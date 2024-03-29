﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMovementComplex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucMovementComplex))
        Me.colModifiedDateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DsMovement = New EasyTemplate_Taxcom.dsMovement()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMM_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_REFNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_YA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_TITLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_PERIOD_ENDED = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_YEAR_ENDED = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_BALANCE_START = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_BALANCE_END = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_GENERAL_START = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_SPECIFIC_ALLOWABLE_START = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_SPECIFIC_NONALLOWABLE_START = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_NOTE_START = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_NOTE_END = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_GENERAL_END = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_SPECIFIC_ALLOWABLE_END = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMM_SPECIFIC_NONALLOWABLE_END = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.MOVEMENTCOMPLEXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.pnlLoading = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.btnClear2 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cboRefNo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.TaxPayerFindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCA = New EasyTemplate_Taxcom.dsCA()
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRefNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHandleBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployerNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.txtRefNo = New DevExpress.XtraEditors.TextEdit()
        Me.cboYA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnAllRecord = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btnTestPrint = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.DsMovement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOVEMENTCOMPLEXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colModifiedDateTime
        '
        Me.colModifiedDateTime.FieldName = "ModifiedDateTime"
        Me.colModifiedDateTime.Name = "colModifiedDateTime"
        Me.colModifiedDateTime.Visible = True
        Me.colModifiedDateTime.VisibleIndex = 14
        Me.colModifiedDateTime.Width = 180
        '
        'DsMovement
        '
        Me.DsMovement.DataSetName = "dsMovement"
        Me.DsMovement.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMM_ID, Me.colMM_REFNO, Me.colMM_YA, Me.colMM_TITLE, Me.colMM_PERIOD_ENDED, Me.colMM_YEAR_ENDED, Me.colMM_BALANCE_START, Me.colMM_BALANCE_END, Me.colMM_GENERAL_START, Me.colMM_SPECIFIC_ALLOWABLE_START, Me.colMM_SPECIFIC_NONALLOWABLE_START, Me.colMM_NOTE_START, Me.colMM_NOTE_END, Me.colMM_GENERAL_END, Me.colMM_SPECIFIC_ALLOWABLE_END, Me.colMM_SPECIFIC_NONALLOWABLE_END, Me.colModifiedBy, Me.colModifiedDateTime})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        '
        'colMM_ID
        '
        Me.colMM_ID.FieldName = "MM_ID"
        Me.colMM_ID.Name = "colMM_ID"
        '
        'colMM_REFNO
        '
        Me.colMM_REFNO.Caption = "Ref No"
        Me.colMM_REFNO.FieldName = "MM_REFNO"
        Me.colMM_REFNO.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colMM_REFNO.Name = "colMM_REFNO"
        Me.colMM_REFNO.Visible = True
        Me.colMM_REFNO.VisibleIndex = 0
        Me.colMM_REFNO.Width = 150
        '
        'colMM_YA
        '
        Me.colMM_YA.Caption = "YA"
        Me.colMM_YA.FieldName = "MM_YA"
        Me.colMM_YA.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colMM_YA.Name = "colMM_YA"
        Me.colMM_YA.Visible = True
        Me.colMM_YA.VisibleIndex = 1
        Me.colMM_YA.Width = 80
        '
        'colMM_TITLE
        '
        Me.colMM_TITLE.Caption = "Title"
        Me.colMM_TITLE.FieldName = "MM_TITLE"
        Me.colMM_TITLE.Name = "colMM_TITLE"
        Me.colMM_TITLE.Visible = True
        Me.colMM_TITLE.VisibleIndex = 2
        Me.colMM_TITLE.Width = 300
        '
        'colMM_PERIOD_ENDED
        '
        Me.colMM_PERIOD_ENDED.Caption = "Period Ended"
        Me.colMM_PERIOD_ENDED.FieldName = "MM_PERIOD_ENDED"
        Me.colMM_PERIOD_ENDED.Name = "colMM_PERIOD_ENDED"
        Me.colMM_PERIOD_ENDED.Visible = True
        Me.colMM_PERIOD_ENDED.VisibleIndex = 3
        Me.colMM_PERIOD_ENDED.Width = 150
        '
        'colMM_YEAR_ENDED
        '
        Me.colMM_YEAR_ENDED.Caption = "Year Ended"
        Me.colMM_YEAR_ENDED.FieldName = "MM_YEAR_ENDED"
        Me.colMM_YEAR_ENDED.Name = "colMM_YEAR_ENDED"
        Me.colMM_YEAR_ENDED.Visible = True
        Me.colMM_YEAR_ENDED.VisibleIndex = 4
        Me.colMM_YEAR_ENDED.Width = 150
        '
        'colMM_BALANCE_START
        '
        Me.colMM_BALANCE_START.Caption = "Balance Start"
        Me.colMM_BALANCE_START.FieldName = "MM_BALANCE_START"
        Me.colMM_BALANCE_START.Name = "colMM_BALANCE_START"
        Me.colMM_BALANCE_START.Visible = True
        Me.colMM_BALANCE_START.VisibleIndex = 5
        Me.colMM_BALANCE_START.Width = 150
        '
        'colMM_BALANCE_END
        '
        Me.colMM_BALANCE_END.Caption = "Balance End"
        Me.colMM_BALANCE_END.FieldName = "MM_BALANCE_END"
        Me.colMM_BALANCE_END.Name = "colMM_BALANCE_END"
        Me.colMM_BALANCE_END.Visible = True
        Me.colMM_BALANCE_END.VisibleIndex = 6
        Me.colMM_BALANCE_END.Width = 150
        '
        'colMM_GENERAL_START
        '
        Me.colMM_GENERAL_START.Caption = "General Start"
        Me.colMM_GENERAL_START.FieldName = "MM_GENERAL_START"
        Me.colMM_GENERAL_START.Name = "colMM_GENERAL_START"
        Me.colMM_GENERAL_START.Visible = True
        Me.colMM_GENERAL_START.VisibleIndex = 7
        Me.colMM_GENERAL_START.Width = 150
        '
        'colMM_SPECIFIC_ALLOWABLE_START
        '
        Me.colMM_SPECIFIC_ALLOWABLE_START.Caption = "Specific (Allowable)"
        Me.colMM_SPECIFIC_ALLOWABLE_START.FieldName = "MM_SPECIFIC_ALLOWABLE_START"
        Me.colMM_SPECIFIC_ALLOWABLE_START.Name = "colMM_SPECIFIC_ALLOWABLE_START"
        Me.colMM_SPECIFIC_ALLOWABLE_START.Visible = True
        Me.colMM_SPECIFIC_ALLOWABLE_START.VisibleIndex = 8
        Me.colMM_SPECIFIC_ALLOWABLE_START.Width = 150
        '
        'colMM_SPECIFIC_NONALLOWABLE_START
        '
        Me.colMM_SPECIFIC_NONALLOWABLE_START.Caption = "Specific (Non Allowable)"
        Me.colMM_SPECIFIC_NONALLOWABLE_START.FieldName = "MM_SPECIFIC_NONALLOWABLE_START"
        Me.colMM_SPECIFIC_NONALLOWABLE_START.Name = "colMM_SPECIFIC_NONALLOWABLE_START"
        Me.colMM_SPECIFIC_NONALLOWABLE_START.Visible = True
        Me.colMM_SPECIFIC_NONALLOWABLE_START.VisibleIndex = 9
        Me.colMM_SPECIFIC_NONALLOWABLE_START.Width = 150
        '
        'colMM_NOTE_START
        '
        Me.colMM_NOTE_START.FieldName = "MM_NOTE_START"
        Me.colMM_NOTE_START.Name = "colMM_NOTE_START"
        '
        'colMM_NOTE_END
        '
        Me.colMM_NOTE_END.FieldName = "MM_NOTE_END"
        Me.colMM_NOTE_END.Name = "colMM_NOTE_END"
        '
        'colMM_GENERAL_END
        '
        Me.colMM_GENERAL_END.Caption = "General End"
        Me.colMM_GENERAL_END.FieldName = "MM_GENERAL_END"
        Me.colMM_GENERAL_END.Name = "colMM_GENERAL_END"
        Me.colMM_GENERAL_END.Visible = True
        Me.colMM_GENERAL_END.VisibleIndex = 10
        Me.colMM_GENERAL_END.Width = 150
        '
        'colMM_SPECIFIC_ALLOWABLE_END
        '
        Me.colMM_SPECIFIC_ALLOWABLE_END.Caption = "Specific (Allowable)"
        Me.colMM_SPECIFIC_ALLOWABLE_END.FieldName = "MM_SPECIFIC_ALLOWABLE_END"
        Me.colMM_SPECIFIC_ALLOWABLE_END.Name = "colMM_SPECIFIC_ALLOWABLE_END"
        Me.colMM_SPECIFIC_ALLOWABLE_END.Visible = True
        Me.colMM_SPECIFIC_ALLOWABLE_END.VisibleIndex = 11
        Me.colMM_SPECIFIC_ALLOWABLE_END.Width = 150
        '
        'colMM_SPECIFIC_NONALLOWABLE_END
        '
        Me.colMM_SPECIFIC_NONALLOWABLE_END.Caption = "Specific (Non Allowable)"
        Me.colMM_SPECIFIC_NONALLOWABLE_END.FieldName = "MM_SPECIFIC_NONALLOWABLE_END"
        Me.colMM_SPECIFIC_NONALLOWABLE_END.Name = "colMM_SPECIFIC_NONALLOWABLE_END"
        Me.colMM_SPECIFIC_NONALLOWABLE_END.Visible = True
        Me.colMM_SPECIFIC_NONALLOWABLE_END.VisibleIndex = 12
        Me.colMM_SPECIFIC_NONALLOWABLE_END.Width = 150
        '
        'colModifiedBy
        '
        Me.colModifiedBy.FieldName = "ModifiedBy"
        Me.colModifiedBy.Name = "colModifiedBy"
        Me.colModifiedBy.Visible = True
        Me.colModifiedBy.VisibleIndex = 13
        Me.colModifiedBy.Width = 200
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.MOVEMENTCOMPLEXBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridControl1.Location = New System.Drawing.Point(0, 106)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(958, 395)
        Me.GridControl1.TabIndex = 18
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'MOVEMENTCOMPLEXBindingSource
        '
        Me.MOVEMENTCOMPLEXBindingSource.DataMember = "MOVEMENT_COMPLEX"
        Me.MOVEMENTCOMPLEXBindingSource.DataSource = Me.DsMovement
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnAdd, Me.btnEdit, Me.btnDelete, Me.btnPrint, Me.btnTestPrint})
        Me.BarManager1.MaxItemId = 8
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrint), New DevExpress.XtraBars.LinkPersistInfo(Me.btnTestPrint)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None
        Me.Bar1.OptionsBar.DisableClose = True
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'btnAdd
        '
        Me.btnAdd.Caption = "Add"
        Me.btnAdd.Id = 0
        Me.btnAdd.ImageOptions.Image = CType(resources.GetObject("btnAdd.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd.ImageOptions.LargeImage = CType(resources.GetObject("btnAdd.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnEdit
        '
        Me.btnEdit.Caption = "Edit"
        Me.btnEdit.Id = 1
        Me.btnEdit.ImageOptions.Image = CType(resources.GetObject("btnEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEdit.ImageOptions.LargeImage = CType(resources.GetObject("btnEdit.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnDelete
        '
        Me.btnDelete.Caption = "Delete"
        Me.btnDelete.Id = 2
        Me.btnDelete.ImageOptions.Image = CType(resources.GetObject("btnDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelete.ImageOptions.LargeImage = CType(resources.GetObject("btnDelete.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
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
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(958, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 501)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(958, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 470)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(958, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 470)
        '
        'pnlLoading
        '
        Me.pnlLoading.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlLoading.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pnlLoading.Appearance.Options.UseBackColor = True
        Me.pnlLoading.AppearanceCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.pnlLoading.AppearanceCaption.Options.UseFont = True
        Me.pnlLoading.AppearanceDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.pnlLoading.AppearanceDescription.Options.UseFont = True
        Me.pnlLoading.BarAnimationElementThickness = 2
        Me.pnlLoading.Location = New System.Drawing.Point(364, 192)
        Me.pnlLoading.Name = "pnlLoading"
        Me.pnlLoading.Size = New System.Drawing.Size(246, 66)
        Me.pnlLoading.TabIndex = 19
        Me.pnlLoading.Text = "ProgressPanel1"
        Me.pnlLoading.Visible = False
        '
        'btnClear2
        '
        Me.btnClear2.ImageOptions.Image = CType(resources.GetObject("btnClear2.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClear2.Location = New System.Drawing.Point(681, 13)
        Me.btnClear2.Name = "btnClear2"
        Me.btnClear2.Size = New System.Drawing.Size(24, 23)
        Me.btnClear2.TabIndex = 13
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Reference No :"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cboRefNo)
        Me.PanelControl1.Controls.Add(Me.btnClear2)
        Me.PanelControl1.Controls.Add(Me.btnClear)
        Me.PanelControl1.Controls.Add(Me.txtRefNo)
        Me.PanelControl1.Controls.Add(Me.cboYA)
        Me.PanelControl1.Controls.Add(Me.btnAllRecord)
        Me.PanelControl1.Controls.Add(Me.btnFind)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 31)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(958, 75)
        Me.PanelControl1.TabIndex = 17
        '
        'cboRefNo
        '
        Me.cboRefNo.Location = New System.Drawing.Point(90, 14)
        Me.cboRefNo.MenuManager = Me.BarManager1
        Me.cboRefNo.Name = "cboRefNo"
        Me.cboRefNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRefNo.Properties.DataSource = Me.TaxPayerFindBindingSource
        Me.cboRefNo.Properties.DisplayMember = "CompanyName"
        Me.cboRefNo.Properties.NullText = "Select"
        Me.cboRefNo.Properties.PopupFormMinSize = New System.Drawing.Size(600, 0)
        Me.cboRefNo.Properties.ValueMember = "RefNo"
        Me.cboRefNo.Properties.View = Me.SearchLookUpEdit2View
        Me.cboRefNo.Size = New System.Drawing.Size(268, 20)
        Me.cboRefNo.TabIndex = 162
        '
        'TaxPayerFindBindingSource
        '
        Me.TaxPayerFindBindingSource.DataMember = "TaxPayerFind"
        Me.TaxPayerFindBindingSource.DataSource = Me.DsCA
        '
        'DsCA
        '
        Me.DsCA.DataSetName = "dsCA"
        Me.DsCA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SearchLookUpEdit2View
        '
        Me.SearchLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRefNo, Me.colCompanyName, Me.colHandleBy, Me.colCompanyNo, Me.colEmployerNo, Me.colFileNo, Me.colCountry, Me.colCompanyCode})
        Me.SearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit2View.Name = "SearchLookUpEdit2View"
        Me.SearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit2View.OptionsView.ColumnAutoWidth = False
        Me.SearchLookUpEdit2View.OptionsView.RowAutoHeight = True
        Me.SearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colRefNo
        '
        Me.colRefNo.FieldName = "RefNo"
        Me.colRefNo.Name = "colRefNo"
        Me.colRefNo.Visible = True
        Me.colRefNo.VisibleIndex = 0
        Me.colRefNo.Width = 100
        '
        'colCompanyName
        '
        Me.colCompanyName.FieldName = "CompanyName"
        Me.colCompanyName.Name = "colCompanyName"
        Me.colCompanyName.Visible = True
        Me.colCompanyName.VisibleIndex = 1
        Me.colCompanyName.Width = 250
        '
        'colHandleBy
        '
        Me.colHandleBy.FieldName = "HandleBy"
        Me.colHandleBy.Name = "colHandleBy"
        Me.colHandleBy.Visible = True
        Me.colHandleBy.VisibleIndex = 2
        Me.colHandleBy.Width = 150
        '
        'colCompanyNo
        '
        Me.colCompanyNo.FieldName = "CompanyNo"
        Me.colCompanyNo.Name = "colCompanyNo"
        Me.colCompanyNo.Visible = True
        Me.colCompanyNo.VisibleIndex = 3
        Me.colCompanyNo.Width = 100
        '
        'colEmployerNo
        '
        Me.colEmployerNo.FieldName = "EmployerNo"
        Me.colEmployerNo.Name = "colEmployerNo"
        Me.colEmployerNo.Visible = True
        Me.colEmployerNo.VisibleIndex = 4
        Me.colEmployerNo.Width = 100
        '
        'colFileNo
        '
        Me.colFileNo.FieldName = "FileNo"
        Me.colFileNo.Name = "colFileNo"
        Me.colFileNo.Visible = True
        Me.colFileNo.VisibleIndex = 5
        Me.colFileNo.Width = 100
        '
        'colCountry
        '
        Me.colCountry.FieldName = "Country"
        Me.colCountry.Name = "colCountry"
        Me.colCountry.Visible = True
        Me.colCountry.VisibleIndex = 6
        Me.colCountry.Width = 100
        '
        'colCompanyCode
        '
        Me.colCompanyCode.FieldName = "CompanyCode"
        Me.colCompanyCode.Name = "colCompanyCode"
        Me.colCompanyCode.Visible = True
        Me.colCompanyCode.VisibleIndex = 7
        Me.colCompanyCode.Width = 100
        '
        'btnClear
        '
        Me.btnClear.ImageOptions.Image = CType(resources.GetObject("btnClear.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClear.Location = New System.Drawing.Point(364, 13)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(24, 23)
        Me.btnClear.TabIndex = 12
        '
        'txtRefNo
        '
        Me.txtRefNo.Location = New System.Drawing.Point(91, 41)
        Me.txtRefNo.MenuManager = Me.BarManager1
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Properties.ReadOnly = True
        Me.txtRefNo.Size = New System.Drawing.Size(268, 20)
        Me.txtRefNo.TabIndex = 11
        '
        'cboYA
        '
        Me.cboYA.Location = New System.Drawing.Point(449, 14)
        Me.cboYA.Name = "cboYA"
        Me.cboYA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboYA.Properties.PopupSizeable = True
        Me.cboYA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboYA.Size = New System.Drawing.Size(226, 20)
        Me.cboYA.TabIndex = 10
        '
        'btnAllRecord
        '
        Me.btnAllRecord.ImageOptions.Image = CType(resources.GetObject("btnAllRecord.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAllRecord.Location = New System.Drawing.Point(449, 38)
        Me.btnAllRecord.Name = "btnAllRecord"
        Me.btnAllRecord.Size = New System.Drawing.Size(110, 23)
        Me.btnAllRecord.TabIndex = 8
        Me.btnAllRecord.Text = "All Record"
        '
        'btnFind
        '
        Me.btnFind.ImageOptions.Image = CType(resources.GetObject("btnFind.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFind.Location = New System.Drawing.Point(565, 38)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(110, 23)
        Me.btnFind.TabIndex = 7
        Me.btnFind.Text = "Find"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(423, 17)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "YA :"
        '
        'btnTestPrint
        '
        Me.btnTestPrint.Caption = "Test Print"
        Me.btnTestPrint.Id = 7
        Me.btnTestPrint.Name = "btnTestPrint"
        '
        'ucMovementComplex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlLoading)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "ucMovementComplex"
        Me.Size = New System.Drawing.Size(958, 501)
        CType(Me.DsMovement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOVEMENTCOMPLEXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents colModifiedDateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsMovement As EasyTemplate_Taxcom.dsMovement
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMM_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_REFNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_YA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_TITLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_PERIOD_ENDED As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_YEAR_ENDED As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_BALANCE_START As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_BALANCE_END As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_GENERAL_START As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_SPECIFIC_ALLOWABLE_START As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_SPECIFIC_NONALLOWABLE_START As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_NOTE_START As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_NOTE_END As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_GENERAL_END As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_SPECIFIC_ALLOWABLE_END As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMM_SPECIFIC_NONALLOWABLE_END As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents MOVEMENTCOMPLEXBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents pnlLoading As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClear2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRefNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboYA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TaxPayerFindBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsCA As EasyTemplate_Taxcom.dsCA
    Friend WithEvents btnAllRecord As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboRefNo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRefNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHandleBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployerNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnTestPrint As DevExpress.XtraBars.BarButtonItem

End Class
