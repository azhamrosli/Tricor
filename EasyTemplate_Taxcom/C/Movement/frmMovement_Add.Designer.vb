<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovement_Add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovement_Add))
        Dim SuperToolTip7 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem7 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem7 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip8 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem8 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem8 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip9 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem9 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem9 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTitle = New DevExpress.XtraEditors.TextEdit()
        Me.dtStart = New DevExpress.XtraEditors.DateEdit()
        Me.dtEnded = New DevExpress.XtraEditors.DateEdit()
        Me.dtBalanceStart = New DevExpress.XtraEditors.DateEdit()
        Me.dtBalanceEnd = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.MOVEMENTADDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMovement = New EasyTemplate_Taxcom.dsMovement()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMM_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_Description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNote = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colMM_Amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAmount = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colMM_AddBack = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkAddBack = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colMM_AddBack_Amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.MOVEMENTDEDUCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colMM_DEDUCT_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TaxPayerFindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCA = New EasyTemplate_Taxcom.dsCA()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.cboYA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtRefNo = New DevExpress.XtraEditors.TextEdit()
        Me.txtNoteStart = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNoteEnd = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmountStart = New DevExpress.XtraEditors.TextEdit()
        Me.txtAmountEnd = New DevExpress.XtraEditors.TextEdit()
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
        Me.txtTotalAmount_AddbackDeduct = New DevExpress.XtraEditors.TextEdit()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.chkNonAllowableExpenses = New DevExpress.XtraEditors.CheckEdit()
        Me.chkTaxPositive = New DevExpress.XtraEditors.CheckEdit()
        Me.chkTaxNegative = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEnded.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEnded.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBalanceStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBalanceStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBalanceEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBalanceEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOVEMENTADDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMovement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAddBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOVEMENTDEDUCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoteStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoteEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmountStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmountEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalAmount_AddbackDeduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.chkNonAllowableExpenses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTaxPositive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTaxNegative.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnAdd.Id = 0
        Me.btnAdd.ImageOptions.Image = CType(resources.GetObject("btnAdd.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd.ImageOptions.LargeImage = CType(resources.GetObject("btnAdd.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAdd.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem7.Text = "Add new record"
        ToolTipItem7.LeftIndent = 6
        ToolTipItem7.Text = "Add new record Ctrl + R"
        SuperToolTip7.Items.Add(ToolTipTitleItem7)
        SuperToolTip7.Items.Add(ToolTipItem7)
        Me.btnAdd.SuperTip = SuperToolTip7
        '
        'btnAddChild
        '
        Me.btnAddChild.Caption = "Add"
        Me.btnAddChild.Id = 1
        Me.btnAddChild.ImageOptions.Image = CType(resources.GetObject("btnAddChild.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddChild.ImageOptions.LargeImage = CType(resources.GetObject("btnAddChild.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAddChild.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T))
        Me.btnAddChild.Name = "btnAddChild"
        Me.btnAddChild.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem8.Text = "Add new record"
        ToolTipItem8.LeftIndent = 6
        ToolTipItem8.Text = "Add new record Ctrl + T"
        SuperToolTip8.Items.Add(ToolTipTitleItem8)
        SuperToolTip8.Items.Add(ToolTipItem8)
        Me.btnAddChild.SuperTip = SuperToolTip8
        '
        'btnDelete
        '
        Me.btnDelete.Caption = "Delete"
        Me.btnDelete.Id = 4
        Me.btnDelete.ImageOptions.Image = CType(resources.GetObject("btnDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelete.ImageOptions.LargeImage = CType(resources.GetObject("btnDelete.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnDelete.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem9.Text = "Delete record"
        ToolTipItem9.LeftIndent = 6
        ToolTipItem9.Text = "Delete record Ctrl + Y"
        SuperToolTip9.Items.Add(ToolTipTitleItem9)
        SuperToolTip9.Items.Add(ToolTipItem9)
        Me.btnDelete.SuperTip = SuperToolTip9
        '
        'btnMoveUp
        '
        Me.btnMoveUp.Caption = "Move Up"
        Me.btnMoveUp.Id = 9
        Me.btnMoveUp.ImageOptions.Image = CType(resources.GetObject("btnMoveUp.ImageOptions.Image"), System.Drawing.Image)
        Me.btnMoveUp.ImageOptions.LargeImage = CType(resources.GetObject("btnMoveUp.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnMoveUp.Name = "btnMoveUp"
        Me.btnMoveUp.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnMoveDown
        '
        Me.btnMoveDown.Caption = "Move Down"
        Me.btnMoveDown.Id = 10
        Me.btnMoveDown.ImageOptions.Image = CType(resources.GetObject("btnMoveDown.ImageOptions.Image"), System.Drawing.Image)
        Me.btnMoveDown.ImageOptions.LargeImage = CType(resources.GetObject("btnMoveDown.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnMoveDown.Name = "btnMoveDown"
        Me.btnMoveDown.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1175, 39)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 700)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1175, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 39)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 661)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1175, 39)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 661)
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
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 148)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 16)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Title :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(462, 52)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(84, 16)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Period Ended :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(462, 84)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(74, 16)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Year Ended :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 215)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(85, 16)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Balance as at :"
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Location = New System.Drawing.Point(624, 220)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(53, 16)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "Amount :"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(110, 144)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTitle.MenuManager = Me.BarManager1
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(650, 22)
        Me.txtTitle.TabIndex = 2
        '
        'dtStart
        '
        Me.dtStart.EditValue = Nothing
        Me.dtStart.Location = New System.Drawing.Point(560, 48)
        Me.dtStart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtStart.MenuManager = Me.BarManager1
        Me.dtStart.Name = "dtStart"
        Me.dtStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtStart.Size = New System.Drawing.Size(199, 22)
        Me.dtStart.TabIndex = 3
        '
        'dtEnded
        '
        Me.dtEnded.EditValue = Nothing
        Me.dtEnded.Location = New System.Drawing.Point(560, 80)
        Me.dtEnded.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtEnded.MenuManager = Me.BarManager1
        Me.dtEnded.Name = "dtEnded"
        Me.dtEnded.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtEnded.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtEnded.Size = New System.Drawing.Size(199, 22)
        Me.dtEnded.TabIndex = 4
        '
        'dtBalanceStart
        '
        Me.dtBalanceStart.EditValue = Nothing
        Me.dtBalanceStart.Location = New System.Drawing.Point(110, 212)
        Me.dtBalanceStart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtBalanceStart.MenuManager = Me.BarManager1
        Me.dtBalanceStart.Name = "dtBalanceStart"
        Me.dtBalanceStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBalanceStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBalanceStart.Size = New System.Drawing.Size(199, 22)
        Me.dtBalanceStart.TabIndex = 5
        '
        'dtBalanceEnd
        '
        Me.dtBalanceEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtBalanceEnd.EditValue = Nothing
        Me.dtBalanceEnd.Location = New System.Drawing.Point(112, 666)
        Me.dtBalanceEnd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtBalanceEnd.MenuManager = Me.BarManager1
        Me.dtBalanceEnd.Name = "dtBalanceEnd"
        Me.dtBalanceEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBalanceEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBalanceEnd.Size = New System.Drawing.Size(199, 22)
        Me.dtBalanceEnd.TabIndex = 20
        '
        'LabelControl8
        '
        Me.LabelControl8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl8.Location = New System.Drawing.Point(626, 670)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(53, 16)
        Me.LabelControl8.TabIndex = 19
        Me.LabelControl8.Text = "Amount :"
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl9.Location = New System.Drawing.Point(14, 670)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(85, 16)
        Me.LabelControl9.TabIndex = 18
        Me.LabelControl9.Text = "Balance as at :"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.MOVEMENTADDBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Location = New System.Drawing.Point(0, 32)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtNote, Me.txtAmount, Me.chkAddBack})
        Me.GridControl1.Size = New System.Drawing.Size(1145, 129)
        Me.GridControl1.TabIndex = 8
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'MOVEMENTADDBindingSource
        '
        Me.MOVEMENTADDBindingSource.DataMember = "MOVEMENT_ADD"
        Me.MOVEMENTADDBindingSource.DataSource = Me.DsMovement
        '
        'DsMovement
        '
        Me.DsMovement.DataSetName = "dsMovement"
        Me.DsMovement.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMM_ID, Me.colMM_Description, Me.colMM_Amount, Me.colMM_AddBack, Me.colMM_AddBack_Amount})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'colMM_ID
        '
        Me.colMM_ID.FieldName = "MM_ID"
        Me.colMM_ID.Name = "colMM_ID"
        '
        'colMM_Description
        '
        Me.colMM_Description.Caption = "Description"
        Me.colMM_Description.ColumnEdit = Me.txtNote
        Me.colMM_Description.FieldName = "MM_Description"
        Me.colMM_Description.Name = "colMM_Description"
        Me.colMM_Description.Visible = True
        Me.colMM_Description.VisibleIndex = 0
        Me.colMM_Description.Width = 400
        '
        'txtNote
        '
        Me.txtNote.MaxLength = 3000
        Me.txtNote.Name = "txtNote"
        '
        'colMM_Amount
        '
        Me.colMM_Amount.Caption = "Amount"
        Me.colMM_Amount.ColumnEdit = Me.txtAmount
        Me.colMM_Amount.FieldName = "MM_Amount"
        Me.colMM_Amount.Name = "colMM_Amount"
        Me.colMM_Amount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MM_Amount", "SUM={0:0.##}")})
        Me.colMM_Amount.Visible = True
        Me.colMM_Amount.VisibleIndex = 1
        Me.colMM_Amount.Width = 209
        '
        'txtAmount
        '
        Me.txtAmount.AutoHeight = False
        Me.txtAmount.DisplayFormat.FormatString = "n0"
        Me.txtAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmount.EditFormat.FormatString = "n0"
        Me.txtAmount.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmount.Mask.EditMask = "n0"
        Me.txtAmount.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmount.Name = "txtAmount"
        '
        'colMM_AddBack
        '
        Me.colMM_AddBack.Caption = "Add  Back"
        Me.colMM_AddBack.ColumnEdit = Me.chkAddBack
        Me.colMM_AddBack.FieldName = "MM_AddBack"
        Me.colMM_AddBack.Name = "colMM_AddBack"
        Me.colMM_AddBack.Visible = True
        Me.colMM_AddBack.VisibleIndex = 2
        Me.colMM_AddBack.Width = 211
        '
        'chkAddBack
        '
        Me.chkAddBack.AutoHeight = False
        Me.chkAddBack.Caption = "Add Back"
        Me.chkAddBack.Name = "chkAddBack"
        Me.chkAddBack.ValueGrayed = True
        '
        'colMM_AddBack_Amount
        '
        Me.colMM_AddBack_Amount.Caption = "AddBack Amount"
        Me.colMM_AddBack_Amount.ColumnEdit = Me.txtAmount
        Me.colMM_AddBack_Amount.FieldName = "MM_ADDBACK_AMOUNT"
        Me.colMM_AddBack_Amount.Name = "colMM_AddBack_Amount"
        Me.colMM_AddBack_Amount.OptionsColumn.TabStop = False
        Me.colMM_AddBack_Amount.Visible = True
        Me.colMM_AddBack_Amount.VisibleIndex = 3
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.MOVEMENTDEDUCTBindingSource
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl2.MenuManager = Me.BarManager1
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemTextEdit3, Me.RepositoryItemCheckEdit1})
        Me.GridControl2.Size = New System.Drawing.Size(1145, 216)
        Me.GridControl2.TabIndex = 9
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'MOVEMENTDEDUCTBindingSource
        '
        Me.MOVEMENTDEDUCTBindingSource.AllowNew = True
        Me.MOVEMENTDEDUCTBindingSource.DataMember = "MOVEMENT_DEDUCT"
        Me.MOVEMENTDEDUCTBindingSource.DataSource = Me.DsMovement
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.colMM_DEDUCT_AMOUNT})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView2.OptionsView.RowAutoHeight = True
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "MM_ID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Description"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.GridColumn2.FieldName = "MM_Description"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 400
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.MaxLength = 3000
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Amount"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.GridColumn3.FieldName = "MM_Amount"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MM_Amount", "SUM={0:0.##}")})
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 209
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
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Deduct"
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn4.FieldName = "MM_Deduct"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 211
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Add Back"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueGrayed = True
        '
        'colMM_DEDUCT_AMOUNT
        '
        Me.colMM_DEDUCT_AMOUNT.Caption = "Deduct Amount"
        Me.colMM_DEDUCT_AMOUNT.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colMM_DEDUCT_AMOUNT.FieldName = "MM_DEDUCT_AMOUNT"
        Me.colMM_DEDUCT_AMOUNT.Name = "colMM_DEDUCT_AMOUNT"
        Me.colMM_DEDUCT_AMOUNT.OptionsColumn.TabStop = False
        Me.colMM_DEDUCT_AMOUNT.Visible = True
        Me.colMM_DEDUCT_AMOUNT.VisibleIndex = 3
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
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(12, 52)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(47, 16)
        Me.LabelControl10.TabIndex = 41
        Me.LabelControl10.Text = "Ref No :"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(12, 116)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(24, 16)
        Me.LabelControl11.TabIndex = 156
        Me.LabelControl11.Text = "YA :"
        '
        'cboYA
        '
        Me.cboYA.Location = New System.Drawing.Point(110, 112)
        Me.cboYA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboYA.Name = "cboYA"
        Me.cboYA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboYA.Properties.PopupSizeable = True
        Me.cboYA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboYA.Size = New System.Drawing.Size(327, 22)
        Me.cboYA.TabIndex = 1
        '
        'txtRefNo
        '
        Me.txtRefNo.Location = New System.Drawing.Point(110, 80)
        Me.txtRefNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRefNo.MenuManager = Me.BarManager1
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Properties.ReadOnly = True
        Me.txtRefNo.Size = New System.Drawing.Size(327, 22)
        Me.txtRefNo.TabIndex = 158
        '
        'txtNoteStart
        '
        Me.txtNoteStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoteStart.Location = New System.Drawing.Point(953, 217)
        Me.txtNoteStart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNoteStart.MenuManager = Me.BarManager1
        Me.txtNoteStart.Name = "txtNoteStart"
        Me.txtNoteStart.Size = New System.Drawing.Size(174, 22)
        Me.txtNoteStart.TabIndex = 7
        '
        'LabelControl13
        '
        Me.LabelControl13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl13.Location = New System.Drawing.Point(895, 220)
        Me.LabelControl13.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(35, 16)
        Me.LabelControl13.TabIndex = 163
        Me.LabelControl13.Text = "Note :"
        '
        'txtNoteEnd
        '
        Me.txtNoteEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoteEnd.Location = New System.Drawing.Point(955, 666)
        Me.txtNoteEnd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNoteEnd.MenuManager = Me.BarManager1
        Me.txtNoteEnd.Name = "txtNoteEnd"
        Me.txtNoteEnd.Size = New System.Drawing.Size(174, 22)
        Me.txtNoteEnd.TabIndex = 170
        '
        'LabelControl12
        '
        Me.LabelControl12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl12.Location = New System.Drawing.Point(897, 670)
        Me.LabelControl12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(35, 16)
        Me.LabelControl12.TabIndex = 169
        Me.LabelControl12.Text = "Note :"
        '
        'txtAmountStart
        '
        Me.txtAmountStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAmountStart.Location = New System.Drawing.Point(682, 217)
        Me.txtAmountStart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAmountStart.MenuManager = Me.BarManager1
        Me.txtAmountStart.Name = "txtAmountStart"
        Me.txtAmountStart.Properties.DisplayFormat.FormatString = "n0"
        Me.txtAmountStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountStart.Properties.EditFormat.FormatString = "n0"
        Me.txtAmountStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountStart.Properties.Mask.EditMask = "n0"
        Me.txtAmountStart.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmountStart.Properties.NullText = "0"
        Me.txtAmountStart.Properties.NullValuePrompt = "0"
        Me.txtAmountStart.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtAmountStart.Size = New System.Drawing.Size(174, 22)
        Me.txtAmountStart.TabIndex = 6
        '
        'txtAmountEnd
        '
        Me.txtAmountEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAmountEnd.Location = New System.Drawing.Point(685, 666)
        Me.txtAmountEnd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAmountEnd.MenuManager = Me.BarManager1
        Me.txtAmountEnd.Name = "txtAmountEnd"
        Me.txtAmountEnd.Properties.DisplayFormat.FormatString = "n0"
        Me.txtAmountEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountEnd.Properties.EditFormat.FormatString = "n0"
        Me.txtAmountEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountEnd.Properties.Mask.EditMask = "n0"
        Me.txtAmountEnd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmountEnd.Properties.NullText = "0"
        Me.txtAmountEnd.Properties.NullValuePrompt = "0"
        Me.txtAmountEnd.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtAmountEnd.Size = New System.Drawing.Size(174, 22)
        Me.txtAmountEnd.TabIndex = 175
        '
        'cboRefNo
        '
        Me.cboRefNo.Location = New System.Drawing.Point(110, 48)
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
        Me.cboRefNo.Size = New System.Drawing.Size(327, 22)
        Me.cboRefNo.TabIndex = 180
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
        'txtTotalAmount_AddbackDeduct
        '
        Me.txtTotalAmount_AddbackDeduct.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalAmount_AddbackDeduct.Location = New System.Drawing.Point(682, 185)
        Me.txtTotalAmount_AddbackDeduct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalAmount_AddbackDeduct.MenuManager = Me.BarManager1
        Me.txtTotalAmount_AddbackDeduct.Name = "txtTotalAmount_AddbackDeduct"
        Me.txtTotalAmount_AddbackDeduct.Properties.DisplayFormat.FormatString = "n0"
        Me.txtTotalAmount_AddbackDeduct.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalAmount_AddbackDeduct.Properties.EditFormat.FormatString = "n0"
        Me.txtTotalAmount_AddbackDeduct.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalAmount_AddbackDeduct.Properties.Mask.EditMask = "n0"
        Me.txtTotalAmount_AddbackDeduct.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalAmount_AddbackDeduct.Properties.NullText = "0"
        Me.txtTotalAmount_AddbackDeduct.Properties.NullValuePrompt = "0"
        Me.txtTotalAmount_AddbackDeduct.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtTotalAmount_AddbackDeduct.Size = New System.Drawing.Size(174, 22)
        Me.txtTotalAmount_AddbackDeduct.TabIndex = 186
        Me.txtTotalAmount_AddbackDeduct.Visible = False
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.SplitContainerControl1.CaptionLocation = DevExpress.Utils.Locations.Top
        Me.SplitContainerControl1.Collapsed = True
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(12, 249)
        Me.SplitContainerControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GridControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PanelControl1)
        Me.SplitContainerControl1.Panel1.ShowCaption = True
        Me.SplitContainerControl1.Panel1.Tag = "Add"
        Me.SplitContainerControl1.Panel1.Text = "Add"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.PanelControl2)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GridControl2)
        Me.SplitContainerControl1.Panel2.ShowCaption = True
        Me.SplitContainerControl1.Panel2.Tag = "Less"
        Me.SplitContainerControl1.Panel2.Text = "Less"
        Me.SplitContainerControl1.ShowCaption = True
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1149, 410)
        Me.SplitContainerControl1.SplitterPosition = 161
        Me.SplitContainerControl1.TabIndex = 191
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1145, 32)
        Me.PanelControl1.TabIndex = 10
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(10, 6)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(32, 19)
        Me.LabelControl6.TabIndex = 9
        Me.LabelControl6.Text = "Add"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl7)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1145, 32)
        Me.PanelControl2.TabIndex = 11
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(10, 6)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(35, 19)
        Me.LabelControl7.TabIndex = 9
        Me.LabelControl7.Text = "Less"
        '
        'chkNonAllowableExpenses
        '
        Me.chkNonAllowableExpenses.Location = New System.Drawing.Point(810, 51)
        Me.chkNonAllowableExpenses.MenuManager = Me.BarManager1
        Me.chkNonAllowableExpenses.Name = "chkNonAllowableExpenses"
        Me.chkNonAllowableExpenses.Properties.Caption = "Non Allowable Expenses"
        Me.chkNonAllowableExpenses.Size = New System.Drawing.Size(160, 20)
        Me.chkNonAllowableExpenses.TabIndex = 201
        '
        'chkTaxPositive
        '
        Me.chkTaxPositive.Location = New System.Drawing.Point(810, 77)
        Me.chkTaxPositive.MenuManager = Me.BarManager1
        Me.chkTaxPositive.Name = "chkTaxPositive"
        Me.chkTaxPositive.Properties.Appearance.Options.UseTextOptions = True
        Me.chkTaxPositive.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.chkTaxPositive.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.chkTaxPositive.Properties.AutoHeight = False
        Me.chkTaxPositive.Properties.Caption = "Taxable gain / must not entered in the P&&L but entered in the Balance Sheet. "
        Me.chkTaxPositive.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chkTaxPositive.Properties.GlyphVAlignment = DevExpress.Utils.VertAlignment.Top
        Me.chkTaxPositive.Size = New System.Drawing.Size(353, 37)
        Me.chkTaxPositive.TabIndex = 202
        '
        'chkTaxNegative
        '
        Me.chkTaxNegative.Location = New System.Drawing.Point(810, 120)
        Me.chkTaxNegative.MenuManager = Me.BarManager1
        Me.chkTaxNegative.Name = "chkTaxNegative"
        Me.chkTaxNegative.Properties.Appearance.Options.UseTextOptions = True
        Me.chkTaxNegative.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.chkTaxNegative.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.chkTaxNegative.Properties.AutoHeight = False
        Me.chkTaxNegative.Properties.Caption = "2.3 Allowable expenses not entered in P&&L (extracted from the  Balance Sheet)"
        Me.chkTaxNegative.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.chkTaxNegative.Properties.GlyphVAlignment = DevExpress.Utils.VertAlignment.Top
        Me.chkTaxNegative.Size = New System.Drawing.Size(353, 37)
        Me.chkTaxNegative.TabIndex = 207
        '
        'frmMovement_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 700)
        Me.Controls.Add(Me.chkTaxNegative)
        Me.Controls.Add(Me.chkTaxPositive)
        Me.Controls.Add(Me.chkNonAllowableExpenses)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.txtTotalAmount_AddbackDeduct)
        Me.Controls.Add(Me.cboRefNo)
        Me.Controls.Add(Me.txtAmountEnd)
        Me.Controls.Add(Me.txtNoteEnd)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.txtNoteStart)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.txtRefNo)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.cboYA)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.dtBalanceEnd)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtAmountStart)
        Me.Controls.Add(Me.dtBalanceStart)
        Me.Controls.Add(Me.dtEnded)
        Me.Controls.Add(Me.dtStart)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMovement_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movement Normal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEnded.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEnded.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBalanceStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBalanceStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBalanceEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBalanceEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOVEMENTADDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMovement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAddBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOVEMENTDEDUCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoteStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoteEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmountStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmountEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalAmount_AddbackDeduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.chkNonAllowableExpenses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTaxPositive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTaxNegative.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents dtBalanceEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtBalanceStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtEnded As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MOVEMENTADDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsMovement As EasyTemplate_Taxcom.dsMovement
    Friend WithEvents colMM_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_Description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNote As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colMM_Amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAmount As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colMM_AddBack As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkAddBack As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents MOVEMENTDEDUCTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRefNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboYA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtNoteStart As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNoteEnd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TaxPayerFindBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsCA As EasyTemplate_Taxcom.dsCA
    Friend WithEvents txtAmountEnd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAmountStart As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents colMM_DEDUCT_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_AddBack_Amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTotalAmount_AddbackDeduct As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkTaxPositive As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkNonAllowableExpenses As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkTaxNegative As DevExpress.XtraEditors.CheckEdit
End Class
