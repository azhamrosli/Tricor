<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTableofContent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucTableofContent))
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
        Me.TABLECONTENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsReport_Templatexsd = New EasyTemplate_Taxcom.dsReport_Templatexsd()
        Me.dgvCA = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTBL_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTBL_REFNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTBL_COMPANYNAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTBL_YA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.cboRefNo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.TaxPayerFindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDefault = New EasyTemplate_Taxcom.dsDefault()
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRefNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHandleBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployerNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pnlLoading = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.cboYA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnAllRecord = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRefNo = New DevExpress.XtraEditors.TextEdit()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.dgvDisposal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TABLECONTENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsReport_Templatexsd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgvView.DataSource = Me.TABLECONTENTBindingSource
        Me.dgvView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvView.Location = New System.Drawing.Point(0, 108)
        Me.dgvView.MainView = Me.dgvCA
        Me.dgvView.Name = "dgvView"
        Me.dgvView.Size = New System.Drawing.Size(897, 377)
        Me.dgvView.TabIndex = 17
        Me.dgvView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvCA, Me.dgvDisposal})
        '
        'TABLECONTENTBindingSource
        '
        Me.TABLECONTENTBindingSource.DataMember = "TABLE_CONTENT"
        Me.TABLECONTENTBindingSource.DataSource = Me.DsReport_Templatexsd
        '
        'DsReport_Templatexsd
        '
        Me.DsReport_Templatexsd.DataSetName = "dsReport_Templatexsd"
        Me.DsReport_Templatexsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvCA
        '
        Me.dgvCA.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTBL_ID, Me.colTBL_REFNO, Me.colTBL_COMPANYNAME, Me.colTBL_YA, Me.colModifiedBy, Me.colModifiedDateTime})
        Me.dgvCA.GridControl = Me.dgvView
        Me.dgvCA.Name = "dgvCA"
        Me.dgvCA.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.dgvCA.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.dgvCA.OptionsBehavior.Editable = False
        Me.dgvCA.OptionsSelection.MultiSelect = True
        '
        'colTBL_ID
        '
        Me.colTBL_ID.FieldName = "TBL_ID"
        Me.colTBL_ID.Name = "colTBL_ID"
        '
        'colTBL_REFNO
        '
        Me.colTBL_REFNO.Caption = "Reference No"
        Me.colTBL_REFNO.FieldName = "TBL_REFNO"
        Me.colTBL_REFNO.Name = "colTBL_REFNO"
        Me.colTBL_REFNO.Visible = True
        Me.colTBL_REFNO.VisibleIndex = 0
        '
        'colTBL_COMPANYNAME
        '
        Me.colTBL_COMPANYNAME.Caption = "Name"
        Me.colTBL_COMPANYNAME.FieldName = "TBL_COMPANYNAME"
        Me.colTBL_COMPANYNAME.Name = "colTBL_COMPANYNAME"
        Me.colTBL_COMPANYNAME.Visible = True
        Me.colTBL_COMPANYNAME.VisibleIndex = 1
        '
        'colTBL_YA
        '
        Me.colTBL_YA.Caption = "YA"
        Me.colTBL_YA.FieldName = "TBL_YA"
        Me.colTBL_YA.Name = "colTBL_YA"
        Me.colTBL_YA.Visible = True
        Me.colTBL_YA.VisibleIndex = 2
        '
        'colModifiedBy
        '
        Me.colModifiedBy.FieldName = "ModifiedBy"
        Me.colModifiedBy.Name = "colModifiedBy"
        Me.colModifiedBy.Visible = True
        Me.colModifiedBy.VisibleIndex = 3
        '
        'colModifiedDateTime
        '
        Me.colModifiedDateTime.FieldName = "ModifiedDateTime"
        Me.colModifiedDateTime.Name = "colModifiedDateTime"
        Me.colModifiedDateTime.Visible = True
        Me.colModifiedDateTime.VisibleIndex = 4
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
        'btnEdit
        '
        Me.btnEdit.Caption = "Edit"
        Me.btnEdit.Id = 1
        Me.btnEdit.ImageOptions.Image = CType(resources.GetObject("btnEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEdit.ImageOptions.LargeImage = CType(resources.GetObject("btnEdit.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
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
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrint), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None
        Me.Bar1.OptionsBar.DisableClose = True
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "RA Report"
        Me.BarButtonItem1.Id = 8
        Me.BarButtonItem1.Name = "BarButtonItem1"
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnAdd, Me.btnEdit, Me.btnDelete, Me.btnPrint, Me.BarButtonItem1, Me.BarButtonItem2})
        Me.BarManager1.MaxItemId = 10
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(897, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 485)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(897, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 454)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(897, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 454)
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
        Me.pnlLoading.Location = New System.Drawing.Point(335, 261)
        Me.pnlLoading.Name = "pnlLoading"
        Me.pnlLoading.Size = New System.Drawing.Size(246, 66)
        Me.pnlLoading.TabIndex = 16
        Me.pnlLoading.Text = "ProgressPanel1"
        Me.pnlLoading.Visible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cboRefNo)
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Controls.Add(Me.btnClear)
        Me.PanelControl1.Controls.Add(Me.cboYA)
        Me.PanelControl1.Controls.Add(Me.btnAllRecord)
        Me.PanelControl1.Controls.Add(Me.btnFind)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtRefNo)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 31)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(897, 77)
        Me.PanelControl1.TabIndex = 15
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(804, 13)
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
        Me.cboYA.Location = New System.Drawing.Point(530, 15)
        Me.cboYA.Name = "cboYA"
        Me.cboYA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboYA.Properties.PopupSizeable = True
        Me.cboYA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboYA.Size = New System.Drawing.Size(268, 20)
        Me.cboYA.TabIndex = 11
        '
        'btnAllRecord
        '
        Me.btnAllRecord.ImageOptions.Image = CType(resources.GetObject("btnAllRecord.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAllRecord.Location = New System.Drawing.Point(572, 39)
        Me.btnAllRecord.Name = "btnAllRecord"
        Me.btnAllRecord.Size = New System.Drawing.Size(110, 23)
        Me.btnAllRecord.TabIndex = 8
        Me.btnAllRecord.Text = "All Record"
        '
        'btnFind
        '
        Me.btnFind.ImageOptions.Image = CType(resources.GetObject("btnFind.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFind.Location = New System.Drawing.Point(688, 39)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(110, 23)
        Me.btnFind.TabIndex = 7
        Me.btnFind.Text = "Find"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(434, 20)
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
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "ITA Report"
        Me.BarButtonItem2.Id = 9
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'ucTableofContent
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
        Me.Name = "ucTableofContent"
        Me.Size = New System.Drawing.Size(897, 485)
        CType(Me.dgvDisposal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TABLECONTENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsReport_Templatexsd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents pnlLoading As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
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
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboYA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnAllRecord As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents TABLECONTENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsReport_Templatexsd As EasyTemplate_Taxcom.dsReport_Templatexsd
    Friend WithEvents TaxPayerFindBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsDefault As EasyTemplate_Taxcom.dsDefault
    Friend WithEvents colTBL_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTBL_REFNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTBL_COMPANYNAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTBL_YA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem

End Class
