Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid
Imports System.Collections

Public Class ucPNL_p3InterestResPurS33_Yearly
    Public txtAmount As DevExpress.XtraEditors.TextEdit
    Public SourceNo As Integer = 0
    Public RefNo As String = Nothing
    Public YA As String = Nothing
    Public KeyID As Integer = 0
    Public Amount As Decimal = 0
    Public isEdit As Boolean = False

    Public Const MainTable As String = "EXPENSES_INTERESTRESTRICT" 'PLFST_SALES
    Public Const MainTable_Details As String = "REF_INTEREST_RESTRIC_DETAIL" 'PLFST_SALES_DETAIL
    Public Const MainKey As String = "EXIR_EXIRKEY" ' PLFS_KEY
    Public Const MainKey_Details As String = "RIRD_KEY" 'PLFSD_PLFSKEY
    Public Const MainAmount As String = "EXIR_YEAREND" 'PLFS_AMOUNT
    Public Const MainAmount_Details As String = "RIRD_AMOUNT" 'PLFSD_AMOUNT
    Public Const MainSourceNo As String = "EXIR_SOURCENO" 'PLFS_SOURCENO
    Public Const MainSourceNo_Details As String = "RIRD_SOURCENO" 'PLFS_SOURCENO
    Public Const MainDetail As String = "EXIR_DETAIL"  'PLFS_DETAIL
    Public Const MainDetails_Desc As String = "RIRD_DESC"  'PLFSD_DESC
    Public Const Main_Desc As String = "EXIR_DESC"  'PLFSD_DESC
    Public Const Main_Type As String = "RIRD_TYPE"  'PLFSD_DESC
    Public Const Main_TypeofIncome As String = "RIRD_TYPE_INCOME"  'PLFSD_DESC

    Dim MainDataset As DataSet = Nothing
    Dim ErrorLog As clsError = Nothing
    Public Sub New()
        InitializeComponent()
    End Sub
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

            mdlProcess.CreateLookUpSourceNO(DsPNL1, RefNo, YA, "BUSINESS_SOURCE", Errorlog)

            Dim dt As DataTable = Nothing

            dt = mdlProcess.Load_REF_INTEREST_RESTRIC_DETAIL_YEARLY(SourceNo, RefNo, YA, Errorlog)
            If dt Is Nothing Then
                dt = mdlProcess.Load_REF_INTEREST_RESTRIC_DETAIL_TEMP(SourceNo, RefNo, YA, Errorlog)
            End If


            DsPNL1.Tables(MainTable_Details).Rows.Clear()
            If dt IsNot Nothing Then

                For Each row As DataRow In dt.Rows
                    DsPNL1.Tables(MainTable_Details).ImportRow(row)
                Next

            End If

            REFINTERESTRESTRICDETAILBindingSource.DataSource = DsPNL1.Tables(MainTable_Details)
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
        End Try
    End Sub
    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            If DsPNL1.Tables(MainTable_Details).Rows.Count > 0 Then
                Dim Amount_tmp As Decimal = 0
                If mdlProcess.Save_REF_INTEREST_RESTRIC_DETAIL_TEMP(DsPNL1.Tables(MainTable_Details), RefNo, YA, SourceNo, KeyID, _
                                                                    Amount_tmp, ErrorLog) = False Then
                    MsgBox("Unsuccessfully save your data.", MsgBoxStyle.Critical)
                Else
                    Amount = Amount_tmp
                    For Each row As DataRow In MainDataset.Tables(MainTable).Rows
                        If IsDBNull(row(MainKey)) = False AndAlso row(MainKey) = KeyID Then
                            row(MainAmount) = Amount
                        End If
                    Next
                    MsgBox("Successfully saved your data.", MsgBoxStyle.Information)
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        Try
            GridView1.GetDataRow(e.RowHandle)(Main_Type) = "Investment"
            GridView1.GetDataRow(e.RowHandle)(Main_TypeofIncome) = "INTEREST INCOME"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView1.ValidateRow
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.RowHandle)

                If IsDBNull(row(MainDetails_Desc)) = True OrElse IsDBNull(row(MainAmount_Details)) = True Then
                    e.ErrorText = "Please put amount and source number."
                    e.Valid = False
                Else
                    row(MainSourceNo_Details) = SourceNo
                    row(MainKey_Details) = KeyID
                End If
            End If
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
End Class
