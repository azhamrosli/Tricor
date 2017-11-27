Imports DevExpress.XtraEditors.Repository
Imports System.Data.SqlClient
Public Class ucSQLScript
    Dim ErrorLog As clsError = Nothing
    Dim doc As String = Nothing
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
    Private Sub ucSQLScript_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            LoadData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadData()
        Try
            pnlLoading.Visible = True

            Dim dt As DataTable = mdlProcess.Load_DatabaseList(ErrorLog)

            If dt IsNot Nothing Then

                Dim cbo As RepositoryItemComboBox = CType(cboDatabase.Edit, RepositoryItemComboBox)

                If cbo IsNot Nothing Then

                    For i As Integer = 0 To dt.Rows.Count - 1

                        cbo.Items.Add(IIf(IsDBNull(dt.Rows(i)("name")), 0, dt.Rows(i)("name")))

                    Next

                    cboDatabase.EditValue = "TAXCOM_C"
                End If
            End If

        Catch ex As Exception

        Finally
            pnlLoading.Visible = False

        End Try
    End Sub

    Private Sub btnExecute_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExecute.ItemClick
        Try
         
            pnlLoading.Visible = True

            If cboDatabase.EditValue Is Nothing OrElse cboDatabase.EditValue = "" Then
                MsgBox("Please select database.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Dim strSQL As String = Nothing
            Dim ServerName As String
            Dim UserID As String
            Dim Password As String
            mdlProcess.DBSetting_GetSetting(ServerName, UserID, Password)

            Dim SQLCOn As New SqlConnection("Server=" & ServerName & ";Database=" & cboDatabase.EditValue.ToString & ";User Id=" & UserID & ";Password=" & Password & ";")

            If SQLCOn.State <> ConnectionState.Open Then
                SQLCOn.Open()
            End If

            Dim tabControl As DevExpress.XtraTab.XtraTabControl
            Dim dgv As DevExpress.XtraGrid.GridControl
            Dim dgvView As DevExpress.XtraGrid.Views.Grid.GridView
            Dim txtErrolog As DevExpress.XtraEditors.MemoEdit


            If doc = "docScript1" Then
                tabControl = XtraTabControl1
                dgv = dgvView1
                dgvView = GridView1
                txtErrolog = txtErrorLog1

                If txtScript1.EditValue Is Nothing Then
                    Exit Sub
                End If

                strSQL = txtScript1.EditValue.ToString()
                strSQL = strSQL.Trim.ToUpper
            ElseIf doc = "docScript2" Then
                tabControl = XtraTabControl2
                dgv = dgvView2
                dgvView = GridView2
                txtErrolog = txtErrorLog2

                If txtScript2.EditValue Is Nothing Then
                    Exit Sub
                End If

                strSQL = txtScript2.EditValue.ToString()
                strSQL = strSQL.Trim.ToUpper
            Else
                tabControl = XtraTabControl3
                dgv = dgvView3
                dgvView = GridView3
                txtErrolog = txtErrorLog3

                If txtScript3.EditValue Is Nothing Then
                    Exit Sub
                End If

                strSQL = txtScript3.EditValue.ToString()
                strSQL = strSQL.Trim.ToUpper
            End If

            If strSQL.Contains("SELECT") = True Then

                Dim SQLcmd As New SqlCommand

                SQLcmd.CommandText = strSQL

                Dim dt As DataTable = mdlProcess.Load_SQLCmd(SQLcmd, SQLCOn, ErrorLog)

                If ErrorLog IsNot Nothing Then
                    txtErrolog.EditValue = ErrorLog.ErrorDateTime & vbCrLf & ErrorLog.ErrorMessage
                    tabControl.SelectedTabPageIndex = 1
                End If

                dgvView.Columns.Clear()
                dgv.DataSource = Nothing
                dgv.DataBindings.Clear()

                If dt IsNot Nothing Then
                    dgv.DataSource = dt
                    tabControl.SelectedTabPageIndex = 0
                End If

            Else

                Dim SQLcmd As New SqlCommand

                SQLcmd.CommandText = strSQL

                If mdlProcess.Run_SQLCmd(SQLcmd, SQLCOn, ErrorLog) = False Then
                    If ErrorLog IsNot Nothing Then
                        txtErrolog.EditValue = ErrorLog.ErrorDateTime & vbCrLf & ErrorLog.ErrorMessage
                    Else
                        txtErrolog.EditValue = "Failed to run script"
                    End If
                Else
                    txtErrolog.EditValue = "Succesfully run script"
                End If
                tabControl.SelectedTabPageIndex = 1
            End If



        Catch ex As Exception

        Finally
            pnlLoading.Visible = False

        End Try
    End Sub

    Private Sub TabbedView1_DocumentActivated(sender As Object, e As DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs) Handles TabbedView1.DocumentActivated
        doc = e.Document.ControlName
    End Sub

    Private Sub cboDatabase_EditValueChanged(sender As Object, e As EventArgs) Handles cboDatabase.EditValueChanged
        Try
            Dim ServerName As String
            Dim UserID As String
            Dim Password As String
            mdlProcess.DBSetting_GetSetting(ServerName, UserID, Password)

            Dim SQLCOn As New SqlConnection("Server=" & ServerName & ";Database=" & cboDatabase.EditValue.ToString & ";User Id=" & UserID & ";Password=" & Password & ";")

            If SQLCOn.State <> ConnectionState.Open Then
                SQLCOn.Open()
            End If

            Dim dt As DataTable = mdlProcess.GetListofTable(SQLCOn)

            If dt IsNot Nothing Then

                DtDatabaseColumnListBindingSource.DataSource = dt

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SELECTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SELECTToolStripMenuItem.Click
        Try
            Dim val As String = TreeList1.FocusedNode.GetValue("TABLE_NAME")
            Dim script As String = Nothing

            script = "SELECT * FROM " & val
            If doc = "docScript1" Then
                txtScript1.EditValue = script
            ElseIf doc = "docScript2" Then
                txtScript2.EditValue = script
            Else
                txtScript3.EditValue = script
            End If

            btnExecute.PerformClick()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UPDATEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATEToolStripMenuItem.Click
        Try
            Dim val As String = TreeList1.FocusedNode.GetValue("TABLE_NAME")
            Dim script As String = Nothing

            script = "UPDATE " & val & " SET Data=1 WHERE Data=1"
            If doc = "docScript1" Then
                txtScript1.EditValue = script
            ElseIf doc = "docScript2" Then
                txtScript2.EditValue = script
            Else
                txtScript3.EditValue = script
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
        Try
            Dim val As String = TreeList1.FocusedNode.GetValue("TABLE_NAME")
            Dim script As String = Nothing

            script = "DELETE FROM " & val & "WHERE DATA=1"
            If doc = "docScript1" Then
                txtScript1.EditValue = script
            ElseIf doc = "docScript2" Then
                txtScript2.EditValue = script
            Else
                txtScript3.EditValue = script
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRefresh1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh1.ItemClick
        Try
            LoadData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TreeList1_DoubleClick(sender As Object, e As EventArgs) Handles TreeList1.DoubleClick
        Try
            SELECTToolStripMenuItem.PerformClick()
        Catch ex As Exception

        End Try
    End Sub

End Class
