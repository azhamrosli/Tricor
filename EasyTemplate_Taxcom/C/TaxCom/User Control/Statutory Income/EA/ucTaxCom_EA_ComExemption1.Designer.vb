<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTaxCom_EA_ComExemption1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucTaxCom_EA_ComExemption1))
        Me.lblA = New DevExpress.XtraEditors.LabelControl()
        Me.txtSigValueTotal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSigValueImmediately = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSigValueCurrent = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSigPercent = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSigText1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSigExemption = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.btnUpdate = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtSigValueTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSigValueImmediately.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSigValueCurrent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSigPercent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSigText1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSigExemption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblA
        '
        Me.lblA.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.Appearance.Options.UseFont = True
        Me.lblA.Location = New System.Drawing.Point(19, 21)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(542, 16)
        Me.lblA.TabIndex = 23
        Me.lblA.Text = "A.  Computation for Exemption of Income on Value of Significant Increase in Expor" & _
    "ts"
        '
        'txtSigValueTotal
        '
        Me.txtSigValueTotal.EditValue = "0"
        Me.txtSigValueTotal.Location = New System.Drawing.Point(564, 129)
        Me.txtSigValueTotal.Name = "txtSigValueTotal"
        Me.txtSigValueTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSigValueTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSigValueTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSigValueTotal.Properties.ReadOnly = True
        Me.txtSigValueTotal.Size = New System.Drawing.Size(138, 20)
        Me.txtSigValueTotal.TabIndex = 36
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(44, 132)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(229, 13)
        Me.LabelControl3.TabIndex = 35
        Me.LabelControl3.Text = "   (c) Value of increased export [ A1(a) - A1(b) ]"
        '
        'txtSigValueImmediately
        '
        Me.txtSigValueImmediately.EditValue = "0"
        Me.txtSigValueImmediately.Location = New System.Drawing.Point(564, 103)
        Me.txtSigValueImmediately.Name = "txtSigValueImmediately"
        Me.txtSigValueImmediately.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSigValueImmediately.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSigValueImmediately.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSigValueImmediately.Size = New System.Drawing.Size(138, 20)
        Me.txtSigValueImmediately.TabIndex = 34
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(44, 106)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(294, 13)
        Me.LabelControl2.TabIndex = 33
        Me.LabelControl2.Text = "   (b) Value of export for basis period (immediately preceding)"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(72, 87)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl1.TabIndex = 32
        Me.LabelControl1.Text = "LESS :"
        '
        'txtSigValueCurrent
        '
        Me.txtSigValueCurrent.EditValue = "0"
        Me.txtSigValueCurrent.Location = New System.Drawing.Point(564, 56)
        Me.txtSigValueCurrent.Name = "txtSigValueCurrent"
        Me.txtSigValueCurrent.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSigValueCurrent.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSigValueCurrent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSigValueCurrent.Size = New System.Drawing.Size(138, 20)
        Me.txtSigValueCurrent.TabIndex = 31
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(44, 59)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(227, 13)
        Me.LabelControl8.TabIndex = 30
        Me.LabelControl8.Text = "1. (a) Value of export for basic period (current)"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(199, 187)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl9.TabIndex = 41
        Me.LabelControl9.Text = "A1(b)"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(199, 166)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl6.TabIndex = 39
        Me.LabelControl6.Text = "A1(c)"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl7.Appearance.Options.UseBackColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(184, 171)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl7.TabIndex = 40
        Me.LabelControl7.Text = "________"
        '
        'txtSigPercent
        '
        Me.txtSigPercent.EditValue = "0"
        Me.txtSigPercent.Location = New System.Drawing.Point(564, 172)
        Me.txtSigPercent.Name = "txtSigPercent"
        Me.txtSigPercent.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSigPercent.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSigPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSigPercent.Properties.ReadOnly = True
        Me.txtSigPercent.Size = New System.Drawing.Size(138, 20)
        Me.txtSigPercent.TabIndex = 38
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(44, 175)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(244, 13)
        Me.LabelControl5.TabIndex = 37
        Me.LabelControl5.Text = "2   Percentage value added (                  x 100%   )"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(44, 221)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(277, 13)
        Me.LabelControl4.TabIndex = 42
        Me.LabelControl4.Text = "2   Exemption on Statutory Income (if A2 = 50% or more)"
        '
        'txtSigText1
        '
        Me.txtSigText1.EditValue = "0"
        Me.txtSigText1.Location = New System.Drawing.Point(72, 252)
        Me.txtSigText1.Name = "txtSigText1"
        Me.txtSigText1.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSigText1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSigText1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSigText1.Properties.ReadOnly = True
        Me.txtSigText1.Size = New System.Drawing.Size(138, 20)
        Me.txtSigText1.TabIndex = 43
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(216, 255)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl10.TabIndex = 44
        Me.LabelControl10.Text = "X 30%"
        '
        'txtSigExemption
        '
        Me.txtSigExemption.EditValue = "0"
        Me.txtSigExemption.Location = New System.Drawing.Point(564, 252)
        Me.txtSigExemption.Name = "txtSigExemption"
        Me.txtSigExemption.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSigExemption.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSigExemption.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSigExemption.Properties.ReadOnly = True
        Me.txtSigExemption.Size = New System.Drawing.Size(138, 20)
        Me.txtSigExemption.TabIndex = 45
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(550, 255)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(8, 13)
        Me.LabelControl11.TabIndex = 46
        Me.LabelControl11.Text = "="
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(85, 278)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(108, 13)
        Me.LabelControl12.TabIndex = 47
        Me.LabelControl12.Text = "[ Amount from A1 (c) ]"
        '
        'btnUpdate
        '
        Me.btnUpdate.ImageOptions.Image = CType(resources.GetObject("btnUpdate.ImageOptions.Image"), System.Drawing.Image)
        Me.btnUpdate.Location = New System.Drawing.Point(564, 305)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(138, 31)
        Me.btnUpdate.TabIndex = 79
        Me.btnUpdate.Text = "Update"
        '
        'ucTaxCom_EA_ComExemption1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.txtSigExemption)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txtSigText1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txtSigPercent)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtSigValueTotal)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtSigValueImmediately)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtSigValueCurrent)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.lblA)
        Me.Name = "ucTaxCom_EA_ComExemption1"
        Me.Size = New System.Drawing.Size(738, 350)
        CType(Me.txtSigValueTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSigValueImmediately.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSigValueCurrent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSigPercent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSigText1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSigExemption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblA As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSigValueTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSigValueImmediately As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSigValueCurrent As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSigPercent As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSigText1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSigExemption As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnUpdate As DevExpress.XtraEditors.SimpleButton

End Class
