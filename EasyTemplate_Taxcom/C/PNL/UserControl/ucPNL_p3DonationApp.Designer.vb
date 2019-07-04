<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPNL_p3DonationApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucPNL_p3DonationApp))
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
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEXOADD_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOADD_EXOADKEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOADD_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOADD_EXOADDKEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOADD_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOADD_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNumberic = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colPecentage1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtPercentage = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colEXOADD_NOTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNote = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colEXOADD_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOADD_DEDUCTIBLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkBox = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colEXOADD_DEDUCTIBLE_ADD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRowIndex1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPecentageAmount1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.OTHEREXAPPRDONATIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPNL1 = New EasyTemplate_Taxcom.dsPNL()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEXOAD_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOAD_EXOADKEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOAD_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboSourceNo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BUSINESSSOURCEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colEXOAD_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOAD_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOAD_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOAD_DEDUCTIBLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOAD_DEDUCTIBLE_ADD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPecentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOAD_NOTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOAD_DETAIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRowIndex = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPecentageAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddChild = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExpand = New DevExpress.XtraBars.BarButtonItem()
        Me.chkIncludeInReport = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.btnMoveUp = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMoveDown = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNote = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumberic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPercentage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OTHEREXAPPRDONATIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEXOADD_KEY, Me.colEXOADD_EXOADKEY, Me.colEXOADD_SOURCENO, Me.colEXOADD_EXOADDKEY, Me.colEXOADD_DESC, Me.colEXOADD_AMOUNT, Me.colEXOADD_DEDUCTIBLE, Me.colEXOADD_DEDUCTIBLE_ADD, Me.colPecentage1, Me.colEXOADD_NOTE, Me.colEXOADD_TYPE, Me.colRowIndex1, Me.colPecentageAmount1})
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
        'colEXOADD_KEY
        '
        Me.colEXOADD_KEY.FieldName = "EXOADD_KEY"
        Me.colEXOADD_KEY.Name = "colEXOADD_KEY"
        Me.colEXOADD_KEY.OptionsColumn.AllowEdit = False
        Me.colEXOADD_KEY.OptionsColumn.TabStop = False
        Me.colEXOADD_KEY.Visible = True
        Me.colEXOADD_KEY.VisibleIndex = 8
        '
        'colEXOADD_EXOADKEY
        '
        Me.colEXOADD_EXOADKEY.FieldName = "EXOADD_EXOADKEY"
        Me.colEXOADD_EXOADKEY.Name = "colEXOADD_EXOADKEY"
        '
        'colEXOADD_SOURCENO
        '
        Me.colEXOADD_SOURCENO.FieldName = "EXOADD_SOURCENO"
        Me.colEXOADD_SOURCENO.Name = "colEXOADD_SOURCENO"
        '
        'colEXOADD_EXOADDKEY
        '
        Me.colEXOADD_EXOADDKEY.FieldName = "EXOADD_EXOADDKEY"
        Me.colEXOADD_EXOADDKEY.Name = "colEXOADD_EXOADDKEY"
        '
        'colEXOADD_DESC
        '
        Me.colEXOADD_DESC.Caption = "Description"
        Me.colEXOADD_DESC.FieldName = "EXOADD_DESC"
        Me.colEXOADD_DESC.Name = "colEXOADD_DESC"
        Me.colEXOADD_DESC.Visible = True
        Me.colEXOADD_DESC.VisibleIndex = 0
        Me.colEXOADD_DESC.Width = 300
        '
        'colEXOADD_AMOUNT
        '
        Me.colEXOADD_AMOUNT.Caption = "Amount"
        Me.colEXOADD_AMOUNT.ColumnEdit = Me.txtNumberic
        Me.colEXOADD_AMOUNT.FieldName = "EXOADD_AMOUNT"
        Me.colEXOADD_AMOUNT.Name = "colEXOADD_AMOUNT"
        Me.colEXOADD_AMOUNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EXOADD_AMOUNT", "SUM={0:0.##}")})
        Me.colEXOADD_AMOUNT.Visible = True
        Me.colEXOADD_AMOUNT.VisibleIndex = 1
        Me.colEXOADD_AMOUNT.Width = 120
        '
        'txtNumberic
        '
        Me.txtNumberic.AutoHeight = False
        Me.txtNumberic.DisplayFormat.FormatString = "n0"
        Me.txtNumberic.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNumberic.Mask.EditMask = "n0"
        Me.txtNumberic.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNumberic.Name = "txtNumberic"
        Me.txtNumberic.NullValuePromptShowForEmptyValue = True
        '
        'colPecentage1
        '
        Me.colPecentage1.Caption = "Percentage %"
        Me.colPecentage1.ColumnEdit = Me.txtPercentage
        Me.colPecentage1.FieldName = "Pecentage"
        Me.colPecentage1.Name = "colPecentage1"
        Me.colPecentage1.Visible = True
        Me.colPecentage1.VisibleIndex = 4
        Me.colPecentage1.Width = 100
        '
        'txtPercentage
        '
        Me.txtPercentage.AutoHeight = False
        Me.txtPercentage.Mask.EditMask = "P0"
        Me.txtPercentage.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPercentage.Name = "txtPercentage"
        Me.txtPercentage.NullText = "0"
        Me.txtPercentage.NullValuePrompt = "0"
        Me.txtPercentage.NullValuePromptShowForEmptyValue = True
        '
        'colEXOADD_NOTE
        '
        Me.colEXOADD_NOTE.Caption = "Remarks"
        Me.colEXOADD_NOTE.ColumnEdit = Me.txtNote
        Me.colEXOADD_NOTE.FieldName = "EXOADD_NOTE"
        Me.colEXOADD_NOTE.Name = "colEXOADD_NOTE"
        Me.colEXOADD_NOTE.Visible = True
        Me.colEXOADD_NOTE.VisibleIndex = 5
        Me.colEXOADD_NOTE.Width = 300
        '
        'txtNote
        '
        Me.txtNote.MaxLength = 1500
        Me.txtNote.Name = "txtNote"
        '
        'colEXOADD_TYPE
        '
        Me.colEXOADD_TYPE.Caption = "Type"
        Me.colEXOADD_TYPE.FieldName = "EXOADD_TYPE"
        Me.colEXOADD_TYPE.Name = "colEXOADD_TYPE"
        Me.colEXOADD_TYPE.Visible = True
        Me.colEXOADD_TYPE.VisibleIndex = 6
        Me.colEXOADD_TYPE.Width = 100
        '
        'colEXOADD_DEDUCTIBLE
        '
        Me.colEXOADD_DEDUCTIBLE.Caption = "Add Back"
        Me.colEXOADD_DEDUCTIBLE.ColumnEdit = Me.chkBox
        Me.colEXOADD_DEDUCTIBLE.FieldName = "EXOADD_DEDUCTIBLE"
        Me.colEXOADD_DEDUCTIBLE.Name = "colEXOADD_DEDUCTIBLE"
        Me.colEXOADD_DEDUCTIBLE.Visible = True
        Me.colEXOADD_DEDUCTIBLE.VisibleIndex = 2
        Me.colEXOADD_DEDUCTIBLE.Width = 100
        '
        'chkBox
        '
        Me.chkBox.AutoHeight = False
        Me.chkBox.Name = "chkBox"
        Me.chkBox.ValueGrayed = True
        '
        'colEXOADD_DEDUCTIBLE_ADD
        '
        Me.colEXOADD_DEDUCTIBLE_ADD.Caption = "Deduct"
        Me.colEXOADD_DEDUCTIBLE_ADD.ColumnEdit = Me.chkBox
        Me.colEXOADD_DEDUCTIBLE_ADD.FieldName = "EXOADD_DEDUCTIBLE_ADD"
        Me.colEXOADD_DEDUCTIBLE_ADD.Name = "colEXOADD_DEDUCTIBLE_ADD"
        Me.colEXOADD_DEDUCTIBLE_ADD.Visible = True
        Me.colEXOADD_DEDUCTIBLE_ADD.VisibleIndex = 3
        Me.colEXOADD_DEDUCTIBLE_ADD.Width = 100
        '
        'colRowIndex1
        '
        Me.colRowIndex1.FieldName = "RowIndex"
        Me.colRowIndex1.Name = "colRowIndex1"
        '
        'colPecentageAmount1
        '
        Me.colPecentageAmount1.FieldName = "PecentageAmount"
        Me.colPecentageAmount1.Name = "colPecentageAmount1"
        Me.colPecentageAmount1.OptionsColumn.AllowEdit = False
        Me.colPecentageAmount1.OptionsColumn.TabStop = False
        Me.colPecentageAmount1.Visible = True
        Me.colPecentageAmount1.VisibleIndex = 7
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.OTHEREXAPPRDONATIONBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GridView2
        GridLevelNode1.RelationName = "FK_OTHER_EXAPPRDONATION_OTHER_EXAPPRDONATION_DETAIL"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(0, 31)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtNumberic, Me.txtNote, Me.cboSourceNo, Me.chkBox, Me.txtPercentage})
        Me.GridControl1.Size = New System.Drawing.Size(1057, 386)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'OTHEREXAPPRDONATIONBindingSource
        '
        Me.OTHEREXAPPRDONATIONBindingSource.DataMember = "OTHER_EXAPPRDONATION"
        Me.OTHEREXAPPRDONATIONBindingSource.DataSource = Me.DsPNL1
        '
        'DsPNL1
        '
        Me.DsPNL1.DataSetName = "dsPNL"
        Me.DsPNL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEXOAD_KEY, Me.colEXOAD_EXOADKEY, Me.colEXOAD_SOURCENO, Me.colEXOAD_DESC, Me.colEXOAD_AMOUNT, Me.colEXOAD_TYPE, Me.colEXOAD_DEDUCTIBLE, Me.colEXOAD_DEDUCTIBLE_ADD, Me.colPecentage, Me.colEXOAD_NOTE, Me.colEXOAD_DETAIL, Me.colRowIndex, Me.colPecentageAmount})
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
        'colEXOAD_KEY
        '
        Me.colEXOAD_KEY.FieldName = "EXOAD_KEY"
        Me.colEXOAD_KEY.Name = "colEXOAD_KEY"
        '
        'colEXOAD_EXOADKEY
        '
        Me.colEXOAD_EXOADKEY.FieldName = "EXOAD_EXOADKEY"
        Me.colEXOAD_EXOADKEY.Name = "colEXOAD_EXOADKEY"
        '
        'colEXOAD_SOURCENO
        '
        Me.colEXOAD_SOURCENO.Caption = "Source No"
        Me.colEXOAD_SOURCENO.ColumnEdit = Me.cboSourceNo
        Me.colEXOAD_SOURCENO.FieldName = "EXOAD_SOURCENO"
        Me.colEXOAD_SOURCENO.Name = "colEXOAD_SOURCENO"
        Me.colEXOAD_SOURCENO.Visible = True
        Me.colEXOAD_SOURCENO.VisibleIndex = 0
        Me.colEXOAD_SOURCENO.Width = 80
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
        'colEXOAD_DESC
        '
        Me.colEXOAD_DESC.Caption = "Description"
        Me.colEXOAD_DESC.FieldName = "EXOAD_DESC"
        Me.colEXOAD_DESC.Name = "colEXOAD_DESC"
        Me.colEXOAD_DESC.Visible = True
        Me.colEXOAD_DESC.VisibleIndex = 1
        Me.colEXOAD_DESC.Width = 300
        '
        'colEXOAD_AMOUNT
        '
        Me.colEXOAD_AMOUNT.Caption = "Amount"
        Me.colEXOAD_AMOUNT.ColumnEdit = Me.txtNumberic
        Me.colEXOAD_AMOUNT.FieldName = "EXOAD_AMOUNT"
        Me.colEXOAD_AMOUNT.Name = "colEXOAD_AMOUNT"
        Me.colEXOAD_AMOUNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EXOAD_AMOUNT", "SUM={0:0.##}")})
        Me.colEXOAD_AMOUNT.Visible = True
        Me.colEXOAD_AMOUNT.VisibleIndex = 2
        Me.colEXOAD_AMOUNT.Width = 120
        '
        'colEXOAD_TYPE
        '
        Me.colEXOAD_TYPE.Caption = "Type"
        Me.colEXOAD_TYPE.FieldName = "EXOAD_TYPE"
        Me.colEXOAD_TYPE.Name = "colEXOAD_TYPE"
        Me.colEXOAD_TYPE.Visible = True
        Me.colEXOAD_TYPE.VisibleIndex = 3
        Me.colEXOAD_TYPE.Width = 100
        '
        'colEXOAD_DEDUCTIBLE
        '
        Me.colEXOAD_DEDUCTIBLE.Caption = "Add Back"
        Me.colEXOAD_DEDUCTIBLE.ColumnEdit = Me.chkBox
        Me.colEXOAD_DEDUCTIBLE.FieldName = "EXOAD_DEDUCTIBLE"
        Me.colEXOAD_DEDUCTIBLE.Name = "colEXOAD_DEDUCTIBLE"
        Me.colEXOAD_DEDUCTIBLE.Visible = True
        Me.colEXOAD_DEDUCTIBLE.VisibleIndex = 4
        Me.colEXOAD_DEDUCTIBLE.Width = 100
        '
        'colEXOAD_DEDUCTIBLE_ADD
        '
        Me.colEXOAD_DEDUCTIBLE_ADD.Caption = "Deduct"
        Me.colEXOAD_DEDUCTIBLE_ADD.ColumnEdit = Me.chkBox
        Me.colEXOAD_DEDUCTIBLE_ADD.FieldName = "EXOAD_DEDUCTIBLE_ADD"
        Me.colEXOAD_DEDUCTIBLE_ADD.Name = "colEXOAD_DEDUCTIBLE_ADD"
        Me.colEXOAD_DEDUCTIBLE_ADD.Visible = True
        Me.colEXOAD_DEDUCTIBLE_ADD.VisibleIndex = 5
        Me.colEXOAD_DEDUCTIBLE_ADD.Width = 100
        '
        'colPecentage
        '
        Me.colPecentage.Caption = "Percentage %"
        Me.colPecentage.ColumnEdit = Me.txtPercentage
        Me.colPecentage.FieldName = "Pecentage"
        Me.colPecentage.Name = "colPecentage"
        Me.colPecentage.Visible = True
        Me.colPecentage.VisibleIndex = 6
        Me.colPecentage.Width = 100
        '
        'colEXOAD_NOTE
        '
        Me.colEXOAD_NOTE.Caption = "Remarks"
        Me.colEXOAD_NOTE.ColumnEdit = Me.txtNote
        Me.colEXOAD_NOTE.FieldName = "EXOAD_NOTE"
        Me.colEXOAD_NOTE.Name = "colEXOAD_NOTE"
        Me.colEXOAD_NOTE.Visible = True
        Me.colEXOAD_NOTE.VisibleIndex = 7
        Me.colEXOAD_NOTE.Width = 300
        '
        'colEXOAD_DETAIL
        '
        Me.colEXOAD_DETAIL.Caption = "Details"
        Me.colEXOAD_DETAIL.FieldName = "EXOAD_DETAIL"
        Me.colEXOAD_DETAIL.Name = "colEXOAD_DETAIL"
        Me.colEXOAD_DETAIL.OptionsColumn.ReadOnly = True
        Me.colEXOAD_DETAIL.OptionsColumn.TabStop = False
        Me.colEXOAD_DETAIL.Visible = True
        Me.colEXOAD_DETAIL.VisibleIndex = 8
        Me.colEXOAD_DETAIL.Width = 100
        '
        'colRowIndex
        '
        Me.colRowIndex.FieldName = "RowIndex"
        Me.colRowIndex.Name = "colRowIndex"
        '
        'colPecentageAmount
        '
        Me.colPecentageAmount.FieldName = "PecentageAmount"
        Me.colPecentageAmount.Name = "colPecentageAmount"
        Me.colPecentageAmount.OptionsColumn.AllowEdit = False
        Me.colPecentageAmount.OptionsColumn.TabStop = False
        Me.colPecentageAmount.Visible = True
        Me.colPecentageAmount.VisibleIndex = 9
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnAdd, Me.btnAddChild, Me.btnDelete, Me.btnExpand, Me.chkIncludeInReport, Me.btnMoveUp, Me.btnMoveDown, Me.btnNote})
        Me.BarManager1.MaxItemId = 15
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4, Me.RepositoryItemCheckEdit1})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(31, 109)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.btnAddChild), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExpand), New DevExpress.XtraBars.LinkPersistInfo(Me.chkIncludeInReport), New DevExpress.XtraBars.LinkPersistInfo(Me.btnMoveUp), New DevExpress.XtraBars.LinkPersistInfo(Me.btnMoveDown), New DevExpress.XtraBars.LinkPersistInfo(Me.btnNote)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DisableClose = True
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'btnAdd
        '
        Me.btnAdd.Caption = "Add Data"
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
        Me.btnAddChild.Caption = "Add Details Data"
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
        Me.btnDelete.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D))
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem3.Text = "Delete record"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Delete record [Delete]"
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.btnDelete.SuperTip = SuperToolTip3
        '
        'btnExpand
        '
        Me.btnExpand.Caption = "Expand Details"
        Me.btnExpand.Id = 8
        Me.btnExpand.ImageOptions.Image = CType(resources.GetObject("btnExpand.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExpand.ImageOptions.LargeImage = CType(resources.GetObject("btnExpand.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnExpand.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E))
        Me.btnExpand.Name = "btnExpand"
        Me.btnExpand.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem4.Text = "Expand child"
        ToolTipItem4.LeftIndent = 6
        ToolTipItem4.Text = "Expand selected row Ctrl + E"
        SuperToolTip4.Items.Add(ToolTipTitleItem4)
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.btnExpand.SuperTip = SuperToolTip4
        '
        'chkIncludeInReport
        '
        Me.chkIncludeInReport.Caption = "Include in Report :"
        Me.chkIncludeInReport.Edit = Me.RepositoryItemCheckEdit1
        Me.chkIncludeInReport.EditValue = True
        Me.chkIncludeInReport.EditWidth = 56
        Me.chkIncludeInReport.Id = 11
        Me.chkIncludeInReport.Name = "chkIncludeInReport"
        Me.chkIncludeInReport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem5.Text = "Include in Report"
        ToolTipItem5.LeftIndent = 6
        ToolTipItem5.Text = "Include all details item in report."
        SuperToolTip5.Items.Add(ToolTipTitleItem5)
        SuperToolTip5.Items.Add(ToolTipItem5)
        Me.chkIncludeInReport.SuperTip = SuperToolTip5
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Yes"
        Me.RepositoryItemCheckEdit1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'btnMoveUp
        '
        Me.btnMoveUp.Caption = "Move Up"
        Me.btnMoveUp.Id = 12
        Me.btnMoveUp.ImageOptions.Image = CType(resources.GetObject("btnMoveUp.ImageOptions.Image"), System.Drawing.Image)
        Me.btnMoveUp.ImageOptions.LargeImage = CType(resources.GetObject("btnMoveUp.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnMoveUp.Name = "btnMoveUp"
        Me.btnMoveUp.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnMoveDown
        '
        Me.btnMoveDown.Caption = "Move Down"
        Me.btnMoveDown.Id = 13
        Me.btnMoveDown.ImageOptions.Image = CType(resources.GetObject("btnMoveDown.ImageOptions.Image"), System.Drawing.Image)
        Me.btnMoveDown.ImageOptions.LargeImage = CType(resources.GetObject("btnMoveDown.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnMoveDown.Name = "btnMoveDown"
        Me.btnMoveDown.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnNote
        '
        Me.btnNote.Caption = "Note"
        Me.btnNote.Id = 14
        Me.btnNote.ImageOptions.Image = CType(resources.GetObject("btnNote.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNote.ImageOptions.LargeImage = CType(resources.GetObject("btnNote.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnNote.Name = "btnNote"
        Me.btnNote.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1057, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 417)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1057, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 386)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1057, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
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
        'ucPNL_p3DonationApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "ucPNL_p3DonationApp"
        Me.Size = New System.Drawing.Size(1057, 417)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumberic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPercentage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OTHEREXAPPRDONATIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsPNL As EasyTemplate_Taxcom.dsPNL
    Friend WithEvents DsPNL1 As EasyTemplate_Taxcom.dsPNL
    Friend WithEvents BUSINESSSOURCEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtNumberic As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtPercentage As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtNote As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents chkBox As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cboSourceNo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colEXOADD_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOADD_EXOADKEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOADD_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOADD_EXOADDKEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOADD_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOADD_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPecentage1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOADD_NOTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOADD_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOADD_DEDUCTIBLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOADD_DEDUCTIBLE_ADD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRowIndex1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OTHEREXAPPRDONATIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colEXOAD_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOAD_EXOADKEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOAD_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOAD_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOAD_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPecentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOAD_NOTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOAD_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOAD_DEDUCTIBLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOAD_DEDUCTIBLE_ADD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOAD_DETAIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRowIndex As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPecentageAmount1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPecentageAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddChild As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExpand As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents chkIncludeInReport As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnMoveUp As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMoveDown As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

End Class
