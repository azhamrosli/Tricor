Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid
Imports System.Collections

Public Class ucPNL_p1Sales
    Public txtAmount As DevExpress.XtraEditors.TextEdit
    Public SourceNo As DevExpress.XtraBars.BarEditItem
    Public RefNo As String = Nothing
    Public YA As String = Nothing
    Public isEdit As Boolean = False

    Public Const MainTable As String = "PLFST_SALES" 'PLFST_SALES
    Public Const MainTable_Details As String = "PLFST_SALES_DETAIL" 'PLFST_SALES_DETAIL
    Public Const MainKey As String = "PLFS_PLFSKEY" ' PLFS_KEY
    Public Const MainKey_Details As String = "PLFSD_PLFSKEY" 'PLFSD_PLFSKEY
    Public Const MainAmount As String = "PLFS_AMOUNT" 'PLFS_AMOUNT
    Public Const MainAmount_Details As String = "PLFSD_AMOUNT" 'PLFSD_AMOUNT
    Public Const MainSourceNo As String = "PLFS_SOURCENO" 'PLFS_SOURCENO
    Public Const MainSourceNo_Details As String = "PLFSD_SOURCENO" 'PLFS_SOURCENO
    Public Const MainDetail As String = "PLFS_DETAIL"  'PLFS_DETAIL
    Public Const Main_Desc As String = "PLFS_DESC"  'PLFSD_DESC
    Public Const MainDetails_Desc As String = "PLFSD_DESC"  'PLFSD_DESC

    Private _RowInfo As DataRow = Nothing
    Private MainViews As DataSet
    Dim ErrorLog As ClsError = Nothing

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
    Public Property GrdControl() As GridControl
        Get
            Return GridControl1
        End Get
        Set(ByVal value As GridControl)

        End Set
    End Property

    Private Sub ucPNL_p1Sales_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Try
            Dim xx As String = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ucPNLTest_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub


    Public Sub LoadData(Optional ByRef Errorlog As ClsError = Nothing)
        Try
            BUSINESSSOURCEBindingSource.DataSource = DsPNL1.Tables("BUSINESS_SOURCE")
            PLFSTSALESBindingSource.DataSource = DsPNL1.Tables(MainTable)

            If isEdit Then

            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(Errorlog)
        End Try
    End Sub



    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            GridView1.FocusedRowHandle = DevExpress.XtraGrid.GridControl.NewItemRowHandle
            GridView1.FocusedColumn = GridView1.VisibleColumns(0)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

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
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            Dim rslt As DialogResult = MessageBox.Show("Are sure want to remove this item?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If rslt = DialogResult.Yes Then
                Dim dgv As DevExpress.XtraGrid.Views.Grid.GridView
                For i As Integer = 0 To GridView1.RowCount - 1

                    dgv = GridView1.GetDetailView(i, 0)

                    If dgv IsNot Nothing AndAlso i = GridView1.FocusedRowHandle Then
                        dgv.DeleteSelectedRows()
                    ElseIf i = GridView1.FocusedRowHandle Then
                        GridView1.DeleteSelectedRows()
                    End If
                Next
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

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
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub GridView1_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GridView1.ShowingEditor
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)

                Dim dtNote As DataRow = view.GetDataRow(view.FocusedRowHandle)

                If dtNote IsNot Nothing AndAlso IsDBNull(dtNote("PLFS_NOTE")) = False AndAlso dtNote("PLFS_NOTE") = "Dividend income Section 4a" Then
                    e.Cancel = True
                    Exit Sub
                End If

                e.Cancel = mdlPNL.DisableAmountIfGotChild(MainTable_Details, MainKey, MainKey_Details, MainDetail, MainAmount, view, DsPNL1, ErrorLog)


            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

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
                End If
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

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
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

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
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub GridView2_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView2.RowUpdated
        Try
            If mdlPNL.reCalc_SubTotalView(MainTable, MainTable_Details, MainKey, MainKey_Details, _
                                          MainAmount, MainAmount_Details, DsPNL1, ErrorLog) = False Then

                MsgBox("Failed to update." & vbCrLf & ErrorLog.ErrorName & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
            Else
                If MappingSourceNo(MainTable, MainTable_Details, MainKey, MainKey_Details, _
                                          MainSourceNo, MainSourceNo_Details, DsPNL1, ErrorLog) = False Then
                    MsgBox("Failed to update." & vbCrLf & ErrorLog.ErrorName & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                Else
                    CalcTotalofView(txtAmount, DsPNL1, MainTable, MainAmount, 0, ErrorLog)
                End If
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

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
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub


    Private Sub btnExpand_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExpand.ItemClick
        Try
            GridView1.ExpandMasterRow(GridView1.FocusedRowHandle)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        Try
            GridView1.GetDataRow(e.RowHandle)(Main_Desc) = Me.Parent.Text
            GridView1.GetDataRow(e.RowHandle)(MainSourceNo) = SourceNo.EditValue

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnMoveUp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMoveUp.ItemClick
        Try
            mdlPNL.MoveItemsInListView(True, MainTable, MainTable_Details, RefNo, MainKey, MainKey_Details, GridView1, DsPNL1, ErrorLog)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub btnMoveDown_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMoveDown.ItemClick
        Try
            mdlPNL.MoveItemsInListView(False, MainTable, MainTable_Details, RefNo, MainKey, MainKey_Details, GridView1, DsPNL1, ErrorLog)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    

    Private Sub btnNote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNote.ItemClick
        Try
            If _RowInfo Is Nothing Then
                Exit Sub
            End If

            mdlPNL.OpenNoteForm(GridView1, _RowInfo)

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    

End Class
