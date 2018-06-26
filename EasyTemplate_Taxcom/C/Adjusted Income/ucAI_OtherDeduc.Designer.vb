<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAI_OtherDeduc
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
        Me.OTHERDEDUCTIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAdjustedIncome = New EasyTemplate_Taxcom.dsAdjustedIncome()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOD_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOD_REF_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOD_YA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOD_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOD_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.isNumeric = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colOD_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OTHERDEDUCTIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAdjustedIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.OTHERDEDUCTIONBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.isNumeric})
        Me.GridControl1.Size = New System.Drawing.Size(800, 385)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'OTHERDEDUCTIONBindingSource
        '
        Me.OTHERDEDUCTIONBindingSource.DataMember = "OTHER_DEDUCTION"
        Me.OTHERDEDUCTIONBindingSource.DataSource = Me.DsAdjustedIncome
        '
        'DsAdjustedIncome
        '
        Me.DsAdjustedIncome.DataSetName = "dsAdjustedIncome"
        Me.DsAdjustedIncome.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOD_KEY, Me.colOD_REF_NO, Me.colOD_YA, Me.colOD_DESC, Me.colOD_AMOUNT, Me.colOD_SOURCENO})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colOD_KEY
        '
        Me.colOD_KEY.FieldName = "OD_KEY"
        Me.colOD_KEY.Name = "colOD_KEY"
        '
        'colOD_REF_NO
        '
        Me.colOD_REF_NO.FieldName = "OD_REF_NO"
        Me.colOD_REF_NO.Name = "colOD_REF_NO"
        '
        'colOD_YA
        '
        Me.colOD_YA.FieldName = "OD_YA"
        Me.colOD_YA.Name = "colOD_YA"
        '
        'colOD_DESC
        '
        Me.colOD_DESC.Caption = "Description"
        Me.colOD_DESC.FieldName = "OD_DESC"
        Me.colOD_DESC.Name = "colOD_DESC"
        Me.colOD_DESC.Visible = True
        Me.colOD_DESC.VisibleIndex = 0
        Me.colOD_DESC.Width = 391
        '
        'colOD_AMOUNT
        '
        Me.colOD_AMOUNT.Caption = "Amount"
        Me.colOD_AMOUNT.ColumnEdit = Me.isNumeric
        Me.colOD_AMOUNT.FieldName = "OD_AMOUNT"
        Me.colOD_AMOUNT.Name = "colOD_AMOUNT"
        Me.colOD_AMOUNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OD_AMOUNT", "SUM={0:0.##}")})
        Me.colOD_AMOUNT.Visible = True
        Me.colOD_AMOUNT.VisibleIndex = 1
        Me.colOD_AMOUNT.Width = 100
        '
        'isNumeric
        '
        Me.isNumeric.AutoHeight = False
        Me.isNumeric.Mask.EditMask = "n0"
        Me.isNumeric.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.isNumeric.Name = "isNumeric"
        '
        'colOD_SOURCENO
        '
        Me.colOD_SOURCENO.FieldName = "OD_SOURCENO"
        Me.colOD_SOURCENO.Name = "colOD_SOURCENO"
        '
        'ucAI_OtherDeduc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "ucAI_OtherDeduc"
        Me.Size = New System.Drawing.Size(800, 385)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OTHERDEDUCTIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAdjustedIncome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents isNumeric As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents DsAdjustedIncome As EasyTemplate_Taxcom.dsAdjustedIncome
    Friend WithEvents OTHERDEDUCTIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colOD_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOD_REF_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOD_YA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOD_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOD_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOD_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn

End Class
