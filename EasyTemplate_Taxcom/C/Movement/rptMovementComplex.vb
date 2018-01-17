Imports DevExpress.XtraReports.UI

Public Class rptMovementComplex
    Dim Total As Decimal = 0
    Private Sub xrLabel1_SummaryReset(ByVal sender As Object, ByVal e As EventArgs) Handles XrLabel33.SummaryReset, XrLabel27.SummaryReset, XrLabel29.SummaryReset, XrLabel31.SummaryReset
        ' Reset the result each time a group is printed. 
        Total = 0
    End Sub

    Private Sub xrLabel1_SummaryRowChanged(ByVal sender As Object, ByVal e As EventArgs) Handles XrLabel33.SummaryRowChanged, XrLabel27.SummaryRowChanged, XrLabel29.SummaryRowChanged, XrLabel31.SummaryRowChanged
        ' Calculate a summary. 
        Total = CDec(XrLabel27.Text) + CDec(XrLabel29.Text) + CDec(XrLabel31.Text)
    End Sub

    Private Sub xrLabel1_SummaryGetResult(ByVal sender As Object, ByVal e As SummaryGetResultEventArgs) Handles XrLabel33.SummaryGetResult
        ' Round the result, so that a pack will be taken into account  
        ' even if it contains only one unit. 
        Total = CDec(XrLabel27.Text) + CDec(XrLabel29.Text) + CDec(XrLabel31.Text)
        e.Result = Total
        e.Handled = True
    End Sub
End Class