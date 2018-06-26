Public Class frmBalanceSheet 
    Public isEdit As Boolean = False
    Public ID As Integer = 0

    Dim ErrorLog As ClsError = Nothing
    Private Sub frmBalanceSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub


    Public Sub LoadData(Optional ByRef Errorlog As ClsError = Nothing)
        Try
            If CreateLookUpTaxPayer(DataSet:=DsDefault, Errorlog:=Errorlog) = False Then
                MsgBox("Unable to retrive tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If CreateLookUpYA(cboYA, Errorlog, True) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            Application.DoEvents()

            If isEdit = False Then
                If mdlProcess.ArgParam2 <> "" Then
                    cboRefNo.EditValue = mdlProcess.ArgParam2
                End If

                If mdlProcess.ArgParam3 <> "" Then
                    cboYA.EditValue = mdlProcess.ArgParam3
                End If

            Else
                Dim dt As DataTable = ADO.Load_BalanceSheet(ID, Errorlog)

                If dt IsNot Nothing Then

                    cboRefNo.EditValue = IIf(IsDBNull(dt.Rows(0)("BS_REF_NO")), "", dt.Rows(0)("BS_REF_NO"))
                    cboYA.EditValue = IIf(IsDBNull(dt.Rows(0)("BS_YA")), "", dt.Rows(0)("BS_YA"))
                    txtVehicle.EditValue = IIf(IsDBNull(dt.Rows(0)("BS_TRANSPORT")), 0, dt.Rows(0)("BS_TRANSPORT"))
                    txtMachinery.EditValue = IIf(IsDBNull(dt.Rows(0)("BS_MACHINERY")), 0, dt.Rows(0)("BS_MACHINERY"))
                    txtBuilding.EditValue = IIf(IsDBNull(dt.Rows(0)("BS_LAND")), 0, dt.Rows(0)("BS_LAND"))
                    txtOtherFA.EditValue = IIf(IsDBNull(dt.Rows(0)("BS_OTH_FA")), 0, dt.Rows(0)("BS_OTH_FA"))
                    txtInvestment.EditValue = IIf(IsDBNull(dt.Rows(0)("BS_INVESTMENT")), 0, dt.Rows(0)("BS_INVESTMENT"))
                    txtTradeDebtors.EditValue = IIf(IsDBNull(dt.Rows(0)("BS_TRADE_DEBTORS")), 0, dt.Rows(0)("BS_TRADE_DEBTORS"))
                    txtOtherDebtors.EditValue = IIf(IsDBNull(dt.Rows(0)("BS_OTH_DEBTORS")), 0, dt.Rows(0)("BS_OTH_DEBTORS"))
                    txtStock.EditValue = IIf(IsDBNull(dt.Rows(0)("BS_STOCK")), 0, dt.Rows(0)("BS_STOCK"))
                    txtCurYear.EditValue = IIf(IsDBNull(dt.Rows(0)("BS_CURYEARFA")), 0, dt.Rows(0)("BS_CURYEARFA"))
                    txtLoanTo.EditValue = IIf(IsDBNull(dt.Rows(0)("BS_LOAN_DIRECTOR")), 0, dt.Rows(0)("BS_LOAN_DIRECTOR"))
                    txtCashBank.EditValue = IIf(IsDBNull(dt.Rows(0)("BS_CASH")), 0, dt.Rows(0)("BS_CASH"))
                    txtOtherCA.EditValue = IIf(IsDBNull(dt.Rows(0)("BS_OTH_CA")), 0, dt.Rows(0)("BS_OTH_CA"))
                    txtBorrowing.EditValue = IIf(IsDBNull(dt.Rows(0)("BS_LOAN")), 0, dt.Rows(0)("BS_LOAN"))
                    txtTradeCreditor.EditValue = IIf(IsDBNull(dt.Rows(0)("BS_TRADE_CR")), 0, dt.Rows(0)("BS_TRADE_CR"))
                    txtOtherCreditor.EditValue = IIf(IsDBNull(dt.Rows(0)("BS_OTHER_CR")), 0, dt.Rows(0)("BS_OTHER_CR"))
                    txtLoanFrom.EditValue = IIf(IsDBNull(dt.Rows(0)("BS_LOAN_FR_DIR")), 0, dt.Rows(0)("BS_LOAN_FR_DIR"))
                    txtOtherCL.EditValue = IIf(IsDBNull(dt.Rows(0)("BS_OTH_LIAB")), 0, dt.Rows(0)("BS_OTH_LIAB"))
                    txtLongTerm.EditValue = IIf(IsDBNull(dt.Rows(0)("BS_LT_LIAB")), 0, dt.Rows(0)("BS_LT_LIAB"))
                    txtPaidUp.EditValue = IIf(IsDBNull(dt.Rows(0)("BS_CAPITAL")), 0, dt.Rows(0)("BS_CAPITAL"))
                    txtAppropriation.EditValue = IIf(IsDBNull(dt.Rows(0)("BS_PNL_APPR_ACC")), 0, dt.Rows(0)("BS_PNL_APPR_ACC"))
                    txtReserves.EditValue = IIf(IsDBNull(dt.Rows(0)("BS_RESERVE_ACC")), 0, dt.Rows(0)("BS_RESERVE_ACC"))

                    lblModifiedBy.Caption = "Last Update :" & IIf(IsDBNull(dt.Rows(0)("ModifiedBy")), "", dt.Rows(0)("ModifiedBy")) &
                        "(" & Format(CDate(IIf(IsDBNull(dt.Rows(0)("ModifiedDateTime")), Now, dt.Rows(0)("ModifiedDateTime"))), "dd-MMM-yyyy HH:mm") & ")"
                End If
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(Errorlog)
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

    Private Sub txtVehicle_EditValueChanged(sender As Object, e As EventArgs)
        Try
            'txtTotalCA = FormatNumber(CDbl(txtTradeDebtors) + CDbl(txtOtherDebtors) + CDbl(txtStock) + CDbl(txtLoanTo) + CDbl(txtCashBank) + CDbl(txtOtherCA), 0)
            'txtTotalAssets = FormatNumber(CDbl(txtTotalFA) + CDbl(txtInvestment) + CDbl(txtTotalCA), 0)


            txtTotalFA.EditValue = CDec(txtVehicle.EditValue) + CDec(txtMachinery.EditValue) + CDec(txtBuilding.EditValue) + CDec(txtOtherFA.EditValue)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub txtOtherDebtors_EditValueChanged(sender As Object, e As EventArgs)
        Try
            txtTotalCA.EditValue = CDec(txtOtherDebtors.EditValue) + CDec(txtStock.EditValue) + CDec(txtLoanTo.EditValue) + CDec(txtCashBank.EditValue) + CDec(txtOtherCA.EditValue) + CDec(txtTradeDebtors.EditValue)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub


    Private Sub txtTotalCA_EditValueChanged(sender As Object, e As EventArgs)
        Try
            txtTotalAssets.EditValue = CDec(txtTotalCA.EditValue) + CDec(txtInvestment.EditValue) + CDec(txtTotalFA.EditValue)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub txtBorrowing_EditValueChanged(sender As Object, e As EventArgs)
        Try
            txtTotalCL.EditValue = CDec(txtBorrowing.EditValue) + CDec(txtLoanFrom.EditValue) + CDec(txtOtherCreditor.EditValue) + CDec(txtTradeCreditor.EditValue) + CDec(txtOtherCL.EditValue)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub txtLongTerm_EditValueChanged(sender As Object, e As EventArgs)
        Try
            txtTotalLiability.EditValue = CDec(txtTotalCL.EditValue) + CDec(txtLongTerm.EditValue)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub txtPaidUp_EditValueChanged(sender As Object, e As EventArgs)
        Try
            txtTotalEquity.EditValue = CDec(txtPaidUp.EditValue) + CDec(txtReserves.EditValue) + CDec(txtAppropriation.EditValue)

            If CDec(txtPaidUp.EditValue) <= 2500000 And CDec(txtPaidUp.EditValue) > 0 Then
                chkSME.Checked = True
            Else
                chkSME.Checked = False
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub txtTotalEquity_EditValueChanged(sender As Object, e As EventArgs)
        Try
            txtTotalLE.EditValue = CDec(txtTotalEquity.EditValue) + CDec(txtTotalLiability.EditValue)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Try
            If isValid() Then

                If isEdit Then
                    If ADO.Update_BalanceSheet(ID, cboRefNo.EditValue, cboYA.EditValue, txtVehicle.EditValue, txtMachinery.EditValue, _
                                                   txtBuilding.EditValue, txtOtherFA.EditValue, txtTotalFA.EditValue, txtInvestment.EditValue, _
                                                   txtTradeDebtors.EditValue, txtOtherDebtors.EditValue, txtLoanTo.EditValue, txtCashBank.EditValue.ToString, _
                                                   txtOtherCA.EditValue, txtTotalCA.EditValue, txtTotalAssets.EditValue, txtBorrowing.EditValue, _
                                                   txtTradeCreditor.EditValue, txtOtherCreditor.EditValue, txtLoanFrom.EditValue, _
                                                   txtOtherCL.EditValue, txtTotalCL.EditValue, txtLongTerm.EditValue, txtTotalLiability.EditValue, _
                                                   txtPaidUp.EditValue, txtAppropriation.EditValue, txtReserves.EditValue, txtTotalEquity.EditValue, _
                                                   txtTotalLE.EditValue, txtStock.EditValue, "C", txtCurYear.EditValue, _
                                                   chkSME.Checked, "", ErrorLog) Then
                        isEdit = True

                        MsgBox("Successfully updated balance sheet.", MsgBoxStyle.Information)

                        If mdlRefreshTaxComputation.RefreshTaxcom(cboRefNo.EditValue, cboYA.EditValue, ErrorLog) = False Then
                            MsgBox("Failed to refresh tax computation", MsgBoxStyle.Critical)
                        Else
                            Me.LoadData()
                        End If
                    Else
                        MsgBox("Unsuccessfully update balance sheet.", MsgBoxStyle.Critical)
                    End If
                Else
                    Dim ReturnID As Integer = 0
                    If ADO.Save_BalanceSheet(cboRefNo.EditValue, cboYA.EditValue, txtVehicle.EditValue, txtMachinery.EditValue, _
                                                    txtBuilding.EditValue, txtOtherFA.EditValue, txtTotalFA.EditValue, txtInvestment.EditValue, _
                                                    txtTradeDebtors.EditValue, txtOtherDebtors.EditValue, txtLoanTo.EditValue, txtCashBank.EditValue, _
                                                    txtOtherCA.EditValue, txtTotalCA.EditValue, txtTotalAssets.EditValue, txtBorrowing.EditValue, _
                                                    txtTradeCreditor.EditValue, txtOtherCreditor.EditValue, txtLoanFrom.EditValue, _
                                                    txtOtherCL.EditValue, txtTotalCL.EditValue, txtLongTerm.EditValue, txtTotalLiability.EditValue, _
                                                    txtPaidUp.EditValue, txtAppropriation.EditValue, txtReserves.EditValue, txtTotalEquity.EditValue, _
                                                    txtTotalLE.EditValue, txtStock.EditValue, "C", txtCurYear.EditValue, _
                                                    chkSME.Checked, "", ReturnID, ErrorLog) Then
                        isEdit = True
                        ID = ReturnID
                        MsgBox("Successfully saved balance sheet.", MsgBoxStyle.Information)

                        If mdlRefreshTaxComputation.RefreshTaxcom(cboRefNo.EditValue, cboYA.EditValue, ErrorLog) = False Then
                            MsgBox("Failed to refresh tax computation", MsgBoxStyle.Critical)
                        Else
                            Me.LoadData()
                        End If
                    Else
                        MsgBox("Unsuccessfully save balance sheet.", MsgBoxStyle.Critical)
                    End If
                End If
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Function isValid() As Boolean
        Try

            If cboRefNo.EditValue Is Nothing Then
                MsgBox("Please select tax payer.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If cboYA.EditValue Is Nothing Then
                MsgBox("Please select year assessment", MsgBoxStyle.Exclamation)
                Return False
            End If

            If isEdit = False Then
                If ADO.Check_BalanceSheetExist(cboRefNo.EditValue, cboYA.EditValue, ErrorLog) Then
                    MsgBox("Balance sheet already exist.", MsgBoxStyle.Exclamation)
                    Return False
                End If
            End If
            If CDec(txtTotalLE.EditValue) <> CDec(txtTotalAssets.EditValue) Then
                Dim rlst As MsgBoxResult = MessageBox.Show("Assets not equal to Liability + Capital" & vbCrLf & "Assets = " & txtTotalAssets.EditValue & " Liability + Capital = " & txtTotalLE.EditValue & vbCrLf & "Do you want to save the record?", "Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If rlst = MsgBoxResult.No Then
                    Return False
                End If
            End If

            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            Return False
        End Try
    End Function
End Class