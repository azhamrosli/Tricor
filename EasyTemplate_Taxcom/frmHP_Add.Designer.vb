<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHP_Add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHP_Add))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDuplicate = New DevExpress.XtraBars.BarButtonItem()
        Me.txtDuplicateNo = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCompanyCode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFileNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.cboHP = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblHPCode = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cboSourceCode = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboRefNo = New DevExpress.XtraEditors.LookUpEdit()
        Me.TaxPayerFindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCA = New EasyTemplate_Taxcom.dsCA()
        Me.txtTaxPayer = New DevExpress.XtraEditors.TextEdit()
        Me.cboYA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cboPurchaseYE = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.pnlMain = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtCategory = New DevExpress.XtraEditors.TextEdit()
        Me.pnlGenerateType = New System.Windows.Forms.Panel()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNoInstallment = New DevExpress.XtraEditors.TextEdit()
        Me.cboDecimal = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFirstInstallment = New DevExpress.XtraEditors.DateEdit()
        Me.rgGenerateType = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPrincipalInterest_Total = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txtInterest = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPrincipal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescription = New DevExpress.XtraEditors.MemoEdit()
        Me.dtDateofPurchase = New DevExpress.XtraEditors.DateEdit()
        Me.cboCategory = New DevExpress.XtraEditors.LookUpEdit()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRestrictedQua = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDeposit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPurchaseAmountFA = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAssetID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAsset = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.lblTitle_FA = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.dgvCYearly = New DevExpress.XtraGrid.GridControl()
        Me.HPYEARLYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvYearly = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colHP_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_YA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboTextNumberic = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colHPD_PRINCIPAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_INTEREST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_TOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_NOTE_TITLE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_NOTE_TITLE2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dgvCInstallment = New DevExpress.XtraGrid.GridControl()
        Me.HPINSTALLMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvInstallment = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colHP_KEY1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_KEY1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_PRINCIPAL1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_INTEREST1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_TOTAL1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_PAY_DUE_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtDateOnly = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colHPD_PAYMENT_PRINCIPAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNumbericOnly = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colHPD_PAYMENT_INTEREST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_PAYMENT_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPD_YA1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.btnApplyPayment = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPrintCalc = New DevExpress.XtraEditors.SimpleButton()
        Me.btnStraightLine = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSumofDigits = New DevExpress.XtraEditors.SimpleButton()
        Me.lblTypeInstallment = New DevExpress.XtraEditors.LabelControl()
        Me.lblTitleSchedule = New DevExpress.XtraEditors.LabelControl()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtCompanyCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboHP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSourceCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTaxPayer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPurchaseYE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGenerateType.SuspendLayout()
        CType(Me.txtNoInstallment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDecimal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFirstInstallment.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFirstInstallment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgGenerateType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrincipalInterest_Total.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInterest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrincipal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateofPurchase.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateofPurchase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRestrictedQua.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeposit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPurchaseAmountFA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAssetID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAsset.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.dgvCYearly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HPYEARLYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvYearly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTextNumberic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCInstallment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HPINSTALLMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInstallment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateOnly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateOnly.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumbericOnly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSave, Me.btnClose, Me.btnDuplicate, Me.txtDuplicateNo})
        Me.BarManager1.MaxItemId = 9
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemSpinEdit1})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSave), New DevExpress.XtraBars.LinkPersistInfo(Me.btnClose), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDuplicate), New DevExpress.XtraBars.LinkPersistInfo(Me.txtDuplicateNo)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None
        Me.Bar1.OptionsBar.DisableClose = True
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Glyph = CType(resources.GetObject("btnSave.Glyph"), System.Drawing.Image)
        Me.btnSave.Id = 0
        Me.btnSave.LargeGlyph = CType(resources.GetObject("btnSave.LargeGlyph"), System.Drawing.Image)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnClose
        '
        Me.btnClose.Caption = "Close"
        Me.btnClose.Glyph = CType(resources.GetObject("btnClose.Glyph"), System.Drawing.Image)
        Me.btnClose.Id = 2
        Me.btnClose.LargeGlyph = CType(resources.GetObject("btnClose.LargeGlyph"), System.Drawing.Image)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnDuplicate
        '
        Me.btnDuplicate.Caption = "Duplicate CA"
        Me.btnDuplicate.Glyph = CType(resources.GetObject("btnDuplicate.Glyph"), System.Drawing.Image)
        Me.btnDuplicate.Id = 6
        Me.btnDuplicate.LargeGlyph = CType(resources.GetObject("btnDuplicate.LargeGlyph"), System.Drawing.Image)
        Me.btnDuplicate.Name = "btnDuplicate"
        Me.btnDuplicate.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.btnDuplicate.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'txtDuplicateNo
        '
        Me.txtDuplicateNo.Caption = "BarEditItem1"
        Me.txtDuplicateNo.Edit = Me.RepositoryItemSpinEdit1
        Me.txtDuplicateNo.Id = 8
        Me.txtDuplicateNo.Name = "txtDuplicateNo"
        Me.txtDuplicateNo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1132, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 561)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1132, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 530)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1132, 31)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 530)
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl28)
        Me.PanelControl1.Controls.Add(Me.txtCompanyCode)
        Me.PanelControl1.Controls.Add(Me.LabelControl27)
        Me.PanelControl1.Controls.Add(Me.txtFileNo)
        Me.PanelControl1.Controls.Add(Me.LabelControl26)
        Me.PanelControl1.Controls.Add(Me.cboHP)
        Me.PanelControl1.Controls.Add(Me.lblHPCode)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.cboSourceCode)
        Me.PanelControl1.Controls.Add(Me.cboRefNo)
        Me.PanelControl1.Controls.Add(Me.txtTaxPayer)
        Me.PanelControl1.Controls.Add(Me.cboYA)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.cboPurchaseYE)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 31)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1132, 166)
        Me.PanelControl1.TabIndex = 4
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(12, 119)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl28.TabIndex = 180
        Me.LabelControl28.Text = "Company Code :"
        '
        'txtCompanyCode
        '
        Me.txtCompanyCode.Location = New System.Drawing.Point(139, 116)
        Me.txtCompanyCode.Name = "txtCompanyCode"
        Me.txtCompanyCode.Properties.ReadOnly = True
        Me.txtCompanyCode.Size = New System.Drawing.Size(280, 20)
        Me.txtCompanyCode.TabIndex = 179
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(12, 93)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl27.TabIndex = 178
        Me.LabelControl27.Text = "File No :"
        '
        'txtFileNo
        '
        Me.txtFileNo.Location = New System.Drawing.Point(139, 90)
        Me.txtFileNo.Name = "txtFileNo"
        Me.txtFileNo.Properties.ReadOnly = True
        Me.txtFileNo.Size = New System.Drawing.Size(280, 20)
        Me.txtFileNo.TabIndex = 177
        '
        'LabelControl26
        '
        Me.LabelControl26.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl26.Location = New System.Drawing.Point(12, 6)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(185, 19)
        Me.LabelControl26.TabIndex = 176
        Me.LabelControl26.Text = "Tax Payer Information"
        '
        'cboHP
        '
        Me.cboHP.Location = New System.Drawing.Point(571, 93)
        Me.cboHP.Name = "cboHP"
        Me.cboHP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboHP.Size = New System.Drawing.Size(242, 20)
        Me.cboHP.TabIndex = 8
        '
        'lblHPCode
        '
        Me.lblHPCode.Location = New System.Drawing.Point(444, 96)
        Me.lblHPCode.Name = "lblHPCode"
        Me.lblHPCode.Size = New System.Drawing.Size(101, 13)
        Me.lblHPCode.TabIndex = 168
        Me.lblHPCode.Text = "Hire Purchase Code :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 143)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl3.TabIndex = 154
        Me.LabelControl3.Text = "Year Of Assessment :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 44)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl1.TabIndex = 152
        Me.LabelControl1.Text = "Reference No :"
        '
        'cboSourceCode
        '
        Me.cboSourceCode.Location = New System.Drawing.Point(571, 67)
        Me.cboSourceCode.Name = "cboSourceCode"
        Me.cboSourceCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSourceCode.Size = New System.Drawing.Size(242, 20)
        Me.cboSourceCode.TabIndex = 4
        '
        'cboRefNo
        '
        Me.cboRefNo.Location = New System.Drawing.Point(139, 41)
        Me.cboRefNo.Name = "cboRefNo"
        Me.cboRefNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRefNo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RefNo", "Ref No", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[True]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Company Name", 85, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[True]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyNo", "Company No", 71, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployerNo", "Employer No", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FileNo", "File No", 42, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Country", "Country", 49, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyCode", "Company Code", 83, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboRefNo.Properties.DataSource = Me.TaxPayerFindBindingSource
        Me.cboRefNo.Properties.DisplayMember = "RefNo"
        Me.cboRefNo.Properties.PopupFormMinSize = New System.Drawing.Size(450, 0)
        Me.cboRefNo.Properties.ValueMember = "RefNo"
        Me.cboRefNo.Size = New System.Drawing.Size(280, 20)
        Me.cboRefNo.TabIndex = 0
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
        'txtTaxPayer
        '
        Me.txtTaxPayer.Location = New System.Drawing.Point(139, 67)
        Me.txtTaxPayer.Name = "txtTaxPayer"
        Me.txtTaxPayer.Properties.ReadOnly = True
        Me.txtTaxPayer.Size = New System.Drawing.Size(280, 20)
        Me.txtTaxPayer.TabIndex = 157
        '
        'cboYA
        '
        Me.cboYA.Location = New System.Drawing.Point(139, 140)
        Me.cboYA.Name = "cboYA"
        Me.cboYA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboYA.Properties.PopupSizeable = True
        Me.cboYA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboYA.Size = New System.Drawing.Size(280, 20)
        Me.cboYA.TabIndex = 1
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(444, 70)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl5.TabIndex = 160
        Me.LabelControl5.Text = "Source Code :"
        '
        'cboPurchaseYE
        '
        Me.cboPurchaseYE.Location = New System.Drawing.Point(571, 41)
        Me.cboPurchaseYE.Name = "cboPurchaseYE"
        Me.cboPurchaseYE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPurchaseYE.Properties.ReadOnly = True
        Me.cboPurchaseYE.Size = New System.Drawing.Size(242, 20)
        Me.cboPurchaseYE.TabIndex = 3
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(444, 44)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl6.TabIndex = 162
        Me.LabelControl6.Text = "Purchase YE :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(126, 44)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(7, 13)
        Me.LabelControl4.TabIndex = 156
        Me.LabelControl4.Text = "C"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 70)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl2.TabIndex = 153
        Me.LabelControl2.Text = "Tax Payer :"
        '
        'pnlMain
        '
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 197)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.SelectedTabPage = Me.XtraTabPage1
        Me.pnlMain.Size = New System.Drawing.Size(1132, 364)
        Me.pnlMain.TabIndex = 5
        Me.pnlMain.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.txtCategory)
        Me.XtraTabPage1.Controls.Add(Me.pnlGenerateType)
        Me.XtraTabPage1.Controls.Add(Me.rgGenerateType)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl19)
        Me.XtraTabPage1.Controls.Add(Me.txtPrincipalInterest_Total)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl18)
        Me.XtraTabPage1.Controls.Add(Me.txtInterest)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl17)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl16)
        Me.XtraTabPage1.Controls.Add(Me.txtPrincipal)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl7)
        Me.XtraTabPage1.Controls.Add(Me.txtDescription)
        Me.XtraTabPage1.Controls.Add(Me.dtDateofPurchase)
        Me.XtraTabPage1.Controls.Add(Me.cboCategory)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl25)
        Me.XtraTabPage1.Controls.Add(Me.txtRestrictedQua)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl15)
        Me.XtraTabPage1.Controls.Add(Me.txtDeposit)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl14)
        Me.XtraTabPage1.Controls.Add(Me.txtPurchaseAmountFA)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl13)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl12)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl11)
        Me.XtraTabPage1.Controls.Add(Me.txtAssetID)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage1.Controls.Add(Me.txtAsset)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage1.Controls.Add(Me.lblTitle_FA)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1126, 336)
        Me.XtraTabPage1.Text = "General Information"
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(357, 109)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Properties.ReadOnly = True
        Me.txtCategory.Size = New System.Drawing.Size(187, 20)
        Me.txtCategory.TabIndex = 295
        '
        'pnlGenerateType
        '
        Me.pnlGenerateType.Controls.Add(Me.LabelControl20)
        Me.pnlGenerateType.Controls.Add(Me.txtNoInstallment)
        Me.pnlGenerateType.Controls.Add(Me.cboDecimal)
        Me.pnlGenerateType.Controls.Add(Me.LabelControl21)
        Me.pnlGenerateType.Controls.Add(Me.LabelControl22)
        Me.pnlGenerateType.Controls.Add(Me.dtFirstInstallment)
        Me.pnlGenerateType.Location = New System.Drawing.Point(570, 218)
        Me.pnlGenerateType.Name = "pnlGenerateType"
        Me.pnlGenerateType.Size = New System.Drawing.Size(496, 100)
        Me.pnlGenerateType.TabIndex = 294
        Me.pnlGenerateType.Visible = False
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(13, 11)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl20.TabIndex = 287
        Me.LabelControl20.Text = "No of Installment :"
        '
        'txtNoInstallment
        '
        Me.txtNoInstallment.Location = New System.Drawing.Point(152, 8)
        Me.txtNoInstallment.Name = "txtNoInstallment"
        Me.txtNoInstallment.Properties.DisplayFormat.FormatString = "n0"
        Me.txtNoInstallment.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNoInstallment.Properties.EditFormat.FormatString = "n0"
        Me.txtNoInstallment.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNoInstallment.Properties.Mask.EditMask = "n0"
        Me.txtNoInstallment.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNoInstallment.Properties.NullText = "0"
        Me.txtNoInstallment.Properties.NullValuePrompt = "0"
        Me.txtNoInstallment.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNoInstallment.Size = New System.Drawing.Size(203, 20)
        Me.txtNoInstallment.TabIndex = 286
        '
        'cboDecimal
        '
        Me.cboDecimal.Location = New System.Drawing.Point(361, 60)
        Me.cboDecimal.MenuManager = Me.BarManager1
        Me.cboDecimal.Name = "cboDecimal"
        Me.cboDecimal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDecimal.Properties.Items.AddRange(New Object() {"0", "1", "2"})
        Me.cboDecimal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboDecimal.Size = New System.Drawing.Size(100, 20)
        Me.cboDecimal.TabIndex = 292
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(13, 38)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl21.TabIndex = 289
        Me.LabelControl21.Text = "First Installment :"
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(13, 63)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(337, 13)
        Me.LabelControl22.TabIndex = 291
        Me.LabelControl22.Text = "Round Principal and Interest of each installment to how many decimal?"
        '
        'dtFirstInstallment
        '
        Me.dtFirstInstallment.EditValue = Nothing
        Me.dtFirstInstallment.Location = New System.Drawing.Point(152, 34)
        Me.dtFirstInstallment.MenuManager = Me.BarManager1
        Me.dtFirstInstallment.Name = "dtFirstInstallment"
        Me.dtFirstInstallment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFirstInstallment.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFirstInstallment.Size = New System.Drawing.Size(203, 20)
        Me.dtFirstInstallment.TabIndex = 288
        '
        'rgGenerateType
        '
        Me.rgGenerateType.EditValue = CType(0, Short)
        Me.rgGenerateType.Location = New System.Drawing.Point(570, 191)
        Me.rgGenerateType.MenuManager = Me.BarManager1
        Me.rgGenerateType.Name = "rgGenerateType"
        Me.rgGenerateType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(0, Short), "Yearly"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "No of Installments")})
        Me.rgGenerateType.Size = New System.Drawing.Size(258, 21)
        Me.rgGenerateType.TabIndex = 293
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl19.Location = New System.Drawing.Point(570, 160)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(197, 19)
        Me.LabelControl19.TabIndex = 285
        Me.LabelControl19.Text = "Generate Schedule With"
        '
        'txtPrincipalInterest_Total
        '
        Me.txtPrincipalInterest_Total.Location = New System.Drawing.Point(709, 109)
        Me.txtPrincipalInterest_Total.Name = "txtPrincipalInterest_Total"
        Me.txtPrincipalInterest_Total.Properties.DisplayFormat.FormatString = "n"
        Me.txtPrincipalInterest_Total.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrincipalInterest_Total.Properties.Mask.EditMask = "n"
        Me.txtPrincipalInterest_Total.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrincipalInterest_Total.Properties.NullText = "0"
        Me.txtPrincipalInterest_Total.Properties.NullValuePrompt = "0"
        Me.txtPrincipalInterest_Total.Properties.ReadOnly = True
        Me.txtPrincipalInterest_Total.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPrincipalInterest_Total.Size = New System.Drawing.Size(203, 20)
        Me.txtPrincipalInterest_Total.TabIndex = 283
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(570, 112)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(125, 13)
        Me.LabelControl18.TabIndex = 284
        Me.LabelControl18.Text = "Principal + Interest (RM) :"
        '
        'txtInterest
        '
        Me.txtInterest.Location = New System.Drawing.Point(709, 83)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Properties.DisplayFormat.FormatString = "n"
        Me.txtInterest.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInterest.Properties.Mask.EditMask = "n"
        Me.txtInterest.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtInterest.Properties.NullText = "0"
        Me.txtInterest.Properties.NullValuePrompt = "0"
        Me.txtInterest.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtInterest.Size = New System.Drawing.Size(203, 20)
        Me.txtInterest.TabIndex = 281
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(570, 86)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl17.TabIndex = 282
        Me.LabelControl17.Text = "Interest (RM) :"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(918, 60)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(138, 13)
        Me.LabelControl16.TabIndex = 280
        Me.LabelControl16.Text = "(Purchase Amount - Deposit)"
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Location = New System.Drawing.Point(709, 57)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Properties.DisplayFormat.FormatString = "n"
        Me.txtPrincipal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrincipal.Properties.Mask.EditMask = "n"
        Me.txtPrincipal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrincipal.Properties.NullText = "0"
        Me.txtPrincipal.Properties.NullValuePrompt = "0"
        Me.txtPrincipal.Properties.ReadOnly = True
        Me.txtPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPrincipal.Size = New System.Drawing.Size(203, 20)
        Me.txtPrincipal.TabIndex = 278
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(570, 60)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl8.TabIndex = 279
        Me.LabelControl8.Text = "Principal (RM) :"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(570, 24)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(113, 19)
        Me.LabelControl7.TabIndex = 277
        Me.LabelControl7.Text = "Hire Purchase"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(150, 240)
        Me.txtDescription.MenuManager = Me.BarManager1
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(396, 77)
        Me.txtDescription.TabIndex = 267
        '
        'dtDateofPurchase
        '
        Me.dtDateofPurchase.EditValue = Nothing
        Me.dtDateofPurchase.Location = New System.Drawing.Point(150, 135)
        Me.dtDateofPurchase.MenuManager = Me.BarManager1
        Me.dtDateofPurchase.Name = "dtDateofPurchase"
        Me.dtDateofPurchase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDateofPurchase.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDateofPurchase.Size = New System.Drawing.Size(203, 20)
        Me.dtDateofPurchase.TabIndex = 263
        '
        'cboCategory
        '
        Me.cboCategory.Location = New System.Drawing.Point(150, 109)
        Me.cboCategory.MenuManager = Me.BarManager1
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCategory.Properties.DataSource = Me.CategoryBindingSource
        Me.cboCategory.Properties.DisplayMember = "CA_CODE"
        Me.cboCategory.Properties.ValueMember = "CA_CODE"
        Me.cboCategory.Size = New System.Drawing.Size(203, 20)
        Me.cboCategory.TabIndex = 262
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.DsCA
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(11, 243)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl25.TabIndex = 276
        Me.LabelControl25.Text = "Description/Note :"
        '
        'txtRestrictedQua
        '
        Me.txtRestrictedQua.Location = New System.Drawing.Point(150, 214)
        Me.txtRestrictedQua.Name = "txtRestrictedQua"
        Me.txtRestrictedQua.Properties.DisplayFormat.FormatString = "n"
        Me.txtRestrictedQua.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtRestrictedQua.Properties.Mask.EditMask = "n"
        Me.txtRestrictedQua.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRestrictedQua.Properties.NullText = "0"
        Me.txtRestrictedQua.Properties.NullValuePrompt = "0"
        Me.txtRestrictedQua.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtRestrictedQua.Size = New System.Drawing.Size(203, 20)
        Me.txtRestrictedQua.TabIndex = 266
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(11, 217)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(132, 13)
        Me.LabelControl15.TabIndex = 275
        Me.LabelControl15.Text = "Restricted Qualifying Cost :"
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(150, 188)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Properties.DisplayFormat.FormatString = "n"
        Me.txtDeposit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDeposit.Properties.Mask.EditMask = "n"
        Me.txtDeposit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDeposit.Properties.NullText = "0"
        Me.txtDeposit.Properties.NullValuePrompt = "0"
        Me.txtDeposit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDeposit.Size = New System.Drawing.Size(203, 20)
        Me.txtDeposit.TabIndex = 265
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(11, 191)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(118, 13)
        Me.LabelControl14.TabIndex = 274
        Me.LabelControl14.Text = "Deposit/ Payment (RM) :"
        '
        'txtPurchaseAmountFA
        '
        Me.txtPurchaseAmountFA.Location = New System.Drawing.Point(150, 162)
        Me.txtPurchaseAmountFA.Name = "txtPurchaseAmountFA"
        Me.txtPurchaseAmountFA.Properties.DisplayFormat.FormatString = "n"
        Me.txtPurchaseAmountFA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPurchaseAmountFA.Properties.Mask.EditMask = "n"
        Me.txtPurchaseAmountFA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPurchaseAmountFA.Properties.NullText = "0"
        Me.txtPurchaseAmountFA.Properties.NullValuePrompt = "0"
        Me.txtPurchaseAmountFA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPurchaseAmountFA.Size = New System.Drawing.Size(203, 20)
        Me.txtPurchaseAmountFA.TabIndex = 264
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(11, 165)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(117, 13)
        Me.LabelControl13.TabIndex = 273
        Me.LabelControl13.Text = "Purchase Amount (RM) :"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(11, 139)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl12.TabIndex = 272
        Me.LabelControl12.Text = "Date of Purchase :"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(11, 112)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl11.TabIndex = 271
        Me.LabelControl11.Text = "Category Code :"
        '
        'txtAssetID
        '
        Me.txtAssetID.Location = New System.Drawing.Point(150, 83)
        Me.txtAssetID.Name = "txtAssetID"
        Me.txtAssetID.Size = New System.Drawing.Size(203, 20)
        Me.txtAssetID.TabIndex = 261
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(11, 86)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl10.TabIndex = 270
        Me.LabelControl10.Text = "Asset ID/ Stock ID :"
        '
        'txtAsset
        '
        Me.txtAsset.Location = New System.Drawing.Point(150, 57)
        Me.txtAsset.Name = "txtAsset"
        Me.txtAsset.Size = New System.Drawing.Size(396, 20)
        Me.txtAsset.TabIndex = 260
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(11, 60)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl9.TabIndex = 269
        Me.LabelControl9.Text = "Asset Description :"
        '
        'lblTitle_FA
        '
        Me.lblTitle_FA.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle_FA.Location = New System.Drawing.Point(11, 24)
        Me.lblTitle_FA.Name = "lblTitle_FA"
        Me.lblTitle_FA.Size = New System.Drawing.Size(196, 19)
        Me.lblTitle_FA.TabIndex = 268
        Me.lblTitle_FA.Text = "Fixed Asset Information"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.dgvCYearly)
        Me.XtraTabPage2.Controls.Add(Me.dgvCInstallment)
        Me.XtraTabPage2.Controls.Add(Me.Panel1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1126, 336)
        Me.XtraTabPage2.Text = "Schedule"
        '
        'dgvCYearly
        '
        Me.dgvCYearly.DataSource = Me.HPYEARLYBindingSource
        Me.dgvCYearly.Location = New System.Drawing.Point(125, 40)
        Me.dgvCYearly.MainView = Me.dgvYearly
        Me.dgvCYearly.MenuManager = Me.BarManager1
        Me.dgvCYearly.Name = "dgvCYearly"
        Me.dgvCYearly.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboTextNumberic})
        Me.dgvCYearly.Size = New System.Drawing.Size(441, 273)
        Me.dgvCYearly.TabIndex = 2
        Me.dgvCYearly.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvYearly})
        Me.dgvCYearly.Visible = False
        '
        'HPYEARLYBindingSource
        '
        Me.HPYEARLYBindingSource.DataMember = "HP_YEARLY"
        Me.HPYEARLYBindingSource.DataSource = Me.DsCA
        '
        'dgvYearly
        '
        Me.dgvYearly.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHP_KEY, Me.colHPD_KEY, Me.colHPD_YA, Me.colHPD_PRINCIPAL, Me.colHPD_INTEREST, Me.colHPD_TOTAL, Me.colHPD_NOTE_TITLE1, Me.colHPD_NOTE_TITLE2})
        Me.dgvYearly.GridControl = Me.dgvCYearly
        Me.dgvYearly.Name = "dgvYearly"
        Me.dgvYearly.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.dgvYearly.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.dgvYearly.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[True]
        Me.dgvYearly.OptionsView.ColumnAutoWidth = False
        Me.dgvYearly.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'colHP_KEY
        '
        Me.colHP_KEY.FieldName = "HP_KEY"
        Me.colHP_KEY.Name = "colHP_KEY"
        '
        'colHPD_KEY
        '
        Me.colHPD_KEY.FieldName = "HPD_KEY"
        Me.colHPD_KEY.Name = "colHPD_KEY"
        '
        'colHPD_YA
        '
        Me.colHPD_YA.Caption = "Yearly Payment"
        Me.colHPD_YA.ColumnEdit = Me.cboTextNumberic
        Me.colHPD_YA.FieldName = "HPD_YA"
        Me.colHPD_YA.Name = "colHPD_YA"
        Me.colHPD_YA.Visible = True
        Me.colHPD_YA.VisibleIndex = 0
        Me.colHPD_YA.Width = 100
        '
        'cboTextNumberic
        '
        Me.cboTextNumberic.AutoHeight = False
        Me.cboTextNumberic.DisplayFormat.FormatString = "n0"
        Me.cboTextNumberic.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.cboTextNumberic.EditFormat.FormatString = "n0"
        Me.cboTextNumberic.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.cboTextNumberic.Mask.EditMask = "n0"
        Me.cboTextNumberic.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.cboTextNumberic.Name = "cboTextNumberic"
        Me.cboTextNumberic.NullText = "0"
        Me.cboTextNumberic.NullValuePrompt = "0"
        '
        'colHPD_PRINCIPAL
        '
        Me.colHPD_PRINCIPAL.Caption = "Principal Paid"
        Me.colHPD_PRINCIPAL.ColumnEdit = Me.cboTextNumberic
        Me.colHPD_PRINCIPAL.FieldName = "HPD_PRINCIPAL"
        Me.colHPD_PRINCIPAL.Name = "colHPD_PRINCIPAL"
        Me.colHPD_PRINCIPAL.Visible = True
        Me.colHPD_PRINCIPAL.VisibleIndex = 1
        Me.colHPD_PRINCIPAL.Width = 150
        '
        'colHPD_INTEREST
        '
        Me.colHPD_INTEREST.Caption = "Interest Paid"
        Me.colHPD_INTEREST.ColumnEdit = Me.cboTextNumberic
        Me.colHPD_INTEREST.FieldName = "HPD_INTEREST"
        Me.colHPD_INTEREST.Name = "colHPD_INTEREST"
        Me.colHPD_INTEREST.Visible = True
        Me.colHPD_INTEREST.VisibleIndex = 2
        Me.colHPD_INTEREST.Width = 150
        '
        'colHPD_TOTAL
        '
        Me.colHPD_TOTAL.Caption = "Total"
        Me.colHPD_TOTAL.ColumnEdit = Me.cboTextNumberic
        Me.colHPD_TOTAL.FieldName = "HPD_TOTAL"
        Me.colHPD_TOTAL.Name = "colHPD_TOTAL"
        Me.colHPD_TOTAL.OptionsColumn.AllowEdit = False
        Me.colHPD_TOTAL.Visible = True
        Me.colHPD_TOTAL.VisibleIndex = 3
        Me.colHPD_TOTAL.Width = 150
        '
        'colHPD_NOTE_TITLE1
        '
        Me.colHPD_NOTE_TITLE1.Caption = "Note Title"
        Me.colHPD_NOTE_TITLE1.FieldName = "HPD_NOTE_TITLE1"
        Me.colHPD_NOTE_TITLE1.Name = "colHPD_NOTE_TITLE1"
        Me.colHPD_NOTE_TITLE1.Visible = True
        Me.colHPD_NOTE_TITLE1.VisibleIndex = 4
        Me.colHPD_NOTE_TITLE1.Width = 150
        '
        'colHPD_NOTE_TITLE2
        '
        Me.colHPD_NOTE_TITLE2.Caption = "Note Title"
        Me.colHPD_NOTE_TITLE2.FieldName = "HPD_NOTE_TITLE2"
        Me.colHPD_NOTE_TITLE2.Name = "colHPD_NOTE_TITLE2"
        Me.colHPD_NOTE_TITLE2.Visible = True
        Me.colHPD_NOTE_TITLE2.VisibleIndex = 5
        Me.colHPD_NOTE_TITLE2.Width = 200
        '
        'dgvCInstallment
        '
        Me.dgvCInstallment.DataSource = Me.HPINSTALLMENTBindingSource
        Me.dgvCInstallment.Location = New System.Drawing.Point(645, 40)
        Me.dgvCInstallment.MainView = Me.dgvInstallment
        Me.dgvCInstallment.MenuManager = Me.BarManager1
        Me.dgvCInstallment.Name = "dgvCInstallment"
        Me.dgvCInstallment.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtNumbericOnly, Me.dtDateOnly})
        Me.dgvCInstallment.Size = New System.Drawing.Size(441, 273)
        Me.dgvCInstallment.TabIndex = 0
        Me.dgvCInstallment.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgvInstallment})
        Me.dgvCInstallment.Visible = False
        '
        'HPINSTALLMENTBindingSource
        '
        Me.HPINSTALLMENTBindingSource.DataMember = "HP_INSTALLMENT"
        Me.HPINSTALLMENTBindingSource.DataSource = Me.DsCA
        '
        'dgvInstallment
        '
        Me.dgvInstallment.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHP_KEY1, Me.colHPD_KEY1, Me.colHPD_PRINCIPAL1, Me.colHPD_INTEREST1, Me.colHPD_TOTAL1, Me.colHPD_PAY_DUE_DATE, Me.colHPD_PAYMENT_PRINCIPAL, Me.colHPD_PAYMENT_INTEREST, Me.GridColumn1, Me.colHPD_PAYMENT_DATE, Me.colHPD_YA1})
        Me.dgvInstallment.GridControl = Me.dgvCInstallment
        Me.dgvInstallment.Name = "dgvInstallment"
        Me.dgvInstallment.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.dgvInstallment.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.dgvInstallment.OptionsView.ColumnAutoWidth = False
        '
        'colHP_KEY1
        '
        Me.colHP_KEY1.FieldName = "HP_KEY"
        Me.colHP_KEY1.Name = "colHP_KEY1"
        '
        'colHPD_KEY1
        '
        Me.colHPD_KEY1.Caption = "No"
        Me.colHPD_KEY1.FieldName = "HPD_KEY"
        Me.colHPD_KEY1.Name = "colHPD_KEY1"
        Me.colHPD_KEY1.Visible = True
        Me.colHPD_KEY1.VisibleIndex = 0
        '
        'colHPD_PRINCIPAL1
        '
        Me.colHPD_PRINCIPAL1.Caption = "Principal (RM)"
        Me.colHPD_PRINCIPAL1.FieldName = "HPD_PRINCIPAL"
        Me.colHPD_PRINCIPAL1.Name = "colHPD_PRINCIPAL1"
        Me.colHPD_PRINCIPAL1.OptionsColumn.AllowEdit = False
        Me.colHPD_PRINCIPAL1.Visible = True
        Me.colHPD_PRINCIPAL1.VisibleIndex = 1
        Me.colHPD_PRINCIPAL1.Width = 100
        '
        'colHPD_INTEREST1
        '
        Me.colHPD_INTEREST1.Caption = "Interest (RM)"
        Me.colHPD_INTEREST1.FieldName = "HPD_INTEREST"
        Me.colHPD_INTEREST1.Name = "colHPD_INTEREST1"
        Me.colHPD_INTEREST1.OptionsColumn.AllowEdit = False
        Me.colHPD_INTEREST1.Visible = True
        Me.colHPD_INTEREST1.VisibleIndex = 2
        Me.colHPD_INTEREST1.Width = 100
        '
        'colHPD_TOTAL1
        '
        Me.colHPD_TOTAL1.Caption = "Total (RM)"
        Me.colHPD_TOTAL1.FieldName = "HPD_TOTAL"
        Me.colHPD_TOTAL1.Name = "colHPD_TOTAL1"
        Me.colHPD_TOTAL1.OptionsColumn.AllowEdit = False
        Me.colHPD_TOTAL1.Visible = True
        Me.colHPD_TOTAL1.VisibleIndex = 3
        Me.colHPD_TOTAL1.Width = 100
        '
        'colHPD_PAY_DUE_DATE
        '
        Me.colHPD_PAY_DUE_DATE.Caption = "Payment Due"
        Me.colHPD_PAY_DUE_DATE.ColumnEdit = Me.dtDateOnly
        Me.colHPD_PAY_DUE_DATE.FieldName = "HPD_PAY_DUE_DATE"
        Me.colHPD_PAY_DUE_DATE.Name = "colHPD_PAY_DUE_DATE"
        Me.colHPD_PAY_DUE_DATE.OptionsColumn.AllowEdit = False
        Me.colHPD_PAY_DUE_DATE.Visible = True
        Me.colHPD_PAY_DUE_DATE.VisibleIndex = 4
        Me.colHPD_PAY_DUE_DATE.Width = 100
        '
        'dtDateOnly
        '
        Me.dtDateOnly.AutoHeight = False
        Me.dtDateOnly.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDateOnly.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDateOnly.Name = "dtDateOnly"
        '
        'colHPD_PAYMENT_PRINCIPAL
        '
        Me.colHPD_PAYMENT_PRINCIPAL.Caption = "Principal Paid (RM)"
        Me.colHPD_PAYMENT_PRINCIPAL.ColumnEdit = Me.txtNumbericOnly
        Me.colHPD_PAYMENT_PRINCIPAL.FieldName = "HPD_PAYMENT_PRINCIPAL"
        Me.colHPD_PAYMENT_PRINCIPAL.Name = "colHPD_PAYMENT_PRINCIPAL"
        Me.colHPD_PAYMENT_PRINCIPAL.Visible = True
        Me.colHPD_PAYMENT_PRINCIPAL.VisibleIndex = 5
        Me.colHPD_PAYMENT_PRINCIPAL.Width = 100
        '
        'txtNumbericOnly
        '
        Me.txtNumbericOnly.AutoHeight = False
        Me.txtNumbericOnly.DisplayFormat.FormatString = "n"
        Me.txtNumbericOnly.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNumbericOnly.EditFormat.FormatString = "n"
        Me.txtNumbericOnly.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNumbericOnly.Mask.EditMask = "n"
        Me.txtNumbericOnly.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNumbericOnly.Name = "txtNumbericOnly"
        '
        'colHPD_PAYMENT_INTEREST
        '
        Me.colHPD_PAYMENT_INTEREST.Caption = "Interest Paid (RM)"
        Me.colHPD_PAYMENT_INTEREST.ColumnEdit = Me.txtNumbericOnly
        Me.colHPD_PAYMENT_INTEREST.FieldName = "HPD_PAYMENT_INTEREST"
        Me.colHPD_PAYMENT_INTEREST.Name = "colHPD_PAYMENT_INTEREST"
        Me.colHPD_PAYMENT_INTEREST.Visible = True
        Me.colHPD_PAYMENT_INTEREST.VisibleIndex = 6
        Me.colHPD_PAYMENT_INTEREST.Width = 100
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Total (RM)"
        Me.GridColumn1.FieldName = "HPD_PAYMENT_TOTAL"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 7
        Me.GridColumn1.Width = 100
        '
        'colHPD_PAYMENT_DATE
        '
        Me.colHPD_PAYMENT_DATE.Caption = "Payment Date"
        Me.colHPD_PAYMENT_DATE.ColumnEdit = Me.dtDateOnly
        Me.colHPD_PAYMENT_DATE.FieldName = "HPD_PAYMENT_DATE"
        Me.colHPD_PAYMENT_DATE.Name = "colHPD_PAYMENT_DATE"
        Me.colHPD_PAYMENT_DATE.Visible = True
        Me.colHPD_PAYMENT_DATE.VisibleIndex = 8
        Me.colHPD_PAYMENT_DATE.Width = 100
        '
        'colHPD_YA1
        '
        Me.colHPD_YA1.Caption = "YA"
        Me.colHPD_YA1.FieldName = "HPD_YA"
        Me.colHPD_YA1.Name = "colHPD_YA1"
        Me.colHPD_YA1.Visible = True
        Me.colHPD_YA1.VisibleIndex = 9
        Me.colHPD_YA1.Width = 100
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnRemove)
        Me.Panel1.Controls.Add(Me.btnApplyPayment)
        Me.Panel1.Controls.Add(Me.btnPrintCalc)
        Me.Panel1.Controls.Add(Me.btnStraightLine)
        Me.Panel1.Controls.Add(Me.btnSumofDigits)
        Me.Panel1.Controls.Add(Me.lblTypeInstallment)
        Me.Panel1.Controls.Add(Me.lblTitleSchedule)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1126, 37)
        Me.Panel1.TabIndex = 1
        '
        'btnRemove
        '
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.Location = New System.Drawing.Point(659, 11)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(106, 23)
        Me.btnRemove.TabIndex = 276
        Me.btnRemove.Text = "Remove"
        '
        'btnApplyPayment
        '
        Me.btnApplyPayment.Image = CType(resources.GetObject("btnApplyPayment.Image"), System.Drawing.Image)
        Me.btnApplyPayment.Location = New System.Drawing.Point(547, 11)
        Me.btnApplyPayment.Name = "btnApplyPayment"
        Me.btnApplyPayment.Size = New System.Drawing.Size(106, 23)
        Me.btnApplyPayment.TabIndex = 274
        Me.btnApplyPayment.Text = "Apply Payment"
        '
        'btnPrintCalc
        '
        Me.btnPrintCalc.Image = CType(resources.GetObject("btnPrintCalc.Image"), System.Drawing.Image)
        Me.btnPrintCalc.Location = New System.Drawing.Point(435, 11)
        Me.btnPrintCalc.Name = "btnPrintCalc"
        Me.btnPrintCalc.Size = New System.Drawing.Size(106, 23)
        Me.btnPrintCalc.TabIndex = 273
        Me.btnPrintCalc.Text = "Print Calculation"
        '
        'btnStraightLine
        '
        Me.btnStraightLine.Image = CType(resources.GetObject("btnStraightLine.Image"), System.Drawing.Image)
        Me.btnStraightLine.Location = New System.Drawing.Point(323, 11)
        Me.btnStraightLine.Name = "btnStraightLine"
        Me.btnStraightLine.Size = New System.Drawing.Size(106, 23)
        Me.btnStraightLine.TabIndex = 272
        Me.btnStraightLine.Text = "Straight Line"
        '
        'btnSumofDigits
        '
        Me.btnSumofDigits.Image = CType(resources.GetObject("btnSumofDigits.Image"), System.Drawing.Image)
        Me.btnSumofDigits.Location = New System.Drawing.Point(211, 11)
        Me.btnSumofDigits.Name = "btnSumofDigits"
        Me.btnSumofDigits.Size = New System.Drawing.Size(106, 23)
        Me.btnSumofDigits.TabIndex = 271
        Me.btnSumofDigits.Text = "Sum of Digits"
        '
        'lblTypeInstallment
        '
        Me.lblTypeInstallment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTypeInstallment.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeInstallment.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblTypeInstallment.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTypeInstallment.Location = New System.Drawing.Point(889, 15)
        Me.lblTypeInstallment.Name = "lblTypeInstallment"
        Me.lblTypeInstallment.Size = New System.Drawing.Size(230, 19)
        Me.lblTypeInstallment.TabIndex = 270
        Me.lblTypeInstallment.Text = "Sum Of Digits"
        '
        'lblTitleSchedule
        '
        Me.lblTitleSchedule.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleSchedule.Location = New System.Drawing.Point(11, 15)
        Me.lblTitleSchedule.Name = "lblTitleSchedule"
        Me.lblTitleSchedule.Size = New System.Drawing.Size(180, 19)
        Me.lblTitleSchedule.TabIndex = 269
        Me.lblTitleSchedule.Text = "Installments Schedule"
        '
        'frmHP_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 561)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmHP_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hire Purchase"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtCompanyCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboHP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSourceCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTaxPayer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPurchaseYE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGenerateType.ResumeLayout(False)
        Me.pnlGenerateType.PerformLayout()
        CType(Me.txtNoInstallment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDecimal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFirstInstallment.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFirstInstallment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgGenerateType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrincipalInterest_Total.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInterest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrincipal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateofPurchase.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateofPurchase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRestrictedQua.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeposit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPurchaseAmountFA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAssetID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAsset.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.dgvCYearly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HPYEARLYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvYearly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTextNumberic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCInstallment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HPINSTALLMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInstallment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateOnly.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateOnly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumbericOnly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDuplicate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtDuplicateNo As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCompanyCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFileNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboHP As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblHPCode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboSourceCode As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboRefNo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TaxPayerFindBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsCA As EasyTemplate_Taxcom.dsCA
    Friend WithEvents txtTaxPayer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboYA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboPurchaseYE As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnlMain As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pnlGenerateType As System.Windows.Forms.Panel
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNoInstallment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboDecimal As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFirstInstallment As DevExpress.XtraEditors.DateEdit
    Friend WithEvents rgGenerateType As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrincipalInterest_Total As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInterest As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrincipal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescription As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents dtDateofPurchase As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cboCategory As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRestrictedQua As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDeposit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPurchaseAmountFA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAssetID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAsset As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTitle_FA As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtCategory As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnApplyPayment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPrintCalc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnStraightLine As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSumofDigits As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTypeInstallment As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTitleSchedule As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dgvCInstallment As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgvInstallment As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgvCYearly As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgvYearly As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colHP_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_YA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_PRINCIPAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboTextNumberic As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colHPD_INTEREST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_TOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_NOTE_TITLE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_NOTE_TITLE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHP_KEY1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_KEY1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_PRINCIPAL1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_INTEREST1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_TOTAL1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_PAY_DUE_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_PAYMENT_PRINCIPAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_PAYMENT_INTEREST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_PAYMENT_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPD_YA1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HPYEARLYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HPINSTALLMENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtDateOnly As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents txtNumbericOnly As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
