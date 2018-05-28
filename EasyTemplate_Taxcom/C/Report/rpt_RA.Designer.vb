<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rpt_RA
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.DsRA_ITA1 = New EasyTemplate_Taxcom.dsRA_ITA()
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.lbl_Adjustment_Amount = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeader3 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.lbl_TC_CB_RA_CURR = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SUM_ADJUSTMENT = New DevExpress.XtraReports.UI.CalculatedField()
        Me.DetailReport1 = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail2 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeader1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DetailReport2 = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail3 = New DevExpress.XtraReports.UI.DetailBand()
        Me.lbl_WithDrawal_Amount = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.IFWithDrawalYES = New DevExpress.XtraReports.UI.FormattingRule()
        Me.ReportHeader2 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.lbl_TC_CB_RA_BAL_BF = New DevExpress.XtraReports.UI.XRLabel()
        Me.IFWithDrawalNO = New DevExpress.XtraReports.UI.FormattingRule()
        Me.lbl_TC_CB_RA_BAL_BF2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblTC_RA_QUA_AMOUNT = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter1 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SubBand2 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.CalcRA_Less_Withdrawal = New DevExpress.XtraReports.UI.CalculatedField()
        Me.CalcRA_Plus_Withdrawal = New DevExpress.XtraReports.UI.CalculatedField()
        Me.ReportFooter3 = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SUM_WITHDRAWAL = New DevExpress.XtraReports.UI.CalculatedField()
        Me.TOTAL = New DevExpress.XtraReports.UI.CalculatedField()
        Me.paramSch = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.DsRA_ITA1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 0.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 20.83333!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 100.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 35.75001!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(223.9583!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Reinvestment Allowance (RA)"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel8, Me.XrLabel7, Me.XrLabel3, Me.XrLabel1})
        Me.PageHeader.HeightF = 68.75!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(501.0833!, 45.74998!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "RM"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(601.0834!, 45.74998!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "RM"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramSch, "Text", "")})
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(648.9586!, 10.00001!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(126.0416!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Schedule "
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(648.9587!, 10.00001!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(126.0415!, 23.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "DRAFT"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4})
        Me.ReportHeader.HeightF = 41.66667!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'DsRA_ITA1
        '
        Me.DsRA_ITA1.DataSetName = "dsRA_ITA"
        Me.DsRA_ITA1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.ReportHeader3})
        Me.DetailReport.DataMember = "TAX_COMPUTATION.FK_TAX_COMPUTATION_TAX_RA_ADJUSTMENT"
        Me.DetailReport.DataSource = Me.DsRA_ITA1
        Me.DetailReport.Level = 2
        Me.DetailReport.Name = "DetailReport"
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbl_Adjustment_Amount, Me.XrLabel2})
        Me.Detail1.HeightF = 23.0!
        Me.Detail1.Name = "Detail1"
        '
        'lbl_Adjustment_Amount
        '
        Me.lbl_Adjustment_Amount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TAX_COMPUTATION.FK_TAX_COMPUTATION_TAX_RA_ADJUSTMENT.RAADJ_AMOUNT", "{0:n0}")})
        Me.lbl_Adjustment_Amount.LocationFloat = New DevExpress.Utils.PointFloat(601.0834!, 0.0!)
        Me.lbl_Adjustment_Amount.Name = "lbl_Adjustment_Amount"
        Me.lbl_Adjustment_Amount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbl_Adjustment_Amount.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.lbl_Adjustment_Amount.StylePriority.UseTextAlignment = False
        Me.lbl_Adjustment_Amount.Text = "lbl_Adjustment_Amount"
        Me.lbl_Adjustment_Amount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TAX_COMPUTATION.FK_TAX_COMPUTATION_TAX_RA_ADJUSTMENT.RAADJ_ITEM", "Add: {0}")})
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(34.41668!, 0.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(416.2083!, 23.0!)
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportHeader3
        '
        Me.ReportHeader3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbl_TC_CB_RA_CURR, Me.XrLabel11})
        Me.ReportHeader3.HeightF = 56.95832!
        Me.ReportHeader3.Name = "ReportHeader3"
        '
        'lbl_TC_CB_RA_CURR
        '
        Me.lbl_TC_CB_RA_CURR.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TAX_COMPUTATION.TC_CB_RA_CURR", "({0:n0})")})
        Me.lbl_TC_CB_RA_CURR.LocationFloat = New DevExpress.Utils.PointFloat(601.0834!, 23.95833!)
        Me.lbl_TC_CB_RA_CURR.Name = "lbl_TC_CB_RA_CURR"
        Me.lbl_TC_CB_RA_CURR.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbl_TC_CB_RA_CURR.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.lbl_TC_CB_RA_CURR.StylePriority.UseTextAlignment = False
        Me.lbl_TC_CB_RA_CURR.Text = "lbl_TC_CB_RA_CURR"
        Me.lbl_TC_CB_RA_CURR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel11
        '
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 9.999974!)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(317.7083!, 46.95835!)
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Less: RA claimed during the year" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(restricted to 70% of statutory business income" & _
    ")"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'SUM_ADJUSTMENT
        '
        Me.SUM_ADJUSTMENT.DataMember = "TAX_COMPUTATION.FK_TAX_COMPUTATION_TAX_RA_ADJUSTMENT"
        Me.SUM_ADJUSTMENT.Expression = "SUM([RAADJ_AMOUNT])"
        Me.SUM_ADJUSTMENT.Name = "SUM_ADJUSTMENT"
        '
        'DetailReport1
        '
        Me.DetailReport1.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail2, Me.ReportHeader1, Me.ReportFooter})
        Me.DetailReport1.DataMember = "TAX_COMPUTATION.TAX_COMPUTATION_CA"
        Me.DetailReport1.DataSource = Me.DsRA_ITA1
        Me.DetailReport1.Level = 0
        Me.DetailReport1.Name = "DetailReport1"
        '
        'Detail2
        '
        Me.Detail2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel9, Me.XrLabel6})
        Me.Detail2.HeightF = 23.0!
        Me.Detail2.Name = "Detail2"
        '
        'XrLabel9
        '
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TAX_COMPUTATION.TAX_COMPUTATION_CA.CA_QUALIFYING_COST")})
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(601.0834!, 0.0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "XrLabel9"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel6
        '
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TAX_COMPUTATION.TAX_COMPUTATION_CA.CA_ASSET")})
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0.0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(477.0833!, 23.0!)
        Me.XrLabel6.Text = "XrLabel6"
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10})
        Me.ReportHeader1.HeightF = 41.66667!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00001!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(223.9583!, 23.0!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Qualifying Capital Expenditure"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrLine1, Me.XrLabel13})
        Me.ReportFooter.HeightF = 50.0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLine2
        '
        Me.XrLine2.LineWidth = 2
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(601.0834!, 32.99993!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(100.0!, 7.000099!)
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(601.0834!, 2.083333!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(100.0!, 5.208333!)
        '
        'XrLabel13
        '
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TAX_COMPUTATION.TAX_COMPUTATION_CA.CA_QUALIFYING_COST")})
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(601.0834!, 9.999974!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:n0}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel13.Summary = XrSummary1
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'DetailReport2
        '
        Me.DetailReport2.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail3, Me.ReportHeader2, Me.ReportFooter1})
        Me.DetailReport2.DataMember = "TAX_COMPUTATION.FK_TAX_COMPUTATION_TAX_RA_WITHDRAWAL"
        Me.DetailReport2.DataSource = Me.DsRA_ITA1
        Me.DetailReport2.Level = 1
        Me.DetailReport2.Name = "DetailReport2"
        '
        'Detail3
        '
        Me.Detail3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbl_WithDrawal_Amount, Me.XrLabel18})
        Me.Detail3.FormattingRules.Add(Me.IFWithDrawalYES)
        Me.Detail3.HeightF = 24.04162!
        Me.Detail3.Name = "Detail3"
        '
        'lbl_WithDrawal_Amount
        '
        Me.lbl_WithDrawal_Amount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TAX_COMPUTATION.FK_TAX_COMPUTATION_TAX_RA_WITHDRAWAL.RAW_AMOUNT", "({0:n0})")})
        Me.lbl_WithDrawal_Amount.LocationFloat = New DevExpress.Utils.PointFloat(501.0833!, 0.0!)
        Me.lbl_WithDrawal_Amount.Name = "lbl_WithDrawal_Amount"
        Me.lbl_WithDrawal_Amount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbl_WithDrawal_Amount.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.lbl_WithDrawal_Amount.StylePriority.UseTextAlignment = False
        Me.lbl_WithDrawal_Amount.Text = "lbl_WithDrawal_Amount"
        Me.lbl_WithDrawal_Amount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel18
        '
        Me.XrLabel18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TAX_COMPUTATION.FK_TAX_COMPUTATION_TAX_RA_WITHDRAWAL.RAW_ITEM", "Less : {0}")})
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(34.41665!, 0.0!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(416.2083!, 23.0!)
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "XrLabel18"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'IFWithDrawalYES
        '
        Me.IFWithDrawalYES.Condition = "[DataSource.RowCount] =0"
        Me.IFWithDrawalYES.DataMember = "TAX_COMPUTATION.FK_TAX_COMPUTATION_TAX_RA_WITHDRAWAL"
        Me.IFWithDrawalYES.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.IFWithDrawalYES.Name = "IFWithDrawalYES"
        '
        'ReportHeader2
        '
        Me.ReportHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbl_TC_CB_RA_BAL_BF, Me.lbl_TC_CB_RA_BAL_BF2, Me.XrLabel16, Me.lblTC_RA_QUA_AMOUNT, Me.XrLabel14})
        Me.ReportHeader2.HeightF = 64.58335!
        Me.ReportHeader2.Name = "ReportHeader2"
        '
        'lbl_TC_CB_RA_BAL_BF
        '
        Me.lbl_TC_CB_RA_BAL_BF.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TAX_COMPUTATION.TC_CB_RA_BAL_BF", "{0:n0}")})
        Me.lbl_TC_CB_RA_BAL_BF.FormattingRules.Add(Me.IFWithDrawalNO)
        Me.lbl_TC_CB_RA_BAL_BF.LocationFloat = New DevExpress.Utils.PointFloat(601.0834!, 41.58335!)
        Me.lbl_TC_CB_RA_BAL_BF.Name = "lbl_TC_CB_RA_BAL_BF"
        Me.lbl_TC_CB_RA_BAL_BF.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbl_TC_CB_RA_BAL_BF.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.lbl_TC_CB_RA_BAL_BF.StylePriority.UseTextAlignment = False
        Me.lbl_TC_CB_RA_BAL_BF.Text = "XrLabel17"
        Me.lbl_TC_CB_RA_BAL_BF.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'IFWithDrawalNO
        '
        Me.IFWithDrawalNO.Condition = "[DataSource.RowCount] <> 0"
        Me.IFWithDrawalNO.DataMember = "TAX_COMPUTATION.FK_TAX_COMPUTATION_TAX_RA_WITHDRAWAL"
        Me.IFWithDrawalNO.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.IFWithDrawalNO.Name = "IFWithDrawalNO"
        '
        'lbl_TC_CB_RA_BAL_BF2
        '
        Me.lbl_TC_CB_RA_BAL_BF2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TAX_COMPUTATION.TC_CB_RA_BAL_BF", "{0:n0}")})
        Me.lbl_TC_CB_RA_BAL_BF2.FormattingRules.Add(Me.IFWithDrawalYES)
        Me.lbl_TC_CB_RA_BAL_BF2.LocationFloat = New DevExpress.Utils.PointFloat(501.0833!, 41.58335!)
        Me.lbl_TC_CB_RA_BAL_BF2.Name = "lbl_TC_CB_RA_BAL_BF2"
        Me.lbl_TC_CB_RA_BAL_BF2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbl_TC_CB_RA_BAL_BF2.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.lbl_TC_CB_RA_BAL_BF2.StylePriority.UseTextAlignment = False
        Me.lbl_TC_CB_RA_BAL_BF2.Text = "lbl_TC_CB_RA_BAL_BF2"
        Me.lbl_TC_CB_RA_BAL_BF2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel16
        '
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 41.58335!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(223.9583!, 23.0!)
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Add: Unutilised RA b/f"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lblTC_RA_QUA_AMOUNT
        '
        Me.lblTC_RA_QUA_AMOUNT.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TAX_COMPUTATION.TC_ITA_QUALIFYINGCAPITALEXP_AMOUNT", "{0:n0}")})
        Me.lblTC_RA_QUA_AMOUNT.LocationFloat = New DevExpress.Utils.PointFloat(601.0834!, 0.0!)
        Me.lblTC_RA_QUA_AMOUNT.Name = "lblTC_RA_QUA_AMOUNT"
        Me.lblTC_RA_QUA_AMOUNT.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblTC_RA_QUA_AMOUNT.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.lblTC_RA_QUA_AMOUNT.StylePriority.UseTextAlignment = False
        Me.lblTC_RA_QUA_AMOUNT.Text = "lblTC_RA_QUA_AMOUNT"
        Me.lblTC_RA_QUA_AMOUNT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel14
        '
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TAX_COMPUTATION.TC_RA_RATE1", "RA @ {0}%")})
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0.0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(223.9583!, 23.0!)
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportFooter1
        '
        Me.ReportFooter1.HeightF = 0.0!
        Me.ReportFooter1.Name = "ReportFooter1"
        Me.ReportFooter1.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand1, Me.SubBand2})
        '
        'SubBand1
        '
        Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel20})
        Me.SubBand1.FormattingRules.Add(Me.IFWithDrawalYES)
        Me.SubBand1.HeightF = 23.0!
        Me.SubBand1.Name = "SubBand1"
        '
        'XrLabel20
        '
        Me.XrLabel20.CanShrink = True
        Me.XrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TAX_COMPUTATION.CalcRA_Less_Withdrawal", "{0:#,# ;(#,#);0; }")})
        Me.XrLabel20.FormattingRules.Add(Me.IFWithDrawalYES)
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(601.0834!, 0.0!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "XrLabel20"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'SubBand2
        '
        Me.SubBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine3, Me.XrLabel21})
        Me.SubBand2.HeightF = 57.29167!
        Me.SubBand2.Name = "SubBand2"
        '
        'XrLine3
        '
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(601.0834!, 4.791673!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(100.0!, 5.208333!)
        '
        'XrLabel21
        '
        Me.XrLabel21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TAX_COMPUTATION.CalcRA_Plus_Withdrawal", "{0:#,# ;(#,#);0; }")})
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(601.0834!, 10.00001!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'CalcRA_Less_Withdrawal
        '
        Me.CalcRA_Less_Withdrawal.DataMember = "TAX_COMPUTATION"
        Me.CalcRA_Less_Withdrawal.Expression = "ToDecimal([TC_CB_RA_BAL_BF] )- [FK_TAX_COMPUTATION_TAX_RA_WITHDRAWAL.SUM_WITHDRAW" & _
    "AL]"
        Me.CalcRA_Less_Withdrawal.Name = "CalcRA_Less_Withdrawal"
        '
        'CalcRA_Plus_Withdrawal
        '
        Me.CalcRA_Plus_Withdrawal.DataMember = "TAX_COMPUTATION"
        Me.CalcRA_Plus_Withdrawal.Name = "CalcRA_Plus_Withdrawal"
        '
        'ReportFooter3
        '
        Me.ReportFooter3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5, Me.XrLine5, Me.XrLine4, Me.XrLabel22})
        Me.ReportFooter3.HeightF = 100.1251!
        Me.ReportFooter3.Name = "ReportFooter3"
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TAX_COMPUTATION.TOTAL", "{0:#,# ;(#,#);0; }")})
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(601.0834!, 10.00004!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "XrLabel5"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLine5
        '
        Me.XrLine5.LocationFloat = New DevExpress.Utils.PointFloat(601.0834!, 4.791641!)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.SizeF = New System.Drawing.SizeF(100.0!, 5.208333!)
        '
        'XrLine4
        '
        Me.XrLine4.LineWidth = 2
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(601.0834!, 33.00002!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.SizeF = New System.Drawing.SizeF(100.0!, 7.000099!)
        '
        'XrLabel22
        '
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(9.999974!, 10.0!)
        Me.XrLabel22.Multiline = True
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(440.625!, 19.87502!)
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "Unutilised RA c/f to year of assessment [TC_YA]"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'SUM_WITHDRAWAL
        '
        Me.SUM_WITHDRAWAL.DataMember = "TAX_COMPUTATION.FK_TAX_COMPUTATION_TAX_RA_WITHDRAWAL"
        Me.SUM_WITHDRAWAL.Expression = "Sum([RAW_AMOUNT])"
        Me.SUM_WITHDRAWAL.Name = "SUM_WITHDRAWAL"
        '
        'TOTAL
        '
        Me.TOTAL.DataMember = "TAX_COMPUTATION"
        Me.TOTAL.Name = "TOTAL"
        '
        'paramSch
        '
        Me.paramSch.Description = "paramSch"
        Me.paramSch.Name = "paramSch"
        Me.paramSch.ValueInfo = "Schedule"
        '
        'rpt_RA
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.ReportHeader, Me.DetailReport, Me.DetailReport1, Me.DetailReport2, Me.ReportFooter3})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.SUM_ADJUSTMENT, Me.CalcRA_Less_Withdrawal, Me.CalcRA_Plus_Withdrawal, Me.SUM_WITHDRAWAL, Me.TOTAL})
        Me.DataMember = "TAX_COMPUTATION"
        Me.DataSource = Me.DsRA_ITA1
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.IFWithDrawalYES, Me.IFWithDrawalNO})
        Me.Margins = New System.Drawing.Printing.Margins(26, 39, 21, 100)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.paramSch})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "17.1"
        CType(Me.DsRA_ITA1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DsRA_ITA1 As EasyTemplate_Taxcom.dsRA_ITA
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents lbl_Adjustment_Amount As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SUM_ADJUSTMENT As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents DetailReport1 As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail2 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeader1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DetailReport2 As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail3 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents lbl_WithDrawal_Amount As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeader2 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents lbl_TC_CB_RA_BAL_BF2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblTC_RA_QUA_AMOUNT As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter1 As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CalcRA_Less_Withdrawal As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents CalcRA_Plus_Withdrawal As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents ReportHeader3 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents lbl_TC_CB_RA_CURR As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter3 As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SUM_WITHDRAWAL As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents IFWithDrawalYES As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents lbl_TC_CB_RA_BAL_BF As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents IFWithDrawalNO As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents SubBand1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents SubBand2 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TOTAL As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents paramSch As DevExpress.XtraReports.Parameters.Parameter
End Class
