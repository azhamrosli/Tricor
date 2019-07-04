Imports System.Data.SqlClient
Imports System.Type
Imports DevExpress.Spreadsheet
Imports System.IO
Imports DevExpress.XtraSpreadsheet
Imports Microsoft.Reporting.WinForms
Imports DevExpress.XtraReports.UI

Module mdlPNL2

    Public Sub ClearMemoryDataset(Optional ByRef ErrorLog As ClsError = Nothing)
        Try
            dsDataSet.Tables("PLFST_SALES_DETAIL").Rows.Clear()
            dsDataSet.Tables("PLFST_SALES").Rows.Clear()
            dsDataSet.Tables("PLFST_OPENSTOCK_DETAIL").Rows.Clear()
            dsDataSet.Tables("PLFST_OPENSTOCK").Rows.Clear()
            dsDataSet.Tables("PLFST_PURCHASE_DETAIL").Rows.Clear()
            dsDataSet.Tables("PLFST_PURCHASE").Rows.Clear()
            dsDataSet.Tables("EXPENSES_DEPRECIATION_DETAIL").Rows.Clear()
            dsDataSet.Tables("EXPENSES_DEPRECIATION").Rows.Clear()
            dsDataSet.Tables("EXPENSES_ALLOW_DETAIL").Rows.Clear()
            dsDataSet.Tables("EXPENSES_ALLOW").Rows.Clear()
            dsDataSet.Tables("EXPENSES_NONALLOW_DETAIL").Rows.Clear()
            dsDataSet.Tables("EXPENSES_NONALLOW").Rows.Clear()
            dsDataSet.Tables("PLFST_CLOSESTOCK_DETAIL").Rows.Clear()
            dsDataSet.Tables("PLFST_CLOSESTOCK").Rows.Clear()
            dsDataSet.Tables("NONSOURCE_BUSINESSINCOME_DETAIL").Rows.Clear()
            dsDataSet.Tables("NONSOURCE_BUSINESSINCOME").Rows.Clear()
            dsDataSet.Tables("INCOME_REALFET_DETAIL").Rows.Clear()
            dsDataSet.Tables("INCOME_REALFET").Rows.Clear()
            dsDataSet.Tables("dividend_income").Rows.Clear()
            dsDataSet.Tables("INCOME_NBINTEREST_DETAIL").Rows.Clear()
            dsDataSet.Tables("INCOME_NBINTEREST").Rows.Clear()
            dsDataSet.Tables("INCOME_NBROYALTY_DETAIL").Rows.Clear()
            dsDataSet.Tables("INCOME_NBROYALTY").Rows.Clear()
            dsDataSet.Tables("rental_income").Rows.Clear()
            dsDataSet.Tables("OTHER_INCOME_DETAIL").Rows.Clear()
            dsDataSet.Tables("OTHER_INCOME").Rows.Clear()
            dsDataSet.Tables("INCOME_NTDISPOSALFA_DETAIL").Rows.Clear()
            dsDataSet.Tables("INCOME_NTDISPOSALFA").Rows.Clear()
            dsDataSet.Tables("INCOME_NTDISPOSALINVEST_DETAIL").Rows.Clear()
            dsDataSet.Tables("INCOME_NTDISPOSALINVEST").Rows.Clear()
            dsDataSet.Tables("exempt_dividend").Rows.Clear()
            dsDataSet.Tables("INCOME_NTFOREIGNINCREM_DETAIL").Rows.Clear()
            dsDataSet.Tables("INCOME_NTFOREIGNINCREM").Rows.Clear()
            dsDataSet.Tables("INCOME_NTUREALFET_DETAIL").Rows.Clear()
            dsDataSet.Tables("INCOME_NTUREALFET").Rows.Clear()
            dsDataSet.Tables("INCOME_NTREALFE_DETAIL").Rows.Clear()
            dsDataSet.Tables("INCOME_NTREALFE").Rows.Clear()
            dsDataSet.Tables("INCOME_NTUREALFENT_DETAIL").Rows.Clear()
            dsDataSet.Tables("INCOME_NTUREALFENT").Rows.Clear()
            dsDataSet.Tables("NON_TAXABLE_INCOME_DETAIL").Rows.Clear()
            dsDataSet.Tables("non_taxable_income").Rows.Clear()
            dsDataSet.Tables("REF_INTEREST_RESTRIC_DETAIL_MONTHLY").Rows.Clear()
            dsDataSet.Tables("REF_INTEREST_RESTRIC_DETAIL").Rows.Clear()
            dsDataSet.Tables("EXPENSES_INTERESTRESTRICT").Rows.Clear()
            dsDataSet.Tables("EXPENSES_INTEREST_DETAIL").Rows.Clear()
            dsDataSet.Tables("expenses_interest").Rows.Clear()
            dsDataSet.Tables("EXPENSES_LEGAL_DETAIL").Rows.Clear()
            dsDataSet.Tables("expenses_legal").Rows.Clear()
            dsDataSet.Tables("EXPENSES_TECH_FEE_DETAIL").Rows.Clear()
            dsDataSet.Tables("expenses_tech_fee").Rows.Clear()
            dsDataSet.Tables("EXPENSES_CONTRACT_DETAIL").Rows.Clear()
            dsDataSet.Tables("expenses_contract").Rows.Clear()
            dsDataSet.Tables("EXPENSES_DIRECTORS_FEE_DETAIL").Rows.Clear()
            dsDataSet.Tables("expenses_directors_fee").Rows.Clear()
            dsDataSet.Tables("EXPENSES_SALARY_DETAIL").Rows.Clear()
            dsDataSet.Tables("expenses_salary").Rows.Clear()
            dsDataSet.Tables("EXPENSES_EMPLSTOCK_DETAIL").Rows.Clear()
            dsDataSet.Tables("expenses_empl_stock").Rows.Clear()
            dsDataSet.Tables("EXPENSES_ROYALTY_DETAIL").Rows.Clear()
            dsDataSet.Tables("expenses_royalty").Rows.Clear()
            dsDataSet.Tables("EXPENSES_RENTAL_DETAIL").Rows.Clear()
            dsDataSet.Tables("expenses_rental").Rows.Clear()
            dsDataSet.Tables("EXPENSES_REPAIR_DETAIL").Rows.Clear()
            dsDataSet.Tables("expenses_repair").Rows.Clear()
            dsDataSet.Tables("EXPENSES_RESEARCH_DETAIL").Rows.Clear()
            dsDataSet.Tables("expenses_research").Rows.Clear()
            dsDataSet.Tables("EXPENSES_PROMOTE_DETAIL").Rows.Clear()
            dsDataSet.Tables("expenses_promote").Rows.Clear()
            dsDataSet.Tables("EXPENSES_TRAVEL_DETAIL").Rows.Clear()
            dsDataSet.Tables("expenses_travel").Rows.Clear()
            dsDataSet.Tables("EXPENSES_JKDM_DETAIL").Rows.Clear()
            dsDataSet.Tables("expenses_jkdm").Rows.Clear()
            dsDataSet.Tables("OTHER_EXDEPRECIATION_DETAIL").Rows.Clear()
            dsDataSet.Tables("other_exdepreciation").Rows.Clear()
            dsDataSet.Tables("OTHER_EXAPPRDONATION_DETAIL").Rows.Clear()
            dsDataSet.Tables("other_exapprdonation").Rows.Clear()
            dsDataSet.Tables("OTHER_EXNAPPRDONATION_DETAIL").Rows.Clear()
            dsDataSet.Tables("other_exnapprdonation").Rows.Clear()
            dsDataSet.Tables("OTHER_EXZAKAT_DETAIL").Rows.Clear()
            dsDataSet.Tables("other_exzakat").Rows.Clear()
            dsDataSet.Tables("OTHER_EXLOSSDISPOSALFA_DETAIL").Rows.Clear()
            dsDataSet.Tables("other_exlossdisposalfa").Rows.Clear()
            dsDataSet.Tables("OTHER_ENTERTAINNSTAFF_DETAIL").Rows.Clear()
            dsDataSet.Tables("other_entertainnstaff").Rows.Clear()
            dsDataSet.Tables("OTHER_ENTERTAINSTAFF_DETAIL").Rows.Clear()
            dsDataSet.Tables("OTHER_ENTERTAINSTAFF").Rows.Clear()
            dsDataSet.Tables("OTHER_EXPENALTY_DETAIL").Rows.Clear()
            dsDataSet.Tables("other_expenalty").Rows.Clear()
            dsDataSet.Tables("OTHER_EXPROVISIONACC_DETAIL").Rows.Clear()
            dsDataSet.Tables("other_exprovisionacc").Rows.Clear()
            dsDataSet.Tables("OTHER_EXLEAVEPASSAGE_DETAIL").Rows.Clear()
            dsDataSet.Tables("other_exleavepassage").Rows.Clear()
            dsDataSet.Tables("OTHER_EXFAWRITTENOFF_DETAIL").Rows.Clear()
            dsDataSet.Tables("other_exfawrittenoff").Rows.Clear()
            dsDataSet.Tables("OTHER_EXURLOSSFOREIGN_DETAIL").Rows.Clear()
            dsDataSet.Tables("other_exurlossforeign").Rows.Clear()
            dsDataSet.Tables("OTHER_EXRLOSSFOREIGNT_DETAIL").Rows.Clear()
            dsDataSet.Tables("other_exrlossforeignt").Rows.Clear()
            dsDataSet.Tables("OTHER_EXRLOSSFOREIGN_DETAIL").Rows.Clear()
            dsDataSet.Tables("other_exrlossforeign").Rows.Clear()
            dsDataSet.Tables("OTHER_EXINITIALSUB_DETAIL").Rows.Clear()
            dsDataSet.Tables("other_exinitialsub").Rows.Clear()
            dsDataSet.Tables("OTHER_EXCAPITALEXP_DETAIL").Rows.Clear()
            dsDataSet.Tables("other_excapitalexp").Rows.Clear()
            dsDataSet.Tables("OTHER_EXPENSES_DETAIL").Rows.Clear()
            dsDataSet.Tables("OTHER_EXPENSES").Rows.Clear()


        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
        End Try
    End Sub
    Public Function PNL_GetSaveData(ByVal PNL_Key As Decimal, ByVal Type As TaxComPNLEnuItem, _
                                    ByVal oConn As SqlConnection, ByRef ListofCmd As List(Of SqlCommand), _
                                    ByVal RefNo As String, ByVal YA As String, _
                                    Optional ByRef isIncludeInReport As Boolean = True, Optional ByRef Errorlog As ClsError = Nothing) As Boolean
        Try
            Dim contrl As Control = Nothing
            Dim ds As DataSet = Nothing

            Select Case Type

                Case TaxComPNLEnuItem.DEPRECIATION
                    If doc_p1Depreciation IsNot Nothing AndAlso doc_p1Depreciation.Controls.Count > 0 Then
                        contrl = doc_p1Depreciation.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1Depreciation = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p1Depreciation = CType(contrl, ucPNL_p1Depreciation)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        ADO.Save_EXPENSES_DEPRECIATION(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.SALES
                    If doc_p1Sales IsNot Nothing AndAlso doc_p1Sales.Controls.Count > 0 Then
                        contrl = doc_p1Sales.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1Sales = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p1Sales = CType(contrl, ucPNL_p1Sales)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        ADO.Save_PLFST_SALES(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.OPENSTOCK
                    If doc_p1OpeningStock IsNot Nothing AndAlso doc_p1OpeningStock.Controls.Count > 0 Then
                        contrl = doc_p1OpeningStock.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1OpeningStock = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p1OpeningStock = CType(contrl, ucPNL_p1OpeningStock)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        ADO.Save_PLFST_OPENSTOCK(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.PURCHASE
                    If doc_p1Purchase IsNot Nothing AndAlso doc_p1Purchase.Controls.Count > 0 Then
                        contrl = doc_p1Purchase.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1Purchase = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p1Purchase = CType(contrl, ucPNL_p1Purchase)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        ADO.Save_PLFST_PURCHASE(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.OTHERALLOWEXP
                    If doc_p1AllowanceExpenses IsNot Nothing AndAlso doc_p1AllowanceExpenses.Controls.Count > 0 Then
                        contrl = doc_p1AllowanceExpenses.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1AllowanceExpenses = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p1AllowanceExpenses = CType(contrl, ucPNL_p1AllowanceExpenses)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        ADO.Save_EXPENSES_ALLOW(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.OTHERNONALLOWEXP
                    If doc_p1NonAllowableExpenses IsNot Nothing AndAlso doc_p1NonAllowableExpenses.Controls.Count > 0 Then
                        contrl = doc_p1NonAllowableExpenses.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1NonAllowableExpenses = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p1NonAllowableExpenses = CType(contrl, ucPNL_p1NonAllowableExpenses)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        ADO.Save_EXPENSES_NONALLOW(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.CLOSESTOCK
                    If doc_p1CloseStock IsNot Nothing AndAlso doc_p1CloseStock.Controls.Count > 0 Then
                        contrl = doc_p1CloseStock.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1CloseStock = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p1CloseStock = CType(contrl, ucPNL_p1CloseStock)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        ADO.Save_PLFST_CLOSESTOCK(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.OTHERBUSINC
                    If doc_p2OtherBizIncome IsNot Nothing AndAlso doc_p2OtherBizIncome.Controls.Count > 0 Then
                        contrl = doc_p2OtherBizIncome.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2OtherBizIncome = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2OtherBizIncome = CType(contrl, ucPNL_p2OtherBizIncome)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        ADO.Save_NONSOURCE_BUSINESSINCOME(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.REALFETRADE
                    If doc_p2ForeignCurrExGain IsNot Nothing AndAlso doc_p2ForeignCurrExGain.Controls.Count > 0 Then
                        contrl = doc_p2ForeignCurrExGain.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ForeignCurrExGain = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2ForeignCurrExGain = CType(contrl, ucPNL_p2ForeignCurrExGain)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        ADO.Save_INCOME_REALFET(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.INTERESTINC
                    If doc_p2InterestIncome IsNot Nothing AndAlso doc_p2InterestIncome.Controls.Count > 0 Then
                        contrl = doc_p2InterestIncome.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2InterestIncome = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2InterestIncome = CType(contrl, ucPNL_p2InterestIncome)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        ADO.Save_INCOME_NBINTEREST(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.RENTALINC
                    If doc_p2RentalIncome IsNot Nothing AndAlso doc_p2RentalIncome.Controls.Count > 0 Then
                        contrl = doc_p2RentalIncome.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2RentalIncome = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2RentalIncome = CType(contrl, ucPNL_p2RentalIncome)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        ADO.Save_RENTAL_INCOME(PNL_Key, ds.Tables(uc.MainTable), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.ROYALTYINC
                    If doc_p2RoyaltyIncome IsNot Nothing AndAlso doc_p2RoyaltyIncome.Controls.Count > 0 Then
                        contrl = doc_p2RoyaltyIncome.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2RoyaltyIncome = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2RoyaltyIncome = CType(contrl, ucPNL_p2RoyaltyIncome)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        ADO.Save_INCOME_NBROYALTY(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.OTHERINC
                    If doc_p2OtherIncome IsNot Nothing AndAlso doc_p2OtherIncome.Controls.Count > 0 Then
                        contrl = doc_p2OtherIncome.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2OtherIncome = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2OtherIncome = CType(contrl, ucPNL_p2OtherIncome)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        ADO.Save_OTHER_INCOME(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.PDFIXASSET
                    If doc_p2ProDispPlantEq IsNot Nothing AndAlso doc_p2ProDispPlantEq.Controls.Count > 0 Then
                        contrl = doc_p2ProDispPlantEq.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ProDispPlantEq = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2ProDispPlantEq = CType(contrl, ucPNL_p2ProDispPlantEq)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        ADO.Save_INCOME_NTDISPOSALFA(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.PDINVEST
                    If doc_p2ProDisInvestment IsNot Nothing AndAlso doc_p2ProDisInvestment.Controls.Count > 0 Then
                        contrl = doc_p2ProDisInvestment.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ProDisInvestment = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2ProDisInvestment = CType(contrl, ucPNL_p2ProDisInvestment)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        ADO.Save_INCOME_NTDISPOSALINVEST(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.EXEMDIV
                    If doc_p2ExemptDividend IsNot Nothing AndAlso doc_p2ExemptDividend.Controls.Count > 0 Then
                        contrl = doc_p2ExemptDividend.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ExemptDividend = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2ExemptDividend = CType(contrl, ucPNL_p2ExemptDividend)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        ADO.Save_EXEMPT_DIVIDEND(PNL_Key, ds.Tables(uc.MainTable), oConn, ListofCmd, Errorlog)
                    End If


                Case TaxComPNLEnuItem.FORINCREMIT
                    If doc_p2ForeIncomeRemmit IsNot Nothing AndAlso doc_p2ForeIncomeRemmit.Controls.Count > 0 Then
                        contrl = doc_p2ForeIncomeRemmit.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ForeIncomeRemmit = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2ForeIncomeRemmit = CType(contrl, ucPNL_p2ForeIncomeRemmit)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        ADO.Save_INCOME_NTFOREIGNINCREM(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.REALFE
                    If doc_p2UnreaGainForeEx IsNot Nothing AndAlso doc_p2UnreaGainForeEx.Controls.Count > 0 Then
                        contrl = doc_p2UnreaGainForeEx.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2UnreaGainForeEx = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2UnreaGainForeEx = CType(contrl, ucPNL_p2UnreaGainForeEx)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        ADO.Save_INCOME_NTUREALFET(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.UNREALFENONTRADE
                    If doc_p2ReaForeExGainNonTrade IsNot Nothing AndAlso doc_p2ReaForeExGainNonTrade.Controls.Count > 0 Then
                        contrl = doc_p2ReaForeExGainNonTrade.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ReaForeExGainNonTrade = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2ReaForeExGainNonTrade = CType(contrl, ucPNL_p2ReaForeExGainNonTrade)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        ADO.Save_INCOME_NTREALFE(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.UNREALFETRADE
                    If doc_p2UnreaGainForeExNon IsNot Nothing AndAlso doc_p2UnreaGainForeExNon.Controls.Count > 0 Then
                        contrl = doc_p2UnreaGainForeExNon.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2UnreaGainForeExNon = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2UnreaGainForeExNon = CType(contrl, ucPNL_p2UnreaGainForeExNon)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        ADO.Save_INCOME_NTUREALFENT(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.OTHERNONTAXINC
                    If doc_p2Other IsNot Nothing AndAlso doc_p2Other.Controls.Count > 0 Then
                        contrl = doc_p2Other.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2Other = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2Other = CType(contrl, ucPNL_p2Other)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        ADO.Save_NON_TAXABLE_INCOME(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.INTERESTRESTRICT
                    If doc_p3InterestResPurS33 IsNot Nothing AndAlso doc_p3InterestResPurS33.Controls.Count > 0 Then
                        contrl = doc_p3InterestResPurS33.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3InterestResPurS33 = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3InterestResPurS33 = CType(contrl, ucPNL_p3InterestResPurS33)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        ADO.Save_EXPENSES_INTERESTRESTRICT(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Monthly), oConn, RefNo, YA, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPOTHERINTEREST
                    If doc_p3OtherInterestExHirePur IsNot Nothing AndAlso doc_p3OtherInterestExHirePur.Controls.Count > 0 Then
                        contrl = doc_p3OtherInterestExHirePur.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3OtherInterestExHirePur = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3OtherInterestExHirePur = CType(contrl, ucPNL_p3OtherInterestExHirePur)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_EXPENSES_INTEREST(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPLEGAL
                    If doc_p3ProTechManLeganFees IsNot Nothing AndAlso doc_p3ProTechManLeganFees.Controls.Count > 0 Then
                        contrl = doc_p3ProTechManLeganFees.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3ProTechManLeganFees = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3ProTechManLeganFees = CType(contrl, ucPNL_p3ProTechManLeganFees)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_EXPENSES_LEGAL(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPTECHNICAL
                    If doc_p3TechPayNonResis IsNot Nothing AndAlso doc_p3TechPayNonResis.Controls.Count > 0 Then
                        contrl = doc_p3TechPayNonResis.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3TechPayNonResis = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3TechPayNonResis = CType(contrl, ucPNL_p3TechPayNonResis)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_EXPENSES_TECH_FEE(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPCONTRACTPAY
                    If doc_p3ContractPay IsNot Nothing AndAlso doc_p3ContractPay.Controls.Count > 0 Then
                        contrl = doc_p3ContractPay.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3ContractPay = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3ContractPay = CType(contrl, ucPNL_p3ContractPay)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_EXPENSES_CONTRACT(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPDIRECTORFEE
                    If doc_p3DirectorFee IsNot Nothing AndAlso doc_p3DirectorFee.Controls.Count > 0 Then
                        contrl = doc_p3DirectorFee.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3DirectorFee = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3DirectorFee = CType(contrl, ucPNL_p3DirectorFee)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_EXPENSES_DIRECTORS_FEE(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPSALARY
                    If doc_p3Salary IsNot Nothing AndAlso doc_p3Salary.Controls.Count > 0 Then
                        contrl = doc_p3Salary.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Salary = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3Salary = CType(contrl, ucPNL_p3Salary)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_EXPENSES_SALARY(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPEMPLOYEESTOCK
                    If doc_p3COEStock IsNot Nothing AndAlso doc_p3COEStock.Controls.Count > 0 Then
                        contrl = doc_p3COEStock.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3COEStock = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3COEStock = CType(contrl, ucPNL_p3COEStock)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False

                        End If
                        ADO.Save_EXPENSES_EMPL_STOCK(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPROYALTY
                    If doc_p3Royalty IsNot Nothing AndAlso doc_p3Royalty.Controls.Count > 0 Then
                        contrl = doc_p3Royalty.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Royalty = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3Royalty = CType(contrl, ucPNL_p3Royalty)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_EXPENSES_ROYALTY(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPRENTAL
                    If doc_p3Rental IsNot Nothing AndAlso doc_p3Rental.Controls.Count > 0 Then
                        contrl = doc_p3Rental.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Rental = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3Rental = CType(contrl, ucPNL_p3Rental)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_EXPENSES_RENTAL(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPREPAIRMAINTENANCE
                    If doc_p3RepairMain IsNot Nothing AndAlso doc_p3RepairMain.Controls.Count > 0 Then
                        contrl = doc_p3RepairMain.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3RepairMain = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3RepairMain = CType(contrl, ucPNL_p3RepairMain)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_EXPENSES_REPAIR(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPRND
                    If doc_p3ResearchDev IsNot Nothing AndAlso doc_p3ResearchDev.Controls.Count > 0 Then
                        contrl = doc_p3ResearchDev.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3ResearchDev = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3ResearchDev = CType(contrl, ucPNL_p3ResearchDev)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_EXPENSES_RESEARCH(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPADVERTISEMENT
                    If doc_p3PromotionAds IsNot Nothing AndAlso doc_p3PromotionAds.Controls.Count > 0 Then
                        contrl = doc_p3PromotionAds.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3PromotionAds = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3PromotionAds = CType(contrl, ucPNL_p3PromotionAds)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_EXPENSES_PROMOTE(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPTRAVEL
                    If doc_p3Travelling IsNot Nothing AndAlso doc_p3Travelling.Controls.Count > 0 Then
                        contrl = doc_p3Travelling.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Travelling = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3Travelling = CType(contrl, ucPNL_p3Travelling)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_EXPENSES_TRAVEL(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPJKDM
                    If doc_p3JKDM IsNot Nothing AndAlso doc_p3JKDM.Controls.Count > 0 Then
                        contrl = doc_p3JKDM.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3JKDM = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3JKDM = CType(contrl, ucPNL_p3JKDM)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_EXPENSES_JKDM(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPDEPRECIATION
                    If doc_p3Depreciation IsNot Nothing AndAlso doc_p3Depreciation.Controls.Count > 0 Then
                        contrl = doc_p3Depreciation.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Depreciation = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3Depreciation = CType(contrl, ucPNL_p3Depreciation)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_OTHER_EXDEPRECIATION(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPDONATIONAPPR
                    If doc_p3DonationApp IsNot Nothing AndAlso doc_p3DonationApp.Controls.Count > 0 Then
                        contrl = doc_p3DonationApp.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3DonationApp = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3DonationApp = CType(contrl, ucPNL_p3DonationApp)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_OTHER_EXAPPRDONATION(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPDONATIONNONAPPR
                    If doc_p3DonationNonApp IsNot Nothing AndAlso doc_p3DonationNonApp.Controls.Count > 0 Then
                        contrl = doc_p3DonationNonApp.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3DonationNonApp = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3DonationNonApp = CType(contrl, ucPNL_p3DonationNonApp)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_OTHER_EXNAPPRDONATION(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPZAKAT
                    If doc_p3Zakat IsNot Nothing AndAlso doc_p3Zakat.Controls.Count > 0 Then
                        contrl = doc_p3Zakat.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Zakat = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3Zakat = CType(contrl, ucPNL_p3Zakat)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_OTHER_EXZAKAT(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPLOSSDISPFA
                    If doc_p4LossDispFA IsNot Nothing AndAlso doc_p4LossDispFA.Controls.Count > 0 Then
                        contrl = doc_p4LossDispFA.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4LossDispFA = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4LossDispFA = CType(contrl, ucPNL_p4LossDispFA)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_OTHER_EXLOSSDISPOSALFA(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If


                Case TaxComPNLEnuItem.EXPENTERTAINNONSTAFF
                    If doc_p4EntNonStaff IsNot Nothing AndAlso doc_p4EntNonStaff.Controls.Count > 0 Then
                        contrl = doc_p4EntNonStaff.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4EntNonStaff = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4EntNonStaff = CType(contrl, ucPNL_p4EntNonStaff)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_OTHER_ENTERTAINNSTAFF(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPENTERTAINSTAFF
                    If doc_p4EntStaff IsNot Nothing AndAlso doc_p4EntStaff.Controls.Count > 0 Then
                        contrl = doc_p4EntStaff.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4EntStaff = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4EntStaff = CType(contrl, ucPNL_p4EntStaff)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_OTHER_ENTERTAINSTAFF(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPCOMPAUNDPENALTY
                    If doc_p4Compound IsNot Nothing AndAlso doc_p4Compound.Controls.Count > 0 Then
                        contrl = doc_p4Compound.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4Compound = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4Compound = CType(contrl, ucPNL_p4Compound)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_OTHER_EXPENALTY(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.EXPPROVISION
                    If doc_p4ProvisionAcc IsNot Nothing AndAlso doc_p4ProvisionAcc.Controls.Count > 0 Then
                        contrl = doc_p4ProvisionAcc.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4ProvisionAcc = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4ProvisionAcc = CType(contrl, ucPNL_p4ProvisionAcc)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_OTHER_EXPROVISIONACC(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.EXPLEAVEPASSAGE
                    If doc_p4LeavePass IsNot Nothing AndAlso doc_p4LeavePass.Controls.Count > 0 Then
                        contrl = doc_p4LeavePass.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4LeavePass = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4LeavePass = CType(contrl, ucPNL_p4LeavePass)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_OTHER_EXLEAVEPASSAGE(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.EXPFAWRITTENOFF
                    If doc_p4FAWrittenOff IsNot Nothing AndAlso doc_p4FAWrittenOff.Controls.Count > 0 Then
                        contrl = doc_p4FAWrittenOff.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4FAWrittenOff = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4FAWrittenOff = CType(contrl, ucPNL_p4FAWrittenOff)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_OTHER_EXFAWRITTENOFF(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPUNREALLOSSFE
                    If doc_p4UnreaLossForeEx IsNot Nothing AndAlso doc_p4UnreaLossForeEx.Controls.Count > 0 Then
                        contrl = doc_p4UnreaLossForeEx.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4UnreaLossForeEx = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4UnreaLossForeEx = CType(contrl, ucPNL_p4UnreaLossForeEx)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_OTHER_EXURLOSSFOREIGN(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPREALLOSSFETRADE
                    If doc_p4ReaLossForeExTrade IsNot Nothing AndAlso doc_p4ReaLossForeExTrade.Controls.Count > 0 Then
                        contrl = doc_p4ReaLossForeExTrade.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4ReaLossForeExTrade = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4ReaLossForeExTrade = CType(contrl, ucPNL_p4ReaLossForeExTrade)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_OTHER_EXRLOSSFOREIGNT(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPREALLOSSFENONTRADE
                    If doc_p4ReaLossForeExNonTrade IsNot Nothing AndAlso doc_p4ReaLossForeExNonTrade.Controls.Count > 0 Then
                        contrl = doc_p4ReaLossForeExNonTrade.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4ReaLossForeExNonTrade = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4ReaLossForeExNonTrade = CType(contrl, ucPNL_p4ReaLossForeExNonTrade)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_OTHER_EXRLOSSFOREIGN(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPINITIALSUBSCRIPT
                    If doc_p4InitSub IsNot Nothing AndAlso doc_p4InitSub.Controls.Count > 0 Then
                        contrl = doc_p4InitSub.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4InitSub = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4InitSub = CType(contrl, ucPNL_p4InitSub)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_OTHER_EXINITIALSUB(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPCAPITALEXPENDITURE
                    If doc_p4CAExpenditure IsNot Nothing AndAlso doc_p4CAExpenditure.Controls.Count > 0 Then
                        contrl = doc_p4CAExpenditure.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4CAExpenditure = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4CAExpenditure = CType(contrl, ucPNL_p4CAExpenditure)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If

                        ADO.Save_OTHER_EXCAPITALEXP(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
                    If doc_p4Other IsNot Nothing AndAlso doc_p4Other.Controls.Count > 0 Then
                        contrl = doc_p4Other.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4Other = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4Other = CType(contrl, ucPNL_p4Other)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        If uc.chkIncludeInReport IsNot Nothing AndAlso uc.chkIncludeInReport.EditValue = True Then
                            isIncludeInReport = True
                        Else
                            isIncludeInReport = False
                        End If
                        ADO.Save_OTHER_EXPENSES(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)



                    End If
                Case TaxComPNLEnuItem.DIVIDENDINC
                    If doc_p2DivIncome IsNot Nothing AndAlso doc_p2DivIncome.Controls.Count > 0 Then
                        contrl = doc_p2DivIncome.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2DivIncome = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2DivIncome = CType(contrl, ucPNL_p2DivIncome)

                        ds = uc.DataView_Main2

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        ADO.Save_DIVIDEND_INCOME(PNL_Key, ds.Tables(uc.MainTable), uc.GetDiscloseNet, oConn, ListofCmd, Errorlog)
                    End If
            End Select

            Return False
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            Return False
        End Try
    End Function
    Public Function GetIncludeInReport(ByVal type As TaxComPNLEnuItem, ByVal dt As DataTable) As Boolean
        Try
            Select Case type
                Case TaxComPNLEnuItem.EXPOTHERINTEREST
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_EXP_INT")) = False AndAlso CBool(dt.Rows(0)("PL_EXP_INT")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPLEGAL
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_LAWYER_COST")) = False AndAlso CBool(dt.Rows(0)("PL_LAWYER_COST")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPTECHNICAL
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_TECH_FEE")) = False AndAlso CBool(dt.Rows(0)("PL_TECH_FEE")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPCONTRACTPAY
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_CONTRACT_EXP")) = False AndAlso CBool(dt.Rows(0)("PL_CONTRACT_EXP")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPDIRECTORFEE
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_DIRECTORS_FEE")) = False AndAlso CBool(dt.Rows(0)("PL_DIRECTORS_FEE")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPSALARY
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_EXP_SALARY")) = False AndAlso CBool(dt.Rows(0)("PL_EXP_SALARY")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPEMPLOYEESTOCK
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_EMPL_STOCK")) = False AndAlso CBool(dt.Rows(0)("PL_EMPL_STOCK")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPROYALTY
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_ROYALTY")) = False AndAlso CBool(dt.Rows(0)("PL_ROYALTY")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPRENTAL
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_EXP_RENT")) = False AndAlso CBool(dt.Rows(0)("PL_EXP_RENT")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPREPAIRMAINTENANCE
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_EXP_MAINTENANCE")) = False AndAlso CBool(dt.Rows(0)("PL_EXP_MAINTENANCE")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPRND
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_RND")) = False AndAlso CBool(dt.Rows(0)("PL_RND")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPADVERTISEMENT
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_ADVERT")) = False AndAlso CBool(dt.Rows(0)("PL_ADVERT")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPTRAVEL
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_TRAVEL")) = False AndAlso CBool(dt.Rows(0)("PL_TRAVEL")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.FORECURREXLOSS
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_OTHER_EXP_UNREALOSS")) = False AndAlso CBool(dt.Rows(0)("PL_OTHER_EXP_UNREALOSS")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPJKDM
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_JKDM")) = False AndAlso CBool(dt.Rows(0)("PL_JKDM")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPDEPRECIATION
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_OTHER_EXP_DPC")) = False AndAlso CBool(dt.Rows(0)("PL_OTHER_EXP_DPC")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPDONATIONAPPR
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_OTHER_EXP_DNT_APP")) = False AndAlso CBool(dt.Rows(0)("PL_OTHER_EXP_DNT_APP")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPDONATIONNONAPPR
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_OTHER_EXP_DNT_NAPP")) = False AndAlso CBool(dt.Rows(0)("PL_OTHER_EXP_DNT_NAPP")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPZAKAT
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_OTHER_EXP_ZAKAT")) = False AndAlso CBool(dt.Rows(0)("PL_OTHER_EXP_ZAKAT")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPLOSSDISPFA
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_OTHER_EXP_FA_DISP")) = False AndAlso CBool(dt.Rows(0)("PL_OTHER_EXP_FA_DISP")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPENTERTAINNONSTAFF
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_OTHER_EXP_ENTM_CLNT")) = False AndAlso CBool(dt.Rows(0)("PL_OTHER_EXP_ENTM_CLNT")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPENTERTAINSTAFF
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_OTHER_EXP_ENTM_STFF")) = False AndAlso CBool(dt.Rows(0)("PL_OTHER_EXP_ENTM_STFF")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPCOMPAUNDPENALTY
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_OTHER_EXP_PENALTY")) = False AndAlso CBool(dt.Rows(0)("PL_OTHER_EXP_PENALTY")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPPROVISION
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_OTHER_EXP_PROV_ACC")) = False AndAlso CBool(dt.Rows(0)("PL_OTHER_EXP_PROV_ACC")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPLEAVEPASSAGE
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_OTHER_EXP_LEAVE")) = False AndAlso CBool(dt.Rows(0)("PL_OTHER_EXP_LEAVE")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPFAWRITTENOFF
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_OTHER_EXP_FA_WO")) = False AndAlso CBool(dt.Rows(0)("PL_OTHER_EXP_FA_WO")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPUNREALLOSSFE
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_OTHER_EXP_UNREALOSS")) = False AndAlso CBool(dt.Rows(0)("PL_OTHER_EXP_UNREALOSS")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPREALLOSSFETRADE
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_OTHER_EXP_REALOSS")) = False AndAlso CBool(dt.Rows(0)("PL_OTHER_EXP_REALOSS")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPREALLOSSFENONTRADE
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_OTHER_EXRLOSSFOREIGNT")) = False AndAlso CBool(dt.Rows(0)("PL_OTHER_EXRLOSSFOREIGNT")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPINITIALSUBSCRIPT
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_OTHER_EXP_INI_SUB")) = False AndAlso CBool(dt.Rows(0)("PL_OTHER_EXP_INI_SUB")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPCAPITALEXPENDITURE
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_OTHER_EXP_CAP_EXP")) = False AndAlso CBool(dt.Rows(0)("PL_OTHER_EXP_CAP_EXP")) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
                    If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("PL_OTHER_EXP_OTHERS")) = False AndAlso CBool(dt.Rows(0)("PL_OTHER_EXP_OTHERS")) = True Then
                        Return True
                    Else
                        Return False
                    End If

                Case Else
                    Return True
            End Select
            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            Return True
        End Try
    End Function

    Public Function PNL_ReCalcAll_Amount(ByVal Type As TaxComPNLEnuItem, ByRef ds As DataSet, ByRef txtAmount As DevExpress.XtraEditors.TextEdit, Optional ByRef Errorlog As ClsError = Nothing) As Boolean
        Try
            Select Case Type
                Case TaxComPNLEnuItem.SALES
                    CalcTotalofView(txtAmount, ds, ucPNL_p1Sales.MainTable, ucPNL_p1Sales.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.OPENSTOCK
                    CalcTotalofView(txtAmount, ds, ucPNL_p1OpeningStock.MainTable, ucPNL_p1OpeningStock.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.PURCHASE
                    CalcTotalofView(txtAmount, ds, ucPNL_p1Purchase.MainTable, ucPNL_p1Purchase.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.DEPRECIATION
                    CalcTotalofView(txtAmount, ds, ucPNL_p1Depreciation.MainTable, ucPNL_p1Depreciation.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.OTHERALLOWEXP
                    CalcTotalofView(txtAmount, ds, ucPNL_p1AllowanceExpenses.MainTable, ucPNL_p1AllowanceExpenses.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.OTHERNONALLOWEXP
                    CalcTotalofView(txtAmount, ds, ucPNL_p1NonAllowableExpenses.MainTable, ucPNL_p1NonAllowableExpenses.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.CLOSESTOCK
                    CalcTotalofView(txtAmount, ds, ucPNL_p1CloseStock.MainTable, ucPNL_p1CloseStock.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.OTHERBUSINC
                    CalcTotalofView(txtAmount, ds, ucPNL_p2OtherBizIncome.MainTable, ucPNL_p2OtherBizIncome.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.REALFETRADE
                    CalcTotalofView(txtAmount, ds, ucPNL_p2ForeignCurrExGain.MainTable, ucPNL_p2ForeignCurrExGain.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.DIVIDENDINC

                    If doc_p2DivIncome IsNot Nothing AndAlso doc_p2DivIncome.Controls.Count > 0 Then
                        Dim contrl As Control
                        contrl = doc_p2DivIncome.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2DivIncome = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2DivIncome = CType(contrl, ucPNL_p2DivIncome)

                        If uc.GetDiscloseNet Then
                            CalcTotalofView(txtAmount, ds, ucPNL_p2DivIncome.MainTable, ucPNL_p2DivIncome.MainAmount_DI_NET, 0, Errorlog)
                        Else
                            CalcTotalofView(txtAmount, ds, ucPNL_p2DivIncome.MainTable, ucPNL_p2DivIncome.MainAmount_DI_GROSS, 0, Errorlog)
                        End If

                    End If

                Case TaxComPNLEnuItem.INTERESTINC
                    CalcTotalofView(txtAmount, ds, ucPNL_p2InterestIncome.MainTable, ucPNL_p2InterestIncome.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.RENTALINC
                    CalcTotalofViewRental(txtAmount, ds, ucPNL_p2RentalIncome.MainTable, ucPNL_p2RentalIncome.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.ROYALTYINC
                    CalcTotalofView(txtAmount, ds, ucPNL_p2RoyaltyIncome.MainTable, ucPNL_p2RoyaltyIncome.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.OTHERINC
                    CalcTotalofView(txtAmount, ds, ucPNL_p2OtherIncome.MainTable, ucPNL_p2OtherIncome.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.PDFIXASSET
                    CalcTotalofView(txtAmount, ds, ucPNL_p2ProDispPlantEq.MainTable, ucPNL_p2ProDispPlantEq.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.PDINVEST
                    CalcTotalofView(txtAmount, ds, ucPNL_p2ProDisInvestment.MainTable, ucPNL_p2ProDisInvestment.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXEMDIV
                    CalcTotalofView(txtAmount, ds, ucPNL_p2ExemptDividend.MainTable, ucPNL_p2ExemptDividend.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.FORINCREMIT
                    CalcTotalofView(txtAmount, ds, ucPNL_p2ForeIncomeRemmit.MainTable, ucPNL_p2ForeIncomeRemmit.MainAmount, 0, Errorlog)


                Case TaxComPNLEnuItem.REALFE
                    CalcTotalofView(txtAmount, ds, ucPNL_p2ReaForeExGainNonTrade.MainTable, ucPNL_p2ReaForeExGainNonTrade.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.UNREALFENONTRADE
                    CalcTotalofView(txtAmount, ds, ucPNL_p2UnreaGainForeExNon.MainTable, ucPNL_p2UnreaGainForeExNon.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.UNREALFETRADE
                    CalcTotalofView(txtAmount, ds, ucPNL_p2UnreaGainForeEx.MainTable, ucPNL_p2UnreaGainForeEx.MainAmount, 0, Errorlog)

                Case TaxComPNLEnuItem.OTHERNONTAXINC
                    CalcTotalofView(txtAmount, ds, ucPNL_p2Other.MainTable, ucPNL_p2Other.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.INTERESTRESTRICT
                    CalcTotalofView(txtAmount, ds, ucPNL_p3InterestResPurS33.MainTable, ucPNL_p3InterestResPurS33.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPOTHERINTEREST
                    CalcTotalofView(txtAmount, ds, ucPNL_p3OtherInterestExHirePur.MainTable, ucPNL_p3OtherInterestExHirePur.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPLEGAL
                    CalcTotalofView(txtAmount, ds, ucPNL_p3ProTechManLeganFees.MainTable, ucPNL_p3ProTechManLeganFees.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPTECHNICAL
                    CalcTotalofView(txtAmount, ds, ucPNL_p3TechPayNonResis.MainTable, ucPNL_p3TechPayNonResis.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPCONTRACTPAY
                    CalcTotalofView(txtAmount, ds, ucPNL_p3ContractPay.MainTable, ucPNL_p3ContractPay.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPDIRECTORFEE
                    CalcTotalofView(txtAmount, ds, ucPNL_p3DirectorFee.MainTable, ucPNL_p3DirectorFee.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPSALARY
                    CalcTotalofView(txtAmount, ds, ucPNL_p3Salary.MainTable, ucPNL_p3Salary.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPEMPLOYEESTOCK
                    CalcTotalofView(txtAmount, ds, ucPNL_p3COEStock.MainTable, ucPNL_p3COEStock.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPROYALTY
                    CalcTotalofView(txtAmount, ds, ucPNL_p3Royalty.MainTable, ucPNL_p3Royalty.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPRENTAL
                    CalcTotalofView(txtAmount, ds, ucPNL_p3Rental.MainTable, ucPNL_p3Rental.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPREPAIRMAINTENANCE
                    CalcTotalofView(txtAmount, ds, ucPNL_p3RepairMain.MainTable, ucPNL_p3RepairMain.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPRND
                    CalcTotalofView(txtAmount, ds, ucPNL_p3ResearchDev.MainTable, ucPNL_p3ResearchDev.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPADVERTISEMENT
                    CalcTotalofView(txtAmount, ds, ucPNL_p3PromotionAds.MainTable, ucPNL_p3PromotionAds.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPTRAVEL
                    CalcTotalofView(txtAmount, ds, ucPNL_p3Travelling.MainTable, ucPNL_p3Travelling.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPJKDM
                    CalcTotalofView(txtAmount, ds, ucPNL_p3JKDM.MainTable, ucPNL_p3JKDM.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPDEPRECIATION
                    CalcTotalofView(txtAmount, ds, ucPNL_p3Depreciation.MainTable, ucPNL_p3Depreciation.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPDONATIONAPPR
                    CalcTotalofView(txtAmount, ds, ucPNL_p3DonationApp.MainTable, ucPNL_p3DonationApp.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPDONATIONNONAPPR
                    CalcTotalofView(txtAmount, ds, ucPNL_p3DonationNonApp.MainTable, ucPNL_p3DonationNonApp.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPZAKAT
                    CalcTotalofView(txtAmount, ds, ucPNL_p3Zakat.MainTable, ucPNL_p3Zakat.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPLOSSDISPFA
                    CalcTotalofView(txtAmount, ds, ucPNL_p4LossDispFA.MainTable, ucPNL_p4LossDispFA.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPENTERTAINNONSTAFF
                    CalcTotalofView(txtAmount, ds, ucPNL_p4EntNonStaff.MainTable, ucPNL_p4EntNonStaff.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPENTERTAINSTAFF
                    CalcTotalofView(txtAmount, ds, ucPNL_p4EntStaff.MainTable, ucPNL_p4EntStaff.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPCOMPAUNDPENALTY
                    CalcTotalofView(txtAmount, ds, ucPNL_p4Compound.MainTable, ucPNL_p4Compound.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPPROVISION
                    CalcTotalofView(txtAmount, ds, ucPNL_p4ProvisionAcc.MainTable, ucPNL_p4ProvisionAcc.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPLEAVEPASSAGE
                    CalcTotalofView(txtAmount, ds, ucPNL_p4LeavePass.MainTable, ucPNL_p4LeavePass.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPFAWRITTENOFF
                    CalcTotalofView(txtAmount, ds, ucPNL_p4FAWrittenOff.MainTable, ucPNL_p4FAWrittenOff.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPUNREALLOSSFE
                    CalcTotalofView(txtAmount, ds, ucPNL_p4UnreaLossForeEx.MainTable, ucPNL_p4UnreaLossForeEx.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPREALLOSSFETRADE
                    CalcTotalofView(txtAmount, ds, ucPNL_p4ReaLossForeExTrade.MainTable, ucPNL_p4ReaLossForeExTrade.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPREALLOSSFENONTRADE
                    CalcTotalofView(txtAmount, ds, ucPNL_p4ReaLossForeExNonTrade.MainTable, ucPNL_p4ReaLossForeExNonTrade.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPINITIALSUBSCRIPT
                    CalcTotalofView(txtAmount, ds, ucPNL_p4InitSub.MainTable, ucPNL_p4InitSub.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPCAPITALEXPENDITURE
                    CalcTotalofView(txtAmount, ds, ucPNL_p4CAExpenditure.MainTable, ucPNL_p4CAExpenditure.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
                    CalcTotalofView(txtAmount, ds, ucPNL_p4Other.MainTable, ucPNL_p4Other.MainAmount, 0, Errorlog)
            End Select

            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            Return True
        End Try
    End Function
    Public Function PNL_GetData(ByVal PNL_KEY As Decimal, ByVal Type As TaxComPNLEnuItem, _
                                    ByVal RefNo As String, ByVal YA As String, ByRef ds As DataSet, _
                                    Optional ByRef Errorlog As ClsError = Nothing, Optional ByRef isHaveData As Boolean = False, _
                                    Optional ByVal isPrint As Boolean = False, Optional clsNote As clsNote_PNL = Nothing) As Boolean
        Dim strError As String = Nothing
        Try

            Dim dt As DataTable = Nothing
            Dim dtChild As DataTable = Nothing
            Dim dtRow As DataRow = Nothing
            Dim TmpID As Integer = 0
            Dim NoteOrder As Integer = 0
            Dim dtNote As DataTable = Nothing
            Dim dtNoteColumn As DataTable = Nothing
            strError = Type.ToString
            Select Case Type
                Case TaxComPNLEnuItem.SALES
                    dt = Nothing
                    dt = ADO.Load_PNL_PLFST_SALES(PNL_KEY, Errorlog)

                    ds.Tables("PLFST_SALES_DETAIL").Rows.Clear()
                    ds.Tables("PLFST_SALES").Rows.Clear()

                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("PLFST_SALES").NewRow
                            dtRow("PLFS_KEY") = rowx("PLFS_KEY")
                            dtRow("PLFS_PLFSKEY") = rowx("PLFS_PLFSKEY")
                            dtRow("PLFS_SOURCENO") = rowx("PLFS_SOURCENO")
                            dtRow("PLFS_DESC") = rowx("PLFS_DESC")
                            dtRow("PLFS_AMOUNT") = rowx("PLFS_AMOUNT")
                            dtRow("PLFS_NOTE") = rowx("PLFS_NOTE")
                            dtRow("PLFS_DETAIL") = rowx("PLFS_DETAIL")
                            dtRow("TotalSourceNo") = ADO.Load_PLFST_SALES_TOTAL_SOURCENO(PNL_KEY, Errorlog)
                            dtRow("RowIndex") = rowx("RowIndex")

                            If isPrint AndAlso clsNote IsNot Nothing Then
                                dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.SALES.ToString, True, rowx("PLFS_PLFSKEY"), -1, Errorlog)

                                If dtNote IsNot Nothing Then
                                    NoteOrder += 1

                                    dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                End If
                            End If
                            ds.Tables("PLFST_SALES").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_PLFST_SALES_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("PLFST_SALES_DETAIL").NewRow
                                dtRow("PLFSD_KEY") = rowx("PLFSD_KEY")
                                dtRow("PLFSD_PLFSKEY") = rowx("PLFSD_PLFSKEY")
                                dtRow("PLFSD_SOURCENO") = rowx("PLFSD_SOURCENO")
                                dtRow("PLFSD_PLFSDKEY") = ds.Tables("PLFST_SALES_DETAIL").Rows.Count + 1
                                dtRow("PLFSD_DESC") = rowx("PLFSD_DESC")
                                dtRow("PLFSD_AMOUNT") = rowx("PLFSD_AMOUNT")
                                dtRow("PLFSD_NOTE") = rowx("PLFSD_NOTE")
                                dtRow("RowIndex") = rowx("RowIndex")

                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.SALES.ToString, False, rowx("PLFSD_PLFSKEY"), rowx("PLFSD_PLFSDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("PLFST_SALES_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.OPENSTOCK
                    dt = Nothing
                    dt = ADO.Load_PNL_PLFST_OPENSTOCK(PNL_KEY, Errorlog)
                    ds.Tables("PLFST_OPENSTOCK_DETAIL").Rows.Clear()
                    ds.Tables("PLFST_OPENSTOCK").Rows.Clear()

                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("PLFST_OPENSTOCK").NewRow
                            dtRow("PLFOS_KEY") = rowx("PLFOS_KEY")
                            dtRow("PLFOS_PLFOSKEY") = rowx("PLFOS_PLFOSKEY")
                            dtRow("PLFOS_SOURCENO") = rowx("PLFOS_SOURCENO")
                            dtRow("PLFOS_DESC") = rowx("PLFOS_DESC")
                            dtRow("PLFOS_AMOUNT") = rowx("PLFOS_AMOUNT")
                            dtRow("PLFOS_NOTE") = rowx("PLFOS_NOTE")
                            dtRow("RowIndex") = rowx("RowIndex")

                            If isPrint AndAlso clsNote IsNot Nothing Then
                                dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.OPENSTOCK.ToString, True, rowx("PLFOS_PLFOSKEY"), -1, Errorlog)

                                If dtNote IsNot Nothing Then
                                    NoteOrder += 1

                                    dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                End If
                            End If

                            dtRow("TotalSourceNo") = ADO.Load_PNL_PLFST_OPENSTOCK_TOTAL_SOURCENO(PNL_KEY, Errorlog)
                            ds.Tables("PLFST_OPENSTOCK").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_PLFST_OPENSTOCK_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("PLFST_OPENSTOCK_DETAIL").NewRow
                                dtRow("PLFOSD_KEY") = rowx("PLFOSD_KEY")
                                dtRow("PLFOSD_PLFOSKEY") = rowx("PLFOSD_PLFOSKEY")
                                dtRow("PLFOSD_SOURCENO") = rowx("PLFOSD_SOURCENO")
                                dtRow("PLFOSD_PLFOSDKEY") = ds.Tables("PLFST_OPENSTOCK_DETAIL").Rows.Count + 1
                                dtRow("PLFOSD_DESC") = rowx("PLFOSD_DESC")
                                dtRow("PLFOSD_AMOUNT") = rowx("PLFOSD_AMOUNT")
                                dtRow("PLFOSD_NOTE") = rowx("PLFOSD_NOTE")
                                dtRow("RowIndex") = rowx("RowIndex")

                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.OPENSTOCK.ToString, False, rowx("PLFOSD_PLFOSKEY"), rowx("PLFOSD_PLFOSDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If

                                ds.Tables("PLFST_OPENSTOCK_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.PURCHASE
                    dt = Nothing
                    dt = ADO.Load_PNL_PLFST_PURCHASE(PNL_KEY, Errorlog)
                    ds.Tables("PLFST_PURCHASE_DETAIL").Rows.Clear()
                    ds.Tables("PLFST_PURCHASE").Rows.Clear()

                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "PLFST_PURCHASE", "PLFPUR_PLFPURKEY", rowx("PLFPUR_PLFPURKEY")) = False Then
                                dtRow = ds.Tables("PLFST_PURCHASE").NewRow
                                dtRow("PLFPUR_KEY") = rowx("PLFPUR_KEY")
                                dtRow("PLFPUR_PLFPURKEY") = rowx("PLFPUR_PLFPURKEY")
                                dtRow("PLFPUR_SOURCENO") = rowx("PLFPUR_SOURCENO")
                                dtRow("PLFPUR_DESC") = rowx("PLFPUR_DESC")
                                dtRow("PLFPUR_AMOUNT") = rowx("PLFPUR_AMOUNT")
                                dtRow("PLFPUR_NOTE") = rowx("PLFPUR_NOTE")
                                dtRow("PLFPUR_DETAIL") = rowx("PLFPUR_DETAIL")
                                If IsDBNull(rowx("PLFPUR_DEDUCTIBLE")) = False AndAlso (rowx("PLFPUR_DEDUCTIBLE") = "Yes" OrElse rowx("PLFPUR_DEDUCTIBLE") = "True") Then
                                    dtRow("PLFPUR_DEDUCTIBLE") = True
                                Else
                                    dtRow("PLFPUR_DEDUCTIBLE") = False
                                End If
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.PURCHASE.ToString, True, rowx("PLFPUR_PLFPURKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                dtRow("RowIndex") = rowx("RowIndex")
                                ds.Tables("PLFST_PURCHASE").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_PLFST_PURCHASE_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("PLFST_PURCHASE_DETAIL").NewRow
                                dtRow("PLFPURD_KEY") = rowx("PLFPURD_KEY")
                                dtRow("PLFPURD_PLFPURKEY") = rowx("PLFPURD_PLFPURKEY")
                                dtRow("PLFPURD_SOURCENO") = rowx("PLFPURD_SOURCENO")
                                dtRow("PLFPURD_PLFPURDKEY") = ds.Tables("PLFST_PURCHASE_DETAIL").Rows.Count + 1
                                dtRow("PLFPURD_DESC") = rowx("PLFPURD_DESC")
                                dtRow("PLFPURD_AMOUNT") = rowx("PLFPURD_AMOUNT")
                                dtRow("PLFPURD_NOTE") = rowx("PLFPURD_NOTE")
                                If IsDBNull(rowx("PLFPURD_DEDUCTIBLE")) = False AndAlso (rowx("PLFPURD_DEDUCTIBLE") = "Yes" OrElse rowx("PLFPURD_DEDUCTIBLE") = "True") Then
                                    dtRow("PLFPURD_DEDUCTIBLE") = True
                                Else
                                    dtRow("PLFPURD_DEDUCTIBLE") = False
                                End If
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.PURCHASE.ToString, False, rowx("PLFPURD_PLFPURKEY"), rowx("PLFPURD_PLFPURDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                dtRow("RowIndex") = rowx("RowIndex")
                                ds.Tables("PLFST_PURCHASE_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.DEPRECIATION
                    dt = Nothing
                    dt = ADO.Load_PNL_EXPENSES_DEPRECIATION(PNL_KEY, Errorlog)
                    ds.Tables("EXPENSES_DEPRECIATION_DETAIL").Rows.Clear()
                    ds.Tables("EXPENSES_DEPRECIATION").Rows.Clear()

                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "EXPENSES_DEPRECIATION", "EXDEP_EXDEPKEY", rowx("EXDEP_EXDEPKEY")) = False Then
                                dtRow = ds.Tables("EXPENSES_DEPRECIATION").NewRow
                                dtRow("EXDEP_KEY") = rowx("EXDEP_KEY")
                                dtRow("EXDEP_EXDEPKEY") = rowx("EXDEP_EXDEPKEY")
                                dtRow("EXDEP_SOURCENO") = rowx("EXDEP_SOURCENO")
                                dtRow("EXDEP_DESC") = rowx("EXDEP_DESC")
                                dtRow("EXDEP_AMOUNT") = rowx("EXDEP_AMOUNT")

                                If IsDBNull(rowx("EXDEP_DEDUCTIBLE")) = False AndAlso (rowx("EXDEP_DEDUCTIBLE") = "Yes" OrElse rowx("EXDEP_DEDUCTIBLE") = "True") Then
                                    dtRow("EXDEP_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXDEP_DEDUCTIBLE") = False
                                End If

                                dtRow("EXDEP_NOTE") = rowx("EXDEP_NOTE")
                                dtRow("EXDEP_DETAIL") = rowx("EXDEP_DETAIL")

                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.DEPRECIATION.ToString, True, rowx("EXDEP_EXDEPKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If

                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                ds.Tables("EXPENSES_DEPRECIATION").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_EXPENSES_DEPRECIATION_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing

                                dtRow = ds.Tables("EXPENSES_DEPRECIATION_DETAIL").NewRow
                                dtRow("EXDEPD_KEY") = rowx("EXDEPD_KEY")
                                dtRow("EXDEPD_EXDEPKEY") = rowx("EXDEPD_EXDEPKEY")
                                dtRow("EXDEPD_SOURCENO") = rowx("EXDEPD_SOURCENO")
                                dtRow("EXDEPD_EXDEPDKEY") = ds.Tables("EXPENSES_DEPRECIATION_DETAIL").Rows.Count + 1
                                dtRow("EXDEPD_DESC") = rowx("EXDEPD_DESC")
                                dtRow("EXDEPD_AMOUNT") = rowx("EXDEPD_AMOUNT")

                                If IsDBNull(rowx("EXDEPD_DEDUCTIBLE")) = False AndAlso (rowx("EXDEPD_DEDUCTIBLE") = "Yes" OrElse rowx("EXDEPD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXDEPD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXDEPD_DEDUCTIBLE") = False
                                End If

                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.DEPRECIATION.ToString, False, rowx("EXDEPD_EXDEPKEY"), rowx("EXDEPD_EXDEPDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                dtRow("EXDEPD_NOTE") = rowx("EXDEPD_NOTE")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                ds.Tables("EXPENSES_DEPRECIATION_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.OTHERALLOWEXP
                    dt = Nothing
                    dt = ADO.Load_PNL_EXPENSES_ALLOW(PNL_KEY, Errorlog)
                    ds.Tables("EXPENSES_ALLOW_DETAIL").Rows.Clear()
                    ds.Tables("EXPENSES_ALLOW").Rows.Clear()

                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "EXPENSES_ALLOW", "EXA_EXAKEY", rowx("EXA_EXAKEY")) = False Then
                                dtRow = ds.Tables("EXPENSES_ALLOW").NewRow
                                dtRow("EXA_KEY") = rowx("EXA_KEY")
                                dtRow("EXA_EXAKEY") = rowx("EXA_EXAKEY")
                                dtRow("EXA_SOURCENO") = rowx("EXA_SOURCENO")
                                dtRow("EXA_DESC") = rowx("EXA_DESC")
                                dtRow("EXA_AMOUNT") = rowx("EXA_AMOUNT")
                                If IsDBNull(rowx("EXA_DEDUCTIBLE")) = False AndAlso (rowx("EXA_DEDUCTIBLE") = "Yes" OrElse rowx("EXA_DEDUCTIBLE") = "True") Then
                                    dtRow("EXA_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXA_DEDUCTIBLE") = False
                                End If
                                If IsDBNull(rowx("EXA_DEDUCTIBLE")) = False AndAlso (rowx("EXA_DEDUCTIBLE") = "Yes" OrElse rowx("EXA_DEDUCTIBLE") = "True") Then
                                    dtRow("EXA_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXA_DEDUCTIBLE") = False
                                End If
                                dtRow("EXA_NOTE") = rowx("EXA_NOTE")
                                dtRow("EXA_DETAIL") = rowx("EXA_DETAIL")

                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.OTHERALLOWEXP.ToString, True, rowx("EXA_EXAKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If

                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                ds.Tables("EXPENSES_ALLOW").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_EXPENSES_ALLOW_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_ALLOW_DETAIL").NewRow
                                dtRow("EXAD_KEY") = rowx("EXAD_KEY")
                                dtRow("EXAD_EXAKEY") = rowx("EXAD_EXAKEY")
                                dtRow("EXAD_SOURCENO") = rowx("EXAD_SOURCENO")
                                dtRow("EXAD_EXADKEY") = ds.Tables("EXPENSES_ALLOW_DETAIL").Rows.Count + 1
                                dtRow("EXAD_DESC") = rowx("EXAD_DESC")
                                dtRow("EXAD_AMOUNT") = rowx("EXAD_AMOUNT")
                                If IsDBNull(rowx("EXAD_DEDUCTIBLE")) = False AndAlso (rowx("EXAD_DEDUCTIBLE") = "Yes" OrElse rowx("EXAD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXAD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXAD_DEDUCTIBLE") = False
                                End If
                                '  dtRow("EXAD_DEDUCTIBLE") = rowx("EXAD_DEDUCTIBLE")
                                dtRow("EXAD_NOTE") = rowx("EXAD_NOTE")

                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.OTHERALLOWEXP.ToString, False, rowx("EXAD_EXAKEY"), dtRow("EXAD_EXADKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If

                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                ds.Tables("EXPENSES_ALLOW_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.OTHERNONALLOWEXP
                    dt = Nothing
                    dt = ADO.Load_PNL_EXPENSES_NONALLOW(PNL_KEY, Errorlog)
                    ds.Tables("EXPENSES_NONALLOW_DETAIL").Rows.Clear()
                    ds.Tables("EXPENSES_NONALLOW").Rows.Clear()

                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "EXPENSES_NONALLOW", "EXNA_EXNAKEY", rowx("EXNA_EXNAKEY")) = False Then
                                dtRow = ds.Tables("EXPENSES_NONALLOW").NewRow
                                dtRow("EXNA_KEY") = rowx("EXNA_KEY")
                                dtRow("EXNA_EXNAKEY") = rowx("EXNA_EXNAKEY")
                                dtRow("EXNA_SOURCENO") = rowx("EXNA_SOURCENO")
                                dtRow("EXNA_DESC") = rowx("EXNA_DESC")
                                dtRow("EXNA_AMOUNT") = rowx("EXNA_AMOUNT")
                                If IsDBNull(rowx("EXNA_DEDUCTIBLE")) = False AndAlso (rowx("EXNA_DEDUCTIBLE") = "Yes" OrElse rowx("EXNA_DEDUCTIBLE") = "True") Then
                                    dtRow("EXNA_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXNA_DEDUCTIBLE") = False
                                End If
                                ' dtRow("EXNA_DEDUCTIBLE") = rowx("EXNA_DEDUCTIBLE")
                                dtRow("EXNA_NOTE") = rowx("EXNA_NOTE")
                                dtRow("EXNA_DETAIL") = rowx("EXNA_DETAIL")
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.OTHERNONALLOWEXP.ToString, True, rowx("EXNA_EXNAKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If

                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                ds.Tables("EXPENSES_NONALLOW").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_EXPENSES_NONALLOW_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_NONALLOW_DETAIL").NewRow
                                dtRow("EXNAD_KEY") = rowx("EXNAD_KEY")
                                dtRow("EXNAD_EXNAKEY") = rowx("EXNAD_EXNAKEY")
                                dtRow("EXNAD_SOURCENO") = rowx("EXNAD_SOURCENO")
                                dtRow("EXNAD_EXNADKEY") = ds.Tables("EXPENSES_NONALLOW_DETAIL").Rows.Count + 1
                                dtRow("EXNAD_DESC") = rowx("EXNAD_DESC")
                                If IsDBNull(rowx("EXNAD_DEDUCTIBLE")) = False AndAlso (rowx("EXNAD_DEDUCTIBLE") = "Yes" OrElse rowx("EXNAD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXNAD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXNAD_DEDUCTIBLE") = False
                                End If

                                'dtRow("EXNAD_DEDUCTIBLE") = rowx("EXNAD_DEDUCTIBLE")
                                dtRow("EXNAD_AMOUNT") = rowx("EXNAD_AMOUNT")
                                dtRow("EXNAD_NOTE") = rowx("EXNAD_NOTE")
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.OTHERNONALLOWEXP.ToString, False, rowx("EXNAD_EXNAKEY"), dtRow("EXNAD_EXNADKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If

                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                ds.Tables("EXPENSES_NONALLOW_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.CLOSESTOCK
                    dt = Nothing
                    dt = ADO.Load_PNL_PLFST_CLOSESTOCK(PNL_KEY, Errorlog)
                    ds.Tables("PLFST_CLOSESTOCK_DETAIL").Rows.Clear()
                    ds.Tables("PLFST_CLOSESTOCK").Rows.Clear()

                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            If isPrint AndAlso clsNote IsNot Nothing Then
                                dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.CLOSESTOCK.ToString, True, rowx("PLFCS_PLFCSKEY"), -1, Errorlog)

                                If dtNote IsNot Nothing Then
                                    NoteOrder += 1

                                    dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                End If
                            End If
                            ds.Tables("PLFST_CLOSESTOCK").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_PLFST_CLOSESTOCK_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.CLOSESTOCK.ToString, False, rowx("PLFCSD_PLFCSKEY"), rowx("PLFCSD_PLFCSDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("PLFST_CLOSESTOCK_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.OTHERBUSINC
                    dt = Nothing
                    dt = ADO.Load_PNL_NONSOURCE_BUSINESSINCOME(PNL_KEY, Errorlog)

                    ds.Tables("NONSOURCE_BUSINESSINCOME_DETAIL").Rows.Clear()
                    ds.Tables("NONSOURCE_BUSINESSINCOME").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        'For Each rowx As DataRow In dt.Rows
                        '    If isPrint AndAlso clsNote IsNot Nothing Then
                        '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.OTHERBUSINC.ToString, True, rowx("NSBI_NSBIKEY"), -1, Errorlog)

                        '        If dtNote IsNot Nothing Then
                        '            NoteOrder += 1

                        '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                        '        End If
                        '    End If
                        '    ds.Tables("NONSOURCE_BUSINESSINCOME").ImportRow(rowx)
                        'Next

                        For Each rowx As DataRow In dt.Rows
                            dtRow = ds.Tables("NONSOURCE_BUSINESSINCOME").NewRow
                            For Each clm_DB As DataColumn In dt.Columns
                                For Each clm_DS As DataColumn In ds.Tables("NONSOURCE_BUSINESSINCOME").Columns

                                    If clm_DB.ColumnName = clm_DS.ColumnName Then
                                        dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                    End If

                                Next
                            Next
                            If isPrint AndAlso clsNote IsNot Nothing Then
                                dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.OTHERBUSINC.ToString, True, rowx("NSBI_NSBIKEY"), -1, Errorlog)

                                If dtNote IsNot Nothing Then
                                    NoteOrder += 1

                                    dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                End If
                            End If
                            ds.Tables("NONSOURCE_BUSINESSINCOME").Rows.Add(dtRow)
                        Next
                       
                        dt = Nothing

                        dt = ADO.Load_PNL_NONSOURCE_BUSINESSINCOME_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            'For Each rowx As DataRow In dt.Rows
                            '    If isPrint AndAlso clsNote IsNot Nothing Then
                            '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.OTHERALLOWEXP.ToString, False, rowx("NSBID_NSBIKEY"), rowx("NSBID_NSBIDKEY"), Errorlog)

                            '        If dtNote IsNot Nothing Then
                            '            NoteOrder += 1

                            '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                            '        End If
                            '    End If
                            '    ds.Tables("NONSOURCE_BUSINESSINCOME_DETAIL").ImportRow(rowx)
                            'Next


                            For Each rowx As DataRow In dt.Rows
                                dtRow = ds.Tables("NONSOURCE_BUSINESSINCOME_DETAIL").NewRow
                                For Each clm_DB As DataColumn In dt.Columns
                                    For Each clm_DS As DataColumn In ds.Tables("NONSOURCE_BUSINESSINCOME_DETAIL").Columns

                                        If clm_DB.ColumnName = clm_DS.ColumnName Then
                                            dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                        End If

                                    Next
                                Next
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.OTHERALLOWEXP.ToString, False, rowx("NSBID_NSBIKEY"), rowx("NSBID_NSBIDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("NONSOURCE_BUSINESSINCOME_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.REALFETRADE
                    dt = Nothing
                    dt = ADO.Load_PNL_INCOME_REALFET(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_REALFET_DETAIL").Rows.Clear()
                    ds.Tables("INCOME_REALFET").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        'For Each rowx As DataRow In dt.Rows
                        '    If isPrint AndAlso clsNote IsNot Nothing Then
                        '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.REALFETRADE.ToString, True, rowx("IRFET_IRFETKEY"), -1, Errorlog)

                        '        If dtNote IsNot Nothing Then
                        '            NoteOrder += 1

                        '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                        '        End If
                        '    End If
                        '    ds.Tables("INCOME_REALFET").ImportRow(rowx)
                        'Next

                        For Each rowx As DataRow In dt.Rows
                            dtRow = ds.Tables("INCOME_REALFET").NewRow
                            For Each clm_DB As DataColumn In dt.Columns
                                For Each clm_DS As DataColumn In ds.Tables("INCOME_REALFET").Columns

                                    If clm_DB.ColumnName = clm_DS.ColumnName Then
                                        dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                    End If

                                Next
                            Next
                            If isPrint AndAlso clsNote IsNot Nothing Then
                                dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.REALFETRADE.ToString, True, rowx("IRFET_IRFETKEY"), -1, Errorlog)

                                If dtNote IsNot Nothing Then
                                    NoteOrder += 1

                                    dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                End If
                            End If
                            ds.Tables("INCOME_REALFET").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_INCOME_REALFET_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            'For Each rowx As DataRow In dt.Rows
                            '    If isPrint AndAlso clsNote IsNot Nothing Then
                            '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.REALFETRADE.ToString, False, rowx("IRFETD_IRFETKEY"), rowx("IRFETD_IRFETDKEY"), Errorlog)

                            '        If dtNote IsNot Nothing Then
                            '            NoteOrder += 1

                            '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                            '        End If
                            '    End If
                            '    ds.Tables("INCOME_REALFET_DETAIL").ImportRow(rowx)
                            'Next
                            For Each rowx As DataRow In dt.Rows
                                dtRow = ds.Tables("INCOME_REALFET_DETAIL").NewRow
                                For Each clm_DB As DataColumn In dt.Columns
                                    For Each clm_DS As DataColumn In ds.Tables("INCOME_REALFET_DETAIL").Columns

                                        If clm_DB.ColumnName = clm_DS.ColumnName Then
                                            dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                        End If

                                    Next
                                Next
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.REALFETRADE.ToString, False, rowx("IRFETD_IRFETKEY"), rowx("IRFETD_IRFETDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("INCOME_REALFET_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.DIVIDENDINC
                    dt = Nothing
                    dt = ADO.Load_PNL_dividend_income(PNL_KEY, Errorlog)

                    ds.Tables("dividend_income").Rows.Clear()

                    If dt IsNot Nothing Then
                        isHaveData = True
                        'For Each rowx As DataRow In dt.Rows
                        '    If isPrint AndAlso clsNote IsNot Nothing Then
                        '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.DIVIDENDINC.ToString, True, rowx("DI_DIVIDENDKEY"), -1, Errorlog)

                        '        If dtNote IsNot Nothing Then
                        '            NoteOrder += 1

                        '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                        '        End If
                        '    End If
                        '    ds.Tables("dividend_income").ImportRow(rowx)
                        'Next
                        For Each rowx As DataRow In dt.Rows
                            dtRow = ds.Tables("dividend_income").NewRow
                            For Each clm_DB As DataColumn In dt.Columns
                                For Each clm_DS As DataColumn In ds.Tables("dividend_income").Columns

                                    If clm_DB.ColumnName = clm_DS.ColumnName Then
                                        dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                    End If

                                Next
                            Next
                            If isPrint AndAlso clsNote IsNot Nothing Then
                                dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.DIVIDENDINC.ToString, True, rowx("DI_DIVIDENDKEY"), -1, Errorlog)

                                If dtNote IsNot Nothing Then
                                    NoteOrder += 1

                                    dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                End If
                            End If
                            ds.Tables("dividend_income").Rows.Add(dtRow)
                        Next
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.INTERESTINC
                    dt = Nothing
                    dt = ADO.Load_PNL_INCOME_NBINTEREST(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_NBINTEREST_DETAIL").Rows.Clear()
                    ds.Tables("INCOME_NBINTEREST").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        'For Each rowx As DataRow In dt.Rows
                        '    If isPrint AndAlso clsNote IsNot Nothing Then
                        '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.INTERESTINC.ToString, True, rowx("NOBII_NOBIIKEY"), -1, Errorlog)

                        '        If dtNote IsNot Nothing Then
                        '            NoteOrder += 1

                        '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                        '        End If
                        '    End If
                        '    ds.Tables("INCOME_NBINTEREST").ImportRow(rowx)
                        'Next
                        For Each rowx As DataRow In dt.Rows
                            dtRow = ds.Tables("INCOME_NBINTEREST").NewRow
                            For Each clm_DB As DataColumn In dt.Columns
                                For Each clm_DS As DataColumn In ds.Tables("INCOME_NBINTEREST").Columns

                                    If clm_DB.ColumnName = clm_DS.ColumnName Then
                                        dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                    End If

                                Next
                            Next
                            If isPrint AndAlso clsNote IsNot Nothing Then
                                dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.INTERESTINC.ToString, True, rowx("NOBII_NOBIIKEY"), -1, Errorlog)

                                If dtNote IsNot Nothing Then
                                    NoteOrder += 1

                                    dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                End If
                            End If
                            ds.Tables("INCOME_NBINTEREST").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_INCOME_NBINTEREST_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            'For Each rowx As DataRow In dt.Rows
                            '    If isPrint AndAlso clsNote IsNot Nothing Then
                            '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.INTERESTINC.ToString, False, rowx("NOBIID_NOBIIKEY"), rowx("NOBIID_NOBIIDKEY"), Errorlog)

                            '        If dtNote IsNot Nothing Then
                            '            NoteOrder += 1

                            '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                            '        End If
                            '    End If
                            '    ds.Tables("INCOME_NBINTEREST_DETAIL").ImportRow(rowx)
                            'Next
                            For Each rowx As DataRow In dt.Rows
                                dtRow = ds.Tables("INCOME_NBINTEREST_DETAIL").NewRow
                                For Each clm_DB As DataColumn In dt.Columns
                                    For Each clm_DS As DataColumn In ds.Tables("INCOME_NBINTEREST_DETAIL").Columns

                                        If clm_DB.ColumnName = clm_DS.ColumnName Then
                                            dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                        End If

                                    Next
                                Next
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.INTERESTINC.ToString, False, rowx("NOBIID_NOBIIKEY"), rowx("NOBIID_NOBIIDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("INCOME_NBINTEREST_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.RENTALINC
                    dt = Nothing
                    dt = ADO.Load_PNL_rental_income(PNL_KEY, Errorlog)

                    ds.Tables("rental_income").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        'For Each rowx As DataRow In dt.Rows
                        '    If isPrint AndAlso clsNote IsNot Nothing Then
                        '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.RENTALINC.ToString, True, rowx("RI_RENTKEY"), -1, Errorlog)

                        '        If dtNote IsNot Nothing Then
                        '            NoteOrder += 1

                        '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                        '        End If
                        '    End If
                        '    ds.Tables("rental_income").ImportRow(rowx)
                        'Next
                        For Each rowx As DataRow In dt.Rows
                            dtRow = ds.Tables("rental_income").NewRow
                            For Each clm_DB As DataColumn In dt.Columns
                                For Each clm_DS As DataColumn In ds.Tables("rental_income").Columns

                                    If clm_DB.ColumnName = clm_DS.ColumnName Then
                                        dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                    End If

                                Next
                            Next
                            If isPrint AndAlso clsNote IsNot Nothing Then
                                dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.RENTALINC.ToString, True, rowx("RI_RENTKEY"), -1, Errorlog)

                                If dtNote IsNot Nothing Then
                                    NoteOrder += 1

                                    dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                End If
                            End If
                            ds.Tables("rental_income").Rows.Add(dtRow)
                        Next
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.ROYALTYINC
                    dt = Nothing
                    dt = ADO.Load_PNL_INCOME_NBROYALTY(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_NBROYALTY_DETAIL").Rows.Clear()
                    ds.Tables("INCOME_NBROYALTY").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        'For Each rowx As DataRow In dt.Rows
                        '    If isPrint AndAlso clsNote IsNot Nothing Then
                        '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.ROYALTYINC.ToString, True, rowx("NOBRI_NOBRIKEY"), -1, Errorlog)

                        '        If dtNote IsNot Nothing Then
                        '            NoteOrder += 1

                        '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                        '        End If
                        '    End If
                        '    ds.Tables("INCOME_NBROYALTY").ImportRow(rowx)
                        'Next
                        For Each rowx As DataRow In dt.Rows
                            dtRow = ds.Tables("INCOME_NBROYALTY").NewRow
                            For Each clm_DB As DataColumn In dt.Columns
                                For Each clm_DS As DataColumn In ds.Tables("INCOME_NBROYALTY").Columns

                                    If clm_DB.ColumnName = clm_DS.ColumnName Then
                                        dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                    End If

                                Next
                            Next
                            If isPrint AndAlso clsNote IsNot Nothing Then
                                dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.ROYALTYINC.ToString, True, rowx("NOBRI_NOBRIKEY"), -1, Errorlog)

                                If dtNote IsNot Nothing Then
                                    NoteOrder += 1

                                    dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                End If
                            End If
                            ds.Tables("INCOME_NBROYALTY").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_INCOME_NBROYALTY_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            'For Each rowx As DataRow In dt.Rows
                            '    If isPrint AndAlso clsNote IsNot Nothing Then
                            '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.ROYALTYINC.ToString, False, rowx("NOBRID_NOBRIKEY"), rowx("NOBRID_NOBRIDKEY"), Errorlog)

                            '        If dtNote IsNot Nothing Then
                            '            NoteOrder += 1

                            '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                            '        End If
                            '    End If
                            '    ds.Tables("INCOME_NBROYALTY_DETAIL").ImportRow(rowx)
                            'Next
                            For Each rowx As DataRow In dt.Rows
                                dtRow = ds.Tables("INCOME_NBROYALTY_DETAIL").NewRow
                                For Each clm_DB As DataColumn In dt.Columns
                                    For Each clm_DS As DataColumn In ds.Tables("INCOME_NBROYALTY_DETAIL").Columns

                                        If clm_DB.ColumnName = clm_DS.ColumnName Then
                                            dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                        End If

                                    Next
                                Next
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.ROYALTYINC.ToString, False, rowx("NOBRID_NOBRIKEY"), rowx("NOBRID_NOBRIDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("INCOME_NBROYALTY_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.OTHERINC
                    dt = Nothing
                    dt = ADO.Load_PNL_OTHER_INCOME(PNL_KEY, Errorlog)

                    ds.Tables("OTHER_INCOME_DETAIL").Rows.Clear()
                    ds.Tables("OTHER_INCOME").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        'For Each rowx As DataRow In dt.Rows
                        '    If isPrint AndAlso clsNote IsNot Nothing Then
                        '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.OTHERINC.ToString, True, rowx("OI_OIKEY"), -1, Errorlog)

                        '        If dtNote IsNot Nothing Then
                        '            NoteOrder += 1

                        '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                        '        End If
                        '    End If
                        '    ds.Tables("OTHER_INCOME").ImportRow(rowx)
                        'Next
                        For Each rowx As DataRow In dt.Rows
                            dtRow = ds.Tables("OTHER_INCOME").NewRow
                            For Each clm_DB As DataColumn In dt.Columns
                                For Each clm_DS As DataColumn In ds.Tables("OTHER_INCOME").Columns

                                    If clm_DB.ColumnName = clm_DS.ColumnName Then
                                        dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                    End If

                                Next
                            Next
                            If isPrint AndAlso clsNote IsNot Nothing Then
                                dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.OTHERINC.ToString, True, rowx("OI_OIKEY"), -1, Errorlog)

                                If dtNote IsNot Nothing Then
                                    NoteOrder += 1

                                    dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                End If
                            End If
                            ds.Tables("OTHER_INCOME").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_OTHER_INCOME_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            'For Each rowx As DataRow In dt.Rows
                            '    If isPrint AndAlso clsNote IsNot Nothing Then
                            '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.OTHERINC.ToString, False, rowx("OID_OIKEY"), rowx("OID_OIDKEY"), Errorlog)

                            '        If dtNote IsNot Nothing Then
                            '            NoteOrder += 1

                            '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                            '        End If
                            '    End If
                            '    ds.Tables("OTHER_INCOME_DETAIL").ImportRow(rowx)
                            'Next
                            For Each rowx As DataRow In dt.Rows
                                dtRow = ds.Tables("OTHER_INCOME_DETAIL").NewRow
                                For Each clm_DB As DataColumn In dt.Columns
                                    For Each clm_DS As DataColumn In ds.Tables("OTHER_INCOME_DETAIL").Columns

                                        If clm_DB.ColumnName = clm_DS.ColumnName Then
                                            dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                        End If

                                    Next
                                Next
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.OTHERINC.ToString, False, rowx("OID_OIKEY"), rowx("OID_OIDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("OTHER_INCOME_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.PDFIXASSET
                    dt = Nothing
                    dt = ADO.Load_PNL_INCOME_NTDISPOSALFA(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_NTDISPOSALFA_DETAIL").Rows.Clear()
                    ds.Tables("INCOME_NTDISPOSALFA").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        'For Each rowx As DataRow In dt.Rows
                        '    If isPrint AndAlso clsNote IsNot Nothing Then
                        '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.PDFIXASSET.ToString, True, rowx("NTIDFA_NTIDFAKEY"), -1, Errorlog)

                        '        If dtNote IsNot Nothing Then
                        '            NoteOrder += 1

                        '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                        '        End If
                        '    End If
                        '    ds.Tables("INCOME_NTDISPOSALFA").ImportRow(rowx)
                        'Next
                        For Each rowx As DataRow In dt.Rows
                            dtRow = ds.Tables("INCOME_NTDISPOSALFA").NewRow
                            For Each clm_DB As DataColumn In dt.Columns
                                For Each clm_DS As DataColumn In ds.Tables("INCOME_NTDISPOSALFA").Columns

                                    If clm_DB.ColumnName = clm_DS.ColumnName Then
                                        dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                    End If

                                Next
                            Next
                            If isPrint AndAlso clsNote IsNot Nothing Then
                                dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.PDFIXASSET.ToString, True, rowx("NTIDFA_NTIDFAKEY"), -1, Errorlog)

                                If dtNote IsNot Nothing Then
                                    NoteOrder += 1

                                    dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                End If
                            End If
                            ds.Tables("INCOME_NTDISPOSALFA").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_INCOME_NTDISPOSALFA_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            'For Each rowx As DataRow In dt.Rows
                            '    If isPrint AndAlso clsNote IsNot Nothing Then
                            '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.PDFIXASSET.ToString, False, rowx("NTIDFAD_NTIDFAKEY"), rowx("NTIDFAD_NTIDFADKEY"), Errorlog)

                            '        If dtNote IsNot Nothing Then
                            '            NoteOrder += 1

                            '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                            '        End If
                            '    End If
                            '    ds.Tables("INCOME_NTDISPOSALFA_DETAIL").ImportRow(rowx)
                            'Next
                            For Each rowx As DataRow In dt.Rows
                                dtRow = ds.Tables("INCOME_NTDISPOSALFA_DETAIL").NewRow
                                For Each clm_DB As DataColumn In dt.Columns
                                    For Each clm_DS As DataColumn In ds.Tables("INCOME_NTDISPOSALFA_DETAIL").Columns

                                        If clm_DB.ColumnName = clm_DS.ColumnName Then
                                            dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                        End If

                                    Next
                                Next
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.PDFIXASSET.ToString, False, rowx("NTIDFAD_NTIDFAKEY"), rowx("NTIDFAD_NTIDFADKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("INCOME_NTDISPOSALFA_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.PDINVEST
                    dt = Nothing
                    dt = ADO.Load_PNL_INCOME_NTDISPOSALINVEST(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_NTDISPOSALINVEST_DETAIL").Rows.Clear()
                    ds.Tables("INCOME_NTDISPOSALINVEST").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        'For Each rowx As DataRow In dt.Rows
                        '    If isPrint AndAlso clsNote IsNot Nothing Then
                        '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.PDINVEST.ToString, True, rowx("NTIDI_NTIDIKEY"), -1, Errorlog)

                        '        If dtNote IsNot Nothing Then
                        '            NoteOrder += 1

                        '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                        '        End If
                        '    End If
                        '    ds.Tables("INCOME_NTDISPOSALINVEST").ImportRow(rowx)
                        'Next
                        For Each rowx As DataRow In dt.Rows
                            dtRow = ds.Tables("INCOME_NTDISPOSALINVEST").NewRow
                            For Each clm_DB As DataColumn In dt.Columns
                                For Each clm_DS As DataColumn In ds.Tables("INCOME_NTDISPOSALINVEST").Columns

                                    If clm_DB.ColumnName = clm_DS.ColumnName Then
                                        dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                    End If

                                Next
                            Next
                            If isPrint AndAlso clsNote IsNot Nothing Then
                                dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.PDINVEST.ToString, True, rowx("NTIDI_NTIDIKEY"), -1, Errorlog)

                                If dtNote IsNot Nothing Then
                                    NoteOrder += 1

                                    dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                End If
                            End If
                            ds.Tables("INCOME_NTDISPOSALINVEST").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_INCOME_NTDISPOSALINVEST_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            'For Each rowx As DataRow In dt.Rows
                            '    If isPrint AndAlso clsNote IsNot Nothing Then
                            '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.PDINVEST.ToString, False, rowx("NTIDID_NTIDIKEY"), rowx("NTIDID_NTIDIDKEY"), Errorlog)

                            '        If dtNote IsNot Nothing Then
                            '            NoteOrder += 1

                            '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                            '        End If
                            '    End If
                            '    ds.Tables("INCOME_NTDISPOSALINVEST_DETAIL").ImportRow(rowx)
                            'Next
                            For Each rowx As DataRow In dt.Rows
                                dtRow = ds.Tables("INCOME_NTDISPOSALINVEST_DETAIL").NewRow
                                For Each clm_DB As DataColumn In dt.Columns
                                    For Each clm_DS As DataColumn In ds.Tables("INCOME_NTDISPOSALINVEST_DETAIL").Columns

                                        If clm_DB.ColumnName = clm_DS.ColumnName Then
                                            dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                        End If

                                    Next
                                Next
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.PDINVEST.ToString, False, rowx("NTIDID_NTIDIKEY"), rowx("NTIDID_NTIDIDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("INCOME_NTDISPOSALINVEST_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXEMDIV
                    dt = Nothing
                    dt = ADO.Load_PNL_exempt_dividend(PNL_KEY, Errorlog)

                    ds.Tables("exempt_dividend").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        'For Each rowx As DataRow In dt.Rows
                        '    If isPrint AndAlso clsNote IsNot Nothing Then
                        '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXEMDIV.ToString, True, rowx("ED_EDKEY"), -1, Errorlog)

                        '        If dtNote IsNot Nothing Then
                        '            NoteOrder += 1

                        '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                        '        End If
                        '    End If
                        '    ds.Tables("exempt_dividend").ImportRow(rowx)
                        'Next
                        For Each rowx As DataRow In dt.Rows
                            dtRow = ds.Tables("exempt_dividend").NewRow
                            For Each clm_DB As DataColumn In dt.Columns
                                For Each clm_DS As DataColumn In ds.Tables("exempt_dividend").Columns

                                    If clm_DB.ColumnName = clm_DS.ColumnName Then
                                        dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                    End If

                                Next
                            Next
                            If isPrint AndAlso clsNote IsNot Nothing Then
                                dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXEMDIV.ToString, True, rowx("ED_EDKEY"), -1, Errorlog)

                                If dtNote IsNot Nothing Then
                                    NoteOrder += 1

                                    dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                End If
                            End If
                            ds.Tables("exempt_dividend").Rows.Add(dtRow)
                        Next
                    End If
                Case TaxComPNLEnuItem.FORINCREMIT
                    dt = Nothing
                    dt = ADO.Load_PNL_INCOME_NTFOREIGNINCREM(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_NTFOREIGNINCREM_DETAIL").Rows.Clear()
                    ds.Tables("INCOME_NTFOREIGNINCREM").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        'For Each rowx As DataRow In dt.Rows
                        '    If isPrint AndAlso clsNote IsNot Nothing Then
                        '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.FORINCREMIT.ToString, True, rowx("NTIFIR_NTIFIRKEY"), -1, Errorlog)

                        '        If dtNote IsNot Nothing Then
                        '            NoteOrder += 1

                        '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                        '        End If
                        '    End If
                        '    ds.Tables("INCOME_NTFOREIGNINCREM").ImportRow(rowx)
                        'Next
                        For Each rowx As DataRow In dt.Rows
                            dtRow = ds.Tables("INCOME_NTFOREIGNINCREM").NewRow
                            For Each clm_DB As DataColumn In dt.Columns
                                For Each clm_DS As DataColumn In ds.Tables("INCOME_NTFOREIGNINCREM").Columns

                                    If clm_DB.ColumnName = clm_DS.ColumnName Then
                                        dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                    End If

                                Next
                            Next
                            If isPrint AndAlso clsNote IsNot Nothing Then
                                dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.FORINCREMIT.ToString, True, rowx("NTIFIR_NTIFIRKEY"), -1, Errorlog)

                                If dtNote IsNot Nothing Then
                                    NoteOrder += 1

                                    dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                End If
                            End If
                            ds.Tables("INCOME_NTFOREIGNINCREM").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_INCOME_NTFOREIGNINCREM_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            'For Each rowx As DataRow In dt.Rows
                            '    If isPrint AndAlso clsNote IsNot Nothing Then
                            '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.FORINCREMIT.ToString, False, rowx("NTIFIRD_NTIFIRKEY"), rowx("NTIFIRD_NTIFIRDKEY"), Errorlog)

                            '        If dtNote IsNot Nothing Then
                            '            NoteOrder += 1

                            '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                            '        End If
                            '    End If

                            '    ds.Tables("INCOME_NTFOREIGNINCREM_DETAIL").ImportRow(rowx)
                            'Next
                            For Each rowx As DataRow In dt.Rows
                                dtRow = ds.Tables("INCOME_NTFOREIGNINCREM_DETAIL").NewRow
                                For Each clm_DB As DataColumn In dt.Columns
                                    For Each clm_DS As DataColumn In ds.Tables("INCOME_NTFOREIGNINCREM_DETAIL").Columns

                                        If clm_DB.ColumnName = clm_DS.ColumnName Then
                                            dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                        End If

                                    Next
                                Next
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.FORINCREMIT.ToString, False, rowx("NTIFIRD_NTIFIRKEY"), rowx("NTIFIRD_NTIFIRDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("INCOME_NTFOREIGNINCREM_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.REALFE
                    dt = Nothing
                    dt = ADO.Load_PNL_INCOME_NTUREALFET(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_NTUREALFET_DETAIL").Rows.Clear()
                    ds.Tables("INCOME_NTUREALFET").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        'For Each rowx As DataRow In dt.Rows
                        '    If isPrint AndAlso clsNote IsNot Nothing Then
                        '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.REALFE.ToString, True, rowx("NTIUT_NTIUTKEY"), -1, Errorlog)

                        '        If dtNote IsNot Nothing Then
                        '            NoteOrder += 1

                        '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                        '        End If
                        '    End If
                        '    ds.Tables("INCOME_NTUREALFET").ImportRow(rowx)
                        'Next
                        For Each rowx As DataRow In dt.Rows
                            dtRow = ds.Tables("INCOME_NTUREALFET").NewRow
                            For Each clm_DB As DataColumn In dt.Columns
                                For Each clm_DS As DataColumn In ds.Tables("INCOME_NTUREALFET").Columns

                                    If clm_DB.ColumnName = clm_DS.ColumnName Then
                                        dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                    End If

                                Next
                            Next
                            If isPrint AndAlso clsNote IsNot Nothing Then
                                dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.REALFE.ToString, True, rowx("NTIUT_NTIUTKEY"), -1, Errorlog)

                                If dtNote IsNot Nothing Then
                                    NoteOrder += 1

                                    dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                End If
                            End If
                            ds.Tables("INCOME_NTUREALFET").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_INCOME_NTUREALFET_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            'For Each rowx As DataRow In dt.Rows
                            '    If isPrint AndAlso clsNote IsNot Nothing Then
                            '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.REALFE.ToString, False, rowx("NTIUTD_NTIUTKEY"), rowx("NTIRFECTD_NTIRFECTDKEY"), Errorlog)

                            '        If dtNote IsNot Nothing Then
                            '            NoteOrder += 1

                            '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                            '        End If
                            '    End If

                            '    ds.Tables("INCOME_NTUREALFET_DETAIL").ImportRow(rowx)
                            'Next
                            For Each rowx As DataRow In dt.Rows
                                dtRow = ds.Tables("INCOME_NTUREALFET_DETAIL").NewRow
                                For Each clm_DB As DataColumn In dt.Columns
                                    For Each clm_DS As DataColumn In ds.Tables("INCOME_NTUREALFET_DETAIL").Columns

                                        If clm_DB.ColumnName = clm_DS.ColumnName Then
                                            dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                        End If

                                    Next
                                Next
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.REALFE.ToString, False, rowx("NTIUTD_NTIUTKEY"), rowx("NTIRFECTD_NTIRFECTDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("INCOME_NTUREALFET_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.UNREALFENONTRADE
                    dt = Nothing
                    dt = ADO.Load_PNL_INCOME_NTREALFE(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_NTREALFE_DETAIL").Rows.Clear()
                    ds.Tables("INCOME_NTREALFE").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        'For Each rowx As DataRow In dt.Rows
                        '    If isPrint AndAlso clsNote IsNot Nothing Then
                        '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.UNREALFENONTRADE.ToString, True, rowx("NTIRFECT_NTIRFECTKEY"), -1, Errorlog)

                        '        If dtNote IsNot Nothing Then
                        '            NoteOrder += 1

                        '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                        '        End If
                        '    End If
                        '    ds.Tables("INCOME_NTREALFE").ImportRow(rowx)
                        'Next
                        For Each rowx As DataRow In dt.Rows
                            dtRow = ds.Tables("INCOME_NTREALFE").NewRow
                            For Each clm_DB As DataColumn In dt.Columns
                                For Each clm_DS As DataColumn In ds.Tables("INCOME_NTREALFE").Columns

                                    If clm_DB.ColumnName = clm_DS.ColumnName Then
                                        dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                    End If

                                Next
                            Next
                            If isPrint AndAlso clsNote IsNot Nothing Then
                                dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.UNREALFENONTRADE.ToString, True, rowx("NTIRFECT_NTIRFECTKEY"), -1, Errorlog)

                                If dtNote IsNot Nothing Then
                                    NoteOrder += 1

                                    dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                End If
                            End If
                            ds.Tables("INCOME_NTREALFE").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_INCOME_NTREALFE_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            'For Each rowx As DataRow In dt.Rows
                            '    If isPrint AndAlso clsNote IsNot Nothing Then
                            '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.UNREALFENONTRADE.ToString, False, rowx("NTIRFECTD_NTIRFECTKEY"), rowx("NTIRFECTD_NTIRFECTDKEY"), Errorlog)

                            '        If dtNote IsNot Nothing Then
                            '            NoteOrder += 1

                            '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                            '        End If
                            '    End If
                            '    ds.Tables("INCOME_NTREALFE_DETAIL").ImportRow(rowx)
                            'Next
                            For Each rowx As DataRow In dt.Rows
                                dtRow = ds.Tables("INCOME_NTREALFE_DETAIL").NewRow
                                For Each clm_DB As DataColumn In dt.Columns
                                    For Each clm_DS As DataColumn In ds.Tables("INCOME_NTREALFE_DETAIL").Columns

                                        If clm_DB.ColumnName = clm_DS.ColumnName Then
                                            dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                        End If

                                    Next
                                Next
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.UNREALFENONTRADE.ToString, False, rowx("NTIRFECTD_NTIRFECTKEY"), rowx("NTIRFECTD_NTIRFECTDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("INCOME_NTREALFE_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.UNREALFETRADE
                    dt = Nothing
                    dt = ADO.Load_PNL_INCOME_NTUREALFENT(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_NTUREALFENT_DETAIL").Rows.Clear()
                    ds.Tables("INCOME_NTUREALFENT").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        'For Each rowx As DataRow In dt.Rows
                        '    If isPrint AndAlso clsNote IsNot Nothing Then
                        '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.UNREALFETRADE.ToString, True, rowx("NTIUNT_NTIUNTKEY"), -1, Errorlog)

                        '        If dtNote IsNot Nothing Then
                        '            NoteOrder += 1

                        '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                        '        End If
                        '    End If
                        '    ds.Tables("INCOME_NTUREALFENT").ImportRow(rowx)
                        'Next
                        For Each rowx As DataRow In dt.Rows
                            dtRow = ds.Tables("INCOME_NTUREALFENT").NewRow
                            For Each clm_DB As DataColumn In dt.Columns
                                For Each clm_DS As DataColumn In ds.Tables("INCOME_NTUREALFENT").Columns

                                    If clm_DB.ColumnName = clm_DS.ColumnName Then
                                        dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                    End If

                                Next
                            Next
                            If isPrint AndAlso clsNote IsNot Nothing Then
                                dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.UNREALFETRADE.ToString, True, rowx("NTIUNT_NTIUNTKEY"), -1, Errorlog)

                                If dtNote IsNot Nothing Then
                                    NoteOrder += 1

                                    dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                End If
                            End If
                            ds.Tables("INCOME_NTUREALFENT").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_INCOME_NTUREALFENT_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            'For Each rowx As DataRow In dt.Rows
                            '    If isPrint AndAlso clsNote IsNot Nothing Then
                            '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.UNREALFETRADE.ToString, False, rowx("NTIUNTD_NTIUNTKEY"), rowx("NTIUNTD_NTIUNTDKEY"), Errorlog)

                            '        If dtNote IsNot Nothing Then
                            '            NoteOrder += 1

                            '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                            '        End If
                            '    End If
                            '    ds.Tables("INCOME_NTUREALFENT_DETAIL").ImportRow(rowx)
                            'Next
                            For Each rowx As DataRow In dt.Rows
                                dtRow = ds.Tables("INCOME_NTUREALFENT_DETAIL").NewRow
                                For Each clm_DB As DataColumn In dt.Columns
                                    For Each clm_DS As DataColumn In ds.Tables("INCOME_NTUREALFENT_DETAIL").Columns

                                        If clm_DB.ColumnName = clm_DS.ColumnName Then
                                            dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                        End If

                                    Next
                                Next
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.UNREALFETRADE.ToString, False, rowx("NTIUNTD_NTIUNTKEY"), rowx("NTIUNTD_NTIUNTDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("INCOME_NTUREALFENT_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.OTHERNONTAXINC
                    dt = Nothing
                    dt = ADO.Load_PNL_non_taxable_income(RefNo, YA, Errorlog)

                    ds.Tables("NON_TAXABLE_INCOME_DETAIL").Rows.Clear()
                    ds.Tables("non_taxable_income").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        'For Each rowx As DataRow In dt.Rows
                        '    If isPrint AndAlso clsNote IsNot Nothing Then
                        '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.OTHERNONTAXINC.ToString, True, rowx("NT_KEY"), -1, Errorlog)

                        '        If dtNote IsNot Nothing Then
                        '            NoteOrder += 1

                        '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                        '        End If
                        '    End If
                        '    ds.Tables("non_taxable_income").ImportRow(rowx)
                        'Next
                        For Each rowx As DataRow In dt.Rows
                            dtRow = ds.Tables("non_taxable_income").NewRow
                            For Each clm_DB As DataColumn In dt.Columns
                                For Each clm_DS As DataColumn In ds.Tables("non_taxable_income").Columns

                                    If clm_DB.ColumnName = clm_DS.ColumnName Then
                                        dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                    End If

                                Next
                            Next
                            If isPrint AndAlso clsNote IsNot Nothing Then
                                dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.OTHERNONTAXINC.ToString, True, rowx("NT_KEY"), -1, Errorlog)

                                If dtNote IsNot Nothing Then
                                    NoteOrder += 1

                                    dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                End If
                            End If
                            ds.Tables("non_taxable_income").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_NON_TAXABLE_INCOME_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            'For Each rowx As DataRow In dt.Rows
                            '    If isPrint AndAlso clsNote IsNot Nothing Then
                            '        dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.OTHERNONTAXINC.ToString, False, rowx("NTD_NTKEY"), rowx("NTD_NTDKEY"), Errorlog)

                            '        If dtNote IsNot Nothing Then
                            '            NoteOrder += 1

                            '            dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                            '        End If
                            '    End If
                            '    ds.Tables("NON_TAXABLE_INCOME_DETAIL").ImportRow(rowx)
                            'Next
                            For Each rowx As DataRow In dt.Rows
                                dtRow = ds.Tables("NON_TAXABLE_INCOME_DETAIL").NewRow
                                For Each clm_DB As DataColumn In dt.Columns
                                    For Each clm_DS As DataColumn In ds.Tables("NON_TAXABLE_INCOME_DETAIL").Columns

                                        If clm_DB.ColumnName = clm_DS.ColumnName Then
                                            dtRow(clm_DS.ColumnName.ToString) = rowx(clm_DB.ColumnName)
                                        End If

                                    Next
                                Next
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.OTHERNONTAXINC.ToString, False, rowx("NTD_NTKEY"), rowx("NTD_NTDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("NON_TAXABLE_INCOME_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.INTERESTRESTRICT
                    dt = Nothing
                    dt = ADO.Load_PNL_expenses_interestrestrict(PNL_KEY, Errorlog)
                    Dim tmpDt_Data As DataTable = Nothing
                    Dim tmpDt_Col As DataTable = Nothing
                    ds.Tables("REF_INTEREST_RESTRIC_DETAIL_MONTHLY").Rows.Clear()
                    ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Rows.Clear()
                    ds.Tables("REF_INTEREST_RESTRIC_DETAIL").Rows.Clear()
                    ds.Tables("expenses_interestrestrict").Rows.Clear()

                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "expenses_interestrestrict", "EXIR_EXIRKEY", rowx("EXIR_EXIRKEY")) = False Then
                                dtRow = ds.Tables("expenses_interestrestrict").NewRow
                                dtRow("EXIR_KEY") = rowx("EXIR_KEY")
                                dtRow("EXIR_EXIRKEY") = rowx("EXIR_EXIRKEY")
                                dtRow("EXIR_SOURCENO") = rowx("EXIR_SOURCENO")
                                dtRow("EXIR_AMOUNT") = rowx("EXIR_AMOUNT")
                                dtRow("EXIR_DESC") = rowx("EXIR_DESC")
                                If IsDBNull(rowx("EXIR_DEDUCTIBLE")) = False AndAlso (rowx("EXIR_DEDUCTIBLE") = "Yes" OrElse rowx("EXIR_DEDUCTIBLE") = "True") Then
                                    dtRow("EXIR_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXIR_DEDUCTIBLE") = False
                                End If
                                dtRow("EXIR_NOTE") = rowx("EXIR_NOTE")
                                dtRow("EXIR_DETAIL") = rowx("EXIR_DETAIL")
                                dtRow("EXIR_YEAREND") = rowx("EXIR_YEAREND")
                                dtRow("EXIR_STATUS") = rowx("EXIR_STATUS")
                                If IsDBNull(rowx("EXIR_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXIR_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXIR_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXIR_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXIR_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))

                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.INTERESTRESTRICT.ToString, True, rowx("EXIR_EXIRKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If

                                ds.Tables("expenses_interestrestrict").Rows.Add(dtRow)

                                tmpDt_Data = Nothing

                                tmpDt_Data = ADO.Load_REF_INTEREST_RESTRIC_MONTHLY_TRICOR(rowx("EXIR_SOURCENO"), RefNo, YA, Errorlog)

                                mdlPNL2.LoadTable_InterestRestricted(ds, RefNo, YA, rowx("EXIR_SOURCENO"), rowx("EXIR_EXIRKEY"), Errorlog)

                                If tmpDt_Data IsNot Nothing Then
                                    For i As Integer = 0 To tmpDt_Data.Rows.Count - 1
                                        ds.Tables("REF_INTEREST_RESTRIC_DETAIL_TRICOR_TEMP").ImportRow(tmpDt_Data.Rows(i))
                                    Next
                                    mdlPNL2.AppenData_InterestRestricted(tmpDt_Data, ds, Errorlog)
                                    Application.DoEvents()
                                    'AZHAM 23/05/2019 ==== CHANGE FROM INTEREST_RESTRIC_MONTLY_REPORT TO REF_INTEREST_RESTRIC_DETAIL_TRICOR_TEMP =======
                                    'ADO.SAVE_EXPENSES_INTERESTRESTRICT_TRICOR_TEMP(PNL_KEY, ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT"), RefNo,
                                    '                                                YA, rowx("EXIR_SOURCENO"), Errorlog)
                                    ADO.SAVE_EXPENSES_INTERESTRESTRICT_TRICOR_TEMP(PNL_KEY, ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT"), RefNo,
                                                                                YA, rowx("EXIR_SOURCENO"), Errorlog)
                                    'AZHAM 23/05/2019 ==== CHANGE FROM INTEREST_RESTRIC_MONTLY_REPORT TO REF_INTEREST_RESTRIC_DETAIL_TRICOR_TEMP =======
                                End If
                                If isPrint Then
                                    mdlPNL2.AppenData_InterestRestricted_Report(tmpDt_Data, ds, RefNo, YA, rowx("EXIR_SOURCENO"), Errorlog)
                                End If

                                tmpDt_Data = Nothing


                                tmpDt_Data = ADO.Load_REF_INTEREST_RESTRIC_DETAIL_YEARLY(rowx("EXIR_SOURCENO"), RefNo, YA, Errorlog)

                                If tmpDt_Data IsNot Nothing Then
                                    For x As Integer = 0 To tmpDt_Data.Rows.Count - 1

                                        dtRow = Nothing
                                        dtRow = ds.Tables("REF_INTEREST_RESTRIC_DETAIL").NewRow
                                        dtRow("RIRD_KEY") = tmpDt_Data.Rows(x)("RIRD_KEY")
                                        dtRow("RIR_REF_NUM") = tmpDt_Data.Rows(x)("RIR_REF_NUM")
                                        dtRow("RIRD_MONTH") = tmpDt_Data.Rows(x)("RIRD_MONTH")
                                        dtRow("RIRD_TYPE") = tmpDt_Data.Rows(x)("RIRD_TYPE")
                                        dtRow("RIRD_DESC") = tmpDt_Data.Rows(x)("RIRD_DESC")
                                        dtRow("RIRD_AMOUNT") = tmpDt_Data.Rows(x)("RIRD_AMOUNT")
                                        dtRow("RIRD_NOTE") = tmpDt_Data.Rows(x)("RIRD_NOTE")
                                        dtRow("RIRD_SOURCENO") = tmpDt_Data.Rows(x)("RIRD_SOURCENO")
                                        dtRow("RIRD_TYPE_INCOME") = tmpDt_Data.Rows(x)("RIRD_TYPE_INCOME")

                                        ds.Tables("REF_INTEREST_RESTRIC_DETAIL").Rows.Add(dtRow)
                                    Next
                                    If ADO.Save_REF_INTEREST_RESTRIC_DETAIL_TEMP(ds.Tables("REF_INTEREST_RESTRIC_DETAIL"), RefNo, YA, rowx("EXIR_SOURCENO"), PNL_KEY,
                                                                  0, Errorlog, False) = False Then

                                    End If
                                End If

                            End If

                        Next
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPOTHERINTEREST
                    dt = Nothing
                    dt = ADO.Load_PNL_expenses_interest(PNL_KEY, Errorlog)
                    ds.Tables("EXPENSES_INTEREST_DETAIL").Rows.Clear()
                    ds.Tables("expenses_interest").Rows.Clear()

                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "expenses_interest", "EXI_EXIKEY", rowx("EXI_EXIKEY")) = False Then
                                dtRow = ds.Tables("expenses_interest").NewRow
                                dtRow("EXI_KEY") = rowx("EXI_KEY")
                                dtRow("EXI_EXIKEY") = rowx("EXI_EXIKEY")
                                dtRow("EXI_SOURCENO") = rowx("EXI_SOURCENO")
                                dtRow("EXI_DESC") = rowx("EXI_DESC")
                                dtRow("EXI_AMOUNT") = rowx("EXI_AMOUNT")
                                If IsDBNull(rowx("EXI_DEDUCTIBLE")) = False AndAlso (rowx("EXI_DEDUCTIBLE") = "Yes" OrElse rowx("EXI_DEDUCTIBLE") = "True") Then
                                    dtRow("EXI_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXI_DEDUCTIBLE") = False
                                End If
                                dtRow("EXI_NOTE") = rowx("EXI_NOTE")
                                dtRow("EXI_DETAIL") = rowx("EXI_DETAIL")
                                If IsDBNull(rowx("Exi_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXI_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXI_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXI_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXI_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))

                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPOTHERINTEREST.ToString, True, rowx("EXI_EXIKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("expenses_interest").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_EXPENSES_INTEREST_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_INTEREST_DETAIL").NewRow
                                dtRow("EXID_KEY") = rowx("EXID_KEY")
                                dtRow("EXID_EXIKEY") = rowx("EXID_EXIKEY")
                                dtRow("EXID_SOURCENO") = rowx("EXID_SOURCENO")
                                dtRow("EXID_EXIDKEY") = ds.Tables("EXPENSES_INTEREST_DETAIL").Rows.Count + 1
                                dtRow("EXID_DESC") = rowx("EXID_DESC")
                                If IsDBNull(rowx("EXID_DEDUCTIBLE")) = False AndAlso (rowx("EXID_DEDUCTIBLE") = "Yes" OrElse rowx("EXID_DEDUCTIBLE") = "True") Then
                                    dtRow("EXID_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXID_DEDUCTIBLE") = False
                                End If
                                dtRow("EXID_AMOUNT") = rowx("EXID_AMOUNT")
                                dtRow("EXID_NOTE") = rowx("EXID_NOTE")
                                If IsDBNull(rowx("EXID_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXID_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXID_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXID_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXID_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))

                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPOTHERINTEREST.ToString, False, rowx("EXID_EXIKEY"), rowx("EXID_EXIDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("EXPENSES_INTEREST_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPLEGAL
                    dt = Nothing
                    dt = ADO.Load_PNL_expenses_legal(PNL_KEY, Errorlog)
                    ds.Tables("EXPENSES_LEGAL_DETAIL").Rows.Clear()
                    ds.Tables("expenses_legal").Rows.Clear()

                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "expenses_legal", "EXL_EXLKEY", rowx("EXL_EXLKEY")) = False Then
                                dtRow = ds.Tables("expenses_legal").NewRow
                                dtRow("EXL_KEY") = rowx("EXL_KEY")
                                dtRow("EXL_EXLKEY") = rowx("EXL_EXLKEY")
                                dtRow("EXL_SOURCENO") = rowx("EXL_SOURCENO")
                                dtRow("EXL_DESC") = rowx("EXL_DESC")
                                dtRow("EXL_AMOUNT") = rowx("EXL_AMOUNT")
                                If IsDBNull(rowx("EXL_DEDUCTIBLE")) = False AndAlso (rowx("EXL_DEDUCTIBLE") = "Yes" OrElse rowx("EXL_DEDUCTIBLE") = "True") Then
                                    dtRow("EXL_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXL_DEDUCTIBLE") = False
                                End If
                                dtRow("EXL_NOTE") = rowx("EXL_NOTE")
                                dtRow("EXL_DETAIL") = rowx("EXL_DETAIL")
                                If IsDBNull(rowx("EXL_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXL_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXL_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXL_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXL_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPLEGAL.ToString, True, rowx("EXL_EXLKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("expenses_legal").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_EXPENSES_LEGAL_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_LEGAL_DETAIL").NewRow
                                dtRow("EXLD_KEY") = rowx("EXLD_KEY")
                                dtRow("EXLD_EXLKEY") = rowx("EXLD_EXLKEY")
                                dtRow("EXLD_SOURCENO") = rowx("EXLD_SOURCENO")
                                dtRow("EXLD_EXLDKEY") = ds.Tables("EXPENSES_LEGAL_DETAIL").Rows.Count + 1
                                dtRow("EXLD_DESC") = rowx("EXLD_DESC")
                                If IsDBNull(rowx("EXLD_DEDUCTIBLE")) = False AndAlso (rowx("EXLD_DEDUCTIBLE") = "Yes" OrElse rowx("EXLD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXLD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXLD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXLD_AMOUNT") = rowx("EXLD_AMOUNT")
                                dtRow("EXLD_NOTE") = rowx("EXLD_NOTE")
                                If IsDBNull(rowx("EXLD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXLD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXLD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXLD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXLD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPLEGAL.ToString, False, rowx("EXLD_EXLKEY"), rowx("EXLD_EXLDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("EXPENSES_LEGAL_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPTECHNICAL
                    dt = Nothing
                    dt = ADO.Load_PNL_expenses_tech_fee(PNL_KEY, Errorlog)

                    ds.Tables("EXPENSES_TECH_FEE_DETAIL").Rows.Clear()
                    ds.Tables("expenses_tech_fee").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "expenses_tech_fee", "EXTF_EXTFKEY", rowx("EXTF_EXTFKEY")) = False Then
                                dtRow = ds.Tables("expenses_tech_fee").NewRow
                                dtRow("EXTF_KEY") = rowx("EXTF_KEY")
                                dtRow("EXTF_EXTFKEY") = rowx("EXTF_EXTFKEY")
                                dtRow("EXTF_SOURCENO") = rowx("EXTF_SOURCENO")
                                dtRow("EXTF_DESC") = rowx("EXTF_DESC")
                                dtRow("EXTF_AMOUNT") = rowx("EXTF_AMOUNT")
                                If IsDBNull(rowx("EXTF_DEDUCTIBLE")) = False AndAlso (rowx("EXTF_DEDUCTIBLE") = "Yes" OrElse rowx("EXTF_DEDUCTIBLE") = "True") Then
                                    dtRow("EXTF_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXTF_DEDUCTIBLE") = False
                                End If
                                dtRow("EXTF_NOTE") = rowx("EXTF_NOTE")
                                dtRow("EXTF_DETAIL") = rowx("EXTF_DETAIL")
                                If IsDBNull(rowx("EXTF_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXTF_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXTF_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXTF_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXTF_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPTECHNICAL.ToString, True, rowx("EXTF_EXTFKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("expenses_tech_fee").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_EXPENSES_TECH_FEE_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_TECH_FEE_DETAIL").NewRow
                                dtRow("EXTFD_KEY") = rowx("EXTFD_KEY")
                                dtRow("EXTFD_EXTFKEY") = rowx("EXTFD_EXTFKEY")
                                dtRow("EXTFD_SOURCENO") = rowx("EXTFD_SOURCENO")
                                dtRow("EXTFD_EXTFDKEY") = ds.Tables("EXPENSES_TECH_FEE_DETAIL").Rows.Count + 1
                                dtRow("EXTFD_DESC") = rowx("EXTFD_DESC")
                                If IsDBNull(rowx("EXTFD_DEDUCTIBLE")) = False AndAlso (rowx("EXTFD_DEDUCTIBLE") = "Yes" OrElse rowx("EXTFD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXTFD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXTFD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXTFD_AMOUNT") = rowx("EXTFD_AMOUNT")
                                dtRow("EXTFD_NOTE") = rowx("EXTFD_NOTE")
                                If IsDBNull(rowx("EXTFD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXTFD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXTFD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXTFD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXTFD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPTECHNICAL.ToString, False, rowx("EXTFD_EXTFKEY"), rowx("EXTFD_EXTFDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("EXPENSES_TECH_FEE_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPCONTRACTPAY
                    dt = Nothing
                    dt = ADO.Load_PNL_expenses_contract(PNL_KEY, Errorlog)

                    ds.Tables("EXPENSES_CONTRACT_DETAIL").Rows.Clear()
                    ds.Tables("expenses_contract").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "expenses_contract", "EXC_EXCKEY", rowx("EXC_EXCKEY")) = False Then
                                dtRow = ds.Tables("expenses_contract").NewRow
                                dtRow("EXC_KEY") = rowx("EXC_KEY")
                                dtRow("EXC_EXCKEY") = rowx("EXC_EXCKEY")
                                dtRow("EXC_SOURCENO") = rowx("EXC_SOURCENO")
                                dtRow("EXC_DESC") = rowx("EXC_DESC")
                                dtRow("EXC_AMOUNT") = rowx("EXC_AMOUNT")
                                If IsDBNull(rowx("EXC_DEDUCTIBLE")) = False AndAlso (rowx("EXC_DEDUCTIBLE") = "Yes" OrElse rowx("EXC_DEDUCTIBLE") = "True") Then
                                    dtRow("EXC_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXC_DEDUCTIBLE") = False
                                End If
                                dtRow("EXC_NOTE") = rowx("EXC_NOTE")
                                dtRow("EXC_DETAIL") = rowx("EXC_DETAIL")
                                If IsDBNull(rowx("EXC_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXC_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXC_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXC_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXC_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPCONTRACTPAY.ToString, True, rowx("EXC_EXCKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("expenses_contract").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_EXPENSES_CONTRACT_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing

                                dtRow = ds.Tables("EXPENSES_CONTRACT_DETAIL").NewRow
                                dtRow("EXCD_KEY") = rowx("EXCD_KEY")
                                dtRow("EXCD_EXCKEY") = rowx("EXCD_EXCKEY")
                                dtRow("EXCD_SOURCENO") = rowx("EXCD_SOURCENO")
                                dtRow("EXCD_EXCDKEY") = ds.Tables("EXPENSES_CONTRACT_DETAIL").Rows.Count + 1
                                dtRow("EXCD_DESC") = rowx("EXCD_DESC")
                                If IsDBNull(rowx("EXCD_DEDUCTIBLE")) = False AndAlso (rowx("EXCD_DEDUCTIBLE") = "Yes" OrElse rowx("EXCD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXCD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXCD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXCD_AMOUNT") = rowx("EXCD_AMOUNT")
                                dtRow("EXCD_NOTE") = rowx("EXCD_NOTE")
                                If IsDBNull(rowx("EXCD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXCD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXCD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXCD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXCD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPCONTRACTPAY.ToString, False, rowx("EXCD_EXCKEY"), rowx("EXCD_EXCDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If

                                ds.Tables("EXPENSES_CONTRACT_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPDIRECTORFEE
                    dt = Nothing
                    dt = ADO.Load_PNL_expenses_directors_fee(PNL_KEY, Errorlog)

                    ds.Tables("EXPENSES_DIRECTORS_FEE_DETAIL").Rows.Clear()
                    ds.Tables("expenses_directors_fee").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "expenses_directors_fee", "EXDF_EXDFKEY", rowx("EXDF_EXDFKEY")) = False Then
                                dtRow = ds.Tables("expenses_directors_fee").NewRow
                                dtRow("EXDF_KEY") = rowx("EXDF_KEY")
                                dtRow("EXDF_EXDFKEY") = rowx("EXDF_EXDFKEY")
                                dtRow("EXDF_SOURCENO") = rowx("EXDF_SOURCENO")
                                dtRow("EXDF_DESC") = rowx("EXDF_DESC")
                                dtRow("EXDF_AMOUNT") = rowx("EXDF_AMOUNT")
                                If IsDBNull(rowx("EXDF_DEDUCTIBLE")) = False AndAlso (rowx("EXDF_DEDUCTIBLE") = "Yes" OrElse rowx("EXDF_DEDUCTIBLE") = "True") Then
                                    dtRow("EXDF_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXDF_DEDUCTIBLE") = False
                                End If
                                dtRow("EXDF_NOTE") = rowx("EXDF_NOTE")
                                dtRow("EXDF_DETAIL") = rowx("EXDF_DETAIL")
                                If IsDBNull(rowx("EXDF_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXDF_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXDF_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXDF_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXDF_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPDIRECTORFEE.ToString, True, rowx("EXDF_EXDFKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("expenses_directors_fee").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_EXPENSES_DIRECTORS_FEE_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_DIRECTORS_FEE_DETAIL").NewRow
                                dtRow("EXDFD_KEY") = rowx("EXDFD_KEY")
                                dtRow("EXDFD_EXDFKEY") = rowx("EXDFD_EXDFKEY")
                                dtRow("EXDFD_SOURCENO") = rowx("EXDFD_SOURCENO")
                                dtRow("EXDFD_EXDFDKEY") = ds.Tables("EXPENSES_DIRECTORS_FEE_DETAIL").Rows.Count + 1
                                dtRow("EXDFD_DESC") = rowx("EXDFD_DESC")
                                If IsDBNull(rowx("EXDFD_DEDUCTIBLE")) = False AndAlso (rowx("EXDFD_DEDUCTIBLE") = "Yes" OrElse rowx("EXDFD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXDFD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXDFD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXDFD_AMOUNT") = rowx("EXDFD_AMOUNT")
                                dtRow("EXDFD_NOTE") = rowx("EXDFD_NOTE")
                                If IsDBNull(rowx("EXDFD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXDFD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXDFD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXDFD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXDFD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPDIRECTORFEE.ToString, False, rowx("EXDFD_EXDFKEY"), rowx("EXDFD_EXDFDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("EXPENSES_DIRECTORS_FEE_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPSALARY
                    dt = Nothing
                    dt = ADO.Load_PNL_expenses_salary(PNL_KEY, Errorlog)

                    ds.Tables("EXPENSES_SALARY_DETAIL").Rows.Clear()
                    ds.Tables("expenses_salary").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "expenses_salary", "EXS_EXSKEY", rowx("EXS_EXSKEY")) = False Then
                                dtRow = ds.Tables("expenses_salary").NewRow
                                dtRow("EXS_KEY") = rowx("EXS_KEY")
                                dtRow("EXS_EXSKEY") = rowx("EXS_EXSKEY")
                                dtRow("EXS_SOURCENO") = rowx("EXS_SOURCENO")
                                dtRow("EXS_DESC") = rowx("EXS_DESC")
                                dtRow("EXS_AMOUNT") = rowx("EXS_AMOUNT")
                                If IsDBNull(rowx("EXS_DEDUCTIBLE")) = False AndAlso (rowx("EXS_DEDUCTIBLE") = "Yes" OrElse rowx("EXS_DEDUCTIBLE") = "True") Then
                                    dtRow("EXS_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXS_DEDUCTIBLE") = False
                                End If
                                dtRow("EXS_NOTE") = rowx("EXS_NOTE")
                                dtRow("EXS_DETAIL") = rowx("EXS_DETAIL")
                                If IsDBNull(rowx("EXS_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXS_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXS_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXS_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXS_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPSALARY.ToString, True, rowx("EXS_EXSKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("expenses_salary").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_EXPENSES_SALARY_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing

                                dtRow = ds.Tables("EXPENSES_SALARY_DETAIL").NewRow
                                dtRow("EXSD_KEY") = rowx("EXSD_KEY")
                                dtRow("EXSD_EXSKEY") = rowx("EXSD_EXSKEY")
                                dtRow("EXSD_SOURCENO") = rowx("EXSD_SOURCENO")
                                dtRow("EXSD_EXSDKEY") = ds.Tables("EXPENSES_SALARY_DETAIL").Rows.Count + 1
                                dtRow("EXSD_DESC") = rowx("EXSD_DESC")
                                If IsDBNull(rowx("EXSD_DEDUCTIBLE")) = False AndAlso (rowx("EXSD_DEDUCTIBLE") = "Yes" OrElse rowx("EXSD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXSD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXSD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXSD_AMOUNT") = rowx("EXSD_AMOUNT")
                                dtRow("EXSD_NOTE") = rowx("EXSD_NOTE")
                                If IsDBNull(rowx("EXSD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXSD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXSD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXSD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXSD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPSALARY.ToString, False, rowx("EXSD_EXSKEY"), rowx("EXSD_EXSDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If

                                ds.Tables("EXPENSES_SALARY_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPEMPLOYEESTOCK
                    dt = Nothing
                    dt = ADO.Load_PNL_expenses_empl_stock(PNL_KEY, Errorlog)

                    ds.Tables("EXPENSES_EMPLSTOCK_DETAIL").Rows.Clear()
                    ds.Tables("expenses_empl_stock").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "expenses_empl_stock", "EXES_EXESKEY", rowx("EXES_EXESKEY")) = False Then
                                dtRow = ds.Tables("expenses_empl_stock").NewRow
                                dtRow("EXES_KEY") = rowx("EXES_KEY")
                                dtRow("EXES_EXESKEY") = rowx("EXES_EXESKEY")
                                dtRow("EXES_SOURCENO") = rowx("EXES_SOURCENO")
                                dtRow("EXES_DESC") = rowx("EXES_DESC")
                                If IsDBNull(rowx("EXES_DEDUCTIBLE")) = False AndAlso (rowx("EXES_DEDUCTIBLE") = "Yes" OrElse rowx("EXES_DEDUCTIBLE") = "True") Then
                                    dtRow("EXES_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXES_DEDUCTIBLE") = False
                                End If
                                dtRow("EXES_AMOUNT") = rowx("EXES_AMOUNT")
                                dtRow("EXES_NOTE") = rowx("EXES_NOTE")
                                dtRow("RowIndex") = rowx("RowIndex")
                                If IsDBNull(rowx("EXES_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXES_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXES_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXES_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXES_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPEMPLOYEESTOCK.ToString, True, rowx("EXES_EXESKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("expenses_empl_stock").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_EXPENSES_EMPLSTOCK_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_EMPLSTOCK_DETAIL").NewRow
                                dtRow("EXESD_KEY") = rowx("EXESD_KEY")
                                dtRow("EXESD_EXESKEY") = rowx("EXESD_EXESKEY")
                                dtRow("EXESD_SOURCENO") = rowx("EXESD_SOURCENO")
                                dtRow("EXESD_DESC") = rowx("EXESD_DESC")
                                dtRow("EXESD_AMOUNT") = rowx("EXESD_AMOUNT")
                                dtRow("EXESD_EXESDKEY") = ds.Tables("EXPENSES_EMPLSTOCK_DETAIL").Rows.Count + 1
                                If IsDBNull(rowx("EXESD_DEDUCTIBLE")) = False AndAlso (rowx("EXESD_DEDUCTIBLE") = "Yes" OrElse rowx("EXESD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXESD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXESD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXESD_NOTE") = rowx("EXESD_NOTE")
                                dtRow("EXESD_DETAIL") = rowx("EXESD_DETAIL")
                                If IsDBNull(rowx("EXESD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXESD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXESD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXESD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXESD_DEDUCTIBLE_ADD") = False
                                End If

                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPEMPLOYEESTOCK.ToString, False, rowx("EXESD_EXESKEY"), rowx("EXESD_EXESDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("EXPENSES_EMPLSTOCK_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPROYALTY
                    dt = Nothing
                    dt = ADO.Load_PNL_expenses_royalty(PNL_KEY, Errorlog)

                    ds.Tables("EXPENSES_ROYALTY_DETAIL").Rows.Clear()
                    ds.Tables("expenses_royalty").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "expenses_royalty", "EXRO_EXROKEY", rowx("EXRO_EXROKEY")) = False Then
                                dtRow = ds.Tables("expenses_royalty").NewRow
                                dtRow("EXRO_KEY") = rowx("EXRO_KEY")
                                dtRow("EXRO_EXROKEY") = rowx("EXRO_EXROKEY")
                                dtRow("EXRO_SOURCENO") = rowx("EXRO_SOURCENO")
                                dtRow("EXRO_DESC") = rowx("EXRO_DESC")
                                dtRow("EXRO_AMOUNT") = rowx("EXRO_AMOUNT")
                                If IsDBNull(rowx("EXRO_DEDUCTIBLE")) = False AndAlso (rowx("EXRO_DEDUCTIBLE") = "Yes" OrElse rowx("EXRO_DEDUCTIBLE") = "True") Then
                                    dtRow("EXRO_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXRO_DEDUCTIBLE") = False
                                End If
                                dtRow("EXRO_NOTE") = rowx("EXRO_NOTE")
                                dtRow("EXRO_DETAIL") = rowx("EXRO_DETAIL")
                                If IsDBNull(rowx("EXRO_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXRO_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXRO_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXRO_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXRO_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPROYALTY.ToString, True, rowx("EXRO_EXROKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("expenses_royalty").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_EXPENSES_ROYALTY_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_ROYALTY_DETAIL").NewRow
                                dtRow("EXROD_KEY") = rowx("EXROD_KEY")
                                dtRow("EXROD_EXROKEY") = rowx("EXROD_EXROKEY")
                                dtRow("EXROD_SOURCENO") = rowx("EXROD_SOURCENO")
                                dtRow("EXROD_EXRODKEY") = ds.Tables("EXPENSES_ROYALTY_DETAIL").Rows.Count + 1
                                dtRow("EXROD_DESC") = rowx("EXROD_DESC")
                                If IsDBNull(rowx("EXROD_DEDUCTIBLE")) = False AndAlso (rowx("EXROD_DEDUCTIBLE") = "Yes" OrElse rowx("EXROD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXROD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXROD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXROD_AMOUNT") = rowx("EXROD_AMOUNT")
                                dtRow("EXROD_NOTE") = rowx("EXROD_NOTE")
                                If IsDBNull(rowx("EXROD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXROD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXROD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXROD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXROD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPROYALTY.ToString, False, rowx("EXROD_EXROKEY"), rowx("EXROD_EXRODKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("EXPENSES_ROYALTY_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPRENTAL
                    dt = Nothing
                    dt = ADO.Load_PNL_expenses_rental(PNL_KEY, Errorlog)

                    ds.Tables("EXPENSES_RENTAL_DETAIL").Rows.Clear()
                    ds.Tables("expenses_rental").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "expenses_rental", "EXRENT_EXRENTKEY", rowx("EXRENT_EXRENTKEY")) = False Then
                                dtRow = ds.Tables("expenses_rental").NewRow
                                dtRow("EXRENT_KEY") = rowx("EXRENT_KEY")
                                dtRow("EXRENT_EXRENTKEY") = rowx("EXRENT_EXRENTKEY")
                                dtRow("EXRENT_SOURCENO") = rowx("EXRENT_SOURCENO")
                                dtRow("EXRENT_DESC") = rowx("EXRENT_DESC")
                                dtRow("EXRENT_AMOUNT") = rowx("EXRENT_AMOUNT")
                                If IsDBNull(rowx("EXRENT_DEDUCTIBLE")) = False AndAlso (rowx("EXRENT_DEDUCTIBLE") = "Yes" OrElse rowx("EXRENT_DEDUCTIBLE") = "True") Then
                                    dtRow("EXRENT_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXRENT_DEDUCTIBLE") = False
                                End If
                                dtRow("EXRENT_NOTE") = rowx("EXRENT_NOTE")
                                dtRow("EXRENT_DETAIL") = rowx("EXRENT_DETAIL")
                                If IsDBNull(rowx("EXRENT_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXRENT_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXRENT_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXRENT_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXRENT_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPRENTAL.ToString, True, rowx("EXRENT_EXRENTKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                dtRow("Address") = rowx("Address")
                                ds.Tables("expenses_rental").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_EXPENSES_RENTAL_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_RENTAL_DETAIL").NewRow
                                dtRow("EXRENTD_KEY") = rowx("EXRENTD_KEY")
                                dtRow("EXRENTD_EXRENTKEY") = rowx("EXRENTD_EXRENTKEY")
                                dtRow("EXRENTD_SOURCENO") = rowx("EXRENTD_SOURCENO")
                                dtRow("EXRENTD_EXRENTDKEY") = ds.Tables("EXPENSES_RENTAL_DETAIL").Rows.Count + 1
                                dtRow("EXRENTD_DESC") = rowx("EXRENTD_DESC")
                                If IsDBNull(rowx("EXRENTD_DEDUCTIBLE")) = False AndAlso (rowx("EXRENTD_DEDUCTIBLE") = "Yes" OrElse rowx("EXRENTD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXRENTD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXRENTD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXRENTD_AMOUNT") = rowx("EXRENTD_AMOUNT")
                                dtRow("EXRENTD_NOTE") = rowx("EXRENTD_NOTE")
                                If IsDBNull(rowx("EXRENTD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXRENTD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXRENTD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXRENTD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXRENTD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                dtRow("Address") = rowx("Address")
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPRENTAL.ToString, False, rowx("EXRENTD_EXRENTKEY"), rowx("EXRENTD_EXRENTDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("EXPENSES_RENTAL_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPREPAIRMAINTENANCE
                    dt = Nothing
                    dt = ADO.Load_PNL_expenses_repair(PNL_KEY, Errorlog)

                    ds.Tables("EXPENSES_REPAIR_DETAIL").Rows.Clear()
                    ds.Tables("expenses_repair").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "expenses_repair", "EXREP_EXREPKEY", rowx("EXREP_EXREPKEY")) = False Then
                                dtRow = ds.Tables("expenses_repair").NewRow
                                dtRow("EXREP_KEY") = rowx("EXREP_KEY")
                                dtRow("EXREP_EXREPKEY") = rowx("EXREP_EXREPKEY")
                                dtRow("EXREP_SOURCENO") = rowx("EXREP_SOURCENO")
                                dtRow("EXREP_DESC") = rowx("EXREP_DESC")
                                dtRow("EXREP_AMOUNT") = rowx("EXREP_AMOUNT")
                                If IsDBNull(rowx("EXREP_DEDUCTIBLE")) = False AndAlso (rowx("EXREP_DEDUCTIBLE") = "Yes" OrElse rowx("EXREP_DEDUCTIBLE") = "True") Then
                                    dtRow("EXREP_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXREP_DEDUCTIBLE") = False
                                End If
                                dtRow("EXREP_NOTE") = rowx("EXREP_NOTE")
                                dtRow("EXREP_DETAIL") = rowx("EXREP_DETAIL")
                                If IsDBNull(rowx("EXREP_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXREP_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXREP_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXREP_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXREP_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPREPAIRMAINTENANCE.ToString, True, rowx("EXREP_EXREPKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("expenses_repair").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_EXPENSES_REPAIR_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_REPAIR_DETAIL").NewRow
                                dtRow("EXREPD_KEY") = rowx("EXREPD_KEY")
                                dtRow("EXREPD_EXREPKEY") = rowx("EXREPD_EXREPKEY")
                                dtRow("EXREPD_SOURCENO") = rowx("EXREPD_SOURCENO")
                                dtRow("EXREPD_EXREPDKEY") = ds.Tables("EXPENSES_REPAIR_DETAIL").Rows.Count + 1
                                dtRow("EXREPD_DESC") = rowx("EXREPD_DESC")
                                If IsDBNull(rowx("EXREPD_DEDUCTIBLE")) = False AndAlso (rowx("EXREPD_DEDUCTIBLE") = "Yes" OrElse rowx("EXREPD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXREPD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXREPD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXREPD_AMOUNT") = rowx("EXREPD_AMOUNT")
                                dtRow("EXREPD_NOTE") = rowx("EXREPD_NOTE")
                                If IsDBNull(rowx("EXREPD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXREPD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXREPD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXREPD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXREPD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPREPAIRMAINTENANCE.ToString, False, rowx("EXREPD_EXREPKEY"), rowx("EXREPD_EXREPDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("EXPENSES_REPAIR_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPRND
                    dt = Nothing
                    dt = ADO.Load_PNL_expenses_research(PNL_KEY, Errorlog)

                    ds.Tables("EXPENSES_RESEARCH_DETAIL").Rows.Clear()
                    ds.Tables("expenses_research").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "expenses_research", "EXRES_EXRESKEY", rowx("EXRES_EXRESKEY")) = False Then
                                dtRow = ds.Tables("expenses_research").NewRow
                                dtRow("EXRES_KEY") = rowx("EXRES_KEY")
                                dtRow("EXRES_EXRESKEY") = rowx("EXRES_EXRESKEY")
                                dtRow("EXRES_SOURCENO") = rowx("EXRES_SOURCENO")
                                dtRow("EXRES_DESC") = rowx("EXRES_DESC")
                                dtRow("EXRES_AMOUNT") = rowx("EXRES_AMOUNT")
                                If IsDBNull(rowx("EXRES_DEDUCTIBLE")) = False AndAlso (rowx("EXRES_DEDUCTIBLE") = "Yes" OrElse rowx("EXRES_DEDUCTIBLE") = "True") Then
                                    dtRow("EXRES_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXRES_DEDUCTIBLE") = False
                                End If
                                dtRow("EXRES_NOTE") = rowx("EXRES_NOTE")
                                dtRow("EXRES_DETAIL") = rowx("EXRES_DETAIL")
                                If IsDBNull(rowx("EXRES_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXRES_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXRES_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXRES_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXRES_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPRND.ToString, True, rowx("EXRES_EXRESKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("expenses_research").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_EXPENSES_RESEARCH_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_RESEARCH_DETAIL").NewRow
                                dtRow("EXRESD_KEY") = rowx("EXRESD_KEY")
                                dtRow("EXRESD_EXRESKEY") = rowx("EXRESD_EXRESKEY")
                                dtRow("EXRESD_SOURCENO") = rowx("EXRESD_SOURCENO")
                                dtRow("EXRESD_EXRESDKEY") = ds.Tables("EXPENSES_RESEARCH_DETAIL").Rows.Count + 1
                                dtRow("EXRESD_DESC") = rowx("EXRESD_DESC")
                                If IsDBNull(rowx("EXRESD_DEDUCTIBLE")) = False AndAlso (rowx("EXRESD_DEDUCTIBLE") = "Yes" OrElse rowx("EXRESD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXRESD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXRESD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXRESD_AMOUNT") = rowx("EXRESD_AMOUNT")
                                dtRow("EXRESD_NOTE") = rowx("EXRESD_NOTE")
                                If IsDBNull(rowx("EXRESD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXRESD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXRESD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXRESD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXRESD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPRND.ToString, False, rowx("EXRESD_EXRESKEY"), rowx("EXRESD_EXRESDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("EXPENSES_RESEARCH_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPADVERTISEMENT
                    dt = Nothing
                    dt = ADO.Load_PNL_expenses_promote(PNL_KEY, Errorlog)

                    ds.Tables("EXPENSES_PROMOTE_DETAIL").Rows.Clear()
                    ds.Tables("expenses_promote").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "expenses_promote", "EXP_EXPKEY", rowx("EXP_EXPKEY")) = False Then
                                dtRow = ds.Tables("expenses_promote").NewRow
                                dtRow("EXP_KEY") = rowx("EXP_KEY")
                                dtRow("EXP_EXPKEY") = rowx("EXP_EXPKEY")
                                dtRow("EXP_SOURCENO") = rowx("EXP_SOURCENO")
                                dtRow("EXP_DESC") = rowx("EXP_DESC")
                                dtRow("EXP_AMOUNT") = rowx("EXP_AMOUNT")
                                If IsDBNull(rowx("EXP_DEDUCTIBLE")) = False AndAlso (rowx("EXP_DEDUCTIBLE") = "Yes" OrElse rowx("EXP_DEDUCTIBLE") = "True") Then
                                    dtRow("EXP_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXP_DEDUCTIBLE") = False
                                End If
                                dtRow("EXP_NOTE") = rowx("EXP_NOTE")
                                dtRow("EXP_DETAIL") = rowx("EXP_DETAIL")
                                If IsDBNull(rowx("EXP_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXP_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXP_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXP_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXP_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPADVERTISEMENT.ToString, True, rowx("EXP_EXPKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("expenses_promote").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_EXPENSES_PROMOTE_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_PROMOTE_DETAIL").NewRow
                                dtRow("EXPD_KEY") = rowx("EXPD_KEY")
                                dtRow("EXPD_EXPKEY") = rowx("EXPD_EXPKEY")
                                dtRow("EXPD_SOURCENO") = rowx("EXPD_SOURCENO")
                                dtRow("EXPD_EXPDKEY") = ds.Tables("EXPENSES_PROMOTE_DETAIL").Rows.Count + 1
                                dtRow("EXPD_DESC") = rowx("EXPD_DESC")
                                If IsDBNull(rowx("EXPD_DEDUCTIBLE")) = False AndAlso (rowx("EXPD_DEDUCTIBLE") = "Yes" OrElse rowx("EXPD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXPD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXPD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXPD_AMOUNT") = rowx("EXPD_AMOUNT")
                                dtRow("EXPD_NOTE") = rowx("EXPD_NOTE")
                                If IsDBNull(rowx("EXPD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXPD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXPD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXPD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXPD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPADVERTISEMENT.ToString, False, rowx("EXPD_EXPKEY"), rowx("EXPD_EXPDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("EXPENSES_PROMOTE_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPTRAVEL
                    dt = Nothing
                    dt = ADO.Load_PNL_expenses_travel(PNL_KEY, Errorlog)

                    ds.Tables("EXPENSES_TRAVEL_DETAIL").Rows.Clear()
                    ds.Tables("expenses_travel").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "expenses_travel", "EXT_EXTKEY", rowx("EXT_EXTKEY")) = False Then
                                dtRow = ds.Tables("expenses_travel").NewRow
                                dtRow("EXT_KEY") = rowx("EXT_KEY")
                                dtRow("EXT_EXTKEY") = rowx("EXT_EXTKEY")
                                dtRow("EXT_SOURCENO") = rowx("EXT_SOURCENO")
                                dtRow("EXT_DESC") = rowx("EXT_DESC")
                                dtRow("EXT_AMOUNT") = rowx("EXT_AMOUNT")
                                If IsDBNull(rowx("EXT_DEDUCTIBLE")) = False AndAlso (rowx("EXT_DEDUCTIBLE") = "Yes" OrElse rowx("EXT_DEDUCTIBLE") = "True") Then
                                    dtRow("EXT_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXT_DEDUCTIBLE") = False
                                End If
                                dtRow("EXT_NOTE") = rowx("EXT_NOTE")
                                dtRow("EXT_DETAIL") = rowx("EXT_DETAIL")
                                If IsDBNull(rowx("EXT_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXT_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXT_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXT_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXT_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPTRAVEL.ToString, True, rowx("EXT_EXTKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("expenses_travel").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_EXPENSES_TRAVEL_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_TRAVEL_DETAIL").NewRow
                                dtRow("EXTD_KEY") = rowx("EXTD_KEY")
                                dtRow("EXTD_EXTKEY") = rowx("EXTD_EXTKEY")
                                dtRow("EXTD_SOURCENO") = rowx("EXTD_SOURCENO")
                                dtRow("EXTD_EXTDKEY") = ds.Tables("EXPENSES_TRAVEL_DETAIL").Rows.Count + 1
                                dtRow("EXTD_DESC") = rowx("EXTD_DESC")
                                If IsDBNull(rowx("EXTD_DEDUCTIBLE")) = False AndAlso (rowx("EXTD_DEDUCTIBLE") = "Yes" OrElse rowx("EXTD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXTD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXTD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXTD_AMOUNT") = rowx("EXTD_AMOUNT")
                                dtRow("EXTD_NOTE") = rowx("EXTD_NOTE")
                                If IsDBNull(rowx("EXTD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXTD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXTD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXTD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXTD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPTRAVEL.ToString, False, rowx("EXTD_EXTKEY"), rowx("EXTD_EXTDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("EXPENSES_TRAVEL_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPJKDM
                    dt = Nothing
                    dt = ADO.Load_PNL_expenses_jkdm(PNL_KEY, Errorlog)

                    ds.Tables("EXPENSES_JKDM_DETAIL").Rows.Clear()
                    ds.Tables("expenses_jkdm").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "expenses_jkdm", "EXJK_EXJKKEY", rowx("EXJK_EXJKKEY")) = False Then
                                dtRow = ds.Tables("expenses_jkdm").NewRow
                                dtRow("EXJK_KEY") = rowx("EXJK_KEY")
                                dtRow("EXJK_EXJKKEY") = rowx("EXJK_EXJKKEY")
                                dtRow("EXJK_SOURCENO") = rowx("EXJK_SOURCENO")
                                dtRow("EXJK_DESC") = rowx("EXJK_DESC")
                                dtRow("EXJK_AMOUNT") = rowx("EXJK_AMOUNT")
                                If IsDBNull(rowx("EXJK_DEDUCTIBLE")) = False AndAlso (rowx("EXJK_DEDUCTIBLE") = "Yes" OrElse rowx("EXJK_DEDUCTIBLE") = "True") Then
                                    dtRow("EXJK_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXJK_DEDUCTIBLE") = False
                                End If
                                dtRow("EXJK_NOTE") = rowx("EXJK_NOTE")
                                dtRow("EXJK_DETAIL") = rowx("EXJK_DETAIL")
                                If IsDBNull(rowx("EXJK_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXJK_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXJK_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXJK_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXJK_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPJKDM.ToString, True, rowx("EXJK_EXJKKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")


                                ds.Tables("expenses_jkdm").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_EXPENSES_JKDM_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_JKDM_DETAIL").NewRow
                                dtRow("EXJKD_KEY") = rowx("EXJKD_KEY")
                                dtRow("EXJKD_EXJKKEY") = rowx("EXJKD_EXJKKEY")
                                dtRow("EXJKD_SOURCENO") = rowx("EXJKD_SOURCENO")
                                dtRow("EXJKD_EXJKDKEY") = ds.Tables("EXPENSES_JKDM_DETAIL").Rows.Count + 1
                                dtRow("EXJKD_DESC") = rowx("EXJKD_DESC")
                                If IsDBNull(rowx("EXJKD_DEDUCTIBLE")) = False AndAlso (rowx("EXJKD_DEDUCTIBLE") = "Yes" OrElse rowx("EXJKD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXJKD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXJKD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXJKD_AMOUNT") = rowx("EXJKD_AMOUNT")
                                dtRow("EXJKD_NOTE") = rowx("EXJKD_NOTE")
                                If IsDBNull(rowx("EXJKD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXJKD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXJKD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXJKD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXJKD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPJKDM.ToString, False, rowx("EXJKD_EXJKKEY"), rowx("EXJKD_EXJKDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If


                                ds.Tables("EXPENSES_JKDM_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPDEPRECIATION
                    dt = Nothing
                    dt = ADO.Load_PNL_other_exdepreciation(PNL_KEY, Errorlog)

                    ds.Tables("OTHER_EXDEPRECIATION_DETAIL").Rows.Clear()
                    ds.Tables("other_exdepreciation").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "other_exdepreciation", "EXODEP_EXODEPKEY", rowx("EXODEP_EXODEPKEY")) = False Then
                                dtRow = ds.Tables("other_exdepreciation").NewRow
                                dtRow("EXODEP_KEY") = rowx("EXODEP_KEY")
                                dtRow("EXODEP_EXODEPKEY") = rowx("EXODEP_EXODEPKEY")
                                dtRow("EXODEP_SOURCENO") = rowx("EXODEP_SOURCENO")
                                dtRow("EXODEP_DESC") = rowx("EXODEP_DESC")
                                dtRow("EXODEP_AMOUNT") = rowx("EXODEP_AMOUNT")
                                If IsDBNull(rowx("EXODEP_DEDUCTIBLE")) = False AndAlso (rowx("EXODEP_DEDUCTIBLE") = "Yes" OrElse rowx("EXODEP_DEDUCTIBLE") = "True") Then
                                    dtRow("EXODEP_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXODEP_DEDUCTIBLE") = False
                                End If
                                dtRow("EXODEP_NOTE") = rowx("EXODEP_NOTE")
                                dtRow("EXODEP_DETAIL") = rowx("EXODEP_DETAIL")
                                If IsDBNull(rowx("EXODEP_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXODEP_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXODEP_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXODEP_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXODEP_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPDEPRECIATION.ToString, True, rowx("EXODEP_EXODEPKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("other_exdepreciation").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_OTHER_EXDEPRECIATION_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXDEPRECIATION_DETAIL").NewRow
                                dtRow("EXODEPD_KEY") = rowx("EXODEPD_KEY")
                                dtRow("EXODEPD_EXODEPKEY") = rowx("EXODEPD_EXODEPKEY")
                                dtRow("EXODEPD_SOURCENO") = rowx("EXODEPD_SOURCENO")
                                dtRow("EXODEPD_EXODEPDKEY") = ds.Tables("OTHER_EXDEPRECIATION_DETAIL").Rows.Count + 1
                                dtRow("EXODEPD_DESC") = rowx("EXODEPD_DESC")
                                If IsDBNull(rowx("EXODEPD_DEDUCTIBLE")) = False AndAlso (rowx("EXODEPD_DEDUCTIBLE") = "Yes" OrElse rowx("EXODEPD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXODEPD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXODEPD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXODEPD_AMOUNT") = rowx("EXODEPD_AMOUNT")
                                dtRow("EXODEPD_NOTE") = rowx("EXODEPD_NOTE")
                                If IsDBNull(rowx("EXODEPD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXODEPD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXODEPD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXODEPD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXODEPD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPDEPRECIATION.ToString, False, rowx("EXODEPD_EXODEPKEY"), rowx("EXODEPD_EXODEPDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If

                                ds.Tables("OTHER_EXDEPRECIATION_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPDONATIONAPPR
                    dt = Nothing
                    dt = ADO.Load_PNL_other_exapprdonation(PNL_KEY, Errorlog)

                    ds.Tables("OTHER_EXAPPRDONATION_DETAIL").Rows.Clear()
                    ds.Tables("other_exapprdonation").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "other_exapprdonation", "EXOAD_EXOADKEY", rowx("EXOAD_EXOADKEY")) = False Then
                                dtRow = ds.Tables("other_exapprdonation").NewRow
                                dtRow("EXOAD_KEY") = rowx("EXOAD_KEY")
                                dtRow("EXOAD_EXOADKEY") = rowx("EXOAD_EXOADKEY")
                                dtRow("EXOAD_SOURCENO") = rowx("EXOAD_SOURCENO")
                                dtRow("EXOAD_DESC") = rowx("EXOAD_DESC")
                                dtRow("EXOAD_AMOUNT") = rowx("EXOAD_AMOUNT")
                                If IsDBNull(rowx("EXOAD_DEDUCTIBLE")) = False AndAlso (rowx("EXOAD_DEDUCTIBLE") = "Yes" OrElse rowx("EXOAD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOAD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOAD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOAD_NOTE") = rowx("EXOAD_NOTE")
                                dtRow("EXOAD_DETAIL") = rowx("EXOAD_DETAIL")
                                dtRow("EXOAD_TYPE") = rowx("EXOAD_TYPE")
                                If IsDBNull(rowx("EXOAD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOAD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOAD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOAD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOAD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPDONATIONAPPR.ToString, True, rowx("EXOAD_EXOADKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("other_exapprdonation").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_OTHER_EXAPPRDONATION_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXAPPRDONATION_DETAIL").NewRow
                                dtRow("EXOADD_KEY") = rowx("EXOADD_KEY")
                                dtRow("EXOADD_EXOADKEY") = rowx("EXOADD_EXOADKEY")
                                dtRow("EXOADD_SOURCENO") = rowx("EXOADD_SOURCENO")
                                dtRow("EXOADD_EXOADDKEY") = ds.Tables("OTHER_EXAPPRDONATION_DETAIL").Rows.Count + 1
                                dtRow("EXOADD_DESC") = rowx("EXOADD_DESC")
                                If IsDBNull(rowx("EXOADD_DEDUCTIBLE")) = False AndAlso (rowx("EXOADD_DEDUCTIBLE") = "Yes" OrElse rowx("EXOADD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOADD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOADD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOADD_AMOUNT") = rowx("EXOADD_AMOUNT")
                                dtRow("EXOADD_NOTE") = rowx("EXOADD_NOTE")
                                dtRow("EXOADD_TYPE") = rowx("EXOADD_TYPE")
                                If IsDBNull(rowx("EXOADD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOADD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOADD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOADD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOADD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPDONATIONAPPR.ToString, False, rowx("EXOADD_EXOADKEY"), rowx("EXOADD_EXOADDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("OTHER_EXAPPRDONATION_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPDONATIONNONAPPR
                    dt = Nothing
                    dt = ADO.Load_PNL_other_exnapprdonation(PNL_KEY, Errorlog)

                    ds.Tables("OTHER_EXNAPPRDONATION_DETAIL").Rows.Clear()
                    ds.Tables("other_exnapprdonation").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "other_exnapprdonation", "EXONAD_EXONADKEY", rowx("EXONAD_EXONADKEY")) = False Then
                                dtRow = ds.Tables("other_exnapprdonation").NewRow
                                dtRow("EXONAD_KEY") = rowx("EXONAD_KEY")
                                dtRow("EXONAD_EXONADKEY") = rowx("EXONAD_EXONADKEY")
                                dtRow("EXONAD_SOURCENO") = rowx("EXONAD_SOURCENO")
                                dtRow("EXONAD_DESC") = rowx("EXONAD_DESC")
                                dtRow("EXONAD_AMOUNT") = rowx("EXONAD_AMOUNT")
                                If IsDBNull(rowx("EXONAD_DEDUCTIBLE")) = False AndAlso (rowx("EXONAD_DEDUCTIBLE") = "Yes" OrElse rowx("EXONAD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXONAD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXONAD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXONAD_NOTE") = rowx("EXONAD_NOTE")
                                dtRow("EXONAD_DETAIL") = rowx("EXONAD_DETAIL")
                                If IsDBNull(rowx("EXONAD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXONAD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXONAD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXONAD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXONAD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPDONATIONNONAPPR.ToString, True, rowx("EXONAD_EXONADKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("other_exnapprdonation").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_OTHER_EXNAPPRDONATION_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXNAPPRDONATION_DETAIL").NewRow
                                dtRow("EXONADD_KEY") = rowx("EXONADD_KEY")
                                dtRow("EXONADD_EXONADKEY") = rowx("EXONADD_EXONADKEY")
                                dtRow("EXONADD_SOURCENO") = rowx("EXONADD_SOURCENO")
                                dtRow("EXONADD_EXONADDKEY") = ds.Tables("OTHER_EXNAPPRDONATION_DETAIL").Rows.Count + 1
                                dtRow("EXONADD_DESC") = rowx("EXONADD_DESC")
                                If IsDBNull(rowx("EXONADD_DEDUCTIBLE")) = False AndAlso (rowx("EXONADD_DEDUCTIBLE") = "Yes" OrElse rowx("EXONADD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXONADD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXONADD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXONADD_AMOUNT") = rowx("EXONADD_AMOUNT")
                                dtRow("EXONADD_NOTE") = rowx("EXONADD_NOTE")
                                If IsDBNull(rowx("EXONADD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXONADD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXONADD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXONADD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXONADD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPDONATIONNONAPPR.ToString, False, rowx("EXONADD_EXONADKEY"), rowx("EXONADD_EXONADDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("OTHER_EXNAPPRDONATION_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPZAKAT
                    dt = Nothing
                    dt = ADO.Load_PNL_other_exzakat(PNL_KEY, Errorlog)

                    ds.Tables("OTHER_EXZAKAT_DETAIL").Rows.Clear()
                    ds.Tables("other_exzakat").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "other_exzakat", "EXOZ_EXOZKEY", rowx("EXOZ_EXOZKEY")) = False Then
                                dtRow = ds.Tables("other_exzakat").NewRow
                                dtRow("EXOZ_KEY") = rowx("EXOZ_KEY")
                                dtRow("EXOZ_EXOZKEY") = rowx("EXOZ_EXOZKEY")
                                dtRow("EXOZ_SOURCENO") = rowx("EXOZ_SOURCENO")
                                dtRow("EXOZ_DESC") = rowx("EXOZ_DESC")
                                dtRow("EXOZ_AMOUNT") = rowx("EXOZ_AMOUNT")
                                If IsDBNull(rowx("EXOZ_DEDUCTIBLE")) = False AndAlso (rowx("EXOZ_DEDUCTIBLE") = "Yes" OrElse rowx("EXOZ_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOZ_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOZ_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOZ_NOTE") = rowx("EXOZ_NOTE")
                                dtRow("EXOZ_DETAIL") = rowx("EXOZ_DETAIL")
                                If IsDBNull(rowx("EXOZ_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOZ_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOZ_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOZ_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOZ_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPZAKAT.ToString, True, rowx("EXOZ_EXOZKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("other_exzakat").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_OTHER_EXZAKAT_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXZAKAT_DETAIL").NewRow
                                dtRow("EXOZD_KEY") = rowx("EXOZD_KEY")
                                dtRow("EXOZD_EXOZKEY") = rowx("EXOZD_EXOZKEY")
                                dtRow("EXOZD_SOURCENO") = rowx("EXOZD_SOURCENO")
                                dtRow("EXOZD_EXOZDKEY") = ds.Tables("OTHER_EXZAKAT_DETAIL").Rows.Count + 1
                                dtRow("EXOZD_DESC") = rowx("EXOZD_DESC")
                                If IsDBNull(rowx("EXOZD_DEDUCTIBLE")) = False AndAlso (rowx("EXOZD_DEDUCTIBLE") = "Yes" OrElse rowx("EXOZD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOZD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOZD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOZD_AMOUNT") = rowx("EXOZD_AMOUNT")
                                dtRow("EXOZD_NOTE") = rowx("EXOZD_NOTE")
                                If IsDBNull(rowx("EXOZD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOZD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOZD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOZD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOZD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPZAKAT.ToString, False, rowx("EXOZD_EXOZKEY"), rowx("EXOZD_EXOZDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If

                                ds.Tables("OTHER_EXZAKAT_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPLOSSDISPFA
                    dt = Nothing
                    dt = ADO.Load_PNL_other_exlossdisposalfa(PNL_KEY, Errorlog)

                    ds.Tables("OTHER_EXLOSSDISPOSALFA_DETAIL").Rows.Clear()
                    ds.Tables("other_exlossdisposalfa").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "other_exlossdisposalfa", "EXOLD_EXOLDKEY", rowx("EXOLD_EXOLDKEY")) = False Then
                                dtRow = ds.Tables("other_exlossdisposalfa").NewRow
                                dtRow("EXOLD_KEY") = rowx("EXOLD_KEY")
                                dtRow("EXOLD_EXOLDKEY") = rowx("EXOLD_EXOLDKEY")
                                dtRow("EXOLD_SOURCENO") = rowx("EXOLD_SOURCENO")
                                dtRow("EXOLD_DESC") = rowx("EXOLD_DESC")
                                dtRow("EXOLD_AMOUNT") = rowx("EXOLD_AMOUNT")
                                If IsDBNull(rowx("EXOLD_DEDUCTIBLE")) = False AndAlso (rowx("EXOLD_DEDUCTIBLE") = "Yes" OrElse rowx("EXOLD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOLD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOLD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOLD_NOTE") = rowx("EXOLD_NOTE")
                                dtRow("EXOLD_DETAIL") = rowx("EXOLD_DETAIL")
                                If IsDBNull(rowx("EXOLD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOLD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOLD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOLD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOLD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPLOSSDISPFA.ToString, True, rowx("EXOLD_EXOLDKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("other_exlossdisposalfa").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_OTHER_EXLOSSDISPOSALFA_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXLOSSDISPOSALFA_DETAIL").NewRow
                                dtRow("EXOLDD_KEY") = rowx("EXOLDD_KEY")
                                dtRow("EXOLDD_EXOLDKEY") = rowx("EXOLDD_EXOLDKEY")
                                dtRow("EXOLDD_SOURCENO") = rowx("EXOLDD_SOURCENO")
                                dtRow("EXOLDD_EXOLDDKEY") = ds.Tables("OTHER_EXLOSSDISPOSALFA_DETAIL").Rows.Count + 1
                                dtRow("EXOLDD_DESC") = rowx("EXOLDD_DESC")
                                If IsDBNull(rowx("EXOLDD_DEDUCTIBLE")) = False AndAlso (rowx("EXOLDD_DEDUCTIBLE") = "Yes" OrElse rowx("EXOLDD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOLDD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOLDD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOLDD_AMOUNT") = rowx("EXOLDD_AMOUNT")
                                dtRow("EXOLDD_NOTE") = rowx("EXOLDD_NOTE")
                                If IsDBNull(rowx("EXOLDD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOLDD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOLDD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOLDD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOLDD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPLOSSDISPFA.ToString, False, rowx("EXOLDD_EXOLDKEY"), rowx("EXOLDD_EXOLDDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("OTHER_EXLOSSDISPOSALFA_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPENTERTAINNONSTAFF
                    dt = Nothing
                    dt = ADO.Load_PNL_other_entertainnstaff(PNL_KEY, Errorlog)

                    ds.Tables("OTHER_ENTERTAINNSTAFF_DETAIL").Rows.Clear()
                    ds.Tables("other_entertainnstaff").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "other_entertainnstaff", "EXOENS_EXOENSKEY", rowx("EXOENS_EXOENSKEY")) = False Then
                                dtRow = ds.Tables("other_entertainnstaff").NewRow
                                dtRow("EXOENS_KEY") = rowx("EXOENS_KEY")
                                dtRow("EXOENS_EXOENSKEY") = rowx("EXOENS_EXOENSKEY")
                                dtRow("EXOENS_SOURCENO") = rowx("EXOENS_SOURCENO")
                                dtRow("EXOENS_DESC") = rowx("EXOENS_DESC")
                                dtRow("EXOENS_AMOUNT") = rowx("EXOENS_AMOUNT")
                                If IsDBNull(rowx("EXOENS_DEDUCTIBLE")) = False AndAlso (rowx("EXOENS_DEDUCTIBLE") = "Yes" OrElse rowx("EXOENS_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOENS_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOENS_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOENS_NOTE") = rowx("EXOENS_NOTE")
                                dtRow("EXOENS_DETAIL") = rowx("EXOENS_DETAIL")
                                If IsDBNull(rowx("EXOENS_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOENS_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOENS_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOENS_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOENS_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPENTERTAINNONSTAFF.ToString, True, rowx("EXOENS_EXOENSKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("other_entertainnstaff").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_OTHER_ENTERTAINNSTAFF_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_ENTERTAINNSTAFF_DETAIL").NewRow
                                dtRow("EXOENSD_KEY") = rowx("EXOENSD_KEY")
                                dtRow("EXOENSD_EXOENSKEY") = rowx("EXOENSD_EXOENSKEY")
                                dtRow("EXOENSD_SOURCENO") = rowx("EXOENSD_SOURCENO")
                                dtRow("EXOENSD_EXOENSDKEY") = ds.Tables("OTHER_ENTERTAINNSTAFF_DETAIL").Rows.Count + 1
                                dtRow("EXOENSD_DESC") = rowx("EXOENSD_DESC")
                                If IsDBNull(rowx("EXOENSD_DEDUCTIBLE")) = False AndAlso (rowx("EXOENSD_DEDUCTIBLE") = "Yes" OrElse rowx("EXOENSD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOENSD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOENSD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOENSD_AMOUNT") = rowx("EXOENSD_AMOUNT")
                                dtRow("EXOENSD_NOTE") = rowx("EXOENSD_NOTE")
                                If IsDBNull(rowx("EXOENSD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOENSD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOENSD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOENSD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOENSD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPENTERTAINNONSTAFF.ToString, False, rowx("EXOENSD_EXOENSKEY"), rowx("EXOENSD_EXOENSDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If

                                ds.Tables("OTHER_ENTERTAINNSTAFF_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPENTERTAINSTAFF
                    dt = Nothing
                    dt = ADO.Load_PNL_OTHER_ENTERTAINSTAFF(PNL_KEY, Errorlog)

                    ds.Tables("OTHER_ENTERTAINSTAFF_DETAIL").Rows.Clear()
                    ds.Tables("OTHER_ENTERTAINSTAFF").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "OTHER_ENTERTAINSTAFF", "EXOES_EXOESKEY", rowx("EXOES_EXOESKEY")) = False Then
                                dtRow = ds.Tables("OTHER_ENTERTAINSTAFF").NewRow
                                dtRow("EXOES_KEY") = rowx("EXOES_KEY")
                                dtRow("EXOES_EXOESKEY") = rowx("EXOES_EXOESKEY")
                                dtRow("EXOES_SOURCENO") = rowx("EXOES_SOURCENO")
                                dtRow("EXOES_DESC") = rowx("EXOES_DESC")
                                dtRow("EXOES_AMOUNT") = rowx("EXOES_AMOUNT")
                                If IsDBNull(rowx("EXOES_DEDUCTIBLE")) = False AndAlso (rowx("EXOES_DEDUCTIBLE") = "Yes" OrElse rowx("EXOES_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOES_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOES_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOES_NOTE") = rowx("EXOES_NOTE")
                                dtRow("EXOES_DETAIL") = rowx("EXOES_DETAIL")
                                If IsDBNull(rowx("EXOES_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOES_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOES_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOES_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOES_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPENTERTAINSTAFF.ToString, True, rowx("EXOES_EXOESKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("OTHER_ENTERTAINSTAFF").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_OTHER_ENTERTAINSTAFF_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_ENTERTAINSTAFF_DETAIL").NewRow
                                dtRow("EXOESD_KEY") = rowx("EXOESD_KEY")
                                dtRow("EXOESD_EXOESKEY") = rowx("EXOESD_EXOESKEY")
                                dtRow("EXOESD_SOURCENO") = rowx("EXOESD_SOURCENO")
                                dtRow("EXOESD_EXOESDKEY") = ds.Tables("OTHER_ENTERTAINSTAFF_DETAIL").Rows.Count + 1
                                dtRow("EXOESD_DESC") = rowx("EXOESD_DESC")
                                If IsDBNull(rowx("EXOESD_DEDUCTIBLE")) = False AndAlso (rowx("EXOESD_DEDUCTIBLE") = "Yes" OrElse rowx("EXOESD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOESD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOESD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOESD_AMOUNT") = rowx("EXOESD_AMOUNT")
                                dtRow("EXOESD_NOTE") = rowx("EXOESD_NOTE")
                                If IsDBNull(rowx("EXOESD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOESD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOESD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOESD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOESD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPENTERTAINSTAFF.ToString, False, rowx("EXOESD_EXOESKEY"), rowx("EXOESD_EXOESDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("OTHER_ENTERTAINSTAFF_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPCOMPAUNDPENALTY
                    dt = Nothing
                    dt = ADO.Load_PNL_other_expenalty(PNL_KEY, Errorlog)

                    ds.Tables("OTHER_EXPENALTY_DETAIL").Rows.Clear()
                    ds.Tables("other_expenalty").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "other_expenalty", "EXOP_EXOPKEY", rowx("EXOP_EXOPKEY")) = False Then
                                dtRow = ds.Tables("other_expenalty").NewRow
                                dtRow("EXOP_KEY") = rowx("EXOP_KEY")
                                dtRow("EXOP_EXOPKEY") = rowx("EXOP_EXOPKEY")
                                dtRow("EXOP_SOURCENO") = rowx("EXOP_SOURCENO")
                                dtRow("EXOP_DESC") = rowx("EXOP_DESC")
                                dtRow("EXOP_AMOUNT") = rowx("EXOP_AMOUNT")
                                If IsDBNull(rowx("EXOP_DEDUCTIBLE")) = False AndAlso (rowx("EXOP_DEDUCTIBLE") = "Yes" OrElse rowx("EXOP_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOP_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOP_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOP_NOTE") = rowx("EXOP_NOTE")
                                dtRow("EXOP_DETAIL") = rowx("EXOP_DETAIL")
                                If IsDBNull(rowx("EXOP_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOP_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOP_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOP_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOP_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPCOMPAUNDPENALTY.ToString, True, rowx("EXOP_EXOPKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("other_expenalty").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_OTHER_EXPENALTY_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXPENALTY_DETAIL").NewRow
                                dtRow("EXOPD_KEY") = rowx("EXOPD_KEY")
                                dtRow("EXOPD_EXOPKEY") = rowx("EXOPD_EXOPKEY")
                                dtRow("EXOPD_SOURCENO") = rowx("EXOPD_SOURCENO")
                                dtRow("EXOPD_EXOPDKEY") = ds.Tables("OTHER_EXPENALTY_DETAIL").Rows.Count + 1
                                dtRow("EXOPD_DESC") = rowx("EXOPD_DESC")
                                If IsDBNull(rowx("EXOPD_DEDUCTIBLE")) = False AndAlso (rowx("EXOPD_DEDUCTIBLE") = "Yes" OrElse rowx("EXOPD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOPD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOPD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOPD_AMOUNT") = rowx("EXOPD_AMOUNT")
                                dtRow("EXOPD_NOTE") = rowx("EXOPD_NOTE")
                                If IsDBNull(rowx("EXOPD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOPD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOPD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOPD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOPD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPCOMPAUNDPENALTY.ToString, False, rowx("EXOPD_EXOPKEY"), rowx("EXOPD_EXOPDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("OTHER_EXPENALTY_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPPROVISION
                    dt = Nothing
                    dt = ADO.Load_PNL_other_exprovisionacc(PNL_KEY, Errorlog)

                    ds.Tables("OTHER_EXPROVISIONACC_DETAIL").Rows.Clear()
                    ds.Tables("other_exprovisionacc").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "other_exprovisionacc", "EXOPA_EXOPAKEY", rowx("EXOPA_EXOPAKEY")) = False Then
                                dtRow = ds.Tables("other_exprovisionacc").NewRow
                                dtRow("EXOPA_KEY") = rowx("EXOPA_KEY")
                                dtRow("EXOPA_EXOPAKEY") = rowx("EXOPA_EXOPAKEY")
                                dtRow("EXOPA_SOURCENO") = rowx("EXOPA_SOURCENO")
                                dtRow("EXOPA_DESC") = rowx("EXOPA_DESC")
                                dtRow("EXOPA_AMOUNT") = rowx("EXOPA_AMOUNT")
                                If IsDBNull(rowx("EXOPA_DEDUCTIBLE")) = False AndAlso (rowx("EXOPA_DEDUCTIBLE") = "Yes" OrElse rowx("EXOPA_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOPA_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOPA_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOPA_NOTE") = rowx("EXOPA_NOTE")
                                dtRow("EXOPA_DETAIL") = rowx("EXOPA_DETAIL")
                                If IsDBNull(rowx("EXOPA_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOPA_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOPA_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOPA_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOPA_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPPROVISION.ToString, True, rowx("EXOPA_EXOPAKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("other_exprovisionacc").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_OTHER_EXPROVISIONACC_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXPROVISIONACC_DETAIL").NewRow
                                dtRow("EXOPAD_KEY") = rowx("EXOPAD_KEY")
                                dtRow("EXOPAD_EXOPAKEY") = rowx("EXOPAD_EXOPAKEY")
                                dtRow("EXOPAD_SOURCENO") = rowx("EXOPAD_SOURCENO")
                                dtRow("EXOPAD_EXOPADKEY") = ds.Tables("OTHER_EXPROVISIONACC_DETAIL").Rows.Count + 1
                                dtRow("EXOPAD_DESC") = rowx("EXOPAD_DESC")
                                If IsDBNull(rowx("EXOPAD_DEDUCTIBLE")) = False AndAlso (rowx("EXOPAD_DEDUCTIBLE") = "Yes" OrElse rowx("EXOPAD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOPAD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOPAD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOPAD_AMOUNT") = rowx("EXOPAD_AMOUNT")
                                dtRow("EXOPAD_NOTE") = rowx("EXOPAD_NOTE")
                                If IsDBNull(rowx("EXOPAD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOPAD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOPAD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOPAD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOPAD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPPROVISION.ToString, False, rowx("EXOPAD_EXOPAKEY"), rowx("EXOPAD_EXOPADKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("OTHER_EXPROVISIONACC_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPLEAVEPASSAGE
                    dt = Nothing
                    dt = ADO.Load_PNL_other_exleavepassage(PNL_KEY, Errorlog)

                    ds.Tables("OTHER_EXLEAVEPASSAGE_DETAIL").Rows.Clear()
                    ds.Tables("other_exleavepassage").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "other_exleavepassage", "EXOLP_EXOLPKEY", rowx("EXOLP_EXOLPKEY")) = False Then
                                dtRow = ds.Tables("other_exleavepassage").NewRow
                                dtRow("EXOLP_KEY") = rowx("EXOLP_KEY")
                                dtRow("EXOLP_EXOLPKEY") = rowx("EXOLP_EXOLPKEY")
                                dtRow("EXOLP_SOURCENO") = rowx("EXOLP_SOURCENO")
                                dtRow("EXOLP_DESC") = rowx("EXOLP_DESC")
                                dtRow("EXOLP_AMOUNT") = rowx("EXOLP_AMOUNT")
                                If IsDBNull(rowx("EXOLP_DEDUCTIBLE")) = False AndAlso (rowx("EXOLP_DEDUCTIBLE") = "Yes" OrElse rowx("EXOLP_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOLP_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOLP_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOLP_NOTE") = rowx("EXOLP_NOTE")
                                dtRow("EXOLP_DETAIL") = rowx("EXOLP_DETAIL")
                                If IsDBNull(rowx("EXOLP_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOLP_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOLP_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOLP_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOLP_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPLEAVEPASSAGE.ToString, True, rowx("EXOLP_EXOLPKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("other_exleavepassage").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_OTHER_EXLEAVEPASSAGE_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXLEAVEPASSAGE_DETAIL").NewRow
                                dtRow("EXOLPD_KEY") = rowx("EXOLPD_KEY")
                                dtRow("EXOLPD_EXOLPKEY") = rowx("EXOLPD_EXOLPKEY")
                                dtRow("EXOLPD_SOURCENO") = rowx("EXOLPD_SOURCENO")
                                dtRow("EXOLPD_EXOLPDKEY") = ds.Tables("OTHER_EXLEAVEPASSAGE_DETAIL").Rows.Count + 1
                                dtRow("EXOLPD_DESC") = rowx("EXOLPD_DESC")
                                If IsDBNull(rowx("EXOLPD_DEDUCTIBLE")) = False AndAlso (rowx("EXOLPD_DEDUCTIBLE") = "Yes" OrElse rowx("EXOLPD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOLPD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOLPD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOLPD_AMOUNT") = rowx("EXOLPD_AMOUNT")
                                dtRow("EXOLPD_NOTE") = rowx("EXOLPD_NOTE")
                                If IsDBNull(rowx("EXOLPD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOLPD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOLPD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOLPD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOLPD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPLEAVEPASSAGE.ToString, False, rowx("EXOLPD_EXOLPKEY"), rowx("EXOLPD_EXOLPDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("OTHER_EXLEAVEPASSAGE_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPFAWRITTENOFF
                    dt = Nothing
                    dt = ADO.Load_PNL_other_exfawrittenoff(PNL_KEY, Errorlog)

                    ds.Tables("OTHER_EXFAWRITTENOFF_DETAIL").Rows.Clear()
                    ds.Tables("other_exfawrittenoff").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "other_exfawrittenoff", "EXOWO_EXOWOKEY", rowx("EXOWO_EXOWOKEY")) = False Then
                                dtRow = ds.Tables("other_exfawrittenoff").NewRow
                                dtRow("EXOWO_KEY") = rowx("EXOWO_KEY")
                                dtRow("EXOWO_EXOWOKEY") = rowx("EXOWO_EXOWOKEY")
                                dtRow("EXOWO_SOURCENO") = rowx("EXOWO_SOURCENO")
                                dtRow("EXOWO_DESC") = rowx("EXOWO_DESC")
                                dtRow("EXOWO_AMOUNT") = rowx("EXOWO_AMOUNT")
                                If IsDBNull(rowx("EXOWO_DEDUCTIBLE")) = False AndAlso (rowx("EXOWO_DEDUCTIBLE") = "Yes" OrElse rowx("EXOWO_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOWO_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOWO_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOWO_NOTE") = rowx("EXOWO_NOTE")
                                dtRow("EXOWO_DETAIL") = rowx("EXOWO_DETAIL")
                                If IsDBNull(rowx("EXOWO_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOWO_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOWO_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOWO_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOWO_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPFAWRITTENOFF.ToString, True, rowx("EXOWO_EXOWOKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("other_exfawrittenoff").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_OTHER_EXFAWRITTENOFF_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXFAWRITTENOFF_DETAIL").NewRow
                                dtRow("EXOWOD_KEY") = rowx("EXOWOD_KEY")
                                dtRow("EXOWOD_EXOWOKEY") = rowx("EXOWOD_EXOWOKEY")
                                dtRow("EXOWOD_SOURCENO") = rowx("EXOWOD_SOURCENO")
                                dtRow("EXOWOD_EXOWODKEY") = ds.Tables("OTHER_EXFAWRITTENOFF_DETAIL").Rows.Count + 1
                                dtRow("EXOWOD_DESC") = rowx("EXOWOD_DESC")
                                If IsDBNull(rowx("EXOWOD_DEDUCTIBLE")) = False AndAlso (rowx("EXOWOD_DEDUCTIBLE") = "Yes" OrElse rowx("EXOWOD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOWOD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOWOD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOWOD_AMOUNT") = rowx("EXOWOD_AMOUNT")
                                dtRow("EXOWOD_NOTE") = rowx("EXOWOD_NOTE")
                                If IsDBNull(rowx("EXOWOD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOWOD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOWOD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOWOD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOWOD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPFAWRITTENOFF.ToString, False, rowx("EXOWOD_EXOWOKEY"), rowx("EXOWOD_EXOWODKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("OTHER_EXFAWRITTENOFF_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPUNREALLOSSFE
                    dt = Nothing
                    dt = ADO.Load_PNL_other_exurlossforeign(PNL_KEY, Errorlog)

                    ds.Tables("OTHER_EXURLOSSFOREIGN_DETAIL").Rows.Clear()
                    ds.Tables("other_exurlossforeign").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "other_exurlossforeign", "EXOUR_EXOURKEY", rowx("EXOUR_EXOURKEY")) = False Then
                                dtRow = ds.Tables("other_exurlossforeign").NewRow
                                dtRow("EXOUR_KEY") = rowx("EXOUR_KEY")
                                dtRow("EXOUR_EXOURKEY") = rowx("EXOUR_EXOURKEY")
                                dtRow("EXOUR_SOURCENO") = rowx("EXOUR_SOURCENO")
                                dtRow("EXOUR_DESC") = rowx("EXOUR_DESC")
                                dtRow("EXOUR_AMOUNT") = rowx("EXOUR_AMOUNT")
                                If IsDBNull(rowx("EXOUR_DEDUCTIBLE")) = False AndAlso (rowx("EXOUR_DEDUCTIBLE") = "Yes" OrElse rowx("EXOUR_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOUR_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOUR_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOUR_NOTE") = rowx("EXOUR_NOTE")
                                dtRow("EXOUR_DETAIL") = rowx("EXOUR_DETAIL")
                                If IsDBNull(rowx("EXOUR_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOUR_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOUR_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOUR_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOUR_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPUNREALLOSSFE.ToString, True, rowx("EXOUR_EXOURKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("other_exurlossforeign").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_OTHER_EXURLOSSFOREIGN_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing

                                dtRow = ds.Tables("OTHER_EXURLOSSFOREIGN_DETAIL").NewRow
                                dtRow("EXOURD_KEY") = rowx("EXOURD_KEY")
                                dtRow("EXOURD_EXOURKEY") = rowx("EXOURD_EXOURKEY")
                                dtRow("EXOURD_SOURCENO") = rowx("EXOURD_SOURCENO")
                                dtRow("EXOURD_EXOURDKEY") = ds.Tables("OTHER_EXURLOSSFOREIGN_DETAIL").Rows.Count + 1
                                dtRow("EXOURD_DESC") = rowx("EXOURD_DESC")
                                If IsDBNull(rowx("EXOURD_DEDUCTIBLE")) = False AndAlso (rowx("EXOURD_DEDUCTIBLE") = "Yes" OrElse rowx("EXOURD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOURD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOURD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOURD_AMOUNT") = rowx("EXOURD_AMOUNT")
                                dtRow("EXOURD_NOTE") = rowx("EXOURD_NOTE")
                                If IsDBNull(rowx("EXOURD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOURD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOURD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOURD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOURD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPUNREALLOSSFE.ToString, False, rowx("EXOURD_EXOURKEY"), rowx("EXOURD_EXOURDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If

                                ds.Tables("OTHER_EXURLOSSFOREIGN_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPREALLOSSFETRADE
                    dt = Nothing
                    dt = ADO.Load_PNL_other_exrlossforeignt(PNL_KEY, Errorlog)

                    ds.Tables("OTHER_EXRLOSSFOREIGNT_DETAIL").Rows.Clear()
                    ds.Tables("other_exrlossforeignt").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtRow = ds.Tables("other_exrlossforeignt").NewRow
                            dtRow("EXORT_KEY") = rowx("EXORT_KEY")
                            dtRow("EXORT_EXORTKEY") = rowx("EXORT_EXORTKEY")
                            dtRow("EXORT_SOURCENO") = rowx("EXORT_SOURCENO")
                            dtRow("EXORT_DESC") = rowx("EXORT_DESC")
                            dtRow("EXORT_AMOUNT") = rowx("EXORT_AMOUNT")
                            If IsDBNull(rowx("EXORT_DEDUCTIBLE")) = False AndAlso (rowx("EXORT_DEDUCTIBLE") = "Yes" OrElse rowx("EXORT_DEDUCTIBLE") = "True") Then
                                dtRow("EXORT_DEDUCTIBLE") = True
                            Else
                                dtRow("EXORT_DEDUCTIBLE") = False
                            End If
                            dtRow("EXORT_NOTE") = rowx("EXORT_NOTE")
                            dtRow("EXORT_DETAIL") = rowx("EXORT_DETAIL")
                            If IsDBNull(rowx("EXORT_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXORT_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXORT_DEDUCTIBLE_ADD") = "True") Then
                                dtRow("EXORT_DEDUCTIBLE_ADD") = True
                            Else
                                dtRow("EXORT_DEDUCTIBLE_ADD") = False
                            End If
                            dtRow("RowIndex") = rowx("RowIndex")
                            dtRow("Pecentage") = rowx("Pecentage")
                            dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                            If isPrint AndAlso clsNote IsNot Nothing Then
                                dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPREALLOSSFETRADE.ToString, True, rowx("EXORT_EXORTKEY"), -1, Errorlog)

                                If dtNote IsNot Nothing Then
                                    NoteOrder += 1

                                    dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                End If
                            End If
                            ds.Tables("other_exrlossforeignt").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_OTHER_EXRLOSSFOREIGNT_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXRLOSSFOREIGNT_DETAIL").NewRow
                                dtRow("EXORTD_KEY") = rowx("EXORTD_KEY")
                                dtRow("EXORTD_EXORTKEY") = rowx("EXORTD_EXORTKEY")
                                dtRow("EXORTD_SOURCENO") = rowx("EXORTD_SOURCENO")
                                dtRow("EXORTD_EXORTDKEY") = ds.Tables("OTHER_EXRLOSSFOREIGNT_DETAIL").Rows.Count + 1
                                dtRow("EXORTD_DESC") = rowx("EXORTD_DESC")
                                If IsDBNull(rowx("EXORTD_DEDUCTIBLE")) = False AndAlso (rowx("EXORTD_DEDUCTIBLE") = "Yes" OrElse rowx("EXORTD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXORTD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXORTD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXORTD_AMOUNT") = rowx("EXORTD_AMOUNT")
                                dtRow("EXORTD_NOTE") = rowx("EXORTD_NOTE")
                                If IsDBNull(rowx("EXORTD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXORTD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXORTD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXORTD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXORTD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPREALLOSSFETRADE.ToString, False, rowx("EXORTD_EXORTKEY"), rowx("EXORTD_EXORTDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("OTHER_EXRLOSSFOREIGNT_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPREALLOSSFENONTRADE
                    dt = Nothing
                    dt = ADO.Load_PNL_other_exrlossforeign(PNL_KEY, Errorlog)

                    ds.Tables("OTHER_EXRLOSSFOREIGN_DETAIL").Rows.Clear()
                    ds.Tables("other_exrlossforeign").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "other_exrlossforeign", "EXOR_EXORKEY", rowx("EXOR_EXORKEY")) = False Then
                                dtRow = ds.Tables("other_exrlossforeign").NewRow
                                dtRow("EXOR_KEY") = rowx("EXOR_KEY")
                                dtRow("EXOR_EXORKEY") = rowx("EXOR_EXORKEY")
                                dtRow("EXOR_SOURCENO") = rowx("EXOR_SOURCENO")
                                dtRow("EXOR_DESC") = rowx("EXOR_DESC")
                                dtRow("EXOR_AMOUNT") = rowx("EXOR_AMOUNT")
                                If IsDBNull(rowx("EXOR_DEDUCTIBLE")) = False AndAlso (rowx("EXOR_DEDUCTIBLE") = "Yes" OrElse rowx("EXOR_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOR_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOR_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOR_NOTE") = rowx("EXOR_NOTE")
                                dtRow("EXOR_DETAIL") = rowx("EXOR_DETAIL")
                                If IsDBNull(rowx("EXOR_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOR_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOR_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOR_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOR_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPREALLOSSFENONTRADE.ToString, True, rowx("EXOR_EXORKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("other_exrlossforeign").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_OTHER_EXRLOSSFOREIGN_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXRLOSSFOREIGN_DETAIL").NewRow
                                dtRow("EXORD_KEY") = rowx("EXORD_KEY")
                                dtRow("EXORD_EXORKEY") = rowx("EXORD_EXORKEY")
                                dtRow("EXORD_SOURCENO") = rowx("EXORD_SOURCENO")
                                dtRow("EXORD_EXORDKEY") = ds.Tables("OTHER_EXRLOSSFOREIGN_DETAIL").Rows.Count + 1
                                dtRow("EXORD_DESC") = rowx("EXORD_DESC")
                                If IsDBNull(rowx("EXORD_DEDUCTIBLE")) = False AndAlso (rowx("EXORD_DEDUCTIBLE") = "Yes" OrElse rowx("EXORD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXORD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXORD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXORD_AMOUNT") = rowx("EXORD_AMOUNT")
                                dtRow("EXORD_NOTE") = rowx("EXORD_NOTE")
                                If IsDBNull(rowx("EXORD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXORD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXORD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXORD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXORD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPREALLOSSFENONTRADE.ToString, False, rowx("EXORD_EXORKEY"), rowx("EXORD_EXORDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If

                                ds.Tables("OTHER_EXRLOSSFOREIGN_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPINITIALSUBSCRIPT
                    dt = Nothing
                    dt = ADO.Load_PNL_other_exinitialsub(PNL_KEY, Errorlog)

                    ds.Tables("OTHER_EXINITIALSUB_DETAIL").Rows.Clear()
                    ds.Tables("other_exinitialsub").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "other_exinitialsub", "EXOIS_EXOISKEY", rowx("EXOIS_EXOISKEY")) = False Then
                                dtRow = ds.Tables("other_exinitialsub").NewRow
                                dtRow("EXOIS_KEY") = rowx("EXOIS_KEY")
                                dtRow("EXOIS_EXOISKEY") = rowx("EXOIS_EXOISKEY")
                                dtRow("EXOIS_SOURCENO") = rowx("EXOIS_SOURCENO")
                                dtRow("EXOIS_DESC") = rowx("EXOIS_DESC")
                                dtRow("EXOIS_AMOUNT") = rowx("EXOIS_AMOUNT")
                                If IsDBNull(rowx("EXOIS_DEDUCTIBLE")) = False AndAlso (rowx("EXOIS_DEDUCTIBLE") = "Yes" OrElse rowx("EXOIS_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOIS_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOIS_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOIS_NOTE") = rowx("EXOIS_NOTE")
                                dtRow("EXOIS_DETAIL") = rowx("EXOIS_DETAIL")
                                If IsDBNull(rowx("EXOIS_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOIS_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOIS_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOIS_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOIS_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPINITIALSUBSCRIPT.ToString, True, rowx("EXOIS_EXOISKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("other_exinitialsub").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_OTHER_EXINITIALSUB_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXINITIALSUB_DETAIL").NewRow
                                dtRow("EXOISD_KEY") = rowx("EXOISD_KEY")
                                dtRow("EXOISD_EXOISKEY") = rowx("EXOISD_EXOISKEY")
                                dtRow("EXOISD_SOURCENO") = rowx("EXOISD_SOURCENO")
                                dtRow("EXOISD_EXOISDKEY") = ds.Tables("OTHER_EXINITIALSUB_DETAIL").Rows.Count + 1
                                dtRow("EXOISD_DESC") = rowx("EXOISD_DESC")
                                If IsDBNull(rowx("EXOISD_DEDUCTIBLE")) = False AndAlso (rowx("EXOISD_DEDUCTIBLE") = "Yes" OrElse rowx("EXOISD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOISD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOISD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOISD_AMOUNT") = rowx("EXOISD_AMOUNT")
                                dtRow("EXOISD_NOTE") = rowx("EXOISD_NOTE")
                                If IsDBNull(rowx("EXOISD_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOISD_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOISD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOISD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOISD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPINITIALSUBSCRIPT.ToString, False, rowx("EXOISD_EXOISKEY"), rowx("EXOISD_EXOISDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("OTHER_EXINITIALSUB_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPCAPITALEXPENDITURE
                    dt = Nothing
                    dt = ADO.Load_PNL_other_excapitalexp(PNL_KEY, Errorlog)

                    ds.Tables("OTHER_EXCAPITALEXP_DETAIL").Rows.Clear()
                    ds.Tables("other_excapitalexp").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "other_excapitalexp", "EXOCE_EXOCEKEY", rowx("EXOCE_EXOCEKEY")) = False Then
                                dtRow = ds.Tables("other_excapitalexp").NewRow
                                dtRow("EXOCE_KEY") = rowx("EXOCE_KEY")
                                dtRow("EXOCE_EXOCEKEY") = rowx("EXOCE_EXOCEKEY")
                                dtRow("EXOCE_SOURCENO") = rowx("EXOCE_SOURCENO")
                                dtRow("EXOCE_DESC") = rowx("EXOCE_DESC")
                                dtRow("EXOCE_AMOUNT") = rowx("EXOCE_AMOUNT")
                                If IsDBNull(rowx("EXOCE_DEDUCTIBLE")) = False AndAlso (rowx("EXOCE_DEDUCTIBLE") = "Yes" OrElse rowx("EXOCE_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOCE_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOCE_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOCE_NOTE") = rowx("EXOCE_NOTE")
                                dtRow("EXOCE_DETAIL") = rowx("EXOCE_DETAIL")
                                If IsDBNull(rowx("EXOCE_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOCE_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOCE_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOCE_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOCE_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPCAPITALEXPENDITURE.ToString, True, rowx("EXOCE_EXOCEKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("other_excapitalexp").Rows.Add(dtRow)
                            End If

                        Next
                        dt = Nothing

                        dt = ADO.Load_PNL_OTHER_EXCAPITALEXP_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing

                                dtRow = ds.Tables("OTHER_EXCAPITALEXP_DETAIL").NewRow
                                dtRow("EXOCED_KEY") = rowx("EXOCED_KEY")
                                dtRow("EXOCED_EXOCEKEY") = rowx("EXOCED_EXOCEKEY")
                                dtRow("EXOCED_SOURCENO") = rowx("EXOCED_SOURCENO")
                                dtRow("EXOCED_EXOCEDKEY") = ds.Tables("OTHER_EXCAPITALEXP_DETAIL").Rows.Count + 1
                                dtRow("EXOCED_DESC") = rowx("EXOCED_DESC")
                                If IsDBNull(rowx("EXOCED_DEDUCTIBLE")) = False AndAlso (rowx("EXOCED_DEDUCTIBLE") = "Yes" OrElse rowx("EXOCED_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOCED_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOCED_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOCED_AMOUNT") = rowx("EXOCED_AMOUNT")
                                dtRow("EXOCED_NOTE") = rowx("EXOCED_NOTE")
                                If IsDBNull(rowx("EXOCED_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXOCED_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXOCED_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOCED_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOCED_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPCAPITALEXPENDITURE.ToString, False, rowx("EXOCED_EXOCEKEY"), rowx("EXOCED_EXOCEDKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("OTHER_EXCAPITALEXP_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
                    dt = Nothing

                    dt = ADO.Load_PNL_other_expenses(PNL_KEY, Errorlog)
                    ds.Tables("OTHER_EXPENSES_DETAIL").Rows.Clear()
                    ds.Tables("other_expenses").Rows.Clear()

                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            dtRow = Nothing
                            dtChild = Nothing
                            If mdlPNL2.CheckIDExistInTable(ds, "other_expenses", "EXO_EXOKEY", rowx("EXO_EXOKEY")) = False Then
                                dtChild = mdlPNL2.Load_DT_Deduct(rowx("EXO_KEY"), rowx("EXO_EXOKEY"), Type, Errorlog)

                                dtRow = ds.Tables("other_expenses").NewRow
                                dtRow("EXO_KEY") = rowx("EXO_KEY")
                                dtRow("EXO_EXOKEY") = rowx("EXO_EXOKEY")
                                dtRow("EXO_DESC") = rowx("EXO_DESC")
                                dtRow("EXO_AMOUNT") = rowx("EXO_AMOUNT")

                                If dtChild IsNot Nothing Then
                                    If IsDBNull(dtChild.Rows(0)("EXO_DEDUCTIBLE")) = False AndAlso (dtChild.Rows(0)("EXO_DEDUCTIBLE") = "Yes" OrElse dtChild.Rows(0)("EXO_DEDUCTIBLE") = "True") Then
                                        dtRow("EXO_DEDUCTIBLE") = True
                                    Else
                                        dtRow("EXO_DEDUCTIBLE") = False
                                    End If
                                    If IsDBNull(dtChild.Rows(0)("EXO_DEDUCTIBLE_ADD")) = False AndAlso (dtChild.Rows(0)("EXO_DEDUCTIBLE_ADD") = "Yes" OrElse dtChild.Rows(0)("EXO_DEDUCTIBLE_ADD") = "True") Then
                                        dtRow("EXO_DEDUCTIBLE_ADD") = True
                                    Else
                                        dtRow("EXO_DEDUCTIBLE_ADD") = False
                                    End If
                                Else
                                    dtRow("EXO_DEDUCTIBLE") = False
                                    dtRow("EXO_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("EXO_NOTE") = rowx("EXO_NOTE")
                                dtRow("EXO_SOURCENO") = rowx("EXO_SOURCENO")
                                dtRow("EXO_DETAIL") = rowx("EXO_DETAIL")
                                dtRow("RowIndex") = rowx("RowIndex")
                                dtRow("Pecentage") = rowx("Pecentage")
                                dtRow("PecentageAmount") = IIf(IsDBNull(rowx("PecentageAmount")), 0, rowx("PecentageAmount"))
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPOTHERSEXPENSES.ToString, True, rowx("EXO_EXOKEY"), -1, Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If
                                ds.Tables("other_expenses").Rows.Add(dtRow)


                            End If


                        Next

                        dt = Nothing

                        dt = ADO.Load_PNL_OTHER_EXPENSES_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowC As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("OTHER_EXPENSES_DETAIL").NewRow
                                dtRow("EXOD_KEY") = rowC("EXOD_KEY")
                                dtRow("EXOD_EXOKEY") = rowC("EXOD_EXOKEY")
                                dtRow("EXOD_SOURCENO") = rowC("EXOD_SOURCENO")
                                dtRow("EXOD_EXODKEY") = ds.Tables("OTHER_EXPENSES_DETAIL").Rows.Count + 1
                                dtRow("EXOD_DESC") = rowC("EXOD_DESC")
                                If IsDBNull(rowC("EXOD_DEDUCTIBLE")) = False AndAlso (rowC("EXOD_DEDUCTIBLE") = "Yes" OrElse rowC("EXOD_DEDUCTIBLE") = "True") Then
                                    dtRow("EXOD_DEDUCTIBLE") = True
                                Else
                                    dtRow("EXOD_DEDUCTIBLE") = False
                                End If
                                dtRow("EXOD_AMOUNT") = rowC("EXOD_AMOUNT")
                                dtRow("EXOD_NOTE") = rowC("EXOD_NOTE")
                                If IsDBNull(rowC("EXOD_DEDUCTIBLE_ADD")) = False AndAlso (rowC("EXOD_DEDUCTIBLE_ADD") = "Yes" OrElse rowC("EXOD_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXOD_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXOD_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowC("RowIndex")
                                dtRow("Pecentage") = rowC("Pecentage")
                                dtRow("PecentageAmount") = rowC("PecentageAmount")
                                If isPrint AndAlso clsNote IsNot Nothing Then
                                    dtNote = clsNote.Load_Note(PNL_KEY, TaxComPNLEnuItem.EXPOTHERSEXPENSES.ToString, False, rowC("EXOD_EXOKEY"), rowC("EXOD_EXODKEY"), Errorlog)

                                    If dtNote IsNot Nothing Then
                                        NoteOrder += 1

                                        dtRow("Note") = IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                                    End If
                                End If

                                ds.Tables("OTHER_EXPENSES_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
            End Select
            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If

            With Errorlog
                .ErrorCode = "XX1001"
                .ErrorMessage = strError & " | " & ex.Message
                .ErrorDateTime = Now
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
            End With
            AddListOfError(Errorlog)
            Return False
        End Try
    End Function
    Public Function Load_DT_Deduct(ByVal PNLKey As Integer, ByVal ID As Integer, ByVal Type As TaxComPNLEnuItem, Optional ByRef Errorlog As ClsError = Nothing) As DataTable
        Try
            Dim SQLCmd As SqlCommand = Nothing
            Dim strSQL As String = Nothing
            Select Case Type
                Case TaxComPNLEnuItem.PURCHASE
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 PLFPUR_DEDUCTIBLE FROM PLFST_PURCHASE WHERE PLFPUR_PLFPURKEY=@ID AND PLFPUR_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.DEPRECIATION
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXDEP_DEDUCTIBLE FROM EXPENSES_DEPRECIATION WHERE EXDEP_EXDEPKEY=@ID AND EXDEP_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.OTHERALLOWEXP
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXA_DEDUCTIBLE FROM EXPENSES_ALLOW WHERE EXA_EXAKEY=@ID AND EXA_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.OTHERNONALLOWEXP
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXNA_DEDUCTIBLE FROM EXPENSES_NONALLOW WHERE EXNA_EXNAKEY=@ID AND EXNA_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.INTERESTRESTRICT
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXIR_DEDUCTIBLE,EXIR_DEDUCTIBLE_ADD FROM EXPENSES_INTERESTRESTRICT WHERE EXIR_EXIRKEY=@ID AND EXIR_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPOTHERINTEREST
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXI_DEDUCTIBLE,EXI_DEDUCTIBLE_ADD FROM EXPENSES_INTEREST WHERE EXI_EXIKEY=@ID AND EXI_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPLEGAL
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXL_DEDUCTIBLE,EXL_DEDUCTIBLE_ADD FROM EXPENSES_LEGAL WHERE EXL_EXLKEY=@ID AND EXL_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPTECHNICAL
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXTF_DEDUCTIBLE,EXTF_DEDUCTIBLE_ADD FROM EXPENSES_TECH_FEE WHERE EXTF_EXTFKEY=@ID AND EXTF_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPCONTRACTPAY
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXC_DEDUCTIBLE,EXC_DEDUCTIBLE_ADD FROM EXPENSES_CONTRACT WHERE EXC_EXCKEY=@ID AND EXC_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPDIRECTORFEE
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXDF_DEDUCTIBLE,EXDF_DEDUCTIBLE_ADD FROM EXPENSES_DIRECTORS_FEE WHERE EXDF_EXDFKEY=@ID AND EXDF_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPSALARY
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXS_DEDUCTIBLE,EXS_DEDUCTIBLE_ADD FROM EXPENSES_SALARY WHERE EXS_EXSKEY=@ID AND EXS_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPEMPLOYEESTOCK
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXES_DEDUCTIBLE,EXES_DEDUCTIBLE_ADD FROM EXPENSES_EMPL_STOCK WHERE EXES_EXESKEY=@ID AND EXES_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPROYALTY
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXRO_DEDUCTIBLE,EXRO_DEDUCTIBLE_ADD FROM EXPENSES_ROYALTY WHERE EXRO_EXROKEY=@ID AND EXRO_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPRENTAL
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXRENT_DEDUCTIBLE,EXRENT_DEDUCTIBLE_ADD FROM EXPENSES_RENTAL WHERE EXRENT_EXRENTKEY=@ID AND EXRENT_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPREPAIRMAINTENANCE
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXREP_DEDUCTIBLE,EXREP_DEDUCTIBLE_ADD FROM EXPENSES_REPAIR WHERE EXREP_EXREPKEY=@ID AND EXREP_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPRND
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXRES_DEDUCTIBLE,EXRES_DEDUCTIBLE_ADD FROM EXPENSES_RESEARCH WHERE EXRES_EXRESKEY=@ID AND EXRES_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPADVERTISEMENT
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXP_DEDUCTIBLE,EXP_DEDUCTIBLE_ADD FROM EXPENSES_PROMOTE WHERE EXP_EXPKEY=@ID AND EXP_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPTRAVEL
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXT_DEDUCTIBLE,EXT_DEDUCTIBLE_ADD FROM EXPENSES_TRAVEL WHERE EXT_EXTKEY=@ID AND EXT_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPJKDM
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXJK_DEDUCTIBLE,EXJK_DEDUCTIBLE_ADD FROM EXPENSES_JKDM WHERE EXJK_EXJKKEY=@ID AND EXJK_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPDEPRECIATION
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXODEP_DEDUCTIBLE,EXODEP_DEDUCTIBLE_ADD FROM OTHER_EXDEPRECIATION WHERE EXODEP_EXODEPKEY=@ID AND EXODEP_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPDONATIONAPPR
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXOAD_DEDUCTIBLE,EXOAD_DEDUCTIBLE_ADD FROM OTHER_EXAPPRDONATION WHERE EXOAD_EXOADKEY=@ID AND EXOAD_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPDONATIONNONAPPR
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXONAD_DEDUCTIBLE,EXONAD_DEDUCTIBLE_ADD FROM OTHER_EXNAPPRDONATION WHERE EXONAD_EXONADKEY=@ID AND EXONAD_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPZAKAT
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXOZ_DEDUCTIBLE,EXOZ_DEDUCTIBLE_ADD FROM OTHER_EXZAKAT WHERE EXOZ_EXOZKEY=@ID AND EXOZ_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPLOSSDISPFA
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXOLD_DEDUCTIBLE,EXOLD_DEDUCTIBLE_ADD FROM OTHER_EXLOSSDISPOSALFA WHERE EXOLD_EXOLDKEY=@ID AND EXOLD_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPENTERTAINNONSTAFF
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXOENS_DEDUCTIBLE,EXOENS_DEDUCTIBLE_ADD FROM OTHER_ENTERTAINNSTAFF WHERE EXOENS_EXOENSKEY=@ID AND EXOENS_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPENTERTAINSTAFF
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXOES_DEDUCTIBLE,EXOES_DEDUCTIBLE_ADD FROM OTHER_ENTERTAINSTAFF WHERE EXOES_EXOESKEY=@ID AND EXOES_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPCOMPAUNDPENALTY
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXOP_DEDUCTIBLE,EXOP_DEDUCTIBLE_ADD FROM OTHER_EXPENALTY WHERE EXOP_EXOPKEY=@ID AND EXOP_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey


                Case TaxComPNLEnuItem.EXPPROVISION
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXOPA_DEDUCTIBLE,EXOPA_DEDUCTIBLE_ADD FROM OTHER_EXPROVISIONACC WHERE EXOPA_EXOPAKEY=@ID AND EXOPA_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPLEAVEPASSAGE
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXOLP_DEDUCTIBLE,EXOLP_DEDUCTIBLE_ADD FROM OTHER_EXLEAVEPASSAGE WHERE EXOLP_EXOLPKEY=@ID AND EXOLP_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPFAWRITTENOFF
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXOWO_DEDUCTIBLE,EXOWO_DEDUCTIBLE_ADD FROM OTHER_EXFAWRITTENOFF WHERE EXOWO_EXOWOKEY=@ID AND EXOWO_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPUNREALLOSSFE
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXOUR_DEDUCTIBLE,EXOUR_DEDUCTIBLE_ADD FROM OTHER_EXURLOSSFOREIGN WHERE EXOUR_EXOURKEY=@ID AND EXOUR_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPREALLOSSFETRADE
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXORT_DEDUCTIBLE,EXORT_DEDUCTIBLE_ADD FROM OTHER_EXRLOSSFOREIGNT WHERE EXORT_EXORTKEY=@ID AND EXORT_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPREALLOSSFENONTRADE
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXOR_DEDUCTIBLE,EXOR_DEDUCTIBLE_ADD FROM OTHER_EXRLOSSFOREIGN WHERE EXOR_EXORKEY=@ID AND EXOR_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

                Case TaxComPNLEnuItem.EXPINITIALSUBSCRIPT
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXOIS_DEDUCTIBLE,EXOIS_DEDUCTIBLE_ADD FROM OTHER_EXINITIALSUB WHERE EXOIS_EXOISKEY=@ID AND EXOIS_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey
                Case TaxComPNLEnuItem.EXPCAPITALEXPENDITURE
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXOCE_DEDUCTIBLE,EXOCE_DEDUCTIBLE_ADD FROM OTHER_EXCAPITALEXP WHERE EXOCE_EXOCEKEY=@ID AND EXOCE_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey
                Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    strSQL = "SELECT TOP 1 EXO_DEDUCTIBLE,EXO_DEDUCTIBLE_ADD FROM OTHER_EXPENSES WHERE EXO_EXOKEY=@ID AND EXO_KEY=@PL_KEY"
                    SQLCmd.CommandText = strSQL
                    SQLCmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    SQLCmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PNLKey

            End Select

            If SQLCmd IsNot Nothing Then
                Return ADO.Load_SQLCmd(SQLCmd, Errorlog)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            Return Nothing
        End Try
    End Function
    Public Function TransferFromImport_ToMain(ByVal dsMain As DataSet, ByVal dtRowImport As DataRow, ByVal Type As mdlEnum.TaxComPNLEnuItem, ByVal SourceNo As Integer, ByRef RefNo As String, _
                                              ByVal YA As String, ByVal dtPNLInfo As DataTable, ByVal isHasChild As Boolean, _
                                              ByRef TableName_ As String, ByRef ColumnAmount_ As String, Optional ByRef Errorlog As ClsError = Nothing) As Boolean
        Try
            Dim dtRow As DataRow = Nothing
            Dim dtRowChild As DataRow = Nothing
            Dim TableName As String = Nothing
            Dim TableName_Details As String = Nothing
            Dim Tmp_ID As Integer = 0

            For Each RowInfo As DataRow In dtPNLInfo.Rows
                TableName = IIf(IsDBNull(RowInfo("TableName")), "", RowInfo("TableName"))
                TableName_Details = IIf(IsDBNull(RowInfo("TableName_Details")), "", RowInfo("TableName_Details"))
                If Type.ToString = IIf(IsDBNull(RowInfo("KeyName")), "", RowInfo("KeyName")) Then

                    Tmp_ID = dsMain.Tables(TableName).Rows.Count + 1

                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow(RowInfo("ColumnSourceNo")) = 1
                    dtRow(RowInfo("ColumnTable")) = Tmp_ID
                    dtRow(RowInfo("ColumnDescription")) = dtRowImport("Description")

                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow(RowInfo("ColumnAmount")) = dtRowImport("LeftAmount")
                    Else
                        dtRow(RowInfo("ColumnAmount")) = dtRowImport("RightAmount")
                    End If

                    'dtRow(RowInfo("PrefixName") & "_NOTE") = ""

                    Select Case IIf(IsDBNull(RowInfo("Type")), -1, RowInfo("Type"))
                        Case 1
                            'SALE

                        Case 2
                            'INCOME
                            Select Case RowInfo("KEYNAME")
                                Case "PURCHASE", "DEPRECIATION", "OTHERALLOWEXP", "OTHERNONALLOWEXP"
                                    dtRow(RowInfo("ColumnAddBack")) = False
                                    dtRow("PecentageAmount") = 0
                                Case Else
                                    dtRow(RowInfo("ColumnAddBack")) = False
                                    dtRow(RowInfo("ColumnDeduct")) = False
                                    dtRow("PecentageAmount") = 0
                            End Select
                        Case 3
                            'EXPENSES
                            dtRow(RowInfo("ColumnAddBack")) = False
                            dtRow(RowInfo("ColumnDeduct")) = False
                            dtRow("PecentageAmount") = 0
                            dtRow("Pecentage") = 0
                    End Select

                    Select Case RowInfo("KEYNAME")
                        Case "DIVIDENDINC", "RENTALINC", "EXEMDIV", "INTERESTRESTRICT"
                        Case Else
                            If dtRowImport.GetChildRows("FK_ExportPNL_ExportPNL_Details").Length > 0 AndAlso TableName_Details <> "" Then
                                dtRow(RowInfo("PrefixName") & "_DETAIL") = "Yes"
                            Else
                                dtRow(RowInfo("PrefixName") & "_DETAIL") = "No"
                            End If
                    End Select
                   
                    dsMain.Tables(TableName).Rows.Add(dtRow)


                    If dtRowImport.GetChildRows("FK_ExportPNL_ExportPNL_Details").Length > 0 AndAlso TableName_Details <> "" Then

                        For Each dtRowImportChild As DataRow In dsMain.Tables("ExportPNL_Details").Rows
                            If IsDBNull(dtRowImportChild("No2")) = False AndAlso IsDBNull(RowInfo("ColumnTable_Details_Key")) = False AndAlso dtRowImport("No") = dtRowImportChild("No2") Then
                                dtRowChild = dsMain.Tables(TableName_Details).NewRow
                                dtRowChild(RowInfo("ColumnSourceNo_Details")) = 1
                                dtRowChild(RowInfo("ColumnTable_Details")) = Tmp_ID
                                dtRowChild(RowInfo("ColumnTable_Details_Key")) = dsMain.Tables(TableName_Details).Rows.Count + 1

                                dtRowChild(RowInfo("ColumnDescription_Details")) = dtRowImportChild("Description")

                                If IsNumeric(dtRowImportChild("LeftAmount")) = True AndAlso CDec(dtRowImportChild("LeftAmount")) > 0 Then
                                    dtRowChild(RowInfo("ColumnAmount_Details")) = dtRowImportChild("LeftAmount")
                                Else
                                    dtRowChild(RowInfo("ColumnAmount_Details")) = dtRowImportChild("RightAmount")
                                End If
                                'dtRowChild(RowInfo("PrefixName") & "D_NOTE") = ""

                                Select Case IIf(IsDBNull(RowInfo("Type")), -1, RowInfo("Type"))
                                    Case 1
                                        'SALE

                                    Case 2
                                        'INCOME
                                        Select Case RowInfo("KEYNAME")
                                            Case "PURCHASE", "DEPRECIATION", "OTHERALLOWEXP", "OTHERNONALLOWEXP"
                                                dtRowChild(RowInfo("ColumnAddBack_Details")) = False
                                                dtRowChild("PecentageAmount") = 0
                                            Case Else
                                                dtRowChild(RowInfo("ColumnAddBack_Details")) = False
                                                dtRowChild(RowInfo("ColumnDeduct_Details")) = False
                                                dtRowChild("PecentageAmount") = 0
                                        End Select
                                    Case 3
                                        'EXPENSES
                                        dtRowChild(RowInfo("ColumnAddBack_Details")) = False
                                        dtRowChild(RowInfo("ColumnDeduct_Details")) = False
                                        dtRowChild("PecentageAmount") = 0
                                        dtRowChild("Pecentage") = 0
                                End Select

                                dsMain.Tables(TableName_Details).Rows.Add(dtRowChild)
                                dsMain.Tables(TableName_Details).AcceptChanges()
                                ' dsMain.Tables(TableName).Rows(Tmp_ID)(RowInfo("PrefixName") & "_DETAIL") = "Yes"
                            End If
                        Next

                    End If

                    dsMain.Tables(TableName).AcceptChanges()
                    TableName_ = TableName
                    ColumnAmount_ = IIf(IsDBNull(RowInfo("ColumnAmount")), "", RowInfo("ColumnAmount"))
                End If

            Next

            'Dim dtRow As DataRow = Nothing
            'Dim dtRow_child As DataRow = Nothing
            'Select Case Type
            '    Case TaxComPNLEnuItem.SALES


            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("PLFS_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("PLFS_SOURCENO") = SourceNo
            '        dtRow("PLFS_DESC") = dtRowImport("Description")
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("PLFS_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("PLFS_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("PLFS_NOTE") = ""
            '        dtRow("PLFS_DETAIL") = "No"

            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '        Application.DoEvents()
            '        If isHasChild AndAlso IsDBNull(RowInfo("TableName_Details")) = False AndAlso RowInfo("TableName_Details") <> "" Then
            '            dtRow_child = dsMain.Tables(RowInfo("TableName_Details")).NewRow
            '            dtRow("PLFS_KEY") = dsMain.Tables(RowInfo("TableName_Details")).Rows.Count + 1

            '        End If

            '    Case TaxComPNLEnuItem.OPENSTOCK
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("PLFOS_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("PLFOS_SOURCENO") = SourceNo
            '        dtRow("PLFOS_DESC") = dtRowImport("Description")
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("PLFOS_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("PLFOS_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("PLFOS_NOTE") = ""
            '        dtRow("PLFOS_DETAIL") = "No"
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.PURCHASE
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("PLFPUR_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("PLFPUR_SOURCENO") = SourceNo
            '        dtRow("PLFPUR_DESC") = dtRowImport("Description")
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("PLFPUR_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("PLFPUR_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("PLFPUR_NOTE") = ""
            '        dtRow("PLFPUR_DETAIL") = "No"
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.DEPRECIATION
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXDEP_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXDEP_SOURCENO") = SourceNo
            '        dtRow("EXDEP_DESC") = dtRowImport("Description")
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXDEP_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXDEP_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("EXDEP_NOTE") = ""
            '        dtRow("EXDEP_DETAIL") = "No"
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.OTHERALLOWEXP
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXA_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXA_SOURCENO") = SourceNo
            '        dtRow("EXA_DESC") = dtRowImport("Description")
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXA_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXA_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("EXA_NOTE") = ""
            '        dtRow("EXA_DETAIL") = "No"
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.OTHERNONALLOWEXP
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXNA_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXNA_SOURCENO") = SourceNo
            '        dtRow("EXNA_DESC") = dtRowImport("Description")
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXNA_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXNA_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("EXNA_NOTE") = ""
            '        dtRow("EXNA_DETAIL") = "No"
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.CLOSESTOCK
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("PLFCS_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("PLFCS_SOURCENO") = SourceNo
            '        dtRow("PLFCS_DESC") = dtRowImport("Description")
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("PLFCS_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("PLFCS_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("PLFCS_NOTE") = ""
            '        dtRow("PLFCS_DETAIL") = "No"
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.OTHERBUSINC
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("NSBI_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("NSBI_SOURCENO") = SourceNo
            '        dtRow("NSBI_DESC") = dtRowImport("Description")
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("NSBI_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("NSBI_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("NSBI_NOTE") = ""
            '        dtRow("NSBI_DETAIL") = "No"
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.REALFETRADE
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("IRFET_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("IRFET_SOURCENO") = SourceNo
            '        dtRow("IRFET_DESC") = dtRowImport("Description")
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("IRFET_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("IRFET_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("IRFET_NOTE") = ""
            '        dtRow("IRFET_DETAIL") = "No"
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.DIVIDENDINC
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("DI_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("DI_SOURCENO") = SourceNo
            '        dtRow("DI_COMPANY") = dtRowImport("Description")
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("DI_GROSS") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("DI_GROSS") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("DI_TRANSFER") = "Single Tier"
            '        dtRow("DI_WARANT_NO") = "-"
            '        dtRow("DI_DATE") = Now
            '        dtRow("DI_TRANSFER") = "Single Tier"
            '        dtRow("DI_TAX") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("DI_NET") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("DI_TAXDEDUCTION") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("DI_NETDEDUCTION") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("DI_DISCLOSE") = "No"
            '        dtRow("DI_REGROSS") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("DI_CHKREGROSS") = "No"
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.INTERESTINC
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("NOBII_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("NOBII_SOURCENO") = SourceNo
            '        dtRow("NOBII_DESC") = dtRowImport("Description")
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("NOBII_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("NOBII_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("NOBII_NOTE") = ""
            '        dtRow("NOBII_DETAIL") = "No"
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.RENTALINC
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("RI_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("RI_SOURCENO") = SourceNo
            '        dtRow("RI_ADDRESS") = dtRowImport("Description")
            '        dtRow("RI_TYPE") = "Rental"
            '        dtRow("RI_DATE") = Now
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("RI_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("RI_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("RI_STATUS4d") = "Sec 4b"
            '        dtRow("RI_DATE_END") = Now
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.ROYALTYINC
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("NOBRI_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("NOBRI_SOURCENO") = SourceNo
            '        dtRow("NOBRI_DESC") = dtRowImport("Description")
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("NOBRI_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("NOBRI_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("NOBRI_NOTE") = ""
            '        dtRow("NOBRI_DETAIL") = "No"
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.OTHERINC
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("OI_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("OI_SOURCENO") = SourceNo
            '        dtRow("OI_DESC") = dtRowImport("Description")
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("OI_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("OI_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("OI_NOTE") = ""
            '        dtRow("OI_DETAIL") = "No"
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.PDFIXASSET
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("NTIDFA_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("NTIDFA_SOURCENO") = SourceNo
            '        dtRow("NTIDFA_DESC") = dtRowImport("Description")
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("NTIDFA_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("NTIDFA_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("NTIDFA_NOTE") = ""
            '        dtRow("NTIDFA_DETAIL") = "No"
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.PDINVEST
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("NTIDI_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("NTIDI_SOURCENO") = SourceNo
            '        dtRow("NTIDI_DESC") = dtRowImport("Description")
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("NTIDI_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("NTIDI_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("NTIDI_NOTE") = ""
            '        dtRow("NTIDI_DETAIL") = "No"
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXEMDIV
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("ED_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("ED_SOURCENO") = SourceNo
            '        dtRow("ED_COMPANY") = dtRowImport("Description")
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("ED_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("ED_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("ED_TIERSTATUS") = "First Tier"
            '        dtRow("ED_DATE") = Now
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.FORINCREMIT
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("NTIFIR_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("NTIFIR_SOURCENO") = SourceNo
            '        dtRow("NTIFIR_DESC") = dtRowImport("Description")
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("NTIFIR_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("NTIFIR_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("NTIFIR_NOTE") = ""
            '        dtRow("NTIFIR_DETAIL") = "No"
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.REALFE
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("NTIUT_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("NTIUT_SOURCENO") = SourceNo
            '        dtRow("NTIUT_DESC") = dtRowImport("Description")
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("NTIUT_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("NTIUT_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("NTIUT_NOTE") = ""
            '        dtRow("NTIUT_DETAIL") = "No"
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.UNREALFENONTRADE
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("NTIRFECT_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("NTIRFECT_SOURCENO") = SourceNo
            '        dtRow("NTIRFECT_DESC") = dtRowImport("Description")
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("NTIRFECT_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("NTIRFECT_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("NTIRFECT_NOTE") = ""
            '        dtRow("NTIRFECT_DETAIL") = "No"
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.UNREALFETRADE
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("NTIUNT_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("NTIUNT_SOURCENO") = SourceNo
            '        dtRow("NTIUNT_DESC") = dtRowImport("Description")
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("NTIUNT_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("NTIUNT_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("NTIUNT_NOTE") = ""
            '        dtRow("NTIUNT_DETAIL") = "No"
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.OTHERNONTAXINC
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("NT_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("NT_REF_NO") = RefNo
            '        dtRow("NT_YA") = YA
            '        dtRow("NT_SOURCENO") = SourceNo
            '        dtRow("NT_DESC") = dtRowImport("Description")
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("NT_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("NT_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("NT_CATEGORIZED") = "Other"
            '        dtRow("NT_NOTE") = ""
            '        dtRow("NT_DETAIL") = "No"
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPOTHERINTEREST
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXI_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXI_SOURCENO") = SourceNo
            '        dtRow("EXI_DESC") = dtRowImport("Description")
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXI_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXI_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("EXI_DEDUCTIBLE") = False
            '        dtRow("EXI_DEDUCTIBLE_ADD") = False
            '        dtRow("EXI_NOTE") = ""
            '        dtRow("EXI_DETAIL") = "No"
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPLEGAL
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXL_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXL_SOURCENO") = SourceNo
            '        dtRow("EXL_DESC") = dtRowImport("Description")
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXL_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXL_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dtRow("EXL_DEDUCTIBLE") = False
            '        dtRow("EXL_DEDUCTIBLE_ADD") = False
            '        dtRow("EXL_NOTE") = ""
            '        dtRow("EXL_DETAIL") = "No"
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPTECHNICAL
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXTF_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXTF_SOURCENO") = SourceNo
            '        dtRow("EXTF_DESC") = dtRowImport("Description")
            '        dtRow("EXTF_DEDUCTIBLE") = False
            '        dtRow("EXTF_DEDUCTIBLE_ADD") = False
            '        dtRow("EXTF_NOTE") = ""
            '        dtRow("EXTF_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXTF_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXTF_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPCONTRACTPAY
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXC_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXC_SOURCENO") = SourceNo
            '        dtRow("EXC_DESC") = dtRowImport("Description")
            '        dtRow("EXC_DEDUCTIBLE") = False
            '        dtRow("EXC_DEDUCTIBLE_ADD") = False
            '        dtRow("EXC_NOTE") = ""
            '        dtRow("EXC_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXC_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXC_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPDIRECTORFEE
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXDF_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXDF_SOURCENO") = SourceNo
            '        dtRow("EXDF_DESC") = dtRowImport("Description")
            '        dtRow("EXDF_DEDUCTIBLE") = False
            '        dtRow("EXDF_DEDUCTIBLE_ADD") = False
            '        dtRow("EXDF_NOTE") = ""
            '        dtRow("EXDF_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXDF_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXDF_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPSALARY
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXS_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXS_SOURCENO") = SourceNo
            '        dtRow("EXS_DESC") = dtRowImport("Description")
            '        dtRow("EXS_DEDUCTIBLE") = False
            '        dtRow("EXS_DEDUCTIBLE_ADD") = False
            '        dtRow("EXS_NOTE") = ""
            '        dtRow("EXS_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXS_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXS_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPEMPLOYEESTOCK
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXES_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXES_SOURCENO") = SourceNo
            '        dtRow("EXES_DESC") = dtRowImport("Description")
            '        dtRow("EXES_DEDUCTIBLE") = False
            '        dtRow("EXES_DEDUCTIBLE_ADD") = False
            '        dtRow("EXES_NOTE") = ""
            '        dtRow("EXES_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXES_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXES_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPROYALTY
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXRO_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXRO_SOURCENO") = SourceNo
            '        dtRow("EXRO_DESC") = dtRowImport("Description")
            '        dtRow("EXRO_DEDUCTIBLE") = False
            '        dtRow("EXRO_DEDUCTIBLE_ADD") = False
            '        dtRow("EXRO_NOTE") = ""
            '        dtRow("EXRO_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXRO_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXRO_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPRENTAL
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXRENT_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXRENT_SOURCENO") = SourceNo
            '        dtRow("EXRENT_DESC") = dtRowImport("Description")
            '        dtRow("EXRENT_DEDUCTIBLE") = False
            '        dtRow("EXRENT_DEDUCTIBLE_ADD") = False
            '        dtRow("EXRENT_NOTE") = ""
            '        dtRow("EXRENT_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXRENT_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXRENT_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPREPAIRMAINTENANCE
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXREP_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXREP_SOURCENO") = SourceNo
            '        dtRow("EXREP_DESC") = dtRowImport("Description")
            '        dtRow("EXREP_DEDUCTIBLE") = False
            '        dtRow("EXREP_DEDUCTIBLE_ADD") = False
            '        dtRow("EXREP_NOTE") = ""
            '        dtRow("EXREP_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXREP_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXREP_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPRND
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXRES_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXRES_SOURCENO") = SourceNo
            '        dtRow("EXRES_DESC") = dtRowImport("Description")
            '        dtRow("EXRES_DEDUCTIBLE") = False
            '        dtRow("EXRES_DEDUCTIBLE_ADD") = False
            '        dtRow("EXRES_NOTE") = ""
            '        dtRow("EXRES_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXRES_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXRES_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPADVERTISEMENT
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXP_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXP_SOURCENO") = SourceNo
            '        dtRow("EXP_DESC") = dtRowImport("Description")
            '        dtRow("EXP_DEDUCTIBLE") = False
            '        dtRow("EXP_DEDUCTIBLE_ADD") = False
            '        dtRow("EXP_NOTE") = ""
            '        dtRow("EXP_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXP_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXP_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPTRAVEL
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXT_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXT_SOURCENO") = SourceNo
            '        dtRow("EXT_DESC") = dtRowImport("Description")
            '        dtRow("EXT_DEDUCTIBLE") = False
            '        dtRow("EXT_DEDUCTIBLE_ADD") = False
            '        dtRow("EXT_NOTE") = ""
            '        dtRow("EXT_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXT_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXT_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPJKDM
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXJK_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXJK_SOURCENO") = SourceNo
            '        dtRow("EXJK_DESC") = dtRowImport("Description")
            '        dtRow("EXJK_DEDUCTIBLE") = False
            '        dtRow("EXJK_DEDUCTIBLE_ADD") = False
            '        dtRow("EXJK_NOTE") = ""
            '        dtRow("EXJK_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXJK_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXJK_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPDEPRECIATION
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXODEP_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXODEP_SOURCENO") = SourceNo
            '        dtRow("EXODEP_DESC") = dtRowImport("Description")
            '        dtRow("EXODEP_DEDUCTIBLE") = False
            '        dtRow("EXODEP_DEDUCTIBLE_ADD") = False
            '        dtRow("EXODEP_NOTE") = ""
            '        dtRow("EXODEP_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXODEP_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXODEP_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPDONATIONAPPR
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXOAD_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXOAD_SOURCENO") = SourceNo
            '        dtRow("EXOAD_DESC") = dtRowImport("Description")
            '        dtRow("EXOAD_DEDUCTIBLE") = False
            '        dtRow("EXOAD_DEDUCTIBLE_ADD") = False
            '        dtRow("EXOAD_NOTE") = ""
            '        dtRow("EXOAD_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXOAD_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXOAD_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPDONATIONNONAPPR
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXONAD_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXONAD_SOURCENO") = SourceNo
            '        dtRow("EXONAD_DESC") = dtRowImport("Description")
            '        dtRow("EXONAD_DEDUCTIBLE") = False
            '        dtRow("EXONAD_DEDUCTIBLE_ADD") = False
            '        dtRow("EXONAD_NOTE") = ""
            '        dtRow("EXONAD_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXONAD_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXONAD_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPZAKAT
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXOZ_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXOZ_SOURCENO") = SourceNo
            '        dtRow("EXOZ_DESC") = dtRowImport("Description")
            '        dtRow("EXOZ_DEDUCTIBLE") = False
            '        dtRow("EXOZ_DEDUCTIBLE_ADD") = False
            '        dtRow("EXOZ_NOTE") = ""
            '        dtRow("EXOZ_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXOZ_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXOZ_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPLOSSDISPFA
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXOLD_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXOLD_SOURCENO") = SourceNo
            '        dtRow("EXOLD_DESC") = dtRowImport("Description")
            '        dtRow("EXOLD_DEDUCTIBLE") = False
            '        dtRow("EXOLD_DEDUCTIBLE_ADD") = False
            '        dtRow("EXOLD_NOTE") = ""
            '        dtRow("EXOLD_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXOLD_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXOLD_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPENTERTAINNONSTAFF
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXOENS_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXOENS_SOURCENO") = SourceNo
            '        dtRow("EXOENS_DESC") = dtRowImport("Description")
            '        dtRow("EXOENS_DEDUCTIBLE") = False
            '        dtRow("EXOENS_DEDUCTIBLE_ADD") = False
            '        dtRow("EXOENS_NOTE") = ""
            '        dtRow("EXOENS_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXOENS_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXOENS_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPENTERTAINSTAFF
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXOES_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXOES_SOURCENO") = SourceNo
            '        dtRow("EXOES_DESC") = dtRowImport("Description")
            '        dtRow("EXOES_DEDUCTIBLE") = False
            '        dtRow("EXOES_DEDUCTIBLE_ADD") = False
            '        dtRow("EXOES_NOTE") = ""
            '        dtRow("EXOES_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXOES_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXOES_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPCOMPAUNDPENALTY
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXOP_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXOP_SOURCENO") = SourceNo
            '        dtRow("EXOP_DESC") = dtRowImport("Description")
            '        dtRow("EXOP_DEDUCTIBLE") = False
            '        dtRow("EXOP_DEDUCTIBLE_ADD") = False
            '        dtRow("EXOP_NOTE") = ""
            '        dtRow("EXOP_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXOP_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXOP_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPPROVISION
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXOPA_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXOPA_SOURCENO") = SourceNo
            '        dtRow("EXOPA_DESC") = dtRowImport("Description")
            '        dtRow("EXOPA_DEDUCTIBLE") = False
            '        dtRow("EXOPA_DEDUCTIBLE_ADD") = False
            '        dtRow("EXOPA_NOTE") = ""
            '        dtRow("EXOPA_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXOPA_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXOPA_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPLEAVEPASSAGE
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXOLP_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXOLP_SOURCENO") = SourceNo
            '        dtRow("EXOLP_DESC") = dtRowImport("Description")
            '        dtRow("EXOLP_DEDUCTIBLE") = False
            '        dtRow("EXOLP_DEDUCTIBLE_ADD") = False
            '        dtRow("EXOLP_NOTE") = ""
            '        dtRow("EXOLP_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXOLP_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXOLP_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPFAWRITTENOFF
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXOWO_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXOWO_SOURCENO") = SourceNo
            '        dtRow("EXOWO_DESC") = dtRowImport("Description")
            '        dtRow("EXOWO_DEDUCTIBLE") = False
            '        dtRow("EXOWO_DEDUCTIBLE_ADD") = False
            '        dtRow("EXOWO_NOTE") = ""
            '        dtRow("EXOWO_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXOWO_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXOWO_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPUNREALLOSSFE
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXOUR_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXOUR_SOURCENO") = SourceNo
            '        dtRow("EXOUR_DESC") = dtRowImport("Description")
            '        dtRow("EXOUR_DEDUCTIBLE") = False
            '        dtRow("EXOUR_DEDUCTIBLE_ADD") = False
            '        dtRow("EXOUR_NOTE") = ""
            '        dtRow("EXOUR_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXOUR_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXOUR_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPREALLOSSFETRADE
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXORT_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXORT_SOURCENO") = SourceNo
            '        dtRow("EXORT_DESC") = dtRowImport("Description")
            '        dtRow("EXORT_DEDUCTIBLE") = False
            '        dtRow("EXORT_DEDUCTIBLE_ADD") = False
            '        dtRow("EXORT_NOTE") = ""
            '        dtRow("EXORT_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXORT_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXORT_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPREALLOSSFENONTRADE
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXOR_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXOR_SOURCENO") = SourceNo
            '        dtRow("EXOR_DESC") = dtRowImport("Description")
            '        dtRow("EXOR_DEDUCTIBLE") = False
            '        dtRow("EXOR_DEDUCTIBLE_ADD") = False
            '        dtRow("EXOR_NOTE") = ""
            '        dtRow("EXOR_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXOR_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXOR_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPINITIALSUBSCRIPT
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXOIS_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXOIS_SOURCENO") = SourceNo
            '        dtRow("EXOIS_DESC") = dtRowImport("Description")
            '        dtRow("EXOIS_DEDUCTIBLE") = False
            '        dtRow("EXOIS_DEDUCTIBLE_ADD") = False
            '        dtRow("EXOIS_NOTE") = ""
            '        dtRow("EXOIS_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXOIS_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXOIS_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPCAPITALEXPENDITURE
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXOCE_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXOCE_SOURCENO") = SourceNo
            '        dtRow("EXOCE_DESC") = dtRowImport("Description")
            '        dtRow("EXOCE_DEDUCTIBLE") = False
            '        dtRow("EXOCE_DEDUCTIBLE_ADD") = False
            '        dtRow("EXOCE_NOTE") = ""
            '        dtRow("EXOCE_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXOCE_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXOCE_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
            '        dtRow = dsMain.Tables(RowInfo("TableName")).NewRow
            '        dtRow("EXO_KEY") = dsMain.Tables(RowInfo("TableName")).Rows.Count + 1
            '        dtRow("EXO_SOURCENO") = SourceNo
            '        dtRow("EXO_DESC") = dtRowImport("Description")
            '        dtRow("EXO_DEDUCTIBLE") = False
            '        dtRow("EXO_DEDUCTIBLE_ADD") = False
            '        dtRow("EXO_NOTE") = ""
            '        dtRow("EXO_DETAIL") = "No"
            '        If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
            '            dtRow("EXO_AMOUNT") = dtRowImport("LeftAmount")
            '        Else
            '            dtRow("EXO_AMOUNT") = dtRowImport("RightAmount")
            '        End If
            '        dsMain.Tables(RowInfo("TableName")).Rows.Add(dtRow)
            '    Case Else

            'End Select

            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = Type.ToString & " - " & ex.Message
            End With
            AddListOfError(Errorlog)
            Return False
        End Try
    End Function
    Public Function PNL_GenerateReport(ByVal RefNo As String, ByVal YA As String, ByRef ID As String, _
                                       Optional ByRef Errorlog As ClsError = Nothing) As Boolean

        Try
            Dim dtPNL As DataTable = ADO.Load_PNL(RefNo, YA, Errorlog)
            Dim dtPNLInfo As DataTable = ADO.Load_PNLINFO(Errorlog)

            If dtPNL Is Nothing Then
                If Errorlog Is Nothing Then
                    Errorlog = New ClsError
                End If
                With Errorlog
                    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                    .ErrorCode = "P10001"
                    .ErrorDateTime = Now
                    .ErrorMessage = "No data found for PNL = " & RefNo
                End With
                Return False
            End If

            Dim dtRow As DataRow = Nothing
            Dim TableName As String = "PROFIT_LOSS_ACCOUNT_REPORT_TEMP"
            dsDataSet.Tables(TableName).Rows.Clear()

            ID = "PNL_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)

            While ADO.Validate_PNL_TEMP_REPORTID(ID)
                ID = "PNL_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)
            End While

            '   Dim listoflabelname As List(Of clsPNL_LabelName) = mdlPNL.GetPNLLabelName_Report(Errorlog)

            If dtPNLInfo IsNot Nothing Then
                Dim ParentID As Integer = 0
                Dim IDData As Integer = 0
                Dim indexNo As Integer = 0
                Dim ColumnName As String = Nothing
                Dim AlignAmountLeft As Boolean = True
                Dim TypeRow As PNL_REPORT_TypeRow = PNL_REPORT_TypeRow.NORMAL
                Dim SubStatus As Boolean = False

                Dim KeyNameEnum As TaxComPNLEnuItem
                For Each rowInfo As DataRow In dtPNLInfo.Rows
                    KeyNameEnum = [Enum].Parse(GetType(TaxComPNLEnuItem), IIf(IsDBNull(rowInfo("KeyName")), "", rowInfo("KeyName")))
                    ColumnName = IIf(IsDBNull(rowInfo("ColumnName")), "", rowInfo("ColumnName"))

                    If ColumnName <> "" AndAlso IsDBNull(dtPNL.Rows(0)(ColumnName)) = False AndAlso IsNumeric(dtPNL.Rows(0)(ColumnName)) = True AndAlso CDec(dtPNL.Rows(0)(ColumnName)) <> 0 Then
                        SubStatus = True
                    Else
                        SubStatus = False
                    End If

                    If TypeRow = PNL_REPORT_TypeRow.TOTAL Or TypeRow = PNL_REPORT_TypeRow.TITLE Or TypeRow = PNL_REPORT_TypeRow.SUBTOTAL Or SubStatus Then

                        indexNo += 1

                        dtRow = dsDataSet.Tables(TableName).NewRow
                        IDData = dsDataSet.Tables(TableName).Rows.Count + 1

                        dtRow("ID_KEY") = IDData
                        dtRow("PARENT_ID") = ParentID
                        dtRow("ID") = ID
                        dtRow("RefNo") = RefNo
                        dtRow("YA") = CInt(YA)
                        dtRow("IndexNo") = indexNo

                        If TypeRow <> PNL_REPORT_TypeRow.SUBTOTAL Then
                            If isVersionLicenseType = VersionLicenseType.Tricor Then
                                dtRow("Caption") = IIf(IsDBNull(rowInfo("LabelNameTricor")), "", rowInfo("LabelNameTricor"))
                            Else
                                dtRow("Caption") = IIf(IsDBNull(rowInfo("LabelName")), "", rowInfo("LabelName"))
                            End If
                        Else
                            dtRow("Caption") = ""
                        End If

                        If ColumnName <> "" Then
                            If AlignAmountLeft = True Then
                                dtRow("LeftAmount") = CDec(IIf(IsDBNull(dtPNL.Rows(0)(ColumnName)), 0, dtPNL.Rows(0)(ColumnName)))
                                dtRow("RightAmount") = DBNull.Value
                            Else
                                dtRow("LeftAmount") = DBNull.Value
                                dtRow("RightAmount") = CDec(IIf(IsDBNull(dtPNL.Rows(0)(ColumnName)), 0, dtPNL.Rows(0)(ColumnName)))
                            End If
                        Else
                            dtRow("LeftAmount") = DBNull.Value
                            dtRow("RightAmount") = DBNull.Value
                        End If


                        dtRow("TypeRow") = TypeRow
                        dtRow("Note") = ""

                        dsDataSet.Tables(TableName).Rows.Add(dtRow)

                    End If

                Next
                Return ADO.Save_PNL_Report_TEMP(dsDataSet.Tables(TableName), Errorlog)
            End If

            Return False
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(Errorlog)
            Return True
        End Try
    End Function
    Public Function PNL_Report(ByVal RefNo As String, ByVal YA As String, ByRef ds As DataSet, Optional ByRef Errorlog As ClsError = Nothing) As Boolean
        Try

            Dim dtPNL As DataTable = ADO.Load_PNL(RefNo, YA, Errorlog)
            Dim dtPNLInfo As DataTable = ADO.Load_PNLINFO(Errorlog)

            If ds Is Nothing Then
                ds = New dsPNL
            End If

            ds.Tables("PROFIT_LOSS_ACCOUNT_REPORT_KEYNAME").Rows.Clear()
            ds.Tables("PROFIT_LOSS_ACCOUNT_REPORT_SCH").Rows.Clear()
            ds.Tables("PROFIT_LOSS_ACCOUNT_REPORT").Rows.Clear()

            If dtPNL Is Nothing Then
                If Errorlog Is Nothing Then
                    Errorlog = New ClsError
                End If
                With Errorlog
                    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                    .ErrorCode = "A10001"
                    .ErrorDateTime = Now
                    .ErrorMessage = "Data not found."
                End With
                AddListOfError(Errorlog)
                Return False
            End If

            Dim tmpDt As DataTable = Nothing
            Dim dtRow As DataRow = Nothing
            Dim dtRowKeyName As DataRow = Nothing
            Dim dtExclude As DataTable
            Dim PNL_KEY As Integer = 0
            Dim ScheduleInt As Integer = 0
            Dim ColumnName As String = Nothing
            Dim isHaveData As Boolean = False
            Dim dtNote As DataTable = Nothing
            Dim dtNoteColumn As DataTable = Nothing
            Dim dtNoteAttch As DataTable = Nothing
            Dim clsNote As clsNote_PNL = Nothing
            Dim PNLType As Integer = 0
            If clsNote Is Nothing Then
                clsNote = New clsNote_PNL
            End If

            ' Dim listofclsPNLLabel As List(Of clsPNL_LabelName) = GetPNLLabelName()
            ds.Tables("PROFIT_LOSS_ACCOUNT_NOTE_COLUMN").Rows.Clear()
            ds.Tables("PROFIT_LOSS_ACCOUNT_NOTE").Rows.Clear()

            ds.Tables("PROFIT_LOSS_ACCOUNT_REPORT_EXCLUDE_REPORT").Rows.Clear()
            ClearMemoryDataset()

            For i As Integer = 0 To dtPNL.Rows.Count - 1
                ds.Tables("PROFIT_LOSS_ACCOUNT_REPORT").ImportRow(dtPNL.Rows(i))

                PNL_KEY = IIf(IsDBNull(dtPNL.Rows(i)("PL_KEY")), 0, dtPNL.Rows(i)("PL_KEY"))

                dtRow = Nothing
                dtRow = ds.Tables("PROFIT_LOSS_ACCOUNT_REPORT_SCH").NewRow
                dtRow("PL_KEY") = PNL_KEY

                dtRowKeyName = Nothing
                dtRowKeyName = ds.Tables("PROFIT_LOSS_ACCOUNT_REPORT_KEYNAME").NewRow
                dtRowKeyName("PL_KEY") = PNL_KEY

                If dtPNLInfo IsNot Nothing Then
                    Dim KeyNameEnum As TaxComPNLEnuItem
                    For Each rowInfo As DataRow In dtPNLInfo.Rows

                        '==========GET DATA=====================================================================
                        KeyNameEnum = [Enum].Parse(GetType(TaxComPNLEnuItem), IIf(IsDBNull(rowInfo("KeyName")), "", rowInfo("KeyName")))
                        mdlPNL2.PNL_GetData(PNL_KEY, KeyNameEnum, RefNo, YA, ds, Errorlog, isHaveData, True, clsNote)
                        '==========GET DATA=====================================================================

                        ColumnName = IIf(IsDBNull(rowInfo("ColumnName")), "", rowInfo("ColumnName"))
                        PNLType = IIf(IsDBNull(rowInfo("Type")), 1, rowInfo("Type"))
                        If ColumnName <> "" Then
                            If isHaveData Then
                                dtExclude = Nothing
                                If PNLType <> 1 AndAlso ColumnName <> "PL_PURCHASES" And ColumnName <> "PL_PRO_COST_DPC" And ColumnName <> "PL_PRO_COST_OAE" And ColumnName <> "PL_DISALLOWED_EXP" Then
                                    dtExclude = ADO.Load_PNL_IncludeInReport(PNL_KEY, ColumnName)
                                End If

                                If dtExclude IsNot Nothing Then
                                    dtRow(ColumnName) = ""
                                Else
                                    ScheduleInt += 1
                                    dtRow(ColumnName) = ScheduleInt
                                End If
                                dtRowKeyName(ColumnName) = KeyNameEnum.ToString

                                dtNote = Nothing
                                dtNote = clsNote.Load_Note(PNL_KEY, IIf(IsDBNull(rowInfo("KeyName")), "", rowInfo("KeyName")))

                                If dtNote IsNot Nothing Then
                                    Dim dtRowAtt As Byte() = Nothing
                                    Dim Ext As String = Nothing
                                    For Each rowx As DataRow In dtNote.Rows
                                        ds.Tables("PROFIT_LOSS_ACCOUNT_NOTE").ImportRow(rowx)

                                        If IsDBNull(rowx("TypeNote")) = False Then
                                            Select Case rowx("TypeNote")
                                                Case 2
                                                    'Column
                                                    dtNoteColumn = clsNote.Load_Note_Column(rowx("ID"), Errorlog)

                                                    If dtNoteColumn IsNot Nothing Then
                                                        For Each rowy As DataRow In dtNoteColumn.Rows
                                                            ds.Tables("PROFIT_LOSS_ACCOUNT_NOTE_COLUMN").ImportRow(rowy)
                                                        Next

                                                    End If
                                                Case 1
                                                    'Attachment
                                                    dtNoteAttch = clsNote.Load_Note_Attachment(rowx("ID"), Errorlog)

                                                    If dtNoteAttch IsNot Nothing Then

                                                        For Each rowy As DataRow In dtNoteAttch.Rows
                                                            dtRowAtt = Nothing
                                                            Ext = Nothing
                                                            dtRowAtt = IIf(IsDBNull(rowy("Attachment")), Nothing, rowy("Attachment"))
                                                            Ext = IIf(IsDBNull(rowy("Extension")), Nothing, rowy("Extension"))

                                                            If dtRowAtt IsNot Nothing Then
                                                                Dim frmnote As New frmNote_AttachmentView
                                                                Select Case Ext.ToLower
                                                                    Case ".jpg", ".png", ".jpeg", ".bitmap", ".ico", ".gif", ".tif"
                                                                        frmnote.Type = 0
                                                                    Case ".xls", ".xlsx", ".csv", ".openxml"
                                                                        frmnote.Type = 1
                                                                    Case ".doc", "docx", ".rtf", ".wordml", ".opendocument"
                                                                        frmnote.Type = 2
                                                                    Case ".pdf"
                                                                        frmnote.Type = 3
                                                                End Select
                                                                frmnote.Title = IIf(IsDBNull(rowx("Title")), Nothing, rowx("Title"))
                                                                frmnote.Extension = Ext
                                                                frmnote.dataArr = dtRowAtt
                                                                frmnote.Show()

                                                            End If
                                                        Next

                                                    End If


                                            End Select

                                        End If
                                    Next
                                End If
                            Else
                                dtRow(ColumnName) = DBNull.Value
                                dtRowKeyName(ColumnName) = DBNull.Value
                            End If
                        End If
                     

                        Application.DoEvents()
                    Next
                End If
               
                ds.Tables("PROFIT_LOSS_ACCOUNT_REPORT_SCH").Rows.Add(dtRow)
                ds.Tables("PROFIT_LOSS_ACCOUNT_REPORT_KEYNAME").Rows.Add(dtRowKeyName)

                dtExclude = Nothing
                dtExclude = ADO.Load_PNL_IncludeInReport(PNL_KEY, Errorlog)

                If dtExclude IsNot Nothing Then
                    For Each row As DataRow In dtExclude.Rows
                        ds.Tables("PROFIT_LOSS_ACCOUNT_REPORT_EXCLUDE_REPORT").ImportRow(row)
                    Next
                End If
            Next

            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(Errorlog)
            Return False
        End Try
    End Function
    Public Function CheckIDExistInTable(ByVal ds As DataSet, ByVal TableName As String, ByVal ColumnName As String, ByVal Value As Integer) As Boolean
        Try

            Dim obj As Object = ds.Tables(TableName).Compute("Count(" & ColumnName & ")", ColumnName & "=" & Value)

            If obj IsNot Nothing AndAlso IsNumeric(obj) = True AndAlso CInt(obj) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            Return False
        End Try
    End Function
    Public Sub LoadTable_InterestRestricted(ByRef ds As DataSet, ByVal Refno As String, ByVal YA As String, ByVal SourceNo As Integer, _
                                             ByVal KeyID As Integer, Optional ByRef ErrorLog As ClsError = Nothing)
        Try

            Dim dt As DataTable = ADO.Load_interestRestricMonthNBasis(Refno, YA, SourceNo, ErrorLog)
            Dim MonthDuration As Integer = 0
            Dim BasisPeriod As DateTime = Now
            Dim CurrBasisPeriod As DateTime = Now
            Dim dtRow As DataRow = Nothing
            Dim LabelTag As String = Nothing
            Dim dtTaxPayer As DataTable = ADO.LoadTaxPayer_ByRefNO(Refno)
            Dim tmpDt As DataTable = Nothing

            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Rows.Clear()
            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns.Clear()


            If dtTaxPayer Is Nothing Then
                MsgBox("Tax payer not found.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If dt Is Nothing Then
                MsgBox("Failed to load interest restriction.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            MonthDuration = IIf(IsDBNull(dt.Rows(0)("DURATION")), 12, dt.Rows(0)("DURATION"))
            BasisPeriod = IIf(IsDBNull(dt.Rows(0)("BASICPERIOD")), Now, dt.Rows(0)("BASICPERIOD"))
            CurrBasisPeriod = BasisPeriod.AddMonths(-1)

            Dim clm As System.Data.DataColumn

            clm = Nothing
            clm = New System.Data.DataColumn With {
                .ColumnName = "KeyID",
                .Caption = "KeyID",
                .DataType = System.Type.GetType("System.Int32"),
                .AllowDBNull = True
            }
            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns.Add(clm)

            clm = Nothing
            clm = New System.Data.DataColumn With {
                .ColumnName = "LabelTag",
                .Caption = "Label Tag",
                .DataType = System.Type.GetType("System.String"),
                .DefaultValue = "",
                .AllowDBNull = True
            }
            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns.Add(clm)


            clm = Nothing
            clm = New System.Data.DataColumn With {
                .ColumnName = "Title",
                .Caption = "Title",
                .DataType = System.Type.GetType("System.String"),
                .DefaultValue = "",
                .AllowDBNull = True
            }
            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns.Add(clm)

            clm = Nothing
            clm = New System.Data.DataColumn With {
                .ColumnName = "TypeName",
                .Caption = "Type Name",
                .DataType = System.Type.GetType("System.String"),
                .DefaultValue = "",
                .AllowDBNull = True
            }
            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns.Add(clm)

            clm = Nothing
            clm = New System.Data.DataColumn With {
                .ColumnName = "TypeIncome",
                .Caption = "Type Income",
                .DataType = System.Type.GetType("System.String"),
                .DefaultValue = "",
                .AllowDBNull = True
            }
            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns.Add(clm)

            For i As Integer = 0 To MonthDuration - 1

                CurrBasisPeriod = CurrBasisPeriod.AddMonths(+1)

                clm = Nothing
                clm = New System.Data.DataColumn With {
                    .ColumnName = Format(CurrBasisPeriod, "MMM") & "_" & CurrBasisPeriod.Year,
                    .Caption = Format(CurrBasisPeriod, "MMM") & " " & CurrBasisPeriod.Year,
                    .DataType = System.Type.GetType("System.Decimal"),
                    .AllowDBNull = True
                }
                ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns.Add(clm)

            Next

            clm = Nothing
            clm = New System.Data.DataColumn With {
                .ColumnName = "TotalYear",
                .Caption = "Total",
                .DataType = System.Type.GetType("System.Decimal"),
                .AllowDBNull = True
            }
            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns.Add(clm)

            Application.DoEvents()
            Dim inxt As Integer = 0
            Dim CurrInxt As Integer = 0
            For i As Integer = 0 To 3
                CurrInxt = i
                LabelTag = GetLabelTag(CurrInxt)
                Select Case i
                    Case 0

                        dt = ADO.Load_interestRestricSchedule(Refno, YA, SourceNo, "Borr")
                    Case 1
                        dt = ADO.Load_interestRestricSchedule(Refno, YA, SourceNo, "inv")
                    Case 2
                        dt = ADO.Load_interestRestricSchedule(Refno, YA, SourceNo, "invNon")
                    Case Else
                        dt = ADO.Load_interestRestricSchedule(Refno, YA, SourceNo, "Interest")
                End Select

                If dt IsNot Nothing Then
                    inxt = 0
                    For Each rowx As DataRow In dt.Rows
                        inxt += 1
                        dtRow = Nothing
                        dtRow = ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").NewRow
                        dtRow("LabelTag") = LabelTag & inxt
                        dtRow("KeyID") = KeyID
                        dtRow("Title") = IIf(IsDBNull(rowx("Item")), "", rowx("Item")).ToString.Remove(0, 1)
                        Select Case i
                            Case 0
                                dtRow("TypeName") = "1 BORROWINGS"
                            Case 1
                                dtRow("TypeName") = "2 LOANS AND INVESTMENTS"
                            Case 2
                                dtRow("TypeName") = "3 LOANS AND INVESTMENTS NON INCOME PRODUCING"
                            Case Else
                                dtRow("TypeName") = "4 INTEREST EXPENSES"
                        End Select

                        dtRow("TypeIncome") = IIf(IsDBNull(rowx("Income Type")), "", rowx("Income Type"))
                        For Each colx As DataColumn In ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns
                            Select Case colx.ColumnName
                                Case "Title", "TypeName", "TypeIncome", "TotalYear", "LabelTag", "KeyID"

                                Case Else
                                    dtRow(colx.ColumnName) = 0
                            End Select

                        Next

                        dtRow("TotalYear") = 0

                        ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Rows.Add(dtRow)
                    Next

                End If
            Next

            dtRow = Nothing
            dtRow = ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").NewRow
            dtRow("Title") = "Interest restricted"
            dtRow("TypeName") = "5 INTEREST RESTRICTED"
            CurrInxt += 1
            dtRow("LabelTag") = GetLabelTag(CurrInxt)
            dtRow("TypeIncome") = ""
            For Each colx As DataColumn In ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns
                Select Case colx.ColumnName
                    Case "Title", "TypeName", "TypeIncome", "TotalYear", "LabelTag", "KeyID"

                    Case Else
                        dtRow(colx.ColumnName) = 0
                End Select

            Next

            dtRow("TotalYear") = 0

            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Rows.Add(dtRow)


            dtRow = Nothing
            dtRow = ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").NewRow
            dtRow("Title") = "Interest Income"
            CurrInxt += 1
            dtRow("LabelTag") = GetLabelTag(CurrInxt) & "1"
            dtRow("TypeName") = "6 INTEREST RESTRICTED BUT ALLOWABLE AGAINST"

            dtRow("TypeIncome") = "E1"
            For Each colx As DataColumn In ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns
                Select Case colx.ColumnName
                    Case "Title", "TypeName", "TypeIncome", "TotalYear", "LabelTag", "KeyID"

                    Case Else
                        dtRow(colx.ColumnName) = 0
                End Select

            Next

            dtRow("TotalYear") = 0

            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Rows.Add(dtRow)

            dtRow = Nothing
            dtRow = ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").NewRow
            dtRow("Title") = "Rental Income"
            dtRow("LabelTag") = GetLabelTag(CurrInxt) & "2"
            dtRow("TypeName") = "6 INTEREST RESTRICTED BUT ALLOWABLE AGAINST"

            dtRow("TypeIncome") = "E2"
            For Each colx As DataColumn In ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns
                Select Case colx.ColumnName
                    Case "Title", "TypeName", "TypeIncome", "TotalYear", "LabelTag", "KeyID"

                    Case Else
                        dtRow(colx.ColumnName) = 0
                End Select

            Next

            dtRow("TotalYear") = 0

            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Rows.Add(dtRow)

            dtRow = Nothing
            dtRow = ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").NewRow
            dtRow("Title") = "Dividend Income"
            dtRow("LabelTag") = GetLabelTag(CurrInxt) & "3"
            dtRow("TypeName") = "6 INTEREST RESTRICTED BUT ALLOWABLE AGAINST"

            dtRow("TypeIncome") = "E3"
            For Each colx As DataColumn In ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns
                Select Case colx.ColumnName
                    Case "Title", "TypeName", "TypeIncome", "TotalYear", "LabelTag", "KeyID"

                    Case Else
                        dtRow(colx.ColumnName) = 0
                End Select

            Next

            dtRow("TotalYear") = 0

            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Rows.Add(dtRow)

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Function GetLabelTag(ByVal Index As Integer) As String
        Try
            Select Case Index
                Case 0
                    Return "A"
                Case 1
                    Return "B"
                Case 2
                    Return "C"
                Case 3
                    Return "D"
                Case 4
                    Return "E"
                Case 5
                    Return "F"
                Case 6
                    Return "G"
                Case 7
                    Return "H"
            End Select
            Return "A"
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            Return "A"
        End Try
    End Function
    Public Sub AppenData_InterestRestricted(ByVal tmpDt_Data As DataTable, ByRef ds As DataSet, _
                                             Optional ByRef ErrorLog As ClsError = Nothing)
        Try
            If tmpDt_Data Is Nothing Then
                Exit Sub
            End If

            If ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT") Is Nothing Then
                Exit Sub
            End If


            For Each datax As DataRow In tmpDt_Data.Rows

                If IsDBNull(datax("colTitle")) = False AndAlso IsDBNull(datax("rowTitle")) = False AndAlso IsDBNull(datax("dataValue")) = False Then

                    For Each rowxTEMP As DataRow In ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Rows

                        For Each colx As DataColumn In ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns

                            If datax("colTitle") = colx.ColumnName AndAlso datax("rowTitle") = rowxTEMP("Title") AndAlso datax("LabelTag") = rowxTEMP("LabelTag") Then

                                Select Case colx.ColumnName
                                    Case "Title", "TypeName", "TypeIncome", "LabelTag", "KeyID"

                                    Case Else
                                        rowxTEMP(colx.ColumnName) = datax("dataValue")
                                End Select

                            End If


                        Next
                    Next

                End If

            Next
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
        End Try
    End Sub
    Public Sub AppenData_InterestRestricted_Report(ByVal tmpDt_Data As DataTable, ByVal ds As DataSet, _
                                            ByVal RefNo As String, ByVal YA As String, ByVal SourceNO As Integer, _
                                            Optional ByRef ErrorLog As ClsError = Nothing)
        Try
            If tmpDt_Data Is Nothing Then
                Exit Sub
            End If

            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT_Tricor").Rows.Clear()

            Dim dtRow As DataRow = Nothing
            Dim MonthDuration As Integer
            Dim BasisPeriod As DateTime = Now
            Dim CurrBasisPeriod As DateTime = Now
            Dim RowIndex As Integer = -1
            Dim ColIndex As Integer = 0
            Dim dt As DataTable = Nothing
            Dim dtTaxPayer As DataTable = Nothing
            dt = ADO.Load_interestRestricMonthNBasis(RefNo, YA, SourceNO, ErrorLog)

            If dt Is Nothing Then
                Exit Sub
            End If

            dtTaxPayer = ADO.LoadTaxPayer_ByRefNO(RefNo, ErrorLog)

            MonthDuration = IIf(IsDBNull(dt.Rows(0)("DURATION")), 12, dt.Rows(0)("DURATION"))
            BasisPeriod = IIf(IsDBNull(dt.Rows(0)("BASICPERIOD")), Now, dt.Rows(0)("BASICPERIOD"))
            CurrBasisPeriod = BasisPeriod.AddMonths(-1)

            Dim TotalRowCount As Integer = ADO.Load_EXPENSES_INTERESTRESTRICT_TOTAL_ROWINDEX(RefNo, YA, SourceNO)

            If TotalRowCount = 0 Then
                Exit Sub
            End If

            For i As Integer = 0 To TotalRowCount - 1

                dtRow = ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT_Tricor").NewRow
                dtRow("TotalColumn") = MonthDuration
                dtRow("DateFrom") = BasisPeriod
                If dtTaxPayer IsNot Nothing AndAlso IsDBNull(dtTaxPayer.Rows(0)("TP_BASIS_PERIOD_TO")) = False AndAlso IsDate(dtTaxPayer.Rows(0)("TP_BASIS_PERIOD_TO")) Then
                    dtRow("DateTo") = CDate(dtTaxPayer.Rows(0)("TP_BASIS_PERIOD_TO"))
                Else
                    dtRow("DateTo") = CurrBasisPeriod.AddMonths(+MonthDuration)
                End If

                ColIndex = 0
                For Each row As DataRow In tmpDt_Data.Rows

                    If i = IIf(IsDBNull(row("rowIndex")), 0, row("rowIndex")) Then

                        Select Case IIf(IsDBNull(row("colTitle")), "", row("colTitle"))
                            Case "KeyID"
                                dtRow("KeyID") = IIf(IsDBNull(row("DataValue")), "", row("DataValue"))
                            Case "Title"
                                dtRow("Title") = IIf(IsDBNull(row("DataValue")), "", row("DataValue"))
                            Case "TypeName"
                                dtRow("TypeName") = IIf(IsDBNull(row("DataValue")), "", row("DataValue"))
                            Case "TypeIncome"
                                dtRow("TypeIncome") = IIf(IsDBNull(row("DataValue")), "", row("DataValue"))
                            Case "TotalYear"
                                If IsDBNull((row("DataValue"))) = False AndAlso IsNumeric(row("DataValue")) Then
                                    dtRow("TotalYear") = CDec(row("DataValue")).ToString("N0")
                                Else
                                    dtRow("TotalYear") = ""
                                End If
                            Case "LabelTag"
                                dtRow("LabelTag") = IIf(IsDBNull(row("DataValue")), "", row("DataValue"))
                            Case Else
                                ColIndex += 1
                                If ColIndex <= 18 Then
                                    dtRow("No" & ColIndex) = IIf(IsDBNull(row("DataValue")), "", row("DataValue"))
                                End If

                                'For x As Integer = 1 To 18


                                'Next

                                'For Each col As DataColumn In ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT_TRICOR").Columns
                                '    Select Case col.ColumnName
                                '        Case "KeyID", "Title", "TypeName", "TypeIncome", "TotalYear", "LabelTag", "TotalColumn"

                                '        Case Else

                                '            dtRow (col.ColumnName ) =
                                '    End Select

                                'Next

                        End Select

                    End If

                Next                

                ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT_Tricor").Rows.Add(dtRow)

            Next

            'If ADO.Save_InterestRestrictedTEST(ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT_Tricor"), 0, ErrorLog) Then
            '    MsgBox("OK azham ")
            'Else
            '    MsgBox("Failed azham ")
            'End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
        End Try
    End Sub
    Public Function PrintPNL_ReportNew(ByVal RefNo As String, ByVal YA As String, ByVal Title As String, ByRef rpt_Interest As Object, _
                                       ByVal ShowDraft As Boolean, ByRef ErrorLog As ClsError, Optional ByVal SchApex As String = "") As rptPNLNew
        Try
            Dim dsPNL_Report As New dsPNL_Report

            Dim dtInfo As DataTable = ADO.Load_PNLINFO()
            Dim dtPNLInfo As DataTable = Nothing

            dtPNLInfo = ADO.Load_PNLINFO()

            If dtPNLInfo Is Nothing Then
                MsgBox("Failed to load PNL Info.", MsgBoxStyle.Critical)
                Return Nothing
            End If

            Dim dsDataSet_Report As New dsPNL
            dsPNL_Report.Tables("PNL_SOURCENO_COUNT").Rows.Clear()
            dsPNL_Report.Tables("PROFIT_LOSS_ACCOUNT_NOTE_COLUMN").Rows.Clear()
            dsPNL_Report.Tables("PROFIT_LOSS_ACCOUNT_NOTE").Rows.Clear()

            dsPNL_Report.Tables("DIVIDEND_INCOME").Rows.Clear()
            dsPNL_Report.Tables("EXEMPT_DIVIDEND").Rows.Clear()
            dsPNL_Report.Tables("EXPENSES_RENTAL_DETAIL").Rows.Clear()
            dsPNL_Report.Tables("EXPENSES_RENTAL").Rows.Clear()
            dsPNL_Report.Tables("RENTAL_INCOME").Rows.Clear()
            dsPNL_Report.Tables("PNL_QUICK_DETAIL_SUB").Rows.Clear()
            dsPNL_Report.Tables("PNL_QUICK_DETAIL").Rows.Clear()
            dsPNL_Report.Tables("PNL_TABLE_INFO").Rows.Clear()

            dsPNL_Report.Tables("PROFIT_LOSS_ACCOUNT_REPORT_KEYNAME").Rows.Clear()
            dsPNL_Report.Tables("PROFIT_LOSS_ACCOUNT_REPORT_SCH").Rows.Clear()
            dsPNL_Report.Tables("PROFIT_LOSS_ACCOUNT_REPORT").Rows.Clear()
            Application.DoEvents()
            If dtInfo IsNot Nothing Then
                Dim dtRow As DataRow = Nothing
                Dim dtRowSch As DataRow = Nothing
                Dim TableName As String = Nothing
                Dim TableName_Details As String = Nothing
                Dim ColumnSourceNo As String = Nothing
                Dim ColumnSourceNo_Details As String = Nothing
                Dim ColumnAmount As String = Nothing
                Dim ColumnAmount_Details As String = Nothing
                Dim ColumnTable As String = Nothing
                Dim ColumnName As String = Nothing
                Dim ColumnTable_Details As String = Nothing
                Dim ColumnTable_Details_Key As String = Nothing
                Dim ColumnAddBack As String = Nothing
                Dim ColumnAddBack_Details As String = Nothing
                Dim ColumnDeduct As String = Nothing
                Dim ColumnDeduct_Details As String = Nothing
                Dim ColumnPercentage As String = Nothing
                Dim Type As Integer = 0
                Dim LabelName As String = Nothing
                Dim PrefixName As String = Nothing
                Dim IntSch As Integer = 0
                Dim SourceNoTmp As Integer = 0
                Dim SourceNoTmp_count As Integer = 0
                Dim dtRowSourceNo As DataRow = Nothing
                Dim clsNote As clsNote_PNL = Nothing
                If clsNote Is Nothing Then
                    clsNote = New clsNote_PNL
                End If

                Dim dtPNL As DataTable = ADO.Load_PNL(RefNo, YA, ErrorLog)
                Dim PL_KEY As Integer = 0

                If dtPNL IsNot Nothing Then
                    For Each rowx As DataRow In dtPNL.Rows
                        PL_KEY = rowx("PL_KEY")
                        dsPNL_Report.Tables("PROFIT_LOSS_ACCOUNT_REPORT").ImportRow(rowx)
                    Next
                Else
                    MsgBox("Profit and loss not found for YA " & YA, MsgBoxStyle.Critical)
                    Return Nothing
                End If

                dtRowSch = dsPNL_Report.Tables("PROFIT_LOSS_ACCOUNT_REPORT_SCH").NewRow
                dtRowSch("PL_KEY") = PL_KEY

                For Each rowx As DataRow In dtInfo.Rows
                    KeyNameEnum = [Enum].Parse(GetType(TaxComPNLEnuItem), IIf(IsDBNull(rowx("KeyName")), "", rowx("KeyName")))
                    mdlPNL2.PNL_GetData(PL_KEY, KeyNameEnum, RefNo, YA, dsDataSet_Report, ErrorLog, isHaveData, True, clsNote)
                Next
                For Each rowx As DataRow In dtInfo.Rows
                    'PNL QUICK
                    '  dsPNL_Report.Tables("PNL_TABLE_INFO").ImportRow (
                    dtRow = Nothing

                    If IsDBNull(rowx("KeyName")) = False Then
                        dtRow = dsPNL_Report.Tables("PNL_TABLE_INFO").NewRow


                        For Each colx As DataColumn In dtPNLInfo.Columns
                            dtRow(colx.ColumnName) = rowx(colx.ColumnName)
                        Next


                        TableName = IIf(IsDBNull(rowx("TableName")), "", rowx("TableName"))
                        TableName_Details = IIf(IsDBNull(rowx("TableName_Details")), "", rowx("TableName_Details"))
                        ColumnSourceNo = IIf(IsDBNull(rowx("ColumnSourceNo")), "", rowx("ColumnSourceNo"))
                        ColumnSourceNo_Details = IIf(IsDBNull(rowx("ColumnSourceNo_Details")), "", rowx("ColumnSourceNo_Details"))
                        ColumnDescription = IIf(IsDBNull(rowx("ColumnDescription")), "", rowx("ColumnDescription"))
                        ColumnDescription_Details = IIf(IsDBNull(rowx("ColumnDescription_Details")), "", rowx("ColumnDescription_Details"))
                        ColumnAmount = IIf(IsDBNull(rowx("ColumnAmount")), "", rowx("ColumnAmount"))
                        ColumnAmount_Details = IIf(IsDBNull(rowx("ColumnAmount_Details")), "", rowx("ColumnAmount_Details"))
                        ColumnTable = IIf(IsDBNull(rowx("ColumnTable")), "", rowx("ColumnTable"))
                        ColumnTable_Details = IIf(IsDBNull(rowx("ColumnTable_Details")), "", rowx("ColumnTable_Details"))
                        ColumnAddBack = IIf(IsDBNull(rowx("ColumnAddBack")), "", rowx("ColumnAddBack"))
                        ColumnAddBack_Details = IIf(IsDBNull(rowx("ColumnAddBack_Details")), "", rowx("ColumnAddBack_Details"))
                        ColumnDeduct = IIf(IsDBNull(rowx("ColumnDeduct")), "", rowx("ColumnDeduct"))
                        ColumnDeduct_Details = IIf(IsDBNull(rowx("ColumnDeduct_Details")), "", rowx("ColumnDeduct_Details"))
                        ColumnPercentage = IIf(IsDBNull(rowx("ColumnPecentage_Amount")), "", rowx("ColumnPecentage_Amount"))
                        ColumnName = IIf(IsDBNull(rowx("ColumnName")), "", rowx("ColumnName"))
                        ColumnTable_Details_Key = IIf(IsDBNull(rowx("ColumnTable_Details_Key")), "", rowx("ColumnTable_Details_Key"))
                        Type = IIf(IsDBNull(rowx("Type")), 1, rowx("Type"))
                        PrefixName = IIf(IsDBNull(rowx("PrefixName")), "", rowx("PrefixName"))

                        If isVersionLicenseType = VersionLicenseType.Tricor Then
                            LabelName = IIf(IsDBNull(rowx("LabelNameTricor")), "", rowx("LabelNameTricor"))
                        Else
                            LabelName = IIf(IsDBNull(rowx("LabelName")), "", rowx("LabelName"))
                        End If
                        GetSubItemData(dsPNL_Report, rowx("KeyName"), TableName, TableName_Details,
                                       ColumnSourceNo, ColumnSourceNo_Details,
                                       ColumnDescription, ColumnDescription_Details,
                                       ColumnAmount, ColumnAmount_Details, ColumnTable, ColumnTable_Details, ColumnTable_Details_Key,
                                       ColumnAddBack, ColumnAddBack_Details, ColumnDeduct, ColumnDeduct_Details,
                                       ColumnPercentage, Type, PrefixName, LabelName, IntSch, ColumnName, PL_KEY, dtRow, clsNote, dsDataSet_Report)
                        If dtRow("Sch").ToString = " " Then
                            dtRowSch(ColumnName) = ""
                        Else
                            dtRowSch(ColumnName) = "Sch " & dtRow("Sch").ToString.Replace("Schedule ", "")
                        End If

                    End If

                Next

                dsPNL_Report.Tables("PROFIT_LOSS_ACCOUNT_REPORT_SCH").Rows.Add(dtRowSch)

                Application.DoEvents()

                Dim ID_TMP As String = Format(Now, "ddMMMyyyyHHmmss") & My.Computer.Name
                Application.DoEvents()
                While ADO.CheckExist_PROFIT_LOSS_ACCOUNT_REPORT_SOURCE_COUNT(ID_TMP, ErrorLog)
                    Application.DoEvents()
                    ID_TMP = Format(Now, "ddMMMyyyyHHmmss") & My.Computer.Name & RandomID(3)
                End While

                If ADO.Save_PROFIT_LOSS_ACCOUNT_REPORT_SOURCE_COUNT(dsPNL_Report, ID_TMP, ErrorLog) = False Then
                    MsgBox("Failed to searching source no.", MsgBoxStyle.Critical)
                    Return Nothing
                End If

                Dim CompanyName As String = Nothing

                CompanyName = ADO.LoadTaxPayer_CompanyName(RefNo)
                Dim rptPNL_Report As New rptPNL_DetailsNew
                rptPNL_Report.paramCompanyName.Value = CompanyName
                rptPNL_Report.paramID.Value = ID_TMP
                rptPNL_Report.paramYA.Value = CInt(YA)
                ' rptPNL_Report.paramKeyName.Value = "EXPOTHERSEXPENSES"
                rptPNL_Report.DataSource = dsPNL_Report
                rptPNL_Report.SubrptPNL_Details1_Income.ReportSource.DataSource = dsPNL_Report
                rptPNL_Report.SubrptPNL_Details1_Expenses.ReportSource.DataSource = dsPNL_Report
                rptPNL_Report.SubrptPNL_NoteNew.ReportSource.DataSource = dsPNL_Report
                rptPNL_Report.SubrptPNL_Details_DividendIncome.ReportSource.DataSource = dsPNL_Report
                rptPNL_Report.SubrptPNL_Details1_RentalIncome.ReportSource.DataSource = dsPNL_Report
                rptPNL_Report.SubrptPNL_Details1_ExemptDividend.ReportSource.DataSource = dsPNL_Report
                rptPNL_Report.SubrptPNL_Details1_RentalExpenses.ReportSource.DataSource = dsPNL_Report
                '  rptPNL_Report.XrSubreport8.ReportSource.DataSource = dsPNL_Report
                '  rptPNL_Report.rpt_Note1.ReportSource.DataSource = dsPNL_Report
                'Dim rpt_Note1 As XRSubreport = rptPNL_Report.XrSubreport1.ReportSource.FindControl("rpt_Note", True)
                'rpt_Note1.Report.DataSource = dsPNL_Report
                'Dim rpt_Note2 As XRSubreport = rptPNL_Report.XrSubreport2.ReportSource.FindControl("rpt_Note", True)
                'rpt_Note2.Report.DataSource = dsPNL_Report

                'rptPNL_Report.ShowPreview()
                Dim rpt As New rptPNLNew

                rpt.paramCompanyName.Value = CompanyName
                rpt.paramYA.Value = CInt(YA)
                rpt.paramID.Value = ID_TMP
                rpt.param_ShowDraft.Value = ShowDraft

                If Title <> "" Then
                    Dim dtTaxPayer As DataTable = ADO.LoadTaxPayer_ByRefNO(RefNo, ErrorLog)

                    If dtTaxPayer IsNot Nothing Then
                        Dim Acc_Fr As DateTime = Now
                        Dim Acc_To As DateTime = Now
                        If IsDBNull(dtTaxPayer.Rows(0)("TP_ACC_PERIOD_FR")) = False Then
                            Acc_Fr = dtTaxPayer.Rows(0)("TP_ACC_PERIOD_FR")
                        Else
                            Acc_Fr = New Date(CInt(YA), 1, 1)
                        End If
                        If IsDBNull(dtTaxPayer.Rows(0)("TP_ACC_PERIOD_TO")) = False Then
                            Acc_To = dtTaxPayer.Rows(0)("TP_ACC_PERIOD_TO")
                        Else
                            Acc_To = New Date(CInt(YA), 12, 31)
                        End If

                        Title += " for the Period from " & Format(Acc_Fr, "dd.MM.yyyy") & " to " & Format(Acc_To, "dd.MM.yyyy")
                    End If

                End If

                rpt.paramTitle.Value = Title
                rpt.ParamSch.Value = SchApex
                If isVersionLicenseType = VersionLicenseType.Tricor Then
                    rpt.isTricor.Value = True
                Else
                    rpt.isTricor.Value = False
                End If
                rpt.XrSubreport1.ReportSource = rptPNL_Report
                rpt.DataSource = dsPNL_Report
                rpt.CreateDocument()


                If GetInterestRestrictedData(dsPNL_Report, PL_KEY, RefNo, YA) = True Then
                    If dsPNL_Report.Tables("INTEREST_RESTRIC_MONTLY_REPORT_Tricor").Rows.Count > 0 Then
                        Dim TotalColumn As Integer = 0
                        TotalColumn = IIf(IsDBNull(dsPNL_Report.Tables("INTEREST_RESTRIC_MONTLY_REPORT_Tricor").Rows(0)("TotalColumn")), 12, dsPNL_Report.Tables("INTEREST_RESTRIC_MONTLY_REPORT_Tricor").Rows(0)("TotalColumn"))

                        Select Case TotalColumn
                            Case 12
                                Dim rpt_Interest_sub As New rptPNL_InterestResict12
                                rpt_Interest_sub.paramCompanyName.Value = ADO.LoadTaxPayer_CompanyName(RefNo)
                                rpt_Interest_sub.paramYA.Value = CInt(YA)
                                rpt_Interest_sub.DataSource = dsPNL_Report
                                rpt_Interest_sub.param_ShowDraft.Value = ShowDraft
                                rpt_Interest_sub.CreateDocument()
                                rpt_Interest = rpt_Interest_sub
                            Case 13
                                Dim rpt_Interest_sub As New rptPNL_InterestResict13
                                rpt_Interest_sub.paramCompanyName.Value = ADO.LoadTaxPayer_CompanyName(RefNo)
                                rpt_Interest_sub.paramYA.Value = CInt(YA)
                                rpt_Interest_sub.DataSource = dsPNL_Report
                                rpt_Interest_sub.param_ShowDraft.Value = ShowDraft
                                rpt_Interest_sub.CreateDocument()
                                rpt_Interest = rpt_Interest_sub
                            Case 14
                                Dim rpt_Interest_sub As New rptPNL_InterestResict14
                                rpt_Interest_sub.paramCompanyName.Value = ADO.LoadTaxPayer_CompanyName(RefNo)
                                rpt_Interest_sub.paramYA.Value = CInt(YA)
                                rpt_Interest_sub.param_ShowDraft.Value = ShowDraft
                                rpt_Interest_sub.DataSource = dsPNL_Report
                                rpt_Interest_sub.CreateDocument()
                                rpt_Interest = rpt_Interest_sub
                            Case 15
                                Dim rpt_Interest_sub As New rptPNL_InterestResict15
                                rpt_Interest_sub.paramCompanyName.Value = ADO.LoadTaxPayer_CompanyName(RefNo)
                                rpt_Interest_sub.paramYA.Value = CInt(YA)
                                rpt_Interest_sub.param_ShowDraft.Value = ShowDraft
                                rpt_Interest_sub.DataSource = dsPNL_Report
                                rpt_Interest_sub.CreateDocument()
                                rpt_Interest = rpt_Interest_sub
                            Case 16
                                Dim rpt_Interest_sub As New rptPNL_InterestResict16
                                rpt_Interest_sub.paramCompanyName.Value = ADO.LoadTaxPayer_CompanyName(RefNo)
                                rpt_Interest_sub.paramYA.Value = CInt(YA)
                                rpt_Interest_sub.param_ShowDraft.Value = ShowDraft
                                rpt_Interest_sub.DataSource = dsPNL_Report
                                rpt_Interest_sub.CreateDocument()
                                rpt_Interest = rpt_Interest_sub
                            Case 17
                                Dim rpt_Interest_sub As New rptPNL_InterestResict17
                                rpt_Interest_sub.paramCompanyName.Value = ADO.LoadTaxPayer_CompanyName(RefNo)
                                rpt_Interest_sub.paramYA.Value = CInt(YA)
                                rpt_Interest_sub.param_ShowDraft.Value = ShowDraft
                                rpt_Interest_sub.DataSource = dsPNL_Report
                                rpt_Interest_sub.CreateDocument()
                                rpt_Interest = rpt_Interest_sub
                            Case 18
                                Dim rpt_Interest_sub As New rptPNL_InterestResict18
                                rpt_Interest_sub.paramCompanyName.Value = ADO.LoadTaxPayer_CompanyName(RefNo)
                                rpt_Interest_sub.paramYA.Value = CInt(YA)
                                rpt_Interest_sub.param_ShowDraft.Value = ShowDraft
                                rpt_Interest_sub.DataSource = dsPNL_Report
                                rpt_Interest_sub.CreateDocument()
                                rpt_Interest = rpt_Interest_sub
                        End Select

                    End If

                End If
                rpt.PrintingSystem.ContinuousPageNumbering = True
                Return rpt

                ' Dim printTool As New ReportPrintTool(rpt)
                '  printTool.ShowPreviewDialog()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Private Sub GetSubItemData(ByRef dsPNL_Report As DataSet, ByVal KeyName As String, ByVal TableName As String, ByVal TableName_Details As String, _
                  ByVal ColumnSourceNo As String, ByVal ColumnSourceNo_Details As String,
                  ByVal ColumnDescription As String, ByVal ColumnDescription_Details As String, _
                  ByVal ColumnAmount As String, ByVal ColumnAmount_Details As String, _
                  ByVal ColumnTable As String, ByVal ColumnTable_Details As String, ByVal ColumnTable_Details_Key As String, _
                  ByVal ColumnAddBack As String, ByVal ColumnAddBack_Details As String, _
                  ByVal ColumnDeduct As String, ByVal ColumnDeduct_Details As String, _
                  ByVal ColumnPercentage As String, ByVal Type As Integer, ByVal PrefixName As String, _
                  ByVal LabelName As String, ByRef IntSch As Integer, ByVal ColumnName As String, _
                  ByVal PL_KEY As Integer, ByRef PNLINFO_ROW As DataRow, ByRef clsNote As clsNote_PNL, ByVal dsDataSet_Report As DataSet)
        Try
            If dsDataSet_Report Is Nothing Then
                Exit Sub
            End If
            Dim dtRow As DataRow = Nothing
            Dim dtRowChild As DataRow = Nothing
            Dim TmpID As Integer = 0
            Dim TotalAmount As Decimal = 0
            Dim TotalPecentage As Decimal = 0
            Dim dtExclude As DataTable = Nothing

            If IsDBNull(PNLINFO_ROW("Type")) = False AndAlso (PNLINFO_ROW("Type") = 2 OrElse PNLINFO_ROW("Type") = 3) Then
                Select Case KeyName
                    Case "PURCHASE", "DEPRECIATION", "OTHERALLOWEXP", "OTHERNONALLOWEXP"
                        If dsDataSet_Report.Tables(TableName).Rows.Count > 0 Then
                            IntSch += 1
                            PNLINFO_ROW("Sch") = "Schedule " & IntSch.ToString
                        End If
                    Case Else
                        dtExclude = Nothing
                        dtExclude = ADO.Load_PNL_IncludeInReport(PL_KEY, ColumnName)
                        If dsDataSet_Report.Tables(TableName).Rows.Count > 0 Then
                            If dtExclude IsNot Nothing Then
                                IntSch += 1
                                PNLINFO_ROW("Sch") = "Schedule " & IntSch.ToString
                            Else
                                PNLINFO_ROW("Sch") = " "
                            End If
                        Else
                            PNLINFO_ROW("Sch") = " "
                        End If
                End Select

            Else
                If dsDataSet_Report.Tables(TableName).Rows.Count > 0 Then
                    IntSch += 1
                    PNLINFO_ROW("Sch") = "Schedule " & IntSch.ToString
                End If

            End If
          
            dsPNL_Report.Tables("PNL_TABLE_INFO").Rows.Add(PNLINFO_ROW)

            Select Case KeyName
                Case "DIVIDENDINC"
                    For Each rowx As DataRow In dsDataSet_Report.Tables(TableName).Rows
                        If IsDBNull(rowx(ColumnAmount)) = False AndAlso IsNumeric(rowx(ColumnAmount)) Then
                            TotalAmount += rowx(ColumnAmount)
                        End If
                    Next
                    For Each rowx As DataRow In dsDataSet_Report.Tables(TableName).Rows
                        dtRow = Nothing
                        TmpID = -1
                        dtRow = dsPNL_Report.Tables("DIVIDEND_INCOME").NewRow
                        dtRow("DI_KEY") = rowx("DI_KEY")
                        dtRow("DI_DIVIDENDKEY") = rowx("DI_DIVIDENDKEY")
                        dtRow("DI_DATE") = rowx("DI_DATE")
                        dtRow("DI_COMPANY") = rowx("DI_COMPANY")
                        dtRow("DI_GROSS") = rowx("DI_GROSS")
                        dtRow("DI_TAX") = rowx("DI_TAX")
                        dtRow("DI_WARANT_NO") = rowx("DI_WARANT_NO")
                        dtRow("DI_CHKREGROSS") = rowx("DI_CHKREGROSS")
                        dtRow("DI_TAXRATE") = rowx("DI_TAXRATE")
                        dtRow("DI_REGROSS") = rowx("DI_REGROSS")
                        dtRow("DI_TAXDEDUCTION") = rowx("DI_TAXDEDUCTION")
                        dtRow("DI_NETDEDUCTION") = rowx("DI_NETDEDUCTION")
                        dtRow("DI_ENDDATE") = rowx("DI_ENDDATE")
                        dtRow("DI_TRATE") = rowx("DI_TRATE")
                        dtRow("DI_SOURCENO") = rowx("DI_SOURCENO")
                        dtRow("DI_DISCLOSE") = rowx("DI_DISCLOSE")
                        dtRow("DI_TRANSFER") = rowx("DI_TRANSFER")
                        dtRow("DI_NET") = rowx("DI_NET")
                        dtRow("DI_Percentage") = 0
                        dtRow("DI_PercentageAmount") = 0
                        dtRow("Note") = GetTitle_Note(PL_KEY, KeyName, True, rowx(ColumnTable), -1)
                        dtRow("KEYNAME") = KeyName
                        dtRow("TITLE") = LabelName & " - RM" & TotalAmount.ToString("N0")
                        dtRow("SCH") = ""
                        dtRow("TOTAL_AMOUNT") = TotalAmount
                        dsPNL_Report.Tables("DIVIDEND_INCOME").Rows.Add(dtRow)
                    Next
                Case "RENTALINC"
                    For Each rowx As DataRow In dsDataSet_Report.Tables(TableName).Rows
                        If IsDBNull(rowx(ColumnAmount)) = False AndAlso IsNumeric(rowx(ColumnAmount)) Then
                            TotalAmount += rowx(ColumnAmount)
                        End If
                    Next
                    For Each rowx As DataRow In dsDataSet_Report.Tables(TableName).Rows
                        dtRow = Nothing
                        TmpID = -1
                        dtRow = dsPNL_Report.Tables("RENTAL_INCOME").NewRow
                        dtRow("RI_KEY") = rowx("RI_KEY")
                        dtRow("RI_RENTKEY") = rowx("RI_RENTKEY")
                        dtRow("RI_TYPE") = rowx("RI_TYPE")
                        dtRow("RI_ADDRESS") = rowx("RI_ADDRESS")
                        dtRow("RI_DATE") = rowx("RI_DATE")
                        dtRow("RI_AMOUNT") = rowx("RI_AMOUNT")
                        dtRow("RI_SOURCENO") = rowx("RI_SOURCENO")
                        dtRow("RI_STATUS4d") = rowx("RI_STATUS4d")
                        dtRow("RI_DATE_END") = rowx("RI_DATE_END")
                        dtRow("Note") = GetTitle_Note(PL_KEY, KeyName, True, rowx(ColumnTable), -1)
                        dtRow("KEYNAME") = KeyName
                        dtRow("TITLE") = LabelName & " - RM" & TotalAmount.ToString("N0")
                        dtRow("SCH") = ""
                        dtRow("TOTAL_AMOUNT") = TotalAmount
                        dsPNL_Report.Tables("RENTAL_INCOME").Rows.Add(dtRow)
                    Next
                Case "EXEMDIV"
                    For Each rowx As DataRow In dsDataSet_Report.Tables(TableName).Rows
                        If IsDBNull(rowx(ColumnAmount)) = False AndAlso IsNumeric(rowx(ColumnAmount)) Then
                            TotalAmount += rowx(ColumnAmount)
                        End If
                    Next
                    For Each rowx As DataRow In dsDataSet_Report.Tables(TableName).Rows
                        dtRow = Nothing
                        TmpID = -1
                        dtRow = dsPNL_Report.Tables("EXEMPT_DIVIDEND").NewRow
                        dtRow("ED_KEY") = rowx("ED_KEY")
                        dtRow("ED_EDKEY") = rowx("ED_EDKEY")
                        dtRow("ED_DATE") = rowx("ED_DATE")
                        dtRow("ED_COMPANY") = rowx("ED_COMPANY")
                        dtRow("ED_AMOUNT") = rowx("ED_AMOUNT")
                        dtRow("ED_TIERSTATUS") = rowx("ED_TIERSTATUS")
                        dtRow("ED_SOURCENO") = rowx("ED_SOURCENO")
                        dtRow("Note") = GetTitle_Note(PL_KEY, KeyName, True, rowx(ColumnTable), -1)
                        dtRow("KEYNAME") = KeyName
                        dtRow("TITLE") = LabelName & " - RM" & TotalAmount.ToString("N0")
                        dtRow("SCH") = ""
                        dtRow("TOTAL_AMOUNT") = TotalAmount
                        dsPNL_Report.Tables("EXEMPT_DIVIDEND").Rows.Add(dtRow)
                    Next
                Case "EXPRENTAL"
                    For Each rowx As DataRow In dsDataSet_Report.Tables(TableName).Rows
                        If IsDBNull(rowx(ColumnAmount)) = False AndAlso IsNumeric(rowx(ColumnAmount)) Then
                            TotalAmount += rowx(ColumnAmount)
                        End If
                        Select Case Type
                            Case 2, 3
                                'Without Percentage
                                If IsDBNull(rowx("PecentageAmount")) = False AndAlso IsNumeric(rowx("PecentageAmount")) Then
                                    TotalPecentage += rowx("PecentageAmount")
                                End If
                        End Select
                    Next
                    For Each rowx As DataRow In dsDataSet_Report.Tables(TableName).Rows
                        dtRow = Nothing
                        TmpID = -1
                        dtRow = dsPNL_Report.Tables("EXPENSES_RENTAL").NewRow
                        dtRow("EXRENT_KEY") = rowx("EXRENT_KEY")
                        dtRow("EXRENT_EXRENTKEY") = rowx("EXRENT_EXRENTKEY")
                        dtRow("EXRENT_SOURCENO") = rowx("EXRENT_SOURCENO")
                        dtRow("EXRENT_DESC") = rowx("EXRENT_DESC")
                        dtRow("EXRENT_AMOUNT") = rowx("EXRENT_AMOUNT")
                        dtRow("EXRENT_DEDUCTIBLE") = rowx("EXRENT_DEDUCTIBLE")
                        dtRow("EXRENT_NOTE") = rowx("EXRENT_NOTE")
                        dtRow("EXRENT_DETAIL") = rowx("EXRENT_DETAIL")
                        dtRow("EXRENT_DEDUCTIBLE_ADD") = rowx("EXRENT_DEDUCTIBLE_ADD")
                        dtRow("RowIndex") = rowx("RowIndex")
                        dtRow("PecentageAmount") = rowx("PecentageAmount")
                        dtRow("Address") = rowx("Address")
                        dtRow("Note") = GetTitle_Note(PL_KEY, KeyName, True, rowx(ColumnTable), -1)
                        dtRow("KEYNAME") = KeyName
                        dtRow("TITLE") = LabelName & " - RM" & TotalAmount.ToString("N0")
                        dtRow("SCH") = ""
                        dtRow("TOTAL_PECENTAGE") = TotalPecentage
                        dtRow("TOTAL_AMOUNT") = TotalAmount
                        dsPNL_Report.Tables("EXPENSES_RENTAL").Rows.Add(dtRow)
                        Application.DoEvents()

                        TmpID = dsPNL_Report.Tables("EXPENSES_RENTAL").Rows(dsPNL_Report.Tables("EXPENSES_RENTAL").Rows.Count - 1)("EXRENT_EXRENTKEY")

                        If TableName_Details <> "" Then
                            For Each rowChild As DataRow In dsDataSet_Report.Tables(TableName_Details).Rows
                                If IsDBNull(rowx(ColumnTable)) = False AndAlso IsDBNull(rowChild(ColumnTable_Details)) = False AndAlso
                                    rowx(ColumnTable) = rowChild(ColumnTable_Details) AndAlso TmpID <> -1 Then
                                    dtRowChild = Nothing
                                    dtRowChild = dsPNL_Report.Tables("EXPENSES_RENTAL_DETAIL").NewRow
                                    dtRowChild("EXRENTD_KEY") = rowChild("EXRENTD_KEY")
                                    dtRowChild("EXRENTD_EXRENTKEY") = TmpID
                                    dtRowChild("EXRENTD_SOURCENO") = rowChild("EXRENTD_SOURCENO")
                                    dtRowChild("EXRENTD_EXRENTDKEY") = rowChild("EXRENTD_EXRENTDKEY")
                                    dtRowChild("EXRENTD_DESC") = rowChild("EXRENTD_DESC")
                                    dtRowChild("EXRENTD_DEDUCTIBLE") = rowChild("EXRENTD_DEDUCTIBLE")
                                    dtRowChild("EXRENTD_AMOUNT") = rowChild("EXRENTD_AMOUNT")
                                    dtRowChild("EXRENTD_NOTE") = rowChild("EXRENTD_NOTE")
                                    dtRowChild("EXRENTD_DEDUCTIBLE_ADD") = rowChild("EXRENTD_DEDUCTIBLE_ADD")
                                    dtRowChild("RowIndex") = rowChild("RowIndex")
                                    dtRowChild("PecentageAmount") = rowChild("PecentageAmount")
                                    dtRowChild("Address") = rowChild("Address")
                                    dtRowChild("Note") = GetTitle_Note(PL_KEY, KeyName, False, rowChild(ColumnTable_Details), rowChild(ColumnTable_Details_Key))
                                    dsPNL_Report.Tables("EXPENSES_RENTAL_DETAIL").Rows.Add(dtRowChild)

                                End If
                            Next
                        End If
                    Next
                Case "INTERESTRESTRICT"
                    For Each rowx As DataRow In dsDataSet_Report.Tables(TableName).Rows
                        If IsDBNull(rowx(ColumnAmount)) = False AndAlso IsNumeric(rowx(ColumnAmount)) Then
                            TotalAmount += rowx(ColumnAmount)
                        End If
                        Select Case Type
                            Case 2, 3
                                'Without Percentage
                                If IsDBNull(rowx("PecentageAmount")) = False AndAlso IsNumeric(rowx("PecentageAmount")) Then
                                    TotalPecentage += rowx("PecentageAmount")
                                End If
                        End Select
                    Next
                    For Each rowx As DataRow In dsDataSet_Report.Tables(TableName).Rows
                        dtRow = Nothing
                        TmpID = -1
                        dtRow = dsPNL_Report.Tables("PNL_QUICK_DETAIL").NewRow
                        dtRow("KEYNAME") = KeyName
                        dtRow("SOURCE_NO") = rowx(ColumnSourceNo)
                        dtRow("DESCRIPTION") = rowx(ColumnDescription)
                        dtRow("AMOUNT") = rowx("EXIR_YEAREND")
                        dtRow("TITLE") = LabelName & " - RM" & TotalAmount.ToString("N0")
                        dtRow("SCH") = ""
                        dtRow("TOTAL_AMOUNT") = TotalAmount
                        dtRow("TOTAL_PECENTAGE") = TotalPecentage
                        dtRow("NOTE") = GetTitle_Note(PL_KEY, KeyName, True, rowx(ColumnTable), -1)

                        Select Case Type
                            Case 2
                                'Without Percentage
                                dtRow("DEDUCTIBLE") = rowx(ColumnAddBack)
                                If ColumnDeduct <> "" Then
                                    dtRow("DEDUCTIBLE_ADD") = rowx(ColumnDeduct)
                                Else
                                    dtRow("DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("PECENTAGE") = 100
                                dtRow("PECENTAGE_AMOUNT") = rowx("PecentageAmount")
                            Case 3
                                'Percentage
                                dtRow("DEDUCTIBLE") = rowx(ColumnAddBack)
                                dtRow("DEDUCTIBLE_ADD") = rowx(ColumnDeduct)
                                dtRow("PECENTAGE") = rowx("Pecentage")
                                dtRow("PECENTAGE_AMOUNT") = rowx("PecentageAmount")
                            Case Else
                                'Not Deduct
                                dtRow("DEDUCTIBLE") = False
                                dtRow("DEDUCTIBLE_ADD") = False
                                dtRow("PECENTAGE") = 100
                                dtRow("PECENTAGE_AMOUNT") = 0
                        End Select

                        dsPNL_Report.Tables("PNL_QUICK_DETAIL").Rows.Add(dtRow)
                        Application.DoEvents()
                    Next
                Case Else
                    For Each rowx As DataRow In dsDataSet_Report.Tables(TableName).Rows
                        If IsDBNull(rowx(ColumnAmount)) = False AndAlso IsNumeric(rowx(ColumnAmount)) Then
                            TotalAmount += rowx(ColumnAmount)
                        End If
                        Select Case Type
                            Case 2, 3
                                'Without Percentage
                                If IsDBNull(rowx("PecentageAmount")) = False AndAlso IsNumeric(rowx("PecentageAmount")) Then
                                    TotalPecentage += rowx("PecentageAmount")
                                End If
                        End Select
                    Next
                    For Each rowx As DataRow In dsDataSet_Report.Tables(TableName).Rows
                        dtRow = Nothing
                        TmpID = -1
                        dtRow = dsPNL_Report.Tables("PNL_QUICK_DETAIL").NewRow
                        dtRow("KEYNAME") = KeyName
                        dtRow("SOURCE_NO") = rowx(ColumnSourceNo)
                        dtRow("DESCRIPTION") = rowx(ColumnDescription)
                        dtRow("AMOUNT") = rowx(ColumnAmount)
                        dtRow("TITLE") = LabelName & " - RM" & TotalAmount.ToString("N0")
                        dtRow("SCH") = ""
                        dtRow("TOTAL_AMOUNT") = TotalAmount
                        dtRow("TOTAL_PECENTAGE") = TotalPecentage
                        dtRow("NOTE") = GetTitle_Note(PL_KEY, KeyName, True, rowx(ColumnTable), -1)

                        Select Case Type
                            Case 2
                                'Without Percentage
                                dtRow("DEDUCTIBLE") = rowx(ColumnAddBack)
                                If ColumnDeduct <> "" Then
                                    dtRow("DEDUCTIBLE_ADD") = rowx(ColumnDeduct)
                                Else
                                    dtRow("DEDUCTIBLE_ADD") = False
                                End If
                                If rowx(ColumnAddBack) = True Then
                                    dtRow("PECENTAGE") = 100
                                    dtRow("PECENTAGE_AMOUNT") = rowx("PecentageAmount")
                                Else
                                    dtRow("PECENTAGE") = 0
                                    dtRow("PECENTAGE_AMOUNT") = rowx("PecentageAmount")
                                End If
                                
                            Case 3
                                'Percentage
                                dtRow("DEDUCTIBLE") = rowx(ColumnAddBack)
                                dtRow("DEDUCTIBLE_ADD") = rowx(ColumnDeduct)
                                If rowx(ColumnAddBack) = True Then
                                    dtRow("PECENTAGE") = rowx("Pecentage")
                                    dtRow("PECENTAGE_AMOUNT") = rowx("PecentageAmount")
                                Else
                                    dtRow("PECENTAGE") = 0
                                    dtRow("PECENTAGE_AMOUNT") = rowx("PecentageAmount")
                                End If
                                
                            Case Else
                                'Not Deduct
                                dtRow("DEDUCTIBLE") = False
                                dtRow("DEDUCTIBLE_ADD") = False
                                dtRow("PECENTAGE") = 100
                                dtRow("PECENTAGE_AMOUNT") = 0
                        End Select

                        dsPNL_Report.Tables("PNL_QUICK_DETAIL").Rows.Add(dtRow)
                        Application.DoEvents()

                        TmpID = dsPNL_Report.Tables("PNL_QUICK_DETAIL").Rows(dsPNL_Report.Tables("PNL_QUICK_DETAIL").Rows.Count - 1)("ID")

                        If TableName_Details <> "" Then
                            For Each rowChild As DataRow In dsDataSet_Report.Tables(TableName_Details).Rows

                                If IsDBNull(rowx(ColumnTable)) = False AndAlso IsDBNull(rowChild(ColumnTable_Details)) = False AndAlso
                                    rowx(ColumnTable) = rowChild(ColumnTable_Details) AndAlso TmpID <> -1 Then

                                    dtRowChild = Nothing
                                    dtRowChild = dsPNL_Report.Tables("PNL_QUICK_DETAIL_SUB").NewRow
                                    dtRowChild("PARENT_ID") = TmpID
                                    dtRowChild("KEYNAME") = KeyName
                                    dtRowChild("SOURCE_NO") = rowChild(ColumnSourceNo_Details)
                                    dtRowChild("DESCRIPTION") = rowChild(ColumnDescription_Details)
                                    dtRowChild("AMOUNT") = rowChild(ColumnAmount_Details)
                                    dtRowChild("NOTE") = GetTitle_Note(PL_KEY, KeyName, False, rowChild(ColumnTable_Details), rowChild(ColumnTable_Details_Key))

                                    Select Case Type
                                        Case 2
                                            'Without Percentage
                                            dtRowChild("DEDUCTIBLE") = rowChild(ColumnAddBack_Details)
                                            If ColumnDeduct_Details <> "" Then
                                                dtRowChild("DEDUCTIBLE_ADD") = rowChild(ColumnDeduct_Details)
                                            Else
                                                dtRowChild("DEDUCTIBLE_ADD") = False
                                            End If
                                            If rowChild(ColumnAddBack_Details) = True Then
                                                dtRowChild("PECENTAGE") = 100
                                                dtRowChild("PECENTAGE_AMOUNT") = rowChild("PecentageAmount")
                                            Else
                                                dtRowChild("PECENTAGE") = 0
                                                dtRowChild("PECENTAGE_AMOUNT") = rowChild("PecentageAmount")
                                            End If
                                            
                                        Case 3
                                            'Percentage
                                            dtRowChild("DEDUCTIBLE") = rowChild(ColumnAddBack_Details)
                                            dtRowChild("DEDUCTIBLE_ADD") = rowChild(ColumnDeduct_Details)
                                            If rowChild(ColumnAddBack_Details) = True Then
                                                dtRowChild("PECENTAGE") = rowChild("Pecentage")
                                                dtRowChild("PECENTAGE_AMOUNT") = rowChild("PecentageAmount")
                                            Else
                                                dtRowChild("PECENTAGE") = 0
                                                dtRowChild("PECENTAGE_AMOUNT") = rowChild("PecentageAmount")
                                            End If
                                            
                                        Case Else
                                            'Not Deduct
                                            dtRowChild("DEDUCTIBLE") = False
                                            dtRowChild("DEDUCTIBLE_ADD") = False
                                            dtRowChild("PECENTAGE") = 100
                                            dtRowChild("PECENTAGE_AMOUNT") = 0
                                    End Select

                                    dsPNL_Report.Tables("PNL_QUICK_DETAIL_SUB").Rows.Add(dtRowChild)

                                End If

                            Next
                        End If

                    Next
            End Select

            'Select Case KeyName
            '    Case TaxComPNLEnuItem.SALES

            'End Select


            Dim dtNote As DataTable
            dtNote = Nothing
            dtNote = clsNote.Load_Note(PL_KEY, KeyName)
            If dtNote IsNot Nothing Then
                Dim dtRowAtt As Byte() = Nothing
                Dim Ext As String = Nothing
                For Each rowx As DataRow In dtNote.Rows
                    If KeyName = "EXPSALARY" Then
                        Dim x As String = Nothing
                    End If
                    dsPNL_Report.Tables("PROFIT_LOSS_ACCOUNT_NOTE").ImportRow(rowx)

                    If IsDBNull(rowx("TypeNote")) = False Then
                        Select Case rowx("TypeNote")
                            Case 1
                                'Column
                                dtNoteColumn = Nothing
                                dtNoteColumn = clsNote.Load_Note_Column(rowx("ID"), ErrorLog)

                                If dtNoteColumn IsNot Nothing Then
                                    For Each rowy As DataRow In dtNoteColumn.Rows
                                        dsPNL_Report.Tables("PROFIT_LOSS_ACCOUNT_NOTE_COLUMN").ImportRow(rowy)
                                    Next

                                End If
                            Case 2
                                'Attachment
                                dtNoteAttch = clsNote.Load_Note_Attachment(rowx("ID"), ErrorLog)

                                If dtNoteAttch IsNot Nothing Then

                                    For Each rowy As DataRow In dtNoteAttch.Rows
                                        dtRowAtt = Nothing
                                        Ext = Nothing
                                        dtRowAtt = IIf(IsDBNull(rowy("Attachment")), Nothing, rowy("Attachment"))
                                        Ext = IIf(IsDBNull(rowy("Extension")), Nothing, rowy("Extension"))

                                        If dtRowAtt IsNot Nothing Then
                                            Dim frmnote As New frmNote_AttachmentView
                                            Select Case Ext.ToLower
                                                Case ".jpg", ".png", ".jpeg", ".bitmap", ".ico", ".gif", ".tif"
                                                    frmnote.Type = 0
                                                Case ".xls", ".xlsx", ".csv", ".openxml"
                                                    frmnote.Type = 1
                                                Case ".doc", "docx", ".rtf", ".wordml", ".opendocument"
                                                    frmnote.Type = 2
                                                Case ".pdf"
                                                    frmnote.Type = 3
                                            End Select
                                            frmnote.Title = IIf(IsDBNull(rowx("Title")), Nothing, rowx("Title"))
                                            frmnote.Extension = Ext
                                            frmnote.dataArr = dtRowAtt
                                            frmnote.Show()

                                        End If
                                    Next

                                End If


                        End Select

                    End If
                Next
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
        End Try
    End Sub
    Private Function GetInterestRestrictedData(ByRef dsPNL_Report As DataSet, ByVal PL_KEY As Integer, ByVal RefNo_ As String, ByVal YA_ As String) As Boolean
        Try
            Dim dtPNLInterestRestrict As DataTable = Nothing

            dtPNLInterestRestrict = ADO.Load_PNL_expenses_interestrestrict(PL_KEY)

            dsPNL_Report.Tables("INTEREST_RESTRIC_MONTLY_REPORT_Tricor").Rows.Clear()
            dsPNL_Report.Tables("REF_INTEREST_RESTRIC_DETAIL_MONTHLY").Rows.Clear()
            dsPNL_Report.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Rows.Clear()
            dsPNL_Report.Tables("REF_INTEREST_RESTRIC_DETAIL").Rows.Clear()
            dsPNL_Report.Tables("expenses_interestrestrict").Rows.Clear()

            Dim tmpDt_Data As DataTable = Nothing
            If dtPNLInterestRestrict IsNot Nothing Then

                For Each rowx As DataRow In dtPNLInterestRestrict.Rows
                    If mdlPNL2.CheckIDExistInTable(dsPNL_Report, "expenses_interestrestrict", "EXIR_EXIRKEY", rowx("EXIR_EXIRKEY")) = False Then
                        tmpDt_Data = Nothing

                        tmpDt_Data = ADO.Load_REF_INTEREST_RESTRIC_MONTHLY_TRICOR(rowx("EXIR_SOURCENO"), RefNo_, YA_, ErrorLog)

                        mdlPNL2.LoadTable_InterestRestricted(dsPNL_Report, RefNo_, YA_, rowx("EXIR_SOURCENO"), rowx("EXIR_EXIRKEY"), ErrorLog)

                        If tmpDt_Data IsNot Nothing Then
                            'For i As Integer = 0 To tmpDt_Data.Rows.Count - 1
                            '    dsPNL_Report.Tables("REF_INTEREST_RESTRIC_DETAIL_TRICOR_TEMP").ImportRow(tmpDt_Data.Rows(i))
                            'Next
                            ''  mdlPNL2.AppenData_InterestRestricted(tmpDt_Data, dsPNL_Report, ErrorLog)
                            ''  Application.DoEvents()
                            'ADO.SAVE_EXPENSES_INTERESTRESTRICT_TRICOR_TEMP(PL_KEY, dsPNL_Report.Tables("INTEREST_RESTRIC_MONTLY_REPORT"), RefNo_,
                            '                                                YA_, rowx("EXIR_SOURCENO"), ErrorLog)

                            mdlPNL2.AppenData_InterestRestricted_Report(tmpDt_Data, dsPNL_Report, RefNo_, YA_, rowx("EXIR_SOURCENO"), ErrorLog)
                        End If

                        tmpDt_Data = Nothing

                        tmpDt_Data = ADO.Load_REF_INTEREST_RESTRIC_DETAIL_YEARLY(rowx("EXIR_SOURCENO"), RefNo_, YA_, ErrorLog)

                        If tmpDt_Data IsNot Nothing Then
                            For x As Integer = 0 To tmpDt_Data.Rows.Count - 1

                                dtRow = Nothing
                                dtRow = dsPNL_Report.Tables("REF_INTEREST_RESTRIC_DETAIL").NewRow
                                dtRow("RIRD_KEY") = tmpDt_Data.Rows(x)("RIRD_KEY")
                                dtRow("RIR_REF_NUM") = tmpDt_Data.Rows(x)("RIR_REF_NUM")
                                dtRow("RIRD_MONTH") = tmpDt_Data.Rows(x)("RIRD_MONTH")
                                dtRow("RIRD_TYPE") = tmpDt_Data.Rows(x)("RIRD_TYPE")
                                dtRow("RIRD_DESC") = tmpDt_Data.Rows(x)("RIRD_DESC")
                                dtRow("RIRD_AMOUNT") = tmpDt_Data.Rows(x)("RIRD_AMOUNT")
                                dtRow("RIRD_NOTE") = tmpDt_Data.Rows(x)("RIRD_NOTE")
                                dtRow("RIRD_SOURCENO") = tmpDt_Data.Rows(x)("RIRD_SOURCENO")
                                dtRow("RIRD_TYPE_INCOME") = tmpDt_Data.Rows(x)("RIRD_TYPE_INCOME")

                                dsPNL_Report.Tables("REF_INTEREST_RESTRIC_DETAIL").Rows.Add(dtRow)
                            Next
                            If ADO.Save_REF_INTEREST_RESTRIC_DETAIL_TEMP(dsPNL_Report.Tables("REF_INTEREST_RESTRIC_DETAIL"), RefNo_, YA_, rowx("EXIR_SOURCENO"), PL_KEY,
                                                          0, ErrorLog, False) = False Then

                            End If
                        End If
                    End If
                Next
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Private Function GetTitle_Note(ByVal PL_KEY As Integer, ByVal KeyName As String, ByVal isParent As Boolean, _
                                   ByVal DataID As Integer, ByVal SubData_ID As Integer) As String
        Try
            Dim clsNote As New clsNote_PNL
            Dim dtNote As DataTable = Nothing

            dtNote = clsNote.Load_Note(PL_KEY, KeyName, isParent, DataID, SubData_ID)

            If dtNote IsNot Nothing Then
                Return IIf(IsDBNull(dtNote.Rows(0)("TitleFront")), "", dtNote.Rows(0)("TitleFront")) & " " & IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
            Else
                Return ""
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return ""
        End Try
    End Function
 
End Module
