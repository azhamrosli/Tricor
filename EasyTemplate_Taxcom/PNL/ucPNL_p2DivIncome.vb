Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid
Imports System.Collections

Public Class ucPNL_p2DivIncome
    Public txtAmount As DevExpress.XtraEditors.TextEdit
    Public SourceNo As DevExpress.XtraBars.BarEditItem
    Public RefNo As String = Nothing
    Public YA As String = Nothing
    Public isEdit As Boolean = False
    Public txtSales As DevExpress.XtraEditors.TextEdit

    Public Const MainTable As String = "DIVIDEND_INCOME" 'PLFST_SALES
    Public Const MainKey As String = "DI_DIVIDENDKEY" ' PLFS_KEY
    Public Const MainAmount_DI_GROSS As String = "DI_GROSS" 'PLFS_AMOUNT
    Public Const MainAmount_DI_TAX As String = "DI_TAX" 'PLFS_AMOUNT
    Public Const MainAmount_DI_NET As String = "DI_NET" 'PLFSD_AMOUNT
    Public Const MainSourceNo As String = "DI_SOURCENO" 'PLFS_SOURCENO
    Public Const Main_Desc As String = "DI_COMPANY"  'PLFSD_DESC

    Private MainViews As DataSet
    Dim ErrorLog As clsError = Nothing
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Property GetDiscloseNet() As Boolean
        Get
            Return chkDiscloseNet.EditValue
        End Get
        Set(ByVal value As Boolean)

        End Set
    End Property
    Public Property DataView_Main() As DataSet
        Get
            Return MainViews
        End Get
        Set(ByVal value As DataSet)
            MainViews = value
        End Set
    End Property

    Public Property DataView_Main2() As DataSet
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
            DIVIDENDINCOMEBindingSource.DataSource = dsDataSet.Tables("DIVIDEND_INCOME")

            cboSourceNo1.EditValue = SourceNo
            cboTypeofIncome.EditValue = "Single Tier"

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

    Private Sub btnAddChild_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
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

    Private Sub GridView1_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView1.RowUpdated
        Try


            'If mdlPNL.reCalc_SubTotalView(MainTable, MainTable_Details, MainKey, MainKey_Details, _
            '                              MainAmount, MainAmount_Details, DsPNL1, ErrorLog) = False Then

            '    MsgBox("Failed to delete." & vbCrLf & ErrorLog.ErrorName & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
            'Else
            If chkDiscloseNet.EditValue = True Then
                CalcTotalofView(txtAmount, DsPNL1, MainTable, MainAmount_DI_NET, 0, ErrorLog)
            Else
                CalcTotalofView(txtAmount, DsPNL1, MainTable, MainAmount_DI_GROSS, 0, ErrorLog)
            End If

            'End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView1.ValidateRow
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.RowHandle)

                If IsDBNull(row(MainAmount_DI_GROSS)) = True Then
                    e.ErrorText = "Please put amount"
                    e.Valid = False
                ElseIf cboSourceNo1 Is Nothing OrElse cboSourceNo1.EditValue Is Nothing OrElse cboSourceNo1.EditValue.ToString = "" Then
                    e.ErrorText = "Please select source no."
                    e.Valid = False
                ElseIf cboTypeofIncome Is Nothing OrElse cboTypeofIncome.EditValue Is Nothing OrElse cboTypeofIncome.EditValue.ToString = "" Then
                    e.ErrorText = "Please select type of income."
                    e.Valid = False
                Else

                    If IsDBNull(row(MainAmount_DI_TAX)) = True Then
                        row(MainAmount_DI_TAX) = 0
                    End If
                    If row("DI_TRANSFER") = "Single Tier" Then
                        row(MainAmount_DI_TAX) = 0
                    End If
                    row("DI_SOURCENO") = cboSourceNo1.EditValue
                    row("DI_TRANSFER") = cboTypeofIncome.EditValue
                    Application.DoEvents()
                    row(MainAmount_DI_NET) = CDec(row(MainAmount_DI_GROSS)) - CDec(row(MainAmount_DI_TAX))
                    Application.DoEvents()
                    row("DI_TAXDEDUCTION") = CDec(row(MainAmount_DI_TAX))
                    row("DI_NETDEDUCTION") = CDec(row(MainAmount_DI_NET))
                    'FormatNumber((CDbl(txtTaxDed.Text) / CDbl(txtGrossDiv.Text)) * 100, 0).ToString
                    row("DI_TRATE") = ((CDec(row(MainAmount_DI_TAX)) / CDec(row(MainAmount_DI_GROSS))) * 100).ToString("N0")
                    row("DI_TAXRATE") = 0
                    Application.DoEvents()

                    If row("DI_TRANSFER") = "Section 4a" Then

                        Dim dtRow As DataRow = Nothing

                        dtRow = dsDataSet.Tables("PLFST_SALES").NewRow
                        dtRow("PLFS_PLFSKEY") = 0
                        dtRow("PLFS_SOURCENO") = row(MainSourceNo)
                        dtRow("PLFS_DESC") = row(Main_Desc)
                        dtRow("PLFS_AMOUNT") = row(MainAmount_DI_NET)
                        dtRow("PLFS_NOTE") = "Dividend income Section 4a"
                        dtRow("PLFS_DETAIL") = "No"
                        dsDataSet.Tables("PLFST_SALES").Rows.Add(dtRow)

                        CalcTotalofView(txtSales, dsDataSet, "PLFST_SALES", "PLFS_AMOUNT", 0, ErrorLog)
                    End If

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView1_RowDeleted(sender As Object, e As DevExpress.Data.RowDeletedEventArgs) Handles GridView1.RowDeleted
        Try
            Transfer()

            If chkDiscloseNet.EditValue = True Then
                CalcTotalofView(txtAmount, DsPNL1, MainTable, MainAmount_DI_NET, 0, ErrorLog)
            Else
                CalcTotalofView(txtAmount, DsPNL1, MainTable, MainAmount_DI_GROSS, 0, ErrorLog)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExpand_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            GridView1.ExpandMasterRow(GridView1.FocusedRowHandle)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        Try
            GridView1.GetDataRow(e.RowHandle)(Main_Desc) = Me.Parent.Text
            GridView1.GetDataRow(e.RowHandle)("DI_DATE") = Now
            GridView1.GetDataRow(e.RowHandle)("DI_TRANSFER") = "Single Tier"
            GridView1.GetDataRow(e.RowHandle)(MainSourceNo) = SourceNo.EditValue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboTypeofIncome_EditValueChanged(sender As Object, e As EventArgs) Handles cboTypeofIncome.EditValueChanged
        Transfer()
    End Sub
    Private Sub Transfer()
        Try
            Dim dtRow As DataRow = Nothing
            Dim tmpDs As DataSet = New dsPNL
            Dim ds As DataSet = Nothing

            If P1_docSales IsNot Nothing AndAlso P1_docSales.Controls.Count > 0 Then
                Dim contrl As Control = Nothing
                contrl = P1_docSales.Controls(0)

                If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1Sales = False Then
                    Exit Sub
                End If

                Dim uc As ucPNL_p1Sales = CType(contrl, ucPNL_p1Sales)

                ds = uc.DataView_Main
                If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                    Exit Sub
                End If

                If ds IsNot Nothing AndAlso ds.Tables("PLFST_SALES") IsNot Nothing AndAlso ds.Tables("PLFST_SALES").Rows.Count > 0 Then

                    For Each row As DataRow In ds.Tables("PLFST_SALES").Rows
                        If IsDBNull(row("PLFS_NOTE")) = True OrElse row("PLFS_NOTE") <> "Dividend income Section 4a" Then
                            tmpDs.Tables("PLFST_SALES").ImportRow(row)
                        End If
                    Next
                    If tmpDs.Tables("PLFST_SALES").Rows.Count > 0 Then
                        Dim infx As Integer = 0
                        ds.Tables("PLFST_SALES").Rows.Clear()
                        Application.DoEvents()
                        For Each row As DataRow In tmpDs.Tables("PLFST_SALES").Rows
                            'infx += 1
                            'row(uc.MainKey) = infx
                            ds.Tables("PLFST_SALES").ImportRow(row)
                        Next
                    End If
                End If
            End If



            For Each row As DataRow In DsPNL1.Tables("DIVIDEND_INCOME").Rows

                If cboTypeofIncome.EditValue = "Section 4a" Then
                    dtRow = Nothing
                    dtRow = dsDataSet.Tables("PLFST_SALES").NewRow
                    dtRow("PLFS_PLFSKEY") = 0
                    dtRow("PLFS_SOURCENO") = row(MainSourceNo)
                    dtRow("PLFS_DESC") = row(Main_Desc)
                    dtRow("PLFS_AMOUNT") = row(MainAmount_DI_NET)
                    dtRow("PLFS_NOTE") = "Dividend income Section 4a"
                    dtRow("PLFS_DETAIL") = "No"
                    dsDataSet.Tables("PLFST_SALES").Rows.Add(dtRow)

                    CalcTotalofView(txtSales, dsDataSet, "PLFST_SALES", "PLFS_AMOUNT", 0, ErrorLog)
                End If

            Next


        Catch ex As Exception

        End Try
    End Sub
    Private Sub chkDiscloseNet_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles chkDiscloseNet.ItemClick
        Try
            If chkDiscloseNet.EditValue = True Then
                CalcTotalofView(txtAmount, DsPNL1, MainTable, MainAmount_DI_NET, 0, ErrorLog)
            Else
                CalcTotalofView(txtAmount, DsPNL1, MainTable, MainAmount_DI_GROSS, 0, ErrorLog)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
End Class
