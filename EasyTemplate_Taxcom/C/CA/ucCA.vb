﻿Imports DevExpress.XtraGrid.Views.Base

Public Class ucCA
    Dim ErrorLog As ClsError = Nothing
    Dim isChangeForm As Boolean = False
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        'If My.Settings.ThemeName <> "" Then
        '    DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = My.Settings.ThemeName
        'Else
        '    DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2013" ' "Office 2013"
        'End If
        InitializeComponent()
    End Sub

    Private Sub frmCA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cboFilterType.SelectedIndex = 0
            Application.DoEvents()

            If CreateLookUpTaxPayer(DsCA, ErrorLog) = False Then
                MsgBox("Unable to retrive tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If CreateLookUpYA(cboYA, ErrorLog, True) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Application.DoEvents()


            LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
        Finally
            If AutoBot_Allow = True AndAlso My.Computer.Name = DeveloperPCName AndAlso isOneClickOnly = False Then             
                btnPrint.PerformClick()
                isOneClickOnly = True
                Application.DoEvents()
            End If
        End Try
    End Sub
    Private Sub LoadData(Optional Type As Integer = 0)
        Try
            pnlLoading.Visible = True
            Application.DoEvents()

            Dim tmpType As Integer = -1

            If Type = 0 Then
                If mdlProcess.ArgParam2 <> "" Then
                    cboRefNo.EditValue = mdlProcess.ArgParam2
                End If

                If mdlProcess.ArgParam3 <> "" Then
                    cboYA.EditValue = mdlProcess.ArgParam3
                End If
            ElseIf Type = 1 Then
                cboRefNo.EditValue = ""
                cboYA.EditValue = ""
            End If


            If cboFilterType.SelectedIndex <> cboFilterType.Properties.Items.Count - 1 Then
                tmpType = cboFilterType.SelectedIndex
            End If
            'Dim dt As DataTable = mdlProcess.LoadCA_Search(txtRefNo.EditValue, txtYA.EditValue, tmpType, txtFilterValue.EditValue, ErrorLog)

            'DsCA.Tables("CA").Rows.Clear()

            'If dt Is Nothing Then
            '    Exit Sub
            'End If


            'For i As Integer = 0 To dt.Rows.Count - 1
            '    DsCA.Tables("CA").ImportRow(dt.Rows(i))
            'Next

            Dim dt As DataTable = ADO.LoadCA_Search(cboRefNo.EditValue, cboYA.EditValue, tmpType, txtFilterValue.EditValue, ErrorLog)

            DsCA.Tables("CA_DISPOSAL").Rows.Clear()
            DsCA.Tables("CA").Rows.Clear()


            If dt Is Nothing Then
                Exit Sub
            End If

            Dim dtDisposal As DataTable = Nothing
            For i As Integer = 0 To dt.Rows.Count - 1
                dtDisposal = ADO.Load_DISPOSAL_BY_CA_KEY(IIf(IsDBNull(dt.Rows(i)("CA_KEY")), 0, dt.Rows(i)("CA_KEY")))
                DsCA.Tables("CA").ImportRow(dt.Rows(i))
                If dtDisposal IsNot Nothing Then

                    For x As Integer = 0 To dtDisposal.Rows.Count - 1
                        DsCA.Tables("CA_DISPOSAL").ImportRow(dtDisposal.Rows(x))
                    Next
                End If
            Next
            CABindingSource.DataSource = DsCA
            ' dgvView.DataSource = DsCA.Tables("CA")
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        Finally
            pnlLoading.Visible = False
        End Try
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Try
            LoadData(2)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnAllRecord_Click(sender As Object, e As EventArgs) Handles btnAllRecord.Click
        Try
            cboFilterType.SelectedIndex = cboFilterType.Properties.Items.Count - 1
            cboRefNo.Text = ""
            cboYA.Text = ""
            txtFilterValue.Text = ""
            LoadData(1)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            Dim frm As New frmCA_Add3
            frm.ShowDialog()
            Me.LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub


    Private Sub dgvView_DoubleClick(sender As Object, e As EventArgs) Handles dgvView.DoubleClick
        Try
            btnEdit.PerformClick()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Try
            btnAdd.PerformClick()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Try
            btnEdit.PerformClick()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        Try
            btnDelete.PerformClick()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub CopyReferenceNoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyReferenceNoToolStripMenuItem.Click
        Try
            Dim ID As String = dgvCA.GetDataRow(dgvCA.GetSelectedRows(0))("CA_REF_NO")
            Clipboard.SetText(ID)
            MsgBox("Copy " & ID)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub CopyCompanyNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyCompanyNameToolStripMenuItem.Click
        Try
            Dim ID As String = dgvCA.GetDataRow(dgvCA.GetSelectedRows(0))("CA_NAME")
            Clipboard.SetText(ID)
            MsgBox("Copy " & ID)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdit.ItemClick
        Try
            Dim ID As Integer = dgvCA.GetDataRow(dgvCA.GetSelectedRows(0))("CA_KEY")

            Dim frm As New frmCA_Add3 With {
                .isEdit = True,
                .ID = ID
            }
            frm.ShowDialog()
            Me.LoadData(2)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            Dim rslt As DialogResult = MessageBox.Show("Are you sure want to remove item(s)?", "Capital Allowance", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If rslt = Windows.Forms.DialogResult.Yes Then
                Dim tmpSts As Boolean = True
                For i As Integer = 0 To dgvCA.SelectedRowsCount - 1

                    If ADO.Delete_CA(CInt(dgvCA.GetDataRow(dgvCA.GetSelectedRows(i))("CA_KEY")), ErrorLog) = False Then
                        tmpSts = False

                    End If
                    'MsgBox(dgvCA.GetDataRow(dgvCA.GetSelectedRows(i))("CA_KEY"))

                Next

                If tmpSts Then
                    MsgBox("Succesfully remove capital allowance.", MsgBoxStyle.Information)
                    Me.LoadData()
                Else
                    MsgBox("Some of capital allowance failed to delete.", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub DuplicateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuplicateToolStripMenuItem.Click
        Try


            Dim rslt As DialogResult = MessageBox.Show("Are you sure want to duplicate item(s)?", "Capital Allowance", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If rslt = Windows.Forms.DialogResult.Yes Then
                Dim ListofCA_KEY As New List(Of Integer)
                For i As Integer = 0 To dgvCA.SelectedRowsCount - 1
                    ListofCA_KEY.Add(CInt(dgvCA.GetDataRow(dgvCA.GetSelectedRows(i))("CA_KEY")))
                Next

                If ADO.Duplicate_CA(ListofCA_KEY, ErrorLog) Then
                    MsgBox("Successfully duplicate capital allowance.", MsgBoxStyle.Information)
                    Me.LoadData()
                Else
                    MsgBox("Failed to duplicate capital allowance." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)

                End If
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnImportExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImportExport.ItemClick

    End Sub

    Private Sub btnQuickCA_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuickCA.ItemClick
        Try
            frmCA_Quick.Show()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub CreateDisposalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateDisposalToolStripMenuItem.Click
        Try
            If dgvCA.IsMasterRowEmpty(dgvCA.FocusedRowHandle) = False Then
                MsgBox("This CA already disposed.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim rslt As DialogResult = MessageBox.Show("Are you sure want to dispose this item(s)?", "Capital Allowance", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If rslt = Windows.Forms.DialogResult.Yes Then

                Dim CA_KEY As Integer = CInt(dgvCA.GetDataRow(dgvCA.GetSelectedRows(0))("CA_KEY"))

                mdlProcess.ArgParam2 = dgvCA.GetDataRow(dgvCA.GetSelectedRows(0))("CA_REF_NO")
                mdlProcess.ArgParam3 = dgvCA.GetDataRow(dgvCA.GetSelectedRows(0))("CA_YA")
                Dim frm As New frmDisposal_Add With {
                    .isEdit = False,
                    .ID_CA = CA_KEY,
                    .isFromCA = True
                }
                frm.ShowDialog()
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub GridView1_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles dgvCA.CustomDrawCell
        Try
            If e.Column.FieldName = "CA_KEY" Then
                e.DefaultDraw()

                If dgvCA.IsMasterRowEmpty(e.RowHandle) = False Then
                    e.Graphics.DrawImage(DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/hide_16x16.png"), e.Bounds.Location)
                End If

            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
       
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            cboRefNo.EditValue = ""
            Me.LoadData(2)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            cboYA.EditValue = ""
            Me.LoadData(2)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            txtFilterValue.EditValue = ""
            Me.LoadData(2)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            txtRefNo.EditValue = cboRefNo.EditValue
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Try
            Dim frm As New frmCA_ReportMenu
            frm.ShowDialog()
            'Dim ID As String = Notrything
            'If mdlReport_CA.Report_CA(cboRefNo.EditValue, cboYA.EditValue, ID, ErrorLog) = False Then
            '    MsgBox("Failed to generate report", MsgBoxStyle.Critical)
            'Else
            '    Dim frm As New frmCA_ReportList
            '    frm.ID = ID
            '    frm.Show()
            'End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Try
            Dim frm As New frmCA_Quick
            frm.ShowDialog()

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
End Class
