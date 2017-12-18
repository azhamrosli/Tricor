Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid.Drawing
Imports DevExpress.XtraGrid.Helpers
Imports DevExpress.XtraPrinting

Public Class frmPNL_Report
    Dim ErrorLog As clsError = Nothing
    Public RefNo As String = Nothing
    Public YA As String = "0"
    Private Sub frmPNL_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Try
            Dim ID As String = Nothing
            If mdlPNL2.PNL_GenerateReport(RefNo, YA, ID, ErrorLog) = False Then
                MsgBox("Failed to generate profit and loss report.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Dim dt As DataTable = mdlProcess.Load_PNLReport_ByID(ID, ErrorLog)

            DsPNL2.Tables("PROFIT_LOSS_ACCOUNT_REPORT_TEMP").Rows.Clear()
            If dt IsNot Nothing Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    DsPNL2.Tables("PROFIT_LOSS_ACCOUNT_REPORT_TEMP").ImportRow(dt.Rows(i))
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridControl1_Paint(sender As Object, e As PaintEventArgs) Handles GridControl1.Paint
        Try
            Dim grid As GridControl = TryCast(sender, GridControl)
            Dim view As GridView = TryCast(grid.FocusedView, GridView)
            Dim info As GridViewInfo = TryCast(view.GetViewInfo(), GridViewInfo)

            Dim colRect As Rectangle = info.ColumnsInfo(BandedGridView1.Columns(2)).Bounds


            Dim lineRect As New Rectangle(colRect.Right - 1, colRect.Y, 1, info.ViewRects.Rows.Height + colRect.Height)
            e.Graphics.FillRectangle(Brushes.Red, lineRect)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BandedGridView1_CustomDrawCell(sender As Object, e As Views.Base.RowCellCustomDrawEventArgs) Handles BandedGridView1.CustomDrawCell
        Try
            Dim dtRow As DataRow = BandedGridView1.GetDataRow(e.RowHandle)
            If dtRow IsNot Nothing Then
                If IsDBNull(dtRow("TypeRow")) = False Then
                    Select Case CInt(dtRow("TypeRow"))
                        Case 0
                            'Title
                            e.Appearance.Font = New Font("Tahoma", 10, FontStyle.Bold)
                        Case 1
                            'Sub Total
                            If IsDBNull(dtRow("LeftAmount")) = False AndAlso e.Column.FieldName = "LeftAmount" Then
                                Dim R As Rectangle = e.Bounds
                                e.Graphics.DrawLine(Pens.Black, R.Right, R.Top, R.X - 1, R.Y)
                                e.Appearance.DrawString(e.Cache, e.DisplayText, R)
                                e.Handled = True
                            End If
                            If IsDBNull(dtRow("RightAmount")) = False AndAlso e.Column.FieldName = "RightAmount" Then
                                Dim R As Rectangle = e.Bounds
                                e.Graphics.DrawLine(Pens.Black, R.Right, R.Top, R.X - 1, R.Y)
                                e.Appearance.DrawString(e.Cache, e.DisplayText, R)
                                e.Handled = True
                            End If
                        Case 2
                            'Total
                            If IsDBNull(dtRow("LeftAmount")) = False AndAlso e.Column.FieldName = "LeftAmount" Then
                                Dim R As Rectangle = e.Bounds
                                e.Graphics.DrawLine(Pens.Black, R.Left - 1, R.Bottom, R.Right, R.Bottom)
                                e.Graphics.DrawLine(Pens.Black, R.Right, R.Top, R.X - 1, R.Y)
                                e.Appearance.DrawString(e.Cache, e.DisplayText, R)
                                e.Handled = True
                            End If
                            If IsDBNull(dtRow("RightAmount")) = False AndAlso e.Column.FieldName = "RightAmount" Then
                                Dim R As Rectangle = e.Bounds
                                e.Graphics.DrawLine(Pens.Black, R.Left - 1, R.Bottom, R.Right, R.Bottom)
                                e.Graphics.DrawLine(Pens.Black, R.Right, R.Top, R.X - 1, R.Y)
                                e.Appearance.DrawString(e.Cache, e.DisplayText, R)
                                e.Handled = True
                            End If
                            e.Appearance.Font = New Font("Tahoma", 10, FontStyle.Bold)

                        Case 3

                    End Select

                End If
            End If




            'Dim view As GridView = TryCast(sender, GridView)
            'If e.Column Is view.FocusedColumn AndAlso e.RowHandle = view.FocusedRowHandle Then
            '    CellDrawHelper.DoDefaultDrawCell(view, e)
            '    CellDrawHelper.DrawCellBorder(e)
            '    e.Handled = True
            'End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BandedGridView1_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles BandedGridView1.RowCellStyle
        'Try
        '    Dim dtRow As DataRow = BandedGridView1.GetDataRow(e.RowHandle)

        '    If dtRow IsNot Nothing Then

        '        If IsDBNull(dtRow("TypeRow")) = False Then

        '            Select Case CInt(dtRow("TypeRow"))
        '                Case 0
        '                    'Title
        '                    e.Appearance.Font = New Font("Tahoma", 10, FontStyle.Bold)

        '                Case 1
        '                    'SUBTOTAL+
        '                    e.Appearance.Font = New Font("Tahoma", 10, FontStyle.Underline)

        '                Case 2
        '                    'TOTAL


        '                Case 3
        '                    'NORMAL

        '            End Select
        '        End If

        '    End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
        Try
            Dim rslt As DialogResult = FolderBrowserDialog1.ShowDialog

            If rslt = Windows.Forms.DialogResult.OK Then
                Dim Path As String = FolderBrowserDialog1.SelectedPath
                Dim opt As New XlsxExportOptionsEx()
                AddHandler opt.CustomizeCell, AddressOf opt_CustomizeCell
                GridControl1.ExportToXlsx(Path & "\PNL_REPORT_" & Format(Now, "ddMMMyyyyHHmmss") & ".xlsx", opt)
            End If



        Catch ex As Exception

        End Try
    End Sub
    Private Sub opt_CustomizeCell(ByVal e As DevExpress.Export.CustomizeCellEventArgs)
        '  ColorizeCell(e.ColumnFieldName, e.RowHandle, e.Formatting)
        e.Handled = True
    End Sub
End Class

'Public NotInheritable Class CellDrawHelper

'    Private Sub New()
'    End Sub

'    Public Shared Sub DrawCellBorder(ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs)
'        Dim brush As Brush = Brushes.Black
'        e.Cache.FillRectangle(brush, New Rectangle(e.Bounds.X - 1, e.Bounds.Y - 1, e.Bounds.Width + 2, 2))
'        e.Cache.FillRectangle(brush, New Rectangle(e.Bounds.Right - 1, e.Bounds.Y - 1, 2, e.Bounds.Height + 2))
'        e.Cache.FillRectangle(brush, New Rectangle(e.Bounds.X - 1, e.Bounds.Bottom - 1, e.Bounds.Width + 2, 2))
'        e.Cache.FillRectangle(brush, New Rectangle(e.Bounds.X - 1, e.Bounds.Y - 1, 2, e.Bounds.Height + 2))
'    End Sub

'    Public Shared Sub DoDefaultDrawCell(ByVal view As GridView, ByVal e As RowCellCustomDrawEventArgs)
'        e.Appearance.FillRectangle(e.Cache, e.Bounds)
'        CType(view.GridControl, IViewController).EditorHelper.DrawCellEdit(New GridViewDrawArgs(e.Cache, (TryCast(view.GetViewInfo(), GridViewInfo)), e.Bounds), (TryCast(e.Cell, GridCellInfo)).Editor, (TryCast(e.Cell, GridCellInfo)).ViewInfo, e.Appearance, (TryCast(e.Cell, GridCellInfo)).CellValueRect.Location)
'    End Sub
'End Class