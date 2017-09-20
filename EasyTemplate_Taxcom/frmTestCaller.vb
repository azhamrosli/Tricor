Imports System.Collections

Public Class frmTestCaller

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Try
            If txtRefNo.Text = "" Then
                MsgBox("Please enter reference no.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = Application.StartupPath & "\ET_Taxcom.exe"
            pHelp.Arguments = ComboBox1.Text.ToString.ToLower & ",TAXCOM_C," & txtRefNo.Text & "," & txtYA.Text
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmTestCaller_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class