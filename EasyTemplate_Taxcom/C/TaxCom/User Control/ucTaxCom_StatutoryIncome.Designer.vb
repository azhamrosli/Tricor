<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTaxCom_StatutoryIncome
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
        Me.components = New System.ComponentModel.Container()
        Me.btnWithDrawal = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEA = New DevExpress.XtraEditors.SimpleButton()
        Me.btnITA = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRA = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNetStat = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.txtWithdrawal = New DevExpress.XtraEditors.TextEdit()
        Me.chkExemption = New DevExpress.XtraEditors.CheckEdit()
        Me.txtPioneer = New DevExpress.XtraEditors.TextEdit()
        Me.txtPio = New DevExpress.XtraEditors.TextEdit()
        Me.cboPioneer = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEA = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.txtInvestAllow = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRA = New DevExpress.XtraEditors.TextEdit()
        Me.txtStatBsIn = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtABIBalCharge = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCapitalAllow = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtBalCharge = New DevExpress.XtraEditors.TextEdit()
        Me.txtAdjustedBsIn = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAdjustedInLoss = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAdjustBsExp = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAdjustBsIn = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotBsIn = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSource = New DevExpress.XtraEditors.TextEdit()
        Me.txtSourceNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.btnStatutory_Partnership = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAggregate = New DevExpress.XtraEditors.TextEdit()
        Me.txtBsLoss = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.txtStatPartnership = New DevExpress.XtraEditors.TextEdit()
        Me.txtAllStatIn = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.STATUTORYINCOMEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTaxcomputation = New EasyTemplate_Taxcom.dsTaxcomputation()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTC_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_BUSINESS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBC_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_AI_TOT_BS_IN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_AI_TOT_ADJ_BS_IN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_AI_TOT_ADJ_BS_EXP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_AI_ADJ_IN_LOSS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_ADJ_BS_IN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_BC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_ADJ_BS_IN_BC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_CA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_STAT_BS_IN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_INVEST_ALLOW = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_NET_STAT_IN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_RA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_CA_BA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_CA_NA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_PIONEERDESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_PIONEER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_RA_RATE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_RA_QUALIFYINGCAPITALEXP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_RA_QUALIFYINGCAPITALEXP_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_RA_BALANCINGALLOWANCE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_RA_TOTAL1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_RA_RESTRICTRATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_RA_RESTRICTAMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_ITA_RATE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_ITA_QUALIFYINGCAPITALEXP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_ITA_QUALIFYINGCAPITALEXP_AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_ITA_BALANCINGALLOWANCE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_ITA_TOTAL1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_ITA_RESTRICTRATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_ITA_RESTRICTAMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_WITHRAITA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CHK_EXEMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        CType(Me.txtNetStat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWithdrawal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkExemption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPioneer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPioneer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvestAllow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatBsIn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtABIBalCharge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCapitalAllow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBalCharge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdjustedBsIn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdjustedInLoss.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdjustBsExp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdjustBsIn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotBsIn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSourceNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.txtAggregate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBsLoss.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatPartnership.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAllStatIn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STATUTORYINCOMEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTaxcomputation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnWithDrawal
        '
        Me.btnWithDrawal.Location = New System.Drawing.Point(313, 421)
        Me.btnWithDrawal.Name = "btnWithDrawal"
        Me.btnWithDrawal.Size = New System.Drawing.Size(30, 23)
        Me.btnWithDrawal.TabIndex = 111
        Me.btnWithDrawal.Text = "Add"
        '
        'btnEA
        '
        Me.btnEA.Location = New System.Drawing.Point(313, 347)
        Me.btnEA.Name = "btnEA"
        Me.btnEA.Size = New System.Drawing.Size(30, 23)
        Me.btnEA.TabIndex = 110
        Me.btnEA.Text = "EA"
        '
        'btnITA
        '
        Me.btnITA.Location = New System.Drawing.Point(313, 321)
        Me.btnITA.Name = "btnITA"
        Me.btnITA.Size = New System.Drawing.Size(30, 23)
        Me.btnITA.TabIndex = 109
        Me.btnITA.Text = "ITA"
        '
        'btnRA
        '
        Me.btnRA.Location = New System.Drawing.Point(313, 295)
        Me.btnRA.Name = "btnRA"
        Me.btnRA.Size = New System.Drawing.Size(30, 23)
        Me.btnRA.TabIndex = 108
        Me.btnRA.Text = "RA"
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl23.Appearance.Options.UseFont = True
        Me.LabelControl23.Location = New System.Drawing.Point(12, 452)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(123, 13)
        Me.LabelControl23.TabIndex = 107
        Me.LabelControl23.Text = "Net Statutory Income"
        '
        'txtNetStat
        '
        Me.txtNetStat.EditValue = "0"
        Me.txtNetStat.Location = New System.Drawing.Point(349, 449)
        Me.txtNetStat.Name = "txtNetStat"
        Me.txtNetStat.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNetStat.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNetStat.Properties.DisplayFormat.FormatString = "n0"
        Me.txtNetStat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNetStat.Properties.Mask.EditMask = "n0"
        Me.txtNetStat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNetStat.Properties.ReadOnly = True
        Me.txtNetStat.Size = New System.Drawing.Size(116, 20)
        Me.txtNetStat.TabIndex = 106
        Me.txtNetStat.ToolTip = "TC_SI_NET_STAT_IN"
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(12, 426)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(134, 13)
        Me.LabelControl22.TabIndex = 105
        Me.LabelControl22.Text = "Add : Withdrawal of RA/ITA"
        '
        'txtWithdrawal
        '
        Me.txtWithdrawal.EditValue = "0"
        Me.txtWithdrawal.Location = New System.Drawing.Point(349, 423)
        Me.txtWithdrawal.Name = "txtWithdrawal"
        Me.txtWithdrawal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtWithdrawal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtWithdrawal.Properties.DisplayFormat.FormatString = "n0"
        Me.txtWithdrawal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtWithdrawal.Properties.Mask.EditMask = "n0"
        Me.txtWithdrawal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtWithdrawal.Size = New System.Drawing.Size(116, 20)
        Me.txtWithdrawal.TabIndex = 104
        Me.txtWithdrawal.ToolTip = "TC_WITHRAITA"
        '
        'chkExemption
        '
        Me.chkExemption.Location = New System.Drawing.Point(324, 397)
        Me.chkExemption.Name = "chkExemption"
        Me.chkExemption.Properties.Caption = ""
        Me.chkExemption.Size = New System.Drawing.Size(19, 19)
        Me.chkExemption.TabIndex = 103
        Me.chkExemption.ToolTip = "TC_CHK_EXEMP"
        '
        'txtPioneer
        '
        Me.txtPioneer.EditValue = "0"
        Me.txtPioneer.Location = New System.Drawing.Point(349, 397)
        Me.txtPioneer.Name = "txtPioneer"
        Me.txtPioneer.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPioneer.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPioneer.Properties.DisplayFormat.FormatString = "n0"
        Me.txtPioneer.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPioneer.Properties.Mask.EditMask = "n0"
        Me.txtPioneer.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPioneer.Properties.ReadOnly = True
        Me.txtPioneer.Size = New System.Drawing.Size(116, 20)
        Me.txtPioneer.TabIndex = 102
        Me.txtPioneer.ToolTip = "TC_PIONEER"
        '
        'txtPio
        '
        Me.txtPio.EditValue = "0"
        Me.txtPio.Location = New System.Drawing.Point(225, 397)
        Me.txtPio.Name = "txtPio"
        Me.txtPio.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPio.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPio.Properties.Mask.EditMask = "n0"
        Me.txtPio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPio.Size = New System.Drawing.Size(57, 20)
        Me.txtPio.TabIndex = 101
        Me.txtPio.ToolTip = "TC_PIO"
        '
        'cboPioneer
        '
        Me.cboPioneer.Location = New System.Drawing.Point(41, 397)
        Me.cboPioneer.Name = "cboPioneer"
        Me.cboPioneer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPioneer.Size = New System.Drawing.Size(178, 20)
        Me.cboPioneer.TabIndex = 100
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(41, 378)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl21.TabIndex = 99
        Me.LabelControl21.Text = "Other Exemption"
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(41, 352)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(120, 13)
        Me.LabelControl20.TabIndex = 98
        Me.LabelControl20.Text = "Export Allowance Utilised"
        '
        'txtEA
        '
        Me.txtEA.EditValue = "0"
        Me.txtEA.Location = New System.Drawing.Point(349, 349)
        Me.txtEA.Name = "txtEA"
        Me.txtEA.Properties.Appearance.Options.UseTextOptions = True
        Me.txtEA.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtEA.Properties.DisplayFormat.FormatString = "n0"
        Me.txtEA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtEA.Properties.Mask.EditMask = "n0"
        Me.txtEA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtEA.Size = New System.Drawing.Size(116, 20)
        Me.txtEA.TabIndex = 97
        Me.txtEA.ToolTip = "TC_RA_QUALIFYINGCAPITALEXP_AMOUNT"
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(41, 326)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(164, 13)
        Me.LabelControl19.TabIndex = 96
        Me.LabelControl19.Text = "Investment Tax Allowance Utilised"
        '
        'txtInvestAllow
        '
        Me.txtInvestAllow.EditValue = "0"
        Me.txtInvestAllow.Location = New System.Drawing.Point(349, 323)
        Me.txtInvestAllow.Name = "txtInvestAllow"
        Me.txtInvestAllow.Properties.Appearance.Options.UseTextOptions = True
        Me.txtInvestAllow.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtInvestAllow.Properties.DisplayFormat.FormatString = "n0"
        Me.txtInvestAllow.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInvestAllow.Properties.Mask.EditMask = "n0"
        Me.txtInvestAllow.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtInvestAllow.Size = New System.Drawing.Size(116, 20)
        Me.txtInvestAllow.TabIndex = 95
        Me.txtInvestAllow.ToolTip = "TC_SI_INVEST_ALLOW"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.Location = New System.Drawing.Point(12, 274)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(153, 13)
        Me.LabelControl17.TabIndex = 94
        Me.LabelControl17.Text = "Statutory Business Income"
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(12, 300)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(185, 13)
        Me.LabelControl18.TabIndex = 93
        Me.LabelControl18.Text = "Less : Reinvestment Allowance Utilised"
        '
        'txtRA
        '
        Me.txtRA.EditValue = "0"
        Me.txtRA.Location = New System.Drawing.Point(349, 297)
        Me.txtRA.Name = "txtRA"
        Me.txtRA.Properties.Appearance.Options.UseTextOptions = True
        Me.txtRA.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtRA.Properties.DisplayFormat.FormatString = "n0"
        Me.txtRA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtRA.Properties.Mask.EditMask = "n0"
        Me.txtRA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtRA.Size = New System.Drawing.Size(116, 20)
        Me.txtRA.TabIndex = 92
        Me.txtRA.ToolTip = "TC_SI_RA"
        '
        'txtStatBsIn
        '
        Me.txtStatBsIn.EditValue = "0"
        Me.txtStatBsIn.Location = New System.Drawing.Point(349, 271)
        Me.txtStatBsIn.Name = "txtStatBsIn"
        Me.txtStatBsIn.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStatBsIn.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtStatBsIn.Properties.DisplayFormat.FormatString = "n0"
        Me.txtStatBsIn.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtStatBsIn.Properties.Mask.EditMask = "n0"
        Me.txtStatBsIn.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtStatBsIn.Properties.ReadOnly = True
        Me.txtStatBsIn.Size = New System.Drawing.Size(116, 20)
        Me.txtStatBsIn.TabIndex = 91
        Me.txtStatBsIn.ToolTip = "TC_SI_STAT_BS_IN"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(12, 248)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(120, 13)
        Me.LabelControl15.TabIndex = 90
        Me.LabelControl15.Text = "Less : Capital Allowances"
        '
        'txtABIBalCharge
        '
        Me.txtABIBalCharge.EditValue = "0"
        Me.txtABIBalCharge.Location = New System.Drawing.Point(349, 219)
        Me.txtABIBalCharge.Name = "txtABIBalCharge"
        Me.txtABIBalCharge.Properties.Appearance.Options.UseTextOptions = True
        Me.txtABIBalCharge.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtABIBalCharge.Properties.DisplayFormat.FormatString = "n0"
        Me.txtABIBalCharge.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtABIBalCharge.Properties.Mask.EditMask = "n0"
        Me.txtABIBalCharge.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtABIBalCharge.Properties.ReadOnly = True
        Me.txtABIBalCharge.Size = New System.Drawing.Size(116, 20)
        Me.txtABIBalCharge.TabIndex = 89
        Me.txtABIBalCharge.ToolTip = "TC_SI_ADJ_BS_IN_BC"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Location = New System.Drawing.Point(12, 222)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl16.TabIndex = 88
        Me.LabelControl16.Text = "Total"
        '
        'txtCapitalAllow
        '
        Me.txtCapitalAllow.EditValue = "0"
        Me.txtCapitalAllow.Location = New System.Drawing.Point(349, 245)
        Me.txtCapitalAllow.Name = "txtCapitalAllow"
        Me.txtCapitalAllow.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCapitalAllow.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCapitalAllow.Properties.DisplayFormat.FormatString = "n0"
        Me.txtCapitalAllow.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCapitalAllow.Properties.Mask.EditMask = "n0"
        Me.txtCapitalAllow.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCapitalAllow.Properties.ReadOnly = True
        Me.txtCapitalAllow.Size = New System.Drawing.Size(116, 20)
        Me.txtCapitalAllow.TabIndex = 87
        Me.txtCapitalAllow.ToolTip = "TC_SI_CA"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(12, 196)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(112, 13)
        Me.LabelControl14.TabIndex = 86
        Me.LabelControl14.Text = "Add : Balancing Charge"
        '
        'txtBalCharge
        '
        Me.txtBalCharge.EditValue = "0"
        Me.txtBalCharge.Location = New System.Drawing.Point(349, 193)
        Me.txtBalCharge.Name = "txtBalCharge"
        Me.txtBalCharge.Properties.Appearance.Options.UseTextOptions = True
        Me.txtBalCharge.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtBalCharge.Properties.DisplayFormat.FormatString = "n0"
        Me.txtBalCharge.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBalCharge.Properties.Mask.EditMask = "n0"
        Me.txtBalCharge.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtBalCharge.Size = New System.Drawing.Size(116, 20)
        Me.txtBalCharge.TabIndex = 85
        Me.txtBalCharge.ToolTip = "TC_SI_BC"
        '
        'txtAdjustedBsIn
        '
        Me.txtAdjustedBsIn.EditValue = "0"
        Me.txtAdjustedBsIn.Location = New System.Drawing.Point(349, 167)
        Me.txtAdjustedBsIn.Name = "txtAdjustedBsIn"
        Me.txtAdjustedBsIn.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAdjustedBsIn.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAdjustedBsIn.Properties.DisplayFormat.FormatString = "n0"
        Me.txtAdjustedBsIn.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAdjustedBsIn.Properties.Mask.EditMask = "n0"
        Me.txtAdjustedBsIn.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAdjustedBsIn.Properties.ReadOnly = True
        Me.txtAdjustedBsIn.Size = New System.Drawing.Size(116, 20)
        Me.txtAdjustedBsIn.TabIndex = 84
        Me.txtAdjustedBsIn.ToolTip = "TC_SI_ADJ_BS_IN"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(12, 170)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(149, 13)
        Me.LabelControl13.TabIndex = 83
        Me.LabelControl13.Text = "Adjusted Business Income"
        '
        'txtAdjustedInLoss
        '
        Me.txtAdjustedInLoss.EditValue = "0"
        Me.txtAdjustedInLoss.Location = New System.Drawing.Point(349, 141)
        Me.txtAdjustedInLoss.Name = "txtAdjustedInLoss"
        Me.txtAdjustedInLoss.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAdjustedInLoss.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAdjustedInLoss.Properties.DisplayFormat.FormatString = "n0"
        Me.txtAdjustedInLoss.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAdjustedInLoss.Properties.Mask.EditMask = "n0"
        Me.txtAdjustedInLoss.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAdjustedInLoss.Properties.ReadOnly = True
        Me.txtAdjustedInLoss.Size = New System.Drawing.Size(116, 20)
        Me.txtAdjustedInLoss.TabIndex = 82
        Me.txtAdjustedInLoss.ToolTip = "TC_AI_ADJ_IN_LOSS"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(12, 144)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(134, 13)
        Me.LabelControl12.TabIndex = 81
        Me.LabelControl12.Text = "Adjusted Income / Loss"
        '
        'txtAdjustBsExp
        '
        Me.txtAdjustBsExp.EditValue = "0"
        Me.txtAdjustBsExp.Location = New System.Drawing.Point(349, 115)
        Me.txtAdjustBsExp.Name = "txtAdjustBsExp"
        Me.txtAdjustBsExp.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAdjustBsExp.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAdjustBsExp.Properties.DisplayFormat.FormatString = "n0"
        Me.txtAdjustBsExp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAdjustBsExp.Properties.Mask.EditMask = "n0"
        Me.txtAdjustBsExp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAdjustBsExp.Properties.ReadOnly = True
        Me.txtAdjustBsExp.Size = New System.Drawing.Size(116, 20)
        Me.txtAdjustBsExp.TabIndex = 80
        Me.txtAdjustBsExp.ToolTip = "TC_AI_TOT_ADJ_BS_EXP"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(12, 118)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(193, 13)
        Me.LabelControl11.TabIndex = 79
        Me.LabelControl11.Text = "Adjusted for Business Expenditure"
        '
        'txtAdjustBsIn
        '
        Me.txtAdjustBsIn.EditValue = "0"
        Me.txtAdjustBsIn.Location = New System.Drawing.Point(349, 89)
        Me.txtAdjustBsIn.Name = "txtAdjustBsIn"
        Me.txtAdjustBsIn.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAdjustBsIn.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAdjustBsIn.Properties.DisplayFormat.FormatString = "n0"
        Me.txtAdjustBsIn.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAdjustBsIn.Properties.Mask.EditMask = "n0"
        Me.txtAdjustBsIn.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAdjustBsIn.Properties.ReadOnly = True
        Me.txtAdjustBsIn.Size = New System.Drawing.Size(116, 20)
        Me.txtAdjustBsIn.TabIndex = 78
        Me.txtAdjustBsIn.ToolTip = "TC_AI_TOT_ADJ_BS_IN"
        '
        'txtTotBsIn
        '
        Me.txtTotBsIn.EditValue = "0"
        Me.txtTotBsIn.Location = New System.Drawing.Point(349, 63)
        Me.txtTotBsIn.Name = "txtTotBsIn"
        Me.txtTotBsIn.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotBsIn.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotBsIn.Properties.DisplayFormat.FormatString = "n0"
        Me.txtTotBsIn.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotBsIn.Properties.Mask.EditMask = "n0"
        Me.txtTotBsIn.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotBsIn.Properties.ReadOnly = True
        Me.txtTotBsIn.Size = New System.Drawing.Size(116, 20)
        Me.txtTotBsIn.TabIndex = 77
        Me.txtTotBsIn.ToolTip = "TC_AI_TOT_BS_IN"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(12, 92)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(168, 13)
        Me.LabelControl9.TabIndex = 76
        Me.LabelControl9.Text = "Adjusted for Business Income"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(12, 66)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(127, 13)
        Me.LabelControl10.TabIndex = 75
        Me.LabelControl10.Text = "Total Business Income"
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(107, 30)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Properties.ReadOnly = True
        Me.txtSource.Size = New System.Drawing.Size(358, 20)
        Me.txtSource.TabIndex = 74
        Me.txtSource.ToolTip = "BC_TYPE"
        '
        'txtSourceNo
        '
        Me.txtSourceNo.Location = New System.Drawing.Point(107, 4)
        Me.txtSourceNo.Name = "txtSourceNo"
        Me.txtSourceNo.Properties.ReadOnly = True
        Me.txtSourceNo.Size = New System.Drawing.Size(87, 20)
        Me.txtSourceNo.TabIndex = 73
        Me.txtSourceNo.ToolTip = "TC_BUSINESS"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(12, 33)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl8.TabIndex = 72
        Me.LabelControl8.Text = "Source Description"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(12, 7)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl7.TabIndex = 71
        Me.LabelControl7.Text = "Source No"
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(288, 400)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl24.TabIndex = 113
        Me.LabelControl24.Text = "%"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.AutoScroll = True
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.btnStatutory_Partnership)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl6)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl5)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl4)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl3)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtAggregate)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtBsLoss)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtTotal)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtStatPartnership)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtAllStatIn)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GridControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.AutoScroll = True
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl7)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl24)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl8)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtSourceNo)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.btnWithDrawal)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtSource)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.btnEA)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl10)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.btnITA)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl9)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.btnRA)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtTotBsIn)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl23)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtAdjustBsIn)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtNetStat)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl11)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl22)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtAdjustBsExp)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtWithdrawal)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl12)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.chkExemption)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtAdjustedInLoss)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtPioneer)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl13)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtPio)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtAdjustedBsIn)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.cboPioneer)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtBalCharge)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl21)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl14)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl20)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtCapitalAllow)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtEA)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl16)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl19)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtABIBalCharge)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtInvestAllow)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl15)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl17)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtStatBsIn)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl18)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtRA)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1161, 616)
        Me.SplitContainerControl1.SplitterPosition = 589
        Me.SplitContainerControl1.TabIndex = 114
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'btnStatutory_Partnership
        '
        Me.btnStatutory_Partnership.Location = New System.Drawing.Point(396, 348)
        Me.btnStatutory_Partnership.Name = "btnStatutory_Partnership"
        Me.btnStatutory_Partnership.Size = New System.Drawing.Size(30, 23)
        Me.btnStatutory_Partnership.TabIndex = 125
        Me.btnStatutory_Partnership.Text = "Edit"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(12, 5)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(273, 16)
        Me.LabelControl6.TabIndex = 124
        Me.LabelControl6.Text = "Statutory business income from all source"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(12, 453)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(216, 13)
        Me.LabelControl5.TabIndex = 123
        Me.LabelControl5.Text = "Aggregate Statutory Business Income"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(12, 401)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl4.TabIndex = 122
        Me.LabelControl4.Text = "Total"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 427)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(175, 13)
        Me.LabelControl3.TabIndex = 121
        Me.LabelControl3.Text = "Less : Business loss brought forward"
        '
        'txtAggregate
        '
        Me.txtAggregate.EditValue = "0"
        Me.txtAggregate.Location = New System.Drawing.Point(432, 450)
        Me.txtAggregate.Name = "txtAggregate"
        Me.txtAggregate.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAggregate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAggregate.Properties.Mask.EditMask = "n0"
        Me.txtAggregate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAggregate.Properties.ReadOnly = True
        Me.txtAggregate.Size = New System.Drawing.Size(138, 20)
        Me.txtAggregate.TabIndex = 120
        '
        'txtBsLoss
        '
        Me.txtBsLoss.EditValue = "0"
        Me.txtBsLoss.Location = New System.Drawing.Point(432, 424)
        Me.txtBsLoss.Name = "txtBsLoss"
        Me.txtBsLoss.Properties.Appearance.Options.UseTextOptions = True
        Me.txtBsLoss.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtBsLoss.Properties.Mask.EditMask = "n0"
        Me.txtBsLoss.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtBsLoss.Properties.ReadOnly = True
        Me.txtBsLoss.Size = New System.Drawing.Size(138, 20)
        Me.txtBsLoss.TabIndex = 119
        '
        'txtTotal
        '
        Me.txtTotal.EditValue = "0"
        Me.txtTotal.Location = New System.Drawing.Point(432, 398)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal.Properties.Mask.EditMask = "n0"
        Me.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotal.Properties.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(138, 20)
        Me.txtTotal.TabIndex = 118
        '
        'txtStatPartnership
        '
        Me.txtStatPartnership.EditValue = "0"
        Me.txtStatPartnership.Location = New System.Drawing.Point(432, 350)
        Me.txtStatPartnership.Name = "txtStatPartnership"
        Me.txtStatPartnership.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStatPartnership.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtStatPartnership.Properties.Mask.EditMask = "n0"
        Me.txtStatPartnership.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtStatPartnership.Properties.ReadOnly = True
        Me.txtStatPartnership.Size = New System.Drawing.Size(138, 20)
        Me.txtStatPartnership.TabIndex = 117
        '
        'txtAllStatIn
        '
        Me.txtAllStatIn.EditValue = "0"
        Me.txtAllStatIn.Location = New System.Drawing.Point(432, 324)
        Me.txtAllStatIn.Name = "txtAllStatIn"
        Me.txtAllStatIn.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAllStatIn.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAllStatIn.Properties.Mask.EditMask = "n0"
        Me.txtAllStatIn.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAllStatIn.Properties.ReadOnly = True
        Me.txtAllStatIn.Size = New System.Drawing.Size(138, 20)
        Me.txtAllStatIn.TabIndex = 116
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 353)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(177, 13)
        Me.LabelControl2.TabIndex = 115
        Me.LabelControl2.Text = "Total Statutory Income (Partnership)"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 327)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(238, 13)
        Me.LabelControl1.TabIndex = 114
        Me.LabelControl1.Text = "Statutory business income from all source"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.STATUTORYINCOMEBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 27)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(558, 289)
        Me.GridControl1.TabIndex = 113
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'STATUTORYINCOMEBindingSource
        '
        Me.STATUTORYINCOMEBindingSource.DataMember = "STATUTORY_INCOME"
        Me.STATUTORYINCOMEBindingSource.DataSource = Me.DsTaxcomputation
        '
        'DsTaxcomputation
        '
        Me.DsTaxcomputation.DataSetName = "dsTaxcomputation"
        Me.DsTaxcomputation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTC_KEY, Me.colTC_BUSINESS, Me.colBC_TYPE, Me.colTC_AI_TOT_BS_IN, Me.colTC_AI_TOT_ADJ_BS_IN, Me.colTC_AI_TOT_ADJ_BS_EXP, Me.colTC_AI_ADJ_IN_LOSS, Me.colTC_SI_ADJ_BS_IN, Me.colTC_SI_BC, Me.colTC_SI_ADJ_BS_IN_BC, Me.colTC_SI_CA, Me.colTC_SI_STAT_BS_IN, Me.colTC_SI_INVEST_ALLOW, Me.colTC_SI_NET_STAT_IN, Me.colTC_SI_RA, Me.colTC_CB_CA_BA, Me.colTC_CB_CA_NA, Me.colTC_PIONEERDESC, Me.colTC_PIONEER, Me.colTC_RA_RATE1, Me.colTC_RA_QUALIFYINGCAPITALEXP, Me.colTC_RA_QUALIFYINGCAPITALEXP_AMOUNT, Me.colTC_RA_BALANCINGALLOWANCE, Me.colTC_RA_TOTAL1, Me.colTC_RA_RESTRICTRATE, Me.colTC_RA_RESTRICTAMOUNT, Me.colTC_ITA_RATE1, Me.colTC_ITA_QUALIFYINGCAPITALEXP, Me.colTC_ITA_QUALIFYINGCAPITALEXP_AMOUNT, Me.colTC_ITA_BALANCINGALLOWANCE, Me.colTC_ITA_TOTAL1, Me.colTC_ITA_RESTRICTRATE, Me.colTC_ITA_RESTRICTAMOUNT, Me.colTC_WITHRAITA, Me.colTC_CHK_EXEMP})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'colTC_KEY
        '
        Me.colTC_KEY.FieldName = "TC_KEY"
        Me.colTC_KEY.Name = "colTC_KEY"
        Me.colTC_KEY.Width = 150
        '
        'colTC_BUSINESS
        '
        Me.colTC_BUSINESS.Caption = "Source No."
        Me.colTC_BUSINESS.FieldName = "TC_BUSINESS"
        Me.colTC_BUSINESS.Name = "colTC_BUSINESS"
        Me.colTC_BUSINESS.Visible = True
        Me.colTC_BUSINESS.VisibleIndex = 0
        Me.colTC_BUSINESS.Width = 150
        '
        'colBC_TYPE
        '
        Me.colBC_TYPE.Caption = "Source Description"
        Me.colBC_TYPE.FieldName = "BC_TYPE"
        Me.colBC_TYPE.Name = "colBC_TYPE"
        Me.colBC_TYPE.Visible = True
        Me.colBC_TYPE.VisibleIndex = 1
        Me.colBC_TYPE.Width = 150
        '
        'colTC_AI_TOT_BS_IN
        '
        Me.colTC_AI_TOT_BS_IN.Caption = "Business Income"
        Me.colTC_AI_TOT_BS_IN.FieldName = "TC_AI_TOT_BS_IN"
        Me.colTC_AI_TOT_BS_IN.Name = "colTC_AI_TOT_BS_IN"
        Me.colTC_AI_TOT_BS_IN.Visible = True
        Me.colTC_AI_TOT_BS_IN.VisibleIndex = 2
        Me.colTC_AI_TOT_BS_IN.Width = 150
        '
        'colTC_AI_TOT_ADJ_BS_IN
        '
        Me.colTC_AI_TOT_ADJ_BS_IN.Caption = "Business Income Adjustments"
        Me.colTC_AI_TOT_ADJ_BS_IN.FieldName = "TC_AI_TOT_ADJ_BS_IN"
        Me.colTC_AI_TOT_ADJ_BS_IN.Name = "colTC_AI_TOT_ADJ_BS_IN"
        Me.colTC_AI_TOT_ADJ_BS_IN.Visible = True
        Me.colTC_AI_TOT_ADJ_BS_IN.VisibleIndex = 3
        Me.colTC_AI_TOT_ADJ_BS_IN.Width = 150
        '
        'colTC_AI_TOT_ADJ_BS_EXP
        '
        Me.colTC_AI_TOT_ADJ_BS_EXP.Caption = "Business Expenditure Adjustments"
        Me.colTC_AI_TOT_ADJ_BS_EXP.FieldName = "TC_AI_TOT_ADJ_BS_EXP"
        Me.colTC_AI_TOT_ADJ_BS_EXP.Name = "colTC_AI_TOT_ADJ_BS_EXP"
        Me.colTC_AI_TOT_ADJ_BS_EXP.Visible = True
        Me.colTC_AI_TOT_ADJ_BS_EXP.VisibleIndex = 4
        Me.colTC_AI_TOT_ADJ_BS_EXP.Width = 150
        '
        'colTC_AI_ADJ_IN_LOSS
        '
        Me.colTC_AI_ADJ_IN_LOSS.Caption = "Adjusted Income / Loss"
        Me.colTC_AI_ADJ_IN_LOSS.FieldName = "TC_AI_ADJ_IN_LOSS"
        Me.colTC_AI_ADJ_IN_LOSS.Name = "colTC_AI_ADJ_IN_LOSS"
        Me.colTC_AI_ADJ_IN_LOSS.Visible = True
        Me.colTC_AI_ADJ_IN_LOSS.VisibleIndex = 5
        Me.colTC_AI_ADJ_IN_LOSS.Width = 150
        '
        'colTC_SI_ADJ_BS_IN
        '
        Me.colTC_SI_ADJ_BS_IN.Caption = "Adjusted Business Income"
        Me.colTC_SI_ADJ_BS_IN.FieldName = "TC_SI_ADJ_BS_IN"
        Me.colTC_SI_ADJ_BS_IN.Name = "colTC_SI_ADJ_BS_IN"
        Me.colTC_SI_ADJ_BS_IN.Visible = True
        Me.colTC_SI_ADJ_BS_IN.VisibleIndex = 6
        Me.colTC_SI_ADJ_BS_IN.Width = 150
        '
        'colTC_SI_BC
        '
        Me.colTC_SI_BC.Caption = "Balancing Charge"
        Me.colTC_SI_BC.FieldName = "TC_SI_BC"
        Me.colTC_SI_BC.Name = "colTC_SI_BC"
        Me.colTC_SI_BC.Visible = True
        Me.colTC_SI_BC.VisibleIndex = 7
        Me.colTC_SI_BC.Width = 150
        '
        'colTC_SI_ADJ_BS_IN_BC
        '
        Me.colTC_SI_ADJ_BS_IN_BC.Caption = "Total"
        Me.colTC_SI_ADJ_BS_IN_BC.FieldName = "TC_SI_ADJ_BS_IN_BC"
        Me.colTC_SI_ADJ_BS_IN_BC.Name = "colTC_SI_ADJ_BS_IN_BC"
        Me.colTC_SI_ADJ_BS_IN_BC.Visible = True
        Me.colTC_SI_ADJ_BS_IN_BC.VisibleIndex = 8
        Me.colTC_SI_ADJ_BS_IN_BC.Width = 150
        '
        'colTC_SI_CA
        '
        Me.colTC_SI_CA.Caption = "Capital Allowances"
        Me.colTC_SI_CA.FieldName = "TC_SI_CA"
        Me.colTC_SI_CA.Name = "colTC_SI_CA"
        Me.colTC_SI_CA.Visible = True
        Me.colTC_SI_CA.VisibleIndex = 9
        Me.colTC_SI_CA.Width = 150
        '
        'colTC_SI_STAT_BS_IN
        '
        Me.colTC_SI_STAT_BS_IN.Caption = "Statutory Business Income"
        Me.colTC_SI_STAT_BS_IN.FieldName = "TC_SI_STAT_BS_IN"
        Me.colTC_SI_STAT_BS_IN.Name = "colTC_SI_STAT_BS_IN"
        Me.colTC_SI_STAT_BS_IN.Visible = True
        Me.colTC_SI_STAT_BS_IN.VisibleIndex = 10
        Me.colTC_SI_STAT_BS_IN.Width = 150
        '
        'colTC_SI_INVEST_ALLOW
        '
        Me.colTC_SI_INVEST_ALLOW.Caption = "ITA"
        Me.colTC_SI_INVEST_ALLOW.FieldName = "TC_SI_INVEST_ALLOW"
        Me.colTC_SI_INVEST_ALLOW.Name = "colTC_SI_INVEST_ALLOW"
        Me.colTC_SI_INVEST_ALLOW.Visible = True
        Me.colTC_SI_INVEST_ALLOW.VisibleIndex = 11
        Me.colTC_SI_INVEST_ALLOW.Width = 150
        '
        'colTC_SI_NET_STAT_IN
        '
        Me.colTC_SI_NET_STAT_IN.Caption = "Net Statutory Income"
        Me.colTC_SI_NET_STAT_IN.FieldName = "TC_SI_NET_STAT_IN"
        Me.colTC_SI_NET_STAT_IN.Name = "colTC_SI_NET_STAT_IN"
        Me.colTC_SI_NET_STAT_IN.Visible = True
        Me.colTC_SI_NET_STAT_IN.VisibleIndex = 12
        Me.colTC_SI_NET_STAT_IN.Width = 150
        '
        'colTC_SI_RA
        '
        Me.colTC_SI_RA.Caption = "RA"
        Me.colTC_SI_RA.FieldName = "TC_SI_RA"
        Me.colTC_SI_RA.Name = "colTC_SI_RA"
        Me.colTC_SI_RA.Visible = True
        Me.colTC_SI_RA.VisibleIndex = 13
        Me.colTC_SI_RA.Width = 150
        '
        'colTC_CB_CA_BA
        '
        Me.colTC_CB_CA_BA.FieldName = "TC_CB_CA_BA"
        Me.colTC_CB_CA_BA.Name = "colTC_CB_CA_BA"
        Me.colTC_CB_CA_BA.Width = 150
        '
        'colTC_CB_CA_NA
        '
        Me.colTC_CB_CA_NA.FieldName = "TC_CB_CA_NA"
        Me.colTC_CB_CA_NA.Name = "colTC_CB_CA_NA"
        Me.colTC_CB_CA_NA.Width = 150
        '
        'colTC_PIONEERDESC
        '
        Me.colTC_PIONEERDESC.Caption = "Other Exemption"
        Me.colTC_PIONEERDESC.FieldName = "TC_PIONEERDESC"
        Me.colTC_PIONEERDESC.Name = "colTC_PIONEERDESC"
        Me.colTC_PIONEERDESC.Visible = True
        Me.colTC_PIONEERDESC.VisibleIndex = 14
        Me.colTC_PIONEERDESC.Width = 150
        '
        'colTC_PIONEER
        '
        Me.colTC_PIONEER.Caption = "%"
        Me.colTC_PIONEER.FieldName = "TC_PIONEER"
        Me.colTC_PIONEER.Name = "colTC_PIONEER"
        Me.colTC_PIONEER.Visible = True
        Me.colTC_PIONEER.VisibleIndex = 15
        Me.colTC_PIONEER.Width = 150
        '
        'colTC_RA_RATE1
        '
        Me.colTC_RA_RATE1.Caption = "RA Rate"
        Me.colTC_RA_RATE1.FieldName = "TC_RA_RATE1"
        Me.colTC_RA_RATE1.Name = "colTC_RA_RATE1"
        Me.colTC_RA_RATE1.Visible = True
        Me.colTC_RA_RATE1.VisibleIndex = 16
        Me.colTC_RA_RATE1.Width = 150
        '
        'colTC_RA_QUALIFYINGCAPITALEXP
        '
        Me.colTC_RA_QUALIFYINGCAPITALEXP.Caption = "RA Qualifying Expenditure"
        Me.colTC_RA_QUALIFYINGCAPITALEXP.FieldName = "TC_RA_QUALIFYINGCAPITALEXP"
        Me.colTC_RA_QUALIFYINGCAPITALEXP.Name = "colTC_RA_QUALIFYINGCAPITALEXP"
        Me.colTC_RA_QUALIFYINGCAPITALEXP.Visible = True
        Me.colTC_RA_QUALIFYINGCAPITALEXP.VisibleIndex = 17
        Me.colTC_RA_QUALIFYINGCAPITALEXP.Width = 150
        '
        'colTC_RA_QUALIFYINGCAPITALEXP_AMOUNT
        '
        Me.colTC_RA_QUALIFYINGCAPITALEXP_AMOUNT.Caption = "RA Qualifying Amount"
        Me.colTC_RA_QUALIFYINGCAPITALEXP_AMOUNT.FieldName = "TC_RA_QUALIFYINGCAPITALEXP_AMOUNT"
        Me.colTC_RA_QUALIFYINGCAPITALEXP_AMOUNT.Name = "colTC_RA_QUALIFYINGCAPITALEXP_AMOUNT"
        Me.colTC_RA_QUALIFYINGCAPITALEXP_AMOUNT.Visible = True
        Me.colTC_RA_QUALIFYINGCAPITALEXP_AMOUNT.VisibleIndex = 18
        Me.colTC_RA_QUALIFYINGCAPITALEXP_AMOUNT.Width = 150
        '
        'colTC_RA_BALANCINGALLOWANCE
        '
        Me.colTC_RA_BALANCINGALLOWANCE.Caption = "RA Balancing Allowance"
        Me.colTC_RA_BALANCINGALLOWANCE.FieldName = "TC_RA_BALANCINGALLOWANCE"
        Me.colTC_RA_BALANCINGALLOWANCE.Name = "colTC_RA_BALANCINGALLOWANCE"
        Me.colTC_RA_BALANCINGALLOWANCE.Visible = True
        Me.colTC_RA_BALANCINGALLOWANCE.VisibleIndex = 19
        Me.colTC_RA_BALANCINGALLOWANCE.Width = 150
        '
        'colTC_RA_TOTAL1
        '
        Me.colTC_RA_TOTAL1.Caption = "RA Total"
        Me.colTC_RA_TOTAL1.FieldName = "TC_RA_TOTAL1"
        Me.colTC_RA_TOTAL1.Name = "colTC_RA_TOTAL1"
        Me.colTC_RA_TOTAL1.Visible = True
        Me.colTC_RA_TOTAL1.VisibleIndex = 20
        Me.colTC_RA_TOTAL1.Width = 150
        '
        'colTC_RA_RESTRICTRATE
        '
        Me.colTC_RA_RESTRICTRATE.Caption = "RA Restriction (Rate)"
        Me.colTC_RA_RESTRICTRATE.FieldName = "TC_RA_RESTRICTRATE"
        Me.colTC_RA_RESTRICTRATE.Name = "colTC_RA_RESTRICTRATE"
        Me.colTC_RA_RESTRICTRATE.Visible = True
        Me.colTC_RA_RESTRICTRATE.VisibleIndex = 21
        Me.colTC_RA_RESTRICTRATE.Width = 150
        '
        'colTC_RA_RESTRICTAMOUNT
        '
        Me.colTC_RA_RESTRICTAMOUNT.Caption = "RA Restriction (Amount))"
        Me.colTC_RA_RESTRICTAMOUNT.FieldName = "TC_RA_RESTRICTAMOUNT"
        Me.colTC_RA_RESTRICTAMOUNT.Name = "colTC_RA_RESTRICTAMOUNT"
        Me.colTC_RA_RESTRICTAMOUNT.Visible = True
        Me.colTC_RA_RESTRICTAMOUNT.VisibleIndex = 22
        Me.colTC_RA_RESTRICTAMOUNT.Width = 150
        '
        'colTC_ITA_RATE1
        '
        Me.colTC_ITA_RATE1.Caption = "ITA Rate"
        Me.colTC_ITA_RATE1.FieldName = "TC_ITA_RATE1"
        Me.colTC_ITA_RATE1.Name = "colTC_ITA_RATE1"
        Me.colTC_ITA_RATE1.Visible = True
        Me.colTC_ITA_RATE1.VisibleIndex = 23
        Me.colTC_ITA_RATE1.Width = 150
        '
        'colTC_ITA_QUALIFYINGCAPITALEXP
        '
        Me.colTC_ITA_QUALIFYINGCAPITALEXP.Caption = "ITA Qualifying Expenditure"
        Me.colTC_ITA_QUALIFYINGCAPITALEXP.FieldName = "TC_ITA_QUALIFYINGCAPITALEXP"
        Me.colTC_ITA_QUALIFYINGCAPITALEXP.Name = "colTC_ITA_QUALIFYINGCAPITALEXP"
        Me.colTC_ITA_QUALIFYINGCAPITALEXP.Visible = True
        Me.colTC_ITA_QUALIFYINGCAPITALEXP.VisibleIndex = 24
        Me.colTC_ITA_QUALIFYINGCAPITALEXP.Width = 150
        '
        'colTC_ITA_QUALIFYINGCAPITALEXP_AMOUNT
        '
        Me.colTC_ITA_QUALIFYINGCAPITALEXP_AMOUNT.Caption = "ITA Qualifying Amount"
        Me.colTC_ITA_QUALIFYINGCAPITALEXP_AMOUNT.FieldName = "TC_ITA_QUALIFYINGCAPITALEXP_AMOUNT"
        Me.colTC_ITA_QUALIFYINGCAPITALEXP_AMOUNT.Name = "colTC_ITA_QUALIFYINGCAPITALEXP_AMOUNT"
        Me.colTC_ITA_QUALIFYINGCAPITALEXP_AMOUNT.Visible = True
        Me.colTC_ITA_QUALIFYINGCAPITALEXP_AMOUNT.VisibleIndex = 25
        Me.colTC_ITA_QUALIFYINGCAPITALEXP_AMOUNT.Width = 150
        '
        'colTC_ITA_BALANCINGALLOWANCE
        '
        Me.colTC_ITA_BALANCINGALLOWANCE.Caption = "ITA Balancing Allowance"
        Me.colTC_ITA_BALANCINGALLOWANCE.FieldName = "TC_ITA_BALANCINGALLOWANCE"
        Me.colTC_ITA_BALANCINGALLOWANCE.Name = "colTC_ITA_BALANCINGALLOWANCE"
        Me.colTC_ITA_BALANCINGALLOWANCE.Visible = True
        Me.colTC_ITA_BALANCINGALLOWANCE.VisibleIndex = 26
        Me.colTC_ITA_BALANCINGALLOWANCE.Width = 150
        '
        'colTC_ITA_TOTAL1
        '
        Me.colTC_ITA_TOTAL1.Caption = "ITA Total"
        Me.colTC_ITA_TOTAL1.FieldName = "TC_ITA_TOTAL1"
        Me.colTC_ITA_TOTAL1.Name = "colTC_ITA_TOTAL1"
        Me.colTC_ITA_TOTAL1.Visible = True
        Me.colTC_ITA_TOTAL1.VisibleIndex = 27
        Me.colTC_ITA_TOTAL1.Width = 150
        '
        'colTC_ITA_RESTRICTRATE
        '
        Me.colTC_ITA_RESTRICTRATE.Caption = "ITA Restriction (Rate)"
        Me.colTC_ITA_RESTRICTRATE.FieldName = "TC_ITA_RESTRICTRATE"
        Me.colTC_ITA_RESTRICTRATE.Name = "colTC_ITA_RESTRICTRATE"
        Me.colTC_ITA_RESTRICTRATE.Visible = True
        Me.colTC_ITA_RESTRICTRATE.VisibleIndex = 28
        Me.colTC_ITA_RESTRICTRATE.Width = 150
        '
        'colTC_ITA_RESTRICTAMOUNT
        '
        Me.colTC_ITA_RESTRICTAMOUNT.Caption = "ITA Restriction (Amount)"
        Me.colTC_ITA_RESTRICTAMOUNT.FieldName = "TC_ITA_RESTRICTAMOUNT"
        Me.colTC_ITA_RESTRICTAMOUNT.Name = "colTC_ITA_RESTRICTAMOUNT"
        Me.colTC_ITA_RESTRICTAMOUNT.Visible = True
        Me.colTC_ITA_RESTRICTAMOUNT.VisibleIndex = 29
        Me.colTC_ITA_RESTRICTAMOUNT.Width = 150
        '
        'colTC_WITHRAITA
        '
        Me.colTC_WITHRAITA.Caption = "Withdrawal RA ITA"
        Me.colTC_WITHRAITA.FieldName = "TC_WITHRAITA"
        Me.colTC_WITHRAITA.Name = "colTC_WITHRAITA"
        Me.colTC_WITHRAITA.Visible = True
        Me.colTC_WITHRAITA.VisibleIndex = 30
        Me.colTC_WITHRAITA.Width = 150
        '
        'colTC_CHK_EXEMP
        '
        Me.colTC_CHK_EXEMP.Caption = "Check Box Exemption"
        Me.colTC_CHK_EXEMP.FieldName = "TC_CHK_EXEMP"
        Me.colTC_CHK_EXEMP.Name = "colTC_CHK_EXEMP"
        Me.colTC_CHK_EXEMP.Visible = True
        Me.colTC_CHK_EXEMP.VisibleIndex = 31
        Me.colTC_CHK_EXEMP.Width = 150
        '
        'ucTaxCom_StatutoryIncome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "ucTaxCom_StatutoryIncome"
        Me.Size = New System.Drawing.Size(1161, 616)
        CType(Me.txtNetStat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWithdrawal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkExemption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPioneer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPioneer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvestAllow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatBsIn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtABIBalCharge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCapitalAllow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBalCharge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdjustedBsIn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdjustedInLoss.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdjustBsExp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdjustBsIn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotBsIn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSourceNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.txtAggregate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBsLoss.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatPartnership.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAllStatIn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STATUTORYINCOMEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTaxcomputation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnWithDrawal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEA As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnITA As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRA As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNetStat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtWithdrawal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkExemption As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtPioneer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboPioneer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInvestAllow As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStatBsIn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtABIBalCharge As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCapitalAllow As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBalCharge As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAdjustedBsIn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAdjustedInLoss As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAdjustBsExp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAdjustBsIn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotBsIn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSource As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSourceNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents btnStatutory_Partnership As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAggregate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBsLoss As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStatPartnership As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAllStatIn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents STATUTORYINCOMEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsTaxcomputation As EasyTemplate_Taxcom.dsTaxcomputation
    Friend WithEvents colTC_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_BUSINESS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_AI_TOT_BS_IN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_AI_TOT_ADJ_BS_IN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_AI_TOT_ADJ_BS_EXP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_AI_ADJ_IN_LOSS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_ADJ_BS_IN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_BC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_ADJ_BS_IN_BC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_CA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_STAT_BS_IN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_INVEST_ALLOW As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_NET_STAT_IN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_RA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_CA_BA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_CA_NA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_PIONEERDESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_PIONEER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_RA_RATE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_RA_QUALIFYINGCAPITALEXP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_RA_QUALIFYINGCAPITALEXP_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_RA_BALANCINGALLOWANCE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_RA_TOTAL1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_RA_RESTRICTRATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_RA_RESTRICTAMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_ITA_RATE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_ITA_QUALIFYINGCAPITALEXP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_ITA_QUALIFYINGCAPITALEXP_AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_ITA_BALANCINGALLOWANCE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_ITA_TOTAL1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_ITA_RESTRICTRATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_ITA_RESTRICTAMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_WITHRAITA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CHK_EXEMP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBC_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController

End Class
