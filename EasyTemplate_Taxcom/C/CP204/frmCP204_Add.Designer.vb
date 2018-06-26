<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCP204_Add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCP204_Add))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefreshMonthlyBreakdown = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExport = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNote = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCurrAvaiblePayment = New DevExpress.XtraEditors.TextEdit()
        Me.cboRefNo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.TaxPayerFindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDefault = New EasyTemplate_Taxcom.dsDefault()
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRefNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHandleBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployerNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtRefRegistrationNo = New DevExpress.XtraEditors.TextEdit()
        Me.txtRefNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.cboYA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.llbAmountTaxpayerLastYear = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmountTaxPayable_LastYear = New DevExpress.XtraEditors.TextEdit()
        Me.txtFirstInstallmentCount = New DevExpress.XtraEditors.TextEdit()
        Me.cboYA_To_SME = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboYA_From_SME = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboState_Alt_Cor = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboState_Cor = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCity_Alt_Cor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPostcode_Alt_Cor = New DevExpress.XtraEditors.TextEdit()
        Me.txtAdd3_Alt_Cor = New DevExpress.XtraEditors.TextEdit()
        Me.txtAdd2_Alt_Cor = New DevExpress.XtraEditors.TextEdit()
        Me.txtAdd1_Alt_Cor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.dtBasisPeriodSecEnd = New DevExpress.XtraEditors.DateEdit()
        Me.dtBasisPeriodSecStart = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.dtBasisPeriodYAEnd = New DevExpress.XtraEditors.DateEdit()
        Me.dtBasisPeriodYAStart = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLastInstallment = New DevExpress.XtraEditors.TextEdit()
        Me.txtFirstInstallment = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.rbPeriodEnded = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.dtCommencement = New DevExpress.XtraEditors.DateEdit()
        Me.chkCommencement = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.chkSME = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.dtBasisPeriodEnd = New DevExpress.XtraEditors.DateEdit()
        Me.dtBasisPeriodStart = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.dtAccEnd = New DevExpress.XtraEditors.DateEdit()
        Me.dtAccStart = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmountTaxPayable = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEstimationPercent = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.dtDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCity_Cor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPostcode_Cor = New DevExpress.XtraEditors.TextEdit()
        Me.txtAdd3_Cor = New DevExpress.XtraEditors.TextEdit()
        Me.txtAdd2_Cor = New DevExpress.XtraEditors.TextEdit()
        Me.txtAdd1_Cor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ApplyPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BORANGCP204TRICORBREAKDOWNBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCP204 = New EasyTemplate_Taxcom.dsCP204()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCP_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCP_PARENTID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCP_INSTALL_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCP_PAYMENT_DUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colCP_INSTALLMENT_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colCP_PAYMENT_DATE_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCP_AMOUNT_PAID_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCP_PAYMENT_DATE_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCP_AMOUNT_PAID_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCP_PENALTY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCP_NOTE_TITLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCP_NOTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCP_TagID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNote = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.chkAddBack = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ReportGenerator1 = New DevExpress.XtraReports.ReportGeneration.ReportGenerator(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtCurrAvaiblePayment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefRegistrationNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.txtAmountTaxPayable_LastYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFirstInstallmentCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYA_To_SME.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYA_From_SME.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboState_Alt_Cor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboState_Cor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCity_Alt_Cor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPostcode_Alt_Cor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdd3_Alt_Cor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdd2_Alt_Cor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdd1_Alt_Cor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBasisPeriodSecEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBasisPeriodSecEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBasisPeriodSecStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBasisPeriodSecStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBasisPeriodYAEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBasisPeriodYAEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBasisPeriodYAStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBasisPeriodYAStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLastInstallment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFirstInstallment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbPeriodEnded.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCommencement.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCommencement.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCommencement.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSME.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBasisPeriodEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBasisPeriodEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBasisPeriodStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBasisPeriodStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtAccEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtAccEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtAccStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtAccStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmountTaxPayable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstimationPercent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCity_Cor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPostcode_Cor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdd3_Cor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdd2_Cor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdd1_Cor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.BORANGCP204TRICORBREAKDOWNBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCP204, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAddBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnAdd, Me.btnPrint, Me.btnExport, Me.btnRefresh, Me.btnRefreshMonthlyBreakdown, Me.btnNote})
        Me.BarManager1.MaxItemId = 16
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(271, 130)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRefresh), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRefreshMonthlyBreakdown), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExport), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrint), New DevExpress.XtraBars.LinkPersistInfo(Me.btnNote)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DisableClose = True
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'btnAdd
        '
        Me.btnAdd.Caption = "Save"
        Me.btnAdd.Id = 0
        Me.btnAdd.ImageOptions.Image = CType(resources.GetObject("btnAdd.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd.ImageOptions.LargeImage = CType(resources.GetObject("btnAdd.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAdd.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem1.Text = "Add new record"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Add new record Ctrl + R"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btnAdd.SuperTip = SuperToolTip1
        '
        'btnRefresh
        '
        Me.btnRefresh.Caption = "Refresh"
        Me.btnRefresh.Id = 13
        Me.btnRefresh.ImageOptions.Image = CType(resources.GetObject("btnRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageOptions.LargeImage = CType(resources.GetObject("btnRefresh.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnRefreshMonthlyBreakdown
        '
        Me.btnRefreshMonthlyBreakdown.Caption = "Refresh Instalment Monthly Breakdown"
        Me.btnRefreshMonthlyBreakdown.Id = 14
        Me.btnRefreshMonthlyBreakdown.ImageOptions.Image = CType(resources.GetObject("btnRefreshMonthlyBreakdown.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefreshMonthlyBreakdown.ImageOptions.LargeImage = CType(resources.GetObject("btnRefreshMonthlyBreakdown.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnRefreshMonthlyBreakdown.Name = "btnRefreshMonthlyBreakdown"
        Me.btnRefreshMonthlyBreakdown.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnExport
        '
        Me.btnExport.Caption = "Export  Monthly Breakdown"
        Me.btnExport.Id = 12
        Me.btnExport.ImageOptions.Image = CType(resources.GetObject("btnExport.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExport.ImageOptions.LargeImage = CType(resources.GetObject("btnExport.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnPrint
        '
        Me.btnPrint.Caption = "Print Monthly Breakdown"
        Me.btnPrint.Id = 11
        Me.btnPrint.ImageOptions.Image = CType(resources.GetObject("btnPrint.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrint.ImageOptions.LargeImage = CType(resources.GetObject("btnPrint.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.btnPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnNote
        '
        Me.btnNote.Caption = "Note"
        Me.btnNote.Id = 15
        Me.btnNote.ImageOptions.Image = CType(resources.GetObject("btnNote.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNote.ImageOptions.LargeImage = CType(resources.GetObject("btnNote.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnNote.Name = "btnNote"
        Me.btnNote.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1426, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 682)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1426, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 651)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1426, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 651)
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatString = "n"
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        Me.RepositoryItemTextEdit2.ReadOnly = True
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl33)
        Me.PanelControl1.Controls.Add(Me.txtCurrAvaiblePayment)
        Me.PanelControl1.Controls.Add(Me.cboRefNo)
        Me.PanelControl1.Controls.Add(Me.txtRefRegistrationNo)
        Me.PanelControl1.Controls.Add(Me.txtRefNo)
        Me.PanelControl1.Controls.Add(Me.LabelControl11)
        Me.PanelControl1.Controls.Add(Me.cboYA)
        Me.PanelControl1.Controls.Add(Me.LabelControl10)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 31)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1426, 101)
        Me.PanelControl1.TabIndex = 4
        '
        'LabelControl33
        '
        Me.LabelControl33.Location = New System.Drawing.Point(775, 23)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(128, 13)
        Me.LabelControl33.TabIndex = 172
        Me.LabelControl33.Text = "Balance payment amount :"
        '
        'txtCurrAvaiblePayment
        '
        Me.txtCurrAvaiblePayment.EditValue = "0"
        Me.txtCurrAvaiblePayment.Location = New System.Drawing.Point(911, 20)
        Me.txtCurrAvaiblePayment.Name = "txtCurrAvaiblePayment"
        Me.txtCurrAvaiblePayment.Properties.ReadOnly = True
        Me.txtCurrAvaiblePayment.Size = New System.Drawing.Size(262, 20)
        Me.txtCurrAvaiblePayment.TabIndex = 171
        '
        'cboRefNo
        '
        Me.cboRefNo.Location = New System.Drawing.Point(113, 20)
        Me.cboRefNo.MenuManager = Me.BarManager1
        Me.cboRefNo.Name = "cboRefNo"
        Me.cboRefNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRefNo.Properties.DataSource = Me.TaxPayerFindBindingSource
        Me.cboRefNo.Properties.DisplayMember = "CompanyName"
        Me.cboRefNo.Properties.NullText = "Select"
        Me.cboRefNo.Properties.PopupFormMinSize = New System.Drawing.Size(600, 0)
        Me.cboRefNo.Properties.ValueMember = "RefNo"
        Me.cboRefNo.Properties.View = Me.SearchLookUpEdit2View
        Me.cboRefNo.Size = New System.Drawing.Size(262, 20)
        Me.cboRefNo.TabIndex = 170
        '
        'TaxPayerFindBindingSource
        '
        Me.TaxPayerFindBindingSource.DataMember = "TaxPayerFind"
        Me.TaxPayerFindBindingSource.DataSource = Me.DsDefault
        '
        'DsDefault
        '
        Me.DsDefault.DataSetName = "dsDefault"
        Me.DsDefault.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SearchLookUpEdit2View
        '
        Me.SearchLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRefNo, Me.colCompanyName, Me.colHandleBy, Me.colCompanyNo, Me.colEmployerNo, Me.colFileNo, Me.colCountry, Me.colCompanyCode})
        Me.SearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit2View.Name = "SearchLookUpEdit2View"
        Me.SearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit2View.OptionsView.ColumnAutoWidth = False
        Me.SearchLookUpEdit2View.OptionsView.RowAutoHeight = True
        Me.SearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colRefNo
        '
        Me.colRefNo.FieldName = "RefNo"
        Me.colRefNo.Name = "colRefNo"
        Me.colRefNo.Visible = True
        Me.colRefNo.VisibleIndex = 0
        Me.colRefNo.Width = 100
        '
        'colCompanyName
        '
        Me.colCompanyName.FieldName = "CompanyName"
        Me.colCompanyName.Name = "colCompanyName"
        Me.colCompanyName.Visible = True
        Me.colCompanyName.VisibleIndex = 1
        Me.colCompanyName.Width = 250
        '
        'colHandleBy
        '
        Me.colHandleBy.FieldName = "HandleBy"
        Me.colHandleBy.Name = "colHandleBy"
        Me.colHandleBy.Visible = True
        Me.colHandleBy.VisibleIndex = 2
        Me.colHandleBy.Width = 150
        '
        'colCompanyNo
        '
        Me.colCompanyNo.FieldName = "CompanyNo"
        Me.colCompanyNo.Name = "colCompanyNo"
        Me.colCompanyNo.Visible = True
        Me.colCompanyNo.VisibleIndex = 3
        Me.colCompanyNo.Width = 100
        '
        'colEmployerNo
        '
        Me.colEmployerNo.FieldName = "EmployerNo"
        Me.colEmployerNo.Name = "colEmployerNo"
        Me.colEmployerNo.Visible = True
        Me.colEmployerNo.VisibleIndex = 4
        Me.colEmployerNo.Width = 100
        '
        'colFileNo
        '
        Me.colFileNo.FieldName = "FileNo"
        Me.colFileNo.Name = "colFileNo"
        Me.colFileNo.Visible = True
        Me.colFileNo.VisibleIndex = 5
        Me.colFileNo.Width = 100
        '
        'colCountry
        '
        Me.colCountry.FieldName = "Country"
        Me.colCountry.Name = "colCountry"
        Me.colCountry.Visible = True
        Me.colCountry.VisibleIndex = 6
        Me.colCountry.Width = 100
        '
        'colCompanyCode
        '
        Me.colCompanyCode.FieldName = "CompanyCode"
        Me.colCompanyCode.Name = "colCompanyCode"
        Me.colCompanyCode.Visible = True
        Me.colCompanyCode.VisibleIndex = 7
        Me.colCompanyCode.Width = 100
        '
        'txtRefRegistrationNo
        '
        Me.txtRefRegistrationNo.Location = New System.Drawing.Point(113, 70)
        Me.txtRefRegistrationNo.Name = "txtRefRegistrationNo"
        Me.txtRefRegistrationNo.Properties.ReadOnly = True
        Me.txtRefRegistrationNo.Size = New System.Drawing.Size(262, 20)
        Me.txtRefRegistrationNo.TabIndex = 169
        '
        'txtRefNo
        '
        Me.txtRefNo.Location = New System.Drawing.Point(113, 46)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Properties.ReadOnly = True
        Me.txtRefNo.Size = New System.Drawing.Size(262, 20)
        Me.txtRefNo.TabIndex = 168
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(387, 23)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl11.TabIndex = 167
        Me.LabelControl11.Text = "YA :"
        '
        'cboYA
        '
        Me.cboYA.Location = New System.Drawing.Point(471, 20)
        Me.cboYA.Name = "cboYA"
        Me.cboYA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboYA.Properties.PopupSizeable = True
        Me.cboYA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboYA.Size = New System.Drawing.Size(280, 20)
        Me.cboYA.TabIndex = 165
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(10, 22)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl10.TabIndex = 166
        Me.LabelControl10.Text = "Ref No :"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 132)
        Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Size = New System.Drawing.Size(1426, 550)
        Me.XtraTabControl1.TabIndex = 5
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.AutoScroll = True
        Me.XtraTabPage1.Controls.Add(Me.llbAmountTaxpayerLastYear)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl32)
        Me.XtraTabPage1.Controls.Add(Me.txtAmountTaxPayable_LastYear)
        Me.XtraTabPage1.Controls.Add(Me.txtFirstInstallmentCount)
        Me.XtraTabPage1.Controls.Add(Me.cboYA_To_SME)
        Me.XtraTabPage1.Controls.Add(Me.cboYA_From_SME)
        Me.XtraTabPage1.Controls.Add(Me.cboState_Alt_Cor)
        Me.XtraTabPage1.Controls.Add(Me.cboState_Cor)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl28)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl29)
        Me.XtraTabPage1.Controls.Add(Me.txtCity_Alt_Cor)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl30)
        Me.XtraTabPage1.Controls.Add(Me.txtPostcode_Alt_Cor)
        Me.XtraTabPage1.Controls.Add(Me.txtAdd3_Alt_Cor)
        Me.XtraTabPage1.Controls.Add(Me.txtAdd2_Alt_Cor)
        Me.XtraTabPage1.Controls.Add(Me.txtAdd1_Alt_Cor)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl31)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl26)
        Me.XtraTabPage1.Controls.Add(Me.dtBasisPeriodSecEnd)
        Me.XtraTabPage1.Controls.Add(Me.dtBasisPeriodSecStart)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl27)
        Me.XtraTabPage1.Controls.Add(Me.dtBasisPeriodYAEnd)
        Me.XtraTabPage1.Controls.Add(Me.dtBasisPeriodYAStart)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl25)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl24)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl23)
        Me.XtraTabPage1.Controls.Add(Me.txtLastInstallment)
        Me.XtraTabPage1.Controls.Add(Me.txtFirstInstallment)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl22)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl21)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl20)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl19)
        Me.XtraTabPage1.Controls.Add(Me.rbPeriodEnded)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl18)
        Me.XtraTabPage1.Controls.Add(Me.dtCommencement)
        Me.XtraTabPage1.Controls.Add(Me.chkCommencement)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl17)
        Me.XtraTabPage1.Controls.Add(Me.chkSME)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl16)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl15)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl13)
        Me.XtraTabPage1.Controls.Add(Me.dtBasisPeriodEnd)
        Me.XtraTabPage1.Controls.Add(Me.dtBasisPeriodStart)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl14)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl12)
        Me.XtraTabPage1.Controls.Add(Me.dtAccEnd)
        Me.XtraTabPage1.Controls.Add(Me.dtAccStart)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage1.Controls.Add(Me.txtAmountTaxPayable)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage1.Controls.Add(Me.txtEstimationPercent)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl7)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage1.Controls.Add(Me.dtDate)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage1.Controls.Add(Me.txtCity_Cor)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage1.Controls.Add(Me.txtPostcode_Cor)
        Me.XtraTabPage1.Controls.Add(Me.txtAdd3_Cor)
        Me.XtraTabPage1.Controls.Add(Me.txtAdd2_Cor)
        Me.XtraTabPage1.Controls.Add(Me.txtAdd1_Cor)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1420, 522)
        Me.XtraTabPage1.Text = "CP204"
        '
        'llbAmountTaxpayerLastYear
        '
        Me.llbAmountTaxpayerLastYear.Location = New System.Drawing.Point(493, 184)
        Me.llbAmountTaxpayerLastYear.Name = "llbAmountTaxpayerLastYear"
        Me.llbAmountTaxpayerLastYear.Size = New System.Drawing.Size(55, 13)
        Me.llbAmountTaxpayerLastYear.TabIndex = 239
        Me.llbAmountTaxpayerLastYear.Text = ") Last year "
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(334, 184)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl32.TabIndex = 238
        Me.LabelControl32.Text = "("
        '
        'txtAmountTaxPayable_LastYear
        '
        Me.txtAmountTaxPayable_LastYear.Location = New System.Drawing.Point(344, 181)
        Me.txtAmountTaxPayable_LastYear.Name = "txtAmountTaxPayable_LastYear"
        Me.txtAmountTaxPayable_LastYear.Properties.DisplayFormat.FormatString = "n2"
        Me.txtAmountTaxPayable_LastYear.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountTaxPayable_LastYear.Properties.Mask.EditMask = "n2"
        Me.txtAmountTaxPayable_LastYear.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmountTaxPayable_LastYear.Properties.ReadOnly = True
        Me.txtAmountTaxPayable_LastYear.Size = New System.Drawing.Size(143, 20)
        Me.txtAmountTaxPayable_LastYear.TabIndex = 237
        '
        'txtFirstInstallmentCount
        '
        Me.txtFirstInstallmentCount.Location = New System.Drawing.Point(209, 393)
        Me.txtFirstInstallmentCount.Name = "txtFirstInstallmentCount"
        Me.txtFirstInstallmentCount.Properties.ReadOnly = True
        Me.txtFirstInstallmentCount.Size = New System.Drawing.Size(40, 20)
        Me.txtFirstInstallmentCount.TabIndex = 236
        '
        'cboYA_To_SME
        '
        Me.cboYA_To_SME.Enabled = False
        Me.cboYA_To_SME.Location = New System.Drawing.Point(590, 318)
        Me.cboYA_To_SME.Name = "cboYA_To_SME"
        Me.cboYA_To_SME.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboYA_To_SME.Properties.PopupSizeable = True
        Me.cboYA_To_SME.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboYA_To_SME.Size = New System.Drawing.Size(143, 20)
        Me.cboYA_To_SME.TabIndex = 235
        '
        'cboYA_From_SME
        '
        Me.cboYA_From_SME.Enabled = False
        Me.cboYA_From_SME.Location = New System.Drawing.Point(423, 318)
        Me.cboYA_From_SME.Name = "cboYA_From_SME"
        Me.cboYA_From_SME.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboYA_From_SME.Properties.PopupSizeable = True
        Me.cboYA_From_SME.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboYA_From_SME.Size = New System.Drawing.Size(143, 20)
        Me.cboYA_From_SME.TabIndex = 234
        '
        'cboState_Alt_Cor
        '
        Me.cboState_Alt_Cor.Location = New System.Drawing.Point(926, 240)
        Me.cboState_Alt_Cor.Name = "cboState_Alt_Cor"
        Me.cboState_Alt_Cor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboState_Alt_Cor.Properties.PopupSizeable = True
        Me.cboState_Alt_Cor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboState_Alt_Cor.Size = New System.Drawing.Size(351, 20)
        Me.cboState_Alt_Cor.TabIndex = 233
        '
        'cboState_Cor
        '
        Me.cboState_Cor.Location = New System.Drawing.Point(173, 119)
        Me.cboState_Cor.Name = "cboState_Cor"
        Me.cboState_Cor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboState_Cor.Properties.PopupSizeable = True
        Me.cboState_Cor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboState_Cor.Size = New System.Drawing.Size(351, 20)
        Me.cboState_Cor.TabIndex = 232
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(762, 243)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl28.TabIndex = 231
        Me.LabelControl28.Text = "State :"
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(1040, 219)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl29.TabIndex = 229
        Me.LabelControl29.Text = "City :"
        '
        'txtCity_Alt_Cor
        '
        Me.txtCity_Alt_Cor.Location = New System.Drawing.Point(1071, 216)
        Me.txtCity_Alt_Cor.Name = "txtCity_Alt_Cor"
        Me.txtCity_Alt_Cor.Size = New System.Drawing.Size(207, 20)
        Me.txtCity_Alt_Cor.TabIndex = 228
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(762, 219)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl30.TabIndex = 227
        Me.LabelControl30.Text = "Postal Code :"
        '
        'txtPostcode_Alt_Cor
        '
        Me.txtPostcode_Alt_Cor.Location = New System.Drawing.Point(926, 216)
        Me.txtPostcode_Alt_Cor.Name = "txtPostcode_Alt_Cor"
        Me.txtPostcode_Alt_Cor.Size = New System.Drawing.Size(89, 20)
        Me.txtPostcode_Alt_Cor.TabIndex = 226
        '
        'txtAdd3_Alt_Cor
        '
        Me.txtAdd3_Alt_Cor.Location = New System.Drawing.Point(926, 192)
        Me.txtAdd3_Alt_Cor.Name = "txtAdd3_Alt_Cor"
        Me.txtAdd3_Alt_Cor.Size = New System.Drawing.Size(351, 20)
        Me.txtAdd3_Alt_Cor.TabIndex = 225
        '
        'txtAdd2_Alt_Cor
        '
        Me.txtAdd2_Alt_Cor.Location = New System.Drawing.Point(926, 167)
        Me.txtAdd2_Alt_Cor.Name = "txtAdd2_Alt_Cor"
        Me.txtAdd2_Alt_Cor.Size = New System.Drawing.Size(351, 20)
        Me.txtAdd2_Alt_Cor.TabIndex = 224
        '
        'txtAdd1_Alt_Cor
        '
        Me.txtAdd1_Alt_Cor.Location = New System.Drawing.Point(926, 143)
        Me.txtAdd1_Alt_Cor.Name = "txtAdd1_Alt_Cor"
        Me.txtAdd1_Alt_Cor.Size = New System.Drawing.Size(351, 20)
        Me.txtAdd1_Alt_Cor.TabIndex = 223
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(762, 145)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(128, 13)
        Me.LabelControl31.TabIndex = 222
        Me.LabelControl31.Text = "Correspondence Address :"
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(1168, 98)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl26.TabIndex = 221
        Me.LabelControl26.Text = "To"
        '
        'dtBasisPeriodSecEnd
        '
        Me.dtBasisPeriodSecEnd.EditValue = Nothing
        Me.dtBasisPeriodSecEnd.Location = New System.Drawing.Point(1186, 95)
        Me.dtBasisPeriodSecEnd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtBasisPeriodSecEnd.MenuManager = Me.BarManager1
        Me.dtBasisPeriodSecEnd.Name = "dtBasisPeriodSecEnd"
        Me.dtBasisPeriodSecEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBasisPeriodSecEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBasisPeriodSecEnd.Size = New System.Drawing.Size(143, 20)
        Me.dtBasisPeriodSecEnd.TabIndex = 220
        '
        'dtBasisPeriodSecStart
        '
        Me.dtBasisPeriodSecStart.EditValue = Nothing
        Me.dtBasisPeriodSecStart.Location = New System.Drawing.Point(1020, 95)
        Me.dtBasisPeriodSecStart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtBasisPeriodSecStart.MenuManager = Me.BarManager1
        Me.dtBasisPeriodSecStart.Name = "dtBasisPeriodSecStart"
        Me.dtBasisPeriodSecStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBasisPeriodSecStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBasisPeriodSecStart.Size = New System.Drawing.Size(143, 20)
        Me.dtBasisPeriodSecStart.TabIndex = 219
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(1168, 61)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl27.TabIndex = 218
        Me.LabelControl27.Text = "To"
        '
        'dtBasisPeriodYAEnd
        '
        Me.dtBasisPeriodYAEnd.EditValue = Nothing
        Me.dtBasisPeriodYAEnd.Location = New System.Drawing.Point(1186, 58)
        Me.dtBasisPeriodYAEnd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtBasisPeriodYAEnd.MenuManager = Me.BarManager1
        Me.dtBasisPeriodYAEnd.Name = "dtBasisPeriodYAEnd"
        Me.dtBasisPeriodYAEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBasisPeriodYAEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBasisPeriodYAEnd.Size = New System.Drawing.Size(143, 20)
        Me.dtBasisPeriodYAEnd.TabIndex = 217
        '
        'dtBasisPeriodYAStart
        '
        Me.dtBasisPeriodYAStart.EditValue = Nothing
        Me.dtBasisPeriodYAStart.Location = New System.Drawing.Point(1019, 58)
        Me.dtBasisPeriodYAStart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtBasisPeriodYAStart.MenuManager = Me.BarManager1
        Me.dtBasisPeriodYAStart.Name = "dtBasisPeriodYAStart"
        Me.dtBasisPeriodYAStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBasisPeriodYAStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBasisPeriodYAStart.Size = New System.Drawing.Size(143, 20)
        Me.dtBasisPeriodYAStart.TabIndex = 216
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.Options.UseTextOptions = True
        Me.LabelControl25.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl25.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl25.Location = New System.Drawing.Point(781, 96)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(206, 30)
        Me.LabelControl25.TabIndex = 215
        Me.LabelControl25.Text = "7.2 Basis Period for the 2nd subsequent Year of Assessment"
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.Options.UseTextOptions = True
        Me.LabelControl24.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl24.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl24.Location = New System.Drawing.Point(781, 59)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(234, 30)
        Me.LabelControl24.TabIndex = 214
        Me.LabelControl24.Text = "7.1 Basis Period for the immediate following Year of Assessment"
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Options.UseTextOptions = True
        Me.LabelControl23.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl23.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl23.Location = New System.Drawing.Point(759, 23)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(545, 30)
        Me.LabelControl23.TabIndex = 213
        Me.LabelControl23.Text = "7. These columns are to be completed by new companies or if there are changes as " & _
    "a result of a change in the date of closing accounts"
        '
        'txtLastInstallment
        '
        Me.txtLastInstallment.Location = New System.Drawing.Point(513, 444)
        Me.txtLastInstallment.Name = "txtLastInstallment"
        Me.txtLastInstallment.Properties.DisplayFormat.FormatString = "n2"
        Me.txtLastInstallment.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtLastInstallment.Properties.Mask.EditMask = "n2"
        Me.txtLastInstallment.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtLastInstallment.Size = New System.Drawing.Size(143, 20)
        Me.txtLastInstallment.TabIndex = 212
        '
        'txtFirstInstallment
        '
        Me.txtFirstInstallment.Location = New System.Drawing.Point(513, 420)
        Me.txtFirstInstallment.Name = "txtFirstInstallment"
        Me.txtFirstInstallment.Properties.DisplayFormat.FormatString = "n2"
        Me.txtFirstInstallment.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFirstInstallment.Properties.Mask.EditMask = "n2"
        Me.txtFirstInstallment.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtFirstInstallment.Size = New System.Drawing.Size(143, 20)
        Me.txtFirstInstallment.TabIndex = 211
        '
        'LabelControl22
        '
        Me.LabelControl22.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl22.Location = New System.Drawing.Point(32, 447)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(111, 13)
        Me.LabelControl22.TabIndex = 210
        Me.LabelControl22.Text = "6.2 Last instalment"
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(32, 422)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(108, 13)
        Me.LabelControl21.TabIndex = 209
        Me.LabelControl21.Text = "6.1 First instalment to "
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(536, 396)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl20.TabIndex = 208
        Me.LabelControl20.Text = "Monthly Instalment"
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(9, 396)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(182, 13)
        Me.LabelControl19.TabIndex = 207
        Me.LabelControl19.Text = "6. Computation of Monthly Instalment"
        '
        'rbPeriodEnded
        '
        Me.rbPeriodEnded.Location = New System.Drawing.Point(423, 351)
        Me.rbPeriodEnded.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbPeriodEnded.MenuManager = Me.BarManager1
        Me.rbPeriodEnded.Name = "rbPeriodEnded"
        Me.rbPeriodEnded.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Yes"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "No")})
        Me.rbPeriodEnded.Size = New System.Drawing.Size(232, 21)
        Me.rbPeriodEnded.TabIndex = 206
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Options.UseTextOptions = True
        Me.LabelControl18.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl18.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl18.Location = New System.Drawing.Point(32, 348)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(386, 41)
        Me.LabelControl18.TabIndex = 205
        Me.LabelControl18.Text = "5.2 Indicate whether the accounts prepared for the period ended on the same date " & _
    "as reladted companies in the same group."
        '
        'dtCommencement
        '
        Me.dtCommencement.EditValue = Nothing
        Me.dtCommencement.Enabled = False
        Me.dtCommencement.Location = New System.Drawing.Point(590, 294)
        Me.dtCommencement.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtCommencement.MenuManager = Me.BarManager1
        Me.dtCommencement.Name = "dtCommencement"
        Me.dtCommencement.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtCommencement.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtCommencement.Size = New System.Drawing.Size(143, 20)
        Me.dtCommencement.TabIndex = 204
        '
        'chkCommencement
        '
        Me.chkCommencement.Location = New System.Drawing.Point(572, 295)
        Me.chkCommencement.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkCommencement.MenuManager = Me.BarManager1
        Me.chkCommencement.Name = "chkCommencement"
        Me.chkCommencement.Properties.Caption = ""
        Me.chkCommencement.Size = New System.Drawing.Size(15, 19)
        Me.chkCommencement.TabIndex = 203
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(572, 320)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl17.TabIndex = 200
        Me.LabelControl17.Text = "To"
        '
        'chkSME
        '
        Me.chkSME.Location = New System.Drawing.Point(393, 318)
        Me.chkSME.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkSME.MenuManager = Me.BarManager1
        Me.chkSME.Name = "chkSME"
        Me.chkSME.Properties.Caption = ""
        Me.chkSME.Size = New System.Drawing.Size(26, 19)
        Me.chkSME.TabIndex = 198
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(32, 320)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(206, 13)
        Me.LabelControl16.TabIndex = 197
        Me.LabelControl16.Text = "5.1 SME status only companies that qualify"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(9, 297)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(315, 13)
        Me.LabelControl15.TabIndex = 195
        Me.LabelControl15.Text = "5. New Company: state the date of commencement of operations"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(572, 274)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl13.TabIndex = 194
        Me.LabelControl13.Text = "To"
        '
        'dtBasisPeriodEnd
        '
        Me.dtBasisPeriodEnd.EditValue = Nothing
        Me.dtBasisPeriodEnd.Location = New System.Drawing.Point(590, 271)
        Me.dtBasisPeriodEnd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtBasisPeriodEnd.MenuManager = Me.BarManager1
        Me.dtBasisPeriodEnd.Name = "dtBasisPeriodEnd"
        Me.dtBasisPeriodEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBasisPeriodEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBasisPeriodEnd.Size = New System.Drawing.Size(143, 20)
        Me.dtBasisPeriodEnd.TabIndex = 193
        '
        'dtBasisPeriodStart
        '
        Me.dtBasisPeriodStart.EditValue = Nothing
        Me.dtBasisPeriodStart.Location = New System.Drawing.Point(423, 271)
        Me.dtBasisPeriodStart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtBasisPeriodStart.MenuManager = Me.BarManager1
        Me.dtBasisPeriodStart.Name = "dtBasisPeriodStart"
        Me.dtBasisPeriodStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBasisPeriodStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBasisPeriodStart.Size = New System.Drawing.Size(143, 20)
        Me.dtBasisPeriodStart.TabIndex = 192
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(9, 274)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl14.TabIndex = 191
        Me.LabelControl14.Text = "4. Basis Period"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(572, 251)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl12.TabIndex = 190
        Me.LabelControl12.Text = "To"
        '
        'dtAccEnd
        '
        Me.dtAccEnd.EditValue = Nothing
        Me.dtAccEnd.Location = New System.Drawing.Point(590, 249)
        Me.dtAccEnd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtAccEnd.MenuManager = Me.BarManager1
        Me.dtAccEnd.Name = "dtAccEnd"
        Me.dtAccEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtAccEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtAccEnd.Size = New System.Drawing.Size(143, 20)
        Me.dtAccEnd.TabIndex = 189
        '
        'dtAccStart
        '
        Me.dtAccStart.EditValue = Nothing
        Me.dtAccStart.Location = New System.Drawing.Point(423, 249)
        Me.dtAccStart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtAccStart.MenuManager = Me.BarManager1
        Me.dtAccStart.Name = "dtAccStart"
        Me.dtAccStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtAccStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtAccStart.Size = New System.Drawing.Size(143, 20)
        Me.dtAccStart.TabIndex = 188
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(9, 251)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(99, 13)
        Me.LabelControl9.TabIndex = 187
        Me.LabelControl9.Text = "3. Accounting Period"
        '
        'txtAmountTaxPayable
        '
        Me.txtAmountTaxPayable.Location = New System.Drawing.Point(173, 181)
        Me.txtAmountTaxPayable.Name = "txtAmountTaxPayable"
        Me.txtAmountTaxPayable.Properties.DisplayFormat.FormatString = "n2"
        Me.txtAmountTaxPayable.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountTaxPayable.Properties.Mask.EditMask = "n2"
        Me.txtAmountTaxPayable.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmountTaxPayable.Size = New System.Drawing.Size(143, 20)
        Me.txtAmountTaxPayable.TabIndex = 186
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(227, 215)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(227, 13)
        Me.LabelControl8.TabIndex = 185
        Me.LabelControl8.Text = "% of the estimantion from immediate prior year"
        '
        'txtEstimationPercent
        '
        Me.txtEstimationPercent.Location = New System.Drawing.Point(145, 213)
        Me.txtEstimationPercent.Name = "txtEstimationPercent"
        Me.txtEstimationPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtEstimationPercent.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtEstimationPercent.Properties.Appearance.Options.UseBackColor = True
        Me.txtEstimationPercent.Properties.Appearance.Options.UseForeColor = True
        Me.txtEstimationPercent.Properties.ReadOnly = True
        Me.txtEstimationPercent.Size = New System.Drawing.Size(77, 20)
        Me.txtEstimationPercent.TabIndex = 184
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(32, 215)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(103, 13)
        Me.LabelControl6.TabIndex = 183
        Me.LabelControl6.Text = "2.1 This estimation is "
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(9, 184)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(122, 13)
        Me.LabelControl7.TabIndex = 182
        Me.LabelControl7.Text = "2. Estimated Tax Payable"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(9, 145)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl5.TabIndex = 180
        Me.LabelControl5.Text = "Date : "
        '
        'dtDate
        '
        Me.dtDate.EditValue = Nothing
        Me.dtDate.Location = New System.Drawing.Point(173, 143)
        Me.dtDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtDate.MenuManager = Me.BarManager1
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDate.Size = New System.Drawing.Size(143, 20)
        Me.dtDate.TabIndex = 179
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(9, 122)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl4.TabIndex = 178
        Me.LabelControl4.Text = "State :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(287, 98)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl3.TabIndex = 176
        Me.LabelControl3.Text = "City :"
        '
        'txtCity_Cor
        '
        Me.txtCity_Cor.Location = New System.Drawing.Point(318, 95)
        Me.txtCity_Cor.Name = "txtCity_Cor"
        Me.txtCity_Cor.Size = New System.Drawing.Size(207, 20)
        Me.txtCity_Cor.TabIndex = 175
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(9, 98)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl2.TabIndex = 174
        Me.LabelControl2.Text = "Postal Code :"
        '
        'txtPostcode_Cor
        '
        Me.txtPostcode_Cor.Location = New System.Drawing.Point(173, 95)
        Me.txtPostcode_Cor.Name = "txtPostcode_Cor"
        Me.txtPostcode_Cor.Size = New System.Drawing.Size(89, 20)
        Me.txtPostcode_Cor.TabIndex = 173
        '
        'txtAdd3_Cor
        '
        Me.txtAdd3_Cor.Location = New System.Drawing.Point(173, 71)
        Me.txtAdd3_Cor.Name = "txtAdd3_Cor"
        Me.txtAdd3_Cor.Size = New System.Drawing.Size(351, 20)
        Me.txtAdd3_Cor.TabIndex = 172
        '
        'txtAdd2_Cor
        '
        Me.txtAdd2_Cor.Location = New System.Drawing.Point(173, 46)
        Me.txtAdd2_Cor.Name = "txtAdd2_Cor"
        Me.txtAdd2_Cor.Size = New System.Drawing.Size(351, 20)
        Me.txtAdd2_Cor.TabIndex = 171
        '
        'txtAdd1_Cor
        '
        Me.txtAdd1_Cor.Location = New System.Drawing.Point(173, 22)
        Me.txtAdd1_Cor.Name = "txtAdd1_Cor"
        Me.txtAdd1_Cor.Size = New System.Drawing.Size(351, 20)
        Me.txtAdd1_Cor.TabIndex = 170
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(9, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(128, 13)
        Me.LabelControl1.TabIndex = 167
        Me.LabelControl1.Text = "Correspondence Address :"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridControl1)
        Me.XtraTabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1420, 522)
        Me.XtraTabPage2.Text = "Monthly Instalment Breakdown"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl1.DataSource = Me.BORANGCP204TRICORBREAKDOWNBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtNote, Me.RepositoryItemTextEdit3, Me.chkAddBack, Me.cboDate})
        Me.GridControl1.Size = New System.Drawing.Size(1420, 522)
        Me.GridControl1.TabIndex = 192
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplyPaymentToolStripMenuItem, Me.ClearPaymentToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(156, 48)
        '
        'ApplyPaymentToolStripMenuItem
        '
        Me.ApplyPaymentToolStripMenuItem.Name = "ApplyPaymentToolStripMenuItem"
        Me.ApplyPaymentToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ApplyPaymentToolStripMenuItem.Text = "Apply Payment"
        '
        'ClearPaymentToolStripMenuItem
        '
        Me.ClearPaymentToolStripMenuItem.Name = "ClearPaymentToolStripMenuItem"
        Me.ClearPaymentToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ClearPaymentToolStripMenuItem.Text = "Clear Payment"
        '
        'BORANGCP204TRICORBREAKDOWNBindingSource
        '
        Me.BORANGCP204TRICORBREAKDOWNBindingSource.DataMember = "BORANG_CP204_TRICOR_BREAKDOWN"
        Me.BORANGCP204TRICORBREAKDOWNBindingSource.DataSource = Me.DsCP204
        '
        'DsCP204
        '
        Me.DsCP204.DataSetName = "dsCP204"
        Me.DsCP204.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCP_ID, Me.colCP_PARENTID, Me.colCP_INSTALL_NO, Me.colCP_PAYMENT_DUE, Me.colCP_INSTALLMENT_AMOUNT, Me.colCP_PAYMENT_DATE_1, Me.colCP_AMOUNT_PAID_1, Me.colCP_PAYMENT_DATE_2, Me.colCP_AMOUNT_PAID_2, Me.colCP_PENALTY, Me.colCP_NOTE_TITLE, Me.colCP_NOTE, Me.colCP_TagID})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsPrint.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsPrint.PrintPreview = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCP_INSTALL_NO, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCP_ID
        '
        Me.colCP_ID.FieldName = "CP_ID"
        Me.colCP_ID.Name = "colCP_ID"
        '
        'colCP_PARENTID
        '
        Me.colCP_PARENTID.FieldName = "CP_PARENTID"
        Me.colCP_PARENTID.Name = "colCP_PARENTID"
        '
        'colCP_INSTALL_NO
        '
        Me.colCP_INSTALL_NO.Caption = "Install No"
        Me.colCP_INSTALL_NO.FieldName = "CP_INSTALL_NO"
        Me.colCP_INSTALL_NO.Name = "colCP_INSTALL_NO"
        Me.colCP_INSTALL_NO.OptionsColumn.AllowEdit = False
        Me.colCP_INSTALL_NO.OptionsColumn.TabStop = False
        Me.colCP_INSTALL_NO.Visible = True
        Me.colCP_INSTALL_NO.VisibleIndex = 0
        Me.colCP_INSTALL_NO.Width = 80
        '
        'colCP_PAYMENT_DUE
        '
        Me.colCP_PAYMENT_DUE.Caption = "Payment Due"
        Me.colCP_PAYMENT_DUE.ColumnEdit = Me.cboDate
        Me.colCP_PAYMENT_DUE.FieldName = "CP_PAYMENT_DUE"
        Me.colCP_PAYMENT_DUE.Name = "colCP_PAYMENT_DUE"
        Me.colCP_PAYMENT_DUE.Visible = True
        Me.colCP_PAYMENT_DUE.VisibleIndex = 1
        Me.colCP_PAYMENT_DUE.Width = 120
        '
        'cboDate
        '
        Me.cboDate.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.cboDate.AutoHeight = False
        Me.cboDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDate.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDate.Name = "cboDate"
        '
        'colCP_INSTALLMENT_AMOUNT
        '
        Me.colCP_INSTALLMENT_AMOUNT.Caption = "Installment Amount (RM)"
        Me.colCP_INSTALLMENT_AMOUNT.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colCP_INSTALLMENT_AMOUNT.FieldName = "CP_INSTALLMENT_AMOUNT"
        Me.colCP_INSTALLMENT_AMOUNT.Name = "colCP_INSTALLMENT_AMOUNT"
        Me.colCP_INSTALLMENT_AMOUNT.OptionsColumn.AllowEdit = False
        Me.colCP_INSTALLMENT_AMOUNT.OptionsColumn.TabStop = False
        Me.colCP_INSTALLMENT_AMOUNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CP_INSTALLMENT_AMOUNT", "SUM={0:0.##}")})
        Me.colCP_INSTALLMENT_AMOUNT.Visible = True
        Me.colCP_INSTALLMENT_AMOUNT.VisibleIndex = 2
        Me.colCP_INSTALLMENT_AMOUNT.Width = 150
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatString = "n2"
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit3.EditFormat.FormatString = "n2"
        Me.RepositoryItemTextEdit3.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit3.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'colCP_PAYMENT_DATE_1
        '
        Me.colCP_PAYMENT_DATE_1.Caption = "Payment Date 1"
        Me.colCP_PAYMENT_DATE_1.ColumnEdit = Me.cboDate
        Me.colCP_PAYMENT_DATE_1.FieldName = "CP_PAYMENT_DATE_1"
        Me.colCP_PAYMENT_DATE_1.Name = "colCP_PAYMENT_DATE_1"
        Me.colCP_PAYMENT_DATE_1.Visible = True
        Me.colCP_PAYMENT_DATE_1.VisibleIndex = 3
        Me.colCP_PAYMENT_DATE_1.Width = 120
        '
        'colCP_AMOUNT_PAID_1
        '
        Me.colCP_AMOUNT_PAID_1.Caption = "Amount Paid (RM)"
        Me.colCP_AMOUNT_PAID_1.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colCP_AMOUNT_PAID_1.FieldName = "CP_AMOUNT_PAID_1"
        Me.colCP_AMOUNT_PAID_1.Name = "colCP_AMOUNT_PAID_1"
        Me.colCP_AMOUNT_PAID_1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CP_AMOUNT_PAID_1", "SUM={0:0.##}")})
        Me.colCP_AMOUNT_PAID_1.Visible = True
        Me.colCP_AMOUNT_PAID_1.VisibleIndex = 4
        Me.colCP_AMOUNT_PAID_1.Width = 150
        '
        'colCP_PAYMENT_DATE_2
        '
        Me.colCP_PAYMENT_DATE_2.Caption = "Payment Date 2"
        Me.colCP_PAYMENT_DATE_2.ColumnEdit = Me.cboDate
        Me.colCP_PAYMENT_DATE_2.FieldName = "CP_PAYMENT_DATE_2"
        Me.colCP_PAYMENT_DATE_2.Name = "colCP_PAYMENT_DATE_2"
        Me.colCP_PAYMENT_DATE_2.Visible = True
        Me.colCP_PAYMENT_DATE_2.VisibleIndex = 5
        Me.colCP_PAYMENT_DATE_2.Width = 120
        '
        'colCP_AMOUNT_PAID_2
        '
        Me.colCP_AMOUNT_PAID_2.Caption = "Amount Paid (RM)"
        Me.colCP_AMOUNT_PAID_2.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colCP_AMOUNT_PAID_2.FieldName = "CP_AMOUNT_PAID_2"
        Me.colCP_AMOUNT_PAID_2.Name = "colCP_AMOUNT_PAID_2"
        Me.colCP_AMOUNT_PAID_2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CP_AMOUNT_PAID_2", "SUM={0:0.##}")})
        Me.colCP_AMOUNT_PAID_2.Visible = True
        Me.colCP_AMOUNT_PAID_2.VisibleIndex = 6
        Me.colCP_AMOUNT_PAID_2.Width = 150
        '
        'colCP_PENALTY
        '
        Me.colCP_PENALTY.Caption = "Penalty (RM)"
        Me.colCP_PENALTY.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colCP_PENALTY.FieldName = "CP_PENALTY"
        Me.colCP_PENALTY.Name = "colCP_PENALTY"
        Me.colCP_PENALTY.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CP_PENALTY", "SUM={0:0.##}")})
        Me.colCP_PENALTY.Visible = True
        Me.colCP_PENALTY.VisibleIndex = 7
        Me.colCP_PENALTY.Width = 150
        '
        'colCP_NOTE_TITLE
        '
        Me.colCP_NOTE_TITLE.Caption = "Note Title"
        Me.colCP_NOTE_TITLE.FieldName = "CP_NOTE_TITLE"
        Me.colCP_NOTE_TITLE.Name = "colCP_NOTE_TITLE"
        Me.colCP_NOTE_TITLE.Visible = True
        Me.colCP_NOTE_TITLE.VisibleIndex = 8
        Me.colCP_NOTE_TITLE.Width = 200
        '
        'colCP_NOTE
        '
        Me.colCP_NOTE.Caption = "Note"
        Me.colCP_NOTE.FieldName = "CP_NOTE"
        Me.colCP_NOTE.Name = "colCP_NOTE"
        Me.colCP_NOTE.Visible = True
        Me.colCP_NOTE.VisibleIndex = 9
        Me.colCP_NOTE.Width = 350
        '
        'colCP_TagID
        '
        Me.colCP_TagID.FieldName = "CP_TagID"
        Me.colCP_TagID.Name = "colCP_TagID"
        Me.colCP_TagID.Visible = True
        Me.colCP_TagID.VisibleIndex = 10
        '
        'txtNote
        '
        Me.txtNote.MaxLength = 3000
        Me.txtNote.Name = "txtNote"
        '
        'chkAddBack
        '
        Me.chkAddBack.AutoHeight = False
        Me.chkAddBack.Caption = "Add Back"
        Me.chkAddBack.Name = "chkAddBack"
        Me.chkAddBack.ValueGrayed = True
        '
        'frmCP204_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1426, 682)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmCP204_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estimated Tax Payable For Companies"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtCurrAvaiblePayment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefRegistrationNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.txtAmountTaxPayable_LastYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFirstInstallmentCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYA_To_SME.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYA_From_SME.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboState_Alt_Cor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboState_Cor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCity_Alt_Cor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPostcode_Alt_Cor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdd3_Alt_Cor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdd2_Alt_Cor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdd1_Alt_Cor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBasisPeriodSecEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBasisPeriodSecEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBasisPeriodSecStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBasisPeriodSecStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBasisPeriodYAEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBasisPeriodYAEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBasisPeriodYAStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBasisPeriodYAStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLastInstallment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFirstInstallment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbPeriodEnded.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCommencement.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCommencement.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCommencement.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSME.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBasisPeriodEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBasisPeriodEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBasisPeriodStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBasisPeriodStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtAccEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtAccEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtAccStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtAccStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmountTaxPayable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstimationPercent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCity_Cor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPostcode_Cor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdd3_Cor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdd2_Cor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdd1_Cor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.BORANGCP204TRICORBREAKDOWNBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCP204, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAddBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkSME As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtBasisPeriodEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtBasisPeriodStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtAccEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmountTaxPayable As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCity_Cor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPostcode_Cor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAdd3_Cor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAdd2_Cor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAdd1_Cor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRefRegistrationNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRefNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboYA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkCommencement As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rbPeriodEnded As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtCommencement As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCity_Alt_Cor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPostcode_Alt_Cor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAdd3_Alt_Cor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAdd2_Alt_Cor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAdd1_Alt_Cor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtBasisPeriodSecEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtBasisPeriodSecStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtBasisPeriodYAEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtBasisPeriodYAStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLastInstallment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFirstInstallment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtAccStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cboState_Alt_Cor As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboState_Cor As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TaxPayerFindBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsDefault As EasyTemplate_Taxcom.dsDefault
    Friend WithEvents cboYA_To_SME As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboYA_From_SME As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtFirstInstallmentCount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEstimationPercent As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCP_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCP_PARENTID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCP_INSTALL_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCP_PAYMENT_DUE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colCP_INSTALLMENT_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colCP_PAYMENT_DATE_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCP_AMOUNT_PAID_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCP_PAYMENT_DATE_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCP_AMOUNT_PAID_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCP_PENALTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCP_NOTE_TITLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCP_NOTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNote As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents chkAddBack As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents BORANGCP204TRICORBREAKDOWNBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsCP204 As EasyTemplate_Taxcom.dsCP204
    Friend WithEvents llbAmountTaxpayerLastYear As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmountTaxPayable_LastYear As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cboRefNo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRefNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHandleBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployerNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCurrAvaiblePayment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ApplyPaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearPaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportGenerator1 As DevExpress.XtraReports.ReportGeneration.ReportGenerator
    Friend WithEvents btnRefreshMonthlyBreakdown As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnNote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colCP_TagID As DevExpress.XtraGrid.Columns.GridColumn
End Class
