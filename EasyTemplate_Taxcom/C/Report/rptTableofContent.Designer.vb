<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptTableofContent
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
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.paramCompanyName = New DevExpress.XtraReports.Parameters.Parameter()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrPivotGrid1 = New DevExpress.XtraReports.UI.XRPivotGrid()
        Me.XrPivotGridField1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.XrPivotGridField2 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.XrPivotGridField3 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.XrPivotGridField4 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.XrPivotGridField5 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        Me.XrPivotGridField6 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPivotGrid1})
        Me.Detail.HeightF = 100.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'paramCompanyName
        '
        Me.paramCompanyName.Description = "paramCompanyName"
        Me.paramCompanyName.Name = "paramCompanyName"
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 40.0!
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
        'ReportHeader
        '
        Me.ReportHeader.HeightF = 86.20834!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrPivotGrid1
        '
        Me.XrPivotGrid1.Fields.AddRange(New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField() {Me.XrPivotGridField1, Me.XrPivotGridField2, Me.XrPivotGridField3, Me.XrPivotGridField4, Me.XrPivotGridField5, Me.XrPivotGridField6})
        Me.XrPivotGrid1.LocationFloat = New DevExpress.Utils.PointFloat(33.91672!, 0.0!)
        Me.XrPivotGrid1.Name = "XrPivotGrid1"
        Me.XrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3
        Me.XrPivotGrid1.SizeF = New System.Drawing.SizeF(746.25!, 50.0!)
        '
        'XrPivotGridField1
        '
        Me.XrPivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.XrPivotGridField1.AreaIndex = 0
        Me.XrPivotGridField1.Name = "XrPivotGridField1"
        '
        'XrPivotGridField2
        '
        Me.XrPivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.XrPivotGridField2.AreaIndex = 1
        Me.XrPivotGridField2.Name = "XrPivotGridField2"
        '
        'XrPivotGridField3
        '
        Me.XrPivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.XrPivotGridField3.AreaIndex = 2
        Me.XrPivotGridField3.Name = "XrPivotGridField3"
        '
        'XrPivotGridField4
        '
        Me.XrPivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.XrPivotGridField4.AreaIndex = 3
        Me.XrPivotGridField4.Name = "XrPivotGridField4"
        '
        'XrPivotGridField5
        '
        Me.XrPivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.XrPivotGridField5.AreaIndex = 4
        Me.XrPivotGridField5.Name = "XrPivotGridField5"
        '
        'XrPivotGridField6
        '
        Me.XrPivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.XrPivotGridField6.AreaIndex = 5
        Me.XrPivotGridField6.Name = "XrPivotGridField6"
        '
        'rptTableofContent
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
        Me.Margins = New System.Drawing.Printing.Margins(19, 24, 40, 100)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.paramCompanyName})
        Me.RequestParameters = False
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "17.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents paramCompanyName As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrPivotGrid1 As DevExpress.XtraReports.UI.XRPivotGrid
    Friend WithEvents XrPivotGridField1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrPivotGridField2 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrPivotGridField3 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrPivotGridField4 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrPivotGridField5 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrPivotGridField6 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
End Class
