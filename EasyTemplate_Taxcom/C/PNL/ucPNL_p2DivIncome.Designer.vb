<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPNL_p2DivIncome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucPNL_p2DivIncome))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNTD_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNTD_NTKEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNTD_NTDKEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNTD_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNTD_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNumberic = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colNTD_NOTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNote = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colNTD_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNTD_NTKEYN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.DIVIDENDINCOMEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPNL1 = New EasyTemplate_Taxcom.dsPNL()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDI_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDI_DIVIDENDKEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDI_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboSourceNo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BUSINESSSOURCEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colDI_COMPANY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDI_WARANT_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDI_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colDI_GROSS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDI_TAX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDI_NET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDI_TRANSFER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboTypeIncome = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colDI_CHKREGROSS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDI_TAXRATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDI_REGROSS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDI_TAXDEDUCTION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDI_NETDEDUCTION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDI_ENDDATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDI_TRATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDI_DISCLOSE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDI_Percentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDI_PercentageAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.cboTypeofIncome = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.txtPercentage = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.cboSourceNo1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.chkDiscloseNet = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.btnNote = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumberic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DIVIDENDINCOMEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPNL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSourceNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BUSINESSSOURCEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTypeIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNTD_KEY, Me.colNTD_NTKEY, Me.colNTD_NTDKEY, Me.colNTD_DESC, Me.colNTD_AMOUNT, Me.colNTD_NOTE, Me.colNTD_SOURCENO, Me.colNTD_NTKEYN})
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
        'colNTD_KEY
        '
        Me.colNTD_KEY.FieldName = "NTD_KEY"
        Me.colNTD_KEY.Name = "colNTD_KEY"
        '
        'colNTD_NTKEY
        '
        Me.colNTD_NTKEY.FieldName = "NTD_NTKEY"
        Me.colNTD_NTKEY.Name = "colNTD_NTKEY"
        '
        'colNTD_NTDKEY
        '
        Me.colNTD_NTDKEY.FieldName = "NTD_NTDKEY"
        Me.colNTD_NTDKEY.Name = "colNTD_NTDKEY"
        '
        'colNTD_DESC
        '
        Me.colNTD_DESC.Caption = "Description"
        Me.colNTD_DESC.FieldName = "NTD_DESC"
        Me.colNTD_DESC.Name = "colNTD_DESC"
        Me.colNTD_DESC.Visible = True
        Me.colNTD_DESC.VisibleIndex = 0
        Me.colNTD_DESC.Width = 300
        '
        'colNTD_AMOUNT
        '
        Me.colNTD_AMOUNT.Caption = "Amount"
        Me.colNTD_AMOUNT.ColumnEdit = Me.txtNumberic
        Me.colNTD_AMOUNT.FieldName = "NTD_AMOUNT"
        Me.colNTD_AMOUNT.Name = "colNTD_AMOUNT"
        Me.colNTD_AMOUNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NTD_AMOUNT", "SUM={0:0.##}")})
        Me.colNTD_AMOUNT.Visible = True
        Me.colNTD_AMOUNT.VisibleIndex = 1
        Me.colNTD_AMOUNT.Width = 120
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
        'colNTD_NOTE
        '
        Me.colNTD_NOTE.Caption = "Remarks"
        Me.colNTD_NOTE.ColumnEdit = Me.txtNote
        Me.colNTD_NOTE.FieldName = "NTD_NOTE"
        Me.colNTD_NOTE.Name = "colNTD_NOTE"
        Me.colNTD_NOTE.Visible = True
        Me.colNTD_NOTE.VisibleIndex = 2
        Me.colNTD_NOTE.Width = 300
        '
        'txtNote
        '
        Me.txtNote.MaxLength = 1500
        Me.txtNote.Name = "txtNote"
        '
        'colNTD_SOURCENO
        '
        Me.colNTD_SOURCENO.Caption = "Remarks"
        Me.colNTD_SOURCENO.ColumnEdit = Me.txtNote
        Me.colNTD_SOURCENO.FieldName = "NTD_SOURCENO"
        Me.colNTD_SOURCENO.Name = "colNTD_SOURCENO"
        Me.colNTD_SOURCENO.Width = 20
        '
        'colNTD_NTKEYN
        '
        Me.colNTD_NTKEYN.FieldName = "NTD_NTKEYN"
        Me.colNTD_NTKEYN.Name = "colNTD_NTKEYN"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.DIVIDENDINCOMEBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Location = New System.Drawing.Point(0, 39)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtNumberic, Me.txtNote, Me.cboSourceNo, Me.dtDate, Me.cboTypeIncome})
        Me.GridControl1.Size = New System.Drawing.Size(1309, 474)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'DIVIDENDINCOMEBindingSource
        '
        Me.DIVIDENDINCOMEBindingSource.AllowNew = True
        Me.DIVIDENDINCOMEBindingSource.DataMember = "DIVIDEND_INCOME"
        Me.DIVIDENDINCOMEBindingSource.DataSource = Me.DsPNL1
        '
        'DsPNL1
        '
        Me.DsPNL1.DataSetName = "dsPNL"
        Me.DsPNL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDI_KEY, Me.colDI_DIVIDENDKEY, Me.colDI_SOURCENO, Me.colDI_COMPANY, Me.colDI_WARANT_NO, Me.colDI_DATE, Me.colDI_GROSS, Me.colDI_TAX, Me.colDI_NET, Me.colDI_TRANSFER, Me.colDI_CHKREGROSS, Me.colDI_TAXRATE, Me.colDI_REGROSS, Me.colDI_TAXDEDUCTION, Me.colDI_NETDEDUCTION, Me.colDI_ENDDATE, Me.colDI_TRATE, Me.colDI_DISCLOSE, Me.colDI_Percentage, Me.colDI_PercentageAmount})
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
        'colDI_KEY
        '
        Me.colDI_KEY.FieldName = "DI_KEY"
        Me.colDI_KEY.Name = "colDI_KEY"
        '
        'colDI_DIVIDENDKEY
        '
        Me.colDI_DIVIDENDKEY.FieldName = "DI_DIVIDENDKEY"
        Me.colDI_DIVIDENDKEY.Name = "colDI_DIVIDENDKEY"
        '
        'colDI_SOURCENO
        '
        Me.colDI_SOURCENO.Caption = "Source No"
        Me.colDI_SOURCENO.ColumnEdit = Me.cboSourceNo
        Me.colDI_SOURCENO.FieldName = "DI_SOURCENO"
        Me.colDI_SOURCENO.Name = "colDI_SOURCENO"
        Me.colDI_SOURCENO.Width = 80
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
        'colDI_COMPANY
        '
        Me.colDI_COMPANY.Caption = "Name of Company(ies)"
        Me.colDI_COMPANY.FieldName = "DI_COMPANY"
        Me.colDI_COMPANY.Name = "colDI_COMPANY"
        Me.colDI_COMPANY.Visible = True
        Me.colDI_COMPANY.VisibleIndex = 0
        Me.colDI_COMPANY.Width = 350
        '
        'colDI_WARANT_NO
        '
        Me.colDI_WARANT_NO.Caption = "Warrant / Divident No."
        Me.colDI_WARANT_NO.FieldName = "DI_WARANT_NO"
        Me.colDI_WARANT_NO.Name = "colDI_WARANT_NO"
        Me.colDI_WARANT_NO.Visible = True
        Me.colDI_WARANT_NO.VisibleIndex = 1
        Me.colDI_WARANT_NO.Width = 150
        '
        'colDI_DATE
        '
        Me.colDI_DATE.Caption = "Date of Payment"
        Me.colDI_DATE.ColumnEdit = Me.dtDate
        Me.colDI_DATE.FieldName = "DI_DATE"
        Me.colDI_DATE.Name = "colDI_DATE"
        Me.colDI_DATE.Visible = True
        Me.colDI_DATE.VisibleIndex = 2
        Me.colDI_DATE.Width = 120
        '
        'dtDate
        '
        Me.dtDate.AutoHeight = False
        Me.dtDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDate.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDate.Name = "dtDate"
        '
        'colDI_GROSS
        '
        Me.colDI_GROSS.Caption = "Gross Divident (RM)"
        Me.colDI_GROSS.ColumnEdit = Me.txtNumberic
        Me.colDI_GROSS.FieldName = "DI_GROSS"
        Me.colDI_GROSS.Name = "colDI_GROSS"
        Me.colDI_GROSS.Visible = True
        Me.colDI_GROSS.VisibleIndex = 3
        Me.colDI_GROSS.Width = 120
        '
        'colDI_TAX
        '
        Me.colDI_TAX.Caption = "Tax Deduction (RM)"
        Me.colDI_TAX.ColumnEdit = Me.txtNumberic
        Me.colDI_TAX.FieldName = "DI_TAX"
        Me.colDI_TAX.Name = "colDI_TAX"
        Me.colDI_TAX.Visible = True
        Me.colDI_TAX.VisibleIndex = 4
        Me.colDI_TAX.Width = 120
        '
        'colDI_NET
        '
        Me.colDI_NET.Caption = "Net Dividend (RM)"
        Me.colDI_NET.ColumnEdit = Me.txtNumberic
        Me.colDI_NET.DisplayFormat.FormatString = "n2"
        Me.colDI_NET.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDI_NET.FieldName = "DI_NET"
        Me.colDI_NET.Name = "colDI_NET"
        Me.colDI_NET.OptionsColumn.AllowEdit = False
        Me.colDI_NET.OptionsColumn.TabStop = False
        Me.colDI_NET.Visible = True
        Me.colDI_NET.VisibleIndex = 5
        Me.colDI_NET.Width = 120
        '
        'colDI_TRANSFER
        '
        Me.colDI_TRANSFER.Caption = "Type of Income (RM)"
        Me.colDI_TRANSFER.ColumnEdit = Me.cboTypeIncome
        Me.colDI_TRANSFER.FieldName = "DI_TRANSFER"
        Me.colDI_TRANSFER.Name = "colDI_TRANSFER"
        Me.colDI_TRANSFER.Width = 150
        '
        'cboTypeIncome
        '
        Me.cboTypeIncome.AutoHeight = False
        Me.cboTypeIncome.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTypeIncome.Items.AddRange(New Object() {"Single Tier", "Trust", "Royalty", "Interest", "Section 4a", "Other", ""})
        Me.cboTypeIncome.Name = "cboTypeIncome"
        '
        'colDI_CHKREGROSS
        '
        Me.colDI_CHKREGROSS.FieldName = "DI_CHKREGROSS"
        Me.colDI_CHKREGROSS.Name = "colDI_CHKREGROSS"
        '
        'colDI_TAXRATE
        '
        Me.colDI_TAXRATE.FieldName = "DI_TAXRATE"
        Me.colDI_TAXRATE.Name = "colDI_TAXRATE"
        '
        'colDI_REGROSS
        '
        Me.colDI_REGROSS.FieldName = "DI_REGROSS"
        Me.colDI_REGROSS.Name = "colDI_REGROSS"
        '
        'colDI_TAXDEDUCTION
        '
        Me.colDI_TAXDEDUCTION.FieldName = "DI_TAXDEDUCTION"
        Me.colDI_TAXDEDUCTION.Name = "colDI_TAXDEDUCTION"
        '
        'colDI_NETDEDUCTION
        '
        Me.colDI_NETDEDUCTION.FieldName = "DI_NETDEDUCTION"
        Me.colDI_NETDEDUCTION.Name = "colDI_NETDEDUCTION"
        '
        'colDI_ENDDATE
        '
        Me.colDI_ENDDATE.FieldName = "DI_ENDDATE"
        Me.colDI_ENDDATE.Name = "colDI_ENDDATE"
        '
        'colDI_TRATE
        '
        Me.colDI_TRATE.FieldName = "DI_TRATE"
        Me.colDI_TRATE.Name = "colDI_TRATE"
        '
        'colDI_DISCLOSE
        '
        Me.colDI_DISCLOSE.FieldName = "DI_DISCLOSE"
        Me.colDI_DISCLOSE.Name = "colDI_DISCLOSE"
        '
        'colDI_Percentage
        '
        Me.colDI_Percentage.Caption = "Percentage"
        Me.colDI_Percentage.FieldName = "DI_Percentage"
        Me.colDI_Percentage.Name = "colDI_Percentage"
        Me.colDI_Percentage.OptionsColumn.AllowEdit = False
        Me.colDI_Percentage.OptionsColumn.TabStop = False
        Me.colDI_Percentage.Visible = True
        Me.colDI_Percentage.VisibleIndex = 6
        Me.colDI_Percentage.Width = 100
        '
        'colDI_PercentageAmount
        '
        Me.colDI_PercentageAmount.Caption = "Percentage Amount"
        Me.colDI_PercentageAmount.FieldName = "DI_PercentageAmount"
        Me.colDI_PercentageAmount.Name = "colDI_PercentageAmount"
        Me.colDI_PercentageAmount.OptionsColumn.AllowEdit = False
        Me.colDI_PercentageAmount.OptionsColumn.TabStop = False
        Me.colDI_PercentageAmount.Visible = True
        Me.colDI_PercentageAmount.VisibleIndex = 7
        Me.colDI_PercentageAmount.Width = 100
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnAdd, Me.btnDelete, Me.cboTypeofIncome, Me.cboSourceNo1, Me.chkDiscloseNet, Me.txtPercentage, Me.btnNote})
        Me.BarManager1.MaxItemId = 17
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemComboBox1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemCheckEdit1, Me.RepositoryItemTextEdit3})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(31, 109)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.cboTypeofIncome), New DevExpress.XtraBars.LinkPersistInfo(Me.txtPercentage), New DevExpress.XtraBars.LinkPersistInfo(Me.cboSourceNo1), New DevExpress.XtraBars.LinkPersistInfo(Me.chkDiscloseNet), New DevExpress.XtraBars.LinkPersistInfo(Me.btnNote)})
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
        Me.btnDelete.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem2.Text = "Delete record"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Delete record [Delete]"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.btnDelete.SuperTip = SuperToolTip2
        '
        'cboTypeofIncome
        '
        Me.cboTypeofIncome.Caption = "Type of Income"
        Me.cboTypeofIncome.Edit = Me.RepositoryItemComboBox1
        Me.cboTypeofIncome.EditWidth = 150
        Me.cboTypeofIncome.Id = 12
        Me.cboTypeofIncome.Name = "cboTypeofIncome"
        Me.cboTypeofIncome.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Single Tier", "Percentage", "Trust", "Royalty", "Interest", "Section 4a", "Other"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'txtPercentage
        '
        Me.txtPercentage.Caption = "Percentage"
        Me.txtPercentage.Edit = Me.RepositoryItemTextEdit3
        Me.txtPercentage.EditWidth = 100
        Me.txtPercentage.Enabled = False
        Me.txtPercentage.Id = 15
        Me.txtPercentage.Name = "txtPercentage"
        Me.txtPercentage.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        Me.RepositoryItemTextEdit3.NullText = "100"
        Me.RepositoryItemTextEdit3.NullValuePrompt = "100"
        Me.RepositoryItemTextEdit3.NullValuePromptShowForEmptyValue = True
        '
        'cboSourceNo1
        '
        Me.cboSourceNo1.Caption = "Source No"
        Me.cboSourceNo1.Edit = Me.RepositoryItemLookUpEdit2
        Me.cboSourceNo1.EditWidth = 100
        Me.cboSourceNo1.Id = 13
        Me.cboSourceNo1.Name = "cboSourceNo1"
        Me.cboSourceNo1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BC_KEY", "BC_KEY", 67, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BC_SOURCEKEY", "BC_SOURCEKEY", 102, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BC_YA", "BC_YA", 47, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BC_SOURCENO", "Source No", 100, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BC_CODE", "Code", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BC_TYPE", "Type", 250, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BC_COMPANY", "Company", 5, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.BUSINESSSOURCEBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "BC_SOURCENO"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = "Select"
        Me.RepositoryItemLookUpEdit2.PopupFormMinSize = New System.Drawing.Size(400, 0)
        Me.RepositoryItemLookUpEdit2.ValueMember = "BC_SOURCENO"
        '
        'chkDiscloseNet
        '
        Me.chkDiscloseNet.Caption = "Disclose Nett : "
        Me.chkDiscloseNet.Edit = Me.RepositoryItemCheckEdit1
        Me.chkDiscloseNet.EditValue = True
        Me.chkDiscloseNet.EditWidth = 80
        Me.chkDiscloseNet.Id = 14
        Me.chkDiscloseNet.Name = "chkDiscloseNet"
        Me.chkDiscloseNet.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Yes"
        Me.RepositoryItemCheckEdit1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueGrayed = True
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1309, 39)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 513)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1309, 0)
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
        Me.barDockControlRight.Location = New System.Drawing.Point(1309, 39)
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
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'btnNote
        '
        Me.btnNote.Caption = "Note"
        Me.btnNote.Id = 16
        Me.btnNote.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNote.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnNote.Name = "btnNote"
        Me.btnNote.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'ucPNL_p2DivIncome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ucPNL_p2DivIncome"
        Me.Size = New System.Drawing.Size(1309, 513)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumberic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DIVIDENDINCOMEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPNL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSourceNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BUSINESSSOURCEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTypeIncome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsPNL As EasyTemplate_Taxcom.dsPNL
    Friend WithEvents txtNumberic As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtNote As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents cboSourceNo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colNTD_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNTD_NTKEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNTD_NTDKEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNTD_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNTD_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNTD_NOTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNTD_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNTD_NTKEYN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIVIDENDINCOMEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BUSINESSSOURCEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colDI_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDI_DIVIDENDKEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDI_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDI_COMPANY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDI_GROSS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDI_TAX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDI_NET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDI_WARANT_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDI_CHKREGROSS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDI_TAXRATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDI_REGROSS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDI_TAXDEDUCTION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDI_NETDEDUCTION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDI_ENDDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDI_TRATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDI_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDI_DISCLOSE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDI_TRANSFER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents cboTypeIncome As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents DsPNL1 As EasyTemplate_Taxcom.dsPNL
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cboTypeofIncome As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cboSourceNo1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents chkDiscloseNet As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtPercentage As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colDI_Percentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDI_PercentageAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnNote As DevExpress.XtraBars.BarButtonItem

End Class
