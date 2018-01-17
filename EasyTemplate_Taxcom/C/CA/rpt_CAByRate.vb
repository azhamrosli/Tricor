Public Class rpt_CAByRate
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
    Friend WithEvents tableCell81 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell80 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell79 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell78 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell77 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell76 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell75 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell74 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell73 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell72 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell71 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table8 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents reportFooterBand1 As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents tableCell66 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell65 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell64 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell63 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell62 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell61 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell60 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell59 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell58 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell57 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell56 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table7 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents groupFooterBand3 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents tableCell51 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell49 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell48 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell47 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell46 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell45 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell44 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell43 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell42 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell41 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table6 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents groupFooterBand2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents tableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell17 As DevExpress.XtraReports.UI.XRTableCell
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
    Friend WithEvents tableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents detailBand1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents tableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents groupHeaderBand3 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents groupHeaderBand2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents groupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents label19 As DevExpress.XtraReports.UI.XRLabel
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
    Friend WithEvents table2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paramCompanyName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paramYA As DevExpress.XtraReports.Parameters.Parameter
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
        Dim XrSummary21 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary22 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary23 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary24 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary25 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary26 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary27 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary28 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary29 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary30 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary31 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary32 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary33 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
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
        Me.label19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.groupHeaderBand2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.groupHeaderBand3 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.table3 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.table4 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
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
        Me.tableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.groupFooterBand2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.table6 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell42 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell43 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell44 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell45 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell46 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell47 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell48 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell49 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell51 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.groupFooterBand3 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.table7 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell56 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell57 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell58 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell59 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell60 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell61 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell62 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell63 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell64 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell65 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell66 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.reportFooterBand1 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.table8 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell71 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell72 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell73 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell74 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell75 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell76 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell77 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell78 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell79 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell80 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell81 = New DevExpress.XtraReports.UI.XRTableCell()
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
        Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.table2 = New DevExpress.XtraReports.UI.XRTable()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramCompanyName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.paramYA = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.table3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAREPORTTEMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5, Me.XrLabel4, Me.XrLabel1, Me.XrLabel3, Me.XrLabel2, Me.label1, Me.label2, Me.label4, Me.label5, Me.label6, Me.label7, Me.label8, Me.label9, Me.label10, Me.label11, Me.label12, Me.label13, Me.label14, Me.label15, Me.label16, Me.label17, Me.label18, Me.label19})
        Me.pageHeaderBand1.Dpi = 254.0!
        Me.pageHeaderBand1.HeightF = 488.4758!
        Me.pageHeaderBand1.Name = "pageHeaderBand1"
        Me.pageHeaderBand1.StyleName = "ReportHeaderBandStyle"
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label1.Dpi = 254.0!
        Me.label1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 288.3958!)
        Me.label1.Name = "label1"
        Me.label1.SizeF = New System.Drawing.SizeF(1136.42!, 63.0!)
        Me.label1.StylePriority.UseBackColor = False
        Me.label1.StylePriority.UseFont = False
        '
        'label2
        '
        Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label2.Dpi = 254.0!
        Me.label2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 351.3958!)
        Me.label2.Name = "label2"
        Me.label2.SizeF = New System.Drawing.SizeF(644.0303!, 137.08!)
        Me.label2.StylePriority.UseBackColor = False
        Me.label2.StylePriority.UseFont = False
        Me.label2.Text = "Asset"
        '
        'label4
        '
        Me.label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label4.Dpi = 254.0!
        Me.label4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.LocationFloat = New DevExpress.Utils.PointFloat(644.0303!, 351.3958!)
        Me.label4.Name = "label4"
        Me.label4.SizeF = New System.Drawing.SizeF(164.13!, 137.08!)
        Me.label4.StylePriority.UseBackColor = False
        Me.label4.StylePriority.UseFont = False
        Me.label4.StylePriority.UseTextAlignment = False
        Me.label4.Text = "Rate of IA %"
        Me.label4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label5
        '
        Me.label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label5.Dpi = 254.0!
        Me.label5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.LocationFloat = New DevExpress.Utils.PointFloat(808.1603!, 351.3958!)
        Me.label5.Name = "label5"
        Me.label5.SizeF = New System.Drawing.SizeF(164.13!, 137.08!)
        Me.label5.StylePriority.UseBackColor = False
        Me.label5.StylePriority.UseFont = False
        Me.label5.StylePriority.UseTextAlignment = False
        Me.label5.Text = "Rate of AA %"
        Me.label5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label6
        '
        Me.label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label6.Dpi = 254.0!
        Me.label6.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.LocationFloat = New DevExpress.Utils.PointFloat(972.2903!, 351.3958!)
        Me.label6.Name = "label6"
        Me.label6.SizeF = New System.Drawing.SizeF(164.13!, 137.08!)
        Me.label6.StylePriority.UseBackColor = False
        Me.label6.StylePriority.UseFont = False
        Me.label6.StylePriority.UseTextAlignment = False
        Me.label6.Text = "Year of Purchase"
        Me.label6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label7
        '
        Me.label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label7.Dpi = 254.0!
        Me.label7.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.LocationFloat = New DevExpress.Utils.PointFloat(1136.42!, 288.3958!)
        Me.label7.Name = "label7"
        Me.label7.SizeF = New System.Drawing.SizeF(588.8699!, 63.0!)
        Me.label7.StylePriority.UseBackColor = False
        Me.label7.StylePriority.UseFont = False
        Me.label7.StylePriority.UseTextAlignment = False
        Me.label7.Text = "QUALIFYING EXPENDITURE"
        Me.label7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label8
        '
        Me.label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label8.Dpi = 254.0!
        Me.label8.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.LocationFloat = New DevExpress.Utils.PointFloat(1136.42!, 351.3958!)
        Me.label8.Name = "label8"
        Me.label8.SizeF = New System.Drawing.SizeF(153.62!, 137.08!)
        Me.label8.StylePriority.UseBackColor = False
        Me.label8.StylePriority.UseFont = False
        Me.label8.StylePriority.UseTextAlignment = False
        Me.label8.Text = "Brought Forward RM"
        Me.label8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label9
        '
        Me.label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label9.Dpi = 254.0!
        Me.label9.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.LocationFloat = New DevExpress.Utils.PointFloat(1290.04!, 351.3958!)
        Me.label9.Name = "label9"
        Me.label9.SizeF = New System.Drawing.SizeF(147.2!, 137.08!)
        Me.label9.StylePriority.UseBackColor = False
        Me.label9.StylePriority.UseFont = False
        Me.label9.StylePriority.UseTextAlignment = False
        Me.label9.Text = "Additions RM"
        Me.label9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label10
        '
        Me.label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label10.Dpi = 254.0!
        Me.label10.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.LocationFloat = New DevExpress.Utils.PointFloat(1437.24!, 351.3958!)
        Me.label10.Name = "label10"
        Me.label10.SizeF = New System.Drawing.SizeF(145.08!, 137.08!)
        Me.label10.StylePriority.UseBackColor = False
        Me.label10.StylePriority.UseFont = False
        Me.label10.StylePriority.UseTextAlignment = False
        Me.label10.Text = "Disposal RM"
        Me.label10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label11
        '
        Me.label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label11.Dpi = 254.0!
        Me.label11.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.LocationFloat = New DevExpress.Utils.PointFloat(1582.32!, 351.3958!)
        Me.label11.Name = "label11"
        Me.label11.SizeF = New System.Drawing.SizeF(142.97!, 137.08!)
        Me.label11.StylePriority.UseBackColor = False
        Me.label11.StylePriority.UseFont = False
        Me.label11.StylePriority.UseTextAlignment = False
        Me.label11.Text = "Carried Forward RM"
        Me.label11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label12
        '
        Me.label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label12.Dpi = 254.0!
        Me.label12.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.LocationFloat = New DevExpress.Utils.PointFloat(1725.29!, 288.3958!)
        Me.label12.Name = "label12"
        Me.label12.SizeF = New System.Drawing.SizeF(1090.71!, 63.0!)
        Me.label12.StylePriority.UseBackColor = False
        Me.label12.StylePriority.UseFont = False
        Me.label12.StylePriority.UseTextAlignment = False
        Me.label12.Text = "RESIDUAL EXPENDITURE"
        Me.label12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label13
        '
        Me.label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label13.Dpi = 254.0!
        Me.label13.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.LocationFloat = New DevExpress.Utils.PointFloat(1725.29!, 351.3958!)
        Me.label13.Name = "label13"
        Me.label13.SizeF = New System.Drawing.SizeF(145.08!, 137.08!)
        Me.label13.StylePriority.UseBackColor = False
        Me.label13.StylePriority.UseFont = False
        Me.label13.StylePriority.UseTextAlignment = False
        Me.label13.Text = "Brought Forward RM"
        Me.label13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label14
        '
        Me.label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label14.Dpi = 254.0!
        Me.label14.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.LocationFloat = New DevExpress.Utils.PointFloat(1870.37!, 351.3958!)
        Me.label14.Name = "label14"
        Me.label14.SizeF = New System.Drawing.SizeF(147.99!, 137.08!)
        Me.label14.StylePriority.UseBackColor = False
        Me.label14.StylePriority.UseFont = False
        Me.label14.StylePriority.UseTextAlignment = False
        Me.label14.Text = "Additions RM"
        Me.label14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label15
        '
        Me.label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label15.Dpi = 254.0!
        Me.label15.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.LocationFloat = New DevExpress.Utils.PointFloat(2018.36!, 351.3958!)
        Me.label15.Name = "label15"
        Me.label15.SizeF = New System.Drawing.SizeF(155.58!, 137.08!)
        Me.label15.StylePriority.UseBackColor = False
        Me.label15.StylePriority.UseFont = False
        Me.label15.StylePriority.UseTextAlignment = False
        Me.label15.Text = "Disposal RM"
        Me.label15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label16
        '
        Me.label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label16.Dpi = 254.0!
        Me.label16.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label16.LocationFloat = New DevExpress.Utils.PointFloat(2173.94!, 351.3958!)
        Me.label16.Name = "label16"
        Me.label16.SizeF = New System.Drawing.SizeF(147.54!, 137.08!)
        Me.label16.StylePriority.UseBackColor = False
        Me.label16.StylePriority.UseFont = False
        Me.label16.StylePriority.UseTextAlignment = False
        Me.label16.Text = "Total RM"
        Me.label16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label17
        '
        Me.label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label17.Dpi = 254.0!
        Me.label17.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label17.LocationFloat = New DevExpress.Utils.PointFloat(2321.48!, 351.3958!)
        Me.label17.Name = "label17"
        Me.label17.SizeF = New System.Drawing.SizeF(164.13!, 137.08!)
        Me.label17.StylePriority.UseBackColor = False
        Me.label17.StylePriority.UseFont = False
        Me.label17.StylePriority.UseTextAlignment = False
        Me.label17.Text = "Initial Allowances RM"
        Me.label17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label18
        '
        Me.label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label18.Dpi = 254.0!
        Me.label18.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label18.LocationFloat = New DevExpress.Utils.PointFloat(2485.61!, 351.3958!)
        Me.label18.Name = "label18"
        Me.label18.SizeF = New System.Drawing.SizeF(168.37!, 137.08!)
        Me.label18.StylePriority.UseBackColor = False
        Me.label18.StylePriority.UseFont = False
        Me.label18.StylePriority.UseTextAlignment = False
        Me.label18.Text = "Annual Allowances RM"
        Me.label18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'label19
        '
        Me.label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label19.Dpi = 254.0!
        Me.label19.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label19.LocationFloat = New DevExpress.Utils.PointFloat(2653.98!, 351.3958!)
        Me.label19.Name = "label19"
        Me.label19.SizeF = New System.Drawing.SizeF(162.02!, 137.08!)
        Me.label19.StylePriority.UseBackColor = False
        Me.label19.StylePriority.UseFont = False
        Me.label19.StylePriority.UseTextAlignment = False
        Me.label19.Text = "Residual Exp C/F RM"
        Me.label19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'groupHeaderBand1
        '
        Me.groupHeaderBand1.Dpi = 254.0!
        Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CA_RATE_AA", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.groupHeaderBand1.HeightF = 0.0!
        Me.groupHeaderBand1.Name = "groupHeaderBand1"
        Me.groupHeaderBand1.StyleName = "ReportGroupHeaderBandStyle"
        '
        'groupHeaderBand2
        '
        Me.groupHeaderBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2})
        Me.groupHeaderBand2.Dpi = 254.0!
        Me.groupHeaderBand2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CA_PURCHASE_YEAR", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.groupHeaderBand2.HeightF = 64.0!
        Me.groupHeaderBand2.Level = 1
        Me.groupHeaderBand2.Name = "groupHeaderBand2"
        Me.groupHeaderBand2.StyleName = "ReportGroupHeaderBandStyle"
        '
        'groupHeaderBand3
        '
        Me.groupHeaderBand3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table3})
        Me.groupHeaderBand3.Dpi = 254.0!
        Me.groupHeaderBand3.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CA_TRANSFERROR_NAME", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand3.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.groupHeaderBand3.HeightF = 64.0!
        Me.groupHeaderBand3.Level = 2
        Me.groupHeaderBand3.Name = "groupHeaderBand3"
        Me.groupHeaderBand3.StyleName = "ReportGroupHeaderBandStyle"
        '
        'table3
        '
        Me.table3.Dpi = 254.0!
        Me.table3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table3.Name = "table3"
        Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow3})
        Me.table3.SizeF = New System.Drawing.SizeF(2816.0!, 64.0!)
        Me.table3.StylePriority.UseFont = False
        '
        'tableRow3
        '
        Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell6})
        Me.tableRow3.Dpi = 254.0!
        Me.tableRow3.Name = "tableRow3"
        Me.tableRow3.Weight = 10.46953028649871R
        '
        'tableCell6
        '
        Me.tableCell6.BackColor = System.Drawing.Color.Transparent
        Me.tableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_TRANSFERROR_NAME")})
        Me.tableCell6.Dpi = 254.0!
        Me.tableCell6.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell6.Name = "tableCell6"
        Me.tableCell6.StylePriority.UseBackColor = False
        Me.tableCell6.StylePriority.UseFont = False
        Me.tableCell6.Weight = 2.5649300562073254R
        Me.tableCell6.WordWrap = False
        '
        'detailBand1
        '
        Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table4})
        Me.detailBand1.Dpi = 254.0!
        Me.detailBand1.EvenStyleName = "ReportEvenStyle"
        Me.detailBand1.HeightF = 64.0!
        Me.detailBand1.Name = "detailBand1"
        Me.detailBand1.OddStyleName = "ReportOddStyle"
        Me.detailBand1.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CA_ASSET", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("CA_RATE_AA", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("CA_PURCHASE_YEAR", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.detailBand1.StyleName = "ReportDetailBandStyle"
        '
        'table4
        '
        Me.table4.Dpi = 254.0!
        Me.table4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table4.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table4.Name = "table4"
        Me.table4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow4})
        Me.table4.SizeF = New System.Drawing.SizeF(2816.0!, 64.0!)
        Me.table4.StylePriority.UseFont = False
        '
        'tableRow4
        '
        Me.tableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell7, Me.tableCell8, Me.tableCell9, Me.tableCell10, Me.tableCell11, Me.tableCell12, Me.tableCell13, Me.tableCell14, Me.tableCell15, Me.tableCell16, Me.tableCell17, Me.tableCell18, Me.tableCell19, Me.tableCell20, Me.tableCell21})
        Me.tableRow4.Dpi = 254.0!
        Me.tableRow4.Name = "tableRow4"
        Me.tableRow4.Weight = 10.46953028649871R
        '
        'tableCell7
        '
        Me.tableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_ASSET")})
        Me.tableCell7.Dpi = 254.0!
        Me.tableCell7.Name = "tableCell7"
        Me.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.tableCell7.Weight = 0.65190788900199326R
        Me.tableCell7.WordWrap = False
        '
        'tableCell8
        '
        Me.tableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_RATE_IA")})
        Me.tableCell8.Dpi = 254.0!
        Me.tableCell8.Name = "tableCell8"
        Me.tableCell8.StylePriority.UseTextAlignment = False
        Me.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell8.Weight = 0.16613760342117725R
        Me.tableCell8.WordWrap = False
        '
        'tableCell9
        '
        Me.tableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_RATE_AA")})
        Me.tableCell9.Dpi = 254.0!
        Me.tableCell9.Name = "tableCell9"
        Me.tableCell9.StylePriority.UseTextAlignment = False
        Me.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell9.Weight = 0.16613754983350346R
        Me.tableCell9.WordWrap = False
        '
        'tableCell10
        '
        Me.tableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_PURCHASE_YEAR")})
        Me.tableCell10.Dpi = 254.0!
        Me.tableCell10.Name = "tableCell10"
        Me.tableCell10.StylePriority.UseTextAlignment = False
        Me.tableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell10.Weight = 0.16613761161522506R
        Me.tableCell10.WordWrap = False
        '
        'tableCell11
        '
        Me.tableCell11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_BF", "{0:n2}")})
        Me.tableCell11.Dpi = 254.0!
        Me.tableCell11.Name = "tableCell11"
        Me.tableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell11.Weight = 0.15549902057314013R
        Me.tableCell11.WordWrap = False
        '
        'tableCell12
        '
        Me.tableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_ADD", "{0:n2}")})
        Me.tableCell12.Dpi = 254.0!
        Me.tableCell12.Name = "tableCell12"
        Me.tableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell12.Weight = 0.14900032483662681R
        Me.tableCell12.WordWrap = False
        '
        'tableCell13
        '
        Me.tableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_DISP", "{0:n2}")})
        Me.tableCell13.Dpi = 254.0!
        Me.tableCell13.Name = "tableCell13"
        Me.tableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell13.Weight = 0.14685453752584374R
        Me.tableCell13.WordWrap = False
        '
        'tableCell14
        '
        Me.tableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_CF", "{0:n2}")})
        Me.tableCell14.Dpi = 254.0!
        Me.tableCell14.Name = "tableCell14"
        Me.tableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell14.Weight = 0.14471886697198028R
        Me.tableCell14.WordWrap = False
        '
        'tableCell15
        '
        Me.tableCell15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_BF", "{0:n2}")})
        Me.tableCell15.Dpi = 254.0!
        Me.tableCell15.Name = "tableCell15"
        Me.tableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell15.Weight = 0.14685453752584374R
        Me.tableCell15.WordWrap = False
        '
        'tableCell16
        '
        Me.tableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_ADD", "{0:n2}")})
        Me.tableCell16.Dpi = 254.0!
        Me.tableCell16.Name = "tableCell16"
        Me.tableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell16.Weight = 0.14980016645048802R
        Me.tableCell16.WordWrap = False
        '
        'tableCell17
        '
        Me.tableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_DISP", "{0:n2}")})
        Me.tableCell17.Dpi = 254.0!
        Me.tableCell17.Name = "tableCell17"
        Me.tableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell17.Weight = 0.15748309422751444R
        Me.tableCell17.WordWrap = False
        '
        'tableCell18
        '
        Me.tableCell18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_TOTAL")})
        Me.tableCell18.Dpi = 254.0!
        Me.tableCell18.Name = "tableCell18"
        Me.tableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell18.Weight = 0.14934446447162614R
        Me.tableCell18.WordWrap = False
        '
        'tableCell19
        '
        Me.tableCell19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_AI", "{0:n2}")})
        Me.tableCell19.Dpi = 254.0!
        Me.tableCell19.Name = "tableCell19"
        Me.tableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell19.Weight = 0.16613772492259121R
        Me.tableCell19.WordWrap = False
        '
        'tableCell20
        '
        Me.tableCell20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_AA", "{0:n2}")})
        Me.tableCell20.Dpi = 254.0!
        Me.tableCell20.Name = "tableCell20"
        Me.tableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell20.Weight = 0.17042957756190469R
        Me.tableCell20.WordWrap = False
        '
        'tableCell21
        '
        Me.tableCell21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_CF", "{0:n2}")})
        Me.tableCell21.Dpi = 254.0!
        Me.tableCell21.Name = "tableCell21"
        Me.tableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell21.Weight = 0.16400157556038494R
        Me.tableCell21.WordWrap = False
        '
        'groupFooterBand2
        '
        Me.groupFooterBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine3, Me.table6})
        Me.groupFooterBand2.Dpi = 254.0!
        Me.groupFooterBand2.HeightF = 119.5625!
        Me.groupFooterBand2.Level = 1
        Me.groupFooterBand2.Name = "groupFooterBand2"
        Me.groupFooterBand2.StyleName = "ReportGroupFooterBandStyle"
        '
        'table6
        '
        Me.table6.BackColor = System.Drawing.Color.Transparent
        Me.table6.Dpi = 254.0!
        Me.table6.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table6.LocationFloat = New DevExpress.Utils.PointFloat(1136.42!, 27.91664!)
        Me.table6.Name = "table6"
        Me.table6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow6})
        Me.table6.SizeF = New System.Drawing.SizeF(1679.58!, 64.0!)
        Me.table6.StylePriority.UseBackColor = False
        Me.table6.StylePriority.UseFont = False
        '
        'tableRow6
        '
        Me.tableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell41, Me.tableCell42, Me.tableCell43, Me.tableCell44, Me.tableCell45, Me.tableCell46, Me.tableCell47, Me.tableCell48, Me.tableCell49, Me.tableCell50, Me.tableCell51})
        Me.tableRow6.Dpi = 254.0!
        Me.tableRow6.Name = "tableRow6"
        Me.tableRow6.Weight = 10.46953028649871R
        '
        'tableCell41
        '
        Me.tableCell41.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_BF")})
        Me.tableCell41.Dpi = 254.0!
        Me.tableCell41.Name = "tableCell41"
        Me.tableCell41.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.IgnoreNullValues = True
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell41.Summary = XrSummary1
        Me.tableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell41.Weight = 0.12996210005782782R
        Me.tableCell41.WordWrap = False
        '
        'tableCell42
        '
        Me.tableCell42.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_ADD")})
        Me.tableCell42.Dpi = 254.0!
        Me.tableCell42.Name = "tableCell42"
        Me.tableCell42.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary2.FormatString = "{0:n2}"
        XrSummary2.IgnoreNullValues = True
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell42.Summary = XrSummary2
        Me.tableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell42.Weight = 0.12453066058304185R
        Me.tableCell42.WordWrap = False
        '
        'tableCell43
        '
        Me.tableCell43.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_DISP")})
        Me.tableCell43.Dpi = 254.0!
        Me.tableCell43.Name = "tableCell43"
        Me.tableCell43.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary3.FormatString = "{0:n2}"
        XrSummary3.IgnoreNullValues = True
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell43.Summary = XrSummary3
        Me.tableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell43.Weight = 0.12273704836875726R
        Me.tableCell43.WordWrap = False
        '
        'tableCell44
        '
        Me.tableCell44.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_CF")})
        Me.tableCell44.Dpi = 254.0!
        Me.tableCell44.Name = "tableCell44"
        Me.tableCell44.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary4.FormatString = "{0:n2}"
        XrSummary4.IgnoreNullValues = True
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell44.Summary = XrSummary4
        Me.tableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell44.Weight = 0.12095213674343247R
        Me.tableCell44.WordWrap = False
        '
        'tableCell45
        '
        Me.tableCell45.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_BF")})
        Me.tableCell45.Dpi = 254.0!
        Me.tableCell45.Name = "tableCell45"
        Me.tableCell45.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary5.FormatString = "{0:n2}"
        XrSummary5.IgnoreNullValues = True
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell45.Summary = XrSummary5
        Me.tableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell45.Weight = 0.12273717745761425R
        Me.tableCell45.WordWrap = False
        '
        'tableCell46
        '
        Me.tableCell46.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_ADD")})
        Me.tableCell46.Dpi = 254.0!
        Me.tableCell46.Name = "tableCell46"
        Me.tableCell46.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary6.FormatString = "{0:n2}"
        XrSummary6.IgnoreNullValues = True
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell46.Summary = XrSummary6
        Me.tableCell46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell46.Weight = 0.12519916013774696R
        Me.tableCell46.WordWrap = False
        '
        'tableCell47
        '
        Me.tableCell47.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_DISP")})
        Me.tableCell47.Dpi = 254.0!
        Me.tableCell47.Name = "tableCell47"
        Me.tableCell47.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary7.FormatString = "{0:n2}"
        XrSummary7.IgnoreNullValues = True
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell47.Summary = XrSummary7
        Me.tableCell47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell47.Weight = 0.1316202464256081R
        Me.tableCell47.WordWrap = False
        '
        'tableCell48
        '
        Me.tableCell48.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_TOTAL")})
        Me.tableCell48.Dpi = 254.0!
        Me.tableCell48.Name = "tableCell48"
        Me.tableCell48.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary8.IgnoreNullValues = True
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell48.Summary = XrSummary8
        Me.tableCell48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell48.Weight = 0.12481860618739923R
        Me.tableCell48.WordWrap = False
        '
        'tableCell49
        '
        Me.tableCell49.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_AI")})
        Me.tableCell49.Dpi = 254.0!
        Me.tableCell49.Name = "tableCell49"
        Me.tableCell49.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary9.FormatString = "{0:n2}"
        XrSummary9.IgnoreNullValues = True
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell49.Summary = XrSummary9
        Me.tableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell49.Weight = 0.13885375343481027R
        Me.tableCell49.WordWrap = False
        '
        'tableCell50
        '
        Me.tableCell50.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_AA")})
        Me.tableCell50.Dpi = 254.0!
        Me.tableCell50.Name = "tableCell50"
        Me.tableCell50.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary10.FormatString = "{0:n2}"
        XrSummary10.IgnoreNullValues = True
        XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell50.Summary = XrSummary10
        Me.tableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell50.Weight = 0.1424405647790371R
        Me.tableCell50.WordWrap = False
        '
        'tableCell51
        '
        Me.tableCell51.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_CF")})
        Me.tableCell51.Dpi = 254.0!
        Me.tableCell51.Name = "tableCell51"
        Me.tableCell51.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary11.FormatString = "{0:n2}"
        XrSummary11.IgnoreNullValues = True
        XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell51.Summary = XrSummary11
        Me.tableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell51.Weight = 0.13706761546534421R
        Me.tableCell51.WordWrap = False
        '
        'groupFooterBand3
        '
        Me.groupFooterBand3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrLine1, Me.table7})
        Me.groupFooterBand3.Dpi = 254.0!
        Me.groupFooterBand3.HeightF = 146.0208!
        Me.groupFooterBand3.Level = 2
        Me.groupFooterBand3.Name = "groupFooterBand3"
        Me.groupFooterBand3.StyleName = "ReportGroupFooterBandStyle"
        '
        'table7
        '
        Me.table7.BackColor = System.Drawing.Color.Transparent
        Me.table7.Dpi = 254.0!
        Me.table7.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table7.LocationFloat = New DevExpress.Utils.PointFloat(1136.421!, 27.91658!)
        Me.table7.Name = "table7"
        Me.table7.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow7})
        Me.table7.SizeF = New System.Drawing.SizeF(1679.58!, 64.0!)
        Me.table7.StylePriority.UseBackColor = False
        Me.table7.StylePriority.UseFont = False
        '
        'tableRow7
        '
        Me.tableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell56, Me.tableCell57, Me.tableCell58, Me.tableCell59, Me.tableCell60, Me.tableCell61, Me.tableCell62, Me.tableCell63, Me.tableCell64, Me.tableCell65, Me.tableCell66})
        Me.tableRow7.Dpi = 254.0!
        Me.tableRow7.Name = "tableRow7"
        Me.tableRow7.Weight = 10.46953028649871R
        '
        'tableCell56
        '
        Me.tableCell56.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_BF")})
        Me.tableCell56.Dpi = 254.0!
        Me.tableCell56.Name = "tableCell56"
        Me.tableCell56.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary12.FormatString = "{0:n2}"
        XrSummary12.IgnoreNullValues = True
        XrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell56.Summary = XrSummary12
        Me.tableCell56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell56.Weight = 0.1249823964752102R
        Me.tableCell56.WordWrap = False
        '
        'tableCell57
        '
        Me.tableCell57.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_ADD")})
        Me.tableCell57.Dpi = 254.0!
        Me.tableCell57.Name = "tableCell57"
        Me.tableCell57.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary13.FormatString = "{0:n2}"
        XrSummary13.IgnoreNullValues = True
        XrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell57.Summary = XrSummary13
        Me.tableCell57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell57.Weight = 0.11975907120140522R
        Me.tableCell57.WordWrap = False
        '
        'tableCell58
        '
        Me.tableCell58.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_DISP")})
        Me.tableCell58.Dpi = 254.0!
        Me.tableCell58.Name = "tableCell58"
        Me.tableCell58.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary14.FormatString = "{0:n2}"
        XrSummary14.IgnoreNullValues = True
        XrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell58.Summary = XrSummary14
        Me.tableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell58.Weight = 0.11803418407824579R
        Me.tableCell58.WordWrap = False
        '
        'tableCell59
        '
        Me.tableCell59.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_CF")})
        Me.tableCell59.Dpi = 254.0!
        Me.tableCell59.Name = "tableCell59"
        Me.tableCell59.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary15.FormatString = "{0:n2}"
        XrSummary15.IgnoreNullValues = True
        XrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell59.Summary = XrSummary15
        Me.tableCell59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell59.Weight = 0.11631766416720801R
        Me.tableCell59.WordWrap = False
        '
        'tableCell60
        '
        Me.tableCell60.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_BF")})
        Me.tableCell60.Dpi = 254.0!
        Me.tableCell60.Name = "tableCell60"
        Me.tableCell60.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary16.FormatString = "{0:n2}"
        XrSummary16.IgnoreNullValues = True
        XrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell60.Summary = XrSummary16
        Me.tableCell60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell60.Weight = 0.11803440753494937R
        Me.tableCell60.WordWrap = False
        '
        'tableCell61
        '
        Me.tableCell61.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_ADD")})
        Me.tableCell61.Dpi = 254.0!
        Me.tableCell61.Name = "tableCell61"
        Me.tableCell61.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary17.FormatString = "{0:n2}"
        XrSummary17.IgnoreNullValues = True
        XrSummary17.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell61.Summary = XrSummary17
        Me.tableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell61.Weight = 0.12040185682340365R
        Me.tableCell61.WordWrap = False
        '
        'tableCell62
        '
        Me.tableCell62.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_DISP")})
        Me.tableCell62.Dpi = 254.0!
        Me.tableCell62.Name = "tableCell62"
        Me.tableCell62.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary18.FormatString = "{0:n2}"
        XrSummary18.IgnoreNullValues = True
        XrSummary18.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell62.Summary = XrSummary18
        Me.tableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell62.Weight = 0.12657700834020477R
        Me.tableCell62.WordWrap = False
        '
        'tableCell63
        '
        Me.tableCell63.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_TOTAL")})
        Me.tableCell63.Dpi = 254.0!
        Me.tableCell63.Name = "tableCell63"
        Me.tableCell63.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary19.IgnoreNullValues = True
        XrSummary19.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell63.Summary = XrSummary19
        Me.tableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell63.Weight = 0.12003618234231928R
        Me.tableCell63.WordWrap = False
        '
        'tableCell64
        '
        Me.tableCell64.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_AI")})
        Me.tableCell64.Dpi = 254.0!
        Me.tableCell64.Name = "tableCell64"
        Me.tableCell64.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary20.FormatString = "{0:n2}"
        XrSummary20.IgnoreNullValues = True
        XrSummary20.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell64.Summary = XrSummary20
        Me.tableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell64.Weight = 0.13353335207832567R
        Me.tableCell64.WordWrap = False
        '
        'tableCell65
        '
        Me.tableCell65.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_AA")})
        Me.tableCell65.Dpi = 254.0!
        Me.tableCell65.Name = "tableCell65"
        Me.tableCell65.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary21.FormatString = "{0:n2}"
        XrSummary21.IgnoreNullValues = True
        XrSummary21.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell65.Summary = XrSummary21
        Me.tableCell65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell65.Weight = 0.13698332495282534R
        Me.tableCell65.WordWrap = False
        '
        'tableCell66
        '
        Me.tableCell66.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_CF")})
        Me.tableCell66.Dpi = 254.0!
        Me.tableCell66.Name = "tableCell66"
        Me.tableCell66.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary22.FormatString = "{0:n2}"
        XrSummary22.IgnoreNullValues = True
        XrSummary22.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell66.Summary = XrSummary22
        Me.tableCell66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell66.Weight = 0.13181485829973988R
        Me.tableCell66.WordWrap = False
        '
        'reportFooterBand1
        '
        Me.reportFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel6, Me.XrLine5, Me.XrLine4, Me.table8})
        Me.reportFooterBand1.Dpi = 254.0!
        Me.reportFooterBand1.HeightF = 180.4166!
        Me.reportFooterBand1.Name = "reportFooterBand1"
        Me.reportFooterBand1.StyleName = "ReportFooterBandStyle"
        '
        'table8
        '
        Me.table8.BackColor = System.Drawing.Color.Transparent
        Me.table8.Dpi = 254.0!
        Me.table8.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table8.LocationFloat = New DevExpress.Utils.PointFloat(1136.42!, 66.14584!)
        Me.table8.Name = "table8"
        Me.table8.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow8})
        Me.table8.SizeF = New System.Drawing.SizeF(1679.58!, 64.0!)
        Me.table8.StylePriority.UseBackColor = False
        Me.table8.StylePriority.UseFont = False
        '
        'tableRow8
        '
        Me.tableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell71, Me.tableCell72, Me.tableCell73, Me.tableCell74, Me.tableCell75, Me.tableCell76, Me.tableCell77, Me.tableCell78, Me.tableCell79, Me.tableCell80, Me.tableCell81})
        Me.tableRow8.Dpi = 254.0!
        Me.tableRow8.Name = "tableRow8"
        Me.tableRow8.Weight = 10.46953028649871R
        '
        'tableCell71
        '
        Me.tableCell71.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_BF")})
        Me.tableCell71.Dpi = 254.0!
        Me.tableCell71.Name = "tableCell71"
        Me.tableCell71.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary23.FormatString = "{0:n2}"
        XrSummary23.IgnoreNullValues = True
        XrSummary23.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell71.Summary = XrSummary23
        Me.tableCell71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell71.Weight = 0.12398591317468616R
        Me.tableCell71.WordWrap = False
        '
        'tableCell72
        '
        Me.tableCell72.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_ADD")})
        Me.tableCell72.Dpi = 254.0!
        Me.tableCell72.Name = "tableCell72"
        Me.tableCell72.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary24.FormatString = "{0:n2}"
        XrSummary24.IgnoreNullValues = True
        XrSummary24.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell72.Summary = XrSummary24
        Me.tableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell72.Weight = 0.11880413177490595R
        Me.tableCell72.WordWrap = False
        '
        'tableCell73
        '
        Me.tableCell73.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_DISP")})
        Me.tableCell73.Dpi = 254.0!
        Me.tableCell73.Name = "tableCell73"
        Me.tableCell73.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary25.FormatString = "{0:n2}"
        XrSummary25.IgnoreNullValues = True
        XrSummary25.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell73.Summary = XrSummary25
        Me.tableCell73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell73.Weight = 0.11709348873955303R
        Me.tableCell73.WordWrap = False
        '
        'tableCell74
        '
        Me.tableCell74.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "QC_CF")})
        Me.tableCell74.Dpi = 254.0!
        Me.tableCell74.Name = "tableCell74"
        Me.tableCell74.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary26.FormatString = "{0:n2}"
        XrSummary26.IgnoreNullValues = True
        XrSummary26.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell74.Summary = XrSummary26
        Me.tableCell74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell74.Weight = 0.11539023487817077R
        Me.tableCell74.WordWrap = False
        '
        'tableCell75
        '
        Me.tableCell75.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_BF")})
        Me.tableCell75.Dpi = 254.0!
        Me.tableCell75.Name = "tableCell75"
        Me.tableCell75.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary27.FormatString = "{0:n2}"
        XrSummary27.IgnoreNullValues = True
        XrSummary27.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell75.Summary = XrSummary27
        Me.tableCell75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell75.Weight = 0.11709329169491386R
        Me.tableCell75.WordWrap = False
        '
        'tableCell76
        '
        Me.tableCell76.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_ADD")})
        Me.tableCell76.Dpi = 254.0!
        Me.tableCell76.Name = "tableCell76"
        Me.tableCell76.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary28.FormatString = "{0:n2}"
        XrSummary28.IgnoreNullValues = True
        XrSummary28.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell76.Summary = XrSummary28
        Me.tableCell76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell76.Weight = 0.11944196527204781R
        Me.tableCell76.WordWrap = False
        '
        'tableCell77
        '
        Me.tableCell77.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_DISP")})
        Me.tableCell77.Dpi = 254.0!
        Me.tableCell77.Name = "tableCell77"
        Me.tableCell77.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary29.FormatString = "{0:n2}"
        XrSummary29.IgnoreNullValues = True
        XrSummary29.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell77.Summary = XrSummary29
        Me.tableCell77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell77.Weight = 0.12556787374534115R
        Me.tableCell77.WordWrap = False
        '
        'tableCell78
        '
        Me.tableCell78.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_TOTAL")})
        Me.tableCell78.Dpi = 254.0!
        Me.tableCell78.Name = "tableCell78"
        Me.tableCell78.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary30.IgnoreNullValues = True
        XrSummary30.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell78.Summary = XrSummary30
        Me.tableCell78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell78.Weight = 0.11907939082060061R
        Me.tableCell78.WordWrap = False
        '
        'tableCell79
        '
        Me.tableCell79.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_AI")})
        Me.tableCell79.Dpi = 254.0!
        Me.tableCell79.Name = "tableCell79"
        Me.tableCell79.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary31.FormatString = "{0:n2}"
        XrSummary31.IgnoreNullValues = True
        XrSummary31.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell79.Summary = XrSummary31
        Me.tableCell79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell79.Weight = 0.13246857405532136R
        Me.tableCell79.WordWrap = False
        '
        'tableCell80
        '
        Me.tableCell80.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_AA")})
        Me.tableCell80.Dpi = 254.0!
        Me.tableCell80.Name = "tableCell80"
        Me.tableCell80.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary32.FormatString = "{0:n2}"
        XrSummary32.IgnoreNullValues = True
        XrSummary32.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell80.Summary = XrSummary32
        Me.tableCell80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell80.Weight = 0.13589005717066638R
        Me.tableCell80.WordWrap = False
        '
        'tableCell81
        '
        Me.tableCell81.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_CF")})
        Me.tableCell81.Dpi = 254.0!
        Me.tableCell81.Name = "tableCell81"
        Me.tableCell81.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary33.FormatString = "{0:n2}"
        XrSummary33.IgnoreNullValues = True
        XrSummary33.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell81.Summary = XrSummary33
        Me.tableCell81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell81.Weight = 0.13076533250922906R
        Me.tableCell81.WordWrap = False
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
        'tableCell4
        '
        Me.tableCell4.BackColor = System.Drawing.Color.Transparent
        Me.tableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_PURCHASE_YEAR")})
        Me.tableCell4.Dpi = 254.0!
        Me.tableCell4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell4.Name = "tableCell4"
        Me.tableCell4.StylePriority.UseBackColor = False
        Me.tableCell4.StylePriority.UseFont = False
        Me.tableCell4.Weight = 1.8949707245102714R
        Me.tableCell4.WordWrap = False
        '
        'tableRow2
        '
        Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell4})
        Me.tableRow2.Dpi = 254.0!
        Me.tableRow2.Name = "tableRow2"
        Me.tableRow2.Weight = 10.46953028649871R
        '
        'table2
        '
        Me.table2.Dpi = 254.0!
        Me.table2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table2.Name = "table2"
        Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2})
        Me.table2.SizeF = New System.Drawing.SizeF(2816.0!, 64.0!)
        Me.table2.StylePriority.UseFont = False
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
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(2562.0!, 24.99993!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(254.0!, 58.42!)
        '
        'XrLine4
        '
        Me.XrLine4.BackColor = System.Drawing.Color.Transparent
        Me.XrLine4.Dpi = 254.0!
        Me.XrLine4.LineWidth = 3
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(1136.42!, 24.99993!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.SizeF = New System.Drawing.SizeF(1679.58!, 27.91664!)
        Me.XrLine4.StylePriority.UseBackColor = False
        '
        'XrLine5
        '
        Me.XrLine5.BackColor = System.Drawing.Color.Transparent
        Me.XrLine5.Dpi = 254.0!
        Me.XrLine5.LineWidth = 6
        Me.XrLine5.LocationFloat = New DevExpress.Utils.PointFloat(1136.42!, 130.1458!)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.SizeF = New System.Drawing.SizeF(1679.58!, 30.03333!)
        Me.XrLine5.StylePriority.UseBackColor = False
        '
        'XrLine1
        '
        Me.XrLine1.BackColor = System.Drawing.Color.Transparent
        Me.XrLine1.Dpi = 254.0!
        Me.XrLine1.LineWidth = 3
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(1136.42!, 0.0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(1679.58!, 27.91664!)
        Me.XrLine1.StylePriority.UseBackColor = False
        '
        'XrLine2
        '
        Me.XrLine2.BackColor = System.Drawing.Color.Transparent
        Me.XrLine2.Dpi = 254.0!
        Me.XrLine2.LineWidth = 6
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(1136.42!, 91.91655!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(1679.58!, 30.03333!)
        Me.XrLine2.StylePriority.UseBackColor = False
        '
        'XrLine3
        '
        Me.XrLine3.BackColor = System.Drawing.Color.Transparent
        Me.XrLine3.Dpi = 254.0!
        Me.XrLine3.LineWidth = 3
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(1136.42!, 0.0!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(1679.581!, 27.91664!)
        Me.XrLine3.StylePriority.UseBackColor = False
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(760.7147!, 25.00001!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(137.5833!, 58.41999!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "NAME :"
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(760.7119!, 181.8217!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(1294.576!, 58.42001!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "SCHEDULE OF CAPITAL ALLOWANCES"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(760.7147!, 102.235!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(939.2714!, 58.42!)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "INCOME TAX COMPUTATION - YEAR OF ASSESSMENT "
        '
        'XrLabel6
        '
        Me.XrLabel6.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel6.Dpi = 254.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(13.22917!, 66.14584!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(182.5625!, 63.99995!)
        Me.XrLabel6.StylePriority.UseBackColor = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.Text = "TOTAL"
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
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramYA, "Text", "")})
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(1699.986!, 102.235!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(254.0!, 58.42!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "XrLabel4"
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramCompanyName, "Text", "")})
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(898.298!, 25.00001!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(1156.99!, 58.42!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "XrLabel5"
        '
        'rpt_CAByRate
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.topMarginBand1, Me.pageHeaderBand1, Me.groupHeaderBand1, Me.groupHeaderBand2, Me.groupHeaderBand3, Me.detailBand1, Me.groupFooterBand2, Me.groupFooterBand3, Me.reportFooterBand1, Me.bottomMarginBand1, Me.PageFooter})
        Me.DataSource = Me.CAREPORTTEMPBindingSource
        Me.Dpi = 254.0!
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(69, 85, 100, 100)
        Me.PageHeight = 2100
        Me.PageWidth = 2970
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.paramCompanyName, Me.paramYA})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.RequestParameters = False
        Me.SnapGridSize = 25.0!
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.ReportHeaderBandStyle, Me.ReportGroupHeaderBandStyle, Me.ReportDetailBandStyle, Me.ReportGroupFooterBandStyle, Me.ReportFooterBandStyle, Me.ReportOddStyle, Me.ReportEvenStyle})
        Me.Version = "17.1"
        CType(Me.table3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAREPORTTEMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
End Class