<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAI_SurplusMiningAllowance
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
        Me.SURPLUSRECOVEREDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAdjustedIncome = New EasyTemplate_Taxcom.dsAdjustedIncome()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSR_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSR_REF_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSR_YA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSR_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSR_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.isNumeric = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colSR_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SURPLUSRECOVEREDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAdjustedIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.SURPLUSRECOVEREDBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.isNumeric})
        Me.GridControl1.Size = New System.Drawing.Size(635, 356)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SURPLUSRECOVEREDBindingSource
        '
        Me.SURPLUSRECOVEREDBindingSource.DataMember = "SURPLUS_RECOVERED"
        Me.SURPLUSRECOVEREDBindingSource.DataSource = Me.DsAdjustedIncome
        '
        'DsAdjustedIncome
        '
        Me.DsAdjustedIncome.DataSetName = "dsAdjustedIncome"
        Me.DsAdjustedIncome.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSR_KEY, Me.colSR_REF_NO, Me.colSR_YA, Me.colSR_DESC, Me.colSR_AMOUNT, Me.colSR_SOURCENO})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colSR_KEY
        '
        Me.colSR_KEY.FieldName = "SR_KEY"
        Me.colSR_KEY.Name = "colSR_KEY"
        Me.colSR_KEY.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SR_KEY", "SUM={0:0.##}")})
        '
        'colSR_REF_NO
        '
        Me.colSR_REF_NO.FieldName = "SR_REF_NO"
        Me.colSR_REF_NO.Name = "colSR_REF_NO"
        '
        'colSR_YA
        '
        Me.colSR_YA.FieldName = "SR_YA"
        Me.colSR_YA.Name = "colSR_YA"
        '
        'colSR_DESC
        '
        Me.colSR_DESC.Caption = "Description"
        Me.colSR_DESC.FieldName = "SR_DESC"
        Me.colSR_DESC.Name = "colSR_DESC"
        Me.colSR_DESC.Visible = True
        Me.colSR_DESC.VisibleIndex = 0
        Me.colSR_DESC.Width = 308
        '
        'colSR_AMOUNT
        '
        Me.colSR_AMOUNT.Caption = "Amount"
        Me.colSR_AMOUNT.ColumnEdit = Me.isNumeric
        Me.colSR_AMOUNT.FieldName = "SR_AMOUNT"
        Me.colSR_AMOUNT.Name = "colSR_AMOUNT"
        Me.colSR_AMOUNT.Visible = True
        Me.colSR_AMOUNT.VisibleIndex = 1
        Me.colSR_AMOUNT.Width = 100
        '
        'isNumeric
        '
        Me.isNumeric.AutoHeight = False
        Me.isNumeric.Mask.EditMask = "n0"
        Me.isNumeric.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.isNumeric.Name = "isNumeric"
        '
        'colSR_SOURCENO
        '
        Me.colSR_SOURCENO.FieldName = "SR_SOURCENO"
        Me.colSR_SOURCENO.Name = "colSR_SOURCENO"
        '
        'ucAI_SurplusMiningAllowance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "ucAI_SurplusMiningAllowance"
        Me.Size = New System.Drawing.Size(635, 356)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SURPLUSRECOVEREDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAdjustedIncome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents SURPLUSRECOVEREDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsAdjustedIncome As EasyTemplate_Taxcom.dsAdjustedIncome
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSR_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSR_REF_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSR_YA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSR_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSR_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents isNumeric As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colSR_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn

End Class
