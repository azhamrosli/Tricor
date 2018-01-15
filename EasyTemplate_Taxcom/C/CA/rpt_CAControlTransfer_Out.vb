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
    Friend WithEvents table6 As DevExpress.XtraReports.UI.XRTable
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
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paramYA As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paramCompanyName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
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
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramYA = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramCompanyName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.groupFooterBand1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.table6 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.groupFooterBand2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.groupFooterBand3 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
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
        Me.ReportHeaderBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportGroupHeaderBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportDetailBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportGroupFooterBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportFooterBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportOddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportEvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.CAREPORTDISPOSALTEMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCA = New EasyTemplate_Taxcom.dsCA()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table6, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.table1, Me.XrLabel1})
        Me.pageHeaderBand1.Dpi = 254.0!
        Me.pageHeaderBand1.HeightF = 402.6667!
        Me.pageHeaderBand1.Name = "pageHeaderBand1"
        Me.pageHeaderBand1.StyleName = "ReportHeaderBandStyle"
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramYA, "Text", "")})
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(945.75!, 99.29501!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(254.0!, 58.42!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "XrLabel5"
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
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(181.1042!, 40.87501!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(1397.0!, 58.42!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "XrLabel4"
        '
        'paramCompanyName
        '
        Me.paramCompanyName.Description = "paramCompanyName"
        Me.paramCompanyName.Name = "paramCompanyName"
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(25.00001!, 157.715!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(1640.416!, 58.42001!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "CONTROLLED TRANSFER OF PROPERTY, PLANT AND EQUIPMENT TO RELATED COMPANIES"
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(25.00001!, 99.29501!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(920.75!, 58.42!)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "INCOME TAX COMPUTATION - YEAR OF ASSESSMENT "
        '
        'table1
        '
        Me.table1.Dpi = 254.0!
        Me.table1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 243.4167!)
        Me.table1.Name = "table1"
        Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
        Me.table1.SizeF = New System.Drawing.SizeF(2785.0!, 159.25!)
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
        Me.tableCell1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tableCell1.Dpi = 254.0!
        Me.tableCell1.Name = "tableCell1"
        Me.tableCell1.StylePriority.UseBackColor = False
        Me.tableCell1.StylePriority.UseTextAlignment = False
        Me.tableCell1.Text = "Description"
        Me.tableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        Me.tableCell1.Weight = 0.71102961903994844R
        '
        'tableCell2
        '
        Me.tableCell2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tableCell2.Dpi = 254.0!
        Me.tableCell2.Name = "tableCell2"
        Me.tableCell2.StylePriority.UseBackColor = False
        Me.tableCell2.StylePriority.UseTextAlignment = False
        Me.tableCell2.Text = "Year of Purchase"
        Me.tableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell2.Weight = 0.15551166337789948R
        '
        'tableCell3
        '
        Me.tableCell3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tableCell3.Dpi = 254.0!
        Me.tableCell3.Multiline = True
        Me.tableCell3.Name = "tableCell3"
        Me.tableCell3.StylePriority.UseBackColor = False
        Me.tableCell3.StylePriority.UseTextAlignment = False
        Me.tableCell3.Text = "Cost" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RM"
        Me.tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell3.Weight = 0.25101549076460483R
        '
        'tableCell4
        '
        Me.tableCell4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tableCell4.Dpi = 254.0!
        Me.tableCell4.Name = "tableCell4"
        Me.tableCell4.StylePriority.UseBackColor = False
        Me.tableCell4.StylePriority.UseTextAlignment = False
        Me.tableCell4.Text = "Accumulated Depreciation RM"
        Me.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell4.Weight = 0.25101549076460483R
        '
        'tableCell5
        '
        Me.tableCell5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tableCell5.Dpi = 254.0!
        Me.tableCell5.Multiline = True
        Me.tableCell5.Name = "tableCell5"
        Me.tableCell5.StylePriority.UseBackColor = False
        Me.tableCell5.StylePriority.UseTextAlignment = False
        Me.tableCell5.Text = "W.D.V" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RM"
        Me.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell5.Weight = 0.25101549076460483R
        '
        'tableCell6
        '
        Me.tableCell6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tableCell6.Dpi = 254.0!
        Me.tableCell6.Name = "tableCell6"
        Me.tableCell6.StylePriority.UseBackColor = False
        Me.tableCell6.StylePriority.UseTextAlignment = False
        Me.tableCell6.Text = "Disposal Value RM"
        Me.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell6.Weight = 0.25101549076460483R
        '
        'tableCell7
        '
        Me.tableCell7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tableCell7.Dpi = 254.0!
        Me.tableCell7.Name = "tableCell7"
        Me.tableCell7.StylePriority.UseBackColor = False
        Me.tableCell7.StylePriority.UseTextAlignment = False
        Me.tableCell7.Text = "Proft / (Loss) RM"
        Me.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell7.Weight = 0.25101549076460483R
        '
        'tableCell8
        '
        Me.tableCell8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tableCell8.Dpi = 254.0!
        Me.tableCell8.Multiline = True
        Me.tableCell8.Name = "tableCell8"
        Me.tableCell8.StylePriority.UseBackColor = False
        Me.tableCell8.StylePriority.UseTextAlignment = False
        Me.tableCell8.Text = "Rate of AA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%"
        Me.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell8.Weight = 0.15551166337789948R
        '
        'tableCell9
        '
        Me.tableCell9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tableCell9.Dpi = 254.0!
        Me.tableCell9.Multiline = True
        Me.tableCell9.Name = "tableCell9"
        Me.tableCell9.StylePriority.UseBackColor = False
        Me.tableCell9.StylePriority.UseTextAlignment = False
        Me.tableCell9.Text = "Tax W.D.V" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RM"
        Me.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell9.Weight = 0.25101549076460483R
        '
        'tableCell10
        '
        Me.tableCell10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tableCell10.Dpi = 254.0!
        Me.tableCell10.Name = "tableCell10"
        Me.tableCell10.StylePriority.UseBackColor = False
        Me.tableCell10.StylePriority.UseTextAlignment = False
        Me.tableCell10.Text = "Balancing Charge / (Allowance) RM"
        Me.tableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell10.Weight = 0.25101549076460483R
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(25.00001!, 40.87501!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(156.1042!, 58.42!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "NAME : "
        '
        'groupHeaderBand1
        '
        Me.groupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2})
        Me.groupHeaderBand1.Dpi = 254.0!
        Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CA_CATEGORY_CODE", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.groupHeaderBand1.HeightF = 64.0!
        Me.groupHeaderBand1.Name = "groupHeaderBand1"
        Me.groupHeaderBand1.StyleName = "ReportGroupHeaderBandStyle"
        '
        'table2
        '
        Me.table2.Dpi = 254.0!
        Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table2.Name = "table2"
        Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2})
        Me.table2.SizeF = New System.Drawing.SizeF(2785.0!, 64.0!)
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
        Me.tableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_CATEGORY_CODE")})
        Me.tableCell12.Dpi = 254.0!
        Me.tableCell12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell12.Name = "tableCell12"
        Me.tableCell12.StylePriority.UseBackColor = False
        Me.tableCell12.StylePriority.UseFont = False
        Me.tableCell12.Weight = 0.47368690649086403R
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
        Me.table4.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table4.Name = "table4"
        Me.table4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow4})
        Me.table4.SizeF = New System.Drawing.SizeF(2785.0!, 64.0!)
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
        Me.tableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_TRANSFERROR_NAME")})
        Me.tableCell16.Dpi = 254.0!
        Me.tableCell16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell16.Name = "tableCell16"
        Me.tableCell16.StylePriority.UseBackColor = False
        Me.tableCell16.StylePriority.UseFont = False
        Me.tableCell16.Weight = 0.94651511209479644R
        Me.tableCell16.WordWrap = False
        '
        'detailBand1
        '
        Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table5})
        Me.detailBand1.Dpi = 254.0!
        Me.detailBand1.EvenStyleName = "ReportEvenStyle"
        Me.detailBand1.HeightF = 64.0!
        Me.detailBand1.Name = "detailBand1"
        Me.detailBand1.OddStyleName = "ReportOddStyle"
        Me.detailBand1.StyleName = "ReportDetailBandStyle"
        '
        'table5
        '
        Me.table5.Dpi = 254.0!
        Me.table5.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table5.Name = "table5"
        Me.table5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow5})
        Me.table5.SizeF = New System.Drawing.SizeF(2785.0!, 64.0!)
        '
        'tableRow5
        '
        Me.tableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell17, Me.tableCell18, Me.tableCell19, Me.tableCell20, Me.tableCell21, Me.tableCell22, Me.tableCell23, Me.tableCell24, Me.tableCell25, Me.tableCell26})
        Me.tableRow5.Dpi = 254.0!
        Me.tableRow5.Name = "tableRow5"
        Me.tableRow5.Weight = 10.46953028649871R
        '
        'tableCell17
        '
        Me.tableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_ASSET")})
        Me.tableCell17.Dpi = 254.0!
        Me.tableCell17.Name = "tableCell17"
        Me.tableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.tableCell17.Weight = 0.71983265199363689R
        Me.tableCell17.WordWrap = False
        '
        'tableCell18
        '
        Me.tableCell18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_PURCHASE_YEAR")})
        Me.tableCell18.Dpi = 254.0!
        Me.tableCell18.Name = "tableCell18"
        Me.tableCell18.StylePriority.UseTextAlignment = False
        Me.tableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell18.Weight = 0.15743706463990251R
        Me.tableCell18.WordWrap = False
        '
        'tableCell19
        '
        Me.tableCell19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_QUALIFYING_COST", "{0:n2}")})
        Me.tableCell19.Dpi = 254.0!
        Me.tableCell19.Name = "tableCell19"
        Me.tableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell19.Weight = 0.25412308105366627R
        Me.tableCell19.WordWrap = False
        '
        'tableCell20
        '
        Me.tableCell20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DISP_DEPRECIATION", "{0:n2}")})
        Me.tableCell20.Dpi = 254.0!
        Me.tableCell20.Name = "tableCell20"
        Me.tableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell20.Weight = 0.2541229577311348R
        Me.tableCell20.WordWrap = False
        '
        'tableCell21
        '
        Me.tableCell21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DISP_WDV", "{0:n2}")})
        Me.tableCell21.Dpi = 254.0!
        Me.tableCell21.Name = "tableCell21"
        Me.tableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell21.Weight = 0.25412332769872947R
        Me.tableCell21.WordWrap = False
        '
        'tableCell22
        '
        Me.tableCell22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DISP_DISPOSAL_VALUE", "{0:n2}")})
        Me.tableCell22.Dpi = 254.0!
        Me.tableCell22.Name = "tableCell22"
        Me.tableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell22.Weight = 0.25412320437619784R
        Me.tableCell22.WordWrap = False
        '
        'tableCell23
        '
        Me.tableCell23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DISP_PNL", "{0:n2}")})
        Me.tableCell23.Dpi = 254.0!
        Me.tableCell23.Name = "tableCell23"
        Me.tableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell23.Weight = 0.25412332769872936R
        Me.tableCell23.WordWrap = False
        '
        'tableCell24
        '
        Me.tableCell24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_RATE_AA", "{0:n0}")})
        Me.tableCell24.Dpi = 254.0!
        Me.tableCell24.Name = "tableCell24"
        Me.tableCell24.StylePriority.UseTextAlignment = False
        Me.tableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell24.Weight = 0.15743681799483938R
        Me.tableCell24.WordWrap = False
        '
        'tableCell25
        '
        Me.tableCell25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DISP_TWDV", "{0:n2}")})
        Me.tableCell25.Dpi = 254.0!
        Me.tableCell25.Name = "tableCell25"
        Me.tableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell25.Weight = 0.25412332769872942R
        Me.tableCell25.WordWrap = False
        '
        'tableCell26
        '
        Me.tableCell26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DISP_BABC", "{0:n2}")})
        Me.tableCell26.Dpi = 254.0!
        Me.tableCell26.Name = "tableCell26"
        Me.tableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell26.Weight = 0.25412326603746366R
        Me.tableCell26.WordWrap = False
        '
        'groupFooterBand1
        '
        Me.groupFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.table6})
        Me.groupFooterBand1.Dpi = 254.0!
        Me.groupFooterBand1.HeightF = 198.9375!
        Me.groupFooterBand1.Name = "groupFooterBand1"
        Me.groupFooterBand1.StyleName = "ReportGroupFooterBandStyle"
        '
        'XrLine1
        '
        Me.XrLine1.BackColor = System.Drawing.Color.Transparent
        Me.XrLine1.Dpi = 254.0!
        Me.XrLine1.LineWidth = 3
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(856.1877!, 13.22917!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(1928.813!, 13.22917!)
        Me.XrLine1.StylePriority.UseBackColor = False
        '
        'table6
        '
        Me.table6.Dpi = 254.0!
        Me.table6.LocationFloat = New DevExpress.Utils.PointFloat(868.3618!, 35.85413!)
        Me.table6.Name = "table6"
        Me.table6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow6})
        Me.table6.SizeF = New System.Drawing.SizeF(1916.638!, 64.0!)
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
        Me.tableCell29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_QUALIFYING_COST")})
        Me.tableCell29.Dpi = 254.0!
        Me.tableCell29.Name = "tableCell29"
        Me.tableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell29.StylePriority.UseBackColor = False
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.IgnoreNullValues = True
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell29.Summary = XrSummary1
        Me.tableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell29.Weight = 0.25041136170803457R
        Me.tableCell29.WordWrap = False
        '
        'tableCell30
        '
        Me.tableCell30.BackColor = System.Drawing.Color.Transparent
        Me.tableCell30.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DISP_DEPRECIATION")})
        Me.tableCell30.Dpi = 254.0!
        Me.tableCell30.Name = "tableCell30"
        Me.tableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell30.StylePriority.UseBackColor = False
        XrSummary2.FormatString = "{0:n2}"
        XrSummary2.IgnoreNullValues = True
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell30.Summary = XrSummary2
        Me.tableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell30.Weight = 0.25041136170803457R
        Me.tableCell30.WordWrap = False
        '
        'tableCell31
        '
        Me.tableCell31.BackColor = System.Drawing.Color.Transparent
        Me.tableCell31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DISP_WDV")})
        Me.tableCell31.Dpi = 254.0!
        Me.tableCell31.Name = "tableCell31"
        Me.tableCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell31.StylePriority.UseBackColor = False
        XrSummary3.FormatString = "{0:n2}"
        XrSummary3.IgnoreNullValues = True
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell31.Summary = XrSummary3
        Me.tableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell31.Weight = 0.25041124018681626R
        Me.tableCell31.WordWrap = False
        '
        'tableCell32
        '
        Me.tableCell32.BackColor = System.Drawing.Color.Transparent
        Me.tableCell32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DISP_DISPOSAL_VALUE")})
        Me.tableCell32.Dpi = 254.0!
        Me.tableCell32.Name = "tableCell32"
        Me.tableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell32.StylePriority.UseBackColor = False
        XrSummary4.FormatString = "{0:n2}"
        XrSummary4.IgnoreNullValues = True
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell32.Summary = XrSummary4
        Me.tableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell32.Weight = 0.25041148322925288R
        Me.tableCell32.WordWrap = False
        '
        'tableCell33
        '
        Me.tableCell33.BackColor = System.Drawing.Color.Transparent
        Me.tableCell33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DISP_PNL")})
        Me.tableCell33.Dpi = 254.0!
        Me.tableCell33.Name = "tableCell33"
        Me.tableCell33.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell33.StylePriority.UseBackColor = False
        XrSummary5.FormatString = "{0:n2}"
        XrSummary5.IgnoreNullValues = True
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell33.Summary = XrSummary5
        Me.tableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell33.Weight = 0.25041148322925283R
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
        Me.tableCell34.Weight = 0.15513754174739336R
        Me.tableCell34.WordWrap = False
        '
        'tableCell35
        '
        Me.tableCell35.BackColor = System.Drawing.Color.Transparent
        Me.tableCell35.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DISP_TWDV")})
        Me.tableCell35.Dpi = 254.0!
        Me.tableCell35.Name = "tableCell35"
        Me.tableCell35.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell35.StylePriority.UseBackColor = False
        XrSummary6.FormatString = "{0:n2}"
        XrSummary6.IgnoreNullValues = True
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell35.Summary = XrSummary6
        Me.tableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell35.Weight = 0.25041148322925283R
        Me.tableCell35.WordWrap = False
        '
        'tableCell36
        '
        Me.tableCell36.BackColor = System.Drawing.Color.Transparent
        Me.tableCell36.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DISP_BABC")})
        Me.tableCell36.Dpi = 254.0!
        Me.tableCell36.Name = "tableCell36"
        Me.tableCell36.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        Me.tableCell36.StylePriority.UseBackColor = False
        XrSummary7.FormatString = "{0:n2}"
        XrSummary7.IgnoreNullValues = True
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell36.Summary = XrSummary7
        Me.tableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell36.Weight = 0.25041108828529346R
        Me.tableCell36.WordWrap = False
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
        Me.groupFooterBand3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine3, Me.XrLine2, Me.table8})
        Me.groupFooterBand3.Dpi = 254.0!
        Me.groupFooterBand3.HeightF = 119.5625!
        Me.groupFooterBand3.Level = 2
        Me.groupFooterBand3.Name = "groupFooterBand3"
        Me.groupFooterBand3.StyleName = "ReportGroupFooterBandStyle"
        '
        'XrLine3
        '
        Me.XrLine3.BackColor = System.Drawing.Color.Transparent
        Me.XrLine3.Dpi = 254.0!
        Me.XrLine3.LineWidth = 5
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(856.1877!, 94.56255!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(1928.813!, 24.99992!)
        Me.XrLine3.StylePriority.UseBackColor = False
        '
        'XrLine2
        '
        Me.XrLine2.BackColor = System.Drawing.Color.Transparent
        Me.XrLine2.Dpi = 254.0!
        Me.XrLine2.LineWidth = 3
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(856.1873!, 17.33324!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(1928.813!, 13.22917!)
        Me.XrLine2.StylePriority.UseBackColor = False
        '
        'table8
        '
        Me.table8.Dpi = 254.0!
        Me.table8.LocationFloat = New DevExpress.Utils.PointFloat(868.3618!, 30.56247!)
        Me.table8.Name = "table8"
        Me.table8.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow8})
        Me.table8.SizeF = New System.Drawing.SizeF(1916.638!, 64.0!)
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
        Me.tableCell49.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_QUALIFYING_COST")})
        Me.tableCell49.Dpi = 254.0!
        Me.tableCell49.Name = "tableCell49"
        Me.tableCell49.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        Me.tableCell49.StylePriority.UseBackColor = False
        XrSummary8.FormatString = "{0:n2}"
        XrSummary8.IgnoreNullValues = True
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell49.Summary = XrSummary8
        Me.tableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell49.Weight = 0.2294148928744866R
        Me.tableCell49.WordWrap = False
        '
        'tableCell50
        '
        Me.tableCell50.BackColor = System.Drawing.Color.Transparent
        Me.tableCell50.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DISP_DEPRECIATION")})
        Me.tableCell50.Dpi = 254.0!
        Me.tableCell50.Name = "tableCell50"
        Me.tableCell50.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        Me.tableCell50.StylePriority.UseBackColor = False
        XrSummary9.FormatString = "{0:n2}"
        XrSummary9.IgnoreNullValues = True
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell50.Summary = XrSummary9
        Me.tableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell50.Weight = 0.2294142248836249R
        Me.tableCell50.WordWrap = False
        '
        'tableCell51
        '
        Me.tableCell51.BackColor = System.Drawing.Color.Transparent
        Me.tableCell51.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DISP_WDV")})
        Me.tableCell51.Dpi = 254.0!
        Me.tableCell51.Name = "tableCell51"
        Me.tableCell51.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        Me.tableCell51.StylePriority.UseBackColor = False
        XrSummary10.FormatString = "{0:n2}"
        XrSummary10.IgnoreNullValues = True
        XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell51.Summary = XrSummary10
        Me.tableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell51.Weight = 0.22941489287448658R
        Me.tableCell51.WordWrap = False
        '
        'tableCell52
        '
        Me.tableCell52.BackColor = System.Drawing.Color.Transparent
        Me.tableCell52.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DISP_DISPOSAL_VALUE")})
        Me.tableCell52.Dpi = 254.0!
        Me.tableCell52.Name = "tableCell52"
        Me.tableCell52.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        Me.tableCell52.StylePriority.UseBackColor = False
        XrSummary11.FormatString = "{0:n2}"
        XrSummary11.IgnoreNullValues = True
        XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell52.Summary = XrSummary11
        Me.tableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell52.Weight = 0.22941467021086603R
        Me.tableCell52.WordWrap = False
        '
        'tableCell53
        '
        Me.tableCell53.BackColor = System.Drawing.Color.Transparent
        Me.tableCell53.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DISP_PNL")})
        Me.tableCell53.Dpi = 254.0!
        Me.tableCell53.Name = "tableCell53"
        Me.tableCell53.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        Me.tableCell53.StylePriority.UseBackColor = False
        XrSummary12.FormatString = "{0:n2}"
        XrSummary12.IgnoreNullValues = True
        XrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell53.Summary = XrSummary12
        Me.tableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell53.Weight = 0.22941478154267633R
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
        Me.tableCell54.Weight = 0.14212989079066063R
        Me.tableCell54.WordWrap = False
        '
        'tableCell55
        '
        Me.tableCell55.BackColor = System.Drawing.Color.Transparent
        Me.tableCell55.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DISP_TWDV")})
        Me.tableCell55.Dpi = 254.0!
        Me.tableCell55.Name = "tableCell55"
        Me.tableCell55.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        Me.tableCell55.StylePriority.UseBackColor = False
        XrSummary13.FormatString = "{0:n2}"
        XrSummary13.IgnoreNullValues = True
        XrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell55.Summary = XrSummary13
        Me.tableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell55.Weight = 0.22941433621543519R
        Me.tableCell55.WordWrap = False
        '
        'tableCell56
        '
        Me.tableCell56.BackColor = System.Drawing.Color.Transparent
        Me.tableCell56.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DISP_BABC")})
        Me.tableCell56.Dpi = 254.0!
        Me.tableCell56.Name = "tableCell56"
        Me.tableCell56.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        Me.tableCell56.StylePriority.UseBackColor = False
        XrSummary14.FormatString = "{0:n2}"
        XrSummary14.IgnoreNullValues = True
        XrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell56.Summary = XrSummary14
        Me.tableCell56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell56.Weight = 0.22941441971429288R
        Me.tableCell56.WordWrap = False
        '
        'reportFooterBand1
        '
        Me.reportFooterBand1.Dpi = 254.0!
        Me.reportFooterBand1.HeightF = 0.0!
        Me.reportFooterBand1.Name = "reportFooterBand1"
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
        'rpt_CAControlTransfer_Out
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.topMarginBand1, Me.pageHeaderBand1, Me.groupHeaderBand1, Me.groupHeaderBand2, Me.groupHeaderBand3, Me.detailBand1, Me.groupFooterBand1, Me.groupFooterBand2, Me.groupFooterBand3, Me.reportFooterBand1, Me.bottomMarginBand1})
        Me.DataSource = Me.CAREPORTDISPOSALTEMPBindingSource
        Me.Dpi = 254.0!
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(77, 108, 100, 100)
        Me.PageHeight = 2100
        Me.PageWidth = 2970
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.paramCompanyName, Me.paramYA})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.RequestParameters = False
        Me.SnapGridSize = 25.0!
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.ReportHeaderBandStyle, Me.ReportGroupHeaderBandStyle, Me.ReportDetailBandStyle, Me.ReportGroupFooterBandStyle, Me.ReportFooterBandStyle, Me.ReportOddStyle, Me.ReportEvenStyle})
        Me.Version = "17.1"
        CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAREPORTDISPOSALTEMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
End Class
