Imports System.ComponentModel
Imports System.Text


Partial Public Class frmStartup
    Inherits DevExpress.XtraEditors.XtraForm

    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        If My.Settings.ThemeName <> "" Then
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = My.Settings.ThemeName
        Else
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "DevExpress Dark Style" ' "Office 2013"
        End If
        InitializeComponent()
    End Sub
    Private Sub frmStartup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Timer1.Enabled = True
            Timer1.Start()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Timer1.Stop()
            'mdlProcess.ArgParam2 = "0388601701"
            'mdlProcess.ArgParam3 = "2016"
            frmHome.Show()
            'If mdlProcess.ArgParam0 = "" Then
            '    MsgBox("Unable to find parameter")
            '    Me.Close()
            'End If

            'Select Case mdlProcess.ArgParam0.ToLower
            '    Case "frmca"
            '        Me.Hide()
            '        frmCA.Show()
            '    Case "frm_rptlampirana1"
            '        Me.Hide()
            '        frm_rptLampiranA1.Show()
            '    Case "frmhp"
            '        Me.Hide()
            '        frmHP.Show()
            '    Case "frmdisposal"
            '        Me.Hide()
            '        frmDisposal.Show()
            '    Case "frmpnl"
            '        frmPNL.Show()
            '    Case "frmmovement"
            '        frmMovement.Show()
            '    Case "frmmovementcomplex"
            '        frmMovementComplex.Show()
            '    Case "frmdeemedinterest"
            '        frmDeemedInterest.Show()
            '    Case "frmcp204_penaltylate"
            '        frmCP204_PenaltyLate.Show()
            '    Case "frmreport_test"
            '        frmReport_Test.Show()
            '    Case "frmcp204"
            '        frmCP204.Show()
            '    Case "frmhome"

            '    Case Else
            '        MsgBox("Unable to find form name " & mdlProcess.ArgParam0)
            '        Me.Close()
            'End Select

        Catch ex As Exception

        End Try
    End Sub
End Class
