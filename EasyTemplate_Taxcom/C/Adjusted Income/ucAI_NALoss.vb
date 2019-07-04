Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class ucAI_NALoss

    Public RefNo As String = Nothing
    Public YA As Integer = Now.Year
    Public txtAmount As DevExpress.XtraEditors.TextEdit
    Public SourceNo As DevExpress.XtraEditors.SearchLookUpEdit
    Public AdjustedIncome As AdjustedIncome = Nothing
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
       
    End Sub

    Private Sub GridView2_KeyUp(sender As Object, e As KeyEventArgs) Handles GridView2.KeyUp
        Try
            If e.KeyCode = Keys.Delete Then
                btnDelete.PerformClick()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView1_RowDeleted(sender As Object, e As DevExpress.Data.RowDeletedEventArgs) Handles GridView2.RowDeleted
        Try
            AdjustedIncome.TypeSubData = EasyTemplate_Taxcom.AdjustedIncome.EnumTypeSubData.NON_ALLOW_LOSS
            AdjustedIncome.CalcTotalSubData()

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub GridView1_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView2.RowUpdated
        Try
            AdjustedIncome.TypeSubData = EasyTemplate_Taxcom.AdjustedIncome.EnumTypeSubData.NON_ALLOW_LOSS
            AdjustedIncome.CalcTotalSubData()

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub GridView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView2.ValidateRow
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.RowHandle)

                If IsDBNull(row("NL_AMOUNT")) = True Then
                    e.ErrorText = "Please put amount."
                    e.Valid = False
                End If

            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView2.InitNewRow
        Try
            GridView2.GetDataRow(e.RowHandle)("NL_DESC") = Me.Parent.Text
            GridView2.GetDataRow(e.RowHandle)("NL_SOURCENO") = SourceNo.EditValue
            GridView2.GetDataRow(e.RowHandle)("NL_CATEGORIZED") = ""
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try

            GridView2.DeleteSelectedRows()
            AdjustedIncome.dsAdjustIncome.Tables("NON_ALLOW_LOSS").AcceptChanges()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ucAI_NALoss_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If AdjustedIncome Is Nothing Then
                AdjustedIncome = New AdjustedIncome
            End If

            BindingSource1.DataSource = AdjustedIncome.dsAdjustIncome.Tables("NON_ALLOW_LOSS")
        Catch ex As Exception

        End Try
    End Sub
End Class
