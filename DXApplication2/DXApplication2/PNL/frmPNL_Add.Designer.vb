<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPNL_Add
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPNL_Add))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim PushTransition1 As DevExpress.Utils.Animation.PushTransition = New DevExpress.Utils.Animation.PushTransition()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQ1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQ2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQ3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParentID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCAi = New DevExpress.XtraGrid.GridControl()
        Me.AiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPNL = New EasyTemplate_Taxcom_B.dsPNL()
        Me.GVAi = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFrom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommunication = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJobType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKeyName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BackstageViewControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewControl()
        Me.BackstageViewClientControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.BackstageViewTabItem1 = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.cboRefNo = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSearchLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.TaxPayerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDefault = New EasyTemplate_Taxcom_B.dsDefault()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRefNo_Prefix = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRefNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIC_Number = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPostcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colState = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHandleBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtRefNo = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.cboYA = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSearchLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.YABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemSearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colYA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboCompanyNo = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSearchLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.BusinessSourceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemSearchLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCompanyNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSourceNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboSourceNo = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSearchLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.BusinessSourceBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemSearchLookUpEdit4View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCompanyNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSourceNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.cboDecimalPlace = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.btnAllowAllGroupExpanded = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemToggleSwitch1 = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
        Me.btnWorkSpace = New DevExpress.XtraBars.BarWorkspaceMenuItem()
        Me.WorkspaceManager1 = New DevExpress.Utils.WorkspaceManager()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btnSpeech = New DevExpress.XtraBars.BarButtonItem()
        Me.btnStopSpeech = New DevExpress.XtraBars.BarButtonItem()
        Me.txtNetProfitAndLoss = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.btnViewPNLSolution = New DevExpress.XtraBars.BarButtonItem()
        Me.btnViewSearch = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RPGeneralInfo = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemSearchControl1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.ControlContainer1 = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.PNLSEARCHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_SEARCH = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmount1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOldKey1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSearch = New DevExpress.XtraEditors.TextEdit()
        Me.hideContainerBottom = New DevExpress.XtraBars.Docking.AutoHideContainer()
        Me.docAi = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.txtAi = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.lblProgress = New DevExpress.XtraBars.BarStaticItem()
        Me.btnProgress = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.docMainMenu = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.GC_MENU = New DevExpress.XtraGrid.GridControl()
        Me.PNLINFOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_MENU = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKeyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLabelID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTableName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTableName_Details = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColumnName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColumnKey = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColumnKey_Details = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColumnAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColumnAmount_Details = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOldKey = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColumnOldKey = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColumnOldKey_Details = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSequence = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        Me.ProgressPanel1 = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.chkDeclareB = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCAi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPNL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVAi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackstageViewControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BackstageViewControl1.SuspendLayout()
        CType(Me.RepositoryItemSearchLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusinessSourceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusinessSourceBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit4View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hideContainerRight.SuspendLayout()
        Me.DockPanel1.SuspendLayout()
        Me.ControlContainer1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PNLSEARCHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hideContainerBottom.SuspendLayout()
        Me.docAi.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        CType(Me.txtAi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.docMainMenu.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.GC_MENU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PNLINFOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_MENU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID3, Me.colDescription2, Me.colQ1, Me.colQ2, Me.colQ3, Me.colParentID})
        Me.GridView1.GridControl = Me.GCAi
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'colID3
        '
        Me.colID3.Caption = "ID"
        Me.colID3.FieldName = "ID"
        Me.colID3.Name = "colID3"
        Me.colID3.Visible = True
        Me.colID3.VisibleIndex = 0
        Me.colID3.Width = 20
        '
        'colDescription2
        '
        Me.colDescription2.Caption = "Result"
        Me.colDescription2.FieldName = "Description"
        Me.colDescription2.Name = "colDescription2"
        Me.colDescription2.Visible = True
        Me.colDescription2.VisibleIndex = 1
        '
        'colQ1
        '
        Me.colQ1.FieldName = "Q1"
        Me.colQ1.Name = "colQ1"
        '
        'colQ2
        '
        Me.colQ2.FieldName = "Q2"
        Me.colQ2.Name = "colQ2"
        '
        'colQ3
        '
        Me.colQ3.FieldName = "Q3"
        Me.colQ3.Name = "colQ3"
        '
        'colParentID
        '
        Me.colParentID.FieldName = "ParentID"
        Me.colParentID.Name = "colParentID"
        '
        'GCAi
        '
        Me.GCAi.DataSource = Me.AiBindingSource
        Me.GCAi.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GridView1
        GridLevelNode1.RelationName = "FK_Ai_Ai_Result"
        Me.GCAi.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GCAi.Location = New System.Drawing.Point(0, 0)
        Me.GCAi.MainView = Me.GVAi
        Me.GCAi.MenuManager = Me.RibbonControl1
        Me.GCAi.Name = "GCAi"
        Me.GCAi.Size = New System.Drawing.Size(1241, 300)
        Me.GCAi.TabIndex = 1
        Me.GCAi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVAi, Me.GridView1})
        '
        'AiBindingSource
        '
        Me.AiBindingSource.DataMember = "Ai"
        Me.AiBindingSource.DataSource = Me.DsPNL
        '
        'DsPNL
        '
        Me.DsPNL.DataSetName = "dsPNL"
        Me.DsPNL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GVAi
        '
        Me.GVAi.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID2, Me.colFrom, Me.colCommunication, Me.colJobType, Me.colKeyName1})
        Me.GVAi.GridControl = Me.GCAi
        Me.GVAi.Name = "GVAi"
        Me.GVAi.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GVAi.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GVAi.OptionsBehavior.Editable = False
        Me.GVAi.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        '
        'colID2
        '
        Me.colID2.Caption = "ID"
        Me.colID2.FieldName = "ID"
        Me.colID2.Name = "colID2"
        '
        'colFrom
        '
        Me.colFrom.FieldName = "From"
        Me.colFrom.Name = "colFrom"
        Me.colFrom.Visible = True
        Me.colFrom.VisibleIndex = 0
        Me.colFrom.Width = 100
        '
        'colCommunication
        '
        Me.colCommunication.FieldName = "Communication"
        Me.colCommunication.Name = "colCommunication"
        Me.colCommunication.Visible = True
        Me.colCommunication.VisibleIndex = 1
        Me.colCommunication.Width = 325
        '
        'colJobType
        '
        Me.colJobType.FieldName = "JobType"
        Me.colJobType.Name = "colJobType"
        Me.colJobType.Width = 325
        '
        'colKeyName1
        '
        Me.colKeyName1.FieldName = "KeyName"
        Me.colKeyName1.Name = "colKeyName1"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonDropDownControl = Me.BackstageViewControl1
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnRefresh, Me.cboRefNo, Me.txtRefNo, Me.cboYA, Me.cboCompanyNo, Me.cboSourceNo, Me.btnClose, Me.cboDecimalPlace, Me.btnAllowAllGroupExpanded, Me.btnWorkSpace, Me.SkinRibbonGalleryBarItem1, Me.btnSpeech, Me.btnStopSpeech, Me.txtNetProfitAndLoss, Me.btnViewPNLSolution, Me.btnViewSearch, Me.chkDeclareB})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 24
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchLookUpEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemSearchLookUpEdit2, Me.RepositoryItemSearchLookUpEdit3, Me.RepositoryItemSearchLookUpEdit4, Me.RepositoryItemComboBox1, Me.RepositoryItemToggleSwitch1, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4, Me.RepositoryItemSearchControl1, Me.RepositoryItemCheckEdit1})
        Me.RibbonControl1.Size = New System.Drawing.Size(1268, 141)
        '
        'BackstageViewControl1
        '
        Me.BackstageViewControl1.Controls.Add(Me.BackstageViewClientControl1)
        Me.BackstageViewControl1.Items.Add(Me.BackstageViewTabItem1)
        Me.BackstageViewControl1.Location = New System.Drawing.Point(70, 211)
        Me.BackstageViewControl1.Name = "BackstageViewControl1"
        Me.BackstageViewControl1.OwnerControl = Me.RibbonControl1
        Me.BackstageViewControl1.Size = New System.Drawing.Size(480, 150)
        Me.BackstageViewControl1.TabIndex = 6
        '
        'BackstageViewClientControl1
        '
        Me.BackstageViewClientControl1.Location = New System.Drawing.Point(0, 0)
        Me.BackstageViewClientControl1.Name = "BackstageViewClientControl1"
        Me.BackstageViewClientControl1.Size = New System.Drawing.Size(150, 150)
        Me.BackstageViewClientControl1.TabIndex = 1
        '
        'BackstageViewTabItem1
        '
        Me.BackstageViewTabItem1.Caption = "BackstageViewTabItem1"
        Me.BackstageViewTabItem1.ContentControl = Me.BackstageViewClientControl1
        Me.BackstageViewTabItem1.Name = "BackstageViewTabItem1"
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 1
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.ImageOptions.LargeImage = CType(resources.GetObject("btnSave.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSave.Name = "btnSave"
        '
        'btnRefresh
        '
        Me.btnRefresh.Caption = "Refresh"
        Me.btnRefresh.Id = 2
        Me.btnRefresh.ImageOptions.Image = CType(resources.GetObject("btnRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageOptions.LargeImage = CType(resources.GetObject("btnRefresh.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnRefresh.Name = "btnRefresh"
        '
        'cboRefNo
        '
        Me.cboRefNo.Caption = "Tax Payer :"
        Me.cboRefNo.Edit = Me.RepositoryItemSearchLookUpEdit1
        Me.cboRefNo.EditWidth = 150
        Me.cboRefNo.Id = 4
        Me.cboRefNo.Name = "cboRefNo"
        '
        'RepositoryItemSearchLookUpEdit1
        '
        Me.RepositoryItemSearchLookUpEdit1.AutoHeight = False
        Me.RepositoryItemSearchLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSearchLookUpEdit1.DataSource = Me.TaxPayerBindingSource
        Me.RepositoryItemSearchLookUpEdit1.DisplayMember = "Name"
        Me.RepositoryItemSearchLookUpEdit1.Name = "RepositoryItemSearchLookUpEdit1"
        Me.RepositoryItemSearchLookUpEdit1.NullText = "Select"
        Me.RepositoryItemSearchLookUpEdit1.PopupFormMinSize = New System.Drawing.Size(350, 0)
        Me.RepositoryItemSearchLookUpEdit1.PopupFormSize = New System.Drawing.Size(500, 0)
        Me.RepositoryItemSearchLookUpEdit1.ValueMember = "RefNo"
        Me.RepositoryItemSearchLookUpEdit1.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'TaxPayerBindingSource
        '
        Me.TaxPayerBindingSource.DataMember = "TaxPayer"
        Me.TaxPayerBindingSource.DataSource = Me.DsDefault
        '
        'DsDefault
        '
        Me.DsDefault.DataSetName = "dsDefault"
        Me.DsDefault.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRefNo_Prefix, Me.colRefNo, Me.colName, Me.colIC_Number, Me.colAddress1, Me.colAddress2, Me.colAddress3, Me.colPostcode, Me.colCity, Me.colState, Me.colCountry, Me.colHandleBy})
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemSearchLookUpEdit1View.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemSearchLookUpEdit1View.OptionsBehavior.Editable = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ColumnAutoWidth = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.RowAutoHeight = True
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colRefNo_Prefix
        '
        Me.colRefNo_Prefix.Caption = "Prefix"
        Me.colRefNo_Prefix.FieldName = "RefNo_Prefix"
        Me.colRefNo_Prefix.Name = "colRefNo_Prefix"
        Me.colRefNo_Prefix.Visible = True
        Me.colRefNo_Prefix.VisibleIndex = 0
        Me.colRefNo_Prefix.Width = 100
        '
        'colRefNo
        '
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
        Me.colName.Width = 200
        '
        'colIC_Number
        '
        Me.colIC_Number.Caption = "IC Number"
        Me.colIC_Number.FieldName = "IC_Number"
        Me.colIC_Number.Name = "colIC_Number"
        Me.colIC_Number.Visible = True
        Me.colIC_Number.VisibleIndex = 3
        Me.colIC_Number.Width = 120
        '
        'colAddress1
        '
        Me.colAddress1.Caption = "Address 1"
        Me.colAddress1.FieldName = "Address1"
        Me.colAddress1.Name = "colAddress1"
        Me.colAddress1.Visible = True
        Me.colAddress1.VisibleIndex = 4
        Me.colAddress1.Width = 200
        '
        'colAddress2
        '
        Me.colAddress2.Caption = "Address 2"
        Me.colAddress2.FieldName = "Address2"
        Me.colAddress2.Name = "colAddress2"
        Me.colAddress2.Visible = True
        Me.colAddress2.VisibleIndex = 5
        Me.colAddress2.Width = 200
        '
        'colAddress3
        '
        Me.colAddress3.Caption = "Address 3"
        Me.colAddress3.FieldName = "Address3"
        Me.colAddress3.Name = "colAddress3"
        Me.colAddress3.Visible = True
        Me.colAddress3.VisibleIndex = 6
        Me.colAddress3.Width = 200
        '
        'colPostcode
        '
        Me.colPostcode.Caption = "Postcode"
        Me.colPostcode.FieldName = "Postcode"
        Me.colPostcode.Name = "colPostcode"
        Me.colPostcode.Visible = True
        Me.colPostcode.VisibleIndex = 7
        Me.colPostcode.Width = 150
        '
        'colCity
        '
        Me.colCity.Caption = "City"
        Me.colCity.FieldName = "City"
        Me.colCity.Name = "colCity"
        Me.colCity.Visible = True
        Me.colCity.VisibleIndex = 8
        Me.colCity.Width = 150
        '
        'colState
        '
        Me.colState.Caption = "State"
        Me.colState.FieldName = "State"
        Me.colState.Name = "colState"
        Me.colState.Visible = True
        Me.colState.VisibleIndex = 9
        Me.colState.Width = 150
        '
        'colCountry
        '
        Me.colCountry.Caption = "Country"
        Me.colCountry.FieldName = "Country"
        Me.colCountry.Name = "colCountry"
        Me.colCountry.Visible = True
        Me.colCountry.VisibleIndex = 10
        Me.colCountry.Width = 150
        '
        'colHandleBy
        '
        Me.colHandleBy.Caption = "Handle By"
        Me.colHandleBy.FieldName = "HandleBy"
        Me.colHandleBy.Name = "colHandleBy"
        Me.colHandleBy.Visible = True
        Me.colHandleBy.VisibleIndex = 11
        Me.colHandleBy.Width = 120
        '
        'txtRefNo
        '
        Me.txtRefNo.Caption = "Tax Payer :"
        Me.txtRefNo.Edit = Me.RepositoryItemTextEdit1
        Me.txtRefNo.EditWidth = 150
        Me.txtRefNo.Id = 5
        Me.txtRefNo.Name = "txtRefNo"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.ReadOnly = True
        '
        'cboYA
        '
        Me.cboYA.Caption = "YA :            "
        Me.cboYA.Edit = Me.RepositoryItemSearchLookUpEdit2
        Me.cboYA.EditWidth = 150
        Me.cboYA.Id = 6
        Me.cboYA.Name = "cboYA"
        '
        'RepositoryItemSearchLookUpEdit2
        '
        Me.RepositoryItemSearchLookUpEdit2.AutoHeight = False
        Me.RepositoryItemSearchLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSearchLookUpEdit2.DataSource = Me.YABindingSource
        Me.RepositoryItemSearchLookUpEdit2.DisplayMember = "YA"
        Me.RepositoryItemSearchLookUpEdit2.Name = "RepositoryItemSearchLookUpEdit2"
        Me.RepositoryItemSearchLookUpEdit2.NullText = "Select"
        Me.RepositoryItemSearchLookUpEdit2.PopupFormSize = New System.Drawing.Size(100, 0)
        Me.RepositoryItemSearchLookUpEdit2.ValueMember = "YA"
        Me.RepositoryItemSearchLookUpEdit2.View = Me.RepositoryItemSearchLookUpEdit2View
        '
        'YABindingSource
        '
        Me.YABindingSource.DataMember = "YA"
        Me.YABindingSource.DataSource = Me.DsDefault
        '
        'RepositoryItemSearchLookUpEdit2View
        '
        Me.RepositoryItemSearchLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colYA})
        Me.RepositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit2View.Name = "RepositoryItemSearchLookUpEdit2View"
        Me.RepositoryItemSearchLookUpEdit2View.OptionsBehavior.Editable = False
        Me.RepositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colYA
        '
        Me.colYA.AppearanceCell.Options.UseTextOptions = True
        Me.colYA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYA.Caption = "YA"
        Me.colYA.FieldName = "YA"
        Me.colYA.Name = "colYA"
        Me.colYA.Visible = True
        Me.colYA.VisibleIndex = 0
        '
        'cboCompanyNo
        '
        Me.cboCompanyNo.Caption = "Company No :"
        Me.cboCompanyNo.Edit = Me.RepositoryItemSearchLookUpEdit3
        Me.cboCompanyNo.EditWidth = 150
        Me.cboCompanyNo.Id = 7
        Me.cboCompanyNo.Name = "cboCompanyNo"
        '
        'RepositoryItemSearchLookUpEdit3
        '
        Me.RepositoryItemSearchLookUpEdit3.AutoHeight = False
        Me.RepositoryItemSearchLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSearchLookUpEdit3.DataSource = Me.BusinessSourceBindingSource
        Me.RepositoryItemSearchLookUpEdit3.DisplayMember = "CompanyNo"
        Me.RepositoryItemSearchLookUpEdit3.Name = "RepositoryItemSearchLookUpEdit3"
        Me.RepositoryItemSearchLookUpEdit3.NullText = "Select"
        Me.RepositoryItemSearchLookUpEdit3.PopupSizeable = False
        Me.RepositoryItemSearchLookUpEdit3.ValueMember = "CompanyNo"
        Me.RepositoryItemSearchLookUpEdit3.View = Me.RepositoryItemSearchLookUpEdit3View
        '
        'BusinessSourceBindingSource
        '
        Me.BusinessSourceBindingSource.DataMember = "Business_Source"
        Me.BusinessSourceBindingSource.DataSource = Me.DsDefault
        '
        'RepositoryItemSearchLookUpEdit3View
        '
        Me.RepositoryItemSearchLookUpEdit3View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCompanyNo, Me.colSourceNo, Me.colCode, Me.colType})
        Me.RepositoryItemSearchLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit3View.Name = "RepositoryItemSearchLookUpEdit3View"
        Me.RepositoryItemSearchLookUpEdit3View.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemSearchLookUpEdit3View.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemSearchLookUpEdit3View.OptionsBehavior.Editable = False
        Me.RepositoryItemSearchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit3View.OptionsView.ColumnAutoWidth = False
        Me.RepositoryItemSearchLookUpEdit3View.OptionsView.RowAutoHeight = True
        Me.RepositoryItemSearchLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'colCompanyNo
        '
        Me.colCompanyNo.FieldName = "CompanyNo"
        Me.colCompanyNo.Name = "colCompanyNo"
        Me.colCompanyNo.Visible = True
        Me.colCompanyNo.VisibleIndex = 0
        Me.colCompanyNo.Width = 120
        '
        'colSourceNo
        '
        Me.colSourceNo.FieldName = "SourceNo"
        Me.colSourceNo.Name = "colSourceNo"
        Me.colSourceNo.Width = 120
        '
        'colCode
        '
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 1
        Me.colCode.Width = 100
        '
        'colType
        '
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 2
        Me.colType.Width = 300
        '
        'cboSourceNo
        '
        Me.cboSourceNo.Caption = "Main Source :"
        Me.cboSourceNo.Edit = Me.RepositoryItemSearchLookUpEdit4
        Me.cboSourceNo.EditWidth = 150
        Me.cboSourceNo.Id = 8
        Me.cboSourceNo.Name = "cboSourceNo"
        '
        'RepositoryItemSearchLookUpEdit4
        '
        Me.RepositoryItemSearchLookUpEdit4.AutoHeight = False
        Me.RepositoryItemSearchLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSearchLookUpEdit4.DataSource = Me.BusinessSourceBindingSource1
        Me.RepositoryItemSearchLookUpEdit4.DisplayMember = "SourceNo"
        Me.RepositoryItemSearchLookUpEdit4.Name = "RepositoryItemSearchLookUpEdit4"
        Me.RepositoryItemSearchLookUpEdit4.NullText = "Select"
        Me.RepositoryItemSearchLookUpEdit4.ValueMember = "SourceNo"
        Me.RepositoryItemSearchLookUpEdit4.View = Me.RepositoryItemSearchLookUpEdit4View
        '
        'BusinessSourceBindingSource1
        '
        Me.BusinessSourceBindingSource1.DataMember = "Business_Source"
        Me.BusinessSourceBindingSource1.DataSource = Me.DsDefault
        '
        'RepositoryItemSearchLookUpEdit4View
        '
        Me.RepositoryItemSearchLookUpEdit4View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCompanyNo1, Me.colSourceNo1, Me.colCode1, Me.colType1})
        Me.RepositoryItemSearchLookUpEdit4View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit4View.Name = "RepositoryItemSearchLookUpEdit4View"
        Me.RepositoryItemSearchLookUpEdit4View.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemSearchLookUpEdit4View.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemSearchLookUpEdit4View.OptionsBehavior.Editable = False
        Me.RepositoryItemSearchLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit4View.OptionsView.ColumnAutoWidth = False
        Me.RepositoryItemSearchLookUpEdit4View.OptionsView.ShowGroupPanel = False
        '
        'colCompanyNo1
        '
        Me.colCompanyNo1.FieldName = "CompanyNo"
        Me.colCompanyNo1.Name = "colCompanyNo1"
        '
        'colSourceNo1
        '
        Me.colSourceNo1.FieldName = "SourceNo"
        Me.colSourceNo1.Name = "colSourceNo1"
        Me.colSourceNo1.Visible = True
        Me.colSourceNo1.VisibleIndex = 0
        Me.colSourceNo1.Width = 120
        '
        'colCode1
        '
        Me.colCode1.FieldName = "Code"
        Me.colCode1.Name = "colCode1"
        Me.colCode1.Visible = True
        Me.colCode1.VisibleIndex = 1
        Me.colCode1.Width = 120
        '
        'colType1
        '
        Me.colType1.FieldName = "Type"
        Me.colType1.Name = "colType1"
        Me.colType1.Visible = True
        Me.colType1.VisibleIndex = 2
        Me.colType1.Width = 300
        '
        'btnClose
        '
        Me.btnClose.Caption = "Close"
        Me.btnClose.Id = 10
        Me.btnClose.ImageOptions.Image = CType(resources.GetObject("btnClose.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClose.ImageOptions.LargeImage = CType(resources.GetObject("btnClose.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnClose.Name = "btnClose"
        '
        'cboDecimalPlace
        '
        Me.cboDecimalPlace.Caption = "Decimal Place"
        Me.cboDecimalPlace.Edit = Me.RepositoryItemComboBox1
        Me.cboDecimalPlace.EditWidth = 130
        Me.cboDecimalPlace.Id = 11
        Me.cboDecimalPlace.Name = "cboDecimalPlace"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"0 =  Exp : 1000", "1 =  Exp : 1000.1", "2 =  Exp : 1000.10", "3 =  Exp : 1000.100"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'btnAllowAllGroupExpanded
        '
        Me.btnAllowAllGroupExpanded.Caption = "Allow All Group Expanded"
        Me.btnAllowAllGroupExpanded.Edit = Me.RepositoryItemToggleSwitch1
        Me.btnAllowAllGroupExpanded.Id = 12
        Me.btnAllowAllGroupExpanded.Name = "btnAllowAllGroupExpanded"
        ToolTipTitleItem1.Text = "Allow All Group Expanded"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = " ""Yes"" = You can expand more than one group." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """No"" = Only selected row can be exp" & _
    "and"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btnAllowAllGroupExpanded.SuperTip = SuperToolTip1
        '
        'RepositoryItemToggleSwitch1
        '
        Me.RepositoryItemToggleSwitch1.AutoHeight = False
        Me.RepositoryItemToggleSwitch1.Name = "RepositoryItemToggleSwitch1"
        Me.RepositoryItemToggleSwitch1.OffText = "No"
        Me.RepositoryItemToggleSwitch1.OnText = "Yes"
        '
        'btnWorkSpace
        '
        Me.btnWorkSpace.Caption = "Work Space"
        Me.btnWorkSpace.Id = 13
        Me.btnWorkSpace.ImageOptions.Image = CType(resources.GetObject("btnWorkSpace.ImageOptions.Image"), System.Drawing.Image)
        Me.btnWorkSpace.ImageOptions.LargeImage = CType(resources.GetObject("btnWorkSpace.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnWorkSpace.Name = "btnWorkSpace"
        Me.btnWorkSpace.WorkspaceManager = Me.WorkspaceManager1
        '
        'WorkspaceManager1
        '
        Me.WorkspaceManager1.TargetControl = Me
        Me.WorkspaceManager1.TransitionType = PushTransition1
        '
        'SkinRibbonGalleryBarItem1
        '
        Me.SkinRibbonGalleryBarItem1.Caption = "SkinRibbonGalleryBarItem1"
        Me.SkinRibbonGalleryBarItem1.Id = 14
        Me.SkinRibbonGalleryBarItem1.Name = "SkinRibbonGalleryBarItem1"
        '
        'btnSpeech
        '
        Me.btnSpeech.Caption = "Speech Ai"
        Me.btnSpeech.Id = 15
        Me.btnSpeech.ImageOptions.Image = CType(resources.GetObject("btnSpeech.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSpeech.ImageOptions.LargeImage = CType(resources.GetObject("btnSpeech.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSpeech.Name = "btnSpeech"
        '
        'btnStopSpeech
        '
        Me.btnStopSpeech.Caption = "Stop Speech Ai"
        Me.btnStopSpeech.Id = 16
        Me.btnStopSpeech.ImageOptions.Image = CType(resources.GetObject("btnStopSpeech.ImageOptions.Image"), System.Drawing.Image)
        Me.btnStopSpeech.ImageOptions.LargeImage = CType(resources.GetObject("btnStopSpeech.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnStopSpeech.Name = "btnStopSpeech"
        '
        'txtNetProfitAndLoss
        '
        Me.txtNetProfitAndLoss.Caption = "Net Profit or Loss :"
        Me.txtNetProfitAndLoss.Edit = Me.RepositoryItemTextEdit3
        Me.txtNetProfitAndLoss.EditWidth = 200
        Me.txtNetProfitAndLoss.Id = 17
        Me.txtNetProfitAndLoss.Name = "txtNetProfitAndLoss"
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatString = "n0"
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit3.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        Me.RepositoryItemTextEdit3.NullText = "0"
        Me.RepositoryItemTextEdit3.NullValuePrompt = "0"
        Me.RepositoryItemTextEdit3.NullValuePromptShowForEmptyValue = True
        Me.RepositoryItemTextEdit3.ReadOnly = True
        '
        'btnViewPNLSolution
        '
        Me.btnViewPNLSolution.Caption = "Profit & Loss Solution"
        Me.btnViewPNLSolution.Id = 19
        Me.btnViewPNLSolution.Name = "btnViewPNLSolution"
        '
        'btnViewSearch
        '
        Me.btnViewSearch.Caption = "Search"
        Me.btnViewSearch.Id = 20
        Me.btnViewSearch.Name = "btnViewSearch"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RPGeneralInfo, Me.RibbonPageGroup7})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "General"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnRefresh)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnClose)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Action"
        '
        'RPGeneralInfo
        '
        Me.RPGeneralInfo.ItemLinks.Add(Me.cboRefNo)
        Me.RPGeneralInfo.ItemLinks.Add(Me.txtRefNo)
        Me.RPGeneralInfo.ItemLinks.Add(Me.cboYA)
        Me.RPGeneralInfo.ItemLinks.Add(Me.cboCompanyNo)
        Me.RPGeneralInfo.ItemLinks.Add(Me.cboSourceNo)
        Me.RPGeneralInfo.ItemLinks.Add(Me.chkDeclareB)
        Me.RPGeneralInfo.Name = "RPGeneralInfo"
        Me.RPGeneralInfo.Text = "General Information"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.ItemLinks.Add(Me.txtNetProfitAndLoss)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.Text = "Profit && Loss Information"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3, Me.RibbonPageGroup4, Me.RibbonPageGroup5, Me.RibbonPageGroup6})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Setting"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.cboDecimalPlace)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnAllowAllGroupExpanded)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Setting"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnWorkSpace)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Layout"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.SkinRibbonGalleryBarItem1)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "Theme"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnSpeech)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnStopSpeech)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.Text = "BETA"
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'RepositoryItemSearchControl1
        '
        Me.RepositoryItemSearchControl1.AutoHeight = False
        Me.RepositoryItemSearchControl1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.RepositoryItemSearchControl1.Name = "RepositoryItemSearchControl1"
        '
        'DockManager1
        '
        Me.DockManager1.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerRight, Me.hideContainerBottom})
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.docMainMenu})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'hideContainerRight
        '
        Me.hideContainerRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.hideContainerRight.Controls.Add(Me.DockPanel1)
        Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.hideContainerRight.Location = New System.Drawing.Point(1249, 141)
        Me.hideContainerRight.Name = "hideContainerRight"
        Me.hideContainerRight.Size = New System.Drawing.Size(19, 447)
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.ControlContainer1)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("544c8eda-22da-4660-bdae-cdd553362453")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(285, 200)
        Me.DockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.SavedIndex = 1
        Me.DockPanel1.Size = New System.Drawing.Size(285, 450)
        Me.DockPanel1.Text = "Search"
        Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'ControlContainer1
        '
        Me.ControlContainer1.Controls.Add(Me.GridControl1)
        Me.ControlContainer1.Controls.Add(Me.PanelControl1)
        Me.ControlContainer1.Location = New System.Drawing.Point(5, 23)
        Me.ControlContainer1.Name = "ControlContainer1"
        Me.ControlContainer1.Size = New System.Drawing.Size(276, 423)
        Me.ControlContainer1.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.PNLSEARCHBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 61)
        Me.GridControl1.MainView = Me.GV_SEARCH
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(276, 362)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_SEARCH})
        '
        'PNLSEARCHBindingSource
        '
        Me.PNLSEARCHBindingSource.DataMember = "PNL_SEARCH"
        Me.PNLSEARCHBindingSource.DataSource = Me.DsPNL
        '
        'GV_SEARCH
        '
        Me.GV_SEARCH.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID1, Me.colDescription1, Me.colAmount1, Me.colTitle, Me.colOldKey1})
        Me.GV_SEARCH.GridControl = Me.GridControl1
        Me.GV_SEARCH.Name = "GV_SEARCH"
        Me.GV_SEARCH.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV_SEARCH.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV_SEARCH.OptionsBehavior.Editable = False
        Me.GV_SEARCH.OptionsView.ColumnAutoWidth = False
        Me.GV_SEARCH.OptionsView.RowAutoHeight = True
        '
        'colID1
        '
        Me.colID1.FieldName = "ID"
        Me.colID1.Name = "colID1"
        '
        'colDescription1
        '
        Me.colDescription1.Caption = "Description"
        Me.colDescription1.FieldName = "Description"
        Me.colDescription1.Name = "colDescription1"
        Me.colDescription1.Visible = True
        Me.colDescription1.VisibleIndex = 0
        Me.colDescription1.Width = 300
        '
        'colAmount1
        '
        Me.colAmount1.Caption = "Amount"
        Me.colAmount1.DisplayFormat.FormatString = "n0"
        Me.colAmount1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAmount1.FieldName = "Amount"
        Me.colAmount1.Name = "colAmount1"
        Me.colAmount1.Visible = True
        Me.colAmount1.VisibleIndex = 1
        Me.colAmount1.Width = 150
        '
        'colTitle
        '
        Me.colTitle.Caption = "Title"
        Me.colTitle.FieldName = "Title"
        Me.colTitle.Name = "colTitle"
        Me.colTitle.Visible = True
        Me.colTitle.VisibleIndex = 2
        Me.colTitle.Width = 300
        '
        'colOldKey1
        '
        Me.colOldKey1.FieldName = "OldKey"
        Me.colOldKey1.Name = "colOldKey1"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnSearch)
        Me.PanelControl1.Controls.Add(Me.txtSearch)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(276, 61)
        Me.PanelControl1.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(193, 32)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(5, 5)
        Me.txtSearch.MenuManager = Me.RibbonControl1
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(266, 20)
        Me.txtSearch.TabIndex = 0
        '
        'hideContainerBottom
        '
        Me.hideContainerBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.hideContainerBottom.Controls.Add(Me.docAi)
        Me.hideContainerBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.hideContainerBottom.Location = New System.Drawing.Point(0, 569)
        Me.hideContainerBottom.Name = "hideContainerBottom"
        Me.hideContainerBottom.Size = New System.Drawing.Size(1249, 19)
        '
        'docAi
        '
        Me.docAi.Controls.Add(Me.DockPanel2_Container)
        Me.docAi.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
        Me.docAi.ID = New System.Guid("97a2bc8a-8cc5-4779-9d05-b921eb6bc4e2")
        Me.docAi.Location = New System.Drawing.Point(0, 0)
        Me.docAi.Name = "docAi"
        Me.docAi.OriginalSize = New System.Drawing.Size(200, 348)
        Me.docAi.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
        Me.docAi.SavedIndex = 1
        Me.docAi.Size = New System.Drawing.Size(1249, 348)
        Me.docAi.Text = "Ai"
        Me.docAi.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.GCAi)
        Me.DockPanel2_Container.Controls.Add(Me.txtAi)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 24)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(1241, 320)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'txtAi
        '
        Me.txtAi.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtAi.Location = New System.Drawing.Point(0, 300)
        Me.txtAi.MenuManager = Me.RibbonControl1
        Me.txtAi.Name = "txtAi"
        Me.txtAi.Properties.NullText = "Type open / insert / close / info then press enter"
        Me.txtAi.Size = New System.Drawing.Size(1241, 20)
        Me.txtAi.TabIndex = 0
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnProgress, Me.lblProgress})
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar1})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.lblProgress), New DevExpress.XtraBars.LinkPersistInfo(Me.btnProgress)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'lblProgress
        '
        Me.lblProgress.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.lblProgress.Caption = "Ready"
        Me.lblProgress.Id = 3
        Me.lblProgress.Name = "lblProgress"
        '
        'btnProgress
        '
        Me.btnProgress.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnProgress.Caption = "Welcome to Profit and Loss"
        Me.btnProgress.Edit = Me.RepositoryItemProgressBar1
        Me.btnProgress.Id = 0
        Me.btnProgress.Name = "btnProgress"
        Me.btnProgress.Size = New System.Drawing.Size(150, 0)
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1268, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 588)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1268, 25)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 588)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1268, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 588)
        '
        'docMainMenu
        '
        Me.docMainMenu.Controls.Add(Me.DockPanel1_Container)
        Me.docMainMenu.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.docMainMenu.FloatVertical = True
        Me.docMainMenu.ID = New System.Guid("7abe2b62-00b0-47ff-8c49-1cd6a03f7247")
        Me.docMainMenu.Location = New System.Drawing.Point(0, 141)
        Me.docMainMenu.Name = "docMainMenu"
        Me.docMainMenu.OriginalSize = New System.Drawing.Size(473, 200)
        Me.docMainMenu.Size = New System.Drawing.Size(473, 428)
        Me.docMainMenu.Text = "Profit & Loss"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.GC_MENU)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 24)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(464, 400)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'GC_MENU
        '
        Me.GC_MENU.DataSource = Me.PNLINFOBindingSource
        Me.GC_MENU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_MENU.Location = New System.Drawing.Point(0, 0)
        Me.GC_MENU.MainView = Me.GV_MENU
        Me.GC_MENU.MenuManager = Me.RibbonControl1
        Me.GC_MENU.Name = "GC_MENU"
        Me.GC_MENU.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit2})
        Me.GC_MENU.Size = New System.Drawing.Size(464, 400)
        Me.GC_MENU.TabIndex = 0
        Me.GC_MENU.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_MENU})
        '
        'PNLINFOBindingSource
        '
        Me.PNLINFOBindingSource.DataMember = "PNL_INFO"
        Me.PNLINFOBindingSource.DataSource = Me.DsPNL
        '
        'GV_MENU
        '
        Me.GV_MENU.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colKeyName, Me.colLabelID, Me.colTableName, Me.colTableName_Details, Me.colColumnName, Me.colColumnKey, Me.colColumnKey_Details, Me.colColumnAmount, Me.colColumnAmount_Details, Me.colOldKey, Me.colColumnOldKey, Me.colColumnOldKey_Details, Me.colDescription, Me.colSequence, Me.colAmount})
        Me.GV_MENU.GridControl = Me.GC_MENU
        Me.GV_MENU.Name = "GV_MENU"
        Me.GV_MENU.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV_MENU.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV_MENU.OptionsBehavior.Editable = False
        Me.GV_MENU.OptionsView.RowAutoHeight = True
        Me.GV_MENU.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Width = 120
        '
        'colKeyName
        '
        Me.colKeyName.FieldName = "KeyName"
        Me.colKeyName.Name = "colKeyName"
        '
        'colLabelID
        '
        Me.colLabelID.FieldName = "LabelID"
        Me.colLabelID.Name = "colLabelID"
        '
        'colTableName
        '
        Me.colTableName.FieldName = "TableName"
        Me.colTableName.Name = "colTableName"
        '
        'colTableName_Details
        '
        Me.colTableName_Details.FieldName = "TableName_Details"
        Me.colTableName_Details.Name = "colTableName_Details"
        '
        'colColumnName
        '
        Me.colColumnName.FieldName = "ColumnName"
        Me.colColumnName.Name = "colColumnName"
        '
        'colColumnKey
        '
        Me.colColumnKey.FieldName = "ColumnKey"
        Me.colColumnKey.Name = "colColumnKey"
        '
        'colColumnKey_Details
        '
        Me.colColumnKey_Details.FieldName = "ColumnKey_Details"
        Me.colColumnKey_Details.Name = "colColumnKey_Details"
        '
        'colColumnAmount
        '
        Me.colColumnAmount.FieldName = "ColumnAmount"
        Me.colColumnAmount.Name = "colColumnAmount"
        '
        'colColumnAmount_Details
        '
        Me.colColumnAmount_Details.FieldName = "ColumnAmount_Details"
        Me.colColumnAmount_Details.Name = "colColumnAmount_Details"
        '
        'colOldKey
        '
        Me.colOldKey.FieldName = "OldKey"
        Me.colOldKey.Name = "colOldKey"
        '
        'colColumnOldKey
        '
        Me.colColumnOldKey.FieldName = "ColumnOldKey"
        Me.colColumnOldKey.Name = "colColumnOldKey"
        '
        'colColumnOldKey_Details
        '
        Me.colColumnOldKey_Details.FieldName = "ColumnOldKey_Details"
        Me.colColumnOldKey_Details.Name = "colColumnOldKey_Details"
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 0
        Me.colDescription.Width = 185
        '
        'colSequence
        '
        Me.colSequence.FieldName = "Sequence"
        Me.colSequence.Name = "colSequence"
        '
        'colAmount
        '
        Me.colAmount.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.colAmount.FieldName = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.Visible = True
        Me.colAmount.VisibleIndex = 1
        Me.colAmount.Width = 100
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatString = "n0"
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'DocumentManager1
        '
        Me.DocumentManager1.ContainerControl = Me
        Me.DocumentManager1.MenuManager = Me.BarManager1
        Me.DocumentManager1.View = Me.TabbedView1
        Me.DocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.TabbedView1})
        '
        'TabbedView1
        '
        Me.TabbedView1.RootContainer.Element = Nothing
        '
        'ProgressPanel1
        '
        Me.ProgressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel1.Appearance.Options.UseBackColor = True
        Me.ProgressPanel1.BarAnimationElementThickness = 2
        Me.ProgressPanel1.Location = New System.Drawing.Point(616, 316)
        Me.ProgressPanel1.Name = "ProgressPanel1"
        Me.ProgressPanel1.Size = New System.Drawing.Size(246, 66)
        Me.ProgressPanel1.TabIndex = 9
        Me.ProgressPanel1.Text = "ProgressPanel1"
        '
        'chkDeclareB
        '
        Me.chkDeclareB.Caption = "Declare in Form B"
        Me.chkDeclareB.Edit = Me.RepositoryItemCheckEdit1
        Me.chkDeclareB.Id = 23
        Me.chkDeclareB.Name = "chkDeclareB"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'frmPNL_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 613)
        Me.Controls.Add(Me.ProgressPanel1)
        Me.Controls.Add(Me.docMainMenu)
        Me.Controls.Add(Me.hideContainerBottom)
        Me.Controls.Add(Me.hideContainerRight)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmPNL_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profit And Loss"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCAi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPNL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVAi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackstageViewControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BackstageViewControl1.ResumeLayout(False)
        CType(Me.RepositoryItemSearchLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusinessSourceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusinessSourceBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit4View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hideContainerRight.ResumeLayout(False)
        Me.DockPanel1.ResumeLayout(False)
        Me.ControlContainer1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PNLSEARCHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hideContainerBottom.ResumeLayout(False)
        Me.docAi.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        CType(Me.txtAi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.docMainMenu.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.GC_MENU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PNLINFOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_MENU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cboRefNo As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSearchLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtRefNo As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cboYA As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSearchLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cboCompanyNo As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSearchLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cboSourceNo As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSearchLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit4View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RPGeneralInfo As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents docMainMenu As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DocumentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
    Friend WithEvents TabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GC_MENU As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_MENU As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TaxPayerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsDefault As EasyTemplate_Taxcom_B.dsDefault
    Friend WithEvents YABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colRefNo_Prefix As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRefNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIC_Number As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPostcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHandleBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BusinessSourceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colCompanyNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSourceNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BusinessSourceBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents colCompanyNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSourceNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PNLINFOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsPNL As EasyTemplate_Taxcom_B.dsPNL
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKeyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLabelID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTableName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTableName_Details As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColumnName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColumnKey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColumnKey_Details As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColumnAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColumnAmount_Details As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOldKey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColumnOldKey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColumnOldKey_Details As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSequence As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboDecimalPlace As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnAllowAllGroupExpanded As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemToggleSwitch1 As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnWorkSpace As DevExpress.XtraBars.BarWorkspaceMenuItem
    Friend WithEvents WorkspaceManager1 As DevExpress.Utils.WorkspaceManager
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents SkinRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnSpeech As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnStopSpeech As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents ControlContainer1 As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_SEARCH As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PNLSEARCHBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmount1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOldKey1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNetProfitAndLoss As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
    Friend WithEvents BackstageViewControl1 As DevExpress.XtraBars.Ribbon.BackstageViewControl
    Friend WithEvents BackstageViewClientControl1 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents BackstageViewTabItem1 As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents btnViewPNLSolution As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnViewSearch As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemSearchControl1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents lblProgress As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents btnProgress As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ProgressPanel1 As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents docAi As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents GCAi As DevExpress.XtraGrid.GridControl
    Friend WithEvents AiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GVAi As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFrom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommunication As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJobType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colKeyName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQ1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQ2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQ3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParentID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents hideContainerBottom As DevExpress.XtraBars.Docking.AutoHideContainer
    Friend WithEvents chkDeclareB As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
