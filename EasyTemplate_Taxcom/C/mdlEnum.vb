Module mdlEnum

    Public Enum ModuleName
        CAPITAL_ALLOWANCE
        HIRE_PURCHASE
        DISPOSAL
        DEEMED_INTEREST
        PROFIT_AND_lOSS
        MOVEMENT_NORMAL
        MOVEMENT_COMPLEX
        CP204
        TABLE_OF_CONTENT
        WORD
        EXCEL
        LOGIN_ADMINISTRATOR
        USER_NOTE
        DATABASE_CONGIRURATION

    End Enum
    Public Enum PNL_REPORT_TypeRow
        TITLE = 0
        SUBTOTAL = 1
        TOTAL = 2
        NORMAL = 3
    End Enum
    
    Public Enum CAReport_Type

        '1.   Capital Allowance Details By Rate
        '2.   Capital Allowance Details By Category
        '3.   Capital Allowance Details By Asset
        '4.   Capital Allowance Summary By Rate
        '5.   Capital Allowance Summary By Category
        '6.   Capital Allowance Summary By Asset
        '7.   Fixed Asset Reconciliation Report
        '8.   Control Transfer In Report
        '9.   Disposal Report
        '10. Written-Off Report
        '11. Control Transfer Out Report

        CA_REPORT_DETAILS_BYASSET = 0
        CA_REPORT_DETAILS_BYRATE = 1
        CA_REPORT_DETAILS_BYCATEGORY = 2
        CA_REPORT_SUMMARY_BYRATE = 3
        CA_REPORT_SUMMARY_BYCATEGORY = 4
        CA_REPORT_SUMMARY_BYASSET = 5
        CA_REPORT_FIXEDASET_RECONCILIATION = 6
        CA_REPORT_CONTROLTRANSFER_IN = 7
        DISPOSAL_REPORT = 8
        DISPOSAL_REPORT_WRITTENOFF_OUT = 9
        DISPOSAL_REPORT_CONTROLTRANSFER_OUT = 10
    End Enum
    Public Enum PNL_TypeReport
        Sales_TurnOver
        Less_Cost_Of_Good_Sold
        Product_Cost
        CloseStock
        GrossProfit
        Other_Business_Income
        Other_Non_Business_Income
        Non_Taxable_Income
        Expenses
        Other_Expenses
        Net_Profit_Loss
        Non_Allowanble_Expenses
    End Enum
    Public Enum TaxComPNLEnuItem
        SALES
        OPENSTOCK
        PURCHASE
        DEPRECIATION
        OTHERALLOWEXP
        OTHERNONALLOWEXP
        CLOSESTOCK
        OTHERBUSINC
        DIVIDENDINC
        INTERESTINC
        RENTALINC
        ROYALTYINC
        OTHERINC
        PDFIXASSET
        PDINVEST
        EXEMDIV
        FORINCREMIT
        REALFE
        UNREALFETRADE
        UNREALFENONTRADE
        OTHERNONTAXINC
        INTERESTRESTRICT
        EXPOTHERINTEREST
        EXPLEGAL
        EXPTECHNICAL
        EXPCONTRACTPAY
        EXPDIRECTORFEE
        EXPSALARY
        EXPEMPLOYEESTOCK
        EXPROYALTY
        EXPRENTAL
        EXPREPAIRMAINTENANCE
        EXPRND
        EXPADVERTISEMENT
        EXPTRAVEL
        EXPJKDM
        EXPDEPRECIATION
        EXPDONATIONAPPR
        EXPDONATIONNONAPPR
        EXPZAKAT
        EXPLOSSDISPFA
        EXPENTERTAINNONSTAFF
        EXPENTERTAINSTAFF
        EXPCOMPAUNDPENALTY
        EXPPROVISION
        EXPLEAVEPASSAGE
        EXPFAWRITTENOFF
        EXPUNREALLOSSFE
        EXPREALLOSSFETRADE
        EXPREALLOSSFENONTRADE
        EXPINITIALSUBSCRIPT
        EXPCAPITALEXPENDITURE
        EXPOTHERSEXPENSES
        GROSSPROFIT
        OTHERBALANCINGFIGURE
        TOTALOTHEREXPENSES
        TOTALEXPENSES
        NETPROFITORLOSS
        NONALLOWABLEEXPENSES
        REALFETRADE
        FORECURREXLOSS
        COSTPRODUCT
        COSTPRODUCT_TITLEONLY
        PURCHASECOSTPRODUCT
        COSTOFSALES
        LESSCOSTSALES_TITLEONLY
    End Enum





End Module
