<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPNL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPNL))
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
        Me.dgvView = New DevExpress.XtraGrid.GridControl()
        Me.PROFITLOSSACCOUNTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPNL = New EasyTemplate_Taxcom.dsPNL()
        Me.pnlLoading = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnClear2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.txtRefNo = New DevExpress.XtraEditors.TextEdit()
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
        Me.cboYA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboRefNo = New DevExpress.XtraEditors.LookUpEdit()
        Me.TaxPayerFindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCA = New EasyTemplate_Taxcom.dsCA()
        Me.btnAllRecord = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROFITLOSSACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPNL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'dgvView
        '
        Me.dgvView.DataSource = Me.PROFITLOSSACCOUNTBindingSource
        Me.dgvView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvView.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvView.Location = New System.Drawing.Point(0, 129)
        Me.dgvView.MainView = Me.GridView1
        Me.dgvView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvView.Name = "dgvView"
        Me.dgvView.Size = New System.Drawing.Size(1071, 452)
        Me.dgvView.TabIndex = 8
        Me.dgvView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        'pnlLoading
        '
        Me.pnlLoading.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlLoading.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pnlLoading.Appearance.Options.UseBackColor = True
        Me.pnlLoading.AppearanceCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.pnlLoading.AppearanceCaption.Options.UseFont = True
        Me.pnlLoading.AppearanceDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.pnlLoading.AppearanceDescription.Options.UseFont = True
        Me.pnlLoading.Location = New System.Drawing.Point(405, 273)
        Me.pnlLoading.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlLoading.Name = "pnlLoading"
        Me.pnlLoading.Size = New System.Drawing.Size(287, 81)
        Me.pnlLoading.TabIndex = 9
        Me.pnlLoading.Text = "ProgressPanel1"
        Me.pnlLoading.Visible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnClear2)
        Me.PanelControl1.Controls.Add(Me.btnClear)
        Me.PanelControl1.Controls.Add(Me.txtRefNo)
        Me.PanelControl1.Controls.Add(Me.cboYA)
        Me.PanelControl1.Controls.Add(Me.cboRefNo)
        Me.PanelControl1.Controls.Add(Me.btnAllRecord)
        Me.PanelControl1.Controls.Add(Me.btnFind)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 37)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1071, 92)
        Me.PanelControl1.TabIndex = 7
        '
        'btnClear2
        '
        Me.btnClear2.Image = CType(resources.GetObject("btnClear2.Image"), System.Drawing.Image)
        Me.btnClear2.Location = New System.Drawing.Point(794, 16)
        Me.btnClear2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear2.Name = "btnClear2"
        Me.btnClear2.Size = New System.Drawing.Size(28, 28)
        Me.btnClear2.TabIndex = 13
        '
        'btnClear
        '
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
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
        'btnImportExport
        '
        Me.btnImportExport.Caption = "Import / Export"
        Me.btnImportExport.Glyph = CType(resources.GetObject("btnImportExport.Glyph"), System.Drawing.Image)
        Me.btnImportExport.Id = 4
        Me.btnImportExport.LargeGlyph = CType(resources.GetObject("btnImportExport.LargeGlyph"), System.Drawing.Image)
        Me.btnImportExport.Name = "btnImportExport"
        Me.btnImportExport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1071, 37)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 581)
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1071, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 37)
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 544)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1071, 37)
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 544)
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
        'cboRefNo
        '
        Me.cboRefNo.Location = New System.Drawing.Point(106, 18)
        Me.cboRefNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboRefNo.Name = "cboRefNo"
        Me.cboRefNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRefNo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RefNo", "Ref No", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Company Name", 85, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyNo", "Company No", 71, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployerNo", "Employer No", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FileNo", "File No", 42, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Country", "Country", 49, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyCode", "Company Code", 83, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboRefNo.Properties.DataSource = Me.TaxPayerFindBindingSource
        Me.cboRefNo.Properties.DisplayMember = "CompanyName"
        Me.cboRefNo.Properties.PopupFormMinSize = New System.Drawing.Size(450, 0)
        Me.cboRefNo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cboRefNo.Properties.ValueMember = "RefNo"
        Me.cboRefNo.Size = New System.Drawing.Size(313, 22)
        Me.cboRefNo.TabIndex = 9
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
        Me.btnAllRecord.Image = CType(resources.GetObject("btnAllRecord.Image"), System.Drawing.Image)
        Me.btnAllRecord.Location = New System.Drawing.Point(524, 47)
        Me.btnAllRecord.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAllRecord.Name = "btnAllRecord"
        Me.btnAllRecord.Size = New System.Drawing.Size(128, 28)
        Me.btnAllRecord.TabIndex = 8
        Me.btnAllRecord.Text = "All Record"
        '
        'btnFind
        '
        Me.btnFind.Image = CType(resources.GetObject("btnFind.Image"), System.Drawing.Image)
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
        'frmPNL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 581)
        Me.Controls.Add(Me.pnlLoading)
        Me.Controls.Add(Me.dgvView)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmPNL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profit And Loss"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROFITLOSSACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPNL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgvView As DevExpress.XtraGrid.GridControl
    Friend WithEvents pnlLoading As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnAllRecord As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PROFITLOSSACCOUNTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsPNL As EasyTemplate_Taxcom.dsPNL
    Friend WithEvents colPL_KEY As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents cboRefNo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TaxPayerFindBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsCA As EasyTemplate_Taxcom.dsCA
    Friend WithEvents cboYA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtRefNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colPNLStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnClear2 As DevExpress.XtraEditors.SimpleButton
End Class
