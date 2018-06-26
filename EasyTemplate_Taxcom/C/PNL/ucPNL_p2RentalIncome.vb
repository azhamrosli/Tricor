Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid
Imports System.Collections

Public Class ucPNL_p2RentalIncome
    Public txtAmount As DevExpress.XtraEditors.TextEdit
    Public SourceNo As DevExpress.XtraBars.BarEditItem
    Public txtSales As DevExpress.XtraEditors.TextEdit
    Public RefNo As String = Nothing
    Public YA As String = Nothing
    Public isEdit As Boolean = False

    Public Const MainTable As String = "RENTAL_INCOME" 'PLFST_SALES
    Public Const MainKey As String = "RI_RENTKEY" ' PLFS_KEY
    Public Const MainAmount As String = "RI_AMOUNT" 'PLFS_AMOUNT
    Public Const MainSourceNo As String = "RI_SOURCENO" 'PLFS_SOURCENO
    Public Const Main_Desc As String = "RI_ADDRESS"

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
            RENTALINCOMEBindingSource.DataSource = DsPNL1.Tables(MainTable)


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

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            Dim rslt As DialogResult = MessageBox.Show("Are sure want to remove this item?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If rslt = DialogResult.Yes Then
                GridView1.DeleteSelectedRows()

                Dim dtRow As DataRow = Nothing
                Dim tmpDs As DataSet = New dsPNL
                Dim ds As DataSet = Nothing

                If doc_p1Sales IsNot Nothing AndAlso doc_p1Sales.Controls.Count > 0 Then
                    Dim contrl As Control = Nothing
                    contrl = doc_p1Sales.Controls(0)

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
                            If IsDBNull(row("PLFS_NOTE")) = True OrElse row("PLFS_NOTE") <> "Rental income Section 4a" Then
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

                For Each row As DataRow In DsPNL1.Tables("RENTAL_INCOME").Rows

                    If row("RI_STATUS4d") = "Section 4a" Then
                        dtRow = Nothing
                        dtRow = dsDataSet.Tables("PLFST_SALES").NewRow
                        dtRow("PLFS_PLFSKEY") = 0
                        dtRow("PLFS_SOURCENO") = row(MainSourceNo)
                        dtRow("PLFS_DESC") = row("RI_ADDRESS")
                        dtRow("PLFS_AMOUNT") = row("RI_AMOUNT")
                        dtRow("PLFS_NOTE") = "Rental income Section 4a"
                        dtRow("PLFS_DETAIL") = "No"
                        dsDataSet.Tables("PLFST_SALES").Rows.Add(dtRow)

                        CalcTotalofView(txtSales, dsDataSet, "PLFST_SALES", "PLFS_AMOUNT", 0, ErrorLog)
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
            CalcTotalofViewRental(txtAmount, DsPNL1, MainTable, MainAmount, 0, ErrorLog)
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
                Else
                    If IsDBNull(row("RI_DATE")) = False AndAlso IsDBNull(row("RI_DATE_END")) = False Then
                        Dim StartDate As DateTime = CDate(row("RI_DATE"))
                        Dim EndDate As DateTime = CDate(row("RI_DATE_END"))

                        If DateDiff(DateInterval.Day, StartDate, EndDate) < 0 Then
                            e.ErrorText = "Start date cannot less than end date."
                            e.Valid = False
                        End If

                        If row("RI_STATUS4d") = "Section 4a" Then
                            Dim dtRow As DataRow = Nothing

                            dtRow = dsDataSet.Tables("PLFST_SALES").NewRow
                            dtRow("PLFS_PLFSKEY") = 0
                            dtRow("PLFS_SOURCENO") = row(MainSourceNo)
                            dtRow("PLFS_DESC") = row("RI_ADDRESS")
                            dtRow("PLFS_AMOUNT") = row("RI_AMOUNT")
                            dtRow("PLFS_NOTE") = "Rental income Section 4a"
                            dtRow("PLFS_DETAIL") = "No"
                            dsDataSet.Tables("PLFST_SALES").Rows.Add(dtRow)

                            CalcTotalofView(txtSales, dsDataSet, "PLFST_SALES", "PLFS_AMOUNT", 0, ErrorLog)
                        End If
                    End If
                     
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
            GridView1.GetDataRow(e.RowHandle)("RI_STATUS4d") = "Section 4d"
            GridView1.GetDataRow(e.RowHandle)("RI_DATE") = Now
            GridView1.GetDataRow(e.RowHandle)("RI_DATE_END") = Now.AddDays(+7)
            GridView1.GetDataRow(e.RowHandle)(MainSourceNo) = SourceNo.EditValue
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub


    Private Sub btnMoveDown_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMoveDown.ItemClick

    End Sub
    Private Sub btnMoveUp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMoveUp.ItemClick

    End Sub
    Private Sub btnDeleteChild_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteChild.ItemClick

    End Sub
    Private Sub btnAddChild_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddChild.ItemClick

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
