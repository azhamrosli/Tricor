Imports DevExpress.XtraReports.ReportGeneration
Imports DevExpress.XtraReports.UI
Public Class ucDeemedInterest_Report
    Dim ErrorLog As ClsError = Nothing
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()

        InitializeComponent()
    End Sub
    Private Sub frmDeemedInterest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub LoadData(Optional Type As Integer = 0)
        Try
            pnlLoading.Visible = True
            Application.DoEvents()

            Dim tmpType As Integer = -1

            If CreateLookUpTaxPayer(DsDefault, ErrorLog) = False Then
                MsgBox("Unable to retrive tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If CreateLookUpYA(cboYA, ErrorLog, True) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Application.DoEvents()

            If Type = 0 Then
                If mdlProcess.ArgParam2 <> "" Then
                    cboRefNo.EditValue = mdlProcess.ArgParam2
                End If

                If mdlProcess.ArgParam3 <> "" Then
                    cboYA.EditValue = mdlProcess.ArgParam3
                End If
            ElseIf Type = 1 Then
                cboRefNo.EditValue = ""
                cboYA.EditValue = ""
            End If

            Dim dtTaxcom As DataTable = ADO.Load_Tax_Computation(cboRefNo.EditValue, cboYA.EditValue, ErrorLog)


            DsTaxcomputation.Tables("DEEMED_INTEREST").Rows.Clear()
            Dim dtRow As DataRow = Nothing
            Dim TC_KEY As Integer = 0
            Dim dtDeemedInterest As DataTable = Nothing
            If dtTaxcom IsNot Nothing Then

                For i As Integer = 0 To dtTaxcom.Rows.Count - 1

                    TC_KEY = CInt(IIf(IsDBNull(dtTaxcom.Rows(i)("TC_KEY")), 0, dtTaxcom.Rows(i)("TC_KEY")))

                    dtDeemedInterest = ADO.Load_DeemedInterest(TC_KEY, ErrorLog)

                    If dtDeemedInterest IsNot Nothing Then

                        For Each rowx As DataRow In dtDeemedInterest.Rows

                            rowx("DI_MONTH") = MonthName(CInt(rowx("DI_MONTH")), False) & " " & CStr(rowx("DI_YEAR"))
                            DsTaxcomputation.Tables("DEEMED_INTEREST").ImportRow(rowx)

                        Next

                    End If

                Next

            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        Finally
            pnlLoading.Visible = False
        End Try
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Try
            LoadData(2)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            txtRefNo.EditValue = cboRefNo.EditValue
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Try
            If DsTaxcomputation.Tables("DEEMED_INTEREST").Rows.Count > 0 Then
                Dim rpt As New rpt_DeemedInterest With {
                    .DataSource = DsTaxcomputation.Tables("DEEMED_INTEREST")
                }

                rpt.ShowPreview()
            End If
          
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
        Try
            If DsTaxcomputation.Tables("DEEMED_INTEREST").Rows.Count = 0 Then
                Exit Sub
            End If

            SaveFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx"
            Dim rslt As DialogResult = SaveFileDialog1.ShowDialog
            Dim path As String = Nothing
            If rslt = Windows.Forms.DialogResult.OK Then
                path = SaveFileDialog1.FileName
                Dim rpt As New rpt_DeemedInterest With {
                    .DataSource = DsTaxcomputation.Tables("DEEMED_INTEREST")
                }
                rpt.ExportToXlsx(path)

                MsgBox("Successfully export to " & path, MsgBoxStyle.Information)
            Else
                Exit Sub
            End If


        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
End Class
