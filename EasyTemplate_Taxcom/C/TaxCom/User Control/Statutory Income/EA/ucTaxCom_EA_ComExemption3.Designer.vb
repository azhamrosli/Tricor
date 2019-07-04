<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTaxCom_EA_ComExemption3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucTaxCom_EA_ComExemption3))
        Me.lblA = New DevExpress.XtraEditors.LabelControl()
        Me.txtSerValueTotal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSerValueImmediately = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSerValueCurrent = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSerText1 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.btnUpdate = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtSerValueTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerValueImmediately.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerValueCurrent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerText1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblA
        '
        Me.lblA.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.Appearance.Options.UseFont = True
        Me.lblA.Appearance.Options.UseTextOptions = True
        Me.lblA.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lblA.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblA.Location = New System.Drawing.Point(18, 15)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(696, 45)
        Me.lblA.TabIndex = 24
        Me.lblA.Text = "C. Computation for Exemption of Income on Value of Increased Exports by a Company" & _
    " given an Export Excellence Award for Merchandise, Services or Brands"
        '
        'txtSerValueTotal
        '
        Me.txtSerValueTotal.EditValue = "0"
        Me.txtSerValueTotal.Location = New System.Drawing.Point(552, 149)
        Me.txtSerValueTotal.Name = "txtSerValueTotal"
        Me.txtSerValueTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSerValueTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSerValueTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSerValueTotal.Properties.ReadOnly = True
        Me.txtSerValueTotal.Size = New System.Drawing.Size(138, 20)
        Me.txtSerValueTotal.TabIndex = 43
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(32, 152)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(229, 13)
        Me.LabelControl3.TabIndex = 42
        Me.LabelControl3.Text = "   (c) Value of increased export [ C1(a) - C1(b) ]"
        '
        'txtSerValueImmediately
        '
        Me.txtSerValueImmediately.EditValue = "0"
        Me.txtSerValueImmediately.Location = New System.Drawing.Point(552, 123)
        Me.txtSerValueImmediately.Name = "txtSerValueImmediately"
        Me.txtSerValueImmediately.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSerValueImmediately.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSerValueImmediately.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSerValueImmediately.Size = New System.Drawing.Size(138, 20)
        Me.txtSerValueImmediately.TabIndex = 41
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(32, 126)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(294, 13)
        Me.LabelControl2.TabIndex = 40
        Me.LabelControl2.Text = "   (b) Value of export for basis period (immediately preceding)"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(60, 107)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl1.TabIndex = 39
        Me.LabelControl1.Text = "LESS :"
        '
        'txtSerValueCurrent
        '
        Me.txtSerValueCurrent.EditValue = "0"
        Me.txtSerValueCurrent.Location = New System.Drawing.Point(552, 76)
        Me.txtSerValueCurrent.Name = "txtSerValueCurrent"
        Me.txtSerValueCurrent.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSerValueCurrent.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSerValueCurrent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSerValueCurrent.Size = New System.Drawing.Size(138, 20)
        Me.txtSerValueCurrent.TabIndex = 38
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(32, 79)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(227, 13)
        Me.LabelControl8.TabIndex = 37
        Me.LabelControl8.Text = "1. (a) Value of export for basic period (current)"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(32, 185)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(163, 13)
        Me.LabelControl4.TabIndex = 44
        Me.LabelControl4.Text = "2. Exemption of Statutory Income"
        '
        'txtSerText1
        '
        Me.txtSerText1.EditValue = "0"
        Me.txtSerText1.Location = New System.Drawing.Point(57, 214)
        Me.txtSerText1.Name = "txtSerText1"
        Me.txtSerText1.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSerText1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSerText1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSerText1.Properties.ReadOnly = True
        Me.txtSerText1.Size = New System.Drawing.Size(138, 20)
        Me.txtSerText1.TabIndex = 45
        '
        'TextEdit2
        '
        Me.TextEdit2.EditValue = "0"
        Me.TextEdit2.Location = New System.Drawing.Point(552, 214)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(138, 20)
        Me.TextEdit2.TabIndex = 46
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(201, 217)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl5.TabIndex = 47
        Me.LabelControl5.Text = "X 100%"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(538, 217)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(8, 13)
        Me.LabelControl6.TabIndex = 48
        Me.LabelControl6.Text = "="
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(72, 240)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(99, 13)
        Me.LabelControl7.TabIndex = 49
        Me.LabelControl7.Text = "[Amount from C1(c)]"
        '
        'btnUpdate
        '
        Me.btnUpdate.ImageOptions.Image = CType(resources.GetObject("btnUpdate.ImageOptions.Image"), System.Drawing.Image)
        Me.btnUpdate.Location = New System.Drawing.Point(552, 265)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(138, 31)
        Me.btnUpdate.TabIndex = 80
        Me.btnUpdate.Text = "Update"
        '
        'ucTaxCom_EA_ComExemption3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.TextEdit2)
        Me.Controls.Add(Me.txtSerText1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtSerValueTotal)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtSerValueImmediately)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtSerValueCurrent)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.lblA)
        Me.Name = "ucTaxCom_EA_ComExemption3"
        Me.Size = New System.Drawing.Size(737, 313)
        CType(Me.txtSerValueTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerValueImmediately.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerValueCurrent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerText1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblA As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSerValueTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSerValueImmediately As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSerValueCurrent As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSerText1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnUpdate As DevExpress.XtraEditors.SimpleButton

End Class
