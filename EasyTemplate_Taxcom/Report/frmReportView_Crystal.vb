Imports CrystalDecisions.CrystalReports.Engine

Public Class frmReportView_Crystal
    Public RefNo As String = Nothing
    Public YA As String = Nothing
    Public ReportName As String = Nothing
    Private Sub frmReportView_Crystal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ReportName = "CA_Disposal"
            Application.DoEvents()
            LoadData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadData()
        Try
            Dim cryRpt As New ReportDocument

            Select Case ReportName
                Case "CA_Disposal"
                    cryRpt.Load(Application.StartupPath & "\Report\CA_Disposal.rpt")
                    cryRpt.SetParameterValue("Search_CADisp_RefNo", RefNo)
                    cryRpt.SetParameterValue("Search_CADisp_YA", YA)
                    cryRpt.SetParameterValue("Search_CADisp_toRefNo", "")
                    cryRpt.SetParameterValue("Search_CADisp_toYA", "")

            End Select

            cryRpt.SetDatabaseLogon("sa", "azham91")
            CrystalReportViewer1.ReportSource = cryRpt
            CrystalReportViewer1.Refresh()
        Catch ex As Exception

        End Try
    End Sub
End Class