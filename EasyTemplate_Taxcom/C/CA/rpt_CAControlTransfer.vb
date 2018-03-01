Public Class rpt_CAControlTransfer
	Inherits DevExpress.XtraReports.UI.XtraReport
    Friend WithEvents DsCA As EasyTemplate_Taxcom.dsCA
    Private components As System.ComponentModel.IContainer
    Friend WithEvents CAREPORTCONTROLTRANSFERTEMPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportEvenStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportOddStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportFooterBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportGroupFooterBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportDetailBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportGroupHeaderBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportHeaderBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents reportFooterBand1 As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents tableCell100 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell99 As DevExpress.XtraReports.UI.XRTableCell
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
    Friend WithEvents tableCell87 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell86 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell85 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell84 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table8 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents groupFooterBand3 As DevExpress.XtraReports.UI.GroupFooterBand
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
    Friend WithEvents tableCell70 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell69 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell68 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell67 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell66 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table7 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents groupFooterBand2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents tableCell62 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell61 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell60 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell59 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell58 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell57 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell56 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell55 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell54 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell53 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell52 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell51 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell49 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell48 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell47 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell46 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table6 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents groupFooterBand1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents tableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents detailBand1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents tableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents groupHeaderBand3 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents groupHeaderBand2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents tableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents table2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents groupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents pageHeaderBand1 As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents tableCell65 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents DsCA1 As EasyTemplate_Taxcom.dsCA
    Friend WithEvents FormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paramCompanyName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents paramYA As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents table1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
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
        Dim XrSummary34 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary35 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary36 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary37 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary38 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary39 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary40 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary41 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary42 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary43 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary44 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary45 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary46 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary47 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary48 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary49 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary50 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary51 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.pageHeaderBand1 = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.FormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.table2 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.groupHeaderBand2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.groupHeaderBand3 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.table4 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.table5 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.groupFooterBand1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.table6 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell46 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell47 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell48 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell49 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell51 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell52 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell53 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell54 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell55 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell56 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell57 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell58 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell59 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell60 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell61 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell62 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.groupFooterBand2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.table7 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell65 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell66 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell67 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell68 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell69 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell70 = New DevExpress.XtraReports.UI.XRTableCell()
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
        Me.groupFooterBand3 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.table8 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell84 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell85 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell86 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell87 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell88 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell89 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell90 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell91 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell92 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell93 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell94 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell95 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell96 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell97 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell98 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell99 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell100 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.reportFooterBand1 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeaderBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportGroupHeaderBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportDetailBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportGroupFooterBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportFooterBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportOddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportEvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.CAREPORTCONTROLTRANSFERTEMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCA = New EasyTemplate_Taxcom.dsCA()
        Me.DsCA1 = New EasyTemplate_Taxcom.dsCA()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramCompanyName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.paramYA = New DevExpress.XtraReports.Parameters.Parameter()
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
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAREPORTCONTROLTRANSFERTEMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'topMarginBand1
        '
        Me.topMarginBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.XrLabel2, Me.XrLabel4, Me.XrLabel1})
        Me.topMarginBand1.Dpi = 254.0!
        Me.topMarginBand1.HeightF = 262.5725!
        Me.topMarginBand1.Name = "topMarginBand1"
        '
        'pageHeaderBand1
        '
        Me.pageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel6, Me.XrLabel14, Me.XrLabel5, Me.XrLabel7, Me.XrLabel8, Me.XrLabel9, Me.XrLabel10, Me.XrLabel11, Me.XrLabel12, Me.XrLabel13, Me.table1})
        Me.pageHeaderBand1.Dpi = 254.0!
        Me.pageHeaderBand1.HeightF = 259.7916!
        Me.pageHeaderBand1.Name = "pageHeaderBand1"
        Me.pageHeaderBand1.StyleName = "ReportHeaderBandStyle"
        '
        'FormattingRule1
        '
        Me.FormattingRule1.Condition = "[AA_10] is null"
        Me.FormattingRule1.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.FormattingRule1.Name = "FormattingRule1"
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
        Me.table2.SizeF = New System.Drawing.SizeF(1433.0!, 64.0!)
        '
        'tableRow2
        '
        Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell20, Me.tableCell21})
        Me.tableRow2.Dpi = 254.0!
        Me.tableRow2.Name = "tableRow2"
        Me.tableRow2.Weight = 10.46953028649871R
        '
        'tableCell20
        '
        Me.tableCell20.Dpi = 254.0!
        Me.tableCell20.Name = "tableCell20"
        Me.tableCell20.Text = "CA_CATEGORY_CODE:"
        Me.tableCell20.Weight = 0.42251310096055683R
        Me.tableCell20.WordWrap = False
        '
        'tableCell21
        '
        Me.tableCell21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_CATEGORY_CODE")})
        Me.tableCell21.Dpi = 254.0!
        Me.tableCell21.Name = "tableCell21"
        Me.tableCell21.Weight = 0.96954642162021631R
        Me.tableCell21.WordWrap = False
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
        Me.table4.SizeF = New System.Drawing.SizeF(1433.0!, 64.0!)
        '
        'tableRow4
        '
        Me.tableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell24, Me.tableCell25})
        Me.tableRow4.Dpi = 254.0!
        Me.tableRow4.Name = "tableRow4"
        Me.tableRow4.Weight = 10.46953028649871R
        '
        'tableCell24
        '
        Me.tableCell24.Dpi = 254.0!
        Me.tableCell24.Name = "tableCell24"
        Me.tableCell24.Text = "CA_TRANSFERROR_NAME:"
        Me.tableCell24.Weight = 0.46836480154164423R
        Me.tableCell24.WordWrap = False
        '
        'tableCell25
        '
        Me.tableCell25.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_TRANSFERROR_NAME")})
        Me.tableCell25.Dpi = 254.0!
        Me.tableCell25.Name = "tableCell25"
        Me.tableCell25.Weight = 0.9650767758453116R
        Me.tableCell25.WordWrap = False
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
        Me.table5.SizeF = New System.Drawing.SizeF(731.4741!, 64.0!)
        '
        'tableRow5
        '
        Me.tableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell26, Me.XrTableCell1})
        Me.tableRow5.Dpi = 254.0!
        Me.tableRow5.Name = "tableRow5"
        Me.tableRow5.Weight = 10.46953028649871R
        '
        'tableCell26
        '
        Me.tableCell26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_ASSET")})
        Me.tableCell26.Dpi = 254.0!
        Me.tableCell26.Name = "tableCell26"
        Me.tableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.tableCell26.Weight = 0.33669895629666907R
        Me.tableCell26.WordWrap = False
        '
        'groupFooterBand1
        '
        Me.groupFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table6})
        Me.groupFooterBand1.Dpi = 254.0!
        Me.groupFooterBand1.HeightF = 64.0!
        Me.groupFooterBand1.Name = "groupFooterBand1"
        Me.groupFooterBand1.StyleName = "ReportGroupFooterBandStyle"
        '
        'table6
        '
        Me.table6.Dpi = 254.0!
        Me.table6.LocationFloat = New DevExpress.Utils.PointFloat(351.4005!, 0.0!)
        Me.table6.Name = "table6"
        Me.table6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow6})
        Me.table6.SizeF = New System.Drawing.SizeF(2394.148!, 64.0!)
        '
        'tableRow6
        '
        Me.tableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell46, Me.tableCell47, Me.tableCell48, Me.tableCell49, Me.tableCell50, Me.tableCell51, Me.tableCell52, Me.tableCell53, Me.tableCell54, Me.tableCell55, Me.tableCell56, Me.tableCell57, Me.tableCell58, Me.tableCell59, Me.tableCell60, Me.tableCell61, Me.tableCell62})
        Me.tableRow6.Dpi = 254.0!
        Me.tableRow6.Name = "tableRow6"
        Me.tableRow6.Weight = 10.46953028649871R
        '
        'tableCell46
        '
        Me.tableCell46.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_PURCHASE_AMOUNT")})
        Me.tableCell46.Dpi = 254.0!
        Me.tableCell46.Name = "tableCell46"
        Me.tableCell46.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.IgnoreNullValues = True
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell46.Summary = XrSummary1
        Me.tableCell46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell46.Weight = 0.12642726127106574R
        Me.tableCell46.WordWrap = False
        '
        'tableCell47
        '
        Me.tableCell47.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_TRANSFER_VAL")})
        Me.tableCell47.Dpi = 254.0!
        Me.tableCell47.Name = "tableCell47"
        Me.tableCell47.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary2.FormatString = "{0:n2}"
        XrSummary2.IgnoreNullValues = True
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell47.Summary = XrSummary2
        Me.tableCell47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell47.Weight = 0.12642726127106574R
        Me.tableCell47.WordWrap = False
        '
        'tableCell48
        '
        Me.tableCell48.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_BF")})
        Me.tableCell48.Dpi = 254.0!
        Me.tableCell48.Name = "tableCell48"
        Me.tableCell48.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary3.FormatString = "{0:n2}"
        XrSummary3.IgnoreNullValues = True
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell48.Summary = XrSummary3
        Me.tableCell48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell48.Weight = 0.12642726127106574R
        Me.tableCell48.WordWrap = False
        '
        'tableCell49
        '
        Me.tableCell49.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_0")})
        Me.tableCell49.Dpi = 254.0!
        Me.tableCell49.Name = "tableCell49"
        Me.tableCell49.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary4.FormatString = "{0:n2}"
        XrSummary4.IgnoreNullValues = True
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell49.Summary = XrSummary4
        Me.tableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell49.Weight = 0.12642726127106574R
        Me.tableCell49.WordWrap = False
        '
        'tableCell50
        '
        Me.tableCell50.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_2")})
        Me.tableCell50.Dpi = 254.0!
        Me.tableCell50.Name = "tableCell50"
        Me.tableCell50.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary5.FormatString = "{0:n2}"
        XrSummary5.IgnoreNullValues = True
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell50.Summary = XrSummary5
        Me.tableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell50.Weight = 0.12642726127106574R
        Me.tableCell50.WordWrap = False
        '
        'tableCell51
        '
        Me.tableCell51.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_3")})
        Me.tableCell51.Dpi = 254.0!
        Me.tableCell51.Name = "tableCell51"
        Me.tableCell51.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary6.FormatString = "{0:n2}"
        XrSummary6.IgnoreNullValues = True
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell51.Summary = XrSummary6
        Me.tableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell51.Weight = 0.12642726127106574R
        Me.tableCell51.WordWrap = False
        '
        'tableCell52
        '
        Me.tableCell52.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_8")})
        Me.tableCell52.Dpi = 254.0!
        Me.tableCell52.Name = "tableCell52"
        Me.tableCell52.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary7.FormatString = "{0:n2}"
        XrSummary7.IgnoreNullValues = True
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell52.Summary = XrSummary7
        Me.tableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell52.Weight = 0.12642726127106574R
        Me.tableCell52.WordWrap = False
        '
        'tableCell53
        '
        Me.tableCell53.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_10")})
        Me.tableCell53.Dpi = 254.0!
        Me.tableCell53.Name = "tableCell53"
        Me.tableCell53.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary8.FormatString = "{0:n2}"
        XrSummary8.IgnoreNullValues = True
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell53.Summary = XrSummary8
        Me.tableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell53.Weight = 0.12642726127106574R
        Me.tableCell53.WordWrap = False
        '
        'tableCell54
        '
        Me.tableCell54.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_12")})
        Me.tableCell54.Dpi = 254.0!
        Me.tableCell54.Name = "tableCell54"
        Me.tableCell54.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary9.FormatString = "{0:n2}"
        XrSummary9.IgnoreNullValues = True
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell54.Summary = XrSummary9
        Me.tableCell54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell54.Weight = 0.12642726127106574R
        Me.tableCell54.WordWrap = False
        '
        'tableCell55
        '
        Me.tableCell55.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_14")})
        Me.tableCell55.Dpi = 254.0!
        Me.tableCell55.Name = "tableCell55"
        Me.tableCell55.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary10.FormatString = "{0:n2}"
        XrSummary10.IgnoreNullValues = True
        XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell55.Summary = XrSummary10
        Me.tableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell55.Weight = 0.12642726127106574R
        Me.tableCell55.WordWrap = False
        '
        'tableCell56
        '
        Me.tableCell56.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_16")})
        Me.tableCell56.Dpi = 254.0!
        Me.tableCell56.Name = "tableCell56"
        Me.tableCell56.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary11.FormatString = "{0:n2}"
        XrSummary11.IgnoreNullValues = True
        XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell56.Summary = XrSummary11
        Me.tableCell56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell56.Weight = 0.12642726127106574R
        Me.tableCell56.WordWrap = False
        '
        'tableCell57
        '
        Me.tableCell57.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_20")})
        Me.tableCell57.Dpi = 254.0!
        Me.tableCell57.Name = "tableCell57"
        Me.tableCell57.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary12.FormatString = "{0:n2}"
        XrSummary12.IgnoreNullValues = True
        XrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell57.Summary = XrSummary12
        Me.tableCell57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell57.Weight = 0.12642726127106574R
        Me.tableCell57.WordWrap = False
        '
        'tableCell58
        '
        Me.tableCell58.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_40")})
        Me.tableCell58.Dpi = 254.0!
        Me.tableCell58.Name = "tableCell58"
        Me.tableCell58.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary13.FormatString = "{0:n2}"
        XrSummary13.IgnoreNullValues = True
        XrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell58.Summary = XrSummary13
        Me.tableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell58.Weight = 0.12642726127106574R
        Me.tableCell58.WordWrap = False
        '
        'tableCell59
        '
        Me.tableCell59.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_50")})
        Me.tableCell59.Dpi = 254.0!
        Me.tableCell59.Name = "tableCell59"
        Me.tableCell59.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary14.FormatString = "{0:n2}"
        XrSummary14.IgnoreNullValues = True
        XrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell59.Summary = XrSummary14
        Me.tableCell59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell59.Weight = 0.12642726127106574R
        Me.tableCell59.WordWrap = False
        '
        'tableCell60
        '
        Me.tableCell60.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_60")})
        Me.tableCell60.Dpi = 254.0!
        Me.tableCell60.Name = "tableCell60"
        Me.tableCell60.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary15.FormatString = "{0:n2}"
        XrSummary15.IgnoreNullValues = True
        XrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell60.Summary = XrSummary15
        Me.tableCell60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell60.Weight = 0.12642726127106574R
        Me.tableCell60.WordWrap = False
        '
        'tableCell61
        '
        Me.tableCell61.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_80")})
        Me.tableCell61.Dpi = 254.0!
        Me.tableCell61.Name = "tableCell61"
        Me.tableCell61.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary16.FormatString = "{0:n2}"
        XrSummary16.IgnoreNullValues = True
        XrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell61.Summary = XrSummary16
        Me.tableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell61.Weight = 0.12642726127106574R
        Me.tableCell61.WordWrap = False
        '
        'tableCell62
        '
        Me.tableCell62.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_90")})
        Me.tableCell62.Dpi = 254.0!
        Me.tableCell62.Name = "tableCell62"
        Me.tableCell62.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary17.FormatString = "{0:n2}"
        XrSummary17.IgnoreNullValues = True
        XrSummary17.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell62.Summary = XrSummary17
        Me.tableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell62.Weight = 0.12642726127106574R
        Me.tableCell62.WordWrap = False
        '
        'groupFooterBand2
        '
        Me.groupFooterBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table7})
        Me.groupFooterBand2.Dpi = 254.0!
        Me.groupFooterBand2.HeightF = 64.0!
        Me.groupFooterBand2.Level = 1
        Me.groupFooterBand2.Name = "groupFooterBand2"
        Me.groupFooterBand2.StyleName = "ReportGroupFooterBandStyle"
        '
        'table7
        '
        Me.table7.Dpi = 254.0!
        Me.table7.LocationFloat = New DevExpress.Utils.PointFloat(351.4005!, 0.0!)
        Me.table7.Name = "table7"
        Me.table7.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow7})
        Me.table7.SizeF = New System.Drawing.SizeF(2394.148!, 64.0!)
        '
        'tableRow7
        '
        Me.tableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell65, Me.tableCell66, Me.tableCell67, Me.tableCell68, Me.tableCell69, Me.tableCell70, Me.tableCell71, Me.tableCell72, Me.tableCell73, Me.tableCell74, Me.tableCell75, Me.tableCell76, Me.tableCell77, Me.tableCell78, Me.tableCell79, Me.tableCell80, Me.tableCell81})
        Me.tableRow7.Dpi = 254.0!
        Me.tableRow7.Name = "tableRow7"
        Me.tableRow7.Weight = 10.46953028649871R
        '
        'tableCell65
        '
        Me.tableCell65.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_PURCHASE_AMOUNT")})
        Me.tableCell65.Dpi = 254.0!
        Me.tableCell65.Name = "tableCell65"
        Me.tableCell65.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        XrSummary18.FormatString = "{0:n2}"
        XrSummary18.IgnoreNullValues = True
        XrSummary18.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell65.Summary = XrSummary18
        Me.tableCell65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell65.Weight = 0.1208062241445825R
        Me.tableCell65.WordWrap = False
        '
        'tableCell66
        '
        Me.tableCell66.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_TRANSFER_VAL")})
        Me.tableCell66.Dpi = 254.0!
        Me.tableCell66.Name = "tableCell66"
        Me.tableCell66.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        XrSummary19.FormatString = "{0:n2}"
        XrSummary19.IgnoreNullValues = True
        XrSummary19.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell66.Summary = XrSummary19
        Me.tableCell66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell66.Weight = 0.1208062241445825R
        Me.tableCell66.WordWrap = False
        '
        'tableCell67
        '
        Me.tableCell67.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_BF")})
        Me.tableCell67.Dpi = 254.0!
        Me.tableCell67.Name = "tableCell67"
        Me.tableCell67.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        XrSummary20.FormatString = "{0:n2}"
        XrSummary20.IgnoreNullValues = True
        XrSummary20.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell67.Summary = XrSummary20
        Me.tableCell67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell67.Weight = 0.1208062241445825R
        Me.tableCell67.WordWrap = False
        '
        'tableCell68
        '
        Me.tableCell68.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_0")})
        Me.tableCell68.Dpi = 254.0!
        Me.tableCell68.Name = "tableCell68"
        Me.tableCell68.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        XrSummary21.FormatString = "{0:n2}"
        XrSummary21.IgnoreNullValues = True
        XrSummary21.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell68.Summary = XrSummary21
        Me.tableCell68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell68.Weight = 0.1208062241445825R
        Me.tableCell68.WordWrap = False
        '
        'tableCell69
        '
        Me.tableCell69.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_2")})
        Me.tableCell69.Dpi = 254.0!
        Me.tableCell69.Name = "tableCell69"
        Me.tableCell69.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        XrSummary22.FormatString = "{0:n2}"
        XrSummary22.IgnoreNullValues = True
        XrSummary22.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell69.Summary = XrSummary22
        Me.tableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell69.Weight = 0.1208062241445825R
        Me.tableCell69.WordWrap = False
        '
        'tableCell70
        '
        Me.tableCell70.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_3")})
        Me.tableCell70.Dpi = 254.0!
        Me.tableCell70.Name = "tableCell70"
        Me.tableCell70.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        XrSummary23.FormatString = "{0:n2}"
        XrSummary23.IgnoreNullValues = True
        XrSummary23.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell70.Summary = XrSummary23
        Me.tableCell70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell70.Weight = 0.1208062241445825R
        Me.tableCell70.WordWrap = False
        '
        'tableCell71
        '
        Me.tableCell71.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_8")})
        Me.tableCell71.Dpi = 254.0!
        Me.tableCell71.Name = "tableCell71"
        Me.tableCell71.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        XrSummary24.FormatString = "{0:n2}"
        XrSummary24.IgnoreNullValues = True
        XrSummary24.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell71.Summary = XrSummary24
        Me.tableCell71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell71.Weight = 0.1208062241445825R
        Me.tableCell71.WordWrap = False
        '
        'tableCell72
        '
        Me.tableCell72.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_10")})
        Me.tableCell72.Dpi = 254.0!
        Me.tableCell72.Name = "tableCell72"
        Me.tableCell72.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        XrSummary25.FormatString = "{0:n2}"
        XrSummary25.IgnoreNullValues = True
        XrSummary25.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell72.Summary = XrSummary25
        Me.tableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell72.Weight = 0.1208062241445825R
        Me.tableCell72.WordWrap = False
        '
        'tableCell73
        '
        Me.tableCell73.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_12")})
        Me.tableCell73.Dpi = 254.0!
        Me.tableCell73.Name = "tableCell73"
        Me.tableCell73.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        XrSummary26.FormatString = "{0:n2}"
        XrSummary26.IgnoreNullValues = True
        XrSummary26.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell73.Summary = XrSummary26
        Me.tableCell73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell73.Weight = 0.1208062241445825R
        Me.tableCell73.WordWrap = False
        '
        'tableCell74
        '
        Me.tableCell74.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_14")})
        Me.tableCell74.Dpi = 254.0!
        Me.tableCell74.Name = "tableCell74"
        Me.tableCell74.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        XrSummary27.FormatString = "{0:n2}"
        XrSummary27.IgnoreNullValues = True
        XrSummary27.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell74.Summary = XrSummary27
        Me.tableCell74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell74.Weight = 0.1208062241445825R
        Me.tableCell74.WordWrap = False
        '
        'tableCell75
        '
        Me.tableCell75.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_16")})
        Me.tableCell75.Dpi = 254.0!
        Me.tableCell75.Name = "tableCell75"
        Me.tableCell75.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        XrSummary28.FormatString = "{0:n2}"
        XrSummary28.IgnoreNullValues = True
        XrSummary28.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell75.Summary = XrSummary28
        Me.tableCell75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell75.Weight = 0.1208062241445825R
        Me.tableCell75.WordWrap = False
        '
        'tableCell76
        '
        Me.tableCell76.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_20")})
        Me.tableCell76.Dpi = 254.0!
        Me.tableCell76.Name = "tableCell76"
        Me.tableCell76.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        XrSummary29.FormatString = "{0:n2}"
        XrSummary29.IgnoreNullValues = True
        XrSummary29.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell76.Summary = XrSummary29
        Me.tableCell76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell76.Weight = 0.1208062241445825R
        Me.tableCell76.WordWrap = False
        '
        'tableCell77
        '
        Me.tableCell77.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_40")})
        Me.tableCell77.Dpi = 254.0!
        Me.tableCell77.Name = "tableCell77"
        Me.tableCell77.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        XrSummary30.FormatString = "{0:n2}"
        XrSummary30.IgnoreNullValues = True
        XrSummary30.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell77.Summary = XrSummary30
        Me.tableCell77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell77.Weight = 0.1208062241445825R
        Me.tableCell77.WordWrap = False
        '
        'tableCell78
        '
        Me.tableCell78.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_50")})
        Me.tableCell78.Dpi = 254.0!
        Me.tableCell78.Name = "tableCell78"
        Me.tableCell78.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        XrSummary31.FormatString = "{0:n2}"
        XrSummary31.IgnoreNullValues = True
        XrSummary31.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell78.Summary = XrSummary31
        Me.tableCell78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell78.Weight = 0.1208062241445825R
        Me.tableCell78.WordWrap = False
        '
        'tableCell79
        '
        Me.tableCell79.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_60")})
        Me.tableCell79.Dpi = 254.0!
        Me.tableCell79.Name = "tableCell79"
        Me.tableCell79.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        XrSummary32.FormatString = "{0:n2}"
        XrSummary32.IgnoreNullValues = True
        XrSummary32.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell79.Summary = XrSummary32
        Me.tableCell79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell79.Weight = 0.1208062241445825R
        Me.tableCell79.WordWrap = False
        '
        'tableCell80
        '
        Me.tableCell80.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_80")})
        Me.tableCell80.Dpi = 254.0!
        Me.tableCell80.Name = "tableCell80"
        Me.tableCell80.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        XrSummary33.FormatString = "{0:n2}"
        XrSummary33.IgnoreNullValues = True
        XrSummary33.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell80.Summary = XrSummary33
        Me.tableCell80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell80.Weight = 0.1208062241445825R
        Me.tableCell80.WordWrap = False
        '
        'tableCell81
        '
        Me.tableCell81.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_90")})
        Me.tableCell81.Dpi = 254.0!
        Me.tableCell81.Name = "tableCell81"
        Me.tableCell81.Padding = New DevExpress.XtraPrinting.PaddingInfo(11, 11, 0, 0, 254.0!)
        XrSummary34.FormatString = "{0:n2}"
        XrSummary34.IgnoreNullValues = True
        XrSummary34.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell81.Summary = XrSummary34
        Me.tableCell81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell81.Weight = 0.1208062241445825R
        Me.tableCell81.WordWrap = False
        '
        'groupFooterBand3
        '
        Me.groupFooterBand3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table8})
        Me.groupFooterBand3.Dpi = 254.0!
        Me.groupFooterBand3.HeightF = 64.0!
        Me.groupFooterBand3.Level = 2
        Me.groupFooterBand3.Name = "groupFooterBand3"
        Me.groupFooterBand3.StyleName = "ReportGroupFooterBandStyle"
        '
        'table8
        '
        Me.table8.Dpi = 254.0!
        Me.table8.LocationFloat = New DevExpress.Utils.PointFloat(351.4005!, 0.0!)
        Me.table8.Name = "table8"
        Me.table8.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow8})
        Me.table8.SizeF = New System.Drawing.SizeF(2394.148!, 64.0!)
        '
        'tableRow8
        '
        Me.tableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell84, Me.tableCell85, Me.tableCell86, Me.tableCell87, Me.tableCell88, Me.tableCell89, Me.tableCell90, Me.tableCell91, Me.tableCell92, Me.tableCell93, Me.tableCell94, Me.tableCell95, Me.tableCell96, Me.tableCell97, Me.tableCell98, Me.tableCell99, Me.tableCell100})
        Me.tableRow8.Dpi = 254.0!
        Me.tableRow8.Name = "tableRow8"
        Me.tableRow8.Weight = 10.46953028649871R
        '
        'tableCell84
        '
        Me.tableCell84.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_PURCHASE_AMOUNT")})
        Me.tableCell84.Dpi = 254.0!
        Me.tableCell84.Name = "tableCell84"
        Me.tableCell84.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary35.FormatString = "{0:n2}"
        XrSummary35.IgnoreNullValues = True
        XrSummary35.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell84.Summary = XrSummary35
        Me.tableCell84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell84.Weight = 0.11566374007422693R
        Me.tableCell84.WordWrap = False
        '
        'tableCell85
        '
        Me.tableCell85.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_TRANSFER_VAL")})
        Me.tableCell85.Dpi = 254.0!
        Me.tableCell85.Name = "tableCell85"
        Me.tableCell85.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary36.FormatString = "{0:n2}"
        XrSummary36.IgnoreNullValues = True
        XrSummary36.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell85.Summary = XrSummary36
        Me.tableCell85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell85.Weight = 0.11566374007422693R
        Me.tableCell85.WordWrap = False
        '
        'tableCell86
        '
        Me.tableCell86.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TWDV_BF")})
        Me.tableCell86.Dpi = 254.0!
        Me.tableCell86.Name = "tableCell86"
        Me.tableCell86.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary37.FormatString = "{0:n2}"
        XrSummary37.IgnoreNullValues = True
        XrSummary37.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell86.Summary = XrSummary37
        Me.tableCell86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell86.Weight = 0.11566374007422693R
        Me.tableCell86.WordWrap = False
        '
        'tableCell87
        '
        Me.tableCell87.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_0")})
        Me.tableCell87.Dpi = 254.0!
        Me.tableCell87.Name = "tableCell87"
        Me.tableCell87.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary38.FormatString = "{0:n2}"
        XrSummary38.IgnoreNullValues = True
        XrSummary38.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell87.Summary = XrSummary38
        Me.tableCell87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell87.Weight = 0.11566374007422693R
        Me.tableCell87.WordWrap = False
        '
        'tableCell88
        '
        Me.tableCell88.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_2")})
        Me.tableCell88.Dpi = 254.0!
        Me.tableCell88.Name = "tableCell88"
        Me.tableCell88.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary39.FormatString = "{0:n2}"
        XrSummary39.IgnoreNullValues = True
        XrSummary39.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell88.Summary = XrSummary39
        Me.tableCell88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell88.Weight = 0.11566374007422693R
        Me.tableCell88.WordWrap = False
        '
        'tableCell89
        '
        Me.tableCell89.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_3")})
        Me.tableCell89.Dpi = 254.0!
        Me.tableCell89.Name = "tableCell89"
        Me.tableCell89.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary40.FormatString = "{0:n2}"
        XrSummary40.IgnoreNullValues = True
        XrSummary40.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell89.Summary = XrSummary40
        Me.tableCell89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell89.Weight = 0.11566374007422693R
        Me.tableCell89.WordWrap = False
        '
        'tableCell90
        '
        Me.tableCell90.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_8")})
        Me.tableCell90.Dpi = 254.0!
        Me.tableCell90.Name = "tableCell90"
        Me.tableCell90.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary41.FormatString = "{0:n2}"
        XrSummary41.IgnoreNullValues = True
        XrSummary41.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell90.Summary = XrSummary41
        Me.tableCell90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell90.Weight = 0.11566374007422693R
        Me.tableCell90.WordWrap = False
        '
        'tableCell91
        '
        Me.tableCell91.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_10")})
        Me.tableCell91.Dpi = 254.0!
        Me.tableCell91.Name = "tableCell91"
        Me.tableCell91.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary42.FormatString = "{0:n2}"
        XrSummary42.IgnoreNullValues = True
        XrSummary42.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell91.Summary = XrSummary42
        Me.tableCell91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell91.Weight = 0.11566374007422693R
        Me.tableCell91.WordWrap = False
        '
        'tableCell92
        '
        Me.tableCell92.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_12")})
        Me.tableCell92.Dpi = 254.0!
        Me.tableCell92.Name = "tableCell92"
        Me.tableCell92.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary43.FormatString = "{0:n2}"
        XrSummary43.IgnoreNullValues = True
        XrSummary43.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell92.Summary = XrSummary43
        Me.tableCell92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell92.Weight = 0.11566374007422693R
        Me.tableCell92.WordWrap = False
        '
        'tableCell93
        '
        Me.tableCell93.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_14")})
        Me.tableCell93.Dpi = 254.0!
        Me.tableCell93.Name = "tableCell93"
        Me.tableCell93.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary44.FormatString = "{0:n2}"
        XrSummary44.IgnoreNullValues = True
        XrSummary44.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell93.Summary = XrSummary44
        Me.tableCell93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell93.Weight = 0.11566374007422693R
        Me.tableCell93.WordWrap = False
        '
        'tableCell94
        '
        Me.tableCell94.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_16")})
        Me.tableCell94.Dpi = 254.0!
        Me.tableCell94.Name = "tableCell94"
        Me.tableCell94.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary45.FormatString = "{0:n2}"
        XrSummary45.IgnoreNullValues = True
        XrSummary45.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell94.Summary = XrSummary45
        Me.tableCell94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell94.Weight = 0.11566374007422693R
        Me.tableCell94.WordWrap = False
        '
        'tableCell95
        '
        Me.tableCell95.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_20")})
        Me.tableCell95.Dpi = 254.0!
        Me.tableCell95.Name = "tableCell95"
        Me.tableCell95.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary46.FormatString = "{0:n2}"
        XrSummary46.IgnoreNullValues = True
        XrSummary46.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell95.Summary = XrSummary46
        Me.tableCell95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell95.Weight = 0.11566374007422693R
        Me.tableCell95.WordWrap = False
        '
        'tableCell96
        '
        Me.tableCell96.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_40")})
        Me.tableCell96.Dpi = 254.0!
        Me.tableCell96.Name = "tableCell96"
        Me.tableCell96.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary47.FormatString = "{0:n2}"
        XrSummary47.IgnoreNullValues = True
        XrSummary47.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell96.Summary = XrSummary47
        Me.tableCell96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell96.Weight = 0.11566374007422693R
        Me.tableCell96.WordWrap = False
        '
        'tableCell97
        '
        Me.tableCell97.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_50")})
        Me.tableCell97.Dpi = 254.0!
        Me.tableCell97.Name = "tableCell97"
        Me.tableCell97.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary48.FormatString = "{0:n2}"
        XrSummary48.IgnoreNullValues = True
        XrSummary48.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell97.Summary = XrSummary48
        Me.tableCell97.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell97.Weight = 0.11566374007422693R
        Me.tableCell97.WordWrap = False
        '
        'tableCell98
        '
        Me.tableCell98.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_60")})
        Me.tableCell98.Dpi = 254.0!
        Me.tableCell98.Name = "tableCell98"
        Me.tableCell98.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary49.FormatString = "{0:n2}"
        XrSummary49.IgnoreNullValues = True
        XrSummary49.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell98.Summary = XrSummary49
        Me.tableCell98.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell98.Weight = 0.11566374007422693R
        Me.tableCell98.WordWrap = False
        '
        'tableCell99
        '
        Me.tableCell99.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_80")})
        Me.tableCell99.Dpi = 254.0!
        Me.tableCell99.Name = "tableCell99"
        Me.tableCell99.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary50.FormatString = "{0:n2}"
        XrSummary50.IgnoreNullValues = True
        XrSummary50.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell99.Summary = XrSummary50
        Me.tableCell99.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell99.Weight = 0.11566374007422693R
        Me.tableCell99.WordWrap = False
        '
        'tableCell100
        '
        Me.tableCell100.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AA_90")})
        Me.tableCell100.Dpi = 254.0!
        Me.tableCell100.Name = "tableCell100"
        Me.tableCell100.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 96.0!)
        XrSummary51.FormatString = "{0:n2}"
        XrSummary51.IgnoreNullValues = True
        XrSummary51.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.tableCell100.Summary = XrSummary51
        Me.tableCell100.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell100.Weight = 0.11566374007422693R
        Me.tableCell100.WordWrap = False
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
        'CAREPORTCONTROLTRANSFERTEMPBindingSource
        '
        Me.CAREPORTCONTROLTRANSFERTEMPBindingSource.DataMember = "CA_REPORT_CONTROLTRANSFER_TEMP"
        Me.CAREPORTCONTROLTRANSFERTEMPBindingSource.DataSource = Me.DsCA
        '
        'DsCA
        '
        Me.DsCA.DataSetName = "dsCA"
        Me.DsCA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsCA1
        '
        Me.DsCA1.DataSetName = "dsCA"
        Me.DsCA1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 116.84!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(1690.687!, 58.42001!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "CONTROLLED TRANSFER OF PROPERTY, PLANT AND EQUIPMENT FROM RELATED COMPANIES"
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramYA, "Text", "INCOME TAX COMPUTATION - YEAR OF ASSESSMENT  {0}")})
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 58.42001!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(920.75!, 58.42!)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseFont = False
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramCompanyName, "Text", "")})
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(156.1042!, 0.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(1397.0!, 58.42!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseFont = False
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(156.1042!, 58.42!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "NAME : "
        '
        'paramCompanyName
        '
        Me.paramCompanyName.Description = "paramCompanyName"
        Me.paramCompanyName.Name = "paramCompanyName"
        '
        'paramYA
        '
        Me.paramYA.Description = "Parameter1"
        Me.paramYA.Name = "paramYA"
        Me.paramYA.Type = GetType(Integer)
        Me.paramYA.ValueInfo = "0"
        '
        'table1
        '
        Me.table1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.table1.Dpi = 254.0!
        Me.table1.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(1.884635!, 96.70849!)
        Me.table1.Name = "table1"
        Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow1})
        Me.table1.SizeF = New System.Drawing.SizeF(2218.667!, 91.64565!)
        Me.table1.StylePriority.UseBackColor = False
        Me.table1.StylePriority.UseFont = False
        '
        'tableRow1
        '
        Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell1, Me.tableCell2, Me.tableCell3, Me.tableCell4, Me.tableCell5, Me.tableCell6, Me.tableCell7, Me.tableCell8, Me.tableCell9})
        Me.tableRow1.Dpi = 254.0!
        Me.tableRow1.Name = "tableRow1"
        Me.tableRow1.Weight = 10.46953028649871R
        '
        'tableCell1
        '
        Me.tableCell1.Dpi = 254.0!
        Me.tableCell1.Name = "tableCell1"
        Me.tableCell1.StylePriority.UseTextAlignment = False
        Me.tableCell1.Text = "Description"
        Me.tableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        Me.tableCell1.Weight = 0.6384274631682888R
        '
        'tableCell2
        '
        Me.tableCell2.Dpi = 254.0!
        Me.tableCell2.Name = "tableCell2"
        Me.tableCell2.StylePriority.UseTextAlignment = False
        Me.tableCell2.Text = "Year of Purchase"
        Me.tableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell2.Weight = 0.18514951893895917R
        '
        'tableCell3
        '
        Me.tableCell3.Dpi = 254.0!
        Me.tableCell3.Multiline = True
        Me.tableCell3.Name = "tableCell3"
        Me.tableCell3.StylePriority.UseTextAlignment = False
        Me.tableCell3.Text = "Original Cost Transferred" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell3.Weight = 0.253772194485596R
        '
        'tableCell4
        '
        Me.tableCell4.Dpi = 254.0!
        Me.tableCell4.Name = "tableCell4"
        Me.tableCell4.StylePriority.UseTextAlignment = False
        Me.tableCell4.Text = "Tax WDV Transferred"
        Me.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell4.Weight = 0.25974591367433253R
        '
        'tableCell5
        '
        Me.tableCell5.Dpi = 254.0!
        Me.tableCell5.Multiline = True
        Me.tableCell5.Name = "tableCell5"
        Me.tableCell5.StylePriority.UseTextAlignment = False
        Me.tableCell5.Text = "Transfer Value"
        Me.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell5.Weight = 0.22390624321922134R
        '
        'tableCell6
        '
        Me.tableCell6.Dpi = 254.0!
        Me.tableCell6.Multiline = True
        Me.tableCell6.Name = "tableCell6"
        Me.tableCell6.StylePriority.UseTextAlignment = False
        Me.tableCell6.Text = "No Claim"
        Me.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell6.Weight = 0.25377276099756291R
        '
        'tableCell7
        '
        Me.tableCell7.Dpi = 254.0!
        Me.tableCell7.Multiline = True
        Me.tableCell7.Name = "tableCell7"
        Me.tableCell7.StylePriority.UseTextAlignment = False
        Me.tableCell7.Text = "10%"
        Me.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell7.Weight = 0.2358527009144499R
        '
        'tableCell8
        '
        Me.tableCell8.Dpi = 254.0!
        Me.tableCell8.Name = "tableCell8"
        Me.tableCell8.StylePriority.UseTextAlignment = False
        Me.tableCell8.Text = "40%"
        Me.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell8.Weight = 0.20305106702594933R
        '
        'tableCell9
        '
        Me.tableCell9.Dpi = 254.0!
        Me.tableCell9.Multiline = True
        Me.tableCell9.Name = "tableCell9"
        Me.tableCell9.StylePriority.UseTextAlignment = False
        Me.tableCell9.Text = "ACA 100%"
        Me.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.tableCell9.Weight = 0.25080408962675688R
        '
        'XrLabel14
        '
        Me.XrLabel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.XrLabel14.Dpi = 254.0!
        Me.XrLabel14.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(1.884644!, 188.3541!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(729.5894!, 70.25015!)
        Me.XrLabel14.StylePriority.UseBackColor = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(731.4741!, 188.3541!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(200.999!, 70.25015!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "RM"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.XrLabel7.Dpi = 254.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(932.473!, 188.3541!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(232.749!, 70.25015!)
        Me.XrLabel7.StylePriority.UseBackColor = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "RM"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.XrLabel8.Dpi = 254.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(1165.222!, 188.3541!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(219.5205!, 70.25015!)
        Me.XrLabel8.StylePriority.UseBackColor = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "RM"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.XrLabel9.Dpi = 254.0!
        Me.XrLabel9.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(1384.743!, 188.3541!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(224.8119!, 70.25015!)
        Me.XrLabel9.StylePriority.UseBackColor = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "RM"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.XrLabel10.Dpi = 254.0!
        Me.XrLabel10.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(1609.555!, 188.3541!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(208.9369!, 70.25015!)
        Me.XrLabel10.StylePriority.UseBackColor = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "RM"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.XrLabel11.Dpi = 254.0!
        Me.XrLabel11.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(1609.554!, 26.45832!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(610.9967!, 70.25017!)
        Me.XrLabel11.StylePriority.UseBackColor = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Qualifying Expenditure"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel12
        '
        Me.XrLabel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.XrLabel12.Dpi = 254.0!
        Me.XrLabel12.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(1998.37!, 188.3541!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(222.1814!, 70.25015!)
        Me.XrLabel12.StylePriority.UseBackColor = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "RM"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel13
        '
        Me.XrLabel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.XrLabel13.Dpi = 254.0!
        Me.XrLabel13.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(1818.492!, 189.5415!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(179.8781!, 70.25014!)
        Me.XrLabel13.StylePriority.UseBackColor = False
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "RM"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.XrLabel6.Dpi = 254.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(1.884635!, 25.00001!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(1607.67!, 71.70848!)
        Me.XrLabel6.StylePriority.UseBackColor = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTableCell1
        '
        Me.XrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_PURCHASE_YEAR")})
        Me.XrTableCell1.Dpi = 254.0!
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell1.Weight = 0.097321354566630325R
        '
        'rpt_CAControlTransfer
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.topMarginBand1, Me.pageHeaderBand1, Me.groupHeaderBand1, Me.groupHeaderBand2, Me.groupHeaderBand3, Me.detailBand1, Me.groupFooterBand1, Me.groupFooterBand2, Me.groupFooterBand3, Me.reportFooterBand1, Me.bottomMarginBand1})
        Me.DataSource = Me.CAREPORTCONTROLTRANSFERTEMPBindingSource
        Me.Dpi = 254.0!
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.FormattingRule1})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(45, 98, 263, 100)
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
        CType(Me.table4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAREPORTCONTROLTRANSFERTEMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    '    Private Sub table1_BeforePrint(sender As Object, e As Printing.PrintEventArgs)
    '        Try
    '            Dim TotalCell As Integer = 19
    '            Dim DynamicCell As Integer = 15
    '            Dim DisableCell As Integer = 0




    '        Catch ex As Exception

    '        End Try
    '    End Sub

    'Handles tableCell1.BeforePrint, tableCell2.BeforePrint, tableCell2.BeforePrint, tableCell3.BeforePrint, tableCell4.BeforePrint, tableCell5.BeforePrint, tableCell6.BeforePrint, tableCell7.BeforePrint, tableCell8.BeforePrint, tableCell9.BeforePrint, tableCell10.BeforePrint, tableCell11.BeforePrint, tableCell12.BeforePrint, tableCell13.BeforePrint, tableCell14.BeforePrint, tableCell15.BeforePrint, tableCell16.BeforePrint, tableCell17.BeforePrint, tableCell18.BeforePrint
    '        Try
    '            If TypeOf sender Is DevExpress.XtraReports.UI.XRTableCell Then

    '    Dim obj As DevExpress.XtraReports.UI.XRTableCell '= CType(sender, DevExpress.XtraReports.UI.XRTableCell)

    '    Dim Width As Integer = 0
    '    Dim TotalWidthFixed As Integer = 0
    '    Dim WidthPage As Integer = 2827
    '    Dim TotalVisible As Integer = 0
    '    Dim CurrLocation As Integer = 0

    '                For i As Integer = 0 To 18

    '                    Select Case i
    '                        Case 0
    '                            obj = tableCell1
    '                            TotalWidthFixed += obj.WidthF
    '                        Case 1
    '                            obj = tableCell2
    '                            TotalWidthFixed += obj.WidthF
    '                        Case 2
    '                            obj = tableCell3
    '                            TotalWidthFixed += obj.WidthF
    '                        Case 3
    '                            obj = tableCell4
    '                            TotalWidthFixed += obj.WidthF
    '                        Case 4
    '                            obj = tableCell5
    '                        Case 5
    '                            obj = tableCell6
    '                        Case 6
    '                            obj = tableCell7
    '                        Case 7
    '                            obj = tableCell8
    '                        Case 8
    '                            obj = tableCell9
    '                        Case 9
    '                            obj = tableCell10
    '                        Case 10
    '                            obj = tableCell11
    '                            obj.Visible = False
    '                        Case 11
    '                            obj = tableCell12
    '                        Case 12
    '                            obj = tableCell13
    '                        Case 13
    '                            obj = tableCell14
    '                        Case 14
    '                            obj = tableCell15
    '                        Case 15
    '                            obj = tableCell16
    '                        Case 16
    '                            obj = tableCell17
    '                        Case 17
    '                            obj = tableCell18
    '                        Case 18
    '                            obj = tableCell19
    '                    End Select

    '                    If obj.Visible Then
    '                        TotalVisible += 1
    '                    End If

    '                Next
    '                TotalVisible -= 4
    '                If TotalVisible > 0 Then
    '                    Width = (WidthPage - TotalWidthFixed) / TotalVisible
    '                Else
    '                    Width = WidthPage
    '                End If

    '                For i As Integer = 0 To 18
    '                    Select Case i
    '                        Case 0
    '                            obj = tableCell1
    '                        Case 1
    '                            obj = tableCell2
    '                        Case 2
    '                            obj = tableCell3
    '                        Case 3
    '                            obj = tableCell4
    '                        Case 4
    '                            obj = tableCell5
    '                        Case 5
    '                            obj = tableCell6
    '                        Case 6
    '                            obj = tableCell7
    '                        Case 7
    '                            obj = tableCell8
    '                        Case 8
    '                            obj = tableCell9
    '                        Case 9
    '                            obj = tableCell10
    '                        Case 10
    '                            obj = tableCell11
    '                        Case 11
    '                            obj = tableCell12
    '                        Case 12
    '                            obj = tableCell13
    '                        Case 13
    '                            obj = tableCell14
    '                        Case 14
    '                            obj = tableCell15
    '                        Case 15
    '                            obj = tableCell16
    '                        Case 16
    '                            obj = tableCell17
    '                        Case 17
    '                            obj = tableCell18
    '                        Case 18
    '                            obj = tableCell19
    '                    End Select

    '                    If obj.Visible Then

    '                        Select i
    '                            Case 0, 1, 2, 3

    '                            Case Else
    '                                obj.WidthF = Width
    '                        End Select
    '                        CurrLocation += obj.WidthF
    '                        obj.LocationF = New PointF(CurrLocation, obj.LocationF.Y)
    '                    Else
    '                        obj.WidthF = 0
    '                    End If
    '                Next


    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Sub

End Class
