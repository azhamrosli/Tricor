<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovementComplex_Add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovementComplex_Add))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
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
        Me.TaxPayerFindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCA = New EasyTemplate_Taxcom.dsCA()
        Me.MOVEMENTCOMPLEXADDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMovement = New EasyTemplate_Taxcom.dsMovement()
        Me.MOVEMENTCOMPLEXDEDUCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.XtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.RGType = New DevExpress.XtraEditors.RadioGroup()
        Me.txtTotal_AddBackDeduct = New DevExpress.XtraEditors.TextEdit()
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
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMM_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_PARENTID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_Sequence = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_Description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNote = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colMM_Amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAmount = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colMM_GENERAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_GENERAL_ADDBACK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkAddBack = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colMM_SPECIFIC_ALLOWABLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_SPECIFIC_ALLOWABLE_ADDBACK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_SPECIFIC_NONALLOWABLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_SPECIFIC_NONALLOWABLE_ADDBACK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_ADDBACK_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_NOTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMM_ID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_PARENTID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_Sequence1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_Description1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colMM_Amount1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colMM_GENERAL1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_GENERAL_DEDUCT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colMM_SPECIFIC_ALLOWABLE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_SPECIFIC_ALLOWABLE_DEDUCT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_SPECIFIC_NONALLOWABLE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_SPECIFIC_NONALLOWABLE_DEDUCT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_DEDUCT_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_NOTE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmountSpecificNonAllow_End = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmountSpecificAllow_End = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmountGeneral_End = New DevExpress.XtraEditors.TextEdit()
        Me.txtNoteEnd = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.dtBalanceEnd = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmountSpecificNonAllow = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmountSpecificAllow = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmountGeneral = New DevExpress.XtraEditors.TextEdit()
        Me.txtNoteStart = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRefNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.cboYA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.dtBalanceStart = New DevExpress.XtraEditors.DateEdit()
        Me.txtTitle = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cboType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dtEnded = New DevExpress.XtraEditors.DateEdit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOVEMENTCOMPLEXADDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMovement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOVEMENTCOMPLEXDEDUCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraScrollableControl1.SuspendLayout()
        CType(Me.RGType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal_AddBackDeduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAddBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtAmountSpecificNonAllow_End.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmountSpecificAllow_End.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmountGeneral_End.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoteEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBalanceEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBalanceEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtAmountSpecificNonAllow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmountSpecificAllow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmountGeneral.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoteStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBalanceStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBalanceStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEnded.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEnded.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnAddChild.Id = 1
        Me.btnAddChild.ImageOptions.Image = CType(resources.GetObject("btnAddChild.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddChild.ImageOptions.LargeImage = CType(resources.GetObject("btnAddChild.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAddChild.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T))
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
        Me.btnDelete.Id = 4
        Me.btnDelete.ImageOptions.Image = CType(resources.GetObject("btnDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelete.ImageOptions.LargeImage = CType(resources.GetObject("btnDelete.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnDelete.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete)
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1323, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 777)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1323, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 746)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1323, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 746)
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
        'MOVEMENTCOMPLEXADDBindingSource
        '
        Me.MOVEMENTCOMPLEXADDBindingSource.DataMember = "MOVEMENT_COMPLEX_ADD"
        Me.MOVEMENTCOMPLEXADDBindingSource.DataSource = Me.DsMovement
        '
        'DsMovement
        '
        Me.DsMovement.DataSetName = "dsMovement"
        Me.DsMovement.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MOVEMENTCOMPLEXDEDUCTBindingSource
        '
        Me.MOVEMENTCOMPLEXDEDUCTBindingSource.DataMember = "MOVEMENT_COMPLEX_DEDUCT"
        Me.MOVEMENTCOMPLEXDEDUCTBindingSource.DataSource = Me.DsMovement
        '
        'XtraScrollableControl1
        '
        Me.XtraScrollableControl1.Controls.Add(Me.cboType)
        Me.XtraScrollableControl1.Controls.Add(Me.dtEnded)
        Me.XtraScrollableControl1.Controls.Add(Me.RGType)
        Me.XtraScrollableControl1.Controls.Add(Me.txtTotal_AddBackDeduct)
        Me.XtraScrollableControl1.Controls.Add(Me.cboRefNo)
        Me.XtraScrollableControl1.Controls.Add(Me.SplitContainerControl1)
        Me.XtraScrollableControl1.Controls.Add(Me.PanelControl2)
        Me.XtraScrollableControl1.Controls.Add(Me.txtNoteEnd)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl17)
        Me.XtraScrollableControl1.Controls.Add(Me.dtBalanceEnd)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl18)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl8)
        Me.XtraScrollableControl1.Controls.Add(Me.PanelControl1)
        Me.XtraScrollableControl1.Controls.Add(Me.txtNoteStart)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl13)
        Me.XtraScrollableControl1.Controls.Add(Me.txtRefNo)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl11)
        Me.XtraScrollableControl1.Controls.Add(Me.cboYA)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl10)
        Me.XtraScrollableControl1.Controls.Add(Me.dtBalanceStart)
        Me.XtraScrollableControl1.Controls.Add(Me.txtTitle)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl4)
        Me.XtraScrollableControl1.Controls.Add(Me.LabelControl1)
        Me.XtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraScrollableControl1.Location = New System.Drawing.Point(0, 31)
        Me.XtraScrollableControl1.Name = "XtraScrollableControl1"
        Me.XtraScrollableControl1.Size = New System.Drawing.Size(1323, 746)
        Me.XtraScrollableControl1.TabIndex = 210
        '
        'RGType
        '
        Me.RGType.EditValue = False
        Me.RGType.Location = New System.Drawing.Point(680, 6)
        Me.RGType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RGType.MenuManager = Me.BarManager1
        Me.RGType.Name = "RGType"
        Me.RGType.Properties.Appearance.Options.UseTextOptions = True
        Me.RGType.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.RGType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "None"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Non Allowable Expenses"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Taxable gain /Income not entered in the Profit and Loss Account but entered in th" & _
                    "e Balance Sheet"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Allowable expenses not entered not in the Profit and Loss Account (extracted from" & _
                    " the Balance Sheet)")})
        Me.RGType.Size = New System.Drawing.Size(493, 110)
        Me.RGType.TabIndex = 234
        '
        'txtTotal_AddBackDeduct
        '
        Me.txtTotal_AddBackDeduct.Location = New System.Drawing.Point(283, 674)
        Me.txtTotal_AddBackDeduct.MenuManager = Me.BarManager1
        Me.txtTotal_AddBackDeduct.Name = "txtTotal_AddBackDeduct"
        Me.txtTotal_AddBackDeduct.Properties.DisplayFormat.FormatString = "n0"
        Me.txtTotal_AddBackDeduct.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotal_AddBackDeduct.Properties.EditFormat.FormatString = "n0"
        Me.txtTotal_AddBackDeduct.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotal_AddBackDeduct.Properties.Mask.EditMask = "n0"
        Me.txtTotal_AddBackDeduct.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotal_AddBackDeduct.Properties.NullText = "0"
        Me.txtTotal_AddBackDeduct.Properties.NullValuePrompt = "0"
        Me.txtTotal_AddBackDeduct.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtTotal_AddBackDeduct.Properties.ReadOnly = True
        Me.txtTotal_AddBackDeduct.Size = New System.Drawing.Size(149, 20)
        Me.txtTotal_AddBackDeduct.TabIndex = 187
        Me.txtTotal_AddBackDeduct.Visible = False
        '
        'cboRefNo
        '
        Me.cboRefNo.Location = New System.Drawing.Point(96, 6)
        Me.cboRefNo.MenuManager = Me.BarManager1
        Me.cboRefNo.Name = "cboRefNo"
        Me.cboRefNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRefNo.Properties.DataSource = Me.TaxPayerFindBindingSource
        Me.cboRefNo.Properties.DisplayMember = "CompanyName"
        Me.cboRefNo.Properties.NullText = "Select"
        Me.cboRefNo.Properties.PopupFormMinSize = New System.Drawing.Size(600, 0)
        Me.cboRefNo.Properties.ValueMember = "RefNo"
        Me.cboRefNo.Properties.View = Me.SearchLookUpEdit2View
        Me.cboRefNo.Size = New System.Drawing.Size(280, 20)
        Me.cboRefNo.TabIndex = 233
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
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(12, 221)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GridControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PanelControl3)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GridControl2)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.PanelControl4)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1293, 450)
        Me.SplitContainerControl1.SplitterPosition = 162
        Me.SplitContainerControl1.TabIndex = 232
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.MOVEMENTCOMPLEXADDBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 23)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtNote, Me.txtAmount, Me.chkAddBack})
        Me.GridControl1.Size = New System.Drawing.Size(1293, 139)
        Me.GridControl1.TabIndex = 9
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMM_ID, Me.colMM_PARENTID, Me.colMM_Sequence, Me.colMM_Description, Me.colMM_Amount, Me.colMM_GENERAL, Me.colMM_GENERAL_ADDBACK, Me.colMM_SPECIFIC_ALLOWABLE, Me.colMM_SPECIFIC_ALLOWABLE_ADDBACK, Me.colMM_SPECIFIC_NONALLOWABLE, Me.colMM_SPECIFIC_NONALLOWABLE_ADDBACK, Me.colMM_ADDBACK_AMOUNT, Me.colMM_NOTE})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'colMM_ID
        '
        Me.colMM_ID.FieldName = "MM_ID"
        Me.colMM_ID.Name = "colMM_ID"
        '
        'colMM_PARENTID
        '
        Me.colMM_PARENTID.FieldName = "MM_PARENTID"
        Me.colMM_PARENTID.Name = "colMM_PARENTID"
        '
        'colMM_Sequence
        '
        Me.colMM_Sequence.FieldName = "MM_Sequence"
        Me.colMM_Sequence.Name = "colMM_Sequence"
        '
        'colMM_Description
        '
        Me.colMM_Description.Caption = "Description"
        Me.colMM_Description.ColumnEdit = Me.txtNote
        Me.colMM_Description.FieldName = "MM_Description"
        Me.colMM_Description.Name = "colMM_Description"
        Me.colMM_Description.Visible = True
        Me.colMM_Description.VisibleIndex = 0
        Me.colMM_Description.Width = 300
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
        Me.colMM_Amount.OptionsColumn.AllowEdit = False
        Me.colMM_Amount.OptionsColumn.TabStop = False
        Me.colMM_Amount.Visible = True
        Me.colMM_Amount.VisibleIndex = 1
        Me.colMM_Amount.Width = 120
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
        'colMM_GENERAL
        '
        Me.colMM_GENERAL.Caption = "General"
        Me.colMM_GENERAL.ColumnEdit = Me.txtAmount
        Me.colMM_GENERAL.FieldName = "MM_GENERAL"
        Me.colMM_GENERAL.Name = "colMM_GENERAL"
        Me.colMM_GENERAL.Visible = True
        Me.colMM_GENERAL.VisibleIndex = 2
        Me.colMM_GENERAL.Width = 120
        '
        'colMM_GENERAL_ADDBACK
        '
        Me.colMM_GENERAL_ADDBACK.Caption = "Add Back"
        Me.colMM_GENERAL_ADDBACK.ColumnEdit = Me.chkAddBack
        Me.colMM_GENERAL_ADDBACK.FieldName = "MM_GENERAL_ADDBACK"
        Me.colMM_GENERAL_ADDBACK.Name = "colMM_GENERAL_ADDBACK"
        Me.colMM_GENERAL_ADDBACK.Visible = True
        Me.colMM_GENERAL_ADDBACK.VisibleIndex = 3
        Me.colMM_GENERAL_ADDBACK.Width = 120
        '
        'chkAddBack
        '
        Me.chkAddBack.AutoHeight = False
        Me.chkAddBack.Caption = "Add Back"
        Me.chkAddBack.Name = "chkAddBack"
        Me.chkAddBack.ValueGrayed = True
        '
        'colMM_SPECIFIC_ALLOWABLE
        '
        Me.colMM_SPECIFIC_ALLOWABLE.Caption = "Specific (Allowable)"
        Me.colMM_SPECIFIC_ALLOWABLE.ColumnEdit = Me.txtAmount
        Me.colMM_SPECIFIC_ALLOWABLE.FieldName = "MM_SPECIFIC_ALLOWABLE"
        Me.colMM_SPECIFIC_ALLOWABLE.Name = "colMM_SPECIFIC_ALLOWABLE"
        Me.colMM_SPECIFIC_ALLOWABLE.Visible = True
        Me.colMM_SPECIFIC_ALLOWABLE.VisibleIndex = 4
        Me.colMM_SPECIFIC_ALLOWABLE.Width = 120
        '
        'colMM_SPECIFIC_ALLOWABLE_ADDBACK
        '
        Me.colMM_SPECIFIC_ALLOWABLE_ADDBACK.Caption = "Add Back"
        Me.colMM_SPECIFIC_ALLOWABLE_ADDBACK.ColumnEdit = Me.chkAddBack
        Me.colMM_SPECIFIC_ALLOWABLE_ADDBACK.FieldName = "MM_SPECIFIC_ALLOWABLE_ADDBACK"
        Me.colMM_SPECIFIC_ALLOWABLE_ADDBACK.Name = "colMM_SPECIFIC_ALLOWABLE_ADDBACK"
        Me.colMM_SPECIFIC_ALLOWABLE_ADDBACK.Visible = True
        Me.colMM_SPECIFIC_ALLOWABLE_ADDBACK.VisibleIndex = 5
        Me.colMM_SPECIFIC_ALLOWABLE_ADDBACK.Width = 120
        '
        'colMM_SPECIFIC_NONALLOWABLE
        '
        Me.colMM_SPECIFIC_NONALLOWABLE.Caption = "Specific (Non Allowable)"
        Me.colMM_SPECIFIC_NONALLOWABLE.ColumnEdit = Me.txtAmount
        Me.colMM_SPECIFIC_NONALLOWABLE.FieldName = "MM_SPECIFIC_NONALLOWABLE"
        Me.colMM_SPECIFIC_NONALLOWABLE.Name = "colMM_SPECIFIC_NONALLOWABLE"
        Me.colMM_SPECIFIC_NONALLOWABLE.Visible = True
        Me.colMM_SPECIFIC_NONALLOWABLE.VisibleIndex = 6
        Me.colMM_SPECIFIC_NONALLOWABLE.Width = 120
        '
        'colMM_SPECIFIC_NONALLOWABLE_ADDBACK
        '
        Me.colMM_SPECIFIC_NONALLOWABLE_ADDBACK.Caption = "Add Back"
        Me.colMM_SPECIFIC_NONALLOWABLE_ADDBACK.ColumnEdit = Me.chkAddBack
        Me.colMM_SPECIFIC_NONALLOWABLE_ADDBACK.FieldName = "MM_SPECIFIC_NONALLOWABLE_ADDBACK"
        Me.colMM_SPECIFIC_NONALLOWABLE_ADDBACK.Name = "colMM_SPECIFIC_NONALLOWABLE_ADDBACK"
        Me.colMM_SPECIFIC_NONALLOWABLE_ADDBACK.Visible = True
        Me.colMM_SPECIFIC_NONALLOWABLE_ADDBACK.VisibleIndex = 7
        Me.colMM_SPECIFIC_NONALLOWABLE_ADDBACK.Width = 120
        '
        'colMM_ADDBACK_AMOUNT
        '
        Me.colMM_ADDBACK_AMOUNT.Caption = "Add Back Amount"
        Me.colMM_ADDBACK_AMOUNT.ColumnEdit = Me.txtAmount
        Me.colMM_ADDBACK_AMOUNT.FieldName = "MM_ADDBACK_AMOUNT"
        Me.colMM_ADDBACK_AMOUNT.Name = "colMM_ADDBACK_AMOUNT"
        Me.colMM_ADDBACK_AMOUNT.OptionsColumn.ReadOnly = True
        Me.colMM_ADDBACK_AMOUNT.OptionsColumn.TabStop = False
        Me.colMM_ADDBACK_AMOUNT.Visible = True
        Me.colMM_ADDBACK_AMOUNT.VisibleIndex = 8
        Me.colMM_ADDBACK_AMOUNT.Width = 100
        '
        'colMM_NOTE
        '
        Me.colMM_NOTE.Caption = "Note"
        Me.colMM_NOTE.ColumnEdit = Me.txtNote
        Me.colMM_NOTE.FieldName = "MM_NOTE"
        Me.colMM_NOTE.Name = "colMM_NOTE"
        Me.colMM_NOTE.Visible = True
        Me.colMM_NOTE.VisibleIndex = 9
        Me.colMM_NOTE.Width = 350
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.LabelControl9)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1293, 23)
        Me.PanelControl3.TabIndex = 0
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(5, 3)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(26, 16)
        Me.LabelControl9.TabIndex = 223
        Me.LabelControl9.Text = "Add"
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.MOVEMENTCOMPLEXDEDUCTBindingSource
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 23)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.MenuManager = Me.BarManager1
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemTextEdit3, Me.RepositoryItemCheckEdit1})
        Me.GridControl2.Size = New System.Drawing.Size(1293, 260)
        Me.GridControl2.TabIndex = 11
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMM_ID1, Me.colMM_PARENTID1, Me.colMM_Sequence1, Me.colMM_Description1, Me.colMM_Amount1, Me.colMM_GENERAL1, Me.colMM_GENERAL_DEDUCT, Me.colMM_SPECIFIC_ALLOWABLE1, Me.colMM_SPECIFIC_ALLOWABLE_DEDUCT, Me.colMM_SPECIFIC_NONALLOWABLE1, Me.colMM_SPECIFIC_NONALLOWABLE_DEDUCT, Me.colMM_DEDUCT_AMOUNT, Me.colMM_NOTE1})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView2.OptionsView.RowAutoHeight = True
        '
        'colMM_ID1
        '
        Me.colMM_ID1.FieldName = "MM_ID"
        Me.colMM_ID1.Name = "colMM_ID1"
        '
        'colMM_PARENTID1
        '
        Me.colMM_PARENTID1.FieldName = "MM_PARENTID"
        Me.colMM_PARENTID1.Name = "colMM_PARENTID1"
        '
        'colMM_Sequence1
        '
        Me.colMM_Sequence1.FieldName = "MM_Sequence"
        Me.colMM_Sequence1.Name = "colMM_Sequence1"
        '
        'colMM_Description1
        '
        Me.colMM_Description1.Caption = "Description"
        Me.colMM_Description1.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colMM_Description1.FieldName = "MM_Description"
        Me.colMM_Description1.Name = "colMM_Description1"
        Me.colMM_Description1.Visible = True
        Me.colMM_Description1.VisibleIndex = 0
        Me.colMM_Description1.Width = 300
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.MaxLength = 3000
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colMM_Amount1
        '
        Me.colMM_Amount1.Caption = "Amount"
        Me.colMM_Amount1.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colMM_Amount1.FieldName = "MM_Amount"
        Me.colMM_Amount1.Name = "colMM_Amount1"
        Me.colMM_Amount1.OptionsColumn.AllowEdit = False
        Me.colMM_Amount1.OptionsColumn.TabStop = False
        Me.colMM_Amount1.Visible = True
        Me.colMM_Amount1.VisibleIndex = 1
        Me.colMM_Amount1.Width = 120
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
        'colMM_GENERAL1
        '
        Me.colMM_GENERAL1.Caption = "General"
        Me.colMM_GENERAL1.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colMM_GENERAL1.FieldName = "MM_GENERAL"
        Me.colMM_GENERAL1.Name = "colMM_GENERAL1"
        Me.colMM_GENERAL1.Visible = True
        Me.colMM_GENERAL1.VisibleIndex = 2
        Me.colMM_GENERAL1.Width = 120
        '
        'colMM_GENERAL_DEDUCT
        '
        Me.colMM_GENERAL_DEDUCT.Caption = "Deduct"
        Me.colMM_GENERAL_DEDUCT.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colMM_GENERAL_DEDUCT.FieldName = "MM_GENERAL_DEDUCT"
        Me.colMM_GENERAL_DEDUCT.Name = "colMM_GENERAL_DEDUCT"
        Me.colMM_GENERAL_DEDUCT.Visible = True
        Me.colMM_GENERAL_DEDUCT.VisibleIndex = 3
        Me.colMM_GENERAL_DEDUCT.Width = 120
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Add Back"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueGrayed = True
        '
        'colMM_SPECIFIC_ALLOWABLE1
        '
        Me.colMM_SPECIFIC_ALLOWABLE1.Caption = "Specific (Allowable)"
        Me.colMM_SPECIFIC_ALLOWABLE1.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colMM_SPECIFIC_ALLOWABLE1.FieldName = "MM_SPECIFIC_ALLOWABLE"
        Me.colMM_SPECIFIC_ALLOWABLE1.Name = "colMM_SPECIFIC_ALLOWABLE1"
        Me.colMM_SPECIFIC_ALLOWABLE1.Visible = True
        Me.colMM_SPECIFIC_ALLOWABLE1.VisibleIndex = 4
        Me.colMM_SPECIFIC_ALLOWABLE1.Width = 120
        '
        'colMM_SPECIFIC_ALLOWABLE_DEDUCT
        '
        Me.colMM_SPECIFIC_ALLOWABLE_DEDUCT.Caption = "Deduct"
        Me.colMM_SPECIFIC_ALLOWABLE_DEDUCT.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colMM_SPECIFIC_ALLOWABLE_DEDUCT.FieldName = "MM_SPECIFIC_ALLOWABLE_DEDUCT"
        Me.colMM_SPECIFIC_ALLOWABLE_DEDUCT.Name = "colMM_SPECIFIC_ALLOWABLE_DEDUCT"
        Me.colMM_SPECIFIC_ALLOWABLE_DEDUCT.Visible = True
        Me.colMM_SPECIFIC_ALLOWABLE_DEDUCT.VisibleIndex = 5
        Me.colMM_SPECIFIC_ALLOWABLE_DEDUCT.Width = 120
        '
        'colMM_SPECIFIC_NONALLOWABLE1
        '
        Me.colMM_SPECIFIC_NONALLOWABLE1.Caption = "Specific (Non Allowable)"
        Me.colMM_SPECIFIC_NONALLOWABLE1.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colMM_SPECIFIC_NONALLOWABLE1.FieldName = "MM_SPECIFIC_NONALLOWABLE"
        Me.colMM_SPECIFIC_NONALLOWABLE1.Name = "colMM_SPECIFIC_NONALLOWABLE1"
        Me.colMM_SPECIFIC_NONALLOWABLE1.Visible = True
        Me.colMM_SPECIFIC_NONALLOWABLE1.VisibleIndex = 6
        Me.colMM_SPECIFIC_NONALLOWABLE1.Width = 120
        '
        'colMM_SPECIFIC_NONALLOWABLE_DEDUCT
        '
        Me.colMM_SPECIFIC_NONALLOWABLE_DEDUCT.Caption = "Deduct"
        Me.colMM_SPECIFIC_NONALLOWABLE_DEDUCT.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colMM_SPECIFIC_NONALLOWABLE_DEDUCT.FieldName = "MM_SPECIFIC_NONALLOWABLE_DEDUCT"
        Me.colMM_SPECIFIC_NONALLOWABLE_DEDUCT.Name = "colMM_SPECIFIC_NONALLOWABLE_DEDUCT"
        Me.colMM_SPECIFIC_NONALLOWABLE_DEDUCT.Visible = True
        Me.colMM_SPECIFIC_NONALLOWABLE_DEDUCT.VisibleIndex = 7
        Me.colMM_SPECIFIC_NONALLOWABLE_DEDUCT.Width = 120
        '
        'colMM_DEDUCT_AMOUNT
        '
        Me.colMM_DEDUCT_AMOUNT.Caption = "Deduct Amount"
        Me.colMM_DEDUCT_AMOUNT.ColumnEdit = Me.RepositoryItemTextEdit3
        Me.colMM_DEDUCT_AMOUNT.FieldName = "MM_DEDUCT_AMOUNT"
        Me.colMM_DEDUCT_AMOUNT.Name = "colMM_DEDUCT_AMOUNT"
        Me.colMM_DEDUCT_AMOUNT.OptionsColumn.ReadOnly = True
        Me.colMM_DEDUCT_AMOUNT.OptionsColumn.TabStop = False
        Me.colMM_DEDUCT_AMOUNT.Visible = True
        Me.colMM_DEDUCT_AMOUNT.VisibleIndex = 8
        Me.colMM_DEDUCT_AMOUNT.Width = 100
        '
        'colMM_NOTE1
        '
        Me.colMM_NOTE1.Caption = "Note"
        Me.colMM_NOTE1.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colMM_NOTE1.FieldName = "MM_NOTE"
        Me.colMM_NOTE1.Name = "colMM_NOTE1"
        Me.colMM_NOTE1.Visible = True
        Me.colMM_NOTE1.VisibleIndex = 9
        Me.colMM_NOTE1.Width = 350
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.LabelControl12)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(1293, 23)
        Me.PanelControl4.TabIndex = 10
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(5, 3)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(29, 16)
        Me.LabelControl12.TabIndex = 223
        Me.LabelControl12.Text = "Less"
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.LabelControl14)
        Me.PanelControl2.Controls.Add(Me.txtAmountSpecificNonAllow_End)
        Me.PanelControl2.Controls.Add(Me.LabelControl15)
        Me.PanelControl2.Controls.Add(Me.txtAmountSpecificAllow_End)
        Me.PanelControl2.Controls.Add(Me.LabelControl16)
        Me.PanelControl2.Controls.Add(Me.txtAmountGeneral_End)
        Me.PanelControl2.Location = New System.Drawing.Point(12, 697)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1293, 46)
        Me.PanelControl2.TabIndex = 231
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(5, 19)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl14.TabIndex = 181
        Me.LabelControl14.Text = "1. General"
        '
        'txtAmountSpecificNonAllow_End
        '
        Me.txtAmountSpecificNonAllow_End.Location = New System.Drawing.Point(757, 16)
        Me.txtAmountSpecificNonAllow_End.MenuManager = Me.BarManager1
        Me.txtAmountSpecificNonAllow_End.Name = "txtAmountSpecificNonAllow_End"
        Me.txtAmountSpecificNonAllow_End.Properties.DisplayFormat.FormatString = "n0"
        Me.txtAmountSpecificNonAllow_End.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountSpecificNonAllow_End.Properties.EditFormat.FormatString = "n0"
        Me.txtAmountSpecificNonAllow_End.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountSpecificNonAllow_End.Properties.Mask.EditMask = "n0"
        Me.txtAmountSpecificNonAllow_End.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmountSpecificNonAllow_End.Properties.NullText = "0"
        Me.txtAmountSpecificNonAllow_End.Properties.NullValuePrompt = "0"
        Me.txtAmountSpecificNonAllow_End.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtAmountSpecificNonAllow_End.Properties.ReadOnly = True
        Me.txtAmountSpecificNonAllow_End.Size = New System.Drawing.Size(149, 20)
        Me.txtAmountSpecificNonAllow_End.TabIndex = 186
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(271, 19)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(105, 13)
        Me.LabelControl15.TabIndex = 182
        Me.LabelControl15.Text = "2. Specific (Allowable)"
        '
        'txtAmountSpecificAllow_End
        '
        Me.txtAmountSpecificAllow_End.Location = New System.Drawing.Point(401, 16)
        Me.txtAmountSpecificAllow_End.MenuManager = Me.BarManager1
        Me.txtAmountSpecificAllow_End.Name = "txtAmountSpecificAllow_End"
        Me.txtAmountSpecificAllow_End.Properties.DisplayFormat.FormatString = "n0"
        Me.txtAmountSpecificAllow_End.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountSpecificAllow_End.Properties.EditFormat.FormatString = "n0"
        Me.txtAmountSpecificAllow_End.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountSpecificAllow_End.Properties.Mask.EditMask = "n0"
        Me.txtAmountSpecificAllow_End.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmountSpecificAllow_End.Properties.NullText = "0"
        Me.txtAmountSpecificAllow_End.Properties.NullValuePrompt = "0"
        Me.txtAmountSpecificAllow_End.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtAmountSpecificAllow_End.Properties.ReadOnly = True
        Me.txtAmountSpecificAllow_End.Size = New System.Drawing.Size(149, 20)
        Me.txtAmountSpecificAllow_End.TabIndex = 185
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(604, 19)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(134, 13)
        Me.LabelControl16.TabIndex = 183
        Me.LabelControl16.Text = "3. Specific (Non - Allowable)"
        '
        'txtAmountGeneral_End
        '
        Me.txtAmountGeneral_End.Location = New System.Drawing.Point(84, 16)
        Me.txtAmountGeneral_End.MenuManager = Me.BarManager1
        Me.txtAmountGeneral_End.Name = "txtAmountGeneral_End"
        Me.txtAmountGeneral_End.Properties.DisplayFormat.FormatString = "n0"
        Me.txtAmountGeneral_End.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountGeneral_End.Properties.EditFormat.FormatString = "n0"
        Me.txtAmountGeneral_End.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountGeneral_End.Properties.Mask.EditMask = "n0"
        Me.txtAmountGeneral_End.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmountGeneral_End.Properties.NullText = "0"
        Me.txtAmountGeneral_End.Properties.NullValuePrompt = "0"
        Me.txtAmountGeneral_End.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtAmountGeneral_End.Properties.ReadOnly = True
        Me.txtAmountGeneral_End.Size = New System.Drawing.Size(149, 20)
        Me.txtAmountGeneral_End.TabIndex = 184
        '
        'txtNoteEnd
        '
        Me.txtNoteEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoteEnd.Location = New System.Drawing.Point(1158, 671)
        Me.txtNoteEnd.MenuManager = Me.BarManager1
        Me.txtNoteEnd.Name = "txtNoteEnd"
        Me.txtNoteEnd.Size = New System.Drawing.Size(149, 20)
        Me.txtNoteEnd.TabIndex = 10
        '
        'LabelControl17
        '
        Me.LabelControl17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl17.Location = New System.Drawing.Point(1107, 673)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl17.TabIndex = 230
        Me.LabelControl17.Text = "Note :"
        '
        'dtBalanceEnd
        '
        Me.dtBalanceEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtBalanceEnd.EditValue = Nothing
        Me.dtBalanceEnd.Location = New System.Drawing.Point(96, 675)
        Me.dtBalanceEnd.MenuManager = Me.BarManager1
        Me.dtBalanceEnd.Name = "dtBalanceEnd"
        Me.dtBalanceEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBalanceEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBalanceEnd.Size = New System.Drawing.Size(171, 20)
        Me.dtBalanceEnd.TabIndex = 9
        '
        'LabelControl18
        '
        Me.LabelControl18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl18.Location = New System.Drawing.Point(12, 677)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl18.TabIndex = 228
        Me.LabelControl18.Text = "Balance as at :"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(12, 120)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl8.TabIndex = 222
        Me.LabelControl8.Text = "Opening"
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txtAmountSpecificNonAllow)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.txtAmountSpecificAllow)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.txtAmountGeneral)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 165)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1293, 50)
        Me.PanelControl1.TabIndex = 221
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(5, 19)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl5.TabIndex = 181
        Me.LabelControl5.Text = "1. General"
        '
        'txtAmountSpecificNonAllow
        '
        Me.txtAmountSpecificNonAllow.Location = New System.Drawing.Point(757, 16)
        Me.txtAmountSpecificNonAllow.MenuManager = Me.BarManager1
        Me.txtAmountSpecificNonAllow.Name = "txtAmountSpecificNonAllow"
        Me.txtAmountSpecificNonAllow.Properties.DisplayFormat.FormatString = "n0"
        Me.txtAmountSpecificNonAllow.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountSpecificNonAllow.Properties.EditFormat.FormatString = "n0"
        Me.txtAmountSpecificNonAllow.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountSpecificNonAllow.Properties.Mask.EditMask = "n0"
        Me.txtAmountSpecificNonAllow.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmountSpecificNonAllow.Properties.NullText = "0"
        Me.txtAmountSpecificNonAllow.Properties.NullValuePrompt = "0"
        Me.txtAmountSpecificNonAllow.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtAmountSpecificNonAllow.Size = New System.Drawing.Size(149, 20)
        Me.txtAmountSpecificNonAllow.TabIndex = 186
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(271, 19)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(105, 13)
        Me.LabelControl6.TabIndex = 182
        Me.LabelControl6.Text = "2. Specific (Allowable)"
        '
        'txtAmountSpecificAllow
        '
        Me.txtAmountSpecificAllow.Location = New System.Drawing.Point(401, 16)
        Me.txtAmountSpecificAllow.MenuManager = Me.BarManager1
        Me.txtAmountSpecificAllow.Name = "txtAmountSpecificAllow"
        Me.txtAmountSpecificAllow.Properties.DisplayFormat.FormatString = "n0"
        Me.txtAmountSpecificAllow.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountSpecificAllow.Properties.EditFormat.FormatString = "n0"
        Me.txtAmountSpecificAllow.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountSpecificAllow.Properties.Mask.EditMask = "n0"
        Me.txtAmountSpecificAllow.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmountSpecificAllow.Properties.NullText = "0"
        Me.txtAmountSpecificAllow.Properties.NullValuePrompt = "0"
        Me.txtAmountSpecificAllow.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtAmountSpecificAllow.Size = New System.Drawing.Size(149, 20)
        Me.txtAmountSpecificAllow.TabIndex = 185
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(604, 19)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(134, 13)
        Me.LabelControl7.TabIndex = 183
        Me.LabelControl7.Text = "3. Specific (Non - Allowable)"
        '
        'txtAmountGeneral
        '
        Me.txtAmountGeneral.Location = New System.Drawing.Point(84, 16)
        Me.txtAmountGeneral.MenuManager = Me.BarManager1
        Me.txtAmountGeneral.Name = "txtAmountGeneral"
        Me.txtAmountGeneral.Properties.DisplayFormat.FormatString = "n0"
        Me.txtAmountGeneral.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountGeneral.Properties.EditFormat.FormatString = "n0"
        Me.txtAmountGeneral.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmountGeneral.Properties.Mask.EditMask = "n0"
        Me.txtAmountGeneral.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmountGeneral.Properties.NullText = "0"
        Me.txtAmountGeneral.Properties.NullValuePrompt = "0"
        Me.txtAmountGeneral.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtAmountGeneral.Size = New System.Drawing.Size(149, 20)
        Me.txtAmountGeneral.TabIndex = 184
        '
        'txtNoteStart
        '
        Me.txtNoteStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoteStart.Location = New System.Drawing.Point(1158, 139)
        Me.txtNoteStart.MenuManager = Me.BarManager1
        Me.txtNoteStart.Name = "txtNoteStart"
        Me.txtNoteStart.Size = New System.Drawing.Size(149, 20)
        Me.txtNoteStart.TabIndex = 6
        '
        'LabelControl13
        '
        Me.LabelControl13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl13.Location = New System.Drawing.Point(1107, 142)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl13.TabIndex = 220
        Me.LabelControl13.Text = "Note :"
        '
        'txtRefNo
        '
        Me.txtRefNo.Location = New System.Drawing.Point(96, 32)
        Me.txtRefNo.MenuManager = Me.BarManager1
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Properties.ReadOnly = True
        Me.txtRefNo.Size = New System.Drawing.Size(280, 20)
        Me.txtRefNo.TabIndex = 219
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(12, 61)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl11.TabIndex = 218
        Me.LabelControl11.Text = "YA :"
        '
        'cboYA
        '
        Me.cboYA.Location = New System.Drawing.Point(96, 58)
        Me.cboYA.Name = "cboYA"
        Me.cboYA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboYA.Properties.PopupSizeable = True
        Me.cboYA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboYA.Size = New System.Drawing.Size(280, 20)
        Me.cboYA.TabIndex = 1
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(12, 9)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl10.TabIndex = 217
        Me.LabelControl10.Text = "Ref No :"
        '
        'dtBalanceStart
        '
        Me.dtBalanceStart.EditValue = Nothing
        Me.dtBalanceStart.Location = New System.Drawing.Point(96, 139)
        Me.dtBalanceStart.MenuManager = Me.BarManager1
        Me.dtBalanceStart.Name = "dtBalanceStart"
        Me.dtBalanceStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBalanceStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBalanceStart.Size = New System.Drawing.Size(171, 20)
        Me.dtBalanceStart.TabIndex = 5
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(96, 84)
        Me.txtTitle.MenuManager = Me.BarManager1
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(557, 20)
        Me.txtTitle.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 142)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl4.TabIndex = 215
        Me.LabelControl4.Text = "Balance as at :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 87)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl1.TabIndex = 210
        Me.LabelControl1.Text = "Title :"
        '
        'cboType
        '
        Me.cboType.Location = New System.Drawing.Point(482, 9)
        Me.cboType.MenuManager = Me.BarManager1
        Me.cboType.Name = "cboType"
        Me.cboType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboType.Properties.Items.AddRange(New Object() {"Year Ended", "Period Ended"})
        Me.cboType.Size = New System.Drawing.Size(171, 20)
        Me.cboType.TabIndex = 236
        '
        'dtEnded
        '
        Me.dtEnded.EditValue = Nothing
        Me.dtEnded.Location = New System.Drawing.Point(482, 32)
        Me.dtEnded.MenuManager = Me.BarManager1
        Me.dtEnded.Name = "dtEnded"
        Me.dtEnded.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtEnded.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtEnded.Size = New System.Drawing.Size(171, 20)
        Me.dtEnded.TabIndex = 235
        '
        'frmMovementComplex_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1323, 777)
        Me.Controls.Add(Me.XtraScrollableControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmMovementComplex_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movement Complex Add"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOVEMENTCOMPLEXADDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMovement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOVEMENTCOMPLEXDEDUCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraScrollableControl1.ResumeLayout(False)
        Me.XtraScrollableControl1.PerformLayout()
        CType(Me.RGType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal_AddBackDeduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAddBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtAmountSpecificNonAllow_End.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmountSpecificAllow_End.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmountGeneral_End.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoteEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBalanceEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBalanceEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtAmountSpecificNonAllow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmountSpecificAllow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmountGeneral.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoteStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBalanceStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBalanceStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEnded.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEnded.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents MOVEMENTCOMPLEXADDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsMovement As EasyTemplate_Taxcom.dsMovement
    Friend WithEvents MOVEMENTCOMPLEXDEDUCTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TaxPayerFindBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsCA As EasyTemplate_Taxcom.dsCA
    Friend WithEvents XtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmountSpecificNonAllow_End As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmountSpecificAllow_End As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmountGeneral_End As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNoteEnd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtBalanceEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmountSpecificNonAllow As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmountSpecificAllow As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmountGeneral As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNoteStart As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRefNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboYA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtBalanceStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMM_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_PARENTID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_Sequence As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_Description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNote As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colMM_Amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAmount As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colMM_GENERAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_GENERAL_ADDBACK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkAddBack As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colMM_SPECIFIC_ALLOWABLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_SPECIFIC_ALLOWABLE_ADDBACK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_SPECIFIC_NONALLOWABLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_SPECIFIC_NONALLOWABLE_ADDBACK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_NOTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMM_ID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_PARENTID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_Sequence1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_Description1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colMM_Amount1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colMM_GENERAL1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_GENERAL_DEDUCT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colMM_SPECIFIC_ALLOWABLE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_SPECIFIC_ALLOWABLE_DEDUCT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_SPECIFIC_NONALLOWABLE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_SPECIFIC_NONALLOWABLE_DEDUCT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_NOTE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents colMM_ADDBACK_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_DEDUCT_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTotal_AddBackDeduct As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RGType As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents cboType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents dtEnded As DevExpress.XtraEditors.DateEdit
End Class
