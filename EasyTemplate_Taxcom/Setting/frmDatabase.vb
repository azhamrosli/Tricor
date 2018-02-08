Imports System.Data.SqlClient

Public Class frmDatabase
    
    Dim ErrorLog As clsError = Nothing
    Public Status As Boolean = False
    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            Dim SQLCon As SqlConnection

            If chkDefault.Checked = True Then
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

                If mdlProcess.DBConnection_Test(txtServerName.EditValue, txtUser.EditValue, _
                                                txtPassword.EditValue, SQLCon, ErrorLog) = False Then
                    MsgBox("Unable to connect with database.", MsgBoxStyle.Critical)
                End If

                If mdlProcess.DBSetting_SetSetting(txtServerName.Text, txtUser.Text, txtPassword.Text) = False Then
                    MsgBox("Failed to save configuration. Please run this as administrator", MsgBoxStyle.Critical)
                Else
                    Status = True
                    MsgBox("Successfully to save configuration.", MsgBoxStyle.Information)
                    ReConnectServer()
                End If

                My.Settings.ServerName = txtServerName2.EditValue
                My.Settings.UserID = txtUser2.EditValue
                My.Settings.Password = txtPassword2.EditValue
            Else
                If txtServerName2.EditValue Is Nothing OrElse txtServerName2.EditValue.ToString = "" Then
                    txtServerName2.Focus()
                    MsgBox("Please enter server name.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                If txtUser2.EditValue Is Nothing OrElse txtUser2.EditValue.ToString = "" Then
                    txtUser2.Focus()
                    MsgBox("Please enter server name.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                If txtPassword2.EditValue Is Nothing OrElse txtPassword2.EditValue.ToString = "" Then
                    txtPassword2.Focus()
                    MsgBox("Please enter server name.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                If mdlProcess.DBConnection_Test(txtServerName2.EditValue, txtUser2.EditValue, _
                                                txtPassword2.EditValue, SQLCon, ErrorLog) = False Then
                    MsgBox("Unable to connect with database.", MsgBoxStyle.Critical)
                End If

                If mdlProcess.DBSetting_SetSetting(txtServerName2.Text, txtUser2.Text, txtPassword2.Text) = False Then
                    MsgBox("Failed to save configuration. Please run this as administrator", MsgBoxStyle.Critical)
                Else
                    Status = True
                    MsgBox("Successfully to save configuration.", MsgBoxStyle.Information)
                    ReConnectServer()
                End If

                My.Settings.ServerName = txtServerName.EditValue
                My.Settings.UserID = txtUser.EditValue
                My.Settings.Password = txtPassword.EditValue
            End If


        Catch ex As Exception

        End Try
    End Sub
    Private Sub ReConnectServer()
        Try
            frmHome.RefreshData()

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
            chkDefault.Checked = True


            If My.Settings.ServerName IsNot Nothing Then
                txtServerName2.EditValue = My.Settings.ServerName
            Else
                txtServerName2.EditValue = ""
            End If

            If My.Settings.ServerName IsNot Nothing Then
                txtUser2.EditValue = My.Settings.UserID
            Else
                txtUser2.EditValue = ""
            End If

            If My.Settings.ServerName IsNot Nothing Then
                txtPassword2.EditValue = My.Settings.Password
            Else
                txtPassword2.EditValue = ""
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Me.Close()
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

    Private Sub btnViewPass2_MouseDown(sender As Object, e As MouseEventArgs) Handles btnViewPass2.MouseDown
        Try
            txtPassword2.Properties.PasswordChar = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnViewPass2_MouseUp(sender As Object, e As MouseEventArgs) Handles btnViewPass2.MouseUp
        Try
            txtPassword2.Properties.PasswordChar = "*"
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
                If ADO.BackupData(txtIniDir.Text, 0, SQLCon, ErrorLog) = False Then
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
                If ADO.BackupData(txtIniDir.Text, 1, SQLCon, ErrorLog) = False Then
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
                If ADO.BackupData(txtIniDir.Text, 2, SQLCon, ErrorLog) = False Then
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
                If ADO.BackupData(txtIniDir.Text, 3, SQLCon, ErrorLog) = False Then
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
                If ADO.BackupData(txtIniDir.Text, 4, SQLCon, ErrorLog) = False Then
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
                If ADO.BackupData(txtIniDir.Text, 5, SQLCon, ErrorLog) = False Then
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
                If ADO.BackupData(txtIniDir.Text, 6, SQLCon, ErrorLog) = False Then
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
                If ADO.BackupData(txtIniDir.Text, 7, SQLCon, ErrorLog) = False Then
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

    Private Sub chkDefault_CheckedChanged(sender As Object, e As EventArgs) Handles chkDefault.CheckedChanged
        Try
            If chkDefault.Checked = True Then
                chkDefault2.Checked = False
            Else
                chkDefault2.Checked = True
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub chkDefault2_CheckedChanged(sender As Object, e As EventArgs) Handles chkDefault2.CheckedChanged
        Try
            If chkDefault2.Checked = True Then
                chkDefault.Checked = False
            Else
                chkDefault.Checked = True
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class