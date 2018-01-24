<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPNL_InterestResPurS33_Monthly
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPNL_InterestResPurS33_Monthly))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.INTERESTRESTRICMONTLYREPORTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPNL = New EasyTemplate_Taxcom.dsPNL()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INTERESTRESTRICMONTLYREPORTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPNL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.INTERESTRESTRICMONTLYREPORTBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit3})
        Me.GridControl1.Size = New System.Drawing.Size(877, 476)
        Me.GridControl1.TabIndex = 19
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'INTERESTRESTRICMONTLYREPORTBindingSource
        '
        Me.INTERESTRESTRICMONTLYREPORTBindingSource.DataMember = "INTEREST_RESTRIC_MONTLY_REPORT"
        Me.INTERESTRESTRICMONTLYREPORTBindingSource.DataSource = Me.DsPNL
        '
        'DsPNL
        '
        Me.DsPNL.DataSetName = "dsPNL"
        Me.DsPNL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridView1.OptionsPrint.PrintHorzLines = False
        Me.GridView1.OptionsPrint.PrintVertLines = False
        Me.GridView1.OptionsPrint.RtfPageHeader = resources.GetString("GridView1.OptionsPrint.RtfPageHeader")
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatString = "n2"
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit3.Mask.EditMask = "n2"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'frmPNL_InterestResPurS33_Monthly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 476)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmPNL_InterestResPurS33_Monthly"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Interest expense restricted under subsection 33(2)"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INTERESTRESTRICMONTLYREPORTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPNL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents INTERESTRESTRICMONTLYREPORTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsPNL As EasyTemplate_Taxcom.dsPNL
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
