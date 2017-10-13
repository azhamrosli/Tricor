Public Class frmPNL 

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
            Dim frm As New frmPNL_Details
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

            Dim frm As New frmPNL_Details
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

                    If mdlProcess.Delete_CA(CInt(GridView1.GetDataRow(GridView1.GetSelectedRows(i))("PL_KEY")), ErrorLog) = False Then
                        tmpSts = False

                    End If
                    'MsgBox(GridView1.GetDataRow(GridView1.GetSelectedRows(i))("CA_KEY"))

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

    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            If cboRefNo IsNot Nothing AndAlso cboRefNo.EditValue IsNot Nothing AndAlso cboRefNo.EditValue <> "" Then
                txtRefNo.EditValue = cboRefNo.EditValue
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class