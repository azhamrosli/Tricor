<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAI_NALoss
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
        Me.NONALLOWLOSSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAdjustedIncome = New EasyTemplate_Taxcom.dsAdjustedIncome()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNL_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNL_REF_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNL_YA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNL_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNL_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.isNumeric = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colNL_CATEGORIZED = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNL_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NONALLOWLOSSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAdjustedIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.NONALLOWLOSSBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.isNumeric})
        Me.GridControl1.Size = New System.Drawing.Size(800, 385)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'NONALLOWLOSSBindingSource
        '
        Me.NONALLOWLOSSBindingSource.DataMember = "NON_ALLOW_LOSS"
        Me.NONALLOWLOSSBindingSource.DataSource = Me.DsAdjustedIncome
        '
        'DsAdjustedIncome
        '
        Me.DsAdjustedIncome.DataSetName = "dsAdjustedIncome"
        Me.DsAdjustedIncome.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNL_KEY, Me.colNL_REF_NO, Me.colNL_YA, Me.colNL_DESC, Me.colNL_AMOUNT, Me.colNL_CATEGORIZED, Me.colNL_SOURCENO})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colNL_KEY
        '
        Me.colNL_KEY.FieldName = "NL_KEY"
        Me.colNL_KEY.Name = "colNL_KEY"
        '
        'colNL_REF_NO
        '
        Me.colNL_REF_NO.FieldName = "NL_REF_NO"
        Me.colNL_REF_NO.Name = "colNL_REF_NO"
        '
        'colNL_YA
        '
        Me.colNL_YA.FieldName = "NL_YA"
        Me.colNL_YA.Name = "colNL_YA"
        '
        'colNL_DESC
        '
        Me.colNL_DESC.Caption = "Description"
        Me.colNL_DESC.FieldName = "NL_DESC"
        Me.colNL_DESC.Name = "colNL_DESC"
        Me.colNL_DESC.Visible = True
        Me.colNL_DESC.VisibleIndex = 0
        Me.colNL_DESC.Width = 391
        '
        'colNL_AMOUNT
        '
        Me.colNL_AMOUNT.Caption = "Amount"
        Me.colNL_AMOUNT.ColumnEdit = Me.isNumeric
        Me.colNL_AMOUNT.FieldName = "NL_AMOUNT"
        Me.colNL_AMOUNT.Name = "colNL_AMOUNT"
        Me.colNL_AMOUNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NL_AMOUNT", "SUM={0:0.##}")})
        Me.colNL_AMOUNT.Visible = True
        Me.colNL_AMOUNT.VisibleIndex = 1
        Me.colNL_AMOUNT.Width = 100
        '
        'isNumeric
        '
        Me.isNumeric.AutoHeight = False
        Me.isNumeric.Mask.EditMask = "n0"
        Me.isNumeric.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.isNumeric.Name = "isNumeric"
        '
        'colNL_CATEGORIZED
        '
        Me.colNL_CATEGORIZED.FieldName = "NL_CATEGORIZED"
        Me.colNL_CATEGORIZED.Name = "colNL_CATEGORIZED"
        '
        'colNL_SOURCENO
        '
        Me.colNL_SOURCENO.FieldName = "NL_SOURCENO"
        Me.colNL_SOURCENO.Name = "colNL_SOURCENO"
        '
        'ucAI_NALoss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "ucAI_NALoss"
        Me.Size = New System.Drawing.Size(800, 385)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NONALLOWLOSSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAdjustedIncome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents NONALLOWLOSSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsAdjustedIncome As EasyTemplate_Taxcom.dsAdjustedIncome
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNL_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNL_REF_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNL_YA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNL_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNL_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents isNumeric As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colNL_CATEGORIZED As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNL_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn

End Class
