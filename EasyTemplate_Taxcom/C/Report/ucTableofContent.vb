Imports DevExpress.XtraReports.ReportGeneration
Imports DevExpress.XtraReports.UI
Public Class ucTableofContent
    Dim ADO As clsIODatabase
    Dim ErrorLog As clsError = Nothing
    Sub New()       
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If clsMoveNormal Is Nothing Then
            clsMoveNormal = New clsMovementNormal
        End If

        If ADO Is Nothing Then
            ADO = New clsIODatabase
        End If
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
            Dim ID As Decimal = dgvDetails.GetDataRow(dgvDetails.GetSelectedRows(0))("TBL_ID")

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
                For i As Integer = 0 To dgvDetails.SelectedRowsCount - 1

                    If ADO.Delete_TableofContent(CInt(dgvDetails.GetDataRow(dgvDetails.GetSelectedRows(i))("TBL_ID")), ErrorLog) = False Then
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
            pnlLoading.Visible = True
            Application.DoEvents()
            PrintTableOfContent()
        Catch ex As Exception

        Finally
            pnlLoading.Visible = False
        End Try
    End Sub
    Private Sub PrintTableOfContent()
        Try
            Dim dtRowTOC As DataRow = Nothing


            If DsReport_Templatexsd.Tables("TABLE_CONTENT").Rows.Count = 1 Then
                dtRowTOC = DsReport_Templatexsd.Tables("TABLE_CONTENT").Rows(0)
            Else
                dtRowTOC = DsReport_Templatexsd.Tables("TABLE_CONTENT").Rows(dgvDetails.FocusedRowHandle)
            End If

            If dtRowTOC Is Nothing Then
                Exit Sub
            End If

            Dim dtTOC_List As DataTable = ADO.Load_TableofContent_List_ByParentID(IIf(IsDBNull(dtRowTOC("TBL_ID")), 0, dtRowTOC("TBL_ID")), ErrorLog)

            If dtTOC_List Is Nothing Then
                Exit Sub
            End If


            Dim Title As String = Nothing
            Dim Report_Index As String = Nothing
            Dim ReportName As String = Nothing
            Dim RefNo As String = Nothing
            Dim YA As String = Nothing
            Dim SchApx As String = "Schedule"

            RefNo = IIf(IsDBNull(dtRowTOC("TBL_REFNO")), "", dtRowTOC("TBL_REFNO"))
            YA = IIf(IsDBNull(dtRowTOC("TBL_YA")), "", dtRowTOC("TBL_YA"))

            If IsNumeric(YA) = False Then
                Exit Sub
            End If

            Dim ListofRpt As New List(Of DevExpress.XtraReports.UI.XtraReport)

            Dim dtTMP As DataTable = Nothing
            Dim dsMovement As dsMovement = Nothing
            Dim dsCA As dsCA = Nothing
            Dim dsCP204 As dsCP204 = Nothing
            Dim Status As Boolean = False
            Dim ID_CA_TMP As String = ""
            Dim ComName As String = ""

            If ADO Is Nothing Then
                ADO = New clsIODatabase
            End If

            ComName = ADO.LoadTaxPayer_CompanyName(RefNo)

            Dim dsTOC As New dsReport_Templatexsd


            For Each rowx As DataRow In dtTOC_List.Rows

                Title = IIf(IsDBNull(rowx("TBL_TITLE")), "", rowx("TBL_TITLE"))
                Report_Index = IIf(IsDBNull(rowx("TBL_INDEX")), "", rowx("TBL_INDEX"))
                ReportName = IIf(IsDBNull(rowx("TBL_REPORTNAME")), "", rowx("TBL_REPORTNAME"))

                If IsDBNull(rowx("TBL_SCH")) = False AndAlso rowx("TBL_SCH") <> "" Then
                    SchApx = rowx("TBL_SCH") & " " & Report_Index
                Else
                    SchApx = ""
                End If


                Select Case ReportName
                    Case "rptProfitAndLoss"
                        Dim rpt As rptPNL
                        Dim rpt_details As rptPNL_Details
                        Dim rpt_interest As rptPNL_InterestResict

                        If mdlProcess.PrintReport_PNL(RefNo, YA, rpt, rpt_details, rpt_interest, ErrorLog, SchApx) Then
                            Dim minPageCount As Integer = Math.Min(rpt.Pages.Count, rpt_interest.Pages.Count)

                            Dim x As Integer = 0

                            For Each pg As DevExpress.XtraPrinting.Page In rpt_interest.Pages
                                rpt.Pages.Add(pg)
                            Next
                            dsTOC.Tables("TABLE_CONTENT_LIST").ImportRow(rowx)
                            ListofRpt.Add(rpt)
                        End If
                    Case "rptMovementNormal"

                        If dsMovement Is Nothing Then
                            dsMovement = New dsMovement
                        End If
                        If clsMoveNormal Is Nothing Then
                            clsMoveNormal = New clsMovementNormal
                        End If

                        dtTMP = clsMoveNormal.Load_MovementNormal(RefNo, YA, ErrorLog)

                        If dtTMP IsNot Nothing Then
                            Dim rpt As rptMovementNormal = Nothing
                            For Each dtTmp_Row As DataRow In dtTMP.Rows

                                rpt = Nothing
                                If mdlProcess.PrintReport_MovementNormal(dsMovement, _
                                                                         IIf(IsDBNull(dtTmp_Row("MM_ID")), 0, dtTmp_Row("MM_ID")), _
                                                                         RefNo, rpt, ErrorLog, SchApx) Then
                                    ListofRpt.Add(rpt)
                                End If

                            Next
                            dsTOC.Tables("TABLE_CONTENT_LIST").ImportRow(rowx)
                        End If

                    Case "rptMovementComplex"

                        If dsMovement Is Nothing Then
                            dsMovement = New dsMovement
                        End If
                        dtTMP = ADO.Load_MovementComplex(RefNo, YA, ErrorLog)

                        If dtTMP IsNot Nothing Then
                            Dim rpt As rptMovementComplex = Nothing
                            For Each dtTmp_Row As DataRow In dtTMP.Rows

                                rpt = Nothing
                                If mdlProcess.PrintReport_MovementComplex(dsMovement, IIf(IsDBNull(dtTmp_Row("MM_ID")), 0, dtTmp_Row("MM_ID")), _
                                                                          RefNo, rpt, ErrorLog, SchApx) Then
                                    ListofRpt.Add(rpt)
                                End If

                            Next
                            dsTOC.Tables("TABLE_CONTENT_LIST").ImportRow(rowx)
                        End If
                    Case "rpt_HP"

                        Status = mdlReport_CA.Report_HP(RefNo, YA, ID_CA_TMP, 0, 100, "", ErrorLog)

                        If Status Then
                            dtTMP = ADO.Load_HPReport_Temp(ID_CA_TMP, CInt(YA))

                            If dsCA Is Nothing Then
                                dsCA = New dsCA
                            End If
                            If dtTMP IsNot Nothing Then
                                dsCA.Tables("HP_REPORT_TEMP").Rows.Clear()

                                For i As Integer = 0 To dtTMP.Rows.Count - 1
                                    dsCA.Tables("HP_REPORT_TEMP").ImportRow(dtTMP.Rows(i))
                                Next
                            End If

                            Dim rpt As rpt_HP

                            If mdlProcess.PrintReport_HP(dsCA, ComName, YA, rpt, ErrorLog, SchApx) Then
                                ListofRpt.Add(rpt)
                                dsTOC.Tables("TABLE_CONTENT_LIST").ImportRow(rowx)
                            End If
                        End If

                    Case "rpt_Disposal", "rpt_CAWrittenOff"

                        If ReportName = "" Then
                            Status = mdlReport_CA.Report_DISPOSAL(RefNo, YA, ID_CA_TMP, 0, 100, "", 0, ErrorLog)
                        ElseIf ReportName = "" Then
                            Status = mdlReport_CA.Report_DISPOSAL(RefNo, YA, ID_CA_TMP, 0, 100, "", 1, ErrorLog)
                        ElseIf ReportName = "" Then
                            Status = mdlReport_CA.Report_DISPOSAL(RefNo, YA, ID_CA_TMP, 0, 100, "", 2, ErrorLog)
                        End If

                        If Status Then
                            dtTMP = ADO.Load_CAReport_Disposal(ID_CA_TMP)

                            If dsCA Is Nothing Then
                                dsCA = New dsCA
                            End If
                            If dtTMP IsNot Nothing Then

                                dsCA.Tables("CA_REPORT_DISPOSAL_TEMP").Rows.Clear()

                                For i As Integer = 0 To dtTMP.Rows.Count - 1
                                    dsCA.Tables("CA_REPORT_DISPOSAL_TEMP").ImportRow(dtTMP.Rows(i))
                                Next

                                If ReportName = "" Then
                                    Dim rpt As rpt_Disposal

                                    If mdlProcess.PrintReport_Disposal(dsCA, ComName, YA, rpt, ErrorLog, SchApx) Then
                                        ListofRpt.Add(rpt)
                                        dsTOC.Tables("TABLE_CONTENT_LIST").ImportRow(rowx)
                                    End If
                                ElseIf ReportName = "" Then
                                    Dim rpt As rpt_CAWrittenOff

                                    If mdlProcess.PrintReport_WrittenOff(dsCA, ComName, YA, rpt, ErrorLog, SchApx) Then
                                        ListofRpt.Add(rpt)
                                        dsTOC.Tables("TABLE_CONTENT_LIST").ImportRow(rowx)
                                    End If
                                ElseIf ReportName = "" Then
                                    Dim rpt As rpt_CAControlTransfer_Out

                                    If mdlProcess.PrintReport_ControlTransferOut(dsCA, ComName, YA, rpt, ErrorLog, SchApx) Then
                                        ListofRpt.Add(rpt)
                                        dsTOC.Tables("TABLE_CONTENT_LIST").ImportRow(rowx)
                                    End If
                                End If
                                
                            End If
                        End If

                    Case "rpt_CAByRate", "rpt_CAByCategory", "rpt_CAByAsset"

                        Status = mdlReport_CA.Report_CA(cboRefNo.EditValue, cboYA.EditValue, ID_CA_TMP, 0, 100, "", ErrorLog)

                        If Status Then
                            dtTMP = ADO.Load_CAReport_Temp(ID_CA_TMP, CInt(YA))

                            If dsCA Is Nothing Then
                                dsCA = New dsCA
                            End If
                            If dtTMP IsNot Nothing Then

                                dsCA.Tables("CA_REPORT_TEMP").Rows.Clear()

                                For i As Integer = 0 To dtTMP.Rows.Count - 1
                                    dsCA.Tables("CA_REPORT_TEMP").ImportRow(dtTMP.Rows(i))
                                Next

                                If ReportName = "rpt_CAByCategory" Then
                                    Dim rpt As rpt_CAByCategory

                                    If mdlProcess.PrintReport_CAByCategory(dsCA, ComName, YA, rpt, ErrorLog, SchApx) Then
                                        ListofRpt.Add(rpt)
                                        dsTOC.Tables("TABLE_CONTENT_LIST").ImportRow(rowx)
                                    End If
                                ElseIf ReportName = "rpt_CAByRate" Then
                                    Dim rpt As rpt_CAByRate

                                    If mdlProcess.PrintReport_CAByRate(dsCA, ComName, YA, rpt, ErrorLog, SchApx) Then
                                        ListofRpt.Add(rpt)
                                        dsTOC.Tables("TABLE_CONTENT_LIST").ImportRow(rowx)
                                    End If
                                ElseIf ReportName = "rpt_CAByAsset" Then
                                    Dim rpt As rptCAReport

                                    If mdlProcess.PrintReport_CAByAsset(dsCA, ComName, YA, rpt, ErrorLog) Then
                                        ListofRpt.Add(rpt)
                                        dsTOC.Tables("TABLE_CONTENT_LIST").ImportRow(rowx)
                                    End If
                                End If
                            End If
                        End If
                        
                    Case "rpt_CAByCategory_Summary", "rpt_CAByRate_Summary", "rpt_CAByAsset_Summary"

                        Status = mdlReport_CA.Report_CA(cboRefNo.EditValue, cboYA.EditValue, ID_CA_TMP, 0, 100, "", ErrorLog)

                        If Status Then
                            dtTMP = ADO.Load_CAReportSummary2_Temp(ID_CA_TMP)

                            If dsCA Is Nothing Then
                                dsCA = New dsCA
                            End If
                            If dtTMP IsNot Nothing Then

                                dsCA.Tables("CA_REPORT_TEMP").Rows.Clear()

                                For i As Integer = 0 To dtTMP.Rows.Count - 1
                                    dsCA.Tables("CA_REPORT_TEMP").ImportRow(dtTMP.Rows(i))
                                Next

                                If ReportName = "rpt_CAByCategory" Then
                                    Dim rpt As rpt_CAByCategory

                                    If mdlProcess.PrintReport_CAByCategory(dsCA, ComName, YA, rpt, ErrorLog, SchApx) Then
                                        ListofRpt.Add(rpt)
                                        dsTOC.Tables("TABLE_CONTENT_LIST").ImportRow(rowx)
                                    End If
                                ElseIf ReportName = "rpt_CAByRate" Then
                                    Dim rpt As rpt_CAByRate

                                    If mdlProcess.PrintReport_CAByRate(dsCA, ComName, YA, rpt, ErrorLog, SchApx) Then
                                        ListofRpt.Add(rpt)
                                        dsTOC.Tables("TABLE_CONTENT_LIST").ImportRow(rowx)
                                    End If
                                ElseIf ReportName = "rpt_CAByAsset" Then
                                    Dim rpt As rptCAReport

                                    If mdlProcess.PrintReport_CAByAsset(dsCA, ComName, YA, rpt, ErrorLog) Then
                                        ListofRpt.Add(rpt)
                                        dsTOC.Tables("TABLE_CONTENT_LIST").ImportRow(rowx)
                                    End If
                                End If
                            End If
                        End If
                        
                    Case "rpt_CP204_Breakdown"
                        Dim rpt As rpt_CP204_Breakdown

                        If dsCP204 Is Nothing Then
                            dsCP204 = New dsCP204
                        End If

                        dtTMP = ADO.Load_CP204_Search(RefNo, YA, -1, ErrorLog)

                        If dtTMP IsNot Nothing Then

                            For Each dtTMP_Rox As DataRow In dtTMP.Rows
                                rpt = Nothing

                                If mdlProcess.PrintReport_CP204(dsCP204, RefNo, YA, _
                                                                IIf(IsDBNull(dtTMP_Rox("BCP_KEY")), 0, dtTMP_Rox("BCP_KEY")), rpt, ErrorLog, SchApx) Then
                                    ListofRpt.Add(rpt)
                                End If
                            Next
                            dsTOC.Tables("TABLE_CONTENT_LIST").ImportRow(rowx)
                        End If
                    Case "rpt_RA"

                        Dim rpt As rpt_RA
                        If mdlProcess.PrintReport_RA(RefNo, YA, rpt, ErrorLog, SchApx) Then
                            ListofRpt.Add(rpt)
                            dsTOC.Tables("TABLE_CONTENT_LIST").ImportRow(rowx)
                        End If
                    Case "rpt_ITA"

                        Dim rpt As rpt_ITA
                        If mdlProcess.PrintReport_ITA(RefNo, YA, rpt, ErrorLog, SchApx) Then
                            ListofRpt.Add(rpt)
                            dsTOC.Tables("TABLE_CONTENT_LIST").ImportRow(rowx)
                        End If
                    Case "rpt_CASummaryQE"
                        Status = mdlReport_CA.Report_CA_SummaryQE(RefNo, YA, ID_CA_TMP, 0, 100, "", ErrorLog)

                        If Status Then
                            dtTMP = ADO.Load_CAReport_SummaryQE_Temp(ID_CA_TMP)

                            If dtTMP IsNot Nothing Then
                                If dsCA Is Nothing Then
                                    dsCA = New dsCA
                                End If

                                If mdlProcess.GenerateTable_SummaryQE(dtTMP, dsCA, ErrorLog) Then

                                    Dim rpt As rpt_CASummaryQE
                                    If mdlProcess.PrintReport_SummaryQE(dsCA, ID_CA_TMP, rpt, ErrorLog, SchApx) Then
                                        ListofRpt.Add(rpt)
                                        dsTOC.Tables("TABLE_CONTENT_LIST").ImportRow(rowx)
                                    End If

                                End If
                            End If
                        End If
                    Case "rpt_CAAnalysis"
                        Status = mdlReport_CA.Report_CA_Analysis(RefNo, YA, ID_CA_TMP, 0, 100, "", ErrorLog)

                        If Status Then
                            dtTMP = ADO.Load_CAReport_Analysis_Temp(ID_CA_TMP)

                            If dtTMP IsNot Nothing Then
                                If dsCA Is Nothing Then
                                    dsCA = New dsCA
                                End If

                                Dim rpt As rpt_CAAnalysis
                                If mdlProcess.PrintReport_CAAnalysis(dsCA, ID_CA_TMP, rpt, ErrorLog, SchApx) Then
                                    ListofRpt.Add(rpt)
                                    dsTOC.Tables("TABLE_CONTENT_LIST").ImportRow(rowx)
                                End If
                            End If
                        End If

                End Select

            Next

            If ListofRpt IsNot Nothing AndAlso ListofRpt.Count > 0 Then
                Dim minPageCount As Integer = 10000

                Dim rpt As DevExpress.XtraReports.UI.XtraReport = Nothing
                Dim rptChild As DevExpress.XtraReports.UI.XtraReport = Nothing


                Dim rpt_TOC As New rpt_TableofContent
                rpt_TOC.DataSource = dsTOC.Tables("TABLE_CONTENT_LIST")
                rpt_TOC.paramCompanyName.Value = ComName
                rpt_TOC.paramYA.Value = IIf(IsNumeric(YA), CInt(YA), 0)
                rpt_TOC.CreateDocument()
                rpt = rpt_TOC
                Application.DoEvents()


                If rpt IsNot Nothing Then

                    For i As Integer = 0 To ListofRpt.Count - 1

                        '  If i <> 0 Then

                        If ListofRpt(i) IsNot Nothing Then
                            ListofRpt(i).CreateDocument()

                            rptChild = ListofRpt(i)

                            If rptChild IsNot Nothing Then

                                rpt.Pages.AddRange(rptChild.Pages)
                                'For x As Integer = 0 To rptChild.RowCount - 1
                                '    rpt.Pages.Add(rptChild.Pages(x))
                                'Next

                            End If

                        End If

                        'End If

                    Next

                End If

                rpt.PrintingSystem.ContinuousPageNumbering = True

                Dim printTool As New ReportPrintTool(rpt)
                printTool.ShowPreviewDialog()



                'Dim minPageCount As Integer = Math.Min(rpt1.Pages.Count, rpt2.Pages.Count)

                'minPageCount = Math.Min(minPageCount, rpt3.Pages.Count)

                'Dim x As Integer = 0
                'Do While x < minPageCount
                '    rpt1.Pages.Insert(x * 2 + 1, rpt2.Pages(x))
                '    '  rpt1.Pages.Insert(x * 2 + 1, rpt3.Pages(x))
                '    x += 1
                'Loop

                'If rpt2.Pages.Count <> minPageCount Then
                '    x = minPageCount
                '    Do While x < rpt2.Pages.Count
                '        rpt1.Pages.Add(rpt2.Pages(x))
                '        x += 1
                '    Loop
                'End If

                'If rpt3.Pages.Count <> minPageCount Then
                '    x = minPageCount
                '    Do While x < rpt3.Pages.Count
                '        rpt1.Pages.Add(rpt3.Pages(x))
                '        x += 1
                '    Loop
                'End If

                '' Reset all page numbers in the resulting document. 
                'rpt1.PrintingSystem.ContinuousPageNumbering = True

                '' Show the Print Preview form (in a WinForms application). 
                'Dim printTool As New ReportPrintTool(rpt1)
                'printTool.ShowPreviewDialog()
            End If
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
