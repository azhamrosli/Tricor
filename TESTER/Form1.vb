Public Class Form1

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Try
            If txtRefNo.Text = "" Then
                MsgBox("Please enter reference no.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "C:\Users\Azham\Documents\GitHub\Tricor\EasyTemplate_Taxcom\bin\Debug\ET_Taxcom.exe"
            pHelp.Arguments = ComboBox1.Text.ToString.ToLower & ",TAXCOM_C," & txtRefNo.Text & "," & txtYA.Text
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)

        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub
End Class
