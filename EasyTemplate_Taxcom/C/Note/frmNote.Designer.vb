<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNote))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRemove = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PROFITLOSSACCOUNTNOTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPNL = New EasyTemplate_Taxcom.dsPNL()
        Me.txtProfitAndLoss = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.txtParentID = New DevExpress.XtraEditors.TextEdit()
        Me.txtParentSubID = New DevExpress.XtraEditors.TextEdit()
        Me.TabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.TabNote = New DevExpress.XtraTab.XtraTabPage()
        Me.txtMemo = New DevExpress.XtraEditors.MemoEdit()
        Me.TabAttachment = New DevExpress.XtraTab.XtraTabPage()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddAttachment = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.PROFITLOSSACCOUNTNOTEATTACHMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParentID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAttachment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExtension = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabColumn = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCol6 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCol5 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCol4 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCol3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCol2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCol1 = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.PROFITLOSSACCOUNTNOTECOLUMNBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParentID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCol1_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCol1_Val = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCol2_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCol2_Val = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCol3_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCol3_Val = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCol4_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCol4_Val = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCol5_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCol5_Val = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCol6_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCol6_Val = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTitleNote = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.RGTypeNote = New DevExpress.XtraEditors.RadioGroup()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtTitleFrontNote = New DevExpress.XtraEditors.TextEdit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROFITLOSSACCOUNTNOTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPNL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProfitAndLoss.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtParentID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtParentSubID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.TabNote.SuspendLayout()
        CType(Me.txtMemo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAttachment.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROFITLOSSACCOUNTNOTEATTACHMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabColumn.SuspendLayout()
        CType(Me.txtCol6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCol5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCol4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCol3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCol2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCol1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROFITLOSSACCOUNTNOTECOLUMNBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGTypeNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleFrontNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 77)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Description : "
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 104)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Parent ID :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 50)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Profit and loss ID :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 131)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Parent Sub ID :"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnRemove, Me.btnSave, Me.btnClose})
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSave), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRemove), New DevExpress.XtraBars.LinkPersistInfo(Me.btnClose)})
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 3
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.ImageOptions.LargeImage = CType(resources.GetObject("btnSave.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnRemove
        '
        Me.btnRemove.Caption = "Remove"
        Me.btnRemove.Id = 2
        Me.btnRemove.ImageOptions.Image = CType(resources.GetObject("btnRemove.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRemove.ImageOptions.LargeImage = CType(resources.GetObject("btnRemove.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnClose
        '
        Me.btnClose.Caption = "Close"
        Me.btnClose.Id = 4
        Me.btnClose.ImageOptions.Image = CType(resources.GetObject("btnClose.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClose.ImageOptions.LargeImage = CType(resources.GetObject("btnClose.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
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
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(901, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 483)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(901, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 452)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(901, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 452)
        '
        'PROFITLOSSACCOUNTNOTEBindingSource
        '
        Me.PROFITLOSSACCOUNTNOTEBindingSource.DataMember = "PROFIT_LOSS_ACCOUNT_NOTE"
        Me.PROFITLOSSACCOUNTNOTEBindingSource.DataSource = Me.DsPNL
        '
        'DsPNL
        '
        Me.DsPNL.DataSetName = "dsPNL"
        Me.DsPNL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtProfitAndLoss
        '
        Me.txtProfitAndLoss.Location = New System.Drawing.Point(121, 47)
        Me.txtProfitAndLoss.MenuManager = Me.BarManager1
        Me.txtProfitAndLoss.Name = "txtProfitAndLoss"
        Me.txtProfitAndLoss.Size = New System.Drawing.Size(344, 20)
        Me.txtProfitAndLoss.TabIndex = 17
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(121, 74)
        Me.txtDescription.MenuManager = Me.BarManager1
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(344, 20)
        Me.txtDescription.TabIndex = 18
        '
        'txtParentID
        '
        Me.txtParentID.Location = New System.Drawing.Point(121, 101)
        Me.txtParentID.MenuManager = Me.BarManager1
        Me.txtParentID.Name = "txtParentID"
        Me.txtParentID.Size = New System.Drawing.Size(344, 20)
        Me.txtParentID.TabIndex = 19
        '
        'txtParentSubID
        '
        Me.txtParentSubID.Location = New System.Drawing.Point(121, 128)
        Me.txtParentSubID.MenuManager = Me.BarManager1
        Me.txtParentSubID.Name = "txtParentSubID"
        Me.txtParentSubID.Size = New System.Drawing.Size(344, 20)
        Me.txtParentSubID.TabIndex = 20
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Location = New System.Drawing.Point(12, 232)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedTabPage = Me.TabNote
        Me.TabControl.Size = New System.Drawing.Size(877, 245)
        Me.TabControl.TabIndex = 28
        Me.TabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabNote, Me.TabAttachment, Me.TabColumn})
        '
        'TabNote
        '
        Me.TabNote.Controls.Add(Me.txtMemo)
        Me.TabNote.Name = "TabNote"
        Me.TabNote.Size = New System.Drawing.Size(871, 217)
        Me.TabNote.Text = "Note"
        '
        'txtMemo
        '
        Me.txtMemo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMemo.Location = New System.Drawing.Point(0, 0)
        Me.txtMemo.MenuManager = Me.BarManager1
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Size = New System.Drawing.Size(871, 217)
        Me.txtMemo.TabIndex = 0
        '
        'TabAttachment
        '
        Me.TabAttachment.Controls.Add(Me.SimpleButton1)
        Me.TabAttachment.Controls.Add(Me.btnAddAttachment)
        Me.TabAttachment.Controls.Add(Me.GridControl2)
        Me.TabAttachment.Controls.Add(Me.Label1)
        Me.TabAttachment.Name = "TabAttachment"
        Me.TabAttachment.Size = New System.Drawing.Size(871, 217)
        Me.TabAttachment.Text = "Attachment"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(185, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "Delete"
        '
        'btnAddAttachment
        '
        Me.btnAddAttachment.ImageOptions.Image = CType(resources.GetObject("btnAddAttachment.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddAttachment.Location = New System.Drawing.Point(104, 4)
        Me.btnAddAttachment.Name = "btnAddAttachment"
        Me.btnAddAttachment.Size = New System.Drawing.Size(75, 23)
        Me.btnAddAttachment.TabIndex = 2
        Me.btnAddAttachment.Text = "Add"
        '
        'GridControl2
        '
        Me.GridControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl2.DataSource = Me.PROFITLOSSACCOUNTNOTEATTACHMENTBindingSource
        Me.GridControl2.Location = New System.Drawing.Point(9, 33)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.MenuManager = Me.BarManager1
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(859, 181)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'PROFITLOSSACCOUNTNOTEATTACHMENTBindingSource
        '
        Me.PROFITLOSSACCOUNTNOTEATTACHMENTBindingSource.DataMember = "PROFIT_LOSS_ACCOUNT_NOTE_ATTACHMENT"
        Me.PROFITLOSSACCOUNTNOTEATTACHMENTBindingSource.DataSource = Me.DsPNL
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colParentID, Me.colAttachment, Me.colExtension})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.RowAutoHeight = True
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "ID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'colParentID
        '
        Me.colParentID.FieldName = "ParentID"
        Me.colParentID.Name = "colParentID"
        '
        'colAttachment
        '
        Me.colAttachment.FieldName = "Attachment"
        Me.colAttachment.Name = "colAttachment"
        Me.colAttachment.Visible = True
        Me.colAttachment.VisibleIndex = 0
        Me.colAttachment.Width = 400
        '
        'colExtension
        '
        Me.colExtension.FieldName = "Extension"
        Me.colExtension.Name = "colExtension"
        Me.colExtension.Visible = True
        Me.colExtension.VisibleIndex = 1
        Me.colExtension.Width = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Attachment :"
        '
        'TabColumn
        '
        Me.TabColumn.Controls.Add(Me.LabelControl8)
        Me.TabColumn.Controls.Add(Me.txtCol6)
        Me.TabColumn.Controls.Add(Me.LabelControl7)
        Me.TabColumn.Controls.Add(Me.txtCol5)
        Me.TabColumn.Controls.Add(Me.LabelControl6)
        Me.TabColumn.Controls.Add(Me.txtCol4)
        Me.TabColumn.Controls.Add(Me.LabelControl5)
        Me.TabColumn.Controls.Add(Me.txtCol3)
        Me.TabColumn.Controls.Add(Me.LabelControl9)
        Me.TabColumn.Controls.Add(Me.txtCol2)
        Me.TabColumn.Controls.Add(Me.LabelControl10)
        Me.TabColumn.Controls.Add(Me.txtCol1)
        Me.TabColumn.Controls.Add(Me.GridControl3)
        Me.TabColumn.Name = "TabColumn"
        Me.TabColumn.Size = New System.Drawing.Size(871, 217)
        Me.TabColumn.Text = "Column"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(372, 74)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl8.TabIndex = 18
        Me.LabelControl8.Text = "Column Title 6 :"
        '
        'txtCol6
        '
        Me.txtCol6.Location = New System.Drawing.Point(456, 71)
        Me.txtCol6.MenuManager = Me.BarManager1
        Me.txtCol6.Name = "txtCol6"
        Me.txtCol6.Size = New System.Drawing.Size(262, 20)
        Me.txtCol6.TabIndex = 17
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(372, 48)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl7.TabIndex = 16
        Me.LabelControl7.Text = "Column Title 5 :"
        '
        'txtCol5
        '
        Me.txtCol5.Location = New System.Drawing.Point(456, 45)
        Me.txtCol5.MenuManager = Me.BarManager1
        Me.txtCol5.Name = "txtCol5"
        Me.txtCol5.Size = New System.Drawing.Size(262, 20)
        Me.txtCol5.TabIndex = 15
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(372, 22)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl6.TabIndex = 14
        Me.LabelControl6.Text = "Column Title 4 :"
        '
        'txtCol4
        '
        Me.txtCol4.Location = New System.Drawing.Point(456, 19)
        Me.txtCol4.MenuManager = Me.BarManager1
        Me.txtCol4.Name = "txtCol4"
        Me.txtCol4.Size = New System.Drawing.Size(262, 20)
        Me.txtCol4.TabIndex = 13
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(9, 74)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl5.TabIndex = 12
        Me.LabelControl5.Text = "Column Title 3 :"
        '
        'txtCol3
        '
        Me.txtCol3.Location = New System.Drawing.Point(93, 71)
        Me.txtCol3.MenuManager = Me.BarManager1
        Me.txtCol3.Name = "txtCol3"
        Me.txtCol3.Size = New System.Drawing.Size(262, 20)
        Me.txtCol3.TabIndex = 11
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(9, 48)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl9.TabIndex = 10
        Me.LabelControl9.Text = "Column Title 2 :"
        '
        'txtCol2
        '
        Me.txtCol2.Location = New System.Drawing.Point(93, 45)
        Me.txtCol2.MenuManager = Me.BarManager1
        Me.txtCol2.Name = "txtCol2"
        Me.txtCol2.Size = New System.Drawing.Size(262, 20)
        Me.txtCol2.TabIndex = 9
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(9, 22)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl10.TabIndex = 8
        Me.LabelControl10.Text = "Column Title 1 :"
        '
        'txtCol1
        '
        Me.txtCol1.Location = New System.Drawing.Point(93, 19)
        Me.txtCol1.MenuManager = Me.BarManager1
        Me.txtCol1.Name = "txtCol1"
        Me.txtCol1.Size = New System.Drawing.Size(262, 20)
        Me.txtCol1.TabIndex = 3
        '
        'GridControl3
        '
        Me.GridControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl3.DataSource = Me.PROFITLOSSACCOUNTNOTECOLUMNBindingSource
        Me.GridControl3.Location = New System.Drawing.Point(9, 97)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.MenuManager = Me.BarManager1
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(859, 117)
        Me.GridControl3.TabIndex = 2
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'PROFITLOSSACCOUNTNOTECOLUMNBindingSource
        '
        Me.PROFITLOSSACCOUNTNOTECOLUMNBindingSource.DataMember = "PROFIT_LOSS_ACCOUNT_NOTE_COLUMN"
        Me.PROFITLOSSACCOUNTNOTECOLUMNBindingSource.DataSource = Me.DsPNL
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID1, Me.colParentID1, Me.colCol1_Name, Me.colCol1_Val, Me.colCol2_Name, Me.colCol2_Val, Me.colCol3_Name, Me.colCol3_Val, Me.colCol4_Name, Me.colCol4_Val, Me.colCol5_Name, Me.colCol5_Val, Me.colCol6_Name, Me.colCol6_Val})
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView3.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView3.OptionsView.RowAutoHeight = True
        '
        'colID1
        '
        Me.colID1.FieldName = "ID"
        Me.colID1.Name = "colID1"
        '
        'colParentID1
        '
        Me.colParentID1.FieldName = "ParentID"
        Me.colParentID1.Name = "colParentID1"
        '
        'colCol1_Name
        '
        Me.colCol1_Name.Caption = " "
        Me.colCol1_Name.FieldName = "Col1_Name"
        Me.colCol1_Name.Name = "colCol1_Name"
        Me.colCol1_Name.Width = 300
        '
        'colCol1_Val
        '
        Me.colCol1_Val.Caption = " "
        Me.colCol1_Val.FieldName = "Col1_Val"
        Me.colCol1_Val.Name = "colCol1_Val"
        Me.colCol1_Val.Visible = True
        Me.colCol1_Val.VisibleIndex = 0
        Me.colCol1_Val.Width = 300
        '
        'colCol2_Name
        '
        Me.colCol2_Name.Caption = " "
        Me.colCol2_Name.FieldName = "Col2_Name"
        Me.colCol2_Name.Name = "colCol2_Name"
        Me.colCol2_Name.Width = 150
        '
        'colCol2_Val
        '
        Me.colCol2_Val.Caption = " "
        Me.colCol2_Val.FieldName = "Col2_Val"
        Me.colCol2_Val.Name = "colCol2_Val"
        Me.colCol2_Val.Visible = True
        Me.colCol2_Val.VisibleIndex = 1
        Me.colCol2_Val.Width = 150
        '
        'colCol3_Name
        '
        Me.colCol3_Name.Caption = " "
        Me.colCol3_Name.FieldName = "Col3_Name"
        Me.colCol3_Name.Name = "colCol3_Name"
        Me.colCol3_Name.Width = 150
        '
        'colCol3_Val
        '
        Me.colCol3_Val.Caption = " "
        Me.colCol3_Val.FieldName = "Col3_Val"
        Me.colCol3_Val.Name = "colCol3_Val"
        Me.colCol3_Val.Visible = True
        Me.colCol3_Val.VisibleIndex = 2
        Me.colCol3_Val.Width = 150
        '
        'colCol4_Name
        '
        Me.colCol4_Name.Caption = " "
        Me.colCol4_Name.FieldName = "Col4_Name"
        Me.colCol4_Name.Name = "colCol4_Name"
        Me.colCol4_Name.Width = 150
        '
        'colCol4_Val
        '
        Me.colCol4_Val.Caption = " "
        Me.colCol4_Val.FieldName = "Col4_Val"
        Me.colCol4_Val.Name = "colCol4_Val"
        Me.colCol4_Val.Visible = True
        Me.colCol4_Val.VisibleIndex = 3
        Me.colCol4_Val.Width = 150
        '
        'colCol5_Name
        '
        Me.colCol5_Name.Caption = " "
        Me.colCol5_Name.FieldName = "Col5_Name"
        Me.colCol5_Name.Name = "colCol5_Name"
        Me.colCol5_Name.Width = 150
        '
        'colCol5_Val
        '
        Me.colCol5_Val.Caption = " "
        Me.colCol5_Val.FieldName = "Col5_Val"
        Me.colCol5_Val.Name = "colCol5_Val"
        Me.colCol5_Val.Visible = True
        Me.colCol5_Val.VisibleIndex = 4
        Me.colCol5_Val.Width = 150
        '
        'colCol6_Name
        '
        Me.colCol6_Name.Caption = " "
        Me.colCol6_Name.FieldName = "Col6_Name"
        Me.colCol6_Name.Name = "colCol6_Name"
        Me.colCol6_Name.Width = 150
        '
        'colCol6_Val
        '
        Me.colCol6_Val.Caption = " "
        Me.colCol6_Val.FieldName = "Col6_Val"
        Me.colCol6_Val.Name = "colCol6_Val"
        Me.colCol6_Val.Visible = True
        Me.colCol6_Val.VisibleIndex = 5
        Me.colCol6_Val.Width = 150
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(15, 173)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl11.TabIndex = 29
        Me.LabelControl11.Text = "Title :"
        '
        'txtTitleNote
        '
        Me.txtTitleNote.Location = New System.Drawing.Point(224, 170)
        Me.txtTitleNote.MenuManager = Me.BarManager1
        Me.txtTitleNote.Name = "txtTitleNote"
        Me.txtTitleNote.Size = New System.Drawing.Size(660, 20)
        Me.txtTitleNote.TabIndex = 25
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(15, 204)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl12.TabIndex = 26
        Me.LabelControl12.Text = "Type :"
        '
        'RGTypeNote
        '
        Me.RGTypeNote.EditValue = CType(0, Short)
        Me.RGTypeNote.Location = New System.Drawing.Point(121, 196)
        Me.RGTypeNote.Name = "RGTypeNote"
        Me.RGTypeNote.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(0, Short), "Text"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Attachment"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Short), "Column")})
        Me.RGTypeNote.Size = New System.Drawing.Size(324, 29)
        Me.RGTypeNote.TabIndex = 27
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'txtTitleFrontNote
        '
        Me.txtTitleFrontNote.Location = New System.Drawing.Point(121, 170)
        Me.txtTitleFrontNote.MenuManager = Me.BarManager1
        Me.txtTitleFrontNote.Name = "txtTitleFrontNote"
        Me.txtTitleFrontNote.Size = New System.Drawing.Size(97, 20)
        Me.txtTitleFrontNote.TabIndex = 34
        '
        'frmNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 506)
        Me.Controls.Add(Me.txtTitleFrontNote)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.txtTitleNote)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.RGTypeNote)
        Me.Controls.Add(Me.txtParentSubID)
        Me.Controls.Add(Me.txtParentID)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtProfitAndLoss)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmNote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Note"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROFITLOSSACCOUNTNOTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPNL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProfitAndLoss.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtParentID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtParentSubID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.TabNote.ResumeLayout(False)
        CType(Me.txtMemo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAttachment.ResumeLayout(False)
        Me.TabAttachment.PerformLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROFITLOSSACCOUNTNOTEATTACHMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabColumn.ResumeLayout(False)
        Me.TabColumn.PerformLayout()
        CType(Me.txtCol6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCol5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCol4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCol3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCol2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCol1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROFITLOSSACCOUNTNOTECOLUMNBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGTypeNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleFrontNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnRemove As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PROFITLOSSACCOUNTNOTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsPNL As EasyTemplate_Taxcom.dsPNL
    Friend WithEvents txtParentSubID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtParentID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProfitAndLoss As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents TabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabNote As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtMemo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents TabAttachment As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddAttachment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParentID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAttachment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExtension As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabColumn As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCol6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCol5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCol4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCol3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCol2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCol1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParentID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCol1_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCol1_Val As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCol2_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCol2_Val As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCol3_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCol3_Val As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCol4_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCol4_Val As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCol5_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCol5_Val As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCol6_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCol6_Val As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitleNote As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RGTypeNote As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents PROFITLOSSACCOUNTNOTEATTACHMENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROFITLOSSACCOUNTNOTECOLUMNBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtTitleFrontNote As DevExpress.XtraEditors.TextEdit
End Class
