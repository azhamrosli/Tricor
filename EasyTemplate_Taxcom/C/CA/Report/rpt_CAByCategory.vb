Imports DevExpress.XtraReports.UI

Public Class rpt_CAByCategory
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
    Friend WithEvents tableCell83 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell82 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell81 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell80 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell79 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell78 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell77 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell76 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell75 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell74 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell73 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tblTotalCategory As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents groupFooterBand4 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents groupFooterBand3 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents tableCell23 As DevExpress.XtraReports.UI.XRTableCell
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
    Friend WithEvents tableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents detailBand1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents tableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents groupHeaderBand4 As DevExpress.XtraReports.UI.GroupHeaderBand
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
    Friend WithEvents label3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pageHeaderBand1 As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents paramYA As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paramCompanyName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents lblTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents tblTotalCategory_line As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents FormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents FontSize As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paramSch As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tableCell98 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell97 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell96 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell95 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell94 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell93 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell92 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell91 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell90 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell89 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell88 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow10 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table10 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents reportFooterBand1 As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents tblTotalCategory_line_Bot2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents tblTotalCategory_line_Bot As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents NOTCAPEX As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents CAPEX As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents param_ShowDraft As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ShowDraft As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
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
        Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.pageHeaderBand1 = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ShowDraft = New DevExpress.XtraReports.UI.FormattingRule()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramSch = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramYA = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramCompanyName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.lblTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramTitle = New DevExpress.XtraReports.Parameters.Parameter()
        Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.groupHeaderBand4 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.table4 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.FormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.table5 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
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
        Me.tableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.groupFooterBand3 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.groupFooterBand4 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.tblTotalCategory_line_Bot2 = New DevExpress.XtraReports.UI.XRLine()
        Me.tblTotalCategory_line_Bot = New DevExpress.XtraReports.UI.XRLine()
        Me.tblTotalCategory_line = New DevExpress.XtraReports.UI.XRLine()
        Me.tblTotalCategory = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell73 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell74 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell75 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell76 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell77 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell78 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell79 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell80 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell81 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell82 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell83 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.FontSize = New DevExpress.XtraReports.Parameters.Parameter()
        Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportHeaderBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportGroupHeaderBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportDetailBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportGroupFooterBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportFooterBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportOddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportEvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.CAREPORTTEMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCA = New EasyTemplate_Taxcom.dsCA()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.tableCell98 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell97 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell96 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell95 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell94 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell93 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell92 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell91 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell90 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell89 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell88 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.table10 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.reportFooterBand1 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.CAPEX = New DevExpress.XtraReports.UI.FormattingRule()
        Me.NOTCAPEX = New DevExpress.XtraReports.UI.FormattingRule()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.param_ShowDraft = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.table3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblTotalCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAREPORTTEMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'topMarginBand1
        '
        Me.topMarginBand1.HeightF = 39.0!
        Me.topMarginBand1.Name = "topMarginBand1"
        '
        'pageHeaderBand1
        '
        Me.pageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel45, Me.XrLine2, Me.XrLine1, Me.XrLabel5, Me.XrLabel19, Me.XrLabel18, Me.XrLabel17, Me.XrLabel16, Me.XrLabel15, Me.XrLabel14, Me.XrLabel13, Me.XrLabel12, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLabel2, Me.XrLabel4, Me.lblTitle, Me.label2, Me.label3, Me.label4, Me.label5, Me.label6, Me.label7, Me.label8, Me.label9, Me.label10, Me.label11, Me.label12, Me.label13, Me.label14, Me.label15, Me.label16, Me.label17, Me.label18, Me.label19})
        Me.pageHeaderBand1.Font = New System.Drawing.Font("Arial", 10.2!)
        Me.pageHeaderBand1.HeightF = 211.5678!
        Me.pageHeaderBand1.Name = "pageHeaderBand1"
        Me.pageHeaderBand1.StyleName = "ReportHeaderBandStyle"
        Me.pageHeaderBand1.StylePriority.UseFont = False
        '
        'XrLabel45
        '
        Me.XrLabel45.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel45.CanShrink = True
        Me.XrLabel45.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic)
        Me.XrLabel45.FormattingRules.Add(Me.ShowDraft)
        Me.XrLabel45.LocationFloat = New DevExpress.Utils.PointFloat(903.249!, 10.00001!)
        Me.XrLabel45.Name = "XrLabel45"
        Me.XrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel45.SizeF = New System.Drawing.SizeF(126.0414!, 23.0!)
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
        'XrLine2
        '
        Me.XrLine2.BackColor = System.Drawing.Color.Transparent
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0.2624512!, 127.3785!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLine2.SizeF = New System.Drawing.SizeF(1029.029!, 5.681816!)
        Me.XrLine2.StylePriority.UseBackColor = False
        Me.XrLine2.StylePriority.UsePadding = False
        '
        'XrLine1
        '
        Me.XrLine1.BackColor = System.Drawing.Color.Transparent
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.262324!, 205.886!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLine1.SizeF = New System.Drawing.SizeF(1029.028!, 5.681824!)
        Me.XrLine1.StylePriority.UseBackColor = False
        Me.XrLine1.StylePriority.UsePadding = False
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramSch, "Text", "")})
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(808.457!, 46.26865!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(220.8334!, 23.0!)
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
        'XrLabel19
        '
        Me.XrLabel19.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(800.8859!, 133.0604!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(228.4056!, 14.38649!)
        Me.XrLabel19.StylePriority.UseBackColor = False
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel19.WordWrap = False
        '
        'XrLabel18
        '
        Me.XrLabel18.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(0.262324!, 186.562!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(328.0876!, 19.32413!)
        Me.XrLabel18.StylePriority.UseBackColor = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.WordWrap = False
        '
        'XrLabel17
        '
        Me.XrLabel17.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(965.5042!, 186.5618!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(63.7868!, 19.32431!)
        Me.XrLabel17.StylePriority.UseBackColor = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "RM"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel16
        '
        Me.XrLabel16.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(883.1958!, 186.5617!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(82.30835!, 19.3243!)
        Me.XrLabel16.StylePriority.UseBackColor = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "RM"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel15
        '
        Me.XrLabel15.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(800.8858!, 186.5618!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(82.31!, 19.32431!)
        Me.XrLabel15.StylePriority.UseBackColor = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "RM"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel14
        '
        Me.XrLabel14.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(742.8003!, 186.5617!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(58.08533!, 19.3243!)
        Me.XrLabel14.StylePriority.UseBackColor = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "RM"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel13
        '
        Me.XrLabel13.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(685.7165!, 186.5617!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(57.0838!, 19.3243!)
        Me.XrLabel13.StylePriority.UseBackColor = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "RM"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel12
        '
        Me.XrLabel12.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(622.5154!, 186.5618!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(63.20105!, 19.32431!)
        Me.XrLabel12.StylePriority.UseBackColor = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "RM"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(565.396!, 186.5617!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(57.11926!, 19.3243!)
        Me.XrLabel11.StylePriority.UseBackColor = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "RM"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(509.1098!, 186.5617!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(56.28601!, 19.3243!)
        Me.XrLabel10.StylePriority.UseBackColor = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "RM"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(451.9906!, 186.5617!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(57.11938!, 19.3243!)
        Me.XrLabel9.StylePriority.UseBackColor = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "RM"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(388.8298!, 186.5617!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(63.16061!, 19.32431!)
        Me.XrLabel8.StylePriority.UseBackColor = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "RM"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(328.3499!, 186.5617!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(60.47983!, 19.3243!)
        Me.XrLabel7.StylePriority.UseBackColor = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "RM"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramYA, "Text", "INCOME TAX COMPUTATION - YEAR OF ASSESSMENT {0}")})
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(362.0621!, 86.01862!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(369.7919!, 16.74998!)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UsePadding = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
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
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramCompanyName, "Text", "NAME: {0}")})
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(362.0621!, 69.26864!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(509.6751!, 16.74998!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UsePadding = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "NAME :"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
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
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.LocationFloat = New DevExpress.Utils.PointFloat(362.0621!, 102.7686!)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.lblTitle.SizeF = New System.Drawing.SizeF(509.6756!, 16.75!)
        Me.lblTitle.StylePriority.UseBackColor = False
        Me.lblTitle.StylePriority.UseFont = False
        Me.lblTitle.StylePriority.UsePadding = False
        Me.lblTitle.StylePriority.UseTextAlignment = False
        Me.lblTitle.Text = "SCHEDULE OF CAPITAL ALLOWANCES"
        Me.lblTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'paramTitle
        '
        Me.paramTitle.Description = "paramTitle"
        Me.paramTitle.Name = "paramTitle"
        '
        'label2
        '
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(0.262324!, 159.328!)
        Me.label2.Name = "label2"
        Me.label2.SizeF = New System.Drawing.SizeF(157.1474!, 27.2337!)
        Me.label2.StylePriority.UseBackColor = False
        Me.label2.StylePriority.UseFont = False
        Me.label2.StylePriority.UseTextAlignment = False
        Me.label2.Text = "Asset"
        Me.label2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'label3
        '
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label3.LocationFloat = New DevExpress.Utils.PointFloat(0.2624512!, 133.0604!)
        Me.label3.Name = "label3"
        Me.label3.SizeF = New System.Drawing.SizeF(328.0874!, 14.38647!)
        Me.label3.StylePriority.UseBackColor = False
        Me.label3.StylePriority.UseFont = False
        Me.label3.WordWrap = False
        '
        'label4
        '
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label4.LocationFloat = New DevExpress.Utils.PointFloat(157.4097!, 159.328!)
        Me.label4.Name = "label4"
        Me.label4.SizeF = New System.Drawing.SizeF(53.16095!, 27.2337!)
        Me.label4.StylePriority.UseBackColor = False
        Me.label4.StylePriority.UseFont = False
        Me.label4.StylePriority.UseTextAlignment = False
        Me.label4.Text = "Rate of IA"
        Me.label4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'label5
        '
        Me.label5.BackColor = System.Drawing.Color.Transparent
        Me.label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label5.LocationFloat = New DevExpress.Utils.PointFloat(210.5707!, 159.328!)
        Me.label5.Name = "label5"
        Me.label5.SizeF = New System.Drawing.SizeF(53.16!, 27.23!)
        Me.label5.StylePriority.UseBackColor = False
        Me.label5.StylePriority.UseFont = False
        Me.label5.StylePriority.UseTextAlignment = False
        Me.label5.Text = "Rate of AA"
        Me.label5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'label6
        '
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label6.LocationFloat = New DevExpress.Utils.PointFloat(263.7307!, 159.328!)
        Me.label6.Name = "label6"
        Me.label6.SizeF = New System.Drawing.SizeF(64.61938!, 27.2337!)
        Me.label6.StylePriority.UseBackColor = False
        Me.label6.StylePriority.UseFont = False
        Me.label6.StylePriority.UseTextAlignment = False
        Me.label6.Text = "Year of Purchase"
        Me.label6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'label7
        '
        Me.label7.BackColor = System.Drawing.Color.Transparent
        Me.label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label7.LocationFloat = New DevExpress.Utils.PointFloat(328.3499!, 133.0604!)
        Me.label7.Name = "label7"
        Me.label7.SizeF = New System.Drawing.SizeF(237.0462!, 14.38647!)
        Me.label7.StylePriority.UseBackColor = False
        Me.label7.StylePriority.UseFont = False
        Me.label7.StylePriority.UseTextAlignment = False
        Me.label7.Text = "QUALIFYING EXPENDITURE"
        Me.label7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.label7.WordWrap = False
        '
        'label8
        '
        Me.label8.BackColor = System.Drawing.Color.Transparent
        Me.label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label8.LocationFloat = New DevExpress.Utils.PointFloat(328.3501!, 159.328!)
        Me.label8.Name = "label8"
        Me.label8.SizeF = New System.Drawing.SizeF(60.47974!, 27.2337!)
        Me.label8.StylePriority.UseBackColor = False
        Me.label8.StylePriority.UseFont = False
        Me.label8.StylePriority.UseTextAlignment = False
        Me.label8.Text = "Brought Forward"
        Me.label8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'label9
        '
        Me.label9.BackColor = System.Drawing.Color.Transparent
        Me.label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label9.LocationFloat = New DevExpress.Utils.PointFloat(388.8298!, 159.3278!)
        Me.label9.Name = "label9"
        Me.label9.SizeF = New System.Drawing.SizeF(63.1608!, 27.23367!)
        Me.label9.StylePriority.UseBackColor = False
        Me.label9.StylePriority.UseFont = False
        Me.label9.StylePriority.UseTextAlignment = False
        Me.label9.Text = "Additions"
        Me.label9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'label10
        '
        Me.label10.BackColor = System.Drawing.Color.Transparent
        Me.label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label10.LocationFloat = New DevExpress.Utils.PointFloat(451.9906!, 159.3278!)
        Me.label10.Name = "label10"
        Me.label10.SizeF = New System.Drawing.SizeF(57.11932!, 27.23367!)
        Me.label10.StylePriority.UseBackColor = False
        Me.label10.StylePriority.UseFont = False
        Me.label10.StylePriority.UseTextAlignment = False
        Me.label10.Text = "Disposal"
        Me.label10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'label11
        '
        Me.label11.BackColor = System.Drawing.Color.Transparent
        Me.label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label11.LocationFloat = New DevExpress.Utils.PointFloat(509.1098!, 159.3278!)
        Me.label11.Name = "label11"
        Me.label11.SizeF = New System.Drawing.SizeF(56.28601!, 27.23367!)
        Me.label11.StylePriority.UseBackColor = False
        Me.label11.StylePriority.UseFont = False
        Me.label11.StylePriority.UseTextAlignment = False
        Me.label11.Text = "Carried Forward"
        Me.label11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'label12
        '
        Me.label12.BackColor = System.Drawing.Color.Transparent
        Me.label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label12.LocationFloat = New DevExpress.Utils.PointFloat(565.3961!, 133.0604!)
        Me.label12.Name = "label12"
        Me.label12.SizeF = New System.Drawing.SizeF(235.4895!, 14.38649!)
        Me.label12.StylePriority.UseBackColor = False
        Me.label12.StylePriority.UseFont = False
        Me.label12.StylePriority.UseTextAlignment = False
        Me.label12.Text = "RESIDUAL EXPENDITURE"
        Me.label12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.label12.WordWrap = False
        '
        'label13
        '
        Me.label13.BackColor = System.Drawing.Color.Transparent
        Me.label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label13.LocationFloat = New DevExpress.Utils.PointFloat(565.396!, 159.3278!)
        Me.label13.Name = "label13"
        Me.label13.SizeF = New System.Drawing.SizeF(57.11945!, 27.23367!)
        Me.label13.StylePriority.UseBackColor = False
        Me.label13.StylePriority.UseFont = False
        Me.label13.StylePriority.UseTextAlignment = False
        Me.label13.Text = "Brought Forward"
        Me.label13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'label14
        '
        Me.label14.BackColor = System.Drawing.Color.Transparent
        Me.label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label14.LocationFloat = New DevExpress.Utils.PointFloat(622.5154!, 159.328!)
        Me.label14.Name = "label14"
        Me.label14.SizeF = New System.Drawing.SizeF(63.20105!, 27.2337!)
        Me.label14.StylePriority.UseBackColor = False
        Me.label14.StylePriority.UseFont = False
        Me.label14.StylePriority.UseTextAlignment = False
        Me.label14.Text = "Additions"
        Me.label14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'label15
        '
        Me.label15.BackColor = System.Drawing.Color.Transparent
        Me.label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label15.LocationFloat = New DevExpress.Utils.PointFloat(685.7165!, 159.3278!)
        Me.label15.Name = "label15"
        Me.label15.SizeF = New System.Drawing.SizeF(57.0838!, 27.23367!)
        Me.label15.StylePriority.UseBackColor = False
        Me.label15.StylePriority.UseFont = False
        Me.label15.StylePriority.UseTextAlignment = False
        Me.label15.Text = "Disposal"
        Me.label15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'label16
        '
        Me.label16.BackColor = System.Drawing.Color.Transparent
        Me.label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label16.LocationFloat = New DevExpress.Utils.PointFloat(742.8003!, 159.3278!)
        Me.label16.Multiline = True
        Me.label16.Name = "label16"
        Me.label16.SizeF = New System.Drawing.SizeF(58.08551!, 27.23367!)
        Me.label16.StylePriority.UseBackColor = False
        Me.label16.StylePriority.UseFont = False
        Me.label16.StylePriority.UseTextAlignment = False
        Me.label16.Text = "Total" & Global.Microsoft.VisualBasic.ChrW(13)
        Me.label16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'label17
        '
        Me.label17.BackColor = System.Drawing.Color.Transparent
        Me.label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label17.LocationFloat = New DevExpress.Utils.PointFloat(800.8858!, 159.3278!)
        Me.label17.Name = "label17"
        Me.label17.SizeF = New System.Drawing.SizeF(82.31!, 27.23!)
        Me.label17.StylePriority.UseBackColor = False
        Me.label17.StylePriority.UseFont = False
        Me.label17.StylePriority.UseTextAlignment = False
        Me.label17.Text = "Initial Allowances"
        Me.label17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'label18
        '
        Me.label18.BackColor = System.Drawing.Color.Transparent
        Me.label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label18.LocationFloat = New DevExpress.Utils.PointFloat(883.1958!, 159.3278!)
        Me.label18.Name = "label18"
        Me.label18.SizeF = New System.Drawing.SizeF(82.30835!, 27.23367!)
        Me.label18.StylePriority.UseBackColor = False
        Me.label18.StylePriority.UseFont = False
        Me.label18.StylePriority.UseTextAlignment = False
        Me.label18.Text = "Annual Allowances"
        Me.label18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'label19
        '
        Me.label19.BackColor = System.Drawing.Color.Transparent
        Me.label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label19.LocationFloat = New DevExpress.Utils.PointFloat(965.5041!, 159.328!)
        Me.label19.Name = "label19"
        Me.label19.SizeF = New System.Drawing.SizeF(63.78619!, 27.2337!)
        Me.label19.StylePriority.UseBackColor = False
        Me.label19.StylePriority.UseFont = False
        Me.label19.StylePriority.UseTextAlignment = False
        Me.label19.Text = "Residual Exp C/F"
        Me.label19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'groupHeaderBand1
        '
        Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CA_RATE_AA", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.groupHeaderBand1.HeightF = 0.0!
        Me.groupHeaderBand1.Name = "groupHeaderBand1"
        Me.groupHeaderBand1.StyleName = "ReportGroupHeaderBandStyle"
        '
        'groupHeaderBand2
        '
        Me.groupHeaderBand2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CA_PURCHASE_YEAR", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.groupHeaderBand2.HeightF = 0.0!
        Me.groupHeaderBand2.Level = 1
        Me.groupHeaderBand2.Name = "groupHeaderBand2"
        Me.groupHeaderBand2.StyleName = "ReportGroupHeaderBandStyle"
        '
        'groupHeaderBand3
        '
        Me.groupHeaderBand3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table3})
        Me.groupHeaderBand3.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CA_CATEGORY_CODE", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand3.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage
        Me.groupHeaderBand3.HeightF = 25.0!
        Me.groupHeaderBand3.KeepTogether = True
        Me.groupHeaderBand3.Level = 2
        Me.groupHeaderBand3.Name = "groupHeaderBand3"
        Me.groupHeaderBand3.StyleName = "ReportGroupHeaderBandStyle"
        '
        'table3
        '
        Me.table3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table3.Name = "table3"
        Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow3})
        Me.table3.SizeF = New System.Drawing.SizeF(1029.652!, 25.19685!)
        '
        'tableRow3
        '
        Me.tableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell6})
        Me.tableRow3.Name = "tableRow3"
        Me.tableRow3.Weight = 10.46953028649871R
        '
        'tableCell6
        '
        Me.tableCell6.BackColor = System.Drawing.Color.Transparent
        Me.tableCell6.CanShrink = True
        Me.tableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.CA_CATEGORY_CODE")})
        Me.tableCell6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tableCell6.Name = "tableCell6"
        Me.tableCell6.StylePriority.UseBackColor = False
        Me.tableCell6.StylePriority.UseFont = False
        Me.tableCell6.Weight = 1.0927410518786826R
        '
        'groupHeaderBand4
        '
        Me.groupHeaderBand4.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table4})
        Me.groupHeaderBand4.FormattingRules.Add(Me.FormattingRule1)
        Me.groupHeaderBand4.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CA_TRANSFERROR_NAME", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.groupHeaderBand4.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.groupHeaderBand4.HeightF = 25.0!
        Me.groupHeaderBand4.Level = 3
        Me.groupHeaderBand4.Name = "groupHeaderBand4"
        Me.groupHeaderBand4.StyleName = "ReportGroupHeaderBandStyle"
        '
        'table4
        '
        Me.table4.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table4.Name = "table4"
        Me.table4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow4})
        Me.table4.SizeF = New System.Drawing.SizeF(1029.652!, 25.19685!)
        '
        'tableRow4
        '
        Me.tableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell8})
        Me.tableRow4.Name = "tableRow4"
        Me.tableRow4.Weight = 10.46953028649871R
        '
        'tableCell8
        '
        Me.tableCell8.BackColor = System.Drawing.Color.Transparent
        Me.tableCell8.CanShrink = True
        Me.tableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.CA_TRANSFERROR_NAME", "Controlled Transfer from {0}")})
        Me.tableCell8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tableCell8.Name = "tableCell8"
        Me.tableCell8.StylePriority.UseBackColor = False
        Me.tableCell8.StylePriority.UseFont = False
        Me.tableCell8.Weight = 1.4308911150553167R
        '
        'FormattingRule1
        '
        Me.FormattingRule1.Condition = "[CA_TRANSFERROR_NAME] == ' []'"
        Me.FormattingRule1.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.FormattingRule1.Name = "FormattingRule1"
        '
        'detailBand1
        '
        Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table5})
        Me.detailBand1.EvenStyleName = "ReportEvenStyle"
        Me.detailBand1.HeightF = 25.19685!
        Me.detailBand1.KeepTogether = True
        Me.detailBand1.KeepTogetherWithDetailReports = True
        Me.detailBand1.Name = "detailBand1"
        Me.detailBand1.OddStyleName = "ReportOddStyle"
        Me.detailBand1.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CA_ASSET", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("CA_RATE_AA", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("CA_PURCHASE_YEAR", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.detailBand1.StyleName = "ReportDetailBandStyle"
        '
        'table5
        '
        Me.table5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.table5.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table5.Name = "table5"
        Me.table5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow5})
        Me.table5.SizeF = New System.Drawing.SizeF(1076.0!, 25.19685!)
        Me.table5.StylePriority.UseFont = False
        '
        'tableRow5
        '
        Me.tableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell9, Me.tableCell10, Me.tableCell11, Me.tableCell12, Me.tableCell13, Me.tableCell14, Me.tableCell15, Me.tableCell16, Me.tableCell17, Me.tableCell18, Me.tableCell19, Me.tableCell20, Me.tableCell21, Me.tableCell22, Me.tableCell23, Me.XrTableCell1})
        Me.tableRow5.Name = "tableRow5"
        Me.tableRow5.Weight = 10.46953028649871R
        '
        'tableCell9
        '
        Me.tableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.CA_ASSET")})
        Me.tableCell9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableCell9.Name = "tableCell9"
        Me.tableCell9.StylePriority.UseFont = False
        Me.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.tableCell9.Weight = 0.42012792491648326R
        '
        'tableCell10
        '
        Me.tableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.CA_RATE_IA", "{0} %")})
        Me.tableCell10.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell10.Name = "tableCell10"
        Me.tableCell10.StylePriority.UseFont = False
        Me.tableCell10.StylePriority.UseTextAlignment = False
        Me.tableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell10.Weight = 0.1418870319488541R
        Me.tableCell10.WordWrap = False
        '
        'tableCell11
        '
        Me.tableCell11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.CA_RATE_AA", "{0} %")})
        Me.tableCell11.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell11.Name = "tableCell11"
        Me.tableCell11.StylePriority.UseFont = False
        Me.tableCell11.StylePriority.UseTextAlignment = False
        Me.tableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell11.Weight = 0.14188451057552831R
        Me.tableCell11.WordWrap = False
        '
        'tableCell12
        '
        Me.tableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.CA_PURCHASE_YEAR")})
        Me.tableCell12.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell12.Name = "tableCell12"
        Me.tableCell12.StylePriority.UseFont = False
        Me.tableCell12.StylePriority.UseTextAlignment = False
        Me.tableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell12.Weight = 0.17246913435882635R
        Me.tableCell12.WordWrap = False
        '
        'tableCell13
        '
        Me.tableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.QC_BF", "{0:#,# ;(#,#);0 }")})
        Me.tableCell13.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell13.Name = "tableCell13"
        Me.tableCell13.StylePriority.UseFont = False
        Me.tableCell13.StylePriority.UseTextAlignment = False
        Me.tableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell13.Weight = 0.16142183646163469R
        Me.tableCell13.WordWrap = False
        '
        'tableCell14
        '
        Me.tableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.QC_ADD", "{0:#,# ;(#,#);0 }")})
        Me.tableCell14.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell14.Name = "tableCell14"
        Me.tableCell14.StylePriority.UseFont = False
        Me.tableCell14.StylePriority.UseTextAlignment = False
        Me.tableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell14.Weight = 0.16857622191986377R
        Me.tableCell14.WordWrap = False
        '
        'tableCell15
        '
        Me.tableCell15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.QC_DISP", "{0:#,# ;(#,#); 0}")})
        Me.tableCell15.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell15.Name = "tableCell15"
        Me.tableCell15.StylePriority.UseFont = False
        Me.tableCell15.StylePriority.UseTextAlignment = False
        Me.tableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell15.Weight = 0.15245245426859227R
        Me.tableCell15.WordWrap = False
        '
        'tableCell16
        '
        Me.tableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.QC_CF", "{0:#,# ;(#,#);0 }")})
        Me.tableCell16.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell16.Name = "tableCell16"
        Me.tableCell16.StylePriority.UseFont = False
        Me.tableCell16.StylePriority.UseTextAlignment = False
        Me.tableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell16.Weight = 0.15022785039749326R
        Me.tableCell16.WordWrap = False
        '
        'tableCell17
        '
        Me.tableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.TWDV_BF", "{0:#,# ;(#,#);0 }")})
        Me.tableCell17.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell17.Name = "tableCell17"
        Me.tableCell17.StylePriority.UseFont = False
        Me.tableCell17.StylePriority.UseTextAlignment = False
        Me.tableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell17.Weight = 0.15245180975205758R
        Me.tableCell17.WordWrap = False
        '
        'tableCell18
        '
        Me.tableCell18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.TWDV_ADD", "{0:#,# ;(#,#);0 }")})
        Me.tableCell18.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell18.Name = "tableCell18"
        Me.tableCell18.StylePriority.UseFont = False
        Me.tableCell18.StylePriority.UseTextAlignment = False
        Me.tableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell18.Weight = 0.16868463659193994R
        Me.tableCell18.WordWrap = False
        '
        'tableCell19
        '
        Me.tableCell19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.TWDV_DISP", "{0:#,# ;(#,#);0 }")})
        Me.tableCell19.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell19.Name = "tableCell19"
        Me.tableCell19.StylePriority.UseFont = False
        Me.tableCell19.StylePriority.UseTextAlignment = False
        Me.tableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell19.Weight = 0.15235716057139312R
        Me.tableCell19.WordWrap = False
        '
        'tableCell20
        '
        Me.tableCell20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.TWDV_TOTAL", "{0:#,# ;(#,#);0 }")})
        Me.tableCell20.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell20.Name = "tableCell20"
        Me.tableCell20.StylePriority.UseFont = False
        Me.tableCell20.StylePriority.UseTextAlignment = False
        Me.tableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell20.Weight = 0.15502991551259693R
        Me.tableCell20.WordWrap = False
        '
        'tableCell21
        '
        Me.tableCell21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.TWDV_AI", "{0:#,# ;(#,#); 0}")})
        Me.tableCell21.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell21.Name = "tableCell21"
        Me.tableCell21.StylePriority.UseFont = False
        Me.tableCell21.StylePriority.UseTextAlignment = False
        Me.tableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell21.Weight = 0.21968691443765456R
        Me.tableCell21.WordWrap = False
        '
        'tableCell22
        '
        Me.tableCell22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.TWDV_AA", "{0:#,# ;(#,#); 0}")})
        Me.tableCell22.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell22.Name = "tableCell22"
        Me.tableCell22.StylePriority.UseFont = False
        Me.tableCell22.StylePriority.UseTextAlignment = False
        Me.tableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell22.Weight = 0.21968169747630317R
        Me.tableCell22.WordWrap = False
        '
        'tableCell23
        '
        Me.tableCell23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.TWDV_CF", "{0:#,# ;(#,#);0 }")})
        Me.tableCell23.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell23.Name = "tableCell23"
        Me.tableCell23.StylePriority.UseFont = False
        Me.tableCell23.StylePriority.UseTextAlignment = False
        Me.tableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell23.Weight = 0.17024746078841949R
        Me.tableCell23.WordWrap = False
        '
        'XrTableCell1
        '
        Me.XrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.CA_NOTE_COLUMN")})
        Me.XrTableCell1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell1.Weight = 0.12466676700180671R
        '
        'groupFooterBand3
        '
        Me.groupFooterBand3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1})
        Me.groupFooterBand3.HeightF = 14.62498!
        Me.groupFooterBand3.KeepTogether = True
        Me.groupFooterBand3.Level = 2
        Me.groupFooterBand3.Name = "groupFooterBand3"
        Me.groupFooterBand3.StyleName = "ReportGroupFooterBandStyle"
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(205.9725!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(509.6757!, 14.62498!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UsePadding = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "    "
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'groupFooterBand4
        '
        Me.groupFooterBand4.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.tblTotalCategory_line_Bot2, Me.tblTotalCategory_line_Bot, Me.tblTotalCategory_line, Me.tblTotalCategory})
        Me.groupFooterBand4.HeightF = 47.80344!
        Me.groupFooterBand4.KeepTogether = True
        Me.groupFooterBand4.Level = 3
        Me.groupFooterBand4.Name = "groupFooterBand4"
        Me.groupFooterBand4.StyleName = "ReportGroupFooterBandStyle"
        '
        'tblTotalCategory_line_Bot2
        '
        Me.tblTotalCategory_line_Bot2.BackColor = System.Drawing.Color.Transparent
        Me.tblTotalCategory_line_Bot2.LocationFloat = New DevExpress.Utils.PointFloat(328.9727!, 29.17846!)
        Me.tblTotalCategory_line_Bot2.Name = "tblTotalCategory_line_Bot2"
        Me.tblTotalCategory_line_Bot2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.tblTotalCategory_line_Bot2.SizeF = New System.Drawing.SizeF(700.3177!, 2.0!)
        Me.tblTotalCategory_line_Bot2.StylePriority.UseBackColor = False
        Me.tblTotalCategory_line_Bot2.StylePriority.UsePadding = False
        '
        'tblTotalCategory_line_Bot
        '
        Me.tblTotalCategory_line_Bot.BackColor = System.Drawing.Color.Transparent
        Me.tblTotalCategory_line_Bot.LocationFloat = New DevExpress.Utils.PointFloat(328.9722!, 31.17846!)
        Me.tblTotalCategory_line_Bot.Name = "tblTotalCategory_line_Bot"
        Me.tblTotalCategory_line_Bot.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.tblTotalCategory_line_Bot.SizeF = New System.Drawing.SizeF(700.3182!, 2.0!)
        Me.tblTotalCategory_line_Bot.StylePriority.UseBackColor = False
        Me.tblTotalCategory_line_Bot.StylePriority.UsePadding = False
        '
        'tblTotalCategory_line
        '
        Me.tblTotalCategory_line.BackColor = System.Drawing.Color.Transparent
        Me.tblTotalCategory_line.LocationFloat = New DevExpress.Utils.PointFloat(328.7439!, 1.981608!)
        Me.tblTotalCategory_line.Name = "tblTotalCategory_line"
        Me.tblTotalCategory_line.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.tblTotalCategory_line.SizeF = New System.Drawing.SizeF(700.5465!, 2.0!)
        Me.tblTotalCategory_line.StylePriority.UseBackColor = False
        Me.tblTotalCategory_line.StylePriority.UsePadding = False
        '
        'tblTotalCategory
        '
        Me.tblTotalCategory.BackColor = System.Drawing.Color.Transparent
        Me.tblTotalCategory.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.tblTotalCategory.LocationFloat = New DevExpress.Utils.PointFloat(328.3502!, 3.981608!)
        Me.tblTotalCategory.Name = "tblTotalCategory"
        Me.tblTotalCategory.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow9})
        Me.tblTotalCategory.SizeF = New System.Drawing.SizeF(700.9403!, 25.19685!)
        Me.tblTotalCategory.StylePriority.UseBackColor = False
        Me.tblTotalCategory.StylePriority.UseFont = False
        '
        'tableRow9
        '
        Me.tableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell73, Me.tableCell74, Me.tableCell75, Me.tableCell76, Me.tableCell77, Me.tableCell78, Me.tableCell79, Me.tableCell80, Me.tableCell81, Me.tableCell82, Me.tableCell83})
        Me.tableRow9.Name = "tableRow9"
        Me.tableRow9.Weight = 10.46953028649871R
        '
        'tableCell73
        '
        Me.tableCell73.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.QC_BF")})
        Me.tableCell73.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell73.Name = "tableCell73"
        Me.tableCell73.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.tableCell73.StylePriority.UseFont = False
        Me.tableCell73.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary1.IgnoreNullValues = True
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell73.Summary = XrSummary1
        Me.tableCell73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell73.Weight = 0.13378430441832481R
        Me.tableCell73.WordWrap = False
        '
        'tableCell74
        '
        Me.tableCell74.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.QC_ADD")})
        Me.tableCell74.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell74.Name = "tableCell74"
        Me.tableCell74.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.tableCell74.StylePriority.UseFont = False
        Me.tableCell74.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary2.IgnoreNullValues = True
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell74.Summary = XrSummary2
        Me.tableCell74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell74.Weight = 0.13971494660433284R
        Me.tableCell74.WordWrap = False
        '
        'tableCell75
        '
        Me.tableCell75.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.QC_DISP")})
        Me.tableCell75.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell75.Name = "tableCell75"
        Me.tableCell75.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.tableCell75.StylePriority.UseFont = False
        Me.tableCell75.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary3.IgnoreNullValues = True
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell75.Summary = XrSummary3
        Me.tableCell75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell75.Weight = 0.12635090108379005R
        Me.tableCell75.WordWrap = False
        '
        'tableCell76
        '
        Me.tableCell76.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.QC_CF")})
        Me.tableCell76.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell76.Name = "tableCell76"
        Me.tableCell76.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.tableCell76.StylePriority.UseFont = False
        Me.tableCell76.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary4.IgnoreNullValues = True
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell76.Summary = XrSummary4
        Me.tableCell76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell76.Weight = 0.12450756511219464R
        Me.tableCell76.WordWrap = False
        '
        'tableCell77
        '
        Me.tableCell77.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.TWDV_BF")})
        Me.tableCell77.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell77.Name = "tableCell77"
        Me.tableCell77.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.tableCell77.StylePriority.UseFont = False
        Me.tableCell77.StylePriority.UseTextAlignment = False
        XrSummary5.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary5.IgnoreNullValues = True
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell77.Summary = XrSummary5
        Me.tableCell77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell77.Weight = 0.12635117144238484R
        Me.tableCell77.WordWrap = False
        '
        'tableCell78
        '
        Me.tableCell78.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.TWDV_ADD")})
        Me.tableCell78.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell78.Name = "tableCell78"
        Me.tableCell78.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.tableCell78.StylePriority.UseFont = False
        Me.tableCell78.StylePriority.UseTextAlignment = False
        XrSummary6.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary6.IgnoreNullValues = True
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell78.Summary = XrSummary6
        Me.tableCell78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell78.Weight = 0.13980399328694687R
        Me.tableCell78.WordWrap = False
        '
        'tableCell79
        '
        Me.tableCell79.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.TWDV_DISP")})
        Me.tableCell79.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell79.Name = "tableCell79"
        Me.tableCell79.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.tableCell79.StylePriority.UseFont = False
        Me.tableCell79.StylePriority.UseTextAlignment = False
        XrSummary7.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary7.IgnoreNullValues = True
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell79.Summary = XrSummary7
        Me.tableCell79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell79.Weight = 0.12627232100950914R
        Me.tableCell79.WordWrap = False
        '
        'tableCell80
        '
        Me.tableCell80.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.TWDV_TOTAL")})
        Me.tableCell80.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell80.Name = "tableCell80"
        Me.tableCell80.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.tableCell80.StylePriority.UseFont = False
        Me.tableCell80.StylePriority.UseTextAlignment = False
        XrSummary8.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary8.IgnoreNullValues = True
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell80.Summary = XrSummary8
        Me.tableCell80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell80.Weight = 0.12848814928545482R
        Me.tableCell80.WordWrap = False
        '
        'tableCell81
        '
        Me.tableCell81.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.TWDV_AI")})
        Me.tableCell81.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell81.Name = "tableCell81"
        Me.tableCell81.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.tableCell81.StylePriority.UseFont = False
        Me.tableCell81.StylePriority.UseTextAlignment = False
        XrSummary9.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary9.IgnoreNullValues = True
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell81.Summary = XrSummary9
        Me.tableCell81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell81.Weight = 0.18207404437878622R
        Me.tableCell81.WordWrap = False
        '
        'tableCell82
        '
        Me.tableCell82.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.TWDV_AA")})
        Me.tableCell82.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell82.Name = "tableCell82"
        Me.tableCell82.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.tableCell82.StylePriority.UseFont = False
        Me.tableCell82.StylePriority.UseTextAlignment = False
        XrSummary10.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary10.IgnoreNullValues = True
        XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell82.Summary = XrSummary10
        Me.tableCell82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell82.Weight = 0.18207018904372618R
        Me.tableCell82.WordWrap = False
        '
        'tableCell83
        '
        Me.tableCell83.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.TWDV_CF")})
        Me.tableCell83.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell83.Name = "tableCell83"
        Me.tableCell83.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.tableCell83.StylePriority.UseFont = False
        Me.tableCell83.StylePriority.UseTextAlignment = False
        XrSummary11.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary11.IgnoreNullValues = True
        XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell83.Summary = XrSummary11
        Me.tableCell83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell83.Weight = 0.14109862334328127R
        Me.tableCell83.WordWrap = False
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
        Me.bottomMarginBand1.HeightF = 39.0!
        Me.bottomMarginBand1.Name = "bottomMarginBand1"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrPageInfo1.Format = "Page {0} / {1}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(930.2746!, 0.0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'ReportHeaderBandStyle
        '
        Me.ReportHeaderBandStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ReportHeaderBandStyle.Name = "ReportHeaderBandStyle"
        Me.ReportHeaderBandStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.ReportHeaderBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportGroupHeaderBandStyle
        '
        Me.ReportGroupHeaderBandStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ReportGroupHeaderBandStyle.Name = "ReportGroupHeaderBandStyle"
        Me.ReportGroupHeaderBandStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.ReportGroupHeaderBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportDetailBandStyle
        '
        Me.ReportDetailBandStyle.BackColor = System.Drawing.Color.Transparent
        Me.ReportDetailBandStyle.Name = "ReportDetailBandStyle"
        Me.ReportDetailBandStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.ReportDetailBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportGroupFooterBandStyle
        '
        Me.ReportGroupFooterBandStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ReportGroupFooterBandStyle.Name = "ReportGroupFooterBandStyle"
        Me.ReportGroupFooterBandStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.ReportGroupFooterBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportFooterBandStyle
        '
        Me.ReportFooterBandStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ReportFooterBandStyle.Name = "ReportFooterBandStyle"
        Me.ReportFooterBandStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.ReportFooterBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportOddStyle
        '
        Me.ReportOddStyle.BackColor = System.Drawing.Color.Transparent
        Me.ReportOddStyle.Name = "ReportOddStyle"
        Me.ReportOddStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.ReportOddStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportEvenStyle
        '
        Me.ReportEvenStyle.BackColor = System.Drawing.Color.Transparent
        Me.ReportEvenStyle.Name = "ReportEvenStyle"
        Me.ReportEvenStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.ReportEvenStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 0.0!
        Me.PageFooter.Name = "PageFooter"
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
        'XrLabel6
        '
        Me.XrLabel6.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 4.16533!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel6.StylePriority.UseBackColor = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.Text = "TOTAL"
        '
        'tableCell98
        '
        Me.tableCell98.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.TWDV_CF")})
        Me.tableCell98.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell98.Name = "tableCell98"
        Me.tableCell98.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.tableCell98.StylePriority.UseFont = False
        Me.tableCell98.StylePriority.UseTextAlignment = False
        XrSummary12.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary12.IgnoreNullValues = True
        XrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell98.Summary = XrSummary12
        Me.tableCell98.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell98.Weight = 0.14239237010298994R
        Me.tableCell98.WordWrap = False
        '
        'tableCell97
        '
        Me.tableCell97.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.TWDV_AA")})
        Me.tableCell97.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell97.Name = "tableCell97"
        Me.tableCell97.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.tableCell97.StylePriority.UseFont = False
        Me.tableCell97.StylePriority.UseTextAlignment = False
        XrSummary13.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary13.IgnoreNullValues = True
        XrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell97.Summary = XrSummary13
        Me.tableCell97.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell97.Weight = 0.18373991593646261R
        Me.tableCell97.WordWrap = False
        '
        'tableCell96
        '
        Me.tableCell96.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.TWDV_AI")})
        Me.tableCell96.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell96.Name = "tableCell96"
        Me.tableCell96.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.tableCell96.StylePriority.UseFont = False
        Me.tableCell96.StylePriority.UseTextAlignment = False
        XrSummary14.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary14.IgnoreNullValues = True
        XrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell96.Summary = XrSummary14
        Me.tableCell96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell96.Weight = 0.18374379556606074R
        Me.tableCell96.WordWrap = False
        '
        'tableCell95
        '
        Me.tableCell95.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.TWDV_TOTAL")})
        Me.tableCell95.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell95.Name = "tableCell95"
        Me.tableCell95.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.tableCell95.StylePriority.UseFont = False
        Me.tableCell95.StylePriority.UseTextAlignment = False
        XrSummary15.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary15.IgnoreNullValues = True
        XrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell95.Summary = XrSummary15
        Me.tableCell95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell95.Weight = 0.12966648666862496R
        Me.tableCell95.WordWrap = False
        '
        'tableCell94
        '
        Me.tableCell94.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.TWDV_DISP")})
        Me.tableCell94.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell94.Name = "tableCell94"
        Me.tableCell94.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.tableCell94.StylePriority.UseFont = False
        Me.tableCell94.StylePriority.UseTextAlignment = False
        XrSummary16.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary16.IgnoreNullValues = True
        XrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell94.Summary = XrSummary16
        Me.tableCell94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell94.Weight = 0.12743034160979938R
        Me.tableCell94.WordWrap = False
        '
        'tableCell93
        '
        Me.tableCell93.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.TWDV_ADD")})
        Me.tableCell93.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell93.Name = "tableCell93"
        Me.tableCell93.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.tableCell93.StylePriority.UseFont = False
        Me.tableCell93.StylePriority.UseTextAlignment = False
        XrSummary17.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary17.IgnoreNullValues = True
        XrSummary17.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell93.Summary = XrSummary17
        Me.tableCell93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell93.Weight = 0.14108610617095879R
        Me.tableCell93.WordWrap = False
        '
        'tableCell92
        '
        Me.tableCell92.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.TWDV_BF")})
        Me.tableCell92.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell92.Name = "tableCell92"
        Me.tableCell92.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.tableCell92.StylePriority.UseFont = False
        Me.tableCell92.StylePriority.UseTextAlignment = False
        XrSummary18.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary18.IgnoreNullValues = True
        XrSummary18.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell92.Summary = XrSummary18
        Me.tableCell92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell92.Weight = 0.1275099054764344R
        Me.tableCell92.WordWrap = False
        '
        'tableCell91
        '
        Me.tableCell91.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.QC_CF")})
        Me.tableCell91.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell91.Name = "tableCell91"
        Me.tableCell91.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.tableCell91.StylePriority.UseFont = False
        Me.tableCell91.StylePriority.UseTextAlignment = False
        XrSummary19.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary19.IgnoreNullValues = True
        XrSummary19.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell91.Summary = XrSummary19
        Me.tableCell91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell91.Weight = 0.12564939420527108R
        Me.tableCell91.WordWrap = False
        '
        'tableCell90
        '
        Me.tableCell90.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.QC_DISP")})
        Me.tableCell90.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell90.Name = "tableCell90"
        Me.tableCell90.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.tableCell90.StylePriority.UseFont = False
        Me.tableCell90.StylePriority.UseTextAlignment = False
        XrSummary20.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary20.IgnoreNullValues = True
        XrSummary20.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell90.Summary = XrSummary20
        Me.tableCell90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell90.Weight = 0.12750962844404984R
        Me.tableCell90.WordWrap = False
        '
        'tableCell89
        '
        Me.tableCell89.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.QC_ADD")})
        Me.tableCell89.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell89.Name = "tableCell89"
        Me.tableCell89.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.tableCell89.StylePriority.UseFont = False
        Me.tableCell89.StylePriority.UseTextAlignment = False
        XrSummary21.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary21.IgnoreNullValues = True
        XrSummary21.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell89.Summary = XrSummary21
        Me.tableCell89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell89.Weight = 0.14099624064753241R
        Me.tableCell89.WordWrap = False
        '
        'tableCell88
        '
        Me.tableCell88.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_TEMP.QC_BF")})
        Me.tableCell88.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.tableCell88.Name = "tableCell88"
        Me.tableCell88.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.tableCell88.StylePriority.UseFont = False
        Me.tableCell88.StylePriority.UseTextAlignment = False
        XrSummary22.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary22.IgnoreNullValues = True
        XrSummary22.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell88.Summary = XrSummary22
        Me.tableCell88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell88.Weight = 0.13501120782588974R
        Me.tableCell88.WordWrap = False
        '
        'tableRow10
        '
        Me.tableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell88, Me.tableCell89, Me.tableCell90, Me.tableCell91, Me.tableCell92, Me.tableCell93, Me.tableCell94, Me.tableCell95, Me.tableCell96, Me.tableCell97, Me.tableCell98})
        Me.tableRow10.Name = "tableRow10"
        Me.tableRow10.Weight = 10.46953028649871R
        '
        'table10
        '
        Me.table10.BackColor = System.Drawing.Color.Transparent
        Me.table10.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.table10.LocationFloat = New DevExpress.Utils.PointFloat(328.3502!, 4.16533!)
        Me.table10.Name = "table10"
        Me.table10.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow10})
        Me.table10.SizeF = New System.Drawing.SizeF(700.9402!, 25.19685!)
        Me.table10.StylePriority.UseBackColor = False
        Me.table10.StylePriority.UseFont = False
        Me.table10.StylePriority.UseTextAlignment = False
        Me.table10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine4
        '
        Me.XrLine4.BackColor = System.Drawing.Color.Transparent
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(328.7439!, 0.0!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLine4.SizeF = New System.Drawing.SizeF(700.5465!, 2.0!)
        Me.XrLine4.StylePriority.UseBackColor = False
        Me.XrLine4.StylePriority.UsePadding = False
        Me.XrLine4.Visible = False
        '
        'XrLine5
        '
        Me.XrLine5.BackColor = System.Drawing.Color.Transparent
        Me.XrLine5.LocationFloat = New DevExpress.Utils.PointFloat(328.3501!, 29.36218!)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLine5.SizeF = New System.Drawing.SizeF(700.9414!, 2.083334!)
        Me.XrLine5.StylePriority.UseBackColor = False
        Me.XrLine5.StylePriority.UsePadding = False
        '
        'XrTableCell12
        '
        Me.XrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_NOTE.TWDV_CF")})
        Me.XrTableCell12.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StylePriority.UseFont = False
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.Text = "XrTableCell12"
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell12.Weight = 133.82319988967126R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_NOTE.TWDV_AA")})
        Me.XrTableCell11.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseFont = False
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.Text = "XrTableCell11"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell11.Weight = 172.67949758648996R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_NOTE.TWDV_AI")})
        Me.XrTableCell10.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseFont = False
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        Me.XrTableCell10.Text = "XrTableCell10"
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell10.Weight = 172.6831547311468R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_NOTE.TWDV_TOTAL")})
        Me.XrTableCell9.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "XrTableCell9"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell9.Weight = 121.86107002294901R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_NOTE.TWDV_DISP")})
        Me.XrTableCell8.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseFont = False
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.Text = "XrTableCell8"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell8.Weight = 119.75952908866967R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_NOTE.TWDV_ADD")})
        Me.XrTableCell7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseFont = False
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.Text = "XrTableCell7"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell7.Weight = 132.59327528675357R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_NOTE.TWDV_BF")})
        Me.XrTableCell6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseFont = False
        Me.XrTableCell6.StylePriority.UseTextAlignment = False
        Me.XrTableCell6.Text = "XrTableCell6"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell6.Weight = 119.83431400333475R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_NOTE.QC_CF")})
        Me.XrTableCell5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "XrTableCell5"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell5.Weight = 118.08579302014364R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_NOTE.QC_DISP")})
        Me.XrTableCell4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.Text = "XrTableCell4"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell4.Weight = 119.834436641298R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_NOTE.QC_ADD")})
        Me.XrTableCell3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "XrTableCell3"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell3.Weight = 132.50844089773329R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_NOTE.QC_BF")})
        Me.XrTableCell2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.Text = "XrTableCell2"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell2.Weight = 126.88432565515R
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell12})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 0.5679012345679012R
        '
        'XrTable1
        '
        Me.XrTable1.BackColor = System.Drawing.Color.Transparent
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(328.3501!, 37.5!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(700.9414!, 25.0!)
        Me.XrTable1.StylePriority.UseBackColor = False
        '
        'reportFooterBand1
        '
        Me.reportFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine3, Me.XrTable1, Me.XrLine5, Me.XrLine4, Me.table10, Me.XrLabel6})
        Me.reportFooterBand1.HeightF = 90.0!
        Me.reportFooterBand1.Name = "reportFooterBand1"
        Me.reportFooterBand1.StyleName = "ReportFooterBandStyle"
        '
        'XrLine3
        '
        Me.XrLine3.BackColor = System.Drawing.Color.Transparent
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(328.3505!, 31.44551!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLine3.SizeF = New System.Drawing.SizeF(700.941!, 2.083336!)
        Me.XrLine3.StylePriority.UseBackColor = False
        Me.XrLine3.StylePriority.UsePadding = False
        '
        'CAPEX
        '
        Me.CAPEX.Condition = "[CA_CATEGORY_CODE] == 'CAPEX'"
        Me.CAPEX.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.CAPEX.Name = "CAPEX"
        '
        'NOTCAPEX
        '
        Me.NOTCAPEX.Condition = "[CA_CATEGORY_CODE] == 'CAPEX'"
        Me.NOTCAPEX.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.NOTCAPEX.Name = "NOTCAPEX"
        '
        'ReportHeader
        '
        Me.ReportHeader.HeightF = 0.3750006!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'param_ShowDraft
        '
        Me.param_ShowDraft.Description = "param_ShowDraft"
        Me.param_ShowDraft.Name = "param_ShowDraft"
        Me.param_ShowDraft.Type = GetType(Boolean)
        Me.param_ShowDraft.ValueInfo = "False"
        '
        'rpt_CAByCategory
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.topMarginBand1, Me.pageHeaderBand1, Me.groupHeaderBand1, Me.groupHeaderBand2, Me.groupHeaderBand3, Me.groupHeaderBand4, Me.detailBand1, Me.groupFooterBand3, Me.groupFooterBand4, Me.reportFooterBand1, Me.bottomMarginBand1, Me.PageFooter, Me.ReportHeader})
        Me.DataMember = "CA_REPORT_TEMP"
        Me.DataSource = Me.DsCA
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.FormattingRule1, Me.CAPEX, Me.NOTCAPEX, Me.ShowDraft})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(78, 15, 39, 39)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.paramCompanyName, Me.paramYA, Me.FontSize, Me.paramSch, Me.param_ShowDraft, Me.paramTitle})
        Me.RequestParameters = False
        Me.SnapGridSize = 9.84252!
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.ReportHeaderBandStyle, Me.ReportGroupHeaderBandStyle, Me.ReportDetailBandStyle, Me.ReportGroupFooterBandStyle, Me.ReportFooterBandStyle, Me.ReportOddStyle, Me.ReportEvenStyle})
        Me.Version = "17.1"
        CType(Me.table3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblTotalCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAREPORTTEMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    'Private Sub groupHeaderBand4_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles groupHeaderBand4.BeforePrint
    '    Try
    '        Dim label As XRLabel = CType(sender, XRLabel)

    '        If String.IsNullOrEmpty(label.Text) Then
    '            groupHeaderBand4.Visible = False
    '        End If

    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub tblTotalCategory_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles tblTotalCategory.BeforePrint
        Try
            Dim CA_TRANSFERROR_NAME As String = Me.GetCurrentColumnValue("CA_TRANSFERROR_NAME")
            Dim ID As String = Me.GetCurrentColumnValue("ID")
            Dim YA As String = Me.GetCurrentColumnValue("YA")
            Dim Count As Integer = ADO.Load_CAReport_CA_REPORT_TEMP_CountByControlTransfer(ID, YA, CA_TRANSFERROR_NAME)

            If Count <= 1 Then
                tblTotalCategory.Visible = False
                tblTotalCategory_line.Visible = False
                tblTotalCategory_line_Bot.Visible = False
                tblTotalCategory_line_Bot2.Visible = False
            Else
                tblTotalCategory.Visible = True
                tblTotalCategory_line.Visible = True
                tblTotalCategory_line_Bot.Visible = True
                tblTotalCategory_line_Bot2.Visible = True
            End If

           
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tableCell6_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles tableCell6.BeforePrint
        Try
            Dim Val As String = Me.GetCurrentColumnValue("CA_CATEGORY_CODE")

            If Val.ToUpper <> "Capital Expenditure Expensed Off in Income Statement" Then
                tableCell6.Text = Val.Remove(0, 1)
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
