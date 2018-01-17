Public Class rptCAReport
	Inherits DevExpress.XtraReports.UI.XtraReport
    Friend WithEvents DsCA As EasyTemplate_Taxcom.dsCA
    Private components As System.ComponentModel.IContainer
    Friend WithEvents CAREPORTTEMPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportEvenStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportOddStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportFooterBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportGroupFooterBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportDetailBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportGroupHeaderBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportHeaderBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents tableCell44 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell43 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell42 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell41 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell40 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell39 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell38 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell37 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell35 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents reportFooterBand1 As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents tableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents groupFooterBand1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents tableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents detailBand1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents groupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents label18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pageHeaderBand1 As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paramYA As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paramCompanyName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents tableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents table1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell2 As DevExpress.XtraReports.UI.XRTableCell
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
        Dim XrSummary15 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary16 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary17 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary18 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary19 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary20 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.pageHeaderBand1 = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.table2 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.groupFooterBand1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.table3 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.reportFooterBand1 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.table4 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell42 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell43 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell44 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeaderBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportGroupHeaderBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportDetailBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportGroupFooterBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportFooterBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportOddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportEvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.CAREPORTTEMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCA = New EasyTemplate_Taxcom.dsCA()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramCompanyName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.paramYA = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.tableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.table1 = New DevExpress.XtraReports.UI.XRTable()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAREPORTTEMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'topMarginBand1
        '
        Me.topMarginBand1.Dpi = 254.0!
        Me.topMarginBand1.HeightF = 50.0!
        Me.topMarginBand1.Name = "topMarginBand1"
        '
        'pageHeaderBand1
        '
        Me.pageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.label1, Me.label2, Me.label4, Me.label5, Me.label6, Me.label7, Me.label8, Me.label9, Me.label10, Me.label11, Me.label12, Me.label13, Me.label14, Me.label15, Me.label16, Me.label17, Me.label18, Me.XrLabel1})
        Me.pageHeaderBand1.Dpi = 254.0!
        Me.pageHeaderBand1.HeightF = 422.34!
        Me.pageHeaderBand1.Name = "pageHeaderBand1"
        Me.pageHeaderBand1.StyleName = "ReportHeaderBandStyle"
        '
        'label1
        '
        Me.label1.BorderColor = System.Drawing.Color.Transparent
        Me.label1.BorderWidth = 0.0!
        Me.label1.Dpi = 254.0!
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 237.0667!)
        Me.label1.Name = "label1"
        Me.label1.SizeF = New System.Drawing.SizeF(1286.522!, 62.99998!)
        Me.label1.StylePriority.UseBorderColor = False
        Me.label1.StylePriority.UseBorderWidth = False
        Me.label1.StylePriority.UseFont = False
        Me.label1.WordWrap = False
        '
        'label2
        '
        Me.label2.BorderColor = System.Drawing.Color.Transparent
        Me.label2.BorderWidth = 0.0!
        Me.label2.Dpi = 254.0!
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 300.0667!)
        Me.label2.Name = "label2"
        Me.label2.SizeF = New System.Drawing.SizeF(883.9927!, 122.2667!)
        Me.label2.StylePriority.UseBorderColor = False
        Me.label2.StylePriority.UseBorderWidth = False
        Me.label2.StylePriority.UseFont = False
        Me.label2.Text = "Asset"
        '
        'label4
        '
        Me.label4.BorderColor = System.Drawing.Color.Transparent
        Me.label4.BorderWidth = 0.0!
        Me.label4.Dpi = 254.0!
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.LocationFloat = New DevExpress.Utils.PointFloat(883.9927!, 300.07!)
        Me.label4.Name = "label4"
        Me.label4.SizeF = New System.Drawing.SizeF(128.35!, 122.27!)
        Me.label4.StylePriority.UseBorderColor = False
        Me.label4.StylePriority.UseBorderWidth = False
        Me.label4.StylePriority.UseFont = False
        Me.label4.StylePriority.UseTextAlignment = False
        Me.label4.Text = "Rate of IA"
        Me.label4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label5
        '
        Me.label5.BorderColor = System.Drawing.Color.Transparent
        Me.label5.BorderWidth = 0.0!
        Me.label5.Dpi = 254.0!
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.LocationFloat = New DevExpress.Utils.PointFloat(1012.343!, 300.0733!)
        Me.label5.Name = "label5"
        Me.label5.SizeF = New System.Drawing.SizeF(128.3463!, 122.2667!)
        Me.label5.StylePriority.UseBorderColor = False
        Me.label5.StylePriority.UseBorderWidth = False
        Me.label5.StylePriority.UseFont = False
        Me.label5.StylePriority.UseTextAlignment = False
        Me.label5.Text = "Rate of AA"
        Me.label5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label6
        '
        Me.label6.BorderColor = System.Drawing.Color.Transparent
        Me.label6.BorderWidth = 0.0!
        Me.label6.Dpi = 254.0!
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.LocationFloat = New DevExpress.Utils.PointFloat(1140.689!, 300.0667!)
        Me.label6.Name = "label6"
        Me.label6.SizeF = New System.Drawing.SizeF(145.8328!, 122.2667!)
        Me.label6.StylePriority.UseBorderColor = False
        Me.label6.StylePriority.UseBorderWidth = False
        Me.label6.StylePriority.UseFont = False
        Me.label6.StylePriority.UseTextAlignment = False
        Me.label6.Text = "Year of Purchase"
        Me.label6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label7
        '
        Me.label7.BorderColor = System.Drawing.Color.Transparent
        Me.label7.BorderWidth = 0.0!
        Me.label7.Dpi = 254.0!
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.LocationFloat = New DevExpress.Utils.PointFloat(1286.522!, 237.0635!)
        Me.label7.Name = "label7"
        Me.label7.SizeF = New System.Drawing.SizeF(621.9973!, 62.99998!)
        Me.label7.StylePriority.UseBorderColor = False
        Me.label7.StylePriority.UseBorderWidth = False
        Me.label7.StylePriority.UseFont = False
        Me.label7.StylePriority.UseTextAlignment = False
        Me.label7.Text = "QUALIFYING EXPENDITURE"
        Me.label7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.label7.WordWrap = False
        '
        'label8
        '
        Me.label8.BorderColor = System.Drawing.Color.Transparent
        Me.label8.BorderWidth = 0.0!
        Me.label8.Dpi = 254.0!
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.LocationFloat = New DevExpress.Utils.PointFloat(1286.522!, 300.07!)
        Me.label8.Name = "label8"
        Me.label8.SizeF = New System.Drawing.SizeF(157.8354!, 122.2667!)
        Me.label8.StylePriority.UseBorderColor = False
        Me.label8.StylePriority.UseBorderWidth = False
        Me.label8.StylePriority.UseFont = False
        Me.label8.StylePriority.UseTextAlignment = False
        Me.label8.Text = "Brought Forward RM"
        Me.label8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label9
        '
        Me.label9.BorderColor = System.Drawing.Color.Transparent
        Me.label9.BorderWidth = 0.0!
        Me.label9.Dpi = 254.0!
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.LocationFloat = New DevExpress.Utils.PointFloat(1444.357!, 300.0733!)
        Me.label9.Name = "label9"
        Me.label9.SizeF = New System.Drawing.SizeF(164.7664!, 122.2667!)
        Me.label9.StylePriority.UseBorderColor = False
        Me.label9.StylePriority.UseBorderWidth = False
        Me.label9.StylePriority.UseFont = False
        Me.label9.StylePriority.UseTextAlignment = False
        Me.label9.Text = "Additions RM"
        Me.label9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label10
        '
        Me.label10.BorderColor = System.Drawing.Color.Transparent
        Me.label10.BorderWidth = 0.0!
        Me.label10.Dpi = 254.0!
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.LocationFloat = New DevExpress.Utils.PointFloat(1609.124!, 300.0733!)
        Me.label10.Name = "label10"
        Me.label10.SizeF = New System.Drawing.SizeF(149.698!, 122.2667!)
        Me.label10.StylePriority.UseBorderColor = False
        Me.label10.StylePriority.UseBorderWidth = False
        Me.label10.StylePriority.UseFont = False
        Me.label10.StylePriority.UseTextAlignment = False
        Me.label10.Text = "Disposal RM"
        Me.label10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label11
        '
        Me.label11.BorderColor = System.Drawing.Color.Transparent
        Me.label11.BorderWidth = 0.0!
        Me.label11.Dpi = 254.0!
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.LocationFloat = New DevExpress.Utils.PointFloat(1758.821!, 300.07!)
        Me.label11.Name = "label11"
        Me.label11.SizeF = New System.Drawing.SizeF(149.6975!, 122.2667!)
        Me.label11.StylePriority.UseBorderColor = False
        Me.label11.StylePriority.UseBorderWidth = False
        Me.label11.StylePriority.UseFont = False
        Me.label11.StylePriority.UseTextAlignment = False
        Me.label11.Text = "Carried Forward RM"
        Me.label11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label12
        '
        Me.label12.BorderColor = System.Drawing.Color.Transparent
        Me.label12.BorderWidth = 0.0!
        Me.label12.Dpi = 254.0!
        Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.LocationFloat = New DevExpress.Utils.PointFloat(1908.519!, 237.0635!)
        Me.label12.Name = "label12"
        Me.label12.SizeF = New System.Drawing.SizeF(995.481!, 62.99022!)
        Me.label12.StylePriority.UseBorderColor = False
        Me.label12.StylePriority.UseBorderWidth = False
        Me.label12.StylePriority.UseFont = False
        Me.label12.StylePriority.UseTextAlignment = False
        Me.label12.Text = "RESIDUAL EXPENDITURE"
        Me.label12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.label12.WordWrap = False
        '
        'label13
        '
        Me.label13.BorderColor = System.Drawing.Color.Transparent
        Me.label13.BorderWidth = 0.0!
        Me.label13.Dpi = 254.0!
        Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.LocationFloat = New DevExpress.Utils.PointFloat(1908.519!, 300.0733!)
        Me.label13.Name = "label13"
        Me.label13.SizeF = New System.Drawing.SizeF(160.4197!, 122.2667!)
        Me.label13.StylePriority.UseBorderColor = False
        Me.label13.StylePriority.UseBorderWidth = False
        Me.label13.StylePriority.UseFont = False
        Me.label13.StylePriority.UseTextAlignment = False
        Me.label13.Text = "Brought Forward RM"
        Me.label13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label14
        '
        Me.label14.BorderColor = System.Drawing.Color.Transparent
        Me.label14.BorderWidth = 0.0!
        Me.label14.Dpi = 254.0!
        Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.LocationFloat = New DevExpress.Utils.PointFloat(2068.939!, 300.0634!)
        Me.label14.Name = "label14"
        Me.label14.SizeF = New System.Drawing.SizeF(166.5935!, 122.2667!)
        Me.label14.StylePriority.UseBorderColor = False
        Me.label14.StylePriority.UseBorderWidth = False
        Me.label14.StylePriority.UseFont = False
        Me.label14.StylePriority.UseTextAlignment = False
        Me.label14.Text = "Additions RM"
        Me.label14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label15
        '
        Me.label15.BorderColor = System.Drawing.Color.Transparent
        Me.label15.BorderWidth = 0.0!
        Me.label15.Dpi = 254.0!
        Me.label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.LocationFloat = New DevExpress.Utils.PointFloat(2235.532!, 300.0634!)
        Me.label15.Name = "label15"
        Me.label15.SizeF = New System.Drawing.SizeF(153.7585!, 122.2667!)
        Me.label15.StylePriority.UseBorderColor = False
        Me.label15.StylePriority.UseBorderWidth = False
        Me.label15.StylePriority.UseFont = False
        Me.label15.StylePriority.UseTextAlignment = False
        Me.label15.Text = "Disposal RM"
        Me.label15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label16
        '
        Me.label16.BorderColor = System.Drawing.Color.Transparent
        Me.label16.BorderWidth = 0.0!
        Me.label16.Dpi = 254.0!
        Me.label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label16.LocationFloat = New DevExpress.Utils.PointFloat(2389.29!, 300.0733!)
        Me.label16.Name = "label16"
        Me.label16.SizeF = New System.Drawing.SizeF(172.981!, 122.2667!)
        Me.label16.StylePriority.UseBorderColor = False
        Me.label16.StylePriority.UseBorderWidth = False
        Me.label16.StylePriority.UseFont = False
        Me.label16.StylePriority.UseTextAlignment = False
        Me.label16.Text = "Initial Allowances RM"
        Me.label16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label17
        '
        Me.label17.BorderColor = System.Drawing.Color.Transparent
        Me.label17.BorderWidth = 0.0!
        Me.label17.Dpi = 254.0!
        Me.label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label17.LocationFloat = New DevExpress.Utils.PointFloat(2562.271!, 300.0634!)
        Me.label17.Name = "label17"
        Me.label17.SizeF = New System.Drawing.SizeF(187.7976!, 122.2667!)
        Me.label17.StylePriority.UseBorderColor = False
        Me.label17.StylePriority.UseBorderWidth = False
        Me.label17.StylePriority.UseFont = False
        Me.label17.StylePriority.UseTextAlignment = False
        Me.label17.Text = "Annual Allowances RM"
        Me.label17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label18
        '
        Me.label18.BorderColor = System.Drawing.Color.Transparent
        Me.label18.BorderWidth = 0.0!
        Me.label18.Dpi = 254.0!
        Me.label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label18.LocationFloat = New DevExpress.Utils.PointFloat(2750.069!, 300.0667!)
        Me.label18.Name = "label18"
        Me.label18.SizeF = New System.Drawing.SizeF(153.9312!, 122.2667!)
        Me.label18.StylePriority.UseBorderColor = False
        Me.label18.StylePriority.UseBorderWidth = False
        Me.label18.StylePriority.UseFont = False
        Me.label18.StylePriority.UseTextAlignment = False
        Me.label18.Text = "Residual Exp C/F RM"
        Me.label18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'groupHeaderBand1
        '
        Me.groupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table1})
        Me.groupHeaderBand1.Dpi = 254.0!
        Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CA_ASSET", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.groupHeaderBand1.HeightF = 64.0!
        Me.groupHeaderBand1.Name = "groupHeaderBand1"
        Me.groupHeaderBand1.StyleName = "ReportGroupHeaderBandStyle"
        '
        'detailBand1
        '
        Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2})
        Me.detailBand1.Dpi = 254.0!
        Me.detailBand1.EvenStyleName = "ReportEvenStyle"
        Me.detailBand1.HeightF = 64.0!
        Me.detailBand1.Name = "detailBand1"
        Me.detailBand1.OddStyleName = "ReportOddStyle"
        Me.detailBand1.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CA_ASSET", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.detailBand1.StyleName = "ReportDetailBandStyle"
        '
        'table2
        '
        Me.table2.Dpi = 254.0!
        Me.table2.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table2.Name = "table2"
        Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2})
        Me.table2.SizeF = New System.Drawing.SizeF(2904.0!, 64.0!)
        Me.table2.StylePriority.UseFont = False
        '
        'tableRow2
        '
        Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell3, Me.tableCell4, Me.tableCell5, Me.tableCell6, Me.tableCell7, Me.tableCell8, Me.tableCell9, Me.tableCell10, Me.tableCell11, Me.tableCell12, Me.tableCell13, Me.tableCell14, Me.tableCell15, Me.tableCell16})
        Me.tableRow2.Dpi = 254.0!
        Me.tableRow2.Name = "tableRow2"
        Me.tableRow2.Weight = 10.46953028649871R
        '
        'tableCell3
        '
        Me.tableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_ASSET")})
        Me.tableCell3.Dpi = 254.0!
        Me.tableCell3.Name = "tableCell3"
        Me.tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.tableCell3.Weight = 1.5881705829447579R
        '
        'tableCell4
        '
        Me.tableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_RATE_IA", "{0} %")})
        Me.tableCell4.Dpi = 254.0!
        Me.tableCell4.Name = "tableCell4"
        Me.tableCell4.StylePriority.UseTextAlignment = False
        Me.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell4.Weight = 0.2305921459163677R
        '
        'tableCell5
        '
        Me.tableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_RATE_AA", "{0} %")})
        Me.tableCell5.Dpi = 254.0!
        Me.tableCell5.Name = "tableCell5"
        Me.tableCell5.StylePriority.UseTextAlignment = False
        Me.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell5.Weight = 0.23058555046257295R
        '
        'tableCell6
        '
        Me.tableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_PURCHASE_YEAR")})
        Me.tableCell6.Dpi = 254.0!
        Me.tableCell6.Name = "tableCell6"
        Me.tableCell6.StylePriority.UseTextAlignment = False
        Me.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell6.Weight = 0.26200094831482462R
        '
        'tableCell7
        '
        Me.tableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_BF", "{0:n2}")})
        Me.tableCell7.Dpi = 254.0!
        Me.tableCell7.Name = "tableCell7"
        Me.tableCell7.StylePriority.UseTextAlignment = False
        Me.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell7.Weight = 0.30186077180370613R
        '
        'tableCell8
        '
        Me.tableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_ADD", "{0:n2}")})
        Me.tableCell8.Dpi = 254.0!
        Me.tableCell8.Name = "tableCell8"
        Me.tableCell8.StylePriority.UseTextAlignment = False
        Me.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell8.Weight = 0.27772197193492215R
        '
        'tableCell9
        '
        Me.tableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_DISP", "{0:n2}")})
        Me.tableCell9.Dpi = 254.0!
        Me.tableCell9.Name = "tableCell9"
        Me.tableCell9.StylePriority.UseTextAlignment = False
        Me.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell9.Weight = 0.26894562213753481R
        '
        'tableCell10
        '
        Me.tableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_CF", "{0:n2}")})
        Me.tableCell10.Dpi = 254.0!
        Me.tableCell10.Name = "tableCell10"
        Me.tableCell10.StylePriority.UseTextAlignment = False
        Me.tableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell10.Weight = 0.26894452558725751R
        '
        'tableCell11
        '
        Me.tableCell11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_BF", "{0:n2}")})
        Me.tableCell11.Dpi = 254.0!
        Me.tableCell11.Name = "tableCell11"
        Me.tableCell11.StylePriority.UseTextAlignment = False
        Me.tableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell11.Weight = 0.28820828223433942R
        '
        'tableCell12
        '
        Me.tableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_ADD", "{0:n2}")})
        Me.tableCell12.Dpi = 254.0!
        Me.tableCell12.Name = "tableCell12"
        Me.tableCell12.StylePriority.UseTextAlignment = False
        Me.tableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell12.Weight = 0.29929988828668663R
        '
        'tableCell13
        '
        Me.tableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_DISP", "{0:n2}")})
        Me.tableCell13.Dpi = 254.0!
        Me.tableCell13.Name = "tableCell13"
        Me.tableCell13.StylePriority.UseTextAlignment = False
        Me.tableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell13.Weight = 0.27623987458046312R
        '
        'tableCell14
        '
        Me.tableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_AI", "{0:n2}")})
        Me.tableCell14.Dpi = 254.0!
        Me.tableCell14.Name = "tableCell14"
        Me.tableCell14.StylePriority.UseTextAlignment = False
        Me.tableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell14.Weight = 0.31077594486616772R
        '
        'tableCell15
        '
        Me.tableCell15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_AA", "{0:n2}")})
        Me.tableCell15.Dpi = 254.0!
        Me.tableCell15.Name = "tableCell15"
        Me.tableCell15.StylePriority.UseTextAlignment = False
        Me.tableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell15.Weight = 0.3373953607716913R
        '
        'tableCell16
        '
        Me.tableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_CF", "{0:n2}")})
        Me.tableCell16.Dpi = 254.0!
        Me.tableCell16.Name = "tableCell16"
        Me.tableCell16.StylePriority.UseTextAlignment = False
        Me.tableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell16.Weight = 0.27655000641256916R
        '
        'groupFooterBand1
        '
        Me.groupFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine4, Me.table3})
        Me.groupFooterBand1.Dpi = 254.0!
        Me.groupFooterBand1.HeightF = 114.8!
        Me.groupFooterBand1.Name = "groupFooterBand1"
        Me.groupFooterBand1.StyleName = "ReportGroupFooterBandStyle"
        '
        'table3
        '
        Me.table3.Dpi = 254.0!
        Me.table3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 25.00002!)
        Me.table3.Name = "table3"
        Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow3})
        Me.table3.SizeF = New System.Drawing.SizeF(2904.0!, 64.0!)
        '
        'tableRow3
        '
        Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell17, Me.tableCell21, Me.tableCell22, Me.tableCell23, Me.tableCell24, Me.tableCell25, Me.tableCell26, Me.tableCell27, Me.tableCell28, Me.tableCell29, Me.tableCell30})
        Me.tableRow3.Dpi = 254.0!
        Me.tableRow3.Name = "tableRow3"
        Me.tableRow3.Weight = 10.46953028649871R
        '
        'tableCell17
        '
        Me.tableCell17.BackColor = System.Drawing.Color.Transparent
        Me.tableCell17.Dpi = 254.0!
        Me.tableCell17.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell17.Name = "tableCell17"
        Me.tableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell17.StylePriority.UseBackColor = False
        Me.tableCell17.StylePriority.UseFont = False
        Me.tableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.tableCell17.Weight = 1.1412595112860429R
        Me.tableCell17.WordWrap = False
        '
        'tableCell21
        '
        Me.tableCell21.BackColor = System.Drawing.Color.Transparent
        Me.tableCell21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_BF")})
        Me.tableCell21.Dpi = 254.0!
        Me.tableCell21.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell21.Name = "tableCell21"
        Me.tableCell21.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell21.StylePriority.UseBackColor = False
        Me.tableCell21.StylePriority.UseFont = False
        Me.tableCell21.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.IgnoreNullValues = True
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell21.Summary = XrSummary1
        Me.tableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell21.Weight = 0.14001423713098371R
        Me.tableCell21.WordWrap = False
        '
        'tableCell22
        '
        Me.tableCell22.BackColor = System.Drawing.Color.Transparent
        Me.tableCell22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_ADD")})
        Me.tableCell22.Dpi = 254.0!
        Me.tableCell22.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell22.Name = "tableCell22"
        Me.tableCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell22.StylePriority.UseBackColor = False
        Me.tableCell22.StylePriority.UseFont = False
        Me.tableCell22.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:n2}"
        XrSummary2.IgnoreNullValues = True
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell22.Summary = XrSummary2
        Me.tableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell22.Weight = 0.1461624600393362R
        Me.tableCell22.WordWrap = False
        '
        'tableCell23
        '
        Me.tableCell23.BackColor = System.Drawing.Color.Transparent
        Me.tableCell23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_DISP")})
        Me.tableCell23.Dpi = 254.0!
        Me.tableCell23.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell23.Name = "tableCell23"
        Me.tableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell23.StylePriority.UseBackColor = False
        Me.tableCell23.StylePriority.UseFont = False
        Me.tableCell23.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:n2}"
        XrSummary3.IgnoreNullValues = True
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell23.Summary = XrSummary3
        Me.tableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell23.Weight = 0.13279548768676938R
        Me.tableCell23.WordWrap = False
        '
        'tableCell24
        '
        Me.tableCell24.BackColor = System.Drawing.Color.Transparent
        Me.tableCell24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_CF")})
        Me.tableCell24.Dpi = 254.0!
        Me.tableCell24.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell24.Name = "tableCell24"
        Me.tableCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell24.StylePriority.UseBackColor = False
        Me.tableCell24.StylePriority.UseFont = False
        Me.tableCell24.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0:n2}"
        XrSummary4.IgnoreNullValues = True
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell24.Summary = XrSummary4
        Me.tableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell24.Weight = 0.13279494003058556R
        Me.tableCell24.WordWrap = False
        '
        'tableCell25
        '
        Me.tableCell25.BackColor = System.Drawing.Color.Transparent
        Me.tableCell25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_BF")})
        Me.tableCell25.Dpi = 254.0!
        Me.tableCell25.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell25.Name = "tableCell25"
        Me.tableCell25.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell25.StylePriority.UseBackColor = False
        Me.tableCell25.StylePriority.UseFont = False
        Me.tableCell25.StylePriority.UseTextAlignment = False
        XrSummary5.FormatString = "{0:n2}"
        XrSummary5.IgnoreNullValues = True
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell25.Summary = XrSummary5
        Me.tableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell25.Weight = 0.14230668252292478R
        Me.tableCell25.WordWrap = False
        '
        'tableCell26
        '
        Me.tableCell26.BackColor = System.Drawing.Color.Transparent
        Me.tableCell26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_ADD")})
        Me.tableCell26.Dpi = 254.0!
        Me.tableCell26.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell26.Name = "tableCell26"
        Me.tableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell26.StylePriority.UseBackColor = False
        Me.tableCell26.StylePriority.UseFont = False
        Me.tableCell26.StylePriority.UseTextAlignment = False
        XrSummary6.FormatString = "{0:n2}"
        XrSummary6.IgnoreNullValues = True
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell26.Summary = XrSummary6
        Me.tableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell26.Weight = 0.14778330624287284R
        Me.tableCell26.WordWrap = False
        '
        'tableCell27
        '
        Me.tableCell27.BackColor = System.Drawing.Color.Transparent
        Me.tableCell27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_DISP")})
        Me.tableCell27.Dpi = 254.0!
        Me.tableCell27.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell27.Name = "tableCell27"
        Me.tableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell27.StylePriority.UseBackColor = False
        Me.tableCell27.StylePriority.UseFont = False
        Me.tableCell27.StylePriority.UseTextAlignment = False
        XrSummary7.FormatString = "{0:n2}"
        XrSummary7.IgnoreNullValues = True
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell27.Summary = XrSummary7
        Me.tableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell27.Weight = 0.13639711990251313R
        Me.tableCell27.WordWrap = False
        '
        'tableCell28
        '
        Me.tableCell28.BackColor = System.Drawing.Color.Transparent
        Me.tableCell28.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_AI")})
        Me.tableCell28.Dpi = 254.0!
        Me.tableCell28.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell28.Name = "tableCell28"
        Me.tableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell28.StylePriority.UseBackColor = False
        Me.tableCell28.StylePriority.UseFont = False
        Me.tableCell28.StylePriority.UseTextAlignment = False
        XrSummary8.FormatString = "{0:n2}"
        XrSummary8.IgnoreNullValues = True
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell28.Summary = XrSummary8
        Me.tableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell28.Weight = 0.15344976517476783R
        Me.tableCell28.WordWrap = False
        '
        'tableCell29
        '
        Me.tableCell29.BackColor = System.Drawing.Color.Transparent
        Me.tableCell29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_AA")})
        Me.tableCell29.Dpi = 254.0!
        Me.tableCell29.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell29.Name = "tableCell29"
        Me.tableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell29.StylePriority.UseBackColor = False
        Me.tableCell29.StylePriority.UseFont = False
        Me.tableCell29.StylePriority.UseTextAlignment = False
        XrSummary9.FormatString = "{0:n2}"
        XrSummary9.IgnoreNullValues = True
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell29.Summary = XrSummary9
        Me.tableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell29.Weight = 0.1665934543758526R
        Me.tableCell29.WordWrap = False
        '
        'tableCell30
        '
        Me.tableCell30.BackColor = System.Drawing.Color.Transparent
        Me.tableCell30.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_CF")})
        Me.tableCell30.Dpi = 254.0!
        Me.tableCell30.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell30.Name = "tableCell30"
        Me.tableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell30.StylePriority.UseBackColor = False
        Me.tableCell30.StylePriority.UseFont = False
        Me.tableCell30.StylePriority.UseTextAlignment = False
        XrSummary10.FormatString = "{0:n2}"
        XrSummary10.IgnoreNullValues = True
        XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell30.Summary = XrSummary10
        Me.tableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell30.Weight = 0.13655019061303261R
        Me.tableCell30.WordWrap = False
        '
        'reportFooterBand1
        '
        Me.reportFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine3, Me.XrLine2, Me.table4})
        Me.reportFooterBand1.Dpi = 254.0!
        Me.reportFooterBand1.HeightF = 193.1166!
        Me.reportFooterBand1.Name = "reportFooterBand1"
        Me.reportFooterBand1.StyleName = "ReportFooterBandStyle"
        '
        'table4
        '
        Me.table4.Dpi = 254.0!
        Me.table4.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 49.0833!)
        Me.table4.Name = "table4"
        Me.table4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow4})
        Me.table4.SizeF = New System.Drawing.SizeF(2904.0!, 64.0!)
        '
        'tableRow4
        '
        Me.tableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell31, Me.tableCell35, Me.tableCell36, Me.tableCell37, Me.tableCell38, Me.tableCell39, Me.tableCell40, Me.tableCell41, Me.tableCell42, Me.tableCell43, Me.tableCell44})
        Me.tableRow4.Dpi = 254.0!
        Me.tableRow4.Name = "tableRow4"
        Me.tableRow4.Weight = 10.46953028649871R
        '
        'tableCell35
        '
        Me.tableCell35.BackColor = System.Drawing.Color.Transparent
        Me.tableCell35.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.tableCell35.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_BF")})
        Me.tableCell35.Dpi = 254.0!
        Me.tableCell35.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell35.Name = "tableCell35"
        Me.tableCell35.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        Me.tableCell35.StylePriority.UseBackColor = False
        Me.tableCell35.StylePriority.UseBorders = False
        Me.tableCell35.StylePriority.UseFont = False
        Me.tableCell35.StylePriority.UseTextAlignment = False
        XrSummary11.FormatString = "{0:n2}"
        XrSummary11.IgnoreNullValues = True
        XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell35.Summary = XrSummary11
        Me.tableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell35.Weight = 0.220967314267185R
        Me.tableCell35.WordWrap = False
        '
        'tableCell36
        '
        Me.tableCell36.BackColor = System.Drawing.Color.Transparent
        Me.tableCell36.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_ADD")})
        Me.tableCell36.Dpi = 254.0!
        Me.tableCell36.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell36.Name = "tableCell36"
        Me.tableCell36.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        Me.tableCell36.StylePriority.UseBackColor = False
        Me.tableCell36.StylePriority.UseFont = False
        Me.tableCell36.StylePriority.UseTextAlignment = False
        XrSummary12.FormatString = "{0:n2}"
        XrSummary12.IgnoreNullValues = True
        XrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell36.Summary = XrSummary12
        Me.tableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell36.Weight = 0.23067029000816797R
        Me.tableCell36.WordWrap = False
        '
        'tableCell37
        '
        Me.tableCell37.BackColor = System.Drawing.Color.Transparent
        Me.tableCell37.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_DISP")})
        Me.tableCell37.Dpi = 254.0!
        Me.tableCell37.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell37.Name = "tableCell37"
        Me.tableCell37.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        Me.tableCell37.StylePriority.UseBackColor = False
        Me.tableCell37.StylePriority.UseFont = False
        Me.tableCell37.StylePriority.UseTextAlignment = False
        XrSummary13.FormatString = "{0:n2}"
        XrSummary13.IgnoreNullValues = True
        XrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell37.Summary = XrSummary13
        Me.tableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell37.Weight = 0.20957484494862433R
        Me.tableCell37.WordWrap = False
        '
        'tableCell38
        '
        Me.tableCell38.BackColor = System.Drawing.Color.Transparent
        Me.tableCell38.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_CF")})
        Me.tableCell38.Dpi = 254.0!
        Me.tableCell38.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell38.Name = "tableCell38"
        Me.tableCell38.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        Me.tableCell38.StylePriority.UseBackColor = False
        Me.tableCell38.StylePriority.UseFont = False
        Me.tableCell38.StylePriority.UseTextAlignment = False
        XrSummary14.FormatString = "{0:n2}"
        XrSummary14.IgnoreNullValues = True
        XrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell38.Summary = XrSummary14
        Me.tableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell38.Weight = 0.20957398755141221R
        Me.tableCell38.WordWrap = False
        '
        'tableCell39
        '
        Me.tableCell39.BackColor = System.Drawing.Color.Transparent
        Me.tableCell39.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_BF")})
        Me.tableCell39.Dpi = 254.0!
        Me.tableCell39.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell39.Name = "tableCell39"
        Me.tableCell39.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        Me.tableCell39.StylePriority.UseBackColor = False
        Me.tableCell39.StylePriority.UseFont = False
        Me.tableCell39.StylePriority.UseTextAlignment = False
        XrSummary15.FormatString = "{0:n2}"
        XrSummary15.IgnoreNullValues = True
        XrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell39.Summary = XrSummary15
        Me.tableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell39.Weight = 0.22458519258820644R
        Me.tableCell39.WordWrap = False
        '
        'tableCell40
        '
        Me.tableCell40.BackColor = System.Drawing.Color.Transparent
        Me.tableCell40.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_ADD")})
        Me.tableCell40.Dpi = 254.0!
        Me.tableCell40.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell40.Name = "tableCell40"
        Me.tableCell40.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        Me.tableCell40.StylePriority.UseBackColor = False
        Me.tableCell40.StylePriority.UseFont = False
        Me.tableCell40.StylePriority.UseTextAlignment = False
        XrSummary16.FormatString = "{0:n2}"
        XrSummary16.IgnoreNullValues = True
        XrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell40.Summary = XrSummary16
        Me.tableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell40.Weight = 0.23322826896283672R
        Me.tableCell40.WordWrap = False
        '
        'tableCell41
        '
        Me.tableCell41.BackColor = System.Drawing.Color.Transparent
        Me.tableCell41.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_DISP")})
        Me.tableCell41.Dpi = 254.0!
        Me.tableCell41.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell41.Name = "tableCell41"
        Me.tableCell41.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        Me.tableCell41.StylePriority.UseBackColor = False
        Me.tableCell41.StylePriority.UseFont = False
        Me.tableCell41.StylePriority.UseTextAlignment = False
        XrSummary17.FormatString = "{0:n2}"
        XrSummary17.IgnoreNullValues = True
        XrSummary17.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell41.Summary = XrSummary17
        Me.tableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell41.Weight = 0.21525886233597402R
        Me.tableCell41.WordWrap = False
        '
        'tableCell42
        '
        Me.tableCell42.BackColor = System.Drawing.Color.Transparent
        Me.tableCell42.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_AI")})
        Me.tableCell42.Dpi = 254.0!
        Me.tableCell42.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell42.Name = "tableCell42"
        Me.tableCell42.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        Me.tableCell42.StylePriority.UseBackColor = False
        Me.tableCell42.StylePriority.UseFont = False
        Me.tableCell42.StylePriority.UseTextAlignment = False
        XrSummary18.FormatString = "{0:n2}"
        XrSummary18.IgnoreNullValues = True
        XrSummary18.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell42.Summary = XrSummary18
        Me.tableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell42.Weight = 0.24217096026414026R
        Me.tableCell42.WordWrap = False
        '
        'tableCell43
        '
        Me.tableCell43.BackColor = System.Drawing.Color.Transparent
        Me.tableCell43.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_AA")})
        Me.tableCell43.Dpi = 254.0!
        Me.tableCell43.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell43.Name = "tableCell43"
        Me.tableCell43.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        Me.tableCell43.StylePriority.UseBackColor = False
        Me.tableCell43.StylePriority.UseFont = False
        Me.tableCell43.StylePriority.UseTextAlignment = False
        XrSummary19.FormatString = "{0:n2}"
        XrSummary19.IgnoreNullValues = True
        XrSummary19.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell43.Summary = XrSummary19
        Me.tableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell43.Weight = 0.26291403619846004R
        Me.tableCell43.WordWrap = False
        '
        'tableCell44
        '
        Me.tableCell44.BackColor = System.Drawing.Color.Transparent
        Me.tableCell44.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_CF")})
        Me.tableCell44.Dpi = 254.0!
        Me.tableCell44.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell44.Name = "tableCell44"
        Me.tableCell44.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        Me.tableCell44.StylePriority.UseBackColor = False
        Me.tableCell44.StylePriority.UseFont = False
        Me.tableCell44.StylePriority.UseTextAlignment = False
        XrSummary20.FormatString = "{0:n2}"
        XrSummary20.IgnoreNullValues = True
        XrSummary20.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell44.Summary = XrSummary20
        Me.tableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell44.Weight = 0.2155004200145324R
        Me.tableCell44.WordWrap = False
        '
        'bottomMarginBand1
        '
        Me.bottomMarginBand1.Dpi = 254.0!
        Me.bottomMarginBand1.HeightF = 50.0!
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
        Me.ReportDetailBandStyle.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.ReportDetailBandStyle.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.ReportDetailBandStyle.BorderWidth = 1.0!
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
        'CAREPORTTEMPBindingSource
        '
        Me.CAREPORTTEMPBindingSource.DataMember = "CA_REPORT_TEMP"
        Me.CAREPORTTEMPBindingSource.DataSource = Me.DsCA
        '
        'DsCA
        '
        Me.DsCA.DataSetName = "dsCA"
        Me.DsCA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
        Me.PageFooter.Dpi = 254.0!
        Me.PageFooter.HeightF = 127.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Dpi = 254.0!
        Me.XrPageInfo1.Format = "Page {0} / {1}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(2621.25!, 12.30002!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(254.0!, 58.42!)
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(872.6785!, 24.99999!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(136.4884!, 58.42!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "Name :"
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(872.6785!, 83.41998!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(965.8489!, 58.41999!)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "INCOME TAX COMPUTATION - YEAR OF ASSESSMENT"
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(872.6785!, 141.8401!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(965.8489!, 58.42001!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "SCHEDULE OF CAPITAL ALLOWANCES"
        '
        'paramCompanyName
        '
        Me.paramCompanyName.Description = "paramCompanyName"
        Me.paramCompanyName.Name = "paramCompanyName"
        '
        'paramYA
        '
        Me.paramYA.Description = "paramYA"
        Me.paramYA.Name = "paramYA"
        Me.paramYA.Type = GetType(Integer)
        Me.paramYA.ValueInfo = "0"
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramCompanyName, "Text", "")})
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(1009.167!, 24.99999!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(1083.361!, 58.42!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "XrLabel4"
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramYA, "Text", "")})
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(1838.527!, 83.41998!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(254.0!, 58.42!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "XrLabel5"
        '
        'tableCell31
        '
        Me.tableCell31.BackColor = System.Drawing.Color.Transparent
        Me.tableCell31.Dpi = 254.0!
        Me.tableCell31.Name = "tableCell31"
        Me.tableCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        Me.tableCell31.StylePriority.UseBackColor = False
        Me.tableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.tableCell31.Weight = 1.8011099940396946R
        Me.tableCell31.WordWrap = False
        '
        'XrLine2
        '
        Me.XrLine2.BackColor = System.Drawing.Color.Transparent
        Me.XrLine2.Dpi = 254.0!
        Me.XrLine2.LineWidth = 3
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(1286.522!, 123.2434!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(1617.478!, 22.43661!)
        Me.XrLine2.StylePriority.UseBackColor = False
        '
        'XrLine3
        '
        Me.XrLine3.BackColor = System.Drawing.Color.Transparent
        Me.XrLine3.Dpi = 254.0!
        Me.XrLine3.LineWidth = 3
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(1286.522!, 145.68!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(1617.478!, 22.43661!)
        Me.XrLine3.StylePriority.UseBackColor = False
        '
        'XrLine4
        '
        Me.XrLine4.BackColor = System.Drawing.Color.Transparent
        Me.XrLine4.Dpi = 254.0!
        Me.XrLine4.LineWidth = 3
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(1286.522!, 2.563409!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.SizeF = New System.Drawing.SizeF(1617.478!, 22.43661!)
        Me.XrLine4.StylePriority.UseBackColor = False
        '
        'tableCell2
        '
        Me.tableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_ASSET")})
        Me.tableCell2.Dpi = 254.0!
        Me.tableCell2.Name = "tableCell2"
        Me.tableCell2.Weight = 0.38856864725017926R
        Me.tableCell2.WordWrap = False
        '
        'tableRow1
        '
        Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell2})
        Me.tableRow1.Dpi = 254.0!
        Me.tableRow1.Name = "tableRow1"
        Me.tableRow1.Weight = 10.46953028649871R
        '
        'table1
        '
        Me.table1.BackColor = System.Drawing.Color.Transparent
        Me.table1.Dpi = 254.0!
        Me.table1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table1.Name = "table1"
        Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
        Me.table1.SizeF = New System.Drawing.SizeF(2904.0!, 64.0!)
        Me.table1.StylePriority.UseBackColor = False
        Me.table1.StylePriority.UseFont = False
        '
        'rptCAReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.topMarginBand1, Me.pageHeaderBand1, Me.groupHeaderBand1, Me.detailBand1, Me.groupFooterBand1, Me.reportFooterBand1, Me.bottomMarginBand1, Me.PageFooter})
        Me.DataSource = Me.CAREPORTTEMPBindingSource
        Me.Dpi = 254.0!
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(36, 30, 50, 50)
        Me.PageHeight = 2100
        Me.PageWidth = 2970
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.paramCompanyName, Me.paramYA})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.RequestParameters = False
        Me.SnapGridSize = 25.0!
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.ReportHeaderBandStyle, Me.ReportGroupHeaderBandStyle, Me.ReportDetailBandStyle, Me.ReportGroupFooterBandStyle, Me.ReportFooterBandStyle, Me.ReportOddStyle, Me.ReportEvenStyle})
        Me.Version = "17.1"
        CType(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAREPORTTEMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
End Class
