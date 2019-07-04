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
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintAdmin = New DevExpress.XtraBars.BarButtonItem()
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
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyReferenceNoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyYAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROFITLOSSACCOUNTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPNL = New EasyTemplate_Taxcom.dsPNL()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPL_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPNLStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_REF_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_YA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_MAINBUZ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_GROSS_PROFIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_OTH_BSIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_OTH_IN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NONTAX_IN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_TOT_EXP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_NET_PROFIT_LOSS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_DISALLOWED_EXP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_S60F = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPL_S60FA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboYA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TaxPayerFindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCA = New EasyTemplate_Taxcom.dsCA()
        Me.btnAllRecord = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
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
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PROFITLOSSACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPNL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlLoading.Location = New System.Drawing.Point(347, 206)
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnAdd, Me.btnEdit, Me.btnDelete, Me.btnPrint, Me.BarButtonItem1, Me.btnPrintAdmin})
        Me.BarManager1.MaxItemId = 9
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrint), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrintAdmin)})
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
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Test"
        Me.BarButtonItem1.Id = 7
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btnPrintAdmin
        '
        Me.btnPrintAdmin.Caption = "Print Admin"
        Me.btnPrintAdmin.Id = 8
        Me.btnPrintAdmin.Name = "btnPrintAdmin"
        Me.btnPrintAdmin.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.PrintToolStripMenuItem, Me.CopyReferenceNoToolStripMenuItem, Me.CopyYAToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(177, 136)
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
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
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
        'PROFITLOSSACCOUNTBindingSource
        '
        Me.PROFITLOSSACCOUNTBindingSource.DataMember = "PROFIT_LOSS_ACCOUNT"
        Me.PROFITLOSSACCOUNTBindingSource.DataSource = Me.DsPNL
        '
        'DsPNL
        '
        Me.DsPNL.DataSetName = "dsPNL"
        Me.DsPNL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPL_KEY, Me.colPNLStatus, Me.colPL_REF_NO, Me.colPL_YA, Me.colPL_MAINBUZ, Me.colPL_GROSS_PROFIT, Me.colPL_OTH_BSIN, Me.colPL_OTH_IN, Me.colPL_NONTAX_IN, Me.colPL_TOT_EXP, Me.colPL_NET_PROFIT_LOSS, Me.colPL_DISALLOWED_EXP, Me.colPL_S60F, Me.colPL_S60FA, Me.colModifiedBy, Me.colModifiedDateTime})
        Me.GridView1.GridControl = Me.dgvView
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        '
        'colPL_KEY
        '
        Me.colPL_KEY.Caption = "No"
        Me.colPL_KEY.FieldName = "PL_KEY"
        Me.colPL_KEY.Name = "colPL_KEY"
        Me.colPL_KEY.Visible = True
        Me.colPL_KEY.VisibleIndex = 0
        '
        'colPNLStatus
        '
        Me.colPNLStatus.AppearanceCell.Options.UseTextOptions = True
        Me.colPNLStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPNLStatus.Caption = "Status"
        Me.colPNLStatus.FieldName = "PNL_Status"
        Me.colPNLStatus.Name = "colPNLStatus"
        Me.colPNLStatus.Visible = True
        Me.colPNLStatus.VisibleIndex = 1
        Me.colPNLStatus.Width = 150
        '
        'colPL_REF_NO
        '
        Me.colPL_REF_NO.Caption = "Reference No"
        Me.colPL_REF_NO.FieldName = "PL_REF_NO"
        Me.colPL_REF_NO.Name = "colPL_REF_NO"
        Me.colPL_REF_NO.Visible = True
        Me.colPL_REF_NO.VisibleIndex = 2
        Me.colPL_REF_NO.Width = 120
        '
        'colPL_YA
        '
        Me.colPL_YA.Caption = "YA"
        Me.colPL_YA.FieldName = "PL_YA"
        Me.colPL_YA.Name = "colPL_YA"
        Me.colPL_YA.Visible = True
        Me.colPL_YA.VisibleIndex = 3
        Me.colPL_YA.Width = 100
        '
        'colPL_MAINBUZ
        '
        Me.colPL_MAINBUZ.Caption = "Source No"
        Me.colPL_MAINBUZ.FieldName = "PL_MAINBUZ"
        Me.colPL_MAINBUZ.Name = "colPL_MAINBUZ"
        Me.colPL_MAINBUZ.Visible = True
        Me.colPL_MAINBUZ.VisibleIndex = 4
        Me.colPL_MAINBUZ.Width = 80
        '
        'colPL_GROSS_PROFIT
        '
        Me.colPL_GROSS_PROFIT.Caption = "Gross Profit / Loss"
        Me.colPL_GROSS_PROFIT.FieldName = "PL_GROSS_PROFIT"
        Me.colPL_GROSS_PROFIT.Name = "colPL_GROSS_PROFIT"
        Me.colPL_GROSS_PROFIT.Visible = True
        Me.colPL_GROSS_PROFIT.VisibleIndex = 5
        Me.colPL_GROSS_PROFIT.Width = 100
        '
        'colPL_OTH_BSIN
        '
        Me.colPL_OTH_BSIN.Caption = "Other Business Income"
        Me.colPL_OTH_BSIN.FieldName = "PL_OTH_BSIN"
        Me.colPL_OTH_BSIN.Name = "colPL_OTH_BSIN"
        Me.colPL_OTH_BSIN.Visible = True
        Me.colPL_OTH_BSIN.VisibleIndex = 6
        Me.colPL_OTH_BSIN.Width = 100
        '
        'colPL_OTH_IN
        '
        Me.colPL_OTH_IN.Caption = "Total Other Income"
        Me.colPL_OTH_IN.FieldName = "PL_OTH_IN"
        Me.colPL_OTH_IN.Name = "colPL_OTH_IN"
        Me.colPL_OTH_IN.Visible = True
        Me.colPL_OTH_IN.VisibleIndex = 7
        Me.colPL_OTH_IN.Width = 100
        '
        'colPL_NONTAX_IN
        '
        Me.colPL_NONTAX_IN.Caption = "Total Non Taxable Income"
        Me.colPL_NONTAX_IN.FieldName = "PL_NONTAX_IN"
        Me.colPL_NONTAX_IN.Name = "colPL_NONTAX_IN"
        Me.colPL_NONTAX_IN.Visible = True
        Me.colPL_NONTAX_IN.VisibleIndex = 8
        Me.colPL_NONTAX_IN.Width = 100
        '
        'colPL_TOT_EXP
        '
        Me.colPL_TOT_EXP.Caption = "Total Expenses"
        Me.colPL_TOT_EXP.FieldName = "PL_TOT_EXP"
        Me.colPL_TOT_EXP.Name = "colPL_TOT_EXP"
        Me.colPL_TOT_EXP.Visible = True
        Me.colPL_TOT_EXP.VisibleIndex = 9
        Me.colPL_TOT_EXP.Width = 100
        '
        'colPL_NET_PROFIT_LOSS
        '
        Me.colPL_NET_PROFIT_LOSS.Caption = "Net Profit or Loss"
        Me.colPL_NET_PROFIT_LOSS.FieldName = "PL_NET_PROFIT_LOSS"
        Me.colPL_NET_PROFIT_LOSS.Name = "colPL_NET_PROFIT_LOSS"
        Me.colPL_NET_PROFIT_LOSS.Visible = True
        Me.colPL_NET_PROFIT_LOSS.VisibleIndex = 10
        Me.colPL_NET_PROFIT_LOSS.Width = 100
        '
        'colPL_DISALLOWED_EXP
        '
        Me.colPL_DISALLOWED_EXP.Caption = "Non Allowable Expenses"
        Me.colPL_DISALLOWED_EXP.FieldName = "PL_DISALLOWED_EXP"
        Me.colPL_DISALLOWED_EXP.Name = "colPL_DISALLOWED_EXP"
        Me.colPL_DISALLOWED_EXP.Visible = True
        Me.colPL_DISALLOWED_EXP.VisibleIndex = 11
        Me.colPL_DISALLOWED_EXP.Width = 100
        '
        'colPL_S60F
        '
        Me.colPL_S60F.Caption = "S60"
        Me.colPL_S60F.FieldName = "PL_S60F"
        Me.colPL_S60F.Name = "colPL_S60F"
        Me.colPL_S60F.Visible = True
        Me.colPL_S60F.VisibleIndex = 12
        Me.colPL_S60F.Width = 100
        '
        'colPL_S60FA
        '
        Me.colPL_S60FA.Caption = "SF60A"
        Me.colPL_S60FA.FieldName = "PL_S60FA"
        Me.colPL_S60FA.Name = "colPL_S60FA"
        Me.colPL_S60FA.Visible = True
        Me.colPL_S60FA.VisibleIndex = 13
        Me.colPL_S60FA.Width = 100
        '
        'colModifiedBy
        '
        Me.colModifiedBy.Caption = "Modified By"
        Me.colModifiedBy.FieldName = "ModifiedBy"
        Me.colModifiedBy.Name = "colModifiedBy"
        Me.colModifiedBy.Visible = True
        Me.colModifiedBy.VisibleIndex = 14
        Me.colModifiedBy.Width = 200
        '
        'colModifiedDateTime
        '
        Me.colModifiedDateTime.Caption = "Last Modified"
        Me.colModifiedDateTime.FieldName = "ModifiedDateTime"
        Me.colModifiedDateTime.Name = "colModifiedDateTime"
        Me.colModifiedDateTime.Visible = True
        Me.colModifiedDateTime.VisibleIndex = 15
        Me.colModifiedDateTime.Width = 180
        '
        'cboYA
        '
        Me.cboYA.Location = New System.Drawing.Point(449, 14)
        Me.cboYA.Name = "cboYA"
        Me.cboYA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboYA.Properties.PopupSizeable = True
        Me.cboYA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboYA.Size = New System.Drawing.Size(226, 20)
        Me.cboYA.TabIndex = 10
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
        Me.PanelControl1.Location = New System.Drawing.Point(0, 31)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(948, 75)
        Me.PanelControl1.TabIndex = 10
        '
        'cboRefNo
        '
        Me.cboRefNo.Location = New System.Drawing.Point(91, 14)
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
        Me.cboRefNo.TabIndex = 161
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
        CType(Me.PROFITLOSSACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPNL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents dgvView As DevExpress.XtraGrid.GridControl
    Friend WithEvents PROFITLOSSACCOUNTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsPNL As EasyTemplate_Taxcom.dsPNL
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPL_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPNLStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_REF_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_YA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_MAINBUZ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_GROSS_PROFIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_OTH_BSIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_OTH_IN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NONTAX_IN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_TOT_EXP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_NET_PROFIT_LOSS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_DISALLOWED_EXP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_S60F As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPL_S60FA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cboYA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TaxPayerFindBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsCA As EasyTemplate_Taxcom.dsCA
    Friend WithEvents btnAllRecord As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyReferenceNoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyYAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrintAdmin As DevExpress.XtraBars.BarButtonItem

End Class
