Imports DevExpress.XtraReports.ReportGeneration
Imports DevExpress.XtraReports.UI
Public Class ucMovement
    Dim ErrorLog As clsError = Nothing
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

        If clsMoveNormal Is Nothing Then
            clsMoveNormal = New clsMovementNormal
        End If
        InitializeComponent()
    End Sub
    Private Sub frmMovement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.LoadData(0)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadData(Optional Type As Integer = 0)
        Try
            pnlLoading.Visible = True
            Application.DoEvents()

            Dim tmpType As Integer = -1

            If CreateLookUpTaxPayer(DsCA, ErrorLog) = False Then
                MsgBox("Unable to retrive tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If CreateLookUpYA(cboYA, ErrorLog, True) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Application.DoEvents()

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

            clsMoveNormal.SearchListData(cboRefNo.EditValue, cboYA.EditValue, DsMovement, ErrorLog)

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
    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            Dim frm As New frmMovement_Add
            frm.isEdit = False
            frm.ID = 0
            frm.ShowDialog()

            Me.LoadData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs)
        Try
            If cboRefNo IsNot Nothing AndAlso cboRefNo.EditValue IsNot Nothing AndAlso cboRefNo.EditValue <> "" Then
                txtRefNo.EditValue = cboRefNo.EditValue
                LoadData(2)
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
            Me.LoadData(2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        Try
            cboYA.EditValue = ""
            Me.LoadData(2)
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

    Private Sub btnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdit.ItemClick
        Try
            Dim ID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows(0))("MM_ID")

            Dim frm As New frmMovement_Add
            frm.isEdit = True
            frm.ID = ID
            frm.ShowDialog()
            Me.LoadData(2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            Dim rslt As DialogResult = MessageBox.Show("Are you sure want to remove item(s)?", "Movement Normal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If rslt = Windows.Forms.DialogResult.Yes Then
                Dim tmpSts As Boolean = True
                For i As Integer = 0 To GridView1.SelectedRowsCount - 1

                    If clsMoveNormal.Delete_MovementNormal(CInt(GridView1.GetDataRow(GridView1.GetSelectedRows(i))("MM_ID")), ErrorLog) = False Then
                        tmpSts = False

                    End If
                    'MsgBox(GridView1.GetDataRow(GridView1.GetSelectedRows(i))("CA_KEY"))
                Next
                If tmpSts Then
                    MsgBox("Succesfully remove movement normal.", MsgBoxStyle.Information)
                    Me.LoadData(2)
                Else
                    MsgBox("Some of movement normal failed to delete.", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Try
            btnEdit.PerformClick()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Try

            Dim dt As DataTable = Nothing
            Dim dtChild As DataTable = Nothing
            Dim ID As Integer = GridView1.GetDataRow(GridView1.FocusedRowHandle)("MM_ID")

            dt = clsMoveNormal.Load_MovementNormal(ID, ErrorLog)

            DsMovement.Tables("MOVEMENT_ADD").Rows.Clear()
            DsMovement.Tables("MOVEMENT_DEDUCT").Rows.Clear()
            DsMovement.Tables("MOVEMENT_NORMAL").Rows.Clear()

            If dt Is Nothing Then
                MsgBox("Data not found.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("MM_TITLE") = "Movements in " & IIf(IsDBNull(dt.Rows(i)("MM_TITLE")), "", dt.Rows(i)("MM_TITLE")) & " for the Year Ended " & Format(IIf(IsDBNull(dt.Rows(i)("MM_YEAR_ENDED")), Now, dt.Rows(i)("MM_YEAR_ENDED")), "dd.MM.yyyy")
                Application.DoEvents()
                DsMovement.Tables("MOVEMENT_NORMAL").ImportRow(dt.Rows(i))
            Next

            dt = clsMoveNormal.Load_MovementNormal_Add(ID, ErrorLog)

            If dt IsNot Nothing Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    DsMovement.Tables("MOVEMENT_ADD").ImportRow(dt.Rows(i))
                Next
            End If
            Application.DoEvents()
            dt = clsMoveNormal.Load_MovementNormal_Deduct(ID, ErrorLog)

            If dt IsNot Nothing Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    DsMovement.Tables("MOVEMENT_DEDUCT").ImportRow(dt.Rows(i))
                Next
            End If

            Dim rpt As New rptMovementNormal
            rpt.paramCompanyName.Value = ADO.LoadTaxPayer_CompanyName(GridView1.GetDataRow(GridView1.FocusedRowHandle)("MM_REFNO"))
            rpt.DataSource = DsMovement.Tables("MOVEMENT_NORMAL")

            rpt.ShowPreview()


        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

            AddListOfError(ErrorLog)
        Finally
            pnlLoading.Visible = False
            Application.DoEvents()
        End Try

    End Sub

    Private Sub btnImportExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImportExport.ItemClick

    End Sub

    Private Sub cboRefNo_EditValueChanged_1(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            txtRefNo.EditValue = cboRefNo.EditValue
        Catch ex As Exception

        End Try
    End Sub
End Class
