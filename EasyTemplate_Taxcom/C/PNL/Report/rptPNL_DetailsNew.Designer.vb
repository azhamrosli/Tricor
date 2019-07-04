<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptPNL_DetailsNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPNL_DetailsNew))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.SubBand1 = New DevExpress.XtraReports.UI.SubBand()
        Me.paramCompanyName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.paramYA = New DevExpress.XtraReports.Parameters.Parameter()
        Me.paramID = New DevExpress.XtraReports.Parameters.Parameter()
        Me.SubBand2 = New DevExpress.XtraReports.UI.SubBand()
        Me.SubBand3 = New DevExpress.XtraReports.UI.SubBand()
        Me.SubBand4 = New DevExpress.XtraReports.UI.SubBand()
        Me.SubBand5 = New DevExpress.XtraReports.UI.SubBand()
        Me.SubBand6 = New DevExpress.XtraReports.UI.SubBand()
        Me.SubBand7 = New DevExpress.XtraReports.UI.SubBand()
        Me.SubBand8 = New DevExpress.XtraReports.UI.SubBand()
        Me.SubPNLInfo_KEYName = New DevExpress.XtraReports.UI.XRLabel()
        Me.KeyNameType = New DevExpress.XtraReports.UI.FormattingRule()
        Me.KeyNameType2 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.Exclude = New DevExpress.XtraReports.UI.FormattingRule()
        Me.FormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.DsPNL_Report1 = New EasyTemplate_Taxcom.dsPNL_Report()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.lblDraft_Report = New DevExpress.XtraReports.UI.XRLabel()
        Me.ShowDraft = New DevExpress.XtraReports.UI.FormattingRule()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.lblDraft_Page = New DevExpress.XtraReports.UI.XRLabel()
        Me.param_ShowDraft = New DevExpress.XtraReports.Parameters.Parameter()
        Me.SubrptPNL_Details1_Income = New DevExpress.XtraReports.UI.XRSubreport()
        Me.SubrptPNL_Details1_Expenses = New DevExpress.XtraReports.UI.XRSubreport()
        Me.SubrptPNL_Details_DividendIncome = New DevExpress.XtraReports.UI.XRSubreport()
        Me.SubrptPNL_Details1_RentalIncome = New DevExpress.XtraReports.UI.XRSubreport()
        Me.SubrptPNL_Details1_ExemptDividend = New DevExpress.XtraReports.UI.XRSubreport()
        Me.SubrptPNL_Details1_RentalExpenses = New DevExpress.XtraReports.UI.XRSubreport()
        Me.SubrptPNL_NoteNew = New DevExpress.XtraReports.UI.XRSubreport()
        CType(Me.DsPNL_Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 0.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand1, Me.SubBand2, Me.SubBand3, Me.SubBand4, Me.SubBand5, Me.SubBand6, Me.SubBand7, Me.SubBand8})
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'SubBand1
        '
        Me.SubBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.SubrptPNL_Details1_Income})
        Me.SubBand1.Dpi = 254.0!
        Me.SubBand1.HeightF = 60.85416!
        Me.SubBand1.KeepTogether = True
        Me.SubBand1.Name = "SubBand1"
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
        'paramID
        '
        Me.paramID.Description = "paramID"
        Me.paramID.Name = "paramID"
        '
        'SubBand2
        '
        Me.SubBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.SubrptPNL_Details1_Expenses})
        Me.SubBand2.Dpi = 254.0!
        Me.SubBand2.HeightF = 55.5625!
        Me.SubBand2.KeepTogether = True
        Me.SubBand2.Name = "SubBand2"
        '
        'SubBand3
        '
        Me.SubBand3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.SubrptPNL_Details_DividendIncome})
        Me.SubBand3.Dpi = 254.0!
        Me.SubBand3.HeightF = 58.42!
        Me.SubBand3.KeepTogether = True
        Me.SubBand3.Name = "SubBand3"
        '
        'SubBand4
        '
        Me.SubBand4.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.SubrptPNL_Details1_RentalIncome})
        Me.SubBand4.Dpi = 254.0!
        Me.SubBand4.HeightF = 58.42!
        Me.SubBand4.KeepTogether = True
        Me.SubBand4.Name = "SubBand4"
        '
        'SubBand5
        '
        Me.SubBand5.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.SubrptPNL_Details1_ExemptDividend})
        Me.SubBand5.Dpi = 254.0!
        Me.SubBand5.HeightF = 58.42!
        Me.SubBand5.KeepTogether = True
        Me.SubBand5.Name = "SubBand5"
        '
        'SubBand6
        '
        Me.SubBand6.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.SubrptPNL_Details1_RentalExpenses})
        Me.SubBand6.Dpi = 254.0!
        Me.SubBand6.HeightF = 58.42!
        Me.SubBand6.KeepTogether = True
        Me.SubBand6.Name = "SubBand6"
        '
        'SubBand7
        '
        Me.SubBand7.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.SubrptPNL_NoteNew})
        Me.SubBand7.Dpi = 254.0!
        Me.SubBand7.HeightF = 58.42!
        Me.SubBand7.KeepTogether = True
        Me.SubBand7.Name = "SubBand7"
        '
        'SubBand8
        '
        Me.SubBand8.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.SubPNLInfo_KEYName})
        Me.SubBand8.Dpi = 254.0!
        Me.SubBand8.HeightF = 63.71171!
        Me.SubBand8.KeepTogether = True
        Me.SubBand8.Name = "SubBand8"
        '
        'SubPNLInfo_KEYName
        '
        Me.SubPNLInfo_KEYName.BackColor = System.Drawing.Color.Transparent
        Me.SubPNLInfo_KEYName.CanGrow = False
        Me.SubPNLInfo_KEYName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PNL_TABLE_INFO.KeyName", " ")})
        Me.SubPNLInfo_KEYName.Dpi = 254.0!
        Me.SubPNLInfo_KEYName.KeepTogether = True
        Me.SubPNLInfo_KEYName.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.SubPNLInfo_KEYName.Name = "SubPNLInfo_KEYName"
        Me.SubPNLInfo_KEYName.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.SubPNLInfo_KEYName.SizeF = New System.Drawing.SizeF(1849.0!, 63.71171!)
        Me.SubPNLInfo_KEYName.StylePriority.UseBackColor = False
        '
        'KeyNameType
        '
        Me.KeyNameType.Condition = resources.GetString("KeyNameType.Condition")
        Me.KeyNameType.DataMember = "PNL_QUICK_DETAIL"
        Me.KeyNameType.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.KeyNameType.Name = "KeyNameType"
        '
        'KeyNameType2
        '
        Me.KeyNameType2.Condition = resources.GetString("KeyNameType2.Condition")
        Me.KeyNameType2.DataMember = "PNL_QUICK_DETAIL"
        Me.KeyNameType2.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.KeyNameType2.Name = "KeyNameType2"
        '
        'Exclude
        '
        Me.Exclude.Condition = resources.GetString("Exclude.Condition")
        Me.Exclude.DataMember = "PNL_TABLE_INFO"
        Me.Exclude.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.Exclude.Name = "Exclude"
        '
        'FormattingRule1
        '
        Me.FormattingRule1.Condition = "[DataSource.RowCount] > 0"
        Me.FormattingRule1.DataMember = "PNL_QUICK_DETAIL"
        Me.FormattingRule1.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.FormattingRule1.Name = "FormattingRule1"
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 97.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 79.07996!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DsPNL_Report1
        '
        Me.DsPNL_Report1.DataSetName = "dsPNL_Report"
        Me.DsPNL_Report1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblDraft_Report, Me.XrLabel2, Me.XrLabel1, Me.XrLabel3})
        Me.ReportHeader.Dpi = 254.0!
        Me.ReportHeader.HeightF = 328.1875!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'lblDraft_Report
        '
        Me.lblDraft_Report.CanShrink = True
        Me.lblDraft_Report.Dpi = 254.0!
        Me.lblDraft_Report.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDraft_Report.FormattingRules.Add(Me.ShowDraft)
        Me.lblDraft_Report.LocationFloat = New DevExpress.Utils.PointFloat(1531.661!, 0.0!)
        Me.lblDraft_Report.Name = "lblDraft_Report"
        Me.lblDraft_Report.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblDraft_Report.SizeF = New System.Drawing.SizeF(317.3389!, 58.42!)
        Me.lblDraft_Report.StylePriority.UseFont = False
        Me.lblDraft_Report.StylePriority.UseTextAlignment = False
        Me.lblDraft_Report.Text = "DRAFT"
        Me.lblDraft_Report.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblDraft_Report.Visible = False
        '
        'ShowDraft
        '
        Me.ShowDraft.Condition = "[Parameters.param_ShowDraft] = true"
        Me.ShowDraft.Formatting.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.ShowDraft.Name = "ShowDraft"
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramYA, "Text", "Tax Computation - Year Assessment {0}")})
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0003229777!, 172.1909!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(1849.0!, 58.42!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.paramCompanyName, "Text", "")})
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0003229777!, 113.7708!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(1849.0!, 58.42!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.0003229777!, 230.6108!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(1849.0!, 58.42!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Particulars of Accounts"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'PageFooter
        '
        Me.PageFooter.Dpi = 254.0!
        Me.PageFooter.HeightF = 58.42!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.StylePriority.UseBackColor = False
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblDraft_Page})
        Me.PageHeader.Dpi = 254.0!
        Me.PageHeader.HeightF = 116.6284!
        Me.PageHeader.Name = "PageHeader"
        '
        'lblDraft_Page
        '
        Me.lblDraft_Page.CanShrink = True
        Me.lblDraft_Page.Dpi = 254.0!
        Me.lblDraft_Page.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDraft_Page.FormattingRules.Add(Me.ShowDraft)
        Me.lblDraft_Page.LocationFloat = New DevExpress.Utils.PointFloat(1531.661!, 0.0!)
        Me.lblDraft_Page.Name = "lblDraft_Page"
        Me.lblDraft_Page.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblDraft_Page.SizeF = New System.Drawing.SizeF(317.3389!, 58.42!)
        Me.lblDraft_Page.StylePriority.UseFont = False
        Me.lblDraft_Page.StylePriority.UseTextAlignment = False
        Me.lblDraft_Page.Text = "DRAFT"
        Me.lblDraft_Page.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lblDraft_Page.Visible = False
        '
        'param_ShowDraft
        '
        Me.param_ShowDraft.Description = "param_ShowDraft"
        Me.param_ShowDraft.Name = "param_ShowDraft"
        Me.param_ShowDraft.Type = GetType(Boolean)
        Me.param_ShowDraft.ValueInfo = "False"
        '
        'SubrptPNL_Details1_Income
        '
        Me.SubrptPNL_Details1_Income.CanShrink = True
        Me.SubrptPNL_Details1_Income.Dpi = 254.0!
        Me.SubrptPNL_Details1_Income.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.SubrptPNL_Details1_Income.Name = "SubrptPNL_Details1_Income"
        Me.SubrptPNL_Details1_Income.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramCompanyName", Me.paramCompanyName))
        Me.SubrptPNL_Details1_Income.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramYA", Me.paramYA))
        Me.SubrptPNL_Details1_Income.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramKeyName", Nothing, "PNL_TABLE_INFO.KeyName"))
        Me.SubrptPNL_Details1_Income.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramSch", Nothing, "PNL_TABLE_INFO.Sch"))
        Me.SubrptPNL_Details1_Income.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramID", Me.paramID))
        Me.SubrptPNL_Details1_Income.ReportSource = New EasyTemplate_Taxcom.rptPNL_Details1_Income()
        Me.SubrptPNL_Details1_Income.SizeF = New System.Drawing.SizeF(1849.0!, 60.85416!)
        Me.SubrptPNL_Details1_Income.Visible = False
        '
        'SubrptPNL_Details1_Expenses
        '
        Me.SubrptPNL_Details1_Expenses.CanShrink = True
        Me.SubrptPNL_Details1_Expenses.Dpi = 254.0!
        Me.SubrptPNL_Details1_Expenses.LocationFloat = New DevExpress.Utils.PointFloat(0.00006055832!, 0.0!)
        Me.SubrptPNL_Details1_Expenses.Name = "SubrptPNL_Details1_Expenses"
        Me.SubrptPNL_Details1_Expenses.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramCompanyName", Me.paramCompanyName))
        Me.SubrptPNL_Details1_Expenses.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramYA", Me.paramYA))
        Me.SubrptPNL_Details1_Expenses.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramKeyName", Nothing, "PNL_TABLE_INFO.KeyName"))
        Me.SubrptPNL_Details1_Expenses.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramSch", Nothing, "PNL_TABLE_INFO.Sch"))
        Me.SubrptPNL_Details1_Expenses.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramID", Me.paramID))
        Me.SubrptPNL_Details1_Expenses.ReportSource = New EasyTemplate_Taxcom.rptPNL_Details1_Expenses()
        Me.SubrptPNL_Details1_Expenses.SizeF = New System.Drawing.SizeF(1849.0!, 55.5625!)
        Me.SubrptPNL_Details1_Expenses.Visible = False
        '
        'SubrptPNL_Details_DividendIncome
        '
        Me.SubrptPNL_Details_DividendIncome.CanShrink = True
        Me.SubrptPNL_Details_DividendIncome.Dpi = 254.0!
        Me.SubrptPNL_Details_DividendIncome.LocationFloat = New DevExpress.Utils.PointFloat(0.0003835359!, 0.0!)
        Me.SubrptPNL_Details_DividendIncome.Name = "SubrptPNL_Details_DividendIncome"
        Me.SubrptPNL_Details_DividendIncome.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramYA", Me.paramYA))
        Me.SubrptPNL_Details_DividendIncome.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramCompanyName", Me.paramCompanyName))
        Me.SubrptPNL_Details_DividendIncome.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramKeyName", Nothing, "PNL_TABLE_INFO.KeyName"))
        Me.SubrptPNL_Details_DividendIncome.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramSch", Nothing, "PNL_TABLE_INFO.Sch"))
        Me.SubrptPNL_Details_DividendIncome.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramID", Me.paramID))
        Me.SubrptPNL_Details_DividendIncome.ReportSource = New EasyTemplate_Taxcom.rptPNL_Details_DividendIncome()
        Me.SubrptPNL_Details_DividendIncome.SizeF = New System.Drawing.SizeF(1849.0!, 58.42!)
        '
        'SubrptPNL_Details1_RentalIncome
        '
        Me.SubrptPNL_Details1_RentalIncome.CanShrink = True
        Me.SubrptPNL_Details1_RentalIncome.Dpi = 254.0!
        Me.SubrptPNL_Details1_RentalIncome.LocationFloat = New DevExpress.Utils.PointFloat(0.0003835359!, 0.0!)
        Me.SubrptPNL_Details1_RentalIncome.Name = "SubrptPNL_Details1_RentalIncome"
        Me.SubrptPNL_Details1_RentalIncome.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramYA", Me.paramYA))
        Me.SubrptPNL_Details1_RentalIncome.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramCompanyName", Me.paramCompanyName))
        Me.SubrptPNL_Details1_RentalIncome.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramSch", Nothing, "PNL_TABLE_INFO.Sch"))
        Me.SubrptPNL_Details1_RentalIncome.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramKeyName", Nothing, "PNL_TABLE_INFO.KeyName"))
        Me.SubrptPNL_Details1_RentalIncome.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramID", Me.paramID))
        Me.SubrptPNL_Details1_RentalIncome.ReportSource = New EasyTemplate_Taxcom.rptPNL_Details1_RentalIncome()
        Me.SubrptPNL_Details1_RentalIncome.SizeF = New System.Drawing.SizeF(1849.0!, 58.42!)
        '
        'SubrptPNL_Details1_ExemptDividend
        '
        Me.SubrptPNL_Details1_ExemptDividend.CanShrink = True
        Me.SubrptPNL_Details1_ExemptDividend.Dpi = 254.0!
        Me.SubrptPNL_Details1_ExemptDividend.LocationFloat = New DevExpress.Utils.PointFloat(0.0003835359!, 0.0!)
        Me.SubrptPNL_Details1_ExemptDividend.Name = "SubrptPNL_Details1_ExemptDividend"
        Me.SubrptPNL_Details1_ExemptDividend.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramYA", Me.paramYA))
        Me.SubrptPNL_Details1_ExemptDividend.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramCompanyName", Me.paramCompanyName))
        Me.SubrptPNL_Details1_ExemptDividend.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramSch", Nothing, "PNL_TABLE_INFO.Sch"))
        Me.SubrptPNL_Details1_ExemptDividend.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramKeyName", Nothing, "PNL_TABLE_INFO.KeyName"))
        Me.SubrptPNL_Details1_ExemptDividend.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramID", Me.paramID))
        Me.SubrptPNL_Details1_ExemptDividend.ReportSource = New EasyTemplate_Taxcom.rptPNL_Details1_ExemptDividend()
        Me.SubrptPNL_Details1_ExemptDividend.SizeF = New System.Drawing.SizeF(1849.0!, 58.42!)
        '
        'SubrptPNL_Details1_RentalExpenses
        '
        Me.SubrptPNL_Details1_RentalExpenses.CanShrink = True
        Me.SubrptPNL_Details1_RentalExpenses.Dpi = 254.0!
        Me.SubrptPNL_Details1_RentalExpenses.LocationFloat = New DevExpress.Utils.PointFloat(0.0003835359!, 0.0!)
        Me.SubrptPNL_Details1_RentalExpenses.Name = "SubrptPNL_Details1_RentalExpenses"
        Me.SubrptPNL_Details1_RentalExpenses.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramYA", Me.paramYA))
        Me.SubrptPNL_Details1_RentalExpenses.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramCompanyName", Me.paramCompanyName))
        Me.SubrptPNL_Details1_RentalExpenses.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramKeyName", Nothing, "PNL_TABLE_INFO.KeyName"))
        Me.SubrptPNL_Details1_RentalExpenses.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramSch", Nothing, "PNL_TABLE_INFO.Sch"))
        Me.SubrptPNL_Details1_RentalExpenses.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramID", Me.paramID))
        Me.SubrptPNL_Details1_RentalExpenses.ReportSource = New EasyTemplate_Taxcom.rptPNL_Details1_RentalExpenses()
        Me.SubrptPNL_Details1_RentalExpenses.SizeF = New System.Drawing.SizeF(1849.0!, 58.42!)
        '
        'SubrptPNL_NoteNew
        '
        Me.SubrptPNL_NoteNew.CanShrink = True
        Me.SubrptPNL_NoteNew.Dpi = 254.0!
        Me.SubrptPNL_NoteNew.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.SubrptPNL_NoteNew.Name = "SubrptPNL_NoteNew"
        Me.SubrptPNL_NoteNew.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramYA", Me.paramYA))
        Me.SubrptPNL_NoteNew.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("ParamCompayName", Me.paramCompanyName))
        Me.SubrptPNL_NoteNew.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramKeyName", Nothing, "PNL_TABLE_INFO.KeyName"))
        Me.SubrptPNL_NoteNew.ReportSource = New EasyTemplate_Taxcom.rptPNL_NoteNew()
        Me.SubrptPNL_NoteNew.SizeF = New System.Drawing.SizeF(1849.0!, 58.42!)
        Me.SubrptPNL_NoteNew.Visible = False
        '
        'rptPNL_DetailsNew
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageFooter, Me.PageHeader})
        Me.DataMember = "PNL_TABLE_INFO"
        Me.DataSource = Me.DsPNL_Report1
        Me.Dpi = 254.0!
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.FormattingRule1, Me.KeyNameType, Me.KeyNameType2, Me.Exclude, Me.ShowDraft})
        Me.Margins = New System.Drawing.Printing.Margins(193, 58, 97, 79)
        Me.PageHeight = 2970
        Me.PageWidth = 2100
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.paramCompanyName, Me.paramYA, Me.param_ShowDraft, Me.paramID})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.RequestParameters = False
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnapGridSize = 25.0!
        Me.Version = "17.1"
        CType(Me.DsPNL_Report1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents DsPNL_Report1 As EasyTemplate_Taxcom.dsPNL_Report
    Friend WithEvents SubrptPNL_Details1_Income As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents paramCompanyName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents paramYA As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents FormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents SubBand1 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents KeyNameType As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents SubBand2 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents KeyNameType2 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents SubrptPNL_Details1_Expenses As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents Exclude As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SubBand3 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents SubrptPNL_NoteNew As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents SubBand4 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents SubPNLInfo_KEYName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SubrptPNL_Details_DividendIncome As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents SubBand5 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents SubrptPNL_Details1_RentalIncome As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents SubBand6 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents SubBand7 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents SubrptPNL_Details1_ExemptDividend As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents SubrptPNL_Details1_RentalExpenses As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents SubBand8 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents lblDraft_Page As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents param_ShowDraft As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents lblDraft_Report As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ShowDraft As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents paramID As DevExpress.XtraReports.Parameters.Parameter
End Class
