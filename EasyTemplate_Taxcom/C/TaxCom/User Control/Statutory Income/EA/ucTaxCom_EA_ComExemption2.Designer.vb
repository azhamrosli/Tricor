<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTaxCom_EA_ComExemption2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucTaxCom_EA_ComExemption2))
        Me.lblA = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMarketTotal = New DevExpress.XtraEditors.TextEdit()
        Me.txtMarketStatutory = New DevExpress.XtraEditors.TextEdit()
        Me.txtMarketValueCurrent = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btnUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.txtMarketTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMarketStatutory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMarketValueCurrent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblA
        '
        Me.lblA.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.Appearance.Options.UseFont = True
        Me.lblA.Location = New System.Drawing.Point(17, 21)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(493, 16)
        Me.lblA.TabIndex = 24
        Me.lblA.Text = "B. Computation for Exemption of Income on Value of Exports for New Market"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(37, 56)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(304, 13)
        Me.LabelControl8.TabIndex = 31
        Me.LabelControl8.Text = "1. Value of exports for new market in the basic period (current)"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(37, 271)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(213, 13)
        Me.LabelControl1.TabIndex = 32
        Me.LabelControl1.Text = "2. Exemption on Statutory Income absorbed"
        '
        'txtMarketTotal
        '
        Me.txtMarketTotal.EditValue = "0"
        Me.txtMarketTotal.Location = New System.Drawing.Point(63, 302)
        Me.txtMarketTotal.Name = "txtMarketTotal"
        Me.txtMarketTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMarketTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMarketTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMarketTotal.Properties.ReadOnly = True
        Me.txtMarketTotal.Size = New System.Drawing.Size(138, 20)
        Me.txtMarketTotal.TabIndex = 39
        '
        'txtMarketStatutory
        '
        Me.txtMarketStatutory.EditValue = "0"
        Me.txtMarketStatutory.Location = New System.Drawing.Point(473, 302)
        Me.txtMarketStatutory.Name = "txtMarketStatutory"
        Me.txtMarketStatutory.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMarketStatutory.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMarketStatutory.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMarketStatutory.Properties.ReadOnly = True
        Me.txtMarketStatutory.Size = New System.Drawing.Size(138, 20)
        Me.txtMarketStatutory.TabIndex = 40
        '
        'txtMarketValueCurrent
        '
        Me.txtMarketValueCurrent.EditValue = "0"
        Me.txtMarketValueCurrent.Location = New System.Drawing.Point(473, 53)
        Me.txtMarketValueCurrent.Name = "txtMarketValueCurrent"
        Me.txtMarketValueCurrent.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMarketValueCurrent.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtMarketValueCurrent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMarketValueCurrent.Properties.ReadOnly = True
        Me.txtMarketValueCurrent.Size = New System.Drawing.Size(138, 20)
        Me.txtMarketValueCurrent.TabIndex = 41
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(207, 305)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl2.TabIndex = 42
        Me.LabelControl2.Text = "X 50%"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(86, 328)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl3.TabIndex = 43
        Me.LabelControl3.Text = "(Total from B1)"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(459, 305)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(8, 13)
        Me.LabelControl4.TabIndex = 44
        Me.LabelControl4.Text = "="
        '
        'btnUpdate
        '
        Me.btnUpdate.ImageOptions.Image = CType(resources.GetObject("btnUpdate.ImageOptions.Image"), System.Drawing.Image)
        Me.btnUpdate.Location = New System.Drawing.Point(473, 353)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(138, 31)
        Me.btnUpdate.TabIndex = 80
        Me.btnUpdate.Text = "Update"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(37, 79)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(574, 186)
        Me.GridControl1.TabIndex = 81
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'ucTaxCom_EA_ComExemption2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtMarketValueCurrent)
        Me.Controls.Add(Me.txtMarketStatutory)
        Me.Controls.Add(Me.txtMarketTotal)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.lblA)
        Me.Name = "ucTaxCom_EA_ComExemption2"
        Me.Size = New System.Drawing.Size(635, 403)
        CType(Me.txtMarketTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMarketStatutory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMarketValueCurrent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblA As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMarketTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMarketStatutory As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMarketValueCurrent As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView

End Class
