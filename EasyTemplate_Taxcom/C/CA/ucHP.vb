Public Class ucHP
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

    Private Sub frmHP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim dt As DataTable = ADO.LoadHP_Search(cboRefNo.EditValue, cboYA.EditValue, tmpType, txtFilterValue.EditValue, ErrorLog)

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

                dtHP_Install = ADO.Load_HP_INSTALLMENT(dt.Rows(i)("HP_KEY"))

                If dtHP_Install IsNot Nothing Then
                    For x As Integer = 0 To dtHP_Install.Rows.Count - 1
                        DsCA.Tables("HP_INSTALLMENT").ImportRow(dtHP_Install.Rows(x))
                    Next
                End If


                dtHP_Year = ADO.Load_HP_YEARLY(dt.Rows(i)("HP_KEY"))
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

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            Dim frm As New frmHP_Add
            frm.ShowDialog()
            Me.LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdit.ItemClick
        Try
            Dim ID As Integer = GridView2.GetDataRow(GridView2.GetSelectedRows(0))("HP_KEY")

            Dim frm As New frmHP_Add With {
                .isEdit = True,
                .ID = ID
            }
            frm.ShowDialog()
            Me.LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub GridView2_DoubleClick(sender As Object, e As EventArgs) Handles GridView2.DoubleClick
        Try
            btnEdit.PerformClick()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            Dim rslt As DialogResult = MessageBox.Show("Are you sure want to remove item(s)?", "Hire Purchase", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If rslt = Windows.Forms.DialogResult.Yes Then
                Dim tmpSts As Boolean = True
                For i As Integer = 0 To GridView2.SelectedRowsCount - 1

                    If ADO.Delete_HP(CInt(GridView2.GetDataRow(GridView2.GetSelectedRows(i))("HP_KEY")), ErrorLog) = False Then
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
            Dim frm As New frmCA_ReportMenu With {
                .TypeReport = 11
            }
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
End Class
