<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCA
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucCA))
        Me.dgvDisposal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCA_KEY1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_DISP_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_DISP_YA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_DISP_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_DISP_WITHIN_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_DISP_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_DISP_QC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_DISP_BALANCE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_DISP_TWDV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_DISP_SPROCEED = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_DISP_BABC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_DISP_REMARKS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dgvView = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DuplicateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateDisposalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyReferenceNoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyCompanyNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvCA = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCA_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_MODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_PREFIX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_REF_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_FILENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_YA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_COMPANY_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_ASSET_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_ASSET = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.pnlLoading = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cboRefNo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.TaxPayerFindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCA = New EasyTemplate_Taxcom.dsCA()
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRefNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHandleBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployerNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.cboYA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboFilterType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnAllRecord = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFilterValue = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRefNo = New DevExpress.XtraEditors.TextEdit()
        Me.btnImportExport = New DevExpress.XtraBars.BarButtonItem()
        Me.btnQuickCA = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.dgvDisposal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.CABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFilterType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilterValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDisposal
        '
        Me.dgvDisposal.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCA_KEY1, Me.colCA_DISP_KEY, Me.colCA_DISP_YA, Me.colCA_DISP_DATE, Me.colCA_DISP_WITHIN_2, Me.colCA_DISP_AMOUNT, Me.colCA_DISP_QC, Me.colCA_DISP_BALANCE, Me.colCA_DISP_TWDV, Me.colCA_DISP_SPROCEED, Me.colCA_DISP_BABC, Me.colCA_DISP_REMARKS})
        Me.dgvDisposal.GridControl = Me.dgvView
        Me.dgvDisposal.Name = "dgvDisposal"
        Me.dgvDisposal.ViewCaption = "Disposal"
        '
        'colCA_KEY1
        '
        Me.colCA_KEY1.FieldName = "CA_KEY"
        Me.colCA_KEY1.Name = "colCA_KEY1"
        '
        'colCA_DISP_KEY
        '
        Me.colCA_DISP_KEY.Caption = "No"
        Me.colCA_DISP_KEY.FieldName = "CA_DISP_KEY"
        Me.colCA_DISP_KEY.Name = "colCA_DISP_KEY"
        Me.colCA_DISP_KEY.Visible = True
        Me.colCA_DISP_KEY.VisibleIndex = 0
        '
        'colCA_DISP_YA
        '
        Me.colCA_DISP_YA.Caption = "YA"
        Me.colCA_DISP_YA.FieldName = "CA_DISP_YA"
        Me.colCA_DISP_YA.Name = "colCA_DISP_YA"
        Me.colCA_DISP_YA.Visible = True
        Me.colCA_DISP_YA.VisibleIndex = 1
        '
        'colCA_DISP_DATE
        '
        Me.colCA_DISP_DATE.Caption = "Disposal Date"
        Me.colCA_DISP_DATE.FieldName = "CA_DISP_DATE"
        Me.colCA_DISP_DATE.Name = "colCA_DISP_DATE"
        Me.colCA_DISP_DATE.Visible = True
        Me.colCA_DISP_DATE.VisibleIndex = 2
        '
        'colCA_DISP_WITHIN_2
        '
        Me.colCA_DISP_WITHIN_2.FieldName = "CA_DISP_WITHIN_2"
        Me.colCA_DISP_WITHIN_2.Name = "colCA_DISP_WITHIN_2"
        '
        'colCA_DISP_AMOUNT
        '
        Me.colCA_DISP_AMOUNT.Caption = "Disposal Amount"
        Me.colCA_DISP_AMOUNT.FieldName = "CA_DISP_AMOUNT"
        Me.colCA_DISP_AMOUNT.Name = "colCA_DISP_AMOUNT"
        Me.colCA_DISP_AMOUNT.Visible = True
        Me.colCA_DISP_AMOUNT.VisibleIndex = 3
        '
        'colCA_DISP_QC
        '
        Me.colCA_DISP_QC.Caption = "Disposal QC"
        Me.colCA_DISP_QC.FieldName = "CA_DISP_QC"
        Me.colCA_DISP_QC.Name = "colCA_DISP_QC"
        Me.colCA_DISP_QC.Visible = True
        Me.colCA_DISP_QC.VisibleIndex = 4
        '
        'colCA_DISP_BALANCE
        '
        Me.colCA_DISP_BALANCE.Caption = "Disposal Balance"
        Me.colCA_DISP_BALANCE.FieldName = "CA_DISP_BALANCE"
        Me.colCA_DISP_BALANCE.Name = "colCA_DISP_BALANCE"
        Me.colCA_DISP_BALANCE.Visible = True
        Me.colCA_DISP_BALANCE.VisibleIndex = 5
        '
        'colCA_DISP_TWDV
        '
        Me.colCA_DISP_TWDV.Caption = "Disposal TWDV"
        Me.colCA_DISP_TWDV.FieldName = "CA_DISP_TWDV"
        Me.colCA_DISP_TWDV.Name = "colCA_DISP_TWDV"
        Me.colCA_DISP_TWDV.Visible = True
        Me.colCA_DISP_TWDV.VisibleIndex = 6
        '
        'colCA_DISP_SPROCEED
        '
        Me.colCA_DISP_SPROCEED.Caption = "Disposal Sales Proceed"
        Me.colCA_DISP_SPROCEED.FieldName = "CA_DISP_SPROCEED"
        Me.colCA_DISP_SPROCEED.Name = "colCA_DISP_SPROCEED"
        Me.colCA_DISP_SPROCEED.Visible = True
        Me.colCA_DISP_SPROCEED.VisibleIndex = 7
        '
        'colCA_DISP_BABC
        '
        Me.colCA_DISP_BABC.Caption = "Balancing Charge"
        Me.colCA_DISP_BABC.FieldName = "CA_DISP_BABC"
        Me.colCA_DISP_BABC.Name = "colCA_DISP_BABC"
        Me.colCA_DISP_BABC.Visible = True
        Me.colCA_DISP_BABC.VisibleIndex = 8
        '
        'colCA_DISP_REMARKS
        '
        Me.colCA_DISP_REMARKS.Caption = "Remarks"
        Me.colCA_DISP_REMARKS.FieldName = "CA_DISP_REMARKS"
        Me.colCA_DISP_REMARKS.Name = "colCA_DISP_REMARKS"
        Me.colCA_DISP_REMARKS.Visible = True
        Me.colCA_DISP_REMARKS.VisibleIndex = 9
        Me.colCA_DISP_REMARKS.Width = 300
        '
        'dgvView
        '
        Me.dgvView.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvView.DataSource = Me.CABindingSource
        Me.dgvView.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.dgvDisposal
        GridLevelNode1.RelationName = "FK_CA_CA_DISPOSAL"
        Me.dgvView.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.dgvView.Location = New System.Drawing.Point(0, 140)
        Me.dgvView.MainView = Me.dgvCA
        Me.dgvView.Name = "dgvView"
        Me.dgvView.Size = New System.Drawing.Size(905, 362)
        Me.dgvView.TabIndex = 14
        Me.dgvView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvCA, Me.dgvDisposal})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.RemoveToolStripMenuItem, Me.DuplicateToolStripMenuItem, Me.ToolStripMenuItem2, Me.CreateDisposalToolStripMenuItem, Me.CopyReferenceNoToolStripMenuItem, Me.CopyCompanyNameToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(193, 180)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'DuplicateToolStripMenuItem
        '
        Me.DuplicateToolStripMenuItem.Name = "DuplicateToolStripMenuItem"
        Me.DuplicateToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.DuplicateToolStripMenuItem.Text = "Duplicate"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(192, 22)
        Me.ToolStripMenuItem2.Text = "_______________________"
        '
        'CreateDisposalToolStripMenuItem
        '
        Me.CreateDisposalToolStripMenuItem.Name = "CreateDisposalToolStripMenuItem"
        Me.CreateDisposalToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.CreateDisposalToolStripMenuItem.Text = "Create Disposal"
        '
        'CopyReferenceNoToolStripMenuItem
        '
        Me.CopyReferenceNoToolStripMenuItem.Name = "CopyReferenceNoToolStripMenuItem"
        Me.CopyReferenceNoToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.CopyReferenceNoToolStripMenuItem.Text = "Copy Reference No"
        '
        'CopyCompanyNameToolStripMenuItem
        '
        Me.CopyCompanyNameToolStripMenuItem.Name = "CopyCompanyNameToolStripMenuItem"
        Me.CopyCompanyNameToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.CopyCompanyNameToolStripMenuItem.Text = "Copy Company Name"
        '
        'CABindingSource
        '
        Me.CABindingSource.DataMember = "CA"
        '
        'dgvCA
        '
        Me.dgvCA.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCA_KEY, Me.colCA_MODE, Me.colCA_PREFIX, Me.colCA_REF_NO, Me.colCA_NAME, Me.colCA_FILENO, Me.colCA_YA, Me.colCA_COMPANY_CODE, Me.colCA_SOURCENO, Me.colCA_ASSET_CODE, Me.colCA_ASSET, Me.colCA_CATEGORY_CODE, Me.colCA_PURCHASE_DATE, Me.colCA_PURCHASE_YEAR, Me.colCA_PURCHASE_AMOUNT, Me.colCA_PAYMENT, Me.colCA_RESTRICTED_QC, Me.colCA_DESC, Me.colCA_RATE_IA, Me.colCA_RATE_AA, Me.colCA_QUALIFYING_COST, Me.colCA_REMAIN_QC, Me.colCA_TWDV, Me.colCA_INCENTIVE, Me.colCA_CTRL_TRANSFER, Me.colHP_CODE, Me.colCA_ACCELERATED, Me.colCA_CAEEO, Me.colCA_REC, Me.colCA_DEFERREDCLAIM, Me.colCA_DEDUCTADJ_INCOME, Me.colCA_TAX_FILE_NUMBER, Me.colCA_TRANSFERROR_NAME, Me.colCA_TRANSFER_VAL})
        Me.dgvCA.GridControl = Me.dgvView
        Me.dgvCA.Name = "dgvCA"
        Me.dgvCA.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.dgvCA.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.dgvCA.OptionsBehavior.Editable = False
        Me.dgvCA.OptionsSelection.MultiSelect = True
        Me.dgvCA.OptionsView.ColumnAutoWidth = False
        '
        'colCA_KEY
        '
        Me.colCA_KEY.Caption = "CA No"
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
        'colCA_REF_NO
        '
        Me.colCA_REF_NO.Caption = "Ref No"
        Me.colCA_REF_NO.FieldName = "CA_REF_NO"
        Me.colCA_REF_NO.Name = "colCA_REF_NO"
        Me.colCA_REF_NO.Visible = True
        Me.colCA_REF_NO.VisibleIndex = 1
        Me.colCA_REF_NO.Width = 200
        '
        'colCA_NAME
        '
        Me.colCA_NAME.Caption = "Company Name"
        Me.colCA_NAME.FieldName = "CA_NAME"
        Me.colCA_NAME.Name = "colCA_NAME"
        Me.colCA_NAME.Visible = True
        Me.colCA_NAME.VisibleIndex = 2
        Me.colCA_NAME.Width = 200
        '
        'colCA_FILENO
        '
        Me.colCA_FILENO.FieldName = "CA_FILENO"
        Me.colCA_FILENO.Name = "colCA_FILENO"
        '
        'colCA_YA
        '
        Me.colCA_YA.Caption = "YA"
        Me.colCA_YA.FieldName = "CA_YA"
        Me.colCA_YA.Name = "colCA_YA"
        Me.colCA_YA.Visible = True
        Me.colCA_YA.VisibleIndex = 3
        Me.colCA_YA.Width = 100
        '
        'colCA_COMPANY_CODE
        '
        Me.colCA_COMPANY_CODE.FieldName = "CA_COMPANY_CODE"
        Me.colCA_COMPANY_CODE.Name = "colCA_COMPANY_CODE"
        '
        'colCA_SOURCENO
        '
        Me.colCA_SOURCENO.Caption = "Source No"
        Me.colCA_SOURCENO.FieldName = "CA_SOURCENO"
        Me.colCA_SOURCENO.Name = "colCA_SOURCENO"
        Me.colCA_SOURCENO.Visible = True
        Me.colCA_SOURCENO.VisibleIndex = 4
        '
        'colCA_ASSET_CODE
        '
        Me.colCA_ASSET_CODE.Caption = "Asset Code"
        Me.colCA_ASSET_CODE.FieldName = "CA_ASSET_CODE"
        Me.colCA_ASSET_CODE.Name = "colCA_ASSET_CODE"
        Me.colCA_ASSET_CODE.Visible = True
        Me.colCA_ASSET_CODE.VisibleIndex = 5
        Me.colCA_ASSET_CODE.Width = 150
        '
        'colCA_ASSET
        '
        Me.colCA_ASSET.Caption = "Asset"
        Me.colCA_ASSET.FieldName = "CA_ASSET"
        Me.colCA_ASSET.Name = "colCA_ASSET"
        Me.colCA_ASSET.Visible = True
        Me.colCA_ASSET.VisibleIndex = 6
        Me.colCA_ASSET.Width = 250
        '
        'colCA_CATEGORY_CODE
        '
        Me.colCA_CATEGORY_CODE.Caption = "Category"
        Me.colCA_CATEGORY_CODE.FieldName = "CA_CATEGORY_CODE"
        Me.colCA_CATEGORY_CODE.Name = "colCA_CATEGORY_CODE"
        Me.colCA_CATEGORY_CODE.Visible = True
        Me.colCA_CATEGORY_CODE.VisibleIndex = 7
        Me.colCA_CATEGORY_CODE.Width = 150
        '
        'colCA_PURCHASE_DATE
        '
        Me.colCA_PURCHASE_DATE.Caption = "Purchase Date"
        Me.colCA_PURCHASE_DATE.FieldName = "CA_PURCHASE_DATE"
        Me.colCA_PURCHASE_DATE.Name = "colCA_PURCHASE_DATE"
        Me.colCA_PURCHASE_DATE.Visible = True
        Me.colCA_PURCHASE_DATE.VisibleIndex = 8
        Me.colCA_PURCHASE_DATE.Width = 150
        '
        'colCA_PURCHASE_YEAR
        '
        Me.colCA_PURCHASE_YEAR.Caption = "Purchase YA"
        Me.colCA_PURCHASE_YEAR.FieldName = "CA_PURCHASE_YEAR"
        Me.colCA_PURCHASE_YEAR.Name = "colCA_PURCHASE_YEAR"
        Me.colCA_PURCHASE_YEAR.Visible = True
        Me.colCA_PURCHASE_YEAR.VisibleIndex = 9
        Me.colCA_PURCHASE_YEAR.Width = 150
        '
        'colCA_PURCHASE_AMOUNT
        '
        Me.colCA_PURCHASE_AMOUNT.Caption = "Purchase Amount"
        Me.colCA_PURCHASE_AMOUNT.FieldName = "CA_PURCHASE_AMOUNT"
        Me.colCA_PURCHASE_AMOUNT.Name = "colCA_PURCHASE_AMOUNT"
        Me.colCA_PURCHASE_AMOUNT.Visible = True
        Me.colCA_PURCHASE_AMOUNT.VisibleIndex = 10
        Me.colCA_PURCHASE_AMOUNT.Width = 150
        '
        'colCA_PAYMENT
        '
        Me.colCA_PAYMENT.Caption = "Deposit"
        Me.colCA_PAYMENT.FieldName = "CA_PAYMENT"
        Me.colCA_PAYMENT.Name = "colCA_PAYMENT"
        Me.colCA_PAYMENT.Visible = True
        Me.colCA_PAYMENT.VisibleIndex = 11
        Me.colCA_PAYMENT.Width = 150
        '
        'colCA_RESTRICTED_QC
        '
        Me.colCA_RESTRICTED_QC.Caption = "Restricted QC"
        Me.colCA_RESTRICTED_QC.FieldName = "CA_RESTRICTED_QC"
        Me.colCA_RESTRICTED_QC.Name = "colCA_RESTRICTED_QC"
        Me.colCA_RESTRICTED_QC.Visible = True
        Me.colCA_RESTRICTED_QC.VisibleIndex = 12
        Me.colCA_RESTRICTED_QC.Width = 150
        '
        'colCA_DESC
        '
        Me.colCA_DESC.FieldName = "CA_DESC"
        Me.colCA_DESC.Name = "colCA_DESC"
        '
        'colCA_RATE_IA
        '
        Me.colCA_RATE_IA.Caption = "Rate IA"
        Me.colCA_RATE_IA.FieldName = "CA_RATE_IA"
        Me.colCA_RATE_IA.Name = "colCA_RATE_IA"
        Me.colCA_RATE_IA.Visible = True
        Me.colCA_RATE_IA.VisibleIndex = 13
        Me.colCA_RATE_IA.Width = 150
        '
        'colCA_RATE_AA
        '
        Me.colCA_RATE_AA.Caption = "Rate AA"
        Me.colCA_RATE_AA.FieldName = "CA_RATE_AA"
        Me.colCA_RATE_AA.Name = "colCA_RATE_AA"
        Me.colCA_RATE_AA.Visible = True
        Me.colCA_RATE_AA.VisibleIndex = 14
        Me.colCA_RATE_AA.Width = 150
        '
        'colCA_QUALIFYING_COST
        '
        Me.colCA_QUALIFYING_COST.Caption = "Qualifying Cost"
        Me.colCA_QUALIFYING_COST.FieldName = "CA_QUALIFYING_COST"
        Me.colCA_QUALIFYING_COST.Name = "colCA_QUALIFYING_COST"
        Me.colCA_QUALIFYING_COST.Visible = True
        Me.colCA_QUALIFYING_COST.VisibleIndex = 15
        Me.colCA_QUALIFYING_COST.Width = 150
        '
        'colCA_REMAIN_QC
        '
        Me.colCA_REMAIN_QC.Caption = "Remaining QC"
        Me.colCA_REMAIN_QC.FieldName = "CA_REMAIN_QC"
        Me.colCA_REMAIN_QC.Name = "colCA_REMAIN_QC"
        Me.colCA_REMAIN_QC.Visible = True
        Me.colCA_REMAIN_QC.VisibleIndex = 16
        Me.colCA_REMAIN_QC.Width = 150
        '
        'colCA_TWDV
        '
        Me.colCA_TWDV.Caption = "TWDW"
        Me.colCA_TWDV.FieldName = "CA_TWDV"
        Me.colCA_TWDV.Name = "colCA_TWDV"
        Me.colCA_TWDV.Visible = True
        Me.colCA_TWDV.VisibleIndex = 17
        Me.colCA_TWDV.Width = 150
        '
        'colCA_INCENTIVE
        '
        Me.colCA_INCENTIVE.FieldName = "CA_INCENTIVE"
        Me.colCA_INCENTIVE.Name = "colCA_INCENTIVE"
        '
        'colCA_CTRL_TRANSFER
        '
        Me.colCA_CTRL_TRANSFER.FieldName = "CA_CTRL_TRANSFER"
        Me.colCA_CTRL_TRANSFER.Name = "colCA_CTRL_TRANSFER"
        '
        'colHP_CODE
        '
        Me.colHP_CODE.Caption = "HP Code"
        Me.colHP_CODE.FieldName = "HP_CODE"
        Me.colHP_CODE.Name = "colHP_CODE"
        Me.colHP_CODE.Visible = True
        Me.colHP_CODE.VisibleIndex = 18
        Me.colHP_CODE.Width = 150
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
        Me.pnlLoading.Location = New System.Drawing.Point(355, 207)
        Me.pnlLoading.Name = "pnlLoading"
        Me.pnlLoading.Size = New System.Drawing.Size(246, 66)
        Me.pnlLoading.TabIndex = 9
        Me.pnlLoading.Text = "ProgressPanel1"
        Me.pnlLoading.Visible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cboRefNo)
        Me.PanelControl1.Controls.Add(Me.SimpleButton2)
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Controls.Add(Me.btnClear)
        Me.PanelControl1.Controls.Add(Me.cboYA)
        Me.PanelControl1.Controls.Add(Me.cboFilterType)
        Me.PanelControl1.Controls.Add(Me.btnAllRecord)
        Me.PanelControl1.Controls.Add(Me.btnFind)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.txtFilterValue)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtRefNo)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 31)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(905, 109)
        Me.PanelControl1.TabIndex = 7
        '
        'cboRefNo
        '
        Me.cboRefNo.Location = New System.Drawing.Point(108, 15)
        Me.cboRefNo.MenuManager = Me.BarManager1
        Me.cboRefNo.Name = "cboRefNo"
        Me.cboRefNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRefNo.Properties.DataSource = Me.TaxPayerFindBindingSource
        Me.cboRefNo.Properties.DisplayMember = "CompanyName"
        Me.cboRefNo.Properties.NullText = "Select"
        Me.cboRefNo.Properties.PopupFormMinSize = New System.Drawing.Size(600, 0)
        Me.cboRefNo.Properties.ValueMember = "RefNo"
        Me.cboRefNo.Properties.View = Me.SearchLookUpEdit2View
        Me.cboRefNo.Size = New System.Drawing.Size(268, 20)
        Me.cboRefNo.TabIndex = 160
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnAdd, Me.btnEdit, Me.btnDelete, Me.btnPrint, Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 9
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrint), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
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
        'btnPrint
        '
        Me.btnPrint.Caption = "Print"
        Me.btnPrint.Id = 3
        Me.btnPrint.ImageOptions.Image = CType(resources.GetObject("btnPrint.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrint.ImageOptions.LargeImage = CType(resources.GetObject("btnPrint.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
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
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Quick CA"
        Me.BarButtonItem1.Id = 8
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(905, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 502)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(905, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 471)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(905, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 471)
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
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(804, 39)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(24, 23)
        Me.SimpleButton2.TabIndex = 15
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(382, 65)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(24, 23)
        Me.SimpleButton1.TabIndex = 14
        '
        'btnClear
        '
        Me.btnClear.ImageOptions.Image = CType(resources.GetObject("btnClear.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClear.Location = New System.Drawing.Point(382, 13)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(24, 23)
        Me.btnClear.TabIndex = 13
        '
        'cboYA
        '
        Me.cboYA.Location = New System.Drawing.Point(108, 67)
        Me.cboYA.Name = "cboYA"
        Me.cboYA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboYA.Properties.PopupSizeable = True
        Me.cboYA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboYA.Size = New System.Drawing.Size(268, 20)
        Me.cboYA.TabIndex = 11
        '
        'cboFilterType
        '
        Me.cboFilterType.Location = New System.Drawing.Point(530, 15)
        Me.cboFilterType.MenuManager = Me.BarManager1
        Me.cboFilterType.Name = "cboFilterType"
        Me.cboFilterType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFilterType.Properties.Items.AddRange(New Object() {"Asset Description", "Asset Code / Stock No", "Accelerated CA", "HP Code", "RA", "ITA", "Deferred Claim", "All"})
        Me.cboFilterType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboFilterType.Size = New System.Drawing.Size(268, 20)
        Me.cboFilterType.TabIndex = 9
        '
        'btnAllRecord
        '
        Me.btnAllRecord.ImageOptions.Image = CType(resources.GetObject("btnAllRecord.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAllRecord.Location = New System.Drawing.Point(572, 67)
        Me.btnAllRecord.Name = "btnAllRecord"
        Me.btnAllRecord.Size = New System.Drawing.Size(110, 23)
        Me.btnAllRecord.TabIndex = 8
        Me.btnAllRecord.Text = "All Record"
        '
        'btnFind
        '
        Me.btnFind.ImageOptions.Image = CType(resources.GetObject("btnFind.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFind.Location = New System.Drawing.Point(688, 67)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(110, 23)
        Me.btnFind.TabIndex = 7
        Me.btnFind.Text = "Find"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(434, 18)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Filter Advance :"
        '
        'txtFilterValue
        '
        Me.txtFilterValue.Location = New System.Drawing.Point(530, 41)
        Me.txtFilterValue.MenuManager = Me.BarManager1
        Me.txtFilterValue.Name = "txtFilterValue"
        Me.txtFilterValue.Size = New System.Drawing.Size(268, 20)
        Me.txtFilterValue.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 72)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "YA :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Reference No :"
        '
        'txtRefNo
        '
        Me.txtRefNo.Location = New System.Drawing.Point(108, 41)
        Me.txtRefNo.MenuManager = Me.BarManager1
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Properties.ReadOnly = True
        Me.txtRefNo.Size = New System.Drawing.Size(268, 20)
        Me.txtRefNo.TabIndex = 0
        '
        'btnImportExport
        '
        Me.btnImportExport.Caption = "Import / Export"
        Me.btnImportExport.Id = 4
        Me.btnImportExport.ImageOptions.Image = CType(resources.GetObject("btnImportExport.ImageOptions.Image"), System.Drawing.Image)
        Me.btnImportExport.ImageOptions.LargeImage = CType(resources.GetObject("btnImportExport.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnImportExport.Name = "btnImportExport"
        Me.btnImportExport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnQuickCA
        '
        Me.btnQuickCA.Caption = "Quick CA"
        Me.btnQuickCA.Id = 7
        Me.btnQuickCA.ImageOptions.Image = CType(resources.GetObject("btnQuickCA.ImageOptions.Image"), System.Drawing.Image)
        Me.btnQuickCA.ImageOptions.LargeImage = CType(resources.GetObject("btnQuickCA.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnQuickCA.Name = "btnQuickCA"
        Me.btnQuickCA.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'ucCA
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
        Me.Name = "ucCA"
        Me.Size = New System.Drawing.Size(905, 502)
        CType(Me.dgvDisposal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.CABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFilterType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilterValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DuplicateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateDisposalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyReferenceNoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyCompanyNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlLoading As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cboFilterType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnAllRecord As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFilterValue As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRefNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dgvView As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgvDisposal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCA_KEY1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_DISP_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_DISP_YA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_DISP_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_DISP_WITHIN_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_DISP_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_DISP_QC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_DISP_BALANCE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_DISP_TWDV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_DISP_SPROCEED As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_DISP_BABC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_DISP_REMARKS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dgvCA As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents cboYA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents DsCA As EasyTemplate_Taxcom.dsCA
    Friend WithEvents btnImportExport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnQuickCA As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents TaxPayerFindBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem

End Class
