Public Class rpt_CP204_Breakdown
	Inherits DevExpress.XtraReports.UI.XtraReport
    Friend WithEvents DsCP204 As EasyTemplate_Taxcom.dsCP204
    Private components As System.ComponentModel.IContainer
    Friend WithEvents BORANGCP204TRICORBREAKDOWNBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportEvenStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportOddStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportFooterBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportGroupFooterBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportDetailBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportGroupHeaderBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportHeaderBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents tableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents reportFooterBand1 As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents tableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtDate2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtDate1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents detailBand1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents tableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents pageHeaderBand1 As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents lblTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paramYA As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paramCompanyName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents paramSch As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents param_ShowDraft As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ShowDraft As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLine6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents paramTitle As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.pageHeaderBand1 = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ShowDraft = New DevExpress.XtraReports.UI.FormattingRule()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramSch = New DevExpress.XtraReports.Parameters.Parameter()
        Me.lblTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramTitle = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramCompanyName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.table1 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramYA = New DevExpress.XtraReports.Parameters.Parameter()
        Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.table2 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtDate1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtDate2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.reportFooterBand1 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLine6 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.table3 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeaderBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportGroupHeaderBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportDetailBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportGroupFooterBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportFooterBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportOddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportEvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.BORANGCP204TRICORBREAKDOWNBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCP204 = New EasyTemplate_Taxcom.dsCP204()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.param_ShowDraft = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BORANGCP204TRICORBREAKDOWNBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCP204, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel45, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLabel3, Me.lblTitle, Me.XrLabel1, Me.table1, Me.XrLabel4})
        Me.pageHeaderBand1.Dpi = 254.0!
        Me.pageHeaderBand1.HeightF = 586.1876!
        Me.pageHeaderBand1.Name = "pageHeaderBand1"
        Me.pageHeaderBand1.StyleName = "ReportHeaderBandStyle"
        '
        'XrLabel45
        '
        Me.XrLabel45.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel45.CanShrink = True
        Me.XrLabel45.Dpi = 254.0!
        Me.XrLabel45.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel45.FormattingRules.Add(Me.ShowDraft)
        Me.XrLabel45.LocationFloat = New DevExpress.Utils.PointFloat(1519.855!, 0.0!)
        Me.XrLabel45.Name = "XrLabel45"
        Me.XrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel45.SizeF = New System.Drawing.SizeF(320.1453!, 58.42!)
        Me.XrLabel45.StylePriority.UseBackColor = False
        Me.XrLabel45.StylePriority.UseFont = False
        Me.XrLabel45.StylePriority.UseTextAlignment = False
        Me.XrLabel45.Text = "DRAFT"
        Me.XrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel45.Visible = False
        '
        'ShowDraft
        '
        Me.ShowDraft.Condition = "[Parameters.param_ShowDraft]=true"
        Me.ShowDraft.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.ShowDraft.Name = "ShowDraft"
        '
        'XrLabel7
        '
        Me.XrLabel7.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel7.Dpi = 254.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(1114.473!, 496.3292!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(362.6907!, 46.43744!)
        Me.XrLabel7.StylePriority.UseBackColor = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel6.Dpi = 254.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(455.7125!, 496.3292!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(201.2909!, 46.43744!)
        Me.XrLabel6.StylePriority.UseBackColor = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "RM"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(913.1826!, 496.3292!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(201.2899!, 46.4375!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "RM"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramSch, "Text", "")})
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(864.2168!, 107.0208!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(975.7833!, 58.42!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "XrLabel3"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'paramSch
        '
        Me.paramSch.Description = "paramSch"
        Me.paramSch.Name = "paramSch"
        Me.paramSch.ValueInfo = "APPENDIX"
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramTitle, "Text", "")})
        Me.lblTitle.Dpi = 254.0!
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.LocationFloat = New DevExpress.Utils.PointFloat(0.004440943!, 273.3908!)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblTitle.SizeF = New System.Drawing.SizeF(1839.996!, 48.82877!)
        Me.lblTitle.StylePriority.UseBackColor = False
        Me.lblTitle.StylePriority.UseFont = False
        Me.lblTitle.StylePriority.UseTextAlignment = False
        Me.lblTitle.Text = "lblTitle"
        Me.lblTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'paramTitle
        '
        Me.paramTitle.Description = "paramTitle"
        Me.paramTitle.Name = "paramTitle"
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramCompanyName, "Text", "{0}")})
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 221.5854!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(1840.0!, 51.80544!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'paramCompanyName
        '
        Me.paramCompanyName.Description = "paramCompanyName"
        Me.paramCompanyName.Name = "paramCompanyName"
        '
        'table1
        '
        Me.table1.Dpi = 254.0!
        Me.table1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 381.5292!)
        Me.table1.Name = "table1"
        Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
        Me.table1.SizeF = New System.Drawing.SizeF(1840.0!, 114.8!)
        Me.table1.StylePriority.UseFont = False
        '
        'tableRow1
        '
        Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2, Me.tableCell3, Me.tableCell4, Me.tableCell5, Me.XrTableCell3, Me.tableCell8, Me.XrTableCell1})
        Me.tableRow1.Dpi = 254.0!
        Me.tableRow1.Name = "tableRow1"
        Me.tableRow1.Weight = 10.46953028649871R
        '
        'tableCell1
        '
        Me.tableCell1.BackColor = System.Drawing.Color.Transparent
        Me.tableCell1.Dpi = 254.0!
        Me.tableCell1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tableCell1.Name = "tableCell1"
        Me.tableCell1.StylePriority.UseBackColor = False
        Me.tableCell1.StylePriority.UseFont = False
        Me.tableCell1.StylePriority.UseTextAlignment = False
        Me.tableCell1.Text = "Instalment No."
        Me.tableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell1.Weight = 0.12963401066813446R
        '
        'tableCell2
        '
        Me.tableCell2.BackColor = System.Drawing.Color.Transparent
        Me.tableCell2.Dpi = 254.0!
        Me.tableCell2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tableCell2.Name = "tableCell2"
        Me.tableCell2.StylePriority.UseBackColor = False
        Me.tableCell2.StylePriority.UseFont = False
        Me.tableCell2.StylePriority.UseTextAlignment = False
        Me.tableCell2.Text = "Payment Due"
        Me.tableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell2.Weight = 0.15878347589792444R
        '
        'tableCell3
        '
        Me.tableCell3.BackColor = System.Drawing.Color.Transparent
        Me.tableCell3.Dpi = 254.0!
        Me.tableCell3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tableCell3.Multiline = True
        Me.tableCell3.Name = "tableCell3"
        Me.tableCell3.StylePriority.UseBackColor = False
        Me.tableCell3.StylePriority.UseFont = False
        Me.tableCell3.StylePriority.UseTextAlignment = False
        Me.tableCell3.Text = "Amount"
        Me.tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell3.Weight = 0.12739564864435146R
        '
        'tableCell4
        '
        Me.tableCell4.BackColor = System.Drawing.Color.Transparent
        Me.tableCell4.Dpi = 254.0!
        Me.tableCell4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tableCell4.Name = "tableCell4"
        Me.tableCell4.StylePriority.UseBackColor = False
        Me.tableCell4.StylePriority.UseFont = False
        Me.tableCell4.StylePriority.UseTextAlignment = False
        Me.tableCell4.Text = "Payment Date"
        Me.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell4.Weight = 0.16213407791180662R
        '
        'tableCell5
        '
        Me.tableCell5.BackColor = System.Drawing.Color.Transparent
        Me.tableCell5.Dpi = 254.0!
        Me.tableCell5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tableCell5.Multiline = True
        Me.tableCell5.Name = "tableCell5"
        Me.tableCell5.StylePriority.UseBackColor = False
        Me.tableCell5.StylePriority.UseFont = False
        Me.tableCell5.StylePriority.UseTextAlignment = False
        Me.tableCell5.Text = "Amount Paid"
        Me.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell5.Weight = 0.12739511545342791R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell3.Dpi = 254.0!
        Me.XrTableCell3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseBackColor = False
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "Remarks"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell3.Weight = 0.22954454940851582R
        '
        'tableCell8
        '
        Me.tableCell8.BackColor = System.Drawing.Color.Transparent
        Me.tableCell8.Dpi = 254.0!
        Me.tableCell8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tableCell8.Multiline = True
        Me.tableCell8.Name = "tableCell8"
        Me.tableCell8.StylePriority.UseBackColor = False
        Me.tableCell8.StylePriority.UseFont = False
        Me.tableCell8.StylePriority.UseTextAlignment = False
        Me.tableCell8.Text = "Penalty"
        Me.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell8.Weight = 0.10730394886085004R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell1.Dpi = 254.0!
        Me.XrTableCell1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBackColor = False
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell1.Weight = 0.12233312324380802R
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(1477.163!, 496.3292!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(169.5454!, 46.4375!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "RM"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'paramYA
        '
        Me.paramYA.Description = "paramYA"
        Me.paramYA.Name = "paramYA"
        Me.paramYA.Type = GetType(Integer)
        Me.paramYA.ValueInfo = "0"
        '
        'detailBand1
        '
        Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2})
        Me.detailBand1.Dpi = 254.0!
        Me.detailBand1.EvenStyleName = "ReportEvenStyle"
        Me.detailBand1.HeightF = 64.0!
        Me.detailBand1.Name = "detailBand1"
        Me.detailBand1.OddStyleName = "ReportOddStyle"
        Me.detailBand1.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CP_INSTALL_NO", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.detailBand1.StyleName = "ReportDetailBandStyle"
        '
        'table2
        '
        Me.table2.Dpi = 254.0!
        Me.table2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table2.Name = "table2"
        Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2})
        Me.table2.SizeF = New System.Drawing.SizeF(1840.0!, 64.0!)
        Me.table2.StylePriority.UseFont = False
        '
        'tableRow2
        '
        Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell11, Me.txtDate1, Me.tableCell13, Me.txtDate2, Me.tableCell15, Me.XrTableCell4, Me.tableCell18, Me.XrTableCell2})
        Me.tableRow2.Dpi = 254.0!
        Me.tableRow2.Name = "tableRow2"
        Me.tableRow2.Weight = 10.46953028649871R
        '
        'tableCell11
        '
        Me.tableCell11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "BORANG_CP204_TRICOR_BREAKDOWN_REPORT.CP_INSTALL_NO", "{0:00}")})
        Me.tableCell11.Dpi = 254.0!
        Me.tableCell11.Name = "tableCell11"
        Me.tableCell11.StylePriority.UseTextAlignment = False
        Me.tableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell11.Weight = 0.13139533484091251R
        Me.tableCell11.WordWrap = False
        '
        'txtDate1
        '
        Me.txtDate1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "BORANG_CP204_TRICOR_BREAKDOWN_REPORT.CP_PAYMENT_DUE", "{0:dd.MM.yyyy}")})
        Me.txtDate1.Dpi = 254.0!
        Me.txtDate1.Name = "txtDate1"
        Me.txtDate1.StylePriority.UseTextAlignment = False
        Me.txtDate1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtDate1.Weight = 0.16094084968413314R
        Me.txtDate1.WordWrap = False
        '
        'tableCell13
        '
        Me.tableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "BORANG_CP204_TRICOR_BREAKDOWN_REPORT.CP_INSTALLMENT_AMOUNT", "{0:n2}")})
        Me.tableCell13.Dpi = 254.0!
        Me.tableCell13.Name = "tableCell13"
        Me.tableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell13.Weight = 0.1291265791018669R
        Me.tableCell13.WordWrap = False
        '
        'txtDate2
        '
        Me.txtDate2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "BORANG_CP204_TRICOR_BREAKDOWN_REPORT.CP_PAYMENT_DATE_1", "{0:dd.MM.yyyy}")})
        Me.txtDate2.Dpi = 254.0!
        Me.txtDate2.Name = "txtDate2"
        Me.txtDate2.StylePriority.UseTextAlignment = False
        Me.txtDate2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtDate2.Weight = 0.16433695746121008R
        Me.txtDate2.WordWrap = False
        '
        'tableCell15
        '
        Me.tableCell15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "BORANG_CP204_TRICOR_BREAKDOWN_REPORT.CP_AMOUNT_PAID_1", "{0:n2}")})
        Me.tableCell15.Dpi = 254.0!
        Me.tableCell15.Name = "tableCell15"
        Me.tableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell15.Weight = 0.12912604676406725R
        Me.tableCell15.WordWrap = False
        '
        'XrTableCell4
        '
        Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "BORANG_CP204_TRICOR_BREAKDOWN_REPORT.CP_NOTE")})
        Me.XrTableCell4.Dpi = 254.0!
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell4.Weight = 0.23266333674778675R
        '
        'tableCell18
        '
        Me.tableCell18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "BORANG_CP204_TRICOR_BREAKDOWN_REPORT.CP_PENALTY", "{0:n2}")})
        Me.tableCell18.Dpi = 254.0!
        Me.tableCell18.Name = "tableCell18"
        Me.tableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell18.Weight = 0.10876187650090288R
        Me.tableCell18.WordWrap = False
        '
        'XrTableCell2
        '
        Me.XrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "BORANG_CP204_TRICOR_BREAKDOWN_REPORT.CP_NOTE_TITLE")})
        Me.XrTableCell2.Dpi = 254.0!
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.Text = "XrTableCell2"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell2.Weight = 0.12399527928968115R
        '
        'reportFooterBand1
        '
        Me.reportFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine6, Me.XrLine5, Me.XrLine4, Me.XrLine3, Me.XrLine2, Me.XrLine1, Me.table3})
        Me.reportFooterBand1.Dpi = 254.0!
        Me.reportFooterBand1.HeightF = 287.3084!
        Me.reportFooterBand1.Name = "reportFooterBand1"
        Me.reportFooterBand1.StyleName = "ReportFooterBandStyle"
        '
        'XrLine6
        '
        Me.XrLine6.BackColor = System.Drawing.Color.Transparent
        Me.XrLine6.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLine6.Dpi = 254.0!
        Me.XrLine6.LocationFloat = New DevExpress.Utils.PointFloat(1477.163!, 108.45!)
        Me.XrLine6.Name = "XrLine6"
        Me.XrLine6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLine6.SizeF = New System.Drawing.SizeF(169.545!, 23.81249!)
        Me.XrLine6.StylePriority.UseBackColor = False
        Me.XrLine6.StylePriority.UseBorders = False
        Me.XrLine6.StylePriority.UsePadding = False
        '
        'XrLine5
        '
        Me.XrLine5.BackColor = System.Drawing.Color.Transparent
        Me.XrLine5.Dpi = 254.0!
        Me.XrLine5.LineWidth = 3
        Me.XrLine5.LocationFloat = New DevExpress.Utils.PointFloat(1477.163!, 33.86671!)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLine5.SizeF = New System.Drawing.SizeF(169.545!, 10.58333!)
        Me.XrLine5.StylePriority.UseBackColor = False
        Me.XrLine5.StylePriority.UsePadding = False
        '
        'XrLine4
        '
        Me.XrLine4.BackColor = System.Drawing.Color.Transparent
        Me.XrLine4.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLine4.Dpi = 254.0!
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(913.1826!, 108.4499!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLine4.SizeF = New System.Drawing.SizeF(201.2899!, 23.81249!)
        Me.XrLine4.StylePriority.UseBackColor = False
        Me.XrLine4.StylePriority.UseBorders = False
        Me.XrLine4.StylePriority.UsePadding = False
        '
        'XrLine3
        '
        Me.XrLine3.BackColor = System.Drawing.Color.Transparent
        Me.XrLine3.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLine3.Dpi = 254.0!
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(455.7126!, 108.45!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLine3.SizeF = New System.Drawing.SizeF(201.2909!, 23.81249!)
        Me.XrLine3.StylePriority.UseBackColor = False
        Me.XrLine3.StylePriority.UseBorders = False
        Me.XrLine3.StylePriority.UsePadding = False
        '
        'XrLine2
        '
        Me.XrLine2.BackColor = System.Drawing.Color.Transparent
        Me.XrLine2.Dpi = 254.0!
        Me.XrLine2.LineWidth = 3
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(455.7126!, 33.86671!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLine2.SizeF = New System.Drawing.SizeF(201.2909!, 10.58333!)
        Me.XrLine2.StylePriority.UseBackColor = False
        Me.XrLine2.StylePriority.UsePadding = False
        '
        'XrLine1
        '
        Me.XrLine1.BackColor = System.Drawing.Color.Transparent
        Me.XrLine1.Dpi = 254.0!
        Me.XrLine1.LineWidth = 3
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(913.1826!, 33.86671!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLine1.SizeF = New System.Drawing.SizeF(201.2899!, 10.58333!)
        Me.XrLine1.StylePriority.UseBackColor = False
        Me.XrLine1.StylePriority.UsePadding = False
        '
        'table3
        '
        Me.table3.Dpi = 254.0!
        Me.table3.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.table3.LocationFloat = New DevExpress.Utils.PointFloat(0.004394531!, 44.45004!)
        Me.table3.Name = "table3"
        Me.table3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow3})
        Me.table3.SizeF = New System.Drawing.SizeF(1646.704!, 64.0!)
        Me.table3.StylePriority.UseFont = False
        Me.table3.StylePriority.UsePadding = False
        '
        'tableRow3
        '
        Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell21, Me.tableCell22, Me.tableCell23, Me.tableCell24, Me.tableCell25, Me.XrTableCell5, Me.tableCell28})
        Me.tableRow3.Dpi = 254.0!
        Me.tableRow3.Name = "tableRow3"
        Me.tableRow3.Weight = 10.46953028649871R
        '
        'tableCell21
        '
        Me.tableCell21.BackColor = System.Drawing.Color.Transparent
        Me.tableCell21.Dpi = 254.0!
        Me.tableCell21.Name = "tableCell21"
        Me.tableCell21.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell21.StylePriority.UseBackColor = False
        Me.tableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell21.Weight = 0.12963117476441094R
        Me.tableCell21.WordWrap = False
        '
        'tableCell22
        '
        Me.tableCell22.BackColor = System.Drawing.Color.Transparent
        Me.tableCell22.Dpi = 254.0!
        Me.tableCell22.Name = "tableCell22"
        Me.tableCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell22.StylePriority.UseBackColor = False
        Me.tableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell22.Weight = 0.15878338598291969R
        Me.tableCell22.WordWrap = False
        '
        'tableCell23
        '
        Me.tableCell23.BackColor = System.Drawing.Color.Transparent
        Me.tableCell23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "BORANG_CP204_TRICOR_BREAKDOWN_REPORT.CP_INSTALLMENT_AMOUNT")})
        Me.tableCell23.Dpi = 254.0!
        Me.tableCell23.Name = "tableCell23"
        Me.tableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell23.StylePriority.UseBackColor = False
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.IgnoreNullValues = True
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell23.Summary = XrSummary1
        Me.tableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell23.Weight = 0.12739557960751491R
        Me.tableCell23.WordWrap = False
        '
        'tableCell24
        '
        Me.tableCell24.BackColor = System.Drawing.Color.Transparent
        Me.tableCell24.Dpi = 254.0!
        Me.tableCell24.Name = "tableCell24"
        Me.tableCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell24.StylePriority.UseBackColor = False
        Me.tableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell24.Weight = 0.16213398863658302R
        Me.tableCell24.WordWrap = False
        '
        'tableCell25
        '
        Me.tableCell25.BackColor = System.Drawing.Color.Transparent
        Me.tableCell25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "BORANG_CP204_TRICOR_BREAKDOWN_REPORT.CP_AMOUNT_PAID_1")})
        Me.tableCell25.Dpi = 254.0!
        Me.tableCell25.Name = "tableCell25"
        Me.tableCell25.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell25.StylePriority.UseBackColor = False
        XrSummary2.FormatString = "{0:n2}"
        XrSummary2.IgnoreNullValues = True
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell25.Summary = XrSummary2
        Me.tableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell25.Weight = 0.12739489594265527R
        Me.tableCell25.WordWrap = False
        '
        'XrTableCell5
        '
        Me.XrTableCell5.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell5.Dpi = 254.0!
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        Me.XrTableCell5.StylePriority.UseBackColor = False
        Me.XrTableCell5.StylePriority.UsePadding = False
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell5.Weight = 0.22954437447535106R
        '
        'tableCell28
        '
        Me.tableCell28.BackColor = System.Drawing.Color.Transparent
        Me.tableCell28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "BORANG_CP204_TRICOR_BREAKDOWN_REPORT.CP_PENALTY")})
        Me.tableCell28.Dpi = 254.0!
        Me.tableCell28.Name = "tableCell28"
        Me.tableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell28.StylePriority.UseBackColor = False
        XrSummary3.FormatString = "{0:n2}"
        XrSummary3.IgnoreNullValues = True
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell28.Summary = XrSummary3
        Me.tableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell28.Weight = 0.1073039098126962R
        Me.tableCell28.WordWrap = False
        '
        'bottomMarginBand1
        '
        Me.bottomMarginBand1.Dpi = 254.0!
        Me.bottomMarginBand1.HeightF = 100.0!
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
        'BORANGCP204TRICORBREAKDOWNBindingSource
        '
        Me.BORANGCP204TRICORBREAKDOWNBindingSource.DataMember = "BORANG_CP204_TRICOR_BREAKDOWN"
        Me.BORANGCP204TRICORBREAKDOWNBindingSource.DataSource = Me.DsCP204
        '
        'DsCP204
        '
        Me.DsCP204.DataSetName = "dsCP204"
        Me.DsCP204.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportHeader
        '
        Me.ReportHeader.Dpi = 254.0!
        Me.ReportHeader.HeightF = 0.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'param_ShowDraft
        '
        Me.param_ShowDraft.Description = "param_ShowDraft"
        Me.param_ShowDraft.Name = "param_ShowDraft"
        Me.param_ShowDraft.Type = GetType(Boolean)
        Me.param_ShowDraft.ValueInfo = "False"
        '
        'rpt_CP204_Breakdown
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.topMarginBand1, Me.pageHeaderBand1, Me.detailBand1, Me.reportFooterBand1, Me.bottomMarginBand1, Me.ReportHeader})
        Me.DataMember = "BORANG_CP204_TRICOR_BREAKDOWN_REPORT"
        Me.DataSource = Me.DsCP204
        Me.Dpi = 254.0!
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.ShowDraft})
        Me.Margins = New System.Drawing.Printing.Margins(190, 69, 100, 100)
        Me.PageHeight = 2970
        Me.PageWidth = 2100
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.paramCompanyName, Me.paramYA, Me.paramSch, Me.param_ShowDraft, Me.paramTitle})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.RequestParameters = False
        Me.SnapGridSize = 25.0!
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.ReportHeaderBandStyle, Me.ReportGroupHeaderBandStyle, Me.ReportDetailBandStyle, Me.ReportGroupFooterBandStyle, Me.ReportFooterBandStyle, Me.ReportOddStyle, Me.ReportEvenStyle})
        Me.Version = "17.1"
        CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BORANGCP204TRICORBREAKDOWNBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCP204, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Private Sub txtDate1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtDate1.BeforePrint
        Try
            Dim datex As Object = Me.GetCurrentColumnValue("CP_PAYMENT_DUE")

            If datex IsNot Nothing AndAlso IsDate(datex) Then
                txtDate1.Text = Format(CDate(datex), "dd.MM.yyyy")
            Else
                txtDate1.Text = ""
            End If


        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub txtDate2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles txtDate2.BeforePrint
        Try
            Dim datex As Object = Me.GetCurrentColumnValue("CP_PAYMENT_DATE_1")

            If datex IsNot Nothing AndAlso IsDate(datex) Then
                txtDate2.Text = Format(CDate(datex), "dd.MM.yyyy")
            Else
                txtDate2.Text = ""
            End If


        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Dim CurrInstall As Integer = 0
    Private Sub tableCell11_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles tableCell11.BeforePrint
        Try
            Dim TmpInstallment As Object = Me.GetCurrentColumnValue("CP_INSTALL_NO")

            If TmpInstallment IsNot Nothing AndAlso IsNumeric(TmpInstallment) Then
                If CurrInstall <> TmpInstallment Then
                    CurrInstall = TmpInstallment
                Else
                    tableCell11.Text = ""
                End If
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub lblTitle_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTitle.BeforePrint
        Try
            lblTitle.Text = lblTitle.Text & " for the Year of Assessment " & paramYA.Value.ToString
        Catch ex As Exception

        End Try
    End Sub
End Class
