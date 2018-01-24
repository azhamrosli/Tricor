Public Class rpt_HP
	Inherits DevExpress.XtraReports.UI.XtraReport
    Friend WithEvents DsCA As EasyTemplate_Taxcom.dsCA
    Private components As System.ComponentModel.IContainer
    Friend WithEvents HPREPORTTEMPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportEvenStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportOddStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportFooterBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportGroupFooterBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportDetailBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportGroupHeaderBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportHeaderBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents tableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents reportFooterBand1 As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents tableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents groupFooterBand1 As DevExpress.XtraReports.UI.GroupFooterBand
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
    Friend WithEvents tableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents groupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents label12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pageHeaderBand1 As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents ParamCompanyName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents ParamYA As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
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
        Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.pageHeaderBand1 = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.label12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.table1 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
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
        Me.groupFooterBand1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.table3 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.reportFooterBand1 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.table4 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeaderBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportGroupHeaderBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportDetailBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportGroupFooterBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportFooterBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportOddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportEvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.HPREPORTTEMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCA = New EasyTemplate_Taxcom.dsCA()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.ParamCompanyName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.ParamYA = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HPREPORTTEMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1, Me.label1, Me.label3, Me.label4, Me.label5, Me.label6, Me.label7, Me.label8, Me.label9, Me.label10, Me.label11, Me.label12})
        Me.pageHeaderBand1.Dpi = 254.0!
        Me.pageHeaderBand1.HeightF = 480.5417!
        Me.pageHeaderBand1.Name = "pageHeaderBand1"
        Me.pageHeaderBand1.StyleName = "ReportHeaderBandStyle"
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label1.Dpi = 254.0!
        Me.label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 259.2917!)
        Me.label1.Name = "label1"
        Me.label1.SizeF = New System.Drawing.SizeF(699.1892!, 117.1042!)
        Me.label1.StylePriority.UseBackColor = False
        Me.label1.StylePriority.UseFont = False
        Me.label1.StylePriority.UseTextAlignment = False
        Me.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        Me.label1.WordWrap = False
        '
        'label3
        '
        Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label3.Dpi = 254.0!
        Me.label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.LocationFloat = New DevExpress.Utils.PointFloat(433.9994!, 376.3959!)
        Me.label3.Multiline = True
        Me.label3.Name = "label3"
        Me.label3.SizeF = New System.Drawing.SizeF(265.1898!, 104.1458!)
        Me.label3.StylePriority.UseBackColor = False
        Me.label3.StylePriority.UseFont = False
        Me.label3.StylePriority.UseTextAlignment = False
        Me.label3.Text = "Year of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Purchase"
        Me.label3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.label3.WordWrap = False
        '
        'label4
        '
        Me.label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label4.Dpi = 254.0!
        Me.label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.LocationFloat = New DevExpress.Utils.PointFloat(699.1892!, 259.2917!)
        Me.label4.Multiline = True
        Me.label4.Name = "label4"
        Me.label4.SizeF = New System.Drawing.SizeF(585.8105!, 117.1042!)
        Me.label4.StylePriority.UseBackColor = False
        Me.label4.StylePriority.UseFont = False
        Me.label4.StylePriority.UseTextAlignment = False
        Me.label4.Text = "BALANCE AT BEGINNING / " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ACQUISTION AT COST"
        Me.label4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.label4.WordWrap = False
        '
        'label5
        '
        Me.label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label5.Dpi = 254.0!
        Me.label5.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.LocationFloat = New DevExpress.Utils.PointFloat(699.1892!, 376.3958!)
        Me.label5.Multiline = True
        Me.label5.Name = "label5"
        Me.label5.SizeF = New System.Drawing.SizeF(291.5604!, 104.1458!)
        Me.label5.StylePriority.UseBackColor = False
        Me.label5.StylePriority.UseFont = False
        Me.label5.StylePriority.UseTextAlignment = False
        Me.label5.Text = "Capital / Cost" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RM"
        Me.label5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.label5.WordWrap = False
        '
        'label6
        '
        Me.label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label6.Dpi = 254.0!
        Me.label6.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.LocationFloat = New DevExpress.Utils.PointFloat(990.7496!, 376.3958!)
        Me.label6.Multiline = True
        Me.label6.Name = "label6"
        Me.label6.SizeF = New System.Drawing.SizeF(294.25!, 104.1459!)
        Me.label6.StylePriority.UseBackColor = False
        Me.label6.StylePriority.UseFont = False
        Me.label6.StylePriority.UseTextAlignment = False
        Me.label6.Text = "H.P. Interest" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RM"
        Me.label6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.label6.WordWrap = False
        '
        'label7
        '
        Me.label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label7.Dpi = 254.0!
        Me.label7.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.LocationFloat = New DevExpress.Utils.PointFloat(1285.0!, 259.2917!)
        Me.label7.Name = "label7"
        Me.label7.SizeF = New System.Drawing.SizeF(588.5002!, 117.1042!)
        Me.label7.StylePriority.UseBackColor = False
        Me.label7.StylePriority.UseFont = False
        Me.label7.StylePriority.UseTextAlignment = False
        Me.label7.Text = "PAYMENT IN THE YEAR"
        Me.label7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.label7.WordWrap = False
        '
        'label8
        '
        Me.label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label8.Dpi = 254.0!
        Me.label8.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.LocationFloat = New DevExpress.Utils.PointFloat(1285.0!, 376.3958!)
        Me.label8.Multiline = True
        Me.label8.Name = "label8"
        Me.label8.SizeF = New System.Drawing.SizeF(294.25!, 104.1459!)
        Me.label8.StylePriority.UseBackColor = False
        Me.label8.StylePriority.UseFont = False
        Me.label8.StylePriority.UseTextAlignment = False
        Me.label8.Text = "Capital Instalments" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RM"
        Me.label8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.label8.WordWrap = False
        '
        'label9
        '
        Me.label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label9.Dpi = 254.0!
        Me.label9.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.LocationFloat = New DevExpress.Utils.PointFloat(1579.25!, 376.3959!)
        Me.label9.Multiline = True
        Me.label9.Name = "label9"
        Me.label9.SizeF = New System.Drawing.SizeF(294.25!, 104.1458!)
        Me.label9.StylePriority.UseBackColor = False
        Me.label9.StylePriority.UseFont = False
        Me.label9.StylePriority.UseTextAlignment = False
        Me.label9.Text = "H.P. Interest Paid" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RM"
        Me.label9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.label9.WordWrap = False
        '
        'label10
        '
        Me.label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label10.Dpi = 254.0!
        Me.label10.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.LocationFloat = New DevExpress.Utils.PointFloat(1873.5!, 259.2917!)
        Me.label10.Name = "label10"
        Me.label10.SizeF = New System.Drawing.SizeF(588.5002!, 117.1042!)
        Me.label10.StylePriority.UseBackColor = False
        Me.label10.StylePriority.UseFont = False
        Me.label10.StylePriority.UseTextAlignment = False
        Me.label10.Text = "BALANCE AT END"
        Me.label10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.label10.WordWrap = False
        '
        'label11
        '
        Me.label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label11.Dpi = 254.0!
        Me.label11.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.LocationFloat = New DevExpress.Utils.PointFloat(1873.5!, 376.3958!)
        Me.label11.Multiline = True
        Me.label11.Name = "label11"
        Me.label11.SizeF = New System.Drawing.SizeF(294.25!, 104.1459!)
        Me.label11.StylePriority.UseBackColor = False
        Me.label11.StylePriority.UseFont = False
        Me.label11.StylePriority.UseTextAlignment = False
        Me.label11.Text = "Capital" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RM"
        Me.label11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.label11.WordWrap = False
        '
        'label12
        '
        Me.label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.label12.Dpi = 254.0!
        Me.label12.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.LocationFloat = New DevExpress.Utils.PointFloat(2167.75!, 376.3958!)
        Me.label12.Multiline = True
        Me.label12.Name = "label12"
        Me.label12.SizeF = New System.Drawing.SizeF(294.2505!, 104.1459!)
        Me.label12.StylePriority.UseBackColor = False
        Me.label12.StylePriority.UseFont = False
        Me.label12.StylePriority.UseTextAlignment = False
        Me.label12.Text = "H.P. Interest" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RM"
        Me.label12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.label12.WordWrap = False
        '
        'groupHeaderBand1
        '
        Me.groupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table1})
        Me.groupHeaderBand1.Dpi = 254.0!
        Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CA_CATEGORY_CODE", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.groupHeaderBand1.HeightF = 64.0!
        Me.groupHeaderBand1.Name = "groupHeaderBand1"
        Me.groupHeaderBand1.StyleName = "ReportGroupHeaderBandStyle"
        '
        'table1
        '
        Me.table1.Dpi = 254.0!
        Me.table1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table1.Name = "table1"
        Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
        Me.table1.SizeF = New System.Drawing.SizeF(2462.001!, 64.0!)
        Me.table1.StylePriority.UseFont = False
        '
        'tableRow1
        '
        Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell2})
        Me.tableRow1.Dpi = 254.0!
        Me.tableRow1.Name = "tableRow1"
        Me.tableRow1.Weight = 10.46953028649871R
        '
        'tableCell2
        '
        Me.tableCell2.BackColor = System.Drawing.Color.Transparent
        Me.tableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_CATEGORY_CODE")})
        Me.tableCell2.Dpi = 254.0!
        Me.tableCell2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell2.Name = "tableCell2"
        Me.tableCell2.StylePriority.UseBackColor = False
        Me.tableCell2.StylePriority.UseFont = False
        Me.tableCell2.Weight = 1.502437806498031R
        Me.tableCell2.WordWrap = False
        '
        'detailBand1
        '
        Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2})
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
        Me.table2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table2.Name = "table2"
        Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2})
        Me.table2.SizeF = New System.Drawing.SizeF(2462.0!, 64.0!)
        Me.table2.StylePriority.UseFont = False
        '
        'tableRow2
        '
        Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell3, Me.tableCell4, Me.tableCell5, Me.tableCell6, Me.tableCell7, Me.tableCell8, Me.tableCell9, Me.tableCell10})
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
        Me.tableCell3.Weight = 0.54021875932095453R
        Me.tableCell3.WordWrap = False
        '
        'tableCell4
        '
        Me.tableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_PURCHASE_YEAR")})
        Me.tableCell4.Dpi = 254.0!
        Me.tableCell4.Name = "tableCell4"
        Me.tableCell4.StylePriority.UseTextAlignment = False
        Me.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell4.Weight = 0.33009401393692339R
        Me.tableCell4.WordWrap = False
        '
        'tableCell5
        '
        Me.tableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "BF_PRINCIPAL")})
        Me.tableCell5.Dpi = 254.0!
        Me.tableCell5.Name = "tableCell5"
        Me.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell5.Weight = 0.362919456363471R
        Me.tableCell5.WordWrap = False
        '
        'tableCell6
        '
        Me.tableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "BF_INTEREST")})
        Me.tableCell6.Dpi = 254.0!
        Me.tableCell6.Name = "tableCell6"
        Me.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell6.Weight = 0.36626577507679192R
        Me.tableCell6.WordWrap = False
        '
        'tableCell7
        '
        Me.tableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CURR_PRINCIPAL")})
        Me.tableCell7.Dpi = 254.0!
        Me.tableCell7.Name = "tableCell7"
        Me.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell7.Weight = 0.366266686756049R
        Me.tableCell7.WordWrap = False
        '
        'tableCell8
        '
        Me.tableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CURR_INTEREST")})
        Me.tableCell8.Dpi = 254.0!
        Me.tableCell8.Name = "tableCell8"
        Me.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell8.Weight = 0.366266686756049R
        Me.tableCell8.WordWrap = False
        '
        'tableCell9
        '
        Me.tableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CF_PRINCIPAL")})
        Me.tableCell9.Dpi = 254.0!
        Me.tableCell9.Name = "tableCell9"
        Me.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell9.Weight = 0.36626592702333477R
        Me.tableCell9.WordWrap = False
        '
        'tableCell10
        '
        Me.tableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CF_INTEREST")})
        Me.tableCell10.Dpi = 254.0!
        Me.tableCell10.Name = "tableCell10"
        Me.tableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell10.Weight = 0.36626784534843826R
        Me.tableCell10.WordWrap = False
        '
        'groupFooterBand1
        '
        Me.groupFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrLine1, Me.table3})
        Me.groupFooterBand1.Dpi = 254.0!
        Me.groupFooterBand1.HeightF = 103.6875!
        Me.groupFooterBand1.Name = "groupFooterBand1"
        Me.groupFooterBand1.StyleName = "ReportGroupFooterBandStyle"
        '
        'table3
        '
        Me.table3.BackColor = System.Drawing.Color.Transparent
        Me.table3.Dpi = 254.0!
        Me.table3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table3.LocationFloat = New DevExpress.Utils.PointFloat(699.189!, 13.22917!)
        Me.table3.Name = "table3"
        Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow3})
        Me.table3.SizeF = New System.Drawing.SizeF(1762.811!, 64.0!)
        Me.table3.StylePriority.UseBackColor = False
        Me.table3.StylePriority.UseFont = False
        '
        'tableRow3
        '
        Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell13, Me.tableCell14, Me.tableCell15, Me.tableCell16, Me.tableCell17, Me.tableCell18})
        Me.tableRow3.Dpi = 254.0!
        Me.tableRow3.Name = "tableRow3"
        Me.tableRow3.Weight = 10.46953028649871R
        '
        'tableCell13
        '
        Me.tableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "BF_PRINCIPAL")})
        Me.tableCell13.Dpi = 254.0!
        Me.tableCell13.Name = "tableCell13"
        Me.tableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.IgnoreNullValues = True
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell13.Summary = XrSummary1
        Me.tableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell13.Weight = 0.30079810858668088R
        Me.tableCell13.WordWrap = False
        '
        'tableCell14
        '
        Me.tableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "BF_INTEREST")})
        Me.tableCell14.Dpi = 254.0!
        Me.tableCell14.Name = "tableCell14"
        Me.tableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary2.FormatString = "{0:n2}"
        XrSummary2.IgnoreNullValues = True
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell14.Summary = XrSummary2
        Me.tableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell14.Weight = 0.30357238964636268R
        Me.tableCell14.WordWrap = False
        '
        'tableCell15
        '
        Me.tableCell15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CURR_PRINCIPAL")})
        Me.tableCell15.Dpi = 254.0!
        Me.tableCell15.Name = "tableCell15"
        Me.tableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary3.FormatString = "{0:n2}"
        XrSummary3.IgnoreNullValues = True
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell15.Summary = XrSummary3
        Me.tableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell15.Weight = 0.30357238964636257R
        Me.tableCell15.WordWrap = False
        '
        'tableCell16
        '
        Me.tableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CURR_INTEREST")})
        Me.tableCell16.Dpi = 254.0!
        Me.tableCell16.Name = "tableCell16"
        Me.tableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary4.FormatString = "{0:n2}"
        XrSummary4.IgnoreNullValues = True
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell16.Summary = XrSummary4
        Me.tableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell16.Weight = 0.3035717599579838R
        Me.tableCell16.WordWrap = False
        '
        'tableCell17
        '
        Me.tableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CF_PRINCIPAL")})
        Me.tableCell17.Dpi = 254.0!
        Me.tableCell17.Name = "tableCell17"
        Me.tableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary5.FormatString = "{0:n2}"
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell17.Summary = XrSummary5
        Me.tableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell17.Weight = 0.30357226370868684R
        Me.tableCell17.WordWrap = False
        '
        'tableCell18
        '
        Me.tableCell18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CF_INTEREST")})
        Me.tableCell18.Dpi = 254.0!
        Me.tableCell18.Name = "tableCell18"
        Me.tableCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary6.FormatString = "{0:n2}"
        XrSummary6.IgnoreNullValues = True
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell18.Summary = XrSummary6
        Me.tableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell18.Weight = 0.30357254706845738R
        Me.tableCell18.WordWrap = False
        '
        'reportFooterBand1
        '
        Me.reportFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine3, Me.table4})
        Me.reportFooterBand1.Dpi = 254.0!
        Me.reportFooterBand1.HeightF = 140.7291!
        Me.reportFooterBand1.Name = "reportFooterBand1"
        Me.reportFooterBand1.StyleName = "ReportFooterBandStyle"
        '
        'table4
        '
        Me.table4.BackColor = System.Drawing.Color.Transparent
        Me.table4.Dpi = 254.0!
        Me.table4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table4.LocationFloat = New DevExpress.Utils.PointFloat(699.1892!, 25.0!)
        Me.table4.Name = "table4"
        Me.table4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow4})
        Me.table4.SizeF = New System.Drawing.SizeF(1762.812!, 64.0!)
        Me.table4.StylePriority.UseBackColor = False
        Me.table4.StylePriority.UseFont = False
        '
        'tableRow4
        '
        Me.tableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell21, Me.tableCell22, Me.tableCell23, Me.tableCell24, Me.tableCell25, Me.tableCell26})
        Me.tableRow4.Dpi = 254.0!
        Me.tableRow4.Name = "tableRow4"
        Me.tableRow4.Weight = 10.46953028649871R
        '
        'tableCell21
        '
        Me.tableCell21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "BF_PRINCIPAL")})
        Me.tableCell21.Dpi = 254.0!
        Me.tableCell21.Name = "tableCell21"
        Me.tableCell21.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary7.FormatString = "{0:n2}"
        XrSummary7.IgnoreNullValues = True
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell21.Summary = XrSummary7
        Me.tableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell21.Weight = 0.30359657325936323R
        Me.tableCell21.WordWrap = False
        '
        'tableCell22
        '
        Me.tableCell22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "BF_INTEREST")})
        Me.tableCell22.Dpi = 254.0!
        Me.tableCell22.Name = "tableCell22"
        Me.tableCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary8.FormatString = "{0:n2}"
        XrSummary8.IgnoreNullValues = True
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell22.Summary = XrSummary8
        Me.tableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell22.Weight = 0.30174272775661476R
        Me.tableCell22.WordWrap = False
        '
        'tableCell23
        '
        Me.tableCell23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CURR_PRINCIPAL")})
        Me.tableCell23.Dpi = 254.0!
        Me.tableCell23.Name = "tableCell23"
        Me.tableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary9.FormatString = "{0:n2}"
        XrSummary9.IgnoreNullValues = True
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell23.Summary = XrSummary9
        Me.tableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell23.Weight = 0.30406092549757868R
        Me.tableCell23.WordWrap = False
        '
        'tableCell24
        '
        Me.tableCell24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CURR_INTEREST")})
        Me.tableCell24.Dpi = 254.0!
        Me.tableCell24.Name = "tableCell24"
        Me.tableCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary10.FormatString = "{0:n2}"
        XrSummary10.IgnoreNullValues = True
        XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell24.Summary = XrSummary10
        Me.tableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell24.Weight = 0.30405903340017337R
        Me.tableCell24.WordWrap = False
        '
        'tableCell25
        '
        Me.tableCell25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CF_PRINCIPAL")})
        Me.tableCell25.Dpi = 254.0!
        Me.tableCell25.Name = "tableCell25"
        Me.tableCell25.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary11.FormatString = "{0:n2}"
        XrSummary11.IgnoreNullValues = True
        XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell25.Summary = XrSummary11
        Me.tableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell25.Weight = 0.30405903340017337R
        Me.tableCell25.WordWrap = False
        '
        'tableCell26
        '
        Me.tableCell26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CF_INTEREST")})
        Me.tableCell26.Dpi = 254.0!
        Me.tableCell26.Name = "tableCell26"
        Me.tableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary12.FormatString = "{0:n2}"
        XrSummary12.IgnoreNullValues = True
        XrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell26.Summary = XrSummary12
        Me.tableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell26.Weight = 0.304061146242276R
        Me.tableCell26.WordWrap = False
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
        'HPREPORTTEMPBindingSource
        '
        Me.HPREPORTTEMPBindingSource.DataMember = "HP_REPORT_TEMP"
        Me.HPREPORTTEMPBindingSource.DataSource = Me.DsCA
        '
        'DsCA
        '
        Me.DsCA.DataSetName = "dsCA"
        Me.DsCA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'XrLine1
        '
        Me.XrLine1.BackColor = System.Drawing.Color.Transparent
        Me.XrLine1.Dpi = 254.0!
        Me.XrLine1.LineWidth = 3
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(694.5833!, 0.0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(1767.417!, 13.22917!)
        Me.XrLine1.StylePriority.UseBackColor = False
        '
        'XrLine2
        '
        Me.XrLine2.BackColor = System.Drawing.Color.Transparent
        Me.XrLine2.BorderWidth = 2.0!
        Me.XrLine2.Dpi = 254.0!
        Me.XrLine2.LineWidth = 5
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(691.937!, 77.22916!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(1770.063!, 26.45834!)
        Me.XrLine2.StylePriority.UseBackColor = False
        Me.XrLine2.StylePriority.UseBorderWidth = False
        '
        'XrLine3
        '
        Me.XrLine3.BackColor = System.Drawing.Color.Transparent
        Me.XrLine3.BorderWidth = 2.0!
        Me.XrLine3.Dpi = 254.0!
        Me.XrLine3.LineWidth = 5
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(694.5828!, 89.2708!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(1767.417!, 26.45833!)
        Me.XrLine3.StylePriority.UseBackColor = False
        Me.XrLine3.StylePriority.UseBorderWidth = False
        '
        'ParamCompanyName
        '
        Me.ParamCompanyName.Description = "ParamCompanyName"
        Me.ParamCompanyName.Name = "ParamCompanyName"
        '
        'ParamYA
        '
        Me.ParamYA.Description = "ParamYA"
        Me.ParamYA.Name = "ParamYA"
        Me.ParamYA.Type = GetType(Integer)
        Me.ParamYA.ValueInfo = "0"
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.ParamCompanyName, "Text", "NAME : {0}")})
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 39.58167!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(2462.0!, 58.41999!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "XrLabel1"
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.ParamYA, "Text", "INCOME TAX COMPUTATION - YEAR OF ASSESSMENT - {0}")})
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 98.00165!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(2462.0!, 58.42!)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "XrLabel2"
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 156.4217!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(2462.0!, 58.42!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "SCHEDULE OF HIRE PURCHASE PAYMENTS"
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 376.3959!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(433.9994!, 104.1457!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Particulars"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        Me.XrLabel4.WordWrap = False
        '
        'rpt_HP
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.topMarginBand1, Me.pageHeaderBand1, Me.groupHeaderBand1, Me.detailBand1, Me.groupFooterBand1, Me.reportFooterBand1, Me.bottomMarginBand1})
        Me.DataSource = Me.HPREPORTTEMPBindingSource
        Me.Dpi = 254.0!
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(254, 254, 100, 100)
        Me.PageHeight = 2100
        Me.PageWidth = 2970
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.ParamCompanyName, Me.ParamYA})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.RequestParameters = False
        Me.SnapGridSize = 25.0!
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.ReportHeaderBandStyle, Me.ReportGroupHeaderBandStyle, Me.ReportDetailBandStyle, Me.ReportGroupFooterBandStyle, Me.ReportFooterBandStyle, Me.ReportOddStyle, Me.ReportEvenStyle})
        Me.Version = "17.1"
        CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HPREPORTTEMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
End Class
