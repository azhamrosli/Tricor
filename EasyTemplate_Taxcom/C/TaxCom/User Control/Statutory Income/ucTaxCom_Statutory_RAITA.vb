Public Class ucTaxCom_Statutory_RAITA
    Public Type As Type_StatutoryIncome_RAITA = Type_StatutoryIncome_RAITA.RA
    Public rowData As DataRow = Nothing
    Public Enum Type_StatutoryIncome_RAITA
        RA = 0
        ITA = 1
    End Enum
    Public WithEvents AdjustedIncome As AdjustedIncome

    Private Sub ucTaxCom_Statutory_RAITA_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub
    Public Sub LoadData()
        Try
            Select Case Type
                Case Type_StatutoryIncome_RAITA.RA
                    txtBalancingAllowance.EditValue = IIf(IsDBNull(rowData("TC_RA_BALANCINGALLOWANCE")), 0, rowData("TC_RA_BALANCINGALLOWANCE"))
                    txtRate1.EditValue = IIf(IsDBNull(rowData("TC_RA_RATE1")), 0, rowData("TC_RA_RATE1"))
                    txtQlfCapExp.EditValue = IIf(IsDBNull(rowData("TC_RA_QUALIFYINGCAPITALEXP")), 0, rowData("TC_RA_QUALIFYINGCAPITALEXP"))
                    txtTotal1.EditValue = IIf(IsDBNull(rowData("TC_RA_QUALIFYINGCAPITALEXP_AMOUNT")), 0, rowData("TC_RA_QUALIFYINGCAPITALEXP_AMOUNT"))

                    'txtTotal2.EditValue = IIf(IsDBNull(row("TC_RA_RATE1")), 0, row("TC_RA_RATE1"))
                    'txtRate2.EditValue = IIf(IsDBNull(row("TC_RA_RATE1")), 0, row("TC_RA_RATE1"))
                    'txtStatutoryIncome.EditValue = IIf(IsDBNull(row("TC_RA_RATE1")), 0, row("TC_RA_RATE1"))
                    'txtRestriction.EditValue = IIf(IsDBNull(row("TC_RA_RATE1")), 0, row("TC_RA_RATE1"))
                    'txtSCH7A.EditValue = IIf(IsDBNull(row("TC_RA_RATE1")), 0, row("TC_RA_RATE1"))
                    'txtSCH7A_StatutoryIncome.EditValue = IIf(IsDBNull(row("TC_RA_RATE1")), 0, row("TC_RA_RATE1"))
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtQlfCapExp_EditValueChanged(sender As Object, e As EventArgs) Handles txtQlfCapExp.EditValueChanged, txtRate1.EditValueChanged
        Try
            If IsNumeric(txtRate1.EditValue) = False AndAlso CInt(txtRate1.EditValue) = 0 Then
                Exit Sub
            End If
            If IsNumeric(txtQlfCapExp.EditValue) = False AndAlso CInt(txtQlfCapExp.EditValue) = 0 Then
                Exit Sub
            End If

            Dim Total As Decimal = 0

            Total = CDec(txtRate1.EditValue) / 100 * CDec(txtQlfCapExp.EditValue)

            txtTotal1.EditValue = CInt(Total)
        Catch ex As Exception

        End Try
    End Sub

End Class
