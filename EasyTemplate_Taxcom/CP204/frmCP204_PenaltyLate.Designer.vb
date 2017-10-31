<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCP204_PenaltyLate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCP204_PenaltyLate))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.txtRefNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.cboYA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.cboRefNo = New DevExpress.XtraEditors.LookUpEdit()
        Me.TaxPayerFindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCA = New EasyTemplate_Taxcom.dsCA()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddChild = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMoveUp = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMoveDown = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.dtBasisStart = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.dtBasisEnd = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotalBasisPeriod = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BORANGCP204TRICORBREAKDOWNBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCP204 = New EasyTemplate_Taxcom.dsCP204()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCP_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCP_PARENTID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCP_INSTALL_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCP_PAYMENT_DUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colCP_INSTALLMENT_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colCP_PAYMENT_DATE_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCP_AMOUNT_PAID_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCP_PAYMENT_DATE_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCP_AMOUNT_PAID_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCP_PENALTY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCP_NOTE_TITLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCP_NOTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNote = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.chkAddBack = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBasisStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBasisStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBasisEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBasisEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalBasisPeriod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BORANGCP204TRICORBREAKDOWNBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCP204, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAddBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRefNo
        '
        Me.txtRefNo.Location = New System.Drawing.Point(132, 75)
        Me.txtRefNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Properties.ReadOnly = True
        Me.txtRefNo.Size = New System.Drawing.Size(306, 22)
        Me.txtRefNo.TabIndex = 163
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(452, 49)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(24, 16)
        Me.LabelControl11.TabIndex = 162
        Me.LabelControl11.Text = "YA :"
        '
        'cboYA
        '
        Me.cboYA.Location = New System.Drawing.Point(550, 45)
        Me.cboYA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboYA.Name = "cboYA"
        Me.cboYA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboYA.Properties.PopupSizeable = True
        Me.cboYA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboYA.Size = New System.Drawing.Size(327, 22)
        Me.cboYA.TabIndex = 160
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(12, 48)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(47, 16)
        Me.LabelControl10.TabIndex = 161
        Me.LabelControl10.Text = "Ref No :"
        '
        'cboRefNo
        '
        Me.cboRefNo.Location = New System.Drawing.Point(132, 45)
        Me.cboRefNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboRefNo.Name = "cboRefNo"
        Me.cboRefNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRefNo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RefNo", "Ref No", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Company Name", 500, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyNo", "Company No", 71, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployerNo", "Employer No", 70, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FileNo", "File No", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Country", "Country", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyCode", "Company Code", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboRefNo.Properties.DataSource = Me.TaxPayerFindBindingSource
        Me.cboRefNo.Properties.DisplayMember = "CompanyName"
        Me.cboRefNo.Properties.NullText = "Select"
        Me.cboRefNo.Properties.PopupFormMinSize = New System.Drawing.Size(600, 0)
        Me.cboRefNo.Properties.ValueMember = "RefNo"
        Me.cboRefNo.Size = New System.Drawing.Size(307, 22)
        Me.cboRefNo.TabIndex = 159
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
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnAdd, Me.btnAddChild, Me.btnDelete, Me.btnMoveUp, Me.btnMoveDown})
        Me.BarManager1.MaxItemId = 11
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(271, 130)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.btnAddChild), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.btnMoveUp), New DevExpress.XtraBars.LinkPersistInfo(Me.btnMoveDown)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DisableClose = True
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'btnAdd
        '
        Me.btnAdd.Caption = "Save"
        Me.btnAdd.Glyph = CType(resources.GetObject("btnAdd.Glyph"), System.Drawing.Image)
        Me.btnAdd.Id = 0
        Me.btnAdd.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
        Me.btnAdd.LargeGlyph = CType(resources.GetObject("btnAdd.LargeGlyph"), System.Drawing.Image)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem1.Text = "Add new record"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Add new record Ctrl + R"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btnAdd.SuperTip = SuperToolTip1
        '
        'btnAddChild
        '
        Me.btnAddChild.Caption = "Add"
        Me.btnAddChild.Glyph = CType(resources.GetObject("btnAddChild.Glyph"), System.Drawing.Image)
        Me.btnAddChild.Id = 1
        Me.btnAddChild.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T))
        Me.btnAddChild.LargeGlyph = CType(resources.GetObject("btnAddChild.LargeGlyph"), System.Drawing.Image)
        Me.btnAddChild.Name = "btnAddChild"
        Me.btnAddChild.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem2.Text = "Add new record"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Add new record Ctrl + T"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.btnAddChild.SuperTip = SuperToolTip2
        '
        'btnDelete
        '
        Me.btnDelete.Caption = "Delete"
        Me.btnDelete.Glyph = CType(resources.GetObject("btnDelete.Glyph"), System.Drawing.Image)
        Me.btnDelete.Id = 4
        Me.btnDelete.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete)
        Me.btnDelete.LargeGlyph = CType(resources.GetObject("btnDelete.LargeGlyph"), System.Drawing.Image)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem3.Text = "Delete record"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Delete record Ctrl + Y"
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.btnDelete.SuperTip = SuperToolTip3
        '
        'btnMoveUp
        '
        Me.btnMoveUp.Caption = "Move Up"
        Me.btnMoveUp.Glyph = CType(resources.GetObject("btnMoveUp.Glyph"), System.Drawing.Image)
        Me.btnMoveUp.Id = 9
        Me.btnMoveUp.LargeGlyph = CType(resources.GetObject("btnMoveUp.LargeGlyph"), System.Drawing.Image)
        Me.btnMoveUp.Name = "btnMoveUp"
        Me.btnMoveUp.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnMoveDown
        '
        Me.btnMoveDown.Caption = "Move Down"
        Me.btnMoveDown.Glyph = CType(resources.GetObject("btnMoveDown.Glyph"), System.Drawing.Image)
        Me.btnMoveDown.Id = 10
        Me.btnMoveDown.LargeGlyph = CType(resources.GetObject("btnMoveDown.LargeGlyph"), System.Drawing.Image)
        Me.btnMoveDown.Name = "btnMoveDown"
        Me.btnMoveDown.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1086, 37)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 684)
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1086, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 37)
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 647)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1086, 37)
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 647)
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatString = "n"
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        Me.RepositoryItemTextEdit2.ReadOnly = True
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(132, 104)
        Me.txtAmount.MenuManager = Me.BarManager1
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Properties.DisplayFormat.FormatString = "n2"
        Me.txtAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmount.Properties.Mask.EditMask = "n2"
        Me.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmount.Size = New System.Drawing.Size(199, 22)
        Me.txtAmount.TabIndex = 173
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 107)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(53, 16)
        Me.LabelControl1.TabIndex = 174
        Me.LabelControl1.Text = "Amount :"
        '
        'dtBasisStart
        '
        Me.dtBasisStart.EditValue = Nothing
        Me.dtBasisStart.Location = New System.Drawing.Point(572, 107)
        Me.dtBasisStart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtBasisStart.MenuManager = Me.BarManager1
        Me.dtBasisStart.Name = "dtBasisStart"
        Me.dtBasisStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBasisStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBasisStart.Properties.ReadOnly = True
        Me.dtBasisStart.Size = New System.Drawing.Size(199, 22)
        Me.dtBasisStart.TabIndex = 181
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(452, 110)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(110, 16)
        Me.LabelControl2.TabIndex = 182
        Me.LabelControl2.Text = "Basis Period Start :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(452, 140)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(103, 16)
        Me.LabelControl3.TabIndex = 184
        Me.LabelControl3.Text = "Basis Period End :"
        '
        'dtBasisEnd
        '
        Me.dtBasisEnd.EditValue = Nothing
        Me.dtBasisEnd.Location = New System.Drawing.Point(572, 137)
        Me.dtBasisEnd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtBasisEnd.MenuManager = Me.BarManager1
        Me.dtBasisEnd.Name = "dtBasisEnd"
        Me.dtBasisEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBasisEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBasisEnd.Properties.ReadOnly = True
        Me.dtBasisEnd.Size = New System.Drawing.Size(199, 22)
        Me.dtBasisEnd.TabIndex = 183
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 140)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(111, 16)
        Me.LabelControl4.TabIndex = 186
        Me.LabelControl4.Text = "Total Basis Period :"
        '
        'txtTotalBasisPeriod
        '
        Me.txtTotalBasisPeriod.Location = New System.Drawing.Point(132, 137)
        Me.txtTotalBasisPeriod.MenuManager = Me.BarManager1
        Me.txtTotalBasisPeriod.Name = "txtTotalBasisPeriod"
        Me.txtTotalBasisPeriod.Properties.DisplayFormat.FormatString = "n0"
        Me.txtTotalBasisPeriod.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalBasisPeriod.Properties.Mask.EditMask = "n0"
        Me.txtTotalBasisPeriod.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalBasisPeriod.Properties.ReadOnly = True
        Me.txtTotalBasisPeriod.Size = New System.Drawing.Size(199, 22)
        Me.txtTotalBasisPeriod.TabIndex = 185
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.BORANGCP204TRICORBREAKDOWNBindingSource
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Location = New System.Drawing.Point(12, 167)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtNote, Me.RepositoryItemTextEdit3, Me.chkAddBack, Me.cboDate})
        Me.GridControl1.Size = New System.Drawing.Size(1062, 504)
        Me.GridControl1.TabIndex = 191
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'BORANGCP204TRICORBREAKDOWNBindingSource
        '
        Me.BORANGCP204TRICORBREAKDOWNBindingSource.DataMember = "BORANG_CP204_TRICOR_BREAKDOWN"
        Me.BORANGCP204TRICORBREAKDOWNBindingSource.DataSource = Me.DsCP204
        '
        'DsCP204
        '
        Me.DsCP204.DataSetName = "dsCP204"
        Me.DsCP204.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCP_ID, Me.colCP_PARENTID, Me.colCP_INSTALL_NO, Me.colCP_PAYMENT_DUE, Me.colCP_INSTALLMENT_AMOUNT, Me.colCP_PAYMENT_DATE_1, Me.colCP_AMOUNT_PAID_1, Me.colCP_PAYMENT_DATE_2, Me.colCP_AMOUNT_PAID_2, Me.colCP_PENALTY, Me.colCP_NOTE_TITLE, Me.colCP_NOTE})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'colCP_ID
        '
        Me.colCP_ID.FieldName = "CP_ID"
        Me.colCP_ID.Name = "colCP_ID"
        '
        'colCP_PARENTID
        '
        Me.colCP_PARENTID.FieldName = "CP_PARENTID"
        Me.colCP_PARENTID.Name = "colCP_PARENTID"
        '
        'colCP_INSTALL_NO
        '
        Me.colCP_INSTALL_NO.Caption = "Install No"
        Me.colCP_INSTALL_NO.FieldName = "CP_INSTALL_NO"
        Me.colCP_INSTALL_NO.Name = "colCP_INSTALL_NO"
        Me.colCP_INSTALL_NO.OptionsColumn.AllowEdit = False
        Me.colCP_INSTALL_NO.OptionsColumn.TabStop = False
        Me.colCP_INSTALL_NO.Visible = True
        Me.colCP_INSTALL_NO.VisibleIndex = 0
        Me.colCP_INSTALL_NO.Width = 80
        '
        'colCP_PAYMENT_DUE
        '
        Me.colCP_PAYMENT_DUE.Caption = "Payment Due"
        Me.colCP_PAYMENT_DUE.ColumnEdit = Me.cboDate
        Me.colCP_PAYMENT_DUE.FieldName = "CP_PAYMENT_DUE"
        Me.colCP_PAYMENT_DUE.Name = "colCP_PAYMENT_DUE"
        Me.colCP_PAYMENT_DUE.Visible = True
        Me.colCP_PAYMENT_DUE.VisibleIndex = 1
        Me.colCP_PAYMENT_DUE.Width = 120
        '
        'cboDate
        '
        Me.cboDate.AutoHeight = False
        Me.cboDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDate.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDate.Name = "cboDate"
        '
        'colCP_INSTALLMENT_AMOUNT
        '
        Me.colCP_INSTALLMENT_AMOUNT.Caption = "Installment Amount (RM)"
        Me.colCP_INSTALLMENT_AMOUNT.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colCP_INSTALLMENT_AMOUNT.FieldName = "CP_INSTALLMENT_AMOUNT"
        Me.colCP_INSTALLMENT_AMOUNT.Name = "colCP_INSTALLMENT_AMOUNT"
        Me.colCP_INSTALLMENT_AMOUNT.OptionsColumn.AllowEdit = False
        Me.colCP_INSTALLMENT_AMOUNT.OptionsColumn.TabStop = False
        Me.colCP_INSTALLMENT_AMOUNT.Visible = True
        Me.colCP_INSTALLMENT_AMOUNT.VisibleIndex = 2
        Me.colCP_INSTALLMENT_AMOUNT.Width = 150
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatString = "n0"
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit3.EditFormat.FormatString = "n0"
        Me.RepositoryItemTextEdit3.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit3.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'colCP_PAYMENT_DATE_1
        '
        Me.colCP_PAYMENT_DATE_1.Caption = "Payment Date 1"
        Me.colCP_PAYMENT_DATE_1.ColumnEdit = Me.cboDate
        Me.colCP_PAYMENT_DATE_1.FieldName = "CP_PAYMENT_DATE_1"
        Me.colCP_PAYMENT_DATE_1.Name = "colCP_PAYMENT_DATE_1"
        Me.colCP_PAYMENT_DATE_1.Visible = True
        Me.colCP_PAYMENT_DATE_1.VisibleIndex = 3
        Me.colCP_PAYMENT_DATE_1.Width = 120
        '
        'colCP_AMOUNT_PAID_1
        '
        Me.colCP_AMOUNT_PAID_1.Caption = "Amount Paid (RM)"
        Me.colCP_AMOUNT_PAID_1.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colCP_AMOUNT_PAID_1.FieldName = "CP_AMOUNT_PAID_1"
        Me.colCP_AMOUNT_PAID_1.Name = "colCP_AMOUNT_PAID_1"
        Me.colCP_AMOUNT_PAID_1.Visible = True
        Me.colCP_AMOUNT_PAID_1.VisibleIndex = 4
        Me.colCP_AMOUNT_PAID_1.Width = 150
        '
        'colCP_PAYMENT_DATE_2
        '
        Me.colCP_PAYMENT_DATE_2.Caption = "Payment Date 2"
        Me.colCP_PAYMENT_DATE_2.ColumnEdit = Me.cboDate
        Me.colCP_PAYMENT_DATE_2.FieldName = "CP_PAYMENT_DATE_2"
        Me.colCP_PAYMENT_DATE_2.Name = "colCP_PAYMENT_DATE_2"
        Me.colCP_PAYMENT_DATE_2.Visible = True
        Me.colCP_PAYMENT_DATE_2.VisibleIndex = 5
        Me.colCP_PAYMENT_DATE_2.Width = 120
        '
        'colCP_AMOUNT_PAID_2
        '
        Me.colCP_AMOUNT_PAID_2.Caption = "Amount Paid (RM)"
        Me.colCP_AMOUNT_PAID_2.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colCP_AMOUNT_PAID_2.FieldName = "CP_AMOUNT_PAID_2"
        Me.colCP_AMOUNT_PAID_2.Name = "colCP_AMOUNT_PAID_2"
        Me.colCP_AMOUNT_PAID_2.Visible = True
        Me.colCP_AMOUNT_PAID_2.VisibleIndex = 6
        Me.colCP_AMOUNT_PAID_2.Width = 150
        '
        'colCP_PENALTY
        '
        Me.colCP_PENALTY.Caption = "Penalty (RM)"
        Me.colCP_PENALTY.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colCP_PENALTY.FieldName = "CP_PENALTY"
        Me.colCP_PENALTY.Name = "colCP_PENALTY"
        Me.colCP_PENALTY.OptionsColumn.AllowEdit = False
        Me.colCP_PENALTY.OptionsColumn.TabStop = False
        Me.colCP_PENALTY.Visible = True
        Me.colCP_PENALTY.VisibleIndex = 7
        Me.colCP_PENALTY.Width = 150
        '
        'colCP_NOTE_TITLE
        '
        Me.colCP_NOTE_TITLE.Caption = "Note Title"
        Me.colCP_NOTE_TITLE.FieldName = "CP_NOTE_TITLE"
        Me.colCP_NOTE_TITLE.Name = "colCP_NOTE_TITLE"
        Me.colCP_NOTE_TITLE.Visible = True
        Me.colCP_NOTE_TITLE.VisibleIndex = 8
        Me.colCP_NOTE_TITLE.Width = 200
        '
        'colCP_NOTE
        '
        Me.colCP_NOTE.Caption = "Note"
        Me.colCP_NOTE.FieldName = "CP_NOTE"
        Me.colCP_NOTE.Name = "colCP_NOTE"
        Me.colCP_NOTE.Visible = True
        Me.colCP_NOTE.VisibleIndex = 9
        Me.colCP_NOTE.Width = 350
        '
        'txtNote
        '
        Me.txtNote.MaxLength = 3000
        Me.txtNote.Name = "txtNote"
        '
        'chkAddBack
        '
        Me.chkAddBack.AutoHeight = False
        Me.chkAddBack.Caption = "Add Back"
        Me.chkAddBack.Name = "chkAddBack"
        Me.chkAddBack.ValueGrayed = True
        '
        'frmCP204_PenaltyLate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 684)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtTotalBasisPeriod)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.dtBasisEnd)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.dtBasisStart)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtRefNo)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.cboYA)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.cboRefNo)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCP204_PenaltyLate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CP204 Penalty on Late Payment of Tax Instalments"
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBasisStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBasisStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBasisEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBasisEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalBasisPeriod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BORANGCP204TRICORBREAKDOWNBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCP204, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAddBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRefNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboYA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboRefNo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddChild As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMoveUp As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMoveDown As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TaxPayerFindBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsCA As EasyTemplate_Taxcom.dsCA
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtBasisEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtBasisStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalBasisPeriod As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents BORANGCP204TRICORBREAKDOWNBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsCP204 As EasyTemplate_Taxcom.dsCP204
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCP_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCP_PARENTID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCP_INSTALL_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCP_PAYMENT_DUE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colCP_INSTALLMENT_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colCP_PAYMENT_DATE_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCP_AMOUNT_PAID_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCP_PAYMENT_DATE_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCP_AMOUNT_PAID_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCP_PENALTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCP_NOTE_TITLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCP_NOTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNote As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents chkAddBack As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
