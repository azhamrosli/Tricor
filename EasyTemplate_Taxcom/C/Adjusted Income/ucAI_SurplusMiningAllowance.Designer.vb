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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucAI_SurplusMiningAllowance))
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SURPLUSRECOVEREDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAdjustedIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.SURPLUSRECOVEREDBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 31)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.isNumeric})
        Me.GridControl1.Size = New System.Drawing.Size(635, 325)
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
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnDelete})
        Me.BarManager1.MaxItemId = 1
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete)})
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'btnDelete
        '
        Me.btnDelete.Caption = "Delete"
        Me.btnDelete.Id = 0
        Me.btnDelete.ImageOptions.Image = CType(resources.GetObject("btnDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelete.ImageOptions.LargeImage = CType(resources.GetObject("btnDelete.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(635, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 356)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(635, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 325)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(635, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 325)
        '
        'ucAI_SurplusMiningAllowance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "ucAI_SurplusMiningAllowance"
        Me.Size = New System.Drawing.Size(635, 356)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SURPLUSRECOVEREDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAdjustedIncome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl

End Class
