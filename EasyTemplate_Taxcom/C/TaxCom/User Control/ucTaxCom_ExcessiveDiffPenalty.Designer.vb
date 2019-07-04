<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTaxCom_ExcessiveDiffPenalty
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
        Me.txtInTaxPay2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.txtEsTaxPay = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAllowDiff = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtExDiff = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPenOnExDiff = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtInTaxPay3 = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtInTaxPay2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEsTaxPay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAllowDiff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExDiff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPenOnExDiff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInTaxPay3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtInTaxPay2
        '
        Me.txtInTaxPay2.EditValue = "0"
        Me.txtInTaxPay2.Location = New System.Drawing.Point(577, 46)
        Me.txtInTaxPay2.Name = "txtInTaxPay2"
        Me.txtInTaxPay2.Properties.Appearance.Options.UseTextOptions = True
        Me.txtInTaxPay2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtInTaxPay2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtInTaxPay2.Properties.ReadOnly = True
        Me.txtInTaxPay2.Size = New System.Drawing.Size(112, 20)
        Me.txtInTaxPay2.TabIndex = 47
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(20, 49)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(97, 13)
        Me.LabelControl1.TabIndex = 46
        Me.LabelControl1.Text = "Income Tax Payable"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(20, 24)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Not applicable"
        Me.CheckEdit1.Size = New System.Drawing.Size(158, 19)
        Me.CheckEdit1.TabIndex = 48
        '
        'txtEsTaxPay
        '
        Me.txtEsTaxPay.EditValue = "0"
        Me.txtEsTaxPay.Location = New System.Drawing.Point(577, 72)
        Me.txtEsTaxPay.Name = "txtEsTaxPay"
        Me.txtEsTaxPay.Properties.Appearance.Options.UseTextOptions = True
        Me.txtEsTaxPay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtEsTaxPay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtEsTaxPay.Properties.ReadOnly = True
        Me.txtEsTaxPay.Size = New System.Drawing.Size(112, 20)
        Me.txtEsTaxPay.TabIndex = 50
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(20, 75)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(137, 13)
        Me.LabelControl2.TabIndex = 49
        Me.LabelControl2.Text = "Less: Estimated Tax Payable"
        '
        'txtAllowDiff
        '
        Me.txtAllowDiff.EditValue = "0"
        Me.txtAllowDiff.Location = New System.Drawing.Point(577, 124)
        Me.txtAllowDiff.Name = "txtAllowDiff"
        Me.txtAllowDiff.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAllowDiff.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAllowDiff.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAllowDiff.Properties.ReadOnly = True
        Me.txtAllowDiff.Size = New System.Drawing.Size(112, 20)
        Me.txtAllowDiff.TabIndex = 52
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(20, 127)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(235, 13)
        Me.LabelControl3.TabIndex = 51
        Me.LabelControl3.Text = "Less: Allowable Difference (30% of Tax Payable)"
        '
        'txtExDiff
        '
        Me.txtExDiff.EditValue = "0"
        Me.txtExDiff.Location = New System.Drawing.Point(577, 150)
        Me.txtExDiff.Name = "txtExDiff"
        Me.txtExDiff.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExDiff.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExDiff.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtExDiff.Properties.ReadOnly = True
        Me.txtExDiff.Size = New System.Drawing.Size(112, 20)
        Me.txtExDiff.TabIndex = 54
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(20, 153)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl4.TabIndex = 53
        Me.LabelControl4.Text = "Excessive Difference"
        '
        'txtPenOnExDiff
        '
        Me.txtPenOnExDiff.EditValue = "0"
        Me.txtPenOnExDiff.Location = New System.Drawing.Point(577, 176)
        Me.txtPenOnExDiff.Name = "txtPenOnExDiff"
        Me.txtPenOnExDiff.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPenOnExDiff.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPenOnExDiff.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPenOnExDiff.Properties.ReadOnly = True
        Me.txtPenOnExDiff.Size = New System.Drawing.Size(112, 20)
        Me.txtPenOnExDiff.TabIndex = 56
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(20, 179)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(180, 13)
        Me.LabelControl5.TabIndex = 55
        Me.LabelControl5.Text = "10% Penalty on Excessive Difference"
        '
        'txtInTaxPay3
        '
        Me.txtInTaxPay3.EditValue = "0"
        Me.txtInTaxPay3.Location = New System.Drawing.Point(577, 98)
        Me.txtInTaxPay3.Name = "txtInTaxPay3"
        Me.txtInTaxPay3.Properties.Appearance.Options.UseTextOptions = True
        Me.txtInTaxPay3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtInTaxPay3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtInTaxPay3.Properties.ReadOnly = True
        Me.txtInTaxPay3.Size = New System.Drawing.Size(112, 20)
        Me.txtInTaxPay3.TabIndex = 57
        '
        'ucTaxCom_ExcessiveDiffPenalty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtInTaxPay3)
        Me.Controls.Add(Me.txtPenOnExDiff)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtExDiff)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtAllowDiff)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtEsTaxPay)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.txtInTaxPay2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "ucTaxCom_ExcessiveDiffPenalty"
        Me.Size = New System.Drawing.Size(702, 243)
        CType(Me.txtInTaxPay2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEsTaxPay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAllowDiff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExDiff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPenOnExDiff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInTaxPay3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInTaxPay2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtEsTaxPay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAllowDiff As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtExDiff As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPenOnExDiff As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInTaxPay3 As DevExpress.XtraEditors.TextEdit

End Class
