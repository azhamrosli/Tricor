Public Class rpt_CAWrittenOff
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
    Friend WithEvents tableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tblTotalCategory As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents groupFooterBand1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents tableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents detailBand1 As DevExpress.XtraReports.UI.DetailBand
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
    Friend WithEvents tblTotalCategory_line As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents paramCompanyName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents paramYA As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents FontSize As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paramSch As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tblNote_Bot As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents param_ShowDraft As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents lblDraft_Report As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ShowDraft As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents tblTotalCategory_line2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents tblTotalCategory_line2_Bot As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents tblTotalCategory_line_Bot As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents tblNote_Top As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents paramTitle As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents lblDraft_Page As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pnlTitle As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
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
        Me.pnlTitle = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblDraft_Page = New DevExpress.XtraReports.UI.XRLabel()
        Me.ShowDraft = New DevExpress.XtraReports.UI.FormattingRule()
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
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramSch = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramCompanyName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramYA = New DevExpress.XtraReports.Parameters.Parameter()
        Me.lblTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramTitle = New DevExpress.XtraReports.Parameters.Parameter()
        Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.table2 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.table3 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.groupFooterBand1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.tblNote_Top = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tblTotalCategory_line2_Bot = New DevExpress.XtraReports.UI.XRLine()
        Me.tblTotalCategory_line_Bot = New DevExpress.XtraReports.UI.XRLine()
        Me.tblTotalCategory_line2 = New DevExpress.XtraReports.UI.XRLine()
        Me.tblTotalCategory_line = New DevExpress.XtraReports.UI.XRLine()
        Me.tblTotalCategory = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.reportFooterBand1 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.tblNote_Bot = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.FontSize = New DevExpress.XtraReports.Parameters.Parameter()
        Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeaderBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportGroupHeaderBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportDetailBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportGroupFooterBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportFooterBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportOddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportEvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.CAREPORTDISPOSALTEMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCA = New EasyTemplate_Taxcom.dsCA()
        Me.param_ShowDraft = New DevExpress.XtraReports.Parameters.Parameter()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblNote_Top, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblTotalCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblNote_Bot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pnlTitle, Me.lblDraft_Page, Me.table1})
        Me.pageHeaderBand1.Dpi = 254.0!
        Me.pageHeaderBand1.HeightF = 339.1758!
        Me.pageHeaderBand1.Name = "pageHeaderBand1"
        Me.pageHeaderBand1.StyleName = "ReportHeaderBandStyle"
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.Transparent
        Me.pnlTitle.CanShrink = True
        Me.pnlTitle.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.XrLabel8, Me.XrLabel14, Me.XrLabel13, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.XrLabel1})
        Me.pnlTitle.Dpi = 254.0!
        Me.pnlTitle.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 241.28!)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.SizeF = New System.Drawing.SizeF(2697.0!, 97.89583!)
        Me.pnlTitle.StylePriority.UseBackColor = False
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(1670.782!, 0.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(217.0238!, 58.41998!)
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
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(747.6839!, 0.000003814697!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(205.9838!, 58.42001!)
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
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(2273.693!, 0.0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(249.3674!, 58.41998!)
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
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(2066.335!, 0.0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(207.3572!, 58.42001!)
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
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(1449.109!, 0.0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(221.6722!, 58.41998!)
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
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(1224.144!, 0.0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(224.9652!, 58.42001!)
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
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(953.6677!, 0.0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(270.4766!, 58.41998!)
        Me.XrLabel9.StylePriority.UseBackColor = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "RM"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.002733866!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(553.4481!, 58.41995!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'lblDraft_Page
        '
        Me.lblDraft_Page.BackColor = System.Drawing.Color.Transparent
        Me.lblDraft_Page.CanShrink = True
        Me.lblDraft_Page.Dpi = 254.0!
        Me.lblDraft_Page.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDraft_Page.FormattingRules.Add(Me.ShowDraft)
        Me.lblDraft_Page.LocationFloat = New DevExpress.Utils.PointFloat(2202.915!, 0.0!)
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
        Me.ShowDraft.Condition = "[Parameters.param_ShowDraft]=True"
        Me.ShowDraft.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.ShowDraft.Name = "ShowDraft"
        '
        'table1
        '
        Me.table1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.table1.Dpi = 254.0!
        Me.table1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 97.9!)
        Me.table1.Name = "table1"
        Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
        Me.table1.SizeF = New System.Drawing.SizeF(2523.06!, 143.38!)
        Me.table1.StylePriority.UseBackColor = False
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
        Me.tableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 10, 0, 0, 254.0!)
        Me.tableCell1.StylePriority.UseBackColor = False
        Me.tableCell1.StylePriority.UsePadding = False
        Me.tableCell1.StylePriority.UseTextAlignment = False
        Me.tableCell1.Text = "Description"
        Me.tableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        Me.tableCell1.Weight = 0.6096284744682251R
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
        Me.tableCell2.Weight = 0.21394850763902282R
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
        Me.tableCell3.Weight = 0.226892055098191R
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
        Me.tableCell4.Weight = 0.29793101531844363R
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
        Me.tableCell5.Weight = 0.24780013514907304R
        '
        'tableCell6
        '
        Me.tableCell6.BackColor = System.Drawing.Color.Transparent
        Me.tableCell6.Dpi = 254.0!
        Me.tableCell6.Multiline = True
        Me.tableCell6.Name = "tableCell6"
        Me.tableCell6.StylePriority.UseBackColor = False
        Me.tableCell6.StylePriority.UseTextAlignment = False
        Me.tableCell6.Text = "Disposal Value" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell6.Weight = 0.24417294431376896R
        '
        'tableCell7
        '
        Me.tableCell7.BackColor = System.Drawing.Color.Transparent
        Me.tableCell7.Dpi = 254.0!
        Me.tableCell7.Multiline = True
        Me.tableCell7.Name = "tableCell7"
        Me.tableCell7.StylePriority.UseBackColor = False
        Me.tableCell7.StylePriority.UseTextAlignment = False
        Me.tableCell7.Text = "Profit / (Loss)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell7.Weight = 0.23905261520364424R
        '
        'tableCell8
        '
        Me.tableCell8.BackColor = System.Drawing.Color.Transparent
        Me.tableCell8.Dpi = 254.0!
        Me.tableCell8.Multiline = True
        Me.tableCell8.Name = "tableCell8"
        Me.tableCell8.StylePriority.UseBackColor = False
        Me.tableCell8.StylePriority.UseTextAlignment = False
        Me.tableCell8.Text = "Rate of AA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%"
        Me.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell8.Weight = 0.19665142298808794R
        '
        'tableCell9
        '
        Me.tableCell9.BackColor = System.Drawing.Color.Transparent
        Me.tableCell9.Dpi = 254.0!
        Me.tableCell9.Multiline = True
        Me.tableCell9.Name = "tableCell9"
        Me.tableCell9.StylePriority.UseBackColor = False
        Me.tableCell9.StylePriority.UseTextAlignment = False
        Me.tableCell9.Text = "Tax " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "W.D.V"
        Me.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell9.Weight = 0.22840478187266008R
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
        Me.tableCell10.Weight = 0.27467949201970576R
        '
        'lblDraft_Report
        '
        Me.lblDraft_Report.BackColor = System.Drawing.Color.Transparent
        Me.lblDraft_Report.CanShrink = True
        Me.lblDraft_Report.Dpi = 254.0!
        Me.lblDraft_Report.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDraft_Report.FormattingRules.Add(Me.ShowDraft)
        Me.lblDraft_Report.LocationFloat = New DevExpress.Utils.PointFloat(2202.915!, 0.0!)
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
        'XrLabel15
        '
        Me.XrLabel15.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramSch, "Text", "")})
        Me.XrLabel15.Dpi = 254.0!
        Me.XrLabel15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(1893.352!, 87.3125!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(629.7084!, 58.42!)
        Me.XrLabel15.StylePriority.UseBackColor = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "XrLabel15"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
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
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0.0009689331!, 152.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(1695.568!, 58.42!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "XrLabel4"
        '
        'paramCompanyName
        '
        Me.paramCompanyName.Description = "paramCompanyName"
        Me.paramCompanyName.Name = "paramCompanyName"
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramYA, "Text", "INCOME TAX COMPUTATION - YEAR OF ASSESSMENT  {0}")})
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0009689331!, 210.42!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(1695.568!, 58.42001!)
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
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramTitle, "Text", "")})
        Me.lblTitle.Dpi = 254.0!
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.LocationFloat = New DevExpress.Utils.PointFloat(0.0009689331!, 268.84!)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblTitle.SizeF = New System.Drawing.SizeF(1690.687!, 58.42001!)
        Me.lblTitle.StylePriority.UseBackColor = False
        Me.lblTitle.StylePriority.UseFont = False
        Me.lblTitle.Text = "PROPERTY, PLANT AND EQUIPMENT WRITTEN - OFF / BALANCING CHARGE AND ALLOWANCES"
        '
        'paramTitle
        '
        Me.paramTitle.Description = "paramTitle"
        Me.paramTitle.Name = "paramTitle"
        '
        'groupHeaderBand1
        '
        Me.groupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2})
        Me.groupHeaderBand1.Dpi = 254.0!
        Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CA_CAEEO", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("CA_CATEGORY_CODE", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage
        Me.groupHeaderBand1.HeightF = 70.25015!
        Me.groupHeaderBand1.KeepTogether = True
        Me.groupHeaderBand1.Name = "groupHeaderBand1"
        Me.groupHeaderBand1.StyleName = "ReportGroupHeaderBandStyle"
        '
        'table2
        '
        Me.table2.Dpi = 254.0!
        Me.table2.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table2.Name = "table2"
        Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2})
        Me.table2.SizeF = New System.Drawing.SizeF(2697.0!, 64.0!)
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
        Me.tableCell12.Weight = 1.0126608934072563R
        Me.tableCell12.WordWrap = False
        '
        'detailBand1
        '
        Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table3})
        Me.detailBand1.Dpi = 254.0!
        Me.detailBand1.EvenStyleName = "ReportEvenStyle"
        Me.detailBand1.HeightF = 64.0!
        Me.detailBand1.KeepTogether = True
        Me.detailBand1.KeepTogetherWithDetailReports = True
        Me.detailBand1.Name = "detailBand1"
        Me.detailBand1.OddStyleName = "ReportOddStyle"
        Me.detailBand1.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CA_PURCHASE_YEAR", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending), New DevExpress.XtraReports.UI.GroupField("CA_RATE_AA", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("CA_ASSET", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.detailBand1.StyleName = "ReportDetailBandStyle"
        '
        'table3
        '
        Me.table3.Dpi = 254.0!
        Me.table3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table3.Name = "table3"
        Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow3})
        Me.table3.SizeF = New System.Drawing.SizeF(2697.0!, 64.0!)
        Me.table3.StylePriority.UseFont = False
        '
        'tableRow3
        '
        Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell13, Me.tableCell14, Me.tableCell15, Me.tableCell16, Me.tableCell17, Me.tableCell18, Me.tableCell19, Me.tableCell20, Me.tableCell21, Me.tableCell22, Me.XrTableCell9})
        Me.tableRow3.Dpi = 254.0!
        Me.tableRow3.Name = "tableRow3"
        Me.tableRow3.Weight = 10.46953028649871R
        '
        'tableCell13
        '
        Me.tableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.CA_ASSET")})
        Me.tableCell13.Dpi = 254.0!
        Me.tableCell13.Name = "tableCell13"
        Me.tableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 10, 0, 0, 254.0!)
        Me.tableCell13.StylePriority.UsePadding = False
        Me.tableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.tableCell13.Weight = 0.655606890375655R
        Me.tableCell13.WordWrap = False
        '
        'tableCell14
        '
        Me.tableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.CA_PURCHASE_YEAR")})
        Me.tableCell14.Dpi = 254.0!
        Me.tableCell14.Name = "tableCell14"
        Me.tableCell14.StylePriority.UseTextAlignment = False
        Me.tableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell14.Weight = 0.23008457832958312R
        Me.tableCell14.WordWrap = False
        '
        'tableCell15
        '
        Me.tableCell15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.CA_QUALIFYING_COST", "{0:#,# ;(#,#);0 }")})
        Me.tableCell15.Dpi = 254.0!
        Me.tableCell15.Name = "tableCell15"
        Me.tableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell15.Weight = 0.24400434095411061R
        Me.tableCell15.WordWrap = False
        '
        'tableCell16
        '
        Me.tableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_DEPRECIATION", "{0:#,# ;(#,#);0 }")})
        Me.tableCell16.Dpi = 254.0!
        Me.tableCell16.Name = "tableCell16"
        Me.tableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell16.Weight = 0.32040114256797769R
        Me.tableCell16.WordWrap = False
        '
        'tableCell17
        '
        Me.tableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_WDV", "{0:#,# ;(#,#);0 }")})
        Me.tableCell17.Dpi = 254.0!
        Me.tableCell17.Name = "tableCell17"
        Me.tableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell17.Weight = 0.26648930815175886R
        Me.tableCell17.WordWrap = False
        '
        'tableCell18
        '
        Me.tableCell18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_DISPOSAL_VALUE", "{0:#,# ;(#,#);0 }")})
        Me.tableCell18.Dpi = 254.0!
        Me.tableCell18.Name = "tableCell18"
        Me.tableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell18.Weight = 0.26258851948758255R
        Me.tableCell18.WordWrap = False
        '
        'tableCell19
        '
        Me.tableCell19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_PNL", "{0:#,# ;(#,#);0 }")})
        Me.tableCell19.Dpi = 254.0!
        Me.tableCell19.Name = "tableCell19"
        Me.tableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell19.Weight = 0.25708207245657733R
        Me.tableCell19.WordWrap = False
        '
        'tableCell20
        '
        Me.tableCell20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.CA_RATE_AA", "{0:#,# ;(#,#);0 }")})
        Me.tableCell20.Dpi = 254.0!
        Me.tableCell20.Name = "tableCell20"
        Me.tableCell20.StylePriority.UseTextAlignment = False
        Me.tableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell20.Weight = 0.21148296731481186R
        Me.tableCell20.WordWrap = False
        '
        'tableCell21
        '
        Me.tableCell21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_TWDV", "{0:#,# ;(#,#);0 }")})
        Me.tableCell21.Dpi = 254.0!
        Me.tableCell21.Name = "tableCell21"
        Me.tableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell21.Weight = 0.24563116840812352R
        Me.tableCell21.WordWrap = False
        '
        'tableCell22
        '
        Me.tableCell22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_BABC", "{0:#,# ;(#,#);0 }")})
        Me.tableCell22.Dpi = 254.0!
        Me.tableCell22.Name = "tableCell22"
        Me.tableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell22.Weight = 0.29539568440629854R
        Me.tableCell22.WordWrap = False
        '
        'XrTableCell9
        '
        Me.XrTableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.CA_NOTE_COLUMN")})
        Me.XrTableCell9.Dpi = 254.0!
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell9.Weight = 0.20604574469972484R
        '
        'groupFooterBand1
        '
        Me.groupFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.tblNote_Top, Me.tblTotalCategory_line2_Bot, Me.tblTotalCategory_line_Bot, Me.tblTotalCategory_line2, Me.tblTotalCategory_line, Me.tblTotalCategory})
        Me.groupFooterBand1.Dpi = 254.0!
        Me.groupFooterBand1.HeightF = 181.3751!
        Me.groupFooterBand1.KeepTogether = True
        Me.groupFooterBand1.Name = "groupFooterBand1"
        Me.groupFooterBand1.StyleName = "ReportGroupFooterBandStyle"
        '
        'tblNote_Top
        '
        Me.tblNote_Top.BackColor = System.Drawing.Color.Transparent
        Me.tblNote_Top.Dpi = 254.0!
        Me.tblNote_Top.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.tblNote_Top.LocationFloat = New DevExpress.Utils.PointFloat(747.6839!, 117.8751!)
        Me.tblNote_Top.Name = "tblNote_Top"
        Me.tblNote_Top.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.tblNote_Top.SizeF = New System.Drawing.SizeF(1775.376!, 63.49999!)
        Me.tblNote_Top.StylePriority.UseBackColor = False
        Me.tblNote_Top.StylePriority.UseFont = False
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell18, Me.XrTableCell19, Me.XrTableCell20, Me.XrTableCell21, Me.XrTableCell22, Me.XrTableCell23, Me.XrTableCell24, Me.XrTableCell25})
        Me.XrTableRow3.Dpi = 254.0!
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 0.5679012345679012R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.CA_QUALIFYING_COST")})
        Me.XrTableCell18.Dpi = 254.0!
        Me.XrTableCell18.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.StylePriority.UseFont = False
        Me.XrTableCell18.StylePriority.UseTextAlignment = False
        Me.XrTableCell18.Text = "XrTableCell10"
        Me.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell18.Weight = 0.30159084057381452R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_DEPRECIATION")})
        Me.XrTableCell19.Dpi = 254.0!
        Me.XrTableCell19.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.StylePriority.UseFont = False
        Me.XrTableCell19.StylePriority.UseTextAlignment = False
        Me.XrTableCell19.Text = "XrTableCell11"
        Me.XrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell19.Weight = 0.39601723829885754R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_WDV")})
        Me.XrTableCell20.Dpi = 254.0!
        Me.XrTableCell20.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.StylePriority.UseFont = False
        Me.XrTableCell20.StylePriority.UseTextAlignment = False
        Me.XrTableCell20.Text = "XrTableCell12"
        Me.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell20.Weight = 0.32938219658437551R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_DISPOSAL_VALUE")})
        Me.XrTableCell21.Dpi = 254.0!
        Me.XrTableCell21.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.StylePriority.UseFont = False
        Me.XrTableCell21.StylePriority.UseTextAlignment = False
        Me.XrTableCell21.Text = "XrTableCell13"
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell21.Weight = 0.32456124751872861R
        '
        'XrTableCell22
        '
        Me.XrTableCell22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_PNL")})
        Me.XrTableCell22.Dpi = 254.0!
        Me.XrTableCell22.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.StylePriority.UseFont = False
        Me.XrTableCell22.StylePriority.UseTextAlignment = False
        Me.XrTableCell22.Text = "XrTableCell14"
        Me.XrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell22.Weight = 0.31775503665228771R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.Dpi = 254.0!
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.Weight = 0.26139416495549062R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_TWDV")})
        Me.XrTableCell24.Dpi = 254.0!
        Me.XrTableCell24.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.StylePriority.UseFont = False
        Me.XrTableCell24.StylePriority.UseTextAlignment = False
        Me.XrTableCell24.Text = "XrTableCell15"
        Me.XrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell24.Weight = 0.3036018429530371R
        '
        'XrTableCell25
        '
        Me.XrTableCell25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_BABC")})
        Me.XrTableCell25.Dpi = 254.0!
        Me.XrTableCell25.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.StylePriority.UseFont = False
        Me.XrTableCell25.StylePriority.UseTextAlignment = False
        Me.XrTableCell25.Text = "XrTableCell16"
        Me.XrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell25.Weight = 0.36511126973764296R
        '
        'tblTotalCategory_line2_Bot
        '
        Me.tblTotalCategory_line2_Bot.BackColor = System.Drawing.Color.Transparent
        Me.tblTotalCategory_line2_Bot.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.tblTotalCategory_line2_Bot.Dpi = 254.0!
        Me.tblTotalCategory_line2_Bot.LocationFloat = New DevExpress.Utils.PointFloat(2066.335!, 93.10417!)
        Me.tblTotalCategory_line2_Bot.Name = "tblTotalCategory_line2_Bot"
        Me.tblTotalCategory_line2_Bot.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.tblTotalCategory_line2_Bot.SizeF = New System.Drawing.SizeF(456.7251!, 21.54463!)
        Me.tblTotalCategory_line2_Bot.StylePriority.UseBackColor = False
        Me.tblTotalCategory_line2_Bot.StylePriority.UseBorders = False
        Me.tblTotalCategory_line2_Bot.StylePriority.UsePadding = False
        '
        'tblTotalCategory_line_Bot
        '
        Me.tblTotalCategory_line_Bot.BackColor = System.Drawing.Color.Transparent
        Me.tblTotalCategory_line_Bot.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.tblTotalCategory_line_Bot.Dpi = 254.0!
        Me.tblTotalCategory_line_Bot.LocationFloat = New DevExpress.Utils.PointFloat(747.6838!, 93.10413!)
        Me.tblTotalCategory_line_Bot.Name = "tblTotalCategory_line_Bot"
        Me.tblTotalCategory_line_Bot.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.tblTotalCategory_line_Bot.SizeF = New System.Drawing.SizeF(1140.122!, 21.54463!)
        Me.tblTotalCategory_line_Bot.StylePriority.UseBackColor = False
        Me.tblTotalCategory_line_Bot.StylePriority.UseBorders = False
        Me.tblTotalCategory_line_Bot.StylePriority.UsePadding = False
        '
        'tblTotalCategory_line2
        '
        Me.tblTotalCategory_line2.BackColor = System.Drawing.Color.Transparent
        Me.tblTotalCategory_line2.Dpi = 254.0!
        Me.tblTotalCategory_line2.LineWidth = 3
        Me.tblTotalCategory_line2.LocationFloat = New DevExpress.Utils.PointFloat(2066.335!, 2.645833!)
        Me.tblTotalCategory_line2.Name = "tblTotalCategory_line2"
        Me.tblTotalCategory_line2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.tblTotalCategory_line2.SizeF = New System.Drawing.SizeF(456.7251!, 26.45833!)
        Me.tblTotalCategory_line2.StylePriority.UseBackColor = False
        Me.tblTotalCategory_line2.StylePriority.UsePadding = False
        '
        'tblTotalCategory_line
        '
        Me.tblTotalCategory_line.BackColor = System.Drawing.Color.Transparent
        Me.tblTotalCategory_line.Dpi = 254.0!
        Me.tblTotalCategory_line.LineWidth = 3
        Me.tblTotalCategory_line.LocationFloat = New DevExpress.Utils.PointFloat(747.6838!, 2.645833!)
        Me.tblTotalCategory_line.Name = "tblTotalCategory_line"
        Me.tblTotalCategory_line.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.tblTotalCategory_line.SizeF = New System.Drawing.SizeF(1140.121!, 26.45833!)
        Me.tblTotalCategory_line.StylePriority.UseBackColor = False
        Me.tblTotalCategory_line.StylePriority.UsePadding = False
        '
        'tblTotalCategory
        '
        Me.tblTotalCategory.Dpi = 254.0!
        Me.tblTotalCategory.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.tblTotalCategory.LocationFloat = New DevExpress.Utils.PointFloat(747.6838!, 29.10418!)
        Me.tblTotalCategory.Name = "tblTotalCategory"
        Me.tblTotalCategory.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow4})
        Me.tblTotalCategory.SizeF = New System.Drawing.SizeF(1775.376!, 64.0!)
        Me.tblTotalCategory.StylePriority.UseFont = False
        '
        'tableRow4
        '
        Me.tableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell25, Me.tableCell26, Me.tableCell27, Me.tableCell28, Me.tableCell29, Me.tableCell30, Me.tableCell31, Me.tableCell32})
        Me.tableRow4.Dpi = 254.0!
        Me.tableRow4.Name = "tableRow4"
        Me.tableRow4.Weight = 10.46953028649871R
        '
        'tableCell25
        '
        Me.tableCell25.BackColor = System.Drawing.Color.Transparent
        Me.tableCell25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.CA_QUALIFYING_COST")})
        Me.tableCell25.Dpi = 254.0!
        Me.tableCell25.Name = "tableCell25"
        Me.tableCell25.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell25.StylePriority.UseBackColor = False
        XrSummary1.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary1.IgnoreNullValues = True
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell25.Summary = XrSummary1
        Me.tableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell25.Weight = 0.20912574577313797R
        Me.tableCell25.WordWrap = False
        '
        'tableCell26
        '
        Me.tableCell26.BackColor = System.Drawing.Color.Transparent
        Me.tableCell26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_DEPRECIATION")})
        Me.tableCell26.Dpi = 254.0!
        Me.tableCell26.Name = "tableCell26"
        Me.tableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell26.StylePriority.UseBackColor = False
        XrSummary2.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary2.IgnoreNullValues = True
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell26.Summary = XrSummary2
        Me.tableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell26.Weight = 0.27460175241796264R
        Me.tableCell26.WordWrap = False
        '
        'tableCell27
        '
        Me.tableCell27.BackColor = System.Drawing.Color.Transparent
        Me.tableCell27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_WDV")})
        Me.tableCell27.Dpi = 254.0!
        Me.tableCell27.Name = "tableCell27"
        Me.tableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell27.StylePriority.UseBackColor = False
        XrSummary3.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary3.IgnoreNullValues = True
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell27.Summary = XrSummary3
        Me.tableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell27.Weight = 0.22839646599291033R
        Me.tableCell27.WordWrap = False
        '
        'tableCell28
        '
        Me.tableCell28.BackColor = System.Drawing.Color.Transparent
        Me.tableCell28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_DISPOSAL_VALUE")})
        Me.tableCell28.Dpi = 254.0!
        Me.tableCell28.Name = "tableCell28"
        Me.tableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell28.StylePriority.UseBackColor = False
        XrSummary4.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary4.IgnoreNullValues = True
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell28.Summary = XrSummary4
        Me.tableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell28.Weight = 0.22505365932474786R
        Me.tableCell28.WordWrap = False
        '
        'tableCell29
        '
        Me.tableCell29.BackColor = System.Drawing.Color.Transparent
        Me.tableCell29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_PNL")})
        Me.tableCell29.Dpi = 254.0!
        Me.tableCell29.Name = "tableCell29"
        Me.tableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell29.StylePriority.UseBackColor = False
        XrSummary5.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary5.IgnoreNullValues = True
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell29.Summary = XrSummary5
        Me.tableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell29.Weight = 0.22033396125368976R
        Me.tableCell29.WordWrap = False
        '
        'tableCell30
        '
        Me.tableCell30.BackColor = System.Drawing.Color.Transparent
        Me.tableCell30.Dpi = 254.0!
        Me.tableCell30.Name = "tableCell30"
        Me.tableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell30.StylePriority.UseBackColor = False
        Me.tableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell30.Weight = 0.18125282501344256R
        Me.tableCell30.WordWrap = False
        '
        'tableCell31
        '
        Me.tableCell31.BackColor = System.Drawing.Color.Transparent
        Me.tableCell31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_TWDV")})
        Me.tableCell31.Dpi = 254.0!
        Me.tableCell31.Name = "tableCell31"
        Me.tableCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell31.StylePriority.UseBackColor = False
        XrSummary6.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary6.IgnoreNullValues = True
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell31.Summary = XrSummary6
        Me.tableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell31.Weight = 0.21052008625336149R
        Me.tableCell31.WordWrap = False
        '
        'tableCell32
        '
        Me.tableCell32.BackColor = System.Drawing.Color.Transparent
        Me.tableCell32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_BABC")})
        Me.tableCell32.Dpi = 254.0!
        Me.tableCell32.Name = "tableCell32"
        Me.tableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell32.StylePriority.UseBackColor = False
        XrSummary7.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary7.IgnoreNullValues = True
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell32.Summary = XrSummary7
        Me.tableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell32.Weight = 0.25317142465825654R
        Me.tableCell32.WordWrap = False
        '
        'reportFooterBand1
        '
        Me.reportFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.tblNote_Bot, Me.XrLabel6, Me.XrLine4, Me.XrTable1})
        Me.reportFooterBand1.Dpi = 254.0!
        Me.reportFooterBand1.HeightF = 185.9966!
        Me.reportFooterBand1.Name = "reportFooterBand1"
        '
        'XrLine2
        '
        Me.XrLine2.BackColor = System.Drawing.Color.Transparent
        Me.XrLine2.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLine2.Dpi = 254.0!
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(2066.335!, 96.03827!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(456.7246!, 26.45833!)
        Me.XrLine2.StylePriority.UseBackColor = False
        Me.XrLine2.StylePriority.UseBorders = False
        '
        'tblNote_Bot
        '
        Me.tblNote_Bot.BackColor = System.Drawing.Color.Transparent
        Me.tblNote_Bot.Dpi = 254.0!
        Me.tblNote_Bot.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.tblNote_Bot.LocationFloat = New DevExpress.Utils.PointFloat(747.6839!, 122.4966!)
        Me.tblNote_Bot.Name = "tblNote_Bot"
        Me.tblNote_Bot.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.tblNote_Bot.SizeF = New System.Drawing.SizeF(1775.376!, 63.49998!)
        Me.tblNote_Bot.StylePriority.UseBackColor = False
        Me.tblNote_Bot.StylePriority.UseFont = False
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell12, Me.XrTableCell13, Me.XrTableCell14, Me.XrTableCell17, Me.XrTableCell15, Me.XrTableCell16})
        Me.XrTableRow2.Dpi = 254.0!
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 0.5679012345679012R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.CA_QUALIFYING_COST")})
        Me.XrTableCell10.Dpi = 254.0!
        Me.XrTableCell10.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseFont = False
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        Me.XrTableCell10.Text = "XrTableCell10"
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell10.Weight = 0.30159139661749712R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_DEPRECIATION")})
        Me.XrTableCell11.Dpi = 254.0!
        Me.XrTableCell11.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseFont = False
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.Text = "XrTableCell11"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell11.Weight = 0.39601668225517495R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_WDV")})
        Me.XrTableCell12.Dpi = 254.0!
        Me.XrTableCell12.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StylePriority.UseFont = False
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.Text = "XrTableCell12"
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell12.Weight = 0.32938219658437551R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_DISPOSAL_VALUE")})
        Me.XrTableCell13.Dpi = 254.0!
        Me.XrTableCell13.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.StylePriority.UseFont = False
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        Me.XrTableCell13.Text = "XrTableCell13"
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell13.Weight = 0.32456124751872861R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_PNL")})
        Me.XrTableCell14.Dpi = 254.0!
        Me.XrTableCell14.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.StylePriority.UseFont = False
        Me.XrTableCell14.StylePriority.UseTextAlignment = False
        Me.XrTableCell14.Text = "XrTableCell14"
        Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell14.Weight = 0.31775503665228771R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.Dpi = 254.0!
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.Weight = 0.26139416495549062R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_TWDV")})
        Me.XrTableCell15.Dpi = 254.0!
        Me.XrTableCell15.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.StylePriority.UseFont = False
        Me.XrTableCell15.StylePriority.UseTextAlignment = False
        Me.XrTableCell15.Text = "XrTableCell15"
        Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell15.Weight = 0.3036018429530371R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_BABC")})
        Me.XrTableCell16.Dpi = 254.0!
        Me.XrTableCell16.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.StylePriority.UseFont = False
        Me.XrTableCell16.StylePriority.UseTextAlignment = False
        Me.XrTableCell16.Text = "XrTableCell16"
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell16.Weight = 0.36511126973764296R
        '
        'XrLabel6
        '
        Me.XrLabel6.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel6.Dpi = 254.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 37.61818!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(156.1042!, 58.42!)
        Me.XrLabel6.StylePriority.UseBackColor = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.Text = "TOTAL"
        '
        'XrLine4
        '
        Me.XrLine4.BackColor = System.Drawing.Color.Transparent
        Me.XrLine4.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLine4.Dpi = 254.0!
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(747.6839!, 96.03825!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.SizeF = New System.Drawing.SizeF(1140.122!, 26.45834!)
        Me.XrLine4.StylePriority.UseBackColor = False
        Me.XrLine4.StylePriority.UseBorders = False
        '
        'XrTable1
        '
        Me.XrTable1.Dpi = 254.0!
        Me.XrTable1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(747.6839!, 32.03825!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(1775.376!, 64.0!)
        Me.XrTable1.StylePriority.UseFont = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell8})
        Me.XrTableRow1.Dpi = 254.0!
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 10.46953028649871R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.CA_QUALIFYING_COST")})
        Me.XrTableCell1.Dpi = 254.0!
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.XrTableCell1.StylePriority.UseBackColor = False
        XrSummary8.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary8.IgnoreNullValues = True
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell1.Summary = XrSummary8
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell1.Weight = 0.209125685244404R
        Me.XrTableCell1.WordWrap = False
        '
        'XrTableCell2
        '
        Me.XrTableCell2.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_DEPRECIATION")})
        Me.XrTableCell2.Dpi = 254.0!
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.XrTableCell2.StylePriority.UseBackColor = False
        XrSummary9.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary9.IgnoreNullValues = True
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell2.Summary = XrSummary9
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell2.Weight = 0.27460191674393036R
        Me.XrTableCell2.WordWrap = False
        '
        'XrTableCell3
        '
        Me.XrTableCell3.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_WDV")})
        Me.XrTableCell3.Dpi = 254.0!
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.XrTableCell3.StylePriority.UseBackColor = False
        XrSummary10.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary10.IgnoreNullValues = True
        XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell3.Summary = XrSummary10
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell3.Weight = 0.2283963449370785R
        Me.XrTableCell3.WordWrap = False
        '
        'XrTableCell4
        '
        Me.XrTableCell4.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_DISPOSAL_VALUE")})
        Me.XrTableCell4.Dpi = 254.0!
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.XrTableCell4.StylePriority.UseBackColor = False
        XrSummary11.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary11.IgnoreNullValues = True
        XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell4.Summary = XrSummary11
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell4.Weight = 0.22505371060142715R
        Me.XrTableCell4.WordWrap = False
        '
        'XrTableCell5
        '
        Me.XrTableCell5.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_PNL")})
        Me.XrTableCell5.Dpi = 254.0!
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.XrTableCell5.StylePriority.UseBackColor = False
        XrSummary12.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary12.IgnoreNullValues = True
        XrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell5.Summary = XrSummary12
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell5.Weight = 0.22033392723560866R
        Me.XrTableCell5.WordWrap = False
        '
        'XrTableCell6
        '
        Me.XrTableCell6.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell6.Dpi = 254.0!
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.XrTableCell6.StylePriority.UseBackColor = False
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell6.Weight = 0.18125296108576702R
        Me.XrTableCell6.WordWrap = False
        '
        'XrTableCell7
        '
        Me.XrTableCell7.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_TWDV")})
        Me.XrTableCell7.Dpi = 254.0!
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.XrTableCell7.StylePriority.UseBackColor = False
        XrSummary13.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary13.IgnoreNullValues = True
        XrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell7.Summary = XrSummary13
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell7.Weight = 0.210519950181037R
        Me.XrTableCell7.WordWrap = False
        '
        'XrTableCell8
        '
        Me.XrTableCell8.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_BABC")})
        Me.XrTableCell8.Dpi = 254.0!
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.XrTableCell8.StylePriority.UseBackColor = False
        XrSummary14.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary14.IgnoreNullValues = True
        XrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell8.Summary = XrSummary14
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell8.Weight = 0.25317142465825654R
        Me.XrTableCell8.WordWrap = False
        '
        'FontSize
        '
        Me.FontSize.Description = "FontSize"
        Me.FontSize.Name = "FontSize"
        Me.FontSize.Type = GetType(Integer)
        Me.FontSize.ValueInfo = "0"
        '
        'bottomMarginBand1
        '
        Me.bottomMarginBand1.Dpi = 254.0!
        Me.bottomMarginBand1.HeightF = 52.54169!
        Me.bottomMarginBand1.Name = "bottomMarginBand1"
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
        'param_ShowDraft
        '
        Me.param_ShowDraft.Description = "param_ShowDraft"
        Me.param_ShowDraft.Name = "param_ShowDraft"
        Me.param_ShowDraft.Type = GetType(Boolean)
        Me.param_ShowDraft.ValueInfo = "False"
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblTitle, Me.XrLabel15, Me.XrLabel4, Me.XrLabel2, Me.lblDraft_Report})
        Me.ReportHeader.Dpi = 254.0!
        Me.ReportHeader.HeightF = 361.6559!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
        Me.PageFooter.Dpi = 254.0!
        Me.PageFooter.HeightF = 97.89584!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrPageInfo1.Dpi = 254.0!
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrPageInfo1.Format = "Page {0} / {1}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(2269.059!, 0.0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(254.0002!, 58.42!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'rpt_CAWrittenOff
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.topMarginBand1, Me.pageHeaderBand1, Me.groupHeaderBand1, Me.detailBand1, Me.groupFooterBand1, Me.reportFooterBand1, Me.bottomMarginBand1, Me.ReportHeader, Me.PageFooter})
        Me.DataMember = "CA_REPORT_DISPOSAL_TEMP"
        Me.DataSource = Me.DsCA
        Me.Dpi = 254.0!
        Me.FilterString = "[Type] = 1"
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.ShowDraft})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(196, 77, 100, 53)
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
        CType(Me.table3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblNote_Top, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblTotalCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblNote_Bot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAREPORTDISPOSALTEMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    'Private Sub tblTotalCategory_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles tblTotalCategory.BeforePrint
    '    Try
    '        Dim CA_TRANSFERROR_NAME As String = Me.GetCurrentColumnValue("CA_TRANSFERROR_NAME")
    '        Dim ID As String = Me.GetCurrentColumnValue("ID")
    '        Dim YA As String = Me.GetCurrentColumnValue("YA")
    '        Dim Count As Integer = ADO.Load_CAReport_CA_REPORT_DISPOSAL_TEMP_CountByControlTransfer(ID, YA, CA_TRANSFERROR_NAME, 1)

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
    Private Sub tblTotalCategory_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles tblTotalCategory.BeforePrint, groupFooterBand1.BeforePrint
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

                tblTotalCategory_line_Bot.Visible = False
                tblTotalCategory_line2_Bot.Visible = False

                'tblNote_Bot.Visible = False
                'tblNote_Top.Visible = True
                'tblNote_Top.LocationF = New PointF(727.14, 21.17)

                If Me.RowCount > 1 Then
                    tblNote_Bot.Visible = True
                    tblNote_Top.Visible = False
                    tblNote_Top.LocationF = New PointF(727.14, 21.17)
                    tblNote_Top.HeightF = 5
                    groupFooterBand1.HeightF = 64
                Else
                    tblNote_Bot.Visible = False
                    tblNote_Top.Visible = True
                    tblNote_Top.LocationF = New PointF(727.14, 21.17)
                    groupFooterBand1.HeightF = 169.8333
                End If
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
