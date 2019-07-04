<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTaxPayerInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucTaxPayerInformation))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnAllRecord = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.cboRefNo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.TaxPayerFindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDefault = New EasyTemplate_Taxcom.dsDefault()
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRefNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployerNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.TAXPPROFILEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTP_REF_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_COM_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_ROC_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_EMPLOYER_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_FILE_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_RESIDENCE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_COUNTRY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_ACC_PERIOD_FR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_ACC_PERIOD_TO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_EFILING = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_PUBLIC_ORDER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_CO_STATUS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_EMAIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_REG_ADD_LINE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_REG_ADD_LINE2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_REG_ADD_LINE3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_REG_POSTCODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_REG_CITY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_REG_STATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_CURR_ADD_LINE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_CURR_ADD_LINE2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_CURR_ADD_LINE3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_CURR_POSTCODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_CURR_CITY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_CURR_STATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_COM_ADD_LINE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_COM_ADD_LINE2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_COM_ADD_LINE3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_COM_POSTCODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_COM_CITY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_COM_STATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_BANK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_BANK_ACC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_BANK_ADD_LINE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_BANK_ADD_LINE2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_BANK_ADD_LINE3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_BANK_POSTCODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_BANK_CITY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_BANK_STATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_RECORD_KEPT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_ALT_ADD_LINE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_ALT_ADD_LINE2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_ALT_ADD_LINE3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_ALT_POSTCODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_ALT_CITY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_ALT_STATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_TAX_FILE_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_CONTACT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_TEL_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_FAX_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_INV_ANN_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_INV_DETTAXFEE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_INV_DISBURSEMENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_INV_SALESTAX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_INV_TOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_PREFIX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_BLOG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_BASIS_PERIOD_FR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_BASIS_PERIOD_TO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_OPN_OPERATION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_ULT_COMPANY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_ULT_COUNTRY_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_IMD_COMPANY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_IMD_COUNTRY_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_REG_COUNTRY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_CURR_COUNTRY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_COM_COUNTRY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_ALT_COUNTRY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_COM_STS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_SECTION_127_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_SECTION_127_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_SECTION_127_3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_ROYALCLAIM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_CARRYETRANDING = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_GOODSERVICETAXREGISTRAION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_LABUAN_STATUS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_LABUAN_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_LABUAN_REG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_LABUAN_INCOME_TAX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_BUILDINGINDUSTRY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTP_STS_OTHER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHandleBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pnlLoading = New DevExpress.XtraWaitForm.ProgressPanel()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXPPROFILEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(904, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 480)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(904, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 449)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(904, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 449)
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnAllRecord)
        Me.PanelControl1.Controls.Add(Me.btnFind)
        Me.PanelControl1.Controls.Add(Me.cboRefNo)
        Me.PanelControl1.Controls.Add(Me.btnClear)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 31)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(904, 47)
        Me.PanelControl1.TabIndex = 4
        '
        'btnAllRecord
        '
        Me.btnAllRecord.ImageOptions.Image = CType(resources.GetObject("btnAllRecord.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAllRecord.Location = New System.Drawing.Point(436, 13)
        Me.btnAllRecord.Name = "btnAllRecord"
        Me.btnAllRecord.Size = New System.Drawing.Size(110, 23)
        Me.btnAllRecord.TabIndex = 165
        Me.btnAllRecord.Text = "All Record"
        '
        'btnFind
        '
        Me.btnFind.ImageOptions.Image = CType(resources.GetObject("btnFind.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFind.Location = New System.Drawing.Point(552, 13)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(110, 23)
        Me.btnFind.TabIndex = 164
        Me.btnFind.Text = "Find"
        '
        'cboRefNo
        '
        Me.cboRefNo.Location = New System.Drawing.Point(106, 15)
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
        Me.cboRefNo.TabIndex = 163
        '
        'TaxPayerFindBindingSource
        '
        Me.TaxPayerFindBindingSource.DataMember = "TaxPayerFind"
        Me.TaxPayerFindBindingSource.DataSource = Me.DsDefault
        '
        'DsDefault
        '
        Me.DsDefault.DataSetName = "dsDefault"
        Me.DsDefault.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SearchLookUpEdit2View
        '
        Me.SearchLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRefNo, Me.colCompanyName, Me.GridColumn1, Me.colCompanyNo, Me.colEmployerNo, Me.colFileNo, Me.colCountry, Me.colCompanyCode})
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
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "HandleBy"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 150
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
        'btnClear
        '
        Me.btnClear.ImageOptions.Image = CType(resources.GetObject("btnClear.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClear.Location = New System.Drawing.Point(380, 13)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(24, 23)
        Me.btnClear.TabIndex = 162
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(10, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl1.TabIndex = 161
        Me.LabelControl1.Text = "Reference No :"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.TAXPPROFILEBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 78)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(904, 402)
        Me.GridControl1.TabIndex = 5
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'TAXPPROFILEBindingSource
        '
        Me.TAXPPROFILEBindingSource.DataMember = "TAXP_PROFILE"
        Me.TAXPPROFILEBindingSource.DataSource = Me.DsDefault
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTP_REF_NO, Me.colTP_COM_NAME, Me.colTP_ROC_NO, Me.colTP_EMPLOYER_NO, Me.colTP_FILE_NO, Me.colTP_RESIDENCE, Me.colTP_COUNTRY, Me.colTP_ACC_PERIOD_FR, Me.colTP_ACC_PERIOD_TO, Me.colTP_EFILING, Me.colTP_PUBLIC_ORDER, Me.colTP_CO_STATUS, Me.colTP_EMAIL, Me.colTP_REG_ADD_LINE1, Me.colTP_REG_ADD_LINE2, Me.colTP_REG_ADD_LINE3, Me.colTP_REG_POSTCODE, Me.colTP_REG_CITY, Me.colTP_REG_STATE, Me.colTP_CURR_ADD_LINE1, Me.colTP_CURR_ADD_LINE2, Me.colTP_CURR_ADD_LINE3, Me.colTP_CURR_POSTCODE, Me.colTP_CURR_CITY, Me.colTP_CURR_STATE, Me.colTP_COM_ADD_LINE1, Me.colTP_COM_ADD_LINE2, Me.colTP_COM_ADD_LINE3, Me.colTP_COM_POSTCODE, Me.colTP_COM_CITY, Me.colTP_COM_STATE, Me.colTP_BANK, Me.colTP_BANK_ACC, Me.colTP_BANK_ADD_LINE1, Me.colTP_BANK_ADD_LINE2, Me.colTP_BANK_ADD_LINE3, Me.colTP_BANK_POSTCODE, Me.colTP_BANK_CITY, Me.colTP_BANK_STATE, Me.colTP_RECORD_KEPT, Me.colTP_ALT_ADD_LINE1, Me.colTP_ALT_ADD_LINE2, Me.colTP_ALT_ADD_LINE3, Me.colTP_ALT_POSTCODE, Me.colTP_ALT_CITY, Me.colTP_ALT_STATE, Me.colTP_TAX_FILE_NO, Me.colTP_CONTACT, Me.colTP_TEL_NO, Me.colTP_FAX_NO, Me.colTP_INV_ANN_DATE, Me.colTP_INV_DETTAXFEE, Me.colTP_INV_DISBURSEMENT, Me.colTP_INV_SALESTAX, Me.colTP_INV_TOTAL, Me.colTP_PREFIX, Me.colTP_BLOG, Me.colTP_BASIS_PERIOD_FR, Me.colTP_BASIS_PERIOD_TO, Me.colTP_OPN_OPERATION, Me.colTP_ULT_COMPANY, Me.colTP_ULT_COUNTRY_CODE, Me.colTP_IMD_COMPANY, Me.colTP_IMD_COUNTRY_CODE, Me.colTP_REG_COUNTRY, Me.colTP_CURR_COUNTRY, Me.colTP_COM_COUNTRY, Me.colTP_ALT_COUNTRY, Me.colTP_COM_STS, Me.colTP_SECTION_127_1, Me.colTP_SECTION_127_2, Me.colTP_SECTION_127_3, Me.colTP_ROYALCLAIM, Me.colTP_CARRYETRANDING, Me.colTP_GOODSERVICETAXREGISTRAION, Me.colTP_LABUAN_STATUS, Me.colTP_LABUAN_NAME, Me.colTP_LABUAN_REG, Me.colTP_LABUAN_INCOME_TAX, Me.colTP_BUILDINGINDUSTRY, Me.colTP_STS_OTHER, Me.colHandleBy})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'colTP_REF_NO
        '
        Me.colTP_REF_NO.Caption = "Ref No"
        Me.colTP_REF_NO.FieldName = "TP_REF_NO"
        Me.colTP_REF_NO.Name = "colTP_REF_NO"
        Me.colTP_REF_NO.Visible = True
        Me.colTP_REF_NO.VisibleIndex = 0
        Me.colTP_REF_NO.Width = 100
        '
        'colTP_COM_NAME
        '
        Me.colTP_COM_NAME.Caption = "Company Name"
        Me.colTP_COM_NAME.FieldName = "TP_COM_NAME"
        Me.colTP_COM_NAME.Name = "colTP_COM_NAME"
        Me.colTP_COM_NAME.Visible = True
        Me.colTP_COM_NAME.VisibleIndex = 1
        Me.colTP_COM_NAME.Width = 250
        '
        'colTP_ROC_NO
        '
        Me.colTP_ROC_NO.Caption = "Registration No"
        Me.colTP_ROC_NO.FieldName = "TP_ROC_NO"
        Me.colTP_ROC_NO.Name = "colTP_ROC_NO"
        Me.colTP_ROC_NO.Visible = True
        Me.colTP_ROC_NO.VisibleIndex = 2
        Me.colTP_ROC_NO.Width = 150
        '
        'colTP_EMPLOYER_NO
        '
        Me.colTP_EMPLOYER_NO.Caption = "Employee No"
        Me.colTP_EMPLOYER_NO.FieldName = "TP_EMPLOYER_NO"
        Me.colTP_EMPLOYER_NO.Name = "colTP_EMPLOYER_NO"
        Me.colTP_EMPLOYER_NO.Visible = True
        Me.colTP_EMPLOYER_NO.VisibleIndex = 3
        Me.colTP_EMPLOYER_NO.Width = 100
        '
        'colTP_FILE_NO
        '
        Me.colTP_FILE_NO.FieldName = "TP_FILE_NO"
        Me.colTP_FILE_NO.Name = "colTP_FILE_NO"
        Me.colTP_FILE_NO.Width = 100
        '
        'colTP_RESIDENCE
        '
        Me.colTP_RESIDENCE.Caption = "Re"
        Me.colTP_RESIDENCE.FieldName = "TP_RESIDENCE"
        Me.colTP_RESIDENCE.Name = "colTP_RESIDENCE"
        Me.colTP_RESIDENCE.Width = 100
        '
        'colTP_COUNTRY
        '
        Me.colTP_COUNTRY.Caption = "Country"
        Me.colTP_COUNTRY.FieldName = "TP_COUNTRY"
        Me.colTP_COUNTRY.Name = "colTP_COUNTRY"
        Me.colTP_COUNTRY.Visible = True
        Me.colTP_COUNTRY.VisibleIndex = 4
        Me.colTP_COUNTRY.Width = 100
        '
        'colTP_ACC_PERIOD_FR
        '
        Me.colTP_ACC_PERIOD_FR.Caption = "Accounting Period From"
        Me.colTP_ACC_PERIOD_FR.FieldName = "TP_ACC_PERIOD_FR"
        Me.colTP_ACC_PERIOD_FR.Name = "colTP_ACC_PERIOD_FR"
        Me.colTP_ACC_PERIOD_FR.Visible = True
        Me.colTP_ACC_PERIOD_FR.VisibleIndex = 5
        Me.colTP_ACC_PERIOD_FR.Width = 100
        '
        'colTP_ACC_PERIOD_TO
        '
        Me.colTP_ACC_PERIOD_TO.Caption = "Accounting Period To"
        Me.colTP_ACC_PERIOD_TO.FieldName = "TP_ACC_PERIOD_TO"
        Me.colTP_ACC_PERIOD_TO.Name = "colTP_ACC_PERIOD_TO"
        Me.colTP_ACC_PERIOD_TO.Visible = True
        Me.colTP_ACC_PERIOD_TO.VisibleIndex = 6
        Me.colTP_ACC_PERIOD_TO.Width = 100
        '
        'colTP_EFILING
        '
        Me.colTP_EFILING.FieldName = "TP_EFILING"
        Me.colTP_EFILING.Name = "colTP_EFILING"
        '
        'colTP_PUBLIC_ORDER
        '
        Me.colTP_PUBLIC_ORDER.FieldName = "TP_PUBLIC_ORDER"
        Me.colTP_PUBLIC_ORDER.Name = "colTP_PUBLIC_ORDER"
        '
        'colTP_CO_STATUS
        '
        Me.colTP_CO_STATUS.FieldName = "TP_CO_STATUS"
        Me.colTP_CO_STATUS.Name = "colTP_CO_STATUS"
        '
        'colTP_EMAIL
        '
        Me.colTP_EMAIL.Caption = "Email"
        Me.colTP_EMAIL.FieldName = "TP_EMAIL"
        Me.colTP_EMAIL.Name = "colTP_EMAIL"
        Me.colTP_EMAIL.Visible = True
        Me.colTP_EMAIL.VisibleIndex = 7
        Me.colTP_EMAIL.Width = 250
        '
        'colTP_REG_ADD_LINE1
        '
        Me.colTP_REG_ADD_LINE1.FieldName = "TP_REG_ADD_LINE1"
        Me.colTP_REG_ADD_LINE1.Name = "colTP_REG_ADD_LINE1"
        '
        'colTP_REG_ADD_LINE2
        '
        Me.colTP_REG_ADD_LINE2.FieldName = "TP_REG_ADD_LINE2"
        Me.colTP_REG_ADD_LINE2.Name = "colTP_REG_ADD_LINE2"
        '
        'colTP_REG_ADD_LINE3
        '
        Me.colTP_REG_ADD_LINE3.FieldName = "TP_REG_ADD_LINE3"
        Me.colTP_REG_ADD_LINE3.Name = "colTP_REG_ADD_LINE3"
        '
        'colTP_REG_POSTCODE
        '
        Me.colTP_REG_POSTCODE.FieldName = "TP_REG_POSTCODE"
        Me.colTP_REG_POSTCODE.Name = "colTP_REG_POSTCODE"
        '
        'colTP_REG_CITY
        '
        Me.colTP_REG_CITY.FieldName = "TP_REG_CITY"
        Me.colTP_REG_CITY.Name = "colTP_REG_CITY"
        '
        'colTP_REG_STATE
        '
        Me.colTP_REG_STATE.FieldName = "TP_REG_STATE"
        Me.colTP_REG_STATE.Name = "colTP_REG_STATE"
        '
        'colTP_CURR_ADD_LINE1
        '
        Me.colTP_CURR_ADD_LINE1.Caption = "Address"
        Me.colTP_CURR_ADD_LINE1.FieldName = "TP_CURR_ADD_LINE1"
        Me.colTP_CURR_ADD_LINE1.Name = "colTP_CURR_ADD_LINE1"
        Me.colTP_CURR_ADD_LINE1.Visible = True
        Me.colTP_CURR_ADD_LINE1.VisibleIndex = 8
        Me.colTP_CURR_ADD_LINE1.Width = 150
        '
        'colTP_CURR_ADD_LINE2
        '
        Me.colTP_CURR_ADD_LINE2.Caption = "Address"
        Me.colTP_CURR_ADD_LINE2.FieldName = "TP_CURR_ADD_LINE2"
        Me.colTP_CURR_ADD_LINE2.Name = "colTP_CURR_ADD_LINE2"
        Me.colTP_CURR_ADD_LINE2.Visible = True
        Me.colTP_CURR_ADD_LINE2.VisibleIndex = 9
        Me.colTP_CURR_ADD_LINE2.Width = 150
        '
        'colTP_CURR_ADD_LINE3
        '
        Me.colTP_CURR_ADD_LINE3.Caption = "Address"
        Me.colTP_CURR_ADD_LINE3.FieldName = "TP_CURR_ADD_LINE3"
        Me.colTP_CURR_ADD_LINE3.Name = "colTP_CURR_ADD_LINE3"
        Me.colTP_CURR_ADD_LINE3.Visible = True
        Me.colTP_CURR_ADD_LINE3.VisibleIndex = 10
        Me.colTP_CURR_ADD_LINE3.Width = 150
        '
        'colTP_CURR_POSTCODE
        '
        Me.colTP_CURR_POSTCODE.Caption = "Postcode"
        Me.colTP_CURR_POSTCODE.FieldName = "TP_CURR_POSTCODE"
        Me.colTP_CURR_POSTCODE.Name = "colTP_CURR_POSTCODE"
        Me.colTP_CURR_POSTCODE.Visible = True
        Me.colTP_CURR_POSTCODE.VisibleIndex = 11
        Me.colTP_CURR_POSTCODE.Width = 100
        '
        'colTP_CURR_CITY
        '
        Me.colTP_CURR_CITY.Caption = "City"
        Me.colTP_CURR_CITY.FieldName = "TP_CURR_CITY"
        Me.colTP_CURR_CITY.Name = "colTP_CURR_CITY"
        Me.colTP_CURR_CITY.Visible = True
        Me.colTP_CURR_CITY.VisibleIndex = 12
        Me.colTP_CURR_CITY.Width = 100
        '
        'colTP_CURR_STATE
        '
        Me.colTP_CURR_STATE.Caption = "State"
        Me.colTP_CURR_STATE.FieldName = "TP_CURR_STATE"
        Me.colTP_CURR_STATE.Name = "colTP_CURR_STATE"
        Me.colTP_CURR_STATE.Visible = True
        Me.colTP_CURR_STATE.VisibleIndex = 13
        Me.colTP_CURR_STATE.Width = 100
        '
        'colTP_COM_ADD_LINE1
        '
        Me.colTP_COM_ADD_LINE1.FieldName = "TP_COM_ADD_LINE1"
        Me.colTP_COM_ADD_LINE1.Name = "colTP_COM_ADD_LINE1"
        '
        'colTP_COM_ADD_LINE2
        '
        Me.colTP_COM_ADD_LINE2.FieldName = "TP_COM_ADD_LINE2"
        Me.colTP_COM_ADD_LINE2.Name = "colTP_COM_ADD_LINE2"
        '
        'colTP_COM_ADD_LINE3
        '
        Me.colTP_COM_ADD_LINE3.FieldName = "TP_COM_ADD_LINE3"
        Me.colTP_COM_ADD_LINE3.Name = "colTP_COM_ADD_LINE3"
        '
        'colTP_COM_POSTCODE
        '
        Me.colTP_COM_POSTCODE.FieldName = "TP_COM_POSTCODE"
        Me.colTP_COM_POSTCODE.Name = "colTP_COM_POSTCODE"
        '
        'colTP_COM_CITY
        '
        Me.colTP_COM_CITY.FieldName = "TP_COM_CITY"
        Me.colTP_COM_CITY.Name = "colTP_COM_CITY"
        '
        'colTP_COM_STATE
        '
        Me.colTP_COM_STATE.FieldName = "TP_COM_STATE"
        Me.colTP_COM_STATE.Name = "colTP_COM_STATE"
        '
        'colTP_BANK
        '
        Me.colTP_BANK.FieldName = "TP_BANK"
        Me.colTP_BANK.Name = "colTP_BANK"
        '
        'colTP_BANK_ACC
        '
        Me.colTP_BANK_ACC.FieldName = "TP_BANK_ACC"
        Me.colTP_BANK_ACC.Name = "colTP_BANK_ACC"
        '
        'colTP_BANK_ADD_LINE1
        '
        Me.colTP_BANK_ADD_LINE1.FieldName = "TP_BANK_ADD_LINE1"
        Me.colTP_BANK_ADD_LINE1.Name = "colTP_BANK_ADD_LINE1"
        '
        'colTP_BANK_ADD_LINE2
        '
        Me.colTP_BANK_ADD_LINE2.FieldName = "TP_BANK_ADD_LINE2"
        Me.colTP_BANK_ADD_LINE2.Name = "colTP_BANK_ADD_LINE2"
        '
        'colTP_BANK_ADD_LINE3
        '
        Me.colTP_BANK_ADD_LINE3.FieldName = "TP_BANK_ADD_LINE3"
        Me.colTP_BANK_ADD_LINE3.Name = "colTP_BANK_ADD_LINE3"
        '
        'colTP_BANK_POSTCODE
        '
        Me.colTP_BANK_POSTCODE.FieldName = "TP_BANK_POSTCODE"
        Me.colTP_BANK_POSTCODE.Name = "colTP_BANK_POSTCODE"
        '
        'colTP_BANK_CITY
        '
        Me.colTP_BANK_CITY.FieldName = "TP_BANK_CITY"
        Me.colTP_BANK_CITY.Name = "colTP_BANK_CITY"
        '
        'colTP_BANK_STATE
        '
        Me.colTP_BANK_STATE.FieldName = "TP_BANK_STATE"
        Me.colTP_BANK_STATE.Name = "colTP_BANK_STATE"
        '
        'colTP_RECORD_KEPT
        '
        Me.colTP_RECORD_KEPT.FieldName = "TP_RECORD_KEPT"
        Me.colTP_RECORD_KEPT.Name = "colTP_RECORD_KEPT"
        '
        'colTP_ALT_ADD_LINE1
        '
        Me.colTP_ALT_ADD_LINE1.FieldName = "TP_ALT_ADD_LINE1"
        Me.colTP_ALT_ADD_LINE1.Name = "colTP_ALT_ADD_LINE1"
        '
        'colTP_ALT_ADD_LINE2
        '
        Me.colTP_ALT_ADD_LINE2.FieldName = "TP_ALT_ADD_LINE2"
        Me.colTP_ALT_ADD_LINE2.Name = "colTP_ALT_ADD_LINE2"
        '
        'colTP_ALT_ADD_LINE3
        '
        Me.colTP_ALT_ADD_LINE3.FieldName = "TP_ALT_ADD_LINE3"
        Me.colTP_ALT_ADD_LINE3.Name = "colTP_ALT_ADD_LINE3"
        '
        'colTP_ALT_POSTCODE
        '
        Me.colTP_ALT_POSTCODE.FieldName = "TP_ALT_POSTCODE"
        Me.colTP_ALT_POSTCODE.Name = "colTP_ALT_POSTCODE"
        '
        'colTP_ALT_CITY
        '
        Me.colTP_ALT_CITY.FieldName = "TP_ALT_CITY"
        Me.colTP_ALT_CITY.Name = "colTP_ALT_CITY"
        '
        'colTP_ALT_STATE
        '
        Me.colTP_ALT_STATE.FieldName = "TP_ALT_STATE"
        Me.colTP_ALT_STATE.Name = "colTP_ALT_STATE"
        '
        'colTP_TAX_FILE_NO
        '
        Me.colTP_TAX_FILE_NO.FieldName = "TP_TAX_FILE_NO"
        Me.colTP_TAX_FILE_NO.Name = "colTP_TAX_FILE_NO"
        Me.colTP_TAX_FILE_NO.Visible = True
        Me.colTP_TAX_FILE_NO.VisibleIndex = 14
        '
        'colTP_CONTACT
        '
        Me.colTP_CONTACT.Caption = "Contact Person"
        Me.colTP_CONTACT.FieldName = "TP_CONTACT"
        Me.colTP_CONTACT.Name = "colTP_CONTACT"
        Me.colTP_CONTACT.Visible = True
        Me.colTP_CONTACT.VisibleIndex = 15
        Me.colTP_CONTACT.Width = 150
        '
        'colTP_TEL_NO
        '
        Me.colTP_TEL_NO.Caption = "Tel No"
        Me.colTP_TEL_NO.FieldName = "TP_TEL_NO"
        Me.colTP_TEL_NO.Name = "colTP_TEL_NO"
        Me.colTP_TEL_NO.Visible = True
        Me.colTP_TEL_NO.VisibleIndex = 16
        Me.colTP_TEL_NO.Width = 150
        '
        'colTP_FAX_NO
        '
        Me.colTP_FAX_NO.FieldName = "TP_FAX_NO"
        Me.colTP_FAX_NO.Name = "colTP_FAX_NO"
        '
        'colTP_INV_ANN_DATE
        '
        Me.colTP_INV_ANN_DATE.FieldName = "TP_INV_ANN_DATE"
        Me.colTP_INV_ANN_DATE.Name = "colTP_INV_ANN_DATE"
        '
        'colTP_INV_DETTAXFEE
        '
        Me.colTP_INV_DETTAXFEE.FieldName = "TP_INV_DETTAXFEE"
        Me.colTP_INV_DETTAXFEE.Name = "colTP_INV_DETTAXFEE"
        '
        'colTP_INV_DISBURSEMENT
        '
        Me.colTP_INV_DISBURSEMENT.FieldName = "TP_INV_DISBURSEMENT"
        Me.colTP_INV_DISBURSEMENT.Name = "colTP_INV_DISBURSEMENT"
        '
        'colTP_INV_SALESTAX
        '
        Me.colTP_INV_SALESTAX.FieldName = "TP_INV_SALESTAX"
        Me.colTP_INV_SALESTAX.Name = "colTP_INV_SALESTAX"
        '
        'colTP_INV_TOTAL
        '
        Me.colTP_INV_TOTAL.FieldName = "TP_INV_TOTAL"
        Me.colTP_INV_TOTAL.Name = "colTP_INV_TOTAL"
        '
        'colTP_PREFIX
        '
        Me.colTP_PREFIX.FieldName = "TP_PREFIX"
        Me.colTP_PREFIX.Name = "colTP_PREFIX"
        '
        'colTP_BLOG
        '
        Me.colTP_BLOG.FieldName = "TP_BLOG"
        Me.colTP_BLOG.Name = "colTP_BLOG"
        '
        'colTP_BASIS_PERIOD_FR
        '
        Me.colTP_BASIS_PERIOD_FR.Caption = "Basis Period"
        Me.colTP_BASIS_PERIOD_FR.FieldName = "TP_BASIS_PERIOD_FR"
        Me.colTP_BASIS_PERIOD_FR.Name = "colTP_BASIS_PERIOD_FR"
        Me.colTP_BASIS_PERIOD_FR.Visible = True
        Me.colTP_BASIS_PERIOD_FR.VisibleIndex = 17
        '
        'colTP_BASIS_PERIOD_TO
        '
        Me.colTP_BASIS_PERIOD_TO.Caption = "Basis Period"
        Me.colTP_BASIS_PERIOD_TO.FieldName = "TP_BASIS_PERIOD_TO"
        Me.colTP_BASIS_PERIOD_TO.Name = "colTP_BASIS_PERIOD_TO"
        Me.colTP_BASIS_PERIOD_TO.Visible = True
        Me.colTP_BASIS_PERIOD_TO.VisibleIndex = 18
        '
        'colTP_OPN_OPERATION
        '
        Me.colTP_OPN_OPERATION.FieldName = "TP_OPN_OPERATION"
        Me.colTP_OPN_OPERATION.Name = "colTP_OPN_OPERATION"
        '
        'colTP_ULT_COMPANY
        '
        Me.colTP_ULT_COMPANY.FieldName = "TP_ULT_COMPANY"
        Me.colTP_ULT_COMPANY.Name = "colTP_ULT_COMPANY"
        '
        'colTP_ULT_COUNTRY_CODE
        '
        Me.colTP_ULT_COUNTRY_CODE.FieldName = "TP_ULT_COUNTRY_CODE"
        Me.colTP_ULT_COUNTRY_CODE.Name = "colTP_ULT_COUNTRY_CODE"
        '
        'colTP_IMD_COMPANY
        '
        Me.colTP_IMD_COMPANY.FieldName = "TP_IMD_COMPANY"
        Me.colTP_IMD_COMPANY.Name = "colTP_IMD_COMPANY"
        '
        'colTP_IMD_COUNTRY_CODE
        '
        Me.colTP_IMD_COUNTRY_CODE.FieldName = "TP_IMD_COUNTRY_CODE"
        Me.colTP_IMD_COUNTRY_CODE.Name = "colTP_IMD_COUNTRY_CODE"
        '
        'colTP_REG_COUNTRY
        '
        Me.colTP_REG_COUNTRY.FieldName = "TP_REG_COUNTRY"
        Me.colTP_REG_COUNTRY.Name = "colTP_REG_COUNTRY"
        '
        'colTP_CURR_COUNTRY
        '
        Me.colTP_CURR_COUNTRY.FieldName = "TP_CURR_COUNTRY"
        Me.colTP_CURR_COUNTRY.Name = "colTP_CURR_COUNTRY"
        '
        'colTP_COM_COUNTRY
        '
        Me.colTP_COM_COUNTRY.FieldName = "TP_COM_COUNTRY"
        Me.colTP_COM_COUNTRY.Name = "colTP_COM_COUNTRY"
        '
        'colTP_ALT_COUNTRY
        '
        Me.colTP_ALT_COUNTRY.FieldName = "TP_ALT_COUNTRY"
        Me.colTP_ALT_COUNTRY.Name = "colTP_ALT_COUNTRY"
        '
        'colTP_COM_STS
        '
        Me.colTP_COM_STS.FieldName = "TP_COM_STS"
        Me.colTP_COM_STS.Name = "colTP_COM_STS"
        '
        'colTP_SECTION_127_1
        '
        Me.colTP_SECTION_127_1.FieldName = "TP_SECTION_127_1"
        Me.colTP_SECTION_127_1.Name = "colTP_SECTION_127_1"
        '
        'colTP_SECTION_127_2
        '
        Me.colTP_SECTION_127_2.FieldName = "TP_SECTION_127_2"
        Me.colTP_SECTION_127_2.Name = "colTP_SECTION_127_2"
        '
        'colTP_SECTION_127_3
        '
        Me.colTP_SECTION_127_3.FieldName = "TP_SECTION_127_3"
        Me.colTP_SECTION_127_3.Name = "colTP_SECTION_127_3"
        '
        'colTP_ROYALCLAIM
        '
        Me.colTP_ROYALCLAIM.FieldName = "TP_ROYALCLAIM"
        Me.colTP_ROYALCLAIM.Name = "colTP_ROYALCLAIM"
        '
        'colTP_CARRYETRANDING
        '
        Me.colTP_CARRYETRANDING.FieldName = "TP_CARRYETRANDING"
        Me.colTP_CARRYETRANDING.Name = "colTP_CARRYETRANDING"
        '
        'colTP_GOODSERVICETAXREGISTRAION
        '
        Me.colTP_GOODSERVICETAXREGISTRAION.FieldName = "TP_GOODSERVICETAXREGISTRAION"
        Me.colTP_GOODSERVICETAXREGISTRAION.Name = "colTP_GOODSERVICETAXREGISTRAION"
        '
        'colTP_LABUAN_STATUS
        '
        Me.colTP_LABUAN_STATUS.FieldName = "TP_LABUAN_STATUS"
        Me.colTP_LABUAN_STATUS.Name = "colTP_LABUAN_STATUS"
        '
        'colTP_LABUAN_NAME
        '
        Me.colTP_LABUAN_NAME.FieldName = "TP_LABUAN_NAME"
        Me.colTP_LABUAN_NAME.Name = "colTP_LABUAN_NAME"
        '
        'colTP_LABUAN_REG
        '
        Me.colTP_LABUAN_REG.FieldName = "TP_LABUAN_REG"
        Me.colTP_LABUAN_REG.Name = "colTP_LABUAN_REG"
        '
        'colTP_LABUAN_INCOME_TAX
        '
        Me.colTP_LABUAN_INCOME_TAX.FieldName = "TP_LABUAN_INCOME_TAX"
        Me.colTP_LABUAN_INCOME_TAX.Name = "colTP_LABUAN_INCOME_TAX"
        '
        'colTP_BUILDINGINDUSTRY
        '
        Me.colTP_BUILDINGINDUSTRY.FieldName = "TP_BUILDINGINDUSTRY"
        Me.colTP_BUILDINGINDUSTRY.Name = "colTP_BUILDINGINDUSTRY"
        '
        'colTP_STS_OTHER
        '
        Me.colTP_STS_OTHER.FieldName = "TP_STS_OTHER"
        Me.colTP_STS_OTHER.Name = "colTP_STS_OTHER"
        '
        'colHandleBy
        '
        Me.colHandleBy.FieldName = "HandleBy"
        Me.colHandleBy.Name = "colHandleBy"
        Me.colHandleBy.Visible = True
        Me.colHandleBy.VisibleIndex = 19
        Me.colHandleBy.Width = 200
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
        Me.pnlLoading.Location = New System.Drawing.Point(329, 207)
        Me.pnlLoading.Name = "pnlLoading"
        Me.pnlLoading.Size = New System.Drawing.Size(246, 66)
        Me.pnlLoading.TabIndex = 10
        Me.pnlLoading.Text = "ProgressPanel1"
        Me.pnlLoading.Visible = False
        '
        'ucTaxPayerInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlLoading)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "ucTaxPayerInformation"
        Me.Size = New System.Drawing.Size(904, 480)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXPPROFILEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents TAXPPROFILEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsDefault As EasyTemplate_Taxcom.dsDefault
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTP_REF_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_COM_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_ROC_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_EMPLOYER_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_FILE_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_RESIDENCE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_COUNTRY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_ACC_PERIOD_FR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_ACC_PERIOD_TO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_EFILING As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_PUBLIC_ORDER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_CO_STATUS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_EMAIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_REG_ADD_LINE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_REG_ADD_LINE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_REG_ADD_LINE3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_REG_POSTCODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_REG_CITY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_REG_STATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_CURR_ADD_LINE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_CURR_ADD_LINE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_CURR_ADD_LINE3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_CURR_POSTCODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_CURR_CITY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_CURR_STATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_COM_ADD_LINE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_COM_ADD_LINE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_COM_ADD_LINE3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_COM_POSTCODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_COM_CITY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_COM_STATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_BANK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_BANK_ACC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_BANK_ADD_LINE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_BANK_ADD_LINE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_BANK_ADD_LINE3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_BANK_POSTCODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_BANK_CITY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_BANK_STATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_RECORD_KEPT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_ALT_ADD_LINE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_ALT_ADD_LINE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_ALT_ADD_LINE3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_ALT_POSTCODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_ALT_CITY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_ALT_STATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_TAX_FILE_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_CONTACT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_TEL_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_FAX_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_INV_ANN_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_INV_DETTAXFEE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_INV_DISBURSEMENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_INV_SALESTAX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_INV_TOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_PREFIX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_BLOG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_BASIS_PERIOD_FR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_BASIS_PERIOD_TO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_OPN_OPERATION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_ULT_COMPANY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_ULT_COUNTRY_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_IMD_COMPANY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_IMD_COUNTRY_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_REG_COUNTRY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_CURR_COUNTRY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_COM_COUNTRY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_ALT_COUNTRY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_COM_STS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_SECTION_127_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_SECTION_127_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_SECTION_127_3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_ROYALCLAIM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_CARRYETRANDING As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_GOODSERVICETAXREGISTRAION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_LABUAN_STATUS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_LABUAN_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_LABUAN_REG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_LABUAN_INCOME_TAX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_BUILDINGINDUSTRY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTP_STS_OTHER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHandleBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cboRefNo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRefNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployerNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAllRecord As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlLoading As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents TaxPayerFindBindingSource As System.Windows.Forms.BindingSource

End Class
