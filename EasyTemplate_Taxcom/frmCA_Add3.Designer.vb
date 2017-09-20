<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCA_Add3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCA_Add3))
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
        Me.DsCA = New EasyTemplate_Taxcom.dsCA()
        Me.TaxPayerFindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.chkREC = New DevExpress.XtraEditors.CheckEdit()
        Me.cboSourceCode = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboRefNo = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtTaxPayer = New DevExpress.XtraEditors.TextEdit()
        Me.cboYA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.rgTypeCA = New DevExpress.XtraEditors.RadioGroup()
        Me.cboPurchaseYE = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.chkHP = New DevExpress.XtraEditors.CheckEdit()
        Me.chkCAEEO = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.pnlMain = New DevExpress.XtraEditors.PanelControl()
        Me.pnlControlTransfer = New DevExpress.XtraEditors.PanelControl()
        Me.txtTransferVal = New DevExpress.XtraEditors.TextEdit()
        Me.txtTransferorName = New DevExpress.XtraEditors.TextEdit()
        Me.txtTaxFileNumber = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCategory = New DevExpress.XtraEditors.TextEdit()
        Me.cboAA = New DevExpress.XtraEditors.ComboBoxEdit()
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
        Me.chkDeductAdjustIncome = New DevExpress.XtraEditors.CheckEdit()
        Me.chkDeferred = New DevExpress.XtraEditors.CheckEdit()
        Me.chkControlTransfer = New DevExpress.XtraEditors.CheckEdit()
        Me.chkAccelerated = New DevExpress.XtraEditors.CheckEdit()
        Me.txtTWDV = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemainingQualifyingCost = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNonQualifyingCost = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.txtQualifyingCost = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPurchaseAmount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.cboIncentive = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIA = New DevExpress.XtraEditors.TextEdit()
        Me.lblTitle_CA = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtCompanyCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboHP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkREC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSourceCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTaxPayer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgTypeCA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPurchaseYE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkHP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCAEEO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        CType(Me.pnlControlTransfer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControlTransfer.SuspendLayout()
        CType(Me.txtTransferVal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransferorName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTaxFileNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.chkDeductAdjustIncome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDeferred.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkControlTransfer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAccelerated.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTWDV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemainingQualifyingCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNonQualifyingCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQualifyingCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPurchaseAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboIncentive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 617)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1132, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 586)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1132, 31)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 586)
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'DsCA
        '
        Me.DsCA.DataSetName = "dsCA"
        Me.DsCA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TaxPayerFindBindingSource
        '
        Me.TaxPayerFindBindingSource.DataMember = "TaxPayerFind"
        Me.TaxPayerFindBindingSource.DataSource = Me.DsCA
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
        Me.PanelControl1.Controls.Add(Me.chkREC)
        Me.PanelControl1.Controls.Add(Me.cboSourceCode)
        Me.PanelControl1.Controls.Add(Me.cboRefNo)
        Me.PanelControl1.Controls.Add(Me.txtTaxPayer)
        Me.PanelControl1.Controls.Add(Me.cboYA)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.rgTypeCA)
        Me.PanelControl1.Controls.Add(Me.cboPurchaseYE)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.chkHP)
        Me.PanelControl1.Controls.Add(Me.chkCAEEO)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 31)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1132, 166)
        Me.PanelControl1.TabIndex = 0
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
        Me.cboHP.Location = New System.Drawing.Point(608, 116)
        Me.cboHP.Name = "cboHP"
        Me.cboHP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboHP.Size = New System.Drawing.Size(242, 20)
        Me.cboHP.TabIndex = 8
        Me.cboHP.Visible = False
        '
        'lblHPCode
        '
        Me.lblHPCode.Location = New System.Drawing.Point(481, 119)
        Me.lblHPCode.Name = "lblHPCode"
        Me.lblHPCode.Size = New System.Drawing.Size(101, 13)
        Me.lblHPCode.TabIndex = 168
        Me.lblHPCode.Text = "Hire Purchase Code :"
        Me.lblHPCode.Visible = False
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
        'chkREC
        '
        Me.chkREC.Location = New System.Drawing.Point(856, 119)
        Me.chkREC.Name = "chkREC"
        Me.chkREC.Properties.Caption = "Revenue Expenditure Capitalised"
        Me.chkREC.Size = New System.Drawing.Size(187, 19)
        Me.chkREC.TabIndex = 7
        Me.chkREC.Visible = False
        '
        'cboSourceCode
        '
        Me.cboSourceCode.Location = New System.Drawing.Point(608, 90)
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
        Me.cboRefNo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RefNo", "Ref No", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Company Name", 85, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyNo", "Company No", 71, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployerNo", "Employer No", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FileNo", "File No", 42, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Country", "Country", 49, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyCode", "Company Code", 83, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboRefNo.Properties.DataSource = Me.TaxPayerFindBindingSource
        Me.cboRefNo.Properties.DisplayMember = "RefNo"
        Me.cboRefNo.Properties.PopupFormMinSize = New System.Drawing.Size(450, 0)
        Me.cboRefNo.Properties.ValueMember = "RefNo"
        Me.cboRefNo.Size = New System.Drawing.Size(280, 20)
        Me.cboRefNo.TabIndex = 0
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
        Me.LabelControl5.Location = New System.Drawing.Point(481, 93)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl5.TabIndex = 160
        Me.LabelControl5.Text = "Source Code :"
        '
        'rgTypeCA
        '
        Me.rgTypeCA.EditValue = True
        Me.rgTypeCA.Location = New System.Drawing.Point(608, 34)
        Me.rgTypeCA.Name = "rgTypeCA"
        Me.rgTypeCA.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Addition"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Opening")})
        Me.rgTypeCA.Size = New System.Drawing.Size(242, 26)
        Me.rgTypeCA.TabIndex = 2
        '
        'cboPurchaseYE
        '
        Me.cboPurchaseYE.Location = New System.Drawing.Point(608, 67)
        Me.cboPurchaseYE.Name = "cboPurchaseYE"
        Me.cboPurchaseYE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPurchaseYE.Size = New System.Drawing.Size(242, 20)
        Me.cboPurchaseYE.TabIndex = 3
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(481, 70)
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
        'chkHP
        '
        Me.chkHP.Location = New System.Drawing.Point(856, 67)
        Me.chkHP.Name = "chkHP"
        Me.chkHP.Properties.Caption = "Hire Purchase Item"
        Me.chkHP.Size = New System.Drawing.Size(121, 19)
        Me.chkHP.TabIndex = 5
        Me.chkHP.Visible = False
        '
        'chkCAEEO
        '
        Me.chkCAEEO.Location = New System.Drawing.Point(856, 93)
        Me.chkCAEEO.Name = "chkCAEEO"
        Me.chkCAEEO.Properties.Caption = "Capital Expenditure Expensed - Off"
        Me.chkCAEEO.Size = New System.Drawing.Size(215, 19)
        Me.chkCAEEO.TabIndex = 6
        Me.chkCAEEO.Visible = False
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
        Me.pnlMain.Controls.Add(Me.pnlControlTransfer)
        Me.pnlMain.Controls.Add(Me.txtCategory)
        Me.pnlMain.Controls.Add(Me.cboAA)
        Me.pnlMain.Controls.Add(Me.txtDescription)
        Me.pnlMain.Controls.Add(Me.dtDateofPurchase)
        Me.pnlMain.Controls.Add(Me.cboCategory)
        Me.pnlMain.Controls.Add(Me.LabelControl25)
        Me.pnlMain.Controls.Add(Me.txtRestrictedQua)
        Me.pnlMain.Controls.Add(Me.LabelControl15)
        Me.pnlMain.Controls.Add(Me.txtDeposit)
        Me.pnlMain.Controls.Add(Me.LabelControl14)
        Me.pnlMain.Controls.Add(Me.txtPurchaseAmountFA)
        Me.pnlMain.Controls.Add(Me.LabelControl13)
        Me.pnlMain.Controls.Add(Me.LabelControl12)
        Me.pnlMain.Controls.Add(Me.LabelControl11)
        Me.pnlMain.Controls.Add(Me.txtAssetID)
        Me.pnlMain.Controls.Add(Me.LabelControl10)
        Me.pnlMain.Controls.Add(Me.txtAsset)
        Me.pnlMain.Controls.Add(Me.LabelControl9)
        Me.pnlMain.Controls.Add(Me.lblTitle_FA)
        Me.pnlMain.Controls.Add(Me.chkDeductAdjustIncome)
        Me.pnlMain.Controls.Add(Me.chkDeferred)
        Me.pnlMain.Controls.Add(Me.chkControlTransfer)
        Me.pnlMain.Controls.Add(Me.chkAccelerated)
        Me.pnlMain.Controls.Add(Me.txtTWDV)
        Me.pnlMain.Controls.Add(Me.LabelControl24)
        Me.pnlMain.Controls.Add(Me.txtRemainingQualifyingCost)
        Me.pnlMain.Controls.Add(Me.LabelControl23)
        Me.pnlMain.Controls.Add(Me.txtNonQualifyingCost)
        Me.pnlMain.Controls.Add(Me.LabelControl22)
        Me.pnlMain.Controls.Add(Me.txtQualifyingCost)
        Me.pnlMain.Controls.Add(Me.LabelControl21)
        Me.pnlMain.Controls.Add(Me.txtPurchaseAmount)
        Me.pnlMain.Controls.Add(Me.LabelControl20)
        Me.pnlMain.Controls.Add(Me.LabelControl19)
        Me.pnlMain.Controls.Add(Me.cboIncentive)
        Me.pnlMain.Controls.Add(Me.LabelControl18)
        Me.pnlMain.Controls.Add(Me.txtIA)
        Me.pnlMain.Controls.Add(Me.lblTitle_CA)
        Me.pnlMain.Controls.Add(Me.LabelControl16)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Enabled = False
        Me.pnlMain.Location = New System.Drawing.Point(0, 197)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1132, 420)
        Me.pnlMain.TabIndex = 1
        '
        'pnlControlTransfer
        '
        Me.pnlControlTransfer.Controls.Add(Me.txtTransferVal)
        Me.pnlControlTransfer.Controls.Add(Me.txtTransferorName)
        Me.pnlControlTransfer.Controls.Add(Me.txtTaxFileNumber)
        Me.pnlControlTransfer.Controls.Add(Me.LabelControl17)
        Me.pnlControlTransfer.Controls.Add(Me.LabelControl7)
        Me.pnlControlTransfer.Controls.Add(Me.LabelControl8)
        Me.pnlControlTransfer.Location = New System.Drawing.Point(575, 308)
        Me.pnlControlTransfer.Name = "pnlControlTransfer"
        Me.pnlControlTransfer.Size = New System.Drawing.Size(545, 100)
        Me.pnlControlTransfer.TabIndex = 244
        Me.pnlControlTransfer.Visible = False
        '
        'txtTransferVal
        '
        Me.txtTransferVal.Location = New System.Drawing.Point(158, 63)
        Me.txtTransferVal.Name = "txtTransferVal"
        Me.txtTransferVal.Size = New System.Drawing.Size(211, 20)
        Me.txtTransferVal.TabIndex = 231
        '
        'txtTransferorName
        '
        Me.txtTransferorName.Location = New System.Drawing.Point(158, 37)
        Me.txtTransferorName.Name = "txtTransferorName"
        Me.txtTransferorName.Size = New System.Drawing.Size(211, 20)
        Me.txtTransferorName.TabIndex = 230
        '
        'txtTaxFileNumber
        '
        Me.txtTaxFileNumber.Location = New System.Drawing.Point(158, 11)
        Me.txtTaxFileNumber.Name = "txtTaxFileNumber"
        Me.txtTaxFileNumber.Size = New System.Drawing.Size(211, 20)
        Me.txtTaxFileNumber.TabIndex = 229
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(5, 66)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl17.TabIndex = 228
        Me.LabelControl17.Text = "Transfer Value :"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(5, 40)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl7.TabIndex = 227
        Me.LabelControl7.Text = "Transferor Name :"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(5, 14)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl8.TabIndex = 226
        Me.LabelControl8.Text = "Tax File Number :"
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(357, 127)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Properties.ReadOnly = True
        Me.txtCategory.Size = New System.Drawing.Size(187, 20)
        Me.txtCategory.TabIndex = 243
        '
        'cboAA
        '
        Me.cboAA.Location = New System.Drawing.Point(733, 101)
        Me.cboAA.Name = "cboAA"
        Me.cboAA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAA.Properties.Items.AddRange(New Object() {"0", "2", "3", "8", "10", "12", "14", "16", "20", "40", "50", "60", "80", "90", "100"})
        Me.cboAA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboAA.Size = New System.Drawing.Size(211, 20)
        Me.cboAA.TabIndex = 9
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(148, 258)
        Me.txtDescription.MenuManager = Me.BarManager1
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(396, 77)
        Me.txtDescription.TabIndex = 7
        '
        'dtDateofPurchase
        '
        Me.dtDateofPurchase.EditValue = Nothing
        Me.dtDateofPurchase.Location = New System.Drawing.Point(148, 153)
        Me.dtDateofPurchase.MenuManager = Me.BarManager1
        Me.dtDateofPurchase.Name = "dtDateofPurchase"
        Me.dtDateofPurchase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDateofPurchase.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDateofPurchase.Size = New System.Drawing.Size(203, 20)
        Me.dtDateofPurchase.TabIndex = 3
        '
        'cboCategory
        '
        Me.cboCategory.Location = New System.Drawing.Point(148, 127)
        Me.cboCategory.MenuManager = Me.BarManager1
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCategory.Properties.DataSource = Me.CategoryBindingSource
        Me.cboCategory.Properties.DisplayMember = "CA_CODE"
        Me.cboCategory.Properties.ValueMember = "CA_CODE"
        Me.cboCategory.Size = New System.Drawing.Size(203, 20)
        Me.cboCategory.TabIndex = 2
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.DsCA
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(9, 261)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl25.TabIndex = 242
        Me.LabelControl25.Text = "Description/Note :"
        '
        'txtRestrictedQua
        '
        Me.txtRestrictedQua.Location = New System.Drawing.Point(148, 232)
        Me.txtRestrictedQua.Name = "txtRestrictedQua"
        Me.txtRestrictedQua.Properties.DisplayFormat.FormatString = "n"
        Me.txtRestrictedQua.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtRestrictedQua.Properties.Mask.EditMask = "n"
        Me.txtRestrictedQua.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRestrictedQua.Properties.NullText = "0"
        Me.txtRestrictedQua.Properties.NullValuePrompt = "0"
        Me.txtRestrictedQua.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtRestrictedQua.Size = New System.Drawing.Size(203, 20)
        Me.txtRestrictedQua.TabIndex = 6
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(9, 235)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(132, 13)
        Me.LabelControl15.TabIndex = 240
        Me.LabelControl15.Text = "Restricted Qualifying Cost :"
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(148, 206)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Properties.DisplayFormat.FormatString = "n"
        Me.txtDeposit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDeposit.Properties.Mask.EditMask = "n"
        Me.txtDeposit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDeposit.Properties.NullText = "0"
        Me.txtDeposit.Properties.NullValuePrompt = "0"
        Me.txtDeposit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDeposit.Size = New System.Drawing.Size(203, 20)
        Me.txtDeposit.TabIndex = 5
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(9, 209)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(118, 13)
        Me.LabelControl14.TabIndex = 238
        Me.LabelControl14.Text = "Deposit/ Payment (RM) :"
        '
        'txtPurchaseAmountFA
        '
        Me.txtPurchaseAmountFA.Location = New System.Drawing.Point(148, 180)
        Me.txtPurchaseAmountFA.Name = "txtPurchaseAmountFA"
        Me.txtPurchaseAmountFA.Properties.DisplayFormat.FormatString = "n"
        Me.txtPurchaseAmountFA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPurchaseAmountFA.Properties.Mask.EditMask = "n"
        Me.txtPurchaseAmountFA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPurchaseAmountFA.Properties.NullText = "0"
        Me.txtPurchaseAmountFA.Properties.NullValuePrompt = "0"
        Me.txtPurchaseAmountFA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPurchaseAmountFA.Size = New System.Drawing.Size(203, 20)
        Me.txtPurchaseAmountFA.TabIndex = 4
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(9, 183)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(117, 13)
        Me.LabelControl13.TabIndex = 236
        Me.LabelControl13.Text = "Purchase Amount (RM) :"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(9, 157)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl12.TabIndex = 235
        Me.LabelControl12.Text = "Date of Purchase :"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(9, 130)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl11.TabIndex = 234
        Me.LabelControl11.Text = "Category Code :"
        '
        'txtAssetID
        '
        Me.txtAssetID.Location = New System.Drawing.Point(148, 101)
        Me.txtAssetID.Name = "txtAssetID"
        Me.txtAssetID.Size = New System.Drawing.Size(203, 20)
        Me.txtAssetID.TabIndex = 1
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(9, 104)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl10.TabIndex = 232
        Me.LabelControl10.Text = "Asset ID/ Stock ID :"
        '
        'txtAsset
        '
        Me.txtAsset.Location = New System.Drawing.Point(148, 75)
        Me.txtAsset.Name = "txtAsset"
        Me.txtAsset.Size = New System.Drawing.Size(396, 20)
        Me.txtAsset.TabIndex = 0
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(9, 78)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl9.TabIndex = 230
        Me.LabelControl9.Text = "Asset Description :"
        '
        'lblTitle_FA
        '
        Me.lblTitle_FA.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle_FA.Location = New System.Drawing.Point(9, 17)
        Me.lblTitle_FA.Name = "lblTitle_FA"
        Me.lblTitle_FA.Size = New System.Drawing.Size(284, 19)
        Me.lblTitle_FA.TabIndex = 229
        Me.lblTitle_FA.Text = "Fixed Asset Information (Addition)"
        '
        'chkDeductAdjustIncome
        '
        Me.chkDeductAdjustIncome.Location = New System.Drawing.Point(959, 206)
        Me.chkDeductAdjustIncome.Name = "chkDeductAdjustIncome"
        Me.chkDeductAdjustIncome.Properties.AutoHeight = False
        Me.chkDeductAdjustIncome.Properties.Caption = "Deduct from Adjusted Income"
        Me.chkDeductAdjustIncome.Size = New System.Drawing.Size(165, 19)
        Me.chkDeductAdjustIncome.TabIndex = 19
        '
        'chkDeferred
        '
        Me.chkDeferred.Location = New System.Drawing.Point(959, 154)
        Me.chkDeferred.Name = "chkDeferred"
        Me.chkDeferred.Properties.Caption = "Deferred Claim"
        Me.chkDeferred.Size = New System.Drawing.Size(137, 19)
        Me.chkDeferred.TabIndex = 17
        Me.chkDeferred.Visible = False
        '
        'chkControlTransfer
        '
        Me.chkControlTransfer.Location = New System.Drawing.Point(959, 179)
        Me.chkControlTransfer.Name = "chkControlTransfer"
        Me.chkControlTransfer.Properties.Caption = "Control Transfer"
        Me.chkControlTransfer.Size = New System.Drawing.Size(121, 19)
        Me.chkControlTransfer.TabIndex = 18
        '
        'chkAccelerated
        '
        Me.chkAccelerated.Location = New System.Drawing.Point(575, 283)
        Me.chkAccelerated.Name = "chkAccelerated"
        Me.chkAccelerated.Properties.Caption = "Accelerated Capital Allowance"
        Me.chkAccelerated.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkAccelerated.Size = New System.Drawing.Size(175, 19)
        Me.chkAccelerated.TabIndex = 16
        '
        'txtTWDV
        '
        Me.txtTWDV.Location = New System.Drawing.Point(733, 257)
        Me.txtTWDV.Name = "txtTWDV"
        Me.txtTWDV.Properties.DisplayFormat.FormatString = "n"
        Me.txtTWDV.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTWDV.Properties.Mask.EditMask = "n"
        Me.txtTWDV.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTWDV.Properties.NullText = "0"
        Me.txtTWDV.Properties.NullValuePrompt = "0"
        Me.txtTWDV.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTWDV.Size = New System.Drawing.Size(211, 20)
        Me.txtTWDV.TabIndex = 15
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(575, 260)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl24.TabIndex = 223
        Me.LabelControl24.Text = "TWDV :"
        '
        'txtRemainingQualifyingCost
        '
        Me.txtRemainingQualifyingCost.Location = New System.Drawing.Point(733, 231)
        Me.txtRemainingQualifyingCost.Name = "txtRemainingQualifyingCost"
        Me.txtRemainingQualifyingCost.Properties.DisplayFormat.FormatString = "n"
        Me.txtRemainingQualifyingCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtRemainingQualifyingCost.Properties.Mask.EditMask = "n"
        Me.txtRemainingQualifyingCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRemainingQualifyingCost.Properties.NullText = "0"
        Me.txtRemainingQualifyingCost.Properties.NullValuePrompt = "0"
        Me.txtRemainingQualifyingCost.Properties.ReadOnly = True
        Me.txtRemainingQualifyingCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtRemainingQualifyingCost.Size = New System.Drawing.Size(211, 20)
        Me.txtRemainingQualifyingCost.TabIndex = 14
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(575, 234)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(158, 13)
        Me.LabelControl23.TabIndex = 221
        Me.LabelControl23.Text = "Remaining Qualifying Cost (RM) :"
        '
        'txtNonQualifyingCost
        '
        Me.txtNonQualifyingCost.Location = New System.Drawing.Point(733, 205)
        Me.txtNonQualifyingCost.Name = "txtNonQualifyingCost"
        Me.txtNonQualifyingCost.Properties.DisplayFormat.FormatString = "n"
        Me.txtNonQualifyingCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNonQualifyingCost.Properties.Mask.EditMask = "n"
        Me.txtNonQualifyingCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNonQualifyingCost.Properties.NullText = "0"
        Me.txtNonQualifyingCost.Properties.NullValuePrompt = "0"
        Me.txtNonQualifyingCost.Properties.ReadOnly = True
        Me.txtNonQualifyingCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNonQualifyingCost.Size = New System.Drawing.Size(211, 20)
        Me.txtNonQualifyingCost.TabIndex = 13
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(575, 208)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(128, 13)
        Me.LabelControl22.TabIndex = 219
        Me.LabelControl22.Text = "Non Qualifying Cost (RM) :"
        '
        'txtQualifyingCost
        '
        Me.txtQualifyingCost.Location = New System.Drawing.Point(733, 179)
        Me.txtQualifyingCost.Name = "txtQualifyingCost"
        Me.txtQualifyingCost.Properties.DisplayFormat.FormatString = "n"
        Me.txtQualifyingCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtQualifyingCost.Properties.Mask.EditMask = "n"
        Me.txtQualifyingCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtQualifyingCost.Properties.NullText = "0"
        Me.txtQualifyingCost.Properties.NullValuePrompt = "0"
        Me.txtQualifyingCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtQualifyingCost.Size = New System.Drawing.Size(211, 20)
        Me.txtQualifyingCost.TabIndex = 12
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(575, 182)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(106, 13)
        Me.LabelControl21.TabIndex = 217
        Me.LabelControl21.Text = "Qualifying Cost (RM) :"
        '
        'txtPurchaseAmount
        '
        Me.txtPurchaseAmount.Location = New System.Drawing.Point(733, 153)
        Me.txtPurchaseAmount.Name = "txtPurchaseAmount"
        Me.txtPurchaseAmount.Properties.DisplayFormat.FormatString = "n"
        Me.txtPurchaseAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPurchaseAmount.Properties.Mask.EditMask = "n"
        Me.txtPurchaseAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPurchaseAmount.Properties.NullText = "0"
        Me.txtPurchaseAmount.Properties.NullValuePrompt = "0"
        Me.txtPurchaseAmount.Properties.ReadOnly = True
        Me.txtPurchaseAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPurchaseAmount.Size = New System.Drawing.Size(211, 20)
        Me.txtPurchaseAmount.TabIndex = 11
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(575, 156)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(117, 13)
        Me.LabelControl20.TabIndex = 215
        Me.LabelControl20.Text = "Purchase Amount (RM) :"
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(575, 130)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl19.TabIndex = 214
        Me.LabelControl19.Text = "Incentive :"
        '
        'cboIncentive
        '
        Me.cboIncentive.Location = New System.Drawing.Point(733, 127)
        Me.cboIncentive.Name = "cboIncentive"
        Me.cboIncentive.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboIncentive.Properties.Items.AddRange(New Object() {"", "RA", "ITA"})
        Me.cboIncentive.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboIncentive.Size = New System.Drawing.Size(211, 20)
        Me.cboIncentive.TabIndex = 10
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(575, 104)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl18.TabIndex = 212
        Me.LabelControl18.Text = "AA Rate (%) :"
        '
        'txtIA
        '
        Me.txtIA.Location = New System.Drawing.Point(733, 75)
        Me.txtIA.Name = "txtIA"
        Me.txtIA.Properties.DisplayFormat.FormatString = "f0"
        Me.txtIA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtIA.Properties.EditFormat.FormatString = "f0"
        Me.txtIA.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtIA.Properties.Mask.EditMask = "f0"
        Me.txtIA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtIA.Properties.NullText = "0"
        Me.txtIA.Properties.NullValuePrompt = "0"
        Me.txtIA.Size = New System.Drawing.Size(211, 20)
        Me.txtIA.TabIndex = 8
        '
        'lblTitle_CA
        '
        Me.lblTitle_CA.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle_CA.Location = New System.Drawing.Point(575, 17)
        Me.lblTitle_CA.Name = "lblTitle_CA"
        Me.lblTitle_CA.Size = New System.Drawing.Size(337, 19)
        Me.lblTitle_CA.TabIndex = 210
        Me.lblTitle_CA.Text = "Capital Allowance Information (Addition)"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(575, 78)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl16.TabIndex = 209
        Me.LabelControl16.Text = "IA Rate (%) :"
        '
        'frmCA_Add3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 617)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmCA_Add3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capital Allowance"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtCompanyCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboHP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkREC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSourceCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTaxPayer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgTypeCA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPurchaseYE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkHP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCAEEO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.pnlControlTransfer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControlTransfer.ResumeLayout(False)
        Me.pnlControlTransfer.PerformLayout()
        CType(Me.txtTransferVal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransferorName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTaxFileNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.chkDeductAdjustIncome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDeferred.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkControlTransfer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAccelerated.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTWDV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemainingQualifyingCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNonQualifyingCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQualifyingCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPurchaseAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboIncentive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents TaxPayerFindBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsCA As EasyTemplate_Taxcom.dsCA
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboHP As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblHPCode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkREC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cboSourceCode As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboRefNo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtTaxPayer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboYA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgTypeCA As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents cboPurchaseYE As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkHP As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkCAEEO As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnlMain As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cboAA As DevExpress.XtraEditors.ComboBoxEdit
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
    Friend WithEvents chkDeductAdjustIncome As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkDeferred As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkControlTransfer As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAccelerated As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtTWDV As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRemainingQualifyingCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNonQualifyingCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQualifyingCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPurchaseAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboIncentive As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTitle_CA As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCategory As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents pnlControlTransfer As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtTransferVal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTransferorName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTaxFileNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFileNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCompanyCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnDuplicate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtDuplicateNo As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
