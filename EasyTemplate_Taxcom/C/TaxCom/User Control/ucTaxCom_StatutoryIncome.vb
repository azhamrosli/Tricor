Public Class ucTaxCom_StatutoryIncome
    Public WithEvents AdjustedIncome As AdjustedIncome = Nothing
    Public RefNo As String = Nothing
    Public YA As String = Nothing
    Public RowIndex As Integer = 0
    Dim rowData As DataRow = Nothing
    Private Sub ucTaxCom_StatutoryIncome_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            AdjustedIncome.TaxCom.RefNo = RefNo
            AdjustedIncome.TaxCom.YA = YA

            Dim dt As DataTable = Nothing

            dt = AdjustedIncome.TaxCom.StatutoryIncome.Load_OtherExemption()
            cboPioneer.Properties.Items.Clear()

            If dt IsNot Nothing Then
                For Each rowx As DataRow In dt.Rows
                    If IsDBNull(rowx("EXP_PIONEER")) = False Then
                        cboPioneer.Properties.Items.Add(rowx("EXP_PIONEER"))
                    End If
                Next

                cboPioneer.SelectedIndex = 0
            End If

            dt = Nothing

            AdjustedIncome.TaxCom.LoadStatutoryIncome()
            Application.DoEvents()
            If AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME") IsNot Nothing AndAlso AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows.Count > 0 Then
                STATUTORYINCOMEBindingSource.DataSource = AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME")
                Application.DoEvents()
                rowData = AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex)
                Me.LoadDetails(AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex))

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadDetails(ByVal rowx As DataRow)
        Try

            If rowx("TC_BUSINESS") IsNot Nothing AndAlso IsDBNull(rowx("TC_BUSINESS")) = False Then
                txtSourceNo.EditValue = rowx("TC_BUSINESS")
            Else
                txtSourceNo.EditValue = 0
            End If

            If rowx("BC_TYPE") IsNot Nothing AndAlso IsDBNull(rowx("BC_TYPE")) = False Then
                txtSource.EditValue = rowx("BC_TYPE")
            Else
                txtSource.EditValue = 0
            End If

            If rowx("TC_AI_TOT_BS_IN") IsNot Nothing AndAlso IsDBNull(rowx("TC_AI_TOT_BS_IN")) = False Then
                txtTotBsIn.EditValue = rowx("TC_AI_TOT_BS_IN")
            Else
                txtTotBsIn.EditValue = 0
            End If

            If rowx("TC_AI_TOT_ADJ_BS_IN") IsNot Nothing AndAlso IsDBNull(rowx("TC_AI_TOT_BS_IN")) = False Then
                txtAdjustBsIn.EditValue = rowx("TC_AI_TOT_ADJ_BS_IN")
            Else
                txtAdjustBsIn.EditValue = 0
            End If

            If rowx("TC_AI_TOT_ADJ_BS_EXP") IsNot Nothing AndAlso IsDBNull(rowx("TC_AI_TOT_ADJ_BS_EXP")) = False Then
                txtAdjustBsExp.EditValue = rowx("TC_AI_TOT_ADJ_BS_EXP")
            Else
                txtAdjustBsExp.EditValue = 0
            End If

            If rowx("TC_AI_ADJ_IN_LOSS") IsNot Nothing AndAlso IsDBNull(rowx("TC_AI_ADJ_IN_LOSS")) = False Then
                txtAdjustedInLoss.EditValue = rowx("TC_AI_ADJ_IN_LOSS")
            Else
                txtAdjustedInLoss.EditValue = 0
            End If

            If rowx("TC_SI_ADJ_BS_IN") IsNot Nothing AndAlso IsDBNull(rowx("TC_SI_ADJ_BS_IN")) = False Then
                txtAdjustedBsIn.EditValue = rowx("TC_SI_ADJ_BS_IN")
            Else
                txtAdjustedBsIn.EditValue = 0
            End If

            If rowx("TC_SI_BC") IsNot Nothing AndAlso IsDBNull(rowx("TC_SI_BC")) = False Then
                txtBalCharge.EditValue = rowx("TC_SI_BC")
            Else
                txtBalCharge.EditValue = 0
            End If

            If rowx("TC_SI_ADJ_BS_IN_BC") IsNot Nothing AndAlso IsDBNull(rowx("TC_SI_ADJ_BS_IN_BC")) = False Then
                txtABIBalCharge.EditValue = rowx("TC_SI_ADJ_BS_IN_BC")
            Else
                txtABIBalCharge.EditValue = 0
            End If

            If rowx("TC_SI_CA") IsNot Nothing AndAlso IsDBNull(rowx("TC_SI_CA")) = False Then
                txtCapitalAllow.EditValue = rowx("TC_SI_CA")
            Else
                txtCapitalAllow.EditValue = 0
            End If

            If rowx("TC_SI_STAT_BS_IN") IsNot Nothing AndAlso IsDBNull(rowx("TC_SI_STAT_BS_IN")) = False Then
                txtStatBsIn.EditValue = rowx("TC_SI_STAT_BS_IN")
            Else
                txtStatBsIn.EditValue = 0
            End If

            ''TC_SI_INVEST_ALLOW
            If rowx("TC_SI_RA") IsNot Nothing AndAlso IsDBNull(rowx("TC_SI_RA")) = False Then
                txtRA.EditValue = rowx("TC_SI_RA")
            Else
                txtRA.EditValue = 0
            End If

            If rowx("TC_SI_INVEST_ALLOW") IsNot Nothing AndAlso IsDBNull(rowx("TC_SI_INVEST_ALLOW")) = False Then
                txtInvestAllow.EditValue = rowx("TC_SI_INVEST_ALLOW")
            Else
                txtInvestAllow.EditValue = 0
            End If

            If rowx("TC_RA_QUALIFYINGCAPITALEXP_AMOUNT") IsNot Nothing AndAlso IsDBNull(rowx("TC_RA_QUALIFYINGCAPITALEXP_AMOUNT")) = False Then
                txtEA.EditValue = rowx("TC_RA_QUALIFYINGCAPITALEXP_AMOUNT")
            Else
                txtEA.EditValue = 0
            End If

            If rowx("TC_PIO") IsNot Nothing AndAlso IsDBNull(rowx("TC_PIO")) = False Then
                txtPio.EditValue = rowx("TC_PIO")
            Else
                txtPio.EditValue = 0
            End If

            If rowx("TC_PIONEERDESC") IsNot Nothing AndAlso IsDBNull(rowx("TC_PIONEERDESC")) = False Then
                cboPioneer.EditValue = rowx("TC_PIONEERDESC")
            Else
                cboPioneer.SelectedIndex = 0
            End If

            If rowx("TC_PIONEER") IsNot Nothing AndAlso IsDBNull(rowx("TC_PIONEER")) = False Then
                txtPioneer.EditValue = rowx("TC_PIONEER")
            Else
                txtPioneer.EditValue = 0
            End If

            If rowx("TC_WITHRAITA") IsNot Nothing AndAlso IsDBNull(rowx("TC_WITHRAITA")) = False Then
                txtWithdrawal.EditValue = rowx("TC_WITHRAITA")
            Else
                txtWithdrawal.EditValue = 0
            End If

            If rowx("TC_SI_NET_STAT_IN") IsNot Nothing AndAlso IsDBNull(rowx("TC_SI_NET_STAT_IN")) = False Then
                txtNetStat.EditValue = rowx("TC_SI_NET_STAT_IN")
            Else
                txtNetStat.EditValue = 0
            End If

            If rowx("TC_CHK_EXEMP") IsNot Nothing AndAlso IsDBNull(rowx("TC_CHK_EXEMP")) = False AndAlso rowx("TC_CHK_EXEMP") = "Y" Then
                chkExemption.Checked = True
            Else
                chkExemption.Checked = False
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtBalCharge_EditValueChanged(sender As Object, e As EventArgs) Handles txtBalCharge.EditValueChanged,
        txtWithdrawal.EditValueChanged, txtEA.EditValueChanged,
        txtInvestAllow.EditValueChanged, txtRA.EditValueChanged, txtPio.EditValueChanged
        Try
            AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex)("TC_AI_TOT_BS_IN") = txtTotBsIn.EditValue
            AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex)("TC_AI_TOT_ADJ_BS_IN") = txtAdjustBsIn.EditValue
            AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex)("TC_AI_TOT_ADJ_BS_EXP") = txtAdjustBsExp.EditValue
            AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex)("TC_AI_ADJ_IN_LOSS") = txtAdjustedInLoss.EditValue
            AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex)("TC_SI_ADJ_BS_IN") = txtAdjustedBsIn.EditValue
            AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex)("TC_SI_BC") = txtBalCharge.EditValue
            AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex)("TC_SI_ADJ_BS_IN_BC") = txtABIBalCharge.EditValue
            AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex)("TC_SI_CA") = txtCapitalAllow.EditValue
            AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex)("TC_SI_STAT_BS_IN") = txtStatBsIn.EditValue
            AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex)("TC_SI_RA") = txtRA.EditValue
            AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex)("TC_SI_INVEST_ALLOW") = txtInvestAllow.EditValue
            AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex)("TC_RA_QUALIFYINGCAPITALEXP_AMOUNT") = txtEA.EditValue
            AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex)("TC_PIONEER") = txtPioneer.EditValue
            AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex)("TC_WITHRAITA") = txtWithdrawal.EditValue
            AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex)("TC_PIO") = txtPio.EditValue
            AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex)("TC_CHK_EXEMP") = IIf(chkExemption.Checked, "Y", "N")

            If rowData IsNot Nothing Then
                AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex)("TC_RA_RATE1") = IIf(IsDBNull(rowData("TC_RA_RATE1")), 0, rowData("TC_RA_RATE1"))
                AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex)("TC_RA_QUALIFYINGCAPITALEXP") = IIf(IsDBNull(rowData("TC_RA_QUALIFYINGCAPITALEXP")), 0, rowData("TC_RA_QUALIFYINGCAPITALEXP"))
                AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex)("TC_RA_QUALIFYINGCAPITALEXP_AMOUNT") = IIf(IsDBNull(rowData("TC_RA_QUALIFYINGCAPITALEXP_AMOUNT")), 0, rowData("TC_RA_QUALIFYINGCAPITALEXP_AMOUNT"))
                AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex)("TC_RA_BALANCINGALLOWANCE") = IIf(IsDBNull(rowData("TC_RA_BALANCINGALLOWANCE")), 0, rowData("TC_RA_BALANCINGALLOWANCE"))
                AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex)("TC_RA_TOTAL1") = IIf(IsDBNull(rowData("TC_RA_TOTAL1")), 0, rowData("TC_RA_TOTAL1"))
            End If

            Application.DoEvents()
            AdjustedIncome.TaxCom.StatutoryIncome_BySource(AdjustedIncome.TaxCom.dsTaxcomputation.Tables("STATUTORY_INCOME").Rows(RowIndex))
        Catch ex As Exception

        End Try
    End Sub
    Private Sub AdjustedIncome_OnChangeStatutoryIncome(row_ As DataRow) Handles AdjustedIncome.OnChangeStatutoryIncome
        Try
            If row_ IsNot Nothing Then
                LoadDetails(row_)
            End If
        Catch ex As Exception

        End Try
    End Sub
