Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting

Public Class frmCP204_Add
    Dim ErrorLog As clsError = Nothing
    Public isEdit As Boolean = False
    Public ID As Integer = 0

    Public Const MainTable As String = "BORANG_CP204_TRICOR"
    Public Const MainTable_Details As String = "BORANG_CP204_TRICOR_BREAKDOWN"
    Public Const MainTable_PaymentDue As String = "CP_PAYMENT_DUE"
    Public Const MainTable_InstallmentAmount As String = "CP_INSTALLMENT_AMOUNT"
    Public Const MainTable_Penalty As String = "CP_PENALTY"
    Public Const MainTable_Amount1 As String = "CP_AMOUNT_PAID_1"
    Public Const MainTable_Amount2 As String = "CP_AMOUNT_PAID_2"
    Public Const MainTable_Payment1 As String = "CP_PAYMENT_DATE_1"
    Public Const MainTable_Payment2 As String = "CP_PAYMENT_DATE_2"

    Private Sub frmCP204_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadData()
        Try
            If mdlProcess.CreateLookUpTaxPayer(DsDefault, ErrorLog) = False Then
                MsgBox("Unable to retrive tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If mdlProcess.CreateLookUpYA(cboYA, ErrorLog, True) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If mdlProcess.CreateLookUpYA(cboYA_From_SME, ErrorLog, True) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If mdlProcess.CreateLookUpYA(cboYA_To_SME, ErrorLog, True) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If mdlProcess.CreateLookUpState(cboState_Cor, ErrorLog, True) = False Then
                MsgBox("Unable to retrive State.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If mdlProcess.CreateLookUpState(cboState_Alt_Cor, ErrorLog, True) = False Then
                MsgBox("Unable to retrive State.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            dtDate.EditValue = Now
            dtAccStart.EditValue = Now
            dtAccEnd.EditValue = Now
            dtBasisPeriodStart.EditValue = Now
            dtBasisPeriodEnd.EditValue = Now
            dtCommencement.EditValue = Now
            dtBasisPeriodYAStart.EditValue = Now
            dtBasisPeriodYAEnd.EditValue = Now
            dtBasisPeriodSecStart.EditValue = Now
            dtBasisPeriodSecEnd.EditValue = Now
            chkCommencement.EditValue = False
            chkSME.EditValue = False
            txtAmountTaxPayable.EditValue = 100000

            Application.DoEvents()

            If isEdit = False Then
                If mdlProcess.ArgParam2 <> "" Then
                    cboRefNo.EditValue = mdlProcess.ArgParam2
                End If

                If mdlProcess.ArgParam3 <> "" Then
                    cboYA.EditValue = mdlProcess.ArgParam3
                End If

            Else

                Dim dt As DataTable = mdlProcess.Load_CP204_ByID(ID)

                If dt Is Nothing Then
                    isEdit = False
                    Exit Sub
                End If

                cboRefNo.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_REF_NO")), "", dt.Rows(0)("BCP_REF_NO"))
                txtRefRegistrationNo.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_CO_REGNO")), "", dt.Rows(0)("BCP_CO_REGNO"))
                cboYA.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_YA")), "", dt.Rows(0)("BCP_YA"))
                Application.DoEvents()
                dtDate.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_DATE")), Now, dt.Rows(0)("BCP_DATE"))
                txtAmountTaxPayable.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_ESTIMATED_TAX")), 0, dt.Rows(0)("BCP_ESTIMATED_TAX"))
                chkSME.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_SME_PERIOD_FR")), False, True)
                cboYA_From_SME.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_SME_PERIOD_FR")), Now, dt.Rows(0)("BCP_SME_PERIOD_FR"))
                cboYA_To_SME.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_SME_PERIOD_TO")), Now, dt.Rows(0)("BCP_SME_PERIOD_TO"))

                If IsDBNull(dt.Rows(0)("BCP_INDICATE")) = False AndAlso dt.Rows(0)("BCP_INDICATE") = 1 Then
                    rbPeriodEnded.EditValue = True
                Else
                    rbPeriodEnded.EditValue = False
                End If


                dtBasisPeriodStart.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_ACC_PERIOD_FR")), Now, dt.Rows(0)("BCP_ACC_PERIOD_FR"))
                dtBasisPeriodEnd.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_ACC_PERIOD_TO")), Now, dt.Rows(0)("BCP_ACC_PERIOD_TO"))
                dtAccStart.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_BASIS_PERIOD_FR")), Now, dt.Rows(0)("BCP_BASIS_PERIOD_FR"))
                dtAccEnd.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_BASIS_PERIOD_TO")), Now, dt.Rows(0)("BCP_BASIS_PERIOD_TO"))

                If IsDBNull(dt.Rows(0)("BCP_NEWCO_DATE")) = False Then
                    dtAccEnd.EditValue = dt.Rows(0)("BCP_NEWCO_DATE")
                    chkCommencement.EditValue = True
                Else
                    chkCommencement.EditValue = False
                End If

                txtAdd1_Cor.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_CORRESPOND_ADD1")), "", dt.Rows(0)("BCP_CORRESPOND_ADD1"))
                txtAdd2_Cor.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_CORRESPOND_ADD2")), "", dt.Rows(0)("BCP_CORRESPOND_ADD2"))
                txtAdd3_Cor.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_CORRESPOND_ADD3")), "", dt.Rows(0)("BCP_CORRESPOND_ADD3"))
                txtPostcode_Cor.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_CORRESPOND_POST")), "", dt.Rows(0)("BCP_CORRESPOND_POST"))
                txtCity_Cor.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_CORRESPOND_CITY")), "", dt.Rows(0)("BCP_CORRESPOND_CITY"))
                cboState_Cor.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_CORRESPOND_STATE")), "", dt.Rows(0)("BCP_CORRESPOND_STATE"))


                dtBasisPeriodYAStart.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_NEWCO_BAS_FR")), Now, dt.Rows(0)("BCP_NEWCO_BAS_FR"))
                dtBasisPeriodYAEnd.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_NEWCO_BAS_TO")), Now, dt.Rows(0)("BCP_NEWCO_BAS_TO"))
                dtBasisPeriodSecStart.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_NEWCO_BAS_SUB_FR")), Now, dt.Rows(0)("BCP_NEWCO_BAS_SUB_FR"))
                dtBasisPeriodSecEnd.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_NEWCO_BAS_SUB_TO")), Now, dt.Rows(0)("BCP_NEWCO_BAS_SUB_TO"))

                txtAdd1_Alt_Cor.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_CURR_CORR_ADD1")), "", dt.Rows(0)("BCP_CURR_CORR_ADD1"))
                txtAdd2_Alt_Cor.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_CURR_CORR_ADD2")), "", dt.Rows(0)("BCP_CURR_CORR_ADD2"))
                txtAdd3_Alt_Cor.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_CURR_CORR_ADD3")), "", dt.Rows(0)("BCP_CURR_CORR_ADD3"))
                txtPostcode_Alt_Cor.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_CURR_CORR_POST")), "", dt.Rows(0)("BCP_CURR_CORR_POST"))
                txtCity_Alt_Cor.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_CURR_CORR_CITY")), "", dt.Rows(0)("BCP_CURR_CORR_CITY"))
                cboState_Alt_Cor.EditValue = IIf(IsDBNull(dt.Rows(0)("BCP_CURR_CORR_STATE")), "", dt.Rows(0)("BCP_CURR_CORR_STATE"))

                CalcEstimationPercent()


                Dim dtBreakDown As DataTable = mdlProcess.Load_CP204_BreakDown_ByParentID(ID)

                If dtBreakDown IsNot Nothing Then

                    DsCP204.Tables(MainTable_Details).Rows.Clear()

                    Dim dtRow As DataRow = Nothing
                    For i As Integer = 0 To dtBreakDown.Rows.Count - 1
                        With dtBreakDown
                            dtRow = DsCP204.Tables(MainTable_Details).NewRow
                            dtRow("CP_PARENTID") = ID
                            dtRow("CP_INSTALL_NO") = IIf(IsDBNull(.Rows(i)("CP_INSTALL_NO")), DsCP204.Tables(MainTable_Details).Rows.Count + 1, .Rows(i)("CP_INSTALL_NO"))
                            dtRow("CP_PAYMENT_DUE") = IIf(IsDBNull(.Rows(i)("CP_PAYMENT_DUE")), DBNull.Value, .Rows(i)("CP_PAYMENT_DUE"))
                            dtRow("CP_INSTALLMENT_AMOUNT") = IIf(IsDBNull(.Rows(i)("CP_INSTALLMENT_AMOUNT")), 0, .Rows(i)("CP_INSTALLMENT_AMOUNT"))
                            dtRow("CP_PAYMENT_DATE_1") = IIf(IsDBNull(.Rows(i)("CP_PAYMENT_DATE_1")), DBNull.Value, .Rows(i)("CP_PAYMENT_DATE_1"))
                            dtRow("CP_AMOUNT_PAID_1") = IIf(IsDBNull(.Rows(i)("CP_AMOUNT_PAID_1")), 0, .Rows(i)("CP_AMOUNT_PAID_1"))
                            dtRow("CP_PAYMENT_DATE_2") = IIf(IsDBNull(.Rows(i)("CP_PAYMENT_DATE_2")), DBNull.Value, .Rows(i)("CP_PAYMENT_DATE_2"))
                            dtRow("CP_AMOUNT_PAID_2") = IIf(IsDBNull(.Rows(i)("CP_AMOUNT_PAID_2")), 0, .Rows(i)("CP_AMOUNT_PAID_2"))
                            dtRow("CP_PENALTY") = IIf(IsDBNull(.Rows(i)("CP_PENALTY")), 0, .Rows(i)("CP_PENALTY"))
                            dtRow("CP_NOTE_TITLE") = IIf(IsDBNull(.Rows(i)("CP_NOTE_TITLE")), "", .Rows(i)("CP_NOTE_TITLE"))
                            dtRow("CP_NOTE") = IIf(IsDBNull(.Rows(i)("CP_NOTE")), "", .Rows(i)("CP_NOTE"))
                            DsCP204.Tables(MainTable_Details).Rows.Add(dtRow)
                        End With

                    Next
                    Application.DoEvents()

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub GenerateBreakDown()
        Try

            If cboRefNo.EditValue Is Nothing OrElse cboRefNo.EditValue = "" Then
                Exit Sub
            End If

            If cboYA.EditValue Is Nothing OrElse cboYA.EditValue = "" Then
                Exit Sub
            End If

            Dim dt As DataTable = mdlProcess.LoadTaxPayer_ByRefNO(cboRefNo.EditValue, ErrorLog)

            If dt IsNot Nothing Then

                dtBasisPeriodStart.EditValue = IIf(IsDBNull(dt.Rows(0)("TP_BASIS_PERIOD_FR")), Now, dt.Rows(0)("TP_BASIS_PERIOD_FR"))
                dtBasisPeriodEnd.EditValue = IIf(IsDBNull(dt.Rows(0)("TP_BASIS_PERIOD_TO")), Now, dt.Rows(0)("TP_BASIS_PERIOD_TO"))
                dtAccStart.EditValue = IIf(IsDBNull(dt.Rows(0)("TP_ACC_PERIOD_FR")), Now, dt.Rows(0)("TP_ACC_PERIOD_FR"))
                dtAccEnd.EditValue = IIf(IsDBNull(dt.Rows(0)("TP_ACC_PERIOD_TO")), Now, dt.Rows(0)("TP_ACC_PERIOD_TO"))
                If IsDBNull(dt.Rows(0)("TP_OPN_OPERATION")) = False Then
                    dtAccEnd.EditValue = dt.Rows(0)("TP_OPN_OPERATION")
                    chkCommencement.EditValue = True
                Else
                    chkCommencement.EditValue = False
                End If



                txtAdd1_Cor.EditValue = IIf(IsDBNull(dt.Rows(0)("TP_CURR_ADD_LINE1")), "", dt.Rows(0)("TP_CURR_ADD_LINE1"))
                txtAdd2_Cor.EditValue = IIf(IsDBNull(dt.Rows(0)("TP_CURR_ADD_LINE2")), "", dt.Rows(0)("TP_CURR_ADD_LINE2"))
                txtAdd3_Cor.EditValue = IIf(IsDBNull(dt.Rows(0)("TP_CURR_ADD_LINE3")), "", dt.Rows(0)("TP_CURR_ADD_LINE3"))
                txtPostcode_Cor.EditValue = IIf(IsDBNull(dt.Rows(0)("TP_CURR_POSTCODE")), "", dt.Rows(0)("TP_CURR_POSTCODE"))
                txtCity_Cor.EditValue = IIf(IsDBNull(dt.Rows(0)("TP_CURR_CITY")), "", dt.Rows(0)("TP_CURR_CITY"))
                cboState_Cor.EditValue = IIf(IsDBNull(dt.Rows(0)("TP_CURR_STATE")), "", dt.Rows(0)("TP_CURR_STATE"))

                Application.DoEvents()

                Dim dtCP204Lastyear As DataTable = mdlProcess.Load_CP204(cboRefNo.EditValue, CStr((CInt(cboYA.EditValue) - 1)))

                If dtCP204Lastyear IsNot Nothing Then
                    Dim YEAROFUSED As Integer = 0
                    If CInt(cboYA.EditValue) > CInt(IIf(IsDBNull(dtCP204Lastyear.Rows(0)("BCP_YA")), 0, dtCP204Lastyear.Rows(0)("BCP_YA"))) Then
                        YEAROFUSED = IIf(IsDBNull(dtCP204Lastyear.Rows(0)("BCP_YA")), 0, dtCP204Lastyear.Rows(0)("BCP_YA"))
                        Dim dtCP204ALastyear As DataTable = mdlProcess.Load_CP204_LastYAChecking(cboRefNo.EditValue, "CP204A")

                        If dtCP204ALastyear IsNot Nothing Then
                            If YEAROFUSED = IIf(IsDBNull(dtCP204ALastyear.Rows(0)("BCP_YA")), 0, dtCP204ALastyear.Rows(0)("BCP_YA")) Then

                                Dim dtCP204BLastyear As DataTable = mdlProcess.Load_CP204_LastYAChecking(cboRefNo.EditValue, "CP204B")

                                If dtCP204BLastyear IsNot Nothing AndAlso YEAROFUSED = IIf(IsDBNull(dtCP204BLastyear.Rows(0)("BCP_YA")), 0, dtCP204BLastyear.Rows(0)("BCP_YA")) Then
                                    txtAmountTaxPayable_LastYear.EditValue = IIf(IsDBNull(dtCP204BLastyear.Rows(0)("BCP_REV_ESTIMATED_TAX")), 0, dtCP204BLastyear.Rows(0)("BCP_REV_ESTIMATED_TAX"))
                                    llbAmountTaxpayerLastYear.Text = ") Last year " & IIf(IsDBNull(dtCP204BLastyear.Rows(0)("BCP_YA")), "", dtCP204BLastyear.Rows(0)("BCP_YA"))
                                Else
                                    txtAmountTaxPayable_LastYear.EditValue = IIf(IsDBNull(dtCP204ALastyear.Rows(0)("BCP_REV_ESTIMATED_TAX")), 0, dtCP204ALastyear.Rows(0)("BCP_REV_ESTIMATED_TAX"))
                                    llbAmountTaxpayerLastYear.Text = ") Last year " & IIf(IsDBNull(dtCP204ALastyear.Rows(0)("BCP_YA")), "", dtCP204ALastyear.Rows(0)("BCP_YA"))
                                End If
                            Else
                                txtAmountTaxPayable_LastYear.EditValue = IIf(IsDBNull(dtCP204ALastyear.Rows(0)("BCP_REV_ESTIMATED_TAX")), 0, dtCP204ALastyear.Rows(0)("BCP_REV_ESTIMATED_TAX"))
                                llbAmountTaxpayerLastYear.Text = ") Last year " & IIf(IsDBNull(dtCP204ALastyear.Rows(0)("BCP_YA")), "", dtCP204ALastyear.Rows(0)("BCP_YA"))
                            End If
                        Else
                            txtAmountTaxPayable_LastYear.EditValue = 0
                            llbAmountTaxpayerLastYear.Text = ") Last year "
                        End If
                    Else
                        txtAmountTaxPayable_LastYear.EditValue = IIf(IsDBNull(dtCP204Lastyear.Rows(0)("BCP_ESTIMATED_TAX")), 0, dtCP204Lastyear.Rows(0)("BCP_ESTIMATED_TAX"))
                        llbAmountTaxpayerLastYear.Text = ") Last year " & IIf(IsDBNull(dtCP204Lastyear.Rows(0)("BCP_YA")), "", dtCP204Lastyear.Rows(0)("BCP_YA"))
                    End If

                Else
                    txtAmountTaxPayable_LastYear.EditValue = 0
                    llbAmountTaxpayerLastYear.Text = ") Last year "
                End If

                Application.DoEvents()
                CalcEstimationPercent()

            End If


        Catch ex As Exception

        End Try
    End Sub
    Private Sub CalcEstimationPercent()
        Try
            If txtAmountTaxPayable.EditValue Is Nothing Then
                txtAmountTaxPayable.EditValue = 0
            End If
            If txtAmountTaxPayable_LastYear.EditValue Is Nothing Then
                txtAmountTaxPayable_LastYear.EditValue = 0
            End If


            If txtAmountTaxPayable_LastYear.EditValue = 0 Then
                txtEstimationPercent.EditValue = 100
            Else
                Dim totalpecent As Decimal = (CDec(txtAmountTaxPayable.EditValue) / CDec(txtAmountTaxPayable_LastYear.EditValue)) * 100
                txtEstimationPercent.EditValue = totalpecent.ToString("N2")

            End If



            Dim tmpTotal As Long = 0

            tmpTotal = DateDiff(DateInterval.Month, dtBasisPeriodStart.EditValue, dtBasisPeriodEnd.EditValue)

            txtFirstInstallmentCount.EditValue = CInt(tmpTotal)

            Application.DoEvents()

            If IsNumeric(txtFirstInstallmentCount.EditValue) = False Then
                Exit Sub
            End If
            DsCP204.Tables(MainTable_Details).Rows.Clear()

            Dim dtRow As DataRow = Nothing
            For i As Integer = 0 To CInt(txtFirstInstallmentCount.EditValue)
                dtRow = DsCP204.Tables(MainTable_Details).NewRow
                dtRow("CP_PARENTID") = 0
                dtRow("CP_INSTALL_NO") = i + 1
                dtRow("CP_PAYMENT_DUE") = CDate(dtBasisPeriodStart.EditValue).AddMonths(1)
                dtRow("CP_INSTALLMENT_AMOUNT") = 0
                dtRow("CP_PAYMENT_DATE_1") = DBNull.Value

                dtRow("CP_AMOUNT_PAID_1") = 0
                dtRow("CP_PAYMENT_DATE_2") = DBNull.Value
                dtRow("CP_AMOUNT_PAID_2") = 0
                dtRow("CP_PENALTY") = 0
                dtRow("CP_NOTE_TITLE") = ""
                dtRow("CP_NOTE") = ""
                DsCP204.Tables(MainTable_Details).Rows.Add(dtRow)
            Next
            Application.DoEvents()

            If DsCP204.Tables(MainTable_Details).Rows.Count > 0 Then

                Dim MonthyInstall As Decimal = 0
                Dim LastAmount As Decimal = 0
                Dim Amountx As Decimal = CDec(IIf(txtAmountTaxPayable.EditValue Is Nothing, 0, txtAmountTaxPayable.EditValue))
                MonthyInstall = Amountx / (CInt(txtFirstInstallmentCount.EditValue) + 1)
                MonthyInstall = Math.Round(MonthyInstall, MidpointRounding.AwayFromZero)
                LastAmount = Amountx - (MonthyInstall * CInt(txtFirstInstallmentCount.EditValue))

                Dim paymentdue As DateTime
                If CInt(cboYA.EditValue) < 2015 Then
                    paymentdue = New DateTime(Format(dtBasisPeriodStart.EditValue, "yyyy"), Format(dtBasisPeriodStart.EditValue, "MM"), 10)

                Else
                    paymentdue = New DateTime(Format(dtBasisPeriodStart.EditValue, "yyyy"), Format(dtBasisPeriodStart.EditValue, "MM"), 15)

                End If
                Dim tmpDt As DateTime = paymentdue
                For i As Integer = 0 To DsCP204.Tables(MainTable_Details).Rows.Count - 1

                    DsCP204.Tables(MainTable_Details).Rows(i)("CP_PAYMENT_DUE") = tmpDt
                    ' DsCP204.Tables(MainTable_Details).Rows(i)("CP_PAYMENT_DATE_1") = tmpDt
                    tmpDt = tmpDt.AddMonths(+1)

                    If i = (DsCP204.Tables(MainTable_Details).Rows.Count - 1) Then
                        DsCP204.Tables(MainTable_Details).Rows(i)("CP_INSTALLMENT_AMOUNT") = LastAmount
                        DsCP204.Tables(MainTable_Details).Rows(i)(MainTable_Amount1) = LastAmount
                        txtLastInstallment.EditValue = LastAmount
                    Else
                        If i = 0 Then
                            txtFirstInstallment.EditValue = MonthyInstall
                        End If
                        DsCP204.Tables(MainTable_Details).Rows(i)("CP_INSTALLMENT_AMOUNT") = MonthyInstall
                        DsCP204.Tables(MainTable_Details).Rows(i)(MainTable_Amount1) = MonthyInstall
                    End If

                Next

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Installment_Breakdown()
        Try
            Dim instalments As Decimal = FormatNumber(CDbl(txtAmountTaxPayable.EditValue) / (CDbl(txtFirstInstallmentCount.EditValue) + 1), 2)
            Dim FirstInstallment As Decimal = 0
            Dim LastInstallment As Decimal = 0

            For i As Integer = 0 To CDbl(txtFirstInstallmentCount.EditValue) - 1
                If i = 0 Then

                Else

                End If
            Next

        Catch ex As Exception

        End Try
    End Sub
    Private Sub chkCommencement_CheckedChanged(sender As Object, e As EventArgs) Handles chkCommencement.CheckedChanged
        Try
            If chkCommencement.EditValue IsNot Nothing AndAlso chkCommencement.EditValue = True Then
                dtCommencement.Enabled = True
            Else
                dtCommencement.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkSME_CheckedChanged(sender As Object, e As EventArgs) Handles chkSME.CheckedChanged
        Try
            If chkSME.EditValue IsNot Nothing AndAlso chkSME.EditValue = True Then
                cboYA_From_SME.Enabled = True
                cboYA_To_SME.Enabled = True
            Else
                cboYA_From_SME.Enabled = False
                cboYA_To_SME.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboYA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYA.SelectedIndexChanged
        GenerateBreakDown()
    End Sub

    Private Sub dtBasisPeriodStart_EditValueChanged(sender As Object, e As EventArgs) Handles dtBasisPeriodStart.EditValueChanged
        GenerateBreakDown()
    End Sub

    Private Sub dtBasisPeriodEnd_EditValueChanged(sender As Object, e As EventArgs) Handles dtBasisPeriodEnd.EditValueChanged
        GenerateBreakDown()
    End Sub

    Private Sub txtAmountTaxPayable_EditValueChanged(sender As Object, e As EventArgs) Handles txtAmountTaxPayable.EditValueChanged
        CalcEstimationPercent()
    End Sub

    Private Sub GridView1_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated
        Try
            Dim rowHandle As Integer = e.RowHandle
            Dim CurrPenalty As Decimal = 0
            Dim SubTotal As Decimal = 0

            If rowHandle < 0 OrElse rowHandle > (DsCP204.Tables(MainTable_Details).Rows.Count - 1) Then
                Exit Sub
            End If

            Dim dtRow As DataRow = DsCP204.Tables(MainTable_Details).Rows(rowHandle)
            Dim dtRowPrevious As DataRow = Nothing

            If rowHandle <> 0 Then
                dtRowPrevious = DsCP204.Tables(MainTable_Details).Rows(rowHandle - 1)
            End If

            If dtRow Is Nothing Then
                Exit Sub
            End If

            If IsDBNull(dtRow(MainTable_Payment1)) Then
                Exit Sub
            End If

            Dim Installment As Decimal = CDec(IIf(IsDBNull(dtRow(MainTable_InstallmentAmount)), 0, dtRow(MainTable_InstallmentAmount)))
            Dim Amount1 As Decimal = CDec(IIf(IsDBNull(dtRow(MainTable_Amount1)), 0, dtRow(MainTable_Amount1)))
            Dim Amount2 As Decimal = CDec(IIf(IsDBNull(dtRow(MainTable_Amount2)), 0, dtRow(MainTable_Amount2)))
            Dim dtNextPaymentDue As DateTime = CDate(dtRow(MainTable_PaymentDue)).AddDays(+30)
            'checking if payment lated
            'if late have penalty
            If IsDBNull(dtRow(MainTable_Payment2)) Then
                'check if payment 2 is null

                If DateDiff(DateInterval.Day, dtRow(MainTable_PaymentDue), dtRow(MainTable_Payment1)) > 0 Then
                    If (Amount1 + Amount2) >= Installment Then
                        '9k > 8333
                        CurrPenalty += Installment * 0.1
                    Else
                        CurrPenalty += (Installment - Amount1) * 0.1
                    End If
                End If

                If (Amount1 + Amount2) < Installment Then
                    CurrPenalty += (Installment - (Amount1 + Amount2)) * 0.1
                End If

                If DateDiff(DateInterval.Day, dtNextPaymentDue, dtRow(MainTable_Payment1)) > 0 Then
                    CurrPenalty += (CurrPenalty + Installment) * 0.05
                End If

            Else

                If DateDiff(DateInterval.Day, dtRow(MainTable_PaymentDue), dtRow(MainTable_Payment1)) > 0 Then
                    CurrPenalty += Installment * 0.1
                End If

                If DateDiff(DateInterval.Day, dtRow(MainTable_PaymentDue), dtRow(MainTable_Payment2)) > 0 Then
                    CurrPenalty += (Installment - Amount1) * 0.1
                End If

                If (Amount1 + Amount2) < Installment Then
                    CurrPenalty += (Installment - (Amount1 + Amount2)) * 0.1
                End If

                If DateDiff(DateInterval.Day, dtNextPaymentDue, dtRow(MainTable_Payment1)) > 0 Then
                    CurrPenalty += (CurrPenalty + Installment) * 0.05
                End If

            End If

            dtRow(MainTable_Penalty) = CurrPenalty
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GridView1_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.RowHandle)

                If IsDBNull(row(MainTable_Payment1)) = False AndAlso IsDBNull(row(MainTable_Amount1)) = True Then
                    e.ErrorText = "Please enter the payment amount 1."
                    e.Valid = False
                    Exit Sub
                End If

                If IsDBNull(row(MainTable_Payment2)) = False AndAlso IsDBNull(row(MainTable_Amount2)) = True Then
                    e.ErrorText = "Please enter the payment amount 2."
                    e.Valid = False
                    Exit Sub
                Else

                    If IsDBNull(row(MainTable_Payment2)) = False AndAlso DateDiff(DateInterval.Day, CDate(row(MainTable_Payment1)), CDate(row(MainTable_Payment2))) < 0 Then
                        e.ErrorText = "Payment date 2 cannot less than payment date 1."
                        e.Valid = False
                        Exit Sub
                    End If
                End If


            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Try
            '  GridControl1.PrintDialog()
            '  GridControl1.ShowPrintPreview()
            Dim link As New PrintableComponentLink(New PrintingSystem())

            link.Component = GridControl1

            link.Landscape = True

            link.ShowPreview()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
        Try
            Dim rslt As DialogResult = FolderBrowserDialog1.ShowDialog

            If rslt = Windows.Forms.DialogResult.OK Then
                Dim Path As String = FolderBrowserDialog1.SelectedPath

                GridControl1.ExportToXlsx(Path & "\CP204_MonthBreakDown_" & Format(Now, "ddMMMyyyyHHmmss") & ".xlsx")
            End If



        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            If isValid() Then
                Dim tmpID As Integer = 0
                Dim dtRow As DataRow = Nothing

                tmpID = GETCP204KEY(ErrorLog)
                tmpID += 1

                dtRow = DsCP204.Tables("BORANG_CP204").NewRow

                If isEdit Then
                    dtRow("BCP_KEY") = ID
                Else
                    dtRow("BCP_KEY") = tmpID
                End If

                dtRow("BCP_REF_NO") = IIf(cboRefNo.EditValue Is Nothing, DBNull.Value, cboRefNo.EditValue)
                dtRow("BCP_CO_NAME") = IIf(cboRefNo.EditValue Is Nothing, DBNull.Value, cboRefNo.Properties.View.GetFocusedRowCellValue("CompanyName"))
                dtRow("BCP_CO_REGNO") = IIf(txtRefRegistrationNo.EditValue Is Nothing, DBNull.Value, txtRefRegistrationNo.EditValue)
                dtRow("BCP_CORRESPOND_ADD1") = IIf(txtAdd1_Cor.EditValue Is Nothing, DBNull.Value, txtAdd1_Cor.EditValue)
                dtRow("BCP_CORRESPOND_ADD2") = IIf(txtAdd2_Cor.EditValue Is Nothing, DBNull.Value, txtAdd2_Cor.EditValue)
                dtRow("BCP_CORRESPOND_ADD3") = IIf(txtAdd3_Cor.EditValue Is Nothing, DBNull.Value, txtAdd3_Cor.EditValue)
                dtRow("BCP_CORRESPOND_POST") = IIf(txtPostcode_Cor.EditValue Is Nothing, DBNull.Value, txtPostcode_Cor.EditValue)
                dtRow("BCP_CORRESPOND_CITY") = IIf(txtCity_Cor.EditValue Is Nothing, DBNull.Value, txtCity_Cor.EditValue)
                dtRow("BCP_CORRESPOND_STATE") = IIf(cboState_Cor.EditValue Is Nothing, DBNull.Value, cboState_Cor.EditValue)
                dtRow("BCP_DATE") = IIf(dtDate.EditValue Is Nothing, DBNull.Value, dtDate.EditValue)
                dtRow("BCP_YA") = IIf(cboYA.EditValue Is Nothing, DBNull.Value, cboYA.EditValue)
                dtRow("BCP_ESTIMATED_TAX") = IIf(txtAmountTaxPayable.EditValue Is Nothing, DBNull.Value, txtAmountTaxPayable.EditValue)
                dtRow("BCP_ACC_PERIOD_FR") = IIf(dtAccStart.EditValue Is Nothing, DBNull.Value, dtAccStart.EditValue)
                dtRow("BCP_ACC_PERIOD_TO") = IIf(dtAccEnd.EditValue Is Nothing, DBNull.Value, dtAccEnd.EditValue)
                dtRow("BCP_BASIS_PERIOD_FR") = IIf(dtBasisPeriodStart.EditValue Is Nothing, DBNull.Value, dtBasisPeriodStart.EditValue)
                dtRow("BCP_BASIS_PERIOD_TO") = IIf(dtBasisPeriodEnd.EditValue Is Nothing, DBNull.Value, dtBasisPeriodEnd.EditValue)
                If chkCommencement.Checked Then
                    dtRow("BCP_NEWCO_DATE") = IIf(dtCommencement.EditValue Is Nothing, DBNull.Value, dtCommencement.EditValue)
                Else
                    dtRow("BCP_NEWCO_DATE") = DBNull.Value
                End If

                dtRow("BCP_TO_MONTH") = IIf(txtFirstInstallmentCount.EditValue Is Nothing, DBNull.Value, txtFirstInstallmentCount.EditValue)
                dtRow("BCP_FIRST_INSTALMENT") = IIf(txtFirstInstallment.EditValue Is Nothing, DBNull.Value, txtFirstInstallment.EditValue)
                dtRow("BCP_LAST_INSTALMENT") = IIf(txtLastInstallment.EditValue Is Nothing, DBNull.Value, txtLastInstallment.EditValue)
                dtRow("BCP_NEWCO_BAS_FR") = IIf(dtBasisPeriodYAStart.EditValue Is Nothing, DBNull.Value, dtBasisPeriodYAStart.EditValue)
                dtRow("BCP_NEWCO_BAS_TO") = IIf(dtBasisPeriodYAEnd.EditValue Is Nothing, DBNull.Value, dtBasisPeriodYAEnd.EditValue)
                dtRow("BCP_NEWCO_BAS_SUB_FR") = IIf(dtBasisPeriodSecStart.EditValue Is Nothing, DBNull.Value, dtBasisPeriodSecStart.EditValue)
                dtRow("BCP_NEWCO_BAS_SUB_TO") = IIf(dtBasisPeriodSecEnd.EditValue Is Nothing, DBNull.Value, dtBasisPeriodSecEnd.EditValue)
                dtRow("BCP_CURR_CORR_ADD1") = IIf(txtAdd1_Alt_Cor.EditValue Is Nothing, DBNull.Value, txtAdd1_Alt_Cor.EditValue)
                dtRow("BCP_CURR_CORR_ADD2") = IIf(txtAdd2_Alt_Cor.EditValue Is Nothing, DBNull.Value, txtAdd2_Alt_Cor.EditValue)
                dtRow("BCP_CURR_CORR_ADD3") = IIf(txtAdd3_Alt_Cor.EditValue Is Nothing, DBNull.Value, txtAdd3_Alt_Cor.EditValue)
                dtRow("BCP_CURR_CORR_POST") = IIf(txtPostcode_Alt_Cor.EditValue Is Nothing, DBNull.Value, txtPostcode_Alt_Cor.EditValue)
                dtRow("BCP_CURR_CORR_CITY") = IIf(txtCity_Alt_Cor.EditValue Is Nothing, DBNull.Value, txtCity_Alt_Cor.EditValue)
                dtRow("BCP_CURR_CORR_STATE") = IIf(cboState_Alt_Cor.EditValue Is Nothing, DBNull.Value, cboState_Alt_Cor.EditValue)
                dtRow("BCP_REV_ESTIMATED_TAX") = 0 'IIf(cboState_Alt_Cor.EditValue Is Nothing, DBNull.Value, cboState_Alt_Cor.EditValue)
                dtRow("BCP_BAL_ESTIMATED_TAX") = 0
                dtRow("BCP_TOTAL_PAID") = 0
                dtRow("BCP_FR_MONTH") = 0
                dtRow("BCP_FROM_INSTALMENT") = "0"
                dtRow("BCP_NEW_ACC_PERIOD_FR") = DBNull.Value
                dtRow("BCP_NEW_ACC_PERIOD_TO") = DBNull.Value
                dtRow("BCP_BASIS_PERIOD_FLW_FR") = DBNull.Value
                dtRow("BCP_BASIS_PERIOD_FLW_TO") = DBNull.Value
                dtRow("BCP_BASIS_PERIOD_SUB_FR") = DBNull.Value
                dtRow("BCP_BASIS_PERIOD_SUB_TO") = DBNull.Value
                dtRow("BCP_FORM") = "CP204"
                dtRow("BCP_VERSION") = 1
                dtRow("BCP_ESTIMATED") = 0
                If rbPeriodEnded.EditValue = tmpID Then
                    dtRow("BCP_INDICATE") = 1
                Else
                    dtRow("BCP_INDICATE") = 0
                End If

                dtRow("BCP_CHKM") = "T"

                If chkSME.Checked = True Then
                    dtRow("BCP_SME_PERIOD_FR") = IIf(cboYA_From_SME.EditValue Is Nothing, DBNull.Value, cboYA_From_SME.EditValue)
                    dtRow("BCP_SME_PERIOD_TO") = IIf(cboYA_To_SME.EditValue Is Nothing, DBNull.Value, cboYA_To_SME.EditValue)
                Else
                    dtRow("BCP_SME_PERIOD_FR") = DBNull.Value
                    dtRow("BCP_SME_PERIOD_TO") = DBNull.Value
                End If

                dtRow("ModifiedBy") = My.Computer.Name
                dtRow("ModifiedDateTime") = Now
                DsCP204.Tables("BORANG_CP204").Rows.Add(dtRow)

                If isEdit Then
                    If mdlProcess.Update_CP204(DsCP204, ErrorLog) Then
                        MsgBox("Succesfully update CP204", MsgBoxStyle.Information)
                    Else
                        MsgBox("Unsuccesfully update CP204", MsgBoxStyle.Critical)
                    End If
                Else
                    If mdlProcess.Save_CP204(DsCP204, ErrorLog) Then
                        MsgBox("Succesfully saved CP204", MsgBoxStyle.Information)
                        ID = tmpID
                    Else
                        MsgBox("Unsuccesfully saved CP204", MsgBoxStyle.Critical)
                    End If
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Function isValid() As Boolean
        Try
            If cboRefNo.EditValue Is Nothing OrElse cboRefNo.EditValue = "" Then
                cboRefNo.Focus()
                MsgBox("Please select tax payer.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If cboYA.EditValue Is Nothing OrElse cboYA.EditValue = "" Then
                cboYA.Focus()
                MsgBox("Please select year assessment.", MsgBoxStyle.Exclamation)
                Return False
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
        Try
            Me.LoadData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboRefNo_EditValueChanged_1(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            txtRefNo.EditValue = cboRefNo.EditValue
            txtRefRegistrationNo.EditValue = cboRefNo.Properties.View.GetFocusedRowCellValue("CompanyNo") 'cboRefNo.GetSelectedDataRow()
            GenerateBreakDown()
        Catch ex As Exception

        End Try
    End Sub
End Class