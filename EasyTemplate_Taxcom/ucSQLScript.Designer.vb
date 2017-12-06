<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSQLScript
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucSQLScript))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnExecute = New DevExpress.XtraBars.BarButtonItem()
        Me.cboDatabase = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.btnRefresh1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList()
        Me.colTABLE_SCHEMA = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.colTABLE_NAME = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SELECTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UPDATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DtDatabaseColumnListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDefault = New EasyTemplate_Taxcom.dsDefault()
        Me.docScript1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.pnlLoading = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.txtScript1 = New DevExpress.XtraEditors.MemoEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.dgvView1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtErrorLog1 = New DevExpress.XtraEditors.MemoEdit()
        Me.docScript2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.txtScript2 = New DevExpress.XtraEditors.MemoEdit()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.dgvView2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtErrorLog2 = New DevExpress.XtraEditors.MemoEdit()
        Me.docScript3 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel4_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.SplitContainerControl3 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.txtScript3 = New DevExpress.XtraEditors.MemoEdit()
        Me.XtraTabControl3 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.dgvView3 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtErrorLog3 = New DevExpress.XtraEditors.MemoEdit()
        Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
        Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
        Me.Document2 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
        Me.Document3 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.DtDatabaseColumnListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.docScript1.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.txtScript1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.dgvView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtErrorLog1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.docScript2.SuspendLayout()
        Me.DockPanel3_Container.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.txtScript2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.dgvView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.txtErrorLog2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.docScript3.SuspendLayout()
        Me.DockPanel4_Container.SuspendLayout()
        CType(Me.SplitContainerControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl3.SuspendLayout()
        CType(Me.txtScript3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl3.SuspendLayout()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.dgvView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage6.SuspendLayout()
        CType(Me.txtErrorLog3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Document2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Document3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnExecute, Me.cboDatabase, Me.btnRefresh, Me.btnRefresh1})
        Me.BarManager1.MaxItemId = 15
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemComboBox1})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(271, 130)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnExecute), New DevExpress.XtraBars.LinkPersistInfo(Me.cboDatabase), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRefresh1)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DisableClose = True
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'btnExecute
        '
        Me.btnExecute.Caption = "Execute"
        Me.btnExecute.Glyph = CType(resources.GetObject("btnExecute.Glyph"), System.Drawing.Image)
        Me.btnExecute.Id = 11
        Me.btnExecute.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5)
        Me.btnExecute.LargeGlyph = CType(resources.GetObject("btnExecute.LargeGlyph"), System.Drawing.Image)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'cboDatabase
        '
        Me.cboDatabase.Caption = "Database :"
        Me.cboDatabase.Edit = Me.RepositoryItemComboBox1
        Me.cboDatabase.Id = 12
        Me.cboDatabase.Name = "cboDatabase"
        Me.cboDatabase.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.cboDatabase.Width = 200
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'btnRefresh1
        '
        Me.btnRefresh1.Caption = "Refresh"
        Me.btnRefresh1.Glyph = CType(resources.GetObject("btnRefresh1.Glyph"), System.Drawing.Image)
        Me.btnRefresh1.Id = 14
        Me.btnRefresh1.LargeGlyph = CType(resources.GetObject("btnRefresh1.LargeGlyph"), System.Drawing.Image)
        Me.btnRefresh1.Name = "btnRefresh1"
        Me.btnRefresh1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1011, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 606)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1011, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 575)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1011, 31)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 575)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1, Me.docScript1, Me.docScript2, Me.docScript3})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("22ba9eab-9a9d-4607-b352-ea4229bd66b5")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 31)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.AllowDockBottom = False
        Me.DockPanel1.Options.AllowDockFill = False
        Me.DockPanel1.Options.ShowAutoHideButton = False
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.Options.ShowMaximizeButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(210, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(210, 575)
        Me.DockPanel1.Text = "Object Explorer"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.TreeList1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(202, 548)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'TreeList1
        '
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colTABLE_SCHEMA, Me.colTABLE_NAME})
        Me.TreeList1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TreeList1.DataSource = Me.DtDatabaseColumnListBindingSource
        Me.TreeList1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeList1.Location = New System.Drawing.Point(0, 0)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.OptionsBehavior.Editable = False
        Me.TreeList1.ParentFieldName = "TABLE_CATALOG"
        Me.TreeList1.PreviewFieldName = "TABLE_CATALOG"
        Me.TreeList1.Size = New System.Drawing.Size(202, 548)
        Me.TreeList1.TabIndex = 0
        '
        'colTABLE_SCHEMA
        '
        Me.colTABLE_SCHEMA.FieldName = "TABLE_SCHEMA"
        Me.colTABLE_SCHEMA.Name = "colTABLE_SCHEMA"
        Me.colTABLE_SCHEMA.Width = 92
        '
        'colTABLE_NAME
        '
        Me.colTABLE_NAME.Caption = "Table Name"
        Me.colTABLE_NAME.FieldName = "TABLE_NAME"
        Me.colTABLE_NAME.Name = "colTABLE_NAME"
        Me.colTABLE_NAME.Visible = True
        Me.colTABLE_NAME.VisibleIndex = 0
        Me.colTABLE_NAME.Width = 92
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SELECTToolStripMenuItem, Me.UPDATEToolStripMenuItem, Me.DELETEToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 70)
        '
        'SELECTToolStripMenuItem
        '
        Me.SELECTToolStripMenuItem.Name = "SELECTToolStripMenuItem"
        Me.SELECTToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.SELECTToolStripMenuItem.Text = "SELECT"
        '
        'UPDATEToolStripMenuItem
        '
        Me.UPDATEToolStripMenuItem.Name = "UPDATEToolStripMenuItem"
        Me.UPDATEToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.UPDATEToolStripMenuItem.Text = "UPDATE"
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.DELETEToolStripMenuItem.Text = "DELETE"
        '
        'DtDatabaseColumnListBindingSource
        '
        Me.DtDatabaseColumnListBindingSource.DataMember = "dtDatabaseColumnList"
        Me.DtDatabaseColumnListBindingSource.DataSource = Me.DsDefault
        '
        'DsDefault
        '
        Me.DsDefault.DataSetName = "dsDefault"
        Me.DsDefault.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'docScript1
        '
        Me.docScript1.Controls.Add(Me.DockPanel2_Container)
        Me.docScript1.DockedAsTabbedDocument = True
        Me.docScript1.FloatLocation = New System.Drawing.Point(263, 154)
        Me.docScript1.ID = New System.Guid("240f8a45-7df3-4a3c-9d77-231e6be2e959")
        Me.docScript1.Name = "docScript1"
        Me.docScript1.Options.AllowDockFill = False
        Me.docScript1.Options.AllowDockLeft = False
        Me.docScript1.Options.AllowDockRight = False
        Me.docScript1.Options.AllowDockTop = False
        Me.docScript1.Options.FloatOnDblClick = False
        Me.docScript1.Options.ShowAutoHideButton = False
        Me.docScript1.Options.ShowCloseButton = False
        Me.docScript1.Options.ShowMaximizeButton = False
        Me.docScript1.OriginalSize = New System.Drawing.Size(200, 200)
        Me.docScript1.SavedIndex = 1
        Me.docScript1.SavedMdiDocument = True
        Me.docScript1.Text = "DockPanel2"
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.SplitContainerControl1)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(795, 547)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.pnlLoading)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtScript1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.ScrollBarSmallChange = 15
        Me.SplitContainerControl1.Size = New System.Drawing.Size(795, 547)
        Me.SplitContainerControl1.SplitterPosition = 285
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
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
        Me.pnlLoading.Location = New System.Drawing.Point(326, 118)
        Me.pnlLoading.Name = "pnlLoading"
        Me.pnlLoading.Size = New System.Drawing.Size(246, 66)
        Me.pnlLoading.TabIndex = 1
        Me.pnlLoading.Text = "ProgressPanel1"
        Me.pnlLoading.Visible = False
        '
        'txtScript1
        '
        Me.txtScript1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtScript1.Location = New System.Drawing.Point(0, 0)
        Me.txtScript1.MenuManager = Me.BarManager1
        Me.txtScript1.Name = "txtScript1"
        Me.txtScript1.Size = New System.Drawing.Size(795, 285)
        Me.txtScript1.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(795, 257)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.dgvView1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(789, 229)
        Me.XtraTabPage1.Text = "Result"
        '
        'dgvView1
        '
        Me.dgvView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvView1.Location = New System.Drawing.Point(0, 0)
        Me.dgvView1.MainView = Me.GridView1
        Me.dgvView1.MenuManager = Me.BarManager1
        Me.dgvView1.Name = "dgvView1"
        Me.dgvView1.Size = New System.Drawing.Size(789, 229)
        Me.dgvView1.TabIndex = 0
        Me.dgvView1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.dgvView1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.txtErrorLog1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(0, 0)
        Me.XtraTabPage2.Text = "Error log"
        '
        'txtErrorLog1
        '
        Me.txtErrorLog1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtErrorLog1.Location = New System.Drawing.Point(0, 0)
        Me.txtErrorLog1.MenuManager = Me.BarManager1
        Me.txtErrorLog1.Name = "txtErrorLog1"
        Me.txtErrorLog1.Properties.ReadOnly = True
        Me.txtErrorLog1.Size = New System.Drawing.Size(0, 0)
        Me.txtErrorLog1.TabIndex = 0
        '
        'docScript2
        '
        Me.docScript2.Controls.Add(Me.DockPanel3_Container)
        Me.docScript2.DockedAsTabbedDocument = True
        Me.docScript2.FloatLocation = New System.Drawing.Point(570, 144)
        Me.docScript2.ID = New System.Guid("8baabd17-ba30-46b6-a080-75836ae7ed90")
        Me.docScript2.Name = "docScript2"
        Me.docScript2.Options.AllowDockFill = False
        Me.docScript2.Options.AllowDockLeft = False
        Me.docScript2.Options.AllowDockRight = False
        Me.docScript2.Options.AllowDockTop = False
        Me.docScript2.Options.FloatOnDblClick = False
        Me.docScript2.Options.ShowAutoHideButton = False
        Me.docScript2.Options.ShowCloseButton = False
        Me.docScript2.Options.ShowMaximizeButton = False
        Me.docScript2.OriginalSize = New System.Drawing.Size(200, 200)
        Me.docScript2.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.docScript2.SavedIndex = 2
        Me.docScript2.Text = "Script 2"
        '
        'DockPanel3_Container
        '
        Me.DockPanel3_Container.Controls.Add(Me.SplitContainerControl2)
        Me.DockPanel3_Container.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel3_Container.Name = "DockPanel3_Container"
        Me.DockPanel3_Container.Size = New System.Drawing.Size(795, 547)
        Me.DockPanel3_Container.TabIndex = 0
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Horizontal = False
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.txtScript2)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.XtraTabControl2)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(795, 547)
        Me.SplitContainerControl2.SplitterPosition = 259
        Me.SplitContainerControl2.TabIndex = 0
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'txtScript2
        '
        Me.txtScript2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtScript2.Location = New System.Drawing.Point(0, 0)
        Me.txtScript2.MenuManager = Me.BarManager1
        Me.txtScript2.Name = "txtScript2"
        Me.txtScript2.Size = New System.Drawing.Size(795, 259)
        Me.txtScript2.TabIndex = 1
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage3
        Me.XtraTabControl2.Size = New System.Drawing.Size(795, 283)
        Me.XtraTabControl2.TabIndex = 0
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.dgvView2)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(789, 255)
        Me.XtraTabPage3.Text = "Results"
        '
        'dgvView2
        '
        Me.dgvView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvView2.Location = New System.Drawing.Point(0, 0)
        Me.dgvView2.MainView = Me.GridView2
        Me.dgvView2.MenuManager = Me.BarManager1
        Me.dgvView2.Name = "dgvView2"
        Me.dgvView2.Size = New System.Drawing.Size(789, 255)
        Me.dgvView2.TabIndex = 1
        Me.dgvView2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.dgvView2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.txtErrorLog2)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(0, 0)
        Me.XtraTabPage4.Text = "Error log"
        '
        'txtErrorLog2
        '
        Me.txtErrorLog2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtErrorLog2.Location = New System.Drawing.Point(0, 0)
        Me.txtErrorLog2.MenuManager = Me.BarManager1
        Me.txtErrorLog2.Name = "txtErrorLog2"
        Me.txtErrorLog2.Properties.ReadOnly = True
        Me.txtErrorLog2.Size = New System.Drawing.Size(0, 0)
        Me.txtErrorLog2.TabIndex = 1
        '
        'docScript3
        '
        Me.docScript3.Controls.Add(Me.DockPanel4_Container)
        Me.docScript3.DockedAsTabbedDocument = True
        Me.docScript3.FloatLocation = New System.Drawing.Point(260, 154)
        Me.docScript3.ID = New System.Guid("7ecae712-a268-477c-bb7b-092b98ebab84")
        Me.docScript3.Name = "docScript3"
        Me.docScript3.Options.AllowDockFill = False
        Me.docScript3.Options.AllowDockLeft = False
        Me.docScript3.Options.AllowDockRight = False
        Me.docScript3.Options.AllowDockTop = False
        Me.docScript3.Options.FloatOnDblClick = False
        Me.docScript3.Options.ShowAutoHideButton = False
        Me.docScript3.Options.ShowCloseButton = False
        Me.docScript3.Options.ShowMaximizeButton = False
        Me.docScript3.OriginalSize = New System.Drawing.Size(200, 200)
        Me.docScript3.SavedIndex = 3
        Me.docScript3.SavedMdiDocument = True
        Me.docScript3.Text = "Script 3"
        '
        'DockPanel4_Container
        '
        Me.DockPanel4_Container.Controls.Add(Me.SplitContainerControl3)
        Me.DockPanel4_Container.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel4_Container.Name = "DockPanel4_Container"
        Me.DockPanel4_Container.Size = New System.Drawing.Size(795, 547)
        Me.DockPanel4_Container.TabIndex = 0
        '
        'SplitContainerControl3
        '
        Me.SplitContainerControl3.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl3.Horizontal = False
        Me.SplitContainerControl3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl3.Name = "SplitContainerControl3"
        Me.SplitContainerControl3.Panel1.Controls.Add(Me.txtScript3)
        Me.SplitContainerControl3.Panel1.Text = "Panel1"
        Me.SplitContainerControl3.Panel2.Controls.Add(Me.XtraTabControl3)
        Me.SplitContainerControl3.Panel2.Text = "Panel2"
        Me.SplitContainerControl3.Size = New System.Drawing.Size(795, 547)
        Me.SplitContainerControl3.SplitterPosition = 241
        Me.SplitContainerControl3.TabIndex = 0
        Me.SplitContainerControl3.Text = "SplitContainerControl3"
        '
        'txtScript3
        '
        Me.txtScript3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtScript3.Location = New System.Drawing.Point(0, 0)
        Me.txtScript3.MenuManager = Me.BarManager1
        Me.txtScript3.Name = "txtScript3"
        Me.txtScript3.Size = New System.Drawing.Size(795, 241)
        Me.txtScript3.TabIndex = 0
        '
        'XtraTabControl3
        '
        Me.XtraTabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl3.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl3.Name = "XtraTabControl3"
        Me.XtraTabControl3.SelectedTabPage = Me.XtraTabPage5
        Me.XtraTabControl3.Size = New System.Drawing.Size(795, 301)
        Me.XtraTabControl3.TabIndex = 0
        Me.XtraTabControl3.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage5, Me.XtraTabPage6})
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.dgvView3)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(789, 273)
        Me.XtraTabPage5.Text = "Results"
        '
        'dgvView3
        '
        Me.dgvView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvView3.Location = New System.Drawing.Point(0, 0)
        Me.dgvView3.MainView = Me.GridView3
        Me.dgvView3.MenuManager = Me.BarManager1
        Me.dgvView3.Name = "dgvView3"
        Me.dgvView3.Size = New System.Drawing.Size(789, 273)
        Me.dgvView3.TabIndex = 0
        Me.dgvView3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.dgvView3
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.RowAutoHeight = True
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.txtErrorLog3)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(0, 0)
        Me.XtraTabPage6.Text = "Error log"
        '
        'txtErrorLog3
        '
        Me.txtErrorLog3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtErrorLog3.Location = New System.Drawing.Point(0, 0)
        Me.txtErrorLog3.MenuManager = Me.BarManager1
        Me.txtErrorLog3.Name = "txtErrorLog3"
        Me.txtErrorLog3.Size = New System.Drawing.Size(0, 0)
        Me.txtErrorLog3.TabIndex = 1
        '
        'btnRefresh
        '
        Me.btnRefresh.Caption = "Refresh"
        Me.btnRefresh.Glyph = CType(resources.GetObject("btnRefresh.Glyph"), System.Drawing.Image)
        Me.btnRefresh.Id = 13
        Me.btnRefresh.LargeGlyph = CType(resources.GetObject("btnRefresh.LargeGlyph"), System.Drawing.Image)
        Me.btnRefresh.Name = "btnRefresh"
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
        'DocumentManager1
        '
        Me.DocumentManager1.ContainerControl = Me
        Me.DocumentManager1.View = Me.TabbedView1
        Me.DocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.TabbedView1})
        '
        'TabbedView1
        '
        Me.TabbedView1.DocumentGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup() {Me.DocumentGroup1})
        Me.TabbedView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.Document2, Me.Document3, Me.Document1})
        '
        'DocumentGroup1
        '
        Me.DocumentGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.Document1, Me.Document2, Me.Document3})
        '
        'Document1
        '
        Me.Document1.Caption = "Script 1"
        Me.Document1.ControlName = "docScript1"
        Me.Document1.FloatLocation = New System.Drawing.Point(263, 154)
        Me.Document1.FloatSize = New System.Drawing.Size(200, 200)
        Me.Document1.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
        Me.Document1.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
        Me.Document1.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
        '
        'Document2
        '
        Me.Document2.Caption = "Script 2"
        Me.Document2.ControlName = "docScript2"
        Me.Document2.FloatLocation = New System.Drawing.Point(570, 144)
        Me.Document2.FloatSize = New System.Drawing.Size(200, 200)
        Me.Document2.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
        Me.Document2.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
        Me.Document2.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
        '
        'Document3
        '
        Me.Document3.Caption = "Script 3"
        Me.Document3.ControlName = "docScript3"
        Me.Document3.FloatLocation = New System.Drawing.Point(260, 154)
        Me.Document3.FloatSize = New System.Drawing.Size(200, 200)
        Me.Document3.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
        Me.Document3.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
        Me.Document3.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
        '
        'ucSQLScript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "ucSQLScript"
        Me.Size = New System.Drawing.Size(1011, 606)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.DtDatabaseColumnListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).EndInit()
        Me.docScript1.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.txtScript1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.dgvView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.txtErrorLog1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.docScript2.ResumeLayout(False)
        Me.DockPanel3_Container.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.txtScript2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.dgvView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.txtErrorLog2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.docScript3.ResumeLayout(False)
        Me.DockPanel4_Container.ResumeLayout(False)
        CType(Me.SplitContainerControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl3.ResumeLayout(False)
        CType(Me.txtScript3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl3.ResumeLayout(False)
        Me.XtraTabPage5.ResumeLayout(False)
        CType(Me.dgvView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage6.ResumeLayout(False)
        CType(Me.txtErrorLog3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Document1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Document2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Document3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents docScript1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents DocumentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
    Friend WithEvents TabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
    Friend WithEvents btnExecute As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtScript1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents dgvView1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cboDatabase As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtErrorLog1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents DocumentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
    Friend WithEvents docScript2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtScript2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents docScript3 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel4_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents Document2 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
    Friend WithEvents dgvView2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtErrorLog2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SplitContainerControl3 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtScript3 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents XtraTabControl3 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dgvView3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtErrorLog3 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Document3 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
    Friend WithEvents DtDatabaseColumnListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsDefault As EasyTemplate_Taxcom.dsDefault
    Friend WithEvents colTABLE_SCHEMA As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colTABLE_NAME As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SELECTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UPDATEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
    Friend WithEvents pnlLoading As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRefresh1 As DevExpress.XtraBars.BarButtonItem

End Class
