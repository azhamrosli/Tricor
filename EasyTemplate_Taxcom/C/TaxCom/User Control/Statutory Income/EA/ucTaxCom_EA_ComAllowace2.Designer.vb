<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTaxCom_EA_ComAllowace2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucTaxCom_EA_ComAllowace2))
        Me.txtAgrValueCurrent = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.lblA = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAgrValueImmediately = New DevExpress.XtraEditors.TextEdit()
        Me.txtAgrValueTotal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAgrCurrentAllowance = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btnUpdate = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtAgrValueCurrent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAgrValueImmediately.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAgrValueTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAgrCurrentAllowance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAgrValueCurrent
        '
        Me.txtAgrValueCurrent.EditValue = "0"
        Me.txtAgrValueCurrent.Location = New System.Drawing.Point(576, 52)
        Me.txtAgrValueCurrent.Name = "txtAgrValueCurrent"
        Me.txtAgrValueCurrent.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAgrValueCurrent.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAgrValueCurrent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAgrValueCurrent.Size = New System.Drawing.Size(138, 20)
        Me.txtAgrValueCurrent.TabIndex = 27
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(56, 55)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(227, 13)
        Me.LabelControl8.TabIndex = 26
        Me.LabelControl8.Text = "1. (a) Value of export for basis period (current)"
        '
        'lblA
        '
        Me.lblA.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.Appearance.Options.UseFont = True
        Me.lblA.Location = New System.Drawing.Point(22, 21)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(575, 16)
        Me.lblA.TabIndex = 25
        Me.lblA.Text = "B    Computation of Allowance for Increased Exports by a company Engage in Agricu" & _
    "lture"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(87, 85)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl1.TabIndex = 28
        Me.LabelControl1.Text = "LESS :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(66, 114)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(297, 13)
        Me.LabelControl2.TabIndex = 29
        Me.LabelControl2.Text = "    (b) Value of export for basis period (immediately preceding)"
        '
        'txtAgrValueImmediately
        '
        Me.txtAgrValueImmediately.EditValue = "0"
        Me.txtAgrValueImmediately.Location = New System.Drawing.Point(576, 111)
        Me.txtAgrValueImmediately.Name = "txtAgrValueImmediately"
        Me.txtAgrValueImmediately.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAgrValueImmediately.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAgrValueImmediately.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAgrValueImmediately.Size = New System.Drawing.Size(138, 20)
        Me.txtAgrValueImmediately.TabIndex = 30
        '
        'txtAgrValueTotal
        '
        Me.txtAgrValueTotal.EditValue = "0"
        Me.txtAgrValueTotal.Location = New System.Drawing.Point(576, 137)
        Me.txtAgrValueTotal.Name = "txtAgrValueTotal"
        Me.txtAgrValueTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAgrValueTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAgrValueTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAgrValueTotal.Properties.ReadOnly = True
        Me.txtAgrValueTotal.Size = New System.Drawing.Size(138, 20)
        Me.txtAgrValueTotal.TabIndex = 32
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(66, 140)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(224, 13)
        Me.LabelControl3.TabIndex = 31
        Me.LabelControl3.Text = "    (c) Value of increased export [B1(a) - B1(b)]"
        '
        'txtAgrCurrentAllowance
        '
        Me.txtAgrCurrentAllowance.EditValue = "0"
        Me.txtAgrCurrentAllowance.Location = New System.Drawing.Point(576, 176)
        Me.txtAgrCurrentAllowance.Name = "txtAgrCurrentAllowance"
        Me.txtAgrCurrentAllowance.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAgrCurrentAllowance.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAgrCurrentAllowance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAgrCurrentAllowance.Properties.ReadOnly = True
        Me.txtAgrCurrentAllowance.Size = New System.Drawing.Size(138, 20)
        Me.txtAgrCurrentAllowance.TabIndex = 34
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(56, 179)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(322, 13)
        Me.LabelControl4.TabIndex = 33
        Me.LabelControl4.Text = "2. (a) Current year Allowance for Increased Exports [B1(c) x 10%]"
        '
        'btnUpdate
        '
        Me.btnUpdate.ImageOptions.Image = CType(resources.GetObject("btnUpdate.ImageOptions.Image"), System.Drawing.Image)
        Me.btnUpdate.Location = New System.Drawing.Point(576, 216)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(138, 31)
        Me.btnUpdate.TabIndex = 79
        Me.btnUpdate.Text = "Update"
        '
        'ucTaxCom_EA_ComAllowace2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtAgrCurrentAllowance)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtAgrValueTotal)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtAgrValueImmediately)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtAgrValueCurrent)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.lblA)
        Me.Name = "ucTaxCom_EA_ComAllowace2"
        Me.Size = New System.Drawing.Size(742, 269)
        CType(Me.txtAgrValueCurrent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAgrValueImmediately.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAgrValueTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAgrCurrentAllowance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAgrValueCurrent As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblA As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAgrValueImmediately As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAgrValueTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAgrCurrentAllowance As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnUpdate As DevExpress.XtraEditors.SimpleButton

End Class
