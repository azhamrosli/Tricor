﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPNL_p3ContractPay
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucPNL_p3ContractPay))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem5 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip6 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem6 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem6 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEXCD_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXCD_EXCKEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXCD_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXCD_EXCDKEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXCD_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXCD_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNumberic = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colEXCD_NOTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNote = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colEXCD_DEDUCTIBLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkBox = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colEXCD_DEDUCTIBLE_ADD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRowIndex1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.EXPENSESCONTRACTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPNL1 = New EasyTemplate_Taxcom.dsPNL()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEXC_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXC_EXCKEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXC_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboSourceNo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BUSINESSSOURCEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colEXC_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXC_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXC_NOTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXC_DEDUCTIBLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXC_DEDUCTIBLE_ADD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXC_DETAIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRowIndex = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddChild = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteChild = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExpand = New DevExpress.XtraBars.BarButtonItem()
        Me.chkIncludeInReport = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.btnMoveUp = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMoveDown = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumberic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXPENSESCONTRACTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPNL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSourceNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BUSINESSSOURCEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEXCD_KEY, Me.colEXCD_EXCKEY, Me.colEXCD_SOURCENO, Me.colEXCD_EXCDKEY, Me.colEXCD_DESC, Me.colEXCD_AMOUNT, Me.colEXCD_NOTE, Me.colEXCD_DEDUCTIBLE, Me.colEXCD_DEDUCTIBLE_ADD, Me.colRowIndex1})
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsDetail.SmartDetailHeight = True
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.ViewCaption = "Details"
        '
        'colEXCD_KEY
        '
        Me.colEXCD_KEY.FieldName = "EXCD_KEY"
        Me.colEXCD_KEY.Name = "colEXCD_KEY"
        '
        'colEXCD_EXCKEY
        '
        Me.colEXCD_EXCKEY.FieldName = "EXCD_EXCKEY"
        Me.colEXCD_EXCKEY.Name = "colEXCD_EXCKEY"
        '
        'colEXCD_SOURCENO
        '
        Me.colEXCD_SOURCENO.FieldName = "EXCD_SOURCENO"
        Me.colEXCD_SOURCENO.Name = "colEXCD_SOURCENO"
        '
        'colEXCD_EXCDKEY
        '
        Me.colEXCD_EXCDKEY.FieldName = "EXCD_EXCDKEY"
        Me.colEXCD_EXCDKEY.Name = "colEXCD_EXCDKEY"
        '
        'colEXCD_DESC
        '
        Me.colEXCD_DESC.Caption = "Description"
        Me.colEXCD_DESC.FieldName = "EXCD_DESC"
        Me.colEXCD_DESC.Name = "colEXCD_DESC"
        Me.colEXCD_DESC.Visible = True
        Me.colEXCD_DESC.VisibleIndex = 0
        Me.colEXCD_DESC.Width = 300
        '
        'colEXCD_AMOUNT
        '
        Me.colEXCD_AMOUNT.Caption = "Amount"
        Me.colEXCD_AMOUNT.ColumnEdit = Me.txtNumberic
        Me.colEXCD_AMOUNT.FieldName = "EXCD_AMOUNT"
        Me.colEXCD_AMOUNT.Name = "colEXCD_AMOUNT"
        Me.colEXCD_AMOUNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EXCD_AMOUNT", "SUM={0:0.##}")})
        Me.colEXCD_AMOUNT.Visible = True
        Me.colEXCD_AMOUNT.VisibleIndex = 1
        Me.colEXCD_AMOUNT.Width = 120
        '
        'txtNumberic
        '
        Me.txtNumberic.AutoHeight = False
        Me.txtNumberic.DisplayFormat.FormatString = "n2"
        Me.txtNumberic.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNumberic.Mask.EditMask = "c"
        Me.txtNumberic.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNumberic.Name = "txtNumberic"
        Me.txtNumberic.NullValuePromptShowForEmptyValue = True
        '
        'colEXCD_NOTE
        '
        Me.colEXCD_NOTE.Caption = "Remarks"
        Me.colEXCD_NOTE.ColumnEdit = Me.txtNote
        Me.colEXCD_NOTE.FieldName = "EXCD_NOTE"
        Me.colEXCD_NOTE.Name = "colEXCD_NOTE"
        Me.colEXCD_NOTE.Visible = True
        Me.colEXCD_NOTE.VisibleIndex = 2
        Me.colEXCD_NOTE.Width = 300
        '
        'txtNote
        '
        Me.txtNote.MaxLength = 1500
        Me.txtNote.Name = "txtNote"
        '
        'colEXCD_DEDUCTIBLE
        '
        Me.colEXCD_DEDUCTIBLE.Caption = "Add Back"
        Me.colEXCD_DEDUCTIBLE.ColumnEdit = Me.chkBox
        Me.colEXCD_DEDUCTIBLE.FieldName = "EXCD_DEDUCTIBLE"
        Me.colEXCD_DEDUCTIBLE.Name = "colEXCD_DEDUCTIBLE"
        Me.colEXCD_DEDUCTIBLE.Visible = True
        Me.colEXCD_DEDUCTIBLE.VisibleIndex = 3
        Me.colEXCD_DEDUCTIBLE.Width = 100
        '
        'chkBox
        '
        Me.chkBox.AutoHeight = False
        Me.chkBox.Name = "chkBox"
        Me.chkBox.ValueGrayed = True
        '
        'colEXCD_DEDUCTIBLE_ADD
        '
        Me.colEXCD_DEDUCTIBLE_ADD.Caption = "Deduct"
        Me.colEXCD_DEDUCTIBLE_ADD.ColumnEdit = Me.chkBox
        Me.colEXCD_DEDUCTIBLE_ADD.FieldName = "EXCD_DEDUCTIBLE_ADD"
        Me.colEXCD_DEDUCTIBLE_ADD.Name = "colEXCD_DEDUCTIBLE_ADD"
        Me.colEXCD_DEDUCTIBLE_ADD.Visible = True
        Me.colEXCD_DEDUCTIBLE_ADD.VisibleIndex = 4
        Me.colEXCD_DEDUCTIBLE_ADD.Width = 100
        '
        'colRowIndex1
        '
        Me.colRowIndex1.FieldName = "RowIndex"
        Me.colRowIndex1.Name = "colRowIndex1"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.EXPENSESCONTRACTBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GridView2
        GridLevelNode1.RelationName = "FK_EXPENSES_CONTRACT_EXPENSES_CONTRACT_DETAIL"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(0, 31)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtNumberic, Me.txtNote, Me.cboSourceNo, Me.chkBox})
        Me.GridControl1.Size = New System.Drawing.Size(1032, 386)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'EXPENSESCONTRACTBindingSource
        '
        Me.EXPENSESCONTRACTBindingSource.DataMember = "EXPENSES_CONTRACT"
        Me.EXPENSESCONTRACTBindingSource.DataSource = Me.DsPNL1
        '
        'DsPNL1
        '
        Me.DsPNL1.DataSetName = "dsPNL"
        Me.DsPNL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEXC_KEY, Me.colEXC_EXCKEY, Me.colEXC_SOURCENO, Me.colEXC_DESC, Me.colEXC_AMOUNT, Me.colEXC_NOTE, Me.colEXC_DEDUCTIBLE, Me.colEXC_DEDUCTIBLE_ADD, Me.colEXC_DETAIL, Me.colRowIndex})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GridView1.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled
        Me.GridView1.OptionsDetail.SmartDetailHeight = True
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colEXC_KEY
        '
        Me.colEXC_KEY.FieldName = "EXC_KEY"
        Me.colEXC_KEY.Name = "colEXC_KEY"
        '
        'colEXC_EXCKEY
        '
        Me.colEXC_EXCKEY.FieldName = "EXC_EXCKEY"
        Me.colEXC_EXCKEY.Name = "colEXC_EXCKEY"
        '
        'colEXC_SOURCENO
        '
        Me.colEXC_SOURCENO.Caption = "Source No"
        Me.colEXC_SOURCENO.ColumnEdit = Me.cboSourceNo
        Me.colEXC_SOURCENO.FieldName = "EXC_SOURCENO"
        Me.colEXC_SOURCENO.Name = "colEXC_SOURCENO"
        Me.colEXC_SOURCENO.Visible = True
        Me.colEXC_SOURCENO.VisibleIndex = 0
        Me.colEXC_SOURCENO.Width = 80
        '
        'cboSourceNo
        '
        Me.cboSourceNo.AutoHeight = False
        Me.cboSourceNo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSourceNo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BC_SOURCEKEY", "Source No", 101, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BC_SOURCENO", "Source No", 85, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BC_CODE", "Code", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BC_TYPE", "Type", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboSourceNo.DataSource = Me.BUSINESSSOURCEBindingSource
        Me.cboSourceNo.DisplayMember = "BC_SOURCENO"
        Me.cboSourceNo.Name = "cboSourceNo"
        Me.cboSourceNo.NullText = "Select"
        Me.cboSourceNo.PopupFormMinSize = New System.Drawing.Size(450, 0)
        Me.cboSourceNo.ValueMember = "BC_SOURCENO"
        '
        'BUSINESSSOURCEBindingSource
        '
        Me.BUSINESSSOURCEBindingSource.DataMember = "BUSINESS_SOURCE"
        Me.BUSINESSSOURCEBindingSource.DataSource = Me.DsPNL1
        '
        'colEXC_DESC
        '
        Me.colEXC_DESC.Caption = "Description"
        Me.colEXC_DESC.FieldName = "EXC_DESC"
        Me.colEXC_DESC.Name = "colEXC_DESC"
        Me.colEXC_DESC.Visible = True
        Me.colEXC_DESC.VisibleIndex = 1
        Me.colEXC_DESC.Width = 300
        '
        'colEXC_AMOUNT
        '
        Me.colEXC_AMOUNT.Caption = "Amount"
        Me.colEXC_AMOUNT.ColumnEdit = Me.txtNumberic
        Me.colEXC_AMOUNT.FieldName = "EXC_AMOUNT"
        Me.colEXC_AMOUNT.Name = "colEXC_AMOUNT"
        Me.colEXC_AMOUNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EXC_AMOUNT", "SUM={0:0.##}")})
        Me.colEXC_AMOUNT.Visible = True
        Me.colEXC_AMOUNT.VisibleIndex = 2
        Me.colEXC_AMOUNT.Width = 120
        '
        'colEXC_NOTE
        '
        Me.colEXC_NOTE.Caption = "Remarks"
        Me.colEXC_NOTE.ColumnEdit = Me.txtNote
        Me.colEXC_NOTE.FieldName = "EXC_NOTE"
        Me.colEXC_NOTE.Name = "colEXC_NOTE"
        Me.colEXC_NOTE.Visible = True
        Me.colEXC_NOTE.VisibleIndex = 3
        Me.colEXC_NOTE.Width = 300
        '
        'colEXC_DEDUCTIBLE
        '
        Me.colEXC_DEDUCTIBLE.Caption = "Add Back"
        Me.colEXC_DEDUCTIBLE.ColumnEdit = Me.chkBox
        Me.colEXC_DEDUCTIBLE.FieldName = "EXC_DEDUCTIBLE"
        Me.colEXC_DEDUCTIBLE.Name = "colEXC_DEDUCTIBLE"
        Me.colEXC_DEDUCTIBLE.Visible = True
        Me.colEXC_DEDUCTIBLE.VisibleIndex = 4
        Me.colEXC_DEDUCTIBLE.Width = 100
        '
        'colEXC_DEDUCTIBLE_ADD
        '
        Me.colEXC_DEDUCTIBLE_ADD.Caption = "Deduct"
        Me.colEXC_DEDUCTIBLE_ADD.ColumnEdit = Me.chkBox
        Me.colEXC_DEDUCTIBLE_ADD.FieldName = "EXC_DEDUCTIBLE_ADD"
        Me.colEXC_DEDUCTIBLE_ADD.Name = "colEXC_DEDUCTIBLE_ADD"
        Me.colEXC_DEDUCTIBLE_ADD.Visible = True
        Me.colEXC_DEDUCTIBLE_ADD.VisibleIndex = 5
        Me.colEXC_DEDUCTIBLE_ADD.Width = 100
        '
        'colEXC_DETAIL
        '
        Me.colEXC_DETAIL.Caption = "Details"
        Me.colEXC_DETAIL.FieldName = "EXC_DETAIL"
        Me.colEXC_DETAIL.Name = "colEXC_DETAIL"
        Me.colEXC_DETAIL.OptionsColumn.ReadOnly = True
        Me.colEXC_DETAIL.OptionsColumn.TabStop = False
        Me.colEXC_DETAIL.Visible = True
        Me.colEXC_DETAIL.VisibleIndex = 6
        Me.colEXC_DETAIL.Width = 100
        '
        'colRowIndex
        '
        Me.colRowIndex.FieldName = "RowIndex"
        Me.colRowIndex.Name = "colRowIndex"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnAdd, Me.btnAddChild, Me.btnDelete, Me.btnDeleteChild, Me.btnExpand, Me.chkIncludeInReport, Me.btnMoveUp, Me.btnMoveDown})
        Me.BarManager1.MaxItemId = 14
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4, Me.RepositoryItemCheckEdit1})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(31, 109)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.btnAddChild), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDeleteChild), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExpand), New DevExpress.XtraBars.LinkPersistInfo(Me.chkIncludeInReport), New DevExpress.XtraBars.LinkPersistInfo(Me.btnMoveUp), New DevExpress.XtraBars.LinkPersistInfo(Me.btnMoveDown)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DisableClose = True
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'btnAdd
        '
        Me.btnAdd.Caption = "Add Data"
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
        Me.btnAddChild.Caption = "Add Child Data"
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
        Me.btnDelete.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y))
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
        'btnDeleteChild
        '
        Me.btnDeleteChild.Caption = "Delete Child"
        Me.btnDeleteChild.Glyph = CType(resources.GetObject("btnDeleteChild.Glyph"), System.Drawing.Image)
        Me.btnDeleteChild.Id = 5
        Me.btnDeleteChild.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U))
        Me.btnDeleteChild.LargeGlyph = CType(resources.GetObject("btnDeleteChild.LargeGlyph"), System.Drawing.Image)
        Me.btnDeleteChild.Name = "btnDeleteChild"
        Me.btnDeleteChild.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem4.Text = "Delete record"
        ToolTipItem4.LeftIndent = 6
        ToolTipItem4.Text = "Delete record Ctrl + U" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "How to use : Please select the main row first then contin" & _
    "ues with select child row(s)."
        SuperToolTip4.Items.Add(ToolTipTitleItem4)
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.btnDeleteChild.SuperTip = SuperToolTip4
        '
        'btnExpand
        '
        Me.btnExpand.Caption = "Expand Child"
        Me.btnExpand.Glyph = CType(resources.GetObject("btnExpand.Glyph"), System.Drawing.Image)
        Me.btnExpand.Id = 8
        Me.btnExpand.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E))
        Me.btnExpand.LargeGlyph = CType(resources.GetObject("btnExpand.LargeGlyph"), System.Drawing.Image)
        Me.btnExpand.Name = "btnExpand"
        Me.btnExpand.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem5.Text = "Expand child"
        ToolTipItem5.LeftIndent = 6
        ToolTipItem5.Text = "Expand selected row Ctrl + E"
        SuperToolTip5.Items.Add(ToolTipTitleItem5)
        SuperToolTip5.Items.Add(ToolTipItem5)
        Me.btnExpand.SuperTip = SuperToolTip5
        '
        'chkIncludeInReport
        '
        Me.chkIncludeInReport.Caption = "Include in Report :"
        Me.chkIncludeInReport.Edit = Me.RepositoryItemCheckEdit1
        Me.chkIncludeInReport.EditValue = True
        Me.chkIncludeInReport.Id = 11
        Me.chkIncludeInReport.Name = "chkIncludeInReport"
        Me.chkIncludeInReport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem6.Text = "Include in Report"
        ToolTipItem6.LeftIndent = 6
        ToolTipItem6.Text = "Include all details item in report."
        SuperToolTip6.Items.Add(ToolTipTitleItem6)
        SuperToolTip6.Items.Add(ToolTipItem6)
        Me.chkIncludeInReport.SuperTip = SuperToolTip6
        Me.chkIncludeInReport.Width = 150
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Yes"
        Me.RepositoryItemCheckEdit1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1032, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 417)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1032, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 386)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1032, 31)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 386)
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
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'btnMoveUp
        '
        Me.btnMoveUp.Caption = "Move Up"
        Me.btnMoveUp.Glyph = CType(resources.GetObject("btnMoveUp.Glyph"), System.Drawing.Image)
        Me.btnMoveUp.Id = 12
        Me.btnMoveUp.LargeGlyph = CType(resources.GetObject("btnMoveUp.LargeGlyph"), System.Drawing.Image)
        Me.btnMoveUp.Name = "btnMoveUp"
        Me.btnMoveUp.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnMoveDown
        '
        Me.btnMoveDown.Caption = "Move Down"
        Me.btnMoveDown.Glyph = CType(resources.GetObject("btnMoveDown.Glyph"), System.Drawing.Image)
        Me.btnMoveDown.Id = 13
        Me.btnMoveDown.LargeGlyph = CType(resources.GetObject("btnMoveDown.LargeGlyph"), System.Drawing.Image)
        Me.btnMoveDown.Name = "btnMoveDown"
        Me.btnMoveDown.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'ucPNL_p3ContractPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "ucPNL_p3ContractPay"
        Me.Size = New System.Drawing.Size(1032, 417)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumberic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXPENSESCONTRACTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPNL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSourceNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BUSINESSSOURCEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsPNL As EasyTemplate_Taxcom.dsPNL
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddChild As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents txtNumberic As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtNote As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents btnDeleteChild As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnExpand As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cboSourceNo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DsPNL1 As EasyTemplate_Taxcom.dsPNL
    Friend WithEvents BUSINESSSOURCEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents chkBox As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents chkIncludeInReport As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colEXCD_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXCD_EXCKEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXCD_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXCD_EXCDKEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXCD_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXCD_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXCD_NOTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXCD_DEDUCTIBLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXCD_DEDUCTIBLE_ADD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRowIndex1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EXPENSESCONTRACTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colEXC_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXC_EXCKEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXC_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXC_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXC_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXC_NOTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXC_DEDUCTIBLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXC_DEDUCTIBLE_ADD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXC_DETAIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRowIndex As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnMoveUp As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMoveDown As DevExpress.XtraBars.BarButtonItem

End Class
