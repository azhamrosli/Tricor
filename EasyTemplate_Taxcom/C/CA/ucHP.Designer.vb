<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucHP
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
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucHP))
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colHP_KEY1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_YA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_PRINCIPAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_INTEREST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_TOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_NOTE_TITLE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_NOTE_TITLE2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.HPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCA = New EasyTemplate_Taxcom.dsCA()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colHP_KEY2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_KEY1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_PRINCIPAL1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_INTEREST1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_TOTAL1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_PAY_DUE_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_PAYMENT_PRINCIPAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_PAYMENT_INTEREST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_PAYMENT_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_YA1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_PAYMENT_TOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colHP_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_PREFIX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_REF_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_FILENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_YA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_COMPANY_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_ASSET_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_ASSET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_CATEGORY_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_PURCHASE_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_PURCHASE_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_PAYMENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_RESTRICTED_QC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_CODE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_PRINCIPAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_INTEREST_RATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_INTEREST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_TOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_NO_INST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_FIRST_INST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_DECIMAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_SCHE_METHOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.colCA_CATEGORY_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_RATE_AA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_RATE_IA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_ASSET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_ASSET_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_COMPANY_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_FILENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_PURCHASE_YEAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_PURCHASE_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_REF_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_MODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCA_PREFIX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_PURCHASE_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_PAYMENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_RESTRICTED_QC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_QUALIFYING_COST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_REMAIN_QC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_TWDV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_INCENTIVE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_CTRL_TRANSFER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHP_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_YA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCA_ACCELERATED = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dgvView = New DevExpress.XtraGrid.GridControl()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnAllRecord = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFilterValue = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.cboFilterType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.pnlLoading = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.cboYA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TaxPayerFindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtRefNo = New DevExpress.XtraEditors.TextEdit()
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
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFilterValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFilterType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHP_KEY1, Me.colHPD_KEY, Me.colHPD_YA, Me.colHPD_PRINCIPAL, Me.colHPD_INTEREST, Me.colHPD_TOTAL, Me.colHPD_NOTE_TITLE1, Me.colHPD_NOTE_TITLE2})
        Me.GridView3.GridControl = Me.GridControl1
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GridView3.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        '
        'colHP_KEY1
        '
        Me.colHP_KEY1.FieldName = "HP_KEY"
        Me.colHP_KEY1.Name = "colHP_KEY1"
        Me.colHP_KEY1.Visible = True
        Me.colHP_KEY1.VisibleIndex = 0
        '
        'colHPD_KEY
        '
        Me.colHPD_KEY.FieldName = "HPD_KEY"
        Me.colHPD_KEY.Name = "colHPD_KEY"
        Me.colHPD_KEY.Visible = True
        Me.colHPD_KEY.VisibleIndex = 1
        '
        'colHPD_YA
        '
        Me.colHPD_YA.FieldName = "HPD_YA"
        Me.colHPD_YA.Name = "colHPD_YA"
        Me.colHPD_YA.Visible = True
        Me.colHPD_YA.VisibleIndex = 2
        '
        'colHPD_PRINCIPAL
        '
        Me.colHPD_PRINCIPAL.FieldName = "HPD_PRINCIPAL"
        Me.colHPD_PRINCIPAL.Name = "colHPD_PRINCIPAL"
        Me.colHPD_PRINCIPAL.Visible = True
        Me.colHPD_PRINCIPAL.VisibleIndex = 3
        '
        'colHPD_INTEREST
        '
        Me.colHPD_INTEREST.FieldName = "HPD_INTEREST"
        Me.colHPD_INTEREST.Name = "colHPD_INTEREST"
        Me.colHPD_INTEREST.Visible = True
        Me.colHPD_INTEREST.VisibleIndex = 4
        '
        'colHPD_TOTAL
        '
        Me.colHPD_TOTAL.FieldName = "HPD_TOTAL"
        Me.colHPD_TOTAL.Name = "colHPD_TOTAL"
        Me.colHPD_TOTAL.Visible = True
        Me.colHPD_TOTAL.VisibleIndex = 5
        '
        'colHPD_NOTE_TITLE1
        '
        Me.colHPD_NOTE_TITLE1.FieldName = "HPD_NOTE_TITLE1"
        Me.colHPD_NOTE_TITLE1.Name = "colHPD_NOTE_TITLE1"
        Me.colHPD_NOTE_TITLE1.Visible = True
        Me.colHPD_NOTE_TITLE1.VisibleIndex = 6
        '
        'colHPD_NOTE_TITLE2
        '
        Me.colHPD_NOTE_TITLE2.FieldName = "HPD_NOTE_TITLE2"
        Me.colHPD_NOTE_TITLE2.Name = "colHPD_NOTE_TITLE2"
        Me.colHPD_NOTE_TITLE2.Visible = True
        Me.colHPD_NOTE_TITLE2.VisibleIndex = 7
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.HPBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GridView3
        GridLevelNode1.RelationName = "HP YEARLY"
        GridLevelNode2.LevelTemplate = Me.GridView4
        GridLevelNode2.RelationName = "HP INSTALLMENT"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.GridControl1.Location = New System.Drawing.Point(0, 134)
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(997, 391)
        Me.GridControl1.TabIndex = 40
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4, Me.GridView2, Me.GridView3})
        '
        'HPBindingSource
        '
        Me.HPBindingSource.DataMember = "HP"
        Me.HPBindingSource.DataSource = Me.DsCA
        '
        'DsCA
        '
        Me.DsCA.DataSetName = "dsCA"
        Me.DsCA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHP_KEY2, Me.colHPD_KEY1, Me.colHPD_PRINCIPAL1, Me.colHPD_INTEREST1, Me.colHPD_TOTAL1, Me.colHPD_PAY_DUE_DATE, Me.colHPD_PAYMENT_PRINCIPAL, Me.colHPD_PAYMENT_INTEREST, Me.colHPD_PAYMENT_DATE, Me.colHPD_YA1, Me.colHPD_PAYMENT_TOTAL})
        Me.GridView4.GridControl = Me.GridControl1
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView4.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsView.ColumnAutoWidth = False
        '
        'colHP_KEY2
        '
        Me.colHP_KEY2.FieldName = "HP_KEY"
        Me.colHP_KEY2.Name = "colHP_KEY2"
        Me.colHP_KEY2.Visible = True
        Me.colHP_KEY2.VisibleIndex = 0
        '
        'colHPD_KEY1
        '
        Me.colHPD_KEY1.FieldName = "HPD_KEY"
        Me.colHPD_KEY1.Name = "colHPD_KEY1"
        Me.colHPD_KEY1.Visible = True
        Me.colHPD_KEY1.VisibleIndex = 1
        '
        'colHPD_PRINCIPAL1
        '
        Me.colHPD_PRINCIPAL1.FieldName = "HPD_PRINCIPAL"
        Me.colHPD_PRINCIPAL1.Name = "colHPD_PRINCIPAL1"
        Me.colHPD_PRINCIPAL1.Visible = True
        Me.colHPD_PRINCIPAL1.VisibleIndex = 2
        '
        'colHPD_INTEREST1
        '
        Me.colHPD_INTEREST1.FieldName = "HPD_INTEREST"
        Me.colHPD_INTEREST1.Name = "colHPD_INTEREST1"
        Me.colHPD_INTEREST1.Visible = True
        Me.colHPD_INTEREST1.VisibleIndex = 3
        '
        'colHPD_TOTAL1
        '
        Me.colHPD_TOTAL1.FieldName = "HPD_TOTAL"
        Me.colHPD_TOTAL1.Name = "colHPD_TOTAL1"
        Me.colHPD_TOTAL1.Visible = True
        Me.colHPD_TOTAL1.VisibleIndex = 4
        '
        'colHPD_PAY_DUE_DATE
        '
        Me.colHPD_PAY_DUE_DATE.FieldName = "HPD_PAY_DUE_DATE"
        Me.colHPD_PAY_DUE_DATE.Name = "colHPD_PAY_DUE_DATE"
        Me.colHPD_PAY_DUE_DATE.Visible = True
        Me.colHPD_PAY_DUE_DATE.VisibleIndex = 5
        '
        'colHPD_PAYMENT_PRINCIPAL
        '
        Me.colHPD_PAYMENT_PRINCIPAL.FieldName = "HPD_PAYMENT_PRINCIPAL"
        Me.colHPD_PAYMENT_PRINCIPAL.Name = "colHPD_PAYMENT_PRINCIPAL"
        Me.colHPD_PAYMENT_PRINCIPAL.Visible = True
        Me.colHPD_PAYMENT_PRINCIPAL.VisibleIndex = 6
        '
        'colHPD_PAYMENT_INTEREST
        '
        Me.colHPD_PAYMENT_INTEREST.FieldName = "HPD_PAYMENT_INTEREST"
        Me.colHPD_PAYMENT_INTEREST.Name = "colHPD_PAYMENT_INTEREST"
        Me.colHPD_PAYMENT_INTEREST.Visible = True
        Me.colHPD_PAYMENT_INTEREST.VisibleIndex = 7
        '
        'colHPD_PAYMENT_DATE
        '
        Me.colHPD_PAYMENT_DATE.FieldName = "HPD_PAYMENT_DATE"
        Me.colHPD_PAYMENT_DATE.Name = "colHPD_PAYMENT_DATE"
        Me.colHPD_PAYMENT_DATE.Visible = True
        Me.colHPD_PAYMENT_DATE.VisibleIndex = 8
        '
        'colHPD_YA1
        '
        Me.colHPD_YA1.FieldName = "HPD_YA"
        Me.colHPD_YA1.Name = "colHPD_YA1"
        Me.colHPD_YA1.Visible = True
        Me.colHPD_YA1.VisibleIndex = 9
        '
        'colHPD_PAYMENT_TOTAL
        '
        Me.colHPD_PAYMENT_TOTAL.FieldName = "HPD_PAYMENT_TOTAL"
        Me.colHPD_PAYMENT_TOTAL.Name = "colHPD_PAYMENT_TOTAL"
        Me.colHPD_PAYMENT_TOTAL.Visible = True
        Me.colHPD_PAYMENT_TOTAL.VisibleIndex = 10
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHP_KEY, Me.colHP_PREFIX, Me.colHP_REF_NO, Me.colHP_NAME, Me.colHP_FILENO, Me.colHP_YA, Me.colHP_COMPANY_CODE, Me.colHP_SOURCENO, Me.colHP_ASSET_CODE, Me.colHP_ASSET, Me.colHP_CATEGORY_CODE, Me.colHP_PURCHASE_DATE, Me.colHP_PURCHASE_AMOUNT, Me.colHP_PAYMENT, Me.colHP_RESTRICTED_QC, Me.colHP_DESC, Me.colHP_CODE1, Me.colHP_PRINCIPAL, Me.colHP_INTEREST_RATE, Me.colHP_INTEREST, Me.colHP_TOTAL, Me.colHP_NO_INST, Me.colHP_FIRST_INST, Me.colHP_DECIMAL, Me.colHP_SCHE_METHOD})
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GridView2.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        '
        'colHP_KEY
        '
        Me.colHP_KEY.Caption = "No"
        Me.colHP_KEY.FieldName = "HP_KEY"
        Me.colHP_KEY.Name = "colHP_KEY"
        Me.colHP_KEY.Visible = True
        Me.colHP_KEY.VisibleIndex = 0
        '
        'colHP_PREFIX
        '
        Me.colHP_PREFIX.FieldName = "HP_PREFIX"
        Me.colHP_PREFIX.Name = "colHP_PREFIX"
        '
        'colHP_REF_NO
        '
        Me.colHP_REF_NO.Caption = "Reference No"
        Me.colHP_REF_NO.FieldName = "HP_REF_NO"
        Me.colHP_REF_NO.Name = "colHP_REF_NO"
        Me.colHP_REF_NO.Visible = True
        Me.colHP_REF_NO.VisibleIndex = 1
        Me.colHP_REF_NO.Width = 150
        '
        'colHP_NAME
        '
        Me.colHP_NAME.Caption = "Name"
        Me.colHP_NAME.FieldName = "HP_NAME"
        Me.colHP_NAME.Name = "colHP_NAME"
        Me.colHP_NAME.Visible = True
        Me.colHP_NAME.VisibleIndex = 2
        Me.colHP_NAME.Width = 250
        '
        'colHP_FILENO
        '
        Me.colHP_FILENO.FieldName = "HP_FILENO"
        Me.colHP_FILENO.Name = "colHP_FILENO"
        '
        'colHP_YA
        '
        Me.colHP_YA.FieldName = "HP_YA"
        Me.colHP_YA.Name = "colHP_YA"
        '
        'colHP_COMPANY_CODE
        '
        Me.colHP_COMPANY_CODE.FieldName = "HP_COMPANY_CODE"
        Me.colHP_COMPANY_CODE.Name = "colHP_COMPANY_CODE"
        '
        'colHP_SOURCENO
        '
        Me.colHP_SOURCENO.Caption = "Source No"
        Me.colHP_SOURCENO.FieldName = "HP_SOURCENO"
        Me.colHP_SOURCENO.Name = "colHP_SOURCENO"
        Me.colHP_SOURCENO.Visible = True
        Me.colHP_SOURCENO.VisibleIndex = 3
        '
        'colHP_ASSET_CODE
        '
        Me.colHP_ASSET_CODE.Caption = "Asset Code"
        Me.colHP_ASSET_CODE.FieldName = "HP_ASSET_CODE"
        Me.colHP_ASSET_CODE.Name = "colHP_ASSET_CODE"
        Me.colHP_ASSET_CODE.Visible = True
        Me.colHP_ASSET_CODE.VisibleIndex = 4
        '
        'colHP_ASSET
        '
        Me.colHP_ASSET.Caption = "Asset"
        Me.colHP_ASSET.FieldName = "HP_ASSET"
        Me.colHP_ASSET.Name = "colHP_ASSET"
        Me.colHP_ASSET.Visible = True
        Me.colHP_ASSET.VisibleIndex = 5
        Me.colHP_ASSET.Width = 250
        '
        'colHP_CATEGORY_CODE
        '
        Me.colHP_CATEGORY_CODE.Caption = "Category Code"
        Me.colHP_CATEGORY_CODE.FieldName = "HP_CATEGORY_CODE"
        Me.colHP_CATEGORY_CODE.Name = "colHP_CATEGORY_CODE"
        Me.colHP_CATEGORY_CODE.Visible = True
        Me.colHP_CATEGORY_CODE.VisibleIndex = 6
        '
        'colHP_PURCHASE_DATE
        '
        Me.colHP_PURCHASE_DATE.Caption = "Date of Purchase"
        Me.colHP_PURCHASE_DATE.FieldName = "HP_PURCHASE_DATE"
        Me.colHP_PURCHASE_DATE.Name = "colHP_PURCHASE_DATE"
        Me.colHP_PURCHASE_DATE.Visible = True
        Me.colHP_PURCHASE_DATE.VisibleIndex = 7
        '
        'colHP_PURCHASE_AMOUNT
        '
        Me.colHP_PURCHASE_AMOUNT.Caption = "Purchase Amount"
        Me.colHP_PURCHASE_AMOUNT.FieldName = "HP_PURCHASE_AMOUNT"
        Me.colHP_PURCHASE_AMOUNT.Name = "colHP_PURCHASE_AMOUNT"
        Me.colHP_PURCHASE_AMOUNT.Visible = True
        Me.colHP_PURCHASE_AMOUNT.VisibleIndex = 8
        '
        'colHP_PAYMENT
        '
        Me.colHP_PAYMENT.Caption = "Deposit"
        Me.colHP_PAYMENT.FieldName = "HP_PAYMENT"
        Me.colHP_PAYMENT.Name = "colHP_PAYMENT"
        Me.colHP_PAYMENT.Visible = True
        Me.colHP_PAYMENT.VisibleIndex = 9
        '
        'colHP_RESTRICTED_QC
        '
        Me.colHP_RESTRICTED_QC.Caption = "Restricted QC"
        Me.colHP_RESTRICTED_QC.FieldName = "HP_RESTRICTED_QC"
        Me.colHP_RESTRICTED_QC.Name = "colHP_RESTRICTED_QC"
        Me.colHP_RESTRICTED_QC.Visible = True
        Me.colHP_RESTRICTED_QC.VisibleIndex = 10
        '
        'colHP_DESC
        '
        Me.colHP_DESC.Caption = "HP Description"
        Me.colHP_DESC.FieldName = "HP_DESC"
        Me.colHP_DESC.Name = "colHP_DESC"
        Me.colHP_DESC.Visible = True
        Me.colHP_DESC.VisibleIndex = 11
        '
        'colHP_CODE1
        '
        Me.colHP_CODE1.Caption = "HP Code"
        Me.colHP_CODE1.FieldName = "HP_CODE"
        Me.colHP_CODE1.Name = "colHP_CODE1"
        Me.colHP_CODE1.Visible = True
        Me.colHP_CODE1.VisibleIndex = 12
        '
        'colHP_PRINCIPAL
        '
        Me.colHP_PRINCIPAL.Caption = "HP Principal"
        Me.colHP_PRINCIPAL.FieldName = "HP_PRINCIPAL"
        Me.colHP_PRINCIPAL.Name = "colHP_PRINCIPAL"
        Me.colHP_PRINCIPAL.Visible = True
        Me.colHP_PRINCIPAL.VisibleIndex = 13
        '
        'colHP_INTEREST_RATE
        '
        Me.colHP_INTEREST_RATE.FieldName = "HP_INTEREST_RATE"
        Me.colHP_INTEREST_RATE.Name = "colHP_INTEREST_RATE"
        '
        'colHP_INTEREST
        '
        Me.colHP_INTEREST.Caption = "HP Interest"
        Me.colHP_INTEREST.FieldName = "HP_INTEREST"
        Me.colHP_INTEREST.Name = "colHP_INTEREST"
        Me.colHP_INTEREST.Visible = True
        Me.colHP_INTEREST.VisibleIndex = 14
        '
        'colHP_TOTAL
        '
        Me.colHP_TOTAL.Caption = "Total"
        Me.colHP_TOTAL.FieldName = "HP_TOTAL"
        Me.colHP_TOTAL.Name = "colHP_TOTAL"
        Me.colHP_TOTAL.Visible = True
        Me.colHP_TOTAL.VisibleIndex = 15
        '
        'colHP_NO_INST
        '
        Me.colHP_NO_INST.FieldName = "HP_NO_INST"
        Me.colHP_NO_INST.Name = "colHP_NO_INST"
        '
        'colHP_FIRST_INST
        '
        Me.colHP_FIRST_INST.FieldName = "HP_FIRST_INST"
        Me.colHP_FIRST_INST.Name = "colHP_FIRST_INST"
        '
        'colHP_DECIMAL
        '
        Me.colHP_DECIMAL.FieldName = "HP_DECIMAL"
        Me.colHP_DECIMAL.Name = "colHP_DECIMAL"
        '
        'colHP_SCHE_METHOD
        '
        Me.colHP_SCHE_METHOD.FieldName = "HP_SCHE_METHOD"
        Me.colHP_SCHE_METHOD.Name = "colHP_SCHE_METHOD"
        '
        'BarManager1
        '
        Me.BarManager1.AllowQuickCustomization = False
        Me.BarManager1.AllowShowToolbarsPopup = False
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.BarDockControl1)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnAdd, Me.btnEdit, Me.btnDelete, Me.btnPrint})
        Me.BarManager1.MaxItemId = 7
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrint)})
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
        Me.btnAdd.Glyph = CType(resources.GetObject("btnAdd.Glyph"), System.Drawing.Image)
        Me.btnAdd.Id = 0
        Me.btnAdd.LargeGlyph = CType(resources.GetObject("btnAdd.LargeGlyph"), System.Drawing.Image)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnEdit
        '
        Me.btnEdit.Caption = "Edit"
        Me.btnEdit.Glyph = CType(resources.GetObject("btnEdit.Glyph"), System.Drawing.Image)
        Me.btnEdit.Id = 1
        Me.btnEdit.LargeGlyph = CType(resources.GetObject("btnEdit.LargeGlyph"), System.Drawing.Image)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnDelete
        '
        Me.btnDelete.Caption = "Delete"
        Me.btnDelete.Glyph = CType(resources.GetObject("btnDelete.Glyph"), System.Drawing.Image)
        Me.btnDelete.Id = 2
        Me.btnDelete.LargeGlyph = CType(resources.GetObject("btnDelete.LargeGlyph"), System.Drawing.Image)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
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
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(997, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 525)
        Me.barDockControlBottom.Size = New System.Drawing.Size(997, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 494)
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl1.Location = New System.Drawing.Point(997, 31)
        Me.BarDockControl1.Size = New System.Drawing.Size(0, 494)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(997, 31)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 494)
        '
        'colCA_CATEGORY_CODE
        '
        Me.colCA_CATEGORY_CODE.Caption = "Category Code"
        Me.colCA_CATEGORY_CODE.FieldName = "CA_CATEGORY_CODE"
        Me.colCA_CATEGORY_CODE.Name = "colCA_CATEGORY_CODE"
        Me.colCA_CATEGORY_CODE.Visible = True
        Me.colCA_CATEGORY_CODE.VisibleIndex = 9
        '
        'colCA_RATE_AA
        '
        Me.colCA_RATE_AA.Caption = "AA Rate %"
        Me.colCA_RATE_AA.FieldName = "CA_RATE_AA"
        Me.colCA_RATE_AA.Name = "colCA_RATE_AA"
        Me.colCA_RATE_AA.Visible = True
        Me.colCA_RATE_AA.VisibleIndex = 8
        '
        'colCA_RATE_IA
        '
        Me.colCA_RATE_IA.Caption = "IA Rate %"
        Me.colCA_RATE_IA.FieldName = "CA_RATE_IA"
        Me.colCA_RATE_IA.Name = "colCA_RATE_IA"
        Me.colCA_RATE_IA.Visible = True
        Me.colCA_RATE_IA.VisibleIndex = 7
        '
        'colCA_ASSET
        '
        Me.colCA_ASSET.Caption = "Asset"
        Me.colCA_ASSET.FieldName = "CA_ASSET"
        Me.colCA_ASSET.Name = "colCA_ASSET"
        Me.colCA_ASSET.Visible = True
        Me.colCA_ASSET.VisibleIndex = 6
        '
        'colCA_ASSET_CODE
        '
        Me.colCA_ASSET_CODE.Caption = "Asset Code"
        Me.colCA_ASSET_CODE.FieldName = "CA_ASSET_CODE"
        Me.colCA_ASSET_CODE.Name = "colCA_ASSET_CODE"
        Me.colCA_ASSET_CODE.Visible = True
        Me.colCA_ASSET_CODE.VisibleIndex = 5
        '
        'colCA_SOURCENO
        '
        Me.colCA_SOURCENO.Caption = "Source No"
        Me.colCA_SOURCENO.FieldName = "CA_SOURCENO"
        Me.colCA_SOURCENO.Name = "colCA_SOURCENO"
        Me.colCA_SOURCENO.Visible = True
        Me.colCA_SOURCENO.VisibleIndex = 4
        '
        'colCA_COMPANY_CODE
        '
        Me.colCA_COMPANY_CODE.FieldName = "CA_COMPANY_CODE"
        Me.colCA_COMPANY_CODE.Name = "colCA_COMPANY_CODE"
        '
        'colCA_FILENO
        '
        Me.colCA_FILENO.FieldName = "CA_FILENO"
        Me.colCA_FILENO.Name = "colCA_FILENO"
        '
        'colCA_PURCHASE_YEAR
        '
        Me.colCA_PURCHASE_YEAR.Caption = "Purchase YE"
        Me.colCA_PURCHASE_YEAR.FieldName = "CA_PURCHASE_YEAR"
        Me.colCA_PURCHASE_YEAR.Name = "colCA_PURCHASE_YEAR"
        Me.colCA_PURCHASE_YEAR.Visible = True
        Me.colCA_PURCHASE_YEAR.VisibleIndex = 3
        '
        'colCA_NAME
        '
        Me.colCA_NAME.Caption = "Name"
        Me.colCA_NAME.FieldName = "CA_NAME"
        Me.colCA_NAME.Name = "colCA_NAME"
        Me.colCA_NAME.Visible = True
        Me.colCA_NAME.VisibleIndex = 2
        '
        'colCA_PURCHASE_DATE
        '
        Me.colCA_PURCHASE_DATE.Caption = "Purchase Date"
        Me.colCA_PURCHASE_DATE.FieldName = "CA_PURCHASE_DATE"
        Me.colCA_PURCHASE_DATE.Name = "colCA_PURCHASE_DATE"
        Me.colCA_PURCHASE_DATE.Visible = True
        Me.colCA_PURCHASE_DATE.VisibleIndex = 10
        '
        'colCA_REF_NO
        '
        Me.colCA_REF_NO.Caption = "Reference No"
        Me.colCA_REF_NO.FieldName = "CA_REF_NO"
        Me.colCA_REF_NO.Name = "colCA_REF_NO"
        Me.colCA_REF_NO.Visible = True
        Me.colCA_REF_NO.VisibleIndex = 1
        '
        'colCA_MODE
        '
        Me.colCA_MODE.FieldName = "CA_MODE"
        Me.colCA_MODE.Name = "colCA_MODE"
        '
        'colCA_KEY
        '
        Me.colCA_KEY.Caption = "No"
        Me.colCA_KEY.FieldName = "CA_KEY"
        Me.colCA_KEY.Name = "colCA_KEY"
        Me.colCA_KEY.Visible = True
        Me.colCA_KEY.VisibleIndex = 0
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCA_KEY, Me.colCA_MODE, Me.colCA_PREFIX, Me.colCA_REF_NO, Me.colCA_NAME, Me.colCA_PURCHASE_YEAR, Me.colCA_FILENO, Me.colCA_COMPANY_CODE, Me.colCA_SOURCENO, Me.colCA_ASSET_CODE, Me.colCA_ASSET, Me.colCA_RATE_IA, Me.colCA_RATE_AA, Me.colCA_CATEGORY_CODE, Me.colCA_PURCHASE_DATE, Me.colCA_PURCHASE_AMOUNT, Me.colCA_PAYMENT, Me.colCA_RESTRICTED_QC, Me.colCA_DESC, Me.colCA_QUALIFYING_COST, Me.colCA_REMAIN_QC, Me.colCA_TWDV, Me.colCA_INCENTIVE, Me.colCA_CTRL_TRANSFER, Me.colHP_CODE, Me.colCA_YA, Me.colCA_ACCELERATED})
        Me.GridView1.GridControl = Me.dgvView
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'colCA_PREFIX
        '
        Me.colCA_PREFIX.FieldName = "CA_PREFIX"
        Me.colCA_PREFIX.Name = "colCA_PREFIX"
        '
        'colCA_PURCHASE_AMOUNT
        '
        Me.colCA_PURCHASE_AMOUNT.Caption = "Purchase Amount"
        Me.colCA_PURCHASE_AMOUNT.FieldName = "CA_PURCHASE_AMOUNT"
        Me.colCA_PURCHASE_AMOUNT.Name = "colCA_PURCHASE_AMOUNT"
        Me.colCA_PURCHASE_AMOUNT.Visible = True
        Me.colCA_PURCHASE_AMOUNT.VisibleIndex = 11
        '
        'colCA_PAYMENT
        '
        Me.colCA_PAYMENT.FieldName = "CA_PAYMENT"
        Me.colCA_PAYMENT.Name = "colCA_PAYMENT"
        '
        'colCA_RESTRICTED_QC
        '
        Me.colCA_RESTRICTED_QC.FieldName = "CA_RESTRICTED_QC"
        Me.colCA_RESTRICTED_QC.Name = "colCA_RESTRICTED_QC"
        '
        'colCA_DESC
        '
        Me.colCA_DESC.FieldName = "CA_DESC"
        Me.colCA_DESC.Name = "colCA_DESC"
        '
        'colCA_QUALIFYING_COST
        '
        Me.colCA_QUALIFYING_COST.Caption = "Qualifying Cost (RM)"
        Me.colCA_QUALIFYING_COST.FieldName = "CA_QUALIFYING_COST"
        Me.colCA_QUALIFYING_COST.Name = "colCA_QUALIFYING_COST"
        Me.colCA_QUALIFYING_COST.Visible = True
        Me.colCA_QUALIFYING_COST.VisibleIndex = 12
        '
        'colCA_REMAIN_QC
        '
        Me.colCA_REMAIN_QC.FieldName = "CA_REMAIN_QC"
        Me.colCA_REMAIN_QC.Name = "colCA_REMAIN_QC"
        '
        'colCA_TWDV
        '
        Me.colCA_TWDV.FieldName = "CA_TWDV"
        Me.colCA_TWDV.Name = "colCA_TWDV"
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
        Me.colHP_CODE.VisibleIndex = 14
        '
        'colCA_YA
        '
        Me.colCA_YA.Caption = "YA"
        Me.colCA_YA.FieldName = "CA_YA"
        Me.colCA_YA.Name = "colCA_YA"
        Me.colCA_YA.Visible = True
        Me.colCA_YA.VisibleIndex = 13
        '
        'colCA_ACCELERATED
        '
        Me.colCA_ACCELERATED.FieldName = "CA_ACCELERATED"
        Me.colCA_ACCELERATED.Name = "colCA_ACCELERATED"
        '
        'dgvView
        '
        Me.dgvView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvView.Location = New System.Drawing.Point(0, 31)
        Me.dgvView.MainView = Me.GridView1
        Me.dgvView.Name = "dgvView"
        Me.dgvView.Size = New System.Drawing.Size(997, 494)
        Me.dgvView.TabIndex = 37
        Me.dgvView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(530, 15)
        Me.ComboBoxEdit1.MenuManager = Me.BarManager1
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"Asset Description", "Asset Code/ Stock No", "HP Code", "All"})
        Me.ComboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(268, 20)
        Me.ComboBoxEdit1.TabIndex = 9
        '
        'btnAllRecord
        '
        Me.btnAllRecord.Image = CType(resources.GetObject("btnAllRecord.Image"), System.Drawing.Image)
        Me.btnAllRecord.Location = New System.Drawing.Point(572, 67)
        Me.btnAllRecord.Name = "btnAllRecord"
        Me.btnAllRecord.Size = New System.Drawing.Size(110, 23)
        Me.btnAllRecord.TabIndex = 8
        Me.btnAllRecord.Text = "All Record"
        '
        'btnFind
        '
        Me.btnFind.Image = CType(resources.GetObject("btnFind.Image"), System.Drawing.Image)
        Me.btnFind.Location = New System.Drawing.Point(688, 67)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(110, 23)
        Me.btnFind.TabIndex = 7
        Me.btnFind.Text = "Find"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(409, 18)
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
        Me.LabelControl2.Location = New System.Drawing.Point(12, 44)
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
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl2.Location = New System.Drawing.Point(997, 31)
        Me.BarDockControl2.Size = New System.Drawing.Size(0, 494)
        '
        'cboFilterType
        '
        Me.cboFilterType.Location = New System.Drawing.Point(449, 67)
        Me.cboFilterType.Name = "cboFilterType"
        Me.cboFilterType.Size = New System.Drawing.Size(100, 20)
        Me.cboFilterType.TabIndex = 35
        Me.cboFilterType.Visible = False
        '
        'pnlLoading
        '
        Me.pnlLoading.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pnlLoading.Appearance.Options.UseBackColor = True
        Me.pnlLoading.AppearanceCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.pnlLoading.AppearanceCaption.Options.UseFont = True
        Me.pnlLoading.AppearanceDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.pnlLoading.AppearanceDescription.Options.UseFont = True
        Me.pnlLoading.Location = New System.Drawing.Point(388, 279)
        Me.pnlLoading.Name = "pnlLoading"
        Me.pnlLoading.Size = New System.Drawing.Size(246, 66)
        Me.pnlLoading.TabIndex = 38
        Me.pnlLoading.Text = "ProgressPanel1"
        Me.pnlLoading.Visible = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.cboRefNo)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Controls.Add(Me.btnClear)
        Me.PanelControl2.Controls.Add(Me.cboYA)
        Me.PanelControl2.Controls.Add(Me.txtRefNo)
        Me.PanelControl2.Controls.Add(Me.ComboBoxEdit1)
        Me.PanelControl2.Controls.Add(Me.cboFilterType)
        Me.PanelControl2.Controls.Add(Me.btnAllRecord)
        Me.PanelControl2.Controls.Add(Me.btnFind)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.txtFilterValue)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 31)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(997, 103)
        Me.PanelControl2.TabIndex = 39
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(804, 39)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(24, 23)
        Me.SimpleButton2.TabIndex = 41
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(365, 65)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(24, 23)
        Me.SimpleButton1.TabIndex = 40
        '
        'btnClear
        '
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.Location = New System.Drawing.Point(365, 13)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(24, 23)
        Me.btnClear.TabIndex = 39
        '
        'cboYA
        '
        Me.cboYA.Location = New System.Drawing.Point(91, 67)
        Me.cboYA.Name = "cboYA"
        Me.cboYA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboYA.Properties.PopupSizeable = True
        Me.cboYA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboYA.Size = New System.Drawing.Size(268, 20)
        Me.cboYA.TabIndex = 38
        '
        'TaxPayerFindBindingSource
        '
        Me.TaxPayerFindBindingSource.DataMember = "TaxPayerFind"
        Me.TaxPayerFindBindingSource.DataSource = Me.DsCA
        '
        'txtRefNo
        '
        Me.txtRefNo.Location = New System.Drawing.Point(91, 41)
        Me.txtRefNo.MenuManager = Me.BarManager1
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Properties.ReadOnly = True
        Me.txtRefNo.Size = New System.Drawing.Size(268, 20)
        Me.txtRefNo.TabIndex = 36
        '
        'cboRefNo
        '
        Me.cboRefNo.Location = New System.Drawing.Point(91, 15)
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
        'ucHP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlLoading)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.dgvView)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "ucHP"
        Me.Size = New System.Drawing.Size(997, 525)
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFilterValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFilterType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colCA_CATEGORY_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_RATE_AA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_RATE_IA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_ASSET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_ASSET_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_COMPANY_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_FILENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_PURCHASE_YEAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_PURCHASE_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_REF_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_MODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCA_PREFIX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_PURCHASE_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_PAYMENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_RESTRICTED_QC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_QUALIFYING_COST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_REMAIN_QC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_TWDV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_INCENTIVE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_CTRL_TRANSFER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_YA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCA_ACCELERATED As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dgvView As DevExpress.XtraGrid.GridControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents cboFilterType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents pnlLoading As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents HPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsCA As EasyTemplate_Taxcom.dsCA
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colHP_KEY1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_YA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_PRINCIPAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_INTEREST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_TOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_NOTE_TITLE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_NOTE_TITLE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colHP_KEY2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_KEY1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_PRINCIPAL1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_INTEREST1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_TOTAL1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_PAY_DUE_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_PAYMENT_PRINCIPAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_PAYMENT_INTEREST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_PAYMENT_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_YA1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_PAYMENT_TOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colHP_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_PREFIX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_REF_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_FILENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_YA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_COMPANY_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_ASSET_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_ASSET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_CATEGORY_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_PURCHASE_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_PURCHASE_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_PAYMENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_RESTRICTED_QC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_CODE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_PRINCIPAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_INTEREST_RATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_INTEREST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_TOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_NO_INST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_FIRST_INST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_DECIMAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_SCHE_METHOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnAllRecord As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFilterValue As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboYA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtRefNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TaxPayerFindBindingSource As System.Windows.Forms.BindingSource
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
