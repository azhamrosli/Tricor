<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptPNL_Details1_RentalExpenses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPNL_Details1_RentalExpenses))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrRichText3 = New DevExpress.XtraReports.UI.XRRichText()
        Me.lblAmount = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblPercentage = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblNote = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrRichText2 = New DevExpress.XtraReports.UI.XRRichText()
        Me.SubBand2 = New DevExpress.XtraReports.UI.SubBand()
        Me.lineup = New DevExpress.XtraReports.UI.XRLine()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblPercentage_RM = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblPercentage_Title = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramSch = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel1010 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
        Me.lblPercentage_Total = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblAmount_Total = New DevExpress.XtraReports.UI.XRLabel()
        Me.lineGrandTotal_PLFST_SALES = New DevExpress.XtraReports.UI.XRLine()
        Me.lineGrandTotal_PLFST_SALES_Top = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DsPNL_Report1 = New EasyTemplate_Taxcom.dsPNL_Report()
        Me.paramYA = New DevExpress.XtraReports.Parameters.Parameter()
        Me.paramCompanyName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.paramKeyName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrRichText4 = New DevExpress.XtraReports.UI.XRRichText()
        Me.lblNote_Details = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblPercentage_Details = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblAmount_Details = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrRichText5 = New DevExpress.XtraReports.UI.XRRichText()
        Me.TotalSourceNo = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.lblGroupTotal_Percent = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblGroupTotal = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.paramID = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.XrRichText3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPNL_Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrRichText3, Me.lblAmount, Me.lblPercentage, Me.lblNote, Me.XrRichText2})
        Me.Detail.HeightF = 23.0!
        Me.Detail.KeepTogether = True
        Me.Detail.KeepTogetherWithDetailReports = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("EXRENT_DESC", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.Detail.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand2})
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrRichText3
        '
        Me.XrRichText3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Rtf", Nothing, "EXPENSES_RENTAL.Address")})
        Me.XrRichText3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrRichText3.LocationFloat = New DevExpress.Utils.PointFloat(251.7823!, 0.0!)
        Me.XrRichText3.Name = "XrRichText3"
        Me.XrRichText3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 5, 100.0!)
        Me.XrRichText3.SerializableRtfString = resources.GetString("XrRichText3.SerializableRtfString")
        Me.XrRichText3.SizeF = New System.Drawing.SizeF(249.3877!, 23.0!)
        Me.XrRichText3.StylePriority.UseFont = False
        Me.XrRichText3.StylePriority.UsePadding = False
        '
        'lblAmount
        '
        Me.lblAmount.CanGrow = False
        Me.lblAmount.CanShrink = True
        Me.lblAmount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "EXPENSES_RENTAL.EXRENT_AMOUNT", "{0:#,# ;(#,#);0 }")})
        Me.lblAmount.LocationFloat = New DevExpress.Utils.PointFloat(501.1702!, 0.0!)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblAmount.SizeF = New System.Drawing.SizeF(89.03998!, 23.0!)
        Me.lblAmount.StylePriority.UseTextAlignment = False
        Me.lblAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'lblPercentage
        '
        Me.lblPercentage.CanGrow = False
        Me.lblPercentage.CanShrink = True
        Me.lblPercentage.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "EXPENSES_RENTAL.PecentageAmount", "{0:#,# ;(#,#); }")})
        Me.lblPercentage.LocationFloat = New DevExpress.Utils.PointFloat(590.21!, 0.0!)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPercentage.SizeF = New System.Drawing.SizeF(89.03986!, 23.0!)
        Me.lblPercentage.StylePriority.UseTextAlignment = False
        Me.lblPercentage.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'lblNote
        '
        Me.lblNote.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "EXPENSES_RENTAL.Note")})
        Me.lblNote.LocationFloat = New DevExpress.Utils.PointFloat(679.2499!, 0.0!)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNote.SizeF = New System.Drawing.SizeF(48.95325!, 23.0!)
        '
        'XrRichText2
        '
        Me.XrRichText2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Rtf", Nothing, "EXPENSES_RENTAL.EXRENT_DESC")})
        Me.XrRichText2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrRichText2.LocationFloat = New DevExpress.Utils.PointFloat(30.04169!, 0.0!)
        Me.XrRichText2.Name = "XrRichText2"
        Me.XrRichText2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 5, 100.0!)
        Me.XrRichText2.SerializableRtfString = resources.GetString("XrRichText2.SerializableRtfString")
        Me.XrRichText2.SizeF = New System.Drawing.SizeF(221.7406!, 23.0!)
        Me.XrRichText2.StylePriority.UseFont = False
        Me.XrRichText2.StylePriority.UsePadding = False
        '
        'SubBand2
        '
        Me.SubBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lineup})
        Me.SubBand2.HeightF = 6.67!
        Me.SubBand2.KeepTogether = True
        Me.SubBand2.Name = "SubBand2"
        '
        'lineup
        '
        Me.lineup.BackColor = System.Drawing.Color.Transparent
        Me.lineup.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lineup.BorderWidth = 1.0!
        Me.lineup.LocationFloat = New DevExpress.Utils.PointFloat(501.165!, 0.0!)
        Me.lineup.Name = "lineup"
        Me.lineup.SizeF = New System.Drawing.SizeF(178.07!, 6.67!)
        Me.lineup.StylePriority.UseBackColor = False
        Me.lineup.StylePriority.UseBorders = False
        Me.lineup.StylePriority.UseBorderWidth = False
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
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel6, Me.lblPercentage_RM, Me.lblPercentage_Title, Me.XrRichText1, Me.XrLabel2, Me.XrLabel1010, Me.XrLabel1, Me.XrLabel4})
        Me.PageHeader.HeightF = 125.8434!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel6
        '
        Me.XrLabel6.CanShrink = True
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(501.1652!, 92.60562!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(89.03986!, 23.00001!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UsePadding = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "RM"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'lblPercentage_RM
        '
        Me.lblPercentage_RM.CanShrink = True
        Me.lblPercentage_RM.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblPercentage_RM.LocationFloat = New DevExpress.Utils.PointFloat(590.205!, 92.60562!)
        Me.lblPercentage_RM.Name = "lblPercentage_RM"
        Me.lblPercentage_RM.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.lblPercentage_RM.SizeF = New System.Drawing.SizeF(89.03986!, 23.00001!)
        Me.lblPercentage_RM.StylePriority.UseFont = False
        Me.lblPercentage_RM.StylePriority.UsePadding = False
        Me.lblPercentage_RM.StylePriority.UseTextAlignment = False
        Me.lblPercentage_RM.Text = "RM"
        Me.lblPercentage_RM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'lblPercentage_Title
        '
        Me.lblPercentage_Title.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblPercentage_Title.LocationFloat = New DevExpress.Utils.PointFloat(590.205!, 56.35748!)
        Me.lblPercentage_Title.Name = "lblPercentage_Title"
        Me.lblPercentage_Title.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPercentage_Title.SizeF = New System.Drawing.SizeF(89.03986!, 36.24814!)
        Me.lblPercentage_Title.StylePriority.UseFont = False
        Me.lblPercentage_Title.StylePriority.UseTextAlignment = False
        Me.lblPercentage_Title.Text = "Add back / (Deduct)"
        Me.lblPercentage_Title.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrRichText1
        '
        Me.XrRichText1.CanShrink = True
        Me.XrRichText1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(30.04169!, 23.0!)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.SizeF = New System.Drawing.SizeF(698.1614!, 23.0!)
        Me.XrRichText1.StylePriority.UseFont = False
        Me.XrRichText1.StylePriority.UsePadding = False
        '
        'XrLabel2
        '
        Me.XrLabel2.CanShrink = True
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramSch, "Text", "")})
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(501.17!, 0.0!)
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
        Me.paramSch.Description = "paramSch"
        Me.paramSch.Name = "paramSch"
        '
        'XrLabel1010
        '
        Me.XrLabel1010.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1010.LocationFloat = New DevExpress.Utils.PointFloat(30.03667!, 56.35748!)
        Me.XrLabel1010.Name = "XrLabel1010"
        Me.XrLabel1010.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.XrLabel1010.SizeF = New System.Drawing.SizeF(221.7406!, 36.24814!)
        Me.XrLabel1010.StylePriority.UseFont = False
        Me.XrLabel1010.StylePriority.UsePadding = False
        Me.XrLabel1010.StylePriority.UseTextAlignment = False
        Me.XrLabel1010.Text = "Details of Recipient(s)"
        Me.XrLabel1010.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(251.7773!, 56.35748!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(249.3877!, 36.24817!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UsePadding = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Address of Premises Rented"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(501.165!, 56.35748!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(89.04001!, 36.24814!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UsePadding = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Amount"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel7})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("EXRENT_SOURCENO", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage
        Me.GroupHeader1.HeightF = 23.0!
        Me.GroupHeader1.KeepTogether = True
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PNL_QUICK_DETAIL.SOURCE_NO", "Source {0}")})
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.KeepTogether = True
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(30.04169!, 0.0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(698.1614!, 23.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UsePadding = False
        Me.XrLabel7.Text = "XrLabel7"
        '
        'ReportFooter
        '
        Me.ReportFooter.HeightF = 0.0!
        Me.ReportFooter.KeepTogether = True
        Me.ReportFooter.Name = "ReportFooter"
        Me.ReportFooter.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand1})
        '
        'SubBand1
        '
        Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblPercentage_Total, Me.lblAmount_Total, Me.lineGrandTotal_PLFST_SALES, Me.lineGrandTotal_PLFST_SALES_Top})
        Me.SubBand1.HeightF = 57.16998!
        Me.SubBand1.Name = "SubBand1"
        '
        'lblPercentage_Total
        '
        Me.lblPercentage_Total.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "EXPENSES_RENTAL.TOTAL_PECENTAGE", "{0:#,# ;(#,#); }")})
        Me.lblPercentage_Total.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentage_Total.LocationFloat = New DevExpress.Utils.PointFloat(590.2048!, 10.00333!)
        Me.lblPercentage_Total.Name = "lblPercentage_Total"
        Me.lblPercentage_Total.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPercentage_Total.SizeF = New System.Drawing.SizeF(89.03986!, 23.0!)
        Me.lblPercentage_Total.StylePriority.UseFont = False
        Me.lblPercentage_Total.StylePriority.UseTextAlignment = False
        Me.lblPercentage_Total.Text = "lblPercentage_Total"
        Me.lblPercentage_Total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lblAmount_Total
        '
        Me.lblAmount_Total.CanShrink = True
        Me.lblAmount_Total.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "EXPENSES_RENTAL.TOTAL_AMOUNT", "{0:#,# ;(#,#);0 }")})
        Me.lblAmount_Total.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount_Total.LocationFloat = New DevExpress.Utils.PointFloat(501.165!, 10.00333!)
        Me.lblAmount_Total.Name = "lblAmount_Total"
        Me.lblAmount_Total.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblAmount_Total.SizeF = New System.Drawing.SizeF(89.03986!, 23.0!)
        Me.lblAmount_Total.StylePriority.UseFont = False
        Me.lblAmount_Total.StylePriority.UseTextAlignment = False
        Me.lblAmount_Total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lineGrandTotal_PLFST_SALES
        '
        Me.lineGrandTotal_PLFST_SALES.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lineGrandTotal_PLFST_SALES.BorderWidth = 1.0!
        Me.lineGrandTotal_PLFST_SALES.LocationFloat = New DevExpress.Utils.PointFloat(501.165!, 33.00335!)
        Me.lineGrandTotal_PLFST_SALES.Name = "lineGrandTotal_PLFST_SALES"
        Me.lineGrandTotal_PLFST_SALES.SizeF = New System.Drawing.SizeF(178.0746!, 6.67!)
        Me.lineGrandTotal_PLFST_SALES.StylePriority.UseBorders = False
        Me.lineGrandTotal_PLFST_SALES.StylePriority.UseBorderWidth = False
        '
        'lineGrandTotal_PLFST_SALES_Top
        '
        Me.lineGrandTotal_PLFST_SALES_Top.BorderWidth = 1.0!
        Me.lineGrandTotal_PLFST_SALES_Top.LocationFloat = New DevExpress.Utils.PointFloat(501.17!, 7.92!)
        Me.lineGrandTotal_PLFST_SALES_Top.Name = "lineGrandTotal_PLFST_SALES_Top"
        Me.lineGrandTotal_PLFST_SALES_Top.SizeF = New System.Drawing.SizeF(89.04431!, 2.083333!)
        Me.lineGrandTotal_PLFST_SALES_Top.StylePriority.UseBorderWidth = False
        Me.lineGrandTotal_PLFST_SALES_Top.Visible = False
        '
        'XrLabel14
        '
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(130.0416!, 0.0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(100.0!, 10.0!)
        '
        'DsPNL_Report1
        '
        Me.DsPNL_Report1.DataSetName = "dsPNL_Report"
        Me.DsPNL_Report1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.paramKeyName.Description = "paramKeyName"
        Me.paramKeyName.Name = "paramKeyName"
        '
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1})
        Me.DetailReport.DataMember = "EXPENSES_RENTAL.FK_EXPENSES_RENTAL_EXPENSES_RENTAL_DETAIL"
        Me.DetailReport.DataSource = Me.DsPNL_Report1
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrRichText4, Me.lblNote_Details, Me.lblPercentage_Details, Me.lblAmount_Details, Me.XrRichText5})
        Me.Detail1.HeightF = 27.16665!
        Me.Detail1.KeepTogether = True
        Me.Detail1.Name = "Detail1"
        Me.Detail1.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("EXRENTD_DESC", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        '
        'XrRichText4
        '
        Me.XrRichText4.CanShrink = True
        Me.XrRichText4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Rtf", Nothing, "EXPENSES_RENTAL.FK_EXPENSES_RENTAL_EXPENSES_RENTAL_DETAIL.EXRENTD_DESC")})
        Me.XrRichText4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrRichText4.LocationFloat = New DevExpress.Utils.PointFloat(30.04169!, 0.0!)
        Me.XrRichText4.Name = "XrRichText4"
        Me.XrRichText4.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 5, 100.0!)
        Me.XrRichText4.SerializableRtfString = resources.GetString("XrRichText4.SerializableRtfString")
        Me.XrRichText4.SizeF = New System.Drawing.SizeF(221.7406!, 23.0!)
        Me.XrRichText4.StylePriority.UseFont = False
        Me.XrRichText4.StylePriority.UsePadding = False
        '
        'lblNote_Details
        '
        Me.lblNote_Details.CanShrink = True
        Me.lblNote_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "EXPENSES_RENTAL.FK_EXPENSES_RENTAL_EXPENSES_RENTAL_DETAIL.Note")})
        Me.lblNote_Details.LocationFloat = New DevExpress.Utils.PointFloat(679.25!, 0.0!)
        Me.lblNote_Details.Name = "lblNote_Details"
        Me.lblNote_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblNote_Details.SizeF = New System.Drawing.SizeF(48.95313!, 23.0!)
        '
        'lblPercentage_Details
        '
        Me.lblPercentage_Details.CanShrink = True
        Me.lblPercentage_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "EXPENSES_RENTAL.FK_EXPENSES_RENTAL_EXPENSES_RENTAL_DETAIL.PecentageAmount", "{0:#,# ;(#,#); }")})
        Me.lblPercentage_Details.LocationFloat = New DevExpress.Utils.PointFloat(590.2101!, 0.0!)
        Me.lblPercentage_Details.Name = "lblPercentage_Details"
        Me.lblPercentage_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblPercentage_Details.SizeF = New System.Drawing.SizeF(89.03986!, 23.0!)
        Me.lblPercentage_Details.StylePriority.UseTextAlignment = False
        Me.lblPercentage_Details.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'lblAmount_Details
        '
        Me.lblAmount_Details.CanShrink = True
        Me.lblAmount_Details.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "EXPENSES_RENTAL.FK_EXPENSES_RENTAL_EXPENSES_RENTAL_DETAIL.EXRENTD_AMOUNT", "{0:#,# ;(#,#);0 }")})
        Me.lblAmount_Details.LocationFloat = New DevExpress.Utils.PointFloat(501.1702!, 0.0!)
        Me.lblAmount_Details.Name = "lblAmount_Details"
        Me.lblAmount_Details.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblAmount_Details.SizeF = New System.Drawing.SizeF(89.03998!, 23.0!)
        Me.lblAmount_Details.StylePriority.UseTextAlignment = False
        Me.lblAmount_Details.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrRichText5
        '
        Me.XrRichText5.CanShrink = True
        Me.XrRichText5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Rtf", Nothing, "EXPENSES_RENTAL.FK_EXPENSES_RENTAL_EXPENSES_RENTAL_DETAIL.Address")})
        Me.XrRichText5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrRichText5.LocationFloat = New DevExpress.Utils.PointFloat(251.7823!, 0.0!)
        Me.XrRichText5.Name = "XrRichText5"
        Me.XrRichText5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 5, 100.0!)
        Me.XrRichText5.SerializableRtfString = resources.GetString("XrRichText5.SerializableRtfString")
        Me.XrRichText5.SizeF = New System.Drawing.SizeF(249.3877!, 23.0!)
        Me.XrRichText5.StylePriority.UseFont = False
        Me.XrRichText5.StylePriority.UsePadding = False
        '
        'TotalSourceNo
        '
        Me.TotalSourceNo.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblGroupTotal_Percent, Me.lblGroupTotal, Me.XrLabel14, Me.XrLabel3})
        Me.TotalSourceNo.HeightF = 32.99999!
        Me.TotalSourceNo.KeepTogether = True
        Me.TotalSourceNo.Name = "TotalSourceNo"
        '
        'lblGroupTotal_Percent
        '
        Me.lblGroupTotal_Percent.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblGroupTotal_Percent.CanShrink = True
        Me.lblGroupTotal_Percent.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "EXPENSES_RENTAL.PecentageAmount", "{0:#,# ;(#,#); }")})
        Me.lblGroupTotal_Percent.KeepTogether = True
        Me.lblGroupTotal_Percent.LocationFloat = New DevExpress.Utils.PointFloat(590.2102!, 0.0!)
        Me.lblGroupTotal_Percent.Name = "lblGroupTotal_Percent"
        Me.lblGroupTotal_Percent.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblGroupTotal_Percent.SizeF = New System.Drawing.SizeF(89.03986!, 23.0!)
        Me.lblGroupTotal_Percent.StylePriority.UseBorders = False
        Me.lblGroupTotal_Percent.StylePriority.UseTextAlignment = False
        Me.lblGroupTotal_Percent.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'lblGroupTotal
        '
        Me.lblGroupTotal.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lblGroupTotal.CanShrink = True
        Me.lblGroupTotal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "EXPENSES_RENTAL.EXRENT_AMOUNT", "{0:#,# ;(#,#);0 }")})
        Me.lblGroupTotal.KeepTogether = True
        Me.lblGroupTotal.LocationFloat = New DevExpress.Utils.PointFloat(501.1702!, 0.0!)
        Me.lblGroupTotal.Name = "lblGroupTotal"
        Me.lblGroupTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblGroupTotal.SizeF = New System.Drawing.SizeF(89.03998!, 23.0!)
        Me.lblGroupTotal.StylePriority.UseBorders = False
        Me.lblGroupTotal.StylePriority.UseTextAlignment = False
        Me.lblGroupTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel3
        '
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(30.04163!, 0.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(100.0!, 10.0!)
        '
        'paramID
        '
        Me.paramID.Description = "paramID"
        Me.paramID.Name = "paramID"
        '
        'rptPNL_Details1_RentalExpenses
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.GroupHeader1, Me.ReportFooter, Me.DetailReport, Me.TotalSourceNo})
        Me.DataMember = "EXPENSES_RENTAL"
        Me.DataSource = Me.DsPNL_Report1
        Me.FilterString = "[KEYNAME] = ?paramKeyName"
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margins = New System.Drawing.Printing.Margins(0, 45, 17, 10)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.paramYA, Me.paramCompanyName, Me.paramKeyName, Me.paramSch, Me.paramID})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "17.1"
        CType(Me.XrRichText3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPNL_Report1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents DsPNL_Report1 As EasyTemplate_Taxcom.dsPNL_Report
    Friend WithEvents paramYA As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents paramCompanyName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents paramKeyName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents paramSch As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents lblNote As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1010 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblPercentage_RM As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblPercentage_Title As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblAmount As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblPercentage As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrRichText2 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrRichText3 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrRichText4 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents lblNote_Details As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblPercentage_Details As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblAmount_Details As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrRichText5 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents lblAmount_Total As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lineGrandTotal_PLFST_SALES As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lineGrandTotal_PLFST_SALES_Top As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents lblPercentage_Total As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SubBand1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents TotalSourceNo As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents paramID As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents lblGroupTotal_Percent As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblGroupTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SubBand2 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents lineup As DevExpress.XtraReports.UI.XRLine
End Class
