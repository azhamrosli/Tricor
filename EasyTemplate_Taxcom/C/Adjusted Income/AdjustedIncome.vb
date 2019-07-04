Imports System.Data.SqlClient

Public Class AdjustedIncome
    Inherits clsIODatabase
    Public Property RefNo As String = ""
    Public Property YA As String = ""
    Public Property SourceNo As Integer = 0
    Public Property TypeSubData As EnumTypeSubData = EnumTypeSubData.NON_ALLOW_LOSS
    Public Property dsAdjustIncome As DataSet
    Public WithEvents TaxCom As TaxComputation

    Public Event OnLoadTaxcom(dt_ As DataTable, ByVal dtTaxpayer_ As DataTable)
    Public Event OnChangeStatus(Status_ As EnumStatus, Stage_ As EnumStage, Errorlog_ As ClsError)
    Public Event OnChangeStep1(txtBalProfit_ As Decimal, txtBalLoss_ As Decimal, txtDividend_ As Decimal,
                               txtInterest_ As Decimal, txtRental_ As Decimal, txtRoyalty_ As Decimal, txtSection4A_ As Decimal,
                               txtTotBsProfit_ As Decimal, txtNTaxIn_ As Decimal, txtOthBsIn_ As Decimal, txtTotNonBs_ As Decimal,
                               txtInterestRestricted_ As Decimal, txtNAExp_ As Decimal, txtTotBsLoss_ As Decimal)

    Public Event OnChangeStatutoryIncome(row_ As DataRow)

    Protected Property txtBalProfit As Decimal = 0
    Protected Property txtBalLoss As Decimal = 0
    Protected Property txtDividend As Decimal = 0
    Protected Property txtInterest As Decimal = 0
    Protected Property txtRental As Decimal = 0
    Protected Property txtRoyalty As Decimal = 0
    Protected Property txtSection4A As Decimal = 0
    Protected Property txtTotBsProfit As Decimal = 0
    Protected Property txtOthBsIn As Decimal = 0
    Protected Property txtInterestRestricted As Decimal = 0
    Protected Property txtTotNonBs As Decimal = 0
    Protected Property txtTotBsLoss As Decimal = 0
    Protected Property txtNTaxIn As Decimal = 0

    Public Event OnChangeStep2(txtNALoss_ As Decimal, txtSurplusMiningAllowance_ As Decimal, txtTaxIn_ As Decimal, _
                               txtMiningAllowing_ As Decimal, txtAddMiningExp_ As Decimal, txtRevenueExp_ As Decimal, _
                               txtOtherDeduc_ As Decimal, txtOthExp_ As Decimal)


    Protected Property txtNALoss As Decimal = 0
    Protected Property txtSurplusMiningAllowance As Decimal = 0
    Protected Property txtTaxIn As Decimal = 0
    Protected Property txtMiningAllowing As Decimal = 0
    Protected Property txtAddMiningExp As Decimal = 0
    Protected Property txtRevenueExp As Decimal = 0
    Protected Property txtOtherDeduc As Decimal = 0
    Protected Property txtOthExp As Decimal = 0
    Protected Property txtNAExp As Decimal = 0

    Public Event OnChangeStep3(txtTotBIProfit_ As Decimal, txtTotBILoss_ As Decimal, txtTotBSExp_ As Decimal,
                               txtAdIn_ As Decimal, txtAdLoss_ As Decimal)


    Protected Property txtTotBIProfit As Decimal = 0
    Protected Property txtTotBILoss As Decimal = 0
    Protected Property txtTotBSExp As Decimal = 0
    Protected Property txtAdIn As Decimal = 0
    Protected Property txtAdLoss As Decimal = 0

    Public Property PL_KEY As Integer = 0
    Public Property dtPNL As DataRow = Nothing

    'PNL START
    '==================================================================
    Private Property dtSALES As Decimal = 0
    Private Property dtOPENSTOCK As Decimal = 0
    Private Property dtPURCHASE As Decimal = 0
    Private Property dtDEPRECIATION As Decimal = 0
    Private Property dtOTHERALLOWEXP As Decimal = 0
    Private Property dtOTHERNONALLOWEXP As Decimal = 0
    Private Property dtCLOSESTOCK As Decimal = 0
    Private Property dtOTHERBUSINC As Decimal = 0
    Private Property dtREALFETRADE As Decimal = 0
    Private Property dtDIVIDENDINC As Decimal = 0
    Private Property dtINTERESTINC As Decimal = 0
    Private Property dtRENTALINC As Decimal = 0
    Private Property dtROYALTYINC As Decimal = 0
    Private Property dtOTHERINC As Decimal = 0
    Private Property dtPDFIXASSET As Decimal = 0
    Private Property dtPDINVEST As Decimal = 0
    Private Property dtEXEMDIV As Decimal = 0
    Private Property dtFORINCREMIT As Decimal = 0
    Private Property dtREALFE As Decimal = 0
    Private Property dtUNREALFENONTRADE As Decimal = 0
    Private Property dtUNREALFETRADE As Decimal = 0
    Private Property dtOTHERNONTAXINC As Decimal = 0
    Private Property dtINTERESTRESTRICT As Decimal = 0
    Private Property dtEXPOTHERINTEREST As Decimal = 0
    Private Property dtEXPLEGAL As Decimal = 0
    Private Property dtEXPTECHNICAL As Decimal = 0
    Private Property dtEXPCONTRACTPAY As Decimal = 0
    Private Property dtEXPDIRECTORFEE As Decimal = 0
    Private Property dtEXPSALARY As Decimal = 0
    Private Property dtEXPEMPLOYEESTOCK As Decimal = 0
    Private Property dtEXPROYALTY As Decimal = 0
    Private Property dtEXPRENTAL As Decimal = 0
    Private Property dtEXPREPAIRMAINTENANCE As Decimal = 0
    Private Property dtEXPRND As Decimal = 0
    Private Property dtEXPADVERTISEMENT As Decimal = 0
    Private Property dtEXPTRAVEL As Decimal = 0
    Private Property dtFORECURREXLOSS As Decimal = 0
    Private Property dtEXPJKDM As Decimal = 0
    Private Property dtEXPDEPRECIATION As Decimal = 0
    Private Property dtEXPDONATIONAPPR As Decimal = 0
    Private Property dtEXPDONATIONNONAPPR As Decimal = 0
    Private Property dtEXPZAKAT As Decimal = 0
    Private Property dtEXPLOSSDISPFA As Decimal = 0
    Private Property dtEXPENTERTAINNONSTAFF As Decimal = 0
    Private Property dtEXPENTERTAINSTAFF As Decimal = 0
    Private Property dtEXPCOMPAUNDPENALTY As Decimal = 0
    Private Property dtEXPPROVISION As Decimal = 0
    Private Property dtEXPLEAVEPASSAGE As Decimal = 0
    Private Property dtEXPFAWRITTENOFF As Decimal = 0
    Private Property dtEXPUNREALLOSSFE As Decimal = 0
    Private Property dtEXPREALLOSSFETRADE As Decimal = 0
    Private Property dtEXPREALLOSSFENONTRADE As Decimal = 0
    Private Property dtEXPINITIALSUBSCRIPT As Decimal = 0
    Private Property dtEXPCAPITALEXPENDITURE As Decimal = 0
    Private Property dtEXPOTHERSEXPENSES As Decimal = 0
    '==================================================================
    'PNL END

    Public Property Status As EnumStatus = EnumStatus.Ready
    Public Property Stage As EnumStatus = EnumStage.none
    Public Property ErrorLog As ClsError = Nothing
    Public Property PNLInfo As DataTable = Nothing

    Dim dt As DataTable = Nothing

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
    Enum EnumTypeSubData
        NON_ALLOW_LOSS = 0
        SURPLUS_MINING_ALLOW = 1
        TAXABLE_INCOME = 2
        MINING_EXPENSES = 3
        MINING_ALLOWNANCE = 4
        REVENUE_EXPENDITURE = 5
        OTHER_DEDUCTION = 6
        OTHER_EXPENDITURE = 7
    End Enum

    Sub New()
        If TaxCom Is Nothing Then
            TaxCom = New TaxComputation
        End If
    End Sub
    Public Sub LoadData()
        Try
            ChangeStatus(EnumStatus.InProgress, EnumStage.Load)
            PNLInfo = Load_PNLINFO(ErrorLog)

            If PNLInfo Is Nothing Then
                ChangeStatus(EnumStatus.Failed, EnumStage.Load)
                Exit Sub
            End If

            dsAdjustIncome.Tables("NON_ALLOW_LOSS").Rows.Clear()
            dsAdjustIncome.Tables("SURPLUS_RECOVERED").Rows.Clear()
            dsAdjustIncome.Tables("TAXABLE_INCOME").Rows.Clear()
            dsAdjustIncome.Tables("MINING_ALLOWNANCE").Rows.Clear()
            dsAdjustIncome.Tables("MINING_EXPENSES").Rows.Clear()
            dsAdjustIncome.Tables("REVENUE_EXPENDITURE").Rows.Clear()
            dsAdjustIncome.Tables("OTHER_EXPENDITURE").Rows.Clear()
            dsAdjustIncome.Tables("OTHER_DEDUCTION").Rows.Clear()

            dt = Load_PNL(RefNo, YA, ErrorLog)

            If dt Is Nothing Then
                ChangeStatus(EnumStatus.Failed, EnumStage.Calculating)
                Exit Sub
            End If

            dtPNL = dt.Rows(0)

            If IsDBNull(dtPNL("PL_S60F")) = False AndAlso dtPNL("PL_S60F") = "Y" Then
                ChangeStatus(EnumStatus.isInvestmentHolding, EnumStage.Load)
                Exit Sub
            End If

            PL_KEY = IIf(IsDBNull(dt.Rows(0)("PL_KEY")), 0, dt.Rows(0)("PL_KEY"))

            Dim tmpNameColumn As String = ""
            Dim tmpAmount As Decimal = 0
            Dim KeyName As String = ""
            For Each rowInfo As DataRow In PNLInfo.Rows

                If IsDBNull(rowInfo("TableName")) = False AndAlso IsDBNull(rowInfo("PrefixName")) = False AndAlso IsDBNull(rowInfo("ColumnSourceNo")) = False Then
                    tmpNameColumn = rowInfo("PrefixName") & "_KEY"
                    tmpAmount = 0
                    tmpAmount = Load_PNLItem(rowInfo("TableName"), tmpNameColumn, rowInfo("ColumnSourceNo"), rowInfo("ColumnAmount"))
                    KeyName = IIf(IsDBNull(rowInfo("KeyName")), "", rowInfo("KeyName"))
                    ' If dt IsNot Nothing Then
                    Select Case KeyName
                        Case "SALES"
                            dtSALES = tmpAmount
                        Case "OPENSTOCK"
                            dtOPENSTOCK = tmpAmount
                        Case "PURCHASE"
                            dtPURCHASE = tmpAmount
                        Case "DEPRECIATION"
                            dtDEPRECIATION = tmpAmount
                        Case "OTHERALLOWEXP"
                            dtOTHERALLOWEXP = tmpAmount
                        Case "OTHERNONALLOWEXP"
                            dtOTHERNONALLOWEXP = tmpAmount
                        Case "CLOSESTOCK"
                            dtCLOSESTOCK = tmpAmount
                        Case "OTHERBUSINC"
                            dtOTHERBUSINC = tmpAmount
                        Case "REALFETRADE"
                            dtREALFETRADE = tmpAmount
                        Case "DIVIDENDINC"
                            dt = Nothing
                            dt = DIVIDEND_INCOME(PL_KEY, ErrorLog)

                            If dt IsNot Nothing Then
                                For Each rowx As DataRow In dt.Rows
                                    If IsDBNull(rowx("DI_DISCLOSE")) = False Then

                                        If rowx("DI_DISCLOSE") = "Yes" Then
                                            If IsDBNull(rowx("DI_NET")) = False AndAlso IsNumeric(rowx("DI_NET")) Then
                                                dtDIVIDENDINC += CDec(rowx("DI_NET"))
                                            End If
                                        Else
                                            If IsDBNull(rowx("DI_GROSS")) = False AndAlso IsNumeric(rowx("DI_GROSS")) Then
                                                dtDIVIDENDINC += CDec(rowx("DI_GROSS"))
                                            End If
                                        End If
                                    End If

                                Next
                            End If

                        Case "INTERESTINC"
                            dtINTERESTINC = tmpAmount
                        Case "RENTALINC"
                            dtRENTALINC = tmpAmount
                        Case "ROYALTYINC"
                            dtROYALTYINC = tmpAmount
                        Case "OTHERINC"
                            dtOTHERINC = tmpAmount
                        Case "PDFIXASSET"
                            dtPDFIXASSET = tmpAmount
                        Case "PDINVEST"
                            dtPDINVEST = tmpAmount
                        Case "EXEMDIV"
                            dtEXEMDIV = tmpAmount
                        Case "FORINCREMIT"
                            dtFORINCREMIT = tmpAmount
                        Case "REALFE"
                            dtREALFE = tmpAmount
                        Case "UNREALFENONTRADE"
                            dtUNREALFENONTRADE = tmpAmount
                        Case "UNREALFETRADE"
                            dtUNREALFETRADE = tmpAmount
                        Case "OTHERNONTAXINC"
                            dtOTHERNONTAXINC = tmpAmount
                        Case "INTERESTRESTRICT"
                            dtINTERESTRESTRICT = tmpAmount
                        Case "EXPOTHERINTEREST"
                            dtEXPOTHERINTEREST = tmpAmount
                        Case "EXPLEGAL"
                            dtEXPLEGAL = tmpAmount
                        Case "EXPTECHNICAL"
                            dtEXPTECHNICAL = tmpAmount
                        Case "EXPCONTRACTPAY"
                            dtEXPCONTRACTPAY = tmpAmount
                        Case "EXPDIRECTORFEE"
                            dtEXPDIRECTORFEE = tmpAmount
                        Case "EXPSALARY"
                            dtEXPSALARY = tmpAmount
                        Case "EXPEMPLOYEESTOCK"
                            dtEXPEMPLOYEESTOCK = tmpAmount
                        Case "EXPROYALTY"
                            dtEXPROYALTY = tmpAmount
                        Case "EXPRENTAL"
                            dtEXPRENTAL = tmpAmount
                        Case "EXPREPAIRMAINTENANCE"
                            dtEXPREPAIRMAINTENANCE = tmpAmount
                        Case "EXPRND"
                            dtEXPRND = tmpAmount
                        Case "EXPADVERTISEMENT"
                            dtEXPADVERTISEMENT = tmpAmount
                        Case "EXPTRAVEL"
                            dtEXPTRAVEL = tmpAmount
                        Case "FORECURREXLOSS"
                            dtFORECURREXLOSS = tmpAmount
                        Case "EXPJKDM"
                            dtEXPJKDM = tmpAmount
                        Case "EXPDEPRECIATION"
                            dtEXPDEPRECIATION = tmpAmount
                        Case "EXPDONATIONAPPR"
                            dtEXPDONATIONAPPR = tmpAmount
                        Case "EXPDONATIONNONAPPR"
                            dtEXPDONATIONNONAPPR = tmpAmount
                        Case "EXPZAKAT"
                            dtEXPZAKAT = tmpAmount
                        Case "EXPLOSSDISPFA"
                            dtEXPLOSSDISPFA = tmpAmount
                        Case "EXPENTERTAINNONSTAFF"
                            dtEXPENTERTAINNONSTAFF = tmpAmount
                        Case "EXPENTERTAINSTAFF"
                            dtEXPENTERTAINSTAFF = tmpAmount
                        Case "EXPCOMPAUNDPENALTY"
                            dtEXPCOMPAUNDPENALTY = tmpAmount
                        Case "EXPPROVISION"
                            dtEXPPROVISION = tmpAmount
                        Case "EXPLEAVEPASSAGE"
                            dtEXPLEAVEPASSAGE = tmpAmount
                        Case "EXPFAWRITTENOFF"
                            dtEXPFAWRITTENOFF = tmpAmount
                        Case "EXPUNREALLOSSFE"
                            dtEXPUNREALLOSSFE = tmpAmount
                        Case "EXPREALLOSSFETRADE"
                            dtEXPREALLOSSFETRADE = tmpAmount
                        Case "EXPREALLOSSFENONTRADE"
                            dtEXPREALLOSSFENONTRADE = tmpAmount
                        Case "EXPINITIALSUBSCRIPT"
                            dtEXPINITIALSUBSCRIPT = tmpAmount
                        Case "EXPCAPITALEXPENDITURE"
                            dtEXPCAPITALEXPENDITURE = tmpAmount
                        Case "EXPOTHERSEXPENSES"
                            dtEXPOTHERSEXPENSES = tmpAmount
                    End Select
                    'End If
                End If

            Next
            ' txt_p1GrossProfitLoss.EditValue = mdlPNL.CalcGrossProfitLoss(IIf(IsNumeric(txt_p1Sales.EditValue) = False, 0, txt_p1Sales.EditValue), IIf(IsNumeric(txt_p1COS.EditValue) = False, 0, txt_p1COS.EditValue))
            Dim p1COP As Decimal = 0
            Dim p1PCP As Decimal = 0
            Dim p1COS As Decimal = 0
            Dim TotalGrossPL As Decimal = 0
            p1COP = dtDEPRECIATION + dtOTHERALLOWEXP + dtOTHERNONALLOWEXP
            p1PCP = dtPURCHASE + p1COP
            p1COS = (dtOPENSTOCK + p1PCP) - dtCLOSESTOCK
            TotalGrossPL = dtSALES - p1COS

            Dim TotalNBI As Decimal = dtDIVIDENDINC + dtRENTALINC + dtROYALTYINC + dtINTERESTINC + dtOTHERINC
            Dim Bus_Inc As Decimal = dtOTHERBUSINC
            Dim NTax_In As Decimal = dtOTHERNONTAXINC + dtEXEMDIV
            Dim Tax_In As Decimal = 0
            Dim NA_Exp As Decimal = dtEXPOTHERINTEREST + dtEXPCONTRACTPAY + dtEXPLEGAL + dtEXPSALARY + dtEXPROYALTY + dtEXPRENTAL + dtEXPREPAIRMAINTENANCE
            NA_Exp += dtEXPRND + dtEXPADVERTISEMENT + dtEXPTRAVEL + dtEXPOTHERSEXPENSES + dtINTERESTRESTRICT + dtEXPEMPLOYEESTOCK + dtEXPTECHNICAL + dtEXPREALLOSSFETRADE + dtEXPDIRECTORFEE + dtEXPJKDM
            NA_Exp += dtEXPDEPRECIATION + dtEXPDONATIONAPPR + dtEXPDONATIONNONAPPR + dtEXPZAKAT + dtEXPENTERTAINNONSTAFF + dtEXPENTERTAINSTAFF + dtEXPCOMPAUNDPENALTY
            NA_Exp += dtEXPPROVISION + dtEXPLEAVEPASSAGE + dtEXPFAWRITTENOFF + dtEXPINITIALSUBSCRIPT + dtEXPCAPITALEXPENDITURE + dtEXPUNREALLOSSFE + dtEXPREALLOSSFENONTRADE

            Dim Revenue_Exp As Decimal = 0
            Dim Oth_Exp As Decimal = 0
            Dim NA_Loss As Decimal = NON_ALLOW_LOSS() + dtFORECURREXLOSS + dtEXPUNREALLOSSFE + dtEXPREALLOSSFENONTRADE + dtEXPLOSSDISPFA
            Dim RealFETrade As Decimal = dtREALFETRADE
            Dim Other_Business As Decimal = OTHER_BUSINESS_INCOME(PL_KEY)
            Dim lngBalancingFigure As Decimal = IIf(IsDBNull(dtPNL("PL_OTHER_EXP_BALANCE")), 0, dtPNL("PL_OTHER_EXP_BALANCE"))
            Dim Interest_Restrict As Decimal = EXPENSES_INTERESTRESTRICT(PL_KEY, ErrorLog)
            ' Dim NA_Exp As Decimal = 0
            txtOthBsIn = Other_Business

            Dim data As Decimal = TotalGrossPL - Other_Business + TotalNBI + Bus_Inc + NTax_In - NA_Exp - lngBalancingFigure + RealFETrade

            If IIf(IsDBNull(dtPNL("PL_MAINBUZ")), -1, dtPNL("PL_MAINBUZ")) <> SourceNo Then
                data = data - lngBalancingFigure
            End If

            If data < 0 Then
                txtBalLoss = data
                txtBalProfit = 0
            Else
                txtBalLoss = 0
                txtBalProfit = data
            End If

            txtDividend = dtDIVIDENDINC
            txtInterest = dtINTERESTINC
            txtRental = dtRENTALINC
            txtRoyalty = dtROYALTYINC
            txtSection4A = dtOTHERINC
            txtInterestRestricted = Interest_Restrict

            txtTotNonBs = txtDividend + txtInterest + txtRental + txtRoyalty + txtSection4A
            data = data - txtTotNonBs

            If data < 0 Then
                txtTotBsLoss = data
                txtTotBsProfit = 0
            Else
                txtTotBsLoss = 0
                txtTotBsProfit = data
            End If

            txtNTaxIn = 0
            If SourceNo = 1 Then
                txtNTaxIn = NON_TAXABLE_INCOME(ErrorLog) + EXEMPT_DIVIDEND(PL_KEY, ErrorLog)
            Else
                txtNTaxIn = NON_TAXABLE_INCOME(ErrorLog) + EXEMPT_DIVIDEND(PL_KEY, ErrorLog) + INCOME_REALFET(PL_KEY, ErrorLog)
            End If
            Load_NonAllowableExpenses(PNLInfo)
            Application.DoEvents()
            Load_SubItem_Data()
            Application.DoEvents()


            RaiseEvent OnChangeStep1(txtBalProfit, txtBalLoss, txtDividend, txtInterest, txtRental, txtRoyalty, txtSection4A,
                                     txtTotBsProfit, txtNTaxIn, txtOthBsIn, txtTotNonBs, txtInterestRestricted, txtNAExp, txtTotBsLoss)

            CalcAdjustedIncome()
            ChangeStatus(EnumStatus.Done, EnumStage.Load)

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
    Public Sub Load_NonAllowableExpenses(ByVal PNLInfo_ As DataTable)
        Try
            ChangeStatus(EnumStatus.InProgress, EnumStage.Load)
            'Non-allowable expenditure pursuant to sec39(1)
            NA_Exp = 0
           
            For Each rowInfo As DataRow In PNLInfo_.Rows
                If IsDBNull(rowInfo("Type")) = False AndAlso rowInfo("Type") <> 1 Then
                    If IsDBNull(rowInfo("TableName")) = False AndAlso IsDBNull(rowInfo("PrefixName")) = False AndAlso
                        IsDBNull(rowInfo("ColumnSourceNo")) = False AndAlso IsDBNull(rowInfo("ColumnAmount")) = False Then

                        tmpNameColumn = rowInfo("PrefixName") & "_KEY"
                        tmpAmount = 0

                        If rowInfo("TableName").ToString.ToUpper = "OTHER_EXAPPRDONATION" Or rowInfo("TableName").ToString.ToUpper = "OTHER_EXZAKAT" Then
                            tmpAmount = Load_PNLItem(rowInfo("TableName"), tmpNameColumn, rowInfo("ColumnSourceNo"), rowInfo("ColumnPecentage_Amount"))

                        Else
                            tmpAmount = Load_PNLItem_NonAllowable(rowInfo("TableName"), tmpNameColumn, rowInfo("ColumnSourceNo"),
                                                              rowInfo("ColumnPecentage_Amount"), rowInfo("ColumnAddBack"))
                        End If

                        NA_Exp += tmpAmount

                    End If
                End If
            Next

            Dim Movement As DataTable = MOVEMENT_NORMAL_NON_ALLOWABLE_EXPENSES(RefNo, YA, ErrorLog)

            If Movement IsNot Nothing Then
                For Each rowx As DataRow In Movement.Rows
                    If IsDBNull(rowx("MM_ADD_DEDUCT_AMOUNT")) = False AndAlso IsNumeric(rowx("MM_ADD_DEDUCT_AMOUNT")) Then
                        NA_Exp += CDec(rowx("MM_ADD_DEDUCT_AMOUNT"))
                    End If
                Next
            End If
            Movement = Nothing
            Movement = MOVEMENT_COMPLEX_NON_ALLOWABLE_EXPENSES(RefNo, YA, ErrorLog)
            If Movement IsNot Nothing Then
                For Each rowx As DataRow In Movement.Rows
                    If IsDBNull(rowx("MM_ADD_DEDUCT_AMOUNT")) = False AndAlso IsNumeric(rowx("MM_ADD_DEDUCT_AMOUNT")) Then
                        NA_Exp += CDec(rowx("MM_ADD_DEDUCT_AMOUNT"))
                    End If
                Next
            End If

            txtNAExp = NA_Exp
            ChangeStatus(EnumStatus.Done, EnumStage.Load)
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
    Public Sub Load_NonAllowableExpensesData(ByVal PNLInfo_ As DataTable)
        Try
            ChangeStatus(EnumStatus.InProgress, EnumStage.Load)
            'Non-allowable expenditure pursuant to sec39(1)
            NA_Exp = 0
            Dim dtTmp As DataTable = Nothing
            Dim dtRow As DataRow = Nothing
            Dim tmpTotalx As Decimal = 0

            dt = Load_PNL(RefNo, YA, ErrorLog)

            If dt Is Nothing Then
                ChangeStatus(EnumStatus.Failed, EnumStage.Calculating)
                Exit Sub
            End If

            dtPNL = dt.Rows(0)

            PL_KEY = IIf(IsDBNull(dt.Rows(0)("PL_KEY")), 0, dt.Rows(0)("PL_KEY"))

            For Each rowInfo As DataRow In PNLInfo_.Rows
                If IsDBNull(rowInfo("Type")) = False AndAlso rowInfo("Type") <> 1 Then
                    If IsDBNull(rowInfo("TableName")) = False AndAlso IsDBNull(rowInfo("PrefixName")) = False AndAlso
                        IsDBNull(rowInfo("ColumnSourceNo")) = False AndAlso IsDBNull(rowInfo("ColumnAmount")) = False Then

                        tmpNameColumn = rowInfo("PrefixName") & "_KEY"
                        dtRow = Nothing
                        dtTmp = Nothing
                        If rowInfo("TableName").ToString.ToUpper = "OTHER_EXAPPRDONATION" Or rowInfo("TableName").ToString.ToUpper = "OTHER_EXZAKAT" Then
                            dtTmp = Load_PNLItemData(rowInfo("TableName"), tmpNameColumn, rowInfo("ColumnAmount"))

                        Else
                            dtTmp = Load_PNLItem_NonAllowableData(rowInfo("TableName"), tmpNameColumn, rowInfo("ColumnAmount"), rowInfo("ColumnAddBack"))
                        End If

                        If dtTmp IsNot Nothing Then

                            For Each rowx As DataRow In dtTmp.Rows
                                dtRow = dsAdjustIncome.Tables("NON_ALLOWABLE_EXPENSES_REPORT").NewRow
                                dtRow("TITLE") = rowx(rowInfo("ColumnDescription"))
                                dtRow("SOURCE_NO") = rowx(rowInfo("ColumnSourceNo"))
                                tmpTotalx += rowx(rowInfo("ColumnPecentage_Amount"))
                                dtRow("AMOUNT") = rowx(rowInfo("ColumnPecentage_Amount"))
                                dtRow("TOTAL") = tmpTotalx
                                dsAdjustIncome.Tables("NON_ALLOWABLE_EXPENSES_REPORT").Rows.Add(dtRow)
                            Next

                        End If
                    End If
                End If
            Next
            ChangeStatus(EnumStatus.Done, EnumStage.Load)
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
    Public Sub SaveData()
        Try
            ChangeStatus(EnumStatus.InProgress, EnumStage.Save)
            TaxCom.RefNo = RefNo
            TaxCom.YA = YA
            TaxCom.SourceNo = SourceNo

            If txtBalLoss <= 0 Then
                TaxCom.TC_AI_PNL_BAL = txtBalLoss
            Else
                TaxCom.TC_AI_PNL_BAL = txtBalProfit
            End If
            TC_AI_DIVIDEND = txtDividend
            TaxCom.TC_AI_RENTAL = txtRental
            TaxCom.TC_AI_ROYALTY = txtRoyalty
            TaxCom.TC_AI_INTEREST = txtInterest
            TaxCom.TC_AI_SEC4A = txtSection4A
            TaxCom.TC_AI_OTH_BS_IN = txtOthBsIn
            TaxCom.TC_AI_TOT_NONBS_IN = txtTotNonBs

            If txtTotBsProfit <= 0 Then
                TaxCom.TC_AI_TOT_BS_IN = txtTotBsLoss
            Else
                TaxCom.TC_AI_TOT_BS_IN = txtTotBsProfit
            End If
            TaxCom.TC_AI_ADJ_BS_IN_NA_LOS = txtNALoss
            TaxCom.TC_AI_ADJ_BS_IN_NT_IN = txtNTaxIn
            TaxCom.TC_AI_ADJ_BS_IN_TAX_IN = txtTaxIn
            If txtTotBILoss <= 0 Then
                TaxCom.TC_AI_TOT_ADJ_BS_IN = txtTotBILoss
            Else
                TaxCom.TC_AI_TOT_ADJ_BS_IN = txtTotBIProfit
            End If

            TaxCom.TC_AI_ADJ_BS_EXP_INT = txtInterestRestricted
            TaxCom.TC_AI_ADJ_BS_EXP_NA_EXP = txtNAExp
            TaxCom.TC_AI_ADJ_BS_EXP_RV_EXP = txtRevenueExp
            TaxCom.TC_AI_ADJ_BS_EXP_CLAIM = txtOthExp
            TaxCom.TC_AI_TOT_ADJ_BS_EXP = txtTotBSExp

            If txtAdIn <= 0 Then
                TaxCom.TC_AI_ADJ_IN_LOSS = txtAdLoss
            Else
                TaxCom.TC_AI_ADJ_IN_LOSS = txtAdIn
            End If

            TaxCom.TC_OTHERDEDUCTION = txtOtherDeduc
            TaxCom.TC_SURPLUSRECOVERED = txtSurplusMiningAllowance
            TaxCom.TC_MININGALLOWNANCE = txtMiningAllowing
            TaxCom.TC_MININGEXPENSES = txtAddMiningExp

            If TaxCom.TC_AI_ADJ_IN_LOSS > 0 Then
                TaxCom.TC_SI_NET_STAT_IN = txtAdLoss - 0
            Else
                TaxCom.TC_SI_NET_STAT_IN = 0
            End If


            TaxCom.dsAdjustIncome = dsAdjustIncome
            TaxCom.SaveData()

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
    Private Sub CalcAdjustedIncome()
        Try
            Dim temptotal As Decimal = 0
            Dim businessexpendadjust As Decimal = 0
            Dim tmpadjustedincome As Decimal = 0
            Dim businessincomeadjust As Decimal = 0
            Dim businessincome As Decimal = 0

            ' Protected Property txtTotBsProfit As Decimal = 0
            'Protected Property txtOthBsIn As Decimal = 0
            If txtTotBsProfit = 0 Then
                businessincome = txtOthBsIn
            ElseIf txtOthBsIn = 0 Then
                businessincome = txtTotBsProfit
            End If

            temptotal = (txtNALoss + txtSurplusMiningAllowance) - (txtNTaxIn + txtTaxIn)

            If temptotal <= 0 Then
                txtTotBIProfit = 0
                txtTotBILoss = temptotal
            Else
                txtTotBIProfit = temptotal
                txtTotBILoss = 0
            End If
            businessincomeadjust = temptotal

            temptotal = (txtInterestRestricted + txtNAExp) - (txtRevenueExp + txtOthExp + txtOtherDeduc + txtMiningAllowing + txtAddMiningExp)
            txtTotBSExp = temptotal
            'adjustedincome = FormatNumber(CDbl(businessincome) + CDbl(businessincomeadjust) + CDbl(businessexpendadjust), 0)
            tmpadjustedincome = businessincome + businessincomeadjust + txtTotBSExp

            If tmpadjustedincome <= 0 Then
                txtAdIn = 0
                txtAdLoss = tmpadjustedincome
            Else
                txtAdIn = tmpadjustedincome
                txtAdLoss = 0
            End If

            RaiseEvent OnChangeStep3(txtTotBIProfit, txtTotBILoss, txtTotBSExp, txtAdIn, txtAdLoss)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub Get_Claim()
        Try
            ChangeStatus(EnumStatus.InProgress, EnumStage.Load)
            Dim dt As DataTable = Load_CLAIM_CODE()

            If dt IsNot Nothing Then

                If dsAdjustIncome Is Nothing Then
                    dsAdjustIncome = New dsAdjustedIncome
                End If

                For Each rowx As DataRow In dt.Rows
                    dsAdjustIncome.Tables("CLAIM").ImportRow(rowx)
                Next
            End If
            ChangeStatus(EnumStatus.Done, EnumStage.Load)
        Catch ex As Exception
            ChangeStatus(EnumStatus.Failed, EnumStage.Load)
        End Try
    End Sub
    Public Sub CalcTotalSubData()
        Try
            ChangeStatus(EnumStatus.InProgress, EnumStage.Calculating)

            Dim tmpDec As Decimal = 0
            Select Case TypeSubData
                Case EnumTypeSubData.NON_ALLOW_LOSS
                    tmpDec = 0

                    For Each rowx As DataRow In dsAdjustIncome.Tables("NON_ALLOW_LOSS").Rows
                        If rowx.RowState <> DataRowState.Deleted AndAlso IsDBNull(rowx("NL_AMOUNT")) = False AndAlso IsNumeric(rowx("NL_AMOUNT")) Then
                            tmpDec += CDec(rowx("NL_AMOUNT"))
                        End If
                    Next

                    txtNALoss = tmpDec
                Case EnumTypeSubData.SURPLUS_MINING_ALLOW
                    tmpDec = 0

                    For Each rowx As DataRow In dsAdjustIncome.Tables("SURPLUS_RECOVERED").Rows
                        If rowx.RowState <> DataRowState.Deleted AndAlso IsDBNull(rowx("SR_AMOUNT")) = False AndAlso IsNumeric(rowx("SR_AMOUNT")) Then
                            tmpDec += CDec(rowx("SR_AMOUNT"))
                        End If
                    Next

                    txtSurplusMiningAllowance = tmpDec
                Case EnumTypeSubData.TAXABLE_INCOME
                    tmpDec = 0

                    For Each rowx As DataRow In dsAdjustIncome.Tables("TAXABLE_INCOME").Rows
                        If rowx.RowState <> DataRowState.Deleted AndAlso IsDBNull(rowx("TI_AMOUNT")) = False AndAlso IsNumeric(rowx("TI_AMOUNT")) Then
                            tmpDec += CDec(rowx("TI_AMOUNT"))
                        End If
                    Next

                    txtTaxIn = tmpDec
                Case EnumTypeSubData.MINING_EXPENSES
                    tmpDec = 0

                    For Each rowx As DataRow In dsAdjustIncome.Tables("MINING_EXPENSES").Rows
                        If rowx.RowState <> DataRowState.Deleted AndAlso IsDBNull(rowx("ME_AMOUNT")) = False AndAlso IsNumeric(rowx("ME_AMOUNT")) Then
                            tmpDec += CDec(rowx("ME_AMOUNT"))
                        End If
                    Next

                    txtAddMiningExp = tmpDec
                Case EnumTypeSubData.MINING_ALLOWNANCE
                    tmpDec = 0

                    For Each rowx As DataRow In dsAdjustIncome.Tables("MINING_ALLOWNANCE").Rows
                        If rowx.RowState <> DataRowState.Deleted AndAlso IsDBNull(rowx("MA_AMOUNT")) = False AndAlso IsNumeric(rowx("MA_AMOUNT")) Then
                            tmpDec += CDec(rowx("MA_AMOUNT"))
                        End If
                    Next

                    txtMiningAllowing = tmpDec
                Case EnumTypeSubData.REVENUE_EXPENDITURE
                    tmpDec = 0

                    For Each rowx As DataRow In dsAdjustIncome.Tables("REVENUE_EXPENDITURE").Rows
                        If rowx.RowState <> DataRowState.Deleted AndAlso IsDBNull(rowx("RE_AMOUNT")) = False AndAlso IsNumeric(rowx("RE_AMOUNT")) Then
                            tmpDec += CDec(rowx("RE_AMOUNT"))
                        End If
                    Next

                    txtRevenueExp = tmpDec
                Case EnumTypeSubData.OTHER_DEDUCTION
                    tmpDec = 0

                    For Each rowx As DataRow In dsAdjustIncome.Tables("OTHER_DEDUCTION").Rows
                        If rowx.RowState <> DataRowState.Deleted AndAlso IsDBNull(rowx("OD_AMOUNT")) = False AndAlso IsNumeric(rowx("OD_AMOUNT")) Then
                            tmpDec += CDec(rowx("OD_AMOUNT"))
                        End If
                    Next

                    txtOtherDeduc = tmpDec
                Case EnumTypeSubData.OTHER_EXPENDITURE
                    tmpDec = 0

                    For Each rowx As DataRow In dsAdjustIncome.Tables("OTHER_EXPENDITURE").Rows
                        If rowx.RowState <> DataRowState.Deleted AndAlso IsDBNull(rowx("OE_AMOUNT")) = False AndAlso IsNumeric(rowx("OE_AMOUNT")) Then
                            tmpDec += CDec(rowx("OE_AMOUNT"))
                        End If
                    Next

                    txtOthExp = tmpDec
            End Select

            RaiseEvent OnChangeStep2(txtNALoss, txtSurplusMiningAllowance, txtTaxIn, txtAddMiningExp, txtMiningAllowing, txtRevenueExp, txtOtherDeduc, txtOthExp)
            Application.DoEvents()
            CalcAdjustedIncome()
            ChangeStatus(EnumStatus.Done, EnumStage.Calculating)
        Catch ex As Exception
            ChangeStatus(EnumStatus.Failed, EnumStage.Calculating)
        End Try
    End Sub
    Public Sub ChangeStatus(ByVal Status_ As EnumStatus, ByVal Stage_ As EnumStage)
        Try
            Status = Status_
            RaiseEvent OnChangeStatus(Status_, Stage_, ErrorLog)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Load_SubItem_Data()
        Try
          
            ' dsAdjustIncome.Tables("NON_ALLOW_LOSS").Rows.Clear()
            Dim dt As DataTable = Nothing
            Dim dtRow As DataRow = Nothing
            dt = NON_ALLOW_LOSS(ErrorLog)

            If dt IsNot Nothing Then
                For Each rowx As DataRow In dt.Rows
                    dtRow = Nothing
                    dtRow = dsAdjustIncome.Tables("NON_ALLOW_LOSS").NewRow
                    dtRow("NL_REF_NO") = RefNo
                    dtRow("NL_YA") = YA
                    dtRow("NL_DESC") = IIf(IsDBNull(rowx("NL_DESC")), "", rowx("NL_DESC"))
                    If IsDBNull(rowx("NL_AMOUNT")) = False AndAlso IsNumeric(rowx("NL_AMOUNT")) Then
                        dtRow("NL_AMOUNT") = CDec(rowx("NL_AMOUNT"))
                    Else
                        dtRow("NL_AMOUNT") = 0
                    End If
                    dtRow("NL_CATEGORIZED") = ""
                    dtRow("NL_SOURCENO") = SourceNo
                    dsAdjustIncome.Tables("NON_ALLOW_LOSS").Rows.Add(dtRow)
                Next
            End If

            dt = Nothing
            dt = OTHER_EXURLOSSFOREIGN(PL_KEY, ErrorLog)

            If dt IsNot Nothing Then
                For Each rowx As DataRow In dt.Rows
                    dtRow = Nothing
                    dtRow = dsAdjustIncome.Tables("NON_ALLOW_LOSS").NewRow
                    dtRow("NL_REF_NO") = RefNo
                    dtRow("NL_YA") = YA
                    dtRow("NL_DESC") = "Unrealised Loss on Foreign Exchange"
                    If IsDBNull(rowx("EXOUR_AMOUNT")) = False AndAlso IsNumeric(rowx("EXOUR_AMOUNT")) Then
                        dtRow("NL_AMOUNT") = CDec(rowx("EXOUR_AMOUNT"))
                    Else
                        dtRow("NL_AMOUNT") = 0
                    End If
                    dtRow("NL_CATEGORIZED") = "PNL"
                    dtRow("NL_SOURCENO") = SourceNo
                    dsAdjustIncome.Tables("NON_ALLOW_LOSS").Rows.Add(dtRow)
                Next
            End If

            dt = Nothing
            dt = OTHER_EXRLOSSFOREIGN(PL_KEY, ErrorLog)

            If dt IsNot Nothing Then
                For Each rowx As DataRow In dt.Rows
                    dtRow = Nothing
                    dtRow = dsAdjustIncome.Tables("NON_ALLOW_LOSS").NewRow
                    dtRow("NL_REF_NO") = RefNo
                    dtRow("NL_YA") = YA
                    dtRow("NL_DESC") = "Realised Loss on Foreign Exchange - Non-Trade"
                    If IsDBNull(rowx("EXOR_AMOUNT")) = False AndAlso IsNumeric(rowx("EXOR_AMOUNT")) Then
                        dtRow("NL_AMOUNT") = CDec(rowx("EXOR_AMOUNT"))
                    Else
                        dtRow("NL_AMOUNT") = 0
                    End If
                    dtRow("NL_CATEGORIZED") = "PNL"
                    dtRow("NL_SOURCENO") = SourceNo
                    dsAdjustIncome.Tables("NON_ALLOW_LOSS").Rows.Add(dtRow)
                Next
            End If

            dt = Nothing
            dt = OTHER_EXLOSSDISPOSALFA(PL_KEY, ErrorLog)

            If dt IsNot Nothing Then
                For Each rowx As DataRow In dt.Rows
                    dtRow = Nothing
                    dtRow = dsAdjustIncome.Tables("NON_ALLOW_LOSS").NewRow
                    dtRow("NL_REF_NO") = RefNo
                    dtRow("NL_YA") = YA
                    dtRow("NL_DESC") = "Loss on Disposal of Fixed Assets"
                    If IsDBNull(rowx("EXOLD_AMOUNT")) = False AndAlso IsNumeric(rowx("EXOLD_AMOUNT")) Then
                        dtRow("NL_AMOUNT") = CDec(rowx("EXOLD_AMOUNT"))
                    Else
                        dtRow("NL_AMOUNT") = 0
                    End If
                    dtRow("NL_CATEGORIZED") = "PNL"
                    dtRow("NL_SOURCENO") = SourceNo
                    dsAdjustIncome.Tables("NON_ALLOW_LOSS").Rows.Add(dtRow)
                Next
            End If
            TypeSubData = EnumTypeSubData.NON_ALLOW_LOSS
            CalcTotalSubData()

            dt = Nothing
            dt = SURPLUS_RECOVERED()
            If dt IsNot Nothing Then
                For Each rowx As DataRow In dt.Rows
                    dtRow = Nothing
                    dtRow = dsAdjustIncome.Tables("SURPLUS_RECOVERED").NewRow
                    dtRow("SR_REF_NO") = IIf(IsDBNull(rowx("SR_REF_NO")), "", rowx("SR_REF_NO"))
                    dtRow("SR_YA") = IIf(IsDBNull(rowx("SR_YA")), "", rowx("SR_YA"))
                    dtRow("SR_DESC") = IIf(IsDBNull(rowx("SR_DESC")), "", rowx("SR_DESC"))
                    dtRow("SR_AMOUNT") = IIf(IsDBNull(rowx("SR_AMOUNT")), 0, rowx("SR_AMOUNT"))
                    dtRow("SR_SOURCENO") = IIf(IsDBNull(rowx("SR_SOURCENO")), 0, rowx("SR_SOURCENO"))
                    dsAdjustIncome.Tables("SURPLUS_RECOVERED").Rows.Add(dtRow)
                Next
            End If
            TypeSubData = EnumTypeSubData.SURPLUS_MINING_ALLOW
            CalcTotalSubData()

            dt = Nothing
            dt = TAXABLE_INCOME()
            If dt IsNot Nothing Then
                For Each rowx As DataRow In dt.Rows
                    dtRow = Nothing
                    dtRow = dsAdjustIncome.Tables("TAXABLE_INCOME").NewRow
                    dtRow("TI_REF_NO") = IIf(IsDBNull(rowx("TI_REF_NO")), "", rowx("TI_REF_NO"))
                    dtRow("TI_YA") = IIf(IsDBNull(rowx("TI_YA")), "", rowx("TI_YA"))
                    dtRow("TI_DESC") = IIf(IsDBNull(rowx("TI_DESC")), "", rowx("TI_DESC"))
                    dtRow("TI_AMOUNT") = IIf(IsDBNull(rowx("TI_AMOUNT")), 0, rowx("TI_AMOUNT"))
                    dtRow("TI_SOURCENO") = IIf(IsDBNull(rowx("TI_SOURCENO")), 0, rowx("TI_SOURCENO"))
                    dtRow("TI_TYPE") = IIf(IsDBNull(rowx("TI_TYPE")), -1, rowx("TI_TYPE"))
                    dtRow("TI_REFID") = ""
                    dsAdjustIncome.Tables("TAXABLE_INCOME").Rows.Add(dtRow)
                Next
            End If
          
            dt = Nothing
            dt = MOVEMENT_NORMAL(2)
            If dt IsNot Nothing Then
                For Each rowx As DataRow In dt.Rows
                    dtRow = Nothing
                    dtRow = dsAdjustIncome.Tables("TAXABLE_INCOME").NewRow
                    dtRow("TI_REF_NO") = IIf(IsDBNull(rowx("MM_REFNO")), "", rowx("MM_REFNO"))
                    dtRow("TI_YA") = IIf(IsDBNull(rowx("MM_YA")), "", rowx("MM_YA"))
                    dtRow("TI_DESC") = IIf(IsDBNull(rowx("MM_TITLE")), "", rowx("MM_TITLE"))
                    dtRow("TI_AMOUNT") = IIf(IsDBNull(rowx("MM_ADD_DEDUCT_AMOUNT")), 0, rowx("MM_ADD_DEDUCT_AMOUNT"))
                    dtRow("TI_SOURCENO") = IIf(IsDBNull(rowx("MM_SOURCENO")), 0, rowx("MM_SOURCENO"))
                    dtRow("TI_TYPE") = IIf(IsDBNull(rowx("MM_ID")), -1, rowx("MM_ID"))
                    dtRow("TI_REFID") = IIf(IsDBNull(rowx("MM_REFID")), "", rowx("MM_REFID"))
                    dsAdjustIncome.Tables("TAXABLE_INCOME").Rows.Add(dtRow)
                Next
            End If

            dt = Nothing
            dt = MOVEMENT_COMPLEX(2)
            If dt IsNot Nothing Then
                For Each rowx As DataRow In dt.Rows
                    dtRow = Nothing
                    dtRow = dsAdjustIncome.Tables("TAXABLE_INCOME").NewRow
                    dtRow("TI_REF_NO") = IIf(IsDBNull(rowx("MM_REFNO")), "", rowx("MM_REFNO"))
                    dtRow("TI_YA") = IIf(IsDBNull(rowx("MM_YA")), "", rowx("MM_YA"))
                    dtRow("TI_DESC") = IIf(IsDBNull(rowx("MM_TITLE")), "", rowx("MM_TITLE"))
                    dtRow("TI_AMOUNT") = IIf(IsDBNull(rowx("MM_ADD_DEDUCT_AMOUNT")), 0, rowx("MM_ADD_DEDUCT_AMOUNT"))
                    dtRow("TI_SOURCENO") = IIf(IsDBNull(rowx("MM_SOURCENO")), 0, rowx("MM_SOURCENO"))
                    dtRow("TI_TYPE") = IIf(IsDBNull(rowx("MM_ID")), -1, rowx("MM_ID"))
                    dtRow("TI_REFID") = IIf(IsDBNull(rowx("MM_REFID")), "", rowx("MM_REFID"))
                    dsAdjustIncome.Tables("TAXABLE_INCOME").Rows.Add(dtRow)
                Next
            End If
            TypeSubData = EnumTypeSubData.TAXABLE_INCOME
            CalcTotalSubData()

            dt = Nothing
            dt = MINING_ALLOWNANCE()
            If dt IsNot Nothing Then
                For Each rowx As DataRow In dt.Rows
                    dtRow = Nothing
                    dtRow = dsAdjustIncome.Tables("MINING_ALLOWNANCE").NewRow
                    dtRow("MA_REF_NO") = IIf(IsDBNull(rowx("MA_REF_NO")), "", rowx("MA_REF_NO"))
                    dtRow("MA_YA") = IIf(IsDBNull(rowx("MA_YA")), "", rowx("MA_YA"))
                    dtRow("MA_DESC") = IIf(IsDBNull(rowx("MA_DESC")), "", rowx("MA_DESC"))
                    dtRow("MA_AMOUNT") = IIf(IsDBNull(rowx("MA_AMOUNT")), 0, rowx("MA_AMOUNT"))
                    dtRow("MA_SOURCENO") = IIf(IsDBNull(rowx("MA_SOURCENO")), 0, rowx("MA_SOURCENO"))
                    dsAdjustIncome.Tables("MINING_ALLOWNANCE").Rows.Add(dtRow)
                Next
            End If
            TypeSubData = EnumTypeSubData.MINING_ALLOWNANCE
            CalcTotalSubData()

            dt = Nothing
            dt = MINING_EXPENSES()
            If dt IsNot Nothing Then
                For Each rowx As DataRow In dt.Rows
                    dtRow = Nothing
                    dtRow = dsAdjustIncome.Tables("MINING_EXPENSES").NewRow
                    dtRow("ME_REF_NO") = IIf(IsDBNull(rowx("ME_REF_NO")), "", rowx("ME_REF_NO"))
                    dtRow("ME_YA") = IIf(IsDBNull(rowx("ME_YA")), "", rowx("ME_YA"))
                    dtRow("ME_DESC") = IIf(IsDBNull(rowx("ME_DESC")), "", rowx("ME_DESC"))
                    dtRow("ME_AMOUNT") = IIf(IsDBNull(rowx("ME_AMOUNT")), 0, rowx("ME_AMOUNT"))
                    dtRow("ME_SOURCENO") = IIf(IsDBNull(rowx("ME_SOURCENO")), 0, rowx("ME_SOURCENO"))
                    dsAdjustIncome.Tables("MINING_EXPENSES").Rows.Add(dtRow)
                Next
            End If
            TypeSubData = EnumTypeSubData.MINING_EXPENSES
            CalcTotalSubData()

            dt = Nothing
            dt = REVENUE_EXPENDITURE()
            If dt IsNot Nothing Then
                For Each rowx As DataRow In dt.Rows
                    dtRow = Nothing
                    dtRow = dsAdjustIncome.Tables("REVENUE_EXPENDITURE").NewRow
                    dtRow("RE_REF_NO") = IIf(IsDBNull(rowx("RE_REF_NO")), "", rowx("RE_REF_NO"))
                    dtRow("RE_YA") = IIf(IsDBNull(rowx("RE_YA")), "", rowx("RE_YA"))
                    dtRow("RE_DESC") = IIf(IsDBNull(rowx("RE_DESC")), "", rowx("RE_DESC"))
                    dtRow("RE_AMOUNT") = IIf(IsDBNull(rowx("RE_AMOUNT")), 0, rowx("RE_AMOUNT"))
                    dtRow("RE_SOURCENO") = IIf(IsDBNull(rowx("RE_SOURCENO")), 0, rowx("RE_SOURCENO"))
                    dtRow("RE_TYPE") = IIf(IsDBNull(rowx("RE_TYPE")), -1, rowx("RE_TYPE"))
                    dsAdjustIncome.Tables("REVENUE_EXPENDITURE").Rows.Add(dtRow)
                Next
            End If

            dt = Nothing
            dt = MOVEMENT_NORMAL(3)
            If dt IsNot Nothing Then
                For Each rowx As DataRow In dt.Rows
                    dtRow = Nothing
                    dtRow = dsAdjustIncome.Tables("REVENUE_EXPENDITURE").NewRow
                    dtRow("RE_REF_NO") = IIf(IsDBNull(rowx("MM_REFNO")), "", rowx("MM_REFNO"))
                    dtRow("RE_YA") = IIf(IsDBNull(rowx("MM_YA")), "", rowx("MM_YA"))
                    dtRow("RE_DESC") = IIf(IsDBNull(rowx("MM_TITLE")), "", rowx("MM_TITLE"))
                    dtRow("RE_AMOUNT") = IIf(IsDBNull(rowx("MM_ADD_DEDUCT_AMOUNT")), 0, rowx("MM_ADD_DEDUCT_AMOUNT"))
                    dtRow("RE_SOURCENO") = IIf(IsDBNull(rowx("MM_SOURCENO")), 0, rowx("MM_SOURCENO"))
                    dtRow("RE_TYPE") = IIf(IsDBNull(rowx("MM_TYPE_PASS")), -1, rowx("MM_TYPE_PASS"))
                    dtRow("RE_REFID") = IIf(IsDBNull(rowx("MM_REFID")), "", rowx("MM_REFID"))
                    dsAdjustIncome.Tables("REVENUE_EXPENDITURE").Rows.Add(dtRow)
                Next
            End If

            dt = Nothing
            dt = MOVEMENT_COMPLEX(3)
            If dt IsNot Nothing Then
                For Each rowx As DataRow In dt.Rows
                    dtRow = Nothing
                    dtRow = dsAdjustIncome.Tables("REVENUE_EXPENDITURE").NewRow
                    dtRow("RE_REF_NO") = IIf(IsDBNull(rowx("MM_REFNO")), "", rowx("MM_REFNO"))
                    dtRow("RE_YA") = IIf(IsDBNull(rowx("MM_YA")), "", rowx("MM_YA"))
                    dtRow("RE_DESC") = IIf(IsDBNull(rowx("MM_TITLE")), "", rowx("MM_TITLE"))
                    dtRow("RE_AMOUNT") = IIf(IsDBNull(rowx("MM_ADD_DEDUCT_AMOUNT")), 0, rowx("MM_ADD_DEDUCT_AMOUNT"))
                    dtRow("RE_SOURCENO") = IIf(IsDBNull(rowx("MM_SOURCENO")), 0, rowx("MM_SOURCENO"))
                    dtRow("RE_TYPE") = IIf(IsDBNull(rowx("MM_TYPE_PASS")), -1, rowx("MM_TYPE_PASS"))
                    dtRow("RE_REFID") = IIf(IsDBNull(rowx("MM_REFID")), "", rowx("MM_REFID"))
                    dsAdjustIncome.Tables("REVENUE_EXPENDITURE").Rows.Add(dtRow)
                Next
            End If
            TypeSubData = EnumTypeSubData.REVENUE_EXPENDITURE
            CalcTotalSubData()

            dt = Nothing
            dt = OTHER_DEDUCTION()
            If dt IsNot Nothing Then
                For Each rowx As DataRow In dt.Rows
                    dtRow = Nothing
                    dtRow = dsAdjustIncome.Tables("OTHER_DEDUCTION").NewRow
                    dtRow("OD_REF_NO") = IIf(IsDBNull(rowx("OD_REF_NO")), "", rowx("OD_REF_NO"))
                    dtRow("OD_YA") = IIf(IsDBNull(rowx("OD_YA")), "", rowx("OD_YA"))
                    dtRow("OD_DESC") = IIf(IsDBNull(rowx("OD_DESC")), "", rowx("OD_DESC"))
                    dtRow("OD_AMOUNT") = IIf(IsDBNull(rowx("OD_AMOUNT")), 0, rowx("OD_AMOUNT"))
                    dtRow("OD_SOURCENO") = IIf(IsDBNull(rowx("OD_SOURCENO")), 0, rowx("OD_SOURCENO"))
                    dsAdjustIncome.Tables("OTHER_DEDUCTION").Rows.Add(dtRow)
                Next
            End If
            TypeSubData = EnumTypeSubData.OTHER_DEDUCTION
            CalcTotalSubData()


            dt = Nothing
            dt = OTHER_EXPENDITURE()
            If dt IsNot Nothing Then
                For Each rowx As DataRow In dt.Rows
                    dtRow = Nothing
                    dtRow = dsAdjustIncome.Tables("OTHER_EXPENDITURE").NewRow
                    dtRow("OE_REF_NO") = IIf(IsDBNull(rowx("OE_REF_NO")), "", rowx("OE_REF_NO"))
                    dtRow("OE_YA") = IIf(IsDBNull(rowx("OE_YA")), "", rowx("OE_YA"))
                    dtRow("OE_CLAIMCODE") = IIf(IsDBNull(rowx("OE_CLAIMCODE")), "", rowx("OE_CLAIMCODE"))
                    dtRow("OE_AMOUNT") = IIf(IsDBNull(rowx("OE_AMOUNT")), 0, rowx("OE_AMOUNT"))
                    dtRow("OE_SOURCENO") = IIf(IsDBNull(rowx("OE_SOURCENO")), 0, rowx("OE_SOURCENO"))
                    dtRow("OE_COMPANY") = IIf(IsDBNull(rowx("OE_COMPANY")), "C", rowx("OE_COMPANY"))
                    dsAdjustIncome.Tables("OTHER_EXPENDITURE").Rows.Add(dtRow)
                Next
            End If
            TypeSubData = EnumTypeSubData.OTHER_EXPENDITURE
            CalcTotalSubData()

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
#Region "DATABASE"
#Region "LOAD SUB DATA"
    Private Function NON_ALLOW_LOSS(Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM NON_ALLOW_LOSS WHERE NL_REF_NO = '" & RefNo & "' AND NL_YA= '" & YA & "' AND NL_SOURCENO=" & SourceNo
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

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
    Private Function OTHER_EXURLOSSFOREIGN(ByVal PL_KEY As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_EXURLOSSFOREIGN WHERE EXOUR_KEY = " & PL_KEY & " AND EXOUR_SOURCENO=" & SourceNo
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

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
    Private Function OTHER_EXRLOSSFOREIGN(ByVal PL_KEY As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_EXRLOSSFOREIGN WHERE EXOR_KEY = " & PL_KEY & " AND EXOR_SOURCENO=" & SourceNo
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

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
    Private Function OTHER_EXLOSSDISPOSALFA(ByVal PL_KEY As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_EXLOSSDISPOSALFA WHERE EXOLD_KEY = " & PL_KEY & " AND EXOLD_SOURCENO=" & SourceNo
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

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
    Private Function SURPLUS_RECOVERED(Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM SURPLUS_RECOVERED WHERE SR_REF_NO = '" & RefNo & "' AND SR_YA = '" & YA & "' AND SR_SOURCENO=" & SourceNo
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

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
    Private Function TAXABLE_INCOME(Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM TAXABLE_INCOME WHERE TI_REF_NO = '" & RefNo & "' AND TI_YA = '" & YA & "' AND TI_SOURCENO=" & SourceNo & " AND TI_TYPE = -1 ORDER BY TI_KEY"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

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
    Private Function MINING_ALLOWNANCE(Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM MINING_ALLOWNANCE WHERE MA_REF_NO = '" & RefNo & "' AND MA_YA = '" & YA & "' AND MA_SOURCENO=" & SourceNo & " ORDER BY MA_KEY"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

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
    Private Function MINING_EXPENSES(Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM MINING_EXPENSES WHERE ME_REF_NO = '" & RefNo & "' AND ME_YA = '" & YA & "' AND ME_SOURCENO=" & SourceNo & " ORDER BY ME_KEY"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

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
    Private Function REVENUE_EXPENDITURE(Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM REVENUE_EXPENDITURE WHERE RE_REF_NO = '" & RefNo & "' AND RE_YA = '" & YA & "' AND RE_SOURCENO=" & SourceNo & " AND (RE_TYPE = -1 OR RE_TYPE = 0) ORDER BY RE_KEY"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

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
    Private Function OTHER_DEDUCTION(Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_DEDUCTION WHERE OD_REF_NO = '" & RefNo & "' AND OD_YA = '" & YA & "' AND OD_SOURCENO=" & SourceNo & " ORDER BY OD_KEY"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

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
    Private Function OTHER_EXPENDITURE(Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_EXPENDITURE WHERE OE_REF_NO = '" & RefNo & "' AND OE_YA = '" & YA & "' AND OE_SOURCENO=" & SourceNo & " ORDER BY OE_KEY"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

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
    Private Function MOVEMENT_NORMAL(ByVal Type As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM MOVEMENT_NORMAL WHERE MM_REFNO = '" & RefNo & "' AND MM_YA = '" & YA & "' AND MM_SOURCENO=" & SourceNo & " AND MM_REFID <> '' AND MM_TYPE_PASS=" & Type
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

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
    Private Function MOVEMENT_COMPLEX(ByVal Type As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM MOVEMENT_COMPLEX WHERE MM_REFNO = '" & RefNo & "' AND MM_YA = '" & YA & "' AND MM_SOURCENO=" & SourceNo & " AND MM_REFID <> '' AND MM_TYPE_PASS=" & Type
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

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
#End Region
    Private Function MOVEMENT_NORMAL_NON_ALLOWABLE_EXPENSES(ByVal MM_REFNO As String, ByVal MM_YA As String, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM MOVEMENT_NORMAL WHERE MM_REFNO = '" & MM_REFNO & "' AND MM_YA='" & MM_YA & "' AND MM_TYPE_PASS=1"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

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
    Private Function MOVEMENT_COMPLEX_NON_ALLOWABLE_EXPENSES(ByVal MM_REFNO As String, ByVal MM_YA As String, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM MOVEMENT_COMPLEX WHERE MM_REFNO = '" & MM_REFNO & "' AND MM_YA='" & MM_YA & "' AND MM_TYPE_PASS=1"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

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
    Private Function DIVIDEND_INCOME(ByVal PL_KEY As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM DIVIDEND_INCOME WHERE DI_KEY = " & PL_KEY & " AND DI_SOURCENO=" & SourceNo
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

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
    Private Function NON_TAXABLE_INCOME(Optional ByRef ErrorLog As ClsError = Nothing) As Decimal
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT SUM(NT_AMOUNT) AS SUMX FROM NON_TAXABLE_INCOME WHERE NT_REF_NO = '" & RefNo & "' AND NT_YA='" & YA & "' AND NT_SOURCENO=" & SourceNo & " AND NT_CATEGORIZED <> 'Other'"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

            Dim dt As DataTable = Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("SUMX")) = False AndAlso IsNumeric(dt.Rows(0)("SUMX")) Then
                Return CDec(dt.Rows(0)("SUMX"))
            Else
                Return 0
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
    Private Function EXEMPT_DIVIDEND(ByVal PL_KEY As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As Decimal
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT SUM(ED_AMOUNT) AS SUMX FROM EXEMPT_DIVIDEND WHERE ED_KEY = " & PL_KEY & " AND ED_SOURCENO=" & SourceNo
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

            Dim dt As DataTable = Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("SUMX")) = False AndAlso IsNumeric(dt.Rows(0)("SUMX")) Then
                Return CDec(dt.Rows(0)("SUMX"))
            Else
                Return 0
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
    Private Function INCOME_REALFET(ByVal PL_KEY As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As Decimal
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT SUM(IRFET_AMOUNT) AS SUMX FROM INCOME_REALFET WHERE IRFET_KEY = " & PL_KEY & " AND IRFET_SOURCENO=" & SourceNo
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

            Dim dt As DataTable = Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("SUMX")) = False AndAlso IsNumeric(dt.Rows(0)("SUMX")) Then
                Return CDec(dt.Rows(0)("SUMX"))
            Else
                Return 0
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
    Private Function OTHER_BUSINESS_INCOME(ByVal PL_KEY As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As Decimal
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT SUM(OBI_GROSS_INCOME) AS SUMX FROM OTHER_BUSINESS_INCOME WHERE OBI_KEY = " & PL_KEY & " AND OBI_SOURCENO=" & SourceNo
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

            Dim dt As DataTable = Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("SUMX")) = False AndAlso IsNumeric(dt.Rows(0)("SUMX")) Then
                Return CDec(dt.Rows(0)("SUMX"))
            Else
                Return 0
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
    Private Function EXPENSES_INTERESTRESTRICT(ByVal PL_KEY As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As Decimal
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT SUM(EXIR_AMOUNT) AS SUMX FROM EXPENSES_INTERESTRESTRICT WHERE EXIR_KEY= " & PL_KEY & " AND EXIR_SOURCENO=" & SourceNo
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

            Dim dt As DataTable = Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("SUMX")) = False AndAlso IsNumeric(dt.Rows(0)("SUMX")) Then
                Return CDec(dt.Rows(0)("SUMX"))
            Else
                Return 0
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
    Private Function NON_ALLOW_LOSS() As Decimal
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT SUM(NL_AMOUNT) AS SUMX FROM NON_ALLOW_LOSS WHERE NL_REF_NO= '" & RefNo & "' AND NL_YA = '" & YA & "' AND NL_SOURCENO =" & SourceNo & " AND NL_CATEGORIZED = ''"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

            Dim dt As DataTable = Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("SUMX")) = False AndAlso IsNumeric(dt.Rows(0)("SUMX")) Then
                Return CDec(dt.Rows(0)("SUMX"))
            Else
                Return 0
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
    Private Function Load_CLAIM_CODE() As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CLAIM ORDER BY CL_DESC"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

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
    Private Function Load_PNLItem(ByVal TableName As String, ByVal Column_PL_KEY As String, ByVal Column_SourceNo As String, ByVal Column_Amount As String, _
                                   Optional ByRef ErrorLog As ClsError = Nothing) As Decimal
        Try


            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT SUM(" & Column_Amount & ") AS SUMX FROM " & TableName & " WHERE " & Column_PL_KEY & "=" & PL_KEY & " AND " & Column_SourceNo & "=" & SourceNo
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

            Dim dt As DataTable = Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("SUMX")) = False AndAlso IsNumeric(dt.Rows(0)("SUMX")) Then
                Return CDec(dt.Rows(0)("SUMX"))
            Else
                Return 0
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
    Private Function Load_PNLItemData(ByVal TableName As String, ByVal Column_PL_KEY As String, ByVal Column_Amount As String, _
                                   Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try


            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM " & TableName & " WHERE " & Column_PL_KEY & "=" & PL_KEY
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

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
    Private Function Load_PNLItem_NonAllowable(ByVal TableName As String, ByVal Column_PL_KEY As String, ByVal Column_SourceNo As String,
                                               ByVal Column_Amount As String, ByVal Column_Deductible As String, _
                                               Optional ByRef ErrorLog As ClsError = Nothing) As Decimal
        Try


            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT SUM(PecentageAmount) AS SUMX FROM " & TableName & " WHERE " & Column_PL_KEY & "=" & PL_KEY & " AND " & Column_SourceNo & "=" & SourceNo & " AND (" & Column_Deductible & "= 'Yes' OR " & Column_Deductible & "= 'True' OR " & Column_Deductible & "= '1')"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

            Dim dt As DataTable = Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("SUMX")) = False AndAlso IsNumeric(dt.Rows(0)("SUMX")) Then
                Return CDec(dt.Rows(0)("SUMX"))
            Else
                Return 0
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
    Private Function Load_PNLItem_NonAllowableData(ByVal TableName As String, ByVal Column_PL_KEY As String,
                                              ByVal Column_Amount As String, ByVal Column_Deductible As String, _
                                              Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try


            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM " & TableName & " WHERE " & Column_PL_KEY & "=" & PL_KEY & " AND (" & Column_Deductible & "= 'Yes' OR " & Column_Deductible & "= 'True' OR " & Column_Deductible & "= '1')"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

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
#Region "SAVE"
   
#End Region
#End Region

    Private Sub TaxCom_OnChangeStatus(Status_ As TaxComputation.EnumStatus, Stage_ As EnumStage, ErrorLog_ As ClsError) Handles TaxCom.OnChangeStatus
        Try
            ErrorLog = ErrorLog_
            Me.ChangeStatus(Status_, Stage_)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TaxCom_OnChangeStatutoryIncome(row_ As DataRow) Handles TaxCom.OnChangeStatutoryIncome
        Try
            RaiseEvent OnChangeStatutoryIncome(row_)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TaxCom_OnLoadTaxcom(dt_ As DataTable, dtTaxpayer_ As DataTable) Handles TaxCom.OnLoadTaxcom
        Try
            RaiseEvent OnLoadTaxcom(dt_, dtTaxpayer_)
        Catch ex As Exception

        End Try
    End Sub
End Class