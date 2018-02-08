Public Class rptPNL_Details
    Dim PLST_SALES_C As Integer = 0
    Dim PLFST_OPENSTOCK_C As Integer = 0
    Dim PLFST_PURCHASE_C As Integer = 0
    Private Sub txtRUN_PLST_SALES_SummaryRowChanged(sender As Object, e As EventArgs) Handles txtRUN_PLST_SALES.SummaryRowChanged
        Try
            PLST_SALES_C += 1

            If PLST_SALES_C > 1 Then
                PF_PLST_SALES.Visible = True
            Else
                PF_PLST_SALES.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtRUN_PLFST_OPENSTOCK_SummaryRowChanged(sender As Object, e As EventArgs) Handles txtRUN_PLFST_OPENSTOCK.SummaryRowChanged
        Try
            PLFST_OPENSTOCK_C += 1

            If PLFST_OPENSTOCK_C > 1 Then
                PF_PLFST_OPENSTOCK.Visible = True
            Else
                PF_PLFST_OPENSTOCK.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtRUN_PLFST_PURCHASE_SummaryRowChanged(sender As Object, e As EventArgs) Handles txtRUN_PLFST_PURCHASE.SummaryRowChanged
        Try
            PLFST_PURCHASE_C += 1

            If PLFST_PURCHASE_C > 1 Then
                RF_PLFST_PURCHASE.Visible = True
            Else
                RF_PLFST_PURCHASE.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class