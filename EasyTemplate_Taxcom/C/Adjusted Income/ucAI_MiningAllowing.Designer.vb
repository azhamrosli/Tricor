<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAI_MiningAllowing
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
        Me.MININGALLOWNANCEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAdjustedIncome = New EasyTemplate_Taxcom.dsAdjustedIncome()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMA_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMA_REF_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMA_YA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMA_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMA_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.isNumeric = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colMA_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MININGALLOWNANCEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAdjustedIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.MININGALLOWNANCEBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.isNumeric})
        Me.GridControl1.Size = New System.Drawing.Size(800, 385)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'MININGALLOWNANCEBindingSource
        '
        Me.MININGALLOWNANCEBindingSource.DataMember = "MINING_ALLOWNANCE"
        Me.MININGALLOWNANCEBindingSource.DataSource = Me.DsAdjustedIncome
        '
        'DsAdjustedIncome
        '
        Me.DsAdjustedIncome.DataSetName = "dsAdjustedIncome"
        Me.DsAdjustedIncome.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMA_KEY, Me.colMA_REF_NO, Me.colMA_YA, Me.colMA_DESC, Me.colMA_AMOUNT, Me.colMA_SOURCENO})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colMA_KEY
        '
        Me.colMA_KEY.FieldName = "MA_KEY"
        Me.colMA_KEY.Name = "colMA_KEY"
        '
        'colMA_REF_NO
        '
        Me.colMA_REF_NO.FieldName = "MA_REF_NO"
        Me.colMA_REF_NO.Name = "colMA_REF_NO"
        '
        'colMA_YA
        '
        Me.colMA_YA.FieldName = "MA_YA"
        Me.colMA_YA.Name = "colMA_YA"
        '
        'colMA_DESC
        '
        Me.colMA_DESC.Caption = "Description"
        Me.colMA_DESC.FieldName = "MA_DESC"
        Me.colMA_DESC.Name = "colMA_DESC"
        Me.colMA_DESC.Visible = True
        Me.colMA_DESC.VisibleIndex = 0
        Me.colMA_DESC.Width = 391
        '
        'colMA_AMOUNT
        '
        Me.colMA_AMOUNT.Caption = "Amount"
        Me.colMA_AMOUNT.ColumnEdit = Me.isNumeric
        Me.colMA_AMOUNT.FieldName = "MA_AMOUNT"
        Me.colMA_AMOUNT.Name = "colMA_AMOUNT"
        Me.colMA_AMOUNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MA_AMOUNT", "SUM={0:0.##}")})
        Me.colMA_AMOUNT.Visible = True
        Me.colMA_AMOUNT.VisibleIndex = 1
        Me.colMA_AMOUNT.Width = 100
        '
        'isNumeric
        '
        Me.isNumeric.AutoHeight = False
        Me.isNumeric.Mask.EditMask = "n0"
        Me.isNumeric.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.isNumeric.Name = "isNumeric"
        '
        'colMA_SOURCENO
        '
        Me.colMA_SOURCENO.FieldName = "MA_SOURCENO"
        Me.colMA_SOURCENO.Name = "colMA_SOURCENO"
        '
        'ucAI_MiningAllowing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "ucAI_MiningAllowing"
        Me.Size = New System.Drawing.Size(800, 385)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MININGALLOWNANCEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAdjustedIncome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents isNumeric As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents MININGALLOWNANCEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsAdjustedIncome As EasyTemplate_Taxcom.dsAdjustedIncome
    Friend WithEvents colMA_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMA_REF_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMA_YA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMA_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMA_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMA_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn

End Class
