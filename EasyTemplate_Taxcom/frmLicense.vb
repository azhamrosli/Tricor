﻿Public Class frmLicense 
    Public LicenseKey As String = Nothing

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            If txtLicense.EditValue IsNot Nothing AndAlso txtLicense.EditValue.ToString <> "" Then
                LicenseKey = txtLicense.EditValue.ToString
                Me.Close()
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            LicenseKey = Nothing
            Me.Close()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub frmLicense_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If My.Computer.Name = DeveloperPCName OrElse My.Computer.Name = "SUPERSTATION" Then
                txtLicense.EditValue = "CLN-22052018113101BAA"
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class