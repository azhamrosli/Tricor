<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPNL_Import_Select
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPNL_Import_Select))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnImport = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOpenFile = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFileUrl = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnNext = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.PNLImportTableListSelectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPNL2 = New EasyTemplate_Taxcom.dsPNL2()
        Me.PNLImportTableListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnMoveLeft2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnMoveLeft1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnMoveRight2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnMoveRight1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSheetName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSheetName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtFileUrl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PNLImportTableListSelectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPNL2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PNLImportTableListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.btnImport)
        Me.PanelControl1.Controls.Add(Me.btnOpenFile)
        Me.PanelControl1.Controls.Add(Me.txtFileUrl)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1117, 75)
        Me.PanelControl1.TabIndex = 0
        '
        'btnImport
        '
        Me.btnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImport.Location = New System.Drawing.Point(938, 35)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(122, 32)
        Me.btnImport.TabIndex = 2
        Me.btnImport.Text = "Import"
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenFile.Image = CType(resources.GetObject("btnOpenFile.Image"), System.Drawing.Image)
        Me.btnOpenFile.Location = New System.Drawing.Point(1066, 7)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(34, 23)
        Me.btnOpenFile.TabIndex = 2
        '
        'txtFileUrl
        '
        Me.txtFileUrl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileUrl.Location = New System.Drawing.Point(82, 9)
        Me.txtFileUrl.Name = "txtFileUrl"
        Me.txtFileUrl.Size = New System.Drawing.Size(978, 20)
        Me.txtFileUrl.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Select File :"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnNext)
        Me.PanelControl2.Controls.Add(Me.btnCancel)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 478)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1117, 67)
        Me.PanelControl2.TabIndex = 1
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.Location = New System.Drawing.Point(850, 6)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(122, 32)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(978, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(122, 32)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        '
        'PNLImportTableListSelectBindingSource
        '
        Me.PNLImportTableListSelectBindingSource.DataMember = "PNLImport_TableList_Select"
        Me.PNLImportTableListSelectBindingSource.DataSource = Me.DsPNL2
        '
        'DsPNL2
        '
        Me.DsPNL2.DataSetName = "dsPNL2"
        Me.DsPNL2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PNLImportTableListBindingSource
        '
        Me.PNLImportTableListBindingSource.DataMember = "PNLImport_TableList"
        Me.PNLImportTableListBindingSource.DataSource = Me.DsPNL2
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnMoveLeft2
        '
        Me.btnMoveLeft2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMoveLeft2.Location = New System.Drawing.Point(532, 302)
        Me.btnMoveLeft2.Name = "btnMoveLeft2"
        Me.btnMoveLeft2.Size = New System.Drawing.Size(53, 32)
        Me.btnMoveLeft2.TabIndex = 15
        Me.btnMoveLeft2.Text = "<<"
        '
        'btnMoveLeft1
        '
        Me.btnMoveLeft1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMoveLeft1.Location = New System.Drawing.Point(531, 264)
        Me.btnMoveLeft1.Name = "btnMoveLeft1"
        Me.btnMoveLeft1.Size = New System.Drawing.Size(53, 32)
        Me.btnMoveLeft1.TabIndex = 14
        Me.btnMoveLeft1.Text = "<"
        '
        'btnMoveRight2
        '
        Me.btnMoveRight2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMoveRight2.Location = New System.Drawing.Point(531, 226)
        Me.btnMoveRight2.Name = "btnMoveRight2"
        Me.btnMoveRight2.Size = New System.Drawing.Size(53, 32)
        Me.btnMoveRight2.TabIndex = 13
        Me.btnMoveRight2.Text = ">>"
        '
        'btnMoveRight1
        '
        Me.btnMoveRight1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMoveRight1.Location = New System.Drawing.Point(530, 188)
        Me.btnMoveRight1.Name = "btnMoveRight1"
        Me.btnMoveRight1.Size = New System.Drawing.Size(53, 32)
        Me.btnMoveRight1.TabIndex = 10
        Me.btnMoveRight1.Text = ">"
        '
        'GridControl2
        '
        Me.GridControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GridControl2.DataSource = Me.PNLImportTableListSelectBindingSource
        Me.GridControl2.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridControl2.Location = New System.Drawing.Point(589, 90)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(518, 365)
        Me.GridControl2.TabIndex = 12
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNo1, Me.colSheetName1})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        '
        'colNo1
        '
        Me.colNo1.FieldName = "No"
        Me.colNo1.Name = "colNo1"
        Me.colNo1.Visible = True
        Me.colNo1.VisibleIndex = 0
        '
        'colSheetName1
        '
        Me.colSheetName1.FieldName = "SheetName"
        Me.colSheetName1.Name = "colSheetName1"
        Me.colSheetName1.Visible = True
        Me.colSheetName1.VisibleIndex = 1
        Me.colSheetName1.Width = 500
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.PNLImportTableListBindingSource
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridControl1.Location = New System.Drawing.Point(10, 90)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(515, 365)
        Me.GridControl1.TabIndex = 11
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNo, Me.colSheetName})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        '
        'colNo
        '
        Me.colNo.FieldName = "No"
        Me.colNo.Name = "colNo"
        Me.colNo.Visible = True
        Me.colNo.VisibleIndex = 0
        '
        'colSheetName
        '
        Me.colSheetName.FieldName = "SheetName"
        Me.colSheetName.Name = "colSheetName"
        Me.colSheetName.Visible = True
        Me.colSheetName.VisibleIndex = 1
        Me.colSheetName.Width = 500
        '
        'PanelControl3
        '
        Me.PanelControl3.Location = New System.Drawing.Point(92, 19)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(8, 8)
        Me.PanelControl3.TabIndex = 3
        '
        'frmPNL_Import_Select
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 545)
        Me.Controls.Add(Me.btnMoveLeft2)
        Me.Controls.Add(Me.btnMoveLeft1)
        Me.Controls.Add(Me.btnMoveRight2)
        Me.Controls.Add(Me.btnMoveRight1)
        Me.Controls.Add(Me.GridControl2)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.MinimumSize = New System.Drawing.Size(1133, 584)
        Me.Name = "frmPNL_Import_Select"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profit and Loss Import"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtFileUrl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PNLImportTableListSelectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPNL2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PNLImportTableListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnOpenFile As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFileUrl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnNext As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PNLImportTableListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsPNL2 As EasyTemplate_Taxcom.dsPNL2
    Friend WithEvents PNLImportTableListSelectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnMoveLeft2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMoveLeft1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMoveRight2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMoveRight1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSheetName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSheetName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
End Class
