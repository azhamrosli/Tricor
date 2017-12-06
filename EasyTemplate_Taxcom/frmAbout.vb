﻿Public Class frmAbout 

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lblVersion.Text = "Version : V" & mdlProcess.V1 & "." & mdlProcess.V2 & "." & mdlProcess.V3 & "." & mdlProcess.V4 & " R." & System.Reflection.Assembly.GetExecutingAssembly.GetName.Version.Revision.ToString

            lblPCName.Text = "PC Name : " & My.Computer.Name
            txtUpdateLog.EditValue = My.Resources.UpdateNo

            lblUserLicense.Text = "User Licenses : 15 Users"

            Dim TotalSize As Decimal = 0
            Dim Ram As Decimal = 0
            For Each tmp As System.IO.DriveInfo In System.IO.DriveInfo.GetDrives()
                If tmp.IsReady Then
                    TotalSize += tmp.TotalFreeSpace
                End If

            Next

            lblStorage.Text = "Storage : Mininum Requirement : 5 GB / " & String.Format("Current : {0} GBytes", System.Math.Round(TotalSize / (1024 * 1024 * 1024)), 2).ToString

            Ram = My.Computer.Info.TotalPhysicalMemory
            lblRAM.Text = "RAM : Mininum Requirement : 4 GB / " & String.Format("Current : {0} GBytes", System.Math.Round(Ram / (1024 * 1024 * 1024)), 2).ToString

            Ram = Ram / (1024 * 1024 * 1024)

            If Ram < 4 Then
                lblStatus.Text = "Status : Unsupported - it will be slow down your taxoffice and pc"
            ElseIf Ram >= 4 And Ram <= 7 Then
                lblStatus.Text = "Status : Supported - mybe sometime taxoffice will be slow"
            Else
                lblStatus.Text = "Status : Good"
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class