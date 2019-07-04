<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdjustedIncome_Add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdjustedIncome_Add))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.lblStatus = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.txtTaxPayer = New DevExpress.XtraEditors.TextEdit()
        Me.cboSourceNo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.BUSINESSSOURCEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDefault = New EasyTemplate_Taxcom.dsDefault()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBC_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBC_SOURCEKEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBC_YA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBC_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBC_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBC_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBC_COMPANY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cboRefNo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.TaxPayerFindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRefNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHandleBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployerNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboYA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.XtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.txtTotBsLoss = New DevExpress.XtraEditors.TextEdit()
        Me.btnOthExp = New DevExpress.XtraEditors.SimpleButton()
        Me.ProgressPanel1 = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.btnOtherDeduc = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRevenueExp = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddMiningExp = New DevExpress.XtraEditors.SimpleButton()
        Me.btnMiningAllowing = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTaxIn = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSurplusMiningAllowance = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNALoss = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAdLoss = New DevExpress.XtraEditors.TextEdit()
        Me.txtAdIn = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotBSExp = New DevExpress.XtraEditors.TextEdit()
        Me.txtOthExp = New DevExpress.XtraEditors.TextEdit()
        Me.lblOthExp = New DevExpress.XtraEditors.LabelControl()
        Me.txtOtherDeduc = New DevExpress.XtraEditors.TextEdit()
        Me.lblOtherDeduc = New DevExpress.XtraEditors.LabelControl()
        Me.txtRevenueExp = New DevExpress.XtraEditors.TextEdit()
        Me.lblRevenueExp = New DevExpress.XtraEditors.LabelControl()
        Me.txtAddMiningExp = New DevExpress.XtraEditors.TextEdit()
        Me.lblAddMiningExp = New DevExpress.XtraEditors.LabelControl()
        Me.txtMiningAllowing = New DevExpress.XtraEditors.TextEdit()
        Me.lblMiningAllowing = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNAExp = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.txtInterestRestricted = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotBILoss = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotBIProfit = New DevExpress.XtraEditors.TextEdit()
        Me.lblTaxIn = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTaxIn = New DevExpress.XtraEditors.TextEdit()
        Me.txtNTaxIn = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.lblSurplusMiningAllowance = New DevExpress.XtraEditors.LabelControl()
        Me.txtSurplusMiningAllowance = New DevExpress.XtraEditors.TextEdit()
        Me.txtNALoss = New DevExpress.XtraEditors.TextEdit()
        Me.lblNALoss = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txtOthBsIn = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotBsProfit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtInterest = New DevExpress.XtraEditors.TextEdit()
        Me.txtRental = New DevExpress.XtraEditors.TextEdit()
        Me.txtSection4A = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotNonBs = New DevExpress.XtraEditors.TextEdit()
        Me.txtRoyalty = New DevExpress.XtraEditors.TextEdit()
        Me.txtDividend = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtBalLoss = New DevExpress.XtraEditors.TextEdit()
        Me.txtBalProfit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel2.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        CType(Me.txtTaxPayer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSourceNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BUSINESSSOURCEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.XtraScrollableControl1.SuspendLayout()
        CType(Me.txtTotBsLoss.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdLoss.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdIn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotBSExp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOthExp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOtherDeduc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRevenueExp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddMiningExp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMiningAllowing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNAExp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInterestRestricted.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotBILoss.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotBIProfit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTaxIn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNTaxIn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSurplusMiningAllowance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNALoss.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOthBsIn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotBsProfit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInterest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRental.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSection4A.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotNonBs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoyalty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDividend.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBalLoss.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBalProfit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSave, Me.btnClose, Me.lblStatus})
        Me.BarManager1.MaxItemId = 3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSave), New DevExpress.XtraBars.LinkPersistInfo(Me.btnClose), New DevExpress.XtraBars.LinkPersistInfo(Me.lblStatus)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
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
        Me.btnClose.Id = 1
        Me.btnClose.ImageOptions.Image = CType(resources.GetObject("btnClose.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClose.ImageOptions.LargeImage = CType(resources.GetObject("btnClose.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'lblStatus
        '
        Me.lblStatus.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.lblStatus.Id = 2
        Me.lblStatus.Name = "lblStatus"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1178, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 920)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1178, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 889)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1178, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 889)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel2, Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'DockPanel2
        '
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top
        Me.DockPanel2.FloatVertical = True
        Me.DockPanel2.ID = New System.Guid("68e1cabb-4681-4363-ac53-cff601c4ddf3")
        Me.DockPanel2.Location = New System.Drawing.Point(0, 31)
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.Options.AllowDockAsTabbedDocument = False
        Me.DockPanel2.Options.AllowDockBottom = False
        Me.DockPanel2.Options.AllowDockFill = False
        Me.DockPanel2.Options.AllowDockLeft = False
        Me.DockPanel2.Options.AllowFloating = False
        Me.DockPanel2.Options.FloatOnDblClick = False
        Me.DockPanel2.Options.ResizeDirection = DevExpress.XtraBars.Docking.Helpers.ResizeDirection.None
        Me.DockPanel2.Options.ShowCloseButton = False
        Me.DockPanel2.Options.ShowMaximizeButton = False
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(200, 126)
        Me.DockPanel2.Size = New System.Drawing.Size(1178, 126)
        Me.DockPanel2.Text = "General Information"
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.txtTaxPayer)
        Me.DockPanel2_Container.Controls.Add(Me.cboSourceNo)
        Me.DockPanel2_Container.Controls.Add(Me.LabelControl2)
        Me.DockPanel2_Container.Controls.Add(Me.LabelControl6)
        Me.DockPanel2_Container.Controls.Add(Me.LabelControl3)
        Me.DockPanel2_Container.Controls.Add(Me.LabelControl5)
        Me.DockPanel2_Container.Controls.Add(Me.cboRefNo)
        Me.DockPanel2_Container.Controls.Add(Me.cboYA)
        Me.DockPanel2_Container.Controls.Add(Me.LabelControl4)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(1170, 99)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'txtTaxPayer
        '
        Me.txtTaxPayer.Location = New System.Drawing.Point(122, 36)
        Me.txtTaxPayer.Name = "txtTaxPayer"
        Me.txtTaxPayer.Properties.ReadOnly = True
        Me.txtTaxPayer.Size = New System.Drawing.Size(280, 20)
        Me.txtTaxPayer.TabIndex = 159
        '
        'cboSourceNo
        '
        Me.cboSourceNo.Location = New System.Drawing.Point(557, 10)
        Me.cboSourceNo.MenuManager = Me.BarManager1
        Me.cboSourceNo.Name = "cboSourceNo"
        Me.cboSourceNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSourceNo.Properties.DataSource = Me.BUSINESSSOURCEBindingSource
        Me.cboSourceNo.Properties.DisplayMember = "BC_SOURCENO"
        Me.cboSourceNo.Properties.NullText = "Select"
        Me.cboSourceNo.Properties.PopupFormMinSize = New System.Drawing.Size(600, 0)
        Me.cboSourceNo.Properties.ValueMember = "BC_SOURCENO"
        Me.cboSourceNo.Properties.View = Me.GridView1
        Me.cboSourceNo.Size = New System.Drawing.Size(280, 20)
        Me.cboSourceNo.TabIndex = 187
        '
        'BUSINESSSOURCEBindingSource
        '
        Me.BUSINESSSOURCEBindingSource.DataMember = "BUSINESS_SOURCE"
        Me.BUSINESSSOURCEBindingSource.DataSource = Me.DsDefault
        '
        'DsDefault
        '
        Me.DsDefault.DataSetName = "dsDefault"
        Me.DsDefault.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBC_KEY, Me.colBC_SOURCEKEY, Me.colBC_YA, Me.colBC_SOURCENO, Me.colBC_CODE, Me.colBC_TYPE, Me.colBC_COMPANY})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colBC_KEY
        '
        Me.colBC_KEY.FieldName = "BC_KEY"
        Me.colBC_KEY.Name = "colBC_KEY"
        '
        'colBC_SOURCEKEY
        '
        Me.colBC_SOURCEKEY.FieldName = "BC_SOURCEKEY"
        Me.colBC_SOURCEKEY.Name = "colBC_SOURCEKEY"
        '
        'colBC_YA
        '
        Me.colBC_YA.FieldName = "BC_YA"
        Me.colBC_YA.Name = "colBC_YA"
        '
        'colBC_SOURCENO
        '
        Me.colBC_SOURCENO.Caption = "Source No"
        Me.colBC_SOURCENO.FieldName = "BC_SOURCENO"
        Me.colBC_SOURCENO.Name = "colBC_SOURCENO"
        Me.colBC_SOURCENO.Visible = True
        Me.colBC_SOURCENO.VisibleIndex = 0
        Me.colBC_SOURCENO.Width = 100
        '
        'colBC_CODE
        '
        Me.colBC_CODE.Caption = "Code"
        Me.colBC_CODE.FieldName = "BC_CODE"
        Me.colBC_CODE.Name = "colBC_CODE"
        Me.colBC_CODE.Visible = True
        Me.colBC_CODE.VisibleIndex = 1
        Me.colBC_CODE.Width = 100
        '
        'colBC_TYPE
        '
        Me.colBC_TYPE.Caption = "Type"
        Me.colBC_TYPE.FieldName = "BC_TYPE"
        Me.colBC_TYPE.Name = "colBC_TYPE"
        Me.colBC_TYPE.Visible = True
        Me.colBC_TYPE.VisibleIndex = 2
        Me.colBC_TYPE.Width = 350
        '
        'colBC_COMPANY
        '
        Me.colBC_COMPANY.FieldName = "BC_COMPANY"
        Me.colBC_COMPANY.Name = "colBC_COMPANY"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(4, 39)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Reference No :"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(439, 13)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl6.TabIndex = 186
        Me.LabelControl6.Text = "Business Source :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(4, 13)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl3.TabIndex = 158
        Me.LabelControl3.Text = "Tax Payer :"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(4, 65)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl5.TabIndex = 185
        Me.LabelControl5.Text = "Year Of Assessment :"
        '
        'cboRefNo
        '
        Me.cboRefNo.Location = New System.Drawing.Point(122, 10)
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
        Me.cboRefNo.TabIndex = 182
        '
        'TaxPayerFindBindingSource
        '
        Me.TaxPayerFindBindingSource.DataMember = "TaxPayerFind"
        Me.TaxPayerFindBindingSource.DataSource = Me.DsDefault
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
        'cboYA
        '
        Me.cboYA.Location = New System.Drawing.Point(122, 62)
        Me.cboYA.Name = "cboYA"
        Me.cboYA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboYA.Properties.PopupSizeable = True
        Me.cboYA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboYA.Size = New System.Drawing.Size(280, 20)
        Me.cboYA.TabIndex = 184
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(109, 39)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(7, 13)
        Me.LabelControl4.TabIndex = 183
        Me.LabelControl4.Text = "C"
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("f5373444-be27-4399-acc5-6197ec0b3c30")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 157)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.AllowFloating = False
        Me.DockPanel1.Options.FloatOnDblClick = False
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(587, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(587, 763)
        Me.DockPanel1.Text = "Adjusted Income"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.XtraScrollableControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(578, 736)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'XtraScrollableControl1
        '
        Me.XtraScrollableControl1.Controls.Add(Me.txtTotBsLoss)
        Me.XtraScrollableControl1.Controls.Add(Me.btnOthExp)
        Me.XtraScrollableControl1.Controls.Add(Me.ProgressPanel1)
        Me.XtraScrollableControl1.Controls.Add(Me.btnOtherDeduc)
        Me.XtraScrollableControl1.Controls.Add(Me.btnRevenueExp)
        Me.XtraScrollableControl1.Controls.Add(Me.btnAddMiningExp)
        Me.XtraScrollableControl1.Controls.Add(Me.btnMiningAllowing)
        Me.XtraScrollableControl1.Controls.Add(Me.btnTaxIn)
        Me.XtraScrollableControl1.Controls.Add(Me.btnSurplusMiningAllowance)
        Me.XtraScrollableControl1.Controls.Add(Me.btnNALoss)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl41)
        Me.XtraScrollableControl1.Controls.Add(Me.txtAdLoss)
        Me.XtraScrollableControl1.Controls.Add(Me.txtAdIn)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl39)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl40)
        Me.XtraScrollableControl1.Controls.Add(Me.txtTotBSExp)
        Me.XtraScrollableControl1.Controls.Add(Me.txtOthExp)
        Me.XtraScrollableControl1.Controls.Add(Me.lblOthExp)
        Me.XtraScrollableControl1.Controls.Add(Me.txtOtherDeduc)
        Me.XtraScrollableControl1.Controls.Add(Me.lblOtherDeduc)
        Me.XtraScrollableControl1.Controls.Add(Me.txtRevenueExp)
        Me.XtraScrollableControl1.Controls.Add(Me.lblRevenueExp)
        Me.XtraScrollableControl1.Controls.Add(Me.txtAddMiningExp)
        Me.XtraScrollableControl1.Controls.Add(Me.lblAddMiningExp)
        Me.XtraScrollableControl1.Controls.Add(Me.txtMiningAllowing)
        Me.XtraScrollableControl1.Controls.Add(Me.lblMiningAllowing)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl32)
        Me.XtraScrollableControl1.Controls.Add(Me.txtNAExp)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl31)
        Me.XtraScrollableControl1.Controls.Add(Me.txtInterestRestricted)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl30)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl29)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl28)
        Me.XtraScrollableControl1.Controls.Add(Me.txtTotBILoss)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl26)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl27)
        Me.XtraScrollableControl1.Controls.Add(Me.txtTotBIProfit)
        Me.XtraScrollableControl1.Controls.Add(Me.lblTaxIn)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl22)
        Me.XtraScrollableControl1.Controls.Add(Me.txtTaxIn)
        Me.XtraScrollableControl1.Controls.Add(Me.txtNTaxIn)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl23)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl24)
        Me.XtraScrollableControl1.Controls.Add(Me.lblSurplusMiningAllowance)
        Me.XtraScrollableControl1.Controls.Add(Me.txtSurplusMiningAllowance)
        Me.XtraScrollableControl1.Controls.Add(Me.txtNALoss)
        Me.XtraScrollableControl1.Controls.Add(Me.lblNALoss)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl19)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl18)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl17)
        Me.XtraScrollableControl1.Controls.Add(Me.txtOthBsIn)
        Me.XtraScrollableControl1.Controls.Add(Me.txtTotBsProfit)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl16)
        Me.XtraScrollableControl1.Controls.Add(Me.txtInterest)
        Me.XtraScrollableControl1.Controls.Add(Me.txtRental)
        Me.XtraScrollableControl1.Controls.Add(Me.txtSection4A)
        Me.XtraScrollableControl1.Controls.Add(Me.txtTotNonBs)
        Me.XtraScrollableControl1.Controls.Add(Me.txtRoyalty)
        Me.XtraScrollableControl1.Controls.Add(Me.txtDividend)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl15)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl14)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl13)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl12)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl11)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl10)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl9)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl8)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl7)
        Me.XtraScrollableControl1.Controls.Add(Me.txtBalLoss)
        Me.XtraScrollableControl1.Controls.Add(Me.txtBalProfit)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl1)
        Me.XtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraScrollableControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraScrollableControl1.Name = "XtraScrollableControl1"
        Me.XtraScrollableControl1.Size = New System.Drawing.Size(578, 736)
        Me.XtraScrollableControl1.TabIndex = 0
        '
        'txtTotBsLoss
        '
        Me.txtTotBsLoss.EditValue = "0"
        Me.txtTotBsLoss.Location = New System.Drawing.Point(403, 246)
        Me.txtTotBsLoss.Name = "txtTotBsLoss"
        Me.txtTotBsLoss.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotBsLoss.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotBsLoss.Properties.Mask.EditMask = "n0"
        Me.txtTotBsLoss.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotBsLoss.Properties.ReadOnly = True
        Me.txtTotBsLoss.Size = New System.Drawing.Size(124, 20)
        Me.txtTotBsLoss.TabIndex = 231
        '
        'btnOthExp
        '
        Me.btnOthExp.ImageOptions.Image = CType(resources.GetObject("btnOthExp.ImageOptions.Image"), System.Drawing.Image)
        Me.btnOthExp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnOthExp.Location = New System.Drawing.Point(533, 837)
        Me.btnOthExp.Name = "btnOthExp"
        Me.btnOthExp.Size = New System.Drawing.Size(28, 23)
        Me.btnOthExp.TabIndex = 230
        '
        'ProgressPanel1
        '
        Me.ProgressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel1.Appearance.Options.UseBackColor = True
        Me.ProgressPanel1.BarAnimationElementThickness = 2
        Me.ProgressPanel1.Location = New System.Drawing.Point(138, 112)
        Me.ProgressPanel1.Name = "ProgressPanel1"
        Me.ProgressPanel1.Size = New System.Drawing.Size(273, 72)
        Me.ProgressPanel1.TabIndex = 7
        Me.ProgressPanel1.Text = "ProgressPanel1"
        Me.ProgressPanel1.Visible = False
        '
        'btnOtherDeduc
        '
        Me.btnOtherDeduc.ImageOptions.Image = CType(resources.GetObject("btnOtherDeduc.ImageOptions.Image"), System.Drawing.Image)
        Me.btnOtherDeduc.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnOtherDeduc.Location = New System.Drawing.Point(533, 811)
        Me.btnOtherDeduc.Name = "btnOtherDeduc"
        Me.btnOtherDeduc.Size = New System.Drawing.Size(28, 23)
        Me.btnOtherDeduc.TabIndex = 229
        '
        'btnRevenueExp
        '
        Me.btnRevenueExp.ImageOptions.Image = CType(resources.GetObject("btnRevenueExp.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRevenueExp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnRevenueExp.Location = New System.Drawing.Point(533, 785)
        Me.btnRevenueExp.Name = "btnRevenueExp"
        Me.btnRevenueExp.Size = New System.Drawing.Size(28, 23)
        Me.btnRevenueExp.TabIndex = 228
        '
        'btnAddMiningExp
        '
        Me.btnAddMiningExp.ImageOptions.Image = CType(resources.GetObject("btnAddMiningExp.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddMiningExp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnAddMiningExp.Location = New System.Drawing.Point(533, 759)
        Me.btnAddMiningExp.Name = "btnAddMiningExp"
        Me.btnAddMiningExp.Size = New System.Drawing.Size(28, 23)
        Me.btnAddMiningExp.TabIndex = 227
        '
        'btnMiningAllowing
        '
        Me.btnMiningAllowing.ImageOptions.Image = CType(resources.GetObject("btnMiningAllowing.ImageOptions.Image"), System.Drawing.Image)
        Me.btnMiningAllowing.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnMiningAllowing.Location = New System.Drawing.Point(533, 733)
        Me.btnMiningAllowing.Name = "btnMiningAllowing"
        Me.btnMiningAllowing.Size = New System.Drawing.Size(28, 23)
        Me.btnMiningAllowing.TabIndex = 226
        '
        'btnTaxIn
        '
        Me.btnTaxIn.ImageOptions.Image = CType(resources.GetObject("btnTaxIn.ImageOptions.Image"), System.Drawing.Image)
        Me.btnTaxIn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnTaxIn.Location = New System.Drawing.Point(403, 468)
        Me.btnTaxIn.Name = "btnTaxIn"
        Me.btnTaxIn.Size = New System.Drawing.Size(28, 23)
        Me.btnTaxIn.TabIndex = 225
        '
        'btnSurplusMiningAllowance
        '
        Me.btnSurplusMiningAllowance.ImageOptions.Image = CType(resources.GetObject("btnSurplusMiningAllowance.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSurplusMiningAllowance.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnSurplusMiningAllowance.Location = New System.Drawing.Point(403, 347)
        Me.btnSurplusMiningAllowance.Name = "btnSurplusMiningAllowance"
        Me.btnSurplusMiningAllowance.Size = New System.Drawing.Size(28, 23)
        Me.btnSurplusMiningAllowance.TabIndex = 224
        '
        'btnNALoss
        '
        Me.btnNALoss.ImageOptions.Image = CType(resources.GetObject("btnNALoss.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNALoss.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnNALoss.Location = New System.Drawing.Point(403, 321)
        Me.btnNALoss.Name = "btnNALoss"
        Me.btnNALoss.Size = New System.Drawing.Size(28, 23)
        Me.btnNALoss.TabIndex = 223
        '
        'LabelControl41
        '
        Me.LabelControl41.Location = New System.Drawing.Point(9, 929)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(142, 13)
        Me.LabelControl41.TabIndex = 222
        Me.LabelControl41.Text = "F. ADJUSTED ICNOME / LOSS"
        '
        'txtAdLoss
        '
        Me.txtAdLoss.EditValue = "0"
        Me.txtAdLoss.Location = New System.Drawing.Point(403, 926)
        Me.txtAdLoss.Name = "txtAdLoss"
        Me.txtAdLoss.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAdLoss.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAdLoss.Properties.Mask.EditMask = "n0"
        Me.txtAdLoss.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAdLoss.Properties.ReadOnly = True
        Me.txtAdLoss.Size = New System.Drawing.Size(124, 20)
        Me.txtAdLoss.TabIndex = 221
        '
        'txtAdIn
        '
        Me.txtAdIn.EditValue = "0"
        Me.txtAdIn.Location = New System.Drawing.Point(273, 926)
        Me.txtAdIn.Name = "txtAdIn"
        Me.txtAdIn.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAdIn.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAdIn.Properties.Mask.EditMask = "n0"
        Me.txtAdIn.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAdIn.Properties.ReadOnly = True
        Me.txtAdIn.Size = New System.Drawing.Size(124, 20)
        Me.txtAdIn.TabIndex = 220
        '
        'LabelControl39
        '
        Me.LabelControl39.Appearance.Options.UseTextOptions = True
        Me.LabelControl39.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl39.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl39.Location = New System.Drawing.Point(45, 903)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl39.TabIndex = 218
        Me.LabelControl39.Text = "(E1 - E2)"
        '
        'LabelControl40
        '
        Me.LabelControl40.Location = New System.Drawing.Point(26, 880)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl40.TabIndex = 217
        Me.LabelControl40.Text = "4. TOTAL :"
        '
        'txtTotBSExp
        '
        Me.txtTotBSExp.EditValue = "0"
        Me.txtTotBSExp.Location = New System.Drawing.Point(273, 900)
        Me.txtTotBSExp.Name = "txtTotBSExp"
        Me.txtTotBSExp.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotBSExp.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotBSExp.Properties.Mask.EditMask = "n0"
        Me.txtTotBSExp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotBSExp.Properties.ReadOnly = True
        Me.txtTotBSExp.Size = New System.Drawing.Size(124, 20)
        Me.txtTotBSExp.TabIndex = 216
        '
        'txtOthExp
        '
        Me.txtOthExp.EditValue = "0"
        Me.txtOthExp.Location = New System.Drawing.Point(404, 840)
        Me.txtOthExp.Name = "txtOthExp"
        Me.txtOthExp.Properties.Appearance.Options.UseTextOptions = True
        Me.txtOthExp.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtOthExp.Properties.Mask.EditMask = "n0"
        Me.txtOthExp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtOthExp.Properties.ReadOnly = True
        Me.txtOthExp.Size = New System.Drawing.Size(124, 20)
        Me.txtOthExp.TabIndex = 215
        '
        'lblOthExp
        '
        Me.lblOthExp.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOthExp.Appearance.Options.UseFont = True
        Me.lblOthExp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblOthExp.Location = New System.Drawing.Point(46, 843)
        Me.lblOthExp.Name = "lblOthExp"
        Me.lblOthExp.Size = New System.Drawing.Size(198, 13)
        Me.lblOthExp.TabIndex = 214
        Me.lblOthExp.Text = "2.4 Claim for other expenditure/incentive"
        '
        'txtOtherDeduc
        '
        Me.txtOtherDeduc.EditValue = "0"
        Me.txtOtherDeduc.Location = New System.Drawing.Point(404, 814)
        Me.txtOtherDeduc.Name = "txtOtherDeduc"
        Me.txtOtherDeduc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtOtherDeduc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtOtherDeduc.Properties.Mask.EditMask = "n0"
        Me.txtOtherDeduc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtOtherDeduc.Properties.ReadOnly = True
        Me.txtOtherDeduc.Size = New System.Drawing.Size(124, 20)
        Me.txtOtherDeduc.TabIndex = 213
        '
        'lblOtherDeduc
        '
        Me.lblOtherDeduc.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOtherDeduc.Appearance.Options.UseFont = True
        Me.lblOtherDeduc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblOtherDeduc.Location = New System.Drawing.Point(66, 817)
        Me.lblOtherDeduc.Name = "lblOtherDeduc"
        Me.lblOtherDeduc.Size = New System.Drawing.Size(79, 13)
        Me.lblOtherDeduc.TabIndex = 212
        Me.lblOtherDeduc.Text = "Other Deduction"
        '
        'txtRevenueExp
        '
        Me.txtRevenueExp.EditValue = "0"
        Me.txtRevenueExp.Location = New System.Drawing.Point(403, 788)
        Me.txtRevenueExp.Name = "txtRevenueExp"
        Me.txtRevenueExp.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRevenueExp.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtRevenueExp.Properties.Mask.EditMask = "n0"
        Me.txtRevenueExp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRevenueExp.Properties.ReadOnly = True
        Me.txtRevenueExp.Size = New System.Drawing.Size(124, 20)
        Me.txtRevenueExp.TabIndex = 211
        '
        'lblRevenueExp
        '
        Me.lblRevenueExp.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevenueExp.Appearance.Options.UseFont = True
        Me.lblRevenueExp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRevenueExp.Location = New System.Drawing.Point(45, 791)
        Me.lblRevenueExp.Name = "lblRevenueExp"
        Me.lblRevenueExp.Size = New System.Drawing.Size(176, 13)
        Me.lblRevenueExp.TabIndex = 210
        Me.lblRevenueExp.Text = "2.3 Revenue expenditure capitalised"
        '
        'txtAddMiningExp
        '
        Me.txtAddMiningExp.EditValue = "0"
        Me.txtAddMiningExp.Location = New System.Drawing.Point(403, 762)
        Me.txtAddMiningExp.Name = "txtAddMiningExp"
        Me.txtAddMiningExp.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAddMiningExp.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAddMiningExp.Properties.Mask.EditMask = "n0"
        Me.txtAddMiningExp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAddMiningExp.Properties.ReadOnly = True
        Me.txtAddMiningExp.Size = New System.Drawing.Size(124, 20)
        Me.txtAddMiningExp.TabIndex = 209
        '
        'lblAddMiningExp
        '
        Me.lblAddMiningExp.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddMiningExp.Appearance.Options.UseFont = True
        Me.lblAddMiningExp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAddMiningExp.Location = New System.Drawing.Point(45, 765)
        Me.lblAddMiningExp.Name = "lblAddMiningExp"
        Me.lblAddMiningExp.Size = New System.Drawing.Size(136, 13)
        Me.lblAddMiningExp.TabIndex = 208
        Me.lblAddMiningExp.Text = "2.2 Surplus Mining Expenses"
        '
        'txtMiningAllowing
        '
        Me.txtMiningAllowing.EditValue = "0"
        Me.txtMiningAllowing.Location = New System.Drawing.Point(403, 736)
        Me.txtMiningAllowing.Name = "txtMiningAllowing"
        Me.txtMiningAllowing.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMiningAllowing.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMiningAllowing.Properties.Mask.EditMask = "n0"
        Me.txtMiningAllowing.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMiningAllowing.Properties.ReadOnly = True
        Me.txtMiningAllowing.Size = New System.Drawing.Size(124, 20)
        Me.txtMiningAllowing.TabIndex = 205
        '
        'lblMiningAllowing
        '
        Me.lblMiningAllowing.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiningAllowing.Appearance.Options.UseFont = True
        Me.lblMiningAllowing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMiningAllowing.Location = New System.Drawing.Point(45, 739)
        Me.lblMiningAllowing.Name = "lblMiningAllowing"
        Me.lblMiningAllowing.Size = New System.Drawing.Size(100, 13)
        Me.lblMiningAllowing.TabIndex = 204
        Me.lblMiningAllowing.Text = "2.1 Mining Allowance"
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(26, 720)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl32.TabIndex = 203
        Me.LabelControl32.Text = "2. LESS :"
        '
        'txtNAExp
        '
        Me.txtNAExp.EditValue = "0"
        Me.txtNAExp.Location = New System.Drawing.Point(273, 669)
        Me.txtNAExp.Name = "txtNAExp"
        Me.txtNAExp.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNAExp.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNAExp.Properties.Mask.EditMask = "n0"
        Me.txtNAExp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNAExp.Properties.ReadOnly = True
        Me.txtNAExp.Size = New System.Drawing.Size(124, 20)
        Me.txtNAExp.TabIndex = 202
        '
        'LabelControl31
        '
        Me.LabelControl31.Appearance.Options.UseTextOptions = True
        Me.LabelControl31.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl31.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl31.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl31.Location = New System.Drawing.Point(45, 672)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(222, 42)
        Me.LabelControl31.TabIndex = 201
        Me.LabelControl31.Text = "1.2 Non-allowable expenditure pursuant to sec 39(1)"
        '
        'txtInterestRestricted
        '
        Me.txtInterestRestricted.EditValue = "0"
        Me.txtInterestRestricted.Location = New System.Drawing.Point(273, 643)
        Me.txtInterestRestricted.Name = "txtInterestRestricted"
        Me.txtInterestRestricted.Properties.Appearance.Options.UseTextOptions = True
        Me.txtInterestRestricted.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtInterestRestricted.Properties.Mask.EditMask = "n0"
        Me.txtInterestRestricted.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtInterestRestricted.Properties.ReadOnly = True
        Me.txtInterestRestricted.Size = New System.Drawing.Size(124, 20)
        Me.txtInterestRestricted.TabIndex = 200
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(45, 646)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(214, 13)
        Me.LabelControl30.TabIndex = 199
        Me.LabelControl30.Text = "1.1 Interest restricted pursuant to sec 33(2)"
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(26, 627)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl29.TabIndex = 198
        Me.LabelControl29.Text = "1. ADD :"
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(9, 597)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(230, 13)
        Me.LabelControl28.TabIndex = 197
        Me.LabelControl28.Text = "E. ADJUSTMENTS FOR BUSINESS EXPENDITURE"
        '
        'txtTotBILoss
        '
        Me.txtTotBILoss.EditValue = "0"
        Me.txtTotBILoss.Location = New System.Drawing.Point(403, 554)
        Me.txtTotBILoss.Name = "txtTotBILoss"
        Me.txtTotBILoss.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotBILoss.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotBILoss.Properties.Mask.EditMask = "n0"
        Me.txtTotBILoss.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotBILoss.Properties.ReadOnly = True
        Me.txtTotBILoss.Size = New System.Drawing.Size(124, 20)
        Me.txtTotBILoss.TabIndex = 196
        '
        'LabelControl26
        '
        Me.LabelControl26.Appearance.Options.UseTextOptions = True
        Me.LabelControl26.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl26.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl26.Location = New System.Drawing.Point(45, 557)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl26.TabIndex = 195
        Me.LabelControl26.Text = "(D1 - D2 + D3)"
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(26, 534)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl27.TabIndex = 194
        Me.LabelControl27.Text = "4. TOTAL :"
        '
        'txtTotBIProfit
        '
        Me.txtTotBIProfit.EditValue = "0"
        Me.txtTotBIProfit.Location = New System.Drawing.Point(273, 554)
        Me.txtTotBIProfit.Name = "txtTotBIProfit"
        Me.txtTotBIProfit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotBIProfit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotBIProfit.Properties.Mask.EditMask = "n0"
        Me.txtTotBIProfit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotBIProfit.Properties.ReadOnly = True
        Me.txtTotBIProfit.Size = New System.Drawing.Size(124, 20)
        Me.txtTotBIProfit.TabIndex = 193
        '
        'lblTaxIn
        '
        Me.lblTaxIn.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxIn.Appearance.Options.UseFont = True
        Me.lblTaxIn.Appearance.Options.UseTextOptions = True
        Me.lblTaxIn.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lblTaxIn.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lblTaxIn.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTaxIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTaxIn.Location = New System.Drawing.Point(45, 474)
        Me.lblTaxIn.Name = "lblTaxIn"
        Me.lblTaxIn.Size = New System.Drawing.Size(222, 43)
        Me.lblTaxIn.TabIndex = 192
        Me.lblTaxIn.Text = "Non-taxable income/gain taken up in Proft and Loss Account but taken up in Balanc" & _
    "e Sheet"
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(26, 451)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl22.TabIndex = 191
        Me.LabelControl22.Text = "3. ADD :"
        '
        'txtTaxIn
        '
        Me.txtTaxIn.EditValue = "0"
        Me.txtTaxIn.Location = New System.Drawing.Point(273, 471)
        Me.txtTaxIn.Name = "txtTaxIn"
        Me.txtTaxIn.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTaxIn.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTaxIn.Properties.Mask.EditMask = "n0"
        Me.txtTaxIn.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTaxIn.Properties.ReadOnly = True
        Me.txtTaxIn.Size = New System.Drawing.Size(124, 20)
        Me.txtTaxIn.TabIndex = 190
        '
        'txtNTaxIn
        '
        Me.txtNTaxIn.EditValue = "0"
        Me.txtNTaxIn.Location = New System.Drawing.Point(403, 399)
        Me.txtNTaxIn.Name = "txtNTaxIn"
        Me.txtNTaxIn.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNTaxIn.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNTaxIn.Properties.Mask.EditMask = "n0"
        Me.txtNTaxIn.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNTaxIn.Properties.ReadOnly = True
        Me.txtNTaxIn.Size = New System.Drawing.Size(124, 20)
        Me.txtNTaxIn.TabIndex = 189
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Options.UseTextOptions = True
        Me.LabelControl23.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl23.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl23.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl23.Location = New System.Drawing.Point(45, 402)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(222, 43)
        Me.LabelControl23.TabIndex = 188
        Me.LabelControl23.Text = "Non-taxable income/gain taken up in Proft and Loss Account"
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(26, 383)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl24.TabIndex = 187
        Me.LabelControl24.Text = "2. LESS :"
        '
        'lblSurplusMiningAllowance
        '
        Me.lblSurplusMiningAllowance.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurplusMiningAllowance.Appearance.Options.UseFont = True
        Me.lblSurplusMiningAllowance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSurplusMiningAllowance.Location = New System.Drawing.Point(45, 353)
        Me.lblSurplusMiningAllowance.Name = "lblSurplusMiningAllowance"
        Me.lblSurplusMiningAllowance.Size = New System.Drawing.Size(184, 13)
        Me.lblSurplusMiningAllowance.TabIndex = 186
        Me.lblSurplusMiningAllowance.Text = "Surplus Recovered Mining Expenditure"
        '
        'txtSurplusMiningAllowance
        '
        Me.txtSurplusMiningAllowance.EditValue = "0"
        Me.txtSurplusMiningAllowance.Location = New System.Drawing.Point(273, 350)
        Me.txtSurplusMiningAllowance.Name = "txtSurplusMiningAllowance"
        Me.txtSurplusMiningAllowance.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSurplusMiningAllowance.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSurplusMiningAllowance.Properties.Mask.EditMask = "n0"
        Me.txtSurplusMiningAllowance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSurplusMiningAllowance.Properties.ReadOnly = True
        Me.txtSurplusMiningAllowance.Size = New System.Drawing.Size(124, 20)
        Me.txtSurplusMiningAllowance.TabIndex = 185
        '
        'txtNALoss
        '
        Me.txtNALoss.EditValue = "0"
        Me.txtNALoss.Location = New System.Drawing.Point(273, 324)
        Me.txtNALoss.Name = "txtNALoss"
        Me.txtNALoss.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNALoss.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNALoss.Properties.Mask.EditMask = "n0"
        Me.txtNALoss.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNALoss.Properties.ReadOnly = True
        Me.txtNALoss.Size = New System.Drawing.Size(124, 20)
        Me.txtNALoss.TabIndex = 184
        '
        'lblNALoss
        '
        Me.lblNALoss.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNALoss.Appearance.Options.UseFont = True
        Me.lblNALoss.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNALoss.Location = New System.Drawing.Point(45, 327)
        Me.lblNALoss.Name = "lblNALoss"
        Me.lblNALoss.Size = New System.Drawing.Size(88, 13)
        Me.lblNALoss.TabIndex = 183
        Me.lblNALoss.Text = "Non-allowable loss"
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(26, 308)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl19.TabIndex = 182
        Me.LabelControl19.Text = "1. ADD :"
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(9, 278)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(197, 13)
        Me.LabelControl18.TabIndex = 181
        Me.LabelControl18.Text = "D. ADJUSTMENT FOR BUSINESS INCOME"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(9, 249)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(168, 13)
        Me.LabelControl17.TabIndex = 180
        Me.LabelControl17.Text = "C. TOTAL BUSINESS INCOME (A-B)"
        '
        'txtOthBsIn
        '
        Me.txtOthBsIn.EditValue = "0"
        Me.txtOthBsIn.Location = New System.Drawing.Point(273, 220)
        Me.txtOthBsIn.Name = "txtOthBsIn"
        Me.txtOthBsIn.Properties.Appearance.Options.UseTextOptions = True
        Me.txtOthBsIn.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtOthBsIn.Properties.Mask.EditMask = "n0"
        Me.txtOthBsIn.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtOthBsIn.Properties.ReadOnly = True
        Me.txtOthBsIn.Size = New System.Drawing.Size(124, 20)
        Me.txtOthBsIn.TabIndex = 179
        Me.txtOthBsIn.Visible = False
        '
        'txtTotBsProfit
        '
        Me.txtTotBsProfit.EditValue = "0"
        Me.txtTotBsProfit.Location = New System.Drawing.Point(273, 246)
        Me.txtTotBsProfit.Name = "txtTotBsProfit"
        Me.txtTotBsProfit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotBsProfit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotBsProfit.Properties.Mask.EditMask = "n0"
        Me.txtTotBsProfit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotBsProfit.Properties.ReadOnly = True
        Me.txtTotBsProfit.Size = New System.Drawing.Size(124, 20)
        Me.txtTotBsProfit.TabIndex = 178
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(9, 223)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(165, 13)
        Me.LabelControl16.TabIndex = 177
        Me.LabelControl16.Text = "B. TOTAL NON-BUSINESS INCOME"
        '
        'txtInterest
        '
        Me.txtInterest.EditValue = "0"
        Me.txtInterest.Location = New System.Drawing.Point(403, 116)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Properties.Appearance.Options.UseTextOptions = True
        Me.txtInterest.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtInterest.Properties.Mask.EditMask = "n0"
        Me.txtInterest.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtInterest.Properties.ReadOnly = True
        Me.txtInterest.Size = New System.Drawing.Size(124, 20)
        Me.txtInterest.TabIndex = 173
        '
        'txtRental
        '
        Me.txtRental.EditValue = "0"
        Me.txtRental.Location = New System.Drawing.Point(403, 142)
        Me.txtRental.Name = "txtRental"
        Me.txtRental.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRental.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtRental.Properties.Mask.EditMask = "n0"
        Me.txtRental.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRental.Properties.ReadOnly = True
        Me.txtRental.Size = New System.Drawing.Size(124, 20)
        Me.txtRental.TabIndex = 174
        '
        'txtSection4A
        '
        Me.txtSection4A.EditValue = "0"
        Me.txtSection4A.Location = New System.Drawing.Point(403, 194)
        Me.txtSection4A.Name = "txtSection4A"
        Me.txtSection4A.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSection4A.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSection4A.Properties.Mask.EditMask = "n0"
        Me.txtSection4A.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSection4A.Properties.ReadOnly = True
        Me.txtSection4A.Size = New System.Drawing.Size(124, 20)
        Me.txtSection4A.TabIndex = 175
        '
        'txtTotNonBs
        '
        Me.txtTotNonBs.EditValue = "0"
        Me.txtTotNonBs.Location = New System.Drawing.Point(403, 220)
        Me.txtTotNonBs.Name = "txtTotNonBs"
        Me.txtTotNonBs.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotNonBs.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotNonBs.Properties.Mask.EditMask = "n0"
        Me.txtTotNonBs.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotNonBs.Properties.ReadOnly = True
        Me.txtTotNonBs.Size = New System.Drawing.Size(124, 20)
        Me.txtTotNonBs.TabIndex = 176
        '
        'txtRoyalty
        '
        Me.txtRoyalty.EditValue = "0"
        Me.txtRoyalty.Location = New System.Drawing.Point(403, 168)
        Me.txtRoyalty.Name = "txtRoyalty"
        Me.txtRoyalty.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRoyalty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtRoyalty.Properties.Mask.EditMask = "n0"
        Me.txtRoyalty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRoyalty.Properties.ReadOnly = True
        Me.txtRoyalty.Size = New System.Drawing.Size(124, 20)
        Me.txtRoyalty.TabIndex = 173
        '
        'txtDividend
        '
        Me.txtDividend.EditValue = "0"
        Me.txtDividend.Location = New System.Drawing.Point(403, 90)
        Me.txtDividend.Name = "txtDividend"
        Me.txtDividend.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDividend.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDividend.Properties.Mask.EditMask = "n0"
        Me.txtDividend.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDividend.Properties.ReadOnly = True
        Me.txtDividend.Size = New System.Drawing.Size(124, 20)
        Me.txtDividend.TabIndex = 172
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(26, 197)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl15.TabIndex = 171
        Me.LabelControl15.Text = "Section 4A Income"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(26, 171)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl14.TabIndex = 170
        Me.LabelControl14.Text = "Royalty Income"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(26, 145)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl13.TabIndex = 169
        Me.LabelControl13.Text = "Rental Income"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(26, 119)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl12.TabIndex = 168
        Me.LabelControl12.Text = "Interest Income"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(26, 93)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl11.TabIndex = 167
        Me.LabelControl11.Text = "Dividend Income"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(26, 74)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl10.TabIndex = 166
        Me.LabelControl10.Text = "LESS :"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(26, 55)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(290, 13)
        Me.LabelControl9.TabIndex = 165
        Me.LabelControl9.Text = "SEGREGATION OF INCOME BASED ON CLASSES OF INCOME"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(460, 3)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl8.TabIndex = 164
        Me.LabelControl8.Text = "-"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(326, 3)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(8, 13)
        Me.LabelControl7.TabIndex = 163
        Me.LabelControl7.Text = "+"
        '
        'txtBalLoss
        '
        Me.txtBalLoss.EditValue = "0"
        Me.txtBalLoss.Location = New System.Drawing.Point(403, 20)
        Me.txtBalLoss.Name = "txtBalLoss"
        Me.txtBalLoss.Properties.Appearance.Options.UseTextOptions = True
        Me.txtBalLoss.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtBalLoss.Properties.Mask.EditMask = "n0"
        Me.txtBalLoss.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtBalLoss.Properties.ReadOnly = True
        Me.txtBalLoss.Size = New System.Drawing.Size(124, 20)
        Me.txtBalLoss.TabIndex = 162
        '
        'txtBalProfit
        '
        Me.txtBalProfit.EditValue = "0"
        Me.txtBalProfit.Location = New System.Drawing.Point(273, 20)
        Me.txtBalProfit.Name = "txtBalProfit"
        Me.txtBalProfit.Properties.Appearance.Options.UseTextOptions = True
        Me.txtBalProfit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtBalProfit.Properties.Mask.EditMask = "n0"
        Me.txtBalProfit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtBalProfit.Properties.ReadOnly = True
        Me.txtBalProfit.Size = New System.Drawing.Size(124, 20)
        Me.txtBalProfit.TabIndex = 161
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(9, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(217, 13)
        Me.LabelControl1.TabIndex = 160
        Me.LabelControl1.Text = "A. BALANCE IN PROFIT AND LOSS ACCOUNT"
        '
        'DocumentManager1
        '
        Me.DocumentManager1.ContainerControl = Me
        Me.DocumentManager1.View = Me.TabbedView1
        Me.DocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.TabbedView1})
        '
        'TabbedView1
        '
        Me.TabbedView1.RootContainer.Element = Nothing
        '
        'frmAdjustedIncome_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 920)
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.DockPanel2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmAdjustedIncome_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adjusted Income"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel2.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        Me.DockPanel2_Container.PerformLayout()
        CType(Me.txtTaxPayer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSourceNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BUSINESSSOURCEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.XtraScrollableControl1.ResumeLayout(False)
        Me.XtraScrollableControl1.PerformLayout()
        CType(Me.txtTotBsLoss.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdLoss.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdIn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotBSExp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOthExp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOtherDeduc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRevenueExp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddMiningExp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMiningAllowing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNAExp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInterestRestricted.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotBILoss.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotBIProfit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTaxIn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNTaxIn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSurplusMiningAllowance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNALoss.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOthBsIn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotBsProfit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInterest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRental.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSection4A.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotNonBs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoyalty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDividend.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBalLoss.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBalProfit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DocumentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
    Friend WithEvents TabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
    Friend WithEvents txtTaxPayer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboYA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboSourceNo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents txtNAExp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInterestRestricted As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotBILoss As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotBIProfit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTaxIn As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTaxIn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNTaxIn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSurplusMiningAllowance As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSurplusMiningAllowance As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNALoss As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNALoss As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOthBsIn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotBsProfit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInterest As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRental As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSection4A As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotNonBs As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRoyalty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDividend As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBalLoss As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBalProfit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOtherDeduc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblOtherDeduc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRevenueExp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblRevenueExp As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAddMiningExp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblAddMiningExp As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMiningAllowing As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMiningAllowing As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAdLoss As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAdIn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotBSExp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOthExp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblOthExp As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents btnOthExp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOtherDeduc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRevenueExp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddMiningExp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMiningAllowing As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTaxIn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSurplusMiningAllowance As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNALoss As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BUSINESSSOURCEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsDefault As EasyTemplate_Taxcom.dsDefault
    Friend WithEvents TaxPayerFindBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colBC_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBC_SOURCEKEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBC_YA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBC_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBC_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBC_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBC_COMPANY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProgressPanel1 As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents txtTotBsLoss As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblStatus As DevExpress.XtraBars.BarStaticItem
End Class
