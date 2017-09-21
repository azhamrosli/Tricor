Public Class frmPNL 
    Public isEdit As Boolean = False
    Public ID As Decimal = 0
    Dim ErrorLog As clsError = Nothing
    Private Sub frmPNL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
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


            If isEdit Then
                cboRefNo.Edit.ReadOnly = True
                cboYA.Edit.ReadOnly = True
            Else
                cboRefNo.Edit.ReadOnly = False
                cboYA.Edit.ReadOnly = False

                cboRefNo.EditValue = mdlProcess.ArgParam2
                cboYA.EditValue = mdlProcess.ArgParam3

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
            End Select

            If cboRefNo Is Nothing OrElse cboYA Is Nothing OrElse cboRefNo.EditValue.ToString = "" OrElse cboYA.EditValue.ToString = "" Then
                MsgBox("Please select tax payer and ya first.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If


            mdlPNL.ViewPNL(Type, Me.DockManager1, Me.DocumentManager1, lbl, txtamount, TabbedView1, cboRefNo.EditValue, cboYA.EditValue)
            '.View.AddDocument(doc)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblSales_DoubleClick(sender As Object, e As EventArgs) Handles lbl_p1Sales.DoubleClick, lbl_p1OpenStock.DoubleClick, lbl_p1Purchase.DoubleClick, lbl_p1Depreciation.DoubleClick, lbl_p1AllowanceExpenses.DoubleClick, lbl_p1NonAllowableExpenses.DoubleClick, lbl_p1CloseStock.DoubleClick, lbl_p2OtherBizIncome.DoubleClick, lbl_p2ForeignCurrExGain.DoubleClick, lbl_p2InterestIncome.DoubleClick, lbl_p2RoyaltyIncome.DoubleClick, lbl_p2OtherIncome.DoubleClick, lbl_p2ProDispPlantEq.DoubleClick, lbl_p2ProDisInvestment.DoubleClick, lbl_p2ForeIncomeRemmit.DoubleClick, lbl_p2ReaForeExGainNonTrade.DoubleClick, lbl_p2UnreaGainForeEx.DoubleClick, lbl_p2UnreaGainForeExNon.DoubleClick, lbl_p3OtherInterestExHirePur.DoubleClick, lbl_p3ProTechManLeganFees.DoubleClick, lbl_p3TechPayNonResis.DoubleClick, lbl_p3ContractPay.DoubleClick, lbl_p3DirectorFee.DoubleClick, lbl_p3Salary.DoubleClick, lbl_p3COEStock.DoubleClick, lbl_p3Royalty.DoubleClick, lbl_p3Rental.DoubleClick, lbl_p3RepairMain.DoubleClick, lbl_p3ResearchDev.DoubleClick, lbl_p3PromotionAds.DoubleClick, lbl_p3Travelling.DoubleClick, lbl_p3JKDM.DoubleClick, lbl_p3Depreciation.DoubleClick, lbl_p3DonationApp.DoubleClick, lbl_p3DonationNonApp.DoubleClick, lbl_p3Zakat.DoubleClick, lbl_p4LossDispFA.DoubleClick, lbl_p4EntNonStaff.DoubleClick, lbl_p4EntStaff.DoubleClick, lbl_p4Compound.DoubleClick, lbl_p4ProvisionAcc.DoubleClick, lbl_p4LeavePass.DoubleClick, lbl_p4FAWrittenOff.DoubleClick, lbl_p4UnreaLossForeEx.DoubleClick, lbl_p4ReaLossForeExTrade.DoubleClick, lbl_p4ReaLossForeExNonTrade.DoubleClick, lbl_p4InitSub.DoubleClick, lbl_p4CAExpenditure.DoubleClick, lbl_p4Other.DoubleClick, lbl_p2RentalIncome.DoubleClick, lblP4NonAllowableExpenses.DoubleClick, lbl_p2Other.DoubleClick, lbl_p2ExemptDividend.DoubleClick, lbl_p3InterestResPurS33.DoubleClick
        Try
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

    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            If cboRefNo IsNot Nothing AndAlso cboRefNo.EditValue.ToString <> "" Then
                txtRefNo.EditValue = cboRefNo.EditValue
            End If
        Catch ex As Exception

        End Try
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
            Dim x As Control = P1_docSales.Controls(0)

            If x IsNot Nothing Then

                If TypeOf x Is ucPNL_p1Sales Then

                    Dim uc As ucPNL_p1Sales = CType(x, ucPNL_p1Sales)

                    'Dim cp As DataTable = uc.DataView_Main

                End If

            End If

        Catch ex As Exception

        End Try
    End Sub

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
          CalcTotalExpenses
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

            Dim TotalExpenses As Decimal = mdlPNL.CalcExpenses(p3ForeignCurrExLoss, p3OtherInterestExHirePur, p3ProTechManLeganFees, p3TechPayNonResis, p3ContractPay, p3DirectorFee, p3Salary, p3COEStock, p3Royalty, p3Rental, p3RepairMain, p3ResearchDev, p3PromotionAds, p3Travelling, p3JKDM, p3InterestResPurS33, p4TotalOtherExpenses, BalacingFigure, ErrorLog)


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
End Class