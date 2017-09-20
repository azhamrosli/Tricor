<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPNL_p3Rental
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucPNL_p3Rental))
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
        Me.colEXRENTD_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXRENTD_EXRENTKEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXRENTD_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXRENTD_EXRENTDKEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXRENTD_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXRENTD_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNumberic = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colEXRENTD_NOTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNote = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colEXRENTD_DEDUCTIBLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkBox = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colEXRENTD_DEDUCTIBLE_ADD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRowIndex1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.EXPENSESRENTALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPNL1 = New EasyTemplate_Taxcom.dsPNL()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEXRENT_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXRENT_EXRENTKEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXRENT_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboSourceNo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BUSINESSSOURCEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colEXRENT_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXRENT_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXRENT_NOTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXRENT_DEDUCTIBLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXRENT_DEDUCTIBLE_ADD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXRENT_DETAIL = New DevExpress.XtraGrid.Columns.GridColumn()
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
        CType(Me.EXPENSESRENTALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEXRENTD_KEY, Me.colEXRENTD_EXRENTKEY, Me.colEXRENTD_SOURCENO, Me.colEXRENTD_EXRENTDKEY, Me.colEXRENTD_DESC, Me.colEXRENTD_AMOUNT, Me.colEXRENTD_NOTE, Me.colEXRENTD_DEDUCTIBLE, Me.colEXRENTD_DEDUCTIBLE_ADD, Me.colRowIndex1})
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
        'colEXRENTD_KEY
        '
        Me.colEXRENTD_KEY.FieldName = "EXRENTD_KEY"
        Me.colEXRENTD_KEY.Name = "colEXRENTD_KEY"
        '
        'colEXRENTD_EXRENTKEY
        '
        Me.colEXRENTD_EXRENTKEY.FieldName = "EXRENTD_EXRENTKEY"
        Me.colEXRENTD_EXRENTKEY.Name = "colEXRENTD_EXRENTKEY"
        '
        'colEXRENTD_SOURCENO
        '
        Me.colEXRENTD_SOURCENO.FieldName = "EXRENTD_SOURCENO"
        Me.colEXRENTD_SOURCENO.Name = "colEXRENTD_SOURCENO"
        '
        'colEXRENTD_EXRENTDKEY
        '
        Me.colEXRENTD_EXRENTDKEY.FieldName = "EXRENTD_EXRENTDKEY"
        Me.colEXRENTD_EXRENTDKEY.Name = "colEXRENTD_EXRENTDKEY"
        '
        'colEXRENTD_DESC
        '
        Me.colEXRENTD_DESC.Caption = "Description"
        Me.colEXRENTD_DESC.FieldName = "EXRENTD_DESC"
        Me.colEXRENTD_DESC.Name = "colEXRENTD_DESC"
        Me.colEXRENTD_DESC.Visible = True
        Me.colEXRENTD_DESC.VisibleIndex = 0
        Me.colEXRENTD_DESC.Width = 300
        '
        'colEXRENTD_AMOUNT
        '
        Me.colEXRENTD_AMOUNT.Caption = "Amount"
        Me.colEXRENTD_AMOUNT.ColumnEdit = Me.txtNumberic
        Me.colEXRENTD_AMOUNT.FieldName = "EXRENTD_AMOUNT"
        Me.colEXRENTD_AMOUNT.Name = "colEXRENTD_AMOUNT"
        Me.colEXRENTD_AMOUNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EXRENTD_AMOUNT", "SUM={0:0.##}")})
        Me.colEXRENTD_AMOUNT.Visible = True
        Me.colEXRENTD_AMOUNT.VisibleIndex = 1
        Me.colEXRENTD_AMOUNT.Width = 120
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
        'colEXRENTD_NOTE
        '
        Me.colEXRENTD_NOTE.Caption = "Remarks"
        Me.colEXRENTD_NOTE.ColumnEdit = Me.txtNote
        Me.colEXRENTD_NOTE.FieldName = "EXRENTD_NOTE"
        Me.colEXRENTD_NOTE.Name = "colEXRENTD_NOTE"
        Me.colEXRENTD_NOTE.Visible = True
        Me.colEXRENTD_NOTE.VisibleIndex = 2
        Me.colEXRENTD_NOTE.Width = 300
        '
        'txtNote
        '
        Me.txtNote.MaxLength = 1500
        Me.txtNote.Name = "txtNote"
        '
        'colEXRENTD_DEDUCTIBLE
        '
        Me.colEXRENTD_DEDUCTIBLE.Caption = "Add Back"
        Me.colEXRENTD_DEDUCTIBLE.ColumnEdit = Me.chkBox
        Me.colEXRENTD_DEDUCTIBLE.FieldName = "EXRENTD_DEDUCTIBLE"
        Me.colEXRENTD_DEDUCTIBLE.Name = "colEXRENTD_DEDUCTIBLE"
        Me.colEXRENTD_DEDUCTIBLE.Visible = True
        Me.colEXRENTD_DEDUCTIBLE.VisibleIndex = 3
        Me.colEXRENTD_DEDUCTIBLE.Width = 100
        '
        'chkBox
        '
        Me.chkBox.AutoHeight = False
        Me.chkBox.Name = "chkBox"
        Me.chkBox.ValueGrayed = True
        '
        'colEXRENTD_DEDUCTIBLE_ADD
        '
        Me.colEXRENTD_DEDUCTIBLE_ADD.Caption = "Deduct"
        Me.colEXRENTD_DEDUCTIBLE_ADD.ColumnEdit = Me.chkBox
        Me.colEXRENTD_DEDUCTIBLE_ADD.FieldName = "EXRENTD_DEDUCTIBLE_ADD"
        Me.colEXRENTD_DEDUCTIBLE_ADD.Name = "colEXRENTD_DEDUCTIBLE_ADD"
        Me.colEXRENTD_DEDUCTIBLE_ADD.Visible = True
        Me.colEXRENTD_DEDUCTIBLE_ADD.VisibleIndex = 4
        Me.colEXRENTD_DEDUCTIBLE_ADD.Width = 100
        '
        'colRowIndex1
        '
        Me.colRowIndex1.FieldName = "RowIndex"
        Me.colRowIndex1.Name = "colRowIndex1"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.EXPENSESRENTALBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GridView2
        GridLevelNode1.RelationName = "FK_EXPENSES_RENTAL_EXPENSES_RENTAL_DETAIL"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(0, 31)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtNumberic, Me.txtNote, Me.cboSourceNo, Me.chkBox})
        Me.GridControl1.Size = New System.Drawing.Size(951, 386)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'EXPENSESRENTALBindingSource
        '
        Me.EXPENSESRENTALBindingSource.DataMember = "EXPENSES_RENTAL"
        Me.EXPENSESRENTALBindingSource.DataSource = Me.DsPNL1
        '
        'DsPNL1
        '
        Me.DsPNL1.DataSetName = "dsPNL"
        Me.DsPNL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEXRENT_KEY, Me.colEXRENT_EXRENTKEY, Me.colEXRENT_SOURCENO, Me.colEXRENT_DESC, Me.colEXRENT_AMOUNT, Me.colEXRENT_NOTE, Me.colEXRENT_DEDUCTIBLE, Me.colEXRENT_DEDUCTIBLE_ADD, Me.colEXRENT_DETAIL, Me.colRowIndex})
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
        'colEXRENT_KEY
        '
        Me.colEXRENT_KEY.FieldName = "EXRENT_KEY"
        Me.colEXRENT_KEY.Name = "colEXRENT_KEY"
        '
        'colEXRENT_EXRENTKEY
        '
        Me.colEXRENT_EXRENTKEY.FieldName = "EXRENT_EXRENTKEY"
        Me.colEXRENT_EXRENTKEY.Name = "colEXRENT_EXRENTKEY"
        '
        'colEXRENT_SOURCENO
        '
        Me.colEXRENT_SOURCENO.Caption = "Source No"
        Me.colEXRENT_SOURCENO.ColumnEdit = Me.cboSourceNo
        Me.colEXRENT_SOURCENO.FieldName = "EXRENT_SOURCENO"
        Me.colEXRENT_SOURCENO.Name = "colEXRENT_SOURCENO"
        Me.colEXRENT_SOURCENO.Visible = True
        Me.colEXRENT_SOURCENO.VisibleIndex = 0
        Me.colEXRENT_SOURCENO.Width = 80
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
        'colEXRENT_DESC
        '
        Me.colEXRENT_DESC.Caption = "Description"
        Me.colEXRENT_DESC.FieldName = "EXRENT_DESC"
        Me.colEXRENT_DESC.Name = "colEXRENT_DESC"
        Me.colEXRENT_DESC.Visible = True
        Me.colEXRENT_DESC.VisibleIndex = 1
        Me.colEXRENT_DESC.Width = 300
        '
        'colEXRENT_AMOUNT
        '
        Me.colEXRENT_AMOUNT.Caption = "Amount"
        Me.colEXRENT_AMOUNT.ColumnEdit = Me.txtNumberic
        Me.colEXRENT_AMOUNT.FieldName = "EXRENT_AMOUNT"
        Me.colEXRENT_AMOUNT.Name = "colEXRENT_AMOUNT"
        Me.colEXRENT_AMOUNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EXRENT_AMOUNT", "SUM={0:0.##}")})
        Me.colEXRENT_AMOUNT.Visible = True
        Me.colEXRENT_AMOUNT.VisibleIndex = 2
        Me.colEXRENT_AMOUNT.Width = 120
        '
        'colEXRENT_NOTE
        '
        Me.colEXRENT_NOTE.Caption = "Remarks"
        Me.colEXRENT_NOTE.ColumnEdit = Me.txtNote
        Me.colEXRENT_NOTE.FieldName = "EXRENT_NOTE"
        Me.colEXRENT_NOTE.Name = "colEXRENT_NOTE"
        Me.colEXRENT_NOTE.Visible = True
        Me.colEXRENT_NOTE.VisibleIndex = 3
        Me.colEXRENT_NOTE.Width = 300
        '
        'colEXRENT_DEDUCTIBLE
        '
        Me.colEXRENT_DEDUCTIBLE.Caption = "Add Back"
        Me.colEXRENT_DEDUCTIBLE.ColumnEdit = Me.chkBox
        Me.colEXRENT_DEDUCTIBLE.FieldName = "EXRENT_DEDUCTIBLE"
        Me.colEXRENT_DEDUCTIBLE.Name = "colEXRENT_DEDUCTIBLE"
        Me.colEXRENT_DEDUCTIBLE.Visible = True
        Me.colEXRENT_DEDUCTIBLE.VisibleIndex = 4
        Me.colEXRENT_DEDUCTIBLE.Width = 100
        '
        'colEXRENT_DEDUCTIBLE_ADD
        '
        Me.colEXRENT_DEDUCTIBLE_ADD.Caption = "Deduct"
        Me.colEXRENT_DEDUCTIBLE_ADD.ColumnEdit = Me.chkBox
        Me.colEXRENT_DEDUCTIBLE_ADD.FieldName = "EXRENT_DEDUCTIBLE_ADD"
        Me.colEXRENT_DEDUCTIBLE_ADD.Name = "colEXRENT_DEDUCTIBLE_ADD"
        Me.colEXRENT_DEDUCTIBLE_ADD.Visible = True
        Me.colEXRENT_DEDUCTIBLE_ADD.VisibleIndex = 5
        Me.colEXRENT_DEDUCTIBLE_ADD.Width = 100
        '
        'colEXRENT_DETAIL
        '
        Me.colEXRENT_DETAIL.Caption = "Details"
        Me.colEXRENT_DETAIL.FieldName = "EXRENT_DETAIL"
        Me.colEXRENT_DETAIL.Name = "colEXRENT_DETAIL"
        Me.colEXRENT_DETAIL.OptionsColumn.ReadOnly = True
        Me.colEXRENT_DETAIL.OptionsColumn.TabStop = False
        Me.colEXRENT_DETAIL.Visible = True
        Me.colEXRENT_DETAIL.VisibleIndex = 6
        Me.colEXRENT_DETAIL.Width = 100
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
        Me.barDockControlTop.Size = New System.Drawing.Size(951, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 417)
        Me.barDockControlBottom.Size = New System.Drawing.Size(951, 0)
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
        Me.barDockControlRight.Location = New System.Drawing.Point(951, 31)
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
        'ucPNL_p3Rental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "ucPNL_p3Rental"
        Me.Size = New System.Drawing.Size(951, 417)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumberic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXPENSESRENTALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents colEXRENTD_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXRENTD_EXRENTKEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXRENTD_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXRENTD_EXRENTDKEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXRENTD_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXRENTD_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXRENTD_NOTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXRENTD_DEDUCTIBLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXRENTD_DEDUCTIBLE_ADD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRowIndex1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EXPENSESRENTALBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colEXRENT_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXRENT_EXRENTKEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXRENT_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXRENT_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXRENT_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXRENT_NOTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXRENT_DEDUCTIBLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXRENT_DEDUCTIBLE_ADD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXRENT_DETAIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRowIndex As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnMoveUp As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMoveDown As DevExpress.XtraBars.BarButtonItem

End Class
