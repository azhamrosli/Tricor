<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPNL_Import
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
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFileURL2 = New DevExpress.XtraEditors.TextEdit()
        Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.dgvExport = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLeftAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRightAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        Me.DsPNL2 = New EasyTemplate_Taxcom.dsPNL2()
        Me.ExportPNLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtRefNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.cboYA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.cboRefNo = New DevExpress.XtraEditors.LookUpEdit()
        Me.DsDefault = New EasyTemplate_Taxcom.dsDefault()
        Me.TaxPayerFindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cboMainSource = New DevExpress.XtraEditors.LookUpEdit()
        Me.DsPNL = New EasyTemplate_Taxcom.dsPNL()
        Me.BUSINESSSOURCEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.txtFileURL2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel2.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        CType(Me.dgvExport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPNL2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportPNLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMainSource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPNL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BUSINESSSOURCEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1, Me.DockPanel2})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top
        Me.DockPanel1.ID = New System.Guid("3dbfc6f7-c52e-4e4e-8f57-54670badd480")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.Options.ShowMaximizeButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 108)
        Me.DockPanel1.Size = New System.Drawing.Size(1099, 108)
        Me.DockPanel1.Text = "Tax Payer Information"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.cboMainSource)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl5)
        Me.DockPanel1_Container.Controls.Add(Me.SimpleButton1)
        Me.DockPanel1_Container.Controls.Add(Me.txtRefNo)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl2)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl11)
        Me.DockPanel1_Container.Controls.Add(Me.txtFileURL2)
        Me.DockPanel1_Container.Controls.Add(Me.cboYA)
        Me.DockPanel1_Container.Controls.Add(Me.cboRefNo)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl10)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(1091, 81)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(9, 6)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "File URL :"
        '
        'txtFileURL2
        '
        Me.txtFileURL2.Location = New System.Drawing.Point(60, 3)
        Me.txtFileURL2.Name = "txtFileURL2"
        Me.txtFileURL2.Properties.ReadOnly = True
        Me.txtFileURL2.Size = New System.Drawing.Size(991, 20)
        Me.txtFileURL2.TabIndex = 0
        '
        'DockPanel2
        '
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel2.ID = New System.Guid("94ff1069-46d7-41ac-a959-174c7385ab23")
        Me.DockPanel2.Location = New System.Drawing.Point(0, 108)
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.Options.ShowCloseButton = False
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(553, 200)
        Me.DockPanel2.Size = New System.Drawing.Size(553, 505)
        Me.DockPanel2.Text = "Import Data"
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.dgvExport)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(545, 478)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'dgvExport
        '
        Me.dgvExport.DataSource = Me.ExportPNLBindingSource
        Me.dgvExport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvExport.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvExport.Location = New System.Drawing.Point(0, 0)
        Me.dgvExport.MainView = Me.GridView1
        Me.dgvExport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvExport.Name = "dgvExport"
        Me.dgvExport.Size = New System.Drawing.Size(545, 478)
        Me.dgvExport.TabIndex = 62
        Me.dgvExport.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNo, Me.colNo2, Me.colType, Me.colDescription, Me.colLeftAmount, Me.colRightAmount})
        Me.GridView1.GridControl = Me.dgvExport
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'colNo
        '
        Me.colNo.Caption = "No"
        Me.colNo.FieldName = "No"
        Me.colNo.Name = "colNo"
        Me.colNo.Visible = True
        Me.colNo.VisibleIndex = 0
        '
        'colNo2
        '
        Me.colNo2.Caption = "Parent No"
        Me.colNo2.FieldName = "No2"
        Me.colNo2.Name = "colNo2"
        Me.colNo2.Visible = True
        Me.colNo2.VisibleIndex = 1
        '
        'colType
        '
        Me.colType.Caption = "Type"
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 2
        Me.colType.Width = 150
        '
        'colDescription
        '
        Me.colDescription.Caption = "Description"
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 3
        Me.colDescription.Width = 500
        '
        'colLeftAmount
        '
        Me.colLeftAmount.Caption = "Debit Amount"
        Me.colLeftAmount.FieldName = "LeftAmount"
        Me.colLeftAmount.Name = "colLeftAmount"
        Me.colLeftAmount.Visible = True
        Me.colLeftAmount.VisibleIndex = 4
        Me.colLeftAmount.Width = 150
        '
        'colRightAmount
        '
        Me.colRightAmount.Caption = "Creadit Amount"
        Me.colRightAmount.FieldName = "RightAmount"
        Me.colRightAmount.Name = "colRightAmount"
        Me.colRightAmount.Visible = True
        Me.colRightAmount.VisibleIndex = 5
        Me.colRightAmount.Width = 150
        '
        'DocumentManager1
        '
        Me.DocumentManager1.ContainerControl = Me
        Me.DocumentManager1.View = Me.TabbedView1
        Me.DocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.TabbedView1})
        '
        'TabbedView1
        '
        Me.TabbedView1.DocumentGroupProperties.CloseTabOnMiddleClick = DevExpress.XtraTabbedMdi.CloseTabOnMiddleClick.Never
        Me.TabbedView1.DocumentGroupProperties.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.TabbedView1.DocumentProperties.AllowClose = False
        Me.TabbedView1.DocumentProperties.AllowFloat = False
        Me.TabbedView1.DocumentProperties.AllowFloatOnDoubleClick = False
        Me.TabbedView1.FloatingDocumentContainer = DevExpress.XtraBars.Docking2010.Views.FloatingDocumentContainer.SingleDocument
        '
        'DsPNL2
        '
        Me.DsPNL2.DataSetName = "dsPNL2"
        Me.DsPNL2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExportPNLBindingSource
        '
        Me.ExportPNLBindingSource.DataMember = "ExportPNL"
        Me.ExportPNLBindingSource.DataSource = Me.DsPNL2
        '
        'txtRefNo
        '
        Me.txtRefNo.Location = New System.Drawing.Point(61, 55)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Properties.ReadOnly = True
        Me.txtRefNo.Size = New System.Drawing.Size(280, 20)
        Me.txtRefNo.TabIndex = 163
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(368, 32)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl11.TabIndex = 162
        Me.LabelControl11.Text = "YA :"
        '
        'cboYA
        '
        Me.cboYA.Location = New System.Drawing.Point(452, 29)
        Me.cboYA.Name = "cboYA"
        Me.cboYA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboYA.Properties.PopupSizeable = True
        Me.cboYA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboYA.Size = New System.Drawing.Size(280, 20)
        Me.cboYA.TabIndex = 160
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(8, 32)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl10.TabIndex = 161
        Me.LabelControl10.Text = "Ref No :"
        '
        'cboRefNo
        '
        Me.cboRefNo.Location = New System.Drawing.Point(60, 29)
        Me.cboRefNo.Name = "cboRefNo"
        Me.cboRefNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRefNo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RefNo", "Ref No", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Company Name", 500, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyNo", "Company No", 71, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployerNo", "Employer No", 70, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FileNo", "File No", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Country", "Country", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyCode", "Company Code", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboRefNo.Properties.DataSource = Me.TaxPayerFindBindingSource
        Me.cboRefNo.Properties.DisplayMember = "CompanyName"
        Me.cboRefNo.Properties.NullText = "Select"
        Me.cboRefNo.Properties.PopupFormMinSize = New System.Drawing.Size(600, 0)
        Me.cboRefNo.Properties.ValueMember = "RefNo"
        Me.cboRefNo.Size = New System.Drawing.Size(281, 20)
        Me.cboRefNo.TabIndex = 159
        '
        'DsDefault
        '
        Me.DsDefault.DataSetName = "dsDefault"
        Me.DsDefault.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TaxPayerFindBindingSource
        '
        Me.TaxPayerFindBindingSource.DataMember = "TaxPayerFind"
        Me.TaxPayerFindBindingSource.DataSource = Me.DsDefault
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(785, 32)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 164
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(368, 58)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl5.TabIndex = 162
        Me.LabelControl5.Text = "Source Code :"
        '
        'cboMainSource
        '
        Me.cboMainSource.Location = New System.Drawing.Point(451, 55)
        Me.cboMainSource.Name = "cboMainSource"
        Me.cboMainSource.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMainSource.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BC_SOURCEKEY", "BC_SOURCEKEY", 101, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BC_SOURCENO", "BC_SOURCENO", 85, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BC_CODE", "BC_CODE", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BC_TYPE", "BC_TYPE", 250, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RefNo", "Ref No", 43, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Company Name", 85, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyNo", "Company No", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployerNo", "Employer No", 100, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FileNo", "File No", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Country", "Country", 49, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyCode", "Company Code", 83, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboMainSource.Properties.DataSource = Me.BUSINESSSOURCEBindingSource
        Me.cboMainSource.Properties.DisplayMember = "BC_SOURCENO"
        Me.cboMainSource.Properties.NullText = "Select"
        Me.cboMainSource.Properties.PopupFormMinSize = New System.Drawing.Size(600, 0)
        Me.cboMainSource.Properties.ValueMember = "BC_SOURCENO"
        Me.cboMainSource.Size = New System.Drawing.Size(281, 20)
        Me.cboMainSource.TabIndex = 160
        '
        'DsPNL
        '
        Me.DsPNL.DataSetName = "dsPNL"
        Me.DsPNL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BUSINESSSOURCEBindingSource
        '
        Me.BUSINESSSOURCEBindingSource.DataMember = "BUSINESS_SOURCE"
        Me.BUSINESSSOURCEBindingSource.DataSource = Me.DsPNL
        '
        'frmPNL_Import
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 613)
        Me.Controls.Add(Me.DockPanel2)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "frmPNL_Import"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPNL_Import"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel1_Container.PerformLayout()
        CType(Me.txtFileURL2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel2.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        CType(Me.dgvExport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPNL2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportPNLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMainSource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPNL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BUSINESSSOURCEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOpenFile As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFileUrl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DocumentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
    Friend WithEvents TabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
    Friend WithEvents dgvExport As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLeftAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRightAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsPNL2 As EasyTemplate_Taxcom.dsPNL2
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFileURL2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ExportPNLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtRefNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboYA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboRefNo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TaxPayerFindBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsDefault As EasyTemplate_Taxcom.dsDefault
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboMainSource As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BUSINESSSOURCEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsPNL As EasyTemplate_Taxcom.dsPNL
End Class
