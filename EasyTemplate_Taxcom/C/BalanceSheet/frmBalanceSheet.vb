Public Class frmBalanceSheet 

    Private Sub frmBalanceSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Public Sub LoadData(Optional ByRef Errorlog As clsError = Nothing)
        Try
            If mdlProcess.CreateLookUpTaxPayer(DsDefault, Errorlog) = False Then
                MsgBox("Unable to retrive tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If mdlProcess.CreateLookUpYA(cboYA, Errorlog, True) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If



        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            AddListOfError(Errorlog)
        End Try
    End Sub



    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            txtRefNo.EditValue = cboRefNo.Properties.View.GetDataRow(cboRefNo.Properties.View.FocusedRowHandle)("CompanyName")
            txtRefRegistrationNo.EditValue = cboRefNo.Properties.View.GetFocusedRowCellValue("CompanyNo")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtVehicle_EditValueChanged(sender As Object, e As EventArgs) Handles txtVehicle.EditValueChanged, txtMachinery.EditValueChanged, txtBuilding.EditValueChanged, txtOtherFA.EditValueChanged
        Try
            'txtTotalCA = FormatNumber(CDbl(txtTradeDebtors) + CDbl(txtOtherDebtors) + CDbl(txtStock) + CDbl(txtLoanTo) + CDbl(txtCashBank) + CDbl(txtOtherCA), 0)
            'txtTotalAssets = FormatNumber(CDbl(txtTotalFA) + CDbl(txtInvestment) + CDbl(txtTotalCA), 0)


            txtTotalFA.EditValue = CDec(txtVehicle.EditValue) + CDec(txtMachinery.EditValue) + CDec(txtBuilding.EditValue) + CDec(txtOtherFA.EditValue)
        Catch ex As Exception

        End Try
    End Sub

End Class