Imports DevExpress.XtraBars.Docking
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid

Module mdlPNL
   
    Public doc_p1Sales As DockPanel
    Public doc_p1OpeningStock As DockPanel
    Public doc_p1Purchase As DockPanel
    Public doc_p1Depreciation As DockPanel
    Public doc_p1AllowanceExpenses As DockPanel
    Public doc_p1NonAllowableExpenses As DockPanel
    Public doc_p1CloseStock As DockPanel

    Public doc_p2OtherBizIncome As DockPanel
    Public doc_p2ForeignCurrExGain As DockPanel
    Public doc_p2InterestIncome As DockPanel
    Public doc_p2RentalIncome As DockPanel
    Public doc_p2RoyaltyIncome As DockPanel
    Public doc_p2OtherIncome As DockPanel
    Public doc_p2ProDispPlantEq As DockPanel
    Public doc_p2ProDisInvestment As DockPanel
    Public doc_p2ForeIncomeRemmit As DockPanel
    Public doc_p2ReaForeExGainNonTrade As DockPanel
    Public doc_p2UnreaGainForeEx As DockPanel
    Public doc_p2UnreaGainForeExNon As DockPanel
    Public doc_p2Other As DockPanel
    Public doc_p2ExemptDividend As DockPanel
    Public doc_p2DivIncome As DockPanel

    Public doc_p3InterestResPurS33 As DockPanel
    Public doc_p3OtherInterestExHirePur As DockPanel
    Public doc_p3ProTechManLeganFees As DockPanel
    Public doc_p3TechPayNonResis As DockPanel
    Public doc_p3ContractPay As DockPanel
    Public doc_p3DirectorFee As DockPanel
    Public doc_p3Salary As DockPanel
    Public doc_p3COEStock As DockPanel
    Public doc_p3Royalty As DockPanel
    Public doc_p3Rental As DockPanel
    Public doc_p3RepairMain As DockPanel
    Public doc_p3ResearchDev As DockPanel
    Public doc_p3PromotionAds As DockPanel
    Public doc_p3Travelling As DockPanel
    Public doc_p3JKDM As DockPanel
    Public doc_p3Depreciation As DockPanel
    Public doc_p3DonationApp As DockPanel
    Public doc_p3DonationNonApp As DockPanel
    Public doc_p3Zakat As DockPanel

    Public doc_p4LossDispFA As DockPanel
    Public doc_p4EntNonStaff As DockPanel
    Public doc_p4EntStaff As DockPanel
    Public doc_p4Compound As DockPanel
    Public doc_p4ProvisionAcc As DockPanel
    Public doc_p4LeavePass As DockPanel
    Public doc_p4FAWrittenOff As DockPanel
    Public doc_p4UnreaLossForeEx As DockPanel
    Public doc_p4ReaLossForeExTrade As DockPanel
    Public doc_p4ReaLossForeExNonTrade As DockPanel
    Public doc_p4InitSub As DockPanel
    Public doc_p4CAExpenditure As DockPanel
    Public doc_p4Other As DockPanel
    Public doc_p4NonAllowableExpenses As DockPanel

    Public dsDataSet As DataSet

    Public Function GetVariableDockPnl(ByVal Name As String) As DockPanel
        Try
            Select Case Name
                Case "doc_p1Sales"
                    Return doc_p1Sales
                Case "doc_p1OpeningStock"
                    Return doc_p1OpeningStock
                Case "doc_p1Purchase"
                    Return doc_p1Purchase
                Case "doc_p1Depreciation"
                    Return doc_p1Depreciation
                Case "doc_p1AllowanceExpenses"
                    Return doc_p1AllowanceExpenses
                Case "doc_p1NonAllowableExpenses"
                    Return doc_p1NonAllowableExpenses
                Case "doc_p1CloseStock"
                    Return doc_p1CloseStock
                Case "doc_p2OtherBizIncome"
                    Return doc_p2OtherBizIncome
                Case "doc_p2ForeignCurrExGain"
                    Return doc_p2ForeignCurrExGain
                Case "doc_p2InterestIncome"
                    Return doc_p2InterestIncome
                Case "doc_p2RentalIncome"
                    Return doc_p2RentalIncome
                Case "doc_p2RoyaltyIncome"
                    Return doc_p2RoyaltyIncome
                Case "doc_p2OtherIncome"
                    Return doc_p2OtherIncome
                Case "doc_p2ProDispPlantEq"
                    Return doc_p2ProDispPlantEq
                Case "doc_p2ProDisInvestment"
                    Return doc_p2ProDisInvestment
                Case "doc_p2ForeIncomeRemmit"
                    Return doc_p2ForeIncomeRemmit
                Case "doc_p2ReaForeExGainNonTrade"
                    Return doc_p2ReaForeExGainNonTrade
                Case "doc_p2UnreaGainForeEx"
                    Return doc_p2UnreaGainForeEx
                Case "doc_p2UnreaGainForeExNon"
                    Return doc_p2UnreaGainForeExNon
                Case "doc_p2Other"
                    Return doc_p2Other
                Case "doc_p2ExemptDividend"
                    Return doc_p2ExemptDividend
                Case "doc_p2DivIncome"
                    Return doc_p2DivIncome
                Case "doc_p3InterestResPurS33"
                    Return doc_p3InterestResPurS33
                Case "doc_p3OtherInterestExHirePur"
                    Return doc_p3OtherInterestExHirePur
                Case "doc_p3ProTechManLeganFees"
                    Return doc_p3ProTechManLeganFees
                Case "doc_p3TechPayNonResis"
                    Return doc_p3TechPayNonResis
                Case "doc_p3ContractPay"
                    Return doc_p3ContractPay
                Case "doc_p3DirectorFee"
                    Return doc_p3DirectorFee
                Case "doc_p3Salary"
                    Return doc_p3Salary
                Case "doc_p3COEStock"
                    Return doc_p3COEStock
                Case "doc_p3Royalty"
                    Return doc_p3Royalty
                Case "doc_p3Rental"
                    Return doc_p3Rental
                Case "doc_p3RepairMain"
                    Return doc_p3RepairMain
                Case "doc_p3ResearchDev"
                    Return doc_p3ResearchDev
                Case "doc_p3PromotionAds"
                    Return doc_p3PromotionAds
                Case "doc_p3Travelling"
                    Return doc_p3Travelling
                Case "doc_p3JKDM"
                    Return doc_p3JKDM
                Case "doc_p3Depreciation"
                    Return doc_p3Depreciation
                Case "doc_p3DonationApp"
                    Return doc_p3DonationApp
                Case "doc_p3DonationNonApp"
                    Return doc_p3DonationNonApp
                Case "doc_p3Zakat"
                    Return doc_p3Zakat
                Case "doc_p4LossDispFA"
                    Return doc_p4LossDispFA
                Case "doc_p4EntNonStaff"
                    Return doc_p4EntNonStaff
                Case "doc_p4EntStaff"
                    Return doc_p4EntStaff
                Case "doc_p4Compound"
                    Return doc_p4Compound
                Case "doc_p4ProvisionAcc"
                    Return doc_p4ProvisionAcc
                Case "doc_p4LeavePass"
                    Return doc_p4LeavePass
                Case "doc_p4FAWrittenOff"
                    Return doc_p4FAWrittenOff
                Case "doc_p4UnreaLossForeEx"
                    Return doc_p4UnreaLossForeEx
                Case "doc_p4ReaLossForeExTrade"
                    Return doc_p4ReaLossForeExTrade
                Case "doc_p4ReaLossForeExNonTrade"
                    Return doc_p4ReaLossForeExNonTrade
                Case "doc_p4InitSub"
                    Return doc_p4InitSub
                Case "doc_p4CAExpenditure"
                    Return doc_p4CAExpenditure
                Case "doc_p4Other"
                    Return doc_p4Other
                Case "doc_p4NonAllowableExpenses"
                    Return doc_p4NonAllowableExpenses
            End Select
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    'Public Function GetVariableUserControl(ByVal Name As String) As class
    '    Try

    '        Select Case Name
    '            Case "ucPNL_p1Sales"
    '                'Return CType(ucPNL_p1Sales, Object)
    '                Return ucPNL_p1Sales
    '            Case "ucPNL_p1OpeningStock"
    '                Return ucPNL_p1OpeningStock
    '            Case "ucPNL_p1Purchase"
    '                Return ucPNL_p1Purchase
    '            Case "ucPNL_p1Depreciation"
    '                Return ucPNL_p1Depreciation
    '            Case "ucPNL_p1AllowanceExpenses"
    '                Return ucPNL_p1AllowanceExpenses
    '            Case "ucPNL_p1NonAllowableExpenses"
    '                Return ucPNL_p1NonAllowableExpenses
    '            Case "ucPNL_p1CloseStock"
    '                Return ucPNL_p1CloseStock
    '            Case "ucPNL_p2OtherBizIncome"
    '                Return ucPNL_p2OtherBizIncome
    '            Case "ucPNL_p2ForeignCurrExGain"
    '                Return ucPNL_p2ForeignCurrExGain
    '            Case "ucPNL_p2InterestIncome"
    '                Return ucPNL_p2InterestIncome
    '            Case "ucPNL_p2RentalIncome"
    '                Return ucPNL_p2RentalIncome
    '            Case "ucPNL_p2RoyaltyIncome"
    '                Return ucPNL_p2RoyaltyIncome
    '            Case "ucPNL_p2OtherIncome"
    '                Return ucPNL_p2OtherIncome
    '            Case "ucPNL_p2ProDispPlantEq"
    '                Return ucPNL_p2ProDispPlantEq
    '            Case "ucPNL_p2ProDisInvestment"
    '                Return ucPNL_p2ProDisInvestment
    '            Case "ucPNL_p2ForeIncomeRemmit"
    '                Return ucPNL_p2ForeIncomeRemmit
    '            Case "ucPNL_p2ReaForeExGainNonTrade"
    '                Return ucPNL_p2ReaForeExGainNonTrade
    '            Case "ucPNL_p2UnreaGainForeEx"
    '                Return ucPNL_p2UnreaGainForeEx
    '            Case "ucPNL_p2UnreaGainForeExNon"
    '                Return ucPNL_p2UnreaGainForeExNon
    '            Case "ucPNL_p2Other"
    '                Return ucPNL_p2Other
    '            Case "ucPNL_p2ExemptDividend"
    '                Return ucPNL_p2ExemptDividend
    '            Case "ucPNL_p2DivIncome"
    '                Return ucPNL_p2DivIncome
    '            Case "ucPNL_p3InterestResPurS33"
    '                Return ucPNL_p3InterestResPurS33
    '            Case "ucPNL_p3OtherInterestExHirePur"
    '                Return ucPNL_p3OtherInterestExHirePur
    '            Case "ucPNL_p3ProTechManLeganFees"
    '                Return ucPNL_p3ProTechManLeganFees
    '            Case "ucPNL_p3TechPayNonResis"
    '                Return ucPNL_p3TechPayNonResis
    '            Case "ucPNL_p3ContractPay"
    '                Return ucPNL_p3ContractPay
    '            Case "ucPNL_p3DirectorFee"
    '                Return ucPNL_p3DirectorFee
    '            Case "ucPNL_p3Salary"
    '                Return ucPNL_p3Salary
    '            Case "ucPNL_p3COEStock"
    '                Return ucPNL_p3COEStock
    '            Case "ucPNL_p3Royalty"
    '                Return ucPNL_p3Royalty
    '            Case "ucPNL_p3Rental"
    '                Return ucPNL_p3Rental
    '            Case "ucPNL_p3RepairMain"
    '                Return ucPNL_p3RepairMain
    '            Case "ucPNL_p3ResearchDev"
    '                Return ucPNL_p3ResearchDev
    '            Case "ucPNL_p3PromotionAds"
    '                Return ucPNL_p3PromotionAds
    '            Case "ucPNL_p3Travelling"
    '                Return ucPNL_p3Travelling
    '            Case "ucPNL_p3JKDM"
    '                Return ucPNL_p3JKDM
    '            Case "ucPNL_p3Depreciation"
    '                Return ucPNL_p3Depreciation
    '            Case "ucPNL_p3DonationApp"
    '                Return ucPNL_p3DonationApp
    '            Case "ucPNL_p3DonationNonApp"
    '                Return ucPNL_p3DonationNonApp
    '            Case "ucPNL_p3Zakat"
    '                Return ucPNL_p3Zakat
    '            Case "ucPNL_p4LossDispFA"
    '                Return ucPNL_p4LossDispFA
    '            Case "ucPNL_p4EntNonStaff"
    '                Return ucPNL_p4EntNonStaff
    '            Case "ucPNL_p4EntStaff"
    '                Return ucPNL_p4EntStaff
    '            Case "ucPNL_p4Compound"
    '                Return ucPNL_p4Compound
    '            Case "ucPNL_p4ProvisionAcc"
    '                Return ucPNL_p4ProvisionAcc
    '            Case "ucPNL_p4LeavePass"
    '                Return ucPNL_p4LeavePass
    '            Case "ucPNL_p4FAWrittenOff"
    '                Return ucPNL_p4FAWrittenOff
    '            Case "ucPNL_p4UnreaLossForeEx"
    '                Return ucPNL_p4UnreaLossForeEx
    '            Case "ucPNL_p4ReaLossForeExTrade"
    '                Return ucPNL_p4ReaLossForeExTrade
    '            Case "ucPNL_p4ReaLossForeExNonTrade"
    '                Return ucPNL_p4ReaLossForeExNonTrade
    '            Case "ucPNL_p4InitSub"
    '                Return ucPNL_p4InitSub
    '            Case "ucPNL_p4CAExpenditure"
    '                Return ucPNL_p4CAExpenditure
    '            Case "ucPNL_p4Other"
    '                Return ucPNL_p4Other
    '            Case "ucPNL_p4NonAllowableExpenses"
    '                Return ucPNL_p4NonAllowableExpenses
    '        End Select
    '    Catch ex As Exception
    '        Return Nothing
    '    End Try
    'End Function
    ' Public dsDataSet2 As DataSet

    'Public Function GetPNLLabelName(Optional ByRef Errorlog As clsError = Nothing) As List(Of clsPNL_LabelName)
    '    Try
    '        Dim ListofLabel As New List(Of clsPNL_LabelName)

    '        'Page 1
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p1Sales", "Sales/Turnover", "Sale / turnover", TaxComPNLEnuItem.SALES, PNL_TypeReport.Sales_TurnOver))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p1OpenStock", "Opening Stock", "Opening stock", TaxComPNLEnuItem.OPENSTOCK, PNL_TypeReport.Less_Cost_Of_Good_Sold))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p1Purchase", "Purchases", "Purchases", TaxComPNLEnuItem.PURCHASE, PNL_TypeReport.Less_Cost_Of_Good_Sold))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p1Depreciation", "Depreciation", "Depreciation", TaxComPNLEnuItem.DEPRECIATION, PNL_TypeReport.Product_Cost))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p1AllowanceExpenses", "Other Allowable Expenses", "Allowable expenses", TaxComPNLEnuItem.OTHERALLOWEXP, PNL_TypeReport.Product_Cost))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p1NonAllowableExpenses", "Other Non Allowable Expenses", "", TaxComPNLEnuItem.OTHERNONALLOWEXP, PNL_TypeReport.Product_Cost))
    '        ListofLabel.Add(New clsPNL_LabelName("LabelControl9", "Product and cost of production", "Product and cost of production", TaxComPNLEnuItem.COSTPRODUCT, PNL_TypeReport.Product_Cost))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p1CloseStock", "Closing Stock", "Closing stock", TaxComPNLEnuItem.CLOSESTOCK, PNL_TypeReport.CloseStock))
    '        ListofLabel.Add(New clsPNL_LabelName("LabelControl10", "Cost of sales", "Cost of sales", TaxComPNLEnuItem.COSTOFSALES, PNL_TypeReport.Product_Cost))
    '        ListofLabel.Add(New clsPNL_LabelName("LabelControl11", "Gross Profit", "Gross Profit", TaxComPNLEnuItem.GROSSPROFIT, PNL_TypeReport.GrossProfit))

    '        'Page 2
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2OtherBizIncome", "Other Business Income", "Other business income", TaxComPNLEnuItem.OTHERBUSINC, PNL_TypeReport.Other_Business_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2ForeignCurrExGain", "Realised Foreign Exchange Gain - Trade", "Foreign currency exchange gain", TaxComPNLEnuItem.REALFETRADE, PNL_TypeReport.Other_Business_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2DivIncome", "Dividend Income", "Dividend income", TaxComPNLEnuItem.DIVIDENDINC, PNL_TypeReport.Other_Non_Business_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2InterestIncome", "Interest Income", "Interest income", TaxComPNLEnuItem.INTERESTINC, PNL_TypeReport.Other_Non_Business_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2RentalIncome", "Rental Income", "Rental income", TaxComPNLEnuItem.RENTALINC, PNL_TypeReport.Other_Non_Business_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2RoyaltyIncome", "Royalty Income", "Royalty income", TaxComPNLEnuItem.ROYALTYINC, PNL_TypeReport.Non_Allowanble_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2OtherIncome", "Other Income", "Other income", TaxComPNLEnuItem.OTHERINC, PNL_TypeReport.Other_Non_Business_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2ProDispPlantEq", "Profit on Disposal of Fixed Assets", "Profit on disposal of property, plant and equipment", TaxComPNLEnuItem.PDFIXASSET, PNL_TypeReport.Non_Taxable_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2ProDisInvestment", "Profit on Disposal of Investment", "Profit on disposal of investment", TaxComPNLEnuItem.PDINVEST, PNL_TypeReport.Non_Taxable_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2ExemptDividend", "Exempt Dividend", "Exempt dividend", TaxComPNLEnuItem.EXEMDIV, PNL_TypeReport.Non_Taxable_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2ForeIncomeRemmit", "Foreign Income Remittance", "Foreign income remittance", TaxComPNLEnuItem.FORINCREMIT, PNL_TypeReport.Non_Taxable_Income))

    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2ReaForeExGainNonTrade", "Realised Foreign Exchange Gain Arising from Capital Transaction", "", TaxComPNLEnuItem.REALFE, PNL_TypeReport.Non_Taxable_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2UnreaGainForeEx", "Unrealised Gain on Foreign Exchange - Trade", "Unrealised gain on foreign exchange", TaxComPNLEnuItem.UNREALFETRADE, PNL_TypeReport.Non_Taxable_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2UnreaGainForeExNon", "Unrealised Gain on Foregin Exchange - Non-Trade", "Realised foreign exchange gain - non trade", TaxComPNLEnuItem.UNREALFENONTRADE, PNL_TypeReport.Non_Taxable_Income))




    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2Other", "Other", "Other", TaxComPNLEnuItem.OTHERNONTAXINC, PNL_TypeReport.Non_Taxable_Income))


    '        'Page 3
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3InterestResPurS33", "Interest restricted pursuant to S33 (2)", "Interest expense restricted under subsection 33(2)", TaxComPNLEnuItem.INTERESTRESTRICT, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3OtherInterestExHirePur", "Other Interest (excluding hire purchase interest)", "Interest", TaxComPNLEnuItem.EXPOTHERINTEREST, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3ProTechManLeganFees", "Professional, Technical, Management & Legal Fees", "Professional, technical, management and legal fees", TaxComPNLEnuItem.EXPLEGAL, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3TechPayNonResis", "Technical fee payments to non-resident recipients", "Technical fee payments to non - resident recipients", TaxComPNLEnuItem.EXPTECHNICAL, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3ContractPay", "Contract Payments", "Contract payments", TaxComPNLEnuItem.EXPCONTRACTPAY, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3DirectorFee", "Directors' Fee", "Directors' fee", TaxComPNLEnuItem.EXPDIRECTORFEE, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3Salary", "Salary", "Salaries and wages", TaxComPNLEnuItem.EXPSALARY, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3COEStock", "Cost of Employee Stock Options", "Cost of employee stock options", TaxComPNLEnuItem.EXPEMPLOYEESTOCK, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3Royalty", "Royalty", "Royalties", TaxComPNLEnuItem.EXPROYALTY, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3Rental", "Rental", "Rental / lease", TaxComPNLEnuItem.EXPRENTAL, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3RepairMain", "Repair & Maintenance", "Maintenance and repairs", TaxComPNLEnuItem.EXPREPAIRMAINTENANCE, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3ResearchDev", "Research & Development", "Research and development", TaxComPNLEnuItem.EXPRND, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3PromotionAds", "Promotion & Advertisement", "Promotion and advertisement", TaxComPNLEnuItem.EXPADVERTISEMENT, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3Travelling", "Travelling & Accommodation", "Travelling and accommodation", TaxComPNLEnuItem.EXPTRAVEL, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3ForeignCurrExLoss", "", "Foreign currency exchange loss", TaxComPNLEnuItem.EXPUNREALLOSSFE, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3JKDM", "Input Tax Not Claimable from JKDM", "Input tax not claimable from RMCD", TaxComPNLEnuItem.EXPJKDM, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3Depreciation", "Depreciation", "Depreciation of property, plant and equipment", TaxComPNLEnuItem.EXPDEPRECIATION, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3DonationApp", "Donation Approved", "Approved donations and contributions", TaxComPNLEnuItem.EXPDONATIONAPPR, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3DonationNonApp", "Donation Non Approved", "Unapproved donations and contributions", TaxComPNLEnuItem.EXPDONATIONNONAPPR, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3Zakat", "Zakat", "Zakat", TaxComPNLEnuItem.EXPZAKAT, PNL_TypeReport.Other_Expenses))

    '        'Page 4
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4LossDispFA", "Loss on Disposal of Fixed Assets", "Loss on disposal of property, plant and equipment", TaxComPNLEnuItem.EXPLOSSDISPFA, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4EntNonStaff", "Entertainment Non Staff", "Entertainment - others", TaxComPNLEnuItem.EXPENTERTAINNONSTAFF, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4EntStaff", "Entertainment  Staff", "Entertainment - staff", TaxComPNLEnuItem.EXPENTERTAINSTAFF, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4Compound", "Compound / Penalty", "Compound / penalty", TaxComPNLEnuItem.EXPCOMPAUNDPENALTY, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4ProvisionAcc", "Provision Account", "Provision account", TaxComPNLEnuItem.EXPPROVISION, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4LeavePass", "Leave Passage", "Leave passage", TaxComPNLEnuItem.EXPLEAVEPASSAGE, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4FAWrittenOff", "Fixed Asset Written Off", "Property, plant and equipment written - off", TaxComPNLEnuItem.EXPFAWRITTENOFF, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4UnreaLossForeEx", "Unrealised Loss on Foreign Exchange", "", TaxComPNLEnuItem.EXPUNREALLOSSFE, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4ReaLossForeExTrade", "Realised Loss on Foreign Exchange - Trade", "", TaxComPNLEnuItem.EXPREALLOSSFETRADE, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4ReaLossForeExNonTrade", "Realised Loss on Foreign Exchange - Non-Trade", "", TaxComPNLEnuItem.EXPREALLOSSFENONTRADE, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4InitSub", "Initial Subscription", "Subscription", TaxComPNLEnuItem.EXPINITIALSUBSCRIPT, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4CAExpenditure", "Capital Expenditure", "Capital expenditure", TaxComPNLEnuItem.EXPCAPITALEXPENDITURE, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4Other", "Others", "Others", TaxComPNLEnuItem.EXPOTHERSEXPENSES, PNL_TypeReport.Other_Expenses))

    '        Return ListofLabel
    '    Catch ex As Exception
    '        If Errorlog Is Nothing Then
    '            Errorlog = New clsError
    '        End If
    '        With Errorlog
    '            .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
    '            .ErrorCode = ex.GetHashCode.ToString
    '            .ErrorDateTime = Now
    '            .ErrorMessage = ex.Message
    '        End With
    '        Return Nothing
    '    End Try
    'End Function
    'Public Function GetPNLLabelName_Report(Optional ByRef Errorlog As clsError = Nothing) As List(Of clsPNL_LabelName)
    '    Try
    '        Dim ListofLabel As New List(Of clsPNL_LabelName)

    '        'Page 1
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p1Sales", "Sales/Turnover", "Sale / turnover", TaxComPNLEnuItem.SALES, PNL_TypeReport.Sales_TurnOver))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p1OpenStock", "Less : Cost of Sales", "Less : Cost of Sales", TaxComPNLEnuItem.LESSCOSTSALES_TITLEONLY, PNL_TypeReport.Less_Cost_Of_Good_Sold))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p1OpenStock", "Opening Stock", "Opening stock", TaxComPNLEnuItem.OPENSTOCK, PNL_TypeReport.Less_Cost_Of_Good_Sold))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p1Purchase", "Purchases", "Purchases", TaxComPNLEnuItem.PURCHASE, PNL_TypeReport.Less_Cost_Of_Good_Sold))
    '        ListofLabel.Add(New clsPNL_LabelName("LabelControl9", "Product and cost of production", "Product and cost of production", TaxComPNLEnuItem.COSTPRODUCT_TITLEONLY, PNL_TypeReport.Product_Cost))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p1Depreciation", "Depreciation", "Depreciation", TaxComPNLEnuItem.DEPRECIATION, PNL_TypeReport.Product_Cost))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p1AllowanceExpenses", "Other Allowable Expenses", "Allowable expenses", TaxComPNLEnuItem.OTHERALLOWEXP, PNL_TypeReport.Product_Cost))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p1NonAllowableExpenses", "Other Non Allowable Expenses", "", TaxComPNLEnuItem.OTHERNONALLOWEXP, PNL_TypeReport.Product_Cost))
    '        ListofLabel.Add(New clsPNL_LabelName("LabelControl9", "Product and cost of production", "Product and cost of production", TaxComPNLEnuItem.COSTPRODUCT, PNL_TypeReport.Product_Cost))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p1CloseStock", "Closing Stock", "Closing stock", TaxComPNLEnuItem.CLOSESTOCK, PNL_TypeReport.CloseStock))
    '        ListofLabel.Add(New clsPNL_LabelName("LabelControl10", "Cost of sales", "Cost of sales", TaxComPNLEnuItem.COSTOFSALES, PNL_TypeReport.Product_Cost))
    '        ListofLabel.Add(New clsPNL_LabelName("LabelControl11", "Gross Profit", "Gross Profit", TaxComPNLEnuItem.GROSSPROFIT, PNL_TypeReport.GrossProfit))

    '        'Page 2
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2OtherBizIncome", "Other Business Income", "Other business income", TaxComPNLEnuItem.OTHERBUSINC, PNL_TypeReport.Other_Business_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2ForeignCurrExGain", "Realised Foreign Exchange Gain - Trade", "Foreign currency exchange gain", TaxComPNLEnuItem.REALFETRADE, PNL_TypeReport.Other_Business_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2DivIncome", "Dividend Income", "Dividend income", TaxComPNLEnuItem.DIVIDENDINC, PNL_TypeReport.Other_Non_Business_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2InterestIncome", "Interest Income", "Interest income", TaxComPNLEnuItem.INTERESTINC, PNL_TypeReport.Other_Non_Business_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2RentalIncome", "Rental Income", "Rental income", TaxComPNLEnuItem.RENTALINC, PNL_TypeReport.Other_Non_Business_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2RoyaltyIncome", "Royalty Income", "Royalty income", TaxComPNLEnuItem.ROYALTYINC, PNL_TypeReport.Non_Allowanble_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2OtherIncome", "Other Income", "Other income", TaxComPNLEnuItem.OTHERINC, PNL_TypeReport.Other_Non_Business_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2ProDispPlantEq", "Profit on Disposal of Fixed Assets", "Profit on disposal of property, plant and equipment", TaxComPNLEnuItem.PDFIXASSET, PNL_TypeReport.Non_Taxable_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2ProDisInvestment", "Profit on Disposal of Investment", "Profit on disposal of investment", TaxComPNLEnuItem.PDINVEST, PNL_TypeReport.Non_Taxable_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2ExemptDividend", "Exempt Dividend", "Exempt dividend", TaxComPNLEnuItem.EXEMDIV, PNL_TypeReport.Non_Taxable_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2ForeIncomeRemmit", "Foreign Income Remittance", "Foreign income remittance", TaxComPNLEnuItem.FORINCREMIT, PNL_TypeReport.Non_Taxable_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2ReaForeExGainNonTrade", "Realised Foreign Exchange Gain Arising from Capital Transaction", "", TaxComPNLEnuItem.REALFE, PNL_TypeReport.Non_Taxable_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2UnreaGainForeEx", "Unrealised Gain on Foreign Exchange - Trade", "Realised foreign exchange gain - non trade", TaxComPNLEnuItem.UNREALFETRADE, PNL_TypeReport.Non_Taxable_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2UnreaGainForeExNon", "Unrealised Gain on Foregin Exchange - Non-Trade", "Unrealised gain on foreign exchange", TaxComPNLEnuItem.UNREALFENONTRADE, PNL_TypeReport.Non_Taxable_Income))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p2Other", "Other", "Other", TaxComPNLEnuItem.OTHERNONTAXINC, PNL_TypeReport.Non_Taxable_Income))


    '        'Page 3
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3InterestResPurS33", "Interest restricted pursuant to S33 (2)", "Interest expense restricted under subsection 33(2)", TaxComPNLEnuItem.INTERESTRESTRICT, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3OtherInterestExHirePur", "Other Interest (excluding hire purchase interest)", "Interest", TaxComPNLEnuItem.EXPOTHERINTEREST, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3ProTechManLeganFees", "Professional, Technical, Management & Legal Fees", "Professional, technical, management and legal fees", TaxComPNLEnuItem.EXPLEGAL, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3TechPayNonResis", "Technical fee payments to non-resident recipients", "Technical fee payments to non - resident recipients", TaxComPNLEnuItem.EXPTECHNICAL, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3ContractPay", "Contract Payments", "Contract payments", TaxComPNLEnuItem.EXPCONTRACTPAY, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3DirectorFee", "Directors' Fee", "Directors' fee", TaxComPNLEnuItem.EXPDIRECTORFEE, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3Salary", "Salary", "Salaries and wages", TaxComPNLEnuItem.EXPSALARY, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3COEStock", "Cost of Employee Stock Options", "Cost of employee stock options", TaxComPNLEnuItem.EXPEMPLOYEESTOCK, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3Royalty", "Royalty", "Royalties", TaxComPNLEnuItem.EXPROYALTY, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3Rental", "Rental", "Rental / lease", TaxComPNLEnuItem.EXPRENTAL, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3RepairMain", "Repair & Maintenance", "Maintenance and repairs", TaxComPNLEnuItem.EXPREPAIRMAINTENANCE, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3ResearchDev", "Research & Development", "Research and development", TaxComPNLEnuItem.EXPRND, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3PromotionAds", "Promotion & Advertisement", "Promotion and advertisement", TaxComPNLEnuItem.EXPADVERTISEMENT, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3Travelling", "Travelling & Accommodation", "Travelling and accommodation", TaxComPNLEnuItem.EXPTRAVEL, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3ForeignCurrExLoss", "", "Foreign currency exchange loss", TaxComPNLEnuItem.EXPUNREALLOSSFE, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3JKDM", "Input Tax Not Claimable from JKDM", "Input tax not claimable from RMCD", TaxComPNLEnuItem.EXPJKDM, PNL_TypeReport.Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3Depreciation", "Depreciation", "Depreciation of property, plant and equipment", TaxComPNLEnuItem.EXPDEPRECIATION, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3DonationApp", "Donation Approved", "Approved donations and contributions", TaxComPNLEnuItem.EXPDONATIONAPPR, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3DonationNonApp", "Donation Non Approved", "Unapproved donations and contributions", TaxComPNLEnuItem.EXPDONATIONNONAPPR, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p3Zakat", "Zakat", "Zakat", TaxComPNLEnuItem.EXPZAKAT, PNL_TypeReport.Other_Expenses))

    '        'Page 4
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4LossDispFA", "Loss on Disposal of Fixed Assets", "Loss on disposal of property, plant and equipment", TaxComPNLEnuItem.EXPLOSSDISPFA, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4EntNonStaff", "Entertainment Non Staff", "Entertainment - others", TaxComPNLEnuItem.EXPENTERTAINNONSTAFF, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4EntStaff", "Entertainment  Staff", "Entertainment - staff", TaxComPNLEnuItem.EXPENTERTAINSTAFF, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4Compound", "Compound / Penalty", "Compound / penalty", TaxComPNLEnuItem.EXPCOMPAUNDPENALTY, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4ProvisionAcc", "Provision Account", "Provision account", TaxComPNLEnuItem.EXPPROVISION, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4LeavePass", "Leave Passage", "Leave passage", TaxComPNLEnuItem.EXPLEAVEPASSAGE, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4FAWrittenOff", "Fixed Asset Written Off", "Property, plant and equipment written - off", TaxComPNLEnuItem.EXPFAWRITTENOFF, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4UnreaLossForeEx", "Unrealised Loss on Foreign Exchange", "", TaxComPNLEnuItem.EXPUNREALLOSSFE, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4ReaLossForeExTrade", "Realised Loss on Foreign Exchange - Trade", "", TaxComPNLEnuItem.EXPREALLOSSFETRADE, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4ReaLossForeExNonTrade", "Realised Loss on Foreign Exchange - Non-Trade", "", TaxComPNLEnuItem.EXPREALLOSSFENONTRADE, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4InitSub", "Initial Subscription", "Subscription", TaxComPNLEnuItem.EXPINITIALSUBSCRIPT, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4CAExpenditure", "Capital Expenditure", "Capital expenditure", TaxComPNLEnuItem.EXPCAPITALEXPENDITURE, PNL_TypeReport.Other_Expenses))
    '        ListofLabel.Add(New clsPNL_LabelName("lbl_p4Other", "Others", "Others", TaxComPNLEnuItem.EXPOTHERSEXPENSES, PNL_TypeReport.Other_Expenses))

    '        Return ListofLabel
    '    Catch ex As Exception
    '        If Errorlog Is Nothing Then
    '            Errorlog = New clsError
    '        End If
    '        With Errorlog
    '            .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
    '            .ErrorCode = ex.GetHashCode.ToString
    '            .ErrorDateTime = Now
    '            .ErrorMessage = ex.Message
    '        End With
    '        Return Nothing
    '    End Try
    'End Function

    Public Function DestroyPNL(ByVal Type As String, ByRef DockingManager As DockManager, _
                            ByRef DockDocument As DevExpress.XtraBars.Docking2010.DocumentManager, Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            DockDocument.BeginUpdate()

            Dim val As mdlEnum.TaxComPNLEnuItem = DirectCast([Enum].Parse(GetType(mdlEnum.TaxComPNLEnuItem), Type.ToUpper), mdlEnum.TaxComPNLEnuItem)

            Select Case val
                Case TaxComPNLEnuItem.SALES
                    doc_p1Sales.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p1Sales)
                Case TaxComPNLEnuItem.OPENSTOCK
                    doc_p1OpeningStock.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p1OpeningStock)
                Case TaxComPNLEnuItem.PURCHASE
                    doc_p1Purchase.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p1Purchase)
                Case TaxComPNLEnuItem.DEPRECIATION
                    doc_p1Depreciation.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p1Depreciation)
                Case TaxComPNLEnuItem.OTHERALLOWEXP
                    doc_p1AllowanceExpenses.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p1AllowanceExpenses)
                Case TaxComPNLEnuItem.OTHERNONALLOWEXP
                    doc_p1NonAllowableExpenses.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p1NonAllowableExpenses)
                Case TaxComPNLEnuItem.CLOSESTOCK
                    doc_p1CloseStock.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p1CloseStock)
                Case TaxComPNLEnuItem.OTHERBUSINC
                    doc_p2OtherBizIncome.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p2OtherBizIncome)
                Case TaxComPNLEnuItem.REALFETRADE
                    doc_p2ForeignCurrExGain.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p2ForeignCurrExGain)
                Case TaxComPNLEnuItem.INTERESTINC
                    doc_p2InterestIncome.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p2InterestIncome)
                Case TaxComPNLEnuItem.ROYALTYINC
                    doc_p2RoyaltyIncome.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p2RoyaltyIncome)
                Case TaxComPNLEnuItem.OTHERINC
                    doc_p2OtherIncome.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p2OtherIncome)
                Case TaxComPNLEnuItem.PDFIXASSET
                    doc_p2ProDispPlantEq.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p2ProDispPlantEq)
                Case TaxComPNLEnuItem.PDINVEST
                    doc_p2ProDisInvestment.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p2ProDisInvestment)
                Case TaxComPNLEnuItem.FORINCREMIT
                    doc_p2ForeIncomeRemmit.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p2ForeIncomeRemmit)
                Case TaxComPNLEnuItem.REALFE
                    doc_p2ReaForeExGainNonTrade.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p2ReaForeExGainNonTrade)
                Case TaxComPNLEnuItem.UNREALFETRADE
                    doc_p2UnreaGainForeEx.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p2UnreaGainForeEx)
                Case TaxComPNLEnuItem.UNREALFENONTRADE
                    doc_p2UnreaGainForeExNon.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p2UnreaGainForeExNon)
                Case TaxComPNLEnuItem.EXPOTHERINTEREST
                    doc_p3OtherInterestExHirePur.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p3OtherInterestExHirePur)
                Case TaxComPNLEnuItem.EXPLEGAL
                    doc_p3ProTechManLeganFees.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p3ProTechManLeganFees)
                Case TaxComPNLEnuItem.EXPTECHNICAL
                    doc_p3TechPayNonResis.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p3TechPayNonResis)
                Case TaxComPNLEnuItem.EXPCONTRACTPAY
                    doc_p3ContractPay.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p3ContractPay)
                Case TaxComPNLEnuItem.EXPDIRECTORFEE
                    doc_p3DirectorFee.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p3DirectorFee)
                Case TaxComPNLEnuItem.EXPSALARY
                    doc_p3Salary.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p3Salary)
                Case TaxComPNLEnuItem.EXPEMPLOYEESTOCK
                    doc_p3COEStock.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p3COEStock)
                Case TaxComPNLEnuItem.EXPROYALTY
                    doc_p3Royalty.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p3Royalty)
                Case TaxComPNLEnuItem.EXPRENTAL
                    doc_p3Rental.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p3Rental)
                Case TaxComPNLEnuItem.EXPREPAIRMAINTENANCE
                    doc_p3RepairMain.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p3RepairMain)
                Case TaxComPNLEnuItem.EXPRND
                    doc_p3ResearchDev.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p3ResearchDev)
                Case TaxComPNLEnuItem.EXPADVERTISEMENT
                    doc_p3PromotionAds.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p3PromotionAds)
                Case TaxComPNLEnuItem.EXPTRAVEL
                    doc_p3Travelling.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p3Travelling)
                Case TaxComPNLEnuItem.EXPJKDM
                    doc_p3JKDM.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p3JKDM)
                Case TaxComPNLEnuItem.EXPDEPRECIATION
                    doc_p3Depreciation.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p3Depreciation)
                Case TaxComPNLEnuItem.EXPDONATIONAPPR
                    doc_p3DonationApp.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p3DonationApp)
                Case TaxComPNLEnuItem.EXPDONATIONNONAPPR
                    doc_p3DonationNonApp.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p3DonationNonApp)
                Case TaxComPNLEnuItem.EXPZAKAT
                    doc_p3Zakat.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p3Zakat)
                Case TaxComPNLEnuItem.EXPLOSSDISPFA
                    doc_p4LossDispFA.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p4LossDispFA)
                Case TaxComPNLEnuItem.EXPENTERTAINNONSTAFF
                    doc_p4EntNonStaff.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p4EntNonStaff)
                Case TaxComPNLEnuItem.EXPENTERTAINSTAFF
                    doc_p4EntStaff.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p4EntStaff)
                Case TaxComPNLEnuItem.EXPCOMPAUNDPENALTY
                    doc_p4Compound.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p4Compound)
                Case TaxComPNLEnuItem.EXPPROVISION
                    doc_p4ProvisionAcc.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p4ProvisionAcc)
                Case TaxComPNLEnuItem.EXPLEAVEPASSAGE
                    doc_p4LeavePass.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p4LeavePass)
                Case TaxComPNLEnuItem.EXPFAWRITTENOFF
                    doc_p4FAWrittenOff.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p4FAWrittenOff)
                Case TaxComPNLEnuItem.EXPUNREALLOSSFE
                    doc_p4UnreaLossForeEx.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p4UnreaLossForeEx)
                Case TaxComPNLEnuItem.EXPREALLOSSFETRADE
                    doc_p4ReaLossForeExTrade.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p4ReaLossForeExTrade)
                Case TaxComPNLEnuItem.EXPREALLOSSFENONTRADE
                    doc_p4ReaLossForeExNonTrade.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p4ReaLossForeExNonTrade)
                Case TaxComPNLEnuItem.EXPINITIALSUBSCRIPT
                    doc_p4InitSub.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p4InitSub)
                Case TaxComPNLEnuItem.EXPCAPITALEXPENDITURE
                    doc_p4CAExpenditure.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p4CAExpenditure)
                Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
                    doc_p4Other.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p4Other)
                Case TaxComPNLEnuItem.RENTALINC
                    doc_p2RentalIncome.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p2RentalIncome)
                Case TaxComPNLEnuItem.NONALLOWABLEEXPENSES
                    doc_p4NonAllowableExpenses.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p4NonAllowableExpenses)
                Case TaxComPNLEnuItem.OTHERNONTAXINC
                    doc_p2Other.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p2Other)
                Case TaxComPNLEnuItem.EXEMDIV
                    doc_p2ExemptDividend.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p2ExemptDividend)
                Case TaxComPNLEnuItem.INTERESTRESTRICT
                    doc_p3InterestResPurS33.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p3InterestResPurS33)
                Case TaxComPNLEnuItem.DIVIDENDINC
                    doc_p2DivIncome.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                    DockDocument.View.RemoveDocument(doc_p2DivIncome)
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
                            ByVal RefNo As String, ByVal YA As String, _
                            ByVal RowInfo As DataRow, _
                            Optional ByRef Errorlog As clsError = Nothing, _
                            Optional ByRef txtSales As DevExpress.XtraEditors.TextEdit = Nothing, _
                            Optional ByRef SourceNo As Integer = 0, _
                            Optional ByVal cboSourceNo As DevExpress.XtraBars.BarEditItem = Nothing) As Boolean
        Try
            DockDocument.BeginUpdate()
            Dim doc As DevExpress.XtraBars.Docking2010.Views.BaseDocument

            Select Case Type
                Case TaxComPNLEnuItem.SALES

                    If doc_p1Sales Is Nothing OrElse doc_p1Sales.IsDisposed Then
                        doc_p1Sales = New DockPanel
                        Dim uc As New ucPNL_p1Sales

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = cboSourceNo
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p1Sales.Text = lbl.Text
                        doc_p1Sales.Name = TaxComPNLEnuItem.SALES.ToString
                        doc_p1Sales.Controls.Add(uc)
                        doc_p1Sales.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p1Sales)
                    Else
                        doc_p1Sales.Visibility = DockVisibility.Visible
                        If doc_p1Sales.Controls.Count > 0 AndAlso TypeOf doc_p1Sales.Controls(0) Is ucPNL_p1Sales Then
                            Dim uc As ucPNL_p1Sales = CType(doc_p1Sales.Controls(0), ucPNL_p1Sales)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.YA = YA
                            uc.RowInfo = RowInfo
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p1Sales)
                    End If

                    DockDocument.View.ActivateDocument(doc_p1Sales)

                Case TaxComPNLEnuItem.OPENSTOCK
                    If doc_p1OpeningStock Is Nothing OrElse doc_p1OpeningStock.IsDisposed Then
                        doc_p1OpeningStock = New DockPanel
                        Dim uc As New ucPNL_p1OpeningStock

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = cboSourceNo
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p1OpeningStock.Text = lbl.Text
                        doc_p1OpeningStock.Name = TaxComPNLEnuItem.OPENSTOCK.ToString
                        doc_p1OpeningStock.Controls.Add(uc)
                        doc_p1OpeningStock.DockedAsTabbedDocument = True
                        doc_p1OpeningStock.Register(DockingManager)

                        DockDocument.View.AddDocument(doc_p1OpeningStock)
                    Else
                        doc_p1OpeningStock.Visibility = DockVisibility.Visible
                        If doc_p1OpeningStock.Controls.Count > 0 AndAlso TypeOf doc_p1OpeningStock.Controls(0) Is ucPNL_p1Sales Then
                            Dim uc As ucPNL_p1Sales = CType(doc_p1OpeningStock.Controls(0), ucPNL_p1Sales)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p1OpeningStock)
                    End If
                    DockDocument.View.ActivateDocument(doc_p1OpeningStock)

                Case TaxComPNLEnuItem.PURCHASE
                    If doc_p1Purchase Is Nothing OrElse doc_p1Purchase.IsDisposed Then
                        doc_p1Purchase = New DockPanel
                        Dim uc As New ucPNL_p1Purchase

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = cboSourceNo
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p1Purchase.Text = lbl.Text
                        doc_p1Purchase.Name = TaxComPNLEnuItem.PURCHASE.ToString
                        doc_p1Purchase.Controls.Add(uc)
                        doc_p1Purchase.DockedAsTabbedDocument = True
                        doc_p1Purchase.Register(DockingManager)

                        DockDocument.View.AddDocument(doc_p1Purchase)
                    Else
                        doc_p1Purchase.Visibility = DockVisibility.Visible
                        If doc_p1Purchase.Controls.Count > 0 AndAlso TypeOf doc_p1Purchase.Controls(0) Is ucPNL_p1Purchase Then
                            Dim uc As ucPNL_p1Purchase = CType(doc_p1Purchase.Controls(0), ucPNL_p1Purchase)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p1Purchase)
                    End If
                    DockDocument.View.ActivateDocument(doc_p1Purchase)

                Case TaxComPNLEnuItem.DEPRECIATION
                    If doc_p1Depreciation Is Nothing OrElse doc_p1Depreciation.IsDisposed Then
                        doc_p1Depreciation = New DockPanel
                        Dim uc As New ucPNL_p1Depreciation

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = cboSourceNo
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p1Depreciation.Text = lbl.Text
                        doc_p1Depreciation.Name = TaxComPNLEnuItem.DEPRECIATION.ToString
                        doc_p1Depreciation.Controls.Add(uc)
                        doc_p1Depreciation.DockedAsTabbedDocument = True
                        doc_p1Depreciation.Register(DockingManager)

                        DockDocument.View.AddDocument(doc_p1Depreciation)
                    Else
                        doc_p1Depreciation.Visibility = DockVisibility.Visible
                        If doc_p1Depreciation.Controls.Count > 0 AndAlso TypeOf doc_p1Depreciation.Controls(0) Is ucPNL_p1Depreciation Then
                            Dim uc As ucPNL_p1Depreciation = CType(doc_p1Depreciation.Controls(0), ucPNL_p1Depreciation)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p1Depreciation)
                    End If
                    DockDocument.View.ActivateDocument(doc_p1Depreciation)
                Case TaxComPNLEnuItem.OTHERALLOWEXP
                    If doc_p1AllowanceExpenses Is Nothing OrElse doc_p1AllowanceExpenses.IsDisposed Then
                        doc_p1AllowanceExpenses = New DockPanel
                        Dim uc As New ucPNL_p1AllowanceExpenses

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = cboSourceNo
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p1AllowanceExpenses.Text = lbl.Text
                        doc_p1AllowanceExpenses.Name = TaxComPNLEnuItem.OTHERALLOWEXP.ToString
                        doc_p1AllowanceExpenses.Controls.Add(uc)
                        doc_p1AllowanceExpenses.DockedAsTabbedDocument = True
                        doc_p1AllowanceExpenses.Register(DockingManager)

                        DockDocument.View.AddDocument(doc_p1AllowanceExpenses)
                    Else
                        doc_p1AllowanceExpenses.Visibility = DockVisibility.Visible
                        If doc_p1AllowanceExpenses.Controls.Count > 0 AndAlso TypeOf doc_p1AllowanceExpenses.Controls(0) Is ucPNL_p1AllowanceExpenses Then
                            Dim uc As ucPNL_p1AllowanceExpenses = CType(doc_p1AllowanceExpenses.Controls(0), ucPNL_p1AllowanceExpenses)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p1AllowanceExpenses)
                    End If
                    DockDocument.View.ActivateDocument(doc_p1AllowanceExpenses)
                Case TaxComPNLEnuItem.OTHERNONALLOWEXP
                    If doc_p1NonAllowableExpenses Is Nothing OrElse doc_p1NonAllowableExpenses.IsDisposed Then
                        doc_p1NonAllowableExpenses = New DockPanel
                        Dim uc As New ucPNL_p1NonAllowableExpenses

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = cboSourceNo
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p1NonAllowableExpenses.Text = lbl.Text
                        doc_p1NonAllowableExpenses.Name = TaxComPNLEnuItem.OTHERNONALLOWEXP.ToString
                        doc_p1NonAllowableExpenses.Controls.Add(uc)
                        doc_p1NonAllowableExpenses.DockedAsTabbedDocument = True
                        doc_p1NonAllowableExpenses.Register(DockingManager)

                        DockDocument.View.AddDocument(doc_p1NonAllowableExpenses)
                    Else
                        doc_p1NonAllowableExpenses.Visibility = DockVisibility.Visible
                        If doc_p1NonAllowableExpenses.Controls.Count > 0 AndAlso TypeOf doc_p1NonAllowableExpenses.Controls(0) Is ucPNL_p1NonAllowableExpenses Then
                            Dim uc As ucPNL_p1NonAllowableExpenses = CType(doc_p1NonAllowableExpenses.Controls(0), ucPNL_p1NonAllowableExpenses)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p1NonAllowableExpenses)
                    End If
                    DockDocument.View.ActivateDocument(doc_p1NonAllowableExpenses)
                Case TaxComPNLEnuItem.CLOSESTOCK
                    If doc_p1CloseStock Is Nothing OrElse doc_p1CloseStock.IsDisposed Then
                        doc_p1CloseStock = New DockPanel
                        Dim uc As New ucPNL_p1CloseStock

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = cboSourceNo
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p1CloseStock.Text = lbl.Text
                        doc_p1CloseStock.Name = TaxComPNLEnuItem.CLOSESTOCK.ToString
                        doc_p1CloseStock.Controls.Add(uc)
                        doc_p1CloseStock.DockedAsTabbedDocument = True
                        doc_p1CloseStock.Register(DockingManager)

                        DockDocument.View.AddDocument(doc_p1CloseStock)
                    Else
                        doc_p1CloseStock.Visibility = DockVisibility.Visible
                        If doc_p1CloseStock.Controls.Count > 0 AndAlso TypeOf doc_p1CloseStock.Controls(0) Is ucPNL_p1CloseStock Then
                            Dim uc As ucPNL_p1CloseStock = CType(doc_p1CloseStock.Controls(0), ucPNL_p1CloseStock)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p1CloseStock)
                    End If
                    DockDocument.View.ActivateDocument(doc_p1CloseStock)
                Case TaxComPNLEnuItem.OTHERBUSINC
                    If doc_p2OtherBizIncome Is Nothing OrElse doc_p2OtherBizIncome.IsDisposed Then
                        doc_p2OtherBizIncome = New DockPanel
                        Dim uc As New ucPNL_p2OtherBizIncome

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = cboSourceNo
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p2OtherBizIncome.Text = lbl.Text
                        doc_p2OtherBizIncome.Name = TaxComPNLEnuItem.OTHERBUSINC.ToString
                        doc_p2OtherBizIncome.Controls.Add(uc)
                        doc_p2OtherBizIncome.DockedAsTabbedDocument = True
                        doc_p2OtherBizIncome.Register(DockingManager)

                        DockDocument.View.AddDocument(doc_p2OtherBizIncome)
                    Else
                        doc_p2OtherBizIncome.Visibility = DockVisibility.Visible
                        If doc_p2OtherBizIncome.Controls.Count > 0 AndAlso TypeOf doc_p2OtherBizIncome.Controls(0) Is ucPNL_p2OtherBizIncome Then
                            Dim uc As ucPNL_p2OtherBizIncome = CType(doc_p2OtherBizIncome.Controls(0), ucPNL_p2OtherBizIncome)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2OtherBizIncome)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2OtherBizIncome)
                Case TaxComPNLEnuItem.REALFETRADE
                    If doc_p2ForeignCurrExGain Is Nothing OrElse doc_p2ForeignCurrExGain.IsDisposed Then
                        doc_p2ForeignCurrExGain = New DockPanel
                        Dim uc As New ucPNL_p2ForeignCurrExGain

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = cboSourceNo
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p2ForeignCurrExGain.Text = lbl.Text
                        doc_p2ForeignCurrExGain.Name = TaxComPNLEnuItem.REALFETRADE.ToString
                        doc_p2ForeignCurrExGain.Controls.Add(uc)
                        doc_p2ForeignCurrExGain.DockedAsTabbedDocument = True
                        doc_p2ForeignCurrExGain.Register(DockingManager)

                        DockDocument.View.AddDocument(doc_p2ForeignCurrExGain)
                    Else
                        doc_p2ForeignCurrExGain.Visibility = DockVisibility.Visible
                        If doc_p2ForeignCurrExGain.Controls.Count > 0 AndAlso TypeOf doc_p2ForeignCurrExGain.Controls(0) Is ucPNL_p2ForeignCurrExGain Then
                            Dim uc As ucPNL_p2ForeignCurrExGain = CType(doc_p2ForeignCurrExGain.Controls(0), ucPNL_p2ForeignCurrExGain)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2ForeignCurrExGain)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2ForeignCurrExGain)
                Case TaxComPNLEnuItem.INTERESTINC
                    If doc_p2InterestIncome Is Nothing OrElse doc_p2InterestIncome.IsDisposed Then
                        doc_p2InterestIncome = New DockPanel
                        Dim uc As New ucPNL_p2InterestIncome

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = cboSourceNo
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p2InterestIncome.Text = lbl.Text
                        doc_p2InterestIncome.Name = TaxComPNLEnuItem.INTERESTINC.ToString
                        doc_p2InterestIncome.Controls.Add(uc)
                        doc_p2InterestIncome.DockedAsTabbedDocument = True
                        doc_p2InterestIncome.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p2InterestIncome)
                    Else
                        doc_p2InterestIncome.Visibility = DockVisibility.Visible
                        If doc_p2InterestIncome.Controls.Count > 0 AndAlso TypeOf doc_p2InterestIncome.Controls(0) Is ucPNL_p2InterestIncome Then
                            Dim uc As ucPNL_p2InterestIncome = CType(doc_p2InterestIncome.Controls(0), ucPNL_p2InterestIncome)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2InterestIncome)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2InterestIncome)
                Case TaxComPNLEnuItem.ROYALTYINC
                    If doc_p2RoyaltyIncome Is Nothing OrElse doc_p2RoyaltyIncome.IsDisposed Then
                        doc_p2RoyaltyIncome = New DockPanel
                        Dim uc As New ucPNL_p2RoyaltyIncome

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = cboSourceNo
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p2RoyaltyIncome.Text = lbl.Text
                        doc_p2RoyaltyIncome.Name = TaxComPNLEnuItem.ROYALTYINC.ToString
                        doc_p2RoyaltyIncome.Controls.Add(uc)
                        doc_p2RoyaltyIncome.DockedAsTabbedDocument = True
                        doc_p2RoyaltyIncome.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p2RoyaltyIncome)
                    Else
                        doc_p2RoyaltyIncome.Visibility = DockVisibility.Visible
                        If doc_p2RoyaltyIncome.Controls.Count > 0 AndAlso TypeOf doc_p2RoyaltyIncome.Controls(0) Is ucPNL_p2RoyaltyIncome Then
                            Dim uc As ucPNL_p2RoyaltyIncome = CType(doc_p2RoyaltyIncome.Controls(0), ucPNL_p2RoyaltyIncome)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2RoyaltyIncome)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2RoyaltyIncome)
                Case TaxComPNLEnuItem.OTHERINC
                    If doc_p2OtherIncome Is Nothing OrElse doc_p2OtherIncome.IsDisposed Then
                        doc_p2OtherIncome = New DockPanel
                        Dim uc As New ucPNL_p2OtherIncome

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = cboSourceNo
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p2OtherIncome.Text = lbl.Text
                        doc_p2OtherIncome.Name = TaxComPNLEnuItem.OTHERINC.ToString
                        doc_p2OtherIncome.Controls.Add(uc)
                        doc_p2OtherIncome.DockedAsTabbedDocument = True
                        doc_p2OtherIncome.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p2OtherIncome)
                    Else
                        doc_p2OtherIncome.Visibility = DockVisibility.Visible
                        If doc_p2OtherIncome.Controls.Count > 0 AndAlso TypeOf doc_p2OtherIncome.Controls(0) Is ucPNL_p2OtherIncome Then
                            Dim uc As ucPNL_p2OtherIncome = CType(doc_p2OtherIncome.Controls(0), ucPNL_p2OtherIncome)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2OtherIncome)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2OtherIncome)
                Case TaxComPNLEnuItem.PDFIXASSET
                    If doc_p2ProDispPlantEq Is Nothing OrElse doc_p2ProDispPlantEq.IsDisposed Then
                        doc_p2ProDispPlantEq = New DockPanel
                        Dim uc As New ucPNL_p2ProDispPlantEq

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p2ProDispPlantEq.Text = lbl.Text
                        doc_p2ProDispPlantEq.Name = TaxComPNLEnuItem.PDFIXASSET.ToString
                        doc_p2ProDispPlantEq.Controls.Add(uc)
                        doc_p2ProDispPlantEq.DockedAsTabbedDocument = True
                        doc_p2ProDispPlantEq.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p2ProDispPlantEq)
                    Else
                        doc_p2ProDispPlantEq.Visibility = DockVisibility.Visible
                        If doc_p2ProDispPlantEq.Controls.Count > 0 AndAlso TypeOf doc_p2ProDispPlantEq.Controls(0) Is ucPNL_p2ProDispPlantEq Then
                            Dim uc As ucPNL_p2ProDispPlantEq = CType(doc_p2ProDispPlantEq.Controls(0), ucPNL_p2ProDispPlantEq)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2ProDispPlantEq)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2ProDispPlantEq)
                Case TaxComPNLEnuItem.PDINVEST
                    If doc_p2ProDisInvestment Is Nothing OrElse doc_p2ProDisInvestment.IsDisposed Then
                        doc_p2ProDisInvestment = New DockPanel
                        Dim uc As New ucPNL_p2ProDisInvestment

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p2ProDisInvestment.Text = lbl.Text
                        doc_p2ProDisInvestment.Name = TaxComPNLEnuItem.PDINVEST.ToString
                        doc_p2ProDisInvestment.Controls.Add(uc)
                        doc_p2ProDisInvestment.DockedAsTabbedDocument = True
                        doc_p2ProDisInvestment.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p2ProDisInvestment)
                    Else
                        doc_p2ProDisInvestment.Visibility = DockVisibility.Visible
                        If doc_p2ProDisInvestment.Controls.Count > 0 AndAlso TypeOf doc_p2ProDisInvestment.Controls(0) Is ucPNL_p2ProDisInvestment Then
                            Dim uc As ucPNL_p2ProDisInvestment = CType(doc_p2ProDisInvestment.Controls(0), ucPNL_p2ProDisInvestment)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2ProDisInvestment)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2ProDisInvestment)
                Case TaxComPNLEnuItem.FORINCREMIT
                    If doc_p2ForeIncomeRemmit Is Nothing OrElse doc_p2ForeIncomeRemmit.IsDisposed Then
                        doc_p2ForeIncomeRemmit = New DockPanel
                        Dim uc As New ucPNL_p2ForeIncomeRemmit

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p2ForeIncomeRemmit.Text = lbl.Text
                        doc_p2ForeIncomeRemmit.Name = TaxComPNLEnuItem.FORINCREMIT.ToString
                        doc_p2ForeIncomeRemmit.Controls.Add(uc)
                        doc_p2ForeIncomeRemmit.DockedAsTabbedDocument = True
                        doc_p2ForeIncomeRemmit.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p2ForeIncomeRemmit)
                    Else
                        doc_p2ForeIncomeRemmit.Visibility = DockVisibility.Visible
                        If doc_p2ForeIncomeRemmit.Controls.Count > 0 AndAlso TypeOf doc_p2ForeIncomeRemmit.Controls(0) Is ucPNL_p2ForeIncomeRemmit Then
                            Dim uc As ucPNL_p2ForeIncomeRemmit = CType(doc_p2ForeIncomeRemmit.Controls(0), ucPNL_p2ForeIncomeRemmit)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2ForeIncomeRemmit)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2ForeIncomeRemmit)
                Case TaxComPNLEnuItem.REALFE
                    If doc_p2ReaForeExGainNonTrade Is Nothing OrElse doc_p2ReaForeExGainNonTrade.IsDisposed Then
                        doc_p2ReaForeExGainNonTrade = New DockPanel
                        Dim uc As New ucPNL_p2ReaForeExGainNonTrade

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p2ReaForeExGainNonTrade.Text = lbl.Text
                        doc_p2ReaForeExGainNonTrade.Name = TaxComPNLEnuItem.REALFE.ToString
                        doc_p2ReaForeExGainNonTrade.Controls.Add(uc)
                        doc_p2ReaForeExGainNonTrade.DockedAsTabbedDocument = True
                        doc_p2ReaForeExGainNonTrade.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p2ReaForeExGainNonTrade)
                    Else
                        doc_p2ReaForeExGainNonTrade.Visibility = DockVisibility.Visible
                        If doc_p2ReaForeExGainNonTrade.Controls.Count > 0 AndAlso TypeOf doc_p2ReaForeExGainNonTrade.Controls(0) Is ucPNL_p2ReaForeExGainNonTrade Then
                            Dim uc As ucPNL_p2ReaForeExGainNonTrade = CType(doc_p2ReaForeExGainNonTrade.Controls(0), ucPNL_p2ReaForeExGainNonTrade)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2ReaForeExGainNonTrade)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2ReaForeExGainNonTrade)
                Case TaxComPNLEnuItem.UNREALFETRADE
                    If doc_p2UnreaGainForeEx Is Nothing OrElse doc_p2UnreaGainForeEx.IsDisposed Then
                        doc_p2UnreaGainForeEx = New DockPanel
                        Dim uc As New ucPNL_p2UnreaGainForeEx

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p2UnreaGainForeEx.Text = lbl.Text
                        doc_p2UnreaGainForeEx.Name = TaxComPNLEnuItem.UNREALFETRADE.ToString
                        doc_p2UnreaGainForeEx.Controls.Add(uc)
                        doc_p2UnreaGainForeEx.DockedAsTabbedDocument = True
                        doc_p2UnreaGainForeEx.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p2UnreaGainForeEx)
                    Else
                        doc_p2UnreaGainForeEx.Visibility = DockVisibility.Visible
                        If doc_p2UnreaGainForeEx.Controls.Count > 0 AndAlso TypeOf doc_p2UnreaGainForeEx.Controls(0) Is ucPNL_p2UnreaGainForeEx Then
                            Dim uc As ucPNL_p2UnreaGainForeEx = CType(doc_p2UnreaGainForeEx.Controls(0), ucPNL_p2UnreaGainForeEx)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2UnreaGainForeEx)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2UnreaGainForeEx)
                Case TaxComPNLEnuItem.UNREALFENONTRADE
                    If doc_p2UnreaGainForeExNon Is Nothing OrElse doc_p2UnreaGainForeExNon.IsDisposed Then
                        doc_p2UnreaGainForeExNon = New DockPanel
                        Dim uc As New ucPNL_p2UnreaGainForeExNon

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p2UnreaGainForeExNon.Text = lbl.Text
                        doc_p2UnreaGainForeExNon.Name = TaxComPNLEnuItem.UNREALFENONTRADE.ToString
                        doc_p2UnreaGainForeExNon.Controls.Add(uc)
                        doc_p2UnreaGainForeExNon.DockedAsTabbedDocument = True
                        doc_p2UnreaGainForeExNon.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p2UnreaGainForeExNon)
                    Else
                        doc_p2UnreaGainForeExNon.Visibility = DockVisibility.Visible
                        If doc_p2UnreaGainForeExNon.Controls.Count > 0 AndAlso TypeOf doc_p2UnreaGainForeExNon.Controls(0) Is ucPNL_p2UnreaGainForeExNon Then
                            Dim uc As ucPNL_p2UnreaGainForeExNon = CType(doc_p2UnreaGainForeExNon.Controls(0), ucPNL_p2UnreaGainForeExNon)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2UnreaGainForeExNon)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2UnreaGainForeExNon)
                Case TaxComPNLEnuItem.EXPOTHERINTEREST
                    If doc_p3OtherInterestExHirePur Is Nothing OrElse doc_p3OtherInterestExHirePur.IsDisposed Then
                        doc_p3OtherInterestExHirePur = New DockPanel
                        Dim uc As New ucPNL_p3OtherInterestExHirePur

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p3OtherInterestExHirePur.Text = lbl.Text
                        doc_p3OtherInterestExHirePur.Name = TaxComPNLEnuItem.EXPOTHERINTEREST.ToString
                        doc_p3OtherInterestExHirePur.Controls.Add(uc)
                        doc_p3OtherInterestExHirePur.DockedAsTabbedDocument = True
                        doc_p3OtherInterestExHirePur.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p3OtherInterestExHirePur)
                    Else
                        doc_p3OtherInterestExHirePur.Visibility = DockVisibility.Visible
                        If doc_p3OtherInterestExHirePur.Controls.Count > 0 AndAlso TypeOf doc_p3OtherInterestExHirePur.Controls(0) Is ucPNL_p3OtherInterestExHirePur Then
                            Dim uc As ucPNL_p3OtherInterestExHirePur = CType(doc_p3OtherInterestExHirePur.Controls(0), ucPNL_p3OtherInterestExHirePur)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3OtherInterestExHirePur)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3OtherInterestExHirePur)
                Case TaxComPNLEnuItem.EXPLEGAL
                    If doc_p3ProTechManLeganFees Is Nothing OrElse doc_p3ProTechManLeganFees.IsDisposed Then
                        doc_p3ProTechManLeganFees = New DockPanel
                        Dim uc As New ucPNL_p3ProTechManLeganFees

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p3ProTechManLeganFees.Text = lbl.Text
                        doc_p3ProTechManLeganFees.Name = TaxComPNLEnuItem.EXPLEGAL.ToString
                        doc_p3ProTechManLeganFees.Controls.Add(uc)
                        doc_p3ProTechManLeganFees.DockedAsTabbedDocument = True
                        doc_p3ProTechManLeganFees.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p3ProTechManLeganFees)
                    Else
                        doc_p3ProTechManLeganFees.Visibility = DockVisibility.Visible
                        If doc_p3ProTechManLeganFees.Controls.Count > 0 AndAlso TypeOf doc_p3ProTechManLeganFees.Controls(0) Is ucPNL_p3ProTechManLeganFees Then
                            Dim uc As ucPNL_p3ProTechManLeganFees = CType(doc_p3ProTechManLeganFees.Controls(0), ucPNL_p3ProTechManLeganFees)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3ProTechManLeganFees)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3ProTechManLeganFees)
                Case TaxComPNLEnuItem.EXPTECHNICAL
                    If doc_p3TechPayNonResis Is Nothing OrElse doc_p3TechPayNonResis.IsDisposed Then
                        doc_p3TechPayNonResis = New DockPanel
                        Dim uc As New ucPNL_p3TechPayNonResis

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.RowInfo = RowInfo
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        doc_p3TechPayNonResis.Text = lbl.Text
                        doc_p3TechPayNonResis.Name = TaxComPNLEnuItem.EXPTECHNICAL.ToString
                        doc_p3TechPayNonResis.Controls.Add(uc)
                        doc_p3TechPayNonResis.DockedAsTabbedDocument = True
                        doc_p3TechPayNonResis.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p3TechPayNonResis)
                    Else
                        doc_p3TechPayNonResis.Visibility = DockVisibility.Visible
                        If doc_p3TechPayNonResis.Controls.Count > 0 AndAlso TypeOf doc_p3TechPayNonResis.Controls(0) Is ucPNL_p3TechPayNonResis Then
                            Dim uc As ucPNL_p3TechPayNonResis = CType(doc_p3TechPayNonResis.Controls(0), ucPNL_p3TechPayNonResis)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3TechPayNonResis)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3TechPayNonResis)
                Case TaxComPNLEnuItem.EXPCONTRACTPAY
                    If doc_p3ContractPay Is Nothing OrElse doc_p3ContractPay.IsDisposed Then
                        doc_p3ContractPay = New DockPanel
                        Dim uc As New ucPNL_p3ContractPay

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p3ContractPay.Text = lbl.Text
                        doc_p3ContractPay.Name = TaxComPNLEnuItem.EXPCONTRACTPAY.ToString
                        doc_p3ContractPay.Controls.Add(uc)
                        doc_p3ContractPay.DockedAsTabbedDocument = True
                        doc_p3ContractPay.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p3ContractPay)
                    Else
                        doc_p3ContractPay.Visibility = DockVisibility.Visible
                        If doc_p3ContractPay.Controls.Count > 0 AndAlso TypeOf doc_p3ContractPay.Controls(0) Is ucPNL_p3ContractPay Then
                            Dim uc As ucPNL_p3ContractPay = CType(doc_p3ContractPay.Controls(0), ucPNL_p3ContractPay)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3ContractPay)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3ContractPay)
                Case TaxComPNLEnuItem.EXPDIRECTORFEE
                    If doc_p3DirectorFee Is Nothing OrElse doc_p3DirectorFee.IsDisposed Then
                        doc_p3DirectorFee = New DockPanel
                        Dim uc As New ucPNL_p3DirectorFee

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p3DirectorFee.Text = lbl.Text
                        doc_p3DirectorFee.Name = TaxComPNLEnuItem.EXPDIRECTORFEE.ToString
                        doc_p3DirectorFee.Controls.Add(uc)
                        doc_p3DirectorFee.DockedAsTabbedDocument = True
                        doc_p3DirectorFee.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p3DirectorFee)
                    Else
                        doc_p3DirectorFee.Visibility = DockVisibility.Visible
                        If doc_p3DirectorFee.Controls.Count > 0 AndAlso TypeOf doc_p3DirectorFee.Controls(0) Is ucPNL_p3DirectorFee Then
                            Dim uc As ucPNL_p3DirectorFee = CType(doc_p3DirectorFee.Controls(0), ucPNL_p3DirectorFee)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3DirectorFee)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3DirectorFee)
                Case TaxComPNLEnuItem.EXPSALARY
                    If doc_p3Salary Is Nothing OrElse doc_p3Salary.IsDisposed Then
                        doc_p3Salary = New DockPanel
                        Dim uc As New ucPNL_p3Salary

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p3Salary.Text = lbl.Text
                        doc_p3Salary.Name = TaxComPNLEnuItem.EXPSALARY.ToString
                        doc_p3Salary.Controls.Add(uc)
                        doc_p3Salary.DockedAsTabbedDocument = True
                        doc_p3Salary.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p3Salary)
                    Else
                        doc_p3Salary.Visibility = DockVisibility.Visible
                        If doc_p3Salary.Controls.Count > 0 AndAlso TypeOf doc_p3Salary.Controls(0) Is ucPNL_p3Salary Then
                            Dim uc As ucPNL_p3Salary = CType(doc_p3Salary.Controls(0), ucPNL_p3Salary)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3Salary)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3Salary)
                Case TaxComPNLEnuItem.EXPEMPLOYEESTOCK
                    If doc_p3COEStock Is Nothing OrElse doc_p3COEStock.IsDisposed Then
                        doc_p3COEStock = New DockPanel
                        Dim uc As New ucPNL_p3COEStock

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p3COEStock.Text = lbl.Text
                        doc_p3COEStock.Name = TaxComPNLEnuItem.EXPEMPLOYEESTOCK.ToString
                        doc_p3COEStock.Controls.Add(uc)
                        doc_p3COEStock.DockedAsTabbedDocument = True
                        doc_p3COEStock.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p3COEStock)
                    Else
                        doc_p3COEStock.Visibility = DockVisibility.Visible
                        If doc_p3COEStock.Controls.Count > 0 AndAlso TypeOf doc_p3COEStock.Controls(0) Is ucPNL_p3COEStock Then
                            Dim uc As ucPNL_p3COEStock = CType(doc_p3COEStock.Controls(0), ucPNL_p3COEStock)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3COEStock)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3COEStock)
                Case TaxComPNLEnuItem.EXPROYALTY
                    If doc_p3Royalty Is Nothing OrElse doc_p3Royalty.IsDisposed Then
                        doc_p3Royalty = New DockPanel
                        Dim uc As New ucPNL_p3Royalty

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p3Royalty.Text = lbl.Text
                        doc_p3Royalty.Name = TaxComPNLEnuItem.EXPROYALTY.ToString
                        doc_p3Royalty.Controls.Add(uc)
                        doc_p3Royalty.DockedAsTabbedDocument = True
                        doc_p3Royalty.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p3Royalty)
                    Else
                        doc_p3Royalty.Visibility = DockVisibility.Visible
                        If doc_p3Royalty.Controls.Count > 0 AndAlso TypeOf doc_p3Royalty.Controls(0) Is ucPNL_p3Royalty Then
                            Dim uc As ucPNL_p3Royalty = CType(doc_p3Royalty.Controls(0), ucPNL_p3Royalty)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3Royalty)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3Royalty)
                Case TaxComPNLEnuItem.EXPRENTAL
                    If doc_p3Rental Is Nothing OrElse doc_p3Rental.IsDisposed Then
                        doc_p3Rental = New DockPanel
                        Dim uc As New ucPNL_p3Rental

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p3Rental.Text = lbl.Text
                        doc_p3Rental.Name = TaxComPNLEnuItem.EXPRENTAL.ToString
                        doc_p3Rental.Controls.Add(uc)
                        doc_p3Rental.DockedAsTabbedDocument = True
                        doc_p3Rental.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p3Rental)
                    Else
                        doc_p3Rental.Visibility = DockVisibility.Visible
                        If doc_p3Rental.Controls.Count > 0 AndAlso TypeOf doc_p3Rental.Controls(0) Is ucPNL_p3Rental Then
                            Dim uc As ucPNL_p3Rental = CType(doc_p3Rental.Controls(0), ucPNL_p3Rental)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3Rental)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3Rental)
                Case TaxComPNLEnuItem.EXPREPAIRMAINTENANCE
                    If doc_p3RepairMain Is Nothing OrElse doc_p3RepairMain.IsDisposed Then
                        doc_p3RepairMain = New DockPanel
                        Dim uc As New ucPNL_p3RepairMain

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p3RepairMain.Text = lbl.Text
                        doc_p3RepairMain.Name = TaxComPNLEnuItem.EXPREPAIRMAINTENANCE.ToString
                        doc_p3RepairMain.Controls.Add(uc)
                        doc_p3RepairMain.DockedAsTabbedDocument = True
                        doc_p3RepairMain.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p3RepairMain)
                    Else
                        doc_p3RepairMain.Visibility = DockVisibility.Visible
                        If doc_p3RepairMain.Controls.Count > 0 AndAlso TypeOf doc_p3RepairMain.Controls(0) Is ucPNL_p3RepairMain Then
                            Dim uc As ucPNL_p3RepairMain = CType(doc_p3RepairMain.Controls(0), ucPNL_p3RepairMain)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3RepairMain)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3RepairMain)
                Case TaxComPNLEnuItem.EXPRND
                    If doc_p3ResearchDev Is Nothing OrElse doc_p3ResearchDev.IsDisposed Then
                        doc_p3ResearchDev = New DockPanel
                        Dim uc As New ucPNL_p3ResearchDev

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p3ResearchDev.Text = lbl.Text
                        doc_p3ResearchDev.Name = TaxComPNLEnuItem.EXPRND.ToString
                        doc_p3ResearchDev.Controls.Add(uc)
                        doc_p3ResearchDev.DockedAsTabbedDocument = True
                        doc_p3ResearchDev.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p3ResearchDev)
                    Else
                        doc_p3ResearchDev.Visibility = DockVisibility.Visible
                        If doc_p3ResearchDev.Controls.Count > 0 AndAlso TypeOf doc_p3ResearchDev.Controls(0) Is ucPNL_p3ResearchDev Then
                            Dim uc As ucPNL_p3ResearchDev = CType(doc_p3ResearchDev.Controls(0), ucPNL_p3ResearchDev)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3ResearchDev)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3ResearchDev)
                Case TaxComPNLEnuItem.EXPADVERTISEMENT
                    If doc_p3PromotionAds Is Nothing OrElse doc_p3PromotionAds.IsDisposed Then
                        doc_p3PromotionAds = New DockPanel
                        Dim uc As New ucPNL_p3PromotionAds

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p3PromotionAds.Text = lbl.Text
                        doc_p3PromotionAds.Name = TaxComPNLEnuItem.EXPADVERTISEMENT.ToString
                        doc_p3PromotionAds.Controls.Add(uc)
                        doc_p3PromotionAds.DockedAsTabbedDocument = True
                        doc_p3PromotionAds.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p3PromotionAds)
                    Else
                        doc_p3PromotionAds.Visibility = DockVisibility.Visible
                        If doc_p3PromotionAds.Controls.Count > 0 AndAlso TypeOf doc_p3PromotionAds.Controls(0) Is ucPNL_p3PromotionAds Then
                            Dim uc As ucPNL_p3PromotionAds = CType(doc_p3PromotionAds.Controls(0), ucPNL_p3PromotionAds)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3PromotionAds)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3PromotionAds)
                Case TaxComPNLEnuItem.EXPTRAVEL
                    If doc_p3Travelling Is Nothing OrElse doc_p3Travelling.IsDisposed Then
                        doc_p3Travelling = New DockPanel
                        Dim uc As New ucPNL_p3Travelling

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p3Travelling.Text = lbl.Text
                        doc_p3Travelling.Name = TaxComPNLEnuItem.EXPTRAVEL.ToString
                        doc_p3Travelling.Controls.Add(uc)
                        doc_p3Travelling.DockedAsTabbedDocument = True
                        doc_p3Travelling.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p3Travelling)
                    Else
                        doc_p3Travelling.Visibility = DockVisibility.Visible
                        If doc_p3Travelling.Controls.Count > 0 AndAlso TypeOf doc_p3Travelling.Controls(0) Is ucPNL_p3Travelling Then
                            Dim uc As ucPNL_p3Travelling = CType(doc_p3Travelling.Controls(0), ucPNL_p3Travelling)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3Travelling)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3Travelling)
                Case TaxComPNLEnuItem.EXPJKDM
                    If doc_p3JKDM Is Nothing OrElse doc_p3JKDM.IsDisposed Then
                        doc_p3JKDM = New DockPanel
                        Dim uc As New ucPNL_p3JKDM

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p3JKDM.Text = lbl.Text
                        doc_p3JKDM.Name = TaxComPNLEnuItem.EXPJKDM.ToString
                        doc_p3JKDM.Controls.Add(uc)
                        doc_p3JKDM.DockedAsTabbedDocument = True
                        doc_p3JKDM.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p3JKDM)
                    Else
                        doc_p3JKDM.Visibility = DockVisibility.Visible
                        If doc_p3JKDM.Controls.Count > 0 AndAlso TypeOf doc_p3JKDM.Controls(0) Is ucPNL_p3JKDM Then
                            Dim uc As ucPNL_p3JKDM = CType(doc_p3JKDM.Controls(0), ucPNL_p3JKDM)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3JKDM)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3JKDM)
                Case TaxComPNLEnuItem.EXPDEPRECIATION
                    If doc_p3Depreciation Is Nothing OrElse doc_p3Depreciation.IsDisposed Then
                        doc_p3Depreciation = New DockPanel
                        Dim uc As New ucPNL_p3Depreciation

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p3Depreciation.Text = lbl.Text
                        doc_p3Depreciation.Name = TaxComPNLEnuItem.EXPDEPRECIATION.ToString
                        doc_p3Depreciation.Controls.Add(uc)
                        doc_p3Depreciation.DockedAsTabbedDocument = True
                        doc_p3Depreciation.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p3Depreciation)
                    Else
                        doc_p3Depreciation.Visibility = DockVisibility.Visible
                        If doc_p3Depreciation.Controls.Count > 0 AndAlso TypeOf doc_p3Depreciation.Controls(0) Is ucPNL_p3Depreciation Then
                            Dim uc As ucPNL_p3Depreciation = CType(doc_p3Depreciation.Controls(0), ucPNL_p3Depreciation)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3Depreciation)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3Depreciation)
                Case TaxComPNLEnuItem.EXPDONATIONAPPR
                    If doc_p3DonationApp Is Nothing OrElse doc_p3DonationApp.IsDisposed Then
                        doc_p3DonationApp = New DockPanel
                        Dim uc As New ucPNL_p3DonationApp

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p3DonationApp.Text = lbl.Text
                        doc_p3DonationApp.Name = TaxComPNLEnuItem.EXPDONATIONAPPR.ToString
                        doc_p3DonationApp.Controls.Add(uc)
                        doc_p3DonationApp.DockedAsTabbedDocument = True
                        doc_p3DonationApp.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p3DonationApp)
                    Else
                        doc_p3DonationApp.Visibility = DockVisibility.Visible
                        If doc_p3DonationApp.Controls.Count > 0 AndAlso TypeOf doc_p3DonationApp.Controls(0) Is ucPNL_p3DonationApp Then
                            Dim uc As ucPNL_p3DonationApp = CType(doc_p3DonationApp.Controls(0), ucPNL_p3DonationApp)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3DonationApp)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3DonationApp)
                Case TaxComPNLEnuItem.EXPDONATIONNONAPPR
                    If doc_p3DonationNonApp Is Nothing OrElse doc_p3DonationNonApp.IsDisposed Then
                        doc_p3DonationNonApp = New DockPanel
                        Dim uc As New ucPNL_p3DonationNonApp

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p3DonationNonApp.Text = lbl.Text
                        doc_p3DonationNonApp.Name = TaxComPNLEnuItem.EXPDONATIONNONAPPR.ToString
                        doc_p3DonationNonApp.Controls.Add(uc)
                        doc_p3DonationNonApp.DockedAsTabbedDocument = True
                        doc_p3DonationNonApp.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p3DonationNonApp)
                    Else
                        doc_p3DonationNonApp.Visibility = DockVisibility.Visible
                        If doc_p3DonationNonApp.Controls.Count > 0 AndAlso TypeOf doc_p3DonationNonApp.Controls(0) Is ucPNL_p3DonationNonApp Then
                            Dim uc As ucPNL_p3DonationNonApp = CType(doc_p3DonationNonApp.Controls(0), ucPNL_p3DonationNonApp)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3DonationNonApp)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3DonationNonApp)

                Case TaxComPNLEnuItem.EXPZAKAT
                    If doc_p3Zakat Is Nothing OrElse doc_p3Zakat.IsDisposed Then
                        doc_p3Zakat = New DockPanel
                        Dim uc As New ucPNL_p3Zakat

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p3Zakat.Text = lbl.Text
                        doc_p3Zakat.Name = TaxComPNLEnuItem.EXPZAKAT.ToString
                        doc_p3Zakat.Controls.Add(uc)
                        doc_p3Zakat.DockedAsTabbedDocument = True
                        doc_p3Zakat.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p3Zakat)
                    Else
                        doc_p3Zakat.Visibility = DockVisibility.Visible
                        If doc_p3Zakat.Controls.Count > 0 AndAlso TypeOf doc_p3Zakat.Controls(0) Is ucPNL_p3Zakat Then
                            Dim uc As ucPNL_p3Zakat = CType(doc_p3Zakat.Controls(0), ucPNL_p3Zakat)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3Zakat)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3Zakat)

                Case TaxComPNLEnuItem.EXPLOSSDISPFA
                    If doc_p4LossDispFA Is Nothing OrElse doc_p4LossDispFA.IsDisposed Then
                        doc_p4LossDispFA = New DockPanel
                        Dim uc As New ucPNL_p4LossDispFA

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p4LossDispFA.Text = lbl.Text
                        doc_p4LossDispFA.Name = TaxComPNLEnuItem.EXPLOSSDISPFA.ToString
                        doc_p4LossDispFA.Controls.Add(uc)
                        doc_p4LossDispFA.DockedAsTabbedDocument = True
                        doc_p4LossDispFA.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p4LossDispFA)
                    Else
                        doc_p4LossDispFA.Visibility = DockVisibility.Visible
                        If doc_p4LossDispFA.Controls.Count > 0 AndAlso TypeOf doc_p4LossDispFA.Controls(0) Is ucPNL_p4LossDispFA Then
                            Dim uc As ucPNL_p4LossDispFA = CType(doc_p4LossDispFA.Controls(0), ucPNL_p4LossDispFA)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4LossDispFA)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4LossDispFA)

                Case TaxComPNLEnuItem.EXPENTERTAINNONSTAFF
                    If doc_p4EntNonStaff Is Nothing OrElse doc_p4EntNonStaff.IsDisposed Then
                        doc_p4EntNonStaff = New DockPanel
                        Dim uc As New ucPNL_p4EntNonStaff

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p4EntNonStaff.Text = lbl.Text
                        doc_p4EntNonStaff.Name = TaxComPNLEnuItem.EXPENTERTAINNONSTAFF.ToString
                        doc_p4EntNonStaff.Controls.Add(uc)
                        doc_p4EntNonStaff.DockedAsTabbedDocument = True
                        doc_p4EntNonStaff.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p4EntNonStaff)
                    Else
                        doc_p4EntNonStaff.Visibility = DockVisibility.Visible
                        If doc_p4EntNonStaff.Controls.Count > 0 AndAlso TypeOf doc_p4EntNonStaff.Controls(0) Is ucPNL_p4EntNonStaff Then
                            Dim uc As ucPNL_p4EntNonStaff = CType(doc_p4EntNonStaff.Controls(0), ucPNL_p4EntNonStaff)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4EntNonStaff)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4EntNonStaff)

                Case TaxComPNLEnuItem.EXPENTERTAINSTAFF
                    If doc_p4EntStaff Is Nothing OrElse doc_p4EntStaff.IsDisposed Then
                        doc_p4EntStaff = New DockPanel
                        Dim uc As New ucPNL_p4EntStaff

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p4EntStaff.Text = lbl.Text
                        doc_p4EntStaff.Name = TaxComPNLEnuItem.EXPENTERTAINSTAFF.ToString
                        doc_p4EntStaff.Controls.Add(uc)
                        doc_p4EntStaff.DockedAsTabbedDocument = True
                        doc_p4EntStaff.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p4EntStaff)
                    Else
                        doc_p4EntStaff.Visibility = DockVisibility.Visible
                        If doc_p4EntStaff.Controls.Count > 0 AndAlso TypeOf doc_p4EntStaff.Controls(0) Is ucPNL_p4EntStaff Then
                            Dim uc As ucPNL_p4EntStaff = CType(doc_p4EntStaff.Controls(0), ucPNL_p4EntStaff)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4EntStaff)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4EntStaff)

                Case TaxComPNLEnuItem.EXPCOMPAUNDPENALTY
                    If doc_p4Compound Is Nothing OrElse doc_p4Compound.IsDisposed Then
                        doc_p4Compound = New DockPanel
                        Dim uc As New ucPNL_p4Compound

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p4Compound.Text = lbl.Text
                        doc_p4Compound.Name = TaxComPNLEnuItem.EXPCOMPAUNDPENALTY.ToString
                        doc_p4Compound.Controls.Add(uc)
                        doc_p4Compound.DockedAsTabbedDocument = True
                        doc_p4Compound.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p4Compound)
                    Else
                        doc_p4Compound.Visibility = DockVisibility.Visible
                        If doc_p4Compound.Controls.Count > 0 AndAlso TypeOf doc_p4Compound.Controls(0) Is ucPNL_p4Compound Then
                            Dim uc As ucPNL_p4Compound = CType(doc_p4Compound.Controls(0), ucPNL_p4Compound)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4Compound)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4Compound)

                Case TaxComPNLEnuItem.EXPPROVISION
                    If doc_p4ProvisionAcc Is Nothing OrElse doc_p4ProvisionAcc.IsDisposed Then
                        doc_p4ProvisionAcc = New DockPanel
                        Dim uc As New ucPNL_p4ProvisionAcc

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p4ProvisionAcc.Text = lbl.Text
                        doc_p4ProvisionAcc.Name = TaxComPNLEnuItem.EXPPROVISION.ToString
                        doc_p4ProvisionAcc.Controls.Add(uc)
                        doc_p4ProvisionAcc.DockedAsTabbedDocument = True
                        doc_p4ProvisionAcc.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p4ProvisionAcc)
                    Else
                        doc_p4ProvisionAcc.Visibility = DockVisibility.Visible
                        If doc_p4ProvisionAcc.Controls.Count > 0 AndAlso TypeOf doc_p4ProvisionAcc.Controls(0) Is ucPNL_p4ProvisionAcc Then
                            Dim uc As ucPNL_p4ProvisionAcc = CType(doc_p4ProvisionAcc.Controls(0), ucPNL_p4ProvisionAcc)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4ProvisionAcc)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4ProvisionAcc)


                Case TaxComPNLEnuItem.EXPLEAVEPASSAGE
                    If doc_p4LeavePass Is Nothing OrElse doc_p4LeavePass.IsDisposed Then
                        doc_p4LeavePass = New DockPanel
                        Dim uc As New ucPNL_p4LeavePass

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p4LeavePass.Text = lbl.Text
                        doc_p4LeavePass.Name = TaxComPNLEnuItem.EXPLEAVEPASSAGE.ToString
                        doc_p4LeavePass.Controls.Add(uc)
                        doc_p4LeavePass.DockedAsTabbedDocument = True
                        doc_p4LeavePass.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p4LeavePass)
                    Else
                        doc_p4LeavePass.Visibility = DockVisibility.Visible
                        If doc_p4LeavePass.Controls.Count > 0 AndAlso TypeOf doc_p4LeavePass.Controls(0) Is ucPNL_p4LeavePass Then
                            Dim uc As ucPNL_p4LeavePass = CType(doc_p4LeavePass.Controls(0), ucPNL_p4LeavePass)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4LeavePass)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4LeavePass)

                Case TaxComPNLEnuItem.EXPFAWRITTENOFF
                    If doc_p4FAWrittenOff Is Nothing OrElse doc_p4FAWrittenOff.IsDisposed Then
                        doc_p4FAWrittenOff = New DockPanel
                        Dim uc As New ucPNL_p4FAWrittenOff

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p4FAWrittenOff.Text = lbl.Text
                        doc_p4FAWrittenOff.Name = TaxComPNLEnuItem.EXPFAWRITTENOFF.ToString
                        doc_p4FAWrittenOff.Controls.Add(uc)
                        doc_p4FAWrittenOff.DockedAsTabbedDocument = True
                        doc_p4FAWrittenOff.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p4FAWrittenOff)
                    Else
                        doc_p4FAWrittenOff.Visibility = DockVisibility.Visible
                        If doc_p4FAWrittenOff.Controls.Count > 0 AndAlso TypeOf doc_p4FAWrittenOff.Controls(0) Is ucPNL_p4FAWrittenOff Then
                            Dim uc As ucPNL_p4FAWrittenOff = CType(doc_p4FAWrittenOff.Controls(0), ucPNL_p4FAWrittenOff)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4FAWrittenOff)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4FAWrittenOff)

                Case TaxComPNLEnuItem.EXPUNREALLOSSFE
                    If doc_p4UnreaLossForeEx Is Nothing OrElse doc_p4UnreaLossForeEx.IsDisposed Then
                        doc_p4UnreaLossForeEx = New DockPanel
                        Dim uc As New ucPNL_p4UnreaLossForeEx

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p4UnreaLossForeEx.Text = lbl.Text
                        doc_p4UnreaLossForeEx.Name = TaxComPNLEnuItem.EXPUNREALLOSSFE.ToString
                        doc_p4UnreaLossForeEx.Controls.Add(uc)
                        doc_p4UnreaLossForeEx.DockedAsTabbedDocument = True
                        doc_p4UnreaLossForeEx.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p4UnreaLossForeEx)
                    Else
                        doc_p4UnreaLossForeEx.Visibility = DockVisibility.Visible
                        If doc_p4UnreaLossForeEx.Controls.Count > 0 AndAlso TypeOf doc_p4UnreaLossForeEx.Controls(0) Is ucPNL_p4UnreaLossForeEx Then
                            Dim uc As ucPNL_p4UnreaLossForeEx = CType(doc_p4UnreaLossForeEx.Controls(0), ucPNL_p4UnreaLossForeEx)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4UnreaLossForeEx)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4UnreaLossForeEx)

                Case TaxComPNLEnuItem.EXPREALLOSSFETRADE
                    If doc_p4ReaLossForeExTrade Is Nothing OrElse doc_p4ReaLossForeExTrade.IsDisposed Then
                        doc_p4ReaLossForeExTrade = New DockPanel
                        Dim uc As New ucPNL_p4ReaLossForeExTrade

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p4ReaLossForeExTrade.Text = lbl.Text
                        doc_p4ReaLossForeExTrade.Name = TaxComPNLEnuItem.EXPREALLOSSFETRADE.ToString
                        doc_p4ReaLossForeExTrade.Controls.Add(uc)
                        doc_p4ReaLossForeExTrade.DockedAsTabbedDocument = True
                        doc_p4ReaLossForeExTrade.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p4ReaLossForeExTrade)
                    Else
                        doc_p4ReaLossForeExTrade.Visibility = DockVisibility.Visible
                        If doc_p4ReaLossForeExTrade.Controls.Count > 0 AndAlso TypeOf doc_p4ReaLossForeExTrade.Controls(0) Is ucPNL_p4ReaLossForeExTrade Then
                            Dim uc As ucPNL_p4ReaLossForeExTrade = CType(doc_p4ReaLossForeExTrade.Controls(0), ucPNL_p4ReaLossForeExTrade)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4ReaLossForeExTrade)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4ReaLossForeExTrade)

                Case TaxComPNLEnuItem.EXPREALLOSSFENONTRADE
                    If doc_p4ReaLossForeExNonTrade Is Nothing OrElse doc_p4ReaLossForeExNonTrade.IsDisposed Then
                        doc_p4ReaLossForeExNonTrade = New DockPanel
                        Dim uc As New ucPNL_p4ReaLossForeExNonTrade

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p4ReaLossForeExNonTrade.Text = lbl.Text
                        doc_p4ReaLossForeExNonTrade.Name = TaxComPNLEnuItem.EXPREALLOSSFENONTRADE.ToString
                        doc_p4ReaLossForeExNonTrade.Controls.Add(uc)
                        doc_p4ReaLossForeExNonTrade.DockedAsTabbedDocument = True
                        doc_p4ReaLossForeExNonTrade.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p4ReaLossForeExNonTrade)
                    Else
                        doc_p4ReaLossForeExNonTrade.Visibility = DockVisibility.Visible
                        If doc_p4ReaLossForeExNonTrade.Controls.Count > 0 AndAlso TypeOf doc_p4ReaLossForeExNonTrade.Controls(0) Is ucPNL_p4ReaLossForeExNonTrade Then
                            Dim uc As ucPNL_p4ReaLossForeExNonTrade = CType(doc_p4ReaLossForeExNonTrade.Controls(0), ucPNL_p4ReaLossForeExNonTrade)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4ReaLossForeExNonTrade)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4ReaLossForeExNonTrade)

                Case TaxComPNLEnuItem.EXPINITIALSUBSCRIPT
                    If doc_p4InitSub Is Nothing OrElse doc_p4InitSub.IsDisposed Then
                        doc_p4InitSub = New DockPanel
                        Dim uc As New ucPNL_p4InitSub

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p4InitSub.Text = lbl.Text
                        doc_p4InitSub.Name = TaxComPNLEnuItem.EXPINITIALSUBSCRIPT.ToString
                        doc_p4InitSub.Controls.Add(uc)
                        doc_p4InitSub.DockedAsTabbedDocument = True
                        doc_p4InitSub.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p4InitSub)
                    Else
                        doc_p4InitSub.Visibility = DockVisibility.Visible
                        If doc_p4InitSub.Controls.Count > 0 AndAlso TypeOf doc_p4InitSub.Controls(0) Is ucPNL_p4InitSub Then
                            Dim uc As ucPNL_p4InitSub = CType(doc_p4InitSub.Controls(0), ucPNL_p4InitSub)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4InitSub)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4InitSub)

                Case TaxComPNLEnuItem.EXPCAPITALEXPENDITURE
                    If doc_p4CAExpenditure Is Nothing OrElse doc_p4CAExpenditure.IsDisposed Then
                        doc_p4CAExpenditure = New DockPanel
                        Dim uc As New ucPNL_p4CAExpenditure

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p4CAExpenditure.Text = lbl.Text
                        doc_p4CAExpenditure.Name = TaxComPNLEnuItem.EXPCAPITALEXPENDITURE.ToString
                        doc_p4CAExpenditure.Controls.Add(uc)
                        doc_p4CAExpenditure.DockedAsTabbedDocument = True
                        doc_p4CAExpenditure.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p4CAExpenditure)
                    Else
                        doc_p4CAExpenditure.Visibility = DockVisibility.Visible
                        If doc_p4CAExpenditure.Controls.Count > 0 AndAlso TypeOf doc_p4CAExpenditure.Controls(0) Is ucPNL_p4CAExpenditure Then
                            Dim uc As ucPNL_p4CAExpenditure = CType(doc_p4CAExpenditure.Controls(0), ucPNL_p4CAExpenditure)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4CAExpenditure)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4CAExpenditure)

                Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
                    If doc_p4Other Is Nothing OrElse doc_p4Other.IsDisposed Then
                        doc_p4Other = New DockPanel
                        Dim uc As New ucPNL_p4Other

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p4Other.Text = lbl.Text
                        doc_p4Other.Name = TaxComPNLEnuItem.EXPOTHERSEXPENSES.ToString
                        doc_p4Other.Controls.Add(uc)
                        doc_p4Other.DockedAsTabbedDocument = True
                        doc_p4Other.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p4Other)
                    Else
                        doc_p4Other.Visibility = DockVisibility.Visible
                        If doc_p4Other.Controls.Count > 0 AndAlso TypeOf doc_p4Other.Controls(0) Is ucPNL_p4Other Then
                            Dim uc As ucPNL_p4Other = CType(doc_p4Other.Controls(0), ucPNL_p4Other)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4Other)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4Other)
                Case TaxComPNLEnuItem.RENTALINC
                    If doc_p2RentalIncome Is Nothing OrElse doc_p2RentalIncome.IsDisposed Then
                        doc_p2RentalIncome = New DockPanel
                        Dim uc As New ucPNL_p2RentalIncome

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.txtSales = txtSales
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p2RentalIncome.Text = lbl.Text
                        doc_p2RentalIncome.Name = TaxComPNLEnuItem.RENTALINC.ToString
                        doc_p2RentalIncome.Controls.Add(uc)
                        doc_p2RentalIncome.DockedAsTabbedDocument = True
                        doc_p2RentalIncome.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p2RentalIncome)
                    Else
                        doc_p2RentalIncome.Visibility = DockVisibility.Visible
                        If doc_p2RentalIncome.Controls.Count > 0 AndAlso TypeOf doc_p2RentalIncome.Controls(0) Is ucPNL_p2RentalIncome Then
                            Dim uc As ucPNL_p2RentalIncome = CType(doc_p2RentalIncome.Controls(0), ucPNL_p2RentalIncome)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2RentalIncome)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2RentalIncome)
                Case TaxComPNLEnuItem.NONALLOWABLEEXPENSES
                    If doc_p4NonAllowableExpenses Is Nothing OrElse doc_p4NonAllowableExpenses.IsDisposed Then
                        doc_p4NonAllowableExpenses = New DockPanel
                        Dim uc As New ucPNL_p4NonAllowableExpenses

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        doc_p4NonAllowableExpenses.Text = lbl.Text
                        doc_p4NonAllowableExpenses.Name = TaxComPNLEnuItem.NONALLOWABLEEXPENSES.ToString
                        doc_p4NonAllowableExpenses.Controls.Add(uc)
                        doc_p4NonAllowableExpenses.DockedAsTabbedDocument = True
                        doc_p4NonAllowableExpenses.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p4NonAllowableExpenses)
                    Else
                        doc_p4NonAllowableExpenses.Visibility = DockVisibility.Visible
                        If doc_p4NonAllowableExpenses.Controls.Count > 0 AndAlso TypeOf doc_p4NonAllowableExpenses.Controls(0) Is ucPNL_p4NonAllowableExpenses Then
                            Dim uc As ucPNL_p4NonAllowableExpenses = CType(doc_p4NonAllowableExpenses.Controls(0), ucPNL_p4NonAllowableExpenses)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4NonAllowableExpenses)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4NonAllowableExpenses)
                Case TaxComPNLEnuItem.OTHERNONTAXINC
                    If doc_p2Other Is Nothing OrElse doc_p2Other.IsDisposed Then
                        doc_p2Other = New DockPanel
                        Dim uc As New ucPNL_p2Other

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p2Other.Text = lbl.Text
                        doc_p2Other.Name = TaxComPNLEnuItem.OTHERNONTAXINC.ToString
                        doc_p2Other.Controls.Add(uc)
                        doc_p2Other.DockedAsTabbedDocument = True
                        doc_p2Other.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p2Other)
                    Else
                        doc_p2Other.Visibility = DockVisibility.Visible
                        If doc_p2Other.Controls.Count > 0 AndAlso TypeOf doc_p2Other.Controls(0) Is ucPNL_p2Other Then
                            Dim uc As ucPNL_p2Other = CType(doc_p2Other.Controls(0), ucPNL_p2Other)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2Other)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2Other)
                Case TaxComPNLEnuItem.EXEMDIV
                    If doc_p2ExemptDividend Is Nothing OrElse doc_p2ExemptDividend.IsDisposed Then
                        doc_p2ExemptDividend = New DockPanel
                        Dim uc As New ucPNL_p2ExemptDividend

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p2ExemptDividend.Text = lbl.Text
                        doc_p2ExemptDividend.Name = TaxComPNLEnuItem.EXEMDIV.ToString
                        doc_p2ExemptDividend.Controls.Add(uc)
                        doc_p2ExemptDividend.DockedAsTabbedDocument = True
                        doc_p2ExemptDividend.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p2ExemptDividend)
                    Else
                        doc_p2ExemptDividend.Visibility = DockVisibility.Visible
                        If doc_p2ExemptDividend.Controls.Count > 0 AndAlso TypeOf doc_p2ExemptDividend.Controls(0) Is ucPNL_p2ExemptDividend Then
                            Dim uc As ucPNL_p2ExemptDividend = CType(doc_p2ExemptDividend.Controls(0), ucPNL_p2ExemptDividend)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2ExemptDividend)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2ExemptDividend)
                Case TaxComPNLEnuItem.INTERESTRESTRICT
                    If doc_p3InterestResPurS33 Is Nothing OrElse doc_p3InterestResPurS33.IsDisposed Then
                        doc_p3InterestResPurS33 = New DockPanel
                        Dim uc As New ucPNL_p3InterestResPurS33

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.DataView_Main = dsDataSet
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p3InterestResPurS33.Text = lbl.Text
                        doc_p3InterestResPurS33.Name = TaxComPNLEnuItem.INTERESTRESTRICT.ToString
                        doc_p3InterestResPurS33.Controls.Add(uc)
                        doc_p3InterestResPurS33.DockedAsTabbedDocument = True
                        doc_p3InterestResPurS33.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p3InterestResPurS33)
                    Else
                        doc_p3InterestResPurS33.Visibility = DockVisibility.Visible
                        If doc_p3InterestResPurS33.Controls.Count > 0 AndAlso TypeOf doc_p3InterestResPurS33.Controls(0) Is ucPNL_p3InterestResPurS33 Then
                            Dim uc As ucPNL_p3InterestResPurS33 = CType(doc_p3InterestResPurS33.Controls(0), ucPNL_p3InterestResPurS33)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3InterestResPurS33)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3InterestResPurS33)
                Case TaxComPNLEnuItem.DIVIDENDINC
                    If doc_p2DivIncome Is Nothing OrElse doc_p2DivIncome.IsDisposed Then
                        doc_p2DivIncome = New DockPanel
                        Dim uc As New ucPNL_p2DivIncome

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.txtSales = txtSales
                        uc.DataView_Main = dsDataSet
                        uc.DataView_Main2 = dsDataSet
                        uc.SourceNo = cboSourceNo
                        uc.Dock = DockStyle.Fill
                        uc.txtAmount = txtAmount
                        uc.RowInfo = RowInfo
                        doc_p2DivIncome.Text = lbl.Text
                        doc_p2DivIncome.Name = TaxComPNLEnuItem.DIVIDENDINC.ToString
                        doc_p2DivIncome.Controls.Add(uc)
                        doc_p2DivIncome.DockedAsTabbedDocument = True
                        doc_p2DivIncome.Register(DockingManager)


                        DockDocument.View.AddDocument(doc_p2DivIncome)
                    Else
                        doc_p2DivIncome.Visibility = DockVisibility.Visible
                        If doc_p2DivIncome.Controls.Count > 0 AndAlso TypeOf doc_p2DivIncome.Controls(0) Is ucPNL_p2DivIncome Then
                            Dim uc As ucPNL_p2DivIncome = CType(doc_p2DivIncome.Controls(0), ucPNL_p2DivIncome)
                            uc.RefNo = RefNo
                            uc.txtAmount = txtAmount
                            uc.RowInfo = RowInfo
                            uc.YA = YA
                            uc.SourceNo = cboSourceNo
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2DivIncome)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2DivIncome)
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
    'Public Function ViewPNL(ByVal Type As mdlEnum.TaxComPNLEnuItem, ByRef DockingManager As DockManager, _
    '                        ByRef DockDocument As DevExpress.XtraBars.Docking2010.DocumentManager, ByVal lbl As DevExpress.XtraEditors.LabelControl, _
    '                        ByVal txtAmount As DevExpress.XtraEditors.TextEdit, _
    '                        ByVal tabView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView, _
    '                        ByVal RefNo As String, ByVal YA As String,
    '                        Optional ByRef Errorlog As clsError = Nothing, Optional ByRef txtSales As DevExpress.XtraEditors.TextEdit = Nothing, Optional ByRef SourceNo As Integer = 0, Optional ByVal cboSourceNo As DevExpress.XtraBars.BarEditItem = Nothing) As Boolean
    '    Try
    '        DockDocument.BeginUpdate()
    '        Dim doc As DevExpress.XtraBars.Docking2010.Views.BaseDocument
    '        Select Case Type
    '            Case TaxComPNLEnuItem.SALES

    '                If P1_docSales Is Nothing OrElse P1_docSales.IsDisposed Then
    '                    P1_docSales = New DockPanel
    '                    Dim uc As New ucPNL_p1Sales

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.SourceNo = cboSourceNo
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P1_docSales.Text = lbl.Text
    '                    P1_docSales.Name = TaxComPNLEnuItem.SALES.ToString
    '                    P1_docSales.Controls.Add(uc)
    '                    P1_docSales.Register(DockingManager)
    '                    doc = DockDocument.View.AddDocument(P1_docSales)
    '                Else
    '                    P1_docSales.Visibility = DockVisibility.Visible
    '                    If P1_docSales.Controls.Count > 0 AndAlso TypeOf P1_docSales.Controls(0) Is ucPNL_p1Sales Then
    '                        Dim uc As ucPNL_p1Sales = CType(P1_docSales.Controls(0), ucPNL_p1Sales)
    '                        uc.RefNo = RefNo
    '                        uc.txtAmount = txtAmount
    '                        uc.YA = YA
    '                        uc.SourceNo = cboSourceNo
    '                    End If
    '                    doc = DockDocument.View.AddDocument(P1_docSales)
    '                End If

    '                DockDocument.View.ActivateDocument(P1_docSales)

    '            Case TaxComPNLEnuItem.OPENSTOCK
    '                If P1_docOpeningStock Is Nothing OrElse P1_docOpeningStock.IsDisposed Then
    '                    P1_docOpeningStock = New DockPanel
    '                    Dim uc As New ucPNL_p1OpeningStock

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.SourceNo = cboSourceNo
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P1_docOpeningStock.Text = lbl.Text
    '                    P1_docOpeningStock.Name = TaxComPNLEnuItem.OPENSTOCK.ToString
    '                    P1_docOpeningStock.Controls.Add(uc)
    '                    P1_docOpeningStock.DockedAsTabbedDocument = True
    '                    P1_docOpeningStock.Register(DockingManager)

    '                    DockDocument.View.AddDocument(P1_docOpeningStock)
    '                Else
    '                    P1_docOpeningStock.Visibility = DockVisibility.Visible
    '                    If P1_docOpeningStock.Controls.Count > 0 AndAlso TypeOf P1_docOpeningStock.Controls(0) Is ucPNL_p1Sales Then
    '                        Dim uc As ucPNL_p1Sales = CType(P1_docOpeningStock.Controls(0), ucPNL_p1Sales)
    '                        uc.RefNo = RefNo
    '                        uc.txtAmount = txtAmount
    '                        uc.YA = YA
    '                        uc.SourceNo = cboSourceNo
    '                    End If
    '                    doc = DockDocument.View.AddDocument(P1_docOpeningStock)
    '                End If
    '                DockDocument.View.ActivateDocument(P1_docOpeningStock)

    '            Case TaxComPNLEnuItem.PURCHASE
    '                If P1_docPurchase Is Nothing OrElse P1_docPurchase.IsDisposed Then
    '                    P1_docPurchase = New DockPanel
    '                    Dim uc As New ucPNL_p1Purchase

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.SourceNo = cboSourceNo
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P1_docPurchase.Text = lbl.Text
    '                    P1_docPurchase.Name = TaxComPNLEnuItem.PURCHASE.ToString
    '                    P1_docPurchase.Controls.Add(uc)
    '                    P1_docPurchase.DockedAsTabbedDocument = True
    '                    P1_docPurchase.Register(DockingManager)

    '                    DockDocument.View.AddDocument(P1_docPurchase)
    '                Else
    '                    P1_docPurchase.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P1_docPurchase)
    '                End If
    '                DockDocument.View.ActivateDocument(P1_docPurchase)

    '            Case TaxComPNLEnuItem.DEPRECIATION
    '                If P1_docDepreciation Is Nothing OrElse P1_docDepreciation.IsDisposed Then
    '                    P1_docDepreciation = New DockPanel
    '                    Dim uc As New ucPNL_p1Depreciation

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.SourceNo = cboSourceNo
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P1_docDepreciation.Text = lbl.Text
    '                    P1_docDepreciation.Name = TaxComPNLEnuItem.DEPRECIATION.ToString
    '                    P1_docDepreciation.Controls.Add(uc)
    '                    P1_docDepreciation.DockedAsTabbedDocument = True
    '                    P1_docDepreciation.Register(DockingManager)

    '                    DockDocument.View.AddDocument(P1_docDepreciation)
    '                Else
    '                    P1_docDepreciation.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P1_docDepreciation)
    '                End If
    '                DockDocument.View.ActivateDocument(P1_docDepreciation)
    '            Case TaxComPNLEnuItem.OTHERALLOWEXP
    '                If P1_docAllowanceExpenses Is Nothing OrElse P1_docAllowanceExpenses.IsDisposed Then
    '                    P1_docAllowanceExpenses = New DockPanel
    '                    Dim uc As New ucPNL_p1AllowanceExpenses

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.SourceNo = cboSourceNo
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P1_docAllowanceExpenses.Text = lbl.Text
    '                    P1_docAllowanceExpenses.Name = TaxComPNLEnuItem.OTHERALLOWEXP.ToString
    '                    P1_docAllowanceExpenses.Controls.Add(uc)
    '                    P1_docAllowanceExpenses.DockedAsTabbedDocument = True
    '                    P1_docAllowanceExpenses.Register(DockingManager)

    '                    DockDocument.View.AddDocument(P1_docAllowanceExpenses)
    '                Else
    '                    P1_docAllowanceExpenses.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P1_docAllowanceExpenses)
    '                End If
    '                DockDocument.View.ActivateDocument(P1_docAllowanceExpenses)
    '            Case TaxComPNLEnuItem.OTHERNONALLOWEXP
    '                If P1_docNonAllowableExpenses Is Nothing OrElse P1_docNonAllowableExpenses.IsDisposed Then
    '                    P1_docNonAllowableExpenses = New DockPanel
    '                    Dim uc As New ucPNL_p1NonAllowableExpenses

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.SourceNo = cboSourceNo
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P1_docNonAllowableExpenses.Text = lbl.Text
    '                    P1_docNonAllowableExpenses.Name = TaxComPNLEnuItem.OTHERNONALLOWEXP.ToString
    '                    P1_docNonAllowableExpenses.Controls.Add(uc)
    '                    P1_docNonAllowableExpenses.DockedAsTabbedDocument = True
    '                    P1_docNonAllowableExpenses.Register(DockingManager)

    '                    DockDocument.View.AddDocument(P1_docNonAllowableExpenses)
    '                Else
    '                    P1_docNonAllowableExpenses.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P1_docNonAllowableExpenses)
    '                End If
    '                DockDocument.View.ActivateDocument(P1_docNonAllowableExpenses)
    '            Case TaxComPNLEnuItem.CLOSESTOCK
    '                If P1_docCloseStock Is Nothing OrElse P1_docCloseStock.IsDisposed Then
    '                    P1_docCloseStock = New DockPanel
    '                    Dim uc As New ucPNL_p1CloseStock

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.SourceNo = cboSourceNo
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P1_docCloseStock.Text = lbl.Text
    '                    P1_docCloseStock.Name = TaxComPNLEnuItem.CLOSESTOCK.ToString
    '                    P1_docCloseStock.Controls.Add(uc)
    '                    P1_docCloseStock.DockedAsTabbedDocument = True
    '                    P1_docCloseStock.Register(DockingManager)

    '                    DockDocument.View.AddDocument(P1_docCloseStock)
    '                Else
    '                    P1_docCloseStock.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P1_docCloseStock)
    '                End If
    '                DockDocument.View.ActivateDocument(P1_docCloseStock)
    '            Case TaxComPNLEnuItem.OTHERBUSINC
    '                If P2_docOtherBizIncome Is Nothing OrElse P2_docOtherBizIncome.IsDisposed Then
    '                    P2_docOtherBizIncome = New DockPanel
    '                    Dim uc As New ucPNL_p2OtherBizIncome

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.SourceNo = cboSourceNo
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P2_docOtherBizIncome.Text = lbl.Text
    '                    P2_docOtherBizIncome.Name = TaxComPNLEnuItem.OTHERBUSINC.ToString
    '                    P2_docOtherBizIncome.Controls.Add(uc)
    '                    P2_docOtherBizIncome.DockedAsTabbedDocument = True
    '                    P2_docOtherBizIncome.Register(DockingManager)

    '                    DockDocument.View.AddDocument(P2_docOtherBizIncome)
    '                Else
    '                    P2_docOtherBizIncome.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P2_docOtherBizIncome)
    '                End If
    '                DockDocument.View.ActivateDocument(P2_docOtherBizIncome)
    '            Case TaxComPNLEnuItem.REALFETRADE
    '                If P2_docForeignCurrExGain Is Nothing OrElse P2_docForeignCurrExGain.IsDisposed Then
    '                    P2_docForeignCurrExGain = New DockPanel
    '                    Dim uc As New ucPNL_p2ForeignCurrExGain

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.SourceNo = cboSourceNo
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P2_docForeignCurrExGain.Text = lbl.Text
    '                    P2_docForeignCurrExGain.Name = TaxComPNLEnuItem.REALFETRADE.ToString
    '                    P2_docForeignCurrExGain.Controls.Add(uc)
    '                    P2_docForeignCurrExGain.DockedAsTabbedDocument = True
    '                    P2_docForeignCurrExGain.Register(DockingManager)

    '                    DockDocument.View.AddDocument(P2_docForeignCurrExGain)
    '                Else
    '                    P2_docForeignCurrExGain.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P2_docForeignCurrExGain)
    '                End If
    '                DockDocument.View.ActivateDocument(P2_docForeignCurrExGain)
    '            Case TaxComPNLEnuItem.INTERESTINC
    '                If P2_docInterestIncome Is Nothing OrElse P2_docInterestIncome.IsDisposed Then
    '                    P2_docInterestIncome = New DockPanel
    '                    Dim uc As New ucPNL_p2InterestIncome

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.SourceNo = cboSourceNo
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P2_docInterestIncome.Text = lbl.Text
    '                    P2_docInterestIncome.Name = TaxComPNLEnuItem.INTERESTINC.ToString
    '                    P2_docInterestIncome.Controls.Add(uc)
    '                    P2_docInterestIncome.DockedAsTabbedDocument = True
    '                    P2_docInterestIncome.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P2_docInterestIncome)
    '                Else
    '                    P2_docInterestIncome.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P2_docInterestIncome)
    '                End If
    '                DockDocument.View.ActivateDocument(P2_docInterestIncome)
    '            Case TaxComPNLEnuItem.ROYALTYINC
    '                If P2_docRoyaltyIncome Is Nothing OrElse P2_docRoyaltyIncome.IsDisposed Then
    '                    P2_docRoyaltyIncome = New DockPanel
    '                    Dim uc As New ucPNL_p2RoyaltyIncome

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.SourceNo = cboSourceNo
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P2_docRoyaltyIncome.Text = lbl.Text
    '                    P2_docRoyaltyIncome.Name = TaxComPNLEnuItem.ROYALTYINC.ToString
    '                    P2_docRoyaltyIncome.Controls.Add(uc)
    '                    P2_docRoyaltyIncome.DockedAsTabbedDocument = True
    '                    P2_docRoyaltyIncome.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P2_docRoyaltyIncome)
    '                Else
    '                    P2_docRoyaltyIncome.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P2_docRoyaltyIncome)
    '                End If
    '                DockDocument.View.ActivateDocument(P2_docRoyaltyIncome)
    '            Case TaxComPNLEnuItem.OTHERINC
    '                If P2_docOtherIncome Is Nothing OrElse P2_docOtherIncome.IsDisposed Then
    '                    P2_docOtherIncome = New DockPanel
    '                    Dim uc As New ucPNL_p2OtherIncome

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.SourceNo = cboSourceNo
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P2_docOtherIncome.Text = lbl.Text
    '                    P2_docOtherIncome.Name = TaxComPNLEnuItem.OTHERINC.ToString
    '                    P2_docOtherIncome.Controls.Add(uc)
    '                    P2_docOtherIncome.DockedAsTabbedDocument = True
    '                    P2_docOtherIncome.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P2_docOtherIncome)
    '                Else
    '                    P2_docOtherIncome.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P2_docOtherIncome)
    '                End If
    '                DockDocument.View.ActivateDocument(P2_docOtherIncome)
    '            Case TaxComPNLEnuItem.PDFIXASSET
    '                If P2_docProDispPlantEq Is Nothing OrElse P2_docProDispPlantEq.IsDisposed Then
    '                    P2_docProDispPlantEq = New DockPanel
    '                    Dim uc As New ucPNL_p2ProDispPlantEq

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P2_docProDispPlantEq.Text = lbl.Text
    '                    P2_docProDispPlantEq.Name = TaxComPNLEnuItem.PDFIXASSET.ToString
    '                    P2_docProDispPlantEq.Controls.Add(uc)
    '                    P2_docProDispPlantEq.DockedAsTabbedDocument = True
    '                    P2_docProDispPlantEq.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P2_docProDispPlantEq)
    '                Else
    '                    P2_docProDispPlantEq.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P2_docProDispPlantEq)
    '                End If
    '                DockDocument.View.ActivateDocument(P2_docProDispPlantEq)
    '            Case TaxComPNLEnuItem.PDINVEST
    '                If P2_docProDisInvestment Is Nothing OrElse P2_docProDisInvestment.IsDisposed Then
    '                    P2_docProDisInvestment = New DockPanel
    '                    Dim uc As New ucPNL_p2ProDisInvestment

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P2_docProDisInvestment.Text = lbl.Text
    '                    P2_docProDisInvestment.Name = TaxComPNLEnuItem.PDINVEST.ToString
    '                    P2_docProDisInvestment.Controls.Add(uc)
    '                    P2_docProDisInvestment.DockedAsTabbedDocument = True
    '                    P2_docProDisInvestment.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P2_docProDisInvestment)
    '                Else
    '                    P2_docProDisInvestment.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P2_docProDisInvestment)
    '                End If
    '                DockDocument.View.ActivateDocument(P2_docProDisInvestment)
    '            Case TaxComPNLEnuItem.FORINCREMIT
    '                If P2_docForeIncomeRemmit Is Nothing OrElse P2_docForeIncomeRemmit.IsDisposed Then
    '                    P2_docForeIncomeRemmit = New DockPanel
    '                    Dim uc As New ucPNL_p2ForeIncomeRemmit

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P2_docForeIncomeRemmit.Text = lbl.Text
    '                    P2_docForeIncomeRemmit.Name = TaxComPNLEnuItem.FORINCREMIT.ToString
    '                    P2_docForeIncomeRemmit.Controls.Add(uc)
    '                    P2_docForeIncomeRemmit.DockedAsTabbedDocument = True
    '                    P2_docForeIncomeRemmit.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P2_docForeIncomeRemmit)
    '                Else
    '                    P2_docForeIncomeRemmit.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P2_docForeIncomeRemmit)
    '                End If
    '                DockDocument.View.ActivateDocument(P2_docForeIncomeRemmit)
    '            Case TaxComPNLEnuItem.REALFE
    '                If P2_docReaForeExGainNonTrade Is Nothing OrElse P2_docReaForeExGainNonTrade.IsDisposed Then
    '                    P2_docReaForeExGainNonTrade = New DockPanel
    '                    Dim uc As New ucPNL_p2ReaForeExGainNonTrade

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P2_docReaForeExGainNonTrade.Text = lbl.Text
    '                    P2_docReaForeExGainNonTrade.Name = TaxComPNLEnuItem.REALFE.ToString
    '                    P2_docReaForeExGainNonTrade.Controls.Add(uc)
    '                    P2_docReaForeExGainNonTrade.DockedAsTabbedDocument = True
    '                    P2_docReaForeExGainNonTrade.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P2_docReaForeExGainNonTrade)
    '                Else
    '                    P2_docReaForeExGainNonTrade.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P2_docReaForeExGainNonTrade)
    '                End If
    '                DockDocument.View.ActivateDocument(P2_docReaForeExGainNonTrade)
    '            Case TaxComPNLEnuItem.UNREALFETRADE
    '                If P2_docUnreaGainForeEx Is Nothing OrElse P2_docUnreaGainForeEx.IsDisposed Then
    '                    P2_docUnreaGainForeEx = New DockPanel
    '                    Dim uc As New ucPNL_p2UnreaGainForeEx

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P2_docUnreaGainForeEx.Text = lbl.Text
    '                    P2_docUnreaGainForeEx.Name = TaxComPNLEnuItem.UNREALFETRADE.ToString
    '                    P2_docUnreaGainForeEx.Controls.Add(uc)
    '                    P2_docUnreaGainForeEx.DockedAsTabbedDocument = True
    '                    P2_docUnreaGainForeEx.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P2_docUnreaGainForeEx)
    '                Else
    '                    P2_docUnreaGainForeEx.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P2_docUnreaGainForeEx)
    '                End If
    '                DockDocument.View.ActivateDocument(P2_docUnreaGainForeEx)
    '            Case TaxComPNLEnuItem.UNREALFENONTRADE
    '                If P2_docUnreaGainForeExNon Is Nothing OrElse P2_docUnreaGainForeExNon.IsDisposed Then
    '                    P2_docUnreaGainForeExNon = New DockPanel
    '                    Dim uc As New ucPNL_p2UnreaGainForeExNon

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P2_docUnreaGainForeExNon.Text = lbl.Text
    '                    P2_docUnreaGainForeExNon.Name = TaxComPNLEnuItem.UNREALFENONTRADE.ToString
    '                    P2_docUnreaGainForeExNon.Controls.Add(uc)
    '                    P2_docUnreaGainForeExNon.DockedAsTabbedDocument = True
    '                    P2_docUnreaGainForeExNon.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P2_docUnreaGainForeExNon)
    '                Else
    '                    P2_docUnreaGainForeExNon.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P2_docUnreaGainForeExNon)
    '                End If
    '                DockDocument.View.ActivateDocument(P2_docUnreaGainForeExNon)
    '            Case TaxComPNLEnuItem.EXPOTHERINTEREST
    '                If P3_docOtherInterestExHirePur Is Nothing OrElse P3_docOtherInterestExHirePur.IsDisposed Then
    '                    P3_docOtherInterestExHirePur = New DockPanel
    '                    Dim uc As New ucPNL_p3OtherInterestExHirePur

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P3_docOtherInterestExHirePur.Text = lbl.Text
    '                    P3_docOtherInterestExHirePur.Name = TaxComPNLEnuItem.EXPOTHERINTEREST.ToString
    '                    P3_docOtherInterestExHirePur.Controls.Add(uc)
    '                    P3_docOtherInterestExHirePur.DockedAsTabbedDocument = True
    '                    P3_docOtherInterestExHirePur.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P3_docOtherInterestExHirePur)
    '                Else
    '                    P3_docOtherInterestExHirePur.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P3_docOtherInterestExHirePur)
    '                End If
    '                DockDocument.View.ActivateDocument(P3_docOtherInterestExHirePur)
    '            Case TaxComPNLEnuItem.EXPLEGAL
    '                If P3_docProTechManLeganFees Is Nothing OrElse P3_docProTechManLeganFees.IsDisposed Then
    '                    P3_docProTechManLeganFees = New DockPanel
    '                    Dim uc As New ucPNL_p3ProTechManLeganFees

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P3_docProTechManLeganFees.Text = lbl.Text
    '                    P3_docProTechManLeganFees.Name = TaxComPNLEnuItem.EXPLEGAL.ToString
    '                    P3_docProTechManLeganFees.Controls.Add(uc)
    '                    P3_docProTechManLeganFees.DockedAsTabbedDocument = True
    '                    P3_docProTechManLeganFees.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P3_docProTechManLeganFees)
    '                Else
    '                    P3_docProTechManLeganFees.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P3_docProTechManLeganFees)
    '                End If
    '                DockDocument.View.ActivateDocument(P3_docProTechManLeganFees)
    '            Case TaxComPNLEnuItem.EXPTECHNICAL
    '                If P3_docTechPayNonResis Is Nothing OrElse P3_docTechPayNonResis.IsDisposed Then
    '                    P3_docTechPayNonResis = New DockPanel
    '                    Dim uc As New ucPNL_p3TechPayNonResis

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P3_docTechPayNonResis.Text = lbl.Text
    '                    P3_docTechPayNonResis.Name = TaxComPNLEnuItem.EXPTECHNICAL.ToString
    '                    P3_docTechPayNonResis.Controls.Add(uc)
    '                    P3_docTechPayNonResis.DockedAsTabbedDocument = True
    '                    P3_docTechPayNonResis.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P3_docTechPayNonResis)
    '                Else
    '                    P3_docTechPayNonResis.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P3_docTechPayNonResis)
    '                End If
    '                DockDocument.View.ActivateDocument(P3_docTechPayNonResis)
    '            Case TaxComPNLEnuItem.EXPCONTRACTPAY
    '                If P3_docContractPay Is Nothing OrElse P3_docContractPay.IsDisposed Then
    '                    P3_docContractPay = New DockPanel
    '                    Dim uc As New ucPNL_p3ContractPay

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P3_docContractPay.Text = lbl.Text
    '                    P3_docContractPay.Name = TaxComPNLEnuItem.EXPCONTRACTPAY.ToString
    '                    P3_docContractPay.Controls.Add(uc)
    '                    P3_docContractPay.DockedAsTabbedDocument = True
    '                    P3_docContractPay.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P3_docContractPay)
    '                Else
    '                    P3_docContractPay.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P3_docContractPay)
    '                End If
    '                DockDocument.View.ActivateDocument(P3_docContractPay)
    '            Case TaxComPNLEnuItem.EXPDIRECTORFEE
    '                If P3_docDirectorFee Is Nothing OrElse P3_docDirectorFee.IsDisposed Then
    '                    P3_docDirectorFee = New DockPanel
    '                    Dim uc As New ucPNL_p3DirectorFee

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P3_docDirectorFee.Text = lbl.Text
    '                    P3_docDirectorFee.Name = TaxComPNLEnuItem.EXPDIRECTORFEE.ToString
    '                    P3_docDirectorFee.Controls.Add(uc)
    '                    P3_docDirectorFee.DockedAsTabbedDocument = True
    '                    P3_docDirectorFee.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P3_docDirectorFee)
    '                Else
    '                    P3_docDirectorFee.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P3_docDirectorFee)
    '                End If
    '                DockDocument.View.ActivateDocument(P3_docDirectorFee)
    '            Case TaxComPNLEnuItem.EXPSALARY
    '                If P3_docSalary Is Nothing OrElse P3_docSalary.IsDisposed Then
    '                    P3_docSalary = New DockPanel
    '                    Dim uc As New ucPNL_p3Salary

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P3_docSalary.Text = lbl.Text
    '                    P3_docSalary.Name = TaxComPNLEnuItem.EXPSALARY.ToString
    '                    P3_docSalary.Controls.Add(uc)
    '                    P3_docSalary.DockedAsTabbedDocument = True
    '                    P3_docSalary.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P3_docSalary)
    '                Else
    '                    P3_docSalary.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P3_docSalary)
    '                End If
    '                DockDocument.View.ActivateDocument(P3_docSalary)
    '            Case TaxComPNLEnuItem.EXPEMPLOYEESTOCK
    '                If P3_docCOEStock Is Nothing OrElse P3_docCOEStock.IsDisposed Then
    '                    P3_docCOEStock = New DockPanel
    '                    Dim uc As New ucPNL_p3COEStock

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P3_docCOEStock.Text = lbl.Text
    '                    P3_docCOEStock.Name = TaxComPNLEnuItem.EXPEMPLOYEESTOCK.ToString
    '                    P3_docCOEStock.Controls.Add(uc)
    '                    P3_docCOEStock.DockedAsTabbedDocument = True
    '                    P3_docCOEStock.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P3_docCOEStock)
    '                Else
    '                    P3_docCOEStock.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P3_docCOEStock)
    '                End If
    '                DockDocument.View.ActivateDocument(P3_docCOEStock)
    '            Case TaxComPNLEnuItem.EXPROYALTY
    '                If P3_docRoyalty Is Nothing OrElse P3_docRoyalty.IsDisposed Then
    '                    P3_docRoyalty = New DockPanel
    '                    Dim uc As New ucPNL_p3Royalty

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P3_docRoyalty.Text = lbl.Text
    '                    P3_docRoyalty.Name = TaxComPNLEnuItem.EXPROYALTY.ToString
    '                    P3_docRoyalty.Controls.Add(uc)
    '                    P3_docRoyalty.DockedAsTabbedDocument = True
    '                    P3_docRoyalty.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P3_docRoyalty)
    '                Else
    '                    P3_docRoyalty.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P3_docRoyalty)
    '                End If
    '                DockDocument.View.ActivateDocument(P3_docRoyalty)
    '            Case TaxComPNLEnuItem.EXPRENTAL
    '                If P3_docRental Is Nothing OrElse P3_docRental.IsDisposed Then
    '                    P3_docRental = New DockPanel
    '                    Dim uc As New ucPNL_p3Rental

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P3_docRental.Text = lbl.Text
    '                    P3_docRental.Name = TaxComPNLEnuItem.EXPRENTAL.ToString
    '                    P3_docRental.Controls.Add(uc)
    '                    P3_docRental.DockedAsTabbedDocument = True
    '                    P3_docRental.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P3_docRental)
    '                Else
    '                    P3_docRental.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P3_docRental)
    '                End If
    '                DockDocument.View.ActivateDocument(P3_docRental)
    '            Case TaxComPNLEnuItem.EXPREPAIRMAINTENANCE
    '                If P3_docRepairMain Is Nothing OrElse P3_docRepairMain.IsDisposed Then
    '                    P3_docRepairMain = New DockPanel
    '                    Dim uc As New ucPNL_p3RepairMain

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P3_docRepairMain.Text = lbl.Text
    '                    P3_docRepairMain.Name = TaxComPNLEnuItem.EXPREPAIRMAINTENANCE.ToString
    '                    P3_docRepairMain.Controls.Add(uc)
    '                    P3_docRepairMain.DockedAsTabbedDocument = True
    '                    P3_docRepairMain.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P3_docRepairMain)
    '                Else
    '                    P3_docRepairMain.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P3_docRepairMain)
    '                End If
    '                DockDocument.View.ActivateDocument(P3_docRepairMain)
    '            Case TaxComPNLEnuItem.EXPRND
    '                If P3_docResearchDev Is Nothing OrElse P3_docResearchDev.IsDisposed Then
    '                    P3_docResearchDev = New DockPanel
    '                    Dim uc As New ucPNL_p3ResearchDev

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P3_docResearchDev.Text = lbl.Text
    '                    P3_docResearchDev.Name = TaxComPNLEnuItem.EXPRND.ToString
    '                    P3_docResearchDev.Controls.Add(uc)
    '                    P3_docResearchDev.DockedAsTabbedDocument = True
    '                    P3_docResearchDev.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P3_docResearchDev)
    '                Else
    '                    P3_docResearchDev.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P3_docResearchDev)
    '                End If
    '                DockDocument.View.ActivateDocument(P3_docResearchDev)
    '            Case TaxComPNLEnuItem.EXPADVERTISEMENT
    '                If P3_docPromotionAds Is Nothing OrElse P3_docPromotionAds.IsDisposed Then
    '                    P3_docPromotionAds = New DockPanel
    '                    Dim uc As New ucPNL_p3PromotionAds

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P3_docPromotionAds.Text = lbl.Text
    '                    P3_docPromotionAds.Name = TaxComPNLEnuItem.EXPADVERTISEMENT.ToString
    '                    P3_docPromotionAds.Controls.Add(uc)
    '                    P3_docPromotionAds.DockedAsTabbedDocument = True
    '                    P3_docPromotionAds.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P3_docPromotionAds)
    '                Else
    '                    P3_docPromotionAds.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P3_docPromotionAds)
    '                End If
    '                DockDocument.View.ActivateDocument(P3_docPromotionAds)
    '            Case TaxComPNLEnuItem.EXPTRAVEL
    '                If P3_docTravelling Is Nothing OrElse P3_docTravelling.IsDisposed Then
    '                    P3_docTravelling = New DockPanel
    '                    Dim uc As New ucPNL_p3Travelling

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P3_docTravelling.Text = lbl.Text
    '                    P3_docTravelling.Name = TaxComPNLEnuItem.EXPTRAVEL.ToString
    '                    P3_docTravelling.Controls.Add(uc)
    '                    P3_docTravelling.DockedAsTabbedDocument = True
    '                    P3_docTravelling.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P3_docTravelling)
    '                Else
    '                    P3_docTravelling.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P3_docTravelling)
    '                End If
    '                DockDocument.View.ActivateDocument(P3_docTravelling)
    '            Case TaxComPNLEnuItem.EXPJKDM
    '                If P3_docJKDM Is Nothing OrElse P3_docJKDM.IsDisposed Then
    '                    P3_docJKDM = New DockPanel
    '                    Dim uc As New ucPNL_p3JKDM

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P3_docJKDM.Text = lbl.Text
    '                    P3_docJKDM.Name = TaxComPNLEnuItem.EXPJKDM.ToString
    '                    P3_docJKDM.Controls.Add(uc)
    '                    P3_docJKDM.DockedAsTabbedDocument = True
    '                    P3_docJKDM.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P3_docJKDM)
    '                Else
    '                    P3_docJKDM.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P3_docJKDM)
    '                End If
    '                DockDocument.View.ActivateDocument(P3_docJKDM)
    '            Case TaxComPNLEnuItem.EXPDEPRECIATION
    '                If P3_docDepreciation Is Nothing OrElse P3_docDepreciation.IsDisposed Then
    '                    P3_docDepreciation = New DockPanel
    '                    Dim uc As New ucPNL_p3Depreciation

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P3_docDepreciation.Text = lbl.Text
    '                    P3_docDepreciation.Name = TaxComPNLEnuItem.EXPDEPRECIATION.ToString
    '                    P3_docDepreciation.Controls.Add(uc)
    '                    P3_docDepreciation.DockedAsTabbedDocument = True
    '                    P3_docDepreciation.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P3_docDepreciation)
    '                Else
    '                    P3_docDepreciation.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P3_docDepreciation)
    '                End If
    '                DockDocument.View.ActivateDocument(P3_docDepreciation)
    '            Case TaxComPNLEnuItem.EXPDONATIONAPPR
    '                If P3_docDonationApp Is Nothing OrElse P3_docDonationApp.IsDisposed Then
    '                    P3_docDonationApp = New DockPanel
    '                    Dim uc As New ucPNL_p3DonationApp

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P3_docDonationApp.Text = lbl.Text
    '                    P3_docDonationApp.Name = TaxComPNLEnuItem.EXPDONATIONAPPR.ToString
    '                    P3_docDonationApp.Controls.Add(uc)
    '                    P3_docDonationApp.DockedAsTabbedDocument = True
    '                    P3_docDonationApp.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P3_docDonationApp)
    '                Else
    '                    P3_docDonationApp.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P3_docDonationApp)
    '                End If
    '                DockDocument.View.ActivateDocument(P3_docDonationApp)
    '            Case TaxComPNLEnuItem.EXPDONATIONNONAPPR
    '                If P3_docDonationNonApp Is Nothing OrElse P3_docDonationNonApp.IsDisposed Then
    '                    P3_docDonationNonApp = New DockPanel
    '                    Dim uc As New ucPNL_p3DonationNonApp

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P3_docDonationNonApp.Text = lbl.Text
    '                    P3_docDonationNonApp.Name = TaxComPNLEnuItem.EXPDONATIONNONAPPR.ToString
    '                    P3_docDonationNonApp.Controls.Add(uc)
    '                    P3_docDonationNonApp.DockedAsTabbedDocument = True
    '                    P3_docDonationNonApp.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P3_docDonationNonApp)
    '                Else
    '                    P3_docDonationNonApp.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P3_docDonationNonApp)
    '                End If
    '                DockDocument.View.ActivateDocument(P3_docDonationNonApp)

    '            Case TaxComPNLEnuItem.EXPZAKAT
    '                If p3_docZakat Is Nothing OrElse p3_docZakat.IsDisposed Then
    '                    p3_docZakat = New DockPanel
    '                    Dim uc As New ucPNL_p3Zakat

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    p3_docZakat.Text = lbl.Text
    '                    p3_docZakat.Name = TaxComPNLEnuItem.EXPZAKAT.ToString
    '                    p3_docZakat.Controls.Add(uc)
    '                    p3_docZakat.DockedAsTabbedDocument = True
    '                    p3_docZakat.Register(DockingManager)


    '                    DockDocument.View.AddDocument(p3_docZakat)
    '                Else
    '                    p3_docZakat.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(p3_docZakat)
    '                End If
    '                DockDocument.View.ActivateDocument(p3_docZakat)

    '            Case TaxComPNLEnuItem.EXPLOSSDISPFA
    '                If p4_docLossDispFA Is Nothing OrElse p4_docLossDispFA.IsDisposed Then
    '                    p4_docLossDispFA = New DockPanel
    '                    Dim uc As New ucPNL_p4LossDispFA

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    p4_docLossDispFA.Text = lbl.Text
    '                    p4_docLossDispFA.Name = TaxComPNLEnuItem.EXPLOSSDISPFA.ToString
    '                    p4_docLossDispFA.Controls.Add(uc)
    '                    p4_docLossDispFA.DockedAsTabbedDocument = True
    '                    p4_docLossDispFA.Register(DockingManager)


    '                    DockDocument.View.AddDocument(p4_docLossDispFA)
    '                Else
    '                    p4_docLossDispFA.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(p4_docLossDispFA)
    '                End If
    '                DockDocument.View.ActivateDocument(p4_docLossDispFA)

    '            Case TaxComPNLEnuItem.EXPENTERTAINNONSTAFF
    '                If p4_docEntNonStaff Is Nothing OrElse p4_docEntNonStaff.IsDisposed Then
    '                    p4_docEntNonStaff = New DockPanel
    '                    Dim uc As New ucPNL_p4EntNonStaff

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    p4_docEntNonStaff.Text = lbl.Text
    '                    p4_docEntNonStaff.Name = TaxComPNLEnuItem.EXPENTERTAINNONSTAFF.ToString
    '                    p4_docEntNonStaff.Controls.Add(uc)
    '                    p4_docEntNonStaff.DockedAsTabbedDocument = True
    '                    p4_docEntNonStaff.Register(DockingManager)


    '                    DockDocument.View.AddDocument(p4_docEntNonStaff)
    '                Else
    '                    p4_docEntNonStaff.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(p4_docEntNonStaff)
    '                End If
    '                DockDocument.View.ActivateDocument(p4_docEntNonStaff)

    '            Case TaxComPNLEnuItem.EXPENTERTAINSTAFF
    '                If p4_docEntStaff Is Nothing OrElse p4_docEntStaff.IsDisposed Then
    '                    p4_docEntStaff = New DockPanel
    '                    Dim uc As New ucPNL_p4EntStaff

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    p4_docEntStaff.Text = lbl.Text
    '                    p4_docEntStaff.Name = TaxComPNLEnuItem.EXPENTERTAINSTAFF.ToString
    '                    p4_docEntStaff.Controls.Add(uc)
    '                    p4_docEntStaff.DockedAsTabbedDocument = True
    '                    p4_docEntStaff.Register(DockingManager)


    '                    DockDocument.View.AddDocument(p4_docEntStaff)
    '                Else
    '                    p4_docEntStaff.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(p4_docEntStaff)
    '                End If
    '                DockDocument.View.ActivateDocument(p4_docEntStaff)

    '            Case TaxComPNLEnuItem.EXPCOMPAUNDPENALTY
    '                If p4_docCompound Is Nothing OrElse p4_docCompound.IsDisposed Then
    '                    p4_docCompound = New DockPanel
    '                    Dim uc As New ucPNL_p4Compound

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    p4_docCompound.Text = lbl.Text
    '                    p4_docCompound.Name = TaxComPNLEnuItem.EXPCOMPAUNDPENALTY.ToString
    '                    p4_docCompound.Controls.Add(uc)
    '                    p4_docCompound.DockedAsTabbedDocument = True
    '                    p4_docCompound.Register(DockingManager)


    '                    DockDocument.View.AddDocument(p4_docCompound)
    '                Else
    '                    p4_docCompound.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(p4_docCompound)
    '                End If
    '                DockDocument.View.ActivateDocument(p4_docCompound)

    '            Case TaxComPNLEnuItem.EXPPROVISION
    '                If p4_docProvisionAcc Is Nothing OrElse p4_docProvisionAcc.IsDisposed Then
    '                    p4_docProvisionAcc = New DockPanel
    '                    Dim uc As New ucPNL_p4ProvisionAcc

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    p4_docProvisionAcc.Text = lbl.Text
    '                    p4_docProvisionAcc.Name = TaxComPNLEnuItem.EXPPROVISION.ToString
    '                    p4_docProvisionAcc.Controls.Add(uc)
    '                    p4_docProvisionAcc.DockedAsTabbedDocument = True
    '                    p4_docProvisionAcc.Register(DockingManager)


    '                    DockDocument.View.AddDocument(p4_docProvisionAcc)
    '                Else
    '                    p4_docProvisionAcc.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(p4_docProvisionAcc)
    '                End If
    '                DockDocument.View.ActivateDocument(p4_docProvisionAcc)


    '            Case TaxComPNLEnuItem.EXPLEAVEPASSAGE
    '                If p4_docLeavePass Is Nothing OrElse p4_docLeavePass.IsDisposed Then
    '                    p4_docLeavePass = New DockPanel
    '                    Dim uc As New ucPNL_p4LeavePass

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    p4_docLeavePass.Text = lbl.Text
    '                    p4_docLeavePass.Name = TaxComPNLEnuItem.EXPLEAVEPASSAGE.ToString
    '                    p4_docLeavePass.Controls.Add(uc)
    '                    p4_docLeavePass.DockedAsTabbedDocument = True
    '                    p4_docLeavePass.Register(DockingManager)


    '                    DockDocument.View.AddDocument(p4_docLeavePass)
    '                Else
    '                    p4_docLeavePass.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(p4_docLeavePass)
    '                End If
    '                DockDocument.View.ActivateDocument(p4_docLeavePass)

    '            Case TaxComPNLEnuItem.EXPFAWRITTENOFF
    '                If p4_docFAWrittenOff Is Nothing OrElse p4_docFAWrittenOff.IsDisposed Then
    '                    p4_docFAWrittenOff = New DockPanel
    '                    Dim uc As New ucPNL_p4FAWrittenOff

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    p4_docFAWrittenOff.Text = lbl.Text
    '                    p4_docFAWrittenOff.Name = TaxComPNLEnuItem.EXPFAWRITTENOFF.ToString
    '                    p4_docFAWrittenOff.Controls.Add(uc)
    '                    p4_docFAWrittenOff.DockedAsTabbedDocument = True
    '                    p4_docFAWrittenOff.Register(DockingManager)


    '                    DockDocument.View.AddDocument(p4_docFAWrittenOff)
    '                Else
    '                    p4_docFAWrittenOff.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(p4_docFAWrittenOff)
    '                End If
    '                DockDocument.View.ActivateDocument(p4_docFAWrittenOff)

    '            Case TaxComPNLEnuItem.EXPUNREALLOSSFE
    '                If p4_docUnreaLossForeEx Is Nothing OrElse p4_docUnreaLossForeEx.IsDisposed Then
    '                    p4_docUnreaLossForeEx = New DockPanel
    '                    Dim uc As New ucPNL_p4UnreaLossForeEx

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    p4_docUnreaLossForeEx.Text = lbl.Text
    '                    p4_docUnreaLossForeEx.Name = TaxComPNLEnuItem.EXPUNREALLOSSFE.ToString
    '                    p4_docUnreaLossForeEx.Controls.Add(uc)
    '                    p4_docUnreaLossForeEx.DockedAsTabbedDocument = True
    '                    p4_docUnreaLossForeEx.Register(DockingManager)


    '                    DockDocument.View.AddDocument(p4_docUnreaLossForeEx)
    '                Else
    '                    p4_docUnreaLossForeEx.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(p4_docUnreaLossForeEx)
    '                End If
    '                DockDocument.View.ActivateDocument(p4_docUnreaLossForeEx)

    '            Case TaxComPNLEnuItem.EXPREALLOSSFETRADE
    '                If p4_docReaLossForeExTrade Is Nothing OrElse p4_docReaLossForeExTrade.IsDisposed Then
    '                    p4_docReaLossForeExTrade = New DockPanel
    '                    Dim uc As New ucPNL_p4ReaLossForeExTrade

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    p4_docReaLossForeExTrade.Text = lbl.Text
    '                    p4_docReaLossForeExTrade.Name = TaxComPNLEnuItem.EXPREALLOSSFETRADE.ToString
    '                    p4_docReaLossForeExTrade.Controls.Add(uc)
    '                    p4_docReaLossForeExTrade.DockedAsTabbedDocument = True
    '                    p4_docReaLossForeExTrade.Register(DockingManager)


    '                    DockDocument.View.AddDocument(p4_docReaLossForeExTrade)
    '                Else
    '                    p4_docReaLossForeExTrade.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(p4_docReaLossForeExTrade)
    '                End If
    '                DockDocument.View.ActivateDocument(p4_docReaLossForeExTrade)

    '            Case TaxComPNLEnuItem.EXPREALLOSSFENONTRADE
    '                If p4_docReaLossForeExNonTrade Is Nothing OrElse p4_docReaLossForeExNonTrade.IsDisposed Then
    '                    p4_docReaLossForeExNonTrade = New DockPanel
    '                    Dim uc As New ucPNL_p4ReaLossForeExNonTrade

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    p4_docReaLossForeExNonTrade.Text = lbl.Text
    '                    p4_docReaLossForeExNonTrade.Name = TaxComPNLEnuItem.EXPREALLOSSFENONTRADE.ToString
    '                    p4_docReaLossForeExNonTrade.Controls.Add(uc)
    '                    p4_docReaLossForeExNonTrade.DockedAsTabbedDocument = True
    '                    p4_docReaLossForeExNonTrade.Register(DockingManager)


    '                    DockDocument.View.AddDocument(p4_docReaLossForeExNonTrade)
    '                Else
    '                    p4_docReaLossForeExNonTrade.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(p4_docReaLossForeExNonTrade)
    '                End If
    '                DockDocument.View.ActivateDocument(p4_docReaLossForeExNonTrade)

    '            Case TaxComPNLEnuItem.EXPINITIALSUBSCRIPT
    '                If p4_docInitSub Is Nothing OrElse p4_docInitSub.IsDisposed Then
    '                    p4_docInitSub = New DockPanel
    '                    Dim uc As New ucPNL_p4InitSub

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    p4_docInitSub.Text = lbl.Text
    '                    p4_docInitSub.Name = TaxComPNLEnuItem.EXPINITIALSUBSCRIPT.ToString
    '                    p4_docInitSub.Controls.Add(uc)
    '                    p4_docInitSub.DockedAsTabbedDocument = True
    '                    p4_docInitSub.Register(DockingManager)


    '                    DockDocument.View.AddDocument(p4_docInitSub)
    '                Else
    '                    p4_docInitSub.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(p4_docInitSub)
    '                End If
    '                DockDocument.View.ActivateDocument(p4_docInitSub)

    '            Case TaxComPNLEnuItem.EXPCAPITALEXPENDITURE
    '                If p4_docCAExpenditure Is Nothing OrElse p4_docCAExpenditure.IsDisposed Then
    '                    p4_docCAExpenditure = New DockPanel
    '                    Dim uc As New ucPNL_p4CAExpenditure

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    p4_docCAExpenditure.Text = lbl.Text
    '                    p4_docCAExpenditure.Name = TaxComPNLEnuItem.EXPCAPITALEXPENDITURE.ToString
    '                    p4_docCAExpenditure.Controls.Add(uc)
    '                    p4_docCAExpenditure.DockedAsTabbedDocument = True
    '                    p4_docCAExpenditure.Register(DockingManager)


    '                    DockDocument.View.AddDocument(p4_docCAExpenditure)
    '                Else
    '                    p4_docCAExpenditure.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(p4_docCAExpenditure)
    '                End If
    '                DockDocument.View.ActivateDocument(p4_docCAExpenditure)

    '            Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
    '                If p4_docOther Is Nothing OrElse p4_docOther.IsDisposed Then
    '                    p4_docOther = New DockPanel
    '                    Dim uc As New ucPNL_p4Other

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    p4_docOther.Text = lbl.Text
    '                    p4_docOther.Name = TaxComPNLEnuItem.EXPOTHERSEXPENSES.ToString
    '                    p4_docOther.Controls.Add(uc)
    '                    p4_docOther.DockedAsTabbedDocument = True
    '                    p4_docOther.Register(DockingManager)


    '                    DockDocument.View.AddDocument(p4_docOther)
    '                Else
    '                    p4_docOther.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(p4_docOther)
    '                End If
    '                DockDocument.View.ActivateDocument(p4_docOther)
    '            Case TaxComPNLEnuItem.RENTALINC
    '                If P2_docRentalIncome Is Nothing OrElse P2_docRentalIncome.IsDisposed Then
    '                    P2_docRentalIncome = New DockPanel
    '                    Dim uc As New ucPNL_p2RentalIncome

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.txtSales = txtSales
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P2_docRentalIncome.Text = lbl.Text
    '                    P2_docRentalIncome.Name = TaxComPNLEnuItem.RENTALINC.ToString
    '                    P2_docRentalIncome.Controls.Add(uc)
    '                    P2_docRentalIncome.DockedAsTabbedDocument = True
    '                    P2_docRentalIncome.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P2_docRentalIncome)
    '                Else
    '                    P2_docRentalIncome.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P2_docRentalIncome)
    '                End If
    '                DockDocument.View.ActivateDocument(P2_docRentalIncome)
    '            Case TaxComPNLEnuItem.NONALLOWABLEEXPENSES
    '                If p4_docNonAllowableExpenses Is Nothing OrElse p4_docNonAllowableExpenses.IsDisposed Then
    '                    p4_docNonAllowableExpenses = New DockPanel
    '                    Dim uc As New ucPNL_p4NonAllowableExpenses

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    p4_docNonAllowableExpenses.Text = lbl.Text
    '                    p4_docNonAllowableExpenses.Name = TaxComPNLEnuItem.NONALLOWABLEEXPENSES.ToString
    '                    p4_docNonAllowableExpenses.Controls.Add(uc)
    '                    p4_docNonAllowableExpenses.DockedAsTabbedDocument = True
    '                    p4_docNonAllowableExpenses.Register(DockingManager)


    '                    DockDocument.View.AddDocument(p4_docNonAllowableExpenses)
    '                Else
    '                    p4_docNonAllowableExpenses.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(p4_docNonAllowableExpenses)
    '                End If
    '                DockDocument.View.ActivateDocument(p4_docNonAllowableExpenses)
    '            Case TaxComPNLEnuItem.OTHERNONTAXINC
    '                If P2_docOther Is Nothing OrElse P2_docOther.IsDisposed Then
    '                    P2_docOther = New DockPanel
    '                    Dim uc As New ucPNL_p2Other

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P2_docOther.Text = lbl.Text
    '                    P2_docOther.Name = TaxComPNLEnuItem.OTHERNONTAXINC.ToString
    '                    P2_docOther.Controls.Add(uc)
    '                    P2_docOther.DockedAsTabbedDocument = True
    '                    P2_docOther.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P2_docOther)
    '                Else
    '                    P2_docOther.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P2_docOther)
    '                End If
    '                DockDocument.View.ActivateDocument(P2_docOther)
    '            Case TaxComPNLEnuItem.EXEMDIV
    '                If P2_docExemptDividend Is Nothing OrElse P2_docExemptDividend.IsDisposed Then
    '                    P2_docExemptDividend = New DockPanel
    '                    Dim uc As New ucPNL_p2ExemptDividend

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P2_docExemptDividend.Text = lbl.Text
    '                    P2_docExemptDividend.Name = TaxComPNLEnuItem.EXEMDIV.ToString
    '                    P2_docExemptDividend.Controls.Add(uc)
    '                    P2_docExemptDividend.DockedAsTabbedDocument = True
    '                    P2_docExemptDividend.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P2_docExemptDividend)
    '                Else
    '                    P2_docExemptDividend.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P2_docExemptDividend)
    '                End If
    '                DockDocument.View.ActivateDocument(P2_docExemptDividend)
    '            Case TaxComPNLEnuItem.INTERESTRESTRICT
    '                If P3_docInterestResPurS33 Is Nothing OrElse P3_docInterestResPurS33.IsDisposed Then
    '                    P3_docInterestResPurS33 = New DockPanel
    '                    Dim uc As New ucPNL_p3InterestResPurS33

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.DataView_Main = dsDataSet
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P3_docInterestResPurS33.Text = lbl.Text
    '                    P3_docInterestResPurS33.Name = TaxComPNLEnuItem.INTERESTRESTRICT.ToString
    '                    P3_docInterestResPurS33.Controls.Add(uc)
    '                    P3_docInterestResPurS33.DockedAsTabbedDocument = True
    '                    P3_docInterestResPurS33.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P3_docInterestResPurS33)
    '                Else
    '                    P3_docInterestResPurS33.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P3_docInterestResPurS33)
    '                End If
    '                DockDocument.View.ActivateDocument(P3_docInterestResPurS33)
    '            Case TaxComPNLEnuItem.DIVIDENDINC
    '                If P2_docDivIncome Is Nothing OrElse P2_docDivIncome.IsDisposed Then
    '                    P2_docDivIncome = New DockPanel
    '                    Dim uc As New ucPNL_p2DivIncome

    '                    uc.RefNo = RefNo
    '                    uc.YA = YA
    '                    uc.txtSales = txtSales
    '                    uc.DataView_Main = dsDataSet
    '                    uc.DataView_Main2 = dsDataSet
    '                    uc.SourceNo = cboSourceNo
    '                    uc.Dock = DockStyle.Fill
    '                    uc.txtAmount = txtAmount
    '                    P2_docDivIncome.Text = lbl.Text
    '                    P2_docDivIncome.Name = TaxComPNLEnuItem.DIVIDENDINC.ToString
    '                    P2_docDivIncome.Controls.Add(uc)
    '                    P2_docDivIncome.DockedAsTabbedDocument = True
    '                    P2_docDivIncome.Register(DockingManager)


    '                    DockDocument.View.AddDocument(P2_docDivIncome)
    '                Else
    '                    P2_docDivIncome.Visibility = DockVisibility.Visible
    '                    DockDocument.View.AddDocument(P2_docDivIncome)
    '                End If
    '                DockDocument.View.ActivateDocument(P2_docDivIncome)
    '        End Select

    '        Return False
    '    Catch ex As Exception
    '        If Errorlog Is Nothing Then
    '            Errorlog = New clsError
    '        End If
    '        With Errorlog
    '            .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
    '            .ErrorCode = ex.GetHashCode.ToString
    '            .ErrorDateTime = Now
    '            .ErrorMessage = ex.Message
    '        End With
    '        Return False
    '    Finally
    '        DockDocument.EndUpdate()
    '    End Try
    'End Function
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
                                                     ByRef TotalMonth As Integer, ByRef Day As DateTime, _
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

            dt = ADO.Load_interestRestricSchedule(RefNo, YA, SourceNo, "inv", Errorlog)

            If dt IsNot Nothing Then

                For Each row As DataRow In dt.Rows
                    TotalMonth = IIf(IsDBNull(row("Month")), 12, row("Month"))
                    Day = CDate(IIf(IsDBNull(row("BasicPeriod")), Now, row("BasicPeriod")))
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

            dt = ADO.Load_interestRestricSchedule(RefNo, YA, SourceNo, "invNon", Errorlog)

            If dt IsNot Nothing Then
                For Each row As DataRow In dt.Rows
                    TotalMonth = IIf(IsDBNull(row("Month")), 12, row("Month"))
                    Day = CDate(IIf(IsDBNull(row("BasicPeriod")), Now, row("BasicPeriod")))
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


            dt = ADO.Load_interestRestricSchedule(RefNo, YA, SourceNo, "Borr", Errorlog)

            If dt IsNot Nothing Then
                For Each row As DataRow In dt.Rows
                    TotalMonth = IIf(IsDBNull(row("Month")), 12, row("Month"))
                    Day = CDate(IIf(IsDBNull(row("BasicPeriod")), Now, row("BasicPeriod")))
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

            dt = ADO.Load_interestRestricSchedule(RefNo, YA, SourceNo, "Interest", Errorlog)

            If dt IsNot Nothing Then
                For Each row As DataRow In dt.Rows
                    TotalMonth = IIf(IsDBNull(row("Month")), 12, row("Month"))
                    Day = CDate(IIf(IsDBNull(row("BasicPeriod")), Now, row("BasicPeriod")))
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
    Public Sub OpenNoteForm(ByVal GridView As GridView, ByVal RowInfo As DataRow, Optional ByRef ErrorLog As clsError = Nothing)
        Try
            Dim frm As New frmNote

            frm.PNL_KeyName = IIf(IsDBNull(RowInfo("KeyName")), "", RowInfo("KeyName"))

            Dim viewChild As GridView = GridView.GetDetailView(GridView.FocusedRowHandle, 0)
            Dim PrefixName As String = IIf(IsDBNull(RowInfo("PrefixName")), "", RowInfo("PrefixName"))
            If viewChild IsNot Nothing AndAlso viewChild.IsFocusedView Then
                frm.PNL_isParent = False
                frm.PNL_Parent_Key = viewChild.GetDataRow(viewChild.FocusedRowHandle)(PrefixName & "D_KEY") '("PLFSD_KEY")
                frm.PNL_DataID = viewChild.GetDataRow(viewChild.FocusedRowHandle)(IIf(IsDBNull(RowInfo("ColumnTable_Details")), "", RowInfo("ColumnTable_Details")))
                frm.PNL_Data_SubID = viewChild.GetDataRow(viewChild.FocusedRowHandle)(PrefixName & "D_" & PrefixName & "DKEY") '("PLFSD_PLFSDKEY")
                frm.PNL_RowDescription = viewChild.GetDataRow(viewChild.FocusedRowHandle)(IIf(IsDBNull(RowInfo("ColumnDescription_Details")), "", RowInfo("ColumnDescription_Details")))
            Else
                frm.PNL_isParent = True
                frm.PNL_Parent_Key = GridView.GetDataRow(GridView.FocusedRowHandle)(PrefixName & "_KEY")
                frm.PNL_DataID = GridView.GetDataRow(GridView.FocusedRowHandle)(IIf(IsDBNull(RowInfo("ColumnTable")), "", RowInfo("ColumnTable")))
                frm.PNL_Data_SubID = -1
                frm.PNL_RowDescription = GridView.GetDataRow(GridView.FocusedRowHandle)(IIf(IsDBNull(RowInfo("ColumnDescription")), "", RowInfo("ColumnDescription")))
            End If

            frm.ShowDialog()

        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            AddListOfError(ErrorLog)
        End Try
    End Sub
    Public Function GetNonAllowanbleExpenses(ByRef dsNonAllowableExpenses As DataSet, ByVal RefNo As String, ByVal YA As String, _
                                             ByVal SourceNo As DevExpress.XtraBars.BarEditItem, Optional ByRef Errorlog As clsError = Nothing) As Decimal
        Try
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

            'PURCHASE
            If doc_p1Purchase IsNot Nothing AndAlso doc_p1Purchase.Controls.Count > 0 Then
                contrl = doc_p1Purchase.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p1Purchase Then
                    Dim uc As ucPNL_p1Purchase = CType(contrl, ucPNL_p1Purchase)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        'CalcPercentageAmount(ds, uc.MainTable, uc.MainTable_Details, uc.MainKey, uc.MainKey_Details, uc.Main_Addback, uc.Main_Deduct, uc.MainDetails_Addback, uc.MainDetails_Deduct, uc.MainAmount, _
                        '        uc.MainAmount_Details, uc.MainColumn_Percentage, uc.MainColumn_PercentageAmount, Errorlog)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'DEPRECIATION
            If doc_p1Depreciation IsNot Nothing AndAlso doc_p1Depreciation.Controls.Count > 0 Then
                contrl = doc_p1Depreciation.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p1Depreciation Then
                    Dim uc As ucPNL_p1Depreciation = CType(contrl, ucPNL_p1Depreciation)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        'CalcPercentageAmount(ds, uc.MainTable, uc.MainTable_Details, uc.MainKey, uc.MainKey_Details, uc.Main_Addback, uc.Main_Deduct, uc.MainDetails_Addback, uc.MainDetails_Deduct, uc.MainAmount, _
                        '        uc.MainAmount_Details, uc.MainColumn_Percentage, uc.MainColumn_PercentageAmount, Errorlog)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'OTHERALLOWEXP
            If doc_p1AllowanceExpenses IsNot Nothing AndAlso doc_p1AllowanceExpenses.Controls.Count > 0 Then
                contrl = doc_p1AllowanceExpenses.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p1AllowanceExpenses Then
                    Dim uc As ucPNL_p1AllowanceExpenses = CType(contrl, ucPNL_p1AllowanceExpenses)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'OTHERNONALLOWEXP
            If doc_p1NonAllowableExpenses IsNot Nothing AndAlso doc_p1NonAllowableExpenses.Controls.Count > 0 Then
                contrl = doc_p1NonAllowableExpenses.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p1NonAllowableExpenses Then
                    Dim uc As ucPNL_p1NonAllowableExpenses = CType(contrl, ucPNL_p1NonAllowableExpenses)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'EXPOTHERINTEREST
            If doc_p3OtherInterestExHirePur IsNot Nothing AndAlso doc_p3OtherInterestExHirePur.Controls.Count > 0 Then
                contrl = doc_p3OtherInterestExHirePur.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'ProTechManLeganFees
            If doc_p3ProTechManLeganFees IsNot Nothing AndAlso doc_p3ProTechManLeganFees.Controls.Count > 0 Then
                contrl = doc_p3ProTechManLeganFees.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'TechPayNonResis
            If doc_p3TechPayNonResis IsNot Nothing AndAlso doc_p3TechPayNonResis.Controls.Count > 0 Then
                contrl = doc_p3TechPayNonResis.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'ContractPay
            If doc_p3ContractPay IsNot Nothing AndAlso doc_p3ContractPay.Controls.Count > 0 Then
                contrl = doc_p3ContractPay.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'DirectorFee
            If doc_p3DirectorFee IsNot Nothing AndAlso doc_p3DirectorFee.Controls.Count > 0 Then
                contrl = doc_p3DirectorFee.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'Salary

            If doc_p3Salary IsNot Nothing AndAlso doc_p3Salary.Controls.Count > 0 Then
                contrl = doc_p3Salary.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If


            'COEStock
            If doc_p3COEStock IsNot Nothing AndAlso doc_p3COEStock.Controls.Count > 0 Then
                contrl = doc_p3COEStock.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'Royalty
            If doc_p3Royalty IsNot Nothing AndAlso doc_p3Royalty.Controls.Count > 0 Then
                contrl = doc_p3Royalty.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'Rental
            If doc_p3Rental IsNot Nothing AndAlso doc_p3Rental.Controls.Count > 0 Then
                contrl = doc_p3Rental.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'RepairMain
            If doc_p3RepairMain IsNot Nothing AndAlso doc_p3RepairMain.Controls.Count > 0 Then
                contrl = doc_p3RepairMain.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'ResearchDev
            If doc_p3ResearchDev IsNot Nothing AndAlso doc_p3ResearchDev.Controls.Count > 0 Then
                contrl = doc_p3ResearchDev.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'PromotionAds
            If doc_p3PromotionAds IsNot Nothing AndAlso doc_p3PromotionAds.Controls.Count > 0 Then
                contrl = doc_p3PromotionAds.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'Travelling
            If doc_p3Travelling IsNot Nothing AndAlso doc_p3Travelling.Controls.Count > 0 Then
                contrl = doc_p3Travelling.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
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
            '                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
            '                            dtRow("TitleKeyName") = uc.Parent.Text
            '                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
            '                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
            '                        End If

            '                    Next

            '                Else
            '                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
            '                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
            '                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
            '                        dtRow("KeyName") = uc.Parent.Name
            '                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
            '                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
            '                        dtRow("TitleKeyName") = uc.Parent.Text
            '                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
            '                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
            '                    End If
            '                End If

            '            End If

            '        Next
            '    End If

            'End If

            'JKDM
            If doc_p3JKDM IsNot Nothing AndAlso doc_p3JKDM.Controls.Count > 0 Then
                contrl = doc_p3JKDM.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'Depreciation
            If doc_p3Depreciation IsNot Nothing AndAlso doc_p3Depreciation.Controls.Count > 0 Then
                contrl = doc_p3Depreciation.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If


            'DonationApp
            If doc_p3DonationApp IsNot Nothing AndAlso doc_p3DonationApp.Controls.Count > 0 Then
                contrl = doc_p3DonationApp.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If


            'DonationNonApp
            If doc_p3DonationNonApp IsNot Nothing AndAlso doc_p3DonationNonApp.Controls.Count > 0 Then
                contrl = doc_p3DonationNonApp.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'Zakat
            If doc_p3Zakat IsNot Nothing AndAlso doc_p3Zakat.Controls.Count > 0 Then
                contrl = doc_p3Zakat.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If


            'LossDispFA
            If doc_p4LossDispFA IsNot Nothing AndAlso doc_p4LossDispFA.Controls.Count > 0 Then
                contrl = doc_p4LossDispFA.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'EntNonStaff
            If doc_p4EntNonStaff IsNot Nothing AndAlso doc_p4EntNonStaff.Controls.Count > 0 Then
                contrl = doc_p4EntNonStaff.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'EntStaff
            If doc_p4EntStaff IsNot Nothing AndAlso doc_p4EntStaff.Controls.Count > 0 Then
                contrl = doc_p4EntStaff.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If


            'Compound
            If doc_p4Compound IsNot Nothing AndAlso doc_p4Compound.Controls.Count > 0 Then
                contrl = doc_p4Compound.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'ProvisionAcc
            If doc_p4ProvisionAcc IsNot Nothing AndAlso doc_p4ProvisionAcc.Controls.Count > 0 Then
                contrl = doc_p4ProvisionAcc.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'LeavePass
            If doc_p4LeavePass IsNot Nothing AndAlso doc_p4LeavePass.Controls.Count > 0 Then
                contrl = doc_p4LeavePass.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'FAWrittenOff
            If doc_p4FAWrittenOff IsNot Nothing AndAlso doc_p4FAWrittenOff.Controls.Count > 0 Then
                contrl = doc_p4FAWrittenOff.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'UnreaLossForeEx
            If doc_p4UnreaLossForeEx IsNot Nothing AndAlso doc_p4UnreaLossForeEx.Controls.Count > 0 Then
                contrl = doc_p4UnreaLossForeEx.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If

            'ReaLossForeExTrade
            If doc_p4ReaLossForeExTrade IsNot Nothing AndAlso doc_p4ReaLossForeExTrade.Controls.Count > 0 Then
                contrl = doc_p4ReaLossForeExTrade.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If

            End If

            'ReaLossForeExNonTrade
            If doc_p4ReaLossForeExNonTrade IsNot Nothing AndAlso doc_p4ReaLossForeExNonTrade.Controls.Count > 0 Then
                contrl = doc_p4ReaLossForeExNonTrade.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If


            'InitSub
            If doc_p4InitSub IsNot Nothing AndAlso doc_p4InitSub.Controls.Count > 0 Then
                contrl = doc_p4InitSub.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If


            'CAExpenditure
            If doc_p4CAExpenditure IsNot Nothing AndAlso doc_p4CAExpenditure.Controls.Count > 0 Then
                contrl = doc_p4CAExpenditure.Controls(0)

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
                                            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                            dtRow("TitleKeyName") = uc.Parent.Text
                                            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                        End If

                                    Next

                                Else
                                    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                        dtRow("KeyName") = uc.Parent.Name
                                        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                        dtRow("TitleKeyName") = uc.Parent.Text
                                        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    End If
                                End If

                            End If

                        Next
                    End If

                End If
            End If


            'Other
            If doc_p4Other IsNot Nothing AndAlso doc_p4Other.Controls.Count > 0 Then
                contrl = doc_p4Other.Controls(0)

                If contrl IsNot Nothing AndAlso TypeOf contrl Is ucPNL_p4Other Then
                    Dim uc As ucPNL_p4Other = CType(contrl, ucPNL_p4Other)

                    ds = uc.DataView_Main

                    If ds IsNot Nothing AndAlso ds.Tables(uc.MainTable) IsNot Nothing AndAlso ds.Tables(uc.MainTable).Rows.Count > 0 Then

                        For Each rows As DataRow In ds.Tables(uc.MainTable).Rows

                            If IsDBNull(rows(uc.MainKey)) = False Then

                                obj = Nothing
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rows(uc.MainKey))

                                If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                    dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                    dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                    dtRow("KeyName") = uc.Parent.Name
                                    dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                    dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                    dtRow("TitleKeyName") = uc.Parent.Text
                                    dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                    dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                    NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                End If
                                'If obj IsNot Nothing AndAlso TypeOf obj Is DataRow() AndAlso CType(obj, DataRow()).Length > 0 Then

                                '    For Each detailsrows As DataRow In obj

                                '        If TypeOf detailsrows(uc.MainDetails_Addback) Is Boolean AndAlso CBool(detailsrows(uc.MainDetails_Addback)) = True Then
                                '            dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                '            dtRow("ID") = IIf(IsDBNull(detailsrows(uc.MainKey_Details)), 0, detailsrows(uc.MainKey_Details))
                                '            dtRow("KeyName") = uc.Parent.Name
                                '            dtRow("Description") = IIf(IsDBNull(detailsrows(uc.MainDetails_Desc)), "", detailsrows(uc.MainDetails_Desc))
                                '            dtRow("Amount") = IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                '            dtRow("TitleKeyName") = uc.Parent.Text
                                '            dtRow("SourceNo") = IIf(IsDBNull(detailsrows(uc.MainSourceNo_Details)), 0, detailsrows(uc.MainSourceNo_Details))
                                '            dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                '            NonAllowableExpenses += IIf(IsDBNull(detailsrows(uc.MainColumn_PercentageAmount)), 0, detailsrows(uc.MainColumn_PercentageAmount))
                                '        End If

                                '    Next

                                'Else
                                '    If TypeOf rows(uc.Main_Addback) Is Boolean AndAlso CBool(rows(uc.Main_Addback)) = True Then
                                '        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                                '        dtRow("ID") = IIf(IsDBNull(rows(uc.MainKey)), 0, rows(uc.MainKey))
                                '        dtRow("KeyName") = uc.Parent.Name
                                '        dtRow("Description") = IIf(IsDBNull(rows(uc.Main_Desc)), "", rows(uc.Main_Desc))
                                '        dtRow("Amount") = IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                '        dtRow("TitleKeyName") = uc.Parent.Text
                                '        dtRow("SourceNo") = IIf(IsDBNull(rows(uc.MainSourceNo)), 0, rows(uc.MainSourceNo))
                                '        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                                '        NonAllowableExpenses += IIf(IsDBNull(rows(uc.MainColumn_PercentageAmount)), 0, rows(uc.MainColumn_PercentageAmount))
                                '    End If
                                'End If

                            End If

                        Next
                    End If

                End If
            End If
            Application.DoEvents()

            'Movement
            Dim dtMovement As DataTable = Nothing

            dtMovement = clsMoveNormal.Load_MovementNormal(RefNo, YA, Errorlog)

            If dtMovement IsNot Nothing Then
                For i As Integer = 0 To dtMovement.Rows.Count - 1
                    If IsDBNull(dtMovement.Rows(i)("MM_TYPE_PASS")) = False AndAlso dtMovement.Rows(i)("MM_TYPE_PASS") = 1 Then
                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                        dtRow("ID") = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Count + 1
                        dtRow("KeyName") = "MOVEMENT_NORMAL"
                        dtRow("Description") = IIf(IsDBNull(dtMovement.Rows(i)("MM_TITLE")), "", dtMovement.Rows(i)("MM_TITLE"))
                        dtRow("Amount") = IIf(IsDBNull(dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT")), 0, dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT"))
                        dtRow("TitleKeyName") = "Movement Normal"
                        dtRow("SourceNo") = IIf(IsDBNull(dtMovement.Rows(i)("MM_SOURCENO")), 0, dtMovement.Rows(i)("MM_SOURCENO"))
                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                        NonAllowableExpenses += IIf(IsDBNull(dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT")), 0, dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT"))
                    End If
                Next
            End If
            dtMovement = Nothing
            dtMovement = ADO.Load_MovementComplex(RefNo, YA, Errorlog)

            If dtMovement IsNot Nothing Then
                For i As Integer = 0 To dtMovement.Rows.Count - 1
                    If IsDBNull(dtMovement.Rows(i)("MM_TYPE_PASS")) = False AndAlso dtMovement.Rows(i)("MM_TYPE_PASS") = 1 Then
                        dtRow = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").NewRow
                        dtRow("ID") = dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Count + 1
                        dtRow("KeyName") = "MOVEMENT_COMPLEX"
                        dtRow("Description") = IIf(IsDBNull(dtMovement.Rows(i)("MM_TITLE")), "", dtMovement.Rows(i)("MM_TITLE"))
                        dtRow("Amount") = IIf(IsDBNull(dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT")), 0, dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT"))
                        dtRow("TitleKeyName") = "Movement Complex"
                        dtRow("SourceNo") = IIf(IsDBNull(dtMovement.Rows(i)("MM_SOURCENO")), 0, dtMovement.Rows(i)("MM_SOURCENO"))
                        dsNonAllowableExpenses.Tables("NonAllowable_Expenses").Rows.Add(dtRow)
                        NonAllowableExpenses += IIf(IsDBNull(dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT")), 0, dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT"))
                    End If
                Next

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
    Public Function CalcExpenses(ByVal p3ForeignCurrExLoss As Decimal, ByVal p3OtherInterestExHirePur As Decimal, _
                                 ByVal p3ProTechManLeganFees As Decimal, ByVal p3TechPayNonResis As Decimal, _
                                 ByVal p3ContractPay As Decimal, ByVal p3DirectorFee As Decimal, ByVal p3Salary As Decimal, _
                                 ByVal p3COEStock As Decimal, ByVal p3Royalty As Decimal, ByVal p3Rental As Decimal, _
                                 ByVal p3RepairMain As Decimal, ByVal p3ResearchDev As Decimal, ByVal p3PromotionAds As Decimal, _
                                 ByVal p3Travelling As Decimal, ByVal p3JKDM As Decimal, ByVal p3InterestResPurS33 As Decimal, _
                                 ByVal p4TotalOtherExpenses As Decimal, ByRef BalacingFigure As Decimal, ByRef NonAllowableExpenses As Decimal, _
                                 ByVal RefNo As String, ByVal YA As String, ByVal cboSourceNo As DevExpress.XtraBars.BarEditItem, Optional ByRef Errorlog As clsError = Nothing) As Decimal
        Try
            'Dim p3ContractPay As Decimal = IIf(IsNumeric(txt_p3Depreciation.EditValue) = False, 0, txt_p3Depreciation.EditValue)
            'Dim p3DirectorFee As Decimal = IIf(IsNumeric(txt_p3Depreciation.EditValue) = False, 0, txt_p3Depreciation.EditValue)
            NonAllowableExpenses = mdlPNL.GetNonAllowanbleExpenses(dsDataSet, RefNo, YA, cboSourceNo, Errorlog)

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
    Public Function CalcPercentageAmount_Expenses(ByRef ds As DataSet, ByVal TableName As String, ByVal TableName_Details As String, _
                                         ByVal ColumnName_Key As String, ByVal ColumnNameDetails_Key As String, _
                                         ByVal ColumnAddBack As String, ByVal ColumnDeduct As String, _
                                         ByVal ColumnAddBack_Details As String, ByVal ColumnDeduct_Details As String, _
                                         ByVal ColumnAmount As String, ByVal ColumnAmount_Details As String, _
                                         ByVal ColumnPecentageAmount As String, _
                                         Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try

            Dim tmpTotal As Decimal = 0
            Dim MainTotal As Decimal = 0
            Dim RunningTotal As Decimal = 0
            Dim amount As Decimal = 0

            For i As Integer = 0 To ds.Tables(TableName).Rows.Count - 1


                amount = IIf(IsDBNull(ds.Tables(TableName).Rows(i)(ColumnAmount)), 0, ds.Tables(TableName).Rows(i)(ColumnAmount))
                tmpTotal = amount

                If ColumnAddBack <> "" AndAlso IsDBNull(ds.Tables(TableName).Rows(i)(ColumnAddBack)) = False AndAlso CBool(ds.Tables(TableName).Rows(i)(ColumnAddBack)) Then
                    ds.Tables(TableName).Rows(i)(ColumnPecentageAmount) = Math.Round(CDec(tmpTotal), 2)
                    'ElseIf ColumnDeduct <> "" AndAlso IsDBNull(ds.Tables(TableName).Rows(i)(ColumnDeduct)) = False AndAlso CBool(ds.Tables(TableName).Rows(i)(ColumnDeduct)) Then
                    ' ds.Tables(TableName).Rows(i)(ColumnPecentageAmount) = Math.Round(CDec(tmpTotal / -1), 2)
                Else
                    ds.Tables(TableName).Rows(i)(ColumnPecentageAmount) = 0
                End If
                RunningTotal = 0
                For x As Integer = 0 To ds.Tables(TableName_Details).Rows.Count - 1

                    If ds.Tables(TableName_Details).Rows(x)(ColumnNameDetails_Key) = ds.Tables(TableName).Rows(i)(ColumnName_Key) Then

                        amount = IIf(IsDBNull(ds.Tables(TableName_Details).Rows(x)(ColumnAmount_Details)), 0, ds.Tables(TableName_Details).Rows(x)(ColumnAmount_Details))
                        tmpTotal = amount

                        If ColumnAddBack_Details <> "" AndAlso IsDBNull(ds.Tables(TableName_Details).Rows(x)(ColumnAddBack_Details)) = False AndAlso CBool(ds.Tables(TableName_Details).Rows(x)(ColumnAddBack_Details)) Then
                            MainTotal = Math.Round(CDec(tmpTotal), 2)
                            RunningTotal += MainTotal
                            ds.Tables(TableName_Details).Rows(x)(ColumnPecentageAmount) = MainTotal
                        ElseIf ColumnDeduct_Details <> "" AndAlso IsDBNull(ds.Tables(TableName_Details).Rows(x)(ColumnDeduct_Details)) = False AndAlso CBool(ds.Tables(TableName_Details).Rows(x)(ColumnDeduct_Details)) Then
                            'MainTotal = Math.Round(CDec(tmpTotal / -1), 2)
                            'RunningTotal += MainTotal
                            ds.Tables(TableName_Details).Rows(x)(ColumnPecentageAmount) = MainTotal
                        Else
                            ds.Tables(TableName_Details).Rows(x)(ColumnPecentageAmount) = 0
                        End If


                        ds.Tables(TableName).Rows(i)(ColumnPecentageAmount) = RunningTotal
                    End If

                Next

            Next
            Application.DoEvents()



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
            AddListOfError(Errorlog)
            Return True
        End Try
    End Function
    Public Function CalcPercentageAmount(ByRef ds As DataSet, ByVal TableName As String, ByVal TableName_Details As String, _
                                         ByVal ColumnName_Key As String, ByVal ColumnNameDetails_Key As String, _
                                         ByVal ColumnAddBack As String, ByVal ColumnDeduct As String, _
                                         ByVal ColumnAddBack_Details As String, ByVal ColumnDeduct_Details As String, _
                                         ByVal ColumnAmount As String, ByVal ColumnAmount_Details As String, _
                                         ByVal ColumnPecentage As String, ByVal ColumnPecentageAmount As String, _
                                         Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try

            Dim tmpTotal As Decimal = 0
            Dim MainTotal As Decimal = 0
            Dim RunningTotal As Decimal = 0
            Dim percentage As Decimal = 0
            Dim amount As Decimal = 0

            For i As Integer = 0 To ds.Tables(TableName).Rows.Count - 1

                percentage = IIf(IsDBNull(ds.Tables(TableName).Rows(i)(ColumnPecentage)), 0, ds.Tables(TableName).Rows(i)(ColumnPecentage))
                amount = IIf(IsDBNull(ds.Tables(TableName).Rows(i)(ColumnAmount)), 0, ds.Tables(TableName).Rows(i)(ColumnAmount))
                tmpTotal = (amount / 100) * percentage

                If IsDBNull(ds.Tables(TableName).Rows(i)(ColumnAddBack)) = False AndAlso CBool(ds.Tables(TableName).Rows(i)(ColumnAddBack)) Then
                    ds.Tables(TableName).Rows(i)(ColumnPecentageAmount) = Math.Round(CDec(tmpTotal), 2)
                    'ElseIf IsDBNull(ds.Tables(TableName).Rows(i)(ColumnDeduct)) = False AndAlso CBool(ds.Tables(TableName).Rows(i)(ColumnDeduct)) Then
                    '    ds.Tables(TableName).Rows(i)(ColumnPecentageAmount) = Math.Round(CDec(tmpTotal / -1), 2)
                Else
                    ds.Tables(TableName).Rows(i)(ColumnPecentageAmount) = 0
                End If
                RunningTotal = 0
                For x As Integer = 0 To ds.Tables(TableName_Details).Rows.Count - 1

                    If ds.Tables(TableName_Details).Rows(x)(ColumnNameDetails_Key) = ds.Tables(TableName).Rows(i)(ColumnName_Key) Then
                        percentage = IIf(IsDBNull(ds.Tables(TableName_Details).Rows(x)(ColumnPecentage)), 0, ds.Tables(TableName_Details).Rows(x)(ColumnPecentage))
                        amount = IIf(IsDBNull(ds.Tables(TableName_Details).Rows(x)(ColumnAmount_Details)), 0, ds.Tables(TableName_Details).Rows(x)(ColumnAmount_Details))
                        tmpTotal = (amount / 100) * percentage

                        If IsDBNull(ds.Tables(TableName_Details).Rows(x)(ColumnAddBack_Details)) = False AndAlso CBool(ds.Tables(TableName_Details).Rows(x)(ColumnAddBack_Details)) Then
                            MainTotal = Math.Round(CDec(tmpTotal), 2)
                            RunningTotal += MainTotal
                            ds.Tables(TableName_Details).Rows(x)(ColumnPecentageAmount) = MainTotal
                            'ElseIf IsDBNull(ds.Tables(TableName_Details).Rows(x)(ColumnDeduct_Details)) = False AndAlso CBool(ds.Tables(TableName_Details).Rows(x)(ColumnDeduct_Details)) Then
                            '    MainTotal = Math.Round(CDec(tmpTotal / -1), 2)
                            '    RunningTotal += MainTotal
                            '    ds.Tables(TableName_Details).Rows(x)(ColumnPecentageAmount) = MainTotal
                        Else
                            ds.Tables(TableName_Details).Rows(x)(ColumnPecentageAmount) = 0
                        End If


                        ds.Tables(TableName).Rows(i)(ColumnPecentageAmount) = RunningTotal
                    End If

                Next

            Next
            Application.DoEvents()



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
            AddListOfError(Errorlog)
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
    Public TypeReport As PNL_TypeReport = PNL_TypeReport.Sales_TurnOver
    Sub New()

    End Sub

    Sub New(ByVal LabeName_ As String, ByVal LabelText_ As String, ByVal LabelTricor_ As String, ByVal Type_ As TaxComPNLEnuItem, ByVal TypeReport_ As PNL_TypeReport)
        LabelName = LabeName_
        LabelText = LabelText_
        LabelTricor = LabelTricor_
        Type = Type_
        TypeReport = TypeReport_
    End Sub
End Class
