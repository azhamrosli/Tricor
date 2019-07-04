Imports DevExpress.Spreadsheet
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Reporting.WinForms

Public Class frmReport_Test
    Public rptURL As String = Nothing
    Public ds As DataSet = Nothing
    Private Sub frmReport_Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()

        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub LoadData()
        Dim BindingSource1 As New BindingSource With {
            .DataSource = ds,
            .DataMember = "REF_INTEREST_RESTRIC_DETAIL_TRICOR_TEMP"
        }


        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = rptURL
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", BindingSource1))
        ReportViewer1.DocumentMapCollapsed = True
        ReportViewer1.RefreshReport()
        'Try

        '    Dim dt As DataTable = ADO.Load_CAReport_Temp(ID, ErrorLog)

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