Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid
Imports System.Collections

Public Class ucPNL_p2OtherBizIncome
    Public txtAmount As DevExpress.XtraEditors.TextEdit
    Public RefNo As String = Nothing
    Public YA As String = Nothing
    Public isEdit As Boolean = False

    Public Const MainTable As String = "NONSOURCE_BUSINESSINCOME" 'PLFST_SALES
    Public Const MainTable_Details As String = "NONSOURCE_BUSINESSINCOME_DETAIL" 'PLFST_SALES_DETAIL
    Public Const MainKey As String = "NSBI_NSBIKEY" ' PLFS_KEY
    Public Const MainKey_Details As String = "NSBID_NSBIKEY" 'PLFSD_PLFSKEY
    Public Const MainAmount As String = "NSBI_AMOUNT" 'PLFS_AMOUNT
    Public Const MainAmount_Details As String = "NSBID_AMOUNT" 'PLFSD_AMOUNT
    Public Const MainSourceNo As String = "NSBI_SOURCENO" 'PLFS_SOURCENO
    Public Const MainDetail As String = "NSBI_DETAIL"  'PLFS_DETAIL
    Public Const MainDetails_Desc As String = "NSBID_DESC"  'PLFSD_DESC
    Public Const Main_Desc As String = "NSBI_DESC"  'PLFSD_DESC

    Private MainViews As DataSet
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


            If isEdit Then

            End If

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



    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            GridView1.FocusedRowHandle = DevExpress.XtraGrid.GridControl.NewItemRowHandle
            GridView1.FocusedColumn = GridView1.VisibleColumns(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAddChild_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddChild.ItemClick
        Try
            GridView1.ExpandMasterRow(GridView1.FocusedRowHandle)
            Application.DoEvents()

            Dim dgv As DevExpress.XtraGrid.Views.Grid.GridView = GridView1.GetDetailView(GridView1.FocusedRowHandle, 0)
            dgv.FocusedRowHandle = DevExpress.XtraGrid.GridControl.NewItemRowHandle
            dgv.FocusedColumn = dgv.VisibleColumns(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            Dim rslt As DialogResult = MessageBox.Show("Are sure want to remove this item?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If rslt = DialogResult.Yes Then

                GridView1.DeleteSelectedRows()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDeleteChild_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteChild.ItemClick
        Try
            Dim rslt As DialogResult = MessageBox.Show("Are sure want to remove this item?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If rslt = DialogResult.Yes Then
                Dim dgv As DevExpress.XtraGrid.Views.Grid.GridView
                For i As Integer = 0 To GridView1.RowCount - 1

                    dgv = GridView1.GetDetailView(i, 0)

                    If dgv IsNot Nothing AndAlso i = GridView1.FocusedRowHandle Then
                        dgv.DeleteSelectedRows()
                    End If
                Next
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
                    CalcTotalofView(txtAmount, DsPNL1, MainTable, MainAmount, CDec(row(MainAmount)), ErrorLog)
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
    Private Sub GridView2_RowDeleted(sender As Object, e As DevExpress.Data.RowDeletedEventArgs) Handles GridView2.RowDeleted
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

    Private Sub GridView2_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView2.RowUpdated
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
    Private Sub GridView2_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView2.ValidateRow
        Dim x As String = Nothing
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.RowHandle)

                If IsDBNull(row(MainDetails_Desc)) = True OrElse IsDBNull(row(MainAmount_Details)) = True Then
                    e.ErrorText = "Please put amount and description."
                    e.Valid = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnExpand_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExpand.ItemClick
        Try
            GridView1.ExpandMasterRow(GridView1.FocusedRowHandle)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        Try
            GridView1.GetDataRow(e.RowHandle)(Main_Desc) = Me.Parent.Text

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMoveUp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMoveUp.ItemClick
        Try
            mdlPNL.MoveItemsInListView(True, MainTable, MainTable_Details, RefNo, MainKey, MainKey_Details, GridView1, DsPNL1, ErrorLog)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMoveDown_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMoveDown.ItemClick
        Try
            mdlPNL.MoveItemsInListView(False, MainTable, MainTable_Details, RefNo, MainKey, MainKey_Details, GridView1, DsPNL1, ErrorLog)
        Catch ex As Exception

        End Try
    End Sub

End Class
