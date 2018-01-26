<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBalanceSheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucBalanceSheet))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cboRefNo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.btnImportExport = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRefNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHandleBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployerNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnClear2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.txtRefNo = New DevExpress.XtraEditors.TextEdit()
        Me.cboYA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnAllRecord = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.pnlLoading = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ReportGenerator1 = New DevExpress.XtraReports.ReportGeneration.ReportGenerator(Me.components)
        Me.DsDefault = New EasyTemplate_Taxcom.dsDefault()
        Me.TaxPayerFindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsBalanceSheet = New EasyTemplate_Taxcom.dsBalanceSheet()
        Me.BALANCESHEETBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colBS_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_REF_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_YA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_TRANSPORT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_MACHINERY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_LAND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_OTH_FA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_TOT_FA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_INVESTMENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_TRADE_DEBTORS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_OTH_DEBTORS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_LOAN_DIRECTOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_CASH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_OTH_CA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_TOT_CA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_TOT_ASSETS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_LOAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_TRADE_CR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_OTHER_CR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_LOAN_FR_DIR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_OTH_LIAB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_TOT_CUR_LIAB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_LT_LIAB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_TOT_LIAB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_CAPITAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_PNL_APPR_ACC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_RESERVE_ACC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_TOT_EQUITY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_TOT_LIAB_EQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_STOCK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_COMPANY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_CURYEARFA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBS_STATUS = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsBalanceSheet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BALANCESHEETBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cboRefNo)
        Me.PanelControl1.Controls.Add(Me.btnClear2)
        Me.PanelControl1.Controls.Add(Me.btnClear)
        Me.PanelControl1.Controls.Add(Me.txtRefNo)
        Me.PanelControl1.Controls.Add(Me.cboYA)
        Me.PanelControl1.Controls.Add(Me.btnAllRecord)
        Me.PanelControl1.Controls.Add(Me.btnFind)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 39)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1242, 92)
        Me.PanelControl1.TabIndex = 16
        '
        'cboRefNo
        '
        Me.cboRefNo.Location = New System.Drawing.Point(106, 18)
        Me.cboRefNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboRefNo.MenuManager = Me.BarManager1
        Me.cboRefNo.Name = "cboRefNo"
        Me.cboRefNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRefNo.Properties.DataSource = Me.TaxPayerFindBindingSource
        Me.cboRefNo.Properties.DisplayMember = "CompanyName"
        Me.cboRefNo.Properties.NullText = "Select"
        Me.cboRefNo.Properties.PopupFormMinSize = New System.Drawing.Size(600, 0)
        Me.cboRefNo.Properties.ValueMember = "RefNo"
        Me.cboRefNo.Properties.View = Me.SearchLookUpEdit2View
        Me.cboRefNo.Size = New System.Drawing.Size(313, 22)
        Me.cboRefNo.TabIndex = 162
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnAdd, Me.btnEdit, Me.btnDelete, Me.btnPrint, Me.btnImportExport})
        Me.BarManager1.MaxItemId = 7
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrint), New DevExpress.XtraBars.LinkPersistInfo(Me.btnImportExport)})
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
        'btnPrint
        '
        Me.btnPrint.Caption = "Print"
        Me.btnPrint.Id = 3
        Me.btnPrint.ImageOptions.Image = CType(resources.GetObject("btnPrint.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrint.ImageOptions.LargeImage = CType(resources.GetObject("btnPrint.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
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
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1242, 39)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 651)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1242, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 39)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 612)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1242, 39)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 612)
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
        'btnClear2
        '
        Me.btnClear2.ImageOptions.Image = CType(resources.GetObject("btnClear2.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClear2.Location = New System.Drawing.Point(794, 16)
        Me.btnClear2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear2.Name = "btnClear2"
        Me.btnClear2.Size = New System.Drawing.Size(28, 28)
        Me.btnClear2.TabIndex = 13
        '
        'btnClear
        '
        Me.btnClear.ImageOptions.Image = CType(resources.GetObject("btnClear.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClear.Location = New System.Drawing.Point(425, 16)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(28, 28)
        Me.btnClear.TabIndex = 12
        '
        'txtRefNo
        '
        Me.txtRefNo.Location = New System.Drawing.Point(106, 50)
        Me.txtRefNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRefNo.MenuManager = Me.BarManager1
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Properties.ReadOnly = True
        Me.txtRefNo.Size = New System.Drawing.Size(313, 22)
        Me.txtRefNo.TabIndex = 11
        '
        'cboYA
        '
        Me.cboYA.Location = New System.Drawing.Point(524, 17)
        Me.cboYA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboYA.Name = "cboYA"
        Me.cboYA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboYA.Properties.PopupSizeable = True
        Me.cboYA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboYA.Size = New System.Drawing.Size(264, 22)
        Me.cboYA.TabIndex = 10
        '
        'btnAllRecord
        '
        Me.btnAllRecord.ImageOptions.Image = CType(resources.GetObject("btnAllRecord.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAllRecord.Location = New System.Drawing.Point(524, 47)
        Me.btnAllRecord.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAllRecord.Name = "btnAllRecord"
        Me.btnAllRecord.Size = New System.Drawing.Size(128, 28)
        Me.btnAllRecord.TabIndex = 8
        Me.btnAllRecord.Text = "All Record"
        '
        'btnFind
        '
        Me.btnFind.ImageOptions.Image = CType(resources.GetObject("btnFind.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFind.Location = New System.Drawing.Point(659, 47)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(128, 28)
        Me.btnFind.TabIndex = 7
        Me.btnFind.Text = "Find"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(493, 21)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(24, 16)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "YA :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(14, 22)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(86, 16)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Reference No :"
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
        Me.pnlLoading.Location = New System.Drawing.Point(451, 337)
        Me.pnlLoading.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlLoading.Name = "pnlLoading"
        Me.pnlLoading.Size = New System.Drawing.Size(287, 81)
        Me.pnlLoading.TabIndex = 17
        Me.pnlLoading.Text = "ProgressPanel1"
        Me.pnlLoading.Visible = False
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BALANCESHEETBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridControl1.Location = New System.Drawing.Point(0, 131)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1242, 520)
        Me.GridControl1.TabIndex = 15
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBS_KEY, Me.colBS_STATUS, Me.colBS_REF_NO, Me.colBS_YA, Me.colBS_TRANSPORT, Me.colBS_MACHINERY, Me.colBS_LAND, Me.colBS_OTH_FA, Me.colBS_TOT_FA, Me.colBS_INVESTMENT, Me.colBS_TRADE_DEBTORS, Me.colBS_OTH_DEBTORS, Me.colBS_LOAN_DIRECTOR, Me.colBS_CASH, Me.colBS_OTH_CA, Me.colBS_TOT_CA, Me.colBS_TOT_ASSETS, Me.colBS_LOAN, Me.colBS_TRADE_CR, Me.colBS_OTHER_CR, Me.colBS_LOAN_FR_DIR, Me.colBS_OTH_LIAB, Me.colBS_TOT_CUR_LIAB, Me.colBS_LT_LIAB, Me.colBS_TOT_LIAB, Me.colBS_CAPITAL, Me.colBS_PNL_APPR_ACC, Me.colBS_RESERVE_ACC, Me.colBS_TOT_EQUITY, Me.colBS_TOT_LIAB_EQ, Me.colBS_STOCK, Me.colBS_COMPANY, Me.colBS_CURYEARFA, Me.colSME, Me.colModifiedBy, Me.colModifiedDateTime})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        '
        'DsDefault
        '
        Me.DsDefault.DataSetName = "dsDefault"
        Me.DsDefault.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TaxPayerFindBindingSource
        '
        Me.TaxPayerFindBindingSource.DataMember = "TaxPayerFind"
        Me.TaxPayerFindBindingSource.DataSource = Me.DsDefault
        '
        'DsBalanceSheet
        '
        Me.DsBalanceSheet.DataSetName = "dsBalanceSheet"
        Me.DsBalanceSheet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BALANCESHEETBindingSource
        '
        Me.BALANCESHEETBindingSource.DataMember = "BALANCE_SHEET"
        Me.BALANCESHEETBindingSource.DataSource = Me.DsBalanceSheet
        '
        'colBS_KEY
        '
        Me.colBS_KEY.Caption = "No"
        Me.colBS_KEY.FieldName = "BS_KEY"
        Me.colBS_KEY.Name = "colBS_KEY"
        Me.colBS_KEY.Visible = True
        Me.colBS_KEY.VisibleIndex = 0
        '
        'colBS_REF_NO
        '
        Me.colBS_REF_NO.Caption = "Reference No"
        Me.colBS_REF_NO.FieldName = "BS_REF_NO"
        Me.colBS_REF_NO.Name = "colBS_REF_NO"
        Me.colBS_REF_NO.Visible = True
        Me.colBS_REF_NO.VisibleIndex = 1
        Me.colBS_REF_NO.Width = 150
        '
        'colBS_YA
        '
        Me.colBS_YA.Caption = "YA"
        Me.colBS_YA.FieldName = "BS_YA"
        Me.colBS_YA.Name = "colBS_YA"
        Me.colBS_YA.Visible = True
        Me.colBS_YA.VisibleIndex = 2
        Me.colBS_YA.Width = 150
        '
        'colBS_TRANSPORT
        '
        Me.colBS_TRANSPORT.Caption = "Motor Vehicle"
        Me.colBS_TRANSPORT.FieldName = "BS_TRANSPORT"
        Me.colBS_TRANSPORT.Name = "colBS_TRANSPORT"
        Me.colBS_TRANSPORT.Visible = True
        Me.colBS_TRANSPORT.VisibleIndex = 3
        Me.colBS_TRANSPORT.Width = 120
        '
        'colBS_MACHINERY
        '
        Me.colBS_MACHINERY.Caption = "Plant && Machinery"
        Me.colBS_MACHINERY.FieldName = "BS_MACHINERY"
        Me.colBS_MACHINERY.Name = "colBS_MACHINERY"
        Me.colBS_MACHINERY.Visible = True
        Me.colBS_MACHINERY.VisibleIndex = 4
        Me.colBS_MACHINERY.Width = 120
        '
        'colBS_LAND
        '
        Me.colBS_LAND.Caption = "Land && Building"
        Me.colBS_LAND.FieldName = "BS_LAND"
        Me.colBS_LAND.Name = "colBS_LAND"
        Me.colBS_LAND.Visible = True
        Me.colBS_LAND.VisibleIndex = 5
        Me.colBS_LAND.Width = 120
        '
        'colBS_OTH_FA
        '
        Me.colBS_OTH_FA.Caption = "Other Fixed Assets"
        Me.colBS_OTH_FA.FieldName = "BS_OTH_FA"
        Me.colBS_OTH_FA.Name = "colBS_OTH_FA"
        Me.colBS_OTH_FA.Visible = True
        Me.colBS_OTH_FA.VisibleIndex = 6
        Me.colBS_OTH_FA.Width = 120
        '
        'colBS_TOT_FA
        '
        Me.colBS_TOT_FA.Caption = "Total Fixed Assets"
        Me.colBS_TOT_FA.FieldName = "BS_TOT_FA"
        Me.colBS_TOT_FA.Name = "colBS_TOT_FA"
        Me.colBS_TOT_FA.Visible = True
        Me.colBS_TOT_FA.VisibleIndex = 7
        Me.colBS_TOT_FA.Width = 120
        '
        'colBS_INVESTMENT
        '
        Me.colBS_INVESTMENT.Caption = "Investment"
        Me.colBS_INVESTMENT.FieldName = "BS_INVESTMENT"
        Me.colBS_INVESTMENT.Name = "colBS_INVESTMENT"
        Me.colBS_INVESTMENT.Visible = True
        Me.colBS_INVESTMENT.VisibleIndex = 8
        Me.colBS_INVESTMENT.Width = 120
        '
        'colBS_TRADE_DEBTORS
        '
        Me.colBS_TRADE_DEBTORS.Caption = "Trade Debtors"
        Me.colBS_TRADE_DEBTORS.FieldName = "BS_TRADE_DEBTORS"
        Me.colBS_TRADE_DEBTORS.Name = "colBS_TRADE_DEBTORS"
        Me.colBS_TRADE_DEBTORS.Visible = True
        Me.colBS_TRADE_DEBTORS.VisibleIndex = 9
        Me.colBS_TRADE_DEBTORS.Width = 120
        '
        'colBS_OTH_DEBTORS
        '
        Me.colBS_OTH_DEBTORS.Caption = "Other Debtors"
        Me.colBS_OTH_DEBTORS.FieldName = "BS_OTH_DEBTORS"
        Me.colBS_OTH_DEBTORS.Name = "colBS_OTH_DEBTORS"
        Me.colBS_OTH_DEBTORS.Visible = True
        Me.colBS_OTH_DEBTORS.VisibleIndex = 10
        Me.colBS_OTH_DEBTORS.Width = 120
        '
        'colBS_LOAN_DIRECTOR
        '
        Me.colBS_LOAN_DIRECTOR.Caption = "Loan to director"
        Me.colBS_LOAN_DIRECTOR.FieldName = "BS_LOAN_DIRECTOR"
        Me.colBS_LOAN_DIRECTOR.Name = "colBS_LOAN_DIRECTOR"
        Me.colBS_LOAN_DIRECTOR.Visible = True
        Me.colBS_LOAN_DIRECTOR.VisibleIndex = 11
        Me.colBS_LOAN_DIRECTOR.Width = 120
        '
        'colBS_CASH
        '
        Me.colBS_CASH.Caption = "Cash && Bank"
        Me.colBS_CASH.FieldName = "BS_CASH"
        Me.colBS_CASH.Name = "colBS_CASH"
        Me.colBS_CASH.Visible = True
        Me.colBS_CASH.VisibleIndex = 12
        Me.colBS_CASH.Width = 120
        '
        'colBS_OTH_CA
        '
        Me.colBS_OTH_CA.Caption = "Other Current Assets"
        Me.colBS_OTH_CA.FieldName = "BS_OTH_CA"
        Me.colBS_OTH_CA.Name = "colBS_OTH_CA"
        Me.colBS_OTH_CA.Visible = True
        Me.colBS_OTH_CA.VisibleIndex = 13
        Me.colBS_OTH_CA.Width = 120
        '
        'colBS_TOT_CA
        '
        Me.colBS_TOT_CA.Caption = "Total Current Assets"
        Me.colBS_TOT_CA.FieldName = "BS_TOT_CA"
        Me.colBS_TOT_CA.Name = "colBS_TOT_CA"
        Me.colBS_TOT_CA.Visible = True
        Me.colBS_TOT_CA.VisibleIndex = 14
        Me.colBS_TOT_CA.Width = 120
        '
        'colBS_TOT_ASSETS
        '
        Me.colBS_TOT_ASSETS.Caption = "Total Assets"
        Me.colBS_TOT_ASSETS.FieldName = "BS_TOT_ASSETS"
        Me.colBS_TOT_ASSETS.Name = "colBS_TOT_ASSETS"
        Me.colBS_TOT_ASSETS.Visible = True
        Me.colBS_TOT_ASSETS.VisibleIndex = 15
        Me.colBS_TOT_ASSETS.Width = 120
        '
        'colBS_LOAN
        '
        Me.colBS_LOAN.Caption = "Borrowing"
        Me.colBS_LOAN.FieldName = "BS_LOAN"
        Me.colBS_LOAN.Name = "colBS_LOAN"
        Me.colBS_LOAN.Visible = True
        Me.colBS_LOAN.VisibleIndex = 16
        Me.colBS_LOAN.Width = 120
        '
        'colBS_TRADE_CR
        '
        Me.colBS_TRADE_CR.Caption = "Trade Creditro"
        Me.colBS_TRADE_CR.FieldName = "BS_TRADE_CR"
        Me.colBS_TRADE_CR.Name = "colBS_TRADE_CR"
        Me.colBS_TRADE_CR.Visible = True
        Me.colBS_TRADE_CR.VisibleIndex = 17
        Me.colBS_TRADE_CR.Width = 120
        '
        'colBS_OTHER_CR
        '
        Me.colBS_OTHER_CR.Caption = "Other Creditor"
        Me.colBS_OTHER_CR.FieldName = "BS_OTHER_CR"
        Me.colBS_OTHER_CR.Name = "colBS_OTHER_CR"
        Me.colBS_OTHER_CR.Visible = True
        Me.colBS_OTHER_CR.VisibleIndex = 18
        Me.colBS_OTHER_CR.Width = 120
        '
        'colBS_LOAN_FR_DIR
        '
        Me.colBS_LOAN_FR_DIR.Caption = "Loan from Director"
        Me.colBS_LOAN_FR_DIR.FieldName = "BS_LOAN_FR_DIR"
        Me.colBS_LOAN_FR_DIR.Name = "colBS_LOAN_FR_DIR"
        Me.colBS_LOAN_FR_DIR.Visible = True
        Me.colBS_LOAN_FR_DIR.VisibleIndex = 19
        Me.colBS_LOAN_FR_DIR.Width = 120
        '
        'colBS_OTH_LIAB
        '
        Me.colBS_OTH_LIAB.Caption = "Other Current Liability"
        Me.colBS_OTH_LIAB.FieldName = "BS_OTH_LIAB"
        Me.colBS_OTH_LIAB.Name = "colBS_OTH_LIAB"
        Me.colBS_OTH_LIAB.Visible = True
        Me.colBS_OTH_LIAB.VisibleIndex = 20
        Me.colBS_OTH_LIAB.Width = 120
        '
        'colBS_TOT_CUR_LIAB
        '
        Me.colBS_TOT_CUR_LIAB.Caption = "Total Current Liability"
        Me.colBS_TOT_CUR_LIAB.FieldName = "BS_TOT_CUR_LIAB"
        Me.colBS_TOT_CUR_LIAB.Name = "colBS_TOT_CUR_LIAB"
        Me.colBS_TOT_CUR_LIAB.Visible = True
        Me.colBS_TOT_CUR_LIAB.VisibleIndex = 21
        Me.colBS_TOT_CUR_LIAB.Width = 120
        '
        'colBS_LT_LIAB
        '
        Me.colBS_LT_LIAB.Caption = "Long Term Liability"
        Me.colBS_LT_LIAB.FieldName = "BS_LT_LIAB"
        Me.colBS_LT_LIAB.Name = "colBS_LT_LIAB"
        Me.colBS_LT_LIAB.Visible = True
        Me.colBS_LT_LIAB.VisibleIndex = 22
        Me.colBS_LT_LIAB.Width = 120
        '
        'colBS_TOT_LIAB
        '
        Me.colBS_TOT_LIAB.Caption = "Total Liability"
        Me.colBS_TOT_LIAB.FieldName = "BS_TOT_LIAB"
        Me.colBS_TOT_LIAB.Name = "colBS_TOT_LIAB"
        Me.colBS_TOT_LIAB.Visible = True
        Me.colBS_TOT_LIAB.VisibleIndex = 23
        Me.colBS_TOT_LIAB.Width = 120
        '
        'colBS_CAPITAL
        '
        Me.colBS_CAPITAL.Caption = "Paid up Capital"
        Me.colBS_CAPITAL.FieldName = "BS_CAPITAL"
        Me.colBS_CAPITAL.Name = "colBS_CAPITAL"
        Me.colBS_CAPITAL.Visible = True
        Me.colBS_CAPITAL.VisibleIndex = 24
        Me.colBS_CAPITAL.Width = 120
        '
        'colBS_PNL_APPR_ACC
        '
        Me.colBS_PNL_APPR_ACC.Caption = "Appropration P && L"
        Me.colBS_PNL_APPR_ACC.FieldName = "BS_PNL_APPR_ACC"
        Me.colBS_PNL_APPR_ACC.Name = "colBS_PNL_APPR_ACC"
        Me.colBS_PNL_APPR_ACC.Visible = True
        Me.colBS_PNL_APPR_ACC.VisibleIndex = 25
        Me.colBS_PNL_APPR_ACC.Width = 120
        '
        'colBS_RESERVE_ACC
        '
        Me.colBS_RESERVE_ACC.Caption = "Reserves"
        Me.colBS_RESERVE_ACC.FieldName = "BS_RESERVE_ACC"
        Me.colBS_RESERVE_ACC.Name = "colBS_RESERVE_ACC"
        Me.colBS_RESERVE_ACC.Visible = True
        Me.colBS_RESERVE_ACC.VisibleIndex = 26
        Me.colBS_RESERVE_ACC.Width = 120
        '
        'colBS_TOT_EQUITY
        '
        Me.colBS_TOT_EQUITY.Caption = "Total Equity"
        Me.colBS_TOT_EQUITY.FieldName = "BS_TOT_EQUITY"
        Me.colBS_TOT_EQUITY.Name = "colBS_TOT_EQUITY"
        Me.colBS_TOT_EQUITY.Visible = True
        Me.colBS_TOT_EQUITY.VisibleIndex = 27
        Me.colBS_TOT_EQUITY.Width = 120
        '
        'colBS_TOT_LIAB_EQ
        '
        Me.colBS_TOT_LIAB_EQ.Caption = "Total Liability && Equity"
        Me.colBS_TOT_LIAB_EQ.FieldName = "BS_TOT_LIAB_EQ"
        Me.colBS_TOT_LIAB_EQ.Name = "colBS_TOT_LIAB_EQ"
        Me.colBS_TOT_LIAB_EQ.Visible = True
        Me.colBS_TOT_LIAB_EQ.VisibleIndex = 28
        Me.colBS_TOT_LIAB_EQ.Width = 120
        '
        'colBS_STOCK
        '
        Me.colBS_STOCK.Caption = "Stock"
        Me.colBS_STOCK.FieldName = "BS_STOCK"
        Me.colBS_STOCK.Name = "colBS_STOCK"
        Me.colBS_STOCK.Visible = True
        Me.colBS_STOCK.VisibleIndex = 29
        Me.colBS_STOCK.Width = 120
        '
        'colBS_COMPANY
        '
        Me.colBS_COMPANY.FieldName = "BS_COMPANY"
        Me.colBS_COMPANY.Name = "colBS_COMPANY"
        '
        'colBS_CURYEARFA
        '
        Me.colBS_CURYEARFA.Caption = "Current Year Fixed Asset"
        Me.colBS_CURYEARFA.FieldName = "BS_CURYEARFA"
        Me.colBS_CURYEARFA.Name = "colBS_CURYEARFA"
        Me.colBS_CURYEARFA.Visible = True
        Me.colBS_CURYEARFA.VisibleIndex = 30
        '
        'colSME
        '
        Me.colSME.Caption = "SME Status"
        Me.colSME.FieldName = "SME"
        Me.colSME.Name = "colSME"
        Me.colSME.Visible = True
        Me.colSME.VisibleIndex = 31
        Me.colSME.Width = 120
        '
        'colModifiedBy
        '
        Me.colModifiedBy.Caption = "Modified By"
        Me.colModifiedBy.FieldName = "ModifiedBy"
        Me.colModifiedBy.Name = "colModifiedBy"
        Me.colModifiedBy.Visible = True
        Me.colModifiedBy.VisibleIndex = 32
        Me.colModifiedBy.Width = 120
        '
        'colModifiedDateTime
        '
        Me.colModifiedDateTime.Caption = "Modified DateTime"
        Me.colModifiedDateTime.FieldName = "ModifiedDateTime"
        Me.colModifiedDateTime.Name = "colModifiedDateTime"
        Me.colModifiedDateTime.Visible = True
        Me.colModifiedDateTime.VisibleIndex = 33
        Me.colModifiedDateTime.Width = 120
        '
        'colBS_STATUS
        '
        Me.colBS_STATUS.Caption = "Status"
        Me.colBS_STATUS.FieldName = "BS_STATUS"
        Me.colBS_STATUS.Name = "colBS_STATUS"
        Me.colBS_STATUS.Visible = True
        Me.colBS_STATUS.VisibleIndex = 34
        '
        'ucBalanceSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlLoading)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ucBalanceSheet"
        Me.Size = New System.Drawing.Size(1242, 651)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsBalanceSheet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BALANCESHEETBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClear2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRefNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnImportExport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents pnlLoading As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cboYA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnAllRecord As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents ReportGenerator1 As DevExpress.XtraReports.ReportGeneration.ReportGenerator
    Friend WithEvents TaxPayerFindBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsDefault As EasyTemplate_Taxcom.dsDefault
    Friend WithEvents BALANCESHEETBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsBalanceSheet As EasyTemplate_Taxcom.dsBalanceSheet
    Friend WithEvents colBS_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_STATUS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_REF_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_YA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_TRANSPORT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_MACHINERY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_LAND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_OTH_FA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_TOT_FA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_INVESTMENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_TRADE_DEBTORS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_OTH_DEBTORS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_LOAN_DIRECTOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_CASH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_OTH_CA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_TOT_CA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_TOT_ASSETS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_LOAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_TRADE_CR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_OTHER_CR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_LOAN_FR_DIR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_OTH_LIAB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_TOT_CUR_LIAB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_LT_LIAB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_TOT_LIAB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_CAPITAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_PNL_APPR_ACC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_RESERVE_ACC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_TOT_EQUITY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_TOT_LIAB_EQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_STOCK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_COMPANY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBS_CURYEARFA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDateTime As DevExpress.XtraGrid.Columns.GridColumn

End Class
