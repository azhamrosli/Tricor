﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPNL_p4LeavePass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucPNL_p4LeavePass))
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
        Me.colEXOLPD_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOLPD_EXOLPKEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOLPD_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOLPD_EXOLPDKEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOLPD_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOLPD_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNumberic = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colPecentage1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtPercentage = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colEXOLPD_NOTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNote = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colEXOLPD_DEDUCTIBLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkBox = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colEXOLPD_DEDUCTIBLE_ADD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRowIndex1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPecentageAmount1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.OTHEREXLEAVEPASSAGEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPNL1 = New EasyTemplate_Taxcom.dsPNL()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEXOLP_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOLP_EXOLPKEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOLP_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboSourceNo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BUSINESSSOURCEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colEXOLP_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOLP_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPecentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOLP_NOTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOLP_DEDUCTIBLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOLP_DEDUCTIBLE_ADD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOLP_DETAIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRowIndex = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPecentageAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddChild = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteChild = New DevExpress.XtraBars.BarButtonItem()
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
        CType(Me.OTHEREXLEAVEPASSAGEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEXOLPD_KEY, Me.colEXOLPD_EXOLPKEY, Me.colEXOLPD_SOURCENO, Me.colEXOLPD_EXOLPDKEY, Me.colEXOLPD_DESC, Me.colEXOLPD_AMOUNT, Me.colPecentage1, Me.colEXOLPD_NOTE, Me.colEXOLPD_DEDUCTIBLE, Me.colEXOLPD_DEDUCTIBLE_ADD, Me.colRowIndex1, Me.colPecentageAmount1})
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
        'colEXOLPD_KEY
        '
        Me.colEXOLPD_KEY.FieldName = "EXOLPD_KEY"
        Me.colEXOLPD_KEY.Name = "colEXOLPD_KEY"
        '
        'colEXOLPD_EXOLPKEY
        '
        Me.colEXOLPD_EXOLPKEY.FieldName = "EXOLPD_EXOLPKEY"
        Me.colEXOLPD_EXOLPKEY.Name = "colEXOLPD_EXOLPKEY"
        '
        'colEXOLPD_SOURCENO
        '
        Me.colEXOLPD_SOURCENO.FieldName = "EXOLPD_SOURCENO"
        Me.colEXOLPD_SOURCENO.Name = "colEXOLPD_SOURCENO"
        '
        'colEXOLPD_EXOLPDKEY
        '
        Me.colEXOLPD_EXOLPDKEY.FieldName = "EXOLPD_EXOLPDKEY"
        Me.colEXOLPD_EXOLPDKEY.Name = "colEXOLPD_EXOLPDKEY"
        '
        'colEXOLPD_DESC
        '
        Me.colEXOLPD_DESC.Caption = "Description"
        Me.colEXOLPD_DESC.FieldName = "EXOLPD_DESC"
        Me.colEXOLPD_DESC.Name = "colEXOLPD_DESC"
        Me.colEXOLPD_DESC.Visible = True
        Me.colEXOLPD_DESC.VisibleIndex = 0
        Me.colEXOLPD_DESC.Width = 300
        '
        'colEXOLPD_AMOUNT
        '
        Me.colEXOLPD_AMOUNT.Caption = "Amount"
        Me.colEXOLPD_AMOUNT.ColumnEdit = Me.txtNumberic
        Me.colEXOLPD_AMOUNT.FieldName = "EXOLPD_AMOUNT"
        Me.colEXOLPD_AMOUNT.Name = "colEXOLPD_AMOUNT"
        Me.colEXOLPD_AMOUNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EXOLPD_AMOUNT", "SUM={0:0.##}")})
        Me.colEXOLPD_AMOUNT.Visible = True
        Me.colEXOLPD_AMOUNT.VisibleIndex = 1
        Me.colEXOLPD_AMOUNT.Width = 120
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
        Me.colPecentage1.VisibleIndex = 2
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
        'colEXOLPD_NOTE
        '
        Me.colEXOLPD_NOTE.Caption = "Remarks"
        Me.colEXOLPD_NOTE.ColumnEdit = Me.txtNote
        Me.colEXOLPD_NOTE.FieldName = "EXOLPD_NOTE"
        Me.colEXOLPD_NOTE.Name = "colEXOLPD_NOTE"
        Me.colEXOLPD_NOTE.Visible = True
        Me.colEXOLPD_NOTE.VisibleIndex = 3
        Me.colEXOLPD_NOTE.Width = 300
        '
        'txtNote
        '
        Me.txtNote.MaxLength = 1500
        Me.txtNote.Name = "txtNote"
        '
        'colEXOLPD_DEDUCTIBLE
        '
        Me.colEXOLPD_DEDUCTIBLE.Caption = "Add Back"
        Me.colEXOLPD_DEDUCTIBLE.ColumnEdit = Me.chkBox
        Me.colEXOLPD_DEDUCTIBLE.FieldName = "EXOLPD_DEDUCTIBLE"
        Me.colEXOLPD_DEDUCTIBLE.Name = "colEXOLPD_DEDUCTIBLE"
        Me.colEXOLPD_DEDUCTIBLE.Visible = True
        Me.colEXOLPD_DEDUCTIBLE.VisibleIndex = 4
        Me.colEXOLPD_DEDUCTIBLE.Width = 100
        '
        'chkBox
        '
        Me.chkBox.AutoHeight = False
        Me.chkBox.Name = "chkBox"
        Me.chkBox.ValueGrayed = True
        '
        'colEXOLPD_DEDUCTIBLE_ADD
        '
        Me.colEXOLPD_DEDUCTIBLE_ADD.Caption = "Deduct"
        Me.colEXOLPD_DEDUCTIBLE_ADD.ColumnEdit = Me.chkBox
        Me.colEXOLPD_DEDUCTIBLE_ADD.FieldName = "EXOLPD_DEDUCTIBLE_ADD"
        Me.colEXOLPD_DEDUCTIBLE_ADD.Name = "colEXOLPD_DEDUCTIBLE_ADD"
        Me.colEXOLPD_DEDUCTIBLE_ADD.Visible = True
        Me.colEXOLPD_DEDUCTIBLE_ADD.VisibleIndex = 5
        Me.colEXOLPD_DEDUCTIBLE_ADD.Width = 100
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
        Me.colPecentageAmount1.VisibleIndex = 6
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.OTHEREXLEAVEPASSAGEBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        GridLevelNode1.LevelTemplate = Me.GridView2
        GridLevelNode1.RelationName = "FK_OTHER_EXLEAVEPASSAGE_OTHER_EXLEAVEPASSAGE_DETAIL"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(0, 39)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtNumberic, Me.txtNote, Me.cboSourceNo, Me.chkBox, Me.txtPercentage})
        Me.GridControl1.Size = New System.Drawing.Size(1182, 474)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'OTHEREXLEAVEPASSAGEBindingSource
        '
        Me.OTHEREXLEAVEPASSAGEBindingSource.DataMember = "OTHER_EXLEAVEPASSAGE"
        Me.OTHEREXLEAVEPASSAGEBindingSource.DataSource = Me.DsPNL1
        '
        'DsPNL1
        '
        Me.DsPNL1.DataSetName = "dsPNL"
        Me.DsPNL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEXOLP_KEY, Me.colEXOLP_EXOLPKEY, Me.colEXOLP_SOURCENO, Me.colEXOLP_DESC, Me.colEXOLP_AMOUNT, Me.colPecentage, Me.colEXOLP_NOTE, Me.colEXOLP_DEDUCTIBLE, Me.colEXOLP_DEDUCTIBLE_ADD, Me.colEXOLP_DETAIL, Me.colRowIndex, Me.colPecentageAmount})
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
        'colEXOLP_KEY
        '
        Me.colEXOLP_KEY.FieldName = "EXOLP_KEY"
        Me.colEXOLP_KEY.Name = "colEXOLP_KEY"
        '
        'colEXOLP_EXOLPKEY
        '
        Me.colEXOLP_EXOLPKEY.FieldName = "EXOLP_EXOLPKEY"
        Me.colEXOLP_EXOLPKEY.Name = "colEXOLP_EXOLPKEY"
        '
        'colEXOLP_SOURCENO
        '
        Me.colEXOLP_SOURCENO.Caption = "Source No"
        Me.colEXOLP_SOURCENO.ColumnEdit = Me.cboSourceNo
        Me.colEXOLP_SOURCENO.FieldName = "EXOLP_SOURCENO"
        Me.colEXOLP_SOURCENO.Name = "colEXOLP_SOURCENO"
        Me.colEXOLP_SOURCENO.Visible = True
        Me.colEXOLP_SOURCENO.VisibleIndex = 0
        Me.colEXOLP_SOURCENO.Width = 80
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
        'colEXOLP_DESC
        '
        Me.colEXOLP_DESC.Caption = "Description"
        Me.colEXOLP_DESC.FieldName = "EXOLP_DESC"
        Me.colEXOLP_DESC.Name = "colEXOLP_DESC"
        Me.colEXOLP_DESC.Visible = True
        Me.colEXOLP_DESC.VisibleIndex = 1
        Me.colEXOLP_DESC.Width = 300
        '
        'colEXOLP_AMOUNT
        '
        Me.colEXOLP_AMOUNT.Caption = "Amount"
        Me.colEXOLP_AMOUNT.ColumnEdit = Me.txtNumberic
        Me.colEXOLP_AMOUNT.FieldName = "EXOLP_AMOUNT"
        Me.colEXOLP_AMOUNT.Name = "colEXOLP_AMOUNT"
        Me.colEXOLP_AMOUNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EXOLP_AMOUNT", "SUM={0:0.##}")})
        Me.colEXOLP_AMOUNT.Visible = True
        Me.colEXOLP_AMOUNT.VisibleIndex = 2
        Me.colEXOLP_AMOUNT.Width = 120
        '
        'colPecentage
        '
        Me.colPecentage.Caption = "Percentage %"
        Me.colPecentage.ColumnEdit = Me.txtPercentage
        Me.colPecentage.FieldName = "Pecentage"
        Me.colPecentage.Name = "colPecentage"
        Me.colPecentage.Visible = True
        Me.colPecentage.VisibleIndex = 3
        Me.colPecentage.Width = 100
        '
        'colEXOLP_NOTE
        '
        Me.colEXOLP_NOTE.Caption = "Remarks"
        Me.colEXOLP_NOTE.ColumnEdit = Me.txtNote
        Me.colEXOLP_NOTE.FieldName = "EXOLP_NOTE"
        Me.colEXOLP_NOTE.Name = "colEXOLP_NOTE"
        Me.colEXOLP_NOTE.Visible = True
        Me.colEXOLP_NOTE.VisibleIndex = 4
        Me.colEXOLP_NOTE.Width = 300
        '
        'colEXOLP_DEDUCTIBLE
        '
        Me.colEXOLP_DEDUCTIBLE.Caption = "Add Back"
        Me.colEXOLP_DEDUCTIBLE.ColumnEdit = Me.chkBox
        Me.colEXOLP_DEDUCTIBLE.FieldName = "EXOLP_DEDUCTIBLE"
        Me.colEXOLP_DEDUCTIBLE.Name = "colEXOLP_DEDUCTIBLE"
        Me.colEXOLP_DEDUCTIBLE.Visible = True
        Me.colEXOLP_DEDUCTIBLE.VisibleIndex = 5
        Me.colEXOLP_DEDUCTIBLE.Width = 100
        '
        'colEXOLP_DEDUCTIBLE_ADD
        '
        Me.colEXOLP_DEDUCTIBLE_ADD.Caption = "Deduct"
        Me.colEXOLP_DEDUCTIBLE_ADD.ColumnEdit = Me.chkBox
        Me.colEXOLP_DEDUCTIBLE_ADD.FieldName = "EXOLP_DEDUCTIBLE_ADD"
        Me.colEXOLP_DEDUCTIBLE_ADD.Name = "colEXOLP_DEDUCTIBLE_ADD"
        Me.colEXOLP_DEDUCTIBLE_ADD.Visible = True
        Me.colEXOLP_DEDUCTIBLE_ADD.VisibleIndex = 6
        Me.colEXOLP_DEDUCTIBLE_ADD.Width = 100
        '
        'colEXOLP_DETAIL
        '
        Me.colEXOLP_DETAIL.Caption = "Details"
        Me.colEXOLP_DETAIL.FieldName = "EXOLP_DETAIL"
        Me.colEXOLP_DETAIL.Name = "colEXOLP_DETAIL"
        Me.colEXOLP_DETAIL.OptionsColumn.ReadOnly = True
        Me.colEXOLP_DETAIL.OptionsColumn.TabStop = False
        Me.colEXOLP_DETAIL.Visible = True
        Me.colEXOLP_DETAIL.VisibleIndex = 7
        Me.colEXOLP_DETAIL.Width = 100
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
        Me.colPecentageAmount.VisibleIndex = 8
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnAdd, Me.btnAddChild, Me.btnDelete, Me.btnDeleteChild, Me.btnExpand, Me.chkIncludeInReport, Me.btnMoveUp, Me.btnMoveDown, Me.btnNote})
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
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.btnAddChild), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDeleteChild), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExpand), New DevExpress.XtraBars.LinkPersistInfo(Me.chkIncludeInReport), New DevExpress.XtraBars.LinkPersistInfo(Me.btnMoveUp), New DevExpress.XtraBars.LinkPersistInfo(Me.btnMoveDown), New DevExpress.XtraBars.LinkPersistInfo(Me.btnNote)})
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
        Me.btnDelete.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem3.Text = "Delete record"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Delete record [Delete]"
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.btnDelete.SuperTip = SuperToolTip3
        '
        'btnDeleteChild
        '
        Me.btnDeleteChild.Caption = "Delete Details"
        Me.btnDeleteChild.Id = 5
        Me.btnDeleteChild.ImageOptions.Image = CType(resources.GetObject("btnDeleteChild.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDeleteChild.ImageOptions.LargeImage = CType(resources.GetObject("btnDeleteChild.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnDeleteChild.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete))
        Me.btnDeleteChild.Name = "btnDeleteChild"
        Me.btnDeleteChild.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem4.Text = "Delete record"
        ToolTipItem4.LeftIndent = 6
        ToolTipItem4.Text = "Delete record [Ctrl + Delete]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "How to use : Please select the main row first then" & _
    " continues with select detail row(s)."
        SuperToolTip4.Items.Add(ToolTipTitleItem4)
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.btnDeleteChild.SuperTip = SuperToolTip4
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
        Me.chkIncludeInReport.EditWidth = 56
        Me.chkIncludeInReport.Id = 11
        Me.chkIncludeInReport.Name = "chkIncludeInReport"
        Me.chkIncludeInReport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem6.Text = "Include in Report"
        ToolTipItem6.LeftIndent = 6
        ToolTipItem6.Text = "Include all details item in report."
        SuperToolTip6.Items.Add(ToolTipTitleItem6)
        SuperToolTip6.Items.Add(ToolTipItem6)
        Me.chkIncludeInReport.SuperTip = SuperToolTip6
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
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1182, 39)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 513)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1182, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 39)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 474)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1182, 39)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 474)
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
        'ucPNL_p4LeavePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ucPNL_p4LeavePass"
        Me.Size = New System.Drawing.Size(1182, 513)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumberic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPercentage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OTHEREXLEAVEPASSAGEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents colEXOLP_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOLP_EXOLPKEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOLP_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOLP_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOLP_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPecentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOLP_NOTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOLP_DEDUCTIBLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOLP_DEDUCTIBLE_ADD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOLP_DETAIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRowIndex As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOLPD_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOLPD_EXOLPKEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOLPD_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOLPD_EXOLPDKEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOLPD_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOLPD_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPecentage1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOLPD_NOTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOLPD_DEDUCTIBLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOLPD_DEDUCTIBLE_ADD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRowIndex1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OTHEREXLEAVEPASSAGEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colPecentageAmount1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPecentageAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddChild As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteChild As DevExpress.XtraBars.BarButtonItem
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
