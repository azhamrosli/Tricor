<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCP204
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucCP204))
        Me.colBCP_CURR_CORR_STATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_CURR_CORR_POST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_CURR_CORR_ADD3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_CURR_CORR_ADD2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_CURR_CORR_ADD1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_NEWCO_BAS_SUB_TO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_NEWCO_BAS_SUB_FR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_NEWCO_BAS_TO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_NEWCO_BAS_FR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_LAST_INSTALMENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_FIRST_INSTALMENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_TO_MONTH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_NEWCO_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_BASIS_PERIOD_TO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_BASIS_PERIOD_FR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_ACC_PERIOD_TO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_CURR_CORR_CITY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_ESTIMATED_TAX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_REV_ESTIMATED_TAX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_SME_PERIOD_TO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_SME_PERIOD_FR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_CHKM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_INDICATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_ESTIMATED = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_VERSION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_FORM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_ACC_PERIOD_FR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_BASIS_PERIOD_SUB_TO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_BASIS_PERIOD_FLW_TO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_BASIS_PERIOD_FLW_FR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_NEW_ACC_PERIOD_TO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_NEW_ACC_PERIOD_FR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_FROM_INSTALMENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_FR_MONTH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_TOTAL_PAID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_BASIS_PERIOD_SUB_FR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_BAL_ESTIMATED_TAX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMonth = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.btnImportExport = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btnClear2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.txtRefNo = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cboRefNo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.TaxPayerFindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDefault = New EasyTemplate_Taxcom.dsDefault()
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRefNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHandleBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployerNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboYA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnAllRecord = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.colBCP_CORRESPOND_STATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_CORRESPOND_CITY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_CORRESPOND_POST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_CORRESPOND_ADD3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_CORRESPOND_ADD2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_CORRESPOND_ADD1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_CO_REGNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_CO_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_YA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBCP_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBCP_REF_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BORANGCP204BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCP204 = New EasyTemplate_Taxcom.dsCP204()
        CType(Me.txtMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BORANGCP204BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCP204, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colBCP_CURR_CORR_STATE
        '
        Me.colBCP_CURR_CORR_STATE.FieldName = "BCP_CURR_CORR_STATE"
        Me.colBCP_CURR_CORR_STATE.Name = "colBCP_CURR_CORR_STATE"
        '
        'colBCP_CURR_CORR_POST
        '
        Me.colBCP_CURR_CORR_POST.FieldName = "BCP_CURR_CORR_POST"
        Me.colBCP_CURR_CORR_POST.Name = "colBCP_CURR_CORR_POST"
        '
        'colBCP_CURR_CORR_ADD3
        '
        Me.colBCP_CURR_CORR_ADD3.FieldName = "BCP_CURR_CORR_ADD3"
        Me.colBCP_CURR_CORR_ADD3.Name = "colBCP_CURR_CORR_ADD3"
        '
        'colBCP_CURR_CORR_ADD2
        '
        Me.colBCP_CURR_CORR_ADD2.FieldName = "BCP_CURR_CORR_ADD2"
        Me.colBCP_CURR_CORR_ADD2.Name = "colBCP_CURR_CORR_ADD2"
        '
        'colBCP_CURR_CORR_ADD1
        '
        Me.colBCP_CURR_CORR_ADD1.FieldName = "BCP_CURR_CORR_ADD1"
        Me.colBCP_CURR_CORR_ADD1.Name = "colBCP_CURR_CORR_ADD1"
        '
        'colBCP_NEWCO_BAS_SUB_TO
        '
        Me.colBCP_NEWCO_BAS_SUB_TO.FieldName = "BCP_NEWCO_BAS_SUB_TO"
        Me.colBCP_NEWCO_BAS_SUB_TO.Name = "colBCP_NEWCO_BAS_SUB_TO"
        '
        'colBCP_NEWCO_BAS_SUB_FR
        '
        Me.colBCP_NEWCO_BAS_SUB_FR.FieldName = "BCP_NEWCO_BAS_SUB_FR"
        Me.colBCP_NEWCO_BAS_SUB_FR.Name = "colBCP_NEWCO_BAS_SUB_FR"
        '
        'colBCP_NEWCO_BAS_TO
        '
        Me.colBCP_NEWCO_BAS_TO.FieldName = "BCP_NEWCO_BAS_TO"
        Me.colBCP_NEWCO_BAS_TO.Name = "colBCP_NEWCO_BAS_TO"
        '
        'colBCP_NEWCO_BAS_FR
        '
        Me.colBCP_NEWCO_BAS_FR.FieldName = "BCP_NEWCO_BAS_FR"
        Me.colBCP_NEWCO_BAS_FR.Name = "colBCP_NEWCO_BAS_FR"
        '
        'colBCP_LAST_INSTALMENT
        '
        Me.colBCP_LAST_INSTALMENT.Caption = "Last Installment"
        Me.colBCP_LAST_INSTALMENT.FieldName = "BCP_LAST_INSTALMENT"
        Me.colBCP_LAST_INSTALMENT.Name = "colBCP_LAST_INSTALMENT"
        Me.colBCP_LAST_INSTALMENT.Visible = True
        Me.colBCP_LAST_INSTALMENT.VisibleIndex = 19
        Me.colBCP_LAST_INSTALMENT.Width = 150
        '
        'colBCP_FIRST_INSTALMENT
        '
        Me.colBCP_FIRST_INSTALMENT.Caption = "First Installment"
        Me.colBCP_FIRST_INSTALMENT.FieldName = "BCP_FIRST_INSTALMENT"
        Me.colBCP_FIRST_INSTALMENT.Name = "colBCP_FIRST_INSTALMENT"
        Me.colBCP_FIRST_INSTALMENT.Visible = True
        Me.colBCP_FIRST_INSTALMENT.VisibleIndex = 18
        Me.colBCP_FIRST_INSTALMENT.Width = 150
        '
        'colBCP_TO_MONTH
        '
        Me.colBCP_TO_MONTH.Caption = "Month"
        Me.colBCP_TO_MONTH.FieldName = "BCP_TO_MONTH"
        Me.colBCP_TO_MONTH.Name = "colBCP_TO_MONTH"
        Me.colBCP_TO_MONTH.Visible = True
        Me.colBCP_TO_MONTH.VisibleIndex = 17
        Me.colBCP_TO_MONTH.Width = 150
        '
        'colBCP_NEWCO_DATE
        '
        Me.colBCP_NEWCO_DATE.FieldName = "BCP_NEWCO_DATE"
        Me.colBCP_NEWCO_DATE.Name = "colBCP_NEWCO_DATE"
        Me.colBCP_NEWCO_DATE.Width = 150
        '
        'colBCP_BASIS_PERIOD_TO
        '
        Me.colBCP_BASIS_PERIOD_TO.Caption = "Basis Period To"
        Me.colBCP_BASIS_PERIOD_TO.FieldName = "BCP_BASIS_PERIOD_TO"
        Me.colBCP_BASIS_PERIOD_TO.Name = "colBCP_BASIS_PERIOD_TO"
        Me.colBCP_BASIS_PERIOD_TO.Visible = True
        Me.colBCP_BASIS_PERIOD_TO.VisibleIndex = 16
        Me.colBCP_BASIS_PERIOD_TO.Width = 150
        '
        'colBCP_BASIS_PERIOD_FR
        '
        Me.colBCP_BASIS_PERIOD_FR.Caption = "Basis Period From"
        Me.colBCP_BASIS_PERIOD_FR.FieldName = "BCP_BASIS_PERIOD_FR"
        Me.colBCP_BASIS_PERIOD_FR.Name = "colBCP_BASIS_PERIOD_FR"
        Me.colBCP_BASIS_PERIOD_FR.Visible = True
        Me.colBCP_BASIS_PERIOD_FR.VisibleIndex = 15
        Me.colBCP_BASIS_PERIOD_FR.Width = 150
        '
        'colBCP_ACC_PERIOD_TO
        '
        Me.colBCP_ACC_PERIOD_TO.Caption = "Account Period To"
        Me.colBCP_ACC_PERIOD_TO.FieldName = "BCP_ACC_PERIOD_TO"
        Me.colBCP_ACC_PERIOD_TO.Name = "colBCP_ACC_PERIOD_TO"
        Me.colBCP_ACC_PERIOD_TO.Visible = True
        Me.colBCP_ACC_PERIOD_TO.VisibleIndex = 14
        Me.colBCP_ACC_PERIOD_TO.Width = 150
        '
        'colBCP_CURR_CORR_CITY
        '
        Me.colBCP_CURR_CORR_CITY.FieldName = "BCP_CURR_CORR_CITY"
        Me.colBCP_CURR_CORR_CITY.Name = "colBCP_CURR_CORR_CITY"
        '
        'colBCP_ESTIMATED_TAX
        '
        Me.colBCP_ESTIMATED_TAX.Caption = "Estimated Tax"
        Me.colBCP_ESTIMATED_TAX.FieldName = "BCP_ESTIMATED_TAX"
        Me.colBCP_ESTIMATED_TAX.Name = "colBCP_ESTIMATED_TAX"
        Me.colBCP_ESTIMATED_TAX.Visible = True
        Me.colBCP_ESTIMATED_TAX.VisibleIndex = 12
        Me.colBCP_ESTIMATED_TAX.Width = 150
        '
        'colBCP_REV_ESTIMATED_TAX
        '
        Me.colBCP_REV_ESTIMATED_TAX.FieldName = "BCP_REV_ESTIMATED_TAX"
        Me.colBCP_REV_ESTIMATED_TAX.Name = "colBCP_REV_ESTIMATED_TAX"
        '
        'colModifiedDateTime
        '
        Me.colModifiedDateTime.FieldName = "ModifiedDateTime"
        Me.colModifiedDateTime.Name = "colModifiedDateTime"
        Me.colModifiedDateTime.Visible = True
        Me.colModifiedDateTime.VisibleIndex = 21
        Me.colModifiedDateTime.Width = 150
        '
        'colBCP_SME_PERIOD_TO
        '
        Me.colBCP_SME_PERIOD_TO.FieldName = "BCP_SME_PERIOD_TO"
        Me.colBCP_SME_PERIOD_TO.Name = "colBCP_SME_PERIOD_TO"
        '
        'colBCP_SME_PERIOD_FR
        '
        Me.colBCP_SME_PERIOD_FR.FieldName = "BCP_SME_PERIOD_FR"
        Me.colBCP_SME_PERIOD_FR.Name = "colBCP_SME_PERIOD_FR"
        '
        'colBCP_CHKM
        '
        Me.colBCP_CHKM.FieldName = "BCP_CHKM"
        Me.colBCP_CHKM.Name = "colBCP_CHKM"
        '
        'colBCP_INDICATE
        '
        Me.colBCP_INDICATE.FieldName = "BCP_INDICATE"
        Me.colBCP_INDICATE.Name = "colBCP_INDICATE"
        '
        'colBCP_ESTIMATED
        '
        Me.colBCP_ESTIMATED.FieldName = "BCP_ESTIMATED"
        Me.colBCP_ESTIMATED.Name = "colBCP_ESTIMATED"
        '
        'colBCP_VERSION
        '
        Me.colBCP_VERSION.FieldName = "BCP_VERSION"
        Me.colBCP_VERSION.Name = "colBCP_VERSION"
        '
        'colBCP_FORM
        '
        Me.colBCP_FORM.FieldName = "BCP_FORM"
        Me.colBCP_FORM.Name = "colBCP_FORM"
        '
        'colBCP_ACC_PERIOD_FR
        '
        Me.colBCP_ACC_PERIOD_FR.Caption = "Account Period From"
        Me.colBCP_ACC_PERIOD_FR.FieldName = "BCP_ACC_PERIOD_FR"
        Me.colBCP_ACC_PERIOD_FR.Name = "colBCP_ACC_PERIOD_FR"
        Me.colBCP_ACC_PERIOD_FR.Visible = True
        Me.colBCP_ACC_PERIOD_FR.VisibleIndex = 13
        Me.colBCP_ACC_PERIOD_FR.Width = 150
        '
        'colBCP_BASIS_PERIOD_SUB_TO
        '
        Me.colBCP_BASIS_PERIOD_SUB_TO.FieldName = "BCP_BASIS_PERIOD_SUB_TO"
        Me.colBCP_BASIS_PERIOD_SUB_TO.Name = "colBCP_BASIS_PERIOD_SUB_TO"
        '
        'colBCP_BASIS_PERIOD_FLW_TO
        '
        Me.colBCP_BASIS_PERIOD_FLW_TO.FieldName = "BCP_BASIS_PERIOD_FLW_TO"
        Me.colBCP_BASIS_PERIOD_FLW_TO.Name = "colBCP_BASIS_PERIOD_FLW_TO"
        '
        'colBCP_BASIS_PERIOD_FLW_FR
        '
        Me.colBCP_BASIS_PERIOD_FLW_FR.FieldName = "BCP_BASIS_PERIOD_FLW_FR"
        Me.colBCP_BASIS_PERIOD_FLW_FR.Name = "colBCP_BASIS_PERIOD_FLW_FR"
        '
        'colBCP_NEW_ACC_PERIOD_TO
        '
        Me.colBCP_NEW_ACC_PERIOD_TO.FieldName = "BCP_NEW_ACC_PERIOD_TO"
        Me.colBCP_NEW_ACC_PERIOD_TO.Name = "colBCP_NEW_ACC_PERIOD_TO"
        '
        'colBCP_NEW_ACC_PERIOD_FR
        '
        Me.colBCP_NEW_ACC_PERIOD_FR.FieldName = "BCP_NEW_ACC_PERIOD_FR"
        Me.colBCP_NEW_ACC_PERIOD_FR.Name = "colBCP_NEW_ACC_PERIOD_FR"
        '
        'colBCP_FROM_INSTALMENT
        '
        Me.colBCP_FROM_INSTALMENT.FieldName = "BCP_FROM_INSTALMENT"
        Me.colBCP_FROM_INSTALMENT.Name = "colBCP_FROM_INSTALMENT"
        '
        'colBCP_FR_MONTH
        '
        Me.colBCP_FR_MONTH.FieldName = "BCP_FR_MONTH"
        Me.colBCP_FR_MONTH.Name = "colBCP_FR_MONTH"
        '
        'colBCP_TOTAL_PAID
        '
        Me.colBCP_TOTAL_PAID.FieldName = "BCP_TOTAL_PAID"
        Me.colBCP_TOTAL_PAID.Name = "colBCP_TOTAL_PAID"
        '
        'colBCP_BASIS_PERIOD_SUB_FR
        '
        Me.colBCP_BASIS_PERIOD_SUB_FR.FieldName = "BCP_BASIS_PERIOD_SUB_FR"
        Me.colBCP_BASIS_PERIOD_SUB_FR.Name = "colBCP_BASIS_PERIOD_SUB_FR"
        '
        'colBCP_BAL_ESTIMATED_TAX
        '
        Me.colBCP_BAL_ESTIMATED_TAX.FieldName = "BCP_BAL_ESTIMATED_TAX"
        Me.colBCP_BAL_ESTIMATED_TAX.Name = "colBCP_BAL_ESTIMATED_TAX"
        '
        'colBCP_DATE
        '
        Me.colBCP_DATE.Caption = "Date"
        Me.colBCP_DATE.FieldName = "BCP_DATE"
        Me.colBCP_DATE.Name = "colBCP_DATE"
        Me.colBCP_DATE.Visible = True
        Me.colBCP_DATE.VisibleIndex = 11
        Me.colBCP_DATE.Width = 150
        '
        'colModifiedBy
        '
        Me.colModifiedBy.FieldName = "ModifiedBy"
        Me.colModifiedBy.Name = "colModifiedBy"
        Me.colModifiedBy.Visible = True
        Me.colModifiedBy.VisibleIndex = 20
        Me.colModifiedBy.Width = 150
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(406, 44)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl3.TabIndex = 15
        Me.LabelControl3.Text = "Month :"
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(449, 40)
        Me.txtMonth.MenuManager = Me.BarManager1
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Properties.Mask.EditMask = "n0"
        Me.txtMonth.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMonth.Size = New System.Drawing.Size(100, 20)
        Me.txtMonth.TabIndex = 14
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnAdd, Me.btnEdit, Me.btnDelete, Me.btnPrint, Me.btnImportExport})
        Me.BarManager1.MaxItemId = 7
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrint), New DevExpress.XtraBars.LinkPersistInfo(Me.btnImportExport)})
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
        'btnImportExport
        '
        Me.btnImportExport.Caption = "Import / Export"
        Me.btnImportExport.Id = 4
        Me.btnImportExport.ImageOptions.Image = CType(resources.GetObject("btnImportExport.ImageOptions.Image"), System.Drawing.Image)
        Me.btnImportExport.ImageOptions.LargeImage = CType(resources.GetObject("btnImportExport.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnImportExport.Name = "btnImportExport"
        Me.btnImportExport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1018, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 502)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1018, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 471)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1018, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 471)
        '
        'btnClear2
        '
        Me.btnClear2.ImageOptions.Image = CType(resources.GetObject("btnClear2.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClear2.Location = New System.Drawing.Point(681, 13)
        Me.btnClear2.Name = "btnClear2"
        Me.btnClear2.Size = New System.Drawing.Size(24, 23)
        Me.btnClear2.TabIndex = 13
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
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cboRefNo)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.txtMonth)
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
        Me.PanelControl1.Size = New System.Drawing.Size(1018, 100)
        Me.PanelControl1.TabIndex = 12
        '
        'cboRefNo
        '
        Me.cboRefNo.Location = New System.Drawing.Point(91, 14)
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
        Me.cboRefNo.TabIndex = 161
        '
        'TaxPayerFindBindingSource
        '
        Me.TaxPayerFindBindingSource.DataMember = "TaxPayerFind"
        Me.TaxPayerFindBindingSource.DataSource = Me.DsDefault
        '
        'DsDefault
        '
        Me.DsDefault.DataSetName = "dsDefault"
        Me.DsDefault.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.btnAllRecord.Location = New System.Drawing.Point(449, 66)
        Me.btnAllRecord.Name = "btnAllRecord"
        Me.btnAllRecord.Size = New System.Drawing.Size(110, 23)
        Me.btnAllRecord.TabIndex = 8
        Me.btnAllRecord.Text = "All Record"
        '
        'btnFind
        '
        Me.btnFind.ImageOptions.Image = CType(resources.GetObject("btnFind.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFind.Location = New System.Drawing.Point(565, 66)
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
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Reference No :"
        '
        'colBCP_CORRESPOND_STATE
        '
        Me.colBCP_CORRESPOND_STATE.Caption = "State"
        Me.colBCP_CORRESPOND_STATE.FieldName = "BCP_CORRESPOND_STATE"
        Me.colBCP_CORRESPOND_STATE.Name = "colBCP_CORRESPOND_STATE"
        Me.colBCP_CORRESPOND_STATE.Visible = True
        Me.colBCP_CORRESPOND_STATE.VisibleIndex = 10
        Me.colBCP_CORRESPOND_STATE.Width = 150
        '
        'colBCP_CORRESPOND_CITY
        '
        Me.colBCP_CORRESPOND_CITY.Caption = "City"
        Me.colBCP_CORRESPOND_CITY.FieldName = "BCP_CORRESPOND_CITY"
        Me.colBCP_CORRESPOND_CITY.Name = "colBCP_CORRESPOND_CITY"
        Me.colBCP_CORRESPOND_CITY.Visible = True
        Me.colBCP_CORRESPOND_CITY.VisibleIndex = 9
        Me.colBCP_CORRESPOND_CITY.Width = 150
        '
        'colBCP_CORRESPOND_POST
        '
        Me.colBCP_CORRESPOND_POST.Caption = "Postcode"
        Me.colBCP_CORRESPOND_POST.FieldName = "BCP_CORRESPOND_POST"
        Me.colBCP_CORRESPOND_POST.Name = "colBCP_CORRESPOND_POST"
        Me.colBCP_CORRESPOND_POST.Visible = True
        Me.colBCP_CORRESPOND_POST.VisibleIndex = 8
        Me.colBCP_CORRESPOND_POST.Width = 120
        '
        'colBCP_CORRESPOND_ADD3
        '
        Me.colBCP_CORRESPOND_ADD3.Caption = "Address 3"
        Me.colBCP_CORRESPOND_ADD3.FieldName = "BCP_CORRESPOND_ADD3"
        Me.colBCP_CORRESPOND_ADD3.Name = "colBCP_CORRESPOND_ADD3"
        Me.colBCP_CORRESPOND_ADD3.Visible = True
        Me.colBCP_CORRESPOND_ADD3.VisibleIndex = 7
        Me.colBCP_CORRESPOND_ADD3.Width = 300
        '
        'colBCP_CORRESPOND_ADD2
        '
        Me.colBCP_CORRESPOND_ADD2.Caption = "Address 2"
        Me.colBCP_CORRESPOND_ADD2.FieldName = "BCP_CORRESPOND_ADD2"
        Me.colBCP_CORRESPOND_ADD2.Name = "colBCP_CORRESPOND_ADD2"
        Me.colBCP_CORRESPOND_ADD2.Visible = True
        Me.colBCP_CORRESPOND_ADD2.VisibleIndex = 6
        Me.colBCP_CORRESPOND_ADD2.Width = 300
        '
        'colBCP_CORRESPOND_ADD1
        '
        Me.colBCP_CORRESPOND_ADD1.Caption = "Address 1"
        Me.colBCP_CORRESPOND_ADD1.FieldName = "BCP_CORRESPOND_ADD1"
        Me.colBCP_CORRESPOND_ADD1.Name = "colBCP_CORRESPOND_ADD1"
        Me.colBCP_CORRESPOND_ADD1.Visible = True
        Me.colBCP_CORRESPOND_ADD1.VisibleIndex = 5
        Me.colBCP_CORRESPOND_ADD1.Width = 300
        '
        'colBCP_CO_REGNO
        '
        Me.colBCP_CO_REGNO.Caption = "Registration No"
        Me.colBCP_CO_REGNO.FieldName = "BCP_CO_REGNO"
        Me.colBCP_CO_REGNO.Name = "colBCP_CO_REGNO"
        Me.colBCP_CO_REGNO.Visible = True
        Me.colBCP_CO_REGNO.VisibleIndex = 4
        Me.colBCP_CO_REGNO.Width = 200
        '
        'colBCP_CO_NAME
        '
        Me.colBCP_CO_NAME.Caption = "Name"
        Me.colBCP_CO_NAME.FieldName = "BCP_CO_NAME"
        Me.colBCP_CO_NAME.Name = "colBCP_CO_NAME"
        Me.colBCP_CO_NAME.Visible = True
        Me.colBCP_CO_NAME.VisibleIndex = 3
        Me.colBCP_CO_NAME.Width = 300
        '
        'colBCP_YA
        '
        Me.colBCP_YA.Caption = "YA"
        Me.colBCP_YA.FieldName = "BCP_YA"
        Me.colBCP_YA.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colBCP_YA.Name = "colBCP_YA"
        Me.colBCP_YA.Visible = True
        Me.colBCP_YA.VisibleIndex = 2
        Me.colBCP_YA.Width = 100
        '
        'colBCP_KEY
        '
        Me.colBCP_KEY.Caption = "No"
        Me.colBCP_KEY.FieldName = "BCP_KEY"
        Me.colBCP_KEY.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colBCP_KEY.Name = "colBCP_KEY"
        Me.colBCP_KEY.Visible = True
        Me.colBCP_KEY.VisibleIndex = 0
        Me.colBCP_KEY.Width = 80
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBCP_KEY, Me.colBCP_REF_NO, Me.colBCP_YA, Me.colBCP_CO_NAME, Me.colBCP_CO_REGNO, Me.colBCP_CORRESPOND_ADD1, Me.colBCP_CORRESPOND_ADD2, Me.colBCP_CORRESPOND_ADD3, Me.colBCP_CORRESPOND_POST, Me.colBCP_CORRESPOND_CITY, Me.colBCP_CORRESPOND_STATE, Me.colBCP_DATE, Me.colBCP_ESTIMATED_TAX, Me.colBCP_ACC_PERIOD_FR, Me.colBCP_ACC_PERIOD_TO, Me.colBCP_BASIS_PERIOD_FR, Me.colBCP_BASIS_PERIOD_TO, Me.colBCP_NEWCO_DATE, Me.colBCP_TO_MONTH, Me.colBCP_FIRST_INSTALMENT, Me.colBCP_LAST_INSTALMENT, Me.colBCP_NEWCO_BAS_FR, Me.colBCP_NEWCO_BAS_TO, Me.colBCP_NEWCO_BAS_SUB_FR, Me.colBCP_NEWCO_BAS_SUB_TO, Me.colBCP_CURR_CORR_ADD1, Me.colBCP_CURR_CORR_ADD2, Me.colBCP_CURR_CORR_ADD3, Me.colBCP_CURR_CORR_POST, Me.colBCP_CURR_CORR_CITY, Me.colBCP_CURR_CORR_STATE, Me.colBCP_REV_ESTIMATED_TAX, Me.colBCP_BAL_ESTIMATED_TAX, Me.colBCP_TOTAL_PAID, Me.colBCP_FR_MONTH, Me.colBCP_FROM_INSTALMENT, Me.colBCP_NEW_ACC_PERIOD_FR, Me.colBCP_NEW_ACC_PERIOD_TO, Me.colBCP_BASIS_PERIOD_FLW_FR, Me.colBCP_BASIS_PERIOD_FLW_TO, Me.colBCP_BASIS_PERIOD_SUB_FR, Me.colBCP_BASIS_PERIOD_SUB_TO, Me.colBCP_FORM, Me.colBCP_VERSION, Me.colBCP_ESTIMATED, Me.colBCP_INDICATE, Me.colBCP_CHKM, Me.colBCP_SME_PERIOD_FR, Me.colBCP_SME_PERIOD_TO, Me.colModifiedBy, Me.colModifiedDateTime})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        '
        'colBCP_REF_NO
        '
        Me.colBCP_REF_NO.Caption = "Reference No"
        Me.colBCP_REF_NO.FieldName = "BCP_REF_NO"
        Me.colBCP_REF_NO.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colBCP_REF_NO.Name = "colBCP_REF_NO"
        Me.colBCP_REF_NO.Visible = True
        Me.colBCP_REF_NO.VisibleIndex = 1
        Me.colBCP_REF_NO.Width = 120
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BORANGCP204BindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridControl1.Location = New System.Drawing.Point(0, 131)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1018, 371)
        Me.GridControl1.TabIndex = 13
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'BORANGCP204BindingSource
        '
        Me.BORANGCP204BindingSource.DataMember = "BORANG_CP204"
        Me.BORANGCP204BindingSource.DataSource = Me.DsCP204
        '
        'DsCP204
        '
        Me.DsCP204.DataSetName = "dsCP204"
        Me.DsCP204.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ucCP204
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "ucCP204"
        Me.Size = New System.Drawing.Size(1018, 502)
        CType(Me.txtMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BORANGCP204BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCP204, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents colBCP_CURR_CORR_STATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_CURR_CORR_POST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_CURR_CORR_ADD3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_CURR_CORR_ADD2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_CURR_CORR_ADD1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_NEWCO_BAS_SUB_TO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_NEWCO_BAS_SUB_FR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_NEWCO_BAS_TO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_NEWCO_BAS_FR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_LAST_INSTALMENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_FIRST_INSTALMENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_TO_MONTH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_NEWCO_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_BASIS_PERIOD_TO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_BASIS_PERIOD_FR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_ACC_PERIOD_TO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_CURR_CORR_CITY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_ESTIMATED_TAX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_REV_ESTIMATED_TAX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_SME_PERIOD_TO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_SME_PERIOD_FR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_CHKM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_INDICATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_ESTIMATED As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_VERSION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_FORM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_ACC_PERIOD_FR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_BASIS_PERIOD_SUB_TO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_BASIS_PERIOD_FLW_TO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_BASIS_PERIOD_FLW_FR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_NEW_ACC_PERIOD_TO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_NEW_ACC_PERIOD_FR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_FROM_INSTALMENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_FR_MONTH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_TOTAL_PAID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_BASIS_PERIOD_SUB_FR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_BAL_ESTIMATED_TAX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMonth As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnImportExport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClear2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRefNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboYA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnAllRecord As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents BORANGCP204BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsCP204 As EasyTemplate_Taxcom.dsCP204
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBCP_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_REF_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_YA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_CO_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_CO_REGNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_CORRESPOND_ADD1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_CORRESPOND_ADD2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_CORRESPOND_ADD3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_CORRESPOND_POST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_CORRESPOND_CITY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBCP_CORRESPOND_STATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboRefNo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents TaxPayerFindBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsDefault As EasyTemplate_Taxcom.dsDefault
    Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRefNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHandleBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployerNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyCode As DevExpress.XtraGrid.Columns.GridColumn

End Class
