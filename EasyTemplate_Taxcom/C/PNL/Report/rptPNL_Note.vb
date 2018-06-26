Public Class rptpnl_Note
    Dim clsNote As clsNote_PNL
    Private Sub lblTitleNote_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTitleNote.BeforePrint
        Try
            If clsNote Is Nothing Then
                clsNote = New clsNote_PNL
            End If

            Dim dt As DataTable = Nothing

            dt = clsNote.Load_Note(Me.GetCurrentColumnValue("Parent_KEY"), Me.paramKeyName.Value, Nothing)

            If dt IsNot Nothing Then
                lblTitleNote.Visible = True
                XrLabel1.Visible = True
            Else
                lblTitleNote.Visible = False
                XrLabel1.Visible = False
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub XrLabel3_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
        Try

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
End Class