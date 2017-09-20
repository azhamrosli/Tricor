Imports DevExpress.XtraBars.Docking
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
            ListofLabel.Add(New clsPNL_LabelName("lbl_p2Other", "Other", "Other", TaxComPNLEnuItem.OTHERINC))


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
            ListofLabel.Add(New clsPNL_LabelName("lbl_p3ForeignCurrExLoss", "", "Foreign currency exchange loss", TaxComPNLEnuItem.FORECURREXLOSS))
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
            ListofLabel.Add(New clsPNL_LabelName("lbl_p4UnreaLossForeEx", "Unrealised Loss on Foreign Exchange", "Unrealised loss on foreign exchange", TaxComPNLEnuItem.EXPUNREALLOSSFE))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p4ReaLossForeExTrade", "Realised Loss on Foreign Exchange - Trade", "Realised loss on foreign exchange - trade", TaxComPNLEnuItem.EXPREALLOSSFETRADE))
            ListofLabel.Add(New clsPNL_LabelName("lbl_p4ReaLossForeExNonTrade", "Realised Loss on Foreign Exchange - Non-Trade", "Realised loss on foreign exchange - non - trade", TaxComPNLEnuItem.EXPREALLOSSFENONTRADE))
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
                            Optional ByRef Errorlog As clsError = Nothing) As Boolean
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
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        P1_docSales.Text = lbl.Text
                        P1_docSales.Name = TaxComPNLEnuItem.SALES.ToString
                        P1_docSales.Controls.Add(uc)
                        P1_docSales.Register(DockingManager)

                        doc = DockDocument.View.AddDocument(P1_docSales)
                    Else
                        
                        If P1_docSales.IsHandleCreated = False Then
                            P1_docSales.Visibility = DockVisibility.Visible
                            doc = DockDocument.View.AddDocument(P1_docSales)
                        End If
                    End If

                    DockDocument.View.ActivateDocument(P1_docSales)

                Case TaxComPNLEnuItem.OPENSTOCK
                    If P1_docOpeningStock Is Nothing Then
                        P1_docOpeningStock = New DockPanel
                        Dim uc As New ucPNL_p1OpeningStock

                        uc.RefNo = RefNo
                        uc.YA = YA
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
#Region "GENERAL"


    Public Function GetNonAllowanbleExpenses(Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            'Get Data

            Dim ds As DataSet = Nothing


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
    Public Function CalcExpenses(ByVal p3ForeignCurrExLoss As Decimal, ByVal p3OtherInterestExHirePur As Decimal, ByVal p3ProTechManLeganFees As Decimal, ByVal p3TechPayNonResis As Decimal, ByVal p3ContractPay As Decimal, ByVal p3DirectorFee As Decimal, ByVal p3Salary As Decimal, ByVal p3COEStock As Decimal, ByVal p3Royalty As Decimal, ByVal p3Rental As Decimal, ByVal p3RepairMain As Decimal, ByVal p3ResearchDev As Decimal, ByVal p3PromotionAds As Decimal, ByVal p3Travelling As Decimal, ByVal p3JKDM As Decimal, ByVal p3InterestResPurS33 As Decimal, ByVal p4TotalOtherExpenses As Decimal, ByRef BalacingFigure As Decimal, Optional ByRef Errorlog As clsError = Nothing) As Decimal
        Try
            'Dim p3ContractPay As Decimal = IIf(IsNumeric(txt_p3Depreciation.EditValue) = False, 0, txt_p3Depreciation.EditValue)
            'Dim p3DirectorFee As Decimal = IIf(IsNumeric(txt_p3Depreciation.EditValue) = False, 0, txt_p3Depreciation.EditValue)

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
