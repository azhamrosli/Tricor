Public Class rpt_DeemedInterest
	Inherits DevExpress.XtraReports.UI.XtraReport
    Friend WithEvents DsTaxcomputation As EasyTemplate_Taxcom.dsTaxcomputation
    Private components As System.ComponentModel.IContainer
    Friend WithEvents DEEMEDINTERESTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportEvenStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportOddStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportFooterBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportGroupFooterBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportDetailBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportGroupHeaderBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportHeaderBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents tableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents reportFooterBand1 As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents tableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents detailBand1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents tableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents pageHeaderBand1 As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblExp As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ShowDraft As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents param_ShowDraft As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents paramSch As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paramTitle As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.pageHeaderBand1 = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ShowDraft = New DevExpress.XtraReports.UI.FormattingRule()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramSch = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.table1 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramTitle = New DevExpress.XtraReports.Parameters.Parameter()
        Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.table2 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblExp = New DevExpress.XtraReports.UI.XRLabel()
        Me.reportFooterBand1 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.table3 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeaderBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportGroupHeaderBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportDetailBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportGroupFooterBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportFooterBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportOddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportEvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DEEMEDINTERESTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTaxcomputation = New EasyTemplate_Taxcom.dsTaxcomputation()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.param_ShowDraft = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEEMEDINTERESTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTaxcomputation, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel45, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel6, Me.table1, Me.XrLabel1})
        Me.pageHeaderBand1.Dpi = 254.0!
        Me.pageHeaderBand1.HeightF = 426.3235!
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
        Me.XrLabel45.LocationFloat = New DevExpress.Utils.PointFloat(1403.855!, 0.0!)
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
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.White
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramSch, "Text", "")})
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(828.7745!, 83.20834!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(895.2255!, 58.42!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'paramSch
        '
        Me.paramSch.Description = "paramSch"
        Me.paramSch.Name = "paramSch"
        Me.paramSch.ValueInfo = "Schedule"
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(293.9627!, 357.5318!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(331.0041!, 67.60416!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "RM"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(624.967!, 357.5318!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(283.379!, 67.60419!)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "%"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel6.Dpi = 254.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(908.3457!, 357.5318!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(239.9467!, 67.60416!)
        Me.XrLabel6.StylePriority.UseBackColor = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "RM"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'table1
        '
        Me.table1.BackColor = System.Drawing.Color.Transparent
        Me.table1.Dpi = 254.0!
        Me.table1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 264.4277!)
        Me.table1.Name = "table1"
        Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
        Me.table1.SizeF = New System.Drawing.SizeF(1148.292!, 93.10418!)
        Me.table1.StylePriority.UseBackColor = False
        Me.table1.StylePriority.UseFont = False
        Me.table1.StylePriority.UseTextAlignment = False
        Me.table1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'tableRow1
        '
        Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2, Me.tableCell3, Me.tableCell4})
        Me.tableRow1.Dpi = 254.0!
        Me.tableRow1.Name = "tableRow1"
        Me.tableRow1.Weight = 10.46953028649871R
        '
        'tableCell1
        '
        Me.tableCell1.Dpi = 254.0!
        Me.tableCell1.Name = "tableCell1"
        Me.tableCell1.StylePriority.UseTextAlignment = False
        Me.tableCell1.Text = "Month"
        Me.tableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        Me.tableCell1.Weight = 0.37909461939897093R
        '
        'tableCell2
        '
        Me.tableCell2.Dpi = 254.0!
        Me.tableCell2.Multiline = True
        Me.tableCell2.Name = "tableCell2"
        Me.tableCell2.Text = "Balance as at Month End" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.tableCell2.Weight = 0.42686349058890993R
        '
        'tableCell3
        '
        Me.tableCell3.Dpi = 254.0!
        Me.tableCell3.Multiline = True
        Me.tableCell3.Name = "tableCell3"
        Me.tableCell3.Text = "Average Lending Rate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.tableCell3.Weight = 0.36544604439891881R
        '
        'tableCell4
        '
        Me.tableCell4.Dpi = 254.0!
        Me.tableCell4.Multiline = True
        Me.tableCell4.Name = "tableCell4"
        Me.tableCell4.Text = "Amount" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.tableCell4.Weight = 0.30943565672469975R
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramTitle, "Text", "")})
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 158.4886!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(1724.0!, 58.42!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "Computation of Deemed Interest Income from Advances to Director"
        '
        'paramTitle
        '
        Me.paramTitle.Description = "paramTitle"
        Me.paramTitle.Name = "paramTitle"
        '
        'detailBand1
        '
        Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2, Me.lblExp})
        Me.detailBand1.Dpi = 254.0!
        Me.detailBand1.EvenStyleName = "ReportEvenStyle"
        Me.detailBand1.HeightF = 64.0!
        Me.detailBand1.Name = "detailBand1"
        Me.detailBand1.OddStyleName = "ReportOddStyle"
        Me.detailBand1.StyleName = "ReportDetailBandStyle"
        '
        'table2
        '
        Me.table2.Dpi = 254.0!
        Me.table2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table2.Name = "table2"
        Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2})
        Me.table2.SizeF = New System.Drawing.SizeF(1148.292!, 64.0!)
        Me.table2.StylePriority.UseFont = False
        '
        'tableRow2
        '
        Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell5, Me.tableCell6, Me.tableCell7, Me.tableCell8})
        Me.tableRow2.Dpi = 254.0!
        Me.tableRow2.Name = "tableRow2"
        Me.tableRow2.Weight = 10.46953028649871R
        '
        'tableCell5
        '
        Me.tableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DI_MONTH")})
        Me.tableCell5.Dpi = 254.0!
        Me.tableCell5.Name = "tableCell5"
        Me.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.tableCell5.Weight = 0.37909459590374683R
        Me.tableCell5.WordWrap = False
        '
        'tableCell6
        '
        Me.tableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "MONTHLY_BASIS", "{0:#,# ;(#,#);0 }")})
        Me.tableCell6.Dpi = 254.0!
        Me.tableCell6.Name = "tableCell6"
        Me.tableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 45, 0, 0, 254.0!)
        Me.tableCell6.StylePriority.UsePadding = False
        Me.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell6.Weight = 0.42686346413310461R
        Me.tableCell6.WordWrap = False
        '
        'tableCell7
        '
        Me.tableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AVR_LEND_RATE", "{0:n2}")})
        Me.tableCell7.Dpi = 254.0!
        Me.tableCell7.Name = "tableCell7"
        Me.tableCell7.StylePriority.UseTextAlignment = False
        Me.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell7.Weight = 0.36544606110511829R
        Me.tableCell7.WordWrap = False
        '
        'tableCell8
        '
        Me.tableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DEEMED_INT", "{0:#,# ;(#,#);0 }")})
        Me.tableCell8.Dpi = 254.0!
        Me.tableCell8.Name = "tableCell8"
        Me.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell8.Weight = 0.3094355981912203R
        Me.tableCell8.WordWrap = False
        '
        'lblExp
        '
        Me.lblExp.Dpi = 254.0!
        Me.lblExp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExp.LocationFloat = New DevExpress.Utils.PointFloat(1169.459!, 0.0!)
        Me.lblExp.Name = "lblExp"
        Me.lblExp.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblExp.SizeF = New System.Drawing.SizeF(554.541!, 58.42!)
        Me.lblExp.StylePriority.UseFont = False
        '
        'reportFooterBand1
        '
        Me.reportFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrLine1, Me.table3})
        Me.reportFooterBand1.Dpi = 254.0!
        Me.reportFooterBand1.HeightF = 119.5625!
        Me.reportFooterBand1.Name = "reportFooterBand1"
        Me.reportFooterBand1.StyleName = "ReportFooterBandStyle"
        '
        'XrLine2
        '
        Me.XrLine2.BackColor = System.Drawing.Color.Transparent
        Me.XrLine2.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLine2.Dpi = 254.0!
        Me.XrLine2.LineWidth = 3
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(908.3457!, 86.0!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLine2.SizeF = New System.Drawing.SizeF(239.9467!, 18.52083!)
        Me.XrLine2.StylePriority.UseBackColor = False
        Me.XrLine2.StylePriority.UseBorders = False
        Me.XrLine2.StylePriority.UsePadding = False
        '
        'XrLine1
        '
        Me.XrLine1.BackColor = System.Drawing.Color.Transparent
        Me.XrLine1.Dpi = 254.0!
        Me.XrLine1.LineWidth = 3
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(908.3457!, 6.0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLine1.SizeF = New System.Drawing.SizeF(239.9467!, 13.22917!)
        Me.XrLine1.StylePriority.UseBackColor = False
        Me.XrLine1.StylePriority.UsePadding = False
        '
        'table3
        '
        Me.table3.BackColor = System.Drawing.Color.Transparent
        Me.table3.Dpi = 254.0!
        Me.table3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table3.LocationFloat = New DevExpress.Utils.PointFloat(908.35!, 20.0!)
        Me.table3.Name = "table3"
        Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow3})
        Me.table3.SizeF = New System.Drawing.SizeF(239.9467!, 64.0!)
        Me.table3.StylePriority.UseBackColor = False
        Me.table3.StylePriority.UseFont = False
        '
        'tableRow3
        '
        Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell12})
        Me.tableRow3.Dpi = 254.0!
        Me.tableRow3.Name = "tableRow3"
        Me.tableRow3.Weight = 10.46953028649871R
        '
        'tableCell12
        '
        Me.tableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DEEMED_INT")})
        Me.tableCell12.Dpi = 254.0!
        Me.tableCell12.Name = "tableCell12"
        Me.tableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary1.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary1.IgnoreNullValues = True
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell12.Summary = XrSummary1
        Me.tableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell12.Weight = 0.63499998926517354R
        Me.tableCell12.WordWrap = False
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
        'DEEMEDINTERESTBindingSource
        '
        Me.DEEMEDINTERESTBindingSource.DataMember = "DEEMED_INTEREST"
        Me.DEEMEDINTERESTBindingSource.DataSource = Me.DsTaxcomputation
        '
        'DsTaxcomputation
        '
        Me.DsTaxcomputation.DataSetName = "dsTaxcomputation"
        Me.DsTaxcomputation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'rpt_DeemedInterest
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.topMarginBand1, Me.pageHeaderBand1, Me.detailBand1, Me.reportFooterBand1, Me.bottomMarginBand1, Me.ReportHeader})
        Me.DataSource = Me.DEEMEDINTERESTBindingSource
        Me.Dpi = 254.0!
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.ShowDraft})
        Me.Margins = New System.Drawing.Printing.Margins(193, 183, 100, 100)
        Me.PageHeight = 2970
        Me.PageWidth = 2100
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.param_ShowDraft, Me.paramSch, Me.paramTitle})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.RequestParameters = False
        Me.SnapGridSize = 25.0!
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.ReportHeaderBandStyle, Me.ReportGroupHeaderBandStyle, Me.ReportDetailBandStyle, Me.ReportGroupFooterBandStyle, Me.ReportFooterBandStyle, Me.ReportOddStyle, Me.ReportEvenStyle})
        Me.Version = "17.1"
        CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEEMEDINTERESTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTaxcomputation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Private Sub lblExp_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblExp.BeforePrint
        Try
            '[ie. 1/12 x RM[MONTHLY_BASIS] x [AVR_LEND_RATE]%]
            Dim MonthlyBasis As Object = Me.GetCurrentColumnValue("MONTHLY_BASIS")
            Dim Avg As Object = Me.GetCurrentColumnValue("AVR_LEND_RATE")

            If MonthlyBasis IsNot Nothing AndAlso Avg IsNot Nothing AndAlso IsNumeric(MonthlyBasis) AndAlso IsNumeric(Avg) Then
                lblExp.Text = "[ie. 1/12 x RM" & CDec(MonthlyBasis).ToString("N0") & " x " & CDec(Avg) & "%]"
            Else
                lblExp.Text = ""
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
End Class
