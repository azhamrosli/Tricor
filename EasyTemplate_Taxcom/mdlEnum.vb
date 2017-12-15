Module mdlEnum
    Public Enum PNL_REPORT_TypeRow
        TITLE = 0
        SUBTOTAL = 1
        TOTAL = 2
        NORMAL = 3
    End Enum
    Public Enum CAReport_TableType
        CA_REPORT_TEMP
        CA_REPORT_SUMMARY_TEMP
        CA_REPORT_FIXEDASET_RECONCILIATION
    End Enum
    Public Enum CAReport_Type

        CA_REPORT_DETAILS_BYASSET = 0
        CA_REPORT_DETAILS_BYRATE = 1
        CA_REPORT_DETAILS_BYCATEGORY = 2
        CA_REPORT_SUMMARY_BYRATE = 3
        CA_REPORT_SUMMARY_BYCATEGORY = 4
        CA_REPORT_FIXEDASET_RECONCILIATION = 5
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
