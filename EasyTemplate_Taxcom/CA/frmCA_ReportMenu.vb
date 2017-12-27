Public Class frmCA_ReportMenu 
    Dim ErrorLog As clsError = Nothing
    Private Sub frmCA_ReportMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.LoadData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadData()
        Try
            If mdlProcess.CreateLookUpTaxPayer(DsCA, ErrorLog) = False Then
                MsgBox("Unable to retrive tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If mdlProcess.CreateLookUpYA(cboYA, ErrorLog, True) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If mdlProcess.CreateLookUpCategory(DsCA, ErrorLog) = False Then
                MsgBox("Unable to retrive category.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            cboType.SelectedIndex = 0

            If mdlProcess.ArgParam2 <> "" Then
                cboRefNo.EditValue = mdlProcess.ArgParam2
            End If

            If mdlProcess.ArgParam3 <> "" Then
                cboYA.EditValue = mdlProcess.ArgParam3
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            txtRefNo.EditValue = cboRefNo.EditValue

            If cboRefNo.EditValue Is Nothing OrElse cboRefNo.EditValue.ToString = "" Then
                gbCategory.Enabled = False
                gbRate.Enabled = False
            Else
                gbCategory.Enabled = True
                gbRate.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboCategory_EditValueChanged(sender As Object, e As EventArgs) Handles cboCategory.EditValueChanged
        Try
            Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
            Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
            Dim value As Object = row("CA_CATEGORY")
            txtCategory.Text = value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkAllCategory_CheckedChanged(sender As Object, e As EventArgs) Handles chkAllCategory.CheckedChanged
        Try
            If chkAllCategory.Checked = True Then
                cboCategory.Enabled = False
                txtCategory.Enabled = False
                cboCategory.EditValue = ""
                txtCategory.EditValue = ""
            Else
                cboCategory.Enabled = True
                txtCategory.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkAllRate_CheckedChanged(sender As Object, e As EventArgs) Handles chkAllRate.CheckedChanged
        Try
            If chkAllRate.Checked = True Then
                cboRateFrom.Enabled = False
                cboRateTo.Enabled = False
                cboRateFrom.EditValue = ""
                cboRateTo.EditValue = ""
            Else
                cboRateFrom.Enabled = True
                cboRateTo.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Try
            If cboRefNo.EditValue Is Nothing OrElse cboRefNo.EditValue.ToString = "" Then
                MsgBox("Please select tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Dim ID As String = Nothing

            Dim RateFrom As Integer = -1
            Dim RateTo As Integer = -1
            Dim Category As String = ""

            If chkAllRate.Checked = False Then
                If cboRateFrom.EditValue <> "" Then
                    RateFrom = CInt(cboRateFrom.EditValue)
                End If
                If cboRateTo.EditValue <> "" Then
                    RateTo = CInt(cboRateTo.EditValue)
                End If
            End If
           
            If chkAllCategory.Checked = False Then
                Category = cboCategory.EditValue
            End If
            Dim Status As Boolean = False
            Select Case cboType.SelectedIndex
                Case 0, 1, 2
                    Status = mdlReport_CA.Report_CA(cboRefNo.EditValue, cboYA.EditValue, ID, RateFrom, RateTo, Category, ErrorLog)
                   
                Case 3, 4, 5
                    Status = mdlReport_CA.Report_CA_Summary(cboRefNo.EditValue, cboYA.EditValue, ID, RateFrom, RateTo, Category, cboType.SelectedIndex, ErrorLog)

                Case 6
                    Status = mdlReport_CA.Report_CA_FAConciliation(cboRefNo.EditValue, cboYA.EditValue, ID, RateFrom, RateTo, Category, ErrorLog)

                Case 7
                    'control transfer
                    Status = mdlReport_CA.Report_CA_ControlTransfer(cboRefNo.EditValue, cboYA.EditValue, ID, RateFrom, RateTo, Category, ErrorLog)
                Case 8
                    'Disposal Report
                    Status = mdlReport_CA.Report_DISPOSAL(cboRefNo.EditValue, cboYA.EditValue, ID, RateFrom, RateTo, Category, 0, ErrorLog)
                Case 9
                    'Disposal Report_Written_Out
                    Status = mdlReport_CA.Report_DISPOSAL(cboRefNo.EditValue, cboYA.EditValue, ID, RateFrom, RateTo, Category, 1, ErrorLog)
                Case 10
                    'Disposal Report Control Transfer Out
                    Status = mdlReport_CA.Report_DISPOSAL(cboRefNo.EditValue, cboYA.EditValue, ID, RateFrom, RateTo, Category, 2, ErrorLog)
            End Select

            If Status = False Then
                MsgBox("Failed to generate report", MsgBoxStyle.Critical)
            Else
                Select Case cboType.SelectedIndex
                    Case 0, 1, 2, 3, 4, 5
                        Dim frm As New frmCA_Report
                        frm.TypeReport = cboType.SelectedIndex
                        frm.ID = ID
                        frm.RefNo = cboRefNo.EditValue
                        frm.YA = cboYA.EditValue
                        frm.ComName = cboRefNo.Text
                        frm.Show()

                    Case 6
                        Dim frm As New frmCA_Report_FA_Reconciliation
                        frm.TypeReport = cboType.SelectedIndex
                        frm.ID = ID
                        frm.RefNo = cboRefNo.EditValue
                        frm.YA = cboYA.EditValue
                        frm.ComName = cboRefNo.Text
                        frm.Show()

                    Case 7
                        'control transfer
                        Dim frm As New frmCA_Report_ControlTransfer
                        frm.TypeReport = cboType.SelectedIndex
                        frm.ID = ID
                        frm.RefNo = cboRefNo.EditValue
                        frm.YA = cboYA.EditValue
                        frm.ComName = cboRefNo.Text
                        frm.Show()
                    Case 8, 9, 10
                        'disposal
                        'written off
                        'control transfer out

                        Dim frm As New frmCA_Report_Disposal
                        frm.TypeReport = cboType.SelectedIndex
                        frm.ID = ID

                        Select Case cboType.SelectedIndex
                            Case 8
                                frm.Type = 0
                            Case 9
                                frm.Type = 1
                            Case 10
                                frm.Type = 2
                            Case Else
                                frm.Type = 0
                        End Select
                        frm.RefNo = cboRefNo.EditValue
                        frm.YA = cboYA.EditValue
                        frm.ComName = cboRefNo.Text
                        frm.Show()
                End Select
                
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class