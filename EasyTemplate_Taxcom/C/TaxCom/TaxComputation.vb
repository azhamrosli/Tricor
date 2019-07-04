Imports System.Data.SqlClient

Public Class TaxComputation
    Inherits clsIODatabase
#Region "REFERNCE"
    'Dim dtRow As DataRow = Nothing

    '                dtRow = dsAdjustIncome.Tables("TAX_COMPUTATION").NewRow
    ''===== INFO ===============================================
    '                dtRow("TC_KEY") = TC_KEY
    '                dtRow("TC_REF_NO") = RefNo
    '                dtRow("TC_YA") = YA
    '                dtRow("TC_CO_NAME") = dtTaxPayer.Rows(0)("TP_COM_NAME")
    '                dtRow("TC_ROC") = dtTaxPayer.Rows(0)("TP_ROC_NO")
    '                dtRow("TC_BUSINESS") = SourceNo
    ''===== INFO ===============================================
    ''===== ADJUSTED INCOME=====================================
    '                dtRow("TC_AI_PNL_BAL") = TC_AI_PNL_BAL  'txtBalLoss or txtBalProfit
    '                dtRow("TC_AI_DIVIDEND") = TC_AI_DIVIDEND 'txtDividend
    '                dtRow("TC_AI_RENTAL") = TC_AI_RENTAL 'txtRental
    '                dtRow("TC_AI_ROYALTY") = TC_AI_ROYALTY 'txtRoyalty
    '                dtRow("TC_AI_INTEREST") = TC_AI_INTEREST 'txtInterest
    '                dtRow("TC_AI_SEC4A") = TC_AI_SEC4A 'txtSection4A
    '                dtRow("TC_AI_TOT_NONBS_IN") = TC_AI_TOT_NONBS_IN 'txtTotNonBs
    '                dtRow("TC_AI_TOT_BS_IN") = TC_AI_TOT_BS_IN 'totbusinessincome  (txtTotBsLoss or txtTotBsProfit)
    '                dtRow("TC_AI_ADJ_BS_IN_NA_LOS") = TC_AI_ADJ_BS_IN_NA_LOS 'txtNALoss
    '                dtRow("TC_AI_ADJ_BS_IN_NT_IN") = TC_AI_ADJ_BS_IN_NT_IN 'txtNTaxIn
    '                dtRow("TC_AI_ADJ_BS_IN_TAX_IN") = TC_AI_ADJ_BS_IN_TAX_IN 'txtTaxIn
    '                dtRow("TC_AI_TOT_ADJ_BS_IN") = TC_AI_TOT_ADJ_BS_IN 'adjbusinessincome (txtTotBILoss or txtTotBIProfit)
    '                dtRow("TC_AI_ADJ_BS_EXP_INT") = TC_AI_ADJ_BS_EXP_INT 'txtInterestRestricted
    '                dtRow("TC_AI_ADJ_BS_EXP_NA_EXP") = TC_AI_ADJ_BS_EXP_NA_EXP 'txtNAExp
    '                dtRow("TC_AI_ADJ_BS_EXP_RV_EXP") = TC_AI_ADJ_BS_EXP_RV_EXP 'txtRevenueExp
    '                dtRow("TC_AI_ADJ_BS_EXP_CLAIM") = TC_AI_ADJ_BS_EXP_CLAIM 'txtOthExp
    '                dtRow("TC_AI_TOT_ADJ_BS_EXP") = TC_AI_TOT_ADJ_BS_EXP 'txtTotBSExp
    '                dtRow("TC_AI_ADJ_IN_LOSS") = TC_AI_ADJ_IN_LOSS 'adjincome (txtAdLoss or txtAdIn)
    ''===== ADJUSTED INCOME=====================================
    '                dtRow("TC_SI_ADJ_BS_IN") = TC_SI_ADJ_BS_IN 'lstView.ListItems(i).ListSubItems(6).Text - Adjusted Business Income
    '                dtRow("TC_SI_CA") = TC_SI_CA 'lstView.ListItems(i).ListSubItems(9).Text - Capital Allowances
    '                dtRow("TC_SI_STAT_BS_IN") = TC_SI_STAT_BS_IN 'lstView.ListItems(i).ListSubItems(10).Text 'Statutory Business Income
    '                dtRow("TC_SI_INVEST_ALLOW") = TC_SI_INVEST_ALLOW 'lstView.ListItems(i).ListSubItems(12).Text 'Investment Tax Allowance
    '                dtRow("TC_SI_NET_STAT_IN") = TC_SI_NET_STAT_IN 'lstView.ListItems(i).ListSubItems(13).Text 'Net Statutory Income
    '                dtRow("TC_SI_SS_RENTAL") = TC_SI_SS_RENTAL
    '                dtRow("TC_SI_SS_DIR_EXP") = TC_SI_SS_DIR_EXP
    '                dtRow("TC_SI_SS_DIR_EXP_QUIT") = TC_SI_SS_DIR_EXP_QUIT
    '                dtRow("TC_SI_SS_DIR_EXP_MAIN") = TC_SI_SS_DIR_EXP_MAIN
    '                dtRow("TC_SI_SS_ADJ_IN") = TC_SI_SS_ADJ_IN
    '                dtRow("TC_SI_SS_CA") = TC_SI_SS_CA
    '                dtRow("TC_SI_SS_STAT_BS_IN") = TC_SI_SS_STAT_BS_IN
    '                dtRow("TC_SI_OTH_SOURCE") = TC_SI_OTH_SOURCE
    '                dtRow("TC_SI_MAIN_BS") = TC_SI_MAIN_BS
    '                dtRow("TC_SI_SEC_BS") = TC_SI_SEC_BS
    '                dtRow("TC_SI_OTH_BS") = TC_SI_OTH_BS
    '                dtRow("TC_SI_TOT") = TC_SI_TOT 'txtAllStatIn
    '                dtRow("TC_SI_BS_LOSS_BF") = TC_SI_BS_LOSS_BF 'txtBsLoss
    '                dtRow("TC_SI_AGGREGATE") = TC_SI_AGGREGATE 'txtAggregate
    '                dtRow("TC_NB_DIV") = TC_NB_DIV 'txtDividendIn(1)
    '                dtRow("TC_NB_DIV_ATT_INT") = TC_NB_DIV_ATT_INT 'txtDivAttrInt
    '                dtRow("TC_NB_DIV_NET") = TC_NB_DIV_NET 'txtNetDividend
    '                dtRow("TC_NB_INT") = TC_NB_INT 'txtInterestIn(0)
    '                dtRow("TC_NB_INT_ATT_INT") = TC_NB_INT_ATT_INT 'txtIntAttrInt
    '                dtRow("TC_NB_INT_NET") = TC_NB_INT_NET 'txtNetIntIn
    '                dtRow("TC_NB_RENT") = TC_NB_RENT 'txtRentalIn
    '                dtRow("TC_NB_RENT_ATT_INT") = TC_NB_RENT_ATT_INT 'txtRentAttrIn
    '                dtRow("TC_NB_RENT_ASSESS") = TC_NB_RENT_ASSESS 'txtRentAssess
    '                dtRow("TC_NB_RENT_QUIT") = TC_NB_RENT_QUIT 'txtRentQuit
    '                dtRow("TC_NB_RENT_INSUR") = TC_NB_RENT_INSUR 'txtRentInsur
    '                dtRow("TC_NB_RENT_OTH") = TC_NB_RENT_OTH 'txtRentOthExp
    '                dtRow("TC_NB_RENT_MAIN") = TC_NB_RENT_MAIN 'txtRentRepair
    '                dtRow("TC_NB_RENT_AGREE") = TC_NB_RENT_AGREE 'txtRentRenewal
    '                dtRow("TC_NB_RENT_NET") = TC_NB_RENT_NET 'txtNetRentalIn
    '                dtRow("TC_NB_SUNDRY") = TC_NB_SUNDRY 'txtSundryIn
    '                dtRow("TC_NB_OTH_AGGR_STAT") = TC_NB_OTH_AGGR_STAT 'txtOthAggregate
    '                dtRow("TC_TP_AGGR_IN") = TC_TP_AGGR_IN 'txtAggregateIn
    '                dtRow("TC_TP_CURR_LOSS") = TC_TP_CURR_LOSS 'txtCurrBsLoss
    '                dtRow("TC_TP_AGGR_IN_LOSS") = 0 'txtAggrLoss
    '                dtRow("TC_TP_APRV_DONATION") = 0 'txtApprDonation
    '                dtRow("TC_TP_CHARGEABLE") = 0 'txtChargeableIn
    '                dtRow("TC_TP_28_CHARGEABLE") = 0 'txtITPChargeableIn5
    '                dtRow("TC_TP_SEC110") = 0 'txtITPSetoff
    '                dtRow("TC_TP_SEC132") = 0 'txtSec132
    '                dtRow("TC_TP_SEC133") = 0 'txtSec133
    '                dtRow("TC_TP_TOT_SETOFF") = 0 'txtTotalSetoff
    '                dtRow("TC_TP_PAYABLE") = 0 'txtITP
    '                dtRow("TC_TP_INSTALL") = 0 'txtInstallments
    '                dtRow("TC_TP_PAYABLE_BAL") = 0 'txtTPBal
    '                dtRow("TC_CB_CA_BAL_BF") = 0 'lstViewCA.ListItems(I).ListSubItems(2).Text 'Balance b/f
    '                dtRow("TC_CB_CA_CURR") = 0 'lstViewCA.ListItems(I).ListSubItems(6).Text 'UCA Year
    '                dtRow("TC_CB_CA_AA") = 0 'lstViewCA.ListItems(I).ListSubItems(3).Text 'AA
    '                dtRow("TC_CB_CA_IA") = 0 'lstViewCA.ListItems(I).ListSubItems(4).Text 'AI
    '                dtRow("TC_CB_CA_BA") = 0 'lstViewCA.ListItems(I).ListSubItems(7).Text 'Balancing Allowance
    '                dtRow("TC_CB_CA_UTIL") = 0 'lstViewCA.ListItems(I).ListSubItems(9).Text 'UCA Utilised
    '                dtRow("TC_CB_CA_BAL_CF") = 0 'lstViewCA.ListItems(I).ListSubItems(10).Text 'Balance c/f
    '                dtRow("TC_CB_LS_BAL_BF") = 0 'txtULBalbf
    '                dtRow("TC_CB_LS_UTIL") = 0 'txtULUtilised
    '                dtRow("TC_CB_LS_BAL_UTIL") = 0 'txtULBalUtil
    '                dtRow("TC_CB_LS_UNABSORBED") = 0 'txtUBL
    '                dtRow("TC_CB_LS_BAL_CF") = 0 'txtULBalcf
    '                dtRow("TC_CB_ITA_BAL_BF") = 0 'ListViewITA.ListItems(i).ListSubItems(2).Text 'txtITABalbf 'Balance b/f
    '                dtRow("TC_CB_ITA_CURR") = 0 'ListViewITA.ListItems(I).ListSubItems(3).Text 'ITA for the year
    '                dtRow("TC_CB_ITA_BAL_BF_CURR") = 0 'ITACurrClaims
    '                dtRow("TC_CB_ITA_UTIL") = 0 'ListViewITA.ListItems(i).ListSubItems(5).Text 'TOTAL ALL SOURCE 'Utilised
    '                dtRow("TC_CB_ITA_BAL_CF") = 0 'ITABalanceCF 'Balance C/F
    '                dtRow("TC_AI_OTH_BS_IN") = 0 'txtOthBsIn
    '                dtRow("TC_TP_RATE1") = 0 'txtRate1
    '                dtRow("TC_TP_RATE2") = 0 'txtRate2
    '                dtRow("TC_TP_RATE3") = 0 'txtRate3
    '                dtRow("TC_TP_RATE4") = 0 'txtRate4
    '                dtRow("TC_TP_RATE5") = 0 'txtRate5
    '                dtRow("TC_TP_RATE6") = 0 'txtRate6
    '                dtRow("TC_TP_APP_CHARGEABLE1") = 0 'txtAppChargeableIn1
    '                dtRow("TC_TP_APP_CHARGEABLE2") = 0 'txtAppChargeableIn2
    '                dtRow("TC_TP_APP_CHARGEABLE3") = 0 'txtAppChargeableIn3
    '                dtRow("TC_TP_APP_CHARGEABLE4") = 0 'txtAppChargeableIn4
    '                dtRow("TC_TP_APP_CHARGEABLE5") = 0 'txtAppChargeableIn5
    '                dtRow("TC_TP_APP_CHARGEABLE6") = 0 'txtAppChargeableIn6
    '                dtRow("TC_TP_RATE1_CHARGEABLE") = 0 'txtITPChargeableIn1
    '                dtRow("TC_TP_RATE2_CHARGEABLE") = 0 'txtITPChargeableIn2
    '                dtRow("TC_TP_RATE3_CHARGEABLE") = 0 'txtITPChargeableIn3
    '                dtRow("TC_TP_RATE4_CHARGEABLE") = 0 'txtITPChargeableIn4
    '                dtRow("TC_TP_RATE5_CHARGEABLE") = 0 'txtITPChargeableIn6
    '                dtRow("TC_TP_TOT_TAX_CHARGED") = 0 'txtTotalTaxCharged
    '                dtRow("TC_TP_SEC6B_REBATE") = 0 'txtSec6BRebate
    '                dtRow("TC_TP_SEC110_OTHERS") = 0 'txtITPSetoffOth
    '                dtRow("TC_TP_PROSPECTING") = 0 'txtProspecting
    '                dtRow("TC_TP_QUALIFY_AGRICULTURE") = 0 'txtQualifyAgri
    '                dtRow("TC_TP_PREOP_BS") = 0 'txtPreopBs
    '                dtRow("TC_TP_FOOD_PRODUCTION") = 0 'txtFoodProduct
    '                dtRow("TC_TP_EXP_ALLOWED") = 0 'txtExpAllowed
    '                dtRow("TC_TP_TOTAL_OTH_EXP") = 0 'txtTotalOthExp
    '                dtRow("TC_TP_TOTAL_INCOME") = 0 'txtTotalIncome
    '                dtRow("TC_TP_PIONEER_CHARGE") = 0 'txtPioneerChargeable
    '                dtRow("TC_TP_OPERATIONALHQ_CHARGE") = 0 'txtOpHQChargeable
    '                dtRow("TC_TP_FOREIGN_CHARGE") = 0 'txtForeignChargeable
    '                dtRow("TC_TP_BS_LOSS") = 0
    '                dtRow("TC_NB_ROYALTY") = 0 'txtRoyaltyIncome
    '                dtRow("TC_NB_ADDITION") = 0 'txtAddition
    '                dtRow("TC_CB_LS_ADJUST_LOSS") = 0 'txtCurrentYrLoss
    '                dtRow("TC_CB_LS_UTIL_CURR") = 0 'txtULUtilisedCurr
    '                dtRow("TC_SI_RA") = 0  'lstView.ListItems(i).ListSubItems(11).Text 'Reinvestment Allowance
    '                dtRow("TC_CB_RA_BAL_BF") = 0 'ListViewRA.ListItems(I).ListSubItems(2).Text 'Balance b/f
    '                dtRow("TC_CB_RA_CURR") = 0 'ListViewRA.ListItems(i).ListSubItems(3).Text 'RA for the year
    '                dtRow("TC_CB_RA_BAL_BF_CURR") = 0 'RACurrClaims
    '                dtRow("TC_CB_RA_UTIL") = 0 'ListViewRA.ListItems(i).ListSubItems(5).Text 'Utilised
    '                dtRow("TC_CB_RA_BAL_CF") = 0 'RABalanceCF 'Balance C/F
    '                dtRow("TC_SI_BC") = 0 'lstView.ListItems(i).ListSubItems(7).Text 'Balancing Charge
    '                dtRow("TC_SI_ADJ_BS_IN_BC") = 0 'lstView.ListItems(i).ListSubItems(8).Text 'Total
    '                dtRow("TC_CB_CA_CURR_BA") = 0 'lstViewCA.ListItems(I).ListSubItems(8).Text 'Total
    '                dtRow("TC_TP_RATE4A") = 0 'txtRate4a
    '                dtRow("TC_TP_APP_CHARGEABLE4A") = 0 'txtAppChargeableIn4a
    '                dtRow("TC_TP_RATE4A_CHARGEABLE") = 0 'txtITPChargeableIn4a
    '                dtRow("TC_CB_CA_NA") = 0 'lstViewCA.ListItems(I).ListSubItems(5).Text 'Notional Allowance
    '                dtRow("TC_TP_ZAKAT") = 0 'txtZakat
    '                dtRow("TC_OTHERDEDUCTION") = 0 'txtOtherDeduc frmAdjustedIncomeEdit
    '                dtRow("TC_CB_CA_DISALLOW") = 0 'lstViewCA.ListItems(I).ListSubItems(11).Text 'Disallowed CA
    '                dtRow("TC_CB_CA_ABAL_CF") = 0 'lstViewCA.ListItems(i).ListSubItems(12).Text 'ActualBalancebf 'Actual Balance c/f
    '                dtRow("TC_TP_CLAIM") = 0 'txtClaim
    '                dtRow("TC_CB_LS_SAMOUNT") = 0 'txtSrdAmt
    '                dtRow("TC_CB_LS_BALS_CF") = 0 'txtBalcf
    '                dtRow("TC_CB_LS_D_BL") = 0 'txtDisABL
    '                dtRow("TC_CB_LS_SRDAMT2") = 0 'txtSrdAmt2
    '                dtRow("TC_CB_LS_BLNBF") = 0 'txtBlnBf
    '                dtRow("TC_CB_LS_AMTTUT") = 0 'txtAmtTut
    '                dtRow("TC_CB_LS_BLNCF") = 0 'txtBlnCf
    '                dtRow("TC_COMPANY") = "C"
    '                dtRow("TC_PIONEERDESC") = "" 'lstView.ListItems(i).ListSubItems(15).Text 'IIf(Not IsNull(rst!TC_PIONEERDESC), rst!TC_PIONEERDESC, " ")
    '                dtRow("TC_PIO") = "0" 'lstView.ListItems(I).ListSubItems(16).Text 'TC_PIONEERDESC  'frmTaxSummrryReport 'Always Be 0 "Zero"
    '                dtRow("TC_PIONEER") = 0 'lstView.ListItems(i).ListSubItems(17).Text 'TC_PIO
    '                dtRow("TC_RA_RATE1") = 0 'lstView.ListItems(i).ListSubItems(18).Text 'TC_RA_RATE1
    '                dtRow("TC_RA_QUALIFYINGCAPITALEXP") = 0 'lstView.ListItems(i).ListSubItems(19).Text 'TC_RA_QUALIFYINGCAPITALEXP
    '                dtRow("TC_RA_QUALIFYINGCAPITALEXP_AMOUNT") = 0 'lstView.ListItems(i).ListSubItems(20).Text 'TC_RA_QUALIFYINGCAPITALEXP_AMOUNT
    '                dtRow("TC_RA_BALANCINGALLOWANCE") = 0 'lstView.ListItems(i).ListSubItems(21).Text 'TC_RA_BALANCINGALLOWANCE
    '                dtRow("TC_RA_TOTAL1") = 0 'lstView.ListItems(i).ListSubItems(22).Text
    '                dtRow("TC_RA_RESTRICTRATE") = 0 'lstView.ListItems(i).ListSubItems(23).Text
    '                dtRow("TC_RA_RESTRICTAMOUNT") = 0 'lstView.ListItems(i).ListSubItems(24).Text
    '                dtRow("TC_ITA_RATE1") = 0 'lstView.ListItems(i).ListSubItems(25).Text
    '                dtRow("TC_ITA_QUALIFYINGCAPITALEXP") = 0 'lstView.ListItems(i).ListSubItems(26).Text
    '                dtRow("TC_ITA_QUALIFYINGCAPITALEXP_AMOUNT") = 0 'lstView.ListItems(i).ListSubItems(27).Text
    '                dtRow("TC_ITA_BALANCINGALLOWANCE") = 0 'lstView.ListItems(i).ListSubItems(28).Text
    '                dtRow("TC_ITA_TOTAL1") = 0 'lstView.ListItems(i).ListSubItems(29).Text
    '                dtRow("TC_ITA_RESTRICTRATE") = 0 'lstView.ListItems(i).ListSubItems(30).Text
    '                dtRow("TC_ITA_RESTRICTAMOUNT") = 0 'lstView.ListItems(i).ListSubItems(31).Text
    '                dtRow("TC_DISALLOW_NOTE") = "" 'lstViewCA.ListItems(I).ListSubItems(13).Text 'Disallowed CA NOTE
    '                dtRow("TC_DISALLOWBUSINESS_NOTE") = "" 'lvNote.ListItems(i).ListSubItems(1).Text 'DBSNote
    '                dtRow("TC_SURPLUSRECOVERED") = "" 'txtSurplusMiningAllowance 'frmAdjustedIncome
    '                dtRow("TC_MININGALLOWNANCE") = "" 'txtMiningAllowing 'frmAdjustedIncome
    '                dtRow("TC_MININGEXPENSES") = "" 'txtAddMiningExp
    '                dtRow("TC_STAT_DIVIDEND") = 0 'txtSIFrmDiv '===== If Val(cYA) >= 2008 Then txtSIFrmDiv = txtDividendIncome else txtSIFrmDiv = FormatNumber(0, 2)
    '                dtRow("TC_TP_SEC110B") = 0 'txt110BSetOff
    '                dtRow("TC_NB_RENT_OTH2") = 0 'txtOthers
    '                dtRow("TC_NB_CARRYBCKLOSS") = 0 'txtCBL
    '                dtRow("TC_NB_AMTNOTCARRYBCK") = 0 'txtANCB
    '                dtRow("TC_NB_CHKCB") = "0" 'checkstatus 'If Me.chkCBL.Value = 1 Then checkstatus = "1" else checkstatus = "0"
    '                dtRow("TC_TP_INCOME_TP2") = 0 'txtInTaxPay2
    '                dtRow("TC_TP_ESTIMATED_TP") = 0 'txtEsTaxPay
    '                dtRow("TC_TP_INCOME_TP3") = 0 'txtInTaxPay3
    '                dtRow("TC_TP_ALL_DIFF") = 0 'txtAllowDiff
    '                dtRow("TC_TP_EX_DIFF") = 0 'txtExDiff
    '                dtRow("TC_TP_PEN_DIFF") = 0 'txtPenOnExDiff
    '                dtRow("TC_WITHRAITA") = 0 'lstView.ListItems(i).ListSubItems(32).Text
    '                dtRow("TC_RA_WITHDRAWAL") = 0 'ListViewRA.ListItems(i).ListSubItems(7).Text
    '                dtRow("TC_RA_ADJUSTMENT") = 0 'ListViewRA.ListItems(i).ListSubItems(8).Text
    '                dtRow("TC_ITA_WITHDRAWAL") = 0 'ListViewITA.ListItems(i).ListSubItems(7).Text
    '                dtRow("TC_ITA_ADJUSTMENT") = 0 'ListViewITA.ListItems(i).ListSubItems(8).Text
    '                dtRow("TC_NB_DIV_OTH") = 0 'txtDivOthers
    '                dtRow("TC_NB_INT_OTH") = 0 'txtIntOthers
    '                dtRow("TC_SUNDRY_EXP") = 0 'txtDirExpenses3
    '                dtRow("TC_CHK_EXEMP") = "N" 'lstView.ListItems(i).ListSubItems(33).Text
    '                dtRow("TC_SI_TOT_PARTNERSHIP") = 0 'txtTotal
    '                dtRow("TC_CB_CA_ACA") = 0 'lstViewCA.ListItems(i).ListSubItems(14).Text
    '                dtRow("TC_NB_RENTIBA") = 0 'txtRentalInIBA
    '                dtRow("TC_NB_RENTIBA_ATT_IN") = 0 'txtRentAttrInIBA
    '                dtRow("TC_NB_RENTIBA_ASSESS") = 0 'txtRentAssessIBA
    '                dtRow("TC_NB_RENTIBA_QUIT") = 0 'txtRentQuitIBA
    '                dtRow("TC_NB_RENTIBA_INSUR") = 0 'txtRentInsurIBA
    '                dtRow("TC_NB_RENTIBA_OTH") = 0 'txtRentOthExpIBA
    '                dtRow("TC_NB_RENTIBA_MAIN") = 0 'txtRentRepairIBA
    '                dtRow("TC_NB_RENTIBA_AGREE") = 0 'txtRentRenewalIBA
    '                dtRow("TC_NB_RENTIBA_IBA") = 0 'txtOthersIBA
    '                dtRow("TC_NB_DIV_DIS_ATT_INT") = 0 'txtIntDisallow
    '                dtRow("TC_NB_DIV_TOT_ATT_INT") = 0 'txtTotalInterest
    '                dtRow("TC_EA_UTL") = 0 'objExportAllowance(n).strUtilised
    '                dtRow("TC_EA_TYPE") = 0 'objExportAllowance(n).strType
    '                dtRow("TC_EA_CURR_COMPANY") = 0 'objExportAllowance(n).strAllowanceCompany
    '                dtRow("TC_EA_CURR_AGRICULTURE") = 0 'objExportAllowance(n).strAllowanceAgriculture
    '                dtRow("TC_EA_CURR_SIGNIFICANT") = 0 'objExportAllowance(n).strAllowanceSignificant
    '                dtRow("TC_EA_CURR_MARKET") = 0 'objExportAllowance(n).strAllowanceMarket
    '                dtRow("TC_EA_CURR_MSB") = 0 'objExportAllowance(n).strAllowanceService
    '                dtRow("TC_EA_TOTAL") = 0 'objExportAllowance(n).strAllowance
    '                dtRow("TC_EA_RESTRICTRATE") = 0 'objExportAllowance(n).strRestrictRate
    '                dtRow("TC_EA_BF") = 0 'objExportAllowance(n).strBalance
    '                dtRow("TC_EA_CF") = 0 'objExportAllowance(n).strCarryForward
    '                dtRow("TC_TP_ESTIMATED_SME") = "" 'chkSMEFirst2Year
    '                dtRow("TC_NB_DCA_INT") = 0 'txtDCAInterest
    '                dtRow("TC_NB_DEEMED_INT") = 0 'txtDeemedInterest
    '                dtRow("TC_EXEMPTIONCAL") = 0 'txtExemptionIncreaseChargeable
    '                dtRow("TC_EXEMPTIONLESS") = 0 'txtExemptionIncreaseChargeableAfter
    '                dtRow("TC_TP_INSTALL_107C") = 0 'txtInstallments_107C
    '                dtRow("TC_TP_INSTALL_107A") = 0 'txtInstallments_107A
    '                dtRow("TC_TP_RATE7") = 0 'txtRate7
    '                dtRow("TC_TP_APP_CHARGEABLE7") = 0 'txtAppChargeableIn7
    '                dtRow("TC_TP_RATE6_CHARGEABLE") = 0
    '                dtRow("TC_TP_RATE7_CHARGEABLE") = 0
    '                dtRow("TC_EA_TYPE1") = 0
    '                dtRow("TC_EA_TYPE2") = 0
    '                dtRow("TC_EA_TYPE3") = 0
