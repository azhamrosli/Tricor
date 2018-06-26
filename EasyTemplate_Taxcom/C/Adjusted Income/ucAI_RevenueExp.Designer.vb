<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAI_RevenueExp
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
        Me.REVENUEEXPENDITUREBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAdjustedIncome = New EasyTemplate_Taxcom.dsAdjustedIncome()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRE_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRE_REF_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRE_YA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRE_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRE_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.isNumeric = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colRE_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRE_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REVENUEEXPENDITUREBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAdjustedIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.REVENUEEXPENDITUREBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.isNumeric})
        Me.GridControl1.Size = New System.Drawing.Size(800, 385)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'REVENUEEXPENDITUREBindingSource
        '
        Me.REVENUEEXPENDITUREBindingSource.DataMember = "REVENUE_EXPENDITURE"
        Me.REVENUEEXPENDITUREBindingSource.DataSource = Me.DsAdjustedIncome
        '
        'DsAdjustedIncome
        '
        Me.DsAdjustedIncome.DataSetName = "dsAdjustedIncome"
        Me.DsAdjustedIncome.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRE_KEY, Me.colRE_REF_NO, Me.colRE_YA, Me.colRE_DESC, Me.colRE_AMOUNT, Me.colRE_SOURCENO, Me.colRE_TYPE})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colRE_KEY
        '
        Me.colRE_KEY.FieldName = "RE_KEY"
        Me.colRE_KEY.Name = "colRE_KEY"
        '
        'colRE_REF_NO
        '
        Me.colRE_REF_NO.FieldName = "RE_REF_NO"
        Me.colRE_REF_NO.Name = "colRE_REF_NO"
        '
        'colRE_YA
        '
        Me.colRE_YA.FieldName = "RE_YA"
        Me.colRE_YA.Name = "colRE_YA"
        '
        'colRE_DESC
        '
        Me.colRE_DESC.Caption = "Description"
        Me.colRE_DESC.FieldName = "RE_DESC"
        Me.colRE_DESC.Name = "colRE_DESC"
        Me.colRE_DESC.Visible = True
        Me.colRE_DESC.VisibleIndex = 0
        Me.colRE_DESC.Width = 391
        '
        'colRE_AMOUNT
        '
        Me.colRE_AMOUNT.Caption = "Amount"
        Me.colRE_AMOUNT.ColumnEdit = Me.isNumeric
        Me.colRE_AMOUNT.FieldName = "RE_AMOUNT"
        Me.colRE_AMOUNT.Name = "colRE_AMOUNT"
        Me.colRE_AMOUNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RE_AMOUNT", "SUM={0:0.##}")})
        Me.colRE_AMOUNT.Visible = True
        Me.colRE_AMOUNT.VisibleIndex = 1
        Me.colRE_AMOUNT.Width = 100
        '
        'isNumeric
        '
        Me.isNumeric.AutoHeight = False
        Me.isNumeric.Mask.EditMask = "n0"
        Me.isNumeric.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.isNumeric.Name = "isNumeric"
        '
        'colRE_SOURCENO
        '
        Me.colRE_SOURCENO.FieldName = "RE_SOURCENO"
        Me.colRE_SOURCENO.Name = "colRE_SOURCENO"
        '
        'colRE_TYPE
        '
        Me.colRE_TYPE.FieldName = "RE_TYPE"
        Me.colRE_TYPE.Name = "colRE_TYPE"
        '
        'ucAI_RevenueExp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "ucAI_RevenueExp"
        Me.Size = New System.Drawing.Size(800, 385)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REVENUEEXPENDITUREBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAdjustedIncome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents isNumeric As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents DsAdjustedIncome As EasyTemplate_Taxcom.dsAdjustedIncome
    Friend WithEvents REVENUEEXPENDITUREBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colRE_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRE_REF_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRE_YA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRE_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRE_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRE_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRE_TYPE As DevExpress.XtraGrid.Columns.GridColumn

End Class
