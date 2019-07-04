<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptPNL_Details1_Income
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPNL_Details1_Income))
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.lblNote = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblAmount = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblDescription = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.FormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.SubBand2 = New DevExpress.XtraReports.UI.SubBand()
        Me.lineup = New DevExpress.XtraReports.UI.XRLine()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.DsPNL_Report1 = New EasyTemplate_Taxcom.dsPNL_Report()
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblAmount_Details = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblDescription_Details = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
        Me.lineGrandTotal_PLFST_SALES_Top = New DevExpress.XtraReports.UI.XRLine()
        Me.lineGrandTotal_PLFST_SALES = New DevExpress.XtraReports.UI.XRLine()
        Me.lblAmount_Total = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramYA = New DevExpress.XtraReports.Parameters.Parameter()
        Me.paramCompanyName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.paramKeyName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrLabel1010 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramSch = New DevExpress.XtraReports.Parameters.Parameter()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.FormattingRule2 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.Keyname = New DevExpress.XtraReports.UI.FormattingRule()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.TotalSourceNo = New DevExpress.XtraReports.UI.SubBand()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblGroupTotal = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.paramID = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.DsPNL_Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblNote, Me.lblAmount, Me.lblDescription, Me.lblNo})
        Me.Detail.FormattingRules.Add(Me.FormattingRule1)
        Me.Detail.HeightF = 23.0!
        Me.Detail.KeepTogether = True
        Me.Detail.KeepTogetherWithDetailReports = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("DESCRIPTION", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.Detail.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand2})
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblNote
        '
        Me.lblNote.CanShrink = True
        Me.lblNote.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PNL_QUICK_DETAIL.NOTE")})
        Me.lblNote.LocationFloat = New DevExpress.Utils.PointFloat(679.24!, 0.0!)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNote.SizeF = New System.Drawing.SizeF(48.95837!, 23.0!)
        Me.lblNote.StylePriority.UseTextAlignment = False
        Me.lblNote.Text = "lblNote"
        '
        'lblAmount
        '
        Me.lblAmount.CanShrink = True
        Me.lblAmount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PNL_QUICK_DETAIL.AMOUNT", "{0:#,# ;(#,#);0 }")})
        Me.lblAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.LocationFloat = New DevExpress.Utils.PointFloat(501.1717!, 0.0!)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblAmount.SizeF = New System.Drawing.SizeF(89.03741!, 23.0!)
        Me.lblAmount.StylePriority.UseFont = False
        Me.lblAmount.StylePriority.UseTextAlignment = False
        Me.lblAmount.Text = "lblAmount"
        Me.lblAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.CanShrink = True
        Me.lblDescription.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PNL_QUICK_DETAIL.DESCRIPTION")})
        Me.lblDescription.LocationFloat = New DevExpress.Utils.PointFloat(28.04171!, 0.0!)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.lblDescription.SizeF = New System.Drawing.SizeF(473.13!, 23.0!)
        Me.lblDescription.StylePriority.UseBackColor = False
        Me.lblDescription.StylePriority.UsePadding = False
        Me.lblDescription.StylePriority.UseTextAlignment = False
        Me.lblDescription.Text = "lblDescription"
        '
        'lblNo
        '
        Me.lblNo.CanShrink = True
        Me.lblNo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PNL_QUICK_DETAIL.DESCRIPTION")})
        Me.lblNo.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNo.SizeF = New System.Drawing.SizeF(28.04166!, 23.0!)
        Me.lblNo.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0}."
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.lblNo.Summary = XrSummary1
        '
        'FormattingRule1
        '
        Me.FormattingRule1.Condition = "[DataSource.RowCount] == 0"
        Me.FormattingRule1.DataMember = "PNL_QUICK_DETAIL"
        Me.FormattingRule1.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.FormattingRule1.Name = "FormattingRule1"
        '
        'SubBand2
        '
        Me.SubBand2.BackColor = System.Drawing.Color.Transparent
        Me.SubBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lineup})
        Me.SubBand2.HeightF = 5.208333!
        Me.SubBand2.KeepTogether = True
        Me.SubBand2.Name = "SubBand2"
        Me.SubBand2.StylePriority.UseBackColor = False
        '
        'lineup
        '
        Me.lineup.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lineup.LocationFloat = New DevExpress.Utils.PointFloat(501.1653!, 0.0!)
        Me.lineup.Name = "lineup"
        Me.lineup.SizeF = New System.Drawing.SizeF(89.04648!, 5.208333!)
        Me.lineup.StylePriority.UseBorders = False
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 17.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 10.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DsPNL_Report1
        '
        Me.DsPNL_Report1.DataSetName = "dsPNL_Report"
        Me.DsPNL_Report1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1})
        Me.DetailReport.DataMember = "PNL_QUICK_DETAIL.FK_PNL_QUICK_DETAIL_PNL_QUICK_DETAIL_SUB"
        Me.DetailReport.DataSource = Me.DsPNL_Report1
        Me.DetailReport.FormattingRules.Add(Me.FormattingRule1)
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel9, Me.lblAmount_Details, Me.lblDescription_Details})
        Me.Detail1.HeightF = 27.16665!
        Me.Detail1.KeepTogether = True
        Me.Detail1.KeepTogetherWithDetailReports = True
        Me.Detail1.Name = "Detail1"
        Me.Detail1.SnapLinePadding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail1.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("DESCRIPTION", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        '
        'XrLabel9
        '
        Me.XrLabel9.CanShrink = True
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PNL_QUICK_DETAIL.FK_PNL_QUICK_DETAIL_PNL_QUICK_DETAIL_SUB.NOTE")})
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(679.24!, 0.0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(48.95837!, 23.0!)
        Me.XrLabel9.Text = "XrLabel9"
        '
        'lblAmount_Details
        '
        Me.lblAmount_Details.CanShrink = True
        Me.lblAmount_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PNL_QUICK_DETAIL.FK_PNL_QUICK_DETAIL_PNL_QUICK_DETAIL_SUB.AMOUNT", "{0:#,# ;(#,#);0 }")})
        Me.lblAmount_Details.LocationFloat = New DevExpress.Utils.PointFloat(501.1717!, 0.0!)
        Me.lblAmount_Details.Name = "lblAmount_Details"
        Me.lblAmount_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblAmount_Details.SizeF = New System.Drawing.SizeF(89.03741!, 23.0!)
        Me.lblAmount_Details.StylePriority.UseTextAlignment = False
        Me.lblAmount_Details.Text = "lblAmount_Details"
        Me.lblAmount_Details.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'lblDescription_Details
        '
        Me.lblDescription_Details.CanShrink = True
        Me.lblDescription_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PNL_QUICK_DETAIL.FK_PNL_QUICK_DETAIL_PNL_QUICK_DETAIL_SUB.DESCRIPTION", "- {0}")})
        Me.lblDescription_Details.LocationFloat = New DevExpress.Utils.PointFloat(28.04167!, 0.0!)
        Me.lblDescription_Details.Name = "lblDescription_Details"
        Me.lblDescription_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.lblDescription_Details.SizeF = New System.Drawing.SizeF(473.13!, 23.0!)
        Me.lblDescription_Details.StylePriority.UsePadding = False
        Me.lblDescription_Details.Text = "lblDescription_Details"
        '
        'ReportFooter
        '
        Me.ReportFooter.FormattingRules.Add(Me.FormattingRule1)
        Me.ReportFooter.HeightF = 0.0!
        Me.ReportFooter.KeepTogether = True
        Me.ReportFooter.Name = "ReportFooter"
        Me.ReportFooter.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand1})
        '
        'SubBand1
        '
        Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lineGrandTotal_PLFST_SALES_Top, Me.lineGrandTotal_PLFST_SALES, Me.lblAmount_Total})
        Me.SubBand1.HeightF = 57.16998!
        Me.SubBand1.Name = "SubBand1"
        '
        'lineGrandTotal_PLFST_SALES_Top
        '
        Me.lineGrandTotal_PLFST_SALES_Top.BorderWidth = 1.0!
        Me.lineGrandTotal_PLFST_SALES_Top.LocationFloat = New DevExpress.Utils.PointFloat(501.1767!, 7.916697!)
        Me.lineGrandTotal_PLFST_SALES_Top.Name = "lineGrandTotal_PLFST_SALES_Top"
        Me.lineGrandTotal_PLFST_SALES_Top.SizeF = New System.Drawing.SizeF(89.03723!, 2.083333!)
        Me.lineGrandTotal_PLFST_SALES_Top.StylePriority.UseBorderWidth = False
        Me.lineGrandTotal_PLFST_SALES_Top.Visible = False
        '
        'lineGrandTotal_PLFST_SALES
        '
        Me.lineGrandTotal_PLFST_SALES.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lineGrandTotal_PLFST_SALES.BorderWidth = 1.0!
        Me.lineGrandTotal_PLFST_SALES.LocationFloat = New DevExpress.Utils.PointFloat(501.177!, 33.00002!)
        Me.lineGrandTotal_PLFST_SALES.Name = "lineGrandTotal_PLFST_SALES"
        Me.lineGrandTotal_PLFST_SALES.SizeF = New System.Drawing.SizeF(89.03998!, 6.67!)
        Me.lineGrandTotal_PLFST_SALES.StylePriority.UseBorders = False
        Me.lineGrandTotal_PLFST_SALES.StylePriority.UseBorderWidth = False
        '
        'lblAmount_Total
        '
        Me.lblAmount_Total.CanShrink = True
        Me.lblAmount_Total.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PNL_QUICK_DETAIL.TOTAL_AMOUNT", "{0:#,# ;(#,#);0 }")})
        Me.lblAmount_Total.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount_Total.LocationFloat = New DevExpress.Utils.PointFloat(501.177!, 10.00002!)
        Me.lblAmount_Total.Name = "lblAmount_Total"
        Me.lblAmount_Total.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblAmount_Total.SizeF = New System.Drawing.SizeF(89.03735!, 23.0!)
        Me.lblAmount_Total.StylePriority.UseFont = False
        Me.lblAmount_Total.StylePriority.UseTextAlignment = False
        Me.lblAmount_Total.Text = "lblAmount_Total"
        Me.lblAmount_Total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'paramYA
        '
        Me.paramYA.Description = "paramYA"
        Me.paramYA.Name = "paramYA"
        Me.paramYA.Type = GetType(Integer)
        Me.paramYA.ValueInfo = "0"
        '
        'paramCompanyName
        '
        Me.paramCompanyName.Description = "paramCompanyName"
        Me.paramCompanyName.Name = "paramCompanyName"
        '
        'paramKeyName
        '
        Me.paramKeyName.Description = "Parameter1"
        Me.paramKeyName.Name = "paramKeyName"
        '
        'XrRichText1
        '
        Me.XrRichText1.CanShrink = True
        Me.XrRichText1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(28.04171!, 23.0!)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.SizeF = New System.Drawing.SizeF(700.1567!, 23.0!)
        Me.XrRichText1.StylePriority.UseFont = False
        Me.XrRichText1.StylePriority.UsePadding = False
        '
        'XrLabel1010
        '
        Me.XrLabel1010.CanShrink = True
        Me.XrLabel1010.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1010.LocationFloat = New DevExpress.Utils.PointFloat(501.1744!, 62.92!)
        Me.XrLabel1010.Name = "XrLabel1010"
        Me.XrLabel1010.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1010.SizeF = New System.Drawing.SizeF(89.03741!, 23.0!)
        Me.XrLabel1010.StylePriority.UseFont = False
        Me.XrLabel1010.StylePriority.UseTextAlignment = False
        Me.XrLabel1010.Text = "RM"
        Me.XrLabel1010.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel1010, Me.XrRichText1})
        Me.PageHeader.FormattingRules.Add(Me.FormattingRule1)
        Me.PageHeader.HeightF = 85.92!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel2
        '
        Me.XrLabel2.CanShrink = True
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramSch, "Text", "")})
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(501.1653!, 0.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(227.0331!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'paramSch
        '
        Me.paramSch.Description = "Parameter1"
        Me.paramSch.Name = "paramSch"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3})
        Me.GroupHeader1.FormattingRules.Add(Me.FormattingRule1)
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("SOURCE_NO", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage
        Me.GroupHeader1.HeightF = 23.0!
        Me.GroupHeader1.KeepTogether = True
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel3
        '
        Me.XrLabel3.CanShrink = True
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PNL_QUICK_DETAIL.SOURCE_NO", "Source {0}")})
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.KeepTogether = True
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(28.04167!, 0.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(700.1567!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UsePadding = False
        '
        'FormattingRule2
        '
        Me.FormattingRule2.Condition = "[DataSource.RowCount] > 0"
        Me.FormattingRule2.DataMember = "PNL_QUICK_DETAIL"
        Me.FormattingRule2.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.FormattingRule2.Name = "FormattingRule2"
        '
        'Keyname
        '
        Me.Keyname.Condition = resources.GetString("Keyname.Condition")
        Me.Keyname.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.Keyname.Name = "Keyname"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.HeightF = 0.0!
        Me.GroupFooter1.KeepTogether = True
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.TotalSourceNo})
        '
        'TotalSourceNo
        '
        Me.TotalSourceNo.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.lblGroupTotal})
        Me.TotalSourceNo.HeightF = 32.99999!
        Me.TotalSourceNo.KeepTogether = True
        Me.TotalSourceNo.Name = "TotalSourceNo"
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.Maroon
        Me.XrLabel4.CanShrink = True
        Me.XrLabel4.FormattingRules.Add(Me.FormattingRule2)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(288.4675!, 0.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(100.0!, 10.0!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.Visible = False
        '
        'lblGroupTotal
        '
        Me.lblGroupTotal.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblGroupTotal.CanShrink = True
        Me.lblGroupTotal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PNL_QUICK_DETAIL.AMOUNT")})
        Me.lblGroupTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupTotal.KeepTogether = True
        Me.lblGroupTotal.LocationFloat = New DevExpress.Utils.PointFloat(501.1744!, 0.0!)
        Me.lblGroupTotal.Name = "lblGroupTotal"
        Me.lblGroupTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblGroupTotal.SizeF = New System.Drawing.SizeF(89.03741!, 23.0!)
        Me.lblGroupTotal.StylePriority.UseBorders = False
        Me.lblGroupTotal.StylePriority.UseFont = False
        Me.lblGroupTotal.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:#,# ;(#,#);0 }"
        XrSummary2.IgnoreNullValues = True
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.lblGroupTotal.Summary = XrSummary2
        Me.lblGroupTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'GroupFooter2
        '
        Me.GroupFooter2.HeightF = 0.0!
        Me.GroupFooter2.Level = 1
        Me.GroupFooter2.Name = "GroupFooter2"
        Me.GroupFooter2.Visible = False
        '
        'paramID
        '
        Me.paramID.Description = "paramID"
        Me.paramID.Name = "paramID"
        '
        'rptPNL_Details1_Income
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport, Me.ReportFooter, Me.PageHeader, Me.GroupHeader1, Me.GroupFooter1, Me.GroupFooter2})
        Me.DataMember = "PNL_QUICK_DETAIL"
        Me.DataSource = Me.DsPNL_Report1
        Me.FilterString = "[KEYNAME] = ?paramKeyName"
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormattingRules.Add(Me.Keyname)
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.FormattingRule1, Me.FormattingRule2, Me.Keyname})
        Me.Margins = New System.Drawing.Printing.Margins(0, 28, 17, 10)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.paramCompanyName, Me.paramYA, Me.paramKeyName, Me.paramSch, Me.paramID})
        Me.RequestParameters = False
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "17.1"
        Me.Visible = False
        CType(Me.DsPNL_Report1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents DsPNL1 As EasyTemplate_Taxcom.dsPNL
    Friend WithEvents DsPNL_Report1 As EasyTemplate_Taxcom.dsPNL_Report
    Friend WithEvents lblDescription As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblAmount As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblNote As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblAmount_Details As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblDescription_Details As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents lblAmount_Total As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lineGrandTotal_PLFST_SALES_Top As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lineGrandTotal_PLFST_SALES As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents paramCompanyName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents paramYA As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents lblNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrLabel1010 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents paramKeyName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents FormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents FormattingRule2 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents Keyname As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paramSch As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents SubBand1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents SubBand2 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents lineup As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paramID As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents lblGroupTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TotalSourceNo As DevExpress.XtraReports.UI.SubBand
End Class
