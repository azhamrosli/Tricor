Public Class rptPNL_Details
    Dim PLST_SALES_bool As Boolean = False
    Dim PLFST_OPENSTOCK_bool As Boolean = False
    Private Sub txtAmLeft_PLFST_SALES_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtAmLeft_PLFST_SALES.BeforePrint, txtAmRight_PLFST_SALES.BeforePrint
        Try

            If PLST_SALES.CurrentRowIndex = 0 AndAlso PLST_SALES_DETAIL_SUB.RowCount = 0 Then
                txtAmLeft_PLFST_SALES.Visible = False
                txtAmRight_PLFST_SALES.Visible = True

            ElseIf PLST_SALES.CurrentRowIndex = 0 AndAlso PLST_SALES_DETAIL_SUB.RowCount > 0 Then
                txtAmLeft_PLFST_SALES.Visible = False
                txtAmRight_PLFST_SALES.Visible = False

                txtSubLeft_PLFS_SALES.Visible = True
                txtSubRight_PLFS_SALES.Visible = False
                PLST_SALES_bool = True

            ElseIf PLST_SALES.CurrentRowIndex > 0 AndAlso PLST_SALES_DETAIL_SUB.RowCount = 0 AndAlso PLST_SALES_bool Then
                txtAmLeft_PLFST_SALES.Visible = True
                txtAmRight_PLFST_SALES.Visible = False

                txtSubLeft_PLFS_SALES.Visible = True
                txtSubRight_PLFS_SALES.Visible = False

            ElseIf PLST_SALES.CurrentRowIndex > 0 AndAlso PLST_SALES_DETAIL_SUB.RowCount = 0 AndAlso PLST_SALES_bool = False Then
                txtAmLeft_PLFST_SALES.Visible = False
                txtAmRight_PLFST_SALES.Visible = True

            ElseIf PLST_SALES.CurrentRowIndex > 0 AndAlso PLST_SALES_DETAIL_SUB.RowCount > 0 Then
                txtAmLeft_PLFST_SALES.Visible = False
                txtAmRight_PLFST_SALES.Visible = False

                txtSubLeft_PLFS_SALES.Visible = True
                txtSubRight_PLFS_SALES.Visible = False
                PLST_SALES_bool = True

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTotal_PLST_SALES_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_PLST_SALES.BeforePrint, lineLeftTotal_PLFST_SALES.BeforePrint
        Try
            If IsNumeric(PLST_SALES.GetCurrentColumnValue("TotalSourceNo")) = True AndAlso CInt(PLST_SALES.GetCurrentColumnValue("TotalSourceNo")) > 1 Then

                Dim PL_KEY As Integer = PLFST_OPENSTOCK.GetCurrentColumnValue("PLFOS_KEY")
                Dim SourceNo As Integer = PLFST_OPENSTOCK.GetCurrentColumnValue("PLFOS_SOURCENO")
                Dim countx As Integer = ADO.Load_PNL_PLFST_SALES_TOTAL_SOURCENO_BYSOURCE(PL_KEY, SourceNo)

                If countx <= 1 Then
                    lineLeftTotal_PLFST_SALES.Visible = False
                    lineRightTotal_PLFST_SALES.Visible = False
                    txtTotal_PLST_SALES.Visible = False
                Else
                    If PLST_SALES_bool Then
                        lineLeftTotal_PLFST_SALES.Visible = True
                        lineRightTotal_PLFST_SALES.Visible = False
                    Else
                        lineLeftTotal_PLFST_SALES.Visible = False
                        lineRightTotal_PLFST_SALES.Visible = True
                    End If

                    txtTotal_PLST_SALES.Visible = True
                End If
            Else
                lineLeftTotal_PLFST_SALES.Visible = False
                txtTotal_PLST_SALES.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtAmRight_PLFST_OPENSTOCK_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtAmLeft_PLFST_OPENSTOCK.BeforePrint, txtAmRight_PLFST_OPENSTOCK.BeforePrint
        Try
            'Dim x As String = XrLabel3.Text
            If PLFST_OPENSTOCK.CurrentRowIndex = 0 AndAlso PLST_OPENSTOCK_DETAIL_SUB.RowCount = 0 Then
                txtAmLeft_PLFST_OPENSTOCK.Visible = False
                txtAmRight_PLFST_OPENSTOCK.Visible = True
            ElseIf PLFST_OPENSTOCK.CurrentRowIndex = 0 AndAlso PLST_OPENSTOCK_DETAIL_SUB.RowCount > 0 Then
                txtAmLeft_PLFST_OPENSTOCK.Visible = False
                txtAmRight_PLFST_OPENSTOCK.Visible = False

                txtSubLeft_PLFST_OPENSTOCK.Visible = True
                txtSubRight_PLFST_OPENSTOCK.Visible = False
                PLFST_OPENSTOCK_bool = True

            ElseIf PLFST_OPENSTOCK.CurrentRowIndex > 0 AndAlso PLST_OPENSTOCK_DETAIL_SUB.RowCount = 0 AndAlso PLFST_OPENSTOCK_bool Then
                txtAmLeft_PLFST_OPENSTOCK.Visible = True
                txtAmRight_PLFST_OPENSTOCK.Visible = False

                txtSubLeft_PLFST_OPENSTOCK.Visible = True
                txtSubRight_PLFST_OPENSTOCK.Visible = False

            ElseIf PLFST_OPENSTOCK.CurrentRowIndex > 0 AndAlso PLST_OPENSTOCK_DETAIL_SUB.RowCount = 0 AndAlso PLFST_OPENSTOCK_bool = False Then
                txtAmLeft_PLFST_OPENSTOCK.Visible = False
                txtAmRight_PLFST_OPENSTOCK.Visible = True


            ElseIf PLFST_OPENSTOCK.CurrentRowIndex > 0 AndAlso PLST_OPENSTOCK_DETAIL_SUB.RowCount > 0 Then
                txtAmLeft_PLFST_OPENSTOCK.Visible = False
                txtAmRight_PLFST_OPENSTOCK.Visible = False

                txtSubLeft_PLFST_OPENSTOCK.Visible = True
                txtSubRight_PLFST_OPENSTOCK.Visible = False
                PLFST_OPENSTOCK_bool = True

            End If
            Application.DoEvents()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtTotal_PLFST_OPENSTOCK_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtTotal_PLFST_OPENSTOCK.BeforePrint, lineLeftTotal_PLFST_OPENSTOCK.BeforePrint
        Try
            If IsNumeric(PLFST_OPENSTOCK.GetCurrentColumnValue("TotalSourceNo")) = True AndAlso CInt(PLFST_OPENSTOCK.GetCurrentColumnValue("TotalSourceNo")) > 1 Then

                Dim PL_KEY As Integer = PLFST_OPENSTOCK.GetCurrentColumnValue("PLFOS_KEY")
                Dim SourceNo As Integer = PLFST_OPENSTOCK.GetCurrentColumnValue("PLFOS_SOURCENO")
                Dim countx As Integer = ADO.Load_PNL_PLFST_OPENSTOCK_TOTAL_SOURCENO_BYSOURCE(PL_KEY, SourceNo)

                If countx <= 1 Then
                    lineLeftTotal_PLFST_OPENSTOCK.Visible = False
                    lineRightTotal_PLFST_OPENSTOCK.Visible = False
                    txtTotal_PLFST_OPENSTOCK.Visible = False
                Else
                    If PLFST_OPENSTOCK_bool Then
                        lineLeftTotal_PLFST_OPENSTOCK.Visible = True
                        lineRightTotal_PLFST_OPENSTOCK.Visible = False
                    Else
                        lineLeftTotal_PLFST_OPENSTOCK.Visible = False
                        lineRightTotal_PLFST_OPENSTOCK.Visible = True
                    End If


                    txtTotal_PLFST_OPENSTOCK.Visible = True
                End If

            Else
                lineLeftTotal_PLFST_OPENSTOCK.Visible = False
                txtTotal_PLFST_OPENSTOCK.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class