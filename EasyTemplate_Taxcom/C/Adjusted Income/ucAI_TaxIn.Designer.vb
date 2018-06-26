<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAI_TaxIn
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.TAXABLEINCOMEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAdjustedIncome = New EasyTemplate_Taxcom.dsAdjustedIncome()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTI_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTI_REF_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTI_YA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTI_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTI_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.isNumeric = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colTI_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTI_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXABLEINCOMEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAdjustedIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.TAXABLEINCOMEBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.isNumeric})
        Me.GridControl1.Size = New System.Drawing.Size(800, 385)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'TAXABLEINCOMEBindingSource
        '
        Me.TAXABLEINCOMEBindingSource.DataMember = "TAXABLE_INCOME"
        Me.TAXABLEINCOMEBindingSource.DataSource = Me.DsAdjustedIncome
        '
        'DsAdjustedIncome
        '
        Me.DsAdjustedIncome.DataSetName = "dsAdjustedIncome"
        Me.DsAdjustedIncome.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTI_KEY, Me.colTI_REF_NO, Me.colTI_YA, Me.colTI_DESC, Me.colTI_AMOUNT, Me.colTI_SOURCENO, Me.colTI_TYPE})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colTI_KEY
        '
        Me.colTI_KEY.FieldName = "TI_KEY"
        Me.colTI_KEY.Name = "colTI_KEY"
        '
        'colTI_REF_NO
        '
        Me.colTI_REF_NO.FieldName = "TI_REF_NO"
        Me.colTI_REF_NO.Name = "colTI_REF_NO"
        '
        'colTI_YA
        '
        Me.colTI_YA.FieldName = "TI_YA"
        Me.colTI_YA.Name = "colTI_YA"
        '
        'colTI_DESC
        '
        Me.colTI_DESC.Caption = "Description"
        Me.colTI_DESC.FieldName = "TI_DESC"
        Me.colTI_DESC.Name = "colTI_DESC"
        Me.colTI_DESC.Visible = True
        Me.colTI_DESC.VisibleIndex = 0
        Me.colTI_DESC.Width = 391
        '
        'colTI_AMOUNT
        '
        Me.colTI_AMOUNT.Caption = "Amount"
        Me.colTI_AMOUNT.ColumnEdit = Me.isNumeric
        Me.colTI_AMOUNT.FieldName = "TI_AMOUNT"
        Me.colTI_AMOUNT.Name = "colTI_AMOUNT"
        Me.colTI_AMOUNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TI_AMOUNT", "SUM={0:0.##}")})
        Me.colTI_AMOUNT.Visible = True
        Me.colTI_AMOUNT.VisibleIndex = 1
        Me.colTI_AMOUNT.Width = 100
        '
        'isNumeric
        '
        Me.isNumeric.AutoHeight = False
        Me.isNumeric.Mask.EditMask = "n0"
        Me.isNumeric.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.isNumeric.Name = "isNumeric"
        '
        'colTI_SOURCENO
        '
        Me.colTI_SOURCENO.FieldName = "TI_SOURCENO"
        Me.colTI_SOURCENO.Name = "colTI_SOURCENO"
        '
        'colTI_TYPE
        '
        Me.colTI_TYPE.FieldName = "TI_TYPE"
        Me.colTI_TYPE.Name = "colTI_TYPE"
        '
        'ucAI_TaxIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "ucAI_TaxIn"
        Me.Size = New System.Drawing.Size(800, 385)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXABLEINCOMEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAdjustedIncome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents isNumeric As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents TAXABLEINCOMEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsAdjustedIncome As EasyTemplate_Taxcom.dsAdjustedIncome
    Friend WithEvents colTI_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTI_REF_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTI_YA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTI_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTI_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTI_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTI_TYPE As DevExpress.XtraGrid.Columns.GridColumn

End Class
