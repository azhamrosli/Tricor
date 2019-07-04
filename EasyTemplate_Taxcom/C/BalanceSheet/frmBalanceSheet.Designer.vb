<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBalanceSheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBalanceSheet))
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.lblModifiedBy = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
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
        Me.txtRefNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.cboYA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.txtOtherFA = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.chkSME = New DevExpress.XtraEditors.CheckEdit()
        Me.txtTotalLE = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotalEquity = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.txtReserves = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAppropriation = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPaidUp = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotalLiability = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLongTerm = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotalCL = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.txtOtherCL = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLoanFrom = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.txtOtherCreditor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTradeCreditor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.txtBorrowing = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotalAssets = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalCA = New DevExpress.XtraEditors.TextEdit()
        Me.txtOtherCA = New DevExpress.XtraEditors.TextEdit()
        Me.txtCashBank = New DevExpress.XtraEditors.TextEdit()
        Me.txtLoanTo = New DevExpress.XtraEditors.TextEdit()
        Me.txtStock = New DevExpress.XtraEditors.TextEdit()
        Me.txtOtherDebtors = New DevExpress.XtraEditors.TextEdit()
        Me.txtTradeDebtors = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txtInvestment = New DevExpress.XtraEditors.TextEdit()
        Me.txtCurYear = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalFA = New DevExpress.XtraEditors.TextEdit()
        Me.txtBuilding = New DevExpress.XtraEditors.TextEdit()
        Me.txtMachinery = New DevExpress.XtraEditors.TextEdit()
        Me.txtVehicle = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraScrollableControl1.SuspendLayout()
        CType(Me.txtOtherFA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSME.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalLE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalEquity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReserves.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAppropriation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPaidUp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalLiability.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLongTerm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOtherCL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLoanFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOtherCreditor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTradeCreditor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBorrowing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalAssets.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOtherCA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCashBank.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLoanTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOtherDebtors.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTradeDebtors.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvestment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalFA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuilding.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMachinery.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVehicle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None
        Me.Bar1.OptionsBar.DisableClose = True
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'BarManager1
        '
        Me.BarManager1.AllowQuickCustomization = False
        Me.BarManager1.AllowShowToolbarsPopup = False
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSave, Me.btnClose, Me.lblModifiedBy})
        Me.BarManager1.MaxItemId = 10
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemSpinEdit1})
        '
        'Bar2
        '
        Me.Bar2.BarName = "Tools"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSave), New DevExpress.XtraBars.LinkPersistInfo(Me.btnClose), New DevExpress.XtraBars.LinkPersistInfo(Me.lblModifiedBy)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None
        Me.Bar2.OptionsBar.DisableClose = True
        Me.Bar2.OptionsBar.DisableCustomization = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Tools"
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
        Me.btnClose.Id = 2
        Me.btnClose.ImageOptions.Image = CType(resources.GetObject("btnClose.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClose.ImageOptions.LargeImage = CType(resources.GetObject("btnClose.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'lblModifiedBy
        '
        Me.lblModifiedBy.Caption = "Last Update : AZHAM-LAPTOP (25/Jan/2018)"
        Me.lblModifiedBy.Id = 9
        Me.lblModifiedBy.Name = "lblModifiedBy"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1012, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 598)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1012, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 567)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1012, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 567)
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.Mask.EditMask = "n0"
        Me.RepositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        Me.RepositoryItemSpinEdit1.NullText = "1"
        Me.RepositoryItemSpinEdit1.NullValuePrompt = "1"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cboRefNo)
        Me.PanelControl1.Controls.Add(Me.txtRefNo)
        Me.PanelControl1.Controls.Add(Me.LabelControl11)
        Me.PanelControl1.Controls.Add(Me.cboYA)
        Me.PanelControl1.Controls.Add(Me.LabelControl10)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 31)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1012, 77)
        Me.PanelControl1.TabIndex = 5
        '
        'cboRefNo
        '
        Me.cboRefNo.Location = New System.Drawing.Point(113, 20)
        Me.cboRefNo.MenuManager = Me.BarManager1
        Me.cboRefNo.Name = "cboRefNo"
        Me.cboRefNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRefNo.Properties.DataSource = Me.TaxPayerFindBindingSource
        Me.cboRefNo.Properties.DisplayMember = "CompanyName"
        Me.cboRefNo.Properties.NullText = "Select"
        Me.cboRefNo.Properties.PopupFormMinSize = New System.Drawing.Size(600, 0)
        Me.cboRefNo.Properties.ValueMember = "RefNo"
        Me.cboRefNo.Properties.View = Me.SearchLookUpEdit2View
        Me.cboRefNo.Size = New System.Drawing.Size(262, 20)
        Me.cboRefNo.TabIndex = 170
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
        'txtRefNo
        '
        Me.txtRefNo.Location = New System.Drawing.Point(113, 46)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Properties.ReadOnly = True
        Me.txtRefNo.Size = New System.Drawing.Size(262, 20)
        Me.txtRefNo.TabIndex = 168
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(387, 23)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl11.TabIndex = 167
        Me.LabelControl11.Text = "YA :"
        '
        'cboYA
        '
        Me.cboYA.Location = New System.Drawing.Point(471, 20)
        Me.cboYA.Name = "cboYA"
        Me.cboYA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboYA.Properties.PopupSizeable = True
        Me.cboYA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboYA.Size = New System.Drawing.Size(280, 20)
        Me.cboYA.TabIndex = 165
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(10, 22)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl10.TabIndex = 166
        Me.LabelControl10.Text = "Ref No :"
        '
        'XtraScrollableControl1
        '
        Me.XtraScrollableControl1.Controls.Add(Me.txtOtherFA)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl35)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl34)
        Me.XtraScrollableControl1.Controls.Add(Me.chkSME)
        Me.XtraScrollableControl1.Controls.Add(Me.txtTotalLE)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl33)
        Me.XtraScrollableControl1.Controls.Add(Me.txtTotalEquity)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl32)
        Me.XtraScrollableControl1.Controls.Add(Me.txtReserves)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl31)
        Me.XtraScrollableControl1.Controls.Add(Me.txtAppropriation)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl30)
        Me.XtraScrollableControl1.Controls.Add(Me.txtPaidUp)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl29)
        Me.XtraScrollableControl1.Controls.Add(Me.txtTotalLiability)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl28)
        Me.XtraScrollableControl1.Controls.Add(Me.txtLongTerm)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl27)
        Me.XtraScrollableControl1.Controls.Add(Me.txtTotalCL)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl26)
        Me.XtraScrollableControl1.Controls.Add(Me.txtOtherCL)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl25)
        Me.XtraScrollableControl1.Controls.Add(Me.txtLoanFrom)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl24)
        Me.XtraScrollableControl1.Controls.Add(Me.txtOtherCreditor)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl23)
        Me.XtraScrollableControl1.Controls.Add(Me.txtTradeCreditor)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl22)
        Me.XtraScrollableControl1.Controls.Add(Me.txtBorrowing)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl21)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl20)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl19)
        Me.XtraScrollableControl1.Controls.Add(Me.txtTotalAssets)
        Me.XtraScrollableControl1.Controls.Add(Me.txtTotalCA)
        Me.XtraScrollableControl1.Controls.Add(Me.txtOtherCA)
        Me.XtraScrollableControl1.Controls.Add(Me.txtCashBank)
        Me.XtraScrollableControl1.Controls.Add(Me.txtLoanTo)
        Me.XtraScrollableControl1.Controls.Add(Me.txtStock)
        Me.XtraScrollableControl1.Controls.Add(Me.txtOtherDebtors)
        Me.XtraScrollableControl1.Controls.Add(Me.txtTradeDebtors)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl18)
        Me.XtraScrollableControl1.Controls.Add(Me.txtInvestment)
        Me.XtraScrollableControl1.Controls.Add(Me.txtCurYear)
        Me.XtraScrollableControl1.Controls.Add(Me.txtTotalFA)
        Me.XtraScrollableControl1.Controls.Add(Me.txtBuilding)
        Me.XtraScrollableControl1.Controls.Add(Me.txtMachinery)
        Me.XtraScrollableControl1.Controls.Add(Me.txtVehicle)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl17)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl16)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl15)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl14)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl13)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl12)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl9)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl8)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl7)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl6)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl5)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl4)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl3)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl2)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl1)
        Me.XtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraScrollableControl1.Location = New System.Drawing.Point(0, 108)
        Me.XtraScrollableControl1.Name = "XtraScrollableControl1"
        Me.XtraScrollableControl1.Size = New System.Drawing.Size(1012, 490)
        Me.XtraScrollableControl1.TabIndex = 72
        '
        'txtOtherFA
        '
        Me.txtOtherFA.Location = New System.Drawing.Point(267, 127)
        Me.txtOtherFA.MenuManager = Me.BarManager1
        Me.txtOtherFA.Name = "txtOtherFA"
        Me.txtOtherFA.Properties.DisplayFormat.FormatString = "n2"
        Me.txtOtherFA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOtherFA.Properties.Mask.EditMask = "n2"
        Me.txtOtherFA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtOtherFA.Properties.NullText = "0"
        Me.txtOtherFA.Properties.NullValuePrompt = "0"
        Me.txtOtherFA.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtOtherFA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtOtherFA.Size = New System.Drawing.Size(156, 20)
        Me.txtOtherFA.TabIndex = 129
        '
        'LabelControl35
        '
        Me.LabelControl35.Location = New System.Drawing.Point(59, 104)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl35.TabIndex = 128
        Me.LabelControl35.Text = "Land && Building"
        '
        'LabelControl34
        '
        Me.LabelControl34.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl34.Appearance.Options.UseFont = True
        Me.LabelControl34.Location = New System.Drawing.Point(491, 285)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(124, 14)
        Me.LabelControl34.TabIndex = 127
        Me.LabelControl34.Text = "Shareholding Equity"
        '
        'chkSME
        '
        Me.chkSME.Location = New System.Drawing.Point(861, 312)
        Me.chkSME.MenuManager = Me.BarManager1
        Me.chkSME.Name = "chkSME"
        Me.chkSME.Properties.Caption = "SME"
        Me.chkSME.Size = New System.Drawing.Size(75, 19)
        Me.chkSME.TabIndex = 126
        '
        'txtTotalLE
        '
        Me.txtTotalLE.Location = New System.Drawing.Point(698, 413)
        Me.txtTotalLE.MenuManager = Me.BarManager1
        Me.txtTotalLE.Name = "txtTotalLE"
        Me.txtTotalLE.Properties.DisplayFormat.FormatString = "n2"
        Me.txtTotalLE.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalLE.Properties.Mask.EditMask = "n2"
        Me.txtTotalLE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalLE.Properties.NullText = "0"
        Me.txtTotalLE.Properties.NullValuePrompt = "0"
        Me.txtTotalLE.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtTotalLE.Properties.ReadOnly = True
        Me.txtTotalLE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalLE.Size = New System.Drawing.Size(156, 20)
        Me.txtTotalLE.TabIndex = 125
        '
        'LabelControl33
        '
        Me.LabelControl33.Location = New System.Drawing.Point(491, 416)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(105, 13)
        Me.LabelControl33.TabIndex = 124
        Me.LabelControl33.Text = "Total Liability && Equity"
        '
        'txtTotalEquity
        '
        Me.txtTotalEquity.Location = New System.Drawing.Point(698, 387)
        Me.txtTotalEquity.MenuManager = Me.BarManager1
        Me.txtTotalEquity.Name = "txtTotalEquity"
        Me.txtTotalEquity.Properties.DisplayFormat.FormatString = "n2"
        Me.txtTotalEquity.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalEquity.Properties.Mask.EditMask = "n2"
        Me.txtTotalEquity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalEquity.Properties.NullText = "0"
        Me.txtTotalEquity.Properties.NullValuePrompt = "0"
        Me.txtTotalEquity.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtTotalEquity.Properties.ReadOnly = True
        Me.txtTotalEquity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalEquity.Size = New System.Drawing.Size(156, 20)
        Me.txtTotalEquity.TabIndex = 123
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(491, 390)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl32.TabIndex = 122
        Me.LabelControl32.Text = "Total Equity"
        '
        'txtReserves
        '
        Me.txtReserves.Location = New System.Drawing.Point(698, 361)
        Me.txtReserves.MenuManager = Me.BarManager1
        Me.txtReserves.Name = "txtReserves"
        Me.txtReserves.Properties.DisplayFormat.FormatString = "n2"
        Me.txtReserves.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtReserves.Properties.Mask.EditMask = "n2"
        Me.txtReserves.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtReserves.Properties.NullText = "0"
        Me.txtReserves.Properties.NullValuePrompt = "0"
        Me.txtReserves.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtReserves.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtReserves.Size = New System.Drawing.Size(156, 20)
        Me.txtReserves.TabIndex = 121
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(491, 364)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl31.TabIndex = 120
        Me.LabelControl31.Text = "Reserves"
        '
        'txtAppropriation
        '
        Me.txtAppropriation.Location = New System.Drawing.Point(698, 335)
        Me.txtAppropriation.MenuManager = Me.BarManager1
        Me.txtAppropriation.Name = "txtAppropriation"
        Me.txtAppropriation.Properties.DisplayFormat.FormatString = "n2"
        Me.txtAppropriation.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAppropriation.Properties.Mask.EditMask = "n2"
        Me.txtAppropriation.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAppropriation.Properties.NullText = "0"
        Me.txtAppropriation.Properties.NullValuePrompt = "0"
        Me.txtAppropriation.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtAppropriation.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAppropriation.Size = New System.Drawing.Size(156, 20)
        Me.txtAppropriation.TabIndex = 119
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(491, 338)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl30.TabIndex = 118
        Me.LabelControl30.Text = "Appropration P && L"
        '
        'txtPaidUp
        '
        Me.txtPaidUp.Location = New System.Drawing.Point(698, 309)
        Me.txtPaidUp.MenuManager = Me.BarManager1
        Me.txtPaidUp.Name = "txtPaidUp"
        Me.txtPaidUp.Properties.DisplayFormat.FormatString = "n2"
        Me.txtPaidUp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPaidUp.Properties.Mask.EditMask = "n2"
        Me.txtPaidUp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPaidUp.Properties.NullText = "0"
        Me.txtPaidUp.Properties.NullValuePrompt = "0"
        Me.txtPaidUp.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtPaidUp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPaidUp.Size = New System.Drawing.Size(156, 20)
        Me.txtPaidUp.TabIndex = 117
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(491, 312)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl29.TabIndex = 116
        Me.LabelControl29.Text = "Paid Up Capital"
        '
        'txtTotalLiability
        '
        Me.txtTotalLiability.Location = New System.Drawing.Point(698, 262)
        Me.txtTotalLiability.MenuManager = Me.BarManager1
        Me.txtTotalLiability.Name = "txtTotalLiability"
        Me.txtTotalLiability.Properties.DisplayFormat.FormatString = "n2"
        Me.txtTotalLiability.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalLiability.Properties.Mask.EditMask = "n2"
        Me.txtTotalLiability.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalLiability.Properties.NullText = "0"
        Me.txtTotalLiability.Properties.NullValuePrompt = "0"
        Me.txtTotalLiability.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtTotalLiability.Properties.ReadOnly = True
        Me.txtTotalLiability.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalLiability.Size = New System.Drawing.Size(156, 20)
        Me.txtTotalLiability.TabIndex = 115
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(491, 265)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl28.TabIndex = 114
        Me.LabelControl28.Text = "Total Liability"
        '
        'txtLongTerm
        '
        Me.txtLongTerm.Location = New System.Drawing.Point(698, 236)
        Me.txtLongTerm.MenuManager = Me.BarManager1
        Me.txtLongTerm.Name = "txtLongTerm"
        Me.txtLongTerm.Properties.DisplayFormat.FormatString = "n2"
        Me.txtLongTerm.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtLongTerm.Properties.Mask.EditMask = "n2"
        Me.txtLongTerm.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtLongTerm.Properties.NullText = "0"
        Me.txtLongTerm.Properties.NullValuePrompt = "0"
        Me.txtLongTerm.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtLongTerm.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtLongTerm.Size = New System.Drawing.Size(156, 20)
        Me.txtLongTerm.TabIndex = 113
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(491, 239)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl27.TabIndex = 112
        Me.LabelControl27.Text = "Long Term Liability"
        '
        'txtTotalCL
        '
        Me.txtTotalCL.Location = New System.Drawing.Point(698, 210)
        Me.txtTotalCL.MenuManager = Me.BarManager1
        Me.txtTotalCL.Name = "txtTotalCL"
        Me.txtTotalCL.Properties.DisplayFormat.FormatString = "n2"
        Me.txtTotalCL.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalCL.Properties.Mask.EditMask = "n2"
        Me.txtTotalCL.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalCL.Properties.NullText = "0"
        Me.txtTotalCL.Properties.NullValuePrompt = "0"
        Me.txtTotalCL.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtTotalCL.Properties.ReadOnly = True
        Me.txtTotalCL.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalCL.Size = New System.Drawing.Size(156, 20)
        Me.txtTotalCL.TabIndex = 111
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(491, 213)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl26.TabIndex = 110
        Me.LabelControl26.Text = "Total Current Liability"
        '
        'txtOtherCL
        '
        Me.txtOtherCL.Location = New System.Drawing.Point(698, 181)
        Me.txtOtherCL.MenuManager = Me.BarManager1
        Me.txtOtherCL.Name = "txtOtherCL"
        Me.txtOtherCL.Properties.DisplayFormat.FormatString = "n2"
        Me.txtOtherCL.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOtherCL.Properties.Mask.EditMask = "n2"
        Me.txtOtherCL.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtOtherCL.Properties.NullText = "0"
        Me.txtOtherCL.Properties.NullValuePrompt = "0"
        Me.txtOtherCL.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtOtherCL.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtOtherCL.Size = New System.Drawing.Size(156, 20)
        Me.txtOtherCL.TabIndex = 109
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(491, 184)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(106, 13)
        Me.LabelControl25.TabIndex = 108
        Me.LabelControl25.Text = "Other Current Liability"
        '
        'txtLoanFrom
        '
        Me.txtLoanFrom.Location = New System.Drawing.Point(698, 153)
        Me.txtLoanFrom.MenuManager = Me.BarManager1
        Me.txtLoanFrom.Name = "txtLoanFrom"
        Me.txtLoanFrom.Properties.DisplayFormat.FormatString = "n2"
        Me.txtLoanFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtLoanFrom.Properties.Mask.EditMask = "n2"
        Me.txtLoanFrom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtLoanFrom.Properties.NullText = "0"
        Me.txtLoanFrom.Properties.NullValuePrompt = "0"
        Me.txtLoanFrom.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtLoanFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtLoanFrom.Size = New System.Drawing.Size(156, 20)
        Me.txtLoanFrom.TabIndex = 107
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(491, 156)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl24.TabIndex = 106
        Me.LabelControl24.Text = "Loan from Director"
        '
        'txtOtherCreditor
        '
        Me.txtOtherCreditor.Location = New System.Drawing.Point(698, 127)
        Me.txtOtherCreditor.MenuManager = Me.BarManager1
        Me.txtOtherCreditor.Name = "txtOtherCreditor"
        Me.txtOtherCreditor.Properties.DisplayFormat.FormatString = "n2"
        Me.txtOtherCreditor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOtherCreditor.Properties.Mask.EditMask = "n2"
        Me.txtOtherCreditor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtOtherCreditor.Properties.NullText = "0"
        Me.txtOtherCreditor.Properties.NullValuePrompt = "0"
        Me.txtOtherCreditor.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtOtherCreditor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtOtherCreditor.Size = New System.Drawing.Size(156, 20)
        Me.txtOtherCreditor.TabIndex = 105
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(491, 130)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl23.TabIndex = 104
        Me.LabelControl23.Text = "Other Creditor"
        '
        'txtTradeCreditor
        '
        Me.txtTradeCreditor.Location = New System.Drawing.Point(698, 101)
        Me.txtTradeCreditor.MenuManager = Me.BarManager1
        Me.txtTradeCreditor.Name = "txtTradeCreditor"
        Me.txtTradeCreditor.Properties.DisplayFormat.FormatString = "n2"
        Me.txtTradeCreditor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTradeCreditor.Properties.Mask.EditMask = "n2"
        Me.txtTradeCreditor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTradeCreditor.Properties.NullText = "0"
        Me.txtTradeCreditor.Properties.NullValuePrompt = "0"
        Me.txtTradeCreditor.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtTradeCreditor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTradeCreditor.Size = New System.Drawing.Size(156, 20)
        Me.txtTradeCreditor.TabIndex = 103
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(491, 104)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl22.TabIndex = 102
        Me.LabelControl22.Text = "Trade Creditor"
        '
        'txtBorrowing
        '
        Me.txtBorrowing.Location = New System.Drawing.Point(698, 75)
        Me.txtBorrowing.MenuManager = Me.BarManager1
        Me.txtBorrowing.Name = "txtBorrowing"
        Me.txtBorrowing.Properties.DisplayFormat.FormatString = "n2"
        Me.txtBorrowing.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBorrowing.Properties.Mask.EditMask = "n2"
        Me.txtBorrowing.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtBorrowing.Properties.NullText = "0"
        Me.txtBorrowing.Properties.NullValuePrompt = "0"
        Me.txtBorrowing.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtBorrowing.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtBorrowing.Size = New System.Drawing.Size(156, 20)
        Me.txtBorrowing.TabIndex = 101
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(491, 78)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl21.TabIndex = 100
        Me.LabelControl21.Text = "Borrowing"
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl20.Appearance.Options.UseFont = True
        Me.LabelControl20.Location = New System.Drawing.Point(491, 51)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(98, 14)
        Me.LabelControl20.TabIndex = 99
        Me.LabelControl20.Text = "Current Liability"
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.Location = New System.Drawing.Point(491, 32)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(169, 14)
        Me.LabelControl19.TabIndex = 98
        Me.LabelControl19.Text = "Liability And Equity Owners"
        '
        'txtTotalAssets
        '
        Me.txtTotalAssets.Location = New System.Drawing.Point(267, 439)
        Me.txtTotalAssets.MenuManager = Me.BarManager1
        Me.txtTotalAssets.Name = "txtTotalAssets"
        Me.txtTotalAssets.Properties.DisplayFormat.FormatString = "n2"
        Me.txtTotalAssets.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalAssets.Properties.Mask.EditMask = "n2"
        Me.txtTotalAssets.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalAssets.Properties.NullText = "0"
        Me.txtTotalAssets.Properties.NullValuePrompt = "0"
        Me.txtTotalAssets.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtTotalAssets.Properties.ReadOnly = True
        Me.txtTotalAssets.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalAssets.Size = New System.Drawing.Size(156, 20)
        Me.txtTotalAssets.TabIndex = 97
        '
        'txtTotalCA
        '
        Me.txtTotalCA.Location = New System.Drawing.Point(267, 413)
        Me.txtTotalCA.MenuManager = Me.BarManager1
        Me.txtTotalCA.Name = "txtTotalCA"
        Me.txtTotalCA.Properties.DisplayFormat.FormatString = "n2"
        Me.txtTotalCA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalCA.Properties.Mask.EditMask = "n2"
        Me.txtTotalCA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalCA.Properties.NullText = "0"
        Me.txtTotalCA.Properties.NullValuePrompt = "0"
        Me.txtTotalCA.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtTotalCA.Properties.ReadOnly = True
        Me.txtTotalCA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalCA.Size = New System.Drawing.Size(156, 20)
        Me.txtTotalCA.TabIndex = 96
        '
        'txtOtherCA
        '
        Me.txtOtherCA.Location = New System.Drawing.Point(267, 387)
        Me.txtOtherCA.MenuManager = Me.BarManager1
        Me.txtOtherCA.Name = "txtOtherCA"
        Me.txtOtherCA.Properties.DisplayFormat.FormatString = "n2"
        Me.txtOtherCA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOtherCA.Properties.Mask.EditMask = "n2"
        Me.txtOtherCA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtOtherCA.Properties.NullText = "0"
        Me.txtOtherCA.Properties.NullValuePrompt = "0"
        Me.txtOtherCA.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtOtherCA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtOtherCA.Size = New System.Drawing.Size(156, 20)
        Me.txtOtherCA.TabIndex = 95
        '
        'txtCashBank
        '
        Me.txtCashBank.Location = New System.Drawing.Point(267, 361)
        Me.txtCashBank.MenuManager = Me.BarManager1
        Me.txtCashBank.Name = "txtCashBank"
        Me.txtCashBank.Properties.DisplayFormat.FormatString = "n2"
        Me.txtCashBank.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCashBank.Properties.Mask.EditMask = "n2"
        Me.txtCashBank.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCashBank.Properties.NullText = "0"
        Me.txtCashBank.Properties.NullValuePrompt = "0"
        Me.txtCashBank.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtCashBank.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCashBank.Size = New System.Drawing.Size(156, 20)
        Me.txtCashBank.TabIndex = 94
        '
        'txtLoanTo
        '
        Me.txtLoanTo.Location = New System.Drawing.Point(267, 335)
        Me.txtLoanTo.MenuManager = Me.BarManager1
        Me.txtLoanTo.Name = "txtLoanTo"
        Me.txtLoanTo.Properties.DisplayFormat.FormatString = "n2"
        Me.txtLoanTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtLoanTo.Properties.Mask.EditMask = "n2"
        Me.txtLoanTo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtLoanTo.Properties.NullText = "0"
        Me.txtLoanTo.Properties.NullValuePrompt = "0"
        Me.txtLoanTo.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtLoanTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtLoanTo.Size = New System.Drawing.Size(156, 20)
        Me.txtLoanTo.TabIndex = 93
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(267, 309)
        Me.txtStock.MenuManager = Me.BarManager1
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Properties.DisplayFormat.FormatString = "n2"
        Me.txtStock.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtStock.Properties.Mask.EditMask = "n2"
        Me.txtStock.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtStock.Properties.NullText = "0"
        Me.txtStock.Properties.NullValuePrompt = "0"
        Me.txtStock.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtStock.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtStock.Size = New System.Drawing.Size(156, 20)
        Me.txtStock.TabIndex = 92
        '
        'txtOtherDebtors
        '
        Me.txtOtherDebtors.Location = New System.Drawing.Point(267, 283)
        Me.txtOtherDebtors.MenuManager = Me.BarManager1
        Me.txtOtherDebtors.Name = "txtOtherDebtors"
        Me.txtOtherDebtors.Properties.DisplayFormat.FormatString = "n2"
        Me.txtOtherDebtors.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOtherDebtors.Properties.Mask.EditMask = "n2"
        Me.txtOtherDebtors.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtOtherDebtors.Properties.NullText = "0"
        Me.txtOtherDebtors.Properties.NullValuePrompt = "0"
        Me.txtOtherDebtors.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtOtherDebtors.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtOtherDebtors.Size = New System.Drawing.Size(156, 20)
        Me.txtOtherDebtors.TabIndex = 91
        '
        'txtTradeDebtors
        '
        Me.txtTradeDebtors.Location = New System.Drawing.Point(267, 257)
        Me.txtTradeDebtors.MenuManager = Me.BarManager1
        Me.txtTradeDebtors.Name = "txtTradeDebtors"
        Me.txtTradeDebtors.Properties.DisplayFormat.FormatString = "n2"
        Me.txtTradeDebtors.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTradeDebtors.Properties.Mask.EditMask = "n2"
        Me.txtTradeDebtors.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTradeDebtors.Properties.NullText = "0"
        Me.txtTradeDebtors.Properties.NullValuePrompt = "0"
        Me.txtTradeDebtors.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtTradeDebtors.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTradeDebtors.Size = New System.Drawing.Size(156, 20)
        Me.txtTradeDebtors.TabIndex = 90
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Location = New System.Drawing.Point(60, 238)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(85, 14)
        Me.LabelControl18.TabIndex = 89
        Me.LabelControl18.Text = "Current Asset"
        '
        'txtInvestment
        '
        Me.txtInvestment.Location = New System.Drawing.Point(267, 205)
        Me.txtInvestment.MenuManager = Me.BarManager1
        Me.txtInvestment.Name = "txtInvestment"
        Me.txtInvestment.Properties.DisplayFormat.FormatString = "n2"
        Me.txtInvestment.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInvestment.Properties.Mask.EditMask = "n2"
        Me.txtInvestment.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtInvestment.Properties.NullText = "0"
        Me.txtInvestment.Properties.NullValuePrompt = "0"
        Me.txtInvestment.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtInvestment.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtInvestment.Size = New System.Drawing.Size(156, 20)
        Me.txtInvestment.TabIndex = 88
        '
        'txtCurYear
        '
        Me.txtCurYear.Location = New System.Drawing.Point(267, 179)
        Me.txtCurYear.MenuManager = Me.BarManager1
        Me.txtCurYear.Name = "txtCurYear"
        Me.txtCurYear.Properties.DisplayFormat.FormatString = "n2"
        Me.txtCurYear.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCurYear.Properties.Mask.EditMask = "n2"
        Me.txtCurYear.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCurYear.Properties.NullText = "0"
        Me.txtCurYear.Properties.NullValuePrompt = "0"
        Me.txtCurYear.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtCurYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCurYear.Size = New System.Drawing.Size(156, 20)
        Me.txtCurYear.TabIndex = 87
        '
        'txtTotalFA
        '
        Me.txtTotalFA.Location = New System.Drawing.Point(267, 153)
        Me.txtTotalFA.MenuManager = Me.BarManager1
        Me.txtTotalFA.Name = "txtTotalFA"
        Me.txtTotalFA.Properties.DisplayFormat.FormatString = "n2"
        Me.txtTotalFA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalFA.Properties.Mask.EditMask = "n2"
        Me.txtTotalFA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalFA.Properties.NullText = "0"
        Me.txtTotalFA.Properties.NullValuePrompt = "0"
        Me.txtTotalFA.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtTotalFA.Properties.ReadOnly = True
        Me.txtTotalFA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotalFA.Size = New System.Drawing.Size(156, 20)
        Me.txtTotalFA.TabIndex = 86
        '
        'txtBuilding
        '
        Me.txtBuilding.Location = New System.Drawing.Point(267, 101)
        Me.txtBuilding.MenuManager = Me.BarManager1
        Me.txtBuilding.Name = "txtBuilding"
        Me.txtBuilding.Properties.DisplayFormat.FormatString = "n2"
        Me.txtBuilding.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBuilding.Properties.Mask.EditMask = "n2"
        Me.txtBuilding.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtBuilding.Properties.NullText = "0"
        Me.txtBuilding.Properties.NullValuePrompt = "0"
        Me.txtBuilding.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtBuilding.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtBuilding.Size = New System.Drawing.Size(156, 20)
        Me.txtBuilding.TabIndex = 85
        '
        'txtMachinery
        '
        Me.txtMachinery.Location = New System.Drawing.Point(267, 75)
        Me.txtMachinery.MenuManager = Me.BarManager1
        Me.txtMachinery.Name = "txtMachinery"
        Me.txtMachinery.Properties.DisplayFormat.FormatString = "n2"
        Me.txtMachinery.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMachinery.Properties.Mask.EditMask = "n2"
        Me.txtMachinery.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMachinery.Properties.NullText = "0"
        Me.txtMachinery.Properties.NullValuePrompt = "0"
        Me.txtMachinery.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtMachinery.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMachinery.Size = New System.Drawing.Size(156, 20)
        Me.txtMachinery.TabIndex = 84
        '
        'txtVehicle
        '
        Me.txtVehicle.Location = New System.Drawing.Point(267, 49)
        Me.txtVehicle.MenuManager = Me.BarManager1
        Me.txtVehicle.Name = "txtVehicle"
        Me.txtVehicle.Properties.DisplayFormat.FormatString = "n2"
        Me.txtVehicle.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtVehicle.Properties.Mask.EditMask = "n2"
        Me.txtVehicle.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtVehicle.Properties.NullText = "0"
        Me.txtVehicle.Properties.NullValuePrompt = "0"
        Me.txtVehicle.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtVehicle.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtVehicle.Size = New System.Drawing.Size(156, 20)
        Me.txtVehicle.TabIndex = 83
        Me.txtVehicle.ToolTip = "FA_MOTORVECHILE"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.Location = New System.Drawing.Point(60, 32)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(69, 14)
        Me.LabelControl17.TabIndex = 82
        Me.LabelControl17.Text = "Fixed Asset"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(58, 442)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl16.TabIndex = 81
        Me.LabelControl16.Text = "Total Assets"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(59, 416)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(99, 13)
        Me.LabelControl15.TabIndex = 80
        Me.LabelControl15.Text = "Total Current Assets"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(59, 390)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(103, 13)
        Me.LabelControl14.TabIndex = 79
        Me.LabelControl14.Text = "Other Current Assets"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(60, 364)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl13.TabIndex = 78
        Me.LabelControl13.Text = "Cash && Bank"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(60, 338)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl12.TabIndex = 77
        Me.LabelControl12.Text = "Loan to director"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(60, 312)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl9.TabIndex = 76
        Me.LabelControl9.Text = "Stock"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(60, 286)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl8.TabIndex = 75
        Me.LabelControl8.Text = "Other Debtors"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(59, 260)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl7.TabIndex = 74
        Me.LabelControl7.Text = "Trade Debtors"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(60, 210)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl6.TabIndex = 73
        Me.LabelControl6.Text = "Investment"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(60, 182)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(121, 13)
        Me.LabelControl5.TabIndex = 72
        Me.LabelControl5.Text = "Current Year Fixed Asset"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(60, 156)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl4.TabIndex = 71
        Me.LabelControl4.Text = "Total Fixed Assets"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(58, 130)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl3.TabIndex = 70
        Me.LabelControl3.Text = "Other Fixed Assets"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(59, 78)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl2.TabIndex = 69
        Me.LabelControl2.Text = "Plant && Machinery"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(60, 52)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl1.TabIndex = 68
        Me.LabelControl1.Text = "Motor Vehicle"
        '
        'frmBalanceSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 598)
        Me.Controls.Add(Me.XtraScrollableControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmBalanceSheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance Sheet"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraScrollableControl1.ResumeLayout(False)
        Me.XtraScrollableControl1.PerformLayout()
        CType(Me.txtOtherFA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSME.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalLE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalEquity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReserves.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAppropriation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPaidUp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalLiability.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLongTerm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOtherCL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLoanFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOtherCreditor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTradeCreditor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBorrowing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalAssets.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOtherCA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCashBank.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLoanTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOtherDebtors.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTradeDebtors.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvestment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalFA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuilding.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMachinery.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVehicle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
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
    Friend WithEvents txtRefNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboYA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TaxPayerFindBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsDefault As EasyTemplate_Taxcom.dsDefault
    Friend WithEvents XtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents txtOtherFA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkSME As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtTotalLE As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalEquity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtReserves As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAppropriation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPaidUp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalLiability As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLongTerm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalCL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOtherCL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLoanFrom As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOtherCreditor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTradeCreditor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBorrowing As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalAssets As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalCA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOtherCA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCashBank As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLoanTo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStock As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOtherDebtors As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTradeDebtors As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInvestment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCurYear As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalFA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBuilding As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMachinery As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtVehicle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblModifiedBy As DevExpress.XtraBars.BarStaticItem
End Class
