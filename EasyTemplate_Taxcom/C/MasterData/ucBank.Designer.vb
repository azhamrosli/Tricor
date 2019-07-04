<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBank
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucBank))
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BANKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDefault = New EasyTemplate_Taxcom.dsDefault()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBK_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBK_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBK_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboBank = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.BANKCODEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBKC_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBKC_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBK_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BANKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BANKCODEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSave, Me.btnDelete})
        Me.BarManager1.MaxItemId = 2
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSave), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete)})
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
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1035, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 536)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1035, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 505)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1035, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 505)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BANKBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 31)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboBank})
        Me.GridControl1.Size = New System.Drawing.Size(1035, 505)
        Me.GridControl1.TabIndex = 9
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'BANKBindingSource
        '
        Me.BANKBindingSource.DataMember = "BANK"
        Me.BANKBindingSource.DataSource = Me.DsDefault
        '
        'DsDefault
        '
        Me.DsDefault.DataSetName = "dsDefault"
        Me.DsDefault.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBK_KEY, Me.colBK_NAME, Me.colBK_CODE, Me.colBK_DESC})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "BK_CODE", Me.colBK_KEY, "Count : {0}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colBK_KEY
        '
        Me.colBK_KEY.Caption = "ID"
        Me.colBK_KEY.FieldName = "BK_KEY"
        Me.colBK_KEY.Name = "colBK_KEY"
        Me.colBK_KEY.OptionsColumn.ReadOnly = True
        Me.colBK_KEY.Visible = True
        Me.colBK_KEY.VisibleIndex = 0
        '
        'colBK_NAME
        '
        Me.colBK_NAME.Caption = "Bank Name"
        Me.colBK_NAME.FieldName = "BK_NAME"
        Me.colBK_NAME.Name = "colBK_NAME"
        Me.colBK_NAME.Visible = True
        Me.colBK_NAME.VisibleIndex = 1
        Me.colBK_NAME.Width = 300
        '
        'colBK_DESC
        '
        Me.colBK_DESC.Caption = "Description"
        Me.colBK_DESC.FieldName = "BK_DESC"
        Me.colBK_DESC.Name = "colBK_DESC"
        Me.colBK_DESC.OptionsColumn.ReadOnly = True
        Me.colBK_DESC.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.colBK_DESC.Width = 300
        '
        'cboBank
        '
        Me.cboBank.AutoHeight = False
        Me.cboBank.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBank.DataSource = Me.BANKCODEBindingSource
        Me.cboBank.DisplayMember = "BKC_DESC"
        Me.cboBank.Name = "cboBank"
        Me.cboBank.PopupFormSize = New System.Drawing.Size(500, 0)
        Me.cboBank.ValueMember = "BKC_CODE"
        Me.cboBank.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'BANKCODEBindingSource
        '
        Me.BANKCODEBindingSource.DataMember = "BANK_CODE"
        Me.BANKCODEBindingSource.DataSource = Me.DsDefault
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBKC_DESC, Me.colBKC_CODE})
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsBehavior.Editable = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colBKC_DESC
        '
        Me.colBKC_DESC.Caption = "Description"
        Me.colBKC_DESC.FieldName = "BKC_DESC"
        Me.colBKC_DESC.Name = "colBKC_DESC"
        Me.colBKC_DESC.Visible = True
        Me.colBKC_DESC.VisibleIndex = 0
        Me.colBKC_DESC.Width = 200
        '
        'colBKC_CODE
        '
        Me.colBKC_CODE.Caption = "Code"
        Me.colBKC_CODE.FieldName = "BKC_CODE"
        Me.colBKC_CODE.Name = "colBKC_CODE"
        Me.colBKC_CODE.Visible = True
        Me.colBKC_CODE.VisibleIndex = 1
        Me.colBKC_CODE.Width = 184
        '
        'colBK_CODE
        '
        Me.colBK_CODE.Caption = "Code"
        Me.colBK_CODE.ColumnEdit = Me.cboBank
        Me.colBK_CODE.FieldName = "BK_CODE"
        Me.colBK_CODE.Name = "colBK_CODE"
        Me.colBK_CODE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "BK_CODE", "{0}")})
        Me.colBK_CODE.Visible = True
        Me.colBK_CODE.VisibleIndex = 2
        Me.colBK_CODE.Width = 350
        '
        'ucBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "ucBank"
        Me.Size = New System.Drawing.Size(1035, 536)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BANKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BANKCODEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BANKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsDefault As EasyTemplate_Taxcom.dsDefault
    Friend WithEvents colBK_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBK_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBK_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBK_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboBank As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents BANKCODEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBKC_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBKC_CODE As DevExpress.XtraGrid.Columns.GridColumn

End Class
