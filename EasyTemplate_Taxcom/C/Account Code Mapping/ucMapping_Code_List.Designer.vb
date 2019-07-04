<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMapping_Code_List
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucMapping_Code_List))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnImport = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExport = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.MAPPINGCODELISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAccountMapping = New EasyTemplate_Taxcom.DsAccountMapping()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboType = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colKeyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboKeyName = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.KeyNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboType2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colType1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOperator = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboOperator = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboIndicator = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DsDefault = New EasyTemplate_Taxcom.dsDefault()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.INDICATORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAPPINGCODELISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAccountMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKeyName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeyNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboType2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOperator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INDICATORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSave, Me.btnDelete, Me.btnImport, Me.btnExport})
        Me.BarManager1.MaxItemId = 4
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSave), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.btnImport), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExport)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 0
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.ImageOptions.LargeImage = CType(resources.GetObject("btnSave.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnDelete
        '
        Me.btnDelete.Caption = "Delete"
        Me.btnDelete.Id = 1
        Me.btnDelete.ImageOptions.Image = CType(resources.GetObject("btnDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelete.ImageOptions.LargeImage = CType(resources.GetObject("btnDelete.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnDelete.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnImport
        '
        Me.btnImport.Caption = "Import"
        Me.btnImport.Id = 2
        Me.btnImport.ImageOptions.Image = CType(resources.GetObject("btnImport.ImageOptions.Image"), System.Drawing.Image)
        Me.btnImport.ImageOptions.LargeImage = CType(resources.GetObject("btnImport.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnExport
        '
        Me.btnExport.Caption = "Export"
        Me.btnExport.Id = 3
        Me.btnExport.ImageOptions.Image = CType(resources.GetObject("btnExport.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExport.ImageOptions.LargeImage = CType(resources.GetObject("btnExport.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(893, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 580)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(893, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 549)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(893, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 549)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.MAPPINGCODELISTBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 31)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboType, Me.cboKeyName, Me.cboOperator, Me.cboIndicator})
        Me.GridControl1.Size = New System.Drawing.Size(893, 549)
        Me.GridControl1.TabIndex = 11
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'MAPPINGCODELISTBindingSource
        '
        Me.MAPPINGCODELISTBindingSource.DataMember = "MAPPING_CODE_LIST"
        Me.MAPPINGCODELISTBindingSource.DataSource = Me.DsAccountMapping
        '
        'DsAccountMapping
        '
        Me.DsAccountMapping.DataSetName = "DsAccountMapping"
        Me.DsAccountMapping.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colCode, Me.colType, Me.colKeyName, Me.colOperator, Me.colModifiedBy, Me.colModifiedDateTime})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "BK_CODE", Nothing, "Count : {0}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colCode
        '
        Me.colCode.Caption = "Account Code"
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 0
        Me.colCode.Width = 250
        '
        'colType
        '
        Me.colType.Caption = "Type"
        Me.colType.ColumnEdit = Me.cboType
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 1
        Me.colType.Width = 150
        '
        'cboType
        '
        Me.cboType.AutoHeight = False
        Me.cboType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboType.Items.AddRange(New Object() {"Balance Sheet", "Profit and Loss"})
        Me.cboType.Name = "cboType"
        '
        'colKeyName
        '
        Me.colKeyName.ColumnEdit = Me.cboKeyName
        Me.colKeyName.FieldName = "KeyName"
        Me.colKeyName.Name = "colKeyName"
        Me.colKeyName.Visible = True
        Me.colKeyName.VisibleIndex = 2
        Me.colKeyName.Width = 250
        '
        'cboKeyName
        '
        Me.cboKeyName.AutoHeight = False
        Me.cboKeyName.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboKeyName.DataSource = Me.KeyNameBindingSource
        Me.cboKeyName.DisplayMember = "Description"
        Me.cboKeyName.Name = "cboKeyName"
        Me.cboKeyName.NullText = "Select"
        Me.cboKeyName.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboType2})
        Me.cboKeyName.ValueMember = "Keyname"
        Me.cboKeyName.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'KeyNameBindingSource
        '
        Me.KeyNameBindingSource.DataMember = "KeyName"
        Me.KeyNameBindingSource.DataSource = Me.DsAccountMapping
        '
        'cboType2
        '
        Me.cboType2.AutoHeight = False
        Me.cboType2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboType2.Items.AddRange(New Object() {"Balance Sheet", "Profit & Loss"})
        Me.cboType2.Name = "cboType2"
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colType1, Me.colDescription})
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ColumnAutoWidth = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colType1
        '
        Me.colType1.ColumnEdit = Me.cboType2
        Me.colType1.FieldName = "Type"
        Me.colType1.Name = "colType1"
        Me.colType1.Visible = True
        Me.colType1.VisibleIndex = 0
        Me.colType1.Width = 100
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 1
        Me.colDescription.Width = 350
        '
        'colOperator
        '
        Me.colOperator.Caption = "Indicator"
        Me.colOperator.ColumnEdit = Me.cboIndicator
        Me.colOperator.FieldName = "Operator"
        Me.colOperator.Name = "colOperator"
        Me.colOperator.Visible = True
        Me.colOperator.VisibleIndex = 3
        Me.colOperator.Width = 200
        '
        'cboOperator
        '
        Me.cboOperator.AutoHeight = False
        Me.cboOperator.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboOperator.Items.AddRange(New Object() {"Positive   (Debit Side)", "Negative (Credit Side with negative - )", "Dynamic  (Credit Side but always be positive in system)"})
        Me.cboOperator.Name = "cboOperator"
        '
        'colModifiedBy
        '
        Me.colModifiedBy.Caption = "Modified By"
        Me.colModifiedBy.FieldName = "ModifiedBy"
        Me.colModifiedBy.Name = "colModifiedBy"
        Me.colModifiedBy.Visible = True
        Me.colModifiedBy.VisibleIndex = 4
        Me.colModifiedBy.Width = 300
        '
        'colModifiedDateTime
        '
        Me.colModifiedDateTime.Caption = "Last Modified Date"
        Me.colModifiedDateTime.FieldName = "ModifiedDateTime"
        Me.colModifiedDateTime.Name = "colModifiedDateTime"
        Me.colModifiedDateTime.Visible = True
        Me.colModifiedDateTime.VisibleIndex = 5
        Me.colModifiedDateTime.Width = 250
        '
        'cboIndicator
        '
        Me.cboIndicator.AutoHeight = False
        Me.cboIndicator.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboIndicator.DataSource = Me.INDICATORBindingSource
        Me.cboIndicator.DisplayMember = "Description"
        Me.cboIndicator.Name = "cboIndicator"
        Me.cboIndicator.ValueMember = "ID"
        '
        'DsDefault
        '
        Me.DsDefault.DataSetName = "dsDefault"
        Me.DsDefault.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'INDICATORBindingSource
        '
        Me.INDICATORBindingSource.DataMember = "INDICATOR"
        Me.INDICATORBindingSource.DataSource = Me.DsAccountMapping
        '
        'ucMapping_Code_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "ucMapping_Code_List"
        Me.Size = New System.Drawing.Size(893, 580)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAPPINGCODELISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAccountMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKeyName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeyNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboType2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOperator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INDICATORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MAPPINGCODELISTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsAccountMapping As EasyTemplate_Taxcom.DsAccountMapping
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboType As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnImport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colKeyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsDefault As EasyTemplate_Taxcom.dsDefault
    Friend WithEvents cboKeyName As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents KeyNameBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cboType2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents colOperator As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboOperator As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cboIndicator As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents INDICATORBindingSource As System.Windows.Forms.BindingSource

End Class
