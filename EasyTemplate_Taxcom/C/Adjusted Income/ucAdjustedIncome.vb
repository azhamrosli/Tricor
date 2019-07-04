Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraReports.UI

Public Class ucAdjustedIncome
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


            Dim dt As DataTable = ADO.LoadAdjustedIncome_Search(cboRefNo.EditValue, cboYA.EditValue, ErrorLog)

            DsAdjustedIncome.Tables("TAX_COMPUTATION").Rows.Clear()

            If dt Is Nothing Then
                Exit Sub
            End If


            For i As Integer = 0 To dt.Rows.Count - 1
                DsAdjustedIncome.Tables("TAX_COMPUTATION").ImportRow(dt.Rows(i))
            Next

            dgvView.DataSource = DsAdjustedIncome.Tables("TAX_COMPUTATION")
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
    '    End If2
    'End Sub

    Private Sub btnAllRecord_Click(sender As Object, e As EventArgs) Handles btnAllRecord.Click
        Try
            cboRefNo.EditValue = ""
            cboYA.EditValue = ""
            LoadData(1)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            Dim frm As New frmAdjustedIncome_Add With {
                .isEdit = False
            }
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

    Private Sub btnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdit.ItemClick
        Try
            Dim Datax As System.Data.DataRow = GridView1.GetDataRow(GridView1.GetSelectedRows(0))

            Dim frm As New frmAdjustedIncome_Add With {
                .isEdit = True,
                .RefNo = Datax("TC_REF_NO"),
                .YA = Datax("TC_YA"),
                .SourceNo = Datax("TC_BUSINESS")
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

            Dim rslt As DialogResult = MessageBox.Show("Are you sure want to remove item(s)?", "Adjusted Income", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If rslt = Windows.Forms.DialogResult.Yes Then
                Dim tmpSts As Boolean = True
                For i As Integer = 0 To GridView1.SelectedRowsCount - 1

                    If ADO.Delete_AdjustedIncome(GridView1.GetDataRow(GridView1.GetSelectedRows(i))("TC_REF_NO"),
                                                 GridView1.GetDataRow(GridView1.GetSelectedRows(i))("TC_YA"),
                                                 CInt(GridView1.GetDataRow(GridView1.GetSelectedRows(i))("TC_BUSINESS")), ErrorLog) = False Then
                        tmpSts = False
                    End If
                Next

                If tmpSts Then
                    MsgBox("Succesfully remove adjusted income.", MsgBoxStyle.Information)
                    Me.LoadData(2)
                Else
                    MsgBox("Some of adjusted income to delete.", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub cboYA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYA.SelectedIndexChanged
        Try
            LoadData(2)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            cboRefNo.EditValue = ""
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub


    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        Try
            cboYA.EditValue = ""

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnImportExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            frmPNL_Import_Select.Show()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

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
            Dim RefNo As String = GridView1.GetFocusedDataRow()("TC_REF_NO")
            My.Computer.Clipboard.SetText(RefNo)
            MsgBox("Copy refence number " & RefNo)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub CopyYAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyYAToolStripMenuItem.Click
        Try
            Dim RefNo As String = GridView1.GetFocusedDataRow()("TC_YA")
            My.Computer.Clipboard.SetText(RefNo)
            MsgBox("Copy year assessment " & RefNo)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub cboRefNo_EditValueChanged_1(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            If cboRefNo IsNot Nothing AndAlso cboRefNo.EditValue IsNot Nothing AndAlso cboRefNo.EditValue <> "" Then
                txtRefNo.EditValue = cboRefNo.EditValue
                LoadData(2)
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
     
    End Sub
End Class
