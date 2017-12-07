<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisposal_Add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDisposal_Add))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.cboSourceCode = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSearchVal = New DevExpress.XtraEditors.TextEdit()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.cboSearchFor = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.CABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCA = New EasyTemplate_Taxcom.dsCA()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCA_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_MODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_PREFIX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_FILENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_COMPANY_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_ASSET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_ASSET_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_CATEGORY_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_PURCHASE_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_PURCHASE_YEAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_PURCHASE_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_PAYMENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_RESTRICTED_QC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_RATE_IA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_RATE_AA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_QUALIFYING_COST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_REMAIN_QC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_TWDV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_INCENTIVE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_REF_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_YA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_CTRL_TRANSFER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_ACCELERATED = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_CAEEO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_REC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_DEFERREDCLAIM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_DEDUCTADJ_INCOME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_TAX_FILE_NUMBER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_TRANSFERROR_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_TRANSFER_VAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCompanyCode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFileNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cboYA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtTaxPayer = New DevExpress.XtraEditors.TextEdit()
        Me.TaxPayerFindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.XtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.txtAccumulated = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.pnlControlTransfer = New DevExpress.XtraEditors.PanelControl()
        Me.txtTaxFileNumber = New DevExpress.XtraEditors.TextEdit()
        Me.txtTransfereeName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.cboTypeDisposal = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotal_QC = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txtHP_Code = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.chkControlTransfer = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDispose_QC = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDisposal_Remarks = New DevExpress.XtraEditors.MemoEdit()
        Me.txtDisposal_BABC = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisposal_SalesProceed = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisposal_TWDV = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisposal_RemainingQuaCost = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisposal_PurchaseAmount = New DevExpress.XtraEditors.TextEdit()
        Me.rgWithIn2YA = New DevExpress.XtraEditors.RadioGroup()
        Me.dtDisposal = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl()
        Me.lblTitle_FA = New DevExpress.XtraEditors.LabelControl()
        Me.lblTitle_CA = New DevExpress.XtraEditors.LabelControl()
        Me.cboAA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtTWDV = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemainingQualifyingCost = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNonQualifyingCost = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.txtQualifyingCost = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.cboIncentive = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIA = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescription = New DevExpress.XtraEditors.MemoEdit()
        Me.dtDateofPurchase = New DevExpress.XtraEditors.DateEdit()
        Me.cboCategory = New DevExpress.XtraEditors.LookUpEdit()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRestrictedQua = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDeposit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPurchaseAmountFA = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAssetID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAsset = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
        Me.Document2 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
        Me.cboRefNo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRefNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHandleBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployerNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyCode = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.cboSourceCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSearchVal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSearchFor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCompanyCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTaxPayer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel3.SuspendLayout()
        Me.DockPanel3_Container.SuspendLayout()
        Me.XtraScrollableControl1.SuspendLayout()
        CType(Me.txtAccumulated.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlControlTransfer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControlTransfer.SuspendLayout()
        CType(Me.txtTaxFileNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransfereeName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTypeDisposal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal_QC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHP_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkControlTransfer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDispose_QC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisposal_Remarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisposal_BABC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisposal_SalesProceed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisposal_TWDV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisposal_RemainingQuaCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisposal_PurchaseAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgWithIn2YA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDisposal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDisposal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTWDV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemainingQualifyingCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNonQualifyingCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQualifyingCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboIncentive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateofPurchase.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateofPurchase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRestrictedQua.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeposit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPurchaseAmountFA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAssetID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAsset.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Document2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSave, Me.btnClose})
        Me.BarManager1.MaxItemId = 9
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemSpinEdit1})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSave), New DevExpress.XtraBars.LinkPersistInfo(Me.btnClose)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None
        Me.Bar1.OptionsBar.DisableClose = True
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Glyph = CType(resources.GetObject("btnSave.Glyph"), System.Drawing.Image)
        Me.btnSave.Id = 0
        Me.btnSave.LargeGlyph = CType(resources.GetObject("btnSave.LargeGlyph"), System.Drawing.Image)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnClose
        '
        Me.btnClose.Caption = "Close"
        Me.btnClose.Glyph = CType(resources.GetObject("btnClose.Glyph"), System.Drawing.Image)
        Me.btnClose.Id = 2
        Me.btnClose.LargeGlyph = CType(resources.GetObject("btnClose.LargeGlyph"), System.Drawing.Image)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1364, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 627)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1364, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 596)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1364, 31)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 596)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1, Me.DockPanel3})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("cf5d0d36-80e9-46d6-8bcf-eb14b421f7cc")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 31)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(441, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(441, 596)
        Me.DockPanel1.Text = "Tax Payer Information"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.cboRefNo)
        Me.DockPanel1_Container.Controls.Add(Me.cboSourceCode)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl7)
        Me.DockPanel1_Container.Controls.Add(Me.txtSearchVal)
        Me.DockPanel1_Container.Controls.Add(Me.btnSearch)
        Me.DockPanel1_Container.Controls.Add(Me.cboSearchFor)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl6)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl5)
        Me.DockPanel1_Container.Controls.Add(Me.GridControl1)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl28)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl1)
        Me.DockPanel1_Container.Controls.Add(Me.txtCompanyCode)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl2)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl27)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl4)
        Me.DockPanel1_Container.Controls.Add(Me.txtFileNo)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl3)
        Me.DockPanel1_Container.Controls.Add(Me.cboYA)
        Me.DockPanel1_Container.Controls.Add(Me.txtTaxPayer)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(433, 569)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'cboSourceCode
        '
        Me.cboSourceCode.Location = New System.Drawing.Point(135, 139)
        Me.cboSourceCode.Name = "cboSourceCode"
        Me.cboSourceCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSourceCode.Size = New System.Drawing.Size(280, 20)
        Me.cboSourceCode.TabIndex = 204
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(8, 142)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl7.TabIndex = 205
        Me.LabelControl7.Text = "Source Code :"
        '
        'txtSearchVal
        '
        Me.txtSearchVal.Location = New System.Drawing.Point(176, 197)
        Me.txtSearchVal.MenuManager = Me.BarManager1
        Me.txtSearchVal.Name = "txtSearchVal"
        Me.txtSearchVal.Size = New System.Drawing.Size(206, 20)
        Me.txtSearchVal.TabIndex = 203
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(388, 195)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(27, 23)
        Me.btnSearch.TabIndex = 202
        '
        'cboSearchFor
        '
        Me.cboSearchFor.Location = New System.Drawing.Point(54, 197)
        Me.cboSearchFor.Name = "cboSearchFor"
        Me.cboSearchFor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSearchFor.Properties.Items.AddRange(New Object() {"All Records", "Asset", "Asset Code", "Purchase Y/E", "HP Code", "Category Code", "CA Key"})
        Me.cboSearchFor.Properties.PopupSizeable = True
        Me.cboSearchFor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboSearchFor.Size = New System.Drawing.Size(116, 20)
        Me.cboSearchFor.TabIndex = 201
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(8, 200)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl6.TabIndex = 200
        Me.LabelControl6.Text = "Search :"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(8, 174)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(137, 13)
        Me.LabelControl5.TabIndex = 199
        Me.LabelControl5.Text = "Select Capital Allowance"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.CABindingSource
        Me.GridControl1.Location = New System.Drawing.Point(3, 224)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(427, 335)
        Me.GridControl1.TabIndex = 198
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'CABindingSource
        '
        Me.CABindingSource.DataMember = "CA"
        Me.CABindingSource.DataSource = Me.DsCA
        '
        'DsCA
        '
        Me.DsCA.DataSetName = "dsCA"
        Me.DsCA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCA_KEY, Me.colCA_MODE, Me.colCA_PREFIX, Me.colCA_FILENO, Me.colCA_COMPANY_CODE, Me.colCA_ASSET, Me.colCA_ASSET_CODE, Me.colCA_CATEGORY_CODE, Me.colCA_PURCHASE_DATE, Me.colCA_PURCHASE_YEAR, Me.colCA_PURCHASE_AMOUNT, Me.colCA_PAYMENT, Me.colCA_RESTRICTED_QC, Me.colCA_DESC, Me.colCA_RATE_IA, Me.colCA_RATE_AA, Me.colCA_QUALIFYING_COST, Me.colCA_REMAIN_QC, Me.colCA_TWDV, Me.colCA_INCENTIVE, Me.colCA_REF_NO, Me.colCA_NAME, Me.colCA_YA, Me.colCA_SOURCENO, Me.colCA_CTRL_TRANSFER, Me.colHP_CODE, Me.colCA_ACCELERATED, Me.colCA_CAEEO, Me.colCA_REC, Me.colCA_DEFERREDCLAIM, Me.colCA_DEDUCTADJ_INCOME, Me.colCA_TAX_FILE_NUMBER, Me.colCA_TRANSFERROR_NAME, Me.colCA_TRANSFER_VAL})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'colCA_KEY
        '
        Me.colCA_KEY.Caption = "No"
        Me.colCA_KEY.FieldName = "CA_KEY"
        Me.colCA_KEY.Name = "colCA_KEY"
        Me.colCA_KEY.Visible = True
        Me.colCA_KEY.VisibleIndex = 0
        '
        'colCA_MODE
        '
        Me.colCA_MODE.FieldName = "CA_MODE"
        Me.colCA_MODE.Name = "colCA_MODE"
        '
        'colCA_PREFIX
        '
        Me.colCA_PREFIX.FieldName = "CA_PREFIX"
        Me.colCA_PREFIX.Name = "colCA_PREFIX"
        '
        'colCA_FILENO
        '
        Me.colCA_FILENO.FieldName = "CA_FILENO"
        Me.colCA_FILENO.Name = "colCA_FILENO"
        '
        'colCA_COMPANY_CODE
        '
        Me.colCA_COMPANY_CODE.FieldName = "CA_COMPANY_CODE"
        Me.colCA_COMPANY_CODE.Name = "colCA_COMPANY_CODE"
        '
        'colCA_ASSET
        '
        Me.colCA_ASSET.Caption = "Asset"
        Me.colCA_ASSET.FieldName = "CA_ASSET"
        Me.colCA_ASSET.Name = "colCA_ASSET"
        Me.colCA_ASSET.Visible = True
        Me.colCA_ASSET.VisibleIndex = 1
        Me.colCA_ASSET.Width = 150
        '
        'colCA_ASSET_CODE
        '
        Me.colCA_ASSET_CODE.Caption = "Asset Code"
        Me.colCA_ASSET_CODE.FieldName = "CA_ASSET_CODE"
        Me.colCA_ASSET_CODE.Name = "colCA_ASSET_CODE"
        Me.colCA_ASSET_CODE.Visible = True
        Me.colCA_ASSET_CODE.VisibleIndex = 2
        Me.colCA_ASSET_CODE.Width = 150
        '
        'colCA_CATEGORY_CODE
        '
        Me.colCA_CATEGORY_CODE.Caption = "Category"
        Me.colCA_CATEGORY_CODE.FieldName = "CA_CATEGORY_CODE"
        Me.colCA_CATEGORY_CODE.Name = "colCA_CATEGORY_CODE"
        Me.colCA_CATEGORY_CODE.Visible = True
        Me.colCA_CATEGORY_CODE.VisibleIndex = 3
        Me.colCA_CATEGORY_CODE.Width = 150
        '
        'colCA_PURCHASE_DATE
        '
        Me.colCA_PURCHASE_DATE.Caption = "Purchase Date"
        Me.colCA_PURCHASE_DATE.FieldName = "CA_PURCHASE_DATE"
        Me.colCA_PURCHASE_DATE.Name = "colCA_PURCHASE_DATE"
        Me.colCA_PURCHASE_DATE.Visible = True
        Me.colCA_PURCHASE_DATE.VisibleIndex = 4
        Me.colCA_PURCHASE_DATE.Width = 150
        '
        'colCA_PURCHASE_YEAR
        '
        Me.colCA_PURCHASE_YEAR.FieldName = "CA_PURCHASE_YEAR"
        Me.colCA_PURCHASE_YEAR.Name = "colCA_PURCHASE_YEAR"
        '
        'colCA_PURCHASE_AMOUNT
        '
        Me.colCA_PURCHASE_AMOUNT.Caption = "Purchase Amount"
        Me.colCA_PURCHASE_AMOUNT.FieldName = "CA_PURCHASE_AMOUNT"
        Me.colCA_PURCHASE_AMOUNT.Name = "colCA_PURCHASE_AMOUNT"
        Me.colCA_PURCHASE_AMOUNT.Visible = True
        Me.colCA_PURCHASE_AMOUNT.VisibleIndex = 5
        Me.colCA_PURCHASE_AMOUNT.Width = 150
        '
        'colCA_PAYMENT
        '
        Me.colCA_PAYMENT.Caption = "Deposit"
        Me.colCA_PAYMENT.FieldName = "CA_PAYMENT"
        Me.colCA_PAYMENT.Name = "colCA_PAYMENT"
        Me.colCA_PAYMENT.Visible = True
        Me.colCA_PAYMENT.VisibleIndex = 6
        Me.colCA_PAYMENT.Width = 150
        '
        'colCA_RESTRICTED_QC
        '
        Me.colCA_RESTRICTED_QC.Caption = "Restricted QC"
        Me.colCA_RESTRICTED_QC.FieldName = "CA_RESTRICTED_QC"
        Me.colCA_RESTRICTED_QC.Name = "colCA_RESTRICTED_QC"
        Me.colCA_RESTRICTED_QC.Visible = True
        Me.colCA_RESTRICTED_QC.VisibleIndex = 7
        Me.colCA_RESTRICTED_QC.Width = 150
        '
        'colCA_DESC
        '
        Me.colCA_DESC.Caption = "Description"
        Me.colCA_DESC.FieldName = "CA_DESC"
        Me.colCA_DESC.Name = "colCA_DESC"
        Me.colCA_DESC.Visible = True
        Me.colCA_DESC.VisibleIndex = 8
        Me.colCA_DESC.Width = 150
        '
        'colCA_RATE_IA
        '
        Me.colCA_RATE_IA.Caption = "Rate IA"
        Me.colCA_RATE_IA.FieldName = "CA_RATE_IA"
        Me.colCA_RATE_IA.Name = "colCA_RATE_IA"
        Me.colCA_RATE_IA.Visible = True
        Me.colCA_RATE_IA.VisibleIndex = 9
        Me.colCA_RATE_IA.Width = 150
        '
        'colCA_RATE_AA
        '
        Me.colCA_RATE_AA.Caption = "Rate AA"
        Me.colCA_RATE_AA.FieldName = "CA_RATE_AA"
        Me.colCA_RATE_AA.Name = "colCA_RATE_AA"
        Me.colCA_RATE_AA.Visible = True
        Me.colCA_RATE_AA.VisibleIndex = 10
        Me.colCA_RATE_AA.Width = 150
        '
        'colCA_QUALIFYING_COST
        '
        Me.colCA_QUALIFYING_COST.Caption = "Qualifying Cost"
        Me.colCA_QUALIFYING_COST.FieldName = "CA_QUALIFYING_COST"
        Me.colCA_QUALIFYING_COST.Name = "colCA_QUALIFYING_COST"
        Me.colCA_QUALIFYING_COST.Visible = True
        Me.colCA_QUALIFYING_COST.VisibleIndex = 11
        Me.colCA_QUALIFYING_COST.Width = 150
        '
        'colCA_REMAIN_QC
        '
        Me.colCA_REMAIN_QC.Caption = "Remaining Cost"
        Me.colCA_REMAIN_QC.FieldName = "CA_REMAIN_QC"
        Me.colCA_REMAIN_QC.Name = "colCA_REMAIN_QC"
        Me.colCA_REMAIN_QC.Visible = True
        Me.colCA_REMAIN_QC.VisibleIndex = 12
        Me.colCA_REMAIN_QC.Width = 150
        '
        'colCA_TWDV
        '
        Me.colCA_TWDV.Caption = "TWDV"
        Me.colCA_TWDV.FieldName = "CA_TWDV"
        Me.colCA_TWDV.Name = "colCA_TWDV"
        Me.colCA_TWDV.Visible = True
        Me.colCA_TWDV.VisibleIndex = 13
        Me.colCA_TWDV.Width = 150
        '
        'colCA_INCENTIVE
        '
        Me.colCA_INCENTIVE.Caption = "Incentive"
        Me.colCA_INCENTIVE.FieldName = "CA_INCENTIVE"
        Me.colCA_INCENTIVE.Name = "colCA_INCENTIVE"
        Me.colCA_INCENTIVE.Visible = True
        Me.colCA_INCENTIVE.VisibleIndex = 14
        Me.colCA_INCENTIVE.Width = 150
        '
        'colCA_REF_NO
        '
        Me.colCA_REF_NO.Caption = "Reference No"
        Me.colCA_REF_NO.FieldName = "CA_REF_NO"
        Me.colCA_REF_NO.Name = "colCA_REF_NO"
        Me.colCA_REF_NO.Visible = True
        Me.colCA_REF_NO.VisibleIndex = 15
        Me.colCA_REF_NO.Width = 150
        '
        'colCA_NAME
        '
        Me.colCA_NAME.Caption = "Company Name"
        Me.colCA_NAME.FieldName = "CA_NAME"
        Me.colCA_NAME.Name = "colCA_NAME"
        Me.colCA_NAME.Visible = True
        Me.colCA_NAME.VisibleIndex = 16
        Me.colCA_NAME.Width = 150
        '
        'colCA_YA
        '
        Me.colCA_YA.Caption = "YA"
        Me.colCA_YA.FieldName = "CA_YA"
        Me.colCA_YA.Name = "colCA_YA"
        Me.colCA_YA.Visible = True
        Me.colCA_YA.VisibleIndex = 18
        Me.colCA_YA.Width = 100
        '
        'colCA_SOURCENO
        '
        Me.colCA_SOURCENO.Caption = "Source No"
        Me.colCA_SOURCENO.FieldName = "CA_SOURCENO"
        Me.colCA_SOURCENO.Name = "colCA_SOURCENO"
        Me.colCA_SOURCENO.Visible = True
        Me.colCA_SOURCENO.VisibleIndex = 19
        Me.colCA_SOURCENO.Width = 100
        '
        'colCA_CTRL_TRANSFER
        '
        Me.colCA_CTRL_TRANSFER.FieldName = "CA_CTRL_TRANSFER"
        Me.colCA_CTRL_TRANSFER.Name = "colCA_CTRL_TRANSFER"
        '
        'colHP_CODE
        '
        Me.colHP_CODE.FieldName = "HP_CODE"
        Me.colHP_CODE.Name = "colHP_CODE"
        Me.colHP_CODE.Visible = True
        Me.colHP_CODE.VisibleIndex = 17
        '
        'colCA_ACCELERATED
        '
        Me.colCA_ACCELERATED.FieldName = "CA_ACCELERATED"
        Me.colCA_ACCELERATED.Name = "colCA_ACCELERATED"
        '
        'colCA_CAEEO
        '
        Me.colCA_CAEEO.FieldName = "CA_CAEEO"
        Me.colCA_CAEEO.Name = "colCA_CAEEO"
        '
        'colCA_REC
        '
        Me.colCA_REC.FieldName = "CA_REC"
        Me.colCA_REC.Name = "colCA_REC"
        '
        'colCA_DEFERREDCLAIM
        '
        Me.colCA_DEFERREDCLAIM.FieldName = "CA_DEFERREDCLAIM"
        Me.colCA_DEFERREDCLAIM.Name = "colCA_DEFERREDCLAIM"
        '
        'colCA_DEDUCTADJ_INCOME
        '
        Me.colCA_DEDUCTADJ_INCOME.FieldName = "CA_DEDUCTADJ_INCOME"
        Me.colCA_DEDUCTADJ_INCOME.Name = "colCA_DEDUCTADJ_INCOME"
        '
        'colCA_TAX_FILE_NUMBER
        '
        Me.colCA_TAX_FILE_NUMBER.FieldName = "CA_TAX_FILE_NUMBER"
        Me.colCA_TAX_FILE_NUMBER.Name = "colCA_TAX_FILE_NUMBER"
        '
        'colCA_TRANSFERROR_NAME
        '
        Me.colCA_TRANSFERROR_NAME.FieldName = "CA_TRANSFERROR_NAME"
        Me.colCA_TRANSFERROR_NAME.Name = "colCA_TRANSFERROR_NAME"
        '
        'colCA_TRANSFER_VAL
        '
        Me.colCA_TRANSFER_VAL.FieldName = "CA_TRANSFER_VAL"
        Me.colCA_TRANSFER_VAL.Name = "colCA_TRANSFER_VAL"
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(8, 92)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl28.TabIndex = 197
        Me.LabelControl28.Text = "Company Code :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(8, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl1.TabIndex = 186
        Me.LabelControl1.Text = "Reference No :"
        '
        'txtCompanyCode
        '
        Me.txtCompanyCode.Location = New System.Drawing.Point(135, 89)
        Me.txtCompanyCode.Name = "txtCompanyCode"
        Me.txtCompanyCode.Properties.ReadOnly = True
        Me.txtCompanyCode.Size = New System.Drawing.Size(280, 20)
        Me.txtCompanyCode.TabIndex = 196
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(8, 43)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl2.TabIndex = 187
        Me.LabelControl2.Text = "Tax Payer :"
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(8, 66)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl27.TabIndex = 195
        Me.LabelControl27.Text = "File No :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(122, 17)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(7, 13)
        Me.LabelControl4.TabIndex = 189
        Me.LabelControl4.Text = "C"
        '
        'txtFileNo
        '
        Me.txtFileNo.Location = New System.Drawing.Point(135, 63)
        Me.txtFileNo.Name = "txtFileNo"
        Me.txtFileNo.Properties.ReadOnly = True
        Me.txtFileNo.Size = New System.Drawing.Size(280, 20)
        Me.txtFileNo.TabIndex = 194
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(8, 116)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl3.TabIndex = 188
        Me.LabelControl3.Text = "Year Of Assessment :"
        '
        'cboYA
        '
        Me.cboYA.Location = New System.Drawing.Point(135, 113)
        Me.cboYA.Name = "cboYA"
        Me.cboYA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboYA.Properties.PopupSizeable = True
        Me.cboYA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboYA.Size = New System.Drawing.Size(280, 20)
        Me.cboYA.TabIndex = 182
        '
        'txtTaxPayer
        '
        Me.txtTaxPayer.Location = New System.Drawing.Point(135, 40)
        Me.txtTaxPayer.Name = "txtTaxPayer"
        Me.txtTaxPayer.Properties.ReadOnly = True
        Me.txtTaxPayer.Size = New System.Drawing.Size(280, 20)
        Me.txtTaxPayer.TabIndex = 190
        '
        'TaxPayerFindBindingSource
        '
        Me.TaxPayerFindBindingSource.DataMember = "TaxPayerFind"
        Me.TaxPayerFindBindingSource.DataSource = Me.DsCA
        '
        'DockPanel3
        '
        Me.DockPanel3.Controls.Add(Me.DockPanel3_Container)
        Me.DockPanel3.DockedAsTabbedDocument = True
        Me.DockPanel3.Enabled = False
        Me.DockPanel3.FloatLocation = New System.Drawing.Point(487, 190)
        Me.DockPanel3.ID = New System.Guid("ff397a35-8ee2-4be7-9263-f4ef69906b13")
        Me.DockPanel3.Name = "DockPanel3"
        Me.DockPanel3.Options.ShowCloseButton = False
        Me.DockPanel3.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel3.SavedIndex = 2
        Me.DockPanel3.SavedMdiDocument = True
        Me.DockPanel3.Text = "Fixed Asset And Capital Allowance Information"
        '
        'DockPanel3_Container
        '
        Me.DockPanel3_Container.Controls.Add(Me.XtraScrollableControl1)
        Me.DockPanel3_Container.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel3_Container.Name = "DockPanel3_Container"
        Me.DockPanel3_Container.Size = New System.Drawing.Size(917, 568)
        Me.DockPanel3_Container.TabIndex = 0
        '
        'XtraScrollableControl1
        '
        Me.XtraScrollableControl1.Controls.Add(Me.txtAccumulated)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl29)
        Me.XtraScrollableControl1.Controls.Add(Me.pnlControlTransfer)
        Me.XtraScrollableControl1.Controls.Add(Me.cboTypeDisposal)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl26)
        Me.XtraScrollableControl1.Controls.Add(Me.txtTotal_QC)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl20)
        Me.XtraScrollableControl1.Controls.Add(Me.txtHP_Code)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl17)
        Me.XtraScrollableControl1.Controls.Add(Me.chkControlTransfer)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl8)
        Me.XtraScrollableControl1.Controls.Add(Me.txtDispose_QC)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl41)
        Me.XtraScrollableControl1.Controls.Add(Me.txtDisposal_Remarks)
        Me.XtraScrollableControl1.Controls.Add(Me.txtDisposal_BABC)
        Me.XtraScrollableControl1.Controls.Add(Me.txtDisposal_SalesProceed)
        Me.XtraScrollableControl1.Controls.Add(Me.txtDisposal_TWDV)
        Me.XtraScrollableControl1.Controls.Add(Me.txtDisposal_RemainingQuaCost)
        Me.XtraScrollableControl1.Controls.Add(Me.txtDisposal_PurchaseAmount)
        Me.XtraScrollableControl1.Controls.Add(Me.rgWithIn2YA)
        Me.XtraScrollableControl1.Controls.Add(Me.dtDisposal)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl33)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl34)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl35)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl36)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl37)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl38)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl39)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl40)
        Me.XtraScrollableControl1.Controls.Add(Me.lblTitle_FA)
        Me.XtraScrollableControl1.Controls.Add(Me.lblTitle_CA)
        Me.XtraScrollableControl1.Controls.Add(Me.cboAA)
        Me.XtraScrollableControl1.Controls.Add(Me.txtTWDV)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl24)
        Me.XtraScrollableControl1.Controls.Add(Me.txtRemainingQualifyingCost)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl23)
        Me.XtraScrollableControl1.Controls.Add(Me.txtNonQualifyingCost)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl22)
        Me.XtraScrollableControl1.Controls.Add(Me.txtQualifyingCost)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl21)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl19)
        Me.XtraScrollableControl1.Controls.Add(Me.cboIncentive)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl18)
        Me.XtraScrollableControl1.Controls.Add(Me.txtIA)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl16)
        Me.XtraScrollableControl1.Controls.Add(Me.txtDescription)
        Me.XtraScrollableControl1.Controls.Add(Me.dtDateofPurchase)
        Me.XtraScrollableControl1.Controls.Add(Me.cboCategory)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl25)
        Me.XtraScrollableControl1.Controls.Add(Me.txtRestrictedQua)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl15)
        Me.XtraScrollableControl1.Controls.Add(Me.txtDeposit)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl14)
        Me.XtraScrollableControl1.Controls.Add(Me.txtPurchaseAmountFA)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl13)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl12)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl11)
        Me.XtraScrollableControl1.Controls.Add(Me.txtAssetID)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl10)
        Me.XtraScrollableControl1.Controls.Add(Me.txtAsset)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl9)
        Me.XtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraScrollableControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraScrollableControl1.Name = "XtraScrollableControl1"
        Me.XtraScrollableControl1.Size = New System.Drawing.Size(917, 568)
        Me.XtraScrollableControl1.TabIndex = 315
        '
        'txtAccumulated
        '
        Me.txtAccumulated.Location = New System.Drawing.Point(655, 196)
        Me.txtAccumulated.Name = "txtAccumulated"
        Me.txtAccumulated.Properties.DisplayFormat.FormatString = "n"
        Me.txtAccumulated.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAccumulated.Properties.Mask.EditMask = "n"
        Me.txtAccumulated.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAccumulated.Properties.NullText = "0"
        Me.txtAccumulated.Properties.NullValuePrompt = "0"
        Me.txtAccumulated.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAccumulated.Size = New System.Drawing.Size(203, 20)
        Me.txtAccumulated.TabIndex = 375
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(469, 199)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(150, 13)
        Me.LabelControl29.TabIndex = 374
        Me.LabelControl29.Text = "Accumulated Depreciation (RM)"
        '
        'pnlControlTransfer
        '
        Me.pnlControlTransfer.Controls.Add(Me.txtTaxFileNumber)
        Me.pnlControlTransfer.Controls.Add(Me.txtTransfereeName)
        Me.pnlControlTransfer.Controls.Add(Me.LabelControl30)
        Me.pnlControlTransfer.Controls.Add(Me.LabelControl31)
        Me.pnlControlTransfer.Location = New System.Drawing.Point(467, 427)
        Me.pnlControlTransfer.Name = "pnlControlTransfer"
        Me.pnlControlTransfer.Size = New System.Drawing.Size(426, 71)
        Me.pnlControlTransfer.TabIndex = 373
        Me.pnlControlTransfer.Visible = False
        '
        'txtTaxFileNumber
        '
        Me.txtTaxFileNumber.Location = New System.Drawing.Point(188, 37)
        Me.txtTaxFileNumber.Name = "txtTaxFileNumber"
        Me.txtTaxFileNumber.Size = New System.Drawing.Size(211, 20)
        Me.txtTaxFileNumber.TabIndex = 230
        '
        'txtTransfereeName
        '
        Me.txtTransfereeName.Location = New System.Drawing.Point(188, 11)
        Me.txtTransfereeName.Name = "txtTransfereeName"
        Me.txtTransfereeName.Size = New System.Drawing.Size(211, 20)
        Me.txtTransfereeName.TabIndex = 229
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(5, 40)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl30.TabIndex = 227
        Me.LabelControl30.Text = "Tax File Number"
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(5, 14)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl31.TabIndex = 226
        Me.LabelControl31.Text = "Transferee Name :"
        '
        'cboTypeDisposal
        '
        Me.cboTypeDisposal.Location = New System.Drawing.Point(655, 31)
        Me.cboTypeDisposal.MenuManager = Me.BarManager1
        Me.cboTypeDisposal.Name = "cboTypeDisposal"
        Me.cboTypeDisposal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTypeDisposal.Properties.Items.AddRange(New Object() {"Disposal", "Writen off", "Control Transfer Out"})
        Me.cboTypeDisposal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboTypeDisposal.Size = New System.Drawing.Size(210, 20)
        Me.cboTypeDisposal.TabIndex = 372
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(469, 34)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl26.TabIndex = 371
        Me.LabelControl26.Text = "Type of Disposal"
        '
        'txtTotal_QC
        '
        Me.txtTotal_QC.Location = New System.Drawing.Point(212, 537)
        Me.txtTotal_QC.Name = "txtTotal_QC"
        Me.txtTotal_QC.Properties.ReadOnly = True
        Me.txtTotal_QC.Size = New System.Drawing.Size(211, 20)
        Me.txtTotal_QC.TabIndex = 369
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(17, 540)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl20.TabIndex = 370
        Me.LabelControl20.Text = "Total QC"
        '
        'txtHP_Code
        '
        Me.txtHP_Code.Location = New System.Drawing.Point(193, 215)
        Me.txtHP_Code.Name = "txtHP_Code"
        Me.txtHP_Code.Properties.ReadOnly = True
        Me.txtHP_Code.Size = New System.Drawing.Size(230, 20)
        Me.txtHP_Code.TabIndex = 367
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(17, 218)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl17.TabIndex = 368
        Me.LabelControl17.Text = "HP Code :"
        '
        'chkControlTransfer
        '
        Me.chkControlTransfer.Location = New System.Drawing.Point(302, 516)
        Me.chkControlTransfer.Name = "chkControlTransfer"
        Me.chkControlTransfer.Properties.Caption = "Control Transfer"
        Me.chkControlTransfer.Size = New System.Drawing.Size(121, 19)
        Me.chkControlTransfer.TabIndex = 366
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(468, 145)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(141, 13)
        Me.LabelControl8.TabIndex = 365
        Me.LabelControl8.Text = "Disposal Qualifying Cost (RM)"
        '
        'txtDispose_QC
        '
        Me.txtDispose_QC.Location = New System.Drawing.Point(655, 142)
        Me.txtDispose_QC.Name = "txtDispose_QC"
        Me.txtDispose_QC.Properties.DisplayFormat.FormatString = "n"
        Me.txtDispose_QC.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDispose_QC.Properties.Mask.EditMask = "n"
        Me.txtDispose_QC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDispose_QC.Properties.NullText = "0"
        Me.txtDispose_QC.Properties.NullValuePrompt = "0"
        Me.txtDispose_QC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDispose_QC.Size = New System.Drawing.Size(203, 20)
        Me.txtDispose_QC.TabIndex = 364
        '
        'LabelControl41
        '
        Me.LabelControl41.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl41.Location = New System.Drawing.Point(468, 3)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(170, 19)
        Me.LabelControl41.TabIndex = 363
        Me.LabelControl41.Text = "Disposal Information"
        '
        'txtDisposal_Remarks
        '
        Me.txtDisposal_Remarks.Location = New System.Drawing.Point(655, 320)
        Me.txtDisposal_Remarks.MenuManager = Me.BarManager1
        Me.txtDisposal_Remarks.Name = "txtDisposal_Remarks"
        Me.txtDisposal_Remarks.Size = New System.Drawing.Size(238, 101)
        Me.txtDisposal_Remarks.TabIndex = 362
        '
        'txtDisposal_BABC
        '
        Me.txtDisposal_BABC.Location = New System.Drawing.Point(655, 278)
        Me.txtDisposal_BABC.Name = "txtDisposal_BABC"
        Me.txtDisposal_BABC.Properties.DisplayFormat.FormatString = "n"
        Me.txtDisposal_BABC.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisposal_BABC.Properties.EditFormat.FormatString = "n"
        Me.txtDisposal_BABC.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisposal_BABC.Properties.Mask.EditMask = "n"
        Me.txtDisposal_BABC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDisposal_BABC.Properties.NullText = "0"
        Me.txtDisposal_BABC.Properties.NullValuePrompt = "0"
        Me.txtDisposal_BABC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDisposal_BABC.Size = New System.Drawing.Size(203, 20)
        Me.txtDisposal_BABC.TabIndex = 361
        '
        'txtDisposal_SalesProceed
        '
        Me.txtDisposal_SalesProceed.Location = New System.Drawing.Point(655, 252)
        Me.txtDisposal_SalesProceed.Name = "txtDisposal_SalesProceed"
        Me.txtDisposal_SalesProceed.Properties.DisplayFormat.FormatString = "n"
        Me.txtDisposal_SalesProceed.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisposal_SalesProceed.Properties.Mask.EditMask = "n"
        Me.txtDisposal_SalesProceed.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDisposal_SalesProceed.Properties.NullText = "0"
        Me.txtDisposal_SalesProceed.Properties.NullValuePrompt = "0"
        Me.txtDisposal_SalesProceed.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDisposal_SalesProceed.Size = New System.Drawing.Size(203, 20)
        Me.txtDisposal_SalesProceed.TabIndex = 360
        '
        'txtDisposal_TWDV
        '
        Me.txtDisposal_TWDV.Location = New System.Drawing.Point(655, 226)
        Me.txtDisposal_TWDV.Name = "txtDisposal_TWDV"
        Me.txtDisposal_TWDV.Properties.DisplayFormat.FormatString = "n"
        Me.txtDisposal_TWDV.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisposal_TWDV.Properties.Mask.EditMask = "n"
        Me.txtDisposal_TWDV.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDisposal_TWDV.Properties.NullText = "0"
        Me.txtDisposal_TWDV.Properties.NullValuePrompt = "0"
        Me.txtDisposal_TWDV.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDisposal_TWDV.Size = New System.Drawing.Size(203, 20)
        Me.txtDisposal_TWDV.TabIndex = 359
        '
        'txtDisposal_RemainingQuaCost
        '
        Me.txtDisposal_RemainingQuaCost.Location = New System.Drawing.Point(655, 168)
        Me.txtDisposal_RemainingQuaCost.Name = "txtDisposal_RemainingQuaCost"
        Me.txtDisposal_RemainingQuaCost.Properties.DisplayFormat.FormatString = "n"
        Me.txtDisposal_RemainingQuaCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisposal_RemainingQuaCost.Properties.Mask.EditMask = "n"
        Me.txtDisposal_RemainingQuaCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDisposal_RemainingQuaCost.Properties.NullText = "0"
        Me.txtDisposal_RemainingQuaCost.Properties.NullValuePrompt = "0"
        Me.txtDisposal_RemainingQuaCost.Properties.ReadOnly = True
        Me.txtDisposal_RemainingQuaCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDisposal_RemainingQuaCost.Size = New System.Drawing.Size(203, 20)
        Me.txtDisposal_RemainingQuaCost.TabIndex = 358
        '
        'txtDisposal_PurchaseAmount
        '
        Me.txtDisposal_PurchaseAmount.Location = New System.Drawing.Point(655, 116)
        Me.txtDisposal_PurchaseAmount.Name = "txtDisposal_PurchaseAmount"
        Me.txtDisposal_PurchaseAmount.Properties.DisplayFormat.FormatString = "n"
        Me.txtDisposal_PurchaseAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisposal_PurchaseAmount.Properties.Mask.EditMask = "n"
        Me.txtDisposal_PurchaseAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDisposal_PurchaseAmount.Properties.NullText = "0"
        Me.txtDisposal_PurchaseAmount.Properties.NullValuePrompt = "0"
        Me.txtDisposal_PurchaseAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDisposal_PurchaseAmount.Size = New System.Drawing.Size(203, 20)
        Me.txtDisposal_PurchaseAmount.TabIndex = 357
        '
        'rgWithIn2YA
        '
        Me.rgWithIn2YA.EditValue = False
        Me.rgWithIn2YA.Location = New System.Drawing.Point(655, 83)
        Me.rgWithIn2YA.MenuManager = Me.BarManager1
        Me.rgWithIn2YA.Name = "rgWithIn2YA"
        Me.rgWithIn2YA.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Yes"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "No")})
        Me.rgWithIn2YA.Size = New System.Drawing.Size(143, 27)
        Me.rgWithIn2YA.TabIndex = 356
        '
        'dtDisposal
        '
        Me.dtDisposal.EditValue = Nothing
        Me.dtDisposal.Location = New System.Drawing.Point(655, 57)
        Me.dtDisposal.MenuManager = Me.BarManager1
        Me.dtDisposal.Name = "dtDisposal"
        Me.dtDisposal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDisposal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDisposal.Size = New System.Drawing.Size(210, 20)
        Me.dtDisposal.TabIndex = 355
        '
        'LabelControl33
        '
        Me.LabelControl33.Location = New System.Drawing.Point(467, 320)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl33.TabIndex = 354
        Me.LabelControl33.Text = "Remarks"
        '
        'LabelControl34
        '
        Me.LabelControl34.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl34.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl34.Location = New System.Drawing.Point(467, 281)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(152, 33)
        Me.LabelControl34.TabIndex = 353
        Me.LabelControl34.Text = "(Balancing Allowance) / Balancing Charges (RM)"
        '
        'LabelControl35
        '
        Me.LabelControl35.Location = New System.Drawing.Point(469, 255)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl35.TabIndex = 352
        Me.LabelControl35.Text = "Sales Proceed (RM)"
        '
        'LabelControl36
        '
        Me.LabelControl36.Location = New System.Drawing.Point(472, 229)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl36.TabIndex = 351
        Me.LabelControl36.Text = "TWDV (RM)"
        '
        'LabelControl37
        '
        Me.LabelControl37.Location = New System.Drawing.Point(468, 171)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(151, 13)
        Me.LabelControl37.TabIndex = 350
        Me.LabelControl37.Text = "Remaining Qualifying Cost (RM)"
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(468, 119)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(152, 13)
        Me.LabelControl38.TabIndex = 349
        Me.LabelControl38.Text = "Disposal Purchase Amount (RM)"
        '
        'LabelControl39
        '
        Me.LabelControl39.Location = New System.Drawing.Point(469, 90)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(128, 13)
        Me.LabelControl39.TabIndex = 348
        Me.LabelControl39.Text = "Within 2 Years (Claw back)"
        '
        'LabelControl40
        '
        Me.LabelControl40.Location = New System.Drawing.Point(468, 60)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl40.TabIndex = 347
        Me.LabelControl40.Text = "Date of Disposal"
        '
        'lblTitle_FA
        '
        Me.lblTitle_FA.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle_FA.Location = New System.Drawing.Point(17, 4)
        Me.lblTitle_FA.Name = "lblTitle_FA"
        Me.lblTitle_FA.Size = New System.Drawing.Size(196, 19)
        Me.lblTitle_FA.TabIndex = 346
        Me.lblTitle_FA.Text = "Fixed Asset Information"
        '
        'lblTitle_CA
        '
        Me.lblTitle_CA.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle_CA.Location = New System.Drawing.Point(17, 306)
        Me.lblTitle_CA.Name = "lblTitle_CA"
        Me.lblTitle_CA.Size = New System.Drawing.Size(249, 19)
        Me.lblTitle_CA.TabIndex = 345
        Me.lblTitle_CA.Text = "Capital Allowance Information"
        '
        'cboAA
        '
        Me.cboAA.Location = New System.Drawing.Point(212, 360)
        Me.cboAA.Name = "cboAA"
        Me.cboAA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAA.Properties.Items.AddRange(New Object() {"0", "2", "3", "8", "10", "12", "14", "16", "20", "40", "50", "60", "80", "90", "100"})
        Me.cboAA.Properties.ReadOnly = True
        Me.cboAA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboAA.Size = New System.Drawing.Size(211, 20)
        Me.cboAA.TabIndex = 332
        '
        'txtTWDV
        '
        Me.txtTWDV.Location = New System.Drawing.Point(212, 490)
        Me.txtTWDV.Name = "txtTWDV"
        Me.txtTWDV.Properties.DisplayFormat.FormatString = "n"
        Me.txtTWDV.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTWDV.Properties.Mask.EditMask = "n"
        Me.txtTWDV.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTWDV.Properties.NullText = "0"
        Me.txtTWDV.Properties.NullValuePrompt = "0"
        Me.txtTWDV.Properties.ReadOnly = True
        Me.txtTWDV.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTWDV.Size = New System.Drawing.Size(211, 20)
        Me.txtTWDV.TabIndex = 337
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(17, 493)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl24.TabIndex = 344
        Me.LabelControl24.Text = "TWDV :"
        '
        'txtRemainingQualifyingCost
        '
        Me.txtRemainingQualifyingCost.Location = New System.Drawing.Point(212, 464)
        Me.txtRemainingQualifyingCost.Name = "txtRemainingQualifyingCost"
        Me.txtRemainingQualifyingCost.Properties.DisplayFormat.FormatString = "n"
        Me.txtRemainingQualifyingCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtRemainingQualifyingCost.Properties.Mask.EditMask = "n"
        Me.txtRemainingQualifyingCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRemainingQualifyingCost.Properties.NullText = "0"
        Me.txtRemainingQualifyingCost.Properties.NullValuePrompt = "0"
        Me.txtRemainingQualifyingCost.Properties.ReadOnly = True
        Me.txtRemainingQualifyingCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtRemainingQualifyingCost.Size = New System.Drawing.Size(211, 20)
        Me.txtRemainingQualifyingCost.TabIndex = 336
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(17, 467)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(158, 13)
        Me.LabelControl23.TabIndex = 343
        Me.LabelControl23.Text = "Remaining Qualifying Cost (RM) :"
        '
        'txtNonQualifyingCost
        '
        Me.txtNonQualifyingCost.Location = New System.Drawing.Point(212, 438)
        Me.txtNonQualifyingCost.Name = "txtNonQualifyingCost"
        Me.txtNonQualifyingCost.Properties.DisplayFormat.FormatString = "n"
        Me.txtNonQualifyingCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNonQualifyingCost.Properties.Mask.EditMask = "n"
        Me.txtNonQualifyingCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNonQualifyingCost.Properties.NullText = "0"
        Me.txtNonQualifyingCost.Properties.NullValuePrompt = "0"
        Me.txtNonQualifyingCost.Properties.ReadOnly = True
        Me.txtNonQualifyingCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNonQualifyingCost.Size = New System.Drawing.Size(211, 20)
        Me.txtNonQualifyingCost.TabIndex = 335
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(17, 441)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(128, 13)
        Me.LabelControl22.TabIndex = 342
        Me.LabelControl22.Text = "Non Qualifying Cost (RM) :"
        '
        'txtQualifyingCost
        '
        Me.txtQualifyingCost.Location = New System.Drawing.Point(212, 412)
        Me.txtQualifyingCost.Name = "txtQualifyingCost"
        Me.txtQualifyingCost.Properties.DisplayFormat.FormatString = "n"
        Me.txtQualifyingCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtQualifyingCost.Properties.Mask.EditMask = "n"
        Me.txtQualifyingCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtQualifyingCost.Properties.NullText = "0"
        Me.txtQualifyingCost.Properties.NullValuePrompt = "0"
        Me.txtQualifyingCost.Properties.ReadOnly = True
        Me.txtQualifyingCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtQualifyingCost.Size = New System.Drawing.Size(211, 20)
        Me.txtQualifyingCost.TabIndex = 334
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(17, 415)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(106, 13)
        Me.LabelControl21.TabIndex = 341
        Me.LabelControl21.Text = "Qualifying Cost (RM) :"
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(17, 389)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl19.TabIndex = 340
        Me.LabelControl19.Text = "Incentive :"
        '
        'cboIncentive
        '
        Me.cboIncentive.Location = New System.Drawing.Point(212, 386)
        Me.cboIncentive.Name = "cboIncentive"
        Me.cboIncentive.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboIncentive.Properties.Items.AddRange(New Object() {"", "RA", "ITA"})
        Me.cboIncentive.Properties.ReadOnly = True
        Me.cboIncentive.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboIncentive.Size = New System.Drawing.Size(211, 20)
        Me.cboIncentive.TabIndex = 333
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(17, 363)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl18.TabIndex = 339
        Me.LabelControl18.Text = "AA Rate (%) :"
        '
        'txtIA
        '
        Me.txtIA.Location = New System.Drawing.Point(212, 334)
        Me.txtIA.Name = "txtIA"
        Me.txtIA.Properties.DisplayFormat.FormatString = "f0"
        Me.txtIA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtIA.Properties.EditFormat.FormatString = "f0"
        Me.txtIA.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtIA.Properties.Mask.EditMask = "f0"
        Me.txtIA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtIA.Properties.NullText = "0"
        Me.txtIA.Properties.NullValuePrompt = "0"
        Me.txtIA.Properties.ReadOnly = True
        Me.txtIA.Size = New System.Drawing.Size(211, 20)
        Me.txtIA.TabIndex = 331
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(17, 337)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl16.TabIndex = 338
        Me.LabelControl16.Text = "IA Rate (%) :"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(193, 241)
        Me.txtDescription.MenuManager = Me.BarManager1
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(230, 59)
        Me.txtDescription.TabIndex = 322
        '
        'dtDateofPurchase
        '
        Me.dtDateofPurchase.EditValue = Nothing
        Me.dtDateofPurchase.Location = New System.Drawing.Point(193, 110)
        Me.dtDateofPurchase.MenuManager = Me.BarManager1
        Me.dtDateofPurchase.Name = "dtDateofPurchase"
        Me.dtDateofPurchase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDateofPurchase.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDateofPurchase.Properties.ReadOnly = True
        Me.dtDateofPurchase.Size = New System.Drawing.Size(230, 20)
        Me.dtDateofPurchase.TabIndex = 318
        '
        'cboCategory
        '
        Me.cboCategory.Location = New System.Drawing.Point(193, 84)
        Me.cboCategory.MenuManager = Me.BarManager1
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCategory.Properties.DataSource = Me.CategoryBindingSource
        Me.cboCategory.Properties.DisplayMember = "CA_CODE"
        Me.cboCategory.Properties.ReadOnly = True
        Me.cboCategory.Properties.ValueMember = "CA_CODE"
        Me.cboCategory.Size = New System.Drawing.Size(230, 20)
        Me.cboCategory.TabIndex = 317
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.DsCA
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(17, 244)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl25.TabIndex = 330
        Me.LabelControl25.Text = "Description/Note :"
        '
        'txtRestrictedQua
        '
        Me.txtRestrictedQua.Location = New System.Drawing.Point(193, 189)
        Me.txtRestrictedQua.Name = "txtRestrictedQua"
        Me.txtRestrictedQua.Properties.DisplayFormat.FormatString = "n"
        Me.txtRestrictedQua.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtRestrictedQua.Properties.Mask.EditMask = "n"
        Me.txtRestrictedQua.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRestrictedQua.Properties.NullText = "0"
        Me.txtRestrictedQua.Properties.NullValuePrompt = "0"
        Me.txtRestrictedQua.Properties.ReadOnly = True
        Me.txtRestrictedQua.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtRestrictedQua.Size = New System.Drawing.Size(230, 20)
        Me.txtRestrictedQua.TabIndex = 321
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(17, 192)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(132, 13)
        Me.LabelControl15.TabIndex = 329
        Me.LabelControl15.Text = "Restricted Qualifying Cost :"
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(193, 163)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Properties.DisplayFormat.FormatString = "n"
        Me.txtDeposit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDeposit.Properties.Mask.EditMask = "n"
        Me.txtDeposit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDeposit.Properties.NullText = "0"
        Me.txtDeposit.Properties.NullValuePrompt = "0"
        Me.txtDeposit.Properties.ReadOnly = True
        Me.txtDeposit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDeposit.Size = New System.Drawing.Size(230, 20)
        Me.txtDeposit.TabIndex = 320
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(17, 166)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(118, 13)
        Me.LabelControl14.TabIndex = 328
        Me.LabelControl14.Text = "Deposit/ Payment (RM) :"
        '
        'txtPurchaseAmountFA
        '
        Me.txtPurchaseAmountFA.Location = New System.Drawing.Point(193, 137)
        Me.txtPurchaseAmountFA.Name = "txtPurchaseAmountFA"
        Me.txtPurchaseAmountFA.Properties.DisplayFormat.FormatString = "n"
        Me.txtPurchaseAmountFA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPurchaseAmountFA.Properties.Mask.EditMask = "n"
        Me.txtPurchaseAmountFA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPurchaseAmountFA.Properties.NullText = "0"
        Me.txtPurchaseAmountFA.Properties.NullValuePrompt = "0"
        Me.txtPurchaseAmountFA.Properties.ReadOnly = True
        Me.txtPurchaseAmountFA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPurchaseAmountFA.Size = New System.Drawing.Size(230, 20)
        Me.txtPurchaseAmountFA.TabIndex = 319
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(17, 140)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(117, 13)
        Me.LabelControl13.TabIndex = 327
        Me.LabelControl13.Text = "Purchase Amount (RM) :"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(17, 114)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl12.TabIndex = 326
        Me.LabelControl12.Text = "Date of Purchase :"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(17, 87)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl11.TabIndex = 325
        Me.LabelControl11.Text = "Category Code :"
        '
        'txtAssetID
        '
        Me.txtAssetID.Location = New System.Drawing.Point(193, 58)
        Me.txtAssetID.Name = "txtAssetID"
        Me.txtAssetID.Properties.ReadOnly = True
        Me.txtAssetID.Size = New System.Drawing.Size(230, 20)
        Me.txtAssetID.TabIndex = 316
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(17, 61)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl10.TabIndex = 324
        Me.LabelControl10.Text = "Asset ID/ Stock ID :"
        '
        'txtAsset
        '
        Me.txtAsset.Location = New System.Drawing.Point(193, 32)
        Me.txtAsset.Name = "txtAsset"
        Me.txtAsset.Properties.ReadOnly = True
        Me.txtAsset.Size = New System.Drawing.Size(230, 20)
        Me.txtAsset.TabIndex = 315
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(17, 35)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl9.TabIndex = 323
        Me.LabelControl9.Text = "Asset Description :"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.Mask.EditMask = "n0"
        Me.RepositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        Me.RepositoryItemSpinEdit1.NullText = "1"
        Me.RepositoryItemSpinEdit1.NullValuePrompt = "1"
        '
        'DocumentManager1
        '
        Me.DocumentManager1.ContainerControl = Me
        Me.DocumentManager1.View = Me.TabbedView1
        Me.DocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.TabbedView1})
        '
        'TabbedView1
        '
        Me.TabbedView1.DocumentGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup() {Me.DocumentGroup1})
        Me.TabbedView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.Document2})
        '
        'DocumentGroup1
        '
        Me.DocumentGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.Document2})
        '
        'Document2
        '
        Me.Document2.Caption = "Fixed Asset And Capital Allowance Information"
        Me.Document2.ControlName = "DockPanel3"
        Me.Document2.FloatLocation = New System.Drawing.Point(487, 190)
        Me.Document2.FloatSize = New System.Drawing.Size(200, 200)
        Me.Document2.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
        Me.Document2.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
        Me.Document2.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        '
        'cboRefNo
        '
        Me.cboRefNo.Location = New System.Drawing.Point(135, 14)
        Me.cboRefNo.MenuManager = Me.BarManager1
        Me.cboRefNo.Name = "cboRefNo"
        Me.cboRefNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRefNo.Properties.DataSource = Me.TaxPayerFindBindingSource
        Me.cboRefNo.Properties.DisplayMember = "CompanyName"
        Me.cboRefNo.Properties.NullText = "Select"
        Me.cboRefNo.Properties.PopupFormMinSize = New System.Drawing.Size(600, 0)
        Me.cboRefNo.Properties.ValueMember = "RefNo"
        Me.cboRefNo.Properties.View = Me.SearchLookUpEdit2View
        Me.cboRefNo.Size = New System.Drawing.Size(280, 20)
        Me.cboRefNo.TabIndex = 160
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
        'frmDisposal_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1364, 627)
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MinimumSize = New System.Drawing.Size(1289, 651)
        Me.Name = "frmDisposal_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Disposal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel1_Container.PerformLayout()
        CType(Me.cboSourceCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSearchVal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSearchFor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCompanyCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTaxPayer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel3.ResumeLayout(False)
        Me.DockPanel3_Container.ResumeLayout(False)
        Me.XtraScrollableControl1.ResumeLayout(False)
        Me.XtraScrollableControl1.PerformLayout()
        CType(Me.txtAccumulated.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlControlTransfer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControlTransfer.ResumeLayout(False)
        Me.pnlControlTransfer.PerformLayout()
        CType(Me.txtTaxFileNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransfereeName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTypeDisposal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal_QC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHP_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkControlTransfer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDispose_QC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisposal_Remarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisposal_BABC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisposal_SalesProceed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisposal_TWDV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisposal_RemainingQuaCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisposal_PurchaseAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgWithIn2YA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDisposal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDisposal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTWDV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemainingQualifyingCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNonQualifyingCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQualifyingCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboIncentive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateofPurchase.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateofPurchase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRestrictedQua.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeposit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPurchaseAmountFA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAssetID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAsset.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Document2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCompanyCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFileNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboYA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtTaxPayer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DockPanel3 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DocumentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
    Friend WithEvents TabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
    Friend WithEvents DocumentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
    Friend WithEvents Document2 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
    Friend WithEvents TaxPayerFindBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsCA As EasyTemplate_Taxcom.dsCA
    Friend WithEvents cboSearchFor As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colCA_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_MODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_PREFIX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_REF_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_FILENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_YA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_COMPANY_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_ASSET_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_ASSET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_CATEGORY_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_PURCHASE_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_PURCHASE_YEAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_PURCHASE_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_PAYMENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_RESTRICTED_QC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_RATE_IA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_RATE_AA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_QUALIFYING_COST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_REMAIN_QC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_TWDV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_INCENTIVE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_CTRL_TRANSFER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_ACCELERATED As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_CAEEO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_REC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_DEFERREDCLAIM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_DEDUCTADJ_INCOME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_TAX_FILE_NUMBER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_TRANSFERROR_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_TRANSFER_VAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSearchVal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboSourceCode As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents XtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents txtAccumulated As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnlControlTransfer As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtTaxFileNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTransfereeName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTypeDisposal As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotal_QC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHP_Code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkControlTransfer As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDispose_QC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDisposal_Remarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtDisposal_BABC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDisposal_SalesProceed As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDisposal_TWDV As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDisposal_RemainingQuaCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDisposal_PurchaseAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rgWithIn2YA As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents dtDisposal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTitle_FA As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTitle_CA As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboAA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtTWDV As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRemainingQualifyingCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNonQualifyingCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQualifyingCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboIncentive As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescription As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents dtDateofPurchase As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cboCategory As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRestrictedQua As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDeposit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPurchaseAmountFA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAssetID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAsset As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
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
End Class
