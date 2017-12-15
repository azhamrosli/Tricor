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

            If mdlProcess.CreateLookUpTaxPayer(dsCA, ErrorLog) = False Then
                MsgBox("Unable to retrive tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If mdlProcess.CreateLookUpYA(cboYA, ErrorLog, True) = False Then
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


            Dim dt As DataTable = mdlProcess.Load_MovementNormal_Search(cboRefNo.EditValue, cboYA.EditValue, ErrorLog)

            DsMovement.Tables("MOVEMENT_NORMAL").Rows.Clear()

            If dt Is Nothing Then
                Exit Sub
            End If

            For i As Integer = 0 To dt.Rows.Count - 1
                DsMovement.Tables("MOVEMENT_NORMAL").ImportRow(dt.Rows(i))
            Next


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

                    If mdlProcess.Delete_MovementNormal(CInt(GridView1.GetDataRow(GridView1.GetSelectedRows(i))("MM_ID")), ErrorLog) = False Then
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
            pnlLoading.Visible = True
            Application.DoEvents()

            Dim ds As DataSet = New dsReport_Templatexsd
            ds.Tables("dtReport").Rows.Clear()
            Dim rowxStart As Integer = 9
            Dim ID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows(0))("MM_ID")

            Dim dtParent As DataTable = mdlProcess.Load_MovementNormal(ID, ErrorLog)

            If dtParent Is Nothing Then
                MsgBox("No data found.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            mdlReport.CreateDataSetReport(ds, LoadTaxPayer_CompanyName(IIf(IsDBNull(dtParent.Rows(0)("MM_REFNO")), "", dtParent.Rows(0)("MM_REFNO"))) & "(" & IIf(IsDBNull(dtParent.Rows(0)("MM_REFNO")), "", dtParent.Rows(0)("MM_REFNO")) & ")", "", 0, 1, False, DevExpress.Spreadsheet.UnderlineType.None, False, "Pink", "Black", DevExpress.Spreadsheet.BorderLineStyle.None, DevExpress.Spreadsheet.BorderLineStyle.None, DevExpress.Spreadsheet.BorderLineStyle.None, DevExpress.Spreadsheet.BorderLineStyle.None, -1, 100, ErrorLog)

            mdlReport.CreateDataSetReport(ds, "Movement in Allowance for Vacation Pay for the Year Ended " & IIf(IsDBNull(dtParent.Rows(0)("MM_YEAR_ENDED")), "", dtParent.Rows(0)("MM_YEAR_ENDED")), 0, 2, ErrorLog)
            mdlReport.CreateDataSetReport(ds, "Add back / (Deduct)", 6, 3, ErrorLog)
            mdlReport.CreateDataSetReport(ds, "RM", 5, 5, ErrorLog)
            mdlReport.CreateDataSetReport(ds, "RM", 6, 5, ErrorLog)
            mdlReport.CreateDataSetReport(ds, "Balance as at " & Format(IIf(IsDBNull(dtParent.Rows(0)("MM_BALANCE_START")), Now, dtParent.Rows(0)("MM_BALANCE_START")), "dd-MM-yyyy"), 0, 6, ErrorLog)
            mdlReport.CreateDataSetReport(ds, CDec(IIf(IsDBNull(dtParent.Rows(0)("MM_AMOUNT_START")), 0, dtParent.Rows(0)("MM_AMOUNT_START"))).ToString("N0"), 5, 6, ErrorLog)
            mdlReport.CreateDataSetReport(ds, "YA " & IIf(IsDBNull(dtParent.Rows(0)("MM_YA")), "", dtParent.Rows(0)("MM_YA")), 7, 6, ErrorLog)
            mdlReport.CreateDataSetReport(ds, "Add :", 0, 8, ErrorLog)


            Dim dt As DataTable = mdlProcess.Load_MovementNormal_Add(ID)
            Dim tmpDec As Decimal = 0
            If dt IsNot Nothing Then


                For i As Integer = 0 To dt.Rows.Count - 1
                    rowxStart += 1
                    mdlReport.CreateDataSetReport(ds, IIf(IsDBNull(dt.Rows(i)("MM_Description")), "", dt.Rows(i)("MM_Description")), 0, rowxStart, ErrorLog)
                    mdlReport.CreateDataSetReport(ds, CDec(IIf(IsDBNull(dt.Rows(i)("MM_Amount")), 0, dt.Rows(i)("MM_Amount"))).ToString("N0"), 5, rowxStart, ErrorLog)
                    If IsDBNull(dt.Rows(i)("MM_AddBack")) = False AndAlso dt.Rows(i)("MM_AddBack") = True Then
                        tmpDec += IIf(IsDBNull(dt.Rows(i)("MM_Amount")), 0, dt.Rows(i)("MM_Amount"))
                        mdlReport.CreateDataSetReport(ds, CDec(IIf(IsDBNull(dt.Rows(i)("MM_Amount")), 0, dt.Rows(i)("MM_Amount"))).ToString("N0"), 6, rowxStart, ErrorLog)
                    End If

                Next
            End If
            rowxStart += 2
            mdlReport.CreateDataSetReport(ds, "Less :", 0, rowxStart, ErrorLog)
            rowxStart += 1
            dt = mdlProcess.Load_MovementNormal_Deduct(ID)

            If dt IsNot Nothing Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    rowxStart += 1
                    mdlReport.CreateDataSetReport(ds, IIf(IsDBNull(dt.Rows(i)("MM_Description")), "", dt.Rows(i)("MM_Description")), 0, rowxStart, ErrorLog)
                    mdlReport.CreateDataSetReport(ds, CDec(IIf(IsDBNull(dt.Rows(i)("MM_Amount")), 0, dt.Rows(i)("MM_Amount"))).ToString("N0"), 5, rowxStart, ErrorLog)
                    If IsDBNull(dt.Rows(i)("MM_Deduct")) = False AndAlso dt.Rows(i)("MM_Deduct") = True Then
                        tmpDec -= IIf(IsDBNull(dt.Rows(i)("MM_Amount")), 0, dt.Rows(i)("MM_Amount"))
                        mdlReport.CreateDataSetReport(ds, CDec(IIf(IsDBNull(dt.Rows(i)("MM_Amount")), 0, dt.Rows(i)("MM_Amount"))).ToString("N0"), 6, rowxStart, ErrorLog)
                    End If

                Next
            End If

            rowxStart += 2

            mdlReport.CreateDataSetReport(ds, "Balance as at " & Format(IIf(IsDBNull(dtParent.Rows(0)("MM_BALANCE_END")), Now, dtParent.Rows(0)("MM_BALANCE_END")), "dd-MM-yyyy"), 0, rowxStart, ErrorLog)

            mdlReport.CreateDataSetReport(ds, CDec(IIf(IsDBNull(dtParent.Rows(0)("MM_AMOUNT_END")), 0, dtParent.Rows(0)("MM_AMOUNT_END"))).ToString("N0"), "", 5, rowxStart, False, DevExpress.Spreadsheet.UnderlineType.None, False, "", "", DevExpress.Spreadsheet.BorderLineStyle.None, DevExpress.Spreadsheet.BorderLineStyle.Thin, DevExpress.Spreadsheet.BorderLineStyle.None, DevExpress.Spreadsheet.BorderLineStyle.Double, -1, -1, ErrorLog)

            mdlReport.CreateDataSetReport(ds, CDec(tmpDec).ToString("N0"), "", 6, rowxStart, False, DevExpress.Spreadsheet.UnderlineType.None, False, "", "", DevExpress.Spreadsheet.BorderLineStyle.None, DevExpress.Spreadsheet.BorderLineStyle.Thin, DevExpress.Spreadsheet.BorderLineStyle.None, DevExpress.Spreadsheet.BorderLineStyle.Double, -1, -1, ErrorLog)

        Catch ex As Exception

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
