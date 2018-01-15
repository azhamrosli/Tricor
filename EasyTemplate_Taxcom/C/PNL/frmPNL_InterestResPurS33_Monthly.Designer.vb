<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPNL_InterestResPurS33_Monthly
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPNL_InterestResPurS33_Monthly))
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
        Me.colRIRD_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRIR_REF_NUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRIRD_MONTH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRIRD_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRIRD_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRIRD_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboType = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colRIRD_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNumberic = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colRIRD_TYPE_INCOME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboTypeIncome = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colRIRD_NOTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtNote = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.EXPENSESINTERESTRESTRICTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPNL = New EasyTemplate_Taxcom.dsPNL()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEXIR_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXIR_EXIRKEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXIR_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXIR_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXIR_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXIR_DEDUCTIBLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXIR_NOTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXIR_DETAIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXIR_YEAREND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXIR_STATUS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXIR_DEDUCTIBLE_ADD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRowIndex = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboSourceNo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BUSINESSSOURCEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtDate = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.cboStatus = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.chkDeduct = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddChild = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteChild = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExpand = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMoveUp = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMoveDown = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumberic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTypeIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXPENSESINTERESTRESTRICTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPNL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSourceNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BUSINESSSOURCEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDeduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRIRD_KEY, Me.colRIR_REF_NUM, Me.colRIRD_MONTH, Me.colRIRD_SOURCENO, Me.colRIRD_DESC, Me.colRIRD_TYPE, Me.colRIRD_AMOUNT, Me.colRIRD_TYPE_INCOME, Me.colRIRD_NOTE})
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
        'colRIRD_KEY
        '
        Me.colRIRD_KEY.FieldName = "RIRD_KEY"
        Me.colRIRD_KEY.Name = "colRIRD_KEY"
        '
        'colRIR_REF_NUM
        '
        Me.colRIR_REF_NUM.FieldName = "RIR_REF_NUM"
        Me.colRIR_REF_NUM.Name = "colRIR_REF_NUM"
        '
        'colRIRD_MONTH
        '
        Me.colRIRD_MONTH.FieldName = "RIRD_MONTH"
        Me.colRIRD_MONTH.Name = "colRIRD_MONTH"
        '
        'colRIRD_SOURCENO
        '
        Me.colRIRD_SOURCENO.FieldName = "RIRD_SOURCENO"
        Me.colRIRD_SOURCENO.Name = "colRIRD_SOURCENO"
        '
        'colRIRD_DESC
        '
        Me.colRIRD_DESC.Caption = "Description"
        Me.colRIRD_DESC.FieldName = "RIRD_DESC"
        Me.colRIRD_DESC.Name = "colRIRD_DESC"
        Me.colRIRD_DESC.Visible = True
        Me.colRIRD_DESC.VisibleIndex = 0
        Me.colRIRD_DESC.Width = 300
        '
        'colRIRD_TYPE
        '
        Me.colRIRD_TYPE.Caption = "Type"
        Me.colRIRD_TYPE.ColumnEdit = Me.cboType
        Me.colRIRD_TYPE.FieldName = "RIRD_TYPE"
        Me.colRIRD_TYPE.Name = "colRIRD_TYPE"
        Me.colRIRD_TYPE.Visible = True
        Me.colRIRD_TYPE.VisibleIndex = 1
        Me.colRIRD_TYPE.Width = 150
        '
        'cboType
        '
        Me.cboType.AutoHeight = False
        Me.cboType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboType.Items.AddRange(New Object() {"Investment", "Borrowing", "Interest"})
        Me.cboType.Name = "cboType"
        Me.cboType.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colRIRD_AMOUNT
        '
        Me.colRIRD_AMOUNT.Caption = "Amount"
        Me.colRIRD_AMOUNT.ColumnEdit = Me.txtNumberic
        Me.colRIRD_AMOUNT.FieldName = "RIRD_AMOUNT"
        Me.colRIRD_AMOUNT.Name = "colRIRD_AMOUNT"
        Me.colRIRD_AMOUNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RIRD_AMOUNT", "SUM={0:0.##}")})
        Me.colRIRD_AMOUNT.Visible = True
        Me.colRIRD_AMOUNT.VisibleIndex = 2
        Me.colRIRD_AMOUNT.Width = 120
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
        'colRIRD_TYPE_INCOME
        '
        Me.colRIRD_TYPE_INCOME.Caption = "Type of Income"
        Me.colRIRD_TYPE_INCOME.ColumnEdit = Me.cboTypeIncome
        Me.colRIRD_TYPE_INCOME.FieldName = "RIRD_TYPE_INCOME"
        Me.colRIRD_TYPE_INCOME.Name = "colRIRD_TYPE_INCOME"
        Me.colRIRD_TYPE_INCOME.Visible = True
        Me.colRIRD_TYPE_INCOME.VisibleIndex = 3
        Me.colRIRD_TYPE_INCOME.Width = 200
        '
        'cboTypeIncome
        '
        Me.cboTypeIncome.AutoHeight = False
        Me.cboTypeIncome.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTypeIncome.Items.AddRange(New Object() {"INTEREST INCOME", "DIVIDEND INCOME", "RENTAL INCOME", "NON-INCOME PRODUCING"})
        Me.cboTypeIncome.Name = "cboTypeIncome"
        Me.cboTypeIncome.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colRIRD_NOTE
        '
        Me.colRIRD_NOTE.Caption = "Remarks"
        Me.colRIRD_NOTE.ColumnEdit = Me.txtNote
        Me.colRIRD_NOTE.FieldName = "RIRD_NOTE"
        Me.colRIRD_NOTE.Name = "colRIRD_NOTE"
        Me.colRIRD_NOTE.Visible = True
        Me.colRIRD_NOTE.VisibleIndex = 4
        Me.colRIRD_NOTE.Width = 300
        '
        'txtNote
        '
        Me.txtNote.MaxLength = 1500
        Me.txtNote.Name = "txtNote"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.EXPENSESINTERESTRESTRICTBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 31)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtNumberic, Me.txtNote, Me.cboSourceNo, Me.dtDate, Me.cboStatus, Me.chkDeduct, Me.cboType, Me.cboTypeIncome})
        Me.GridControl1.Size = New System.Drawing.Size(877, 445)
        Me.GridControl1.TabIndex = 14
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'EXPENSESINTERESTRESTRICTBindingSource
        '
        Me.EXPENSESINTERESTRESTRICTBindingSource.DataMember = "EXPENSES_INTERESTRESTRICT"
        Me.EXPENSESINTERESTRESTRICTBindingSource.DataSource = Me.DsPNL
        '
        'DsPNL
        '
        Me.DsPNL.DataSetName = "dsPNL"
        Me.DsPNL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEXIR_KEY, Me.colEXIR_EXIRKEY, Me.colEXIR_SOURCENO, Me.colEXIR_AMOUNT, Me.colEXIR_DESC, Me.colEXIR_DEDUCTIBLE, Me.colEXIR_NOTE, Me.colEXIR_DETAIL, Me.colEXIR_YEAREND, Me.colEXIR_STATUS, Me.colEXIR_DEDUCTIBLE_ADD, Me.colRowIndex})
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
        Me.GridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colEXIR_KEY
        '
        Me.colEXIR_KEY.FieldName = "EXIR_KEY"
        Me.colEXIR_KEY.Name = "colEXIR_KEY"
        Me.colEXIR_KEY.Visible = True
        Me.colEXIR_KEY.VisibleIndex = 0
        '
        'colEXIR_EXIRKEY
        '
        Me.colEXIR_EXIRKEY.FieldName = "EXIR_EXIRKEY"
        Me.colEXIR_EXIRKEY.Name = "colEXIR_EXIRKEY"
        Me.colEXIR_EXIRKEY.Visible = True
        Me.colEXIR_EXIRKEY.VisibleIndex = 1
        '
        'colEXIR_SOURCENO
        '
        Me.colEXIR_SOURCENO.FieldName = "EXIR_SOURCENO"
        Me.colEXIR_SOURCENO.Name = "colEXIR_SOURCENO"
        Me.colEXIR_SOURCENO.Visible = True
        Me.colEXIR_SOURCENO.VisibleIndex = 2
        '
        'colEXIR_AMOUNT
        '
        Me.colEXIR_AMOUNT.FieldName = "EXIR_AMOUNT"
        Me.colEXIR_AMOUNT.Name = "colEXIR_AMOUNT"
        Me.colEXIR_AMOUNT.Visible = True
        Me.colEXIR_AMOUNT.VisibleIndex = 3
        '
        'colEXIR_DESC
        '
        Me.colEXIR_DESC.FieldName = "EXIR_DESC"
        Me.colEXIR_DESC.Name = "colEXIR_DESC"
        Me.colEXIR_DESC.Visible = True
        Me.colEXIR_DESC.VisibleIndex = 4
        '
        'colEXIR_DEDUCTIBLE
        '
        Me.colEXIR_DEDUCTIBLE.FieldName = "EXIR_DEDUCTIBLE"
        Me.colEXIR_DEDUCTIBLE.Name = "colEXIR_DEDUCTIBLE"
        Me.colEXIR_DEDUCTIBLE.Visible = True
        Me.colEXIR_DEDUCTIBLE.VisibleIndex = 5
        '
        'colEXIR_NOTE
        '
        Me.colEXIR_NOTE.FieldName = "EXIR_NOTE"
        Me.colEXIR_NOTE.Name = "colEXIR_NOTE"
        Me.colEXIR_NOTE.Visible = True
        Me.colEXIR_NOTE.VisibleIndex = 6
        '
        'colEXIR_DETAIL
        '
        Me.colEXIR_DETAIL.FieldName = "EXIR_DETAIL"
        Me.colEXIR_DETAIL.Name = "colEXIR_DETAIL"
        Me.colEXIR_DETAIL.Visible = True
        Me.colEXIR_DETAIL.VisibleIndex = 7
        '
        'colEXIR_YEAREND
        '
        Me.colEXIR_YEAREND.FieldName = "EXIR_YEAREND"
        Me.colEXIR_YEAREND.Name = "colEXIR_YEAREND"
        Me.colEXIR_YEAREND.Visible = True
        Me.colEXIR_YEAREND.VisibleIndex = 8
        '
        'colEXIR_STATUS
        '
        Me.colEXIR_STATUS.FieldName = "EXIR_STATUS"
        Me.colEXIR_STATUS.Name = "colEXIR_STATUS"
        Me.colEXIR_STATUS.Visible = True
        Me.colEXIR_STATUS.VisibleIndex = 9
        '
        'colEXIR_DEDUCTIBLE_ADD
        '
        Me.colEXIR_DEDUCTIBLE_ADD.FieldName = "EXIR_DEDUCTIBLE_ADD"
        Me.colEXIR_DEDUCTIBLE_ADD.Name = "colEXIR_DEDUCTIBLE_ADD"
        Me.colEXIR_DEDUCTIBLE_ADD.Visible = True
        Me.colEXIR_DEDUCTIBLE_ADD.VisibleIndex = 10
        '
        'colRowIndex
        '
        Me.colRowIndex.FieldName = "RowIndex"
        Me.colRowIndex.Name = "colRowIndex"
        Me.colRowIndex.Visible = True
        Me.colRowIndex.VisibleIndex = 11
        '
        'cboSourceNo
        '
        Me.cboSourceNo.AutoHeight = False
        Me.cboSourceNo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSourceNo.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BC_SOURCEKEY", "Key", 5, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BC_SOURCENO", "Source No", 85, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BC_CODE", "Code", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BC_TYPE", "Type", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboSourceNo.DataSource = Me.BUSINESSSOURCEBindingSource
        Me.cboSourceNo.DisplayMember = "BC_SOURCENO"
        Me.cboSourceNo.Name = "cboSourceNo"
        Me.cboSourceNo.NullText = "Select"
        Me.cboSourceNo.PopupFormMinSize = New System.Drawing.Size(450, 0)
        Me.cboSourceNo.ValueMember = "BC_SOURCENO"
        '
        'BUSINESSSOURCEBindingSource
        '
        Me.BUSINESSSOURCEBindingSource.AllowNew = True
        Me.BUSINESSSOURCEBindingSource.DataMember = "BUSINESS_SOURCE"
        '
        'dtDate
        '
        Me.dtDate.AutoHeight = False
        Me.dtDate.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDate.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDate.Name = "dtDate"
        '
        'cboStatus
        '
        Me.cboStatus.AutoHeight = False
        Me.cboStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboStatus.Items.AddRange(New Object() {"First Tier", "Second Tier", "Single Tier"})
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'chkDeduct
        '
        Me.chkDeduct.AutoHeight = False
        Me.chkDeduct.Name = "chkDeduct"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnAdd, Me.btnAddChild, Me.btnDelete, Me.btnDeleteChild, Me.btnExpand, Me.btnMoveUp, Me.btnMoveDown})
        Me.BarManager1.MaxItemId = 11
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(31, 109)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.btnAddChild), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDeleteChild), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExpand), New DevExpress.XtraBars.LinkPersistInfo(Me.btnMoveUp), New DevExpress.XtraBars.LinkPersistInfo(Me.btnMoveDown)})
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
        Me.barDockControlTop.Size = New System.Drawing.Size(877, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 476)
        Me.barDockControlBottom.Size = New System.Drawing.Size(877, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 445)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(877, 31)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 445)
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
        'frmPNL_InterestResPurS33_Monthly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 476)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmPNL_InterestResPurS33_Monthly"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Interest expense restricted under subsection 33(2)"
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumberic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTypeIncome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXPENSESINTERESTRESTRICTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPNL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSourceNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BUSINESSSOURCEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDeduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRIRD_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRIR_REF_NUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRIRD_MONTH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRIRD_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRIRD_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRIRD_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboType As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colRIRD_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNumberic As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colRIRD_TYPE_INCOME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboTypeIncome As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colRIRD_NOTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNote As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chkDeduct As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cboSourceNo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents dtDate As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents cboStatus As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddChild As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteChild As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExpand As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMoveUp As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMoveDown As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents EXPENSESINTERESTRESTRICTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsPNL As EasyTemplate_Taxcom.dsPNL
    Friend WithEvents colEXIR_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXIR_EXIRKEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXIR_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXIR_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXIR_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXIR_DEDUCTIBLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXIR_NOTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXIR_DETAIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXIR_YEAREND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXIR_STATUS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXIR_DEDUCTIBLE_ADD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRowIndex As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BUSINESSSOURCEBindingSource As System.Windows.Forms.BindingSource
End Class
