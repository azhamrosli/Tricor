﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPNL_p2ExemptDividend
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucPNL_p2ExemptDividend))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNOBRID_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOBRID_NOBRIKEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOBRID_NOBRIDKEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOBRID_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOBRID_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNumberic = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colNOBRID_NOTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNote = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colNOBRID_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.EXEMPTDIVIDENDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPNL1 = New EasyTemplate_Taxcom.dsPNL()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colED_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colED_EDKEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colED_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboSourceNo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BUSINESSSOURCEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colED_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colED_COMPANY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colED_TIERSTATUS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboStatus = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colED_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNote = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumberic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXEMPTDIVIDENDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPNL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSourceNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BUSINESSSOURCEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNOBRID_KEY, Me.colNOBRID_NOBRIKEY, Me.colNOBRID_NOBRIDKEY, Me.colNOBRID_DESC, Me.colNOBRID_AMOUNT, Me.colNOBRID_NOTE, Me.colNOBRID_SOURCENO})
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
        'colNOBRID_KEY
        '
        Me.colNOBRID_KEY.FieldName = "NOBRID_KEY"
        Me.colNOBRID_KEY.Name = "colNOBRID_KEY"
        '
        'colNOBRID_NOBRIKEY
        '
        Me.colNOBRID_NOBRIKEY.FieldName = "NOBRID_NOBRIKEY"
        Me.colNOBRID_NOBRIKEY.Name = "colNOBRID_NOBRIKEY"
        '
        'colNOBRID_NOBRIDKEY
        '
        Me.colNOBRID_NOBRIDKEY.FieldName = "NOBRID_NOBRIDKEY"
        Me.colNOBRID_NOBRIDKEY.Name = "colNOBRID_NOBRIDKEY"
        '
        'colNOBRID_DESC
        '
        Me.colNOBRID_DESC.Caption = "Description"
        Me.colNOBRID_DESC.FieldName = "NOBRID_DESC"
        Me.colNOBRID_DESC.Name = "colNOBRID_DESC"
        Me.colNOBRID_DESC.Visible = True
        Me.colNOBRID_DESC.VisibleIndex = 0
        Me.colNOBRID_DESC.Width = 300
        '
        'colNOBRID_AMOUNT
        '
        Me.colNOBRID_AMOUNT.Caption = "Amount"
        Me.colNOBRID_AMOUNT.ColumnEdit = Me.txtNumberic
        Me.colNOBRID_AMOUNT.FieldName = "NOBRID_AMOUNT"
        Me.colNOBRID_AMOUNT.Name = "colNOBRID_AMOUNT"
        Me.colNOBRID_AMOUNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NOBRID_AMOUNT", "SUM={0:0.##}")})
        Me.colNOBRID_AMOUNT.Visible = True
        Me.colNOBRID_AMOUNT.VisibleIndex = 1
        Me.colNOBRID_AMOUNT.Width = 120
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
        'colNOBRID_NOTE
        '
        Me.colNOBRID_NOTE.Caption = "Remarks"
        Me.colNOBRID_NOTE.ColumnEdit = Me.txtNote
        Me.colNOBRID_NOTE.FieldName = "NOBRID_NOTE"
        Me.colNOBRID_NOTE.Name = "colNOBRID_NOTE"
        Me.colNOBRID_NOTE.Visible = True
        Me.colNOBRID_NOTE.VisibleIndex = 2
        Me.colNOBRID_NOTE.Width = 300
        '
        'txtNote
        '
        Me.txtNote.MaxLength = 1500
        Me.txtNote.Name = "txtNote"
        '
        'colNOBRID_SOURCENO
        '
        Me.colNOBRID_SOURCENO.FieldName = "NOBRID_SOURCENO"
        Me.colNOBRID_SOURCENO.Name = "colNOBRID_SOURCENO"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.EXEMPTDIVIDENDBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 31)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtNumberic, Me.txtNote, Me.cboSourceNo, Me.dtDate, Me.cboStatus})
        Me.GridControl1.Size = New System.Drawing.Size(758, 386)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'EXEMPTDIVIDENDBindingSource
        '
        Me.EXEMPTDIVIDENDBindingSource.DataMember = "EXEMPT_DIVIDEND"
        Me.EXEMPTDIVIDENDBindingSource.DataSource = Me.DsPNL1
        '
        'DsPNL1
        '
        Me.DsPNL1.DataSetName = "dsPNL"
        Me.DsPNL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colED_KEY, Me.colED_EDKEY, Me.colED_SOURCENO, Me.colED_DATE, Me.colED_COMPANY, Me.colED_TIERSTATUS, Me.colED_AMOUNT})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.GridView1.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GridView1.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled
        Me.GridView1.OptionsDetail.SmartDetailHeight = True
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colED_KEY
        '
        Me.colED_KEY.FieldName = "ED_KEY"
        Me.colED_KEY.Name = "colED_KEY"
        '
        'colED_EDKEY
        '
        Me.colED_EDKEY.FieldName = "ED_EDKEY"
        Me.colED_EDKEY.Name = "colED_EDKEY"
        '
        'colED_SOURCENO
        '
        Me.colED_SOURCENO.Caption = "Source No"
        Me.colED_SOURCENO.ColumnEdit = Me.cboSourceNo
        Me.colED_SOURCENO.FieldName = "ED_SOURCENO"
        Me.colED_SOURCENO.Name = "colED_SOURCENO"
        Me.colED_SOURCENO.Visible = True
        Me.colED_SOURCENO.VisibleIndex = 0
        Me.colED_SOURCENO.Width = 80
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
        'colED_DATE
        '
        Me.colED_DATE.Caption = "Payment Date"
        Me.colED_DATE.ColumnEdit = Me.dtDate
        Me.colED_DATE.FieldName = "ED_DATE"
        Me.colED_DATE.Name = "colED_DATE"
        Me.colED_DATE.Visible = True
        Me.colED_DATE.VisibleIndex = 1
        Me.colED_DATE.Width = 100
        '
        'dtDate
        '
        Me.dtDate.AutoHeight = False
        Me.dtDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDate.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDate.Name = "dtDate"
        '
        'colED_COMPANY
        '
        Me.colED_COMPANY.Caption = "Company Name"
        Me.colED_COMPANY.ColumnEdit = Me.txtNote
        Me.colED_COMPANY.FieldName = "ED_COMPANY"
        Me.colED_COMPANY.Name = "colED_COMPANY"
        Me.colED_COMPANY.Visible = True
        Me.colED_COMPANY.VisibleIndex = 2
        Me.colED_COMPANY.Width = 300
        '
        'colED_TIERSTATUS
        '
        Me.colED_TIERSTATUS.Caption = "Exempt Status"
        Me.colED_TIERSTATUS.ColumnEdit = Me.cboStatus
        Me.colED_TIERSTATUS.FieldName = "ED_TIERSTATUS"
        Me.colED_TIERSTATUS.Name = "colED_TIERSTATUS"
        Me.colED_TIERSTATUS.Visible = True
        Me.colED_TIERSTATUS.VisibleIndex = 3
        Me.colED_TIERSTATUS.Width = 200
        '
        'cboStatus
        '
        Me.cboStatus.AutoHeight = False
        Me.cboStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboStatus.Items.AddRange(New Object() {"First Tier", "Second Tier", "Single Tier"})
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colED_AMOUNT
        '
        Me.colED_AMOUNT.Caption = "Amount"
        Me.colED_AMOUNT.ColumnEdit = Me.txtNumberic
        Me.colED_AMOUNT.FieldName = "ED_AMOUNT"
        Me.colED_AMOUNT.Name = "colED_AMOUNT"
        Me.colED_AMOUNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ED_AMOUNT", "SUM={0:0.##}")})
        Me.colED_AMOUNT.Visible = True
        Me.colED_AMOUNT.VisibleIndex = 4
        Me.colED_AMOUNT.Width = 120
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnAdd, Me.btnDelete, Me.btnNote})
        Me.BarManager1.MaxItemId = 10
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(31, 109)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.btnNote)})
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
        'btnDelete
        '
        Me.btnDelete.Caption = "Delete"
        Me.btnDelete.Id = 4
        Me.btnDelete.ImageOptions.Image = CType(resources.GetObject("btnDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelete.ImageOptions.LargeImage = CType(resources.GetObject("btnDelete.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnDelete.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D))
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem2.Text = "Delete record"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Delete record Ctrl + Y"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.btnDelete.SuperTip = SuperToolTip2
        '
        'btnNote
        '
        Me.btnNote.Caption = "Note"
        Me.btnNote.Id = 9
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
        Me.barDockControlTop.Size = New System.Drawing.Size(758, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 417)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(758, 0)
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
        Me.barDockControlRight.Location = New System.Drawing.Point(758, 31)
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
        'ucPNL_p2ExemptDividend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "ucPNL_p2ExemptDividend"
        Me.Size = New System.Drawing.Size(758, 417)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumberic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXEMPTDIVIDENDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPNL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSourceNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BUSINESSSOURCEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsPNL As EasyTemplate_Taxcom.dsPNL
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents txtNumberic As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtNote As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cboSourceNo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DsPNL1 As EasyTemplate_Taxcom.dsPNL
    Friend WithEvents BUSINESSSOURCEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colNOBRID_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOBRID_NOBRIKEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOBRID_NOBRIDKEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOBRID_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOBRID_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOBRID_NOTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOBRID_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents cboStatus As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents EXEMPTDIVIDENDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colED_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colED_EDKEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colED_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colED_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colED_COMPANY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colED_TIERSTATUS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colED_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnNote As DevExpress.XtraBars.BarButtonItem

End Class
