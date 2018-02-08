Public Class ucDisposal
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
        InitializeComponent()
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

            Dim dt As DataTable = ADO.LoadCA_Search(cboRefNo.EditValue, cboYA.EditValue, tmpType, txtFilterValue.EditValue, ErrorLog)

            DsCA.Tables("CA_DISPOSAL").Rows.Clear()
            DsCA.Tables("CA").Rows.Clear()


            If dt Is Nothing Then
                Exit Sub
            End If

            Dim dtDisposal As DataTable = Nothing
            For i As Integer = 0 To dt.Rows.Count - 1
                dtDisposal = ADO.Load_DISPOSAL_BY_CA_KEY(IIf(IsDBNull(dt.Rows(i)("CA_KEY")), 0, dt.Rows(i)("CA_KEY")))

                If dtDisposal IsNot Nothing Then
                    DsCA.Tables("CA").ImportRow(dt.Rows(i))
                    For x As Integer = 0 To dtDisposal.Rows.Count - 1
                        DsCA.Tables("CA_DISPOSAL").ImportRow(dtDisposal.Rows(x))
                    Next
                End If
            Next

            CABindingSource.DataSource = DsCA
        Catch ex As Exception

        Finally
            pnlLoading.Visible = False
        End Try
    End Sub

    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            Dim frm As New frmDisposal_Add
            frm.ShowDialog()
            Me.LoadData()
        Catch ex As Exception

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

        End Try
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        LoadData(2)
    End Sub
    Private Sub dgvView_DoubleClick(sender As Object, e As EventArgs) Handles dgvView.DoubleClick
        Try
            btnEdit.PerformClick()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdit.ItemClick
        Try
            Dim ID_CA As Integer = dgvCA.GetDataRow(dgvCA.GetSelectedRows(0))("CA_KEY")
            Dim dtRow = DsCA.Tables("CA_DISPOSAL").Select("CA_KEY = " & ID_CA)

            If dtRow IsNot Nothing AndAlso dtRow.Count > 0 Then
                Dim ID As Integer = dtRow(0)("CA_DISP_KEY")
                Dim frm As New frmDisposal_Add
                frm.isEdit = True
                frm.ID = ID
                frm.ID_CA = ID_CA
                frm.ShowDialog()
                Me.LoadData()
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub ucDisposal_Load(sender As Object, e As EventArgs) Handles Me.Load
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

        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            cboRefNo.EditValue = ""
            Me.LoadData(2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            cboYA.EditValue = ""
            Me.LoadData(2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            txtFilterValue.EditValue = ""
            Me.LoadData(2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            txtRefNo.EditValue = cboRefNo.EditValue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Try
            Dim frm As New frmCA_ReportMenu
            frm.TypeReport = 8
            frm.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub
End Class
