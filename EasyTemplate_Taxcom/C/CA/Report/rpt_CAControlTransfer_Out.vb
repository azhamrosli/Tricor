Public Class rpt_CAControlTransfer_Out
	Inherits DevExpress.XtraReports.UI.XtraReport
    Friend WithEvents DsCA As EasyTemplate_Taxcom.dsCA
    Private components As System.ComponentModel.IContainer
    Friend WithEvents CAREPORTDISPOSALTEMPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportEvenStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportOddStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportFooterBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportGroupFooterBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportDetailBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportGroupHeaderBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportHeaderBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents reportFooterBand1 As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents tableCell56 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell55 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell53 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell52 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell51 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell49 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table8 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents groupFooterBand3 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents groupFooterBand2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents tableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell35 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tblTotalCategory As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents groupFooterBand1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents tableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents detailBand1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents tableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents groupHeaderBand3 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents groupHeaderBand2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents tableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents groupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents tableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents pageHeaderBand1 As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents tableCell54 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents paramYA As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paramCompanyName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents lblTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tblTotalCategory_line As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents FontSize As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paramSch As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tblNote_Bot As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents lblDraft_Report As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ShowDraft As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents param_ShowDraft As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tblTotalCategory_line2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents tblTotalCategory_line2_Bot As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents tblTotalCategory_line_Bot As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents tblNote_Top As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents paramTitle As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pnlTitle As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblDraft_Page As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents lblPageNo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary8 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary9 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary10 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary11 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary12 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary13 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary14 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.pageHeaderBand1 = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.lblDraft_Page = New DevExpress.XtraReports.UI.XRLabel()
        Me.ShowDraft = New DevExpress.XtraReports.UI.FormattingRule()
        Me.pnlTitle = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.table1 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblDraft_Report = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramSch = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramCompanyName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.lblTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramTitle = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramYA = New DevExpress.XtraReports.Parameters.Parameter()
        Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.table2 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.groupHeaderBand2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.groupHeaderBand3 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.table4 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.table5 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.groupFooterBand1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.tblNote_Top = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tblTotalCategory_line2_Bot = New DevExpress.XtraReports.UI.XRLine()
        Me.tblTotalCategory_line_Bot = New DevExpress.XtraReports.UI.XRLine()
        Me.tblTotalCategory_line2 = New DevExpress.XtraReports.UI.XRLine()
        Me.tblTotalCategory_line = New DevExpress.XtraReports.UI.XRLine()
        Me.tblTotalCategory = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.groupFooterBand2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.groupFooterBand3 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine()
        Me.tblNote_Bot = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.table8 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell49 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell51 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell52 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell53 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell54 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell55 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell56 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.reportFooterBand1 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.FontSize = New DevExpress.XtraReports.Parameters.Parameter()
        Me.ReportHeaderBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportGroupHeaderBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportDetailBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportGroupFooterBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportFooterBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportOddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportEvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.CAREPORTDISPOSALTEMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCA = New EasyTemplate_Taxcom.dsCA()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.param_ShowDraft = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.lblPageNo = New DevExpress.XtraReports.UI.XRPageInfo()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblNote_Top, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblTotalCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblNote_Bot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAREPORTDISPOSALTEMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'topMarginBand1
        '
        Me.topMarginBand1.Dpi = 254.0!
        Me.topMarginBand1.HeightF = 100.0!
        Me.topMarginBand1.Name = "topMarginBand1"
        '
        'pageHeaderBand1
        '
        Me.pageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblDraft_Page, Me.pnlTitle, Me.table1})
        Me.pageHeaderBand1.Dpi = 254.0!
        Me.pageHeaderBand1.HeightF = 314.1709!
        Me.pageHeaderBand1.Name = "pageHeaderBand1"
        Me.pageHeaderBand1.StyleName = "ReportHeaderBandStyle"
        '
        'lblDraft_Page
        '
        Me.lblDraft_Page.BackColor = System.Drawing.Color.Transparent
        Me.lblDraft_Page.CanShrink = True
        Me.lblDraft_Page.Dpi = 254.0!
        Me.lblDraft_Page.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDraft_Page.FormattingRules.Add(Me.ShowDraft)
        Me.lblDraft_Page.LocationFloat = New DevExpress.Utils.PointFloat(2202.917!, 0.0!)
        Me.lblDraft_Page.Name = "lblDraft_Page"
        Me.lblDraft_Page.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblDraft_Page.SizeF = New System.Drawing.SizeF(320.1453!, 58.42!)
        Me.lblDraft_Page.StylePriority.UseBackColor = False
        Me.lblDraft_Page.StylePriority.UseFont = False
        Me.lblDraft_Page.StylePriority.UseTextAlignment = False
        Me.lblDraft_Page.Text = "DRAFT"
        Me.lblDraft_Page.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblDraft_Page.Visible = False
        '
        'ShowDraft
        '
        Me.ShowDraft.Condition = "[Parameters.param_ShowDraft]=true"
        Me.ShowDraft.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.ShowDraft.Name = "ShowDraft"
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.Transparent
        Me.pnlTitle.CanShrink = True
        Me.pnlTitle.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.XrLabel8, Me.XrLabel14, Me.XrLabel13, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.XrLabel15})
        Me.pnlTitle.Dpi = 254.0!
        Me.pnlTitle.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 226.4583!)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.SizeF = New System.Drawing.SizeF(2700.0!, 87.7126!)
        Me.pnlTitle.StylePriority.UseBackColor = False
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(1698.228!, 0.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(183.7806!, 58.41998!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "RM"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel8.Dpi = 254.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(811.6179!, 0.0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(231.7202!, 58.42001!)
        Me.XrLabel8.StylePriority.UseBackColor = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "RM"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrLabel14
        '
        Me.XrLabel14.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel14.Dpi = 254.0!
        Me.XrLabel14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(2268.687!, 0.0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(254.3757!, 58.41998!)
        Me.XrLabel14.StylePriority.UseBackColor = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "RM"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrLabel13
        '
        Me.XrLabel13.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel13.Dpi = 254.0!
        Me.XrLabel13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(2093.752!, 0.0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(174.0723!, 58.42001!)
        Me.XrLabel13.StylePriority.UseBackColor = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "RM"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel11.Dpi = 254.0!
        Me.XrLabel11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(1506.778!, 0.0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(191.4502!, 58.41998!)
        Me.XrLabel11.StylePriority.UseBackColor = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "RM"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel10.Dpi = 254.0!
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(1303.822!, 0.0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(202.9558!, 58.42001!)
        Me.XrLabel10.StylePriority.UseBackColor = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "RM"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel9.Dpi = 254.0!
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(1043.338!, 0.0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(260.4836!, 58.41998!)
        Me.XrLabel9.StylePriority.UseBackColor = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "RM"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrLabel15
        '
        Me.XrLabel15.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel15.Dpi = 254.0!
        Me.XrLabel15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(0.002733866!, 0.0!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(630.2391!, 58.41995!)
        Me.XrLabel15.StylePriority.UseBackColor = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'table1
        '
        Me.table1.BackColor = System.Drawing.Color.Transparent
        Me.table1.BorderWidth = 0.0!
        Me.table1.Dpi = 254.0!
        Me.table1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 97.89997!)
        Me.table1.Name = "table1"
        Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
        Me.table1.SizeF = New System.Drawing.SizeF(2523.063!, 128.5583!)
        Me.table1.StylePriority.UseBackColor = False
        Me.table1.StylePriority.UseBorderWidth = False
        Me.table1.StylePriority.UseFont = False
        '
        'tableRow1
        '
        Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2, Me.tableCell3, Me.tableCell4, Me.tableCell5, Me.tableCell6, Me.tableCell7, Me.tableCell8, Me.tableCell9, Me.tableCell10})
        Me.tableRow1.Dpi = 254.0!
        Me.tableRow1.Name = "tableRow1"
        Me.tableRow1.Weight = 10.46953028649871R
        '
        'tableCell1
        '
        Me.tableCell1.BackColor = System.Drawing.Color.Transparent
        Me.tableCell1.Dpi = 254.0!
        Me.tableCell1.Name = "tableCell1"
        Me.tableCell1.StylePriority.UseBackColor = False
        Me.tableCell1.StylePriority.UseTextAlignment = False
        Me.tableCell1.Text = "Description"
        Me.tableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        Me.tableCell1.Weight = 0.69421335055328925R
        '
        'tableCell2
        '
        Me.tableCell2.BackColor = System.Drawing.Color.Transparent
        Me.tableCell2.Dpi = 254.0!
        Me.tableCell2.Name = "tableCell2"
        Me.tableCell2.StylePriority.UseBackColor = False
        Me.tableCell2.StylePriority.UseTextAlignment = False
        Me.tableCell2.Text = "Year of Purchase"
        Me.tableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell2.Weight = 0.1997868766459629R
        '
        'tableCell3
        '
        Me.tableCell3.BackColor = System.Drawing.Color.Transparent
        Me.tableCell3.Dpi = 254.0!
        Me.tableCell3.Multiline = True
        Me.tableCell3.Name = "tableCell3"
        Me.tableCell3.StylePriority.UseBackColor = False
        Me.tableCell3.StylePriority.UseTextAlignment = False
        Me.tableCell3.Text = "Cost" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell3.Weight = 0.25523995317823611R
        '
        'tableCell4
        '
        Me.tableCell4.BackColor = System.Drawing.Color.Transparent
        Me.tableCell4.Dpi = 254.0!
        Me.tableCell4.Name = "tableCell4"
        Me.tableCell4.StylePriority.UseBackColor = False
        Me.tableCell4.StylePriority.UseTextAlignment = False
        Me.tableCell4.Text = "Accumulated Depreciation"
        Me.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell4.Weight = 0.286923573548468R
        '
        'tableCell5
        '
        Me.tableCell5.BackColor = System.Drawing.Color.Transparent
        Me.tableCell5.Dpi = 254.0!
        Me.tableCell5.Multiline = True
        Me.tableCell5.Name = "tableCell5"
        Me.tableCell5.StylePriority.UseBackColor = False
        Me.tableCell5.StylePriority.UseTextAlignment = False
        Me.tableCell5.Text = "W.D.V" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell5.Weight = 0.22355646984920191R
        '
        'tableCell6
        '
        Me.tableCell6.BackColor = System.Drawing.Color.Transparent
        Me.tableCell6.Dpi = 254.0!
        Me.tableCell6.Name = "tableCell6"
        Me.tableCell6.StylePriority.UseBackColor = False
        Me.tableCell6.StylePriority.UseTextAlignment = False
        Me.tableCell6.Text = "Disposal Value"
        Me.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell6.Weight = 0.21088302170110912R
        '
        'tableCell7
        '
        Me.tableCell7.BackColor = System.Drawing.Color.Transparent
        Me.tableCell7.Dpi = 254.0!
        Me.tableCell7.Name = "tableCell7"
        Me.tableCell7.StylePriority.UseBackColor = False
        Me.tableCell7.StylePriority.UseTextAlignment = False
        Me.tableCell7.Text = "Profit / (Loss)"
        Me.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell7.Weight = 0.20243431004904303R
        '
        'tableCell8
        '
        Me.tableCell8.BackColor = System.Drawing.Color.Transparent
        Me.tableCell8.Dpi = 254.0!
        Me.tableCell8.Multiline = True
        Me.tableCell8.Name = "tableCell8"
        Me.tableCell8.StylePriority.UseBackColor = False
        Me.tableCell8.StylePriority.UseTextAlignment = False
        Me.tableCell8.Text = "Rate of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%"
        Me.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell8.Weight = 0.23323680710550077R
        '
        'tableCell9
        '
        Me.tableCell9.BackColor = System.Drawing.Color.Transparent
        Me.tableCell9.Dpi = 254.0!
        Me.tableCell9.Multiline = True
        Me.tableCell9.Name = "tableCell9"
        Me.tableCell9.StylePriority.UseBackColor = False
        Me.tableCell9.StylePriority.UseTextAlignment = False
        Me.tableCell9.Text = "Tax      W.D.V" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell9.Weight = 0.19174008441787962R
        '
        'tableCell10
        '
        Me.tableCell10.BackColor = System.Drawing.Color.Transparent
        Me.tableCell10.Dpi = 254.0!
        Me.tableCell10.Name = "tableCell10"
        Me.tableCell10.StylePriority.UseBackColor = False
        Me.tableCell10.StylePriority.UseTextAlignment = False
        Me.tableCell10.Text = "Balancing Charge / (Allowance)"
        Me.tableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell10.Weight = 0.28114693409929059R
        '
        'lblDraft_Report
        '
        Me.lblDraft_Report.BackColor = System.Drawing.Color.Transparent
        Me.lblDraft_Report.CanShrink = True
        Me.lblDraft_Report.Dpi = 254.0!
        Me.lblDraft_Report.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDraft_Report.FormattingRules.Add(Me.ShowDraft)
        Me.lblDraft_Report.LocationFloat = New DevExpress.Utils.PointFloat(2202.918!, 0.0!)
        Me.lblDraft_Report.Name = "lblDraft_Report"
        Me.lblDraft_Report.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblDraft_Report.SizeF = New System.Drawing.SizeF(320.1453!, 58.42!)
        Me.lblDraft_Report.StylePriority.UseBackColor = False
        Me.lblDraft_Report.StylePriority.UseFont = False
        Me.lblDraft_Report.StylePriority.UseTextAlignment = False
        Me.lblDraft_Report.Text = "DRAFT"
        Me.lblDraft_Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblDraft_Report.Visible = False
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramSch, "Text", "")})
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(1815.456!, 87.31248!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(707.6074!, 58.42!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "XrLabel5"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'paramSch
        '
        Me.paramSch.Description = "paramSch"
        Me.paramSch.Name = "paramSch"
        Me.paramSch.ValueInfo = "Schedule"
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramCompanyName, "Text", "NAME: {0}")})
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0.0006459554!, 165.2292!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(2066.396!, 58.42001!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "XrLabel4"
        '
        'paramCompanyName
        '
        Me.paramCompanyName.Description = "paramCompanyName"
        Me.paramCompanyName.Name = "paramCompanyName"
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramTitle, "Text", "")})
        Me.lblTitle.Dpi = 254.0!
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.LocationFloat = New DevExpress.Utils.PointFloat(0.0006459554!, 282.0692!)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblTitle.SizeF = New System.Drawing.SizeF(1640.416!, 58.42001!)
        Me.lblTitle.StylePriority.UseBackColor = False
        Me.lblTitle.StylePriority.UseFont = False
        Me.lblTitle.Text = "CONTROLLED TRANSFER OF PROPERTY, PLANT AND EQUIPMENT TO RELATED COMPANIES"
        '
        'paramTitle
        '
        Me.paramTitle.Description = "paramTitle"
        Me.paramTitle.Name = "paramTitle"
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramYA, "Text", "INCOME TAX COMPUTATION - YEAR OF ASSESSMENT  {0}")})
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0006459554!, 223.6491!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(2066.396!, 58.42001!)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseFont = False
        '
        'paramYA
        '
        Me.paramYA.Description = "paramYA"
        Me.paramYA.Name = "paramYA"
        Me.paramYA.Type = GetType(Integer)
        Me.paramYA.ValueInfo = "0"
        '
        'groupHeaderBand1
        '
        Me.groupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2})
        Me.groupHeaderBand1.Dpi = 254.0!
        Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CA_CATEGORY_CODE", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage
        Me.groupHeaderBand1.HeightF = 64.0!
        Me.groupHeaderBand1.KeepTogether = True
        Me.groupHeaderBand1.Name = "groupHeaderBand1"
        Me.groupHeaderBand1.StyleName = "ReportGroupHeaderBandStyle"
        '
        'table2
        '
        Me.table2.Dpi = 254.0!
        Me.table2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table2.Name = "table2"
        Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2})
        Me.table2.SizeF = New System.Drawing.SizeF(2703.0!, 64.0!)
        Me.table2.StylePriority.UseFont = False
        '
        'tableRow2
        '
        Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell12})
        Me.tableRow2.Dpi = 254.0!
        Me.tableRow2.Name = "tableRow2"
        Me.tableRow2.Weight = 10.46953028649871R
        '
        'tableCell12
        '
        Me.tableCell12.BackColor = System.Drawing.Color.Transparent
        Me.tableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.CA_CATEGORY_CODE")})
        Me.tableCell12.Dpi = 254.0!
        Me.tableCell12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell12.Name = "tableCell12"
        Me.tableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 254.0!)
        Me.tableCell12.StylePriority.UseBackColor = False
        Me.tableCell12.StylePriority.UseFont = False
        Me.tableCell12.StylePriority.UsePadding = False
        Me.tableCell12.Weight = 0.4597399311471474R
        Me.tableCell12.WordWrap = False
        '
        'groupHeaderBand2
        '
        Me.groupHeaderBand2.Dpi = 254.0!
        Me.groupHeaderBand2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CA_CAEEO", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.groupHeaderBand2.HeightF = 0.0!
        Me.groupHeaderBand2.Level = 1
        Me.groupHeaderBand2.Name = "groupHeaderBand2"
        Me.groupHeaderBand2.StyleName = "ReportGroupHeaderBandStyle"
        '
        'groupHeaderBand3
        '
        Me.groupHeaderBand3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table4})
        Me.groupHeaderBand3.Dpi = 254.0!
        Me.groupHeaderBand3.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CA_TRANSFERROR_NAME", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand3.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.groupHeaderBand3.HeightF = 64.0!
        Me.groupHeaderBand3.Level = 2
        Me.groupHeaderBand3.Name = "groupHeaderBand3"
        Me.groupHeaderBand3.StyleName = "ReportGroupHeaderBandStyle"
        '
        'table4
        '
        Me.table4.Dpi = 254.0!
        Me.table4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table4.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table4.Name = "table4"
        Me.table4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow4})
        Me.table4.SizeF = New System.Drawing.SizeF(2703.0!, 64.0!)
        Me.table4.StylePriority.UseFont = False
        '
        'tableRow4
        '
        Me.tableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell16})
        Me.tableRow4.Dpi = 254.0!
        Me.tableRow4.Name = "tableRow4"
        Me.tableRow4.Weight = 10.46953028649871R
        '
        'tableCell16
        '
        Me.tableCell16.BackColor = System.Drawing.Color.Transparent
        Me.tableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.CA_TRANSFERROR_NAME")})
        Me.tableCell16.Dpi = 254.0!
        Me.tableCell16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tableCell16.Name = "tableCell16"
        Me.tableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 254.0!)
        Me.tableCell16.StylePriority.UseBackColor = False
        Me.tableCell16.StylePriority.UseFont = False
        Me.tableCell16.StylePriority.UsePadding = False
        Me.tableCell16.Weight = 0.91864644452144872R
        Me.tableCell16.WordWrap = False
        '
        'detailBand1
        '
        Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table5})
        Me.detailBand1.Dpi = 254.0!
        Me.detailBand1.EvenStyleName = "ReportEvenStyle"
        Me.detailBand1.HeightF = 64.0!
        Me.detailBand1.KeepTogether = True
        Me.detailBand1.KeepTogetherWithDetailReports = True
        Me.detailBand1.Name = "detailBand1"
        Me.detailBand1.OddStyleName = "ReportOddStyle"
        Me.detailBand1.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CA_CATEGORY_CODE", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("CA_PURCHASE_YEAR", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("CA_RATE_AA", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("CA_ASSET", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.detailBand1.StyleName = "ReportDetailBandStyle"
        '
        'table5
        '
        Me.table5.Dpi = 254.0!
        Me.table5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table5.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table5.Name = "table5"
        Me.table5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow5})
        Me.table5.SizeF = New System.Drawing.SizeF(2703.0!, 64.0!)
        Me.table5.StylePriority.UseFont = False
        '
        'tableRow5
        '
        Me.tableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell17, Me.tableCell18, Me.tableCell19, Me.tableCell20, Me.tableCell21, Me.tableCell22, Me.tableCell23, Me.tableCell24, Me.tableCell25, Me.tableCell26, Me.XrTableCell1})
        Me.tableRow5.Dpi = 254.0!
        Me.tableRow5.Name = "tableRow5"
        Me.tableRow5.Weight = 10.46953028649871R
        '
        'tableCell17
        '
        Me.tableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.CA_ASSET")})
        Me.tableCell17.Dpi = 254.0!
        Me.tableCell17.Name = "tableCell17"
        Me.tableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 10, 0, 0, 254.0!)
        Me.tableCell17.StylePriority.UsePadding = False
        Me.tableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.tableCell17.Weight = 0.69637895194992017R
        Me.tableCell17.WordWrap = False
        '
        'tableCell18
        '
        Me.tableCell18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.CA_PURCHASE_YEAR")})
        Me.tableCell18.Dpi = 254.0!
        Me.tableCell18.Name = "tableCell18"
        Me.tableCell18.StylePriority.UseTextAlignment = False
        Me.tableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell18.Weight = 0.20041011823406449R
        Me.tableCell18.WordWrap = False
        '
        'tableCell19
        '
        Me.tableCell19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.CA_QUALIFYING_COST", "{0:#,# ;(#,#);0 }")})
        Me.tableCell19.Dpi = 254.0!
        Me.tableCell19.Name = "tableCell19"
        Me.tableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell19.Weight = 0.25603624016130422R
        Me.tableCell19.WordWrap = False
        '
        'tableCell20
        '
        Me.tableCell20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_DEPRECIATION", "{0:#,# ;(#,#);0 }")})
        Me.tableCell20.Dpi = 254.0!
        Me.tableCell20.Name = "tableCell20"
        Me.tableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell20.Weight = 0.28781863965909982R
        Me.tableCell20.WordWrap = False
        '
        'tableCell21
        '
        Me.tableCell21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_WDV", "{0:#,# ;(#,#);0 }")})
        Me.tableCell21.Dpi = 254.0!
        Me.tableCell21.Name = "tableCell21"
        Me.tableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell21.Weight = 0.22425385560222369R
        Me.tableCell21.WordWrap = False
        '
        'tableCell22
        '
        Me.tableCell22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_DISPOSAL_VALUE", "{0:#,# ;(#,#);0 }")})
        Me.tableCell22.Dpi = 254.0!
        Me.tableCell22.Name = "tableCell22"
        Me.tableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell22.Weight = 0.21154084618216568R
        Me.tableCell22.WordWrap = False
        '
        'tableCell23
        '
        Me.tableCell23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_PNL", "{0:#,# ;(#,#);0 }")})
        Me.tableCell23.Dpi = 254.0!
        Me.tableCell23.Name = "tableCell23"
        Me.tableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell23.Weight = 0.20306578340404929R
        Me.tableCell23.WordWrap = False
        '
        'tableCell24
        '
        Me.tableCell24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.CA_RATE_AA", "{0:n0}")})
        Me.tableCell24.Dpi = 254.0!
        Me.tableCell24.Name = "tableCell24"
        Me.tableCell24.StylePriority.UseTextAlignment = False
        Me.tableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell24.Weight = 0.23396443031203129R
        Me.tableCell24.WordWrap = False
        '
        'tableCell25
        '
        Me.tableCell25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_TWDV", "{0:#,# ;(#,#);0 }")})
        Me.tableCell25.Dpi = 254.0!
        Me.tableCell25.Name = "tableCell25"
        Me.tableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell25.Weight = 0.19233821658387582R
        Me.tableCell25.WordWrap = False
        '
        'tableCell26
        '
        Me.tableCell26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_BABC", "{0:#,# ;(#,#);0 }")})
        Me.tableCell26.Dpi = 254.0!
        Me.tableCell26.Name = "tableCell26"
        Me.tableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell26.Weight = 0.28202388556738089R
        Me.tableCell26.WordWrap = False
        '
        'XrTableCell1
        '
        Me.XrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.CA_NOTE_COLUMN")})
        Me.XrTableCell1.Dpi = 254.0!
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell1.Weight = 0.19882005769407146R
        '
        'groupFooterBand1
        '
        Me.groupFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.tblNote_Top, Me.tblTotalCategory_line2_Bot, Me.tblTotalCategory_line_Bot, Me.tblTotalCategory_line2, Me.tblTotalCategory_line, Me.tblTotalCategory})
        Me.groupFooterBand1.Dpi = 254.0!
        Me.groupFooterBand1.HeightF = 126.7!
        Me.groupFooterBand1.KeepTogether = True
        Me.groupFooterBand1.Name = "groupFooterBand1"
        Me.groupFooterBand1.StyleName = "ReportGroupFooterBandStyle"
        '
        'tblNote_Top
        '
        Me.tblNote_Top.BackColor = System.Drawing.Color.Transparent
        Me.tblNote_Top.Dpi = 254.0!
        Me.tblNote_Top.LocationFloat = New DevExpress.Utils.PointFloat(811.6185!, 114.0!)
        Me.tblNote_Top.Name = "tblNote_Top"
        Me.tblNote_Top.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.tblNote_Top.SizeF = New System.Drawing.SizeF(1711.445!, 12.7!)
        Me.tblNote_Top.StylePriority.UseBackColor = False
        Me.tblNote_Top.Visible = False
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell12, Me.XrTableCell13, Me.XrTableCell14, Me.XrTableCell15, Me.XrTableCell16, Me.XrTableCell17})
        Me.XrTableRow2.Dpi = 254.0!
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 0.5679012345679012R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.CA_QUALIFYING_COST")})
        Me.XrTableCell10.Dpi = 254.0!
        Me.XrTableCell10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseFont = False
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        Me.XrTableCell10.Text = "XrTableCell2"
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        Me.XrTableCell10.Weight = 0.25458372256524614R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_DEPRECIATION")})
        Me.XrTableCell11.Dpi = 254.0!
        Me.XrTableCell11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseFont = False
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.Text = "XrTableCell3"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell11.Weight = 0.28618520631535882R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_WDV")})
        Me.XrTableCell12.Dpi = 254.0!
        Me.XrTableCell12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StylePriority.UseFont = False
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.Text = "XrTableCell4"
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell12.Weight = 0.2229811754465621R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_DISPOSAL_VALUE")})
        Me.XrTableCell13.Dpi = 254.0!
        Me.XrTableCell13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.StylePriority.UseFont = False
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        Me.XrTableCell13.Text = "XrTableCell5"
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell13.Weight = 0.21034031040494247R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_PNL")})
        Me.XrTableCell14.Dpi = 254.0!
        Me.XrTableCell14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.StylePriority.UseFont = False
        Me.XrTableCell14.StylePriority.UseTextAlignment = False
        Me.XrTableCell14.Text = "XrTableCell6"
        Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell14.Weight = 0.20191334079347753R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.Dpi = 254.0!
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.Weight = 0.23263664550599564R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_TWDV")})
        Me.XrTableCell16.Dpi = 254.0!
        Me.XrTableCell16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.StylePriority.UseFont = False
        Me.XrTableCell16.StylePriority.UseTextAlignment = False
        Me.XrTableCell16.Text = "XrTableCell7"
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell16.Weight = 0.19124665786954761R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_BABC")})
        Me.XrTableCell17.Dpi = 254.0!
        Me.XrTableCell17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.StylePriority.UseFont = False
        Me.XrTableCell17.StylePriority.UseTextAlignment = False
        Me.XrTableCell17.Text = "XrTableCell8"
        Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell17.Weight = 0.28042336067278817R
        '
        'tblTotalCategory_line2_Bot
        '
        Me.tblTotalCategory_line2_Bot.BackColor = System.Drawing.Color.Transparent
        Me.tblTotalCategory_line2_Bot.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.tblTotalCategory_line2_Bot.Dpi = 254.0!
        Me.tblTotalCategory_line2_Bot.LineWidth = 3
        Me.tblTotalCategory_line2_Bot.LocationFloat = New DevExpress.Utils.PointFloat(2093.752!, 89.0!)
        Me.tblTotalCategory_line2_Bot.Name = "tblTotalCategory_line2_Bot"
        Me.tblTotalCategory_line2_Bot.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.tblTotalCategory_line2_Bot.SizeF = New System.Drawing.SizeF(429.31!, 25.0!)
        Me.tblTotalCategory_line2_Bot.StylePriority.UseBackColor = False
        Me.tblTotalCategory_line2_Bot.StylePriority.UseBorders = False
        Me.tblTotalCategory_line2_Bot.StylePriority.UsePadding = False
        Me.tblTotalCategory_line2_Bot.Visible = False
        '
        'tblTotalCategory_line_Bot
        '
        Me.tblTotalCategory_line_Bot.BackColor = System.Drawing.Color.Transparent
        Me.tblTotalCategory_line_Bot.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.tblTotalCategory_line_Bot.Dpi = 254.0!
        Me.tblTotalCategory_line_Bot.LineWidth = 3
        Me.tblTotalCategory_line_Bot.LocationFloat = New DevExpress.Utils.PointFloat(811.62!, 89.0!)
        Me.tblTotalCategory_line_Bot.Name = "tblTotalCategory_line_Bot"
        Me.tblTotalCategory_line_Bot.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.tblTotalCategory_line_Bot.SizeF = New System.Drawing.SizeF(1070.39!, 25.0!)
        Me.tblTotalCategory_line_Bot.StylePriority.UseBackColor = False
        Me.tblTotalCategory_line_Bot.StylePriority.UseBorders = False
        Me.tblTotalCategory_line_Bot.StylePriority.UsePadding = False
        Me.tblTotalCategory_line_Bot.Visible = False
        '
        'tblTotalCategory_line2
        '
        Me.tblTotalCategory_line2.BackColor = System.Drawing.Color.Transparent
        Me.tblTotalCategory_line2.Dpi = 254.0!
        Me.tblTotalCategory_line2.LineWidth = 3
        Me.tblTotalCategory_line2.LocationFloat = New DevExpress.Utils.PointFloat(2093.752!, 0.0!)
        Me.tblTotalCategory_line2.Name = "tblTotalCategory_line2"
        Me.tblTotalCategory_line2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.tblTotalCategory_line2.SizeF = New System.Drawing.SizeF(429.31!, 25.0!)
        Me.tblTotalCategory_line2.StylePriority.UseBackColor = False
        Me.tblTotalCategory_line2.StylePriority.UsePadding = False
        '
        'tblTotalCategory_line
        '
        Me.tblTotalCategory_line.BackColor = System.Drawing.Color.Transparent
        Me.tblTotalCategory_line.Dpi = 254.0!
        Me.tblTotalCategory_line.LineWidth = 3
        Me.tblTotalCategory_line.LocationFloat = New DevExpress.Utils.PointFloat(811.6184!, 0.0!)
        Me.tblTotalCategory_line.Name = "tblTotalCategory_line"
        Me.tblTotalCategory_line.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.tblTotalCategory_line.SizeF = New System.Drawing.SizeF(1070.39!, 25.0!)
        Me.tblTotalCategory_line.StylePriority.UseBackColor = False
        Me.tblTotalCategory_line.StylePriority.UsePadding = False
        '
        'tblTotalCategory
        '
        Me.tblTotalCategory.Dpi = 254.0!
        Me.tblTotalCategory.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblTotalCategory.LocationFloat = New DevExpress.Utils.PointFloat(811.6184!, 25.0!)
        Me.tblTotalCategory.Name = "tblTotalCategory"
        Me.tblTotalCategory.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow6})
        Me.tblTotalCategory.SizeF = New System.Drawing.SizeF(1711.444!, 64.0!)
        Me.tblTotalCategory.StylePriority.UseFont = False
        '
        'tableRow6
        '
        Me.tableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell29, Me.tableCell30, Me.tableCell31, Me.tableCell32, Me.tableCell33, Me.tableCell34, Me.tableCell35, Me.tableCell36})
        Me.tableRow6.Dpi = 254.0!
        Me.tableRow6.Name = "tableRow6"
        Me.tableRow6.Weight = 10.46953028649871R
        '
        'tableCell29
        '
        Me.tableCell29.BackColor = System.Drawing.Color.Transparent
        Me.tableCell29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.CA_QUALIFYING_COST")})
        Me.tableCell29.Dpi = 254.0!
        Me.tableCell29.Name = "tableCell29"
        Me.tableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 8, 254.0!)
        Me.tableCell29.StylePriority.UseBackColor = False
        Me.tableCell29.StylePriority.UsePadding = False
        XrSummary1.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary1.IgnoreNullValues = True
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell29.Summary = XrSummary1
        Me.tableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell29.Weight = 0.24486791670040975R
        Me.tableCell29.WordWrap = False
        '
        'tableCell30
        '
        Me.tableCell30.BackColor = System.Drawing.Color.Transparent
        Me.tableCell30.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_DEPRECIATION")})
        Me.tableCell30.Dpi = 254.0!
        Me.tableCell30.Name = "tableCell30"
        Me.tableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 8, 254.0!)
        Me.tableCell30.StylePriority.UseBackColor = False
        Me.tableCell30.StylePriority.UsePadding = False
        XrSummary2.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary2.IgnoreNullValues = True
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell30.Summary = XrSummary2
        Me.tableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell30.Weight = 0.27526396271171483R
        Me.tableCell30.WordWrap = False
        '
        'tableCell31
        '
        Me.tableCell31.BackColor = System.Drawing.Color.Transparent
        Me.tableCell31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_WDV")})
        Me.tableCell31.Dpi = 254.0!
        Me.tableCell31.Name = "tableCell31"
        Me.tableCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 8, 254.0!)
        Me.tableCell31.StylePriority.UseBackColor = False
        Me.tableCell31.StylePriority.UsePadding = False
        XrSummary3.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary3.IgnoreNullValues = True
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell31.Summary = XrSummary3
        Me.tableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell31.Weight = 0.21447189606091135R
        Me.tableCell31.WordWrap = False
        '
        'tableCell32
        '
        Me.tableCell32.BackColor = System.Drawing.Color.Transparent
        Me.tableCell32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_DISPOSAL_VALUE")})
        Me.tableCell32.Dpi = 254.0!
        Me.tableCell32.Name = "tableCell32"
        Me.tableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 8, 254.0!)
        Me.tableCell32.StylePriority.UseBackColor = False
        Me.tableCell32.StylePriority.UsePadding = False
        XrSummary4.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary4.IgnoreNullValues = True
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell32.Summary = XrSummary4
        Me.tableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell32.Weight = 0.20231342379975911R
        Me.tableCell32.WordWrap = False
        '
        'tableCell33
        '
        Me.tableCell33.BackColor = System.Drawing.Color.Transparent
        Me.tableCell33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_PNL")})
        Me.tableCell33.Dpi = 254.0!
        Me.tableCell33.Name = "tableCell33"
        Me.tableCell33.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 8, 254.0!)
        Me.tableCell33.StylePriority.UseBackColor = False
        Me.tableCell33.StylePriority.UsePadding = False
        XrSummary5.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary5.IgnoreNullValues = True
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell33.Summary = XrSummary5
        Me.tableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell33.Weight = 0.19420804251467835R
        Me.tableCell33.WordWrap = False
        '
        'tableCell34
        '
        Me.tableCell34.BackColor = System.Drawing.Color.Transparent
        Me.tableCell34.Dpi = 254.0!
        Me.tableCell34.Name = "tableCell34"
        Me.tableCell34.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell34.StylePriority.UseBackColor = False
        Me.tableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell34.Weight = 0.22375888612427511R
        Me.tableCell34.WordWrap = False
        '
        'tableCell35
        '
        Me.tableCell35.BackColor = System.Drawing.Color.Transparent
        Me.tableCell35.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_TWDV")})
        Me.tableCell35.Dpi = 254.0!
        Me.tableCell35.Name = "tableCell35"
        Me.tableCell35.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 8, 254.0!)
        Me.tableCell35.StylePriority.UseBackColor = False
        Me.tableCell35.StylePriority.UsePadding = False
        XrSummary6.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary6.IgnoreNullValues = True
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell35.Summary = XrSummary6
        Me.tableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell35.Weight = 0.1839484062006192R
        Me.tableCell35.WordWrap = False
        '
        'tableCell36
        '
        Me.tableCell36.BackColor = System.Drawing.Color.Transparent
        Me.tableCell36.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_BABC")})
        Me.tableCell36.Dpi = 254.0!
        Me.tableCell36.Name = "tableCell36"
        Me.tableCell36.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 8, 254.0!)
        Me.tableCell36.StylePriority.UseBackColor = False
        Me.tableCell36.StylePriority.UsePadding = False
        XrSummary7.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary7.IgnoreNullValues = True
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell36.Summary = XrSummary7
        Me.tableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell36.Weight = 0.2697219960940736R
        Me.tableCell36.WordWrap = False
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(156.1042!, 64.00014!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "TOTAL"
        '
        'groupFooterBand2
        '
        Me.groupFooterBand2.Dpi = 254.0!
        Me.groupFooterBand2.HeightF = 0.0!
        Me.groupFooterBand2.Level = 1
        Me.groupFooterBand2.Name = "groupFooterBand2"
        Me.groupFooterBand2.StyleName = "ReportGroupFooterBandStyle"
        '
        'groupFooterBand3
        '
        Me.groupFooterBand3.Dpi = 254.0!
        Me.groupFooterBand3.HeightF = 27.51667!
        Me.groupFooterBand3.Level = 2
        Me.groupFooterBand3.Name = "groupFooterBand3"
        Me.groupFooterBand3.StyleName = "ReportGroupFooterBandStyle"
        '
        'XrLine5
        '
        Me.XrLine5.BackColor = System.Drawing.Color.Transparent
        Me.XrLine5.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLine5.Dpi = 254.0!
        Me.XrLine5.LocationFloat = New DevExpress.Utils.PointFloat(2093.751!, 64.0001!)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLine5.SizeF = New System.Drawing.SizeF(429.3105!, 24.99992!)
        Me.XrLine5.StylePriority.UseBackColor = False
        Me.XrLine5.StylePriority.UseBorders = False
        Me.XrLine5.StylePriority.UsePadding = False
        '
        'tblNote_Bot
        '
        Me.tblNote_Bot.BackColor = System.Drawing.Color.Transparent
        Me.tblNote_Bot.Dpi = 254.0!
        Me.tblNote_Bot.LocationFloat = New DevExpress.Utils.PointFloat(811.6174!, 88.99999!)
        Me.tblNote_Bot.Name = "tblNote_Bot"
        Me.tblNote_Bot.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.tblNote_Bot.SizeF = New System.Drawing.SizeF(1711.445!, 63.5!)
        Me.tblNote_Bot.StylePriority.UseBackColor = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell9, Me.XrTableCell7, Me.XrTableCell8})
        Me.XrTableRow1.Dpi = 254.0!
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 0.5679012345679012R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.CA_QUALIFYING_COST")})
        Me.XrTableCell2.Dpi = 254.0!
        Me.XrTableCell2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.Text = "XrTableCell2"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        Me.XrTableCell2.Weight = 0.25458372256524614R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_DEPRECIATION")})
        Me.XrTableCell3.Dpi = 254.0!
        Me.XrTableCell3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "XrTableCell3"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell3.Weight = 0.28618520631535882R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_WDV")})
        Me.XrTableCell4.Dpi = 254.0!
        Me.XrTableCell4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.Text = "XrTableCell4"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell4.Weight = 0.2229811754465621R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_DISPOSAL_VALUE")})
        Me.XrTableCell5.Dpi = 254.0!
        Me.XrTableCell5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "XrTableCell5"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell5.Weight = 0.21034031040494247R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_PNL")})
        Me.XrTableCell6.Dpi = 254.0!
        Me.XrTableCell6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseFont = False
        Me.XrTableCell6.StylePriority.UseTextAlignment = False
        Me.XrTableCell6.Text = "XrTableCell6"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell6.Weight = 0.20191334079347753R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Dpi = 254.0!
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Weight = 0.23263664550599564R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_TWDV")})
        Me.XrTableCell7.Dpi = 254.0!
        Me.XrTableCell7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseFont = False
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.Text = "XrTableCell7"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell7.Weight = 0.19124665786954761R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_BABC")})
        Me.XrTableCell8.Dpi = 254.0!
        Me.XrTableCell8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseFont = False
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.Text = "XrTableCell8"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell8.Weight = 0.28042336067278817R
        '
        'XrLine3
        '
        Me.XrLine3.BackColor = System.Drawing.Color.Transparent
        Me.XrLine3.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLine3.Dpi = 254.0!
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(811.618!, 64.0001!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLine3.SizeF = New System.Drawing.SizeF(1070.389!, 24.99992!)
        Me.XrLine3.StylePriority.UseBackColor = False
        Me.XrLine3.StylePriority.UseBorders = False
        Me.XrLine3.StylePriority.UsePadding = False
        '
        'table8
        '
        Me.table8.Dpi = 254.0!
        Me.table8.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table8.LocationFloat = New DevExpress.Utils.PointFloat(811.618!, 0.0!)
        Me.table8.Name = "table8"
        Me.table8.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow8})
        Me.table8.SizeF = New System.Drawing.SizeF(1711.444!, 64.0!)
        Me.table8.StylePriority.UseFont = False
        '
        'tableRow8
        '
        Me.tableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell49, Me.tableCell50, Me.tableCell51, Me.tableCell52, Me.tableCell53, Me.tableCell54, Me.tableCell55, Me.tableCell56})
        Me.tableRow8.Dpi = 254.0!
        Me.tableRow8.Name = "tableRow8"
        Me.tableRow8.Weight = 10.46953028649871R
        '
        'tableCell49
        '
        Me.tableCell49.BackColor = System.Drawing.Color.Transparent
        Me.tableCell49.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.CA_QUALIFYING_COST")})
        Me.tableCell49.Dpi = 254.0!
        Me.tableCell49.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell49.Name = "tableCell49"
        Me.tableCell49.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 8, 254.0!)
        Me.tableCell49.StylePriority.UseBackColor = False
        Me.tableCell49.StylePriority.UseFont = False
        Me.tableCell49.StylePriority.UsePadding = False
        XrSummary8.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary8.IgnoreNullValues = True
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell49.Summary = XrSummary8
        Me.tableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell49.Weight = 0.22433603639970012R
        Me.tableCell49.WordWrap = False
        '
        'tableCell50
        '
        Me.tableCell50.BackColor = System.Drawing.Color.Transparent
        Me.tableCell50.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_DEPRECIATION")})
        Me.tableCell50.Dpi = 254.0!
        Me.tableCell50.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell50.Name = "tableCell50"
        Me.tableCell50.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 8, 254.0!)
        Me.tableCell50.StylePriority.UseBackColor = False
        Me.tableCell50.StylePriority.UseFont = False
        Me.tableCell50.StylePriority.UsePadding = False
        XrSummary9.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary9.IgnoreNullValues = True
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell50.Summary = XrSummary9
        Me.tableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell50.Weight = 0.25218341051195287R
        Me.tableCell50.WordWrap = False
        '
        'tableCell51
        '
        Me.tableCell51.BackColor = System.Drawing.Color.Transparent
        Me.tableCell51.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_WDV")})
        Me.tableCell51.Dpi = 254.0!
        Me.tableCell51.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell51.Name = "tableCell51"
        Me.tableCell51.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 8, 254.0!)
        Me.tableCell51.StylePriority.UseBackColor = False
        Me.tableCell51.StylePriority.UseFont = False
        Me.tableCell51.StylePriority.UsePadding = False
        XrSummary10.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary10.IgnoreNullValues = True
        XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell51.Summary = XrSummary10
        Me.tableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell51.Weight = 0.19648868445689305R
        Me.tableCell51.WordWrap = False
        '
        'tableCell52
        '
        Me.tableCell52.BackColor = System.Drawing.Color.Transparent
        Me.tableCell52.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_DISPOSAL_VALUE")})
        Me.tableCell52.Dpi = 254.0!
        Me.tableCell52.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell52.Name = "tableCell52"
        Me.tableCell52.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 8, 254.0!)
        Me.tableCell52.StylePriority.UseBackColor = False
        Me.tableCell52.StylePriority.UseFont = False
        Me.tableCell52.StylePriority.UsePadding = False
        XrSummary11.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary11.IgnoreNullValues = True
        XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell52.Summary = XrSummary11
        Me.tableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell52.Weight = 0.185349686546478R
        Me.tableCell52.WordWrap = False
        '
        'tableCell53
        '
        Me.tableCell53.BackColor = System.Drawing.Color.Transparent
        Me.tableCell53.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_PNL")})
        Me.tableCell53.Dpi = 254.0!
        Me.tableCell53.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell53.Name = "tableCell53"
        Me.tableCell53.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 8, 254.0!)
        Me.tableCell53.StylePriority.UseBackColor = False
        Me.tableCell53.StylePriority.UseFont = False
        Me.tableCell53.StylePriority.UsePadding = False
        XrSummary12.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary12.IgnoreNullValues = True
        XrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell53.Summary = XrSummary12
        Me.tableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell53.Weight = 0.17792393280848262R
        Me.tableCell53.WordWrap = False
        '
        'tableCell54
        '
        Me.tableCell54.BackColor = System.Drawing.Color.Transparent
        Me.tableCell54.Dpi = 254.0!
        Me.tableCell54.Name = "tableCell54"
        Me.tableCell54.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        Me.tableCell54.StylePriority.UseBackColor = False
        Me.tableCell54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell54.Weight = 0.20499697479864237R
        Me.tableCell54.WordWrap = False
        '
        'tableCell55
        '
        Me.tableCell55.BackColor = System.Drawing.Color.Transparent
        Me.tableCell55.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_TWDV")})
        Me.tableCell55.Dpi = 254.0!
        Me.tableCell55.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell55.Name = "tableCell55"
        Me.tableCell55.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 8, 254.0!)
        Me.tableCell55.StylePriority.UseBackColor = False
        Me.tableCell55.StylePriority.UseFont = False
        Me.tableCell55.StylePriority.UsePadding = False
        XrSummary13.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary13.IgnoreNullValues = True
        XrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell55.Summary = XrSummary13
        Me.tableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell55.Weight = 0.16852455882069114R
        Me.tableCell55.WordWrap = False
        '
        'tableCell56
        '
        Me.tableCell56.BackColor = System.Drawing.Color.Transparent
        Me.tableCell56.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_BABC")})
        Me.tableCell56.Dpi = 254.0!
        Me.tableCell56.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell56.Name = "tableCell56"
        Me.tableCell56.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 8, 254.0!)
        Me.tableCell56.StylePriority.UseBackColor = False
        Me.tableCell56.StylePriority.UseFont = False
        Me.tableCell56.StylePriority.UsePadding = False
        XrSummary14.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary14.IgnoreNullValues = True
        XrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell56.Summary = XrSummary14
        Me.tableCell56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell56.Weight = 0.24710612374319868R
        Me.tableCell56.WordWrap = False
        '
        'reportFooterBand1
        '
        Me.reportFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine5, Me.XrLabel1, Me.tblNote_Bot, Me.XrLine3, Me.table8})
        Me.reportFooterBand1.Dpi = 254.0!
        Me.reportFooterBand1.HeightF = 177.5!
        Me.reportFooterBand1.Name = "reportFooterBand1"
        '
        'bottomMarginBand1
        '
        Me.bottomMarginBand1.Dpi = 254.0!
        Me.bottomMarginBand1.HeightF = 79.0!
        Me.bottomMarginBand1.Name = "bottomMarginBand1"
        '
        'FontSize
        '
        Me.FontSize.Description = "FontSize"
        Me.FontSize.Name = "FontSize"
        Me.FontSize.Type = GetType(Integer)
        Me.FontSize.ValueInfo = "0"
        '
        'ReportHeaderBandStyle
        '
        Me.ReportHeaderBandStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ReportHeaderBandStyle.Name = "ReportHeaderBandStyle"
        Me.ReportHeaderBandStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254.0!)
        Me.ReportHeaderBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportGroupHeaderBandStyle
        '
        Me.ReportGroupHeaderBandStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ReportGroupHeaderBandStyle.Name = "ReportGroupHeaderBandStyle"
        Me.ReportGroupHeaderBandStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 254.0!)
        Me.ReportGroupHeaderBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportDetailBandStyle
        '
        Me.ReportDetailBandStyle.BackColor = System.Drawing.Color.Transparent
        Me.ReportDetailBandStyle.Name = "ReportDetailBandStyle"
        Me.ReportDetailBandStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254.0!)
        Me.ReportDetailBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportGroupFooterBandStyle
        '
        Me.ReportGroupFooterBandStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ReportGroupFooterBandStyle.Name = "ReportGroupFooterBandStyle"
        Me.ReportGroupFooterBandStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254.0!)
        Me.ReportGroupFooterBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportFooterBandStyle
        '
        Me.ReportFooterBandStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ReportFooterBandStyle.Name = "ReportFooterBandStyle"
        Me.ReportFooterBandStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254.0!)
        Me.ReportFooterBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportOddStyle
        '
        Me.ReportOddStyle.BackColor = System.Drawing.Color.Transparent
        Me.ReportOddStyle.Name = "ReportOddStyle"
        Me.ReportOddStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254.0!)
        Me.ReportOddStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportEvenStyle
        '
        Me.ReportEvenStyle.BackColor = System.Drawing.Color.Transparent
        Me.ReportEvenStyle.Name = "ReportEvenStyle"
        Me.ReportEvenStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254.0!)
        Me.ReportEvenStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'CAREPORTDISPOSALTEMPBindingSource
        '
        Me.CAREPORTDISPOSALTEMPBindingSource.DataMember = "CA_REPORT_DISPOSAL_TEMP"
        Me.CAREPORTDISPOSALTEMPBindingSource.DataSource = Me.DsCA
        '
        'DsCA
        '
        Me.DsCA.DataSetName = "dsCA"
        Me.DsCA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel5, Me.XrLabel4, Me.lblTitle, Me.lblDraft_Report})
        Me.ReportHeader.Dpi = 254.0!
        Me.ReportHeader.HeightF = 380.1767!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'param_ShowDraft
        '
        Me.param_ShowDraft.Description = "param_ShowDraft"
        Me.param_ShowDraft.Name = "param_ShowDraft"
        Me.param_ShowDraft.Type = GetType(Boolean)
        Me.param_ShowDraft.ValueInfo = "False"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblPageNo})
        Me.PageFooter.Dpi = 254.0!
        Me.PageFooter.HeightF = 254.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'lblPageNo
        '
        Me.lblPageNo.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.lblPageNo.Dpi = 254.0!
        Me.lblPageNo.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lblPageNo.Format = "Page {0} / {1}"
        Me.lblPageNo.LocationFloat = New DevExpress.Utils.PointFloat(2269.064!, 0.0!)
        Me.lblPageNo.Name = "lblPageNo"
        Me.lblPageNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblPageNo.SizeF = New System.Drawing.SizeF(253.9995!, 58.42!)
        Me.lblPageNo.StylePriority.UseFont = False
        Me.lblPageNo.StylePriority.UseTextAlignment = False
        Me.lblPageNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'rpt_CAControlTransfer_Out
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.topMarginBand1, Me.pageHeaderBand1, Me.groupHeaderBand1, Me.groupHeaderBand2, Me.groupHeaderBand3, Me.detailBand1, Me.groupFooterBand1, Me.groupFooterBand2, Me.groupFooterBand3, Me.reportFooterBand1, Me.bottomMarginBand1, Me.ReportHeader, Me.PageFooter})
        Me.DataMember = "CA_REPORT_DISPOSAL_TEMP"
        Me.DataSource = Me.DsCA
        Me.Dpi = 254.0!
        Me.FilterString = "[Type] = 2"
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.ShowDraft})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(198, 69, 100, 79)
        Me.PageHeight = 2100
        Me.PageWidth = 2970
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.paramCompanyName, Me.paramYA, Me.FontSize, Me.paramSch, Me.param_ShowDraft, Me.paramTitle})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.RequestParameters = False
        Me.SnapGridSize = 25.0!
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.ReportHeaderBandStyle, Me.ReportGroupHeaderBandStyle, Me.ReportDetailBandStyle, Me.ReportGroupFooterBandStyle, Me.ReportFooterBandStyle, Me.ReportOddStyle, Me.ReportEvenStyle})
        Me.Version = "17.1"
        CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblNote_Top, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblTotalCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblNote_Bot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAREPORTDISPOSALTEMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private Sub tblTotalCategory_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles tblTotalCategory.BeforePrint, tblTotalCategory_line_Bot.BeforePrint, tblTotalCategory_line2_Bot.BeforePrint, tblTotalCategory_line.BeforePrint, tblTotalCategory_line2.BeforePrint
        Try
            Dim CA_CATEGORY_CODE As String = Me.GetCurrentColumnValue("CA_CATEGORY_CODE")
            Dim CA_TRANSFERROR_NAME As String = Me.GetCurrentColumnValue("CA_TRANSFERROR_NAME")
            Dim ID As String = Me.GetCurrentColumnValue("ID")
            Dim YA As String = Me.GetCurrentColumnValue("YA")
            Dim Count As Integer = ADO.Load_CAReport_CA_REPORT_DISPOSAL_TEMP_CountByCATEGORY(ID, YA, CA_CATEGORY_CODE, CA_TRANSFERROR_NAME, Nothing)

            If Count <= 1 Then
                tblTotalCategory.Visible = False

                ' tblTotalCategory_line.Visible = True
                tblTotalCategory_line.Borders = DevExpress.XtraPrinting.BorderSide.Top
                tblTotalCategory_line.BorderWidth = 1
                tblTotalCategory_line2.Borders = DevExpress.XtraPrinting.BorderSide.Top
                tblTotalCategory_line2.BorderWidth = 1

                tblTotalCategory_line.Visible = True
                tblTotalCategory_line2.Visible = True
                tblTotalCategory_line_Bot.Visible = False
                tblTotalCategory_line2_Bot.Visible = False

                tblNote_Bot.Visible = False
                tblNote_Top.Visible = True
                tblNote_Top.LocationF = New PointF(727.14, 21.17)
            Else
                tblTotalCategory.Visible = True
                tblTotalCategory_line.Borders = DevExpress.XtraPrinting.BorderSide.None
                tblTotalCategory_line.BorderWidth = 0
                tblTotalCategory_line2.Borders = DevExpress.XtraPrinting.BorderSide.None
                tblTotalCategory_line2.BorderWidth = 0

                tblTotalCategory_line_Bot.Visible = True
                tblTotalCategory_line2_Bot.Visible = True
                ' tblTotalCategory_line.Visible = False
                tblNote_Bot.Visible = True
                tblNote_Top.Visible = False
            End If


        Catch ex As Exception

        End Try
    End Sub
    'Private Sub tblTotalCategory_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles tblTotalCategory.BeforePrint
    '    Try
    '        Dim CA_TRANSFERROR_NAME As String = Me.GetCurrentColumnValue("CA_TRANSFERROR_NAME")
    '        Dim ID As String = Me.GetCurrentColumnValue("ID")
    '        Dim YA As String = Me.GetCurrentColumnValue("YA")
    '        Dim Count As Integer = ADO.Load_CAReport_CA_REPORT_DISPOSAL_TEMP_CountByControlTransfer(ID, YA, CA_TRANSFERROR_NAME, 2)

    '        If Count <= 1 Then
    '            tblTotalCategory.Visible = False
    '            tblTotalCategory_line.Visible = False
    '            tblTotalCategory_line2.Visible = False
    '        Else
    '            tblTotalCategory.Visible = True
    '            tblTotalCategory_line.Visible = True
    '            tblTotalCategory_line2.Visible = True
    '        End If


    '    Catch ex As Exception

    '    End Try
    'End Sub
    Private Sub groupFooterBand3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles groupFooterBand3.BeforePrint
        Try
            If Me.Report.RowCount = 1 Then
                groupFooterBand3.Visible = False
            Else
                groupFooterBand3.Visible = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblTitle_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTitle.BeforePrint
        Try
            lblTitle.Text = lblTitle.Text.ToUpper
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblDraft_Report_PrintOnPage(sender As Object, e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles lblDraft_Report.PrintOnPage
        Try
            If e.PageIndex = 0 Then
                lblDraft_Report.Visible = True
                table1.LocationF = New PointF(0, 0)
                pnlTitle.LocationF = New PointF(0, 138.09)
                pageHeaderBand1.HeightF = 235.98
            Else
                lblDraft_Report.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblDraft_Page_PrintOnPage(sender As Object, e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles lblDraft_Page.PrintOnPage
        Try
            If e.PageIndex <> 0 Then
                lblDraft_Page.Visible = True
                table1.LocationF = New PointF(0, 97.9)
                pnlTitle.LocationF = New PointF(0, 235.98)
                pageHeaderBand1.HeightF = 333.875
            Else
                lblDraft_Page.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