#End Region
    Public Property RefNo As String = ""
    Public Property YA As String = ""
    Public Property SourceNo As Integer = 0
    Public Property dsAdjustIncome As dsAdjustedIncome
    Public Property dsTaxcomputation As dsTaxcomputation
    Public Property TC_KEY As Integer = 0
    Private Property ErrorLog As ClsError = Nothing
    Public Event OnChangeStatus(Status_ As EnumStatus, Stage_ As EnumStage, ErrorLog_ As ClsError)
    Public Event OnLoadTaxcom(dt_ As DataTable, ByVal dtTaxpayer_ As DataTable)
    Public Event OnChangeStatutoryIncome(row_ As DataRow)

    Public Property dtPNL As DataRow = Nothing
    Public Property dtTaxPayer As DataTable = Nothing
    Public Property Status As EnumStatus = EnumStatus.Ready
    Public Property Stage As EnumStatus = EnumStage.none

    Public Property StatutoryIncome As StatutoryIncome

#Region "PROPERTY"
    Public Property TC_REF_NO As String = ""
    Public Property TC_YA As String = ""
    Public Property TC_CO_NAME As String = ""
    Public Property TC_ROC As String = ""
    Public Property TC_BUSINESS As Integer = 0
    Public Property TC_AI_PNL_BAL As Decimal = 0
    Public Property TC_AI_DIVIDEND As Decimal = 0
    Public Property TC_AI_RENTAL As Decimal = 0
    Public Property TC_AI_ROYALTY As Decimal = 0
    Public Property TC_AI_INTEREST As Decimal = 0
    Public Property TC_AI_SEC4A As Decimal = 0
    Public Property TC_AI_TOT_NONBS_IN As Decimal = 0
    Public Property TC_AI_TOT_BS_IN As Decimal = 0
    Public Property TC_AI_ADJ_BS_IN_NA_LOS As Decimal = 0
    Public Property TC_AI_ADJ_BS_IN_NT_IN As Decimal = 0
    Public Property TC_AI_ADJ_BS_IN_TAX_IN As Decimal = 0
    Public Property TC_AI_TOT_ADJ_BS_IN As Decimal = 0
    Public Property TC_AI_ADJ_BS_EXP_INT As Decimal = 0
    Public Property TC_AI_ADJ_BS_EXP_NA_EXP As Decimal = 0
    Public Property TC_AI_ADJ_BS_EXP_RV_EXP As Decimal = 0
    Public Property TC_AI_ADJ_BS_EXP_CLAIM As Decimal = 0
    Public Property TC_AI_TOT_ADJ_BS_EXP As Decimal = 0
    Public Property TC_AI_ADJ_IN_LOSS As Decimal = 0
    Public Property TC_SI_ADJ_BS_IN As Decimal = 0
    Public Property TC_SI_CA As Decimal = 0
    Public Property TC_SI_STAT_BS_IN As Decimal = 0
    Public Property TC_SI_INVEST_ALLOW As Decimal = 0
    Public Property TC_SI_NET_STAT_IN As Decimal = 0
    Public Property TC_SI_SS_RENTAL As Decimal = 0
    Public Property TC_SI_SS_DIR_EXP As Decimal = 0
    Public Property TC_SI_SS_DIR_EXP_QUIT As Decimal = 0
    Public Property TC_SI_SS_DIR_EXP_MAIN As Decimal = 0
    Public Property TC_SI_SS_ADJ_IN As Decimal = 0
    Public Property TC_SI_SS_CA As Decimal = 0
    Public Property TC_SI_SS_STAT_BS_IN As Decimal = 0
    Public Property TC_SI_OTH_SOURCE As Decimal = 0
    Public Property TC_SI_MAIN_BS As Decimal = 0
    Public Property TC_SI_SEC_BS As Decimal = 0
    Public Property TC_SI_OTH_BS As Decimal = 0
    Public Property TC_SI_TOT As Decimal = 0
    Public Property TC_SI_BS_LOSS_BF As Decimal = 0
    Public Property TC_SI_AGGREGATE As Decimal = 0
    Public Property TC_NB_DIV As Decimal = 0
    Public Property TC_NB_DIV_ATT_INT As Decimal = 0
    Public Property TC_NB_DIV_NET As Decimal = 0
    Public Property TC_NB_INT As Decimal = 0
    Public Property TC_NB_INT_ATT_INT As Decimal = 0
    Public Property TC_NB_INT_NET As Decimal = 0
    Public Property TC_NB_RENT As Decimal = 0
    Public Property TC_NB_RENT_ATT_INT As Decimal = 0
    Public Property TC_NB_RENT_ASSESS As Decimal = 0
    Public Property TC_NB_RENT_QUIT As Decimal = 0
    Public Property TC_NB_RENT_INSUR As Decimal = 0
    Public Property TC_NB_RENT_OTH As Decimal = 0
    Public Property TC_NB_RENT_MAIN As Decimal = 0
    Public Property TC_NB_RENT_AGREE As Decimal = 0
    Public Property TC_NB_RENT_NET As Decimal = 0
    Public Property TC_NB_SUNDRY As Decimal = 0
    Public Property TC_NB_OTH_AGGR_STAT As Decimal = 0
    Public Property TC_TP_AGGR_IN As Decimal = 0
    Public Property TC_TP_CURR_LOSS As Decimal = 0
    Public Property TC_TP_AGGR_IN_LOSS As Decimal = 0
    Public Property TC_TP_APRV_DONATION As Decimal = 0
    Public Property TC_TP_CHARGEABLE As Decimal = 0
    Public Property TC_TP_28_CHARGEABLE As Decimal = 0
    Public Property TC_TP_SEC110 As Decimal = 0
    Public Property TC_TP_SEC132 As Decimal = 0
    Public Property TC_TP_SEC133 As Decimal = 0
    Public Property TC_TP_TOT_SETOFF As Decimal = 0
    Public Property TC_TP_PAYABLE As Decimal = 0
    Public Property TC_TP_INSTALL As Decimal = 0
    Public Property TC_TP_PAYABLE_BAL As Decimal = 0
    Public Property TC_CB_CA_BAL_BF As Decimal = 0
    Public Property TC_CB_CA_CURR As Decimal = 0
    Public Property TC_CB_CA_AA As Decimal = 0
    Public Property TC_CB_CA_IA As Decimal = 0
    Public Property TC_CB_CA_BA As Decimal = 0
    Public Property TC_CB_CA_UTIL As Decimal = 0
    Public Property TC_CB_CA_BAL_CF As Decimal = 0
    Public Property TC_CB_LS_BAL_BF As Decimal = 0
    Public Property TC_CB_LS_UTIL As Decimal = 0
    Public Property TC_CB_LS_BAL_UTIL As Decimal = 0
    Public Property TC_CB_LS_UNABSORBED As Decimal = 0
    Public Property TC_CB_LS_BAL_CF As Decimal = 0
    Public Property TC_CB_ITA_BAL_BF As Decimal = 0
    Public Property TC_CB_ITA_CURR As Decimal = 0
    Public Property TC_CB_ITA_BAL_BF_CURR As Decimal = 0
    Public Property TC_CB_ITA_UTIL As Decimal = 0
    Public Property TC_CB_ITA_BAL_CF As Decimal = 0
    Public Property TC_AI_OTH_BS_IN As Decimal = 0
    Public Property TC_TP_RATE1 As Integer = 0
    Public Property TC_TP_RATE2 As Integer = 0
    Public Property TC_TP_RATE3 As Integer = 0
    Public Property TC_TP_RATE4 As Integer = 0
    Public Property TC_TP_RATE5 As Integer = 0
    Public Property TC_TP_RATE6 As Integer = 0
    Public Property TC_TP_APP_CHARGEABLE1 As Decimal = 0
    Public Property TC_TP_APP_CHARGEABLE2 As Decimal = 0
    Public Property TC_TP_APP_CHARGEABLE3 As Decimal = 0
    Public Property TC_TP_APP_CHARGEABLE4 As Decimal = 0
    Public Property TC_TP_APP_CHARGEABLE5 As Decimal = 0
    Public Property TC_TP_APP_CHARGEABLE6 As Decimal = 0
    Public Property TC_TP_RATE1_CHARGEABLE As Decimal = 0
    Public Property TC_TP_RATE2_CHARGEABLE As Decimal = 0
    Public Property TC_TP_RATE3_CHARGEABLE As Decimal = 0
    Public Property TC_TP_RATE4_CHARGEABLE As Decimal = 0
    Public Property TC_TP_RATE5_CHARGEABLE As Decimal = 0
    Public Property TC_TP_TOT_TAX_CHARGED As Decimal = 0
    Public Property TC_TP_SEC6B_REBATE As Decimal = 0
    Public Property TC_TP_SEC110_OTHERS As Decimal = 0
    Public Property TC_TP_PROSPECTING As Decimal = 0
    Public Property TC_TP_QUALIFY_AGRICULTURE As Decimal = 0
    Public Property TC_TP_PREOP_BS As Decimal = 0
    Public Property TC_TP_FOOD_PRODUCTION As Decimal = 0
    Public Property TC_TP_EXP_ALLOWED As Decimal = 0
    Public Property TC_TP_TOTAL_OTH_EXP As Decimal = 0
    Public Property TC_TP_TOTAL_INCOME As Decimal = 0
    Public Property TC_TP_PIONEER_CHARGE As Decimal = 0
    Public Property TC_TP_OPERATIONALHQ_CHARGE As Decimal = 0
    Public Property TC_TP_FOREIGN_CHARGE As Decimal = 0
    Public Property TC_TP_BS_LOSS As Decimal = 0
    Public Property TC_NB_ROYALTY As Decimal = 0
    Public Property TC_NB_ADDITION As Decimal = 0
    Public Property TC_CB_LS_ADJUST_LOSS As Decimal = 0
    Public Property TC_CB_LS_UTIL_CURR As Decimal = 0
    Public Property TC_SI_RA As Decimal = 0
    Public Property TC_CB_RA_BAL_BF As Decimal = 0
    Public Property TC_CB_RA_CURR As Decimal = 0
    Public Property TC_CB_RA_BAL_BF_CURR As Decimal = 0
    Public Property TC_CB_RA_UTIL As Decimal = 0
    Public Property TC_CB_RA_BAL_CF As Decimal = 0
    Public Property TC_SI_BC As Decimal = 0
    Public Property TC_SI_ADJ_BS_IN_BC As Decimal = 0
    Public Property TC_CB_CA_CURR_BA As Decimal = 0
    Public Property TC_TP_RATE4A As Integer = 0
    Public Property TC_TP_APP_CHARGEABLE4A As Decimal = 0
    Public Property TC_TP_RATE4A_CHARGEABLE As Decimal = 0
    Public Property TC_CB_CA_NA As Decimal = 0
    Public Property TC_TP_ZAKAT As Decimal = 0
    Public Property TC_OTHERDEDUCTION As Decimal = 0
    Public Property TC_CB_CA_DISALLOW As Decimal = 0
    Public Property TC_CB_CA_ABAL_CF As Decimal = 0
    Public Property TC_CB_CHECK As Double = 0
    Public Property TC_TP_CLAIM As Decimal = 0
    Public Property TC_CB_LS_SAMOUNT As Decimal = 0
    Public Property TC_CB_LS_BALS_CF As Decimal = 0
    Public Property TC_CB_LS_D_BL As Decimal = 0
    Public Property TC_CB_LS_SRDAMT2 As Decimal = 0
    Public Property TC_CB_LS_BLNBF As Decimal = 0
    Public Property TC_CB_LS_AMTTUT As Decimal = 0
    Public Property TC_CB_LS_BLNCF As Decimal = 0
    Public Property TC_COMPANY As String = ""
    Public Property TC_PIONEERDESC As String = ""
    Public Property TC_PIO As String = ""
    Public Property TC_PIONEER As Decimal = 0
    Public Property TC_RA_RATE1 As Decimal = 0
    Public Property TC_RA_QUALIFYINGCAPITALEXP As Decimal = 0
    Public Property TC_RA_QUALIFYINGCAPITALEXP_AMOUNT As Decimal = 0
    Public Property TC_RA_BALANCINGALLOWANCE As Decimal = 0
    Public Property TC_RA_TOTAL1 As Decimal = 0
    Public Property TC_RA_RESTRICTRATE As Decimal = 0
    Public Property TC_RA_RESTRICTAMOUNT As Decimal = 0
    Public Property TC_ITA_RATE1 As Decimal = 0
    Public Property TC_ITA_QUALIFYINGCAPITALEXP As Decimal = 0
    Public Property TC_ITA_QUALIFYINGCAPITALEXP_AMOUNT As Decimal = 0
    Public Property TC_ITA_BALANCINGALLOWANCE As Decimal = 0
    Public Property TC_ITA_TOTAL1 As Decimal = 0
    Public Property TC_ITA_RESTRICTRATE As Decimal = 0
    Public Property TC_ITA_RESTRICTAMOUNT As Decimal = 0
    Public Property TC_DISALLOW_NOTE As String = ""
    Public Property TC_DISALLOWBUSINESS_NOTE As String = ""
    Public Property TC_SURPLUSRECOVERED As Decimal = 0
    Public Property TC_MININGALLOWNANCE As Decimal = 0
    Public Property TC_MININGEXPENSES As Decimal = 0
    Public Property TC_STAT_DIVIDEND As Decimal = 0
    Public Property TC_TP_SEC110B As Decimal = 0
    Public Property TC_NB_RENT_OTH2 As Decimal = 0
    Public Property TC_NB_CARRYBCKLOSS As Decimal = 0
    Public Property TC_NB_AMTNOTCARRYBCK As Decimal = 0
    Public Property TC_NB_CHKCB As Boolean = False
    Public Property TC_TP_INCOME_TP2 As Decimal = 0
    Public Property TC_TP_ESTIMATED_TP As Decimal = 0
    Public Property TC_TP_INCOME_TP3 As Decimal = 0
    Public Property TC_TP_ALL_DIFF As Decimal = 0
    Public Property TC_TP_EX_DIFF As Decimal = 0
    Public Property TC_TP_PEN_DIFF As Decimal = 0
    Public Property TC_WITHRAITA As Decimal = 0
    Public Property TC_RA_WITHDRAWAL As Decimal = 0
    Public Property TC_RA_ADJUSTMENT As Decimal = 0
    Public Property TC_ITA_WITHDRAWAL As Decimal = 0
    Public Property TC_ITA_ADJUSTMENT As Decimal = 0
    Public Property TC_NB_DIV_OTH As Decimal = 0
    Public Property TC_NB_INT_OTH As Decimal = 0
    Public Property TC_SUNDRY_EXP As Decimal = 0
    Public Property TC_CHK_EXEMP As String = ""
    Public Property TC_SI_TOT_PARTNERSHIP As Decimal = 0
    Public Property TC_CB_CA_ACA As Decimal = 0
    Public Property TC_NB_RENTIBA As Decimal = 0
    Public Property TC_NB_RENTIBA_ATT_IN As Decimal = 0
    Public Property TC_NB_RENTIBA_ASSESS As Decimal = 0
    Public Property TC_NB_RENTIBA_QUIT As Decimal = 0
    Public Property TC_NB_RENTIBA_INSUR As Decimal = 0
    Public Property TC_NB_RENTIBA_OTH As Decimal = 0
    Public Property TC_NB_RENTIBA_MAIN As Decimal = 0
    Public Property TC_NB_RENTIBA_AGREE As Decimal = 0
    Public Property TC_NB_RENTIBA_IBA As Decimal = 0
    Public Property TC_NB_DIV_DIS_ATT_INT As Decimal = 0
    Public Property TC_NB_DIV_TOT_ATT_INT As Decimal = 0
    Public Property TC_EA_UTL As Decimal = 0
    Public Property TC_EA_TYPE As Decimal = 0
    Public Property TC_EA_CURR_COMPANY As Decimal = 0
    Public Property TC_EA_CURR_AGRICULTURE As Decimal = 0
    Public Property TC_EA_CURR_SIGNIFICANT As Decimal = 0
    Public Property TC_EA_CURR_MARKET As Decimal = 0
    Public Property TC_EA_CURR_MSB As Decimal = 0
    Public Property TC_EA_TOTAL As Decimal = 0
    Public Property TC_EA_RESTRICTRATE As Decimal = 0
    Public Property TC_EA_BF As Decimal = 0
    Public Property TC_EA_CF As Decimal = 0
    Public Property TC_TP_ESTIMATED_SME As String = ""
    Public Property TC_NB_DCA_INT As Decimal = 0
    Public Property TC_NB_DEEMED_INT As Decimal = 0
    Public Property TC_EXEMPTIONCAL As Decimal = 0
    Public Property TC_EXEMPTIONLESS As Decimal = 0
    Public Property TC_TP_INSTALL_107C As Decimal = 0
    Public Property TC_TP_INSTALL_107A As Decimal = 0
    Public Property TC_TP_RATE7 As Integer = 0
    Public Property TC_TP_APP_CHARGEABLE7 As Decimal = 0
    Public Property TC_TP_RATE6_CHARGEABLE As Decimal = 0
    Public Property TC_TP_RATE7_CHARGEABLE As Decimal = 0
    Public Property TC_EA_TYPE1 As Decimal = 0
    Public Property TC_EA_TYPE2 As Decimal = 0
    Public Property TC_EA_TYPE3 As Decimal = 0
