<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmErrorLog
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
        Me.grdErrorLog = New DevExpress.XtraGrid.GridControl()
        Me.ContMenu_ErrorLog = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExportToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DtErrorLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDefault = New EasyTemplate_Taxcom.dsDefault()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colErrorDateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colErrorCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colErrorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colErrorMessage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.grdErrorLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContMenu_ErrorLog.SuspendLayout()
        CType(Me.DtErrorLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdErrorLog
        '
        Me.grdErrorLog.ContextMenuStrip = Me.ContMenu_ErrorLog
        Me.grdErrorLog.DataSource = Me.DtErrorLogBindingSource
        Me.grdErrorLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdErrorLog.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grdErrorLog.Location = New System.Drawing.Point(0, 0)
        Me.grdErrorLog.MainView = Me.GridView1
        Me.grdErrorLog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grdErrorLog.Name = "grdErrorLog"
        Me.grdErrorLog.Size = New System.Drawing.Size(775, 377)
        Me.grdErrorLog.TabIndex = 1
        Me.grdErrorLog.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContMenu_ErrorLog
        '
        Me.ContMenu_ErrorLog.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContMenu_ErrorLog.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToExcelToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ClearAllToolStripMenuItem})
        Me.ContMenu_ErrorLog.Name = "ContMenu_ErrorLog"
        Me.ContMenu_ErrorLog.Size = New System.Drawing.Size(153, 70)
        '
        'ExportToExcelToolStripMenuItem
        '
        Me.ExportToExcelToolStripMenuItem.Name = "ExportToExcelToolStripMenuItem"
        Me.ExportToExcelToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExportToExcelToolStripMenuItem.Text = "Export To Excel"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearAllToolStripMenuItem.Text = "Clear All"
        '
        'DtErrorLogBindingSource
        '
        Me.DtErrorLogBindingSource.DataMember = "dtErrorLog"
        Me.DtErrorLogBindingSource.DataSource = Me.DsDefault
        '
        'DsDefault
        '
        Me.DsDefault.DataSetName = "dsDefault"
        Me.DsDefault.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNo, Me.colErrorDateTime, Me.colErrorCode, Me.colErrorName, Me.colErrorMessage})
        Me.GridView1.GridControl = Me.grdErrorLog
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
        '
        'colNo
        '
        Me.colNo.Caption = "No"
        Me.colNo.FieldName = "No"
        Me.colNo.Name = "colNo"
        Me.colNo.Visible = True
        Me.colNo.VisibleIndex = 0
        Me.colNo.Width = 80
        '
        'colErrorDateTime
        '
        Me.colErrorDateTime.Caption = "Date Time"
        Me.colErrorDateTime.FieldName = "ErrorDateTime"
        Me.colErrorDateTime.Name = "colErrorDateTime"
        Me.colErrorDateTime.Visible = True
        Me.colErrorDateTime.VisibleIndex = 1
        Me.colErrorDateTime.Width = 179
        '
        'colErrorCode
        '
        Me.colErrorCode.Caption = "Code"
        Me.colErrorCode.FieldName = "ErrorCode"
        Me.colErrorCode.Name = "colErrorCode"
        Me.colErrorCode.Visible = True
        Me.colErrorCode.VisibleIndex = 2
        Me.colErrorCode.Width = 179
        '
        'colErrorName
        '
        Me.colErrorName.Caption = "Name"
        Me.colErrorName.FieldName = "ErrorName"
        Me.colErrorName.Name = "colErrorName"
        Me.colErrorName.Visible = True
        Me.colErrorName.VisibleIndex = 3
        Me.colErrorName.Width = 179
        '
        'colErrorMessage
        '
        Me.colErrorMessage.Caption = "Message"
        Me.colErrorMessage.FieldName = "ErrorMessage"
        Me.colErrorMessage.Name = "colErrorMessage"
        Me.colErrorMessage.Visible = True
        Me.colErrorMessage.VisibleIndex = 4
        Me.colErrorMessage.Width = 300
        '
        'frmErrorLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 377)
        Me.Controls.Add(Me.grdErrorLog)
        Me.Name = "frmErrorLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ErrorLog"
        CType(Me.grdErrorLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContMenu_ErrorLog.ResumeLayout(False)
        CType(Me.DtErrorLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDefault, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdErrorLog As DevExpress.XtraGrid.GridControl
    Friend WithEvents DtErrorLogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsDefault As EasyTemplate_Taxcom.dsDefault
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colErrorDateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colErrorCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colErrorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colErrorMessage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContMenu_ErrorLog As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExportToExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
End Class
