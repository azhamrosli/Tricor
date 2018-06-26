Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid
Imports System.Collections

Public Class ucPNL_p2InterestIncome
    Public SourceNo As DevExpress.XtraBars.BarEditItem
    Public RefNo As DevExpress.XtraBars.BarEditItem
    Public AllowAllGroupExpanded As DevExpress.XtraBars.BarEditItem

    Public YA As DevExpress.XtraBars.BarEditItem
    Public isEdit As Boolean = False
    Public dtParent As DataRow = Nothing

    Dim ErrorLog As clsError = Nothing
    Public Sub New()
        InitializeComponent()

        GridView1.OptionsDetail.AllowOnlyOneMasterRowExpanded = Setting_AllowAllGroupExpand
    End Sub
    Public Property DataView_Main() As dsPNL
        Get
            Return clsPNL_.ds_p2InterestIncome
        End Get
        Set(ByVal value As dsPNL)
            clsPNL_.ds_p2InterestIncome = value
        End Set
    End Property
    Public Property DataView_Default() As dsDefault
        Get
            Return DsDefault
        End Get
        Set(ByVal value As dsDefault)
            DsDefault = value
        End Set
    End Property
    Public Property GrdControl() As GridControl
        Get
            Return GridControl1
        End Get
        Set(ByVal value As GridControl)

        End Set
    End Property

    Private Sub ucPNLTest_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            LoadData()
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub


    Public Sub LoadData(Optional ByRef Errorlog As clsError = Nothing)
        Try

            BusinessSourceBindingSource.DataSource = DsDefault.Tables("Business_Source")
            PLINCOMENONBUSINESSBindingSource.DataSource = clsPNL_.ds_p2InterestIncome.Tables(dtParent("TableName"))

            Dim filterString As String = dtParent("ColumnOldKey") & " = " & CStr(dtParent("OldKey"))

            GridView1.Columns(dtParent("ColumnOldKey")).FilterInfo = New ColumnFilterInfo(filterString)

        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
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
#Region "BUTTON"
    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
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

                GridView1.DeleteSelectedRows()

            End If
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

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
    Private Sub btnMoveUp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMoveUp.ItemClick
        Try
            clsPNL_.MoveItemsInListView(True, dtParent, RefNo.EditValue, GridView1, clsPNL_.ds_p2InterestIncome, ErrorLog)
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnMoveDown_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMoveDown.ItemClick
        Try
            clsPNL_.MoveItemsInListView(False, dtParent, RefNo.EditValue, GridView1, clsPNL_.ds_p2InterestIncome, ErrorLog)
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub
#End Region
#Region "GRIDVIEW"
    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                view.GetDataRow(e.RowHandle)(dtParent("PrefixName") & "_KEY") = 1
                view.GetDataRow(e.RowHandle)(dtParent("ColumnOldKey")) = dtParent("OldKey")
                view.GetDataRow(e.RowHandle)(dtParent("PrefixName") & "_DESC") = dtParent("Description")
                view.GetDataRow(e.RowHandle)(dtParent("ColumnAmount")) = 0
            End If
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub GridView1_RowDeleted(sender As Object, e As DevExpress.Data.RowDeletedEventArgs) Handles GridView1.RowDeleted
        UpdateCalculation()
    End Sub

    Private Sub GridView1_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView1.RowUpdated
        Try

            UpdateCalculation()

        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try

    End Sub
    Private Sub UpdateCalculation()
        Try
            Try
                If clsPNL_.reCalc_SubTotalView(dtParent, clsPNL_.ds_p2InterestIncome, ErrorLog) = False Then

                    MsgBox("Failed to Update." & vbCrLf & ErrorLog.ErrorName & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                Else
                    clsPNL_.CalcTotalofView(dtParent, clsPNL_.ds_p2InterestIncome, 0, ErrorLog)
                End If
            Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

            End Try
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub GridView1_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GridView1.ShowingEditor
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                e.Cancel = clsPNL_.DisableAmountIfGotChild(dtParent, view, clsPNL_.ds_p2InterestIncome, ErrorLog)
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
                If row IsNot Nothing Then
                    row(dtParent("ColumnOldKey")) = dtParent("OldKey")

                    If IsDBNull(row(dtParent("ColumnOldKey"))) = True OrElse IsDBNull(row(dtParent("ColumnOldKey"))) = True Then
                        e.ErrorText = "Please put amount and source number."
                        e.Valid = False
                    End If
                End If

            End If

        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub GridView2_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView2.InitNewRow
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                view.GetDataRow(e.RowHandle)(dtParent("ColumnKey_Details")) = GridView1.GetRowCellValue(view.SourceRowHandle, dtParent("ColumnKey"))
                view.GetDataRow(e.RowHandle)(dtParent("ColumnSource_Details")) = GridView1.GetRowCellValue(view.SourceRowHandle, dtParent("ColumnSource"))
                view.GetDataRow(e.RowHandle)(dtParent("ColumnOldKey_Details")) = dtParent("OldKey")
                view.GetDataRow(e.RowHandle)(dtParent("ColumnAmount_Details")) = 0
            End If
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub GridView2_RowDeleted(sender As Object, e As DevExpress.Data.RowDeletedEventArgs) Handles GridView2.RowDeleted
        UpdateCalculation_Details()
    End Sub
    Private Sub GridView2_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView2.RowUpdated
        UpdateCalculation_Details()
    End Sub
    Private Sub UpdateCalculation_Details()
        Try
            If clsPNL_.reCalc_SubTotalView(dtParent, clsPNL_.ds_p2InterestIncome, ErrorLog) = False Then

                MsgBox("Failed to Update." & vbCrLf & ErrorLog.ErrorName & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
            Else
                If clsPNL_.MappingSourceNo(dtParent, clsPNL_.ds_p2InterestIncome, ErrorLog) = False Then
                    MsgBox("Failed to update." & vbCrLf & ErrorLog.ErrorName & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                Else
                    clsPNL_.CalcTotalofView(dtParent, clsPNL_.ds_p2InterestIncome, 0, ErrorLog)
                End If
            End If

        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub

#End Region


End Class
