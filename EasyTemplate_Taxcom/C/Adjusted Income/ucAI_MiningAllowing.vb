﻿Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class ucAI_MiningAllowing
    Public RefNo As String = Nothing
    Public YA As Integer = Now.Year
    Public txtAmount As DevExpress.XtraEditors.TextEdit
    Public SourceNo As DevExpress.XtraEditors.SearchLookUpEdit
    Public AdjustedIncome As AdjustedIncome
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ucAI_Taxin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If AdjustedIncome Is Nothing Then
                AdjustedIncome = New AdjustedIncome
            End If
            MININGALLOWNANCEBindingSource.DataSource = AdjustedIncome.dsAdjustIncome
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView2_KeyUp(sender As Object, e As KeyEventArgs) Handles GridView1.KeyUp
        Try
            If e.KeyCode = Keys.Delete Then
                btnDelete.PerformClick()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView1_RowDeleted(sender As Object, e As DevExpress.Data.RowDeletedEventArgs) Handles GridView1.RowDeleted
        Try
            AdjustedIncome.TypeSubData = EasyTemplate_Taxcom.AdjustedIncome.EnumTypeSubData.MINING_ALLOWNANCE
            AdjustedIncome.CalcTotalSubData()

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub GridView1_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView1.RowUpdated
        Try
            AdjustedIncome.TypeSubData = EasyTemplate_Taxcom.AdjustedIncome.EnumTypeSubData.MINING_ALLOWNANCE
            AdjustedIncome.CalcTotalSubData()

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

                If IsDBNull(row("MA_AMOUNT")) = True Then
                    e.ErrorText = "Please put amount."
                    e.Valid = False
                End If
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        Try
            GridView1.GetDataRow(e.RowHandle)("MA_DESC") = Me.Parent.Text
            GridView1.GetDataRow(e.RowHandle)("MA_SOURCENO") = SourceNo.EditValue
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try

            GridView1.DeleteSelectedRows()
            AdjustedIncome.dsAdjustIncome.Tables("MINING_ALLOWNANCE").AcceptChanges()

        Catch ex As Exception

        End Try
    End Sub
End Class
