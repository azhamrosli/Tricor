Imports System.Collections

Public Class frmTestCaller

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Try
            If txtRefNo.Text = "" Then
                MsgBox("Please enter reference no.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Dim pHelp As New ProcessStartInfo With {
                .FileName = Application.StartupPath & "\ET_Taxcom.exe",
                .Arguments = ComboBox1.Text.ToString.ToLower & ",TAXCOM_C," & txtRefNo.Text & "," & txtYA.Text,
                .UseShellExecute = True,
                .WindowStyle = ProcessWindowStyle.Normal
            }
            Dim proc As Process = Process.Start(pHelp)

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub frmTestCaller_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class