Imports DevExpress.XtraBars.Docking
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository

Module mdlPNL

    Public P1_docSales As DockPanel
    Public P1_docOpeningStock As DockPanel
    Public P1_docPurchase As DockPanel
    Public P1_docDepreciation As DockPanel
    Public P1_docAllowanceExpenses As DockPanel
    Public P1_docNonAllowableExpenses As DockPanel
    Public P1_docCloseStock As DockPanel

    Public P2_docOtherBizIncome As DockPanel
    Public P2_docForeignCurrExGain As DockPanel
    Public P2_docInterestIncome As DockPanel
    Public P2_docRentalIncome As DockPanel
    Public P2_docRoyaltyIncome As DockPanel
    Public P2_docOtherIncome As DockPanel
    Public P2_docProDispPlantEq As DockPanel
    Public P2_docProDisInvestment As DockPanel
    Public P2_docForeIncomeRemmit As DockPanel
    Public P2_docReaForeExGainNonTrade As DockPanel
    Public P2_docUnreaGainForeEx As DockPanel
    Public P2_docUnreaGainForeExNon As DockPanel
    Public P2_docOther As DockPanel
    Public P2_docExemptDividend As DockPanel
    Public P2_docDivIncome As DockPanel

    Public P3_docInterestResPurS33 As DockPanel
    Public P3_docOtherInterestExHirePur As DockPanel
    Public P3_docProTechManLeganFees As DockPanel
    Public P3_docTechPayNonResis As DockPanel
    Public P3_docContractPay As DockPanel
    Public P3_docDirectorFee As DockPanel
    Public P3_docSalary As DockPanel
    Public P3_docCOEStock As DockPanel
    Public P3_docRoyalty As DockPanel
    Public P3_docRental As DockPanel
    Public P3_docRepairMain As DockPanel
    Public P3_docResearchDev As DockPanel
    Public P3_docPromotionAds As DockPanel
    Public P3_docTravelling As DockPanel
    Public P3_docJKDM As DockPanel
    Public P3_docDepreciation As DockPanel
    Public P3_docDonationApp As DockPanel
    Public P3_docDonationNonApp As DockPanel
    Public p3_docZakat As DockPanel

    Public p4_docLossDispFA As DockPanel
    Public p4_docEntNonStaff As DockPanel
    Public p4_docEntStaff As DockPanel
    Public p4_docCompound As DockPanel
    Public p4_docProvisionAcc As DockPanel
    Public p4_docLeavePass As DockPanel
    Public p4_docFAWrittenOff As DockPanel
    Public p4_docUnreaLossForeEx As DockPanel
    Public p4_docReaLossForeExTrade As DockPanel
    Public p4_docReaLossForeExNonTrade As DockPanel
    Public p4_docInitSub As DockPanel
    Public p4_docCAExpenditure As DockPanel
    Public p4_docOther As DockPanel
    Public p4_docNonAllowableExpenses As DockPanel

    Public dsDataSet As DataSet
    Public dsDataSet2 As DataSet

    Public Function GetPNLLabelName(Optional ByRef Errorlog As clsError = Nothing) As List(Of clsPNL_LabelName)
        Try
            Dim ListofLabel As New List(Of clsPNL_LabelName)

            'Page 1
            ListofLabel.Add(New clsPNL_LabelName("lbl_p1Sales", "Sales/Turnover", "Sale / turnover", TaxComPNLEnuItem.SALES))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p1OpenStock", "Opening Stock", "Opening stock", TaxComPNLEnuItem.OPENSTOCK))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p1Purchase", "Purchases", "Purchases", TaxComPNLEnuItem.PURCHASE))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p1Depreciation", "Depreciation", "Depreciation", TaxComPNLEnuItem.DEPRECIATION))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p1AllowanceExpenses", "Other Allowable Expenses", "Allowable expenses", TaxComPNLEnuItem.OTHERALLOWEXP))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p1NonAllowableExpenses", "Other Non Allowable Expenses", "", TaxComPNLEnuItem.OTHERNONALLOWEXP))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p1CloseStock", "Closing Stock", "Closing stock", TaxComPNLEnuItem.CLOSESTOCK))

            'Page 2
            ListofLabel.Add(New clsPNL_LabelName("lbl_p2OtherBizIncome", "Other Business Income", "Other business income", TaxComPNLEnuItem.OTHERBUSINC))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p2ForeignCurrExGain", "Realised Foreign Exchange Gain - Trade", "Foreign currency exchange gain", TaxComPNLEnuItem.REALFETRADE))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p2DivIncome", "Dividend Income", "Dividend income", TaxComPNLEnuItem.DIVIDENDINC))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p2InterestIncome", "Interest Income", "Interest income", TaxComPNLEnuItem.INTERESTINC))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p2RentalIncome", "Rental Income", "Rental income", TaxComPNLEnuItem.RENTALINC))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p2RoyaltyIncome", "Royalty Income", "Royalty income", TaxComPNLEnuItem.ROYALTYINC))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p2OtherIncome", "Other Income", "Other income", TaxComPNLEnuItem.OTHERINC))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p2ProDispPlantEq", "Profit on Disposal of Fixed Assets", "Profit on disposal of property, plant and equipment", TaxComPNLEnuItem.PDFIXASSET))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p2ProDisInvestment", "Profit on Disposal of Investment", "Profit on disposal of investment", TaxComPNLEnuItem.PDINVEST))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p2ExemptDividend", "Exempt Dividend", "Exempt dividend", TaxComPNLEnuItem.EXEMDIV))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p2ForeIncomeRemmit", "Foreign Income Remittance", "Foreign income remittance", TaxComPNLEnuItem.FORINCREMIT))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p2ReaForeExGainNonTrade", "Realised Foreign Exchange Gain Arising from Capital Transaction", "", TaxComPNLEnuItem.REALFE))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p2UnreaGainForeEx", "Unrealised Gain on Foreign Exchange - Trade", "Realised foreign exchange gain - non trade", TaxComPNLEnuItem.UNREALFETRADE))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p2UnreaGainForeExNon", "Unrealised Gain on Foregin Exchange - Non-Trade", "Unrealised gain on foreign exchange", TaxComPNLEnuItem.UNREALFENONTRADE))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p2Other", "Other", "Other", TaxComPNLEnuItem.OTHERNONTAXINC))


            'Page 3
            ListofLabel.Add(New clsPNL_LabelName("lbl_p3InterestResPurS33", "Interest restricted pursuant to S33 (2)", "Interest expense restricted under subsection 33(2)", TaxComPNLEnuItem.INTERESTRESTRICT))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p3OtherInterestExHirePur", "Other Interest (excluding hire purchase interest)", "Interest", TaxComPNLEnuItem.EXPOTHERINTEREST))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p3ProTechManLeganFees", "Professional, Technical, Management & Legal Fees", "Professional, technical, management and legal fees", TaxComPNLEnuItem.EXPLEGAL))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p3TechPayNonResis", "Technical fee payments to non-resident recipients", "Technical fee payments to non - resident recipients", TaxComPNLEnuItem.EXPTECHNICAL))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p3ContractPay", "Contract Payments", "Contract payments", TaxComPNLEnuItem.EXPCONTRACTPAY))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p3DirectorFee", "Directors' Fee", "Directors' fee", TaxComPNLEnuItem.EXPDIRECTORFEE))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p3Salary", "Salary", "Salaries and wages", TaxComPNLEnuItem.EXPSALARY))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p3COEStock", "Cost of Employee Stock Options", "Cost of employee stock options", TaxComPNLEnuItem.EXPEMPLOYEESTOCK))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p3Royalty", "Royalty", "Royalties", TaxComPNLEnuItem.EXPROYALTY))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p3Rental", "Rental", "Rental / lease", TaxComPNLEnuItem.EXPRENTAL))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p3RepairMain", "Repair & Maintenance", "Maintenance and repairs", TaxComPNLEnuItem.EXPREPAIRMAINTENANCE))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p3ResearchDev", "Research & Development", "Research and development", TaxComPNLEnuItem.EXPRND))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p3PromotionAds", "Promotion & Advertisement", "Promotion and advertisement", TaxComPNLEnuItem.EXPADVERTISEMENT))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p3Travelling", "Travelling & Accommodation", "Travelling and accommodation", TaxComPNLEnuItem.EXPTRAVEL))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p3ForeignCurrExLoss", "", "Foreign currency exchange loss", TaxComPNLEnuItem.EXPUNREALLOSSFE))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p3JKDM", "Input Tax Not Claimable from JKDM", "Input tax not claimable from RMCD", TaxComPNLEnuItem.EXPJKDM))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p3Depreciation", "Depreciation", "Depreciation of property, plant and equipment", TaxComPNLEnuItem.EXPDEPRECIATION))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p3DonationApp", "Donation Approved", "Approved donations and contributions", TaxComPNLEnuItem.EXPDONATIONAPPR))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p3DonationNonApp", "Donation Non Approved", "Unapproved donations and contributions", TaxComPNLEnuItem.EXPDONATIONNONAPPR))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p3Zakat", "Zakat", "Zakat", TaxComPNLEnuItem.EXPZAKAT))

            'Page 4
            ListofLabel.Add(New clsPNL_LabelName("lbl_p4LossDispFA", "Loss on Disposal of Fixed Assets", "Loss on disposal of property, plant and equipment", TaxComPNLEnuItem.EXPLOSSDISPFA))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p4EntNonStaff", "Entertainment Non Staff", "Entertainment - others", TaxComPNLEnuItem.EXPENTERTAINNONSTAFF))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p4EntStaff", "Entertainment  Staff", "Entertainment - staff", TaxComPNLEnuItem.EXPENTERTAINSTAFF))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p4Compound", "Compound / Penalty", "Compound / penalty", TaxComPNLEnuItem.EXPCOMPAUNDPENALTY))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p4ProvisionAcc", "Provision Account", "Provision account", TaxComPNLEnuItem.EXPPROVISION))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p4LeavePass", "Leave Passage", "Leave passage", TaxComPNLEnuItem.EXPLEAVEPASSAGE))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p4FAWrittenOff", "Fixed Asset Written Off", "Property, plant and equipment written - off", TaxComPNLEnuItem.EXPFAWRITTENOFF))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p4UnreaLossForeEx", "Unrealised Loss on Foreign Exchange", "", TaxComPNLEnuItem.EXPUNREALLOSSFE))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p4ReaLossForeExTrade", "Realised Loss on Foreign Exchange - Trade", "", TaxComPNLEnuItem.EXPREALLOSSFETRADE))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p4ReaLossForeExNonTrade", "Realised Loss on Foreign Exchange - Non-Trade", "", TaxComPNLEnuItem.EXPREALLOSSFENONTRADE))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p4InitSub", "Initial Subscription", "Subscription", TaxComPNLEnuItem.EXPINITIALSUBSCRIPT))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p4CAExpenditure", "Capital Expenditure", "Capital expenditure", TaxComPNLEnuItem.EXPCAPITALEXPENDITURE))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p4Other", "Others", "Others", TaxComPNLEnuItem.EXPOTHERSEXPENSES))



            Return ListofLabel
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return Nothing
        End Try
    End Function

    Public Function DestroyPNL(ByVal Type As String, ByRef DockingManager As DockManager, _
                            ByRef DockDocument As DevExpress.XtraBars.Docking2010.DocumentManager, Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            DockDocument.BeginUpdate()

            Dim val As mdlEnum.TaxComPNLEnuItem = DirectCast([Enum].Parse(GetType(mdlEnum.TaxComPNLEnuItem), Type.ToUpper), mdlEnum.TaxComPNLEnuItem)

            Select Case val
                Case TaxComPNLEnuItem.SALES
                    P1_docSales.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P1_docSales)
                Case TaxComPNLEnuItem.OPENSTOCK
                    P1_docOpeningStock.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P1_docOpeningStock)
                Case TaxComPNLEnuItem.PURCHASE
                    P1_docPurchase.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P1_docPurchase)
                Case TaxComPNLEnuItem.DEPRECIATION
                    P1_docDepreciation.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P1_docDepreciation)
                Case TaxComPNLEnuItem.OTHERALLOWEXP
                    P1_docAllowanceExpenses.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P1_docAllowanceExpenses)
                Case TaxComPNLEnuItem.OTHERNONALLOWEXP
                    P1_docNonAllowableExpenses.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P1_docNonAllowableExpenses)
                Case TaxComPNLEnuItem.CLOSESTOCK
                    P1_docCloseStock.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P1_docCloseStock)
                Case TaxComPNLEnuItem.OTHERBUSINC
                    P2_docOtherBizIncome.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P2_docOtherBizIncome)
                Case TaxComPNLEnuItem.REALFETRADE
                    P2_docForeignCurrExGain.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P2_docForeignCurrExGain)
                Case TaxComPNLEnuItem.INTERESTINC
                    P2_docInterestIncome.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P2_docInterestIncome)
                Case TaxComPNLEnuItem.ROYALTYINC
                    P2_docRoyaltyIncome.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P2_docRoyaltyIncome)
                Case TaxComPNLEnuItem.OTHERINC
                    P2_docOtherIncome.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P2_docOtherIncome)
                Case TaxComPNLEnuItem.PDFIXASSET
                    P2_docProDispPlantEq.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P2_docProDispPlantEq)
                Case TaxComPNLEnuItem.PDINVEST
                    P2_docProDisInvestment.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P2_docProDisInvestment)
                Case TaxComPNLEnuItem.FORINCREMIT
                    P2_docForeIncomeRemmit.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P2_docForeIncomeRemmit)
                Case TaxComPNLEnuItem.REALFE
                    P2_docReaForeExGainNonTrade.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P2_docReaForeExGainNonTrade)
                Case TaxComPNLEnuItem.UNREALFETRADE
                    P2_docUnreaGainForeEx.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P2_docUnreaGainForeEx)
                Case TaxComPNLEnuItem.UNREALFENONTRADE
                    P2_docUnreaGainForeExNon.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P2_docUnreaGainForeExNon)
                Case TaxComPNLEnuItem.EXPOTHERINTEREST
                    P3_docOtherInterestExHirePur.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P3_docOtherInterestExHirePur)
                Case TaxComPNLEnuItem.EXPLEGAL
                    P3_docProTechManLeganFees.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P3_docProTechManLeganFees)
                Case TaxComPNLEnuItem.EXPTECHNICAL
                    P3_docTechPayNonResis.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P3_docTechPayNonResis)
                Case TaxComPNLEnuItem.EXPCONTRACTPAY
                    P3_docContractPay.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P3_docContractPay)
                Case TaxComPNLEnuItem.EXPDIRECTORFEE
                    P3_docDirectorFee.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P3_docDirectorFee)
                Case TaxComPNLEnuItem.EXPSALARY
                    P3_docSalary.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P3_docSalary)
                Case TaxComPNLEnuItem.EXPEMPLOYEESTOCK
                    P3_docCOEStock.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P3_docCOEStock)
                Case TaxComPNLEnuItem.EXPROYALTY
                    P3_docRoyalty.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P3_docRoyalty)
                Case TaxComPNLEnuItem.EXPRENTAL
                    P3_docRental.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P3_docRental)
                Case TaxComPNLEnuItem.EXPREPAIRMAINTENANCE
                    P3_docRepairMain.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P3_docRepairMain)
                Case TaxComPNLEnuItem.EXPRND
                    P3_docResearchDev.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P3_docResearchDev)
                Case TaxComPNLEnuItem.EXPADVERTISEMENT
                    P3_docPromotionAds.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P3_docPromotionAds)
                Case TaxComPNLEnuItem.EXPTRAVEL
                    P3_docTravelling.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P3_docTravelling)
                Case TaxComPNLEnuItem.EXPJKDM
                    P3_docJKDM.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P3_docJKDM)
                Case TaxComPNLEnuItem.EXPDEPRECIATION
                    P3_docDepreciation.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P3_docDepreciation)
                Case TaxComPNLEnuItem.EXPDONATIONAPPR
                    P3_docDonationApp.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P3_docDonationApp)
                Case TaxComPNLEnuItem.EXPDONATIONNONAPPR
                    P3_docDonationNonApp.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P3_docDonationNonApp)
                Case TaxComPNLEnuItem.EXPZAKAT
                    p3_docZakat.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(p3_docZakat)
                Case TaxComPNLEnuItem.EXPLOSSDISPFA
                    p4_docLossDispFA.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(p4_docLossDispFA)
                Case TaxComPNLEnuItem.EXPENTERTAINNONSTAFF
                    p4_docEntNonStaff.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(p4_docEntNonStaff)
                Case TaxComPNLEnuItem.EXPENTERTAINSTAFF
                    p4_docEntStaff.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(p4_docEntStaff)
                Case TaxComPNLEnuItem.EXPCOMPAUNDPENALTY
                    p4_docCompound.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(p4_docCompound)
                Case TaxComPNLEnuItem.EXPPROVISION
                    p4_docProvisionAcc.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(p4_docProvisionAcc)
                Case TaxComPNLEnuItem.EXPLEAVEPASSAGE
                    p4_docLeavePass.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(p4_docLeavePass)
                Case TaxComPNLEnuItem.EXPFAWRITTENOFF
                    p4_docFAWrittenOff.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(p4_docFAWrittenOff)
                Case TaxComPNLEnuItem.EXPUNREALLOSSFE
                    p4_docUnreaLossForeEx.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(p4_docUnreaLossForeEx)
                Case TaxComPNLEnuItem.EXPREALLOSSFETRADE
                    p4_docReaLossForeExTrade.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(p4_docReaLossForeExTrade)
                Case TaxComPNLEnuItem.EXPREALLOSSFENONTRADE
                    p4_docReaLossForeExNonTrade.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(p4_docReaLossForeExNonTrade)
                Case TaxComPNLEnuItem.EXPINITIALSUBSCRIPT
                    p4_docInitSub.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(p4_docInitSub)
                Case TaxComPNLEnuItem.EXPCAPITALEXPENDITURE
                    p4_docCAExpenditure.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(p4_docCAExpenditure)
                Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
                    p4_docOther.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(p4_docOther)
                Case TaxComPNLEnuItem.RENTALINC
                    P2_docRentalIncome.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P2_docRentalIncome)
                Case TaxComPNLEnuItem.NONALLOWABLEEXPENSES
                    p4_docNonAllowableExpenses.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(p4_docNonAllowableExpenses)
                Case TaxComPNLEnuItem.OTHERNONTAXINC
                    P2_docOther.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P2_docOther)
                Case TaxComPNLEnuItem.EXEMDIV
                    P2_docExemptDividend.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P2_docExemptDividend)
                Case TaxComPNLEnuItem.INTERESTRESTRICT
                    P3_docInterestResPurS33.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P3_docInterestResPurS33)
                Case TaxComPNLEnuItem.DIVIDENDINC
                    P2_docDivIncome.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(P2_docDivIncome)
            End Select
            Return False
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return False
        Finally
            DockDocument.EndUpdate()
        End Try
    End Function
    Public Function ViewPNL(ByVal Type As mdlEnum.TaxComPNLEnuItem, ByRef DockingManager As DockManager, _
                            ByRef DockDocument As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal lbl As DevExpress.XtraEditors.LabelControl, _
                            ByVal txtAmount As DevExpress.XtraEditors.TextEdit, _
                            ByVal tabView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView, _
                            ByVal RefNo As String, ByVal YA As String,
                            Optional ByRef Errorlog As clsError = Nothing, Optional ByRef txtSales As DevExpress.XtraEditors.TextEdit = Nothing, Optional ByRef SourceNo As Integer = 0) As Boolean
        Try
            DockDocument.BeginUpdate()
            Select Case Type
                Case TaxComPNLEnuItem.SALES
                    Dim doc As DevExpress.XtraBars.Docking2010.Views.BaseDocument
                    If P1_docSales Is Nothing OrElse P1_docSales.IsDisposed Then
                        P1_docSales = New DockPanel
                        Dim uc As New ucPNL_p1Sales

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P1_docSales.Text = lbl.Text
                        P1_docSales.Name = TaxComPNLEnuItem.SALES.ToString
                        P1_docSales.Controls.Add(uc)
                        P1_docSales.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(P1_docSales)
                    Else
                        P1_docSales.Visibility = DockVisibility.Visible
                        If DockDocument.View.AddFloatingDocumentsHost(P1_docSales) Then

                        Else

                        End If
                        doc = DockDocument.View.AddDocument(P1_docSales)
                    End If

                    DockDocument.View.ActivateDocument(P1_docSales)

                Case TaxComPNLEnuItem.OPENSTOCK
                    If P1_docOpeningStock Is Nothing OrElse P1_docOpeningStock.IsDisposed Then
                        P1_docOpeningStock = New DockPanel
                        Dim uc As New ucPNL_p1OpeningStock

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P1_docOpeningStock.Text = lbl.Text
                        P1_docOpeningStock.Name = TaxComPNLEnuItem.OPENSTOCK.ToString
                        P1_docOpeningStock.Controls.Add(uc)
                        P1_docOpeningStock.DockedAsTabbedDocument = True
                        P1_docOpeningStock.Register(DockingManager)

                        DockDocument.View.AddDocument(P1_docOpeningStock)
                    Else
                        P1_docOpeningStock.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P1_docOpeningStock)
                    End If
                    DockDocument.View.ActivateDocument(P1_docOpeningStock)

                Case TaxComPNLEnuItem.PURCHASE
                    If P1_docPurchase Is Nothing OrElse P1_docPurchase.IsDisposed Then
                        P1_docPurchase = New DockPanel
                        Dim uc As New ucPNL_p1Purchase

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P1_docPurchase.Text = lbl.Text
                        P1_docPurchase.Name = TaxComPNLEnuItem.PURCHASE.ToString
                        P1_docPurchase.Controls.Add(uc)
                        P1_docPurchase.DockedAsTabbedDocument = True
                        P1_docPurchase.Register(DockingManager)

                        DockDocument.View.AddDocument(P1_docPurchase)
                    Else
                        P1_docPurchase.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P1_docPurchase)
                    End If
                    DockDocument.View.ActivateDocument(P1_docPurchase)

                Case TaxComPNLEnuItem.DEPRECIATION
                    If P1_docDepreciation Is Nothing OrElse P1_docDepreciation.IsDisposed Then
                        P1_docDepreciation = New DockPanel
                        Dim uc As New ucPNL_p1Depreciation

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P1_docDepreciation.Text = lbl.Text
                        P1_docDepreciation.Name = TaxComPNLEnuItem.DEPRECIATION.ToString
                        P1_docDepreciation.Controls.Add(uc)
                        P1_docDepreciation.DockedAsTabbedDocument = True
                        P1_docDepreciation.Register(DockingManager)

                        DockDocument.View.AddDocument(P1_docDepreciation)
                    Else
                        P1_docDepreciation.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P1_docDepreciation)
                    End If
                    DockDocument.View.ActivateDocument(P1_docDepreciation)
                Case TaxComPNLEnuItem.OTHERALLOWEXP
                    If P1_docAllowanceExpenses Is Nothing OrElse P1_docAllowanceExpenses.IsDisposed Then
                        P1_docAllowanceExpenses = New DockPanel
                        Dim uc As New ucPNL_p1AllowanceExpenses

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P1_docAllowanceExpenses.Text = lbl.Text
                        P1_docAllowanceExpenses.Name = TaxComPNLEnuItem.OTHERALLOWEXP.ToString
                        P1_docAllowanceExpenses.Controls.Add(uc)
                        P1_docAllowanceExpenses.DockedAsTabbedDocument = True
                        P1_docAllowanceExpenses.Register(DockingManager)

                        DockDocument.View.AddDocument(P1_docAllowanceExpenses)
                    Else
                        P1_docAllowanceExpenses.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P1_docAllowanceExpenses)
                    End If
                    DockDocument.View.ActivateDocument(P1_docAllowanceExpenses)
                Case TaxComPNLEnuItem.OTHERNONALLOWEXP
                    If P1_docNonAllowableExpenses Is Nothing OrElse P1_docNonAllowableExpenses.IsDisposed Then
                        P1_docNonAllowableExpenses = New DockPanel
                        Dim uc As New ucPNL_p1NonAllowableExpenses

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P1_docNonAllowableExpenses.Text = lbl.Text
                        P1_docNonAllowableExpenses.Name = TaxComPNLEnuItem.OTHERNONALLOWEXP.ToString
                        P1_docNonAllowableExpenses.Controls.Add(uc)
                        P1_docNonAllowableExpenses.DockedAsTabbedDocument = True
                        P1_docNonAllowableExpenses.Register(DockingManager)

                        DockDocument.View.AddDocument(P1_docNonAllowableExpenses)
                    Else
                        P1_docNonAllowableExpenses.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P1_docNonAllowableExpenses)
                    End If
                    DockDocument.View.ActivateDocument(P1_docNonAllowableExpenses)
                Case TaxComPNLEnuItem.CLOSESTOCK
                    If P1_docCloseStock Is Nothing OrElse P1_docCloseStock.IsDisposed Then
                        P1_docCloseStock = New DockPanel
                        Dim uc As New ucPNL_p1CloseStock

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P1_docCloseStock.Text = lbl.Text
                        P1_docCloseStock.Name = TaxComPNLEnuItem.CLOSESTOCK.ToString
                        P1_docCloseStock.Controls.Add(uc)
                        P1_docCloseStock.DockedAsTabbedDocument = True
                        P1_docCloseStock.Register(DockingManager)

                        DockDocument.View.AddDocument(P1_docCloseStock)
                    Else
                        P1_docCloseStock.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P1_docCloseStock)
                    End If
                    DockDocument.View.ActivateDocument(P1_docCloseStock)
                Case TaxComPNLEnuItem.OTHERBUSINC
                    If P2_docOtherBizIncome Is Nothing OrElse P2_docOtherBizIncome.IsDisposed Then
                        P2_docOtherBizIncome = New DockPanel
                        Dim uc As New ucPNL_p2OtherBizIncome

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P2_docOtherBizIncome.Text = lbl.Text
                        P2_docOtherBizIncome.Name = TaxComPNLEnuItem.OTHERBUSINC.ToString
                        P2_docOtherBizIncome.Controls.Add(uc)
                        P2_docOtherBizIncome.DockedAsTabbedDocument = True
                        P2_docOtherBizIncome.Register(DockingManager)

                        DockDocument.View.AddDocument(P2_docOtherBizIncome)
                    Else
                        P2_docOtherBizIncome.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P2_docOtherBizIncome)
                    End If
                    DockDocument.View.ActivateDocument(P2_docOtherBizIncome)
                Case TaxComPNLEnuItem.REALFETRADE
                    If P2_docForeignCurrExGain Is Nothing OrElse P2_docForeignCurrExGain.IsDisposed Then
                        P2_docForeignCurrExGain = New DockPanel
                        Dim uc As New ucPNL_p2ForeignCurrExGain

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P2_docForeignCurrExGain.Text = lbl.Text
                        P2_docForeignCurrExGain.Name = TaxComPNLEnuItem.REALFETRADE.ToString
                        P2_docForeignCurrExGain.Controls.Add(uc)
                        P2_docForeignCurrExGain.DockedAsTabbedDocument = True
                        P2_docForeignCurrExGain.Register(DockingManager)

                        DockDocument.View.AddDocument(P2_docForeignCurrExGain)
                    Else
                        P2_docForeignCurrExGain.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P2_docForeignCurrExGain)
                    End If
                    DockDocument.View.ActivateDocument(P2_docForeignCurrExGain)
                Case TaxComPNLEnuItem.INTERESTINC
                    If P2_docInterestIncome Is Nothing OrElse P2_docInterestIncome.IsDisposed Then
                        P2_docInterestIncome = New DockPanel
                        Dim uc As New ucPNL_p2InterestIncome

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P2_docInterestIncome.Text = lbl.Text
                        P2_docInterestIncome.Name = TaxComPNLEnuItem.INTERESTINC.ToString
                        P2_docInterestIncome.Controls.Add(uc)
                        P2_docInterestIncome.DockedAsTabbedDocument = True
                        P2_docInterestIncome.Register(DockingManager)


                        DockDocument.View.AddDocument(P2_docInterestIncome)
                    Else
                        P2_docInterestIncome.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P2_docInterestIncome)
                    End If
                    DockDocument.View.ActivateDocument(P2_docInterestIncome)
                Case TaxComPNLEnuItem.ROYALTYINC
                    If P2_docRoyaltyIncome Is Nothing OrElse P2_docRoyaltyIncome.IsDisposed Then
                        P2_docRoyaltyIncome = New DockPanel
                        Dim uc As New ucPNL_p2RoyaltyIncome

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P2_docRoyaltyIncome.Text = lbl.Text
                        P2_docRoyaltyIncome.Name = TaxComPNLEnuItem.ROYALTYINC.ToString
                        P2_docRoyaltyIncome.Controls.Add(uc)
                        P2_docRoyaltyIncome.DockedAsTabbedDocument = True
                        P2_docRoyaltyIncome.Register(DockingManager)


                        DockDocument.View.AddDocument(P2_docRoyaltyIncome)
                    Else
                        P2_docRoyaltyIncome.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P2_docRoyaltyIncome)
                    End If
                    DockDocument.View.ActivateDocument(P2_docRoyaltyIncome)
                Case TaxComPNLEnuItem.OTHERINC
                    If P2_docOtherIncome Is Nothing OrElse P2_docOtherIncome.IsDisposed Then
                        P2_docOtherIncome = New DockPanel
                        Dim uc As New ucPNL_p2OtherIncome

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P2_docOtherIncome.Text = lbl.Text
                        P2_docOtherIncome.Name = TaxComPNLEnuItem.OTHERINC.ToString
                        P2_docOtherIncome.Controls.Add(uc)
                        P2_docOtherIncome.DockedAsTabbedDocument = True
                        P2_docOtherIncome.Register(DockingManager)


                        DockDocument.View.AddDocument(P2_docOtherIncome)
                    Else
                        P2_docOtherIncome.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P2_docOtherIncome)
                    End If
                    DockDocument.View.ActivateDocument(P2_docOtherIncome)
                Case TaxComPNLEnuItem.PDFIXASSET
                    If P2_docProDispPlantEq Is Nothing OrElse P2_docProDispPlantEq.IsDisposed Then
                        P2_docProDispPlantEq = New DockPanel
                        Dim uc As New ucPNL_p2ProDispPlantEq

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P2_docProDispPlantEq.Text = lbl.Text
                        P2_docProDispPlantEq.Name = TaxComPNLEnuItem.PDFIXASSET.ToString
                        P2_docProDispPlantEq.Controls.Add(uc)
                        P2_docProDispPlantEq.DockedAsTabbedDocument = True
                        P2_docProDispPlantEq.Register(DockingManager)


                        DockDocument.View.AddDocument(P2_docProDispPlantEq)
                    Else
                        P2_docProDispPlantEq.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P2_docProDispPlantEq)
                    End If
                    DockDocument.View.ActivateDocument(P2_docProDispPlantEq)
                Case TaxComPNLEnuItem.PDINVEST
                    If P2_docProDisInvestment Is Nothing OrElse P2_docProDisInvestment.IsDisposed Then
                        P2_docProDisInvestment = New DockPanel
                        Dim uc As New ucPNL_p2ProDisInvestment

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P2_docProDisInvestment.Text = lbl.Text
                        P2_docProDisInvestment.Name = TaxComPNLEnuItem.PDINVEST.ToString
                        P2_docProDisInvestment.Controls.Add(uc)
                        P2_docProDisInvestment.DockedAsTabbedDocument = True
                        P2_docProDisInvestment.Register(DockingManager)


                        DockDocument.View.AddDocument(P2_docProDisInvestment)
                    Else
                        P2_docProDisInvestment.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P2_docProDisInvestment)
                    End If
                    DockDocument.View.ActivateDocument(P2_docProDisInvestment)
                Case TaxComPNLEnuItem.FORINCREMIT
                    If P2_docForeIncomeRemmit Is Nothing OrElse P2_docForeIncomeRemmit.IsDisposed Then
                        P2_docForeIncomeRemmit = New DockPanel
                        Dim uc As New ucPNL_p2ForeIncomeRemmit

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P2_docForeIncomeRemmit.Text = lbl.Text
                        P2_docForeIncomeRemmit.Name = TaxComPNLEnuItem.FORINCREMIT.ToString
                        P2_docForeIncomeRemmit.Controls.Add(uc)
                        P2_docForeIncomeRemmit.DockedAsTabbedDocument = True
                        P2_docForeIncomeRemmit.Register(DockingManager)


                        DockDocument.View.AddDocument(P2_docForeIncomeRemmit)
                    Else
                        P2_docForeIncomeRemmit.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P2_docForeIncomeRemmit)
                    End If
                    DockDocument.View.ActivateDocument(P2_docForeIncomeRemmit)
                Case TaxComPNLEnuItem.REALFE
                    If P2_docReaForeExGainNonTrade Is Nothing OrElse P2_docReaForeExGainNonTrade.IsDisposed Then
                        P2_docReaForeExGainNonTrade = New DockPanel
                        Dim uc As New ucPNL_p2ReaForeExGainNonTrade

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P2_docReaForeExGainNonTrade.Text = lbl.Text
                        P2_docReaForeExGainNonTrade.Name = TaxComPNLEnuItem.REALFE.ToString
                        P2_docReaForeExGainNonTrade.Controls.Add(uc)
                        P2_docReaForeExGainNonTrade.DockedAsTabbedDocument = True
                        P2_docReaForeExGainNonTrade.Register(DockingManager)


                        DockDocument.View.AddDocument(P2_docReaForeExGainNonTrade)
                    Else
                        P2_docReaForeExGainNonTrade.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P2_docReaForeExGainNonTrade)
                    End If
                    DockDocument.View.ActivateDocument(P2_docReaForeExGainNonTrade)
                Case TaxComPNLEnuItem.UNREALFETRADE
                    If P2_docUnreaGainForeEx Is Nothing OrElse P2_docUnreaGainForeEx.IsDisposed Then
                        P2_docUnreaGainForeEx = New DockPanel
                        Dim uc As New ucPNL_p2UnreaGainForeEx

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P2_docUnreaGainForeEx.Text = lbl.Text
                        P2_docUnreaGainForeEx.Name = TaxComPNLEnuItem.UNREALFETRADE.ToString
                        P2_docUnreaGainForeEx.Controls.Add(uc)
                        P2_docUnreaGainForeEx.DockedAsTabbedDocument = True
                        P2_docUnreaGainForeEx.Register(DockingManager)


                        DockDocument.View.AddDocument(P2_docUnreaGainForeEx)
                    Else
                        P2_docUnreaGainForeEx.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P2_docUnreaGainForeEx)
                    End If
                    DockDocument.View.ActivateDocument(P2_docUnreaGainForeEx)
                Case TaxComPNLEnuItem.UNREALFENONTRADE
                    If P2_docUnreaGainForeExNon Is Nothing OrElse P2_docUnreaGainForeExNon.IsDisposed Then
                        P2_docUnreaGainForeExNon = New DockPanel
                        Dim uc As New ucPNL_p2UnreaGainForeExNon

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P2_docUnreaGainForeExNon.Text = lbl.Text
                        P2_docUnreaGainForeExNon.Name = TaxComPNLEnuItem.UNREALFENONTRADE.ToString
                        P2_docUnreaGainForeExNon.Controls.Add(uc)
                        P2_docUnreaGainForeExNon.DockedAsTabbedDocument = True
                        P2_docUnreaGainForeExNon.Register(DockingManager)


                        DockDocument.View.AddDocument(P2_docUnreaGainForeExNon)
                    Else
                        P2_docUnreaGainForeExNon.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P2_docUnreaGainForeExNon)
                    End If
                    DockDocument.View.ActivateDocument(P2_docUnreaGainForeExNon)
                Case TaxComPNLEnuItem.EXPOTHERINTEREST
                    If P3_docOtherInterestExHirePur Is Nothing OrElse P3_docOtherInterestExHirePur.IsDisposed Then
                        P3_docOtherInterestExHirePur = New DockPanel
                        Dim uc As New ucPNL_p3OtherInterestExHirePur

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P3_docOtherInterestExHirePur.Text = lbl.Text
                        P3_docOtherInterestExHirePur.Name = TaxComPNLEnuItem.EXPOTHERINTEREST.ToString
                        P3_docOtherInterestExHirePur.Controls.Add(uc)
                        P3_docOtherInterestExHirePur.DockedAsTabbedDocument = True
                        P3_docOtherInterestExHirePur.Register(DockingManager)


                        DockDocument.View.AddDocument(P3_docOtherInterestExHirePur)
                    Else
                        P3_docOtherInterestExHirePur.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P3_docOtherInterestExHirePur)
                    End If
                    DockDocument.View.ActivateDocument(P3_docOtherInterestExHirePur)
                Case TaxComPNLEnuItem.EXPLEGAL
                    If P3_docProTechManLeganFees Is Nothing OrElse P3_docProTechManLeganFees.IsDisposed Then
                        P3_docProTechManLeganFees = New DockPanel
                        Dim uc As New ucPNL_p3ProTechManLeganFees

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P3_docProTechManLeganFees.Text = lbl.Text
                        P3_docProTechManLeganFees.Name = TaxComPNLEnuItem.EXPLEGAL.ToString
                        P3_docProTechManLeganFees.Controls.Add(uc)
                        P3_docProTechManLeganFees.DockedAsTabbedDocument = True
                        P3_docProTechManLeganFees.Register(DockingManager)


                        DockDocument.View.AddDocument(P3_docProTechManLeganFees)
                    Else
                        P3_docProTechManLeganFees.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P3_docProTechManLeganFees)
                    End If
                    DockDocument.View.ActivateDocument(P3_docProTechManLeganFees)
                Case TaxComPNLEnuItem.EXPTECHNICAL
                    If P3_docTechPayNonResis Is Nothing OrElse P3_docTechPayNonResis.IsDisposed Then
                        P3_docTechPayNonResis = New DockPanel
                        Dim uc As New ucPNL_p3TechPayNonResis

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P3_docTechPayNonResis.Text = lbl.Text
                        P3_docTechPayNonResis.Name = TaxComPNLEnuItem.EXPTECHNICAL.ToString
                        P3_docTechPayNonResis.Controls.Add(uc)
                        P3_docTechPayNonResis.DockedAsTabbedDocument = True
                        P3_docTechPayNonResis.Register(DockingManager)


                        DockDocument.View.AddDocument(P3_docTechPayNonResis)
                    Else
                        P3_docTechPayNonResis.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P3_docTechPayNonResis)
                    End If
                    DockDocument.View.ActivateDocument(P3_docTechPayNonResis)
                Case TaxComPNLEnuItem.EXPCONTRACTPAY
                    If P3_docContractPay Is Nothing OrElse P3_docContractPay.IsDisposed Then
                        P3_docContractPay = New DockPanel
                        Dim uc As New ucPNL_p3ContractPay

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P3_docContractPay.Text = lbl.Text
                        P3_docContractPay.Name = TaxComPNLEnuItem.EXPCONTRACTPAY.ToString
                        P3_docContractPay.Controls.Add(uc)
                        P3_docContractPay.DockedAsTabbedDocument = True
                        P3_docContractPay.Register(DockingManager)


                        DockDocument.View.AddDocument(P3_docContractPay)
                    Else
                        P3_docContractPay.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P3_docContractPay)
                    End If
                    DockDocument.View.ActivateDocument(P3_docContractPay)
                Case TaxComPNLEnuItem.EXPDIRECTORFEE
                    If P3_docDirectorFee Is Nothing OrElse P3_docDirectorFee.IsDisposed Then
                        P3_docDirectorFee = New DockPanel
                        Dim uc As New ucPNL_p3DirectorFee

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P3_docDirectorFee.Text = lbl.Text
                        P3_docDirectorFee.Name = TaxComPNLEnuItem.EXPDIRECTORFEE.ToString
                        P3_docDirectorFee.Controls.Add(uc)
                        P3_docDirectorFee.DockedAsTabbedDocument = True
                        P3_docDirectorFee.Register(DockingManager)


                        DockDocument.View.AddDocument(P3_docDirectorFee)
                    Else
                        P3_docDirectorFee.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P3_docDirectorFee)
                    End If
                    DockDocument.View.ActivateDocument(P3_docDirectorFee)
                Case TaxComPNLEnuItem.EXPSALARY
                    If P3_docSalary Is Nothing OrElse P3_docSalary.IsDisposed Then
                        P3_docSalary = New DockPanel
                        Dim uc As New ucPNL_p3Salary

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P3_docSalary.Text = lbl.Text
                        P3_docSalary.Name = TaxComPNLEnuItem.EXPSALARY.ToString
                        P3_docSalary.Controls.Add(uc)
                        P3_docSalary.DockedAsTabbedDocument = True
                        P3_docSalary.Register(DockingManager)


                        DockDocument.View.AddDocument(P3_docSalary)
                    Else
                        P3_docSalary.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P3_docSalary)
                    End If
                    DockDocument.View.ActivateDocument(P3_docSalary)
                Case TaxComPNLEnuItem.EXPEMPLOYEESTOCK
                    If P3_docCOEStock Is Nothing OrElse P3_docCOEStock.IsDisposed Then
                        P3_docCOEStock = New DockPanel
                        Dim uc As New ucPNL_p3COEStock

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P3_docCOEStock.Text = lbl.Text
                        P3_docCOEStock.Name = TaxComPNLEnuItem.EXPEMPLOYEESTOCK.ToString
                        P3_docCOEStock.Controls.Add(uc)
                        P3_docCOEStock.DockedAsTabbedDocument = True
                        P3_docCOEStock.Register(DockingManager)


                        DockDocument.View.AddDocument(P3_docCOEStock)
                    Else
                        P3_docCOEStock.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P3_docCOEStock)
                    End If
                    DockDocument.View.ActivateDocument(P3_docCOEStock)
                Case TaxComPNLEnuItem.EXPROYALTY
                    If P3_docRoyalty Is Nothing OrElse P3_docRoyalty.IsDisposed Then
                        P3_docRoyalty = New DockPanel
                        Dim uc As New ucPNL_p3Royalty

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P3_docRoyalty.Text = lbl.Text
                        P3_docRoyalty.Name = TaxComPNLEnuItem.EXPROYALTY.ToString
                        P3_docRoyalty.Controls.Add(uc)
                        P3_docRoyalty.DockedAsTabbedDocument = True
                        P3_docRoyalty.Register(DockingManager)


                        DockDocument.View.AddDocument(P3_docRoyalty)
                    Else
                        P3_docRoyalty.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P3_docRoyalty)
                    End If
                    DockDocument.View.ActivateDocument(P3_docRoyalty)
                Case TaxComPNLEnuItem.EXPRENTAL
                    If P3_docRental Is Nothing OrElse P3_docRental.IsDisposed Then
                        P3_docRental = New DockPanel
                        Dim uc As New ucPNL_p3Rental

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P3_docRental.Text = lbl.Text
                        P3_docRental.Name = TaxComPNLEnuItem.EXPRENTAL.ToString
                        P3_docRental.Controls.Add(uc)
                        P3_docRental.DockedAsTabbedDocument = True
                        P3_docRental.Register(DockingManager)


                        DockDocument.View.AddDocument(P3_docRental)
                    Else
                        P3_docRental.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P3_docRental)
                    End If
                    DockDocument.View.ActivateDocument(P3_docRental)
                Case TaxComPNLEnuItem.EXPREPAIRMAINTENANCE
                    If P3_docRepairMain Is Nothing OrElse P3_docRepairMain.IsDisposed Then
                        P3_docRepairMain = New DockPanel
                        Dim uc As New ucPNL_p3RepairMain

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P3_docRepairMain.Text = lbl.Text
                        P3_docRepairMain.Name = TaxComPNLEnuItem.EXPREPAIRMAINTENANCE.ToString
                        P3_docRepairMain.Controls.Add(uc)
                        P3_docRepairMain.DockedAsTabbedDocument = True
                        P3_docRepairMain.Register(DockingManager)


                        DockDocument.View.AddDocument(P3_docRepairMain)
                    Else
                        P3_docRepairMain.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P3_docRepairMain)
                    End If
                    DockDocument.View.ActivateDocument(P3_docRepairMain)
                Case TaxComPNLEnuItem.EXPRND
                    If P3_docResearchDev Is Nothing OrElse P3_docResearchDev.IsDisposed Then
                        P3_docResearchDev = New DockPanel
                        Dim uc As New ucPNL_p3ResearchDev

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P3_docResearchDev.Text = lbl.Text
                        P3_docResearchDev.Name = TaxComPNLEnuItem.EXPRND.ToString
                        P3_docResearchDev.Controls.Add(uc)
                        P3_docResearchDev.DockedAsTabbedDocument = True
                        P3_docResearchDev.Register(DockingManager)


                        DockDocument.View.AddDocument(P3_docResearchDev)
                    Else
                        P3_docResearchDev.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P3_docResearchDev)
                    End If
                    DockDocument.View.ActivateDocument(P3_docResearchDev)
                Case TaxComPNLEnuItem.EXPADVERTISEMENT
                    If P3_docPromotionAds Is Nothing OrElse P3_docPromotionAds.IsDisposed Then
                        P3_docPromotionAds = New DockPanel
                        Dim uc As New ucPNL_p3PromotionAds

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P3_docPromotionAds.Text = lbl.Text
                        P3_docPromotionAds.Name = TaxComPNLEnuItem.EXPADVERTISEMENT.ToString
                        P3_docPromotionAds.Controls.Add(uc)
                        P3_docPromotionAds.DockedAsTabbedDocument = True
                        P3_docPromotionAds.Register(DockingManager)


                        DockDocument.View.AddDocument(P3_docPromotionAds)
                    Else
                        P3_docPromotionAds.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P3_docPromotionAds)
                    End If
                    DockDocument.View.ActivateDocument(P3_docPromotionAds)
                Case TaxComPNLEnuItem.EXPTRAVEL
                    If P3_docTravelling Is Nothing OrElse P3_docTravelling.IsDisposed Then
                        P3_docTravelling = New DockPanel
                        Dim uc As New ucPNL_p3Travelling

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P3_docTravelling.Text = lbl.Text
                        P3_docTravelling.Name = TaxComPNLEnuItem.EXPTRAVEL.ToString
                        P3_docTravelling.Controls.Add(uc)
                        P3_docTravelling.DockedAsTabbedDocument = True
                        P3_docTravelling.Register(DockingManager)


                        DockDocument.View.AddDocument(P3_docTravelling)
                    Else
                        P3_docTravelling.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P3_docTravelling)
                    End If
                    DockDocument.View.ActivateDocument(P3_docTravelling)
                Case TaxComPNLEnuItem.EXPJKDM
                    If P3_docJKDM Is Nothing OrElse P3_docJKDM.IsDisposed Then
                        P3_docJKDM = New DockPanel
                        Dim uc As New ucPNL_p3JKDM

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P3_docJKDM.Text = lbl.Text
                        P3_docJKDM.Name = TaxComPNLEnuItem.EXPJKDM.ToString
                        P3_docJKDM.Controls.Add(uc)
                        P3_docJKDM.DockedAsTabbedDocument = True
                        P3_docJKDM.Register(DockingManager)


                        DockDocument.View.AddDocument(P3_docJKDM)
                    Else
                        P3_docJKDM.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P3_docJKDM)
                    End If
                    DockDocument.View.ActivateDocument(P3_docJKDM)
                Case TaxComPNLEnuItem.EXPDEPRECIATION
                    If P3_docDepreciation Is Nothing OrElse P3_docDepreciation.IsDisposed Then
                        P3_docDepreciation = New DockPanel
                        Dim uc As New ucPNL_p3Depreciation

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P3_docDepreciation.Text = lbl.Text
                        P3_docDepreciation.Name = TaxComPNLEnuItem.EXPDEPRECIATION.ToString
                        P3_docDepreciation.Controls.Add(uc)
                        P3_docDepreciation.DockedAsTabbedDocument = True
                        P3_docDepreciation.Register(DockingManager)


                        DockDocument.View.AddDocument(P3_docDepreciation)
                    Else
                        P3_docDepreciation.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P3_docDepreciation)
                    End If
                    DockDocument.View.ActivateDocument(P3_docDepreciation)
                Case TaxComPNLEnuItem.EXPDONATIONAPPR
                    If P3_docDonationApp Is Nothing OrElse P3_docDonationApp.IsDisposed Then
                        P3_docDonationApp = New DockPanel
                        Dim uc As New ucPNL_p3DonationApp

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P3_docDonationApp.Text = lbl.Text
                        P3_docDonationApp.Name = TaxComPNLEnuItem.EXPDONATIONAPPR.ToString
                        P3_docDonationApp.Controls.Add(uc)
                        P3_docDonationApp.DockedAsTabbedDocument = True
                        P3_docDonationApp.Register(DockingManager)


                        DockDocument.View.AddDocument(P3_docDonationApp)
                    Else
                        P3_docDonationApp.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P3_docDonationApp)
                    End If
                    DockDocument.View.ActivateDocument(P3_docDonationApp)
                Case TaxComPNLEnuItem.EXPDONATIONNONAPPR
                    If P3_docDonationNonApp Is Nothing OrElse P3_docDonationNonApp.IsDisposed Then
                        P3_docDonationNonApp = New DockPanel
                        Dim uc As New ucPNL_p3DonationNonApp

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P3_docDonationNonApp.Text = lbl.Text
                        P3_docDonationNonApp.Name = TaxComPNLEnuItem.EXPDONATIONNONAPPR.ToString
                        P3_docDonationNonApp.Controls.Add(uc)
                        P3_docDonationNonApp.DockedAsTabbedDocument = True
                        P3_docDonationNonApp.Register(DockingManager)


                        DockDocument.View.AddDocument(P3_docDonationNonApp)
                    Else
                        P3_docDonationNonApp.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P3_docDonationNonApp)
                    End If
                    DockDocument.View.ActivateDocument(P3_docDonationNonApp)

                Case TaxComPNLEnuItem.EXPZAKAT
                    If p3_docZakat Is Nothing OrElse p3_docZakat.IsDisposed Then
                        p3_docZakat = New DockPanel
                        Dim uc As New ucPNL_p3Zakat

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        p3_docZakat.Text = lbl.Text
                        p3_docZakat.Name = TaxComPNLEnuItem.EXPZAKAT.ToString
                        p3_docZakat.Controls.Add(uc)
                        p3_docZakat.DockedAsTabbedDocument = True
                        p3_docZakat.Register(DockingManager)


                        DockDocument.View.AddDocument(p3_docZakat)
                    Else
                        p3_docZakat.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(p3_docZakat)
                    End If
                    DockDocument.View.ActivateDocument(p3_docZakat)

                Case TaxComPNLEnuItem.EXPLOSSDISPFA
                    If p4_docLossDispFA Is Nothing OrElse p4_docLossDispFA.IsDisposed Then
                        p4_docLossDispFA = New DockPanel
                        Dim uc As New ucPNL_p4LossDispFA

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        p4_docLossDispFA.Text = lbl.Text
                        p4_docLossDispFA.Name = TaxComPNLEnuItem.EXPLOSSDISPFA.ToString
                        p4_docLossDispFA.Controls.Add(uc)
                        p4_docLossDispFA.DockedAsTabbedDocument = True
                        p4_docLossDispFA.Register(DockingManager)


                        DockDocument.View.AddDocument(p4_docLossDispFA)
                    Else
                        p4_docLossDispFA.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(p4_docLossDispFA)
                    End If
                    DockDocument.View.ActivateDocument(p4_docLossDispFA)

                Case TaxComPNLEnuItem.EXPENTERTAINNONSTAFF
                    If p4_docEntNonStaff Is Nothing OrElse p4_docEntNonStaff.IsDisposed Then
                        p4_docEntNonStaff = New DockPanel
                        Dim uc As New ucPNL_p4EntNonStaff

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        p4_docEntNonStaff.Text = lbl.Text
                        p4_docEntNonStaff.Name = TaxComPNLEnuItem.EXPENTERTAINNONSTAFF.ToString
                        p4_docEntNonStaff.Controls.Add(uc)
                        p4_docEntNonStaff.DockedAsTabbedDocument = True
                        p4_docEntNonStaff.Register(DockingManager)


                        DockDocument.View.AddDocument(p4_docEntNonStaff)
                    Else
                        p4_docEntNonStaff.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(p4_docEntNonStaff)
                    End If
                    DockDocument.View.ActivateDocument(p4_docEntNonStaff)

                Case TaxComPNLEnuItem.EXPENTERTAINSTAFF
                    If p4_docEntStaff Is Nothing OrElse p4_docEntStaff.IsDisposed Then
                        p4_docEntStaff = New DockPanel
                        Dim uc As New ucPNL_p4EntStaff

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        p4_docEntStaff.Text = lbl.Text
                        p4_docEntStaff.Name = TaxComPNLEnuItem.EXPENTERTAINSTAFF.ToString
                        p4_docEntStaff.Controls.Add(uc)
                        p4_docEntStaff.DockedAsTabbedDocument = True
                        p4_docEntStaff.Register(DockingManager)


                        DockDocument.View.AddDocument(p4_docEntStaff)
                    Else
                        p4_docEntStaff.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(p4_docEntStaff)
                    End If
                    DockDocument.View.ActivateDocument(p4_docEntStaff)

                Case TaxComPNLEnuItem.EXPCOMPAUNDPENALTY
                    If p4_docCompound Is Nothing OrElse p4_docCompound.IsDisposed Then
                        p4_docCompound = New DockPanel
                        Dim uc As New ucPNL_p4Compound

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        p4_docCompound.Text = lbl.Text
                        p4_docCompound.Name = TaxComPNLEnuItem.EXPCOMPAUNDPENALTY.ToString
                        p4_docCompound.Controls.Add(uc)
                        p4_docCompound.DockedAsTabbedDocument = True
                        p4_docCompound.Register(DockingManager)


                        DockDocument.View.AddDocument(p4_docCompound)
                    Else
                        p4_docCompound.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(p4_docCompound)
                    End If
                    DockDocument.View.ActivateDocument(p4_docCompound)

                Case TaxComPNLEnuItem.EXPPROVISION
                    If p4_docProvisionAcc Is Nothing OrElse p4_docProvisionAcc.IsDisposed Then
                        p4_docProvisionAcc = New DockPanel
                        Dim uc As New ucPNL_p4ProvisionAcc

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        p4_docProvisionAcc.Text = lbl.Text
                        p4_docProvisionAcc.Name = TaxComPNLEnuItem.EXPPROVISION.ToString
                        p4_docProvisionAcc.Controls.Add(uc)
                        p4_docProvisionAcc.DockedAsTabbedDocument = True
                        p4_docProvisionAcc.Register(DockingManager)


                        DockDocument.View.AddDocument(p4_docProvisionAcc)
                    Else
                        p4_docProvisionAcc.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(p4_docProvisionAcc)
                    End If
                    DockDocument.View.ActivateDocument(p4_docProvisionAcc)


                Case TaxComPNLEnuItem.EXPLEAVEPASSAGE
                    If p4_docLeavePass Is Nothing OrElse p4_docLeavePass.IsDisposed Then
                        p4_docLeavePass = New DockPanel
                        Dim uc As New ucPNL_p4LeavePass

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        p4_docLeavePass.Text = lbl.Text
                        p4_docLeavePass.Name = TaxComPNLEnuItem.EXPLEAVEPASSAGE.ToString
                        p4_docLeavePass.Controls.Add(uc)
                        p4_docLeavePass.DockedAsTabbedDocument = True
                        p4_docLeavePass.Register(DockingManager)


                        DockDocument.View.AddDocument(p4_docLeavePass)
                    Else
                        p4_docLeavePass.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(p4_docLeavePass)
                    End If
                    DockDocument.View.ActivateDocument(p4_docLeavePass)

                Case TaxComPNLEnuItem.EXPFAWRITTENOFF
                    If p4_docFAWrittenOff Is Nothing OrElse p4_docFAWrittenOff.IsDisposed Then
                        p4_docFAWrittenOff = New DockPanel
                        Dim uc As New ucPNL_p4FAWrittenOff

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        p4_docFAWrittenOff.Text = lbl.Text
                        p4_docFAWrittenOff.Name = TaxComPNLEnuItem.EXPFAWRITTENOFF.ToString
                        p4_docFAWrittenOff.Controls.Add(uc)
                        p4_docFAWrittenOff.DockedAsTabbedDocument = True
                        p4_docFAWrittenOff.Register(DockingManager)


                        DockDocument.View.AddDocument(p4_docFAWrittenOff)
                    Else
                        p4_docFAWrittenOff.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(p4_docFAWrittenOff)
                    End If
                    DockDocument.View.ActivateDocument(p4_docFAWrittenOff)

                Case TaxComPNLEnuItem.EXPUNREALLOSSFE
                    If p4_docUnreaLossForeEx Is Nothing OrElse p4_docUnreaLossForeEx.IsDisposed Then
                        p4_docUnreaLossForeEx = New DockPanel
                        Dim uc As New ucPNL_p4UnreaLossForeEx

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        p4_docUnreaLossForeEx.Text = lbl.Text
                        p4_docUnreaLossForeEx.Name = TaxComPNLEnuItem.EXPUNREALLOSSFE.ToString
                        p4_docUnreaLossForeEx.Controls.Add(uc)
                        p4_docUnreaLossForeEx.DockedAsTabbedDocument = True
                        p4_docUnreaLossForeEx.Register(DockingManager)


                        DockDocument.View.AddDocument(p4_docUnreaLossForeEx)
                    Else
                        p4_docUnreaLossForeEx.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(p4_docUnreaLossForeEx)
                    End If
                    DockDocument.View.ActivateDocument(p4_docUnreaLossForeEx)

                Case TaxComPNLEnuItem.EXPREALLOSSFETRADE
                    If p4_docReaLossForeExTrade Is Nothing OrElse p4_docReaLossForeExTrade.IsDisposed Then
                        p4_docReaLossForeExTrade = New DockPanel
                        Dim uc As New ucPNL_p4ReaLossForeExTrade

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        p4_docReaLossForeExTrade.Text = lbl.Text
                        p4_docReaLossForeExTrade.Name = TaxComPNLEnuItem.EXPREALLOSSFETRADE.ToString
                        p4_docReaLossForeExTrade.Controls.Add(uc)
                        p4_docReaLossForeExTrade.DockedAsTabbedDocument = True
                        p4_docReaLossForeExTrade.Register(DockingManager)


                        DockDocument.View.AddDocument(p4_docReaLossForeExTrade)
                    Else
                        p4_docReaLossForeExTrade.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(p4_docReaLossForeExTrade)
                    End If
                    DockDocument.View.ActivateDocument(p4_docReaLossForeExTrade)

                Case TaxComPNLEnuItem.EXPREALLOSSFENONTRADE
                    If p4_docReaLossForeExNonTrade Is Nothing OrElse p4_docReaLossForeExNonTrade.IsDisposed Then
                        p4_docReaLossForeExNonTrade = New DockPanel
                        Dim uc As New ucPNL_p4ReaLossForeExNonTrade

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        p4_docReaLossForeExNonTrade.Text = lbl.Text
                        p4_docReaLossForeExNonTrade.Name = TaxComPNLEnuItem.EXPREALLOSSFENONTRADE.ToString
                        p4_docReaLossForeExNonTrade.Controls.Add(uc)
                        p4_docReaLossForeExNonTrade.DockedAsTabbedDocument = True
                        p4_docReaLossForeExNonTrade.Register(DockingManager)


                        DockDocument.View.AddDocument(p4_docReaLossForeExNonTrade)
                    Else
                        p4_docReaLossForeExNonTrade.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(p4_docReaLossForeExNonTrade)
                    End If
                    DockDocument.View.ActivateDocument(p4_docReaLossForeExNonTrade)

                Case TaxComPNLEnuItem.EXPINITIALSUBSCRIPT
                    If p4_docInitSub Is Nothing OrElse p4_docInitSub.IsDisposed Then
                        p4_docInitSub = New DockPanel
                        Dim uc As New ucPNL_p4InitSub

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        p4_docInitSub.Text = lbl.Text
                        p4_docInitSub.Name = TaxComPNLEnuItem.EXPINITIALSUBSCRIPT.ToString
                        p4_docInitSub.Controls.Add(uc)
                        p4_docInitSub.DockedAsTabbedDocument = True
                        p4_docInitSub.Register(DockingManager)


                        DockDocument.View.AddDocument(p4_docInitSub)
                    Else
                        p4_docInitSub.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(p4_docInitSub)
                    End If
                    DockDocument.View.ActivateDocument(p4_docInitSub)

                Case TaxComPNLEnuItem.EXPCAPITALEXPENDITURE
                    If p4_docCAExpenditure Is Nothing OrElse p4_docCAExpenditure.IsDisposed Then
                        p4_docCAExpenditure = New DockPanel
                        Dim uc As New ucPNL_p4CAExpenditure

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        p4_docCAExpenditure.Text = lbl.Text
                        p4_docCAExpenditure.Name = TaxComPNLEnuItem.EXPCAPITALEXPENDITURE.ToString
                        p4_docCAExpenditure.Controls.Add(uc)
                        p4_docCAExpenditure.DockedAsTabbedDocument = True
                        p4_docCAExpenditure.Register(DockingManager)


                        DockDocument.View.AddDocument(p4_docCAExpenditure)
                    Else
                        p4_docCAExpenditure.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(p4_docCAExpenditure)
                    End If
                    DockDocument.View.ActivateDocument(p4_docCAExpenditure)

                Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
                    If p4_docOther Is Nothing OrElse p4_docOther.IsDisposed Then
                        p4_docOther = New DockPanel
                        Dim uc As New ucPNL_p4Other

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        p4_docOther.Text = lbl.Text
                        p4_docOther.Name = TaxComPNLEnuItem.EXPOTHERSEXPENSES.ToString
                        p4_docOther.Controls.Add(uc)
                        p4_docOther.DockedAsTabbedDocument = True
                        p4_docOther.Register(DockingManager)


                        DockDocument.View.AddDocument(p4_docOther)
                    Else
                        p4_docOther.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(p4_docOther)
                    End If
                    DockDocument.View.ActivateDocument(p4_docOther)
                Case TaxComPNLEnuItem.RENTALINC
                    If P2_docRentalIncome Is Nothing OrElse P2_docRentalIncome.IsDisposed Then
                        P2_docRentalIncome = New DockPanel
                        Dim uc As New ucPNL_p2RentalIncome

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.txtSales = txtSales
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P2_docRentalIncome.Text = lbl.Text
                        P2_docRentalIncome.Name = TaxComPNLEnuItem.RENTALINC.ToString
                        P2_docRentalIncome.Controls.Add(uc)
                        P2_docRentalIncome.DockedAsTabbedDocument = True
                        P2_docRentalIncome.Register(DockingManager)


                        DockDocument.View.AddDocument(P2_docRentalIncome)
                    Else
                        P2_docRentalIncome.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P2_docRentalIncome)
                    End If
                    DockDocument.View.ActivateDocument(P2_docRentalIncome)
                Case TaxComPNLEnuItem.NONALLOWABLEEXPENSES
                    If p4_docNonAllowableExpenses Is Nothing OrElse p4_docNonAllowableExpenses.IsDisposed Then
                        p4_docNonAllowableExpenses = New DockPanel
                        Dim uc As New ucPNL_p4NonAllowableExpenses

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        p4_docNonAllowableExpenses.Text = lbl.Text
                        p4_docNonAllowableExpenses.Name = TaxComPNLEnuItem.NONALLOWABLEEXPENSES.ToString
                        p4_docNonAllowableExpenses.Controls.Add(uc)
                        p4_docNonAllowableExpenses.DockedAsTabbedDocument = True
                        p4_docNonAllowableExpenses.Register(DockingManager)


                        DockDocument.View.AddDocument(p4_docNonAllowableExpenses)
                    Else
                        p4_docNonAllowableExpenses.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(p4_docNonAllowableExpenses)
                    End If
                    DockDocument.View.ActivateDocument(p4_docNonAllowableExpenses)
                Case TaxComPNLEnuItem.OTHERNONTAXINC
                    If P2_docOther Is Nothing OrElse P2_docOther.IsDisposed Then
                        P2_docOther = New DockPanel
                        Dim uc As New ucPNL_p2Other

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P2_docOther.Text = lbl.Text
                        P2_docOther.Name = TaxComPNLEnuItem.OTHERNONTAXINC.ToString
                        P2_docOther.Controls.Add(uc)
                        P2_docOther.DockedAsTabbedDocument = True
                        P2_docOther.Register(DockingManager)


                        DockDocument.View.AddDocument(P2_docOther)
                    Else
                        P2_docOther.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P2_docOther)
                    End If
                    DockDocument.View.ActivateDocument(P2_docOther)
                Case TaxComPNLEnuItem.EXEMDIV
                    If P2_docExemptDividend Is Nothing OrElse P2_docExemptDividend.IsDisposed Then
                        P2_docExemptDividend = New DockPanel
                        Dim uc As New ucPNL_p2ExemptDividend

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P2_docExemptDividend.Text = lbl.Text
                        P2_docExemptDividend.Name = TaxComPNLEnuItem.EXEMDIV.ToString
                        P2_docExemptDividend.Controls.Add(uc)
                        P2_docExemptDividend.DockedAsTabbedDocument = True
                        P2_docExemptDividend.Register(DockingManager)


                        DockDocument.View.AddDocument(P2_docExemptDividend)
                    Else
                        P2_docExemptDividend.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P2_docExemptDividend)
                    End If
                    DockDocument.View.ActivateDocument(P2_docExemptDividend)
                Case TaxComPNLEnuItem.INTERESTRESTRICT
                    If P3_docInterestResPurS33 Is Nothing OrElse P3_docInterestResPurS33.IsDisposed Then
                        P3_docInterestResPurS33 = New DockPanel
                        Dim uc As New ucPNL_p3InterestResPurS33

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P3_docInterestResPurS33.Text = lbl.Text
                        P3_docInterestResPurS33.Name = TaxComPNLEnuItem.INTERESTRESTRICT.ToString
                        P3_docInterestResPurS33.Controls.Add(uc)
                        P3_docInterestResPurS33.DockedAsTabbedDocument = True
                        P3_docInterestResPurS33.Register(DockingManager)


                        DockDocument.View.AddDocument(P3_docInterestResPurS33)
                    Else
                        P3_docInterestResPurS33.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P3_docInterestResPurS33)
                    End If
                    DockDocument.View.ActivateDocument(P3_docInterestResPurS33)
                Case TaxComPNLEnuItem.DIVIDENDINC
                    If P2_docDivIncome Is Nothing OrElse P2_docDivIncome.IsDisposed Then
                        P2_docDivIncome = New DockPanel
                        Dim uc As New ucPNL_p2DivIncome

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.txtSales = txtSales
                        uc.DataView_Main = dsDataSet
                        uc.DataView_Main2 = dsDataSet2
                        uc.SourceNo = SourceNo
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P2_docDivIncome.Text = lbl.Text
                        P2_docDivIncome.Name = TaxComPNLEnuItem.DIVIDENDINC.ToString
                        P2_docDivIncome.Controls.Add(uc)
                        P2_docDivIncome.DockedAsTabbedDocument = True
                        P2_docDivIncome.Register(DockingManager)


                        DockDocument.View.AddDocument(P2_docDivIncome)
                    Else
                        P2_docDivIncome.Visibility = DockVisibility.Visible
                        DockDocument.View.AddDocument(P2_docDivIncome)
                    End If
                    DockDocument.View.ActivateDocument(P2_docDivIncome)
            End Select

            Return False
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return False
        Finally
            DockDocument.EndUpdate()
        End Try
    End Function
    Public Sub MoveItemsInListView(ByVal blnMoveUp As Boolean, ByVal MainTable As String, ByVal MainTable_Details As String, _
                                   ByVal RefNo As String, ByVal MainKey As String, ByVal MainKey_Details As String, _
                                    ByRef gridview As DevExpress.XtraGrid.Views.Grid.GridView, ByRef ds As DataSet, Optional ByRef ErrorLog As clsError = Nothing)
        Try
            'Set the listview index to limit to depending on whether we are moving things up or down in the list
            Dim intLimittedIndex As Integer = (ds.Tables(MainTable).Rows.Count - 1)
            If blnMoveUp Then intLimittedIndex = 0

            'Define a new collection of the listview indexes to move
            Dim colIndexesToMove As New List(Of Integer)()

            For i As Integer = 0 To ds.Tables(MainTable).Rows.Count - 1
                If gridview.FocusedRowHandle = i Then
                    colIndexesToMove.Add(i)
                    If gridview.FocusedRowHandle = intLimittedIndex Then
                        'Do not attempt to move item(s) as we are at the top or bottom of the list
                        Exit Try
                    End If
                    If blnMoveUp = False AndAlso i = ds.Tables(MainTable).Rows.Count - 1 Then
                        Exit Sub
                    End If
                End If
            Next


            'If we are moving items down
            If Not blnMoveUp Then
                'Reverse the index list so that we move items from the bottom of the selection first
                colIndexesToMove.Reverse()
            End If
            Dim ltmpdtRow As New DataTable("TMP")
            Dim tmpcol As System.Data.DataColumn
            For Each col As System.Data.DataColumn In ds.Tables(MainTable_Details).Columns
                tmpcol = Nothing
                tmpcol = New DataColumn
                tmpcol.ColumnName = col.ColumnName
                tmpcol.DataType = col.DataType
                tmpcol.DefaultValue = col.DefaultValue
                tmpcol.AutoIncrement = col.AutoIncrement
                tmpcol.AutoIncrementSeed = col.AutoIncrementSeed
                tmpcol.AutoIncrementStep = col.AutoIncrementStep

                ltmpdtRow.Columns.Add(tmpcol)
            Next
            Application.DoEvents()
            Dim dtXrow As DataRow = Nothing
            Dim row As DataRow
            'Loop through each index we want to move
            For Each intIndex As Integer In colIndexesToMove

                If RefNo IsNot Nothing AndAlso RefNo <> "" Then
                    ltmpdtRow.Rows.Clear()
                    dtXrow = Nothing
                    dtXrow = ds.Tables(MainTable).Rows(intIndex)
                    Dim indx As Integer = 0

                    If blnMoveUp Then
                        indx = intIndex - 1
                    Else
                        indx = intIndex + 1
                    End If

                    Dim KeyNo As Integer = 0
                    row = Nothing
                    row = ds.Tables(MainTable).NewRow
                    For Each col As DataColumn In ds.Tables(MainTable).Columns
                        If col.ColumnName = MainKey Then
                            KeyNo = dtXrow(col)
                        End If
                        row(col) = dtXrow(col)
                    Next
                    'if got child
                    For i As Integer = 0 To ds.Tables(MainTable_Details).Rows.Count - 1
                        If IsDBNull(ds.Tables(MainTable_Details).Rows(i)(MainKey_Details)) = False AndAlso ds.Tables(MainTable_Details).Rows(i)(MainKey_Details) = KeyNo Then
                            ltmpdtRow.ImportRow(ds.Tables(MainTable_Details).Rows(i))
                        End If
                    Next

                    ds.Tables(MainTable).Rows(intIndex).Delete()

                    ds.Tables(MainTable).Rows.InsertAt(row, indx)
                    Application.DoEvents()

                    If ltmpdtRow.Rows.Count > 0 Then
                        For i As Integer = 0 To ltmpdtRow.Rows.Count - 1
                            ltmpdtRow.Rows(i)(MainKey_Details) = ds.Tables(MainTable).Rows(indx)(MainKey)
                            ds.Tables(MainTable_Details).ImportRow(ltmpdtRow.Rows(i))
                        Next
                    End If
                    gridview.FocusedRowHandle = indx
                    gridview.SelectRow(indx)
                Else
                    dtXrow = Nothing
                    dtXrow = gridview.GetDataRow(intIndex)
                    ds.Tables(MainTable).Rows.RemoveAt(intIndex)

                    If blnMoveUp Then

                        ds.Tables(MainTable).Rows.InsertAt(dtXrow, intIndex - 1)
                        gridview.FocusedRowHandle = intIndex - 1
                        gridview.SelectRow(intIndex - 1)
                    Else
                        ds.Tables(MainTable).Rows.InsertAt(dtXrow, intIndex + 1)
                        gridview.FocusedRowHandle = intIndex + 1
                        gridview.SelectRow(intIndex + 1)
                    End If

                End If

            Next

        Catch ex As Exception
            ' Trace.WriteLine("MoveItemsInListView() has thrown an exception: " & ex.Message)
        Finally
            'Set the focus on the listview
            gridview.Focus()
        End Try
    End Sub
    Public Sub MoveItemsInListView_WithoutChild(ByVal blnMoveUp As Boolean, ByVal MainTable As String, _
                                   ByVal RefNo As String, ByVal MainKey As String, _
                                    ByRef gridview As DevExpress.XtraGrid.Views.Grid.GridView, ByRef ds As DataSet, Optional ByRef ErrorLog As clsError = Nothing)
        Try
            'Set the listview index to limit to depending on whether we are moving things up or down in the list
            Dim intLimittedIndex As Integer = (ds.Tables(MainTable).Rows.Count - 1)
            If blnMoveUp Then intLimittedIndex = 0

            'Define a new collection of the listview indexes to move
            Dim colIndexesToMove As New List(Of Integer)()

            For i As Integer = 0 To ds.Tables(MainTable).Rows.Count - 1
                If gridview.FocusedRowHandle = i Then
                    colIndexesToMove.Add(i)
                    If gridview.FocusedRowHandle = intLimittedIndex Then
                        'Do not attempt to move item(s) as we are at the top or bottom of the list
                        Exit Try
                    End If
                    If blnMoveUp = False AndAlso i = ds.Tables(MainTable).Rows.Count - 1 Then
                        Exit Sub
                    End If
                End If
            Next


            'If we are moving items down
            If Not blnMoveUp Then
                'Reverse the index list so that we move items from the bottom of the selection first
                colIndexesToMove.Reverse()
            End If
            Dim tmpcol As System.Data.DataColumn
            Application.DoEvents()
            Dim dtXrow As DataRow = Nothing
            Dim row As DataRow
            'Loop through each index we want to move
            For Each intIndex As Integer In colIndexesToMove

                If RefNo IsNot Nothing AndAlso RefNo <> "" Then

                    dtXrow = Nothing
                    dtXrow = ds.Tables(MainTable).Rows(intIndex)
                    Dim indx As Integer = 0

                    If blnMoveUp Then
                        indx = intIndex - 1
                    Else
                        indx = intIndex + 2
                    End If

                    Dim KeyNo As Integer = 0
                    row = Nothing
                    row = ds.Tables(MainTable).NewRow
                    For Each col As DataColumn In ds.Tables(MainTable).Columns
                        If col.ColumnName = MainKey Then
                            KeyNo = dtXrow(col)
                        End If
                        row(col) = dtXrow(col)
                    Next

                    ds.Tables(MainTable).Rows(intIndex).Delete()
                    Application.DoEvents()
                    ds.Tables(MainTable).Rows.InsertAt(row, indx)
                    Application.DoEvents()


                    If blnMoveUp Then
                        gridview.FocusedRowHandle = indx
                    Else
                        gridview.FocusedRowHandle = indx - 1
                    End If
                    gridview.SelectRow(indx)
                Else
                    dtXrow = Nothing
                    dtXrow = gridview.GetDataRow(intIndex)
                    ds.Tables(MainTable).Rows.RemoveAt(intIndex)

                    If blnMoveUp Then

                        ds.Tables(MainTable).Rows.InsertAt(dtXrow, intIndex - 1)
                        gridview.FocusedRowHandle = intIndex - 1
                        gridview.SelectRow(intIndex - 1)
                    Else
                        ds.Tables(MainTable).Rows.InsertAt(dtXrow, intIndex + 1)
                        gridview.FocusedRowHandle = intIndex + 1
                        gridview.SelectRow(intIndex + 1)
                    End If

                End If

            Next

        Catch ex As Exception
            ' Trace.WriteLine("MoveItemsInListView() has thrown an exception: " & ex.Message)
        Finally
            'Set the focus on the listview
            ds.Tables(MainTable).AcceptChanges()
            gridview.Focus()
        End Try
    End Sub
     Public Function GetColumn_InterestRestrictMonthly(ByVal RefNo As String, ByVal YA As String, _
                                                      ByVal SourceNo As Integer, ByRef dsPNL As DataSet, _
                                                      ByRef GridView1 As DevExpress.XtraGrid.Views.Grid.GridView, _
                                                      Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = Nothing
            Dim clm As System.Data.DataColumn
            Dim col As DevExpress.XtraGrid.Columns.GridColumn
            Dim txt As RepositoryItemTextEdit

            Dim infx As Integer = 0

            GridView1.Columns.Clear()
            dsPNL.Tables("REF_INTEREST_RESTRIC_TMP").Columns.Clear()

            clm = New System.Data.DataColumn
            clm.ColumnName = "Month"
            clm.Caption = "Month"
            clm.DataType = Type.GetType("System.DateTime")
            clm.DefaultValue = Now
            clm.AllowDBNull = True
            dsPNL.Tables("REF_INTEREST_RESTRIC_TMP").Columns.Add(clm)

            col = New DevExpress.XtraGrid.Columns.GridColumn
            col.Caption = "Month"
            col.Name = "Month"
            col.VisibleIndex = infx
            col.Visible = True
            col.ColumnEdit = New RepositoryItemDateEdit()
            col.Width = 150
            col.FieldName = "Month"
            col.OptionsColumn.ReadOnly = True
            col.OptionsColumn.TabStop = False
            GridView1.Columns.Add(col)

            dt = mdlProcess.Load_interestRestricSchedule(RefNo, YA, SourceNo, "inv", Errorlog)

            If dt IsNot Nothing Then
                For Each row As DataRow In dt.Rows
                    infx += 1
                    clm = Nothing
                    clm = New System.Data.DataColumn
                    clm.ColumnName = IIf(IsDBNull(row("Item")), "", row("Item")).ToString
                    clm.Caption = "inv"
                    clm.DefaultValue = 0
                    clm.DataType = Type.GetType("System.Decimal")
                    dsPNL.Tables("REF_INTEREST_RESTRIC_TMP").Columns.Add(clm)

                    '------------------------------------------------------------------

                    col = New DevExpress.XtraGrid.Columns.GridColumn
                    col.Caption = IIf(IsDBNull(row("Item")), "", row("Item")).ToString.Remove(0, 1)
                    col.Name = IIf(IsDBNull(row("Item")), "", row("Item")).ToString
                    col.Tag = "inv"
                    col.VisibleIndex = infx
                    col.Visible = True
                    txt = New RepositoryItemTextEdit
                    txt.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
                    txt.Mask.EditMask = "c"
                    txt.Mask.UseMaskAsDisplayFormat = True

                    col.ColumnEdit = txt
                    col.Width = 120
                    col.FieldName = IIf(IsDBNull(row("Item")), "", row("Item")).ToString
                    GridView1.Columns.Add(col)
                Next
            End If

            clm = Nothing
            clm = New System.Data.DataColumn
            clm.ColumnName = "TotalIncProInv"
            clm.Caption = "Total Income Producing Investment"
            clm.DefaultValue = 0
            clm.DataType = Type.GetType("System.Decimal")
            dsPNL.Tables("REF_INTEREST_RESTRIC_TMP").Columns.Add(clm)

            col = New DevExpress.XtraGrid.Columns.GridColumn
            col.Caption = "Total Income Producing Investment"
            col.Name = "TotalIncProInv"
            infx += 1
            col.VisibleIndex = infx
            col.Visible = True
            col.OptionsColumn.ReadOnly = True
            col.OptionsColumn.TabStop = False

            txt = New RepositoryItemTextEdit
            txt.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            txt.Mask.EditMask = "c"
            txt.Mask.UseMaskAsDisplayFormat = True

            col.ColumnEdit = txt
            col.Width = 150
            col.FieldName = "TotalIncProInv"
            GridView1.Columns.Add(col)

            dt = mdlProcess.Load_interestRestricSchedule(RefNo, YA, SourceNo, "invNon", Errorlog)

            If dt IsNot Nothing Then
                For Each row As DataRow In dt.Rows
                    infx += 1
                    clm = Nothing
                    clm = New System.Data.DataColumn
                    clm.ColumnName = IIf(IsDBNull(row("Item")), "", row("Item")).ToString
                    clm.Caption = "invNon"
                    clm.DefaultValue = 0
                    clm.DataType = Type.GetType("System.Decimal")
                    dsPNL.Tables("REF_INTEREST_RESTRIC_TMP").Columns.Add(clm)

                    '------------------------------------------------------------------

                    col = New DevExpress.XtraGrid.Columns.GridColumn
                    col.Caption = IIf(IsDBNull(row("Item")), "", row("Item")).ToString.Remove(0, 1)
                    col.Name = IIf(IsDBNull(row("Item")), "", row("Item")).ToString
                    col.Tag = "invNon"
                    col.VisibleIndex = infx
                    col.Visible = True
                    txt = New RepositoryItemTextEdit
                    txt.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
                    txt.Mask.EditMask = "c"
                    txt.Mask.UseMaskAsDisplayFormat = True

                    col.ColumnEdit = txt
                    col.Width = 120
                    col.FieldName = IIf(IsDBNull(row("Item")), "", row("Item")).ToString
                    GridView1.Columns.Add(col)
                Next
            End If


            clm = Nothing
            clm = New System.Data.DataColumn
            clm.ColumnName = "TotalIncNonProInv"
            clm.Caption = "Total Income Non Producing Investment"
            clm.DefaultValue = 0
            clm.DataType = Type.GetType("System.Decimal")
            dsPNL.Tables("REF_INTEREST_RESTRIC_TMP").Columns.Add(clm)

            col = New DevExpress.XtraGrid.Columns.GridColumn
            col.Caption = "Total Income Non Producing Investment"
            col.Name = "TotalIncNonProInv"
            infx += 1
            col.VisibleIndex = infx
            col.Visible = True
            col.OptionsColumn.ReadOnly = True
            col.OptionsColumn.TabStop = False

            txt = New RepositoryItemTextEdit
            txt.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            txt.Mask.EditMask = "c"
            txt.Mask.UseMaskAsDisplayFormat = True

            col.ColumnEdit = txt
            col.Width = 150
            col.FieldName = "TotalIncNonProInv"
            GridView1.Columns.Add(col)

            '==============================================================

            clm = Nothing
            clm = New System.Data.DataColumn
            clm.ColumnName = "TotalInv"
            clm.Caption = "Total Investment"
            clm.DefaultValue = 0
            clm.DataType = Type.GetType("System.Decimal")
            dsPNL.Tables("REF_INTEREST_RESTRIC_TMP").Columns.Add(clm)

            col = New DevExpress.XtraGrid.Columns.GridColumn
            col.Caption = "Total Investment"
            col.Name = "TotalInv"
            infx += 1
            col.VisibleIndex = infx
            col.Visible = True
            col.OptionsColumn.ReadOnly = True
            col.OptionsColumn.TabStop = False

            txt = New RepositoryItemTextEdit
            txt.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            txt.Mask.EditMask = "c"
            txt.Mask.UseMaskAsDisplayFormat = True

            col.ColumnEdit = txt
            col.Width = 150
            col.FieldName = "TotalInv"
            GridView1.Columns.Add(col)


            dt = mdlProcess.Load_interestRestricSchedule(RefNo, YA, SourceNo, "Borr", Errorlog)

            If dt IsNot Nothing Then
                For Each row As DataRow In dt.Rows
                    infx += 1
                    clm = Nothing
                    clm = New System.Data.DataColumn
                    clm.ColumnName = IIf(IsDBNull(row("Item")), "", row("Item")).ToString
                    clm.Caption = "Borr"
                    clm.DefaultValue = 0
                    clm.DataType = Type.GetType("System.Decimal")
                    dsPNL.Tables("REF_INTEREST_RESTRIC_TMP").Columns.Add(clm)

                    '------------------------------------------------------------------

                    col = New DevExpress.XtraGrid.Columns.GridColumn
                    col.Caption = IIf(IsDBNull(row("Item")), "", row("Item")).ToString.Remove(0, 1)
                    col.Name = IIf(IsDBNull(row("Item")), "", row("Item")).ToString
                    col.Tag = "Borr"
                    col.VisibleIndex = infx
                    col.Visible = True
                    txt = New RepositoryItemTextEdit
                    txt.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
                    txt.Mask.EditMask = "c"
                    txt.Mask.UseMaskAsDisplayFormat = True

                    col.ColumnEdit = txt
                    col.Width = 120
                    col.FieldName = IIf(IsDBNull(row("Item")), "", row("Item")).ToString
                    GridView1.Columns.Add(col)
                Next
            End If

            '==============================================================

            clm = Nothing
            clm = New System.Data.DataColumn
            clm.ColumnName = "TotalBorr"
            clm.Caption = "Total Borrowing"
            clm.DefaultValue = 0
            clm.DataType = Type.GetType("System.Decimal")
            dsPNL.Tables("REF_INTEREST_RESTRIC_TMP").Columns.Add(clm)

            col = New DevExpress.XtraGrid.Columns.GridColumn
            col.Caption = "Total Borrowing"
            col.Name = "TotalBorr"
            infx += 1
            col.VisibleIndex = infx
            col.Visible = True
            col.OptionsColumn.ReadOnly = True
            col.OptionsColumn.TabStop = False

            txt = New RepositoryItemTextEdit
            txt.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            txt.Mask.EditMask = "c"
            txt.Mask.UseMaskAsDisplayFormat = True

            col.ColumnEdit = txt
            col.Width = 150
            col.FieldName = "TotalBorr"
            GridView1.Columns.Add(col)

            dt = mdlProcess.Load_interestRestricSchedule(RefNo, YA, SourceNo, "Interest", Errorlog)

            If dt IsNot Nothing Then
                For Each row As DataRow In dt.Rows
                    infx += 1
                    clm = Nothing
                    clm = New System.Data.DataColumn
                    clm.ColumnName = IIf(IsDBNull(row("Item")), "", row("Item")).ToString
                    clm.Caption = "Interest"
                    clm.DefaultValue = 0
                    clm.DataType = Type.GetType("System.Decimal")
                    dsPNL.Tables("REF_INTEREST_RESTRIC_TMP").Columns.Add(clm)

                    '------------------------------------------------------------------

                    col = New DevExpress.XtraGrid.Columns.GridColumn
                    col.Caption = IIf(IsDBNull(row("Item")), "", row("Item")).ToString.Remove(0, 1)
                    col.Name = IIf(IsDBNull(row("Item")), "", row("Item")).ToString
                    col.Tag = "Interest"
                    col.VisibleIndex = infx
                    col.Visible = True
                    txt = New RepositoryItemTextEdit
                    txt.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
                    txt.Mask.EditMask = "c"
                    txt.Mask.UseMaskAsDisplayFormat = True

                    col.ColumnEdit = txt
                    col.Width = 120
                    col.FieldName = IIf(IsDBNull(row("Item")), "", row("Item")).ToString
                    GridView1.Columns.Add(col)
                Next
            End If

            '==============================================================

            clm = Nothing
            clm = New System.Data.DataColumn
            clm.ColumnName = "TotalInterest"
            clm.Caption = "Total Expenses"
            clm.DefaultValue = 0
            clm.DataType = Type.GetType("System.Decimal")
            dsPNL.Tables("REF_INTEREST_RESTRIC_TMP").Columns.Add(clm)

            col = New DevExpress.XtraGrid.Columns.GridColumn
            col.Caption = "Total Interest"
            col.Name = "TotalInterest"
            infx += 1
            col.VisibleIndex = infx
            col.Visible = True
            col.OptionsColumn.ReadOnly = True
            col.OptionsColumn.TabStop = False

            txt = New RepositoryItemTextEdit
            txt.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            txt.Mask.EditMask = "c"
            txt.Mask.UseMaskAsDisplayFormat = True

            col.ColumnEdit = txt
            col.Width = 150
            col.FieldName = "TotalInterest"
            GridView1.Columns.Add(col)

            '==============================================================

            clm = Nothing
            clm = New System.Data.DataColumn
            clm.ColumnName = "TotalRestrict"
            clm.Caption = "Interest Restrict"
            clm.DefaultValue = 0
            clm.DataType = Type.GetType("System.Decimal")
            dsPNL.Tables("REF_INTEREST_RESTRIC_TMP").Columns.Add(clm)

            col = New DevExpress.XtraGrid.Columns.GridColumn
            col.Caption = "Total Restrict"
            col.Name = "TotalRestrict"
            infx += 1
            col.VisibleIndex = infx
            col.Visible = True
            col.OptionsColumn.ReadOnly = True
            col.OptionsColumn.TabStop = False

            txt = New RepositoryItemTextEdit
            txt.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            txt.Mask.EditMask = "c"
            txt.Mask.UseMaskAsDisplayFormat = True

            col.ColumnEdit = txt
            col.Width = 150
            col.FieldName = "TotalRestrict"
            GridView1.Columns.Add(col)

            Return True
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return True
        End Try
    End Function

#Region "GENERAL"
    Public Function GetNonAllowanbleExpenses(ByRef dsNonAllowableExpenses As DataSet, Optional ByRef Errorlog As clsError = Nothing) As Decimal
        Try
            'Get Data

            If dsNonAllowableExpenses Is Nothing OrElse dsNonAllowableExpenses.Tables("NonAllowable_Expenses") Is Nothing Then
                If Errorlog Is Nothing Then
                    Errorlog = New clsError
                End If
                With Errorlog
                    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                    .ErrorCode = "000000"
                    .ErrorDateTime = Now
                    .ErrorMessage = "Dataset or datatable not found."
                End With
                Return 0
            End If
            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Clear()
            Dim ds As DataSet = Nothing
            Dim dtRow As DataRow = Nothing
            Dim contrl As Control = Nothing
            Dim obj As Object = Nothing
            Dim NonAllowableExpenses As Decimal = 0

            'EXPOTHERINTEREST
            If P3_docOtherInterestExHirePur IsNot Nothing AndAlso P3_docOtherInterestExHirePur.Controls.Count > 0 Then
                contrl = P3_docOtherInterestExHirePur.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p3OtherInterestExHirePur Then
                    Dim uc As ucPNL_p3OtherInterestExHirePur = CType(contrl, ucPNL_p3OtherInterestExHirePur)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            
            'ProTechManLeganFees
            If P3_docProTechManLeganFees IsNot Nothing AndAlso P3_docProTechManLeganFees.Controls.Count > 0 Then
                contrl = P3_docProTechManLeganFees.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p3ProTechManLeganFees Then
                    Dim uc As ucPNL_p3ProTechManLeganFees = CType(contrl, ucPNL_p3ProTechManLeganFees)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
           
            'TechPayNonResis
            If P3_docTechPayNonResis IsNot Nothing AndAlso P3_docTechPayNonResis.Controls.Count > 0 Then
                contrl = P3_docTechPayNonResis.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p3TechPayNonResis Then
                    Dim uc As ucPNL_p3TechPayNonResis = CType(contrl, ucPNL_p3TechPayNonResis)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
           
            'ContractPay
            If P3_docContractPay IsNot Nothing AndAlso P3_docContractPay.Controls.Count > 0 Then
                contrl = P3_docContractPay.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p3ContractPay Then
                    Dim uc As ucPNL_p3ContractPay = CType(contrl, ucPNL_p3ContractPay)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            
            'DirectorFee
            If P3_docDirectorFee IsNot Nothing AndAlso P3_docDirectorFee.Controls.Count > 0 Then
                contrl = P3_docDirectorFee.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p3DirectorFee Then
                    Dim uc As ucPNL_p3DirectorFee = CType(contrl, ucPNL_p3DirectorFee)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            
            'Salary

            If P3_docSalary IsNot Nothing AndAlso P3_docSalary.Controls.Count > 0 Then
                contrl = P3_docSalary.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p3Salary Then
                    Dim uc As ucPNL_p3Salary = CType(contrl, ucPNL_p3Salary)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            

            'COEStock
            If P3_docCOEStock IsNot Nothing AndAlso P3_docCOEStock.Controls.Count > 0 Then
                contrl = P3_docCOEStock.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p3COEStock Then
                    Dim uc As ucPNL_p3COEStock = CType(contrl, ucPNL_p3COEStock)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            
            'Royalty
            If P3_docRoyalty IsNot Nothing AndAlso P3_docRoyalty.Controls.Count > 0 Then
                contrl = P3_docRoyalty.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p3Royalty Then
                    Dim uc As ucPNL_p3Royalty = CType(contrl, ucPNL_p3Royalty)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            
            'Rental
            If P3_docRental IsNot Nothing AndAlso P3_docRental.Controls.Count > 0 Then
                contrl = P3_docRental.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p3Rental Then
                    Dim uc As ucPNL_p3Rental = CType(contrl, ucPNL_p3Rental)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            
            'RepairMain
            If P3_docRepairMain IsNot Nothing AndAlso P3_docRepairMain.Controls.Count > 0 Then
                contrl = P3_docRepairMain.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p3RepairMain Then
                    Dim uc As ucPNL_p3RepairMain = CType(contrl, ucPNL_p3RepairMain)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            
            'ResearchDev
            If P3_docResearchDev IsNot Nothing AndAlso P3_docResearchDev.Controls.Count > 0 Then
                contrl = P3_docResearchDev.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p3ResearchDev Then
                    Dim uc As ucPNL_p3ResearchDev = CType(contrl, ucPNL_p3ResearchDev)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            
            'PromotionAds
            If P3_docPromotionAds IsNot Nothing AndAlso P3_docPromotionAds.Controls.Count > 0 Then
                contrl = P3_docPromotionAds.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p3PromotionAds Then
                    Dim uc As ucPNL_p3PromotionAds = CType(contrl, ucPNL_p3PromotionAds)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            
            'Travelling
            If P3_docTravelling IsNot Nothing AndAlso P3_docTravelling.Controls.Count > 0 Then
                contrl = P3_docTravelling.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p3Travelling Then
                    Dim uc As ucPNL_p3Travelling = CType(contrl, ucPNL_p3Travelling)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            

            ''ForeignCurrExLoss
            'contrl = P3_docForeignCurrExLoss.Controls(0)

            'If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p3ForeignCurrExLoss Then
            '    Dim uc As ucPNL_p3ForeignCurrExLoss = CType(contrl, ucPNL_p3ForeignCurrExLoss)

            '    ds = uc.DataView_Main

            '    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

            '        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

            '            If IsDBNull(rows(uc.MainKey)) = False Then

            '                obj = Nothing
            '                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

            '                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

            '                    For Each detailsrows As DataRow In obj

            '                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
            '                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
            '                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
            '                            dtRow("KeyName") = uc.Parent.Name
            '                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
            '                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
            '                            dtRow("TitleKeyName") = uc.Parent.Text
            '                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
            '                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
            '                        End If

            '                    Next

            '                Else
            '                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
            '                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
            '                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
            '                        dtRow("KeyName") = uc.Parent.Name
            '                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
            '                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
            '                        dtRow("TitleKeyName") = uc.Parent.Text
            '                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
            '                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
            '                    End If
            '                End If

            '            End If

            '        Next
            '    End If

            'End If

            'JKDM
            If P3_docJKDM IsNot Nothing AndAlso P3_docJKDM.Controls.Count > 0 Then
                contrl = P3_docJKDM.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p3JKDM Then
                    Dim uc As ucPNL_p3JKDM = CType(contrl, ucPNL_p3JKDM)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            
            'Depreciation
            If P3_docDepreciation IsNot Nothing AndAlso P3_docDepreciation.Controls.Count > 0 Then
                contrl = P3_docDepreciation.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p3Depreciation Then
                    Dim uc As ucPNL_p3Depreciation = CType(contrl, ucPNL_p3Depreciation)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            

            'DonationApp
            If P3_docDonationApp IsNot Nothing AndAlso P3_docDonationApp.Controls.Count > 0 Then
                contrl = P3_docDonationApp.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p3DonationApp Then
                    Dim uc As ucPNL_p3DonationApp = CType(contrl, ucPNL_p3DonationApp)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            

            'DonationNonApp
            If P3_docDonationNonApp IsNot Nothing AndAlso P3_docDonationNonApp.Controls.Count > 0 Then
                contrl = P3_docDonationNonApp.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p3DonationNonApp Then
                    Dim uc As ucPNL_p3DonationNonApp = CType(contrl, ucPNL_p3DonationNonApp)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            
            'Zakat
            If p3_docZakat IsNot Nothing AndAlso p3_docZakat.Controls.Count > 0 Then
                contrl = p3_docZakat.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p3Zakat Then
                    Dim uc As ucPNL_p3Zakat = CType(contrl, ucPNL_p3Zakat)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            

            'LossDispFA
            If p4_docLossDispFA IsNot Nothing AndAlso p4_docLossDispFA.Controls.Count > 0 Then
                contrl = p4_docLossDispFA.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p4LossDispFA Then
                    Dim uc As ucPNL_p4LossDispFA = CType(contrl, ucPNL_p4LossDispFA)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            
            'EntNonStaff
            If p4_docEntNonStaff IsNot Nothing AndAlso p4_docEntNonStaff.Controls.Count > 0 Then
                contrl = p4_docEntNonStaff.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p4EntNonStaff Then
                    Dim uc As ucPNL_p4EntNonStaff = CType(contrl, ucPNL_p4EntNonStaff)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
           
            'EntStaff
            If p4_docEntStaff IsNot Nothing AndAlso p4_docEntStaff.Controls.Count > 0 Then
                contrl = p4_docEntStaff.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p4EntStaff Then
                    Dim uc As ucPNL_p4EntStaff = CType(contrl, ucPNL_p4EntStaff)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            

            'Compound
            If p4_docCompound IsNot Nothing AndAlso p4_docCompound.Controls.Count > 0 Then
                contrl = p4_docCompound.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p4Compound Then
                    Dim uc As ucPNL_p4Compound = CType(contrl, ucPNL_p4Compound)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            
            'ProvisionAcc
            If p4_docProvisionAcc IsNot Nothing AndAlso p4_docProvisionAcc.Controls.Count > 0 Then
                contrl = p4_docProvisionAcc.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p4ProvisionAcc Then
                    Dim uc As ucPNL_p4ProvisionAcc = CType(contrl, ucPNL_p4ProvisionAcc)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'LeavePass
            If p4_docLeavePass IsNot Nothing AndAlso p4_docLeavePass.Controls.Count > 0 Then
                contrl = p4_docLeavePass.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p4LeavePass Then
                    Dim uc As ucPNL_p4LeavePass = CType(contrl, ucPNL_p4LeavePass)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            
            'FAWrittenOff
            If p4_docFAWrittenOff IsNot Nothing AndAlso p4_docFAWrittenOff.Controls.Count > 0 Then
                contrl = p4_docFAWrittenOff.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p4FAWrittenOff Then
                    Dim uc As ucPNL_p4FAWrittenOff = CType(contrl, ucPNL_p4FAWrittenOff)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            
            'UnreaLossForeEx
            If p4_docUnreaLossForeEx IsNot Nothing AndAlso p4_docUnreaLossForeEx.Controls.Count > 0 Then
                contrl = p4_docUnreaLossForeEx.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p4UnreaLossForeEx Then
                    Dim uc As ucPNL_p4UnreaLossForeEx = CType(contrl, ucPNL_p4UnreaLossForeEx)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            
            'ReaLossForeExTrade
            If p4_docReaLossForeExTrade IsNot Nothing AndAlso p4_docReaLossForeExTrade.Controls.Count > 0 Then
                contrl = p4_docReaLossForeExTrade.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p4ReaLossForeExTrade Then
                    Dim uc As ucPNL_p4ReaLossForeExTrade = CType(contrl, ucPNL_p4ReaLossForeExTrade)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If

            End If
            
            'ReaLossForeExNonTrade
            If p4_docReaLossForeExNonTrade IsNot Nothing AndAlso p4_docReaLossForeExNonTrade.Controls.Count > 0 Then
                contrl = p4_docReaLossForeExNonTrade.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p4ReaLossForeExNonTrade Then
                    Dim uc As ucPNL_p4ReaLossForeExNonTrade = CType(contrl, ucPNL_p4ReaLossForeExNonTrade)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            

            'InitSub
            If p4_docInitSub IsNot Nothing AndAlso p4_docInitSub.Controls.Count > 0 Then
                contrl = p4_docInitSub.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p4InitSub Then
                    Dim uc As ucPNL_p4InitSub = CType(contrl, ucPNL_p4InitSub)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            

            'CAExpenditure
            If p4_docCAExpenditure IsNot Nothing AndAlso p4_docCAExpenditure.Controls.Count > 0 Then
                contrl = p4_docCAExpenditure.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p4CAExpenditure Then
                    Dim uc As ucPNL_p4CAExpenditure = CType(contrl, ucPNL_p4CAExpenditure)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
            

            'Other
            If p4_docOther IsNot Nothing AndAlso p4_docOther.Controls.Count > 0 Then
                contrl = p4_docOther.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p4Other Then
                    Dim uc As ucPNL_p4Other = CType(contrl, ucPNL_p4Other)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                    For Each detailsrows As DataRow In obj

                                        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                            dtRow("KeyName") = uc.Parent.Name
                                            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainAmount_Details)), 0, detailsrows(uc.MainAmount_Details))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainAmount)), 0, rows(uc.MainAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If
           

            Return NonAllowableExpenses
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function CalcProductofCost(ByVal p1Depreciation As Decimal, ByVal p1AllowanceExpenses As Decimal, ByVal p1NonAllowableExpenses As Decimal, Optional ByRef Errorlog As clsError = Nothing) As Decimal
        Try
            Dim subTotal As Decimal = p1Depreciation + p1AllowanceExpenses + p1NonAllowableExpenses
            Return subTotal
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function CalcPurchaseProductofCost(ByVal p1Purchase As Decimal, ByVal p1COP As Decimal, Optional ByRef Errorlog As clsError = Nothing) As Decimal
        Try
            Dim subTotal As Decimal = p1Purchase + p1COP
            Return subTotal
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function CalcGrossProfitLoss(ByVal p1Sales As Decimal, ByVal p1COS As Decimal, Optional ByRef Errorlog As clsError = Nothing) As Decimal
        Try
            Dim subTotal As Decimal = p1Sales - p1COS
            Return subTotal
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function CalcNonBizIncome(ByVal p2DividendInc As Decimal, ByVal p2InterestInc As Decimal, _
                                     ByVal p2RentalInc As Decimal, ByVal p2RoyaltyInc As Decimal, _
                                     ByVal p2OtherInc As Decimal, Optional ByRef Errorlog As clsError = Nothing) As Decimal
        Try
            Dim subTotal As Decimal = p2DividendInc + p2InterestInc + p2RentalInc + p2RoyaltyInc + p2OtherInc
            Return subTotal
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function CalcExpenses(ByVal p3ForeignCurrExLoss As Decimal, ByVal p3OtherInterestExHirePur As Decimal, ByVal p3ProTechManLeganFees As Decimal, ByVal p3TechPayNonResis As Decimal, ByVal p3ContractPay As Decimal, ByVal p3DirectorFee As Decimal, ByVal p3Salary As Decimal, ByVal p3COEStock As Decimal, ByVal p3Royalty As Decimal, ByVal p3Rental As Decimal, ByVal p3RepairMain As Decimal, ByVal p3ResearchDev As Decimal, ByVal p3PromotionAds As Decimal, ByVal p3Travelling As Decimal, ByVal p3JKDM As Decimal, ByVal p3InterestResPurS33 As Decimal, ByVal p4TotalOtherExpenses As Decimal, ByRef BalacingFigure As Decimal, ByRef NonAllowableExpenses As Decimal, Optional ByRef Errorlog As clsError = Nothing) As Decimal
        Try
            'Dim p3ContractPay As Decimal = IIf(IsNumeric(txt_p3Depreciation.EditValue) = False, 0, txt_p3Depreciation.EditValue)
            'Dim p3DirectorFee As Decimal = IIf(IsNumeric(txt_p3Depreciation.EditValue) = False, 0, txt_p3Depreciation.EditValue)
            NonAllowableExpenses = mdlPNL.GetNonAllowanbleExpenses(dsDataSet, Errorlog)

            Dim subTotal As Decimal = p3ForeignCurrExLoss + p3OtherInterestExHirePur + p3ProTechManLeganFees + p3TechPayNonResis + p3ContractPay + p3DirectorFee + p3Salary + p3COEStock + p3Royalty + p3Rental + p3RepairMain + p3ResearchDev + p3PromotionAds + p3Travelling + p3JKDM + p3InterestResPurS33 + p4TotalOtherExpenses

            Return subTotal
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function CalcOtherExpenses(ByVal p3Depreciation As Decimal, ByVal p3DonationApp As Decimal, _
                                     ByVal p3DonationNonApp As Decimal, ByVal p3Zakat As Decimal, _
                                     ByVal p4EntNonStaff As Decimal, _
                                     ByVal p4EntStaff As Decimal, ByVal p4Compound As Decimal, _
                                     ByVal p4ProvisionAcc As Decimal, ByVal p4LeavePass As Decimal, _
                                     ByVal p4FAWrittenOff As Decimal, ByVal p4UnreaLossForeEx As Decimal, _
                                     ByVal p4ReaLossForeExTrade As Decimal, ByVal p4ReaLossForeExNonTrade As Decimal, _
                                     ByVal p4InitSub As Decimal, ByVal p4CAExpenditure As Decimal, _
                                     ByVal p4Other As Decimal, ByVal p4LossDispFA As Decimal, Optional ByRef Errorlog As clsError = Nothing) As Decimal
        Try
            Dim subTotal As Decimal = p3Depreciation + p3DonationApp + p3DonationNonApp + p3Zakat + p4EntNonStaff + p4EntStaff + p4Compound + p4ProvisionAcc + p4LeavePass + p4FAWrittenOff + p4UnreaLossForeEx + p4ReaLossForeExTrade + p4ReaLossForeExNonTrade + p4InitSub + p4CAExpenditure + p4Other + p4LossDispFA

            Return subTotal
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function CalcNonTaxProfit(ByVal p2ProDispPlantEq As Decimal, ByVal p2Other As Decimal, _
                                     ByVal p2ExemptDividend As Decimal, ByVal p2ForeIncomeRemmit As Decimal, _
                                     ByVal p2ReaForeExGainNonTrade As Decimal, ByVal p2UnreaGainForeEx As Decimal, _
                                     ByVal p2UnreaGainForeExNon As Decimal, ByVal p2ProDisInvestment As Decimal, Optional ByRef Errorlog As clsError = Nothing) As Decimal
        Try
            Dim subTotal As Decimal = p2ProDispPlantEq + p2Other + p2ExemptDividend + p2ForeIncomeRemmit + p2ReaForeExGainNonTrade + p2UnreaGainForeEx + p2UnreaGainForeExNon + p2ProDisInvestment
            Return subTotal
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function CalcCostOfSales(ByVal p1OpenStock As Decimal, ByVal p1CloseStock As Decimal, ByVal p1PCP As Decimal, Optional ByRef Errorlog As clsError = Nothing) As Decimal
        Try
            Dim subTotal As Decimal = (p1OpenStock + p1PCP) - p1CloseStock
            Return subTotal
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function CalcTotalofViewRental(ByRef txtName As DevExpress.XtraEditors.TextEdit, ByRef ds As DataSet, _
                                    ByVal TableName As String, ByVal ColumnName As String, _
                                    ByVal CurrentAmount As Decimal, Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            Dim obj As Object = ds.Tables(TableName).Compute("sum(" & ColumnName & ")", "RI_STATUS4d ='Section 4d'")

            If obj IsNot Nothing AndAlso IsNumeric(obj) Then
                txtName.EditValue = CDec(obj) + CurrentAmount
            Else
                txtName.EditValue = CurrentAmount
            End If

            Return True
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return True
        End Try
    End Function
    Public Function CalcTotalofView(ByRef txtName As DevExpress.XtraEditors.TextEdit, ByRef ds As DataSet, _
                                    ByVal TableName As String, ByVal ColumnName As String, _
                                    ByVal CurrentAmount As Decimal, Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            Dim obj As Object = ds.Tables(TableName).Compute("sum(" & ColumnName & ")", "")

            If obj IsNot Nothing AndAlso IsNumeric(obj) Then
                txtName.EditValue = CDec(obj) + CurrentAmount
            Else
                txtName.EditValue = CurrentAmount
            End If

            Return True
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return True
        End Try
    End Function
    Public Function MappingSourceNo(ByVal TableName As String, ByVal TableName_Details As String, ByVal ColumnName_Key As String, _
                                        ByVal ColumnNameDetails_Key As String, ByVal Column_SourceNo As String, ByVal ColumnDetails_SourceNo As String, _
                                        ByRef ds As DataSet, Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            If ds IsNot Nothing Then
                Dim obj As Object = Nothing
                Dim dtRow As DataRow = Nothing
                For i As Integer = 0 To ds.Tables(TableName).Rows.Count - 1
                    obj = ds.Tables(TableName_Details).Select(ColumnNameDetails_Key & "=" & ds.Tables(TableName).Rows(i)(ColumnName_Key))

                    If obj IsNot Nothing Then
                        Dim ListofRow() As DataRow = obj
                        For x As Integer = 0 To ListofRow.Count - 1
                            dtRow = ListofRow(x)
                            dtRow(ColumnDetails_SourceNo) = ds.Tables(TableName).Rows(i)(Column_SourceNo)
                        Next

                    End If
                Next

            End If
            Return True
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return True
        End Try
    End Function
    Public Function reCalc_SubTotalView(ByVal TableName As String, ByVal TableName_Details As String, ByVal ColumnName_Key As String, _
                                        ByVal ColumnNameDetails_Key As String, ByVal Column_Total As String, ByVal ColumnDetails_Total As String, _
                                        ByRef ds As DataSet, Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            If ds IsNot Nothing Then
                Dim obj As Object = Nothing

                For i As Integer = 0 To ds.Tables(TableName).Rows.Count - 1
                    obj = ds.Tables(TableName_Details).Compute("Sum(" & ColumnDetails_Total & ")", ColumnNameDetails_Key & " =" & ds.Tables(TableName).Rows(i)(ColumnName_Key))

                    If obj IsNot Nothing AndAlso IsNumeric(obj) Then
                        ds.Tables(TableName).Rows(i)(Column_Total) = CDec(obj)
                    End If

                Next

            End If


            Return True
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return True
        End Try
    End Function
    Public Function DisableAmountIfGotChild(ByVal TableName As String, ByVal ColumnName_key As String, ByVal ColumnNameDetails_key As String, _
                                            ByVal DetailsColumnName As String, ByRef view1 As DevExpress.XtraGrid.Views.Grid.GridView, ByRef ds As DataSet, _
                                            Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            Dim parentkey As Integer = 0
            Dim obj As Object = Nothing
            For i As Integer = 0 To view1.RowCount - 1

                If i = view1.FocusedRowHandle Then
                    parentkey = view1.GetDataRow(i)(ColumnName_key)

                    obj = ds.Tables(TableName).Compute("count(" & ColumnNameDetails_key & ")", ColumnNameDetails_key & " =" & parentkey)

                    If obj IsNot Nothing AndAlso IsNumeric(obj) AndAlso CInt(obj) > 0 Then
                        view1.GetDataRow(i)(DetailsColumnName) = "Yes"
                        Return True
                    Else
                        view1.GetDataRow(i)(DetailsColumnName) = "No"
                        Return False
                    End If

                End If

            Next
            Return False
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return False
        End Try
    End Function
    Public Function SumSubTotalViewRow(ByVal TableName_Details As String, ByVal ColumnName_key As String, ByVal ColumnNameDetails_key As String, _
                                       ByVal ColumnName_Amount As String, ByVal ColumnNameDetails_Amount As String, _
                                       ByRef view1 As DevExpress.XtraGrid.Views.Grid.GridView, ByRef view2 As DevExpress.XtraGrid.Views.Grid.GridView, _
                                       ByRef ds As DataSet, ByRef currentrow As DataRow, Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            If IsDBNull(currentrow(ColumnNameDetails_key)) = False Then
                Dim parentkey As Integer = CInt(currentrow(ColumnNameDetails_key))
                Dim Total As Decimal = 0
                Dim obj As Object = Nothing
                For i As Integer = 0 To view1.RowCount - 1
                    If view1.GetDataRow(i)(ColumnName_key) = parentkey Then

                        obj = ds.Tables(TableName_Details).Compute("Sum(" & ColumnNameDetails_Amount & ")", ColumnNameDetails_key & " =" & parentkey)

                        If obj IsNot Nothing AndAlso IsNumeric(obj) Then
                            Total = CDec(obj)
                            view1.GetDataRow(i)(ColumnName_Amount) = Total + CDec(currentrow(ColumnNameDetails_Amount))
                        Else
                            view1.GetDataRow(i)(ColumnName_Amount) = CDec(currentrow(ColumnNameDetails_Amount))
                        End If

                        currentrow("PLFSD_SOURCENO") = view1.GetDataRow(i)("PLFS_SOURCENO")
                        Exit For
                    End If
                Next

                'Dim x As DataRow = GridView1.GetDataSourceRowIndex 
                '   MsgBox(GridView1.GetRelationIndex(parentkey, "PLFST_SALES_DETAIL_PLFST_SALES"))
            End If

            Return True
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return True
        End Try
    End Function
#End Region
End Module
Class clsPNL_LabelName
    Public LabelName As String = Nothing
    Public LabelText As String = Nothing
    Public LabelTricor As String = Nothing
    Public Type As TaxComPNLEnuItem = TaxComPNLEnuItem.CLOSESTOCK

    Sub New()

    End Sub

    Sub New(ByVal LabeName_ As String, ByVal LabelText_ As String, ByVal LabelTricor_ As String, ByVal Type_ As TaxComPNLEnuItem)
        LabelName = LabeName_
        LabelText = LabelText_
        LabelTricor = LabelTricor_
        Type = Type_
    End Sub
End Class
