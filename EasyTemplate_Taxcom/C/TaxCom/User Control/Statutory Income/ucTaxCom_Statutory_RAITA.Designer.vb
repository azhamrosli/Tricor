<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTaxCom_Statutory_RAITA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucTaxCom_Statutory_RAITA))
        Me.lblA = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.lblRAITA = New DevExpress.XtraEditors.LabelControl()
        Me.txtRate1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtQlfCapExp = New DevExpress.XtraEditors.TextEdit()
        Me.txtBalancingAllowance = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotal1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btnLoad = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotal2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRate2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtStatutoryIncome = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRestriction = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSCH7A = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSCH7A_StatutoryIncome = New DevExpress.XtraEditors.TextEdit()
        Me.btnUpdate = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtRate1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQlfCapExp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBalancingAllowance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRate2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatutoryIncome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRestriction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSCH7A.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSCH7A_StatutoryIncome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblA
        '
        Me.lblA.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.Appearance.Options.UseFont = True
        Me.lblA.Location = New System.Drawing.Point(15, 13)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(90, 16)
        Me.lblA.TabIndex = 12
        Me.lblA.Text = "A    RA or ITA"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(40, 49)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl8.TabIndex = 14
        Me.LabelControl8.Text = "1. Balance B/F"
        '
        'lblRAITA
        '
        Me.lblRAITA.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRAITA.Appearance.Options.UseFont = True
        Me.lblRAITA.Location = New System.Drawing.Point(40, 68)
        Me.lblRAITA.Name = "lblRAITA"
        Me.lblRAITA.Size = New System.Drawing.Size(64, 16)
        Me.lblRAITA.TabIndex = 15
        Me.lblRAITA.Text = "RA or ITA"
        '
        'txtRate1
        '
        Me.txtRate1.EditValue = "0"
        Me.txtRate1.Location = New System.Drawing.Point(40, 90)
        Me.txtRate1.Name = "txtRate1"
        Me.txtRate1.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRate1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtRate1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRate1.Size = New System.Drawing.Size(138, 20)
        Me.txtRate1.TabIndex = 16
        '
        'txtQlfCapExp
        '
        Me.txtQlfCapExp.EditValue = "0"
        Me.txtQlfCapExp.Location = New System.Drawing.Point(231, 90)
        Me.txtQlfCapExp.Name = "txtQlfCapExp"
        Me.txtQlfCapExp.Properties.Appearance.Options.UseTextOptions = True
        Me.txtQlfCapExp.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtQlfCapExp.Properties.DisplayFormat.FormatString = "n0"
        Me.txtQlfCapExp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtQlfCapExp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtQlfCapExp.Size = New System.Drawing.Size(138, 20)
        Me.txtQlfCapExp.TabIndex = 17
        '
        'txtBalancingAllowance
        '
        Me.txtBalancingAllowance.EditValue = "0"
        Me.txtBalancingAllowance.Location = New System.Drawing.Point(457, 46)
        Me.txtBalancingAllowance.Name = "txtBalancingAllowance"
        Me.txtBalancingAllowance.Properties.Appearance.Options.UseTextOptions = True
        Me.txtBalancingAllowance.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtBalancingAllowance.Properties.DisplayFormat.FormatString = "n0"
        Me.txtBalancingAllowance.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBalancingAllowance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtBalancingAllowance.Properties.ReadOnly = True
        Me.txtBalancingAllowance.Size = New System.Drawing.Size(138, 20)
        Me.txtBalancingAllowance.TabIndex = 18
        '
        'txtTotal1
        '
        Me.txtTotal1.EditValue = "0"
        Me.txtTotal1.Location = New System.Drawing.Point(457, 90)
        Me.txtTotal1.Name = "txtTotal1"
        Me.txtTotal1.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotal1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal1.Properties.DisplayFormat.FormatString = "n0"
        Me.txtTotal1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotal1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotal1.Properties.ReadOnly = True
        Me.txtTotal1.Size = New System.Drawing.Size(138, 20)
        Me.txtTotal1.TabIndex = 19
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(443, 93)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(8, 13)
        Me.LabelControl2.TabIndex = 20
        Me.LabelControl2.Text = "="
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(184, 93)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl3.TabIndex = 21
        Me.LabelControl3.Text = "%        X"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(231, 117)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(145, 13)
        Me.LabelControl4.TabIndex = 22
        Me.LabelControl4.Text = "Qualifying Capital Expenditure"
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(375, 88)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(62, 23)
        Me.btnLoad.TabIndex = 59
        Me.btnLoad.Text = "Load"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(40, 148)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl5.TabIndex = 60
        Me.LabelControl5.Text = "3. Total"
        '
        'txtTotal2
        '
        Me.txtTotal2.EditValue = "0"
        Me.txtTotal2.Location = New System.Drawing.Point(457, 145)
        Me.txtTotal2.Name = "txtTotal2"
        Me.txtTotal2.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotal2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal2.Properties.DisplayFormat.FormatString = "n0"
        Me.txtTotal2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotal2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotal2.Properties.ReadOnly = True
        Me.txtTotal2.Size = New System.Drawing.Size(138, 20)
        Me.txtTotal2.TabIndex = 61
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(15, 182)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(232, 16)
        Me.LabelControl7.TabIndex = 62
        Me.LabelControl7.Text = "B    Restriction to Statutory Income"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(40, 214)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl9.TabIndex = 63
        Me.LabelControl9.Text = "Restricted Limit"
        '
        'txtRate2
        '
        Me.txtRate2.EditValue = "0"
        Me.txtRate2.Location = New System.Drawing.Point(130, 211)
        Me.txtRate2.Name = "txtRate2"
        Me.txtRate2.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRate2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtRate2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRate2.Size = New System.Drawing.Size(76, 20)
        Me.txtRate2.TabIndex = 64
        '
        'txtStatutoryIncome
        '
        Me.txtStatutoryIncome.EditValue = "0"
        Me.txtStatutoryIncome.Location = New System.Drawing.Point(259, 211)
        Me.txtStatutoryIncome.Name = "txtStatutoryIncome"
        Me.txtStatutoryIncome.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStatutoryIncome.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtStatutoryIncome.Properties.DisplayFormat.FormatString = "n0"
        Me.txtStatutoryIncome.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtStatutoryIncome.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtStatutoryIncome.Properties.ReadOnly = True
        Me.txtStatutoryIncome.Size = New System.Drawing.Size(138, 20)
        Me.txtStatutoryIncome.TabIndex = 65
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(212, 214)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl10.TabIndex = 66
        Me.LabelControl10.Text = "%        X"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(443, 214)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(8, 13)
        Me.LabelControl11.TabIndex = 67
        Me.LabelControl11.Text = "="
        '
        'txtRestriction
        '
        Me.txtRestriction.EditValue = "0"
        Me.txtRestriction.Location = New System.Drawing.Point(457, 211)
        Me.txtRestriction.Name = "txtRestriction"
        Me.txtRestriction.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRestriction.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtRestriction.Properties.DisplayFormat.FormatString = "n0"
        Me.txtRestriction.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtRestriction.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRestriction.Properties.ReadOnly = True
        Me.txtRestriction.Size = New System.Drawing.Size(138, 20)
        Me.txtRestriction.TabIndex = 68
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(259, 237)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(136, 13)
        Me.LabelControl12.TabIndex = 69
        Me.LabelControl12.Text = "(Statutory Business Income)"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(15, 273)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(177, 16)
        Me.LabelControl13.TabIndex = 70
        Me.LabelControl13.Text = "C    Utilised During the Year"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(40, 295)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(231, 13)
        Me.LabelControl14.TabIndex = 71
        Me.LabelControl14.Text = "Compare Amount in A3 and B whichever is lower"
        '
        'txtSCH7A
        '
        Me.txtSCH7A.EditValue = "0"
        Me.txtSCH7A.Location = New System.Drawing.Point(457, 292)
        Me.txtSCH7A.Name = "txtSCH7A"
        Me.txtSCH7A.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSCH7A.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSCH7A.Properties.DisplayFormat.FormatString = "n0"
        Me.txtSCH7A.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSCH7A.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSCH7A.Properties.ReadOnly = True
        Me.txtSCH7A.Size = New System.Drawing.Size(138, 20)
        Me.txtSCH7A.TabIndex = 72
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Location = New System.Drawing.Point(15, 330)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(236, 16)
        Me.LabelControl15.TabIndex = 73
        Me.LabelControl15.Text = "B    Statutory Income Subject to Tax"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(40, 352)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(231, 13)
        Me.LabelControl16.TabIndex = 74
        Me.LabelControl16.Text = "Compare Amount in A3 and B whichever is lower"
        '
        'txtSCH7A_StatutoryIncome
        '
        Me.txtSCH7A_StatutoryIncome.EditValue = "0"
        Me.txtSCH7A_StatutoryIncome.Location = New System.Drawing.Point(457, 349)
        Me.txtSCH7A_StatutoryIncome.Name = "txtSCH7A_StatutoryIncome"
        Me.txtSCH7A_StatutoryIncome.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSCH7A_StatutoryIncome.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSCH7A_StatutoryIncome.Properties.DisplayFormat.FormatString = "n0"
        Me.txtSCH7A_StatutoryIncome.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSCH7A_StatutoryIncome.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSCH7A_StatutoryIncome.Properties.ReadOnly = True
        Me.txtSCH7A_StatutoryIncome.Size = New System.Drawing.Size(138, 20)
        Me.txtSCH7A_StatutoryIncome.TabIndex = 75
        '
        'btnUpdate
        '
        Me.btnUpdate.ImageOptions.Image = CType(resources.GetObject("btnUpdate.ImageOptions.Image"), System.Drawing.Image)
        Me.btnUpdate.Location = New System.Drawing.Point(457, 399)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(138, 31)
        Me.btnUpdate.TabIndex = 76
        Me.btnUpdate.Text = "Update"
        '
        'ucTaxCom_Statutory_RAITA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtSCH7A_StatutoryIncome)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.txtSCH7A)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.txtRestriction)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txtStatutoryIncome)
        Me.Controls.Add(Me.txtRate2)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txtTotal2)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtTotal1)
        Me.Controls.Add(Me.txtBalancingAllowance)
        Me.Controls.Add(Me.txtQlfCapExp)
        Me.Controls.Add(Me.txtRate1)
        Me.Controls.Add(Me.lblRAITA)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.lblA)
        Me.Name = "ucTaxCom_Statutory_RAITA"
        Me.Size = New System.Drawing.Size(617, 448)
        CType(Me.txtRate1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQlfCapExp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBalancingAllowance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRate2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatutoryIncome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRestriction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSCH7A.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSCH7A_StatutoryIncome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblA As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRAITA As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRate1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtQlfCapExp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBalancingAllowance As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotal1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnLoad As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotal2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRate2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStatutoryIncome As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRestriction As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSCH7A As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSCH7A_StatutoryIncome As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnUpdate As DevExpress.XtraEditors.SimpleButton

End Class
