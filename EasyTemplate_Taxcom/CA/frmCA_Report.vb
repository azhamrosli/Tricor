Imports DevExpress.XtraPrinting
Imports DevExpress.XtraGrid.Columns
Imports System.Drawing
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting.Links
Imports DevExpress.XtraPrintingLinks
Imports System.Drawing.Printing

Public Class frmCA_Report
    Public ID As String = ""
    Public RefNo As String = ""
    Public YA As String = ""
    Public ComName As String = ""
    Public TypeReport As Integer = 0
    Dim link As PrintableComponentLink

    Private Sub frmCA_Report_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            mdlProcess.Delete_CA_Report_TEMP(ID)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmCA_ReportList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadData()
        Try
            Dim dt As DataTable = Nothing

            Select Case TypeReport
                Case 0, 1, 2
                    dt = mdlProcess.Load_CAReport_Temp(ID, CInt(YA))
                Case 3, 4, 5
                    dt = mdlProcess.Load_CAReportSummary2_Temp(ID)
            End Select



            DsCA.Tables("CA_REPORT_TEMP").Rows.Clear()
            DsCA1.Tables("CA_REPORT_TEMP").Rows.Clear()
            If dt IsNot Nothing Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    DsCA.Tables("CA_REPORT_TEMP").ImportRow(dt.Rows(i))
                    DsCA1.Tables("CA_REPORT_TEMP").ImportRow(dt.Rows(i))
                Next
            End If



            Application.DoEvents()
            BandedGridView1.BeginSort()
            Select Case TypeReport
                Case 0
                    'Capital Allowance Details By Rate
                    Dim col1 As GridColumn = BandedGridView1.Columns("CA_TRANSFERROR_NAME")
                    Dim col2 As GridColumn = BandedGridView1.Columns("CA_PURCHASE_YEAR")
                    Dim col3 As GridColumn = BandedGridView1.Columns("CA_RATE_AA")

                    BandedGridView1.ClearGrouping()
                    col1.GroupIndex = 0
                    col2.GroupIndex = 1
                    col2.GroupIndex = 2
                Case 1
                    'Capital Allowance Details By Category
                    Dim col1 As GridColumn = BandedGridView1.Columns("CA_TRANSFERROR_NAME")
                    Dim col2 As GridColumn = BandedGridView1.Columns("CA_CATEGORY_CODE")
                    Dim col3 As GridColumn = BandedGridView1.Columns("CA_PURCHASE_YEAR")
                    Dim col4 As GridColumn = BandedGridView1.Columns("CA_RATE_AA")

                    BandedGridView1.ClearGrouping()
                    col1.GroupIndex = 0
                    col2.GroupIndex = 1
                    col3.GroupIndex = 2
                    col4.GroupIndex = 3

                    'BandedGridView1.SortInfo.ClearAndAddRange(New GridColumnSortInfo() {
                    '        New GridColumnSortInfo(col1, DevExpress.Data.ColumnSortOrder.Ascending),
                    '        New GridColumnSortInfo(col2, DevExpress.Data.ColumnSortOrder.Ascending)
                    '})

                Case 2, 5
                    'Capital Allowance Details By Asset
                    Dim col1 As GridColumn = BandedGridView1.Columns("CA_TRANSFERROR_NAME")
                    Dim col2 As GridColumn = BandedGridView1.Columns("YA")
                    Dim col3 As GridColumn = BandedGridView1.Columns("CA_ASSET")


                    BandedGridView1.ClearGrouping()
                    col1.GroupIndex = 0
                    col2.GroupIndex = 1

                    'BandedGridView1.SortInfo.ClearAndAddRange(New GridColumnSortInfo() {
                    '        New GridColumnSortInfo(col1, DevExpress.Data.ColumnSortOrder.Ascending),
                    '        New GridColumnSortInfo(col2, DevExpress.Data.ColumnSortOrder.Ascending)
                    '})
                Case 3
                    Dim col1 As GridColumn = BandedGridView1.Columns("CA_RATE_AA")
                    Dim col2 As GridColumn = BandedGridView1.Columns("CA_PURCHASE_YEAR")

                    BandedGridView1.ClearGrouping()
                    col1.GroupIndex = 0
                    col2.GroupIndex = 1
                Case 4
                    Dim col1 As GridColumn = BandedGridView1.Columns("CA_CATEGORY_CODE")
                    Dim col2 As GridColumn = BandedGridView1.Columns("CA_RATE_AA")
                    Dim col3 As GridColumn = BandedGridView1.Columns("CA_PURCHASE_YEAR")

                    BandedGridView1.ClearGrouping()
                    col1.GroupIndex = 0
                    col2.GroupIndex = 1
                    col3.GroupIndex = 2
            End Select
            BandedGridView1.EndSort()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Try

            Dim ListofGridControl As New List(Of DevExpress.XtraGrid.GridControl)

            ListofGridControl.Add(GridControl1)
            '  ListofGridControl.Add(GridControl2)
            Dim ps As PrintingSystem = New PrintingSystem
            Dim compisiteLink As DevExpress.XtraPrintingLinks.CompositeLink = New DevExpress.XtraPrintingLinks.CompositeLink
            compisiteLink.PrintingSystem = ps

            Dim Link As PrintableComponentLink

            For Each grid As DevExpress.XtraGrid.GridControl In ListofGridControl
                Link = New PrintableComponentLink
                '  AddHandler Link.CreateReportHeaderArea, AddressOf Grid_CreateReportHeaderArea
                Link.Component = grid

                compisiteLink.Links.Add(Link)

            Next

            compisiteLink.RtfReportHeader = vbCrLf & ComName & vbCrLf & "Reference No : C" & RefNo & vbCrLf & "Year of Assessment :" & YA
            compisiteLink.Landscape = True
            compisiteLink.MinMargins.Left = 5
            compisiteLink.MinMargins.Right = 5
            compisiteLink.PaperKind = PaperKind.A4
            compisiteLink.CreateDocument()
            compisiteLink.ShowPreview()


            ''Dim str As String = vbCrLf & ComName & vbCrLf & "Reference No : C" & RefNo & vbCrLf & "Year of Assessment :" & YA
            ''BandedGridView1.OptionsPrint.RtfPageHeader &= str

            ''  GridControl1.PrintDialog()
            ''  GridControl1.ShowPrintPreview()
            'Dim link As New PrintableComponentLink(New PrintingSystem())
            'AddHandler link.CreateReportHeaderArea, AddressOf Link_CreateReportHeaderArea
            '' AddHandler link.createPageHeaderArea, AddressOf Link_CreateReportHeaderArea1
            'link.Component = GridControl1

            ''Dim sb = New System.Text.StringBuilder()
            ''sb.Append("{\rtf1\deff0{\fonttbl{\f0 Calibri;}}{\colortbl ;\red0\green0\blue255 ;\red79\green129\blue189 ;\red238\green236\blue225 ;}{\*\defchp \fs22}{\stylesheet {\ql\fs22 Normal;}{\*\cs1\fs22 Default Paragraph Font;}{\*\cs2\sbasedon1\fs22 Line Number;}{\*\cs3\ul\fs22\cf1 Hyperlink;}{\*\ts4\tsrowd\fs22\ql\trautofit1\tscellpaddfl3\tscellpaddl108\tscellpaddfr3\tscellpaddr108\tsvertalt\cltxlrtb Normal Table;}{\*\ts5\tsrowd\sbasedon4\fs22\ql\trbrdrt\brdrs\brdrw10\trbrdrl\brdrs\brdrw10\trbrdrb\brdrs\brdrw10\trbrdrr\brdrs\brdrw10\trbrdrh\brdrs\brdrw10\trbrdrv\brdrs\brdrw10\trautofit1\tscellpaddfl3\tscellpaddl108\tscellpaddfr3\tscellpaddr108\tsvertalt\cltxlrtb Table Simple 1;}}{\*\listoverridetable}\nouicompat\splytwnine\htmautsp\sectd\trowd\irow0\irowband-1\lastrow\ts5\trbrdrt\brdrs\brdrw10\trbrdrl\brdrs\brdrw10\trbrdrb\brdrs\brdrw10\trbrdrr\brdrs\brdrw10\trbrdrh\brdrs\brdrw10\trbrdrv\brdrs\brdrw10\trleft-1080\trftsWidth1\trautofit1\trpaddfl3\trpaddl108\trpaddfr3\trpaddr108\tbllkhdrcols\tbllkhdrrows\tbllknocolband\tblindtype3\tblind-972\clvertalt\clbrdrt\brdrs\brdrw10\clbrdrl\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\cltxlrtb\clftsWidth3\clwWidth10785\clpadfr3\clpadr108\clpadft3\clpadt108\cellx9720\pard\plain\ql\intbl\fi1080\li-1080\lin-1080\cbpat2\yts5{\lang17417\langfe17417\fs22\cf3\chcbpat2 CAPITAL ALLOWANCE}\fs22\cf3\cell\trowd\irow0\irowband-1\lastrow\ts5\trbrdrt\brdrs\brdrw10\trbrdrl\brdrs\brdrw10\trbrdrb\brdrs\brdrw10\trbrdrr\brdrs\brdrw10\trbrdrh\brdrs\brdrw10\trbrdrv\brdrs\brdrw10\trleft-1080\trftsWidth1\trautofit1\trpaddfl3\trpaddl108\trpaddfr3\trpaddr108\tbllkhdrcols\tbllkhdrrows\tbllknocolband\tblindtype3\tblind-972\clvertalt\clbrdrt\brdrs\brdrw10\clbrdrl\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\cltxlrtb\clftsWidth3\clwWidth10785\clpadfr3\clpadr108\clpadft3\clpadt108\cellx9720\row\pard\plain\ql\fs22\par}")
            ''link.RtfReportHeader = sb.ToString()
            'link.Landscape = True

            'link.ShowPreview()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
        Try
            Dim rslt As DialogResult = FolderBrowserDialog1.ShowDialog

            If rslt = Windows.Forms.DialogResult.OK Then
                Dim Path As String = FolderBrowserDialog1.SelectedPath

                ' GridControl1.ExportToXlsx(Path & "\CA_REPORT_" & Format(Now, "ddMMMyyyyHHmmss") & ".xlsx")

                Dim ListofGridControl As New List(Of DevExpress.XtraGrid.GridControl)

                ListofGridControl.Add(GridControl1)
                '  ListofGridControl.Add(GridControl2)
                Dim ps As PrintingSystem = New PrintingSystem
                Dim compisiteLink As DevExpress.XtraPrintingLinks.CompositeLink = New DevExpress.XtraPrintingLinks.CompositeLink
                compisiteLink.PrintingSystem = ps

                Dim Link As PrintableComponentLink

                For Each grid As DevExpress.XtraGrid.GridControl In ListofGridControl
                    Link = New PrintableComponentLink
                    '  AddHandler Link.CreateReportHeaderArea, AddressOf Grid_CreateReportHeaderArea
                    Link.Component = grid

                    compisiteLink.Links.Add(Link)

                Next

                compisiteLink.RtfReportHeader = vbCrLf & ComName & vbCrLf & "Reference No : C" & RefNo & vbCrLf & "Year of Assessment :" & YA
                compisiteLink.CreateDocument()
                compisiteLink.Landscape = True
                compisiteLink.ExportToXlsx(Path & "\CA_REPORT_" & Format(Now, "ddMMMyyyyHHmmss") & ".xlsx")

            End If



        Catch ex As Exception

        End Try
    End Sub
    Private Sub Grid_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs)
        Try
            Dim pb As PanelBrick = New PanelBrick
            pb.Rect = New RectangleF(0, 0, 111, 111)
            e.Graph.DrawBrick(pb)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Link_CreateReportHeaderArea(sender As Object, e As CreateAreaEventArgs)
        Dim reportHeader As String = "Capital Allowance"
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Near)
        e.Graph.Font = New Font("Tahoma", 16, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.Bottom)

        Dim reportHeader1 As String = ComName
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Near)
        e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)
        Dim rec1 As RectangleF = New RectangleF(0, 30, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader1, Color.Black, rec1, BorderSide.None)

        Dim reportHeader2 As String = "Reference No : " & RefNo
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Near)
        e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)
        Dim rec2 As RectangleF = New RectangleF(0, 50, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader2, Color.Black, rec2, BorderSide.None)

        Dim reportHeader3 As String = "Year of Assessment : " & YA
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Near)
        e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)
        Dim rec3 As RectangleF = New RectangleF(0, 70, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader3, Color.Black, rec3, BorderSide.None)
    End Sub

    Private Sub btnExpand_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExpand.ItemClick
        Try
            BandedGridView1.ExpandAllGroups()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCollepase_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCollepase.ItemClick
        Try
            BandedGridView1.CollapseAllGroups()
        Catch ex As Exception

        End Try
    End Sub
End Class