#End Region
   
    Enum EnumStatus
        Ready = 0
        InProgress = 1
        Done = 2
        Failed = 3
        isInvestmentHolding = 4
    End Enum
    Enum EnumStage
        none = 0
        Load = 1
        Save = 2
        Validating = 3
        Calculating = 4
    End Enum
    Sub New()
        If ErrorLog Is Nothing Then
            ErrorLog = New ClsError
        End If

        If StatutoryIncome Is Nothing Then
            StatutoryIncome = New StatutoryIncome
        End If
    End Sub
    Public Sub ChangeStatus(ByVal Status_ As EnumStatus, ByVal Stage_ As EnumStage)
        Try
            Status = Status_
            RaiseEvent OnChangeStatus(Status_, Stage_, ErrorLog)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub SaveData()
        Try
            Dim ListofSQLCmd As List(Of SqlCommand) = Nothing
            Dim dt As DataTable = Nothing

            dt = Me.Load_Taxcomputation(SourceNo)

            dtTaxPayer = LoadTaxPayer_ByRefNO(RefNo, ErrorLog)

            If dtTaxPayer Is Nothing Then
                ChangeStatus(EnumStatus.Failed, EnumStage.Save)
                Exit Sub
            End If

            TC_KEY = TC_KEY
            TC_REF_NO = RefNo
            TC_YA = YA
            TC_CO_NAME = dtTaxPayer.Rows(0)("TP_COM_NAME")
            TC_ROC = dtTaxPayer.Rows(0)("TP_ROC_NO")
            TC_BUSINESS = SourceNo

            ListofSQLCmd = New List(Of SqlCommand)

            If Me.DELETE_NON_ALLOW_LOSS(ListofSQLCmd) = False Then
                ChangeStatus(EnumStatus.Failed, EnumStage.Save)
                Exit Sub
            End If

            If Me.DELETE_SURPLUS_RECOVERED(ListofSQLCmd) = False Then
                ChangeStatus(EnumStatus.Failed, EnumStage.Save)
                Exit Sub
            End If

            If Me.DELETE_TAXABLE_INCOME(ListofSQLCmd) = False Then
                ChangeStatus(EnumStatus.Failed, EnumStage.Save)
                Exit Sub
            End If

            If Me.DELETE_MINING_ALLOWNANCE(ListofSQLCmd) = False Then
                ChangeStatus(EnumStatus.Failed, EnumStage.Save)
                Exit Sub
            End If

            If Me.DELETE_MINING_EXPENSES(ListofSQLCmd) = False Then
                ChangeStatus(EnumStatus.Failed, EnumStage.Save)
                Exit Sub
            End If

            If Me.DELETE_REVENUE_EXPENDITURE(ListofSQLCmd) = False Then
                ChangeStatus(EnumStatus.Failed, EnumStage.Save)
                Exit Sub
            End If

            If Me.DELETE_OTHER_DEDUCTION(ListofSQLCmd) = False Then
                ChangeStatus(EnumStatus.Failed, EnumStage.Save)
                Exit Sub
            End If

            If Me.DELETE_OTHER_EXPENDITURE(ListofSQLCmd) = False Then
                ChangeStatus(EnumStatus.Failed, EnumStage.Save)
                Exit Sub
            End If


            If Me.Save_NON_ALLOW_LOSS(ListofSQLCmd) = False Then
                ChangeStatus(EnumStatus.Failed, EnumStage.Save)
                Exit Sub
            End If

            If Me.Save_SURPLUS_RECOVERED(ListofSQLCmd) = False Then
                ChangeStatus(EnumStatus.Failed, EnumStage.Save)
                Exit Sub
            End If

            If Me.Save_TAXABLE_INCOME(ListofSQLCmd) = False Then
                ChangeStatus(EnumStatus.Failed, EnumStage.Save)
                Exit Sub
            End If

            If Me.Save_MINING_ALLOWNANCE(ListofSQLCmd) = False Then
                ChangeStatus(EnumStatus.Failed, EnumStage.Save)
                Exit Sub
            End If

            If Me.Save_MINING_EXPENSES(ListofSQLCmd) = False Then
                ChangeStatus(EnumStatus.Failed, EnumStage.Save)
                Exit Sub
            End If

            If Me.Save_REVENUE_EXPENDITURE(ListofSQLCmd) = False Then
                ChangeStatus(EnumStatus.Failed, EnumStage.Save)
                Exit Sub
            End If

            If Me.Save_OTHER_DEDUCTION(ListofSQLCmd) = False Then
                ChangeStatus(EnumStatus.Failed, EnumStage.Save)
                Exit Sub
            End If

            If Me.Save_OTHER_EXPENDITURE(ListofSQLCmd) = False Then
                ChangeStatus(EnumStatus.Failed, EnumStage.Save)
                Exit Sub
            End If


            If dt Is Nothing Then
                'New
                TC_KEY = GetLastTC_KEY()

                If TC_KEY = -1 Then
                    ChangeStatus(EnumStatus.Failed, EnumStage.Save)
                    Exit Sub
                End If

                TC_KEY += 1

                If Me.Save_Taxcomputation(ListofSQLCmd) = False Then
                    ChangeStatus(EnumStatus.Failed, EnumStage.Save)
                    Exit Sub
                End If

            Else
                'Update
                TC_KEY = IIf(IsDBNull(dt.Rows(0)("TC_KEY")), 0, dt.Rows(0)("TC_KEY"))

                If Me.Update_Taxcomputation(ListofSQLCmd) = False Then
                    ChangeStatus(EnumStatus.Failed, EnumStage.Save)
                    Exit Sub
                End If
            End If

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                ChangeStatus(EnumStatus.Failed, EnumStage.Save)
                Exit Sub
            End If

            If Me.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofSQLCmd, SqlCon, "", ErrorLog) Then
                ChangeStatus(EnumStatus.Done, EnumStage.Save)
            Else
                ChangeStatus(EnumStatus.Failed, EnumStage.Save)
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(ErrorLog)
            ChangeStatus(EnumStatus.Failed, EnumStage.Save)
        End Try
    End Sub
    Public Sub StatutoryIncome_BySource(ByVal row As DataRow)
        Try

            ChangeStatus(EnumStatus.Ready, EnumStage.Calculating)

            Dim TC_AI_TOT_BS_IN_ As Decimal = 0
            Dim TC_AI_TOT_ADJ_BS_IN_ As Decimal = 0
            Dim TC_AI_TOT_ADJ_BS_EXP_ As Decimal = 0
            Dim TC_AI_ADJ_IN_LOSS_ As Decimal = 0
            Dim TC_SI_ADJ_BS_IN_ As Decimal = 0
            Dim TC_SI_BC_ As Decimal = 0
            Dim TC_SI_ADJ_BS_IN_BC_ As Decimal = 0
            Dim TC_SI_CA_ As Decimal = 0
            Dim TC_SI_STAT_BS_IN_ As Decimal = 0
            Dim TC_SI_RA_ As Decimal = 0
            Dim TC_SI_INVEST_ALLOW_ As Decimal = 0
            Dim TC_RA_QUALIFYINGCAPITALEXP_AMOUNT_ As Decimal = 0
            Dim TC_PIONEER_ As Decimal = 0
            Dim TC_WITHRAITA_ As Decimal = 0
            Dim TC_CHK_EXEMP As String = "N"

            Dim TC_RA_RATE1_ As Decimal = 0
            Dim TC_RA_QUALIFYINGCAPITALEXP_ As Decimal = 0
            Dim TC_RA_BALANCINGALLOWANCE_ As Decimal = 0
            Dim TC_RA_TOTAL1_ As Decimal = 0


            ChangeStatus(EnumStatus.InProgress, EnumStage.Calculating)

            'ADD
            TC_AI_TOT_BS_IN_ = IIf(IsDBNull(row("TC_AI_TOT_BS_IN")), 0, row("TC_AI_TOT_BS_IN"))
            TC_AI_TOT_ADJ_BS_IN_ = IIf(IsDBNull(row("TC_AI_TOT_ADJ_BS_IN")), 0, row("TC_AI_TOT_ADJ_BS_IN"))
            TC_AI_TOT_ADJ_BS_EXP_ = IIf(IsDBNull(row("TC_AI_TOT_ADJ_BS_EXP")), 0, row("TC_AI_TOT_ADJ_BS_EXP"))
            TC_AI_ADJ_IN_LOSS_ = IIf(IsDBNull(row("TC_AI_ADJ_IN_LOSS")), 0, row("TC_AI_ADJ_IN_LOSS"))
            TC_SI_BC_ = IIf(IsDBNull(row("TC_SI_BC")), 0, row("TC_SI_BC"))
            TC_SI_CA_ = IIf(IsDBNull(row("TC_SI_CA")), 0, row("TC_SI_CA"))

            TC_RA_RATE1_ = IIf(IsDBNull(row("TC_RA_RATE1")), 0, row("TC_RA_RATE1"))
            TC_RA_QUALIFYINGCAPITALEXP_ = IIf(IsDBNull(row("TC_RA_QUALIFYINGCAPITALEXP")), 0, row("TC_RA_QUALIFYINGCAPITALEXP"))
            TC_RA_BALANCINGALLOWANCE_ = IIf(IsDBNull(row("TC_RA_BALANCINGALLOWANCE")), 0, row("TC_RA_BALANCINGALLOWANCE"))
            TC_RA_TOTAL1_ = IIf(IsDBNull(row("TC_RA_TOTAL1")), 0, row("TC_RA_TOTAL1"))
            TC_RA_QUALIFYINGCAPITALEXP_AMOUNT_ = IIf(IsDBNull(row("TC_RA_QUALIFYINGCAPITALEXP_AMOUNT")), 0, row("TC_RA_QUALIFYINGCAPITALEXP_AMOUNT"))

            TC_SI_ADJ_BS_IN_ = TC_AI_TOT_BS_IN_ + TC_AI_TOT_ADJ_BS_IN_ + TC_AI_TOT_ADJ_BS_EXP_ + TC_AI_ADJ_IN_LOSS_

            TC_SI_ADJ_BS_IN_BC_ = TC_SI_ADJ_BS_IN_ + TC_SI_BC_

            TC_SI_STAT_BS_IN_ = TC_SI_ADJ_BS_IN_BC_ + TC_SI_CA_

            'LESS
            TC_SI_RA_ = IIf(IsDBNull(row("TC_SI_RA")), 0, row("TC_SI_RA"))
            TC_SI_INVEST_ALLOW_ = IIf(IsDBNull(row("TC_SI_INVEST_ALLOW")), 0, row("TC_SI_INVEST_ALLOW"))
            TC_RA_QUALIFYINGCAPITALEXP_AMOUNT_ = IIf(IsDBNull(row("TC_RA_QUALIFYINGCAPITALEXP_AMOUNT")), 0, row("TC_RA_QUALIFYINGCAPITALEXP_AMOUNT"))
            TC_CHK_EXEMP = IIf(IsDBNull(row("TC_CHK_EXEMP")), "N", row("TC_CHK_EXEMP"))
            If TC_CHK_EXEMP = "Y" Then
                TC_PIONEER_ = IIf(IsDBNull(row("TC_PIONEER")), 0, row("TC_PIONEER"))
            Else
                TC_PIONEER_ = Me.Calculate_Pioneer(TC_SI_STAT_BS_IN, IIf(IsDBNull(row("TC_PIO")), 0, row("TC_PIO")))
            End If

            TC_WITHRAITA_ = IIf(IsDBNull(row("TC_WITHRAITA")), 0, row("TC_WITHRAITA"))

            TC_SI_NET_STAT_IN_ = TC_SI_STAT_BS_IN_ - (TC_SI_RA_ + TC_SI_INVEST_ALLOW_ + TC_RA_QUALIFYINGCAPITALEXP_AMOUNT_ + TC_PIONEER_ + TC_WITHRAITA_)




            ChangeStatus(EnumStatus.Done, EnumStage.Calculating)


            row("TC_AI_TOT_BS_IN") = TC_AI_TOT_BS_IN_
            row("TC_AI_TOT_ADJ_BS_IN") = TC_AI_TOT_ADJ_BS_IN_
            row("TC_AI_TOT_ADJ_BS_EXP") = TC_AI_TOT_ADJ_BS_EXP_
            row("TC_AI_ADJ_IN_LOSS") = TC_AI_ADJ_IN_LOSS_
            row("TC_SI_BC") = TC_SI_BC_
            row("TC_SI_ADJ_BS_IN_BC") = TC_SI_ADJ_BS_IN_BC_
            row("TC_SI_CA") = TC_SI_CA_
            row("TC_SI_STAT_BS_IN") = TC_SI_STAT_BS_IN_
            row("TC_PIONEER") = TC_PIONEER_
            row("TC_WITHRAITA") = TC_WITHRAITA_
            row("TC_SI_NET_STAT_IN") = TC_SI_NET_STAT_IN_

            row("TC_RA_RATE1") = TC_RA_RATE1_
            row("TC_RA_QUALIFYINGCAPITALEXP") = TC_RA_QUALIFYINGCAPITALEXP_
            row("TC_RA_QUALIFYINGCAPITALEXP_AMOUNT") = TC_RA_QUALIFYINGCAPITALEXP_AMOUNT_
            row("TC_RA_BALANCINGALLOWANCE") = TC_RA_BALANCINGALLOWANCE_
            row("TC_RA_TOTAL1") = TC_RA_TOTAL1_

            RaiseEvent OnChangeStatutoryIncome(row)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(ErrorLog)
            ChangeStatus(EnumStatus.Failed, EnumStage.Calculating)

        End Try
    End Sub
    Public Function Calculate_Pioneer(ByVal TC_SI_STAT_BS_IN As Decimal, ByVal TC_PIO As Integer) As Decimal
        Try
            Dim Total As Decimal = 0


            Total = ((TC_PIO / 100) * TC_SI_STAT_BS_IN) + TC_SI_STAT_BS_IN

            Return Total
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(ErrorLog)
            ChangeStatus(EnumStatus.Failed, EnumStage.Calculating)

            Return 0
        End Try
    End Function
#Region "LOAD"
    Public Sub LoadData()
        Try
            Dim dt As DataTable = Me.Load_Taxcomputation()

            If dt Is Nothing Then
                ChangeStatus(EnumStatus.Failed, EnumStage.Load)
                Exit Sub
            End If

            Dim dtTaxPayer As DataTable = ADO.LoadTaxPayer_ByRefNO(RefNo, ErrorLog)

            If dtTaxPayer Is Nothing Then
                ChangeStatus(EnumStatus.Failed, EnumStage.Load)
                Exit Sub
            End If


            Me.LoadStatutoryIncome()


            RaiseEvent OnLoadTaxcom(dt, dtTaxPayer)

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(ErrorLog)
            ChangeStatus(EnumStatus.Failed, EnumStage.Load)
        End Try
    End Sub
    Public Sub LoadStatutoryIncome()
        Try
            If dsTaxcomputation Is Nothing Then
                dsTaxcomputation = New dsTaxcomputation
            End If

            Dim dt As DataTable = Nothing

            dt = Me.Load_Taxcomputation()

            dsTaxcomputation.Tables("STATUTORY_INCOME").Rows.Clear()

            If dt IsNot Nothing Then
                Dim dtRow As DataRow = Nothing
                Dim dtBusinessSource As DataTable = Nothing
                For Each rowx As DataRow In dt.Rows
                    dtRow = Nothing
                    dtRow = dsTaxcomputation.Tables("STATUTORY_INCOME").NewRow

                    For Each clm As DataColumn In dsTaxcomputation.Tables("STATUTORY_INCOME").Columns
                        Select Case clm.ColumnName
                            Case "BC_TYPE"
                                dtBusinessSource = Me.LoadSourceNo2(RefNo, YA)
                                If dtBusinessSource IsNot Nothing AndAlso IsDBNull(dtBusinessSource.Rows(0)("BC_TYPE")) = False Then
                                    dtRow("BC_TYPE") = dtBusinessSource.Rows(0)("BC_TYPE")
                                Else
                                    dtRow("BC_TYPE") = ""
                                End If

                            Case Else
                                dtRow(clm.ColumnName) = rowx(clm.ColumnName)
                        End Select

                    Next

                    dsTaxcomputation.Tables("STATUTORY_INCOME").Rows.Add(dtRow)
                Next
            End If

            dt = Nothing


        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(ErrorLog)
            ChangeStatus(EnumStatus.Failed, EnumStage.Load)
        End Try
    End Sub
