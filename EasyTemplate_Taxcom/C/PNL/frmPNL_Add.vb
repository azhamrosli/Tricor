Imports System.Data.SqlClient
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Export
Imports DevExpress.XtraGrid
Imports System.Data.OleDb

Public Class frmPNL_Add
    Public isEdit As Boolean = True
    Public ID As Decimal = 1269
    Dim ErrorLog As clsError = Nothing
    Dim isReplacePNL As Boolean = False
    Dim ListofCmd As List(Of SqlCommand)

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        If dsDataSet Is Nothing Then
            dsDataSet = New dsPNL
        End If


        txtPCName.Caption = My.Computer.Name & " | " & GetServerName() & " | V" & mdlProcess.V1 & "." & mdlProcess.V2 & "." & mdlProcess.V3 & "." & mdlProcess.V4 & " R." & System.Reflection.Assembly.GetExecutingAssembly.GetName.Version.Revision.ToString
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmPNL_Details_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Try
            If e.KeyCode = Keys.F1 Then
                XtraTabControl1.SelectedTabPageIndex = 0
            ElseIf e.KeyCode = Keys.F2 Then
                XtraTabControl1.SelectedTabPageIndex = 1
            ElseIf e.KeyCode = Keys.F3 Then
                XtraTabControl1.SelectedTabPageIndex = 2
            ElseIf e.KeyCode = Keys.F4 Then
                XtraTabControl1.SelectedTabPageIndex = 3
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmPNL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


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

            LoadData()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub InitDockingSystem(ByVal CurrentProgress As Integer)
        Try

            Dim listoflabelname As List(Of clsPNL_LabelName) = mdlPNL.GetPNLLabelName(ErrorLog)

            If listoflabelname IsNot Nothing Then
                Dim lbl As DevExpress.XtraEditors.LabelControl
                For Each tmp As clsPNL_LabelName In listoflabelname
                    Select Case tmp.Type
                        Case TaxComPNLEnuItem.SALES
                            lbl = lbl_p1Sales
                        Case TaxComPNLEnuItem.OPENSTOCK
                            lbl = lbl_p1OpenStock
                        Case TaxComPNLEnuItem.PURCHASE
                            lbl = lbl_p1Purchase
                        Case TaxComPNLEnuItem.DEPRECIATION
                            lbl = lbl_p1Depreciation
                        Case TaxComPNLEnuItem.OTHERALLOWEXP
                            lbl = lbl_p1AllowanceExpenses
                        Case TaxComPNLEnuItem.OTHERNONALLOWEXP
                            lbl = lbl_p1NonAllowableExpenses
                        Case TaxComPNLEnuItem.CLOSESTOCK
                            lbl = lbl_p1CloseStock
                        Case TaxComPNLEnuItem.OTHERBUSINC
                            lbl = lbl_p2OtherBizIncome
                        Case TaxComPNLEnuItem.REALFETRADE
                            lbl = lbl_p2ForeignCurrExGain
                        Case TaxComPNLEnuItem.INTERESTINC
                            lbl = lbl_p2InterestIncome
                        Case TaxComPNLEnuItem.ROYALTYINC
                            lbl = lbl_p2RoyaltyIncome
                        Case TaxComPNLEnuItem.OTHERINC
                            lbl = lbl_p2OtherIncome
                        Case TaxComPNLEnuItem.PDFIXASSET
                            lbl = lbl_p2ProDispPlantEq
                        Case TaxComPNLEnuItem.PDINVEST
                            lbl = lbl_p2ProDisInvestment
                        Case TaxComPNLEnuItem.FORINCREMIT
                            lbl = lbl_p2ForeIncomeRemmit

                        Case TaxComPNLEnuItem.REALFE
                            lbl = lbl_p2ReaForeExGainNonTrade
                        Case TaxComPNLEnuItem.UNREALFETRADE
                            lbl = lbl_p2UnreaGainForeEx
                        Case TaxComPNLEnuItem.UNREALFENONTRADE
                            lbl = lbl_p2UnreaGainForeExNon

                        Case TaxComPNLEnuItem.EXPOTHERINTEREST
                            lbl = lbl_p3OtherInterestExHirePur
                        Case TaxComPNLEnuItem.EXPLEGAL
                            lbl = lbl_p3ProTechManLeganFees
                        Case TaxComPNLEnuItem.EXPTECHNICAL
                            lbl = lbl_p3TechPayNonResis
                        Case TaxComPNLEnuItem.EXPCONTRACTPAY
                            lbl = lbl_p3ContractPay
                        Case TaxComPNLEnuItem.EXPDIRECTORFEE
                            lbl = lbl_p3DirectorFee
                        Case TaxComPNLEnuItem.EXPSALARY
                            lbl = lbl_p3Salary
                        Case TaxComPNLEnuItem.EXPEMPLOYEESTOCK
                            lbl = lbl_p3COEStock
                        Case TaxComPNLEnuItem.EXPROYALTY
                            lbl = lbl_p3Royalty
                        Case TaxComPNLEnuItem.EXPRENTAL
                            lbl = lbl_p3Rental
                        Case TaxComPNLEnuItem.EXPREPAIRMAINTENANCE
                            lbl = lbl_p3RepairMain
                        Case TaxComPNLEnuItem.EXPRND
                            lbl = lbl_p3ResearchDev
                        Case TaxComPNLEnuItem.EXPADVERTISEMENT
                            lbl = lbl_p3PromotionAds
                        Case TaxComPNLEnuItem.EXPTRAVEL
                            lbl = lbl_p3Travelling
                        Case TaxComPNLEnuItem.EXPJKDM
                            lbl = lbl_p3JKDM
                        Case TaxComPNLEnuItem.EXPDEPRECIATION
                            lbl = lbl_p3Depreciation
                        Case TaxComPNLEnuItem.EXPDONATIONAPPR
                            lbl = lbl_p3DonationApp
                        Case TaxComPNLEnuItem.EXPDONATIONAPPR
                            lbl = lbl_p3DonationApp
                        Case TaxComPNLEnuItem.EXPDONATIONNONAPPR
                            lbl = lbl_p3DonationNonApp
                        Case TaxComPNLEnuItem.EXPZAKAT
                            lbl = lbl_p3Zakat
                        Case TaxComPNLEnuItem.EXPLOSSDISPFA
                            lbl = lbl_p4LossDispFA
                        Case TaxComPNLEnuItem.EXPENTERTAINNONSTAFF
                            lbl = lbl_p4EntNonStaff
                        Case TaxComPNLEnuItem.EXPENTERTAINSTAFF
                            lbl = lbl_p4EntStaff
                        Case TaxComPNLEnuItem.EXPCOMPAUNDPENALTY
                            lbl = lbl_p4Compound
                        Case TaxComPNLEnuItem.EXPPROVISION
                            lbl = lbl_p4ProvisionAcc
                        Case TaxComPNLEnuItem.EXPLEAVEPASSAGE
                            lbl = lbl_p4LeavePass
                        Case TaxComPNLEnuItem.EXPFAWRITTENOFF
                            lbl = lbl_p4FAWrittenOff
                        Case TaxComPNLEnuItem.EXPUNREALLOSSFE
                            lbl = lbl_p4UnreaLossForeEx
                        Case TaxComPNLEnuItem.EXPREALLOSSFETRADE
                            lbl = lbl_p4ReaLossForeExTrade
                        Case TaxComPNLEnuItem.EXPREALLOSSFENONTRADE
                            lbl = lbl_p4ReaLossForeExNonTrade
                        Case TaxComPNLEnuItem.EXPINITIALSUBSCRIPT
                            lbl = lbl_p4InitSub
                        Case TaxComPNLEnuItem.EXPCAPITALEXPENDITURE
                            lbl = lbl_p4CAExpenditure
                        Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
                            lbl = lbl_p4Other
                        Case TaxComPNLEnuItem.RENTALINC
                            lbl = lbl_p2RentalIncome
                        Case TaxComPNLEnuItem.NONALLOWABLEEXPENSES
                            lbl = lblP4NonAllowableExpenses
                        Case TaxComPNLEnuItem.OTHERNONTAXINC
                            lbl = lbl_p2Other
                        Case TaxComPNLEnuItem.EXEMDIV
                            lbl = lbl_p2ExemptDividend
                        Case TaxComPNLEnuItem.INTERESTRESTRICT
                            lbl = lbl_p3InterestResPurS33
                        Case TaxComPNLEnuItem.DIVIDENDINC
                            lbl = lbl_p2DivIncome
                    End Select
                    DetailsClick(lbl, tmp.Type)
                    CurrentProgress += 0.8
                    Progress(CurrentProgress, "Initialize " & tmp.LabelTricor & " data...")
                    Application.DoEvents()

                Next
                Application.DoEvents()
                DocumentManager1.View.Controller.CloseAll()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadData()
        Try
            ProgressPanel1.Visible = True
            Me.Text = "Profit and Loss - New"
            Application.DoEvents()

            GC.Collect()
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
            ClearMemoryDataset()

            UcPNL_Import1.MainData = dsDataSet

            If isEdit = False Then

                cboS60FA.EditValue = "No"

                cboRefNo.EditValue = mdlProcess.ArgParam2
                cboYA.EditValue = mdlProcess.ArgParam3

                cboRefNo.Edit.ReadOnly = False
                cboYA.Edit.ReadOnly = False
                cboMainSource.Edit.ReadOnly = False

                InitDockingSystem(0)
                Application.DoEvents()
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

                Dim CurrentProgress As Decimal = 5
                pnlProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                XtraTabControl1.Enabled = False
                RibbonControl1.Enabled = False
                Application.DoEvents()

                Me.Text = "Profit and Loss - Edit"

                cboRefNo.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_REF_NO")), "", dtPNL.Rows(0)("PL_REF_NO"))
                cboYA.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_YA")), "", dtPNL.Rows(0)("PL_YA"))
                Application.DoEvents()
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

                'txt_p1Sales.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_SALES")), 0, dtPNL.Rows(0)("PL_SALES"))
                'txt_p1OpenStock.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OP_STK")), 0, dtPNL.Rows(0)("PL_OP_STK"))
                'txt_p1Purchase.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_PURCHASES")), 0, dtPNL.Rows(0)("PL_PURCHASES"))
                'txt_p1COP.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_PRO_COST")), 0, dtPNL.Rows(0)("PL_PRO_COST")) '///
                'txt_p1Depreciation.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_PRO_COST_DPC")), 0, dtPNL.Rows(0)("PL_PRO_COST_DPC"))
                'txt_p1AllowanceExpenses.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_PRO_COST_OAE")), 0, dtPNL.Rows(0)("PL_PRO_COST_OAE"))
                'txt_p1NonAllowableExpenses.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_PRO_COST_ONAE")), 0, dtPNL.Rows(0)("PL_PRO_COST_ONAE"))
                'txt_p1PCP.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_PURCHASES_PRO_COST")), 0, dtPNL.Rows(0)("PL_PURCHASES_PRO_COST")) '///
                'txt_p1CloseStock.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_CLS_STK")), 0, dtPNL.Rows(0)("PL_CLS_STK"))
                'txt_p1COS.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_COGS")), 0, dtPNL.Rows(0)("PL_COGS"))
                'txt_p1GrossProfitLoss.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_GROSS_PROFIT")), 0, dtPNL.Rows(0)("PL_GROSS_PROFIT"))
                'txt_p2OtherBizIncome.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTH_BSIN")), 0, dtPNL.Rows(0)("PL_OTH_BSIN"))
                'txt_p2UnreaGainForeEx.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTH_BSIN_UNREALGT")), 0, dtPNL.Rows(0)("PL_OTH_BSIN_UNREALGT"))
                'txt_p2ForeignCurrExGain.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTH_BSIN_REALGT")), 0, dtPNL.Rows(0)("PL_OTH_BSIN_REALGT"))
                'txt_p2NonBizIncome.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTH_IN")), 0, dtPNL.Rows(0)("PL_OTH_IN"))
                'txt_p2DivIncome.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTH_IN_DIVIDEND")), 0, dtPNL.Rows(0)("PL_OTH_IN_DIVIDEND"))
                'txt_p2InterestIncome.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTH_IN_INTEREST")), 0, dtPNL.Rows(0)("PL_OTH_IN_INTEREST"))
                'txt_p2RentalIncome.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTH_IN_RENTAL")), 0, dtPNL.Rows(0)("PL_OTH_IN_RENTAL"))
                'txt_p2RoyaltyIncome.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTH_IN_ROYALTY")), 0, dtPNL.Rows(0)("PL_OTH_IN_ROYALTY"))
                'txt_p2OtherIncome.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTH_IN_OTHER")), 0, dtPNL.Rows(0)("PL_OTH_IN_OTHER"))
                'txt_p2NonTaxProfit.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_NONTAX_IN")), 0, dtPNL.Rows(0)("PL_NONTAX_IN"))
                'txt_p2ProDispPlantEq.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_NONTAX_IN_FA_DISP")), 0, dtPNL.Rows(0)("PL_NONTAX_IN_FA_DISP"))
                'txt_p2ProDisInvestment.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_NONTAX_IN_INV_DISP")), 0, dtPNL.Rows(0)("PL_NONTAX_IN_INV_DISP"))
                'txt_p2ExemptDividend.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_NONTAX_IN_EXM_DIV")), 0, dtPNL.Rows(0)("PL_NONTAX_IN_EXM_DIV"))
                'txt_p2ForeIncomeRemmit.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_NONTAX_IN_FIR")), 0, dtPNL.Rows(0)("PL_NONTAX_IN_FIR"))
                'txt_p2ReaForeExGainNonTrade.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_NONTAX_IN_REALG")), 0, dtPNL.Rows(0)("PL_NONTAX_IN_REALG"))
                'txt_p2UnreaGainForeExNon.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_NONTAX_IN_UNREALG")), 0, dtPNL.Rows(0)("PL_NONTAX_IN_UNREALG"))
                'txt_p2Other.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_NONTAX_IN_INSU_COMP")), 0, dtPNL.Rows(0)("PL_NONTAX_IN_INSU_COMP"))
                'txt_p3InterestResPurS33.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_EXP_INT")), 0, dtPNL.Rows(0)("PL_EXP_INT")) '///
                'txt_p3ProTechManLeganFees.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_LAWYER_COST")), 0, dtPNL.Rows(0)("PL_LAWYER_COST"))
                'txt_p3ContractPay.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_CONTRACT_EXP")), 0, dtPNL.Rows(0)("PL_CONTRACT_EXP"))
                'txt_p3Salary.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_EXP_SALARY")), 0, dtPNL.Rows(0)("PL_EXP_SALARY"))
                'txt_p3Royalty.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_ROYALTY")), 0, dtPNL.Rows(0)("PL_ROYALTY"))
                'txt_p3Rental.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_EXP_RENT")), 0, dtPNL.Rows(0)("PL_EXP_RENT"))
                'txt_p3RepairMain.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_EXP_MAINTENANCE")), 0, dtPNL.Rows(0)("PL_EXP_MAINTENANCE"))
                'txt_p3ResearchDev.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_RND")), 0, dtPNL.Rows(0)("PL_RND"))
                'txt_p3PromotionAds.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_ADVERT")), 0, dtPNL.Rows(0)("PL_ADVERT"))
                'txt_p3Travelling.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_TRAVEL")), 0, dtPNL.Rows(0)("PL_TRAVEL"))
                'txt_p4TotalOtherExpenses.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP")), 0, dtPNL.Rows(0)("PL_OTHER_EXP"))
                'txt_p3Depreciation.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_DPC")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_DPC"))
                'txt_p3DonationApp.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_DNT_APP")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_DNT_APP"))
                'txt_p3DonationNonApp.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_DNT_NAPP")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_DNT_NAPP"))
                'txt_p4LossDispFA.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_FA_DISP")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_FA_DISP"))
                'txt_p4EntNonStaff.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_ENTM_CLNT")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_ENTM_CLNT"))
                'txt_p4EntStaff.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_ENTM_STFF")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_ENTM_STFF"))
                'txt_p4Compound.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_PENALTY")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_PENALTY"))
                'txt_p4ProvisionAcc.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_PROV_ACC")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_PROV_ACC"))
                'txt_p4LeavePass.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_LEAVE")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_LEAVE"))
                'txt_p4FAWrittenOff.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_FA_WO")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_FA_WO"))
                'txt_p4UnreaLossForeEx.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_UNREALOSS")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_UNREALOSS"))
                'txt_p4ReaLossForeExTrade.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_REALOSS")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_REALOSS"))
                'txt_p4InitSub.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_INI_SUB")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_INI_SUB"))
                'txt_p4CAExpenditure.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_CAP_EXP")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_CAP_EXP"))
                'txt_p4Other.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_OTHERS")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_OTHERS"))
                'txt_p4TotalExpenses.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_TOT_EXP")), 0, dtPNL.Rows(0)("PL_TOT_EXP"))
                'txt_p4NetProfitLoss.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_NET_PROFIT_LOSS")), 0, dtPNL.Rows(0)("PL_NET_PROFIT_LOSS"))
                ''txt_p4NonAllowableExpenses.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_DISALLOWED_EXP")), 0, dtPNL.Rows(0)("PL_DISALLOWED_EXP"))
                'txt_p3InterestResPurS33.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_EXP_INTRESTRICT")), 0, dtPNL.Rows(0)("PL_EXP_INTRESTRICT")) '///
                'txt_p2OtherBizIncome.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTH_BSIN_NONSOURCE")), 0, dtPNL.Rows(0)("PL_OTH_BSIN_NONSOURCE"))
                'txt_p3Zakat.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_ZAKAT")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_ZAKAT"))
                'txt_p3TechPayNonResis.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_TECH_FEE")), 0, dtPNL.Rows(0)("PL_TECH_FEE"))
                'txt_p3COEStock.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_EMPL_STOCK")), 0, dtPNL.Rows(0)("PL_EMPL_STOCK"))
                'txt_p4OtherBalacingFigure.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXP_BALANCE")), 0, dtPNL.Rows(0)("PL_OTHER_EXP_BALANCE"))
                'txt_p4ReaLossForeExNonTrade.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_OTHER_EXRLOSSFOREIGNT")), 0, dtPNL.Rows(0)("PL_OTHER_EXRLOSSFOREIGNT"))
                'txt_p3DirectorFee.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_DIRECTORS_FEE")), 0, dtPNL.Rows(0)("PL_DIRECTORS_FEE"))
                'txt_p3JKDM.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_JKDM")), 0, dtPNL.Rows(0)("PL_JKDM"))
                txt_p4ExpectedExpenses.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_TOT_EXP")), 0, dtPNL.Rows(0)("PL_TOT_EXP"))
                CurrentProgress += 5
                Dim listofclsPNLLabel As List(Of clsPNL_LabelName) = GetPNLLabelName()

                If listofclsPNLLabel IsNot Nothing Then
                    For Each tmp As clsPNL_LabelName In listofclsPNLLabel
                        'If mdlProcess.isVersionLicenseType = VersionLicenseType.Tricor Then
                        '    Progress(CurrentProgress, "Getting " & tmp.LabelTricor & " data...")
                        'Else
                        '    Progress(CurrentProgress, "Getting " & tmp.LabelText & " data...")
                        'End If
                        If tmp.Type = TaxComPNLEnuItem.EXPOTHERSEXPENSES Then
                            Dim x As String = Nothing

                        End If
                        CurrentProgress += 1
                        mdlPNL2.PNL_GetData(ID, tmp.Type, txtRefNo.EditValue, cboYA.EditValue, dsDataSet, ErrorLog)
                        Progress(CurrentProgress, "Loading " & tmp.LabelTricor & " data...")
                        Application.DoEvents()

                    Next
                End If

                Application.DoEvents()
                InitDockingSystem(CurrentProgress)
                Application.DoEvents()

                If listofclsPNLLabel IsNot Nothing Then
                    Dim txtamount As DevExpress.XtraEditors.TextEdit
                    For Each tmp As clsPNL_LabelName In listofclsPNLLabel
                        GetTxtAmount(tmp.Type, txtamount)
                        mdlPNL2.PNL_ReCalcAll_Amount(tmp.Type, dsDataSet, txtamount, ErrorLog)
                        'CalcTotalofView(txtAmount, DsPNL1, MainTable, MainAmount, 0, ErrorLog)
                    Next
                End If




                txt_p4NonAllowableExpenses.EditValue = mdlPNL.GetNonAllowanbleExpenses(dsDataSet, ErrorLog)

            End If


        Catch ex As Exception

        Finally
            RibbonControl1.Enabled = True
            XtraTabControl1.Enabled = True
            ProgressPanel1.Visible = False
            pnlProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End Try
    End Sub
    Private Sub DetailsClick(ByVal lbl As DevExpress.XtraEditors.LabelControl, Optional ByVal Type As mdlEnum.TaxComPNLEnuItem = TaxComPNLEnuItem.SALES)
        Try
            Dim doc As New DevExpress.XtraBars.Docking.DockPanel
            Dim txtamount As DevExpress.XtraEditors.TextEdit

            GetTxtAmount(Type, txtamount)

            If cboRefNo Is Nothing OrElse cboYA Is Nothing OrElse cboRefNo.EditValue.ToString = "" OrElse cboYA.EditValue.ToString = "" Then
                MsgBox("Please select tax payer and ya first.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Application.DoEvents()
            mdlPNL.ViewPNL(Type, Me.DockManager1, Me.DocumentManager1, lbl, txtamount, TabbedView1, cboRefNo.EditValue, cboYA.EditValue, ErrorLog, txt_p1Sales, cboMainSource.EditValue, cboMainSource)
            Application.DoEvents()
            '.View.AddDocument(doc)

        Catch ex As Exception

        End Try
    End Sub
    Private Function GetTxtAmount(ByVal type As TaxComPNLEnuItem, ByRef txtAmount As DevExpress.XtraEditors.TextEdit)
        Try
            Select Case type
                Case TaxComPNLEnuItem.SALES
                    txtAmount = txt_p1Sales
                Case TaxComPNLEnuItem.OPENSTOCK
                    txtAmount = txt_p1OpenStock
                Case TaxComPNLEnuItem.PURCHASE
                    txtAmount = txt_p1Purchase
                Case TaxComPNLEnuItem.DEPRECIATION
                    txtAmount = txt_p1Depreciation
                Case TaxComPNLEnuItem.OTHERALLOWEXP
                    txtAmount = txt_p1AllowanceExpenses
                Case TaxComPNLEnuItem.OTHERNONALLOWEXP
                    txtAmount = txt_p1NonAllowableExpenses
                Case TaxComPNLEnuItem.CLOSESTOCK
                    txtAmount = txt_p1CloseStock
                Case TaxComPNLEnuItem.OTHERBUSINC
                    txtAmount = txt_p2OtherBizIncome
                Case TaxComPNLEnuItem.REALFETRADE
                    txtAmount = txt_p2ForeignCurrExGain
                Case TaxComPNLEnuItem.INTERESTINC
                    txtAmount = txt_p2InterestIncome
                Case TaxComPNLEnuItem.ROYALTYINC
                    txtAmount = txt_p2RoyaltyIncome
                Case TaxComPNLEnuItem.OTHERINC
                    txtAmount = txt_p2OtherIncome
                Case TaxComPNLEnuItem.PDFIXASSET
                    txtAmount = txt_p2ProDispPlantEq
                Case TaxComPNLEnuItem.PDINVEST
                    txtAmount = txt_p2ProDisInvestment
                Case TaxComPNLEnuItem.FORINCREMIT
                    txtAmount = txt_p2ForeIncomeRemmit


                Case TaxComPNLEnuItem.REALFE
                    txtAmount = txt_p2ReaForeExGainNonTrade
                Case TaxComPNLEnuItem.UNREALFETRADE
                    txtAmount = txt_p2UnreaGainForeEx
                Case TaxComPNLEnuItem.UNREALFENONTRADE 'azham ====================
                    txtAmount = txt_p2UnreaGainForeExNon

                Case TaxComPNLEnuItem.EXPOTHERINTEREST
                    txtAmount = txt_p3OtherInterestExHirePur
                Case TaxComPNLEnuItem.EXPLEGAL
                    txtAmount = txt_p3ProTechManLeganFees
                Case TaxComPNLEnuItem.EXPTECHNICAL
                    txtAmount = txt_p3TechPayNonResis
                Case TaxComPNLEnuItem.EXPCONTRACTPAY
                    txtAmount = txt_p3ContractPay
                Case TaxComPNLEnuItem.EXPDIRECTORFEE
                    txtAmount = txt_p3DirectorFee
                Case TaxComPNLEnuItem.EXPSALARY
                    txtAmount = txt_p3Salary
                Case TaxComPNLEnuItem.EXPEMPLOYEESTOCK
                    txtAmount = txt_p3COEStock
                Case TaxComPNLEnuItem.EXPROYALTY
                    txtAmount = txt_p3Royalty
                Case TaxComPNLEnuItem.EXPRENTAL
                    txtAmount = txt_p3Rental
                Case TaxComPNLEnuItem.EXPREPAIRMAINTENANCE
                    txtAmount = txt_p3RepairMain
                Case TaxComPNLEnuItem.EXPRND
                    txtAmount = txt_p3ResearchDev
                Case TaxComPNLEnuItem.EXPADVERTISEMENT
                    txtAmount = txt_p3PromotionAds
                Case TaxComPNLEnuItem.EXPTRAVEL
                    txtAmount = txt_p3Travelling
                Case TaxComPNLEnuItem.EXPJKDM
                    txtAmount = txt_p3JKDM
                Case TaxComPNLEnuItem.EXPDEPRECIATION
                    txtAmount = txt_p3Depreciation
                Case TaxComPNLEnuItem.EXPDONATIONAPPR
                    txtAmount = txt_p3DonationApp
                Case TaxComPNLEnuItem.EXPDONATIONAPPR
                    txtAmount = txt_p3DonationApp
                Case TaxComPNLEnuItem.EXPDONATIONNONAPPR
                    txtAmount = txt_p3DonationNonApp
                Case TaxComPNLEnuItem.EXPZAKAT
                    txtAmount = txt_p3Zakat
                Case TaxComPNLEnuItem.EXPLOSSDISPFA
                    txtAmount = txt_p4LossDispFA
                Case TaxComPNLEnuItem.EXPENTERTAINNONSTAFF
                    txtAmount = txt_p4EntNonStaff
                Case TaxComPNLEnuItem.EXPENTERTAINSTAFF
                    txtAmount = txt_p4EntStaff
                Case TaxComPNLEnuItem.EXPCOMPAUNDPENALTY
                    txtAmount = txt_p4Compound
                Case TaxComPNLEnuItem.EXPPROVISION
                    txtAmount = txt_p4ProvisionAcc
                Case TaxComPNLEnuItem.EXPLEAVEPASSAGE
                    txtAmount = txt_p4LeavePass
                Case TaxComPNLEnuItem.EXPFAWRITTENOFF
                    txtAmount = txt_p4FAWrittenOff
                Case TaxComPNLEnuItem.EXPUNREALLOSSFE
                    txtAmount = txt_p4UnreaLossForeEx
                Case TaxComPNLEnuItem.EXPREALLOSSFETRADE
                    txtAmount = txt_p4ReaLossForeExTrade
                Case TaxComPNLEnuItem.EXPREALLOSSFENONTRADE
                    txtAmount = txt_p4ReaLossForeExNonTrade
                Case TaxComPNLEnuItem.EXPINITIALSUBSCRIPT
                    txtAmount = txt_p4InitSub
                Case TaxComPNLEnuItem.EXPCAPITALEXPENDITURE
                    txtAmount = txt_p4CAExpenditure
                Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
                    txtAmount = txt_p4Other
                Case TaxComPNLEnuItem.RENTALINC
                    txtAmount = txt_p2RentalIncome
                Case TaxComPNLEnuItem.NONALLOWABLEEXPENSES
                    txtAmount = txt_p4NonAllowableExpenses
                Case TaxComPNLEnuItem.OTHERNONTAXINC
                    txtAmount = txt_p2Other
                Case TaxComPNLEnuItem.EXEMDIV
                    txtAmount = txt_p2ExemptDividend
                Case TaxComPNLEnuItem.INTERESTRESTRICT
                    txtAmount = txt_p3InterestResPurS33
                Case TaxComPNLEnuItem.DIVIDENDINC
                    txtAmount = txt_p2DivIncome
            End Select
        Catch ex As Exception
            txtAmount = txt_p2DivIncome
        End Try
    End Function
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

            If dsDataSet.Tables("PROFIT_LOSS_ACCOUNT") IsNot Nothing Then
                dsDataSet.Tables("PROFIT_LOSS_ACCOUNT").Rows.Clear()
            End If
            Dim tmpID As Integer = 0
            Dim dtrow As DataRow = Nothing
            If isEdit Then
                'edit
                Progress(4, "Saving new PNL data...")

                dtrow = dsDataSet.Tables("PROFIT_LOSS_ACCOUNT").NewRow
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

                '   dtrow("PL_OTH_BSIN_UNREALGT") = IIf(IsDBNull(txt_p2UnreaGainForeEx.EditValue), 0, txt_p2UnreaGainForeEx.EditValue)
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
                ' dtrow("PL_NONTAX_IN_REALG") = IIf(IsDBNull(txt_p2UnreaGainForeExNon.EditValue), 0, txt_p2UnreaGainForeExNon.EditValue)

                dtrow("PL_NONTAX_IN_REALG") = IIf(IsDBNull(txt_p2ReaForeExGainNonTrade.EditValue), 0, txt_p2ReaForeExGainNonTrade.EditValue)
                dtrow("PL_OTH_BSIN_UNREALGT") = IIf(IsDBNull(txt_p2UnreaGainForeEx.EditValue), 0, txt_p2UnreaGainForeEx.EditValue)
                dtrow("PL_NONTAX_IN_UNREALG") = IIf(IsDBNull(txt_p2UnreaGainForeExNon.EditValue), 0, txt_p2UnreaGainForeExNon.EditValue)

                ' dtrow("PL_NONTAX_IN_UNREALG") = IIf(IsDBNull(txt_p2ReaForeExGainNonTrade.EditValue), 0, txt_p2ReaForeExGainNonTrade.EditValue)
                dtrow("PL_NONTAX_IN_INSU_COMP") = IIf(IsDBNull(txt_p2Other.EditValue), 0, txt_p2Other.EditValue)
                dtrow("PL_EXP_INT") = IIf(IsDBNull(txt_p3OtherInterestExHirePur.EditValue), 0, txt_p3OtherInterestExHirePur.EditValue)
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

                dsDataSet.Tables("PROFIT_LOSS_ACCOUNT").Rows.Add(dtrow)

                mdlProcess.Update_ProfitAndLoss_Query(dsDataSet.Tables("PROFIT_LOSS_ACCOUNT"), ListofCmd, ErrorLog)

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

                dtrow = dsDataSet.Tables("PROFIT_LOSS_ACCOUNT").NewRow

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

                dtrow("PL_NONTAX_IN_REALG") = IIf(IsDBNull(txt_p2ReaForeExGainNonTrade.EditValue), 0, txt_p2UnreaGainForeExNon.EditValue)
                dtrow("PL_OTH_BSIN_UNREALGT") = IIf(IsDBNull(txt_p2UnreaGainForeEx.EditValue), 0, txt_p2UnreaGainForeEx.EditValue)
                dtrow("PL_NONTAX_IN_UNREALG") = IIf(IsDBNull(txt_p2UnreaGainForeExNon.EditValue), 0, txt_p2ReaForeExGainNonTrade.EditValue)

                dtrow("PL_NONTAX_IN_INSU_COMP") = IIf(IsDBNull(txt_p2Other.EditValue), 0, txt_p2Other.EditValue)
                dtrow("PL_EXP_INT") = IIf(IsDBNull(txt_p3OtherInterestExHirePur.EditValue), 0, txt_p3OtherInterestExHirePur.EditValue)
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

                dsDataSet.Tables("PROFIT_LOSS_ACCOUNT").Rows.Add(dtrow)

                mdlProcess.Save_ProfitAndLoss_Query(dsDataSet.Tables("PROFIT_LOSS_ACCOUNT"), ListofCmd, ErrorLog)

                Progress(6, "trying to connect with database...")

                If mdlProcess.DBConnection(sqlCon, ErrorLog) = False Then
                    Progress(0, "Failed to connect with database.")
                    MsgBox("Failed to connect with database.", MsgBoxStyle.Critical)
                    Exit Sub
                End If

            End If

            mdlProcess.Delete_PNLItem(ListofCmd, tmpID, ErrorLog)

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

                    If tmp.Type = TaxComPNLEnuItem.DIVIDENDINC Then
                        Dim x As Integer = 0
                    End If

                    mdlPNL2.PNL_GetSaveData(tmpID, tmp.Type, Nothing, ListofCmd, ErrorLog)
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
                    If mdlRefreshTaxComputation.RefreshTaxcom(cboRefNo.EditValue, cboYA.EditValue, ErrorLog) = False Then
                        MsgBox("Error to recalculate tax computation.", MsgBoxStyle.Critical)

                    End If
                Else
                    Progress(100, "Failed to saving " & ListofCmd.Count & " data(s)...")
                    MsgBox("Failed to save data." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)

                End If
            End If


        Catch ex As Exception
            If ErrorLog IsNot Nothing Then
                MsgBox(ErrorLog.ErrorMessage)
            End If
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
            Dim obj As Object = dsDataSet.Tables("DIVIDEND_INCOME").Compute("sum('di_taxdeduction')", "")

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
    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged, cboYA.EditValueChanged
        Try
            If cboRefNo IsNot Nothing AndAlso cboRefNo.EditValue.ToString <> "" AndAlso cboYA IsNot Nothing AndAlso cboYA.EditValue.ToString <> "" Then
                txtRefNo.EditValue = cboRefNo.EditValue
                mdlProcess.CreateLookUpSourceNO(dsDataSet, cboRefNo.EditValue, cboYA.EditValue, "BUSINESS_SOURCE", ErrorLog)
                mdlProcess.CreateLookUpSourceNO(dsDataSet, cboRefNo.EditValue, cboYA.EditValue, "BUSINESS_SOURCE", ErrorLog)
                Application.DoEvents()
                BUSINESSSOURCEBindingSource.DataSource = dsDataSet.Tables("BUSINESS_SOURCE")

                For i As Integer = 0 To dsDataSet.Tables("BUSINESS_SOURCE").Rows.Count - 1
                    If i = 0 Then
                        cboMainSource.EditValue = dsDataSet.Tables("BUSINESS_SOURCE").Rows(i)("BC_SOURCENO")
                    End If
                Next
                'If isEdit = False Then
                '    'Dim editor As DevExpress.XtraEditors.ComboBoxEdit
                '    'editor = CType(cboMainSource, DevExpress.XtraEditors.ComboBoxEdit)
                '    '' editor = TryCast(cboMainSource, DevExpress.XtraEditors.ComboBoxEdit)
                '    'editor.SelectedIndex = 0
                '    For i As Integer = 0 To dsDataSet.Tables("BUSINESS_SOURCE").Rows.Count - 1
                '        If i = 0 Then
                '            cboMainSource.EditValue = dsDataSet.Tables("BUSINESS_SOURCE").Rows(i)("BC_SOURCENO")
                '        End If
                '    Next

                'End If
                If mdlProcess.VerifyInvestmentHolding(cboRefNo.EditValue, cboYA.EditValue, ErrorLog) Then
                    cboS60F.Edit.ReadOnly = True
                    cboS60F.EditValue = "Yes"
                Else
                    cboS60F.Edit.ReadOnly = False
                    cboS60F.EditValue = "No"
                End If

                pnlDocInformation.Enabled = True
            Else
                pnlDocInformation.Enabled = False
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
            pnlDocImport.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible

            'OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;"

            'Dim rslt As DialogResult = OpenFileDialog1.ShowDialog

            'If rslt = Windows.Forms.DialogResult.OK Then

            '    Dim Path As String = OpenFileDialog1.FileName

            '    If System.IO.File.Exists(Path) = False Then
            '        MsgBox("File not exist, please select correct file.", MsgBoxStyle.Exclamation)
            '        Exit Sub
            '    End If
            '    Dim connectionString As String = String.Format("Provider=Microsoft.ACE.OLEDB.12.0; data source={0}; Extended Properties=Excel 12.0;", OpenFileDialog1.FileName)
            '    Dim adapter = New OleDbDataAdapter("select * from [Sheet$]", connectionString)
            '    Dim ds = New DataSet()
            '    Dim dsControl As DataSet
            '    Dim tableName As String = "Sheet"
            '    adapter.Fill(ds, tableName)

            '    Dim Status As Boolean = False
            '    Dim PnlType As mdlEnum.TaxComPNLEnuItem = TaxComPNLEnuItem.CLOSESTOCK
            '    Dim contrl As Control = Nothing
            '    Dim ParentID As Integer = 0
            '    Dim dtRow As DataRow = Nothing
            '    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
            '        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            '            If IsDBNull(ds.Tables(0).Rows(i)("Type")) = False AndAlso ds.Tables(0).Rows(i)("Type") IsNot Nothing Then
            '                PnlType = DirectCast([Enum].Parse(GetType(mdlEnum.TaxComPNLEnuItem), ds.Tables(0).Rows(i)("Type")), mdlEnum.TaxComPNLEnuItem)

            '                Select Case PnlType
            '                    Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
            '                        If p4_docOther IsNot Nothing AndAlso p4_docOther.Controls.Count > 0 Then
            '                            contrl = p4_docOther.Controls(0)

            '                            If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4Other = False Then
            '                                Exit Sub
            '                            End If
            '                            Dim uc As ucPNL_p4Other = CType(contrl, ucPNL_p4Other)

            '                            dsControl = uc.DataView_Main

            '                            If dsControl IsNot Nothing Then
            '                                If IsDBNull(ds.Tables(0).Rows(i)("Description")) = False OrElse ds.Tables(0).Rows(i)("Description") IsNot Nothing Then

            '                                    dtRow = dsControl.Tables(uc.MainTable_Details).NewRow
            '                                    ParentID = dsControl.Tables(uc.MainTable).Rows.Count + 1

            '                                    dtRow("EXO_KEY") = 0
            '                                    dtRow("EXO_EXOKEY") = ParentID
            '                                    dtRow("EXO_DESC") = ds.Tables(0).Rows(i)("Description")
            '                                    If IsNumeric(ds.Tables(0).Rows(i)("Description")) = True AndAlso CDec(ds.Tables(0).Rows(i)("Description")) > 0 Then
            '                                        dtRow("EXO_AMOUNT") = ds.Tables(0).Rows(i)("Debit Amount")
            '                                    Else
            '                                        dtRow("EXO_AMOUNT") = ds.Tables(0).Rows(i)("Credit Amount")
            '                                    End If
            '                                    dtRow("EXO_DEDUCTIBLE") = False
            '                                    dtRow("EXO_NOTE") = ""
            '                                    dtRow("EXO_SOURCENO") = cboMainSource.EditValue
            '                                    dtRow("EXO_DETAIL") = "No"
            '                                    dtRow("EXO_DEDUCTIBLE_ADD") = False
            '                                    dtRow("RowIndex") = 0
            '                                    dtRow("Pecentage") = 0

            '                                    dsControl.Tables(uc.MainTable_Details).Rows.Add(dtRow)

            '                                Else
            '                                    dtRow = dsControl.Tables(uc.MainTable).NewRow
            '                                    ParentID = dsControl.Tables(uc.MainTable).Rows.Count + 1

            '                                    dtRow("EXO_KEY") = 0
            '                                    dtRow("EXO_EXOKEY") = ParentID
            '                                    dtRow("EXO_DESC") = ds.Tables(0).Rows(i)("Description")
            '                                    If IsNumeric(ds.Tables(0).Rows(i)("Description")) = True AndAlso CDec(ds.Tables(0).Rows(i)("Description")) > 0 Then
            '                                        dtRow("EXO_AMOUNT") = ds.Tables(0).Rows(i)("Debit Amount")
            '                                    Else
            '                                        dtRow("EXO_AMOUNT") = ds.Tables(0).Rows(i)("Credit Amount")
            '                                    End If
            '                                    dtRow("EXO_DEDUCTIBLE") = False
            '                                    dtRow("EXO_NOTE") = ""
            '                                    dtRow("EXO_SOURCENO") = cboMainSource.EditValue
            '                                    dtRow("EXO_DETAIL") = "No"
            '                                    dtRow("EXO_DEDUCTIBLE_ADD") = False
            '                                    dtRow("RowIndex") = 0
            '                                    dtRow("Pecentage") = 0

            '                                    dsControl.Tables(uc.MainTable).Rows.Add(dtRow)
            '                                End If

            '                            End If

            '                            End If

            '                End Select

            '            End If

            '            ' mdlC_Process.Save_State(ds.Tables(0).Rows(i)("CT_CODE"), ds.Tables(0).Rows(i)("ST_DESC"), ErrorLog)
            '        Next
            '    End If
            'End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
        Try
            Dim rslt As DialogResult = FolderBrowserDialog1.ShowDialog
            Dim obj() As Object = Nothing
            Dim rowchild As DataRow = Nothing
            Dim ParentNo As Integer = 0
            If rslt = Windows.Forms.DialogResult.OK Then
                Dim Path As String = FolderBrowserDialog1.SelectedPath

                If System.IO.Directory.Exists(Path) = False Then
                    MsgBox("Directory not exist.", MsgBoxStyle.Critical)
                    Exit Sub
                End If



                If System.IO.File.Exists(Path & "\ExportPNL_" & cboRefNo.EditValue.ToString & "_" & cboYA.EditValue.ToString & ".xlsx") Then
                    Path = Path & "\ExportPNL_" & cboRefNo.EditValue.ToString & "_" & cboYA.EditValue.ToString & "_& " & Format(Now, "ddMMMyyyyHHmmss") & ".xlsx"
                Else
                    Path = Path & "\ExportPNL_" & cboRefNo.EditValue.ToString & "_" & cboYA.EditValue.ToString & ".xlsx"
                End If

                Dim contrl As Control = Nothing
                Dim ds As DataSet = Nothing
                Dim dtRow As DataRow = Nothing

                Dim listofclsPNLLabel As List(Of clsPNL_LabelName) = GetPNLLabelName()
                DsPNL2.Tables("ExportPNL").Rows.Clear()


                If P1_docDepreciation IsNot Nothing AndAlso P1_docDepreciation.Controls.Count > 0 Then
                    contrl = P1_docDepreciation.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1Depreciation = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p1Depreciation = CType(contrl, ucPNL_p1Depreciation)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.DEPRECIATION.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.DEPRECIATION.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If

                End If

                If P1_docSales IsNot Nothing AndAlso P1_docSales.Controls.Count > 0 Then
                    contrl = P1_docSales.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1Sales = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p1Sales = CType(contrl, ucPNL_p1Sales)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.SALES.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.SALES.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If

                End If


                If P1_docOpeningStock IsNot Nothing AndAlso P1_docOpeningStock.Controls.Count > 0 Then
                    contrl = P1_docOpeningStock.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1OpeningStock = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p1OpeningStock = CType(contrl, ucPNL_p1OpeningStock)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.OPENSTOCK.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.OPENSTOCK.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If

                End If

                If P1_docPurchase IsNot Nothing AndAlso P1_docPurchase.Controls.Count > 0 Then
                    contrl = P1_docPurchase.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1Purchase = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p1Purchase = CType(contrl, ucPNL_p1Purchase)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.PURCHASE.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.PURCHASE.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If

                End If

                If P1_docAllowanceExpenses IsNot Nothing AndAlso P1_docAllowanceExpenses.Controls.Count > 0 Then
                    contrl = P1_docAllowanceExpenses.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1AllowanceExpenses = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p1AllowanceExpenses = CType(contrl, ucPNL_p1AllowanceExpenses)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.OTHERALLOWEXP.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.OTHERALLOWEXP.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If

                End If


                If P1_docNonAllowableExpenses IsNot Nothing AndAlso P1_docNonAllowableExpenses.Controls.Count > 0 Then
                    contrl = P1_docNonAllowableExpenses.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1NonAllowableExpenses = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p1NonAllowableExpenses = CType(contrl, ucPNL_p1NonAllowableExpenses)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.OTHERNONALLOWEXP.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.OTHERNONALLOWEXP.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If

                End If

                If P1_docCloseStock IsNot Nothing AndAlso P1_docCloseStock.Controls.Count > 0 Then
                    contrl = P1_docCloseStock.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1CloseStock = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p1CloseStock = CType(contrl, ucPNL_p1CloseStock)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.CLOSESTOCK.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.CLOSESTOCK.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If

                End If

                If P2_docOtherBizIncome IsNot Nothing AndAlso P2_docOtherBizIncome.Controls.Count > 0 Then
                    contrl = P2_docOtherBizIncome.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2OtherBizIncome = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p2OtherBizIncome = CType(contrl, ucPNL_p2OtherBizIncome)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.OTHERBUSINC.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.OTHERBUSINC.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If

                End If

                If P2_docForeignCurrExGain IsNot Nothing AndAlso P2_docForeignCurrExGain.Controls.Count > 0 Then
                    contrl = P2_docForeignCurrExGain.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ForeignCurrExGain = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p2ForeignCurrExGain = CType(contrl, ucPNL_p2ForeignCurrExGain)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.REALFETRADE.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.REALFETRADE.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If

                End If

                If P2_docInterestIncome IsNot Nothing AndAlso P2_docInterestIncome.Controls.Count > 0 Then
                    contrl = P2_docInterestIncome.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2InterestIncome = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p2InterestIncome = CType(contrl, ucPNL_p2InterestIncome)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.INTERESTINC.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.INTERESTINC.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If

                End If


                If P2_docRentalIncome IsNot Nothing AndAlso P2_docRentalIncome.Controls.Count > 0 Then
                    contrl = P2_docRentalIncome.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2RentalIncome = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p2RentalIncome = CType(contrl, ucPNL_p2RentalIncome)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("Type") = TaxComPNLEnuItem.RENTALINC.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            dtRow("RightAmount") = 0
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                        Next
                    End If

                End If


                If P2_docRoyaltyIncome IsNot Nothing AndAlso P2_docRoyaltyIncome.Controls.Count > 0 Then
                    contrl = P2_docRoyaltyIncome.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2RoyaltyIncome = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p2RoyaltyIncome = CType(contrl, ucPNL_p2RoyaltyIncome)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.ROYALTYINC.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.ROYALTYINC.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If

                End If

                If P2_docOtherIncome IsNot Nothing AndAlso P2_docOtherIncome.Controls.Count > 0 Then
                    contrl = P2_docOtherIncome.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2OtherIncome = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p2OtherIncome = CType(contrl, ucPNL_p2OtherIncome)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.OTHERINC.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.OTHERINC.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If

                End If


                If P2_docProDispPlantEq IsNot Nothing AndAlso P2_docProDispPlantEq.Controls.Count > 0 Then
                    contrl = P2_docProDispPlantEq.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ProDispPlantEq = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p2ProDispPlantEq = CType(contrl, ucPNL_p2ProDispPlantEq)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.PDFIXASSET.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.PDFIXASSET.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If

                End If

                If P2_docProDisInvestment IsNot Nothing AndAlso P2_docProDisInvestment.Controls.Count > 0 Then
                    contrl = P2_docProDisInvestment.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ProDisInvestment = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p2ProDisInvestment = CType(contrl, ucPNL_p2ProDisInvestment)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.PDINVEST.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.PDINVEST.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If

                If P2_docExemptDividend IsNot Nothing AndAlso P2_docExemptDividend.Controls.Count > 0 Then
                    contrl = P2_docExemptDividend.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ExemptDividend = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p2ExemptDividend = CType(contrl, ucPNL_p2ExemptDividend)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("Type") = TaxComPNLEnuItem.EXEMDIV.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            dtRow("RightAmount") = 0
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                        Next
                    End If


                End If



                If P2_docForeIncomeRemmit IsNot Nothing AndAlso P2_docForeIncomeRemmit.Controls.Count > 0 Then
                    contrl = P2_docForeIncomeRemmit.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ForeIncomeRemmit = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p2ForeIncomeRemmit = CType(contrl, ucPNL_p2ForeIncomeRemmit)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.FORINCREMIT.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.FORINCREMIT.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If

                If P2_docUnreaGainForeEx IsNot Nothing AndAlso P2_docUnreaGainForeEx.Controls.Count > 0 Then
                    contrl = P2_docUnreaGainForeEx.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2UnreaGainForeEx = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p2UnreaGainForeEx = CType(contrl, ucPNL_p2UnreaGainForeEx)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.REALFE.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.REALFE.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If

                If P2_docReaForeExGainNonTrade IsNot Nothing AndAlso P2_docReaForeExGainNonTrade.Controls.Count > 0 Then
                    contrl = P2_docReaForeExGainNonTrade.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ReaForeExGainNonTrade = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p2ReaForeExGainNonTrade = CType(contrl, ucPNL_p2ReaForeExGainNonTrade)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.UNREALFENONTRADE.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.UNREALFENONTRADE.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If

                If P2_docUnreaGainForeExNon IsNot Nothing AndAlso P2_docUnreaGainForeExNon.Controls.Count > 0 Then
                    contrl = P2_docUnreaGainForeExNon.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2UnreaGainForeExNon = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p2UnreaGainForeExNon = CType(contrl, ucPNL_p2UnreaGainForeExNon)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.UNREALFETRADE.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.UNREALFETRADE.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If

                If P2_docOther IsNot Nothing AndAlso P2_docOther.Controls.Count > 0 Then
                    contrl = P2_docOther.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2Other = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p2Other = CType(contrl, ucPNL_p2Other)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.OTHERNONTAXINC.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.OTHERNONTAXINC.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If

                If P3_docInterestResPurS33 IsNot Nothing AndAlso P3_docInterestResPurS33.Controls.Count > 0 Then
                    contrl = P3_docInterestResPurS33.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3InterestResPurS33 = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p3InterestResPurS33 = CType(contrl, ucPNL_p3InterestResPurS33)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.INTERESTRESTRICT.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.INTERESTRESTRICT.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If P3_docOtherInterestExHirePur IsNot Nothing AndAlso P3_docOtherInterestExHirePur.Controls.Count > 0 Then
                    contrl = P3_docOtherInterestExHirePur.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3OtherInterestExHirePur = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p3OtherInterestExHirePur = CType(contrl, ucPNL_p3OtherInterestExHirePur)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPOTHERINTEREST.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPOTHERINTEREST.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If P3_docProTechManLeganFees IsNot Nothing AndAlso P3_docProTechManLeganFees.Controls.Count > 0 Then
                    contrl = P3_docProTechManLeganFees.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3ProTechManLeganFees = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p3ProTechManLeganFees = CType(contrl, ucPNL_p3ProTechManLeganFees)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPLEGAL.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPLEGAL.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If P3_docTechPayNonResis IsNot Nothing AndAlso P3_docTechPayNonResis.Controls.Count > 0 Then
                    contrl = P3_docTechPayNonResis.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3TechPayNonResis = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p3TechPayNonResis = CType(contrl, ucPNL_p3TechPayNonResis)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPTECHNICAL.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPTECHNICAL.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If P3_docContractPay IsNot Nothing AndAlso P3_docContractPay.Controls.Count > 0 Then
                    contrl = P3_docContractPay.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3ContractPay = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p3ContractPay = CType(contrl, ucPNL_p3ContractPay)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPCONTRACTPAY.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPCONTRACTPAY.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If P3_docDirectorFee IsNot Nothing AndAlso P3_docDirectorFee.Controls.Count > 0 Then
                    contrl = P3_docDirectorFee.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3DirectorFee = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p3DirectorFee = CType(contrl, ucPNL_p3DirectorFee)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPDIRECTORFEE.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPDIRECTORFEE.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If P3_docSalary IsNot Nothing AndAlso P3_docSalary.Controls.Count > 0 Then
                    contrl = P3_docSalary.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Salary = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p3Salary = CType(contrl, ucPNL_p3Salary)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPSALARY.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPSALARY.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If P3_docCOEStock IsNot Nothing AndAlso P3_docCOEStock.Controls.Count > 0 Then
                    contrl = P3_docCOEStock.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3COEStock = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p3COEStock = CType(contrl, ucPNL_p3COEStock)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPEMPLOYEESTOCK.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPEMPLOYEESTOCK.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If P3_docRoyalty IsNot Nothing AndAlso P3_docRoyalty.Controls.Count > 0 Then
                    contrl = P3_docRoyalty.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Royalty = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p3Royalty = CType(contrl, ucPNL_p3Royalty)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPROYALTY.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPROYALTY.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If P3_docRental IsNot Nothing AndAlso P3_docRental.Controls.Count > 0 Then
                    contrl = P3_docRental.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Rental = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p3Rental = CType(contrl, ucPNL_p3Rental)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPRENTAL.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPRENTAL.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If P3_docRepairMain IsNot Nothing AndAlso P3_docRepairMain.Controls.Count > 0 Then
                    contrl = P3_docRepairMain.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3RepairMain = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p3RepairMain = CType(contrl, ucPNL_p3RepairMain)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPREPAIRMAINTENANCE.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPREPAIRMAINTENANCE.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If

                End If


                If P3_docResearchDev IsNot Nothing AndAlso P3_docResearchDev.Controls.Count > 0 Then
                    contrl = P3_docResearchDev.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3ResearchDev = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p3ResearchDev = CType(contrl, ucPNL_p3ResearchDev)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPRND.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPRND.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If P3_docPromotionAds IsNot Nothing AndAlso P3_docPromotionAds.Controls.Count > 0 Then
                    contrl = P3_docPromotionAds.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3PromotionAds = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p3PromotionAds = CType(contrl, ucPNL_p3PromotionAds)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPADVERTISEMENT.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPADVERTISEMENT.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If P3_docTravelling IsNot Nothing AndAlso P3_docTravelling.Controls.Count > 0 Then
                    contrl = P3_docTravelling.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Travelling = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p3Travelling = CType(contrl, ucPNL_p3Travelling)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPTRAVEL.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPTRAVEL.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If P3_docJKDM IsNot Nothing AndAlso P3_docJKDM.Controls.Count > 0 Then
                    contrl = P3_docJKDM.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3JKDM = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p3JKDM = CType(contrl, ucPNL_p3JKDM)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPJKDM.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPJKDM.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If P3_docDepreciation IsNot Nothing AndAlso P3_docDepreciation.Controls.Count > 0 Then
                    contrl = P3_docDepreciation.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Depreciation = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p3Depreciation = CType(contrl, ucPNL_p3Depreciation)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPDEPRECIATION.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPDEPRECIATION.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If P3_docDonationApp IsNot Nothing AndAlso P3_docDonationApp.Controls.Count > 0 Then
                    contrl = P3_docDonationApp.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3DonationApp = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p3DonationApp = CType(contrl, ucPNL_p3DonationApp)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPDONATIONAPPR.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPDONATIONAPPR.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If P3_docDonationNonApp IsNot Nothing AndAlso P3_docDonationNonApp.Controls.Count > 0 Then
                    contrl = P3_docDonationNonApp.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3DonationNonApp = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p3DonationNonApp = CType(contrl, ucPNL_p3DonationNonApp)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPDONATIONNONAPPR.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPDONATIONNONAPPR.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If p3_docZakat IsNot Nothing AndAlso p3_docZakat.Controls.Count > 0 Then
                    contrl = p3_docZakat.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Zakat = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p3Zakat = CType(contrl, ucPNL_p3Zakat)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPZAKAT.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPZAKAT.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If

                End If


                If p4_docLossDispFA IsNot Nothing AndAlso p4_docLossDispFA.Controls.Count > 0 Then
                    contrl = p4_docLossDispFA.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4LossDispFA = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p4LossDispFA = CType(contrl, ucPNL_p4LossDispFA)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPLOSSDISPFA.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPLOSSDISPFA.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If



                If p4_docEntNonStaff IsNot Nothing AndAlso p4_docEntNonStaff.Controls.Count > 0 Then
                    contrl = p4_docEntNonStaff.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4EntNonStaff = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p4EntNonStaff = CType(contrl, ucPNL_p4EntNonStaff)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPENTERTAINNONSTAFF.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPENTERTAINNONSTAFF.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If p4_docEntStaff IsNot Nothing AndAlso p4_docEntStaff.Controls.Count > 0 Then
                    contrl = p4_docEntStaff.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4EntStaff = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p4EntStaff = CType(contrl, ucPNL_p4EntStaff)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPENTERTAINSTAFF.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPENTERTAINSTAFF.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If p4_docCompound IsNot Nothing AndAlso p4_docCompound.Controls.Count > 0 Then
                    contrl = p4_docCompound.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4Compound = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p4Compound = CType(contrl, ucPNL_p4Compound)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPCOMPAUNDPENALTY.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPCOMPAUNDPENALTY.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If

                If p4_docProvisionAcc IsNot Nothing AndAlso p4_docProvisionAcc.Controls.Count > 0 Then
                    contrl = p4_docProvisionAcc.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4ProvisionAcc = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p4ProvisionAcc = CType(contrl, ucPNL_p4ProvisionAcc)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPPROVISION.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPPROVISION.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If

                If p4_docLeavePass IsNot Nothing AndAlso p4_docLeavePass.Controls.Count > 0 Then
                    contrl = p4_docLeavePass.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4LeavePass = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p4LeavePass = CType(contrl, ucPNL_p4LeavePass)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPLEAVEPASSAGE.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPLEAVEPASSAGE.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If

                If p4_docFAWrittenOff IsNot Nothing AndAlso p4_docFAWrittenOff.Controls.Count > 0 Then
                    contrl = p4_docFAWrittenOff.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4FAWrittenOff = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p4FAWrittenOff = CType(contrl, ucPNL_p4FAWrittenOff)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPFAWRITTENOFF.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPFAWRITTENOFF.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If p4_docUnreaLossForeEx IsNot Nothing AndAlso p4_docUnreaLossForeEx.Controls.Count > 0 Then
                    contrl = p4_docUnreaLossForeEx.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4UnreaLossForeEx = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p4UnreaLossForeEx = CType(contrl, ucPNL_p4UnreaLossForeEx)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPUNREALLOSSFE.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPUNREALLOSSFE.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If p4_docReaLossForeExTrade IsNot Nothing AndAlso p4_docReaLossForeExTrade.Controls.Count > 0 Then
                    contrl = p4_docReaLossForeExTrade.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4ReaLossForeExTrade = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p4ReaLossForeExTrade = CType(contrl, ucPNL_p4ReaLossForeExTrade)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPREALLOSSFETRADE.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPREALLOSSFETRADE.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If p4_docReaLossForeExNonTrade IsNot Nothing AndAlso p4_docReaLossForeExNonTrade.Controls.Count > 0 Then
                    contrl = p4_docReaLossForeExNonTrade.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4ReaLossForeExNonTrade = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p4ReaLossForeExNonTrade = CType(contrl, ucPNL_p4ReaLossForeExNonTrade)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPREALLOSSFENONTRADE.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPREALLOSSFENONTRADE.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If p4_docInitSub IsNot Nothing AndAlso p4_docInitSub.Controls.Count > 0 Then
                    contrl = p4_docInitSub.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4InitSub = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p4InitSub = CType(contrl, ucPNL_p4InitSub)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPINITIALSUBSCRIPT.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)

                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPINITIALSUBSCRIPT.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If


                If p4_docCAExpenditure IsNot Nothing AndAlso p4_docCAExpenditure.Controls.Count > 0 Then
                    contrl = p4_docCAExpenditure.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4CAExpenditure = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p4CAExpenditure = CType(contrl, ucPNL_p4CAExpenditure)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPCAPITALEXPENDITURE.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPCAPITALEXPENDITURE.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next
                    End If


                End If

                If p4_docOther IsNot Nothing AndAlso p4_docOther.Controls.Count > 0 Then
                    contrl = p4_docOther.Controls(0)

                    If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4Other = False Then
                        Exit Sub
                    End If
                    Dim uc As ucPNL_p4Other = CType(contrl, ucPNL_p4Other)

                    ds = uc.DataView_Main

                    If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count > 0 Then
                        For Each rowx As DataRow In ds.Tables(uc.MainTable).Rows
                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                            ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                            dtRow("No") = ParentNo
                            dtRow("Type") = TaxComPNLEnuItem.EXPOTHERSEXPENSES.ToString
                            dtRow("Description") = IIf(IsDBNull(rowx(uc.Main_Desc)), "", rowx(uc.Main_Desc))
                            dtRow("LeftAmount") = 0
                            dtRow("RightAmount") = IIf(IsDBNull(rowx(uc.MainAmount)), 0, rowx(uc.MainAmount))
                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)


                            If ds Is Nothing OrElse ds.Tables(uc.MainTable_Details) Is Nothing OrElse ds.Tables(uc.MainTable_Details).Rows.Count > 0 Then
                                obj = ds.Tables(uc.MainTable_Details).Select(uc.MainKey_Details & " = " & rowx(uc.MainKey))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = TaxComPNLEnuItem.EXPOTHERSEXPENSES.ToString
                                            dtRow("Description") = IIf(IsDBNull(rowchild(uc.MainDetails_Desc)), "", rowchild(uc.MainDetails_Desc))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(uc.MainAmount_Details)), 0, rowchild(uc.MainAmount_Details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If


                            End If
                        Next

                    End If

                End If
                If DsPNL2.Tables("ExportPNL").Rows.Count > 0 Then
                    dgvExport.BeginInit()
                    ExportPNLBindingSource.DataSource = DsPNL2.Tables("ExportPNL")
                    dgvExport.EndInit()

                    Application.DoEvents()
                    System.Threading.Thread.Sleep(500)

                    dgvExport.ExportToXlsx(Path)

                End If




            End If



        Catch ex As Exception

        Finally

        End Try
    End Sub
    Private Sub exporter_CellValueConversionError(ByVal sender As Object, ByVal e As CellValueConversionErrorEventArgs)
        MessageBox.Show("Error in cell " & e.Cell.GetReferenceA1())
        e.DataTableValue = Nothing
        e.Action = DataTableExporterAction.Continue
    End Sub

    'Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
    '    Try
    '        Dim frm As New frmPNL_Report
    '        frm.RefNo = cboRefNo.EditValue
    '        frm.YA = cboYA.EditValue
    '        frm.ShowDialog()
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub TabbedView1_EndDocumentsHostDocking(sender As Object, e As DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs) Handles TabbedView1.EndDocumentsHostDocking

    End Sub


    Private Sub TabbedView1_RegisterDocumentsHostWindow(sender As Object, e As DevExpress.XtraBars.Docking2010.DocumentsHostWindowEventArgs) Handles TabbedView1.RegisterDocumentsHostWindow
        'Try
        '    ' MsgBox(e.HostWindow.DocumentManager.View.Documents(0).ControlName)
        '    If e.HostWindow.DocumentManager.GetDocument(P1_docSales) IsNot Nothing Then
        '        MsgBox(e.HostWindow.DocumentManager.GetDocument(P1_docSales).ControlName)
        '    End If

        'Catch ex As Exception

        'End Try
        'MsgBox("E")
    End Sub

    Private Sub cboMainSource_EditValueChanged(sender As Object, e As EventArgs) Handles cboMainSource.EditValueChanged
        Try
            UcPNL_Import1.SourceNo = cboMainSource.EditValue

        Catch ex As Exception

        End Try
    End Sub



    'Private Sub TabbedView1_UnregisterDocumentsHostWindow(sender As Object, e As DevExpress.XtraBars.Docking2010.DocumentsHostWindowEventArgs) Handles TabbedView1.UnregisterDocumentsHostWindow
    '    MsgBox("M")
    'End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Me.LoadData()

    End Sub

    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Try
            pnlDocInformation.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BarButtonItem4_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Try
            pnlDocImport.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnErrorLog_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnErrorLog.ItemClick
        Try
            frmErrorLog.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UcPNL_Import1_Load(sender As Object, e As EventArgs) Handles UcPNL_Import1.Load
        Try
            UcPNL_Import1.txt_p1Sales = Me.txt_p1Sales
            UcPNL_Import1.cboRefNo = cboRefNo
            UcPNL_Import1.cboYA = cboYA
            UcPNL_Import1.txt_p1OpenStock = txt_p1OpenStock
            UcPNL_Import1.txt_p1Purchase = txt_p1Purchase
            UcPNL_Import1.txt_p1Depreciation = txt_p1Depreciation
            UcPNL_Import1.txt_p1AllowanceExpenses = txt_p1AllowanceExpenses
            UcPNL_Import1.txt_p1NonAllowableExpenses = txt_p1NonAllowableExpenses
            UcPNL_Import1.txt_p1CloseStock = txt_p1CloseStock
            UcPNL_Import1.txt_p2OtherBizIncome = txt_p2OtherBizIncome
            UcPNL_Import1.txt_p2ForeignCurrExGain = txt_p2ForeignCurrExGain
            UcPNL_Import1.txt_p2DivIncome = txt_p2DivIncome
            UcPNL_Import1.txt_p2InterestIncome = txt_p2InterestIncome
            UcPNL_Import1.txt_p2RentalIncome = txt_p2RentalIncome
            UcPNL_Import1.txt_p2RoyaltyIncome = txt_p2RoyaltyIncome
            UcPNL_Import1.txt_p2OtherIncome = txt_p2OtherIncome
            UcPNL_Import1.txt_p2ProDispPlantEq = txt_p2ProDispPlantEq
            UcPNL_Import1.txt_p2ProDisInvestment = txt_p2ProDisInvestment
            UcPNL_Import1.txt_p2ExemptDividend = txt_p2ExemptDividend
            UcPNL_Import1.txt_p2ForeIncomeRemmit = txt_p2ForeIncomeRemmit
            UcPNL_Import1.txt_p2UnreaGainForeEx = txt_p2UnreaGainForeEx
            UcPNL_Import1.txt_p2ReaForeExGainNonTrade = txt_p2ReaForeExGainNonTrade
            UcPNL_Import1.txt_p2UnreaGainForeExNon = txt_p2UnreaGainForeExNon
            UcPNL_Import1.txt_p2Other = txt_p2Other
            UcPNL_Import1.txt_p3InterestResPurS33 = txt_p3InterestResPurS33
            UcPNL_Import1.txt_p3OtherInterestExHirePur = txt_p3OtherInterestExHirePur
            UcPNL_Import1.txt_p3ProTechManLeganFees = txt_p3ProTechManLeganFees
            UcPNL_Import1.txt_p3TechPayNonResis = txt_p3TechPayNonResis
            UcPNL_Import1.txt_p3ContractPay = txt_p3ContractPay
            UcPNL_Import1.txt_p3DirectorFee = txt_p3DirectorFee
            UcPNL_Import1.txt_p3Salary = txt_p3Salary
            UcPNL_Import1.txt_p3COEStock = txt_p3COEStock
            UcPNL_Import1.txt_p3Royalty = txt_p3Royalty
            UcPNL_Import1.txt_p3Rental = txt_p3Rental
            UcPNL_Import1.txt_p3RepairMain = txt_p3RepairMain
            UcPNL_Import1.txt_p3ResearchDev = txt_p3ResearchDev
            UcPNL_Import1.txt_p3PromotionAds = txt_p3PromotionAds
            UcPNL_Import1.txt_p3Travelling = txt_p3Travelling
            UcPNL_Import1.txt_p3ForeignCurrExLoss = txt_p3ForeignCurrExLoss
            UcPNL_Import1.txt_p3JKDM = txt_p3JKDM
            UcPNL_Import1.txt_p3Depreciation = txt_p3Depreciation
            UcPNL_Import1.txt_p3DonationApp = txt_p3DonationApp
            UcPNL_Import1.txt_p3DonationNonApp = txt_p3DonationNonApp
            UcPNL_Import1.txt_p3Zakat = txt_p3Zakat
            UcPNL_Import1.txt_p4LossDispFA = txt_p4LossDispFA
            UcPNL_Import1.txt_p4EntNonStaff = txt_p4EntNonStaff
            UcPNL_Import1.txt_p4EntStaff = txt_p4EntStaff
            UcPNL_Import1.txt_p4Compound = txt_p4Compound
            UcPNL_Import1.txt_p4ProvisionAcc = txt_p4ProvisionAcc
            UcPNL_Import1.txt_p4LeavePass = txt_p4LeavePass
            UcPNL_Import1.txt_p4FAWrittenOff = txt_p4FAWrittenOff
            UcPNL_Import1.txt_p4UnreaLossForeEx = txt_p4UnreaLossForeEx
            UcPNL_Import1.txt_p4ReaLossForeExTrade = txt_p4ReaLossForeExTrade
            UcPNL_Import1.txt_p4ReaLossForeExNonTrade = txt_p4ReaLossForeExNonTrade
            UcPNL_Import1.txt_p4InitSub = txt_p4InitSub
            UcPNL_Import1.txt_p4CAExpenditure = txt_p4CAExpenditure
            UcPNL_Import1.txt_p4Other = txt_p4Other

        Catch ex As Exception

        End Try
    End Sub

End Class