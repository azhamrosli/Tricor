Public Class ucDisposal
    Dim ErrorLog As clsError = Nothing
    Dim isChangeForm As Boolean = False
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Visual Studio 2013 Dark" ' "Office 2013" DevExpress Dark Style,
        InitializeComponent()
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

            Dim dt As DataTable = mdlProcess.LoadCA_Search(txtRefNo.EditValue, txtYA.EditValue, tmpType, txtFilterValue.EditValue, ErrorLog)

            DsCA.Tables("CA_DISPOSAL").Rows.Clear()
            DsCA.Tables("CA").Rows.Clear()


            If dt Is Nothing Then
                Exit Sub
            End If

            Dim dtDisposal As DataTable = Nothing
            For i As Integer = 0 To dt.Rows.Count - 1
                dtDisposal = mdlProcess.Load_DISPOSAL_BY_CA_KEY(IIf(IsDBNull(dt.Rows(i)("CA_KEY")), 0, dt.Rows(i)("CA_KEY")))

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

    Private Sub frmDisposal_Load(sender As Object, e As EventArgs)
        LoadData()
    End Sub

    Private Sub btnAllRecord_Click(sender As Object, e As EventArgs) Handles btnAllRecord.Click

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

    End Sub
End Class
