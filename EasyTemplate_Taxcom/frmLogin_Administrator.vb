Public Class frmLogin_Administrator 
    Public Status As Boolean = False
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If txtPass.EditValue.ToString = "123456" OrElse txtPass.EditValue.ToString = "P@$$w0rd*****" OrElse txtPass.EditValue.ToString = "P@$$w0rd" Then
                Status = True
                Me.Close()
            Else
                MsgBox("Invalid password. try again", MsgBoxStyle.Exclamation)
                Status = False
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            Status = False
            Me.Close()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

End Class