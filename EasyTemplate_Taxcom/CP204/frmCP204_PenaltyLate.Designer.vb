<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCP204_PenaltyLate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCP204_PenaltyLate))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.txtRefNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.cboYA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.cboRefNo = New DevExpress.XtraEditors.LookUpEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddChild = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMoveUp = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMoveDown = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRefNo
        '
        Me.txtRefNo.Location = New System.Drawing.Point(113, 77)
        Me.txtRefNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Properties.ReadOnly = True
        Me.txtRefNo.Size = New System.Drawing.Size(327, 22)
        Me.txtRefNo.TabIndex = 163
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(452, 49)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(24, 16)
        Me.LabelControl11.TabIndex = 162
        Me.LabelControl11.Text = "YA :"
        '
        'cboYA
        '
        Me.cboYA.Location = New System.Drawing.Point(550, 45)
        Me.cboYA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboYA.Name = "cboYA"
        Me.cboYA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboYA.Properties.PopupSizeable = True
        Me.cboYA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboYA.Size = New System.Drawing.Size(327, 22)
        Me.cboYA.TabIndex = 160
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(15, 49)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(47, 16)
        Me.LabelControl10.TabIndex = 161
        Me.LabelControl10.Text = "Ref No :"
        '
        'cboRefNo
        '
        Me.cboRefNo.Location = New System.Drawing.Point(111, 45)
        Me.cboRefNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboRefNo.Name = "cboRefNo"
        Me.cboRefNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRefNo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RefNo", "Ref No", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Company Name", 500, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyNo", "Company No", 71, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployerNo", "Employer No", 70, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FileNo", "File No", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Country", "Country", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyCode", "Company Code", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboRefNo.Properties.DisplayMember = "CompanyName"
        Me.cboRefNo.Properties.NullText = "Select"
        Me.cboRefNo.Properties.PopupFormMinSize = New System.Drawing.Size(600, 0)
        Me.cboRefNo.Properties.ValueMember = "RefNo"
        Me.cboRefNo.Size = New System.Drawing.Size(328, 22)
        Me.cboRefNo.TabIndex = 159
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnAdd, Me.btnAddChild, Me.btnDelete, Me.btnMoveUp, Me.btnMoveDown})
        Me.BarManager1.MaxItemId = 11
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(271, 130)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.btnAddChild), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.btnMoveUp), New DevExpress.XtraBars.LinkPersistInfo(Me.btnMoveDown)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DisableClose = True
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'btnAdd
        '
        Me.btnAdd.Caption = "Save"
        Me.btnAdd.Glyph = CType(resources.GetObject("btnAdd.Glyph"), System.Drawing.Image)
        Me.btnAdd.Id = 0
        Me.btnAdd.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
        Me.btnAdd.LargeGlyph = CType(resources.GetObject("btnAdd.LargeGlyph"), System.Drawing.Image)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem1.Text = "Add new record"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Add new record Ctrl + R"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btnAdd.SuperTip = SuperToolTip1
        '
        'btnAddChild
        '
        Me.btnAddChild.Caption = "Add"
        Me.btnAddChild.Glyph = CType(resources.GetObject("btnAddChild.Glyph"), System.Drawing.Image)
        Me.btnAddChild.Id = 1
        Me.btnAddChild.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T))
        Me.btnAddChild.LargeGlyph = CType(resources.GetObject("btnAddChild.LargeGlyph"), System.Drawing.Image)
        Me.btnAddChild.Name = "btnAddChild"
        Me.btnAddChild.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem2.Text = "Add new record"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Add new record Ctrl + T"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.btnAddChild.SuperTip = SuperToolTip2
        '
        'btnDelete
        '
        Me.btnDelete.Caption = "Delete"
        Me.btnDelete.Glyph = CType(resources.GetObject("btnDelete.Glyph"), System.Drawing.Image)
        Me.btnDelete.Id = 4
        Me.btnDelete.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete)
        Me.btnDelete.LargeGlyph = CType(resources.GetObject("btnDelete.LargeGlyph"), System.Drawing.Image)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        ToolTipTitleItem3.Text = "Delete record"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Delete record Ctrl + Y"
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.btnDelete.SuperTip = SuperToolTip3
        '
        'btnMoveUp
        '
        Me.btnMoveUp.Caption = "Move Up"
        Me.btnMoveUp.Glyph = CType(resources.GetObject("btnMoveUp.Glyph"), System.Drawing.Image)
        Me.btnMoveUp.Id = 9
        Me.btnMoveUp.LargeGlyph = CType(resources.GetObject("btnMoveUp.LargeGlyph"), System.Drawing.Image)
        Me.btnMoveUp.Name = "btnMoveUp"
        Me.btnMoveUp.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnMoveDown
        '
        Me.btnMoveDown.Caption = "Move Down"
        Me.btnMoveDown.Glyph = CType(resources.GetObject("btnMoveDown.Glyph"), System.Drawing.Image)
        Me.btnMoveDown.Id = 10
        Me.btnMoveDown.LargeGlyph = CType(resources.GetObject("btnMoveDown.LargeGlyph"), System.Drawing.Image)
        Me.btnMoveDown.Name = "btnMoveDown"
        Me.btnMoveDown.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1086, 37)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 648)
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1086, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 37)
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 611)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1086, 37)
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 611)
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatString = "n"
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        Me.RepositoryItemTextEdit2.ReadOnly = True
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(15, 106)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1059, 500)
        Me.GridControl1.TabIndex = 168
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'frmCP204_PenaltyLate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 648)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtRefNo)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.cboYA)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.cboRefNo)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCP204_PenaltyLate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CP204 Penalty on Late Payment of Tax Instalments"
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRefNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboYA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboRefNo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddChild As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMoveUp As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMoveDown As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
