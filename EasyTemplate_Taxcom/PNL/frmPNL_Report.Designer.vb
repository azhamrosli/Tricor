<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPNL_Report
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPNL_Report))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.PROFITLOSSACCOUNTREPORTTEMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPNL2 = New EasyTemplate_Taxcom.dsPNL2()
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colID_KEY = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPARENT_ID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colRefNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colYA = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colIndexNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCaption = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colLeftAmount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colRightAmount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTypeRow = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colNote = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExport = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROFITLOSSACCOUNTREPORTTEMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPNL2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.PROFITLOSSACCOUNTREPORTTEMPBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 31)
        Me.GridControl1.MainView = Me.BandedGridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(1039, 497)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1})
        '
        'PROFITLOSSACCOUNTREPORTTEMPBindingSource
        '
        Me.PROFITLOSSACCOUNTREPORTTEMPBindingSource.DataMember = "PROFIT_LOSS_ACCOUNT_REPORT_TEMP"
        Me.PROFITLOSSACCOUNTREPORTTEMPBindingSource.DataSource = Me.DsPNL2
        '
        'DsPNL2
        '
        Me.DsPNL2.DataSetName = "dsPNL2"
        Me.DsPNL2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Appearance.Row.Options.UseTextOptions = True
        Me.BandedGridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colID_KEY, Me.colPARENT_ID, Me.colID, Me.colRefNo, Me.colYA, Me.colIndexNo, Me.colCaption, Me.colLeftAmount, Me.colRightAmount, Me.colTypeRow, Me.colNote})
        Me.BandedGridView1.FixedLineWidth = 1
        Me.BandedGridView1.GridControl = Me.GridControl1
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.BandedGridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.BandedGridView1.OptionsBehavior.Editable = False
        Me.BandedGridView1.OptionsView.RowAutoHeight = True
        Me.BandedGridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.BandedGridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Profit and loss"
        Me.GridBand1.Columns.Add(Me.colID_KEY)
        Me.GridBand1.Columns.Add(Me.colPARENT_ID)
        Me.GridBand1.Columns.Add(Me.colID)
        Me.GridBand1.Columns.Add(Me.colRefNo)
        Me.GridBand1.Columns.Add(Me.colYA)
        Me.GridBand1.Columns.Add(Me.colIndexNo)
        Me.GridBand1.Columns.Add(Me.colCaption)
        Me.GridBand1.Columns.Add(Me.colLeftAmount)
        Me.GridBand1.Columns.Add(Me.colRightAmount)
        Me.GridBand1.Columns.Add(Me.colTypeRow)
        Me.GridBand1.Columns.Add(Me.colNote)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        Me.GridBand1.Width = 692
        '
        'colID_KEY
        '
        Me.colID_KEY.FieldName = "ID_KEY"
        Me.colID_KEY.Name = "colID_KEY"
        '
        'colPARENT_ID
        '
        Me.colPARENT_ID.FieldName = "PARENT_ID"
        Me.colPARENT_ID.Name = "colPARENT_ID"
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colRefNo
        '
        Me.colRefNo.FieldName = "RefNo"
        Me.colRefNo.Name = "colRefNo"
        '
        'colYA
        '
        Me.colYA.FieldName = "YA"
        Me.colYA.Name = "colYA"
        '
        'colIndexNo
        '
        Me.colIndexNo.FieldName = "IndexNo"
        Me.colIndexNo.Name = "colIndexNo"
        '
        'colCaption
        '
        Me.colCaption.Caption = "Description"
        Me.colCaption.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colCaption.FieldName = "Caption"
        Me.colCaption.Name = "colCaption"
        Me.colCaption.Visible = True
        Me.colCaption.Width = 230
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colLeftAmount
        '
        Me.colLeftAmount.Caption = "RM"
        Me.colLeftAmount.DisplayFormat.FormatString = "n2"
        Me.colLeftAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colLeftAmount.FieldName = "LeftAmount"
        Me.colLeftAmount.Name = "colLeftAmount"
        Me.colLeftAmount.Visible = True
        Me.colLeftAmount.Width = 230
        '
        'colRightAmount
        '
        Me.colRightAmount.Caption = "RM"
        Me.colRightAmount.DisplayFormat.FormatString = "n2"
        Me.colRightAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRightAmount.FieldName = "RightAmount"
        Me.colRightAmount.Name = "colRightAmount"
        Me.colRightAmount.Visible = True
        Me.colRightAmount.Width = 232
        '
        'colTypeRow
        '
        Me.colTypeRow.FieldName = "TypeRow"
        Me.colTypeRow.Name = "colTypeRow"
        '
        'colNote
        '
        Me.colNote.FieldName = "Note"
        Me.colNote.Name = "colNote"
        '
        'BarManager1
        '
        Me.BarManager1.AllowQuickCustomization = False
        Me.BarManager1.AllowShowToolbarsPopup = False
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnExport, Me.btnPrint})
        Me.BarManager1.MaxItemId = 10
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrint), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExport)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None
        Me.Bar1.OptionsBar.DisableClose = True
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'btnPrint
        '
        Me.btnPrint.Caption = "Print"
        Me.btnPrint.Id = 3
        Me.btnPrint.ImageOptions.Image = CType(resources.GetObject("btnPrint.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrint.ImageOptions.LargeImage = CType(resources.GetObject("btnPrint.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnExport
        '
        Me.btnExport.Caption = "Export"
        Me.btnExport.Id = 2
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1039, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 528)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1039, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 497)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1039, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 497)
        '
        'frmPNL_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 528)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmPNL_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Profit and loss report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROFITLOSSACCOUNTREPORTTEMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPNL2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents PROFITLOSSACCOUNTREPORTTEMPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsPNL2 As EasyTemplate_Taxcom.dsPNL2
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colID_KEY As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPARENT_ID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRefNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colYA As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIndexNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCaption As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colLeftAmount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRightAmount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTypeRow As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNote As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
End Class
