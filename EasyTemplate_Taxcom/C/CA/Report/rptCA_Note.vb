Public Class rptCA_Note
    Private Sub XrTableCell1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrTableCell1.BeforePrint
        Try
            If Me.FontSize.Value <= 0 Then
                Me.FontSize.Value = 9.75
            End If
            XrTableCell1.Font = New Font("Arial", Me.FontSize.Value)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub XrTable3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrTable3.BeforePrint
        Try
            If Me.FontSize.Value <= 0 Then
                Me.FontSize.Value = 9.75
            End If
            XrTable3.Font = New Font("Arial", Me.FontSize.Value, FontStyle.Bold)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub XrTable2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrTable2.BeforePrint
        Try
            If Me.FontSize.Value <= 0 Then
                Me.FontSize.Value = 9.75
            End If
            XrTable2.Font = New Font("Arial", Me.FontSize.Value)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub XrLabel1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel1.BeforePrint
        Try
            If Me.FontSize.Value <= 0 Then
                Me.FontSize.Value = 9.75
            End If
            XrLabel1.Font = New Font("Arial", Me.FontSize.Value)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub XrTable1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrTable1.BeforePrint
        Try
            If Me.FontSize.Value <= 0 Then
                Me.FontSize.Value = 9.75
            End If
            XrTable1.Font = New Font("Arial", Me.FontSize.Value)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub XrLabel2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel2.BeforePrint
        Try
            If Me.FontSize.Value <= 0 Then
                Me.FontSize.Value = 9.75
            End If
            XrLabel2.Font = New Font("Arial", Me.FontSize.Value)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
End Class