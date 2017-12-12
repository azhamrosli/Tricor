<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCA_ReportList
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCA_ReportList))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.CAREPORTTEMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCA = New EasyTemplate_Taxcom.dsCA()
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colYA = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCA_PURCHASE_YEAR = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCA_ASSET = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.txtMemo = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colCA_CATEGORY_CODE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCA_RATE_IA = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCA_RATE_AA = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colQC_BF = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colQC_ADD = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colQC_DISP = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colQC_CF = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colTWDV_BF = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTWDV_ADD = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTWDV_DISP = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTWDV_AI = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTWDV_AA = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTWDV_CF = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colID_Key = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colRefNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCA_KEY = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCA_NAME = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCA_MODE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCA_QUALIFYING_COST = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colIndexNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExport = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExpand = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCollepase = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAREPORTTEMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.CAREPORTTEMPBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridControl1.Location = New System.Drawing.Point(0, 31)
        Me.GridControl1.MainView = Me.BandedGridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtMemo})
        Me.GridControl1.Size = New System.Drawing.Size(1069, 536)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1})
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
        'BandedGridView1
        '
        Me.BandedGridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.BandedGridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BandedGridView1.Appearance.Row.Options.UseTextOptions = True
        Me.BandedGridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BandedGridView1.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.BandedGridView1.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand5, Me.gridBand4, Me.gridBand1, Me.gridBand2})
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colID_Key, Me.colID, Me.colRefNo, Me.colYA, Me.colCA_KEY, Me.colCA_NAME, Me.colCA_ASSET, Me.colCA_CATEGORY_CODE, Me.colCA_MODE, Me.colCA_PURCHASE_YEAR, Me.colCA_QUALIFYING_COST, Me.colCA_RATE_IA, Me.colCA_RATE_AA, Me.colQC_BF, Me.colQC_ADD, Me.colQC_DISP, Me.colQC_CF, Me.colTWDV_BF, Me.colTWDV_ADD, Me.colTWDV_DISP, Me.colTWDV_AI, Me.colTWDV_AA, Me.colTWDV_CF, Me.colIndexNo})
        Me.BandedGridView1.GridControl = Me.GridControl1
        Me.BandedGridView1.GroupCount = 1
        Me.BandedGridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QC_BF", Me.colQC_BF, "{0:n2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QC_ADD", Me.colQC_ADD, "{0:n2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QC_DISP", Me.colQC_DISP, "{0:n2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QC_CF", Me.colQC_CF, "{0:n2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TWDV_BF", Me.colTWDV_BF, "{0:n2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TWDV_ADD", Me.colTWDV_ADD, "{0:n2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TWDV_DISP", Me.colTWDV_DISP, "{0:n2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TWDV_AI", Me.colTWDV_AI, "{0:n2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TWDV_AA", Me.colTWDV_AA, "{0:n2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TWDV_CF", Me.colTWDV_CF, "{0:n2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "", Me.colCA_ASSET, "Sub Total :")})
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.BandedGridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.BandedGridView1.OptionsBehavior.Editable = False
        Me.BandedGridView1.OptionsPrint.AllowMultilineHeaders = True
        Me.BandedGridView1.OptionsPrint.EnableAppearanceOddRow = True
        Me.BandedGridView1.OptionsPrint.ExpandAllDetails = True
        Me.BandedGridView1.OptionsPrint.RtfPageFooter = resources.GetString("BandedGridView1.OptionsPrint.RtfPageFooter")
        Me.BandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        Me.BandedGridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.BandedGridView1.OptionsView.RowAutoHeight = True
        Me.BandedGridView1.OptionsView.ShowFooter = True
        Me.BandedGridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCA_ASSET, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'gridBand5
        '
        Me.gridBand5.Columns.Add(Me.colYA)
        Me.gridBand5.Columns.Add(Me.colCA_PURCHASE_YEAR)
        Me.gridBand5.Columns.Add(Me.colCA_ASSET)
        Me.gridBand5.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.gridBand5.Name = "gridBand5"
        Me.gridBand5.VisibleIndex = 0
        Me.gridBand5.Width = 460
        '
        'colYA
        '
        Me.colYA.Caption = "Year"
        Me.colYA.FieldName = "YA"
        Me.colYA.Name = "colYA"
        Me.colYA.Visible = True
        Me.colYA.Width = 80
        '
        'colCA_PURCHASE_YEAR
        '
        Me.colCA_PURCHASE_YEAR.Caption = "Purchase of Year"
        Me.colCA_PURCHASE_YEAR.FieldName = "CA_PURCHASE_YEAR"
        Me.colCA_PURCHASE_YEAR.Name = "colCA_PURCHASE_YEAR"
        Me.colCA_PURCHASE_YEAR.Visible = True
        Me.colCA_PURCHASE_YEAR.Width = 150
        '
        'colCA_ASSET
        '
        Me.colCA_ASSET.Caption = "Description"
        Me.colCA_ASSET.ColumnEdit = Me.txtMemo
        Me.colCA_ASSET.FieldName = "CA_ASSET"
        Me.colCA_ASSET.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value
        Me.colCA_ASSET.Name = "colCA_ASSET"
        Me.colCA_ASSET.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "CA_ASSET", "Total :")})
        Me.colCA_ASSET.Visible = True
        Me.colCA_ASSET.Width = 230
        '
        'txtMemo
        '
        Me.txtMemo.Name = "txtMemo"
        '
        'gridBand4
        '
        Me.gridBand4.Columns.Add(Me.colCA_CATEGORY_CODE)
        Me.gridBand4.Columns.Add(Me.colCA_RATE_IA)
        Me.gridBand4.Columns.Add(Me.colCA_RATE_AA)
        Me.gridBand4.Name = "gridBand4"
        Me.gridBand4.VisibleIndex = 1
        Me.gridBand4.Width = 304
        '
        'colCA_CATEGORY_CODE
        '
        Me.colCA_CATEGORY_CODE.Caption = "Category"
        Me.colCA_CATEGORY_CODE.FieldName = "CA_CATEGORY_CODE"
        Me.colCA_CATEGORY_CODE.Name = "colCA_CATEGORY_CODE"
        Me.colCA_CATEGORY_CODE.Visible = True
        Me.colCA_CATEGORY_CODE.Width = 108
        '
        'colCA_RATE_IA
        '
        Me.colCA_RATE_IA.Caption = "IA"
        Me.colCA_RATE_IA.FieldName = "CA_RATE_IA"
        Me.colCA_RATE_IA.Name = "colCA_RATE_IA"
        Me.colCA_RATE_IA.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCA_RATE_IA.Visible = True
        Me.colCA_RATE_IA.Width = 97
        '
        'colCA_RATE_AA
        '
        Me.colCA_RATE_AA.Caption = "AA"
        Me.colCA_RATE_AA.FieldName = "CA_RATE_AA"
        Me.colCA_RATE_AA.Name = "colCA_RATE_AA"
        Me.colCA_RATE_AA.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCA_RATE_AA.Visible = True
        Me.colCA_RATE_AA.Width = 99
        '
        'gridBand1
        '
        Me.gridBand1.Caption = "Qualifying Cost"
        Me.gridBand1.Columns.Add(Me.colQC_BF)
        Me.gridBand1.Columns.Add(Me.colQC_ADD)
        Me.gridBand1.Columns.Add(Me.colQC_DISP)
        Me.gridBand1.Columns.Add(Me.colQC_CF)
        Me.gridBand1.Name = "gridBand1"
        Me.gridBand1.VisibleIndex = 2
        Me.gridBand1.Width = 600
        '
        'colQC_BF
        '
        Me.colQC_BF.Caption = "Balance b/f"
        Me.colQC_BF.DisplayFormat.FormatString = "n2"
        Me.colQC_BF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQC_BF.FieldName = "QC_BF"
        Me.colQC_BF.Name = "colQC_BF"
        Me.colQC_BF.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QC_BF", "{0:n2}")})
        Me.colQC_BF.Visible = True
        Me.colQC_BF.Width = 150
        '
        'colQC_ADD
        '
        Me.colQC_ADD.Caption = "Addition"
        Me.colQC_ADD.DisplayFormat.FormatString = "n2"
        Me.colQC_ADD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQC_ADD.FieldName = "QC_ADD"
        Me.colQC_ADD.Name = "colQC_ADD"
        Me.colQC_ADD.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QC_ADD", "{0:n2}")})
        Me.colQC_ADD.Visible = True
        Me.colQC_ADD.Width = 150
        '
        'colQC_DISP
        '
        Me.colQC_DISP.Caption = "Disposal"
        Me.colQC_DISP.DisplayFormat.FormatString = "n2"
        Me.colQC_DISP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQC_DISP.FieldName = "QC_DISP"
        Me.colQC_DISP.Name = "colQC_DISP"
        Me.colQC_DISP.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QC_DISP", "{0:n2}")})
        Me.colQC_DISP.Visible = True
        Me.colQC_DISP.Width = 150
        '
        'colQC_CF
        '
        Me.colQC_CF.Caption = "Balance c/f"
        Me.colQC_CF.DisplayFormat.FormatString = "n2"
        Me.colQC_CF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQC_CF.FieldName = "QC_CF"
        Me.colQC_CF.Name = "colQC_CF"
        Me.colQC_CF.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QC_CF", "{0:n2}")})
        Me.colQC_CF.Visible = True
        Me.colQC_CF.Width = 150
        '
        'gridBand2
        '
        Me.gridBand2.Caption = "TWDV"
        Me.gridBand2.Columns.Add(Me.colTWDV_BF)
        Me.gridBand2.Columns.Add(Me.colTWDV_ADD)
        Me.gridBand2.Columns.Add(Me.colTWDV_DISP)
        Me.gridBand2.Columns.Add(Me.colTWDV_AI)
        Me.gridBand2.Columns.Add(Me.colTWDV_AA)
        Me.gridBand2.Columns.Add(Me.colTWDV_CF)
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.VisibleIndex = 3
        Me.gridBand2.Width = 900
        '
        'colTWDV_BF
        '
        Me.colTWDV_BF.Caption = "Balance b/f"
        Me.colTWDV_BF.DisplayFormat.FormatString = "n2"
        Me.colTWDV_BF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTWDV_BF.FieldName = "TWDV_BF"
        Me.colTWDV_BF.Name = "colTWDV_BF"
        Me.colTWDV_BF.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TWDV_BF", "{0:n2}")})
        Me.colTWDV_BF.Visible = True
        Me.colTWDV_BF.Width = 150
        '
        'colTWDV_ADD
        '
        Me.colTWDV_ADD.Caption = "Addition"
        Me.colTWDV_ADD.DisplayFormat.FormatString = "n2"
        Me.colTWDV_ADD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTWDV_ADD.FieldName = "TWDV_ADD"
        Me.colTWDV_ADD.Name = "colTWDV_ADD"
        Me.colTWDV_ADD.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TWDV_ADD", "{0:n2}")})
        Me.colTWDV_ADD.Visible = True
        Me.colTWDV_ADD.Width = 150
        '
        'colTWDV_DISP
        '
        Me.colTWDV_DISP.Caption = "Disposal"
        Me.colTWDV_DISP.DisplayFormat.FormatString = "n2"
        Me.colTWDV_DISP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTWDV_DISP.FieldName = "TWDV_DISP"
        Me.colTWDV_DISP.Name = "colTWDV_DISP"
        Me.colTWDV_DISP.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TWDV_DISP", "{0:n2}")})
        Me.colTWDV_DISP.Visible = True
        Me.colTWDV_DISP.Width = 150
        '
        'colTWDV_AI
        '
        Me.colTWDV_AI.Caption = "IA%"
        Me.colTWDV_AI.DisplayFormat.FormatString = "n2"
        Me.colTWDV_AI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTWDV_AI.FieldName = "TWDV_AI"
        Me.colTWDV_AI.Name = "colTWDV_AI"
        Me.colTWDV_AI.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TWDV_AI", "{0:n2}")})
        Me.colTWDV_AI.Visible = True
        Me.colTWDV_AI.Width = 150
        '
        'colTWDV_AA
        '
        Me.colTWDV_AA.Caption = "AA%"
        Me.colTWDV_AA.DisplayFormat.FormatString = "n2"
        Me.colTWDV_AA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTWDV_AA.FieldName = "TWDV_AA"
        Me.colTWDV_AA.Name = "colTWDV_AA"
        Me.colTWDV_AA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TWDV_AA", "{0:n2}")})
        Me.colTWDV_AA.Visible = True
        Me.colTWDV_AA.Width = 150
        '
        'colTWDV_CF
        '
        Me.colTWDV_CF.Caption = "Balance c/f"
        Me.colTWDV_CF.DisplayFormat.FormatString = "n2"
        Me.colTWDV_CF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTWDV_CF.FieldName = "TWDV_CF"
        Me.colTWDV_CF.Name = "colTWDV_CF"
        Me.colTWDV_CF.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TWDV_CF", "{0:n2}")})
        Me.colTWDV_CF.Visible = True
        Me.colTWDV_CF.Width = 150
        '
        'colID_Key
        '
        Me.colID_Key.FieldName = "ID_Key"
        Me.colID_Key.Name = "colID_Key"
        Me.colID_Key.Visible = True
        Me.colID_Key.Width = 150
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.Width = 150
        '
        'colRefNo
        '
        Me.colRefNo.Caption = "Reference No"
        Me.colRefNo.FieldName = "RefNo"
        Me.colRefNo.Name = "colRefNo"
        Me.colRefNo.Visible = True
        Me.colRefNo.Width = 150
        '
        'colCA_KEY
        '
        Me.colCA_KEY.FieldName = "CA_KEY"
        Me.colCA_KEY.Name = "colCA_KEY"
        Me.colCA_KEY.Visible = True
        Me.colCA_KEY.Width = 150
        '
        'colCA_NAME
        '
        Me.colCA_NAME.Caption = "Company Name"
        Me.colCA_NAME.FieldName = "CA_NAME"
        Me.colCA_NAME.Name = "colCA_NAME"
        Me.colCA_NAME.Visible = True
        Me.colCA_NAME.Width = 247
        '
        'colCA_MODE
        '
        Me.colCA_MODE.FieldName = "CA_MODE"
        Me.colCA_MODE.Name = "colCA_MODE"
        Me.colCA_MODE.Width = 150
        '
        'colCA_QUALIFYING_COST
        '
        Me.colCA_QUALIFYING_COST.FieldName = "CA_QUALIFYING_COST"
        Me.colCA_QUALIFYING_COST.Name = "colCA_QUALIFYING_COST"
        Me.colCA_QUALIFYING_COST.Visible = True
        Me.colCA_QUALIFYING_COST.Width = 150
        '
        'colIndexNo
        '
        Me.colIndexNo.FieldName = "IndexNo"
        Me.colIndexNo.Name = "colIndexNo"
        Me.colIndexNo.Visible = True
        Me.colIndexNo.Width = 150
        '
        'BarManager1
        '
        Me.BarManager1.AllowQuickCustomization = False
        Me.BarManager1.AllowShowToolbarsPopup = False
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnExport, Me.btnPrint, Me.btnExpand, Me.btnCollepase})
        Me.BarManager1.MaxItemId = 10
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrint), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExport), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExpand), New DevExpress.XtraBars.LinkPersistInfo(Me.btnCollepase)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None
        Me.Bar1.OptionsBar.DisableClose = True
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'btnPrint
        '
        Me.btnPrint.Caption = "Print"
        Me.btnPrint.Glyph = CType(resources.GetObject("btnPrint.Glyph"), System.Drawing.Image)
        Me.btnPrint.Id = 3
        Me.btnPrint.LargeGlyph = CType(resources.GetObject("btnPrint.LargeGlyph"), System.Drawing.Image)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnExport
        '
        Me.btnExport.Caption = "Export"
        Me.btnExport.Glyph = CType(resources.GetObject("btnExport.Glyph"), System.Drawing.Image)
        Me.btnExport.Id = 2
        Me.btnExport.LargeGlyph = CType(resources.GetObject("btnExport.LargeGlyph"), System.Drawing.Image)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnExpand
        '
        Me.btnExpand.Caption = "Expand"
        Me.btnExpand.Glyph = CType(resources.GetObject("btnExpand.Glyph"), System.Drawing.Image)
        Me.btnExpand.Id = 8
        Me.btnExpand.LargeGlyph = CType(resources.GetObject("btnExpand.LargeGlyph"), System.Drawing.Image)
        Me.btnExpand.Name = "btnExpand"
        Me.btnExpand.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnCollepase
        '
        Me.btnCollepase.Caption = "Collepase"
        Me.btnCollepase.Glyph = CType(resources.GetObject("btnCollepase.Glyph"), System.Drawing.Image)
        Me.btnCollepase.Id = 9
        Me.btnCollepase.LargeGlyph = CType(resources.GetObject("btnCollepase.LargeGlyph"), System.Drawing.Image)
        Me.btnCollepase.Name = "btnCollepase"
        Me.btnCollepase.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1069, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 567)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1069, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 536)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1069, 31)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 536)
        '
        'frmCA_ReportList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 567)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmCA_ReportList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAREPORTTEMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents CAREPORTTEMPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsCA As EasyTemplate_Taxcom.dsCA
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents colID_Key As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRefNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colYA As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCA_KEY As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCA_NAME As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCA_ASSET As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCA_CATEGORY_CODE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCA_MODE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCA_PURCHASE_YEAR As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCA_QUALIFYING_COST As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCA_RATE_IA As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCA_RATE_AA As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colQC_BF As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colQC_ADD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colQC_DISP As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colQC_CF As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTWDV_BF As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTWDV_ADD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTWDV_DISP As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTWDV_AI As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTWDV_AA As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTWDV_CF As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIndexNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents txtMemo As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents btnExpand As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCollepase As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
