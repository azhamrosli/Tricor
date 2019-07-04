<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAI_OthExp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucAI_OthExp))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.OTHEREXPENDITUREBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAdjustedIncome = New EasyTemplate_Taxcom.dsAdjustedIncome()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOE_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOE_REF_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOE_YA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOE_CLAIMCODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboClaimCode = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.CLAIMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCL_CODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCL_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCL_ACTIVATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOE_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.isNumeric = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colOE_SOURCENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOE_COMPANY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OTHEREXPENDITUREBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAdjustedIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboClaimCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLAIMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.OTHEREXPENDITUREBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 31)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.isNumeric, Me.cboClaimCode})
        Me.GridControl1.Size = New System.Drawing.Size(800, 354)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'OTHEREXPENDITUREBindingSource
        '
        Me.OTHEREXPENDITUREBindingSource.DataMember = "OTHER_EXPENDITURE"
        Me.OTHEREXPENDITUREBindingSource.DataSource = Me.DsAdjustedIncome
        '
        'DsAdjustedIncome
        '
        Me.DsAdjustedIncome.DataSetName = "dsAdjustedIncome"
        Me.DsAdjustedIncome.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOE_KEY, Me.colOE_REF_NO, Me.colOE_YA, Me.colOE_CLAIMCODE, Me.colOE_AMOUNT, Me.colOE_SOURCENO, Me.colOE_COMPANY})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colOE_KEY
        '
        Me.colOE_KEY.FieldName = "OE_KEY"
        Me.colOE_KEY.Name = "colOE_KEY"
        '
        'colOE_REF_NO
        '
        Me.colOE_REF_NO.FieldName = "OE_REF_NO"
        Me.colOE_REF_NO.Name = "colOE_REF_NO"
        '
        'colOE_YA
        '
        Me.colOE_YA.FieldName = "OE_YA"
        Me.colOE_YA.Name = "colOE_YA"
        '
        'colOE_CLAIMCODE
        '
        Me.colOE_CLAIMCODE.Caption = "Claim Code"
        Me.colOE_CLAIMCODE.ColumnEdit = Me.cboClaimCode
        Me.colOE_CLAIMCODE.FieldName = "OE_CLAIMCODE"
        Me.colOE_CLAIMCODE.Name = "colOE_CLAIMCODE"
        Me.colOE_CLAIMCODE.Visible = True
        Me.colOE_CLAIMCODE.VisibleIndex = 0
        Me.colOE_CLAIMCODE.Width = 391
        '
        'cboClaimCode
        '
        Me.cboClaimCode.AutoHeight = False
        Me.cboClaimCode.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboClaimCode.DataSource = Me.CLAIMBindingSource
        Me.cboClaimCode.DisplayMember = "CL_DESC"
        Me.cboClaimCode.Name = "cboClaimCode"
        Me.cboClaimCode.NullText = "Select Claim Code"
        Me.cboClaimCode.ValueMember = "CL_CODE"
        Me.cboClaimCode.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'CLAIMBindingSource
        '
        Me.CLAIMBindingSource.DataMember = "CLAIM"
        Me.CLAIMBindingSource.DataSource = Me.DsAdjustedIncome
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCL_CODE, Me.colCL_DESC, Me.colCL_ACTIVATE})
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colCL_CODE
        '
        Me.colCL_CODE.Caption = "Code"
        Me.colCL_CODE.FieldName = "CL_CODE"
        Me.colCL_CODE.Name = "colCL_CODE"
        Me.colCL_CODE.Visible = True
        Me.colCL_CODE.VisibleIndex = 0
        Me.colCL_CODE.Width = 128
        '
        'colCL_DESC
        '
        Me.colCL_DESC.Caption = "Description"
        Me.colCL_DESC.FieldName = "CL_DESC"
        Me.colCL_DESC.Name = "colCL_DESC"
        Me.colCL_DESC.Visible = True
        Me.colCL_DESC.VisibleIndex = 1
        Me.colCL_DESC.Width = 200
        '
        'colCL_ACTIVATE
        '
        Me.colCL_ACTIVATE.FieldName = "CL_ACTIVATE"
        Me.colCL_ACTIVATE.Name = "colCL_ACTIVATE"
        Me.colCL_ACTIVATE.Width = 56
        '
        'colOE_AMOUNT
        '
        Me.colOE_AMOUNT.Caption = "Amount"
        Me.colOE_AMOUNT.ColumnEdit = Me.isNumeric
        Me.colOE_AMOUNT.FieldName = "OE_AMOUNT"
        Me.colOE_AMOUNT.Name = "colOE_AMOUNT"
        Me.colOE_AMOUNT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OE_AMOUNT", "SUM={0:0.##}")})
        Me.colOE_AMOUNT.Visible = True
        Me.colOE_AMOUNT.VisibleIndex = 1
        Me.colOE_AMOUNT.Width = 100
        '
        'isNumeric
        '
        Me.isNumeric.AutoHeight = False
        Me.isNumeric.Mask.EditMask = "n0"
        Me.isNumeric.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.isNumeric.Name = "isNumeric"
        '
        'colOE_SOURCENO
        '
        Me.colOE_SOURCENO.FieldName = "OE_SOURCENO"
        Me.colOE_SOURCENO.Name = "colOE_SOURCENO"
        '
        'colOE_COMPANY
        '
        Me.colOE_COMPANY.FieldName = "OE_COMPANY"
        Me.colOE_COMPANY.Name = "colOE_COMPANY"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(800, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 385)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(800, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 354)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(800, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 354)
        '
        'ucAI_OthExp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "ucAI_OthExp"
        Me.Size = New System.Drawing.Size(800, 385)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OTHEREXPENDITUREBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAdjustedIncome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboClaimCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLAIMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents isNumeric As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents DsAdjustedIncome As EasyTemplate_Taxcom.dsAdjustedIncome
    Friend WithEvents OTHEREXPENDITUREBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colOE_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOE_REF_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOE_YA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOE_CLAIMCODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOE_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOE_SOURCENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOE_COMPANY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboClaimCode As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CLAIMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colCL_CODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCL_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCL_ACTIVATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl

End Class
