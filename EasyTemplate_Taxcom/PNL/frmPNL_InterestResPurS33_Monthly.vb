Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository

Public Class frmPNL_InterestResPurS33_Monthly
    Public ID_PNL As Decimal = 0
    Public RefNo As String = Nothing
    Public YA As String = Nothing
    Public SourceNo As Integer = 0
    Public isEdit As Boolean = False
    Public txtAmount As DevExpress.XtraEditors.TextEdit
    Dim ErrorLog As clsError = Nothing

    Public Const MainTable As String = "EXPENSES_INTERESTRESTRICT" 'PLFST_SALES
    Public Const MainTable_Details As String = "REF_INTEREST_RESTRIC_DETAIL" 'PLFST_SALES_DETAIL
    Public Const MainKey As String = "EXIR_EXIRKEY" ' PLFS_KEY
    Public Const MainKey_Details As String = "RIRD_KEY" 'PLFSD_PLFSKEY
    Public Const MainAmount As String = "EXIR_YEAREND" 'PLFS_AMOUNT
    Public Const MainAmount_Details As String = "RIRD_AMOUNT" 'PLFSD_AMOUNT
    Public Const MainSourceNo As String = "EXIR_SOURCENO" 'PLFS_SOURCENO
    Public Const MainDetail As String = "EXIR_DETAIL"  'PLFS_DETAIL
    Public Const MainDetails_Desc As String = "RIRD_DESC"  'PLFSD_DESC
    Public Const Main_Desc As String = "EXIR_DESC"  'PLFSD_DESC
    Dim MainDs As DataSet = Nothing
    Public Property DataView_Main() As DataSet
        Get
            Return DsPNL
        End Get
        Set(ByVal value As DataSet)
            DsPNL = value
        End Set
    End Property

    Private Sub frmPNL_InterestResPurS33_Yearly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadData()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub LoadData(Optional ByRef Errorlog As clsError = Nothing)
        Try

            ' mdlPNL.GetColumn_InterestRestrictMonthly(RefNo, YA, SourceNo, DsPNL, GridView1)

            Dim clm As System.Data.DataColumn
            Dim col As DevExpress.XtraGrid.Columns.GridColumn
            Dim txt As RepositoryItemTextEdit
            Dim Memo As RepositoryItemMemoEdit
            Dim cbo As RepositoryItemComboBox
            Dim infx As Integer = 0
            GridView1.Columns.Clear()
            DsPNL.Tables("REF_INTEREST_RESTRIC_TMP").Columns.Clear()

            clm = New System.Data.DataColumn
            clm.ColumnName = "RIRD_KEY"
            clm.Caption = "KEY"
            clm.DataType = Type.GetType("System.Int32")
            clm.AllowDBNull = True
            DsPNL.Tables("REF_INTEREST_RESTRIC_TMP").Columns.Add(clm)

            col = New DevExpress.XtraGrid.Columns.GridColumn
            col.Caption = "KEY"
            col.Name = "RIRD_KEY"
            col.VisibleIndex = infx
            col.Visible = False
            col.Width = 0
            col.FieldName = "RIRD_KEY"
            GridView1.Columns.Add(col)

            '-==============================================

            clm = New System.Data.DataColumn
            clm.ColumnName = "RIR_REF_NUM"
            clm.Caption = "RefNo"
            clm.DataType = Type.GetType("System.String")
            clm.MaxLength = 30
            clm.AllowDBNull = True
            DsPNL.Tables("REF_INTEREST_RESTRIC_TMP").Columns.Add(clm)
            infx += 1
            col = New DevExpress.XtraGrid.Columns.GridColumn
            col.Caption = "RefNo"
            col.Name = "RIR_REF_NUM"
            col.VisibleIndex = infx
            col.Visible = False
            col.Width = 0
            col.FieldName = "RIR_REF_NUM"
            GridView1.Columns.Add(col)

            '-==============================================

            clm = New System.Data.DataColumn
            clm.ColumnName = "RIRD_MONTH"
            clm.Caption = "RefNo"
            clm.DataType = Type.GetType("System.String")
            clm.AllowDBNull = True
            DsPNL.Tables("REF_INTEREST_RESTRIC_TMP").Columns.Add(clm)
            infx += 1
            col = New DevExpress.XtraGrid.Columns.GridColumn
            col.Caption = "RefNo"
            col.Name = "RIRD_MONTH"
            col.VisibleIndex = infx
            col.Visible = False
            col.Width = 0
            col.FieldName = "RIRD_MONTH"
            GridView1.Columns.Add(col)

            '-==============================================

            clm = New System.Data.DataColumn
            clm.ColumnName = "RIRD_SOURCENO"
            clm.Caption = "Source No"
            clm.DataType = Type.GetType("System.Int32")
            clm.AllowDBNull = True
            DsPNL.Tables("REF_INTEREST_RESTRIC_TMP").Columns.Add(clm)
            infx += 1
            col = New DevExpress.XtraGrid.Columns.GridColumn
            col.Caption = "Source No"
            col.Name = "RIRD_SOURCENO"
            col.VisibleIndex = infx
            col.Visible = False
            col.Width = 0
            col.FieldName = "RIRD_SOURCENO"
            GridView1.Columns.Add(col)

            '-==============================================

            clm = New System.Data.DataColumn
            clm.ColumnName = "RIRD_DESC"
            clm.Caption = "Description"
            clm.DataType = Type.GetType("System.String")
            clm.AllowDBNull = True
            DsPNL.Tables("REF_INTEREST_RESTRIC_TMP").Columns.Add(clm)
            infx += 1
            col = New DevExpress.XtraGrid.Columns.GridColumn
            col.Caption = "Description"
            col.Name = "RIRD_DESC"
            col.VisibleIndex = infx
            col.Visible = True
            col.Width = 300
            col.FieldName = "RIRD_DESC"
            GridView1.Columns.Add(col)

            '-==============================================

            clm = New System.Data.DataColumn
            clm.ColumnName = "RIRD_TYPE"
            clm.Caption = "Type"
            clm.DataType = Type.GetType("System.String")
            clm.AllowDBNull = True
            DsPNL.Tables("REF_INTEREST_RESTRIC_TMP").Columns.Add(clm)
            infx += 1
            col = New DevExpress.XtraGrid.Columns.GridColumn
            col.Caption = "Type"
            col.Name = "RIRD_TYPE"
            col.VisibleIndex = infx
            cbo = Nothing
            cbo = New RepositoryItemComboBox
            cbo.Items.Add("Investment")
            cbo.Items.Add("Borrowing")
            cbo.Items.Add("Interest")
            col.ColumnEdit = cbo
            col.Visible = True
            col.Width = 200
            col.FieldName = "RIRD_TYPE"
            GridView1.Columns.Add(col)

            '-==============================================

            clm = New System.Data.DataColumn
            clm.ColumnName = "RIRD_AMOUNT"
            clm.Caption = "Amount"
            clm.DataType = Type.GetType("System.String")
            clm.AllowDBNull = True
            DsPNL.Tables("REF_INTEREST_RESTRIC_TMP").Columns.Add(clm)
            infx += 1
            col = New DevExpress.XtraGrid.Columns.GridColumn
            col.Caption = "Amount"
            col.Name = "RIRD_AMOUNT"
            col.VisibleIndex = infx
            txt = New RepositoryItemTextEdit
            txt.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            txt.Mask.EditMask = "c"
            txt.Mask.UseMaskAsDisplayFormat = True
            col.ColumnEdit = txt
            col.Visible = True
            col.Width = 120
            col.FieldName = "RIRD_AMOUNT"
            GridView1.Columns.Add(col)

            '-==============================================

            clm = New System.Data.DataColumn
            clm.ColumnName = "RIRD_TYPE_INCOME"
            clm.Caption = "Type of Income"
            clm.DataType = Type.GetType("System.String")
            clm.AllowDBNull = True
            DsPNL.Tables("REF_INTEREST_RESTRIC_TMP").Columns.Add(clm)
            infx += 1
            col = New DevExpress.XtraGrid.Columns.GridColumn
            col.Caption = "Type of Income"
            col.Name = "RIRD_TYPE_INCOME"
            col.VisibleIndex = infx
            cbo = Nothing
            cbo = New RepositoryItemComboBox
            cbo.Items.Add("INTEREST INCOME")
            cbo.Items.Add("DIVIDEND INCOME")
            cbo.Items.Add("RENTAL INCOME")
            cbo.Items.Add("NON-INCOME PRODUCING")

            col.ColumnEdit = cbo
            col.Visible = True
            col.Width = 200
            col.FieldName = "RIRD_TYPE_INCOME"
            GridView1.Columns.Add(col)

            '-==============================================

            clm = New System.Data.DataColumn
            clm.ColumnName = "RIRD_NOTE"
            clm.Caption = "Note"
            clm.DataType = Type.GetType("System.String")
            clm.AllowDBNull = True
            DsPNL.Tables("REF_INTEREST_RESTRIC_TMP").Columns.Add(clm)
            infx += 1
            col = New DevExpress.XtraGrid.Columns.GridColumn
            col.Caption = "Remarks"
            col.Name = "RIRD_NOTE"
            col.VisibleIndex = infx
            Memo = New RepositoryItemMemoEdit
            Memo.MaxLength = 3000
            col.ColumnEdit = Memo
            col.Visible = True
            col.Width = 300
            col.FieldName = "RIRD_NOTE"
            GridView1.Columns.Add(col)


            '' DsPNL = MainDs
            'BUSINESSSOURCEBindingSource.DataSource = DsPNL.Tables("BUSINESS_SOURCE")
            'EXPENSESINTERESTRESTRICTBindingSource.DataSource = DsPNL.Tables("EXPENSES_INTERESTRESTRICT")

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

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
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
                                          MainAmount, MainAmount_Details, DsPNL, ErrorLog) = False Then

                MsgBox("Failed to delete." & vbCrLf & ErrorLog.ErrorName & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
            Else
                CalcTotalofView(txtAmount, DsPNL, MainTable, MainAmount, 0, ErrorLog)
            End If


        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView1_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GridView1.ShowingEditor
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                e.Cancel = mdlPNL.DisableAmountIfGotChild(MainTable_Details, MainKey, MainKey_Details, MainDetail, view, DsPNL, ErrorLog)


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
                    For i As Integer = 0 To DsPNL.Tables(MainTable).Rows.Count - 1
                        If DsPNL.Tables(MainTable).Rows(i)(MainSourceNo) = e.Row(MainSourceNo) Then
                            TotalSourceNo += 1
                        End If
                    Next

                    If TotalSourceNo > 0 Then
                        e.ErrorText = "Cannot have more than one source no in same time."
                        e.Valid = False
                    Else
                        row("EXIR_STATUS") = "Yearly"
                    End If

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView1_RowDeleted(sender As Object, e As DevExpress.Data.RowDeletedEventArgs) Handles GridView1.RowDeleted
        Try
            If mdlPNL.reCalc_SubTotalView(MainTable, MainTable_Details, MainKey, MainKey_Details, _
                                          MainAmount, MainAmount_Details, DsPNL, ErrorLog) = False Then

                MsgBox("Failed to delete." & vbCrLf & ErrorLog.ErrorName & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
            Else
                CalcTotalofView(txtAmount, DsPNL, MainTable, MainAmount, 0, ErrorLog)
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView2_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView2.InitNewRow
        Try
            If TypeOf sender Is DevExpress.XtraGrid.Views.Grid.GridView Then
                Dim dgv As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                dgv.GetDataRow(dgv.FocusedRowHandle)("RIRD_TYPE") = "Investment"
                dgv.GetDataRow(dgv.FocusedRowHandle)("RIRD_TYPE_INCOME") = "INTEREST INCOME"
            End If


        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView2_RowDeleted(sender As Object, e As DevExpress.Data.RowDeletedEventArgs) Handles GridView2.RowDeleted
        Try
            If mdlPNL.reCalc_SubTotalView(MainTable, MainTable_Details, MainKey, MainKey_Details, _
                                         MainAmount, MainAmount_Details, DsPNL, ErrorLog) = False Then

                MsgBox("Failed to delete." & vbCrLf & ErrorLog.ErrorName & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
            Else
                CalcTotalofView(txtAmount, DsPNL, MainTable, MainAmount, 0, ErrorLog)
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView2_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView2.RowUpdated
        Try
            If mdlPNL.reCalc_SubTotalView(MainTable, MainTable_Details, MainKey, MainKey_Details, _
                                          MainAmount, MainAmount_Details, DsPNL, ErrorLog) = False Then

                MsgBox("Failed to delete." & vbCrLf & ErrorLog.ErrorName & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
            Else
                CalcTotalofView(txtAmount, DsPNL, MainTable, MainAmount, 0, ErrorLog)
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
            mdlPNL.MoveItemsInListView(True, MainTable, MainTable_Details, RefNo, MainKey, MainKey_Details, GridView1, DsPNL, ErrorLog)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMoveDown_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMoveDown.ItemClick
        Try
            mdlPNL.MoveItemsInListView(False, MainTable, MainTable_Details, RefNo, MainKey, MainKey_Details, GridView1, DsPNL, ErrorLog)
        Catch ex As Exception

        End Try
    End Sub
End Class