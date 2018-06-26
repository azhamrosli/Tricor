Public Class frmCA_ReportMenu 
    Dim ErrorLog As ClsError = Nothing
    Public TypeReport As Integer = 1
    Dim ListofIndexNo As List(Of Integer)
    Private Sub frmCA_ReportMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub LoadData()
        Try
            If CreateLookUpTaxPayer(DsCA, ErrorLog) = False Then
                MsgBox("Unable to retrive tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If CreateLookUpYA(cboYA, ErrorLog, True) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If CreateLookUpCategory(DsCA, ErrorLog) = False Then
                MsgBox("Unable to retrive category.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Dim TypeLicense As Integer = 0
            If isVersionLicenseType = VersionLicenseType.Tricor Then
                TypeLicense = 2
            Else
                TypeLicense = 1
            End If
            Dim dt As DataTable = ADO.Load_CA_ReportMenu(TypeLicense, ErrorLog)

            If dt IsNot Nothing Then
                Dim SelectedTypeIndex As Integer = 2
                Dim i As Integer = -1
                cboType.Properties.Items.Clear()

                If ListofIndexNo Is Nothing Then
                    ListofIndexNo = New List(Of Integer)
                End If

                ListofIndexNo.Clear()

                For Each rowx As DataRow In dt.Rows
                    i += 1
                    If IsDBNull(rowx("Description")) = False Then

                        cboType.Properties.Items.Add(rowx("Description"))
                        ListofIndexNo.Add(IIf(IsDBNull(rowx("IndexNo")), 0, rowx("IndexNo")))

                        If IIf(IsDBNull(rowx("IndexNo")), 0, rowx("IndexNo")) = TypeReport Then
                            SelectedTypeIndex = i
                        End If

                    End If

                Next

                cboType.SelectedIndex = SelectedTypeIndex
            Else
                MsgBox("Failed to load report menu.", MsgBoxStyle.Critical)
                Me.Close()
            End If

            If mdlProcess.ArgParam2 <> "" Then
                cboRefNo.EditValue = mdlProcess.ArgParam2
            End If

            If mdlProcess.ArgParam3 <> "" Then
                cboYA.EditValue = mdlProcess.ArgParam3
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

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
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub cboCategory_EditValueChanged(sender As Object, e As EventArgs) Handles cboCategory.EditValueChanged
        Try
            Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
            Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
            Dim value As Object = row("CA_CATEGORY")
            txtCategory.Text = value.ToString
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

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
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

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
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

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
            Select Case ListofIndexNo(cboType.SelectedIndex)
                Case 0, 1, 2
                    Status = mdlReport_CA.Report_CA(cboRefNo.EditValue, cboYA.EditValue, ID, RateFrom, RateTo, Category, ErrorLog)

                Case 3, 4, 5
                    Status = mdlReport_CA.Report_CA_Summary(cboRefNo.EditValue, cboYA.EditValue, ID, RateFrom, RateTo, Category, ListofIndexNo(cboType.SelectedIndex), ErrorLog)

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
                Case 11
                    'Hire Purchase
                    Status = mdlReport_CA.Report_HP(cboRefNo.EditValue, cboYA.EditValue, ID, RateFrom, RateTo, Category, ErrorLog)
                Case 12
                    'Summary QE
                    Status = mdlReport_CA.Report_CA_SummaryQE(cboRefNo.EditValue, cboYA.EditValue, ID, RateFrom, RateTo, Category, ErrorLog)
                Case 13
                    'Analysis
                    Status = mdlReport_CA.Report_CA_Analysis(cboRefNo.EditValue, cboYA.EditValue, ID, RateFrom, RateTo, Category, ErrorLog)
            End Select

            If Status = False Then
                MsgBox("Failed to generate report", MsgBoxStyle.Critical)
            Else
                Select Case ListofIndexNo(cboType.SelectedIndex)
                    Case 0, 1, 2, 3, 4, 5
                        Dim frm As New frmCA_Report With {
                            .TypeReport = ListofIndexNo(cboType.SelectedIndex),
                            .ID = ID,
                            .RefNo = CType(cboRefNo.EditValue, String),
                            .YA = cboYA.EditValue,
                            .ComName = cboRefNo.Text
                        }
                        frm.Show()

                    Case 6
                        Dim frm As New frmCA_Report_FA_Reconciliation With {
                            .TypeReport = ListofIndexNo(cboType.SelectedIndex),
                            .ID = ID,
                            .RefNo = CType(cboRefNo.EditValue, String),
                            .YA = cboYA.EditValue,
                            .ComName = cboRefNo.Text
                        }
                        frm.Show()

                    Case 7
                        'control transfer
                        Dim frm As New frmCA_Report_ControlTransfer With {
                            .TypeReport = ListofIndexNo(cboType.SelectedIndex),
                            .ID = ID,
                            .RefNo = CType(cboRefNo.EditValue, String),
                            .YA = cboYA.EditValue,
                            .ComName = cboRefNo.Text
                        }
                        frm.Show()
                    Case 8, 9, 10
                        'disposal
                        'written off
                        'control transfer out

                        Dim frm As New frmCA_Report_Disposal With {
                            .TypeReport = ListofIndexNo(cboType.SelectedIndex),
                            .ID = ID
                        }

                        Select Case ListofIndexNo(cboType.SelectedIndex)
                            Case 8
                                frm.Type = 0
                            Case 9
                                frm.Type = 1
                            Case 10
                                frm.Type = 2
                            Case Else
                                frm.Type = 0
                        End Select
                        frm.RefNo = CType(cboRefNo.EditValue, String)
                        frm.YA = cboYA.EditValue
                        frm.ComName = cboRefNo.Text
                        frm.Show()
                    Case 11
                        'Hire Purchase

                        Dim frm As New frmHP_Report With {
                            .ID = ID,
                            .RefNo = CType(cboRefNo.EditValue, String),
                            .YA = cboYA.EditValue,
                            .ComName = cboRefNo.Text
                        }
                        frm.Show()
                    Case 12
                        'Summary QE
                        Dim frm As New frmCA_Report_SummaryQE With {
                            .TypeReport = ListofIndexNo(cboType.SelectedIndex),
                            .ID = ID,
                            .RefNo = CType(cboRefNo.EditValue, String),
                            .YA = cboYA.EditValue,
                            .ComName = cboRefNo.Text
                        }
                        frm.Show()
                    Case 13
                        'Analysis
                        Dim frm As New frmCA_Report_Analysis With {
                            .TypeReport = ListofIndexNo(cboType.SelectedIndex),
                            .ID = ID,
                            .RefNo = CType(cboRefNo.EditValue, String),
                            .YA = cboYA.EditValue,
                            .ComName = cboRefNo.Text
                        }
                        frm.Show()
                End Select

            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
End Class