Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid
Imports System.Collections

Public Class ucPNL_p2ExemptDividend
    Public txtAmount As DevExpress.XtraEditors.TextEdit
    Public SourceNo As DevExpress.XtraBars.BarEditItem
    Public RefNo As String = Nothing
    Public YA As String = Nothing
    Public isEdit As Boolean = False

    Public Const MainTable As String = "EXEMPT_DIVIDEND" 'PLFST_SALES
    Public Const MainKey As String = "ED_EDKEY" ' PLFS_KEY
    Public Const MainAmount As String = "ED_AMOUNT" 'PLFS_AMOUNT
    Public Const MainSourceNo As String = "ED_SOURCENO" 'PLFS_SOURCENO
    Public Const Main_Desc As String = "ED_COMPANY"

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
            BUSINESSSOURCEBindingSource.DataSource = DsPNL1.Tables("BUSINESS_SOURCE")
            EXEMPTDIVIDENDBindingSource.DataSource = DsPNL1.Tables(MainTable)

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
            CalcTotalofView(txtAmount, DsPNL1, MainTable, MainAmount, 0, ErrorLog)
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
                    If IsDBNull(row("RI_DATE")) = False AndAlso IsDBNull(row("RI_DATE_END")) = False Then
                        Dim StartDate As DateTime = CDate(row("RI_DATE"))
                        Dim EndDate As DateTime = CDate(row("RI_DATE_END"))

                        If DateDiff(DateInterval.Day, StartDate, EndDate) < 0 Then
                            e.ErrorText = "Start date cannot less than end date."
                            e.Valid = False
                        End If
                    End If
                End If
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
            GridView1.GetDataRow(e.RowHandle)("ED_TIERSTATUS") = "First Tier"
            GridView1.GetDataRow(e.RowHandle)("ED_DATE") = Now
            GridView1.GetDataRow(e.RowHandle)(MainSourceNo) = SourceNo.EditValue
        Catch ex As Exception

        End Try
    End Sub


End Class
