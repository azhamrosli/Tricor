<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPNL_p4NonAllowableExpenses
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
        Me.DsPNL1 = New EasyTemplate_Taxcom.dsPNL()
        Me.BUSINESSSOURCEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtNumberic = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtNote = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.cboSourceNo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.chkBox = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.txtPercentage = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEXOURD_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOURD_EXOURKEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOURD_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOURD_EXOURDKEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOURD_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOURD_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPecentage1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOURD_NOTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOURD_DEDUCTIBLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXOURD_DEDUCTIBLE_ADD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRowIndex1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXORD_DEDUCTIBLE_ADD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.NonAllowableExpensesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKeyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSourceNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTitleKeyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DsPNL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BUSINESSSOURCEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumberic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSourceNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPercentage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NonAllowableExpensesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsPNL1
        '
        Me.DsPNL1.DataSetName = "dsPNL"
        Me.DsPNL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BUSINESSSOURCEBindingSource
        '
        Me.BUSINESSSOURCEBindingSource.DataMember = "BUSINESS_SOURCE"
        Me.BUSINESSSOURCEBindingSource.DataSource = Me.DsPNL1
        '
        'txtNumberic
        '
        Me.txtNumberic.AutoHeight = False
        Me.txtNumberic.DisplayFormat.FormatString = "n0"
        Me.txtNumberic.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNumberic.Mask.EditMask = "c"
        Me.txtNumberic.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNumberic.Name = "txtNumberic"
        Me.txtNumberic.NullValuePromptShowForEmptyValue = True
        '
        'txtNote
        '
        Me.txtNote.MaxLength = 1500
        Me.txtNote.Name = "txtNote"
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
        'chkBox
        '
        Me.chkBox.AutoHeight = False
        Me.chkBox.Name = "chkBox"
        Me.chkBox.ValueGrayed = True
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
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEXOURD_KEY, Me.colEXOURD_EXOURKEY, Me.colEXOURD_SOURCENO, Me.colEXOURD_EXOURDKEY, Me.colEXOURD_DESC, Me.colEXOURD_AMOUNT, Me.colPecentage1, Me.colEXOURD_NOTE, Me.colEXOURD_DEDUCTIBLE, Me.colEXOURD_DEDUCTIBLE_ADD, Me.colRowIndex1, Me.colEXORD_DEDUCTIBLE_ADD})
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
        'colEXOURD_KEY
        '
        Me.colEXOURD_KEY.FieldName = "EXOURD_KEY"
        Me.colEXOURD_KEY.Name = "colEXOURD_KEY"
        '
        'colEXOURD_EXOURKEY
        '
        Me.colEXOURD_EXOURKEY.FieldName = "EXOURD_EXOURKEY"
        Me.colEXOURD_EXOURKEY.Name = "colEXOURD_EXOURKEY"
        '
        'colEXOURD_SOURCENO
        '
        Me.colEXOURD_SOURCENO.FieldName = "EXOURD_SOURCENO"
        Me.colEXOURD_SOURCENO.Name = "colEXOURD_SOURCENO"
        '
        'colEXOURD_EXOURDKEY
        '
        Me.colEXOURD_EXOURDKEY.FieldName = "EXOURD_EXOURDKEY"
        Me.colEXOURD_EXOURDKEY.Name = "colEXOURD_EXOURDKEY"
        '
        'colEXOURD_DESC
        '
        Me.colEXOURD_DESC.Caption = "Description"
        Me.colEXOURD_DESC.FieldName = "EXOURD_DESC"
        Me.colEXOURD_DESC.Name = "colEXOURD_DESC"
        Me.colEXOURD_DESC.Visible = True
        Me.colEXOURD_DESC.VisibleIndex = 0
        Me.colEXOURD_DESC.Width = 300
        '
        'colEXOURD_AMOUNT
        '
        Me.colEXOURD_AMOUNT.Caption = "Amount"
        Me.colEXOURD_AMOUNT.ColumnEdit = Me.txtNumberic
        Me.colEXOURD_AMOUNT.FieldName = "EXOURD_AMOUNT"
        Me.colEXOURD_AMOUNT.Name = "colEXOURD_AMOUNT"
        Me.colEXOURD_AMOUNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EXOURD_AMOUNT", "SUM={0:0.##}")})
        Me.colEXOURD_AMOUNT.Visible = True
        Me.colEXOURD_AMOUNT.VisibleIndex = 1
        Me.colEXOURD_AMOUNT.Width = 120
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
        'colEXOURD_NOTE
        '
        Me.colEXOURD_NOTE.Caption = "Remarks"
        Me.colEXOURD_NOTE.ColumnEdit = Me.txtNote
        Me.colEXOURD_NOTE.FieldName = "EXOURD_NOTE"
        Me.colEXOURD_NOTE.Name = "colEXOURD_NOTE"
        Me.colEXOURD_NOTE.Visible = True
        Me.colEXOURD_NOTE.VisibleIndex = 3
        Me.colEXOURD_NOTE.Width = 300
        '
        'colEXOURD_DEDUCTIBLE
        '
        Me.colEXOURD_DEDUCTIBLE.Caption = "Add Back"
        Me.colEXOURD_DEDUCTIBLE.ColumnEdit = Me.chkBox
        Me.colEXOURD_DEDUCTIBLE.FieldName = "EXOURD_DEDUCTIBLE"
        Me.colEXOURD_DEDUCTIBLE.Name = "colEXOURD_DEDUCTIBLE"
        Me.colEXOURD_DEDUCTIBLE.Visible = True
        Me.colEXOURD_DEDUCTIBLE.VisibleIndex = 4
        Me.colEXOURD_DEDUCTIBLE.Width = 100
        '
        'colEXOURD_DEDUCTIBLE_ADD
        '
        Me.colEXOURD_DEDUCTIBLE_ADD.Caption = "Deduct"
        Me.colEXOURD_DEDUCTIBLE_ADD.ColumnEdit = Me.chkBox
        Me.colEXOURD_DEDUCTIBLE_ADD.FieldName = "EXOURD_DEDUCTIBLE_ADD"
        Me.colEXOURD_DEDUCTIBLE_ADD.Name = "colEXOURD_DEDUCTIBLE_ADD"
        Me.colEXOURD_DEDUCTIBLE_ADD.Visible = True
        Me.colEXOURD_DEDUCTIBLE_ADD.VisibleIndex = 5
        Me.colEXOURD_DEDUCTIBLE_ADD.Width = 100
        '
        'colRowIndex1
        '
        Me.colRowIndex1.FieldName = "RowIndex"
        Me.colRowIndex1.Name = "colRowIndex1"
        Me.colRowIndex1.Width = 100
        '
        'colEXORD_DEDUCTIBLE_ADD
        '
        Me.colEXORD_DEDUCTIBLE_ADD.FieldName = "EXORD_DEDUCTIBLE_ADD"
        Me.colEXORD_DEDUCTIBLE_ADD.Name = "colEXORD_DEDUCTIBLE_ADD"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.NonAllowableExpensesBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtNumberic, Me.txtNote, Me.cboSourceNo, Me.chkBox, Me.txtPercentage})
        Me.GridControl1.Size = New System.Drawing.Size(758, 417)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'NonAllowableExpensesBindingSource
        '
        Me.NonAllowableExpensesBindingSource.DataMember = "NonAllowable_Expenses"
        Me.NonAllowableExpensesBindingSource.DataSource = Me.DsPNL1
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colKeyName, Me.colSourceNo, Me.colTitleKeyName, Me.colDescription, Me.colAmount})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 2
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", Me.colAmount, "{0:n0}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GridView1.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled
        Me.GridView1.OptionsDetail.SmartDetailHeight = True
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSourceNo, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colKeyName, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colKeyName
        '
        Me.colKeyName.FieldName = "KeyName"
        Me.colKeyName.Name = "colKeyName"
        '
        'colSourceNo
        '
        Me.colSourceNo.FieldName = "SourceNo"
        Me.colSourceNo.Name = "colSourceNo"
        Me.colSourceNo.Visible = True
        Me.colSourceNo.VisibleIndex = 0
        '
        'colTitleKeyName
        '
        Me.colTitleKeyName.Caption = "From"
        Me.colTitleKeyName.FieldName = "TitleKeyName"
        Me.colTitleKeyName.Name = "colTitleKeyName"
        Me.colTitleKeyName.Visible = True
        Me.colTitleKeyName.VisibleIndex = 0
        Me.colTitleKeyName.Width = 250
        '
        'colDescription
        '
        Me.colDescription.Caption = "Description"
        Me.colDescription.ColumnEdit = Me.txtNote
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 1
        Me.colDescription.Width = 500
        '
        'colAmount
        '
        Me.colAmount.Caption = "Amount"
        Me.colAmount.ColumnEdit = Me.txtNumberic
        Me.colAmount.FieldName = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "SUM={0:0.##}")})
        Me.colAmount.Visible = True
        Me.colAmount.VisibleIndex = 2
        Me.colAmount.Width = 120
        '
        'ucPNL_p4NonAllowableExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "ucPNL_p4NonAllowableExpenses"
        Me.Size = New System.Drawing.Size(758, 417)
        CType(Me.DsPNL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BUSINESSSOURCEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumberic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSourceNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPercentage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NonAllowableExpensesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsPNL As EasyTemplate_Taxcom.dsPNL
    Friend WithEvents DsPNL1 As EasyTemplate_Taxcom.dsPNL
    Friend WithEvents BUSINESSSOURCEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtNumberic As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtNote As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents cboSourceNo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents chkBox As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents txtPercentage As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEXOURD_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOURD_EXOURKEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOURD_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOURD_EXOURDKEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOURD_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOURD_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPecentage1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOURD_NOTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOURD_DEDUCTIBLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXOURD_DEDUCTIBLE_ADD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRowIndex1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXORD_DEDUCTIBLE_ADD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NonAllowableExpensesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKeyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTitleKeyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSourceNo As DevExpress.XtraGrid.Columns.GridColumn

End Class
