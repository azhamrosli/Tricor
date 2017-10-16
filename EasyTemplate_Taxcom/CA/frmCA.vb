Public Class frmCA 
    Inherits DevExpress.XtraEditors.XtraForm
    Dim ErrorLog As clsError = Nothing
    Dim isChangeForm As Boolean = False
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Visual Studio 2013 Dark" ' "Office 2013" DevExpress Dark Style, DevExpress Dark Style,
        InitializeComponent()
    End Sub

    Private Sub frmCA_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If isChangeForm = False Then
                e.Cancel = True
                frmStartup.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
    
    Private Sub frmCA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cboFilterType.SelectedIndex = 0
            Application.DoEvents()


            LoadData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadData(Optional Type As Integer = 0)
        Try
            pnlLoading.Visible = True
            Application.DoEvents()

            Dim tmpType As Integer = -1

            If Type = 0 Then
                If mdlProcess.ArgParam2 <> "" Then
                    txtRefNo.EditValue = mdlProcess.ArgParam2
                End If

                If mdlProcess.ArgParam3 <> "" Then
                    txtYA.EditValue = mdlProcess.ArgParam3
                End If
            ElseIf Type = 1 Then
                txtRefNo.EditValue = ""
                txtYA.EditValue = ""
            End If


            If cboFilterType.SelectedIndex <> cboFilterType.Properties.Items.Count - 1 Then
                tmpType = cboFilterType.SelectedIndex
            End If
            Dim dt As DataTable = mdlProcess.LoadCA_Search(txtRefNo.EditValue, txtYA.EditValue, tmpType, txtFilterValue.EditValue, ErrorLog)

            DsCA.Tables("CA").Rows.Clear()

            If dt Is Nothing Then
                Exit Sub
            End If


            For i As Integer = 0 To dt.Rows.Count - 1
                DsCA.Tables("CA").ImportRow(dt.Rows(i))
            Next

            dgvView.DataSource = DsCA.Tables("CA")
        Catch ex As Exception

        Finally
            pnlLoading.Visible = False
        End Try
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Try
            LoadData(2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAllRecord_Click(sender As Object, e As EventArgs) Handles btnAllRecord.Click
        Try
            cboFilterType.SelectedIndex = cboFilterType.Properties.Items.Count - 1
            txtRefNo.Text = ""
            txtYA.Text = ""
            txtFilterValue.Text = ""
            LoadData(1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            Dim frm As New frmCA_Add3
            frm.ShowDialog()
            Me.LoadData()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub dgvView_DoubleClick(sender As Object, e As EventArgs) Handles dgvView.DoubleClick
        Try
            btnEdit.PerformClick()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Try
            btnAdd.PerformClick()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Try
            btnEdit.PerformClick()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        Try
            btnDelete.PerformClick()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CopyReferenceNoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyReferenceNoToolStripMenuItem.Click
        Try
            Dim ID As String = GridView1.GetDataRow(GridView1.GetSelectedRows(0))("CA_REF_NO")
            Clipboard.SetText(ID)
            MsgBox("Copy " & ID)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CopyCompanyNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyCompanyNameToolStripMenuItem.Click
        Try
            Dim ID As String = GridView1.GetDataRow(GridView1.GetSelectedRows(0))("CA_NAME")
            Clipboard.SetText(ID)
            MsgBox("Copy " & ID)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdit.ItemClick
        Try
            Dim ID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows(0))("CA_KEY")

            Dim frm As New frmCA_Add3
            frm.isEdit = True
            frm.ID = ID
            frm.ShowDialog()
            Me.LoadData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            Dim rslt As DialogResult = MessageBox.Show("Are you sure want to remove item(s)?", "Capital Allowance", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If rslt = Windows.Forms.DialogResult.Yes Then
                Dim tmpSts As Boolean = True
                For i As Integer = 0 To GridView1.SelectedRowsCount - 1

                    If mdlProcess.Delete_CA(CInt(GridView1.GetDataRow(GridView1.GetSelectedRows(i))("CA_KEY")), ErrorLog) = False Then
                        tmpSts = False

                    End If
                    'MsgBox(GridView1.GetDataRow(GridView1.GetSelectedRows(i))("CA_KEY"))

                Next

                If tmpSts Then
                    MsgBox("Succesfully remove capital allowance.", MsgBoxStyle.Information)
                    Me.LoadData()
                Else
                    MsgBox("Some of capital allowance failed to delete.", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DuplicateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuplicateToolStripMenuItem.Click
        Try


            Dim rslt As DialogResult = MessageBox.Show("Are you sure want to duplicate item(s)?", "Capital Allowance", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If rslt = Windows.Forms.DialogResult.Yes Then
                Dim ListofCA_KEY As New List(Of Integer)
                For i As Integer = 0 To GridView1.SelectedRowsCount - 1
                    ListofCA_KEY.Add(CInt(GridView1.GetDataRow(GridView1.GetSelectedRows(i))("CA_KEY")))
                Next

                If mdlProcess.Duplicate_CA(ListofCA_KEY, ErrorLog) Then
                    MsgBox("Successfully duplicate capital allowance.", MsgBoxStyle.Information)
                    Me.LoadData()
                Else
                    MsgBox("Failed to duplicate capital allowance." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class