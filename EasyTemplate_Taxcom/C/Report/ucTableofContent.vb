Imports DevExpress.XtraReports.ReportGeneration
Imports DevExpress.XtraReports.UI
Public Class ucTableofContent
    Dim ErrorLog As clsError = Nothing
    Sub New()
        If clsMoveNormal Is Nothing Then
            clsMoveNormal = New clsMovementNormal
        End If
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            Dim frm As New frmTableofContent_Add
            frm.ShowDialog()
            Me.LoadData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ucTableofContent_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If CreateLookUpTaxPayer(DsDefault, ErrorLog) = False Then
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


            Dim dt As DataTable = ADO.Load_TableofContent_Search(cboRefNo.EditValue, cboYA.EditValue, ErrorLog)

            DsReport_Templatexsd.Tables("TABLE_CONTENT").Rows.Clear()
            If dt IsNot Nothing Then

                For i As Integer = 0 To dt.Rows.Count - 1
                    DsReport_Templatexsd.Tables("TABLE_CONTENT").ImportRow(dt(i))
                Next

            End If
        Catch ex As Exception

        Finally
            pnlLoading.Visible = False
        End Try
    End Sub
    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            txtRefNo.EditValue = cboRefNo.EditValue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAllRecord_Click(sender As Object, e As EventArgs) Handles btnAllRecord.Click
        Try
            cboRefNo.Text = ""
            cboYA.Text = ""
            LoadData(1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Me.LoadData(2)
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

    Private Sub btnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdit.ItemClick
        Try
            Dim ID As Decimal = dgvCA.GetDataRow(dgvCA.GetSelectedRows(0))("TBL_ID")

            Dim frm As New frmTableofContent_Add
            frm.isEdit = True
            frm.ID = ID
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

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            Dim rslt As DialogResult = MessageBox.Show("Are you sure want to remove item(s)?", "Table of content", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If rslt = Windows.Forms.DialogResult.Yes Then
                Dim tmpSts As Boolean = True
                For i As Integer = 0 To dgvCA.SelectedRowsCount - 1

                    If ADO.Delete_TableofContent(CInt(dgvCA.GetDataRow(dgvCA.GetSelectedRows(i))("TBL_ID")), ErrorLog) = False Then
                        tmpSts = False

                    End If
                    'MsgBox(dgvCA.GetDataRow(dgvCA.GetSelectedRows(i))("CA_KEY"))

                Next

                If tmpSts Then
                    MsgBox("Succesfully remove table of content.", MsgBoxStyle.Information)
                    Me.LoadData()
                Else
                    MsgBox("Some of table of content failed to delete.", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Try

            Dim dt As DataTable = Nothing
            Dim dtChild As DataTable = Nothing
            Dim ID As Integer = 0
            Dim RefNo As String = Nothing
            Dim dsMovement As New dsMovement

            dt = clsMoveNormal.Load_MovementNormal_Search(cboRefNo.EditValue, cboYA.EditValue, ErrorLog)

            dsMovement.Tables("MOVEMENT_ADD").Rows.Clear()
            dsMovement.Tables("MOVEMENT_DEDUCT").Rows.Clear()
            dsMovement.Tables("MOVEMENT_NORMAL").Rows.Clear()

            If dt Is Nothing Then
                MsgBox("Data not found.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            For i As Integer = 0 To dt.Rows.Count - 1
                ID = IIf(IsDBNull(dt.Rows(i)("MM_ID")), 0, dt.Rows(i)("MM_ID"))
                RefNo = IIf(IsDBNull(dt.Rows(i)("MM_REFNO")), "", dt.Rows(i)("MM_REFNO"))
                dt.Rows(i)("MM_TITLE") = "Movements in " & IIf(IsDBNull(dt.Rows(i)("MM_TITLE")), "", dt.Rows(i)("MM_TITLE")) & " for the Year Ended " & IIf(IsDBNull(dt.Rows(i)("MM_YEAR_ENDED")), "", dt.Rows(i)("MM_YEAR_ENDED"))
                Application.DoEvents()
                dsMovement.Tables("MOVEMENT_NORMAL").ImportRow(dt.Rows(i))
            Next

            dt = clsMoveNormal.Load_MovementNormal_Add(ID, ErrorLog)

            If dt IsNot Nothing Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    dsMovement.Tables("MOVEMENT_ADD").ImportRow(dt.Rows(i))
                Next
            End If
            Application.DoEvents()
            dt = clsMoveNormal.Load_MovementNormal_Deduct(ID, ErrorLog)

            If dt IsNot Nothing Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    dsMovement.Tables("MOVEMENT_DEDUCT").ImportRow(dt.Rows(i))
                Next
            End If


            dt = ADO.Load_MovementComplex_Search(cboRefNo.EditValue, cboYA.EditValue, ErrorLog)

            dsMovement.Tables("MOVEMENT_COMPLEX_ADD").Rows.Clear()
            dsMovement.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows.Clear()
            dsMovement.Tables("MOVEMENT_COMPLEX").Rows.Clear()

            If dt Is Nothing Then
                MsgBox("Data not found.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            For i As Integer = 0 To dt.Rows.Count - 1
                ID = IIf(IsDBNull(dt.Rows(i)("MM_ID")), 0, dt.Rows(i)("MM_ID"))
                dt.Rows(i)("MM_TITLE") = "Movements in " & IIf(IsDBNull(dt.Rows(i)("MM_TITLE")), "", dt.Rows(i)("MM_TITLE")) & " for the Year Ended " & IIf(IsDBNull(dt.Rows(i)("MM_YEAR_ENDED")), "", dt.Rows(i)("MM_YEAR_ENDED"))
                Application.DoEvents()
                dsMovement.Tables("MOVEMENT_COMPLEX").ImportRow(dt.Rows(i))
            Next

            dt = ADO.Load_MovementComplex_Add(ID, ErrorLog)

            If dt IsNot Nothing Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    dsMovement.Tables("MOVEMENT_COMPLEX_ADD").ImportRow(dt.Rows(i))
                Next
            End If
            Application.DoEvents()
            dt = ADO.Load_MovementComplex_Deduct(ID, ErrorLog)

            If dt IsNot Nothing Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    dsMovement.Tables("MOVEMENT_COMPLEX_DEDUCT").ImportRow(dt.Rows(i))
                Next
            End If


            Dim CAID As String = ""
            Dim dsCA As New dsCA
            mdlReport_CA.Report_CA(cboRefNo.EditValue, cboYA.EditValue, CAID, -1, -1, "", ErrorLog)

            dt = ADO.Load_CAReport_Temp(CAID, CInt(cboYA.EditValue))

            dsCA.Tables("CA_REPORT_TEMP").Rows.Clear()

            For i As Integer = 0 To dt.Rows.Count - 1
                dsCA.Tables("CA_REPORT_TEMP").ImportRow(dt.Rows(i))
            Next


            Dim rpt1 As New rptMovementNormal
            rpt1.paramCompanyName.Value = cboRefNo.EditValue
            rpt1.DataSource = dsMovement.Tables("MOVEMENT_NORMAL")
            rpt1.CreateDocument()

            Dim rpt2 As New rptMovementComplex
            rpt2.paramCompanyName.Value = cboRefNo.EditValue
            rpt2.DataSource = dsMovement.Tables("MOVEMENT_COMPLEX")
            rpt2.CreateDocument()

            Dim rpt3 As New rpt_CAByCategory
            rpt3.paramCompanyName.Value = cboRefNo.EditValue
            rpt3.paramYA.Value = cboYA.EditValue
            rpt3.DataSource = dsCA.Tables("CA_REPORT_TEMP")
            rpt3.CreateDocument()

            Dim minPageCount As Integer = Math.Min(rpt1.Pages.Count, rpt2.Pages.Count)

            minPageCount = Math.Min(minPageCount, rpt3.Pages.Count)

            Dim x As Integer = 0
            Do While x < minPageCount
                rpt1.Pages.Insert(x * 2 + 1, rpt2.Pages(x))
                '  rpt1.Pages.Insert(x * 2 + 1, rpt3.Pages(x))
                x += 1
            Loop

            If rpt2.Pages.Count <> minPageCount Then
                x = minPageCount
                Do While x < rpt2.Pages.Count
                    rpt1.Pages.Add(rpt2.Pages(x))
                    x += 1
                Loop
            End If

            If rpt3.Pages.Count <> minPageCount Then
                x = minPageCount
                Do While x < rpt3.Pages.Count
                    rpt1.Pages.Add(rpt3.Pages(x))
                    x += 1
                Loop
            End If

            ' Reset all page numbers in the resulting document. 
            rpt1.PrintingSystem.ContinuousPageNumbering = True

            ' Show the Print Preview form (in a WinForms application). 
            Dim printTool As New ReportPrintTool(rpt1)
            printTool.ShowPreviewDialog()

            'Dim rptTableofContent As New rptTableofContent

            'rptTableofContent.paramCompanyName.Value = txtRefNo.EditValue

            'rptTableofContent.XrSubreport1.ReportSource.DataSource = dsMovement.Tables("MOVEMENT_NORMAL")
            'rptTableofContent.XrSubreport2.ReportSource.DataSource = dsMovement.Tables("MOVEMENT_COMPLEX")


            'rptTableofContent.showpreview()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Try

            Dim dtTaxCOM As DataTable = ADO.Load_Tax_Computation(cboRefNo.EditValue, cboYA.EditValue)

            Dim ds As New dsRA_ITA


            ds.Tables("CA").Rows.Clear()
            ds.Tables("TAX_RA_WITHDRAWAL").Rows.Clear()
            ds.Tables("TAX_RA_ADJUSTMENT").Rows.Clear()
            ds.Tables("TAX_COMPUTATION").Rows.Clear()
            If dtTaxCOM IsNot Nothing Then

                Dim TC_KEY As Integer = 0
                Dim TC_SOURCENO As Integer = 0
                Dim dtAdjustment As DataTable = Nothing
                Dim dtWithDrawal As DataTable = Nothing
                Dim dtCA As DataTable = Nothing
                For i As Integer = 0 To dtTaxCOM.Rows.Count - 1
                    TC_KEY = IIf(IsDBNull(dtTaxCOM.Rows(i)("TC_KEY")), 0, dtTaxCOM.Rows(i)("TC_KEY"))
                    TC_SOURCENO = IIf(IsDBNull(dtTaxCOM.Rows(i)("TC_BUSINESS")), 0, dtTaxCOM.Rows(i)("TC_BUSINESS"))
                    ds.Tables("TAX_COMPUTATION").ImportRow(dtTaxCOM.Rows(i))
                    Application.DoEvents()

                    dtCA = ADO.LoadCA_ByRefNoYASourceNo(cboRefNo.EditValue, cboYA.EditValue, TC_SOURCENO)
                    If dtCA IsNot Nothing Then
                        For Each rowx As DataRow In dtCA.Rows
                            ds.Tables("CA").ImportRow(rowx)
                        Next
                    End If

                    dtWithDrawal = ADO.Load_Taxcom_RA_Withdrawal(TC_KEY, ErrorLog)
                    If dtWithDrawal IsNot Nothing Then
                        For Each rowx As DataRow In dtWithDrawal.Rows
                            ds.Tables("TAX_RA_WITHDRAWAL").ImportRow(rowx)
                        Next
                    End If

                    dtAdjustment = ADO.Load_Taxcom_RA_Adjustment(TC_KEY, ErrorLog)
                    If dtAdjustment IsNot Nothing Then
                        For Each rowx As DataRow In dtAdjustment.Rows
                            ds.Tables("TAX_RA_ADJUSTMENT").ImportRow(rowx)
                        Next
                    End If


                Next

                Dim rpt As New rpt_RA
                rpt.DataSource = ds

                rpt.ShowPreview()
            End If


        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            AddListOfError(ErrorLog)

        End Try
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Try

            Dim dtTaxCOM As DataTable = ADO.Load_Tax_Computation(cboRefNo.EditValue, cboYA.EditValue)

            Dim ds As New dsRA_ITA


            ds.Tables("CA").Rows.Clear()
            ds.Tables("TAX_ITA_WITHDRAWAL").Rows.Clear()
            ds.Tables("TAX_ITA_ADJUSTMENT").Rows.Clear()
            ds.Tables("TAX_COMPUTATION").Rows.Clear()
            If dtTaxCOM IsNot Nothing Then

                Dim TC_KEY As Integer = 0
                Dim TC_SOURCENO As Integer = 0
                Dim dtAdjustment As DataTable = Nothing
                Dim dtWithDrawal As DataTable = Nothing
                Dim dtCA As DataTable = Nothing
                For i As Integer = 0 To dtTaxCOM.Rows.Count - 1
                    TC_KEY = IIf(IsDBNull(dtTaxCOM.Rows(i)("TC_KEY")), 0, dtTaxCOM.Rows(i)("TC_KEY"))
                    TC_SOURCENO = IIf(IsDBNull(dtTaxCOM.Rows(i)("TC_BUSINESS")), 0, dtTaxCOM.Rows(i)("TC_BUSINESS"))
                    ds.Tables("TAX_COMPUTATION").ImportRow(dtTaxCOM.Rows(i))
                    Application.DoEvents()

                    dtCA = ADO.LoadCA_ByRefNoYASourceNo(cboRefNo.EditValue, cboYA.EditValue, TC_SOURCENO)
                    If dtCA IsNot Nothing Then
                        For Each rowx As DataRow In dtCA.Rows
                            ds.Tables("CA").ImportRow(rowx)
                        Next
                    End If

                    dtWithDrawal = ADO.Load_Taxcom_RA_Withdrawal(TC_KEY, ErrorLog)
                    If dtWithDrawal IsNot Nothing Then
                        For Each rowx As DataRow In dtWithDrawal.Rows
                            ds.Tables("TAX_ITA_WITHDRAWAL").ImportRow(rowx)
                        Next
                    End If

                    dtAdjustment = ADO.Load_Taxcom_RA_Adjustment(TC_KEY, ErrorLog)
                    If dtAdjustment IsNot Nothing Then
                        For Each rowx As DataRow In dtAdjustment.Rows
                            ds.Tables("TAX_ITA_ADJUSTMENT").ImportRow(rowx)
                        Next
                    End If


                Next

                Dim rpt As New rpt_ITA
                rpt.DataSource = ds

                rpt.ShowPreview()
            End If


        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            AddListOfError(ErrorLog)

        End Try
    End Sub
End Class