#End Region
#Region "DATABASE"
    Private Function Save_NON_ALLOW_LOSS(ByRef ListOfSQLCmd As List(Of SqlCommand)) As Boolean
        Try
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = ""
            For Each rowData As DataRow In dsAdjustIncome.Tables("NON_ALLOW_LOSS").Rows

                If IsDBNull(rowData("NL_CATEGORIZED")) = False AndAlso rowData("NL_CATEGORIZED") <> "PNL" Then
                    StrSQL = "INSERT INTO NON_ALLOW_LOSS(NL_REF_NO,NL_YA,NL_DESC,NL_AMOUNT,NL_CATEGORIZED,NL_SOURCENO) VALUES (@NL_REF_NO,@NL_YA,@NL_DESC,@NL_AMOUNT,@NL_CATEGORIZED,@NL_SOURCENO)"

                    SQLcmd = New SqlCommand With {
                      .CommandText = StrSQL
                    }
                    SQLcmd.Parameters.Add("@NL_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
                    SQLcmd.Parameters.Add("@NL_YA", SqlDbType.NVarChar, 5).Value = YA
                    SQLcmd.Parameters.Add("@NL_DESC", SqlDbType.NVarChar, 255).Value = IIf(IsDBNull(rowData("NL_DESC")), "", rowData("NL_DESC"))
                    SQLcmd.Parameters.Add("@NL_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(rowData("NL_AMOUNT")), 0, rowData("NL_AMOUNT"))
                    SQLcmd.Parameters.Add("@NL_CATEGORIZED", SqlDbType.NVarChar, 10).Value = IIf(IsDBNull(rowData("NL_CATEGORIZED")), "", rowData("NL_CATEGORIZED"))
                    SQLcmd.Parameters.Add("@NL_SOURCENO", SqlDbType.Int).Value = IIf(IsDBNull(rowData("NL_SOURCENO")), 0, rowData("NL_SOURCENO"))


                    ListOfSQLCmd.Add(SQLcmd)
                End If

            Next

            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Private Function Save_SURPLUS_RECOVERED(ByRef ListOfSQLCmd As List(Of SqlCommand)) As Boolean
        Try
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = ""
            For Each rowData As DataRow In dsAdjustIncome.Tables("SURPLUS_RECOVERED").Rows
                StrSQL = "INSERT INTO SURPLUS_RECOVERED(SR_REF_NO,SR_YA,SR_DESC,SR_AMOUNT,SR_SOURCENO) VALUES (@SR_REF_NO,@SR_YA,@SR_DESC,@SR_AMOUNT,@SR_SOURCENO)"

                SQLcmd = New SqlCommand With {
                  .CommandText = StrSQL
                }
                SQLcmd.Parameters.Add("@SR_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
                SQLcmd.Parameters.Add("@SR_YA", SqlDbType.NVarChar, 5).Value = YA
                SQLcmd.Parameters.Add("@SR_DESC", SqlDbType.NVarChar, 255).Value = IIf(IsDBNull(rowData("SR_DESC")), "", rowData("SR_DESC"))
                SQLcmd.Parameters.Add("@SR_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(rowData("SR_AMOUNT")), 0, rowData("SR_AMOUNT"))
                SQLcmd.Parameters.Add("@SR_SOURCENO", SqlDbType.Int).Value = IIf(IsDBNull(rowData("SR_SOURCENO")), 0, rowData("SR_SOURCENO"))

                ListOfSQLCmd.Add(SQLcmd)
            Next

            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Private Function Save_TAXABLE_INCOME(ByRef ListOfSQLCmd As List(Of SqlCommand)) As Boolean
        Try
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = ""
            For Each rowData As DataRow In dsAdjustIncome.Tables("TAXABLE_INCOME").Rows
                If IsDBNull(rowData("TI_TYPE")) = False AndAlso rowData("TI_TYPE") <> -1 Then
                    StrSQL = "INSERT INTO TAXABLE_INCOME(TI_REF_NO,TI_YA,TI_DESC,TI_AMOUNT,TI_SOURCENO,TI_TYPE,TI_REFID) VALUES (@TI_REF_NO,@TI_YA,@TI_DESC,@TI_AMOUNT,@TI_SOURCENO,@TI_TYPE,@TI_REFID)"

                    SQLcmd = New SqlCommand With {
                      .CommandText = StrSQL
                    }
                    SQLcmd.Parameters.Add("@TI_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
                    SQLcmd.Parameters.Add("@TI_YA", SqlDbType.NVarChar, 5).Value = YA
                    SQLcmd.Parameters.Add("@TI_DESC", SqlDbType.NVarChar, 255).Value = IIf(IsDBNull(rowData("TI_DESC")), "", rowData("TI_DESC"))
                    SQLcmd.Parameters.Add("@TI_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(rowData("TI_AMOUNT")), 0, rowData("TI_AMOUNT"))
                    SQLcmd.Parameters.Add("@TI_SOURCENO", SqlDbType.Int).Value = IIf(IsDBNull(rowData("TI_SOURCENO")), 0, rowData("TI_SOURCENO"))
                    SQLcmd.Parameters.Add("@TI_TYPE", SqlDbType.Int).Value = IIf(IsDBNull(rowData("TI_TYPE")), 0, rowData("TI_TYPE"))
                    SQLcmd.Parameters.Add("@TI_REFID", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowData("TI_REFID")), "", rowData("TI_REFID"))


                    ListOfSQLCmd.Add(SQLcmd)
                End If

            Next

            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Private Function Save_MINING_ALLOWNANCE(ByRef ListOfSQLCmd As List(Of SqlCommand)) As Boolean
        Try
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = ""
            For Each rowData As DataRow In dsAdjustIncome.Tables("MINING_ALLOWNANCE").Rows
                StrSQL = "INSERT INTO MINING_ALLOWNANCE(MA_REF_NO,MA_YA,MA_DESC,MA_AMOUNT,MA_SOURCENO) VALUES (@MA_REF_NO,@MA_YA,@MA_DESC,@MA_AMOUNT,@MA_SOURCENO)"

                SQLcmd = New SqlCommand With {
                  .CommandText = StrSQL
                }
                SQLcmd.Parameters.Add("@MA_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
                SQLcmd.Parameters.Add("@MA_YA", SqlDbType.NVarChar, 5).Value = YA
                SQLcmd.Parameters.Add("@MA_DESC", SqlDbType.NVarChar, 255).Value = IIf(IsDBNull(rowData("MA_DESC")), "", rowData("MA_DESC"))
                SQLcmd.Parameters.Add("@MA_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(rowData("MA_AMOUNT")), 0, rowData("MA_AMOUNT"))
                SQLcmd.Parameters.Add("@MA_SOURCENO", SqlDbType.Int).Value = IIf(IsDBNull(rowData("MA_SOURCENO")), 0, rowData("MA_SOURCENO"))

                ListOfSQLCmd.Add(SQLcmd)
            Next

            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Private Function Save_MINING_EXPENSES(ByRef ListOfSQLCmd As List(Of SqlCommand)) As Boolean
        Try
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = ""
            For Each rowData As DataRow In dsAdjustIncome.Tables("MINING_EXPENSES").Rows
                StrSQL = "INSERT INTO MINING_EXPENSES(ME_REF_NO,ME_YA,ME_DESC,ME_AMOUNT,ME_SOURCENO) VALUES (@ME_REF_NO,@ME_YA,@ME_DESC,@ME_AMOUNT,@ME_SOURCENO)"

                SQLcmd = New SqlCommand With {
                  .CommandText = StrSQL
                }
                SQLcmd.Parameters.Add("@ME_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
                SQLcmd.Parameters.Add("@ME_YA", SqlDbType.NVarChar, 5).Value = YA
                SQLcmd.Parameters.Add("@ME_DESC", SqlDbType.NVarChar, 255).Value = IIf(IsDBNull(rowData("ME_DESC")), "", rowData("ME_DESC"))
                SQLcmd.Parameters.Add("@ME_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(rowData("ME_AMOUNT")), 0, rowData("ME_AMOUNT"))
                SQLcmd.Parameters.Add("@ME_SOURCENO", SqlDbType.Int).Value = IIf(IsDBNull(rowData("ME_SOURCENO")), 0, rowData("ME_SOURCENO"))


                ListOfSQLCmd.Add(SQLcmd)
            Next

            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Private Function Save_REVENUE_EXPENDITURE(ByRef ListOfSQLCmd As List(Of SqlCommand)) As Boolean
        Try
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = ""
            For Each rowData As DataRow In dsAdjustIncome.Tables("REVENUE_EXPENDITURE").Rows
                StrSQL = "INSERT INTO REVENUE_EXPENDITURE(RE_REF_NO,RE_YA,RE_DESC,RE_AMOUNT,RE_SOURCENO,RE_TYPE,RE_REFID) VALUES (@RE_REF_NO,@RE_YA,@RE_DESC,@RE_AMOUNT,@RE_SOURCENO,@RE_TYPE,@RE_REFID)"

                SQLcmd = New SqlCommand With {
                  .CommandText = StrSQL
                }
                SQLcmd.Parameters.Add("@RE_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
                SQLcmd.Parameters.Add("@RE_YA", SqlDbType.NVarChar, 5).Value = YA
                SQLcmd.Parameters.Add("@RE_DESC", SqlDbType.NVarChar, 255).Value = IIf(IsDBNull(rowData("RE_DESC")), "", rowData("RE_DESC"))
                SQLcmd.Parameters.Add("@RE_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(rowData("RE_AMOUNT")), 0, rowData("RE_AMOUNT"))
                SQLcmd.Parameters.Add("@RE_SOURCENO", SqlDbType.Int).Value = IIf(IsDBNull(rowData("RE_SOURCENO")), 0, rowData("RE_SOURCENO"))
                SQLcmd.Parameters.Add("@RE_TYPE", SqlDbType.Int).Value = IIf(IsDBNull(rowData("RE_TYPE")), 0, rowData("RE_TYPE"))
                SQLcmd.Parameters.Add("@RE_REFID", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowData("RE_REFID")), "", rowData("RE_REFID"))

                ListOfSQLCmd.Add(SQLcmd)
            Next

            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Private Function Save_OTHER_DEDUCTION(ByRef ListOfSQLCmd As List(Of SqlCommand)) As Boolean
        Try
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = ""
            For Each rowData As DataRow In dsAdjustIncome.Tables("OTHER_DEDUCTION").Rows

                StrSQL = "INSERT INTO OTHER_DEDUCTION(OD_REF_NO,OD_YA,OD_DESC,OD_AMOUNT,OD_SOURCENO) VALUES (@OD_REF_NO,@OD_YA,@OD_DESC,@OD_AMOUNT,@OD_SOURCENO)"

                SQLcmd = New SqlCommand With {
                  .CommandText = StrSQL
                }
                SQLcmd.Parameters.Add("@OD_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
                SQLcmd.Parameters.Add("@OD_YA", SqlDbType.NVarChar, 5).Value = YA
                SQLcmd.Parameters.Add("@OD_DESC", SqlDbType.NVarChar, 255).Value = IIf(IsDBNull(rowData("OD_DESC")), "", rowData("OD_DESC"))
                SQLcmd.Parameters.Add("@OD_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(rowData("OD_AMOUNT")), 0, rowData("OD_AMOUNT"))
                SQLcmd.Parameters.Add("@OD_SOURCENO", SqlDbType.Int).Value = IIf(IsDBNull(rowData("OD_SOURCENO")), 0, rowData("OD_SOURCENO"))

                ListOfSQLCmd.Add(SQLcmd)
            Next

            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Private Function Save_OTHER_EXPENDITURE(ByRef ListOfSQLCmd As List(Of SqlCommand)) As Boolean
        Try
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = ""
            For Each rowData As DataRow In dsAdjustIncome.Tables("OTHER_EXPENDITURE").Rows

                StrSQL = "INSERT INTO OTHER_EXPENDITURE(OE_REF_NO,OE_YA,OE_CLAIMCODE,OE_AMOUNT,OE_SOURCENO,OE_COMPANY) VALUES (@OE_REF_NO,@OE_YA,@OE_CLAIMCODE,@OE_AMOUNT,@OE_SOURCENO,@OE_COMPANY)"

                SQLcmd = New SqlCommand With {
                  .CommandText = StrSQL
                }
                SQLcmd.Parameters.Add("@OE_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
                SQLcmd.Parameters.Add("@OE_YA", SqlDbType.NVarChar, 5).Value = YA
                SQLcmd.Parameters.Add("@OE_CLAIMCODE", SqlDbType.NVarChar, 10).Value = IIf(IsDBNull(rowData("OE_CLAIMCODE")), "", rowData("OE_CLAIMCODE"))
                SQLcmd.Parameters.Add("@OE_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(rowData("OE_AMOUNT")), 0, rowData("OE_AMOUNT"))
                SQLcmd.Parameters.Add("@OE_SOURCENO", SqlDbType.Int).Value = IIf(IsDBNull(rowData("OE_SOURCENO")), 0, rowData("OE_SOURCENO"))
                SQLcmd.Parameters.Add("@OE_COMPANY", SqlDbType.NVarChar, 8).Value = IIf(IsDBNull(rowData("OE_COMPANY")), "", rowData("OE_COMPANY"))


                ListOfSQLCmd.Add(SQLcmd)
            Next

            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Private Function Save_Taxcomputation(ByRef ListOfSQLCmd As List(Of SqlCommand)) As Boolean
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "INSERT INTO TAX_COMPUTATION (TC_KEY,TC_REF_NO,TC_YA,TC_CO_NAME,TC_ROC,TC_BUSINESS,TC_AI_PNL_BAL,"
            StrSQL += "TC_AI_DIVIDEND,TC_AI_RENTAL,TC_AI_ROYALTY,TC_AI_INTEREST,TC_AI_SEC4A,TC_AI_TOT_NONBS_IN,TC_AI_TOT_BS_IN,TC_AI_ADJ_BS_IN_NA_LOS,"
            StrSQL += "TC_AI_ADJ_BS_IN_NT_IN,TC_AI_ADJ_BS_IN_TAX_IN,TC_AI_TOT_ADJ_BS_IN,TC_AI_ADJ_BS_EXP_INT,TC_AI_ADJ_BS_EXP_NA_EXP,"
            StrSQL += "TC_AI_ADJ_BS_EXP_RV_EXP,TC_AI_ADJ_BS_EXP_CLAIM,TC_AI_TOT_ADJ_BS_EXP,TC_AI_ADJ_IN_LOSS,TC_SI_ADJ_BS_IN,TC_SI_CA,"
            StrSQL += "TC_SI_STAT_BS_IN,TC_SI_INVEST_ALLOW,TC_SI_NET_STAT_IN,TC_SI_SS_RENTAL,TC_SI_SS_DIR_EXP,TC_SI_SS_DIR_EXP_QUIT,"
            StrSQL += "TC_SI_SS_DIR_EXP_MAIN,TC_SI_SS_ADJ_IN,TC_SI_SS_CA,TC_SI_SS_STAT_BS_IN,TC_SI_OTH_SOURCE,TC_SI_MAIN_BS,TC_SI_SEC_BS,"
            StrSQL += "TC_SI_OTH_BS,TC_SI_TOT,TC_SI_BS_LOSS_BF,TC_SI_AGGREGATE,TC_NB_DIV,TC_NB_DIV_ATT_INT,TC_NB_DIV_NET,TC_NB_INT,TC_NB_INT_ATT_INT,"
            StrSQL += "TC_NB_INT_NET,TC_NB_RENT,TC_NB_RENT_ATT_INT,TC_NB_RENT_ASSESS,TC_NB_RENT_QUIT,TC_NB_RENT_INSUR,TC_NB_RENT_OTH,TC_NB_RENT_MAIN,"
            StrSQL += "TC_NB_RENT_AGREE,TC_NB_RENT_NET,TC_NB_SUNDRY,TC_NB_OTH_AGGR_STAT,TC_TP_AGGR_IN,TC_TP_CURR_LOSS,TC_TP_AGGR_IN_LOSS,"
            StrSQL += "TC_TP_APRV_DONATION,TC_TP_CHARGEABLE,TC_TP_28_CHARGEABLE,TC_TP_SEC110,TC_TP_SEC132,TC_TP_SEC133,TC_TP_TOT_SETOFF,TC_TP_PAYABLE,"
            StrSQL += "TC_TP_INSTALL,TC_TP_PAYABLE_BAL,TC_CB_CA_BAL_BF,TC_CB_CA_CURR,TC_CB_CA_AA,TC_CB_CA_IA,TC_CB_CA_BA,TC_CB_CA_UTIL,TC_CB_CA_BAL_CF,"
            StrSQL += "TC_CB_LS_BAL_BF,TC_CB_LS_UTIL,TC_CB_LS_BAL_UTIL,TC_CB_LS_UNABSORBED,TC_CB_LS_BAL_CF,TC_CB_ITA_BAL_BF,TC_CB_ITA_CURR,"
            StrSQL += "TC_CB_ITA_BAL_BF_CURR,TC_CB_ITA_UTIL,TC_CB_ITA_BAL_CF,TC_AI_OTH_BS_IN,TC_TP_RATE1,TC_TP_RATE2,TC_TP_RATE3,TC_TP_RATE4,"
            StrSQL += "TC_TP_RATE5,TC_TP_RATE6,TC_TP_APP_CHARGEABLE1,TC_TP_APP_CHARGEABLE2,TC_TP_APP_CHARGEABLE3,TC_TP_APP_CHARGEABLE4,"
            StrSQL += "TC_TP_APP_CHARGEABLE5,TC_TP_APP_CHARGEABLE6,TC_TP_RATE1_CHARGEABLE,TC_TP_RATE2_CHARGEABLE,TC_TP_RATE3_CHARGEABLE,"
            StrSQL += "TC_TP_RATE4_CHARGEABLE,TC_TP_RATE5_CHARGEABLE,TC_TP_TOT_TAX_CHARGED,TC_TP_SEC6B_REBATE,TC_TP_SEC110_OTHERS,TC_TP_PROSPECTING,"
            StrSQL += "TC_TP_QUALIFY_AGRICULTURE,TC_TP_PREOP_BS,TC_TP_FOOD_PRODUCTION,TC_TP_EXP_ALLOWED,TC_TP_TOTAL_OTH_EXP,TC_TP_TOTAL_INCOME,"
            StrSQL += "TC_TP_PIONEER_CHARGE,TC_TP_OPERATIONALHQ_CHARGE,TC_TP_FOREIGN_CHARGE,TC_TP_BS_LOSS,TC_NB_ROYALTY,TC_NB_ADDITION,TC_CB_LS_ADJUST_LOSS,"
            StrSQL += "TC_CB_LS_UTIL_CURR,TC_SI_RA,TC_CB_RA_BAL_BF,TC_CB_RA_CURR,TC_CB_RA_BAL_BF_CURR,TC_CB_RA_UTIL,TC_CB_RA_BAL_CF,TC_SI_BC,"
            StrSQL += "TC_SI_ADJ_BS_IN_BC,TC_CB_CA_CURR_BA,TC_TP_RATE4A,TC_TP_APP_CHARGEABLE4A,TC_TP_RATE4A_CHARGEABLE,TC_CB_CA_NA,TC_TP_ZAKAT,"
            StrSQL += "TC_OTHERDEDUCTION,TC_CB_CA_DISALLOW,TC_CB_CA_ABAL_CF,TC_CB_CHECK,TC_TP_CLAIM,TC_CB_LS_SAMOUNT,TC_CB_LS_BALS_CF,TC_CB_LS_D_BL,"
            StrSQL += "TC_CB_LS_SRDAMT2,TC_CB_LS_BLNBF,TC_CB_LS_AMTTUT,TC_CB_LS_BLNCF,TC_COMPANY,TC_PIONEERDESC,TC_PIO,TC_PIONEER,TC_RA_RATE1,"
            StrSQL += "TC_RA_QUALIFYINGCAPITALEXP,TC_RA_QUALIFYINGCAPITALEXP_AMOUNT,TC_RA_BALANCINGALLOWANCE,TC_RA_TOTAL1,TC_RA_RESTRICTRATE,"
            StrSQL += "TC_RA_RESTRICTAMOUNT,TC_ITA_RATE1,TC_ITA_QUALIFYINGCAPITALEXP,TC_ITA_QUALIFYINGCAPITALEXP_AMOUNT,TC_ITA_BALANCINGALLOWANCE,"
            StrSQL += "TC_ITA_TOTAL1,TC_ITA_RESTRICTRATE,TC_ITA_RESTRICTAMOUNT,TC_DISALLOW_NOTE,TC_DISALLOWBUSINESS_NOTE,TC_SURPLUSRECOVERED,"
            StrSQL += "TC_MININGALLOWNANCE,TC_MININGEXPENSES,TC_STAT_DIVIDEND,TC_TP_SEC110B,TC_NB_RENT_OTH2,TC_NB_CARRYBCKLOSS,TC_NB_AMTNOTCARRYBCK,"
            StrSQL += "TC_NB_CHKCB, TC_TP_INCOME_TP2, TC_TP_ESTIMATED_TP, TC_TP_INCOME_TP3, TC_TP_ALL_DIFF, TC_TP_EX_DIFF, TC_TP_PEN_DIFF, TC_WITHRAITA, TC_RA_WITHDRAWAL, "
            StrSQL += "TC_RA_ADJUSTMENT, TC_ITA_WITHDRAWAL, TC_ITA_ADJUSTMENT, TC_NB_DIV_OTH, TC_NB_INT_OTH, TC_SUNDRY_EXP, TC_CHK_EXEMP, TC_SI_TOT_PARTNERSHIP, "
            StrSQL += "TC_CB_CA_ACA, TC_NB_RENTIBA, TC_NB_RENTIBA_ATT_IN, TC_NB_RENTIBA_ASSESS, TC_NB_RENTIBA_QUIT, TC_NB_RENTIBA_INSUR, TC_NB_RENTIBA_OTH, "
            StrSQL += "TC_NB_RENTIBA_MAIN, TC_NB_RENTIBA_AGREE, TC_NB_RENTIBA_IBA, TC_NB_DIV_DIS_ATT_INT, TC_NB_DIV_TOT_ATT_INT, TC_EA_UTL, TC_EA_TYPE, TC_EA_CURR_COMPANY, "
            StrSQL += "TC_EA_CURR_AGRICULTURE, TC_EA_CURR_SIGNIFICANT, TC_EA_CURR_MARKET, TC_EA_CURR_MSB, TC_EA_TOTAL, TC_EA_RESTRICTRATE, TC_EA_BF, TC_EA_CF, TC_TP_ESTIMATED_SME, "
            StrSQL += "TC_NB_DCA_INT, TC_NB_DEEMED_INT, TC_EXEMPTIONCAL, TC_EXEMPTIONLESS, TC_TP_INSTALL_107C, TC_TP_INSTALL_107A, TC_TP_RATE7, TC_TP_APP_CHARGEABLE7, "
            StrSQL += "TC_TP_RATE6_CHARGEABLE,TC_TP_RATE7_CHARGEABLE,TC_EA_TYPE1,TC_EA_TYPE2,TC_EA_TYPE3)"
            StrSQL += " VALUES (@TC_KEY,@TC_REF_NO,@TC_YA,@TC_CO_NAME,@TC_ROC,@TC_BUSINESS,@TC_AI_PNL_BAL,@"
            StrSQL += "TC_AI_DIVIDEND,@TC_AI_RENTAL,@TC_AI_ROYALTY,@TC_AI_INTEREST,@TC_AI_SEC4A,@TC_AI_TOT_NONBS_IN,@TC_AI_TOT_BS_IN,@TC_AI_ADJ_BS_IN_NA_LOS,@"
            StrSQL += "TC_AI_ADJ_BS_IN_NT_IN,@TC_AI_ADJ_BS_IN_TAX_IN,@TC_AI_TOT_ADJ_BS_IN,@TC_AI_ADJ_BS_EXP_INT,@TC_AI_ADJ_BS_EXP_NA_EXP,@"
            StrSQL += "TC_AI_ADJ_BS_EXP_RV_EXP,@TC_AI_ADJ_BS_EXP_CLAIM,@TC_AI_TOT_ADJ_BS_EXP,@TC_AI_ADJ_IN_LOSS,@TC_SI_ADJ_BS_IN,@TC_SI_CA,@"
            StrSQL += "TC_SI_STAT_BS_IN,@TC_SI_INVEST_ALLOW,@TC_SI_NET_STAT_IN,@TC_SI_SS_RENTAL,@TC_SI_SS_DIR_EXP,@TC_SI_SS_DIR_EXP_QUIT,@"
            StrSQL += "TC_SI_SS_DIR_EXP_MAIN,@TC_SI_SS_ADJ_IN,@TC_SI_SS_CA,@TC_SI_SS_STAT_BS_IN,@TC_SI_OTH_SOURCE,@TC_SI_MAIN_BS,@TC_SI_SEC_BS,@"
            StrSQL += "TC_SI_OTH_BS,@TC_SI_TOT,@TC_SI_BS_LOSS_BF,@TC_SI_AGGREGATE,@TC_NB_DIV,@TC_NB_DIV_ATT_INT,@TC_NB_DIV_NET,@TC_NB_INT,@TC_NB_INT_ATT_INT,@"
            StrSQL += "TC_NB_INT_NET,@TC_NB_RENT,@TC_NB_RENT_ATT_INT,@TC_NB_RENT_ASSESS,@TC_NB_RENT_QUIT,@TC_NB_RENT_INSUR,@TC_NB_RENT_OTH,@TC_NB_RENT_MAIN,@"
            StrSQL += "TC_NB_RENT_AGREE,@TC_NB_RENT_NET,@TC_NB_SUNDRY,@TC_NB_OTH_AGGR_STAT,@TC_TP_AGGR_IN,@TC_TP_CURR_LOSS,@TC_TP_AGGR_IN_LOSS,@"
            StrSQL += "TC_TP_APRV_DONATION,@TC_TP_CHARGEABLE,@TC_TP_28_CHARGEABLE,@TC_TP_SEC110,@TC_TP_SEC132,@TC_TP_SEC133,@TC_TP_TOT_SETOFF,@TC_TP_PAYABLE,@"
            StrSQL += "TC_TP_INSTALL,@TC_TP_PAYABLE_BAL,@TC_CB_CA_BAL_BF,@TC_CB_CA_CURR,@TC_CB_CA_AA,@TC_CB_CA_IA,@TC_CB_CA_BA,@TC_CB_CA_UTIL,@TC_CB_CA_BAL_CF,@"
            StrSQL += "TC_CB_LS_BAL_BF,@TC_CB_LS_UTIL,@TC_CB_LS_BAL_UTIL,@TC_CB_LS_UNABSORBED,@TC_CB_LS_BAL_CF,@TC_CB_ITA_BAL_BF,@TC_CB_ITA_CURR,@"
            StrSQL += "TC_CB_ITA_BAL_BF_CURR,@TC_CB_ITA_UTIL,@TC_CB_ITA_BAL_CF,@TC_AI_OTH_BS_IN,@TC_TP_RATE1,@TC_TP_RATE2,@TC_TP_RATE3,@TC_TP_RATE4,@"
            StrSQL += "TC_TP_RATE5,@TC_TP_RATE6,@TC_TP_APP_CHARGEABLE1,@TC_TP_APP_CHARGEABLE2,@TC_TP_APP_CHARGEABLE3,@TC_TP_APP_CHARGEABLE4,@"
            StrSQL += "TC_TP_APP_CHARGEABLE5,@TC_TP_APP_CHARGEABLE6,@TC_TP_RATE1_CHARGEABLE,@TC_TP_RATE2_CHARGEABLE,@TC_TP_RATE3_CHARGEABLE,@"
            StrSQL += "TC_TP_RATE4_CHARGEABLE,@TC_TP_RATE5_CHARGEABLE,@TC_TP_TOT_TAX_CHARGED,@TC_TP_SEC6B_REBATE,@TC_TP_SEC110_OTHERS,@TC_TP_PROSPECTING,@"
            StrSQL += "TC_TP_QUALIFY_AGRICULTURE,@TC_TP_PREOP_BS,@TC_TP_FOOD_PRODUCTION,@TC_TP_EXP_ALLOWED,@TC_TP_TOTAL_OTH_EXP,@TC_TP_TOTAL_INCOME,@"
            StrSQL += "TC_TP_PIONEER_CHARGE,@TC_TP_OPERATIONALHQ_CHARGE,@TC_TP_FOREIGN_CHARGE,@TC_TP_BS_LOSS,@TC_NB_ROYALTY,@TC_NB_ADDITION,@TC_CB_LS_ADJUST_LOSS,@"
            StrSQL += "TC_CB_LS_UTIL_CURR,@TC_SI_RA,@TC_CB_RA_BAL_BF,@TC_CB_RA_CURR,@TC_CB_RA_BAL_BF_CURR,@TC_CB_RA_UTIL,@TC_CB_RA_BAL_CF,@TC_SI_BC,@"
            StrSQL += "TC_SI_ADJ_BS_IN_BC,@TC_CB_CA_CURR_BA,@TC_TP_RATE4A,@TC_TP_APP_CHARGEABLE4A,@TC_TP_RATE4A_CHARGEABLE,@TC_CB_CA_NA,@TC_TP_ZAKAT,@"
            StrSQL += "TC_OTHERDEDUCTION,@TC_CB_CA_DISALLOW,@TC_CB_CA_ABAL_CF,@TC_CB_CHECK,@TC_TP_CLAIM,@TC_CB_LS_SAMOUNT,@TC_CB_LS_BALS_CF,@TC_CB_LS_D_BL,@"
            StrSQL += "TC_CB_LS_SRDAMT2,@TC_CB_LS_BLNBF,@TC_CB_LS_AMTTUT,@TC_CB_LS_BLNCF,@TC_COMPANY,@TC_PIONEERDESC,@TC_PIO,@TC_PIONEER,@TC_RA_RATE1,@"
            StrSQL += "TC_RA_QUALIFYINGCAPITALEXP,@TC_RA_QUALIFYINGCAPITALEXP_AMOUNT,@TC_RA_BALANCINGALLOWANCE,@TC_RA_TOTAL1,@TC_RA_RESTRICTRATE,@"
            StrSQL += "TC_RA_RESTRICTAMOUNT,@TC_ITA_RATE1,@TC_ITA_QUALIFYINGCAPITALEXP,@TC_ITA_QUALIFYINGCAPITALEXP_AMOUNT,@TC_ITA_BALANCINGALLOWANCE,@"
            StrSQL += "TC_ITA_TOTAL1,@TC_ITA_RESTRICTRATE,@TC_ITA_RESTRICTAMOUNT,@TC_DISALLOW_NOTE,@TC_DISALLOWBUSINESS_NOTE,@TC_SURPLUSRECOVERED,@"
            StrSQL += "TC_MININGALLOWNANCE,@TC_MININGEXPENSES,@TC_STAT_DIVIDEND,@TC_TP_SEC110B,@TC_NB_RENT_OTH2,@TC_NB_CARRYBCKLOSS,@TC_NB_AMTNOTCARRYBCK,@"
            StrSQL += "TC_NB_CHKCB,@TC_TP_INCOME_TP2,@TC_TP_ESTIMATED_TP,@TC_TP_INCOME_TP3,@TC_TP_ALL_DIFF,@TC_TP_EX_DIFF,@TC_TP_PEN_DIFF,@TC_WITHRAITA,@TC_RA_WITHDRAWAL,@"
            StrSQL += "TC_RA_ADJUSTMENT,@TC_ITA_WITHDRAWAL,@TC_ITA_ADJUSTMENT,@TC_NB_DIV_OTH,@TC_NB_INT_OTH,@TC_SUNDRY_EXP,@TC_CHK_EXEMP,@TC_SI_TOT_PARTNERSHIP,@"
            StrSQL += "TC_CB_CA_ACA,@TC_NB_RENTIBA,@TC_NB_RENTIBA_ATT_IN,@TC_NB_RENTIBA_ASSESS,@TC_NB_RENTIBA_QUIT,@TC_NB_RENTIBA_INSUR,@TC_NB_RENTIBA_OTH,@"
            StrSQL += "TC_NB_RENTIBA_MAIN,@TC_NB_RENTIBA_AGREE,@TC_NB_RENTIBA_IBA,@TC_NB_DIV_DIS_ATT_INT,@TC_NB_DIV_TOT_ATT_INT,@TC_EA_UTL,@TC_EA_TYPE,@TC_EA_CURR_COMPANY,@"
            StrSQL += "TC_EA_CURR_AGRICULTURE,@TC_EA_CURR_SIGNIFICANT,@TC_EA_CURR_MARKET,@TC_EA_CURR_MSB,@TC_EA_TOTAL,@TC_EA_RESTRICTRATE,@TC_EA_BF,@TC_EA_CF,@TC_TP_ESTIMATED_SME,@"
            StrSQL += "TC_NB_DCA_INT,@TC_NB_DEEMED_INT,@TC_EXEMPTIONCAL,@TC_EXEMPTIONLESS,@TC_TP_INSTALL_107C,@TC_TP_INSTALL_107A,@TC_TP_RATE7,@TC_TP_APP_CHARGEABLE7,@"
            StrSQL += "TC_TP_RATE6_CHARGEABLE,@TC_TP_RATE7_CHARGEABLE,@TC_EA_TYPE1,@TC_EA_TYPE2,@TC_EA_TYPE3)"

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@TC_KEY", SqlDbType.Int).Value = TC_KEY
            SQLcmd.Parameters.Add("@TC_REF_NO", SqlDbType.NVarChar, 20).Value = TC_REF_NO
            SQLcmd.Parameters.Add("@TC_YA", SqlDbType.NVarChar, 5).Value = TC_YA
            SQLcmd.Parameters.Add("@TC_CO_NAME", SqlDbType.NVarChar, 255).Value = TC_CO_NAME
            SQLcmd.Parameters.Add("@TC_ROC", SqlDbType.NVarChar, 20).Value = TC_ROC
            SQLcmd.Parameters.Add("@TC_BUSINESS", SqlDbType.Int).Value = TC_BUSINESS
            SQLcmd.Parameters.Add("@TC_AI_PNL_BAL", SqlDbType.Decimal).Value = TC_AI_PNL_BAL
            SQLcmd.Parameters.Add("@TC_AI_DIVIDEND", SqlDbType.Decimal).Value = TC_AI_DIVIDEND
            SQLcmd.Parameters.Add("@TC_AI_RENTAL", SqlDbType.Decimal).Value = TC_AI_RENTAL
            SQLcmd.Parameters.Add("@TC_AI_ROYALTY", SqlDbType.Decimal).Value = TC_AI_ROYALTY
            SQLcmd.Parameters.Add("@TC_AI_INTEREST", SqlDbType.Decimal).Value = TC_AI_INTEREST
            SQLcmd.Parameters.Add("@TC_AI_SEC4A", SqlDbType.Decimal).Value = TC_AI_SEC4A
            SQLcmd.Parameters.Add("@TC_AI_TOT_NONBS_IN", SqlDbType.Decimal).Value = TC_AI_TOT_NONBS_IN
            SQLcmd.Parameters.Add("@TC_AI_TOT_BS_IN", SqlDbType.Decimal).Value = TC_AI_TOT_BS_IN
            SQLcmd.Parameters.Add("@TC_AI_ADJ_BS_IN_NA_LOS", SqlDbType.Decimal).Value = TC_AI_ADJ_BS_IN_NA_LOS
            SQLcmd.Parameters.Add("@TC_AI_ADJ_BS_IN_NT_IN", SqlDbType.Decimal).Value = TC_AI_ADJ_BS_IN_NT_IN
            SQLcmd.Parameters.Add("@TC_AI_ADJ_BS_IN_TAX_IN", SqlDbType.Decimal).Value = TC_AI_ADJ_BS_IN_TAX_IN
            SQLcmd.Parameters.Add("@TC_AI_TOT_ADJ_BS_IN", SqlDbType.Decimal).Value = TC_AI_TOT_ADJ_BS_IN
            SQLcmd.Parameters.Add("@TC_AI_ADJ_BS_EXP_INT", SqlDbType.Decimal).Value = TC_AI_ADJ_BS_EXP_INT
            SQLcmd.Parameters.Add("@TC_AI_ADJ_BS_EXP_NA_EXP", SqlDbType.Decimal).Value = TC_AI_ADJ_BS_EXP_NA_EXP
            SQLcmd.Parameters.Add("@TC_AI_ADJ_BS_EXP_RV_EXP", SqlDbType.Decimal).Value = TC_AI_ADJ_BS_EXP_RV_EXP
            SQLcmd.Parameters.Add("@TC_AI_ADJ_BS_EXP_CLAIM", SqlDbType.Decimal).Value = TC_AI_ADJ_BS_EXP_CLAIM
            SQLcmd.Parameters.Add("@TC_AI_TOT_ADJ_BS_EXP", SqlDbType.Decimal).Value = TC_AI_TOT_ADJ_BS_EXP
            SQLcmd.Parameters.Add("@TC_AI_ADJ_IN_LOSS", SqlDbType.Decimal).Value = TC_AI_ADJ_IN_LOSS
            SQLcmd.Parameters.Add("@TC_SI_ADJ_BS_IN", SqlDbType.Decimal).Value = TC_SI_ADJ_BS_IN
            SQLcmd.Parameters.Add("@TC_SI_CA", SqlDbType.Decimal).Value = TC_SI_CA
            SQLcmd.Parameters.Add("@TC_SI_STAT_BS_IN", SqlDbType.Decimal).Value = TC_SI_STAT_BS_IN
            SQLcmd.Parameters.Add("@TC_SI_INVEST_ALLOW", SqlDbType.Decimal).Value = TC_SI_INVEST_ALLOW
            SQLcmd.Parameters.Add("@TC_SI_NET_STAT_IN", SqlDbType.Decimal).Value = TC_SI_NET_STAT_IN
            SQLcmd.Parameters.Add("@TC_SI_SS_RENTAL", SqlDbType.Decimal).Value = TC_SI_SS_RENTAL
            SQLcmd.Parameters.Add("@TC_SI_SS_DIR_EXP", SqlDbType.Decimal).Value = TC_SI_SS_DIR_EXP
            SQLcmd.Parameters.Add("@TC_SI_SS_DIR_EXP_QUIT", SqlDbType.Decimal).Value = TC_SI_SS_DIR_EXP_QUIT
            SQLcmd.Parameters.Add("@TC_SI_SS_DIR_EXP_MAIN", SqlDbType.Decimal).Value = TC_SI_SS_DIR_EXP_MAIN
            SQLcmd.Parameters.Add("@TC_SI_SS_ADJ_IN", SqlDbType.Decimal).Value = TC_SI_SS_ADJ_IN
            SQLcmd.Parameters.Add("@TC_SI_SS_CA", SqlDbType.Decimal).Value = TC_SI_SS_CA
            SQLcmd.Parameters.Add("@TC_SI_SS_STAT_BS_IN", SqlDbType.Decimal).Value = TC_SI_SS_STAT_BS_IN
            SQLcmd.Parameters.Add("@TC_SI_OTH_SOURCE", SqlDbType.Decimal).Value = TC_SI_OTH_SOURCE
            SQLcmd.Parameters.Add("@TC_SI_MAIN_BS", SqlDbType.Decimal).Value = TC_SI_MAIN_BS
            SQLcmd.Parameters.Add("@TC_SI_SEC_BS", SqlDbType.Decimal).Value = TC_SI_SEC_BS
            SQLcmd.Parameters.Add("@TC_SI_OTH_BS", SqlDbType.Decimal).Value = TC_SI_OTH_BS
            SQLcmd.Parameters.Add("@TC_SI_TOT", SqlDbType.Decimal).Value = TC_SI_TOT
            SQLcmd.Parameters.Add("@TC_SI_BS_LOSS_BF", SqlDbType.Decimal).Value = TC_SI_BS_LOSS_BF
            SQLcmd.Parameters.Add("@TC_SI_AGGREGATE", SqlDbType.Decimal).Value = TC_SI_AGGREGATE
            SQLcmd.Parameters.Add("@TC_NB_DIV", SqlDbType.Decimal).Value = TC_NB_DIV
            SQLcmd.Parameters.Add("@TC_NB_DIV_ATT_INT", SqlDbType.Decimal).Value = TC_NB_DIV_ATT_INT
            SQLcmd.Parameters.Add("@TC_NB_DIV_NET", SqlDbType.Decimal).Value = TC_NB_DIV_NET
            SQLcmd.Parameters.Add("@TC_NB_INT", SqlDbType.Decimal).Value = TC_NB_INT
            SQLcmd.Parameters.Add("@TC_NB_INT_ATT_INT", SqlDbType.Decimal).Value = TC_NB_INT_ATT_INT
            SQLcmd.Parameters.Add("@TC_NB_INT_NET", SqlDbType.Decimal).Value = TC_NB_INT_NET
            SQLcmd.Parameters.Add("@TC_NB_RENT", SqlDbType.Decimal).Value = TC_NB_RENT
            SQLcmd.Parameters.Add("@TC_NB_RENT_ATT_INT", SqlDbType.Decimal).Value = TC_NB_RENT_ATT_INT
            SQLcmd.Parameters.Add("@TC_NB_RENT_ASSESS", SqlDbType.Decimal).Value = TC_NB_RENT_ASSESS
            SQLcmd.Parameters.Add("@TC_NB_RENT_QUIT", SqlDbType.Decimal).Value = TC_NB_RENT_QUIT
            SQLcmd.Parameters.Add("@TC_NB_RENT_INSUR", SqlDbType.Decimal).Value = TC_NB_RENT_INSUR
            SQLcmd.Parameters.Add("@TC_NB_RENT_OTH", SqlDbType.Decimal).Value = TC_NB_RENT_OTH
            SQLcmd.Parameters.Add("@TC_NB_RENT_MAIN", SqlDbType.Decimal).Value = TC_NB_RENT_MAIN
            SQLcmd.Parameters.Add("@TC_NB_RENT_AGREE", SqlDbType.Decimal).Value = TC_NB_RENT_AGREE
            SQLcmd.Parameters.Add("@TC_NB_RENT_NET", SqlDbType.Decimal).Value = TC_NB_RENT_NET
            SQLcmd.Parameters.Add("@TC_NB_SUNDRY", SqlDbType.Decimal).Value = TC_NB_SUNDRY
            SQLcmd.Parameters.Add("@TC_NB_OTH_AGGR_STAT", SqlDbType.Decimal).Value = TC_NB_OTH_AGGR_STAT
            SQLcmd.Parameters.Add("@TC_TP_AGGR_IN", SqlDbType.Decimal).Value = TC_TP_AGGR_IN
            SQLcmd.Parameters.Add("@TC_TP_CURR_LOSS", SqlDbType.Decimal).Value = TC_TP_CURR_LOSS
            SQLcmd.Parameters.Add("@TC_TP_AGGR_IN_LOSS", SqlDbType.Decimal).Value = TC_TP_AGGR_IN_LOSS
            SQLcmd.Parameters.Add("@TC_TP_APRV_DONATION", SqlDbType.Decimal).Value = TC_TP_APRV_DONATION
            SQLcmd.Parameters.Add("@TC_TP_CHARGEABLE", SqlDbType.Decimal).Value = TC_TP_CHARGEABLE
            SQLcmd.Parameters.Add("@TC_TP_28_CHARGEABLE", SqlDbType.Decimal).Value = TC_TP_28_CHARGEABLE
            SQLcmd.Parameters.Add("@TC_TP_SEC110", SqlDbType.Decimal).Value = TC_TP_SEC110
            SQLcmd.Parameters.Add("@TC_TP_SEC132", SqlDbType.Decimal).Value = TC_TP_SEC132
            SQLcmd.Parameters.Add("@TC_TP_SEC133", SqlDbType.Decimal).Value = TC_TP_SEC133
            SQLcmd.Parameters.Add("@TC_TP_TOT_SETOFF", SqlDbType.Decimal).Value = TC_TP_TOT_SETOFF
            SQLcmd.Parameters.Add("@TC_TP_PAYABLE", SqlDbType.Decimal).Value = TC_TP_PAYABLE
            SQLcmd.Parameters.Add("@TC_TP_INSTALL", SqlDbType.Decimal).Value = TC_TP_INSTALL
            SQLcmd.Parameters.Add("@TC_TP_PAYABLE_BAL", SqlDbType.Decimal).Value = TC_TP_PAYABLE_BAL
            SQLcmd.Parameters.Add("@TC_CB_CA_BAL_BF", SqlDbType.Decimal).Value = TC_CB_CA_BAL_BF
            SQLcmd.Parameters.Add("@TC_CB_CA_CURR", SqlDbType.Decimal).Value = TC_CB_CA_CURR
            SQLcmd.Parameters.Add("@TC_CB_CA_AA", SqlDbType.Decimal).Value = TC_CB_CA_AA
            SQLcmd.Parameters.Add("@TC_CB_CA_IA", SqlDbType.Decimal).Value = TC_CB_CA_IA
            SQLcmd.Parameters.Add("@TC_CB_CA_BA", SqlDbType.Decimal).Value = TC_CB_CA_BA
            SQLcmd.Parameters.Add("@TC_CB_CA_UTIL", SqlDbType.Decimal).Value = TC_CB_CA_UTIL
            SQLcmd.Parameters.Add("@TC_CB_CA_BAL_CF", SqlDbType.Decimal).Value = TC_CB_CA_BAL_CF
            SQLcmd.Parameters.Add("@TC_CB_LS_BAL_BF", SqlDbType.Decimal).Value = TC_CB_LS_BAL_BF
            SQLcmd.Parameters.Add("@TC_CB_LS_UTIL", SqlDbType.Decimal).Value = TC_CB_LS_UTIL
            SQLcmd.Parameters.Add("@TC_CB_LS_BAL_UTIL", SqlDbType.Decimal).Value = TC_CB_LS_BAL_UTIL
            SQLcmd.Parameters.Add("@TC_CB_LS_UNABSORBED", SqlDbType.Decimal).Value = TC_CB_LS_UNABSORBED
            SQLcmd.Parameters.Add("@TC_CB_LS_BAL_CF", SqlDbType.Decimal).Value = TC_CB_LS_BAL_CF
            SQLcmd.Parameters.Add("@TC_CB_ITA_BAL_BF", SqlDbType.Decimal).Value = TC_CB_ITA_BAL_BF
            SQLcmd.Parameters.Add("@TC_CB_ITA_CURR", SqlDbType.Decimal).Value = TC_CB_ITA_CURR
            SQLcmd.Parameters.Add("@TC_CB_ITA_BAL_BF_CURR", SqlDbType.Decimal).Value = TC_CB_ITA_BAL_BF_CURR
            SQLcmd.Parameters.Add("@TC_CB_ITA_UTIL", SqlDbType.Decimal).Value = TC_CB_ITA_UTIL
            SQLcmd.Parameters.Add("@TC_CB_ITA_BAL_CF", SqlDbType.Decimal).Value = TC_CB_ITA_BAL_CF
            SQLcmd.Parameters.Add("@TC_AI_OTH_BS_IN", SqlDbType.Decimal).Value = TC_AI_OTH_BS_IN
            SQLcmd.Parameters.Add("@TC_TP_RATE1", SqlDbType.Int).Value = TC_TP_RATE1
            SQLcmd.Parameters.Add("@TC_TP_RATE2", SqlDbType.Int).Value = TC_TP_RATE2
            SQLcmd.Parameters.Add("@TC_TP_RATE3", SqlDbType.Int).Value = TC_TP_RATE3
            SQLcmd.Parameters.Add("@TC_TP_RATE4", SqlDbType.Int).Value = TC_TP_RATE4
            SQLcmd.Parameters.Add("@TC_TP_RATE5", SqlDbType.Int).Value = TC_TP_RATE5
            SQLcmd.Parameters.Add("@TC_TP_RATE6", SqlDbType.Int).Value = TC_TP_RATE6
            SQLcmd.Parameters.Add("@TC_TP_APP_CHARGEABLE1", SqlDbType.Decimal).Value = TC_TP_APP_CHARGEABLE1
            SQLcmd.Parameters.Add("@TC_TP_APP_CHARGEABLE2", SqlDbType.Decimal).Value = TC_TP_APP_CHARGEABLE2
            SQLcmd.Parameters.Add("@TC_TP_APP_CHARGEABLE3", SqlDbType.Decimal).Value = TC_TP_APP_CHARGEABLE3
            SQLcmd.Parameters.Add("@TC_TP_APP_CHARGEABLE4", SqlDbType.Decimal).Value = TC_TP_APP_CHARGEABLE4
            SQLcmd.Parameters.Add("@TC_TP_APP_CHARGEABLE5", SqlDbType.Decimal).Value = TC_TP_APP_CHARGEABLE5
            SQLcmd.Parameters.Add("@TC_TP_APP_CHARGEABLE6", SqlDbType.Decimal).Value = TC_TP_APP_CHARGEABLE6
            SQLcmd.Parameters.Add("@TC_TP_RATE1_CHARGEABLE", SqlDbType.Decimal).Value = TC_TP_RATE1_CHARGEABLE
            SQLcmd.Parameters.Add("@TC_TP_RATE2_CHARGEABLE", SqlDbType.Decimal).Value = TC_TP_RATE2_CHARGEABLE
            SQLcmd.Parameters.Add("@TC_TP_RATE3_CHARGEABLE", SqlDbType.Decimal).Value = TC_TP_RATE3_CHARGEABLE
            SQLcmd.Parameters.Add("@TC_TP_RATE4_CHARGEABLE", SqlDbType.Decimal).Value = TC_TP_RATE4_CHARGEABLE
            SQLcmd.Parameters.Add("@TC_TP_RATE5_CHARGEABLE", SqlDbType.Decimal).Value = TC_TP_RATE5_CHARGEABLE
            SQLcmd.Parameters.Add("@TC_TP_TOT_TAX_CHARGED", SqlDbType.Decimal).Value = TC_TP_TOT_TAX_CHARGED
            SQLcmd.Parameters.Add("@TC_TP_SEC6B_REBATE", SqlDbType.Decimal).Value = TC_TP_SEC6B_REBATE
            SQLcmd.Parameters.Add("@TC_TP_SEC110_OTHERS", SqlDbType.Decimal).Value = TC_TP_SEC110_OTHERS
            SQLcmd.Parameters.Add("@TC_TP_PROSPECTING", SqlDbType.Decimal).Value = TC_TP_PROSPECTING
            SQLcmd.Parameters.Add("@TC_TP_QUALIFY_AGRICULTURE", SqlDbType.Decimal).Value = TC_TP_QUALIFY_AGRICULTURE
            SQLcmd.Parameters.Add("@TC_TP_PREOP_BS", SqlDbType.Decimal).Value = TC_TP_PREOP_BS
            SQLcmd.Parameters.Add("@TC_TP_FOOD_PRODUCTION", SqlDbType.Decimal).Value = TC_TP_FOOD_PRODUCTION
            SQLcmd.Parameters.Add("@TC_TP_EXP_ALLOWED", SqlDbType.Decimal).Value = TC_TP_EXP_ALLOWED
            SQLcmd.Parameters.Add("@TC_TP_TOTAL_OTH_EXP", SqlDbType.Decimal).Value = TC_TP_TOTAL_OTH_EXP
            SQLcmd.Parameters.Add("@TC_TP_TOTAL_INCOME", SqlDbType.Decimal).Value = TC_TP_TOTAL_INCOME
            SQLcmd.Parameters.Add("@TC_TP_PIONEER_CHARGE", SqlDbType.Decimal).Value = TC_TP_PIONEER_CHARGE
            SQLcmd.Parameters.Add("@TC_TP_OPERATIONALHQ_CHARGE", SqlDbType.Decimal).Value = TC_TP_OPERATIONALHQ_CHARGE
            SQLcmd.Parameters.Add("@TC_TP_FOREIGN_CHARGE", SqlDbType.Decimal).Value = TC_TP_FOREIGN_CHARGE
            SQLcmd.Parameters.Add("@TC_TP_BS_LOSS", SqlDbType.Decimal).Value = TC_TP_BS_LOSS
            SQLcmd.Parameters.Add("@TC_NB_ROYALTY", SqlDbType.Decimal).Value = TC_NB_ROYALTY
            SQLcmd.Parameters.Add("@TC_NB_ADDITION", SqlDbType.Decimal).Value = TC_NB_ADDITION
            SQLcmd.Parameters.Add("@TC_CB_LS_ADJUST_LOSS", SqlDbType.Decimal).Value = TC_CB_LS_ADJUST_LOSS
            SQLcmd.Parameters.Add("@TC_CB_LS_UTIL_CURR", SqlDbType.Decimal).Value = TC_CB_LS_UTIL_CURR
            SQLcmd.Parameters.Add("@TC_SI_RA", SqlDbType.Decimal).Value = TC_SI_RA
            SQLcmd.Parameters.Add("@TC_CB_RA_BAL_BF", SqlDbType.Decimal).Value = TC_CB_RA_BAL_BF
            SQLcmd.Parameters.Add("@TC_CB_RA_CURR", SqlDbType.Decimal).Value = TC_CB_RA_CURR
            SQLcmd.Parameters.Add("@TC_CB_RA_BAL_BF_CURR", SqlDbType.Decimal).Value = TC_CB_RA_BAL_BF_CURR
            SQLcmd.Parameters.Add("@TC_CB_RA_UTIL", SqlDbType.Decimal).Value = TC_CB_RA_UTIL
            SQLcmd.Parameters.Add("@TC_CB_RA_BAL_CF", SqlDbType.Decimal).Value = TC_CB_RA_BAL_CF
            SQLcmd.Parameters.Add("@TC_SI_BC", SqlDbType.Decimal).Value = TC_SI_BC
            SQLcmd.Parameters.Add("@TC_SI_ADJ_BS_IN_BC", SqlDbType.Decimal).Value = TC_SI_ADJ_BS_IN_BC
            SQLcmd.Parameters.Add("@TC_CB_CA_CURR_BA", SqlDbType.Decimal).Value = TC_CB_CA_CURR_BA
            SQLcmd.Parameters.Add("@TC_TP_RATE4A", SqlDbType.Int).Value = TC_TP_RATE4A
            SQLcmd.Parameters.Add("@TC_TP_APP_CHARGEABLE4A", SqlDbType.Decimal).Value = TC_TP_APP_CHARGEABLE4A
            SQLcmd.Parameters.Add("@TC_TP_RATE4A_CHARGEABLE", SqlDbType.Decimal).Value = TC_TP_RATE4A_CHARGEABLE
            SQLcmd.Parameters.Add("@TC_CB_CA_NA", SqlDbType.Decimal).Value = TC_CB_CA_NA
            SQLcmd.Parameters.Add("@TC_TP_ZAKAT", SqlDbType.Decimal).Value = TC_TP_ZAKAT
            SQLcmd.Parameters.Add("@TC_OTHERDEDUCTION", SqlDbType.Decimal).Value = TC_OTHERDEDUCTION
            SQLcmd.Parameters.Add("@TC_CB_CA_DISALLOW", SqlDbType.Decimal).Value = TC_CB_CA_DISALLOW
            SQLcmd.Parameters.Add("@TC_CB_CA_ABAL_CF", SqlDbType.Float).Value = TC_CB_CA_ABAL_CF
            SQLcmd.Parameters.Add("@TC_CB_CHECK", SqlDbType.Decimal).Value = TC_CB_CHECK
            SQLcmd.Parameters.Add("@TC_TP_CLAIM", SqlDbType.Decimal).Value = TC_TP_CLAIM
            SQLcmd.Parameters.Add("@TC_CB_LS_SAMOUNT", SqlDbType.Decimal).Value = TC_CB_LS_SAMOUNT
            SQLcmd.Parameters.Add("@TC_CB_LS_BALS_CF", SqlDbType.Decimal).Value = TC_CB_LS_BALS_CF
            SQLcmd.Parameters.Add("@TC_CB_LS_D_BL", SqlDbType.Decimal).Value = TC_CB_LS_D_BL
            SQLcmd.Parameters.Add("@TC_CB_LS_SRDAMT2", SqlDbType.Decimal).Value = TC_CB_LS_SRDAMT2
            SQLcmd.Parameters.Add("@TC_CB_LS_BLNBF", SqlDbType.Decimal).Value = TC_CB_LS_BLNBF
            SQLcmd.Parameters.Add("@TC_CB_LS_AMTTUT", SqlDbType.Decimal).Value = TC_CB_LS_AMTTUT
            SQLcmd.Parameters.Add("@TC_CB_LS_BLNCF", SqlDbType.Decimal).Value = TC_CB_LS_BLNCF
            SQLcmd.Parameters.Add("@TC_COMPANY", SqlDbType.NVarChar, 8).Value = TC_COMPANY
            SQLcmd.Parameters.Add("@TC_PIONEERDESC", SqlDbType.NVarChar, 255).Value = TC_PIONEERDESC
            SQLcmd.Parameters.Add("@TC_PIO", SqlDbType.NVarChar, 3).Value = TC_PIO
            SQLcmd.Parameters.Add("@TC_PIONEER", SqlDbType.Decimal).Value = TC_PIONEER
            SQLcmd.Parameters.Add("@TC_RA_RATE1", SqlDbType.Decimal).Value = TC_RA_RATE1
            SQLcmd.Parameters.Add("@TC_RA_QUALIFYINGCAPITALEXP", SqlDbType.Decimal).Value = TC_RA_QUALIFYINGCAPITALEXP
            SQLcmd.Parameters.Add("@TC_RA_QUALIFYINGCAPITALEXP_AMOUNT", SqlDbType.Decimal).Value = TC_RA_QUALIFYINGCAPITALEXP_AMOUNT
            SQLcmd.Parameters.Add("@TC_RA_BALANCINGALLOWANCE", SqlDbType.Decimal).Value = TC_RA_BALANCINGALLOWANCE
            SQLcmd.Parameters.Add("@TC_RA_TOTAL1", SqlDbType.Decimal).Value = TC_RA_TOTAL1
            SQLcmd.Parameters.Add("@TC_RA_RESTRICTRATE", SqlDbType.Decimal).Value = TC_RA_RESTRICTRATE
            SQLcmd.Parameters.Add("@TC_RA_RESTRICTAMOUNT", SqlDbType.Decimal).Value = TC_RA_RESTRICTAMOUNT
            SQLcmd.Parameters.Add("@TC_ITA_RATE1", SqlDbType.Decimal).Value = TC_ITA_RATE1
            SQLcmd.Parameters.Add("@TC_ITA_QUALIFYINGCAPITALEXP", SqlDbType.Decimal).Value = TC_ITA_QUALIFYINGCAPITALEXP
            SQLcmd.Parameters.Add("@TC_ITA_QUALIFYINGCAPITALEXP_AMOUNT", SqlDbType.Decimal).Value = TC_ITA_QUALIFYINGCAPITALEXP_AMOUNT
            SQLcmd.Parameters.Add("@TC_ITA_BALANCINGALLOWANCE", SqlDbType.Decimal).Value = TC_ITA_BALANCINGALLOWANCE
            SQLcmd.Parameters.Add("@TC_ITA_TOTAL1", SqlDbType.Decimal).Value = TC_ITA_TOTAL1
            SQLcmd.Parameters.Add("@TC_ITA_RESTRICTRATE", SqlDbType.Decimal).Value = TC_ITA_RESTRICTRATE
            SQLcmd.Parameters.Add("@TC_ITA_RESTRICTAMOUNT", SqlDbType.Decimal).Value = TC_ITA_RESTRICTAMOUNT
            SQLcmd.Parameters.Add("@TC_DISALLOW_NOTE", SqlDbType.NVarChar, 255).Value = TC_DISALLOW_NOTE
            SQLcmd.Parameters.Add("@TC_DISALLOWBUSINESS_NOTE", SqlDbType.NVarChar, 255).Value = TC_DISALLOWBUSINESS_NOTE
            SQLcmd.Parameters.Add("@TC_SURPLUSRECOVERED", SqlDbType.Decimal).Value = TC_SURPLUSRECOVERED
            SQLcmd.Parameters.Add("@TC_MININGALLOWNANCE", SqlDbType.Decimal).Value = TC_MININGALLOWNANCE
            SQLcmd.Parameters.Add("@TC_MININGEXPENSES", SqlDbType.Decimal).Value = TC_MININGEXPENSES
            SQLcmd.Parameters.Add("@TC_STAT_DIVIDEND", SqlDbType.Decimal).Value = TC_STAT_DIVIDEND
            SQLcmd.Parameters.Add("@TC_TP_SEC110B", SqlDbType.Decimal).Value = TC_TP_SEC110B
            SQLcmd.Parameters.Add("@TC_NB_RENT_OTH2", SqlDbType.Decimal).Value = TC_NB_RENT_OTH2
            SQLcmd.Parameters.Add("@TC_NB_CARRYBCKLOSS", SqlDbType.Decimal).Value = TC_NB_CARRYBCKLOSS
            SQLcmd.Parameters.Add("@TC_NB_AMTNOTCARRYBCK", SqlDbType.Decimal).Value = TC_NB_AMTNOTCARRYBCK
            SQLcmd.Parameters.Add("@TC_NB_CHKCB", SqlDbType.Bit).Value = TC_NB_CHKCB
            SQLcmd.Parameters.Add("@TC_TP_INCOME_TP2", SqlDbType.Decimal).Value = TC_TP_INCOME_TP2
            SQLcmd.Parameters.Add("@TC_TP_ESTIMATED_TP", SqlDbType.Decimal).Value = TC_TP_ESTIMATED_TP
            SQLcmd.Parameters.Add("@TC_TP_INCOME_TP3", SqlDbType.Decimal).Value = TC_TP_INCOME_TP3
            SQLcmd.Parameters.Add("@TC_TP_ALL_DIFF", SqlDbType.Decimal).Value = TC_TP_ALL_DIFF
            SQLcmd.Parameters.Add("@TC_TP_EX_DIFF", SqlDbType.Decimal).Value = TC_TP_EX_DIFF
            SQLcmd.Parameters.Add("@TC_TP_PEN_DIFF", SqlDbType.Decimal).Value = TC_TP_PEN_DIFF
            SQLcmd.Parameters.Add("@TC_WITHRAITA", SqlDbType.Decimal).Value = TC_WITHRAITA
            SQLcmd.Parameters.Add("@TC_RA_WITHDRAWAL", SqlDbType.Decimal).Value = TC_RA_WITHDRAWAL
            SQLcmd.Parameters.Add("@TC_RA_ADJUSTMENT", SqlDbType.Decimal).Value = TC_RA_ADJUSTMENT
            SQLcmd.Parameters.Add("@TC_ITA_WITHDRAWAL", SqlDbType.Decimal).Value = TC_ITA_WITHDRAWAL
            SQLcmd.Parameters.Add("@TC_ITA_ADJUSTMENT", SqlDbType.Decimal).Value = TC_ITA_ADJUSTMENT
            SQLcmd.Parameters.Add("@TC_NB_DIV_OTH", SqlDbType.Decimal).Value = TC_NB_DIV_OTH
            SQLcmd.Parameters.Add("@TC_NB_INT_OTH", SqlDbType.Decimal).Value = TC_NB_INT_OTH
            SQLcmd.Parameters.Add("@TC_SUNDRY_EXP", SqlDbType.Decimal).Value = TC_SUNDRY_EXP
            SQLcmd.Parameters.Add("@TC_CHK_EXEMP", SqlDbType.NVarChar, 25).Value = TC_CHK_EXEMP
            SQLcmd.Parameters.Add("@TC_SI_TOT_PARTNERSHIP", SqlDbType.Decimal).Value = TC_SI_TOT_PARTNERSHIP
            SQLcmd.Parameters.Add("@TC_CB_CA_ACA", SqlDbType.Decimal).Value = TC_CB_CA_ACA
            SQLcmd.Parameters.Add("@TC_NB_RENTIBA", SqlDbType.Decimal).Value = TC_NB_RENTIBA
            SQLcmd.Parameters.Add("@TC_NB_RENTIBA_ATT_IN", SqlDbType.Decimal).Value = TC_NB_RENTIBA_ATT_IN
            SQLcmd.Parameters.Add("@TC_NB_RENTIBA_ASSESS", SqlDbType.Decimal).Value = TC_NB_RENTIBA_ASSESS
            SQLcmd.Parameters.Add("@TC_NB_RENTIBA_QUIT", SqlDbType.Decimal).Value = TC_NB_RENTIBA_QUIT
            SQLcmd.Parameters.Add("@TC_NB_RENTIBA_INSUR", SqlDbType.Decimal).Value = TC_NB_RENTIBA_INSUR
            SQLcmd.Parameters.Add("@TC_NB_RENTIBA_OTH", SqlDbType.Decimal).Value = TC_NB_RENTIBA_OTH
            SQLcmd.Parameters.Add("@TC_NB_RENTIBA_MAIN", SqlDbType.Decimal).Value = TC_NB_RENTIBA_MAIN
            SQLcmd.Parameters.Add("@TC_NB_RENTIBA_AGREE", SqlDbType.Decimal).Value = TC_NB_RENTIBA_AGREE
            SQLcmd.Parameters.Add("@TC_NB_RENTIBA_IBA", SqlDbType.Decimal).Value = TC_NB_RENTIBA_IBA
            SQLcmd.Parameters.Add("@TC_NB_DIV_DIS_ATT_INT", SqlDbType.Decimal).Value = TC_NB_DIV_DIS_ATT_INT
            SQLcmd.Parameters.Add("@TC_NB_DIV_TOT_ATT_INT", SqlDbType.Decimal).Value = TC_NB_DIV_TOT_ATT_INT
            SQLcmd.Parameters.Add("@TC_EA_UTL", SqlDbType.Decimal).Value = TC_EA_UTL
            SQLcmd.Parameters.Add("@TC_EA_TYPE", SqlDbType.Decimal).Value = TC_EA_TYPE
            SQLcmd.Parameters.Add("@TC_EA_CURR_COMPANY", SqlDbType.Decimal).Value = TC_EA_CURR_COMPANY
            SQLcmd.Parameters.Add("@TC_EA_CURR_AGRICULTURE", SqlDbType.Decimal).Value = TC_EA_CURR_AGRICULTURE
            SQLcmd.Parameters.Add("@TC_EA_CURR_SIGNIFICANT", SqlDbType.Decimal).Value = TC_EA_CURR_SIGNIFICANT
            SQLcmd.Parameters.Add("@TC_EA_CURR_MARKET", SqlDbType.Decimal).Value = TC_EA_CURR_MARKET
            SQLcmd.Parameters.Add("@TC_EA_CURR_MSB", SqlDbType.Decimal).Value = TC_EA_CURR_MSB
            SQLcmd.Parameters.Add("@TC_EA_TOTAL", SqlDbType.Decimal).Value = TC_EA_TOTAL
            SQLcmd.Parameters.Add("@TC_EA_RESTRICTRATE", SqlDbType.Decimal).Value = TC_EA_RESTRICTRATE
            SQLcmd.Parameters.Add("@TC_EA_BF", SqlDbType.Decimal).Value = TC_EA_BF
            SQLcmd.Parameters.Add("@TC_EA_CF", SqlDbType.Decimal).Value = TC_EA_CF
            SQLcmd.Parameters.Add("@TC_TP_ESTIMATED_SME", SqlDbType.NVarChar, 2).Value = TC_TP_ESTIMATED_SME
            SQLcmd.Parameters.Add("@TC_NB_DCA_INT", SqlDbType.Decimal).Value = TC_NB_DCA_INT
            SQLcmd.Parameters.Add("@TC_NB_DEEMED_INT", SqlDbType.Decimal).Value = TC_NB_DEEMED_INT
            SQLcmd.Parameters.Add("@TC_EXEMPTIONCAL", SqlDbType.Decimal).Value = TC_EXEMPTIONCAL
            SQLcmd.Parameters.Add("@TC_EXEMPTIONLESS", SqlDbType.Decimal).Value = TC_EXEMPTIONLESS
            SQLcmd.Parameters.Add("@TC_TP_INSTALL_107C", SqlDbType.Decimal).Value = TC_TP_INSTALL_107C
            SQLcmd.Parameters.Add("@TC_TP_INSTALL_107A", SqlDbType.Decimal).Value = TC_TP_INSTALL_107A
            SQLcmd.Parameters.Add("@TC_TP_RATE7", SqlDbType.Int).Value = TC_TP_RATE7
            SQLcmd.Parameters.Add("@TC_TP_APP_CHARGEABLE7", SqlDbType.Decimal).Value = TC_TP_APP_CHARGEABLE7
            SQLcmd.Parameters.Add("@TC_TP_RATE6_CHARGEABLE", SqlDbType.Decimal).Value = TC_TP_RATE6_CHARGEABLE
            SQLcmd.Parameters.Add("@TC_TP_RATE7_CHARGEABLE", SqlDbType.Decimal).Value = TC_TP_RATE7_CHARGEABLE
            SQLcmd.Parameters.Add("@TC_EA_TYPE1", SqlDbType.Decimal).Value = TC_EA_TYPE1
            SQLcmd.Parameters.Add("@TC_EA_TYPE2", SqlDbType.Decimal).Value = TC_EA_TYPE2
            SQLcmd.Parameters.Add("@TC_EA_TYPE3", SqlDbType.Decimal).Value = TC_EA_TYPE3


            ListOfSQLCmd.Add(SQLcmd)
            Return True

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Private Function Update_Taxcomputation(ByRef ListOfSQLCmd As List(Of SqlCommand)) As Boolean
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "UPDATE TAX_COMPUTATION SET TC_CO_NAME=@TC_CO_NAME,"
            StrSQL += "TC_ROC=@TC_ROC,TC_BUSINESS=@TC_BUSINESS,TC_AI_PNL_BAL=@TC_AI_PNL_BAL,TC_AI_DIVIDEND=@TC_AI_DIVIDEND,TC_AI_RENTAL=@TC_AI_RENTAL,"
            StrSQL += "TC_AI_ROYALTY=@TC_AI_ROYALTY,TC_AI_INTEREST=@TC_AI_INTEREST,TC_AI_SEC4A=@TC_AI_SEC4A,TC_AI_TOT_NONBS_IN=@TC_AI_TOT_NONBS_IN,"
            StrSQL += "TC_AI_TOT_BS_IN=@TC_AI_TOT_BS_IN,TC_AI_ADJ_BS_IN_NA_LOS=@TC_AI_ADJ_BS_IN_NA_LOS,TC_AI_ADJ_BS_IN_NT_IN=@TC_AI_ADJ_BS_IN_NT_IN,"
            StrSQL += "TC_AI_ADJ_BS_IN_TAX_IN=@TC_AI_ADJ_BS_IN_TAX_IN,TC_AI_TOT_ADJ_BS_IN=@TC_AI_TOT_ADJ_BS_IN,TC_AI_ADJ_BS_EXP_INT=@TC_AI_ADJ_BS_EXP_INT,"
            StrSQL += "TC_AI_ADJ_BS_EXP_NA_EXP=@TC_AI_ADJ_BS_EXP_NA_EXP,TC_AI_ADJ_BS_EXP_RV_EXP=@TC_AI_ADJ_BS_EXP_RV_EXP,TC_AI_ADJ_BS_EXP_CLAIM=@TC_AI_ADJ_BS_EXP_CLAIM,"
            StrSQL += "TC_AI_TOT_ADJ_BS_EXP=@TC_AI_TOT_ADJ_BS_EXP,TC_AI_ADJ_IN_LOSS=@TC_AI_ADJ_IN_LOSS,TC_SI_ADJ_BS_IN=@TC_SI_ADJ_BS_IN,TC_SI_CA=@TC_SI_CA,"
            StrSQL += "TC_SI_STAT_BS_IN=@TC_SI_STAT_BS_IN,TC_SI_INVEST_ALLOW=@TC_SI_INVEST_ALLOW,TC_SI_NET_STAT_IN=@TC_SI_NET_STAT_IN,TC_SI_SS_RENTAL=@TC_SI_SS_RENTAL,"
            StrSQL += "TC_SI_SS_DIR_EXP=@TC_SI_SS_DIR_EXP,TC_SI_SS_DIR_EXP_QUIT=@TC_SI_SS_DIR_EXP_QUIT,TC_SI_SS_DIR_EXP_MAIN=@TC_SI_SS_DIR_EXP_MAIN,"
            StrSQL += "TC_SI_SS_ADJ_IN=@TC_SI_SS_ADJ_IN,TC_SI_SS_CA=@TC_SI_SS_CA,TC_SI_SS_STAT_BS_IN=@TC_SI_SS_STAT_BS_IN,TC_SI_OTH_SOURCE=@TC_SI_OTH_SOURCE,"
            StrSQL += "TC_SI_MAIN_BS=@TC_SI_MAIN_BS,TC_SI_SEC_BS=@TC_SI_SEC_BS,TC_SI_OTH_BS=@TC_SI_OTH_BS,TC_SI_TOT=@TC_SI_TOT,TC_SI_BS_LOSS_BF=@TC_SI_BS_LOSS_BF,"
            StrSQL += "TC_SI_AGGREGATE=@TC_SI_AGGREGATE,TC_NB_DIV=@TC_NB_DIV,TC_NB_DIV_ATT_INT=@TC_NB_DIV_ATT_INT,TC_NB_DIV_NET=@TC_NB_DIV_NET,TC_NB_INT=@TC_NB_INT,"
            StrSQL += "TC_NB_INT_ATT_INT=@TC_NB_INT_ATT_INT,TC_NB_INT_NET=@TC_NB_INT_NET,TC_NB_RENT=@TC_NB_RENT,TC_NB_RENT_ATT_INT=@TC_NB_RENT_ATT_INT,"
            StrSQL += "TC_NB_RENT_ASSESS=@TC_NB_RENT_ASSESS,TC_NB_RENT_QUIT=@TC_NB_RENT_QUIT,TC_NB_RENT_INSUR=@TC_NB_RENT_INSUR,TC_NB_RENT_OTH=@TC_NB_RENT_OTH,"
            StrSQL += "TC_NB_RENT_MAIN=@TC_NB_RENT_MAIN,TC_NB_RENT_AGREE=@TC_NB_RENT_AGREE,TC_NB_RENT_NET=@TC_NB_RENT_NET,TC_NB_SUNDRY=@TC_NB_SUNDRY,"
            StrSQL += "TC_NB_OTH_AGGR_STAT=@TC_NB_OTH_AGGR_STAT,TC_TP_AGGR_IN=@TC_TP_AGGR_IN,TC_TP_CURR_LOSS=@TC_TP_CURR_LOSS,TC_TP_AGGR_IN_LOSS=@TC_TP_AGGR_IN_LOSS,"
            StrSQL += "TC_TP_APRV_DONATION=@TC_TP_APRV_DONATION,TC_TP_CHARGEABLE=@TC_TP_CHARGEABLE,TC_TP_28_CHARGEABLE=@TC_TP_28_CHARGEABLE,TC_TP_SEC110=@TC_TP_SEC110,"
            StrSQL += "TC_TP_SEC132=@TC_TP_SEC132,TC_TP_SEC133=@TC_TP_SEC133,TC_TP_TOT_SETOFF=@TC_TP_TOT_SETOFF,TC_TP_PAYABLE=@TC_TP_PAYABLE,"
            StrSQL += "TC_TP_INSTALL=@TC_TP_INSTALL,TC_TP_PAYABLE_BAL=@TC_TP_PAYABLE_BAL,TC_CB_CA_BAL_BF=@TC_CB_CA_BAL_BF,TC_CB_CA_CURR=@TC_CB_CA_CURR,TC_CB_CA_AA=@TC_CB_CA_AA,"
            StrSQL += "TC_CB_CA_IA=@TC_CB_CA_IA,TC_CB_CA_BA=@TC_CB_CA_BA,TC_CB_CA_UTIL=@TC_CB_CA_UTIL,TC_CB_CA_BAL_CF=@TC_CB_CA_BAL_CF,TC_CB_LS_BAL_BF=@TC_CB_LS_BAL_BF,"
            StrSQL += "TC_CB_LS_UTIL=@TC_CB_LS_UTIL,TC_CB_LS_BAL_UTIL=@TC_CB_LS_BAL_UTIL,TC_CB_LS_UNABSORBED=@TC_CB_LS_UNABSORBED,TC_CB_LS_BAL_CF=@TC_CB_LS_BAL_CF,"
            StrSQL += "TC_CB_ITA_BAL_BF=@TC_CB_ITA_BAL_BF,TC_CB_ITA_CURR=@TC_CB_ITA_CURR,TC_CB_ITA_BAL_BF_CURR=@TC_CB_ITA_BAL_BF_CURR,TC_CB_ITA_UTIL=@TC_CB_ITA_UTIL,"
            StrSQL += "TC_CB_ITA_BAL_CF=@TC_CB_ITA_BAL_CF,TC_AI_OTH_BS_IN=@TC_AI_OTH_BS_IN,TC_TP_RATE1=@TC_TP_RATE1,TC_TP_RATE2=@TC_TP_RATE2,TC_TP_RATE3=@TC_TP_RATE3,"
            StrSQL += "TC_TP_RATE4=@TC_TP_RATE4,TC_TP_RATE5=@TC_TP_RATE5,TC_TP_RATE6=@TC_TP_RATE6,TC_TP_APP_CHARGEABLE1=@TC_TP_APP_CHARGEABLE1,"
            StrSQL += "TC_TP_APP_CHARGEABLE2=@TC_TP_APP_CHARGEABLE2,TC_TP_APP_CHARGEABLE3=@TC_TP_APP_CHARGEABLE3,TC_TP_APP_CHARGEABLE4=@TC_TP_APP_CHARGEABLE4,"
            StrSQL += "TC_TP_APP_CHARGEABLE5=@TC_TP_APP_CHARGEABLE5,TC_TP_APP_CHARGEABLE6=@TC_TP_APP_CHARGEABLE6,TC_TP_RATE1_CHARGEABLE=@TC_TP_RATE1_CHARGEABLE,"
            StrSQL += "TC_TP_RATE2_CHARGEABLE=@TC_TP_RATE2_CHARGEABLE,TC_TP_RATE3_CHARGEABLE=@TC_TP_RATE3_CHARGEABLE,TC_TP_RATE4_CHARGEABLE=@TC_TP_RATE4_CHARGEABLE,"
            StrSQL += "TC_TP_RATE5_CHARGEABLE=@TC_TP_RATE5_CHARGEABLE,TC_TP_TOT_TAX_CHARGED=@TC_TP_TOT_TAX_CHARGED,TC_TP_SEC6B_REBATE=@TC_TP_SEC6B_REBATE,"
            StrSQL += "TC_TP_SEC110_OTHERS=@TC_TP_SEC110_OTHERS,TC_TP_PROSPECTING=@TC_TP_PROSPECTING,TC_TP_QUALIFY_AGRICULTURE=@TC_TP_QUALIFY_AGRICULTURE,"
            StrSQL += "TC_TP_PREOP_BS=@TC_TP_PREOP_BS,TC_TP_FOOD_PRODUCTION=@TC_TP_FOOD_PRODUCTION,TC_TP_EXP_ALLOWED=@TC_TP_EXP_ALLOWED,"
            StrSQL += "TC_TP_TOTAL_OTH_EXP=@TC_TP_TOTAL_OTH_EXP,TC_TP_TOTAL_INCOME=@TC_TP_TOTAL_INCOME,TC_TP_PIONEER_CHARGE=@TC_TP_PIONEER_CHARGE,"
            StrSQL += "TC_TP_OPERATIONALHQ_CHARGE=@TC_TP_OPERATIONALHQ_CHARGE,TC_TP_FOREIGN_CHARGE=@TC_TP_FOREIGN_CHARGE,TC_TP_BS_LOSS=@TC_TP_BS_LOSS,"
            StrSQL += "TC_NB_ROYALTY=@TC_NB_ROYALTY,TC_NB_ADDITION=@TC_NB_ADDITION,TC_CB_LS_ADJUST_LOSS=@TC_CB_LS_ADJUST_LOSS,TC_CB_LS_UTIL_CURR=@TC_CB_LS_UTIL_CURR,"
            StrSQL += "TC_SI_RA=@TC_SI_RA,TC_CB_RA_BAL_BF=@TC_CB_RA_BAL_BF,TC_CB_RA_CURR=@TC_CB_RA_CURR,TC_CB_RA_BAL_BF_CURR=@TC_CB_RA_BAL_BF_CURR,TC_CB_RA_UTIL=@TC_CB_RA_UTIL,"
            StrSQL += "TC_CB_RA_BAL_CF=@TC_CB_RA_BAL_CF,TC_SI_BC=@TC_SI_BC,TC_SI_ADJ_BS_IN_BC=@TC_SI_ADJ_BS_IN_BC,TC_CB_CA_CURR_BA=@TC_CB_CA_CURR_BA,TC_TP_RATE4A=@TC_TP_RATE4A,"
            StrSQL += "TC_TP_APP_CHARGEABLE4A=@TC_TP_APP_CHARGEABLE4A,TC_TP_RATE4A_CHARGEABLE=@TC_TP_RATE4A_CHARGEABLE,TC_CB_CA_NA=@TC_CB_CA_NA,TC_TP_ZAKAT=@TC_TP_ZAKAT,"
            StrSQL += "TC_OTHERDEDUCTION=@TC_OTHERDEDUCTION,TC_CB_CA_DISALLOW=@TC_CB_CA_DISALLOW,TC_CB_CA_ABAL_CF=@TC_CB_CA_ABAL_CF,TC_CB_CHECK=@TC_CB_CHECK,"
            StrSQL += "TC_TP_CLAIM=@TC_TP_CLAIM,TC_CB_LS_SAMOUNT=@TC_CB_LS_SAMOUNT,TC_CB_LS_BALS_CF=@TC_CB_LS_BALS_CF,TC_CB_LS_D_BL=@TC_CB_LS_D_BL,"
            StrSQL += "TC_CB_LS_SRDAMT2=@TC_CB_LS_SRDAMT2,TC_CB_LS_BLNBF=@TC_CB_LS_BLNBF,TC_CB_LS_AMTTUT=@TC_CB_LS_AMTTUT,TC_CB_LS_BLNCF=@TC_CB_LS_BLNCF,"
            StrSQL += "TC_COMPANY=@TC_COMPANY,TC_PIONEERDESC=@TC_PIONEERDESC,TC_PIO=@TC_PIO,TC_PIONEER=@TC_PIONEER,TC_RA_RATE1=@TC_RA_RATE1,"
            StrSQL += "TC_RA_QUALIFYINGCAPITALEXP=@TC_RA_QUALIFYINGCAPITALEXP,TC_RA_QUALIFYINGCAPITALEXP_AMOUNT=@TC_RA_QUALIFYINGCAPITALEXP_AMOUNT,"
            StrSQL += "TC_RA_BALANCINGALLOWANCE=@TC_RA_BALANCINGALLOWANCE,TC_RA_TOTAL1=@TC_RA_TOTAL1,TC_RA_RESTRICTRATE=@TC_RA_RESTRICTRATE,"
            StrSQL += "TC_RA_RESTRICTAMOUNT=@TC_RA_RESTRICTAMOUNT,TC_ITA_RATE1=@TC_ITA_RATE1,TC_ITA_QUALIFYINGCAPITALEXP=@TC_ITA_QUALIFYINGCAPITALEXP,"
            StrSQL += "TC_ITA_QUALIFYINGCAPITALEXP_AMOUNT=@TC_ITA_QUALIFYINGCAPITALEXP_AMOUNT,TC_ITA_BALANCINGALLOWANCE=@TC_ITA_BALANCINGALLOWANCE,TC_ITA_TOTAL1=@TC_ITA_TOTAL1,"
            StrSQL += "TC_ITA_RESTRICTRATE=@TC_ITA_RESTRICTRATE,TC_ITA_RESTRICTAMOUNT=@TC_ITA_RESTRICTAMOUNT,TC_DISALLOW_NOTE=@TC_DISALLOW_NOTE,"
            StrSQL += "TC_DISALLOWBUSINESS_NOTE=@TC_DISALLOWBUSINESS_NOTE,TC_SURPLUSRECOVERED=@TC_SURPLUSRECOVERED,TC_MININGALLOWNANCE=@TC_MININGALLOWNANCE,"
            StrSQL += "TC_MININGEXPENSES=@TC_MININGEXPENSES,TC_STAT_DIVIDEND=@TC_STAT_DIVIDEND,TC_TP_SEC110B=@TC_TP_SEC110B,TC_NB_RENT_OTH2=@TC_NB_RENT_OTH2,"
            StrSQL += "TC_NB_CARRYBCKLOSS=@TC_NB_CARRYBCKLOSS,TC_NB_AMTNOTCARRYBCK=@TC_NB_AMTNOTCARRYBCK,TC_NB_CHKCB=@TC_NB_CHKCB,TC_TP_INCOME_TP2=@TC_TP_INCOME_TP2,"
            StrSQL += "TC_TP_ESTIMATED_TP=@TC_TP_ESTIMATED_TP,TC_TP_INCOME_TP3=@TC_TP_INCOME_TP3,TC_TP_ALL_DIFF=@TC_TP_ALL_DIFF,TC_TP_EX_DIFF=@TC_TP_EX_DIFF,"
            StrSQL += "TC_TP_PEN_DIFF=@TC_TP_PEN_DIFF,TC_WITHRAITA=@TC_WITHRAITA,TC_RA_WITHDRAWAL=@TC_RA_WITHDRAWAL,TC_RA_ADJUSTMENT=@TC_RA_ADJUSTMENT,"
            StrSQL += "TC_ITA_WITHDRAWAL=@TC_ITA_WITHDRAWAL,TC_ITA_ADJUSTMENT=@TC_ITA_ADJUSTMENT,TC_NB_DIV_OTH=@TC_NB_DIV_OTH,TC_NB_INT_OTH=@TC_NB_INT_OTH,"
            StrSQL += "TC_SUNDRY_EXP=@TC_SUNDRY_EXP,TC_CHK_EXEMP=@TC_CHK_EXEMP,TC_SI_TOT_PARTNERSHIP=@TC_SI_TOT_PARTNERSHIP,TC_CB_CA_ACA=@TC_CB_CA_ACA,"
            StrSQL += "TC_NB_RENTIBA=@TC_NB_RENTIBA,TC_NB_RENTIBA_ATT_IN=@TC_NB_RENTIBA_ATT_IN,TC_NB_RENTIBA_ASSESS=@TC_NB_RENTIBA_ASSESS,"
            StrSQL += "TC_NB_RENTIBA_QUIT=@TC_NB_RENTIBA_QUIT,TC_NB_RENTIBA_INSUR=@TC_NB_RENTIBA_INSUR,TC_NB_RENTIBA_OTH=@TC_NB_RENTIBA_OTH,"
            StrSQL += "TC_NB_RENTIBA_MAIN=@TC_NB_RENTIBA_MAIN,TC_NB_RENTIBA_AGREE=@TC_NB_RENTIBA_AGREE,TC_NB_RENTIBA_IBA=@TC_NB_RENTIBA_IBA,"
            StrSQL += "TC_NB_DIV_DIS_ATT_INT=@TC_NB_DIV_DIS_ATT_INT,TC_NB_DIV_TOT_ATT_INT=@TC_NB_DIV_TOT_ATT_INT,TC_EA_UTL=@TC_EA_UTL,TC_EA_TYPE=@TC_EA_TYPE,"
            StrSQL += "TC_EA_CURR_COMPANY=@TC_EA_CURR_COMPANY,TC_EA_CURR_AGRICULTURE=@TC_EA_CURR_AGRICULTURE,TC_EA_CURR_SIGNIFICANT=@TC_EA_CURR_SIGNIFICANT,"
            StrSQL += "TC_EA_CURR_MARKET=@TC_EA_CURR_MARKET,TC_EA_CURR_MSB=@TC_EA_CURR_MSB,TC_EA_TOTAL=@TC_EA_TOTAL,TC_EA_RESTRICTRATE=@TC_EA_RESTRICTRATE,"
            StrSQL += "TC_EA_BF=@TC_EA_BF,TC_EA_CF=@TC_EA_CF,TC_TP_ESTIMATED_SME=@TC_TP_ESTIMATED_SME,TC_NB_DCA_INT=@TC_NB_DCA_INT,TC_NB_DEEMED_INT=@TC_NB_DEEMED_INT,"
            StrSQL += "TC_EXEMPTIONCAL=@TC_EXEMPTIONCAL,TC_EXEMPTIONLESS=@TC_EXEMPTIONLESS,TC_TP_INSTALL_107C=@TC_TP_INSTALL_107C,TC_TP_INSTALL_107A=@TC_TP_INSTALL_107A,"
            StrSQL += "TC_TP_RATE7=@TC_TP_RATE7,TC_TP_APP_CHARGEABLE7=@TC_TP_APP_CHARGEABLE7,TC_TP_RATE6_CHARGEABLE=@TC_TP_RATE6_CHARGEABLE,"
            StrSQL += "TC_TP_RATE7_CHARGEABLE=@TC_TP_RATE7_CHARGEABLE,TC_EA_TYPE1=@TC_EA_TYPE1,TC_EA_TYPE2=@TC_EA_TYPE2,TC_EA_TYPE3=@TC_EA_TYPE3 WHERE TC_KEY=@TC_KEY"

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@TC_KEY", SqlDbType.Int).Value = TC_KEY
            SQLcmd.Parameters.Add("@TC_CO_NAME", SqlDbType.NVarChar, 255).Value = TC_CO_NAME
            SQLcmd.Parameters.Add("@TC_ROC", SqlDbType.NVarChar, 20).Value = TC_ROC
            SQLcmd.Parameters.Add("@TC_BUSINESS", SqlDbType.Int).Value = TC_BUSINESS
            SQLcmd.Parameters.Add("@TC_AI_PNL_BAL", SqlDbType.Decimal).Value = TC_AI_PNL_BAL
            SQLcmd.Parameters.Add("@TC_AI_DIVIDEND", SqlDbType.Decimal).Value = TC_AI_DIVIDEND
            SQLcmd.Parameters.Add("@TC_AI_RENTAL", SqlDbType.Decimal).Value = TC_AI_RENTAL
            SQLcmd.Parameters.Add("@TC_AI_ROYALTY", SqlDbType.Decimal).Value = TC_AI_ROYALTY
            SQLcmd.Parameters.Add("@TC_AI_INTEREST", SqlDbType.Decimal).Value = TC_AI_INTEREST
            SQLcmd.Parameters.Add("@TC_AI_SEC4A", SqlDbType.Decimal).Value = TC_AI_SEC4A
            SQLcmd.Parameters.Add("@TC_AI_TOT_NONBS_IN", SqlDbType.Decimal).Value = TC_AI_TOT_NONBS_IN
            SQLcmd.Parameters.Add("@TC_AI_TOT_BS_IN", SqlDbType.Decimal).Value = TC_AI_TOT_BS_IN
            SQLcmd.Parameters.Add("@TC_AI_ADJ_BS_IN_NA_LOS", SqlDbType.Decimal).Value = TC_AI_ADJ_BS_IN_NA_LOS
            SQLcmd.Parameters.Add("@TC_AI_ADJ_BS_IN_NT_IN", SqlDbType.Decimal).Value = TC_AI_ADJ_BS_IN_NT_IN
            SQLcmd.Parameters.Add("@TC_AI_ADJ_BS_IN_TAX_IN", SqlDbType.Decimal).Value = TC_AI_ADJ_BS_IN_TAX_IN
            SQLcmd.Parameters.Add("@TC_AI_TOT_ADJ_BS_IN", SqlDbType.Decimal).Value = TC_AI_TOT_ADJ_BS_IN
            SQLcmd.Parameters.Add("@TC_AI_ADJ_BS_EXP_INT", SqlDbType.Decimal).Value = TC_AI_ADJ_BS_EXP_INT
            SQLcmd.Parameters.Add("@TC_AI_ADJ_BS_EXP_NA_EXP", SqlDbType.Decimal).Value = TC_AI_ADJ_BS_EXP_NA_EXP
            SQLcmd.Parameters.Add("@TC_AI_ADJ_BS_EXP_RV_EXP", SqlDbType.Decimal).Value = TC_AI_ADJ_BS_EXP_RV_EXP
            SQLcmd.Parameters.Add("@TC_AI_ADJ_BS_EXP_CLAIM", SqlDbType.Decimal).Value = TC_AI_ADJ_BS_EXP_CLAIM
            SQLcmd.Parameters.Add("@TC_AI_TOT_ADJ_BS_EXP", SqlDbType.Decimal).Value = TC_AI_TOT_ADJ_BS_EXP
            SQLcmd.Parameters.Add("@TC_AI_ADJ_IN_LOSS", SqlDbType.Decimal).Value = TC_AI_ADJ_IN_LOSS
            SQLcmd.Parameters.Add("@TC_SI_ADJ_BS_IN", SqlDbType.Decimal).Value = TC_SI_ADJ_BS_IN
            SQLcmd.Parameters.Add("@TC_SI_CA", SqlDbType.Decimal).Value = TC_SI_CA
            SQLcmd.Parameters.Add("@TC_SI_STAT_BS_IN", SqlDbType.Decimal).Value = TC_SI_STAT_BS_IN
            SQLcmd.Parameters.Add("@TC_SI_INVEST_ALLOW", SqlDbType.Decimal).Value = TC_SI_INVEST_ALLOW
            SQLcmd.Parameters.Add("@TC_SI_NET_STAT_IN", SqlDbType.Decimal).Value = TC_SI_NET_STAT_IN
            SQLcmd.Parameters.Add("@TC_SI_SS_RENTAL", SqlDbType.Decimal).Value = TC_SI_SS_RENTAL
            SQLcmd.Parameters.Add("@TC_SI_SS_DIR_EXP", SqlDbType.Decimal).Value = TC_SI_SS_DIR_EXP
            SQLcmd.Parameters.Add("@TC_SI_SS_DIR_EXP_QUIT", SqlDbType.Decimal).Value = TC_SI_SS_DIR_EXP_QUIT
            SQLcmd.Parameters.Add("@TC_SI_SS_DIR_EXP_MAIN", SqlDbType.Decimal).Value = TC_SI_SS_DIR_EXP_MAIN
            SQLcmd.Parameters.Add("@TC_SI_SS_ADJ_IN", SqlDbType.Decimal).Value = TC_SI_SS_ADJ_IN
            SQLcmd.Parameters.Add("@TC_SI_SS_CA", SqlDbType.Decimal).Value = TC_SI_SS_CA
            SQLcmd.Parameters.Add("@TC_SI_SS_STAT_BS_IN", SqlDbType.Decimal).Value = TC_SI_SS_STAT_BS_IN
            SQLcmd.Parameters.Add("@TC_SI_OTH_SOURCE", SqlDbType.Decimal).Value = TC_SI_OTH_SOURCE
            SQLcmd.Parameters.Add("@TC_SI_MAIN_BS", SqlDbType.Decimal).Value = TC_SI_MAIN_BS
            SQLcmd.Parameters.Add("@TC_SI_SEC_BS", SqlDbType.Decimal).Value = TC_SI_SEC_BS
            SQLcmd.Parameters.Add("@TC_SI_OTH_BS", SqlDbType.Decimal).Value = TC_SI_OTH_BS
            SQLcmd.Parameters.Add("@TC_SI_TOT", SqlDbType.Decimal).Value = TC_SI_TOT
            SQLcmd.Parameters.Add("@TC_SI_BS_LOSS_BF", SqlDbType.Decimal).Value = TC_SI_BS_LOSS_BF
            SQLcmd.Parameters.Add("@TC_SI_AGGREGATE", SqlDbType.Decimal).Value = TC_SI_AGGREGATE
            SQLcmd.Parameters.Add("@TC_NB_DIV", SqlDbType.Decimal).Value = TC_NB_DIV
            SQLcmd.Parameters.Add("@TC_NB_DIV_ATT_INT", SqlDbType.Decimal).Value = TC_NB_DIV_ATT_INT
            SQLcmd.Parameters.Add("@TC_NB_DIV_NET", SqlDbType.Decimal).Value = TC_NB_DIV_NET
            SQLcmd.Parameters.Add("@TC_NB_INT", SqlDbType.Decimal).Value = TC_NB_INT
            SQLcmd.Parameters.Add("@TC_NB_INT_ATT_INT", SqlDbType.Decimal).Value = TC_NB_INT_ATT_INT
            SQLcmd.Parameters.Add("@TC_NB_INT_NET", SqlDbType.Decimal).Value = TC_NB_INT_NET
            SQLcmd.Parameters.Add("@TC_NB_RENT", SqlDbType.Decimal).Value = TC_NB_RENT
            SQLcmd.Parameters.Add("@TC_NB_RENT_ATT_INT", SqlDbType.Decimal).Value = TC_NB_RENT_ATT_INT
            SQLcmd.Parameters.Add("@TC_NB_RENT_ASSESS", SqlDbType.Decimal).Value = TC_NB_RENT_ASSESS
            SQLcmd.Parameters.Add("@TC_NB_RENT_QUIT", SqlDbType.Decimal).Value = TC_NB_RENT_QUIT
            SQLcmd.Parameters.Add("@TC_NB_RENT_INSUR", SqlDbType.Decimal).Value = TC_NB_RENT_INSUR
            SQLcmd.Parameters.Add("@TC_NB_RENT_OTH", SqlDbType.Decimal).Value = TC_NB_RENT_OTH
            SQLcmd.Parameters.Add("@TC_NB_RENT_MAIN", SqlDbType.Decimal).Value = TC_NB_RENT_MAIN
            SQLcmd.Parameters.Add("@TC_NB_RENT_AGREE", SqlDbType.Decimal).Value = TC_NB_RENT_AGREE
            SQLcmd.Parameters.Add("@TC_NB_RENT_NET", SqlDbType.Decimal).Value = TC_NB_RENT_NET
            SQLcmd.Parameters.Add("@TC_NB_SUNDRY", SqlDbType.Decimal).Value = TC_NB_SUNDRY
            SQLcmd.Parameters.Add("@TC_NB_OTH_AGGR_STAT", SqlDbType.Decimal).Value = TC_NB_OTH_AGGR_STAT
            SQLcmd.Parameters.Add("@TC_TP_AGGR_IN", SqlDbType.Decimal).Value = TC_TP_AGGR_IN
            SQLcmd.Parameters.Add("@TC_TP_CURR_LOSS", SqlDbType.Decimal).Value = TC_TP_CURR_LOSS
            SQLcmd.Parameters.Add("@TC_TP_AGGR_IN_LOSS", SqlDbType.Decimal).Value = TC_TP_AGGR_IN_LOSS
            SQLcmd.Parameters.Add("@TC_TP_APRV_DONATION", SqlDbType.Decimal).Value = TC_TP_APRV_DONATION
            SQLcmd.Parameters.Add("@TC_TP_CHARGEABLE", SqlDbType.Decimal).Value = TC_TP_CHARGEABLE
            SQLcmd.Parameters.Add("@TC_TP_28_CHARGEABLE", SqlDbType.Decimal).Value = TC_TP_28_CHARGEABLE
            SQLcmd.Parameters.Add("@TC_TP_SEC110", SqlDbType.Decimal).Value = TC_TP_SEC110
            SQLcmd.Parameters.Add("@TC_TP_SEC132", SqlDbType.Decimal).Value = TC_TP_SEC132
            SQLcmd.Parameters.Add("@TC_TP_SEC133", SqlDbType.Decimal).Value = TC_TP_SEC133
            SQLcmd.Parameters.Add("@TC_TP_TOT_SETOFF", SqlDbType.Decimal).Value = TC_TP_TOT_SETOFF
            SQLcmd.Parameters.Add("@TC_TP_PAYABLE", SqlDbType.Decimal).Value = TC_TP_PAYABLE
            SQLcmd.Parameters.Add("@TC_TP_INSTALL", SqlDbType.Decimal).Value = TC_TP_INSTALL
            SQLcmd.Parameters.Add("@TC_TP_PAYABLE_BAL", SqlDbType.Decimal).Value = TC_TP_PAYABLE_BAL
            SQLcmd.Parameters.Add("@TC_CB_CA_BAL_BF", SqlDbType.Decimal).Value = TC_CB_CA_BAL_BF
            SQLcmd.Parameters.Add("@TC_CB_CA_CURR", SqlDbType.Decimal).Value = TC_CB_CA_CURR
            SQLcmd.Parameters.Add("@TC_CB_CA_AA", SqlDbType.Decimal).Value = TC_CB_CA_AA
            SQLcmd.Parameters.Add("@TC_CB_CA_IA", SqlDbType.Decimal).Value = TC_CB_CA_IA
            SQLcmd.Parameters.Add("@TC_CB_CA_BA", SqlDbType.Decimal).Value = TC_CB_CA_BA
            SQLcmd.Parameters.Add("@TC_CB_CA_UTIL", SqlDbType.Decimal).Value = TC_CB_CA_UTIL
            SQLcmd.Parameters.Add("@TC_CB_CA_BAL_CF", SqlDbType.Decimal).Value = TC_CB_CA_BAL_CF
            SQLcmd.Parameters.Add("@TC_CB_LS_BAL_BF", SqlDbType.Decimal).Value = TC_CB_LS_BAL_BF
            SQLcmd.Parameters.Add("@TC_CB_LS_UTIL", SqlDbType.Decimal).Value = TC_CB_LS_UTIL
            SQLcmd.Parameters.Add("@TC_CB_LS_BAL_UTIL", SqlDbType.Decimal).Value = TC_CB_LS_BAL_UTIL
            SQLcmd.Parameters.Add("@TC_CB_LS_UNABSORBED", SqlDbType.Decimal).Value = TC_CB_LS_UNABSORBED
            SQLcmd.Parameters.Add("@TC_CB_LS_BAL_CF", SqlDbType.Decimal).Value = TC_CB_LS_BAL_CF
            SQLcmd.Parameters.Add("@TC_CB_ITA_BAL_BF", SqlDbType.Decimal).Value = TC_CB_ITA_BAL_BF
            SQLcmd.Parameters.Add("@TC_CB_ITA_CURR", SqlDbType.Decimal).Value = TC_CB_ITA_CURR
            SQLcmd.Parameters.Add("@TC_CB_ITA_BAL_BF_CURR", SqlDbType.Decimal).Value = TC_CB_ITA_BAL_BF_CURR
            SQLcmd.Parameters.Add("@TC_CB_ITA_UTIL", SqlDbType.Decimal).Value = TC_CB_ITA_UTIL
            SQLcmd.Parameters.Add("@TC_CB_ITA_BAL_CF", SqlDbType.Decimal).Value = TC_CB_ITA_BAL_CF
            SQLcmd.Parameters.Add("@TC_AI_OTH_BS_IN", SqlDbType.Decimal).Value = TC_AI_OTH_BS_IN
            SQLcmd.Parameters.Add("@TC_TP_RATE1", SqlDbType.Int).Value = TC_TP_RATE1
            SQLcmd.Parameters.Add("@TC_TP_RATE2", SqlDbType.Int).Value = TC_TP_RATE2
            SQLcmd.Parameters.Add("@TC_TP_RATE3", SqlDbType.Int).Value = TC_TP_RATE3
            SQLcmd.Parameters.Add("@TC_TP_RATE4", SqlDbType.Int).Value = TC_TP_RATE4
            SQLcmd.Parameters.Add("@TC_TP_RATE5", SqlDbType.Int).Value = TC_TP_RATE5
            SQLcmd.Parameters.Add("@TC_TP_RATE6", SqlDbType.Int).Value = TC_TP_RATE6
            SQLcmd.Parameters.Add("@TC_TP_APP_CHARGEABLE1", SqlDbType.Decimal).Value = TC_TP_APP_CHARGEABLE1
            SQLcmd.Parameters.Add("@TC_TP_APP_CHARGEABLE2", SqlDbType.Decimal).Value = TC_TP_APP_CHARGEABLE2
            SQLcmd.Parameters.Add("@TC_TP_APP_CHARGEABLE3", SqlDbType.Decimal).Value = TC_TP_APP_CHARGEABLE3
            SQLcmd.Parameters.Add("@TC_TP_APP_CHARGEABLE4", SqlDbType.Decimal).Value = TC_TP_APP_CHARGEABLE4
            SQLcmd.Parameters.Add("@TC_TP_APP_CHARGEABLE5", SqlDbType.Decimal).Value = TC_TP_APP_CHARGEABLE5
            SQLcmd.Parameters.Add("@TC_TP_APP_CHARGEABLE6", SqlDbType.Decimal).Value = TC_TP_APP_CHARGEABLE6
            SQLcmd.Parameters.Add("@TC_TP_RATE1_CHARGEABLE", SqlDbType.Decimal).Value = TC_TP_RATE1_CHARGEABLE
            SQLcmd.Parameters.Add("@TC_TP_RATE2_CHARGEABLE", SqlDbType.Decimal).Value = TC_TP_RATE2_CHARGEABLE
            SQLcmd.Parameters.Add("@TC_TP_RATE3_CHARGEABLE", SqlDbType.Decimal).Value = TC_TP_RATE3_CHARGEABLE
            SQLcmd.Parameters.Add("@TC_TP_RATE4_CHARGEABLE", SqlDbType.Decimal).Value = TC_TP_RATE4_CHARGEABLE
            SQLcmd.Parameters.Add("@TC_TP_RATE5_CHARGEABLE", SqlDbType.Decimal).Value = TC_TP_RATE5_CHARGEABLE
            SQLcmd.Parameters.Add("@TC_TP_TOT_TAX_CHARGED", SqlDbType.Decimal).Value = TC_TP_TOT_TAX_CHARGED
            SQLcmd.Parameters.Add("@TC_TP_SEC6B_REBATE", SqlDbType.Decimal).Value = TC_TP_SEC6B_REBATE
            SQLcmd.Parameters.Add("@TC_TP_SEC110_OTHERS", SqlDbType.Decimal).Value = TC_TP_SEC110_OTHERS
            SQLcmd.Parameters.Add("@TC_TP_PROSPECTING", SqlDbType.Decimal).Value = TC_TP_PROSPECTING
            SQLcmd.Parameters.Add("@TC_TP_QUALIFY_AGRICULTURE", SqlDbType.Decimal).Value = TC_TP_QUALIFY_AGRICULTURE
            SQLcmd.Parameters.Add("@TC_TP_PREOP_BS", SqlDbType.Decimal).Value = TC_TP_PREOP_BS
            SQLcmd.Parameters.Add("@TC_TP_FOOD_PRODUCTION", SqlDbType.Decimal).Value = TC_TP_FOOD_PRODUCTION
            SQLcmd.Parameters.Add("@TC_TP_EXP_ALLOWED", SqlDbType.Decimal).Value = TC_TP_EXP_ALLOWED
            SQLcmd.Parameters.Add("@TC_TP_TOTAL_OTH_EXP", SqlDbType.Decimal).Value = TC_TP_TOTAL_OTH_EXP
            SQLcmd.Parameters.Add("@TC_TP_TOTAL_INCOME", SqlDbType.Decimal).Value = TC_TP_TOTAL_INCOME
            SQLcmd.Parameters.Add("@TC_TP_PIONEER_CHARGE", SqlDbType.Decimal).Value = TC_TP_PIONEER_CHARGE
            SQLcmd.Parameters.Add("@TC_TP_OPERATIONALHQ_CHARGE", SqlDbType.Decimal).Value = TC_TP_OPERATIONALHQ_CHARGE
            SQLcmd.Parameters.Add("@TC_TP_FOREIGN_CHARGE", SqlDbType.Decimal).Value = TC_TP_FOREIGN_CHARGE
            SQLcmd.Parameters.Add("@TC_TP_BS_LOSS", SqlDbType.Decimal).Value = TC_TP_BS_LOSS
            SQLcmd.Parameters.Add("@TC_NB_ROYALTY", SqlDbType.Decimal).Value = TC_NB_ROYALTY
            SQLcmd.Parameters.Add("@TC_NB_ADDITION", SqlDbType.Decimal).Value = TC_NB_ADDITION
            SQLcmd.Parameters.Add("@TC_CB_LS_ADJUST_LOSS", SqlDbType.Decimal).Value = TC_CB_LS_ADJUST_LOSS
            SQLcmd.Parameters.Add("@TC_CB_LS_UTIL_CURR", SqlDbType.Decimal).Value = TC_CB_LS_UTIL_CURR
            SQLcmd.Parameters.Add("@TC_SI_RA", SqlDbType.Decimal).Value = TC_SI_RA
            SQLcmd.Parameters.Add("@TC_CB_RA_BAL_BF", SqlDbType.Decimal).Value = TC_CB_RA_BAL_BF
            SQLcmd.Parameters.Add("@TC_CB_RA_CURR", SqlDbType.Decimal).Value = TC_CB_RA_CURR
            SQLcmd.Parameters.Add("@TC_CB_RA_BAL_BF_CURR", SqlDbType.Decimal).Value = TC_CB_RA_BAL_BF_CURR
            SQLcmd.Parameters.Add("@TC_CB_RA_UTIL", SqlDbType.Decimal).Value = TC_CB_RA_UTIL
            SQLcmd.Parameters.Add("@TC_CB_RA_BAL_CF", SqlDbType.Decimal).Value = TC_CB_RA_BAL_CF
            SQLcmd.Parameters.Add("@TC_SI_BC", SqlDbType.Decimal).Value = TC_SI_BC
            SQLcmd.Parameters.Add("@TC_SI_ADJ_BS_IN_BC", SqlDbType.Decimal).Value = TC_SI_ADJ_BS_IN_BC
            SQLcmd.Parameters.Add("@TC_CB_CA_CURR_BA", SqlDbType.Decimal).Value = TC_CB_CA_CURR_BA
            SQLcmd.Parameters.Add("@TC_TP_RATE4A", SqlDbType.Int).Value = TC_TP_RATE4A
            SQLcmd.Parameters.Add("@TC_TP_APP_CHARGEABLE4A", SqlDbType.Decimal).Value = TC_TP_APP_CHARGEABLE4A
            SQLcmd.Parameters.Add("@TC_TP_RATE4A_CHARGEABLE", SqlDbType.Decimal).Value = TC_TP_RATE4A_CHARGEABLE
            SQLcmd.Parameters.Add("@TC_CB_CA_NA", SqlDbType.Decimal).Value = TC_CB_CA_NA
            SQLcmd.Parameters.Add("@TC_TP_ZAKAT", SqlDbType.Decimal).Value = TC_TP_ZAKAT
            SQLcmd.Parameters.Add("@TC_OTHERDEDUCTION", SqlDbType.Decimal).Value = TC_OTHERDEDUCTION
            SQLcmd.Parameters.Add("@TC_CB_CA_DISALLOW", SqlDbType.Decimal).Value = TC_CB_CA_DISALLOW
            SQLcmd.Parameters.Add("@TC_CB_CA_ABAL_CF", SqlDbType.Float).Value = TC_CB_CA_ABAL_CF
            SQLcmd.Parameters.Add("@TC_CB_CHECK", SqlDbType.Decimal).Value = TC_CB_CHECK
            SQLcmd.Parameters.Add("@TC_TP_CLAIM", SqlDbType.Decimal).Value = TC_TP_CLAIM
            SQLcmd.Parameters.Add("@TC_CB_LS_SAMOUNT", SqlDbType.Decimal).Value = TC_CB_LS_SAMOUNT
            SQLcmd.Parameters.Add("@TC_CB_LS_BALS_CF", SqlDbType.Decimal).Value = TC_CB_LS_BALS_CF
            SQLcmd.Parameters.Add("@TC_CB_LS_D_BL", SqlDbType.Decimal).Value = TC_CB_LS_D_BL
            SQLcmd.Parameters.Add("@TC_CB_LS_SRDAMT2", SqlDbType.Decimal).Value = TC_CB_LS_SRDAMT2
            SQLcmd.Parameters.Add("@TC_CB_LS_BLNBF", SqlDbType.Decimal).Value = TC_CB_LS_BLNBF
            SQLcmd.Parameters.Add("@TC_CB_LS_AMTTUT", SqlDbType.Decimal).Value = TC_CB_LS_AMTTUT
            SQLcmd.Parameters.Add("@TC_CB_LS_BLNCF", SqlDbType.Decimal).Value = TC_CB_LS_BLNCF
            SQLcmd.Parameters.Add("@TC_COMPANY", SqlDbType.NVarChar, 8).Value = TC_COMPANY
            SQLcmd.Parameters.Add("@TC_PIONEERDESC", SqlDbType.NVarChar, 255).Value = TC_PIONEERDESC
            SQLcmd.Parameters.Add("@TC_PIO", SqlDbType.NVarChar, 3).Value = TC_PIO
            SQLcmd.Parameters.Add("@TC_PIONEER", SqlDbType.Decimal).Value = TC_PIONEER
            SQLcmd.Parameters.Add("@TC_RA_RATE1", SqlDbType.Decimal).Value = TC_RA_RATE1
            SQLcmd.Parameters.Add("@TC_RA_QUALIFYINGCAPITALEXP", SqlDbType.Decimal).Value = TC_RA_QUALIFYINGCAPITALEXP
            SQLcmd.Parameters.Add("@TC_RA_QUALIFYINGCAPITALEXP_AMOUNT", SqlDbType.Decimal).Value = TC_RA_QUALIFYINGCAPITALEXP_AMOUNT
            SQLcmd.Parameters.Add("@TC_RA_BALANCINGALLOWANCE", SqlDbType.Decimal).Value = TC_RA_BALANCINGALLOWANCE
            SQLcmd.Parameters.Add("@TC_RA_TOTAL1", SqlDbType.Decimal).Value = TC_RA_TOTAL1
            SQLcmd.Parameters.Add("@TC_RA_RESTRICTRATE", SqlDbType.Decimal).Value = TC_RA_RESTRICTRATE
            SQLcmd.Parameters.Add("@TC_RA_RESTRICTAMOUNT", SqlDbType.Decimal).Value = TC_RA_RESTRICTAMOUNT
            SQLcmd.Parameters.Add("@TC_ITA_RATE1", SqlDbType.Decimal).Value = TC_ITA_RATE1
            SQLcmd.Parameters.Add("@TC_ITA_QUALIFYINGCAPITALEXP", SqlDbType.Decimal).Value = TC_ITA_QUALIFYINGCAPITALEXP
            SQLcmd.Parameters.Add("@TC_ITA_QUALIFYINGCAPITALEXP_AMOUNT", SqlDbType.Decimal).Value = TC_ITA_QUALIFYINGCAPITALEXP_AMOUNT
            SQLcmd.Parameters.Add("@TC_ITA_BALANCINGALLOWANCE", SqlDbType.Decimal).Value = TC_ITA_BALANCINGALLOWANCE
            SQLcmd.Parameters.Add("@TC_ITA_TOTAL1", SqlDbType.Decimal).Value = TC_ITA_TOTAL1
            SQLcmd.Parameters.Add("@TC_ITA_RESTRICTRATE", SqlDbType.Decimal).Value = TC_ITA_RESTRICTRATE
            SQLcmd.Parameters.Add("@TC_ITA_RESTRICTAMOUNT", SqlDbType.Decimal).Value = TC_ITA_RESTRICTAMOUNT
            SQLcmd.Parameters.Add("@TC_DISALLOW_NOTE", SqlDbType.NVarChar, 255).Value = TC_DISALLOW_NOTE
            SQLcmd.Parameters.Add("@TC_DISALLOWBUSINESS_NOTE", SqlDbType.NVarChar, 255).Value = TC_DISALLOWBUSINESS_NOTE
            SQLcmd.Parameters.Add("@TC_SURPLUSRECOVERED", SqlDbType.Decimal).Value = TC_SURPLUSRECOVERED
            SQLcmd.Parameters.Add("@TC_MININGALLOWNANCE", SqlDbType.Decimal).Value = TC_MININGALLOWNANCE
            SQLcmd.Parameters.Add("@TC_MININGEXPENSES", SqlDbType.Decimal).Value = TC_MININGEXPENSES
            SQLcmd.Parameters.Add("@TC_STAT_DIVIDEND", SqlDbType.Decimal).Value = TC_STAT_DIVIDEND
            SQLcmd.Parameters.Add("@TC_TP_SEC110B", SqlDbType.Decimal).Value = TC_TP_SEC110B
            SQLcmd.Parameters.Add("@TC_NB_RENT_OTH2", SqlDbType.Decimal).Value = TC_NB_RENT_OTH2
            SQLcmd.Parameters.Add("@TC_NB_CARRYBCKLOSS", SqlDbType.Decimal).Value = TC_NB_CARRYBCKLOSS
            SQLcmd.Parameters.Add("@TC_NB_AMTNOTCARRYBCK", SqlDbType.Decimal).Value = TC_NB_AMTNOTCARRYBCK
            SQLcmd.Parameters.Add("@TC_NB_CHKCB", SqlDbType.Bit).Value = TC_NB_CHKCB
            SQLcmd.Parameters.Add("@TC_TP_INCOME_TP2", SqlDbType.Decimal).Value = TC_TP_INCOME_TP2
            SQLcmd.Parameters.Add("@TC_TP_ESTIMATED_TP", SqlDbType.Decimal).Value = TC_TP_ESTIMATED_TP
            SQLcmd.Parameters.Add("@TC_TP_INCOME_TP3", SqlDbType.Decimal).Value = TC_TP_INCOME_TP3
            SQLcmd.Parameters.Add("@TC_TP_ALL_DIFF", SqlDbType.Decimal).Value = TC_TP_ALL_DIFF
            SQLcmd.Parameters.Add("@TC_TP_EX_DIFF", SqlDbType.Decimal).Value = TC_TP_EX_DIFF
            SQLcmd.Parameters.Add("@TC_TP_PEN_DIFF", SqlDbType.Decimal).Value = TC_TP_PEN_DIFF
            SQLcmd.Parameters.Add("@TC_WITHRAITA", SqlDbType.Decimal).Value = TC_WITHRAITA
            SQLcmd.Parameters.Add("@TC_RA_WITHDRAWAL", SqlDbType.Decimal).Value = TC_RA_WITHDRAWAL
            SQLcmd.Parameters.Add("@TC_RA_ADJUSTMENT", SqlDbType.Decimal).Value = TC_RA_ADJUSTMENT
            SQLcmd.Parameters.Add("@TC_ITA_WITHDRAWAL", SqlDbType.Decimal).Value = TC_ITA_WITHDRAWAL
            SQLcmd.Parameters.Add("@TC_ITA_ADJUSTMENT", SqlDbType.Decimal).Value = TC_ITA_ADJUSTMENT
            SQLcmd.Parameters.Add("@TC_NB_DIV_OTH", SqlDbType.Decimal).Value = TC_NB_DIV_OTH
            SQLcmd.Parameters.Add("@TC_NB_INT_OTH", SqlDbType.Decimal).Value = TC_NB_INT_OTH
            SQLcmd.Parameters.Add("@TC_SUNDRY_EXP", SqlDbType.Decimal).Value = TC_SUNDRY_EXP
            SQLcmd.Parameters.Add("@TC_CHK_EXEMP", SqlDbType.NVarChar, 25).Value = TC_CHK_EXEMP
            SQLcmd.Parameters.Add("@TC_SI_TOT_PARTNERSHIP", SqlDbType.Decimal).Value = TC_SI_TOT_PARTNERSHIP
            SQLcmd.Parameters.Add("@TC_CB_CA_ACA", SqlDbType.Decimal).Value = TC_CB_CA_ACA
            SQLcmd.Parameters.Add("@TC_NB_RENTIBA", SqlDbType.Decimal).Value = TC_NB_RENTIBA
            SQLcmd.Parameters.Add("@TC_NB_RENTIBA_ATT_IN", SqlDbType.Decimal).Value = TC_NB_RENTIBA_ATT_IN
            SQLcmd.Parameters.Add("@TC_NB_RENTIBA_ASSESS", SqlDbType.Decimal).Value = TC_NB_RENTIBA_ASSESS
            SQLcmd.Parameters.Add("@TC_NB_RENTIBA_QUIT", SqlDbType.Decimal).Value = TC_NB_RENTIBA_QUIT
            SQLcmd.Parameters.Add("@TC_NB_RENTIBA_INSUR", SqlDbType.Decimal).Value = TC_NB_RENTIBA_INSUR
            SQLcmd.Parameters.Add("@TC_NB_RENTIBA_OTH", SqlDbType.Decimal).Value = TC_NB_RENTIBA_OTH
            SQLcmd.Parameters.Add("@TC_NB_RENTIBA_MAIN", SqlDbType.Decimal).Value = TC_NB_RENTIBA_MAIN
            SQLcmd.Parameters.Add("@TC_NB_RENTIBA_AGREE", SqlDbType.Decimal).Value = TC_NB_RENTIBA_AGREE
            SQLcmd.Parameters.Add("@TC_NB_RENTIBA_IBA", SqlDbType.Decimal).Value = TC_NB_RENTIBA_IBA
            SQLcmd.Parameters.Add("@TC_NB_DIV_DIS_ATT_INT", SqlDbType.Decimal).Value = TC_NB_DIV_DIS_ATT_INT
            SQLcmd.Parameters.Add("@TC_NB_DIV_TOT_ATT_INT", SqlDbType.Decimal).Value = TC_NB_DIV_TOT_ATT_INT
            SQLcmd.Parameters.Add("@TC_EA_UTL", SqlDbType.Decimal).Value = TC_EA_UTL
            SQLcmd.Parameters.Add("@TC_EA_TYPE", SqlDbType.Decimal).Value = TC_EA_TYPE
            SQLcmd.Parameters.Add("@TC_EA_CURR_COMPANY", SqlDbType.Decimal).Value = TC_EA_CURR_COMPANY
            SQLcmd.Parameters.Add("@TC_EA_CURR_AGRICULTURE", SqlDbType.Decimal).Value = TC_EA_CURR_AGRICULTURE
            SQLcmd.Parameters.Add("@TC_EA_CURR_SIGNIFICANT", SqlDbType.Decimal).Value = TC_EA_CURR_SIGNIFICANT
            SQLcmd.Parameters.Add("@TC_EA_CURR_MARKET", SqlDbType.Decimal).Value = TC_EA_CURR_MARKET
            SQLcmd.Parameters.Add("@TC_EA_CURR_MSB", SqlDbType.Decimal).Value = TC_EA_CURR_MSB
            SQLcmd.Parameters.Add("@TC_EA_TOTAL", SqlDbType.Decimal).Value = TC_EA_TOTAL
            SQLcmd.Parameters.Add("@TC_EA_RESTRICTRATE", SqlDbType.Decimal).Value = TC_EA_RESTRICTRATE
            SQLcmd.Parameters.Add("@TC_EA_BF", SqlDbType.Decimal).Value = TC_EA_BF
            SQLcmd.Parameters.Add("@TC_EA_CF", SqlDbType.Decimal).Value = TC_EA_CF
            SQLcmd.Parameters.Add("@TC_TP_ESTIMATED_SME", SqlDbType.NVarChar, 2).Value = TC_TP_ESTIMATED_SME
            SQLcmd.Parameters.Add("@TC_NB_DCA_INT", SqlDbType.Decimal).Value = TC_NB_DCA_INT
            SQLcmd.Parameters.Add("@TC_NB_DEEMED_INT", SqlDbType.Decimal).Value = TC_NB_DEEMED_INT
            SQLcmd.Parameters.Add("@TC_EXEMPTIONCAL", SqlDbType.Decimal).Value = TC_EXEMPTIONCAL
            SQLcmd.Parameters.Add("@TC_EXEMPTIONLESS", SqlDbType.Decimal).Value = TC_EXEMPTIONLESS
            SQLcmd.Parameters.Add("@TC_TP_INSTALL_107C", SqlDbType.Decimal).Value = TC_TP_INSTALL_107C
            SQLcmd.Parameters.Add("@TC_TP_INSTALL_107A", SqlDbType.Decimal).Value = TC_TP_INSTALL_107A
            SQLcmd.Parameters.Add("@TC_TP_RATE7", SqlDbType.Int).Value = TC_TP_RATE7
            SQLcmd.Parameters.Add("@TC_TP_APP_CHARGEABLE7", SqlDbType.Decimal).Value = TC_TP_APP_CHARGEABLE7
            SQLcmd.Parameters.Add("@TC_TP_RATE6_CHARGEABLE", SqlDbType.Decimal).Value = TC_TP_RATE6_CHARGEABLE
            SQLcmd.Parameters.Add("@TC_TP_RATE7_CHARGEABLE", SqlDbType.Decimal).Value = TC_TP_RATE7_CHARGEABLE
            SQLcmd.Parameters.Add("@TC_EA_TYPE1", SqlDbType.Decimal).Value = TC_EA_TYPE1
            SQLcmd.Parameters.Add("@TC_EA_TYPE2", SqlDbType.Decimal).Value = TC_EA_TYPE2
            SQLcmd.Parameters.Add("@TC_EA_TYPE3", SqlDbType.Decimal).Value = TC_EA_TYPE3


            ListOfSQLCmd.Add(SQLcmd)
            Return True

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function Load_Taxcomputation(Optional SourceNo_ As Integer = -1) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM TAX_COMPUTATION WHERE TC_REF_NO=@TC_REF_NO AND TC_YA=@TC_YA"

            If SourceNo_ <> -1 Then
                StrSQL += " AND TC_BUSINESS=@TC_BUSINESS"
            End If
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@TC_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@TC_YA", SqlDbType.NVarChar, 5).Value = YA
            If SourceNo_ <> -1 Then
                SQLcmd.Parameters.Add("@TC_BUSINESS", SqlDbType.Int).Value = SourceNo
            End If

            Return Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_Total_StatutoryIncome() As Decimal
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT SUM(TC_SI_NET_STAT_IN) FROM TAX_COMPUTATION WHERE TC_REF_NO=@TC_REF_NO AND TC_YA=@TC_YA"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@TC_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@TC_YA", SqlDbType.NVarChar, 5).Value = YA

            Dim dt As DataTable = Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("")) = False AndAlso IsNumeric(dt.Rows(0)("")) Then

            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Private Function GetLastTC_KEY() As Integer
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT TOP 1 TC_KEY FROM TAX_COMPUTATION ORDER BY TC_KEY DESC"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

            Dim dt As DataTable = Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("TC_KEY")) = False AndAlso IsNumeric(dt.Rows(0)("TC_KEY")) Then
                Return CInt(dt.Rows(0)("TC_KEY"))
            Else
                Return -1
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
#End Region
#Region "DELETE"
    Private Function DELETE_NON_ALLOW_LOSS(ByRef ListOfSQLCmd As List(Of SqlCommand)) As Boolean
        Try
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = ""
            StrSQL = "DELETE FROM NON_ALLOW_LOSS WHERE NL_REF_NO=@RefNo AND NL_YA=@YA AND NL_SOURCENO=@SourceNo"
            SQLcmd = New SqlCommand With {.CommandText = StrSQL}
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@SourceNo", SqlDbType.Int).Value = SourceNo
            ListOfSQLCmd.Add(SQLcmd)
            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Private Function DELETE_SURPLUS_RECOVERED(ByRef ListOfSQLCmd As List(Of SqlCommand)) As Boolean
        Try
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = ""
            StrSQL = "DELETE FROM SURPLUS_RECOVERED WHERE SR_REF_NO=@RefNo AND SR_YA=@YA AND SR_SOURCENO=@SourceNo"
            SQLcmd = New SqlCommand With {.CommandText = StrSQL}
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@SourceNo", SqlDbType.Int).Value = SourceNo
            ListOfSQLCmd.Add(SQLcmd)
            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Private Function DELETE_TAXABLE_INCOME(ByRef ListOfSQLCmd As List(Of SqlCommand)) As Boolean
        Try
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = ""
            StrSQL = "DELETE FROM TAXABLE_INCOME WHERE TI_REF_NO=@RefNo AND TI_YA=@YA AND TI_SOURCENO=@SourceNo"
            SQLcmd = New SqlCommand With {.CommandText = StrSQL}
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@SourceNo", SqlDbType.Int).Value = SourceNo
            ListOfSQLCmd.Add(SQLcmd)
            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Private Function DELETE_MINING_ALLOWNANCE(ByRef ListOfSQLCmd As List(Of SqlCommand)) As Boolean
        Try
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = ""
            StrSQL = "DELETE FROM MINING_ALLOWNANCE WHERE MA_REF_NO=@RefNo AND MA_YA=@YA AND MA_SOURCENO=@SourceNo"
            SQLcmd = New SqlCommand With {.CommandText = StrSQL}
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@SourceNo", SqlDbType.Int).Value = SourceNo
            ListOfSQLCmd.Add(SQLcmd)
            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Private Function DELETE_MINING_EXPENSES(ByRef ListOfSQLCmd As List(Of SqlCommand)) As Boolean
        Try
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = ""
            StrSQL = "DELETE FROM MINING_EXPENSES WHERE ME_REF_NO=@RefNo AND ME_YA=@YA AND ME_SOURCENO=@SourceNo"
            SQLcmd = New SqlCommand With {.CommandText = StrSQL}
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@SourceNo", SqlDbType.Int).Value = SourceNo
            ListOfSQLCmd.Add(SQLcmd)
            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Private Function DELETE_OTHER_DEDUCTION(ByRef ListOfSQLCmd As List(Of SqlCommand)) As Boolean
        Try
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = ""
            StrSQL = "DELETE FROM OTHER_DEDUCTION WHERE OD_REF_NO=@RefNo AND OD_YA=@YA AND OD_SOURCENO=@SourceNo"
            SQLcmd = New SqlCommand With {.CommandText = StrSQL}
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@SourceNo", SqlDbType.Int).Value = SourceNo
            ListOfSQLCmd.Add(SQLcmd)
            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Private Function DELETE_REVENUE_EXPENDITURE(ByRef ListOfSQLCmd As List(Of SqlCommand)) As Boolean
        Try
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = ""
            StrSQL = "DELETE FROM REVENUE_EXPENDITURE WHERE RE_REF_NO=@RefNo AND RE_YA=@YA AND RE_SOURCENO=@SourceNo"
            SQLcmd = New SqlCommand With {.CommandText = StrSQL}
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@SourceNo", SqlDbType.Int).Value = SourceNo
            ListOfSQLCmd.Add(SQLcmd)
            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Private Function DELETE_OTHER_EXPENDITURE(ByRef ListOfSQLCmd As List(Of SqlCommand)) As Boolean
        Try
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = ""
            StrSQL = "DELETE FROM OTHER_EXPENDITURE WHERE OE_REF_NO=@RefNo AND OE_YA=@YA AND OE_SOURCENO=@SourceNo"
            SQLcmd = New SqlCommand With {.CommandText = StrSQL}
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@SourceNo", SqlDbType.Int).Value = SourceNo

            ListOfSQLCmd.Add(SQLcmd)
            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
#End Region
End Class

