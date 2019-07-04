Module mdlTaxcomputation_Reference
    
#Region "REFERENCE TAXCOM"
'Option Explicit
'Dim TotalNA_EXP As Double '2007.4
'Dim DBSNote As String
'Dim sForm As Form
'Dim cRefNo As String, cYA As String, cCoName As String, pnl_key As String
'Dim cSourceNo As Integer, i As Integer, X As Integer, z As Integer, nNo As Integer, a As Integer
'Dim cSQL2 As String
'Dim rst1 As New ADODB.Recordset, rst2 As New ADODB.Recordset
'Public totalstatutory As Double
'Public totalRA As Double, total_statin As Double, invest_allow As Double
'Dim total_loss As Double
'Dim interest_restricted As Double, non_allow_exp As Double
'Dim dividend_att_interest As Double, interest_att_interest As Double
'Dim rental_att_interest As Double, rental_assess As Double
'Dim rental_quit_rent As Double, rental_insurance As Double
'Dim rental_oth_exp As Double, approved_donation As Double
'Dim totalStatBsIn As Double, totalITA As Double, NA_Exp As Double, NA_Loss As Double
'Dim UCABal_Allow As Double, UCABal_Charge As Double
'Dim ULBalance As Double, ITABalance As Double, RABalance As Double, SABalance As Double
'Dim non_allowable_expenses As Double
'Dim xItem As ListItem
'Dim sourcenum As String, pre_sourcenum As String
'Dim key_array
'Dim UCA_AA As Double, pre_UCA_AA As Double, qc_bal_cf As Double, twdv_balance As Double, twdv_disposal As Double, twdv_addition As Double, IA As Double, UCA_IA As Double
'Dim current_year As String
'Dim iYear As Double, instal_paid_amt As Double
'Dim txtSourceNo As String

'Dim cSQL3 As String
'Dim cSQL4 As String
'Dim rst3 As ADODB.Recordset
'Dim rst4 As ADODB.Recordset
'Dim rst5 As New ADODB.Recordset 'HS : 2009 : Change Unabsorbed business loss'
'Dim dblzakat As Double
'Public DetailsReturnControl As Control 'pin add v2006.2.2
'Dim ITA_AMOUNT As Double
'Dim ITA_CF As Double
'Dim RA_AMOUNT As Double
'Dim RA_CF As Double
'Dim ITA_AMOUNT1 As Double
'Dim ITA_CF1 As Double
'Dim RA_AMOUNT1 As Double
'Dim RA_CF1 As Double

'Dim EA_AMOUNT As Double 'LeeCC 2012.1 export allowance
'Dim EA_CF As Double 'LeeCC 2012.1 export allowance
'Dim EA_AMOUNT1 As Double 'LeeCC 2012.1 export allowance
'Dim EA_CF1 As Double 'LeeCC 2012.1 export allowance
'Dim EA_AMOUNT_SP As Double 'LeeCC 2012.1 export allowance
'Dim EA_CF_SP As Double 'LeeCC 2012.1 export allowance
'Dim EA_AMOUNT_SP1 As Double 'LeeCC 2012.1 export allowance
'Dim EA_CF_SP1 As Double 'LeeCC 2012.1 export allowance
'Dim EA_AMOUNT_AGRI As Double 'LeeCC 2012.1 export allowance
'Dim EA_CF_AGRI As Double 'LeeCC 2012.1 export allowance
'Dim EA_AMOUNT_AGRI1 As Double 'LeeCC 2012.1 export allowance
'Dim EA_CF_AGRI1 As Double 'LeeCC 2012.1 export allowance

'Dim strS60FA As String
'Dim strKey As String

''HS : 2009: C2008.7 '
'Dim TotalCompareAmount As Double
'Dim PLRefNo As String
'Dim rst6 As New ADODB.Recordset
'Dim rst7 As New ADODB.Recordset
''HS : 2009: C2008.7 end '

'' *** irisa
'Private xitem_CA As ListItem, disp_QC As Double, disp_Pur As Double, temp_IA As Double

''Loo Jia An
'Dim strSource As String, total As String

''LeeCC IBA
'Dim txtDividendIn, txtDivAttrInt, txtDivOthers, txtNetDividend, txtInterestIn, txtIntAttrInt, txtIntOthers, txtNetIntIn, txtIntDisallow, txtTotalInterest, txtDCAInterest, txtDeemedInterest As String 'LeeCC 2012 disallowed interest
'Dim txtRentalIn, txtRentAttrIn, txtRentAssess, txtRentQuit, txtRentInsur, txtRentOthExp, txtRentRepair, txtRentRenewal, txtNetRentalIn, txtOthers As String
'Dim txtSundryIn, txtDirExpenses3 As String
'Dim txtRentalInIBA, txtRentAttrInIBA, txtRentAssessIBA, txtRentQuitIBA, txtRentInsurIBA, txtRentOthExpIBA, txtRentRepairIBA, txtRentRenewalIBA, txtNetRentalInIBA, txtOthersIBA As String

''simkh 2012.1  EA
'Dim txtCompanySales, txtCompanyCost, txtCompanyValue1, txtCompanyPercent, txtCompanyValueImmediately, txtCompanyValueCurrent, txtCompanyValue2, txtCompanyAllowanceValue As String
'Dim txtAgrValueCurrent, txtAgrValueImmediately, txtAgrValueTotal, txtAgrCurrentAllowance As String
'Dim txtSigValueCurrent, txtSigValueImmediately, txtSigValueTotal, txtSigPercent, txtSigExemption, txtSigText1 As String
'Dim txtMarketTotal, txtMarketStatutory, txtMarketValueCurrent As String
'Dim txtSerValueCurrent, txtSerValueImmediately, txtSerValueTotal, txtSerText1, txtSerStatutory As String



'' HS : 2009 : C2008.7 '
'Private Sub btnApproDonation_Click()
'cFormType = "frmIncomeCalculationEdit"
'Call LoadForm_Subform(frmApproDonation)
'End Sub

'' Hs : 2009 : C2008.7'
'Private Sub LoadLessApprDonation()
'Dim amount, DetailType, KEY, KeySourceno, refnum, Refno1, YearAccess, BUSINESS As String
'Dim TotalAmount1, TotalAmount2, TotalAmount3, TotalAmount4, TotalAmount5, TotalAmount6, TotalAmount7, TotalA1, LessA1 As Double
'Dim CompareAmount1, CompareAmount2, CompareAmount3, CompareAmount4, CompareAmount5, CompareAmount6, CompareAmount7, TotalSum As Double
   
'PLRefNo = ""
'refnum = Me.txtRefNo 'frmIncomeCalculation.lstView.SelectedItem.ListSubItems(1).Text
'Refno1 = Me.txtRefNo 'Right(RefNum, Len(RefNum) - 1)
'amount = ""
'TotalAmount1 = 0
'TotalAmount2 = 0
'TotalAmount3 = 0
'TotalAmount4 = 0
'TotalAmount5 = 0
'TotalAmount6 = 0
'TotalAmount7 = 0
'DetailType = ""
'YearAccess = Me.txtYA 'frmIncomeCalculation.lstView.SelectedItem.ListSubItems(2).Text
''business = frmProfitLossAccountEdit.cboSourceNo 'frmIncomeCalculation.lstView.SelectedItem.ListSubItems(5).Text
'KEY = ""
'KeySourceno = ""

'cSQL = "SELECT [PL_KEY], [PL_MAINBUZ] FROM [PROFIT_LOSS_ACCOUNT] WHERE [PL_REF_NO] = '" & Trim(Refno1) & "' AND [PL_YA] = '" & Trim(YearAccess) & "'"
'Set rst6 = DB.Execute(cSQL)
''MsgBox (CStr(rst1.RecordCount))
'    If Not rst6.EOF Then
'        PLRefNo = rst6!PL_KEY
'        BUSINESS = rst6!PL_MAINBUZ
'    End If
'        rst6.Close
'        Set rst6 = Nothing

''cSQL = "SELECT * FROM [OTHER_EXAPPRDONATION] WHERE [EXOAD_KEY] = " & Trim(PLRefNo) & " AND [EXOAD_SOURCENO] = " & Trim(business) & ""
'cSQL = "SELECT * FROM [OTHER_EXAPPRDONATION] WHERE [EXOAD_KEY] = " & Trim(PLRefNo) & ""
'Set rst6 = DB.Execute(cSQL)
'    If Not rst6.EOF Then
'        rst6.MoveFirst
'          Do While Not rst6.EOF
'            If rst6!EXOAD_DETAIL = "Yes" Then
'            cSQL = "SELECT * FROM [OTHER_EXAPPRDONATION_DETAIL] WHERE [EXOADD_KEY] = " & Trim(PLRefNo) & " AND [EXOADD_SOURCENO] = " & Trim(rst6!EXOAD_SOURCENO) & " AND [EXOADD_EXOADKEY]= " & rst6!EXOAD_EXOADKEY
'            ' new : cSQL = "SELECT * FROM [OTHER_EXAPPRDONATION_DETAIL] WHERE [EXOADD_KEY] = " & Trim(PLRefNo) & ""
'            Set rst7 = DB.Execute(cSQL)
'                If Not rst7.EOF Then
'                    rst7.MoveFirst
'                    Do While Not rst7.EOF
'                          Select Case rst7!EXOADD_TYPE
'                            Case "Gifts of Money to Government"
'                                TotalAmount1 = TotalAmount1 + FormatNumber(CDbl(rst7!EXOADD_AMOUNT), 0)
'                            Case "Gifts of Money to Approved institutions"
'                                TotalAmount2 = TotalAmount2 + FormatNumber(CDbl(rst7!EXOADD_AMOUNT), 0)
'                            Case "Gifts of Money or Contribution for Approved Sports Activities"
'                                TotalAmount3 = TotalAmount3 + FormatNumber(CDbl(rst7!EXOADD_AMOUNT), 0)
'                            Case "Gifts of Money or Contribution for Approved Project of National Interest"
'                                TotalAmount4 = TotalAmount4 + FormatNumber(CDbl(rst7!EXOADD_AMOUNT), 0)
'                            Case "Gifts of Artifacts, Manuscripts or paintings"
'                                TotalAmount5 = TotalAmount5 + FormatNumber(CDbl(rst7!EXOADD_AMOUNT), 0)
'                            Case "Gifts of Money to Library"
'                                TotalAmount6 = TotalAmount6 + FormatNumber(CDbl(rst7!EXOADD_AMOUNT), 0)
'                            Case "Gifts of Paintings to National Art Gallery"
'                                TotalAmount7 = TotalAmount7 + FormatNumber(CDbl(rst7!EXOADD_AMOUNT), 0)
'                        End Select
'                    rst7.MoveNext
'                    Loop
'                End If
'                    rst7.Close
'                    Set rst7 = Nothing
'            Else
'                 Select Case rst6!EXOAD_TYPE
'                     Case "Gifts of Money to Government"
'                          TotalAmount1 = TotalAmount1 + FormatNumber(CDbl(rst6!EXOAD_AMOUNT), 0)
'                     Case "Gifts of Money to Approved institutions"
'                          TotalAmount2 = TotalAmount2 + FormatNumber(CDbl(rst6!EXOAD_AMOUNT), 0)
'                     Case "Gifts of Money or Contribution for Approved Sports Activities"
'                          TotalAmount3 = TotalAmount3 + FormatNumber(CDbl(rst6!EXOAD_AMOUNT), 0)
'                     Case "Gifts of Money or Contribution for Approved Project of National Interest"
'                          TotalAmount4 = TotalAmount4 + FormatNumber(CDbl(rst6!EXOAD_AMOUNT), 0)
'                     Case "Gifts of Artifacts, Manuscripts or paintings"
'                          TotalAmount5 = TotalAmount5 + FormatNumber(CDbl(rst6!EXOAD_AMOUNT), 0)
'                     Case "Gifts of Money to Library"
'                          TotalAmount6 = TotalAmount6 + FormatNumber(CDbl(rst6!EXOAD_AMOUNT), 0)
'                     Case "Gifts of Paintings to National Art Gallery"
'                          TotalAmount7 = TotalAmount7 + FormatNumber(CDbl(rst6!EXOAD_AMOUNT), 0)
'                End Select
'            End If
'            rst6.MoveNext
'            Loop
'        End If
'        rst6.Close
'        Set rst6 = Nothing
        
'' Calculation '
'    LessA1 = 0
    
'    TotalA1 = CDbl(txtAggregateIn)
    
'    CompareAmount1 = FormatNumber(TotalAmount1, 0)
'    CompareAmount2 = FormatNumber(TotalAmount2, 0)
'    CompareAmount3 = FormatNumber(TotalAmount3, 0)
'    CompareAmount4 = FormatNumber(TotalAmount4, 0)
'    CompareAmount5 = FormatNumber(TotalAmount5, 0)
'    CompareAmount6 = FormatNumber(TotalAmount6, 0)
'    CompareAmount7 = FormatNumber(TotalAmount7, 0)
    
'    TotalSum = FormatNumber(CDbl(CompareAmount2) + CDbl(CompareAmount3) + CDbl(CompareAmount4), 0)
    
'    Select Case Val(YearAccess)
'        'NGOHCS 2009
'        Case Is >= 2009
'                LessA1 = TotalA1 * 10 / 100
'                If TotalSum >= LessA1 Then
'                    'TotalSum = FormatNumber(CDbl(LessA1), 0)
'                    'dannylee 2012 su5.2
'                    TotalSum = Fix(CDbl(LessA1))
'                    'dannylee end
'                End If
                    
'        Case Is > 2006
'                LessA1 = TotalA1 * 7 / 100
'                If TotalSum >= LessA1 Then
'                    TotalSum = FormatNumber(CDbl(LessA1), 0)
'                End If
            
'        Case Is <= 2006
'                LessA1 = TotalA1 * 5 / 100
'                If TotalSum >= LessA1 Then
'                    TotalSum = FormatNumber(CDbl(LessA1), 0)
'                End If
'    End Select
    
'    TotalCompareAmount = FormatNumber(CDbl(CompareAmount1) + TotalSum + CDbl(CompareAmount5) + CDbl(CompareAmount6) + CDbl(CompareAmount7), 0)
        
'End Sub

''LeeCC IBA start
'Private Sub btnIBA_Click()
'    frmIBA.Show
'End Sub
''LeeCC IBA end

'Private Sub btnExemptionIncreaseChargeable_Click()
''Call LoadForm_Subform(frmIncomeCalculation_ExemptionIncomeChargeable_OKCancel)

'cFormType = "frmIncalculation_ExemptionIncomeChargeable"

'Call LoadForm_Subform(frmIncomeCalculation_ExemptionIncomeChargeable)
'End Sub

'' === csNgoh 2008 === '
'Private Sub ChkApply_Click()
'    If ChkApply.Value = Checked Then
'        ChkMajorC.Visible = True
'    Else
'        ChkMajorC.Visible = False
'        ChkMajorC.Value = Unchecked
'    End If
'End Sub
'' === End csNgoh 2008 === '

'' HS : 2009 , Change Unabsorbed business los '
'Private Sub chkCBL_Click()

'If chkCBL.Value = 1 Then
'    txtCBL.Enabled = True
    
'     cSQL = "SELECT * FROM [TAX_COMPUTATION] WHERE [TC_KEY] =" & CDbl(vIncomeCalKey)
'     Set rst5 = DB.Execute(cSQL)
'     If Not rst5.EOF Then
'        With rst5
'            txtCBL = !TC_NB_CARRYBCKLOSS
'        End With
'     End If
'     rst5.Close
'Else
'    txtCBL.Enabled = False
'    txtCBL = 0
'End If

'Call txtCBL_Change

'End Sub

'Private Sub ChkMajorC_Click()
'    If lstViewCA.ListItems.count > 0 Then
'       For X = 1 To lstViewCA.ListItems.count
'                If frmIncomeCalculationEdit.ChkMajorC = 1 Then
                                                    
'                     lstViewCA.ListItems(X).ListSubItems(11).Text = lstViewCA.ListItems(X).ListSubItems(10).Text  'DisAllowance CA
'                     lstViewCA.ListItems(X).ListSubItems(12).Text = lstViewCA.ListItems(X).ListSubItems(10).Text - lstViewCA.ListItems(X).ListSubItems(11).Text ' Actual Balance c/f
'                Else
'                     lstViewCA.ListItems(X).ListSubItems(11).Text = 0  'DisAllowance CA 'PINP3R2
'                     lstViewCA.ListItems(X).ListSubItems(12).Text = lstViewCA.ListItems(X).ListSubItems(10).Text
                                    
'                End If
'        Next
'     End If
  
'    '==Oscar2009.1==' S60FA
'    cSQL3 = "SELECT * FROM [PROFIT_LOSS_ACCOUNT] WHERE [PL_REF_NO] = '" & txtRefNo & "' AND [PL_YA] = '" & txtYA & "'"
'    Set rst2 = DB.Execute(cSQL3)
'    If Not rst2.EOF Then
'        If rst2!PL_S60FA = "Y" Then
'            txtULBalbf = 0
'            txtULBalcf = 0
'            txtBalcf = 0
'            txtDisABL.Enabled = False
'            txtDisABL.BackColor = &H8000000F
'            txtDisABL = txtULBalcf
'            cmdNote.Enabled = False
'       Else
'            If ChkMajorC = 1 Then
'                ' ====== HS : C2008.7 ======
'                'txtDisABL = txtULBalcf
'                txtDisABL = txtULBalbf
'                ' ====== HS : C2008.7 : end ======
'                txtBalcf = FormatNumber(txtULBalcf - txtDisABL, 0) ' HS : C2008.7 : Add in FormatNumber
'                txtDisABL.Enabled = True
'                txtDisABL.BackColor = &HFFFFFF
'                cmdNote.Enabled = True
'            Else
'                txtDisABL = 0
'                txtBalcf = FormatNumber(txtULBalcf - txtDisABL, 0) ' HS : C2008.7 : Add in FormatNumber
'                txtDisABL.Enabled = False
'                txtDisABL.BackColor = &H8000000F
'                cmdNote.Enabled = False
'            End If
'       End If
'    End If
'    rst2.Close
'    '==End Oscar2009.1=='
'End Sub

''dannylee 2012 su5.2
'Private Sub chkSMEFirst2Year_Click()
'If chkSMEFirst2Year.Value = "1" Then
'    lblInTaxPay2.Visible = False
'    lblEsTaxPay.Visible = False
'    lblAllowDiff.Visible = False
'    lblExDiff.Visible = False
'    lblPenOnExDiff.Visible = False
'    txtInTaxPay2.Visible = False
'    txtInTaxPay3.Visible = False
'    txtEsTaxPay.Visible = False
'    txtAllowDiff.Visible = False
'    txtExDiff.Visible = False
'    txtPenOnExDiff.Visible = False
'Else
'    lblInTaxPay2.Visible = True
'    lblEsTaxPay.Visible = True
'    lblAllowDiff.Visible = True
'    lblExDiff.Visible = True
'    lblPenOnExDiff.Visible = True
'    txtInTaxPay2.Visible = True
'    txtInTaxPay3.Visible = True
'    txtEsTaxPay.Visible = True
'    txtAllowDiff.Visible = True
'    txtExDiff.Visible = True
'    txtPenOnExDiff.Visible = True
'End If
'End Sub
''dannylee end

''Private Sub cmdDivExp_Click()
''    cICType = "ADD DI OTHERS"
''    frmIncomeCalculationGeneral.Caption = "Dividend Expenses : Others"
''    frmIncomeCalculationGeneral.Show
''End Sub

'Private Sub cmdDividendIncome_Click()
'    frmDividendIncome.Show
'End Sub

'Private Sub cmdEdit_Click()
'    If lstView.ListItems.count = 0 Then
'        Exit Sub
'    End If
    
'    frmStatutoryIncome.Show
'     'azham 19072017
'    Call CalcExemtpionx
'End Sub

'Private Sub cmdEditCA_Click()
'If lstViewCA.ListItems.count = 0 Then
'   Exit Sub
'End If
'lngNotionalKey = lstView.ListItems(lstViewCA.SelectedItem.Index).ListSubItems(14).Text
''vIncomeCalKey
'frmCAComputation.Show
'End Sub

'Private Sub cmdEditEA_Click()
'    If lstViewEA.ListItems.count = 0 Then Exit Sub
    
'    frmEAComputation.Show
'End Sub

'' === CYS C2010.11 ==='
'Private Sub cmdEditRAP_Click()
'    If lstRAPartnership.ListItems.count = 0 Then
'        Exit Sub
'    End If
'    frmRAP.Show
'End Sub
'' === CYS End ===

''===NgKL C2010.1==='
''Private Sub cmdIntExp_Click()
''    cICType = "ADD IN OTHERS"
''    frmIncomeCalculationGeneral.Caption = "Interest Expenses : Others"
''    frmIncomeCalculationGeneral.Show
''End Sub

''Private Sub cmdIntIncome_Click()
''cICType = "Interest Income"
''frmIncomeCalculationGeneral.Caption = "Interest Income"
''frmIncomeCalculationGeneral.Show
''End Sub
''===NgKL End==='

'Private Sub cmdInterestIncome_Click()
'    frmInterestIncome.Show
'End Sub

'Private Sub cmdITA_Click()
' If ListViewITA.ListItems.count = 0 Then
'        Exit Sub
'    End If
'    frmITA.Show
'End Sub

'Private Sub cmdNote_Click() 'PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'NoteDesc = "Disallowed Business Loss"
'NoteID = "2"
'frmNote.Show
'End Sub

'Private Sub cmdRA_Click()
'    If ListViewRA.ListItems.count = 0 Then
'        Exit Sub
'    End If
    
'    frmRA.Show
'End Sub

'Private Function AllowSave() As Boolean
        
'    AllowSave = False
'    If ListViewRA.ListItems.count > 0 Then 'PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'        For i = 1 To ListViewRA.ListItems.count
'            If CDbl(ListViewRA.ListItems(i).ListSubItems(6).Text) < 0 Then
'            MsgBox "The RA Utilised during the year is cannot greater than RA Total !", vbCritical, "Taxcom"
'            Exit Function
'            End If
'        Next
'    End If
'    If ListViewITA.ListItems.count > 0 Then 'PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'        For i = 1 To ListViewITA.ListItems.count
'            If CDbl(ListViewITA.ListItems(i).ListSubItems(6).Text) < 0 Then
'            MsgBox "The ITA Utilised during the year is cannot greater than ITA Total !", vbCritical, "Taxcom"
'            Exit Function
'            End If
'        Next
'     End If
'     If lstRAPartnership.ListItems.count > 0 Then 'CYS TAXCOM C+ 2010
'        For i = 1 To lstRAPartnership.ListItems.count
'            If CDbl(lstRAPartnership.ListItems(i).ListSubItems(6).Text) < 0 Then
'            MsgBox "The RAP Utilised during the year is cannot greater than RAP Total !", vbCritical, "Taxcom"
'            Exit Function
'            End If
'        Next
'    End If
''    If ListViewEA.ListItems.count > 0 Then
''        For i = 1 To ListViewEA.ListItems.count
''            If CDbl(ListViewEA.ListItems(i).ListSubItems(6).Text) < 0 Then
''            MsgBox "The EA Utilised during the year is cannot greater than EA Total !", vbCritical, "TaxCom"
''            Exit Function
''            End If
''        Next
''    End If
        
'    AllowSave = True
    
'End Function

''Private Sub cmdRentalExp_Click()
''    cICType = "ADD RE OTHERS"
''    frmIncomeCalculationGeneral.Caption = "Rental Expenses : Others"
''    frmIncomeCalculationGeneral.Show
''End Sub

'Private Sub cmdRentalIncome_Click()
'    frmRentalIncome.Show
'End Sub

'Private Sub cmdSave_Click()
'Dim rstInsert As New ADODB.Recordset
'Dim check As Integer
'Dim DBSNote As String, i As Integer, arrClaim(5, 2) As String

'sForm.Enabled = True
'If Not AllowSave Then Exit Sub
      
   
'    '-==Amy 2008==-'
'If IncomeCal_Flag1 = False Then 'Or Remind = False Then
'    If txtBtnCheck.Text = "False" Then
    
'        If Val(Trim(txtInstallments.Text)) = 0 Then
         
'            If MsgBox("Is your Installment made figure equal to RM 0.00?", vbYesNo + vbInformation, "Taxcom") = vbYes Then
'            Else
'               Exit Sub
'            End If
     
'        End If
'    End If
'End If
'     '-==End Amy 2008==-'


'If IncomeCal_Flag <> True Then
'    If Not AllowSave Then Exit Sub
'End If
    
''   cSQL = "SELECT * FROM [PROFIT_LOSS_ACCOUNT] WHERE [PL_REF_NO]='" & Trim(cRefNo) & "' AND [PL_YA]='" & Trim(cYA) & "'"
''        Set rst = DB.Execute(cSQL)
''        If Not rst.EOF Then    'O2008.1
''        '===NgKL C2010==='
''            'txtDividendIn(1) = FormatNumber(CDbl(rst!PL_TREGROSS), 0) 'TC_NB_DIV FormatNumber(CDbl(rst!PL_OTH_IN_DIVIDEND), 0)
''            'txtInterestIn(0) = FormatNumber(CDbl(rst!PL_OTH_IN_INTEREST), 0)
''        '===NgKL End==='
''            txtRentalIn = FormatNumber(CDbl(rst!PL_OTH_IN_RENTAL), 0)
''            If Not IsNull(rst!PL_TOTALY) Then
''              '  txtITPSetoff = FormatNumber(CDbl(rst!PL_TOTALY), 2)
''                txtITPSetoff = FormatNumber(CDbl(rst!PL_TTAXDEDUCTION), 2)
''
''            End If
''            txtRoyaltyIncome = rst!PL_OTH_IN_ROYALTY
''        ' === NGKL 2010.2 === '
''            'txtSundryIn = rst!PL_OTH_IN_OTHER
''        ' === NGKL 2010.2 END === '
''        End If
''        rst.Close
''=== CYS 2010.10 ===
'    cSQL = "SELECT * FROM [TAX_COMPUTATION_PARTNER] WHERE [TCP_REF_NO] ='" & Trim(cRefNo) & "' AND [TCP_YA]='" & Trim(cYA) & "'"
'        Set rst = DB.Execute(cSQL)
'        If Not rst.EOF Then
'            txtStatPartnership = FormatNumber(CDbl(rst!TCP_PARTNERSHIP), 0)
'        End If
'        rst.Close
''=== End ===
'If lvNote.ListItems.count > 0 Then 'PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'   For i = 1 To lvNote.ListItems.count
'      If lvNote.ListItems(i).Text = "2" Then
'         DBSNote = lvNote.ListItems(i).ListSubItems(1).Text
'         cSQL = "UPDATE [TAX_COMPUTATION] SET [TC_DISALLOWBUSINESS_NOTE]='" & DBSNote & _
'                "' WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' AND [TC_BUSINESS]=" & lstView.ListItems(i).Text
'         DB.Execute (cSQL)
'      Else
'      End If
'   Next
'End If
    
'    If lstView.ListItems.count > 0 Then 'PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'        For i = 1 To lstView.ListItems.count
'         cSQL = "SELECT * FROM [TAX_COMPUTATION] WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' AND [TC_BUSINESS]=" & lstView.ListItems(i).Text
'            DB.Execute (cSQL)
'            Set rst2 = DB.Execute(cSQL)
'            'RA
'            If rst2![TC_RA_TOTAL1] <> 0 Or rst2![TC_ITA_TOTAL1] <> 0 Or rst2![TC_RA_RESTRICTAMOUNT] <> 0 Or rst2![TC_ITA_RESTRICTAMOUNT] <> 0 Then
'              'O2008.1
''              If lstView.ListItems(I).ListSubItems(21).Text = 0 And lstView.ListItems(I).ListSubItems(20).Text = 0 And lstView.ListItems(I).ListSubItems(22).Text = 0 And lstView.ListItems(I).ListSubItems(24).Text = 0 Then
'                If lstView.ListItems(i).ListSubItems(20).Text = 0 And lstView.ListItems(i).ListSubItems(24).Text = 0 Then
'                        lstView.ListItems(i).ListSubItems(11).Text = lstView.ListItems(i).ListSubItems(11).Text
'                Else
'                    If (lstView.ListItems(i).ListSubItems(10).Text * lstView.ListItems(i).ListSubItems(23).Text / 100) < lstView.ListItems(i).ListSubItems(22).Text Then
'                         lstView.ListItems(i).ListSubItems(11).Text = FormatNumber((lstView.ListItems(i).ListSubItems(10).Text * lstView.ListItems(i).ListSubItems(23).Text / 100), 0)
'                         lstView.ListItems(i).ListSubItems(24).Text = FormatNumber((lstView.ListItems(i).ListSubItems(10).Text * lstView.ListItems(i).ListSubItems(23).Text / 100), 0)
'                         ListViewRA.ListItems(i).ListSubItems(5).Text = lstView.ListItems(i).ListSubItems(11).Text
'                    Else
'                         lstView.ListItems(i).ListSubItems(11).Text = lstView.ListItems(i).ListSubItems(22).Text
'                         lstView.ListItems(i).ListSubItems(24).Text = FormatNumber((lstView.ListItems(i).ListSubItems(10).Text * lstView.ListItems(i).ListSubItems(23).Text / 100), 0)
'                         ListViewRA.ListItems(i).ListSubItems(5).Text = lstView.ListItems(i).ListSubItems(11).Text
'                    End If
'                End If
                
'                'ITA
'                'O2008.1
''                If lstView.ListItems(I).ListSubItems(28).Text = 0 And lstView.ListItems(I).ListSubItems(27).Text = 0 And lstView.ListItems(I).ListSubItems(29).Text = 0 And lstView.ListItems(I).ListSubItems(31).Text = 0 Then
'                If lstView.ListItems(i).ListSubItems(27).Text = 0 And lstView.ListItems(i).ListSubItems(31).Text = 0 Then
'                   lstView.ListItems(i).ListSubItems(12).Text = lstView.ListItems(i).ListSubItems(12).Text

'                Else
'                    If (lstView.ListItems(i).ListSubItems(10).Text * lstView.ListItems(i).ListSubItems(30).Text / 100) < lstView.ListItems(i).ListSubItems(29).Text Then 'TC_ITA_TOTAL1
'                         lstView.ListItems(i).ListSubItems(12).Text = FormatNumber((lstView.ListItems(i).ListSubItems(10).Text * lstView.ListItems(i).ListSubItems(30).Text / 100), 0)
'                         lstView.ListItems(i).ListSubItems(31).Text = FormatNumber((lstView.ListItems(i).ListSubItems(10).Text * lstView.ListItems(i).ListSubItems(30).Text / 100), 0)
'                         ListViewITA.ListItems(i).ListSubItems(5).Text = lstView.ListItems(i).ListSubItems(12).Text
'                    Else
'                         lstView.ListItems(i).ListSubItems(12).Text = lstView.ListItems(i).ListSubItems(29).Text
'                         lstView.ListItems(i).ListSubItems(31).Text = FormatNumber((lstView.ListItems(i).ListSubItems(10).Text * lstView.ListItems(i).ListSubItems(30).Text / 100), 0)
'                         'Utilisi during the year
'                         ListViewITA.ListItems(i).ListSubItems(5).Text = lstView.ListItems(i).ListSubItems(12).Text
'                    End If
'                End If
'            End If
                
'                'EA
''                simkh 2012.1
''                  If lstView.ListItems(i).ListItems(i).ListSubItems(42).Text = 0 Then
''                   lstView.ListItems(i).ListSubItems(14).Text = lstView.ListItems(i).ListSubItems(12).Text
''
''                Else
''
''                    If (lstView.ListItems(i).ListSubItems(10).Text * lstView.ListItems(i).ListSubItems(41).Text / 100) < lstView.ListItems(i).ListSubItems(40).Text Then
''                         lstView.ListItems(i).ListSubItems(14).Text = FormatNumber((lstView.ListItems(i).ListSubItems(10).Text * lstView.ListItems(i).ListSubItems(41).Text / 100), 0)
''                         lstView.ListItems(i).ListSubItems(38).Text = FormatNumber((lstView.ListItems(i).ListSubItems(10).Text * lstView.ListItems(i).ListSubItems(41).Text / 100), 0)
''                         ListViewEA.ListItems(i).ListSubItems(5).Text = lstView.ListItems(i).ListSubItems(14).Text
''                    Else
''                         lstView.ListItems(i).ListSubItems(14).Text = lstView.ListItems(i).ListSubItems(40).Text
''                         lstView.ListItems(i).ListSubItems(42).Text = FormatNumber((lstView.ListItems(i).ListSubItems(10).Text * lstView.ListItems(i).ListSubItems(41).Text / 100), 0)
''                         'Utilisi during the year
''                         ListViewEA.ListItems(i).ListSubItems(5).Text = lstView.ListItems(i).ListSubItems(14).Text
''
''                    End If
''
''                End If
            
            
''NGOHCSCA 2008
'            cSQL = "UPDATE [TAX_COMPUTATION] SET [TC_SI_ADJ_BS_IN]='" & lstView.ListItems(i).ListSubItems(6).Text & "', [TC_SI_BC]='" & lstView.ListItems(i).ListSubItems(7).Text & "', " _
'            & "[TC_SI_ADJ_BS_IN_BC]='" & lstView.ListItems(i).ListSubItems(8).Text & "', [TC_SI_CA]='" & lstView.ListItems(i).ListSubItems(9).Text & "', [TC_SI_STAT_BS_IN]='" & lstView.ListItems(i).ListSubItems(10).Text & "', " _
'            & "[TC_SI_RA]='" & lstView.ListItems(i).ListSubItems(11).Text & "', [TC_SI_INVEST_ALLOW]='" & lstView.ListItems(i).ListSubItems(12).Text & "', [TC_SI_NET_STAT_IN]='" & lstView.ListItems(i).ListSubItems(13).Text & "', " _
'            & "[TC_PIONEERDESC]='" & lstView.ListItems(i).ListSubItems(15).Text & "', [TC_PIO]= '" & lstView.ListItems(i).ListSubItems(16).Text & "', [TC_PIONEER]='" & lstView.ListItems(i).ListSubItems(17).Text & "'," _
'            & "[TC_RA_RATE1]='" & lstView.ListItems(i).ListSubItems(18).Text & "', [TC_RA_QUALIFYINGCAPITALEXP]='" & lstView.ListItems(i).ListSubItems(19).Text & "', [TC_RA_QUALIFYINGCAPITALEXP_AMOUNT]='" & lstView.ListItems(i).ListSubItems(20).Text & "', [TC_RA_BALANCINGALLOWANCE]='" & lstView.ListItems(i).ListSubItems(21).Text & "', [TC_RA_TOTAL1]='" & lstView.ListItems(i).ListSubItems(22).Text & "', [TC_RA_RESTRICTRATE]='" & lstView.ListItems(i).ListSubItems(23).Text & "', [TC_RA_RESTRICTAMOUNT]='" & lstView.ListItems(i).ListSubItems(24).Text & "'," _
'            & "[TC_ITA_RATE1]='" & lstView.ListItems(i).ListSubItems(25).Text & "', [TC_ITA_QUALIFYINGCAPITALEXP]='" & lstView.ListItems(i).ListSubItems(26).Text & "', [TC_ITA_QUALIFYINGCAPITALEXP_AMOUNT]='" & lstView.ListItems(i).ListSubItems(27).Text & "', [TC_ITA_BALANCINGALLOWANCE]='" & lstView.ListItems(i).ListSubItems(28).Text & "', [TC_ITA_TOTAL1]='" & lstView.ListItems(i).ListSubItems(29).Text & "', [TC_ITA_RESTRICTRATE]='" & lstView.ListItems(i).ListSubItems(30).Text & "', [TC_ITA_RESTRICTAMOUNT]='" & lstView.ListItems(i).ListSubItems(31).Text & "'," _
'            & "[TC_WITHRAITA]='" & lstView.ListItems(i).ListSubItems(32).Text & "', [TC_CHK_EXEMP]='" & lstView.ListItems(i).ListSubItems(33).Text & "'" _
'            & " WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' AND [TC_BUSINESS]=" & lstView.ListItems(i).Text

''            cSQL = "UPDATE [TAX_COMPUTATION] SET [TC_SI_ADJ_BS_IN]='" & lstView.ListItems(I).ListSubItems(6).Text & "', [TC_SI_BC]='" & lstView.ListItems(I).ListSubItems(7).Text & "', " _
''            & "[TC_SI_ADJ_BS_IN_BC]='" & lstView.ListItems(I).ListSubItems(8).Text & "', [TC_SI_CA]='" & lstView.ListItems(I).ListSubItems(9).Text & "', [TC_SI_STAT_BS_IN]='" & lstView.ListItems(I).ListSubItems(10).Text & "', " _
''            & "[TC_SI_RA]='" & lstView.ListItems(I).ListSubItems(11).Text & "', [TC_SI_INVEST_ALLOW]='" & lstView.ListItems(I).ListSubItems(12).Text & "', [TC_SI_NET_STAT_IN]='" & lstView.ListItems(I).ListSubItems(13).Text & "', " _
''            & "[TC_PIONEERDESC]='" & lstView.ListItems(I).ListSubItems(15).Text & "', [TC_PIO]= '" & lstView.ListItems(I).ListSubItems(16).Text & "', [TC_PIONEER]='" & lstView.ListItems(I).ListSubItems(17).Text & "'," _
''            & "[TC_RA_RATE1]='" & lstView.ListItems(I).ListSubItems(18).Text & "', [TC_RA_QUALIFYINGCAPITALEXP]='" & lstView.ListItems(I).ListSubItems(19).Text & "', [TC_RA_QUALIFYINGCAPITALEXP_AMOUNT]='" & lstView.ListItems(I).ListSubItems(20).Text & "', [TC_RA_BALANCINGALLOWANCE]='" & lstView.ListItems(I).ListSubItems(21).Text & "', [TC_RA_TOTAL1]='" & lstView.ListItems(I).ListSubItems(22).Text & "', [TC_RA_RESTRICTRATE]='" & lstView.ListItems(I).ListSubItems(23).Text & "', [TC_RA_RESTRICTAMOUNT]='" & lstView.ListItems(I).ListSubItems(24).Text & "'," _
''            & "[TC_ITA_RATE1]='" & lstView.ListItems(I).ListSubItems(25).Text & "', [TC_ITA_QUALIFYINGCAPITALEXP]='" & lstView.ListItems(I).ListSubItems(26).Text & "', [TC_ITA_QUALIFYINGCAPITALEXP_AMOUNT]='" & lstView.ListItems(I).ListSubItems(27).Text & "', [TC_ITA_BALANCINGALLOWANCE]='" & lstView.ListItems(I).ListSubItems(28).Text & "', [TC_ITA_TOTAL1]='" & lstView.ListItems(I).ListSubItems(29).Text & "', [TC_ITA_RESTRICTRATE]='" & lstView.ListItems(I).ListSubItems(30).Text & "', [TC_ITA_RESTRICTAMOUNT]='" & lstView.ListItems(I).ListSubItems(31).Text & "'" _
''            & " WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' AND [TC_BUSINESS]=" & lstView.ListItems(I).Text
'             DB.Execute (cSQL)
''NGOHCS CA2008 END
            
'            Dim n As Integer
'            For n = 0 To UBound(objExportAllowance)
'                If objExportAllowance(n).strBusiness = lstView.ListItems(i).Text Then
'                    cSQL = "UPDATE [TAX_COMPUTATION] SET [TC_EA_UTL]='" & objExportAllowance(n).strUtilised & "', [TC_EA_TYPE]='" & objExportAllowance(n).strType & "', " _
'                    & "[TC_EA_CURR_COMPANY]='" & objExportAllowance(n).strAllowanceCompany & "', [TC_EA_CURR_AGRICULTURE]='" & objExportAllowance(n).strAllowanceAgriculture & "', [TC_EA_CURR_SIGNIFICANT]='" & objExportAllowance(n).strAllowanceSignificant & "', " _
'                    & "[TC_EA_CURR_MARKET]='" & objExportAllowance(n).strAllowanceMarket & "', [TC_EA_CURR_MSB]='" & objExportAllowance(n).strAllowanceService & "', [TC_EA_TOTAL]='" & objExportAllowance(n).strAllowance & "', " _
'                    & "[TC_EA_RESTRICTRATE]='" & objExportAllowance(n).strRestrictRate & "', [TC_EA_BF]= '" & objExportAllowance(n).strBalance & "', [TC_EA_CF]='" & objExportAllowance(n).strCarryForward & "'" _
'                    & " WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' AND [TC_BUSINESS]=" & lstView.ListItems(i).Text

'                    DB.Execute (cSQL)
'                    Exit For
'                End If
'            Next
                        
'            'LeeCC 2012.1 Export Allowance Computation
'            Call InsertExportAllowanceCompany(lstView.ListItems(i).ListSubItems(14).Text, lstView.ListItems(i).Text)
'            Call InsertExportAllowanceAgriculture(lstView.ListItems(i).ListSubItems(14).Text, lstView.ListItems(i).Text)
'            Call InsertExportAllowanceSignificant(lstView.ListItems(i).ListSubItems(14).Text, lstView.ListItems(i).Text)
'            Call InsertExportAllowanceMarket(lstView.ListItems(i).ListSubItems(14).Text, lstView.ListItems(i).Text)
'            Call InsertExportAllowanceService(lstView.ListItems(i).ListSubItems(14).Text, lstView.ListItems(i).Text)
'        Next
'    End If
    
'     ' === csNgoh 2008 === '
'    If Val(txtYA) >= 2008 Then
'        If ChkMajorC = 1 And ChkApply = 1 Then
'            check = 1
'        ElseIf ChkApply = 1 And ChkMajorC = 0 Then
'            check = 0
'        Else
'            check = 2
'        End If
'    Else
'        If ChkMajorC = 1 Then
'            check = 1
'        Else
'            check = 0
'        End If
'    End If
'     ' === End csNgoh 2008 === '
     

'    'If ChkMajorC = 1 Then
'    '    check = 1
'    'Else
'    '    check = 0
'    'End If
    
'    If lstViewCA.ListItems.count > 0 Then  'pin Add field Taxcom C+ v2005.4 SP1
'        For i = 1 To lstViewCA.ListItems.count
'            'cSQL = "UPDATE [TAX_COMPUTATION] SET [TC_CB_CA_BAL_BF]='" & lstViewCA.ListItems(I).ListSubItems(2).Text & "', " _
'            & "[TC_CB_CA_AA]='" & lstViewCA.ListItems(I).ListSubItems(3).Text & "', [TC_CB_CA_IA]='" & lstViewCA.ListItems(I).ListSubItems(4).Text & "', " _
'            & "[TC_CB_CA_BA]='" & lstViewCA.ListItems(I).ListSubItems(7).Text & "', [TC_CB_CA_CURR]='" & lstViewCA.ListItems(I).ListSubItems(6).Text & "', " _
'            & "[TC_CB_CA_CURR_BA]='" & lstViewCA.ListItems(I).ListSubItems(8).Text & "', [TC_CB_CA_UTIL]='" & lstViewCA.ListItems(I).ListSubItems(9).Text & "', [TC_CB_CA_BAL_CF]='" & lstViewCA.ListItems(I).ListSubItems(10).Text & "', " _
'            & "[TC_CB_CA_DISALLOW]='" & lstViewCA.ListItems(I).ListSubItems(11).Text & "', [TC_CB_CA_ABAL_CF]='" & lstViewCA.ListItems(I).ListSubItems(12).Text & "', " _
'            & "[TC_CB_CHECK]='" & check & "'," _
'            & "[TC_CB_CA_NA]='" & lstViewCA.ListItems(I).ListSubItems(5).Text & "', " _
'            & "[TC_DISALLOW_NOTE]='" & lstViewCA.ListItems(I).ListSubItems(13).Text & "'" _
'            & " WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' AND [TC_BUSINESS]=" & lstViewCA.ListItems(I).Text
            
'            ' === csNgoh Julai 2008 === '
'            'weihong Add TC_CB_CA_ACA
'            cSQL = "UPDATE [TAX_COMPUTATION] SET [TC_CB_CA_BAL_BF]='" & lstViewCA.ListItems(i).ListSubItems(2).Text & "', " _
'            & "[TC_CB_CA_AA]='" & lstViewCA.ListItems(i).ListSubItems(3).Text & "', [TC_CB_CA_IA]='" & lstViewCA.ListItems(i).ListSubItems(4).Text & "', " _
'            & "[TC_CB_CA_BA]='" & lstViewCA.ListItems(i).ListSubItems(7).Text & "', [TC_CB_CA_CURR]='" & lstViewCA.ListItems(i).ListSubItems(6).Text & "', " _
'            & "[TC_CB_CA_CURR_BA]='" & lstViewCA.ListItems(i).ListSubItems(8).Text & "', [TC_CB_CA_UTIL]='" & lstViewCA.ListItems(i).ListSubItems(9).Text & "', [TC_CB_CA_BAL_CF]='" & lstViewCA.ListItems(i).ListSubItems(10).Text & "', " _
'            & "[TC_CB_CA_DISALLOW]='" & lstViewCA.ListItems(i).ListSubItems(11).Text & "', [TC_CB_CA_ABAL_CF]='" & lstViewCA.ListItems(i).ListSubItems(12).Text & "', " _
'            & "[TC_CB_CHECK]='" & check & "'," _
'            & "[TC_CB_CA_NA]='" & lstViewCA.ListItems(i).ListSubItems(5).Text & "', " _
'            & "[TC_DISALLOW_NOTE]='" & lstViewCA.ListItems(i).ListSubItems(13).Text & "'," _
'            & "[TC_CB_CA_ACA]='" & lstViewCA.ListItems(i).ListSubItems(14).Text & "'" _
'            & " WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' AND [TC_BUSINESS]=" & lstViewCA.ListItems(i).Text
'            ' === end csNgoh Julai 2008 === '
            
'            DB.Execute (cSQL)
'        Next
'    End If
    
'    If ListViewRA.ListItems.count > 0 Then 'PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'        For i = 1 To ListViewRA.ListItems.count
'            If CDbl(ListViewRA.ListItems(i).ListSubItems(6).Text) < 0 Then
'                ListViewRA.ListItems(i).ListSubItems(6).Text = 0
'            End If
'           'TC_RA_TOTAL1
'            'TC_SI_RA
'            'TC_RA_RESTRICAMOUNT
            
''NGOHCS CA2008
''           'O2008.1
''            cSQL = "UPDATE [TAX_COMPUTATION] SET [TC_CB_RA_BAL_BF]='" & ListViewRA.ListItems(I).ListSubItems(2).Text & "', " _
''            & "[TC_CB_RA_CURR]='" & ListViewRA.ListItems(I).ListSubItems(3).Text & "', " & _
''            "[TC_CB_RA_BAL_BF_CURR]='" & FormatNumber(CDbl(ListViewRA.ListItems(I).ListSubItems(2)) + CDbl(ListViewRA.ListItems(I).ListSubItems(3)), 0) & "', " _
''            & "[TC_CB_RA_BAL_CF]='" & FormatNumber(ListViewRA.ListItems(I).ListSubItems(4).Text - ListViewRA.ListItems(I).ListSubItems(5).Text, 0) & "' " _
''            & " WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' AND [TC_BUSINESS]=" & ListViewRA.ListItems(I).Text
''            DB.Execute (cSQL)
'            Dim RACurrClaims As String
'            Dim RABalanceCF As String
'            RACurrClaims = FormatNumber(CDbl(ListViewRA.ListItems(i).ListSubItems(2)) + CDbl(ListViewRA.ListItems(i).ListSubItems(3)) - CDbl(ListViewRA.ListItems(i).ListSubItems(7)), 0)
'            RABalanceCF = FormatNumber(CDbl(ListViewRA.ListItems(i).ListSubItems(4).Text) - CDbl(ListViewRA.ListItems(i).ListSubItems(5).Text) - CDbl(ListViewRA.ListItems(i).ListSubItems(8).Text), 0)
            
'            If CDbl(RACurrClaims) < 0 Then
'            RACurrClaims = "0"
'            End If
'            If CDbl(RABalanceCF) < 0 Then
'            RABalanceCF = "0"
'            End If
            
'            cSQL = "UPDATE [TAX_COMPUTATION] SET [TC_CB_RA_BAL_BF]='" & ListViewRA.ListItems(i).ListSubItems(2).Text & "', " _
'            & "[TC_CB_RA_CURR]='" & ListViewRA.ListItems(i).ListSubItems(3).Text & "', " _
'            & "[TC_CB_RA_BAL_BF_CURR]='" & RACurrClaims & "', " _
'            & "[TC_CB_RA_BAL_CF]='" & RABalanceCF & "', [TC_CB_RA_UTIL]='" & ListViewRA.ListItems(i).ListSubItems(5).Text & "', " _
'            & "[TC_RA_WITHDRAWAL]='" & ListViewRA.ListItems(i).ListSubItems(7).Text & "', [TC_RA_ADJUSTMENT]='" & ListViewRA.ListItems(i).ListSubItems(8).Text & "'" _
'            & " WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' AND [TC_BUSINESS]=" & ListViewRA.ListItems(i).Text
'            DB.Execute (cSQL)
''NGOHCS CA2008 END
            
'        Next
        
'    End If
'        'O2008.1
'     If ListViewITA.ListItems.count > 0 Then 'PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'        For i = 1 To ListViewITA.ListItems.count
'            If CDbl(ListViewITA.ListItems(i).ListSubItems(6).Text) < 0 Then
'                ListViewITA.ListItems(i).ListSubItems(6).Text = 0
'            End If
            
''NGOHCS CA2008
''            cSQL = "UPDATE [TAX_COMPUTATION] SET [TC_CB_ITA_BAL_BF]='" & ListViewITA.ListItems(I).ListSubItems(2).Text & "', " _
''            & "[TC_CB_ITA_CURR]='" & ListViewITA.ListItems(I).ListSubItems(3).Text & _
''              "', [TC_CB_ITA_BAL_BF_CURR]='" & FormatNumber(CDbl(ListViewITA.ListItems(I).ListSubItems(2)) + CDbl(ListViewITA.ListItems(I).ListSubItems(3)), 0) & "', " _
''            & "[TC_CB_ITA_BAL_CF]='" & FormatNumber(ListViewITA.ListItems(I).ListSubItems(4).Text - ListViewITA.ListItems(I).ListSubItems(5).Text, 0) & "' " _
''            & " WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' AND [TC_BUSINESS]=" & ListViewRA.ListItems(I).Text
''            DB.Execute (cSQL)
'            Dim ITACurrClaims As String
'            Dim ITABalanceCF As String
'            ITACurrClaims = FormatNumber(CDbl(ListViewITA.ListItems(i).ListSubItems(2)) + CDbl(ListViewITA.ListItems(i).ListSubItems(3)) - CDbl(ListViewITA.ListItems(i).ListSubItems(7)), 0)
'            ITABalanceCF = FormatNumber(CDbl(ListViewITA.ListItems(i).ListSubItems(4).Text) - CDbl(ListViewITA.ListItems(i).ListSubItems(5).Text) - CDbl(ListViewITA.ListItems(i).ListSubItems(8).Text), 0)
            
'            If CDbl(ITACurrClaims) < 0 Then
'            ITACurrClaims = "0"
'            End If
'            If CDbl(ITABalanceCF) < 0 Then
'            ITABalanceCF = "0"
'            End If
            
'            cSQL = "UPDATE [TAX_COMPUTATION] SET [TC_CB_ITA_BAL_BF]='" & ListViewITA.ListItems(i).ListSubItems(2).Text & "', " _
'            & "[TC_CB_ITA_CURR]='" & ListViewITA.ListItems(i).ListSubItems(3).Text & "', " _
'            & "[TC_CB_ITA_BAL_BF_CURR]='" & ITACurrClaims & "', " _
'            & "[TC_CB_ITA_BAL_CF]='" & ITABalanceCF & "', [TC_CB_ITA_UTIL]='" & ListViewITA.ListItems(i).ListSubItems(5).Text & "', " _
'            & "[TC_ITA_WITHDRAWAL]='" & ListViewITA.ListItems(i).ListSubItems(7).Text & "', [TC_ITA_ADJUSTMENT]='" & ListViewITA.ListItems(i).ListSubItems(8).Text & "'" _
'            & " WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' AND [TC_BUSINESS]=" & ListViewRA.ListItems(i).Text
'            DB.Execute (cSQL)
''NGOHCS CA2008 END

'        Next
'    End If

    
'    'cSQL = "UPDATE [TAX_COMPUTATION] SET [TC_SI_TOT]='" & txtAllStatIn & "', [TC_SI_BS_LOSS_BF]='" & txtBsLoss & "', [TC_SI_AGGREGATE]='" & txtAggregate & "', " _
'    '& "[TC_NB_DIV]='" & txtDividendIn(1) & "', [TC_NB_DIV_ATT_INT]='" & txtDivAttrInt & "', [TC_NB_DIV_NET]='" & txtNetDividend & "', " _
'    '& "[TC_NB_INT]='" & txtInterestIn(0) & "', [TC_NB_INT_ATT_INT]='" & txtIntAttrInt & "', [TC_NB_INT_NET]='" & txtNetIntIn & "', " _
'    '& "[TC_NB_RENT]='" & txtRentalIn & "', [TC_NB_RENT_ATT_INT]='" & txtRentAttrIn & "', [TC_NB_RENT_ASSESS]='" & txtRentAssess & "', [TC_NB_RENT_QUIT]='" & txtRentQuit & "', " _
'    '& "[TC_NB_RENT_INSUR]='" & txtRentInsur & "', [TC_NB_RENT_OTH]='" & txtRentOthExp & "', [TC_NB_RENT_MAIN]='" & txtRentRepair & "', [TC_NB_RENT_AGREE]='" & txtRentRenewal & "', [TC_NB_RENT_NET]='" & txtNetRentalIn & "', " _
'    '& "[TC_NB_ROYALTY]='" & txtRoyaltyIncome & "', [TC_NB_SUNDRY]='" & txtSundryIn & "', [TC_NB_ADDITION]='" & txtAddition & "', [TC_NB_OTH_AGGR_STAT]='" & txtOthAggregate & "', " _
'    '& "[TC_TP_AGGR_IN]='" & txtAggregateIn & "', [TC_TP_CURR_LOSS]='" & txtCurrBsLoss & "', [TC_TP_AGGR_IN_LOSS]='" & txtAggrLoss & "', " _
'    '& "[TC_TP_PROSPECTING]='" & txtProspecting & "', [TC_TP_QUALIFY_AGRICULTURE]='" & txtQualifyAgri & "', [TC_TP_PREOP_BS]='" & txtPreopBs & "', [TC_TP_FOOD_PRODUCTION]='" & txtFoodProduct & "', [TC_TP_EXP_ALLOWED]='" & txtExpAllowed & "', " _
'    '& "[TC_TP_TOTAL_OTH_EXP]='" & txtTotalOthExp & "', [TC_TP_APRV_DONATION]='" & txtApprDonation & "', [TC_TP_TOTAL_INCOME]='" & txtTotalIncome & "', " _
'    '& "[TC_TP_PIONEER_CHARGE]='" & txtPioneerChargeable & "', [TC_TP_CHARGEABLE]='" & txtChargeableIn & "', [TC_TP_OPERATIONALHQ_CHARGE]='" & txtOpHQChargeable & "', [TC_TP_FOREIGN_CHARGE]='" & txtForeignChargeable & "', " _
'    '& "[TC_TP_APP_CHARGEABLE1]='" & txtAppChargeableIn1 & "', [TC_TP_APP_CHARGEABLE2]='" & txtAppChargeableIn2 & "', [TC_TP_APP_CHARGEABLE3]='" & txtAppChargeableIn3 & "', [TC_TP_APP_CHARGEABLE4]='" & txtAppChargeableIn4 & "', [TC_TP_APP_CHARGEABLE4A]='" & txtAppChargeableIn4a & "', [TC_TP_APP_CHARGEABLE5]='" & txtAppChargeableIn5 & "', [TC_TP_APP_CHARGEABLE6]='" & txtAppChargeableIn6 & "', " _
'    '& "[TC_TP_RATE1]=" & txtRate1 & ", [TC_TP_RATE2]=" & txtRate2 & ", [TC_TP_RATE3]=" & txtRate3 & ", [TC_TP_RATE4]=" & txtRate4 & ", [TC_TP_RATE4A]=" & txtRate4a & ", [TC_TP_RATE5]=" & txtRate5 & ", [TC_TP_RATE6]=" & txtRate6 & ", " _
'    '& "[TC_TP_RATE1_CHARGEABLE]='" & txtITPChargeableIn1 & "', [TC_TP_RATE2_CHARGEABLE]='" & txtITPChargeableIn2 & "', [TC_TP_RATE3_CHARGEABLE]='" & txtITPChargeableIn3 & "', [TC_TP_RATE4_CHARGEABLE]='" & txtITPChargeableIn4 & "', [TC_TP_RATE4A_CHARGEABLE]='" & txtITPChargeableIn4a & "', [TC_TP_28_CHARGEABLE]='" & txtITPChargeableIn5 & "', [TC_TP_RATE5_CHARGEABLE]='" & txtITPChargeableIn6 & "', " _
'    '& "[TC_TP_TOT_TAX_CHARGED]='" & txtTotalTaxCharged & "', [TC_TP_SEC6B_REBATE]='" & txtSec6BRebate & "', [TC_TP_SEC110]='" & txtITPSetoff & "', [TC_TP_SEC110_OTHERS]='" & txtITPSetoffOth & "', [TC_TP_SEC132]='" & txtSec132 & "', [TC_TP_SEC133]='" & txtSec133 & "', [TC_TP_TOT_SETOFF]='" & txtTotalSetoff & "', " _
'    '& "[TC_TP_PAYABLE]='" & txtITP & "', [TC_TP_INSTALL]='" & txtInstallments & "', [TC_TP_PAYABLE_BAL]='" & txtTPBal & "', " _
'    '& "[TC_CB_LS_BAL_BF]='" & txtULBalbf & "', [TC_CB_LS_UTIL]='" & txtULUtilised & "', [TC_CB_LS_BAL_UTIL]='" & txtULBalUtil & "', [TC_CB_LS_ADJUST_LOSS]='" & txtCurrentYrLoss & "', [TC_CB_LS_UTIL_CURR]='" & txtULUtilisedCurr & "', [TC_CB_LS_UNABSORBED]='" & txtUBL & "', [TC_CB_LS_BAL_CF]='" & txtULBalcf & "', " _
'    '& "[TC_CB_ITA_UTIL]='" & txtITAUtilised & "',  " _
'    '& "[TC_TP_ZAKAT] ='" & txtZakat & "',[TC_TP_CLAIM] ='" & txtClaim & "',[TC_CB_LS_SAMOUNT] ='" & txtSrdAmt & "',[TC_CB_LS_BALS_CF] ='" & txtBalcf & "',[TC_CB_LS_D_BL] ='" & txtDisABL & "'," _
'    '& "[TC_CB_LS_SRDAMT2]='" & txtSrdAmt2 & "', [TC_CB_LS_BLNBF]='" & txtBlnBf & "', [TC_CB_LS_AMTTUT]='" & txtAmtTut & "', [TC_CB_LS_BLNCF]='" & txtBlnCf & "'" _
'    '& " WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' AND [TC_BUSINESS]=" & cSourceNo
'    'DB.Execute (cSQL) 'PIN TAXCOM C+ V2005.4 SP1 'PIN TAXCOM C+ V2005.4 SP2
    
'  ' === csNgoh 2008 === '
'    'cSQL = "UPDATE [TAX_COMPUTATION] SET [TC_SI_TOT]='" & txtAllStatIn & "', [TC_SI_BS_LOSS_BF]='" & txtBsLoss & "', [TC_SI_AGGREGATE]='" & txtAggregate & "', " _
'    '& "[TC_NB_DIV]='" & txtDividendIn(1) & "', [TC_NB_DIV_ATT_INT]='" & txtDivAttrInt & "', [TC_NB_DIV_NET]='" & txtNetDividend & "', " _
'    '& "[TC_NB_INT]='" & txtInterestIn(0) & "', [TC_NB_INT_ATT_INT]='" & txtIntAttrInt & "', [TC_NB_INT_NET]='" & txtNetIntIn & "', " _
'    '& "[TC_NB_RENT]='" & txtRentalIn & "', [TC_NB_RENT_ATT_INT]='" & txtRentAttrIn & "', [TC_NB_RENT_ASSESS]='" & txtRentAssess & "', [TC_NB_RENT_QUIT]='" & txtRentQuit & "', " _
'    '& "[TC_NB_RENT_INSUR]='" & txtRentInsur & "', [TC_NB_RENT_OTH]='" & txtRentOthExp & "', [TC_NB_RENT_MAIN]='" & txtRentRepair & "', [TC_NB_RENT_AGREE]='" & txtRentRenewal & "', [TC_NB_RENT_NET]='" & txtNetRentalIn & "', " _
'    '& "[TC_NB_ROYALTY]='" & txtRoyaltyIncome & "', [TC_NB_SUNDRY]='" & txtSundryIn & "', [TC_NB_ADDITION]='" & txtAddition & "', [TC_NB_OTH_AGGR_STAT]='" & txtOthAggregate & "', " _
'    '& "[TC_TP_AGGR_IN]='" & txtAggregateIn & "', [TC_TP_CURR_LOSS]='" & txtCurrBsLoss & "', [TC_TP_AGGR_IN_LOSS]='" & txtAggrLoss & "', " _
'    '& "[TC_TP_PROSPECTING]='" & txtProspecting & "', [TC_TP_QUALIFY_AGRICULTURE]='" & txtQualifyAgri & "', [TC_TP_PREOP_BS]='" & txtPreopBs & "', [TC_TP_FOOD_PRODUCTION]='" & txtFoodProduct & "', [TC_TP_EXP_ALLOWED]='" & txtExpAllowed & "', " _
'    '& "[TC_TP_TOTAL_OTH_EXP]='" & txtTotalOthExp & "', [TC_TP_APRV_DONATION]='" & txtApprDonation & "', [TC_TP_TOTAL_INCOME]='" & txtTotalIncome & "', " _
'    '& "[TC_TP_PIONEER_CHARGE]='" & txtPioneerChargeable & "', [TC_TP_CHARGEABLE]='" & txtChargeableIn & "', [TC_TP_OPERATIONALHQ_CHARGE]='" & txtOpHQChargeable & "', [TC_TP_FOREIGN_CHARGE]='" & txtForeignChargeable & "', " _
'    '& "[TC_TP_APP_CHARGEABLE1]='" & txtAppChargeableIn1 & "', [TC_TP_APP_CHARGEABLE2]='" & txtAppChargeableIn2 & "', [TC_TP_APP_CHARGEABLE3]='" & txtAppChargeableIn3 & "', [TC_TP_APP_CHARGEABLE4]='" & txtAppChargeableIn4 & "', [TC_TP_APP_CHARGEABLE4A]='" & txtAppChargeableIn4a & "', [TC_TP_APP_CHARGEABLE5]='" & txtAppChargeableIn5 & "', [TC_TP_APP_CHARGEABLE6]='" & txtAppChargeableIn6 & "', " _
'    '& "[TC_TP_RATE1]=" & txtRate1 & ", [TC_TP_RATE2]=" & txtRate2 & ", [TC_TP_RATE3]=" & txtRate3 & ", [TC_TP_RATE4]=" & txtRate4 & ", [TC_TP_RATE4A]=" & txtRate4a & ", [TC_TP_RATE5]=" & txtRate5 & ", [TC_TP_RATE6]=" & txtRate6 & ", " _
'    '& "[TC_TP_RATE1_CHARGEABLE]='" & txtITPChargeableIn1 & "', [TC_TP_RATE2_CHARGEABLE]='" & txtITPChargeableIn2 & "', [TC_TP_RATE3_CHARGEABLE]='" & txtITPChargeableIn3 & "', [TC_TP_RATE4_CHARGEABLE]='" & txtITPChargeableIn4 & "', [TC_TP_RATE4A_CHARGEABLE]='" & txtITPChargeableIn4a & "', [TC_TP_28_CHARGEABLE]='" & txtITPChargeableIn5 & "', [TC_TP_RATE5_CHARGEABLE]='" & txtITPChargeableIn6 & "', " _
'    '& "[TC_TP_TOT_TAX_CHARGED]='" & txtTotalTaxCharged & "', [TC_TP_SEC6B_REBATE]='" & txtSec6BRebate & "', [TC_TP_SEC110]='" & txtITPSetoff & "', [TC_TP_SEC110_OTHERS]='" & txtITPSetoffOth & "', [TC_TP_SEC132]='" & txtSec132 & "', [TC_TP_SEC133]='" & txtSec133 & "', [TC_TP_TOT_SETOFF]='" & txtTotalSetoff & "', " _
'    '& "[TC_TP_PAYABLE]='" & txtITP & "', [TC_TP_INSTALL]='" & txtInstallments & "', [TC_TP_PAYABLE_BAL]='" & txtTPBal & "', " _
'    '& "[TC_CB_LS_BAL_BF]='" & txtULBalbf & "', [TC_CB_LS_UTIL]='" & txtULUtilised & "', [TC_CB_LS_BAL_UTIL]='" & txtULBalUtil & "', [TC_CB_LS_ADJUST_LOSS]='" & txtCurrentYrLoss & "', [TC_CB_LS_UTIL_CURR]='" & txtULUtilisedCurr & "', [TC_CB_LS_UNABSORBED]='" & txtUBL & "', [TC_CB_LS_BAL_CF]='" & txtULBalcf & "', " _
'    '& "[TC_CB_ITA_UTIL]='" & txtITAUtilised & "',  " _
'    '& "[TC_TP_ZAKAT] ='" & txtZakat & "',[TC_TP_CLAIM] ='" & txtClaim & "',[TC_CB_LS_SAMOUNT] ='" & txtSrdAmt & "',[TC_CB_LS_BALS_CF] ='" & txtBalcf & "',[TC_CB_LS_D_BL] ='" & txtDisABL & "'," _
'    '& "[TC_CB_LS_SRDAMT2]='" & txtSrdAmt2 & "', [TC_CB_LS_BLNBF]='" & txtBlnBf & "', [TC_CB_LS_AMTTUT]='" & txtAmtTut & "', [TC_CB_LS_BLNCF]='" & txtBlnCf & "'," _
'    '& "[TC_TP_SEC110B]='" & txt110BSetOff & "', [TC_STAT_DIVIDEND] ='" & txtSIFrmDiv & "'" _
'    '& " WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' AND [TC_BUSINESS]=" & cSourceNo
'    'DB.Execute (cSQL)
'    ' === End csNgoh 2008 === '
    
'    ' === csNgoh C2008.5 === '
''    cSQL = "UPDATE [TAX_COMPUTATION] SET [TC_SI_TOT]='" & txtAllStatIn & "', [TC_SI_BS_LOSS_BF]='" & txtBsLoss & "', [TC_SI_AGGREGATE]='" & txtAggregate & "', " _
''    & "[TC_NB_DIV]='" & txtDividendIn(1) & "', [TC_NB_DIV_ATT_INT]='" & txtDivAttrInt & "', [TC_NB_DIV_NET]='" & txtNetDividend & "', " _
''    & "[TC_NB_INT]='" & txtInterestIn(0) & "', [TC_NB_INT_ATT_INT]='" & txtIntAttrInt & "', [TC_NB_INT_NET]='" & txtNetIntIn & "', " _
''    & "[TC_NB_RENT]='" & txtRentalIn & "', [TC_NB_RENT_ATT_INT]='" & txtRentAttrIn & "', [TC_NB_RENT_ASSESS]='" & txtRentAssess & "', [TC_NB_RENT_QUIT]='" & txtRentQuit & "', " _
''    & "[TC_NB_RENT_INSUR]='" & txtRentInsur & "', [TC_NB_RENT_OTH]='" & txtRentOthExp & "', [TC_NB_RENT_MAIN]='" & txtRentRepair & "', [TC_NB_RENT_AGREE]='" & txtRentRenewal & "', [TC_NB_RENT_NET]='" & txtNetRentalIn & "', " _
''    & "[TC_NB_ROYALTY]='" & txtRoyaltyIncome & "', [TC_NB_SUNDRY]='" & txtSundryIn & "', [TC_NB_ADDITION]='" & txtAddition & "', [TC_NB_OTH_AGGR_STAT]='" & txtOthAggregate & "', " _
''    & "[TC_TP_AGGR_IN]='" & txtAggregateIn & "', [TC_TP_CURR_LOSS]='" & txtCurrBsLoss & "', [TC_TP_AGGR_IN_LOSS]='" & txtAggrLoss & "', " _
''    & "[TC_TP_PROSPECTING]='" & txtProspecting & "', [TC_TP_QUALIFY_AGRICULTURE]='" & txtQualifyAgri & "', [TC_TP_PREOP_BS]='" & txtPreopBs & "', [TC_TP_FOOD_PRODUCTION]='" & txtFoodProduct & "', [TC_TP_EXP_ALLOWED]='" & txtExpAllowed & "', " _
''    & "[TC_TP_TOTAL_OTH_EXP]='" & txtTotalOthExp & "', [TC_TP_APRV_DONATION]='" & txtApprDonation & "', [TC_TP_TOTAL_INCOME]='" & txtTotalIncome & "', " _
''    & "[TC_TP_PIONEER_CHARGE]='" & txtPioneerChargeable & "', [TC_TP_CHARGEABLE]='" & txtChargeableIn & "', [TC_TP_OPERATIONALHQ_CHARGE]='" & txtOpHQChargeable & "', [TC_TP_FOREIGN_CHARGE]='" & txtForeignChargeable & "', " _
''    & "[TC_TP_APP_CHARGEABLE1]='" & txtAppChargeableIn1 & "', [TC_TP_APP_CHARGEABLE2]='" & txtAppChargeableIn2 & "', [TC_TP_APP_CHARGEABLE3]='" & txtAppChargeableIn3 & "', [TC_TP_APP_CHARGEABLE4]='" & txtAppChargeableIn4 & "', [TC_TP_APP_CHARGEABLE4A]='" & txtAppChargeableIn4a & "', [TC_TP_APP_CHARGEABLE5]='" & txtAppChargeableIn5 & "', [TC_TP_APP_CHARGEABLE6]='" & txtAppChargeableIn6 & "', " _
''    & "[TC_TP_RATE1]=" & txtRate1 & ", [TC_TP_RATE2]=" & txtRate2 & ", [TC_TP_RATE3]=" & txtRate3 & ", [TC_TP_RATE4]=" & txtRate4 & ", [TC_TP_RATE4A]=" & txtRate4a & ", [TC_TP_RATE5]=" & txtRate5 & ", [TC_TP_RATE6]=" & txtRate6 & ", " _
''    & "[TC_TP_RATE1_CHARGEABLE]='" & txtITPChargeableIn1 & "', [TC_TP_RATE2_CHARGEABLE]='" & txtITPChargeableIn2 & "', [TC_TP_RATE3_CHARGEABLE]='" & txtITPChargeableIn3 & "', [TC_TP_RATE4_CHARGEABLE]='" & txtITPChargeableIn4 & "', [TC_TP_RATE4A_CHARGEABLE]='" & txtITPChargeableIn4a & "', [TC_TP_28_CHARGEABLE]='" & txtITPChargeableIn5 & "', [TC_TP_RATE5_CHARGEABLE]='" & txtITPChargeableIn6 & "', " _
''    & "[TC_TP_TOT_TAX_CHARGED]='" & txtTotalTaxCharged & "', [TC_TP_SEC6B_REBATE]='" & txtSec6BRebate & "', [TC_TP_SEC110]='" & txtITPSetoff & "', [TC_TP_SEC110_OTHERS]='" & txtITPSetoffOth & "', [TC_TP_SEC132]='" & txtSec132 & "', [TC_TP_SEC133]='" & txtSec133 & "', [TC_TP_TOT_SETOFF]='" & txtTotalSetoff & "', " _
''    & "[TC_TP_PAYABLE]='" & txtITP & "', [TC_TP_INSTALL]='" & txtInstallments & "', [TC_TP_PAYABLE_BAL]='" & txtTPBal & "', " _
''    & "[TC_CB_LS_BAL_BF]='" & txtULBalbf & "', [TC_CB_LS_UTIL]='" & txtULUtilised & "', [TC_CB_LS_BAL_UTIL]='" & txtULBalUtil & "', [TC_CB_LS_ADJUST_LOSS]='" & txtCurrentYrLoss & "', [TC_CB_LS_UTIL_CURR]='" & txtULUtilisedCurr & "', [TC_CB_LS_UNABSORBED]='" & txtUBL & "', [TC_CB_LS_BAL_CF]='" & txtULBalcf & "', " _
''    & "[TC_CB_ITA_UTIL]='" & txtITAUtilised & "',  " _
''    & "[TC_TP_ZAKAT] ='" & txtZakat & "',[TC_TP_CLAIM] ='" & txtClaim & "',[TC_CB_LS_SAMOUNT] ='" & txtSrdAmt & "',[TC_CB_LS_BALS_CF] ='" & txtBalcf & "',[TC_CB_LS_D_BL] ='" & txtDisABL & "'," _
''    & "[TC_CB_LS_SRDAMT2]='" & txtSrdAmt2 & "', [TC_CB_LS_BLNBF]='" & txtBlnBf & "', [TC_CB_LS_AMTTUT]='" & txtAmtTut & "', [TC_CB_LS_BLNCF]='" & txtBlnCf & "'," _
''    & "[TC_TP_SEC110B]='" & txt110BSetOff & "', [TC_STAT_DIVIDEND] ='" & txtSIFrmDiv & "', [TC_NB_RENT_OTH2] = '" & txtOthers & "'" _
''    & " WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' AND [TC_BUSINESS]=" & cSourceNo
''    DB.Execute (cSQL)
'    ' === end csNgoh C2008.5 === '
     
'    ' HS : 2009 : C2008.7 : Change Unabsorbed business loss'
'    Dim checkstatus As String
'    If Me.chkCBL.Value = 1 Then
'        checkstatus = "1"
'    Else
'        checkstatus = "0"
'    End If
    
'    'cSQL = "UPDATE [TAX_COMPUTATION] SET [TC_SI_TOT]='" & txtAllStatIn & "', [TC_SI_TOT_PARTNERSHIP] ='" & txtTotal & "', [TC_SI_BS_LOSS_BF]='" & txtBsLoss & "', [TC_SI_AGGREGATE]='" & txtAggregate & "', " _
'    '& "[TC_NB_DIV]='" & txtDividendIn & "', [TC_NB_DIV_ATT_INT]='" & txtDivAttrInt & "', [TC_NB_DIV_OTH]='" & txtDivOthers & "', [TC_NB_DIV_NET]='" & txtDividendIncome & "', " _
'    '& "[TC_NB_INT]='" & txtInterestIn & "', [TC_NB_INT_ATT_INT]='" & txtIntAttrInt & "', [TC_NB_INT_OTH]='" & txtIntOthers & "', [TC_NB_INT_NET]='" & txtInterestIncome & "', " _
'    '& "[TC_NB_RENT]='" & txtRentalIn & "', [TC_NB_RENT_ATT_INT]='" & txtRentAttrIn & "', [TC_NB_RENT_ASSESS]='" & txtRentAssess & "', [TC_NB_RENT_QUIT]='" & txtRentQuit & "', " _
'    '& "[TC_NB_RENT_INSUR]='" & txtRentInsur & "', [TC_NB_RENT_OTH]='" & txtRentOthExp & "', [TC_NB_RENT_MAIN]='" & txtRentRepair & "', [TC_NB_RENT_AGREE]='" & txtRentRenewal & "', [TC_NB_RENT_NET]='" & txtRentalIncome & "', " _
'    '& "[TC_NB_ROYALTY]='" & txtRoyaltyIncome & "', [TC_NB_SUNDRY]='" & txtSundryIn & "' , [TC_SUNDRY_EXP]='" & txtDirExpenses3 & "', [TC_NB_ADDITION]='" & txtAddition & "', [TC_NB_OTH_AGGR_STAT]='" & txtOthAggregate & "', " _
'    '& "[TC_TP_AGGR_IN]='" & txtAggregateIn & "', [TC_TP_CURR_LOSS]='" & txtCurrBsLoss & "', [TC_TP_AGGR_IN_LOSS]='" & txtAggrLoss & "', " _
'    '& "[TC_TP_PROSPECTING]='" & txtProspecting & "', [TC_TP_QUALIFY_AGRICULTURE]='" & txtQualifyAgri & "', [TC_TP_PREOP_BS]='" & txtPreopBs & "', [TC_TP_FOOD_PRODUCTION]='" & txtFoodProduct & "', [TC_TP_EXP_ALLOWED]='" & txtExpAllowed & "', " _
'    '& "[TC_TP_TOTAL_OTH_EXP]='" & txtTotalOthExp & "', [TC_TP_APRV_DONATION]='" & txtApprDonation & "', [TC_TP_TOTAL_INCOME]='" & txtTotalIncome & "', " _
'    '& "[TC_TP_PIONEER_CHARGE]='" & txtPioneerChargeable & "', [TC_TP_CHARGEABLE]='" & txtChargeableIn & "', [TC_TP_OPERATIONALHQ_CHARGE]='" & txtOpHQChargeable & "', [TC_TP_FOREIGN_CHARGE]='" & txtForeignChargeable & "', " _
'    '& "[TC_TP_APP_CHARGEABLE1]='" & txtAppChargeableIn1 & "', [TC_TP_APP_CHARGEABLE2]='" & txtAppChargeableIn2 & "', [TC_TP_APP_CHARGEABLE3]='" & txtAppChargeableIn3 & "', [TC_TP_APP_CHARGEABLE4]='" & txtAppChargeableIn4 & "', [TC_TP_APP_CHARGEABLE4A]='" & txtAppChargeableIn4a & "', [TC_TP_APP_CHARGEABLE5]='" & txtAppChargeableIn5 & "', [TC_TP_APP_CHARGEABLE6]='" & txtAppChargeableIn6 & "', " _
'    '& "[TC_TP_RATE1]=" & txtRate1 & ", [TC_TP_RATE2]=" & txtRate2 & ", [TC_TP_RATE3]=" & txtRate3 & ", [TC_TP_RATE4]=" & txtRate4 & ", [TC_TP_RATE4A]=" & txtRate4a & ", [TC_TP_RATE5]=" & txtRate5 & ", [TC_TP_RATE6]=" & txtRate6 & ", " _
'    '& "[TC_TP_RATE1_CHARGEABLE]='" & txtITPChargeableIn1 & "', [TC_TP_RATE2_CHARGEABLE]='" & txtITPChargeableIn2 & "', [TC_TP_RATE3_CHARGEABLE]='" & txtITPChargeableIn3 & "', [TC_TP_RATE4_CHARGEABLE]='" & txtITPChargeableIn4 & "', [TC_TP_RATE4A_CHARGEABLE]='" & txtITPChargeableIn4a & "', [TC_TP_28_CHARGEABLE]='" & txtITPChargeableIn5 & "', [TC_TP_RATE5_CHARGEABLE]='" & txtITPChargeableIn6 & "', " _
'    '& "[TC_TP_TOT_TAX_CHARGED]='" & txtTotalTaxCharged & "', [TC_TP_SEC6B_REBATE]='" & txtSec6BRebate & "', [TC_TP_SEC110]='" & txtITPSetoff & "', [TC_TP_SEC110_OTHERS]='" & txtITPSetoffOth & "', [TC_TP_SEC132]='" & txtSec132 & "', [TC_TP_SEC133]='" & txtSec133 & "', [TC_TP_TOT_SETOFF]='" & txtTotalSetoff & "', " _
'    '& "[TC_TP_PAYABLE]='" & txtITP & "', [TC_TP_INSTALL]='" & txtInstallments & "', [TC_TP_PAYABLE_BAL]='" & txtTPBal & "', " _
'    '& "[TC_CB_LS_BAL_BF]='" & txtULBalbf & "', [TC_CB_LS_UTIL]='" & txtULUtilised & "', [TC_CB_LS_BAL_UTIL]='" & txtULBalUtil & "', [TC_CB_LS_ADJUST_LOSS]='" & txtCurrentYrLoss & "', [TC_CB_LS_UTIL_CURR]='" & txtULUtilisedCurr & "', [TC_CB_LS_UNABSORBED]='" & txtUBL & "', [TC_CB_LS_BAL_CF]='" & txtULBalcf & "', " _
'    '& "[TC_CB_ITA_UTIL]='" & txtITAUtilised & "',  " _
'    '& "[TC_TP_ZAKAT] ='" & txtZakat & "',[TC_TP_CLAIM] ='" & txtClaim & "',[TC_CB_LS_SAMOUNT] ='" & txtSrdAmt & "',[TC_CB_LS_BALS_CF] ='" & txtBalcf & "',[TC_CB_LS_D_BL] ='" & txtDisABL & "'," _
'    '& "[TC_CB_LS_SRDAMT2]='" & txtSrdAmt2 & "', [TC_CB_LS_BLNBF]='" & txtBlnBf & "', [TC_CB_LS_AMTTUT]='" & txtAmtTut & "', [TC_CB_LS_BLNCF]='" & txtBlnCf & "'," _
'    '& "[TC_NB_CARRYBCKLOSS]='" & txtCBL.Text & "', [TC_NB_AMTNOTCARRYBCK]='" & txtANCB.Text & "', [TC_NB_CHKCB]='" & checkstatus & "'," _
'    '& "[TC_TP_SEC110B]='" & txt110BSetOff & "', [TC_STAT_DIVIDEND] ='" & txtSIFrmDiv & "', [TC_NB_RENT_OTH2] = '" & txtOthers & "'," _
'    '& "[TC_TP_INCOME_TP2]='" & txtInTaxPay2 & "', [TC_TP_INCOME_TP3] ='" & txtInTaxPay3 & "', [TC_TP_ESTIMATED_TP] = '" & txtEsTaxPay & "'," _
'    '& "[TC_TP_ALL_DIFF]='" & txtAllowDiff & "', [TC_TP_EX_DIFF] ='" & txtExDiff & "', [TC_TP_PEN_DIFF] = '" & txtPenOnExDiff & "'," _
'    '& "[TC_NB_RENTIBA] ='" & txtRentalInIBA & "', [TC_NB_RENTIBA_ATT_IN]='" & txtRentAttrInIBA & "', [TC_NB_RENTIBA_ASSESS]='" & txtRentAssessIBA & "', [TC_NB_RENTIBA_QUIT]='" & txtRentQuitIBA & "', [TC_NB_RENTIBA_INSUR]='" & txtRentInsurIBA & "', [TC_NB_RENTIBA_OTH]='" & txtRentOthExpIBA & "', [TC_NB_RENTIBA_MAIN]='" & txtRentRepairIBA & "', [TC_NB_RENTIBA_AGREE]='" & txtRentRenewalIBA & "', [TC_NB_RENTIBA_IBA]='" & txtOthersIBA & "', [TC_NB_DIV_DIS_ATT_INT]='" & txtIntDisallow & "', [TC_NB_DIV_TOT_ATT_INT]='" & txtTotalInterest & "'" _
'    '& " WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' AND [TC_BUSINESS]=" & cSourceNo
'    'DB.Execute (cSQL) '==Oscar has update new fields=='Excessive Difference Penalty Tab 'LeeCC 2012 Disallowed Interest
    
'    'dannylee 2012 su5.2
'    cSQL = "UPDATE [TAX_COMPUTATION] SET [TC_SI_TOT]='" & txtAllStatIn & "', [TC_SI_TOT_PARTNERSHIP] ='" & txtTotal & "', [TC_SI_BS_LOSS_BF]='" & txtBsLoss & "', [TC_SI_AGGREGATE]='" & txtAggregate & "', " _
'    & "[TC_NB_DIV]='" & txtDividendIn & "', [TC_NB_DIV_ATT_INT]='" & txtDivAttrInt & "', [TC_NB_DIV_OTH]='" & txtDivOthers & "', [TC_NB_DIV_NET]='" & txtDividendIncome & "', " _
'    & "[TC_NB_INT]='" & txtInterestIn & "', [TC_NB_INT_ATT_INT]='" & txtIntAttrInt & "', [TC_NB_INT_OTH]='" & txtIntOthers & "', [TC_NB_INT_NET]='" & txtInterestIncome & "', " _
'    & "[TC_NB_RENT]='" & txtRentalIn & "', [TC_NB_RENT_ATT_INT]='" & txtRentAttrIn & "', [TC_NB_RENT_ASSESS]='" & txtRentAssess & "', [TC_NB_RENT_QUIT]='" & txtRentQuit & "', " _
'    & "[TC_NB_RENT_INSUR]='" & txtRentInsur & "', [TC_NB_RENT_OTH]='" & txtRentOthExp & "', [TC_NB_RENT_MAIN]='" & txtRentRepair & "', [TC_NB_RENT_AGREE]='" & txtRentRenewal & "', [TC_NB_RENT_NET]='" & txtRentalIncome & "', " _
'    & "[TC_NB_ROYALTY]='" & txtRoyaltyIncome & "', [TC_NB_SUNDRY]='" & txtSundryIn & "' , [TC_SUNDRY_EXP]='" & txtDirExpenses3 & "', [TC_NB_ADDITION]='" & txtAddition & "', [TC_NB_OTH_AGGR_STAT]='" & txtOthAggregate & "', " _
'    & "[TC_TP_AGGR_IN]='" & txtAggregateIn & "', [TC_TP_CURR_LOSS]='" & txtCurrBsLoss & "', [TC_TP_AGGR_IN_LOSS]='" & txtAggrLoss & "', " _
'    & "[TC_TP_PROSPECTING]='" & txtProspecting & "', [TC_TP_QUALIFY_AGRICULTURE]='" & txtQualifyAgri & "', [TC_TP_PREOP_BS]='" & txtPreopBs & "', [TC_TP_FOOD_PRODUCTION]='" & txtFoodProduct & "', [TC_TP_EXP_ALLOWED]='" & txtExpAllowed & "', " _
'    & "[TC_TP_TOTAL_OTH_EXP]='" & txtTotalOthExp & "', [TC_TP_APRV_DONATION]='" & txtApprDonation & "', [TC_TP_TOTAL_INCOME]='" & txtTotalIncome & "', " _
'    & "[TC_TP_PIONEER_CHARGE]='" & txtPioneerChargeable & "', [TC_TP_CHARGEABLE]='" & txtChargeableIn & "', [TC_TP_OPERATIONALHQ_CHARGE]='" & txtOpHQChargeable & "', [TC_TP_FOREIGN_CHARGE]='" & txtForeignChargeable & "', " _
'    & "[TC_TP_APP_CHARGEABLE1]='" & txtAppChargeableIn1 & "', [TC_TP_APP_CHARGEABLE2]='" & txtAppChargeableIn2 & "', [TC_TP_APP_CHARGEABLE3]='" & txtAppChargeableIn3 & "', [TC_TP_APP_CHARGEABLE4]='" & txtAppChargeableIn4 & "', [TC_TP_APP_CHARGEABLE4A]='" & txtAppChargeableIn4a & "', [TC_TP_APP_CHARGEABLE5]='" & txtAppChargeableIn5 & "', [TC_TP_APP_CHARGEABLE6]='" & txtAppChargeableIn6 & "', [TC_TP_APP_CHARGEABLE7]='" & txtAppChargeableIn7 & "', " _
'    & "[TC_TP_RATE1]=" & txtRate1 & ", [TC_TP_RATE2]=" & txtRate2 & ", [TC_TP_RATE3]=" & txtRate3 & ", [TC_TP_RATE4]=" & txtRate4 & ", [TC_TP_RATE4A]=" & txtRate4a & ", [TC_TP_RATE5]=" & txtRate5 & ", [TC_TP_RATE6]=" & txtRate6 & ", [TC_TP_RATE7]=" & txtRate7 & ", " _
'    & "[TC_TP_RATE1_CHARGEABLE]='" & txtITPChargeableIn1 & "', [TC_TP_RATE2_CHARGEABLE]='" & txtITPChargeableIn2 & "', [TC_TP_RATE3_CHARGEABLE]='" & txtITPChargeableIn3 & "', [TC_TP_RATE4_CHARGEABLE]='" & txtITPChargeableIn4 & "', [TC_TP_RATE4A_CHARGEABLE]='" & txtITPChargeableIn4a & "', [TC_TP_28_CHARGEABLE]='" & txtITPChargeableIn5 & "', [TC_TP_RATE5_CHARGEABLE]='" & txtITPChargeableIn6 & "', [TC_TP_RATE7_CHARGEABLE]='" & txtITPChargeableIn7 & "', " _
'    & "[TC_TP_TOT_TAX_CHARGED]='" & txtTotalTaxCharged & "', [TC_TP_SEC6B_REBATE]='" & txtSec6BRebate & "', [TC_TP_SEC110]='" & txtITPSetoff & "', [TC_TP_SEC110_OTHERS]='" & txtITPSetoffOth & "', [TC_TP_SEC132]='" & txtSec132 & "', [TC_TP_SEC133]='" & txtSec133 & "', [TC_TP_TOT_SETOFF]='" & txtTotalSetoff & "', " _
'    & "[TC_TP_PAYABLE]='" & txtITP & "', [TC_TP_INSTALL]='" & txtInstallments & "', [TC_TP_PAYABLE_BAL]='" & txtTPBal & "', " _
'    & "[TC_CB_LS_BAL_BF]='" & txtULBalbf & "', [TC_CB_LS_UTIL]='" & txtULUtilised & "', [TC_CB_LS_BAL_UTIL]='" & txtULBalUtil & "', [TC_CB_LS_ADJUST_LOSS]='" & txtCurrentYrLoss & "', [TC_CB_LS_UTIL_CURR]='" & txtULUtilisedCurr & "', [TC_CB_LS_UNABSORBED]='" & txtUBL & "', [TC_CB_LS_BAL_CF]='" & txtULBalcf & "', " _
'    & "[TC_CB_ITA_UTIL]='" & txtITAUtilised & "',  " _
'    & "[TC_TP_ZAKAT] ='" & txtZakat & "',[TC_TP_CLAIM] ='" & txtClaim & "',[TC_CB_LS_SAMOUNT] ='" & txtSrdAmt & "',[TC_CB_LS_BALS_CF] ='" & txtBalcf & "',[TC_CB_LS_D_BL] ='" & txtDisABL & "'," _
'    & "[TC_CB_LS_SRDAMT2]='" & txtSrdAmt2 & "', [TC_CB_LS_BLNBF]='" & txtBlnBf & "', [TC_CB_LS_AMTTUT]='" & txtAmtTut & "', [TC_CB_LS_BLNCF]='" & txtBlnCf & "'," _
'    & "[TC_NB_CARRYBCKLOSS]='" & txtCBL.Text & "', [TC_NB_AMTNOTCARRYBCK]='" & txtANCB.Text & "', [TC_NB_CHKCB]='" & checkstatus & "'," _
'    & "[TC_TP_SEC110B]='" & txt110BSetOff & "', [TC_STAT_DIVIDEND] ='" & txtSIFrmDiv & "', [TC_NB_RENT_OTH2] = '" & txtOthers & "'," _
'    & "[TC_TP_INCOME_TP2]='" & txtInTaxPay2 & "', [TC_TP_INCOME_TP3] ='" & txtInTaxPay3 & "', [TC_TP_ESTIMATED_TP] = '" & txtEsTaxPay & "', [TC_TP_ESTIMATED_SME] = '" & chkSMEFirst2Year & "'," _
'    & "[TC_TP_ALL_DIFF]='" & txtAllowDiff & "', [TC_TP_EX_DIFF] ='" & txtExDiff & "', [TC_TP_PEN_DIFF] = '" & txtPenOnExDiff & "'," _
'    & "[TC_NB_RENTIBA] ='" & txtRentalInIBA & "', [TC_NB_RENTIBA_ATT_IN]='" & txtRentAttrInIBA & "', [TC_NB_RENTIBA_ASSESS]='" & txtRentAssessIBA & "', [TC_NB_RENTIBA_QUIT]='" & txtRentQuitIBA & "', [TC_NB_RENTIBA_INSUR]='" & txtRentInsurIBA & "', [TC_NB_RENTIBA_OTH]='" & txtRentOthExpIBA & "', [TC_NB_RENTIBA_MAIN]='" & txtRentRepairIBA & "', [TC_NB_RENTIBA_AGREE]='" & txtRentRenewalIBA & "', [TC_NB_RENTIBA_IBA]='" & txtOthersIBA & "', [TC_NB_DIV_DIS_ATT_INT]='" & txtIntDisallow & "', [TC_NB_DIV_TOT_ATT_INT]='" & txtTotalInterest & "'," _
'    & "[TC_NB_DCA_INT] ='" & txtDCAInterest & "', [TC_NB_DEEMED_INT]='" & txtDeemedInterest & "',[TC_EXEMPTIONCAL]='" & txtExemptionIncreaseChargeable & "',[TC_TP_INSTALL_107C]='" & txtInstallments_107C & "',[TC_TP_INSTALL_107A]='" & txtInstallments_107A & "',[TC_EXEMPTIONLESS] = '" & txtExemptionIncreaseChargeableAfter & "' WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' AND [TC_BUSINESS]=" & cSourceNo
'    DB.Execute (cSQL) '==Oscar has update new fields=='Excessive Difference Penalty Tab 'LeeCC 2012 Disallowed Interest
'    'dannylee end


'    ' End HS : 2009 : C2008.7 : Change Unabsorbed business loss'
    
'    ' === csNgoh C2008.5 === '
'    Insert_GeneralNone (CDbl(vIncomeCalKey))
'    ' === end csNgoh C2008.5 === '
'    ' === NGOHCS CA2008 === '
'    Insert_Withdrawal (CDbl(vIncomeCalKey))
'    ' === NGOHCS CA2008 END === '

'    interest_restricted = 0
'    non_allow_exp = 0
'    dividend_att_interest = 0
'    interest_att_interest = 0
'    rental_att_interest = 0
'    rental_assess = 0
'    rental_quit_rent = 0
'    rental_insurance = 0
'    rental_oth_exp = 0
'    approved_donation = 0
    
'    'azham 28042017 =========================
'        'delete exemption
'        If lvExemptionChargeable.ListItems.count > 0 Then
'        cSQL = "DELETE FROM [TAX_COMPUTATION_EXEMPTION] WHERE REF_NO='" & Trim(txtRefNo.Text) & "' AND [YA]='" & Trim(txtYA.Text) & "'"
'        DB.Execute (cSQL)
        
'        Dim StatusisCancel As Integer
'        If lvExemptionChargeable.ListItems(1).ListSubItems(17).Text = "True" Then
'        StatusisCancel = 1
'        Else
'        StatusisCancel = 0
'        End If
        
'        'CREATE BACK
'        cSQL = "INSERT INTO [TAX_COMPUTATION_EXEMPTION] (YA,REF_NO,STATUTORY_BIZ_INCOME_A,AGGREGATE_INCOME_A,CHARGEABLE_INCOME_A,STATUTORY_BIZ_INCOME_B,AGGREGATE_INCOME_B,CHARGEABLE_INCOME_B,TOTAL_CHARGEABLE_INCOME_A,TOTAL_CHARGEABLE_INCOME_B,TOTAL_A_B,RATE,TOTAL,SUB_RATE,IncreaseBizA_B_SME,TOTAL_A_B_SME,ISCANCEL) VALUES "
'        cSQL = cSQL & "('" & Trim(txtYA.Text) & "','" & Trim(txtRefNo.Text) & "','" & lvExemptionChargeable.ListItems(1).ListSubItems(3).Text & "','" & lvExemptionChargeable.ListItems(1).ListSubItems(4).Text & "','" & lvExemptionChargeable.ListItems(1).ListSubItems(5).Text & "','" & lvExemptionChargeable.ListItems(1).ListSubItems(6).Text & "','" & lvExemptionChargeable.ListItems(1).ListSubItems(7).Text & "','" & lvExemptionChargeable.ListItems(1).ListSubItems(8).Text & "','" & lvExemptionChargeable.ListItems(1).ListSubItems(9).Text & "','" & lvExemptionChargeable.ListItems(1).ListSubItems(10).Text & "','" & lvExemptionChargeable.ListItems(1).ListSubItems(11).Text & "','" & lvExemptionChargeable.ListItems(1).ListSubItems(12).Text & "','" & lvExemptionChargeable.ListItems(1).ListSubItems(13).Text & "','" & lvExemptionChargeable.ListItems(1).ListSubItems(14).Text & "','" & lvExemptionChargeable.ListItems(1).ListSubItems(15).Text & "','" & lvExemptionChargeable.ListItems(1).ListSubItems(16).Text & "" _
'                & "'," & StatusisCancel & ")"
'        DB.Execute (cSQL)
'        End If
        
'        'azham 28042017 =========================
        
'    cSQL = "SELECT * FROM [TAX_COMPUTATION] WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' ORDER BY [TC_BUSINESS]"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        non_allow_exp = CDbl(non_allow_exp) + CDbl(rst!TC_AI_ADJ_BS_EXP_NA_EXP)
'        Do While Not rst.EOF
'            interest_restricted = CDbl(interest_restricted) + CDbl(rst!TC_AI_ADJ_BS_EXP_INT)
'            'non_allow_exp = CDbl(non_allow_exp) + CDbl(rst!TC_AI_ADJ_BS_EXP_NA_EXP)
'            dividend_att_interest = CDbl(dividend_att_interest) + CDbl(rst!TC_NB_DIV_ATT_INT)
'            interest_att_interest = CDbl(interest_att_interest) + CDbl(rst!TC_NB_INT_ATT_INT)
'            rental_att_interest = CDbl(rental_att_interest) + CDbl(rst!TC_NB_RENT_ATT_INT)
'            rental_assess = CDbl(rental_assess) + CDbl(rst!TC_NB_RENT_ASSESS)
'            rental_quit_rent = CDbl(rental_quit_rent) + CDbl(rst!TC_NB_RENT_QUIT)
'            rental_insurance = CDbl(rental_insurance) + CDbl(rst!TC_NB_RENT_INSUR)
'            rental_oth_exp = CDbl(rental_oth_exp) + CDbl(rst!TC_NB_RENT_OTH)
'            approved_donation = CDbl(approved_donation) + CDbl(rst!TC_TP_APRV_DONATION)
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close

'    pnl_key = 0
'    cSQL = "SELECT [PL_KEY] FROM [PROFIT_LOSS_ACCOUNT] WHERE [PL_REF_NO]='" & Trim(txtRefNo) & "' AND [PL_YA]='" & Trim(txtYA) & "'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        pnl_key = rst!PL_KEY
'    End If
'    rst.Close
        
'    NA_Exp = 0
'    cSQL = "SELECT [EXI_AMOUNT] FROM [EXPENSES_INTEREST] WHERE [EXI_KEY]=" & Val(pnl_key) & " AND [EXI_SOURCENO]>1 AND [EXI_DEDUCTIBLE]='Yes'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
    
'    cSQL = "SELECT [EXC_AMOUNT] FROM [EXPENSES_CONTRACT] WHERE [EXC_KEY]=" & Val(pnl_key) & " AND [EXC_SOURCENO]>1 AND [EXC_DEDUCTIBLE]='Yes'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
    
'    cSQL = "SELECT [EXL_AMOUNT] FROM [EXPENSES_LEGAL] WHERE [EXL_KEY]=" & Val(pnl_key) & " AND [EXL_SOURCENO]>1 AND [EXL_DEDUCTIBLE]='Yes'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
    
'    cSQL = "SELECT [EXS_AMOUNT] FROM [EXPENSES_SALARY] WHERE [EXS_KEY]=" & Val(pnl_key) & " AND [EXS_SOURCENO]>1 AND [EXS_DEDUCTIBLE]='Yes'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
    
'    cSQL = "SELECT [EXRO_AMOUNT] FROM [EXPENSES_ROYALTY] WHERE [EXRO_KEY]=" & Val(pnl_key) & " AND [EXRO_SOURCENO]>1 AND [EXRO_DEDUCTIBLE]='Yes'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
    
'    cSQL = "SELECT [EXRENT_AMOUNT] FROM [EXPENSES_RENTAL] WHERE [EXRENT_KEY]=" & Val(pnl_key) & " AND [EXRENT_SOURCENO]>1 AND [EXRENT_DEDUCTIBLE]='Yes'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
    
'    cSQL = "SELECT [EXREP_AMOUNT] FROM [EXPENSES_REPAIR] WHERE [EXREP_KEY]=" & Val(pnl_key) & " AND [EXREP_SOURCENO]>1 AND [EXREP_DEDUCTIBLE]='Yes'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
    
'    cSQL = "SELECT [EXRES_AMOUNT] FROM [EXPENSES_RESEARCH] WHERE [EXRES_KEY]=" & Val(pnl_key) & " AND [EXRES_SOURCENO]>1 AND [EXRES_DEDUCTIBLE]='Yes'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
    
'    cSQL = "SELECT [EXP_AMOUNT] FROM [EXPENSES_PROMOTE] WHERE [EXP_KEY]=" & Val(pnl_key) & " AND [EXP_SOURCENO]>1 AND [EXP_DEDUCTIBLE]='Yes'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close

'    cSQL = "SELECT [EXT_AMOUNT] FROM [EXPENSES_TRAVEL] WHERE [EXT_KEY]=" & Val(pnl_key) & " AND [EXT_SOURCENO]>1 AND [EXT_DEDUCTIBLE]='Yes'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close

'    'geline feel that this andy part got something wrong ler...it suppose to have [EXPENSES_ALLOW] - bcos it hv "yes" mah
'    cSQL = "SELECT [EXNA_AMOUNT] FROM [EXPENSES_NONALLOW] WHERE [EXNA_KEY]=" & Val(pnl_key) & " AND [EXNA_DEDUCTIBLE]='Yes' AND [EXNA_SOURCENO]>1"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close

'    cSQL = "SELECT [EXO_AMOUNT] FROM [OTHER_EXPENSES] WHERE [EXO_KEY]=" & Val(pnl_key) & " AND [EXO_DEDUCTIBLE]='Yes' AND [EXO_SOURCENO]>1"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
    
''***Start:Geline - May2004: Due to new feature
'    cSQL = "SELECT [EXOENS_AMOUNT] FROM [OTHER_ENTERTAINNSTAFF] WHERE [EXOENS_KEY]=" & Val(pnl_key) & " AND [EXOENS_DEDUCTIBLE]='Yes' AND [EXOENS_SOURCENO]>1"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close

'    cSQL = "SELECT [EXOES_AMOUNT] FROM [OTHER_ENTERTAINSTAFF] WHERE [EXOES_KEY]=" & Val(pnl_key) & " AND [EXOES_DEDUCTIBLE]='Yes' AND [EXOES_SOURCENO]>1"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
''***End:Geline - May2004

''LeeCC 20 August 2011 SU3.4 start
'  cSQL = "SELECT [EXORT_AMOUNT] FROM [OTHER_EXRLOSSFOREIGNT] WHERE [EXORT_KEY]=" & Val(pnl_key) & " AND [EXORT_DEDUCTIBLE]='Yes' AND [EXORT_SOURCENO]>1"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
''LeeCC 20 August 2011 SU3.4 end
    
'    NA_Loss = 0
'    cSQL = "SELECT [NL_AMOUNT] FROM [NON_ALLOW_LOSS] WHERE [NL_REF_NO]='" & Trim(txtRefNo) & "' AND [NL_YA]='" & Trim(txtYA) & "'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Loss = CDbl(NA_Loss) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
   
'   '2007.4
'   TotalNA_EXP = 0
'    Call NAllow_Exp
'   '2007.4
'    'Start: Geline: Taxcom v2004.3 - Nov
'   ' non_allowable_expenses = (CDbl(interest_restricted) + ((CDbl(non_allow_exp) + CDbl(NA_Loss)) - CDbl(NA_Exp)))
'    'End: Geline: Taxcom v2004.3 - Nov
'     non_allowable_expenses = TotalNA_EXP

    
'    cSQL = "UPDATE [PROFIT_LOSS_ACCOUNT] SET [PL_DISALLOWED_EXP]='" & FormatNumber(CDbl(non_allowable_expenses), 0) & "' WHERE [PL_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [PL_YA]='" & Trim(txtYA.Text) & "'"
'    DB.Execute (cSQL)
    
    
'    ITA_AMOUNT = 0
'    ITA_CF = 0
'    RA_AMOUNT = 0
'    RA_CF = 0
'    ITA_AMOUNT1 = 0
'    ITA_CF1 = 0
'    RA_AMOUNT1 = 0
'    RA_CF1 = 0
    
'    EA_AMOUNT = 0 'LeeCC 2012.1 export allowance
'    EA_CF = 0 'LeeCC 2012.1 export allowance
'    EA_AMOUNT1 = 0 'LeeCC 2012.1 export allowance
'    EA_CF1 = 0 'LeeCC 2012.1 export allowance
    
'    EA_AMOUNT_SP = 0 'LeeCC 2012.1 export allowance
'    EA_CF_SP = 0 'LeeCC 2012.1 export allowance
'    EA_AMOUNT_SP1 = 0 'LeeCC 2012.1 export allowance
'    EA_CF_SP1 = 0 'LeeCC 2012.1 export allowance
    
'    EA_AMOUNT_AGRI = 0
'    EA_CF_AGRI = 0
'    EA_AMOUNT_AGRI1 = 0
'    EA_CF_AGRI1 = 0
    
'    cSQL = "SELECT [TC_SI_RA],[TC_CB_RA_BAL_CF],[TC_SI_INVEST_ALLOW],[TC_CB_ITA_BAL_CF],[TC_EA_UTL],[TC_EA_CF],[TC_EA_TYPE] FROM [TAX_COMPUTATION] " & _
'           "WHERE [TC_REF_NO]='" & Trim(txtRefNo) & "' AND [TC_YA]='" & Trim(txtYA) & "'" 'LeeCC 2012.1 export allowance
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            ITA_AMOUNT1 = rst!TC_SI_INVEST_ALLOW
'            ITA_CF1 = rst!TC_CB_ITA_BAL_CF
'            RA_AMOUNT1 = rst!TC_SI_RA
'            RA_CF1 = rst!TC_CB_RA_BAL_CF
            
'            If CDbl(rst!TC_SI_INVEST_ALLOW) < 0 Then
'             ITA_AMOUNT1 = 0
'            End If
'            If CDbl(rst!TC_CB_ITA_BAL_CF) < 0 Then
'            ITA_CF1 = 0
'            End If
'            If CDbl(rst!TC_SI_RA) < 0 Then
'             RA_AMOUNT1 = 0
'            End If
'            If CDbl(rst!TC_CB_RA_BAL_CF) < 0 Then
'             RA_CF1 = 0
'            End If
            
'            ITA_AMOUNT = CDbl(ITA_AMOUNT) + CDbl(ITA_AMOUNT1)  'CDbl(rst!TC_CB_ITA_BAL_BF_CURR)
'            ITA_CF = CDbl(ITA_CF) + CDbl(ITA_CF1)
'            RA_AMOUNT = CDbl(RA_AMOUNT) + CDbl(RA_AMOUNT1)  'CDbl(rst!TC_CB_RA_BAL_BF_CURR)
'            RA_CF = CDbl(RA_CF) + CDbl(RA_CF1)
            
'            EA_AMOUNT_AGRI1 = 0
'            EA_CF_AGRI1 = 0
'            EA_AMOUNT1 = 0
'            EA_CF1 = 0
'            EA_AMOUNT_SP1 = 0
'            EA_CF_SP1 = 0

'            Select Case rst!TC_EA_TYPE
'                Case 1
'                    If CDbl(rst!TC_EA_UTL) < 0 Then
'                        EA_AMOUNT1 = 0
'                    Else
'                        EA_AMOUNT1 = CDbl(rst!TC_EA_UTL)
'                    End If
                    
'                    If CDbl(rst!TC_EA_CF) < 0 Then
'                        EA_CF1 = 0
'                    Else
'                        EA_CF1 = CDbl(rst!TC_EA_CF)
'                    End If
'                Case 2
'                    If CDbl(rst!TC_EA_UTL) < 0 Then
'                        EA_AMOUNT_AGRI1 = 0
'                    Else
'                        EA_AMOUNT_AGRI1 = CDbl(rst!TC_EA_UTL)
'                    End If
                    
'                    If CDbl(rst!TC_EA_CF) < 0 Then
'                        EA_CF_AGRI1 = 0
'                    Else
'                        EA_CF_AGRI1 = CDbl(rst!TC_EA_CF)
'                    End If
'                Case 3, 4, 5
'                    If CDbl(rst!TC_EA_UTL) < 0 Then
'                        EA_AMOUNT_SP1 = 0
'                    Else
'                        EA_AMOUNT_SP1 = CDbl(rst!TC_EA_UTL)
'                    End If
                    
'                    If CDbl(rst!TC_EA_CF) < 0 Then
'                        EA_CF_SP1 = 0
'                    Else
'                        EA_CF_SP1 = CDbl(rst!TC_EA_CF)
'                    End If
'            End Select
            
'            EA_AMOUNT = CDbl(EA_AMOUNT) + CDbl(EA_AMOUNT1)
'            EA_CF = CDbl(EA_CF) + CDbl(EA_CF1)
'            EA_AMOUNT_SP = CDbl(EA_AMOUNT_SP) + CDbl(EA_AMOUNT_SP1)
'            EA_CF_SP = CDbl(EA_CF_SP) + CDbl(EA_CF_SP1)
'            EA_AMOUNT_AGRI = CDbl(EA_AMOUNT_AGRI) + CDbl(EA_AMOUNT_AGRI1)
'            EA_CF_AGRI = CDbl(EA_CF_AGRI) + CDbl(EA_CF_AGRI1)
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close

'    ' === CYS 2010 ===
'    'Dim strKey As String
'    Dim no As Integer
'    Dim totalSCH7A As Double
'    Dim totalBalCF As Double
    
'    'cSQL3 = "SELECT * FROM [TAX_COMPUTATION_PARTNER] WHERE [TCP_REF_NO] ='" & Trim(txtRefNo) & "' AND [TCP_YA]='" & Trim(txtYA) & "'"
'    'Set rst3 = DB.Execute(cSQL3)
'    'If Not rst3.EOF Then
'        'strKey = rst3!TCP_KEY
    
'        'cSQL = "SELECT sum(PN_SCH_7A_STAT_INCOME) AS totalSCH7A , sum(PN_RAP_CF) AS totalRAP FROM [INCOME_PARTNERSHIP] WHERE [TCP_KEY] = " & strKey
'        'Set rst = DB.Execute(cSQL)
'        'If IsNull(rst!totalSCH7A) Then
'            'totalSCH7A = "0"
'            'totalBalCF = "0"
'        'Else
'            'totalSCH7A = rst!totalSCH7A
'            'totalBalCF = rst!totalRAP
'        'End If
'    If lstRAPartnership.ListItems.count <> 0 Then
'        For no = 1 To Me.lstRAPartnership.ListItems.count
'            totalSCH7A = totalSCH7A + CDbl(Me.lstRAPartnership.ListItems(no).ListSubItems(5).Text)
'            totalBalCF = totalBalCF + CDbl(Me.lstRAPartnership.ListItems(no).ListSubItems(6).Text)
'        Next
        
'        RA_AMOUNT = FormatNumber(CDbl(RA_AMOUNT) + CDbl(totalSCH7A), 0)
'        RA_CF = FormatNumber(CDbl(RA_CF) + CDbl(totalBalCF), 0)
    
'        If Not CDbl(txtRAUtilised) = 0 Or Not CDbl(txtRABalcf) = 0 Or Not CDbl(totalSCH7A) = 0 Or Not CDbl(totalBalCF) = 0 Or Not CDbl(txtITAUtilised) = 0 Or Not CDbl(txtITABalcf) = 0 Or Not CDbl(txtProspecting) = 0 Or Not CDbl(txtQualifyAgri) = 0 Or Not CDbl(txtPreopBs) = 0 Then  'CYS 2010
'            cSQL = "SELECT * FROM [INCENTIVE_CLAIM] WHERE [IC_REF_NO]='" & Trim(txtRefNo) & "' AND [IC_YA]='" & Trim(txtYA) & "'"
'            Set rst = DB.Execute(cSQL)
'            If rst.EOF Then
'                cSQL2 = "SELECT * FROM [INCENTIVE_CLAIM] ORDER BY [IC_KEY]"
'                Set rst2 = DB.Execute(cSQL2)
'                nNo = 0
'                If Not rst2.EOF Then
'                    While Not rst2.EOF
'                        nNo = Val(rst2.Fields(0))
'                        rst2.MoveNext
'                    Wend
'                End If
'                nNo = nNo + 1
'                rst2.Close
                
'                cSQL2 = "SELECT * FROM [INCENTIVE_CLAIM]"
'                With rst2
'                .Open cSQL, DB, 3, 3
'                .AddNew
'                !IC_KEY = nNo
'                !IC_REF_NO = txtRefNo
'                !IC_YA = txtYA
'                !IC_INVEST_AMT = ITA_AMOUNT 'txtITAUtilised
'                !IC_INVEST_BF = ITA_CF 'txtITABalcf
'                !IC_INDUST_AMT = 0
'                !IC_INDUST_BF = 0
'                !IC_INDUST_AMT = 0
'                !IC_INDUST_BF = 0
'                !IC_INFRA_AMT = 0
'                !IC_INFRA_BF = 0
'                !IC_SECT7A_AMT = RA_AMOUNT 'txtRAUtilised
'                !IC_SECT7A_BF = RA_CF 'txtRABalcf
'                !IC_SECT7B_AMT = 0
'                !IC_SECT7B_BF = 0
'                !IC_EXPORT_AMT = EA_AMOUNT 'LeeCC 2012.1 Export Allowance
'                !IC_EXPORT_BF = EA_CF 'LeeCC 2012.1 Export Allowance
'                !IC_AGRI_AMT = EA_AMOUNT_AGRI 'LeeCC 2012.1 Export Allowance
'                !IC_AGRI_BF = EA_CF_AGRI 'LeeCC 2012.1 Export Allowance
'                !IC_SCH4 = 0
'                !IC_SCH4A = 0
'                !IC_SCH4B = 0
'                '!IC_TOTAL = FormatNumber(CDbl(txtITAUtilised) + CDbl(txtRAUtilised) + CDbl(txtProspecting) + CDbl(txtQualifyAgri) + CDbl(txtPreopBs), 0)
'                '!IC_TRANSFER = FormatNumber(CDbl(txtITAUtilised) + CDbl(txtRAUtilised), 0)
'                !IC_TOTAL = FormatNumber(CDbl(ITA_AMOUNT) + CDbl(RA_AMOUNT) + CDbl(txtProspecting) + CDbl(txtQualifyAgri) + CDbl(txtPreopBs), 0)
'                !IC_TRANSFER = FormatNumber(CDbl(ITA_AMOUNT) + CDbl(RA_AMOUNT), 0)
'                !IC_INTCO_AMT = 0
'                !IC_INTCO_BF = 0
'                !IC_SERVICE_AMT = 0
'                !IC_SERVICE_BF = 0
'                !IC_SPECIAL_AMT = EA_AMOUNT_SP 'LeeCC 2012.1 Export Allowance
'                !IC_SPECIAL_BF = EA_CF_SP 'LeeCC 2012.1 Export Allowance
'                !IC_BIO_CF = 0
'                !IC_BIO_AMT = 0
'                .Update
'                .Close
'                End With
                
'    '            cSQL2 = "INSERT INTO [INCENTIVE_CLAIM] VALUES ( " & _
'    '            " " & nNo & ", '" & txtRefNo & "', '" & txtYA & "', '" & txtITAUtilised & "', '" & txtITABalcf & "', " & _
'    '            " '0', '0', '0', '0'," & _
'    '            " '" & txtRAUtilised & "', '" & txtRABalcf & "', '0', '0'," & _
'    '            " '0', '0', '0', '0'," & _
'    '            " '0', '0', '0'," & _
'    '            " '" & FormatNumber(CDbl(txtITAUtilised) + CDbl(txtRAUtilised) + CDbl(txtProspecting) + CDbl(txtQualifyAgri) + CDbl(txtPreopBs), 0) & "'," & _
'    '            " '" & FormatNumber(CDbl(txtITAUtilised) + CDbl(txtRAUtilised), 0) & "'," & _
'    '            " '0', '0', '0', '0', '0', '0')"
'    '            DB.Execute (cSQL2)
            
            
'            Else
'    ''            cSQL2 = "UPDATE [INCENTIVE_CLAIM] SET " _
'    ''            & "[IC_INVEST_AMT]='" & txtITAUtilised & "'," _
'    ''            & "[IC_INVEST_BF]='" & txtITABalcf & "'," _
'    ''            & "[IC_SECT7A_AMT]='" & txtRAUtilised & "'," _
'    ''            & "[IC_SECT7A_BF]='" & txtRABalcf & "'," _
'    ''            & "[IC_TOTAL]='" & FormatNumber(CDbl(txtITAUtilised) + CDbl(txtRAUtilised) + CDbl(rst!IC_INDUST_AMT) + CDbl(rst!IC_INFRA_AMT) + CDbl(rst!IC_SECT7B_AMT) + CDbl(rst!IC_EXPORT_AMT) + CDbl(rst!IC_AGRI_AMT) + CDbl(txtProspecting) + CDbl(txtQualifyAgri) + CDbl(txtPreopBs), 0) & "'," _
'    ''            & "[IC_TRANSFER]='" & FormatNumber(CDbl(txtITAUtilised) + CDbl(txtRAUtilised) + CDbl(rst!IC_INDUST_AMT) + CDbl(rst!IC_INFRA_AMT) + CDbl(rst!IC_SECT7B_AMT) + CDbl(rst!IC_EXPORT_AMT) + CDbl(rst!IC_AGRI_AMT), 0) & "'" _
'    ''            & " WHERE [IC_KEY]=" & Val(rst!IC_KEY)
'    ''            DB.Execute (cSQL2)
'                cSQL2 = "UPDATE [INCENTIVE_CLAIM] SET " _
'                & "[IC_INVEST_AMT]='" & ITA_AMOUNT & "'," _
'                & "[IC_INVEST_BF]='" & ITA_CF & "'," _
'                & "[IC_SECT7A_AMT]='" & RA_AMOUNT & "'," _
'                & "[IC_SECT7A_BF]='" & RA_CF & "'," _
'                & "[IC_EXPORT_AMT]='" & EA_AMOUNT & "'," _
'                & "[IC_EXPORT_BF]='" & EA_CF & "'," _
'                & "[IC_SPECIAL_AMT]='" & EA_AMOUNT_SP & "'," _
'                & "[IC_SPECIAL_BF]='" & EA_CF_SP & "'," _
'                & "[IC_AGRI_AMT]='" & EA_AMOUNT_AGRI & "'," _
'                & "[IC_AGRI_BF]='" & EA_CF_AGRI & "'," _
'                & "[IC_TOTAL]='" & FormatNumber(CDbl(ITA_AMOUNT) + CDbl(RA_AMOUNT) + CDbl(rst!IC_INDUST_AMT) + CDbl(rst!IC_INFRA_AMT) + CDbl(rst!IC_SECT7B_AMT) + CDbl(EA_AMOUNT) + CDbl(EA_AMOUNT) + CDbl(txtProspecting) + CDbl(txtQualifyAgri) + CDbl(txtPreopBs), 0) & "'," _
'                & "[IC_TRANSFER]='" & FormatNumber(CDbl(ITA_AMOUNT) + CDbl(RA_AMOUNT) + CDbl(rst!IC_INDUST_AMT) + CDbl(rst!IC_INFRA_AMT) + CDbl(rst!IC_SECT7B_AMT) + CDbl(EA_AMOUNT) + CDbl(EA_AMOUNT), 0) & "'" _
'                & " WHERE [IC_KEY]=" & Val(rst!IC_KEY)
'                DB.Execute (cSQL2)
    
'    ''            cSQL2 = "SELECT * FROM [INCENTIVE_CLAIM]WHERE [IC_KEY]=" & Val(rst!IC_KEY)
'    ''            With rst2
'    ''            .Open cSQL, DB, 3, 3
'    ''            !IC_INVEST_AMT = ITA_AMOUNT 'txtITAUtilised
'    ''            !IC_INVEST_BF = ITA_CF
'    ''            !IC_SECT7A_AMT = RA_AMOUNT 'txtRAUtilised
'    ''            !IC_SECT7A_BF = RA_CF 'txtRABalcf
'    ''            !IC_TOTAL = FormatNumber(CDbl(ITA_AMOUNT) + CDbl(RA_AMOUNT) + CDbl(rst!IC_INDUST_AMT) + CDbl(rst!IC_INFRA_AMT) + CDbl(rst!IC_SECT7B_AMT) + CDbl(rst!IC_EXPORT_AMT) + CDbl(rst!IC_AGRI_AMT) + CDbl(txtProspecting) + CDbl(txtQualifyAgri) + CDbl(txtPreopBs), 0)
'    ''            !IC_TRANSFER = FormatNumber(CDbl(ITA_AMOUNT) + CDbl(RA_AMOUNT) + CDbl(rst!IC_INDUST_AMT) + CDbl(rst!IC_INFRA_AMT) + CDbl(rst!IC_SECT7B_AMT) + CDbl(rst!IC_EXPORT_AMT) + CDbl(rst!IC_AGRI_AMT), 0)
'    ''            .Update
'    ''            .Close
'    ''            End With
    
'            End If
'            rst.Close
'        Else
'    ''        cSQL = "SELECT * FROM [INCENTIVE_CLAIM] WHERE [IC_REF_NO]='" & Trim(txtRefNo) & "' AND [IC_YA]='" & Trim(txtYA) & "'"
'    ''        Set rst = DB.Execute(cSQL)
'    ''        If Not rst.EOF Then
'    ''            cSQL2 = "UPDATE [INCENTIVE_CLAIM] SET " _
'    ''            & "[IC_INVEST_AMT]='" & txtITAUtilised & "',[IC_INVEST_BF]='" & txtITABalcf & "'," _
'    ''            & "[IC_SECT7A_AMT]='" & txtRAUtilised & "',[IC_SECT7A_BF]='" & txtRABalcf & "'," _
'    ''            & "[IC_TOTAL]='" & FormatNumber(CDbl(txtITAUtilised) + CDbl(txtRAUtilised) + CDbl(rst!IC_INDUST_AMT) + CDbl(rst!IC_INFRA_AMT) + CDbl(rst!IC_SECT7B_AMT) + CDbl(rst!IC_EXPORT_AMT) + CDbl(rst!IC_AGRI_AMT) + CDbl(txtProspecting) + CDbl(txtQualifyAgri) + CDbl(txtPreopBs), 0) & "'," _
'    ''            & "[IC_TRANSFER]='" & FormatNumber(CDbl(txtITAUtilised) + CDbl(txtRAUtilised) + CDbl(rst!IC_INDUST_AMT) + CDbl(rst!IC_INFRA_AMT) + CDbl(rst!IC_SECT7B_AMT) + CDbl(rst!IC_EXPORT_AMT) + CDbl(rst!IC_AGRI_AMT), 0) & "'" _
'    ''            & " WHERE [IC_KEY]=" & Val(rst!IC_KEY)
'    ''            DB.Execute (cSQL2)
'    ''        End If
'    ''        rst.Close
    
'            cSQL = "SELECT * FROM [INCENTIVE_CLAIM] WHERE [IC_REF_NO]='" & Trim(txtRefNo) & "' AND [IC_YA]='" & Trim(txtYA) & "'"
'            Set rst = DB.Execute(cSQL)
'            If Not rst.EOF Then
'                 cSQL2 = "UPDATE [INCENTIVE_CLAIM] SET " _
'                & "[IC_INVEST_AMT]='" & ITA_AMOUNT & "'," _
'                & "[IC_INVEST_BF]='" & ITA_CF & "'," _
'                & "[IC_SECT7A_AMT]='" & RA_AMOUNT & "'," _
'                & "[IC_SECT7A_BF]='" & RA_CF & "'," _
'                & "[IC_EXPORT_AMT]='" & EA_AMOUNT & "'," _
'                & "[IC_EXPORT_BF]='" & EA_CF & "'," _
'                & "[IC_SPECIAL_AMT]='" & EA_AMOUNT_SP & "'," _
'                & "[IC_SPECIAL_BF]='" & EA_CF_SP & "'," _
'                & "[IC_AGRI_AMT]='" & EA_AMOUNT_AGRI & "'," _
'                & "[IC_AGRI_BF]='" & EA_CF_AGRI & "'," _
'                & "[IC_TOTAL]='" & FormatNumber(CDbl(ITA_AMOUNT) + CDbl(RA_AMOUNT) + CDbl(rst!IC_INDUST_AMT) + CDbl(rst!IC_INFRA_AMT) + CDbl(rst!IC_SECT7B_AMT) + CDbl(txtProspecting) + CDbl(txtQualifyAgri) + CDbl(txtPreopBs), 0) & "'," _
'                & "[IC_TRANSFER]='" & FormatNumber(CDbl(ITA_AMOUNT) + CDbl(RA_AMOUNT) + CDbl(rst!IC_INDUST_AMT) + CDbl(rst!IC_INFRA_AMT) + CDbl(rst!IC_SECT7B_AMT) + CDbl(rst!IC_EXPORT_AMT) + CDbl(rst!IC_AGRI_AMT), 0) & "'" _
'                & " WHERE [IC_KEY]=" & Val(rst!IC_KEY)
'                '& "[IC_TOTAL]='" & FormatNumber(CDbl(ITA_AMOUNT) + CDbl(RA_AMOUNT) + CDbl(rst!IC_INDUST_AMT) + CDbl(rst!IC_INFRA_AMT) + CDbl(rst!IC_SECT7B_AMT) + CDbl(rst!EA_AMOUNT) + CDbl(rst!EA_AMOUNT) + CDbl(txtProspecting) + CDbl(txtQualifyAgri) + CDbl(txtPreopBs), 0) & "'," _
'                & "[IC_TRANSFER]='" & FormatNumber(CDbl(ITA_AMOUNT) + CDbl(RA_AMOUNT) + CDbl(rst!IC_INDUST_AMT) + CDbl(rst!IC_INFRA_AMT) + CDbl(rst!IC_SECT7B_AMT) + CDbl(rst!IC_EXPORT_AMT) + CDbl(rst!IC_AGRI_AMT), 0) & "'" _
'                & " WHERE [IC_KEY]=" & Val(rst!IC_KEY)
'                DB.Execute (cSQL2)
'            End If
'            rst.Close
    
'    ''        cSQL = "SELECT * FROM [INCENTIVE_CLAIM] WHERE [IC_REF_NO]='" & Trim(txtRefNo) & "' AND [IC_YA]='" & Trim(txtYA) & "'"
'    ''        Set rst = DB.Execute(cSQL)
'    ''        If Not rst.EOF Then
'    ''            cSQL2 = "SELECT * FROM [INCENTIVE_CLAIM] WHERE  [IC_KEY]=" & Val(rst!IC_KEY)
'    ''            With rst2
'    ''            .Open cSQL2, DB, 3, 3
'    ''            !IC_INVEST_AMT = ITA_AMOUNT 'txtITAUtilised
'    ''            !IC_INVEST_BF = ITA_CF
'    ''            !IC_SECT7A_AMT = RA_AMOUNT 'txtRAUtilised
'    ''            !IC_SECT7A_BF = RA_CF 'txtRABalcf
'    ''            !IC_TOTAL = FormatNumber(CDbl(ITA_AMOUNT) + CDbl(RA_AMOUNT) + CDbl(rst!IC_INDUST_AMT) + CDbl(rst!IC_INFRA_AMT) + CDbl(rst!IC_SECT7B_AMT) + CDbl(rst!IC_EXPORT_AMT) + CDbl(rst!IC_AGRI_AMT) + CDbl(txtProspecting) + CDbl(txtQualifyAgri) + CDbl(txtPreopBs), 0)
'    ''            !IC_TRANSFER = FormatNumber(CDbl(ITA_AMOUNT) + CDbl(RA_AMOUNT) + CDbl(rst!IC_INDUST_AMT) + CDbl(rst!IC_INFRA_AMT) + CDbl(rst!IC_SECT7B_AMT) + CDbl(rst!IC_EXPORT_AMT) + CDbl(rst!IC_AGRI_AMT), 0)
'    ''            .Update
'    ''            .Close
'    ''            End With
'    ''        End If
'    ''        rst.Close
'        End If
'    Else
'        If Not CDbl(txtRAUtilised) = 0 Or Not CDbl(txtRABalcf) = 0 Or Not CDbl(txtITAUtilised) = 0 Or Not CDbl(txtITABalcf) = 0 Or Not CDbl(txtProspecting) = 0 Or Not CDbl(txtQualifyAgri) = 0 Or Not CDbl(txtPreopBs) = 0 Then  'CYS 2010
'            cSQL = "SELECT * FROM [INCENTIVE_CLAIM] WHERE [IC_REF_NO]='" & Trim(txtRefNo) & "' AND [IC_YA]='" & Trim(txtYA) & "'"
'            Set rst = DB.Execute(cSQL)
'            If rst.EOF Then
'                cSQL2 = "SELECT * FROM [INCENTIVE_CLAIM] ORDER BY [IC_KEY]"
'                Set rst2 = DB.Execute(cSQL2)
'                nNo = 0
'                If Not rst2.EOF Then
'                    While Not rst2.EOF
'                        nNo = Val(rst2.Fields(0))
'                        rst2.MoveNext
'                    Wend
'                End If
'                nNo = nNo + 1
'                rst2.Close
                
'                cSQL2 = "SELECT * FROM [INCENTIVE_CLAIM]"
'                With rst2
'                .Open cSQL, DB, 3, 3
'                .AddNew
'                !IC_KEY = nNo
'                !IC_REF_NO = txtRefNo
'                !IC_YA = txtYA
'                !IC_INVEST_AMT = ITA_AMOUNT 'txtITAUtilised
'                !IC_INVEST_BF = ITA_CF 'txtITABalcf
'                !IC_INDUST_AMT = 0
'                !IC_INDUST_BF = 0
'                !IC_INDUST_AMT = 0
'                !IC_INDUST_BF = 0
'                !IC_INFRA_AMT = 0
'                !IC_INFRA_BF = 0
'                !IC_SECT7A_AMT = RA_AMOUNT 'txtRAUtilised
'                !IC_SECT7A_BF = RA_CF 'txtRABalcf
'                !IC_SECT7B_AMT = 0
'                !IC_SECT7B_BF = 0
'                !IC_EXPORT_AMT = EA_AMOUNT
'                !IC_EXPORT_BF = EA_CF
'                !IC_AGRI_AMT = EA_AMOUNT_AGRI
'                !IC_AGRI_BF = EA_CF_AGRI
'                !IC_SCH4 = 0
'                !IC_SCH4A = 0
'                !IC_SCH4B = 0
'                '!IC_TOTAL = FormatNumber(CDbl(txtITAUtilised) + CDbl(txtRAUtilised) + CDbl(txtProspecting) + CDbl(txtQualifyAgri) + CDbl(txtPreopBs), 0)
'                '!IC_TRANSFER = FormatNumber(CDbl(txtITAUtilised) + CDbl(txtRAUtilised), 0)
'                !IC_TOTAL = FormatNumber(CDbl(ITA_AMOUNT) + CDbl(RA_AMOUNT) + CDbl(EA_AMOUNT) + CDbl(EA_AMOUNT) + CDbl(txtProspecting) + CDbl(txtQualifyAgri) + CDbl(txtPreopBs), 0)
'                !IC_TRANSFER = FormatNumber(CDbl(ITA_AMOUNT) + CDbl(RA_AMOUNT) + CDbl(EA_AMOUNT) + CDbl(EA_AMOUNT), 0)
'                !IC_INTCO_AMT = 0
'                !IC_INTCO_BF = 0
'                !IC_SERVICE_AMT = 0
'                !IC_SERVICE_BF = 0
'                !IC_SPECIAL_AMT = EA_AMOUNT_SP
'                !IC_SPECIAL_BF = EA_CF_SP
'                !IC_BIO_CF = 0
'                !IC_BIO_AMT = 0
'                .Update
'                .Close
'                End With
            
'            Else
'                cSQL2 = "UPDATE [INCENTIVE_CLAIM] SET " _
'                & "[IC_INVEST_AMT]='" & ITA_AMOUNT & "'," _
'                & "[IC_INVEST_BF]='" & ITA_CF & "'," _
'                & "[IC_SECT7A_AMT]='" & RA_AMOUNT & "'," _
'                & "[IC_SECT7A_BF]='" & RA_CF & "'," _
'                & "[IC_EXPORT_AMT]='" & EA_AMOUNT & "'," _
'                & "[IC_EXPORT_BF]='" & EA_CF & "'," _
'                & "[IC_SPECIAL_AMT]='" & EA_AMOUNT_SP & "'," _
'                & "[IC_SPECIAL_BF]='" & EA_CF_SP & "'," _
'                & "[IC_AGRI_AMT]='" & EA_AMOUNT_AGRI & "'," _
'                & "[IC_AGRI_BF]='" & EA_CF_AGRI & "'," _
'                & "[IC_TOTAL]='" & FormatNumber(CDbl(ITA_AMOUNT) + CDbl(RA_AMOUNT) + CDbl(rst!IC_INDUST_AMT) + CDbl(rst!IC_INFRA_AMT) + CDbl(rst!IC_SECT7B_AMT) + CDbl(EA_AMOUNT) + CDbl(EA_AMOUNT) + CDbl(txtProspecting) + CDbl(txtQualifyAgri) + CDbl(txtPreopBs), 0) & "'," _
'                & "[IC_TRANSFER]='" & FormatNumber(CDbl(ITA_AMOUNT) + CDbl(RA_AMOUNT) + CDbl(rst!IC_INDUST_AMT) + CDbl(rst!IC_INFRA_AMT) + CDbl(rst!IC_SECT7B_AMT) + CDbl(EA_AMOUNT) + CDbl(EA_AMOUNT), 0) & "'" _
'                & " WHERE [IC_KEY]=" & Val(rst!IC_KEY)
'                DB.Execute (cSQL2)
    
'            End If
'            rst.Close
'        Else
'            cSQL = "SELECT * FROM [INCENTIVE_CLAIM] WHERE [IC_REF_NO]='" & Trim(txtRefNo) & "' AND [IC_YA]='" & Trim(txtYA) & "'"
'            Set rst = DB.Execute(cSQL)
'            If Not rst.EOF Then
'                cSQL2 = "UPDATE [INCENTIVE_CLAIM] SET " _
'                & "[IC_INVEST_AMT]='" & ITA_AMOUNT & "'," _
'                & "[IC_INVEST_BF]='" & ITA_CF & "'," _
'                & "[IC_SECT7A_AMT]='" & RA_AMOUNT & "'," _
'                & "[IC_SECT7A_BF]='" & RA_CF & "'," _
'                & "[IC_EXPORT_AMT]='" & EA_AMOUNT & "'," _
'                & "[IC_EXPORT_BF]='" & EA_CF & "'," _
'                & "[IC_SPECIAL_AMT]='" & EA_AMOUNT_SP & "'," _
'                & "[IC_SPECIAL_BF]='" & EA_CF_SP & "'," _
'                & "[IC_AGRI_AMT]='" & EA_AMOUNT_AGRI & "'," _
'                & "[IC_AGRI_BF]='" & EA_CF_AGRI & "'," _
'                & "[IC_TOTAL]='" & FormatNumber(CDbl(ITA_AMOUNT) + CDbl(RA_AMOUNT) + CDbl(rst!IC_INDUST_AMT) + CDbl(rst!IC_INFRA_AMT) + CDbl(rst!IC_SECT7B_AMT) + CDbl(EA_AMOUNT) + CDbl(EA_AMOUNT) + CDbl(txtProspecting) + CDbl(txtQualifyAgri) + CDbl(txtPreopBs), 0) & "'," _
'                & "[IC_TRANSFER]='" & FormatNumber(CDbl(ITA_AMOUNT) + CDbl(RA_AMOUNT) + CDbl(rst!IC_INDUST_AMT) + CDbl(rst!IC_INFRA_AMT) + CDbl(rst!IC_SECT7B_AMT) + CDbl(EA_AMOUNT) + CDbl(EA_AMOUNT), 0) & "'" _
'                & " WHERE [IC_KEY]=" & Val(rst!IC_KEY)
'                DB.Execute (cSQL2)
'            End If
'            rst.Close
'        End If
'    End If
'    'rst3.Close
    
'    '======================== Loo Jia An TAXcom Partnership C+ ===============================
'    Dim rst6 As New ADODB.Recordset
    
'    cSQL = "SELECT * FROM [TAX_COMPUTATION_PARTNER] WHERE [TCP_REF_NO] = '" & Trim(txtRefNo) & "' AND [TCP_YA] = '" & Trim(txtYA) & "'"
'    Set rst = DB.Execute(cSQL)
    
'    If Not rst.EOF Then
'        strKey = rst!TCP_KEY
'    End If
'    rst.Close
    
'    If lstViewCAPI.ListItems.count > 0 Then
'        For i = 1 To lstViewCAPI.ListItems.count
        
'            'cSQL2 = "UPDATE [INCOME_PARTNERSHIP] SET " _
'            & "[PN_CA] = '" & lstViewCAPI.ListItems(i).ListSubItems(6) & "'," _
'            & "[PN_BA] = '" & lstViewCAPI.ListItems(i).ListSubItems(7) & "'," _
'            & "[PN_CA_BA] = '" & lstViewCAPI.ListItems(i).ListSubItems(9) & "'," _
'            & "[PN_CF] = '" & lstViewCAPI.ListItems(i).ListSubItems(10) & "'" _
'            & " WHERE [TCP_KEY] = " & strKey & " AND [PN_SOURCENO] = " & lstViewCAPI.ListItems(i)
'            'DB.Execute (cSQL2)
            
'            cSQL4 = "SELECT * FROM [INCOME_PARTNERSHIP] WHERE [TCP_KEY] = " & strKey & " AND [PN_SOURCENO] = " & lstViewCAPI.ListItems(i)
'            rst6.Open cSQL4, DB, 3, 3
            
'            rst6!PN_CA = lstViewCAPI.ListItems(i).ListSubItems(6).Text
'            rst6![PN_BA] = lstViewCAPI.ListItems(i).ListSubItems(7).Text
'            rst6![PN_CA_BA] = lstViewCAPI.ListItems(i).ListSubItems(9).Text
'            rst6![PN_CF] = lstViewCAPI.ListItems(i).ListSubItems(10).Text
'            rst6![PN_RAP_CF] = lstRAPartnership.ListItems(i).ListSubItems(6).Text
              
'            If Trim(rst6!PN_SOURCENO) = Trim(lstViewCAPI.ListItems(i)) Then
'                rst6!PN_CA_BA = lstViewCAPI.ListItems(i).ListSubItems(9)
'                rst6!PN_STAT_INCOME = FormatNumber(CDbl(rst6!PN_TOTAL) - CDbl(rst6!PN_CA_BA), 0)
'                If CDbl(rst6!PN_STAT_INCOME) < 0 Then rst6!PN_STAT_INCOME = "0"
'                rst6!PN_TOTAL_STAT_INCOME = FormatNumber(CDbl(rst6!PN_STAT_INCOME) - CDbl(rst6!PN_SCH_7A_STAT_INCOME), 0)
'                If CDbl(rst6!PN_TOTAL_STAT_INCOME) < 0 Then rst6!PN_TOTAL_STAT_INCOME = "0"
'            End If
        
'            rst6.Update
'            rst6.Close
'        Next
'    End If
        
'    cSQL4 = "SELECT * FROM [TAX_COMPUTATION_PARTNER] WHERE [TCP_REF_NO] = '" & Trim(txtRefNo) & "' AND [TCP_YA] = '" & Trim(txtYA) & "'"
'    Set rst4 = DB.Execute(cSQL4)
    
'    If Not rst4.EOF Then
    
'        cSQL2 = "SELECT * FROM [INCOME_PARTNERSHIP] WHERE [TCP_KEY] = " & strKey
'        Set rst2 = DB.Execute(cSQL2)
        
'        If Not rst2.EOF Then
'            cSQL3 = "SELECT sum(cast(PN_TOTAL_STAT_INCOME as money)) FROM [INCOME_PARTNERSHIP] WHERE [TCP_KEY] = " & strKey
'            Set rst3 = DB.Execute(cSQL3)
            
'            If Not rst3.EOF Then
'                total = rst3.Fields(0)
'            End If
'            rst3.Close
            
'            cSQL3 = "SELECT * FROM [TAX_COMPUTATION_PARTNER] WHERE [TCP_REF_NO] = '" & Trim(txtRefNo) & "' AND [TCP_YA] = '" & Trim(txtYA) & "'"
'            rst3.Open cSQL3, DB, 3, 3
'            If Not rst3.EOF Then
'                rst3!TCP_PARTNERSHIP = FormatNumber(CDbl(total), 0)
'                rst3.Update
'            End If
'            rst3.Close
'        End If
'        rst2.Close
'    End If
'    rst4.Close
    
'    '====================== Loo Jia An END ==============================

'     If AdjIncome_Flag = True Then
'            If BALANCESHEET = True Then
'                Unload Me
'            Else
'                frmProfitLossAccountEdit.txtNAllowExp = FormatNumber(CDbl(non_allowable_expenses), 0)
'                Unload Me
'            End If
'        ElseIf IncomeCal_Flag = True Then
'            Unload Me
'        ElseIf IncomeCal_Flag1 = True Then
'            boolSaveComplete = True
'            ResetDataChange Me
'        Else
'        ' If frmIncomeCalculation.cmdEdit <> True Then
'        MsgBox "Record Saved !", vbInformation, "Taxcom"
'        'Save Before Exit
'        boolSaveComplete = True
'        ResetDataChange Me
'       ' Else
'        'ResetDataChange Me
'        'End If
'        'Unload Me
'        End If
''    If AdjIncome_Flag = True Then
''        frmProfitLossAccountEdit.txtNAllowExp = FormatNumber(CDbl(non_allowable_expenses), 0)
''        Unload Me
''    ElseIf IncomeCal_Flag = True Or IncomeCal_Flag1 = True Then
''    boolSaveComplete = True
''    ResetDataChange Me
''    IncomeCal_Flag = False
''    IncomeCal_Flag1 = False
''
''    Else
''      MsgBox "Record Saved Income Calculation!", vbInformation, "Taxcom"
''      boolSaveComplete = True
''        ResetDataChange Me
''        Unload Me
''    End If


'End Sub
''End Function

''Private Sub Command1_Click()
''btnApproDonation_Click
''End Sub

''Private Sub cmdSundryExp_Click()
''cICType = "ADD SU EXPENSES"
''    frmIncomeCalculationGeneral.Caption = "Sundry Income - Direct Expenses"
''    frmIncomeCalculationGeneral.Show
''End Sub

''Private Sub cmdSundryIn_Click()
''cICType = "Sundry Income"
''frmIncomeCalculationGeneral.Caption = "Sundry Income"
''frmIncomeCalculationGeneral.Show
''End Sub

'Private Sub cmdSundryIncome_Click()
'    frmSundryIncome.Show
'End Sub

''=== CYS 2010 ===
'Private Sub cmdView_Click()
'    frmIncomeCALPartnershipIncomeView.Show
'End Sub
''=== CYS end ===

'Private Sub cmdViewExport_Click()
'    cRAType = "EAEXEMPTION"
'    frmIncomeCALStatutoryIncome1.Caption = frmIncomeCALStatutoryIncome1.Caption
'    frmIncomeCALStatutoryIncome1.Show
    
    
'End Sub


'Private Sub Form_Load()
        

'    'LeeCC
'    If intMode = 0 Then
'        Set sForm = Screen.ActiveForm
'        sForm.Enabled = False
  
'    Else
'        frmDBoard2.Enabled = False
'    End If
       
''       Set sForm = Screen.ActiveForm
''       sForm.Enabled = False
    
'    'EA
'    'simkh 2012.1
''    txtEABalbf = sForm.ListViewEA.SelectedItem.ListSubItems(2).Text
''    txtEAExemption = sForm.ListViewEA.SelectedItem.ListSubItems(3).Text
''    txtEABalReIn = sForm.ListViewEA.SelectedItem.ListSubItems(4).Text
''    txtEAUtilised = sForm.ListViewEA.SelectedItem.ListSubItems(5).Text
''    txtEABalcf = sForm.ListViewEA.SelectedItem.ListSubItems(6).Text

'    If AdjIncome_Flag = True Or IncomeCal_Flag = True Then
'        'frmIncomeCalculationEdit.Show
        
'        cSQL = "SELECT * FROM [TAX_COMPUTATION] WHERE [TC_KEY] =" & CDbl(vIncomeCalKey)
'        Set rst = DB.Execute(cSQL)
'        If Not rst.EOF Then
'            cRefNo = rst!TC_REF_NO
'            cYA = rst!TC_YA
'            cCoName = rst!TC_CO_NAME
'            cSourceNo = Val(rst!TC_BUSINESS)
'        End If
'        rst.Close

'    'Leecc
'    ElseIf intMode = 0 Then
'        cRefNo = Mid(frmIncomeCalculation.lstView.SelectedItem.ListSubItems(1).Text, 2, Len(frmIncomeCalculation.lstView.SelectedItem.ListSubItems(1).Text))
'        cYA = frmIncomeCalculation.lstView.SelectedItem.ListSubItems(2).Text
'        cCoName = frmIncomeCalculation.lstView.SelectedItem.ListSubItems(3).Text
'        cSourceNo = frmIncomeCalculation.lstView.SelectedItem.ListSubItems(5).Text
     
'    ElseIf intMode = 1 Then
'        cRefNo = vRefNo
'        cYA = vYA
'        cCoName = vName
'        cSourceNo = vSourceNo
       
'    End If

'    Call Display_lstViewCAPI 'Loo Jia Ann TAxcom C+ Partneship
   
'    Call Refresh_RAPartnership ' CYS TAxcom C+ Partneship

'    Call display_value
   
'    If cYA >= "2007" Then
'        ' lbl2007.Caption = "Less :Tax rebate from exploration and exploitation activities of Petroleum in Joint Development Areas"
'        ' HS : C2008.7,'NGOHCS PNL
'        If Val(cYA) >= 2009 Then
'            btnApproDonation.Enabled = True
'        End If
'    Else
'        lbl2007.Caption = "Less : Section 6B Rebate"

'    End If

''===NgKL C2010.1==='
'    If cYA >= "2008" Then
'        lblOthAggre.Caption = "Other Aggregate Statutory Income (excluding Net Dividend Income)"
'    Else
'        lblOthAggre.Caption = "Other Aggregate Statutory Income"
'    End If

'    If cYA >= "2004" Then
'        txtOpHQChargeable.Enabled = False
'    Else
'        txtOpHQChargeable.Enabled = True
'    End If
''===NgKL C2010.1 End==='

''===== AZHAM 26-04-2017 ========
'    If cYA = "2017" Or cYA = "2018" Then
'        btnExemptionIncreaseChargeable.Visible = True
'    Else
'        btnExemptionIncreaseChargeable.Visible = False
'    End If

'    If CInt(cYA) >= 2017 Then
'        txtInstallments_107C.Visible = True
'        txtInstallments_107A.Visible = True
'        txtAppChargeableIn7.Visible = False
'        txtRate7.Visible = False
'        txtITPChargeableIn7.Visible = False
'        Label27.Visible = True
'        Label32.Visible = True
        
'        'txtInstallments.Enabled = False
'    Else
'        txtInstallments_107C.Visible = False
'        txtInstallments_107A.Visible = False
'        txtInstallments.Locked = False
'          txtAppChargeableIn7.Visible = False
'        txtRate7.Visible = False
'        txtITPChargeableIn7.Visible = False
'        Label27.Visible = False
'        Label32.Visible = False
'    End If
  
'     txtAppChargeableIn7 = "0"
'    txtRate7 = "0"
'    txtITPChargeableIn7 = "0"
'    '===== AZHAM 26-04-2017 ========
'    '=== csNgoh 2008 === '
'    YearChecking
'    '=== end csNgoh 2008 ===
'    SSTab1.Tab = 0
'    If Not (AdjIncome_Flag = True Or IncomeCal_Flag = True) Then
'        'Save Before Exit
    
'        ResetDataChange Me
      
'    End If

'End Sub

'Private Sub Form_Unload(Cancel As Integer)
'    'LeeCC rmk
'    If intMode = 0 Then
'        If AdjIncome_Flag = True Then
'            sForm.Enabled = True
'        ElseIf IncomeCal_Flag = True Then
'            sForm.Enabled = True
'        Else
'            'Save Before Exit
'            Cancel = OnScreenClose(Me)
                
'            If Not Cancel Then
'                frmIncomeCalculation.lstView.ListItems.Clear
'                Call Refresh_TaxComputation
'                sForm.Enabled = True
'            End If
'        End If
'    ElseIf intMode = 1 Then
'        frmDBoard2.Enabled = True
'        intMode = 0
'    End If
'    Erase objNonBusinessItem
'    Erase objExportAllowance 'LeeCC 2012.1 EA
'    Erase objCompany 'LeeCC 2012.1 EA
'    Erase objAgriculture 'LeeCC 2012.1 EA
'    Erase objSignificant 'LeeCC 2012.1 EA
'    Erase objMarket 'LeeCC 2012.1 EA
'    Erase objService 'LeeCC 2012.1 EA
'    Erase objNewMarket 'LeeCC 2012.1 EA
'End Sub

'Private Sub display_value()
'    txtRefNo = cRefNo
'    txtYA = cYA
'    txtCoName = cCoName
'    txtRate1 = 5
'    txtRate2 = 8
'    txtRate3 = 10
'    txtRate4 = 15
  
'        a = 0
'        cSQL = "SELECT * FROM [TAX_RATE] WHERE [TAX_YA]='" & cYA & "' ORDER BY [TAX_RATE]"
      
'        Set rst = DB.Execute(cSQL)
'        If Not rst.EOF Then
    
'            If rst.RecordCount = 1 Then
'                txtRate5 = rst!TAX_RATE
'            ElseIf rst.RecordCount = 2 Then
'                For a = 1 To rst.RecordCount
'                    If a = 1 Then
'                        txtRate4a = rst!TAX_RATE
'                    ElseIf a = 2 Then
'                        txtRate5 = rst!TAX_RATE
'                    End If
'                    rst.MoveNext
'                Next
'            End If
'        Else
      
'            txtRate4a = 20
''            If cYA >= 2007 Then
''                txtRate5 = 27
''            Else
''                txtRate5 = 28
''            End If
'            txtRate5 = 28

'            If cYA = 2007 Then
'                txtRate5 = 27
'            ElseIf cYA = 2008 Then
'                txtRate5 = 26
'            ElseIf cYA >= 2009 And cYA <= 2015 Then
'                txtRate5 = 25
'            ElseIf cYA >= 2016 Then
'                txtRate4a = 19
'                txtRate5 = 24
'            End If

'        End If
'        rst.Close
      
'        cSQL = "SELECT * FROM [TAX_COMPUTATION] WHERE [TC_KEY] =" & CDbl(vIncomeCalKey)
      
'        Set rst = DB.Execute(cSQL)
'        If Not rst.EOF Then
'            With rst
'                txtAllStatIn = !TC_SI_TOT
'                txtBsLoss = !TC_SI_BS_LOSS_BF
'                txtAggregate = !TC_SI_AGGREGATE
'                txtDividendIn = !TC_NB_DIV
'                txtDivAttrInt = !TC_NB_DIV_ATT_INT
'                txtDivOthers = FormatNumber(!TC_NB_DIV_OTH, 0)
'                txtDividendIncome = !TC_NB_DIV_NET
'                txtInterestIn = FormatNumber(!TC_NB_INT, 0)
'                txtIntAttrInt = !TC_NB_INT_ATT_INT
'                txtIntOthers = FormatNumber(!TC_NB_INT_OTH, 0)
'                txtInterestIncome = !TC_NB_INT_NET
'                txtRentalIn = !TC_NB_RENT
'                ' === csNgoh C2008.5 === '
'                txtOthers = !TC_NB_RENT_OTH2
'                txtRentAttrIn = !TC_NB_RENT_ATT_INT
'                txtRentAssess = !TC_NB_RENT_ASSESS
'                txtRentQuit = !TC_NB_RENT_QUIT
'                txtRentInsur = !TC_NB_RENT_INSUR
'                txtRentOthExp = !TC_NB_RENT_OTH
'                txtRentRepair = !TC_NB_RENT_MAIN
'                txtRentRenewal = !TC_NB_RENT_AGREE
'                txtRentalIncome = !TC_NB_RENT_NET
'                txtRoyaltyIncome = !TC_NB_ROYALTY
'                'LeeCC IBA start
'                txtRentalInIBA = !TC_NB_RENTIBA
'                txtOthersIBA = !TC_NB_RENTIBA_IBA
'                txtRentAttrInIBA = !TC_NB_RENTIBA_ATT_IN
'                txtRentAssessIBA = !TC_NB_RENTIBA_ASSESS
'                txtRentQuitIBA = !TC_NB_RENTIBA_QUIT
'                txtRentInsurIBA = !TC_NB_RENTIBA_INSUR
'                txtRentOthExpIBA = !TC_NB_RENTIBA_OTH
'                txtRentRepairIBA = !TC_NB_RENTIBA_MAIN
'                txtRentRenewalIBA = !TC_NB_RENTIBA_AGREE
'                'LeeCC IBA end
                
'                'LeeCC 2012 Disallowed Interest start
'                txtIntDisallow = !TC_NB_DIV_DIS_ATT_INT
'                txtTotalInterest = !TC_NB_DIV_TOT_ATT_INT
'                'LeeCC 2012 Disallowed Interest end
                
'                'DannyLee 2012 SU6.1
'                txtDCAInterest = !TC_NB_DCA_INT
'                txtDeemedInterest = !TC_NB_DEEMED_INT
                
'                txtSundryIn = !TC_NB_SUNDRY
'                ' === NGKL 2010.2 === '
'                txtDirExpenses3 = IIf(!TC_SUNDRY_EXP = "", 0, !TC_SUNDRY_EXP)
'                ' === NGKL 2010.2 END === '
'                txtAddition = !TC_NB_ADDITION
'                txtOthAggregate = !TC_NB_OTH_AGGR_STAT
'                txtAggregateIn = !TC_TP_AGGR_IN
'                txtCurrBsLoss = !TC_TP_CURR_LOSS
'                txtAggrLoss = !TC_TP_AGGR_IN_LOSS
'                txtProspecting = !TC_TP_PROSPECTING
'                txtQualifyAgri = !TC_TP_QUALIFY_AGRICULTURE
'                txtPreopBs = !TC_TP_PREOP_BS
'                txtFoodProduct = !TC_TP_FOOD_PRODUCTION
'                txtExpAllowed = !TC_TP_EXP_ALLOWED
'                txtTotalOthExp = !TC_TP_TOTAL_OTH_EXP
'                txtApprDonation = !TC_TP_APRV_DONATION
                
'                txtRate1 = !TC_TP_RATE1
'                txtRate2 = !TC_TP_RATE2
'                txtRate3 = !TC_TP_RATE3
'                txtRate4 = !TC_TP_RATE4
'                txtRate4a = !TC_TP_RATE4A
'               ' txtRate5 = !TC_TP_RATE5
'                txtRate6 = !TC_TP_RATE6
'                txtITPChargeableIn1 = !TC_TP_RATE1_CHARGEABLE
'                txtITPChargeableIn2 = !TC_TP_RATE2_CHARGEABLE
'                txtITPChargeableIn3 = !TC_TP_RATE3_CHARGEABLE
'                txtITPChargeableIn4 = !TC_TP_RATE4_CHARGEABLE
'                txtITPChargeableIn4a = !TC_TP_RATE4A_CHARGEABLE
'                txtITPChargeableIn5 = !TC_TP_28_CHARGEABLE
'                txtITPChargeableIn6 = !TC_TP_RATE5_CHARGEABLE
'                txtTotalTaxCharged = !TC_TP_TOT_TAX_CHARGED
                
'                txtAppChargeableIn1 = !TC_TP_APP_CHARGEABLE1
'                txtAppChargeableIn2 = !TC_TP_APP_CHARGEABLE2
'                txtAppChargeableIn3 = !TC_TP_APP_CHARGEABLE3
'                txtAppChargeableIn4 = !TC_TP_APP_CHARGEABLE4
'                txtAppChargeableIn4a = !TC_TP_APP_CHARGEABLE4A
'                txtAppChargeableIn5 = !TC_TP_APP_CHARGEABLE5
'                txtAppChargeableIn6 = !TC_TP_APP_CHARGEABLE6
'                ' === csNgoh C2008.5 === '
'                chargeable_apportionment
'                ' === end csNgoh C2008.5 === '
'                txtTotalIncome = !TC_TP_TOTAL_INCOME
'                txtPioneerChargeable = !TC_TP_PIONEER_CHARGE
'                txtChargeableIn = !TC_TP_CHARGEABLE
'                'azham 27042017
'                txtExemptionIncreaseChargeable = !TC_EXEMPTIONCAL
'                txtExemptionIncreaseChargeableAfter = !TC_EXEMPTIONLESS
'                'azham 27042017
                    
'                txtOpHQChargeable = !TC_TP_OPERATIONALHQ_CHARGE
'                txtForeignChargeable = !TC_TP_FOREIGN_CHARGE
                
'                txtSec6BRebate = !TC_TP_SEC6B_REBATE
'                txtITPSetoff = !TC_TP_SEC110
'                txtITPSetoffOth = !TC_TP_SEC110_OTHERS
'                txtSec132 = !TC_TP_SEC132
'                txtSec133 = !TC_TP_SEC133
'                txtTotalSetoff = !TC_TP_TOT_SETOFF
'                txtITP = !TC_TP_PAYABLE
'                txtInstallments = !TC_TP_INSTALL
'                txtInstallments_107C = !TC_TP_INSTALL_107C
'                txtInstallments_107A = !TC_TP_INSTALL_107A
'                txtTPBal = !TC_TP_PAYABLE_BAL
'                txtULUtilised = !TC_CB_LS_UTIL
'                txtULBalUtil = !TC_CB_LS_BAL_UTIL
'                txtCurrentYrLoss = !TC_CB_LS_ADJUST_LOSS
'                txtULUtilisedCurr = !TC_CB_LS_UTIL_CURR
'                txtUBL = !TC_CB_LS_UNABSORBED
'                txtULBalcf = !TC_CB_LS_BAL_CF 'Busienss Loss: Balance c/f
'                txtITABalbf = !TC_CB_ITA_BAL_BF
'                txtITAReinvest = !TC_CB_ITA_CURR
'                txtITABalReIn = !TC_CB_ITA_BAL_BF_CURR
'                txtITAUtilised = !TC_CB_ITA_UTIL
'                txtITABalcf = !TC_CB_ITA_BAL_CF
'                txtRABalbf = !TC_CB_RA_BAL_BF
'                txtRAReinvest = !TC_CB_RA_CURR
'                txtRABalReIn = !TC_CB_RA_BAL_BF_CURR
'                txtRAUtilised = !TC_CB_RA_UTIL
'                txtRABalcf = !TC_CB_RA_BAL_CF
                                               
'                'simkh 2012.1
''                txtEABalbf = !TC_EA_BAL_BF
''                txtEAExemption = !TC_EA_CURR_COMPANY Or !TC_EA_CURR_AGRICULTURE Or !TC_EA_CURR_SIGNIFICANT Or !TC_EA_CURR_MARKET Or !TC_EA_CURR_MSB
''                txtEABalReIn = !TC_CB_EA_BAL_BF_CURR
''                txtEAUtilised = !TC_EA_UTIL
''                txtEABalcf = !TC_EA_CF
               
'                'geline: Start: Taxcom  c+ v 2005.1
'                txtZakat = !TC_TP_ZAKAT
'                'geline: End: Taxcom  c+ v 2005.1
                
'                '==Oscar2009.1==
'                'dannylee 2012 su5.2
'                chkSMEFirst2Year = !TC_TP_ESTIMATED_SME
'                'dannylee end
'                txtInTaxPay2 = !TC_TP_INCOME_TP2 'Income Tax Payable
'                txtInTaxPay3 = !TC_TP_INCOME_TP2 - !TC_TP_ESTIMATED_TP 'Total
'                txtEsTaxPay = !TC_TP_ESTIMATED_TP 'Estimated Tax payable
'                txtAllowDiff = !TC_TP_ALL_DIFF 'Allowable difference
'                txtExDiff = !TC_TP_EX_DIFF 'Excessive Difference
'                txtPenOnExDiff = !TC_TP_PEN_DIFF 'Excessive Difference Penalty
'                '==End Oscar2009.1=='
                
'                'dannylee 2012 su5.2
'                If Trim(!TC_TP_ESTIMATED_SME) = "1" Then
'                    lblInTaxPay2.Visible = False
'                    lblEsTaxPay.Visible = False
'                    lblAllowDiff.Visible = False
'                    lblExDiff.Visible = False
'                    lblPenOnExDiff.Visible = False
'                    txtInTaxPay2.Visible = False
'                    txtInTaxPay3.Visible = False
'                    txtEsTaxPay.Visible = False
'                    txtAllowDiff.Visible = False
'                    txtExDiff.Visible = False
'                    txtPenOnExDiff.Visible = False
'                Else
'                    lblInTaxPay2.Visible = True
'                    lblEsTaxPay.Visible = True
'                    lblAllowDiff.Visible = True
'                    lblExDiff.Visible = True
'                    lblPenOnExDiff.Visible = True
'                    txtInTaxPay2.Visible = True
'                    txtInTaxPay3.Visible = True
'                    txtEsTaxPay.Visible = True
'                    txtAllowDiff.Visible = True
'                    txtExDiff.Visible = True
'                    txtPenOnExDiff.Visible = True
'                End If
'                'dannylee end
                
'                'EN
'                EsTaxPay
                
'                ' HS : 2009 : Change Unabsorbed business loss '
'                If Trim(!TC_NB_CARRYBCKLOSS) <> "0" Then
'                     txtCBL = !TC_NB_CARRYBCKLOSS
'                Else
'                    txtCBL = 0
'                End If
'                If !TC_NB_CHKCB = 1 Then
'                    chkCBL.Value = 1
'                Else
'                    chkCBL.Value = 0
'                End If
'                txtANCB = !TC_NB_AMTNOTCARRYBCK

'                'pin Taxcom C+ v2005.4 SP1
'                  ' === csNgoh 2008 === '
'                If Not IsNull(!TC_TP_SEC110B) Then
'                    txt110BSetOff = !TC_TP_SEC110B
'                End If
'                ' === end csNgoh 2008 ==='
'                ' === csNgoh 2008 === '
'                If Not IsNull(!TC_STAT_DIVIDEND) Then
'                    txtSIFrmDiv = !TC_STAT_DIVIDEND
'                End If
'                ' === end csNgoh 2008 ==='
                    
'                ' HS : C2008.7 : Placed here due to error on UBL
'                ' === csNgoh Julai 2008 === '
'                  If txtUBL = 0 Then
'                      txtSrdAmt = 0
'                      txtSrdAmt.Locked = True
'                      txtSrdAmt.BackColor = &H8000000F
'                  Else
'                      txtSrdAmt.Locked = False
'                      txtSrdAmt.BackColor = &HFFFFFF
'                  End If
'                  ' === end csNgoh Julai 2008 === '
'                  ' HS : C2008.7 : Placed here due to error on UBL : end
                    
'                ' === csNgoh 2008 === '
'                If Val(txtYA) >= 2008 Then
'                    If !TC_CB_CHECK = 2 Then
'                         ChkMajorC.Value = Unchecked
'                         ChkApply.Value = Unchecked
'                    ElseIf !TC_CB_CHECK = 1 Then
'                        ChkApply.Value = Checked
'                         ChkMajorC.Value = Checked
'                    ElseIf !TC_CB_CHECK = 0 Then
'                         ChkMajorC.Value = Unchecked
'                         ChkApply.Value = Checked
'                    End If
'                Else
'                    If !TC_CB_CHECK = 1 Then
'                         ChkMajorC.Value = Checked
'                    Else
'                         ChkMajorC.Value = Unchecked
'                    End If
'                End If
           
'                  txtClaim = IIf(IsNull(!TC_TP_CLAIM), 0, !TC_TP_CLAIM)
'                  txtSrdAmt = IIf(IsNull(!TC_CB_LS_SAMOUNT), 0, !TC_CB_LS_SAMOUNT)
'                  txtSrdAmt2 = IIf(IsNull(!TC_CB_LS_SRDAMT2), 0, !TC_CB_LS_SRDAMT2)
'                  txtBlnBf = IIf(IsNull(!TC_CB_LS_BLNBF), 0, !TC_CB_LS_BLNBF)
'                  txtAmtTut = IIf(IsNull(!TC_CB_LS_AMTTUT), 0, !TC_CB_LS_AMTTUT)
'                  txtBlnCf = IIf(IsNull(!TC_CB_LS_BLNCF), 0, !TC_CB_LS_BLNCF) 'TC_CB_LS_BALS_CF IIf(IsNull(!TC_CB_LS_BALS_CF), 0, !TC_CB_LS_BALS_CF)

'               'HS : C2008.7 : Placed here due to error on UBL
'                Call txtSrdAmt_Change
'               'HS : C2008.7 : Placed here due to error on UBL : end
'                Call chkCBL_Click
              
'                '==Oscar2009.1==' Business Loss S60FA
'                cSQL3 = "SELECT * FROM [PROFIT_LOSS_ACCOUNT] WHERE [PL_REF_NO] = '" & txtRefNo & "' AND [PL_YA] = '" & txtYA & "'"
'                Set rst3 = DB.Execute(cSQL3)
              
'                If Not rst3.EOF Then
'                    strS60FA = rst3!PL_S60FA
'                    If rst3!PL_S60FA = "Y" Then
'                        txtULBalbf = 0
'                        txtULBalcf = 0
'                        txtBalcf = 0
'                        txtDisABL.Enabled = False
'                        txtDisABL.BackColor = &H8000000F
'                        'txtDisABL = FormatNumber(CDbl(txtULBalcf), 0) 'Hide it (Cancel)
'                        cmdNote.Enabled = False
'                    Else
'                        If ChkMajorC = 1 Then
'                            txtULBalcf = FormatNumber(CDbl(!TC_CB_LS_BAL_UTIL) + CDbl(!TC_CB_LS_UNABSORBED) - CDbl(!TC_CB_LS_SAMOUNT) - CDbl(!TC_NB_CARRYBCKLOSS), 0)
'                            txtDisABL = FormatNumber(CDbl(!TC_CB_LS_D_BL), 0) 'FormatNumber(CDbl(txtULBalcf), 0) 'PINP3R2
'                            txtBalcf = FormatNumber(CDbl(txtULBalcf) - CDbl(txtDisABL), 0)
'                            If txtULBalcf < 0 Then 'PINP3R2
'                                txtULBalcf = 0
'                            End If

'                            If txtBalcf < 0 Then 'PINP3R2
'                                txtBalcf = 0
'                            End If
'                        Else
'                            txtULBalcf = FormatNumber(CDbl(!TC_CB_LS_BAL_UTIL) + CDbl(!TC_CB_LS_UNABSORBED) - CDbl(IIf(IsNull(!TC_CB_LS_SAMOUNT), 0, CDbl(!TC_CB_LS_SAMOUNT))) - CDbl(!TC_NB_CARRYBCKLOSS), 0)
'                            txtDisABL = 0
'                            txtBalcf = FormatNumber(CDbl(txtULBalcf) - CDbl(txtDisABL), 0)
'                            txtDisABL.Enabled = False
'                            txtDisABL.BackColor = &H8000000F
'                            cmdNote.Enabled = False
'                        End If
'                    End If
'                End If
          
'                'rst3.Close
'                '==End Oscar2009.1=='
                
'                ' HS : C2008.7 : Hide due to error on UBL
'                ' === csNgoh Julai 2008 === '
''                  If txtUBL = 0 Then
''                      txtSrdAmt = 0
''                      txtSrdAmt.Locked = True
''                      txtSrdAmt.BackColor = &H8000000F
''                  Else
''                      txtSrdAmt.Locked = False
''                      txtSrdAmt.BackColor = &HFFFFFF
''                  End If
'                  ' === end csNgoh Julai 2008 === '
                
'                'Call txtSrdAmt_Change
'                ' HS : C2008.7 : Hide due to error on UBL : end
'                ' HS : Add for refresh C/F balance after reopen
                
'                'Hide due to error on Balance c/f (Net), and moved on top
'                'Oscar2009.1=='
'                'Call chkCBL_Click
'                '==End Oscar2009.1=='
                
'                ' HS : Add for refresh C/F balance after reopen : end
                  
'                DBSNote = IIf(IsNull(!TC_DISALLOWBUSINESS_NOTE), "", !TC_DISALLOWBUSINESS_NOTE) 'PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'            End With
'        End If
'        rst.Close
 
'        'azham 27042017
''         cSQL = "SELECT * FROM [TAX_COMPUTATION_EXEMPTION] WHERE [REF_NO] ='" & txtRefNo & "' AND [YA] = '" & txtYA & "'"
''         Set rst = DB.Execute(cSQL)
''
''        lvExemptionChargeable.ListItems.Clear
''        If Not rst.EOF Then
''
''                Set xItem = lvExemptionChargeable.ListItems.Add(1, , rst.Fields(0)) 'NO
''                'STATUTORY_BIZ_INCOME_A
''                'AGGREGATE_INCOME_A
''                'CHARGEABLE_INCOME_A
''                'STATUTORY_BIZ_INCOME_B
''                'AGGREGATE_INCOME_B
''                'CHARGEABLE_INCOME_B
''                With xItem
''                    .ListSubItems.Add 1, , rst.Fields(1) 'YA
''                    .ListSubItems.Add 2, , rst.Fields(2) 'REFNO
''                    .ListSubItems.Add 3, , FormatNumber(CDbl(rst.Fields(3)), 2) 'STATUTORY_BIZ_INCOME_A
''                    .ListSubItems.Add 4, , FormatNumber(CDbl(rst.Fields(4)), 2) 'AGGREGATE_INCOME_A
''                    .ListSubItems.Add 5, , FormatNumber(CDbl(rst.Fields(5)), 2) 'CHARGEABLE_INCOME_A
''                    .ListSubItems.Add 6, , FormatNumber(CDbl(rst.Fields(6)), 2) 'STATUTORY_BIZ_INCOME_B
''                    .ListSubItems.Add 7, , FormatNumber(CDbl(rst.Fields(7)), 2) 'AGGREGATE_INCOME_B
''                    .ListSubItems.Add 8, , FormatNumber(CDbl(rst.Fields(8)), 2) 'CHARGEABLE_INCOME_B
''                    .ListSubItems.Add 9, , FormatNumber(CDbl(rst.Fields(9)), 2) 'TOTAL_CHARGEABLE_INCOME_A
''                    .ListSubItems.Add 10, , FormatNumber(CDbl(rst.Fields(10)), 2) 'TOTAL_CHARGEABLE_INCOME_B
''                    .ListSubItems.Add 11, , FormatNumber(CDbl(rst.Fields(11)), 2) 'TOTAL_A_B
''                    .ListSubItems.Add 12, , FormatNumber(CDbl(rst.Fields(12)), 2) 'RATE
''                    .ListSubItems.Add 13, , FormatNumber(CDbl(rst.Fields(13)), 2) 'TOTAL
''                    .ListSubItems.Add 14, , FormatNumber(CDbl(rst.Fields(14)), 2) 'SUB_RATE
''                End With
''              rst.Close
''        Else
''
''            Set xItem = lvExemptionChargeable.ListItems.Add(1, , 0) 'NO
''                'STATUTORY_BIZ_INCOME_A
''                'AGGREGATE_INCOME_A
''                'CHARGEABLE_INCOME_A
''                'STATUTORY_BIZ_INCOME_B
''                'AGGREGATE_INCOME_B
''                'CHARGEABLE_INCOME_B
''                With xItem
''                    .ListSubItems.Add 1, , txtYA 'YA
''                    .ListSubItems.Add 2, , txtRefNo 'REFNO
''                    .ListSubItems.Add 3, , 0 'STATUTORY_BIZ_INCOME_A
''                    .ListSubItems.Add 4, , 0 'AGGREGATE_INCOME_A
''                    .ListSubItems.Add 5, , 0 'CHARGEABLE_INCOME_A
''                    .ListSubItems.Add 6, , 0 'STATUTORY_BIZ_INCOME_B
''                    .ListSubItems.Add 7, , 0 'AGGREGATE_INCOME_B
''                    .ListSubItems.Add 8, , 0 'CHARGEABLE_INCOME_B
''                    .ListSubItems.Add 9, , 0 'TOTAL_CHARGEABLE_INCOME_A
''                    .ListSubItems.Add 10, , 0 'TOTAL_CHARGEABLE_INCOME_B
''                    .ListSubItems.Add 11, , 0 'TOTAL_A_B
''                    .ListSubItems.Add 12, , 0 'RATE
''                    .ListSubItems.Add 13, , 0 'TOTAL
''                    .ListSubItems.Add 14, , 0 'SUB_RATE
''                End With
''        End If
'    ' === csNgoh C2008.5 === '

'    Call LoadLvGeneralNone
'    ' === end csNgoh C2008.5 === '
  
'    ' === NGOHCS CA2008 === '
'    Call LoadLvWithdrawal
   
'    ' === NGOHCS CA2008 END === '
'    Call INTEREST_RESTRIC
  
          
'    Call total_other_expenses
    
'    If CDbl(txtClaim.Text) > CDbl(txtTotalOthExp.Text) - CDbl(txtApprDonation.Text) - CDbl(txtZakat.Text) Then
'      txtClaim = 0
'    End If
'    Call cal_totalIncome
'    lstView.ListItems.Clear
'    lstViewCA.ListItems.Clear
   
''    Erase objExportAllowance 'LeeCC 2012.1 EA
''    Erase objCompany 'LeeCC 2012.1 EA
''    Erase objAgriculture 'LeeCC 2012.1 EA
''    Erase objSignificant 'LeeCC 2012.1 EA
''    Erase objMarket 'LeeCC 2012.1 EA
''    Erase objService 'LeeCC 2012.1 EA
''    Erase objNewMarket 'LeeCC 2012.1 EA
    
'    Dim intCount As Integer
'    intCount = 0
'    If cSourceNo = 1 Then
'        cSQL = "SELECT [TC_BUSINESS],[TC_AI_TOT_BS_IN],[TC_AI_TOT_ADJ_BS_IN],[TC_AI_TOT_ADJ_BS_EXP],[TC_AI_ADJ_IN_LOSS],[TC_SI_ADJ_BS_IN],[TC_SI_BC],[TC_SI_ADJ_BS_IN_BC],[TC_SI_CA],[TC_SI_STAT_BS_IN],[TC_SI_INVEST_ALLOW],[TC_SI_NET_STAT_IN],[TC_SI_RA],[TC_CB_CA_BA],[TC_CB_CA_NA],[TC_KEY],* FROM [TAX_COMPUTATION] WHERE [TC_REF_NO]='" & Trim(cRefNo) & "' AND [TC_YA]='" & Trim(cYA) & "' ORDER BY [TAX_COMPUTATION].[TC_BUSINESS]" ' AND [TC_BUSINESS]=" & cSourceNo
'    Else
'        cSQL = "SELECT [TC_BUSINESS],[TC_AI_TOT_BS_IN],[TC_AI_TOT_ADJ_BS_IN],[TC_AI_TOT_ADJ_BS_EXP],[TC_AI_ADJ_IN_LOSS],[TC_SI_ADJ_BS_IN],[TC_SI_BC],[TC_SI_ADJ_BS_IN_BC],[TC_SI_CA],[TC_SI_STAT_BS_IN],[TC_SI_INVEST_ALLOW],[TC_SI_NET_STAT_IN],[TC_SI_RA],[TC_CB_CA_BA],[TC_CB_CA_NA],[TC_KEY],* FROM [TAX_COMPUTATION] WHERE [TC_REF_NO]='" & Trim(cRefNo) & "' AND [TC_YA]='" & Trim(cYA) & "' AND [TC_BUSINESS]=" & cSourceNo & " ORDER BY [TAX_COMPUTATION].[TC_BUSINESS]"
'    End If
 
'    Set rst = DB.Execute(cSQL)

'    If Not rst.EOF Then
    '        Do While Not rst.EOF
    'AZHAM 13/08/2018 
'            Set xItem = lstView.ListItems.Add(, , rst.Fields(0))
'            With xItem
         
'                cSQL2 = "SELECT [BC_TYPE] FROM [BUSINESS_SOURCE] WHERE [BC_KEY]='" & Trim(cRefNo) & "' AND [BC_YA]='" & Trim(cYA) & "' AND [BC_SOURCENO]=" & rst.Fields(0) & " ORDER BY [BC_SOURCENO]"
'                Set rst1 = DB.Execute(cSQL2)
'                If Not rst1.EOF Then
'                    .ListSubItems.Add 1, , rst1.Fields(0)
'                Else
'                    .ListSubItems.Add 1, , ""
'                End If
'                rst1.Close
'                .ListSubItems.Add 2, , FormatNumber(CDbl(rst.Fields(1)), 0) 'Total Business Income
'                .ListSubItems.Add 3, , FormatNumber(CDbl(rst.Fields(2)), 0) 'Adjustments for Business Income
'                .ListSubItems.Add 4, , FormatNumber(CDbl(rst.Fields(3)), 0) 'Adjustments for Business Expenditure
'                .ListSubItems.Add 5, , FormatNumber(CDbl(rst.Fields(4)), 0) 'Adjusted Income / Loss
'                .ListSubItems.Add 6, , FormatNumber(CDbl(rst.Fields(5)), 0) 'Adjusted Business Income
'                .ListSubItems.Add 7, , FormatNumber(CDbl(rst.Fields(6)), 0) 'Balancing Charge
'                .ListSubItems.Add 8, , FormatNumber(CDbl(rst.Fields(7)), 0) 'Total
'                .ListSubItems.Add 9, , FormatNumber(CDbl(rst.Fields(8)), 0) 'Capital Allowances
'                .ListSubItems.Add 10, , FormatNumber(CDbl(rst.Fields(9)), 0) 'Statutory Business Income
'                .ListSubItems.Add 11, , FormatNumber(CDbl(rst!TC_SI_RA), 0) 'FormatNumber(CDbl(rst.Fields(12)), 0) 'Reinvestment Allowance
'                .ListSubItems.Add 12, , FormatNumber(CDbl(rst!TC_SI_INVEST_ALLOW), 0) 'FormatNumber(CDbl(rst.Fields(10)), 0) 'Investment Tax Allowance
'                .ListSubItems.Add 13, , FormatNumber(CDbl(rst!TC_SI_NET_STAT_IN), 0) 'Net Statutory Income TC_SI_NET_STAT_IN
'                .ListSubItems.Add 14, , rst!TC_KEY  'Key
'                .ListSubItems.Add 15, , IIf(Not IsNull(rst!TC_PIONEERDESC), rst!TC_PIONEERDESC, " ") ''PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'                .ListSubItems.Add 16, , rst!TC_PIO  ''PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'                .ListSubItems.Add 17, , rst!TC_PIONEER  ''PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'                .ListSubItems.Add 18, , rst!TC_RA_RATE1  ''PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'                .ListSubItems.Add 19, , rst!TC_RA_QUALIFYINGCAPITALEXP  ''PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'                .ListSubItems.Add 20, , rst!TC_RA_QUALIFYINGCAPITALEXP_AMOUNT ''PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'                .ListSubItems.Add 21, , rst!TC_RA_BALANCINGALLOWANCE ''PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'                .ListSubItems.Add 22, , rst!TC_RA_TOTAL1  ''PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'                .ListSubItems.Add 23, , rst!TC_RA_RESTRICTRATE  ''PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'                .ListSubItems.Add 24, , rst!TC_RA_RESTRICTAMOUNT ''PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'                .ListSubItems.Add 25, , rst!TC_ITA_RATE1  ''PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'                .ListSubItems.Add 26, , rst!TC_ITA_QUALIFYINGCAPITALEXP  ''PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'                .ListSubItems.Add 27, , rst!TC_ITA_QUALIFYINGCAPITALEXP_AMOUNT ''PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'                .ListSubItems.Add 28, , rst!TC_ITA_BALANCINGALLOWANCE ''PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'                .ListSubItems.Add 29, , rst!TC_ITA_TOTAL1  ''PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'                .ListSubItems.Add 30, , rst!TC_ITA_RESTRICTRATE  ''PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'                .ListSubItems.Add 31, , rst!TC_ITA_RESTRICTAMOUNT  ''PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'                .ListSubItems.Add 32, , rst!TC_WITHRAITA ''Withdrawal RAITA - NGOHCS TAXCOM CA2008
'                'LeeCC 2010.2 start
'                .ListSubItems.Add 33, , rst!TC_CHK_EXEMP
'                'LeeCC 2010.2 end
                
'                'simkh 2012.1
''                On Error Resume Next
''                If UBound(objExportAllowance) Then
''                    If Err.Number = 9 Then
''                        intCount = 0
''                        'ReDim objExportAllowance(0)
''                    End If
''                Else
''                    intCount = intCount + 1
''                    'ReDim Preserve objExportAllowance(CInt(UBound(objExportAllowance)) + 1)
''                End If

'                'leecc 2012.1 rmk
'                ReDim Preserve objExportAllowance(intCount)

'                objExportAllowance(intCount).strBusiness = rst!TC_BUSINESS
'                objExportAllowance(intCount).strAllowanceAgriculture = rst!TC_EA_CURR_AGRICULTURE
'                objExportAllowance(intCount).strAllowanceCompany = rst!TC_EA_CURR_COMPANY
'                objExportAllowance(intCount).strAllowanceMarket = rst!TC_EA_CURR_MARKET
'                objExportAllowance(intCount).strAllowanceService = rst!TC_EA_CURR_MSB
'                objExportAllowance(intCount).strAllowanceSignificant = rst!TC_EA_CURR_SIGNIFICANT
'                objExportAllowance(intCount).strBalance = rst!TC_EA_BF
'                objExportAllowance(intCount).strRestrictRate = rst!TC_EA_RESTRICTRATE
'                objExportAllowance(intCount).strType = rst!TC_EA_TYPE
'                objExportAllowance(intCount).strUtilised = rst!TC_EA_UTL
'                objExportAllowance(intCount).strAllowance = rst!TC_EA_TOTAL
'                objExportAllowance(intCount).strCarryForward = rst!TC_EA_CF
                
''                .ListSubItems.Add 34, , rst!TC_EA_CURR_COMPANY
''                .ListSubItems.Add 35, , rst!TC_EA_CURR_AGRICULTURE
''                .ListSubItems.Add 36, , rst!TC_EA_CURR_SIGNIFICANT
''                .ListSubItems.Add 37, , rst!TC_EA_CURR_MARKET
''                .ListSubItems.Add 38, , rst!TC_EA_CURR_MSB
''                .ListSubItems.Add 39, , rst!TC_EA_BALANCINGALLOWANCE
''                .ListSubItems.Add 40, , rst!TC_EA_TOTAL1
''                .ListSubItems.Add 41, , rst!TC_EA_RESTRICTRATE
''                .ListSubItems.Add 42, , rst!TC_EA_RESTRICTAMOUNT
''                .ListSubItems.Add 42, , rst!TC_EA_CF
                
                
                
'            End With
'            Set xItem = lstViewCA.ListItems.Add(, , rst.Fields(0))
'            With xItem
'                cSQL2 = "SELECT [BC_TYPE] FROM [BUSINESS_SOURCE] WHERE [BC_KEY]='" & Trim(cRefNo) & "' AND [BC_YA]='" & Trim(cYA) & "' AND [BC_SOURCENO]=" & rst.Fields(0) & " ORDER BY [BC_SOURCENO]"
           
'                Set rst1 = DB.Execute(cSQL2)
                
'                If Not rst1.EOF Then
'                    .ListSubItems.Add 1, , rst1.Fields(0)
'                Else
'                    .ListSubItems.Add 1, , ""
'                End If
'                rst1.Close
'                .ListSubItems.Add 2, , 0 'Balance b/f
'                .ListSubItems.Add 3, , 0 'AA
'                .ListSubItems.Add 4, , 0 'IA
'                .ListSubItems.Add 5, , FormatNumber(CDbl(rst.Fields(14)), 0) 'Notional Allowance
'                .ListSubItems.Add 6, , 0 'UCA Year
'                .ListSubItems.Add 7, , FormatNumber(CDbl(rst.Fields(13)), 0) 'Balancing Allowance
'                .ListSubItems.Add 8, , 0 'Total
'                .ListSubItems.Add 9, , 0 'UCA Utilised
'                .ListSubItems.Add 10, , 0 'Balance c/f
    '                'pin Tacomm C+ v2005.4 SP1
'                .ListSubItems.Add 11, , rst!TC_CB_CA_DISALLOW '0 'Disallowed CA
'                .ListSubItems.Add 12, , rst!TC_CB_CA_ABAL_CF '0 'Actual Balance c/f
'                .ListSubItems.Add 13, , rst!TC_DISALLOW_NOTE 'Disallowed CA NOTE 'PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
                
'                ' === csNgoh Julai 2008 === '
'                'If Not IsNull(rst!TC_CB_CA_BC) Then
'                '    .ListSubItems.Add 14, , rst!TC_CB_CA_BC 'Balancing Charge
'                'Else
'                '    .ListSubItems.Add 14, , 0
'                'End If
'                ' === end csNgoh Julai 2008 === '
                
'                .ListSubItems.Add 14, , 0 'weihong Accelerated value
                
'            End With
    'AZHAM 13/08/2018
'           ' ListViewRA
'            Set xItem = ListViewRA.ListItems.Add(, , rst.Fields(0))
'            With xItem
     
'                cSQL2 = "SELECT [BC_TYPE] FROM [BUSINESS_SOURCE] WHERE [BC_KEY]='" & Trim(cRefNo) & "' AND [BC_YA]='" & Trim(cYA) & "' AND [BC_SOURCENO]=" & rst.Fields(0) & " ORDER BY [BC_SOURCENO]"
'                Set rst1 = DB.Execute(cSQL2)
               
'                If Not rst1.EOF Then
'                    .ListSubItems.Add 1, , rst1.Fields(0)
'                Else
'                    .ListSubItems.Add 1, , ""
'                End If
'                rst1.Close 'O2008.1, 'NGOHCS CA2008
'                .ListSubItems.Add 2, , FormatNumber(CDbl(rst!TC_CB_RA_BAL_BF), 0) 'Balance b/f
'                .ListSubItems.Add 3, , FormatNumber(CDbl(rst!TC_CB_RA_CURR), 0) 'RA for the year
'                .ListSubItems.Add 4, , FormatNumber(CDbl(rst!TC_CB_RA_BAL_BF) + CDbl(rst!TC_CB_RA_CURR), 0) 'FormatNumber(CDbl(rst!TC_CB_RA_BAL_BF_CURR), 0) 'Total
'                .ListSubItems.Add 5, , FormatNumber(CDbl(rst!TC_SI_RA), 0)  'rst!TC_CB_RA_UTIL 'Utilised
'                .ListSubItems.Add 6, , FormatNumber(CDbl(rst!TC_CB_RA_BAL_CF), 0) 'Balance C/F
'                .ListSubItems.Add 7, , FormatNumber(CDbl(rst!TC_RA_WITHDRAWAL), 0) 'RA Withdrawal
'                .ListSubItems.Add 8, , FormatNumber(CDbl(rst!TC_RA_ADJUSTMENT), 0) 'RA Adjustment
'            End With

    'AZHAM 13/08/2018
'            ' ListViewITA
'            Set xItem = ListViewITA.ListItems.Add(, , rst.Fields(0))
'            With xItem
         
'                cSQL2 = "SELECT [BC_TYPE] FROM [BUSINESS_SOURCE] WHERE [BC_KEY]='" & Trim(cRefNo) & "' AND [BC_YA]='" & Trim(cYA) & "' AND [BC_SOURCENO]=" & rst.Fields(0) & " ORDER BY [BC_SOURCENO]"
'                Set rst1 = DB.Execute(cSQL2)
                
'                If Not rst1.EOF Then
'                    .ListSubItems.Add 1, , rst1.Fields(0)
'                Else
'                    .ListSubItems.Add 1, , ""
'                End If
'                rst1.Close 'O2008.1, 'NGOHCS CA2008
'                .ListSubItems.Add 2, , FormatNumber(CDbl(rst!TC_CB_ITA_BAL_BF), 0) 'Balance b/f
'                .ListSubItems.Add 3, , FormatNumber(CDbl(rst!TC_CB_ITA_CURR), 0)  'ITA for the year
'                .ListSubItems.Add 4, , FormatNumber(CDbl(rst!TC_CB_ITA_BAL_BF) + CDbl(rst!TC_CB_ITA_CURR), 0) 'FormatNumber(CDbl(rst!TC_CB_ITA_BAL_BF_CURR), 0) 'Total
'                .ListSubItems.Add 5, , FormatNumber(CDbl(rst!TC_SI_INVEST_ALLOW), 0)  'rst!TC_CB_ITA_UTIL TOTAL ALL SOURCE 'Utilised
'                .ListSubItems.Add 6, , FormatNumber(CDbl(rst!TC_CB_ITA_BAL_CF), 0) 'Balance C/F
'                .ListSubItems.Add 7, , FormatNumber(CDbl(rst!TC_ITA_WITHDRAWAL), 0) 'ITA Withdrawal
'                .ListSubItems.Add 8, , FormatNumber(CDbl(rst!TC_ITA_ADJUSTMENT), 0) 'ITA Adjustment
'            End With
            
                             
'              ' ListViewNOTE
'            Set xItem = lvNote.ListItems.Add(, , "2") 'PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'            xItem.ListSubItems.Add , , DBSNote
            
'            Set xItem = lstViewEA.ListItems.Add(, , rst.Fields(0))
'            With xItem
          
'                cSQL2 = "SELECT [BC_TYPE] FROM [BUSINESS_SOURCE] WHERE [BC_KEY]='" & Trim(cRefNo) & "' AND [BC_YA]='" & Trim(cYA) & "' AND [BC_SOURCENO]=" & rst.Fields(0) & " ORDER BY [BC_SOURCENO]"
'                Set rst1 = DB.Execute(cSQL2)
             
'                If Not rst1.EOF Then
'                    .ListSubItems.Add 1, , rst1.Fields(0)
'                Else
'                    .ListSubItems.Add 1, , ""
'                End If
                
'                .ListSubItems.Add 2, , FormatNumber(CDbl(rst!TC_EA_BF), 0)
'                Select Case rst!TC_EA_TYPE
'                    Case 1
'                        .ListSubItems.Add 3, , FormatNumber(CDbl(rst!TC_EA_CURR_COMPANY), 0)
'                    Case 2
'                        .ListSubItems.Add 3, , FormatNumber(CDbl(rst!TC_EA_CURR_AGRICULTURE), 0)
'                    Case 3
'                        .ListSubItems.Add 3, , FormatNumber(CDbl(rst!TC_EA_CURR_SIGNIFICANT), 0)
'                    Case 4
'                        .ListSubItems.Add 3, , FormatNumber(CDbl(rst!TC_EA_CURR_MARKET), 0)
'                    Case 5
'                        .ListSubItems.Add 3, , FormatNumber(CDbl(rst!TC_EA_CURR_MSB), 0)
'                    Case Else
'                        .ListSubItems.Add 3, , 0
'                End Select
                
'                .ListSubItems.Add 4, , FormatNumber(CDbl(rst!TC_EA_TOTAL), 0)
'                .ListSubItems.Add 5, , FormatNumber(CDbl(rst!TC_EA_UTL), 0)
'                .ListSubItems.Add 6, , FormatNumber(CDbl(rst!TC_EA_CF), 0)
'            End With
            

'            Call LoadExportAllowanceCompany(rst!TC_KEY, rst!TC_BUSINESS, intCount)
            
'            Call LoadExportAllowanceAgriculture(rst!TC_KEY, rst!TC_BUSINESS, intCount)
           
'            Call LoadExportAllowanceSignificant(rst!TC_KEY, rst!TC_BUSINESS, intCount)
          
'            Call LoadExportAllowanceMarket(rst!TC_KEY, rst!TC_BUSINESS, intCount)
          
'            Call LoadExportAllowanceService(rst!TC_KEY, rst!TC_BUSINESS, intCount)
           
            
'            intCount = intCount + 1
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close

'    If cSourceNo = 1 Then
  
'        cSQL = "SELECT * FROM [PROFIT_LOSS_ACCOUNT] WHERE [PL_REF_NO]='" & Trim(cRefNo) & "' AND [PL_YA]='" & Trim(cYA) & "'"
'        Set rst = DB.Execute(cSQL)
    
'        If Not rst.EOF Then    'O2008.1

'            txtDividendIn = FormatNumber(CDbl(rst!PL_TREGROSS), 0) 'FormatNumber(CDbl(rst!PL_OTH_IN_DIVIDEND), 0)
'        '===NgKL C2010==='
'            'txtInterestIn(0) = FormatNumber(CDbl(rst!PL_OTH_IN_INTEREST), 0)
'        '===NgKL End==='
'            txtRentalIn = FormatNumber(CDbl(rst!PL_OTH_IN_RENTAL) - CDbl(txtRentalInIBA), 0)
'            If Not IsNull(rst!PL_TOTALY) Then
'                'txtITPSetoff = FormatNumber(CDbl(rst!PL_TOTALY), 2)
'                txtITPSetoff = FormatNumber(CDbl(rst!PL_TTAXDEDUCTION), 2)
'            End If
'            txtRoyaltyIncome = rst!PL_OTH_IN_ROYALTY
'        ' === NGKL 2010.2 === '
'            'txtSundryIn = rst!PL_OTH_IN_OTHER
'        ' === NGKL 2010.2 END === '
'        End If
'        rst.Close
        
'        'LeeCC IBA
        
'        Call CalculateTotalNetIncome
     
'        '-----------------------------
'        'Statutory Income Calculation
'        '-----------------------------
'        If lstView.ListItems.count > 0 Then
'            For i = 1 To lstView.ListItems.count
'                If lstView.ListItems(i).ListSubItems(5).Text < 0 Then
'                    lstView.ListItems(i).ListSubItems(6).Text = 0 'Adjusted Business Income
'                Else
'                    lstView.ListItems(i).ListSubItems(6).Text = FormatNumber(CDbl(lstView.ListItems(i).ListSubItems(5).Text), 0)
'                End If
'            Next
'        End If

'        'Get Total Statutory Income from all sources
'        totalstatutory = 0
'        If lstView.ListItems.count > 0 Then
'            For X = 1 To lstView.ListItems.count
'                totalstatutory = FormatNumber(CDbl(totalstatutory) + CDbl(lstView.ListItems(X).ListSubItems(11).Text), 0)
'            Next
'        End If
'        txtAllStatIn = FormatNumber(totalstatutory, 0)
      
'        Call txtAggregateIn_Change
       
'        '---------------------------------------------
'        'Get CA, Business Loss and RA/ITA Balance b/f
'        '---------------------------------------------
'        ULBalance = 0
'        ITABalance = 0
'        RABalance = 0
'        SABalance = 0 ' pin
'        txtULBalbf = FormatNumber(CDbl(ULBalance), 0)
'        txtITABalbf = FormatNumber(CDbl(ITABalance), 0)
'        txtRABalbf = FormatNumber(CDbl(RABalance), 0)
'        txtBlnBf = FormatNumber(CDbl(SABalance), 0)  'pin
   
'        '==Oscar2009.1==' Set the balance b/f in lstViewCA amounts to 0 when S60FA is Yes
'        Dim rstS60FA As New ADODB.Recordset
'        Dim intS60FA As String
'        cSQL3 = "SELECT * FROM [PROFIT_LOSS_ACCOUNT] WHERE [PL_REF_NO] = '" & txtRefNo & "' AND [PL_YA] = '" & txtYA & "'"
'        Set rstS60FA = DB.Execute(cSQL3)
'        If Not rstS60FA.EOF Then
'            intS60FA = rstS60FA!PL_S60FA
'        End If
'        rstS60FA.Close

'        Call LoadOpeningBalance(intS60FA)
 
'        Call RefreshExemptionValue
  
        
'        '==End Oscar2009.1=='
        
''        'LeeCC 2012.1 Export Allowance b/f
''        cSQL = "SELECT [OB_SCHEDULE],[OB_BS_LOSS],[OB_INVESTMENT],[OB_SOURCENO],[OB_RA],[OB_SRNAMT], [OB_EXPORT] FROM [OPENING_BALANCE] WHERE [OB_REF_NO]='" & Trim(cRefNo) & "' AND [OB_YA]='" & Trim(cYA) & "' ORDER BY [OB_SOURCENO]"
''        Set rst = DB.Execute(cSQL)
''        If Not rst.EOF Then
''            Do While Not rst.EOF
''                If lstViewCA.ListItems.count > 0 Then
''                    For i = 1 To lstViewCA.ListItems.count
''                        If rst.Fields(3) = lstViewCA.ListItems(i).Text Then
''                        ' === csNgoh Julai 2008 === '
''                            '==Oscar2009.1==' S60FA
''                            If intS60FA = "Y" Then
''                                lstViewCA.ListItems(i).ListSubItems(2).Text = "0"
''                            Else
''                                If CDbl(lstViewCA.ListItems(i).Text) > 0 Then
''                                    lstViewCA.ListItems(i).ListSubItems(2).Text = FormatNumber(CDbl(rst.Fields(0)), 0) 'Balance b/f
''                                Else
''                                    lstViewCA.ListItems(i).ListSubItems(2).Text = "0"
''                                End If
''                            End If
''                            '==End Oscar2009.1=='
''                        End If
''                        ' === End csNgoh Julai 2008 === '
''                    Next
''                End If
''
''                Dim strNo As String
''
''                'LeeCC 2012.1 Export Allowance b/f
''                If lstViewEA.ListItems.count > 0 Then
''                    For i = 0 To UBound(objExportAllowance)
''                        If objExportAllowance(i).strBusiness = rst.Fields(4) Then
''                            strNo = i
''                            objExportAllowance(i).strBalance = rst!OB_EXPORT
''                            Select Case objExportAllowance(i).strType
''                                Case 1
''                                    objExportAllowance(i).strAllowance = objExportAllowance(i).strBalance + objExportAllowance(i).strAllowanceCompany
''                                Case 2
''                                    objExportAllowance(i).strAllowance = objExportAllowance(i).strBalance + objExportAllowance(i).strAllowanceAgriculture
''                                Case 3
''                                    objExportAllowance(i).strAllowance = objExportAllowance(i).strBalance + objExportAllowance(i).strAllowanceSignificant
''                                Case 4
''                                    objExportAllowance(i).strAllowance = objExportAllowance(i).strBalance + objExportAllowance(i).strAllowanceMarket
''                                Case 5
''                                    objExportAllowance(i).strAllowance = objExportAllowance(i).strBalance + objExportAllowance(i).strAllowanceService
''                                Case Else
''                                    objExportAllowance(i).strAllowance = 0
''                            End Select
''                        End If
''                    Next
''                End If
''
''                'FormatNumber(CDbl(lstView.ListItems(X).ListSubItems(20).Text)
''                If lstView.ListItems.count > 0 Then
''                    For i = 1 To lstView.ListItems.count 'O2008.1
''                        If rst.Fields(3) = lstView.ListItems(i).Text Then
''                            'NGOHCS CA2008
''                            If CDbl(rst!OB_RA) - CDbl(ListViewRA.ListItems(i).ListSubItems(7).Text) > 0 Then
''                                lstView.ListItems(i).ListSubItems(21).Text = FormatNumber(CDbl(rst!OB_RA) - CDbl(ListViewRA.ListItems(i).ListSubItems(7).Text), 0) 'RA Balance b/f
''                            Else
''                                lstView.ListItems(i).ListSubItems(21).Text = "0"
''                            End If
''                            If CDbl(rst!OB_INVESTMENT) - CDbl(ListViewITA.ListItems(i).ListSubItems(7).Text) > 0 Then
''                                lstView.ListItems(i).ListSubItems(28).Text = FormatNumber(CDbl(rst!OB_INVESTMENT) - CDbl(ListViewITA.ListItems(i).ListSubItems(7).Text), 0) 'ITA Balance b/f
''                            Else
''                                lstView.ListItems(i).ListSubItems(28).Text = "0"
''                            End If
''
''                            'LeeCC 2012.1 Export Allowance
''                            If CDbl(rst!OB_EXPORT) - CDbl(ListViewITA.ListItems(i).ListSubItems(7).Text) > 0 Then
''                                lstView.ListItems(i).ListSubItems(28).Text = FormatNumber(CDbl(rst!OB_INVESTMENT) - CDbl(ListViewITA.ListItems(i).ListSubItems(7).Text), 0) 'ITA Balance b/f
''                            Else
''                                lstView.ListItems(i).ListSubItems(28).Text = "0"
''                            End If
''                            'simkh 2012.1
' ''                            If CDbl(rst!OB_EXPORT) > 0 Then
' ''                                lstView.ListItems(i).ListSubItems(39).Text = FormatNumber(CDbl(rst!OB_EXPORT), 0)
' ''                            Else
' ''                                lstView.ListItems(i).ListSubItems(39).Text = "0"
' ''                            End If
' ''
''                            lstView.ListItems(i).ListSubItems(22).Text = FormatNumber(CDbl(lstView.ListItems(i).ListSubItems(21).Text) + CDbl(lstView.ListItems(i).ListSubItems(20)), 0)
''                            lstView.ListItems(i).ListSubItems(29).Text = FormatNumber(CDbl(lstView.ListItems(i).ListSubItems(28).Text) + CDbl(lstView.ListItems(i).ListSubItems(27)), 0)
''
''                            'simkh 2012.1
' ''                           lstView.ListItems(i).ListSubItems(40).Text = FormatNumber(CDbl(lstView.ListItems(i).ListSubItems(39).Text) + CDbl(lstView.ListItems(i).ListSubItems(34)) Or CDbl(lstView.ListItems(i).ListSubItems(45)) Or CDbl(lstView.ListItems(i).ListSubItems(46)) Or CDbl(lstView.ListItems(i).ListSubItems(47)) Or CDbl(lstView.ListItems(48)), 0)
''
''                        End If
''                            'NGOHCS CA2008 END
''                    Next
''                End If
''
''                'NGOHCS CA2008
''                If ListViewRA.ListItems.count > 0 Then 'O2008.1
''                    For i = 1 To ListViewRA.ListItems.count
''                        If rst.Fields(3) = ListViewRA.ListItems(i).Text Then
''                            ListViewRA.ListItems(i).ListSubItems(2).Text = FormatNumber(CDbl(rst!OB_RA), 0) 'Balance b/f
''                            ListViewRA.ListItems(i).ListSubItems(4).Text = FormatNumber(CDbl(ListViewRA.ListItems(i).ListSubItems(2).Text) + CDbl(ListViewRA.ListItems(i).ListSubItems(3).Text) - CDbl(ListViewRA.ListItems(i).ListSubItems(7).Text), 0)
''                            ListViewRA.ListItems(i).ListSubItems(6).Text = FormatNumber(CDbl(ListViewRA.ListItems(i).ListSubItems(4).Text) - CDbl(ListViewRA.ListItems(i).ListSubItems(5).Text) - CDbl(ListViewRA.ListItems(i).ListSubItems(8).Text), 0)
''                            If ListViewRA.ListItems(i).ListSubItems(6).Text < 0 Then
''                                ListViewRA.ListItems(i).ListSubItems(6).Text = 0
''                            End If
''                            If ListViewRA.ListItems(i).ListSubItems(4).Text < 0 Then
''                                ListViewRA.ListItems(i).ListSubItems(4).Text = 0
''                            End If
''                        End If
''                    Next
''                End If
''                 'NGOHCS CA2008 END
''
''                 'NGOHCS CA2008
''                 If ListViewITA.ListItems.count > 0 Then
''                    For i = 1 To ListViewITA.ListItems.count
''                        If rst.Fields(3) = ListViewITA.ListItems(i).Text Then
''                            ListViewITA.ListItems(i).ListSubItems(2).Text = FormatNumber(CDbl(rst!OB_INVESTMENT), 0) 'Balance b/f
''                            ListViewITA.ListItems(i).ListSubItems(4).Text = FormatNumber(CDbl(ListViewITA.ListItems(i).ListSubItems(2).Text) + CDbl(ListViewITA.ListItems(i).ListSubItems(3).Text) - CDbl(ListViewITA.ListItems(i).ListSubItems(7).Text), 0)
''                            ListViewITA.ListItems(i).ListSubItems(6).Text = FormatNumber(CDbl(ListViewITA.ListItems(i).ListSubItems(4).Text) - CDbl(ListViewITA.ListItems(i).ListSubItems(5).Text) - CDbl(ListViewITA.ListItems(i).ListSubItems(8).Text), 0)
''                            If ListViewITA.ListItems(i).ListSubItems(6).Text < 0 Then
''                               ListViewITA.ListItems(i).ListSubItems(6).Text = 0
''                            End If
''                            If ListViewITA.ListItems(i).ListSubItems(4).Text < 0 Then
''                               ListViewITA.ListItems(i).ListSubItems(4).Text = 0
''                            End If
''                        End If
''                    Next
''                 End If
''                 'NGOHCS CA2008 END
''
''
''                'simkh 2012.1
' ''                 If ListViewEA.ListItems.count > 0 Then
' ''                    For i = 1 To ListViewEA.ListItems.count
' ''                        If rst.Fields(3) = ListViewEA.ListItems(i).Text Then
' ''                            ListViewEA.ListItems(i).ListSubItems(2).Text = FormatNumber(CDbl(rst!OB_EXPORT), 0) 'Balance b/f
' ''                            ListViewEA.ListItems(i).ListSubItems(4).Text = FormatNumber(CDbl(ListViewEA.ListItems(i).ListSubItems(2).Text) + CDbl(ListViewEA.ListItems(i).ListSubItems(3).Text), 0)
' ''                            ListViewEA.ListItems(i).ListSubItems(6).Text = FormatNumber(CDbl(ListViewEA.ListItems(i).ListSubItems(4).Text) - CDbl(ListViewEA.ListItems(i).ListSubItems(5).Text), 0)
' ''                            If ListViewEA.ListItems(i).ListSubItems(6).Text < 0 Then
' ''                               ListViewEA.ListItems(i).ListSubItems(6).Text = 0
' ''                            End If
' ''                            If ListViewEA.ListItems(i).ListSubItems(4).Text < 0 Then
' ''                               ListViewEA.ListItems(i).ListSubItems(4).Text = 0
' ''                            End If
' ''                        End If
' ''                    Next
' ''                 End If
''
''                '==Oscar2009.1==' Business Loss: Balance b/f S60FA
''                If intS60FA = "Y" Then
''                    ULBalance = "0"
''                Else
''                    ULBalance = CDbl(ULBalance) + CDbl(rst.Fields(1))
''                End If
''                '==End Oscar2009.1=='
''
''                ITABalance = CDbl(ITABalance) + CDbl(rst.Fields(2))
''                RABalance = CDbl(RABalance) + CDbl(rst.Fields(4))
''                SABalance = CDbl(SABalance) + CDbl(rst!OB_SRNAMT)
''
''                txtULBalbf = FormatNumber(CDbl(ULBalance), 0)
''                txtITABalbf = FormatNumber(CDbl(ITABalance), 0)
''                txtRABalbf = FormatNumber(CDbl(RABalance), 0)
''                txtBlnBf = FormatNumber(CDbl(SABalance), 0) 'Pin Taxcom C+ v2005.4 SP2
''
''                If lstViewEA.ListItems.count > 0 Then
''                    Dim n As Integer
''                    For n = 0 To UBound(objExportAllowance)
''                        objExportAllowance(n).strBalance = rst!OB_EXPORT
''
''                    Next
''                End If
''
''                rst.MoveNext
''            Loop
''        End If
''        rst.Close
        
'        'NGOHCS CA2008
'        If txtULBalbf - txtULUtilised <= 0 Then
'            txtULBalUtil = "0"
'        End If
'        'NGOHCS CA2008 END
        
'        '------------
'        'Get AA & IA
'        '------------
'         lstViewDT.ListItems.Clear

'        sourcenum = ""
'        pre_sourcenum = ""
'        cSQL = "SELECT * FROM [CA_OPENING] WHERE [CA_OPN_REF_NO]='" & Trim(cRefNo) & "' AND cast([CA_OPN_YA] as money)<='" & CDbl(Trim(cYA)) & "' ORDER BY [CA_OPN_SOURCENO]"
'        Set rst = DB.Execute(cSQL)
 
'        If Not rst.EOF Then
'            Do While Not rst.EOF
'                If sourcenum = "" Then
'                    sourcenum = rst!CA_OPN_SOURCENO
'                Else
'                    If Not pre_sourcenum = rst!CA_OPN_SOURCENO Then
'                        sourcenum = sourcenum & "," & rst!CA_OPN_SOURCENO
'                    End If
'                End If
'                pre_sourcenum = rst!CA_OPN_SOURCENO
'                rst.MoveNext
'            Loop
'        End If
'        rst.Close

'        key_array = Split(sourcenum, ",")
'        For i = 0 To UBound(key_array)
'            pre_UCA_AA = 0
            
'            'CA OPENING
'            cSQL = "SELECT * FROM [CA_OPENING] WHERE [CA_OPN_REF_NO]='" & Trim(cRefNo) & "' AND cast([CA_OPN_YA] as money)<='" & CDbl(Trim(cYA)) & "' AND [CA_OPN_SOURCENO]=" & Val(key_array(i)) & " AND [CA_OPN_CURR_YEAR] <> null AND NOT cast([CA_OPN_QC_BAL] as money)=0 ORDER BY [CA_OPN_SOURCENO],[CA_OPN_RATE],[CA_OPN_YA]"
'            Set rst = DB.Execute(cSQL)
         
'            If Not rst.EOF Then
                
'                Do While Not rst.EOF
'                    'Debug.Print rst.Fields(0)
'                    current_year = rst!CA_OPN_CURR_YEAR
                    
'                    qc_bal_cf = CDbl(rst!CA_OPN_QC_BAL)
'                    'MsgBox "Opening=" & CDbl(qc_bal_cf)
                    
'                    twdv_balance = 0
'                    UCA_AA = 0
                    
'                    cSQL2 = "SELECT * FROM [CA_TWDV_BALANCE] WHERE [CA_OPN_KEY]=" & rst!CA_OPN_KEY
'                    Set rst1 = DB.Execute(cSQL2)
                 
'                    If Not rst1.EOF Then
'                        twdv_balance = CDbl(rst1!CA_TWDV_BAL)
'                    End If
'                    rst1.Close
                    
'                    For iYear = CDbl(current_year) To CDbl(cYA)
'                        twdv_disposal = 0
                        
'                        cSQL2 = "SELECT * FROM [CA_DISPOSAL] WHERE [CA_OPN_ADD_KEY]=" & rst!CA_OPN_KEY & " AND [CA_DISP_YA]='" & Trim(iYear) & "' AND [CA_DISP_BYA]='" & Trim(rst!CA_OPN_YA) & "' AND [CA_OPN_ADD_TBL]='OPN'"
'                        Set rst1 = DB.Execute(cSQL2)
                       
'                        If Not rst1.EOF Then
'                            Do While Not rst1.EOF
'                                qc_bal_cf = CDbl(qc_bal_cf) - CDbl(rst1!CA_DISP_QC)
'                                'If CDbl(rst1!CA_DISP_TWDV) > 0 Then
'                                   ' Debug.Print rst.Fields(0) & " : " & CDbl(rst1!CA_DISP_TWDV)
'                                'End If
'                                twdv_disposal = CDbl(twdv_disposal) + CDbl(rst1!CA_DISP_TWDV)
'                                rst1.MoveNext
'                            Loop
'                        End If
'                        rst1.Close
'                        'MsgBox "Closing=" & CDbl(qc_bal_cf)
'                        'NGOHCS 2009
'                        UCA_AA = FormatNumber((CDbl(qc_bal_cf) * (CDbl(rst!CA_OPN_RATE) / 100)), 2)
'                        If CDbl(UCA_AA) > CDbl(twdv_balance) - CDbl(twdv_disposal) Then
'                            UCA_AA = CDbl(twdv_balance) - CDbl(twdv_disposal)
'                        End If
'                        'MsgBox "UCA_AA=" & CDbl(UCA_AA)
'                        'Debug.Print iYear & " - " & rst!CA_OPN_RATE & " | " & rst.Fields(8) & "  Opening : " & qc_bal_cf & "  AA : " & UCA_AA
                        
'                        If iYear = CDbl(cYA) Then
'                            pre_UCA_AA = CDbl(pre_UCA_AA) + CDbl(UCA_AA)
'                        End If
'                        twdv_balance = CDbl(twdv_balance) - CDbl(twdv_disposal) - CDbl(UCA_AA)
'                    Next
''*** Irisa records save for Deffered Tax
'                  Set xitem_CA = lstViewDT.ListItems.Add(, , "OPN")
'                  xitem_CA.ListSubItems.Add , , rst!CA_OPN_KEY
'                  ' xitem_CA.ListSubItems.Add , , rst!CA_OPN_COMPANY
'                  xitem_CA.ListSubItems.Add , , rst!CA_OPN_SOURCENO
'                  xitem_CA.ListSubItems.Add , , Category_Desc(rst!CA_OPN_CATEGORY_CODE)
'                  xitem_CA.ListSubItems.Add , , rst!CA_OPN_DESC
'                  xitem_CA.ListSubItems.Add , , "0"
'                  xitem_CA.ListSubItems.Add , , rst!CA_OPN_RATE
'                  xitem_CA.ListSubItems.Add , , rst!CA_OPN_YA
'                  xitem_CA.ListSubItems.Add , , rst!CA_OPN_PURCHASE_COST
'                  xitem_CA.ListSubItems.Add , , rst!CA_OPN_QC_BAL
'                  xitem_CA.ListSubItems.Add , , disp_Pur
'                  xitem_CA.ListSubItems.Add , , disp_QC
'                  xitem_CA.ListSubItems.Add , , CDbl(rst!CA_OPN_PURCHASE_COST) - disp_Pur
'                  xitem_CA.ListSubItems.Add , , qc_bal_cf
'                  If CDbl(rst!CA_OPN_RATE) > 0 Then
'                     xitem_CA.ListSubItems.Add , , qc_bal_cf
'                     xitem_CA.ListSubItems.Add , , CDbl(rst!CA_OPN_PURCHASE_COST) - disp_Pur - qc_bal_cf
'                  Else
'                     xitem_CA.ListSubItems.Add , , 0
'                     xitem_CA.ListSubItems.Add , , CDbl(rst!CA_OPN_PURCHASE_COST) - disp_Pur
'                  End If
'                  xitem_CA.ListSubItems.Add , , twdv_balance
'                  xitem_CA.ListSubItems.Add , , "0"
'                  xitem_CA.ListSubItems.Add , , UCA_AA
'                  xitem_CA.ListSubItems.Add , , ""
'' *** Irisa End
'                    rst.MoveNext
'                Loop
            
'            End If
            
'            'CA ADDITION
        
'            cSQL = "SELECT * FROM [CA_ADDITION] WHERE [CA_ADD_REF_NO]='" & Trim(cRefNo) & "' AND cast([CA_ADD_YA] as money)<='" & CDbl(Trim(cYA)) & "' AND [CA_ADD_SOURCENO]=" & Val(key_array(i)) & " ORDER BY [CA_ADD_SOURCENO],[CA_ADD_RATE],[CA_ADD_YA]"
'            Set rst = DB.Execute(cSQL)
        
'            If Not rst.EOF Then

'                Do While Not rst.EOF
'                    current_year = rst!CA_ADD_YA
                    
'                    qc_bal_cf = CDbl(rst!CA_ADD_QC)
'                    'MsgBox "Opening=" & CDbl(qc_bal_cf)
                    
'                    twdv_addition = 0
'                    IA = 0
'                    UCA_AA = 0
'                    cSQL2 = "SELECT * FROM [CA_TWDV_ADDITION] WHERE [CA_ADD_KEY]=" & rst!CA_ADD_KEY
'                    Set rst1 = DB.Execute(cSQL2)
'                    If Not rst1.EOF Then
'                        twdv_addition = CDbl(rst1!CA_TWDV_ADD)
'                    End If
'                    rst1.Close
'                    cSQL2 = "SELECT * FROM [CA_TWDV_IA] WHERE [CA_ADD_KEY]=" & rst!CA_ADD_KEY
'                    Set rst1 = DB.Execute(cSQL2)
'                    If Not rst1.EOF Then
'                        IA = CDbl(rst1!CA_TWDV_IA)
'                    End If
'                    rst1.Close
'                    For iYear = CDbl(current_year) To CDbl(cYA)
'                        twdv_disposal = 0
                        
'                        cSQL2 = "SELECT * FROM [CA_DISPOSAL] WHERE [CA_OPN_ADD_KEY]=" & rst!CA_ADD_KEY & " AND [CA_DISP_YA]='" & Trim(iYear) & "' AND [CA_DISP_BYA]='" & Trim(rst!CA_ADD_YA) & "' AND [CA_OPN_ADD_TBL]='ADD'"
'                        Set rst1 = DB.Execute(cSQL2)
'                        If Not rst1.EOF Then
'                            Do While Not rst1.EOF
'                                qc_bal_cf = CDbl(qc_bal_cf) - CDbl(rst1!CA_DISP_QC)
'                                twdv_disposal = CDbl(twdv_disposal) + CDbl(rst1!CA_DISP_TWDV)
'                                rst1.MoveNext
'                            Loop
'                        End If
'                        rst1.Close
'                        'MsgBox "Closing=" & CDbl(qc_bal_cf)
'                        'NGOHCS 2009
'                        UCA_AA = FormatNumber((CDbl(qc_bal_cf) * (CDbl(rst!CA_ADD_RATE) / 100)), 2)
'                        If CDbl(UCA_AA) > CDbl(twdv_addition) - CDbl(twdv_disposal) - CDbl(IA) Then
'                            UCA_AA = CDbl(twdv_addition) - CDbl(twdv_disposal) - CDbl(IA)
'                        End If
'                        'MsgBox "AA=" & CDbl(UCA_AA)
                        
'                        If iYear = CDbl(cYA) Then
'                            pre_UCA_AA = CDbl(pre_UCA_AA) + CDbl(UCA_AA)
'                        End If
                        
'                        twdv_addition = CDbl(twdv_addition) - CDbl(twdv_disposal) - CDbl(IA) - CDbl(UCA_AA)
'                        IA = 0
'                    Next
'                    '*** Irisa records save for Deffered Tax
'                  Set xitem_CA = lstViewDT.ListItems.Add(, , "ADD")
'                  xitem_CA.ListSubItems.Add , , rst!CA_ADD_KEY
'                  'xitem_CA.ListSubItems.Add , , rst!CA_ADD_COMPANY
'                  xitem_CA.ListSubItems.Add , , rst!CA_ADD_SOURCENO
'                  xitem_CA.ListSubItems.Add , , Category_Desc(rst!CA_ADD_CATEGORY_CODE)
'                  xitem_CA.ListSubItems.Add , , rst!CA_ADD_ASSET
'                  xitem_CA.ListSubItems.Add , , rst!CA_ADD_IA_RATE
'                  xitem_CA.ListSubItems.Add , , rst!CA_ADD_RATE
'                  xitem_CA.ListSubItems.Add , , rst!CA_ADD_YA
'                  xitem_CA.ListSubItems.Add , , rst!CA_ADD_AMOUNT
'                  xitem_CA.ListSubItems.Add , , rst!CA_ADD_QC
'                  xitem_CA.ListSubItems.Add , , disp_Pur
'                  xitem_CA.ListSubItems.Add , , disp_QC
'                  xitem_CA.ListSubItems.Add , , CDbl(rst!CA_ADD_AMOUNT) - disp_Pur
'                  xitem_CA.ListSubItems.Add , , qc_bal_cf
'                  If CDbl(rst!CA_ADD_RATE) > 0 Then
'                     xitem_CA.ListSubItems.Add , , qc_bal_cf
'                     xitem_CA.ListSubItems.Add , , CDbl(rst!CA_ADD_AMOUNT) - disp_Pur - qc_bal_cf
'                  Else
'                     xitem_CA.ListSubItems.Add , , 0
'                     xitem_CA.ListSubItems.Add , , CDbl(rst!CA_ADD_AMOUNT) - disp_Pur
'                  End If
'                  xitem_CA.ListSubItems.Add , , twdv_addition
'                  xitem_CA.ListSubItems.Add , , temp_IA
'                  xitem_CA.ListSubItems.Add , , UCA_AA
'                  xitem_CA.ListSubItems.Add , , ""
''*** End Irisa
'                    rst.MoveNext
'                Loop
'                End If
'                If lstViewCA.ListItems.count > 0 Then
'                    For X = 1 To lstViewCA.ListItems.count
'                        If Val(lstViewCA.ListItems(X).Text) = Val(key_array(i)) Then
'                            lstViewCA.ListItems(X).ListSubItems(3).Text = FormatNumber(CDbl(pre_UCA_AA), 0)
'                            Exit For
'                        End If
'                    Next
'                End If
'            Next
            
            
'        'NGOHCS CA2008 AA , IA
'            'Replacing AA , iA Rate and remain Old Codes
'            Dim dblAA As Double
'            Dim dblCurrIA As Double
'            Dim dblIA As Double
'            Dim dblTWDV As Double
'            Dim dblQC As Double
'            Dim dblQCDISP As Double
'            Dim dblTWDVDISP As Double
            
'            Dim dblAATotal As Double
'            Dim dblIATotal As Double
'            Dim boolAccelerated As Boolean 'weihong
'            Dim dblAAAccelerated As Double 'weihong
'            Dim dblIAAccelerated As Double 'weihong
            
'            sourcenum = ""
'            pre_sourcenum = ""


'            cSQL = "SELECT CA_SOURCENO FROM [CA] WHERE [CA_REF_NO]='" & Trim(cRefNo) & "' AND cast([CA_YA] as money) <='" & CDbl(Trim(cYA)) & "' ORDER BY [CA_SOURCENO]"
'            Set rst = DB_CA.Execute(cSQL)
'            If Not rst.EOF Then
'                Do While Not rst.EOF
'                    If sourcenum = "" Then
'                        sourcenum = rst!CA_SOURCENO
'                    Else
'                        If Not pre_sourcenum = rst!CA_SOURCENO Then
'                            sourcenum = sourcenum & "," & rst!CA_SOURCENO
'                        End If
'                    End If
'                    pre_sourcenum = rst!CA_SOURCENO
'                    rst.MoveNext
'                Loop
'            End If
'            rst.Close
'            key_array = Split(sourcenum, ",")
'            If UBound(key_array) >= 0 Then
'                For i = 0 To UBound(key_array)
'                    Dim rst2 As New ADODB.Recordset
'                    Dim rst4 As New ADODB.Recordset
'                    Dim J As Integer
'                    J = 0
'                    dblTWDV = 0
'                    dblQC = 0
'                    dblIATotal = 0
'                    dblAATotal = 0
'                    boolAccelerated = False 'weihong
'                    dblAAAccelerated = 0 'weihong
'                    dblIAAccelerated = 0 'weihong
                    
'                    Dim g As Integer
                    
'                    cSQL = "SELECT * FROM [CA] WHERE [CA_REF_NO]='" & Trim(cRefNo) & "' AND cast([CA_YA] as money) <='" & CDbl(Trim(cYA)) & "' AND ([CA_SOURCENO]) = " & Val(key_array(i)) & " ORDER BY [CA_SOURCENO]"
'                    Set rst = DB_CA.Execute(cSQL)
'                    If Not rst.EOF Then
'                        Do While Not rst.EOF
'                            dblQCDISP = 0
'                            dblTWDVDISP = 0
'                            dblIA = 0
'                            dblCurrIA = 0
'                            dblAA = 0
'                            dblQC = CDbl(rst!CA_QUALIFYING_COST)
'                            dblTWDV = CDbl(rst!CA_TWDV)
'                            'weihong
'                            If rst!CA_ACCELERATED = True Then
'                                boolAccelerated = True
'                            Else
'                                boolAccelerated = False
'                            End If
'                            'endweihong
                            
'                            cSQL = "SELECT COUNT([CA_KEY]) as [NumRecord], SUM(cast([CA_DISP_QC] as money)) as [CA_IA_TOTAL] from CA_DISPOSAL where CA_DISP_YA = '" & Val(rst!CA_PURCHASE_YEAR) & "' and CA_KEY = " & Val(rst!CA_KEY)
'                            Set rst4 = DB_CA.Execute(cSQL)
'                            If Val(rst!CA_PURCHASE_YEAR) = Val(cYA) Then
'                                'Calculate IA
''                                cSQL = "SELECT COUNT([CA_KEY]) as [NumRecord], SUM([CA_DISP_QC]) as [CA_IA_TOTAL] from CA_DISPOSAL where CA_DISP_YA = '" & Val(rst!CA_PURCHASE_YEAR) & "' and CA_KEY = " & Val(rst!CA_KEY)
''                                Set rst2 = DB_CA.Execute(cSQL)
'                                If Not rst4.EOF Then
'                                    If (rst4![NumRecord]) > 0 Then
'                                        dblIA = (CDbl(rst!CA_RATE_IA) / 100) * (CDbl(rst!CA_QUALIFYING_COST) - CDbl(rst4!CA_IA_TOTAL))
'                                    Else
'                                        dblIA = (CDbl(rst!CA_RATE_IA) / 100 * CDbl(rst!CA_QUALIFYING_COST))
'                                    End If
'                                Else
'                                    dblIA = (CDbl(rst!CA_RATE_IA) / 100 * CDbl(rst!QUALIFIYING_COST))
'                                End If
'                                'NGOHCS B2010.2
'                                dblIA = CDbl(FormatNumber(dblIA, 2))
'                            Else
'                                'Calculate TWDV for the previous YE
'                                 If Not rst4.EOF Then
'                                    If (rst4![NumRecord]) > 0 Then
'                                        dblCurrIA = (CDbl(rst!CA_RATE_IA) / 100) * (CDbl(rst!CA_QUALIFYING_COST) - CDbl(rst4!CA_IA_TOTAL))
'                                    Else
'                                        dblCurrIA = (CDbl(rst!CA_RATE_IA) / 100 * CDbl(rst!CA_QUALIFYING_COST))
'                                    End If
'                                Else
'                                    dblCurrIA = (CDbl(rst!CA_RATE_IA) / 100 * CDbl(rst!QUALIFIYING_COST))
'                                End If
'                                dblTWDV = dblTWDV - CDbl(FormatNumber(dblCurrIA, 2))
'                                For J = CInt(rst!CA_YA) To (Val(cYA) - 1)
'                                    cSQL = "SELECT COUNT(CA_KEY), SUM(cast(CA_DISP_QC as money)), SUM(cast(CA_DISP_TWDV as money)) FROM [CA_DISPOSAL] WHERE CA_DISP_YA='" & J & "' AND CA_KEY =" & Val(rst!CA_KEY)
'                                    Set rst2 = DB_CA.Execute(cSQL)
'                                    If Not rst2.EOF Then
'                                        If Not IsNull(rst2.Fields(1)) Then
'                                            dblQC = dblQC - CDbl(rst2.Fields(1))
'                                        End If
'                                        If Not IsNull(rst2.Fields(2)) Then
'                                            dblTWDV = dblTWDV - CDbl(rst2.Fields(2))
'                                        End If
'                                    End If
'                                    dblTWDV = FormatNumber(dblTWDV - (dblQC * (CDbl(rst!CA_RATE_AA) / 100)), 2)
'                                    rst2.Close
'                                Next
'                                If dblTWDV < 0 Then dblTWDV = 0
'                            End If
                               
'                            'Calculate TWDV for the particular YE
'                            cSQL = "SELECT COUNT(CA_KEY), SUM(cast(CA_DISP_QC as money)), SUM(cast(CA_DISP_TWDV as money)) FROM [CA_DISPOSAL] WHERE CA_DISP_YA='" & Val(cYA) & "' AND CA_KEY =" & Val(rst!CA_KEY)
'                            Set rst2 = DB_CA.Execute(cSQL)
'                            If Not rst2.EOF Then
'                                If Not IsNull(rst2.Fields(1)) Then
'                                    dblQCDISP = CDbl(rst2.Fields(1))
'                                End If
'                                If Not IsNull(rst2.Fields(2)) Then
'                                    dblTWDVDISP = CDbl(rst2.Fields(2))
'                                End If
'                            End If
'                            rst2.Close
'                            'azham 18-04-2017
'                            'Calculate AA
'                            dblAA = FormatNumber(((dblQC - dblQCDISP) * (CDbl(rst!CA_RATE_AA) / 100)), 3)
                            
'                            If dblAA > (dblTWDV - dblTWDVDISP) Then
'                                dblAA = dblTWDV - dblTWDVDISP
'                               ' MsgBox ("TO : " + CStr(dblAA))
'                            End If
'                            If dblQC - dblQCDISP <= 0 Then dblIA = 0
                            
'                            'Total IA , AA
'                            If dblQC > 0 Then
'                                dblIATotal = dblIATotal + dblIA
'                                dblAATotal = dblAATotal + dblAA
                                
'                            End If
                            
'                            'weihong AcceleratedCA
'                            If boolAccelerated = True Then
'                                dblAAAccelerated = dblAA + dblAAAccelerated
'                                dblIAAccelerated = dblIA + dblIAAccelerated
'                            End If
'                            'endweihong
                            
'                            rst.MoveNext
'                        Loop
'                    End If
'                    rst.Close
            
'                    If lstViewCA.ListItems.count > 0 Then
'                       For X = 1 To lstViewCA.ListItems.count
'                           If Val(lstViewCA.ListItems(X).Text) = Val(key_array(i)) Then
'                              If dblAATotal > 0 Then
'                                lstViewCA.ListItems(X).ListSubItems(3).Text = FormatNumber(dblAATotal, 0)
'                              Else
'                                lstViewCA.ListItems(X).ListSubItems(3).Text = "0"
'                              End If
'                              If dblIATotal > 0 Then
'                                lstViewCA.ListItems(X).ListSubItems(4).Text = FormatNumber(dblIATotal, 0)
'                              Else
'                                lstViewCA.ListItems(X).ListSubItems(4).Text = "0"
'                              End If
'                              lstViewCA.ListItems(X).ListSubItems(14).Text = FormatNumber(dblIAAccelerated + dblAAAccelerated, 0) 'weihong AcceleratedCA
'                              Exit For
'                           End If
'                       Next
'                    End If
'                Next
'            Else
'                dblIATotal = 0
'                dblAATotal = 0
'                If lstViewCA.ListItems.count > 0 Then
'                   For X = 1 To lstViewCA.ListItems.count
'                       'If Val(lstViewCA.ListItems(X).Text) = Val(key_array(I)) Then
'                          lstViewCA.ListItems(X).ListSubItems(3).Text = FormatNumber(dblAATotal, 0)
'                          lstViewCA.ListItems(X).ListSubItems(4).Text = FormatNumber(dblIATotal, 0)
'                          lstViewCA.ListItems(X).ListSubItems(14).Text = FormatNumber(dblIAAccelerated + dblAAAccelerated, 0) 'weihong
'                          'Exit For
'                       'End If
'                   Next
'                End If
'            End If
'        'NGOHCS CA2008 END
'        sourcenum = ""
'        pre_sourcenum = ""
'        cSQL = "SELECT * FROM [CA_TWDV_IA] WHERE [CA_TWDV_IA_REF_NO]='" & Trim(cRefNo) & "' AND [CA_TWDV_IA_YA]<='" & CDbl(Trim(cYA)) & "' ORDER BY [CA_TWDV_IA_SOURCENO]"
'        Set rst = DB.Execute(cSQL)
'        If Not rst.EOF Then
'            Do While Not rst.EOF
'                If sourcenum = "" Then
'                    sourcenum = rst!CA_TWDV_IA_SOURCENO
'                Else
'                    If Not pre_sourcenum = rst!CA_TWDV_IA_SOURCENO Then
'                        sourcenum = sourcenum & "," & rst!CA_TWDV_IA_SOURCENO
'                    End If
'                End If
'                pre_sourcenum = rst!CA_TWDV_IA_SOURCENO
'                rst.MoveNext
'            Loop
'        End If
'        rst.Close

'        key_array = Split(sourcenum, ",")
'        For i = 0 To UBound(key_array)
'            UCA_IA = 0
            
'            cSQL = "SELECT * FROM [CA_TWDV_IA] WHERE [CA_TWDV_IA_REF_NO]='" & Trim(cRefNo) & "' AND cast([CA_TWDV_IA_YA] as money)='" & CDbl(Trim(cYA)) & "' AND [CA_TWDV_IA_SOURCENO]=" & Val(key_array(i)) & " ORDER BY [CA_TWDV_IA_SOURCENO],[CA_TWDV_IA_YA],[CA_TWDV_IA_RATE]"
'            Set rst = DB.Execute(cSQL)
'            If Not rst.EOF Then
'                Do While Not rst.EOF
'                    UCA_IA = CDbl(UCA_IA) + CDbl(rst!CA_TWDV_IA)
'                    rst.MoveNext
'                Loop
'            End If
'            rst.Close
            
            
'            'NGOHCS CA2008 Comment Old Code
''            If lstViewCA.ListItems.count > 0 Then
''                For X = 1 To lstViewCA.ListItems.count
''                    If Val(lstViewCA.ListItems(X).Text) = Val(key_array(I)) Then
''                        lstViewCA.ListItems(X).ListSubItems(4).Text = FormatNumber(CDbl(UCA_IA), 0)
''                        Exit For
''                    End If
''                Next
''            End If
'        Next
        
'        '-----------------------------------
'        'Get Balancing Allowances / Charges
'        '-----------------------------------
'        'NGOHCS CA2008
'        If IncomeCal_Flag = True Then
'            sourcenum = ""
'            pre_sourcenum = ""
'            UCABal_Allow = 0
'            UCABal_Charge = 0
            
'            cSQL = "SELECT * FROM [CA] c INNER JOIN [CA_DISPOSAL] d ON c.CA_KEY = d.CA_KEY WHERE c.[CA_REF_NO]='" & Trim(cRefNo) & "' AND d.[CA_DISP_YA] = '" & Trim(cYA) & "' ORDER BY [CA_SOURCENO]"
'            'cSQL = "SELECT * FROM [CA] WHERE [CA_REF_NO]='" & Trim(cRefNo) & "' AND [CA_YA]='" & Trim(cYA) & "' ORDER BY [CA_SOURCENO]"
'            'cSQL = "SELECT * FROM [CA_DISPOSAL] WHERE [CA_DISP_REF_NO]='" & Trim(crefno) & "' AND [CA_DISP_YA]='" & Trim(cya) & "' ORDER BY [CA_DISP_SOURCENO]"
'            'Set rst = DB.Execute(cSQL)
'            Set rst = DB_CA.Execute(cSQL)
'            If Not rst.EOF Then
'                Do While Not rst.EOF
'                    If sourcenum = "" Then
'                        'sourcenum = rst!CA_DISP_SOURCENO
'                        sourcenum = rst!CA_SOURCENO
'                    Else
''                        If Not pre_sourcenum = rst!CA_DISP_SOURCENO Then
''                            sourcenum = sourcenum & "," & rst!CA_DISP_SOURCENO
''                        End If
'                        If Not pre_sourcenum = rst!CA_SOURCENO Then
'                            sourcenum = sourcenum & "," & rst!CA_SOURCENO
'                        End If
'                    End If
'                    'pre_sourcenum = rst!CA_DISP_SOURCENO
'                    pre_sourcenum = rst!CA_SOURCENO
'                    rst.MoveNext
'                Loop
'            Else
'                If lstViewCA.ListItems.count > 0 Then
'                    For X = 1 To lstViewCA.ListItems.count
'                        lstViewCA.ListItems(X).ListSubItems(7).Text = FormatNumber(Abs(CDbl(UCABal_Allow)), 0)
'                    Next
'                End If
                
'                ' === csNgoh Julai 2008 === '
'                If lstView.ListItems.count > 0 Then
'                    For X = 1 To lstView.ListItems.count
'                        lstView.ListItems(X).ListSubItems(7).Text = FormatNumber(Abs(CDbl(UCABal_Charge)), 0)
'                    Next
'                End If
'                'If lstViewCA.ListItems.count > 0 Then
'                '    For X = 1 To lstViewCA.ListItems.count
'                '        lstViewCA.ListItems(X).ListSubItems(14).Text = FormatNumber(Abs(CDbl(UCABal_Charge)), 0)
'                '    Next
'                'End If
'                'Call TransferBlnCharge(X)
'                ' === end csNgoh Julai 2008 === '
               
'            End If
'            rst.Close
'            key_array = Split(sourcenum, ",")
'            For i = 0 To UBound(key_array)
'                UCABal_Allow = 0
'                UCABal_Charge = 0
                
'                'cSQL = "SELECT * FROM [CA_DISPOSAL] WHERE [CA_DISP_REF_NO]='" & Trim(crefno) & "' AND [CA_DISP_YA]='" & Trim(cya) & "' AND [CA_DISP_SOURCENO]=" & Val(key_array(I)) & " ORDER BY [CA_DISP_SOURCENO]"
'                'cSQL = "SELECT * FROM [CA_DISPOSAL] AS [D] WHERE D.CA_KEY IN (SELECT [CA_KEY] FROM CA WHERE [CA_REF_NO]='" & Trim(cRefNo) & "' AND [CA_SOURCENO] = " & Val(key_array(I)) & ") AND [CA_DISP_YA]= '" & Trim(cYA) & "' ORDER BY [CA_DISP_KEY]"
'                cSQL = "SELECT * FROM [CA_DISPOSAL] AS [D] WHERE D.CA_KEY IN (SELECT [CA_KEY] FROM CA WHERE [CA_REF_NO]='" & Trim(cRefNo) & "' AND [CA_SOURCENO] = " & Val(key_array(i)) & " AND [HP_CODE]='') AND [CA_DISP_YA]= '" & Trim(cYA) & "' ORDER BY [CA_DISP_KEY]"
                
'                Set rst = DB_CA.Execute(cSQL)
'                If Not rst.EOF Then
'                    Do While Not rst.EOF
'                        If CDbl(rst.Fields(10)) < 0 Then
'                            UCABal_Allow = CDbl(UCABal_Allow) + CDbl(rst.Fields(10))
'                            'UCABal_Allow = CDbl(UCABal_Allow) + CDbl(rst.Fields(9))
'                        Else
'                            UCABal_Charge = CDbl(UCABal_Charge) + CDbl(rst.Fields(10))
'                            'UCABal_Charge = CDbl(UCABal_Charge) + CDbl(rst.Fields(9))
'                        End If
'                        rst.MoveNext
'                    Loop
'                End If
'                rst.Close
                
'                'NGOHCS CA 2008
''                cSQL = "SELECT Sum(cast(a.BABC as money)),  a.HP_CODE" _
''                & " FROM (select ca_disposal.ca_disp_ya as YA, ca_disposal.ca_disp_babc as babc , ca.hp_code as hp_code from ca_disposal inner join ca on ca_disposal.ca_key = ca.ca_key where ca.ca_ref_no = '" & Trim(cRefNo) & "' and ca.ca_sourceno = " & Val(key_array(i)) & " )" _
''                & " WHERE HP_CODE IN (select distinct c.hp_code from ca c) AND HP_CODE <> '' AND YA = '" & Trim(cYA) & "'" _
''                & " GROUP BY HP_CODE"
'                cSQL = "select SUM(cast(ca_disposal.ca_disp_babc as money)) as babc, " _
'                & " ca.hp_code from CA_DISPOSAL inner join ca on ca_disposal.ca_key = ca.ca_key" _
'                & " where ca.ca_ref_no = '" & Trim(cRefNo) & "' and CA_DISPOSAL.CA_DISP_YA = '" & Trim(cYA) & "' and ca.HP_CODE <> '' and ca.ca_sourceno = " & Val(key_array(i)) & "" _
'                & "group by ca.hp_code"
'                Set rst = DB_CA.Execute(cSQL)
                
'                If Not rst.EOF Then
'                    Do While Not rst.EOF
'                        If CDbl(rst.Fields(0)) < 0 Then
'                            UCABal_Allow = CDbl(UCABal_Allow) + CDbl(rst.Fields(0))
'                            'UCABal_Allow = CDbl(UCABal_Allow) + CDbl(rst.Fields(9))
'                        Else
'                            UCABal_Charge = CDbl(UCABal_Charge) + CDbl(rst.Fields(0))
'                            'UCABal_Charge = CDbl(UCABal_Charge) + CDbl(rst.Fields(9))
'                        End If
'                        rst.MoveNext
'                    Loop
'                End If
'                rst.Close
'                'NGOHCS CA 2008 END
                
'                If lstViewCA.ListItems.count > 0 Then
'                    For X = 1 To lstViewCA.ListItems.count
'                        If Val(lstViewCA.ListItems(X).Text) = Val(key_array(i)) Then
'                            lstViewCA.ListItems(X).ListSubItems(7).Text = FormatNumber(Abs(CDbl(UCABal_Allow)), 0)
'                            Exit For
'                        End If
'                    Next
'                End If
                    
'                ' === csNgoh Julai 2008 === '
'                If lstView.ListItems.count > 0 Then
'                    For X = 1 To lstView.ListItems.count
'                        If Val(lstView.ListItems(X).Text) = Val(key_array(i)) Then
'                            lstView.ListItems(X).ListSubItems(7).Text = FormatNumber(Abs(CDbl(UCABal_Charge)), 0)
'                            Exit For
'                        End If
'                    Next
'                End If
'                'If lstViewCA.ListItems.count > 0 Then
'                '    For X = 1 To lstViewCA.ListItems.count
'                '        If Val(lstViewCA.ListItems(X).Text) = Val(key_array(I)) Then
'                '            lstViewCA.ListItems(X).ListSubItems(14).Text = FormatNumber(Abs(CDbl(UCABal_Charge)), 0)
'                '            Exit For
'                '        End If
'                '    Next
'                'End If
'                ' === end csNgoh Julai 2008 === '
                
'            Next
'        End If
'        'NGOHCS CA2008 END
'        '--------------------------------------------------------------
'        'Calculate Total of Adjusted Business Income & Balancing Charge
'        '--------------------------------------------------------------
'        If lstView.ListItems.count > 0 Then
'            For X = 1 To lstView.ListItems.count
'                lstView.ListItems(X).ListSubItems(8).Text = FormatNumber(CDbl(lstView.ListItems(X).ListSubItems(6).Text) + CDbl(lstView.ListItems(X).ListSubItems(7).Text), 0)
'            Next
'        End If

'        '----------------------------------------------
'        'Calculate UCA Year, UCA Utilised, Balance c/f
'        'Get CA for Statutory Income
'        '----------------------------------------------
'        If lstViewCA.ListItems.count > 0 Then
'            For X = 1 To lstViewCA.ListItems.count
'                If lstView.ListItems.count > 0 Then
'                    For z = 1 To lstView.ListItems.count
'                        If Val(lstView.ListItems(z).Text) = Val(lstViewCA.ListItems(X).Text) Then
'                            '(old)lstViewCA.ListItems(X).ListSubItems(6).Text = FormatNumber(CDbl(lstViewCA.ListItems(X).ListSubItems(3).Text) + CDbl(lstViewCA.ListItems(X).ListSubItems(4).Text) - CDbl(lstViewCA.ListItems(X).ListSubItems(5).Text), 0) 'UCA Year
                            
'                            'weihong AcceleratedCA
'                            lstViewCA.ListItems(X).ListSubItems(6).Text = FormatNumber(CDbl(lstViewCA.ListItems(X).ListSubItems(3).Text) + CDbl(lstViewCA.ListItems(X).ListSubItems(4).Text) - CDbl(lstViewCA.ListItems(X).ListSubItems(5).Text), 0)
'                            'lstViewCA.ListItems(X).ListSubItems(14).Text = FormatNumber((CDbl(lstViewCA.ListItems(X).ListSubItems(14).Text) - CDbl(lstViewCA.ListItems(X).ListSubItems(5).Text)), 0) 'LeeCC 2012 Rectify ACA will not minus NA
'                            'endweihong
                            
'                            ' === csNgoh Julai 2008 === '
'                            lstViewCA.ListItems(X).ListSubItems(8).Text = FormatNumber(CDbl(lstViewCA.ListItems(X).ListSubItems(2).Text) + CDbl(lstViewCA.ListItems(X).ListSubItems(6).Text) + CDbl(lstViewCA.ListItems(X).ListSubItems(7).Text), 0) 'Total
'                            'rmk csNgoh julai
'                            '    lstViewCA.ListItems(X).ListSubItems(8).Text = FormatNumber(CDbl(lstViewCA.ListItems(X).ListSubItems(2).Text) + CDbl(lstViewCA.ListItems(X).ListSubItems(6).Text) + CDbl(lstViewCA.ListItems(X).ListSubItems(7).Text) - CDbl(lstViewCA.ListItems(X).ListSubItems(14).Text), 0) 'Total
'                            '    If lstViewCA.ListItems(X).ListSubItems(8) <= 0 Then
'                            '        lstView.ListItems(z).ListSubItems(7).Text = Abs(Format(CDbl(lstViewCA.ListItems(X).ListSubItems(8).Text), 0))
'                            '    End If
'                            ' === end csNgoh Julai 2008 === '
'                            'NGOHCS CA 2008
'                            If CDbl(lstViewCA.ListItems(X).ListSubItems(8).Text) >= CDbl(lstView.ListItems(z).ListSubItems(8).Text) Then
'                                If CDbl(lstView.ListItems(X).ListSubItems(8).Text) > 0 Then
'                                    'If CDbl(lstView.ListItems(z).ListSubItems(8).Text) > CDbl(lstView.ListItems(z).ListSubItems(6).Text) Then
'                                    '    lstViewCA.ListItems(X).ListSubItems(9).Text = FormatNumber(CDbl(lstView.ListItems(z).ListSubItems(6).Text), 0) 'UCA Utilised
'                                    'Else
'                                        lstViewCA.ListItems(X).ListSubItems(9).Text = FormatNumber(CDbl(lstView.ListItems(z).ListSubItems(8).Text), 0) 'UCA Utilised
'                                    'End If
'                                Else
'                                    lstViewCA.ListItems(X).ListSubItems(9).Text = "0"
'                                End If
'                            ElseIf CDbl(lstViewCA.ListItems(X).ListSubItems(8).Text) < CDbl(lstView.ListItems(z).ListSubItems(8).Text) Then
'                                If CDbl(lstView.ListItems(X).ListSubItems(8).Text) > 0 Then
'                                    'If CDbl(lstView.ListItems(z).ListSubItems(8).Text) > CDbl(lstView.ListItems(z).ListSubItems(6).Text) Then
'                                    '    lstViewCA.ListItems(X).ListSubItems(9).Text = FormatNumber(CDbl(lstView.ListItems(z).ListSubItems(6).Text), 0) 'UCA Utilised
'                                    'Else
'                                        lstViewCA.ListItems(X).ListSubItems(9).Text = FormatNumber(CDbl(lstViewCA.ListItems(X).ListSubItems(8).Text), 0) 'UCA Utilised
'                                    'End If
'                                Else
'                                    lstViewCA.ListItems(X).ListSubItems(9).Text = "0"
'                                End If
'                            End If
'                            'NGOHCS CA 2008 END
'                            lstView.ListItems(z).ListSubItems(9).Text = FormatNumber(CDbl(lstViewCA.ListItems(X).ListSubItems(9).Text), 0) 'Capital Allowances for Statutory Income
'                            '*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-
'                            '==Oscar2009.1=='
'                            Dim rstS60FA3 As New ADODB.Recordset
'                            Dim strS60FA3 As String
'                            cSQL3 = "SELECT * FROM [PROFIT_LOSS_ACCOUNT] WHERE [PL_REF_NO] = '" & txtRefNo & "' AND [PL_YA] = '" & txtYA & "'"
'                            Set rstS60FA3 = DB.Execute(cSQL3)
'                            If Not rstS60FA3.EOF Then
'                                strS60FA3 = rstS60FA3!PL_S60FA
'                            End If
'                            rstS60FA3.Close
                            
'                            If strS60FA3 = "Y" Then
'                               lstViewCA.ListItems(X).ListSubItems(10).Text = "0"
'                               lstViewCA.ListItems(X).ListSubItems(11).Text = lstViewCA.ListItems(X).ListSubItems(10).Text
'                               lstViewCA.ListItems(X).ListSubItems(12).Text = "0"
'                            Else
'                                If (CDbl(lstViewCA.ListItems(X).ListSubItems(8).Text) - CDbl(lstViewCA.ListItems(X).ListSubItems(9).Text) < 0) Then
'                                    lstViewCA.ListItems(X).ListSubItems(10).Text = "0"
'                                Else
'                                    lstViewCA.ListItems(X).ListSubItems(10).Text = FormatNumber(CDbl(lstViewCA.ListItems(X).ListSubItems(8).Text) - CDbl(lstViewCA.ListItems(X).ListSubItems(9).Text), 0) 'Balance c/f
'                                End If
'                                If frmIncomeCalculationEdit.ChkMajorC = 1 Then
'                                    lstViewCA.ListItems(X).ListSubItems(11).Text = lstViewCA.ListItems(X).ListSubItems(10).Text  'DisAllowance CA
'                                Else
'                                    lstViewCA.ListItems(X).ListSubItems(11).Text = 0
'                                End If
'                                If (CDbl(lstViewCA.ListItems(X).ListSubItems(10).Text) - CDbl(lstViewCA.ListItems(X).ListSubItems(11).Text) > 0) Then
'                                    lstViewCA.ListItems(X).ListSubItems(12).Text = FormatNumber(CDbl(lstViewCA.ListItems(X).ListSubItems(10).Text) - CDbl(lstViewCA.ListItems(X).ListSubItems(11).Text), 0) 'Actual b/f
'                                Else
'                                    lstViewCA.ListItems(X).ListSubItems(12).Text = "0"
'                                End If
'                            End If
'                            Exit For
'                        End If
'                    Next
'                Else
'                    Exit For
'                End If
'            Next
'        End If
'        'Calculate Statutory Business Income & Net Statutory Income
'        'NGOHCS CA2008
'        If lstView.ListItems.count > 0 Then
'            For X = 1 To lstView.ListItems.count
'                lstView.ListItems(X).ListSubItems(10).Text = FormatNumber(CDbl(lstView.ListItems(X).ListSubItems(8).Text) - CDbl(lstView.ListItems(X).ListSubItems(9).Text), 0) 'Statutory Business Income
                             
'                'LeeCC 2012.1 export allowance
'                Dim dblEA As Double
'                Dim n As Integer
'                For n = 0 To UBound(objExportAllowance)
'                    If objExportAllowance(n).strBusiness = lstView.ListItems(X).Text Then
'                        dblEA = CDbl(objExportAllowance(n).strUtilised)
'                    End If
'                Next
'                lstView.ListItems(X).ListSubItems(13).Text = FormatNumber(CDbl(lstView.ListItems(X).ListSubItems(10).Text) - _
'                CDbl(lstView.ListItems(X).ListSubItems(11).Text) - CDbl(lstView.ListItems(X).ListSubItems(12).Text) - _
'                dblEA - CDbl(lstView.ListItems(X).ListSubItems(17).Text) + CDbl(lstView.ListItems(X).ListSubItems(32)), 0) 'Net Statutory Income
'                If lstView.ListItems(X).ListSubItems(13).Text < 0 Then
'                    lstView.ListItems(X).ListSubItems(13).Text = "0"
'                End If
'            Next
'        End If
'        'NGOHCS CA2008 END
'        'Get Total Statutory Income from all sources
'        totalstatutory = 0
'        If lstView.ListItems.count > 0 Then
'            For X = 1 To lstView.ListItems.count
'                totalstatutory = FormatNumber(CDbl(totalstatutory) + CDbl(lstView.ListItems(X).ListSubItems(13).Text), 0)
'            Next
'        End If
'        txtAllStatIn = FormatNumber(totalstatutory, 0)
        
'        '==Oscar2009.1==' S60FA
'        If intS60FA = "Y" Then
'            txtDisABL = FormatNumber(CDbl(txtULBalcf), 0)
'        End If
'        '==End Oscar2009.1=='
'        Call txtAggregateIn_Change
'        If CP204_Flag = True Then
'            instal_paid_amt = 0
        
'            cSQL = "SELECT * FROM [BORANG_CP204] WHERE [BCP_REF_NO]='" & cRefNo & "' AND [BCP_YA]='" & cYA & "'"
'            Set rst = DB.Execute(cSQL)
'            If Not rst.EOF Then
'                cSQL = "SELECT * FROM [BORANG_CP204_BREAKDOWN] WHERE [BCP_KEY]=" & rst!BCP_KEY & " AND [BCP_BD_PAY_DATE] is not null"
'                Set rst1 = DB.Execute(cSQL)
'                If Not rst1.EOF Then
'                    rst1.MoveFirst
'                    Do While Not rst1.EOF
'                        instal_paid_amt = instal_paid_amt + CDbl(rst1!BCP_BD_AMOUNT)
'                        rst1.MoveNext
'                    Loop
'                End If
'                rst1.Close
                
'                txtInstallments = FormatNumber(CDbl(instal_paid_amt), 2)
'            End If
'            rst.Close
'        End If
        
'    End If
'    'simkh 2012su2.1
'    cal_TotalPayable
'    If intMode = 0 Then
'        If frmIncomeCalculation.cmdEdit = True Then
'            IncomeCal_Flag1 = True
'            frmIncomeCalculationEdit.ToUpdate_IncomeCalc
'            IncomeCal_Flag1 = False
'        End If
'    End If
    
'    Exemption
'    'azham 03072017
'    If intMode = 1 Then
'        ToUpdate_IncomeCalc
'    End If

'End Sub
'Private Sub Exemption()
''azham 27042017
'     cSQL = "SELECT * FROM [TAX_COMPUTATION_EXEMPTION] WHERE [REF_NO] ='" & txtRefNo & "' AND [YA] = '" & txtYA & "'"
'     Set rst = DB.Execute(cSQL)

'    lvExemptionChargeable.ListItems.Clear
'    If Not rst.EOF Then
     
'            Set xItem = lvExemptionChargeable.ListItems.Add(1, , rst.Fields(0)) 'NO
'            'AGGREGATE_INCOME_A
'            'STATUTORY_BIZ_INCOME_A
'            'CHARGEABLE_INCOME_A
'            'STATUTORY_BIZ_INCOME_B
'            'AGGREGATE_INCOME_B
'            'CHARGEABLE_INCOME_B
'            'azham 31052017
'            Dim tmpYA As Integer
'            Dim tmpStrSQL As String
'            tmpYA = CDbl(txtYA) - 1
'            cSQL = "SELECT * FROM [TAX_COMPUTATION] WHERE [TC_REF_NO] ='" & txtRefNo & "' AND [TC_YA] = '" & CStr(tmpYA) & "'"
            
'            Set rst1 = DB.Execute(cSQL)
'            If Not rst1.EOF Then
'                With xItem
'                    .ListSubItems.Add 1, , rst.Fields(1) 'YA
'                    .ListSubItems.Add 2, , rst.Fields(2) 'REFNO
'                 .ListSubItems.Add 3, , FormatNumber(CDbl(txtAllStatIn), 2) 'STATUTORY_BIZ_INCOME_A
'                    .ListSubItems.Add 4, , FormatNumber(CDbl(txtAggregateIn), 2) 'AGGREGATE_INCOME_A
'                    .ListSubItems.Add 5, , FormatNumber(CDbl(txtTotalIncome), 2) 'CHARGEABLE_INCOME_A
'                    .ListSubItems.Add 6, , FormatNumber(CDbl(rst1!TC_SI_TOT), 2) 'STATUTORY_BIZ_INCOME_B
'                    .ListSubItems.Add 7, , FormatNumber(CDbl(rst1!TC_TP_AGGR_IN), 2) 'AGGREGATE_INCOME_B
'                    .ListSubItems.Add 8, , FormatNumber(CDbl(rst1!TC_TP_TOTAL_INCOME), 2) 'CHARGEABLE_INCOME_B
'                     .ListSubItems.Add 9, , 0 'TOTAL_CHARGEABLE_INCOME_A
'                    .ListSubItems.Add 10, , 0 'TOTAL_CHARGEABLE_INCOME_B
'                    .ListSubItems.Add 11, , 0 'TOTAL_A_B
'                    .ListSubItems.Add 12, , 0 'RATE
'                    .ListSubItems.Add 13, , 0 'TOTAL
'                    .ListSubItems.Add 14, , 0 'SUB_RATE
'                    .ListSubItems.Add 15, , 0 'TOTAL_CHARGEABLE_INCOME_A_SME
'                    .ListSubItems.Add 16, , 0 'TOTAL_A_B_SME
'                    .ListSubItems.Add 17, , False 'TOTAL_A_B_SME
                    
'                    If CDbl(rst1!TC_TP_CHARGEABLE) > 500000 Or CDbl(txtChargeableIn) > 500000 Then
'                    .ListSubItems.Add 3, , FormatNumber(CDbl(txtAllStatIn), 2) 'STATUTORY_BIZ_INCOME_A
'                    .ListSubItems.Add 4, , FormatNumber(CDbl(txtAggregateIn), 2) 'AGGREGATE_INCOME_A
'                    .ListSubItems.Add 5, , FormatNumber(CDbl(txtTotalIncome), 2) 'CHARGEABLE_INCOME_A
'                    .ListSubItems.Add 6, , FormatNumber(CDbl(rst1!TC_SI_TOT), 2) 'STATUTORY_BIZ_INCOME_B
'                    .ListSubItems.Add 7, , FormatNumber(CDbl(rst1!TC_TP_AGGR_IN), 2) 'AGGREGATE_INCOME_B
'                    .ListSubItems.Add 8, , FormatNumber(CDbl(rst1!TC_TP_TOTAL_INCOME), 2) 'CHARGEABLE_INCOME_B
'                    Else
'                    .ListSubItems.Add 3, , 0 'STATUTORY_BIZ_INCOME_A
'                    .ListSubItems.Add 4, , 0 'AGGREGATE_INCOME_A
'                    .ListSubItems.Add 5, , 0 'CHARGEABLE_INCOME_A
'                    .ListSubItems.Add 6, , 0 'STATUTORY_BIZ_INCOME_B
'                    .ListSubItems.Add 7, , 0 'AGGREGATE_INCOME_B
'                    .ListSubItems.Add 8, , 0 'CHARGEABLE_INCOME_B
'                    End If
                    
'                'azham 20062017
                   
'                End With
'            rst1.Close
'            Else
'                With xItem
'                .ListSubItems.Add 1, , txtYA 'YA
'                .ListSubItems.Add 2, , txtRefNo 'REFNO
'                .ListSubItems.Add 3, , 0 'STATUTORY_BIZ_INCOME_A
'                .ListSubItems.Add 4, , 0 'AGGREGATE_INCOME_A
'                .ListSubItems.Add 5, , 0 'CHARGEABLE_INCOME_A
'                .ListSubItems.Add 6, , 0 'STATUTORY_BIZ_INCOME_B
'                .ListSubItems.Add 7, , 0 'AGGREGATE_INCOME_B
'                .ListSubItems.Add 8, , 0 'CHARGEABLE_INCOME_B
'                .ListSubItems.Add 9, , 0 'TOTAL_CHARGEABLE_INCOME_A
'                .ListSubItems.Add 10, , 0 'TOTAL_CHARGEABLE_INCOME_B
'                .ListSubItems.Add 11, , 0 'TOTAL_A_B
'                .ListSubItems.Add 12, , 0 'RATE
'                .ListSubItems.Add 13, , 0 'TOTAL
'                .ListSubItems.Add 14, , 0 'SUB_RATE
'                 .ListSubItems.Add 15, , 0 'TOTAL_CHARGEABLE_INCOME_A_SME
'                .ListSubItems.Add 16, , 0 'TOTAL_A_B_SME
'                  .ListSubItems.Add 17, , False 'TOTAL_A_B_SME
'            End With
'            End If
           
        
'    Else
        
'        Set xItem = lvExemptionChargeable.ListItems.Add(1, , 0) 'NO
'            'STATUTORY_BIZ_INCOME_A
'            'AGGREGATE_INCOME_A
'            'CHARGEABLE_INCOME_A
'            'STATUTORY_BIZ_INCOME_B
'            'AGGREGATE_INCOME_B
'            'CHARGEABLE_INCOME_B
'            With xItem
'                .ListSubItems.Add 1, , txtYA 'YA
'                .ListSubItems.Add 2, , txtRefNo 'REFNO
'                .ListSubItems.Add 3, , FormatNumber(CDbl(txtAllStatIn), 2) 'STATUTORY_BIZ_INCOME_A
'                .ListSubItems.Add 4, , FormatNumber(CDbl(txtAggregateIn), 2) 'AGGREGATE_INCOME_A
'                .ListSubItems.Add 5, , FormatNumber(CDbl(txtTotalIncome), 2) 'CHARGEABLE_INCOME_A
                
'                .ListSubItems.Add 6, , 0 'STATUTORY_BIZ_INCOME_B
'                .ListSubItems.Add 7, , 0 'AGGREGATE_INCOME_B
'                .ListSubItems.Add 8, , 0 'CHARGEABLE_INCOME_B
'                .ListSubItems.Add 9, , 0 'TOTAL_CHARGEABLE_INCOME_A
'                .ListSubItems.Add 10, , 0 'TOTAL_CHARGEABLE_INCOME_B
'                .ListSubItems.Add 11, , 0 'TOTAL_A_B
'                .ListSubItems.Add 12, , 0 'RATE
'                .ListSubItems.Add 13, , 0 'TOTAL
'                .ListSubItems.Add 14, , 0 'SUB_RATE
'                .ListSubItems.Add 15, , 0 'TOTAL_CHARGEABLE_INCOME_A_SME
'                .ListSubItems.Add 16, , 0 'TOTAL_A_B_SME
'                  .ListSubItems.Add 17, , False 'TOTAL_A_B_SME
'            End With
            
     
'    End If
'       rst.Close
    
'    Dim BizChargeableIncome_A As Double
'    Dim BizChargeableIncome_B As Double
'    Dim IncreaseBizA_B As Double
'    Dim IncreasePercentage_A As Double
'    Dim IncreasePercentage_B As Double
'    Dim IncreasePercentage_Sum As Double
'    Dim EligibleTaxRate As Double
'    Dim CalcExmBiz_1 As Double
'    Dim CalcExmBiz_2 As Double
'    Dim CalcExmBiz_3 As Double
'    Dim CalcExmBiz_Sum As Double
'    Dim CalcExmBiz_Mutli As Double
'    Dim TotalExemption As Double
'    Dim IncreaseBizA_B_SME As Double
'    Dim TOTAL_AB_SME As Double
'    Dim RatePercent As Double
'    Dim rate As Double

'    rate = GetExemptionRate(txtYA, RatePercent)

'   Dim isSME As Boolean
'   Dim isCancel As Boolean
   
'    isSME = False
    
'    cSQL2 = "SELECT [SME] FROM [BALANCE_SHEET] WHERE [BS_REF_NO]='" & cRefNo & "' AND [BS_YA]='" & cYA & "'"
'    Set rst2 = DB.Execute(cSQL2)
'        If Not rst2.EOF Then
'            If rst2.Fields(0) = "1" Then
'                isSME = True
'            End If
'        End If
        
'       cSQL2 = "SELECT [ISCANCEL] FROM [TAX_COMPUTATION_EXEMPTION] WHERE [REF_NO]='" & cRefNo & "' AND [YA]='" & cYA & "'"
'    Set rst2 = DB.Execute(cSQL2)
'        If Not rst2.EOF Then
'            If rst2.Fields(0) = 1 Then
'                isCancel = True
'            Else
'                isCancel = False
'            End If
'        Else
'        isCancel = False
'        End If
        
        
'    Call CalcCurrenctYABizChargeableIncome(isSME, BizChargeableIncome_A, _
'    CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(3).Text), CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(4).Text), _
'    CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(5).Text), BizChargeableIncome_B, _
'    CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(6).Text), CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(7).Text), _
'    CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(8).Text), IncreaseBizA_B, _
'    IncreasePercentage_A, CalcExmBiz_1, _
'    CalcExmBiz_2, CalcExmBiz_Sum, _
'    CalcExmBiz_Mutli, IncreasePercentage_B, _
'    IncreasePercentage_Sum, EligibleTaxRate, _
'    CalcExmBiz_3, rate, TotalExemption, IncreaseBizA_B_SME, TOTAL_AB_SME, isCancel)

'     lvExemptionChargeable.ListItems(1).ListSubItems(9).Text = BizChargeableIncome_A 'TOTAL_CHARGEABLE_INCOME_A
'     lvExemptionChargeable.ListItems(1).ListSubItems(10).Text = BizChargeableIncome_B 'TOTAL_CHARGEABLE_INCOME_B
'     lvExemptionChargeable.ListItems(1).ListSubItems(11).Text = IncreaseBizA_B
'     lvExemptionChargeable.ListItems(1).ListSubItems(12).Text = EligibleTaxRate 'RATE
'     lvExemptionChargeable.ListItems(1).ListSubItems(13).Text = TotalExemption 'TOTAL
'     lvExemptionChargeable.ListItems(1).ListSubItems(14).Text = RatePercent 'SUB_RATE
'     lvExemptionChargeable.ListItems(1).ListSubItems(15).Text = IncreaseBizA_B_SME 'IncreaseBizA_B_SME
'     lvExemptionChargeable.ListItems(1).ListSubItems(16).Text = TOTAL_AB_SME 'TOTAL_AB_SME
'      lvExemptionChargeable.ListItems(1).ListSubItems(17).Text = isCancel 'TOTAL_AB_SME
     
'     'azham 05062017
     
'     If CDbl(txtAppChargeableIn4.Text) > 0 Then
        
'     End If

'     SetChargeableIncomeBizItems (TotalExemption)

'End Sub
''EN
'Private Sub EsTaxPay() 'continue here CYS
'    '==Oscar2009.1=='
'    cSQL = "SELECT TOP 1 * FROM [BORANG_CP204] WHERE [BCP_REF_NO]='" & Trim(txtRefNo) & "' And [BCP_YA]='" & Trim(txtYA) & "' Order by [BCP_VERSION] DESC"
'    Set rst2 = DB.Execute(cSQL)
'    If Not rst2.EOF Then
'        If IsNull(rst2!BCP_REV_ESTIMATED_TAX) Or rst2!BCP_REV_ESTIMATED_TAX = 0 Then
'            If IsNull(rst2!BCP_ESTIMATED_TAX) Or rst2!BCP_ESTIMATED_TAX = 0 Then
'                txtEsTaxPay.Locked = False
'                txtEsTaxPay.BackColor = &H80000005
'            Else
'                txtEsTaxPay.Text = FormatNumber(CDbl(rst2!BCP_ESTIMATED_TAX), 2)
'            End If
'        Else
'            txtEsTaxPay.Text = FormatNumber(CDbl(rst2!BCP_REV_ESTIMATED_TAX), 2)
'        End If
'    Else
'        txtEsTaxPay.Locked = False
'        txtEsTaxPay.BackColor = &H80000005
'    End If
'    rst2.Close
'    If CDbl(txtEsTaxPay.Text) <= 0 Then
'        txtEsTaxPay.Text = "0.00"
'    End If
''==End Oscar2009.1=='
'End Sub
''EN

'Private Sub ListViewITA_DblClick()
'    cmdITA_Click
'End Sub

'Private Sub ListViewRA_DblClick()
'    cmdRA_Click
'End Sub
''=== CYS 2010 ===
'Private Sub lstRAPartnership_DblClick()
'    cmdEditRAP_Click
'End Sub
''=== CYS end 2010 ===

'Private Sub lstView_DblClick()
'    cmdEdit_Click
'End Sub

''NGOHCS CA2008
'Public Sub TotalStatIn()
'    totalRA = 0
'    If lstView.ListItems.count > 0 Then
'        For X = 1 To lstView.ListItems.count
'            totalRA = CDbl(totalRA) + CDbl(lstView.ListItems(X).ListSubItems(11).Text)
'        Next
'    End If
'     If lstView.ListItems.count > 0 Then 'O2008.1
'        For X = 1 To lstView.ListItems.count
          
'             ListViewRA.ListItems(X).ListSubItems(3) = FormatNumber(CDbl(lstView.ListItems(X).ListSubItems(20).Text), 0) 'RA for the year
'             ListViewRA.ListItems(X).ListSubItems(4) = FormatNumber(CDbl(ListViewRA.ListItems(X).ListSubItems(2)) + CDbl(ListViewRA.ListItems(X).ListSubItems(3)) - CDbl(ListViewRA.ListItems(X).ListSubItems(7)), 0) 'TOTAL 'O2008.1
'             ListViewRA.ListItems(X).ListSubItems(5) = FormatNumber(CDbl(lstView.ListItems(X).ListSubItems(11).Text), 0) 'UTILISED DURING THE YEAR
'             ListViewRA.ListItems(X).ListSubItems(6) = FormatNumber(ListViewRA.ListItems(X).ListSubItems(4) - ListViewRA.ListItems(X).ListSubItems(5) - ListViewRA.ListItems(X).ListSubItems(8), 0) 'BALANCE c/f
'             If ListViewRA.ListItems(X).ListSubItems(6) < 0 Then
'                ListViewRA.ListItems(X).ListSubItems(6) = 0
'             End If
'        Next
'    End If
          
'    txtRAUtilised = FormatNumber(CDbl(totalRA), 0)
    
'    totalITA = 0
'    If lstView.ListItems.count > 0 Then
'        For X = 1 To lstView.ListItems.count
'            totalITA = CDbl(totalITA) + CDbl(lstView.ListItems(X).ListSubItems(12).Text)
'        Next
'    End If
        
'    If lstView.ListItems.count > 0 Then 'O2008.1
'        For X = 1 To lstView.ListItems.count
'             ListViewITA.ListItems(X).ListSubItems(3) = FormatNumber(CDbl(lstView.ListItems(X).ListSubItems(27).Text), 0) 'ITA for the year
'             ListViewITA.ListItems(X).ListSubItems(4) = FormatNumber(CDbl(ListViewITA.ListItems(X).ListSubItems(2)) + CDbl(ListViewITA.ListItems(X).ListSubItems(3)) - CDbl(ListViewRA.ListItems(X).ListSubItems(7)), 0) 'TOTAL 'O2008.1
'             ListViewITA.ListItems(X).ListSubItems(5) = FormatNumber(CDbl(lstView.ListItems(X).ListSubItems(12).Text), 0)
'             ListViewITA.ListItems(X).ListSubItems(6) = FormatNumber(ListViewITA.ListItems(X).ListSubItems(4) - ListViewITA.ListItems(X).ListSubItems(5) - ListViewRA.ListItems(X).ListSubItems(8), 0)

'             If ListViewITA.ListItems(X).ListSubItems(6) < 0 Then
'                ListViewITA.ListItems(X).ListSubItems(6) = 0
'             End If
'        Next
'    End If
    
    
'    'Get Total Statutory Income from all sources
'    totalstatutory = 0
'    If lstView.ListItems.count > 0 Then
'        For X = 1 To lstView.ListItems.count
'            totalstatutory = FormatNumber(CDbl(totalstatutory) + CDbl(lstView.ListItems(X).ListSubItems(13).Text), 0)
'        Next
'    End If
'    txtAllStatIn = FormatNumber(totalstatutory, 0)
'End Sub
''NGOHCS CA2008 END

'Private Sub lstViewCA_DblClick()
'    Call cmdEditCA_Click
'End Sub

'Private Sub lstViewEA_DblClick()
'    Call cmdEditEA_Click
'End Sub

'' === csNgoh 2008 === '
'Private Sub txt110BSetOff_Change()
'    If txt110BSetOff = "" Then txt110BSetOff = 0 'weihong
'    If Not IsNumeric(txt110BSetOff) Then Exit Sub
'    txtTotalSetoff = FormatNumber(CDbl(txtITPSetoff) + CDbl(txtITPSetoffOth) + CDbl(txtSec132) + CDbl(txtSec133) + CDbl(txt110BSetOff), 2)
'End Sub


'Private Sub txt110BSetOff_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txt110BSetOff_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txt110BSetOff_LostFocus()
'    If Not IsNumeric(txt110BSetOff) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txt110BSetOff = 0
'        Exit Sub
'    End If
'    ' === remark new added checking by csNgoh 2008 === '
'    If Not txtYA >= 2008 Then
'     txt110BSetOff = FormatNumber(0, 2)
'    Else
'    ' === end new added === '
'    txt110BSetOff = FormatNumber(CDbl(txt110BSetOff), 2)
'    End If
'End Sub

'' === end csNgoh 2008 === '
'Private Sub txtAggregate_Change()
'    txtAggregateIn = FormatNumber(CDbl(txtAggregate) + CDbl(txtOthAggregate), 0)
'End Sub
'Private Sub txtAggregateIn_Change()
'Dim APDonation As String
'Dim rst2 As New ADODB.Recordset
'Dim rst3 As New ADODB.Recordset
'Dim cSQL2 As String
'Dim cSQL3 As String
'Dim strKey As String
'Dim partnerLoss As String

'APDonation = 0
'    total_loss = 0
'    If lstView.ListItems.count > 0 Then
'        For X = 1 To lstView.ListItems.count
'            If CDbl(lstView.ListItems(X).ListSubItems(5).Text) < 0 Then
'                total_loss = CDbl(total_loss) + Abs(CDbl(lstView.ListItems(X).ListSubItems(5).Text))
'            End If
'        Next
'    End If
'    ' === CYS 2010 ===
'    cSQL2 = "SELECT * FROM [TAX_COMPUTATION_PARTNER] WHERE [TCP_REF_NO] = '" & Trim(frmIncomeCalculationEdit.txtRefNo.Text) & "' AND [TCP_YA] = '" & Trim(frmIncomeCalculationEdit.txtYA.Text) & "'"
'    Set rst2 = DB.Execute(cSQL2)
    
'    If rst2.EOF Then
'        partnerLoss = "0"
'    Else
'        strKey = rst2!TCP_KEY
        
'        cSQL3 = "SELECT sum(cast(PN_ADJ_LOSS as money)) AS PARTNER_LOSS FROM [INCOME_PARTNERSHIP] WHERE [TCP_KEY] = " & strKey
'        Set rst3 = DB.Execute(cSQL3)
        
'        If IsNull(rst3!PARTNER_LOSS) Then
'            partnerLoss = "0"
'        Else
'            partnerLoss = rst3!PARTNER_LOSS
'        End If
'        rst3.Close
'    End If
'    rst2.Close
    
'    txtCurrentYrLoss = FormatNumber(CDbl(total_loss) + CDbl(partnerLoss), 0)
'    ' === end CYS 2010 ===
    
'    If CDbl(txtCurrentYrLoss) >= CDbl(txtAggregateIn) Then
'        txtCurrBsLoss = FormatNumber(CDbl(txtAggregateIn), 0)
'    ElseIf CDbl(txtCurrentYrLoss) < CDbl(txtAggregateIn) Then
'        txtCurrBsLoss = FormatNumber(CDbl(txtCurrentYrLoss), 0)
'    End If
    
'    txtAggrLoss = FormatNumber(CDbl(txtAggregateIn) - CDbl(txtCurrBsLoss), 0)

'    If cSourceNo = 1 Then
    
'    'If Val(cya) >= 2009 Then
'        ' HS : 2009 : C2008.7 , new checking'
'        Call LoadLessApprDonation
'              If TotalCompareAmount >= CDbl(txtTotalOthExp) Then
'                  txtApprDonation = txtTotalOthExp
'              Else
'                  txtApprDonation = FormatNumber(TotalCompareAmount, 0)
'              End If
'    'Else
'    ' HS : 2009 : C2008.7
''        cSQL2 = "SELECT * FROM [PROFIT_LOSS_ACCOUNT] WHERE [PL_REF_NO]='" & Trim(crefno) & "' AND [PL_YA]='" & Trim(cya) & "'"
''        Set rst2 = DB.Execute(cSQL2)
''        If Not rst2.EOF Then
''
''                 '=== csNgoh C2008.6 (SU6) === '
''                If rst2!PL_YA < 2007 Then
''                    APDonation = 0.05
''                ElseIf rst2!PL_YA >= 2007 And rst2!PL_YA < 2009 Then
''                    APDonation = 0.07
''                Else
''                    APDonation = 0.1
''                End If
''                 '=== end csNgoh C2008.6 (SU6) === '
''
''            If CDbl(rst2!PL_OTHER_EXP_DNT_APP) < CDbl(txtTotalOthExp) Then
''                If CDbl(rst2!PL_OTHER_EXP_DNT_APP) >= CDbl(txtTotalOthExp) * APDonation Then
''                    txtApprDonation = FormatNumber(CDbl(txtTotalOthExp) * APDonation, 0)
''                ElseIf CDbl(rst2!PL_OTHER_EXP_DNT_APP) < CDbl(txtTotalOthExp) * APDonation Then
''                    txtApprDonation = FormatNumber(CDbl(rst2!PL_OTHER_EXP_DNT_APP), 0)
''                End If
''            ElseIf CDbl(rst2!PL_OTHER_EXP_DNT_APP) >= CDbl(txtTotalOthExp) Then
''                txtApprDonation = FormatNumber(CDbl(txtTotalOthExp) * APDonation, 0)
''           End If
''
''           End If
''        rst2.Close
'        ' HS : 2009: C2008.7 end'
''    End If
''        ' HS : 2009 : C2008.7 , new checking end'
''
''    End If
''
''     If cSourceNo = 1 Then
''        cSQL2 = "SELECT * FROM [PROFIT_LOSS_ACCOUNT] WHERE [PL_REF_NO]='" & Trim(crefno) & "' AND [PL_YA]='" & Trim(cya) & "'"
''        Set rst2 = DB.Execute(cSQL2)
''        If Not rst2.EOF Then
''
''                ' === csNgoh C2008.6 (SU6) === '
''                If rst2!PL_YA < 2007 Then
''                    APDonation = 0.05
''                ElseIf rst2!PL_YA >= 2007 And rst2!PL_YA < 2009 Then
''                    APDonation = 0.07
''                Else
''                    APDonation = 0.1
''                End If
''                ' === end csNgoh C2008.6 (SU6) === '
''
''            dblzakat = 0
''            'geline: Start: Taxcom C+ v 2005.1
''            cSQL4 = "SELECT * FROM [OTHER_EXZAKAT] WHERE [EXOZ_KEY]=" & Trim(rst2![PL_KEY]) & " AND [EXOZ_DEDUCTIBLE]='Yes'"
''            Set rst4 = DB.Execute(cSQL4)
''            If Not rst4.EOF Then
''                Do While Not rst4.EOF
''                    dblzakat = dblzakat + CDbl(rst4![EXOZ_AMOUNT])
''                    rst4.MoveNext
''                Loop
''            End If
''            rst4.Close
''
''            If CDbl(dblzakat) < CDbl(txtTotalOthExp) Then
''                If CDbl(dblzakat) >= CDbl(txtTotalOthExp) * 0.025 Then
''                    txtZakat = FormatNumber(CDbl(txtTotalOthExp) * 0.025, 0)
''                ElseIf CDbl(dblzakat) < CDbl(txtTotalOthExp) * 0.025 Then
''                    txtZakat = FormatNumber(CDbl(dblzakat), 0)
''                End If
''            ElseIf CDbl(dblzakat) >= CDbl(txtTotalOthExp) Then
''                txtZakat = FormatNumber(CDbl(txtTotalOthExp) * 0.025, 0)
''            End If
''            'geline: End: Taxcom C+ v 2005.1
''
''            End If
''        rst2.Close
'Call CalcExemtpionx
'   End If
'End Sub

'Private Sub txtAggrLoss_Change()
'    Call total_other_expenses
'End Sub
'' === CYS 2010 ===
'Private Sub txtAllStatIn_Change()
'    'Call TotalStatIn
'    'txtAggregate = FormatNumber(CDbl(txtAllStatIn) - CDbl(txtBsLoss), 0)
'    'Call txtULBalbf_Change
'    Call Calculate_TotalIncome
'    Call CalcExemtpionx
'End Sub
'Private Sub CalcExemtpionx()

'    If lvExemptionChargeable Is Nothing Then
'        Exit Sub
'    End If
'    If lvExemptionChargeable.ListItems.count <= 0 Then
'        Exit Sub
'    End If
    
'     lvExemptionChargeable.ListItems(1).ListSubItems(3).Text = FormatNumber(CDbl(txtAllStatIn), 2) 'STATUTORY_BIZ_INCOME_A
'    lvExemptionChargeable.ListItems(1).ListSubItems(4).Text = FormatNumber(CDbl(txtAggregateIn), 2) 'AGGREGATE_INCOME_A
'    lvExemptionChargeable.ListItems(1).ListSubItems(5).Text = FormatNumber(CDbl(txtTotalIncome), 2) 'CHARGEABLE_INCOME_A

'   Dim BizChargeableIncome_A As Double
'    Dim BizChargeableIncome_B As Double
'    Dim IncreaseBizA_B As Double
'    Dim IncreasePercentage_A As Double
'    Dim IncreasePercentage_B As Double
'    Dim IncreasePercentage_Sum As Double
'    Dim EligibleTaxRate As Double
'    Dim CalcExmBiz_1 As Double
'    Dim CalcExmBiz_2 As Double
'    Dim CalcExmBiz_3 As Double
'    Dim CalcExmBiz_Sum As Double
'    Dim CalcExmBiz_Mutli As Double
'    Dim TotalExemption As Double
'     Dim IncreaseBizA_B_SME As Double
'    Dim TOTAL_AB_SME As Double
'    Dim RatePercent As Double
'    Dim rate As Double
'    rate = GetExemptionRate(txtYA, RatePercent)
    
'     Dim isSME As Boolean
'     Dim isCancel As Boolean
'    Dim cSQL2 As String
'    isSME = False
    
'    cSQL2 = "SELECT [SME] FROM [BALANCE_SHEET] WHERE [BS_REF_NO]='" & cRefNo & "' AND [BS_YA]='" & cYA & "'"
'    Set rst2 = DB.Execute(cSQL2)
'        If Not rst2.EOF Then
'            If rst2.Fields(0) = "1" Then
'            isSME = True
'            End If
'        End If
        
'         cSQL2 = "SELECT [ISCANCEL] FROM [TAX_COMPUTATION_EXEMPTION] WHERE [REF_NO]='" & cRefNo & "' AND [YA]='" & cYA & "'"
'    Set rst2 = DB.Execute(cSQL2)
'        If Not rst2.EOF Then
'            If rst2.Fields(0) = 1 Then
'                isCancel = True
'            Else
'                isCancel = False
'            End If
'        Else
'        isCancel = False
'        End If
        
'    Call CalcCurrenctYABizChargeableIncome(isSME, BizChargeableIncome_A, _
'    CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(3).Text), CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(4).Text), _
'    CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(5).Text), BizChargeableIncome_B, _
'    CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(6).Text), CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(7).Text), _
'    CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(8).Text), IncreaseBizA_B, _
'    IncreasePercentage_A, CalcExmBiz_1, _
'    CalcExmBiz_2, CalcExmBiz_Sum, _
'    CalcExmBiz_Mutli, IncreasePercentage_B, _
'    IncreasePercentage_Sum, EligibleTaxRate, _
'    CalcExmBiz_3, rate, TotalExemption, IncreaseBizA_B_SME, TOTAL_AB_SME, isCancel)
     
'     lvExemptionChargeable.ListItems(1).ListSubItems(9).Text = BizChargeableIncome_A 'TOTAL_CHARGEABLE_INCOME_A
'     lvExemptionChargeable.ListItems(1).ListSubItems(10).Text = BizChargeableIncome_B 'TOTAL_CHARGEABLE_INCOME_B
'     lvExemptionChargeable.ListItems(1).ListSubItems(11).Text = IncreaseBizA_B
'     lvExemptionChargeable.ListItems(1).ListSubItems(12).Text = EligibleTaxRate 'RATE
'     lvExemptionChargeable.ListItems(1).ListSubItems(13).Text = TotalExemption 'TOTAL
'     lvExemptionChargeable.ListItems(1).ListSubItems(14).Text = RatePercent 'SUB_RATE.
'     lvExemptionChargeable.ListItems(1).ListSubItems(15).Text = IncreaseBizA_B_SME 'SUB_RATE.
'     lvExemptionChargeable.ListItems(1).ListSubItems(16).Text = TOTAL_AB_SME 'SUB_RATE.
'      SetChargeableIncomeBizItems (TotalExemption)
'End Sub

'Private Sub txtDividendIncome_Change()
'    Call Get_Other_Aggregate
'    If Val(cYA) >= 2008 Then
'        txtSIFrmDiv = txtDividendIncome
'    Else
'        txtSIFrmDiv = FormatNumber(0, 2)
'    End If
'End Sub
'Private Sub txtInstallments_107A_Change()
'    Call CalcIntallment
'End Sub

'Private Sub txtInstallments_107C_Change()
'    Call CalcIntallment
'End Sub
'Private Sub CalcIntallment()
'    Dim tmpTotal As String
    
'    If IsNumeric(txtInstallments_107C) = False Then
'        txtInstallments_107C.Text = "0"
'    End If
'    If IsNumeric(txtInstallments_107A) = False Then
'        txtInstallments_107C.Text = "0"
'    End If
    
'    tmpTotal = CDec(txtInstallments_107C.Text) + CDec(txtInstallments_107A.Text)
    
'    txtInstallments.Text = FormatNumber(CDec(tmpTotal), 2)
'End Sub

    
' ''simkh 2012.1
''Private Sub txtEABalReIn_Change()
''    txtEABalcf = FormatNumber(CDbl(txtEABalReIn) - CDbl(txtEAUtilised), 0)
''    If txtEABalcf < 0 Then
''      txtEABalcf = 0
''    End If
''End Sub
''
' ''simkh 2012.1
''Private Sub txtEAExemption_Change()
''    If txtEAExemption = "" Then txtEAExemption = 0
''        If Not IsNumeric(txtEAExemption) Then Exit Sub
''        txtEABalReIn = FormatNumber(CDbl(txtEABalbf) + CDbl(txtEAExemption), 0)
''End Sub
''
' ''simkh 2012.1
''Private Sub txtEAExemption_GotFocus()
''    SendKeys "(End)+(Home)"
''End Sub
''
' ''simkh 2012.1
''Private Sub txtEAExemption_KeyPress(KeyAscii As Integer)
''    On Error Resume Next
''    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
''        KeyAscii = vbKeyCancel
''        Beep
''    End If
''End Sub
''
' ''simkh 2012.1
''Private Sub txtEAExemption_LostFocus()
''    If Not IsNumeric(txtEAExemption) Then
''        MsgBox "Not a valid number !", vbCritical, "Taxcom"
''        txtEAExemption = 0
''        Exit Sub
''    End If
''    txtEAExemption = FormatNumber(CDbl(txtEAExemption), 0)
''End Sub
''
' ''simkh 2012.1
''Private Sub GetEAUtilised()
''    With sForm
''        For i = 1 To .lstView.ListItems.count
' ''            If .ListViewEA.SelectedItem.Text = .lstView.ListItems(i).Text Then
''                If (.lstView.ListItems(i).ListSubItems(10).Text * .lstView.ListItems(i).ListSubItems(41).Text / 100) < CDbl(txtEABalReIn.Text) Then
''                     txtEAUtilised.Text = FormatNumber((.lstView.ListItems(i).ListSubItems(10).Text * .lstView.ListItems(i).ListSubItems(41).Text / 100), 0)
''                Else
''                     txtEAUtilised.Text = CDbl(txtEABalReIn.Text)
''                End If
''            'End If
''        Next
''    End With
''End Sub
''
' ''simkh 2012.1
''Private Sub SetEAUtilised()
''    With sForm
''        For i = 1 To .lstView.ListItems.count
' ''            If .ListViewEA.SelectedItem.Text = .lstView.ListItems(i).Text Then
''            If (.lstView.ListItems(i).ListSubItems(10).Text * .lstView.ListItems(i).ListSubItems(41).Text / 100) < CDbl(txtRABalReIn.Text) Then
''                .lstView.ListItems(i).ListSubItems(14).Text = FormatNumber((.lstView.ListItems(i).ListSubItems(10).Text * .lstView.ListItems(i).ListSubItems(41).Text / 100), 0)
''            Else
''                .lstView.ListItems(i).ListSubItems(14).Text = CDbl(txtEABalReIn.Text)
''            End If
''
''        Next
''    End With
''End Sub
''
' ''simkh 2012.1
''Private Sub txtEAUtilised_Change()
''    txtEABalcf = FormatNumber(CDbl(txtEABalReIn) - CDbl(txtEAUtilised), 0)
''End Sub

'Private Sub txtInterestIncome_Change()
'    Call Get_Other_Aggregate
'End Sub
'Private Sub txtRate7_Change()
'     If txtRate7 = "" Then txtRate7 = 0
'    If Not IsNumeric(txtRate7) Then Exit Sub
'    txtITPChargeableIn7 = FormatNumber(CDbl(txtAppChargeableIn7) * (CDbl(txtRate7) / 100), 2)
'End Sub
'Private Sub txtRate7_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtRate7_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtRate7_LostFocus()
'    If Not IsNumeric(txtRate7) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtRate5 = 0
'        Exit Sub
'    End If
'    txtRate7 = FormatNumber(CDbl(txtRate7), 0)
'End Sub
'Private Sub txtRentalIncome_Change()
'    Call Get_Other_Aggregate
'End Sub

'Private Sub txtPartnershipLoss_Change()
'    Call txtAggregateIn_Change
'End Sub

'Private Sub txtStatPartnership_Change()
'    Call Calculate_TotalIncome
'End Sub
'' === end CYS 2010 ===

'Private Sub txtAmtTut_Change()
'    If txtAmtTut = "" Then txtAmtTut = 0
'    If Not IsNumeric(txtAmtTut) Then Exit Sub
'    txtBlnCf = FormatNumber(CDbl(txtBlnBf) + CDbl(txtSrdAmt2) - CDbl(txtAmtTut), 0)
'    If txtBlnCf < 0 Then
'    txtBlnCf = 0
'    End If
'End Sub

'Private Sub txtAmtTut_GotFocus()
' SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtAmtTut_KeyPress(KeyAscii As Integer)
'   On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtAmtTut_LostFocus()
'  If Not IsNumeric(txtAmtTut) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtAmtTut = 0
'        Exit Sub
'    End If
'    txtAmtTut = FormatNumber(CDbl(txtAmtTut), 0)
'End Sub

'Private Sub txtAppChargeableIn1_Change()
'    If txtAppChargeableIn1 = "" Then txtAppChargeableIn1 = 0
'    If Not IsNumeric(txtAppChargeableIn1) Then Exit Sub
'    txtITPChargeableIn1 = FormatNumber(CDbl(txtAppChargeableIn1) * (CDbl(txtRate1) / 100), 2)
'End Sub

'Private Sub txtAppChargeableIn1_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtAppChargeableIn1_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtAppChargeableIn1_LostFocus()
'    If Not IsNumeric(txtAppChargeableIn1) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtAppChargeableIn1 = 0
'        Exit Sub
'    End If
'    txtAppChargeableIn1 = FormatNumber(CDbl(txtAppChargeableIn1), 0)
'End Sub

'Private Sub txtAppChargeableIn2_Change()
'    If txtAppChargeableIn2 = "" Then txtAppChargeableIn2 = 0
'    If Not IsNumeric(txtAppChargeableIn2) Then Exit Sub
'    txtITPChargeableIn2 = FormatNumber(CDbl(txtAppChargeableIn2) * (CDbl(txtRate2) / 100), 2)
'End Sub

'Private Sub txtAppChargeableIn2_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtAppChargeableIn2_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtAppChargeableIn2_LostFocus()
'    If Not IsNumeric(txtAppChargeableIn2) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtAppChargeableIn2 = 0
'        Exit Sub
'    End If
'    txtAppChargeableIn2 = FormatNumber(CDbl(txtAppChargeableIn2), 0)
'End Sub

'Private Sub txtAppChargeableIn3_Change()
'    If txtAppChargeableIn3 = "" Then txtAppChargeableIn3 = 0
'    If Not IsNumeric(txtAppChargeableIn3) Then Exit Sub
'    txtITPChargeableIn3 = FormatNumber(CDbl(txtAppChargeableIn3) * (CDbl(txtRate3) / 100), 2)
'End Sub

'Private Sub txtAppChargeableIn3_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtAppChargeableIn3_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtAppChargeableIn3_LostFocus()
'    If Not IsNumeric(txtAppChargeableIn3) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtAppChargeableIn3 = 0
'        Exit Sub
'    End If
'    txtAppChargeableIn3 = FormatNumber(CDbl(txtAppChargeableIn3), 0)
'End Sub

'Private Sub txtAppChargeableIn4_Change()
'    If txtAppChargeableIn4 = "" Then txtAppChargeableIn4 = 0
'    If Not IsNumeric(txtAppChargeableIn4) Then Exit Sub
'    txtITPChargeableIn4 = FormatNumber(CDbl(txtAppChargeableIn4) * (CDbl(txtRate4) / 100), 2)
'End Sub

'Private Sub txtAppChargeableIn4_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtAppChargeableIn4_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtAppChargeableIn4_LostFocus()
'    If Not IsNumeric(txtAppChargeableIn4) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtAppChargeableIn4 = 0
'        Exit Sub
'    End If
'    txtAppChargeableIn4 = FormatNumber(CDbl(txtAppChargeableIn4), 0)
'End Sub

'Private Sub txtAppChargeableIn4a_Change()
'    If txtAppChargeableIn4a = "" Then txtAppChargeableIn4a = 0
'    If Not IsNumeric(txtAppChargeableIn4a) Then Exit Sub
'    txtITPChargeableIn4a = FormatNumber(CDbl(txtAppChargeableIn4a) * (CDbl(txtRate4a) / 100), 2)
'End Sub

'Private Sub txtAppChargeableIn4a_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtAppChargeableIn4a_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtAppChargeableIn4a_LostFocus()
'    If Not IsNumeric(txtAppChargeableIn4a) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtAppChargeableIn4a = 0
'        Exit Sub
'    End If
'    txtAppChargeableIn4a = FormatNumber(CDbl(txtAppChargeableIn4a), 0)
'End Sub

'Private Sub txtAppChargeableIn5_Change()
'    If txtAppChargeableIn5 = "" Then txtAppChargeableIn5 = 0
'    If Not IsNumeric(txtAppChargeableIn5) Then Exit Sub
'    txtITPChargeableIn5 = FormatNumber(CDbl(txtAppChargeableIn5) * (CDbl(txtRate5) / 100), 2)
'End Sub

'Private Sub txtAppChargeableIn5_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtAppChargeableIn5_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtAppChargeableIn5_LostFocus()
'    If Not IsNumeric(txtAppChargeableIn5) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtAppChargeableIn5 = 0
'        Exit Sub
'    End If
'    txtAppChargeableIn5 = FormatNumber(CDbl(txtAppChargeableIn5), 0)
'End Sub
'Private Sub txtAppChargeableIn7_Change()
'    If txtAppChargeableIn7 = "" Then txtAppChargeableIn7 = 0
'    If Not IsNumeric(txtAppChargeableIn5) Then Exit Sub
'    txtITPChargeableIn7 = FormatNumber(CDbl(txtAppChargeableIn7) * (CDbl(txtRate7) / 100), 2)
'End Sub
'Private Sub txtAppChargeableIn7_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtAppChargeableIn7_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub
'Private Sub txtAppChargeableIn7_LostFocus()
'    If Not IsNumeric(txtAppChargeableIn7) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtAppChargeableIn7 = 0
'        Exit Sub
'    End If
'    txtAppChargeableIn7 = FormatNumber(CDbl(txtAppChargeableIn7), 0)
'End Sub
'Private Sub txtAppChargeableIn6_Change()
'    If txtAppChargeableIn6 = "" Then txtAppChargeableIn6 = 0
'    If Not IsNumeric(txtAppChargeableIn6) Then Exit Sub
'    txtITPChargeableIn6 = FormatNumber(CDbl(txtAppChargeableIn6) * (CDbl(txtRate6) / 100), 2)
'End Sub

'Private Sub txtAppChargeableIn6_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtAppChargeableIn6_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtAppChargeableIn6_LostFocus()
'    If Not IsNumeric(txtAppChargeableIn6) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtAppChargeableIn6 = 0
'        Exit Sub
'    End If
'    txtAppChargeableIn6 = FormatNumber(CDbl(txtAppChargeableIn6), 0)
'End Sub

'Private Sub txtApprDonation_Change()
' ''    txtTotalIncome = FormatNumber(CDbl(txtTotalOthExp) - (CDbl(txtApprDonation) + CDbl(txtZakat) + CDbl(txtClaim)), 0)
'Call cal_totalIncome
' ''   MsgBox txtTotalIncome
'End Sub

'Private Sub txtBlnBf_Change()
'    txtBlnCf = FormatNumber(CDbl(txtBlnBf) + CDbl(txtSrdAmt2) - CDbl(txtAmtTut), 0)
'End Sub

'Private Sub txtBsLoss_Change()
' 'Mr Tho formula
'    If CDbl(txtBsLoss) >= CDbl(txtULBalbf) - CDbl(txtDisABL) Then
'        'HS : C2008.7 : Format Number
'        'txtULUtilised = FormatNumber(CDbl(txtULBalbf), 0) - FormatNumber(CDbl(txtDisABL), 0)
'        txtULUtilised = FormatNumber(CDbl(txtULBalbf) - CDbl(txtDisABL), 0)
'    ElseIf CDbl(txtBsLoss) < CDbl(txtULBalbf) - CDbl(txtDisABL) Then
'        'HS : C2008.7 : Format Number
'        'txtULUtilised = FormatNumber(CDbl(txtBsLoss), 0) - FormatNumber(CDbl(txtDisABL), 0)
'        txtULUtilised = FormatNumber(CDbl(txtBsLoss) - CDbl(txtDisABL), 0)
'    End If
'    txtAggregate = FormatNumber(CDbl(txtTotal) - CDbl(txtBsLoss), 0) ' CYS 2010
'End Sub

'' HS : 2009 : Change Unabsorbed business loss '
'Private Sub txtCBL_Change()

'    Dim rst As New ADODB.Recordset
'    If txtCBL = "" Then txtCBL = 0
'    If Not IsNumeric(txtCBL) Then Exit Sub
    
'    txtULBalcf = FormatNumber(CDbl(txtULBalUtil) + CDbl(txtUBL) - CDbl(txtSrdAmt) - CDbl(txtCBL), 0)
'    If txtULBalcf < 0 Then
'        txtULBalcf = 0
'    End If
    
    
'    txtBalcf = FormatNumber(CDbl(txtULBalcf) - CDbl(txtDisABL), 0)
'    If txtBalcf < 0 Then
'    txtBalcf = 0
'    End If
    
'    txtANCB = FormatNumber(CDbl(txtUBL) - CDbl(txtSrdAmt) - CDbl(txtCBL), 0)
'    If txtANCB < 0 Then
'        txtANCB = 0
'    End If

'End Sub


'' HS : 2009 : Change Unabsorbed business loss '
'Private Sub txtCBL_LostFocus()
'    If Not IsNumeric(txtCBL.Text) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtCBL.Text = 0
'        Exit Sub
'    Else
'            If Me.chkCBL.Value = Checked Then
'                Dim CompareValue As String
'                CompareValue = FormatNumber(CDbl(txtCBL.Text), 0)
'                Me.txtCBL.Text = CompareValue
'                    If CompareValue > 100000 Then
'                        Me.txtCBL.Text = FormatNumber(CDbl(100000), 0)
'                    End If
'            End If
'    End If
'End Sub

'' HS : 2009 : Change Unabsorbed business loss '
'Private Sub txtCBL_GotFocus()
' SendKeys "{End}+{Home}"
'End Sub

'' HS : 2009 : Change Unabsorbed business loss '
'Private Sub txtCBL_KeyPress(KeyAscii As Integer)
'   On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtChargeableIn_Change()
'    Call CalcExemtpionx
'    Call CalcLessExempChargeableIncome
'    'Call chargeable_apportionment
'End Sub

'Private Sub txtClaim_Change()
'    If txtClaim = "" Then txtClaim = 0
'    If Not IsNumeric(txtClaim) Then Exit Sub
' ''  txtTotalIncome = FormatNumber(CDbl(txtTotalOthExp) - (CDbl(txtApprDonation) + CDbl(txtZakat) + CDbl(txtClaim)), 0)
'    Call cal_totalIncome
' ''    Call InvalidGRelief
' '' MsgBox txtTotalIncome
'End Sub

'Private Sub txtClaim_GotFocus()
' SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtClaim_KeyPress(KeyAscii As Integer)
' On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtClaim_LostFocus()
'If Not IsNumeric(txtClaim) Then
'    MsgBox "Not a valid number !", vbCritical, "Taxcom"
'    txtClaim = 0
'    txtClaim.SetFocus
'    Exit Sub
'End If

'Call InvalidGRelief
' ''   MsgBox "Invalid Losses claim under group relief !", vbCritical, "Taxcom"
' ''   txtClaim = 0
' ''   txtClaim.SetFocus
' ''   Exit Sub
' ''End If
'txtClaim = FormatNumber(CDbl(txtClaim), 0)
'End Sub

'Private Sub txtCurrBsLoss_Change()
'    If CDbl(txtCurrBsLoss) >= CDbl(txtCurrentYrLoss) Then
'        txtULUtilisedCurr = FormatNumber(CDbl(txtCurrentYrLoss), 0)
'    ElseIf CDbl(txtCurrBsLoss) < CDbl(txtCurrentYrLoss) Then
'        txtULUtilisedCurr = FormatNumber(CDbl(txtCurrBsLoss), 0)
'    End If
    
'    txtAggrLoss = FormatNumber(CDbl(txtAggregateIn) - CDbl(txtCurrBsLoss), 0)
'End Sub

'Private Sub txtCurrentYrLoss_Change()
'    If CDbl(txtCurrBsLoss) >= CDbl(txtCurrentYrLoss) Then
'        txtULUtilisedCurr = FormatNumber(CDbl(txtCurrentYrLoss), 0)
'    ElseIf CDbl(txtCurrBsLoss) < CDbl(txtCurrentYrLoss) Then
'        txtULUtilisedCurr = FormatNumber(CDbl(txtCurrBsLoss), 0)
'    End If
'    txtUBL = FormatNumber(CDbl(txtCurrentYrLoss) - CDbl(txtULUtilisedCurr), 0)
'End Sub

''Private Sub txtDirExpenses3_Change()
''    If txtDirExpenses3 = "" Then txtDirExpenses3 = 0
''    If Not IsNumeric(txtDirExpenses3) Then Exit Sub
''    '===NgKL 2010.2==='
''    If CDbl(txtSundryIn) <= CDbl(txtDirExpenses3) Then
''        txtNettSundryIn = "0"
''    ElseIf CDbl(txtSundryIn) > CDbl(txtDirExpenses3) Then
''        txtNettSundryIn = FormatNumber(CDbl(txtSundryIn) - CDbl(txtDirExpenses3), 0)
''    End If
''    '===NgKL End==='
''    Call Get_Other_Aggregate
''End Sub

'Private Sub txtDisABL_Change()
'If txtDisABL = "" Then txtDisABL = 0
'    If Not IsNumeric(txtDisABL) Then Exit Sub
'    ' HS : C2008.7 : Add in FormatNumber
'    txtBalcf = FormatNumber(CDbl(txtULBalcf) - CDbl(txtDisABL), 0)
'    ' HS : C2008.7 : Add in FormatNumber : end
'    If txtBalcf < 0 Then
'    txtBalcf = 0
'    End If
    
'    'Mr Tho formula
'    If CDbl(txtULBalbf) - CDbl(txtDisABL) >= CDbl(txtAllStatIn) Then
'        txtBsLoss = FormatNumber(CDbl(txtAllStatIn), 0)
'    ElseIf CDbl(txtULBalbf) - CDbl(txtDisABL) < CDbl(txtAllStatIn) Then
'        'txtBsLoss = FormatNumber(CDbl(txtULBalbf), 0) - FormatNumber(CDbl(txtDisABL), 0)
'        ' HS : C2008.7 : Add in FormatNumber
'        'PANYW 2009.1 S60FA
'        If Not strS60FA = "Y" Then
'            txtBsLoss = FormatNumber(CDbl(txtULBalbf) - CDbl(txtDisABL), 0)
'        End If
'        'PANYW 2009.1 S60FA END
'    End If
    
'    'Mr Tho formula
'    If CDbl(txtBsLoss) >= CDbl(txtULBalbf) - CDbl(txtDisABL) Then
'        'txtULUtilised = FormatNumber(CDbl(txtULBalbf), 0) - FormatNumber(CDbl(txtDisABL), 0)
'        ' HS : C2008.7 : Add in FormatNumber
'        'PANYW 2009.1 S60FA

'        txtULUtilised = FormatNumber(CDbl(txtULBalbf) - CDbl(txtDisABL), 0)

'        'PANYW 2009.1 S60FA END
'    ElseIf CDbl(txtBsLoss) < CDbl(txtULBalbf) - CDbl(txtDisABL) Then
'        txtULUtilised = FormatNumber(CDbl(txtBsLoss), 0)
'    End If
    
'End Sub

'Private Sub txtDisABL_GotFocus()
' SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtDisABL_KeyPress(KeyAscii As Integer)
'On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtDisABL_LostFocus()
' If Not IsNumeric(txtDisABL) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtDisABL = 0
'        Exit Sub
'    End If
'    txtDisABL = FormatNumber(CDbl(txtDisABL), 0)
'End Sub

''Private Sub txtDivAttrInt_Change()
''
''    If txtDivAttrInt = "" Then txtDivAttrInt = 0
''    If Not IsNumeric(txtDivAttrInt) Then Exit Sub
' ''===NgKL C2010==='
''    txtDirExpenses2 = FormatNumber(CDbl(txtDivAttrInt) + CDbl(txtDivOthers), 0)
''    If CDbl(txtDividendIn(1)) <= CDbl(txtDivAttrInt) + CDbl(txtDivOthers) Then
''        txtNetDividend = "0"
''    ElseIf CDbl(txtDividendIn(1)) > CDbl(txtDivAttrInt) + CDbl(txtDivOthers) Then
''        txtNetDividend = FormatNumber(CDbl(txtDividendIn(1)) - CDbl(txtDivOthers) - CDbl(txtDivAttrInt), 0)
''    End If
' ''===NgKL End==='
''End Sub

''Private Sub txtDivAttrInt_GotFocus()
''    SendKeys "{End}+{Home}"
''End Sub
''
''Private Sub txtDivAttrInt_KeyPress(KeyAscii As Integer)
''    On Error Resume Next
''    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
''        KeyAscii = vbKeyCancel
''        Beep
''    End If
''End Sub
''
''Private Sub txtDivAttrInt_LostFocus()
''    If Not IsNumeric(txtDivAttrInt) Then
''        MsgBox "Not a valid number !", vbCritical, "Taxcom"
''        txtDivAttrInt = 0
''        Exit Sub
''    End If
''    txtDivAttrInt = FormatNumber(CDbl(txtDivAttrInt), 0)
''End Sub

''Private Sub txtDividendIn_Change(Index As Integer)
''
''    If txtDividendIn(1) = "" Then txtDividendIn(1) = 0
''    If Not IsNumeric(txtDividendIn(1)) Then Exit Sub
' ''===NgKL C2010==='
''    If CDbl(txtDividendIn(1)) <= CDbl(txtDivAttrInt) + CDbl(txtDivOthers) Then
''        txtNetDividend = "0"
''    ElseIf CDbl(txtDividendIn(1)) > CDbl(txtDivAttrInt) + CDbl(txtDivOthers) Then
''        txtNetDividend = FormatNumber(CDbl(txtDividendIn(1)) - CDbl(txtDivOthers) - CDbl(txtDivAttrInt), 0)
''    End If
' ''===NgKL End==='
''End Sub

''Private Sub txtDividendIn_GotFocus(Index As Integer)
''    SendKeys "{End}+{Home}"
''End Sub
''
''Private Sub txtDividendIn_KeyPress(Index As Integer, KeyAscii As Integer)
''    On Error Resume Next
''    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
''        KeyAscii = vbKeyCancel
''        Beep
''    End If
''End Sub
''
''Private Sub txtDividendIn_LostFocus(Index As Integer)
''    If Not IsNumeric(txtDividendIn(1)) Then
''        MsgBox "Not a valid number !", vbCritical, "Taxcom"
''        txtDividendIn(1) = 0
''        Exit Sub
''    End If
''    txtDividendIn(1) = FormatNumber(CDbl(txtDividendIn(1)), 0)
''End Sub
''===NgKL C2010==='
''Private Sub txtDivOthers_Change()
''If txtDivOthers = "" Then txtDivOthers = 0
''    If Not IsNumeric(txtDivOthers) Then Exit Sub
''    txtDirExpenses2 = FormatNumber(CDbl(txtDivAttrInt) + CDbl(txtDivOthers), 0)
''    If CDbl(txtDividendIn(1)) <= CDbl(txtDivAttrInt) + CDbl(txtDivOthers) Then
''        txtNetDividend = "0"
''    ElseIf CDbl(txtDividendIn(1)) > CDbl(txtDivAttrInt) + CDbl(txtDivOthers) Then
''        txtNetDividend = FormatNumber(CDbl(txtDividendIn(1)) - CDbl(txtDivOthers) - CDbl(txtDivAttrInt), 0)
''    End If
''End Sub
''===NgKL End==='

'Private Sub txtExpAllowed_Change()
'    If txtExpAllowed = "" Then txtExpAllowed = 0
'    If Not IsNumeric(txtExpAllowed) Then Exit Sub
'    Call total_other_expenses
'End Sub

'Private Sub txtExpAllowed_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtExpAllowed_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtExpAllowed_LostFocus()
'    If Not IsNumeric(txtExpAllowed) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtExpAllowed = 0
'        Exit Sub
'    End If
'    txtExpAllowed = FormatNumber(CDbl(txtExpAllowed), 0)
'    Call InvalidGRelief
'End Sub

'Private Sub txtFoodProduct_Change()
'    If txtFoodProduct = "" Then txtFoodProduct = 0
'    If Not IsNumeric(txtFoodProduct) Then Exit Sub
'    Call total_other_expenses
'End Sub

'Private Sub txtFoodProduct_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtFoodProduct_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtFoodProduct_LostFocus()
'    If Not IsNumeric(txtFoodProduct) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtFoodProduct = 0
'        Exit Sub
'    End If
'    txtFoodProduct = FormatNumber(CDbl(txtFoodProduct), 0)
'    Call InvalidGRelief
'    ' === csNgoh 2008 === '
'    If Val(cYA) >= 2008 Then
'        txtFoodProduct = 0
'    End If
'    ' === end csNgoh 2008 === '
'End Sub

'Private Sub txtForeignChargeable_Change()
'    If txtForeignChargeable = "" Then txtForeignChargeable = 0
'    If Not IsNumeric(txtForeignChargeable) Then Exit Sub
'    Call chargeable_apportionment
'End Sub

'Private Sub txtForeignChargeable_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtForeignChargeable_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtForeignChargeable_LostFocus()
'    If Not IsNumeric(txtForeignChargeable) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtForeignChargeable = 0
'        Exit Sub
'    End If
'    txtForeignChargeable = FormatNumber(CDbl(txtForeignChargeable), 0)
'End Sub

'Private Sub txtInstallments_Change()
'    If txtInstallments = "" Then txtInstallments = 0
'    If Not IsNumeric(txtInstallments) Then Exit Sub
'    txtTPBal = FormatNumber(CDbl(txtInTaxPay) - CDbl(txtInstallments), 2)
'End Sub

'Private Sub txtInstallments_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtInstallments_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtInstallments_LostFocus()
'    If Not IsNumeric(txtInstallments) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtInstallments = 0
'        Exit Sub
'    End If
'    txtInstallments = FormatNumber(CDbl(txtInstallments), 2)
'End Sub

''Private Sub txtIntAttrInt_Change()
''
''If txtIntAttrInt = "" Then txtIntAttrInt = 0
''    If Not IsNumeric(txtIntAttrInt) Then Exit Sub
' ''===NgKL C2010==='
''    txtDirExpenses = FormatNumber(CDbl(txtIntAttrInt) + CDbl(txtIntOthers), 0)
''    If CDbl(txtInterestIn(0)) <= CDbl(txtIntAttrInt) + CDbl(txtIntOthers) Then
''        txtNetIntIn = "0"
''    ElseIf CDbl(txtInterestIn(0)) > CDbl(txtIntAttrInt) + CDbl(txtIntOthers) Then
''        txtNetIntIn = FormatNumber(CDbl(txtInterestIn(0)) - CDbl(txtIntOthers) - CDbl(txtIntAttrInt), 0)
''    End If
' ''===NgKL End==='
''End Sub

''Private Sub txtIntAttrInt_GotFocus()
''    SendKeys "{End}+{Home}"
''End Sub
''
''Private Sub txtIntAttrInt_KeyPress(KeyAscii As Integer)
''    On Error Resume Next
''    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
''        KeyAscii = vbKeyCancel
''        Beep
''    End If
''End Sub
''
''Private Sub txtIntAttrInt_LostFocus()
''    If Not IsNumeric(txtIntAttrInt) Then
''        MsgBox "Not a valid number !", vbCritical, "Taxcom"
''        txtIntAttrInt = 0
''        Exit Sub
''    End If
''    txtIntAttrInt = FormatNumber(CDbl(txtIntAttrInt), 0)
''End Sub
''EN
'Private Sub txtInTaxPay_Change()
'    txtTPBal = FormatNumber(CDbl(txtInTaxPay) - CDbl(txtInstallments), 2)
'    'Pass (Income Tax Payable 2) Income Tax Payble Amount to (Excessive Difference Penalty) Income Tax Payable
'    '==Oscar2009.1=='
'    txtInTaxPay2 = FormatNumber(CDbl(txtInTaxPay), 2)
'    '==End Oscar2009.1=='
'End Sub

''==Oscar2009.1=='Income Tax Payable
'Private Sub txtInTaxPay2_Change()
'    If txtInTaxPay2 = "" Then txtInTaxPay2 = 0
'    If Not IsNumeric(txtInTaxPay2) Then Exit Sub
'    txtInTaxPay2 = FormatNumber((CDbl(txtInTaxPay2)), 2)
'    txtInTaxPay3 = FormatNumber((CDbl(txtInTaxPay2) - CDbl(txtEsTaxPay)), 2)
''==End Oscar2009.1=='
'End Sub

''==Oscar2009.1=='Less: Estimated Tax Payable
'Private Sub txtEsTaxPay_Change()
'    Dim rst2 As New ADODB.Recordset
    
'    If txtEsTaxPay = "" Then txtEsTaxPay = 0
'    If Not IsNumeric(txtEsTaxPay) Then Exit Sub
'    txtInTaxPay3 = FormatNumber((CDbl(txtInTaxPay2) - CDbl(txtEsTaxPay)), 2)
''==End Oscar2009.1=='
'End Sub

''==Oscar2009.1=='TP2 - TP
'Private Sub txtInTaxPay3_Change()
'    If txtInTaxPay3 = "" Then txtInTaxPay3 = 0
'    If Not IsNumeric(txtInTaxPay3) Then Exit Sub
'    txtAllowDiff = FormatNumber((CDbl(txtInTaxPay2) * 0.3), 2)
'    txtExDiff = FormatNumber((CDbl(txtInTaxPay3)) - (CDbl(txtAllowDiff)), 2)
''==End Oscar2009.1=='
'End Sub

''==Oscar2009.1=='Less: Allowable Difference (30% of Tax Payable)
'Private Sub txtAllowDiff_Change()
'    If txtAllowDiff = "" Then txtAllowDiff = 0
'    If Not IsNumeric(txtAllowDiff) Then Exit Sub
'    txtAllowDiff = FormatNumber((CDbl(txtInTaxPay2) * 0.3), 2)
'    txtExDiff = FormatNumber((CDbl(txtInTaxPay3)) - (CDbl(txtAllowDiff)), 2)
''==End Oscar2009.1'==
'End Sub

''==Oscar2009.1=='Excessive Difference
'Private Sub txtExDiff_Change()
'    If txtExDiff = "" Then txtExDiff = 0
'    If Not IsNumeric(txtExDiff) Then Exit Sub

'    If txtExDiff < 0 Then
'        txtExDiff = 0
'    Else
'        txtExDiff = FormatNumber((CDbl(txtExDiff)), 2)
'    End If
'    txtPenOnExDiff = FormatNumber((CDbl(txtExDiff) * 0.1), 2)
''==End Oscar2009.1=='
'End Sub

''==Oscar2009.1=='Income Tax Payable
'Private Sub txtInTaxPay2_GotFocus()
'    SendKeys "{End}+{Home}"
''==End Oscar2009.1=='
'End Sub

' ''==Oscar2009.1=='Less: Estimated Tax Payable
''Private Sub txtEsTaxPay_GotFcus()
''    SendKeys "{End}+{Home}"
' ''==End Oscar2009.1=='
''End Sub

''==Oscar2009.1=='TP2 - TP
'Private Sub txtInTaxPay3_GotFocus()
'    SendKeys "{End}+{Home}"
''==End Oscar2009.1=='
'End Sub

''==Oscar2009.1=='Less: Allowable Difference (30% of Tax Payable)
'Private Sub txtAllowDiff_GotFocus()
'    SendKeys "{End}+{Home}"
''==End Oscar2009.1=='
'End Sub

''==Oscar2009.1=='Excessive Difference
'Private Sub txtExDiff_GotFocus()
'    SendKeys "{End}+{Home}"
''==End Oscar2009.1=='
'End Sub

''==Oscar2009.1=='Income Tax Payable
'Private Sub txtInTaxPay2_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
''==End Oscar2009.1=='
'End Sub

''==Oscar2009.1=='Less: Estimated Tax Payable
'Private Sub txtEsTaxPay_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
''==End Oscar2009.1=='
'End Sub

''==Oscar2009.1=='Less: Estimated Tax Payable
'Private Sub txtInTaxPay3_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
''==End Oscar2009.1=='
'End Sub

''==Oscar2009.1=='Less: Allowable Difference (30% of Tax payable)
'Private Sub txtAllowDiff_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
''==End Oscar2009.1=='
'End Sub

''==Oscar2009.1=='Excessive Difference
'Private Sub txtExDiff_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
''==End Oscar2009.1=='
'End Sub

''==Oscar2009.1=='Income Tax Payable
'Private Sub txtInTaxPay2_LostFocus()
'    If Not IsNumeric(txtInTaxPay2) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtInTaxPay2 = 0
'        Exit Sub
'    End If
'    txtInTaxPay2 = FormatNumber(CDbl(txtInTaxPay2), 2)
''==End Oscar2009.1=='
'End Sub

''==Oscar2009.1=='Less: Estimated Tax Payable
'Private Sub txtEsTaxPay_LostFocus()
'    If Not IsNumeric(txtEsTaxPay) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtEsTaxPay = 0
'        Exit Sub
'    End If
'    'Income Tax Payable - Less: Estimated tax Payable
'    txtEsTaxPay = FormatNumber(CDbl(txtEsTaxPay), 2)
'    txtInTaxPay3 = FormatNumber((CDbl(txtInTaxPay2) - CDbl(txtEsTaxPay)), 2)
''==End Oscar2009.1=='
'End Sub

''==Oscar2009.1=='TP2 - TP
'Private Sub txtInTaxPay3_LostFocus()
'    If Not IsNumeric(txtInTaxPay3) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtInTaxPay3 = 0
'        Exit Sub
'    End If
''==End Oscar2009.1'==
'End Sub

''==Oscar2009.1=='Less: Allowable Difference (30% of tax Payable)
'Private Sub txtAllowDiff_LostFocus()
'    If Not IsNumeric(txtAllowDiff) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtAllowDiff = 0
'        Exit Sub
'    End If
'    txtExDiff = FormatNumber((CDbl(txtInTaxPay3) - CDbl(txtAllowDiff)), 2)
''==End Oscar2009.1=='
'End Sub

''==Oscar2009.1=='Excessive Difference
'Private Sub txtExDiff_LostFocus()
'    If Not IsNumeric(txtExDiff) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtExDiff = 0
'        Exit Sub
'    End If
'    txtPenOnExDiff = FormatNumber((CDbl(txtExDiff) * 10 / 100), 2)
''==End Oscar2009.1=='
'End Sub

''Private Sub txtInterestIn_Change(Index As Integer)
''
''    If txtInterestIn(0) = "" Then txtInterestIn(0) = 0
''    If Not IsNumeric(txtInterestIn(0)) Then Exit Sub
''===NgKL C2010==='
''    If CDbl(txtInterestIn(0)) <= CDbl(txtIntAttrInt) + CDbl(txtIntOthers) Then
''        txtNetIntIn = "0"
''    ElseIf CDbl(txtInterestIn(0)) > CDbl(txtIntAttrInt) + CDbl(txtIntOthers) Then
''        txtNetIntIn = FormatNumber(CDbl(txtInterestIn(0)) - CDbl(txtIntOthers) - CDbl(txtIntAttrInt), 0)
''    End If
''===NgKL End==='
''End Sub

''Private Sub txtInterestIn_GotFocus(Index As Integer)
''    SendKeys "{End}+{Home}"
''End Sub

''Private Sub txtInterestIn_KeyPress(Index As Integer, KeyAscii As Integer)
''    On Error Resume Next
''    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
''        KeyAscii = vbKeyCancel
''        Beep
''    End If
''End Sub

''Private Sub txtInterestIn_LostFocus(Index As Integer)
''    If Not IsNumeric(txtInterestIn(0)) Then
''        MsgBox "Not a valid number !", vbCritical, "Taxcom"
''        txtInterestIn(0) = 0
''        Exit Sub
''    End If
''    txtInterestIn(0) = FormatNumber(CDbl(txtInterestIn(0)), 0)
''End Sub
''===NgKL C2010==='
''Private Sub txtIntOthers_Change()
''If txtIntOthers = "" Then txtIntOthers = 0
''    If Not IsNumeric(txtIntOthers) Then Exit Sub
''    txtDirExpenses = FormatNumber(CDbl(txtIntAttrInt) + CDbl(txtIntOthers), 0)
''    If CDbl(txtInterestIn(0)) <= CDbl(txtIntAttrInt) + CDbl(txtIntOthers) Then
''        txtNetIntIn = "0"
''    ElseIf CDbl(txtInterestIn(0)) > CDbl(txtIntAttrInt) + CDbl(txtIntOthers) Then
''        txtNetIntIn = FormatNumber(CDbl(txtInterestIn(0)) - CDbl(txtIntOthers) - CDbl(txtIntAttrInt), 0)
''    End If
''End Sub
''===NgKL End==='

'Private Sub txtITABalbf_Change()
'    txtITABalReIn = FormatNumber(CDbl(txtITABalbf) + CDbl(txtITAReinvest), 0)
'End Sub

'Private Sub txtITABalReIn_Change()
'    txtITABalcf = FormatNumber(CDbl(txtITABalReIn) - CDbl(txtITAUtilised), 0)
'    'TotalStatIn
'End Sub

'Private Sub txtITAReinvest_Change()
'    If txtITAReinvest = "" Then txtITAReinvest = 0
'    If Not IsNumeric(txtITAReinvest) Then Exit Sub
'    txtITABalReIn = FormatNumber(CDbl(txtITABalbf) + CDbl(txtITAReinvest), 0)
'End Sub

'Private Sub txtITAReinvest_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtITAReinvest_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtITAReinvest_LostFocus()
'    If Not IsNumeric(txtITAReinvest) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtITAReinvest = 0
'        Exit Sub
'    End If
'    txtITAReinvest = FormatNumber(CDbl(txtITAReinvest), 0)
'End Sub

'Private Sub txtITAUtilised_Change()
'    txtITABalcf = FormatNumber(CDbl(txtITABalReIn) - CDbl(txtITAUtilised), 0)
'End Sub

'Private Sub txtITP_Change()
'    If CDbl(txtITP) < 0 Then
'        txtInTaxPay = "0.00"
'    Else
'        txtInTaxPay = FormatNumber(CDbl(txtITP), 2)
'    End If
'End Sub

'Private Sub txtITPChargeableIn1_Change()
'    txtTotalTaxCharged = FormatNumber(CDbl(txtITPChargeableIn1) + CDbl(txtITPChargeableIn2) + CDbl(txtITPChargeableIn3) + CDbl(txtITPChargeableIn4) + CDbl(txtITPChargeableIn4a) + CDbl(txtITPChargeableIn5) + CDbl(txtITPChargeableIn6) + CDbl(txtITPChargeableIn7), 2)
'End Sub

'Private Sub txtITPChargeableIn2_Change()
'    txtTotalTaxCharged = FormatNumber(CDbl(txtITPChargeableIn1) + CDbl(txtITPChargeableIn2) + CDbl(txtITPChargeableIn3) + CDbl(txtITPChargeableIn4) + CDbl(txtITPChargeableIn4a) + CDbl(txtITPChargeableIn5) + CDbl(txtITPChargeableIn6) + CDbl(txtITPChargeableIn7), 2)
'End Sub

'Private Sub txtITPChargeableIn3_Change()
'    txtTotalTaxCharged = FormatNumber(CDbl(txtITPChargeableIn1) + CDbl(txtITPChargeableIn2) + CDbl(txtITPChargeableIn3) + CDbl(txtITPChargeableIn4) + CDbl(txtITPChargeableIn4a) + CDbl(txtITPChargeableIn5) + CDbl(txtITPChargeableIn6) + CDbl(txtITPChargeableIn7), 2)
'    If CDbl(txtITPSetoffOth) <= CDbl(txtITPChargeableIn3) + CDbl(txtITPChargeableIn4) + CDbl(txtITPChargeableIn6) Then
'        txtITPSetoffOth = FormatNumber(CDbl(txtITPSetoffOth), 2)
'    Else
'        txtITPSetoffOth = FormatNumber(CDbl(txtITPChargeableIn3) + CDbl(txtITPChargeableIn4) + CDbl(txtITPChargeableIn6), 2)
'    End If
'End Sub

'Private Sub txtITPChargeableIn4_Change()
'    txtTotalTaxCharged = FormatNumber(CDbl(txtITPChargeableIn1) + CDbl(txtITPChargeableIn2) + CDbl(txtITPChargeableIn3) + CDbl(txtITPChargeableIn4) + CDbl(txtITPChargeableIn4a) + CDbl(txtITPChargeableIn5) + CDbl(txtITPChargeableIn6) + CDbl(txtITPChargeableIn7), 2)
'    If CDbl(txtITPSetoffOth) <= CDbl(txtITPChargeableIn3) + CDbl(txtITPChargeableIn4) + CDbl(txtITPChargeableIn6) Then
'        txtITPSetoffOth = FormatNumber(CDbl(txtITPSetoffOth), 2)
'    Else
'        txtITPSetoffOth = FormatNumber(CDbl(txtITPChargeableIn3) + CDbl(txtITPChargeableIn4) + CDbl(txtITPChargeableIn6), 2)
'    End If
'End Sub

'Private Sub txtITPChargeableIn4a_Change()
'    txtTotalTaxCharged = FormatNumber(CDbl(txtITPChargeableIn1) + CDbl(txtITPChargeableIn2) + CDbl(txtITPChargeableIn3) + CDbl(txtITPChargeableIn4) + CDbl(txtITPChargeableIn4a) + CDbl(txtITPChargeableIn5) + CDbl(txtITPChargeableIn6) + CDbl(txtITPChargeableIn7), 2)
'End Sub

'Private Sub txtITPChargeableIn5_Change()
'    txtTotalTaxCharged = FormatNumber(CDbl(txtITPChargeableIn1) + CDbl(txtITPChargeableIn2) + CDbl(txtITPChargeableIn3) + CDbl(txtITPChargeableIn4) + CDbl(txtITPChargeableIn4a) + CDbl(txtITPChargeableIn5) + CDbl(txtITPChargeableIn6) + CDbl(txtITPChargeableIn7), 2)
'End Sub

'Private Sub txtITPChargeableIn6_Change()
'    txtTotalTaxCharged = FormatNumber(CDbl(txtITPChargeableIn1) + CDbl(txtITPChargeableIn2) + CDbl(txtITPChargeableIn3) + CDbl(txtITPChargeableIn4) + CDbl(txtITPChargeableIn4a) + CDbl(txtITPChargeableIn5) + CDbl(txtITPChargeableIn6) + CDbl(txtITPChargeableIn7), 2)
'    If CDbl(txtITPSetoffOth) <= CDbl(txtITPChargeableIn3) + CDbl(txtITPChargeableIn4) + CDbl(txtITPChargeableIn6) Then
'        txtITPSetoffOth = FormatNumber(CDbl(txtITPSetoffOth), 2)
'    Else
'        txtITPSetoffOth = FormatNumber(CDbl(txtITPChargeableIn3) + CDbl(txtITPChargeableIn4) + CDbl(txtITPChargeableIn6), 2)
'    End If
'End Sub
'Private Sub txtITPChargeableIn7_Change()
'    txtTotalTaxCharged = FormatNumber(CDbl(txtITPChargeableIn1) + CDbl(txtITPChargeableIn2) + CDbl(txtITPChargeableIn3) + CDbl(txtITPChargeableIn4) + CDbl(txtITPChargeableIn4a) + CDbl(txtITPChargeableIn5) + CDbl(txtITPChargeableIn6) + CDbl(txtITPChargeableIn7), 2)
'End Sub
'Private Sub txtITPSetoff_Change()
'    'If txtITPSetoff = "" Then txtITPSetoff = 0 'weihong
'    If Not IsNumeric(txtITPSetoff) Then Exit Sub
'    txtTotalSetoff = FormatNumber(CDbl(txtITPSetoff) + CDbl(txtITPSetoffOth) + CDbl(txt110BSetOff) + CDbl(txtSec132) + CDbl(txtSec133), 2)
'End Sub

'Private Sub txtITPSetoff_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtITPSetoff_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtITPSetoff_LostFocus()
'    If Not IsNumeric(txtITPSetoff) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtITPSetoff = 0
'        Exit Sub
'    End If
'    txtITPSetoff = FormatNumber(CDbl(txtITPSetoff), 2)
'End Sub

'Private Sub txtITPSetoffOth_Change()
'    'If txtITPSetoffOth = "" Then txtITPSetoffOth = 0 'weihong
'    If Not IsNumeric(txtITPSetoffOth) Then Exit Sub
'    txtTotalSetoff = FormatNumber(CDbl(txtITPSetoff) + CDbl(txtITPSetoffOth) + CDbl(txt110BSetOff) + CDbl(txtSec132) + CDbl(txtSec133), 2)
'End Sub

'Private Sub txtITPSetoffOth_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtITPSetoffOth_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtITPSetoffOth_LostFocus()
'    If Not IsNumeric(txtITPSetoffOth) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtITPSetoffOth = 0
'        Exit Sub
'    End If
'    txtITPSetoffOth = FormatNumber(CDbl(txtITPSetoffOth), 2)
'    'weihong + CDbl(txtITPChargeableIn4a)....
'    If CDbl(txtITPSetoffOth) <= CDbl(txtITPChargeableIn3) + CDbl(txtITPChargeableIn4) + CDbl(txtITPChargeableIn6) + CDbl(txtITPChargeableIn4a) + CDbl(txtITPChargeableIn5) + CDbl(txtITPChargeableIn1) + CDbl(txtITPChargeableIn2) Then
'        txtITPSetoffOth = FormatNumber(CDbl(txtITPSetoffOth), 2)
'    Else
'        txtITPSetoffOth = FormatNumber(CDbl(txtITPChargeableIn3) + CDbl(txtITPChargeableIn4) + CDbl(txtITPChargeableIn6), 2)
'    End If
'End Sub


''Private Sub txtNetDividend_Change()
''    If txtNetDividend = "" Then txtNetDividend = 0
''    Call Get_Other_Aggregate
''      Call Get_Other_Aggregate
''    ' === csNgoh 2008 === '
''    If Val(cYA) >= 2008 Then
''        txtSIFrmDiv = txtNetDividend
''    Else
''        txtSIFrmDiv = FormatNumber(0, 2)
''    End If
''    ' === End csNgoh 2008 === '
''End Sub

''Private Sub txtNetIntIn_Change()
''    If txtNetIntIn = "" Then txtNetIntIn = 0
''    Call Get_Other_Aggregate
''End Sub

''Private Sub txtNetRentalIn_Change()
''    If txtNetRentalIn = "" Then txtNetRentalIn = 0
''    Call Get_Other_Aggregate
''End Sub

'Private Sub txtOpHQChargeable_Change()
'    If txtOpHQChargeable = "" Then txtOpHQChargeable = 0
'    If Not IsNumeric(txtOpHQChargeable) Then Exit Sub
'    Call chargeable_apportionment
'End Sub

'Private Sub txtOpHQChargeable_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtOpHQChargeable_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtOpHQChargeable_LostFocus()
'    If Not IsNumeric(txtOpHQChargeable) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtOpHQChargeable = 0
'        Exit Sub
'    End If
'    txtOpHQChargeable = FormatNumber(CDbl(txtOpHQChargeable), 0)
'End Sub

'Private Sub txtOthAggregate_Change()
'    txtAggregateIn = FormatNumber(CDbl(txtAggregate) + CDbl(txtOthAggregate), 0)
'End Sub

'' === csNgoh C2008.5 === '
''Private Sub txtOthers_Change()
''    If txtOthers = "" Then txtOthers = 0
''    If Not IsNumeric(txtOthers) Then Exit Sub
''    txtRentOthExp = FormatNumber(CDbl(txtRentRepair) + CDbl(txtRentRenewal) + CDbl(txtOthers), 0)
''    If CDbl(txtRentalIn) <= CDbl(txtRentAttrIn) + CDbl(txtRentAssess) + CDbl(txtRentQuit) + CDbl(txtRentInsur) + CDbl(txtRentRepair) + CDbl(txtRentRenewal) + CDbl(txtOthers) Then
''        txtNetRentalIn = "0"
''    ElseIf CDbl(txtRentalIn) > CDbl(txtRentAttrIn) + CDbl(txtRentAssess) + CDbl(txtRentQuit) + CDbl(txtRentInsur) + CDbl(txtRentRepair) + CDbl(txtRentRenewal) + CDbl(txtOthers) Then
''        txtNetRentalIn = FormatNumber(CDbl(txtRentalIn) - CDbl(txtRentAttrIn) - CDbl(txtRentAssess) - CDbl(txtRentQuit) - CDbl(txtRentInsur) - CDbl(txtRentRepair) - CDbl(txtRentRenewal) - CDbl(txtOthers), 0)
''    End If
''End Sub
'' === end csNgoh C2008.5 === '

'Private Sub txtPenOnExDiff_Change()
'    txtPenOnExDiff = FormatNumber((CDbl(txtPenOnExDiff)), 2)
'End Sub

'' === csNgoh 2008 ==== '
'Private Sub txtSIFrmDiv_Change()
'    'If txtSIFrmDiv = "" Then txtSIFrmDiv = 0
'    'txtSIFrmDiv = txtNetDividend
'    txtChargeableIn = FormatNumber(CDbl(txtTotalIncome) + CDbl(txtPioneerChargeable) + CDbl(txtSIFrmDiv), 0)
'End Sub
'' === END csNgoh 2008 === '
'Private Sub txtPioneerChargeable_Change()
'    If txtPioneerChargeable = "" Then txtPioneerChargeable = 0
'    If Not IsNumeric(txtPioneerChargeable) Then Exit Sub
'     ' === csNgoh 2008 === '
'    txtChargeableIn = FormatNumber(CDbl(txtTotalIncome) + CDbl(txtPioneerChargeable) + CDbl(txtSIFrmDiv), 0)
'    ' === End csNgoh 2008 === '
'    'txtChargeableIn = FormatNumber(CDbl(txtTotalIncome) + CDbl(txtPioneerChargeable), 0)
'End Sub

'Private Sub txtPioneerChargeable_GotFocus() 'continue here monday
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtPioneerChargeable_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtPioneerChargeable_LostFocus()
'    If Not IsNumeric(txtPioneerChargeable) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtPioneerChargeable = 0
'        Exit Sub
'    End If
'    txtPioneerChargeable = FormatNumber(CDbl(txtPioneerChargeable), 0)
'End Sub

'Private Sub txtPreopBs_Change()
'    If txtPreopBs = "" Then txtPreopBs = 0
'    If Not IsNumeric(txtPreopBs) Then Exit Sub
'    Call total_other_expenses
'End Sub

'Private Sub txtPreopBs_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtPreopBs_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtPreopBs_LostFocus()
'    If Not IsNumeric(txtPreopBs) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtPreopBs = 0
'        Exit Sub
'    End If
'    txtPreopBs = FormatNumber(CDbl(txtPreopBs), 0)
'    Call InvalidGRelief
'End Sub

'Private Sub txtProspecting_Change()
'    If txtProspecting = "" Then txtProspecting = 0
'    If Not IsNumeric(txtProspecting) Then Exit Sub
'    Call total_other_expenses
'End Sub

'Private Sub txtProspecting_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtProspecting_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtProspecting_LostFocus()
'   If Not IsNumeric(txtProspecting) Then
'       MsgBox "Not a valid number !", vbCritical, "Taxcom"
'       txtProspecting = 0
'       Exit Sub
'   End If
'   txtProspecting = FormatNumber(CDbl(txtProspecting), 0)
'   Call InvalidGRelief
'End Sub

'Private Sub txtQualifyAgri_Change()
'    If txtQualifyAgri = "" Then txtQualifyAgri = 0
'    If Not IsNumeric(txtQualifyAgri) Then Exit Sub
'    Call total_other_expenses

'End Sub

'Private Sub txtQualifyAgri_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtQualifyAgri_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtQualifyAgri_LostFocus()
'    If Not IsNumeric(txtQualifyAgri) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtQualifyAgri = 0
'        Exit Sub
'    End If
'    txtQualifyAgri = FormatNumber(CDbl(txtQualifyAgri), 0)
'    ' === csNgoh 2008 === '
'    If Val(cYA) >= 2008 Then
'        txtQualifyAgri = 0
'    End If
'    ' === end csNgoh 2008 ==='
'    Call InvalidGRelief
    
'End Sub

'Private Sub txtRABalbf_Change()
'    txtRABalReIn = FormatNumber(CDbl(txtRABalbf) + CDbl(txtRAReinvest), 0)
'End Sub

'Private Sub txtRABalReIn_Change()
'    txtRABalcf = FormatNumber(CDbl(txtRABalReIn) - CDbl(txtRAUtilised), 0)
'End Sub

'Private Sub txtRAReinvest_Change()
'    If txtRAReinvest = "" Then txtRAReinvest = 0
'    If Not IsNumeric(txtRAReinvest) Then Exit Sub
'    txtRABalReIn = FormatNumber(CDbl(txtRABalbf) + CDbl(txtRAReinvest), 0)
'End Sub

'Private Sub txtRAReinvest_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtRAReinvest_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtRAReinvest_LostFocus()
'    If Not IsNumeric(txtRAReinvest) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtRAReinvest = 0
'        Exit Sub
'    End If
'    txtRAReinvest = FormatNumber(CDbl(txtRAReinvest), 0)
'End Sub

'Private Sub txtRate1_Change()
'    If txtRate1 = "" Then txtRate1 = 0
'    If Not IsNumeric(txtRate1) Then Exit Sub
'    txtITPChargeableIn1 = FormatNumber(CDbl(txtAppChargeableIn1) * (CDbl(txtRate1) / 100), 2)
'End Sub

'Private Sub txtRate1_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtRate1_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtRate1_LostFocus()
'    If Not IsNumeric(txtRate1) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtRate1 = 0
'        Exit Sub
'    End If
'    txtRate1 = FormatNumber(CDbl(txtRate1), 0)
'End Sub

'Private Sub txtRate2_Change()
'    If txtRate2 = "" Then txtRate2 = 0
'    If Not IsNumeric(txtRate2) Then Exit Sub
'    txtITPChargeableIn2 = FormatNumber(CDbl(txtAppChargeableIn2) * (CDbl(txtRate2) / 100), 2)
'End Sub

'Private Sub txtRate2_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtRate2_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtRate2_LostFocus()
'    If Not IsNumeric(txtRate2) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtRate2 = 0
'        Exit Sub
'    End If
'    txtRate2 = FormatNumber(CDbl(txtRate2), 0)
'End Sub

'Private Sub txtRate3_Change()
'    If txtRate3 = "" Then txtRate3 = 0
'    If Not IsNumeric(txtRate3) Then Exit Sub
'    txtITPChargeableIn3 = FormatNumber(CDbl(txtAppChargeableIn3) * (CDbl(txtRate3) / 100), 2)
'End Sub

'Private Sub txtRate3_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtRate3_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtRate3_LostFocus()
'    If Not IsNumeric(txtRate3) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtRate3 = 0
'        Exit Sub
'    End If
'    txtRate3 = FormatNumber(CDbl(txtRate3), 0)
'End Sub

'Private Sub txtRate4_Change()
'    If txtRate4 = "" Then txtRate4 = 0
'    If Not IsNumeric(txtRate4) Then Exit Sub
'    txtITPChargeableIn4 = FormatNumber(CDbl(txtAppChargeableIn4) * (CDbl(txtRate4) / 100), 2)
'End Sub

'Private Sub txtRate4_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtRate4_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtRate4_LostFocus()
'    If Not IsNumeric(txtRate4) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtRate4 = 0
'        Exit Sub
'    End If
'    txtRate4 = FormatNumber(CDbl(txtRate4), 0)
'End Sub

'Private Sub txtRate4a_Change()
'    If txtRate4a = "" Then txtRate4a = 0
'    If Not IsNumeric(txtRate4a) Then Exit Sub
'    txtITPChargeableIn4a = FormatNumber(CDbl(txtAppChargeableIn4a) * (CDbl(txtRate4a) / 100), 2)
'End Sub

'Private Sub txtRate4a_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtRate4a_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtRate4a_LostFocus()
'    If Not IsNumeric(txtRate4a) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtRate4a = 0
'        Exit Sub
'    End If
'    txtRate4a = FormatNumber(CDbl(txtRate4a), 0)
'End Sub

'Private Sub txtRate5_Change()
'    If txtRate5 = "" Then txtRate5 = 0
'    If Not IsNumeric(txtRate5) Then Exit Sub
'    txtITPChargeableIn5 = FormatNumber(CDbl(txtAppChargeableIn5) * (CDbl(txtRate5) / 100), 2)
'End Sub

'Private Sub txtRate5_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtRate5_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtRate5_LostFocus()
'    If Not IsNumeric(txtRate5) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtRate5 = 0
'        Exit Sub
'    End If
'    txtRate5 = FormatNumber(CDbl(txtRate5), 0)
'End Sub

'Private Sub txtRate6_Change()
'    If txtRate6 = "" Then txtRate6 = 0
'    If Not IsNumeric(txtRate6) Then Exit Sub
'    txtITPChargeableIn6 = FormatNumber(CDbl(txtAppChargeableIn6) * (CDbl(txtRate6) / 100), 2)
'End Sub

'Private Sub txtRate6_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtRate6_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtRate6_LostFocus()
'    If Not IsNumeric(txtRate6) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtRate6 = 0
'        Exit Sub
'    End If
'    txtRate6 = FormatNumber(CDbl(txtRate6), 0)
'End Sub

'Private Sub txtRAUtilised_Change()
'    txtRABalcf = FormatNumber(CDbl(txtRABalReIn) - CDbl(txtRAUtilised), 0)
'End Sub

'' === csNgoh C2008.5 === '
''Private Sub txtRentalIn_Change()
''    If txtRentalIn = "" Then txtRentalIn = 0
''    If Not IsNumeric(txtRentalIn) Then Exit Sub
''    If CDbl(txtRentalIn) <= CDbl(txtRentAttrIn) + CDbl(txtRentAssess) + CDbl(txtRentQuit) + CDbl(txtRentInsur) + CDbl(txtRentRepair) + CDbl(txtRentRenewal) + CDbl(txtOthers) Then
''        txtNetRentalIn = "0"
''    ElseIf CDbl(txtRentalIn) > CDbl(txtRentAttrIn) + CDbl(txtRentAssess) + CDbl(txtRentQuit) + CDbl(txtRentInsur) + CDbl(txtRentRepair) + CDbl(txtRentRenewal) + CDbl(txtOthers) Then
''        txtNetRentalIn = FormatNumber(CDbl(txtRentalIn) - CDbl(txtRentAttrIn) - CDbl(txtRentAssess) - CDbl(txtRentQuit) - CDbl(txtRentInsur) - CDbl(txtRentRepair) - CDbl(txtRentRenewal) - CDbl(txtOthers), 0)
''    End If
''End Sub
'' === end csNgoh C2008.5 === '

''Private Sub txtRentalIn_GotFocus()
''    SendKeys "{End}+{Home}"
''End Sub
''
''Private Sub txtRentalIn_KeyPress(KeyAscii As Integer)
''    On Error Resume Next
''    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
''        KeyAscii = vbKeyCancel
''        Beep
''    End If
''End Sub
''
''Private Sub txtRentalIn_LostFocus()
''    If Not IsNumeric(txtRentalIn) Then
''        MsgBox "Not a valid number !", vbCritical, "Taxcom"
''        txtRentalIn = 0
''        Exit Sub
''    End If
''    txtRentalIn = FormatNumber(CDbl(txtRentalIn), 0)
''End Sub

'' === csNgoh C2008.5 === '
''Private Sub txtRentAssess_Change()
''    If txtRentAssess = "" Then txtRentAssess = 0
''    If Not IsNumeric(txtRentAssess) Then Exit Sub
''    If CDbl(txtRentalIn) <= CDbl(txtRentAttrIn) + CDbl(txtRentAssess) + CDbl(txtRentQuit) + CDbl(txtRentInsur) + CDbl(txtRentRepair) + CDbl(txtRentRenewal) + CDbl(txtOthers) Then
''        txtNetRentalIn = "0"
''    ElseIf CDbl(txtRentalIn) > CDbl(txtRentAttrIn) + CDbl(txtRentAssess) + CDbl(txtRentQuit) + CDbl(txtRentInsur) + CDbl(txtRentRepair) + CDbl(txtRentRenewal) + CDbl(txtOthers) Then
''        txtNetRentalIn = FormatNumber(CDbl(txtRentalIn) - CDbl(txtRentAttrIn) - CDbl(txtRentAssess) - CDbl(txtRentQuit) - CDbl(txtRentInsur) - CDbl(txtRentRepair) - CDbl(txtRentRenewal) - CDbl(txtOthers), 0)
''    End If
''End Sub
'' === end csNgoh C2008.5 === '

''Private Sub txtRentAssess_GotFocus()
''    SendKeys "{End}+{Home}"
''End Sub
''
''Private Sub txtRentAssess_KeyPress(KeyAscii As Integer)
''    On Error Resume Next
''    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
''        KeyAscii = vbKeyCancel
''        Beep
''    End If
''End Sub
''
''Private Sub txtRentAssess_LostFocus()
''    If Not IsNumeric(txtRentAssess) Then
''        MsgBox "Not a valid number !", vbCritical, "Taxcom"
''        txtRentAssess = 0
''        Exit Sub
''    End If
''    txtRentAssess = FormatNumber(CDbl(txtRentAssess), 0)
''End Sub

'' === csNgoh C2008.5 === '
''Private Sub txtRentAttrIn_Change()
''    If txtRentAttrIn = "" Then txtRentAttrIn = 0
''    If Not IsNumeric(txtRentAttrIn) Then Exit Sub
''    If CDbl(txtRentalIn) <= CDbl(txtRentAttrIn) + CDbl(txtRentAssess) + CDbl(txtRentQuit) + CDbl(txtRentInsur) + CDbl(txtRentRepair) + CDbl(txtRentRenewal) + CDbl(txtOthers) Then
''        txtNetRentalIn = "0"
''    ElseIf CDbl(txtRentalIn) > CDbl(txtRentAttrIn) + CDbl(txtRentAssess) + CDbl(txtRentQuit) + CDbl(txtRentInsur) + CDbl(txtRentRepair) + CDbl(txtRentRenewal) + CDbl(txtOthers) Then
''        txtNetRentalIn = FormatNumber(CDbl(txtRentalIn) - CDbl(txtRentAttrIn) - CDbl(txtRentAssess) - CDbl(txtRentQuit) - CDbl(txtRentInsur) - CDbl(txtRentRepair) - CDbl(txtRentRenewal) - CDbl(txtOthers), 0)
''    End If
''End Sub
'' === end csNgoh C2008.5 === '

''Private Sub txtRentAttrIn_GotFocus()
''    SendKeys "{End}+{Home}"
''End Sub
''
''Private Sub txtRentAttrIn_KeyPress(KeyAscii As Integer)
''    On Error Resume Next
''    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
''        KeyAscii = vbKeyCancel
''        Beep
''    End If
''End Sub
''
''Private Sub txtRentAttrIn_LostFocus()
''    If Not IsNumeric(txtRentAttrIn) Then
''        MsgBox "Not a valid number !", vbCritical, "Taxcom"
''        txtRentAttrIn = 0
''        Exit Sub
''    End If
''    txtRentAttrIn = FormatNumber(CDbl(txtRentAttrIn), 0)
''End Sub

'' === csNgoh C2008.5 === '
''Private Sub txtRentInsur_Change()
''    If txtRentInsur = "" Then txtRentInsur = 0
''    If Not IsNumeric(txtRentInsur) Then Exit Sub
''    If CDbl(txtRentalIn) <= CDbl(txtRentAttrIn) + CDbl(txtRentAssess) + CDbl(txtRentQuit) + CDbl(txtRentInsur) + CDbl(txtRentRepair) + CDbl(txtRentRenewal) + CDbl(txtOthers) Then
''        txtNetRentalIn = "0"
''    ElseIf CDbl(txtRentalIn) > CDbl(txtRentAttrIn) + CDbl(txtRentAssess) + CDbl(txtRentQuit) + CDbl(txtRentInsur) + CDbl(txtRentRepair) + CDbl(txtRentRenewal) + CDbl(txtOthers) Then
''        txtNetRentalIn = FormatNumber(CDbl(txtRentalIn) - CDbl(txtRentAttrIn) - CDbl(txtRentAssess) - CDbl(txtRentQuit) - CDbl(txtRentInsur) - CDbl(txtRentRepair) - CDbl(txtRentRenewal) - CDbl(txtOthers), 0)
''    End If
''End Sub
'' === csNgoh C2008.5 === '

''Private Sub txtRentInsur_GotFocus()
''    SendKeys "{End}+{Home}"
''End Sub
''
''Private Sub txtRentInsur_KeyPress(KeyAscii As Integer)
''    On Error Resume Next
''    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
''        KeyAscii = vbKeyCancel
''        Beep
''    End If
''End Sub
''
''Private Sub txtRentInsur_LostFocus()
''    If Not IsNumeric(txtRentInsur) Then
''        MsgBox "Not a valid number !", vbCritical, "Taxcom"
''        txtRentInsur = 0
''        Exit Sub
''    End If
''    txtRentInsur = FormatNumber(CDbl(txtRentInsur), 0)
''End Sub
'' === csNgoh C2008.5 === '
''Private Sub txtRentQuit_Change()
''    If txtRentQuit = "" Then txtRentQuit = 0
''    If Not IsNumeric(txtRentQuit) Then Exit Sub
''    If CDbl(txtRentalIn) <= CDbl(txtRentAttrIn) + CDbl(txtRentAssess) + CDbl(txtRentQuit) + CDbl(txtRentInsur) + CDbl(txtRentRepair) + CDbl(txtRentRenewal) + CDbl(txtOthers) Then
''        txtNetRentalIn = "0"
''    ElseIf CDbl(txtRentalIn) > CDbl(txtRentAttrIn) + CDbl(txtRentAssess) + CDbl(txtRentQuit) + CDbl(txtRentInsur) + CDbl(txtRentRepair) + CDbl(txtRentRenewal) + CDbl(txtOthers) Then
''        txtNetRentalIn = FormatNumber(CDbl(txtRentalIn) - CDbl(txtRentAttrIn) - CDbl(txtRentAssess) - CDbl(txtRentQuit) - CDbl(txtRentInsur) - CDbl(txtRentRepair) - CDbl(txtRentRenewal) - CDbl(txtOthers), 0)
''    End If
''End Sub
'' === end csNgoh C2008.5 === '


''Private Sub txtRentQuit_GotFocus()
''    SendKeys "{End}+{Home}"
''End Sub
''
''Private Sub txtRentQuit_KeyPress(KeyAscii As Integer)
''    On Error Resume Next
''    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
''        KeyAscii = vbKeyCancel
''        Beep
''    End If
''End Sub
''
''Private Sub txtRentQuit_LostFocus()
''    If Not IsNumeric(txtRentQuit) Then
''        MsgBox "Not a valid number !", vbCritical, "Taxcom"
''        txtRentQuit = 0
''        Exit Sub
''    End If
''    txtRentQuit = FormatNumber(CDbl(txtRentQuit), 0)
''End Sub

'' === csNgoh C2008.5 === '
''Private Sub txtRentRenewal_Change()
''    If txtRentRenewal = "" Then txtRentRenewal = 0
''    If Not IsNumeric(txtRentRenewal) Then Exit Sub
''    txtRentOthExp = FormatNumber(CDbl(txtRentRepair) + CDbl(txtRentRenewal) + CDbl(txtOthers), 0)
''    If CDbl(txtRentalIn) <= CDbl(txtRentAttrIn) + CDbl(txtRentAssess) + CDbl(txtRentQuit) + CDbl(txtRentInsur) + CDbl(txtRentRepair) + CDbl(txtRentRenewal) + CDbl(txtOthers) Then
''        txtNetRentalIn = "0"
''    ElseIf CDbl(txtRentalIn) > CDbl(txtRentAttrIn) + CDbl(txtRentAssess) + CDbl(txtRentQuit) + CDbl(txtRentInsur) + CDbl(txtRentRepair) + CDbl(txtRentRenewal) + CDbl(txtOthers) Then
''        txtNetRentalIn = FormatNumber(CDbl(txtRentalIn) - CDbl(txtRentAttrIn) - CDbl(txtRentAssess) - CDbl(txtRentQuit) - CDbl(txtRentInsur) - CDbl(txtRentRepair) - CDbl(txtRentRenewal) - CDbl(txtOthers), 0)
''    End If
''End Sub
'' === End csNgoh C2008.5 === '

''Private Sub txtRentRenewal_GotFocus()
''    SendKeys "{End}+{Home}"
''End Sub
''
''Private Sub txtRentRenewal_KeyPress(KeyAscii As Integer)
''    On Error Resume Next
''    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
''        KeyAscii = vbKeyCancel
''        Beep
''    End If
''End Sub
''
''Private Sub txtRentRenewal_LostFocus()
''    If Not IsNumeric(txtRentRenewal) Then
''        MsgBox "Not a valid number !", vbCritical, "Taxcom"
''        txtRentRenewal = 0
''        Exit Sub
''    End If
''    txtRentRenewal = FormatNumber(CDbl(txtRentRenewal), 0)
''End Sub
'' === csNgoh C2008.5 === '
''Private Sub txtRentRepair_Change()
''    If txtRentRepair = "" Then txtRentRepair = 0
''    If Not IsNumeric(txtRentRepair) Then Exit Sub
''    txtRentOthExp = FormatNumber(CDbl(txtRentRepair) + CDbl(txtRentRenewal) + CDbl(txtOthers), 0)
''    If CDbl(txtRentalIn) <= CDbl(txtRentAttrIn) + CDbl(txtRentAssess) + CDbl(txtRentQuit) + CDbl(txtRentInsur) + CDbl(txtRentRepair) + CDbl(txtRentRenewal) + CDbl(txtOthers) Then
''        txtNetRentalIn = "0"
''    ElseIf CDbl(txtRentalIn) > CDbl(txtRentAttrIn) + CDbl(txtRentAssess) + CDbl(txtRentQuit) + CDbl(txtRentInsur) + CDbl(txtRentRepair) + CDbl(txtRentRenewal) + CDbl(txtOthers) Then
''        txtNetRentalIn = FormatNumber(CDbl(txtRentalIn) - CDbl(txtRentAttrIn) - CDbl(txtRentAssess) - CDbl(txtRentQuit) - CDbl(txtRentInsur) - CDbl(txtRentRepair) - CDbl(txtRentRenewal) - CDbl(txtOthers), 0)
''    End If
''End Sub
'' === end csNgoh C2008.5 === '

''Private Sub txtRentRepair_GotFocus()
''    SendKeys "{End}+{Home}"
''End Sub
''
''Private Sub txtRentRepair_KeyPress(KeyAscii As Integer)
''    On Error Resume Next
''    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
''        KeyAscii = vbKeyCancel
''        Beep
''    End If
''End Sub
''
''Private Sub txtRentRepair_LostFocus()
''    If Not IsNumeric(txtRentRepair) Then
''        MsgBox "Not a valid number !", vbCritical, "Taxcom"
''        txtRentRepair = 0
''        Exit Sub
''    End If
''    txtRentRepair = FormatNumber(CDbl(txtRentRepair), 0)
''End Sub

'Private Sub txtRoyaltyIncome_Change()
'    If txtRoyaltyIncome = "" Then txtRoyaltyIncome = 0
'    If Not IsNumeric(txtRoyaltyIncome) Then Exit Sub
'    Call Get_Other_Aggregate
'End Sub

'Private Sub txtRoyaltyIncome_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtRoyaltyIncome_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtRoyaltyIncome_LostFocus()
'    If Not IsNumeric(txtRoyaltyIncome) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtRoyaltyIncome = 0
'        Exit Sub
'    End If
'    txtRoyaltyIncome = FormatNumber(CDbl(txtRoyaltyIncome), 0)
'End Sub

'Private Sub txtSec132_Change()
'    If txtSec132 = "" Then txtSec132 = 0
'    If Not IsNumeric(txtSec132) Then Exit Sub
'    txtTotalSetoff = FormatNumber(CDbl(txtITPSetoff) + CDbl(txtITPSetoffOth) + CDbl(txt110BSetOff) + CDbl(txtSec132) + CDbl(txtSec133), 2)
'End Sub

'Private Sub txtSec132_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtSec132_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtSec132_LostFocus()
'    If Not IsNumeric(txtSec132) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtSec132 = 0
'        Exit Sub
'    End If
'    txtSec132 = FormatNumber(CDbl(txtSec132), 2)
'End Sub

'Private Sub txtSec133_Change()
'    If txtSec133 = "" Then txtSec133 = 0
'    If Not IsNumeric(txtSec133) Then Exit Sub
'    txtTotalSetoff = FormatNumber(CDbl(txtITPSetoff) + CDbl(txtITPSetoffOth) + CDbl(txt110BSetOff) + CDbl(txtSec132) + CDbl(txtSec133), 2)
'End Sub

'Private Sub txtSec133_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtSec133_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtSec133_LostFocus()
'    If Not IsNumeric(txtSec133) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtSec133 = 0
'        Exit Sub
'    End If
'    txtSec133 = FormatNumber(CDbl(txtSec133), 2)
'End Sub

'Private Sub txtSec6BRebate_Change()
'    If txtSec6BRebate = "" Then txtSec6BRebate = 0
'    If Not IsNumeric(txtSec6BRebate) Then Exit Sub
'    Call cal_TotalPayable
'End Sub

'Private Sub cal_TotalPayable()
'    txtITP = FormatNumber(CDbl(txtTotalTaxCharged) - CDbl(txtSec6BRebate) - CDbl(txtTotalSetoff), 2)
' ''    If CDbl(txtITP) < 0 Then
' ''        txtInTaxPay = "0.00"
' ''    Else
' ''        txtInTaxPay = FormatNumber(CDbl(txtITP), 2)
' ''    End If

'End Sub

'Private Sub txtSec6BRebate_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtSec6BRebate_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtSec6BRebate_LostFocus()
'    If Not IsNumeric(txtSec6BRebate) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtSec6BRebate = 0
'        Exit Sub
'    End If
'    txtSec6BRebate = FormatNumber(CDbl(txtSec6BRebate), 2)
'End Sub

'Private Sub txtSrdAmt_Change()
'    If Not IsNumeric(txtSrdAmt) Then Exit Sub
   
'     'txtULBalcf = FormatNumber(CDbl(txtULBalUtil) + CDbl(txtUBL) - CDbl(txtSrdAmt), 0)'
'     ' HS : 2009 : Change Unabsorbed business loss '

'    txtULBalcf = FormatNumber(CDbl(txtULBalUtil) + CDbl(txtUBL) - CDbl(txtSrdAmt) - CDbl(txtCBL), 0)

     
'     txtANCB = FormatNumber(CDbl(txtUBL) - CDbl(txtSrdAmt) - CDbl(txtCBL), 0)
'        If txtANCB < 0 Then
'            txtANCB = 0
'        End If
        
'    txtSrdAmt2 = FormatNumber(CDbl(txtSrdAmt), 0)
'    If txtULBalcf < 0 Then
'    txtULBalcf = 0
'    End If
    
'    txtBalcf = FormatNumber(CDbl(txtULBalcf) - CDbl(txtDisABL), 0)
'    If txtBalcf < 0 Then
'    txtBalcf = 0
'    End If

    
''    If ChkMajorC = 1 Then 'PINP3R2
''    'change
''            txtDisABL = FormatNumber(CDbl(txtULBalcf), 0)
''            txtBalcf = FormatNumber(CDbl(txtULBalcf) - CDbl(txtDisABL), 0)
''    Else
''            txtDisABL = 0
''            txtBalcf = FormatNumber(CDbl(txtULBalcf) - CDbl(txtDisABL), 0)
''    End If
'End Sub

'Private Sub txtSrdAmt_GotFocus()
' SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtSrdAmt_KeyPress(KeyAscii As Integer)
'   On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtSrdAmt_LostFocus()
'   If Not IsNumeric(txtSrdAmt) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtSrdAmt = 0
'        Exit Sub
'    End If
'    txtSrdAmt = FormatNumber(CDbl(txtSrdAmt), 0)
'End Sub

'Private Sub txtSrdAmt2_Change()
'txtBlnCf = FormatNumber(CDbl(txtBlnBf) + CDbl(txtSrdAmt2) - CDbl(txtAmtTut), 0)

'End Sub

''Private Sub txtSundryIn_Change()
''    If txtSundryIn = "" Then txtSundryIn = 0
''    If Not IsNumeric(txtSundryIn) Then Exit Sub
''    '===NgKL 2010.2==='
''    If CDbl(txtSundryIn) <= CDbl(txtDirExpenses3) Then
''        txtNettSundryIn = "0"
''    ElseIf CDbl(txtSundryIn) > CDbl(txtDirExpenses3) Then
''        txtNettSundryIn = FormatNumber(CDbl(txtSundryIn) - CDbl(txtDirExpenses3), 0)
''    End If
''    '===NgKL End==='
''    Call Get_Other_Aggregate
''End Sub

''Private Sub txtSundryIn_GotFocus()
''    SendKeys "{End}+{Home}"
''End Sub

''Private Sub txtSundryIn_KeyPress(KeyAscii As Integer)
''    On Error Resume Next
''    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
''        KeyAscii = vbKeyCancel
''        Beep
''   End If
''End Sub

''Private Sub txtSundryIn_LostFocus()
''    If Not IsNumeric(txtSundryIn) Then
''        MsgBox "Not a valid number !", vbCritical, "Taxcom"
''        txtSundryIn = 0
''        Exit Sub
''    End If
''    txtSundryIn = FormatNumber(CDbl(txtSundryIn), 0)
''End Sub

'Private Sub txtAddition_Change()
'    If txtAddition = "" Then txtAddition = 0
'    If Not IsNumeric(txtAddition) Then Exit Sub
'    Call Get_Other_Aggregate
'End Sub

'Private Sub txtAddition_GotFocus()
'    SendKeys "{End}+{Home}"
'End Sub

'Private Sub txtAddition_KeyPress(KeyAscii As Integer)
'    On Error Resume Next
'    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
'        KeyAscii = vbKeyCancel
'        Beep
'    End If
'End Sub

'Private Sub txtAddition_LostFocus()
'    If Not IsNumeric(txtAddition) Then
'        MsgBox "Not a valid number !", vbCritical, "Taxcom"
'        txtAddition = 0
'        Exit Sub
'    End If
'    txtAddition = FormatNumber(CDbl(txtAddition), 0)
'End Sub

'Private Sub Get_Other_Aggregate()
' ' === csNgoh 2008 === '
'    Dim dblBalance As Double
'    If Val(cYA) >= 2008 Then
'        dblBalance = FormatNumber(CDbl(txtInterestIncome) + CDbl(txtRentalIncome), 0)
'    Else
'        dblBalance = FormatNumber(CDbl(txtDividendIncome) + CDbl(txtInterestIncome) + CDbl(txtRentalIncome), 0)
'    End If
'    ' === End csNgoh 2008 === '
'    txtOthAggregate = FormatNumber(CDbl(dblBalance) + CDbl(txtSundryIncome) + CDbl(txtRoyaltyIncome) + CDbl(txtAddition), 0)
'End Sub

'Private Sub txtSundryIncome_Change()
'    Call Get_Other_Aggregate
'End Sub

''=== CYS 2010 ===
'Private Sub txtTotal_Change()
'    txtAggregate = FormatNumber(CDbl(txtTotal) - CDbl(txtBsLoss), 0)
'    Call txtULBalbf_Change
'End Sub
'' === CYS end 2010 ===

'Private Sub txtTotalIncome_Change()
'  ' === csNgoh 2008 === '
'    txtChargeableIn = FormatNumber(CDbl(txtTotalIncome) + CDbl(txtPioneerChargeable) + CDbl(txtSIFrmDiv), 0)
'    ' === End csNgoh 2008 === '
'    'txtChargeableIn = FormatNumber(CDbl(txtTotalIncome) + CDbl(txtPioneerChargeable), 0)
'End Sub

'Private Sub txtTotalOthExp_Change()
'Dim APDonation As String
'APDonation = 0
'    If cSourceNo = 1 Then
'    ' HS : C2008.7 : Comment due to error in Approved Donation
'        cSQL3 = "SELECT * FROM [PROFIT_LOSS_ACCOUNT] WHERE [PL_REF_NO]='" & Trim(cRefNo) & "' AND [PL_YA]='" & Trim(cYA) & "'"
'        Set rst3 = DB.Execute(cSQL3)
'        If Not rst3.EOF Then
        
'        'HS : C2008.7 : Comment due to error in Approved Donation
'        Call LoadLessApprDonation
'              If TotalCompareAmount >= CDbl(txtTotalOthExp) Then
'                  txtApprDonation = txtTotalOthExp
'              Else
'                  txtApprDonation = FormatNumber(TotalCompareAmount, 0)
'              End If
'        'HS : C2008.7 : Comment due to error in Approved Donation
        
''                ' === csNgoh C2008.6 (SU6) === '
''                If rst3!PL_YA < 2007 Then
''                    APDonation = 0.05
''                ElseIf rst3!PL_YA >= 2007 And rst3!PL_YA < 2009 Then
''                    APDonation = 0.07
''                Else
''                    APDonation = 0.1
''                End If
''                ' === end csNgoh C2008.6 (SU6) === '
''
''            If CDbl(rst3!PL_OTHER_EXP_DNT_APP) < CDbl(txtTotalOthExp) Then
''                If CDbl(rst3!PL_OTHER_EXP_DNT_APP) >= CDbl(txtTotalOthExp) * APDonation Then
''                    txtApprDonation = FormatNumber(CDbl(txtTotalOthExp) * APDonation, 0)
''                ElseIf CDbl(rst3!PL_OTHER_EXP_DNT_APP) < CDbl(txtTotalOthExp) * APDonation Then
''                    txtApprDonation = FormatNumber(CDbl(rst3!PL_OTHER_EXP_DNT_APP), 0)
''                End If
''            ElseIf CDbl(rst3!PL_OTHER_EXP_DNT_APP) >= CDbl(txtTotalOthExp) Then
''                txtApprDonation = FormatNumber(CDbl(txtTotalOthExp) * APDonation, 0)
''            End If
'    ' HS : C2008.7 : Comment due to error in Approved Donation : end

'            'geline: Start: Taxcom C+ v 2005.1
'            dblzakat = 0
'            cSQL4 = "SELECT * FROM [OTHER_EXZAKAT] WHERE [EXOZ_KEY]=" & Trim(rst3![PL_KEY]) & " AND [EXOZ_DEDUCTIBLE]='Yes'"
'            Set rst4 = DB.Execute(cSQL4)
'            If Not rst4.EOF Then
'                Do While Not rst4.EOF
'                    dblzakat = dblzakat + CDbl(rst4![EXOZ_AMOUNT])
'                    rst4.MoveNext
'                Loop
'            End If
'            rst4.Close
            
'            'If CDbl(dblzakat) < CDbl(txtTotalOthExp) Then
'            '    If CDbl(dblzakat) >= CDbl(txtTotalOthExp) * 0.025 Then
'            '        'txtZakat = FormatNumber(CDbl(txtTotalOthExp) * 0.025, 0)
'            '        txtZakat = FormatNumber(Fix(CDbl(txtTotalOthExp) * 0.025), 0)
'            '    ElseIf CDbl(dblzakat) < CDbl(txtTotalOthExp) * 0.025 Then
'            '        'txtZakat = FormatNumber(CDbl(dblzakat), 0)
'            '        txtZakat = FormatNumber(Fix(CDbl(dblzakat)), 0)
'            '    End If
'            'ElseIf CDbl(dblzakat) >= CDbl(txtTotalOthExp) Then
'            '    'txtZakat = FormatNumber(CDbl(txtTotalOthExp) * 0.025, 0)
'            '    txtZakat = FormatNumber(Fix(CDbl(txtTotalOthExp) * 0.025), 0)
'            'End If
'            ''geline: End: Taxcom C+ v 2005.1
            
'            'dannylee 2012 su5.2 - Use Aggregated Income * 2.5%
'            If CDbl(dblzakat) < CDbl(txtAggregateIn) Then
'                If CDbl(dblzakat) >= CDbl(txtAggregateIn) * 0.025 Then
'                    'txtZakat = FormatNumber(CDbl(txtTotalOthExp) * 0.025, 0)
'                    txtZakat = FormatNumber(Fix(CDbl(txtAggregateIn) * 0.025), 0)
'                ElseIf CDbl(dblzakat) < CDbl(txtAggregateIn) * 0.025 Then
'                    'txtZakat = FormatNumber(CDbl(dblzakat), 0)
'                    txtZakat = FormatNumber(Fix(CDbl(dblzakat)), 0)
'                End If
'            ElseIf CDbl(dblzakat) >= CDbl(txtAggregateIn) Then
'                'txtZakat = FormatNumber(CDbl(txtTotalOthExp) * 0.025, 0)
'                txtZakat = FormatNumber(Fix(CDbl(txtAggregateIn) * 0.025), 0)
'            End If
'            'dannylee end
            
'        End If
'        rst3.Close
'    End If
    
    
' ''    txtTotalIncome = FormatNumber(CDbl(txtTotalOthExp) - (CDbl(txtApprDonation) + CDbl(txtZakat) + CDbl(txtClaim)), 0) 'txtClaim
'    Call cal_totalIncome
    
'    ''MsgBox txtTotalIncome
'End Sub

'Private Function InvalidGRelief() As Boolean
'InvalidGRelief = False
'If CDbl(txtClaim.Text) > CDbl(txtTotalOthExp.Text) - CDbl(txtApprDonation.Text) - CDbl(txtZakat.Text) Then
'   MsgBox "Invalid Losses claim under group relief !", vbCritical, "Taxcom"
'   InvalidGRelief = True
'   txtClaim = 0
'   txtClaim.SetFocus
'End If
'End Function

'Private Sub cal_totalIncome()
'txtTotalIncome = FormatNumber(CDbl(txtTotalOthExp) - (CDbl(txtApprDonation) + CDbl(txtZakat) + CDbl(txtClaim)), 0) 'txtClaim
'' HS : 2009 : C2008.7 : Total Income become -ve'
'    If txtTotalIncome < 0 Then
'        txtTotalIncome = 0
'    End If
'' HS : 2009 : C2008.7 : Total Income become -ve end'
'End Sub

'Private Sub txtTotalSetoff_Change()
    
'    ''txtITP = FormatNumber(CDbl(txtTotalTaxCharged) - CDbl(txtSec6BRebate) - CDbl(txtTotalSetoff), 2)
'    Call cal_TotalPayable
'End Sub

'Private Sub txtTotalTaxCharged_Change()
'    ''txtITP = FormatNumber(CDbl(txtTotalTaxCharged) - CDbl(txtSec6BRebate) - CDbl(txtTotalSetoff), 2)
'    Call cal_TotalPayable
'End Sub


'Private Sub txtUBL_Change()
'    'txtULBalcf = FormatNumber(CDbl(txtULBalUtil) + CDbl(txtUBL) - CDbl(txtSrdAmt), 0)'
'    ' HS : 2009 : Change Unabsorbed business loss '
'    txtULBalcf = FormatNumber(CDbl(txtULBalUtil) + CDbl(txtUBL) - CDbl(txtSrdAmt) - CDbl(txtCBL), 0)
    
'    txtANCB = FormatNumber(CDbl(txtUBL) - CDbl(txtSrdAmt) - CDbl(txtCBL), 0)
'    If txtANCB < 0 Then
'        txtANCB = 0
'    End If
        
'    ' === csNgoh Julai 2008 === '
'    If txtUBL = 0 Then
'        txtSrdAmt = 0
'        txtSrdAmt.Locked = True
'        txtSrdAmt.BackColor = &H8000000F
'    Else
'        txtSrdAmt.Locked = False
'        txtSrdAmt.BackColor = &HFFFFFF
'    End If
'    ' === end csNgoh Julai 2008 === '
    
'End Sub

'Private Sub txtULBalbf_Change()

'    Dim rst As New ADODB.Recordset

'    'If CDbl(txtULBalbf) - CDbl(txtDisABL) >= CDbl(txtAllStatIn) Then
'        'txtBsLoss = FormatNumber(CDbl(txtAllStatIn), 0)
'    'ElseIf CDbl(txtULBalbf) - CDbl(txtDisABL) < CDbl(txtAllStatIn) Then
'    '' HS :C2008.7 : Format Number
'        ''txtBsLoss = FormatNumber(CDbl(txtULBalbf), 0) - FormatNumber(CDbl(txtDisABL), 0)
'        'txtBsLoss = FormatNumber(CDbl(txtULBalbf) - CDbl(txtDisABL), 0)
'    'End If
    
'    ' === CYS 2010 ===
'    If CDbl(txtULBalbf) - CDbl(txtDisABL) >= CDbl(txtTotal) Then
'        txtBsLoss = FormatNumber(CDbl(txtTotal), 0)
'    ElseIf CDbl(txtULBalbf) - CDbl(txtDisABL) < CDbl(txtTotal) Then
'        txtBsLoss = FormatNumber(CDbl(txtULBalbf) - CDbl(txtDisABL), 0)
'    End If
'    ' === end CYS 2010 ===
    
'    'Mr Tho formula
'    If CDbl(txtBsLoss) >= CDbl(txtULBalbf) - CDbl(txtDisABL) Then
'    'HS : C2008.7 : Format Number
'        'txtULUtilised = FormatNumber(CDbl(txtULBalbf), 0) - FormatNumber(CDbl(txtDisABL), 0)
'        txtULUtilised = FormatNumber(CDbl(txtULBalbf) - CDbl(txtDisABL), 0)
'    ElseIf CDbl(txtBsLoss) < CDbl(txtULBalbf) - CDbl(txtDisABL) Then
'        txtULUtilised = FormatNumber(CDbl(txtBsLoss), 0)
'    End If
'    txtULBalUtil = FormatNumber(CDbl(txtULBalbf) - CDbl(txtULUtilised), 0)
'End Sub

' ''NGOHCS 2009
'Private Sub txtULBalcf_Change()
'    Dim rst As New ADODB.Recordset
'    txtBalcf = FormatNumber(CDbl(txtULBalcf) - CDbl(txtDisABL), 0)
'    If txtBalcf < 0 Then
'        txtBalcf = 0
'    End If
    
'    If strS60FA = "Y" Then
'        txtULBalcf = 0
'    End If
    
'    txtULBalcf = FormatNumber(CDbl(txtULBalcf), 0)
'End Sub
' ''NGOHCS 2009 END

'Private Sub txtULBalUtil_Change()
'    'txtULBalcf = FormatNumber(CDbl(txtULBalUtil) + CDbl(txtUBL) - CDbl(txtSrdAmt), 0)'
'    ' HS : 2009 : Change Unabsorbed business loss'
'    txtULBalcf = FormatNumber(CDbl(txtULBalUtil) + CDbl(txtUBL) - CDbl(txtSrdAmt) - CDbl(txtCBL), 0)
'    If txtULBalcf < 0 Then
'    txtULBalcf = 0
'    End If
'End Sub

'Private Sub txtULUtilised_Change()
'    txtULBalUtil = FormatNumber(CDbl(txtULBalbf) - CDbl(txtULUtilised), 0)
'End Sub

'Private Sub txtULUtilisedCurr_Change()
'    txtUBL = FormatNumber(CDbl(txtCurrentYrLoss) - CDbl(txtULUtilisedCurr), 0)
'End Sub
'Private Sub INTEREST_RESTRIC() 'C2007.4
'      'SELECT * FROM [REF_INTEREST_RESTRIC] A,[REF_INTEREST_RESTRIC_DETAIL] B WHERE [TP_REF_NO] = '0785981510' AND [YOA] = '2008' AND A.REF_NUM=B.RIR_REF_NUM AND TYPE_INCOME='DIVIDEND INCOME'
'Dim RIRDAMOUNT As Double, INTAMOUNT As Double, RENTALAMOUNT As Double, INVAMOUNT As Double, INVNONAMOUNT As Double, BorrAMOUNT       As Double, INTERESTAMOUNT As Double, TOTALRESTRIC As Double, TOTALRESTRIC1 As Double
'Dim DIVIDEND As Double, Interest As Double, RENTAL As Double
'Dim DIVIDEND1, INTEREST1, RENTAL1 As Double
'Dim plkey As Integer
'Dim InvestmentAMOUNT As Double, BorrowingAMOUNT As Double, ExpensesAMOUNT As Double, DIVIDENDAMOUNT As Double, INTERESTAMOUNT1 As Double, RENTALAMOUNT1 As Double
'Dim TOTALDIVIDEND1 As Double
'Dim TOTALINTEREST1 As Double
'Dim TOTALRENTAL1 As Double
'Dim TOTALDIVIDEND As Double
'Dim TotalInterest As Double
'Dim TotalRental As Double

'TOTALDIVIDEND1 = 0
'TOTALINTEREST1 = 0
'TOTALRENTAL1 = 0
'TOTALDIVIDEND = 0
'TotalInterest = 0
'TotalRental = 0

'        'C2007.4
'  cSQL2 = "SELECT * FROM [TAX_COMPUTATION] WHERE [TC_REF_NO] = '" & txtRefNo & "' AND [TC_YA] = '" & txtYA & "' ORDER BY TC_BUSINESS"
'  Set rst2 = DB.Execute(cSQL2)
'    If Not rst2.EOF Then
'    While Not rst2.EOF
      
'       'For X = 1 To 12
'       For X = 1 To 18
       
'RIRDAMOUNT = 0
'INTAMOUNT = 0
'RENTALAMOUNT = 0
'INVAMOUNT = 0
'INVNONAMOUNT = 0
'BorrAMOUNT = 0
'INTERESTAMOUNT = 0
'TOTALRESTRIC = 0
'TOTALRESTRIC1 = 0
'DIVIDEND = 0
'Interest = 0
'RENTAL = 0
        
'       cSQL = "SELECT * FROM [REF_INTEREST_RESTRIC]A,[REF_INTEREST_RESTRIC_DETAIL] B WHERE [TP_REF_NO] = '" & txtRefNo & "' AND [YOA] = '" & txtYA & "' AND A.REF_NUM=B.RIR_REF_NUM AND TYPE_INCOME='DIVIDEND INCOME' AND TYPE='Inv' AND RIRD_SOURCENO= " & rst2!TC_BUSINESS & " And RIRD_MONTH = '" & X & "'"
'       Set rst = DB.Execute(cSQL)
'       If Not rst.EOF Then
'           While Not rst.EOF
'              RIRDAMOUNT = RIRDAMOUNT + CDbl(rst!RIRD_AMOUNT)
'           rst.MoveNext
'           Wend
'       End If
'       rst.Close
       
'       cSQL = "SELECT * FROM [REF_INTEREST_RESTRIC]A,[REF_INTEREST_RESTRIC_DETAIL] B WHERE [TP_REF_NO] = '" & txtRefNo & "' AND [YOA] = '" & txtYA & "' AND A.REF_NUM=B.RIR_REF_NUM AND TYPE_INCOME='INTEREST INCOME' AND TYPE='Inv'AND RIRD_SOURCENO= " & rst2!TC_BUSINESS & " And RIRD_MONTH = '" & X & "'"
'       Set rst = DB.Execute(cSQL)
'       If Not rst.EOF Then
'           While Not rst.EOF
'              INTAMOUNT = INTAMOUNT + CDbl(rst!RIRD_AMOUNT)
'           rst.MoveNext
'           Wend
'       End If
'       rst.Close

'       cSQL = "SELECT * FROM [REF_INTEREST_RESTRIC]A,[REF_INTEREST_RESTRIC_DETAIL] B WHERE [TP_REF_NO] = '" & txtRefNo & "' AND [YOA] = '" & txtYA & "' AND A.REF_NUM=B.RIR_REF_NUM AND TYPE_INCOME='RENTAL INCOME' AND TYPE='Inv' AND RIRD_SOURCENO= " & rst2!TC_BUSINESS & " And RIRD_MONTH = '" & X & "'"
'       Set rst = DB.Execute(cSQL)
'       If Not rst.EOF Then
'           While Not rst.EOF
'              RENTALAMOUNT = RENTALAMOUNT + CDbl(rst!RIRD_AMOUNT)
'           rst.MoveNext
'           Wend
'       End If
'       rst.Close

       
'       cSQL = "SELECT * FROM [REF_INTEREST_RESTRIC]A,[REF_INTEREST_RESTRIC_DETAIL] B WHERE [TP_REF_NO] = '" & txtRefNo & "' AND [YOA] = '" & txtYA & "' AND A.REF_NUM=B.RIR_REF_NUM AND TYPE='Inv' AND RIRD_SOURCENO= " & rst2!TC_BUSINESS & " And RIRD_MONTH = '" & X & "'"
'       Set rst = DB.Execute(cSQL)
'       If Not rst.EOF Then
'           While Not rst.EOF
'              INVAMOUNT = INVAMOUNT + CDbl(rst!RIRD_AMOUNT)
'           rst.MoveNext
'           Wend
'       End If
'       rst.Close
       
'        cSQL = "SELECT * FROM [REF_INTEREST_RESTRIC]A,[REF_INTEREST_RESTRIC_DETAIL] B WHERE [TP_REF_NO] = '" & txtRefNo & "' AND [YOA] = '" & txtYA & "' AND A.REF_NUM=B.RIR_REF_NUM AND TYPE='InvNon' AND RIRD_SOURCENO= " & rst2!TC_BUSINESS & " And RIRD_MONTH = '" & X & "'"
'       Set rst = DB.Execute(cSQL)
'       If Not rst.EOF Then
'           While Not rst.EOF
'              INVNONAMOUNT = INVNONAMOUNT + CDbl(rst!RIRD_AMOUNT)
'           rst.MoveNext
'           Wend
'       End If
'       rst.Close
       
       
       
'       cSQL = "SELECT * FROM [REF_INTEREST_RESTRIC]A,[REF_INTEREST_RESTRIC_DETAIL] B WHERE [TP_REF_NO] = '" & txtRefNo & "' AND [YOA] = '" & txtYA & "' AND A.REF_NUM=B.RIR_REF_NUM AND TYPE='Borr' AND RIRD_SOURCENO= " & rst2!TC_BUSINESS & " And RIRD_MONTH = '" & X & "'"
'       Set rst = DB.Execute(cSQL)
'       If Not rst.EOF Then
'           While Not rst.EOF
'              BorrAMOUNT = BorrAMOUNT + CDbl(rst!RIRD_AMOUNT)
'           rst.MoveNext
'           Wend
'       End If
'       rst.Close
       
'       cSQL = "SELECT * FROM [REF_INTEREST_RESTRIC]A,[REF_INTEREST_RESTRIC_DETAIL] B WHERE [TP_REF_NO] = '" & txtRefNo & "' AND [YOA] = '" & txtYA & "' AND A.REF_NUM=B.RIR_REF_NUM AND TYPE='Interest' AND RIRD_SOURCENO= " & rst2!TC_BUSINESS & " And RIRD_MONTH = '" & X & "'"
'       Set rst = DB.Execute(cSQL)
'       If Not rst.EOF Then
'           While Not rst.EOF
'              INTERESTAMOUNT = INTERESTAMOUNT + CDbl(rst!RIRD_AMOUNT)
'           rst.MoveNext
'           Wend
'       End If
'       rst.Close
   
       
'            If (INVAMOUNT + INVNONAMOUNT) < BorrAMOUNT Then
'                If BorrAMOUNT <> 0 Then
'                    TOTALRESTRIC = (INVAMOUNT + INVNONAMOUNT) / BorrAMOUNT * INTERESTAMOUNT
'                End If
'            Else
'            TOTALRESTRIC = INTERESTAMOUNT
'            End If
            
'            If INVAMOUNT + INVNONAMOUNT <> 0 Then
            
'                DIVIDEND = RIRDAMOUNT / (INVAMOUNT + INVNONAMOUNT) * TOTALRESTRIC
'                Interest = INTAMOUNT / (INVAMOUNT + INVNONAMOUNT) * TOTALRESTRIC
'                RENTAL = RENTALAMOUNT / (INVAMOUNT + INVNONAMOUNT) * TOTALRESTRIC
'                TOTALDIVIDEND = TOTALDIVIDEND + DIVIDEND
'                TotalInterest = TotalInterest + Interest
'                TotalRental = TotalRental + RENTAL
'            End If
            
'      Next
       
       
       

' '''       cSQL = "SELECT * FROM [REF_INTEREST_RESTRIC]A,[REF_INTEREST_RESTRIC_DETAIL] B WHERE [TP_REF_NO] = '" & txtRefNo & "' AND [YOA] = '" & txtYA & "' AND A.REF_NUM=B.RIR_REF_NUM AND TYPE_INCOME='DIVIDEND INCOME' AND TYPE='Inv' AND RIRD_SOURCENO= " & rst2!TC_BUSINESS
' '''       Set rst = DB.Execute(cSQL)
' '''       If Not rst.EOF Then
' '''           While Not rst.EOF
' '''              RIRDAMOUNT = RIRDAMOUNT + CDbl(rst!RIRD_AMOUNT)
' '''           rst.MoveNext
' '''           Wend
' '''       End If
' '''       rst.Close
' '''
' '''        cSQL = "SELECT * FROM [REF_INTEREST_RESTRIC]A,[REF_INTEREST_RESTRIC_DETAIL] B WHERE [TP_REF_NO] = '" & txtRefNo & "' AND [YOA] = '" & txtYA & "' AND A.REF_NUM=B.RIR_REF_NUM AND TYPE_INCOME='INTEREST INCOME' AND TYPE='Inv'AND RIRD_SOURCENO= " & rst2!TC_BUSINESS
' '''       Set rst = DB.Execute(cSQL)
' '''       If Not rst.EOF Then
' '''           While Not rst.EOF
' '''              INTAMOUNT = INTAMOUNT + CDbl(rst!RIRD_AMOUNT)
' '''           rst.MoveNext
' '''           Wend
' '''       End If
' '''       rst.Close
' '''
' '''       cSQL = "SELECT * FROM [REF_INTEREST_RESTRIC]A,[REF_INTEREST_RESTRIC_DETAIL] B WHERE [TP_REF_NO] = '" & txtRefNo & "' AND [YOA] = '" & txtYA & "' AND A.REF_NUM=B.RIR_REF_NUM AND TYPE_INCOME='RENTAL INCOME' AND TYPE='Inv' AND RIRD_SOURCENO= " & rst2!TC_BUSINESS
' '''       Set rst = DB.Execute(cSQL)
' '''       If Not rst.EOF Then
' '''           While Not rst.EOF
' '''              RENTALAMOUNT = RENTALAMOUNT + CDbl(rst!RIRD_AMOUNT)
' '''           rst.MoveNext
' '''           Wend
' '''       End If
' '''       rst.Close
' '''
            
' '''''      cSQL = "SELECT * FROM [REF_INTEREST_RESTRIC]A,[REF_INTEREST_RESTRIC_DETAIL] B WHERE [TP_REF_NO] = '" & txtRefNo & "' AND [YOA] = '" & txtYA & "' AND A.REF_NUM=B.RIR_REF_NUM AND TYPE='Inv' AND RIRD_SOURCENO= " & rst2!TC_BUSINESS
' '''''       Set rst = DB.Execute(cSQL)
' '''''       If Not rst.EOF Then
' '''''           While Not rst.EOF
' '''''              INVAMOUNT = INVAMOUNT + CDbl(rst!RIRD_AMOUNT)
' '''''           rst.MoveNext
' '''''           Wend
' '''''       End If
' '''''       rst.Close
' '''''
' '''''       cSQL = "SELECT * FROM [REF_INTEREST_RESTRIC]A,[REF_INTEREST_RESTRIC_DETAIL] B WHERE [TP_REF_NO] = '" & txtRefNo & "' AND [YOA] = '" & txtYA & "' AND A.REF_NUM=B.RIR_REF_NUM AND TYPE='InvNon' AND RIRD_SOURCENO= " & rst2!TC_BUSINESS
' '''''       Set rst = DB.Execute(cSQL)
' '''''       If Not rst.EOF Then
' '''''           While Not rst.EOF
' '''''              INVNONAMOUNT = INVNONAMOUNT + CDbl(rst!RIRD_AMOUNT)
' '''''           rst.MoveNext
' '''''           Wend
' '''''       End If
' '''''       rst.Close
' '''''
' '''''     cSQL = "SELECT * FROM [REF_INTEREST_RESTRIC]A,[REF_INTEREST_RESTRIC_DETAIL] B WHERE [TP_REF_NO] = '" & txtRefNo & "' AND [YOA] = '" & txtYA & "' AND A.REF_NUM=B.RIR_REF_NUM AND TYPE='Borr' AND RIRD_SOURCENO= " & rst2!TC_BUSINESS
' '''''       Set rst = DB.Execute(cSQL)
' '''''       If Not rst.EOF Then
' '''''           While Not rst.EOF
' '''''              BorrAMOUNT = BorrAMOUNT + CDbl(rst!RIRD_AMOUNT)
' '''''           rst.MoveNext
' '''''           Wend
' '''''       End If
' '''''       rst.Close
' '''''
' '''''       cSQL = "SELECT * FROM [REF_INTEREST_RESTRIC]A,[REF_INTEREST_RESTRIC_DETAIL] B WHERE [TP_REF_NO] = '" & txtRefNo & "' AND [YOA] = '" & txtYA & "' AND A.REF_NUM=B.RIR_REF_NUM AND TYPE='Interest' AND RIRD_SOURCENO= " & rst2!TC_BUSINESS
' '''''       Set rst = DB.Execute(cSQL)
' '''''       If Not rst.EOF Then
' '''''           While Not rst.EOF
' '''''              INTERESTAMOUNT = INTERESTAMOUNT + CDbl(rst!RIRD_AMOUNT)
' '''''           rst.MoveNext
' '''''           Wend
' '''''       End If
' '''''       rst.Close
' '''''
' '''''       cSQL = "SELECT * FROM [REF_INTEREST_RESTRIC]A,[REF_INTEREST_RESTRIC_DETAIL] B WHERE [TP_REF_NO] = '" & txtRefNo & "' AND [YOA] = '" & txtYA & "' AND A.REF_NUM=B.RIR_REF_NUM  AND RIRD_SOURCENO= " & rst2!TC_BUSINESS
' '''''       Set rst = DB.Execute(cSQL)
' '''''       If Not rst.EOF Then
' '''''            If (INVAMOUNT + INVNONAMOUNT) < BorrAMOUNT Then
' '''''                If BorrAMOUNT <> 0 Then
' '''''                    TOTALRESTRIC = (INVAMOUNT + INVNONAMOUNT) / BorrAMOUNT * INTERESTAMOUNT
' '''''                End If
' '''''            Else
' '''''            TOTALRESTRIC = INTERESTAMOUNT
' '''''            End If
' '''''            If INVAMOUNT + INVNONAMOUNT <> 0 Then
' '''''                DIVIDEND = RIRDAMOUNT / (INVAMOUNT + INVNONAMOUNT) * TOTALRESTRIC
' '''''                Interest = INTAMOUNT / (INVAMOUNT + INVNONAMOUNT) * TOTALRESTRIC
' '''''                RENTAL = RENTALAMOUNT / (INVAMOUNT + INVNONAMOUNT) * TOTALRESTRIC
' '''''                TOTALDIVIDEND = TOTALDIVIDEND + DIVIDEND
' '''''                TotalInterest = TotalInterest + Interest
' '''''                TOTALRENTAL = TOTALRENTAL + RENTAL
' '''''            End If
' '''''       End If
' '''''       rst.Close
       
       
'InvestmentAMOUNT = 0
'BorrowingAMOUNT = 0
'ExpensesAMOUNT = 0
'DIVIDENDAMOUNT = 0
'INTERESTAMOUNT1 = 0
'RENTALAMOUNT1 = 0
'DIVIDEND1 = 0
'INTEREST1 = 0
'RENTAL1 = 0
       
'       cSQL = "SELECT [PL_KEY] FROM [PROFIT_LOSS_ACCOUNT] WHERE [PL_REF_NO] = '" & txtRefNo & "' AND [PL_YA] = '" & txtYA & "' "
'       Set rst = DB.Execute(cSQL)
'       If Not rst.EOF Then
        
'         plkey = rst!PL_KEY
'            cSQL1 = "SELECT * FROM [REF_INTEREST_RESTRIC_DETAIL]  WHERE [RIRD_KEY]= " & plkey & " AND RIRD_TYPE='Investment' AND RIRD_SOURCENO= " & rst2!TC_BUSINESS
'            Set rst1 = DB.Execute(cSQL1)
'            While Not rst1.EOF
'              InvestmentAMOUNT = InvestmentAMOUNT + CDbl(rst1!RIRD_AMOUNT)
'              rst1.MoveNext
'            Wend
'            rst1.Close
            
'            cSQL1 = "SELECT * FROM [REF_INTEREST_RESTRIC_DETAIL]  WHERE [RIRD_KEY]= " & plkey & " AND RIRD_TYPE='Borrowing' AND RIRD_SOURCENO= " & rst2!TC_BUSINESS
'            Set rst1 = DB.Execute(cSQL1)
'            While Not rst1.EOF
'              BorrowingAMOUNT = BorrowingAMOUNT + CDbl(rst1!RIRD_AMOUNT)
'              rst1.MoveNext
'            Wend
'            rst1.Close
            
'            cSQL1 = "SELECT * FROM [REF_INTEREST_RESTRIC_DETAIL]  WHERE [RIRD_KEY]= " & plkey & " AND RIRD_TYPE='Expenses' AND RIRD_SOURCENO= " & rst2!TC_BUSINESS
'            Set rst1 = DB.Execute(cSQL1)
'            While Not rst1.EOF
'              ExpensesAMOUNT = ExpensesAMOUNT + CDbl(rst1!RIRD_AMOUNT)
'              rst1.MoveNext
'            Wend
'            rst1.Close
            
''            cSQL1 = "SELECT * FROM [REF_INTEREST_RESTRIC_DETAIL]  WHERE [RIRD_KEY]= " & plkey
''            Set rst1 = DB.Execute(cSQL1)
'            cSQL1 = "SELECT * FROM [REF_INTEREST_RESTRIC_DETAIL]  WHERE [RIRD_KEY]= " & plkey & " AND RIRD_TYPE='Expenses' AND RIRD_SOURCENO= " & rst2!TC_BUSINESS
'            Set rst1 = DB.Execute(cSQL1)
'            If Not rst1.EOF Then
'                If InvestmentAMOUNT < BorrowingAMOUNT Then
'                    If BorrowingAMOUNT <> 0 Then
'                        TOTALRESTRIC1 = InvestmentAMOUNT / BorrowingAMOUNT * ExpensesAMOUNT
'                    End If
'                Else
'                    TOTALRESTRIC1 = ExpensesAMOUNT
'                End If
'            End If
'            rst1.Close
            
            
'            cSQL1 = "SELECT * FROM [REF_INTEREST_RESTRIC_DETAIL]  WHERE [RIRD_KEY]= " & plkey & " AND RIRD_TYPE='Investment' AND RIRD_TYPE_INCOME='DIVIDEND INCOME' AND RIRD_SOURCENO= " & rst2!TC_BUSINESS
'            Set rst1 = DB.Execute(cSQL1)
'            While Not rst1.EOF
'              DIVIDENDAMOUNT = DIVIDENDAMOUNT + CDbl(rst1!RIRD_AMOUNT)
'              rst1.MoveNext
'            Wend
'            rst1.Close
           
             
'             cSQL1 = "SELECT * FROM [REF_INTEREST_RESTRIC_DETAIL]  WHERE [RIRD_KEY]= " & plkey & " AND RIRD_TYPE='Investment' AND RIRD_TYPE_INCOME='INTEREST INCOME' AND RIRD_SOURCENO= " & rst2!TC_BUSINESS
'            Set rst1 = DB.Execute(cSQL1)
'            While Not rst1.EOF
'              INTERESTAMOUNT1 = INTERESTAMOUNT1 + CDbl(rst1!RIRD_AMOUNT)
'              rst1.MoveNext
'            Wend
'            rst1.Close
            
'            cSQL1 = "SELECT * FROM [REF_INTEREST_RESTRIC_DETAIL]  WHERE [RIRD_KEY]= " & plkey & " AND RIRD_TYPE='Investment' AND RIRD_TYPE_INCOME='RENTAL INCOME' AND RIRD_SOURCENO= " & rst2!TC_BUSINESS
'            Set rst1 = DB.Execute(cSQL1)
'            While Not rst1.EOF
'              RENTALAMOUNT1 = RENTALAMOUNT1 + CDbl(rst1!RIRD_AMOUNT)
'              rst1.MoveNext
'            Wend
'            rst1.Close
            
''            cSQL1 = "SELECT * FROM [REF_INTEREST_RESTRIC_DETAIL]  WHERE [RIRD_KEY]= " & plkey
''            Set rst1 = DB.Execute(cSQL1)
'                If InvestmentAMOUNT <> 0 Then
'                    DIVIDEND1 = DIVIDENDAMOUNT / InvestmentAMOUNT * TOTALRESTRIC1
'                    INTEREST1 = INTERESTAMOUNT1 / InvestmentAMOUNT * TOTALRESTRIC1
'                    RENTAL1 = RENTALAMOUNT1 / InvestmentAMOUNT * TOTALRESTRIC1
'                    TOTALDIVIDEND1 = TOTALDIVIDEND1 + DIVIDEND1
'                    TOTALINTEREST1 = TOTALINTEREST1 + INTEREST1
'                    TOTALRENTAL1 = TOTALRENTAL1 + RENTAL1
'                End If
       
       
'       End If
'       rst.Close
       
'rst2.MoveNext
'Wend

'End If

'    Dim DivAttrInt As Double
'    Dim IntAttrInt As Double
'    Dim RentAttrIn As Double
    
''    Dim dblRental As Double
''    Dim dblDividend As Double
''    Dim dblInterest As Double
''
''    Dim dblAttributable  As Double
''
''    cSQL = "SELECT TC_NB_DIV, TC_NB_RENT, TC_NB_INT FROM TAX_COMPUTATION WHERE TC_KEY = " & vIncomeCalKey
''    Set rst = DB.Execute(cSQL)
''    If Not rst.EOF Then
''        dblRental = CDbl(rst!TC_NB_RENT)
''        dblDividend = CDbl(rst!TC_NB_DIV)
''        dblInterest = CDbl(rst!TC_NB_INT)
''    End If
''    rst.Close
    
'       DivAttrInt = FormatNumber(TOTALDIVIDEND + TOTALDIVIDEND1, 0)
'       IntAttrInt = FormatNumber(TotalInterest + TOTALINTEREST1, 0)
'       RentAttrIn = FormatNumber(TotalRental + TOTALRENTAL1, 0)
       
'       ' === csNgoh C2008.5 , csNgoh C2008.6 (SU6) === '
'       'If DivAttrInt <> 0 Then
       
'       If DivAttrInt < FormatNumber(txtDividendIn, 0) Then
'            txtDivAttrInt = FormatNumber(TOTALDIVIDEND + TOTALDIVIDEND1, 0)
'       Else
'            txtDivAttrInt = FormatNumber(txtDividendIn, 0)
'       End If
'        cSQL = "UPDATE [TAX_COMPUTATION] SET  [TC_NB_DIV_ATT_INT]='" & txtDivAttrInt & "'" & _
'               " WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' AND [TC_BUSINESS]=1"
'         DB.Execute (cSQL)
'       'End If
       
       
'       'If IntAttrInt <> 0 Then
'       If IntAttrInt < FormatNumber(txtInterestIn, 0) Then
'            txtIntAttrInt = FormatNumber(TotalInterest + TOTALINTEREST1, 0)
'       Else
'            txtIntAttrInt = FormatNumber(txtInterestIn, 0)
'       End If
'        cSQL = "UPDATE [TAX_COMPUTATION] SET   [TC_NB_INT_ATT_INT]='" & txtIntAttrInt & "'" & _
'               " WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' AND [TC_BUSINESS]=1"
'         DB.Execute (cSQL)
'       'End If
       
       
'       'If RentAttrIn <> 0 Then
'       If RentAttrIn <= FormatNumber(CDbl(txtRentalIn) + CDbl(txtRentalInIBA), 0) Then
'            If RentAttrIn >= CDbl(txtRentAttrIn) + CDbl(txtRentAttrInIBA) Then
'                txtRentAttrIn = FormatNumber(TotalRental + TOTALRENTAL1 - CDbl(txtRentAttrInIBA), 0)
'            Else
'                If RentAttrIn < CDbl(txtRentAttrInIBA) Then
'                    txtRentAttrInIBA = 0
'                    txtRentAttrIn = FormatNumber(TotalRental + TOTALRENTAL1, 0)
'                Else
'                    txtRentAttrIn = FormatNumber(TotalRental + TOTALRENTAL1 - CDbl(txtRentAttrInIBA), 0)
'                End If
'            End If
'            'txtRentAttrIn = FormatNumber(TotalRental + TOTALRENTAL1 - CDbl(txtRentAttrInIBA), 0)
'       Else
'            txtRentAttrInIBA = 0
'            txtRentAttrIn = FormatNumber(CDbl(txtRentalIn) + CDbl(txtRentalInIBA), 0)
'       End If
'        cSQL = "UPDATE [TAX_COMPUTATION] SET [TC_NB_RENT_ATT_INT]='" & txtRentAttrIn & "'" & _
'               " WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' AND [TC_BUSINESS]=1"
'         DB.Execute (cSQL)
       
'       'End If
'       ' === End csNgoh C2008.5 , End csNgoh C2008.6 (SU6) === '
       
''       If DivAttrInt <> 0 Or IntAttrInt <> 0 Or RentAttrIn <> 0 Then
''
''       txtDivAttrInt = FormatNumber(TOTALDIVIDEND + TOTALDIVIDEND1, 0)
''       txtIntAttrInt = FormatNumber(TotalInterest + TOTALINTEREST1, 0)
''       txtRentAttrIn = FormatNumber(TOTALRENTAL + TOTALRENTAL1, 0)
''
''         cSQL = "UPDATE [TAX_COMPUTATION] SET  [TC_NB_DIV_ATT_INT]='" & txtDivAttrInt & "' AND [TC_NB_INT_ATT_INT]='" & txtIntAttrInt & "' AND [TC_NB_RENT_ATT_INT]='" & txtRentAttrIn & "'" & _
''               " WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' AND [TC_BUSINESS]=1"
''         DB.Execute (cSQL)
''
''      End If
       
       
''[TC_NB_DIV_ATT_INT]='" & txtDivAttrInt
''
''
''[TC_NB_INT_ATT_INT]='" & txtIntAttrInt
''[TC_NB_RENT_ATT_INT]='" & txtRentAttrIn &

'End Sub
'Private Sub total_other_expenses()
'    txtTotalOthExp = FormatNumber(CDbl(txtAggrLoss) - (CDbl(txtProspecting) + CDbl(txtQualifyAgri) + CDbl(txtPreopBs) + CDbl(txtFoodProduct) + CDbl(txtExpAllowed)), 0)
'    If CDbl(txtTotalOthExp) < 0 Then
'        txtTotalOthExp = "0"
'        txtApprDonation = "0"
'        txtZakat = "0"
'    End If
'End Sub

'Public Sub ToUpdate_IncomeCalc()
''-==amy
'Dim amyrst As ADODB.Recordset
'Dim rstos As ADODB.Recordset
'Dim BS As Integer
'Dim i As Integer
'i = 1

'Dim CAYear As String
'' === csNgoh Julai 2008 === '
'Dim Balancecf As Double
'Dim ActualBalancebf As Double
'' === end csNgoh Julai 2008 === '
'Dim cSQL11 As String

'    '==Oscar2009.1=='
'    Dim rstS60FA As New ADODB.Recordset
'    Dim strS60FA As String
    
'    cSQL3 = "SELECT * FROM [PROFIT_LOSS_ACCOUNT] WHERE [PL_REF_NO] = '" & txtRefNo & "' AND [PL_YA] = '" & txtYA & "'"
'    Set rstS60FA = DB.Execute(cSQL3)
'    If Not rstS60FA.EOF Then
'        strS60FA = rstS60FA!PL_S60FA
'    End If
'    rstS60FA.Close
'    '==End Oscar2009.1=='

'cSQL = "SELECT * FROM [TAX_COMPUTATION] WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' Order By TC_BUSINESS"
'Set amyrst = DB.Execute(cSQL)

'    Do While Not amyrst.EOF
'        BS = Val(amyrst!TC_BUSINESS)
'        'CAYear = CDbl(amyrst!TC_CB_CA_AA) + CDbl(amyrst!TC_CB_CA_IA) + CDbl(amyrst!TC_CB_CA_BA) - CDbl(amyrst!TC_CB_CA_NA)
'        If lstViewCA.ListItems.count >= i Then
'        CAYear = CDbl(lstViewCA.ListItems(i).ListSubItems(3)) + CDbl(lstViewCA.ListItems(i).ListSubItems(4)) + CDbl(lstViewCA.ListItems(i).ListSubItems(7)) - CDbl(lstViewCA.ListItems(i).ListSubItems(5))
'        Else
'        CAYear = 0
'        End If
        
'        ' === csNgoh Julai 2008 === '
'        'Balancecf = CAYear - CDbl(lstViewCA.ListItems(I).ListSubItems(14)) - CDbl(lstViewCA.ListItems(I).ListSubItems(9))
        
'        '==Oscar2009.1=='
'        If strS60FA = "Y" Then
'            Balancecf = 0
'        Else
'             If lstViewCA Is Nothing Then
'            Balancecf = 0
'            Else
'            Balancecf = CAYear + CDbl(lstViewCA.ListItems(i).ListSubItems(2)) - CDbl(lstViewCA.ListItems(i).ListSubItems(9)) '+ CDbl(lstViewCA.ListItems(i).ListSubItems(14)) 'weihong CDbl(lstViewCA.ListItems(i).ListSubItems(14)
'            End If
'        End If
'        '==End Oscar2009.1=='
        
'        ActualBalancebf = Balancecf - CDbl(lstViewCA.ListItems(i).ListSubItems(11))
'        ' === end csNgoh Julai 2008 === '
    
'        cSQL11 = "UPDATE [TAX_COMPUTATION] SET [TC_CB_CA_CURR]='" & CAYear & "', [TC_CB_CA_ABAL_CF] = '" & Trim(ActualBalancebf) & "' WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' AND [TC_BUSINESS]= " & BS & ""
'        DB.Execute (cSQL11)
'        amyrst.MoveNext

'        If CAYear = "0" Then
'            lstViewCA.ListItems(i).ListSubItems(6).Text = CAYear
'        Else
'            lstViewCA.ListItems(i).ListSubItems(6).Text = Format(CAYear, "#,###,###")
'        End If
       
        
'        ' === rmk csNgoh Julai 2008 === '
'        If ActualBalancebf < 0 Then
'           lstViewCA.ListItems(i).ListSubItems(12).Text = "0"
'        Else
'           lstViewCA.ListItems(i).ListSubItems(12).Text = FormatNumber(CDbl(ActualBalancebf), 0)
'        End If
'        'If Trim(lstViewCA.ListItems(I).ListSubItems(1).Text) = Trim(lstView.ListItems(I).ListSubItems(1).Text) Then
'        '
'        '     If CDbl(lstViewCA.ListItems(I).ListSubItems(8).Text) < 0 Then
'        '         lstView.ListItems(I).ListSubItems(7).Text = FormatNumber(Abs(lstViewCA.ListItems(I).ListSubItems(8).Text), 0)
'        '     Else
'        '         lstView.ListItems(I).ListSubItems(7).Text = "0"
'        '     End If
'        '
'        'End If
'        ' === end csNgoh Julai 2008 === '
'        i = i + 1
                    
'   Loop
   
'amyrst.Close
''-==end amy

'cmdSave_Click

'End Sub

'Private Sub chargeable_apportionment()
'    If Val(cYA) >= 2003 Then
'        ' === csNgoh C2008.5 === '
'        'cSQL2 = "SELECT [BS_CAPITAL] FROM [BALANCE_SHEET] WHERE [BS_REF_NO]='" & crefno & "' AND [BS_YA]='" & cya & "'"
'        cSQL2 = "SELECT [SME] FROM [BALANCE_SHEET] WHERE [BS_REF_NO]='" & cRefNo & "' AND [BS_YA]='" & cYA & "'"
'        ' === end csNgoh C2008.5 === '
        
'        Set rst2 = DB.Execute(cSQL2)
'        If Not rst2.EOF Then
'            txtAppChargeableIn4a = 0
'            txtAppChargeableIn5 = 0
        
'            ' === csNgoh C2008.5 === '
'            'If CDbl(rst2.Fields(0)) <= 2500000 Then
'            '    If Val(cya) >= 2004 Then
'            '        If CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable) <= 500000 Then
'            '            txtAppChargeableIn4a = FormatNumber(CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable), 0)
'            '        Else
'            '            txtAppChargeableIn4a = FormatNumber(CDbl(500000), 0)
'            '            txtAppChargeableIn5 = FormatNumber((CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable)) - 500000, 0)
'            '        End If
'            '    Else
'            '        If CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable) <= 100000 Then
'            '            txtAppChargeableIn4a = FormatNumber(CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable), 0)
'            '        Else
'            '            txtAppChargeableIn4a = FormatNumber(CDbl(100000), 0)
'            '            txtAppChargeableIn5 = FormatNumber((CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable)) - 100000, 0)
'            '        End If
'            '    End If
'            'Else
'            '    txtAppChargeableIn5 = FormatNumber(CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable), 0)
'            'End If
            
'            If rst2.Fields(0) = "1" Then
'                If Val(cYA) >= 2004 Then
'                    'azham 05062017
''                    If (Val(cYA) = 2017 Or Val(cYA) = 2018) And lvExemptionChargeable.ListItems.count > 0 Then
''                        If CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(3).Text) > CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(6).Text) And CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(8).Text) > 500000 Or CDbl(txtChargeableIn) > 500000 Then
''                            txtExemptionIncreaseChargeableAfter = CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(8).Text)
''                        End If
''                    End If
                    
'                    If CDbl(txtExemptionIncreaseChargeableAfter) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable) <= 500000 Then
'                        txtAppChargeableIn4a = FormatNumber(CDbl(txtExemptionIncreaseChargeableAfter) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable), 0)
'                    Else
'                        txtAppChargeableIn4a = FormatNumber(CDbl(500000), 0)
'                        txtAppChargeableIn5 = FormatNumber((CDbl(txtExemptionIncreaseChargeableAfter) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable)) - 500000, 0)
'                    End If
                    
'                    txtAppChargeableIn7 = 0
'                    txtITPChargeableIn7 = 0
''                    If Val(cYA) = 2017 Or Val(cYA) = 2018 Then
''                        If lvExemptionChargeable.ListItems.count > 0 Then
''                            azham 20062017
''                            If CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(3).Text) > CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(6).Text) And CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(8).Text) > 500000 Or CDbl(txtChargeableIn) > 500000 Then
''                            txtRate7 = FormatNumber(CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(12).Text), 0)
''                            txtAppChargeableIn7 = FormatNumber(CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(13).Text), 0)
''                            txtITPChargeableIn7 = FormatNumber((CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(13).Text) / 100) * CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(12).Text), 2)
''                            End If
''                        End If
''                    End If
                   
''                    If CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable) <= 500000 Then
''                        txtAppChargeableIn4a = FormatNumber(CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable), 0)
''                    Else
''                        txtAppChargeableIn4a = FormatNumber(CDbl(500000), 0)
''                        txtAppChargeableIn5 = FormatNumber((CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable)) - 500000, 0)
''                    End If
'                Else
                   
                    
'                    If CDbl(txtExemptionIncreaseChargeableAfter) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable) <= 100000 Then
'                        txtAppChargeableIn4a = FormatNumber(CDbl(txtExemptionIncreaseChargeableAfter) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable), 0)
'                    Else
'                        txtAppChargeableIn4a = FormatNumber(CDbl(100000), 0)
'                        txtAppChargeableIn5 = FormatNumber((CDbl(txtExemptionIncreaseChargeableAfter) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable)) - 100000, 0)
'                    End If
                    
                    
''                    If CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable) <= 100000 Then
''                        txtAppChargeableIn4a = FormatNumber(CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable), 0)
''                    Else
''                        txtAppChargeableIn4a = FormatNumber(CDbl(100000), 0)
''                        txtAppChargeableIn5 = FormatNumber((CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable)) - 100000, 0)
''                    End If
'                End If
'            ElseIf rst2.Fields(0) = "0" Then
'            'NOT SME
''                    If (Val(cYA) = 2017 Or Val(cYA) = 2018) And lvExemptionChargeable.ListItems.count > 0 Then
''                        If CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(3).Text) > CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(6).Text) And CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(8).Text) > 500000 Or CDbl(txtChargeableIn) > 500000 Then
''                            txtExemptionIncreaseChargeableAfter = CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(8).Text)
''                        End If
''                    End If
                    
'                 txtAppChargeableIn5 = FormatNumber(CDbl(txtExemptionIncreaseChargeableAfter) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable), 0)
                
                
'                If Val(cYA) = 2017 Or Val(cYA) = 2018 Then
'                        If lvExemptionChargeable.ListItems.count > 0 Then
'                            'azham 20062017
                            
''                            txtAppChargeableIn7.Visible = False
''                            txtRate7.Visible = False
''                            txtITPChargeableIn7.Visible = False
''
''                            txtRate7 = "0"
''                            txtAppChargeableIn7 = "0"
''                            txtITPChargeableIn7 = "0"
''                            If CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(3).Text) > CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(6).Text) And CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(8).Text) > 500000 Or CDbl(txtChargeableIn) > 500000 Then
''                            txtRate7 = FormatNumber(CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(12).Text), 0)
''                            txtAppChargeableIn7 = FormatNumber(CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(13).Text), 0)
''                            txtITPChargeableIn7 = FormatNumber((CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(13).Text) / 100) * CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(12).Text), 2)
''                            End If
'                        End If
'                    End If
''                If Val(cYA) = 2017 Or Val(cYA) = 2018 Then
''                        If lvExemptionChargeable.ListItems.count > 0 Then
''
''                            If CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(3).Text) > CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(6).Text) And CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(8).Text) > 500000 Then
''                            txtRate7 = FormatNumber(CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(12).Text), 0)
''                            txtAppChargeableIn7 = FormatNumber(CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(11).Text), 0)
''                            txtITPChargeableIn7 = FormatNumber((CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(11).Text) / 100) * CDbl(lvExemptionChargeable.ListItems(1).ListSubItems(12).Text), 2)
''                            End If
''                        End If
''                End If
                
'                'txtAppChargeableIn5 = FormatNumber(CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable), 0)
'            End If
'       Else
'       'azham 20062017
    
'         txtAppChargeableIn5 = FormatNumber(CDbl(txtExemptionIncreaseChargeableAfter) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable), 0)
'           ' txtAppChargeableIn5 = FormatNumber(CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable), 0)
'       End If
'    Else
'       txtAppChargeableIn5 = FormatNumber(CDbl(txtExemptionIncreaseChargeableAfter) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable), 0)
'      '  txtAppChargeableIn5 = FormatNumber(CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable), 0)
'End If
             
''                If Val(cYA) >= 2004 Then
''                    If CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable) <= 500000 Then
''                        txtAppChargeableIn4a = FormatNumber(CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable), 0)
''                    Else
''                        txtAppChargeableIn4a = FormatNumber(CDbl(500000), 0)
''                        txtAppChargeableIn5 = FormatNumber((CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable)) - 500000, 0)
''                    End If
''                Else
''                    If CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable) <= 100000 Then
''                        txtAppChargeableIn4a = FormatNumber(CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable), 0)
''                    Else
''                        txtAppChargeableIn4a = FormatNumber(CDbl(100000), 0)
''                        txtAppChargeableIn5 = FormatNumber((CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable)) - 100000, 0)
''                    End If
''                End If
''            ElseIf rst2.Fields(0) = "0" Then
''                txtAppChargeableIn5 = FormatNumber(CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable), 0)
''            End If
''            ' === end csNgoh C2008.5 === '
''        Else
''            txtAppChargeableIn5 = FormatNumber(CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable), 0)
''        End If
''    Else
''        txtAppChargeableIn5 = FormatNumber(CDbl(txtChargeableIn) + CDbl(txtOpHQChargeable) + CDbl(txtForeignChargeable), 0)
''    End If


'End Sub

''geline: Start: Taxcom C+ v 2005.1
'Private Sub txtZakat_Change()
'   '' txtTotalIncome = FormatNumber(CDbl(txtTotalOthExp) - (CDbl(txtApprDonation) + CDbl(txtZakat) + CDbl(txtClaim)), 0)
'   Call cal_totalIncome
'    ''MsgBox txtTotalIncome
'End Sub
''geline: Start: Taxcom C+ v 2005.1
'' === csNgoh 2008 Function field block === '
'Private Sub YearChecking()
'    If Val(txtYA) >= 2008 Then
'        ChkMajorC.Caption = "Applies"
'        ChkApply.Visible = True
'        If ChkApply.Value = Unchecked Then
'            ChkMajorC.Visible = False
'        Else
'            ChkMajorC.Visible = True
'        End If
'       ' ChkMajorC.Left = 360
'       ' ChkMajorC.Top = 5400
'        ChkApply.Caption = "Major Changes in Share Holding and S44(5A) not applied"
'        txtQualifyAgri.Enabled = False
'        txtFoodProduct.Enabled = False
'        txt110BSetOff.Enabled = True
'        txtQualifyAgri = 0
'        txtFoodProduct = 0
'        Label42.Caption = "Less: Surrender Amount (50% of current year's business loss)"
        
'        If Val(txtYA) >= 2009 Then
'            Label42.Caption = "Less: Surrender Amount (70% of current year's business loss)"
'        End If
'    Else
'        ChkApply.Visible = False
'        'ChkMajorC.Left = 240
'        'ChkMajorC.Top = 5040
'        ChkMajorC.Caption = "Major Changes in Share Holding/Disallowed C/F utilized CA and Business Loss"
'        ChkApply.Value = Checked
'        txtQualifyAgri.Enabled = True
'        txtFoodProduct.Enabled = True
'        txt110BSetOff.Enabled = False
'        txt110BSetOff = 0
'        Label42.Caption = "Less: Surrender Amount (50% of current year's business loss)"
'    End If
'End Sub
'' === end csNgoh 2008 === '

'Private Sub NAllow_Exp()
'    Dim PnLNo As Integer
'   cSQL = "SELECT [PL_KEY] FROM [PROFIT_LOSS_ACCOUNT] WHERE [PL_REF_NO] = '" & Trim(txtRefNo) & "' AND [PL_YA] = '" & Trim(txtYA) & "' ORDER BY [PL_KEY]"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'      PnLNo = rst![PL_KEY]
'    End If
'    rst.Close

' cSQL = "SELECT [TC_BUSINESS] FROM [TAX_COMPUTATION] where [TC_REF_NO] = '" & Trim(txtRefNo) & "'AND [TC_YA] = '" & Trim(txtYA) & "'ORDER BY [TC_BUSINESS]"
' Set rst1 = DB.Execute(cSQL)
' If Not rst1.EOF Then
'   ' SOURCECELL = 2
'    While Not rst1.EOF
'    'CELLNOROW = 29
'   ' Source = rst1.RecordCount
'    sourcenum = rst1!TC_BUSINESS
'    NA_Exp = 0

'   'OTHER INTEREST
'   cSQL = "SELECT [EXI_AMOUNT] FROM [EXPENSES_INTEREST] WHERE [EXI_KEY]=" & PnLNo & " AND [EXI_SOURCENO]=" & Val(sourcenum) & " AND [EXI_DEDUCTIBLE]='No'"
'   Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
    
'    cSQL = "SELECT [EXC_AMOUNT] FROM [EXPENSES_CONTRACT] WHERE [EXC_KEY]=" & PnLNo & " AND [EXC_SOURCENO]=" & Val(sourcenum) & " AND [EXC_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
    
'    cSQL = "SELECT [EXL_AMOUNT] FROM [EXPENSES_LEGAL] WHERE [EXL_KEY]=" & PnLNo & " AND [EXL_SOURCENO]=" & Val(sourcenum) & " AND [EXL_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
    
'    cSQL = "SELECT [EXS_AMOUNT] FROM [EXPENSES_SALARY] WHERE [EXS_KEY]=" & PnLNo & " AND [EXS_SOURCENO]=" & Val(sourcenum) & " AND [EXS_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
    
'    cSQL = "SELECT [EXRO_AMOUNT] FROM [EXPENSES_ROYALTY] WHERE [EXRO_KEY]=" & PnLNo & " AND [EXRO_SOURCENO]=" & Val(sourcenum) & " AND [EXRO_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
    
'    cSQL = "SELECT [EXRENT_AMOUNT] FROM [EXPENSES_RENTAL] WHERE [EXRENT_KEY]=" & PnLNo & " AND [EXRENT_SOURCENO]=" & Val(sourcenum) & " AND [EXRENT_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
    
'    cSQL = "SELECT [EXREP_AMOUNT] FROM [EXPENSES_REPAIR] WHERE [EXREP_KEY]=" & PnLNo & " AND [EXREP_SOURCENO]=" & Val(sourcenum) & " AND [EXREP_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
    
'    cSQL = "SELECT [EXRES_AMOUNT] FROM [EXPENSES_RESEARCH] WHERE [EXRES_KEY]=" & PnLNo & " AND [EXRES_SOURCENO]=" & Val(sourcenum) & " AND [EXRES_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
    
'    cSQL = "SELECT [EXP_AMOUNT] FROM [EXPENSES_PROMOTE] WHERE [EXP_KEY]=" & PnLNo & " AND [EXP_SOURCENO]=" & Val(sourcenum) & " AND [EXP_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close

'    cSQL = "SELECT [EXT_AMOUNT] FROM [EXPENSES_TRAVEL] WHERE [EXT_KEY]=" & PnLNo & " AND [EXT_SOURCENO]=" & Val(sourcenum) & " AND [EXT_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close

    
'    cSQL = "SELECT [EXO_AMOUNT] FROM [OTHER_EXPENSES] WHERE [EXO_KEY]=" & PnLNo & " AND [EXO_SOURCENO]=" & Val(sourcenum) & " AND [EXO_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
    
'    cSQL = "SELECT [EXIR_AMOUNT] FROM [EXPENSES_INTERESTRESTRICT] WHERE [EXIR_KEY]=" & PnLNo & "  AND [EXIR_SOURCENO]=" & Val(sourcenum) & " AND [EXIR_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
   
'    cSQL = "SELECT [EXODEP_AMOUNT] FROM [OTHER_EXDEPRECIATION] WHERE [EXODEP_KEY]=" & PnLNo & "  AND [EXODEP_SOURCENO]=" & Val(sourcenum) & " AND [EXODEP_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close

'    cSQL = "SELECT [EXOAD_AMOUNT] FROM [OTHER_EXAPPRDONATION] WHERE [EXOAD_KEY]=" & PnLNo & "  AND [EXOAD_SOURCENO]=" & Val(sourcenum)
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
    
'    'NGOHCS PNL2009
'    cSQL = "SELECT [EXONAD_AMOUNT] FROM [OTHER_EXNAPPRDONATION] WHERE [EXONAD_KEY]=" & PnLNo & "  AND [EXONAD_SOURCENO]=" & Val(sourcenum) & " AND [EXONAD_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
'    'NGOHCS PNL2009 END
    
'    'geline: Start: Taxcom C+ v 2005.1
'    cSQL = "SELECT [EXOZ_AMOUNT] FROM [OTHER_EXZAKAT] WHERE [EXOZ_KEY]=" & PnLNo & "  AND [EXOZ_SOURCENO]=" & Val(sourcenum)
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
'    'geline: End: Taxcom C+ v 2005.1
    
'    cSQL = "SELECT [EXOENS_AMOUNT] FROM [OTHER_ENTERTAINNSTAFF] WHERE [EXOENS_KEY]=" & PnLNo & "  AND [EXOENS_SOURCENO]=" & Val(sourcenum) & " AND [EXOENS_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close

'    cSQL = "SELECT [EXOES_AMOUNT] FROM [OTHER_ENTERTAINSTAFF] WHERE [EXOES_KEY]=" & PnLNo & "  AND [EXOES_SOURCENO]=" & Val(sourcenum) & " AND [EXOES_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
''C2007.4
'    cSQL = "SELECT [EXOP_AMOUNT] FROM [OTHER_EXPENALTY] WHERE [EXOP_KEY]=" & PnLNo & "  AND [EXOP_SOURCENO]=" & Val(sourcenum) & " AND [EXOP_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close

'    cSQL = "SELECT [EXOPA_AMOUNT] FROM [OTHER_EXPROVISIONACC] WHERE [EXOPA_KEY]=" & PnLNo & "  AND [EXOPA_SOURCENO]=" & Val(sourcenum) & " AND [EXOPA_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close

'    cSQL = "SELECT [EXOLP_AMOUNT] FROM [OTHER_EXLEAVEPASSAGE] WHERE [EXOLP_KEY]=" & PnLNo & "  AND [EXOLP_SOURCENO]=" & Val(sourcenum) & " AND [EXOLP_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close

'    cSQL = "SELECT [EXOWO_AMOUNT] FROM [OTHER_EXFAWRITTENOFF] WHERE [EXOWO_KEY]=" & PnLNo & "  AND [EXOWO_SOURCENO]=" & Val(sourcenum) & " AND [EXOWO_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close

'    cSQL = "SELECT [EXOIS_AMOUNT] FROM [OTHER_EXINITIALSUB] WHERE [EXOIS_KEY]=" & PnLNo & "  AND [EXOIS_SOURCENO]=" & Val(sourcenum) & " AND [EXOIS_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
   
'    cSQL = "SELECT [EXOCE_AMOUNT] FROM [OTHER_EXCAPITALEXP] WHERE [EXOCE_KEY]=" & PnLNo & "  AND [EXOCE_SOURCENO]=" & Val(sourcenum) & " AND [EXOCE_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
'   'C2007.4
   
'   cSQL = "SELECT [EXOUR_AMOUNT] FROM [OTHER_EXURLOSSFOREIGN] WHERE [EXOUR_KEY]=" & PnLNo & "  AND [EXOUR_SOURCENO]=" & Val(sourcenum) & " AND [EXOUR_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close

' cSQL = "SELECT [EXOR_AMOUNT] FROM [OTHER_EXRLOSSFOREIGN] WHERE [EXOR_KEY]=" & PnLNo & "  AND [EXOR_SOURCENO]=" & Val(sourcenum) & " AND [EXOR_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close


' cSQL = "SELECT [EXOLD_AMOUNT] FROM [OTHER_EXLOSSDISPOSALFA] WHERE [EXOLD_KEY]=" & PnLNo & "  AND [EXOLD_SOURCENO]=" & Val(sourcenum) & " AND [EXOLD_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close

'    cSQL = "SELECT [EXDEP_AMOUNT] FROM [EXPENSES_DEPRECIATION] WHERE [EXDEP_KEY]=" & PnLNo & "  AND [EXDEP_SOURCENO]=" & Val(sourcenum) & " AND [EXDEP_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
    
' cSQL = "SELECT [EXNA_AMOUNT] FROM [EXPENSES_NONALLOW] WHERE [EXNA_KEY]=" & PnLNo & "  AND [EXNA_SOURCENO]=" & Val(sourcenum) & " AND [EXNA_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
' 'C2008.3
 
'   cSQL = "SELECT [EXES_AMOUNT] FROM [EXPENSES_EMPL_STOCK] WHERE [EXES_KEY]=" & PnLNo & " AND [EXES_SOURCENO]= " & Val(sourcenum) & " AND [EXES_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close

' cSQL = "SELECT [EXTF_AMOUNT] FROM [EXPENSES_TECH_FEE] WHERE [EXTF_KEY]=" & PnLNo & " AND [EXTF_SOURCENO]= " & Val(sourcenum) & " AND [EXTF_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
    
'cSQL = "SELECT [NL_AMOUNT] FROM [NON_ALLOW_LOSS] WHERE [NL_REF_NO]='" & Trim(txtRefNo) & "' AND [NL_SOURCENO]= " & Val(sourcenum) & " AND [NL_YA]='" & Trim(txtYA) & "' AND [NL_CATEGORIZED]<>'PNL'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
    
'  ' === csNgoh Julai 2008 === '
'  cSQL = "SELECT [PLFPUR_AMOUNT] FROM [PLFST_PURCHASE] WHERE [PLFPUR_KEY] = " & PnLNo & " AND [PLFPUR_SOURCENO]= " & Val(sourcenum) & " AND [PLFPUR_DEDUCTIBLE]='No'"
'  Set rst = DB.Execute(cSQL)
'  If Not rst.EOF Then
'        Do While Not rst.EOF
'           NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'           rst.MoveNext
'        Loop
'  End If
'  rst.Close
'  ' === end csNgoh Julai 2008 === '
  
'  'LeeCC 20 August 2011 start
'   cSQL = "SELECT [EXORT_AMOUNT] FROM [OTHER_EXRLOSSFOREIGNT] WHERE [EXORT_KEY]=" & PnLNo & " AND [EXORT_SOURCENO]= " & Val(sourcenum) & " AND [EXORT_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
'  'LeeCC 20 August 2011 end
  
'  'DannyLee C2015
'  cSQL = "SELECT [EXDF_AMOUNT] FROM [EXPENSES_DIRECTORS_FEE] WHERE [EXDF_KEY]=" & PnLNo & " AND [EXDF_SOURCENO]=" & Val(sourcenum) & " AND [EXDF_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close
'    cSQL = "SELECT [EXJK_AMOUNT] FROM [EXPENSES_JKDM] WHERE [EXJK_KEY]=" & PnLNo & " AND [EXJK_SOURCENO]=" & Val(sourcenum) & " AND [EXJK_DEDUCTIBLE]='No'"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        Do While Not rst.EOF
'            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
'            rst.MoveNext
'        Loop
'    End If
'    rst.Close

' 'appExcel.ActiveCell.Worksheet.Cells(CELLNOROW, SOURCECELL) = CDbl(NA_Exp)
' TotalNA_EXP = TotalNA_EXP + CDbl(NA_Exp)
 
' 'appExcel.ActiveCell.Worksheet.Cells(CELLNOROW, Source + 2) = TotalNA_EXP
' 'SOURCECELL = SOURCECELL + 1
'rst1.MoveNext
'Wend
'End If
'rst1.Close
'' === csNgoh C2008.6 (SU6), 'NGOHCS PNL2009 === '
'    Dim dblDeductibleIn As Double
'    dblDeductibleIn = 0
''cSQL = "SELECT [TC_NB_DIV_ATT_INT], [TC_NB_INT_ATT_INT], [TC_NB_RENT_ATT_INT], [TC_NB_RENT_ASSESS], [TC_NB_RENT_QUIT], [TC_NB_RENT_INSUR]," & _
''        " [TC_NB_RENT_OTH2], [TC_TP_APRV_DONATION], [TC_TP_ZAKAT]" & _
''        " FROM [TAX_COMPUTATION] WHERE [NL_REF_NO]='" & Trim(txtRefNo) & "' AND [NL_SOURCENO]= " & Val(sourcenum) & " AND [NL_YA]='" & Trim(txtYA) & "' AND [NL_CATEGORIZED]<>'PNL'"
''    Set rst = DB.Execute(cSQL)
'    dblDeductibleIn = CDbl(txtDivAttrInt) + CDbl(txtIntAttrInt) + CDbl(txtRentAttrIn) + _
'                        CDbl(txtRentAssess) + CDbl(txtRentQuit) + CDbl(txtRentInsur) + _
'                        CDbl(txtRentOthExp) + _
'                        CDbl(txtApprDonation) + CDbl(txtZakat) + CDbl(txtDivOthers) + _
'                        CDbl(txtIntOthers) + CDbl(txtDirExpenses3) + CDbl(txtRentAttrInIBA) + _
'                        CDbl(txtRentAssessIBA) + CDbl(txtRentQuitIBA) + CDbl(txtRentInsurIBA) + _
'                        CDbl(txtRentOthExpIBA) + CDbl(txtRentRepairIBA) + CDbl(txtRentRenewalIBA) 'Add IBA direct Exp
                        
'    TotalNA_EXP = TotalNA_EXP - dblDeductibleIn
'' === end csNgoh C2008.6 (SU6) === '
'End Sub

'' === csNgoh Julai 2008 === '
''Private Sub TransferBlnCharge(ByVal X As Integer)
''
''    If lstViewCA.ListItems.count > 0 Then
''        If lstView.ListItems.count > 0 Then
''
''            lstView.ListItems(X).ListSubItems(0).Text = FormatNumber(CDbl(lstViewCA.ListItems(X).ListSubItems(0)) + CDbl(lstViewCA.ListItems(X).ListSubItems(0)), 0)
''
''        End If
''    End If
''
''End Sub

'' === end csNgoh Julai 2008 === '

'' === csNgoh C2008.5 === '

'Private Sub Insert_GeneralNone(RefNo As Integer)
    
'    Dim J As Integer
'    Dim X As Integer
    
'    cSQL = "DELETE FROM [RENTAL_DIREXP_OTHERS] WHERE [RE_KEY] =" & RefNo
'    DB.Execute cSQL
    
''===NgKL C2010==='
'    cSQL = "DELETE FROM [INTEREST_INCOME] WHERE [INT_KEY] =" & RefNo
'    DB.Execute cSQL
    
'    cSQL = "DELETE FROM [INTEREST_DIREXP_OTHERS] WHERE [INTEX_KEY] =" & RefNo
'    DB.Execute cSQL
    
'    cSQL = "DELETE FROM [DIVIDEND_DIREXP_OTHERS] WHERE [DIVEX_KEY] =" & RefNo
'    DB.Execute cSQL
    
'    cSQL = "DELETE FROM [SUNDRY_INCOME] WHERE [SUN_KEY] =" & RefNo
'    DB.Execute cSQL
    
'    cSQL = "DELETE FROM [SUNDRY_EXPENSES] WHERE [SUNEX_KEY] =" & RefNo
'    DB.Execute cSQL
    
'    cSQL = "DELETE FROM [RENTIBA_DIREXP_OTHERS] WHERE [REIBA_KEY]= " & RefNo
'    DB.Execute cSQL
''===NgKL End==='

''    If lvGeneralNone.ListItems.count < 1 Then
''      Exit Sub
''    End If
''
''    X = 1
''    For J = 1 To lvGeneralNone.ListItems.count
''
''      Select Case Trim(lvGeneralNone.ListItems(J).ListSubItems(4).Text)
''        Case "RDO"
''             Call InsertGeneralNone_RentalExp_Others(RefNo, J, n)
''    '===NgKL C2010.1==='
''        Case "IC"
''             Call InsertGeneralNone_InterestIncome(RefNo, J, n, X)
''             X = X + 1
''        Case "IDO"
''             Call InsertGeneralNone_IntDirExpenses(RefNo, J, n)
''        Case "DDO"
''             Call InsertGeneralNone_DivDirExpenses(RefNo, J, n)
''        Case "SUI"
''             Call InsertGeneralNone_SundryIncome(RefNo, J, n)
''        Case "SUE"
''             Call InsertGeneralNone_SundryDirExpenses(RefNo, J)
''    '===NgKL End==='
''      End Select
''    Next

'    'LeeCC IBA
'    On Error Resume Next
'    If UBound(objNonBusinessItem) < 0 Then
'        If Err.Number = 9 Then
'            Exit Sub
'        End If
'    End If
    
'    Dim n As Integer
'    X = 1
'    For J = 0 To UBound(objNonBusinessItem)
'        For n = 0 To UBound(objNonBusinessItem(J).Item)
'            Select Case Trim(objNonBusinessItem(J).Item(n).Category)
'            Case "RDO"
'                 Call InsertGeneralNone_RentalExp_Others(RefNo, J, n)
'            Case "IC"
'                 Call InsertGeneralNone_InterestIncome(RefNo, J, n, X)
'                 X = X + 1
'            Case "IDO"
'                 Call InsertGeneralNone_IntDirExpenses(RefNo, J, n)
'            Case "DDO"
'                 Call InsertGeneralNone_DivDirExpenses(RefNo, J, n)
'            Case "SUI"
'                 Call InsertGeneralNone_SundryIncome(RefNo, J, n, X)
'                 X = X + 1
'            Case "SUE"
'                 Call InsertGeneralNone_SundryDirExpenses(RefNo, J, n)
'            Case "RDOIBA"
'                 Call InsertGeneralNone_RentalIBAOtherExpenses(RefNo, J, n)
'          End Select
'        Next
'        X = 1
'    Next
'End Sub

''===NgKL C2010.1==='
'Private Function InsertGeneralNone_DivDirExpenses(DivexKey As Integer, i As Integer, n As Integer)
    
'    cSQL = "SELECT * FROM [DIVIDEND_DIREXP_OTHERS]"
'    rst.Open cSQL, DB, 3, 3
'    rst.AddNew
'    rst!DIVEX_KEY = DivexKey
'    rst!DIVEX_REKEY = objNonBusinessItem(i).Item(n).no 'Trim(lvGeneralNone.ListItems(i).ListSubItems(1).Text)
'    rst!DIVEX_DESC = objNonBusinessItem(i).Item(n).Description 'Trim(lvGeneralNone.ListItems(i).ListSubItems(2).Text)
'    rst!DIVEX_AMOUNT = objNonBusinessItem(i).Item(n).amount 'Trim(lvGeneralNone.ListItems(i).ListSubItems(3).Text)
'    rst.Update
'    rst.Close

'End Function

'Private Function InsertGeneralNone_IntDirExpenses(IntexKey As Integer, i As Integer, n As Integer)

'    cSQL = "SELECT * FROM [INTEREST_DIREXP_OTHERS]"
'    rst.Open cSQL, DB, 3, 3
'    rst.AddNew
'    rst!INTEX_KEY = IntexKey
'    rst!INTEX_REKEY = objNonBusinessItem(i).Item(n).no 'Trim(lvGeneralNone.ListItems(i).ListSubItems(1).Text)
'    rst!INTEX_DESC = objNonBusinessItem(i).Item(n).Description 'Trim(lvGeneralNone.ListItems(i).ListSubItems(2).Text)
'    rst!INTEX_AMOUNT = objNonBusinessItem(i).Item(n).amount 'Trim(lvGeneralNone.ListItems(i).ListSubItems(3).Text)
'    rst.Update
'    rst.Close
    
'End Function

'Private Function InsertGeneralNone_InterestIncome(IntKey As Integer, i As Integer, n As Integer, Y As Integer)
    
'    cSQL = "SELECT * FROM [INTEREST_INCOME]"
'    rst.Open cSQL, DB, 3, 3
'    rst.AddNew
'    rst!INT_KEY = IntKey
'    rst!INT_REKEY = Trim(Y)
'    rst!INT_DESC = objNonBusinessItem(i).Item(n).Description '(lvGeneralNone.ListItems(i).ListSubItems(2).Text)
'    rst!INT_AMOUNT = objNonBusinessItem(i).Item(n).amount 'Trim(lvGeneralNone.ListItems(i).ListSubItems(3).Text)
'    rst.Update
'    rst.Close

'End Function

''simkh 2012.1 LeeCC rmk
''Private Function InserGeneralNone_ExportNewMarket(EnmKey As Integer, i As Integer, n As Integer, Y As Integer)
''
''    cSQL = "SELECT * FROM [EXPORT_NEW_MARKET]"
''    rst.Open cSQL, DB, 3, 3
''    rst.AddNew
''    rst!ENM_KEY = EnmKey
''    rst!ENM_ENMKEY = Y
''    rst!ENM_COUNTRY = objNonBusinessItem(i).Item(n).country
''    rst!ENM_AMOUNT = objNonBusinessItem(i).Item(n).amount
''    rst.Update
''    rst.Close
''
''End Function

'' === NGKL 2010.2 === '
'Private Function InsertGeneralNone_SundryIncome(SunKey As Integer, i As Integer, n As Integer, Y As Integer)
    
'    cSQL = "SELECT * FROM [SUNDRY_INCOME]"
'    rst.Open cSQL, DB, 3, 3
'    rst.AddNew
'    rst!SUN_KEY = SunKey
'    rst!SUN_REKEY = Y 'Trim(lvGeneralNone.ListItems(i).ListSubItems(1).Text)
'    rst!SUN_DESC = objNonBusinessItem(i).Item(n).Description '(lvGeneralNone.ListItems(i).ListSubItems(2).Text)
'    rst!SUN_AMOUNT = objNonBusinessItem(i).Item(n).amount 'Trim(lvGeneralNone.ListItems(i).ListSubItems(3).Text)
'    rst.Update
'    rst.Close

'End Function

'Private Function InsertGeneralNone_SundryDirExpenses(SunexKey As Integer, i As Integer, n As Integer)
    
'    cSQL = "SELECT * FROM [SUNDRY_EXPENSES]"
'    rst.Open cSQL, DB, 3, 3
'    rst.AddNew
'    rst!SUNEX_KEY = SunexKey
'    rst!SUNEX_REKEY = objNonBusinessItem(i).Item(n).no 'Trim(lvGeneralNone.ListItems(i).ListSubItems(1).Text)
'    rst!SUNEX_DESC = objNonBusinessItem(i).Item(n).Description 'Trim(lvGeneralNone.ListItems(i).ListSubItems(2).Text)
'    rst!SUNEX_AMOUNT = objNonBusinessItem(i).Item(n).amount 'Trim(lvGeneralNone.ListItems(i).ListSubItems(3).Text)
'    rst.Update
'    rst.Close

'End Function
'' === NGKL 2010.2 END === '
''===NgKL End==='

'Private Function InsertGeneralNone_RentalIBAOtherExpenses(RefNo As Integer, i As Integer, n As Integer)
'    cSQL = "SELECT * FROM [RENTIBA_DIREXP_OTHERS]"
'    rst.Open cSQL, DB, 3, 3
'    rst.AddNew
'    rst!REIBA_KEY = RefNo
'    rst!REIBA_REKEY = objNonBusinessItem(i).Item(n).no 'Trim(lvGeneralNone.ListItems(i).ListSubItems(1).Text)
'    rst!REIBA_DESC = objNonBusinessItem(i).Item(n).Description 'Trim(lvGeneralNone.ListItems(i).ListSubItems(2).Text)
'    rst!REIBA_AMOUNT = objNonBusinessItem(i).Item(n).amount 'Trim(lvGeneralNone.ListItems(i).ListSubItems(3).Text)
'    rst.Update
'    rst.Close
'End Function

'Private Function InsertGeneralNone_RentalExp_Others(RefNo As Integer, i As Integer, n As Integer)

'    cSQL = "SELECT * FROM [RENTAL_DIREXP_OTHERS]"
'    rst.Open cSQL, DB, 3, 3
'    rst.AddNew
'    rst!RE_KEY = RefNo
'    rst!RE_REKEY = objNonBusinessItem(i).Item(n).no 'Trim(lvGeneralNone.ListItems(i).ListSubItems(1).Text)
'    rst!RE_DESC = objNonBusinessItem(i).Item(n).Description 'Trim(lvGeneralNone.ListItems(i).ListSubItems(2).Text)
'    rst!RE_AMOUNT = objNonBusinessItem(i).Item(n).amount 'Trim(lvGeneralNone.ListItems(i).ListSubItems(3).Text)
'    rst.Update
'    rst.Close

'End Function

''simkh 2012.1 LeeCC rmk
''Private Function InsertGeneralNone_ExportNewMarket(RefNo As Integer, i As Integer, n As Integer)
''
''    cSQL = "SELECT * FROM [EXPORT_NEW_MARKET]"
''    rst.Open cSQL, DB, 3, 3
''    rst.AddNew
''    rst!ENM_KEY = RefNo
''    rst!ENM_ENMKEY = objNonBusinessItem(i).Item(n).no 'Trim(lvGeneralNone.ListItems(i).ListSubItems(1).Text)
''    rst!ENM_COUNTRY = objNonBusinessItem(i).Item(n).country 'Trim(lvGeneralNone.ListItems(i).ListSubItems(2).Text)
''    rst!ENM_AMOUNT = objNonBusinessItem(i).Item(n).amount 'Trim(lvGeneralNone.ListItems(i).ListSubItems(3).Text)
''    rst.Update
''    rst.Close
''
''End Function

'Private Sub LoadLvGeneralNone()
    
'    Dim xItem As ListItem
'    Dim i As Integer
'    Dim Number As Integer
'    Dim amount As Double
'    'LeeCC IBA
'    Dim intItemCount As Integer
'    Dim intCount As Integer
    
'    Number = 1
'    cSQL = "SELECT * FROM [RENTAL_DIREXP_OTHERS] WHERE [RE_KEY] =" & CDbl(vIncomeCalKey) & " Order by [RE_REKEY]"
'    Set rst = DB.Execute(cSQL)
'    If Not rst.EOF Then
'        On Error Resume Next
'        If UBound(objNonBusinessItem) < 0 Then
'            If Err.Number = 9 Then
'                intCount = 0
'            End If
'        Else
'            intCount = intCount + 1
'        End If
'        ReDim Preserve objNonBusinessItem(intCount)
'        intItemCount = 0
'        objNonBusinessItem(intCount).TypeNo = 1
        
'        While Not rst.EOF
'            ReDim Preserve objNonBusinessItem(intCount).Item(intItemCount)
'            With objNonBusinessItem(intCount).Item(intItemCount)
'                .no = Trim(rst.Fields(1))
'                .Description = Trim(rst.Fields(2))
'                .amount = Trim(rst.Fields(3))
'                .Category = "RDO"
'            End With
'            intItemCount = intItemCount + 1
'            rst.MoveNext
'        Wend
'    End If
'    rst.Close
    
''===NgKL C2010==='
'    amount = 0
'    cSQL = "SELECT * FROM [INCOME_NBINTEREST] WHERE [NOBII_KEY] = (SELECT [PL_KEY] FROM [PROFIT_LOSS_ACCOUNT] WHERE [PL_REF_NO]='" & txtRefNo.Text & "' AND [PL_YA] ='" & txtYA.Text & "')"
'    Set rst = DB.Execute(cSQL)
            
'    If Not rst.EOF Then
'        On Error Resume Next
'        If UBound(objNonBusinessItem) < 0 Then
'            If Err.Number = 9 Then
'                intCount = 0
'            End If
'        Else
'            intCount = intCount + 1
'        End If
'        ReDim Preserve objNonBusinessItem(intCount)
'        intItemCount = 0
'        objNonBusinessItem(intCount).TypeNo = 2
        
'        While Not rst.EOF
'            ReDim Preserve objNonBusinessItem(intCount).Item(intItemCount)
'            With objNonBusinessItem(intCount).Item(intItemCount)
'                .no = Trim(Number)
'                .Description = Trim(rst.Fields(2))
'                .amount = Trim(rst.Fields(3))
'                .Category = "PNL"
'                amount = amount + CDbl(Trim(rst.Fields(3)))
'            End With
'            intItemCount = intItemCount + 1
'            Number = Number + 1
'            rst.MoveNext
'        Wend
'    End If
'    rst.Close

'    cSQL = "SELECT * FROM [INTEREST_INCOME] WHERE [INT_KEY] =" & CDbl(vIncomeCalKey) & " Order By [INT_KEY]"
'    Set rst = DB.Execute(cSQL)

'    If Not rst.EOF Then
'        Dim intCheck As Integer
'        intCheck = -1
        
'        On Error Resume Next
'        If UBound(objNonBusinessItem) < 0 Then
'            If Err.Number = 9 Then
'                intCount = 0
'                ReDim Preserve objNonBusinessItem(intCount)
'                objNonBusinessItem(intCount).TypeNo = 2
'                intCheck = intCount
'                intItemCount = 0
'            End If
'        Else
'            For i = 0 To UBound(objNonBusinessItem)
'                If objNonBusinessItem(i).TypeNo = "2" Then
'                    intCheck = i
'                    Exit For
'                End If
'            Next
            
'            If intCheck = -1 Then
'                intCount = intCount + 1
'                ReDim Preserve objNonBusinessItem(intCount)
'                intCheck = intCount
'                objNonBusinessItem(intCheck).TypeNo = 2
'                intItemCount = 0
'            End If
'        End If
            
'        While Not rst.EOF
'            ReDim Preserve objNonBusinessItem(intCheck).Item(intItemCount)
'            With objNonBusinessItem(intCheck).Item(intItemCount)
'                .no = Trim(Number)
'                .Description = Trim(rst.Fields(2))
'                .amount = Trim(rst.Fields(3))
'                .Category = "IC"
'                amount = amount + CDbl(Trim(rst.Fields(3)))
'            End With
'            intItemCount = intItemCount + 1
'            Number = Number + 1
'            rst.MoveNext
'        Wend
'    End If
'    rst.Close
    
'    txtInterestIn = FormatNumber(amount, 0)
 
'    cSQL = "SELECT * FROM [INTEREST_DIREXP_OTHERS] WHERE [INTEX_KEY] =" & CDbl(vIncomeCalKey) & " Order by [INTEX_REKEY]"
'    Set rst = DB.Execute(cSQL)
    
'    If Not rst.EOF Then
'        On Error Resume Next
'        If UBound(objNonBusinessItem) < 0 Then
'            If Err.Number = 9 Then
'                intCount = 0
'            End If
'        Else
'            intCount = intCount + 1
'        End If
'        ReDim Preserve objNonBusinessItem(intCount)
'        intItemCount = 0
'        objNonBusinessItem(intCount).TypeNo = 3
        
'        While Not rst.EOF
'            ReDim Preserve objNonBusinessItem(intCount).Item(intItemCount)
'            With objNonBusinessItem(intCount).Item(intItemCount)
'                .no = Trim(rst.Fields(1))
'                .Description = Trim(rst.Fields(2))
'                .amount = Trim(rst.Fields(3))
'                .Category = "IDO"
'            End With
'            intItemCount = intItemCount + 1
'            rst.MoveNext
'        Wend
'    End If
'    rst.Close
    

'    cSQL = "SELECT * FROM [DIVIDEND_DIREXP_OTHERS] WHERE [DIVEX_KEY] =" & CDbl(vIncomeCalKey) & " Order by [DIVEX_REKEY]"
'    Set rst = DB.Execute(cSQL)
    
'    If Not rst.EOF Then
'        On Error Resume Next
'        If UBound(objNonBusinessItem) < 0 Then
'            If Err.Number = 9 Then
'                intCount = 0
'            End If
'        Else
'            intCount = intCount + 1
'        End If
'        ReDim Preserve objNonBusinessItem(intCount)
'        intItemCount = 0
'        objNonBusinessItem(intCount).TypeNo = 4
        
'        While Not rst.EOF
'            ReDim Preserve objNonBusinessItem(intCount).Item(intItemCount)
'            With objNonBusinessItem(intCount).Item(intItemCount)
'                .no = Trim(rst.Fields(1))
'                .Description = Trim(rst.Fields(2))
'                .amount = Trim(rst.Fields(3))
'                .Category = "DDO"
'            End With
'            intItemCount = intItemCount + 1
'            rst.MoveNext
'        Wend
'    End If
'    rst.Close
''===NgKL End==='
    
'' === NGKL 2010.2 === '
'    amount = 0
'    Number = 1
    
'    ' === From PNL === '
'    cSQL = "SELECT * FROM [OTHER_INCOME] WHERE [OI_KEY] =(SELECT [PL_KEY] FROM [PROFIT_LOSS_ACCOUNT] WHERE [PL_REF_NO]='" & txtRefNo.Text & "' AND [PL_YA] ='" & txtYA.Text & "')"
'    Set rst = DB.Execute(cSQL)
    
'    If Not rst.EOF Then
'        On Error Resume Next
'        If UBound(objNonBusinessItem) < 0 Then
'            If Err.Number = 9 Then
'                intCount = 0
'            End If
'        Else
'            intCount = intCount + 1
'        End If
'        ReDim Preserve objNonBusinessItem(intCount)
'        intItemCount = 0
'        objNonBusinessItem(intCount).TypeNo = 5
        
'        While Not rst.EOF
'            ReDim Preserve objNonBusinessItem(intCount).Item(intItemCount)
'            With objNonBusinessItem(intCount).Item(intItemCount)
'                .no = Trim(Number)
'                .Description = Trim(rst.Fields(2))
'                .amount = Trim(rst.Fields(3))
'                .Category = "PNL"
'                amount = amount + CDbl(Trim(rst.Fields(3)))
'            End With
'            intItemCount = intItemCount + 1
'            Number = Number + 1
'            rst.MoveNext
'        Wend
'    End If
'    rst.Close
    
'    cSQL = "SELECT * FROM [SUNDRY_INCOME] WHERE [SUN_KEY] =" & CDbl(vIncomeCalKey) & " Order by [SUN_REKEY]"
'    Set rst = DB.Execute(cSQL)

'    If Not rst.EOF Then
'        Dim intCheck1 As Integer
'        intCheck1 = -1
        
'        On Error Resume Next
'        If UBound(objNonBusinessItem) < 0 Then
'            If Err.Number = 9 Then
'                intCount = 0
'                ReDim Preserve objNonBusinessItem(intCount)
'                objNonBusinessItem(intCount).TypeNo = 5
'                intCheck1 = intCount
'                intItemCount = 0
'            End If
'        Else
'            For i = 0 To UBound(objNonBusinessItem)
'                If objNonBusinessItem(i).TypeNo = "5" Then
'                    intCheck1 = i
'                    Exit For
'                End If
'            Next
            
'            If intCheck1 = -1 Then
'                intCount = intCount + 1
'                ReDim Preserve objNonBusinessItem(intCount)
'                intCheck1 = intCount
'                objNonBusinessItem(intCheck1).TypeNo = 5
'                intItemCount = 0
'            End If
'        End If

'        While Not rst.EOF
'            ReDim Preserve objNonBusinessItem(intCheck1).Item(intItemCount)
'            With objNonBusinessItem(intCheck1).Item(intItemCount)
'                .no = Trim(Number)
'                .Description = Trim(rst.Fields(2))
'                .amount = Trim(rst.Fields(3))
'                .Category = "SUI"
'                amount = amount + CDbl(Trim(rst.Fields(3)))
'            End With
'            intItemCount = intItemCount + 1
'            Number = Number + 1
'            rst.MoveNext
'        Wend
'    End If
'    rst.Close
'    txtSundryIn = FormatNumber(amount, 0)
    
'    cSQL = "SELECT * FROM [SUNDRY_EXPENSES] WHERE [SUNEX_KEY] =" & CDbl(vIncomeCalKey) & " Order by [SUNEX_REKEY]"
'    Set rst = DB.Execute(cSQL)
    
'    If Not rst.EOF Then
'        On Error Resume Next
'        If UBound(objNonBusinessItem) < 0 Then
'            If Err.Number = 9 Then
'                intCount = 0
'            End If
'        Else
'            intCount = intCount + 1
'        End If
'        ReDim Preserve objNonBusinessItem(intCount)
'        intItemCount = 0
'        objNonBusinessItem(intCount).TypeNo = 6
        
'        While Not rst.EOF
'            ReDim Preserve objNonBusinessItem(intCount).Item(intItemCount)
'            With objNonBusinessItem(intCount).Item(intItemCount)
'                .no = Trim(rst.Fields(1))
'                .Description = Trim(rst.Fields(2))
'                .amount = Trim(rst.Fields(3))
'                .Category = "SUE"
'                End With
'            intItemCount = intItemCount + 1
'            rst.MoveNext
'        Wend
'    End If
'    rst.Close
    
'    cSQL = "SELECT * FROM [RENTIBA_DIREXP_OTHERS] WHERE [REIBA_KEY] =" & CDbl(vIncomeCalKey) & " Order by [REIBA_KEY]"
'    Set rst = DB.Execute(cSQL)

'    If Not rst.EOF Then
'        On Error Resume Next
'        If UBound(objNonBusinessItem) < 0 Then
'            If Err.Number = 9 Then
'                intCount = 0
'            End If
'        Else
'            intCount = intCount + 1
'        End If
'        ReDim Preserve objNonBusinessItem(intCount)
'        intItemCount = 0
'        objNonBusinessItem(intCount).TypeNo = 7
        
'        While Not rst.EOF
'            ReDim Preserve objNonBusinessItem(intCount).Item(intItemCount)
'            With objNonBusinessItem(intCount).Item(intItemCount)
'                .no = Trim(rst.Fields(1))
'                .Description = Trim(rst.Fields(2))
'                .amount = Trim(rst.Fields(3))
'                .Category = "RDOIBA"
'            End With
'            intItemCount = intItemCount + 1
'            rst.MoveNext
'        Wend
'    End If
'    rst.Close
'' === NGKL 2010.2 END === '

'End Sub
'' === end csNgoh C2008.5 === '

'' === NGOHCS CA2008 === '

'Private Sub Insert_Withdrawal(RefNo As Integer)
        
'    cSQL = "DELETE FROM [TAX_WITHDRAWAL_RAITA] WHERE [WITH_KEY] =" & RefNo
'    DB.Execute cSQL
'    cSQL = "DELETE FROM [TAX_RA_WITHDRAWAL] WHERE [RAW_KEY] =" & RefNo
'    DB.Execute cSQL
'    cSQL = "DELETE FROM [TAX_RA_ADJUSTMENT] WHERE [RAADJ_KEY] =" & RefNo
'    DB.Execute cSQL
'    cSQL = "DELETE FROM [TAX_ITA_WITHDRAWAL] WHERE [ITAW_KEY] =" & RefNo
'    DB.Execute cSQL
'    cSQL = "DELETE FROM [TAX_ITA_ADJUSTMENT] WHERE [ITAADJ_KEY] =" & RefNo
'    DB.Execute cSQL
    
'    If lvWithdrawal.ListItems.count < 1 Then
'      Exit Sub
'    End If
    
'    For i = 1 To lvWithdrawal.ListItems.count
'        Select Case lvWithdrawal.ListItems(i).ListSubItems(4).Text
'            Case "WITH"
'                cSQL = "SELECT * FROM [TAX_WITHDRAWAL_RAITA]"
'                rst.Open cSQL, DB, 3, 3
'                rst.AddNew
'                rst!WITH_KEY = RefNo
'                rst!WITH_BUSINESS = Trim(lvWithdrawal.ListItems(i).ListSubItems(5).Text)
'                rst!WITH_ID = Trim(lvWithdrawal.ListItems(i).Text)
'                rst!WITH_ITEM = Trim(lvWithdrawal.ListItems(i).ListSubItems(1).Text)
'                rst!WITH_AMOUNT = Trim(lvWithdrawal.ListItems(i).ListSubItems(2).Text)
'                rst!WITH_NOTE = Trim(lvWithdrawal.ListItems(i).ListSubItems(3).Text)
'                rst.Update
'                rst.Close
'            Case "RAW"
'                cSQL = "SELECT * FROM [TAX_RA_WITHDRAWAL]"
'                rst.Open cSQL, DB, 3, 3
'                rst.AddNew
'                rst!RAW_KEY = RefNo
'                rst!RAW_BUSINESS = Trim(lvWithdrawal.ListItems(i).ListSubItems(5).Text)
'                rst!RAW_ID = Trim(lvWithdrawal.ListItems(i).Text)
'                rst!RAW_ITEM = Trim(lvWithdrawal.ListItems(i).ListSubItems(1).Text)
'                rst!RAW_AMOUNT = Trim(lvWithdrawal.ListItems(i).ListSubItems(2).Text)
'                rst!RAW_NOTE = Trim(lvWithdrawal.ListItems(i).ListSubItems(3).Text)
'                rst.Update
'                rst.Close
'            Case "RAA"
'                cSQL = "SELECT * FROM [TAX_RA_ADJUSTMENT]"
'                rst.Open cSQL, DB, 3, 3
'                rst.AddNew
'                rst!RAADJ_KEY = RefNo
'                rst!RAADJ_BUSINESS = Trim(lvWithdrawal.ListItems(i).ListSubItems(5).Text)
'                rst!RAADJ_ID = Trim(lvWithdrawal.ListItems(i).Text)
'                rst!RAADJ_ITEM = Trim(lvWithdrawal.ListItems(i).ListSubItems(1).Text)
'                rst!RAADJ_AMOUNT = Trim(lvWithdrawal.ListItems(i).ListSubItems(2).Text)
'                rst!RAADJ_NOTE = Trim(lvWithdrawal.ListItems(i).ListSubItems(3).Text)
'                rst.Update
'                rst.Close
'            Case "ITAW"
'                cSQL = "SELECT * FROM [TAX_ITA_WITHDRAWAL]"
'                rst.Open cSQL, DB, 3, 3
'                rst.AddNew
'                rst!ITAW_KEY = RefNo
'                rst!ITAW_BUSINESS = Trim(lvWithdrawal.ListItems(i).ListSubItems(5).Text)
'                rst!ITAW_ID = Trim(lvWithdrawal.ListItems(i).Text)
'                rst!ITAW_ITEM = Trim(lvWithdrawal.ListItems(i).ListSubItems(1).Text)
'                rst!ITAW_AMOUNT = Trim(lvWithdrawal.ListItems(i).ListSubItems(2).Text)
'                rst!ITAW_NOTE = Trim(lvWithdrawal.ListItems(i).ListSubItems(3).Text)
'                rst.Update
'                rst.Close
'            Case "ITAA"
'                cSQL = "SELECT * FROM [TAX_ITA_ADJUSTMENT]"
'                rst.Open cSQL, DB, 3, 3
'                rst.AddNew
'                rst!ITAADJ_KEY = RefNo
'                rst!ITAADJ_BUSINESS = Trim(lvWithdrawal.ListItems(i).ListSubItems(5).Text)
'                rst!ITAADJ_ID = Trim(lvWithdrawal.ListItems(i).Text)
'                rst!ITAADJ_ITEM = Trim(lvWithdrawal.ListItems(i).ListSubItems(1).Text)
'                rst!ITAADJ_AMOUNT = Trim(lvWithdrawal.ListItems(i).ListSubItems(2).Text)
'                rst!ITAADJ_NOTE = Trim(lvWithdrawal.ListItems(i).ListSubItems(3).Text)
'                rst.Update
'                rst.Close
'        End Select
'    Next
'End Sub

'Private Sub LoadLvWithdrawal()

'    Dim xItem As ListItem
                
'    ' === WITHDRAW RA/ITA === '
'    cSQL = "SELECT * FROM [TAX_WITHDRAWAL_RAITA] WHERE [WITH_KEY] =" & CDbl(vIncomeCalKey) & " Order by [WITH_ID]"
'    Set rst = DB.Execute(cSQL)
    
'    If Not rst.EOF Then
    
'    While Not rst.EOF
'    Set xItem = lvWithdrawal.ListItems.Add(, , Trim(rst.Fields(2)))
'    With xItem
'      .ListSubItems.Add 1, , Trim(rst.Fields(3))
'      .ListSubItems.Add 2, , Trim(rst.Fields(4))
'      .ListSubItems.Add 3, , Trim(rst.Fields(5))
'      .ListSubItems.Add 4, , "WITH"
'      .ListSubItems.Add 5, , Trim(rst.Fields(1))
'    End With
'    rst.MoveNext
'    Wend
'    End If
'    rst.Close
    
'    ' === RA WITHDRAWAL === '
'    cSQL = "SELECT * FROM [TAX_RA_WITHDRAWAL] WHERE [RAW_KEY] =" & CDbl(vIncomeCalKey) & " Order by [RAW_ID]"
'    Set rst = DB.Execute(cSQL)
    
'    If Not rst.EOF Then
    
'    While Not rst.EOF
'    Set xItem = lvWithdrawal.ListItems.Add(, , Trim(rst.Fields(2)))
'    With xItem
'      .ListSubItems.Add 1, , Trim(rst.Fields(3))
'      .ListSubItems.Add 2, , Trim(rst.Fields(4))
'      .ListSubItems.Add 3, , Trim(rst.Fields(5))
'      .ListSubItems.Add 4, , "RAW"
'      .ListSubItems.Add 5, , Trim(rst.Fields(1))
'    End With
'    rst.MoveNext
'    Wend
'    End If
'    rst.Close
    
'    ' === RA ADJUSTMENT === '
'    cSQL = "SELECT * FROM [TAX_RA_ADJUSTMENT] WHERE [RAADJ_KEY] =" & CDbl(vIncomeCalKey) & " Order by [RAADJ_ID]"
'    Set rst = DB.Execute(cSQL)
    
'    If Not rst.EOF Then
    
'    While Not rst.EOF
'    Set xItem = lvWithdrawal.ListItems.Add(, , Trim(rst.Fields(2)))
'    With xItem
'      .ListSubItems.Add 1, , Trim(rst.Fields(3))
'      .ListSubItems.Add 2, , Trim(rst.Fields(4))
'      .ListSubItems.Add 3, , Trim(rst.Fields(5))
'      .ListSubItems.Add 4, , "RAA"
'      .ListSubItems.Add 5, , Trim(rst.Fields(1))
'    End With
'    rst.MoveNext
'    Wend
'    End If
'    rst.Close
    
'    ' === ITA WITHDRAWAL === '
'    cSQL = "SELECT * FROM [TAX_ITA_WITHDRAWAL] WHERE [ITAW_KEY] =" & CDbl(vIncomeCalKey) & " Order by [ITAW_ID]"
'    Set rst = DB.Execute(cSQL)
    
'    If Not rst.EOF Then
    
'    While Not rst.EOF
'    Set xItem = lvWithdrawal.ListItems.Add(, , Trim(rst.Fields(2)))
'    With xItem
'      .ListSubItems.Add 1, , Trim(rst.Fields(3))
'      .ListSubItems.Add 2, , Trim(rst.Fields(4))
'      .ListSubItems.Add 3, , Trim(rst.Fields(5))
'      .ListSubItems.Add 4, , "ITAW"
'      .ListSubItems.Add 5, , Trim(rst.Fields(1))
'    End With
'    rst.MoveNext
'    Wend
'    End If
'    rst.Close
    
'    ' === ITA ADJUSTMENT === '
'    cSQL = "SELECT * FROM [TAX_ITA_ADJUSTMENT] WHERE [ITAADJ_KEY] =" & CDbl(vIncomeCalKey) & " Order by [ITAADJ_ID]"
'    Set rst = DB.Execute(cSQL)
    
'    If Not rst.EOF Then
    
'    While Not rst.EOF
'    Set xItem = lvWithdrawal.ListItems.Add(, , Trim(rst.Fields(2)))
'    With xItem
'      .ListSubItems.Add 1, , Trim(rst.Fields(3))
'      .ListSubItems.Add 2, , Trim(rst.Fields(4))
'      .ListSubItems.Add 3, , Trim(rst.Fields(5))
'      .ListSubItems.Add 4, , "ITAA"
'      .ListSubItems.Add 5, , Trim(rst.Fields(1))
'    End With
'    rst.MoveNext
'    Wend
'    End If
'    rst.Close
    
'End Sub
'' === NGOHCS CA2008 END === '

''=== CYS 2010 ===
'Private Sub Calculate_TotalIncome()
    
'    If Trim(txtAllStatIn.Text) = "" Then txtAllStatIn.Text = 0
'    If Trim(txtStatPartnership.Text) = "" Then txtStatPartnership.Text = 0
    
'    txtTotal.Text = FormatNumber(CDbl(txtAllStatIn.Text) + CDbl(txtStatPartnership.Text), 0)
'End Sub
''=== CYS end 2010 ===

'Private Sub cmdEditPartner_Click() 'Loo Jia Ann TAXcom C+ Partneship
'If lstViewCAPI.ListItems.count = 0 Then
'   Exit Sub
'End If
'frmIncomeCALCAPartnership.Show
'End Sub

'Private Sub lstViewCAPI_DblClick() 'Loo Jia Ann TAXcom C+ Partneship
'    cmdEditPartner_Click
'End Sub

'Public Sub Display_lstViewCAPI() 'Loo Jia Ann TAXcom C+ Partneship

'    Dim strKey As String
'    Dim NoSource As String
'    Dim cSQL2 As String
'    Dim rst2 As New ADODB.Recordset
'    Dim rst3 As New ADODB.Recordset
'    Dim xItem As ListItem
'    Dim total As String
'    Dim balance As String
'    Dim AdjustedPIncome As String
    
'    Me.lstViewCAPI.ListItems.Clear
    
'    cSQL = "SELECT * FROM [TAX_COMPUTATION_PARTNER] WHERE [TCP_REF_NO] = '" & Trim(cRefNo) & "' AND [TCP_YA] = '" & Trim(cYA) & "' "
'    Set rst = DB.Execute(cSQL)
    
'    If rst.EOF Then
'        Exit Sub
'    Else
'        strKey = rst!TCP_KEY
'    End If
'    rst.Close
    
'    cSQL = "SELECT * FROM [INCOME_PARTNERSHIP] WHERE [TCP_KEY] = " & strKey & " ORDER BY [PN_SOURCENO] "
'    Set rst2 = DB.Execute(cSQL)
'    If rst2.EOF Then Exit Sub
    
'    While Not rst2.EOF
'        Set xItem = frmIncomeCalculationEdit.lstViewCAPI.ListItems.Add(, , rst2!PN_SOURCENO)
        
'        NoSource = rst2!PN_SOURCENO
'        cSQL2 = "SELECT * FROM [TAXP_PARTNERSHIP] WHERE [PS_KEY] = '" & Trim(cRefNo) & "' AND [PS_YA] = '" & Trim(cYA) & "' AND [PS_SOURCENO] = " & Trim(NoSource)
'        Set rst3 = DB.Execute(cSQL2)
'        If rst3.EOF Then Exit Sub
'        If Not IsNull(rst3!PS_TYPE) Then
'            xItem.ListSubItems.Add 1, , rst3!PS_TYPE
'        End If
'        rst3.Close
        
'        cSQL2 = "SELECT * FROM [OPENING_BALANCE_PARTNER] WHERE [OBP_REF_NO] = '" & Trim(cRefNo) & "' AND [OBP_YA] = '" & Trim(cYA) & "' AND [OBP_SOURCENO] = " & Trim(NoSource)
'        Set rst3 = DB.Execute(cSQL2)
'        If rst3.EOF Then
'            xItem.ListSubItems.Add 2, , "0"
'        Else
'            xItem.ListSubItems.Add 2, , FormatNumber(rst3!OBP_SCHEDULE, 0)
'        End If
'        rst3.Close
        
'        xItem.ListSubItems.Add 3, , 0
'        xItem.ListSubItems.Add 4, , 0
'        xItem.ListSubItems.Add 5, , 0
        
'        If IsNull(rst2!PN_CA) Then
'            xItem.ListSubItems.Add 6, , "0"
'        Else
'            xItem.ListSubItems.Add 6, , rst2!PN_CA
'        End If
        
'        If IsNull(rst2!PN_BA) Then
'            xItem.ListSubItems.Add 7, , "0"
'        Else
'            xItem.ListSubItems.Add 7, , rst2!PN_BA
'        End If
        
'        xItem.ListSubItems.Add 8, , "0"
        
'        If IsNull(rst2!PN_CA_BA) Then
'            xItem.ListSubItems.Add 9, , "0"
'        Else
'            xItem.ListSubItems.Add 9, , rst2!PN_CA_BA
'        End If
        
'        If IsNull(rst2!PN_CF) Then
'            xItem.ListSubItems.Add 10, , "0"
'        Else
'            xItem.ListSubItems.Add 10, , rst2!PN_CF
'        End If
        
'        rst2.MoveNext
        
'        total = CDbl(xItem.ListSubItems(2).Text) + CDbl(xItem.ListSubItems(6).Text) + CDbl(xItem.ListSubItems(7).Text)
'        If total < 0 Then total = "0"
'        xItem.ListSubItems(8).Text = FormatNumber(total, 0)
        
'        cSQL = "SELECT * FROM [TAX_COMPUTATION_PARTNER] WHERE [TCP_REF_NO] = '" & Trim(cRefNo) & "' AND [TCP_YA] = '" & Trim(cYA) & "'"
'        Set rst = DB.Execute(cSQL)
        
'        If Not rst.EOF Then
'            strKey = rst!TCP_KEY
'        Else
'            Exit Sub
'        End If
'        rst.Close
        
'        cSQL = "SELECT * FROM [INCOME_PARTNERSHIP] WHERE [TCP_KEY] = " & strKey & " AND [PN_SOURCENO] = " & NoSource
'        Set rst = DB.Execute(cSQL)
        
'        If Trim(rst!PN_SOURCENO) = Trim(NoSource) Then
'            AdjustedPIncome = CDbl(rst!PN_ADJ_INCOME) + CDbl(rst!PN_BAL_CHARGES)
'        End If
'        rst.Close
        
'        If CDbl(total) > CDbl(AdjustedPIncome) Then
'           xItem.ListSubItems(9).Text = FormatNumber(AdjustedPIncome, 0)
'        Else
'           xItem.ListSubItems(9).Text = FormatNumber(total, 0)
'        End If

'        balance = CDbl(xItem.ListSubItems(8).Text) - CDbl(xItem.ListSubItems(9).Text)
'        xItem.ListSubItems(10).Text = FormatNumber(balance, 0)
'    Wend
    
'    rst2.Close

'End Sub

'Public Sub Refresh_RAPartnership() 'CYS TAxcom C+ Partnership
'    Dim strKey As String
'    Dim NoSource As String
'    Dim cSQL2 As String
'    Dim rst2 As New ADODB.Recordset
'    Dim rst3 As New ADODB.Recordset
'    Dim xItem As ListItem
'    Dim total1 As String
'    Dim total2 As String
'    Dim total3 As String
'    Dim total4 As String
'    'Dim StatIncome As String
'    'Dim nAmount As String
    
'    frmIncomeCalculationEdit.lstRAPartnership.ListItems.Clear
    
'    cSQL = "SELECT * FROM [TAX_COMPUTATION_PARTNER] WHERE [TCP_REF_NO] = '" & Trim(cRefNo) & "' AND [TCP_YA] = '" & Trim(cYA) & "'"
'    Set rst2 = DB.Execute(cSQL)
    
'    If rst2.EOF Then
'        Exit Sub
'    Else
'        strKey = rst2!TCP_KEY
'    End If
    
'    cSQL = "SELECT * FROM [INCOME_PARTNERSHIP] WHERE [TCP_KEY] = " & strKey & " ORDER BY [PN_SOURCENO] "
    
'    Set rst = DB.Execute(cSQL)
'    If rst.EOF Then Exit Sub
    
'    While Not rst.EOF
'        Set xItem = frmIncomeCalculationEdit.lstRAPartnership.ListItems.Add(, , rst!PN_SOURCENO)
        
'        NoSource = rst!PN_SOURCENO
'        cSQL2 = "SELECT * FROM [TAXP_PARTNERSHIP] WHERE [PS_KEY] = '" & Trim(cRefNo) & "' AND [PS_YA] = '" & Trim(cYA) & "' AND [PS_SOURCENO] = " & Trim(NoSource)
'        Set rst3 = DB.Execute(cSQL2)
'        If rst3.EOF Then Exit Sub
'        If Not IsNull(rst3!PS_TYPE) Then
'            xItem.ListSubItems.Add 1, , rst3!PS_TYPE
'        End If
'        rst3.Close
        
'        cSQL2 = "SELECT * FROM [OPENING_BALANCE_PARTNER] WHERE [OBP_REF_NO] = '" & Trim(cRefNo) & "' AND [OBP_YA] = '" & Trim(cYA) & "' AND [OBP_SOURCENO] = " & Trim(NoSource)
'        Set rst3 = DB.Execute(cSQL2)
'        If rst3.EOF Then
'            xItem.ListSubItems.Add 2, , "0"
'        Else
'            xItem.ListSubItems.Add 2, , rst3!OBP_RA
'        End If
'        rst3.Close
        
'        xItem.ListSubItems.Add 3, , rst!PN_RA
'        xItem.ListSubItems.Add 4, , "0"
'        xItem.ListSubItems.Add 5, , "0"
'        xItem.ListSubItems.Add 6, , "0"
        
'        cSQL2 = "SELECT sum(cast(RAPW_AMOUNT as money)) AS TOTAL_AMOUNT FROM [TAX_RAP_WITHDRAWAL] WHERE [RAPW_KEY] = " & strKey & " AND [RAPW_BUSINESS] = " & Trim(NoSource)
'        Set rst3 = DB.Execute(cSQL2)
'        If IsNull(rst3!TOTAL_AMOUNT) Then
'            xItem.ListSubItems.Add 7, , "0"
'        Else
'            xItem.ListSubItems.Add 7, , FormatNumber(CDbl(rst3!TOTAL_AMOUNT), 0)
'        End If
'        rst3.Close
        
'        cSQL2 = "SELECT sum(cast(RAPADJ_AMOUNT as money)) AS TOTAL_AMOUNT FROM [TAX_RAP_ADJUSTMENT] WHERE [RAPADJ_KEY] = " & strKey & " AND [RAPADJ_BUSINESS] = " & Trim(NoSource)
'        Set rst3 = DB.Execute(cSQL2)
'        If IsNull(rst3!TOTAL_AMOUNT) Then
'            xItem.ListSubItems.Add 8, , "0"
'        Else
'            xItem.ListSubItems.Add 8, , FormatNumber(CDbl(rst3!TOTAL_AMOUNT), 0)
'        End If
'        rst3.Close
        
'        rst.MoveNext
        
'        total1 = xItem.ListSubItems(2).Text - xItem.ListSubItems(7).Text
'        If total1 < 0 Then total1 = 0
'        total2 = FormatNumber(CDbl(total1) + CDbl(xItem.ListSubItems(3).Text), 0)
'        xItem.ListSubItems(4).Text = total2
        
'        cSQL2 = "SELECT * FROM [INCOME_PARTNERSHIP] WHERE [TCP_KEY] = " & strKey & " AND [PN_SOURCENO] = " & xItem.Text
    
'        Set rst3 = DB.Execute(cSQL2)
'        If rst3.EOF Then
'            Exit Sub
'        Else
'            xItem.ListSubItems(5).Text = rst3!PN_SCH_7A_STAT_INCOME
'        End If
'        rst3.Close
        
'        'nAmount = 0.7 * FormatNumber(CDbl(StatIncome), 0)
'        'If CDbl(nAmount) > CDbl(total2) Then
'            'xItem.ListSubItems(5).Text = total2
'        'Else
'            'xItem.ListSubItems(5).Text = nAmount
'        'End If
        
'        total3 = FormatNumber(CDbl(xItem.ListSubItems(5).Text) + CDbl(xItem.ListSubItems(8).Text), 0)
'        total4 = FormatNumber(CDbl(total2) - CDbl(total3), 0)
        
'        If CDbl(total4) < 0 Then
'            xItem.ListSubItems(6).Text = 0
'        Else
'            xItem.ListSubItems(6).Text = total4
'        End If
'    Wend
    
'    rst.Close

'End Sub
'Public Sub SetChargeableIncomeBizItems(str As String)
'       If txtYA = "2017" Or txtYA = "2018" Then
'        txtExemptionIncreaseChargeable = FormatNumber(CDec(str), 0)
'    Else
'        txtExemptionIncreaseChargeable = 0
'    End If
'        Call CalcLessExempChargeableIncome
'    End Sub
'    Private Sub txtExemptionIncreaseChargeable_Change()
'        Call CalcLessExempChargeableIncome
'    End Sub
'    Public Sub CalcLessExempChargeableIncome()
'        Dim total
                
'        txtExemptionIncreaseChargeableAfter.Text = FormatNumber(CDec(txtChargeableIn.Text) - CDec(txtExemptionIncreaseChargeable.Text), 0)
'    Call chargeable_apportionment
'    End Sub
'Public Sub SetDividendItems(str() As String)
'    txtDividendIn = str(0)
'    txtDivAttrInt = str(1)
'    txtDivOthers = str(2)
'    txtNetDividend = str(3)
'    txtDividendIncome = str(3)
'End Sub

'Public Sub SetInterestItems(str() As String)
'    txtInterestIn = str(0)
'    txtIntAttrInt = str(1)
'    txtIntOthers = str(2)
'    'txtNetIntIn = str(3)
'    txtInterestIncome = str(3)
'    txtIntDisallow = str(4)
'    txtTotalInterest = str(5)
'    'DannyLee 2012 SU6.1
'    txtDCAInterest = str(6)
'    txtDeemedInterest = str(7)
'End Sub

'Public Sub SetSundryItems(str() As String)
'    txtSundryIn = str(0)
'    txtDirExpenses3 = str(1)
'    txtSundryIncome = str(2)
'End Sub

'Public Sub SetRentalItems(str() As String)
'    txtRentalIn = str(0)
'    txtRentAttrIn = str(1)
'    txtRentAssess = str(2)
'    txtRentQuit = str(3)
'    txtRentInsur = str(4)
'    txtRentRepair = str(5)
'    txtRentRenewal = str(6)
'    txtOthers = str(7)
'    txtRentOthExp = str(8)
'    txtRentalInIBA = str(9)
'    txtOthersIBA = str(10)
'    txtRentAttrInIBA = str(11)
'    txtRentAssessIBA = str(12)
'    txtRentQuitIBA = str(13)
'    txtRentInsurIBA = str(14)
'    txtRentOthExpIBA = str(15)
'    txtRentRepairIBA = str(16)
'    txtRentRenewalIBA = str(17)
'    txtRentalIncome = str(18)
'End Sub

'Public Property Get GetDividendItems() As String()
'    Dim str(3) As String
'    str(0) = txtDividendIn
'    str(1) = txtDivAttrInt
'    str(2) = txtDivOthers
'    str(3) = txtDividendIncome
'    GetDividendItems = str
'End Property

'Public Property Get GetInterestItems() As String()
'    Dim str(7) As String
'    str(0) = txtInterestIn
'    str(1) = txtIntAttrInt
'    str(2) = txtIntOthers
'    str(3) = txtInterestIncome
'    str(4) = txtIntDisallow
'    str(5) = txtTotalInterest
'    'DannyLee 2012 SU6.1
'    str(6) = txtDCAInterest
'    str(7) = txtDeemedInterest
'    GetInterestItems = str
'End Property

''Public Property Get GetSundryItems() As String()
''    Dim str(2) As String
''    str(0) = txtSundryIn
''    str(1) = txtDirExpenses3
''    str(2) = txtSundryIncome
''    GetSundryItems = str
''End Property

'Public Property Get GetRentalItems() As String()
'    Dim str(17) As String
'    str(0) = txtRentalIn
'    str(1) = txtRentAttrIn
'    str(2) = txtRentAssess
'    str(3) = txtRentQuit
'    str(4) = txtRentInsur
'    str(5) = txtRentRepair
'    str(6) = txtRentRenewal
'    str(7) = txtOthers
'    str(8) = txtRentOthExp
'    str(9) = txtRentalInIBA
'    str(10) = txtOthersIBA
'    str(11) = txtRentAttrInIBA
'    str(12) = txtRentAssessIBA
'    str(13) = txtRentQuitIBA
'    str(14) = txtRentInsurIBA
'    str(15) = txtRentOthExpIBA
'    str(16) = txtRentRepairIBA
'    str(17) = txtRentRenewalIBA
'    GetRentalItems = str
'End Property

'Public Sub CalculateGeneralNonBusinessItemTotal(ByVal strNo As String)
'      Select Case Trim(strNo)
'        Case "1"
'            txtOthers = 0
'        Case "2"
'            txtInterestIn = 0
'        Case "3"
'            txtIntOthers = 0
'        Case "4"
'            txtDivOthers = 0
'        Case "5"
'            txtSundryIn = 0
'        Case "6"
'            txtDirExpenses3 = 0
'        Case "7"
'            txtRentOthExpIBA = 0
'    End Select
    
'    On Error Resume Next
'    If UBound(objNonBusinessItem) Then
'        If Err.Number = 9 Then
'            Exit Sub
'        End If
'    End If
    
'    Dim n, J As Integer
'    For J = 0 To UBound(objNonBusinessItem)
'        If objNonBusinessItem(J).TypeNo = strNo Then
'            For n = 0 To UBound(objNonBusinessItem(J).Item)
            
'                On Error Resume Next
'                If UBound(objNonBusinessItem(J).Item) Then
'                    If Err.Number = 9 Then
'                        Exit For
'                    End If
'                End If
                
'                Select Case Trim(objNonBusinessItem(J).TypeNo)
'                    Case "1"
'                        txtOthers = FormatNumber(CDbl(txtOthers) + CDbl(objNonBusinessItem(J).Item(n).amount), 0)
'                    Case "2"
'                        txtInterestIn = FormatNumber(CDbl(txtInterestIn) + CDbl(objNonBusinessItem(J).Item(n).amount), 0)
'                    Case "3"
'                        txtIntOthers = FormatNumber(CDbl(txtIntOthers) + CDbl(objNonBusinessItem(J).Item(n).amount), 0)
'                    Case "4"
'                        txtDivOthers = FormatNumber(CDbl(txtDivOthers) + CDbl(objNonBusinessItem(J).Item(n).amount), 0)
'                    Case "5"
'                        txtSundryIn = FormatNumber(CDbl(txtSundryIn) + CDbl(objNonBusinessItem(J).Item(n).amount), 0)
'                    Case "6"
'                        txtDirExpenses3 = FormatNumber(CDbl(txtDirExpenses3) + CDbl(objNonBusinessItem(J).Item(n).amount), 0)
'                    Case "7"
'                        txtRentOthExpIBA = FormatNumber(CDbl(txtRentOthExpIBA) + CDbl(objNonBusinessItem(J).Item(n).amount), 0)
'                End Select
'            Next
'        End If
'    Next
'End Sub

'Public Sub CalculateTotalNetIncome()
'    Dim dblDividend As Double
'    dblDividend = CDbl(txtDividendIn) - CDbl(txtDivAttrInt) - CDbl(txtDivOthers)
    
'    If dblDividend <= 0 Then
'        txtDividendIncome = 0
'    Else
'        txtDividendIncome = FormatNumber(dblDividend, 0)
'    End If
    
'    'LeeCC 2012 Disallowed Interest start
'    txtTotalInterest = FormatNumber((CDbl(txtIntAttrInt) - CDbl(txtIntDisallow)), 0) 'LeeCC 2012 SU2 format number

'    If txtTotalInterest < 0 Then txtTotalInterest = 0
    
'    Dim dblInterest As Double
'    'dblInterest = CDbl(txtInterestIn) - CDbl(txtTotalInterest) - CDbl(txtIntOthers)
'    'DannyLee 2012 SU6.1
'    If CDbl(txtDeemedInterest) > CDbl(txtDCAInterest) Then
'        dblInterest = CDbl(txtInterestIn) - CDbl(txtDCAInterest) + CDbl(txtDeemedInterest) - CDbl(txtTotalInterest) - CDbl(txtIntOthers)
'    Else
'        dblInterest = CDbl(txtInterestIn) - CDbl(txtTotalInterest) - CDbl(txtIntOthers)
'    End If
'    'LeeCC 2012 Disallowed Interest end
    
'    If dblInterest <= 0 Then
'        txtInterestIncome = 0
'    Else
'        txtInterestIncome = FormatNumber(dblInterest, 0)
'    End If
    
'    txtRentOthExp = FormatNumber(CDbl(txtRentRepair) + CDbl(txtRentRenewal) + CDbl(txtOthers), 0)
    
'    Dim dblRentalNoneIBA As Double
'    dblRentalNoneIBA = CDbl(txtRentalIn) - (CDbl(txtRentAttrIn) + CDbl(txtRentAssess) _
'    + CDbl(txtRentQuit) + CDbl(txtRentInsur) + CDbl(txtRentRepair) + CDbl(txtRentRenewal) + CDbl(txtOthers))
    
'    If dblRentalNoneIBA <= 0 Then dblRentalNoneIBA = 0
    
'    Dim dblRentalIBA As Double
'    dblRentalIBA = CDbl(txtRentalInIBA) - (CDbl(txtRentAttrInIBA) + CDbl(txtRentAssessIBA) _
'    + CDbl(txtRentQuitIBA) + CDbl(txtRentInsurIBA) + CDbl(txtRentRepairIBA) + CDbl(txtRentRenewalIBA) _
'    + CDbl(txtRentOthExpIBA)) - CDbl(txtOthersIBA)
    
'    If dblRentalIBA <= 0 Then dblRentalIBA = 0
    
'    If dblRentalNoneIBA <= 0 Then dblRentalNoneIBA = 0
'    If dblRentalIBA <= 0 Then dblRentalIBA = 0
    
'    If (dblRentalNoneIBA + dblRentalIBA) <= 0 Then
'        txtRentalIncome = 0
'    Else
'        txtRentalIncome = FormatNumber(dblRentalNoneIBA + dblRentalIBA, 0)
'    End If
   
'    Dim dblSundry As Double
'    dblSundry = CDbl(txtSundryIn) - CDbl(txtDirExpenses3)
    
'    If dblSundry <= 0 Then
'        txtSundryIncome = 0
'    Else
'        txtSundryIncome = FormatNumber(dblSundry, 0)
'    End If
'End Sub


''simkh 2012.1
'Public Sub SetIncreasedExport1(str() As String)
'    txtCompanySales = str(0)
'    txtCompanyCost = str(1)
'    txtCompanyValue1 = str(2)
'    txtCompanyPercent = str(3)
'    txtCompanyValueCurrent = str(4)
'    txtCompanyValueImmediately = str(5)
'    txtCompanyValue2 = str(6)
'    txtCompanyAllowanceValue = str(7)
'End Sub

''simkh 2012.1
'Public Sub SetIncreasedExport2(str() As String)
'    txtAgrValueCurrent = str(0)
'    txtAgrValueImmediately = str(1)
'    txtAgrValueTotal = str(2)
'    txtAgrCurrentAllowance = str(3)
'End Sub

''simkh 2012.1
'Public Sub SetExemption1(str() As String)
'    txtSigValueCurrent = str(0)
'    txtSigValueImmediately = str(1)
'    txtSigValueTotal = str(2)
'    txtSigPercent = str(3)
'    txtSigText1 = str(4)
'    txtSigExemption = str(5)
'End Sub

''simkh 2012.1
'Public Sub SetExemption2(str() As String)
'    txtMarketValueCurrent = str(0)
'    txtMarketTotal = str(1)
'    txtMarketStatutory = str(2)
'End Sub

''simkh 2012.1
'Public Sub SetExemption3(str() As String)
'    txtSerValueCurrent = str(0)
'    txtSerValueImmediately = str(1)
'    txtSerValueTotal = str(2)
'    txtSerText1 = str(3)
'    txtSerStatutory = str(4)
'End Sub

''LeeCC 2012.1 Export Allowance
'Private Sub LoadExportAllowanceCompany(strKey As String, strSourceNo As String, intCount As Integer)
'    cSQL = "SELECT * FROM [EXPORT_ALLOWANCE_COMPANY] WHERE EA_CO_TC_KEY = " & CDbl(strKey)
'    Set rst6 = DB.Execute(cSQL)

''    Dim intCount As Integer
''    intCount = 0
''    On Error Resume Next
''
''    If UBound(objCompany) > 0 Then
''        If Err.Number = 9 Then
''            intCount = 0
''            'ReDim objCompany(0)
''        End If
''    Else
''        intCount = CInt(UBound(objCompany)) + 1
''        'ReDim Preserve objCompany(CInt(UBound(objCompany)) + 1)
''    End If
    
'    ReDim Preserve objCompany(intCount)
    
'    If Not rst6.EOF Then
'        objCompany(intCount).strBusiness = strSourceNo
'        objCompany(intCount).strNo = rst6!EA_CO_KEY
'        objCompany(intCount).strSales = rst6!EA_CO_SALES
'        objCompany(intCount).strMaterial = rst6!EA_CO_MATERIAL
'        objCompany(intCount).strValueAdded = rst6!EA_CO_VALUEADDED
'        objCompany(intCount).strPercentage = rst6!EA_CO_PERCENTAGE
'        objCompany(intCount).strCurrent = rst6!EA_CO_CURR
'        objCompany(intCount).strImmediate = rst6!EA_CO_IMMEDIATE
'        objCompany(intCount).strIncreasedExport = rst6!EA_CO_INCREASE_EXPORT
'        objCompany(intCount).strAllowance = rst6!EA_CO_ALLOWANCE
'    Else
'        objCompany(intCount).strBusiness = strSourceNo
'        objCompany(intCount).strNo = intCount + 1
'        objCompany(intCount).strSales = 0
'        objCompany(intCount).strMaterial = 0
'        objCompany(intCount).strValueAdded = 0
'        objCompany(intCount).strPercentage = 0
'        objCompany(intCount).strCurrent = 0
'        objCompany(intCount).strImmediate = 0
'        objCompany(intCount).strIncreasedExport = 0
'        objCompany(intCount).strAllowance = 0
'    End If
'    rst6.Close
'End Sub

'Private Sub LoadExportAllowanceAgriculture(strKey As String, strSourceNo As String, intCount As Integer)
'    cSQL = "SELECT * FROM [EXPORT_ALLOWANCE_AGRICULTURE] WHERE EA_AGR_TC_KEY = " & CDbl(strKey)
'    Set rst6 = DB.Execute(cSQL)

''    Dim intCount As Integer
''    intCount = 0
''    On Error Resume Next
''
''    If UBound(objAgriculture) > 0 Then
''        If Err.Number = 9 Then
''            intCount = 0
''            'ReDim objAgriculture(0)
''        End If
''    Else
''        intCount = CInt(UBound(objAgriculture)) + 1
''        'ReDim Preserve objAgriculture(CInt(UBound(objAgriculture)) + 1)
''    End If
    
'    ReDim Preserve objAgriculture(intCount)
    
'    If Not rst6.EOF Then
'        objAgriculture(intCount).strBusiness = strSourceNo
'        objAgriculture(intCount).strNo = rst6!EA_AGR_KEY
'        objAgriculture(intCount).strCurrent = rst6!EA_AGR_CURR
'        objAgriculture(intCount).strImmediate = rst6!EA_AGR_IMMEDIATE
'        objAgriculture(intCount).strIncreasedExport = rst6!EA_AGR_INCREASE_EXPORT
'        objAgriculture(intCount).strAllowance = rst6!EA_AGR_ALLOWANCE
'    Else
'        objAgriculture(intCount).strBusiness = strSourceNo
'        objAgriculture(intCount).strNo = intCount + 1
'        objAgriculture(intCount).strCurrent = 0
'        objAgriculture(intCount).strImmediate = 0
'        objAgriculture(intCount).strIncreasedExport = 0
'        objAgriculture(intCount).strAllowance = 0
'    End If
'    rst6.Close
'End Sub

'Private Sub LoadExportAllowanceSignificant(strKey As String, strSourceNo As String, intCount As Integer)
'    cSQL = "SELECT * FROM [EXPORT_ALLOWANCE_SIGNIFICANT] WHERE EA_SIG_TC_KEY = " & CDbl(strKey)
'    Set rst6 = DB.Execute(cSQL)

''    Dim intCount As Integer
''    intCount = 0
''    On Error Resume Next
''
''    If UBound(objSignificant) > 0 Then
''        If Err.Number = 9 Then
''            intCount = 0
''            'ReDim objSignificant(0)
''        End If
''    Else
''        intCount = CInt(UBound(objSignificant)) + 1
''        'ReDim Preserve objSignificant(CInt(UBound(objSignificant)) + 1)
''    End If
    
'    ReDim Preserve objSignificant(intCount)
    
'    If Not rst6.EOF Then
'        objSignificant(intCount).strBusiness = strSourceNo
'        objSignificant(intCount).strNo = rst6!EA_SIG_KEY
'        objSignificant(intCount).strCurrent = rst6!EA_SIG_CURR
'        objSignificant(intCount).strImmediate = rst6!EA_SIG_IMMEDIATE
'        objSignificant(intCount).strIncreasedExport = rst6!EA_SIG_INCREASE_EXPORT
'        objSignificant(intCount).strPercentage = rst6!EA_SIG_PERCENTAGE
'        objSignificant(intCount).strExemption = rst6!EA_SIG_EXEMPTION
'    Else
'        objSignificant(intCount).strBusiness = strSourceNo
'        objSignificant(intCount).strNo = intCount + 1
'        objSignificant(intCount).strCurrent = 0
'        objSignificant(intCount).strImmediate = 0
'        objSignificant(intCount).strIncreasedExport = 0
'        objSignificant(intCount).strPercentage = 0
'        objSignificant(intCount).strExemption = 0
'    End If
'    rst6.Close
'End Sub

'Private Sub LoadExportAllowanceMarket(strKey As String, strSourceNo As String, intCount As Integer)
'    cSQL = "SELECT * FROM [EXPORT_ALLOWANCE_MARKET] WHERE EA_MKT_TC_KEY = " & CDbl(strKey)
'    Set rst6 = DB.Execute(cSQL)

''    Dim intCount As Integer
''    intCount = 0
''    On Error Resume Next
''
''    If UBound(objMarket) > 0 Then
''        If Err.Number = 9 Then
''            intCount = 0
''            'ReDim objMarket(0)
''        End If
''    Else
''        intCount = CInt(UBound(objMarket)) + 1
''        'ReDim Preserve objMarket(CInt(UBound(objMarket)) + 1)
''    End If
    
'    ReDim Preserve objMarket(intCount)
    
'    If Not rst6.EOF Then
'        Call LoadMarket(strKey, rst6!EA_MKT_KEY, strSourceNo)
'        objMarket(intCount).strBusiness = strSourceNo
'        objMarket(intCount).strNo = rst6!EA_MKT_KEY
'        objMarket(intCount).strCurrent = rst6!EA_MKT_CURR
'        objMarket(intCount).strExemption = rst6!EA_MKT_EXEMPTION
'    Else
'        objMarket(intCount).strBusiness = strSourceNo
'        objMarket(intCount).strNo = intCount + 1
'        objMarket(intCount).strCurrent = 0
'        objMarket(intCount).strExemption = 0
'    End If
'    rst6.Close
'End Sub

'Private Sub LoadExportAllowanceService(strKey As String, strSourceNo As String, intCount As Integer)
'    cSQL = "SELECT * FROM [EXPORT_ALLOWANCE_SERVICE] WHERE EA_SVR_TC_KEY = " & CDbl(strKey)
'    Set rst6 = DB.Execute(cSQL)

''    Dim intCount As Integer
''    intCount = 0
''    On Error Resume Next
''
''    If UBound(objService) > 0 Then
''        If Err.Number = 9 Then
''            intCount = 0
''            'ReDim objService(0)
''        End If
''    Else
''        intCount = CInt(UBound(objService)) + 1
''        'ReDim Preserve objService(CInt(UBound(objService)) + 1)
''    End If
     
'    ReDim Preserve objService(intCount)
     
'    If Not rst6.EOF Then
'        objService(intCount).strBusiness = strSourceNo
'        objService(intCount).strNo = rst6!EA_SVR_KEY
'        objService(intCount).strCurrent = rst6!EA_SVR_CURR
'        objService(intCount).strImmediate = rst6!EA_SVR_IMMEDIATE
'        objService(intCount).strIncreasedExport = rst6!EA_SVR_INCREASE_EXPORT
'        objService(intCount).strExemption = rst6!EA_SVR_EXEMPTION
'    Else
'        objService(intCount).strBusiness = strSourceNo
'        objService(intCount).strNo = intCount + 1
'        objService(intCount).strCurrent = 0
'        objService(intCount).strImmediate = 0
'        objService(intCount).strIncreasedExport = 0
'        objService(intCount).strExemption = 0
'    End If
'    rst6.Close
'End Sub

'Private Sub LoadMarket(strTCKey As String, strKey As String, strSourceNo As String)
'    cSQL1 = "SELECT * FROM [EXPORT_NEW_MARKET] WHERE ENM_TC_KEY = " & CDbl(strTCKey) & " and ENM_KEY = " & CDbl(strKey)
'    Set rst2 = DB.Execute(cSQL1)
    
'    If Not rst2.EOF Then
'        Dim intCount As Integer
'        intCount = 0

'        While Not rst2.EOF
'            On Error Resume Next
'            If UBound(objNewMarket) < 0 Then
'                If Err.Number = 9 Then
'                    intCount = 0
'                    'ReDim objNewMarket(0)
'                    'ReDim Preserve objNewMarket(CInt(UBound(objNewMarket)) + 1)
'                End If
'            Else
'                intCount = CInt(UBound(objNewMarket)) + 1
'            End If
            
'            ReDim Preserve objNewMarket(intCount)
'            objNewMarket(intCount).strBusiness = strSourceNo
'            objNewMarket(intCount).strMainNo = rst2!ENM_KEY
'            objNewMarket(intCount).strNo = intCount + 1
'            objNewMarket(intCount).strCountry = rst2!ENM_COUNTRY
'            objNewMarket(intCount).strAmount = rst2!ENM_AMOUNT
'            intCount = intCount + 1
'            rst2.MoveNext
'        Wend
'    End If
'    rst2.Close
'End Sub

'Private Sub InsertExportAllowanceCompany(strKey As String, strSourceNo As String)
'    cSQL = "DELETE FROM [EXPORT_ALLOWANCE_COMPANY] WHERE EA_CO_TC_KEY=" & CDbl(strKey)
'    DB.Execute (cSQL)
    
'    For i = 0 To UBound(objCompany)
'        If objCompany(i).strBusiness = strSourceNo Then
'            cSQL = "SELECT * FROM [EXPORT_ALLOWANCE_COMPANY]"
'            If rst.state = 1 Then
'            rst.Close
'            Set rst = Nothing
'            End If
            
'            rst.Open cSQL, DB, 3, 3
'            rst.AddNew
'            rst!EA_CO_TC_KEY = CDbl(strKey)
'            rst!EA_CO_KEY = objService(i).strNo
'            rst!EA_CO_REF_NO = txtRefNo.Text
'            rst!EA_CO_YA = txtYA.Text
'            rst!EA_CO_BUSINESS = CDbl(strSourceNo)
'            rst!EA_CO_SALES = objCompany(i).strSales
'            rst!EA_CO_MATERIAL = objCompany(i).strMaterial
'            rst!EA_CO_VALUEADDED = objCompany(i).strValueAdded
'            rst!EA_CO_PERCENTAGE = objCompany(i).strPercentage
'            rst!EA_CO_CURR = objCompany(i).strCurrent
'            rst!EA_CO_IMMEDIATE = objCompany(i).strImmediate
'            rst!EA_CO_INCREASE_EXPORT = objCompany(i).strIncreasedExport
'            rst!EA_CO_ALLOWANCE = objCompany(i).strAllowance
'            rst.Update
'            rst.Close
'            Exit For
'        End If
'    Next
'End Sub

'Private Sub InsertExportAllowanceAgriculture(strKey As String, strSourceNo As String)
'    cSQL = "DELETE FROM [EXPORT_ALLOWANCE_AGRICULTURE] WHERE EA_AGR_TC_KEY=" & CDbl(strKey)
'    DB.Execute (cSQL)
    
'    For i = 0 To UBound(objAgriculture)
'        If objAgriculture(i).strBusiness = strSourceNo Then
'            cSQL = "SELECT * FROM [EXPORT_ALLOWANCE_AGRICULTURE]"
'            rst.Open cSQL, DB, 3, 3
'            rst.AddNew
'            rst!EA_AGR_TC_KEY = CDbl(strKey)
'            rst!EA_AGR_KEY = objService(i).strNo
'            rst!EA_AGR_REF_NO = txtRefNo.Text
'            rst!EA_AGR_YA = txtYA.Text
'            rst!EA_AGR_BUSINESS = CDbl(strSourceNo)
'            rst!EA_AGR_CURR = objAgriculture(i).strCurrent
'            rst!EA_AGR_IMMEDIATE = objAgriculture(i).strImmediate
'            rst!EA_AGR_INCREASE_EXPORT = objAgriculture(i).strIncreasedExport
'            rst!EA_AGR_ALLOWANCE = objAgriculture(i).strAllowance
'            rst.Update
'            rst.Close
'            Exit For
'        End If
'    Next
    
'End Sub

'Private Sub InsertExportAllowanceSignificant(strKey As String, strSourceNo As String)
'    cSQL = "DELETE FROM [EXPORT_ALLOWANCE_SIGNIFICANT] WHERE EA_SIG_TC_KEY=" & CDbl(strKey)
'    DB.Execute (cSQL)
    
'    For i = 0 To UBound(objSignificant)
'        If objSignificant(i).strBusiness = strSourceNo Then
'            cSQL = "SELECT * FROM [EXPORT_ALLOWANCE_SIGNIFICANT]"
'            rst.Open cSQL, DB, 3, 3
'            rst.AddNew
'            rst!EA_SIG_TC_KEY = CDbl(strKey)
'            rst!EA_SIG_KEY = objService(i).strNo
'            rst!EA_SIG_REF_NO = txtRefNo.Text
'            rst!EA_SIG_YA = txtYA.Text
'            rst!EA_SIG_BUSINESS = CDbl(strSourceNo)
'            rst!EA_SIG_CURR = objSignificant(i).strCurrent
'            rst!EA_SIG_IMMEDIATE = objSignificant(i).strImmediate
'            rst!EA_SIG_INCREASE_EXPORT = objSignificant(i).strIncreasedExport
'            rst!EA_SIG_PERCENTAGE = objSignificant(i).strPercentage
'            rst!EA_SIG_EXEMPTION = objSignificant(i).strExemption
'            rst.Update
'            rst.Close
'            Exit For
'        End If
'    Next
    
'End Sub

'Private Sub InsertExportAllowanceMarket(strKey As String, strSourceNo As String)
'    cSQL = "DELETE FROM [EXPORT_ALLOWANCE_MARKET] WHERE EA_MKT_TC_KEY=" & CDbl(strKey)
'    DB.Execute (cSQL)
    
'    For i = 0 To UBound(objMarket)
'        If objMarket(i).strBusiness = strSourceNo Then
'            cSQL = "SELECT * FROM [EXPORT_ALLOWANCE_MARKET]"
'            rst.Open cSQL, DB, 3, 3
'            rst.AddNew
'            rst!EA_MKT_TC_KEY = CDbl(strKey)
'            rst!EA_MKT_KEY = objMarket(i).strNo
'            rst!EA_MKT_REF_NO = txtRefNo.Text
'            rst!EA_MKT_YA = txtYA.Text
'            rst!EA_MKT_BUSINESS = CDbl(strSourceNo)
'            rst!EA_MKT_CURR = objMarket(i).strCurrent
'            rst!EA_MKT_EXEMPTION = objMarket(i).strExemption
'            rst.Update
'            rst.Close
'            Call InsertNewMarket(strKey, objMarket(i).strNo, strSourceNo)
'            Exit For
'        End If
'    Next
'End Sub

'Private Sub InsertExportAllowanceService(strKey As String, strSourceNo As String)
'    cSQL = "DELETE FROM [EXPORT_ALLOWANCE_SERVICE] WHERE EA_SVR_TC_KEY=" & CDbl(strKey)
'    DB.Execute (cSQL)
    
'    For i = 0 To UBound(objService)
'        If objService(i).strBusiness = strSourceNo Then
'            cSQL = "SELECT * FROM [EXPORT_ALLOWANCE_SERVICE]"
'            rst.Open cSQL, DB, 3, 3
'            rst.AddNew
'            rst!EA_SVR_TC_KEY = CDbl(strKey)
'            rst!EA_SVR_KEY = objService(i).strNo
'            rst!EA_SVR_REF_NO = txtRefNo.Text
'            rst!EA_SVR_YA = txtYA.Text
'            rst!EA_SVR_BUSINESS = CDbl(strSourceNo)
'            rst!EA_SVR_CURR = objService(i).strCurrent
'            rst!EA_SVR_IMMEDIATE = objService(i).strImmediate
'            rst!EA_SVR_INCREASE_EXPORT = objService(i).strIncreasedExport
'            rst!EA_SVR_EXEMPTION = objService(i).strExemption
'            rst.Update
'            rst.Close
'            Exit For
'        End If
'    Next
'End Sub

'Private Sub InsertNewMarket(strTCKey As String, strKey As String, strSourceNo As String)
'    On Error Resume Next
'    If UBound(objNewMarket) Then
'        If Err.Number = 9 Then
'            Exit Sub
'        End If
'    End If
    
'    cSQL = "DELETE FROM [EXPORT_NEW_MARKET] WHERE ENM_TC_KEY = " & CDbl(strTCKey) & " And ENM_KEY = " & CDbl(strKey)
'    DB.Execute (cSQL)
    
'    For i = 0 To UBound(objNewMarket)
'        If objNewMarket(i).strBusiness = strSourceNo And objNewMarket(i).strMainNo = strKey Then
'            cSQL = "SELECT * FROM [EXPORT_NEW_MARKET]"
'            rst.Open cSQL, DB, 3, 3
'            rst.AddNew
'            rst!ENM_TC_KEY = CDbl(strTCKey)
'            rst!ENM_KEY = CDbl(strKey)
'            rst!ENM_ENMKEY = objNewMarket(i).strNo
'            rst!ENM_COUNTRY = objNewMarket(i).strCountry
'            rst!ENM_AMOUNT = objNewMarket(i).strAmount
'            rst.Update
'            rst.Close
'        End If
'    Next
'End Sub

'Private Sub LoadOpeningBalance(intS60FA As String)
'        'LeeCC 2012.1 Export Allowance b/f
'        cSQL = "SELECT [OB_SCHEDULE],[OB_BS_LOSS],[OB_INVESTMENT],[OB_SOURCENO],[OB_RA],[OB_SRNAMT], [OB_EXPORT] FROM [OPENING_BALANCE] WHERE [OB_REF_NO]='" & Trim(cRefNo) & "' AND [OB_YA]='" & Trim(cYA) & "' ORDER BY [OB_SOURCENO]"
'        Set rst = DB.Execute(cSQL)
'        If Not rst.EOF Then
'            Do While Not rst.EOF
'                If lstViewCA.ListItems.count > 0 Then
'                    For i = 1 To lstViewCA.ListItems.count
'                        If rst.Fields(3) = lstViewCA.ListItems(i).Text Then
'                        ' === csNgoh Julai 2008 === '
'                            '==Oscar2009.1==' S60FA
'                            If intS60FA = "Y" Then
'                                lstViewCA.ListItems(i).ListSubItems(2).Text = "0"
'                            Else
'                                If CDbl(lstViewCA.ListItems(i).Text) > 0 Then
'                                    lstViewCA.ListItems(i).ListSubItems(2).Text = FormatNumber(CDbl(rst.Fields(0)), 0) 'Balance b/f
'                                Else
'                                    lstViewCA.ListItems(i).ListSubItems(2).Text = "0"
'                                End If
'                            End If
'                            '==End Oscar2009.1=='
'                        End If
'                        ' === End csNgoh Julai 2008 === '
'                    Next
'                End If
                
'                Dim strNo As String
                
'                'LeeCC 2012.1 Export Allowance b/f
'                If lstViewEA.ListItems.count > 0 Then
'                    For i = 0 To UBound(objExportAllowance)
'                        If objExportAllowance(i).strBusiness = rst.Fields(3) Then
'                            strNo = i
'                            objExportAllowance(i).strBalance = rst!OB_EXPORT
'                            Select Case objExportAllowance(i).strType
'                                Case 1
'                                    objExportAllowance(i).strAllowance = objExportAllowance(i).strBalance + objExportAllowance(i).strAllowanceCompany
'                                Case 2
'                                    objExportAllowance(i).strAllowance = objExportAllowance(i).strBalance + objExportAllowance(i).strAllowanceAgriculture
'                                Case 3
'                                    objExportAllowance(i).strAllowance = objExportAllowance(i).strBalance + objExportAllowance(i).strAllowanceSignificant
'                                Case 4
'                                    objExportAllowance(i).strAllowance = objExportAllowance(i).strBalance + objExportAllowance(i).strAllowanceMarket
'                                Case 5
'                                    objExportAllowance(i).strAllowance = objExportAllowance(i).strBalance + objExportAllowance(i).strAllowanceService
'                                Case Else
'                                    objExportAllowance(i).strAllowance = objExportAllowance(i).strBalance
'                            End Select
'                        End If
'                    Next
'                End If
                
'                'FormatNumber(CDbl(lstView.ListItems(X).ListSubItems(20).Text)
'                If lstView.ListItems.count > 0 Then
'                    For i = 1 To lstView.ListItems.count 'O2008.1
'                        If rst.Fields(3) = lstView.ListItems(i).Text Then
'                            'NGOHCS CA2008
'                            If CDbl(rst!OB_RA) - CDbl(ListViewRA.ListItems(i).ListSubItems(7).Text) > 0 Then
'                                lstView.ListItems(i).ListSubItems(21).Text = FormatNumber(CDbl(rst!OB_RA) - CDbl(ListViewRA.ListItems(i).ListSubItems(7).Text), 0) 'RA Balance b/f
'                            Else
'                                lstView.ListItems(i).ListSubItems(21).Text = "0"
'                            End If
'                            If CDbl(rst!OB_INVESTMENT) - CDbl(ListViewITA.ListItems(i).ListSubItems(7).Text) > 0 Then
'                                lstView.ListItems(i).ListSubItems(28).Text = FormatNumber(CDbl(rst!OB_INVESTMENT) - CDbl(ListViewITA.ListItems(i).ListSubItems(7).Text), 0) 'ITA Balance b/f
'                            Else
'                                lstView.ListItems(i).ListSubItems(28).Text = "0"
'                            End If

'                            lstView.ListItems(i).ListSubItems(22).Text = FormatNumber(CDbl(lstView.ListItems(i).ListSubItems(21).Text) + CDbl(lstView.ListItems(i).ListSubItems(20)), 0)
'                            lstView.ListItems(i).ListSubItems(29).Text = FormatNumber(CDbl(lstView.ListItems(i).ListSubItems(28).Text) + CDbl(lstView.ListItems(i).ListSubItems(27)), 0)
                            
'                            'simkh 2012.1
''                           lstView.ListItems(i).ListSubItems(40).Text = FormatNumber(CDbl(lstView.ListItems(i).ListSubItems(39).Text) + CDbl(lstView.ListItems(i).ListSubItems(34)) Or CDbl(lstView.ListItems(i).ListSubItems(45)) Or CDbl(lstView.ListItems(i).ListSubItems(46)) Or CDbl(lstView.ListItems(i).ListSubItems(47)) Or CDbl(lstView.ListItems(48)), 0)
                            
'                        End If
'                            'NGOHCS CA2008 END
'                    Next
'                End If
                
'                'NGOHCS CA2008
'                If ListViewRA.ListItems.count > 0 Then 'O2008.1
'                    For i = 1 To ListViewRA.ListItems.count
'                        If rst.Fields(3) = ListViewRA.ListItems(i).Text Then
'                            ListViewRA.ListItems(i).ListSubItems(2).Text = FormatNumber(CDbl(rst!OB_RA), 0) 'Balance b/f
'                            ListViewRA.ListItems(i).ListSubItems(4).Text = FormatNumber(CDbl(ListViewRA.ListItems(i).ListSubItems(2).Text) + CDbl(ListViewRA.ListItems(i).ListSubItems(3).Text) - CDbl(ListViewRA.ListItems(i).ListSubItems(7).Text), 0)
'                            ListViewRA.ListItems(i).ListSubItems(6).Text = FormatNumber(CDbl(ListViewRA.ListItems(i).ListSubItems(4).Text) - CDbl(ListViewRA.ListItems(i).ListSubItems(5).Text) - CDbl(ListViewRA.ListItems(i).ListSubItems(8).Text), 0)
'                            If ListViewRA.ListItems(i).ListSubItems(6).Text < 0 Then
'                                ListViewRA.ListItems(i).ListSubItems(6).Text = 0
'                            End If
'                            If ListViewRA.ListItems(i).ListSubItems(4).Text < 0 Then
'                                ListViewRA.ListItems(i).ListSubItems(4).Text = 0
'                            End If
'                        End If
'                    Next
'                End If
'                 'NGOHCS CA2008 END
                 
'                 'NGOHCS CA2008
'                 If ListViewITA.ListItems.count > 0 Then
'                    For i = 1 To ListViewITA.ListItems.count
'                        If rst.Fields(3) = ListViewITA.ListItems(i).Text Then
'                            ListViewITA.ListItems(i).ListSubItems(2).Text = FormatNumber(CDbl(rst!OB_INVESTMENT), 0) 'Balance b/f
'                            ListViewITA.ListItems(i).ListSubItems(4).Text = FormatNumber(CDbl(ListViewITA.ListItems(i).ListSubItems(2).Text) + CDbl(ListViewITA.ListItems(i).ListSubItems(3).Text) - CDbl(ListViewITA.ListItems(i).ListSubItems(7).Text), 0)
'                            ListViewITA.ListItems(i).ListSubItems(6).Text = FormatNumber(CDbl(ListViewITA.ListItems(i).ListSubItems(4).Text) - CDbl(ListViewITA.ListItems(i).ListSubItems(5).Text) - CDbl(ListViewITA.ListItems(i).ListSubItems(8).Text), 0)
'                            If ListViewITA.ListItems(i).ListSubItems(6).Text < 0 Then
'                               ListViewITA.ListItems(i).ListSubItems(6).Text = 0
'                            End If
'                            If ListViewITA.ListItems(i).ListSubItems(4).Text < 0 Then
'                               ListViewITA.ListItems(i).ListSubItems(4).Text = 0
'                            End If
'                        End If
'                    Next
'                 End If
'                 'NGOHCS CA2008 END
                 
                 
'                '==Oscar2009.1==' Business Loss: Balance b/f S60FA
'                If intS60FA = "Y" Then
'                    ULBalance = "0"
'                Else
'                    ULBalance = CDbl(ULBalance) + CDbl(rst.Fields(1))
'                End If
'                '==End Oscar2009.1=='
                
'                ITABalance = CDbl(ITABalance) + CDbl(rst.Fields(2))
'                RABalance = CDbl(RABalance) + CDbl(rst.Fields(4))
'                SABalance = CDbl(SABalance) + CDbl(rst!OB_SRNAMT)

'                txtULBalbf = FormatNumber(CDbl(ULBalance), 0)
'                txtITABalbf = FormatNumber(CDbl(ITABalance), 0)
'                txtRABalbf = FormatNumber(CDbl(RABalance), 0)
'                txtBlnBf = FormatNumber(CDbl(SABalance), 0) 'Pin Taxcom C+ v2005.4 SP2

'                rst.MoveNext
'            Loop
'        End If
'        rst.Close
'End Sub

'Private Sub RefreshExemptionValue()
'    If lstView.ListItems.count > 0 Then 'PIN TAXCOM c+ 2007 PHASE 3 RELEASE 2
'        For i = 1 To lstView.ListItems.count
'            cSQL = "SELECT * FROM [TAX_COMPUTATION] WHERE [TC_REF_NO]='" & Trim(txtRefNo.Text) & "' AND [TC_YA]='" & Trim(txtYA.Text) & "' AND [TC_BUSINESS]=" & lstView.ListItems(i).Text
'            'DB.Execute (cSQL)
'            Set rst2 = DB.Execute(cSQL)
'            'RA
'            If rst2![TC_RA_TOTAL1] <> 0 Or rst2![TC_ITA_TOTAL1] <> 0 Or rst2![TC_RA_RESTRICTAMOUNT] <> 0 Or rst2![TC_ITA_RESTRICTAMOUNT] <> 0 Then
'              'O2008.1
''              If lstView.ListItems(I).ListSubItems(21).Text = 0 And lstView.ListItems(I).ListSubItems(20).Text = 0 And lstView.ListItems(I).ListSubItems(22).Text = 0 And lstView.ListItems(I).ListSubItems(24).Text = 0 Then
'                If lstView.ListItems(i).ListSubItems(20).Text = 0 And lstView.ListItems(i).ListSubItems(24).Text = 0 Then
'                        lstView.ListItems(i).ListSubItems(11).Text = lstView.ListItems(i).ListSubItems(11).Text
'                Else
'                    If (lstView.ListItems(i).ListSubItems(10).Text * lstView.ListItems(i).ListSubItems(23).Text / 100) < lstView.ListItems(i).ListSubItems(22).Text Then
'                         lstView.ListItems(i).ListSubItems(11).Text = FormatNumber((lstView.ListItems(i).ListSubItems(10).Text * lstView.ListItems(i).ListSubItems(23).Text / 100), 0)
'                         lstView.ListItems(i).ListSubItems(24).Text = FormatNumber((lstView.ListItems(i).ListSubItems(10).Text * lstView.ListItems(i).ListSubItems(23).Text / 100), 0)
'                         ListViewRA.ListItems(i).ListSubItems(5).Text = lstView.ListItems(i).ListSubItems(11).Text
'                    Else
'                         lstView.ListItems(i).ListSubItems(11).Text = lstView.ListItems(i).ListSubItems(22).Text
'                         lstView.ListItems(i).ListSubItems(24).Text = FormatNumber((lstView.ListItems(i).ListSubItems(10).Text * lstView.ListItems(i).ListSubItems(23).Text / 100), 0)
'                         ListViewRA.ListItems(i).ListSubItems(5).Text = lstView.ListItems(i).ListSubItems(11).Text
'                    End If
'                End If
                
'                'ITA
'                'O2008.1
''                If lstView.ListItems(I).ListSubItems(28).Text = 0 And lstView.ListItems(I).ListSubItems(27).Text = 0 And lstView.ListItems(I).ListSubItems(29).Text = 0 And lstView.ListItems(I).ListSubItems(31).Text = 0 Then
'                If lstView.ListItems(i).ListSubItems(27).Text = 0 And lstView.ListItems(i).ListSubItems(31).Text = 0 Then
'                   lstView.ListItems(i).ListSubItems(12).Text = lstView.ListItems(i).ListSubItems(12).Text

'                Else
'                    If (lstView.ListItems(i).ListSubItems(10).Text * lstView.ListItems(i).ListSubItems(30).Text / 100) < lstView.ListItems(i).ListSubItems(29).Text Then 'TC_ITA_TOTAL1
'                         lstView.ListItems(i).ListSubItems(12).Text = FormatNumber((lstView.ListItems(i).ListSubItems(10).Text * lstView.ListItems(i).ListSubItems(30).Text / 100), 0)
'                         lstView.ListItems(i).ListSubItems(31).Text = FormatNumber((lstView.ListItems(i).ListSubItems(10).Text * lstView.ListItems(i).ListSubItems(30).Text / 100), 0)
'                         ListViewITA.ListItems(i).ListSubItems(5).Text = lstView.ListItems(i).ListSubItems(12).Text
'                    Else
'                         lstView.ListItems(i).ListSubItems(12).Text = lstView.ListItems(i).ListSubItems(29).Text
'                         lstView.ListItems(i).ListSubItems(31).Text = FormatNumber((lstView.ListItems(i).ListSubItems(10).Text * lstView.ListItems(i).ListSubItems(30).Text / 100), 0)
'                         'Utilisi during the year
'                         ListViewITA.ListItems(i).ListSubItems(5).Text = lstView.ListItems(i).ListSubItems(12).Text
'                    End If
'                End If
'            End If
            
'                Dim n As Integer
'                For n = 0 To UBound(objExportAllowance)
'                    If objExportAllowance(n).strBusiness = lstView.ListItems(i).Text Then
'                            Select Case objExportAllowance(n).strType
'                                Case 1
'                                    objExportAllowance(n).strAllowance = FormatNumber(CDbl(objExportAllowance(n).strBalance) + CDbl(objExportAllowance(n).strAllowanceCompany), 0)
'                                Case 2
'                                    objExportAllowance(n).strAllowance = FormatNumber(CDbl(objExportAllowance(n).strBalance) + CDbl(objExportAllowance(n).strAllowanceAgriculture), 0)
'                                Case 3
'                                    objExportAllowance(n).strAllowance = FormatNumber(CDbl(objExportAllowance(n).strBalance) + CDbl(objExportAllowance(n).strAllowanceSignificant), 0)
'                                Case 4
'                                    objExportAllowance(n).strAllowance = FormatNumber(CDbl(objExportAllowance(n).strBalance) + CDbl(objExportAllowance(n).strAllowanceMarket), 0)
'                                Case 5
'                                    objExportAllowance(n).strAllowance = FormatNumber(CDbl(objExportAllowance(n).strBalance) + CDbl(objExportAllowance(n).strAllowanceService), 0)
'                                Case Else
'                                    objExportAllowance(n).strAllowance = FormatNumber(CDbl(objExportAllowance(n).strBalance), 0)
'                            End Select
    
'                            If CDbl(objExportAllowance(n).strAllowance) <= (CDbl(lstView.ListItems(i).ListSubItems(10).Text) * objExportAllowance(n).strRestrictRate / 100) Then
'                                objExportAllowance(n).strUtilised = FormatNumber(objExportAllowance(n).strAllowance, 0)
'                            Else
'                                objExportAllowance(n).strUtilised = FormatNumber((CDbl(lstView.ListItems(i).ListSubItems(10).Text) * objExportAllowance(n).strRestrictRate / 100), 0)
'                            End If
                            
'                            objExportAllowance(n).strCarryForward = FormatNumber(CDbl(objExportAllowance(n).strAllowance) - CDbl(objExportAllowance(n).strUtilised), 0)

'                    End If
'                Next
'            rst2.Close
'        Next
'    End If
'End Sub
#End Region
#Region "REFERENCE ADJUSTED INCOME"
    'Option Explicit
    'Dim rst1 As New ADODB.Recordset, rst2 As New ADODB.Recordset, rs As New ADODB.Recordset
    'Dim cSQL2 As String, VSQL As String
    'Dim search_click As Boolean
    'Dim nNo As Integer, pnl_key As Integer
    'Dim NTax_In, Tax_In, NA_Exp, Revenue_Exp, Oth_Exp, NA_Loss, RealFETrade As Double
    'Dim Interest_Restrict As Double, Other_Business As Double
    'Dim sForm As Form
    'Dim i As Integer

    'Private Function AllowSave() As Boolean
    '    AllowSave = True
    'End Function

    'Private Sub cmdAdd7_Click()
    '    cTCType = "EDIT Other Deduction"
    '    frmOtherDeduction.Show()
    'End Sub

    'Private Sub cmdAddMiningExp_Click()
    '    If Not AllowSave Then Exit Sub
    '    cTCType = "EDIT Mining Expenses"
    '    frmMiningExpenses.Show()
    'End Sub

    'Private Sub cmdMiningAllowing_Click()
    '    If Not AllowSave Then Exit Sub
    '    cTCType = "EDIT Mining Allownance"
    '    frmMiningAllowance.Show()
    'End Sub

    'Private Sub cmdSurplusMiningAllowance_Click()
    '    cTCType = "EDIT Surplus Recovered Mining Expenditure"
    '    frmSurplusRecoveredME.Show()
    'End Sub

    'Private Sub cmdSave_Click()
    '    Dim cmd As New ADODB.Command
    '    Dim business_type As String
    '    Dim pnlbalance As Double, totbusinessincome As Double
    '    Dim adjbusinessincome As Double, adjincome As Double

    '    If Not AllowSave Then Exit Sub

    '    If CDbl(txtBalProfit) = 0 Then
    '        pnlbalance = txtBalLoss
    '    ElseIf CDbl(txtBalLoss) = 0 Then
    '        pnlbalance = txtBalProfit
    '    End If

    '    If CDbl(txtTotBsProfit) = 0 Then
    '        totbusinessincome = txtTotBsLoss
    '    ElseIf CDbl(txtTotBsLoss) = 0 Then
    '        totbusinessincome = txtTotBsProfit
    '    End If

    '    If CDbl(txtTotBIProfit) = 0 Then
    '        adjbusinessincome = txtTotBILoss
    '    ElseIf CDbl(txtTotBILoss) = 0 Then
    '        adjbusinessincome = txtTotBIProfit
    '    End If

    '    If CDbl(txtAdIn) = 0 Then
    '        adjincome = txtAdLoss
    '    ElseIf CDbl(txtAdLoss) = 0 Then
    '        adjincome = txtAdIn
    '    End If

    '    cmd.ActiveConnection = DB
    '    cSQL = "UPDATE [TAX_COMPUTATION] SET [TC_CO_NAME]=?,[TC_ROC]='" & txtCoReg(2) & "'," _
    '    & "[TC_AI_PNL_BAL]='" & FormatNumber(CDbl(pnlbalance), 0) & "',[TC_AI_DIVIDEND]='" & txtDividend & "'," _
    '    & "[TC_AI_RENTAL]='" & txtRental & "',[TC_AI_ROYALTY]='" & txtRoyalty & "',[TC_AI_INTEREST]='" & txtInterest & "'," _
    '    & "[TC_AI_SEC4A]='" & txtSection4A & "',[TC_AI_OTH_BS_IN]='" & txtOthBsIn & "',[TC_AI_TOT_NONBS_IN]='" & txtTotNonBs & "',[TC_AI_TOT_BS_IN]='" & FormatNumber(CDbl(totbusinessincome), 0) & "'," _
    '    & "[TC_AI_ADJ_BS_IN_NA_LOS]='" & txtNALoss & "',[TC_AI_ADJ_BS_IN_NT_IN]='" & txtNTaxIn & "',[TC_AI_ADJ_BS_IN_TAX_IN]='" & txtTaxIn & "'," _
    '    & "[TC_AI_TOT_ADJ_BS_IN]='" & FormatNumber(CDbl(adjbusinessincome), 0) & "',[TC_AI_ADJ_BS_EXP_INT]='" & txtInterestRestricted & "',[TC_AI_ADJ_BS_EXP_NA_EXP]='" & txtNAExp & "',[TC_AI_ADJ_BS_EXP_RV_EXP]='" & txtRevenueExp & "'," _
    '    & "[TC_AI_ADJ_BS_EXP_CLAIM]='" & txtOthExp & "',[TC_AI_TOT_ADJ_BS_EXP]='" & txtTotBSExp & "',[TC_AI_ADJ_IN_LOSS]='" & FormatNumber(CDbl(adjincome), 0) & "'," _
    '    & "[TC_OTHERDEDUCTION]='" & txtOtherDeduc & "', [TC_SURPLUSRECOVERED]='" & txtSurplusMiningAllowance & "', [TC_MININGALLOWNANCE]='" & txtMiningAllowing & "', [TC_MININGEXPENSES]='" & txtAddMiningExp & "'" _
    '    & " WHERE [TC_KEY] =" & CDbl(vAdjIncomeKey)
    '    ' DB.Execute (cSQL)
    '    cmd.CommandText = cSQL
    '    cmd.Parameters.Append cmd.CreateParameter("2", adVarWChar, adParamInput, 255, txtCoName(0))
    '    rst.Open cmd
    '    cmd = Nothing
    '    rst = Nothing

    '    InsertlvGeneral()

    '    If AdjIncome_Flag = True Then
    '        'Update Income Calculation
    '        VSQL = "SELECT * FROM [TAX_COMPUTATION] WHERE [TC_REF_NO]='" & Trim(txtRefNo) & "' AND [TC_YA]='" & Trim(txtYA) & "' AND [TC_BUSINESS]=1"
    '        rs = DB.Execute(VSQL)
    '        If Not rs.EOF Then
    '            vIncomeCalKey = rs!TC_KEY

    '            Load frmIncomeCalculationEdit
    '            frmIncomeCalculationEdit.txtBtnCheck.Text = "True"
    '            frmIncomeCalculationEdit.ToUpdate_IncomeCalc()
    '        End If
    '        rs.Close()
    '        Unload Me
    '    Else
    '        'Update Income Calculation
    '        VSQL = "SELECT * FROM [TAX_COMPUTATION] WHERE [TC_REF_NO]='" & Trim(txtRefNo) & "' AND [TC_YA]='" & Trim(txtYA) & "' AND [TC_BUSINESS]=1"
    '        rs = DB.Execute(VSQL)
    '        If Not rs.EOF Then
    '            IncomeCal_Flag = True
    '            vIncomeCalKey = rs!TC_KEY
    '            Load frmIncomeCalculationEdit
    '            frmIncomeCalculationEdit.txtBtnCheck.Text = "True"
    '            frmIncomeCalculationEdit.ToUpdate_IncomeCalc()
    '            IncomeCal_Flag = False
    '        End If
    '        rs.Close()

    '        'If BALANCESHEET = False Then
    '        MsgBox("Record Updated !", vbInformation, "Taxcom")
    '        ' End If


    '        'Save Before Exit
    '        boolSaveComplete = True
    '        ResetDataChange Me
    '        'Unload Me
    '    End If
    'End Sub

    'Private Sub RefreshcmdSave_Click()
    '    Dim cmd As New ADODB.Command
    '    Dim business_type As String
    '    Dim pnlbalance As Double, totbusinessincome As Double
    '    Dim adjbusinessincome As Double, adjincome As Double

    '    If Not AllowSave Then Exit Sub
    '    If CDbl(txtBalProfit) = 0 Then
    '        pnlbalance = txtBalLoss
    '    ElseIf CDbl(txtBalLoss) = 0 Then
    '        pnlbalance = txtBalProfit
    '    End If

    '    If CDbl(txtTotBsProfit) = 0 Then
    '        totbusinessincome = txtTotBsLoss
    '    ElseIf CDbl(txtTotBsLoss) = 0 Then
    '        totbusinessincome = txtTotBsProfit
    '    End If

    '    If CDbl(txtTotBIProfit) = 0 Then
    '        adjbusinessincome = txtTotBILoss
    '    ElseIf CDbl(txtTotBILoss) = 0 Then
    '        adjbusinessincome = txtTotBIProfit
    '    End If

    '    If CDbl(txtAdIn) = 0 Then
    '        adjincome = txtAdLoss
    '    ElseIf CDbl(txtAdLoss) = 0 Then
    '        adjincome = txtAdIn
    '    End If
    '    cmd.ActiveConnection = DB
    '    cSQL = "UPDATE [TAX_COMPUTATION] SET [TC_CO_NAME]=?,[TC_ROC]='" & txtCoReg(2) & "'," _
    '    & "[TC_AI_PNL_BAL]='" & FormatNumber(CDbl(pnlbalance), 0) & "',[TC_AI_DIVIDEND]='" & txtDividend & "'," _
    '    & "[TC_AI_RENTAL]='" & txtRental & "',[TC_AI_ROYALTY]='" & txtRoyalty & "',[TC_AI_INTEREST]='" & txtInterest & "'," _
    '    & "[TC_AI_SEC4A]='" & txtSection4A & "',[TC_AI_OTH_BS_IN]='" & txtOthBsIn & "',[TC_AI_TOT_NONBS_IN]='" & txtTotNonBs & "',[TC_AI_TOT_BS_IN]='" & FormatNumber(CDbl(totbusinessincome), 0) & "'," _
    '    & "[TC_AI_ADJ_BS_IN_NA_LOS]='" & txtNALoss & "',[TC_AI_ADJ_BS_IN_NT_IN]='" & txtNTaxIn & "',[TC_AI_ADJ_BS_IN_TAX_IN]='" & txtTaxIn & "'," _
    '    & "[TC_AI_TOT_ADJ_BS_IN]='" & FormatNumber(CDbl(adjbusinessincome), 0) & "',[TC_AI_ADJ_BS_EXP_INT]='" & txtInterestRestricted & "',[TC_AI_ADJ_BS_EXP_NA_EXP]='" & txtNAExp & "',[TC_AI_ADJ_BS_EXP_RV_EXP]='" & txtRevenueExp & "'," _
    '    & "[TC_AI_ADJ_BS_EXP_CLAIM]='" & txtOthExp & "',[TC_AI_TOT_ADJ_BS_EXP]='" & txtTotBSExp & "',[TC_AI_ADJ_IN_LOSS]='" & FormatNumber(CDbl(adjincome), 0) & "'," _
    '    & "[TC_OTHERDEDUCTION]='" & txtOtherDeduc & "', [TC_SURPLUSRECOVERED]='" & txtSurplusMiningAllowance & "', [TC_MININGALLOWNANCE]='" & txtMiningAllowing & "', [TC_MININGEXPENSES]='" & txtAddMiningExp & "'" _
    '    & " WHERE [TC_KEY] =" & CDbl(vAdjIncomeKey)
    '    ' DB.Execute (cSQL)
    '    cmd.CommandText = cSQL
    '    cmd.Parameters.Append cmd.CreateParameter("2", adVarWChar, adParamInput, 255, txtCoName(0))
    '    rst.Open cmd
    '    cmd = Nothing
    '    rst = Nothing

    '    InsertlvGeneral()

    '    If AdjIncome_Flag = True Then
    '        'Update Income Calculation
    '        VSQL = "SELECT * FROM [TAX_COMPUTATION] WHERE [TC_REF_NO]='" & Trim(txtRefNo) & "' AND [TC_YA]='" & Trim(txtYA) & "' AND [TC_BUSINESS]=1"
    '        rs = DB.Execute(VSQL)
    '        If Not rs.EOF Then
    '            vIncomeCalKey = rs!TC_KEY
    '            Load frmIncomeCalculationEdit
    '            frmIncomeCalculationEdit.txtBtnCheck.Text = "True"
    '            frmIncomeCalculationEdit.ToUpdate_IncomeCalc()
    '        End If
    '        rs.Close()
    '        Unload Me
    '    Else
    '        'Update Income Calculation
    '        VSQL = "SELECT * FROM [TAX_COMPUTATION] WHERE [TC_REF_NO]='" & Trim(txtRefNo) & "' AND [TC_YA]='" & Trim(txtYA) & "' AND [TC_BUSINESS]=1"
    '        rs = DB.Execute(VSQL)
    '        If Not rs.EOF Then
    '            IncomeCal_Flag = True
    '            vIncomeCalKey = rs!TC_KEY
    '            Load frmIncomeCalculationEdit
    '            frmIncomeCalculationEdit.txtBtnCheck.Text = "True"
    '            frmIncomeCalculationEdit.ToUpdate_IncomeCalc()
    '            IncomeCal_Flag = False
    '        End If
    '        rs.Close()

    '        boolSaveComplete = True
    '        ResetDataChange Me
    '    End If
    'End Sub

    'Private Sub InsertlvGeneral()
    '    Dim J As Integer

    '    cSQL = "DELETE FROM [NON_ALLOW_LOSS] Where [NL_REF_NO]='" & Trim(txtRefNo) & "' and [NL_YA]='" & Trim(txtYA) & "' and [NL_SOURCENO]= " & Trim(txtSourceNo) & ""
    '    DB.Execute(cSQL)
    '    cSQL = "DELETE FROM [TAXABLE_INCOME] Where [TI_REF_NO]='" & Trim(txtRefNo) & "' and [TI_YA]='" & Trim(txtYA) & "' and [TI_SOURCENO]= " & Trim(txtSourceNo) & ""
    '    DB.Execute(cSQL)
    '    cSQL = "DELETE FROM [REVENUE_EXPENDITURE] Where [RE_REF_NO]='" & Trim(txtRefNo) & "' and [RE_YA]='" & Trim(txtYA) & "' and [RE_SOURCENO]= " & Trim(txtSourceNo) & ""
    '    DB.Execute(cSQL)
    '    cSQL = "DELETE FROM [OTHER_EXPENDITURE] Where [OE_REF_NO]='" & Trim(txtRefNo) & "' and [OE_YA]='" & Trim(txtYA) & "' and [OE_SOURCENO]= " & Trim(txtSourceNo) & ""
    '    DB.Execute(cSQL)
    '    cSQL = "DELETE FROM [OTHER_DEDUCTION] Where [OD_REF_NO]='" & Trim(txtRefNo) & "' and [OD_YA]='" & Trim(txtYA) & "' and [OD_SOURCENO]= " & Trim(txtSourceNo) & ""
    '    DB.Execute(cSQL)
    '    cSQL = "DELETE FROM [SURPLUS_RECOVERED] Where [SR_REF_NO]='" & Trim(txtRefNo) & "' and [SR_YA]='" & Trim(txtYA) & "' and [SR_SOURCENO]= " & Trim(txtSourceNo) & ""
    '    DB.Execute(cSQL)
    '    cSQL = "DELETE FROM [MINING_ALLOWNANCE] Where [MA_REF_NO]='" & Trim(txtRefNo) & "' and [MA_YA]='" & Trim(txtYA) & "' and [MA_SOURCENO]= " & Trim(txtSourceNo) & ""
    '    DB.Execute(cSQL)
    '    cSQL = "DELETE FROM [MINING_EXPENSES] Where [ME_REF_NO]='" & Trim(txtRefNo) & "' and [ME_YA]='" & Trim(txtYA) & "' and [ME_SOURCENO]= " & Trim(txtSourceNo) & ""
    '    DB.Execute(cSQL)
    '    If lvGeneral.ListItems.count < 1 Then
    '        Exit Sub
    '    End If

    '    For J = 1 To lvGeneral.ListItems.count

    '        Select Case Trim(lvGeneral.ListItems(J).Text)

    '            Case "1"
    '                InsertlvGeneral_NonAllowLoss(J)
    '            Case "3"
    '                InsertlvGeneral_TaxableIncome(J)
    '            Case "5"
    '                InsertlvGeneral_RevenueExpenditure(J)
    '            Case "6"
    '                InsertlvGeneral_OtherExpenditure(J)

    '            Case "7"
    '                InsertlvGeneral_OtherDedeuction(J)  'PIN TAXCOMC+ V2005.3

    '            Case "8"
    '                InsertlvGeneral_SurplusRecovered(J) 'PIN Phase 3 Release 2

    '            Case "9"
    '                InsertlvGeneral_MiningAllownance(J) 'PIN Phase 3 Release 2
    '            Case "10"
    '                InsertlvGeneral_MiningExpenses(J) 'PIN Phase 3 Release 2
    '        End Select

    '    Next

    'End Sub

    'Private Sub InsertlvGeneral_NonAllowLoss(i As Integer)
    '    Dim nNo As Integer

    '    If Trim(lvGeneral.ListItems(i).ListSubItems(4).Text) = "New" Then
    '        cSQL = "SELECT * FROM [NON_ALLOW_LOSS] ORDER BY [NL_KEY]"
    '        rst = DB.Execute(cSQL)

    '        nNo = 0
    '        If Not rst.EOF Then
    '            While Not rst.EOF
    '                nNo = Val(rst.Fields(0))
    '                rst.MoveNext()
    '            End While
    '        End If
    '        nNo = nNo + 1
    '        rst.Close()
    '        cSQL = "SELECT * FROM [NON_ALLOW_LOSS]"

    '        rst.Open(cSQL, DB, 3, 3) 'C2007.4
    '        rst.AddNew()
    '        rst!NL_KEY = nNo
    '        rst!NL_REF_NO = Trim(txtRefNo.Text)
    '        rst!NL_YA = Trim(txtYA.Text)
    '        rst!NL_DESC = lvGeneral.ListItems(i).ListSubItems(2)
    '        rst!NL_AMOUNT = lvGeneral.ListItems(i).ListSubItems(3)
    '        rst!NL_CATEGORIZED = lvGeneral.ListItems(i).ListSubItems(5)
    '        rst!NL_SOURCENO = Trim(txtSourceNo)
    '        rst.Update()
    '        rst.Close()
    '    Else
    '        cSQL = "SELECT * FROM [NON_ALLOW_LOSS] ORDER BY [NL_KEY]"
    '        rst = DB.Execute(cSQL)

    '        nNo = 0
    '        If Not rst.EOF Then
    '            While Not rst.EOF
    '                nNo = Val(rst.Fields(0))
    '                rst.MoveNext()
    '            End While
    '        End If
    '        nNo = nNo + 1
    '        rst.Close()

    '        ' nNo = Val(Trim(lvGeneral.ListItems(I).ListSubItems(4).Text))
    '        cSQL = "SELECT * FROM [NON_ALLOW_LOSS] Where [NL_KEY] = " & nNo

    '        rst.Open(cSQL, DB, 3, 3) 'C2007.4
    '        rst.AddNew()
    '        rst!NL_KEY = nNo
    '        rst!NL_REF_NO = Trim(txtRefNo.Text)
    '        rst!NL_YA = Trim(txtYA.Text)
    '        rst!NL_DESC = lvGeneral.ListItems(i).ListSubItems(2)
    '        rst!NL_AMOUNT = lvGeneral.ListItems(i).ListSubItems(3)
    '        rst!NL_CATEGORIZED = lvGeneral.ListItems(i).ListSubItems(5)
    '        rst!NL_SOURCENO = Trim(txtSourceNo)
    '        rst.Update()
    '        rst.Close()
    '    End If

    '    '        rst.Open cSQL, DB, 3, 3
    '    '        rst.AddNew
    '    '        rst!NL_KEY = nNo
    '    '        rst!NL_REF_NO = Trim(txtRefNo.Text)
    '    '        rst!NL_YA = Trim(txtYA.Text)
    '    '        rst!NL_DESC = lvGeneral.ListItems(I).ListSubItems(2)
    '    '        rst!NL_AMOUNT = lvGeneral.ListItems(I).ListSubItems(3)
    '    '        rst!NL_CATEGORIZED = lvGeneral.ListItems(I).ListSubItems(5)
    '    '        rst!NL_SOURCENO = Trim(txtSourceNo)
    '    '        rst.Update
    '    '        rst.Close

    'End Sub

    'Private Sub InsertlvGeneral_TaxableIncome(i As Integer)
    '    Dim nNo As Integer

    '    If Trim(lvGeneral.ListItems(i).ListSubItems(4).Text) = "New" Then
    '        cSQL = "SELECT * FROM [TAXABLE_INCOME] ORDER BY [TI_KEY]"
    '        rst = DB.Execute(cSQL)

    '        nNo = 0
    '        If Not rst.EOF Then
    '            While Not rst.EOF
    '                nNo = Val(rst.Fields(0))
    '                rst.MoveNext()
    '            End While
    '        End If
    '        nNo = nNo + 1
    '        rst.Close()
    '        cSQL = "SELECT * FROM [TAXABLE_INCOME]"
    '    Else
    '        nNo = Val(Trim(lvGeneral.ListItems(i).ListSubItems(4).Text))
    '        cSQL = "SELECT * FROM [TAXABLE_INCOME] Where [TI_KEY] = " & nNo
    '    End If

    '    rst.Open(cSQL, DB, 3, 3)
    '    rst.AddNew()
    '    rst!TI_KEY = nNo
    '    rst!TI_REF_NO = Trim(txtRefNo.Text)
    '    rst!TI_YA = Trim(txtYA.Text)
    '    rst!TI_DESC = lvGeneral.ListItems(i).ListSubItems(2)
    '    rst!TI_AMOUNT = lvGeneral.ListItems(i).ListSubItems(3)
    '    rst!TI_SOURCENO = Trim(txtSourceNo)

    '    rst.Update()
    '    rst.Close()

    'End Sub

    'Private Sub InsertlvGeneral_RevenueExpenditure(i As Integer)
    '    Dim nNo As Integer

    '    If Trim(lvGeneral.ListItems(i).ListSubItems(4).Text) = "New" Then
    '        cSQL = "SELECT * FROM [REVENUE_EXPENDITURE] ORDER BY [RE_KEY]"
    '        rst = DB.Execute(cSQL)

    '        nNo = 0
    '        If Not rst.EOF Then
    '            While Not rst.EOF
    '                nNo = Val(rst.Fields(0))
    '                rst.MoveNext()
    '            End While
    '        End If
    '        nNo = nNo + 1
    '        rst.Close()
    '        cSQL = "SELECT * FROM [REVENUE_EXPENDITURE]"
    '    Else
    '        nNo = Val(Trim(lvGeneral.ListItems(i).ListSubItems(4).Text))
    '        cSQL = "SELECT * FROM [REVENUE_EXPENDITURE] Where [RE_KEY] = " & nNo
    '    End If

    '    rst.Open(cSQL, DB, 3, 3)
    '    rst.AddNew()
    '    rst!RE_KEY = nNo
    '    rst!RE_REF_NO = Trim(txtRefNo.Text)
    '    rst!RE_YA = Trim(txtYA.Text)
    '    rst!RE_DESC = lvGeneral.ListItems(i).ListSubItems(2)
    '    rst!RE_AMOUNT = lvGeneral.ListItems(i).ListSubItems(3)
    '    rst!RE_SOURCENO = Trim(txtSourceNo)

    '    rst.Update()
    '    rst.Close()

    'End Sub

    'Private Sub InsertlvGeneral_OtherExpenditure(i As Integer)
    '    Dim nNo As Integer

    '    If Trim(lvGeneral.ListItems(i).ListSubItems(4).Text) = "New" Then
    '        cSQL = "SELECT * FROM [OTHER_EXPENDITURE] ORDER BY [OE_KEY]"
    '        rst = DB.Execute(cSQL)

    '        nNo = 0
    '        If Not rst.EOF Then
    '            While Not rst.EOF
    '                nNo = Val(rst.Fields(0))
    '                rst.MoveNext()
    '            End While
    '        End If
    '        nNo = nNo + 1
    '        rst.Close()
    '        cSQL = "SELECT * FROM [OTHER_EXPENDITURE]"
    '    Else
    '        nNo = Val(Trim(lvGeneral.ListItems(i).ListSubItems(4).Text))
    '        cSQL = "SELECT * FROM [OTHER_EXPENDITURE] Where [OE_KEY] = " & nNo
    '    End If

    '    rst.Open(cSQL, DB, 3, 3)
    '    rst.AddNew()
    '    rst!OE_KEY = nNo
    '    rst!OE_REF_NO = Trim(txtRefNo.Text)
    '    rst!OE_YA = Trim(txtYA.Text)
    '    rst!OE_COMPANY = "C"

    '    cSQL = "SELECT * FROM [CLAIM] WHERE [CL_DESC]='" & Trim(lvGeneral.ListItems(i).ListSubItems(2)) & "'"
    '    rst1 = DB.Execute(cSQL)
    '    If Not rst1.EOF Then
    '        rst!OE_CLAIMCODE = rst1!CL_CODE
    '    Else
    '        rst!OE_CLAIMCODE = ""
    '    End If
    '    rst1.Close()

    '    rst!OE_AMOUNT = lvGeneral.ListItems(i).ListSubItems(3)
    '    rst!OE_SOURCENO = Trim(txtSourceNo)

    '    rst.Update()
    '    rst.Close()

    'End Sub

    'Private Sub InsertlvGeneral_OtherDedeuction(i As Integer)  'pin taxcomC+ v2005.3
    '    Dim nNo As Integer

    '    If Trim(lvGeneral.ListItems(i).ListSubItems(4).Text) = "New" Then
    '        cSQL = "SELECT * FROM [OTHER_DEDUCTION] ORDER BY [OD_KEY]"
    '        rst = DB.Execute(cSQL)

    '        nNo = 0
    '        If Not rst.EOF Then
    '            While Not rst.EOF
    '                nNo = Val(rst.Fields(0))
    '                rst.MoveNext()
    '            End While
    '        End If
    '        nNo = nNo + 1
    '        rst.Close()
    '        cSQL = "SELECT * FROM [OTHER_DEDUCTION]"
    '    Else
    '        nNo = Val(Trim(lvGeneral.ListItems(i).ListSubItems(4).Text))
    '        cSQL = "SELECT * FROM [OTHER_DEDUCTION] Where [OD_KEY] = " & nNo
    '    End If

    '    rst.Open(cSQL, DB, 3, 3)
    '    rst.AddNew()
    '    rst!OD_KEY = nNo
    '    rst!OD_REF_NO = Trim(txtRefNo.Text)
    '    rst!OD_YA = Trim(txtYA.Text)
    '    rst!OD_DESC = lvGeneral.ListItems(i).ListSubItems(2)
    '    rst!OD_AMOUNT = lvGeneral.ListItems(i).ListSubItems(3)
    '    rst!OD_SOURCENO = Trim(txtSourceNo)

    '    rst.Update()
    '    rst.Close()
    'End Sub

    'Private Sub InsertlvGeneral_SurplusRecovered(i As Integer)  'pin phase 3 release 2
    '    Dim nNo As Integer

    '    If Trim(lvGeneral.ListItems(i).ListSubItems(4).Text) = "New" Then
    '        cSQL = "SELECT * FROM [SURPLUS_RECOVERED] ORDER BY [SR_KEY]"
    '        rst = DB.Execute(cSQL)

    '        nNo = 0
    '        If Not rst.EOF Then
    '            While Not rst.EOF
    '                nNo = Val(rst.Fields(0))
    '                rst.MoveNext()
    '            End While
    '        End If
    '        nNo = nNo + 1
    '        rst.Close()
    '        cSQL = "SELECT * FROM [SURPLUS_RECOVERED]"
    '    Else
    '        nNo = Val(Trim(lvGeneral.ListItems(i).ListSubItems(4).Text))
    '        cSQL = "SELECT * FROM [SURPLUS_RECOVERED] Where [SR_KEY] = " & nNo
    '    End If

    '    rst.Open(cSQL, DB, 3, 3)
    '    rst.AddNew()
    '    rst!SR_KEY = nNo
    '    rst!SR_REF_NO = Trim(txtRefNo.Text)
    '    rst!SR_YA = Trim(txtYA.Text)
    '    rst!SR_DESC = lvGeneral.ListItems(i).ListSubItems(2)
    '    rst!SR_AMOUNT = lvGeneral.ListItems(i).ListSubItems(3)
    '    rst!SR_SOURCENO = Trim(txtSourceNo)

    '    rst.Update()
    '    rst.Close()

    'End Sub

    'Private Sub InsertlvGeneral_MiningAllownance(i As Integer)  'pin phase 3 release 2
    '    Dim nNo As Integer

    '    If Trim(lvGeneral.ListItems(i).ListSubItems(4).Text) = "New" Then
    '        cSQL = "SELECT * FROM [MINING_ALLOWNANCE] ORDER BY [MA_KEY]"
    '        rst = DB.Execute(cSQL)

    '        nNo = 0
    '        If Not rst.EOF Then
    '            While Not rst.EOF
    '                nNo = Val(rst.Fields(0))
    '                rst.MoveNext()
    '            End While
    '        End If
    '        nNo = nNo + 1
    '        rst.Close()
    '        cSQL = "SELECT * FROM [MINING_ALLOWNANCE]"
    '    Else
    '        nNo = Val(Trim(lvGeneral.ListItems(i).ListSubItems(4).Text))
    '        cSQL = "SELECT * FROM [MINING_ALLOWNANCE] Where [MA_KEY] = " & nNo
    '    End If

    '    rst.Open(cSQL, DB, 3, 3)
    '    rst.AddNew()
    '    rst!MA_KEY = nNo
    '    rst!MA_REF_NO = Trim(txtRefNo.Text)
    '    rst!MA_YA = Trim(txtYA.Text)
    '    rst!MA_DESC = lvGeneral.ListItems(i).ListSubItems(2)
    '    rst!MA_AMOUNT = lvGeneral.ListItems(i).ListSubItems(3)
    '    rst!MA_SOURCENO = Trim(txtSourceNo)

    '    rst.Update()
    '    rst.Close()


    'End Sub
    'Private Sub InsertlvGeneral_MiningExpenses(i As Integer)  'pin phase 3 release 2
    '    Dim nNo As Integer

    '    If Trim(lvGeneral.ListItems(i).ListSubItems(4).Text) = "New" Then
    '        cSQL = "SELECT * FROM [MINING_EXPENSES] ORDER BY [ME_KEY]"
    '        rst = DB.Execute(cSQL)

    '        nNo = 0
    '        If Not rst.EOF Then
    '            While Not rst.EOF
    '                nNo = Val(rst.Fields(0))
    '                rst.MoveNext()
    '            End While
    '        End If
    '        nNo = nNo + 1
    '        rst.Close()
    '        cSQL = "SELECT * FROM [MINING_EXPENSES]"
    '    Else
    '        nNo = Val(Trim(lvGeneral.ListItems(i).ListSubItems(4).Text))
    '        cSQL = "SELECT * FROM [MINING_EXPENSES] Where [ME_KEY] = " & nNo
    '    End If

    '    rst.Open(cSQL, DB, 3, 3)
    '    rst.AddNew()
    '    rst!ME_KEY = nNo
    '    rst!ME_REF_NO = Trim(txtRefNo.Text)
    '    rst!ME_YA = Trim(txtYA.Text)
    '    rst!ME_DESC = lvGeneral.ListItems(i).ListSubItems(2)
    '    rst!ME_AMOUNT = lvGeneral.ListItems(i).ListSubItems(3)
    '    rst!ME_SOURCENO = Trim(txtSourceNo)

    '    rst.Update()
    '    rst.Close()

    'End Sub

    'Private Sub Form_Load()
    '    Dim TotalNBI As Double
    '    Dim Bus_Inc As Double
    '    Dim TotalGrossPL As Double
    '    '=== NGOHCS PNL2009 ==='
    '    Dim TotalInterest As Double
    '    Dim TOTALDIVIDEND As Double
    '    Dim TotalRental As Double
    '    Dim TotalRoyalty As Double
    '    Dim TotalOtherIncome As Double
    '    Dim strMainSource As Integer
    '    Dim lngBalancingFigure As Long
    '    '=== NGOHCS PNL2009 END ==='
    '    TotalGrossPL = 0
    '    TotalNBI = 0
    '    Bus_Inc = 0
    '    NA_Loss = 0
    '    RealFETrade = 0

    '    'NGOHCS CA2008
    '    'Set sForm = Screen.ActiveForm
    '    'sForm.Enabled = False
    '    Screen.ActiveForm.Enabled = False
    '    'NGOHCS CA2008 END
    '    IncomeCal_Flag = False

    '    cSQL = "SELECT * FROM [TAX_COMPUTATION] WHERE [TC_KEY] =" & CDbl(vAdjIncomeKey)
    '    rst = DB.Execute(cSQL)
    '    With rst
    '        txtRefNo = .Fields(1)
    '        txtYA = .Fields(2)
    '        txtCoName(0) = .Fields(3)
    '        txtCoReg(2) = .Fields(4)
    '        txtSourceNo = .Fields(5)

    '        cSQL2 = "SELECT [BC_TYPE] FROM [BUSINESS_SOURCE] WHERE [BC_KEY]='" & Trim(txtRefNo) & "' AND [BC_YA]='" & Trim(txtYA) & "' AND [BC_SOURCENO]=" & Val(Trim(txtSourceNo))
    '        rst2 = DB.Execute(cSQL2)
    '        If Not rst2.EOF Then
    '            txtSource = rst2.Fields(0)
    '        End If
    '        rst2.Close()

    '        If CDbl(.Fields(6)) > 0 Then
    '            txtBalProfit = .Fields(6)
    '        ElseIf CDbl(.Fields(6)) < 0 Then
    '            txtBalLoss = .Fields(6)
    '        End If

    '        txtDividend = .Fields(7)
    '        txtRental = .Fields(8)
    '        txtRoyalty = .Fields(9)
    '        txtInterest = .Fields(10)
    '        txtSection4A = .Fields(11)
    '        txtOthBsIn = rst!TC_AI_OTH_BS_IN
    '        txtTotNonBs = .Fields(12)

    '        If CDbl(.Fields(13)) > 0 Then
    '            txtTotBsProfit = .Fields(13)
    '        ElseIf CDbl(.Fields(13)) < 0 Then
    '            txtTotBsLoss = .Fields(13)
    '        End If

    '        txtNALoss = .Fields(14)
    '        txtNTaxIn = .Fields(15)
    '        txtTaxIn = .Fields(16)

    '        If CDbl(.Fields(17)) > 0 Then
    '            txtTotBIProfit = .Fields(17)
    '        ElseIf CDbl(txtTotBILoss) < 0 Then
    '            txtTotBILoss = .Fields(17)
    '        End If

    '        txtInterestRestricted = .Fields(18)
    '        txtNAExp = .Fields(19)
    '        txtRevenueExp = .Fields(20)
    '        txtOthExp = .Fields(21)
    '        txtTotBSExp = .Fields(22)
    '        txtOtherDeduc = IIf(IsNull(rst!TC_OTHERDEDUCTION), 0, rst!TC_OTHERDEDUCTION)   'PIN START TAXCOMc+ V 2005.3
    '        txtSurplusMiningAllowance = IIf(IsNull(rst!TC_SURPLUSRECOVERED), 0, rst!TC_SURPLUSRECOVERED)   'PIN START Phase 3 Release 2
    '        txtMiningAllowing = IIf(IsNull(rst!TC_MININGALLOWNANCE), 0, rst!TC_MININGALLOWNANCE)   'PIN START Phase 3 Release 2
    '        txtAddMiningExp = IIf(IsNull(rst!TC_MININGEXPENSES), 0, rst!TC_MININGEXPENSES)   'PIN START Phase 3 Release 2

    '        If CDbl(.Fields(23)) > 0 Then
    '            txtAdIn = .Fields(23)
    '        ElseIf CDbl(txtAdLoss) < 0 Then
    '            txtAdLoss = .Fields(23)
    '        End If

    '    End With
    '    rst.Close()
    '    NTax_In = 0
    '    Tax_In = 0
    '    NA_Exp = 0
    '    Revenue_Exp = 0
    '    Oth_Exp = 0
    '    NA_Loss = 0
    '    Interest_Restrict = 0
    '    txtBalProfit.Locked = True
    '    txtBalLoss.Locked = True
    '    txtBalProfit.BackColor = &H8000000F
    '    txtBalLoss.BackColor = &H8000000F
    '    lblSourceNo(0).Caption = "( Source " & txtSourceNo.Text & " )"
    '    lblSourceNo(1).Caption = "( Source " & txtSourceNo.Text & " )"

    '    If txtSourceNo.Text = 1 Then

    '        'Start: geline: Text display for Section A only able to display more than source 1
    '        lblDisplay1.Visible = False
    '        lblDisplay3.Visible = False
    '        lblDisplay2.Visible = False
    '        'End:
    '        ' === NGOHCS PNL2009 === '
    '        cSQL = "SELECT * FROM [PROFIT_LOSS_ACCOUNT] WHERE [PL_REF_NO]='" & Trim(txtRefNo) & "' AND [PL_YA]='" & Trim(txtYA) & "'"
    '        rst = DB.Execute(cSQL)
    '        If Not rst.EOF Then  'C2007.4
    '            pnl_key = rst!PL_KEY
    '            TotalGrossPL = rst!PL_GROSS_PROFIT
    '            lngBalancingFigure = CLng(rst!PL_OTHER_EXP_BALANCE)
    '            strMainSource = rst!PL_MAINBUZ
    '            '            txtDividend = rst!PL_OTH_IN_DIVIDEND
    '            '            txtRental = rst!PL_OTH_IN_RENTAL
    '            '            txtRoyalty = rst!PL_OTH_IN_ROYALTY
    '            '            txtInterest = rst!PL_OTH_IN_INTEREST
    '            '            txtSection4A = rst!PL_OTH_IN_OTHER
    '            '            TotalNBI = FormatNumber(CDbl(txtDividend) + CDbl(txtRental) + CDbl(txtRoyalty) + CDbl(txtInterest) + CDbl(txtSection4A), 0)

    '        End If
    '        rst.Close()
    '        ' === NGOHCS PNL2009 END === '

    '        ' === NGOHCS PNL2009 === '
    '        '=====Dividend Income=========
    '        cSQL = "SELECT [DI_NET], [DI_GROSS], [DI_DISCLOSE] FROM [DIVIDEND_INCOME] WHERE [DI_KEY]=" & pnl_key & "  AND [DI_SOURCENO]=" & Val(txtSourceNo.Text) & " AND [DI_TRANSFER] = 'Section 4c'"
    '        rst = DB.Execute(cSQL)
    '        If Not rst.EOF Then
    '            Do While Not rst.EOF
    '                If rst.Fields(2) = "Yes" Then
    '                    TOTALDIVIDEND = CDbl(TOTALDIVIDEND) + CDbl(rst.Fields(0))
    '                Else
    '                    TOTALDIVIDEND = CDbl(TOTALDIVIDEND) + CDbl(rst.Fields(1))
    '                End If
    '                rst.MoveNext()
    '            Loop
    '        End If
    '        rst.Close()
    '        txtDividend.Text = FormatNumber(TOTALDIVIDEND, 0)
    '        '=====Rental Income=========
    '        cSQL = "SELECT [RI_AMOUNT] FROM [RENTAL_INCOME] WHERE [RI_KEY]=" & pnl_key & "  AND [RI_SOURCENO]=" & Val(txtSourceNo.Text) & " AND [RI_STATUS4d] = 'Sec 4d'"
    '        rst = DB.Execute(cSQL)
    '        If Not rst.EOF Then
    '            Do While Not rst.EOF
    '                TotalRental = CDbl(TotalRental) + CDbl(rst.Fields(0))
    '                rst.MoveNext()
    '            Loop
    '        End If
    '        rst.Close()
    '        txtRental.Text = FormatNumber(TotalRental, 0)

    '        '=====Royalty Income=========
    '        cSQL = "SELECT [NOBRI_AMOUNT] FROM [INCOME_NBROYALTY] WHERE [NOBRI_KEY]=" & pnl_key & "  AND [NOBRI_SOURCENO]=" & Val(txtSourceNo.Text)
    '        rst = DB.Execute(cSQL)
    '        If Not rst.EOF Then
    '            Do While Not rst.EOF
    '                TotalRoyalty = CDbl(TotalRoyalty) + CDbl(rst.Fields(0))
    '                rst.MoveNext()
    '            Loop
    '        End If
    '        rst.Close()
    '        txtRoyalty.Text = FormatNumber(TotalRoyalty, 0)


    '        '=====Interest Income=========
    '        cSQL = "SELECT [NOBII_AMOUNT] FROM [INCOME_NBINTEREST] WHERE [NOBII_KEY]=" & pnl_key & "  AND [NOBII_SOURCENO]=" & Val(txtSourceNo.Text)
    '        rst = DB.Execute(cSQL)
    '        If Not rst.EOF Then
    '            Do While Not rst.EOF
    '                TotalInterest = CDbl(TotalInterest) + CDbl(rst.Fields(0))
    '                rst.MoveNext()
    '            Loop
    '        End If
    '        rst.Close()
    '        txtInterest.Text = FormatNumber(TotalInterest, 0)

    '        '=====Other Income=========
    '        cSQL = "SELECT [OI_AMOUNT] FROM [OTHER_INCOME] WHERE [OI_KEY]=" & pnl_key & "  AND [OI_SOURCENO]=" & Val(txtSourceNo.Text)
    '        rst = DB.Execute(cSQL)
    '        If Not rst.EOF Then
    '            Do While Not rst.EOF
    '                TotalOtherIncome = CDbl(TotalOtherIncome) + CDbl(rst.Fields(0))
    '                rst.MoveNext()
    '            Loop
    '        End If
    '        rst.Close()
    '        txtSection4A.Text = FormatNumber(TotalOtherIncome, 0)

    '        TotalNBI = FormatNumber(CDbl(txtDividend) + CDbl(txtRental) + CDbl(txtRoyalty) + CDbl(txtInterest) + CDbl(txtSection4A), 0)
    '        ' === NGOHCS PNL2009 END === '
    '        '=====Other Business Income=========

    '        cSQL = "SELECT [NSBI_AMOUNT] FROM [NONSOURCE_BUSINESSINCOME] WHERE [NSBI_KEY]=" & pnl_key & "  AND [NSBI_SOURCENO]=" & Val(txtSourceNo.Text)
    '        rst = DB.Execute(cSQL)
    '        If Not rst.EOF Then
    '            Do While Not rst.EOF
    '                Bus_Inc = CDbl(Bus_Inc) + CDbl(rst.Fields(0))
    '                rst.MoveNext()
    '            Loop
    '        End If
    '        rst.Close()

    '        '=====NON_TAXABLE_INCOME=========
    '        NTax_In = 0
    '        cSQL = "SELECT * FROM [NON_TAXABLE_INCOME] WHERE [NT_REF_NO]='" & Trim(txtRefNo) & "' AND [NT_YA]='" & Trim(txtYA) & "' AND [NT_SOURCENO] = " & txtSourceNo & " AND [NT_CATEGORIZED] <> 'Other'"
    '        rst = DB.Execute(cSQL)
    '        If Not rst.EOF Then
    '            Do While Not rst.EOF
    '                NTax_In = NTax_In + CDbl(rst.Fields(4))
    '                rst.MoveNext()
    '            Loop
    '        End If
    '        rst.Close()
    '        '=== NGOHCS PNL2009 ==='
    '        cSQL = "SELECT [ED_AMOUNT] FROM [EXEMPT_DIVIDEND] WHERE [ED_KEY]=" & pnl_key & " AND [ED_SOURCENO]=" & Val(txtSourceNo.Text)
    '        rst = DB.Execute(cSQL)
    '        If Not rst.EOF Then
    '            Do While Not rst.EOF
    '                NTax_In = CDbl(NTax_In) + CDbl(rst.Fields(0))
    '                rst.MoveNext()
    '            Loop
    '        End If
    '        rst.Close()
    '        '=== NGOHCS PNL2009 END ==='
    '        txtNTaxIn = FormatNumber(CDbl(NTax_In), 0)
    '        'Expenses
    '        Call NAllow_Exp()
    '        Call NAllow_Exp2()

    '        cSQL = "SELECT [OBI_GROSS_INCOME] FROM [OTHER_BUSINESS_INCOME] WHERE [OBI_KEY]=" & pnl_key
    '        rst = DB.Execute(cSQL)
    '        Other_Business = 0
    '        If Not rst.EOF Then
    '            Do While Not rst.EOF
    '                Other_Business = CDbl(Other_Business) + CDbl(rst.Fields(0))
    '                rst.MoveNext()
    '            Loop
    '        End If
    '        rst.Close()
    '        '=== weihong ==='
    '        cSQL = "SELECT [IRFET_AMOUNT] FROM [INCOME_REALFET] WHERE [IRFET_KEY]=" & pnl_key & " AND [IRFET_SOURCENO]=" & Val(txtSourceNo.Text)
    '        rst = DB.Execute(cSQL)
    '        If Not rst.EOF Then
    '            Do While Not rst.EOF
    '                RealFETrade = CDbl(RealFETrade) + CDbl(rst.Fields(0))
    '                rst.MoveNext()
    '            Loop
    '        End If
    '        rst.Close()
    '        '=== endweihong ==='

    '        If strMainSource = txtSourceNo.Text Then
    '            If CDbl(TotalGrossPL - Other_Business + TotalNBI + CDbl(Bus_Inc) + CDbl(NTax_In) - CDbl(NA_Exp) - lngBalancingFigure + RealFETrade) < 0 Then
    '                txtBalLoss = FormatNumber(TotalGrossPL - Other_Business + TotalNBI + CDbl(Bus_Inc) + CDbl(NTax_In) - CDbl(NA_Exp) - lngBalancingFigure + RealFETrade, 0)
    '                txtBalProfit = 0
    '            Else
    '                txtBalLoss = 0
    '                txtBalProfit = FormatNumber(TotalGrossPL - Other_Business + TotalNBI + CDbl(Bus_Inc) + CDbl(NTax_In) - CDbl(NA_Exp) - lngBalancingFigure + RealFETrade, 0)
    '            End If
    '        Else
    '            If CDbl(TotalGrossPL - Other_Business + TotalNBI + CDbl(Bus_Inc) + CDbl(NTax_In) - CDbl(NA_Exp) + RealFETrade) < 0 Then
    '                txtBalLoss = FormatNumber(TotalGrossPL - Other_Business + TotalNBI + CDbl(Bus_Inc) + CDbl(NTax_In) - CDbl(NA_Exp) + RealFETrade, 0)
    '                txtBalProfit = 0
    '            Else
    '                txtBalLoss = 0
    '                txtBalProfit = FormatNumber(TotalGrossPL - Other_Business + TotalNBI + CDbl(Bus_Inc) + CDbl(NTax_In) - CDbl(NA_Exp) + RealFETrade, 0)
    '            End If
    '        End If
    '        txtOthBsIn = FormatNumber(CDbl(Other_Business), 0)
    '        txtOthBsIn = 0 'C2007.4
    '        Call NonAllowLoss()

    '        cSQL = "SELECT * FROM [NON_ALLOW_LOSS] WHERE [NL_REF_NO]='" & Trim(txtRefNo) & "' AND [NL_YA]='" & Trim(txtYA) & "' and [NL_SOURCENO]=" & Trim(txtSourceNo) & " and [NL_CATEGORIZED]=''"
    '        rst = DB.Execute(cSQL)
    '        If Not rst.EOF Then
    '            Do While Not rst.EOF
    '                NA_Loss = CDbl(NA_Loss) + CDbl(rst.Fields(4))
    '                rst.MoveNext()
    '            Loop
    '        End If
    '        rst.Close()
    '        txtNALoss = FormatNumber(CDbl(NA_Loss), 0)
    '        'geline: Start: Taxcom C+ v 2004.6
    '        Dim cNoSource As Integer
    '        Dim NonTax() As Double
    '        Dim aboveS1NonTax As Double
    '        Dim SourceArray() As Integer

    '        NTax_In = 0
    '        aboveS1NonTax = 0

    '        cSQL = "SELECT * FROM [BUSINESS_SOURCE] WHERE [BC_KEY]='" & txtRefNo & "' AND [BC_YA]='" & txtYA & "' ORDER BY [BC_SOURCENO]"
    '        rst = DB.Execute(cSQL)
    '        If Not rst.EOF Then
    '            cNoSource = rst.RecordCount
    '        ReDim SourceArray(cNoSource) As Integer
    '        ReDim NonTax(cNoSource) As Double
    '            For i = 1 To rst.RecordCount
    '                SourceArray(i) = rst![BC_SOURCENO]
    '                rst.MoveNext()
    '            Next
    '        End If
    '        rst.Close()
    '        ''        For I = 1 To cNoSource
    '        ''            cSQL = "SELECT * FROM [NON_TAXABLE_INCOME] WHERE [NT_REF_NO]='" & Trim(txtRefNo) & "' AND [NT_YA]='" & Trim(txtYA) & "' AND [NT_SOURCENO] = " & SourceArray(I) & " AND [NT_CATEGORIZED] <> 'Other' ORDER BY [NT_KEY]"
    '        ''            Set rst = DB.Execute(cSQL)
    '        ''            NonTax(I) = 0
    '        ''            If Not rst.EOF Then
    '        ''                Do While Not rst.EOF
    '        ''                    NonTax(I) = NonTax(I) + CDbl(rst.Fields(4))
    '        ''                    rst.MoveNext
    '        ''                Loop
    '        ''            End If
    '        ''            rst.Close
    '        ''        Next
    '        ''
    '        ''        For I = 2 To cNoSource
    '        ''            aboveS1NonTax = aboveS1NonTax + NonTax(I)
    '        ''        Next
    '        ''        NTax_In = Abs(NonTax(1) - Trim(aboveS1NonTax))
    '        ''
    '        ''        cSQL = "SELECT [ED_AMOUNT] FROM [EXEMPT_DIVIDEND] WHERE [ED_KEY]=" & pnl_key
    '        ''        Set rst = DB.Execute(cSQL)
    '        ''        If Not rst.EOF Then
    '        ''            Do While Not rst.EOF
    '        ''                NTax_In = CDbl(NTax_In) + CDbl(rst.Fields(0))
    '        ''                rst.MoveNext
    '        ''            Loop
    '        ''        End If
    '        ''        rst.Close
    '        ''        txtNTaxIn = FormatNumber(CDbl(NTax_In), 0)

    '        cSQL = "SELECT * FROM [TAXABLE_INCOME] WHERE [TI_REF_NO]='" & Trim(txtRefNo) & "' AND [TI_YA]='" & Trim(txtYA) & "' AND [TI_SOURCENO]=" & Trim(txtSourceNo)
    '        rst = DB.Execute(cSQL)
    '        Tax_In = 0
    '        If Not rst.EOF Then
    '            Do While Not rst.EOF
    '                Tax_In = CDbl(Tax_In) + CDbl(rst.Fields(4))
    '                rst.MoveNext()
    '            Loop
    '        End If
    '        rst.Close()
    '        txtTaxIn = FormatNumber(CDbl(Tax_In), 0)
    '        cSQL = "SELECT * FROM [NON_ALLOW_EXPENDITURE] WHERE [NE_REF_NO]='" & Trim(txtRefNo) & "' AND [NE_YA]='" & Trim(txtYA) & "'"
    '        rst = DB.Execute(cSQL)
    '        NA_Exp = 0
    '        If Not rst.EOF Then
    '            Do While Not rst.EOF
    '                NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(4))
    '                rst.MoveNext()
    '            Loop
    '        End If
    '        rst.Close()

    '        '===Non Deductible Expenses for Source 1===
    '        NA_Exp = 0
    '        Call NAllow_NDExp()
    '        Call NAllow_NDExp2()
    '        txtNAExp = FormatNumber(CDbl(NA_Exp), 0)

    '        Interest_Restrict = 0
    '        Call InterestRestricted()

    '        txtInterestRestricted = FormatNumber(CDbl(Interest_Restrict), 0)
    '    Else
    '        'Start: geline: Text display for Section A only able to display more than source 1
    '        lblDisplay1.Visible = True
    '        lblDisplay3.Visible = True
    '        lblDisplay2.Visible = True
    '        lblDisplay2.Caption = txtSourceNo.Text
    '        'End:

    '        lvGeneral.ListItems.Clear()

    '        txtBalProfit.Locked = False
    '        txtBalLoss.Locked = False
    '        txtBalProfit.BackColor = &H80000005
    '        txtBalLoss.BackColor = &H80000005
    '        pnl_key = 0
    '        cSQL = "SELECT [PL_KEY],[PL_OTHER_EXP_BALANCE], [PL_MAINBUZ]  FROM [PROFIT_LOSS_ACCOUNT] WHERE [PL_REF_NO]='" & Trim(txtRefNo) & "' AND [PL_YA]='" & Trim(txtYA) & "'"
    '        rst = DB.Execute(cSQL)
    '        If Not rst.EOF Then
    '            pnl_key = rst!PL_KEY
    '            lngBalancingFigure = CLng(rst!PL_OTHER_EXP_BALANCE)
    '            strMainSource = rst!PL_MAINBUZ
    '        End If
    '        rst.Close()
    '        '===All Expenses for selected Source===
    '        Call NAllow_Exp()
    '        Call NAllow_Exp2()

    '        If AdjIncome_Flag = True Then
    '            txtBalProfit = 0
    '            txtBalLoss = 0

    '            '            cSQL = "SELECT * FROM [OTHER_BUSINESS_INCOME] WHERE [OBI_KEY]=" & pnl_key & " AND [OBI_SOURCENO]=" & Val(txtSourceNo.Text)
    '            '            Set rst = DB.Execute(cSQL)
    '            '            If Not rst.EOF Then
    '            '                If CDbl(rst!OBI_GROSS_INCOME) - CDbl(NA_Exp) < 0 Then
    '            '                    txtBalLoss = FormatNumber(CDbl(rst!OBI_GROSS_INCOME) - CDbl(NA_Exp), 0)
    '            '                    txtBalProfit = 0
    '            '                ElseIf CDbl(rst!OBI_GROSS_INCOME) - CDbl(NA_Exp) > 0 Then
    '            '                    txtBalLoss = 0
    '            '                    txtBalProfit = FormatNumber(CDbl(rst!OBI_GROSS_INCOME) - CDbl(NA_Exp), 0)
    '            '                End If
    '            '            End If
    '            '            rst.Close
    '            '        End If


    '            ' === NGOHCS PNL2009 === '
    '            '=====Dividend Income=========
    '            cSQL = "SELECT [DI_NET], [DI_GROSS], [DI_DISCLOSE] FROM [DIVIDEND_INCOME] WHERE [DI_KEY]=" & pnl_key & "  AND [DI_SOURCENO]=" & Val(txtSourceNo.Text) & " AND [DI_TRANSFER] = 'Section 4c'"
    '            rst = DB.Execute(cSQL)
    '            If Not rst.EOF Then
    '                Do While Not rst.EOF
    '                    If rst.Fields(2) = "Yes" Then
    '                        TOTALDIVIDEND = CDbl(TOTALDIVIDEND) + CDbl(rst.Fields(0))
    '                    Else
    '                        TOTALDIVIDEND = CDbl(TOTALDIVIDEND) + CDbl(rst.Fields(1))
    '                    End If
    '                    rst.MoveNext()
    '                Loop
    '            End If
    '            rst.Close()
    '            txtDividend.Text = FormatNumber(TOTALDIVIDEND, 0)
    '            '=====Rental Income=========
    '            cSQL = "SELECT [RI_AMOUNT] FROM [RENTAL_INCOME] WHERE [RI_KEY]=" & pnl_key & "  AND [RI_SOURCENO]=" & Val(txtSourceNo.Text) & " AND [RI_STATUS4d] = 'Sec 4d'"
    '            rst = DB.Execute(cSQL)
    '            If Not rst.EOF Then
    '                Do While Not rst.EOF
    '                    TotalRental = CDbl(TotalRental) + CDbl(rst.Fields(0))
    '                    rst.MoveNext()
    '                Loop
    '            End If
    '            rst.Close()
    '            txtRental.Text = FormatNumber(TotalRental, 0)

    '            '=====Royalty Income=========
    '            cSQL = "SELECT [NOBRI_AMOUNT] FROM [INCOME_NBROYALTY] WHERE [NOBRI_KEY]=" & pnl_key & "  AND [NOBRI_SOURCENO]=" & Val(txtSourceNo.Text)
    '            rst = DB.Execute(cSQL)
    '            If Not rst.EOF Then
    '                Do While Not rst.EOF
    '                    TotalRoyalty = CDbl(TotalRoyalty) + CDbl(rst.Fields(0))
    '                    rst.MoveNext()
    '                Loop
    '            End If
    '            rst.Close()
    '            txtRoyalty.Text = FormatNumber(TotalRoyalty, 0)

    '            '=====Interest Income=========
    '            cSQL = "SELECT [NOBII_AMOUNT] FROM [INCOME_NBINTEREST] WHERE [NOBII_KEY]=" & pnl_key & "  AND [NOBII_SOURCENO]=" & Val(txtSourceNo.Text)
    '            rst = DB.Execute(cSQL)
    '            If Not rst.EOF Then
    '                Do While Not rst.EOF
    '                    TotalInterest = CDbl(TotalInterest) + CDbl(rst.Fields(0))
    '                    rst.MoveNext()
    '                Loop
    '            End If
    '            rst.Close()
    '            txtInterest.Text = FormatNumber(TotalInterest, 0)

    '            '=====Other Income=========
    '            cSQL = "SELECT [OI_AMOUNT] FROM [OTHER_INCOME] WHERE [OI_KEY]=" & pnl_key & "  AND [OI_SOURCENO]=" & Val(txtSourceNo.Text)
    '            rst = DB.Execute(cSQL)
    '            If Not rst.EOF Then
    '                Do While Not rst.EOF
    '                    TotalOtherIncome = CDbl(TotalOtherIncome) + CDbl(rst.Fields(0))
    '                    rst.MoveNext()
    '                Loop
    '            End If
    '            rst.Close()
    '            txtSection4A.Text = FormatNumber(TotalOtherIncome, 0)
    '            ' === NGOHCS PNL2009 END === '

    '            '=====Other Business Income=========
    '            cSQL = "SELECT [NSBI_AMOUNT] FROM [NONSOURCE_BUSINESSINCOME] WHERE [NSBI_KEY]=" & pnl_key & "  AND [NSBI_SOURCENO]=" & Val(txtSourceNo.Text)
    '            rst = DB.Execute(cSQL)
    '            If Not rst.EOF Then
    '                Do While Not rst.EOF
    '                    Bus_Inc = CDbl(Bus_Inc) + CDbl(rst.Fields(0))
    '                    rst.MoveNext()
    '                Loop
    '            End If
    '            rst.Close()

    '            'geline: start: Taxcom C+ v 2004.6
    '            NTax_In = 0
    '            cSQL = "SELECT * FROM [NON_TAXABLE_INCOME] WHERE [NT_REF_NO]='" & Trim(txtRefNo) & "' AND [NT_YA]='" & Trim(txtYA) & "' AND [NT_SOURCENO] = " & txtSourceNo & " AND [NT_CATEGORIZED] <> 'Other'"
    '            rst = DB.Execute(cSQL)
    '            If Not rst.EOF Then
    '                Do While Not rst.EOF
    '                    NTax_In = NTax_In + CDbl(rst.Fields(4))
    '                    rst.MoveNext()
    '                Loop
    '            End If
    '            rst.Close()

    '            '=== NGOHCS PNL2009 ==='
    '            cSQL = "SELECT [ED_AMOUNT] FROM [EXEMPT_DIVIDEND] WHERE [ED_KEY]=" & pnl_key & " AND [ED_SOURCENO]=" & Val(txtSourceNo.Text)
    '            rst = DB.Execute(cSQL)
    '            If Not rst.EOF Then
    '                Do While Not rst.EOF
    '                    NTax_In = CDbl(NTax_In) + CDbl(rst.Fields(0))
    '                    rst.MoveNext()
    '                Loop
    '            End If
    '            rst.Close()
    '            '=== NGOHCS PNL2009 END ==='
    '            txtNTaxIn = FormatNumber(CDbl(NTax_In), 0)
    '            '=== weihong ==='
    '            cSQL = "SELECT [IRFET_AMOUNT] FROM [INCOME_REALFET] WHERE [IRFET_KEY]=" & pnl_key & " AND [IRFET_SOURCENO]=" & Val(txtSourceNo.Text)
    '            rst = DB.Execute(cSQL)
    '            If Not rst.EOF Then
    '                Do While Not rst.EOF
    '                    RealFETrade = CDbl(RealFETrade) + CDbl(rst.Fields(0))
    '                    rst.MoveNext()
    '                Loop
    '            End If
    '            rst.Close()
    '            '=== endweihong ==='

    '            cSQL = "SELECT * FROM [OTHER_BUSINESS_INCOME] WHERE [OBI_KEY]=" & pnl_key & " AND [OBI_SOURCENO]=" & Val(txtSourceNo.Text)
    '            rst = DB.Execute(cSQL)
    '            If Not rst.EOF Then
    '                If strMainSource = txtSourceNo.Text Then
    '                    If CDbl(rst!OBI_GROSS_INCOME) + CDbl(Bus_Inc) + CDbl(NTax_In) - CDbl(NA_Exp) - lngBalancingFigure + RealFETrade < 0 Then
    '                        txtBalLoss = FormatNumber(CDbl(rst!OBI_GROSS_INCOME) + CDbl(Bus_Inc) + CDbl(NTax_In) - CDbl(NA_Exp) - lngBalancingFigure + RealFETrade, 0)
    '                        txtBalProfit = 0
    '                    ElseIf CDbl(rst!OBI_GROSS_INCOME) + CDbl(Bus_Inc) + CDbl(NTax_In) - CDbl(NA_Exp) - lngBalancingFigure + RealFETrade > 0 Then
    '                        txtBalLoss = 0
    '                        txtBalProfit = FormatNumber(CDbl(rst!OBI_GROSS_INCOME) + CDbl(Bus_Inc) + CDbl(NTax_In) - CDbl(NA_Exp) - lngBalancingFigure + RealFETrade, 0)
    '                    End If
    '                Else
    '                    If CDbl(rst!OBI_GROSS_INCOME) + CDbl(Bus_Inc) + CDbl(NTax_In) - CDbl(NA_Exp) + RealFETrade < 0 Then
    '                        txtBalLoss = FormatNumber(CDbl(rst!OBI_GROSS_INCOME) + CDbl(Bus_Inc) + CDbl(NTax_In) - CDbl(NA_Exp) + RealFETrade, 0)
    '                        txtBalProfit = 0
    '                    ElseIf CDbl(rst!OBI_GROSS_INCOME) + CDbl(Bus_Inc) + CDbl(NTax_In) - CDbl(NA_Exp) + RealFETrade > 0 Then
    '                        txtBalLoss = 0
    '                        txtBalProfit = FormatNumber(CDbl(rst!OBI_GROSS_INCOME) + CDbl(Bus_Inc) + CDbl(NTax_In) - CDbl(NA_Exp) + RealFETrade, 0)
    '                    End If

    '                End If
    '            End If
    '            rst.Close()
    '        End If
    '        Call LoadLvGeneral()
    '        cSQL = "SELECT * FROM [NON_ALLOW_LOSS] WHERE [NL_REF_NO]='" & Trim(txtRefNo) & "' AND [NL_YA]='" & Trim(txtYA) & "' and [NL_SOURCENO]=" & Trim(txtSourceNo)
    '        rst = DB.Execute(cSQL)
    '        NA_Loss = 0
    '        If Not rst.EOF Then
    '            Do While Not rst.EOF
    '                NA_Loss = CDbl(NA_Loss) + CDbl(rst.Fields(4))
    '                rst.MoveNext()
    '            Loop
    '        End If
    '        rst.Close()
    '        txtNALoss = FormatNumber(CDbl(NA_Loss), 0)

    '        cSQL = "SELECT * FROM [TAXABLE_INCOME] WHERE [TI_REF_NO]='" & Trim(txtRefNo) & "' AND [TI_YA]='" & Trim(txtYA) & "' AND [TI_SOURCENO]=" & Trim(txtSourceNo)
    '        rst = DB.Execute(cSQL)
    '        Tax_In = 0
    '        If Not rst.EOF Then
    '            Do While Not rst.EOF
    '                Tax_In = CDbl(Tax_In) + CDbl(rst.Fields(4))
    '                rst.MoveNext()
    '            Loop
    '        End If
    '        rst.Close()
    '        txtTaxIn = FormatNumber(CDbl(Tax_In), 0)
    '        '===Non Deductible Expenses for selected Source===
    '        NA_Exp = 0
    '        Call NAllow_NDExp()
    '        Call NAllow_NDExp2()

    '        txtNAExp = FormatNumber(CDbl(NA_Exp), 0)

    '        Interest_Restrict = 0
    '        Call InterestRestricted()
    '        txtInterestRestricted = FormatNumber(CDbl(Interest_Restrict), 0)

    '        cSQL = "SELECT * FROM [REVENUE_EXPENDITURE] WHERE [RE_REF_NO]='" & Trim(txtRefNo) & "' AND [RE_YA]='" & Trim(txtYA) & "' AND [RE_SOURCENO]= " & Trim(txtSourceNo)
    '        rst = DB.Execute(cSQL)
    '        Revenue_Exp = 0
    '        If Not rst.EOF Then
    '            Do While Not rst.EOF
    '                Revenue_Exp = CDbl(Revenue_Exp) + CDbl(rst.Fields(4))
    '                rst.MoveNext()
    '            Loop
    '        End If
    '        rst.Close()
    '        txtRevenueExp = FormatNumber(CDbl(Revenue_Exp), 0)

    '        cSQL = "SELECT * FROM [OTHER_EXPENDITURE] WHERE [OE_REF_NO]='" & Trim(txtRefNo) & "' AND [OE_YA]='" & Trim(txtYA) & "' AND [OE_SOURCENO]=" & Trim(txtSourceNo)
    '        rst = DB.Execute(cSQL)
    '        Oth_Exp = 0
    '        If Not rst.EOF Then
    '            Do While Not rst.EOF
    '                Oth_Exp = CDbl(Oth_Exp) + CDbl(rst.Fields(4))
    '                rst.MoveNext()
    '            Loop
    '        End If
    '        rst.Close()
    '        txtOthExp = FormatNumber(CDbl(Oth_Exp), 0)

    '    End If

    '    LoadLvGeneral()

    '    SSTab1.Tab = 0
    '    If AdjIncome_Flag = False Then

    '        'Save Before Exit
    '        ResetDataChange Me

    '        RefreshcmdSave_Click()

    '    End If

    'End Sub

    'Private Sub NAllow_Exp()
    '    'OTHER INTEREST
    '    cSQL = "SELECT [EXI_AMOUNT] FROM [EXPENSES_INTEREST] WHERE [EXI_KEY]=" & pnl_key & " AND [EXI_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXC_AMOUNT] FROM [EXPENSES_CONTRACT] WHERE [EXC_KEY]=" & pnl_key & " AND [EXC_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXL_AMOUNT] FROM [EXPENSES_LEGAL] WHERE [EXL_KEY]=" & pnl_key & " AND [EXL_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXS_AMOUNT] FROM [EXPENSES_SALARY] WHERE [EXS_KEY]=" & pnl_key & " AND [EXS_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXRO_AMOUNT] FROM [EXPENSES_ROYALTY] WHERE [EXRO_KEY]=" & pnl_key & " AND [EXRO_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXRENT_AMOUNT] FROM [EXPENSES_RENTAL] WHERE [EXRENT_KEY]=" & pnl_key & " AND [EXRENT_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXREP_AMOUNT] FROM [EXPENSES_REPAIR] WHERE [EXREP_KEY]=" & pnl_key & " AND [EXREP_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXRES_AMOUNT] FROM [EXPENSES_RESEARCH] WHERE [EXRES_KEY]=" & pnl_key & " AND [EXRES_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXP_AMOUNT] FROM [EXPENSES_PROMOTE] WHERE [EXP_KEY]=" & pnl_key & " AND [EXP_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXT_AMOUNT] FROM [EXPENSES_TRAVEL] WHERE [EXT_KEY]=" & pnl_key & " AND [EXT_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    '    Andy: Due to already calculate from Gross Profit
    '    '    cSQL = "SELECT [EXNA_AMOUNT] FROM [EXPENSES_NONALLOW] WHERE [EXNA_KEY]=" & pnl_key & " AND [EXNA_SOURCENO]=" & Val(txtSourceNo.Text)
    '    '    Set rst = DB.Execute(cSQL)
    '    '    If Not rst.EOF Then
    '    '        Do While Not rst.EOF
    '    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '    '            rst.MoveNext
    '    '        Loop
    '    '    End If
    '    '    rst.Close

    '    cSQL = "SELECT [EXO_AMOUNT] FROM [OTHER_EXPENSES] WHERE [EXO_KEY]=" & pnl_key & " AND [EXO_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXIR_AMOUNT] FROM [EXPENSES_INTERESTRESTRICT] WHERE [EXIR_KEY]=" & pnl_key & "  AND [EXIR_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXES_AMOUNT] FROM [EXPENSES_EMPL_STOCK] WHERE [EXES_KEY]=" & pnl_key & " AND [EXES_SOURCENO]= " & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXTF_AMOUNT] FROM [EXPENSES_TECH_FEE] WHERE [EXTF_KEY]=" & pnl_key & " AND [EXTF_SOURCENO]= " & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    'Hogie - added on 19 th August
    '    cSQL = "SELECT [EXORT_AMOUNT] FROM [OTHER_EXRLOSSFOREIGNT] WHERE [EXORT_KEY]=" & pnl_key & " AND [EXORT_SOURCENO]= " & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXDF_AMOUNT] FROM [EXPENSES_DIRECTORS_FEE] WHERE [EXDF_KEY]=" & pnl_key & " AND [EXDF_SOURCENO]= " & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()
    '    cSQL = "SELECT [EXJK_AMOUNT] FROM [EXPENSES_JKDM] WHERE [EXJK_KEY]=" & pnl_key & " AND [EXJK_SOURCENO]= " & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    'End Sub

    'Private Sub NAllow_Exp2()
    '    cSQL = "SELECT [EXODEP_AMOUNT] FROM [OTHER_EXDEPRECIATION] WHERE [EXODEP_KEY]=" & pnl_key & "  AND [EXODEP_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXOAD_AMOUNT] FROM [OTHER_EXAPPRDONATION] WHERE [EXOAD_KEY]=" & pnl_key & "  AND [EXOAD_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXONAD_AMOUNT] FROM [OTHER_EXNAPPRDONATION] WHERE [EXONAD_KEY]=" & pnl_key & "  AND [EXONAD_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    'geline: Start: Taxcom C+ v 2005.1
    '    cSQL = "SELECT [EXOZ_AMOUNT] FROM [OTHER_EXZAKAT] WHERE [EXOZ_KEY]=" & pnl_key & "  AND [EXOZ_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()
    '    'geline: End: Taxcom C+ v 2005.1

    '    cSQL = "SELECT [EXOENS_AMOUNT] FROM [OTHER_ENTERTAINNSTAFF] WHERE [EXOENS_KEY]=" & pnl_key & "  AND [EXOENS_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXOES_AMOUNT] FROM [OTHER_ENTERTAINSTAFF] WHERE [EXOES_KEY]=" & pnl_key & "  AND [EXOES_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXOP_AMOUNT] FROM [OTHER_EXPENALTY] WHERE [EXOP_KEY]=" & pnl_key & "  AND [EXOP_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXOPA_AMOUNT] FROM [OTHER_EXPROVISIONACC] WHERE [EXOPA_KEY]=" & pnl_key & "  AND [EXOPA_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXOLP_AMOUNT] FROM [OTHER_EXLEAVEPASSAGE] WHERE [EXOLP_KEY]=" & pnl_key & "  AND [EXOLP_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXOWO_AMOUNT] FROM [OTHER_EXFAWRITTENOFF] WHERE [EXOWO_KEY]=" & pnl_key & "  AND [EXOWO_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXOIS_AMOUNT] FROM [OTHER_EXINITIALSUB] WHERE [EXOIS_KEY]=" & pnl_key & "  AND [EXOIS_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXOCE_AMOUNT] FROM [OTHER_EXCAPITALEXP] WHERE [EXOCE_KEY]=" & pnl_key & "  AND [EXOCE_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXOUR_AMOUNT] FROM [OTHER_EXURLOSSFOREIGN] WHERE [EXOUR_KEY]=" & pnl_key & "  AND [EXOUR_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXOR_AMOUNT] FROM [OTHER_EXRLOSSFOREIGN] WHERE [EXOR_KEY]=" & pnl_key & "  AND [EXOR_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXOLD_AMOUNT] FROM [OTHER_EXLOSSDISPOSALFA] WHERE [EXOLD_KEY]=" & pnl_key & "  AND [EXOLD_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    'End Sub

    'Private Sub InterestRestricted() 'c2007.4

    '    cSQL = "SELECT [EXIR_AMOUNT] FROM [EXPENSES_INTERESTRESTRICT] WHERE [EXIR_KEY]=" & pnl_key & "  AND [EXIR_SOURCENO]= " & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            Interest_Restrict = CDbl(Interest_Restrict) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()
    'End Sub

    'Private Sub NAllow_NDExp() 'C2007.4
    '    cSQL = "SELECT [EXI_AMOUNT] FROM [EXPENSES_INTEREST] WHERE [EXI_KEY]=" & pnl_key & " AND [EXI_SOURCENO]= " & Val(txtSourceNo.Text) & " AND [EXI_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXL_AMOUNT] FROM [EXPENSES_LEGAL] WHERE [EXL_KEY]=" & pnl_key & " AND [EXL_SOURCENO]= " & Val(txtSourceNo.Text) & " AND [EXL_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXC_AMOUNT] FROM [EXPENSES_CONTRACT] WHERE [EXC_KEY]=" & pnl_key & " AND [EXC_SOURCENO]= " & Val(txtSourceNo.Text) & " AND [EXC_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXS_AMOUNT] FROM [EXPENSES_SALARY] WHERE [EXS_KEY]=" & pnl_key & " AND [EXS_SOURCENO]= " & Val(txtSourceNo.Text) & " AND [EXS_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXRO_AMOUNT] FROM [EXPENSES_ROYALTY] WHERE [EXRO_KEY]=" & pnl_key & " AND [EXRO_SOURCENO]= " & Val(txtSourceNo.Text) & " AND [EXRO_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXRENT_AMOUNT] FROM [EXPENSES_RENTAL] WHERE [EXRENT_KEY]=" & pnl_key & " AND [EXRENT_SOURCENO]= " & Val(txtSourceNo.Text) & " AND [EXRENT_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXREP_AMOUNT] FROM [EXPENSES_REPAIR] WHERE [EXREP_KEY]=" & pnl_key & " AND [EXREP_SOURCENO]= " & Val(txtSourceNo.Text) & " AND [EXREP_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXRES_AMOUNT] FROM [EXPENSES_RESEARCH] WHERE [EXRES_KEY]=" & pnl_key & " AND [EXRES_SOURCENO]= " & Val(txtSourceNo.Text) & " AND [EXRES_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXP_AMOUNT] FROM [EXPENSES_PROMOTE] WHERE [EXP_KEY]=" & pnl_key & " AND [EXP_SOURCENO]= " & Val(txtSourceNo.Text) & " AND [EXP_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXT_AMOUNT] FROM [EXPENSES_TRAVEL] WHERE [EXT_KEY]=" & pnl_key & " AND [EXT_SOURCENO]= " & Val(txtSourceNo.Text) & " AND [EXT_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXES_AMOUNT] FROM [EXPENSES_EMPL_STOCK] WHERE [EXES_KEY]=" & pnl_key & " AND [EXES_SOURCENO]= " & Val(txtSourceNo.Text) & " AND [EXES_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXTF_AMOUNT] FROM [EXPENSES_TECH_FEE] WHERE [EXTF_KEY]=" & pnl_key & " AND [EXTF_SOURCENO]= " & Val(txtSourceNo.Text) & " AND [EXTF_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    'hogie - Added on 19th August

    '    cSQL = "SELECT [EXORT_AMOUNT] FROM [OTHER_EXRLOSSFOREIGNT] WHERE [EXORT_KEY]=" & pnl_key & " AND [EXORT_SOURCENO]= " & Val(txtSourceNo.Text) & " AND [EXORT_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXDF_AMOUNT] FROM [EXPENSES_DIRECTORS_FEE] WHERE [EXDF_KEY]=" & pnl_key & " AND [EXDF_SOURCENO]= " & Val(txtSourceNo.Text) & " AND [EXDF_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()
    '    cSQL = "SELECT [EXJK_AMOUNT] FROM [EXPENSES_JKDM] WHERE [EXJK_KEY]=" & pnl_key & " AND [EXJK_SOURCENO]= " & Val(txtSourceNo.Text) & " AND [EXJK_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    'End Sub

    'Private Sub NonAllowLoss() 'C2007.4
    '    cSQL = "SELECT [EXOUR_AMOUNT] FROM [OTHER_EXURLOSSFOREIGN] WHERE [EXOUR_KEY]=" & pnl_key & "  AND [EXOUR_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Loss = CDbl(NA_Loss) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXOR_AMOUNT] FROM [OTHER_EXRLOSSFOREIGN] WHERE [EXOR_KEY]=" & pnl_key & "  AND [EXOR_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Loss = CDbl(NA_Loss) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXOLD_AMOUNT] FROM [OTHER_EXLOSSDISPOSALFA] WHERE [EXOLD_KEY]=" & pnl_key & "  AND [EXOLD_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Loss = CDbl(NA_Loss) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    'End Sub

    'Private Sub ExpensesS1()
    '    cSQL = "SELECT [EXI_AMOUNT] FROM [EXPENSES_INTEREST] WHERE [EXI_KEY]=" & pnl_key & " AND [EXI_SOURCENO]>" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXC_AMOUNT] FROM [EXPENSES_CONTRACT] WHERE [EXC_KEY]=" & pnl_key & " AND [EXC_SOURCENO]>" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXL_AMOUNT] FROM [EXPENSES_LEGAL] WHERE [EXL_KEY]=" & pnl_key & " AND [EXL_SOURCENO]>" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXS_AMOUNT] FROM [EXPENSES_SALARY] WHERE [EXS_KEY]=" & pnl_key & " AND [EXS_SOURCENO]>" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXRO_AMOUNT] FROM [EXPENSES_ROYALTY] WHERE [EXRO_KEY]=" & pnl_key & " AND [EXRO_SOURCENO]>" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXRENT_AMOUNT] FROM [EXPENSES_RENTAL] WHERE [EXRENT_KEY]=" & pnl_key & " AND [EXRENT_SOURCENO]>" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXREP_AMOUNT] FROM [EXPENSES_REPAIR] WHERE [EXREP_KEY]=" & pnl_key & " AND [EXREP_SOURCENO]>" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXRES_AMOUNT] FROM [EXPENSES_RESEARCH] WHERE [EXRES_KEY]=" & pnl_key & " AND [EXRES_SOURCENO]>" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXP_AMOUNT] FROM [EXPENSES_PROMOTE] WHERE [EXP_KEY]=" & pnl_key & " AND [EXP_SOURCENO]>" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXT_AMOUNT] FROM [EXPENSES_TRAVEL] WHERE [EXT_KEY]=" & pnl_key & " AND [EXT_SOURCENO]>" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXO_AMOUNT] FROM [OTHER_EXPENSES] WHERE [EXO_KEY]=" & pnl_key & " AND [EXO_SOURCENO]>" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXIR_AMOUNT] FROM [EXPENSES_INTERESTRESTRICT] WHERE [EXIR_KEY]=" & pnl_key & "  AND [EXIR_SOURCENO]>" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()
    '    txtNAExp = FormatNumber(CDbl(NA_Exp), 0)

    '    cSQL = "SELECT [EXIR_AMOUNT] FROM [EXPENSES_INTERESTRESTRICT] WHERE [EXIR_KEY]=" & pnl_key & "  AND [EXIR_SOURCENO]= " & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            Interest_Restrict = CDbl(Interest_Restrict) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()
    '    txtInterestRestricted = FormatNumber(CDbl(Interest_Restrict), 0)

    '    cSQL = "SELECT * FROM [REVENUE_EXPENDITURE] WHERE [RE_REF_NO]='" & Trim(txtRefNo) & "' AND [RE_YA]='" & Trim(txtYA) & "' AND [RE_SOURCENO]= " & Trim(txtSourceNo)
    '    rst = DB.Execute(cSQL)
    '    Revenue_Exp = 0
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            Revenue_Exp = CDbl(Revenue_Exp) + CDbl(rst.Fields(4))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()
    '    txtRevenueExp = FormatNumber(CDbl(Revenue_Exp), 0)

    '    cSQL = "SELECT * FROM [OTHER_EXPENDITURE] WHERE [OE_REF_NO]='" & Trim(txtRefNo) & "' AND [OE_YA]='" & Trim(txtYA) & "' AND [OE_SOURCENO]=" & Trim(txtSourceNo)
    '    rst = DB.Execute(cSQL)
    '    Oth_Exp = 0
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            Oth_Exp = CDbl(Oth_Exp) + CDbl(rst.Fields(4))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()
    '    txtOthExp = FormatNumber(CDbl(Oth_Exp), 0)

    'End Sub

    ''NGOHCS PNL2009
    'Private Sub NAllow_NDExp2() 'C2007.4
    '    cSQL = "SELECT [EXODEP_AMOUNT] FROM [OTHER_EXDEPRECIATION] WHERE [EXODEP_KEY]=" & pnl_key & "  AND [EXODEP_SOURCENO]=" & Val(txtSourceNo.Text) & " AND [EXODEP_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXOAD_AMOUNT] FROM [OTHER_EXAPPRDONATION] WHERE [EXOAD_KEY]=" & pnl_key & "  AND [EXOAD_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    'NGOHCS PNL2009
    '    cSQL = "SELECT [EXONAD_AMOUNT] FROM [OTHER_EXNAPPRDONATION] WHERE [EXONAD_KEY]=" & pnl_key & "  AND [EXONAD_SOURCENO]=" & Val(txtSourceNo.Text) & " AND [EXONAD_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()
    '    'NGOHCS PNL2009 END

    '    'geline: Start: Taxcom C+ v 2005.1
    '    cSQL = "SELECT [EXOZ_AMOUNT] FROM [OTHER_EXZAKAT] WHERE [EXOZ_KEY]=" & pnl_key & "  AND [EXOZ_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()
    '    'geline: End: Taxcom C+ v 2005.1

    '    cSQL = "SELECT [EXOENS_AMOUNT] FROM [OTHER_ENTERTAINNSTAFF] WHERE [EXOENS_KEY]=" & pnl_key & "  AND [EXOENS_SOURCENO]=" & Val(txtSourceNo.Text) & " AND [EXOENS_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXOES_AMOUNT] FROM [OTHER_ENTERTAINSTAFF] WHERE [EXOES_KEY]=" & pnl_key & "  AND [EXOES_SOURCENO]=" & Val(txtSourceNo.Text) & " AND [EXOES_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXOP_AMOUNT] FROM [OTHER_EXPENALTY] WHERE [EXOP_KEY]=" & pnl_key & "  AND [EXOP_SOURCENO]=" & Val(txtSourceNo.Text) & " AND [EXOP_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXOPA_AMOUNT] FROM [OTHER_EXPROVISIONACC] WHERE [EXOPA_KEY]=" & pnl_key & "  AND [EXOPA_SOURCENO]=" & Val(txtSourceNo.Text) & " AND [EXOPA_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXOLP_AMOUNT] FROM [OTHER_EXLEAVEPASSAGE] WHERE [EXOLP_KEY]=" & pnl_key & "  AND [EXOLP_SOURCENO]=" & Val(txtSourceNo.Text) & " AND [EXOLP_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXOWO_AMOUNT] FROM [OTHER_EXFAWRITTENOFF] WHERE [EXOWO_KEY]=" & pnl_key & "  AND [EXOWO_SOURCENO]=" & Val(txtSourceNo.Text) & " AND [EXOWO_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXOIS_AMOUNT] FROM [OTHER_EXINITIALSUB] WHERE [EXOIS_KEY]=" & pnl_key & "  AND [EXOIS_SOURCENO]=" & Val(txtSourceNo.Text) & " AND [EXOIS_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXOCE_AMOUNT] FROM [OTHER_EXCAPITALEXP] WHERE [EXOCE_KEY]=" & pnl_key & "  AND [EXOCE_SOURCENO]=" & Val(txtSourceNo.Text) & " AND [EXOCE_DEDUCTIBLE]='No'"
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXO_AMOUNT] FROM [OTHER_EXPENSES] WHERE [EXO_KEY]=" & pnl_key & " AND [EXO_DEDUCTIBLE]='No' AND [EXO_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    cSQL = "SELECT [EXNA_AMOUNT] FROM [EXPENSES_NONALLOW] WHERE [EXNA_KEY]=" & pnl_key & " AND [EXNA_DEDUCTIBLE]='No' AND [EXNA_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()

    '    '***Start:May 2004 Geline - extra add PC Depreciation Source 1  with nonded
    '    cSQL = "SELECT [EXDEP_AMOUNT] FROM [EXPENSES_DEPRECIATION] WHERE [EXDEP_KEY]=" & pnl_key & " AND [EXDEP_DEDUCTIBLE]='No' AND [EXDEP_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()
    '    '***End:May 2004 Geline

    '    ' === csNgoh Julai 2008 === '
    '    cSQL = "SELECT [PLFPUR_AMOUNT] FROM [PLFST_PURCHASE] WHERE [PLFPUR_KEY]=" & pnl_key & "  AND [PLFPUR_DEDUCTIBLE]='No' AND [PLFPUR_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    If Not rst.EOF Then
    '        Do While Not rst.EOF
    '            NA_Exp = CDbl(NA_Exp) + CDbl(rst.Fields(0))
    '            rst.MoveNext()
    '        Loop
    '    End If
    '    rst.Close()
    '    ' === end csNgoh Julai 2008 === '

    'End Sub

    'Private Sub LoadLvGeneral() 'C2007.4
    '    Dim xItem As ListItem
    '    Dim cnt As Integer

    '    lvGeneral.ListItems.Clear()

    '    cSQL = "SELECT * FROM [NON_ALLOW_LOSS] WHERE [NL_REF_NO]='" & Trim(txtRefNo) & "' AND [NL_YA]='" & Trim(txtYA) & "' AND [NL_SOURCENO] = " & Trim(txtSourceNo) & " AND [NL_CATEGORIZED]= '' ORDER BY [NL_KEY]"
    '    rst = DB.Execute(cSQL)
    '    cnt = 0

    '    While Not rst.EOF
    '        cnt = cnt + 1
    '        xItem = lvGeneral.ListItems.Add(, , "1")
    '        With xItem
    '            .ListSubItems.Add(1, , cnt)
    '            .ListSubItems.Add(2, , rst.Fields(3))
    '            .ListSubItems.Add(3, , rst.Fields(4))
    '            .ListSubItems.Add(4, , rst.Fields(0))
    '            .ListSubItems.Add(5, , rst.Fields(5))
    '            .ListSubItems.Add(6, , "")
    '        End With
    '        rst.MoveNext()
    '    End While

    '    cSQL = "SELECT * FROM [OTHER_EXURLOSSFOREIGN] WHERE [EXOUR_KEY]=" & pnl_key & "  AND [EXOUR_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    'cnt = 0
    '    While Not rst.EOF
    '        cnt = cnt + 1
    '        xItem = lvGeneral.ListItems.Add(, , "1")
    '        With xItem
    '            .ListSubItems.Add(1, , cnt)
    '            .ListSubItems.Add(2, , "Unrealised Loss on Foreign Exchange")
    '            .ListSubItems.Add(3, , rst.Fields(4))
    '            .ListSubItems.Add(4, , rst.Fields(0))
    '            .ListSubItems.Add(5, , "PNL")
    '        End With
    '        rst.MoveNext()
    '    End While

    '    cSQL = "SELECT * FROM [OTHER_EXRLOSSFOREIGN] WHERE [EXOR_KEY]=" & pnl_key & "  AND [EXOR_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    'cnt = 0
    '    While Not rst.EOF
    '        cnt = cnt + 1
    '        xItem = lvGeneral.ListItems.Add(, , "1")
    '        With xItem
    '            .ListSubItems.Add(1, , cnt)
    '            .ListSubItems.Add(2, , "Realised Loss on Foreign Exchange - Non-Trade")
    '            .ListSubItems.Add(3, , rst.Fields(4))
    '            .ListSubItems.Add(4, , rst.Fields(0))
    '            .ListSubItems.Add(5, , "PNL")
    '        End With
    '        rst.MoveNext()
    '    End While

    '    cSQL = "SELECT * FROM [OTHER_EXLOSSDISPOSALFA] WHERE [EXOLD_KEY]=" & pnl_key & "  AND [EXOLD_SOURCENO]=" & Val(txtSourceNo.Text)
    '    rst = DB.Execute(cSQL)
    '    'cnt = 0
    '    While Not rst.EOF
    '        cnt = cnt + 1
    '        xItem = lvGeneral.ListItems.Add(, , "1")
    '        With xItem
    '            .ListSubItems.Add(1, , cnt)
    '            .ListSubItems.Add(2, , "Loss on Disposal of Fixed Assets")
    '            .ListSubItems.Add(3, , rst.Fields(4))
    '            .ListSubItems.Add(4, , rst.Fields(0))
    '            .ListSubItems.Add(5, , "PNL")
    '        End With
    '        rst.MoveNext()
    '    End While

    '    cSQL = "SELECT * FROM [TAXABLE_INCOME] WHERE [TI_REF_NO]='" & Trim(txtRefNo) & "' AND [TI_YA]='" & Trim(txtYA) & "' AND [TI_SOURCENO]=" & Trim(txtSourceNo) & " ORDER BY [TI_KEY]"
    '    rst = DB.Execute(cSQL)
    '    cnt = 0
    '    While Not rst.EOF
    '        cnt = cnt + 1
    '        xItem = lvGeneral.ListItems.Add(, , "3")
    '        With xItem
    '            .ListSubItems.Add(1, , cnt)
    '            .ListSubItems.Add(2, , rst.Fields(3))
    '            .ListSubItems.Add(3, , rst.Fields(4))
    '            .ListSubItems.Add(4, , rst.Fields(0))
    '            .ListSubItems.Add(5, , "")
    '            .ListSubItems.Add(6, , "")
    '        End With
    '        rst.MoveNext()
    '    End While

    '    cSQL = "SELECT * FROM [REVENUE_EXPENDITURE] WHERE [RE_REF_NO]='" & Trim(txtRefNo) & "' AND [RE_YA]='" & Trim(txtYA) & "' AND [RE_SOURCENO]=" & Trim(txtSourceNo) & " ORDER BY [RE_KEY]"
    '    rst = DB.Execute(cSQL)
    '    cnt = 0
    '    While Not rst.EOF
    '        cnt = cnt + 1
    '        xItem = lvGeneral.ListItems.Add(, , "5")
    '        With xItem
    '            .ListSubItems.Add(1, , cnt)
    '            .ListSubItems.Add(2, , rst.Fields(3))
    '            .ListSubItems.Add(3, , rst.Fields(4))
    '            .ListSubItems.Add(4, , rst.Fields(0))
    '            .ListSubItems.Add(5, , "")
    '            .ListSubItems.Add(6, , "")
    '        End With
    '        rst.MoveNext()
    '    End While

    '    cSQL = "SELECT * FROM [OTHER_EXPENDITURE] WHERE [OE_REF_NO]='" & Trim(txtRefNo) & "' AND [OE_YA]='" & Trim(txtYA) & "' AND [OE_SOURCENO]=" & Trim(txtSourceNo) & " ORDER BY [OE_KEY]"
    '    rst = DB.Execute(cSQL)
    '    cnt = 0
    '    While Not rst.EOF
    '        cnt = cnt + 1
    '        xItem = lvGeneral.ListItems.Add(, , "6")
    '        With xItem
    '            .ListSubItems.Add(1, , cnt)

    '            cSQL = "SELECT * FROM [CLAIM] WHERE [CL_CODE]='" & Trim(rst.Fields(3)) & "'"
    '            rst1 = DB.Execute(cSQL)
    '            If Not rst1.EOF Then
    '                .ListSubItems.Add(2, , rst1!CL_DESC)
    '            Else
    '                .ListSubItems.Add(2, , "")
    '            End If
    '            rst1.Close()

    '            .ListSubItems.Add(3, , rst.Fields(4))
    '            .ListSubItems.Add(4, , rst.Fields(0))
    '            .ListSubItems.Add(5, , "")
    '            .ListSubItems.Add(6, , "")
    '        End With
    '        rst.MoveNext()
    '    End While

    '    'pin Start: taxcom C+ v2005.3
    '    cSQL = "SELECT * FROM [OTHER_DEDUCTION] WHERE [OD_REF_NO]='" & Trim(txtRefNo) & "' AND [OD_YA]='" & Trim(txtYA) & "' AND [OD_SOURCENO]=" & Trim(txtSourceNo) & " ORDER BY [OD_KEY]"
    '    rst = DB.Execute(cSQL)
    '    cnt = 0
    '    While Not rst.EOF
    '        cnt = cnt + 1
    '        xItem = lvGeneral.ListItems.Add(, , "7")
    '        With xItem
    '            .ListSubItems.Add(1, , cnt)
    '            .ListSubItems.Add(2, , rst!OD_DESC)
    '            .ListSubItems.Add(3, , rst!OD_AMOUNT)
    '            .ListSubItems.Add(4, , rst.Fields(0))
    '            .ListSubItems.Add(5, , "")
    '            .ListSubItems.Add(6, , "")
    '        End With
    '        rst.MoveNext()
    '    End While
    '    rst.Close()

    '    'pin Start: Phase 3 release 2
    '    cSQL = "SELECT * FROM [SURPLUS_RECOVERED] WHERE [SR_REF_NO]='" & Trim(txtRefNo) & "' AND [SR_YA]='" & Trim(txtYA) & "' AND [SR_SOURCENO]=" & Trim(txtSourceNo) & " ORDER BY [SR_KEY]"
    '    rst = DB.Execute(cSQL)
    '    cnt = 0
    '    While Not rst.EOF
    '        cnt = cnt + 1
    '        xItem = lvGeneral.ListItems.Add(, , "8")
    '        With xItem
    '            .ListSubItems.Add(1, , cnt)
    '            .ListSubItems.Add(2, , rst!SR_DESC)
    '            .ListSubItems.Add(3, , rst!SR_AMOUNT)
    '            .ListSubItems.Add(4, , rst.Fields(0))
    '            .ListSubItems.Add(5, , "")
    '            .ListSubItems.Add(6, , "")
    '        End With
    '        rst.MoveNext()
    '    End While
    '    rst.Close()

    '    cSQL = "SELECT * FROM [MINING_ALLOWNANCE] WHERE [MA_REF_NO]='" & Trim(txtRefNo) & "' AND [MA_YA]='" & Trim(txtYA) & "' AND [MA_SOURCENO]=" & Trim(txtSourceNo) & " ORDER BY [MA_KEY]"
    '    rst = DB.Execute(cSQL)
    '    cnt = 0
    '    While Not rst.EOF
    '        cnt = cnt + 1
    '        xItem = lvGeneral.ListItems.Add(, , "9")
    '        With xItem
    '            .ListSubItems.Add(1, , cnt)
    '            .ListSubItems.Add(2, , rst!MA_DESC)
    '            .ListSubItems.Add(3, , rst!MA_AMOUNT)
    '            .ListSubItems.Add(4, , rst.Fields(0))
    '            .ListSubItems.Add(5, , "")
    '            .ListSubItems.Add(6, , "")
    '        End With
    '        rst.MoveNext()
    '    End While
    '    rst.Close()

    '    cSQL = "SELECT * FROM [MINING_EXPENSES] WHERE [ME_REF_NO]='" & Trim(txtRefNo) & "' AND [ME_YA]='" & Trim(txtYA) & "' AND [ME_SOURCENO]=" & Trim(txtSourceNo) & " ORDER BY [ME_KEY]"
    '    rst = DB.Execute(cSQL)
    '    cnt = 0
    '    While Not rst.EOF
    '        cnt = cnt + 1
    '        xItem = lvGeneral.ListItems.Add(, , "10")
    '        With xItem
    '            .ListSubItems.Add(1, , cnt)
    '            .ListSubItems.Add(2, , rst!ME_DESC)
    '            .ListSubItems.Add(3, , rst!ME_AMOUNT)
    '            .ListSubItems.Add(4, , rst.Fields(0))
    '            .ListSubItems.Add(5, , "")
    '            .ListSubItems.Add(6, , "")
    '        End With
    '        rst.MoveNext()
    '    End While
    '    rst.Close()

    'End Sub

    'Private Sub Form_Unload(Cancel As Integer)
    '    If AdjIncome_Flag = False Then
    '        frmAdjustedIncome.lstView.ListItems.Clear()
    '        Call Refresh_AdjustedIncome()
    '        'Save Before Exit
    '        Cancel = OnScreenClose(Me)
    '    End If

    '    'azham 28072017
    '    If Not Cancel Then
    '        IncomeCal_Flag = False

    '        Screen.ActiveForm.Enabled = True
    '    End If

    'End Sub


    'Private Sub txtAddMiningExp_Change()
    '    Adjusted_Income()

    'End Sub

    'Private Sub txtBalLoss_Change()
    '    Total_BusinessIncome()
    'End Sub

    'Private Sub txtBalProfit_Change()
    '    Total_BusinessIncome()
    'End Sub

    'Private Sub Total_BusinessIncome()

    '    Dim incometotal As Double

    '    If FormatNumber(CDbl(txtBalProfit), 0) = 0 Then
    '        txtTotNonBs = FormatNumber(CDbl(txtDividend) + CDbl(txtRental) + CDbl(txtRoyalty) + CDbl(txtInterest) + CDbl(txtSection4A), 0)
    '        incometotal = FormatNumber(CDbl(txtBalLoss) - CDbl(txtTotNonBs) - CDbl(txtOthBsIn), 0)
    '    ElseIf FormatNumber(CDbl(txtBalLoss), 0) = 0 Then
    '        txtTotNonBs = FormatNumber(CDbl(txtDividend) + CDbl(txtRental) + CDbl(txtRoyalty) + CDbl(txtInterest) + CDbl(txtSection4A), 0)
    '        incometotal = FormatNumber(CDbl(txtBalProfit) - CDbl(txtTotNonBs) - CDbl(txtOthBsIn), 0)
    '    End If

    '    If CDbl(incometotal) <= 0 Then
    '        txtTotBsLoss = FormatNumber(CDbl(incometotal), 0)
    '        txtTotBsProfit = 0
    '    ElseIf CDbl(incometotal) > 0 Then
    '        txtTotBsLoss = 0
    '        txtTotBsProfit = FormatNumber(CDbl(incometotal), 0)
    '    End If

    'End Sub

    'Private Sub txtDividend_Change()
    '    If txtDividend = "" Then txtDividend = 0
    '    If Not IsNumeric(txtDividend) Then Exit Sub
    '    Total_BusinessIncome()
    'End Sub

    'Private Sub txtDividend_GotFocus()
    '    SendKeys "{End}+{Home}"
    'End Sub

    'Private Sub txtDividend_KeyPress(KeyAscii As Integer)
    '    On Error Resume Next
    '    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
    '        KeyAscii = vbKeyCancel
    '        Beep()
    '    End If
    'End Sub

    'Private Sub txtDividend_LostFocus()
    '    If Not IsNumeric(txtDividend) Then
    '        MsgBox("Not a valid number !", vbCritical, "Taxcom")
    '        txtDividend = 0
    '        Exit Sub
    '    End If
    '    txtDividend = FormatNumber(CDbl(txtDividend), 0)
    'End Sub

    'Private Sub txtMiningAllowing_Change()
    '    Adjusted_Income()

    'End Sub

    'Private Sub txtOthBsIn_Change()
    '    Total_BusinessIncome()
    'End Sub

    'Private Sub txtOtherDeduc_Change()  'PIN TAXCOMC+ V 2005.3
    '    Adjusted_Income()
    'End Sub

    'Private Sub txtRental_Change()

    '    If txtRental = "" Then txtRental = 0
    '    If Not IsNumeric(txtRental) Then Exit Sub
    '    Total_BusinessIncome()

    'End Sub

    'Private Sub txtRental_GotFocus()
    '    SendKeys "{End}+{Home}"
    'End Sub

    'Private Sub txtRental_KeyPress(KeyAscii As Integer)
    '    On Error Resume Next
    '    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
    '        KeyAscii = vbKeyCancel
    '        Beep()
    '    End If
    'End Sub

    'Private Sub txtRental_LostFocus()
    '    If Not IsNumeric(txtRental) Then
    '        MsgBox("Not a valid number !", vbCritical, "Taxcom")
    '        txtRental = 0
    '        Exit Sub
    '    End If
    '    txtRental = FormatNumber(CDbl(txtRental), 0)
    'End Sub

    'Private Sub txtRoyalty_Change()
    '    If txtRoyalty = "" Then txtRoyalty = 0
    '    If Not IsNumeric(txtRoyalty) Then Exit Sub
    '    Total_BusinessIncome()
    'End Sub

    'Private Sub txtRoyalty_GotFocus()
    '    SendKeys "{End}+{Home}"
    'End Sub

    'Private Sub txtRoyalty_KeyPress(KeyAscii As Integer)
    '    On Error Resume Next
    '    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
    '        KeyAscii = vbKeyCancel
    '        Beep()
    '    End If
    'End Sub

    'Private Sub txtRoyalty_LostFocus()
    '    If Not IsNumeric(txtRoyalty) Then
    '        MsgBox("Not a valid number !", vbCritical, "Taxcom")
    '        txtRoyalty = 0
    '        Exit Sub
    '    End If
    '    txtRoyalty = FormatNumber(CDbl(txtRoyalty), 0)
    'End Sub

    'Private Sub txtInterest_Change()
    '    If txtInterest = "" Then txtInterest = 0
    '    If Not IsNumeric(txtInterest) Then Exit Sub
    '    Total_BusinessIncome()
    'End Sub

    'Private Sub txtInterest_GotFocus()
    '    SendKeys "{End}+{Home}"
    'End Sub

    'Private Sub txtInterest_KeyPress(KeyAscii As Integer)
    '    On Error Resume Next
    '    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
    '        KeyAscii = vbKeyCancel
    '        Beep()
    '    End If
    'End Sub

    'Private Sub txtInterest_LostFocus()
    '    If Not IsNumeric(txtInterest) Then
    '        MsgBox("Not a valid number !", vbCritical, "Taxcom")
    '        txtInterest = 0
    '        Exit Sub
    '    End If
    '    txtInterest = FormatNumber(CDbl(txtInterest), 0)
    'End Sub

    'Private Sub txtSection4A_GotFocus()
    '    SendKeys "{End}+{Home}"
    'End Sub

    'Private Sub txtSection4A_KeyPress(KeyAscii As Integer)
    '    On Error Resume Next
    '    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
    '        KeyAscii = vbKeyCancel
    '        Beep()
    '    End If
    'End Sub

    'Private Sub txtSection4A_LostFocus()
    '    If Not IsNumeric(txtSection4A) Then
    '        MsgBox("Not a valid number !", vbCritical, "Taxcom")
    '        txtSection4A = 0
    '        Exit Sub
    '    End If
    '    txtSection4A = FormatNumber(CDbl(txtSection4A), 0)
    'End Sub

    'Private Sub txtSection4A_Change()
    '    If txtSection4A = "" Then txtSection4A = 0
    '    If Not IsNumeric(txtSection4A) Then Exit Sub
    '    Total_BusinessIncome()
    'End Sub

    'Private Sub txtSurplusMiningAllowance_Change()
    '    Income_Adjustment()
    'End Sub

    'Private Sub txtTotBsProfit_Change()
    '    Adjusted_Income()
    'End Sub

    'Private Sub txtTotBsLoss_Change()
    '    Adjusted_Income()
    'End Sub

    'Private Sub Adjusted_Income()
    '    Dim adjustedincome As Double
    '    Dim businessincome As Double
    '    Dim businessincomeadjust As Double
    '    Dim businessexpendadjust As Double

    '    If FormatNumber(CDbl(txtTotBsProfit), 0) = 0 Then
    '        '***************
    '        businessincome = FormatNumber(CDbl(txtTotBsLoss), 0)
    '    ElseIf FormatNumber(CDbl(txtTotBsLoss), 0) = 0 Then
    '        businessincome = FormatNumber(CDbl(txtTotBsProfit), 0)
    '    End If
    '    If FormatNumber(CDbl(txtTotBIProfit), 0) = 0 Then
    '        '***************
    '        businessincomeadjust = FormatNumber(CDbl(txtTotBILoss), 0)
    '    ElseIf FormatNumber(CDbl(txtTotBILoss), 0) = 0 Then
    '        businessincomeadjust = FormatNumber(CDbl(txtTotBIProfit), 0)
    '    End If
    '    txtTotBSExp = FormatNumber((CDbl(txtInterestRestricted) + CDbl(txtNAExp)) - (CDbl(txtRevenueExp) + CDbl(txtOthExp) + CDbl(txtOtherDeduc) + CDbl(txtMiningAllowing) + CDbl(txtAddMiningExp)), 0) 'PIN TAXCOMC+ V2005.3 PHASE 3 RELEASE 2
    '    businessexpendadjust = FormatNumber(CDbl(txtTotBSExp), 0)
    '    adjustedincome = FormatNumber(CDbl(businessincome) + CDbl(businessincomeadjust) + CDbl(businessexpendadjust), 0)

    '    If CDbl(adjustedincome) <= 0 Then
    '        txtAdLoss = FormatNumber(CDbl(adjustedincome), 0)
    '        txtAdIn = 0
    '    ElseIf CDbl(adjustedincome) > 0 Then
    '        txtAdLoss = 0
    '        txtAdIn = FormatNumber(CDbl(adjustedincome), 0)
    '    End If
    'End Sub

    'Private Sub txtNALoss_Change()
    '    Income_Adjustment()
    'End Sub

    'Private Sub Income_Adjustment()
    '    Dim temptotal As Double

    '    temptotal = FormatNumber(CDbl(txtNALoss) + CDbl(txtSurplusMiningAllowance) - CDbl(txtNTaxIn) + CDbl(txtTaxIn), 0)

    '    If CDbl(temptotal) <= 0 Then
    '        txtTotBILoss = FormatNumber(CDbl(temptotal), 0)
    '        txtTotBIProfit = 0
    '    ElseIf CDbl(temptotal) > 0 Then
    '        txtTotBILoss = 0
    '        txtTotBIProfit = FormatNumber(CDbl(temptotal), 0)
    '    End If
    'End Sub

    'Private Sub cmdAdd1_Click()
    '    'btnno = 1
    '    cTCType = "EDIT NON ALLOWABLE LOSS"
    '    frmNonAllowableLoss.Show()
    'End Sub

    'Private Sub cmdAdd3_Click()
    '    'btnno = 3
    '    cTCType = "EDIT TAXABLE INCOME"
    '    frmTaxableIncome.Show()
    'End Sub

    'Private Sub cmdAdd5_Click()
    '    cTCType = "EDIT REVENUE EXPENDITURE"
    '    frmRevenueExpenditure.Show()
    'End Sub

    'Private Sub cmdAdd6_Click()
    '    cTCType = "EDIT OTHER EXPENDITURE"
    '    frmOtherExpenditure.Show()
    'End Sub

    'Private Sub txtNTaxIn_Change()
    '    Income_Adjustment()
    'End Sub

    'Private Sub txtTaxIn_Change()
    '    Income_Adjustment()
    'End Sub

    'Private Sub txtTotBILoss_Change()
    '    Adjusted_Income()
    'End Sub

    'Private Sub txtTotBIProfit_Change()
    '    Adjusted_Income()
    'End Sub

    'Private Sub txtTotBSExp_Change()
    '    Adjusted_Income()
    'End Sub

    'Private Sub txtInterestRestricted_Change()
    '    If txtInterestRestricted = "" Then txtInterestRestricted = 0
    '    If Not IsNumeric(txtInterestRestricted) Then Exit Sub
    '    Adjusted_Income()
    'End Sub

    'Private Sub txtInterestRestricted_GotFocus()
    '    SendKeys "{End}+{Home}"
    'End Sub

    'Private Sub txtInterestRestricted_KeyPress(KeyAscii As Integer)
    '    On Error Resume Next
    '    If KeyAscii > 57 Or KeyAscii < 48 And KeyAscii <> 44 And KeyAscii <> 46 And KeyAscii <> vbKeyBack And KeyAscii <> vbKeyDelete Then
    '        KeyAscii = vbKeyCancel
    '        Beep()
    '    End If
    'End Sub

    'Private Sub txtInterestRestricted_LostFocus()
    '    If Not IsNumeric(txtInterestRestricted) Then
    '        MsgBox("Not a valid number !", vbCritical, "Taxcom")
    '        txtInterestRestricted = 0
    '        Exit Sub
    '    End If
    '    txtInterestRestricted = FormatNumber(CDbl(txtInterestRestricted), 0)
    'End Sub

    'Private Sub txtNAExp_Change()
    '    Adjusted_Income()
    'End Sub

    'Private Sub txtRevenueExp_Change()
    '    Adjusted_Income()
    'End Sub

    'Private Sub txtOthExp_Change()
    '    Adjusted_Income()
    'End Sub

    'Public Function ToUpdate_AdjIncome()
    '    cmdSave_Click()
    'End Function

#End Region
End Module
