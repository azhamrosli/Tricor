Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid
Imports System.Collections

Public Class ucPNL_p3InterestResPurS33
    Public txtAmount As DevExpress.XtraEditors.TextEdit
    Public SourceNo As DevExpress.XtraBars.BarEditItem
    Public RefNo As String = Nothing
    Public YA As String = Nothing

    Public Const MainTable As String = "EXPENSES_INTERESTRESTRICT" 'PLFST_SALES
    Public Const MainTable_Details As String = "REF_INTEREST_RESTRIC_DETAIL" 'PLFST_SALES_DETAIL
    Public Const MainTable_Details_temp As String = "REF_INTEREST_RESTRIC_DETAIL_TEMP" 'PLFST_SALES_DETAIL
    Public Const MainKey As String = "EXIR_EXIRKEY" ' PLFS_KEY
    Public Const MainKey_Details As String = "RIRD_KEY" 'PLFSD_PLFSKEY
    Public Const MainAmount As String = "EXIR_YEAREND" 'PLFS_AMOUNT
    Public Const MainAmount_Details As String = "RIRD_AMOUNT" 'PLFSD_AMOUNT
    Public Const MainSourceNo As String = "EXIR_SOURCENO" 'PLFS_SOURCENO
    Public Const MainDetail As String = "EXIR_DETAIL"  'PLFS_DETAIL
    Public Const MainDetails_Desc As String = "RIRD_DESC"  'PLFSD_DESC
    Public Const Main_Desc As String = "EXIR_DESC"  'PLFSD_DESC
    Public Const Main_Status As String = "EXIR_STATUS"
    Public Const Main_Addback As String = "EXIR_DEDUCTIBLE"  'PLFSD_DESC
    Public Const MainDetails_Addback As String = ""  'PLFSD_DESC
    Public Const Main_Deduct As String = "EXIR_DEDUCTIBLE_ADD"  'PLFSD_DESC
    Public Const MainDetails_Deduct As String = ""  'PLFSD_DESC
    Public Const MainColumn_PercentageAmount As String = "PecentageAmount"
    Public Const MainTable_Monthly As String = "INTEREST_RESTRIC_MONTLY_REPORT"

    Private _RowInfo As DataRow = Nothing
    Private MainViews As DataSet
    Dim ErrorLog As clsError = Nothing
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Property RowInfo As DataRow
        Set(value As DataRow)
            _RowInfo = value
        End Set
        Get
            Return _RowInfo
        End Get
    End Property
    Public Property DataView_Main() As DataSet
        Get
            Return DsPNL1
        End Get
        Set(ByVal value As DataSet)
            DsPNL1 = value
        End Set
    End Property

    Private Sub ucPNLTest_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            LoadData()
        Catch ex As Exception

        End Try
    End Sub


    Public Sub LoadData(Optional ByRef Errorlog As clsError = Nothing)
        Try
            BUSINESSSOURCEBindingSource.DataSource = DsPNL1.Tables("BUSINESS_SOURCE")
            EXPENSESINTERESTRESTRICTBindingSource.DataSource = DsPNL1.Tables(MainTable)

            SplitContainerControl1.Panel2.Controls.Clear()
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            AddListOfError(Errorlog)
        End Try
    End Sub

    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            DoubleClickType()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAddMonthly_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddMonthly.ItemClick
        Try
            DoubleClickType()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Try
            DoubleClickType()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DoubleClickType()
        Try
            Dim row As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)

            If row IsNot Nothing AndAlso IsDBNull(row(MainKey)) = False AndAlso IsDBNull(row(MainSourceNo)) = False Then
                If row("EXIR_STATUS") = "Yearly" Then
                    Dim uc As New ucPNL_p3InterestResPurS33_Yearly
                    uc.DataView_Main = DsPNL1
                    uc.Dock = DockStyle.Fill
                    uc.txtAmount = txtAmount
                    uc.KeyID = row(MainKey)
                    uc.RefNo = RefNo
                    uc.YA = YA
                    uc.SourceNo = CInt(row(MainSourceNo))
                    SplitContainerControl1.Panel2.Controls.Clear()
                    SplitContainerControl1.Panel2.Controls.Add(uc)
                Else
                    Dim uc As New ucPNL_p3InterestResPurS33_Monthly_Tricor
                    uc.DataView_Main = DsPNL1
                    uc.Dock = DockStyle.Fill
                    uc.txtAmount = txtAmount
                    uc.RefNo = RefNo
                    uc.KeyID = row(MainKey)
                    uc.YA = YA
                    uc.SourceNo = CInt(row(MainSourceNo))
                    SplitContainerControl1.Panel2.Controls.Clear()
                    SplitContainerControl1.Panel2.Controls.Add(uc)
                End If


            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        Try

            GridView1.GetDataRow(e.RowHandle)(Main_Status) = "Yearly"
            GridView1.GetDataRow(e.RowHandle)(MainDetail) = "No"
            GridView1.GetDataRow(e.RowHandle)(MainSourceNo) = SourceNo.EditValue
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView1_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView1.RowUpdated
        Try
            If mdlPNL.reCalc_SubTotalView(MainTable, MainTable_Details, MainKey, MainKey_Details, _
                                          MainAmount, MainAmount_Details, DsPNL1, ErrorLog) = False Then

                MsgBox("Failed to delete." & vbCrLf & ErrorLog.ErrorName & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
            Else
                CalcTotalofView(txtAmount, DsPNL1, MainTable, MainAmount, 0, ErrorLog)
                CalcPercentageAmount_Expenses(DsPNL1, MainTable, MainTable_Details, MainKey, MainKey_Details, Main_Addback, Main_Deduct, MainDetails_Addback, MainDetails_Deduct, MainAmount, _
                                  MainAmount_Details, MainColumn_PercentageAmount, ErrorLog)
            End If


        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView1_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GridView1.ShowingEditor
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                e.Cancel = mdlPNL.DisableAmountIfGotChild(MainTable_Details, MainKey, MainKey_Details, MainDetail, view, DsPNL1, ErrorLog)


            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView1.ValidateRow
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.RowHandle)

                If IsDBNull(row(MainSourceNo)) = True OrElse IsDBNull(row(MainAmount)) = True Then
                    e.ErrorText = "Please put amount and source number."
                    e.Valid = False
                Else

                    Dim TotalSourceNo As Integer = 0
                    For i As Integer = 0 To DsPNL1.Tables(MainTable).Rows.Count - 1
                        If DsPNL1.Tables(MainTable).Rows(i)(MainKey) <> e.Row(MainKey) AndAlso DsPNL1.Tables(MainTable).Rows(i)(MainSourceNo) = e.Row(MainSourceNo) Then
                            TotalSourceNo += 1
                        End If
                    Next

                    If TotalSourceNo > 0 Then
                        e.ErrorText = "Cannot have more than one source no in same time."
                        e.Valid = False
                    Else
                        If IsDBNull(row(Main_Status)) = True OrElse row(Main_Status) = "" Then
                            row(Main_Status) = "Yearly"
                        End If

                    End If

                    'If row.RowState = DataRowState.Detached Then


                    'ElseIf row.RowState = DataRowState.Added OrElse row.RowState = DataRowState.Unchanged OrElse row.RowState = DataRowState.Modified Then
                    'End If

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView1_RowDeleted(sender As Object, e As DevExpress.Data.RowDeletedEventArgs) Handles GridView1.RowDeleted
        Try
            If mdlPNL.reCalc_SubTotalView(MainTable, MainTable_Details, MainKey, MainKey_Details, _
                                          MainAmount, MainAmount_Details, DsPNL1, ErrorLog) = False Then
                MsgBox("Failed to delete." & vbCrLf & ErrorLog.ErrorName & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
            Else
                CalcTotalofView(txtAmount, DsPNL1, MainTable, MainAmount, 0, ErrorLog)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            Dim rslt As DialogResult = MessageBox.Show("Are you sure want to remove this item?", "Delete item", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If rslt = DialogResult.Yes Then
                GridView1.DeleteSelectedRows()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Try
            Dim frm As New frmPNL_InterestResPurS33_Monthly
            frm.DataView_Main = dsDataSet
            frm.RefNo = RefNo
            frm.SourceNo = SourceNo.EditValue
            frm.YA = YA
            frm.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnNote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNote.ItemClick
        Try
            If _RowInfo Is Nothing Then
                Exit Sub
            End If

            mdlPNL.OpenNoteForm(GridView1, _RowInfo)

        Catch ex As Exception

        End Try
    End Sub
End Class
