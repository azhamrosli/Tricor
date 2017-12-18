Imports DevExpress.Spreadsheet
Imports Microsoft.Office.Interop.Excel
Public Class frmReport_Test
    Dim ErrorLog As clsError = Nothing
    Public ID As String = Nothing
    Private Sub frmReport_Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()

        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub LoadData()
        'Try

        '    Dim dt As DataTable = mdlProcess.Load_CAReport_Temp(ID, ErrorLog)

        '    If dt IsNot Nothing Then
        '        dsCA.Tables("CA_REPORT_TEMP").Rows.Clear()
        '        For i As Integer = 0 To dt.Rows.Count - 1
        '            dsCA.Tables("CA_REPORT_TEMP").ImportRow(dt.Rows(i))
        '        Next

        '        Me.ReportViewer1.RefreshReport()
        '    End If


        'Catch ex As Exception

        'End Try
    End Sub

End Class