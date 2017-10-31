Imports DevExpress.Spreadsheet
Imports Microsoft.Office.Interop.Excel
Public Class frmReport_Test
    Dim ErrorLog As clsError = Nothing
    Public dsData As DataSet = Nothing
    Private Sub frmReport_Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Try

            If dsData Is Nothing Then
                MsgBox("Data source no found.", MsgBoxStyle.Exclamation)
                Me.Close()
            End If

            Dim workbook As New Workbook()
            mdlReport.GenerateXlsReport(workbook, dsData, 0, ErrorLog)

            workbook.SaveDocument(Application.StartupPath & "\tsmtp.xlsx")
            Application.DoEvents()

            ExcelView.Document.LoadDocument(Application.StartupPath & "\tsmtp.xlsx")


        Catch ex As Exception

        End Try
    End Sub
    
End Class