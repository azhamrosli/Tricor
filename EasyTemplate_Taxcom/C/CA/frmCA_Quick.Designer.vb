<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCA_Quick
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCA_Quick))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.cboRefNo = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TaxPayerFindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCA = New EasyTemplate_Taxcom.dsCA()
        Me.cboYA = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.cboSourceNo = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.btnImport = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExport = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLoad = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Duplicate1xToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Duplicate3xToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Duplicate5xToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCA_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_PURCHASE_YEAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboYE_Resp = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colCA_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboSourceNo_Resp = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colCA_MODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboMode = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colCA_PREFIX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_REF_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_FILENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_YA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_COMPANY_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_ASSET_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_ASSET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_CATEGORY_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboCategory = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colCA_PURCHASE_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_PURCHASE_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAmount = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colCA_PAYMENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_RESTRICTED_QC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_RATE_IA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_RATE_AA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboAA = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colCA_QUALIFYING_COST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_REMAIN_QC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_TWDV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_INCENTIVE = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.swtMode = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.CABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYE_Resp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSourceNo_Resp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.swtMode, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSave, Me.btnClose, Me.cboRefNo, Me.cboYA, Me.cboSourceNo, Me.btnImport, Me.btnExport, Me.btnLoad})
        Me.BarManager1.MaxItemId = 18
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemSpinEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemComboBox1, Me.RepositoryItemTextEdit2, Me.RepositoryItemComboBox2, Me.RepositoryItemComboBox3})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSave), New DevExpress.XtraBars.LinkPersistInfo(Me.btnClose), New DevExpress.XtraBars.LinkPersistInfo(Me.cboRefNo), New DevExpress.XtraBars.LinkPersistInfo(Me.cboYA), New DevExpress.XtraBars.LinkPersistInfo(Me.cboSourceNo), New DevExpress.XtraBars.LinkPersistInfo(Me.btnImport), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExport), New DevExpress.XtraBars.LinkPersistInfo(Me.btnLoad)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None
        Me.Bar1.OptionsBar.DisableClose = True
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.MultiLine = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 0
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.ImageOptions.LargeImage = CType(resources.GetObject("btnSave.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnClose
        '
        Me.btnClose.Caption = "Close"
        Me.btnClose.Id = 2
        Me.btnClose.ImageOptions.Image = CType(resources.GetObject("btnClose.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClose.ImageOptions.LargeImage = CType(resources.GetObject("btnClose.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'cboRefNo
        '
        Me.cboRefNo.Caption = "Tax Payer :"
        Me.cboRefNo.Edit = Me.RepositoryItemLookUpEdit1
        Me.cboRefNo.EditWidth = 170
        Me.cboRefNo.Id = 10
        Me.cboRefNo.Name = "cboRefNo"
        Me.cboRefNo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RefNo", "Ref No", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Company Name", 300, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyNo", "Company No", 71, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployerNo", "Employer No", 70, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FileNo", "File No", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Country", "Country", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyCode", "Company Code", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.TaxPayerFindBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "CompanyName"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.PopupFormMinSize = New System.Drawing.Size(500, 100)
        Me.RepositoryItemLookUpEdit1.PopupSizeable = False
        Me.RepositoryItemLookUpEdit1.ValueMember = "RefNo"
        '
        'TaxPayerFindBindingSource
        '
        Me.TaxPayerFindBindingSource.DataMember = "TaxPayerFind"
        Me.TaxPayerFindBindingSource.DataSource = Me.DsCA
        '
        'DsCA
        '
        Me.DsCA.DataSetName = "dsCA"
        Me.DsCA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboYA
        '
        Me.cboYA.Caption = "YA : "
        Me.cboYA.Edit = Me.RepositoryItemComboBox1
        Me.cboYA.EditWidth = 120
        Me.cboYA.Id = 11
        Me.cboYA.Name = "cboYA"
        Me.cboYA.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'cboSourceNo
        '
        Me.cboSourceNo.Caption = "Source No"
        Me.cboSourceNo.Edit = Me.RepositoryItemComboBox2
        Me.cboSourceNo.EditWidth = 120
        Me.cboSourceNo.Id = 13
        Me.cboSourceNo.Name = "cboSourceNo"
        Me.cboSourceNo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'btnImport
        '
        Me.btnImport.Caption = "Import"
        Me.btnImport.Id = 15
        Me.btnImport.ImageOptions.Image = CType(resources.GetObject("btnImport.ImageOptions.Image"), System.Drawing.Image)
        Me.btnImport.ImageOptions.LargeImage = CType(resources.GetObject("btnImport.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnExport
        '
        Me.btnExport.Caption = "Export"
        Me.btnExport.Id = 16
        Me.btnExport.ImageOptions.Image = CType(resources.GetObject("btnExport.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExport.ImageOptions.LargeImage = CType(resources.GetObject("btnExport.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnLoad
        '
        Me.btnLoad.Caption = "Load Data Same Reference No"
        Me.btnLoad.Id = 17
        Me.btnLoad.ImageOptions.Image = CType(resources.GetObject("btnLoad.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLoad.ImageOptions.LargeImage = CType(resources.GetObject("btnLoad.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.btnLoad.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(988, 62)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 451)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(988, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 62)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 389)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(988, 62)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 389)
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
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemComboBox3
        '
        Me.RepositoryItemComboBox3.AutoHeight = False
        Me.RepositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox3.Name = "RepositoryItemComboBox3"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl1.DataSource = Me.CABindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 62)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboAA, Me.txtAmount, Me.cboMode, Me.cboCategory, Me.swtMode, Me.cboSourceNo_Resp, Me.cboYE_Resp})
        Me.GridControl1.Size = New System.Drawing.Size(988, 389)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Duplicate1xToolStripMenuItem, Me.Duplicate3xToolStripMenuItem, Me.Duplicate5xToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(139, 92)
        '
        'Duplicate1xToolStripMenuItem
        '
        Me.Duplicate1xToolStripMenuItem.Name = "Duplicate1xToolStripMenuItem"
        Me.Duplicate1xToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.Duplicate1xToolStripMenuItem.Text = "Duplicate 1x"
        '
        'Duplicate3xToolStripMenuItem
        '
        Me.Duplicate3xToolStripMenuItem.Name = "Duplicate3xToolStripMenuItem"
        Me.Duplicate3xToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.Duplicate3xToolStripMenuItem.Text = "Duplicate 3x"
        '
        'Duplicate5xToolStripMenuItem
        '
        Me.Duplicate5xToolStripMenuItem.Name = "Duplicate5xToolStripMenuItem"
        Me.Duplicate5xToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.Duplicate5xToolStripMenuItem.Text = "Duplicate 5x"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'CABindingSource
        '
        Me.CABindingSource.DataMember = "CA"
        Me.CABindingSource.DataSource = Me.DsCA
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCA_KEY, Me.colCA_PURCHASE_YEAR, Me.colCA_SOURCENO, Me.colCA_MODE, Me.colCA_PREFIX, Me.colCA_REF_NO, Me.colCA_NAME, Me.colCA_FILENO, Me.colCA_YA, Me.colCA_COMPANY_CODE, Me.colCA_ASSET_CODE, Me.colCA_ASSET, Me.colCA_CATEGORY_CODE, Me.colCA_PURCHASE_DATE, Me.colCA_PURCHASE_AMOUNT, Me.colCA_PAYMENT, Me.colCA_RESTRICTED_QC, Me.colCA_DESC, Me.colCA_RATE_IA, Me.colCA_RATE_AA, Me.colCA_QUALIFYING_COST, Me.colCA_REMAIN_QC, Me.colCA_TWDV, Me.colCA_INCENTIVE, Me.colCA_CTRL_TRANSFER, Me.colHP_CODE, Me.colCA_ACCELERATED, Me.colCA_CAEEO, Me.colCA_REC, Me.colCA_DEFERREDCLAIM, Me.colCA_DEDUCTADJ_INCOME, Me.colCA_TAX_FILE_NUMBER, Me.colCA_TRANSFERROR_NAME, Me.colCA_TRANSFER_VAL})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'colCA_KEY
        '
        Me.colCA_KEY.FieldName = "CA_KEY"
        Me.colCA_KEY.Name = "colCA_KEY"
        '
        'colCA_PURCHASE_YEAR
        '
        Me.colCA_PURCHASE_YEAR.Caption = "Purchase YE"
        Me.colCA_PURCHASE_YEAR.ColumnEdit = Me.cboYE_Resp
        Me.colCA_PURCHASE_YEAR.FieldName = "CA_PURCHASE_YEAR"
        Me.colCA_PURCHASE_YEAR.Name = "colCA_PURCHASE_YEAR"
        Me.colCA_PURCHASE_YEAR.Visible = True
        Me.colCA_PURCHASE_YEAR.VisibleIndex = 0
        Me.colCA_PURCHASE_YEAR.Width = 150
        '
        'cboYE_Resp
        '
        Me.cboYE_Resp.AutoHeight = False
        Me.cboYE_Resp.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboYE_Resp.Name = "cboYE_Resp"
        '
        'colCA_SOURCENO
        '
        Me.colCA_SOURCENO.Caption = "Source No"
        Me.colCA_SOURCENO.ColumnEdit = Me.cboSourceNo_Resp
        Me.colCA_SOURCENO.FieldName = "CA_SOURCENO"
        Me.colCA_SOURCENO.Name = "colCA_SOURCENO"
        Me.colCA_SOURCENO.Visible = True
        Me.colCA_SOURCENO.VisibleIndex = 1
        '
        'cboSourceNo_Resp
        '
        Me.cboSourceNo_Resp.AllowFocused = False
        Me.cboSourceNo_Resp.AutoHeight = False
        Me.cboSourceNo_Resp.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSourceNo_Resp.Name = "cboSourceNo_Resp"
        '
        'colCA_MODE
        '
        Me.colCA_MODE.Caption = "Mode"
        Me.colCA_MODE.ColumnEdit = Me.cboMode
        Me.colCA_MODE.FieldName = "CA_MODE"
        Me.colCA_MODE.Name = "colCA_MODE"
        Me.colCA_MODE.Visible = True
        Me.colCA_MODE.VisibleIndex = 2
        Me.colCA_MODE.Width = 80
        '
        'cboMode
        '
        Me.cboMode.AutoHeight = False
        Me.cboMode.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMode.Items.AddRange(New Object() {"ADD", "OPN"})
        Me.cboMode.Name = "cboMode"
        Me.cboMode.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colCA_PREFIX
        '
        Me.colCA_PREFIX.FieldName = "CA_PREFIX"
        Me.colCA_PREFIX.Name = "colCA_PREFIX"
        '
        'colCA_REF_NO
        '
        Me.colCA_REF_NO.FieldName = "CA_REF_NO"
        Me.colCA_REF_NO.Name = "colCA_REF_NO"
        '
        'colCA_NAME
        '
        Me.colCA_NAME.FieldName = "CA_NAME"
        Me.colCA_NAME.Name = "colCA_NAME"
        '
        'colCA_FILENO
        '
        Me.colCA_FILENO.FieldName = "CA_FILENO"
        Me.colCA_FILENO.Name = "colCA_FILENO"
        '
        'colCA_YA
        '
        Me.colCA_YA.FieldName = "CA_YA"
        Me.colCA_YA.Name = "colCA_YA"
        '
        'colCA_COMPANY_CODE
        '
        Me.colCA_COMPANY_CODE.FieldName = "CA_COMPANY_CODE"
        Me.colCA_COMPANY_CODE.Name = "colCA_COMPANY_CODE"
        '
        'colCA_ASSET_CODE
        '
        Me.colCA_ASSET_CODE.Caption = "Asset Code"
        Me.colCA_ASSET_CODE.FieldName = "CA_ASSET_CODE"
        Me.colCA_ASSET_CODE.Name = "colCA_ASSET_CODE"
        Me.colCA_ASSET_CODE.Visible = True
        Me.colCA_ASSET_CODE.VisibleIndex = 3
        Me.colCA_ASSET_CODE.Width = 150
        '
        'colCA_ASSET
        '
        Me.colCA_ASSET.Caption = "Asset Description"
        Me.colCA_ASSET.FieldName = "CA_ASSET"
        Me.colCA_ASSET.Name = "colCA_ASSET"
        Me.colCA_ASSET.Visible = True
        Me.colCA_ASSET.VisibleIndex = 4
        Me.colCA_ASSET.Width = 350
        '
        'colCA_CATEGORY_CODE
        '
        Me.colCA_CATEGORY_CODE.Caption = "Category"
        Me.colCA_CATEGORY_CODE.ColumnEdit = Me.cboCategory
        Me.colCA_CATEGORY_CODE.FieldName = "CA_CATEGORY_CODE"
        Me.colCA_CATEGORY_CODE.Name = "colCA_CATEGORY_CODE"
        Me.colCA_CATEGORY_CODE.Visible = True
        Me.colCA_CATEGORY_CODE.VisibleIndex = 5
        Me.colCA_CATEGORY_CODE.Width = 150
        '
        'cboCategory
        '
        Me.cboCategory.AutoHeight = False
        Me.cboCategory.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCategory.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CA_CODE", "CA_CODE", 71, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CA_CATEGORY", "CA_CATEGORY", 84, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboCategory.DataSource = Me.CategoryBindingSource
        Me.cboCategory.DisplayMember = "CA_CODE"
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.NullText = "Select"
        Me.cboCategory.ValueMember = "CA_CODE"
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.DsCA
        '
        'colCA_PURCHASE_DATE
        '
        Me.colCA_PURCHASE_DATE.Caption = "Purchase Date"
        Me.colCA_PURCHASE_DATE.FieldName = "CA_PURCHASE_DATE"
        Me.colCA_PURCHASE_DATE.Name = "colCA_PURCHASE_DATE"
        Me.colCA_PURCHASE_DATE.Visible = True
        Me.colCA_PURCHASE_DATE.VisibleIndex = 6
        Me.colCA_PURCHASE_DATE.Width = 150
        '
        'colCA_PURCHASE_AMOUNT
        '
        Me.colCA_PURCHASE_AMOUNT.Caption = "Purchase Amount"
        Me.colCA_PURCHASE_AMOUNT.ColumnEdit = Me.txtAmount
        Me.colCA_PURCHASE_AMOUNT.FieldName = "CA_PURCHASE_AMOUNT"
        Me.colCA_PURCHASE_AMOUNT.Name = "colCA_PURCHASE_AMOUNT"
        Me.colCA_PURCHASE_AMOUNT.Visible = True
        Me.colCA_PURCHASE_AMOUNT.VisibleIndex = 7
        Me.colCA_PURCHASE_AMOUNT.Width = 150
        '
        'txtAmount
        '
        Me.txtAmount.AutoHeight = False
        Me.txtAmount.DisplayFormat.FormatString = "n"
        Me.txtAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmount.Mask.EditMask = "n0"
        Me.txtAmount.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmount.Name = "txtAmount"
        '
        'colCA_PAYMENT
        '
        Me.colCA_PAYMENT.Caption = "Depost / Payment"
        Me.colCA_PAYMENT.ColumnEdit = Me.txtAmount
        Me.colCA_PAYMENT.FieldName = "CA_PAYMENT"
        Me.colCA_PAYMENT.Name = "colCA_PAYMENT"
        Me.colCA_PAYMENT.Visible = True
        Me.colCA_PAYMENT.VisibleIndex = 8
        Me.colCA_PAYMENT.Width = 150
        '
        'colCA_RESTRICTED_QC
        '
        Me.colCA_RESTRICTED_QC.Caption = "Restricted QC"
        Me.colCA_RESTRICTED_QC.ColumnEdit = Me.txtAmount
        Me.colCA_RESTRICTED_QC.FieldName = "CA_RESTRICTED_QC"
        Me.colCA_RESTRICTED_QC.Name = "colCA_RESTRICTED_QC"
        Me.colCA_RESTRICTED_QC.Visible = True
        Me.colCA_RESTRICTED_QC.VisibleIndex = 9
        Me.colCA_RESTRICTED_QC.Width = 150
        '
        'colCA_DESC
        '
        Me.colCA_DESC.FieldName = "CA_DESC"
        Me.colCA_DESC.Name = "colCA_DESC"
        Me.colCA_DESC.Width = 150
        '
        'colCA_RATE_IA
        '
        Me.colCA_RATE_IA.Caption = "AI"
        Me.colCA_RATE_IA.ColumnEdit = Me.txtAmount
        Me.colCA_RATE_IA.FieldName = "CA_RATE_IA"
        Me.colCA_RATE_IA.Name = "colCA_RATE_IA"
        Me.colCA_RATE_IA.Visible = True
        Me.colCA_RATE_IA.VisibleIndex = 10
        Me.colCA_RATE_IA.Width = 150
        '
        'colCA_RATE_AA
        '
        Me.colCA_RATE_AA.Caption = "AA"
        Me.colCA_RATE_AA.ColumnEdit = Me.cboAA
        Me.colCA_RATE_AA.FieldName = "CA_RATE_AA"
        Me.colCA_RATE_AA.Name = "colCA_RATE_AA"
        Me.colCA_RATE_AA.Visible = True
        Me.colCA_RATE_AA.VisibleIndex = 11
        Me.colCA_RATE_AA.Width = 150
        '
        'cboAA
        '
        Me.cboAA.AutoHeight = False
        Me.cboAA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAA.Items.AddRange(New Object() {"0", "2", "3", "8", "10", "12", "14", "16", "20", "40", "50", "60", "80", "90", "100"})
        Me.cboAA.Name = "cboAA"
        Me.cboAA.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colCA_QUALIFYING_COST
        '
        Me.colCA_QUALIFYING_COST.Caption = "Qualifying Cost"
        Me.colCA_QUALIFYING_COST.ColumnEdit = Me.txtAmount
        Me.colCA_QUALIFYING_COST.FieldName = "CA_QUALIFYING_COST"
        Me.colCA_QUALIFYING_COST.Name = "colCA_QUALIFYING_COST"
        Me.colCA_QUALIFYING_COST.Visible = True
        Me.colCA_QUALIFYING_COST.VisibleIndex = 12
        Me.colCA_QUALIFYING_COST.Width = 150
        '
        'colCA_REMAIN_QC
        '
        Me.colCA_REMAIN_QC.Caption = "Remaining Qualifying Cost"
        Me.colCA_REMAIN_QC.ColumnEdit = Me.txtAmount
        Me.colCA_REMAIN_QC.FieldName = "CA_REMAIN_QC"
        Me.colCA_REMAIN_QC.Name = "colCA_REMAIN_QC"
        Me.colCA_REMAIN_QC.Width = 150
        '
        'colCA_TWDV
        '
        Me.colCA_TWDV.Caption = "TWDV"
        Me.colCA_TWDV.ColumnEdit = Me.txtAmount
        Me.colCA_TWDV.FieldName = "CA_TWDV"
        Me.colCA_TWDV.Name = "colCA_TWDV"
        Me.colCA_TWDV.Visible = True
        Me.colCA_TWDV.VisibleIndex = 13
        Me.colCA_TWDV.Width = 150
        '
        'colCA_INCENTIVE
        '
        Me.colCA_INCENTIVE.FieldName = "CA_INCENTIVE"
        Me.colCA_INCENTIVE.Name = "colCA_INCENTIVE"
        Me.colCA_INCENTIVE.Width = 150
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
        'swtMode
        '
        Me.swtMode.AutoHeight = False
        Me.swtMode.Name = "swtMode"
        Me.swtMode.OffText = "Opening"
        Me.swtMode.OnText = "Addation"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmCA_Quick
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 451)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmCA_Quick"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quick CA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.CABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYE_Resp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSourceNo_Resp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.swtMode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents cboRefNo As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboYA As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cboSourceNo As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents TaxPayerFindBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsCA As EasyTemplate_Taxcom.dsCA
    Friend WithEvents RepositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents CABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents cboAA As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents txtAmount As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cboMode As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cboCategory As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents swtMode As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Duplicate1xToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Duplicate3xToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Duplicate5xToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnImport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnLoad As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cboSourceNo_Resp As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cboYE_Resp As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
End Class
