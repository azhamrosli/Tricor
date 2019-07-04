Public Class rptPNL_NoteNew
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


    Private Sub XrLabel3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel1.BeforePrint, XrLabel2.BeforePrint
        Try
            If Me.GetCurrentColumnValue("KeyName") = Me.paramKeyName.Value Then

                If Me.GetCurrentColumnValue("Note") <> "" AndAlso (Me.GetCurrentColumnValue("TitleNote").ToString.Contains("Note") OrElse Me.GetCurrentColumnValue("TypeNote") = 1) Then
                    XrLabel1.Visible = True
                    XrLabel2.Visible = True
                Else
                    XrLabel1.Visible = False
                    XrLabel2.Visible = False
                End If
                'Else
                ' lblTitleNote.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class