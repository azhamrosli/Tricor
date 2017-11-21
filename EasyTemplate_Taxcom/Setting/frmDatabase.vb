Imports System.Data.SqlClient

Public Class frmDatabase
    Dim ErrorLog As clsError = Nothing
    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            If txtServerName.EditValue Is Nothing OrElse txtServerName.EditValue.ToString = "" Then
                txtServerName.Focus()
                MsgBox("Please enter server name.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If txtUser.EditValue Is Nothing OrElse txtUser.EditValue.ToString = "" Then
                txtUser.Focus()
                MsgBox("Please enter server name.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If txtPassword.EditValue Is Nothing OrElse txtPassword.EditValue.ToString = "" Then
                txtPassword.Focus()
                MsgBox("Please enter server name.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim SQLCon As SqlConnection

            If mdlProcess.DBConnection_Test(txtServerName.EditValue, txtUser.EditValue, _
                                            txtPassword.EditValue, SQLCon, ErrorLog) = False Then
                MsgBox("Unable to connect with database.", MsgBoxStyle.Critical)
            End If

            If mdlProcess.DBSetting_SetSetting(txtServerName.Text, txtUser.Text, txtPassword.Text) = False Then
                MsgBox("Failed to save configuration. Please run this as administrator", MsgBoxStyle.Critical)
            Else
                MsgBox("Successfully to save configuration.", MsgBoxStyle.Information)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadData()
        Try
            Dim ServerName As String = Nothing
            Dim UserID As String = Nothing
            Dim Pass As String = Nothing

            If mdlProcess.DBSetting_GetSetting(ServerName, UserID, Pass, ErrorLog) = False Then
                MsgBox("Unable to get database configuration.", MsgBoxStyle.Critical)
                Me.Close()
            End If

            txtServerName.EditValue = ServerName
            txtUser.EditValue = UserID
            txtPassword.EditValue = Pass


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Me.Close()
    End Sub

    Private Sub btnViewPass_Click(sender As Object, e As EventArgs) Handles btnViewPass.Click

    End Sub

    Private Sub btnViewPass_MouseDown(sender As Object, e As MouseEventArgs) Handles btnViewPass.MouseDown
        Try
            txtPassword.Properties.PasswordChar = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnViewPass_MouseUp(sender As Object, e As MouseEventArgs) Handles btnViewPass.MouseUp
        Try
            txtPassword.Properties.PasswordChar = "*"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkSelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectAll.CheckedChanged
        Try
            If chkSelectAll.Checked = True Then

                chkTAX_CA_B.Checked = True
                chkTAX_CA_C.Checked = True
                chkTAX_CA_P.Checked = True
                chkTAXCOM_B.Checked = True
                chkTAXCOM_C.Checked = True
                chkTAXCOM_R.Checked = True
                chkTAXCOM_P.Checked = True
                chkTAXOFFICE.Checked = True

            Else

                chkTAX_CA_B.Checked = False
                chkTAX_CA_C.Checked = False
                chkTAX_CA_P.Checked = False
                chkTAXCOM_B.Checked = False
                chkTAXCOM_C.Checked = False
                chkTAXCOM_R.Checked = False
                chkTAXCOM_P.Checked = False
                chkTAXOFFICE.Checked = False

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBackup_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBackup.ItemClick
        Try
            Application.DoEvents()
            System.Threading.Thread.Sleep(1000)
            Dim SQLCon As SqlConnection = Nothing

            If txtIniDir.EditValue Is Nothing OrElse txtIniDir.EditValue = "" Then
                MsgBox("Please select path to backup database.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If mdlProcess.DBConnection_Test(txtServerName.EditValue, txtUser.EditValue, _
                                           txtPassword.EditValue, SQLCon, ErrorLog) = False Then
                MsgBox("Unable to connect with database.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If chkTAXCOM_C.Checked = True Then
                If mdlProcess.BackupData(txtIniDir.Text, 0, SQLCon, ErrorLog) = False Then
                    lblStatus.Text = "Unsuccessfully backup database." & vbCrLf & ErrorLog.ErrorMessage
                    lblStatus.ForeColor = Color.Red
                    Exit Sub
                End If
                lblStatus.Text = "Successfully backup database TAXCOM_C."
                lblStatus.ForeColor = Color.Green
                Application.DoEvents()
                System.Threading.Thread.Sleep(1000)

                lblStatus.Text = "Starting backup database."
                lblStatus.ForeColor = Color.Black
                Application.DoEvents()
                System.Threading.Thread.Sleep(1000)
            End If




            If chkTAX_CA_C.Checked = True Then
                If mdlProcess.BackupData(txtIniDir.Text, 1, SQLCon, ErrorLog) = False Then
                    lblStatus.Text = "Unsuccessfully backup database." & vbCrLf & ErrorLog.ErrorMessage
                    lblStatus.ForeColor = Color.Red
                    Exit Sub
                End If
                lblStatus.Text = "Successfully backup database TAX_CA_C."
                lblStatus.ForeColor = Color.Green
                Application.DoEvents()
                System.Threading.Thread.Sleep(1000)

                lblStatus.Text = "Starting backup database."
                lblStatus.ForeColor = Color.Black
                Application.DoEvents()
                System.Threading.Thread.Sleep(1000)
            End If


            If chkTAX_CA_B.Checked = True Then
                If mdlProcess.BackupData(txtIniDir.Text, 2, SQLCon, ErrorLog) = False Then
                    lblStatus.Text = "Unsuccessfully backup database." & vbCrLf & ErrorLog.ErrorMessage
                    lblStatus.ForeColor = Color.Red
                    Exit Sub
                End If
                lblStatus.Text = "Successfully backup database TAX_CA_B."
                lblStatus.ForeColor = Color.Green
                Application.DoEvents()
                System.Threading.Thread.Sleep(1000)

                lblStatus.Text = "Starting backup database."
                lblStatus.ForeColor = Color.Black
                Application.DoEvents()
                System.Threading.Thread.Sleep(1000)
            End If


            If chkTAXCOM_B.Checked = True Then
                If mdlProcess.BackupData(txtIniDir.Text, 3, SQLCon, ErrorLog) = False Then
                    lblStatus.Text = "Unsuccessfully backup database." & vbCrLf & ErrorLog.ErrorMessage
                    lblStatus.ForeColor = Color.Red
                    Exit Sub
                End If
                lblStatus.Text = "Successfully backup database TAXCOM_B."
                lblStatus.ForeColor = Color.Green
                Application.DoEvents()
                System.Threading.Thread.Sleep(1000)

                lblStatus.Text = "Starting backup database."
                lblStatus.ForeColor = Color.Black
                Application.DoEvents()
                System.Threading.Thread.Sleep(1000)
            End If


            If chkTAXCOM_P.Checked = True Then
                If mdlProcess.BackupData(txtIniDir.Text, 4, SQLCon, ErrorLog) = False Then
                    lblStatus.Text = "Unsuccessfully backup database." & vbCrLf & ErrorLog.ErrorMessage
                    lblStatus.ForeColor = Color.Red
                    Exit Sub
                End If
                lblStatus.Text = "Successfully backup database TAXCOM_P."
                lblStatus.ForeColor = Color.Green
                Application.DoEvents()
                System.Threading.Thread.Sleep(1000)

                lblStatus.Text = "Starting backup database."
                lblStatus.ForeColor = Color.Black
                Application.DoEvents()
                System.Threading.Thread.Sleep(1000)
            End If


            If chkTAX_CA_P.Checked = True Then
                If mdlProcess.BackupData(txtIniDir.Text, 5, SQLCon, ErrorLog) = False Then
                    lblStatus.Text = "Unsuccessfully backup database." & vbCrLf & ErrorLog.ErrorMessage
                    lblStatus.ForeColor = Color.Red
                    Exit Sub
                End If
                lblStatus.Text = "Successfully backup database TAX_CA_P."
                lblStatus.ForeColor = Color.Green
                Application.DoEvents()
                System.Threading.Thread.Sleep(1000)

                lblStatus.Text = "Starting backup database."
                lblStatus.ForeColor = Color.Black
                Application.DoEvents()
                System.Threading.Thread.Sleep(1000)
            End If


            If chkTAXOFFICE.Checked = True Then
                If mdlProcess.BackupData(txtIniDir.Text, 6, SQLCon, ErrorLog) = False Then
                    lblStatus.Text = "Unsuccessfully backup database." & vbCrLf & ErrorLog.ErrorMessage
                    lblStatus.ForeColor = Color.Red
                    Exit Sub
                End If
                lblStatus.Text = "Successfully backup database TAXOFFICE."
                lblStatus.ForeColor = Color.Green
                Application.DoEvents()
                System.Threading.Thread.Sleep(1000)

                lblStatus.Text = "Starting backup database."
                lblStatus.ForeColor = Color.Black
                Application.DoEvents()
                System.Threading.Thread.Sleep(1000)
            End If

            If chkTAXCOM_R.Checked = True Then
                If mdlProcess.BackupData(txtIniDir.Text, 7, SQLCon, ErrorLog) = False Then
                    lblStatus.Text = "Unsuccessfully backup database." & vbCrLf & ErrorLog.ErrorMessage
                    lblStatus.ForeColor = Color.Red
                    Exit Sub
                End If
                lblStatus.Text = "Successfully backup database TAXCOM_R."
                lblStatus.ForeColor = Color.Green
                Application.DoEvents()
                System.Threading.Thread.Sleep(1000)

                lblStatus.Text = "Starting backup database."
                lblStatus.ForeColor = Color.Black
                Application.DoEvents()
                System.Threading.Thread.Sleep(1000)
            End If

            lblStatus.Text = "Backup Database Done."
            lblStatus.ForeColor = Color.Green
            Application.DoEvents()
            System.Threading.Thread.Sleep(1000)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            Dim rlst As DialogResult = FolderBrowserDialog1.ShowDialog

            If rlst = Windows.Forms.DialogResult.OK Then
                txtIniDir.Text = FolderBrowserDialog1.SelectedPath
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class