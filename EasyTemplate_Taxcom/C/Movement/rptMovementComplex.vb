Imports DevExpress.XtraReports.UI

Public Class rptMovementComplex
    Dim Total As Decimal = 0
    Private Sub xrLabel1_SummaryReset(ByVal sender As Object, ByVal e As EventArgs) Handles lblTotalSum.SummaryReset, XrLabel27.SummaryReset, XrLabel29.SummaryReset, XrLabel31.SummaryReset
        ' Reset the result each time a group is printed. 
        Total = 0
    End Sub

    Private Sub xrLabel1_SummaryRowChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lblTotalSum.SummaryRowChanged, XrLabel27.SummaryRowChanged, XrLabel29.SummaryRowChanged, XrLabel31.SummaryRowChanged
        ' Calculate a summary. 
        Total = CDec(XrLabel27.Text) + CDec(XrLabel29.Text) + CDec(XrLabel31.Text) '+ CDec(lblTotal.Text)
    End Sub

    Private Sub xrLabel1_SummaryGetResult(ByVal sender As Object, ByVal e As SummaryGetResultEventArgs) Handles lblTotalSum.SummaryGetResult
        ' Round the result, so that a pack will be taken into account  
        ' even if it contains only one unit. 
        Total = CDec(XrLabel27.Text) + CDec(XrLabel29.Text) + CDec(XrLabel31.Text) '+ CDec(lblTotal.Text)
        e.Result = Total.ToString("N0")
        e.Handled = True
    End Sub

    Private Sub lblTotal_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotal.BeforePrint
        Try
            lblTotal.Text = ((lblGeneral.Text) + CDec(lblSpecifiAllow.Text) + CDec(lblSpecifiAllowNon.Text)).ToString("N0")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DetailReport_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles DetailReport.BeforePrint
        Try
            Try
                Dim dtAdd As DataTable = clsMoveNormal.Load_MovementNormal_Add(Me.paramParentID.Value)

                If dtAdd IsNot Nothing Then
                    If dtAdd.Rows.Count > 1 Then
                        boxAdd.Visible = True
                    Else
                        boxAdd.Visible = False
                    End If
                End If


            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DetailReport1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles DetailReport1.BeforePrint
        Try
            Dim dtDeduct As DataTable = clsMoveNormal.Load_MovementNormal_Deduct(Me.paramParentID.Value)

            If dtDeduct IsNot Nothing Then
                If dtDeduct.Rows.Count > 1 Then
                    boxDeduct.Visible = True
                Else
                    boxDeduct.Visible = False
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class