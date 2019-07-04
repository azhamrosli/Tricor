<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPNL_Quick
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPNL_Quick))
        Dim DockingContainer1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKEYNAME3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSOURCE_NO1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPTION2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAMOUNT2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPECENTAGE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEDUCTIBLE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEDUCTIBLE_ADD1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPECENTAGE_AMOUNT1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOTE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.PNLQUICKDETAILBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPNL = New EasyTemplate_Taxcom.dsPNL()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKEYNAME1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboPNLINFO = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.PNLTABLEINFOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPNLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLabelNameTricor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKeyName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSOURCE_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboSourceNo = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.BUSINESSSOURCEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDESCRIPTION1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAMOUNT1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.isNumeric = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colPECENTAGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEDUCTIBLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEDUCTIBLE_ADD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPECENTAGE_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.PNLQUICKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKEYNAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPTION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.DocumentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
        Me.Document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
        Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PNLQUICKDETAILBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPNL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPNLINFO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PNLTABLEINFOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPNLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSourceNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BUSINESSSOURCEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PNLQUICKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel2.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Document1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKEYNAME3, Me.colSOURCE_NO1, Me.colDESCRIPTION2, Me.colAMOUNT2, Me.colPECENTAGE1, Me.colDEDUCTIBLE1, Me.colDEDUCTIBLE_ADD1, Me.colPECENTAGE_AMOUNT1, Me.colNOTE1})
        Me.GridView4.GridControl = Me.GridControl2
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView4.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView4.OptionsView.ColumnAutoWidth = False
        Me.GridView4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'colKEYNAME3
        '
        Me.colKEYNAME3.Caption = "Key Name"
        Me.colKEYNAME3.FieldName = "KEYNAME"
        Me.colKEYNAME3.Name = "colKEYNAME3"
        '
        'colSOURCE_NO1
        '
        Me.colSOURCE_NO1.Caption = "Source No"
        Me.colSOURCE_NO1.FieldName = "SOURCE_NO"
        Me.colSOURCE_NO1.Name = "colSOURCE_NO1"
        '
        'colDESCRIPTION2
        '
        Me.colDESCRIPTION2.Caption = "Description"
        Me.colDESCRIPTION2.FieldName = "DESCRIPTION"
        Me.colDESCRIPTION2.Name = "colDESCRIPTION2"
        Me.colDESCRIPTION2.Visible = True
        Me.colDESCRIPTION2.VisibleIndex = 0
        Me.colDESCRIPTION2.Width = 300
        '
        'colAMOUNT2
        '
        Me.colAMOUNT2.Caption = "Amount"
        Me.colAMOUNT2.FieldName = "AMOUNT"
        Me.colAMOUNT2.Name = "colAMOUNT2"
        Me.colAMOUNT2.Visible = True
        Me.colAMOUNT2.VisibleIndex = 1
        Me.colAMOUNT2.Width = 120
        '
        'colPECENTAGE1
        '
        Me.colPECENTAGE1.Caption = "Percentage %"
        Me.colPECENTAGE1.FieldName = "PECENTAGE"
        Me.colPECENTAGE1.Name = "colPECENTAGE1"
        Me.colPECENTAGE1.Visible = True
        Me.colPECENTAGE1.VisibleIndex = 2
        Me.colPECENTAGE1.Width = 120
        '
        'colDEDUCTIBLE1
        '
        Me.colDEDUCTIBLE1.Caption = "Add Back"
        Me.colDEDUCTIBLE1.FieldName = "DEDUCTIBLE"
        Me.colDEDUCTIBLE1.Name = "colDEDUCTIBLE1"
        Me.colDEDUCTIBLE1.Visible = True
        Me.colDEDUCTIBLE1.VisibleIndex = 3
        Me.colDEDUCTIBLE1.Width = 120
        '
        'colDEDUCTIBLE_ADD1
        '
        Me.colDEDUCTIBLE_ADD1.Caption = "Deduct"
        Me.colDEDUCTIBLE_ADD1.FieldName = "DEDUCTIBLE_ADD"
        Me.colDEDUCTIBLE_ADD1.Name = "colDEDUCTIBLE_ADD1"
        Me.colDEDUCTIBLE_ADD1.Visible = True
        Me.colDEDUCTIBLE_ADD1.VisibleIndex = 4
        Me.colDEDUCTIBLE_ADD1.Width = 120
        '
        'colPECENTAGE_AMOUNT1
        '
        Me.colPECENTAGE_AMOUNT1.Caption = "Percentage Amount"
        Me.colPECENTAGE_AMOUNT1.FieldName = "PECENTAGE_AMOUNT"
        Me.colPECENTAGE_AMOUNT1.Name = "colPECENTAGE_AMOUNT1"
        Me.colPECENTAGE_AMOUNT1.Visible = True
        Me.colPECENTAGE_AMOUNT1.VisibleIndex = 5
        Me.colPECENTAGE_AMOUNT1.Width = 120
        '
        'colNOTE1
        '
        Me.colNOTE1.Caption = "Note"
        Me.colNOTE1.FieldName = "NOTE"
        Me.colNOTE1.Name = "colNOTE1"
        Me.colNOTE1.Visible = True
        Me.colNOTE1.VisibleIndex = 6
        Me.colNOTE1.Width = 400
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.PNLQUICKDETAILBindingSource
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GridView4
        GridLevelNode1.RelationName = "FK_PNL_QUICK_DETAIL_PNL_QUICK_DETAIL_SUB"
        Me.GridControl2.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.MenuManager = Me.BarManager1
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboPNLINFO, Me.cboSourceNo, Me.isNumeric})
        Me.GridControl2.Size = New System.Drawing.Size(616, 508)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2, Me.GridView4})
        '
        'PNLQUICKDETAILBindingSource
        '
        Me.PNLQUICKDETAILBindingSource.DataMember = "PNL_QUICK_DETAIL"
        Me.PNLQUICKDETAILBindingSource.DataSource = Me.DsPNL
        '
        'DsPNL
        '
        Me.DsPNL.DataSetName = "dsPNL"
        Me.DsPNL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKEYNAME1, Me.colSOURCE_NO, Me.colDESCRIPTION1, Me.colAMOUNT1, Me.colPECENTAGE, Me.colDEDUCTIBLE, Me.colDEDUCTIBLE_ADD, Me.colPECENTAGE_AMOUNT, Me.colNOTE})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'colKEYNAME1
        '
        Me.colKEYNAME1.Caption = "Category"
        Me.colKEYNAME1.ColumnEdit = Me.cboPNLINFO
        Me.colKEYNAME1.FieldName = "KEYNAME"
        Me.colKEYNAME1.Name = "colKEYNAME1"
        Me.colKEYNAME1.Visible = True
        Me.colKEYNAME1.VisibleIndex = 0
        Me.colKEYNAME1.Width = 110
        '
        'cboPNLINFO
        '
        Me.cboPNLINFO.AutoHeight = False
        Me.cboPNLINFO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPNLINFO.DataSource = Me.PNLTABLEINFOBindingSource
        Me.cboPNLINFO.DisplayMember = "KeyName"
        Me.cboPNLINFO.Name = "cboPNLINFO"
        Me.cboPNLINFO.NullText = "Select"
        Me.cboPNLINFO.ValueMember = "KeyName"
        Me.cboPNLINFO.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'PNLTABLEINFOBindingSource
        '
        Me.PNLTABLEINFOBindingSource.DataMember = "PNL_TABLE_INFO"
        Me.PNLTABLEINFOBindingSource.DataSource = Me.DsPNLBindingSource
        '
        'DsPNLBindingSource
        '
        Me.DsPNLBindingSource.DataSource = Me.DsPNL
        Me.DsPNLBindingSource.Position = 0
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLabelNameTricor, Me.colKeyName2})
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colLabelNameTricor
        '
        Me.colLabelNameTricor.FieldName = "LabelNameTricor"
        Me.colLabelNameTricor.Name = "colLabelNameTricor"
        Me.colLabelNameTricor.Visible = True
        Me.colLabelNameTricor.VisibleIndex = 0
        Me.colLabelNameTricor.Width = 364
        '
        'colKeyName2
        '
        Me.colKeyName2.FieldName = "KeyName"
        Me.colKeyName2.Name = "colKeyName2"
        Me.colKeyName2.Visible = True
        Me.colKeyName2.VisibleIndex = 1
        Me.colKeyName2.Width = 20
        '
        'colSOURCE_NO
        '
        Me.colSOURCE_NO.Caption = "Source No"
        Me.colSOURCE_NO.ColumnEdit = Me.cboSourceNo
        Me.colSOURCE_NO.FieldName = "SOURCE_NO"
        Me.colSOURCE_NO.Name = "colSOURCE_NO"
        Me.colSOURCE_NO.Visible = True
        Me.colSOURCE_NO.VisibleIndex = 1
        Me.colSOURCE_NO.Width = 80
        '
        'cboSourceNo
        '
        Me.cboSourceNo.AutoHeight = False
        Me.cboSourceNo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSourceNo.DataSource = Me.BUSINESSSOURCEBindingSource
        Me.cboSourceNo.DisplayMember = "BC_SOURCENO"
        Me.cboSourceNo.Name = "cboSourceNo"
        Me.cboSourceNo.NullText = "Select"
        Me.cboSourceNo.ValueMember = "BC_SOURCENO"
        Me.cboSourceNo.View = Me.GridView3
        '
        'BUSINESSSOURCEBindingSource
        '
        Me.BUSINESSSOURCEBindingSource.DataMember = "BUSINESS_SOURCE"
        Me.BUSINESSSOURCEBindingSource.DataSource = Me.DsPNLBindingSource
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colDESCRIPTION1
        '
        Me.colDESCRIPTION1.Caption = "Description"
        Me.colDESCRIPTION1.FieldName = "DESCRIPTION"
        Me.colDESCRIPTION1.Name = "colDESCRIPTION1"
        Me.colDESCRIPTION1.Visible = True
        Me.colDESCRIPTION1.VisibleIndex = 2
        Me.colDESCRIPTION1.Width = 300
        '
        'colAMOUNT1
        '
        Me.colAMOUNT1.Caption = "Amount"
        Me.colAMOUNT1.ColumnEdit = Me.isNumeric
        Me.colAMOUNT1.DisplayFormat.FormatString = "n0"
        Me.colAMOUNT1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAMOUNT1.FieldName = "AMOUNT"
        Me.colAMOUNT1.Name = "colAMOUNT1"
        Me.colAMOUNT1.Visible = True
        Me.colAMOUNT1.VisibleIndex = 3
        Me.colAMOUNT1.Width = 100
        '
        'isNumeric
        '
        Me.isNumeric.AutoHeight = False
        Me.isNumeric.Mask.EditMask = "n"
        Me.isNumeric.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.isNumeric.Name = "isNumeric"
        '
        'colPECENTAGE
        '
        Me.colPECENTAGE.Caption = "Percentage %"
        Me.colPECENTAGE.FieldName = "PECENTAGE"
        Me.colPECENTAGE.Name = "colPECENTAGE"
        Me.colPECENTAGE.Visible = True
        Me.colPECENTAGE.VisibleIndex = 4
        Me.colPECENTAGE.Width = 130
        '
        'colDEDUCTIBLE
        '
        Me.colDEDUCTIBLE.Caption = "Add Back"
        Me.colDEDUCTIBLE.FieldName = "DEDUCTIBLE"
        Me.colDEDUCTIBLE.Name = "colDEDUCTIBLE"
        Me.colDEDUCTIBLE.Visible = True
        Me.colDEDUCTIBLE.VisibleIndex = 5
        Me.colDEDUCTIBLE.Width = 130
        '
        'colDEDUCTIBLE_ADD
        '
        Me.colDEDUCTIBLE_ADD.Caption = "Deduct"
        Me.colDEDUCTIBLE_ADD.FieldName = "DEDUCTIBLE_ADD"
        Me.colDEDUCTIBLE_ADD.Name = "colDEDUCTIBLE_ADD"
        Me.colDEDUCTIBLE_ADD.Visible = True
        Me.colDEDUCTIBLE_ADD.VisibleIndex = 6
        Me.colDEDUCTIBLE_ADD.Width = 130
        '
        'colPECENTAGE_AMOUNT
        '
        Me.colPECENTAGE_AMOUNT.Caption = "Percentage Amount"
        Me.colPECENTAGE_AMOUNT.FieldName = "PECENTAGE_AMOUNT"
        Me.colPECENTAGE_AMOUNT.Name = "colPECENTAGE_AMOUNT"
        Me.colPECENTAGE_AMOUNT.Visible = True
        Me.colPECENTAGE_AMOUNT.VisibleIndex = 7
        Me.colPECENTAGE_AMOUNT.Width = 130
        '
        'colNOTE
        '
        Me.colNOTE.Caption = "Note"
        Me.colNOTE.FieldName = "NOTE"
        Me.colNOTE.Name = "colNOTE"
        Me.colNOTE.Visible = True
        Me.colNOTE.VisibleIndex = 8
        Me.colNOTE.Width = 250
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
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSave, Me.btnClose})
        Me.BarManager1.MaxItemId = 10
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemSpinEdit1})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSave), New DevExpress.XtraBars.LinkPersistInfo(Me.btnClose)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None
        Me.Bar1.OptionsBar.DisableClose = True
        Me.Bar1.OptionsBar.DisableCustomization = True
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
        'btnClose
        '
        Me.btnClose.Caption = "Close"
        Me.btnClose.Id = 2
        Me.btnClose.ImageOptions.Image = CType(resources.GetObject("btnClose.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClose.ImageOptions.LargeImage = CType(resources.GetObject("btnClose.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1014, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 567)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1014, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 536)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1014, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 536)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1, Me.DockPanel2})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("6d0c17e9-7f7d-466d-9b91-6529f8043e2b")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 31)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(392, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(392, 536)
        Me.DockPanel1.Text = "Menu"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.GridControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(383, 509)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.PNLQUICKBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(383, 509)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'PNLQUICKBindingSource
        '
        Me.PNLQUICKBindingSource.DataMember = "PNL_QUICK"
        Me.PNLQUICKBindingSource.DataSource = Me.DsPNL
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKEYNAME, Me.colDESCRIPTION, Me.colAMOUNT})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'colKEYNAME
        '
        Me.colKEYNAME.FieldName = "KEYNAME"
        Me.colKEYNAME.Name = "colKEYNAME"
        '
        'colDESCRIPTION
        '
        Me.colDESCRIPTION.FieldName = "DESCRIPTION"
        Me.colDESCRIPTION.Name = "colDESCRIPTION"
        Me.colDESCRIPTION.Visible = True
        Me.colDESCRIPTION.VisibleIndex = 0
        Me.colDESCRIPTION.Width = 250
        '
        'colAMOUNT
        '
        Me.colAMOUNT.DisplayFormat.FormatString = "n0"
        Me.colAMOUNT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAMOUNT.FieldName = "AMOUNT"
        Me.colAMOUNT.Name = "colAMOUNT"
        Me.colAMOUNT.Visible = True
        Me.colAMOUNT.VisibleIndex = 1
        Me.colAMOUNT.Width = 115
        '
        'DockPanel2
        '
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.DockedAsTabbedDocument = True
        Me.DockPanel2.FloatLocation = New System.Drawing.Point(637, 430)
        Me.DockPanel2.ID = New System.Guid("f9bf5a60-1400-4fbe-aae3-14490457da58")
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.Options.FloatOnDblClick = False
        Me.DockPanel2.Options.ShowCloseButton = False
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel2.SavedIndex = 1
        Me.DockPanel2.SavedMdiDocument = True
        Me.DockPanel2.Text = "Detail(s)"
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.GridControl2)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(616, 508)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.Mask.EditMask = "n0"
        Me.RepositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        Me.RepositoryItemSpinEdit1.NullText = "1"
        Me.RepositoryItemSpinEdit1.NullValuePrompt = "1"
        '
        'DocumentGroup1
        '
        Me.DocumentGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.Document1})
        '
        'Document1
        '
        Me.Document1.Caption = "Detail(s)"
        Me.Document1.ControlName = "DockPanel2"
        Me.Document1.FloatLocation = New System.Drawing.Point(637, 430)
        Me.Document1.FloatSize = New System.Drawing.Size(200, 200)
        Me.Document1.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
        Me.Document1.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
        Me.Document1.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
        '
        'DocumentManager1
        '
        Me.DocumentManager1.ContainerControl = Me
        Me.DocumentManager1.View = Me.TabbedView1
        Me.DocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.TabbedView1})
        '
        'TabbedView1
        '
        Me.TabbedView1.DocumentGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup() {Me.DocumentGroup1})
        Me.TabbedView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.Document1})
        Me.TabbedView1.RootContainer.Element = Nothing
        DockingContainer1.Element = Me.DocumentGroup1
        Me.TabbedView1.RootContainer.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {DockingContainer1})
        '
        'frmPNL_Quick
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 567)
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmPNL_Quick"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quick Profit And Loss"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PNLQUICKDETAILBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPNL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPNLINFO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PNLTABLEINFOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPNLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSourceNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BUSINESSSOURCEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PNLQUICKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel2.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Document1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents DocumentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
    Friend WithEvents TabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
    Friend WithEvents Document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
    Friend WithEvents PNLQUICKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsPNL As EasyTemplate_Taxcom.dsPNL
    Friend WithEvents colKEYNAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPTION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents PNLQUICKDETAILBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKEYNAME1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSOURCE_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPTION1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAMOUNT1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DocumentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
    Friend WithEvents cboPNLINFO As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents DsPNLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PNLTABLEINFOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colKeyName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLabelNameTricor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboSourceNo As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents BUSINESSSOURCEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents isNumeric As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKEYNAME3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSOURCE_NO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPTION2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAMOUNT2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEDUCTIBLE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEDUCTIBLE_ADD1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPECENTAGE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPECENTAGE_AMOUNT1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOTE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEDUCTIBLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEDUCTIBLE_ADD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPECENTAGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPECENTAGE_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
End Class
