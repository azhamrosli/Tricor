Public Class rptMovementNormal


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

    'Private Sub XrLabel3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel3.BeforePrint
    '    
    '    

    '    
    '    
    '    
    '    
    '    
    '    
    '    


    '    

    '    
    'End Sub

    Private Sub XrLabel6_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel6.BeforePrint
       
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