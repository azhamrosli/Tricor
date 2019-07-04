<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAdjustedIncome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucAdjustedIncome))
        Me.pnlLoading = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.btnClear2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.txtRefNo = New DevExpress.XtraEditors.TextEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dgvView = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyReferenceNoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyYAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TAXCOMPUTATIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAdjustedIncome = New EasyTemplate_Taxcom.dsAdjustedIncome()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTC_KEY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_REF_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_YA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CO_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_ROC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_BUSINESS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_AI_PNL_BAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_AI_DIVIDEND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_AI_RENTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_AI_ROYALTY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_AI_INTEREST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_AI_SEC4A = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_AI_TOT_NONBS_IN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_AI_TOT_BS_IN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_AI_ADJ_BS_IN_NA_LOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_AI_ADJ_BS_IN_NT_IN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_AI_ADJ_BS_IN_TAX_IN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_AI_TOT_ADJ_BS_IN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_AI_ADJ_BS_EXP_INT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_AI_ADJ_BS_EXP_NA_EXP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_AI_ADJ_BS_EXP_RV_EXP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_AI_ADJ_BS_EXP_CLAIM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_AI_TOT_ADJ_BS_EXP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_AI_ADJ_IN_LOSS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_ADJ_BS_IN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_CA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_STAT_BS_IN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_INVEST_ALLOW = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_NET_STAT_IN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_SS_RENTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_SS_DIR_EXP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_SS_DIR_EXP_QUIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_SS_DIR_EXP_MAIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_SS_ADJ_IN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_SS_CA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_SS_STAT_BS_IN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_OTH_SOURCE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_MAIN_BS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_SEC_BS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_OTH_BS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_TOT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_BS_LOSS_BF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_AGGREGATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_DIV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_DIV_ATT_INT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_DIV_NET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_INT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_INT_ATT_INT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_INT_NET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_RENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_RENT_ATT_INT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_RENT_ASSESS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_RENT_QUIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_RENT_INSUR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_RENT_OTH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_RENT_MAIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_RENT_AGREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_RENT_NET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_SUNDRY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_OTH_AGGR_STAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_AGGR_IN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_CURR_LOSS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_AGGR_IN_LOSS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_APRV_DONATION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_CHARGEABLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_28_CHARGEABLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_SEC110 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_SEC132 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_SEC133 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_TOT_SETOFF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_PAYABLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_INSTALL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_PAYABLE_BAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_CA_BAL_BF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_CA_CURR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_CA_AA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_CA_IA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_CA_BA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_CA_UTIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_CA_BAL_CF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_LS_BAL_BF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_LS_UTIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_LS_BAL_UTIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_LS_UNABSORBED = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_LS_BAL_CF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_ITA_BAL_BF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_ITA_CURR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_ITA_BAL_BF_CURR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_ITA_UTIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_ITA_BAL_CF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_AI_OTH_BS_IN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_RATE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_RATE2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_RATE3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_RATE4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_RATE5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_RATE6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_APP_CHARGEABLE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_APP_CHARGEABLE2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_APP_CHARGEABLE3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_APP_CHARGEABLE4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_APP_CHARGEABLE5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_APP_CHARGEABLE6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_RATE1_CHARGEABLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_RATE2_CHARGEABLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_RATE3_CHARGEABLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_RATE4_CHARGEABLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_RATE5_CHARGEABLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_TOT_TAX_CHARGED = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_SEC6B_REBATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_SEC110_OTHERS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_PROSPECTING = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_QUALIFY_AGRICULTURE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_PREOP_BS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_FOOD_PRODUCTION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_EXP_ALLOWED = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_TOTAL_OTH_EXP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_TOTAL_INCOME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_PIONEER_CHARGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_OPERATIONALHQ_CHARGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_FOREIGN_CHARGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_BS_LOSS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_ROYALTY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_ADDITION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_LS_ADJUST_LOSS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_LS_UTIL_CURR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_RA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_RA_BAL_BF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_RA_CURR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_RA_BAL_BF_CURR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_RA_UTIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_RA_BAL_CF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_BC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_ADJ_BS_IN_BC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_CA_CURR_BA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_RATE4A = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_APP_CHARGEABLE4A = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_RATE4A_CHARGEABLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_CA_NA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_ZAKAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_OTHERDEDUCTION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_CA_DISALLOW = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_CA_ABAL_CF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_CHECK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_CLAIM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_LS_SAMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_LS_BALS_CF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_LS_D_BL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_LS_SRDAMT2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_LS_BLNBF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_LS_AMTTUT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_LS_BLNCF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_COMPANY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_PIONEERDESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_PIO = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.colTC_DISALLOW_NOTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_DISALLOWBUSINESS_NOTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SURPLUSRECOVERED = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_MININGALLOWNANCE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_MININGEXPENSES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_STAT_DIVIDEND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_SEC110B = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_RENT_OTH2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_CARRYBCKLOSS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_AMTNOTCARRYBCK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_CHKCB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_INCOME_TP2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_ESTIMATED_TP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_INCOME_TP3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_ALL_DIFF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_EX_DIFF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_PEN_DIFF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_WITHRAITA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_RA_WITHDRAWAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_RA_ADJUSTMENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_ITA_WITHDRAWAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_ITA_ADJUSTMENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_DIV_OTH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_INT_OTH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SUNDRY_EXP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CHK_EXEMP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_SI_TOT_PARTNERSHIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_CB_CA_ACA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_RENTIBA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_RENTIBA_ATT_IN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_RENTIBA_ASSESS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_RENTIBA_QUIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_RENTIBA_INSUR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_RENTIBA_OTH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_RENTIBA_MAIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_RENTIBA_AGREE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_RENTIBA_IBA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_DIV_DIS_ATT_INT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_DIV_TOT_ATT_INT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_EA_UTL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_EA_TYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_EA_CURR_COMPANY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_EA_CURR_AGRICULTURE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_EA_CURR_SIGNIFICANT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_EA_CURR_MARKET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_EA_CURR_MSB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_EA_TOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_EA_RESTRICTRATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_EA_BF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_EA_CF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_ESTIMATED_SME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_DCA_INT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_NB_DEEMED_INT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_EXEMPTIONCAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_EXEMPTIONLESS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_INSTALL_107C = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_INSTALL_107A = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_RATE7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_APP_CHARGEABLE7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_RATE6_CHARGEABLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_TP_RATE7_CHARGEABLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_EA_TYPE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_EA_TYPE2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTC_EA_TYPE3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboYA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TaxPayerFindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCA = New EasyTemplate_Taxcom.dsCA()
        Me.btnAllRecord = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cboRefNo = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRefNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHandleBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployerNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyCode = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.TAXCOMPUTATIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAdjustedIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLoading
        '
        Me.pnlLoading.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlLoading.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pnlLoading.Appearance.Options.UseBackColor = True
        Me.pnlLoading.AppearanceCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.pnlLoading.AppearanceCaption.Options.UseFont = True
        Me.pnlLoading.AppearanceDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.pnlLoading.AppearanceDescription.Options.UseFont = True
        Me.pnlLoading.BarAnimationElementThickness = 2
        Me.pnlLoading.Location = New System.Drawing.Point(347, 206)
        Me.pnlLoading.Name = "pnlLoading"
        Me.pnlLoading.Size = New System.Drawing.Size(246, 66)
        Me.pnlLoading.TabIndex = 12
        Me.pnlLoading.Text = "ProgressPanel1"
        Me.pnlLoading.Visible = False
        '
        'btnClear2
        '
        Me.btnClear2.ImageOptions.Image = CType(resources.GetObject("btnClear2.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClear2.Location = New System.Drawing.Point(681, 13)
        Me.btnClear2.Name = "btnClear2"
        Me.btnClear2.Size = New System.Drawing.Size(24, 23)
        Me.btnClear2.TabIndex = 13
        '
        'btnClear
        '
        Me.btnClear.ImageOptions.Image = CType(resources.GetObject("btnClear.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClear.Location = New System.Drawing.Point(364, 13)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(24, 23)
        Me.btnClear.TabIndex = 12
        '
        'txtRefNo
        '
        Me.txtRefNo.Location = New System.Drawing.Point(91, 41)
        Me.txtRefNo.MenuManager = Me.BarManager1
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Properties.ReadOnly = True
        Me.txtRefNo.Size = New System.Drawing.Size(268, 20)
        Me.txtRefNo.TabIndex = 11
        '
        'BarManager1
        '
        Me.BarManager1.AllowQuickCustomization = False
        Me.BarManager1.AllowShowToolbarsPopup = False
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnAdd, Me.btnEdit, Me.btnDelete, Me.btnPrint, Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 8
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrint), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None
        Me.Bar1.OptionsBar.DisableClose = True
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'btnAdd
        '
        Me.btnAdd.Caption = "Add"
        Me.btnAdd.Id = 0
        Me.btnAdd.ImageOptions.Image = CType(resources.GetObject("btnAdd.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd.ImageOptions.LargeImage = CType(resources.GetObject("btnAdd.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnEdit
        '
        Me.btnEdit.Caption = "Edit"
        Me.btnEdit.Id = 1
        Me.btnEdit.ImageOptions.Image = CType(resources.GetObject("btnEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEdit.ImageOptions.LargeImage = CType(resources.GetObject("btnEdit.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnDelete
        '
        Me.btnDelete.Caption = "Delete"
        Me.btnDelete.Id = 2
        Me.btnDelete.ImageOptions.Image = CType(resources.GetObject("btnDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDelete.ImageOptions.LargeImage = CType(resources.GetObject("btnDelete.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnPrint
        '
        Me.btnPrint.Caption = "Print"
        Me.btnPrint.Id = 3
        Me.btnPrint.ImageOptions.Image = CType(resources.GetObject("btnPrint.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrint.ImageOptions.LargeImage = CType(resources.GetObject("btnPrint.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Test"
        Me.BarButtonItem1.Id = 7
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(948, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 579)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(948, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 548)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(948, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 548)
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(423, 17)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "YA :"
        '
        'dgvView
        '
        Me.dgvView.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvView.DataSource = Me.TAXCOMPUTATIONBindingSource
        Me.dgvView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvView.Location = New System.Drawing.Point(0, 106)
        Me.dgvView.MainView = Me.GridView1
        Me.dgvView.Name = "dgvView"
        Me.dgvView.Size = New System.Drawing.Size(948, 473)
        Me.dgvView.TabIndex = 11
        Me.dgvView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.PrintToolStripMenuItem, Me.CopyReferenceNoToolStripMenuItem, Me.CopyYAToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(177, 136)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'CopyReferenceNoToolStripMenuItem
        '
        Me.CopyReferenceNoToolStripMenuItem.Name = "CopyReferenceNoToolStripMenuItem"
        Me.CopyReferenceNoToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CopyReferenceNoToolStripMenuItem.Text = "Copy Reference No"
        '
        'CopyYAToolStripMenuItem
        '
        Me.CopyYAToolStripMenuItem.Name = "CopyYAToolStripMenuItem"
        Me.CopyYAToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CopyYAToolStripMenuItem.Text = "Copy YA"
        '
        'TAXCOMPUTATIONBindingSource
        '
        Me.TAXCOMPUTATIONBindingSource.DataMember = "TAX_COMPUTATION"
        Me.TAXCOMPUTATIONBindingSource.DataSource = Me.DsAdjustedIncome
        '
        'DsAdjustedIncome
        '
        Me.DsAdjustedIncome.DataSetName = "dsAdjustedIncome"
        Me.DsAdjustedIncome.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTC_KEY, Me.colTC_REF_NO, Me.colTC_YA, Me.colTC_CO_NAME, Me.colTC_ROC, Me.colTC_BUSINESS, Me.colTC_AI_PNL_BAL, Me.colTC_AI_DIVIDEND, Me.colTC_AI_RENTAL, Me.colTC_AI_ROYALTY, Me.colTC_AI_INTEREST, Me.colTC_AI_SEC4A, Me.colTC_AI_TOT_NONBS_IN, Me.colTC_AI_TOT_BS_IN, Me.colTC_AI_ADJ_BS_IN_NA_LOS, Me.colTC_AI_ADJ_BS_IN_NT_IN, Me.colTC_AI_ADJ_BS_IN_TAX_IN, Me.colTC_AI_TOT_ADJ_BS_IN, Me.colTC_AI_ADJ_BS_EXP_INT, Me.colTC_AI_ADJ_BS_EXP_NA_EXP, Me.colTC_AI_ADJ_BS_EXP_RV_EXP, Me.colTC_AI_ADJ_BS_EXP_CLAIM, Me.colTC_AI_TOT_ADJ_BS_EXP, Me.colTC_AI_ADJ_IN_LOSS, Me.colTC_SI_ADJ_BS_IN, Me.colTC_SI_CA, Me.colTC_SI_STAT_BS_IN, Me.colTC_SI_INVEST_ALLOW, Me.colTC_SI_NET_STAT_IN, Me.colTC_SI_SS_RENTAL, Me.colTC_SI_SS_DIR_EXP, Me.colTC_SI_SS_DIR_EXP_QUIT, Me.colTC_SI_SS_DIR_EXP_MAIN, Me.colTC_SI_SS_ADJ_IN, Me.colTC_SI_SS_CA, Me.colTC_SI_SS_STAT_BS_IN, Me.colTC_SI_OTH_SOURCE, Me.colTC_SI_MAIN_BS, Me.colTC_SI_SEC_BS, Me.colTC_SI_OTH_BS, Me.colTC_SI_TOT, Me.colTC_SI_BS_LOSS_BF, Me.colTC_SI_AGGREGATE, Me.colTC_NB_DIV, Me.colTC_NB_DIV_ATT_INT, Me.colTC_NB_DIV_NET, Me.colTC_NB_INT, Me.colTC_NB_INT_ATT_INT, Me.colTC_NB_INT_NET, Me.colTC_NB_RENT, Me.colTC_NB_RENT_ATT_INT, Me.colTC_NB_RENT_ASSESS, Me.colTC_NB_RENT_QUIT, Me.colTC_NB_RENT_INSUR, Me.colTC_NB_RENT_OTH, Me.colTC_NB_RENT_MAIN, Me.colTC_NB_RENT_AGREE, Me.colTC_NB_RENT_NET, Me.colTC_NB_SUNDRY, Me.colTC_NB_OTH_AGGR_STAT, Me.colTC_TP_AGGR_IN, Me.colTC_TP_CURR_LOSS, Me.colTC_TP_AGGR_IN_LOSS, Me.colTC_TP_APRV_DONATION, Me.colTC_TP_CHARGEABLE, Me.colTC_TP_28_CHARGEABLE, Me.colTC_TP_SEC110, Me.colTC_TP_SEC132, Me.colTC_TP_SEC133, Me.colTC_TP_TOT_SETOFF, Me.colTC_TP_PAYABLE, Me.colTC_TP_INSTALL, Me.colTC_TP_PAYABLE_BAL, Me.colTC_CB_CA_BAL_BF, Me.colTC_CB_CA_CURR, Me.colTC_CB_CA_AA, Me.colTC_CB_CA_IA, Me.colTC_CB_CA_BA, Me.colTC_CB_CA_UTIL, Me.colTC_CB_CA_BAL_CF, Me.colTC_CB_LS_BAL_BF, Me.colTC_CB_LS_UTIL, Me.colTC_CB_LS_BAL_UTIL, Me.colTC_CB_LS_UNABSORBED, Me.colTC_CB_LS_BAL_CF, Me.colTC_CB_ITA_BAL_BF, Me.colTC_CB_ITA_CURR, Me.colTC_CB_ITA_BAL_BF_CURR, Me.colTC_CB_ITA_UTIL, Me.colTC_CB_ITA_BAL_CF, Me.colTC_AI_OTH_BS_IN, Me.colTC_TP_RATE1, Me.colTC_TP_RATE2, Me.colTC_TP_RATE3, Me.colTC_TP_RATE4, Me.colTC_TP_RATE5, Me.colTC_TP_RATE6, Me.colTC_TP_APP_CHARGEABLE1, Me.colTC_TP_APP_CHARGEABLE2, Me.colTC_TP_APP_CHARGEABLE3, Me.colTC_TP_APP_CHARGEABLE4, Me.colTC_TP_APP_CHARGEABLE5, Me.colTC_TP_APP_CHARGEABLE6, Me.colTC_TP_RATE1_CHARGEABLE, Me.colTC_TP_RATE2_CHARGEABLE, Me.colTC_TP_RATE3_CHARGEABLE, Me.colTC_TP_RATE4_CHARGEABLE, Me.colTC_TP_RATE5_CHARGEABLE, Me.colTC_TP_TOT_TAX_CHARGED, Me.colTC_TP_SEC6B_REBATE, Me.colTC_TP_SEC110_OTHERS, Me.colTC_TP_PROSPECTING, Me.colTC_TP_QUALIFY_AGRICULTURE, Me.colTC_TP_PREOP_BS, Me.colTC_TP_FOOD_PRODUCTION, Me.colTC_TP_EXP_ALLOWED, Me.colTC_TP_TOTAL_OTH_EXP, Me.colTC_TP_TOTAL_INCOME, Me.colTC_TP_PIONEER_CHARGE, Me.colTC_TP_OPERATIONALHQ_CHARGE, Me.colTC_TP_FOREIGN_CHARGE, Me.colTC_TP_BS_LOSS, Me.colTC_NB_ROYALTY, Me.colTC_NB_ADDITION, Me.colTC_CB_LS_ADJUST_LOSS, Me.colTC_CB_LS_UTIL_CURR, Me.colTC_SI_RA, Me.colTC_CB_RA_BAL_BF, Me.colTC_CB_RA_CURR, Me.colTC_CB_RA_BAL_BF_CURR, Me.colTC_CB_RA_UTIL, Me.colTC_CB_RA_BAL_CF, Me.colTC_SI_BC, Me.colTC_SI_ADJ_BS_IN_BC, Me.colTC_CB_CA_CURR_BA, Me.colTC_TP_RATE4A, Me.colTC_TP_APP_CHARGEABLE4A, Me.colTC_TP_RATE4A_CHARGEABLE, Me.colTC_CB_CA_NA, Me.colTC_TP_ZAKAT, Me.colTC_OTHERDEDUCTION, Me.colTC_CB_CA_DISALLOW, Me.colTC_CB_CA_ABAL_CF, Me.colTC_CB_CHECK, Me.colTC_TP_CLAIM, Me.colTC_CB_LS_SAMOUNT, Me.colTC_CB_LS_BALS_CF, Me.colTC_CB_LS_D_BL, Me.colTC_CB_LS_SRDAMT2, Me.colTC_CB_LS_BLNBF, Me.colTC_CB_LS_AMTTUT, Me.colTC_CB_LS_BLNCF, Me.colTC_COMPANY, Me.colTC_PIONEERDESC, Me.colTC_PIO, Me.colTC_PIONEER, Me.colTC_RA_RATE1, Me.colTC_RA_QUALIFYINGCAPITALEXP, Me.colTC_RA_QUALIFYINGCAPITALEXP_AMOUNT, Me.colTC_RA_BALANCINGALLOWANCE, Me.colTC_RA_TOTAL1, Me.colTC_RA_RESTRICTRATE, Me.colTC_RA_RESTRICTAMOUNT, Me.colTC_ITA_RATE1, Me.colTC_ITA_QUALIFYINGCAPITALEXP, Me.colTC_ITA_QUALIFYINGCAPITALEXP_AMOUNT, Me.colTC_ITA_BALANCINGALLOWANCE, Me.colTC_ITA_TOTAL1, Me.colTC_ITA_RESTRICTRATE, Me.colTC_ITA_RESTRICTAMOUNT, Me.colTC_DISALLOW_NOTE, Me.colTC_DISALLOWBUSINESS_NOTE, Me.colTC_SURPLUSRECOVERED, Me.colTC_MININGALLOWNANCE, Me.colTC_MININGEXPENSES, Me.colTC_STAT_DIVIDEND, Me.colTC_TP_SEC110B, Me.colTC_NB_RENT_OTH2, Me.colTC_NB_CARRYBCKLOSS, Me.colTC_NB_AMTNOTCARRYBCK, Me.colTC_NB_CHKCB, Me.colTC_TP_INCOME_TP2, Me.colTC_TP_ESTIMATED_TP, Me.colTC_TP_INCOME_TP3, Me.colTC_TP_ALL_DIFF, Me.colTC_TP_EX_DIFF, Me.colTC_TP_PEN_DIFF, Me.colTC_WITHRAITA, Me.colTC_RA_WITHDRAWAL, Me.colTC_RA_ADJUSTMENT, Me.colTC_ITA_WITHDRAWAL, Me.colTC_ITA_ADJUSTMENT, Me.colTC_NB_DIV_OTH, Me.colTC_NB_INT_OTH, Me.colTC_SUNDRY_EXP, Me.colTC_CHK_EXEMP, Me.colTC_SI_TOT_PARTNERSHIP, Me.colTC_CB_CA_ACA, Me.colTC_NB_RENTIBA, Me.colTC_NB_RENTIBA_ATT_IN, Me.colTC_NB_RENTIBA_ASSESS, Me.colTC_NB_RENTIBA_QUIT, Me.colTC_NB_RENTIBA_INSUR, Me.colTC_NB_RENTIBA_OTH, Me.colTC_NB_RENTIBA_MAIN, Me.colTC_NB_RENTIBA_AGREE, Me.colTC_NB_RENTIBA_IBA, Me.colTC_NB_DIV_DIS_ATT_INT, Me.colTC_NB_DIV_TOT_ATT_INT, Me.colTC_EA_UTL, Me.colTC_EA_TYPE, Me.colTC_EA_CURR_COMPANY, Me.colTC_EA_CURR_AGRICULTURE, Me.colTC_EA_CURR_SIGNIFICANT, Me.colTC_EA_CURR_MARKET, Me.colTC_EA_CURR_MSB, Me.colTC_EA_TOTAL, Me.colTC_EA_RESTRICTRATE, Me.colTC_EA_BF, Me.colTC_EA_CF, Me.colTC_TP_ESTIMATED_SME, Me.colTC_NB_DCA_INT, Me.colTC_NB_DEEMED_INT, Me.colTC_EXEMPTIONCAL, Me.colTC_EXEMPTIONLESS, Me.colTC_TP_INSTALL_107C, Me.colTC_TP_INSTALL_107A, Me.colTC_TP_RATE7, Me.colTC_TP_APP_CHARGEABLE7, Me.colTC_TP_RATE6_CHARGEABLE, Me.colTC_TP_RATE7_CHARGEABLE, Me.colTC_EA_TYPE1, Me.colTC_EA_TYPE2, Me.colTC_EA_TYPE3})
        Me.GridView1.GridControl = Me.dgvView
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        '
        'colTC_KEY
        '
        Me.colTC_KEY.Caption = "No"
        Me.colTC_KEY.FieldName = "TC_KEY"
        Me.colTC_KEY.Name = "colTC_KEY"
        Me.colTC_KEY.Visible = True
        Me.colTC_KEY.VisibleIndex = 0
        '
        'colTC_REF_NO
        '
        Me.colTC_REF_NO.Caption = "Reference No"
        Me.colTC_REF_NO.FieldName = "TC_REF_NO"
        Me.colTC_REF_NO.Name = "colTC_REF_NO"
        Me.colTC_REF_NO.Visible = True
        Me.colTC_REF_NO.VisibleIndex = 1
        Me.colTC_REF_NO.Width = 92
        '
        'colTC_YA
        '
        Me.colTC_YA.Caption = "YA"
        Me.colTC_YA.FieldName = "TC_YA"
        Me.colTC_YA.Name = "colTC_YA"
        Me.colTC_YA.Visible = True
        Me.colTC_YA.VisibleIndex = 2
        '
        'colTC_CO_NAME
        '
        Me.colTC_CO_NAME.Caption = "Company Name"
        Me.colTC_CO_NAME.FieldName = "TC_CO_NAME"
        Me.colTC_CO_NAME.Name = "colTC_CO_NAME"
        Me.colTC_CO_NAME.Visible = True
        Me.colTC_CO_NAME.VisibleIndex = 3
        Me.colTC_CO_NAME.Width = 350
        '
        'colTC_ROC
        '
        Me.colTC_ROC.Caption = "Registration No"
        Me.colTC_ROC.FieldName = "TC_ROC"
        Me.colTC_ROC.Name = "colTC_ROC"
        Me.colTC_ROC.Visible = True
        Me.colTC_ROC.VisibleIndex = 4
        '
        'colTC_BUSINESS
        '
        Me.colTC_BUSINESS.Caption = "Business Source"
        Me.colTC_BUSINESS.FieldName = "TC_BUSINESS"
        Me.colTC_BUSINESS.Name = "colTC_BUSINESS"
        Me.colTC_BUSINESS.Visible = True
        Me.colTC_BUSINESS.VisibleIndex = 5
        '
        'colTC_AI_PNL_BAL
        '
        Me.colTC_AI_PNL_BAL.Caption = "P & L Balance"
        Me.colTC_AI_PNL_BAL.FieldName = "TC_AI_PNL_BAL"
        Me.colTC_AI_PNL_BAL.Name = "colTC_AI_PNL_BAL"
        Me.colTC_AI_PNL_BAL.Visible = True
        Me.colTC_AI_PNL_BAL.VisibleIndex = 6
        '
        'colTC_AI_DIVIDEND
        '
        Me.colTC_AI_DIVIDEND.Caption = "Dividend Income"
        Me.colTC_AI_DIVIDEND.FieldName = "TC_AI_DIVIDEND"
        Me.colTC_AI_DIVIDEND.Name = "colTC_AI_DIVIDEND"
        Me.colTC_AI_DIVIDEND.Visible = True
        Me.colTC_AI_DIVIDEND.VisibleIndex = 7
        '
        'colTC_AI_RENTAL
        '
        Me.colTC_AI_RENTAL.Caption = "Rental Income"
        Me.colTC_AI_RENTAL.FieldName = "TC_AI_RENTAL"
        Me.colTC_AI_RENTAL.Name = "colTC_AI_RENTAL"
        Me.colTC_AI_RENTAL.Visible = True
        Me.colTC_AI_RENTAL.VisibleIndex = 8
        '
        'colTC_AI_ROYALTY
        '
        Me.colTC_AI_ROYALTY.Caption = "Royalty Income"
        Me.colTC_AI_ROYALTY.FieldName = "TC_AI_ROYALTY"
        Me.colTC_AI_ROYALTY.Name = "colTC_AI_ROYALTY"
        Me.colTC_AI_ROYALTY.Visible = True
        Me.colTC_AI_ROYALTY.VisibleIndex = 9
        '
        'colTC_AI_INTEREST
        '
        Me.colTC_AI_INTEREST.Caption = "Interest Income"
        Me.colTC_AI_INTEREST.FieldName = "TC_AI_INTEREST"
        Me.colTC_AI_INTEREST.Name = "colTC_AI_INTEREST"
        Me.colTC_AI_INTEREST.Visible = True
        Me.colTC_AI_INTEREST.VisibleIndex = 10
        '
        'colTC_AI_SEC4A
        '
        Me.colTC_AI_SEC4A.Caption = "Section 4A Income"
        Me.colTC_AI_SEC4A.FieldName = "TC_AI_SEC4A"
        Me.colTC_AI_SEC4A.Name = "colTC_AI_SEC4A"
        Me.colTC_AI_SEC4A.Visible = True
        Me.colTC_AI_SEC4A.VisibleIndex = 11
        '
        'colTC_AI_TOT_NONBS_IN
        '
        Me.colTC_AI_TOT_NONBS_IN.FieldName = "TC_AI_TOT_NONBS_IN"
        Me.colTC_AI_TOT_NONBS_IN.Name = "colTC_AI_TOT_NONBS_IN"
        '
        'colTC_AI_TOT_BS_IN
        '
        Me.colTC_AI_TOT_BS_IN.FieldName = "TC_AI_TOT_BS_IN"
        Me.colTC_AI_TOT_BS_IN.Name = "colTC_AI_TOT_BS_IN"
        '
        'colTC_AI_ADJ_BS_IN_NA_LOS
        '
        Me.colTC_AI_ADJ_BS_IN_NA_LOS.FieldName = "TC_AI_ADJ_BS_IN_NA_LOS"
        Me.colTC_AI_ADJ_BS_IN_NA_LOS.Name = "colTC_AI_ADJ_BS_IN_NA_LOS"
        '
        'colTC_AI_ADJ_BS_IN_NT_IN
        '
        Me.colTC_AI_ADJ_BS_IN_NT_IN.FieldName = "TC_AI_ADJ_BS_IN_NT_IN"
        Me.colTC_AI_ADJ_BS_IN_NT_IN.Name = "colTC_AI_ADJ_BS_IN_NT_IN"
        '
        'colTC_AI_ADJ_BS_IN_TAX_IN
        '
        Me.colTC_AI_ADJ_BS_IN_TAX_IN.FieldName = "TC_AI_ADJ_BS_IN_TAX_IN"
        Me.colTC_AI_ADJ_BS_IN_TAX_IN.Name = "colTC_AI_ADJ_BS_IN_TAX_IN"
        '
        'colTC_AI_TOT_ADJ_BS_IN
        '
        Me.colTC_AI_TOT_ADJ_BS_IN.FieldName = "TC_AI_TOT_ADJ_BS_IN"
        Me.colTC_AI_TOT_ADJ_BS_IN.Name = "colTC_AI_TOT_ADJ_BS_IN"
        '
        'colTC_AI_ADJ_BS_EXP_INT
        '
        Me.colTC_AI_ADJ_BS_EXP_INT.FieldName = "TC_AI_ADJ_BS_EXP_INT"
        Me.colTC_AI_ADJ_BS_EXP_INT.Name = "colTC_AI_ADJ_BS_EXP_INT"
        '
        'colTC_AI_ADJ_BS_EXP_NA_EXP
        '
        Me.colTC_AI_ADJ_BS_EXP_NA_EXP.FieldName = "TC_AI_ADJ_BS_EXP_NA_EXP"
        Me.colTC_AI_ADJ_BS_EXP_NA_EXP.Name = "colTC_AI_ADJ_BS_EXP_NA_EXP"
        '
        'colTC_AI_ADJ_BS_EXP_RV_EXP
        '
        Me.colTC_AI_ADJ_BS_EXP_RV_EXP.FieldName = "TC_AI_ADJ_BS_EXP_RV_EXP"
        Me.colTC_AI_ADJ_BS_EXP_RV_EXP.Name = "colTC_AI_ADJ_BS_EXP_RV_EXP"
        '
        'colTC_AI_ADJ_BS_EXP_CLAIM
        '
        Me.colTC_AI_ADJ_BS_EXP_CLAIM.FieldName = "TC_AI_ADJ_BS_EXP_CLAIM"
        Me.colTC_AI_ADJ_BS_EXP_CLAIM.Name = "colTC_AI_ADJ_BS_EXP_CLAIM"
        '
        'colTC_AI_TOT_ADJ_BS_EXP
        '
        Me.colTC_AI_TOT_ADJ_BS_EXP.FieldName = "TC_AI_TOT_ADJ_BS_EXP"
        Me.colTC_AI_TOT_ADJ_BS_EXP.Name = "colTC_AI_TOT_ADJ_BS_EXP"
        '
        'colTC_AI_ADJ_IN_LOSS
        '
        Me.colTC_AI_ADJ_IN_LOSS.FieldName = "TC_AI_ADJ_IN_LOSS"
        Me.colTC_AI_ADJ_IN_LOSS.Name = "colTC_AI_ADJ_IN_LOSS"
        '
        'colTC_SI_ADJ_BS_IN
        '
        Me.colTC_SI_ADJ_BS_IN.FieldName = "TC_SI_ADJ_BS_IN"
        Me.colTC_SI_ADJ_BS_IN.Name = "colTC_SI_ADJ_BS_IN"
        '
        'colTC_SI_CA
        '
        Me.colTC_SI_CA.FieldName = "TC_SI_CA"
        Me.colTC_SI_CA.Name = "colTC_SI_CA"
        '
        'colTC_SI_STAT_BS_IN
        '
        Me.colTC_SI_STAT_BS_IN.FieldName = "TC_SI_STAT_BS_IN"
        Me.colTC_SI_STAT_BS_IN.Name = "colTC_SI_STAT_BS_IN"
        '
        'colTC_SI_INVEST_ALLOW
        '
        Me.colTC_SI_INVEST_ALLOW.FieldName = "TC_SI_INVEST_ALLOW"
        Me.colTC_SI_INVEST_ALLOW.Name = "colTC_SI_INVEST_ALLOW"
        '
        'colTC_SI_NET_STAT_IN
        '
        Me.colTC_SI_NET_STAT_IN.FieldName = "TC_SI_NET_STAT_IN"
        Me.colTC_SI_NET_STAT_IN.Name = "colTC_SI_NET_STAT_IN"
        '
        'colTC_SI_SS_RENTAL
        '
        Me.colTC_SI_SS_RENTAL.FieldName = "TC_SI_SS_RENTAL"
        Me.colTC_SI_SS_RENTAL.Name = "colTC_SI_SS_RENTAL"
        '
        'colTC_SI_SS_DIR_EXP
        '
        Me.colTC_SI_SS_DIR_EXP.FieldName = "TC_SI_SS_DIR_EXP"
        Me.colTC_SI_SS_DIR_EXP.Name = "colTC_SI_SS_DIR_EXP"
        '
        'colTC_SI_SS_DIR_EXP_QUIT
        '
        Me.colTC_SI_SS_DIR_EXP_QUIT.FieldName = "TC_SI_SS_DIR_EXP_QUIT"
        Me.colTC_SI_SS_DIR_EXP_QUIT.Name = "colTC_SI_SS_DIR_EXP_QUIT"
        '
        'colTC_SI_SS_DIR_EXP_MAIN
        '
        Me.colTC_SI_SS_DIR_EXP_MAIN.FieldName = "TC_SI_SS_DIR_EXP_MAIN"
        Me.colTC_SI_SS_DIR_EXP_MAIN.Name = "colTC_SI_SS_DIR_EXP_MAIN"
        '
        'colTC_SI_SS_ADJ_IN
        '
        Me.colTC_SI_SS_ADJ_IN.FieldName = "TC_SI_SS_ADJ_IN"
        Me.colTC_SI_SS_ADJ_IN.Name = "colTC_SI_SS_ADJ_IN"
        '
        'colTC_SI_SS_CA
        '
        Me.colTC_SI_SS_CA.FieldName = "TC_SI_SS_CA"
        Me.colTC_SI_SS_CA.Name = "colTC_SI_SS_CA"
        '
        'colTC_SI_SS_STAT_BS_IN
        '
        Me.colTC_SI_SS_STAT_BS_IN.FieldName = "TC_SI_SS_STAT_BS_IN"
        Me.colTC_SI_SS_STAT_BS_IN.Name = "colTC_SI_SS_STAT_BS_IN"
        '
        'colTC_SI_OTH_SOURCE
        '
        Me.colTC_SI_OTH_SOURCE.FieldName = "TC_SI_OTH_SOURCE"
        Me.colTC_SI_OTH_SOURCE.Name = "colTC_SI_OTH_SOURCE"
        '
        'colTC_SI_MAIN_BS
        '
        Me.colTC_SI_MAIN_BS.FieldName = "TC_SI_MAIN_BS"
        Me.colTC_SI_MAIN_BS.Name = "colTC_SI_MAIN_BS"
        '
        'colTC_SI_SEC_BS
        '
        Me.colTC_SI_SEC_BS.FieldName = "TC_SI_SEC_BS"
        Me.colTC_SI_SEC_BS.Name = "colTC_SI_SEC_BS"
        '
        'colTC_SI_OTH_BS
        '
        Me.colTC_SI_OTH_BS.FieldName = "TC_SI_OTH_BS"
        Me.colTC_SI_OTH_BS.Name = "colTC_SI_OTH_BS"
        '
        'colTC_SI_TOT
        '
        Me.colTC_SI_TOT.FieldName = "TC_SI_TOT"
        Me.colTC_SI_TOT.Name = "colTC_SI_TOT"
        '
        'colTC_SI_BS_LOSS_BF
        '
        Me.colTC_SI_BS_LOSS_BF.FieldName = "TC_SI_BS_LOSS_BF"
        Me.colTC_SI_BS_LOSS_BF.Name = "colTC_SI_BS_LOSS_BF"
        '
        'colTC_SI_AGGREGATE
        '
        Me.colTC_SI_AGGREGATE.FieldName = "TC_SI_AGGREGATE"
        Me.colTC_SI_AGGREGATE.Name = "colTC_SI_AGGREGATE"
        '
        'colTC_NB_DIV
        '
        Me.colTC_NB_DIV.FieldName = "TC_NB_DIV"
        Me.colTC_NB_DIV.Name = "colTC_NB_DIV"
        '
        'colTC_NB_DIV_ATT_INT
        '
        Me.colTC_NB_DIV_ATT_INT.FieldName = "TC_NB_DIV_ATT_INT"
        Me.colTC_NB_DIV_ATT_INT.Name = "colTC_NB_DIV_ATT_INT"
        '
        'colTC_NB_DIV_NET
        '
        Me.colTC_NB_DIV_NET.FieldName = "TC_NB_DIV_NET"
        Me.colTC_NB_DIV_NET.Name = "colTC_NB_DIV_NET"
        '
        'colTC_NB_INT
        '
        Me.colTC_NB_INT.FieldName = "TC_NB_INT"
        Me.colTC_NB_INT.Name = "colTC_NB_INT"
        '
        'colTC_NB_INT_ATT_INT
        '
        Me.colTC_NB_INT_ATT_INT.FieldName = "TC_NB_INT_ATT_INT"
        Me.colTC_NB_INT_ATT_INT.Name = "colTC_NB_INT_ATT_INT"
        '
        'colTC_NB_INT_NET
        '
        Me.colTC_NB_INT_NET.FieldName = "TC_NB_INT_NET"
        Me.colTC_NB_INT_NET.Name = "colTC_NB_INT_NET"
        '
        'colTC_NB_RENT
        '
        Me.colTC_NB_RENT.FieldName = "TC_NB_RENT"
        Me.colTC_NB_RENT.Name = "colTC_NB_RENT"
        '
        'colTC_NB_RENT_ATT_INT
        '
        Me.colTC_NB_RENT_ATT_INT.FieldName = "TC_NB_RENT_ATT_INT"
        Me.colTC_NB_RENT_ATT_INT.Name = "colTC_NB_RENT_ATT_INT"
        '
        'colTC_NB_RENT_ASSESS
        '
        Me.colTC_NB_RENT_ASSESS.FieldName = "TC_NB_RENT_ASSESS"
        Me.colTC_NB_RENT_ASSESS.Name = "colTC_NB_RENT_ASSESS"
        '
        'colTC_NB_RENT_QUIT
        '
        Me.colTC_NB_RENT_QUIT.FieldName = "TC_NB_RENT_QUIT"
        Me.colTC_NB_RENT_QUIT.Name = "colTC_NB_RENT_QUIT"
        '
        'colTC_NB_RENT_INSUR
        '
        Me.colTC_NB_RENT_INSUR.FieldName = "TC_NB_RENT_INSUR"
        Me.colTC_NB_RENT_INSUR.Name = "colTC_NB_RENT_INSUR"
        '
        'colTC_NB_RENT_OTH
        '
        Me.colTC_NB_RENT_OTH.FieldName = "TC_NB_RENT_OTH"
        Me.colTC_NB_RENT_OTH.Name = "colTC_NB_RENT_OTH"
        '
        'colTC_NB_RENT_MAIN
        '
        Me.colTC_NB_RENT_MAIN.FieldName = "TC_NB_RENT_MAIN"
        Me.colTC_NB_RENT_MAIN.Name = "colTC_NB_RENT_MAIN"
        '
        'colTC_NB_RENT_AGREE
        '
        Me.colTC_NB_RENT_AGREE.FieldName = "TC_NB_RENT_AGREE"
        Me.colTC_NB_RENT_AGREE.Name = "colTC_NB_RENT_AGREE"
        '
        'colTC_NB_RENT_NET
        '
        Me.colTC_NB_RENT_NET.FieldName = "TC_NB_RENT_NET"
        Me.colTC_NB_RENT_NET.Name = "colTC_NB_RENT_NET"
        '
        'colTC_NB_SUNDRY
        '
        Me.colTC_NB_SUNDRY.FieldName = "TC_NB_SUNDRY"
        Me.colTC_NB_SUNDRY.Name = "colTC_NB_SUNDRY"
        '
        'colTC_NB_OTH_AGGR_STAT
        '
        Me.colTC_NB_OTH_AGGR_STAT.FieldName = "TC_NB_OTH_AGGR_STAT"
        Me.colTC_NB_OTH_AGGR_STAT.Name = "colTC_NB_OTH_AGGR_STAT"
        '
        'colTC_TP_AGGR_IN
        '
        Me.colTC_TP_AGGR_IN.FieldName = "TC_TP_AGGR_IN"
        Me.colTC_TP_AGGR_IN.Name = "colTC_TP_AGGR_IN"
        '
        'colTC_TP_CURR_LOSS
        '
        Me.colTC_TP_CURR_LOSS.FieldName = "TC_TP_CURR_LOSS"
        Me.colTC_TP_CURR_LOSS.Name = "colTC_TP_CURR_LOSS"
        '
        'colTC_TP_AGGR_IN_LOSS
        '
        Me.colTC_TP_AGGR_IN_LOSS.FieldName = "TC_TP_AGGR_IN_LOSS"
        Me.colTC_TP_AGGR_IN_LOSS.Name = "colTC_TP_AGGR_IN_LOSS"
        '
        'colTC_TP_APRV_DONATION
        '
        Me.colTC_TP_APRV_DONATION.FieldName = "TC_TP_APRV_DONATION"
        Me.colTC_TP_APRV_DONATION.Name = "colTC_TP_APRV_DONATION"
        '
        'colTC_TP_CHARGEABLE
        '
        Me.colTC_TP_CHARGEABLE.FieldName = "TC_TP_CHARGEABLE"
        Me.colTC_TP_CHARGEABLE.Name = "colTC_TP_CHARGEABLE"
        '
        'colTC_TP_28_CHARGEABLE
        '
        Me.colTC_TP_28_CHARGEABLE.FieldName = "TC_TP_28_CHARGEABLE"
        Me.colTC_TP_28_CHARGEABLE.Name = "colTC_TP_28_CHARGEABLE"
        '
        'colTC_TP_SEC110
        '
        Me.colTC_TP_SEC110.FieldName = "TC_TP_SEC110"
        Me.colTC_TP_SEC110.Name = "colTC_TP_SEC110"
        '
        'colTC_TP_SEC132
        '
        Me.colTC_TP_SEC132.FieldName = "TC_TP_SEC132"
        Me.colTC_TP_SEC132.Name = "colTC_TP_SEC132"
        '
        'colTC_TP_SEC133
        '
        Me.colTC_TP_SEC133.FieldName = "TC_TP_SEC133"
        Me.colTC_TP_SEC133.Name = "colTC_TP_SEC133"
        '
        'colTC_TP_TOT_SETOFF
        '
        Me.colTC_TP_TOT_SETOFF.FieldName = "TC_TP_TOT_SETOFF"
        Me.colTC_TP_TOT_SETOFF.Name = "colTC_TP_TOT_SETOFF"
        '
        'colTC_TP_PAYABLE
        '
        Me.colTC_TP_PAYABLE.FieldName = "TC_TP_PAYABLE"
        Me.colTC_TP_PAYABLE.Name = "colTC_TP_PAYABLE"
        '
        'colTC_TP_INSTALL
        '
        Me.colTC_TP_INSTALL.FieldName = "TC_TP_INSTALL"
        Me.colTC_TP_INSTALL.Name = "colTC_TP_INSTALL"
        '
        'colTC_TP_PAYABLE_BAL
        '
        Me.colTC_TP_PAYABLE_BAL.FieldName = "TC_TP_PAYABLE_BAL"
        Me.colTC_TP_PAYABLE_BAL.Name = "colTC_TP_PAYABLE_BAL"
        '
        'colTC_CB_CA_BAL_BF
        '
        Me.colTC_CB_CA_BAL_BF.FieldName = "TC_CB_CA_BAL_BF"
        Me.colTC_CB_CA_BAL_BF.Name = "colTC_CB_CA_BAL_BF"
        '
        'colTC_CB_CA_CURR
        '
        Me.colTC_CB_CA_CURR.FieldName = "TC_CB_CA_CURR"
        Me.colTC_CB_CA_CURR.Name = "colTC_CB_CA_CURR"
        '
        'colTC_CB_CA_AA
        '
        Me.colTC_CB_CA_AA.FieldName = "TC_CB_CA_AA"
        Me.colTC_CB_CA_AA.Name = "colTC_CB_CA_AA"
        '
        'colTC_CB_CA_IA
        '
        Me.colTC_CB_CA_IA.FieldName = "TC_CB_CA_IA"
        Me.colTC_CB_CA_IA.Name = "colTC_CB_CA_IA"
        '
        'colTC_CB_CA_BA
        '
        Me.colTC_CB_CA_BA.FieldName = "TC_CB_CA_BA"
        Me.colTC_CB_CA_BA.Name = "colTC_CB_CA_BA"
        '
        'colTC_CB_CA_UTIL
        '
        Me.colTC_CB_CA_UTIL.FieldName = "TC_CB_CA_UTIL"
        Me.colTC_CB_CA_UTIL.Name = "colTC_CB_CA_UTIL"
        '
        'colTC_CB_CA_BAL_CF
        '
        Me.colTC_CB_CA_BAL_CF.FieldName = "TC_CB_CA_BAL_CF"
        Me.colTC_CB_CA_BAL_CF.Name = "colTC_CB_CA_BAL_CF"
        '
        'colTC_CB_LS_BAL_BF
        '
        Me.colTC_CB_LS_BAL_BF.FieldName = "TC_CB_LS_BAL_BF"
        Me.colTC_CB_LS_BAL_BF.Name = "colTC_CB_LS_BAL_BF"
        '
        'colTC_CB_LS_UTIL
        '
        Me.colTC_CB_LS_UTIL.FieldName = "TC_CB_LS_UTIL"
        Me.colTC_CB_LS_UTIL.Name = "colTC_CB_LS_UTIL"
        '
        'colTC_CB_LS_BAL_UTIL
        '
        Me.colTC_CB_LS_BAL_UTIL.FieldName = "TC_CB_LS_BAL_UTIL"
        Me.colTC_CB_LS_BAL_UTIL.Name = "colTC_CB_LS_BAL_UTIL"
        '
        'colTC_CB_LS_UNABSORBED
        '
        Me.colTC_CB_LS_UNABSORBED.FieldName = "TC_CB_LS_UNABSORBED"
        Me.colTC_CB_LS_UNABSORBED.Name = "colTC_CB_LS_UNABSORBED"
        '
        'colTC_CB_LS_BAL_CF
        '
        Me.colTC_CB_LS_BAL_CF.FieldName = "TC_CB_LS_BAL_CF"
        Me.colTC_CB_LS_BAL_CF.Name = "colTC_CB_LS_BAL_CF"
        '
        'colTC_CB_ITA_BAL_BF
        '
        Me.colTC_CB_ITA_BAL_BF.FieldName = "TC_CB_ITA_BAL_BF"
        Me.colTC_CB_ITA_BAL_BF.Name = "colTC_CB_ITA_BAL_BF"
        '
        'colTC_CB_ITA_CURR
        '
        Me.colTC_CB_ITA_CURR.FieldName = "TC_CB_ITA_CURR"
        Me.colTC_CB_ITA_CURR.Name = "colTC_CB_ITA_CURR"
        '
        'colTC_CB_ITA_BAL_BF_CURR
        '
        Me.colTC_CB_ITA_BAL_BF_CURR.FieldName = "TC_CB_ITA_BAL_BF_CURR"
        Me.colTC_CB_ITA_BAL_BF_CURR.Name = "colTC_CB_ITA_BAL_BF_CURR"
        '
        'colTC_CB_ITA_UTIL
        '
        Me.colTC_CB_ITA_UTIL.FieldName = "TC_CB_ITA_UTIL"
        Me.colTC_CB_ITA_UTIL.Name = "colTC_CB_ITA_UTIL"
        '
        'colTC_CB_ITA_BAL_CF
        '
        Me.colTC_CB_ITA_BAL_CF.FieldName = "TC_CB_ITA_BAL_CF"
        Me.colTC_CB_ITA_BAL_CF.Name = "colTC_CB_ITA_BAL_CF"
        '
        'colTC_AI_OTH_BS_IN
        '
        Me.colTC_AI_OTH_BS_IN.FieldName = "TC_AI_OTH_BS_IN"
        Me.colTC_AI_OTH_BS_IN.Name = "colTC_AI_OTH_BS_IN"
        '
        'colTC_TP_RATE1
        '
        Me.colTC_TP_RATE1.FieldName = "TC_TP_RATE1"
        Me.colTC_TP_RATE1.Name = "colTC_TP_RATE1"
        '
        'colTC_TP_RATE2
        '
        Me.colTC_TP_RATE2.FieldName = "TC_TP_RATE2"
        Me.colTC_TP_RATE2.Name = "colTC_TP_RATE2"
        '
        'colTC_TP_RATE3
        '
        Me.colTC_TP_RATE3.FieldName = "TC_TP_RATE3"
        Me.colTC_TP_RATE3.Name = "colTC_TP_RATE3"
        '
        'colTC_TP_RATE4
        '
        Me.colTC_TP_RATE4.FieldName = "TC_TP_RATE4"
        Me.colTC_TP_RATE4.Name = "colTC_TP_RATE4"
        '
        'colTC_TP_RATE5
        '
        Me.colTC_TP_RATE5.FieldName = "TC_TP_RATE5"
        Me.colTC_TP_RATE5.Name = "colTC_TP_RATE5"
        '
        'colTC_TP_RATE6
        '
        Me.colTC_TP_RATE6.FieldName = "TC_TP_RATE6"
        Me.colTC_TP_RATE6.Name = "colTC_TP_RATE6"
        '
        'colTC_TP_APP_CHARGEABLE1
        '
        Me.colTC_TP_APP_CHARGEABLE1.FieldName = "TC_TP_APP_CHARGEABLE1"
        Me.colTC_TP_APP_CHARGEABLE1.Name = "colTC_TP_APP_CHARGEABLE1"
        '
        'colTC_TP_APP_CHARGEABLE2
        '
        Me.colTC_TP_APP_CHARGEABLE2.FieldName = "TC_TP_APP_CHARGEABLE2"
        Me.colTC_TP_APP_CHARGEABLE2.Name = "colTC_TP_APP_CHARGEABLE2"
        '
        'colTC_TP_APP_CHARGEABLE3
        '
        Me.colTC_TP_APP_CHARGEABLE3.FieldName = "TC_TP_APP_CHARGEABLE3"
        Me.colTC_TP_APP_CHARGEABLE3.Name = "colTC_TP_APP_CHARGEABLE3"
        '
        'colTC_TP_APP_CHARGEABLE4
        '
        Me.colTC_TP_APP_CHARGEABLE4.FieldName = "TC_TP_APP_CHARGEABLE4"
        Me.colTC_TP_APP_CHARGEABLE4.Name = "colTC_TP_APP_CHARGEABLE4"
        '
        'colTC_TP_APP_CHARGEABLE5
        '
        Me.colTC_TP_APP_CHARGEABLE5.FieldName = "TC_TP_APP_CHARGEABLE5"
        Me.colTC_TP_APP_CHARGEABLE5.Name = "colTC_TP_APP_CHARGEABLE5"
        '
        'colTC_TP_APP_CHARGEABLE6
        '
        Me.colTC_TP_APP_CHARGEABLE6.FieldName = "TC_TP_APP_CHARGEABLE6"
        Me.colTC_TP_APP_CHARGEABLE6.Name = "colTC_TP_APP_CHARGEABLE6"
        '
        'colTC_TP_RATE1_CHARGEABLE
        '
        Me.colTC_TP_RATE1_CHARGEABLE.FieldName = "TC_TP_RATE1_CHARGEABLE"
        Me.colTC_TP_RATE1_CHARGEABLE.Name = "colTC_TP_RATE1_CHARGEABLE"
        '
        'colTC_TP_RATE2_CHARGEABLE
        '
        Me.colTC_TP_RATE2_CHARGEABLE.FieldName = "TC_TP_RATE2_CHARGEABLE"
        Me.colTC_TP_RATE2_CHARGEABLE.Name = "colTC_TP_RATE2_CHARGEABLE"
        '
        'colTC_TP_RATE3_CHARGEABLE
        '
        Me.colTC_TP_RATE3_CHARGEABLE.FieldName = "TC_TP_RATE3_CHARGEABLE"
        Me.colTC_TP_RATE3_CHARGEABLE.Name = "colTC_TP_RATE3_CHARGEABLE"
        '
        'colTC_TP_RATE4_CHARGEABLE
        '
        Me.colTC_TP_RATE4_CHARGEABLE.FieldName = "TC_TP_RATE4_CHARGEABLE"
        Me.colTC_TP_RATE4_CHARGEABLE.Name = "colTC_TP_RATE4_CHARGEABLE"
        '
        'colTC_TP_RATE5_CHARGEABLE
        '
        Me.colTC_TP_RATE5_CHARGEABLE.FieldName = "TC_TP_RATE5_CHARGEABLE"
        Me.colTC_TP_RATE5_CHARGEABLE.Name = "colTC_TP_RATE5_CHARGEABLE"
        '
        'colTC_TP_TOT_TAX_CHARGED
        '
        Me.colTC_TP_TOT_TAX_CHARGED.FieldName = "TC_TP_TOT_TAX_CHARGED"
        Me.colTC_TP_TOT_TAX_CHARGED.Name = "colTC_TP_TOT_TAX_CHARGED"
        '
        'colTC_TP_SEC6B_REBATE
        '
        Me.colTC_TP_SEC6B_REBATE.FieldName = "TC_TP_SEC6B_REBATE"
        Me.colTC_TP_SEC6B_REBATE.Name = "colTC_TP_SEC6B_REBATE"
        '
        'colTC_TP_SEC110_OTHERS
        '
        Me.colTC_TP_SEC110_OTHERS.FieldName = "TC_TP_SEC110_OTHERS"
        Me.colTC_TP_SEC110_OTHERS.Name = "colTC_TP_SEC110_OTHERS"
        '
        'colTC_TP_PROSPECTING
        '
        Me.colTC_TP_PROSPECTING.FieldName = "TC_TP_PROSPECTING"
        Me.colTC_TP_PROSPECTING.Name = "colTC_TP_PROSPECTING"
        '
        'colTC_TP_QUALIFY_AGRICULTURE
        '
        Me.colTC_TP_QUALIFY_AGRICULTURE.FieldName = "TC_TP_QUALIFY_AGRICULTURE"
        Me.colTC_TP_QUALIFY_AGRICULTURE.Name = "colTC_TP_QUALIFY_AGRICULTURE"
        '
        'colTC_TP_PREOP_BS
        '
        Me.colTC_TP_PREOP_BS.FieldName = "TC_TP_PREOP_BS"
        Me.colTC_TP_PREOP_BS.Name = "colTC_TP_PREOP_BS"
        '
        'colTC_TP_FOOD_PRODUCTION
        '
        Me.colTC_TP_FOOD_PRODUCTION.FieldName = "TC_TP_FOOD_PRODUCTION"
        Me.colTC_TP_FOOD_PRODUCTION.Name = "colTC_TP_FOOD_PRODUCTION"
        '
        'colTC_TP_EXP_ALLOWED
        '
        Me.colTC_TP_EXP_ALLOWED.FieldName = "TC_TP_EXP_ALLOWED"
        Me.colTC_TP_EXP_ALLOWED.Name = "colTC_TP_EXP_ALLOWED"
        '
        'colTC_TP_TOTAL_OTH_EXP
        '
        Me.colTC_TP_TOTAL_OTH_EXP.FieldName = "TC_TP_TOTAL_OTH_EXP"
        Me.colTC_TP_TOTAL_OTH_EXP.Name = "colTC_TP_TOTAL_OTH_EXP"
        '
        'colTC_TP_TOTAL_INCOME
        '
        Me.colTC_TP_TOTAL_INCOME.FieldName = "TC_TP_TOTAL_INCOME"
        Me.colTC_TP_TOTAL_INCOME.Name = "colTC_TP_TOTAL_INCOME"
        '
        'colTC_TP_PIONEER_CHARGE
        '
        Me.colTC_TP_PIONEER_CHARGE.FieldName = "TC_TP_PIONEER_CHARGE"
        Me.colTC_TP_PIONEER_CHARGE.Name = "colTC_TP_PIONEER_CHARGE"
        '
        'colTC_TP_OPERATIONALHQ_CHARGE
        '
        Me.colTC_TP_OPERATIONALHQ_CHARGE.FieldName = "TC_TP_OPERATIONALHQ_CHARGE"
        Me.colTC_TP_OPERATIONALHQ_CHARGE.Name = "colTC_TP_OPERATIONALHQ_CHARGE"
        '
        'colTC_TP_FOREIGN_CHARGE
        '
        Me.colTC_TP_FOREIGN_CHARGE.FieldName = "TC_TP_FOREIGN_CHARGE"
        Me.colTC_TP_FOREIGN_CHARGE.Name = "colTC_TP_FOREIGN_CHARGE"
        '
        'colTC_TP_BS_LOSS
        '
        Me.colTC_TP_BS_LOSS.FieldName = "TC_TP_BS_LOSS"
        Me.colTC_TP_BS_LOSS.Name = "colTC_TP_BS_LOSS"
        '
        'colTC_NB_ROYALTY
        '
        Me.colTC_NB_ROYALTY.FieldName = "TC_NB_ROYALTY"
        Me.colTC_NB_ROYALTY.Name = "colTC_NB_ROYALTY"
        '
        'colTC_NB_ADDITION
        '
        Me.colTC_NB_ADDITION.FieldName = "TC_NB_ADDITION"
        Me.colTC_NB_ADDITION.Name = "colTC_NB_ADDITION"
        '
        'colTC_CB_LS_ADJUST_LOSS
        '
        Me.colTC_CB_LS_ADJUST_LOSS.FieldName = "TC_CB_LS_ADJUST_LOSS"
        Me.colTC_CB_LS_ADJUST_LOSS.Name = "colTC_CB_LS_ADJUST_LOSS"
        '
        'colTC_CB_LS_UTIL_CURR
        '
        Me.colTC_CB_LS_UTIL_CURR.FieldName = "TC_CB_LS_UTIL_CURR"
        Me.colTC_CB_LS_UTIL_CURR.Name = "colTC_CB_LS_UTIL_CURR"
        '
        'colTC_SI_RA
        '
        Me.colTC_SI_RA.FieldName = "TC_SI_RA"
        Me.colTC_SI_RA.Name = "colTC_SI_RA"
        '
        'colTC_CB_RA_BAL_BF
        '
        Me.colTC_CB_RA_BAL_BF.FieldName = "TC_CB_RA_BAL_BF"
        Me.colTC_CB_RA_BAL_BF.Name = "colTC_CB_RA_BAL_BF"
        '
        'colTC_CB_RA_CURR
        '
        Me.colTC_CB_RA_CURR.FieldName = "TC_CB_RA_CURR"
        Me.colTC_CB_RA_CURR.Name = "colTC_CB_RA_CURR"
        '
        'colTC_CB_RA_BAL_BF_CURR
        '
        Me.colTC_CB_RA_BAL_BF_CURR.FieldName = "TC_CB_RA_BAL_BF_CURR"
        Me.colTC_CB_RA_BAL_BF_CURR.Name = "colTC_CB_RA_BAL_BF_CURR"
        '
        'colTC_CB_RA_UTIL
        '
        Me.colTC_CB_RA_UTIL.FieldName = "TC_CB_RA_UTIL"
        Me.colTC_CB_RA_UTIL.Name = "colTC_CB_RA_UTIL"
        '
        'colTC_CB_RA_BAL_CF
        '
        Me.colTC_CB_RA_BAL_CF.FieldName = "TC_CB_RA_BAL_CF"
        Me.colTC_CB_RA_BAL_CF.Name = "colTC_CB_RA_BAL_CF"
        '
        'colTC_SI_BC
        '
        Me.colTC_SI_BC.FieldName = "TC_SI_BC"
        Me.colTC_SI_BC.Name = "colTC_SI_BC"
        '
        'colTC_SI_ADJ_BS_IN_BC
        '
        Me.colTC_SI_ADJ_BS_IN_BC.FieldName = "TC_SI_ADJ_BS_IN_BC"
        Me.colTC_SI_ADJ_BS_IN_BC.Name = "colTC_SI_ADJ_BS_IN_BC"
        '
        'colTC_CB_CA_CURR_BA
        '
        Me.colTC_CB_CA_CURR_BA.FieldName = "TC_CB_CA_CURR_BA"
        Me.colTC_CB_CA_CURR_BA.Name = "colTC_CB_CA_CURR_BA"
        '
        'colTC_TP_RATE4A
        '
        Me.colTC_TP_RATE4A.FieldName = "TC_TP_RATE4A"
        Me.colTC_TP_RATE4A.Name = "colTC_TP_RATE4A"
        '
        'colTC_TP_APP_CHARGEABLE4A
        '
        Me.colTC_TP_APP_CHARGEABLE4A.FieldName = "TC_TP_APP_CHARGEABLE4A"
        Me.colTC_TP_APP_CHARGEABLE4A.Name = "colTC_TP_APP_CHARGEABLE4A"
        '
        'colTC_TP_RATE4A_CHARGEABLE
        '
        Me.colTC_TP_RATE4A_CHARGEABLE.FieldName = "TC_TP_RATE4A_CHARGEABLE"
        Me.colTC_TP_RATE4A_CHARGEABLE.Name = "colTC_TP_RATE4A_CHARGEABLE"
        '
        'colTC_CB_CA_NA
        '
        Me.colTC_CB_CA_NA.FieldName = "TC_CB_CA_NA"
        Me.colTC_CB_CA_NA.Name = "colTC_CB_CA_NA"
        '
        'colTC_TP_ZAKAT
        '
        Me.colTC_TP_ZAKAT.FieldName = "TC_TP_ZAKAT"
        Me.colTC_TP_ZAKAT.Name = "colTC_TP_ZAKAT"
        '
        'colTC_OTHERDEDUCTION
        '
        Me.colTC_OTHERDEDUCTION.FieldName = "TC_OTHERDEDUCTION"
        Me.colTC_OTHERDEDUCTION.Name = "colTC_OTHERDEDUCTION"
        '
        'colTC_CB_CA_DISALLOW
        '
        Me.colTC_CB_CA_DISALLOW.FieldName = "TC_CB_CA_DISALLOW"
        Me.colTC_CB_CA_DISALLOW.Name = "colTC_CB_CA_DISALLOW"
        '
        'colTC_CB_CA_ABAL_CF
        '
        Me.colTC_CB_CA_ABAL_CF.FieldName = "TC_CB_CA_ABAL_CF"
        Me.colTC_CB_CA_ABAL_CF.Name = "colTC_CB_CA_ABAL_CF"
        '
        'colTC_CB_CHECK
        '
        Me.colTC_CB_CHECK.FieldName = "TC_CB_CHECK"
        Me.colTC_CB_CHECK.Name = "colTC_CB_CHECK"
        '
        'colTC_TP_CLAIM
        '
        Me.colTC_TP_CLAIM.FieldName = "TC_TP_CLAIM"
        Me.colTC_TP_CLAIM.Name = "colTC_TP_CLAIM"
        '
        'colTC_CB_LS_SAMOUNT
        '
        Me.colTC_CB_LS_SAMOUNT.FieldName = "TC_CB_LS_SAMOUNT"
        Me.colTC_CB_LS_SAMOUNT.Name = "colTC_CB_LS_SAMOUNT"
        '
        'colTC_CB_LS_BALS_CF
        '
        Me.colTC_CB_LS_BALS_CF.FieldName = "TC_CB_LS_BALS_CF"
        Me.colTC_CB_LS_BALS_CF.Name = "colTC_CB_LS_BALS_CF"
        '
        'colTC_CB_LS_D_BL
        '
        Me.colTC_CB_LS_D_BL.FieldName = "TC_CB_LS_D_BL"
        Me.colTC_CB_LS_D_BL.Name = "colTC_CB_LS_D_BL"
        '
        'colTC_CB_LS_SRDAMT2
        '
        Me.colTC_CB_LS_SRDAMT2.FieldName = "TC_CB_LS_SRDAMT2"
        Me.colTC_CB_LS_SRDAMT2.Name = "colTC_CB_LS_SRDAMT2"
        '
        'colTC_CB_LS_BLNBF
        '
        Me.colTC_CB_LS_BLNBF.FieldName = "TC_CB_LS_BLNBF"
        Me.colTC_CB_LS_BLNBF.Name = "colTC_CB_LS_BLNBF"
        '
        'colTC_CB_LS_AMTTUT
        '
        Me.colTC_CB_LS_AMTTUT.FieldName = "TC_CB_LS_AMTTUT"
        Me.colTC_CB_LS_AMTTUT.Name = "colTC_CB_LS_AMTTUT"
        '
        'colTC_CB_LS_BLNCF
        '
        Me.colTC_CB_LS_BLNCF.FieldName = "TC_CB_LS_BLNCF"
        Me.colTC_CB_LS_BLNCF.Name = "colTC_CB_LS_BLNCF"
        '
        'colTC_COMPANY
        '
        Me.colTC_COMPANY.FieldName = "TC_COMPANY"
        Me.colTC_COMPANY.Name = "colTC_COMPANY"
        '
        'colTC_PIONEERDESC
        '
        Me.colTC_PIONEERDESC.FieldName = "TC_PIONEERDESC"
        Me.colTC_PIONEERDESC.Name = "colTC_PIONEERDESC"
        '
        'colTC_PIO
        '
        Me.colTC_PIO.FieldName = "TC_PIO"
        Me.colTC_PIO.Name = "colTC_PIO"
        '
        'colTC_PIONEER
        '
        Me.colTC_PIONEER.FieldName = "TC_PIONEER"
        Me.colTC_PIONEER.Name = "colTC_PIONEER"
        '
        'colTC_RA_RATE1
        '
        Me.colTC_RA_RATE1.FieldName = "TC_RA_RATE1"
        Me.colTC_RA_RATE1.Name = "colTC_RA_RATE1"
        '
        'colTC_RA_QUALIFYINGCAPITALEXP
        '
        Me.colTC_RA_QUALIFYINGCAPITALEXP.FieldName = "TC_RA_QUALIFYINGCAPITALEXP"
        Me.colTC_RA_QUALIFYINGCAPITALEXP.Name = "colTC_RA_QUALIFYINGCAPITALEXP"
        '
        'colTC_RA_QUALIFYINGCAPITALEXP_AMOUNT
        '
        Me.colTC_RA_QUALIFYINGCAPITALEXP_AMOUNT.FieldName = "TC_RA_QUALIFYINGCAPITALEXP_AMOUNT"
        Me.colTC_RA_QUALIFYINGCAPITALEXP_AMOUNT.Name = "colTC_RA_QUALIFYINGCAPITALEXP_AMOUNT"
        '
        'colTC_RA_BALANCINGALLOWANCE
        '
        Me.colTC_RA_BALANCINGALLOWANCE.FieldName = "TC_RA_BALANCINGALLOWANCE"
        Me.colTC_RA_BALANCINGALLOWANCE.Name = "colTC_RA_BALANCINGALLOWANCE"
        '
        'colTC_RA_TOTAL1
        '
        Me.colTC_RA_TOTAL1.FieldName = "TC_RA_TOTAL1"
        Me.colTC_RA_TOTAL1.Name = "colTC_RA_TOTAL1"
        '
        'colTC_RA_RESTRICTRATE
        '
        Me.colTC_RA_RESTRICTRATE.FieldName = "TC_RA_RESTRICTRATE"
        Me.colTC_RA_RESTRICTRATE.Name = "colTC_RA_RESTRICTRATE"
        '
        'colTC_RA_RESTRICTAMOUNT
        '
        Me.colTC_RA_RESTRICTAMOUNT.FieldName = "TC_RA_RESTRICTAMOUNT"
        Me.colTC_RA_RESTRICTAMOUNT.Name = "colTC_RA_RESTRICTAMOUNT"
        '
        'colTC_ITA_RATE1
        '
        Me.colTC_ITA_RATE1.FieldName = "TC_ITA_RATE1"
        Me.colTC_ITA_RATE1.Name = "colTC_ITA_RATE1"
        '
        'colTC_ITA_QUALIFYINGCAPITALEXP
        '
        Me.colTC_ITA_QUALIFYINGCAPITALEXP.FieldName = "TC_ITA_QUALIFYINGCAPITALEXP"
        Me.colTC_ITA_QUALIFYINGCAPITALEXP.Name = "colTC_ITA_QUALIFYINGCAPITALEXP"
        '
        'colTC_ITA_QUALIFYINGCAPITALEXP_AMOUNT
        '
        Me.colTC_ITA_QUALIFYINGCAPITALEXP_AMOUNT.FieldName = "TC_ITA_QUALIFYINGCAPITALEXP_AMOUNT"
        Me.colTC_ITA_QUALIFYINGCAPITALEXP_AMOUNT.Name = "colTC_ITA_QUALIFYINGCAPITALEXP_AMOUNT"
        '
        'colTC_ITA_BALANCINGALLOWANCE
        '
        Me.colTC_ITA_BALANCINGALLOWANCE.FieldName = "TC_ITA_BALANCINGALLOWANCE"
        Me.colTC_ITA_BALANCINGALLOWANCE.Name = "colTC_ITA_BALANCINGALLOWANCE"
        '
        'colTC_ITA_TOTAL1
        '
        Me.colTC_ITA_TOTAL1.FieldName = "TC_ITA_TOTAL1"
        Me.colTC_ITA_TOTAL1.Name = "colTC_ITA_TOTAL1"
        '
        'colTC_ITA_RESTRICTRATE
        '
        Me.colTC_ITA_RESTRICTRATE.FieldName = "TC_ITA_RESTRICTRATE"
        Me.colTC_ITA_RESTRICTRATE.Name = "colTC_ITA_RESTRICTRATE"
        '
        'colTC_ITA_RESTRICTAMOUNT
        '
        Me.colTC_ITA_RESTRICTAMOUNT.FieldName = "TC_ITA_RESTRICTAMOUNT"
        Me.colTC_ITA_RESTRICTAMOUNT.Name = "colTC_ITA_RESTRICTAMOUNT"
        '
        'colTC_DISALLOW_NOTE
        '
        Me.colTC_DISALLOW_NOTE.FieldName = "TC_DISALLOW_NOTE"
        Me.colTC_DISALLOW_NOTE.Name = "colTC_DISALLOW_NOTE"
        '
        'colTC_DISALLOWBUSINESS_NOTE
        '
        Me.colTC_DISALLOWBUSINESS_NOTE.FieldName = "TC_DISALLOWBUSINESS_NOTE"
        Me.colTC_DISALLOWBUSINESS_NOTE.Name = "colTC_DISALLOWBUSINESS_NOTE"
        '
        'colTC_SURPLUSRECOVERED
        '
        Me.colTC_SURPLUSRECOVERED.FieldName = "TC_SURPLUSRECOVERED"
        Me.colTC_SURPLUSRECOVERED.Name = "colTC_SURPLUSRECOVERED"
        '
        'colTC_MININGALLOWNANCE
        '
        Me.colTC_MININGALLOWNANCE.FieldName = "TC_MININGALLOWNANCE"
        Me.colTC_MININGALLOWNANCE.Name = "colTC_MININGALLOWNANCE"
        '
        'colTC_MININGEXPENSES
        '
        Me.colTC_MININGEXPENSES.FieldName = "TC_MININGEXPENSES"
        Me.colTC_MININGEXPENSES.Name = "colTC_MININGEXPENSES"
        '
        'colTC_STAT_DIVIDEND
        '
        Me.colTC_STAT_DIVIDEND.FieldName = "TC_STAT_DIVIDEND"
        Me.colTC_STAT_DIVIDEND.Name = "colTC_STAT_DIVIDEND"
        '
        'colTC_TP_SEC110B
        '
        Me.colTC_TP_SEC110B.FieldName = "TC_TP_SEC110B"
        Me.colTC_TP_SEC110B.Name = "colTC_TP_SEC110B"
        '
        'colTC_NB_RENT_OTH2
        '
        Me.colTC_NB_RENT_OTH2.FieldName = "TC_NB_RENT_OTH2"
        Me.colTC_NB_RENT_OTH2.Name = "colTC_NB_RENT_OTH2"
        '
        'colTC_NB_CARRYBCKLOSS
        '
        Me.colTC_NB_CARRYBCKLOSS.FieldName = "TC_NB_CARRYBCKLOSS"
        Me.colTC_NB_CARRYBCKLOSS.Name = "colTC_NB_CARRYBCKLOSS"
        '
        'colTC_NB_AMTNOTCARRYBCK
        '
        Me.colTC_NB_AMTNOTCARRYBCK.FieldName = "TC_NB_AMTNOTCARRYBCK"
        Me.colTC_NB_AMTNOTCARRYBCK.Name = "colTC_NB_AMTNOTCARRYBCK"
        '
        'colTC_NB_CHKCB
        '
        Me.colTC_NB_CHKCB.FieldName = "TC_NB_CHKCB"
        Me.colTC_NB_CHKCB.Name = "colTC_NB_CHKCB"
        '
        'colTC_TP_INCOME_TP2
        '
        Me.colTC_TP_INCOME_TP2.FieldName = "TC_TP_INCOME_TP2"
        Me.colTC_TP_INCOME_TP2.Name = "colTC_TP_INCOME_TP2"
        '
        'colTC_TP_ESTIMATED_TP
        '
        Me.colTC_TP_ESTIMATED_TP.FieldName = "TC_TP_ESTIMATED_TP"
        Me.colTC_TP_ESTIMATED_TP.Name = "colTC_TP_ESTIMATED_TP"
        '
        'colTC_TP_INCOME_TP3
        '
        Me.colTC_TP_INCOME_TP3.FieldName = "TC_TP_INCOME_TP3"
        Me.colTC_TP_INCOME_TP3.Name = "colTC_TP_INCOME_TP3"
        '
        'colTC_TP_ALL_DIFF
        '
        Me.colTC_TP_ALL_DIFF.FieldName = "TC_TP_ALL_DIFF"
        Me.colTC_TP_ALL_DIFF.Name = "colTC_TP_ALL_DIFF"
        '
        'colTC_TP_EX_DIFF
        '
        Me.colTC_TP_EX_DIFF.FieldName = "TC_TP_EX_DIFF"
        Me.colTC_TP_EX_DIFF.Name = "colTC_TP_EX_DIFF"
        '
        'colTC_TP_PEN_DIFF
        '
        Me.colTC_TP_PEN_DIFF.FieldName = "TC_TP_PEN_DIFF"
        Me.colTC_TP_PEN_DIFF.Name = "colTC_TP_PEN_DIFF"
        '
        'colTC_WITHRAITA
        '
        Me.colTC_WITHRAITA.FieldName = "TC_WITHRAITA"
        Me.colTC_WITHRAITA.Name = "colTC_WITHRAITA"
        '
        'colTC_RA_WITHDRAWAL
        '
        Me.colTC_RA_WITHDRAWAL.FieldName = "TC_RA_WITHDRAWAL"
        Me.colTC_RA_WITHDRAWAL.Name = "colTC_RA_WITHDRAWAL"
        '
        'colTC_RA_ADJUSTMENT
        '
        Me.colTC_RA_ADJUSTMENT.FieldName = "TC_RA_ADJUSTMENT"
        Me.colTC_RA_ADJUSTMENT.Name = "colTC_RA_ADJUSTMENT"
        '
        'colTC_ITA_WITHDRAWAL
        '
        Me.colTC_ITA_WITHDRAWAL.FieldName = "TC_ITA_WITHDRAWAL"
        Me.colTC_ITA_WITHDRAWAL.Name = "colTC_ITA_WITHDRAWAL"
        '
        'colTC_ITA_ADJUSTMENT
        '
        Me.colTC_ITA_ADJUSTMENT.FieldName = "TC_ITA_ADJUSTMENT"
        Me.colTC_ITA_ADJUSTMENT.Name = "colTC_ITA_ADJUSTMENT"
        '
        'colTC_NB_DIV_OTH
        '
        Me.colTC_NB_DIV_OTH.FieldName = "TC_NB_DIV_OTH"
        Me.colTC_NB_DIV_OTH.Name = "colTC_NB_DIV_OTH"
        '
        'colTC_NB_INT_OTH
        '
        Me.colTC_NB_INT_OTH.FieldName = "TC_NB_INT_OTH"
        Me.colTC_NB_INT_OTH.Name = "colTC_NB_INT_OTH"
        '
        'colTC_SUNDRY_EXP
        '
        Me.colTC_SUNDRY_EXP.FieldName = "TC_SUNDRY_EXP"
        Me.colTC_SUNDRY_EXP.Name = "colTC_SUNDRY_EXP"
        '
        'colTC_CHK_EXEMP
        '
        Me.colTC_CHK_EXEMP.FieldName = "TC_CHK_EXEMP"
        Me.colTC_CHK_EXEMP.Name = "colTC_CHK_EXEMP"
        '
        'colTC_SI_TOT_PARTNERSHIP
        '
        Me.colTC_SI_TOT_PARTNERSHIP.FieldName = "TC_SI_TOT_PARTNERSHIP"
        Me.colTC_SI_TOT_PARTNERSHIP.Name = "colTC_SI_TOT_PARTNERSHIP"
        '
        'colTC_CB_CA_ACA
        '
        Me.colTC_CB_CA_ACA.FieldName = "TC_CB_CA_ACA"
        Me.colTC_CB_CA_ACA.Name = "colTC_CB_CA_ACA"
        '
        'colTC_NB_RENTIBA
        '
        Me.colTC_NB_RENTIBA.FieldName = "TC_NB_RENTIBA"
        Me.colTC_NB_RENTIBA.Name = "colTC_NB_RENTIBA"
        '
        'colTC_NB_RENTIBA_ATT_IN
        '
        Me.colTC_NB_RENTIBA_ATT_IN.FieldName = "TC_NB_RENTIBA_ATT_IN"
        Me.colTC_NB_RENTIBA_ATT_IN.Name = "colTC_NB_RENTIBA_ATT_IN"
        '
        'colTC_NB_RENTIBA_ASSESS
        '
        Me.colTC_NB_RENTIBA_ASSESS.FieldName = "TC_NB_RENTIBA_ASSESS"
        Me.colTC_NB_RENTIBA_ASSESS.Name = "colTC_NB_RENTIBA_ASSESS"
        '
        'colTC_NB_RENTIBA_QUIT
        '
        Me.colTC_NB_RENTIBA_QUIT.FieldName = "TC_NB_RENTIBA_QUIT"
        Me.colTC_NB_RENTIBA_QUIT.Name = "colTC_NB_RENTIBA_QUIT"
        '
        'colTC_NB_RENTIBA_INSUR
        '
        Me.colTC_NB_RENTIBA_INSUR.FieldName = "TC_NB_RENTIBA_INSUR"
        Me.colTC_NB_RENTIBA_INSUR.Name = "colTC_NB_RENTIBA_INSUR"
        '
        'colTC_NB_RENTIBA_OTH
        '
        Me.colTC_NB_RENTIBA_OTH.FieldName = "TC_NB_RENTIBA_OTH"
        Me.colTC_NB_RENTIBA_OTH.Name = "colTC_NB_RENTIBA_OTH"
        '
        'colTC_NB_RENTIBA_MAIN
        '
        Me.colTC_NB_RENTIBA_MAIN.FieldName = "TC_NB_RENTIBA_MAIN"
        Me.colTC_NB_RENTIBA_MAIN.Name = "colTC_NB_RENTIBA_MAIN"
        '
        'colTC_NB_RENTIBA_AGREE
        '
        Me.colTC_NB_RENTIBA_AGREE.FieldName = "TC_NB_RENTIBA_AGREE"
        Me.colTC_NB_RENTIBA_AGREE.Name = "colTC_NB_RENTIBA_AGREE"
        '
        'colTC_NB_RENTIBA_IBA
        '
        Me.colTC_NB_RENTIBA_IBA.FieldName = "TC_NB_RENTIBA_IBA"
        Me.colTC_NB_RENTIBA_IBA.Name = "colTC_NB_RENTIBA_IBA"
        '
        'colTC_NB_DIV_DIS_ATT_INT
        '
        Me.colTC_NB_DIV_DIS_ATT_INT.FieldName = "TC_NB_DIV_DIS_ATT_INT"
        Me.colTC_NB_DIV_DIS_ATT_INT.Name = "colTC_NB_DIV_DIS_ATT_INT"
        '
        'colTC_NB_DIV_TOT_ATT_INT
        '
        Me.colTC_NB_DIV_TOT_ATT_INT.FieldName = "TC_NB_DIV_TOT_ATT_INT"
        Me.colTC_NB_DIV_TOT_ATT_INT.Name = "colTC_NB_DIV_TOT_ATT_INT"
        '
        'colTC_EA_UTL
        '
        Me.colTC_EA_UTL.FieldName = "TC_EA_UTL"
        Me.colTC_EA_UTL.Name = "colTC_EA_UTL"
        '
        'colTC_EA_TYPE
        '
        Me.colTC_EA_TYPE.FieldName = "TC_EA_TYPE"
        Me.colTC_EA_TYPE.Name = "colTC_EA_TYPE"
        '
        'colTC_EA_CURR_COMPANY
        '
        Me.colTC_EA_CURR_COMPANY.FieldName = "TC_EA_CURR_COMPANY"
        Me.colTC_EA_CURR_COMPANY.Name = "colTC_EA_CURR_COMPANY"
        '
        'colTC_EA_CURR_AGRICULTURE
        '
        Me.colTC_EA_CURR_AGRICULTURE.FieldName = "TC_EA_CURR_AGRICULTURE"
        Me.colTC_EA_CURR_AGRICULTURE.Name = "colTC_EA_CURR_AGRICULTURE"
        '
        'colTC_EA_CURR_SIGNIFICANT
        '
        Me.colTC_EA_CURR_SIGNIFICANT.FieldName = "TC_EA_CURR_SIGNIFICANT"
        Me.colTC_EA_CURR_SIGNIFICANT.Name = "colTC_EA_CURR_SIGNIFICANT"
        '
        'colTC_EA_CURR_MARKET
        '
        Me.colTC_EA_CURR_MARKET.FieldName = "TC_EA_CURR_MARKET"
        Me.colTC_EA_CURR_MARKET.Name = "colTC_EA_CURR_MARKET"
        '
        'colTC_EA_CURR_MSB
        '
        Me.colTC_EA_CURR_MSB.FieldName = "TC_EA_CURR_MSB"
        Me.colTC_EA_CURR_MSB.Name = "colTC_EA_CURR_MSB"
        '
        'colTC_EA_TOTAL
        '
        Me.colTC_EA_TOTAL.FieldName = "TC_EA_TOTAL"
        Me.colTC_EA_TOTAL.Name = "colTC_EA_TOTAL"
        '
        'colTC_EA_RESTRICTRATE
        '
        Me.colTC_EA_RESTRICTRATE.FieldName = "TC_EA_RESTRICTRATE"
        Me.colTC_EA_RESTRICTRATE.Name = "colTC_EA_RESTRICTRATE"
        '
        'colTC_EA_BF
        '
        Me.colTC_EA_BF.FieldName = "TC_EA_BF"
        Me.colTC_EA_BF.Name = "colTC_EA_BF"
        '
        'colTC_EA_CF
        '
        Me.colTC_EA_CF.FieldName = "TC_EA_CF"
        Me.colTC_EA_CF.Name = "colTC_EA_CF"
        '
        'colTC_TP_ESTIMATED_SME
        '
        Me.colTC_TP_ESTIMATED_SME.FieldName = "TC_TP_ESTIMATED_SME"
        Me.colTC_TP_ESTIMATED_SME.Name = "colTC_TP_ESTIMATED_SME"
        '
        'colTC_NB_DCA_INT
        '
        Me.colTC_NB_DCA_INT.FieldName = "TC_NB_DCA_INT"
        Me.colTC_NB_DCA_INT.Name = "colTC_NB_DCA_INT"
        '
        'colTC_NB_DEEMED_INT
        '
        Me.colTC_NB_DEEMED_INT.FieldName = "TC_NB_DEEMED_INT"
        Me.colTC_NB_DEEMED_INT.Name = "colTC_NB_DEEMED_INT"
        '
        'colTC_EXEMPTIONCAL
        '
        Me.colTC_EXEMPTIONCAL.FieldName = "TC_EXEMPTIONCAL"
        Me.colTC_EXEMPTIONCAL.Name = "colTC_EXEMPTIONCAL"
        '
        'colTC_EXEMPTIONLESS
        '
        Me.colTC_EXEMPTIONLESS.FieldName = "TC_EXEMPTIONLESS"
        Me.colTC_EXEMPTIONLESS.Name = "colTC_EXEMPTIONLESS"
        '
        'colTC_TP_INSTALL_107C
        '
        Me.colTC_TP_INSTALL_107C.FieldName = "TC_TP_INSTALL_107C"
        Me.colTC_TP_INSTALL_107C.Name = "colTC_TP_INSTALL_107C"
        '
        'colTC_TP_INSTALL_107A
        '
        Me.colTC_TP_INSTALL_107A.FieldName = "TC_TP_INSTALL_107A"
        Me.colTC_TP_INSTALL_107A.Name = "colTC_TP_INSTALL_107A"
        '
        'colTC_TP_RATE7
        '
        Me.colTC_TP_RATE7.FieldName = "TC_TP_RATE7"
        Me.colTC_TP_RATE7.Name = "colTC_TP_RATE7"
        '
        'colTC_TP_APP_CHARGEABLE7
        '
        Me.colTC_TP_APP_CHARGEABLE7.FieldName = "TC_TP_APP_CHARGEABLE7"
        Me.colTC_TP_APP_CHARGEABLE7.Name = "colTC_TP_APP_CHARGEABLE7"
        '
        'colTC_TP_RATE6_CHARGEABLE
        '
        Me.colTC_TP_RATE6_CHARGEABLE.FieldName = "TC_TP_RATE6_CHARGEABLE"
        Me.colTC_TP_RATE6_CHARGEABLE.Name = "colTC_TP_RATE6_CHARGEABLE"
        '
        'colTC_TP_RATE7_CHARGEABLE
        '
        Me.colTC_TP_RATE7_CHARGEABLE.FieldName = "TC_TP_RATE7_CHARGEABLE"
        Me.colTC_TP_RATE7_CHARGEABLE.Name = "colTC_TP_RATE7_CHARGEABLE"
        '
        'colTC_EA_TYPE1
        '
        Me.colTC_EA_TYPE1.FieldName = "TC_EA_TYPE1"
        Me.colTC_EA_TYPE1.Name = "colTC_EA_TYPE1"
        '
        'colTC_EA_TYPE2
        '
        Me.colTC_EA_TYPE2.FieldName = "TC_EA_TYPE2"
        Me.colTC_EA_TYPE2.Name = "colTC_EA_TYPE2"
        '
        'colTC_EA_TYPE3
        '
        Me.colTC_EA_TYPE3.FieldName = "TC_EA_TYPE3"
        Me.colTC_EA_TYPE3.Name = "colTC_EA_TYPE3"
        '
        'cboYA
        '
        Me.cboYA.Location = New System.Drawing.Point(449, 14)
        Me.cboYA.Name = "cboYA"
        Me.cboYA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboYA.Properties.PopupSizeable = True
        Me.cboYA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboYA.Size = New System.Drawing.Size(226, 20)
        Me.cboYA.TabIndex = 10
        '
        'TaxPayerFindBindingSource
        '
        Me.TaxPayerFindBindingSource.DataMember = "TaxPayerFind"
        Me.TaxPayerFindBindingSource.DataSource = Me.DsCA
        '
        'DsCA
        '
        Me.DsCA.DataSetName = "dsCA"
        Me.DsCA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAllRecord
        '
        Me.btnAllRecord.ImageOptions.Image = CType(resources.GetObject("btnAllRecord.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAllRecord.Location = New System.Drawing.Point(449, 38)
        Me.btnAllRecord.Name = "btnAllRecord"
        Me.btnAllRecord.Size = New System.Drawing.Size(110, 23)
        Me.btnAllRecord.TabIndex = 8
        Me.btnAllRecord.Text = "All Record"
        '
        'btnFind
        '
        Me.btnFind.ImageOptions.Image = CType(resources.GetObject("btnFind.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFind.Location = New System.Drawing.Point(565, 38)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(110, 23)
        Me.btnFind.TabIndex = 7
        Me.btnFind.Text = "Find"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Reference No :"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cboRefNo)
        Me.PanelControl1.Controls.Add(Me.btnClear2)
        Me.PanelControl1.Controls.Add(Me.btnClear)
        Me.PanelControl1.Controls.Add(Me.txtRefNo)
        Me.PanelControl1.Controls.Add(Me.cboYA)
        Me.PanelControl1.Controls.Add(Me.btnAllRecord)
        Me.PanelControl1.Controls.Add(Me.btnFind)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 31)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(948, 75)
        Me.PanelControl1.TabIndex = 10
        '
        'cboRefNo
        '
        Me.cboRefNo.Location = New System.Drawing.Point(91, 14)
        Me.cboRefNo.MenuManager = Me.BarManager1
        Me.cboRefNo.Name = "cboRefNo"
        Me.cboRefNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRefNo.Properties.DataSource = Me.TaxPayerFindBindingSource
        Me.cboRefNo.Properties.DisplayMember = "CompanyName"
        Me.cboRefNo.Properties.NullText = "Select"
        Me.cboRefNo.Properties.PopupFormMinSize = New System.Drawing.Size(600, 0)
        Me.cboRefNo.Properties.ValueMember = "RefNo"
        Me.cboRefNo.Properties.View = Me.SearchLookUpEdit2View
        Me.cboRefNo.Size = New System.Drawing.Size(268, 20)
        Me.cboRefNo.TabIndex = 161
        '
        'SearchLookUpEdit2View
        '
        Me.SearchLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRefNo, Me.colCompanyName, Me.colHandleBy, Me.colCompanyNo, Me.colEmployerNo, Me.colFileNo, Me.colCountry, Me.colCompanyCode})
        Me.SearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit2View.Name = "SearchLookUpEdit2View"
        Me.SearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit2View.OptionsView.ColumnAutoWidth = False
        Me.SearchLookUpEdit2View.OptionsView.RowAutoHeight = True
        Me.SearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colRefNo
        '
        Me.colRefNo.FieldName = "RefNo"
        Me.colRefNo.Name = "colRefNo"
        Me.colRefNo.Visible = True
        Me.colRefNo.VisibleIndex = 0
        Me.colRefNo.Width = 100
        '
        'colCompanyName
        '
        Me.colCompanyName.FieldName = "CompanyName"
        Me.colCompanyName.Name = "colCompanyName"
        Me.colCompanyName.Visible = True
        Me.colCompanyName.VisibleIndex = 1
        Me.colCompanyName.Width = 250
        '
        'colHandleBy
        '
        Me.colHandleBy.FieldName = "HandleBy"
        Me.colHandleBy.Name = "colHandleBy"
        Me.colHandleBy.Visible = True
        Me.colHandleBy.VisibleIndex = 2
        Me.colHandleBy.Width = 150
        '
        'colCompanyNo
        '
        Me.colCompanyNo.FieldName = "CompanyNo"
        Me.colCompanyNo.Name = "colCompanyNo"
        Me.colCompanyNo.Visible = True
        Me.colCompanyNo.VisibleIndex = 3
        Me.colCompanyNo.Width = 100
        '
        'colEmployerNo
        '
        Me.colEmployerNo.FieldName = "EmployerNo"
        Me.colEmployerNo.Name = "colEmployerNo"
        Me.colEmployerNo.Visible = True
        Me.colEmployerNo.VisibleIndex = 4
        Me.colEmployerNo.Width = 100
        '
        'colFileNo
        '
        Me.colFileNo.FieldName = "FileNo"
        Me.colFileNo.Name = "colFileNo"
        Me.colFileNo.Visible = True
        Me.colFileNo.VisibleIndex = 5
        Me.colFileNo.Width = 100
        '
        'colCountry
        '
        Me.colCountry.FieldName = "Country"
        Me.colCountry.Name = "colCountry"
        Me.colCountry.Visible = True
        Me.colCountry.VisibleIndex = 6
        Me.colCountry.Width = 100
        '
        'colCompanyCode
        '
        Me.colCompanyCode.FieldName = "CompanyCode"
        Me.colCompanyCode.Name = "colCompanyCode"
        Me.colCompanyCode.Visible = True
        Me.colCompanyCode.VisibleIndex = 7
        Me.colCompanyCode.Width = 100
        '
        'ucAdjustedIncome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlLoading)
        Me.Controls.Add(Me.dgvView)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "ucAdjustedIncome"
        Me.Size = New System.Drawing.Size(948, 579)
        CType(Me.txtRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.TAXCOMPUTATIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAdjustedIncome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cboRefNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlLoading As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents btnClear2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRefNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents dgvView As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cboYA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TaxPayerFindBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsCA As EasyTemplate_Taxcom.dsCA
    Friend WithEvents btnAllRecord As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyReferenceNoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyYAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboRefNo As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRefNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHandleBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployerNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents TAXCOMPUTATIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsAdjustedIncome As EasyTemplate_Taxcom.dsAdjustedIncome
    Friend WithEvents colTC_KEY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_REF_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_YA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CO_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_ROC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_BUSINESS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_AI_PNL_BAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_AI_DIVIDEND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_AI_RENTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_AI_ROYALTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_AI_INTEREST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_AI_SEC4A As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_AI_TOT_NONBS_IN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_AI_TOT_BS_IN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_AI_ADJ_BS_IN_NA_LOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_AI_ADJ_BS_IN_NT_IN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_AI_ADJ_BS_IN_TAX_IN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_AI_TOT_ADJ_BS_IN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_AI_ADJ_BS_EXP_INT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_AI_ADJ_BS_EXP_NA_EXP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_AI_ADJ_BS_EXP_RV_EXP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_AI_ADJ_BS_EXP_CLAIM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_AI_TOT_ADJ_BS_EXP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_AI_ADJ_IN_LOSS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_ADJ_BS_IN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_CA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_STAT_BS_IN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_INVEST_ALLOW As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_NET_STAT_IN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_SS_RENTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_SS_DIR_EXP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_SS_DIR_EXP_QUIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_SS_DIR_EXP_MAIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_SS_ADJ_IN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_SS_CA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_SS_STAT_BS_IN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_OTH_SOURCE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_MAIN_BS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_SEC_BS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_OTH_BS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_TOT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_BS_LOSS_BF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_AGGREGATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_DIV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_DIV_ATT_INT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_DIV_NET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_INT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_INT_ATT_INT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_INT_NET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_RENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_RENT_ATT_INT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_RENT_ASSESS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_RENT_QUIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_RENT_INSUR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_RENT_OTH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_RENT_MAIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_RENT_AGREE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_RENT_NET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_SUNDRY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_OTH_AGGR_STAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_AGGR_IN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_CURR_LOSS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_AGGR_IN_LOSS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_APRV_DONATION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_CHARGEABLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_28_CHARGEABLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_SEC110 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_SEC132 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_SEC133 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_TOT_SETOFF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_PAYABLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_INSTALL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_PAYABLE_BAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_CA_BAL_BF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_CA_CURR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_CA_AA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_CA_IA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_CA_BA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_CA_UTIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_CA_BAL_CF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_LS_BAL_BF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_LS_UTIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_LS_BAL_UTIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_LS_UNABSORBED As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_LS_BAL_CF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_ITA_BAL_BF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_ITA_CURR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_ITA_BAL_BF_CURR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_ITA_UTIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_ITA_BAL_CF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_AI_OTH_BS_IN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_RATE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_RATE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_RATE3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_RATE4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_RATE5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_RATE6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_APP_CHARGEABLE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_APP_CHARGEABLE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_APP_CHARGEABLE3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_APP_CHARGEABLE4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_APP_CHARGEABLE5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_APP_CHARGEABLE6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_RATE1_CHARGEABLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_RATE2_CHARGEABLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_RATE3_CHARGEABLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_RATE4_CHARGEABLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_RATE5_CHARGEABLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_TOT_TAX_CHARGED As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_SEC6B_REBATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_SEC110_OTHERS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_PROSPECTING As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_QUALIFY_AGRICULTURE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_PREOP_BS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_FOOD_PRODUCTION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_EXP_ALLOWED As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_TOTAL_OTH_EXP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_TOTAL_INCOME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_PIONEER_CHARGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_OPERATIONALHQ_CHARGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_FOREIGN_CHARGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_BS_LOSS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_ROYALTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_ADDITION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_LS_ADJUST_LOSS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_LS_UTIL_CURR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_RA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_RA_BAL_BF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_RA_CURR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_RA_BAL_BF_CURR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_RA_UTIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_RA_BAL_CF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_BC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_ADJ_BS_IN_BC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_CA_CURR_BA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_RATE4A As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_APP_CHARGEABLE4A As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_RATE4A_CHARGEABLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_CA_NA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_ZAKAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_OTHERDEDUCTION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_CA_DISALLOW As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_CA_ABAL_CF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_CHECK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_CLAIM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_LS_SAMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_LS_BALS_CF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_LS_D_BL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_LS_SRDAMT2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_LS_BLNBF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_LS_AMTTUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_LS_BLNCF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_COMPANY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_PIONEERDESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_PIO As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents colTC_DISALLOW_NOTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_DISALLOWBUSINESS_NOTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SURPLUSRECOVERED As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_MININGALLOWNANCE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_MININGEXPENSES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_STAT_DIVIDEND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_SEC110B As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_RENT_OTH2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_CARRYBCKLOSS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_AMTNOTCARRYBCK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_CHKCB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_INCOME_TP2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_ESTIMATED_TP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_INCOME_TP3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_ALL_DIFF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_EX_DIFF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_PEN_DIFF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_WITHRAITA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_RA_WITHDRAWAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_RA_ADJUSTMENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_ITA_WITHDRAWAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_ITA_ADJUSTMENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_DIV_OTH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_INT_OTH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SUNDRY_EXP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CHK_EXEMP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_SI_TOT_PARTNERSHIP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_CB_CA_ACA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_RENTIBA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_RENTIBA_ATT_IN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_RENTIBA_ASSESS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_RENTIBA_QUIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_RENTIBA_INSUR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_RENTIBA_OTH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_RENTIBA_MAIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_RENTIBA_AGREE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_RENTIBA_IBA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_DIV_DIS_ATT_INT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_DIV_TOT_ATT_INT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_EA_UTL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_EA_TYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_EA_CURR_COMPANY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_EA_CURR_AGRICULTURE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_EA_CURR_SIGNIFICANT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_EA_CURR_MARKET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_EA_CURR_MSB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_EA_TOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_EA_RESTRICTRATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_EA_BF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_EA_CF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_ESTIMATED_SME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_DCA_INT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_NB_DEEMED_INT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_EXEMPTIONCAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_EXEMPTIONLESS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_INSTALL_107C As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_INSTALL_107A As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_RATE7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_APP_CHARGEABLE7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_RATE6_CHARGEABLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_TP_RATE7_CHARGEABLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_EA_TYPE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_EA_TYPE2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTC_EA_TYPE3 As DevExpress.XtraGrid.Columns.GridColumn

End Class
