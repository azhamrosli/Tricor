Public Class frmExemptionCalculator 

    Private Sub frmExemptionCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CalcExemption(ByVal STU_A As Decimal, ByVal AGG_A As Decimal, ByVal CHAR_A As Decimal, ByRef CHARBIZ_A As Decimal, _
                              ByVal STU_B As Decimal, ByVal AGG_B As Decimal, ByVal CHAR_B As Decimal, ByRef CHARBIZ_B As Decimal, _
                              ByRef TOTAL_A_B As Decimal, ByRef Step4_Total_A_B As Decimal, ByRef Step4_B As Decimal, _
                              ByRef Step4Total As Decimal, ByRef Rate As Decimal, ByRef Step6_A As String, ByRef Step6_B As String, _
                              ByRef Step6_C As String, ByRef Step6_D As String, ByRef Total As Decimal, ByVal isSME As Boolean, ByRef IndexRate As Integer)

        Try
            If STU_A = 0 Then
                CHARBIZ_A = 0
            Else
                CHARBIZ_A = STU_A / AGG_A * CHAR_A
            End If

            If STU_B = 0 Then
                CHARBIZ_B = 0
            Else
                CHARBIZ_B = STU_B / AGG_B * CHAR_B
            End If

            TOTAL_A_B = CHARBIZ_A - CHARBIZ_B


            If isSME = True AndAlso TOTAL_A_B <= 499999 Then
                Step4_Total_A_B = 0
                Step4_B = 0
                Step4Total = 0

                Rate = 0


                Step6_A = "0 X 24%"
                Step6_B = "0 X " & Rate
                Step6_C = "0 X 24%"
                Step6_D = "0 X 24%"

                Total = 0
            Else
                Step4_Total_A_B = TOTAL_A_B
                Step4_B = CHARBIZ_B
                Step4Total = (TOTAL_A_B / CHARBIZ_B) * 100

                Rate = GetRate(Step4Total, IndexRate)

                Dim tmp6_A As Decimal = 0
                Dim tmp6_B As Decimal = 0
                Dim tmp6_C As Decimal = 0
                Dim subTotal As Decimal = 0

                tmp6_A = ((TOTAL_A_B / 100) * 24).ToString("N2")
                tmp6_B = ((TOTAL_A_B / 100) * Rate).ToString("N2")
                tmp6_C = ((TOTAL_A_B / 100) * 24).ToString("N2")

                Step6_A = CStr(TOTAL_A_B.ToString("N2")) & " X 24%"
                Step6_B = CStr(TOTAL_A_B.ToString("N2")) & " X " & Rate & "%"
                Step6_C = CStr(TOTAL_A_B.ToString("N2")) & " X 24%"
                Step6_D = CStr(TOTAL_A_B.ToString("N2")) & " X 24%"

                subTotal = ((tmp6_A - tmp6_B) / tmp6_C) * TOTAL_A_B


                Total = subTotal
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Function GetRate(ByVal Value As Decimal, ByRef Index As Integer) As Decimal
        Try

            If Value <= 4.9 Then
                Index = 0
                Return 24
            ElseIf Value >= 5 And Value <= 9.99 Then
                Index = 1
                Return 23
            ElseIf Value >= 10 And Value <= 14.99 Then
                Index = 2
                Return 22
            ElseIf Value >= 15 And Value <= 19.99 Then
                Index = 3
                Return 21
            ElseIf Value >= 20 Then
                Index = 4
                Return 20
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Sub txtSta_A_EditValueChanged(sender As Object, e As EventArgs) Handles txtSta_A.EditValueChanged, txtSta_B.EditValueChanged, txtChar_A.EditValueChanged, txtChar_B.EditValueChanged, txtAgg_A.EditValueChanged, txtAgg_B.EditValueChanged, chkSME.CheckedChanged
        Try
            CalcExemption(txtSta_A.EditValue, txtAgg_A.EditValue, txtChar_A.EditValue, txtCharBiz_A.EditValue, _
                          txtSta_B.EditValue, txtAgg_B.EditValue, txtChar_B.EditValue, txtCharBiz_B.EditValue, _
                          txtTotal_A_B.EditValue, txtStep4_Total_A_B.EditValue, txtStep4_B.EditValue, txtStep4Total.EditValue, _
                          txtRate.EditValue, txtStep6_A.EditValue, txtStep6_B.EditValue, txtStep6_C.EditValue, txtStep6_D.EditValue, _
                          txtTotal.EditValue, chkSME.Checked, rgbRate.SelectedIndex)

        Catch ex As Exception

        End Try
    End Sub

End Class