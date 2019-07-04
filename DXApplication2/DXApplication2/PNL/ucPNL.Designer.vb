<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPNL
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucPNL))
        Me.pnlLoading = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.btnClear2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.txtRefNo = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dgvView = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyReferenceNoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyYAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnAllRecord = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cboYA = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.YABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDefault = New EasyTemplate_Taxcom_B.dsDefault()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colYA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboRefNo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.TaxPayerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRefNo_Prefix = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRefNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIC_Number = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPostcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colState = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHandleBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DsPNL1 = New EasyTemplate_Taxcom_B.dsPNL()
        Me.PROFITLOSSACCOUNTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colPL_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_REF_PREFIX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_REF_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_FILENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_YA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_MAIN_BUSINESS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_SALES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_OP_STK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_PURCHASES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_PRO_COST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_PRO_COST_DPC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_PRO_COST_OAE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_PRO_COST_ONAE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_PURCHASES_PRO_COST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_CLS_STK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_COGS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_GROSS_PROFIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_OTH_BSIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_OTH_IN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_OTH_IN_DIVIDEND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_OTH_IN_INTEREST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_OTH_IN_RENTAL_ROYALTY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_OTH_IN_OTHER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NT_INCOME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NT_GAIN_DISPOSAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NT_GAIN_FOREXCHANGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NT_GAIN_INVEST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NT_OTHERS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_EXP_LOANINTEREST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_EXP_SALARY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_EXP_RENTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_EXP_CONTRACT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_EXP_COMMISSION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_BAD_DEBTS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_TRAVEL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAE_EPF_PER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAE_EPF_STAFF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAE_LEGALFEE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NON_ALLOW_LOSS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAL_LOSS_DISPOSAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAL_LOSS_FOREXCHANGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAL_LOSS_INVEST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAL_OTHERS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAE_DEPERECIATION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAE_ENTERTAINMENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAE_GIFT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAE_DONATION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAE_PENALTY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAE_STOCKDRAWING = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAE_CASHDRAWING = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAE_PROVISION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAE_PRELIMINARY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAE_CAPITALEXP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAE_INTERESTEXP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAE_ASSETWOFF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAEP_MOTORVEH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAEP_RESIDENTIAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAEP_TEL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAEP_SUBSCRIPTION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAEP_SEMILAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAEP_MEDICALEXP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAE_OTHEREXP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NAE_TOTALEXP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_TOT_EXP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NET_PROFIT_LOSS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_DISALLOWED_EXP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_TOTALX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_TOTALY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_COMPANY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_MAINCOMPANY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_REP_MAINT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_PRO_ADV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_JKDM = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPNL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROFITLOSSACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLoading
        '
        Me.pnlLoading.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlLoading.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pnlLoading.Appearance.Options.UseBackColor = True
        Me.pnlLoading.AppearanceCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.pnlLoading.AppearanceCaption.Options.UseFont = True
        Me.pnlLoading.AppearanceDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.pnlLoading.AppearanceDescription.Options.UseFont = True
        Me.pnlLoading.BarAnimationElementThickness = 2
        Me.pnlLoading.Location = New System.Drawing.Point(342, 233)
        Me.pnlLoading.Name = "pnlLoading"
        Me.pnlLoading.Size = New System.Drawing.Size(246, 66)
        Me.pnlLoading.TabIndex = 12
        Me.pnlLoading.Text = "ProgressPanel1"
        Me.pnlLoading.Visible = False
        '
        'btnClear2
        '
        Me.btnClear2.ImageOptions.Image = CType(resources.GetObject("btnClear2.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClear2.Location = New System.Drawing.Point(681, 13)
        Me.btnClear2.Name = "btnClear2"
        Me.btnClear2.Size = New System.Drawing.Size(24, 23)
        Me.btnClear2.TabIndex = 13
        '
        'btnClear
        '
        Me.btnClear.ImageOptions.Image = CType(resources.GetObject("btnClear.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClear.Location = New System.Drawing.Point(364, 13)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(24, 23)
        Me.btnClear.TabIndex = 12
        '
        'txtRefNo
        '
        Me.txtRefNo.Location = New System.Drawing.Point(91, 41)
        Me.txtRefNo.MenuManager = Me.BarManager1
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Properties.ReadOnly = True
        Me.txtRefNo.Size = New System.Drawing.Size(268, 20)
        Me.txtRefNo.TabIndex = 11
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnAdd, Me.btnEdit, Me.btnDelete})
        Me.BarManager1.MaxItemId = 7
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None
        Me.Bar1.OptionsBar.DisableClose = True
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'btnAdd
        '
        Me.btnAdd.Caption = "Add"
        Me.btnAdd.Id = 0
        Me.btnAdd.ImageOptions.Image = CType(resources.GetObject("btnAdd.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd.ImageOptions.LargeImage = CType(resources.GetObject("btnAdd.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnEdit
        '
        Me.btnEdit.Caption = "Edit"
        Me.btnEdit.Id = 1
        Me.btnEdit.ImageOptions.Image = CType(resources.GetObject("btnEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEdit.ImageOptions.LargeImage = CType(resources.GetObject("btnEdit.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnDelete
        '
        Me.btnDelete.Caption = "Delete"
        Me.btnDelete.Id = 2
        Me.btnDelete.ImageOptions.Image = CType(resources.GetObject("btnDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelete.ImageOptions.LargeImage = CType(resources.GetObject("btnDelete.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(948, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 579)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(948, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 548)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(948, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 548)
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(423, 17)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "YA :"
        '
        'dgvView
        '
        Me.dgvView.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvView.DataSource = Me.PROFITLOSSACCOUNTBindingSource
        Me.dgvView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvView.Location = New System.Drawing.Point(0, 106)
        Me.dgvView.MainView = Me.GridView1
        Me.dgvView.Name = "dgvView"
        Me.dgvView.Size = New System.Drawing.Size(948, 473)
        Me.dgvView.TabIndex = 11
        Me.dgvView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.CopyReferenceNoToolStripMenuItem, Me.CopyYAToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(177, 114)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'CopyReferenceNoToolStripMenuItem
        '
        Me.CopyReferenceNoToolStripMenuItem.Name = "CopyReferenceNoToolStripMenuItem"
        Me.CopyReferenceNoToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CopyReferenceNoToolStripMenuItem.Text = "Copy Reference No"
        '
        'CopyYAToolStripMenuItem
        '
        Me.CopyYAToolStripMenuItem.Name = "CopyYAToolStripMenuItem"
        Me.CopyYAToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CopyYAToolStripMenuItem.Text = "Copy YA"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPL_KEY, Me.colPL_REF_PREFIX, Me.colPL_REF_NO, Me.colPL_FILENO, Me.colPL_NAME, Me.colPL_YA, Me.colPL_MAIN_BUSINESS, Me.colPL_SALES, Me.colPL_OP_STK, Me.colPL_PURCHASES, Me.colPL_PRO_COST, Me.colPL_PRO_COST_DPC, Me.colPL_PRO_COST_OAE, Me.colPL_PRO_COST_ONAE, Me.colPL_PURCHASES_PRO_COST, Me.colPL_CLS_STK, Me.colPL_COGS, Me.colPL_GROSS_PROFIT, Me.colPL_OTH_BSIN, Me.colPL_OTH_IN, Me.colPL_OTH_IN_DIVIDEND, Me.colPL_OTH_IN_INTEREST, Me.colPL_OTH_IN_RENTAL_ROYALTY, Me.colPL_OTH_IN_OTHER, Me.colPL_NT_INCOME, Me.colPL_NT_GAIN_DISPOSAL, Me.colPL_NT_GAIN_FOREXCHANGE, Me.colPL_NT_GAIN_INVEST, Me.colPL_NT_OTHERS, Me.colPL_EXP_LOANINTEREST, Me.colPL_EXP_SALARY, Me.colPL_EXP_RENTAL, Me.colPL_EXP_CONTRACT, Me.colPL_EXP_COMMISSION, Me.colPL_BAD_DEBTS, Me.colPL_TRAVEL, Me.colPL_NAE_EPF_PER, Me.colPL_NAE_EPF_STAFF, Me.colPL_NAE_LEGALFEE, Me.colPL_NON_ALLOW_LOSS, Me.colPL_NAL_LOSS_DISPOSAL, Me.colPL_NAL_LOSS_FOREXCHANGE, Me.colPL_NAL_LOSS_INVEST, Me.colPL_NAL_OTHERS, Me.colPL_NAE_DEPERECIATION, Me.colPL_NAE_ENTERTAINMENT, Me.colPL_NAE_GIFT, Me.colPL_NAE_DONATION, Me.colPL_NAE_PENALTY, Me.colPL_NAE_STOCKDRAWING, Me.colPL_NAE_CASHDRAWING, Me.colPL_NAE_PROVISION, Me.colPL_NAE_PRELIMINARY, Me.colPL_NAE_CAPITALEXP, Me.colPL_NAE_INTERESTEXP, Me.colPL_NAE_ASSETWOFF, Me.colPL_NAEP_MOTORVEH, Me.colPL_NAEP_RESIDENTIAL, Me.colPL_NAEP_TEL, Me.colPL_NAEP_SUBSCRIPTION, Me.colPL_NAEP_SEMILAR, Me.colPL_NAEP_MEDICALEXP, Me.colPL_NAE_OTHEREXP, Me.colPL_NAE_TOTALEXP, Me.colPL_TOT_EXP, Me.colPL_NET_PROFIT_LOSS, Me.colPL_DISALLOWED_EXP, Me.colPL_TOTALX, Me.colPL_TOTALY, Me.colPL_1, Me.colPL_2, Me.colPL_3, Me.colPL_4, Me.colPL_5, Me.colPL_COMPANY, Me.colPL_MAINCOMPANY, Me.colPL_REP_MAINT, Me.colPL_PRO_ADV, Me.colPL_JKDM})
        Me.GridView1.GridControl = Me.dgvView
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        '
        'btnAllRecord
        '
        Me.btnAllRecord.ImageOptions.Image = CType(resources.GetObject("btnAllRecord.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAllRecord.Location = New System.Drawing.Point(449, 38)
        Me.btnAllRecord.Name = "btnAllRecord"
        Me.btnAllRecord.Size = New System.Drawing.Size(110, 23)
        Me.btnAllRecord.TabIndex = 8
        Me.btnAllRecord.Text = "All Record"
        '
        'btnFind
        '
        Me.btnFind.ImageOptions.Image = CType(resources.GetObject("btnFind.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFind.Location = New System.Drawing.Point(565, 38)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(110, 23)
        Me.btnFind.TabIndex = 7
        Me.btnFind.Text = "Find"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Reference No :"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cboYA)
        Me.PanelControl1.Controls.Add(Me.cboRefNo)
        Me.PanelControl1.Controls.Add(Me.btnClear2)
        Me.PanelControl1.Controls.Add(Me.btnClear)
        Me.PanelControl1.Controls.Add(Me.txtRefNo)
        Me.PanelControl1.Controls.Add(Me.btnAllRecord)
        Me.PanelControl1.Controls.Add(Me.btnFind)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 31)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(948, 75)
        Me.PanelControl1.TabIndex = 10
        '
        'cboYA
        '
        Me.cboYA.Location = New System.Drawing.Point(449, 12)
        Me.cboYA.MenuManager = Me.BarManager1
        Me.cboYA.Name = "cboYA"
        Me.cboYA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboYA.Properties.DataSource = Me.YABindingSource
        Me.cboYA.Properties.DisplayMember = "YA"
        Me.cboYA.Properties.NullText = "Select"
        Me.cboYA.Properties.ValueMember = "YA"
        Me.cboYA.Properties.View = Me.GridView2
        Me.cboYA.Size = New System.Drawing.Size(226, 20)
        Me.cboYA.TabIndex = 162
        '
        'YABindingSource
        '
        Me.YABindingSource.DataMember = "YA"
        Me.YABindingSource.DataSource = Me.DsDefault
        '
        'DsDefault
        '
        Me.DsDefault.DataSetName = "dsDefault"
        Me.DsDefault.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colYA})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colYA
        '
        Me.colYA.Caption = "YA"
        Me.colYA.FieldName = "YA"
        Me.colYA.Name = "colYA"
        Me.colYA.Visible = True
        Me.colYA.VisibleIndex = 0
        '
        'cboRefNo
        '
        Me.cboRefNo.Location = New System.Drawing.Point(91, 14)
        Me.cboRefNo.MenuManager = Me.BarManager1
        Me.cboRefNo.Name = "cboRefNo"
        Me.cboRefNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRefNo.Properties.DataSource = Me.TaxPayerBindingSource
        Me.cboRefNo.Properties.DisplayMember = "Name"
        Me.cboRefNo.Properties.NullText = "Select"
        Me.cboRefNo.Properties.PopupFormMinSize = New System.Drawing.Size(600, 0)
        Me.cboRefNo.Properties.ValueMember = "RefNo"
        Me.cboRefNo.Properties.View = Me.SearchLookUpEdit2View
        Me.cboRefNo.Size = New System.Drawing.Size(268, 20)
        Me.cboRefNo.TabIndex = 161
        '
        'TaxPayerBindingSource
        '
        Me.TaxPayerBindingSource.DataMember = "TaxPayer"
        Me.TaxPayerBindingSource.DataSource = Me.DsDefault
        '
        'SearchLookUpEdit2View
        '
        Me.SearchLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRefNo_Prefix, Me.colRefNo, Me.colName, Me.colIC_Number, Me.colCountry, Me.colAddress1, Me.colAddress2, Me.colAddress3, Me.colPostcode, Me.colCity, Me.colState, Me.colHandleBy})
        Me.SearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit2View.Name = "SearchLookUpEdit2View"
        Me.SearchLookUpEdit2View.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.SearchLookUpEdit2View.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.SearchLookUpEdit2View.OptionsBehavior.Editable = False
        Me.SearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit2View.OptionsView.ColumnAutoWidth = False
        Me.SearchLookUpEdit2View.OptionsView.RowAutoHeight = True
        Me.SearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colRefNo_Prefix
        '
        Me.colRefNo_Prefix.FieldName = "RefNo_Prefix"
        Me.colRefNo_Prefix.Name = "colRefNo_Prefix"
        Me.colRefNo_Prefix.Visible = True
        Me.colRefNo_Prefix.VisibleIndex = 0
        Me.colRefNo_Prefix.Width = 120
        '
        'colRefNo
        '
        Me.colRefNo.Caption = "Reference No"
        Me.colRefNo.FieldName = "RefNo"
        Me.colRefNo.Name = "colRefNo"
        Me.colRefNo.Visible = True
        Me.colRefNo.VisibleIndex = 1
        Me.colRefNo.Width = 120
        '
        'colName
        '
        Me.colName.Caption = "Name"
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 2
        Me.colName.Width = 250
        '
        'colIC_Number
        '
        Me.colIC_Number.Caption = "IC No."
        Me.colIC_Number.FieldName = "IC_Number"
        Me.colIC_Number.Name = "colIC_Number"
        Me.colIC_Number.Visible = True
        Me.colIC_Number.VisibleIndex = 3
        Me.colIC_Number.Width = 120
        '
        'colCountry
        '
        Me.colCountry.Caption = "Country"
        Me.colCountry.FieldName = "Country"
        Me.colCountry.Name = "colCountry"
        Me.colCountry.Visible = True
        Me.colCountry.VisibleIndex = 4
        Me.colCountry.Width = 150
        '
        'colAddress1
        '
        Me.colAddress1.Caption = "Address 1"
        Me.colAddress1.FieldName = "Address1"
        Me.colAddress1.Name = "colAddress1"
        Me.colAddress1.Visible = True
        Me.colAddress1.VisibleIndex = 5
        Me.colAddress1.Width = 150
        '
        'colAddress2
        '
        Me.colAddress2.Caption = "Address 2"
        Me.colAddress2.FieldName = "Address2"
        Me.colAddress2.Name = "colAddress2"
        Me.colAddress2.Visible = True
        Me.colAddress2.VisibleIndex = 6
        Me.colAddress2.Width = 150
        '
        'colAddress3
        '
        Me.colAddress3.Caption = "Address 3"
        Me.colAddress3.FieldName = "Address3"
        Me.colAddress3.Name = "colAddress3"
        Me.colAddress3.Visible = True
        Me.colAddress3.VisibleIndex = 7
        Me.colAddress3.Width = 150
        '
        'colPostcode
        '
        Me.colPostcode.Caption = "Postcode"
        Me.colPostcode.FieldName = "Postcode"
        Me.colPostcode.Name = "colPostcode"
        Me.colPostcode.Visible = True
        Me.colPostcode.VisibleIndex = 8
        Me.colPostcode.Width = 120
        '
        'colCity
        '
        Me.colCity.Caption = "City"
        Me.colCity.FieldName = "City"
        Me.colCity.Name = "colCity"
        Me.colCity.Visible = True
        Me.colCity.VisibleIndex = 9
        Me.colCity.Width = 120
        '
        'colState
        '
        Me.colState.Caption = "State"
        Me.colState.FieldName = "State"
        Me.colState.Name = "colState"
        Me.colState.Visible = True
        Me.colState.VisibleIndex = 10
        Me.colState.Width = 120
        '
        'colHandleBy
        '
        Me.colHandleBy.FieldName = "HandleBy"
        Me.colHandleBy.Name = "colHandleBy"
        Me.colHandleBy.Visible = True
        Me.colHandleBy.VisibleIndex = 11
        '
        'DsPNL1
        '
        Me.DsPNL1.DataSetName = "dsPNL"
        Me.DsPNL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PROFITLOSSACCOUNTBindingSource
        '
        Me.PROFITLOSSACCOUNTBindingSource.DataMember = "PROFIT_LOSS_ACCOUNT"
        Me.PROFITLOSSACCOUNTBindingSource.DataSource = Me.DsPNL1
        '
        'colPL_KEY
        '
        Me.colPL_KEY.Caption = "No"
        Me.colPL_KEY.FieldName = "PL_KEY"
        Me.colPL_KEY.Name = "colPL_KEY"
        Me.colPL_KEY.Visible = True
        Me.colPL_KEY.VisibleIndex = 0
        Me.colPL_KEY.Width = 70
        '
        'colPL_REF_PREFIX
        '
        Me.colPL_REF_PREFIX.Caption = "Prefix"
        Me.colPL_REF_PREFIX.FieldName = "PL_REF_PREFIX"
        Me.colPL_REF_PREFIX.Name = "colPL_REF_PREFIX"
        Me.colPL_REF_PREFIX.Visible = True
        Me.colPL_REF_PREFIX.VisibleIndex = 1
        Me.colPL_REF_PREFIX.Width = 120
        '
        'colPL_REF_NO
        '
        Me.colPL_REF_NO.Caption = "Ref No."
        Me.colPL_REF_NO.FieldName = "PL_REF_NO"
        Me.colPL_REF_NO.Name = "colPL_REF_NO"
        Me.colPL_REF_NO.Visible = True
        Me.colPL_REF_NO.VisibleIndex = 2
        Me.colPL_REF_NO.Width = 120
        '
        'colPL_FILENO
        '
        Me.colPL_FILENO.FieldName = "PL_FILENO"
        Me.colPL_FILENO.Name = "colPL_FILENO"
        Me.colPL_FILENO.Width = 120
        '
        'colPL_NAME
        '
        Me.colPL_NAME.Caption = "Name"
        Me.colPL_NAME.FieldName = "PL_NAME"
        Me.colPL_NAME.Name = "colPL_NAME"
        Me.colPL_NAME.Visible = True
        Me.colPL_NAME.VisibleIndex = 3
        Me.colPL_NAME.Width = 120
        '
        'colPL_YA
        '
        Me.colPL_YA.Caption = "YA"
        Me.colPL_YA.FieldName = "PL_YA"
        Me.colPL_YA.Name = "colPL_YA"
        Me.colPL_YA.Visible = True
        Me.colPL_YA.VisibleIndex = 4
        Me.colPL_YA.Width = 120
        '
        'colPL_MAIN_BUSINESS
        '
        Me.colPL_MAIN_BUSINESS.Caption = "Main Business"
        Me.colPL_MAIN_BUSINESS.FieldName = "PL_MAIN_BUSINESS"
        Me.colPL_MAIN_BUSINESS.Name = "colPL_MAIN_BUSINESS"
        Me.colPL_MAIN_BUSINESS.Visible = True
        Me.colPL_MAIN_BUSINESS.VisibleIndex = 5
        Me.colPL_MAIN_BUSINESS.Width = 120
        '
        'colPL_SALES
        '
        Me.colPL_SALES.Caption = "Sales"
        Me.colPL_SALES.DisplayFormat.FormatString = "n0"
        Me.colPL_SALES.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPL_SALES.FieldName = "PL_SALES"
        Me.colPL_SALES.Name = "colPL_SALES"
        Me.colPL_SALES.Visible = True
        Me.colPL_SALES.VisibleIndex = 6
        Me.colPL_SALES.Width = 120
        '
        'colPL_OP_STK
        '
        Me.colPL_OP_STK.Caption = "Opening Stock"
        Me.colPL_OP_STK.DisplayFormat.FormatString = "n0"
        Me.colPL_OP_STK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPL_OP_STK.FieldName = "PL_OP_STK"
        Me.colPL_OP_STK.Name = "colPL_OP_STK"
        Me.colPL_OP_STK.Visible = True
        Me.colPL_OP_STK.VisibleIndex = 7
        Me.colPL_OP_STK.Width = 120
        '
        'colPL_PURCHASES
        '
        Me.colPL_PURCHASES.Caption = "Purchase"
        Me.colPL_PURCHASES.DisplayFormat.FormatString = "n0"
        Me.colPL_PURCHASES.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPL_PURCHASES.FieldName = "PL_PURCHASES"
        Me.colPL_PURCHASES.Name = "colPL_PURCHASES"
        Me.colPL_PURCHASES.Visible = True
        Me.colPL_PURCHASES.VisibleIndex = 8
        Me.colPL_PURCHASES.Width = 120
        '
        'colPL_PRO_COST
        '
        Me.colPL_PRO_COST.Caption = "Cost of Product"
        Me.colPL_PRO_COST.DisplayFormat.FormatString = "n0"
        Me.colPL_PRO_COST.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPL_PRO_COST.FieldName = "PL_PRO_COST"
        Me.colPL_PRO_COST.Name = "colPL_PRO_COST"
        Me.colPL_PRO_COST.Visible = True
        Me.colPL_PRO_COST.VisibleIndex = 9
        Me.colPL_PRO_COST.Width = 120
        '
        'colPL_PRO_COST_DPC
        '
        Me.colPL_PRO_COST_DPC.FieldName = "PL_PRO_COST_DPC"
        Me.colPL_PRO_COST_DPC.Name = "colPL_PRO_COST_DPC"
        Me.colPL_PRO_COST_DPC.Width = 120
        '
        'colPL_PRO_COST_OAE
        '
        Me.colPL_PRO_COST_OAE.FieldName = "PL_PRO_COST_OAE"
        Me.colPL_PRO_COST_OAE.Name = "colPL_PRO_COST_OAE"
        Me.colPL_PRO_COST_OAE.Width = 120
        '
        'colPL_PRO_COST_ONAE
        '
        Me.colPL_PRO_COST_ONAE.FieldName = "PL_PRO_COST_ONAE"
        Me.colPL_PRO_COST_ONAE.Name = "colPL_PRO_COST_ONAE"
        Me.colPL_PRO_COST_ONAE.Width = 120
        '
        'colPL_PURCHASES_PRO_COST
        '
        Me.colPL_PURCHASES_PRO_COST.Caption = "Cost of Purchase"
        Me.colPL_PURCHASES_PRO_COST.DisplayFormat.FormatString = "n0"
        Me.colPL_PURCHASES_PRO_COST.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPL_PURCHASES_PRO_COST.FieldName = "PL_PURCHASES_PRO_COST"
        Me.colPL_PURCHASES_PRO_COST.Name = "colPL_PURCHASES_PRO_COST"
        Me.colPL_PURCHASES_PRO_COST.Visible = True
        Me.colPL_PURCHASES_PRO_COST.VisibleIndex = 10
        Me.colPL_PURCHASES_PRO_COST.Width = 120
        '
        'colPL_CLS_STK
        '
        Me.colPL_CLS_STK.Caption = "Close Stock"
        Me.colPL_CLS_STK.DisplayFormat.FormatString = "n0"
        Me.colPL_CLS_STK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPL_CLS_STK.FieldName = "PL_CLS_STK"
        Me.colPL_CLS_STK.Name = "colPL_CLS_STK"
        Me.colPL_CLS_STK.Visible = True
        Me.colPL_CLS_STK.VisibleIndex = 11
        Me.colPL_CLS_STK.Width = 120
        '
        'colPL_COGS
        '
        Me.colPL_COGS.Caption = "Gross Profit (Sales - COGS)"
        Me.colPL_COGS.DisplayFormat.FormatString = "n0"
        Me.colPL_COGS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPL_COGS.FieldName = "PL_COGS"
        Me.colPL_COGS.Name = "colPL_COGS"
        Me.colPL_COGS.Visible = True
        Me.colPL_COGS.VisibleIndex = 12
        Me.colPL_COGS.Width = 120
        '
        'colPL_GROSS_PROFIT
        '
        Me.colPL_GROSS_PROFIT.Caption = "Gross Profit"
        Me.colPL_GROSS_PROFIT.DisplayFormat.FormatString = "n0"
        Me.colPL_GROSS_PROFIT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPL_GROSS_PROFIT.FieldName = "PL_GROSS_PROFIT"
        Me.colPL_GROSS_PROFIT.Name = "colPL_GROSS_PROFIT"
        Me.colPL_GROSS_PROFIT.Visible = True
        Me.colPL_GROSS_PROFIT.VisibleIndex = 13
        Me.colPL_GROSS_PROFIT.Width = 120
        '
        'colPL_OTH_BSIN
        '
        Me.colPL_OTH_BSIN.FieldName = "PL_OTH_BSIN"
        Me.colPL_OTH_BSIN.Name = "colPL_OTH_BSIN"
        '
        'colPL_OTH_IN
        '
        Me.colPL_OTH_IN.FieldName = "PL_OTH_IN"
        Me.colPL_OTH_IN.Name = "colPL_OTH_IN"
        '
        'colPL_OTH_IN_DIVIDEND
        '
        Me.colPL_OTH_IN_DIVIDEND.FieldName = "PL_OTH_IN_DIVIDEND"
        Me.colPL_OTH_IN_DIVIDEND.Name = "colPL_OTH_IN_DIVIDEND"
        '
        'colPL_OTH_IN_INTEREST
        '
        Me.colPL_OTH_IN_INTEREST.FieldName = "PL_OTH_IN_INTEREST"
        Me.colPL_OTH_IN_INTEREST.Name = "colPL_OTH_IN_INTEREST"
        '
        'colPL_OTH_IN_RENTAL_ROYALTY
        '
        Me.colPL_OTH_IN_RENTAL_ROYALTY.FieldName = "PL_OTH_IN_RENTAL_ROYALTY"
        Me.colPL_OTH_IN_RENTAL_ROYALTY.Name = "colPL_OTH_IN_RENTAL_ROYALTY"
        '
        'colPL_OTH_IN_OTHER
        '
        Me.colPL_OTH_IN_OTHER.FieldName = "PL_OTH_IN_OTHER"
        Me.colPL_OTH_IN_OTHER.Name = "colPL_OTH_IN_OTHER"
        '
        'colPL_NT_INCOME
        '
        Me.colPL_NT_INCOME.FieldName = "PL_NT_INCOME"
        Me.colPL_NT_INCOME.Name = "colPL_NT_INCOME"
        '
        'colPL_NT_GAIN_DISPOSAL
        '
        Me.colPL_NT_GAIN_DISPOSAL.FieldName = "PL_NT_GAIN_DISPOSAL"
        Me.colPL_NT_GAIN_DISPOSAL.Name = "colPL_NT_GAIN_DISPOSAL"
        '
        'colPL_NT_GAIN_FOREXCHANGE
        '
        Me.colPL_NT_GAIN_FOREXCHANGE.FieldName = "PL_NT_GAIN_FOREXCHANGE"
        Me.colPL_NT_GAIN_FOREXCHANGE.Name = "colPL_NT_GAIN_FOREXCHANGE"
        '
        'colPL_NT_GAIN_INVEST
        '
        Me.colPL_NT_GAIN_INVEST.FieldName = "PL_NT_GAIN_INVEST"
        Me.colPL_NT_GAIN_INVEST.Name = "colPL_NT_GAIN_INVEST"
        '
        'colPL_NT_OTHERS
        '
        Me.colPL_NT_OTHERS.FieldName = "PL_NT_OTHERS"
        Me.colPL_NT_OTHERS.Name = "colPL_NT_OTHERS"
        '
        'colPL_EXP_LOANINTEREST
        '
        Me.colPL_EXP_LOANINTEREST.FieldName = "PL_EXP_LOANINTEREST"
        Me.colPL_EXP_LOANINTEREST.Name = "colPL_EXP_LOANINTEREST"
        '
        'colPL_EXP_SALARY
        '
        Me.colPL_EXP_SALARY.FieldName = "PL_EXP_SALARY"
        Me.colPL_EXP_SALARY.Name = "colPL_EXP_SALARY"
        '
        'colPL_EXP_RENTAL
        '
        Me.colPL_EXP_RENTAL.FieldName = "PL_EXP_RENTAL"
        Me.colPL_EXP_RENTAL.Name = "colPL_EXP_RENTAL"
        '
        'colPL_EXP_CONTRACT
        '
        Me.colPL_EXP_CONTRACT.FieldName = "PL_EXP_CONTRACT"
        Me.colPL_EXP_CONTRACT.Name = "colPL_EXP_CONTRACT"
        '
        'colPL_EXP_COMMISSION
        '
        Me.colPL_EXP_COMMISSION.FieldName = "PL_EXP_COMMISSION"
        Me.colPL_EXP_COMMISSION.Name = "colPL_EXP_COMMISSION"
        '
        'colPL_BAD_DEBTS
        '
        Me.colPL_BAD_DEBTS.FieldName = "PL_BAD_DEBTS"
        Me.colPL_BAD_DEBTS.Name = "colPL_BAD_DEBTS"
        '
        'colPL_TRAVEL
        '
        Me.colPL_TRAVEL.FieldName = "PL_TRAVEL"
        Me.colPL_TRAVEL.Name = "colPL_TRAVEL"
        '
        'colPL_NAE_EPF_PER
        '
        Me.colPL_NAE_EPF_PER.FieldName = "PL_NAE_EPF_PER"
        Me.colPL_NAE_EPF_PER.Name = "colPL_NAE_EPF_PER"
        '
        'colPL_NAE_EPF_STAFF
        '
        Me.colPL_NAE_EPF_STAFF.FieldName = "PL_NAE_EPF_STAFF"
        Me.colPL_NAE_EPF_STAFF.Name = "colPL_NAE_EPF_STAFF"
        '
        'colPL_NAE_LEGALFEE
        '
        Me.colPL_NAE_LEGALFEE.FieldName = "PL_NAE_LEGALFEE"
        Me.colPL_NAE_LEGALFEE.Name = "colPL_NAE_LEGALFEE"
        '
        'colPL_NON_ALLOW_LOSS
        '
        Me.colPL_NON_ALLOW_LOSS.FieldName = "PL_NON_ALLOW_LOSS"
        Me.colPL_NON_ALLOW_LOSS.Name = "colPL_NON_ALLOW_LOSS"
        '
        'colPL_NAL_LOSS_DISPOSAL
        '
        Me.colPL_NAL_LOSS_DISPOSAL.FieldName = "PL_NAL_LOSS_DISPOSAL"
        Me.colPL_NAL_LOSS_DISPOSAL.Name = "colPL_NAL_LOSS_DISPOSAL"
        '
        'colPL_NAL_LOSS_FOREXCHANGE
        '
        Me.colPL_NAL_LOSS_FOREXCHANGE.FieldName = "PL_NAL_LOSS_FOREXCHANGE"
        Me.colPL_NAL_LOSS_FOREXCHANGE.Name = "colPL_NAL_LOSS_FOREXCHANGE"
        '
        'colPL_NAL_LOSS_INVEST
        '
        Me.colPL_NAL_LOSS_INVEST.FieldName = "PL_NAL_LOSS_INVEST"
        Me.colPL_NAL_LOSS_INVEST.Name = "colPL_NAL_LOSS_INVEST"
        '
        'colPL_NAL_OTHERS
        '
        Me.colPL_NAL_OTHERS.FieldName = "PL_NAL_OTHERS"
        Me.colPL_NAL_OTHERS.Name = "colPL_NAL_OTHERS"
        '
        'colPL_NAE_DEPERECIATION
        '
        Me.colPL_NAE_DEPERECIATION.FieldName = "PL_NAE_DEPERECIATION"
        Me.colPL_NAE_DEPERECIATION.Name = "colPL_NAE_DEPERECIATION"
        '
        'colPL_NAE_ENTERTAINMENT
        '
        Me.colPL_NAE_ENTERTAINMENT.FieldName = "PL_NAE_ENTERTAINMENT"
        Me.colPL_NAE_ENTERTAINMENT.Name = "colPL_NAE_ENTERTAINMENT"
        '
        'colPL_NAE_GIFT
        '
        Me.colPL_NAE_GIFT.FieldName = "PL_NAE_GIFT"
        Me.colPL_NAE_GIFT.Name = "colPL_NAE_GIFT"
        '
        'colPL_NAE_DONATION
        '
        Me.colPL_NAE_DONATION.FieldName = "PL_NAE_DONATION"
        Me.colPL_NAE_DONATION.Name = "colPL_NAE_DONATION"
        '
        'colPL_NAE_PENALTY
        '
        Me.colPL_NAE_PENALTY.FieldName = "PL_NAE_PENALTY"
        Me.colPL_NAE_PENALTY.Name = "colPL_NAE_PENALTY"
        '
        'colPL_NAE_STOCKDRAWING
        '
        Me.colPL_NAE_STOCKDRAWING.FieldName = "PL_NAE_STOCKDRAWING"
        Me.colPL_NAE_STOCKDRAWING.Name = "colPL_NAE_STOCKDRAWING"
        '
        'colPL_NAE_CASHDRAWING
        '
        Me.colPL_NAE_CASHDRAWING.FieldName = "PL_NAE_CASHDRAWING"
        Me.colPL_NAE_CASHDRAWING.Name = "colPL_NAE_CASHDRAWING"
        '
        'colPL_NAE_PROVISION
        '
        Me.colPL_NAE_PROVISION.FieldName = "PL_NAE_PROVISION"
        Me.colPL_NAE_PROVISION.Name = "colPL_NAE_PROVISION"
        '
        'colPL_NAE_PRELIMINARY
        '
        Me.colPL_NAE_PRELIMINARY.FieldName = "PL_NAE_PRELIMINARY"
        Me.colPL_NAE_PRELIMINARY.Name = "colPL_NAE_PRELIMINARY"
        '
        'colPL_NAE_CAPITALEXP
        '
        Me.colPL_NAE_CAPITALEXP.FieldName = "PL_NAE_CAPITALEXP"
        Me.colPL_NAE_CAPITALEXP.Name = "colPL_NAE_CAPITALEXP"
        '
        'colPL_NAE_INTERESTEXP
        '
        Me.colPL_NAE_INTERESTEXP.FieldName = "PL_NAE_INTERESTEXP"
        Me.colPL_NAE_INTERESTEXP.Name = "colPL_NAE_INTERESTEXP"
        '
        'colPL_NAE_ASSETWOFF
        '
        Me.colPL_NAE_ASSETWOFF.FieldName = "PL_NAE_ASSETWOFF"
        Me.colPL_NAE_ASSETWOFF.Name = "colPL_NAE_ASSETWOFF"
        '
        'colPL_NAEP_MOTORVEH
        '
        Me.colPL_NAEP_MOTORVEH.FieldName = "PL_NAEP_MOTORVEH"
        Me.colPL_NAEP_MOTORVEH.Name = "colPL_NAEP_MOTORVEH"
        '
        'colPL_NAEP_RESIDENTIAL
        '
        Me.colPL_NAEP_RESIDENTIAL.FieldName = "PL_NAEP_RESIDENTIAL"
        Me.colPL_NAEP_RESIDENTIAL.Name = "colPL_NAEP_RESIDENTIAL"
        '
        'colPL_NAEP_TEL
        '
        Me.colPL_NAEP_TEL.FieldName = "PL_NAEP_TEL"
        Me.colPL_NAEP_TEL.Name = "colPL_NAEP_TEL"
        '
        'colPL_NAEP_SUBSCRIPTION
        '
        Me.colPL_NAEP_SUBSCRIPTION.FieldName = "PL_NAEP_SUBSCRIPTION"
        Me.colPL_NAEP_SUBSCRIPTION.Name = "colPL_NAEP_SUBSCRIPTION"
        '
        'colPL_NAEP_SEMILAR
        '
        Me.colPL_NAEP_SEMILAR.FieldName = "PL_NAEP_SEMILAR"
        Me.colPL_NAEP_SEMILAR.Name = "colPL_NAEP_SEMILAR"
        '
        'colPL_NAEP_MEDICALEXP
        '
        Me.colPL_NAEP_MEDICALEXP.FieldName = "PL_NAEP_MEDICALEXP"
        Me.colPL_NAEP_MEDICALEXP.Name = "colPL_NAEP_MEDICALEXP"
        '
        'colPL_NAE_OTHEREXP
        '
        Me.colPL_NAE_OTHEREXP.FieldName = "PL_NAE_OTHEREXP"
        Me.colPL_NAE_OTHEREXP.Name = "colPL_NAE_OTHEREXP"
        '
        'colPL_NAE_TOTALEXP
        '
        Me.colPL_NAE_TOTALEXP.Caption = "Non Allowable Expenses"
        Me.colPL_NAE_TOTALEXP.DisplayFormat.FormatString = "n0"
        Me.colPL_NAE_TOTALEXP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPL_NAE_TOTALEXP.FieldName = "PL_NAE_TOTALEXP"
        Me.colPL_NAE_TOTALEXP.Name = "colPL_NAE_TOTALEXP"
        Me.colPL_NAE_TOTALEXP.Visible = True
        Me.colPL_NAE_TOTALEXP.VisibleIndex = 14
        Me.colPL_NAE_TOTALEXP.Width = 120
        '
        'colPL_TOT_EXP
        '
        Me.colPL_TOT_EXP.Caption = "Total Expenses"
        Me.colPL_TOT_EXP.DisplayFormat.FormatString = "n0"
        Me.colPL_TOT_EXP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPL_TOT_EXP.FieldName = "PL_TOT_EXP"
        Me.colPL_TOT_EXP.Name = "colPL_TOT_EXP"
        Me.colPL_TOT_EXP.Visible = True
        Me.colPL_TOT_EXP.VisibleIndex = 15
        Me.colPL_TOT_EXP.Width = 120
        '
        'colPL_NET_PROFIT_LOSS
        '
        Me.colPL_NET_PROFIT_LOSS.Caption = "Net profit"
        Me.colPL_NET_PROFIT_LOSS.DisplayFormat.FormatString = "n0"
        Me.colPL_NET_PROFIT_LOSS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPL_NET_PROFIT_LOSS.FieldName = "PL_NET_PROFIT_LOSS"
        Me.colPL_NET_PROFIT_LOSS.Name = "colPL_NET_PROFIT_LOSS"
        Me.colPL_NET_PROFIT_LOSS.Visible = True
        Me.colPL_NET_PROFIT_LOSS.VisibleIndex = 16
        Me.colPL_NET_PROFIT_LOSS.Width = 120
        '
        'colPL_DISALLOWED_EXP
        '
        Me.colPL_DISALLOWED_EXP.FieldName = "PL_DISALLOWED_EXP"
        Me.colPL_DISALLOWED_EXP.Name = "colPL_DISALLOWED_EXP"
        Me.colPL_DISALLOWED_EXP.Width = 120
        '
        'colPL_TOTALX
        '
        Me.colPL_TOTALX.FieldName = "PL_TOTALX"
        Me.colPL_TOTALX.Name = "colPL_TOTALX"
        '
        'colPL_TOTALY
        '
        Me.colPL_TOTALY.FieldName = "PL_TOTALY"
        Me.colPL_TOTALY.Name = "colPL_TOTALY"
        '
        'colPL_1
        '
        Me.colPL_1.FieldName = "PL_1"
        Me.colPL_1.Name = "colPL_1"
        '
        'colPL_2
        '
        Me.colPL_2.FieldName = "PL_2"
        Me.colPL_2.Name = "colPL_2"
        '
        'colPL_3
        '
        Me.colPL_3.FieldName = "PL_3"
        Me.colPL_3.Name = "colPL_3"
        '
        'colPL_4
        '
        Me.colPL_4.FieldName = "PL_4"
        Me.colPL_4.Name = "colPL_4"
        '
        'colPL_5
        '
        Me.colPL_5.FieldName = "PL_5"
        Me.colPL_5.Name = "colPL_5"
        '
        'colPL_COMPANY
        '
        Me.colPL_COMPANY.FieldName = "PL_COMPANY"
        Me.colPL_COMPANY.Name = "colPL_COMPANY"
        '
        'colPL_MAINCOMPANY
        '
        Me.colPL_MAINCOMPANY.FieldName = "PL_MAINCOMPANY"
        Me.colPL_MAINCOMPANY.Name = "colPL_MAINCOMPANY"
        '
        'colPL_REP_MAINT
        '
        Me.colPL_REP_MAINT.FieldName = "PL_REP_MAINT"
        Me.colPL_REP_MAINT.Name = "colPL_REP_MAINT"
        '
        'colPL_PRO_ADV
        '
        Me.colPL_PRO_ADV.FieldName = "PL_PRO_ADV"
        Me.colPL_PRO_ADV.Name = "colPL_PRO_ADV"
        '
        'colPL_JKDM
        '
        Me.colPL_JKDM.FieldName = "PL_JKDM"
        Me.colPL_JKDM.Name = "colPL_JKDM"
        '
        'ucPNL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlLoading)
        Me.Controls.Add(Me.dgvView)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "ucPNL"
        Me.Size = New System.Drawing.Size(948, 579)
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPNL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROFITLOSSACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlLoading As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents btnClear2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRefNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents dgvView As DevExpress.XtraGrid.GridControl
    Friend WithEvents DsPNL As EasyTemplate_Taxcom.dsPNL
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DsCA As EasyTemplate_Taxcom.dsCA
    Friend WithEvents btnAllRecord As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyReferenceNoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyYAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboRefNo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cboYA As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents YABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsDefault As EasyTemplate_Taxcom_B.dsDefault
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colYA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TaxPayerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colRefNo_Prefix As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRefNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIC_Number As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPostcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHandleBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PROFITLOSSACCOUNTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsPNL1 As EasyTemplate_Taxcom_B.dsPNL
    Friend WithEvents colPL_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_REF_PREFIX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_REF_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_FILENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_YA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_MAIN_BUSINESS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_SALES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_OP_STK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_PURCHASES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_PRO_COST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_PRO_COST_DPC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_PRO_COST_OAE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_PRO_COST_ONAE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_PURCHASES_PRO_COST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_CLS_STK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_COGS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_GROSS_PROFIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_OTH_BSIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_OTH_IN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_OTH_IN_DIVIDEND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_OTH_IN_INTEREST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_OTH_IN_RENTAL_ROYALTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_OTH_IN_OTHER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NT_INCOME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NT_GAIN_DISPOSAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NT_GAIN_FOREXCHANGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NT_GAIN_INVEST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NT_OTHERS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_EXP_LOANINTEREST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_EXP_SALARY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_EXP_RENTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_EXP_CONTRACT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_EXP_COMMISSION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_BAD_DEBTS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_TRAVEL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAE_EPF_PER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAE_EPF_STAFF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAE_LEGALFEE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NON_ALLOW_LOSS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAL_LOSS_DISPOSAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAL_LOSS_FOREXCHANGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAL_LOSS_INVEST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAL_OTHERS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAE_DEPERECIATION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAE_ENTERTAINMENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAE_GIFT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAE_DONATION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAE_PENALTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAE_STOCKDRAWING As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAE_CASHDRAWING As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAE_PROVISION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAE_PRELIMINARY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAE_CAPITALEXP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAE_INTERESTEXP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAE_ASSETWOFF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAEP_MOTORVEH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAEP_RESIDENTIAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAEP_TEL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAEP_SUBSCRIPTION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAEP_SEMILAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAEP_MEDICALEXP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAE_OTHEREXP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NAE_TOTALEXP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_TOT_EXP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NET_PROFIT_LOSS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_DISALLOWED_EXP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_TOTALX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_TOTALY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_COMPANY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_MAINCOMPANY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_REP_MAINT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_PRO_ADV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_JKDM As DevExpress.XtraGrid.Columns.GridColumn

End Class
