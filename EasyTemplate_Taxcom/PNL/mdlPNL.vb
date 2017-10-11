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
                        doc = DockDocument.View.AddDocument(P1_docSales)
                    End If

                    DockDocument.View.ActivateDocument(P1_docSales)

                Case TaxComPNLEnuItem.OPENSTOCK
                    If P1_docOpeningStock Is Nothing Then
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
                    If P1_docPurchase Is Nothing Then
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
                    If P1_docDepreciation Is Nothing Then
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
                    If P1_docAllowanceExpenses Is Nothing Then
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
                    If P1_docNonAllowableExpenses Is Nothing Then
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
                    If P1_docCloseStock Is Nothing Then
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
                    If P2_docOtherBizIncome Is Nothing Then
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
                    If P2_docForeignCurrExGain Is Nothing Then
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
                    If P2_docInterestIncome Is Nothing Then
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
                    If P2_docRoyaltyIncome Is Nothing Then
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
                    If P2_docOtherIncome Is Nothing Then
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
                    If P2_docProDispPlantEq Is Nothing Then
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
                    If P2_docProDisInvestment Is Nothing Then
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
                    If P2_docForeIncomeRemmit Is Nothing Then
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
                    If P2_docReaForeExGainNonTrade Is Nothing Then
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
                    If P2_docUnreaGainForeEx Is Nothing Then
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
                    If P2_docUnreaGainForeExNon Is Nothing Then
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
                    If P3_docOtherInterestExHirePur Is Nothing Then
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
                    If P3_docProTechManLeganFees Is Nothing Then
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
                    If P3_docTechPayNonResis Is Nothing Then
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
                    If P3_docContractPay Is Nothing Then
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
                    If P3_docDirectorFee Is Nothing Then
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
                    If P3_docSalary Is Nothing Then
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
                    If P3_docCOEStock Is Nothing Then
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
                    If P3_docRoyalty Is Nothing Then
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
                    If P3_docRental Is Nothing Then
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
                    If P3_docRepairMain Is Nothing Then
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
                    If P3_docResearchDev Is Nothing Then
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
                    If P3_docPromotionAds Is Nothing Then
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
                    If P3_docTravelling Is Nothing Then
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
                    If P3_docJKDM Is Nothing Then
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
                    If P3_docDepreciation Is Nothing Then
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
                    If P3_docDonationApp Is Nothing Then
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
                    If P3_docDonationNonApp Is Nothing Then
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
                    If p3_docZakat Is Nothing Then
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
                    If p4_docLossDispFA Is Nothing Then
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
                    If p4_docEntNonStaff Is Nothing Then
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
                    If p4_docEntStaff Is Nothing Then
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
                    If p4_docCompound Is Nothing Then
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
                    If p4_docProvisionAcc Is Nothing Then
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
                    If p4_docLeavePass Is Nothing Then
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
                    If p4_docFAWrittenOff Is Nothing Then
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
                    If p4_docUnreaLossForeEx Is Nothing Then
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
                    If p4_docReaLossForeExTrade Is Nothing Then
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
                    If p4_docReaLossForeExNonTrade Is Nothing Then
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
                    If p4_docInitSub Is Nothing Then
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
                    If p4_docCAExpenditure Is Nothing Then
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
                    If p4_docOther Is Nothing Then
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
                    If P2_docRentalIncome Is Nothing Then
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
                    If p4_docNonAllowableExpenses Is Nothing Then
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
                    If P2_docOther Is Nothing Then
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
                    If P2_docExemptDividend Is Nothing Then
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
                    If P3_docInterestResPurS33 Is Nothing Then
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
                    If P2_docDivIncome Is Nothing Then
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
    Public Function PNL_GetSaveData(ByVal PNL_Key As Decimal, ByVal Type As TaxComPNLEnuItem, _
                                    ByVal oConn As SqlConnection, ByRef ListofCmd As List(Of SqlCommand), Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            Dim contrl As Control = Nothing
            Dim ds As DataSet = Nothing

            Select Case Type

                Case TaxComPNLEnuItem.DEPRECIATION
                    If P1_docDepreciation IsNot Nothing AndAlso P1_docDepreciation.Controls.Count > 0 Then
                        contrl = P1_docDepreciation.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1Depreciation = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p1Depreciation = CType(contrl, ucPNL_p1Depreciation)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_DEPRECIATION(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.SALES
                    If P1_docSales IsNot Nothing AndAlso P1_docSales.Controls.Count > 0 Then
                        contrl = P1_docSales.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1Sales = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p1Sales = CType(contrl, ucPNL_p1Sales)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_PLFST_SALES(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.OPENSTOCK
                    If P1_docOpeningStock IsNot Nothing AndAlso P1_docOpeningStock.Controls.Count > 0 Then
                        contrl = P1_docOpeningStock.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1OpeningStock = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p1OpeningStock = CType(contrl, ucPNL_p1OpeningStock)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_PLFST_OPENSTOCK(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.PURCHASE
                    If P1_docPurchase IsNot Nothing AndAlso P1_docPurchase.Controls.Count > 0 Then
                        contrl = P1_docPurchase.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1Purchase = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p1Purchase = CType(contrl, ucPNL_p1Purchase)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_PLFST_PURCHASE(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.OTHERALLOWEXP
                    If P1_docAllowanceExpenses IsNot Nothing AndAlso P1_docAllowanceExpenses.Controls.Count > 0 Then
                        contrl = P1_docAllowanceExpenses.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1AllowanceExpenses = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p1AllowanceExpenses = CType(contrl, ucPNL_p1AllowanceExpenses)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_ALLOW(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.OTHERNONALLOWEXP
                    If P1_docNonAllowableExpenses IsNot Nothing AndAlso P1_docNonAllowableExpenses.Controls.Count > 0 Then
                        contrl = P1_docNonAllowableExpenses.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1NonAllowableExpenses = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p1NonAllowableExpenses = CType(contrl, ucPNL_p1NonAllowableExpenses)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_NONALLOW(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.CLOSESTOCK
                    If P1_docCloseStock IsNot Nothing AndAlso P1_docCloseStock.Controls.Count > 0 Then
                        contrl = P1_docCloseStock.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1CloseStock = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p1CloseStock = CType(contrl, ucPNL_p1CloseStock)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_PLFST_CLOSESTOCK(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.OTHERBUSINC
                    If P2_docOtherBizIncome IsNot Nothing AndAlso P2_docOtherBizIncome.Controls.Count > 0 Then
                        contrl = P2_docOtherBizIncome.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2OtherBizIncome = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2OtherBizIncome = CType(contrl, ucPNL_p2OtherBizIncome)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_NONSOURCE_BUSINESSINCOME(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.REALFETRADE
                    If P2_docForeignCurrExGain IsNot Nothing AndAlso P2_docForeignCurrExGain.Controls.Count > 0 Then
                        contrl = P2_docForeignCurrExGain.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ForeignCurrExGain = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2ForeignCurrExGain = CType(contrl, ucPNL_p2ForeignCurrExGain)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_INCOME_REALFET(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.INTERESTINC
                    If P2_docInterestIncome IsNot Nothing AndAlso P2_docInterestIncome.Controls.Count > 0 Then
                        contrl = P2_docInterestIncome.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2InterestIncome = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2InterestIncome = CType(contrl, ucPNL_p2InterestIncome)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_INCOME_NBINTEREST(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.RENTALINC
                    If P2_docRentalIncome IsNot Nothing AndAlso P2_docRentalIncome.Controls.Count > 0 Then
                        contrl = P2_docRentalIncome.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2RentalIncome = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2RentalIncome = CType(contrl, ucPNL_p2RentalIncome)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_RENTAL_INCOME(PNL_Key, ds.Tables(uc.MainTable), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.ROYALTYINC
                    If P2_docRoyaltyIncome IsNot Nothing AndAlso P2_docRoyaltyIncome.Controls.Count > 0 Then
                        contrl = P2_docRoyaltyIncome.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2RoyaltyIncome = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2RoyaltyIncome = CType(contrl, ucPNL_p2RoyaltyIncome)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_INCOME_NBROYALTY(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.OTHERINC
                    If P2_docOtherIncome IsNot Nothing AndAlso P2_docOtherIncome.Controls.Count > 0 Then
                        contrl = P2_docOtherIncome.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2OtherIncome = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2OtherIncome = CType(contrl, ucPNL_p2OtherIncome)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_INCOME(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.PDFIXASSET
                    If P2_docProDispPlantEq IsNot Nothing AndAlso P2_docProDispPlantEq.Controls.Count > 0 Then
                        contrl = P2_docProDispPlantEq.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ProDispPlantEq = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2ProDispPlantEq = CType(contrl, ucPNL_p2ProDispPlantEq)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_INCOME_NTDISPOSALFA(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.PDINVEST
                    If P2_docProDisInvestment IsNot Nothing AndAlso P2_docProDisInvestment.Controls.Count > 0 Then
                        contrl = P2_docProDisInvestment.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ProDisInvestment = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2ProDisInvestment = CType(contrl, ucPNL_p2ProDisInvestment)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_INCOME_NTDISPOSALINVEST(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.EXEMDIV
                    If P2_docExemptDividend IsNot Nothing AndAlso P2_docExemptDividend.Controls.Count > 0 Then
                        contrl = P2_docExemptDividend.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ExemptDividend = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2ExemptDividend = CType(contrl, ucPNL_p2ExemptDividend)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXEMPT_DIVIDEND(PNL_Key, ds.Tables(uc.MainTable), oConn, ListofCmd, Errorlog)
                    End If


                Case TaxComPNLEnuItem.FORINCREMIT
                    If P2_docForeIncomeRemmit IsNot Nothing AndAlso P2_docForeIncomeRemmit.Controls.Count > 0 Then
                        contrl = P2_docForeIncomeRemmit.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ForeIncomeRemmit = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2ForeIncomeRemmit = CType(contrl, ucPNL_p2ForeIncomeRemmit)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_INCOME_NTFOREIGNINCREM(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.REALFE
                    If P2_docUnreaGainForeEx IsNot Nothing AndAlso P2_docUnreaGainForeEx.Controls.Count > 0 Then
                        contrl = P2_docUnreaGainForeEx.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2UnreaGainForeEx = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2UnreaGainForeEx = CType(contrl, ucPNL_p2UnreaGainForeEx)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_INCOME_NTUREALFET(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.UNREALFENONTRADE
                    If P2_docReaForeExGainNonTrade IsNot Nothing AndAlso P2_docReaForeExGainNonTrade.Controls.Count > 0 Then
                        contrl = P2_docReaForeExGainNonTrade.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ReaForeExGainNonTrade = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2ReaForeExGainNonTrade = CType(contrl, ucPNL_p2ReaForeExGainNonTrade)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_INCOME_NTREALFE(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.UNREALFETRADE
                    If P2_docUnreaGainForeExNon IsNot Nothing AndAlso P2_docUnreaGainForeExNon.Controls.Count > 0 Then
                        contrl = P2_docUnreaGainForeExNon.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2UnreaGainForeExNon = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2UnreaGainForeExNon = CType(contrl, ucPNL_p2UnreaGainForeExNon)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_INCOME_NTUREALFENT(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.OTHERNONTAXINC
                    If P2_docOther IsNot Nothing AndAlso P2_docOther.Controls.Count > 0 Then
                        contrl = P2_docOther.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2Other = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2Other = CType(contrl, ucPNL_p2Other)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_NON_TAXABLE_INCOME(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.INTERESTRESTRICT
                    If P3_docInterestResPurS33 IsNot Nothing AndAlso P3_docInterestResPurS33.Controls.Count > 0 Then
                        contrl = P3_docInterestResPurS33.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3InterestResPurS33 = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3InterestResPurS33 = CType(contrl, ucPNL_p3InterestResPurS33)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_INTERESTRESTRICT(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPOTHERINTEREST
                    If P3_docOtherInterestExHirePur IsNot Nothing AndAlso P3_docOtherInterestExHirePur.Controls.Count > 0 Then
                        contrl = P3_docOtherInterestExHirePur.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3OtherInterestExHirePur = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3OtherInterestExHirePur = CType(contrl, ucPNL_p3OtherInterestExHirePur)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_INTEREST(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPLEGAL
                    If P3_docProTechManLeganFees IsNot Nothing AndAlso P3_docProTechManLeganFees.Controls.Count > 0 Then
                        contrl = P3_docProTechManLeganFees.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3ProTechManLeganFees = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3ProTechManLeganFees = CType(contrl, ucPNL_p3ProTechManLeganFees)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_LEGAL(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPTECHNICAL
                    If P3_docTechPayNonResis IsNot Nothing AndAlso P3_docTechPayNonResis.Controls.Count > 0 Then
                        contrl = P3_docTechPayNonResis.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3TechPayNonResis = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3TechPayNonResis = CType(contrl, ucPNL_p3TechPayNonResis)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_TECH_FEE(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPCONTRACTPAY
                    If P3_docContractPay IsNot Nothing AndAlso P3_docContractPay.Controls.Count > 0 Then
                        contrl = P3_docContractPay.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3ContractPay = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3ContractPay = CType(contrl, ucPNL_p3ContractPay)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_CONTRACT(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPDIRECTORFEE
                    If P3_docDirectorFee IsNot Nothing AndAlso P3_docDirectorFee.Controls.Count > 0 Then
                        contrl = P3_docDirectorFee.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3DirectorFee = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3DirectorFee = CType(contrl, ucPNL_p3DirectorFee)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_DIRECTORS_FEE(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPSALARY
                    If P3_docSalary IsNot Nothing AndAlso P3_docSalary.Controls.Count > 0 Then
                        contrl = P3_docSalary.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Salary = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3Salary = CType(contrl, ucPNL_p3Salary)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_SALARY(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPEMPLOYEESTOCK
                    If P3_docCOEStock IsNot Nothing AndAlso P3_docCOEStock.Controls.Count > 0 Then
                        contrl = P3_docCOEStock.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3COEStock = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3COEStock = CType(contrl, ucPNL_p3COEStock)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_EMPL_STOCK(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPROYALTY
                    If P3_docRoyalty IsNot Nothing AndAlso P3_docRoyalty.Controls.Count > 0 Then
                        contrl = P3_docRoyalty.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Royalty = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3Royalty = CType(contrl, ucPNL_p3Royalty)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_ROYALTY(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPRENTAL
                    If P3_docRental IsNot Nothing AndAlso P3_docRental.Controls.Count > 0 Then
                        contrl = P3_docRental.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Rental = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3Rental = CType(contrl, ucPNL_p3Rental)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_RENTAL(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPREPAIRMAINTENANCE
                    If P3_docRepairMain IsNot Nothing AndAlso P3_docRepairMain.Controls.Count > 0 Then
                        contrl = P3_docRepairMain.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3RepairMain = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3RepairMain = CType(contrl, ucPNL_p3RepairMain)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_REPAIR(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPRND
                    If P3_docResearchDev IsNot Nothing AndAlso P3_docResearchDev.Controls.Count > 0 Then
                        contrl = P3_docResearchDev.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3ResearchDev = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3ResearchDev = CType(contrl, ucPNL_p3ResearchDev)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_RESEARCH(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPADVERTISEMENT
                    If P3_docPromotionAds IsNot Nothing AndAlso P3_docPromotionAds.Controls.Count > 0 Then
                        contrl = P3_docPromotionAds.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3PromotionAds = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3PromotionAds = CType(contrl, ucPNL_p3PromotionAds)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_PROMOTE(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPTRAVEL
                    If P3_docTravelling IsNot Nothing AndAlso P3_docTravelling.Controls.Count > 0 Then
                        contrl = P3_docTravelling.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Travelling = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3Travelling = CType(contrl, ucPNL_p3Travelling)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_TRAVEL(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPJKDM
                    If P3_docJKDM IsNot Nothing AndAlso P3_docJKDM.Controls.Count > 0 Then
                        contrl = P3_docJKDM.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3JKDM = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3JKDM = CType(contrl, ucPNL_p3JKDM)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_JKDM(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPDEPRECIATION
                    If P3_docDepreciation IsNot Nothing AndAlso P3_docDepreciation.Controls.Count > 0 Then
                        contrl = P3_docDepreciation.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Depreciation = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3Depreciation = CType(contrl, ucPNL_p3Depreciation)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXDEPRECIATION(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPDONATIONAPPR
                    If P3_docDonationApp IsNot Nothing AndAlso P3_docDonationApp.Controls.Count > 0 Then
                        contrl = P3_docDonationApp.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3DonationApp = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3DonationApp = CType(contrl, ucPNL_p3DonationApp)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXAPPRDONATION(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPDONATIONNONAPPR
                    If P3_docDonationNonApp IsNot Nothing AndAlso P3_docDonationNonApp.Controls.Count > 0 Then
                        contrl = P3_docDonationNonApp.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3DonationNonApp = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3DonationNonApp = CType(contrl, ucPNL_p3DonationNonApp)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXNAPPRDONATION(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPZAKAT
                    If p3_docZakat IsNot Nothing AndAlso p3_docZakat.Controls.Count > 0 Then
                        contrl = p3_docZakat.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Zakat = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3Zakat = CType(contrl, ucPNL_p3Zakat)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXZAKAT(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPLOSSDISPFA
                    If p4_docLossDispFA IsNot Nothing AndAlso p4_docLossDispFA.Controls.Count > 0 Then
                        contrl = p4_docLossDispFA.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4LossDispFA = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4LossDispFA = CType(contrl, ucPNL_p4LossDispFA)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXLOSSDISPOSALFA(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If


                Case TaxComPNLEnuItem.EXPENTERTAINNONSTAFF
                    If p4_docEntNonStaff IsNot Nothing AndAlso p4_docEntNonStaff.Controls.Count > 0 Then
                        contrl = p4_docEntNonStaff.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4EntNonStaff = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4EntNonStaff = CType(contrl, ucPNL_p4EntNonStaff)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_ENTERTAINNSTAFF(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPENTERTAINSTAFF
                    If p4_docEntStaff IsNot Nothing AndAlso p4_docEntStaff.Controls.Count > 0 Then
                        contrl = p4_docEntStaff.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4EntStaff = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4EntStaff = CType(contrl, ucPNL_p4EntStaff)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_ENTERTAINSTAFF(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPCOMPAUNDPENALTY
                    If p4_docCompound IsNot Nothing AndAlso p4_docCompound.Controls.Count > 0 Then
                        contrl = p4_docCompound.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4Compound = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4Compound = CType(contrl, ucPNL_p4Compound)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXPENALTY(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.EXPPROVISION
                    If p4_docProvisionAcc IsNot Nothing AndAlso p4_docProvisionAcc.Controls.Count > 0 Then
                        contrl = p4_docProvisionAcc.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4ProvisionAcc = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4ProvisionAcc = CType(contrl, ucPNL_p4ProvisionAcc)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXPROVISIONACC(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.EXPLEAVEPASSAGE
                    If p4_docLeavePass IsNot Nothing AndAlso p4_docLeavePass.Controls.Count > 0 Then
                        contrl = p4_docLeavePass.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4LeavePass = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4LeavePass = CType(contrl, ucPNL_p4LeavePass)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXLEAVEPASSAGE(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.EXPFAWRITTENOFF
                    If p4_docFAWrittenOff IsNot Nothing AndAlso p4_docFAWrittenOff.Controls.Count > 0 Then
                        contrl = p4_docFAWrittenOff.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4FAWrittenOff = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4FAWrittenOff = CType(contrl, ucPNL_p4FAWrittenOff)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXFAWRITTENOFF(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If 

                Case TaxComPNLEnuItem.EXPUNREALLOSSFE
                    If p4_docUnreaLossForeEx IsNot Nothing AndAlso p4_docUnreaLossForeEx.Controls.Count > 0 Then
                        contrl = p4_docUnreaLossForeEx.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4UnreaLossForeEx = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4UnreaLossForeEx = CType(contrl, ucPNL_p4UnreaLossForeEx)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXURLOSSFOREIGN(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPREALLOSSFETRADE
                    If p4_docReaLossForeExTrade IsNot Nothing AndAlso p4_docReaLossForeExTrade.Controls.Count > 0 Then
                        contrl = p4_docReaLossForeExTrade.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4ReaLossForeExTrade = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4ReaLossForeExTrade = CType(contrl, ucPNL_p4ReaLossForeExTrade)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXRLOSSFOREIGNT(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPREALLOSSFENONTRADE
                    If p4_docReaLossForeExNonTrade IsNot Nothing AndAlso p4_docReaLossForeExNonTrade.Controls.Count > 0 Then
                        contrl = p4_docReaLossForeExNonTrade.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4ReaLossForeExNonTrade = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4ReaLossForeExNonTrade = CType(contrl, ucPNL_p4ReaLossForeExNonTrade)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXRLOSSFOREIGN(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPINITIALSUBSCRIPT
                    If p4_docInitSub IsNot Nothing AndAlso p4_docInitSub.Controls.Count > 0 Then
                        contrl = p4_docInitSub.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4InitSub = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4InitSub = CType(contrl, ucPNL_p4InitSub)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXINITIALSUB(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If  

                Case TaxComPNLEnuItem.EXPCAPITALEXPENDITURE
                    If p4_docCAExpenditure IsNot Nothing AndAlso p4_docCAExpenditure.Controls.Count > 0 Then
                        contrl = p4_docCAExpenditure.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4CAExpenditure = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4CAExpenditure = CType(contrl, ucPNL_p4CAExpenditure)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXCAPITALEXP(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If  

                Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
                    If p4_docOther IsNot Nothing AndAlso p4_docOther.Controls.Count > 0 Then
                        contrl = p4_docOther.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4Other = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4Other = CType(contrl, ucPNL_p4Other)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXPENSES(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

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
        End Try
    End Function
    Public Function PNL_GetData(ByVal PNL_KEY As Decimal, ByVal Type As TaxComPNLEnuItem, ByRef ds As DataSet, ByRef ds2 As DataSet, Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Dim strError As String = Nothing
        Try

            Dim dt As DataTable = Nothing
            Dim dtRow As DataRow = Nothing
            strError = Type.ToString
            Select Case Type
                Case TaxComPNLEnuItem.SALES
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_PLFST_SALES(PNL_KEY, Errorlog)

                    ds.Tables("PLFST_SALES").Rows.Clear()
                    ds.Tables("PLFST_SALES_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("PLFST_SALES").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_PLFST_SALES_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("PLFST_SALES_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.OPENSTOCK
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_PLFST_OPENSTOCK(PNL_KEY, Errorlog)

                    ds.Tables("PLFST_OPENSTOCK").Rows.Clear()
                    ds.Tables("PLFST_OPENSTOCK_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("PLFST_OPENSTOCK").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_PLFST_OPENSTOCK_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("PLFST_OPENSTOCK_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.PURCHASE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_PLFST_PURCHASE(PNL_KEY, Errorlog)

                    ds.Tables("PLFST_PURCHASE").Rows.Clear()
                    ds.Tables("PLFST_PURCHASE_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("PLFST_PURCHASE").NewRow
                            dtRow("PLFPUR_KEY") = rowx("PLFPUR_KEY")
                            dtRow("PLFPUR_PLFPURKEY") = rowx("PLFPUR_PLFPURKEY")
                            dtRow("PLFPUR_SOURCENO") = rowx("PLFPUR_SOURCENO")
                            dtRow("PLFPUR_DESC") = rowx("PLFPUR_DESC")
                            dtRow("PLFPUR_AMOUNT") = rowx("PLFPUR_AMOUNT")
                            dtRow("PLFPUR_NOTE") = rowx("PLFPUR_NOTE")
                            dtRow("PLFPUR_DETAIL") = rowx("PLFPUR_DETAIL")
                            If IsDBNull(rowx("PLFPUR_DEDUCTIBLE")) = False AndAlso rowx("PLFPUR_DEDUCTIBLE") = "Yes" Then
                                dtRow("PLFPUR_DEDUCTIBLE") = True
                            Else
                                dtRow("PLFPUR_DEDUCTIBLE") = False
                            End If


                            ds.Tables("PLFST_PURCHASE").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_PLFST_PURCHASE_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("PLFST_PURCHASE_DETAIL").NewRow
                                dtRow("PLFPURD_KEY") = rowx("PLFPURD_KEY")
                                dtRow("PLFPURD_PLFPURKEY") = rowx("PLFPURD_PLFPURKEY")
                                dtRow("PLFPURD_SOURCENO") = rowx("PLFPURD_SOURCENO")
                                dtRow("PLFPURD_PLFPURDKEY") = rowx("PLFPURD_PLFPURDKEY")
                                dtRow("PLFPURD_DESC") = rowx("PLFPURD_DESC")
                                dtRow("PLFPURD_AMOUNT") = rowx("PLFPURD_AMOUNT")
                                dtRow("PLFPURD_NOTE") = rowx("PLFPURD_NOTE")
                                If IsDBNull(rowx("PLFPURD_DEDUCTIBLE")) = False AndAlso rowx("PLFPURD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("PLFPURD_DEDUCTIBLE") = True
                                Else
                                    dtRow("PLFPURD_DEDUCTIBLE") = False
                                End If

                                ds.Tables("PLFST_PURCHASE_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.DEPRECIATION
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_EXPENSES_DEPRECIATION(PNL_KEY, Errorlog)

                    ds.Tables("EXPENSES_DEPRECIATION").Rows.Clear()
                    ds.Tables("EXPENSES_DEPRECIATION_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("EXPENSES_DEPRECIATION").NewRow
                            dtRow("EXDEP_KEY") = rowx("EXDEP_KEY")
                            dtRow("EXDEP_EXDEPKEY") = rowx("EXDEP_EXDEPKEY")
                            dtRow("EXDEP_SOURCENO") = rowx("EXDEP_SOURCENO")
                            dtRow("EXDEP_DESC") = rowx("EXDEP_DESC")
                            dtRow("EXDEP_AMOUNT") = rowx("EXDEP_AMOUNT")

                            If IsDBNull(rowx("EXDEP_DEDUCTIBLE")) = False AndAlso rowx("EXDEP_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXDEP_DEDUCTIBLE") = True
                            Else
                                dtRow("EXDEP_DEDUCTIBLE") = False
                            End If

                            dtRow("EXDEP_NOTE") = rowx("EXDEP_NOTE")
                            dtRow("EXDEP_DETAIL") = rowx("EXDEP_DETAIL")
                            ds.Tables("EXPENSES_DEPRECIATION").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_DEPRECIATION_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_DEPRECIATION_DETAIL").NewRow
                                dtRow("EXDEPD_KEY") = rowx("EXDEPD_KEY")
                                dtRow("EXDEPD_EXDEPKEY") = rowx("EXDEPD_EXDEPKEY")
                                dtRow("EXDEPD_SOURCENO") = rowx("EXDEPD_SOURCENO")
                                dtRow("EXDEPD_EXDEPDKEY") = rowx("EXDEPD_EXDEPDKEY")
                                dtRow("EXDEPD_DESC") = rowx("EXDEPD_DESC")
                                dtRow("EXDEPD_AMOUNT") = rowx("EXDEPD_AMOUNT")

                                If IsDBNull(rowx("EXDEPD_DEDUCTIBLE")) = False AndAlso rowx("EXDEPD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXDEPD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXDEPD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXDEPD_DEDUCTIBLE") = rowx("EXDEPD_DEDUCTIBLE")
                                dtRow("EXDEPD_NOTE") = rowx("EXDEPD_NOTE")
                                ds.Tables("EXPENSES_DEPRECIATION_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.OTHERALLOWEXP
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_EXPENSES_ALLOW(PNL_KEY, Errorlog)

                    ds.Tables("EXPENSES_ALLOW").Rows.Clear()
                    ds.Tables("EXPENSES_ALLOW_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("EXPENSES_ALLOW").NewRow
                            dtRow("EXA_KEY") = rowx("EXA_KEY")
                            dtRow("EXA_EXAKEY") = rowx("EXA_EXAKEY")
                            dtRow("EXA_SOURCENO") = rowx("EXA_SOURCENO")
                            dtRow("EXA_DESC") = rowx("EXA_DESC")
                            dtRow("EXA_AMOUNT") = rowx("EXA_AMOUNT")
                            If IsDBNull(rowx("EXA_DEDUCTIBLE")) = False AndAlso rowx("EXA_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXA_DEDUCTIBLE") = True
                            Else
                                dtRow("EXA_DEDUCTIBLE") = False
                            End If
                            If IsDBNull(rowx("EXA_DEDUCTIBLE")) = False AndAlso rowx("EXA_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXA_DEDUCTIBLE") = True
                            Else
                                dtRow("EXA_DEDUCTIBLE") = False
                            End If
                            dtRow("EXA_NOTE") = rowx("EXA_NOTE")
                            dtRow("EXA_DETAIL") = rowx("EXA_DETAIL")

                            ds.Tables("EXPENSES_ALLOW").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_ALLOW_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_ALLOW_DETAIL").NewRow
                                dtRow("EXAD_KEY") = rowx("EXAD_KEY")
                                dtRow("EXAD_EXAKEY") = rowx("EXAD_EXAKEY")
                                dtRow("EXAD_SOURCENO") = rowx("EXAD_SOURCENO")
                                dtRow("EXAD_EXADKEY") = rowx("EXAD_EXADKEY")
                                dtRow("EXAD_DESC") = rowx("EXAD_DESC")
                                dtRow("EXAD_AMOUNT") = rowx("EXAD_AMOUNT")
                                If IsDBNull(rowx("EXAD_DEDUCTIBLE")) = False AndAlso rowx("EXAD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXAD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXAD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXAD_DEDUCTIBLE") = rowx("EXAD_DEDUCTIBLE")
                                dtRow("EXAD_NOTE") = rowx("EXAD_NOTE")

                                ds.Tables("EXPENSES_ALLOW_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.OTHERNONALLOWEXP
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_EXPENSES_NONALLOW(PNL_KEY, Errorlog)

                    ds.Tables("EXPENSES_NONALLOW").Rows.Clear()
                    ds.Tables("EXPENSES_NONALLOW_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("EXPENSES_NONALLOW").NewRow
                            dtRow("EXNA_KEY") = rowx("EXNA_KEY")
                            dtRow("EXNA_EXNAKEY") = rowx("EXNA_EXNAKEY")
                            dtRow("EXNA_SOURCENO") = rowx("EXNA_SOURCENO")
                            dtRow("EXNA_DESC") = rowx("EXNA_DESC")
                            dtRow("EXNA_AMOUNT") = rowx("EXNA_AMOUNT")
                            If IsDBNull(rowx("EXNA_DEDUCTIBLE")) = False AndAlso rowx("EXNA_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXNA_DEDUCTIBLE") = True
                            Else
                                dtRow("EXNA_DEDUCTIBLE") = False
                            End If
                            dtRow("EXNA_DEDUCTIBLE") = rowx("EXNA_DEDUCTIBLE")
                            dtRow("EXNA_NOTE") = rowx("EXNA_NOTE")
                            dtRow("EXNA_DETAIL") = rowx("EXNA_DETAIL")

                            ds.Tables("EXPENSES_NONALLOW").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_NONALLOW_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_NONALLOW_DETAIL").NewRow
                                dtRow("EXNAD_KEY") = rowx("EXNAD_KEY")
                                dtRow("EXNAD_EXNAKEY") = rowx("EXNAD_EXNAKEY")
                                dtRow("EXNAD_SOURCENO") = rowx("EXNAD_SOURCENO")
                                dtRow("EXNAD_EXNADKEY") = rowx("EXNAD_EXNADKEY")
                                dtRow("EXNAD_DESC") = rowx("EXNAD_DESC")
                                If IsDBNull(rowx("EXNAD_DEDUCTIBLE")) = False AndAlso rowx("EXNAD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXNAD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXNAD_DEDUCTIBLE") = False
                                End If

                                dtRow("EXNAD_DEDUCTIBLE") = rowx("EXNAD_DEDUCTIBLE")
                                dtRow("EXNAD_AMOUNT") = rowx("EXNAD_AMOUNT")
                                dtRow("EXNAD_NOTE") = rowx("EXNAD_NOTE")

                                ds.Tables("EXPENSES_NONALLOW_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.CLOSESTOCK
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_PLFST_CLOSESTOCK(PNL_KEY, Errorlog)

                    ds.Tables("PLFST_CLOSESTOCK").Rows.Clear()
                    ds.Tables("PLFST_CLOSESTOCK_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("PLFST_CLOSESTOCK").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_PLFST_CLOSESTOCK_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("PLFST_CLOSESTOCK_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.OTHERBUSINC
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_NONSOURCE_BUSINESSINCOME(PNL_KEY, Errorlog)

                    ds.Tables("NONSOURCE_BUSINESSINCOME").Rows.Clear()
                    ds.Tables("NONSOURCE_BUSINESSINCOME_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("NONSOURCE_BUSINESSINCOME").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_NONSOURCE_BUSINESSINCOME_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("NONSOURCE_BUSINESSINCOME_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.REALFETRADE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_INCOME_REALFET(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_REALFET").Rows.Clear()
                    ds.Tables("INCOME_REALFET_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("INCOME_REALFET").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_INCOME_REALFET_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("INCOME_REALFET_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.DIVIDENDINC
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_dividend_income(PNL_KEY, Errorlog)

                    ds2.Tables("dividend_income").Rows.Clear()

                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            ds2.Tables("dividend_income").ImportRow(rowx)
                        Next

                    End If
                Case TaxComPNLEnuItem.INTERESTINC
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_INCOME_NBINTEREST(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_NBINTEREST").Rows.Clear()
                    ds.Tables("INCOME_NBINTEREST_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("INCOME_NBINTEREST").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_INCOME_NBINTEREST_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("INCOME_NBINTEREST_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.RENTALINC
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_rental_income(PNL_KEY, Errorlog)

                    ds.Tables("rental_income").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("rental_income").ImportRow(rowx)
                        Next

                    End If
                Case TaxComPNLEnuItem.ROYALTYINC
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_INCOME_NBROYALTY(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_NBROYALTY").Rows.Clear()
                    ds.Tables("INCOME_NBROYALTY_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("INCOME_NBROYALTY").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_INCOME_NBROYALTY_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("INCOME_NBROYALTY_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.OTHERINC
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_OTHER_INCOME(PNL_KEY, Errorlog)

                    ds.Tables("OTHER_INCOME").Rows.Clear()
                    ds.Tables("OTHER_INCOME_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("OTHER_INCOME").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_INCOME_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("OTHER_INCOME_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.PDFIXASSET
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_INCOME_NTDISPOSALFA(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_NTDISPOSALFA").Rows.Clear()
                    ds.Tables("INCOME_NTDISPOSALFA_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("INCOME_NTDISPOSALFA").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_INCOME_NTDISPOSALFA_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("INCOME_NTDISPOSALFA_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXEMDIV
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_exempt_dividend(PNL_KEY, Errorlog)

                    ds.Tables("exempt_dividend").Rows.Clear()
                    ds.Tables("INCOME_NTDISPOSALFA_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("INCOME_NTDISPOSALFA").ImportRow(rowx)
                        Next
                    End If
                Case TaxComPNLEnuItem.FORINCREMIT
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_INCOME_NTFOREIGNINCREM(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_NTFOREIGNINCREM").Rows.Clear()
                    ds.Tables("INCOME_NTFOREIGNINCREM_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("INCOME_NTFOREIGNINCREM").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_INCOME_NTFOREIGNINCREM_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("INCOME_NTFOREIGNINCREM_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.REALFE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_INCOME_NTUREALFET(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_NTUREALFET").Rows.Clear()
                    ds.Tables("INCOME_NTUREALFET_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("INCOME_NTUREALFET").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_INCOME_NTUREALFET_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("INCOME_NTUREALFET_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.UNREALFENONTRADE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_INCOME_NTREALFE(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_NTREALFE").Rows.Clear()
                    ds.Tables("INCOME_NTREALFE_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("INCOME_NTREALFE").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_INCOME_NTREALFE_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("INCOME_NTREALFE_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.UNREALFETRADE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_INCOME_NTUREALFENT(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_NTUREALFENT").Rows.Clear()
                    ds.Tables("INCOME_NTUREALFENT_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("INCOME_NTUREALFENT").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_INCOME_NTUREALFENT_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("INCOME_NTUREALFENT_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.OTHERNONTAXINC
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_non_taxable_income(PNL_KEY, Errorlog)

                    ds.Tables("non_taxable_income").Rows.Clear()
                    ds.Tables("NON_TAXABLE_INCOME_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("non_taxable_income").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_NON_TAXABLE_INCOME_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("NON_TAXABLE_INCOME_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.INTERESTRESTRICT
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_interestrestrict(PNL_KEY, Errorlog)

                    ds.Tables("expenses_interestrestrict").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("expenses_interestrestrict").NewRow
                            dtRow("EXIR_KEY") = rowx("EXIR_KEY")
                            dtRow("EXIR_EXIRKEY") = rowx("EXIR_EXIRKEY")
                            dtRow("EXIR_SOURCENO") = rowx("EXIR_SOURCENO")
                            dtRow("EXIR_AMOUNT") = rowx("EXIR_AMOUNT")
                            dtRow("EXIR_DESC") = rowx("EXIR_DESC")
                            If IsDBNull(rowx("EXIR_DEDUCTIBLE")) = False AndAlso rowx("EXIR_DEDUCTIBLE") = "Yes" Then
                                rowx("EXIR_DEDUCTIBLE") = True
                            Else
                                rowx("EXIR_DEDUCTIBLE") = False
                            End If
                            dtRow("EXIR_NOTE") = rowx("EXIR_NOTE")
                            dtRow("EXIR_DETAIL") = rowx("EXIR_DETAIL")
                            dtRow("EXIR_YEAREND") = rowx("EXIR_YEAREND")
                            dtRow("EXIR_STATUS") = rowx("EXIR_STATUS")
                            If IsDBNull(rowx("EXIR_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXIR_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXIR_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXIR_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")

                            ds.Tables("expenses_interestrestrict").Rows.Add(dtRow)
                        Next
                    End If
                Case TaxComPNLEnuItem.EXPOTHERINTEREST
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_interest(PNL_KEY, Errorlog)

                    ds.Tables("expenses_interest").Rows.Clear()
                    ds.Tables("EXPENSES_INTEREST_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("expenses_interest").NewRow
                            dtRow("EXI_KEY") = rowx("EXI_KEY")
                            dtRow("EXI_EXIKEY") = rowx("EXI_EXIKEY")
                            dtRow("EXI_SOURCENO") = rowx("EXI_SOURCENO")
                            dtRow("EXI_DESC") = rowx("EXI_DESC")
                            dtRow("EXI_AMOUNT") = rowx("EXI_AMOUNT")
                            If IsDBNull(rowx("EXI_DEDUCTIBLE")) = False AndAlso rowx("EXI_DEDUCTIBLE") = "Yes" Then
                                rowx("EXI_DEDUCTIBLE") = True
                            Else
                                rowx("EXI_DEDUCTIBLE") = False
                            End If
                            dtRow("EXI_NOTE") = rowx("EXI_NOTE")
                            dtRow("EXI_DETAIL") = rowx("EXI_DETAIL")
                            If IsDBNull(rowx("Exi_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXI_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXI_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXI_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")

                            ds.Tables("expenses_interest").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_INTEREST_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_INTEREST_DETAIL").NewRow
                                dtRow("EXID_KEY") = rowx("EXID_KEY")
                                dtRow("EXID_EXIKEY") = rowx("EXID_EXIKEY")
                                dtRow("EXID_SOURCENO") = rowx("EXID_SOURCENO")
                                dtRow("EXID_EXIDKEY") = rowx("EXID_EXIDKEY")
                                dtRow("EXID_DESC") = rowx("EXID_DESC")
                                If IsDBNull(rowx("EXID_DEDUCTIBLE")) = False AndAlso rowx("EXID_DEDUCTIBLE") = "Yes" Then
                                    rowx("EXID_DEDUCTIBLE") = True
                                Else
                                    rowx("EXID_DEDUCTIBLE") = False
                                End If
                                dtRow("EXID_AMOUNT") = rowx("EXID_AMOUNT")
                                dtRow("EXID_NOTE") = rowx("EXID_NOTE")
                                If IsDBNull(rowx("EXID_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXID_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXID_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXID_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")

                                ds.Tables("EXPENSES_INTEREST_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPLEGAL
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_legal(PNL_KEY, Errorlog)

                    ds.Tables("expenses_legal").Rows.Clear()
                    ds.Tables("EXPENSES_LEGAL_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("expenses_legal").NewRow
                            dtRow("EXL_KEY") = rowx("EXL_KEY")
                            dtRow("EXL_EXLKEY") = rowx("EXL_EXLKEY")
                            dtRow("EXL_SOURCENO") = rowx("EXL_SOURCENO")
                            dtRow("EXL_DESC") = rowx("EXL_DESC")
                            dtRow("EXL_AMOUNT") = rowx("EXL_AMOUNT")
                            If IsDBNull(rowx("EXL_DEDUCTIBLE")) = False AndAlso rowx("EXL_DEDUCTIBLE") = "Yes" Then
                                rowx("EXL_DEDUCTIBLE") = True
                            Else
                                rowx("EXL_DEDUCTIBLE") = False
                            End If
                            dtRow("EXL_NOTE") = rowx("EXL_NOTE")
                            dtRow("EXL_DETAIL") = rowx("EXL_DETAIL")
                            If IsDBNull(rowx("EXL_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXL_DEDUCTIBLE_ADD") = "Yes" Then
                                rowx("EXL_DEDUCTIBLE_ADD") = True
                            Else
                                rowx("EXL_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")

                            ds.Tables("expenses_legal").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_LEGAL_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_LEGAL_DETAIL").NewRow
                                dtRow("EXLD_KEY") = rowx("EXLD_KEY")
                                dtRow("EXLD_EXLKEY") = rowx("EXLD_EXLKEY")
                                dtRow("EXLD_SOURCENO") = rowx("EXLD_SOURCENO")
                                dtRow("EXLD_EXLDKEY") = rowx("EXLD_EXLDKEY")
                                dtRow("EXLD_DESC") = rowx("EXLD_DESC")
                                dtRow("EXLD_DEDUCTIBLE") = rowx("EXLD_DEDUCTIBLE")
                                dtRow("EXLD_AMOUNT") = rowx("EXLD_AMOUNT")
                                dtRow("EXLD_NOTE") = rowx("EXLD_NOTE")
                                If IsDBNull(rowx("EXLD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXLD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXLD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXLD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")

                                ds.Tables("EXPENSES_LEGAL_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPTECHNICAL
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_tech_fee(PNL_KEY, Errorlog)

                    ds.Tables("expenses_tech_fee").Rows.Clear()
                    ds.Tables("EXPENSES_TECH_FEE_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("expenses_tech_fee").NewRow
                            dtRow("EXTF_KEY") = rowx("EXTF_KEY")
                            dtRow("EXTF_EXTFKEY") = rowx("EXTF_EXTFKEY")
                            dtRow("EXTF_SOURCENO") = rowx("EXTF_SOURCENO")
                            dtRow("EXTF_DESC") = rowx("EXTF_DESC")
                            dtRow("EXTF_AMOUNT") = rowx("EXTF_AMOUNT")
                            If IsDBNull(rowx("EXTF_DEDUCTIBLE")) = False AndAlso rowx("EXTF_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXTF_DEDUCTIBLE") = True
                            Else
                                dtRow("EXTF_DEDUCTIBLE") = False
                            End If
                            dtRow("EXTF_NOTE") = rowx("EXTF_NOTE")
                            dtRow("EXTF_DETAIL") = rowx("EXTF_DETAIL")
                            If IsDBNull(rowx("EXTF_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXTF_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXTF_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXTF_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")

                            ds.Tables("expenses_tech_fee").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_TECH_FEE_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_TECH_FEE_DETAIL").NewRow
                                dtRow("EXTFD_KEY") = rowx("EXTFD_KEY")
                                dtRow("EXTFD_EXTFKEY") = rowx("EXTFD_EXTFKEY")
                                dtRow("EXTFD_SOURCENO") = rowx("EXTFD_SOURCENO")
                                dtRow("EXTFD_EXTFDKEY") = rowx("EXTFD_EXTFDKEY")
                                dtRow("EXTFD_DESC") = rowx("EXTFD_DESC")
                                If IsDBNull(rowx("EXTFD_DEDUCTIBLE")) = False AndAlso rowx("EXTFD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXTFD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXTFD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXTFD_AMOUNT") = rowx("EXTFD_AMOUNT")
                                dtRow("EXTFD_NOTE") = rowx("EXTFD_NOTE")
                                If IsDBNull(rowx("EXTFD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXTFD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXTFD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXTFD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")

                                ds.Tables("EXPENSES_TECH_FEE_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPCONTRACTPAY
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_contract(PNL_KEY, Errorlog)

                    ds.Tables("expenses_contract").Rows.Clear()
                    ds.Tables("EXPENSES_CONTRACT_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("expenses_contract").NewRow
                            dtRow("EXC_KEY") = rowx("EXC_KEY")
                            dtRow("EXC_EXCKEY") = rowx("EXC_EXCKEY")
                            dtRow("EXC_SOURCENO") = rowx("EXC_SOURCENO")
                            dtRow("EXC_DESC") = rowx("EXC_DESC")
                            dtRow("EXC_AMOUNT") = rowx("EXC_AMOUNT")
                            If IsDBNull(rowx("EXC_DEDUCTIBLE")) = False AndAlso rowx("EXC_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXC_DEDUCTIBLE") = True
                            Else
                                dtRow("EXC_DEDUCTIBLE") = False
                            End If
                            dtRow("EXC_NOTE") = rowx("EXC_NOTE")
                            dtRow("EXC_DETAIL") = rowx("EXC_DETAIL")
                            If IsDBNull(rowx("EXC_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXC_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXC_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXC_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")

                            ds.Tables("expenses_contract").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_CONTRACT_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_CONTRACT_DETAIL").NewRow
                                dtRow("EXCD_KEY") = rowx("EXCD_KEY")
                                dtRow("EXCD_EXCKEY") = rowx("EXCD_EXCKEY")
                                dtRow("EXCD_SOURCENO") = rowx("EXCD_SOURCENO")
                                dtRow("EXCD_EXCDKEY") = rowx("EXCD_EXCDKEY")
                                dtRow("EXCD_DESC") = rowx("EXCD_DESC")
                                If IsDBNull(rowx("EXCD_DEDUCTIBLE")) = False AndAlso rowx("EXCD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXCD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXCD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXCD_AMOUNT") = rowx("EXCD_AMOUNT")
                                dtRow("EXCD_NOTE") = rowx("EXCD_NOTE")
                                If IsDBNull(rowx("EXCD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXCD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXCD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXCD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")

                                ds.Tables("EXPENSES_CONTRACT_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPDIRECTORFEE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_directors_fee(PNL_KEY, Errorlog)

                    ds.Tables("expenses_directors_fee").Rows.Clear()
                    ds.Tables("EXPENSES_DIRECTORS_FEE_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("expenses_directors_fee").NewRow
                            dtRow("EXDF_KEY") = rowx("EXDF_KEY")
                            dtRow("EXDF_EXDFKEY") = rowx("EXDF_EXDFKEY")
                            dtRow("EXDF_SOURCENO") = rowx("EXDF_SOURCENO")
                            dtRow("EXDF_DESC") = rowx("EXDF_DESC")
                            dtRow("EXDF_AMOUNT") = rowx("EXDF_AMOUNT")
                            If IsDBNull(rowx("EXDF_DEDUCTIBLE")) = False AndAlso rowx("EXDF_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXDF_DEDUCTIBLE") = True
                            Else
                                dtRow("EXDF_DEDUCTIBLE") = False
                            End If
                            dtRow("EXDF_NOTE") = rowx("EXDF_NOTE")
                            dtRow("EXDF_DETAIL") = rowx("EXDF_DETAIL")
                            If IsDBNull(rowx("EXDF_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXDF_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXDF_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXDF_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")

                            ds.Tables("expenses_directors_fee").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_DIRECTORS_FEE_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_DIRECTORS_FEE_DETAIL").NewRow
                                dtRow("EXDFD_KEY") = rowx("EXDFD_KEY")
                                dtRow("EXDFD_EXDFKEY") = rowx("EXDFD_EXDFKEY")
                                dtRow("EXDFD_SOURCENO") = rowx("EXDFD_SOURCENO")
                                dtRow("EXDFD_EXDFDKEY") = rowx("EXDFD_EXDFDKEY")
                                dtRow("EXDFD_DESC") = rowx("EXDFD_DESC")
                                If IsDBNull(rowx("EXDFD_DEDUCTIBLE")) = False AndAlso rowx("EXDFD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXDFD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXDFD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXDFD_AMOUNT") = rowx("EXDFD_AMOUNT")
                                dtRow("EXDFD_NOTE") = rowx("EXDFD_NOTE")
                                If IsDBNull(rowx("EXDFD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXDFD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXDFD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXDFD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")

                                ds.Tables("EXPENSES_DIRECTORS_FEE_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPSALARY
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_salary(PNL_KEY, Errorlog)

                    ds.Tables("expenses_salary").Rows.Clear()
                    ds.Tables("EXPENSES_SALARY_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("expenses_salary").NewRow
                            dtRow("EXS_KEY") = rowx("EXS_KEY")
                            dtRow("EXS_EXSKEY") = rowx("EXS_EXSKEY")
                            dtRow("EXS_SOURCENO") = rowx("EXS_SOURCENO")
                            dtRow("EXS_DESC") = rowx("EXS_DESC")
                            dtRow("EXS_AMOUNT") = rowx("EXS_AMOUNT")
                            If IsDBNull(rowx("EXS_DEDUCTIBLE")) = False AndAlso rowx("EXS_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXS_DEDUCTIBLE") = True
                            Else
                                dtRow("EXS_DEDUCTIBLE") = False
                            End If
                            dtRow("EXS_NOTE") = rowx("EXS_NOTE")
                            dtRow("EXS_DETAIL") = rowx("EXS_DETAIL")
                            If IsDBNull(rowx("EXS_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXS_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXS_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXS_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")

                            ds.Tables("expenses_salary").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_SALARY_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("expenses_salary").NewRow
                                dtRow("EXSD_KEY") = rowx("EXSD_KEY")
                                dtRow("EXSD_EXSKEY") = rowx("EXSD_EXSKEY")
                                dtRow("EXSD_SOURCENO") = rowx("EXSD_SOURCENO")
                                dtRow("EXSD_EXSDKEY") = rowx("EXSD_EXSDKEY")
                                dtRow("EXSD_DESC") = rowx("EXSD_DESC")
                                If IsDBNull(rowx("EXSD_DEDUCTIBLE")) = False AndAlso rowx("EXSD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXSD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXSD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXSD_AMOUNT") = rowx("EXSD_AMOUNT")
                                dtRow("EXSD_NOTE") = rowx("EXSD_NOTE")
                                If IsDBNull(rowx("EXSD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXSD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXSD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXSD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")

                                ds.Tables("EXPENSES_SALARY_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPEMPLOYEESTOCK
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_empl_stock(PNL_KEY, Errorlog)

                    ds.Tables("expenses_empl_stock").Rows.Clear()
                    ds.Tables("EXPENSES_EMPLSTOCK_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("expenses_empl_stock").NewRow
                            dtRow("EXESD_KEY") = rowx("EXESD_KEY")
                            dtRow("EXESD_EXESKEY") = rowx("EXESD_EXESKEY")
                            dtRow("EXESD_SOURCENO") = rowx("EXESD_SOURCENO")
                            dtRow("EXESD_EXESDKEY") = rowx("EXESD_EXESDKEY")
                            dtRow("EXESD_DESC") = rowx("EXESD_DESC")
                            If IsDBNull(rowx("EXESD_DEDUCTIBLE")) = False AndAlso rowx("EXESD_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXESD_DEDUCTIBLE") = True
                            Else
                                dtRow("EXESD_DEDUCTIBLE") = False
                            End If
                            dtRow("EXESD_AMOUNT") = rowx("EXESD_AMOUNT")
                            dtRow("EXESD_NOTE") = rowx("EXESD_NOTE")
                            dtRow("RowIndex") = rowx("RowIndex")
                            If IsDBNull(rowx("EXESD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXESD_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXESD_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXESD_DEDUCTIBLE_ADD") = False
                            End If

                            ds.Tables("expenses_empl_stock").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_EMPLSTOCK_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_EMPLSTOCK_DETAIL").NewRow
                                dtRow("EXES_KEY") = rowx("EXES_KEY")
                                dtRow("EXES_EXESKEY") = rowx("EXES_EXESKEY")
                                dtRow("EXES_SOURCENO") = rowx("EXES_SOURCENO")
                                dtRow("EXES_DESC") = rowx("EXES_DESC")
                                dtRow("EXES_AMOUNT") = rowx("EXES_AMOUNT")
                                If IsDBNull(rowx("EXES_DEDUCTIBLE")) = False AndAlso rowx("EXES_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXES_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXES_DEDUCTIBLE") = False
                                End If
                                dtRow("EXES_NOTE") = rowx("EXES_NOTE")
                                dtRow("EXES_DETAIL") = rowx("EXES_DETAIL")
                                If IsDBNull(rowx("EXES_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXES_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXES_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXES_DEDUCTIBLE_ADD") = False
                                End If

                                dtRow("RowIndex") = rowx("RowIndex")

                                ds.Tables("EXPENSES_EMPLSTOCK_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPROYALTY
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_royalty(PNL_KEY, Errorlog)

                    ds.Tables("expenses_royalty").Rows.Clear()
                    ds.Tables("EXPENSES_ROYALTY_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("expenses_royalty").NewRow
                            dtRow("EXRO_KEY") = rowx("EXRO_KEY")
                            dtRow("EXRO_EXROKEY") = rowx("EXRO_EXROKEY")
                            dtRow("EXRO_SOURCENO") = rowx("EXRO_SOURCENO")
                            dtRow("EXRO_DESC") = rowx("EXRO_DESC")
                            dtRow("EXRO_AMOUNT") = rowx("EXRO_AMOUNT")
                            If IsDBNull(rowx("EXRO_DEDUCTIBLE")) = False AndAlso rowx("EXRO_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXRO_DEDUCTIBLE") = True
                            Else
                                dtRow("EXRO_DEDUCTIBLE") = False
                            End If
                            dtRow("EXRO_NOTE") = rowx("EXRO_NOTE")
                            dtRow("EXRO_DETAIL") = rowx("EXRO_DETAIL")
                            If IsDBNull(rowx("EXRO_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXRO_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXRO_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXRO_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")

                            ds.Tables("expenses_royalty").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_ROYALTY_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_ROYALTY_DETAIL").NewRow
                                dtRow("EXROD_KEY") = rowx("EXROD_KEY")
                                dtRow("EXROD_EXROKEY") = rowx("EXROD_EXROKEY")
                                dtRow("EXROD_SOURCENO") = rowx("EXROD_SOURCENO")
                                dtRow("EXROD_EXRODKEY") = rowx("EXROD_EXRODKEY")
                                dtRow("EXROD_DESC") = rowx("EXROD_DESC")
                                If IsDBNull(rowx("EXROD_DEDUCTIBLE")) = False AndAlso rowx("EXROD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXROD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXROD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXROD_AMOUNT") = rowx("EXROD_AMOUNT")
                                dtRow("EXROD_NOTE") = rowx("EXROD_NOTE")
                                If IsDBNull(rowx("EXROD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXROD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXROD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXROD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")

                                ds.Tables("EXPENSES_ROYALTY_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPRENTAL
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_rental(PNL_KEY, Errorlog)

                    ds.Tables("expenses_rental").Rows.Clear()
                    ds.Tables("EXPENSES_RENTAL_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("expenses_rental").NewRow
                            dtRow("EXRENT_KEY") = rowx("EXRENT_KEY")
                            dtRow("EXRENT_EXRENTKEY") = rowx("EXRENT_EXRENTKEY")
                            dtRow("EXRENT_SOURCENO") = rowx("EXRENT_SOURCENO")
                            dtRow("EXRENT_DESC") = rowx("EXRENT_DESC")
                            dtRow("EXRENT_AMOUNT") = rowx("EXRENT_AMOUNT")
                            If IsDBNull(rowx("EXRENT_DEDUCTIBLE")) = False AndAlso rowx("EXRENT_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXRENT_DEDUCTIBLE") = True
                            Else
                                dtRow("EXRENT_DEDUCTIBLE") = False
                            End If
                            dtRow("EXRENT_NOTE") = rowx("EXRENT_NOTE")
                            dtRow("EXRENT_DETAIL") = rowx("EXRENT_DETAIL")
                            If IsDBNull(rowx("EXRENT_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXRENT_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXRENT_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXRENT_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")

                            ds.Tables("expenses_rental").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_RENTAL_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_RENTAL_DETAIL").NewRow
                                dtRow("EXRENTD_KEY") = rowx("EXRENTD_KEY")
                                dtRow("EXRENTD_EXRENTKEY") = rowx("EXRENTD_EXRENTKEY")
                                dtRow("EXRENTD_SOURCENO") = rowx("EXRENTD_SOURCENO")
                                dtRow("EXRENTD_EXRENTDKEY") = rowx("EXRENTD_EXRENTDKEY")
                                dtRow("EXRENTD_DESC") = rowx("EXRENTD_DESC")
                                If IsDBNull(rowx("EXRENTD_DEDUCTIBLE")) = False AndAlso rowx("EXRENTD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXRENTD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXRENTD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXRENTD_AMOUNT") = rowx("EXRENTD_AMOUNT")
                                dtRow("EXRENTD_NOTE") = rowx("EXRENTD_NOTE")
                                If IsDBNull(rowx("EXRENTD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXRENTD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXRENTD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXRENTD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")

                                ds.Tables("EXPENSES_RENTAL_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPREPAIRMAINTENANCE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_repair(PNL_KEY, Errorlog)

                    ds.Tables("expenses_repair").Rows.Clear()
                    ds.Tables("EXPENSES_REPAIR_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("expenses_repair").NewRow
                            dtRow("EXREP_KEY") = rowx("EXREP_KEY")
                            dtRow("EXREP_EXREPKEY") = rowx("EXREP_EXREPKEY")
                            dtRow("EXREP_SOURCENO") = rowx("EXREP_SOURCENO")
                            dtRow("EXREP_DESC") = rowx("EXREP_DESC")
                            dtRow("EXREP_AMOUNT") = rowx("EXREP_AMOUNT")
                            If IsDBNull(rowx("EXREP_DEDUCTIBLE")) = False AndAlso rowx("EXREP_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXREP_DEDUCTIBLE") = True
                            Else
                                dtRow("EXREP_DEDUCTIBLE") = False
                            End If
                            dtRow("EXREP_NOTE") = rowx("EXREP_NOTE")
                            dtRow("EXREP_DETAIL") = rowx("EXREP_DETAIL")
                            If IsDBNull(rowx("EXREP_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXREP_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXREP_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXREP_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")

                            ds.Tables("expenses_repair").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_REPAIR_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_REPAIR_DETAIL").NewRow
                                dtRow("EXREPD_KEY") = rowx("EXREPD_KEY")
                                dtRow("EXREPD_EXREPKEY") = rowx("EXREPD_EXREPKEY")
                                dtRow("EXREPD_SOURCENO") = rowx("EXREPD_SOURCENO")
                                dtRow("EXREPD_EXREPDKEY") = rowx("EXREPD_EXREPDKEY")
                                dtRow("EXREPD_DESC") = rowx("EXREPD_DESC")
                                If IsDBNull(rowx("EXREPD_DEDUCTIBLE")) = False AndAlso rowx("EXREPD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXREPD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXREPD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXREPD_AMOUNT") = rowx("EXREPD_AMOUNT")
                                dtRow("EXREPD_NOTE") = rowx("EXREPD_NOTE")
                                If IsDBNull(rowx("EXREPD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXREPD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXREPD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXREPD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")

                                ds.Tables("EXPENSES_REPAIR_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPRND
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_research(PNL_KEY, Errorlog)

                    ds.Tables("expenses_research").Rows.Clear()
                    ds.Tables("EXPENSES_RESEARCH_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("expenses_research").NewRow
                            dtRow("EXRES_KEY") = rowx("EXRES_KEY")
                            dtRow("EXRES_EXRESKEY") = rowx("EXRES_EXRESKEY")
                            dtRow("EXRES_SOURCENO") = rowx("EXRES_SOURCENO")
                            dtRow("EXRES_DESC") = rowx("EXRES_DESC")
                            dtRow("EXRES_AMOUNT") = rowx("EXRES_AMOUNT")
                            If IsDBNull(rowx("EXRES_DEDUCTIBLE")) = False AndAlso rowx("EXRES_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXRES_DEDUCTIBLE") = True
                            Else
                                dtRow("EXRES_DEDUCTIBLE") = False
                            End If
                            dtRow("EXRES_NOTE") = rowx("EXRES_NOTE")
                            dtRow("EXRES_DETAIL") = rowx("EXRES_DETAIL")
                            If IsDBNull(rowx("EXRES_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXRES_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXRES_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXRES_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")

                            ds.Tables("expenses_research").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_RESEARCH_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_RESEARCH_DETAIL").NewRow
                                dtRow("EXRESD_KEY") = rowx("EXRESD_KEY")
                                dtRow("EXRESD_EXRESKEY") = rowx("EXRESD_EXRESKEY")
                                dtRow("EXRESD_SOURCENO") = rowx("EXRESD_SOURCENO")
                                dtRow("EXRESD_EXRESDKEY") = rowx("EXRESD_EXRESDKEY")
                                dtRow("EXRESD_DESC") = rowx("EXRESD_DESC")
                                If IsDBNull(rowx("EXRESD_DEDUCTIBLE")) = False AndAlso rowx("EXRESD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXRESD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXRESD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXRESD_AMOUNT") = rowx("EXRESD_AMOUNT")
                                dtRow("EXRESD_NOTE") = rowx("EXRESD_NOTE")
                                If IsDBNull(rowx("EXRESD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXRESD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXRESD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXRESD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")

                                ds.Tables("EXPENSES_RESEARCH_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPADVERTISEMENT
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_promote(PNL_KEY, Errorlog)

                    ds.Tables("expenses_promote").Rows.Clear()
                    ds.Tables("EXPENSES_PROMOTE_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("expenses_promote").NewRow
                            dtRow("EXP_KEY") = rowx("EXP_KEY")
                            dtRow("EXP_EXPKEY") = rowx("EXP_EXPKEY")
                            dtRow("EXP_SOURCENO") = rowx("EXP_SOURCENO")
                            dtRow("EXP_DESC") = rowx("EXP_DESC")
                            dtRow("EXP_AMOUNT") = rowx("EXP_AMOUNT")
                            If IsDBNull(rowx("EXP_DEDUCTIBLE")) = False AndAlso rowx("EXP_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXP_DEDUCTIBLE") = True
                            Else
                                dtRow("EXP_DEDUCTIBLE") = False
                            End If
                            dtRow("EXP_NOTE") = rowx("EXP_NOTE")
                            dtRow("EXP_DETAIL") = rowx("EXP_DETAIL")
                            If IsDBNull(rowx("EXP_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXP_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXP_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXP_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")
                            ds.Tables("expenses_promote").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_PROMOTE_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_PROMOTE_DETAIL").NewRow
                                dtRow("EXPD_KEY") = rowx("EXPD_KEY")
                                dtRow("EXPD_EXPKEY") = rowx("EXPD_EXPKEY")
                                dtRow("EXPD_SOURCENO") = rowx("EXPD_SOURCENO")
                                dtRow("EXPD_EXPDKEY") = rowx("EXPD_EXPDKEY")
                                dtRow("EXPD_DESC") = rowx("EXPD_DESC")
                                If IsDBNull(rowx("EXPD_DEDUCTIBLE")) = False AndAlso rowx("EXPD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXPD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXPD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXPD_AMOUNT") = rowx("EXPD_AMOUNT")
                                dtRow("EXPD_NOTE") = rowx("EXPD_NOTE")
                                If IsDBNull(rowx("EXPD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXPD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXPD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXPD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")

                                ds.Tables("EXPENSES_PROMOTE_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPTRAVEL
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_travel(PNL_KEY, Errorlog)

                    ds.Tables("expenses_travel").Rows.Clear()
                    ds.Tables("EXPENSES_TRAVEL_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("expenses_travel").NewRow
                            dtRow("EXT_KEY") = rowx("EXT_KEY")
                            dtRow("EXT_EXTKEY") = rowx("EXT_EXTKEY")
                            dtRow("EXT_SOURCENO") = rowx("EXT_SOURCENO")
                            dtRow("EXT_DESC") = rowx("EXT_DESC")
                            dtRow("EXT_AMOUNT") = rowx("EXT_AMOUNT")
                            If IsDBNull(rowx("EXT_DEDUCTIBLE")) = False AndAlso rowx("EXT_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXT_DEDUCTIBLE") = True
                            Else
                                dtRow("EXT_DEDUCTIBLE") = False
                            End If
                            dtRow("EXT_NOTE") = rowx("EXT_NOTE")
                            dtRow("EXT_DETAIL") = rowx("EXT_DETAIL")
                            If IsDBNull(rowx("EXT_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXT_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXT_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXT_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")
                            ds.Tables("expenses_travel").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_TRAVEL_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_TRAVEL_DETAIL").NewRow
                                dtRow("EXTD_KEY") = rowx("EXTD_KEY")
                                dtRow("EXTD_EXTKEY") = rowx("EXTD_EXTKEY")
                                dtRow("EXTD_SOURCENO") = rowx("EXTD_SOURCENO")
                                dtRow("EXTD_EXTDKEY") = rowx("EXTD_EXTDKEY")
                                dtRow("EXTD_DESC") = rowx("EXTD_DESC")
                                If IsDBNull(rowx("EXTD_DEDUCTIBLE")) = False AndAlso rowx("EXTD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXTD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXTD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXTD_AMOUNT") = rowx("EXTD_AMOUNT")
                                dtRow("EXTD_NOTE") = rowx("EXTD_NOTE")
                                If IsDBNull(rowx("EXTD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXTD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXTD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXTD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                ds.Tables("EXPENSES_TRAVEL_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPJKDM
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_jkdm(PNL_KEY, Errorlog)

                    ds.Tables("expenses_jkdm").Rows.Clear()
                    ds.Tables("EXPENSES_JKDM_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("expenses_jkdm").NewRow
                            dtRow("EXJK_KEY") = rowx("EXJK_KEY")
                            dtRow("EXJK_EXJKKEY") = rowx("EXJK_EXJKKEY")
                            dtRow("EXJK_SOURCENO") = rowx("EXJK_SOURCENO")
                            dtRow("EXJK_DESC") = rowx("EXJK_DESC")
                            dtRow("EXJK_AMOUNT") = rowx("EXJK_AMOUNT")
                            If IsDBNull(rowx("EXJK_DEDUCTIBLE")) = False AndAlso rowx("EXJK_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXJK_DEDUCTIBLE") = True
                            Else
                                dtRow("EXJK_DEDUCTIBLE") = False
                            End If
                            dtRow("EXJK_NOTE") = rowx("EXJK_NOTE")
                            dtRow("EXJK_DETAIL") = rowx("EXJK_DETAIL")
                            If IsDBNull(rowx("EXJK_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXJK_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXJK_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXJK_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")


                            ds.Tables("expenses_jkdm").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_JKDM_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_JKDM_DETAIL").NewRow
                                dtRow("EXJKD_KEY") = rowx("EXJKD_KEY")
                                dtRow("EXJKD_EXJKKEY") = rowx("EXJKD_EXJKKEY")
                                dtRow("EXJKD_SOURCENO") = rowx("EXJKD_SOURCENO")
                                dtRow("EXJKD_EXJKDKEY") = rowx("EXJKD_EXJKDKEY")
                                dtRow("EXJKD_DESC") = rowx("EXJKD_DESC")
                                If IsDBNull(rowx("EXJKD_DEDUCTIBLE")) = False AndAlso rowx("EXJKD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXJKD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXJKD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXJKD_AMOUNT") = rowx("EXJKD_AMOUNT")
                                dtRow("EXJKD_NOTE") = rowx("EXJKD_NOTE")
                                If IsDBNull(rowx("EXJKD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXJKD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXJKD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXJKD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")

                                ds.Tables("EXPENSES_JKDM_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPDEPRECIATION
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exdepreciation(PNL_KEY, Errorlog)

                    ds.Tables("other_exdepreciation").Rows.Clear()
                    ds.Tables("OTHER_EXDEPRECIATION_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("other_exdepreciation").NewRow
                            dtRow("EXODEP_KEY") = rowx("EXODEP_KEY")
                            dtRow("EXODEP_EXODEPKEY") = rowx("EXODEP_EXODEPKEY")
                            dtRow("EXODEP_SOURCENO") = rowx("EXODEP_SOURCENO")
                            dtRow("EXODEP_DESC") = rowx("EXODEP_DESC")
                            dtRow("EXODEP_AMOUNT") = rowx("EXODEP_AMOUNT")
                            If IsDBNull(rowx("EXODEP_DEDUCTIBLE")) = False AndAlso rowx("EXODEP_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXODEP_DEDUCTIBLE") = True
                            Else
                                dtRow("EXODEP_DEDUCTIBLE") = False
                            End If
                            dtRow("EXODEP_NOTE") = rowx("EXODEP_NOTE")
                            dtRow("EXODEP_DETAIL") = rowx("EXODEP_DETAIL")
                            If IsDBNull(rowx("EXODEP_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXODEP_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXODEP_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXODEP_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")
                            dtRow("Pecentage") = rowx("Pecentage")

                            ds.Tables("other_exdepreciation").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXDEPRECIATION_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXDEPRECIATION_DETAIL").NewRow
                                dtRow("EXODEPD_KEY") = rowx("EXODEPD_KEY")
                                dtRow("EXODEPD_EXODEPKEY") = rowx("EXODEPD_EXODEPKEY")
                                dtRow("EXODEPD_SOURCENO") = rowx("EXODEPD_SOURCENO")
                                dtRow("EXODEPD_EXODEPDKEY") = rowx("EXODEPD_EXODEPDKEY")
                                dtRow("EXODEPD_DESC") = rowx("EXODEPD_DESC")
                                If IsDBNull(rowx("EXODEPD_DEDUCTIBLE")) = False AndAlso rowx("EXODEPD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXODEPD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXODEPD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXODEPD_AMOUNT") = rowx("EXODEPD_AMOUNT")
                                dtRow("EXODEPD_NOTE") = rowx("EXODEPD_NOTE")
                                If IsDBNull(rowx("EXODEPD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXODEPD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXODEPD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXODEPD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")

                                ds.Tables("OTHER_EXDEPRECIATION_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPDONATIONAPPR
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exapprdonation(PNL_KEY, Errorlog)

                    ds.Tables("other_exapprdonation").Rows.Clear()
                    ds.Tables("OTHER_EXAPPRDONATION_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("other_exapprdonation").NewRow
                            dtRow("EXOAD_KEY") = rowx("EXOAD_KEY")
                            dtRow("EXOAD_EXOADKEY") = rowx("EXOAD_EXOADKEY")
                            dtRow("EXOAD_SOURCENO") = rowx("EXOAD_SOURCENO")
                            dtRow("EXOAD_DESC") = rowx("EXOAD_DESC")
                            dtRow("EXOAD_AMOUNT") = rowx("EXOAD_AMOUNT")
                            If IsDBNull(rowx("EXOAD_DEDUCTIBLE")) = False AndAlso rowx("EXOAD_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXOAD_DEDUCTIBLE") = True
                            Else
                                dtRow("EXOAD_DEDUCTIBLE") = False
                            End If
                            dtRow("EXOAD_NOTE") = rowx("EXOAD_NOTE")
                            dtRow("EXOAD_DETAIL") = rowx("EXOAD_DETAIL")
                            dtRow("EXOAD_TYPE") = rowx("EXOAD_TYPE")
                            If IsDBNull(rowx("EXOAD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOAD_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXOAD_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXOAD_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")
                            dtRow("Pecentage") = rowx("Pecentage")

                            ds.Tables("other_exapprdonation").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXAPPRDONATION_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXAPPRDONATION_DETAIL").NewRow
                                dtRow("EXOADD_KEY") = rowx("EXOADD_KEY")
                                dtRow("EXOADD_EXOADKEY") = rowx("EXOADD_EXOADKEY")
                                dtRow("EXOADD_SOURCENO") = rowx("EXOADD_SOURCENO")
                                dtRow("EXOADD_EXOADDKEY") = rowx("EXOADD_EXOADDKEY")
                                dtRow("EXOADD_DESC") = rowx("EXOADD_DESC")
                                If IsDBNull(rowx("EXOADD_DEDUCTIBLE")) = False AndAlso rowx("EXOADD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXOADD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOADD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOADD_AMOUNT") = rowx("EXOADD_AMOUNT")
                                dtRow("EXOADD_NOTE") = rowx("EXOADD_NOTE")
                                dtRow("EXOADD_TYPE") = rowx("EXOADD_TYPE")
                                If IsDBNull(rowx("EXOADD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOADD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXOADD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOADD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                ds.Tables("OTHER_EXAPPRDONATION_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPDONATIONNONAPPR
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exnapprdonation(PNL_KEY, Errorlog)

                    ds.Tables("other_exnapprdonation").Rows.Clear()
                    ds.Tables("OTHER_EXNAPPRDONATION_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("other_exnapprdonation").NewRow
                            dtRow("EXONAD_KEY") = rowx("EXONAD_KEY")
                            dtRow("EXONAD_EXONADKEY") = rowx("EXONAD_EXONADKEY")
                            dtRow("EXONAD_SOURCENO") = rowx("EXONAD_SOURCENO")
                            dtRow("EXONAD_DESC") = rowx("EXONAD_DESC")
                            dtRow("EXONAD_AMOUNT") = rowx("EXONAD_AMOUNT")
                            If IsDBNull(rowx("EXONAD_DEDUCTIBLE")) = False AndAlso rowx("EXONAD_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXONAD_DEDUCTIBLE") = True
                            Else
                                dtRow("EXONAD_DEDUCTIBLE") = False
                            End If
                            dtRow("EXONAD_NOTE") = rowx("EXONAD_NOTE")
                            dtRow("EXONAD_DETAIL") = rowx("EXONAD_DETAIL")
                            If IsDBNull(rowx("EXONAD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXONAD_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXONAD_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXONAD_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")
                            dtRow("Pecentage") = rowx("Pecentage")

                            ds.Tables("other_exnapprdonation").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXNAPPRDONATION_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXNAPPRDONATION_DETAIL").NewRow
                                dtRow("EXONADD_KEY") = rowx("EXONADD_KEY")
                                dtRow("EXONADD_EXONADKEY") = rowx("EXONADD_EXONADKEY")
                                dtRow("EXONADD_SOURCENO") = rowx("EXONADD_SOURCENO")
                                dtRow("EXONADD_EXONADDKEY") = rowx("EXONADD_EXONADDKEY")
                                dtRow("EXONADD_DESC") = rowx("EXONADD_DESC")
                                If IsDBNull(rowx("EXONADD_DEDUCTIBLE")) = False AndAlso rowx("EXONADD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXONADD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXONADD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXONADD_AMOUNT") = rowx("EXONADD_AMOUNT")
                                dtRow("EXONADD_NOTE") = rowx("EXONADD_NOTE")
                                If IsDBNull(rowx("EXONADD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXONADD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXONADD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXONADD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")

                                ds.Tables("OTHER_EXNAPPRDONATION_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPZAKAT
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exzakat(PNL_KEY, Errorlog)

                    ds.Tables("other_exzakat").Rows.Clear()
                    ds.Tables("OTHER_EXZAKAT_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("other_exzakat").NewRow
                            dtRow("EXOZ_KEY") = rowx("EXOZ_KEY")
                            dtRow("EXOZ_EXOZKEY") = rowx("EXOZ_EXOZKEY")
                            dtRow("EXOZ_SOURCENO") = rowx("EXOZ_SOURCENO")
                            dtRow("EXOZ_DESC") = rowx("EXOZ_DESC")
                            dtRow("EXOZ_AMOUNT") = rowx("EXOZ_AMOUNT")
                            If IsDBNull(rowx("EXOZ_DEDUCTIBLE")) = False AndAlso rowx("EXOZ_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXOZ_DEDUCTIBLE") = True
                            Else
                                dtRow("EXOZ_DEDUCTIBLE") = False
                            End If
                            dtRow("EXOZ_NOTE") = rowx("EXOZ_NOTE")
                            dtRow("EXOZ_DETAIL") = rowx("EXOZ_DETAIL")
                            If IsDBNull(rowx("EXOZ_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOZ_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXOZ_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXOZ_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")
                            dtRow("Pecentage") = rowx("Pecentage")

                            ds.Tables("other_exzakat").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXZAKAT_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXZAKAT_DETAIL").NewRow
                                dtRow("EXOZD_KEY") = rowx("EXOZD_KEY")
                                dtRow("EXOZD_EXOZKEY") = rowx("EXOZD_EXOZKEY")
                                dtRow("EXOZD_SOURCENO") = rowx("EXOZD_SOURCENO")
                                dtRow("EXOZD_EXOZDKEY") = rowx("EXOZD_EXOZDKEY")
                                dtRow("EXOZD_DESC") = rowx("EXOZD_DESC")
                                If IsDBNull(rowx("EXOZD_DEDUCTIBLE")) = False AndAlso rowx("EXOZD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXOZD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOZD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOZD_AMOUNT") = rowx("EXOZD_AMOUNT")
                                dtRow("EXOZD_NOTE") = rowx("EXOZD_NOTE")
                                If IsDBNull(rowx("EXOZD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOZD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXOZD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOZD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")

                                ds.Tables("OTHER_EXZAKAT_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPLOSSDISPFA
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exlossdisposalfa(PNL_KEY, Errorlog)

                    ds.Tables("other_exlossdisposalfa").Rows.Clear()
                    ds.Tables("OTHER_EXLOSSDISPOSALFA_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("other_exlossdisposalfa").NewRow
                            dtRow("EXOLD_KEY") = rowx("EXOLD_KEY")
                            dtRow("EXOLD_EXOLDKEY") = rowx("EXOLD_EXOLDKEY")
                            dtRow("EXOLD_SOURCENO") = rowx("EXOLD_SOURCENO")
                            dtRow("EXOLD_DESC") = rowx("EXOLD_DESC")
                            dtRow("EXOLD_AMOUNT") = rowx("EXOLD_AMOUNT")
                            If IsDBNull(rowx("EXOLD_DEDUCTIBLE")) = False AndAlso rowx("EXOLD_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXOLD_DEDUCTIBLE") = True
                            Else
                                dtRow("EXOLD_DEDUCTIBLE") = False
                            End If
                            dtRow("EXOLD_NOTE") = rowx("EXOLD_NOTE")
                            dtRow("EXOLD_DETAIL") = rowx("EXOLD_DETAIL")
                            If IsDBNull(rowx("EXOLD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOLD_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXOLD_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXOLD_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")
                            dtRow("Pecentage") = rowx("Pecentage")

                            ds.Tables("other_exlossdisposalfa").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXLOSSDISPOSALFA_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXLOSSDISPOSALFA_DETAIL").NewRow
                                dtRow("EXOLDD_KEY") = rowx("EXOLDD_KEY")
                                dtRow("EXOLDD_EXOLDKEY") = rowx("EXOLDD_EXOLDKEY")
                                dtRow("EXOLDD_SOURCENO") = rowx("EXOLDD_SOURCENO")
                                dtRow("EXOLDD_EXOLDDKEY") = rowx("EXOLDD_EXOLDDKEY")
                                dtRow("EXOLDD_DESC") = rowx("EXOLDD_DESC")
                                If IsDBNull(rowx("EXOLDD_DEDUCTIBLE")) = False AndAlso rowx("EXOLDD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXOLDD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOLDD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOLDD_AMOUNT") = rowx("EXOLDD_AMOUNT")
                                dtRow("EXOLDD_NOTE") = rowx("EXOLDD_NOTE")
                                If IsDBNull(rowx("EXOLDD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOLDD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXOLDD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOLDD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")

                                ds.Tables("OTHER_EXLOSSDISPOSALFA_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPENTERTAINNONSTAFF
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_entertainnstaff(PNL_KEY, Errorlog)

                    ds.Tables("other_entertainnstaff").Rows.Clear()
                    ds.Tables("OTHER_ENTERTAINNSTAFF_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("other_entertainnstaff").NewRow
                            dtRow("EXOENS_KEY") = rowx("EXOENS_KEY")
                            dtRow("EXOENS_EXOENSKEY") = rowx("EXOENS_EXOENSKEY")
                            dtRow("EXOENS_SOURCENO") = rowx("EXOENS_SOURCENO")
                            dtRow("EXOENS_DESC") = rowx("EXOENS_DESC")
                            dtRow("EXOENS_AMOUNT") = rowx("EXOENS_AMOUNT")
                            If IsDBNull(rowx("EXOENS_DEDUCTIBLE")) = False AndAlso rowx("EXOENS_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXOENS_DEDUCTIBLE") = True
                            Else
                                dtRow("EXOENS_DEDUCTIBLE") = False
                            End If
                            dtRow("EXOENS_NOTE") = rowx("EXOENS_NOTE")
                            dtRow("EXOENS_DETAIL") = rowx("EXOENS_DETAIL")
                            If IsDBNull(rowx("EXOENS_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOENS_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXOENS_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXOENS_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")
                            dtRow("Pecentage") = rowx("Pecentage")

                            ds.Tables("other_entertainnstaff").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_ENTERTAINNSTAFF_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_ENTERTAINNSTAFF_DETAIL").NewRow
                                dtRow("EXOENSD_KEY") = rowx("EXOENSD_KEY")
                                dtRow("EXOENSD_EXOENSKEY") = rowx("EXOENSD_EXOENSKEY")
                                dtRow("EXOENSD_SOURCENO") = rowx("EXOENSD_SOURCENO")
                                dtRow("EXOENSD_EXOENSDKEY") = rowx("EXOENSD_EXOENSDKEY")
                                dtRow("EXOENSD_DESC") = rowx("EXOENSD_DESC")
                                If IsDBNull(rowx("EXOENSD_DEDUCTIBLE")) = False AndAlso rowx("EXOENSD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXOENSD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOENSD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOENSD_AMOUNT") = rowx("EXOENSD_AMOUNT")
                                dtRow("EXOENSD_NOTE") = rowx("EXOENSD_NOTE")
                                If IsDBNull(rowx("EXOENSD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOENSD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXOENSD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOENSD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")

                                ds.Tables("OTHER_ENTERTAINNSTAFF_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPENTERTAINSTAFF
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_OTHER_ENTERTAINSTAFF(PNL_KEY, Errorlog)

                    ds.Tables("OTHER_ENTERTAINSTAFF").Rows.Clear()
                    ds.Tables("OTHER_ENTERTAINSTAFF_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("OTHER_ENTERTAINSTAFF").NewRow
                            dtRow("EXOES_KEY") = rowx("EXOES_KEY")
                            dtRow("EXOES_EXOESKEY") = rowx("EXOES_EXOESKEY")
                            dtRow("EXOES_SOURCENO") = rowx("EXOES_SOURCENO")
                            dtRow("EXOES_DESC") = rowx("EXOES_DESC")
                            dtRow("EXOES_AMOUNT") = rowx("EXOES_AMOUNT")
                            If IsDBNull(rowx("EXOES_DEDUCTIBLE")) = False AndAlso rowx("EXOES_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXOES_DEDUCTIBLE") = True
                            Else
                                dtRow("EXOES_DEDUCTIBLE") = False
                            End If
                            dtRow("EXOES_NOTE") = rowx("EXOES_NOTE")
                            dtRow("EXOES_DETAIL") = rowx("EXOES_DETAIL")
                            If IsDBNull(rowx("EXOES_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOES_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXOES_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXOES_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")
                            dtRow("Pecentage") = rowx("Pecentage")

                            ds.Tables("OTHER_ENTERTAINSTAFF").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_ENTERTAINSTAFF_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_ENTERTAINSTAFF_DETAIL").NewRow
                                dtRow("EXOESD_KEY") = rowx("EXOESD_KEY")
                                dtRow("EXOESD_EXOESKEY") = rowx("EXOESD_EXOESKEY")
                                dtRow("EXOESD_SOURCENO") = rowx("EXOESD_SOURCENO")
                                dtRow("EXOESD_EXOESDKEY") = rowx("EXOESD_EXOESDKEY")
                                dtRow("EXOESD_DESC") = rowx("EXOESD_DESC")
                                If IsDBNull(rowx("EXOESD_DEDUCTIBLE")) = False AndAlso rowx("EXOESD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXOESD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOESD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOESD_AMOUNT") = rowx("EXOESD_AMOUNT")
                                dtRow("EXOESD_NOTE") = rowx("EXOESD_NOTE")
                                If IsDBNull(rowx("EXOESD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOESD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXOESD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOESD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                ds.Tables("OTHER_ENTERTAINSTAFF_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPCOMPAUNDPENALTY
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_expenalty(PNL_KEY, Errorlog)

                    ds.Tables("other_expenalty").Rows.Clear()
                    ds.Tables("OTHER_EXPENALTY_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("other_expenalty").NewRow
                            dtRow("EXOP_KEY") = rowx("EXOP_KEY")
                            dtRow("EXOP_EXOPKEY") = rowx("EXOP_EXOPKEY")
                            dtRow("EXOP_SOURCENO") = rowx("EXOP_SOURCENO")
                            dtRow("EXOP_DESC") = rowx("EXOP_DESC")
                            dtRow("EXOP_AMOUNT") = rowx("EXOP_AMOUNT")
                            If IsDBNull(rowx("EXOP_DEDUCTIBLE")) = False AndAlso rowx("EXOP_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXOP_DEDUCTIBLE") = True
                            Else
                                dtRow("EXOP_DEDUCTIBLE") = False
                            End If
                            dtRow("EXOP_NOTE") = rowx("EXOP_NOTE")
                            dtRow("EXOP_DETAIL") = rowx("EXOP_DETAIL")
                            If IsDBNull(rowx("EXOP_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOP_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXOP_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXOP_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")
                            dtRow("Pecentage") = rowx("Pecentage")

                            ds.Tables("other_expenalty").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXPENALTY_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXPENALTY_DETAIL").NewRow
                                dtRow("EXOPD_KEY") = rowx("EXOPD_KEY")
                                dtRow("EXOPD_EXOPKEY") = rowx("EXOPD_EXOPKEY")
                                dtRow("EXOPD_SOURCENO") = rowx("EXOPD_SOURCENO")
                                dtRow("EXOPD_EXOPDKEY") = rowx("EXOPD_EXOPDKEY")
                                dtRow("EXOPD_DESC") = rowx("EXOPD_DESC")
                                If IsDBNull(rowx("EXOPD_DEDUCTIBLE")) = False AndAlso rowx("EXOPD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXOPD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOPD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOPD_AMOUNT") = rowx("EXOPD_AMOUNT")
                                dtRow("EXOPD_NOTE") = rowx("EXOPD_NOTE")
                                If IsDBNull(rowx("EXOPD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOPD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXOPD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOPD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")

                                ds.Tables("OTHER_EXPENALTY_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPPROVISION
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exprovisionacc(PNL_KEY, Errorlog)

                    ds.Tables("other_exprovisionacc").Rows.Clear()
                    ds.Tables("OTHER_EXPROVISIONACC_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("other_exprovisionacc").NewRow
                            dtRow("EXOPA_KEY") = rowx("EXOPA_KEY")
                            dtRow("EXOPA_EXOPAKEY") = rowx("EXOPA_EXOPAKEY")
                            dtRow("EXOPA_SOURCENO") = rowx("EXOPA_SOURCENO")
                            dtRow("EXOPA_DESC") = rowx("EXOPA_DESC")
                            dtRow("EXOPA_AMOUNT") = rowx("EXOPA_AMOUNT")
                            If IsDBNull(rowx("EXOPA_DEDUCTIBLE")) = False AndAlso rowx("EXOPA_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXOPA_DEDUCTIBLE") = True
                            Else
                                dtRow("EXOPA_DEDUCTIBLE") = False
                            End If
                            dtRow("EXOPA_NOTE") = rowx("EXOPA_NOTE")
                            dtRow("EXOPA_DETAIL") = rowx("EXOPA_DETAIL")
                            If IsDBNull(rowx("EXOPA_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOPA_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXOPA_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXOPA_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")
                            dtRow("Pecentage") = rowx("Pecentage")

                            ds.Tables("other_exprovisionacc").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXPROVISIONACC_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXPROVISIONACC_DETAIL").NewRow
                                dtRow("EXOPAD_KEY") = rowx("EXOPAD_KEY")
                                dtRow("EXOPAD_EXOPAKEY") = rowx("EXOPAD_EXOPAKEY")
                                dtRow("EXOPAD_SOURCENO") = rowx("EXOPAD_SOURCENO")
                                dtRow("EXOPAD_EXOPADKEY") = rowx("EXOPAD_EXOPADKEY")
                                dtRow("EXOPAD_DESC") = rowx("EXOPAD_DESC")
                                If IsDBNull(rowx("EXOPAD_DEDUCTIBLE")) = False AndAlso rowx("EXOPAD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXOPAD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOPAD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOPAD_AMOUNT") = rowx("EXOPAD_AMOUNT")
                                dtRow("EXOPAD_NOTE") = rowx("EXOPAD_NOTE")
                                If IsDBNull(rowx("EXOPAD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOPAD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXOPAD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOPAD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                ds.Tables("OTHER_EXPROVISIONACC_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPLEAVEPASSAGE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exleavepassage(PNL_KEY, Errorlog)

                    ds.Tables("other_exleavepassage").Rows.Clear()
                    ds.Tables("OTHER_EXLEAVEPASSAGE_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("other_exleavepassage").NewRow
                            dtRow("EXOLP_KEY") = rowx("EXOLP_KEY")
                            dtRow("EXOLP_EXOLPKEY") = rowx("EXOLP_EXOLPKEY")
                            dtRow("EXOLP_SOURCENO") = rowx("EXOLP_SOURCENO")
                            dtRow("EXOLP_DESC") = rowx("EXOLP_DESC")
                            dtRow("EXOLP_AMOUNT") = rowx("EXOLP_AMOUNT")
                            If IsDBNull(rowx("EXOLP_DEDUCTIBLE")) = False AndAlso rowx("EXOLP_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXOLP_DEDUCTIBLE") = True
                            Else
                                dtRow("EXOLP_DEDUCTIBLE") = False
                            End If
                            dtRow("EXOLP_NOTE") = rowx("EXOLP_NOTE")
                            dtRow("EXOLP_DETAIL") = rowx("EXOLP_DETAIL")
                            If IsDBNull(rowx("EXOLP_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOLP_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXOLP_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXOLP_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")
                            dtRow("Pecentage") = rowx("Pecentage")

                            ds.Tables("other_exleavepassage").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXLEAVEPASSAGE_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXLEAVEPASSAGE_DETAIL").NewRow
                                dtRow("EXOLPD_KEY") = rowx("EXOLPD_KEY")
                                dtRow("EXOLPD_EXOLPKEY") = rowx("EXOLPD_EXOLPKEY")
                                dtRow("EXOLPD_SOURCENO") = rowx("EXOLPD_SOURCENO")
                                dtRow("EXOLPD_EXOLPDKEY") = rowx("EXOLPD_EXOLPDKEY")
                                dtRow("EXOLPD_DESC") = rowx("EXOLPD_DESC")
                                If IsDBNull(rowx("EXOLPD_DEDUCTIBLE")) = False AndAlso rowx("EXOLPD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXOLPD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOLPD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOLPD_AMOUNT") = rowx("EXOLPD_AMOUNT")
                                dtRow("EXOLPD_NOTE") = rowx("EXOLPD_NOTE")
                                If IsDBNull(rowx("EXOLPD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOLPD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXOLPD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOLPD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")

                                ds.Tables("OTHER_EXLEAVEPASSAGE_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPFAWRITTENOFF
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exfawrittenoff(PNL_KEY, Errorlog)

                    ds.Tables("other_exfawrittenoff").Rows.Clear()
                    ds.Tables("OTHER_EXFAWRITTENOFF_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("other_exfawrittenoff").NewRow
                            dtRow("EXOWO_KEY") = rowx("EXOWO_KEY")
                            dtRow("EXOWO_EXOWOKEY") = rowx("EXOWO_EXOWOKEY")
                            dtRow("EXOWO_SOURCENO") = rowx("EXOWO_SOURCENO")
                            dtRow("EXOWO_DESC") = rowx("EXOWO_DESC")
                            dtRow("EXOWO_AMOUNT") = rowx("EXOWO_AMOUNT")
                            If IsDBNull(rowx("EXOWO_DEDUCTIBLE")) = False AndAlso rowx("EXOWO_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXOWO_DEDUCTIBLE") = True
                            Else
                                dtRow("EXOWO_DEDUCTIBLE") = False
                            End If
                            dtRow("EXOWO_NOTE") = rowx("EXOWO_NOTE")
                            dtRow("EXOWO_DETAIL") = rowx("EXOWO_DETAIL")
                            If IsDBNull(rowx("EXOWO_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOWO_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXOWO_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXOWO_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")
                            dtRow("Pecentage") = rowx("Pecentage")
                            ds.Tables("other_exfawrittenoff").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXFAWRITTENOFF_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXFAWRITTENOFF_DETAIL").NewRow
                                dtRow("EXOWOD_KEY") = rowx("EXOWOD_KEY")
                                dtRow("EXOWOD_EXOWOKEY") = rowx("EXOWOD_EXOWOKEY")
                                dtRow("EXOWOD_SOURCENO") = rowx("EXOWOD_SOURCENO")
                                dtRow("EXOWOD_EXOWODKEY") = rowx("EXOWOD_EXOWODKEY")
                                dtRow("EXOWOD_DESC") = rowx("EXOWOD_DESC")
                                If IsDBNull(rowx("EXOWOD_DEDUCTIBLE")) = False AndAlso rowx("EXOWOD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXOWOD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOWOD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOWOD_AMOUNT") = rowx("EXOWOD_AMOUNT")
                                dtRow("EXOWOD_NOTE") = rowx("EXOWOD_NOTE")
                                If IsDBNull(rowx("EXOWOD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOWOD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXOWOD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOWOD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")

                                ds.Tables("OTHER_EXFAWRITTENOFF_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPUNREALLOSSFE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exurlossforeign(PNL_KEY, Errorlog)

                    ds.Tables("other_exurlossforeign").Rows.Clear()
                    ds.Tables("OTHER_EXURLOSSFOREIGN_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("other_exurlossforeign").NewRow
                            dtRow("EXOUR_KEY") = rowx("EXOUR_KEY")
                            dtRow("EXOUR_EXOURKEY") = rowx("EXOUR_EXOURKEY")
                            dtRow("EXOUR_SOURCENO") = rowx("EXOUR_SOURCENO")
                            dtRow("EXOUR_DESC") = rowx("EXOUR_DESC")
                            dtRow("EXOUR_AMOUNT") = rowx("EXOUR_AMOUNT")
                            If IsDBNull(rowx("EXOUR_DEDUCTIBLE")) = False AndAlso rowx("EXOUR_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXOUR_DEDUCTIBLE") = True
                            Else
                                dtRow("EXOUR_DEDUCTIBLE") = False
                            End If
                            dtRow("EXOUR_NOTE") = rowx("EXOUR_NOTE")
                            dtRow("EXOUR_DETAIL") = rowx("EXOUR_DETAIL")
                            If IsDBNull(rowx("EXOUR_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOUR_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXOUR_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXOUR_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")
                            dtRow("Pecentage") = rowx("Pecentage")

                            ds.Tables("other_exurlossforeign").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXURLOSSFOREIGN_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXURLOSSFOREIGN_DETAIL").NewRow
                                dtRow("EXOURD_KEY") = rowx("EXOURD_KEY")
                                dtRow("EXOURD_EXOURKEY") = rowx("EXOURD_EXOURKEY")
                                dtRow("EXOURD_SOURCENO") = rowx("EXOURD_SOURCENO")
                                dtRow("EXOURD_EXOURDKEY") = rowx("EXOURD_EXOURDKEY")
                                dtRow("EXOURD_DESC") = rowx("EXOURD_DESC")
                                If IsDBNull(rowx("EXOURD_DEDUCTIBLE")) = False AndAlso rowx("EXOURD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXOURD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOURD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOURD_AMOUNT") = rowx("EXOURD_AMOUNT")
                                dtRow("EXOURD_NOTE") = rowx("EXOURD_NOTE")
                                If IsDBNull(rowx("EXOURD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOURD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXOURD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOURD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                ds.Tables("OTHER_EXURLOSSFOREIGN_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPREALLOSSFETRADE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exrlossforeignt(PNL_KEY, Errorlog)

                    ds.Tables("other_exrlossforeignt").Rows.Clear()
                    ds.Tables("OTHER_EXRLOSSFOREIGNT_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("other_exrlossforeignt").NewRow
                            dtRow("EXORT_KEY") = rowx("EXORT_KEY")
                            dtRow("EXORT_EXORTKEY") = rowx("EXORT_EXORTKEY")
                            dtRow("EXORT_SOURCENO") = rowx("EXORT_SOURCENO")
                            dtRow("EXORT_DESC") = rowx("EXORT_DESC")
                            dtRow("EXORT_AMOUNT") = rowx("EXORT_AMOUNT")
                            If IsDBNull(rowx("EXORT_DEDUCTIBLE")) = False AndAlso rowx("EXORT_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXORT_DEDUCTIBLE") = True
                            Else
                                dtRow("EXORT_DEDUCTIBLE") = False
                            End If
                            dtRow("EXORT_NOTE") = rowx("EXORT_NOTE")
                            dtRow("EXORT_DETAIL") = rowx("EXORT_DETAIL")
                            If IsDBNull(rowx("EXORT_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXORT_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXORT_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXORT_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")
                            dtRow("Pecentage") = rowx("Pecentage")
                            ds.Tables("other_exrlossforeignt").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXRLOSSFOREIGNT_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXRLOSSFOREIGNT_DETAIL").NewRow
                                dtRow("EXORTD_KEY") = rowx("EXORTD_KEY")
                                dtRow("EXORTD_EXORTKEY") = rowx("EXORTD_EXORTKEY")
                                dtRow("EXORTD_SOURCENO") = rowx("EXORTD_SOURCENO")
                                dtRow("EXORTD_EXORTDKEY") = rowx("EXORTD_EXORTDKEY")
                                dtRow("EXORTD_DESC") = rowx("EXORTD_DESC")
                                If IsDBNull(rowx("EXORTD_DEDUCTIBLE")) = False AndAlso rowx("EXORTD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXORTD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXORTD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXORTD_AMOUNT") = rowx("EXORTD_AMOUNT")
                                dtRow("EXORTD_NOTE") = rowx("EXORTD_NOTE")
                                If IsDBNull(rowx("EXORTD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXORTD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXORTD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXORTD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                ds.Tables("OTHER_EXRLOSSFOREIGNT_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPREALLOSSFENONTRADE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exrlossforeign(PNL_KEY, Errorlog)

                    ds.Tables("other_exrlossforeign").Rows.Clear()
                    ds.Tables("OTHER_EXRLOSSFOREIGN_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("other_exrlossforeign").NewRow
                            dtRow("EXOR_KEY") = rowx("EXOR_KEY")
                            dtRow("EXOR_EXORKEY") = rowx("EXOR_EXORKEY")
                            dtRow("EXOR_SOURCENO") = rowx("EXOR_SOURCENO")
                            dtRow("EXOR_DESC") = rowx("EXOR_DESC")
                            dtRow("EXOR_AMOUNT") = rowx("EXOR_AMOUNT")
                            If IsDBNull(rowx("EXOR_DEDUCTIBLE")) = False AndAlso rowx("EXOR_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXOR_DEDUCTIBLE") = True
                            Else
                                dtRow("EXOR_DEDUCTIBLE") = False
                            End If
                            dtRow("EXOR_NOTE") = rowx("EXOR_NOTE")
                            dtRow("EXOR_DETAIL") = rowx("EXOR_DETAIL")
                            If IsDBNull(rowx("EXOR_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOR_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXOR_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXOR_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")
                            dtRow("Pecentage") = rowx("Pecentage")
                            ds.Tables("other_exrlossforeign").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXRLOSSFOREIGN_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXRLOSSFOREIGN_DETAIL").NewRow
                                dtRow("EXORD_KEY") = rowx("EXORD_KEY")
                                dtRow("EXORD_EXORKEY") = rowx("EXORD_EXORKEY")
                                dtRow("EXORD_SOURCENO") = rowx("EXORD_SOURCENO")
                                dtRow("EXORD_EXORDKEY") = rowx("EXORD_EXORDKEY")
                                dtRow("EXORD_DESC") = rowx("EXORD_DESC")
                                If IsDBNull(rowx("EXORD_DEDUCTIBLE")) = False AndAlso rowx("EXORD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXORD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXORD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXORD_AMOUNT") = rowx("EXORD_AMOUNT")
                                dtRow("EXORD_NOTE") = rowx("EXORD_NOTE")
                                If IsDBNull(rowx("EXORD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXORD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXORD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXORD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                ds.Tables("OTHER_EXRLOSSFOREIGN_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPINITIALSUBSCRIPT
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exinitialsub(PNL_KEY, Errorlog)

                    ds.Tables("other_exinitialsub").Rows.Clear()
                    ds.Tables("OTHER_EXINITIALSUB_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("other_exinitialsub").NewRow
                            dtRow("EXOIS_KEY") = rowx("EXOIS_KEY")
                            dtRow("EXOIS_EXOISKEY") = rowx("EXOIS_EXOISKEY")
                            dtRow("EXOIS_SOURCENO") = rowx("EXOIS_SOURCENO")
                            dtRow("EXOIS_DESC") = rowx("EXOIS_DESC")
                            dtRow("EXOIS_AMOUNT") = rowx("EXOIS_AMOUNT")
                            If IsDBNull(rowx("EXOIS_DEDUCTIBLE")) = False AndAlso rowx("EXOIS_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXOIS_DEDUCTIBLE") = True
                            Else
                                dtRow("EXOIS_DEDUCTIBLE") = False
                            End If
                            dtRow("EXOIS_NOTE") = rowx("EXOIS_NOTE")
                            dtRow("EXOIS_DETAIL") = rowx("EXOIS_DETAIL")
                            If IsDBNull(rowx("EXOIS_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOIS_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXOIS_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXOIS_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")
                            dtRow("Pecentage") = rowx("Pecentage")

                            ds.Tables("other_exinitialsub").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXINITIALSUB_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXINITIALSUB_DETAIL").NewRow
                                dtRow("EXOISD_KEY") = rowx("EXOISD_KEY")
                                dtRow("EXOISD_EXOISKEY") = rowx("EXOISD_EXOISKEY")
                                dtRow("EXOISD_SOURCENO") = rowx("EXOISD_SOURCENO")
                                dtRow("EXOISD_EXOISDKEY") = rowx("EXOISD_EXOISDKEY")
                                dtRow("EXOISD_DESC") = rowx("EXOISD_DESC")
                                If IsDBNull(rowx("EXOISD_DEDUCTIBLE")) = False AndAlso rowx("EXOISD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXOISD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOISD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOISD_AMOUNT") = rowx("EXOISD_AMOUNT")
                                dtRow("EXOISD_NOTE") = rowx("EXOISD_NOTE")
                                If IsDBNull(rowx("EXOISD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOISD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXOISD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOISD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                ds.Tables("OTHER_EXINITIALSUB_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPCAPITALEXPENDITURE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_excapitalexp(PNL_KEY, Errorlog)

                    ds.Tables("other_excapitalexp").Rows.Clear()
                    ds.Tables("OTHER_EXCAPITALEXP_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("other_excapitalexp").NewRow
                            dtRow("EXOCE_KEY") = rowx("EXOCE_KEY")
                            dtRow("EXOCE_EXOCEKEY") = rowx("EXOCE_EXOCEKEY")
                            dtRow("EXOCE_SOURCENO") = rowx("EXOCE_SOURCENO")
                            dtRow("EXOCE_DESC") = rowx("EXOCE_DESC")
                            dtRow("EXOCE_AMOUNT") = rowx("EXOCE_AMOUNT")
                            If IsDBNull(rowx("EXOCE_DEDUCTIBLE")) = False AndAlso rowx("EXOCE_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXOCE_DEDUCTIBLE") = True
                            Else
                                dtRow("EXOCE_DEDUCTIBLE") = False
                            End If
                            dtRow("EXOCE_NOTE") = rowx("EXOCE_NOTE")
                            dtRow("EXOCE_DETAIL") = rowx("EXOCE_DETAIL")
                            If IsDBNull(rowx("EXOCE_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOCE_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXOCE_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXOCE_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")
                            dtRow("Pecentage") = rowx("Pecentage")
                            ds.Tables("other_excapitalexp").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXCAPITALEXP_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXCAPITALEXP_DETAIL").NewRow
                                dtRow("EXOCED_KEY") = rowx("EXOCED_KEY")
                                dtRow("EXOCED_EXOCEKEY") = rowx("EXOCED_EXOCEKEY")
                                dtRow("EXOCED_SOURCENO") = rowx("EXOCED_SOURCENO")
                                dtRow("EXOCED_EXOCEDKEY") = rowx("EXOCED_EXOCEDKEY")
                                dtRow("EXOCED_DESC") = rowx("EXOCED_DESC")
                                If IsDBNull(rowx("EXOCED_DEDUCTIBLE")) = False AndAlso rowx("EXOCED_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXOCED_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOCED_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOCED_AMOUNT") = rowx("EXOCED_AMOUNT")
                                dtRow("EXOCED_NOTE") = rowx("EXOCED_NOTE")
                                If IsDBNull(rowx("EXOCED_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOCED_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXOCED_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOCED_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                ds.Tables("OTHER_EXCAPITALEXP_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    End If
                Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_expenses(PNL_KEY, Errorlog)

                    ds.Tables("other_expenses").Rows.Clear()
                    ds.Tables("OTHER_EXPENSES_DETAIL").Rows.Clear()
                    If dt IsNot Nothing Then

                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("other_expenses").NewRow
                            dtRow("EXO_KEY") = rowx("EXO_KEY")
                            dtRow("EXO_EXOKEY") = rowx("EXO_EXOKEY")
                            dtRow("EXO_DESC") = rowx("EXO_DESC")
                            dtRow("EXO_AMOUNT") = rowx("EXO_AMOUNT")
                            If IsDBNull(rowx("EXO_DEDUCTIBLE")) = False AndAlso rowx("EXO_DEDUCTIBLE") = "Yes" Then
                                dtRow("EXO_DEDUCTIBLE") = True
                            Else
                                dtRow("EXO_DEDUCTIBLE") = False
                            End If
                            dtRow("EXO_NOTE") = rowx("EXO_NOTE")
                            dtRow("EXO_SOURCENO") = rowx("EXO_SOURCENO")
                            dtRow("EXO_DETAIL") = rowx("EXO_DETAIL")
                            If IsDBNull(rowx("EXO_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXO_DEDUCTIBLE_ADD") = "Yes" Then
                                dtRow("EXO_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXO_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")
                            dtRow("Pecentage") = rowx("Pecentage")
                            ds.Tables("other_expenses").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXPENSES_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXPENSES_DETAIL").NewRow
                                dtRow("EXOD_KEY") = rowx("EXOD_KEY")
                                dtRow("EXOD_EXOKEY") = rowx("EXOD_EXOKEY")
                                dtRow("EXOD_SOURCENO") = rowx("EXOD_SOURCENO")
                                dtRow("EXOD_EXODKEY") = rowx("EXOD_EXODKEY")
                                dtRow("EXOD_DESC") = rowx("EXOD_DESC")
                                If IsDBNull(rowx("EXOD_DEDUCTIBLE")) = False AndAlso rowx("EXOD_DEDUCTIBLE") = "Yes" Then
                                    dtRow("EXOD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOD_AMOUNT") = rowx("EXOD_AMOUNT")
                                dtRow("EXOD_NOTE") = rowx("EXOD_NOTE")
                                If IsDBNull(rowx("EXOD_DEDUCTIBLE_ADD")) = False AndAlso rowx("EXOD_DEDUCTIBLE_ADD") = "Yes" Then
                                    dtRow("EXOD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                ds.Tables("OTHER_EXPENSES_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    End If
            End Select
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If

            With Errorlog
                .ErrorCode = "XX1001"
                .ErrorMessage = strError & " | " & ex.Message
                .ErrorDateTime = Now
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
            End With
            Return False
        End Try
    End Function
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
