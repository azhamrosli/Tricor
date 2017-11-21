Public Class ucHP
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

    Private Sub frmHP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim dt As DataTable = mdlProcess.LoadHP_Search(txtRefNo.EditValue, txtYA.EditValue, tmpType, txtFilterValue.EditValue, ErrorLog)

            DsCA.Tables("HP").Rows.Clear()
            DsCA.Tables("HP_INSTALLMENT").Clear()
            DsCA.Tables("HP_YEARLY").Clear()

            If dt Is Nothing Then
                Exit Sub
            End If
            Dim dtHP_Install As DataTable = Nothing
            Dim dtHP_Year As DataTable = Nothing
            Dim dtRow As DataRow
            For i As Integer = 0 To dt.Rows.Count - 1
                DsCA.Tables("HP").ImportRow(dt.Rows(i))

                dtHP_Install = mdlProcess.Load_HP_INSTALLMENT(dt.Rows(i)("HP_KEY"))

                If dtHP_Install IsNot Nothing Then
                    For x As Integer = 0 To dtHP_Install.Rows.Count - 1
                        DsCA.Tables("HP_INSTALLMENT").ImportRow(dtHP_Install.Rows(x))
                    Next
                End If


                dtHP_Year = mdlProcess.Load_HP_YEARLY(dt.Rows(i)("HP_KEY"))
                If dtHP_Year IsNot Nothing Then
                    For x As Integer = 0 To dtHP_Year.Rows.Count - 1
                        DsCA.Tables("HP_YEARLY").ImportRow(dtHP_Year.Rows(x))
                    Next
                Else
                    'dtRow = DsCA.Tables("HP_YEARLY").NewRow
                    'dtRow("HP_KEY") = DsCA.Tables("HP_YEARLY").Rows.Count + 1
                    'dtRow("HPD_KEY") = dt.Rows(i)("HP_KEY")
                    'dtRow("HPD_YA") = DBNull.Value
                    'dtRow("HPD_PRINCIPAL") = DBNull.Value
                    'dtRow("HPD_INTEREST") = DBNull.Value
                    'dtRow("HPD_TOTAL") = DBNull.Value
                    'dtRow("HPD_NOTE_TITLE1") = DBNull.Value
                    'dtRow("HPD_NOTE_TITLE2") = DBNull.Value
                    'DsCA.Tables("HP_YEARLY").Rows.Add(dtRow)
                End If

            Next

            HPBindingSource.DataSource = DsCA


        Catch ex As Exception

        Finally
            pnlLoading.Visible = False
        End Try
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs)
        Try
            LoadData(2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAllRecord_Click(sender As Object, e As EventArgs)
        Try
            cboFilterType.SelectedIndex = cboFilterType.Properties.Items.Count - 1
            txtRefNo.Text = ""
            txtYA.Text = ""
            txtFilterValue.Text = ""
            LoadData(1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim frm As New frmHP_Add
            frm.ShowDialog()
            Me.LoadData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim ID As Integer = GridView2.GetDataRow(GridView2.GetSelectedRows(0))("HP_KEY")

            Dim frm As New frmHP_Add
            frm.isEdit = True
            frm.ID = ID
            frm.ShowDialog()
            Me.LoadData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView2_DoubleClick(sender As Object, e As EventArgs)
        Try
            btnEdit.PerformClick()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim rslt As DialogResult = MessageBox.Show("Are you sure want to remove item(s)?", "Hire Purchase", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If rslt = Windows.Forms.DialogResult.Yes Then
                Dim tmpSts As Boolean = True
                For i As Integer = 0 To GridView2.SelectedRowsCount - 1

                    If mdlProcess.Delete_HP(CInt(GridView2.GetDataRow(GridView2.GetSelectedRows(i))("HP_KEY")), ErrorLog) = False Then
                        tmpSts = False
                    End If
                    'MsgBox(GridView1.GetDataRow(GridView1.GetSelectedRows(i))("CA_KEY"))

                Next

                If tmpSts Then
                    MsgBox("Succesfully remove hire purchase.", MsgBoxStyle.Information)
                    Me.LoadData()
                Else
                    MsgBox("Some of hire purchase failed to delete.", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