#Region "BUTTON"
    Private Sub btnRA_Click(sender As Object, e As EventArgs) Handles btnRA.Click
        Try
            Dim frm As New frmTaxComputation_Details
            frm.ObjUserControl = New ucTaxCom_Statutory_RAITA
            frm.Title = "Statutory Income- RA" & IIf(My.Computer.Name = DeveloperPCName, " (ucTaxCom_Statutory_RAITA)", "")
            frm.AdjustedIncome = AdjustedIncome
            frm.FormType = frmTaxComputation_Details.Taxcom_FormType.ucTaxCom_Statutory_RA
            frm.rowData = rowData
            frm.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnITA_Click(sender As Object, e As EventArgs) Handles btnITA.Click
        Try
            Dim frm As New frmTaxComputation_Details
            frm.ObjUserControl = New ucTaxCom_Statutory_RAITA
            frm.Title = "Statutory Income- ITA" & IIf(My.Computer.Name = DeveloperPCName, " (ucTaxCom_Statutory_RAITA)", "")
            frm.FormType = frmTaxComputation_Details.Taxcom_FormType.ucTaxCom_Statutory_ITA
            frm.rowData = rowData
            frm.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEA_Click(sender As Object, e As EventArgs) Handles btnEA.Click
        Try
            Dim frm As New frmTaxComputation_Details
            frm.ObjUserControl = New ucTaxCom_Statutory_EA
            frm.Title = "Statutory Income - EA" & IIf(My.Computer.Name = DeveloperPCName, " (ucTaxCom_Statutory_EA)", "")
            frm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnWithDrawal_Click(sender As Object, e As EventArgs) Handles btnWithDrawal.Click
        Try
            Dim frm As New frmTaxComputation_Details
            frm.ObjUserControl = New uc_RAITA_ITA_Withdrawal
            frm.Title = "Withdrawal of RA/ITA" & IIf(My.Computer.Name = DeveloperPCName, " (uc_RAITA_ITA_Withdrawal)", "")
            frm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        Try
            Dim frm As New frmTaxComputation_Details
            frm.ObjUserControl = New ucTaxCom_Statutory_PartnershipIncome
            frm.Title = "Statutory Income (Partnership)" & IIf(My.Computer.Name = DeveloperPCName, " (ucTaxCom_Statutory_PartnershipIncome)", "")
            frm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

#End Region
End Class
