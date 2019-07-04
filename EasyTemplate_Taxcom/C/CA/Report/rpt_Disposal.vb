Public Class rpt_Disposal
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
    Friend WithEvents groupFooterBand2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents tableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tblTotalCategory As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents groupFooterBand1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents tableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents detailBand1 As DevExpress.XtraReports.UI.DetailBand
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
    Friend WithEvents tblTitle As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents pageHeaderBand1 As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents paramCompanyName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents paramYA As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tblTotalCategory_line As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
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
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents FontSize As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
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
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents SubBand1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents lblDraft_Report As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ShowDraft As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents param_ShowDraft As DevExpress.XtraReports.Parameters.Parameter
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
    Friend WithEvents tblTotalCategory_line_Bot As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents tblTotalCategory_line2_Bot As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents tblTotalCategory_line2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents paramTitle As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents lblDraft_Page As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pnlTitle As DevExpress.XtraReports.UI.XRPanel
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
        Me.lblDraft_Page = New DevExpress.XtraReports.UI.XRLabel()
        Me.ShowDraft = New DevExpress.XtraReports.UI.FormattingRule()
        Me.table1 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tblTitle = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.pnlTitle = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblDraft_Report = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramSch = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramYA = New DevExpress.XtraReports.Parameters.Parameter()
        Me.lblTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramTitle = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramCompanyName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.table2 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.groupHeaderBand2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.table4 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.groupFooterBand1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.tblTotalCategory_line2_Bot = New DevExpress.XtraReports.UI.XRLine()
        Me.tblTotalCategory_line2 = New DevExpress.XtraReports.UI.XRLine()
        Me.tblTotalCategory_line_Bot = New DevExpress.XtraReports.UI.XRLine()
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
        Me.tblTotalCategory_line = New DevExpress.XtraReports.UI.XRLine()
        Me.tblTotalCategory = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.groupFooterBand2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.reportFooterBand1 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
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
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
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
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.param_ShowDraft = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblNote_Top, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblTotalCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblNote_Bot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAREPORTDISPOSALTEMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'topMarginBand1
        '
        Me.topMarginBand1.Dpi = 254.0!
        Me.topMarginBand1.HeightF = 74.0!
        Me.topMarginBand1.Name = "topMarginBand1"
        '
        'pageHeaderBand1
        '
        Me.pageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblDraft_Page, Me.table1, Me.pnlTitle})
        Me.pageHeaderBand1.Dpi = 254.0!
        Me.pageHeaderBand1.HeightF = 333.875!
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
        Me.lblDraft_Page.LocationFloat = New DevExpress.Utils.PointFloat(2180.661!, 0.0!)
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
        Me.table1.BackColor = System.Drawing.Color.Transparent
        Me.table1.Dpi = 254.0!
        Me.table1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 97.89584!)
        Me.table1.Name = "table1"
        Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
        Me.table1.SizeF = New System.Drawing.SizeF(2500.805!, 138.0833!)
        Me.table1.StylePriority.UseBackColor = False
        Me.table1.StylePriority.UseFont = False
        '
        'tableRow1
        '
        Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tblTitle, Me.tableCell2, Me.tableCell3, Me.tableCell4, Me.tableCell5, Me.tableCell6, Me.tableCell7, Me.tableCell8, Me.tableCell9, Me.tableCell10})
        Me.tableRow1.Dpi = 254.0!
        Me.tableRow1.Name = "tableRow1"
        Me.tableRow1.Weight = 10.46953028649871R
        '
        'tblTitle
        '
        Me.tblTitle.BackColor = System.Drawing.Color.Transparent
        Me.tblTitle.Dpi = 254.0!
        Me.tblTitle.Name = "tblTitle"
        Me.tblTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.tblTitle.StylePriority.UseBackColor = False
        Me.tblTitle.StylePriority.UsePadding = False
        Me.tblTitle.StylePriority.UseTextAlignment = False
        Me.tblTitle.Text = "Description"
        Me.tblTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        Me.tblTitle.Weight = 0.65830189156625718R
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
        Me.tableCell2.Weight = 0.22110379688435344R
        '
        'tableCell3
        '
        Me.tableCell3.BackColor = System.Drawing.Color.Transparent
        Me.tableCell3.Dpi = 254.0!
        Me.tableCell3.Multiline = True
        Me.tableCell3.Name = "tableCell3"
        Me.tableCell3.StylePriority.UseBackColor = False
        Me.tableCell3.StylePriority.UseTextAlignment = False
        Me.tableCell3.Text = "Cost" & Global.Microsoft.VisualBasic.ChrW(13)
        Me.tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell3.Weight = 0.21804719493013652R
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
        Me.tableCell4.Weight = 0.29028076429143779R
        '
        'tableCell5
        '
        Me.tableCell5.BackColor = System.Drawing.Color.Transparent
        Me.tableCell5.Dpi = 254.0!
        Me.tableCell5.Multiline = True
        Me.tableCell5.Name = "tableCell5"
        Me.tableCell5.StylePriority.UseBackColor = False
        Me.tableCell5.StylePriority.UseTextAlignment = False
        Me.tableCell5.Text = "W.D.V"
        Me.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell5.Weight = 0.21322594555589608R
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
        Me.tableCell6.Weight = 0.23938182523058221R
        '
        'tableCell7
        '
        Me.tableCell7.BackColor = System.Drawing.Color.Transparent
        Me.tableCell7.Dpi = 254.0!
        Me.tableCell7.Multiline = True
        Me.tableCell7.Name = "tableCell7"
        Me.tableCell7.StylePriority.UseBackColor = False
        Me.tableCell7.StylePriority.UseTextAlignment = False
        Me.tableCell7.Text = "Profit /" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Loss)"
        Me.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell7.Weight = 0.2820465597816505R
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
        Me.tableCell8.Weight = 0.2377027385216145R
        '
        'tableCell9
        '
        Me.tableCell9.BackColor = System.Drawing.Color.Transparent
        Me.tableCell9.Dpi = 254.0!
        Me.tableCell9.Multiline = True
        Me.tableCell9.Name = "tableCell9"
        Me.tableCell9.StylePriority.UseBackColor = False
        Me.tableCell9.StylePriority.UseTextAlignment = False
        Me.tableCell9.Text = "Tax" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "W.D.V"
        Me.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell9.Weight = 0.23027828160532851R
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
        Me.tableCell10.Weight = 0.29332197507976859R
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.Transparent
        Me.pnlTitle.CanShrink = True
        Me.pnlTitle.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrLabel8, Me.XrLabel14, Me.XrLabel13, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.XrLabel15})
        Me.pnlTitle.Dpi = 254.0!
        Me.pnlTitle.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 235.9791!)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.SizeF = New System.Drawing.SizeF(2700.0!, 97.89583!)
        Me.pnlTitle.StylePriority.UseBackColor = False
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(1595.989!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(244.5974!, 58.41998!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "RM"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel8.Dpi = 254.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(762.6422!, 0.0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(189.0957!, 58.42001!)
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
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(2246.43!, 0.0!)
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
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(2046.726!, 0.0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(199.7034!, 58.42001!)
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
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(1388.391!, 0.0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(207.5977!, 58.41998!)
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
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(1203.476!, 0.0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(184.9146!, 58.42001!)
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
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(951.7379!, 0.0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(251.7384!, 58.41998!)
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
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(570.8951!, 58.41995!)
        Me.XrLabel15.StylePriority.UseBackColor = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'lblDraft_Report
        '
        Me.lblDraft_Report.BackColor = System.Drawing.Color.Transparent
        Me.lblDraft_Report.CanShrink = True
        Me.lblDraft_Report.Dpi = 254.0!
        Me.lblDraft_Report.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDraft_Report.FormattingRules.Add(Me.ShowDraft)
        Me.lblDraft_Report.LocationFloat = New DevExpress.Utils.PointFloat(2180.66!, 0.0!)
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
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(1910.786!, 87.31!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(590.021!, 58.42!)
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
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramYA, "Text", "INCOME TAX COMPUTATION - YEAR OF ASSESSMENT  {0}")})
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.001291911!, 214.5242!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(2699.999!, 58.42003!)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "INCOME TAX COMPUTATION - YEAR OF ASSESSMENT "
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
        Me.lblTitle.LocationFloat = New DevExpress.Utils.PointFloat(0.001291911!, 272.9441!)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblTitle.SizeF = New System.Drawing.SizeF(2699.999!, 58.42001!)
        Me.lblTitle.StylePriority.UseBackColor = False
        Me.lblTitle.StylePriority.UseFont = False
        Me.lblTitle.Text = "DISPOSAL OF PROPERTY, PLANT AND EQUIPMENT / BALANCING CHARGE AND ALLOWANCES"
        '
        'paramTitle
        '
        Me.paramTitle.Description = "paramTitle"
        Me.paramTitle.Name = "paramTitle"
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramCompanyName, "Text", "NAME: {0}")})
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0.001291911!, 156.1042!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(2699.999!, 58.41998!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "XrLabel4"
        '
        'paramCompanyName
        '
        Me.paramCompanyName.Description = "paramCompanyName"
        Me.paramCompanyName.Name = "paramCompanyName"
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
        Me.groupHeaderBand1.RepeatEveryPage = True
        Me.groupHeaderBand1.StyleName = "ReportGroupHeaderBandStyle"
        '
        'table2
        '
        Me.table2.Dpi = 254.0!
        Me.table2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table2.Name = "table2"
        Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2})
        Me.table2.SizeF = New System.Drawing.SizeF(2660.0!, 64.0!)
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
        Me.tableCell12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tableCell12.Name = "tableCell12"
        Me.tableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 254.0!)
        Me.tableCell12.StylePriority.UseBackColor = False
        Me.tableCell12.StylePriority.UseFont = False
        Me.tableCell12.StylePriority.UsePadding = False
        Me.tableCell12.Weight = 0.70484402250124734R
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
        'detailBand1
        '
        Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table4})
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
        'table4
        '
        Me.table4.Dpi = 254.0!
        Me.table4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table4.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table4.Name = "table4"
        Me.table4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow4})
        Me.table4.SizeF = New System.Drawing.SizeF(2660.0!, 64.0!)
        Me.table4.StylePriority.UseFont = False
        '
        'tableRow4
        '
        Me.tableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell15, Me.tableCell16, Me.tableCell17, Me.tableCell18, Me.tableCell19, Me.tableCell20, Me.tableCell21, Me.tableCell22, Me.tableCell23, Me.tableCell24, Me.XrTableCell9})
        Me.tableRow4.Dpi = 254.0!
        Me.tableRow4.Name = "tableRow4"
        Me.tableRow4.Weight = 10.46953028649871R
        '
        'tableCell15
        '
        Me.tableCell15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.CA_ASSET")})
        Me.tableCell15.Dpi = 254.0!
        Me.tableCell15.Name = "tableCell15"
        Me.tableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 10, 0, 0, 254.0!)
        Me.tableCell15.StylePriority.UsePadding = False
        Me.tableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.tableCell15.Weight = 0.63587443560219459R
        Me.tableCell15.WordWrap = False
        '
        'tableCell16
        '
        Me.tableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.CA_PURCHASE_YEAR")})
        Me.tableCell16.Dpi = 254.0!
        Me.tableCell16.Name = "tableCell16"
        Me.tableCell16.StylePriority.UseTextAlignment = False
        Me.tableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell16.Weight = 0.21357084536641191R
        Me.tableCell16.WordWrap = False
        '
        'tableCell17
        '
        Me.tableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.CA_QUALIFYING_COST", "{0:#,# ;(#,#);0 }")})
        Me.tableCell17.Dpi = 254.0!
        Me.tableCell17.Name = "tableCell17"
        Me.tableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell17.Weight = 0.21061888349612426R
        Me.tableCell17.WordWrap = False
        '
        'tableCell18
        '
        Me.tableCell18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_DEPRECIATION", "{0:#,# ;(#,#);0 }")})
        Me.tableCell18.Dpi = 254.0!
        Me.tableCell18.Name = "tableCell18"
        Me.tableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell18.Weight = 0.28039114539513427R
        Me.tableCell18.WordWrap = False
        '
        'tableCell19
        '
        Me.tableCell19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_WDV", "{0:#,# ;(#,#);0 }")})
        Me.tableCell19.Dpi = 254.0!
        Me.tableCell19.Name = "tableCell19"
        Me.tableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell19.Weight = 0.20596196579072476R
        Me.tableCell19.WordWrap = False
        '
        'tableCell20
        '
        Me.tableCell20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_DISPOSAL_VALUE", "{0:#,# ;(#,#);0 }")})
        Me.tableCell20.Dpi = 254.0!
        Me.tableCell20.Name = "tableCell20"
        Me.tableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell20.Weight = 0.23122603943932862R
        Me.tableCell20.WordWrap = False
        '
        'tableCell21
        '
        Me.tableCell21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_PNL", "{0:#,# ;(#,#);0 }")})
        Me.tableCell21.Dpi = 254.0!
        Me.tableCell21.Name = "tableCell21"
        Me.tableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell21.Weight = 0.27243780349009306R
        Me.tableCell21.WordWrap = False
        '
        'tableCell22
        '
        Me.tableCell22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.CA_RATE_AA")})
        Me.tableCell22.Dpi = 254.0!
        Me.tableCell22.Name = "tableCell22"
        Me.tableCell22.StylePriority.UseTextAlignment = False
        Me.tableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell22.Weight = 0.22960382786157571R
        Me.tableCell22.WordWrap = False
        '
        'tableCell23
        '
        Me.tableCell23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_TWDV", "{0:#,# ;(#,#);0 }")})
        Me.tableCell23.Dpi = 254.0!
        Me.tableCell23.Name = "tableCell23"
        Me.tableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell23.Weight = 0.22243362112903903R
        Me.tableCell23.WordWrap = False
        '
        'tableCell24
        '
        Me.tableCell24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_BABC", "{0:#,# ;(#,#);0 }")})
        Me.tableCell24.Dpi = 254.0!
        Me.tableCell24.Name = "tableCell24"
        Me.tableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell24.Weight = 0.28332799129289266R
        Me.tableCell24.WordWrap = False
        '
        'XrTableCell9
        '
        Me.XrTableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.CA_NOTE_COLUMN")})
        Me.XrTableCell9.Dpi = 254.0!
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell9.Weight = 0.1773149188138293R
        '
        'groupFooterBand1
        '
        Me.groupFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.tblTotalCategory_line2_Bot, Me.tblTotalCategory_line2, Me.tblTotalCategory_line_Bot, Me.tblNote_Top, Me.tblTotalCategory_line, Me.tblTotalCategory})
        Me.groupFooterBand1.Dpi = 254.0!
        Me.groupFooterBand1.HeightF = 169.8333!
        Me.groupFooterBand1.KeepTogether = True
        Me.groupFooterBand1.Name = "groupFooterBand1"
        Me.groupFooterBand1.StyleName = "ReportGroupFooterBandStyle"
        '
        'tblTotalCategory_line2_Bot
        '
        Me.tblTotalCategory_line2_Bot.BackColor = System.Drawing.Color.Transparent
        Me.tblTotalCategory_line2_Bot.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.tblTotalCategory_line2_Bot.Dpi = 254.0!
        Me.tblTotalCategory_line2_Bot.LineWidth = 3
        Me.tblTotalCategory_line2_Bot.LocationFloat = New DevExpress.Utils.PointFloat(2046.727!, 89.87328!)
        Me.tblTotalCategory_line2_Bot.Name = "tblTotalCategory_line2_Bot"
        Me.tblTotalCategory_line2_Bot.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.tblTotalCategory_line2_Bot.SizeF = New System.Drawing.SizeF(454.08!, 16.46!)
        Me.tblTotalCategory_line2_Bot.StylePriority.UseBackColor = False
        Me.tblTotalCategory_line2_Bot.StylePriority.UseBorders = False
        Me.tblTotalCategory_line2_Bot.StylePriority.UsePadding = False
        '
        'tblTotalCategory_line2
        '
        Me.tblTotalCategory_line2.BackColor = System.Drawing.Color.Transparent
        Me.tblTotalCategory_line2.Dpi = 254.0!
        Me.tblTotalCategory_line2.LineWidth = 3
        Me.tblTotalCategory_line2.LocationFloat = New DevExpress.Utils.PointFloat(2046.726!, 0.0!)
        Me.tblTotalCategory_line2.Name = "tblTotalCategory_line2"
        Me.tblTotalCategory_line2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.tblTotalCategory_line2.SizeF = New System.Drawing.SizeF(454.0784!, 21.16667!)
        Me.tblTotalCategory_line2.StylePriority.UseBackColor = False
        Me.tblTotalCategory_line2.StylePriority.UsePadding = False
        '
        'tblTotalCategory_line_Bot
        '
        Me.tblTotalCategory_line_Bot.BackColor = System.Drawing.Color.Transparent
        Me.tblTotalCategory_line_Bot.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.tblTotalCategory_line_Bot.Dpi = 254.0!
        Me.tblTotalCategory_line_Bot.LineWidth = 3
        Me.tblTotalCategory_line_Bot.LocationFloat = New DevExpress.Utils.PointFloat(762.6413!, 89.87032!)
        Me.tblTotalCategory_line_Bot.Name = "tblTotalCategory_line_Bot"
        Me.tblTotalCategory_line_Bot.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.tblTotalCategory_line_Bot.SizeF = New System.Drawing.SizeF(1077.943!, 16.46297!)
        Me.tblTotalCategory_line_Bot.StylePriority.UseBackColor = False
        Me.tblTotalCategory_line_Bot.StylePriority.UseBorders = False
        Me.tblTotalCategory_line_Bot.StylePriority.UsePadding = False
        '
        'tblNote_Top
        '
        Me.tblNote_Top.BackColor = System.Drawing.Color.Transparent
        Me.tblNote_Top.Dpi = 254.0!
        Me.tblNote_Top.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblNote_Top.LocationFloat = New DevExpress.Utils.PointFloat(762.6406!, 106.3333!)
        Me.tblNote_Top.Name = "tblNote_Top"
        Me.tblNote_Top.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.tblNote_Top.SizeF = New System.Drawing.SizeF(1738.164!, 63.49999!)
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
        Me.XrTableCell18.CanShrink = True
        Me.XrTableCell18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.CA_QUALIFYING_COST")})
        Me.XrTableCell18.Dpi = 254.0!
        Me.XrTableCell18.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.StylePriority.UseFont = False
        Me.XrTableCell18.StylePriority.UseTextAlignment = False
        Me.XrTableCell18.Text = "XrTableCell10"
        Me.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell18.Weight = 0.076993418149212525R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.CanShrink = True
        Me.XrTableCell19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_DEPRECIATION")})
        Me.XrTableCell19.Dpi = 254.0!
        Me.XrTableCell19.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.StylePriority.UseFont = False
        Me.XrTableCell19.StylePriority.UseTextAlignment = False
        Me.XrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell19.Weight = 0.10249931184507705R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.CanShrink = True
        Me.XrTableCell20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_WDV")})
        Me.XrTableCell20.Dpi = 254.0!
        Me.XrTableCell20.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.StylePriority.UseFont = False
        Me.XrTableCell20.StylePriority.UseTextAlignment = False
        Me.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell20.Weight = 0.0752910707369284R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.CanShrink = True
        Me.XrTableCell21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_DISPOSAL_VALUE")})
        Me.XrTableCell21.Dpi = 254.0!
        Me.XrTableCell21.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.StylePriority.UseFont = False
        Me.XrTableCell21.StylePriority.UseTextAlignment = False
        Me.XrTableCell21.Text = "XrTableCell13"
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell21.Weight = 0.084526668065524488R
        '
        'XrTableCell22
        '
        Me.XrTableCell22.CanShrink = True
        Me.XrTableCell22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_PNL")})
        Me.XrTableCell22.Dpi = 254.0!
        Me.XrTableCell22.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.StylePriority.UseFont = False
        Me.XrTableCell22.StylePriority.UseTextAlignment = False
        Me.XrTableCell22.Text = "XrTableCell14"
        Me.XrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell22.Weight = 0.0995918143850276R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.CanShrink = True
        Me.XrTableCell23.Dpi = 254.0!
        Me.XrTableCell23.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.StylePriority.UseBackColor = False
        Me.XrTableCell23.StylePriority.UseFont = False
        Me.XrTableCell23.Weight = 0.083933760680237751R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.CanShrink = True
        Me.XrTableCell24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_TWDV")})
        Me.XrTableCell24.Dpi = 254.0!
        Me.XrTableCell24.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.StylePriority.UseFont = False
        Me.XrTableCell24.StylePriority.UseTextAlignment = False
        Me.XrTableCell24.Text = "XrTableCell15"
        Me.XrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell24.Weight = 0.081312478791740445R
        '
        'XrTableCell25
        '
        Me.XrTableCell25.CanShrink = True
        Me.XrTableCell25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_BABC")})
        Me.XrTableCell25.Dpi = 254.0!
        Me.XrTableCell25.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.StylePriority.UseFont = False
        Me.XrTableCell25.StylePriority.UseTextAlignment = False
        Me.XrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell25.Weight = 0.10357321132313538R
        '
        'tblTotalCategory_line
        '
        Me.tblTotalCategory_line.BackColor = System.Drawing.Color.Transparent
        Me.tblTotalCategory_line.Dpi = 254.0!
        Me.tblTotalCategory_line.LineWidth = 3
        Me.tblTotalCategory_line.LocationFloat = New DevExpress.Utils.PointFloat(762.6415!, 0.0!)
        Me.tblTotalCategory_line.Name = "tblTotalCategory_line"
        Me.tblTotalCategory_line.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.tblTotalCategory_line.SizeF = New System.Drawing.SizeF(1077.944!, 21.16667!)
        Me.tblTotalCategory_line.StylePriority.UseBackColor = False
        Me.tblTotalCategory_line.StylePriority.UsePadding = False
        '
        'tblTotalCategory
        '
        Me.tblTotalCategory.Dpi = 254.0!
        Me.tblTotalCategory.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblTotalCategory.LocationFloat = New DevExpress.Utils.PointFloat(762.6415!, 21.16663!)
        Me.tblTotalCategory.Name = "tblTotalCategory"
        Me.tblTotalCategory.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow5})
        Me.tblTotalCategory.SizeF = New System.Drawing.SizeF(1738.164!, 64.0!)
        Me.tblTotalCategory.StylePriority.UseFont = False
        '
        'tableRow5
        '
        Me.tableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell27, Me.tableCell28, Me.tableCell29, Me.tableCell30, Me.tableCell31, Me.tableCell32, Me.tableCell33, Me.tableCell34})
        Me.tableRow5.Dpi = 254.0!
        Me.tableRow5.Name = "tableRow5"
        Me.tableRow5.Weight = 10.46953028649871R
        '
        'tableCell27
        '
        Me.tableCell27.BackColor = System.Drawing.Color.Transparent
        Me.tableCell27.CanShrink = True
        Me.tableCell27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.CA_QUALIFYING_COST")})
        Me.tableCell27.Dpi = 254.0!
        Me.tableCell27.Name = "tableCell27"
        Me.tableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 5, 254.0!)
        Me.tableCell27.StylePriority.UseBackColor = False
        Me.tableCell27.StylePriority.UsePadding = False
        XrSummary1.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary1.IgnoreNullValues = True
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell27.Summary = XrSummary1
        Me.tableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell27.Weight = 0.16525452654308331R
        Me.tableCell27.WordWrap = False
        '
        'tableCell28
        '
        Me.tableCell28.BackColor = System.Drawing.Color.Transparent
        Me.tableCell28.CanShrink = True
        Me.tableCell28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_DEPRECIATION")})
        Me.tableCell28.Dpi = 254.0!
        Me.tableCell28.Name = "tableCell28"
        Me.tableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 5, 254.0!)
        Me.tableCell28.StylePriority.UseBackColor = False
        Me.tableCell28.StylePriority.UsePadding = False
        XrSummary2.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary2.IgnoreNullValues = True
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell28.Summary = XrSummary2
        Me.tableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell28.Weight = 0.21999900940050168R
        Me.tableCell28.WordWrap = False
        '
        'tableCell29
        '
        Me.tableCell29.BackColor = System.Drawing.Color.Transparent
        Me.tableCell29.CanShrink = True
        Me.tableCell29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_WDV")})
        Me.tableCell29.Dpi = 254.0!
        Me.tableCell29.Name = "tableCell29"
        Me.tableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 5, 254.0!)
        Me.tableCell29.StylePriority.UseBackColor = False
        Me.tableCell29.StylePriority.UsePadding = False
        XrSummary3.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary3.IgnoreNullValues = True
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell29.Summary = XrSummary3
        Me.tableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell29.Weight = 0.16160068561517843R
        Me.tableCell29.WordWrap = False
        '
        'tableCell30
        '
        Me.tableCell30.BackColor = System.Drawing.Color.Transparent
        Me.tableCell30.CanShrink = True
        Me.tableCell30.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_DISPOSAL_VALUE")})
        Me.tableCell30.Dpi = 254.0!
        Me.tableCell30.Name = "tableCell30"
        Me.tableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 5, 254.0!)
        Me.tableCell30.StylePriority.UseBackColor = False
        Me.tableCell30.StylePriority.UsePadding = False
        XrSummary4.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary4.IgnoreNullValues = True
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell30.Summary = XrSummary4
        Me.tableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell30.Weight = 0.18142358321639476R
        Me.tableCell30.WordWrap = False
        '
        'tableCell31
        '
        Me.tableCell31.BackColor = System.Drawing.Color.Transparent
        Me.tableCell31.CanShrink = True
        Me.tableCell31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_PNL")})
        Me.tableCell31.Dpi = 254.0!
        Me.tableCell31.Name = "tableCell31"
        Me.tableCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 5, 254.0!)
        Me.tableCell31.StylePriority.UseBackColor = False
        Me.tableCell31.StylePriority.UsePadding = False
        XrSummary5.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary5.IgnoreNullValues = True
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell31.Summary = XrSummary5
        Me.tableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell31.Weight = 0.21375852141126409R
        Me.tableCell31.WordWrap = False
        '
        'tableCell32
        '
        Me.tableCell32.BackColor = System.Drawing.Color.Transparent
        Me.tableCell32.CanShrink = True
        Me.tableCell32.Dpi = 254.0!
        Me.tableCell32.Name = "tableCell32"
        Me.tableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell32.StylePriority.UseBackColor = False
        Me.tableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell32.Weight = 0.18015079712017346R
        Me.tableCell32.WordWrap = False
        '
        'tableCell33
        '
        Me.tableCell33.BackColor = System.Drawing.Color.Transparent
        Me.tableCell33.CanShrink = True
        Me.tableCell33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_TWDV")})
        Me.tableCell33.Dpi = 254.0!
        Me.tableCell33.Name = "tableCell33"
        Me.tableCell33.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 5, 254.0!)
        Me.tableCell33.StylePriority.UseBackColor = False
        Me.tableCell33.StylePriority.UsePadding = False
        XrSummary6.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary6.IgnoreNullValues = True
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell33.Summary = XrSummary6
        Me.tableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell33.Weight = 0.17452429313491022R
        Me.tableCell33.WordWrap = False
        '
        'tableCell34
        '
        Me.tableCell34.BackColor = System.Drawing.Color.Transparent
        Me.tableCell34.CanShrink = True
        Me.tableCell34.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_BABC")})
        Me.tableCell34.Dpi = 254.0!
        Me.tableCell34.Name = "tableCell34"
        Me.tableCell34.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 5, 254.0!)
        Me.tableCell34.StylePriority.UseBackColor = False
        Me.tableCell34.StylePriority.UsePadding = False
        XrSummary7.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary7.IgnoreNullValues = True
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell34.Summary = XrSummary7
        Me.tableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell34.Weight = 0.22230442758688621R
        Me.tableCell34.WordWrap = False
        '
        'groupFooterBand2
        '
        Me.groupFooterBand2.Dpi = 254.0!
        Me.groupFooterBand2.HeightF = 0.4999695!
        Me.groupFooterBand2.Level = 1
        Me.groupFooterBand2.Name = "groupFooterBand2"
        Me.groupFooterBand2.StyleName = "ReportGroupFooterBandStyle"
        '
        'reportFooterBand1
        '
        Me.reportFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine4, Me.XrLine5, Me.XrLine1, Me.XrLine3, Me.XrTable1, Me.XrLabel6})
        Me.reportFooterBand1.Dpi = 254.0!
        Me.reportFooterBand1.HeightF = 114.151!
        Me.reportFooterBand1.Name = "reportFooterBand1"
        Me.reportFooterBand1.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand1})
        '
        'XrLine4
        '
        Me.XrLine4.BackColor = System.Drawing.Color.Transparent
        Me.XrLine4.Dpi = 254.0!
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(2046.726!, 85.1667!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.SizeF = New System.Drawing.SizeF(454.0793!, 5.0!)
        Me.XrLine4.StylePriority.UseBackColor = False
        '
        'XrLine5
        '
        Me.XrLine5.BackColor = System.Drawing.Color.Transparent
        Me.XrLine5.Dpi = 254.0!
        Me.XrLine5.LocationFloat = New DevExpress.Utils.PointFloat(2046.726!, 90.16666!)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.SizeF = New System.Drawing.SizeF(454.0793!, 13.60716!)
        Me.XrLine5.StylePriority.UseBackColor = False
        '
        'XrLine1
        '
        Me.XrLine1.BackColor = System.Drawing.Color.Transparent
        Me.XrLine1.Dpi = 254.0!
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(762.6415!, 90.16665!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(1077.944!, 13.60716!)
        Me.XrLine1.StylePriority.UseBackColor = False
        '
        'XrLine3
        '
        Me.XrLine3.BackColor = System.Drawing.Color.Transparent
        Me.XrLine3.Dpi = 254.0!
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(762.6415!, 85.16666!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(1077.944!, 5.0!)
        Me.XrLine3.StylePriority.UseBackColor = False
        '
        'XrTable1
        '
        Me.XrTable1.Dpi = 254.0!
        Me.XrTable1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(762.6415!, 21.16663!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(1738.164!, 64.0!)
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
        Me.XrTableCell1.CanShrink = True
        Me.XrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.CA_QUALIFYING_COST")})
        Me.XrTableCell1.Dpi = 254.0!
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 5, 254.0!)
        Me.XrTableCell1.StylePriority.UseBackColor = False
        Me.XrTableCell1.StylePriority.UsePadding = False
        XrSummary8.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary8.IgnoreNullValues = True
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell1.Summary = XrSummary8
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell1.Weight = 0.183673948819007R
        Me.XrTableCell1.WordWrap = False
        '
        'XrTableCell2
        '
        Me.XrTableCell2.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell2.CanShrink = True
        Me.XrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_DEPRECIATION")})
        Me.XrTableCell2.Dpi = 254.0!
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 5, 254.0!)
        Me.XrTableCell2.StylePriority.UseBackColor = False
        Me.XrTableCell2.StylePriority.UsePadding = False
        XrSummary9.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary9.IgnoreNullValues = True
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell2.Summary = XrSummary9
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell2.Weight = 0.24452057872459956R
        Me.XrTableCell2.WordWrap = False
        '
        'XrTableCell3
        '
        Me.XrTableCell3.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell3.CanShrink = True
        Me.XrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_WDV")})
        Me.XrTableCell3.Dpi = 254.0!
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 5, 254.0!)
        Me.XrTableCell3.StylePriority.UseBackColor = False
        Me.XrTableCell3.StylePriority.UsePadding = False
        XrSummary10.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary10.IgnoreNullValues = True
        XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell3.Summary = XrSummary10
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell3.Weight = 0.17961309873844775R
        Me.XrTableCell3.WordWrap = False
        '
        'XrTableCell4
        '
        Me.XrTableCell4.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell4.CanShrink = True
        Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_DISPOSAL_VALUE")})
        Me.XrTableCell4.Dpi = 254.0!
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 5, 254.0!)
        Me.XrTableCell4.StylePriority.UseBackColor = False
        Me.XrTableCell4.StylePriority.UsePadding = False
        XrSummary11.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary11.IgnoreNullValues = True
        XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell4.Summary = XrSummary11
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell4.Weight = 0.20164523969415477R
        Me.XrTableCell4.WordWrap = False
        '
        'XrTableCell5
        '
        Me.XrTableCell5.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell5.CanShrink = True
        Me.XrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_PNL")})
        Me.XrTableCell5.Dpi = 254.0!
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 5, 254.0!)
        Me.XrTableCell5.StylePriority.UseBackColor = False
        Me.XrTableCell5.StylePriority.UsePadding = False
        XrSummary12.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary12.IgnoreNullValues = True
        XrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell5.Summary = XrSummary12
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell5.Weight = 0.23758414002792685R
        Me.XrTableCell5.WordWrap = False
        '
        'XrTableCell6
        '
        Me.XrTableCell6.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell6.CanShrink = True
        Me.XrTableCell6.Dpi = 254.0!
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.XrTableCell6.StylePriority.UseBackColor = False
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell6.Weight = 0.20023108952038582R
        Me.XrTableCell6.WordWrap = False
        '
        'XrTableCell7
        '
        Me.XrTableCell7.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell7.CanShrink = True
        Me.XrTableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_TWDV")})
        Me.XrTableCell7.Dpi = 254.0!
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 5, 254.0!)
        Me.XrTableCell7.StylePriority.UseBackColor = False
        Me.XrTableCell7.StylePriority.UsePadding = False
        XrSummary13.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary13.IgnoreNullValues = True
        XrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell7.Summary = XrSummary13
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell7.Weight = 0.19397737888452016R
        Me.XrTableCell7.WordWrap = False
        '
        'XrTableCell8
        '
        Me.XrTableCell8.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell8.CanShrink = True
        Me.XrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_TEMP.DISP_BABC")})
        Me.XrTableCell8.Dpi = 254.0!
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 5, 254.0!)
        Me.XrTableCell8.StylePriority.UseBackColor = False
        Me.XrTableCell8.StylePriority.UsePadding = False
        XrSummary14.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary14.IgnoreNullValues = True
        XrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell8.Summary = XrSummary14
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell8.Weight = 0.2470826134648805R
        Me.XrTableCell8.WordWrap = False
        '
        'XrLabel6
        '
        Me.XrLabel6.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel6.CanShrink = True
        Me.XrLabel6.Dpi = 254.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 24.99993!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(367.7708!, 58.41999!)
        Me.XrLabel6.StylePriority.UseBackColor = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.Text = "TOTAL"
        '
        'SubBand1
        '
        Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.tblNote_Bot})
        Me.SubBand1.Dpi = 254.0!
        Me.SubBand1.HeightF = 63.5!
        Me.SubBand1.Name = "SubBand1"
        '
        'tblNote_Bot
        '
        Me.tblNote_Bot.BackColor = System.Drawing.Color.Transparent
        Me.tblNote_Bot.Dpi = 254.0!
        Me.tblNote_Bot.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblNote_Bot.LocationFloat = New DevExpress.Utils.PointFloat(762.6415!, 0.0!)
        Me.tblNote_Bot.Name = "tblNote_Bot"
        Me.tblNote_Bot.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.tblNote_Bot.SizeF = New System.Drawing.SizeF(1738.164!, 63.5!)
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
        Me.XrTableCell10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseFont = False
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        Me.XrTableCell10.Text = "XrTableCell10"
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell10.Weight = 0.076993457108706018R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_DEPRECIATION")})
        Me.XrTableCell11.Dpi = 254.0!
        Me.XrTableCell11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseFont = False
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell11.Weight = 0.1024993766751848R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_WDV")})
        Me.XrTableCell12.Dpi = 254.0!
        Me.XrTableCell12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StylePriority.UseFont = False
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell12.Weight = 0.075291080588691467R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_DISPOSAL_VALUE")})
        Me.XrTableCell13.Dpi = 254.0!
        Me.XrTableCell13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.StylePriority.UseFont = False
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        Me.XrTableCell13.Text = "XrTableCell13"
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell13.Weight = 0.084526680209417393R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_PNL")})
        Me.XrTableCell14.Dpi = 254.0!
        Me.XrTableCell14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.StylePriority.UseFont = False
        Me.XrTableCell14.StylePriority.UseTextAlignment = False
        Me.XrTableCell14.Text = "XrTableCell14"
        Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell14.Weight = 0.09959173726030289R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.Dpi = 254.0!
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.StylePriority.UseBackColor = False
        Me.XrTableCell17.Weight = 0.083933888261884179R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_TWDV")})
        Me.XrTableCell15.Dpi = 254.0!
        Me.XrTableCell15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.StylePriority.UseFont = False
        Me.XrTableCell15.StylePriority.UseTextAlignment = False
        Me.XrTableCell15.Text = "XrTableCell15"
        Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell15.Weight = 0.081312479603122545R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_DISPOSAL_NOTE.DISP_BABC")})
        Me.XrTableCell16.Dpi = 254.0!
        Me.XrTableCell16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.StylePriority.UseFont = False
        Me.XrTableCell16.StylePriority.UseTextAlignment = False
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell16.Weight = 0.10357329322016035R
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
        Me.bottomMarginBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
        Me.bottomMarginBand1.Dpi = 254.0!
        Me.bottomMarginBand1.HeightF = 81.64586!
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
        'PageFooter
        '
        Me.PageFooter.Dpi = 254.0!
        Me.PageFooter.HeightF = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.XrLabel5, Me.XrLabel2, Me.lblTitle, Me.lblDraft_Report})
        Me.ReportHeader.Dpi = 254.0!
        Me.ReportHeader.HeightF = 365.76!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'param_ShowDraft
        '
        Me.param_ShowDraft.Description = "param_ShowDraft"
        Me.param_ShowDraft.Name = "param_ShowDraft"
        Me.param_ShowDraft.Type = GetType(Boolean)
        Me.param_ShowDraft.ValueInfo = "False"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrPageInfo1.Dpi = 254.0!
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrPageInfo1.Format = "Page {0} / {1}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(2246.807!, 2.645859!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(254.0002!, 58.42!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'rpt_Disposal
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.topMarginBand1, Me.pageHeaderBand1, Me.groupHeaderBand1, Me.groupHeaderBand2, Me.detailBand1, Me.groupFooterBand1, Me.groupFooterBand2, Me.reportFooterBand1, Me.bottomMarginBand1, Me.PageFooter, Me.ReportHeader})
        Me.DataMember = "CA_REPORT_DISPOSAL_TEMP"
        Me.DataSource = Me.DsCA
        Me.Dpi = 254.0!
        Me.FilterString = "[Type] = 0"
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.ShowDraft})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(196, 74, 74, 82)
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
        CType(Me.tblNote_Top, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblTotalCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblNote_Bot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAREPORTDISPOSALTEMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private Sub tblTotalCategory_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles tblTotalCategory.BeforePrint, groupFooterBand1.BeforePrint
        Try
            Dim CA_CATEGORY_CODE As String = Me.GetCurrentColumnValue("CA_CATEGORY_CODE")
            Dim CA_TRANSFERROR_NAME As String = Me.GetCurrentColumnValue("CA_TRANSFERROR_NAME")
            Dim ID As String = Me.GetCurrentColumnValue("ID")
            Dim YA As String = Me.GetCurrentColumnValue("YA")
            Dim Count As Integer = ADO.Load_CAReport_CA_REPORT_DISPOSAL_TEMP_CountByCATEGORY(ID, YA, CA_CATEGORY_CODE, CA_TRANSFERROR_NAME, Nothing)

            If Count <= 1 Then
                tblTotalCategory.Visible = False

                tblTotalCategory_line.Visible = True

                tblTotalCategory_line.Borders = DevExpress.XtraPrinting.BorderSide.Top
                tblTotalCategory_line.BorderWidth = 1
                tblTotalCategory_line2.Borders = DevExpress.XtraPrinting.BorderSide.Top
                tblTotalCategory_line2.BorderWidth = 1

                tblTotalCategory_line_Bot.Visible = False
                tblTotalCategory_line2_Bot.Visible = False
                tblTotalCategory_line_Bot.HeightF = 0
                tblTotalCategory_line2_Bot.HeightF = 0
                tblTotalCategory.HeightF = 0

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

                tblTotalCategory.HeightF = 64

                tblTotalCategory_line_Bot.HeightF = 21
                tblTotalCategory_line2_Bot.HeightF = 21

                'tblTotalCategory_line.Visible = False
                'tblTotalCategory_line2.Visible = False

                tblNote_Bot.Visible = True
                tblNote_Top.Visible = False
                tblNote_Top.HeightF = 5
                groupFooterBand1.HeightF = 169.8333
            End If

            If Me.Report.RowCount > 1 Then

            Else

            End If
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
    Private Sub reportFooterBand1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles reportFooterBand1.BeforePrint
        Try
            If Me.Report.RowCount = 1 Then
                reportFooterBand1.Visible = False
            Else
                reportFooterBand1.Visible = True
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
End Class
