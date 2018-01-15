Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraReports.UI

Public Class ucPNL
    Dim ErrorLog As clsError = Nothing
    Dim isChangeForm As Boolean = False
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

        If dsDataSet Is Nothing Then
            dsDataSet = New dsPNL
        End If

        InitializeComponent()
    End Sub

    'Private Sub frmCA_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    '    Try
    '        If isChangeForm = False Then
    '            e.Cancel = True
    '            frmStartup.Close()
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub frmPNL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If mdlProcess.CreateLookUpTaxPayer(DsCA, ErrorLog) = False Then
                MsgBox("Unable to retrive tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If mdlProcess.CreateLookUpYA(cboYA, ErrorLog, True) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If

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
                    cboRefNo.EditValue = mdlProcess.ArgParam2
                End If

                If mdlProcess.ArgParam3 <> "" Then
                    cboYA.EditValue = mdlProcess.ArgParam3
                End If
            ElseIf Type = 1 Then
                cboRefNo.EditValue = ""
                cboYA.EditValue = ""
            End If


            Dim dt As DataTable = mdlProcess.LoadPNL_Search(cboRefNo.EditValue, cboYA.EditValue, ErrorLog)

            DsPNL.Tables("PROFIT_LOSS_ACCOUNT").Rows.Clear()

            If dt Is Nothing Then
                Exit Sub
            End If


            For i As Integer = 0 To dt.Rows.Count - 1
                DsPNL.Tables("PROFIT_LOSS_ACCOUNT").ImportRow(dt.Rows(i))
            Next

            dgvView.DataSource = DsPNL.Tables("PROFIT_LOSS_ACCOUNT")
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
    'Private Sub GridView1_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
    '    Dim View As GridView = sender
    '    If (e.RowHandle >= 0) Then
    '        Dim category As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("PNL_Status"))
    '        If category = "Ammen Require" Then
    '            e.Appearance.BackColor = Color.LightPink
    '            e.Appearance.BackColor2 = Color.Red
    '        ElseIf category = "Bookmarks" Then
    '            e.Appearance.BackColor = Color.LightYellow
    '            e.Appearance.BackColor2 = Color.Yellow
    '        ElseIf category = "Unfinished" Then
    '            e.Appearance.BackColor = Color.LightSkyBlue
    '            e.Appearance.BackColor2 = Color.Blue
    '        End If
    '    End If
    'End Sub

    Private Sub GridView1_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GridView1.CustomDrawCell
        If e.Column.FieldName = "PNL_Status" Then
            e.DefaultDraw()
            If Convert.ToString(e.CellValue) = "Ammen Require" Then
                e.Graphics.DrawImage(DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/editname_16x16.png"), e.Bounds.Location)
            ElseIf Convert.ToString(e.CellValue) = "Bookmarks" Then
                e.Graphics.DrawImage(DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/show_16x16.png"), e.Bounds.Location)
            ElseIf Convert.ToString(e.CellValue) = "Unfinished" Then
                e.Graphics.DrawImage(DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png"), e.Bounds.Location)
            End If
        End If
    End Sub
    Private Sub btnAllRecord_Click(sender As Object, e As EventArgs) Handles btnAllRecord.Click
        Try
            cboRefNo.EditValue = ""
            cboYA.EditValue = ""
            LoadData(1)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            Dim frm As New frmPNL_Add
            frm.isEdit = False
            frm.ID = 0
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

    Private Sub btnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdit.ItemClick
        Try
            Dim ID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows(0))("PL_KEY")

            Dim frm As New frmPNL_Add
            frm.isEdit = True
            frm.ID = ID
            frm.ShowDialog()
            Me.LoadData(2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try

            Dim rslt As DialogResult = MessageBox.Show("Are you sure want to remove item(s)?", "Profit and loss", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If rslt = Windows.Forms.DialogResult.Yes Then
                Dim tmpSts As Boolean = True
                For i As Integer = 0 To GridView1.SelectedRowsCount - 1

                    If mdlProcess.Check_AdjustedIncomeExist(GridView1.GetDataRow(GridView1.GetSelectedRows(i))("PL_REF_NO"), GridView1.GetDataRow(GridView1.GetSelectedRows(i))("PL_YA")) Then

                        MsgBox("This profit and loss already exist adjusted income. Information Reference (" & GridView1.GetDataRow(GridView1.GetSelectedRows(i))("PL_REF_NO") & ")", MsgBoxStyle.Exclamation)
                    Else
                        If mdlProcess.Delete_PNL(CInt(GridView1.GetDataRow(GridView1.GetSelectedRows(i))("PL_KEY")), ErrorLog) = False Then
                            tmpSts = False

                        End If
                    End If

                Next

                If tmpSts Then
                    MsgBox("Succesfully remove profit and loss.", MsgBoxStyle.Information)
                    Me.LoadData(2)
                Else
                    MsgBox("Some of profit and loss failed to delete.", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboYA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYA.SelectedIndexChanged
        Try
            LoadData(2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            cboRefNo.EditValue = ""
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        Try
            cboYA.EditValue = ""

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImportExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            frmPNL_Import_Select.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        btnAdd.PerformClick()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        btnEdit.PerformClick()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        btnDelete.PerformClick()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        btnPrint.PerformClick()
    End Sub

    Private Sub CopyReferenceNoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyReferenceNoToolStripMenuItem.Click
        Try
            Dim RefNo As String = GridView1.GetFocusedDataRow()("PL_REF_NO")
            My.Computer.Clipboard.SetText(RefNo)
            MsgBox("Copy refence number " & RefNo)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CopyYAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyYAToolStripMenuItem.Click
        Try
            Dim RefNo As String = GridView1.GetFocusedDataRow()("PL_YA")
            My.Computer.Clipboard.SetText(RefNo)
            MsgBox("Copy year assessment " & RefNo)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboRefNo_EditValueChanged_1(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            If cboRefNo IsNot Nothing AndAlso cboRefNo.EditValue IsNot Nothing AndAlso cboRefNo.EditValue <> "" Then
                txtRefNo.EditValue = cboRefNo.EditValue
                LoadData(2)
            End If
        Catch ex As Exception

        End Try
    End Sub
    
    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Try
            Dim RefNo As String = GridView1.GetFocusedDataRow()("PL_REF_NO")
            Dim YA As String = GridView1.GetFocusedDataRow()("PL_YA")

            If RefNo Is Nothing OrElse YA Is Nothing OrElse IsNumeric(YA) = False Then
                Exit Sub
            End If


            Dim rpt As New rptPNL

            rpt.paramCompanyName.Value = mdlProcess.LoadTaxPayer_CompanyName(RefNo)
            rpt.paramYA.Value = CInt(YA)



            If mdlPNL2.PNL_Report(RefNo, YA, rpt.DsPNL1, ErrorLog) Then
                'rpt.DataSource = dsDataSet
                '   rpt.DsPNL1 = dsDataSet

                rpt.ShowPreview()
            Else
                rpt = Nothing
                MsgBox("Failed to load report.", MsgBoxStyle.Critical)
            End If


        Catch ex As Exception

        End Try
    End Sub
End Class
