﻿Imports System.ComponentModel
Imports System.Text
Imports System.Data.SqlClient


Partial Public Class frmStartup
    Inherits DevExpress.XtraEditors.XtraForm
    Dim ErrorLog As ClsError = Nothing
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        If My.Settings.ThemeName <> "" Then
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = My.Settings.ThemeName
        Else
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2013" ' "Office 2013"
        End If
        InitializeComponent()
    End Sub
    Private Sub frmStartup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Timer1.Enabled = True
            Timer1.Start()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Timer1.Stop()
            Dim SqlCon As SqlConnection = Nothing

            If mdlProcess.DBConnection(sqlCon, ErrorLog) = False Then
                MsgBox("Failed to connect with database.", MsgBoxStyle.Critical)
                Dim frm As New frmDatabase
                frm.ShowDialog()

                If frm.Status = False Then
                    Me.Close()
                End If
            End If


            If LicenseChecking() Then
                frmHome.Show()
            Else
                MsgBox("Failed to validate license key, please contact support team.", MsgBoxStyle.Critical)
                Me.Close()
            End If


        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
End Class
