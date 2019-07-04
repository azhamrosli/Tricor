<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMapping_Setting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucMapping_Setting))
        Dim DockingContainer1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
        Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
        Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnNew = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.MAPPINGSETTINGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAccountMapping = New EasyTemplate_Taxcom.DsAccountMapping()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSetting_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStart_Row = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccNo_Cell = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription_Cell = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmount_Cell_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmount_Cell_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboType = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SpreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
        Me.txtPath = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtModifiedBy = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtModifiedDateTime = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtAccCell_A = New DevExpress.XtraEditors.TextEdit()
        Me.txtAmount2Cell_A = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescriptionCell_A = New DevExpress.XtraEditors.TextEdit()
        Me.txtAmount1Cell_A = New DevExpress.XtraEditors.TextEdit()
        Me.btnAmount2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAmount1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDescription = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAcc = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAccCell = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmount2Cell = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescriptionCell = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmount1Cell = New DevExpress.XtraEditors.TextEdit()
        Me.txtStartRow = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAPPINGSETTINGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAccountMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel2.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtPath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtModifiedBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModifiedDateTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtAccCell_A.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount2Cell_A.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescriptionCell_A.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount1Cell_A.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAccCell.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount2Cell.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescriptionCell.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount1Cell.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStartRow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DocumentGroup1
        '
        Me.DocumentGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.Document1})
        '
        'Document1
        '
        Me.Document1.Caption = "Details"
        Me.Document1.ControlName = "DockPanel2"
        Me.Document1.FloatLocation = New System.Drawing.Point(0, 0)
        Me.Document1.FloatSize = New System.Drawing.Size(200, 200)
        Me.Document1.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[True]
        Me.Document1.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
        Me.Document1.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSave, Me.btnDelete, Me.btnNew, Me.btnEdit})
        Me.BarManager1.MaxItemId = 6
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnNew), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSave), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'btnNew
        '
        Me.btnNew.Caption = "New"
        Me.btnNew.Id = 4
        Me.btnNew.ImageOptions.Image = CType(resources.GetObject("btnNew.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNew.ImageOptions.LargeImage = CType(resources.GetObject("btnNew.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnEdit
        '
        Me.btnEdit.Caption = "Edit"
        Me.btnEdit.Id = 5
        Me.btnEdit.ImageOptions.Image = CType(resources.GetObject("btnEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEdit.ImageOptions.LargeImage = CType(resources.GetObject("btnEdit.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
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
        'btnDelete
        '
        Me.btnDelete.Caption = "Delete"
        Me.btnDelete.Id = 1
        Me.btnDelete.ImageOptions.Image = CType(resources.GetObject("btnDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelete.ImageOptions.LargeImage = CType(resources.GetObject("btnDelete.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnDelete.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1158, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 588)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1158, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 557)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1158, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 557)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1, Me.DockPanel2})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("2cd4db55-8989-4309-868a-7d42330e181c")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 31)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(301, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(301, 557)
        Me.DockPanel1.Text = "List Setting"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.GridControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(292, 530)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.MAPPINGSETTINGBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboType})
        Me.GridControl1.Size = New System.Drawing.Size(292, 530)
        Me.GridControl1.TabIndex = 12
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'MAPPINGSETTINGBindingSource
        '
        Me.MAPPINGSETTINGBindingSource.DataMember = "MAPPING_SETTING"
        Me.MAPPINGSETTINGBindingSource.DataSource = Me.DsAccountMapping
        '
        'DsAccountMapping
        '
        Me.DsAccountMapping.DataSetName = "DsAccountMapping"
        Me.DsAccountMapping.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colSetting_Name, Me.colStart_Row, Me.colAccNo_Cell, Me.colDescription_Cell, Me.colAmount_Cell_1, Me.colAmount_Cell_2, Me.colModifiedBy, Me.colModifiedDateTime})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "BK_CODE", Nothing, "Count : {0}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colSetting_Name
        '
        Me.colSetting_Name.Caption = "Name"
        Me.colSetting_Name.FieldName = "Setting_Name"
        Me.colSetting_Name.Name = "colSetting_Name"
        Me.colSetting_Name.Visible = True
        Me.colSetting_Name.VisibleIndex = 0
        Me.colSetting_Name.Width = 200
        '
        'colStart_Row
        '
        Me.colStart_Row.Caption = "Start Row"
        Me.colStart_Row.FieldName = "Start_Row"
        Me.colStart_Row.Name = "colStart_Row"
        Me.colStart_Row.Visible = True
        Me.colStart_Row.VisibleIndex = 1
        Me.colStart_Row.Width = 80
        '
        'colAccNo_Cell
        '
        Me.colAccNo_Cell.Caption = "Acc Cell"
        Me.colAccNo_Cell.FieldName = "AccNo_Cell"
        Me.colAccNo_Cell.Name = "colAccNo_Cell"
        Me.colAccNo_Cell.Visible = True
        Me.colAccNo_Cell.VisibleIndex = 2
        Me.colAccNo_Cell.Width = 80
        '
        'colDescription_Cell
        '
        Me.colDescription_Cell.Caption = "Description Cell"
        Me.colDescription_Cell.FieldName = "Description_Cell"
        Me.colDescription_Cell.Name = "colDescription_Cell"
        Me.colDescription_Cell.Visible = True
        Me.colDescription_Cell.VisibleIndex = 3
        Me.colDescription_Cell.Width = 80
        '
        'colAmount_Cell_1
        '
        Me.colAmount_Cell_1.Caption = "Amount Cell"
        Me.colAmount_Cell_1.FieldName = "Amount_Cell_1"
        Me.colAmount_Cell_1.Name = "colAmount_Cell_1"
        Me.colAmount_Cell_1.Visible = True
        Me.colAmount_Cell_1.VisibleIndex = 4
        Me.colAmount_Cell_1.Width = 80
        '
        'colAmount_Cell_2
        '
        Me.colAmount_Cell_2.Caption = "Amount Cell"
        Me.colAmount_Cell_2.FieldName = "Amount_Cell_2"
        Me.colAmount_Cell_2.Name = "colAmount_Cell_2"
        Me.colAmount_Cell_2.Visible = True
        Me.colAmount_Cell_2.VisibleIndex = 5
        Me.colAmount_Cell_2.Width = 80
        '
        'colModifiedBy
        '
        Me.colModifiedBy.Caption = "Modified By"
        Me.colModifiedBy.FieldName = "ModifiedBy"
        Me.colModifiedBy.Name = "colModifiedBy"
        Me.colModifiedBy.Visible = True
        Me.colModifiedBy.VisibleIndex = 6
        Me.colModifiedBy.Width = 150
        '
        'colModifiedDateTime
        '
        Me.colModifiedDateTime.Caption = "Modified Date Time"
        Me.colModifiedDateTime.FieldName = "ModifiedDateTime"
        Me.colModifiedDateTime.Name = "colModifiedDateTime"
        Me.colModifiedDateTime.Visible = True
        Me.colModifiedDateTime.VisibleIndex = 7
        Me.colModifiedDateTime.Width = 150
        '
        'cboType
        '
        Me.cboType.AutoHeight = False
        Me.cboType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboType.Items.AddRange(New Object() {"Balance Sheet", "Profit and Loss"})
        Me.cboType.Name = "cboType"
        '
        'DockPanel2
        '
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.DockedAsTabbedDocument = True
        Me.DockPanel2.ID = New System.Guid("1c605425-2c5e-43dc-a42a-61a566aa3fc4")
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel2.Text = "Details"
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.PanelControl1)
        Me.DockPanel2_Container.Controls.Add(Me.txtPath)
        Me.DockPanel2_Container.Controls.Add(Me.LabelControl10)
        Me.DockPanel2_Container.Controls.Add(Me.txtID)
        Me.DockPanel2_Container.Controls.Add(Me.LabelControl7)
        Me.DockPanel2_Container.Controls.Add(Me.GroupControl2)
        Me.DockPanel2_Container.Controls.Add(Me.GroupControl1)
        Me.DockPanel2_Container.Controls.Add(Me.txtStartRow)
        Me.DockPanel2_Container.Controls.Add(Me.LabelControl2)
        Me.DockPanel2_Container.Controls.Add(Me.txtName)
        Me.DockPanel2_Container.Controls.Add(Me.LabelControl1)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(851, 529)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.SpreadsheetControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(18, 366)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(830, 357)
        Me.PanelControl1.TabIndex = 22
        '
        'SpreadsheetControl1
        '
        Me.SpreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpreadsheetControl1.Location = New System.Drawing.Point(2, 2)
        Me.SpreadsheetControl1.MenuManager = Me.BarManager1
        Me.SpreadsheetControl1.Name = "SpreadsheetControl1"
        Me.SpreadsheetControl1.Options.Import.Csv.Encoding = CType(resources.GetObject("SpreadsheetControl1.Options.Import.Csv.Encoding"), System.Text.Encoding)
        Me.SpreadsheetControl1.Options.Import.Txt.Encoding = CType(resources.GetObject("SpreadsheetControl1.Options.Import.Txt.Encoding"), System.Text.Encoding)
        Me.SpreadsheetControl1.Size = New System.Drawing.Size(826, 353)
        Me.SpreadsheetControl1.TabIndex = 21
        Me.SpreadsheetControl1.Text = "SpreadsheetControl1"
        '
        'txtPath
        '
        Me.txtPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPath.Location = New System.Drawing.Point(166, 340)
        Me.txtPath.MenuManager = Me.BarManager1
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPath.Size = New System.Drawing.Size(659, 20)
        Me.txtPath.TabIndex = 20
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(22, 344)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(137, 13)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Update your template here :"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(110, 22)
        Me.txtID.MenuManager = Me.BarManager1
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Mask.EditMask = "d"
        Me.txtID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtID.Properties.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(77, 20)
        Me.txtID.TabIndex = 17
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(27, 25)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(18, 13)
        Me.LabelControl7.TabIndex = 16
        Me.LabelControl7.Text = "ID :"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.txtModifiedBy)
        Me.GroupControl2.Controls.Add(Me.LabelControl9)
        Me.GroupControl2.Controls.Add(Me.txtModifiedDateTime)
        Me.GroupControl2.Location = New System.Drawing.Point(18, 246)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(442, 87)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "History"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(9, 33)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl8.TabIndex = 4
        Me.LabelControl8.Text = "Modified By :"
        '
        'txtModifiedBy
        '
        Me.txtModifiedBy.Location = New System.Drawing.Point(92, 30)
        Me.txtModifiedBy.MenuManager = Me.BarManager1
        Me.txtModifiedBy.Name = "txtModifiedBy"
        Me.txtModifiedBy.Properties.ReadOnly = True
        Me.txtModifiedBy.Size = New System.Drawing.Size(324, 20)
        Me.txtModifiedBy.TabIndex = 0
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(9, 59)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl9.TabIndex = 6
        Me.LabelControl9.Text = "Last Modified :"
        '
        'txtModifiedDateTime
        '
        Me.txtModifiedDateTime.Location = New System.Drawing.Point(92, 56)
        Me.txtModifiedDateTime.MenuManager = Me.BarManager1
        Me.txtModifiedDateTime.Name = "txtModifiedDateTime"
        Me.txtModifiedDateTime.Properties.ReadOnly = True
        Me.txtModifiedDateTime.Size = New System.Drawing.Size(324, 20)
        Me.txtModifiedDateTime.TabIndex = 1
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtAccCell_A)
        Me.GroupControl1.Controls.Add(Me.txtAmount2Cell_A)
        Me.GroupControl1.Controls.Add(Me.txtDescriptionCell_A)
        Me.GroupControl1.Controls.Add(Me.txtAmount1Cell_A)
        Me.GroupControl1.Controls.Add(Me.btnAmount2)
        Me.GroupControl1.Controls.Add(Me.btnAmount1)
        Me.GroupControl1.Controls.Add(Me.btnDescription)
        Me.GroupControl1.Controls.Add(Me.btnAcc)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtAccCell)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtAmount2Cell)
        Me.GroupControl1.Controls.Add(Me.txtDescriptionCell)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txtAmount1Cell)
        Me.GroupControl1.Location = New System.Drawing.Point(18, 100)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(442, 140)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Cell"
        '
        'txtAccCell_A
        '
        Me.txtAccCell_A.Location = New System.Drawing.Point(175, 30)
        Me.txtAccCell_A.MenuManager = Me.BarManager1
        Me.txtAccCell_A.Name = "txtAccCell_A"
        Me.txtAccCell_A.Size = New System.Drawing.Size(77, 20)
        Me.txtAccCell_A.TabIndex = 15
        '
        'txtAmount2Cell_A
        '
        Me.txtAmount2Cell_A.Location = New System.Drawing.Point(175, 108)
        Me.txtAmount2Cell_A.MenuManager = Me.BarManager1
        Me.txtAmount2Cell_A.Name = "txtAmount2Cell_A"
        Me.txtAmount2Cell_A.Size = New System.Drawing.Size(77, 20)
        Me.txtAmount2Cell_A.TabIndex = 18
        '
        'txtDescriptionCell_A
        '
        Me.txtDescriptionCell_A.Location = New System.Drawing.Point(175, 56)
        Me.txtDescriptionCell_A.MenuManager = Me.BarManager1
        Me.txtDescriptionCell_A.Name = "txtDescriptionCell_A"
        Me.txtDescriptionCell_A.Size = New System.Drawing.Size(77, 20)
        Me.txtDescriptionCell_A.TabIndex = 16
        '
        'txtAmount1Cell_A
        '
        Me.txtAmount1Cell_A.Location = New System.Drawing.Point(175, 82)
        Me.txtAmount1Cell_A.MenuManager = Me.BarManager1
        Me.txtAmount1Cell_A.Name = "txtAmount1Cell_A"
        Me.txtAmount1Cell_A.Size = New System.Drawing.Size(77, 20)
        Me.txtAmount1Cell_A.TabIndex = 17
        '
        'btnAmount2
        '
        Me.btnAmount2.Location = New System.Drawing.Point(258, 106)
        Me.btnAmount2.Name = "btnAmount2"
        Me.btnAmount2.Size = New System.Drawing.Size(75, 23)
        Me.btnAmount2.TabIndex = 14
        Me.btnAmount2.Text = "Select"
        '
        'btnAmount1
        '
        Me.btnAmount1.Location = New System.Drawing.Point(258, 80)
        Me.btnAmount1.Name = "btnAmount1"
        Me.btnAmount1.Size = New System.Drawing.Size(75, 23)
        Me.btnAmount1.TabIndex = 13
        Me.btnAmount1.Text = "Select"
        '
        'btnDescription
        '
        Me.btnDescription.Location = New System.Drawing.Point(258, 54)
        Me.btnDescription.Name = "btnDescription"
        Me.btnDescription.Size = New System.Drawing.Size(75, 23)
        Me.btnDescription.TabIndex = 12
        Me.btnDescription.Text = "Select"
        '
        'btnAcc
        '
        Me.btnAcc.Location = New System.Drawing.Point(258, 28)
        Me.btnAcc.Name = "btnAcc"
        Me.btnAcc.Size = New System.Drawing.Size(75, 23)
        Me.btnAcc.TabIndex = 11
        Me.btnAcc.Text = "Select"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(9, 33)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Account :"
        '
        'txtAccCell
        '
        Me.txtAccCell.Location = New System.Drawing.Point(92, 30)
        Me.txtAccCell.MenuManager = Me.BarManager1
        Me.txtAccCell.Name = "txtAccCell"
        Me.txtAccCell.Size = New System.Drawing.Size(77, 20)
        Me.txtAccCell.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(9, 59)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Description :"
        '
        'txtAmount2Cell
        '
        Me.txtAmount2Cell.Location = New System.Drawing.Point(92, 108)
        Me.txtAmount2Cell.MenuManager = Me.BarManager1
        Me.txtAmount2Cell.Name = "txtAmount2Cell"
        Me.txtAmount2Cell.Size = New System.Drawing.Size(77, 20)
        Me.txtAmount2Cell.TabIndex = 3
        '
        'txtDescriptionCell
        '
        Me.txtDescriptionCell.Location = New System.Drawing.Point(92, 56)
        Me.txtDescriptionCell.MenuManager = Me.BarManager1
        Me.txtDescriptionCell.Name = "txtDescriptionCell"
        Me.txtDescriptionCell.Size = New System.Drawing.Size(77, 20)
        Me.txtDescriptionCell.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(9, 111)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "Amount 2 :"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(9, 85)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "Amount 1 :"
        '
        'txtAmount1Cell
        '
        Me.txtAmount1Cell.Location = New System.Drawing.Point(92, 82)
        Me.txtAmount1Cell.MenuManager = Me.BarManager1
        Me.txtAmount1Cell.Name = "txtAmount1Cell"
        Me.txtAmount1Cell.Size = New System.Drawing.Size(77, 20)
        Me.txtAmount1Cell.TabIndex = 2
        '
        'txtStartRow
        '
        Me.txtStartRow.Location = New System.Drawing.Point(110, 74)
        Me.txtStartRow.MenuManager = Me.BarManager1
        Me.txtStartRow.Name = "txtStartRow"
        Me.txtStartRow.Properties.Mask.EditMask = "d"
        Me.txtStartRow.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtStartRow.Size = New System.Drawing.Size(77, 20)
        Me.txtStartRow.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(27, 77)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Start Row :"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(110, 48)
        Me.txtName.MenuManager = Me.BarManager1
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(350, 20)
        Me.txtName.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(27, 51)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Setting Name :"
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
        Me.TabbedView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.Document1})
        Me.TabbedView1.RootContainer.Element = Nothing
        DockingContainer1.Element = Me.DocumentGroup1
        Me.TabbedView1.RootContainer.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {DockingContainer1})
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ucMapping_Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "ucMapping_Setting"
        Me.Size = New System.Drawing.Size(1158, 588)
        CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Document1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAPPINGSETTINGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAccountMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel2.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        Me.DockPanel2_Container.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.txtPath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtModifiedBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModifiedDateTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtAccCell_A.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount2Cell_A.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescriptionCell_A.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount1Cell_A.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAccCell.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount2Cell.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescriptionCell.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount1Cell.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStartRow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DocumentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
    Friend WithEvents TabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
    Friend WithEvents DocumentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
    Friend WithEvents Document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cboType As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents MAPPINGSETTINGBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsAccountMapping As EasyTemplate_Taxcom.DsAccountMapping
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSetting_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStart_Row As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccNo_Cell As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription_Cell As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmount_Cell_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmount_Cell_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtModifiedBy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtModifiedDateTime As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAccCell As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmount2Cell As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescriptionCell As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmount1Cell As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStartRow As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtPath As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnAmount2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAmount1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDescription As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAcc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SpreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtAccCell_A As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAmount2Cell_A As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescriptionCell_A As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAmount1Cell_A As DevExpress.XtraEditors.TextEdit

End Class
