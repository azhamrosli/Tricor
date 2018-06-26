Public Class rpt_ITA

    Dim TC_CB_RA_BAL_BF As Decimal = 0
    Dim TC_RA_QU_AMOUNT As Decimal = 0
    Dim LESS_DRAWAL As Decimal = 0
    Dim Total_WithDrawal As Decimal = 0
    Dim Total_Adjustment As Decimal = 0
    Dim TC_CB_RA_CURR As Decimal = 0
    Dim TotalRA As Decimal = 0
    Private Sub CalcRA_Less_Withdrawal_GetValue(sender As Object, e As DevExpress.XtraReports.UI.GetValueEventArgs) Handles CalcRA_Less_Withdrawal.GetValue
        If IsEmptyValue(Total_WithDrawal) Then
            LESS_DRAWAL = 0
        Else
            LESS_DRAWAL = Total_WithDrawal

        End If
    End Sub

    Private Sub lbl_TC_CB_RA_BAL_BF_TextChanged(sender As Object, e As EventArgs) Handles lbl_TC_CB_RA_BAL_BF.TextChanged
        Try
            TC_CB_RA_BAL_BF = CDec(lbl_TC_CB_RA_BAL_BF.Text)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub lblTC_RA_QUA_AMOUNT_TextChanged(sender As Object, e As EventArgs) Handles lblTC_RA_QUA_AMOUNT.TextChanged
        Try
            TC_RA_QU_AMOUNT = CDec(lblTC_RA_QUA_AMOUNT.Text)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub CalcRA_Plus_Withdrawal_GetValue(sender As Object, e As DevExpress.XtraReports.UI.GetValueEventArgs) Handles CalcRA_Plus_Withdrawal.GetValue
        Try
            e.Value = TC_RA_QU_AMOUNT + TC_CB_RA_BAL_BF + LESS_DRAWAL
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub lbl_WithDrawal_Amount_TextChanged(sender As Object, e As EventArgs) Handles lbl_WithDrawal_Amount.TextChanged
        Try
            Total_WithDrawal += CDec(lbl_WithDrawal_Amount.Text)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub lbl_Adjustment_Amount_TextChanged(sender As Object, e As EventArgs) Handles lbl_Adjustment_Amount.TextChanged
        Try
            Total_Adjustment += CDec(lbl_Adjustment_Amount.Text)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub lbl_TC_CB_RA_CURR_TextChanged(sender As Object, e As EventArgs) Handles lbl_TC_CB_RA_CURR.TextChanged
        Try
            TC_CB_RA_CURR = CDec(lbl_TC_CB_RA_CURR.Text)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub lbl_Total_TextChanged(sender As Object, e As EventArgs)
        Try
            '  lbl_Total.Text = 
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub TOTAL_GetValue(sender As Object, e As DevExpress.XtraReports.UI.GetValueEventArgs) Handles TOTAL.GetValue
        e.Value = CDec((TC_RA_QU_AMOUNT + TC_CB_RA_BAL_BF + LESS_DRAWAL) + TC_CB_RA_CURR + Total_Adjustment)
    End Sub
End Class