﻿Imports System.Data.SqlClient
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Export

Public Class frmPNL
    Public isEdit As Boolean = True
    Public ID As Decimal = 1267
    Dim ErrorLog As clsError = Nothing
    Dim isReplacePNL As Boolean = False
    Dim ListofCmd As List(Of SqlCommand)
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        If dsDataSet Is Nothing Then
            dsDataSet = New dsPNL
        End If
        If dsDataSet2 Is Nothing Then
            dsDataSet2 = New dsPNL2
        End If

        txtPCName.Caption = My.Computer.Name & " | " & GetServerName() & " | V" & mdlProcess.V1 & "." & mdlProcess.V2 & "." & mdlProcess.V3 & "." & mdlProcess.V4 & " R." & System.Reflection.Assembly.GetExecutingAssembly.GetName.Version.Revision.ToString
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmPNL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Try
            Me.Text = "Profit and Loss - New"
            Application.DoEvents()
            If mdlProcess.CreateLookUpTaxPayer(DsCA, ErrorLog) = False Then
                MsgBox("Failed to load tax payer." & vbCrLf & ErrorLog.ErrorName & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                Me.Close()
            End If
            Application.DoEvents()
            If mdlProcess.CreateLookUpYA(cboYA, ErrorLog) = False Then
                MsgBox("Failed to load ya." & vbCrLf & ErrorLog.ErrorName & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                Me.Close()
            End If
            Application.DoEvents()



            Dim listoflabelname As List(Of clsPNL_LabelName) = mdlPNL.GetPNLLabelName(ErrorLog)

            If listoflabelname Is Nothing Then
                MsgBox("Failed to retrive profit and loss label name." & vbCrLf & ErrorLog.ErrorName & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                Me.Close()
            End If

            Dim controls() As Control
            Dim controls_text() As Control
            Dim tmpControl As DevExpress.XtraEditors.LabelControl
            Dim tmpControl_txt As DevExpress.XtraEditors.TextEdit
            For i As Integer = 0 To listoflabelname.Count - 1


                controls = Me.Controls.Find(listoflabelname(i).LabelName, True)
                If controls.Length > 0 AndAlso TypeOf controls(0) Is DevExpress.XtraEditors.LabelControl Then
                    tmpControl = CType(controls(0), DevExpress.XtraEditors.LabelControl)

                    If mdlProcess.isVersionLicenseType = VersionLicenseType.Normal Then
                        tmpControl.Text = listoflabelname(i).LabelText
                        If listoflabelname(i).LabelText = "" Then
                            tmpControl.Visible = False

                            controls_text = Me.Controls.Find(listoflabelname(i).LabelName.Replace("lbl", "txt"), True)

                            If controls_text.Length > 0 AndAlso TypeOf controls_text(0) Is DevExpress.XtraEditors.TextEdit Then
                                tmpControl_txt = CType(controls_text(0), DevExpress.XtraEditors.TextEdit)
                                tmpControl_txt.Visible = False
                            End If
                        Else
                            tmpControl.Visible = True
                        End If
                    Else
                        tmpControl.Text = listoflabelname(i).LabelTricor
                        If listoflabelname(i).LabelTricor = "" Then
                            tmpControl.Visible = False

                            controls_text = Me.Controls.Find(listoflabelname(i).LabelName.Replace("lbl", "txt"), True)

                            If controls_text.Length > 0 AndAlso TypeOf controls_text(0) Is DevExpress.XtraEditors.TextEdit Then
                                tmpControl_txt = CType(controls_text(0), DevExpress.XtraEditors.TextEdit)
                                tmpControl_txt.Visible = False
                            End If
                        Else
                            tmpControl.Visible = True
                        End If
                    End If

                    tmpControl.Tag = listoflabelname(i).Type.ToString


                End If
            Next
            If isEdit = False Then
                cboS60FA.EditValue = "No"

                cboRefNo.EditValue = mdlProcess.ArgParam2
                cboYA.EditValue = mdlProcess.ArgParam3

                cboRefNo.Edit.ReadOnly = True
                cboYA.Edit.ReadOnly = True
                cboMainSource.Edit.ReadOnly = True

            Else
                Dim dtPNL As DataTable = mdlProcess.Load_PNL_ByKey(ID)

                If dtPNL Is Nothing Then
                    cboRefNo.Enabled = True
                    cboYA.Enabled = True
                    cboMainSource.Enabled = True
                    isEdit = False
                    cboRefNo.EditValue = mdlProcess.ArgParam2
                    cboYA.EditValue = mdlProcess.ArgParam3
                    Exit Sub
                Else
                    cboRefNo.Enabled = False
                    cboYA.Enabled = False
                    cboMainSource.Enabled = False
                End If
                Me.Text = "Profit and Loss - Edit"
                Application.DoEvents()

                cboRefNo.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_REF_NO")), "", dtPNL.Rows(0)("PL_REF_NO"))
                cboYA.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_YA")), "", dtPNL.Rows(0)("PL_YA"))
                cboMainSource.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_MAINBUZ")), 1, dtPNL.Rows(0)("PL_MAINBUZ"))

                If IsDBNull(dtPNL.Rows(0)("PL_S60F")) = False AndAlso dtPNL.Rows(0)("PL_S60F") = "Y" Then
                    cboS60F.EditValue = "Yes"
                Else
                    cboS60F.EditValue = "No"
                End If
                If IsDBNull(dtPNL.Rows(0)("PL_S60FA")) = False AndAlso dtPNL.Rows(0)("PL_S60FA") = "Y" Then
                    cboS60FA.EditValue = "Yes"
                Else
                    cboS60FA.EditValue = "No"
                End If

                txtLastModified.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("ModifiedBy")), "", dtPNL.Rows(0)("ModifiedBy")) & " | " & IIf(IsDBNull(dtPNL.Rows(0)("ModifiedDateTime")), "", dtPNL.Rows(0)("ModifiedDateTime"))
                cboPNLStatus.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PNL_STATUS")), "", dtPNL.Rows(0)("PNL_STATUS"))

                '==================================================================================================

                txt_p1Sales.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_SALES")), 0, dtPNL.Rows(0)("PL_SALES"))
                txt_p1OpenStock.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OP_STK")), 0, dtPNL.Rows(0)("PL_OP_STK"))
                txt_p1Purchase.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_PURCHASES")), 0, dtPNL.Rows(0)("PL_PURCHASES"))
                txt_p1COP.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_PRO_COST")), 0, dtPNL.Rows(0)("PL_PRO_COST")) '///
                txt_p1Depreciation.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_PRO_COST_DPC")), 0, dtPNL.Rows(0)("PL_PRO_COST_DPC"))
                txt_p1AllowanceExpenses.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_PRO_COST_OAE")), 0, dtPNL.Rows(0)("PL_PRO_COST_OAE"))
                txt_p1NonAllowableExpenses.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_PRO_COST_ONAE")), 0, dtPNL.Rows(0)("PL_PRO_COST_ONAE"))
                txt_p1PCP.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_PURCHASES_PRO_COST")), 0, dtPNL.Rows(0)("PL_PURCHASES_PRO_COST")) '///
                txt_p1CloseStock.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_CLS_STK")), 0, dtPNL.Rows(0)("PL_CLS_STK"))
                txt_p1COS.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_COGS")), 0, dtPNL.Rows(0)("PL_COGS"))
                txt_p1GrossProfitLoss.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_GROSS_PROFIT")), 0, dtPNL.Rows(0)("PL_GROSS_PROFIT"))
                txt_p2OtherBizIncome.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTH_BSIN")), 0, dtPNL.Rows(0)("PL_OTH_BSIN"))
                txt_p2UnreaGainForeEx.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTH_BSIN_UNREALGT")), 0, dtPNL.Rows(0)("PL_OTH_BSIN_UNREALGT"))
                txt_p2ForeignCurrExGain.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTH_BSIN_REALGT")), 0, dtPNL.Rows(0)("PL_OTH_BSIN_REALGT"))
                txt_p2NonBizIncome.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTH_IN")), 0, dtPNL.Rows(0)("PL_OTH_IN"))
                txt_p2DivIncome.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTH_IN_DIVIDEND")), 0, dtPNL.Rows(0)("PL_OTH_IN_DIVIDEND"))
                txt_p2InterestIncome.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTH_IN_INTEREST")), 0, dtPNL.Rows(0)("PL_OTH_IN_INTEREST"))
                txt_p2RentalIncome.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTH_IN_RENTAL")), 0, dtPNL.Rows(0)("PL_OTH_IN_RENTAL"))
                txt_p2RoyaltyIncome.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTH_IN_ROYALTY")), 0, dtPNL.Rows(0)("PL_OTH_IN_ROYALTY"))
                txt_p2OtherIncome.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTH_IN_OTHER")), 0, dtPNL.Rows(0)("PL_OTH_IN_OTHER"))
                txt_p2NonTaxProfit.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_NONTAX_IN")), 0, dtPNL.Rows(0)("PL_NONTAX_IN"))
                txt_p2ProDispPlantEq.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_NONTAX_IN_FA_DISP")), 0, dtPNL.Rows(0)("PL_NONTAX_IN_FA_DISP"))
                txt_p2ProDisInvestment.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_NONTAX_IN_INV_DISP")), 0, dtPNL.Rows(0)("PL_NONTAX_IN_INV_DISP"))
                txt_p2ExemptDividend.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_NONTAX_IN_EXM_DIV")), 0, dtPNL.Rows(0)("PL_NONTAX_IN_EXM_DIV"))
                txt_p2ForeIncomeRemmit.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_NONTAX_IN_FIR")), 0, dtPNL.Rows(0)("PL_NONTAX_IN_FIR"))
                txt_p2ReaForeExGainNonTrade.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_NONTAX_IN_REALG")), 0, dtPNL.Rows(0)("PL_NONTAX_IN_REALG"))
                txt_p2UnreaGainForeExNon.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_NONTAX_IN_UNREALG")), 0, dtPNL.Rows(0)("PL_NONTAX_IN_UNREALG"))
                txt_p2Other.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_NONTAX_IN_INSU_COMP")), 0, dtPNL.Rows(0)("PL_NONTAX_IN_INSU_COMP"))
                txt_p3InterestResPurS33.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_EXP_INT")), 0, dtPNL.Rows(0)("PL_EXP_INT")) '///
                txt_p3ProTechManLeganFees.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_LAWYER_COST")), 0, dtPNL.Rows(0)("PL_LAWYER_COST"))
                txt_p3ContractPay.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_CONTRACT_EXP")), 0, dtPNL.Rows(0)("PL_CONTRACT_EXP"))
                txt_p3Salary.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_EXP_SALARY")), 0, dtPNL.Rows(0)("PL_EXP_SALARY"))
                txt_p3Royalty.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_ROYALTY")), 0, dtPNL.Rows(0)("PL_ROYALTY"))
                txt_p3Rental.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_EXP_RENT")), 0, dtPNL.Rows(0)("PL_EXP_RENT"))
                txt_p3RepairMain.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_EXP_MAINTENANCE")), 0, dtPNL.Rows(0)("PL_EXP_MAINTENANCE"))
                txt_p3ResearchDev.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_RND")), 0, dtPNL.Rows(0)("PL_RND"))
                txt_p3PromotionAds.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_ADVERT")), 0, dtPNL.Rows(0)("PL_ADVERT"))
                txt_p3Travelling.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_TRAVEL")), 0, dtPNL.Rows(0)("PL_TRAVEL"))
                txt_p4TotalOtherExpenses.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP")), 0, dtPNL.Rows(0)("PL_OTHER_EXP"))
                txt_p3Depreciation.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_DPC")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_DPC"))
                txt_p3DonationApp.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_DNT_APP")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_DNT_APP"))
                txt_p3DonationNonApp.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_DNT_NAPP")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_DNT_NAPP"))
                txt_p4LossDispFA.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_FA_DISP")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_FA_DISP"))
                txt_p4EntNonStaff.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_ENTM_CLNT")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_ENTM_CLNT"))
                txt_p4EntStaff.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_ENTM_STFF")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_ENTM_STFF"))
                txt_p4Compound.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_PENALTY")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_PENALTY"))
                txt_p4ProvisionAcc.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_PROV_ACC")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_PROV_ACC"))
                txt_p4LeavePass.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_LEAVE")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_LEAVE"))
                txt_p4FAWrittenOff.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_FA_WO")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_FA_WO"))
                txt_p4UnreaLossForeEx.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_UNREALOSS")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_UNREALOSS"))
                txt_p4ReaLossForeExTrade.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_REALOSS")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_REALOSS"))
                txt_p4InitSub.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_INI_SUB")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_INI_SUB"))
                txt_p4CAExpenditure.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_CAP_EXP")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_CAP_EXP"))
                txt_p4Other.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_OTHERS")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_OTHERS"))
                txt_p4TotalExpenses.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_TOT_EXP")), 0, dtPNL.Rows(0)("PL_TOT_EXP"))
                txt_p4NetProfitLoss.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_NET_PROFIT_LOSS")), 0, dtPNL.Rows(0)("PL_NET_PROFIT_LOSS"))
                txt_p4NonAllowableExpenses.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_DISALLOWED_EXP")), 0, dtPNL.Rows(0)("PL_DISALLOWED_EXP"))
                txt_p3InterestResPurS33.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_EXP_INTRESTRICT")), 0, dtPNL.Rows(0)("PL_EXP_INTRESTRICT")) '///
                txt_p2OtherBizIncome.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTH_BSIN_NONSOURCE")), 0, dtPNL.Rows(0)("PL_OTH_BSIN_NONSOURCE"))
                txt_p3Zakat.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_ZAKAT")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_ZAKAT"))
                txt_p3TechPayNonResis.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_TECH_FEE")), 0, dtPNL.Rows(0)("PL_TECH_FEE"))
                txt_p3COEStock.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_EMPL_STOCK")), 0, dtPNL.Rows(0)("PL_EMPL_STOCK"))
                txt_p4OtherBalacingFigure.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_BALANCE")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_BALANCE"))
                txt_p4ReaLossForeExNonTrade.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXRLOSSFOREIGNT")), 0, dtPNL.Rows(0)("PL_OTHER_EXRLOSSFOREIGNT"))
                txt_p3DirectorFee.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_DIRECTORS_FEE")), 0, dtPNL.Rows(0)("PL_DIRECTORS_FEE"))
                txt_p3JKDM.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_JKDM")), 0, dtPNL.Rows(0)("PL_JKDM"))


                Dim listofclsPNLLabel As List(Of clsPNL_LabelName) = GetPNLLabelName()

                If listofclsPNLLabel IsNot Nothing Then
                    For Each tmp As clsPNL_LabelName In listofclsPNLLabel
                        'If mdlProcess.isVersionLicenseType = VersionLicenseType.Tricor Then
                        '    Progress(CurrentProgress, "Getting " & tmp.LabelTricor & " data...")
                        'Else
                        '    Progress(CurrentProgress, "Getting " & tmp.LabelText & " data...")
                        'End If

                        mdlPNL.PNL_GetData(ID, tmp.Type, dsDataSet, dsDataSet2, ErrorLog)
                    Next
                End If




            End If


        Catch ex As Exception

        End Try
    End Sub


    Private Sub DetailsClick(ByVal lbl As DevExpress.XtraEditors.LabelControl, Optional ByVal Type As mdlEnum.TaxComPNLEnuItem = TaxComPNLEnuItem.SALES)
        Try
            Dim doc As New DevExpress.XtraBars.Docking.DockPanel
            Dim txtamount As DevExpress.XtraEditors.TextEdit
            Select Case Type
                Case TaxComPNLEnuItem.SALES
                    txtamount = txt_p1Sales
                Case TaxComPNLEnuItem.OPENSTOCK
                    txtamount = txt_p1OpenStock
                Case TaxComPNLEnuItem.PURCHASE
                    txtamount = txt_p1Purchase
                Case TaxComPNLEnuItem.DEPRECIATION
                    txtamount = txt_p1Depreciation
                Case TaxComPNLEnuItem.OTHERALLOWEXP
                    txtamount = txt_p1AllowanceExpenses
                Case TaxComPNLEnuItem.OTHERNONALLOWEXP
                    txtamount = txt_p1NonAllowableExpenses
                Case TaxComPNLEnuItem.CLOSESTOCK
                    txtamount = txt_p1CloseStock
                Case TaxComPNLEnuItem.OTHERBUSINC
                    txtamount = txt_p2OtherBizIncome
                Case TaxComPNLEnuItem.REALFETRADE
                    txtamount = txt_p2ForeignCurrExGain
                Case TaxComPNLEnuItem.INTERESTINC
                    txtamount = txt_p2InterestIncome
                Case TaxComPNLEnuItem.ROYALTYINC
                    txtamount = txt_p2RoyaltyIncome
                Case TaxComPNLEnuItem.OTHERINC
                    txtamount = txt_p2OtherIncome
                Case TaxComPNLEnuItem.PDFIXASSET
                    txtamount = txt_p2ProDispPlantEq
                Case TaxComPNLEnuItem.PDINVEST
                    txtamount = txt_p2ProDisInvestment
                Case TaxComPNLEnuItem.FORINCREMIT
                    txtamount = txt_p2ForeIncomeRemmit
                Case TaxComPNLEnuItem.REALFE
                    txtamount = txt_p2ReaForeExGainNonTrade
                Case TaxComPNLEnuItem.UNREALFETRADE
                    txtamount = txt_p2UnreaGainForeEx
                Case TaxComPNLEnuItem.UNREALFENONTRADE
                    txtamount = txt_p2UnreaGainForeExNon
                Case TaxComPNLEnuItem.EXPOTHERINTEREST
                    txtamount = txt_p3OtherInterestExHirePur
                Case TaxComPNLEnuItem.EXPLEGAL
                    txtamount = txt_p3ProTechManLeganFees
                Case TaxComPNLEnuItem.EXPTECHNICAL
                    txtamount = txt_p3TechPayNonResis
                Case TaxComPNLEnuItem.EXPCONTRACTPAY
                    txtamount = txt_p3ContractPay
                Case TaxComPNLEnuItem.EXPDIRECTORFEE
                    txtamount = txt_p3DirectorFee
                Case TaxComPNLEnuItem.EXPSALARY
                    txtamount = txt_p3Salary
                Case TaxComPNLEnuItem.EXPEMPLOYEESTOCK
                    txtamount = txt_p3COEStock
                Case TaxComPNLEnuItem.EXPROYALTY
                    txtamount = txt_p3Royalty
                Case TaxComPNLEnuItem.EXPRENTAL
                    txtamount = txt_p3Rental
                Case TaxComPNLEnuItem.EXPREPAIRMAINTENANCE
                    txtamount = txt_p3RepairMain
                Case TaxComPNLEnuItem.EXPRND
                    txtamount = txt_p3ResearchDev
                Case TaxComPNLEnuItem.EXPADVERTISEMENT
                    txtamount = txt_p3PromotionAds
                Case TaxComPNLEnuItem.EXPTRAVEL
                    txtamount = txt_p3Travelling
                Case TaxComPNLEnuItem.EXPJKDM
                    txtamount = txt_p3JKDM
                Case TaxComPNLEnuItem.EXPDEPRECIATION
                    txtamount = txt_p3Depreciation
                Case TaxComPNLEnuItem.EXPDONATIONAPPR
                    txtamount = txt_p3DonationApp
                Case TaxComPNLEnuItem.EXPDONATIONAPPR
                    txtamount = txt_p3DonationApp
                Case TaxComPNLEnuItem.EXPDONATIONNONAPPR
                    txtamount = txt_p3DonationNonApp
                Case TaxComPNLEnuItem.EXPZAKAT
                    txtamount = txt_p3Zakat
                Case TaxComPNLEnuItem.EXPLOSSDISPFA
                    txtamount = txt_p4LossDispFA
                Case TaxComPNLEnuItem.EXPENTERTAINNONSTAFF
                    txtamount = txt_p4EntNonStaff
                Case TaxComPNLEnuItem.EXPENTERTAINSTAFF
                    txtamount = txt_p4EntStaff
                Case TaxComPNLEnuItem.EXPCOMPAUNDPENALTY
                    txtamount = txt_p4Compound
                Case TaxComPNLEnuItem.EXPPROVISION
                    txtamount = txt_p4ProvisionAcc
                Case TaxComPNLEnuItem.EXPLEAVEPASSAGE
                    txtamount = txt_p4LeavePass
                Case TaxComPNLEnuItem.EXPFAWRITTENOFF
                    txtamount = txt_p4FAWrittenOff
                Case TaxComPNLEnuItem.EXPUNREALLOSSFE
                    txtamount = txt_p4UnreaLossForeEx
                Case TaxComPNLEnuItem.EXPREALLOSSFETRADE
                    txtamount = txt_p4ReaLossForeExTrade
                Case TaxComPNLEnuItem.EXPREALLOSSFENONTRADE
                    txtamount = txt_p4ReaLossForeExNonTrade
                Case TaxComPNLEnuItem.EXPINITIALSUBSCRIPT
                    txtamount = txt_p4InitSub
                Case TaxComPNLEnuItem.EXPCAPITALEXPENDITURE
                    txtamount = txt_p4CAExpenditure
                Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
                    txtamount = txt_p4Other
                Case TaxComPNLEnuItem.RENTALINC
                    txtamount = txt_p2InterestIncome
                Case TaxComPNLEnuItem.NONALLOWABLEEXPENSES
                    txtamount = txt_p4NonAllowableExpenses
                Case TaxComPNLEnuItem.OTHERNONTAXINC
                    txtamount = txt_p2Other
                Case TaxComPNLEnuItem.EXEMDIV
                    txtamount = txt_p2ExemptDividend
                Case TaxComPNLEnuItem.INTERESTRESTRICT
                    txtamount = txt_p3InterestResPurS33
                Case TaxComPNLEnuItem.DIVIDENDINC
                    txtamount = txt_p2DivIncome
            End Select

            If cboRefNo Is Nothing OrElse cboYA Is Nothing OrElse cboRefNo.EditValue.ToString = "" OrElse cboYA.EditValue.ToString = "" Then
                MsgBox("Please select tax payer and ya first.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If


            mdlPNL.ViewPNL(Type, Me.DockManager1, Me.DocumentManager1, lbl, txtamount, TabbedView1, cboRefNo.EditValue, cboYA.EditValue, ErrorLog, txt_p1Sales, cboMainSource.EditValue)
            '.View.AddDocument(doc)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblSales_DoubleClick(sender As Object, e As EventArgs) Handles lbl_p1Sales.DoubleClick, lbl_p1OpenStock.DoubleClick, lbl_p1Purchase.DoubleClick, lbl_p1Depreciation.DoubleClick, lbl_p1AllowanceExpenses.DoubleClick, lbl_p1NonAllowableExpenses.DoubleClick, lbl_p1CloseStock.DoubleClick, lbl_p2OtherBizIncome.DoubleClick, lbl_p2ForeignCurrExGain.DoubleClick, lbl_p2InterestIncome.DoubleClick, lbl_p2RoyaltyIncome.DoubleClick, lbl_p2OtherIncome.DoubleClick, lbl_p2ProDispPlantEq.DoubleClick, lbl_p2ProDisInvestment.DoubleClick, lbl_p2ForeIncomeRemmit.DoubleClick, lbl_p2ReaForeExGainNonTrade.DoubleClick, lbl_p2UnreaGainForeEx.DoubleClick, lbl_p2UnreaGainForeExNon.DoubleClick, lbl_p3OtherInterestExHirePur.DoubleClick, lbl_p3ProTechManLeganFees.DoubleClick, lbl_p3TechPayNonResis.DoubleClick, lbl_p3ContractPay.DoubleClick, lbl_p3DirectorFee.DoubleClick, lbl_p3Salary.DoubleClick, lbl_p3COEStock.DoubleClick, lbl_p3Royalty.DoubleClick, lbl_p3Rental.DoubleClick, lbl_p3RepairMain.DoubleClick, lbl_p3ResearchDev.DoubleClick, lbl_p3PromotionAds.DoubleClick, lbl_p3Travelling.DoubleClick, lbl_p3JKDM.DoubleClick, lbl_p3Depreciation.DoubleClick, lbl_p3DonationApp.DoubleClick, lbl_p3DonationNonApp.DoubleClick, lbl_p3Zakat.DoubleClick, lbl_p4LossDispFA.DoubleClick, lbl_p4EntNonStaff.DoubleClick, lbl_p4EntStaff.DoubleClick, lbl_p4Compound.DoubleClick, lbl_p4ProvisionAcc.DoubleClick, lbl_p4LeavePass.DoubleClick, lbl_p4FAWrittenOff.DoubleClick, lbl_p4UnreaLossForeEx.DoubleClick, lbl_p4ReaLossForeExTrade.DoubleClick, lbl_p4ReaLossForeExNonTrade.DoubleClick, lbl_p4InitSub.DoubleClick, lbl_p4CAExpenditure.DoubleClick, lbl_p4Other.DoubleClick, lbl_p2RentalIncome.DoubleClick, lblP4NonAllowableExpenses.DoubleClick, lbl_p2Other.DoubleClick, lbl_p2ExemptDividend.DoubleClick, lbl_p3InterestResPurS33.DoubleClick, lbl_p2DivIncome.DoubleClick, lbl_p3ForeignCurrExLoss.DoubleClick
        Try

            If cboRefNo Is Nothing OrElse cboRefNo.EditValue = "" Then
                MsgBox("Please select tax payer.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If cboYA Is Nothing OrElse cboYA.EditValue = "" Then
                MsgBox("Please select year assessment.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If cboMainSource Is Nothing OrElse IsNumeric(cboMainSource.EditValue) = False Then
                MsgBox("Please select source no.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If TypeOf sender Is DevExpress.XtraEditors.LabelControl Then

                Dim lbl As DevExpress.XtraEditors.LabelControl = CType(sender, DevExpress.XtraEditors.LabelControl)

                Dim val As mdlEnum.TaxComPNLEnuItem = DirectCast([Enum].Parse(GetType(mdlEnum.TaxComPNLEnuItem), lbl.Tag.ToString), mdlEnum.TaxComPNLEnuItem)

                DetailsClick(lbl, val)
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub TabbedView1_DocumentClosing(sender As Object, e As DevExpress.XtraBars.Docking2010.Views.DocumentCancelEventArgs) Handles TabbedView1.DocumentClosing
        e.Cancel = True

        mdlPNL.DestroyPNL(e.Document.Control.Name, Me.DockManager1, Me.DocumentManager1)
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Me.Close()
    End Sub
    Private Sub txt_p1Depreciation_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p1Depreciation.EditValueChanged, txt_p1AllowanceExpenses.EditValueChanged, txt_p1NonAllowableExpenses.EditValueChanged
        Try
            txt_p1COP.EditValue = mdlPNL.CalcProductofCost(IIf(IsNumeric(txt_p1Depreciation.EditValue) = False, 0, txt_p1Depreciation.EditValue), IIf(IsNumeric(txt_p1AllowanceExpenses.EditValue) = False, 0, txt_p1AllowanceExpenses.EditValue), IIf(IsNumeric(txt_p1NonAllowableExpenses.EditValue) = False, 0, txt_p1NonAllowableExpenses.EditValue))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_p1COP_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p1COP.EditValueChanged, txt_p1Purchase.EditValueChanged
        Try
            txt_p1PCP.EditValue = mdlPNL.CalcPurchaseProductofCost(IIf(IsNumeric(txt_p1Purchase.EditValue) = False, 0, txt_p1Purchase.EditValue), IIf(IsNumeric(txt_p1COP.EditValue) = False, 0, txt_p1COP.EditValue))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_p1CloseStock_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p1CloseStock.EditValueChanged, txt_p1OpenStock.EditValueChanged, txt_p1PCP.EditValueChanged
        Try
            txt_p1COS.EditValue = mdlPNL.CalcCostOfSales(IIf(IsNumeric(txt_p1OpenStock.EditValue) = False, 0, txt_p1OpenStock.EditValue), IIf(IsNumeric(txt_p1CloseStock.EditValue) = False, 0, txt_p1CloseStock.EditValue), IIf(IsNumeric(txt_p1PCP.EditValue) = False, 0, txt_p1PCP.EditValue))


        Catch ex As Exception

        End Try

    End Sub
    Private Sub txt_p1Sales_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p1Sales.EditValueChanged, txt_p1COS.EditValueChanged
        Try
            txt_p1GrossProfitLoss.EditValue = mdlPNL.CalcGrossProfitLoss(IIf(IsNumeric(txt_p1Sales.EditValue) = False, 0, txt_p1Sales.EditValue), IIf(IsNumeric(txt_p1COS.EditValue) = False, 0, txt_p1COS.EditValue))

            CalcNetProfit()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Try
            Dim CurrentProgress As Integer = 0
            pnlProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Application.DoEvents()

            If isValid() = False Then
                pnlProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Application.DoEvents()
                Exit Sub
            End If
            Progress(2, "Preparing data...")
            Dim sqlCon As SqlConnection = Nothing

            ListofCmd = Nothing
            ListofCmd = New List(Of SqlCommand)

            If dsDataSet2.Tables("PROFIT_LOSS_ACCOUNT") IsNot Nothing Then
                dsDataSet2.Tables("PROFIT_LOSS_ACCOUNT").Rows.Clear()
            End If
            Dim tmpID As Integer = 0
            Dim dtrow As DataRow = Nothing
            If isEdit Then
                'edit
                Progress(4, "Saving new PNL data...")

                dtrow = dsDataSet2.Tables("PROFIT_LOSS_ACCOUNT").NewRow
                tmpID = ID
                dtrow("PL_KEY") = tmpID
                dtrow("PL_REF_NO") = cboRefNo.EditValue
                dtrow("PL_YA") = cboYA.EditValue
                dtrow("PL_SALES") = IIf(IsDBNull(txt_p1Sales.EditValue), 0, txt_p1Sales.EditValue)
                dtrow("PL_OP_STK") = IIf(IsDBNull(txt_p1OpenStock.EditValue), 0, txt_p1OpenStock.EditValue)
                dtrow("PL_PURCHASES") = IIf(IsDBNull(txt_p1Purchase.EditValue), 0, txt_p1Purchase.EditValue)
                dtrow("PL_PRO_COST") = IIf(IsDBNull(txt_p1COP.EditValue), 0, txt_p1COP.EditValue)
                dtrow("PL_PRO_COST_DPC") = IIf(IsDBNull(txt_p1Depreciation.EditValue), 0, txt_p1Depreciation.EditValue)
                dtrow("PL_PRO_COST_OAE") = IIf(IsDBNull(txt_p1AllowanceExpenses.EditValue), 0, txt_p1AllowanceExpenses.EditValue)
                dtrow("PL_PRO_COST_ONAE") = IIf(IsDBNull(txt_p1NonAllowableExpenses.EditValue), 0, txt_p1NonAllowableExpenses.EditValue)
                dtrow("PL_PURCHASES_PRO_COST") = IIf(IsDBNull(txt_p1PCP.EditValue), 0, txt_p1PCP.EditValue)
                dtrow("PL_CLS_STK") = IIf(IsDBNull(txt_p1CloseStock.EditValue), 0, txt_p1CloseStock.EditValue)
                dtrow("PL_COGS") = IIf(IsDBNull(txt_p1COS.EditValue), 0, txt_p1COS.EditValue)
                dtrow("PL_GROSS_PROFIT") = IIf(IsDBNull(txt_p1GrossProfitLoss.EditValue), 0, txt_p1GrossProfitLoss.EditValue)
                dtrow("PL_OTH_BSIN") = IIf(IsDBNull(txt_p2OtherBizIncome.EditValue), 0, txt_p2OtherBizIncome.EditValue)
                dtrow("PL_OTH_BSIN_UNREALGT") = IIf(IsDBNull(txt_p2UnreaGainForeEx.EditValue), 0, txt_p2UnreaGainForeEx.EditValue)
                dtrow("PL_OTH_BSIN_REALGT") = IIf(IsDBNull(txt_p2ForeignCurrExGain.EditValue), 0, txt_p2ForeignCurrExGain.EditValue)
                dtrow("PL_OTH_BSIN_RENTAL") = "0"
                dtrow("PL_OTH_BSIN_OTHER") = "0"
                dtrow("PL_OTH_IN") = IIf(IsDBNull(txt_p2NonBizIncome.EditValue), 0, txt_p2NonBizIncome.EditValue)
                dtrow("PL_OTH_IN_DIVIDEND") = IIf(IsDBNull(txt_p2DivIncome.EditValue), 0, txt_p2DivIncome.EditValue)
                dtrow("PL_OTH_IN_INTEREST") = IIf(IsDBNull(txt_p2InterestIncome.EditValue), 0, txt_p2InterestIncome.EditValue)
                dtrow("PL_OTH_IN_RENTAL") = IIf(IsDBNull(txt_p2RentalIncome.EditValue), 0, txt_p2RentalIncome.EditValue)
                dtrow("PL_OTH_IN_ROYALTY") = IIf(IsDBNull(txt_p2RoyaltyIncome.EditValue), 0, txt_p2RoyaltyIncome.EditValue)
                dtrow("PL_OTH_IN_OTHER") = IIf(IsDBNull(txt_p2OtherIncome.EditValue), 0, txt_p2OtherIncome.EditValue)
                dtrow("PL_NONTAX_IN") = IIf(IsDBNull(txt_p2NonTaxProfit.EditValue), 0, txt_p2NonTaxProfit.EditValue)
                dtrow("PL_NONTAX_IN_FA_DISP") = IIf(IsDBNull(txt_p2ProDispPlantEq.EditValue), 0, txt_p2ProDispPlantEq.EditValue)
                dtrow("PL_NONTAX_IN_INV_DISP") = IIf(IsDBNull(txt_p2ProDisInvestment.EditValue), 0, txt_p2ProDisInvestment.EditValue)
                dtrow("PL_NONTAX_IN_EXM_DIV") = IIf(IsDBNull(txt_p2ExemptDividend.EditValue), 0, txt_p2ExemptDividend.EditValue)
                dtrow("PL_NONTAX_IN_FIR") = IIf(IsDBNull(txt_p2ForeIncomeRemmit.EditValue), 0, txt_p2ForeIncomeRemmit.EditValue)
                dtrow("PL_NONTAX_IN_REALG") = IIf(IsDBNull(txt_p2ReaForeExGainNonTrade.EditValue), 0, txt_p2ReaForeExGainNonTrade.EditValue)
                dtrow("PL_NONTAX_IN_UNREALG") = IIf(IsDBNull(txt_p2UnreaGainForeExNon.EditValue), 0, txt_p2UnreaGainForeExNon.EditValue)
                dtrow("PL_NONTAX_IN_INSU_COMP") = IIf(IsDBNull(txt_p2Other.EditValue), 0, txt_p2Other.EditValue)
                dtrow("PL_EXP_INT") = IIf(IsDBNull(txt_p3InterestResPurS33.EditValue), 0, txt_p3InterestResPurS33.EditValue)
                dtrow("PL_LAWYER_COST") = IIf(IsDBNull(txt_p3ProTechManLeganFees.EditValue), 0, txt_p3ProTechManLeganFees.EditValue)
                dtrow("PL_CONTRACT_EXP") = IIf(IsDBNull(txt_p3ContractPay.EditValue), 0, txt_p3ContractPay.EditValue)
                dtrow("PL_EXP_SALARY") = IIf(IsDBNull(txt_p3Salary.EditValue), 0, txt_p3Salary.EditValue)
                dtrow("PL_ROYALTY") = IIf(IsDBNull(txt_p3Royalty.EditValue), 0, txt_p3Royalty.EditValue)
                dtrow("PL_EXP_RENT") = IIf(IsDBNull(txt_p3Rental.EditValue), 0, txt_p3Rental.EditValue)
                dtrow("PL_EXP_MAINTENANCE") = IIf(IsDBNull(txt_p3RepairMain.EditValue), 0, txt_p3RepairMain.EditValue)
                dtrow("PL_RND") = IIf(IsDBNull(txt_p3ResearchDev.EditValue), 0, txt_p3ResearchDev.EditValue)
                dtrow("PL_ADVERT") = IIf(IsDBNull(txt_p3PromotionAds.EditValue), 0, txt_p3PromotionAds.EditValue)
                dtrow("PL_TRAVEL") = IIf(IsDBNull(txt_p3Travelling.EditValue), 0, txt_p3Travelling.EditValue)
                dtrow("PL_OTHER_EXP") = IIf(IsDBNull(txt_p4TotalOtherExpenses.EditValue), 0, txt_p4TotalOtherExpenses.EditValue)
                dtrow("PL_OTHER_EXP_DPC") = IIf(IsDBNull(txt_p3Depreciation.EditValue), 0, txt_p3Depreciation.EditValue)
                dtrow("PL_OTHER_EXP_DNT") = GetTotalDonaiton(ErrorLog)
                dtrow("PL_OTHER_EXP_DNT_APP") = IIf(IsDBNull(txt_p3DonationApp.EditValue), 0, txt_p3DonationApp.EditValue)
                dtrow("PL_OTHER_EXP_DNT_NAPP") = IIf(IsDBNull(txt_p3DonationNonApp.EditValue), 0, txt_p3DonationNonApp.EditValue)
                dtrow("PL_OTHER_EXP_FA_DISP") = IIf(IsDBNull(txt_p4LossDispFA.EditValue), 0, txt_p4LossDispFA.EditValue)
                dtrow("PL_OTHER_EXP_ENTM") = "0"
                dtrow("PL_OTHER_EXP_ENTM_CLNT") = IIf(IsDBNull(txt_p4EntNonStaff.EditValue), 0, txt_p4EntNonStaff.EditValue)
                dtrow("PL_OTHER_EXP_ENTM_STFF") = IIf(IsDBNull(txt_p4EntStaff.EditValue), 0, txt_p4EntStaff.EditValue)
                dtrow("PL_OTHER_EXP_PENALTY") = IIf(IsDBNull(txt_p4Compound.EditValue), 0, txt_p4Compound.EditValue)
                dtrow("PL_OTHER_EXP_PROV_ACC") = IIf(IsDBNull(txt_p4ProvisionAcc.EditValue), 0, txt_p4ProvisionAcc.EditValue)
                dtrow("PL_OTHER_EXP_LEAVE") = IIf(IsDBNull(txt_p4LeavePass.EditValue), 0, txt_p4LeavePass.EditValue)
                dtrow("PL_OTHER_EXP_FA_WO") = IIf(IsDBNull(txt_p4FAWrittenOff.EditValue), 0, txt_p4FAWrittenOff.EditValue)
                dtrow("PL_OTHER_EXP_UNREALOSS") = IIf(IsDBNull(txt_p4UnreaLossForeEx.EditValue), 0, txt_p4UnreaLossForeEx.EditValue)
                dtrow("PL_OTHER_EXP_REALOSS") = IIf(IsDBNull(txt_p4ReaLossForeExTrade.EditValue), 0, txt_p4ReaLossForeExTrade.EditValue)
                dtrow("PL_OTHER_EXP_INI_SUB") = IIf(IsDBNull(txt_p4InitSub.EditValue), 0, txt_p4InitSub.EditValue)
                dtrow("PL_OTHER_EXP_CAP_EXP") = IIf(IsDBNull(txt_p4CAExpenditure.EditValue), 0, txt_p4CAExpenditure.EditValue)
                dtrow("PL_OTHER_EXP_OTHERS") = IIf(IsDBNull(txt_p4Other.EditValue), 0, txt_p4Other.EditValue)
                dtrow("PL_TOT_EXP") = IIf(IsDBNull(txt_p4TotalExpenses.EditValue), 0, txt_p4TotalExpenses.EditValue)
                dtrow("PL_NET_PROFIT_LOSS") = IIf(IsDBNull(txt_p4NetProfitLoss.EditValue), 0, txt_p4NetProfitLoss.EditValue)
                dtrow("PL_DISALLOWED_EXP") = IIf(IsDBNull(txt_p4NonAllowableExpenses.EditValue), 0, txt_p4NonAllowableExpenses.EditValue)
                dtrow("PL_TOTALX") = "0"
                dtrow("PL_TOTALY") = "0"
                dtrow("PL_EXP_INTRESTRICT") = IIf(IsDBNull(txt_p3InterestResPurS33.EditValue), 0, txt_p3InterestResPurS33.EditValue)
                dtrow("PL_OTH_BSIN_NONSOURCE") = IIf(IsDBNull(txt_p2OtherBizIncome.EditValue), 0, txt_p2OtherBizIncome.EditValue)
                dtrow("PL_S60F") = IIf(cboS60F.EditValue = "Yes", "Y", "N")
                dtrow("PL_MAINBUZ") = CInt(IIf(IsDBNull(cboMainSource.EditValue), 1, cboMainSource.EditValue))
                dtrow("PL_OTHER_EXP_ZAKAT") = txt_p3Zakat.EditValue
                dtrow("PL_COMPANY") = "C"
                dtrow("PL_TREGROSS") = GetTotalTaxDeductuibDividendIncome(ErrorLog)
                dtrow("PL_TTAXDEDUCTION") = "0"
                dtrow("PL_TNETDEDUCTION") = "0"
                dtrow("PL_TECH_FEE") = IIf(IsDBNull(txt_p3TechPayNonResis.EditValue), 0, txt_p3TechPayNonResis.EditValue)
                dtrow("PL_EMPL_STOCK") = IIf(IsDBNull(txt_p3COEStock.EditValue), 0, txt_p3COEStock.EditValue)
                dtrow("PL_S60FA") = IIf(cboS60FA.EditValue = "Yes", "Y", "N")
                dtrow("PL_OTHER_EXP_BALANCE") = IIf(IsDBNull(txt_p4OtherBalacingFigure.EditValue), 0, txt_p4OtherBalacingFigure.EditValue)
                dtrow("PL_OTHER_EXRLOSSFOREIGNT") = IIf(IsDBNull(txt_p4ReaLossForeExNonTrade.EditValue), 0, txt_p4ReaLossForeExNonTrade.EditValue)
                dtrow("PL_DIRECTORS_FEE") = IIf(IsDBNull(txt_p3DirectorFee.EditValue), 0, txt_p3DirectorFee.EditValue)
                dtrow("PL_JKDM") = IIf(IsDBNull(txt_p3JKDM.EditValue), 0, txt_p3JKDM.EditValue)
                dtrow("ModifiedBy") = My.Computer.Name
                dtrow("ModifiedDateTime") = Now
                dtrow("PNL_Status") = IIf(cboPNLStatus.EditValue Is Nothing, "New", cboPNLStatus.EditValue)

                dsDataSet2.Tables("PROFIT_LOSS_ACCOUNT").Rows.Add(dtrow)

                mdlProcess.Update_ProfitAndLoss_Query(dsDataSet2.Tables("PROFIT_LOSS_ACCOUNT"), ListofCmd, ErrorLog)

                Progress(6, "trying to connect with database...")

                If mdlProcess.DBConnection(sqlCon, ErrorLog) = False Then
                    Progress(0, "Failed to connect with database.")
                    MsgBox("Failed to connect with database.", MsgBoxStyle.Critical)
                    Exit Sub
                End If

            Else
                'new
                Progress(4, "Preparing new PNL data...")

                tmpID = GETPNLKEY(ErrorLog)
                tmpID += 1

                dtrow = dsDataSet2.Tables("PROFIT_LOSS_ACCOUNT").NewRow

                dtrow("PL_KEY") = tmpID
                dtrow("PL_REF_NO") = cboRefNo.EditValue
                dtrow("PL_YA") = cboYA.EditValue
                dtrow("PL_SALES") = IIf(IsDBNull(txt_p1Sales.EditValue), 0, txt_p1Sales.EditValue)
                dtrow("PL_OP_STK") = IIf(IsDBNull(txt_p1OpenStock.EditValue), 0, txt_p1OpenStock.EditValue)
                dtrow("PL_PURCHASES") = IIf(IsDBNull(txt_p1Purchase.EditValue), 0, txt_p1Purchase.EditValue)
                dtrow("PL_PRO_COST") = IIf(IsDBNull(txt_p1PCP.EditValue), 0, txt_p1PCP.EditValue)
                dtrow("PL_PRO_COST_DPC") = IIf(IsDBNull(txt_p1Depreciation.EditValue), 0, txt_p1Depreciation.EditValue)
                dtrow("PL_PRO_COST_OAE") = IIf(IsDBNull(txt_p1AllowanceExpenses.EditValue), 0, txt_p1AllowanceExpenses.EditValue)
                dtrow("PL_PRO_COST_ONAE") = IIf(IsDBNull(txt_p1NonAllowableExpenses.EditValue), 0, txt_p1NonAllowableExpenses.EditValue)
                dtrow("PL_PURCHASES_PRO_COST") = IIf(IsDBNull(txt_p1PCP.EditValue), 0, txt_p1PCP.EditValue)
                dtrow("PL_CLS_STK") = IIf(IsDBNull(txt_p1CloseStock.EditValue), 0, txt_p1CloseStock.EditValue)
                dtrow("PL_COGS") = IIf(IsDBNull(txt_p1COS.EditValue), 0, txt_p1COS.EditValue)
                dtrow("PL_GROSS_PROFIT") = IIf(IsDBNull(txt_p1GrossProfitLoss.EditValue), 0, txt_p1GrossProfitLoss.EditValue)
                dtrow("PL_OTH_BSIN") = IIf(IsDBNull(txt_p2OtherBizIncome.EditValue), 0, txt_p2OtherBizIncome.EditValue)
                dtrow("PL_OTH_BSIN_UNREALGT") = IIf(IsDBNull(txt_p2UnreaGainForeEx.EditValue), 0, txt_p2UnreaGainForeEx.EditValue)
                dtrow("PL_OTH_BSIN_REALGT") = IIf(IsDBNull(txt_p2ForeignCurrExGain.EditValue), 0, txt_p2ForeignCurrExGain.EditValue)
                dtrow("PL_OTH_BSIN_RENTAL") = "0"
                dtrow("PL_OTH_BSIN_OTHER") = "0"
                dtrow("PL_OTH_IN") = IIf(IsDBNull(txt_p2NonBizIncome.EditValue), 0, txt_p2NonBizIncome.EditValue)
                dtrow("PL_OTH_IN_DIVIDEND") = IIf(IsDBNull(txt_p2DivIncome.EditValue), 0, txt_p2DivIncome.EditValue)
                dtrow("PL_OTH_IN_INTEREST") = IIf(IsDBNull(txt_p2InterestIncome.EditValue), 0, txt_p2InterestIncome.EditValue)
                dtrow("PL_OTH_IN_RENTAL") = IIf(IsDBNull(txt_p2RentalIncome.EditValue), 0, txt_p2RentalIncome.EditValue)
                dtrow("PL_OTH_IN_ROYALTY") = IIf(IsDBNull(txt_p2RoyaltyIncome.EditValue), 0, txt_p2RoyaltyIncome.EditValue)
                dtrow("PL_OTH_IN_OTHER") = IIf(IsDBNull(txt_p2OtherIncome.EditValue), 0, txt_p2OtherIncome.EditValue)
                dtrow("PL_NONTAX_IN") = IIf(IsDBNull(txt_p2NonTaxProfit.EditValue), 0, txt_p2NonTaxProfit.EditValue)
                dtrow("PL_NONTAX_IN_FA_DISP") = IIf(IsDBNull(txt_p2ProDispPlantEq.EditValue), 0, txt_p2ProDispPlantEq.EditValue)
                dtrow("PL_NONTAX_IN_INV_DISP") = IIf(IsDBNull(txt_p2ProDisInvestment.EditValue), 0, txt_p2ProDisInvestment.EditValue)
                dtrow("PL_NONTAX_IN_EXM_DIV") = IIf(IsDBNull(txt_p2ExemptDividend.EditValue), 0, txt_p2ExemptDividend.EditValue)
                dtrow("PL_NONTAX_IN_FIR") = IIf(IsDBNull(txt_p2ForeIncomeRemmit.EditValue), 0, txt_p2ForeIncomeRemmit.EditValue)
                dtrow("PL_NONTAX_IN_REALG") = IIf(IsDBNull(txt_p2ReaForeExGainNonTrade.EditValue), 0, txt_p2ReaForeExGainNonTrade.EditValue)
                dtrow("PL_NONTAX_IN_UNREALG") = IIf(IsDBNull(txt_p2UnreaGainForeExNon.EditValue), 0, txt_p2UnreaGainForeExNon.EditValue)
                dtrow("PL_NONTAX_IN_INSU_COMP") = IIf(IsDBNull(txt_p2Other.EditValue), 0, txt_p2Other.EditValue)
                dtrow("PL_EXP_INT") = IIf(IsDBNull(txt_p3InterestResPurS33.EditValue), 0, txt_p3InterestResPurS33.EditValue)
                dtrow("PL_LAWYER_COST") = IIf(IsDBNull(txt_p3ProTechManLeganFees.EditValue), 0, txt_p3ProTechManLeganFees.EditValue)
                dtrow("PL_CONTRACT_EXP") = IIf(IsDBNull(txt_p3ContractPay.EditValue), 0, txt_p3ContractPay.EditValue)
                dtrow("PL_EXP_SALARY") = IIf(IsDBNull(txt_p3Salary.EditValue), 0, txt_p3Salary.EditValue)
                dtrow("PL_ROYALTY") = IIf(IsDBNull(txt_p3Royalty.EditValue), 0, txt_p3Royalty.EditValue)
                dtrow("PL_EXP_RENT") = IIf(IsDBNull(txt_p3Rental.EditValue), 0, txt_p3Rental.EditValue)
                dtrow("PL_EXP_MAINTENANCE") = IIf(IsDBNull(txt_p3RepairMain.EditValue), 0, txt_p3RepairMain.EditValue)
                dtrow("PL_RND") = IIf(IsDBNull(txt_p3ResearchDev.EditValue), 0, txt_p3ResearchDev.EditValue)
                dtrow("PL_ADVERT") = IIf(IsDBNull(txt_p3PromotionAds.EditValue), 0, txt_p3PromotionAds.EditValue)
                dtrow("PL_TRAVEL") = IIf(IsDBNull(txt_p3Travelling.EditValue), 0, txt_p3Travelling.EditValue)
                dtrow("PL_OTHER_EXP") = IIf(IsDBNull(txt_p4TotalOtherExpenses.EditValue), 0, txt_p4TotalOtherExpenses.EditValue)
                dtrow("PL_OTHER_EXP_DPC") = IIf(IsDBNull(txt_p3Depreciation.EditValue), 0, txt_p3Depreciation.EditValue)
                dtrow("PL_OTHER_EXP_DNT") = GetTotalDonaiton(ErrorLog)
                dtrow("PL_OTHER_EXP_DNT_APP") = IIf(IsDBNull(txt_p3DonationApp.EditValue), 0, txt_p3DonationApp.EditValue)
                dtrow("PL_OTHER_EXP_DNT_NAPP") = IIf(IsDBNull(txt_p3DonationNonApp.EditValue), 0, txt_p3DonationNonApp.EditValue)
                dtrow("PL_OTHER_EXP_FA_DISP") = IIf(IsDBNull(txt_p4LossDispFA.EditValue), 0, txt_p4LossDispFA.EditValue)
                dtrow("PL_OTHER_EXP_ENTM") = "0"
                dtrow("PL_OTHER_EXP_ENTM_CLNT") = IIf(IsDBNull(txt_p4EntNonStaff.EditValue), 0, txt_p4EntNonStaff.EditValue)
                dtrow("PL_OTHER_EXP_ENTM_STFF") = IIf(IsDBNull(txt_p4EntStaff.EditValue), 0, txt_p4EntStaff.EditValue)
                dtrow("PL_OTHER_EXP_PENALTY") = IIf(IsDBNull(txt_p4Compound.EditValue), 0, txt_p4Compound.EditValue)
                dtrow("PL_OTHER_EXP_PROV_ACC") = IIf(IsDBNull(txt_p4ProvisionAcc.EditValue), 0, txt_p4ProvisionAcc.EditValue)
                dtrow("PL_OTHER_EXP_LEAVE") = IIf(IsDBNull(txt_p4LeavePass.EditValue), 0, txt_p4LeavePass.EditValue)
                dtrow("PL_OTHER_EXP_FA_WO") = IIf(IsDBNull(txt_p4FAWrittenOff.EditValue), 0, txt_p4FAWrittenOff.EditValue)
                dtrow("PL_OTHER_EXP_UNREALOSS") = IIf(IsDBNull(txt_p4UnreaLossForeEx.EditValue), 0, txt_p4UnreaLossForeEx.EditValue)
                dtrow("PL_OTHER_EXP_REALOSS") = IIf(IsDBNull(txt_p4ReaLossForeExTrade.EditValue), 0, txt_p4ReaLossForeExTrade.EditValue)
                dtrow("PL_OTHER_EXP_INI_SUB") = IIf(IsDBNull(txt_p4InitSub.EditValue), 0, txt_p4InitSub.EditValue)
                dtrow("PL_OTHER_EXP_CAP_EXP") = IIf(IsDBNull(txt_p4CAExpenditure.EditValue), 0, txt_p4CAExpenditure.EditValue)
                dtrow("PL_OTHER_EXP_OTHERS") = IIf(IsDBNull(txt_p4Other.EditValue), 0, txt_p4Other.EditValue)
                dtrow("PL_TOT_EXP") = IIf(IsDBNull(txt_p4TotalExpenses.EditValue), 0, txt_p4TotalExpenses.EditValue)
                dtrow("PL_NET_PROFIT_LOSS") = IIf(IsDBNull(txt_p4NetProfitLoss.EditValue), 0, txt_p4NetProfitLoss.EditValue)
                dtrow("PL_DISALLOWED_EXP") = IIf(IsDBNull(txt_p4NonAllowableExpenses.EditValue), 0, txt_p4NonAllowableExpenses.EditValue)
                dtrow("PL_TOTALX") = "0"
                dtrow("PL_TOTALY") = "0"
                dtrow("PL_EXP_INTRESTRICT") = IIf(IsDBNull(txt_p3InterestResPurS33.EditValue), 0, txt_p3InterestResPurS33.EditValue)
                dtrow("PL_OTH_BSIN_NONSOURCE") = IIf(IsDBNull(txt_p2OtherBizIncome.EditValue), 0, txt_p2OtherBizIncome.EditValue)
                dtrow("PL_S60F") = IIf(cboS60F.EditValue = "Yes", "Y", "N")
                dtrow("PL_MAINBUZ") = CInt(IIf(IsDBNull(cboMainSource.EditValue), 1, cboMainSource.EditValue))
                dtrow("PL_OTHER_EXP_ZAKAT") = txt_p3Zakat.EditValue
                dtrow("PL_COMPANY") = "C"
                dtrow("PL_TREGROSS") = GetTotalTaxDeductuibDividendIncome(ErrorLog)
                dtrow("PL_TTAXDEDUCTION") = "0"
                dtrow("PL_TNETDEDUCTION") = "0"
                dtrow("PL_TECH_FEE") = IIf(IsDBNull(txt_p3TechPayNonResis.EditValue), 0, txt_p3TechPayNonResis.EditValue)
                dtrow("PL_EMPL_STOCK") = IIf(IsDBNull(txt_p3COEStock.EditValue), 0, txt_p3COEStock.EditValue)
                dtrow("PL_S60FA") = IIf(cboS60FA.EditValue = "Yes", "Y", "N")
                dtrow("PL_OTHER_EXP_BALANCE") = IIf(IsDBNull(txt_p4OtherBalacingFigure.EditValue), 0, txt_p4OtherBalacingFigure.EditValue)
                dtrow("PL_OTHER_EXRLOSSFOREIGNT") = IIf(IsDBNull(txt_p4ReaLossForeExNonTrade.EditValue), 0, txt_p4ReaLossForeExNonTrade.EditValue)
                dtrow("PL_DIRECTORS_FEE") = IIf(IsDBNull(txt_p3DirectorFee.EditValue), 0, txt_p3DirectorFee.EditValue)
                dtrow("PL_JKDM") = IIf(IsDBNull(txt_p3JKDM.EditValue), 0, txt_p3JKDM.EditValue)
                dtrow("ModifiedBy") = My.Computer.Name
                dtrow("ModifiedDateTime") = Now
                dtrow("PNL_Status") = IIf(cboPNLStatus.EditValue Is Nothing, "New", cboPNLStatus.EditValue)

                dsDataSet2.Tables("PROFIT_LOSS_ACCOUNT").Rows.Add(dtrow)

                mdlProcess.Save_ProfitAndLoss_Query(dsDataSet2.Tables("PROFIT_LOSS_ACCOUNT"), ListofCmd, ErrorLog)

                Progress(6, "trying to connect with database...")

                If mdlProcess.DBConnection(sqlCon, ErrorLog) = False Then
                    Progress(0, "Failed to connect with database.")
                    MsgBox("Failed to connect with database.", MsgBoxStyle.Critical)
                    Exit Sub
                End If

            End If

            Dim listofclsPNLLabel As List(Of clsPNL_LabelName) = GetPNLLabelName()

            CurrentProgress = 6
            If listofclsPNLLabel IsNot Nothing Then
                For Each tmp As clsPNL_LabelName In listofclsPNLLabel
                    CurrentProgress += 1
                    If mdlProcess.isVersionLicenseType = VersionLicenseType.Tricor Then
                        Progress(CurrentProgress, "Getting " & tmp.LabelTricor & " data...")
                    Else
                        Progress(CurrentProgress, "Getting " & tmp.LabelText & " data...")
                    End If

                    mdlPNL.PNL_GetSaveData(tmpID, tmp.Type, Nothing, ListofCmd)
                Next
            End If
            CurrentProgress += 1
            Progress(CurrentProgress, "Ready to saving " & ListofCmd.Count & " data(s)...")

            If ListofCmd IsNot Nothing AndAlso ListofCmd.Count > 0 Then
                If mdlProcess.Save_PNLExecute(ListofCmd, ErrorLog) Then
                    Progress(100, "Done to saved " & ListofCmd.Count & " data(s)...")
                    isEdit = True
                    Application.DoEvents()
                    isSuccessfullySaved(tmpID)
                Else
                    Progress(100, "Failed to saving " & ListofCmd.Count & " data(s)...")
                    MsgBox("Failed to save data." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)

                End If
            End If


        Catch ex As Exception

        End Try
    End Sub
    Private Sub isSuccessfullySaved(ByVal KeyID As Integer)
        Try
            Dim dt As DataTable = mdlProcess.Load_PNLLastModified(KeyID)

            If dt IsNot Nothing Then
                txtLastModified.EditValue = IIf(IsDBNull(dt.Rows(0)("ModifiedDateTime")), "", dt.Rows(0)("ModifiedDateTime"))
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Progress(ByVal val As Integer, ByVal Caption As String)
        Try
            pnlProgress.EditValue = val
            pnlProgress.Caption = Caption
            Application.DoEvents()
        Catch ex As Exception

        End Try
    End Sub
    Public Function GetTotalTaxDeductuibDividendIncome(Optional ByRef Errorlog As clsError = Nothing) As Decimal
        Try
            Dim obj As Object = dsDataSet2.Tables("DIVIDEND_INCOME").Compute("sum('di_taxdeduction')", "")

            If obj IsNot Nothing AndAlso IsNumeric(obj) Then
                Return CDec(obj)
            End If

            Return 0
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

    Private Function isValid() As Boolean
        Try
            If cboRefNo Is Nothing OrElse cboRefNo.EditValue.ToString = "" Then
                MsgBox("Please select company reference number.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If cboYA Is Nothing OrElse cboYA.EditValue.ToString = "" Then
                MsgBox("Please select year assesment.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If cboMainSource Is Nothing OrElse cboMainSource.EditValue.ToString = "" Then
                MsgBox("Please select main source number.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If isEdit = False Then
                If mdlProcess.Check_PNLExist(cboRefNo.EditValue, CInt(cboYA.EditValue), ErrorLog) Then
                    ' MsgBox("Profit and loss already exist.", MsgBoxStyle.Exclamation)
                    Dim rlst As DialogResult = MessageBox.Show("Profit and loss already exist, do you want to replace with this pnl?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

                    If rlst = Windows.Forms.DialogResult.Yes Then
                        isEdit = True
                    End If

                    Return False
                End If
            End If


            If dsDataSet Is Nothing Then
                MsgBox("Unable to get dataset.", MsgBoxStyle.Critical)
                Return False
            End If


            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Function GetTotalDonaiton(Optional ByRef Errorlog As clsError = Nothing) As Decimal
        Try
            Dim Total As Decimal = 0

            Total = IIf(IsNumeric(txt_p3DonationApp.EditValue), txt_p3DonationApp.EditValue, 0) + IIf(IsNumeric(txt_p3DonationNonApp.EditValue), txt_p3DonationNonApp.EditValue, 0)
            Return 0
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

    Private Sub txt_p2DivIncome_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p2DivIncome.EditValueChanged, txt_p2InterestIncome.EditValueChanged, txt_p2RentalIncome.EditValueChanged, txt_p2RoyaltyIncome.EditValueChanged, txt_p2OtherIncome.EditValueChanged
        Try
            Dim Dividen As Decimal = IIf(IsNumeric(txt_p2DivIncome.EditValue) = False, 0, txt_p2DivIncome.EditValue)
            Dim Interest As Decimal = IIf(IsNumeric(txt_p2InterestIncome.EditValue) = False, 0, txt_p2InterestIncome.EditValue)
            Dim Rental As Decimal = IIf(IsNumeric(txt_p2RentalIncome.EditValue) = False, 0, txt_p2RentalIncome.EditValue)
            Dim Royalty As Decimal = IIf(IsNumeric(txt_p2RoyaltyIncome.EditValue) = False, 0, txt_p2RoyaltyIncome.EditValue)
            Dim Other As Decimal = IIf(IsNumeric(txt_p2OtherIncome.EditValue) = False, 0, txt_p2OtherIncome.EditValue)

            txt_p2NonBizIncome.EditValue = mdlPNL.CalcNonBizIncome(Dividen, Interest, Rental, Royalty, Other, ErrorLog)

            CalcNetProfit()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_p2ProDispPlantEq_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p2ProDispPlantEq.EditValueChanged, txt_p2Other.EditValueChanged, txt_p2ExemptDividend.EditValueChanged, txt_p2ForeIncomeRemmit.EditValueChanged, txt_p2ReaForeExGainNonTrade.EditValueChanged, txt_p2UnreaGainForeEx.EditValueChanged, txt_p2UnreaGainForeExNon.EditValueChanged, txt_p2ProDisInvestment.EditValueChanged

        Try
            Dim p2ProDispPlantEq As Decimal = IIf(IsNumeric(txt_p2ProDispPlantEq.EditValue) = False, 0, txt_p2ProDispPlantEq.EditValue)
            Dim p2Other As Decimal = IIf(IsNumeric(txt_p2Other.EditValue) = False, 0, txt_p2Other.EditValue)
            Dim p2ExemptDividend As Decimal = IIf(IsNumeric(txt_p2ExemptDividend.EditValue) = False, 0, txt_p2ExemptDividend.EditValue)
            Dim p2ForeIncomeRemmit As Decimal = IIf(IsNumeric(txt_p2ForeIncomeRemmit.EditValue) = False, 0, txt_p2ForeIncomeRemmit.EditValue)
            Dim p2ReaForeExGainNonTrade As Decimal = IIf(IsNumeric(txt_p2ReaForeExGainNonTrade.EditValue) = False, 0, txt_p2ReaForeExGainNonTrade.EditValue)

            Dim p2UnreaGainForeEx As Decimal = IIf(IsNumeric(txt_p2UnreaGainForeEx.EditValue) = False, 0, txt_p2UnreaGainForeEx.EditValue)
            Dim p2UnreaGainForeExNon As Decimal = IIf(IsNumeric(txt_p2UnreaGainForeExNon.EditValue) = False, 0, txt_p2UnreaGainForeExNon.EditValue)
            Dim p2ProDisInvestment As Decimal = IIf(IsNumeric(txt_p2ProDisInvestment.EditValue) = False, 0, txt_p2ProDisInvestment.EditValue)

            txt_p2NonTaxProfit.EditValue = mdlPNL.CalcNonTaxProfit(p2ProDispPlantEq, p2Other, p2ExemptDividend, p2ForeIncomeRemmit, p2ReaForeExGainNonTrade, p2UnreaGainForeEx, p2UnreaGainForeExNon, p2ProDisInvestment, ErrorLog)

            CalcNetProfit()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_p3Depreciation_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p3Depreciation.EditValueChanged, txt_p3DonationApp.EditValueChanged, txt_p3DonationNonApp.EditValueChanged, txt_p3Zakat.EditValueChanged, txt_p4EntNonStaff.EditValueChanged, txt_p4EntStaff.EditValueChanged, txt_p4Compound.EditValueChanged, txt_p4ProvisionAcc.EditValueChanged, txt_p4LeavePass.EditValueChanged, txt_p4FAWrittenOff.EditValueChanged, txt_p4UnreaLossForeEx.EditValueChanged, txt_p4ReaLossForeExTrade.EditValueChanged, txt_p4ReaLossForeExNonTrade.EditValueChanged, txt_p4InitSub.EditValueChanged, txt_p4CAExpenditure.EditValueChanged, txt_p4Other.EditValueChanged, txt_p4LossDispFA.EditValueChanged

        Try
            Dim p3Depreciation As Decimal = IIf(IsNumeric(txt_p3Depreciation.EditValue) = False, 0, txt_p3Depreciation.EditValue)
            Dim p3DonationApp As Decimal = IIf(IsNumeric(txt_p3DonationApp.EditValue) = False, 0, txt_p3DonationApp.EditValue)
            Dim p3DonationNonApp As Decimal = IIf(IsNumeric(txt_p3DonationNonApp.EditValue) = False, 0, txt_p3DonationNonApp.EditValue)
            Dim p3Zakat As Decimal = IIf(IsNumeric(txt_p3Zakat.EditValue) = False, 0, txt_p3Zakat.EditValue)

            Dim p4EntNonStaff As Decimal = IIf(IsNumeric(txt_p4EntNonStaff.EditValue) = False, 0, txt_p4EntNonStaff.EditValue)
            Dim p4EntStaff As Decimal = IIf(IsNumeric(txt_p4EntStaff.EditValue) = False, 0, txt_p4EntStaff.EditValue)
            Dim p4Compound As Decimal = IIf(IsNumeric(txt_p4Compound.EditValue) = False, 0, txt_p4Compound.EditValue)
            Dim p4ProvisionAcc As Decimal = IIf(IsNumeric(txt_p4ProvisionAcc.EditValue) = False, 0, txt_p4ProvisionAcc.EditValue)
            Dim p4LeavePass As Decimal = IIf(IsNumeric(txt_p4LeavePass.EditValue) = False, 0, txt_p4LeavePass.EditValue)
            Dim p4FAWrittenOff As Decimal = IIf(IsNumeric(txt_p4FAWrittenOff.EditValue) = False, 0, txt_p4FAWrittenOff.EditValue)
            Dim p4UnreaLossForeEx As Decimal = IIf(IsNumeric(txt_p4UnreaLossForeEx.EditValue) = False, 0, txt_p4UnreaLossForeEx.EditValue)
            Dim p4ReaLossForeExTrade As Decimal = IIf(IsNumeric(txt_p4ReaLossForeExTrade.EditValue) = False, 0, txt_p4ReaLossForeExTrade.EditValue)
            Dim p4ReaLossForeExNonTrade As Decimal = IIf(IsNumeric(txt_p4ReaLossForeExNonTrade.EditValue) = False, 0, txt_p4ReaLossForeExNonTrade.EditValue)
            Dim p4InitSub As Decimal = IIf(IsNumeric(txt_p4InitSub.EditValue) = False, 0, txt_p4InitSub.EditValue)
            Dim p4CAExpenditure As Decimal = IIf(IsNumeric(txt_p4CAExpenditure.EditValue) = False, 0, txt_p4CAExpenditure.EditValue)
            Dim p4Other As Decimal = IIf(IsNumeric(txt_p4Other.EditValue) = False, 0, txt_p4Other.EditValue)
            Dim p4LossDispFA As Decimal = IIf(IsNumeric(txt_p4LossDispFA.EditValue) = False, 0, txt_p4LossDispFA.EditValue)

            txt_p4TotalOtherExpenses.EditValue = mdlPNL.CalcOtherExpenses(p3Depreciation, p3DonationApp, p3DonationNonApp, p3Zakat, p4EntNonStaff, p4EntStaff, p4Compound, p4ProvisionAcc, p4LeavePass, p4FAWrittenOff, p4UnreaLossForeEx, p4ReaLossForeExTrade, p4ReaLossForeExNonTrade, p4InitSub, p4CAExpenditure, p4Other, p4LossDispFA, ErrorLog)

        Catch ex As Exception

        End Try

    End Sub
    Private Sub txt_p3ForeignCurrExLoss_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p3ForeignCurrExLoss.EditValueChanged, txt_p3OtherInterestExHirePur.EditValueChanged, txt_p3ProTechManLeganFees.EditValueChanged, txt_p3TechPayNonResis.EditValueChanged, txt_p3ContractPay.EditValueChanged, txt_p3DirectorFee.EditValueChanged, txt_p3Salary.EditValueChanged, txt_p3COEStock.EditValueChanged, txt_p3Royalty.EditValueChanged, txt_p3Rental.EditValueChanged, txt_p3RepairMain.EditValueChanged, txt_p3ResearchDev.EditValueChanged, txt_p3PromotionAds.EditValueChanged, txt_p3Travelling.EditValueChanged, txt_p3JKDM.EditValueChanged, txt_p3InterestResPurS33.EditValueChanged, txt_p4TotalOtherExpenses.EditValueChanged
        Try
            CalcTotalExpenses()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CalcTotalExpenses()
        Try
            Dim p3ForeignCurrExLoss As Decimal = IIf(IsNumeric(txt_p3ForeignCurrExLoss.EditValue) = False, 0, txt_p3ForeignCurrExLoss.EditValue)
            Dim p3OtherInterestExHirePur As Decimal = IIf(IsNumeric(txt_p3OtherInterestExHirePur.EditValue) = False, 0, txt_p3OtherInterestExHirePur.EditValue)
            Dim p3ProTechManLeganFees As Decimal = IIf(IsNumeric(txt_p3ProTechManLeganFees.EditValue) = False, 0, txt_p3ProTechManLeganFees.EditValue)
            Dim p3TechPayNonResis As Decimal = IIf(IsNumeric(txt_p3TechPayNonResis.EditValue) = False, 0, txt_p3TechPayNonResis.EditValue)
            Dim p3ContractPay As Decimal = IIf(IsNumeric(txt_p3ContractPay.EditValue) = False, 0, txt_p3ContractPay.EditValue)
            Dim p3DirectorFee As Decimal = IIf(IsNumeric(txt_p3DirectorFee.EditValue) = False, 0, txt_p3DirectorFee.EditValue)
            Dim p3Salary As Decimal = IIf(IsNumeric(txt_p3Salary.EditValue) = False, 0, txt_p3Salary.EditValue)
            Dim p3COEStock As Decimal = IIf(IsNumeric(txt_p3COEStock.EditValue) = False, 0, txt_p3COEStock.EditValue)
            Dim p3Royalty As Decimal = IIf(IsNumeric(txt_p3Royalty.EditValue) = False, 0, txt_p3Royalty.EditValue)
            Dim p3Rental As Decimal = IIf(IsNumeric(txt_p3Rental.EditValue) = False, 0, txt_p3Rental.EditValue)
            Dim p3RepairMain As Decimal = IIf(IsNumeric(txt_p3RepairMain.EditValue) = False, 0, txt_p3RepairMain.EditValue)
            Dim p3ResearchDev As Decimal = IIf(IsNumeric(txt_p3ResearchDev.EditValue) = False, 0, txt_p3ResearchDev.EditValue)
            Dim p3PromotionAds As Decimal = IIf(IsNumeric(txt_p3PromotionAds.EditValue) = False, 0, txt_p3PromotionAds.EditValue)
            Dim p3Travelling As Decimal = IIf(IsNumeric(txt_p3Travelling.EditValue) = False, 0, txt_p3Travelling.EditValue)
            Dim p3JKDM As Decimal = IIf(IsNumeric(txt_p3JKDM.EditValue) = False, 0, txt_p3JKDM.EditValue)
            Dim p3InterestResPurS33 As Decimal = IIf(IsNumeric(txt_p3InterestResPurS33.EditValue) = False, 0, txt_p3InterestResPurS33.EditValue)
            Dim p4TotalOtherExpenses As Decimal = IIf(IsNumeric(txt_p4TotalOtherExpenses.EditValue) = False, 0, txt_p4TotalOtherExpenses.EditValue)
            Dim BalacingFigure As Decimal = 0

            If IsNumeric(txt_p4TotalExpenses.EditValue) = False Then
                txt_p4TotalExpenses.EditValue = 0
            End If
            If IsNumeric(txt_p4OtherBalacingFigure.EditValue) = False Then
                txt_p4OtherBalacingFigure.EditValue = 0
            End If

            Dim NonAllowableExpenses As Decimal = 0
            Dim TotalExpenses As Decimal = mdlPNL.CalcExpenses(p3ForeignCurrExLoss, p3OtherInterestExHirePur, p3ProTechManLeganFees, p3TechPayNonResis, p3ContractPay, p3DirectorFee, p3Salary, p3COEStock, p3Royalty, p3Rental, p3RepairMain, p3ResearchDev, p3PromotionAds, p3Travelling, p3JKDM, p3InterestResPurS33, p4TotalOtherExpenses, BalacingFigure, NonAllowableExpenses, ErrorLog)

            txt_p4NonAllowableExpenses.EditValue = NonAllowableExpenses
            txt_p4TotalExpenses.EditValue = TotalExpenses
            Application.DoEvents()
            Dim p4ExpectedExpenses As Decimal = IIf(IsNumeric(txt_p4ExpectedExpenses.EditValue) = False, 0, txt_p4ExpectedExpenses.EditValue)

            GetOtherBalancingFigureRefresh(TotalExpenses, p4ExpectedExpenses)

            CalcNetProfit()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_p4TotalExpenses_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_p4TotalExpenses.KeyUp
        CalcTotalExpenses()
    End Sub

    Public Sub GetOtherBalancingFigureRefresh(ByVal TotalExpenses As Decimal, ByVal ExpectedExpenses As Decimal, _
                                                    Optional ByRef Errorlog As clsError = Nothing)
        Try
            Dim dblOtherBalancingFigure As Decimal = ExpectedExpenses - TotalExpenses


            txt_p4OtherBalacingFigure.EditValue = dblOtherBalancingFigure
            'If TotalExpenses < txtTotalExpensesDic Then
            '    dblOtherBalancingFigure = txtTotalExpensesDic - TotalExpenses
            '    If dblOtherBalancingFigure >= ExpTotalBalance Then
            '        Return 0
            '    ElseIf dblOtherBalancingFigure > 0 Then
            '        '  Me.dicPNL("ExpTotalBalance") = FormatNumber(CDbl(Me.dicPNL("ExpTotalBalance")) - CDbl(dblOtherBalancingFigure), 0)
            '        Return ExpTotalBalance - dblOtherBalancingFigure
            '    End If
            'End If

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

            txt_p4OtherBalacingFigure.EditValue = 0
        End Try
    End Sub

    Public Sub CalcNetProfit(Optional ByRef Errorlog As clsError = Nothing)
        Try
            'Dim dblNetProfitLoss As Double 'weihong add RealFETrade
            'dblNetProfitLoss = GetGrossProfitLoss() + dicPNL("OtherBusinessIncome") + GetTotalOtherNonBusinessIncome() + GetTotalNonTaxableIncome() - GetTotalExpensesDic() + dicPNL("RealFETrade")
            'Return dblNetProfitLoss

            Dim NetProfitLoss As Decimal = CDec(txt_p1GrossProfitLoss.EditValue) + CDec(txt_p2OtherBizIncome.EditValue) + CDec(txt_p2ForeignCurrExGain.EditValue) - CDec(txt_p4TotalExpenses.EditValue)

            txt_p4NetProfitLoss.EditValue = NetProfitLoss
            txtNetProfit2.EditValue = NetProfitLoss
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

        End Try
    End Sub
    Private Sub txt_p2OtherBizIncome_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p2OtherBizIncome.EditValueChanged, txt_p2ForeignCurrExGain.EditValueChanged
        Try
            CalcNetProfit()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_p4ExpectedExpenses_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p4ExpectedExpenses.EditValueChanged
        Try

            Dim TotalExpenses As Decimal = IIf(IsNumeric(txt_p4TotalExpenses.EditValue) = False, 0, txt_p4TotalExpenses.EditValue)
            Dim p4ExpectedExpenses As Decimal = IIf(IsNumeric(txt_p4ExpectedExpenses.EditValue) = False, 0, txt_p4ExpectedExpenses.EditValue)
            GetOtherBalancingFigureRefresh(TotalExpenses, p4ExpectedExpenses)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_p4NonAllowableExpenses_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p4NonAllowableExpenses.EditValueChanged
        Try
            If txt_p4NonAllowableExpenses IsNot Nothing Then
                txtNonAllowableExpense.EditValue = txt_p4NonAllowableExpenses.EditValue
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged, cboYA.EditValueChanged, cboYA.EditValueChanged
        Try
            If cboRefNo IsNot Nothing AndAlso cboRefNo.EditValue.ToString <> "" AndAlso cboYA IsNot Nothing AndAlso cboYA.EditValue.ToString <> "" Then
                txtRefNo.EditValue = cboRefNo.EditValue
                mdlProcess.CreateLookUpSourceNO(dsDataSet, cboRefNo.EditValue, cboYA.EditValue, "BUSINESS_SOURCE", ErrorLog)
                mdlProcess.CreateLookUpSourceNO(dsDataSet2, cboRefNo.EditValue, cboYA.EditValue, "BUSINESS_SOURCE", ErrorLog)
                Application.DoEvents()
                BUSINESSSOURCEBindingSource.DataSource = dsDataSet.Tables("BUSINESS_SOURCE")

                If isEdit = False Then
                    'Dim editor As DevExpress.XtraEditors.ComboBoxEdit
                    'editor = CType(cboMainSource, DevExpress.XtraEditors.ComboBoxEdit)
                    '' editor = TryCast(cboMainSource, DevExpress.XtraEditors.ComboBoxEdit)
                    'editor.SelectedIndex = 0
                    For i As Integer = 0 To dsDataSet.Tables("BUSINESS_SOURCE").Rows.Count - 1
                        If i = 0 Then
                            cboMainSource.EditValue = dsDataSet.Tables("BUSINESS_SOURCE").Rows(i)("BC_SOURCENO")
                        End If
                    Next

                End If
                If mdlProcess.VerifyInvestmentHolding(cboRefNo.EditValue, cboYA.EditValue, ErrorLog) Then
                    cboS60F.Edit.ReadOnly = True
                    cboS60F.EditValue = "Yes"
                Else
                    cboS60F.Edit.ReadOnly = False
                    cboS60F.EditValue = "No"
                End If

                DockPanel1.Enabled = True
            Else
                DockPanel1.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_p4OtherBalacingFigure_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p4OtherBalacingFigure.EditValueChanged
        txtBalacingFigure.EditValue = txt_p4OtherBalacingFigure.EditValue
    End Sub

    Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
        Try
            Me.LoadData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImport.ItemClick
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
        Try
           

        Catch ex As Exception

        End Try
    End Sub
    Private Sub exporter_CellValueConversionError(ByVal sender As Object, ByVal e As CellValueConversionErrorEventArgs)
        MessageBox.Show("Error in cell " & e.Cell.GetReferenceA1())
        e.DataTableValue = Nothing
        e.Action = DataTableExporterAction.Continue
    End Sub
End Class