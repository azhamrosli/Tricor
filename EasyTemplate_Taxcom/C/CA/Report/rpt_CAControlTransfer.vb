Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Public Class rpt_CAControlTransfer
    Inherits DevExpress.XtraReports.UI.XtraReport
    Private components As System.ComponentModel.IContainer
    Friend WithEvents ReportEvenStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportOddStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportFooterBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportGroupFooterBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportDetailBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportGroupHeaderBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportHeaderBandStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents reportFooterBand1 As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents detailBand1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents pageHeaderBand1 As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents FormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents lblTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paramCompanyName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents paramYA As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents paramID As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents tblTitle As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents NoDescription As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoYE As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoOriCost As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoTWDV As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoTransferVal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoClaim As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No40 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No60 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No80 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No90 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No100 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents NoDescription_Bot As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoYE_Bot As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoOriCost_Bot As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoTWDV_Bot As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoTransferVal_Bot As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoClaim_Bot As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No2_Bot As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No3_Bot As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No8_Bot As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No10_Bot As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No12_Bot As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No14_Bot As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No16_Bot As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No20_Bot As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No40_Bot As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No50_Bot As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No60_Bot As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No80_Bot As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No90_Bot As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No100_Bot As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents table2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents NoDescription_Details As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoYE_Details As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoOriCost_Details As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoTWDV_Details As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoTransferVal_Details As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoClaim_Details As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No2_Details As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No3_Details As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No8_Details As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No10_Details As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No12_Details As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No14_Details As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No16_Details As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No20_Details As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No40_Details As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No50_Details As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No60_Details As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No80_Details As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No90_Details As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No100_Details As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents DsCA1 As EasyTemplate_Taxcom.dsCA
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupHeader3 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents table2_Footer As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents NoDescription_Footer As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoYE_Footer As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoOriCost_Footer As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoTWDV_Footer As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoTransferVal_Footer As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoClaim_Footer As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No2_Footer As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No3_Footer As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No8_Footer As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No10_Footer As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No12_Footer As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No14_Footer As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No16_Footer As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No20_Footer As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No40_Footer As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No50_Footer As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No60_Footer As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No80_Footer As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No90_Footer As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No100_Footer As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lineFooter_Top As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lineFooter_Bot As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents table2_Report As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents NoDescription_Report As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoYE_Report As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoOriCost_Report As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoTWDV_Report As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoTransferVal_Report As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoClaim_Report As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No2_Report As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No3_Report As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No8_Report As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No10_Report As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No12_Report As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No14_Report As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No16_Report As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No20_Report As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No40_Report As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No50_Report As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No60_Report As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No80_Report As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No90_Report As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents No100_Report As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lineReport_Bot As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents FontSize As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paramSch As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents NoNote As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoNote_Bot As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents dtNoteFooter As XRTable
    Friend WithEvents XrTableRow5 As XRTableRow
    Friend WithEvents NoOriCost_NoteFooter As XRTableCell
    Friend WithEvents NoTWDV_NoteFooter As XRTableCell
    Friend WithEvents NoTransferVal_NoteFooter As XRTableCell
    Friend WithEvents NoDescription_NoteFooter As XRTableCell
    Friend WithEvents XrTableCell8 As XRTableCell
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents lblDraft_Report As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents param_ShowDraft As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents ShowDraft As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents lineReport_top As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SubBand1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents NoDescription_Top As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoYE_Top As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoOriCost_Top As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoTWDV_Top As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoTransferVal_Top As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoClaim_Top As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents NoHeader_Top As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents LineDetails As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lblDraft_Page As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paramTitle As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents lblPageNo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents PageHeader_Sub2 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents PageHeader_Sub1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand


    Public Property CurrentPage As Integer = 0
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub InitializeComponent()
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
        Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramSch = New DevExpress.XtraReports.Parameters.Parameter()
        Me.lblTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramTitle = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramYA = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramCompanyName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pageHeaderBand1 = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.PageHeader_Sub1 = New DevExpress.XtraReports.UI.SubBand()
        Me.PageHeader_Sub2 = New DevExpress.XtraReports.UI.SubBand()
        Me.tblTitle = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.NoDescription_Top = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoYE_Top = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoOriCost_Top = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoTWDV_Top = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoTransferVal_Top = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoClaim_Top = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoHeader_Top = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.NoDescription = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoYE = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoOriCost = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoTWDV = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoTransferVal = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoClaim = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No40 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No60 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No80 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No90 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No100 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoNote = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.NoDescription_Bot = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoYE_Bot = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoOriCost_Bot = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoTWDV_Bot = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoTransferVal_Bot = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoClaim_Bot = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No2_Bot = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No3_Bot = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No8_Bot = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No10_Bot = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No12_Bot = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No14_Bot = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No16_Bot = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No20_Bot = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No40_Bot = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No50_Bot = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No60_Bot = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No80_Bot = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No90_Bot = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No100_Bot = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoNote_Bot = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lblDraft_Page = New DevExpress.XtraReports.UI.XRLabel()
        Me.ShowDraft = New DevExpress.XtraReports.UI.FormattingRule()
        Me.FormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.LineDetails = New DevExpress.XtraReports.UI.XRLine()
        Me.table2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.NoDescription_Details = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoYE_Details = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoOriCost_Details = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoTWDV_Details = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoTransferVal_Details = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoClaim_Details = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No2_Details = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No3_Details = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No8_Details = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No10_Details = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No12_Details = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No14_Details = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No16_Details = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No20_Details = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No40_Details = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No50_Details = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No60_Details = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No80_Details = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No90_Details = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No100_Details = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.reportFooterBand1 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.lineReport_top = New DevExpress.XtraReports.UI.XRLine()
        Me.dtNoteFooter = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.NoDescription_NoteFooter = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoOriCost_NoteFooter = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoTWDV_NoteFooter = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoTransferVal_NoteFooter = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lineReport_Bot = New DevExpress.XtraReports.UI.XRLine()
        Me.table2_Report = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.NoDescription_Report = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoYE_Report = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoOriCost_Report = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoTWDV_Report = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoTransferVal_Report = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoClaim_Report = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No2_Report = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No3_Report = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No8_Report = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No10_Report = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No12_Report = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No14_Report = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No16_Report = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No20_Report = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No40_Report = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No50_Report = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No60_Report = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No80_Report = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No90_Report = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No100_Report = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.FontSize = New DevExpress.XtraReports.Parameters.Parameter()
        Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeaderBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportGroupHeaderBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportDetailBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportGroupFooterBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportFooterBandStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportOddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportEvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.paramID = New DevExpress.XtraReports.Parameters.Parameter()
        Me.DsCA1 = New EasyTemplate_Taxcom.dsCA()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.GroupHeader3 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.lineFooter_Bot = New DevExpress.XtraReports.UI.XRLine()
        Me.lineFooter_Top = New DevExpress.XtraReports.UI.XRLine()
        Me.table2_Footer = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.NoDescription_Footer = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoYE_Footer = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoOriCost_Footer = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoTWDV_Footer = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoTransferVal_Footer = New DevExpress.XtraReports.UI.XRTableCell()
        Me.NoClaim_Footer = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No2_Footer = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No3_Footer = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No8_Footer = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No10_Footer = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No12_Footer = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No14_Footer = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No16_Footer = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No20_Footer = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No40_Footer = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No50_Footer = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No60_Footer = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No80_Footer = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No90_Footer = New DevExpress.XtraReports.UI.XRTableCell()
        Me.No100_Footer = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.lblDraft_Report = New DevExpress.XtraReports.UI.XRLabel()
        Me.param_ShowDraft = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.lblPageNo = New DevExpress.XtraReports.UI.XRPageInfo()
        CType(Me.tblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtNoteFooter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table2_Report, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table2_Footer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'topMarginBand1
        '
        Me.topMarginBand1.Dpi = 254.0!
        Me.topMarginBand1.HeightF = 54.37499!
        Me.topMarginBand1.Name = "topMarginBand1"
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramSch, "Text", "")})
        Me.XrLabel7.Dpi = 254.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(1923.312!, 115.1716!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(801.6876!, 58.41997!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "XrLabel7"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'paramSch
        '
        Me.paramSch.Description = "paramSch"
        Me.paramSch.Name = "paramSch"
        Me.paramSch.ValueInfo = "Schedule"
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramTitle, "Text", "")})
        Me.lblTitle.Dpi = 254.0!
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.LocationFloat = New DevExpress.Utils.PointFloat(2.999817!, 314.9548!)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblTitle.SizeF = New System.Drawing.SizeF(2722.0!, 58.42004!)
        Me.lblTitle.StylePriority.UseBackColor = False
        Me.lblTitle.StylePriority.UseFont = False
        Me.lblTitle.Text = "CONTROLLED TRANSFER OF PROPERTY, PLANT AND EQUIPMENT FROM RELATED COMPANIES"
        '
        'paramTitle
        '
        Me.paramTitle.Description = "paramTitle"
        Me.paramTitle.Name = "paramTitle"
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramYA, "Text", "INCOME TAX COMPUTATION - YEAR OF ASSESSMENT  {0}")})
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(2.999817!, 256.5349!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(2722.0!, 58.41998!)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseFont = False
        '
        'paramYA
        '
        Me.paramYA.Description = "Parameter1"
        Me.paramYA.Name = "paramYA"
        Me.paramYA.Type = GetType(Integer)
        Me.paramYA.ValueInfo = "0"
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramCompanyName, "Text", "NAME: {0}")})
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 198.1148!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(2725.0!, 58.41998!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseFont = False
        '
        'paramCompanyName
        '
        Me.paramCompanyName.Description = "paramCompanyName"
        Me.paramCompanyName.Name = "paramCompanyName"
        '
        'pageHeaderBand1
        '
        Me.pageHeaderBand1.BackColor = System.Drawing.Color.Transparent
        Me.pageHeaderBand1.Dpi = 254.0!
        Me.pageHeaderBand1.HeightF = 0.0!
        Me.pageHeaderBand1.Name = "pageHeaderBand1"
        Me.pageHeaderBand1.StyleName = "ReportHeaderBandStyle"
        Me.pageHeaderBand1.StylePriority.UseBackColor = False
        Me.pageHeaderBand1.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.PageHeader_Sub1, Me.PageHeader_Sub2})
        '
        'PageHeader_Sub1
        '
        Me.PageHeader_Sub1.Dpi = 254.0!
        Me.PageHeader_Sub1.HeightF = 0.0!
        Me.PageHeader_Sub1.KeepTogether = True
        Me.PageHeader_Sub1.Name = "PageHeader_Sub1"
        Me.PageHeader_Sub1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.PageHeader_Sub1.StylePriority.UsePadding = False
        '
        'PageHeader_Sub2
        '
        Me.PageHeader_Sub2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.tblTitle, Me.lblDraft_Page})
        Me.PageHeader_Sub2.Dpi = 254.0!
        Me.PageHeader_Sub2.HeightF = 277.3362!
        Me.PageHeader_Sub2.Name = "PageHeader_Sub2"
        '
        'tblTitle
        '
        Me.tblTitle.BackColor = System.Drawing.Color.Transparent
        Me.tblTitle.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.tblTitle.BorderWidth = 0.0!
        Me.tblTitle.Dpi = 254.0!
        Me.tblTitle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblTitle.LocationFloat = New DevExpress.Utils.PointFloat(0.0009689331!, 58.42004!)
        Me.tblTitle.Name = "tblTitle"
        Me.tblTitle.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow6, Me.tableRow1, Me.XrTableRow1})
        Me.tblTitle.SizeF = New System.Drawing.SizeF(2725.0!, 218.9161!)
        Me.tblTitle.StylePriority.UseBackColor = False
        Me.tblTitle.StylePriority.UseBorders = False
        Me.tblTitle.StylePriority.UseBorderWidth = False
        Me.tblTitle.StylePriority.UseFont = False
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.NoDescription_Top, Me.NoYE_Top, Me.NoOriCost_Top, Me.NoTWDV_Top, Me.NoTransferVal_Top, Me.NoClaim_Top, Me.NoHeader_Top, Me.XrTableCell25})
        Me.XrTableRow6.Dpi = 254.0!
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Weight = 10.46953028649871R
        '
        'NoDescription_Top
        '
        Me.NoDescription_Top.Dpi = 254.0!
        Me.NoDescription_Top.Name = "NoDescription_Top"
        Me.NoDescription_Top.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 10, 0, 0, 254.0!)
        Me.NoDescription_Top.StylePriority.UsePadding = False
        Me.NoDescription_Top.StylePriority.UseTextAlignment = False
        Me.NoDescription_Top.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        Me.NoDescription_Top.Weight = 2.1813121229792407R
        '
        'NoYE_Top
        '
        Me.NoYE_Top.Dpi = 254.0!
        Me.NoYE_Top.Name = "NoYE_Top"
        Me.NoYE_Top.RowSpan = 2
        Me.NoYE_Top.StylePriority.UseTextAlignment = False
        Me.NoYE_Top.Text = "Year of Purchase"
        Me.NoYE_Top.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.NoYE_Top.Weight = 0.0089009331106998379R
        '
        'NoOriCost_Top
        '
        Me.NoOriCost_Top.Dpi = 254.0!
        Me.NoOriCost_Top.Multiline = True
        Me.NoOriCost_Top.Name = "NoOriCost_Top"
        Me.NoOriCost_Top.RowSpan = 2
        Me.NoOriCost_Top.StylePriority.UseTextAlignment = False
        Me.NoOriCost_Top.Text = "Original Cost Transferred" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.NoOriCost_Top.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.NoOriCost_Top.Weight = 0.014047399127225635R
        '
        'NoTWDV_Top
        '
        Me.NoTWDV_Top.Dpi = 254.0!
        Me.NoTWDV_Top.Name = "NoTWDV_Top"
        Me.NoTWDV_Top.RowSpan = 2
        Me.NoTWDV_Top.StylePriority.UseTextAlignment = False
        Me.NoTWDV_Top.Text = "Tax WDV Transferred"
        Me.NoTWDV_Top.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.NoTWDV_Top.Weight = 0.01669067362054788R
        '
        'NoTransferVal_Top
        '
        Me.NoTransferVal_Top.BackColor = System.Drawing.Color.Transparent
        Me.NoTransferVal_Top.Dpi = 254.0!
        Me.NoTransferVal_Top.Name = "NoTransferVal_Top"
        Me.NoTransferVal_Top.RowSpan = 2
        Me.NoTransferVal_Top.StylePriority.UseBackColor = False
        Me.NoTransferVal_Top.StylePriority.UseTextAlignment = False
        Me.NoTransferVal_Top.Text = "Transfer Value"
        Me.NoTransferVal_Top.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.NoTransferVal_Top.Weight = 0.02311111293681356R
        '
        'NoClaim_Top
        '
        Me.NoClaim_Top.BackColor = System.Drawing.Color.Transparent
        Me.NoClaim_Top.Dpi = 254.0!
        Me.NoClaim_Top.Name = "NoClaim_Top"
        Me.NoClaim_Top.RowSpan = 2
        Me.NoClaim_Top.StylePriority.UseBackColor = False
        Me.NoClaim_Top.StylePriority.UseTextAlignment = False
        Me.NoClaim_Top.Text = "No Claim"
        Me.NoClaim_Top.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.NoClaim_Top.Visible = False
        Me.NoClaim_Top.Weight = 0.014047667142847775R
        '
        'NoHeader_Top
        '
        Me.NoHeader_Top.BackColor = System.Drawing.Color.Transparent
        Me.NoHeader_Top.Dpi = 254.0!
        Me.NoHeader_Top.Name = "NoHeader_Top"
        Me.NoHeader_Top.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 10, 254.0!)
        Me.NoHeader_Top.StylePriority.UseBackColor = False
        Me.NoHeader_Top.StylePriority.UsePadding = False
        Me.NoHeader_Top.StylePriority.UseTextAlignment = False
        Me.NoHeader_Top.Text = "Qualifying Expenditure"
        Me.NoHeader_Top.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.NoHeader_Top.Weight = 0.19197515918704688R
        '
        'XrTableCell25
        '
        Me.XrTableCell25.Dpi = 254.0!
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.StylePriority.UseTextAlignment = False
        Me.XrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.XrTableCell25.Weight = 0.051247247265371554R
        '
        'tableRow1
        '
        Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.NoDescription, Me.NoYE, Me.NoOriCost, Me.NoTWDV, Me.NoTransferVal, Me.NoClaim, Me.No2, Me.No3, Me.No8, Me.No10, Me.No12, Me.No14, Me.No16, Me.No20, Me.No40, Me.No50, Me.No60, Me.No80, Me.No90, Me.No100, Me.NoNote})
        Me.tableRow1.Dpi = 254.0!
        Me.tableRow1.Name = "tableRow1"
        Me.tableRow1.Weight = 10.46953028649871R
        '
        'NoDescription
        '
        Me.NoDescription.CanShrink = True
        Me.NoDescription.Dpi = 254.0!
        Me.NoDescription.Name = "NoDescription"
        Me.NoDescription.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 10, 0, 0, 254.0!)
        Me.NoDescription.StylePriority.UsePadding = False
        Me.NoDescription.StylePriority.UseTextAlignment = False
        Me.NoDescription.Text = "Description"
        Me.NoDescription.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        Me.NoDescription.Weight = 2.1813121270109681R
        '
        'NoYE
        '
        Me.NoYE.Dpi = 254.0!
        Me.NoYE.Name = "NoYE"
        Me.NoYE.StylePriority.UseTextAlignment = False
        Me.NoYE.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.NoYE.Weight = 0.0089007670503689074R
        '
        'NoOriCost
        '
        Me.NoOriCost.Dpi = 254.0!
        Me.NoOriCost.Multiline = True
        Me.NoOriCost.Name = "NoOriCost"
        Me.NoOriCost.StylePriority.UseTextAlignment = False
        Me.NoOriCost.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.NoOriCost.Weight = 0.014047466639143913R
        '
        'NoTWDV
        '
        Me.NoTWDV.Dpi = 254.0!
        Me.NoTWDV.Name = "NoTWDV"
        Me.NoTWDV.StylePriority.UseTextAlignment = False
        Me.NoTWDV.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.NoTWDV.Weight = 0.016690646615780347R
        '
        'NoTransferVal
        '
        Me.NoTransferVal.Dpi = 254.0!
        Me.NoTransferVal.Multiline = True
        Me.NoTransferVal.Name = "NoTransferVal"
        Me.NoTransferVal.StylePriority.UseTextAlignment = False
        Me.NoTransferVal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.NoTransferVal.Weight = 0.02311111293681356R
        '
        'NoClaim
        '
        Me.NoClaim.BackColor = System.Drawing.Color.Transparent
        Me.NoClaim.Dpi = 254.0!
        Me.NoClaim.Multiline = True
        Me.NoClaim.Name = "NoClaim"
        Me.NoClaim.StylePriority.UseBackColor = False
        Me.NoClaim.StylePriority.UseTextAlignment = False
        Me.NoClaim.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.NoClaim.Visible = False
        Me.NoClaim.Weight = 0.014047667142847775R
        '
        'No2
        '
        Me.No2.CanShrink = True
        Me.No2.Dpi = 254.0!
        Me.No2.Multiline = True
        Me.No2.Name = "No2"
        Me.No2.StylePriority.UseTextAlignment = False
        Me.No2.Text = "2%"
        Me.No2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.No2.Visible = False
        Me.No2.Weight = 0.0140479182014972R
        '
        'No3
        '
        Me.No3.CanShrink = True
        Me.No3.Dpi = 254.0!
        Me.No3.Name = "No3"
        Me.No3.StylePriority.UseTextAlignment = False
        Me.No3.Text = "3%"
        Me.No3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.No3.Visible = False
        Me.No3.Weight = 0.025754554623444559R
        '
        'No8
        '
        Me.No8.CanShrink = True
        Me.No8.Dpi = 254.0!
        Me.No8.Multiline = True
        Me.No8.Name = "No8"
        Me.No8.StylePriority.UseTextAlignment = False
        Me.No8.Text = "8%"
        Me.No8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.No8.Visible = False
        Me.No8.Weight = 0.0210706762210906R
        '
        'No10
        '
        Me.No10.BackColor = System.Drawing.Color.Transparent
        Me.No10.CanShrink = True
        Me.No10.Dpi = 254.0!
        Me.No10.Name = "No10"
        Me.No10.StylePriority.UseBackColor = False
        Me.No10.StylePriority.UseTextAlignment = False
        Me.No10.Text = "10%"
        Me.No10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.No10.Visible = False
        Me.No10.Weight = 0.014047664449316277R
        '
        'No12
        '
        Me.No12.CanShrink = True
        Me.No12.Dpi = 254.0!
        Me.No12.Name = "No12"
        Me.No12.StylePriority.UseTextAlignment = False
        Me.No12.Text = "12%"
        Me.No12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.No12.Visible = False
        Me.No12.Weight = 0.02107150101953259R
        '
        'No14
        '
        Me.No14.CanShrink = True
        Me.No14.Dpi = 254.0!
        Me.No14.Name = "No14"
        Me.No14.StylePriority.UseTextAlignment = False
        Me.No14.Text = "14%"
        Me.No14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.No14.Visible = False
        Me.No14.Weight = 0.017924927111595323R
        '
        'No16
        '
        Me.No16.CanShrink = True
        Me.No16.Dpi = 254.0!
        Me.No16.Name = "No16"
        Me.No16.StylePriority.UseTextAlignment = False
        Me.No16.Text = "16%"
        Me.No16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.No16.Visible = False
        Me.No16.Weight = 0.018235145761460569R
        '
        'No20
        '
        Me.No20.Dpi = 254.0!
        Me.No20.Name = "No20"
        Me.No20.StylePriority.UseTextAlignment = False
        Me.No20.Text = "20%"
        Me.No20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.No20.Visible = False
        Me.No20.Weight = 0.015348858991146241R
        '
        'No40
        '
        Me.No40.Dpi = 254.0!
        Me.No40.Name = "No40"
        Me.No40.StylePriority.UseTextAlignment = False
        Me.No40.Text = "40%"
        Me.No40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.No40.Visible = False
        Me.No40.Weight = 0.018470606620687446R
        '
        'No50
        '
        Me.No50.Dpi = 254.0!
        Me.No50.Name = "No50"
        Me.No50.StylePriority.UseTextAlignment = False
        Me.No50.Text = "50%"
        Me.No50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.No50.Visible = False
        Me.No50.Weight = 0.014306703760647688R
        '
        'No60
        '
        Me.No60.Dpi = 254.0!
        Me.No60.Name = "No60"
        Me.No60.StylePriority.UseTextAlignment = False
        Me.No60.Text = "60%"
        Me.No60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.No60.Visible = False
        Me.No60.Weight = 0.016659354380040625R
        '
        'No80
        '
        Me.No80.BackColor = System.Drawing.Color.Transparent
        Me.No80.Dpi = 254.0!
        Me.No80.Name = "No80"
        Me.No80.StylePriority.UseBackColor = False
        Me.No80.StylePriority.UseTextAlignment = False
        Me.No80.Text = "ACA 80%"
        Me.No80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.No80.Visible = False
        Me.No80.Weight = 0.017159481276564026R
        '
        'No90
        '
        Me.No90.CanShrink = True
        Me.No90.Dpi = 254.0!
        Me.No90.Name = "No90"
        Me.No90.StylePriority.UseTextAlignment = False
        Me.No90.Text = "90%"
        Me.No90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.No90.Visible = False
        Me.No90.Weight = 0.014182687682242012R
        '
        'No100
        '
        Me.No100.CanShrink = True
        Me.No100.Dpi = 254.0!
        Me.No100.Name = "No100"
        Me.No100.StylePriority.UseTextAlignment = False
        Me.No100.Text = "ACA 100%"
        Me.No100.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.No100.Visible = False
        Me.No100.Weight = 0.010518023502107843R
        '
        'NoNote
        '
        Me.NoNote.Dpi = 254.0!
        Me.NoNote.Name = "NoNote"
        Me.NoNote.StylePriority.UseTextAlignment = False
        Me.NoNote.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.NoNote.Weight = 0.0044244243724974857R
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.NoDescription_Bot, Me.NoYE_Bot, Me.NoOriCost_Bot, Me.NoTWDV_Bot, Me.NoTransferVal_Bot, Me.NoClaim_Bot, Me.No2_Bot, Me.No3_Bot, Me.No8_Bot, Me.No10_Bot, Me.No12_Bot, Me.No14_Bot, Me.No16_Bot, Me.No20_Bot, Me.No40_Bot, Me.No50_Bot, Me.No60_Bot, Me.No80_Bot, Me.No90_Bot, Me.No100_Bot, Me.NoNote_Bot})
        Me.XrTableRow1.Dpi = 254.0!
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 10.46953028649871R
        '
        'NoDescription_Bot
        '
        Me.NoDescription_Bot.Dpi = 254.0!
        Me.NoDescription_Bot.Name = "NoDescription_Bot"
        Me.NoDescription_Bot.StylePriority.UseTextAlignment = False
        Me.NoDescription_Bot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        Me.NoDescription_Bot.Weight = 2.1813121270109681R
        '
        'NoYE_Bot
        '
        Me.NoYE_Bot.Dpi = 254.0!
        Me.NoYE_Bot.Name = "NoYE_Bot"
        Me.NoYE_Bot.StylePriority.UseTextAlignment = False
        Me.NoYE_Bot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        Me.NoYE_Bot.Weight = 0.008900780552752896R
        '
        'NoOriCost_Bot
        '
        Me.NoOriCost_Bot.Dpi = 254.0!
        Me.NoOriCost_Bot.Name = "NoOriCost_Bot"
        Me.NoOriCost_Bot.StylePriority.UseTextAlignment = False
        Me.NoOriCost_Bot.Text = "RM"
        Me.NoOriCost_Bot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.NoOriCost_Bot.Weight = 0.014047453136760257R
        '
        'NoTWDV_Bot
        '
        Me.NoTWDV_Bot.Dpi = 254.0!
        Me.NoTWDV_Bot.Name = "NoTWDV_Bot"
        Me.NoTWDV_Bot.StylePriority.UseTextAlignment = False
        Me.NoTWDV_Bot.Text = "RM"
        Me.NoTWDV_Bot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.NoTWDV_Bot.Weight = 0.016690646615780791R
        '
        'NoTransferVal_Bot
        '
        Me.NoTransferVal_Bot.Dpi = 254.0!
        Me.NoTransferVal_Bot.Name = "NoTransferVal_Bot"
        Me.NoTransferVal_Bot.StylePriority.UseTextAlignment = False
        Me.NoTransferVal_Bot.Text = "RM"
        Me.NoTransferVal_Bot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.NoTransferVal_Bot.Weight = 0.02311111293681356R
        '
        'NoClaim_Bot
        '
        Me.NoClaim_Bot.Dpi = 254.0!
        Me.NoClaim_Bot.Name = "NoClaim_Bot"
        Me.NoClaim_Bot.StylePriority.UseTextAlignment = False
        Me.NoClaim_Bot.Text = "RM"
        Me.NoClaim_Bot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.NoClaim_Bot.Visible = False
        Me.NoClaim_Bot.Weight = 0.014047667142847775R
        '
        'No2_Bot
        '
        Me.No2_Bot.Dpi = 254.0!
        Me.No2_Bot.Name = "No2_Bot"
        Me.No2_Bot.StylePriority.UseTextAlignment = False
        Me.No2_Bot.Text = "RM"
        Me.No2_Bot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.No2_Bot.Weight = 0.014047918201497422R
        '
        'No3_Bot
        '
        Me.No3_Bot.Dpi = 254.0!
        Me.No3_Bot.Name = "No3_Bot"
        Me.No3_Bot.StylePriority.UseTextAlignment = False
        Me.No3_Bot.Text = "RM"
        Me.No3_Bot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.No3_Bot.Weight = 0.025754554623444337R
        '
        'No8_Bot
        '
        Me.No8_Bot.Dpi = 254.0!
        Me.No8_Bot.Name = "No8_Bot"
        Me.No8_Bot.StylePriority.UseTextAlignment = False
        Me.No8_Bot.Text = "RM"
        Me.No8_Bot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.No8_Bot.Weight = 0.021070676221090823R
        '
        'No10_Bot
        '
        Me.No10_Bot.Dpi = 254.0!
        Me.No10_Bot.Name = "No10_Bot"
        Me.No10_Bot.StylePriority.UseTextAlignment = False
        Me.No10_Bot.Text = "RM"
        Me.No10_Bot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.No10_Bot.Weight = 0.01404766444931627R
        '
        'No12_Bot
        '
        Me.No12_Bot.Dpi = 254.0!
        Me.No12_Bot.Name = "No12_Bot"
        Me.No12_Bot.StylePriority.UseTextAlignment = False
        Me.No12_Bot.Text = "RM"
        Me.No12_Bot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.No12_Bot.Weight = 0.02107150101953259R
        '
        'No14_Bot
        '
        Me.No14_Bot.Dpi = 254.0!
        Me.No14_Bot.Name = "No14_Bot"
        Me.No14_Bot.StylePriority.UseTextAlignment = False
        Me.No14_Bot.Text = "RM"
        Me.No14_Bot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.No14_Bot.Weight = 0.017924927111595323R
        '
        'No16_Bot
        '
        Me.No16_Bot.Dpi = 254.0!
        Me.No16_Bot.Name = "No16_Bot"
        Me.No16_Bot.StylePriority.UseTextAlignment = False
        Me.No16_Bot.Text = "RM"
        Me.No16_Bot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.No16_Bot.Weight = 0.018235145761460458R
        '
        'No20_Bot
        '
        Me.No20_Bot.Dpi = 254.0!
        Me.No20_Bot.Name = "No20_Bot"
        Me.No20_Bot.StylePriority.UseTextAlignment = False
        Me.No20_Bot.Text = "RM"
        Me.No20_Bot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.No20_Bot.Weight = 0.01534885899114613R
        '
        'No40_Bot
        '
        Me.No40_Bot.Dpi = 254.0!
        Me.No40_Bot.Name = "No40_Bot"
        Me.No40_Bot.StylePriority.UseTextAlignment = False
        Me.No40_Bot.Text = "RM"
        Me.No40_Bot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.No40_Bot.Weight = 0.018470606620687446R
        '
        'No50_Bot
        '
        Me.No50_Bot.Dpi = 254.0!
        Me.No50_Bot.Name = "No50_Bot"
        Me.No50_Bot.StylePriority.UseTextAlignment = False
        Me.No50_Bot.Text = "RM"
        Me.No50_Bot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.No50_Bot.Weight = 0.014306703760647466R
        '
        'No60_Bot
        '
        Me.No60_Bot.Dpi = 254.0!
        Me.No60_Bot.Name = "No60_Bot"
        Me.No60_Bot.StylePriority.UseTextAlignment = False
        Me.No60_Bot.Text = "RM"
        Me.No60_Bot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.No60_Bot.Weight = 0.016659354380040625R
        '
        'No80_Bot
        '
        Me.No80_Bot.Dpi = 254.0!
        Me.No80_Bot.Name = "No80_Bot"
        Me.No80_Bot.StylePriority.UseTextAlignment = False
        Me.No80_Bot.Text = "RM"
        Me.No80_Bot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.No80_Bot.Weight = 0.017159481276564026R
        '
        'No90_Bot
        '
        Me.No90_Bot.Dpi = 254.0!
        Me.No90_Bot.Name = "No90_Bot"
        Me.No90_Bot.StylePriority.UseTextAlignment = False
        Me.No90_Bot.Text = "RM"
        Me.No90_Bot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.No90_Bot.Weight = 0.014182687682242068R
        '
        'No100_Bot
        '
        Me.No100_Bot.Dpi = 254.0!
        Me.No100_Bot.Name = "No100_Bot"
        Me.No100_Bot.StylePriority.UseTextAlignment = False
        Me.No100_Bot.Text = "RM"
        Me.No100_Bot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.No100_Bot.Weight = 0.010518023502107898R
        '
        'NoNote_Bot
        '
        Me.NoNote_Bot.Dpi = 254.0!
        Me.NoNote_Bot.Name = "NoNote_Bot"
        Me.NoNote_Bot.StylePriority.UseTextAlignment = False
        Me.NoNote_Bot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.NoNote_Bot.Weight = 0.0044244243724974857R
        '
        'lblDraft_Page
        '
        Me.lblDraft_Page.BackColor = System.Drawing.Color.Transparent
        Me.lblDraft_Page.CanShrink = True
        Me.lblDraft_Page.Dpi = 254.0!
        Me.lblDraft_Page.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDraft_Page.FormattingRules.Add(Me.ShowDraft)
        Me.lblDraft_Page.LocationFloat = New DevExpress.Utils.PointFloat(2404.855!, 0.0!)
        Me.lblDraft_Page.Name = "lblDraft_Page"
        Me.lblDraft_Page.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblDraft_Page.SizeF = New System.Drawing.SizeF(320.1453!, 58.42001!)
        Me.lblDraft_Page.StylePriority.UseBackColor = False
        Me.lblDraft_Page.StylePriority.UseFont = False
        Me.lblDraft_Page.StylePriority.UseTextAlignment = False
        Me.lblDraft_Page.Text = "DRAFT"
        Me.lblDraft_Page.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblDraft_Page.Visible = False
        '
        'ShowDraft
        '
        Me.ShowDraft.Condition = "[Parameters.param_ShowDraft]=true"
        Me.ShowDraft.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.ShowDraft.Name = "ShowDraft"
        '
        'FormattingRule1
        '
        Me.FormattingRule1.Condition = "[AA_10] is null"
        Me.FormattingRule1.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.FormattingRule1.Name = "FormattingRule1"
        '
        'detailBand1
        '
        Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.LineDetails, Me.table2})
        Me.detailBand1.Dpi = 254.0!
        Me.detailBand1.EvenStyleName = "ReportEvenStyle"
        Me.detailBand1.HeightF = 57.94405!
        Me.detailBand1.KeepTogether = True
        Me.detailBand1.KeepTogetherWithDetailReports = True
        Me.detailBand1.Name = "detailBand1"
        Me.detailBand1.OddStyleName = "ReportOddStyle"
        Me.detailBand1.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CA_PURCHASE_YEAR", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("CA_ASSET", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.detailBand1.StyleName = "ReportDetailBandStyle"
        '
        'LineDetails
        '
        Me.LineDetails.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.LineDetails.Dpi = 254.0!
        Me.LineDetails.LocationFloat = New DevExpress.Utils.PointFloat(2.999918!, 49.79483!)
        Me.LineDetails.Name = "LineDetails"
        Me.LineDetails.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.LineDetails.SizeF = New System.Drawing.SizeF(280.8204!, 8.149216!)
        Me.LineDetails.StylePriority.UseBorders = False
        Me.LineDetails.StylePriority.UsePadding = False
        Me.LineDetails.Visible = False
        '
        'table2
        '
        Me.table2.BackColor = System.Drawing.Color.Transparent
        Me.table2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.table2.BorderWidth = 1.0!
        Me.table2.Dpi = 254.0!
        Me.table2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.table2.Name = "table2"
        Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.table2.SizeF = New System.Drawing.SizeF(2725.0!, 49.79483!)
        Me.table2.StylePriority.UseBackColor = False
        Me.table2.StylePriority.UseBorders = False
        Me.table2.StylePriority.UseBorderWidth = False
        Me.table2.StylePriority.UseFont = False
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.NoDescription_Details, Me.NoYE_Details, Me.NoOriCost_Details, Me.NoTWDV_Details, Me.NoTransferVal_Details, Me.NoClaim_Details, Me.No2_Details, Me.No3_Details, Me.No8_Details, Me.No10_Details, Me.No12_Details, Me.No14_Details, Me.No16_Details, Me.No20_Details, Me.No40_Details, Me.No50_Details, Me.No60_Details, Me.No80_Details, Me.No90_Details, Me.No100_Details, Me.XrTableCell1})
        Me.XrTableRow2.Dpi = 254.0!
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 10.46953028649871R
        '
        'NoDescription_Details
        '
        Me.NoDescription_Details.BackColor = System.Drawing.Color.Transparent
        Me.NoDescription_Details.CanShrink = True
        Me.NoDescription_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.CA_ASSET")})
        Me.NoDescription_Details.Dpi = 254.0!
        Me.NoDescription_Details.Name = "NoDescription_Details"
        Me.NoDescription_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 10, 0, 0, 254.0!)
        Me.NoDescription_Details.StylePriority.UseBackColor = False
        Me.NoDescription_Details.StylePriority.UsePadding = False
        Me.NoDescription_Details.StylePriority.UseTextAlignment = False
        Me.NoDescription_Details.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.NoDescription_Details.Weight = 3.8684133739674507R
        '
        'NoYE_Details
        '
        Me.NoYE_Details.CanShrink = True
        Me.NoYE_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.CA_PURCHASE_YEAR")})
        Me.NoYE_Details.Dpi = 254.0!
        Me.NoYE_Details.Name = "NoYE_Details"
        Me.NoYE_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.NoYE_Details.StylePriority.UsePadding = False
        Me.NoYE_Details.StylePriority.UseTextAlignment = False
        Me.NoYE_Details.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.NoYE_Details.Weight = 0.007516377508610006R
        '
        'NoOriCost_Details
        '
        Me.NoOriCost_Details.CanShrink = True
        Me.NoOriCost_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.CA_PURCHASE_AMOUNT", "{0:#,# ;(#,#);0 }")})
        Me.NoOriCost_Details.Dpi = 254.0!
        Me.NoOriCost_Details.Multiline = True
        Me.NoOriCost_Details.Name = "NoOriCost_Details"
        Me.NoOriCost_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.NoOriCost_Details.StylePriority.UsePadding = False
        Me.NoOriCost_Details.StylePriority.UseTextAlignment = False
        Me.NoOriCost_Details.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.NoOriCost_Details.Weight = 0.0075157848289753026R
        '
        'NoTWDV_Details
        '
        Me.NoTWDV_Details.CanShrink = True
        Me.NoTWDV_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.TWDV_BF", "{0:#,# ;(#,#);0 }")})
        Me.NoTWDV_Details.Dpi = 254.0!
        Me.NoTWDV_Details.Name = "NoTWDV_Details"
        Me.NoTWDV_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.NoTWDV_Details.StylePriority.UsePadding = False
        Me.NoTWDV_Details.StylePriority.UseTextAlignment = False
        Me.NoTWDV_Details.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.NoTWDV_Details.Weight = 0.007516214127715859R
        '
        'NoTransferVal_Details
        '
        Me.NoTransferVal_Details.CanShrink = True
        Me.NoTransferVal_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.CA_TRANSFER_VAL", "{0:#,# ;(#,#);0 }")})
        Me.NoTransferVal_Details.Dpi = 254.0!
        Me.NoTransferVal_Details.Multiline = True
        Me.NoTransferVal_Details.Name = "NoTransferVal_Details"
        Me.NoTransferVal_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.NoTransferVal_Details.StylePriority.UsePadding = False
        Me.NoTransferVal_Details.StylePriority.UseTextAlignment = False
        Me.NoTransferVal_Details.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.NoTransferVal_Details.Weight = 0.007516214127715859R
        '
        'NoClaim_Details
        '
        Me.NoClaim_Details.CanShrink = True
        Me.NoClaim_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_0", "{0:#,# ;(#,#); }")})
        Me.NoClaim_Details.Dpi = 254.0!
        Me.NoClaim_Details.Multiline = True
        Me.NoClaim_Details.Name = "NoClaim_Details"
        Me.NoClaim_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.NoClaim_Details.StylePriority.UsePadding = False
        Me.NoClaim_Details.StylePriority.UseTextAlignment = False
        Me.NoClaim_Details.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.NoClaim_Details.Visible = False
        Me.NoClaim_Details.Weight = 0.0075158673588977543R
        '
        'No2_Details
        '
        Me.No2_Details.CanShrink = True
        Me.No2_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_2", "{0:#,# ;(#,#); }")})
        Me.No2_Details.Dpi = 254.0!
        Me.No2_Details.Multiline = True
        Me.No2_Details.Name = "No2_Details"
        Me.No2_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.No2_Details.StylePriority.UsePadding = False
        Me.No2_Details.StylePriority.UseTextAlignment = False
        Me.No2_Details.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No2_Details.Visible = False
        Me.No2_Details.Weight = 0.007516214127715859R
        '
        'No3_Details
        '
        Me.No3_Details.CanShrink = True
        Me.No3_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_3", "{0:#,# ;(#,#); }")})
        Me.No3_Details.Dpi = 254.0!
        Me.No3_Details.Name = "No3_Details"
        Me.No3_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.No3_Details.StylePriority.UsePadding = False
        Me.No3_Details.StylePriority.UseTextAlignment = False
        Me.No3_Details.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No3_Details.Visible = False
        Me.No3_Details.Weight = 0.007516214127715859R
        '
        'No8_Details
        '
        Me.No8_Details.CanShrink = True
        Me.No8_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_8", "{0:#,# ;(#,#); }")})
        Me.No8_Details.Dpi = 254.0!
        Me.No8_Details.Multiline = True
        Me.No8_Details.Name = "No8_Details"
        Me.No8_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.No8_Details.StylePriority.UsePadding = False
        Me.No8_Details.StylePriority.UseTextAlignment = False
        Me.No8_Details.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No8_Details.Visible = False
        Me.No8_Details.Weight = 0.0075158673588981983R
        '
        'No10_Details
        '
        Me.No10_Details.CanShrink = True
        Me.No10_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_10", "{0:#,# ;(#,#); }")})
        Me.No10_Details.Dpi = 254.0!
        Me.No10_Details.Name = "No10_Details"
        Me.No10_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.No10_Details.StylePriority.UsePadding = False
        Me.No10_Details.StylePriority.UseTextAlignment = False
        Me.No10_Details.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No10_Details.Visible = False
        Me.No10_Details.Weight = 0.007516214127715859R
        '
        'No12_Details
        '
        Me.No12_Details.CanShrink = True
        Me.No12_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_12", "{0:#,# ;(#,#); }")})
        Me.No12_Details.Dpi = 254.0!
        Me.No12_Details.Name = "No12_Details"
        Me.No12_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.No12_Details.StylePriority.UsePadding = False
        Me.No12_Details.StylePriority.UseTextAlignment = False
        Me.No12_Details.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No12_Details.Visible = False
        Me.No12_Details.Weight = 0.007516214127715859R
        '
        'No14_Details
        '
        Me.No14_Details.CanShrink = True
        Me.No14_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_14", "{0:#,# ;(#,#); }")})
        Me.No14_Details.Dpi = 254.0!
        Me.No14_Details.Name = "No14_Details"
        Me.No14_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.No14_Details.StylePriority.UsePadding = False
        Me.No14_Details.StylePriority.UseTextAlignment = False
        Me.No14_Details.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No14_Details.Visible = False
        Me.No14_Details.Weight = 0.0075158673588979763R
        '
        'No16_Details
        '
        Me.No16_Details.CanShrink = True
        Me.No16_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_16", "{0:#,# ;(#,#); }")})
        Me.No16_Details.Dpi = 254.0!
        Me.No16_Details.Name = "No16_Details"
        Me.No16_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.No16_Details.StylePriority.UsePadding = False
        Me.No16_Details.StylePriority.UseTextAlignment = False
        Me.No16_Details.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No16_Details.Visible = False
        Me.No16_Details.Weight = 0.007516214127715859R
        '
        'No20_Details
        '
        Me.No20_Details.CanShrink = True
        Me.No20_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_20", "{0:#,# ;(#,#); }")})
        Me.No20_Details.Dpi = 254.0!
        Me.No20_Details.Name = "No20_Details"
        Me.No20_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.No20_Details.StylePriority.UsePadding = False
        Me.No20_Details.StylePriority.UseTextAlignment = False
        Me.No20_Details.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No20_Details.Visible = False
        Me.No20_Details.Weight = 0.0075169076653518463R
        '
        'No40_Details
        '
        Me.No40_Details.CanShrink = True
        Me.No40_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_40", "{0:#,# ;(#,#); }")})
        Me.No40_Details.Dpi = 254.0!
        Me.No40_Details.Name = "No40_Details"
        Me.No40_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.No40_Details.StylePriority.UsePadding = False
        Me.No40_Details.StylePriority.UseTextAlignment = False
        Me.No40_Details.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No40_Details.Visible = False
        Me.No40_Details.Weight = 0.007516214127715859R
        '
        'No50_Details
        '
        Me.No50_Details.CanShrink = True
        Me.No50_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_50", "{0:#,# ;(#,#); }")})
        Me.No50_Details.Dpi = 254.0!
        Me.No50_Details.Name = "No50_Details"
        Me.No50_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.No50_Details.StylePriority.UsePadding = False
        Me.No50_Details.StylePriority.UseTextAlignment = False
        Me.No50_Details.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No50_Details.Visible = False
        Me.No50_Details.Weight = 0.007516214127715859R
        '
        'No60_Details
        '
        Me.No60_Details.CanShrink = True
        Me.No60_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_60", "{0:#,# ;(#,#); }")})
        Me.No60_Details.Dpi = 254.0!
        Me.No60_Details.Name = "No60_Details"
        Me.No60_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.No60_Details.StylePriority.UsePadding = False
        Me.No60_Details.StylePriority.UseTextAlignment = False
        Me.No60_Details.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No60_Details.Visible = False
        Me.No60_Details.Weight = 0.0075169076653516242R
        '
        'No80_Details
        '
        Me.No80_Details.CanShrink = True
        Me.No80_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_80", "{0:#,# ;(#,#); }")})
        Me.No80_Details.Dpi = 254.0!
        Me.No80_Details.Name = "No80_Details"
        Me.No80_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.No80_Details.StylePriority.UsePadding = False
        Me.No80_Details.StylePriority.UseTextAlignment = False
        Me.No80_Details.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No80_Details.Visible = False
        Me.No80_Details.Weight = 0.0084115712155024R
        '
        'No90_Details
        '
        Me.No90_Details.CanShrink = True
        Me.No90_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_90", "{0:#,# ;(#,#); }")})
        Me.No90_Details.Dpi = 254.0!
        Me.No90_Details.Name = "No90_Details"
        Me.No90_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.No90_Details.StylePriority.UsePadding = False
        Me.No90_Details.StylePriority.UseTextAlignment = False
        Me.No90_Details.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No90_Details.Visible = False
        Me.No90_Details.Weight = 0.007516214127715859R
        '
        'No100_Details
        '
        Me.No100_Details.CanShrink = True
        Me.No100_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_100", "{0:#,# ;(#,#); }")})
        Me.No100_Details.Dpi = 254.0!
        Me.No100_Details.Name = "No100_Details"
        Me.No100_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.No100_Details.StylePriority.UsePadding = False
        Me.No100_Details.StylePriority.UseTextAlignment = False
        Me.No100_Details.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No100_Details.Visible = False
        Me.No100_Details.Weight = 0.0075158673588979763R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.CA_NOTE_COLUMN")})
        Me.XrTableCell1.Dpi = 254.0!
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrTableCell1.StylePriority.UsePadding = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell1.Weight = 0.00751733090617468R
        '
        'reportFooterBand1
        '
        Me.reportFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lineReport_top, Me.dtNoteFooter, Me.lineReport_Bot, Me.table2_Report})
        Me.reportFooterBand1.Dpi = 254.0!
        Me.reportFooterBand1.HeightF = 163.2956!
        Me.reportFooterBand1.Name = "reportFooterBand1"
        '
        'lineReport_top
        '
        Me.lineReport_top.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lineReport_top.Dpi = 254.0!
        Me.lineReport_top.LocationFloat = New DevExpress.Utils.PointFloat(2.999913!, 0.9757513!)
        Me.lineReport_top.Name = "lineReport_top"
        Me.lineReport_top.SizeF = New System.Drawing.SizeF(218.5629!, 5.0!)
        Me.lineReport_top.StylePriority.UseBorders = False
        Me.lineReport_top.Visible = False
        '
        'dtNoteFooter
        '
        Me.dtNoteFooter.Dpi = 254.0!
        Me.dtNoteFooter.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 96.64558!)
        Me.dtNoteFooter.Name = "dtNoteFooter"
        Me.dtNoteFooter.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow5})
        Me.dtNoteFooter.SizeF = New System.Drawing.SizeF(2725.0!, 66.65001!)
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.NoDescription_NoteFooter, Me.NoOriCost_NoteFooter, Me.NoTWDV_NoteFooter, Me.NoTransferVal_NoteFooter, Me.XrTableCell8})
        Me.XrTableRow5.Dpi = 254.0!
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Weight = 0.5679012345679012R
        '
        'NoDescription_NoteFooter
        '
        Me.NoDescription_NoteFooter.BackColor = System.Drawing.Color.Transparent
        Me.NoDescription_NoteFooter.Dpi = 254.0!
        Me.NoDescription_NoteFooter.Name = "NoDescription_NoteFooter"
        Me.NoDescription_NoteFooter.StylePriority.UseBackColor = False
        Me.NoDescription_NoteFooter.Weight = 0.64682599624872983R
        '
        'NoOriCost_NoteFooter
        '
        Me.NoOriCost_NoteFooter.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_NOTE.CA_PURCHASE_AMOUNT")})
        Me.NoOriCost_NoteFooter.Dpi = 254.0!
        Me.NoOriCost_NoteFooter.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.NoOriCost_NoteFooter.Name = "NoOriCost_NoteFooter"
        Me.NoOriCost_NoteFooter.StylePriority.UseFont = False
        Me.NoOriCost_NoteFooter.StylePriority.UseTextAlignment = False
        Me.NoOriCost_NoteFooter.Text = "NoOriCost_NoteFooter"
        Me.NoOriCost_NoteFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.NoOriCost_NoteFooter.Weight = 0.0012658687213003561R
        '
        'NoTWDV_NoteFooter
        '
        Me.NoTWDV_NoteFooter.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_NOTE.TWDV_BF")})
        Me.NoTWDV_NoteFooter.Dpi = 254.0!
        Me.NoTWDV_NoteFooter.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.NoTWDV_NoteFooter.Name = "NoTWDV_NoteFooter"
        Me.NoTWDV_NoteFooter.StylePriority.UseFont = False
        Me.NoTWDV_NoteFooter.StylePriority.UseTextAlignment = False
        Me.NoTWDV_NoteFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.NoTWDV_NoteFooter.Weight = 0.0012658731683157509R
        '
        'NoTransferVal_NoteFooter
        '
        Me.NoTransferVal_NoteFooter.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_NOTE.CA_TRANSFER_VAL")})
        Me.NoTransferVal_NoteFooter.Dpi = 254.0!
        Me.NoTransferVal_NoteFooter.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.NoTransferVal_NoteFooter.Name = "NoTransferVal_NoteFooter"
        Me.NoTransferVal_NoteFooter.StylePriority.UseFont = False
        Me.NoTransferVal_NoteFooter.StylePriority.UseTextAlignment = False
        Me.NoTransferVal_NoteFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.NoTransferVal_NoteFooter.Weight = 0.0012658023324561563R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Dpi = 254.0!
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Weight = 0.0012383184537496233R
        '
        'lineReport_Bot
        '
        Me.lineReport_Bot.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lineReport_Bot.Dpi = 254.0!
        Me.lineReport_Bot.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 72.62135!)
        Me.lineReport_Bot.Name = "lineReport_Bot"
        Me.lineReport_Bot.SizeF = New System.Drawing.SizeF(2720.18!, 24.02421!)
        Me.lineReport_Bot.StylePriority.UseBorders = False
        '
        'table2_Report
        '
        Me.table2_Report.BackColor = System.Drawing.Color.Transparent
        Me.table2_Report.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.table2_Report.BorderWidth = 1.0!
        Me.table2_Report.Dpi = 254.0!
        Me.table2_Report.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table2_Report.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 5.975715!)
        Me.table2_Report.Name = "table2_Report"
        Me.table2_Report.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.table2_Report.SizeF = New System.Drawing.SizeF(2725.0!, 66.64565!)
        Me.table2_Report.StylePriority.UseBackColor = False
        Me.table2_Report.StylePriority.UseBorders = False
        Me.table2_Report.StylePriority.UseBorderWidth = False
        Me.table2_Report.StylePriority.UseFont = False
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.NoDescription_Report, Me.NoYE_Report, Me.NoOriCost_Report, Me.NoTWDV_Report, Me.NoTransferVal_Report, Me.NoClaim_Report, Me.No2_Report, Me.No3_Report, Me.No8_Report, Me.No10_Report, Me.No12_Report, Me.No14_Report, Me.No16_Report, Me.No20_Report, Me.No40_Report, Me.No50_Report, Me.No60_Report, Me.No80_Report, Me.No90_Report, Me.No100_Report, Me.XrTableCell3})
        Me.XrTableRow4.Dpi = 254.0!
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 10.46953028649871R
        '
        'NoDescription_Report
        '
        Me.NoDescription_Report.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.NoDescription_Report.CanShrink = True
        Me.NoDescription_Report.Dpi = 254.0!
        Me.NoDescription_Report.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoDescription_Report.Name = "NoDescription_Report"
        Me.NoDescription_Report.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 254.0!)
        Me.NoDescription_Report.StylePriority.UseBorders = False
        Me.NoDescription_Report.StylePriority.UseFont = False
        Me.NoDescription_Report.StylePriority.UsePadding = False
        Me.NoDescription_Report.StylePriority.UseTextAlignment = False
        Me.NoDescription_Report.Text = "TOTAL"
        Me.NoDescription_Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.NoDescription_Report.Weight = 3.4033079716039962R
        '
        'NoYE_Report
        '
        Me.NoYE_Report.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.NoYE_Report.CanShrink = True
        Me.NoYE_Report.Dpi = 254.0!
        Me.NoYE_Report.Name = "NoYE_Report"
        Me.NoYE_Report.StylePriority.UseBorders = False
        Me.NoYE_Report.StylePriority.UseTextAlignment = False
        Me.NoYE_Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.NoYE_Report.Weight = 0.0068951748042156424R
        '
        'NoOriCost_Report
        '
        Me.NoOriCost_Report.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.NoOriCost_Report.CanShrink = True
        Me.NoOriCost_Report.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.CA_PURCHASE_AMOUNT")})
        Me.NoOriCost_Report.Dpi = 254.0!
        Me.NoOriCost_Report.Multiline = True
        Me.NoOriCost_Report.Name = "NoOriCost_Report"
        Me.NoOriCost_Report.StylePriority.UseBorders = False
        Me.NoOriCost_Report.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.NoOriCost_Report.Summary = XrSummary1
        Me.NoOriCost_Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.NoOriCost_Report.Weight = 0.006895268781831998R
        '
        'NoTWDV_Report
        '
        Me.NoTWDV_Report.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.NoTWDV_Report.CanShrink = True
        Me.NoTWDV_Report.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.TWDV_BF")})
        Me.NoTWDV_Report.Dpi = 254.0!
        Me.NoTWDV_Report.Name = "NoTWDV_Report"
        Me.NoTWDV_Report.StylePriority.UseBorders = False
        Me.NoTWDV_Report.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.NoTWDV_Report.Summary = XrSummary2
        Me.NoTWDV_Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.NoTWDV_Report.Weight = 0.0086628491355891235R
        '
        'NoTransferVal_Report
        '
        Me.NoTransferVal_Report.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.NoTransferVal_Report.CanShrink = True
        Me.NoTransferVal_Report.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.CA_TRANSFER_VAL")})
        Me.NoTransferVal_Report.Dpi = 254.0!
        Me.NoTransferVal_Report.Multiline = True
        Me.NoTransferVal_Report.Name = "NoTransferVal_Report"
        Me.NoTransferVal_Report.StylePriority.UseBorders = False
        Me.NoTransferVal_Report.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.NoTransferVal_Report.Summary = XrSummary3
        Me.NoTransferVal_Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.NoTransferVal_Report.Weight = 0.0068947852405281118R
        '
        'NoClaim_Report
        '
        Me.NoClaim_Report.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.NoClaim_Report.CanShrink = True
        Me.NoClaim_Report.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_0")})
        Me.NoClaim_Report.Dpi = 254.0!
        Me.NoClaim_Report.Multiline = True
        Me.NoClaim_Report.Name = "NoClaim_Report"
        Me.NoClaim_Report.StylePriority.UseBorders = False
        Me.NoClaim_Report.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0:#,# ;(#,#); }"
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.NoClaim_Report.Summary = XrSummary4
        Me.NoClaim_Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.NoClaim_Report.Visible = False
        Me.NoClaim_Report.Weight = 0.0068947728391575147R
        '
        'No2_Report
        '
        Me.No2_Report.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No2_Report.CanShrink = True
        Me.No2_Report.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_2")})
        Me.No2_Report.Dpi = 254.0!
        Me.No2_Report.Multiline = True
        Me.No2_Report.Name = "No2_Report"
        Me.No2_Report.StylePriority.UseBorders = False
        Me.No2_Report.StylePriority.UseTextAlignment = False
        XrSummary5.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.No2_Report.Summary = XrSummary5
        Me.No2_Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.No2_Report.Visible = False
        Me.No2_Report.Weight = 0.0068950806015553034R
        '
        'No3_Report
        '
        Me.No3_Report.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No3_Report.CanShrink = True
        Me.No3_Report.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_3")})
        Me.No3_Report.Dpi = 254.0!
        Me.No3_Report.Name = "No3_Report"
        Me.No3_Report.StylePriority.UseBorders = False
        Me.No3_Report.StylePriority.UseTextAlignment = False
        XrSummary6.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.No3_Report.Summary = XrSummary6
        Me.No3_Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.No3_Report.Visible = False
        Me.No3_Report.Weight = 0.0068950951209934R
        '
        'No8_Report
        '
        Me.No8_Report.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No8_Report.CanShrink = True
        Me.No8_Report.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_8")})
        Me.No8_Report.Dpi = 254.0!
        Me.No8_Report.Multiline = True
        Me.No8_Report.Name = "No8_Report"
        Me.No8_Report.StylePriority.UseBorders = False
        Me.No8_Report.StylePriority.UseTextAlignment = False
        XrSummary7.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.No8_Report.Summary = XrSummary7
        Me.No8_Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.No8_Report.Visible = False
        Me.No8_Report.Weight = 0.0068950782825560886R
        '
        'No10_Report
        '
        Me.No10_Report.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No10_Report.CanShrink = True
        Me.No10_Report.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_10")})
        Me.No10_Report.Dpi = 254.0!
        Me.No10_Report.Name = "No10_Report"
        Me.No10_Report.StylePriority.UseBorders = False
        Me.No10_Report.StylePriority.UseTextAlignment = False
        XrSummary8.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.No10_Report.Summary = XrSummary8
        Me.No10_Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.No10_Report.Visible = False
        Me.No10_Report.Weight = 0.006895229772300171R
        '
        'No12_Report
        '
        Me.No12_Report.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No12_Report.CanShrink = True
        Me.No12_Report.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_12")})
        Me.No12_Report.Dpi = 254.0!
        Me.No12_Report.Name = "No12_Report"
        Me.No12_Report.StylePriority.UseBorders = False
        Me.No12_Report.StylePriority.UseTextAlignment = False
        XrSummary9.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.No12_Report.Summary = XrSummary9
        Me.No12_Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.No12_Report.Visible = False
        Me.No12_Report.Weight = 0.0068950933819316162R
        '
        'No14_Report
        '
        Me.No14_Report.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No14_Report.CanShrink = True
        Me.No14_Report.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_14")})
        Me.No14_Report.Dpi = 254.0!
        Me.No14_Report.Name = "No14_Report"
        Me.No14_Report.StylePriority.UseBorders = False
        Me.No14_Report.StylePriority.UseTextAlignment = False
        XrSummary10.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.No14_Report.Summary = XrSummary10
        Me.No14_Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.No14_Report.Visible = False
        Me.No14_Report.Weight = 0.0068951051568788557R
        '
        'No16_Report
        '
        Me.No16_Report.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No16_Report.CanShrink = True
        Me.No16_Report.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_16")})
        Me.No16_Report.Dpi = 254.0!
        Me.No16_Report.Name = "No16_Report"
        Me.No16_Report.StylePriority.UseBorders = False
        Me.No16_Report.StylePriority.UseTextAlignment = False
        XrSummary11.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.No16_Report.Summary = XrSummary11
        Me.No16_Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.No16_Report.Visible = False
        Me.No16_Report.Weight = 0.007725782730292563R
        '
        'No20_Report
        '
        Me.No20_Report.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No20_Report.CanShrink = True
        Me.No20_Report.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_20")})
        Me.No20_Report.Dpi = 254.0!
        Me.No20_Report.Name = "No20_Report"
        Me.No20_Report.StylePriority.UseBorders = False
        Me.No20_Report.StylePriority.UseTextAlignment = False
        XrSummary12.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.No20_Report.Summary = XrSummary12
        Me.No20_Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.No20_Report.Visible = False
        Me.No20_Report.Weight = 0.0068950955070663511R
        '
        'No40_Report
        '
        Me.No40_Report.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No40_Report.CanShrink = True
        Me.No40_Report.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_40")})
        Me.No40_Report.Dpi = 254.0!
        Me.No40_Report.Name = "No40_Report"
        Me.No40_Report.StylePriority.UseBorders = False
        Me.No40_Report.StylePriority.UseTextAlignment = False
        XrSummary13.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.No40_Report.Summary = XrSummary13
        Me.No40_Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.No40_Report.Visible = False
        Me.No40_Report.Weight = 0.0068951631617677478R
        '
        'No50_Report
        '
        Me.No50_Report.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No50_Report.CanShrink = True
        Me.No50_Report.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_50")})
        Me.No50_Report.Dpi = 254.0!
        Me.No50_Report.Name = "No50_Report"
        Me.No50_Report.StylePriority.UseBorders = False
        Me.No50_Report.StylePriority.UseTextAlignment = False
        XrSummary14.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.No50_Report.Summary = XrSummary14
        Me.No50_Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.No50_Report.Visible = False
        Me.No50_Report.Weight = 0.0068951631617584219R
        '
        'No60_Report
        '
        Me.No60_Report.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No60_Report.CanShrink = True
        Me.No60_Report.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_60")})
        Me.No60_Report.Dpi = 254.0!
        Me.No60_Report.Name = "No60_Report"
        Me.No60_Report.StylePriority.UseBorders = False
        Me.No60_Report.StylePriority.UseTextAlignment = False
        XrSummary15.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.No60_Report.Summary = XrSummary15
        Me.No60_Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.No60_Report.Visible = False
        Me.No60_Report.Weight = 0.0071016405248137682R
        '
        'No80_Report
        '
        Me.No80_Report.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No80_Report.CanShrink = True
        Me.No80_Report.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_80")})
        Me.No80_Report.Dpi = 254.0!
        Me.No80_Report.Name = "No80_Report"
        Me.No80_Report.StylePriority.UseBorders = False
        Me.No80_Report.StylePriority.UseTextAlignment = False
        XrSummary16.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.No80_Report.Summary = XrSummary16
        Me.No80_Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.No80_Report.Visible = False
        Me.No80_Report.Weight = 0.0068948322785087335R
        '
        'No90_Report
        '
        Me.No90_Report.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No90_Report.CanShrink = True
        Me.No90_Report.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_90")})
        Me.No90_Report.Dpi = 254.0!
        Me.No90_Report.Name = "No90_Report"
        Me.No90_Report.StylePriority.UseBorders = False
        Me.No90_Report.StylePriority.UseTextAlignment = False
        XrSummary17.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary17.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.No90_Report.Summary = XrSummary17
        Me.No90_Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.No90_Report.Visible = False
        Me.No90_Report.Weight = 0.0074308657378433507R
        '
        'No100_Report
        '
        Me.No100_Report.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No100_Report.CanShrink = True
        Me.No100_Report.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_100")})
        Me.No100_Report.Dpi = 254.0!
        Me.No100_Report.Name = "No100_Report"
        Me.No100_Report.StylePriority.UseBorders = False
        Me.No100_Report.StylePriority.UseTextAlignment = False
        XrSummary18.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary18.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.No100_Report.Summary = XrSummary18
        Me.No100_Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.No100_Report.Visible = False
        Me.No100_Report.Weight = 0.0078797045784880781R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell3.Dpi = 254.0!
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseBorders = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell3.Weight = 0.012036788122213926R
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
        Me.bottomMarginBand1.HeightF = 109.0!
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
        'paramID
        '
        Me.paramID.Description = "paramID"
        Me.paramID.Name = "paramID"
        '
        'DsCA1
        '
        Me.DsCA1.DataSetName = "dsCA"
        Me.DsCA1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel6})
        Me.GroupHeader1.Dpi = 254.0!
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CA_CATEGORY_CODE", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage
        Me.GroupHeader1.HeightF = 84.8783!
        Me.GroupHeader1.KeepTogether = True
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel6
        '
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.CA_CATEGORY_CODE")})
        Me.XrLabel6.Dpi = 254.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(2725.0!, 58.42!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.Text = "XrLabel6"
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.CA_TRANSFERROR_NAME")})
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 18.0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(2722.0!, 58.42!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "XrLabel5"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Dpi = 254.0!
        Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CA_CAEEO", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader2.HeightF = 3.0!
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'GroupHeader3
        '
        Me.GroupHeader3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5})
        Me.GroupHeader3.Dpi = 254.0!
        Me.GroupHeader3.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CA_TRANSFERROR_NAME", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader3.HeightF = 100.1875!
        Me.GroupHeader3.Level = 2
        Me.GroupHeader3.Name = "GroupHeader3"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lineFooter_Bot, Me.lineFooter_Top, Me.table2_Footer})
        Me.GroupFooter1.Dpi = 254.0!
        Me.GroupFooter1.HeightF = 104.1151!
        Me.GroupFooter1.KeepTogether = True
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand1})
        '
        'lineFooter_Bot
        '
        Me.lineFooter_Bot.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lineFooter_Bot.Dpi = 254.0!
        Me.lineFooter_Bot.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 82.7367!)
        Me.lineFooter_Bot.Name = "lineFooter_Bot"
        Me.lineFooter_Bot.SizeF = New System.Drawing.SizeF(218.5629!, 21.37837!)
        Me.lineFooter_Bot.StylePriority.UseBorders = False
        '
        'lineFooter_Top
        '
        Me.lineFooter_Top.Dpi = 254.0!
        Me.lineFooter_Top.LineWidth = 3
        Me.lineFooter_Top.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.lineFooter_Top.Name = "lineFooter_Top"
        Me.lineFooter_Top.SizeF = New System.Drawing.SizeF(218.5629!, 16.08671!)
        '
        'table2_Footer
        '
        Me.table2_Footer.BackColor = System.Drawing.Color.Transparent
        Me.table2_Footer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.table2_Footer.BorderWidth = 1.0!
        Me.table2_Footer.Dpi = 254.0!
        Me.table2_Footer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table2_Footer.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 16.08671!)
        Me.table2_Footer.Name = "table2_Footer"
        Me.table2_Footer.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.table2_Footer.SizeF = New System.Drawing.SizeF(2725.0!, 66.64999!)
        Me.table2_Footer.StylePriority.UseBackColor = False
        Me.table2_Footer.StylePriority.UseBorders = False
        Me.table2_Footer.StylePriority.UseBorderWidth = False
        Me.table2_Footer.StylePriority.UseFont = False
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.NoDescription_Footer, Me.NoYE_Footer, Me.NoOriCost_Footer, Me.NoTWDV_Footer, Me.NoTransferVal_Footer, Me.NoClaim_Footer, Me.No2_Footer, Me.No3_Footer, Me.No8_Footer, Me.No10_Footer, Me.No12_Footer, Me.No14_Footer, Me.No16_Footer, Me.No20_Footer, Me.No40_Footer, Me.No50_Footer, Me.No60_Footer, Me.No80_Footer, Me.No90_Footer, Me.No100_Footer, Me.XrTableCell2})
        Me.XrTableRow3.Dpi = 254.0!
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 10.46953028649871R
        '
        'NoDescription_Footer
        '
        Me.NoDescription_Footer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.NoDescription_Footer.Dpi = 254.0!
        Me.NoDescription_Footer.Name = "NoDescription_Footer"
        Me.NoDescription_Footer.StylePriority.UseBorders = False
        Me.NoDescription_Footer.StylePriority.UseTextAlignment = False
        Me.NoDescription_Footer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.NoDescription_Footer.Weight = 5.771861693956712R
        '
        'NoYE_Footer
        '
        Me.NoYE_Footer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.NoYE_Footer.CanShrink = True
        Me.NoYE_Footer.Dpi = 254.0!
        Me.NoYE_Footer.Name = "NoYE_Footer"
        Me.NoYE_Footer.StylePriority.UseBorders = False
        Me.NoYE_Footer.StylePriority.UseTextAlignment = False
        Me.NoYE_Footer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.NoYE_Footer.Weight = 0.01122379898821757R
        '
        'NoOriCost_Footer
        '
        Me.NoOriCost_Footer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.NoOriCost_Footer.CanShrink = True
        Me.NoOriCost_Footer.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.CA_PURCHASE_AMOUNT", "{0:#,# ;(#,#);0 }")})
        Me.NoOriCost_Footer.Dpi = 254.0!
        Me.NoOriCost_Footer.Multiline = True
        Me.NoOriCost_Footer.Name = "NoOriCost_Footer"
        Me.NoOriCost_Footer.StylePriority.UseBorders = False
        Me.NoOriCost_Footer.StylePriority.UseTextAlignment = False
        XrSummary19.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary19.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.NoOriCost_Footer.Summary = XrSummary19
        Me.NoOriCost_Footer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.NoOriCost_Footer.Weight = 0.011224328020101051R
        '
        'NoTWDV_Footer
        '
        Me.NoTWDV_Footer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.NoTWDV_Footer.CanShrink = True
        Me.NoTWDV_Footer.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.TWDV_BF")})
        Me.NoTWDV_Footer.Dpi = 254.0!
        Me.NoTWDV_Footer.Name = "NoTWDV_Footer"
        Me.NoTWDV_Footer.StylePriority.UseBorders = False
        Me.NoTWDV_Footer.StylePriority.UseTextAlignment = False
        XrSummary20.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary20.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.NoTWDV_Footer.Summary = XrSummary20
        Me.NoTWDV_Footer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.NoTWDV_Footer.Weight = 0.011224329350619081R
        '
        'NoTransferVal_Footer
        '
        Me.NoTransferVal_Footer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.NoTransferVal_Footer.CanShrink = True
        Me.NoTransferVal_Footer.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.CA_TRANSFER_VAL")})
        Me.NoTransferVal_Footer.Dpi = 254.0!
        Me.NoTransferVal_Footer.Multiline = True
        Me.NoTransferVal_Footer.Name = "NoTransferVal_Footer"
        Me.NoTransferVal_Footer.StylePriority.UseBorders = False
        Me.NoTransferVal_Footer.StylePriority.UseTextAlignment = False
        XrSummary21.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary21.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.NoTransferVal_Footer.Summary = XrSummary21
        Me.NoTransferVal_Footer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.NoTransferVal_Footer.Weight = 0.011225880819100989R
        '
        'NoClaim_Footer
        '
        Me.NoClaim_Footer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.NoClaim_Footer.CanShrink = True
        Me.NoClaim_Footer.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_0")})
        Me.NoClaim_Footer.Dpi = 254.0!
        Me.NoClaim_Footer.Multiline = True
        Me.NoClaim_Footer.Name = "NoClaim_Footer"
        Me.NoClaim_Footer.StylePriority.UseBorders = False
        Me.NoClaim_Footer.StylePriority.UseTextAlignment = False
        XrSummary22.FormatString = "{0:#,# ;(#,#); }"
        XrSummary22.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.NoClaim_Footer.Summary = XrSummary22
        Me.NoClaim_Footer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.NoClaim_Footer.Visible = False
        Me.NoClaim_Footer.Weight = 0.011224330240709672R
        '
        'No2_Footer
        '
        Me.No2_Footer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No2_Footer.CanShrink = True
        Me.No2_Footer.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_2")})
        Me.No2_Footer.Dpi = 254.0!
        Me.No2_Footer.Multiline = True
        Me.No2_Footer.Name = "No2_Footer"
        Me.No2_Footer.StylePriority.UseBorders = False
        Me.No2_Footer.StylePriority.UseTextAlignment = False
        XrSummary23.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary23.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.No2_Footer.Summary = XrSummary23
        Me.No2_Footer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No2_Footer.Visible = False
        Me.No2_Footer.Weight = 0.011224846311143587R
        '
        'No3_Footer
        '
        Me.No3_Footer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No3_Footer.CanShrink = True
        Me.No3_Footer.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_3")})
        Me.No3_Footer.Dpi = 254.0!
        Me.No3_Footer.Name = "No3_Footer"
        Me.No3_Footer.StylePriority.UseBorders = False
        Me.No3_Footer.StylePriority.UseTextAlignment = False
        XrSummary24.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary24.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.No3_Footer.Summary = XrSummary24
        Me.No3_Footer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No3_Footer.Visible = False
        Me.No3_Footer.Weight = 0.011904262418968879R
        '
        'No8_Footer
        '
        Me.No8_Footer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No8_Footer.CanShrink = True
        Me.No8_Footer.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_8")})
        Me.No8_Footer.Dpi = 254.0!
        Me.No8_Footer.Multiline = True
        Me.No8_Footer.Name = "No8_Footer"
        Me.No8_Footer.StylePriority.UseBorders = False
        Me.No8_Footer.StylePriority.UseTextAlignment = False
        XrSummary25.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary25.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.No8_Footer.Summary = XrSummary25
        Me.No8_Footer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No8_Footer.Visible = False
        Me.No8_Footer.Weight = 0.01122536539933492R
        '
        'No10_Footer
        '
        Me.No10_Footer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No10_Footer.CanShrink = True
        Me.No10_Footer.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_10")})
        Me.No10_Footer.Dpi = 254.0!
        Me.No10_Footer.Name = "No10_Footer"
        Me.No10_Footer.StylePriority.UseBorders = False
        Me.No10_Footer.StylePriority.UseTextAlignment = False
        XrSummary26.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary26.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.No10_Footer.Summary = XrSummary26
        Me.No10_Footer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No10_Footer.Visible = False
        Me.No10_Footer.Weight = 0.011223812344294162R
        '
        'No12_Footer
        '
        Me.No12_Footer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No12_Footer.CanShrink = True
        Me.No12_Footer.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_12")})
        Me.No12_Footer.Dpi = 254.0!
        Me.No12_Footer.Name = "No12_Footer"
        Me.No12_Footer.StylePriority.UseBorders = False
        Me.No12_Footer.StylePriority.UseTextAlignment = False
        XrSummary27.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary27.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.No12_Footer.Summary = XrSummary27
        Me.No12_Footer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No12_Footer.Visible = False
        Me.No12_Footer.Weight = 0.011224846954485911R
        '
        'No14_Footer
        '
        Me.No14_Footer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No14_Footer.CanShrink = True
        Me.No14_Footer.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_14")})
        Me.No14_Footer.Dpi = 254.0!
        Me.No14_Footer.Name = "No14_Footer"
        Me.No14_Footer.StylePriority.UseBorders = False
        Me.No14_Footer.StylePriority.UseTextAlignment = False
        XrSummary28.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary28.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.No14_Footer.Summary = XrSummary28
        Me.No14_Footer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No14_Footer.Visible = False
        Me.No14_Footer.Weight = 0.015570098798649998R
        '
        'No16_Footer
        '
        Me.No16_Footer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No16_Footer.CanShrink = True
        Me.No16_Footer.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_16")})
        Me.No16_Footer.Dpi = 254.0!
        Me.No16_Footer.Name = "No16_Footer"
        Me.No16_Footer.StylePriority.UseBorders = False
        Me.No16_Footer.StylePriority.UseTextAlignment = False
        XrSummary29.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary29.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.No16_Footer.Summary = XrSummary29
        Me.No16_Footer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No16_Footer.Visible = False
        Me.No16_Footer.Weight = 0.011224327672431082R
        '
        'No20_Footer
        '
        Me.No20_Footer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No20_Footer.CanShrink = True
        Me.No20_Footer.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_20")})
        Me.No20_Footer.Dpi = 254.0!
        Me.No20_Footer.Name = "No20_Footer"
        Me.No20_Footer.StylePriority.UseBorders = False
        Me.No20_Footer.StylePriority.UseTextAlignment = False
        XrSummary30.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary30.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.No20_Footer.Summary = XrSummary30
        Me.No20_Footer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No20_Footer.Visible = False
        Me.No20_Footer.Weight = 0.011224327187160162R
        '
        'No40_Footer
        '
        Me.No40_Footer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No40_Footer.CanShrink = True
        Me.No40_Footer.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_40")})
        Me.No40_Footer.Dpi = 254.0!
        Me.No40_Footer.Name = "No40_Footer"
        Me.No40_Footer.StylePriority.UseBorders = False
        Me.No40_Footer.StylePriority.UseTextAlignment = False
        XrSummary31.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary31.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.No40_Footer.Summary = XrSummary31
        Me.No40_Footer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No40_Footer.Visible = False
        Me.No40_Footer.Weight = 0.011224330487081866R
        '
        'No50_Footer
        '
        Me.No50_Footer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No50_Footer.CanShrink = True
        Me.No50_Footer.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_50")})
        Me.No50_Footer.Dpi = 254.0!
        Me.No50_Footer.Name = "No50_Footer"
        Me.No50_Footer.StylePriority.UseBorders = False
        Me.No50_Footer.StylePriority.UseTextAlignment = False
        XrSummary32.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary32.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.No50_Footer.Summary = XrSummary32
        Me.No50_Footer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No50_Footer.Visible = False
        Me.No50_Footer.Weight = 0.011224327447539435R
        '
        'No60_Footer
        '
        Me.No60_Footer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No60_Footer.CanShrink = True
        Me.No60_Footer.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_60")})
        Me.No60_Footer.Dpi = 254.0!
        Me.No60_Footer.Name = "No60_Footer"
        Me.No60_Footer.StylePriority.UseBorders = False
        Me.No60_Footer.StylePriority.UseTextAlignment = False
        XrSummary33.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary33.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.No60_Footer.Summary = XrSummary33
        Me.No60_Footer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No60_Footer.Visible = False
        Me.No60_Footer.Weight = 0.011225880727499415R
        '
        'No80_Footer
        '
        Me.No80_Footer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No80_Footer.CanShrink = True
        Me.No80_Footer.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_80")})
        Me.No80_Footer.Dpi = 254.0!
        Me.No80_Footer.Name = "No80_Footer"
        Me.No80_Footer.StylePriority.UseBorders = False
        Me.No80_Footer.StylePriority.UseTextAlignment = False
        XrSummary34.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary34.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.No80_Footer.Summary = XrSummary34
        Me.No80_Footer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No80_Footer.Visible = False
        Me.No80_Footer.Weight = 0.012561928988384229R
        '
        'No90_Footer
        '
        Me.No90_Footer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No90_Footer.CanShrink = True
        Me.No90_Footer.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_90")})
        Me.No90_Footer.Dpi = 254.0!
        Me.No90_Footer.Name = "No90_Footer"
        Me.No90_Footer.StylePriority.UseBorders = False
        Me.No90_Footer.StylePriority.UseTextAlignment = False
        XrSummary35.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary35.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.No90_Footer.Summary = XrSummary35
        Me.No90_Footer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No90_Footer.Visible = False
        Me.No90_Footer.Weight = 0.011223809340319794R
        '
        'No100_Footer
        '
        Me.No100_Footer.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.No100_Footer.CanShrink = True
        Me.No100_Footer.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CA_REPORT_CONTROLTRANSFER_TEMP.AA_100")})
        Me.No100_Footer.Dpi = 254.0!
        Me.No100_Footer.Name = "No100_Footer"
        Me.No100_Footer.StylePriority.UseBorders = False
        Me.No100_Footer.StylePriority.UseTextAlignment = False
        XrSummary36.FormatString = "{0:#,# ;(#,#); }"
        XrSummary36.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.No100_Footer.Summary = XrSummary36
        Me.No100_Footer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.No100_Footer.Visible = False
        Me.No100_Footer.Weight = 0.011224330495059748R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell2.Dpi = 254.0!
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseBorders = False
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell2.Weight = 0.01122437904319544R
        '
        'SubBand1
        '
        Me.SubBand1.BackColor = System.Drawing.Color.Transparent
        Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1})
        Me.SubBand1.Dpi = 254.0!
        Me.SubBand1.HeightF = 41.35746!
        Me.SubBand1.Name = "SubBand1"
        Me.SubBand1.StylePriority.UseBackColor = False
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(2.999918!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(156.1042!, 41.35746!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = " "
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel8})
        Me.GroupFooter2.Dpi = 254.0!
        Me.GroupFooter2.HeightF = 33.41996!
        Me.GroupFooter2.KeepTogether = True
        Me.GroupFooter2.Level = 1
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'XrLabel8
        '
        Me.XrLabel8.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel8.Dpi = 254.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(156.1042!, 33.41996!)
        Me.XrLabel8.StylePriority.UseBackColor = False
        Me.XrLabel8.StylePriority.UseFont = False
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblDraft_Report, Me.XrLabel7, Me.lblTitle, Me.XrLabel4, Me.XrLabel2})
        Me.ReportHeader.Dpi = 254.0!
        Me.ReportHeader.HeightF = 373.3748!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'lblDraft_Report
        '
        Me.lblDraft_Report.CanShrink = True
        Me.lblDraft_Report.Dpi = 254.0!
        Me.lblDraft_Report.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDraft_Report.FormattingRules.Add(Me.ShowDraft)
        Me.lblDraft_Report.LocationFloat = New DevExpress.Utils.PointFloat(2404.855!, 24.99999!)
        Me.lblDraft_Report.Name = "lblDraft_Report"
        Me.lblDraft_Report.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblDraft_Report.SizeF = New System.Drawing.SizeF(320.1453!, 58.42001!)
        Me.lblDraft_Report.StylePriority.UseFont = False
        Me.lblDraft_Report.StylePriority.UseTextAlignment = False
        Me.lblDraft_Report.Text = "DRAFT"
        Me.lblDraft_Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblDraft_Report.Visible = False
        '
        'param_ShowDraft
        '
        Me.param_ShowDraft.Description = "param_ShowDraft"
        Me.param_ShowDraft.Name = "param_ShowDraft"
        Me.param_ShowDraft.Type = GetType(Boolean)
        Me.param_ShowDraft.ValueInfo = "False"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.lblPageNo})
        Me.PageFooter.Dpi = 254.0!
        Me.PageFooter.HeightF = 58.42!
        Me.PageFooter.Name = "PageFooter"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.XrPageInfo1.Dpi = 254.0!
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrPageInfo1.Format = "{0}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(2165.549!, 0.0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(253.9995!, 58.42!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrPageInfo1.Visible = False
        '
        'lblPageNo
        '
        Me.lblPageNo.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        Me.lblPageNo.Dpi = 254.0!
        Me.lblPageNo.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblPageNo.Format = "Page {0} / {1}"
        Me.lblPageNo.LocationFloat = New DevExpress.Utils.PointFloat(2471.001!, 0.0!)
        Me.lblPageNo.Name = "lblPageNo"
        Me.lblPageNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblPageNo.SizeF = New System.Drawing.SizeF(253.9995!, 58.42!)
        Me.lblPageNo.StylePriority.UseFont = False
        Me.lblPageNo.StylePriority.UseTextAlignment = False
        Me.lblPageNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'rpt_CAControlTransfer
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.topMarginBand1, Me.pageHeaderBand1, Me.detailBand1, Me.reportFooterBand1, Me.bottomMarginBand1, Me.GroupHeader1, Me.GroupHeader2, Me.GroupHeader3, Me.GroupFooter1, Me.GroupFooter2, Me.ReportHeader, Me.PageFooter})
        Me.DataMember = "CA_REPORT_CONTROLTRANSFER_TEMP"
        Me.DataSource = Me.DsCA1
        Me.Dpi = 254.0!
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.FormattingRule1, Me.ShowDraft})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(195, 50, 54, 109)
        Me.PageHeight = 2100
        Me.PageWidth = 2970
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.paramCompanyName, Me.paramYA, Me.paramID, Me.FontSize, Me.paramSch, Me.param_ShowDraft, Me.paramTitle})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.RequestParameters = False
        Me.SnapGridSize = 25.0!
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.ReportHeaderBandStyle, Me.ReportGroupHeaderBandStyle, Me.ReportDetailBandStyle, Me.ReportGroupFooterBandStyle, Me.ReportFooterBandStyle, Me.ReportOddStyle, Me.ReportEvenStyle})
        Me.Version = "17.1"
        CType(Me.tblTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtNoteFooter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table2_Report, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table2_Footer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    'Public Function CreateXRTable(ByVal TotalFixed As Integer) As XRTable
    '    Dim dt As DataTable = Nothing
    '    dt = ADO.Load_CAReport_ControlTransfer_Temp(paramID.Value)

    '    If dt Is Nothing Then
    '        Exit Function
    '    End If
    ' Dim ListofAA As List(Of String) = mdlCA.Get_ListofAA()

    '    Dim tmpStatus As Boolean = False
    '    For y As Integer = 0 To ListofAA.Count - 1
    '        tmpStatus = False
    '        For x As Integer = 0 To dt.Rows.Count - 1

    '            If tmpStatus = False AndAlso IsDBNull(dt.Rows(x)(ListofAA(y))) = False AndAlso dt.Rows(x)(ListofAA(y)) <> 0 Then
    '                tmpStatus = True
    '                TotalFixed += 1
    '            End If

    '        Next

    '    Next

    '    ' Create an empty table and set its size.
    '    Dim table As New XRTable()
    '    table.Size = New Size(1100, 60)

    '    ' Start table initialization.
    '    table.BeginInit()

    '    ' Enable table borders to see its boundaries.
    '    table.BorderWidth = 0
    '    table.Borders = DevExpress.XtraPrinting.BorderSide.None
    '    table.Font = New Font("Arial", 10, FontStyle.Bold)

    '    ' Create a table row.
    '    Dim row As XRTableRow
    '    Dim cell As XRTableCell
    '    tmpStatus = False
    '    row = New XRTableRow
    '    For i As Integer = 0 To TotalFixed - 1
    '        cell = Nothing
    '        cell = New XRTableCell
    '        cell.Name = "cell" & i


    '        Select Case i
    '            Case 0
    '                cell.Text = ""
    '                cell.WidthF = 20
    '            Case 1
    '                cell.Text = "Year of"
    '                cell.WidthF = 8
    '                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
    '            Case 2
    '                cell.Text = "Original Cost"
    '                cell.WidthF = 10
    '                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
    '            Case 3
    '                cell.Text = "TAX WDV"
    '                cell.WidthF = 10
    '                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
    '            Case 4
    '                cell.Text = "Transfer"
    '                cell.WidthF = 10
    '                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
    '            Case 5
    '                cell.Text = ""
    '                cell.WidthF = 10
    '                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
    '            Case Else
    '                For y As Integer = 0 To ListofAA.Count - 1
    '                    tmpStatus = False
    '                    For x As Integer = 0 To dt.Rows.Count - 1

    '                        If tmpStatus = False AndAlso IsDBNull(dt.Rows(x)(ListofAA(y))) = False AndAlso dt.Rows(x)(ListofAA(y)) <> 0 Then
    '                            tmpStatus = True

    '                            cell.Text = ""
    '                            'cell.WidthF = DynamicWidth
    '                            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
    '                        End If

    '                    Next

    '                Next

    '        End Select

    '        row.Cells.Add(cell)
    '    Next

    '    table.Rows.Add(row)
    '    row = Nothing
    '    row = New XRTableRow
    '    tmpStatus = False
    '    For i As Integer = 0 To TotalFixed - 1
    '        cell = Nothing
    '        cell = New XRTableCell
    '        cell.Name = "cell" & i


    '        Select Case i
    '            Case 0
    '                cell.Text = "Description"
    '                cell.WidthF = 20
    '                row.Cells.Add(cell)
    '            Case 1
    '                cell.Text = "Purchase"
    '                cell.WidthF = 8
    '                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '            Case 2
    '                cell.Text = "Transferred"
    '                cell.WidthF = 10
    '                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '            Case 3
    '                cell.Text = "Transferred"
    '                cell.WidthF = 10
    '                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '            Case 4
    '                cell.Text = "Value"
    '                cell.WidthF = 10
    '                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '                row.Cells.Add(cell)
    '            Case 5
    '                cell.Text = "No Claim"
    '                cell.WidthF = 10
    '                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
    '            Case Else
    '                For y As Integer = 0 To ListofAA.Count - 1
    '                    tmpStatus = False
    '                    For x As Integer = 0 To dt.Rows.Count - 1

    '                        If tmpStatus = False AndAlso IsDBNull(dt.Rows(x)(ListofAA(y))) = False AndAlso dt.Rows(x)(ListofAA(y)) <> 0 Then
    '                            tmpStatus = True

    '                            If (TotalFixed - 1) = i Then
    '                                cell.Text = "ACA " & ListofAA(y).Replace("AA_", "") & "%"
    '                            Else
    '                                cell.Text = ListofAA(y).Replace("AA_", "") & "%"
    '                            End If
    '                            '   cell.WidthF = DynamicWidth
    '                            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter

    '                        End If

    '                    Next

    '                Next

    '        End Select

    '        row.Cells.Add(cell)
    '    Next

    '    ' Construct the table.
    '    table.Rows.Add(row)
    '    row = Nothing
    '    row = New XRTableRow

    '    For i As Integer = 0 To TotalFixed - 1
    '        cell = Nothing
    '        cell = New XRTableCell
    '        cell.Name = "cell" & i


    '        Select Case i
    '            Case 0
    '                cell.Text = ""
    '                cell.WidthF = 20
    '            Case 1
    '                cell.Text = ""
    '                cell.WidthF = 8
    '            Case 2, 3, 4, 5
    '                cell.Text = "RM"
    '                cell.WidthF = 10
    '                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
    '            Case Else
    '                For y As Integer = 0 To ListofAA.Count - 1
    '                    tmpStatus = False
    '                    For x As Integer = 0 To dt.Rows.Count - 1

    '                        If tmpStatus = False AndAlso IsDBNull(dt.Rows(x)(ListofAA(y))) = False AndAlso dt.Rows(x)(ListofAA(y)) <> 0 Then
    '                            tmpStatus = True

    '                            cell.Text = "RM"
    '                            '  cell.WidthF = DynamicWidth
    '                            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
    '                        End If

    '                    Next

    '                Next

    '        End Select

    '        row.Cells.Add(cell)
    '    Next

    '    ' Construct the table.
    '    table.Rows.Add(row)
    '    ' Finish table initialization.
    '    table.EndInit()

    '    Return table
    'End Function

    'Private Sub pageHeaderBand1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles pageHeaderBand1.BeforePrint
    '    Me.pageHeaderBand1.Controls.Add(CreateXRTable(6))
    'End Sub

    Private Sub No2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles tblTitle.BeforePrint  ', No3.BeforePrint, No8.BeforePrint, No10.BeforePrint, No12.BeforePrint, No14.BeforePrint, No16.BeforePrint, No20.BeforePrint, No40.BeforePrint, No50.BeforePrint, No60.BeforePrint, No8.BeforePrint, No90.BeforePrint, No100.BeforePrint
        Try
            Dim dt As DataTable = Nothing
            dt = ADO.Load_CAReport_ControlTransfer_Temp(paramID.Value)

            If dt Is Nothing Then
                Exit Sub
            End If
            Dim ListofAA As List(Of String) = mdlCA.Get_ListofAA(True)

            Dim tmpStatus As Boolean = False

            Dim TotalWidth_Main As Decimal = 2830
            Dim TotalWidth As Decimal = 0
            Dim DynamicWidth As Decimal = 0
            Dim TotalColumn As Integer = 6

            For y As Integer = 0 To ListofAA.Count - 1
                tmpStatus = False
                For x As Integer = 0 To dt.Rows.Count - 1

                    If tmpStatus = False AndAlso IsDBNull(dt.Rows(x)(ListofAA(y))) = False AndAlso dt.Rows(x)(ListofAA(y)) <> 0 Then
                        tmpStatus = True
                        If IsNumeric(ListofAA(y).Replace("AA_", "")) Then
                            Select Case CInt(ListofAA(y).Replace("AA_", ""))
                                Case 0
                                    NoClaim.Visible = True
                                    TotalColumn += 1
                                Case 2
                                    No2.Visible = True
                                    TotalColumn += 1
                                Case 3
                                    No3.Visible = True
                                    TotalColumn += 1
                                Case 8
                                    No8.Visible = True
                                    TotalColumn += 1
                                Case 10
                                    No10.Visible = True
                                    TotalColumn += 1
                                Case 12
                                    No12.Visible = True
                                    TotalColumn += 1
                                Case 14
                                    No14.Visible = True
                                    TotalColumn += 1
                                Case 16
                                    No16.Visible = True
                                    TotalColumn += 1
                                Case 20
                                    No20.Visible = True
                                    TotalColumn += 1
                                Case 40
                                    No40.Visible = True
                                    TotalColumn += 1
                                Case 50
                                    No50.Visible = True
                                    TotalColumn += 1
                                Case 60
                                    No60.Visible = True
                                    TotalColumn += 1
                                Case 80
                                    No80.Visible = True
                                    TotalColumn += 1
                                Case 90
                                    No90.Visible = True
                                    TotalColumn += 1
                                Case 100
                                    No100.Visible = True
                                    TotalColumn += 1
                            End Select
                        End If

                    End If

                Next

            Next

            Dim TotalQF As Decimal = 0
            Dim DynamicColumn As Integer = TotalColumn - 6
            Dim BalanceWidth As Decimal = 0

            If DynamicColumn = 0 AndAlso DynamicColumn <= 10 Then
                DynamicWidth = (TotalWidth_Main - 1611.18) / DynamicColumn
            Else
                DynamicWidth = (TotalWidth_Main - 1205.51) / DynamicColumn
            End If

            If DynamicWidth > 200 Then
                BalanceWidth = (DynamicWidth * DynamicColumn) - (200 * DynamicColumn)
                DynamicWidth = 200
                If DynamicColumn = 1 Then
                    DynamicWidth = 230
                End If
            End If

            For i As Integer = 0 To TotalColumn
                Select Case i
                    Case 0
                        If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                            NoDescription_Top.WidthF = 504.26 '+ BalanceWidth - 50
                            NoDescription.WidthF = 504.26 '+ BalanceWidth - 50
                            NoDescription_Bot.WidthF = 504.26
                        Else
                            NoDescription_Top.WidthF = 215.23 '+ BalanceWidth - 50
                            NoDescription.WidthF = 215.23 '+ BalanceWidth - 50
                            NoDescription_Bot.WidthF = 215.23
                        End If
                    Case 1
                        If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                            NoYE_Top.WidthF = 187.04
                            NoYE.WidthF = 187.04
                            NoYE_Bot.WidthF = 187.04
                        Else
                            NoYE_Top.WidthF = 187.04
                            NoYE.WidthF = 187.04
                            NoYE_Bot.WidthF = 187.04
                        End If
                    Case 2
                        If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                            NoOriCost_Top.WidthF = 250.35
                            NoOriCost.WidthF = 250.35
                            NoOriCost_Bot.WidthF = 250.35
                        Else
                            NoOriCost_Top.WidthF = 205.37
                            NoOriCost.WidthF = 205.37
                            NoOriCost_Bot.WidthF = 205.37
                        End If

                        TotalWidth += NoOriCost_Top.WidthF
                    Case 3
                        If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                            NoTWDV_Top.WidthF = 226.46
                            NoTWDV.WidthF = 226.46
                            NoTWDV_Bot.WidthF = 226.46
                        Else
                            NoTWDV_Top.WidthF = 190.42
                            NoTWDV.WidthF = 190.42
                            NoTWDV_Bot.WidthF = 190.42
                        End If
                        TotalWidth += NoTWDV_Top.WidthF
                    Case 4
                        If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                            NoTransferVal_Top.WidthF = 226.77
                            NoTransferVal.WidthF = 226.77
                            NoTransferVal_Bot.WidthF = 226.77
                        Else
                            NoTransferVal_Top.WidthF = 180.75
                            NoTransferVal.WidthF = 180.75
                            NoTransferVal_Bot.WidthF = 180.75
                        End If
                        TotalWidth += NoTransferVal_Top.WidthF
                        'Case 5
                        '    If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                        '        NoClaim.WidthF = 238.2
                        '        NoClaim_Bot.WidthF = 238.2
                        '    Else
                        '        NoClaim.WidthF = 231.84
                        '        NoClaim_Bot.WidthF = 231.84
                        '    End If
                    Case Else

                End Select
                Application.DoEvents()
            Next
            If NoClaim.Visible = False Then
                NoClaim_Top.WidthF = 0
                NoClaim.WidthF = 0
                NoClaim_Bot.WidthF = 0
                TotalWidth += 5
            Else
                NoClaim.WidthF = DynamicWidth
                NoClaim_Top.WidthF = DynamicWidth
                NoClaim.WidthF = DynamicWidth
                NoClaim_Bot.WidthF = DynamicWidth
                TotalWidth += NoClaim_Top.WidthF
            End If

            If No2.Visible = False Then
                No2.WidthF = 0
                No2_Bot.WidthF = 0
                TotalWidth += 5
                TotalQF += 5
            Else
                No2.WidthF = DynamicWidth
                No2_Bot.WidthF = DynamicWidth
                TotalWidth += DynamicWidth
                TotalQF += DynamicWidth
            End If
            If No3.Visible = False Then
                No3.WidthF = 0
                No3_Bot.WidthF = 0
                TotalWidth += 5
                TotalQF += 5
            Else
                No3.WidthF = DynamicWidth
                No3_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
                TotalWidth += DynamicWidth
            End If
            If No8.Visible = False Then
                No8.WidthF = 0
                No8_Bot.WidthF = 0
                TotalWidth += 5
                TotalQF += 5
            Else
                No8.WidthF = DynamicWidth
                No8_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
                TotalWidth += DynamicWidth
            End If
            If No10.Visible = False Then
                No10.WidthF = 0
                No10_Bot.WidthF = 0
                TotalWidth += 5
                TotalQF += 5
            Else
                No10.WidthF = DynamicWidth
                No10_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
                TotalWidth += DynamicWidth
            End If
            If No12.Visible = False Then
                No12.WidthF = 0
                No12_Bot.WidthF = 0
                TotalWidth += 5
                TotalQF += 5

            Else
                No12.WidthF = DynamicWidth
                No12_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
                TotalWidth += DynamicWidth
            End If
            If No14.Visible = False Then
                No14.WidthF = 0
                No14_Bot.WidthF = 0
                TotalWidth += 5
                TotalQF += 5
            Else
                No14.WidthF = DynamicWidth
                No14_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
                TotalWidth += DynamicWidth
            End If
            If No16.Visible = False Then
                No16.WidthF = 0
                No16_Bot.WidthF = 0
                TotalWidth += 5
                TotalQF += 5
            Else
                No16.WidthF = DynamicWidth
                No16_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
                TotalWidth += DynamicWidth
            End If
            If No20.Visible = False Then
                No20.WidthF = 0
                No20_Bot.WidthF = 0
                TotalWidth += 5
                TotalQF += 5
            Else
                No20.WidthF = DynamicWidth
                No20_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
                TotalWidth += DynamicWidth
            End If
            If No40.Visible = False Then
                No40.WidthF = 0
                No40_Bot.WidthF = 0
                TotalWidth += 5
                TotalQF += 5
            Else
                No40.WidthF = DynamicWidth
                No40_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
                TotalWidth += DynamicWidth
            End If
            If No50.Visible = False Then
                No50.WidthF = 0
                No50_Bot.WidthF = 0
                TotalWidth += 5
                TotalQF += 5
            Else
                No50.WidthF = DynamicWidth
                No50_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
                TotalWidth += DynamicWidth
            End If
            If No60.Visible = False Then
                No60.WidthF = 0
                No60_Bot.WidthF = 0
                TotalWidth += 5
                TotalQF += 5
            Else
                No60.WidthF = DynamicWidth
                No60_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
                TotalWidth += DynamicWidth
            End If
            If No80.Visible = False Then
                No80.WidthF = 0
                No80_Bot.WidthF = 0
                TotalWidth += 5
                TotalQF += 5
            Else
                No80.WidthF = DynamicWidth
                No80_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
                TotalWidth += DynamicWidth
            End If
            If No90.Visible = False Then
                No90.WidthF = 0
                No90_Bot.WidthF = 0
                TotalWidth += 5
                TotalQF += 5
            Else
                No90.WidthF = DynamicWidth
                No90_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
                TotalWidth += DynamicWidth
            End If
            If No100.Visible = False Then
                No100.WidthF = 0
                No100_Bot.WidthF = 0
                TotalWidth += 5
                TotalQF += 5
            Else
                No100.WidthF = DynamicWidth
                No100_Bot.WidthF = DynamicWidth
                TotalQF += DynamicWidth
                TotalWidth += DynamicWidth
            End If

            NoHeader_Top.WidthF = TotalQF

            LineDetails.LocationF = New PointF(NoOriCost_Top.LocationF.X, NoOriCost_Top.LocationF.Y + 70)
            LineDetails.SizeF = New SizeF(TotalWidth, 10)

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub table2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles table2.BeforePrint  ', No3.BeforePrint, No8.BeforePrint, No10.BeforePrint, No12.BeforePrint, No14.BeforePrint, No16.BeforePrint, No20.BeforePrint, No40.BeforePrint, No50.BeforePrint, No60.BeforePrint, No8.BeforePrint, No90.BeforePrint, No100.BeforePrint
        Try
            Dim dt As DataTable = Nothing
            dt = ADO.Load_CAReport_ControlTransfer_Temp(paramID.Value)

            If dt Is Nothing Then
                Exit Sub
            End If
            Dim ListofAA As List(Of String) = mdlCA.Get_ListofAA(True)
            Dim tmpStatus As Boolean = False

            Dim TotalWidth As Decimal = 2830
            Dim DynamicWidth As Decimal = 0
            Dim TotalColumn As Integer = 6

            For y As Integer = 0 To ListofAA.Count - 1
                tmpStatus = False
                For x As Integer = 0 To dt.Rows.Count - 1

                    If tmpStatus = False AndAlso IsDBNull(dt.Rows(x)(ListofAA(y))) = False AndAlso dt.Rows(x)(ListofAA(y)) <> 0 Then
                        tmpStatus = True
                        If IsNumeric(ListofAA(y).Replace("AA_", "")) Then
                            Select Case CInt(ListofAA(y).Replace("AA_", ""))
                                Case 0
                                    NoClaim_Details.Visible = True
                                    TotalColumn += 1
                                Case 2
                                    No2_Details.Visible = True
                                    TotalColumn += 1
                                Case 3
                                    No3_Details.Visible = True
                                    TotalColumn += 1
                                Case 8
                                    No8_Details.Visible = True
                                    TotalColumn += 1
                                Case 10
                                    No10_Details.Visible = True
                                    TotalColumn += 1
                                Case 12
                                    No12_Details.Visible = True
                                    TotalColumn += 1
                                Case 14
                                    No14_Details.Visible = True
                                    TotalColumn += 1
                                Case 16
                                    No16_Details.Visible = True
                                    TotalColumn += 1
                                Case 20
                                    No20_Details.Visible = True
                                    TotalColumn += 1
                                Case 40
                                    No40_Details.Visible = True
                                    TotalColumn += 1
                                Case 50
                                    No50_Details.Visible = True
                                    TotalColumn += 1
                                Case 60
                                    No60_Details.Visible = True
                                    TotalColumn += 1
                                Case 80
                                    No80_Details.Visible = True
                                    TotalColumn += 1
                                Case 90
                                    No90_Details.Visible = True
                                    TotalColumn += 1
                                Case 100
                                    No100_Details.Visible = True
                                    TotalColumn += 1
                            End Select
                        End If

                    End If

                Next

            Next

            Dim DynamicColumn As Integer = TotalColumn - 6
            Dim BalanceWidth As Decimal = 0

            If DynamicColumn = 0 AndAlso DynamicColumn <= 10 Then
                DynamicWidth = (TotalWidth - 1611.18) / DynamicColumn
            Else
                DynamicWidth = (TotalWidth - 1205.51) / DynamicColumn
            End If

            If DynamicWidth > 200 Then
                BalanceWidth = (DynamicWidth * DynamicColumn) - (200 * DynamicColumn)
                DynamicWidth = 200
                If DynamicColumn = 1 Then
                    DynamicWidth = 230
                End If
            End If

            For i As Integer = 0 To TotalColumn
                Select Case i
                    Case 0
                        If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                            NoDescription_Details.WidthF = 504.26
                        Else
                            NoDescription_Details.WidthF = 215.23
                        End If
                    Case 1
                        If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                            NoYE_Details.WidthF = 187.04
                        Else
                            NoYE_Details.WidthF = 187.04
                        End If
                    Case 2
                        If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                            NoOriCost_Details.WidthF = 250.35
                        Else
                            NoOriCost_Details.WidthF = 205.37
                        End If
                    Case 3
                        If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                            NoTWDV_Details.WidthF = 226.46
                        Else
                            NoTWDV_Details.WidthF = 190.42
                        End If
                    Case 4
                        If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                            NoTransferVal_Details.WidthF = 226.77
                        Else
                            NoTransferVal_Details.WidthF = 180.75
                        End If
                        'Case 5
                        '    If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                        '        NoClaim_Details.WidthF = 238.2
                        '    Else
                        '        NoClaim_Details.WidthF = 231.84
                        '    End If
                    Case Else

                End Select
                Application.DoEvents()

            Next
            If NoClaim.Visible = False Then
                NoClaim_Details.WidthF = 0
            Else
                NoClaim_Details.WidthF = DynamicWidth
            End If
            If No2.Visible = False Then
                No2_Details.WidthF = 0
            Else
                No2_Details.WidthF = DynamicWidth
            End If
            If No3.Visible = False Then
                No3_Details.WidthF = 0
            Else
                No3_Details.WidthF = DynamicWidth
            End If
            If No8.Visible = False Then
                No8_Details.WidthF = 0
            Else
                No8_Details.WidthF = DynamicWidth
            End If
            If No10.Visible = False Then
                No10_Details.WidthF = 0
            Else
                No10_Details.WidthF = DynamicWidth
            End If
            If No12.Visible = False Then
                No12_Details.WidthF = 0
            Else
                No12_Details.WidthF = DynamicWidth
            End If
            If No14.Visible = False Then
                No14_Details.WidthF = 0
            Else
                No14_Details.WidthF = DynamicWidth
            End If
            If No16.Visible = False Then
                No16_Details.WidthF = 0
            Else
                No16_Details.WidthF = DynamicWidth
            End If
            If No20.Visible = False Then
                No20_Details.WidthF = 0
            Else
                No20_Details.WidthF = DynamicWidth
            End If
            If No40.Visible = False Then
                No40_Details.WidthF = 0
            Else
                No40_Details.WidthF = DynamicWidth
            End If
            If No50.Visible = False Then
                No50_Details.WidthF = 0
            Else
                No50_Details.WidthF = DynamicWidth
            End If
            If No60.Visible = False Then
                No60_Details.WidthF = 0
            Else
                No60_Details.WidthF = DynamicWidth
            End If
            If No80.Visible = False Then
                No80_Details.WidthF = 0
            Else
                No80_Details.WidthF = DynamicWidth
            End If
            If No90.Visible = False Then
                No90_Details.WidthF = 0
            Else
                No90_Details.WidthF = DynamicWidth
            End If
            If No100.Visible = False Then
                No100_Details.WidthF = 0
            Else
                No100_Details.WidthF = DynamicWidth
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub table2_Footer_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles table2_Footer.BeforePrint
        Try
            Dim dt As DataTable = Nothing
            dt = ADO.Load_CAReport_ControlTransfer_Temp(paramID.Value)

            If dt Is Nothing Then
                Exit Sub
            End If

            Dim CA_TRANSFERROR_NAME As String = Me.GetCurrentColumnValue("CA_TRANSFERROR_NAME")
            Dim ID As String = Me.GetCurrentColumnValue("ID")
            Dim YA As String = Me.GetCurrentColumnValue("YA")
            Dim CA_CATEGORY_CODE As String = Me.GetCurrentColumnValue("CA_CATEGORY_CODE")
            Dim Count As Integer = ADO.Load_CAReport_CA_REPORT_CONTROLTRANSFER_TEMP_CountByCATEGORY(ID, YA, CA_CATEGORY_CODE, CA_TRANSFERROR_NAME)

            If Count <= 1 Then
                lineFooter_Top.Visible = False
                lineFooter_Bot.Visible = False
                table2_Footer.Visible = False
                'txtBlank.Visible = True
            Else
                lineFooter_Top.Visible = True
                lineFooter_Bot.Visible = True
                table2_Footer.Visible = True
                'txtBlank.Visible = False

            End If


            Dim ListofAA As List(Of String) = mdlCA.Get_ListofAA(True)

            Dim tmpStatus As Boolean = False

            Dim TotalWidth As Decimal = 2830
            Dim DynamicWidth As Decimal = 0
            Dim TotalColumn As Integer = 6

            For y As Integer = 0 To ListofAA.Count - 1
                tmpStatus = False
                For x As Integer = 0 To dt.Rows.Count - 1

                    If tmpStatus = False AndAlso IsDBNull(dt.Rows(x)(ListofAA(y))) = False AndAlso dt.Rows(x)(ListofAA(y)) <> 0 Then
                        tmpStatus = True
                        If IsNumeric(ListofAA(y).Replace("AA_", "")) Then
                            Select Case CInt(ListofAA(y).Replace("AA_", ""))
                                Case 0
                                    NoClaim_Footer.Visible = True
                                    TotalColumn += 1
                                Case 2
                                    No2_Footer.Visible = True
                                    TotalColumn += 1
                                Case 3
                                    No3_Footer.Visible = True
                                    TotalColumn += 1
                                Case 8
                                    No8_Footer.Visible = True
                                    TotalColumn += 1
                                Case 10
                                    No10_Footer.Visible = True
                                    TotalColumn += 1
                                Case 12
                                    No12_Footer.Visible = True
                                    TotalColumn += 1
                                Case 14
                                    No14_Footer.Visible = True
                                    TotalColumn += 1
                                Case 16
                                    No16_Footer.Visible = True
                                    TotalColumn += 1
                                Case 20
                                    No20_Footer.Visible = True
                                    TotalColumn += 1
                                Case 40
                                    No40_Footer.Visible = True
                                    TotalColumn += 1
                                Case 50
                                    No50_Footer.Visible = True
                                    TotalColumn += 1
                                Case 60
                                    No60_Footer.Visible = True
                                    TotalColumn += 1
                                Case 80
                                    No80_Footer.Visible = True
                                    TotalColumn += 1
                                Case 90
                                    No90_Footer.Visible = True
                                    TotalColumn += 1
                                Case 100
                                    No100_Footer.Visible = True
                                    TotalColumn += 1
                            End Select
                        End If

                    End If

                Next

            Next

            Dim DynamicColumn As Integer = TotalColumn - 6
            Dim BalanceWidth As Decimal = 0

            If DynamicColumn = 0 AndAlso DynamicColumn <= 10 Then
                DynamicWidth = (TotalWidth - 1611.18) / DynamicColumn
            Else
                DynamicWidth = (TotalWidth - 1205.51) / DynamicColumn
            End If

            If DynamicWidth > 200 Then
                BalanceWidth = (DynamicWidth * DynamicColumn) - (200 * DynamicColumn)
                DynamicWidth = 200
                If DynamicColumn = 1 Then
                    DynamicWidth = 230
                End If
            End If

            Dim StartCell As XRTableCell = Nothing
            Dim LasttCell As XRTableCell = Nothing
            Dim isFirst As Boolean = False
            Dim isLast As Boolean = False
            Dim TotalWith As Decimal = 0
            Dim FooterNoteTotal As Decimal = 0

            For i As Integer = 0 To TotalColumn
                Select Case i
                    Case 0
                        If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                            NoDescription_Footer.WidthF = 504.26
                        Else
                            NoDescription_Footer.WidthF = 215.23
                        End If
                    Case 1
                        If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                            NoYE_Footer.WidthF = 187.04
                        Else
                            NoYE_Footer.WidthF = 187.04
                        End If
                    Case 2
                        If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                            NoOriCost_Footer.WidthF = 250.35
                            NoOriCost_NoteFooter.WidthF = 250.35
                        Else
                            NoOriCost_Footer.WidthF = 205.37
                            NoOriCost_NoteFooter.WidthF = 205.37
                        End If
                        TotalWith += NoOriCost_Footer.WidthF
                        FooterNoteTotal += NoOriCost_Footer.WidthF
                    Case 3
                        If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                            NoTWDV_Footer.WidthF = 226.46
                            NoTWDV_NoteFooter.WidthF = 226.46
                        Else
                            NoTWDV_Footer.WidthF = 190.42
                            NoTWDV_NoteFooter.WidthF = 190.42
                        End If
                        TotalWith += NoTWDV_Footer.WidthF
                        FooterNoteTotal += NoTWDV_Footer.WidthF
                    Case 4
                        If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                            NoTransferVal_Footer.WidthF = 226.77
                            NoTransferVal_NoteFooter.WidthF = 226.77
                        Else
                            NoTransferVal_Footer.WidthF = 180.75
                            NoTransferVal_NoteFooter.WidthF = 180.75
                        End If
                        TotalWith += NoTransferVal_Footer.WidthF
                        FooterNoteTotal += NoTransferVal_Footer.WidthF
                        'Case 5
                        '    If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                        '        NoClaim_Footer.WidthF = 238.2
                        '    Else
                        '        NoClaim_Footer.WidthF = 231.84
                        '    End If
                        '    TotalWith += NoClaim_Footer.WidthF
                    Case Else

                End Select
                Application.DoEvents()

            Next
            If NoClaim.Visible = False Then
                NoClaim_Footer.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No2
                End If
                NoClaim_Footer.WidthF = DynamicWidth
                TotalWith += NoClaim_Footer.WidthF
            End If

            If No2.Visible = False Then
                No2_Footer.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No2
                End If
                No2_Footer.WidthF = DynamicWidth
                TotalWith += No2_Footer.WidthF
            End If
            If No3.Visible = False Then
                No3_Footer.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No3
                End If
                No3_Footer.WidthF = DynamicWidth
                TotalWith += No3_Footer.WidthF
            End If
            If No8.Visible = False Then
                No8_Footer.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No8
                End If
                No8_Footer.WidthF = DynamicWidth
                TotalWith += No8_Footer.WidthF
            End If
            If No10.Visible = False Then
                No10_Footer.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No10
                End If
                No10_Footer.WidthF = DynamicWidth
                TotalWith += No10_Footer.WidthF
            End If
            If No12.Visible = False Then
                No12_Footer.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No12
                End If
                No12_Footer.WidthF = DynamicWidth
                TotalWith += No12_Footer.WidthF
            End If
            If No14.Visible = False Then
                No14_Footer.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No14
                End If
                No14_Footer.WidthF = DynamicWidth
                TotalWith += No14_Footer.WidthF
            End If
            If No16.Visible = False Then
                No16_Footer.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No16
                End If
                No16_Footer.WidthF = DynamicWidth
                TotalWith += No16_Footer.WidthF
            End If
            If No20.Visible = False Then
                No20_Footer.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No20
                End If
                No20_Footer.WidthF = DynamicWidth
                TotalWith += No20_Footer.WidthF
            End If
            If No40.Visible = False Then
                No40_Footer.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No40
                End If
                No40_Footer.WidthF = DynamicWidth
                TotalWith += No40_Footer.WidthF
            End If
            If No50.Visible = False Then
                No50_Footer.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No50
                End If
                No50_Footer.WidthF = DynamicWidth
                TotalWith += No50_Footer.WidthF
            End If
            If No60.Visible = False Then
                No60_Footer.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No60
                End If
                No60_Footer.WidthF = DynamicWidth
                TotalWith += No60_Footer.WidthF
            End If
            If No80.Visible = False Then
                No80_Footer.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No80
                End If
                No80_Footer.WidthF = DynamicWidth
                TotalWith += No80_Footer.WidthF
            End If
            If No90.Visible = False Then
                No90_Footer.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No90
                End If
                No90_Footer.WidthF = DynamicWidth
                TotalWith += No90_Footer.WidthF
            End If
            If No100.Visible = False Then
                No100_Footer.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No100
                End If

                No100_Footer.WidthF = DynamicWidth
                TotalWith += No100_Footer.WidthF
            End If

            lineFooter_Top.LocationF = New PointF(NoOriCost_Footer.LocationF.X, NoOriCost_Footer.LocationF.Y)
            lineFooter_Top.SizeF = New SizeF(TotalWith, 1)
            lineFooter_Bot.LocationF = New PointF(NoOriCost_Footer.LocationF.X, NoOriCost_Footer.LocationF.Y + 70)
            lineFooter_Bot.SizeF = New SizeF(TotalWith, 10)


            'dtNoteFooter.LocationF = New PointF(NoOriCost_Footer.LocationF.X, NoOriCost_Footer.LocationF.Y)
            'dtNoteFooter.WidthF = FooterNoteTotal

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub table2_Report_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles table2_Report.BeforePrint  ', No3.BeforePrint, No8.BeforePrint, No10.BeforePrint, No12.BeforePrint, No14.BeforePrint, No16.BeforePrint, No20.BeforePrint, No40.BeforePrint, No50.BeforePrint, No60.BeforePrint, No8.BeforePrint, No90.BeforePrint, No100.BeforePrint
        Try
            Dim dt As DataTable = Nothing
            dt = ADO.Load_CAReport_ControlTransfer_Temp(paramID.Value)

            If dt Is Nothing Then
                Exit Sub
            End If

            Dim ListofAA As List(Of String) = Get_ListofAA(True)

            Dim tmpStatus As Boolean = False

            Dim TotalWidth As Decimal = 2830
            Dim DynamicWidth As Decimal = 0
            Dim TotalColumn As Integer = 6

            For y As Integer = 0 To ListofAA.Count - 1
                tmpStatus = False
                For x As Integer = 0 To dt.Rows.Count - 1

                    If tmpStatus = False AndAlso IsDBNull(dt.Rows(x)(ListofAA(y))) = False AndAlso dt.Rows(x)(ListofAA(y)) <> 0 Then
                        tmpStatus = True
                        If IsNumeric(ListofAA(y).Replace("AA_", "")) Then
                            Select Case CInt(ListofAA(y).Replace("AA_", ""))
                                Case 0
                                    NoClaim_Report.Visible = True
                                    TotalColumn += 1
                                Case 2
                                    No2_Report.Visible = True
                                    TotalColumn += 1
                                Case 3
                                    No3_Report.Visible = True
                                    TotalColumn += 1
                                Case 8
                                    No8_Report.Visible = True
                                    TotalColumn += 1
                                Case 10
                                    No10_Report.Visible = True
                                    TotalColumn += 1
                                Case 12
                                    No12_Report.Visible = True
                                    TotalColumn += 1
                                Case 14
                                    No14_Report.Visible = True
                                    TotalColumn += 1
                                Case 16
                                    No16_Report.Visible = True
                                    TotalColumn += 1
                                Case 20
                                    No20_Report.Visible = True
                                    TotalColumn += 1
                                Case 40
                                    No40_Report.Visible = True
                                    TotalColumn += 1
                                Case 50
                                    No50_Report.Visible = True
                                    TotalColumn += 1
                                Case 60
                                    No60_Report.Visible = True
                                    TotalColumn += 1
                                Case 80
                                    No80_Report.Visible = True
                                    TotalColumn += 1
                                Case 90
                                    No90_Report.Visible = True
                                    TotalColumn += 1
                                Case 100
                                    No100_Report.Visible = True
                                    TotalColumn += 1
                            End Select
                        End If

                    End If

                Next

            Next

            Dim DynamicColumn As Integer = TotalColumn - 6
            Dim BalanceWidth As Decimal = 0

            If DynamicColumn = 0 AndAlso DynamicColumn <= 10 Then
                DynamicWidth = (TotalWidth - 1611.18) / DynamicColumn
            Else
                DynamicWidth = (TotalWidth - 1205.51) / DynamicColumn
            End If

            If DynamicWidth > 200 Then
                BalanceWidth = (DynamicWidth * DynamicColumn) - (200 * DynamicColumn)
                DynamicWidth = 200
                If DynamicColumn = 1 Then
                    DynamicWidth = 230
                End If
            End If

            Dim StartCell As XRTableCell = Nothing
            Dim LasttCell As XRTableCell = Nothing
            Dim isFirst As Boolean = False
            Dim isLast As Boolean = False
            Dim TotalWith As Decimal = 0
            For i As Integer = 0 To TotalColumn
                Select Case i
                    Case 0
                        If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                            NoDescription_Report.WidthF = 504.26
                        Else
                            NoDescription_Report.WidthF = 215.23
                        End If
                    Case 1
                        If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                            NoYE_Report.WidthF = 187.04
                        Else
                            NoYE_Report.WidthF = 187.04
                        End If
                    Case 2
                        If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                            NoOriCost_Report.WidthF = 250.35
                        Else
                            NoOriCost_Report.WidthF = 205.37
                        End If
                        TotalWith += NoOriCost_Report.WidthF
                    Case 3
                        If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                            NoTWDV_Report.WidthF = 226.46
                        Else
                            NoTWDV_Report.WidthF = 190.42
                        End If
                        TotalWith += NoTWDV_Report.WidthF
                    Case 4
                        If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                            NoTransferVal_Report.WidthF = 226.77
                        Else
                            NoTransferVal_Report.WidthF = 180.75
                        End If
                        TotalWith += NoTransferVal_Report.WidthF
                        'Case 5
                        '    If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                        '        NoClaim_Report.WidthF = 238.2
                        '    Else
                        '        NoClaim_Report.WidthF = 231.84
                        '    End If
                        '    TotalWith += NoClaim_Report.WidthF
                    Case Else

                End Select
                Application.DoEvents()

            Next

            If NoClaim.Visible = False Then
                NoClaim_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No2
                End If
                NoClaim_Report.WidthF = DynamicWidth
                TotalWith += NoClaim_Report.WidthF
            End If
            If No2.Visible = False Then
                No2_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No2
                End If
                No2_Report.WidthF = DynamicWidth
                TotalWith += No2_Report.WidthF
            End If
            If No3.Visible = False Then
                No3_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No3
                End If
                No3_Report.WidthF = DynamicWidth
                TotalWith += No3_Report.WidthF
            End If
            If No8.Visible = False Then
                No8_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No8
                End If
                No8_Report.WidthF = DynamicWidth
                TotalWith += No8_Report.WidthF
            End If
            If No10.Visible = False Then
                No10_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No10
                End If
                No10_Report.WidthF = DynamicWidth
                TotalWith += No10_Report.WidthF
            End If
            If No12.Visible = False Then
                No12_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No12
                End If
                No12_Report.WidthF = DynamicWidth
                TotalWith += No12_Report.WidthF
            End If
            If No14.Visible = False Then
                No14_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No14
                End If
                No14_Report.WidthF = DynamicWidth
                TotalWith += No14_Report.WidthF
            End If
            If No16.Visible = False Then
                No16_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No16
                End If
                No16_Report.WidthF = DynamicWidth
                TotalWith += No16_Report.WidthF
            End If
            If No20.Visible = False Then
                No20_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No20
                End If
                No20_Report.WidthF = DynamicWidth
                TotalWith += No20_Report.WidthF
            End If
            If No40.Visible = False Then
                No40_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No40
                End If
                No40_Report.WidthF = DynamicWidth
                TotalWith += No40_Report.WidthF
            End If
            If No50.Visible = False Then
                No50_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No50
                End If
                No50_Report.WidthF = DynamicWidth
                TotalWith += No50_Report.WidthF
            End If
            If No60.Visible = False Then
                No60_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No60
                End If
                No60_Report.WidthF = DynamicWidth
                TotalWith += No60_Report.WidthF
            End If
            If No80.Visible = False Then
                No80_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No80
                End If
                No80_Report.WidthF = DynamicWidth
                TotalWith += No80_Report.WidthF
            End If
            If No90.Visible = False Then
                No90_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No90
                End If
                No90_Report.WidthF = DynamicWidth
                TotalWith += No90_Report.WidthF
            End If
            If No100.Visible = False Then
                No100_Report.WidthF = 0
                TotalWith += 5
            Else
                If isFirst = False Then
                    isFirst = True
                    StartCell = No100
                End If

                No100_Report.WidthF = DynamicWidth
                TotalWith += No100_Report.WidthF
            End If

            lineReport_top.LocationF = New PointF(NoOriCost_Report.LocationF.X, 0)
            lineReport_top.SizeF = New SizeF(TotalWith, 1)
            lineReport_Bot.LocationF = New PointF(NoOriCost_Report.LocationF.X, NoOriCost_Report.LocationF.Y + 74)
            lineReport_Bot.SizeF = New SizeF(TotalWith, 10)


        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub dtNoteFooter_BeforePrint(sender As Object, e As PrintEventArgs) Handles dtNoteFooter.BeforePrint
        Try
            Dim dt As DataTable = Nothing
            dt = ADO.Load_CAReport_ControlTransfer_Temp(paramID.Value)

            If dt Is Nothing Then
                Exit Sub
            End If

            Dim ListofAA As List(Of String) = mdlCA.Get_ListofAA()

            Dim tmpStatus As Boolean = False

            Dim TotalWidth As Decimal = 2830
            Dim DynamicWidth As Decimal = 0
            Dim TotalColumn As Integer = 6

            For y As Integer = 0 To ListofAA.Count - 1
                tmpStatus = False
                For x As Integer = 0 To dt.Rows.Count - 1

                    If tmpStatus = False AndAlso IsDBNull(dt.Rows(x)(ListofAA(y))) = False AndAlso dt.Rows(x)(ListofAA(y)) <> 0 Then
                        tmpStatus = True
                        If IsNumeric(ListofAA(y).Replace("AA_", "")) Then
                            Select Case CInt(ListofAA(y).Replace("AA_", ""))
                                Case 2
                                    No2_Footer.Visible = True
                                    TotalColumn += 1
                                Case 3
                                    No3_Footer.Visible = True
                                    TotalColumn += 1
                                Case 8
                                    No8_Footer.Visible = True
                                    TotalColumn += 1
                                Case 10
                                    No10_Footer.Visible = True
                                    TotalColumn += 1
                                Case 12
                                    No12_Footer.Visible = True
                                    TotalColumn += 1
                                Case 14
                                    No14_Footer.Visible = True
                                    TotalColumn += 1
                                Case 16
                                    No16_Footer.Visible = True
                                    TotalColumn += 1
                                Case 20
                                    No20_Footer.Visible = True
                                    TotalColumn += 1
                                Case 40
                                    No40_Footer.Visible = True
                                    TotalColumn += 1
                                Case 50
                                    No50_Footer.Visible = True
                                    TotalColumn += 1
                                Case 60
                                    No60_Footer.Visible = True
                                    TotalColumn += 1
                                Case 80
                                    No80_Footer.Visible = True
                                    TotalColumn += 1
                                Case 90
                                    No90_Footer.Visible = True
                                    TotalColumn += 1
                                Case 100
                                    No100_Footer.Visible = True
                                    TotalColumn += 1
                            End Select
                        End If

                    End If

                Next

            Next

            Dim DynamicColumn As Integer = TotalColumn - 6
            Dim BalanceWidth As Decimal = 0

            If DynamicColumn = 0 AndAlso DynamicColumn <= 10 Then
                DynamicWidth = (TotalWidth - 1611.18) / DynamicColumn
            Else
                DynamicWidth = (TotalWidth - 1205.51) / DynamicColumn
            End If

            If DynamicWidth > 200 Then
                BalanceWidth = (DynamicWidth * DynamicColumn) - (200 * DynamicColumn)
                DynamicWidth = 200

            End If

            If DynamicColumn >= 0 AndAlso DynamicColumn <= 10 Then
                NoDescription_NoteFooter.WidthF = 691.3
                NoOriCost_NoteFooter.WidthF = 250.35
                NoTWDV_NoteFooter.WidthF = 226.46
                NoTransferVal_NoteFooter.WidthF = 226.77
            Else
                NoDescription_NoteFooter.WidthF = 402.27
                NoOriCost_NoteFooter.WidthF = 205.37
                NoTWDV_NoteFooter.WidthF = 190.42
                NoTransferVal_NoteFooter.WidthF = 180.75
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub XrLabel6_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrLabel6.BeforePrint
        Try
            Dim Val As String = Me.GetCurrentColumnValue("CA_CATEGORY_CODE")
            Dim CA_TRANSFERROR_NAME As String = Me.GetCurrentColumnValue("CA_TRANSFERROR_NAME")
            Dim ID As String = Me.GetCurrentColumnValue("ID")
            Dim YA As String = Me.GetCurrentColumnValue("YA")

            Dim Count As Integer = ADO.Load_CAReport_CA_REPORT_CONTROLTRANSFER_TEMP_CountByCATEGORY(ID, YA, Val, CA_TRANSFERROR_NAME)

            If Count <= 1 Then
                LineDetails.Visible = True
            Else
                LineDetails.Visible = False
                detailBand1.HeightF = 60
            End If


            If Val.ToUpper <> "Capital Expenditure Expensed Off in Income Statement" Then
                XrLabel6.Text = Val.Remove(0, 1)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblDraft_Report_PrintOnPage(sender As Object, e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles lblDraft_Report.PrintOnPage
        Try
            If e.PageIndex = 0 Then
                lblDraft_Report.Visible = True
                tblTitle.LocationF = New PointF(0, 0)
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
            Else
                lblDraft_Page.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblTitle_BeforePrint(sender As Object, e As PrintEventArgs) Handles lblTitle.BeforePrint
        Try
            lblTitle.Text = lblTitle.Text.ToUpper
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblPageNo_PrintOnPage(sender As Object, e As PrintOnPageEventArgs) Handles lblPageNo.PrintOnPage
        Try
            If e.PageCount > 1 Then
                lblPageNo.Visible = True
            Else
                lblPageNo.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub lblPageHeaderGAP_BeforePrint(sender As Object, e As PrintEventArgs)
    '    Try
    '        'If CurrentPage = 0 Then
    '        '    lblPageHeaderGAP.Visible = False
    '        '    lblPageHeaderGAP.HeightF = 1
    '        'Else
    '        '    lblPageHeaderGAP.Visible = True
    '        '    lblPageHeaderGAP.HeightF = 92.6
    '        'End If
    '    Catch ex As Exception

    '    End Try
    'End Sub
    'Private Sub lblPageHeaderGAP_PrintOnPage(sender As Object, e As PrintOnPageEventArgs)
    '    Try
    '        CurrentPage = e.PageIndex

    '        If e.PageIndex = 0 Then
    '            lblPageHeaderGAP.Visible = False
    '            lblPageHeaderGAP.HeightF = 1
    '        Else
    '            lblPageHeaderGAP.Visible = True
    '            lblPageHeaderGAP.HeightF = 92.6
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub



    Private Sub lblPageHeaderGAP_PrintOnPage(sender As Object, e As PrintOnPageEventArgs)

    End Sub
    Private Sub lblPageHeaderGAP_BeforePrint(sender As Object, e As PrintEventArgs)

    End Sub

    'Private Sub XrPanel1_PrintOnPage(sender As Object, e As PrintOnPageEventArgs)
    '    Try
    '        If e.PageIndex = 0 Then
    '            XrLabel3.Visible = False
    '            XrLabel3.Text = ""
    '            PageHeader_Sub1.HeightF = 2
    '        Else
    '            XrLabel3.Visible = True
    '        End If

    '    Catch ex As Exception

    '    End Try
    'End Sub
End Class
