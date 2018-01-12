Imports System.Data.SqlClient

Module mdlPNL2

    Public Sub ClearMemoryDataset(Optional ByRef ErrorLog As clsError = Nothing)
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
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
        End Try
    End Sub
    Public Function PNL_GetSaveData(ByVal PNL_Key As Decimal, ByVal Type As TaxComPNLEnuItem, _
                                    ByVal oConn As SqlConnection, ByRef ListofCmd As List(Of SqlCommand), Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            Dim contrl As Control = Nothing
            Dim ds As DataSet = Nothing

            Select Case Type

                Case TaxComPNLEnuItem.DEPRECIATION
                    If P1_docDepreciation IsNot Nothing AndAlso P1_docDepreciation.Controls.Count > 0 Then
                        contrl = P1_docDepreciation.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1Depreciation = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p1Depreciation = CType(contrl, ucPNL_p1Depreciation)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_DEPRECIATION(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.SALES
                    If P1_docSales IsNot Nothing AndAlso P1_docSales.Controls.Count > 0 Then
                        contrl = P1_docSales.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1Sales = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p1Sales = CType(contrl, ucPNL_p1Sales)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_PLFST_SALES(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.OPENSTOCK
                    If P1_docOpeningStock IsNot Nothing AndAlso P1_docOpeningStock.Controls.Count > 0 Then
                        contrl = P1_docOpeningStock.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1OpeningStock = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p1OpeningStock = CType(contrl, ucPNL_p1OpeningStock)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_PLFST_OPENSTOCK(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.PURCHASE
                    If P1_docPurchase IsNot Nothing AndAlso P1_docPurchase.Controls.Count > 0 Then
                        contrl = P1_docPurchase.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1Purchase = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p1Purchase = CType(contrl, ucPNL_p1Purchase)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_PLFST_PURCHASE(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.OTHERALLOWEXP
                    If P1_docAllowanceExpenses IsNot Nothing AndAlso P1_docAllowanceExpenses.Controls.Count > 0 Then
                        contrl = P1_docAllowanceExpenses.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1AllowanceExpenses = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p1AllowanceExpenses = CType(contrl, ucPNL_p1AllowanceExpenses)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_ALLOW(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.OTHERNONALLOWEXP
                    If P1_docNonAllowableExpenses IsNot Nothing AndAlso P1_docNonAllowableExpenses.Controls.Count > 0 Then
                        contrl = P1_docNonAllowableExpenses.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1NonAllowableExpenses = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p1NonAllowableExpenses = CType(contrl, ucPNL_p1NonAllowableExpenses)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_NONALLOW(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.CLOSESTOCK
                    If P1_docCloseStock IsNot Nothing AndAlso P1_docCloseStock.Controls.Count > 0 Then
                        contrl = P1_docCloseStock.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p1CloseStock = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p1CloseStock = CType(contrl, ucPNL_p1CloseStock)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_PLFST_CLOSESTOCK(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.OTHERBUSINC
                    If P2_docOtherBizIncome IsNot Nothing AndAlso P2_docOtherBizIncome.Controls.Count > 0 Then
                        contrl = P2_docOtherBizIncome.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2OtherBizIncome = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2OtherBizIncome = CType(contrl, ucPNL_p2OtherBizIncome)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_NONSOURCE_BUSINESSINCOME(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.REALFETRADE
                    If P2_docForeignCurrExGain IsNot Nothing AndAlso P2_docForeignCurrExGain.Controls.Count > 0 Then
                        contrl = P2_docForeignCurrExGain.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ForeignCurrExGain = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2ForeignCurrExGain = CType(contrl, ucPNL_p2ForeignCurrExGain)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_INCOME_REALFET(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.INTERESTINC
                    If P2_docInterestIncome IsNot Nothing AndAlso P2_docInterestIncome.Controls.Count > 0 Then
                        contrl = P2_docInterestIncome.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2InterestIncome = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2InterestIncome = CType(contrl, ucPNL_p2InterestIncome)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_INCOME_NBINTEREST(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.RENTALINC
                    If P2_docRentalIncome IsNot Nothing AndAlso P2_docRentalIncome.Controls.Count > 0 Then
                        contrl = P2_docRentalIncome.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2RentalIncome = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2RentalIncome = CType(contrl, ucPNL_p2RentalIncome)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_RENTAL_INCOME(PNL_Key, ds.Tables(uc.MainTable), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.ROYALTYINC
                    If P2_docRoyaltyIncome IsNot Nothing AndAlso P2_docRoyaltyIncome.Controls.Count > 0 Then
                        contrl = P2_docRoyaltyIncome.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2RoyaltyIncome = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2RoyaltyIncome = CType(contrl, ucPNL_p2RoyaltyIncome)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_INCOME_NBROYALTY(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.OTHERINC
                    If P2_docOtherIncome IsNot Nothing AndAlso P2_docOtherIncome.Controls.Count > 0 Then
                        contrl = P2_docOtherIncome.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2OtherIncome = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2OtherIncome = CType(contrl, ucPNL_p2OtherIncome)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_INCOME(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.PDFIXASSET
                    If P2_docProDispPlantEq IsNot Nothing AndAlso P2_docProDispPlantEq.Controls.Count > 0 Then
                        contrl = P2_docProDispPlantEq.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ProDispPlantEq = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2ProDispPlantEq = CType(contrl, ucPNL_p2ProDispPlantEq)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_INCOME_NTDISPOSALFA(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.PDINVEST
                    If P2_docProDisInvestment IsNot Nothing AndAlso P2_docProDisInvestment.Controls.Count > 0 Then
                        contrl = P2_docProDisInvestment.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ProDisInvestment = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2ProDisInvestment = CType(contrl, ucPNL_p2ProDisInvestment)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_INCOME_NTDISPOSALINVEST(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.EXEMDIV
                    If P2_docExemptDividend IsNot Nothing AndAlso P2_docExemptDividend.Controls.Count > 0 Then
                        contrl = P2_docExemptDividend.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ExemptDividend = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2ExemptDividend = CType(contrl, ucPNL_p2ExemptDividend)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXEMPT_DIVIDEND(PNL_Key, ds.Tables(uc.MainTable), oConn, ListofCmd, Errorlog)
                    End If


                Case TaxComPNLEnuItem.FORINCREMIT
                    If P2_docForeIncomeRemmit IsNot Nothing AndAlso P2_docForeIncomeRemmit.Controls.Count > 0 Then
                        contrl = P2_docForeIncomeRemmit.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ForeIncomeRemmit = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2ForeIncomeRemmit = CType(contrl, ucPNL_p2ForeIncomeRemmit)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_INCOME_NTFOREIGNINCREM(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.REALFE
                    If P2_docUnreaGainForeEx IsNot Nothing AndAlso P2_docUnreaGainForeEx.Controls.Count > 0 Then
                        contrl = P2_docUnreaGainForeEx.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2UnreaGainForeEx = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2UnreaGainForeEx = CType(contrl, ucPNL_p2UnreaGainForeEx)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_INCOME_NTUREALFET(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.UNREALFENONTRADE
                    If P2_docReaForeExGainNonTrade IsNot Nothing AndAlso P2_docReaForeExGainNonTrade.Controls.Count > 0 Then
                        contrl = P2_docReaForeExGainNonTrade.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2ReaForeExGainNonTrade = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2ReaForeExGainNonTrade = CType(contrl, ucPNL_p2ReaForeExGainNonTrade)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_INCOME_NTREALFE(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.UNREALFETRADE
                    If P2_docUnreaGainForeExNon IsNot Nothing AndAlso P2_docUnreaGainForeExNon.Controls.Count > 0 Then
                        contrl = P2_docUnreaGainForeExNon.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2UnreaGainForeExNon = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2UnreaGainForeExNon = CType(contrl, ucPNL_p2UnreaGainForeExNon)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_INCOME_NTUREALFENT(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.OTHERNONTAXINC
                    If P2_docOther IsNot Nothing AndAlso P2_docOther.Controls.Count > 0 Then
                        contrl = P2_docOther.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2Other = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2Other = CType(contrl, ucPNL_p2Other)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_NON_TAXABLE_INCOME(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.INTERESTRESTRICT
                    If P3_docInterestResPurS33 IsNot Nothing AndAlso P3_docInterestResPurS33.Controls.Count > 0 Then
                        contrl = P3_docInterestResPurS33.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3InterestResPurS33 = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3InterestResPurS33 = CType(contrl, ucPNL_p3InterestResPurS33)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_INTERESTRESTRICT(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPOTHERINTEREST
                    If P3_docOtherInterestExHirePur IsNot Nothing AndAlso P3_docOtherInterestExHirePur.Controls.Count > 0 Then
                        contrl = P3_docOtherInterestExHirePur.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3OtherInterestExHirePur = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3OtherInterestExHirePur = CType(contrl, ucPNL_p3OtherInterestExHirePur)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_INTEREST(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPLEGAL
                    If P3_docProTechManLeganFees IsNot Nothing AndAlso P3_docProTechManLeganFees.Controls.Count > 0 Then
                        contrl = P3_docProTechManLeganFees.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3ProTechManLeganFees = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3ProTechManLeganFees = CType(contrl, ucPNL_p3ProTechManLeganFees)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_LEGAL(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPTECHNICAL
                    If P3_docTechPayNonResis IsNot Nothing AndAlso P3_docTechPayNonResis.Controls.Count > 0 Then
                        contrl = P3_docTechPayNonResis.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3TechPayNonResis = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3TechPayNonResis = CType(contrl, ucPNL_p3TechPayNonResis)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_TECH_FEE(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPCONTRACTPAY
                    If P3_docContractPay IsNot Nothing AndAlso P3_docContractPay.Controls.Count > 0 Then
                        contrl = P3_docContractPay.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3ContractPay = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3ContractPay = CType(contrl, ucPNL_p3ContractPay)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_CONTRACT(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPDIRECTORFEE
                    If P3_docDirectorFee IsNot Nothing AndAlso P3_docDirectorFee.Controls.Count > 0 Then
                        contrl = P3_docDirectorFee.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3DirectorFee = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3DirectorFee = CType(contrl, ucPNL_p3DirectorFee)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_DIRECTORS_FEE(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPSALARY
                    If P3_docSalary IsNot Nothing AndAlso P3_docSalary.Controls.Count > 0 Then
                        contrl = P3_docSalary.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Salary = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3Salary = CType(contrl, ucPNL_p3Salary)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_SALARY(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPEMPLOYEESTOCK
                    If P3_docCOEStock IsNot Nothing AndAlso P3_docCOEStock.Controls.Count > 0 Then
                        contrl = P3_docCOEStock.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3COEStock = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3COEStock = CType(contrl, ucPNL_p3COEStock)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_EMPL_STOCK(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPROYALTY
                    If P3_docRoyalty IsNot Nothing AndAlso P3_docRoyalty.Controls.Count > 0 Then
                        contrl = P3_docRoyalty.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Royalty = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3Royalty = CType(contrl, ucPNL_p3Royalty)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_ROYALTY(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPRENTAL
                    If P3_docRental IsNot Nothing AndAlso P3_docRental.Controls.Count > 0 Then
                        contrl = P3_docRental.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Rental = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3Rental = CType(contrl, ucPNL_p3Rental)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_RENTAL(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPREPAIRMAINTENANCE
                    If P3_docRepairMain IsNot Nothing AndAlso P3_docRepairMain.Controls.Count > 0 Then
                        contrl = P3_docRepairMain.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3RepairMain = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3RepairMain = CType(contrl, ucPNL_p3RepairMain)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_REPAIR(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPRND
                    If P3_docResearchDev IsNot Nothing AndAlso P3_docResearchDev.Controls.Count > 0 Then
                        contrl = P3_docResearchDev.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3ResearchDev = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3ResearchDev = CType(contrl, ucPNL_p3ResearchDev)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_RESEARCH(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPADVERTISEMENT
                    If P3_docPromotionAds IsNot Nothing AndAlso P3_docPromotionAds.Controls.Count > 0 Then
                        contrl = P3_docPromotionAds.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3PromotionAds = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3PromotionAds = CType(contrl, ucPNL_p3PromotionAds)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_PROMOTE(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPTRAVEL
                    If P3_docTravelling IsNot Nothing AndAlso P3_docTravelling.Controls.Count > 0 Then
                        contrl = P3_docTravelling.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Travelling = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3Travelling = CType(contrl, ucPNL_p3Travelling)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_TRAVEL(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPJKDM
                    If P3_docJKDM IsNot Nothing AndAlso P3_docJKDM.Controls.Count > 0 Then
                        contrl = P3_docJKDM.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3JKDM = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3JKDM = CType(contrl, ucPNL_p3JKDM)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_EXPENSES_JKDM(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPDEPRECIATION
                    If P3_docDepreciation IsNot Nothing AndAlso P3_docDepreciation.Controls.Count > 0 Then
                        contrl = P3_docDepreciation.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Depreciation = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3Depreciation = CType(contrl, ucPNL_p3Depreciation)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXDEPRECIATION(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPDONATIONAPPR
                    If P3_docDonationApp IsNot Nothing AndAlso P3_docDonationApp.Controls.Count > 0 Then
                        contrl = P3_docDonationApp.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3DonationApp = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3DonationApp = CType(contrl, ucPNL_p3DonationApp)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXAPPRDONATION(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPDONATIONNONAPPR
                    If P3_docDonationNonApp IsNot Nothing AndAlso P3_docDonationNonApp.Controls.Count > 0 Then
                        contrl = P3_docDonationNonApp.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3DonationNonApp = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3DonationNonApp = CType(contrl, ucPNL_p3DonationNonApp)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXNAPPRDONATION(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPZAKAT
                    If p3_docZakat IsNot Nothing AndAlso p3_docZakat.Controls.Count > 0 Then
                        contrl = p3_docZakat.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p3Zakat = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p3Zakat = CType(contrl, ucPNL_p3Zakat)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXZAKAT(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPLOSSDISPFA
                    If p4_docLossDispFA IsNot Nothing AndAlso p4_docLossDispFA.Controls.Count > 0 Then
                        contrl = p4_docLossDispFA.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4LossDispFA = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4LossDispFA = CType(contrl, ucPNL_p4LossDispFA)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXLOSSDISPOSALFA(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If


                Case TaxComPNLEnuItem.EXPENTERTAINNONSTAFF
                    If p4_docEntNonStaff IsNot Nothing AndAlso p4_docEntNonStaff.Controls.Count > 0 Then
                        contrl = p4_docEntNonStaff.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4EntNonStaff = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4EntNonStaff = CType(contrl, ucPNL_p4EntNonStaff)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_ENTERTAINNSTAFF(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPENTERTAINSTAFF
                    If p4_docEntStaff IsNot Nothing AndAlso p4_docEntStaff.Controls.Count > 0 Then
                        contrl = p4_docEntStaff.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4EntStaff = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4EntStaff = CType(contrl, ucPNL_p4EntStaff)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_ENTERTAINSTAFF(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPCOMPAUNDPENALTY
                    If p4_docCompound IsNot Nothing AndAlso p4_docCompound.Controls.Count > 0 Then
                        contrl = p4_docCompound.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4Compound = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4Compound = CType(contrl, ucPNL_p4Compound)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXPENALTY(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.EXPPROVISION
                    If p4_docProvisionAcc IsNot Nothing AndAlso p4_docProvisionAcc.Controls.Count > 0 Then
                        contrl = p4_docProvisionAcc.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4ProvisionAcc = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4ProvisionAcc = CType(contrl, ucPNL_p4ProvisionAcc)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXPROVISIONACC(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.EXPLEAVEPASSAGE
                    If p4_docLeavePass IsNot Nothing AndAlso p4_docLeavePass.Controls.Count > 0 Then
                        contrl = p4_docLeavePass.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4LeavePass = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4LeavePass = CType(contrl, ucPNL_p4LeavePass)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXLEAVEPASSAGE(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.EXPFAWRITTENOFF
                    If p4_docFAWrittenOff IsNot Nothing AndAlso p4_docFAWrittenOff.Controls.Count > 0 Then
                        contrl = p4_docFAWrittenOff.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4FAWrittenOff = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4FAWrittenOff = CType(contrl, ucPNL_p4FAWrittenOff)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXFAWRITTENOFF(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPUNREALLOSSFE
                    If p4_docUnreaLossForeEx IsNot Nothing AndAlso p4_docUnreaLossForeEx.Controls.Count > 0 Then
                        contrl = p4_docUnreaLossForeEx.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4UnreaLossForeEx = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4UnreaLossForeEx = CType(contrl, ucPNL_p4UnreaLossForeEx)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXURLOSSFOREIGN(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPREALLOSSFETRADE
                    If p4_docReaLossForeExTrade IsNot Nothing AndAlso p4_docReaLossForeExTrade.Controls.Count > 0 Then
                        contrl = p4_docReaLossForeExTrade.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4ReaLossForeExTrade = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4ReaLossForeExTrade = CType(contrl, ucPNL_p4ReaLossForeExTrade)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXRLOSSFOREIGNT(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPREALLOSSFENONTRADE
                    If p4_docReaLossForeExNonTrade IsNot Nothing AndAlso p4_docReaLossForeExNonTrade.Controls.Count > 0 Then
                        contrl = p4_docReaLossForeExNonTrade.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4ReaLossForeExNonTrade = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4ReaLossForeExNonTrade = CType(contrl, ucPNL_p4ReaLossForeExNonTrade)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXRLOSSFOREIGN(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPINITIALSUBSCRIPT
                    If p4_docInitSub IsNot Nothing AndAlso p4_docInitSub.Controls.Count > 0 Then
                        contrl = p4_docInitSub.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4InitSub = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4InitSub = CType(contrl, ucPNL_p4InitSub)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXINITIALSUB(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPCAPITALEXPENDITURE
                    If p4_docCAExpenditure IsNot Nothing AndAlso p4_docCAExpenditure.Controls.Count > 0 Then
                        contrl = p4_docCAExpenditure.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4CAExpenditure = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4CAExpenditure = CType(contrl, ucPNL_p4CAExpenditure)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXCAPITALEXP(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If

                Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
                    If p4_docOther IsNot Nothing AndAlso p4_docOther.Controls.Count > 0 Then
                        contrl = p4_docOther.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4Other = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p4Other = CType(contrl, ucPNL_p4Other)

                        ds = uc.DataView_Main

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_OTHER_EXPENSES(PNL_Key, ds.Tables(uc.MainTable), ds.Tables(uc.MainTable_Details), oConn, ListofCmd, Errorlog)
                    End If
                Case TaxComPNLEnuItem.DIVIDENDINC
                    If P2_docDivIncome IsNot Nothing AndAlso P2_docDivIncome.Controls.Count > 0 Then
                        contrl = P2_docDivIncome.Controls(0)

                        If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p2DivIncome = False Then
                            Return False
                        End If
                        Dim uc As ucPNL_p2DivIncome = CType(contrl, ucPNL_p2DivIncome)

                        ds = uc.DataView_Main2

                        If ds Is Nothing OrElse ds.Tables(uc.MainTable) Is Nothing OrElse ds.Tables(uc.MainTable).Rows.Count <= 0 Then
                            Return False
                        End If

                        mdlProcess.Save_DIVIDEND_INCOME(PNL_Key, ds.Tables(uc.MainTable), uc.GetDiscloseNet, oConn, ListofCmd, Errorlog)
                    End If
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
        End Try
    End Function
    Public Function PNL_ReCalcAll_Amount(ByVal Type As TaxComPNLEnuItem, ByRef ds As DataSet, ByRef txtAmount As DevExpress.XtraEditors.TextEdit, Optional ByRef Errorlog As clsError = Nothing) As Boolean
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

                    If P2_docDivIncome IsNot Nothing AndAlso P2_docDivIncome.Controls.Count > 0 Then
                        Dim contrl As Control
                        contrl = P2_docDivIncome.Controls(0)

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
                    CalcTotalofView(txtAmount, ds, ucPNL_p2UnreaGainForeEx.MainTable, ucPNL_p2UnreaGainForeEx.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.UNREALFENONTRADE
                    CalcTotalofView(txtAmount, ds, ucPNL_p2ReaForeExGainNonTrade.MainTable, ucPNL_p2ReaForeExGainNonTrade.MainAmount, 0, Errorlog)
                Case TaxComPNLEnuItem.UNREALFETRADE
                    CalcTotalofView(txtAmount, ds, ucPNL_p2UnreaGainForeExNon.MainTable, ucPNL_p2UnreaGainForeExNon.MainAmount, 0, Errorlog)
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
    Public Function PNL_GetData(ByVal PNL_KEY As Decimal, ByVal Type As TaxComPNLEnuItem, _
                                    ByVal RefNo As String, ByVal YA As String, ByRef ds As DataSet, _
                                    Optional ByRef Errorlog As clsError = Nothing, Optional ByRef isHaveData As Boolean = False) As Boolean
        Dim strError As String = Nothing
        Try

            Dim dt As DataTable = Nothing
            Dim dtChild As DataTable = Nothing
            Dim dtRow As DataRow = Nothing
            Dim TmpID As Integer = 0
            strError = Type.ToString
            Select Case Type
                Case TaxComPNLEnuItem.SALES
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_PLFST_SALES(PNL_KEY, Errorlog)

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
                            ds.Tables("PLFST_SALES").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_PLFST_SALES_DETAIL(PNL_KEY, Errorlog)

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
                                ds.Tables("PLFST_SALES_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.OPENSTOCK
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_PLFST_OPENSTOCK(PNL_KEY, Errorlog)
                    ds.Tables("PLFST_OPENSTOCK_DETAIL").Rows.Clear()
                    ds.Tables("PLFST_OPENSTOCK").Rows.Clear()

                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("PLFST_OPENSTOCK").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_PLFST_OPENSTOCK_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("PLFST_OPENSTOCK_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.PURCHASE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_PLFST_PURCHASE(PNL_KEY, Errorlog)
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

                                ds.Tables("PLFST_PURCHASE").Rows.Add(dtRow)
                            End If
                         
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_PLFST_PURCHASE_DETAIL(PNL_KEY, Errorlog)

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

                                ds.Tables("PLFST_PURCHASE_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.DEPRECIATION
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_EXPENSES_DEPRECIATION(PNL_KEY, Errorlog)
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
                                ds.Tables("EXPENSES_DEPRECIATION").Rows.Add(dtRow)
                            End If
                          
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_DEPRECIATION_DETAIL(PNL_KEY, Errorlog)

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

                                dtRow("EXDEPD_NOTE") = rowx("EXDEPD_NOTE")
                                ds.Tables("EXPENSES_DEPRECIATION_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.OTHERALLOWEXP
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_EXPENSES_ALLOW(PNL_KEY, Errorlog)
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

                                ds.Tables("EXPENSES_ALLOW").Rows.Add(dtRow)
                            End If
                           
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_ALLOW_DETAIL(PNL_KEY, Errorlog)

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

                                ds.Tables("EXPENSES_ALLOW_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.OTHERNONALLOWEXP
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_EXPENSES_NONALLOW(PNL_KEY, Errorlog)
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
                                dtRow("EXNA_DEDUCTIBLE") = rowx("EXNA_DEDUCTIBLE")
                                dtRow("EXNA_NOTE") = rowx("EXNA_NOTE")
                                dtRow("EXNA_DETAIL") = rowx("EXNA_DETAIL")

                                ds.Tables("EXPENSES_NONALLOW").Rows.Add(dtRow)
                            End If
                           
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_NONALLOW_DETAIL(PNL_KEY, Errorlog)

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

                                dtRow("EXNAD_DEDUCTIBLE") = rowx("EXNAD_DEDUCTIBLE")
                                dtRow("EXNAD_AMOUNT") = rowx("EXNAD_AMOUNT")
                                dtRow("EXNAD_NOTE") = rowx("EXNAD_NOTE")

                                ds.Tables("EXPENSES_NONALLOW_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.CLOSESTOCK
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_PLFST_CLOSESTOCK(PNL_KEY, Errorlog)
                    ds.Tables("PLFST_CLOSESTOCK_DETAIL").Rows.Clear()
                    ds.Tables("PLFST_CLOSESTOCK").Rows.Clear()

                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("PLFST_CLOSESTOCK").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_PLFST_CLOSESTOCK_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("PLFST_CLOSESTOCK_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.OTHERBUSINC
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_NONSOURCE_BUSINESSINCOME(PNL_KEY, Errorlog)

                    ds.Tables("NONSOURCE_BUSINESSINCOME_DETAIL").Rows.Clear()
                    ds.Tables("NONSOURCE_BUSINESSINCOME").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("NONSOURCE_BUSINESSINCOME").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_NONSOURCE_BUSINESSINCOME_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("NONSOURCE_BUSINESSINCOME_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.REALFETRADE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_INCOME_REALFET(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_REALFET_DETAIL").Rows.Clear()
                    ds.Tables("INCOME_REALFET").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("INCOME_REALFET").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_INCOME_REALFET_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("INCOME_REALFET_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.DIVIDENDINC
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_dividend_income(PNL_KEY, Errorlog)

                    ds.Tables("dividend_income").Rows.Clear()

                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("dividend_income").ImportRow(rowx)
                        Next
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.INTERESTINC
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_INCOME_NBINTEREST(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_NBINTEREST_DETAIL").Rows.Clear()
                    ds.Tables("INCOME_NBINTEREST").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("INCOME_NBINTEREST").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_INCOME_NBINTEREST_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("INCOME_NBINTEREST_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.RENTALINC
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_rental_income(PNL_KEY, Errorlog)

                    ds.Tables("rental_income").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("rental_income").ImportRow(rowx)
                        Next
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.ROYALTYINC
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_INCOME_NBROYALTY(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_NBROYALTY_DETAIL").Rows.Clear()
                    ds.Tables("INCOME_NBROYALTY").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("INCOME_NBROYALTY").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_INCOME_NBROYALTY_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("INCOME_NBROYALTY_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.OTHERINC
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_OTHER_INCOME(PNL_KEY, Errorlog)

                    ds.Tables("OTHER_INCOME_DETAIL").Rows.Clear()
                    ds.Tables("OTHER_INCOME").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("OTHER_INCOME").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_INCOME_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("OTHER_INCOME_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.PDFIXASSET
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_INCOME_NTDISPOSALFA(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_NTDISPOSALFA_DETAIL").Rows.Clear()
                    ds.Tables("INCOME_NTDISPOSALFA").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("INCOME_NTDISPOSALFA").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_INCOME_NTDISPOSALFA_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("INCOME_NTDISPOSALFA_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.PDINVEST
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_INCOME_NTDISPOSALINVEST(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_NTDISPOSALINVEST_DETAIL").Rows.Clear()
                    ds.Tables("INCOME_NTDISPOSALINVEST").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("INCOME_NTDISPOSALINVEST").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_INCOME_NTDISPOSALINVEST_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("INCOME_NTDISPOSALINVEST_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXEMDIV
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_exempt_dividend(PNL_KEY, Errorlog)

                    ds.Tables("exempt_dividend").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("exempt_dividend").ImportRow(rowx)
                        Next
                    End If
                Case TaxComPNLEnuItem.FORINCREMIT
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_INCOME_NTFOREIGNINCREM(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_NTFOREIGNINCREM_DETAIL").Rows.Clear()
                    ds.Tables("INCOME_NTFOREIGNINCREM").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("INCOME_NTFOREIGNINCREM").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_INCOME_NTFOREIGNINCREM_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("INCOME_NTFOREIGNINCREM_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.REALFE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_INCOME_NTUREALFET(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_NTUREALFET_DETAIL").Rows.Clear()
                    ds.Tables("INCOME_NTUREALFET").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("INCOME_NTUREALFET").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_INCOME_NTUREALFET_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("INCOME_NTUREALFET_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.UNREALFENONTRADE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_INCOME_NTREALFE(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_NTREALFE_DETAIL").Rows.Clear()
                    ds.Tables("INCOME_NTREALFE").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("INCOME_NTREALFE").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_INCOME_NTREALFE_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("INCOME_NTREALFE_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.UNREALFETRADE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_INCOME_NTUREALFENT(PNL_KEY, Errorlog)

                    ds.Tables("INCOME_NTUREALFENT_DETAIL").Rows.Clear()
                    ds.Tables("INCOME_NTUREALFENT").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("INCOME_NTUREALFENT").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_INCOME_NTUREALFENT_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("INCOME_NTUREALFENT_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.OTHERNONTAXINC
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_non_taxable_income(RefNo, YA, Errorlog)

                    ds.Tables("NON_TAXABLE_INCOME_DETAIL").Rows.Clear()
                    ds.Tables("non_taxable_income").Rows.Clear()
                    If dt IsNot Nothing Then
                        isHaveData = True
                        For Each rowx As DataRow In dt.Rows
                            ds.Tables("non_taxable_income").ImportRow(rowx)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_NON_TAXABLE_INCOME_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                ds.Tables("NON_TAXABLE_INCOME_DETAIL").ImportRow(rowx)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.INTERESTRESTRICT
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_interestrestrict(PNL_KEY, Errorlog)

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
                                    rowx("EXIR_DEDUCTIBLE") = True
                                Else
                                    rowx("EXIR_DEDUCTIBLE") = False
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

                                ds.Tables("expenses_interestrestrict").Rows.Add(dtRow)
                            End If
                          
                        Next
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPOTHERINTEREST
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_interest(PNL_KEY, Errorlog)
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
                                    rowx("EXI_DEDUCTIBLE") = True
                                Else
                                    rowx("EXI_DEDUCTIBLE") = False
                                End If
                                dtRow("EXI_NOTE") = rowx("EXI_NOTE")
                                dtRow("EXI_DETAIL") = rowx("EXI_DETAIL")
                                If IsDBNull(rowx("Exi_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXI_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXI_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXI_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXI_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")

                                ds.Tables("expenses_interest").Rows.Add(dtRow)
                            End If
                            
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_INTEREST_DETAIL(PNL_KEY, Errorlog)

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
                                    rowx("EXID_DEDUCTIBLE") = True
                                Else
                                    rowx("EXID_DEDUCTIBLE") = False
                                End If
                                dtRow("EXID_AMOUNT") = rowx("EXID_AMOUNT")
                                dtRow("EXID_NOTE") = rowx("EXID_NOTE")
                                If IsDBNull(rowx("EXID_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXID_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXID_DEDUCTIBLE_ADD") = "True") Then
                                    dtRow("EXID_DEDUCTIBLE_ADD") = True
                                Else
                                    dtRow("EXID_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")

                                ds.Tables("EXPENSES_INTEREST_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPLEGAL
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_legal(PNL_KEY, Errorlog)
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
                                    rowx("EXL_DEDUCTIBLE") = True
                                Else
                                    rowx("EXL_DEDUCTIBLE") = False
                                End If
                                dtRow("EXL_NOTE") = rowx("EXL_NOTE")
                                dtRow("EXL_DETAIL") = rowx("EXL_DETAIL")
                                If IsDBNull(rowx("EXL_DEDUCTIBLE_ADD")) = False AndAlso (rowx("EXL_DEDUCTIBLE_ADD") = "Yes" OrElse rowx("EXL_DEDUCTIBLE_ADD") = "True") Then
                                    rowx("EXL_DEDUCTIBLE_ADD") = True
                                Else
                                    rowx("EXL_DEDUCTIBLE_ADD") = False
                                End If
                                dtRow("RowIndex") = rowx("RowIndex")

                                ds.Tables("expenses_legal").Rows.Add(dtRow)
                            End If
                           
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_LEGAL_DETAIL(PNL_KEY, Errorlog)

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

                                ds.Tables("EXPENSES_LEGAL_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPTECHNICAL
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_tech_fee(PNL_KEY, Errorlog)

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

                                ds.Tables("expenses_tech_fee").Rows.Add(dtRow)
                            End If
                           
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_TECH_FEE_DETAIL(PNL_KEY, Errorlog)

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

                                ds.Tables("EXPENSES_TECH_FEE_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPCONTRACTPAY
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_contract(PNL_KEY, Errorlog)

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

                                ds.Tables("expenses_contract").Rows.Add(dtRow)
                            End If
                           
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_CONTRACT_DETAIL(PNL_KEY, Errorlog)

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

                                ds.Tables("EXPENSES_CONTRACT_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPDIRECTORFEE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_directors_fee(PNL_KEY, Errorlog)

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

                                ds.Tables("expenses_directors_fee").Rows.Add(dtRow)
                            End If
                            
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_DIRECTORS_FEE_DETAIL(PNL_KEY, Errorlog)

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

                                ds.Tables("EXPENSES_DIRECTORS_FEE_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPSALARY
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_salary(PNL_KEY, Errorlog)

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

                                ds.Tables("expenses_salary").Rows.Add(dtRow)
                            End If
                            
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_SALARY_DETAIL(PNL_KEY, Errorlog)

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

                                ds.Tables("EXPENSES_SALARY_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPEMPLOYEESTOCK
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_empl_stock(PNL_KEY, Errorlog)

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

                                ds.Tables("expenses_empl_stock").Rows.Add(dtRow)
                            End If
                           
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_EMPLSTOCK_DETAIL(PNL_KEY, Errorlog)

                        If dt IsNot Nothing Then
                            For Each rowx As DataRow In dt.Rows
                                dtRow = Nothing
                                dtRow = ds.Tables("EXPENSES_EMPLSTOCK_DETAIL").NewRow
                                dtRow("EXESD_KEY") = rowx("EXESD_KEY")
                                dtRow("EXESD_EXESKEY") = rowx("EXESD_EXESKEY")
                                dtRow("EXESD_SOURCENO") = rowx("EXESD_SOURCENO")
                                dtRow("EXESD_DESC") = rowx("EXESD_DESC")
                                dtRow("EXESD_AMOUNT") = rowx("EXESD_AMOUNT")
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

                                ds.Tables("EXPENSES_EMPLSTOCK_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPROYALTY
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_royalty(PNL_KEY, Errorlog)

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

                                ds.Tables("expenses_royalty").Rows.Add(dtRow)
                            End If
                       
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_ROYALTY_DETAIL(PNL_KEY, Errorlog)

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

                                ds.Tables("EXPENSES_ROYALTY_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPRENTAL
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_rental(PNL_KEY, Errorlog)

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

                                ds.Tables("expenses_rental").Rows.Add(dtRow)
                            End If
                            
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_RENTAL_DETAIL(PNL_KEY, Errorlog)

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

                                ds.Tables("EXPENSES_RENTAL_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPREPAIRMAINTENANCE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_repair(PNL_KEY, Errorlog)

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

                                ds.Tables("expenses_repair").Rows.Add(dtRow)
                            End If
                            
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_REPAIR_DETAIL(PNL_KEY, Errorlog)

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

                                ds.Tables("EXPENSES_REPAIR_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPRND
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_research(PNL_KEY, Errorlog)

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

                                ds.Tables("expenses_research").Rows.Add(dtRow)
                            End If
                            
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_RESEARCH_DETAIL(PNL_KEY, Errorlog)

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

                                ds.Tables("EXPENSES_RESEARCH_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPADVERTISEMENT
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_promote(PNL_KEY, Errorlog)

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
                                ds.Tables("expenses_promote").Rows.Add(dtRow)
                            End If
                            
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_PROMOTE_DETAIL(PNL_KEY, Errorlog)

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

                                ds.Tables("EXPENSES_PROMOTE_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPTRAVEL
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_travel(PNL_KEY, Errorlog)

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
                                ds.Tables("expenses_travel").Rows.Add(dtRow)
                            End If
                           
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_TRAVEL_DETAIL(PNL_KEY, Errorlog)

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
                                ds.Tables("EXPENSES_TRAVEL_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPJKDM
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_expenses_jkdm(PNL_KEY, Errorlog)

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
                                dtRow("RowIndex") = rowx("RowIndex")


                                ds.Tables("expenses_jkdm").Rows.Add(dtRow)
                            End If
                           
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_EXPENSES_JKDM_DETAIL(PNL_KEY, Errorlog)

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

                                ds.Tables("EXPENSES_JKDM_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPDEPRECIATION
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exdepreciation(PNL_KEY, Errorlog)

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

                                ds.Tables("other_exdepreciation").Rows.Add(dtRow)
                            End If
                           
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXDEPRECIATION_DETAIL(PNL_KEY, Errorlog)

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
                                dtRow("Pecentage") = rowx("Pecentage")

                                ds.Tables("OTHER_EXDEPRECIATION_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPDONATIONAPPR
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exapprdonation(PNL_KEY, Errorlog)

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

                                ds.Tables("other_exapprdonation").Rows.Add(dtRow)
                            End If
                            
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXAPPRDONATION_DETAIL(PNL_KEY, Errorlog)

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
                                ds.Tables("OTHER_EXAPPRDONATION_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPDONATIONNONAPPR
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exnapprdonation(PNL_KEY, Errorlog)

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

                                ds.Tables("other_exnapprdonation").Rows.Add(dtRow)
                            End If
                           
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXNAPPRDONATION_DETAIL(PNL_KEY, Errorlog)

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

                                ds.Tables("OTHER_EXNAPPRDONATION_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPZAKAT
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exzakat(PNL_KEY, Errorlog)

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

                                ds.Tables("other_exzakat").Rows.Add(dtRow)
                            End If
                            
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXZAKAT_DETAIL(PNL_KEY, Errorlog)

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

                                ds.Tables("OTHER_EXZAKAT_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPLOSSDISPFA
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exlossdisposalfa(PNL_KEY, Errorlog)

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

                                ds.Tables("other_exlossdisposalfa").Rows.Add(dtRow)
                            End If
                           
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXLOSSDISPOSALFA_DETAIL(PNL_KEY, Errorlog)

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

                                ds.Tables("OTHER_EXLOSSDISPOSALFA_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPENTERTAINNONSTAFF
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_entertainnstaff(PNL_KEY, Errorlog)

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

                                ds.Tables("other_entertainnstaff").Rows.Add(dtRow)
                            End If
                           
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_ENTERTAINNSTAFF_DETAIL(PNL_KEY, Errorlog)

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

                                ds.Tables("OTHER_ENTERTAINNSTAFF_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPENTERTAINSTAFF
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_OTHER_ENTERTAINSTAFF(PNL_KEY, Errorlog)

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

                                ds.Tables("OTHER_ENTERTAINSTAFF").Rows.Add(dtRow)
                            End If
                            
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_ENTERTAINSTAFF_DETAIL(PNL_KEY, Errorlog)

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
                                ds.Tables("OTHER_ENTERTAINSTAFF_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPCOMPAUNDPENALTY
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_expenalty(PNL_KEY, Errorlog)

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

                                ds.Tables("other_expenalty").Rows.Add(dtRow)
                            End If
                           
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXPENALTY_DETAIL(PNL_KEY, Errorlog)

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

                                ds.Tables("OTHER_EXPENALTY_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPPROVISION
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exprovisionacc(PNL_KEY, Errorlog)

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

                                ds.Tables("other_exprovisionacc").Rows.Add(dtRow)
                            End If
                          
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXPROVISIONACC_DETAIL(PNL_KEY, Errorlog)

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
                                ds.Tables("OTHER_EXPROVISIONACC_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPLEAVEPASSAGE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exleavepassage(PNL_KEY, Errorlog)

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

                                ds.Tables("other_exleavepassage").Rows.Add(dtRow)
                            End If
                           
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXLEAVEPASSAGE_DETAIL(PNL_KEY, Errorlog)

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

                                ds.Tables("OTHER_EXLEAVEPASSAGE_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPFAWRITTENOFF
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exfawrittenoff(PNL_KEY, Errorlog)

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
                                ds.Tables("other_exfawrittenoff").Rows.Add(dtRow)
                            End If
                           
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXFAWRITTENOFF_DETAIL(PNL_KEY, Errorlog)

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

                                ds.Tables("OTHER_EXFAWRITTENOFF_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPUNREALLOSSFE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exurlossforeign(PNL_KEY, Errorlog)

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

                                ds.Tables("other_exurlossforeign").Rows.Add(dtRow)
                            End If
                            
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXURLOSSFOREIGN_DETAIL(PNL_KEY, Errorlog)

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
                                ds.Tables("OTHER_EXURLOSSFOREIGN_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPREALLOSSFETRADE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exrlossforeignt(PNL_KEY, Errorlog)

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
                            ds.Tables("other_exrlossforeignt").Rows.Add(dtRow)
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXRLOSSFOREIGNT_DETAIL(PNL_KEY, Errorlog)

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
                                ds.Tables("OTHER_EXRLOSSFOREIGNT_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPREALLOSSFENONTRADE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exrlossforeign(PNL_KEY, Errorlog)

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
                                ds.Tables("other_exrlossforeign").Rows.Add(dtRow)
                            End If
                        
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXRLOSSFOREIGN_DETAIL(PNL_KEY, Errorlog)

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
                                ds.Tables("OTHER_EXRLOSSFOREIGN_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPINITIALSUBSCRIPT
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_exinitialsub(PNL_KEY, Errorlog)

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

                                ds.Tables("other_exinitialsub").Rows.Add(dtRow)
                            End If
                          
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXINITIALSUB_DETAIL(PNL_KEY, Errorlog)

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
                                ds.Tables("OTHER_EXINITIALSUB_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPCAPITALEXPENDITURE
                    dt = Nothing
                    dt = mdlProcess.Load_PNL_other_excapitalexp(PNL_KEY, Errorlog)

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
                                ds.Tables("other_excapitalexp").Rows.Add(dtRow)
                            End If
                           
                        Next
                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXCAPITALEXP_DETAIL(PNL_KEY, Errorlog)

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
                                ds.Tables("OTHER_EXCAPITALEXP_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
                Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
                    dt = Nothing

                    dt = mdlProcess.Load_PNL_other_expenses(PNL_KEY, Errorlog)
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
                                dtRow("PecentageAmount") = rowx("PecentageAmount")
                                ds.Tables("other_expenses").Rows.Add(dtRow)


                            End If
                            

                        Next

                        dt = Nothing

                        dt = mdlProcess.Load_PNL_OTHER_EXPENSES_DETAIL(PNL_KEY, Errorlog)

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
                                ds.Tables("OTHER_EXPENSES_DETAIL").Rows.Add(dtRow)
                            Next
                        End If
                    Else
                        isHaveData = False
                    End If
            End Select
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If

            With Errorlog
                .ErrorCode = "XX1001"
                .ErrorMessage = strError & " | " & ex.Message
                .ErrorDateTime = Now
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
            End With
            Return False
        End Try
    End Function
    Public Function Load_DT_Deduct(ByVal PNLKey As Integer, ByVal ID As Integer, ByVal Type As TaxComPNLEnuItem, Optional ByRef Errorlog As clsError = Nothing) As DataTable
        Try
            Dim SQLCmd As SqlCommand
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
                Return mdlProcess.Load_SQLCmd(SQLCmd, Errorlog)
            Else
                Return Nothing
            End If

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
    Public Function TransferFromImport_ToMain(ByVal dsMain As DataSet, ByVal dsMain2 As DataSet, ByVal dtRowImport As DataRow, ByVal TableName As String, ByVal Type As mdlEnum.TaxComPNLEnuItem, ByVal SourceNo As Integer, ByRef RefNo As String, ByVal YA As String, Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dtRow As DataRow = Nothing

            Select Case Type
                Case TaxComPNLEnuItem.SALES
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("PLFS_KEY") = 0
                    dtRow("PLFS_SOURCENO") = SourceNo
                    dtRow("PLFS_DESC") = dtRowImport("Description")
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("PLFS_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("PLFS_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dtRow("PLFS_NOTE") = ""
                    dtRow("PLFS_DETAIL") = "No"
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.OPENSTOCK
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("PLFOS_KEY") = 0
                    dtRow("PLFOS_SOURCENO") = SourceNo
                    dtRow("PLFOS_DESC") = dtRowImport("Description")
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("PLFOS_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("PLFOS_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dtRow("PLFOS_NOTE") = ""
                    dtRow("PLFOS_DETAIL") = "No"
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.PURCHASE
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("PLFPUR_KEY") = 0
                    dtRow("PLFPUR_SOURCENO") = SourceNo
                    dtRow("PLFPUR_DESC") = dtRowImport("Description")
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("PLFPUR_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("PLFPUR_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dtRow("PLFPUR_NOTE") = ""
                    dtRow("PLFPUR_DETAIL") = "No"
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.DEPRECIATION
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXDEP_KEY") = 0
                    dtRow("EXDEP_SOURCENO") = SourceNo
                    dtRow("EXDEP_DESC") = dtRowImport("Description")
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXDEP_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXDEP_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dtRow("EXDEP_NOTE") = ""
                    dtRow("EXDEP_DETAIL") = "No"
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.OTHERALLOWEXP
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXA_KEY") = 0
                    dtRow("EXA_SOURCENO") = SourceNo
                    dtRow("EXA_DESC") = dtRowImport("Description")
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXA_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXA_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dtRow("EXA_NOTE") = ""
                    dtRow("EXA_DETAIL") = "No"
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.OTHERNONALLOWEXP
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXNA_KEY") = 0
                    dtRow("EXNA_SOURCENO") = SourceNo
                    dtRow("EXNA_DESC") = dtRowImport("Description")
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXNA_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXNA_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dtRow("EXNA_NOTE") = ""
                    dtRow("EXNA_DETAIL") = "No"
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.CLOSESTOCK
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("PLFCS_KEY") = 0
                    dtRow("PLFCS_SOURCENO") = SourceNo
                    dtRow("PLFCS_DESC") = dtRowImport("Description")
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("PLFCS_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("PLFCS_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dtRow("PLFCS_NOTE") = ""
                    dtRow("PLFCS_DETAIL") = "No"
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.OTHERBUSINC
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("NSBI_KEY") = 0
                    dtRow("NSBI_SOURCENO") = SourceNo
                    dtRow("NSBI_DESC") = dtRowImport("Description")
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("NSBI_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("NSBI_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dtRow("NSBI_NOTE") = ""
                    dtRow("NSBI_DETAIL") = "No"
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.REALFETRADE
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("IRFET_KEY") = 0
                    dtRow("IRFET_SOURCENO") = SourceNo
                    dtRow("IRFET_DESC") = dtRowImport("Description")
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("IRFET_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("IRFET_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dtRow("IRFET_NOTE") = ""
                    dtRow("IRFET_DETAIL") = "No"
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.DIVIDENDINC
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("DI_KEY") = 0
                    dtRow("DI_SOURCENO") = SourceNo
                    dtRow("DI_COMPANY") = dtRowImport("Description")
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("DI_GROSS") = dtRowImport("LeftAmount")
                    Else
                        dtRow("DI_GROSS") = dtRowImport("RightAmount")
                    End If
                    dtRow("DI_TRANSFER") = "Single Tier"
                    dtRow("DI_WARANT_NO") = "-"
                    dtRow("DI_DATE") = Now
                    dtRow("DI_TRANSFER") = "Single Tier"
                    dtRow("DI_TAX") = 0
                    dtRow("DI_NET") = 0
                    dtRow("DI_TAXDEDUCTION") = 0
                    dtRow("DI_NETDEDUCTION") = 0
                    dtRow("DI_DISCLOSE") = "No"
                    dtRow("DI_REGROSS") = 0
                    dtRow("DI_CHKREGROSS") = "No"
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.INTERESTINC
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("NOBII_KEY") = 0
                    dtRow("NOBII_SOURCENO") = SourceNo
                    dtRow("NOBII_DESC") = dtRowImport("Description")
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("NOBII_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("NOBII_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dtRow("NOBII_NOTE") = ""
                    dtRow("NOBII_DETAIL") = "No"
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.RENTALINC
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("RI_KEY") = 0
                    dtRow("RI_SOURCENO") = SourceNo
                    dtRow("RI_ADDRESS") = dtRowImport("Description")
                    dtRow("RI_TYPE") = "Rental"
                    dtRow("RI_DATE") = Now
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("RI_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("RI_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dtRow("RI_STATUS4d") = "Sec 4b"
                    dtRow("RI_DATE_END") = Now
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.ROYALTYINC
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("NOBRI_KEY") = 0
                    dtRow("NOBRI_SOURCENO") = SourceNo
                    dtRow("NOBRI_DESC") = dtRowImport("Description")
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("NOBRI_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("NOBRI_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dtRow("NOBRI_NOTE") = ""
                    dtRow("NOBRI_DETAIL") = "No"
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.OTHERINC
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("OI_KEY") = 0
                    dtRow("OI_SOURCENO") = SourceNo
                    dtRow("OI_DESC") = dtRowImport("Description")
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("OI_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("OI_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dtRow("OI_NOTE") = ""
                    dtRow("OI_DETAIL") = "No"
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.PDFIXASSET
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("NTIDFA_KEY") = 0
                    dtRow("NTIDFA_SOURCENO") = SourceNo
                    dtRow("NTIDFA_DESC") = dtRowImport("Description")
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("NTIDFA_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("NTIDFA_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dtRow("NTIDFA_NOTE") = ""
                    dtRow("NTIDFA_DETAIL") = "No"
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.PDINVEST
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("NTIDI_KEY") = 0
                    dtRow("NTIDI_SOURCENO") = SourceNo
                    dtRow("NTIDI_DESC") = dtRowImport("Description")
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("NTIDI_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("NTIDI_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dtRow("NTIDI_NOTE") = ""
                    dtRow("NTIDI_DETAIL") = "No"
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXEMDIV
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("ED_KEY") = 0
                    dtRow("ED_SOURCENO") = SourceNo
                    dtRow("ED_COMPANY") = dtRowImport("Description")
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("ED_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("ED_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dtRow("ED_TIERSTATUS") = "First Tier"
                    dtRow("ED_DATE") = Now
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.FORINCREMIT
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("NTIFIR_KEY") = 0
                    dtRow("NTIFIR_SOURCENO") = SourceNo
                    dtRow("NTIFIR_DESC") = dtRowImport("Description")
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("NTIFIR_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("NTIFIR_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dtRow("NTIFIR_NOTE") = ""
                    dtRow("NTIFIR_DETAIL") = "No"
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.REALFE
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("NTIUT_KEY") = 0
                    dtRow("NTIUT_SOURCENO") = SourceNo
                    dtRow("NTIUT_DESC") = dtRowImport("Description")
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("NTIUT_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("NTIUT_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dtRow("NTIUT_NOTE") = ""
                    dtRow("NTIUT_DETAIL") = "No"
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.UNREALFENONTRADE
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("NTIRFECT_KEY") = 0
                    dtRow("NTIRFECT_SOURCENO") = SourceNo
                    dtRow("NTIRFECT_DESC") = dtRowImport("Description")
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("NTIRFECT_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("NTIRFECT_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dtRow("NTIRFECT_NOTE") = ""
                    dtRow("NTIRFECT_DETAIL") = "No"
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.UNREALFETRADE
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("NTIUNT_KEY") = 0
                    dtRow("NTIUNT_SOURCENO") = SourceNo
                    dtRow("NTIUNT_DESC") = dtRowImport("Description")
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("NTIUNT_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("NTIUNT_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dtRow("NTIUNT_NOTE") = ""
                    dtRow("NTIUNT_DETAIL") = "No"
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.OTHERNONTAXINC
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("NT_KEY") = 0
                    dtRow("NT_REF_NO") = RefNo
                    dtRow("NT_YA") = YA
                    dtRow("NTIUNT_SOURCENO") = SourceNo
                    dtRow("NT_DESC") = dtRowImport("Description")
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("NT_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("NT_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dtRow("NT_CATEGORIZED") = "Other"
                    dtRow("NT_NOTE") = ""
                    dtRow("NT_DETAIL") = "No"
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPOTHERINTEREST
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXI_KEY") = 0
                    dtRow("EXI_SOURCENO") = SourceNo
                    dtRow("EXI_DESC") = dtRowImport("Description")
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXI_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXI_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dtRow("EXI_DEDUCTIBLE") = False
                    dtRow("EXI_DEDUCTIBLE_ADD") = False
                    dtRow("EXI_NOTE") = ""
                    dtRow("EXI_DETAIL") = "No"
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPLEGAL
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXL_KEY") = 0
                    dtRow("EXL_SOURCENO") = SourceNo
                    dtRow("EXL_DESC") = dtRowImport("Description")
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXL_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXL_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dtRow("EXL_DEDUCTIBLE") = False
                    dtRow("EXL_DEDUCTIBLE_ADD") = False
                    dtRow("EXL_NOTE") = ""
                    dtRow("EXL_DETAIL") = "No"
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPTECHNICAL
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXTF_KEY") = 0       
                    dtRow("EXTF_SOURCENO") = SourceNo
                    dtRow("EXTF_DESC") = dtRowImport("Description")
                    dtRow("EXTF_DEDUCTIBLE") = False
                    dtRow("EXTF_DEDUCTIBLE_ADD") = False
                    dtRow("EXTF_NOTE") = ""
                    dtRow("EXTF_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXTF_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXTF_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPCONTRACTPAY
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXC_KEY") = 0
                    dtRow("EXC_SOURCENO") = SourceNo
                    dtRow("EXC_DESC") = dtRowImport("Description")
                    dtRow("EXC_DEDUCTIBLE") = False
                    dtRow("EXC_DEDUCTIBLE_ADD") = False
                    dtRow("EXC_NOTE") = ""
                    dtRow("EXC_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXC_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXC_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPDIRECTORFEE
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXDF_KEY") = 0
                    dtRow("EXDF_SOURCENO") = SourceNo
                    dtRow("EXDF_DESC") = dtRowImport("Description")
                    dtRow("EXDF_DEDUCTIBLE") = False
                    dtRow("EXDF_DEDUCTIBLE_ADD") = False
                    dtRow("EXDF_NOTE") = ""
                    dtRow("EXDF_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXDF_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXDF_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPSALARY
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXS_KEY") = 0
                    dtRow("EXS_SOURCENO") = SourceNo
                    dtRow("EXS_DESC") = dtRowImport("Description")
                    dtRow("EXS_DEDUCTIBLE") = False
                    dtRow("EXS_DEDUCTIBLE_ADD") = False
                    dtRow("EXS_NOTE") = ""
                    dtRow("EXS_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXS_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXS_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPEMPLOYEESTOCK
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXES_KEY") = 0
                    dtRow("EXES_SOURCENO") = SourceNo
                    dtRow("EXES_DESC") = dtRowImport("Description")
                    dtRow("EXES_DEDUCTIBLE") = False
                    dtRow("EXES_DEDUCTIBLE_ADD") = False
                    dtRow("EXES_NOTE") = ""
                    dtRow("EXES_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXES_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXES_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPROYALTY
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXRO_KEY") = 0
                    dtRow("EXRO_SOURCENO") = SourceNo
                    dtRow("EXRO_DESC") = dtRowImport("Description")
                    dtRow("EXRO_DEDUCTIBLE") = False
                    dtRow("EXRO_DEDUCTIBLE_ADD") = False
                    dtRow("EXRO_NOTE") = ""
                    dtRow("EXRO_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXRO_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXRO_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPRENTAL
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXRENT_KEY") = 0
                    dtRow("EXRENT_SOURCENO") = SourceNo
                    dtRow("EXRENT_DESC") = dtRowImport("Description")
                    dtRow("EXRENT_DEDUCTIBLE") = False
                    dtRow("EXRENT_DEDUCTIBLE_ADD") = False
                    dtRow("EXRENT_NOTE") = ""
                    dtRow("EXRENT_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXRENT_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXRENT_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPREPAIRMAINTENANCE
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXREP_KEY") = 0
                    dtRow("EXREP_SOURCENO") = SourceNo
                    dtRow("EXREP_DESC") = dtRowImport("Description")
                    dtRow("EXREP_DEDUCTIBLE") = False
                    dtRow("EXREP_DEDUCTIBLE_ADD") = False
                    dtRow("EXREP_NOTE") = ""
                    dtRow("EXREP_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXREP_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXREP_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPRND
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXRES_KEY") = 0
                    dtRow("EXRES_SOURCENO") = SourceNo
                    dtRow("EXRES_DESC") = dtRowImport("Description")
                    dtRow("EXRES_DEDUCTIBLE") = False
                    dtRow("EXRES_DEDUCTIBLE_ADD") = False
                    dtRow("EXRES_NOTE") = ""
                    dtRow("EXRES_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXRES_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXRES_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPADVERTISEMENT
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXP_KEY") = 0
                    dtRow("EXP_SOURCENO") = SourceNo
                    dtRow("EXP_DESC") = dtRowImport("Description")
                    dtRow("EXP_DEDUCTIBLE") = False
                    dtRow("EXP_DEDUCTIBLE_ADD") = False
                    dtRow("EXP_NOTE") = ""
                    dtRow("EXP_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXP_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXP_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPTRAVEL
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXT_KEY") = 0
                    dtRow("EXT_SOURCENO") = SourceNo
                    dtRow("EXT_DESC") = dtRowImport("Description")
                    dtRow("EXT_DEDUCTIBLE") = False
                    dtRow("EXT_DEDUCTIBLE_ADD") = False
                    dtRow("EXT_NOTE") = ""
                    dtRow("EXT_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXT_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXT_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPJKDM
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXJK_KEY") = 0
                    dtRow("EXJK_SOURCENO") = SourceNo
                    dtRow("EXJK_DESC") = dtRowImport("Description")
                    dtRow("EXJK_DEDUCTIBLE") = False
                    dtRow("EXJK_DEDUCTIBLE_ADD") = False
                    dtRow("EXJK_NOTE") = ""
                    dtRow("EXJK_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXJK_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXJK_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPDEPRECIATION
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXODEP_KEY") = 0
                    dtRow("EXODEP_SOURCENO") = SourceNo
                    dtRow("EXODEP_DESC") = dtRowImport("Description")
                    dtRow("EXODEP_DEDUCTIBLE") = False
                    dtRow("EXODEP_DEDUCTIBLE_ADD") = False
                    dtRow("EXODEP_NOTE") = ""
                    dtRow("EXODEP_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXODEP_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXODEP_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPDONATIONAPPR
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXOAD_KEY") = 0
                    dtRow("EXOAD_SOURCENO") = SourceNo
                    dtRow("EXOAD_DESC") = dtRowImport("Description")
                    dtRow("EXOAD_DEDUCTIBLE") = False
                    dtRow("EXOAD_DEDUCTIBLE_ADD") = False
                    dtRow("EXOAD_NOTE") = ""
                    dtRow("EXOAD_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXOAD_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXOAD_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPDONATIONNONAPPR
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXONAD_KEY") = 0
                    dtRow("EXONAD_SOURCENO") = SourceNo
                    dtRow("EXONAD_DESC") = dtRowImport("Description")
                    dtRow("EXONAD_DEDUCTIBLE") = False
                    dtRow("EXONAD_DEDUCTIBLE_ADD") = False
                    dtRow("EXONAD_NOTE") = ""
                    dtRow("EXONAD_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXONAD_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXONAD_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPZAKAT
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXOZ_KEY") = 0
                    dtRow("EXOZ_SOURCENO") = SourceNo
                    dtRow("EXOZ_DESC") = dtRowImport("Description")
                    dtRow("EXOZ_DEDUCTIBLE") = False
                    dtRow("EXOZ_DEDUCTIBLE_ADD") = False
                    dtRow("EXOZ_NOTE") = ""
                    dtRow("EXOZ_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXOZ_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXOZ_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPLOSSDISPFA
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXOLD_KEY") = 0
                    dtRow("EXOLD_SOURCENO") = SourceNo
                    dtRow("EXOLD_DESC") = dtRowImport("Description")
                    dtRow("EXOLD_DEDUCTIBLE") = False
                    dtRow("EXOLD_DEDUCTIBLE_ADD") = False
                    dtRow("EXOLD_NOTE") = ""
                    dtRow("EXOLD_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXOLD_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXOLD_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPENTERTAINNONSTAFF
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXOENS_KEY") = 0
                    dtRow("EXOENS_SOURCENO") = SourceNo
                    dtRow("EXOENS_DESC") = dtRowImport("Description")
                    dtRow("EXOENS_DEDUCTIBLE") = False
                    dtRow("EXOENS_DEDUCTIBLE_ADD") = False
                    dtRow("EXOENS_NOTE") = ""
                    dtRow("EXOENS_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXOENS_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXOENS_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPENTERTAINSTAFF
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXOES_KEY") = 0
                    dtRow("EXOES_SOURCENO") = SourceNo
                    dtRow("EXOES_DESC") = dtRowImport("Description")
                    dtRow("EXOES_DEDUCTIBLE") = False
                    dtRow("EXOES_DEDUCTIBLE_ADD") = False
                    dtRow("EXOES_NOTE") = ""
                    dtRow("EXOES_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXOES_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXOES_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPCOMPAUNDPENALTY
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXOP_KEY") = 0
                    dtRow("EXOP_SOURCENO") = SourceNo
                    dtRow("EXOP_DESC") = dtRowImport("Description")
                    dtRow("EXOP_DEDUCTIBLE") = False
                    dtRow("EXOP_DEDUCTIBLE_ADD") = False
                    dtRow("EXOP_NOTE") = ""
                    dtRow("EXOP_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXOP_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXOP_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPPROVISION
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXOPA_KEY") = 0
                    dtRow("EXOPA_SOURCENO") = SourceNo
                    dtRow("EXOPA_DESC") = dtRowImport("Description")
                    dtRow("EXOPA_DEDUCTIBLE") = False
                    dtRow("EXOPA_DEDUCTIBLE_ADD") = False
                    dtRow("EXOPA_NOTE") = ""
                    dtRow("EXOPA_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXOPA_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXOPA_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPLEAVEPASSAGE
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXOLP_KEY") = 0
                    dtRow("EXOLP_SOURCENO") = SourceNo
                    dtRow("EXOLP_DESC") = dtRowImport("Description")
                    dtRow("EXOLP_DEDUCTIBLE") = False
                    dtRow("EXOLP_DEDUCTIBLE_ADD") = False
                    dtRow("EXOLP_NOTE") = ""
                    dtRow("EXOLP_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXOLP_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXOLP_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPFAWRITTENOFF
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXOWO_KEY") = 0
                    dtRow("EXOWO_SOURCENO") = SourceNo
                    dtRow("EXOWO_DESC") = dtRowImport("Description")
                    dtRow("EXOWO_DEDUCTIBLE") = False
                    dtRow("EXOWO_DEDUCTIBLE_ADD") = False
                    dtRow("EXOWO_NOTE") = ""
                    dtRow("EXOWO_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXOWO_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXOWO_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPUNREALLOSSFE
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXOUR_KEY") = 0
                    dtRow("EXOUR_SOURCENO") = SourceNo
                    dtRow("EXOUR_DESC") = dtRowImport("Description")
                    dtRow("EXOUR_DEDUCTIBLE") = False
                    dtRow("EXOUR_DEDUCTIBLE_ADD") = False
                    dtRow("EXOUR_NOTE") = ""
                    dtRow("EXOUR_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXOUR_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXOUR_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPREALLOSSFETRADE
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXORT_KEY") = 0
                    dtRow("EXORT_SOURCENO") = SourceNo
                    dtRow("EXORT_DESC") = dtRowImport("Description")
                    dtRow("EXORT_DEDUCTIBLE") = False
                    dtRow("EXORT_DEDUCTIBLE_ADD") = False
                    dtRow("EXORT_NOTE") = ""
                    dtRow("EXORT_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXORT_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXORT_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPREALLOSSFENONTRADE
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXOR_KEY") = 0
                    dtRow("EXOR_SOURCENO") = SourceNo
                    dtRow("EXOR_DESC") = dtRowImport("Description")
                    dtRow("EXOR_DEDUCTIBLE") = False
                    dtRow("EXOR_DEDUCTIBLE_ADD") = False
                    dtRow("EXOR_NOTE") = ""
                    dtRow("EXOR_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXOR_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXOR_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPINITIALSUBSCRIPT
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXOIS_KEY") = 0
                    dtRow("EXOIS_SOURCENO") = SourceNo
                    dtRow("EXOIS_DESC") = dtRowImport("Description")
                    dtRow("EXOIS_DEDUCTIBLE") = False
                    dtRow("EXOIS_DEDUCTIBLE_ADD") = False
                    dtRow("EXOIS_NOTE") = ""
                    dtRow("EXOIS_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXOIS_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXOIS_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPCAPITALEXPENDITURE
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXOCE_KEY") = 0
                    dtRow("EXOCE_SOURCENO") = SourceNo
                    dtRow("EXOCE_DESC") = dtRowImport("Description")
                    dtRow("EXOCE_DEDUCTIBLE") = False
                    dtRow("EXOCE_DEDUCTIBLE_ADD") = False
                    dtRow("EXOCE_NOTE") = ""
                    dtRow("EXOCE_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXOCE_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXOCE_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
                    dtRow = dsMain.Tables(TableName).NewRow
                    dtRow("EXO_KEY") = 0
                    dtRow("EXO_SOURCENO") = SourceNo
                    dtRow("EXO_DESC") = dtRowImport("Description")
                    dtRow("EXO_DEDUCTIBLE") = False
                    dtRow("EXO_DEDUCTIBLE_ADD") = False
                    dtRow("EXO_NOTE") = ""
                    dtRow("EXO_DETAIL") = "No"
                    If IsNumeric(dtRowImport("LeftAmount")) = True AndAlso CDec(dtRowImport("LeftAmount")) > 0 Then
                        dtRow("EXO_AMOUNT") = dtRowImport("LeftAmount")
                    Else
                        dtRow("EXO_AMOUNT") = dtRowImport("RightAmount")
                    End If
                    dsMain.Tables(TableName).Rows.Add(dtRow)
                Case Else

            End Select

            Return True
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
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
                                       Optional ByRef Errorlog As clsError = Nothing) As Boolean

        Try
            Dim dtPNL As DataTable = mdlProcess.Load_PNL(RefNo, YA, Errorlog)

            If dtPNL Is Nothing Then
                If Errorlog Is Nothing Then
                    Errorlog = New clsError
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

            While mdlProcess.Validate_PNL_TEMP_REPORTID(ID)
                ID = "PNL_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)
            End While

            Dim listoflabelname As List(Of clsPNL_LabelName) = mdlPNL.GetPNLLabelName_Report(Errorlog)

            If listoflabelname IsNot Nothing Then
                Dim ParentID As Integer = 0
                Dim IDData As Integer = 0
                Dim indexNo As Integer = 0
                Dim ColumnName As String = Nothing
                Dim AlignAmountLeft As Boolean = True
                Dim TypeRow As PNL_REPORT_TypeRow = PNL_REPORT_TypeRow.NORMAL
                Dim SubStatus As Boolean = False
                For Each lbl As clsPNL_LabelName In listoflabelname

                    Select Case lbl.Type
                        Case TaxComPNLEnuItem.SALES
                            ColumnName = "PL_SALES"
                            AlignAmountLeft = False
                            TypeRow = PNL_REPORT_TypeRow.TITLE
                        Case TaxComPNLEnuItem.LESSCOSTSALES_TITLEONLY
                            ColumnName = ""
                            AlignAmountLeft = True
                            TypeRow = PNL_REPORT_TypeRow.TITLE
                        Case TaxComPNLEnuItem.OPENSTOCK
                            ColumnName = "PL_OP_STK"
                            AlignAmountLeft = True
                            TypeRow = PNL_REPORT_TypeRow.NORMAL
                        Case TaxComPNLEnuItem.PURCHASE
                            ColumnName = "PL_PURCHASES"
                            TypeRow = PNL_REPORT_TypeRow.NORMAL
                            AlignAmountLeft = True
                        Case TaxComPNLEnuItem.DEPRECIATION
                            ColumnName = "PL_PRO_COST_DPC"
                            TypeRow = PNL_REPORT_TypeRow.NORMAL
                            AlignAmountLeft = True
                        Case TaxComPNLEnuItem.OTHERALLOWEXP
                            ColumnName = "PL_PRO_COST_OAE"
                            TypeRow = PNL_REPORT_TypeRow.NORMAL
                            AlignAmountLeft = True
                        Case TaxComPNLEnuItem.OTHERNONALLOWEXP
                            ColumnName = "PL_PRO_COST_ONAE"
                            TypeRow = PNL_REPORT_TypeRow.NORMAL
                            AlignAmountLeft = True
                        Case TaxComPNLEnuItem.COSTPRODUCT_TITLEONLY
                            ColumnName = ""
                            TypeRow = PNL_REPORT_TypeRow.TITLE
                            AlignAmountLeft = True
                        Case TaxComPNLEnuItem.COSTPRODUCT
                            ColumnName = "PL_PURCHASES_PRO_COST"
                            TypeRow = PNL_REPORT_TypeRow.SUBTOTAL
                            AlignAmountLeft = True
                        Case TaxComPNLEnuItem.CLOSESTOCK
                            ColumnName = "PL_CLS_STK"
                            TypeRow = PNL_REPORT_TypeRow.NORMAL
                            AlignAmountLeft = True
                        Case TaxComPNLEnuItem.COSTOFSALES
                            ColumnName = "PL_COGS"
                            TypeRow = PNL_REPORT_TypeRow.SUBTOTAL
                            AlignAmountLeft = False
                        Case TaxComPNLEnuItem.GROSSPROFIT
                            ColumnName = "PL_GROSS_PROFIT"
                            TypeRow = PNL_REPORT_TypeRow.TOTAL
                            AlignAmountLeft = False
                        Case Else
                            ColumnName = ""
                            TypeRow = PNL_REPORT_TypeRow.NORMAL
                            AlignAmountLeft = False
                    End Select

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
                                dtRow("Caption") = lbl.LabelTricor
                            Else
                                dtRow("Caption") = lbl.LabelName
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

                Return mdlProcess.Save_PNL_Report_TEMP(dsDataSet.Tables(TableName), Errorlog)
            End If

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
            AddListOfError(Errorlog)
            Return True
        End Try
    End Function

    Public Function PNL_Report(ByVal RefNo As String, ByVal YA As String, ByRef ds As DataSet, Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try

            Dim dtPNL As DataTable = mdlProcess.Load_PNL(RefNo, YA, Errorlog)

           
            If ds Is Nothing Then
                ds = New dsPNL
            End If

            ds.Tables("PROFIT_LOSS_ACCOUNT_REPORT_SCH").Rows.Clear()
            ds.Tables("PROFIT_LOSS_ACCOUNT_REPORT").Rows.Clear()

            If dtPNL Is Nothing Then
                If Errorlog Is Nothing Then
                    Errorlog = New clsError
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

            Dim dtRow As DataRow = Nothing
            Dim PNL_KEY As Integer = 0
            Dim ScheduleInt As Integer = 0
            Dim ColumnName As String = Nothing
            Dim isHaveData As Boolean = False
            Dim listofclsPNLLabel As List(Of clsPNL_LabelName) = GetPNLLabelName()

            ClearMemoryDataset()

            For i As Integer = 0 To dtPNL.Rows.Count - 1
                ds.Tables("PROFIT_LOSS_ACCOUNT_REPORT").ImportRow(dtPNL.Rows(i))

                PNL_KEY = IIf(IsDBNull(dtPNL.Rows(i)("PL_KEY")), 0, dtPNL.Rows(i)("PL_KEY"))

                dtRow = Nothing
                dtRow = ds.Tables("PROFIT_LOSS_ACCOUNT_REPORT_SCH").NewRow
                dtRow("PL_KEY") = PNL_KEY

                If listofclsPNLLabel IsNot Nothing Then
                    For Each tmp As clsPNL_LabelName In listofclsPNLLabel

                        mdlPNL2.PNL_GetData(PNL_KEY, tmp.Type, RefNo, YA, ds, Errorlog, isHaveData)

                        Select Case tmp.Type
                            Case TaxComPNLEnuItem.SALES
                                ColumnName = "PL_SALES"

                            Case TaxComPNLEnuItem.OPENSTOCK
                                ColumnName = "PL_OP_STK"
                            Case TaxComPNLEnuItem.PURCHASE
                                ColumnName = "PL_PURCHASES"

                            Case TaxComPNLEnuItem.DEPRECIATION
                                ColumnName = "PL_PRO_COST_DPC"

                            Case TaxComPNLEnuItem.OTHERALLOWEXP
                                ColumnName = "PL_PRO_COST_OAE"

                            Case TaxComPNLEnuItem.OTHERNONALLOWEXP
                                ColumnName = "PL_DISALLOWED_EXP"

                            Case TaxComPNLEnuItem.CLOSESTOCK
                                ColumnName = "PL_CLS_STK"

                            Case TaxComPNLEnuItem.OTHERBUSINC
                                ColumnName = "PL_OTH_BSIN"

                            Case TaxComPNLEnuItem.REALFETRADE
                                ColumnName = "PL_OTH_BSIN_REALGT"

                            Case TaxComPNLEnuItem.INTERESTINC
                                ColumnName = "PL_OTH_IN_INTEREST"

                            Case TaxComPNLEnuItem.ROYALTYINC
                                ColumnName = "PL_OTH_IN_ROYALTY"

                            Case TaxComPNLEnuItem.OTHERINC
                                ColumnName = "PL_OTH_IN_OTHER"

                            Case TaxComPNLEnuItem.PDFIXASSET
                                ColumnName = "PL_NONTAX_IN_FA_DISP"

                            Case TaxComPNLEnuItem.PDINVEST
                                ColumnName = "PL_NONTAX_IN_INV_DISP"

                            Case TaxComPNLEnuItem.FORINCREMIT
                                ColumnName = "PL_NONTAX_IN_FIR"

                            Case TaxComPNLEnuItem.REALFE
                                ColumnName = "PL_OTH_BSIN_UNREALGT"

                            Case TaxComPNLEnuItem.UNREALFETRADE
                                ColumnName = "PL_NONTAX_IN_UNREALG"

                            Case TaxComPNLEnuItem.UNREALFENONTRADE
                                ColumnName = "PL_NONTAX_IN_REALG"

                            Case TaxComPNLEnuItem.EXPOTHERINTEREST
                                ColumnName = "PL_EXP_INT"

                            Case TaxComPNLEnuItem.EXPLEGAL
                                ColumnName = "PL_LAWYER_COST"

                            Case TaxComPNLEnuItem.EXPTECHNICAL
                                ColumnName = "PL_TECH_FEE"

                            Case TaxComPNLEnuItem.EXPCONTRACTPAY
                                ColumnName = "PL_CONTRACT_EXP"

                            Case TaxComPNLEnuItem.EXPDIRECTORFEE
                                ColumnName = "PL_DIRECTORS_FEE"

                            Case TaxComPNLEnuItem.EXPSALARY
                                ColumnName = "PL_EXP_SALARY"

                            Case TaxComPNLEnuItem.EXPEMPLOYEESTOCK
                                ColumnName = "PL_EMPL_STOCK"

                            Case TaxComPNLEnuItem.EXPROYALTY
                                ColumnName = "PL_ROYALTY"

                            Case TaxComPNLEnuItem.EXPRENTAL
                                ColumnName = "PL_EXP_RENT"

                            Case TaxComPNLEnuItem.EXPREPAIRMAINTENANCE
                                ColumnName = "PL_EXP_MAINTENANCE"

                            Case TaxComPNLEnuItem.EXPRND
                                ColumnName = "PL_RND"

                            Case TaxComPNLEnuItem.EXPADVERTISEMENT
                                ColumnName = "PL_ADVERT"

                            Case TaxComPNLEnuItem.EXPTRAVEL
                                ColumnName = "PL_TRAVEL"

                            Case TaxComPNLEnuItem.EXPJKDM
                                ColumnName = "PL_JKDM"

                            Case TaxComPNLEnuItem.EXPDEPRECIATION
                                ColumnName = "PL_OTHER_EXP_DPC"

                            Case TaxComPNLEnuItem.EXPDONATIONAPPR
                                ColumnName = "PL_OTHER_EXP_DNT_APP"

                            Case TaxComPNLEnuItem.EXPDONATIONNONAPPR
                                ColumnName = "PL_OTHER_EXP_DNT_NAPP"

                            Case TaxComPNLEnuItem.EXPZAKAT
                                ColumnName = "PL_OTHER_EXP_ZAKAT"

                            Case TaxComPNLEnuItem.EXPLOSSDISPFA
                                ColumnName = "PL_OTHER_EXP_FA_DISP"

                            Case TaxComPNLEnuItem.EXPENTERTAINNONSTAFF
                                ColumnName = "PL_OTHER_EXP_ENTM_CLNT"

                            Case TaxComPNLEnuItem.EXPENTERTAINSTAFF
                                ColumnName = "PL_OTHER_EXP_ENTM_STFF"

                            Case TaxComPNLEnuItem.EXPCOMPAUNDPENALTY
                                ColumnName = "PL_OTHER_EXP_PENALTY"

                            Case TaxComPNLEnuItem.EXPPROVISION
                                ColumnName = "PL_OTHER_EXP_PROV_ACC"

                            Case TaxComPNLEnuItem.EXPLEAVEPASSAGE
                                ColumnName = "PL_OTHER_EXP_LEAVE"

                            Case TaxComPNLEnuItem.EXPFAWRITTENOFF
                                ColumnName = "PL_OTHER_EXP_FA_WO"

                            Case TaxComPNLEnuItem.EXPUNREALLOSSFE
                                ColumnName = "PL_OTHER_EXP_UNREALOSS"

                            Case TaxComPNLEnuItem.EXPREALLOSSFETRADE
                                ColumnName = "PL_OTHER_EXP_REALOSS"

                            Case TaxComPNLEnuItem.EXPREALLOSSFENONTRADE
                                ColumnName = "PL_OTHER_EXRLOSSFOREIGNT"

                            Case TaxComPNLEnuItem.EXPINITIALSUBSCRIPT
                                ColumnName = "PL_OTHER_EXP_INI_SUB"

                            Case TaxComPNLEnuItem.EXPCAPITALEXPENDITURE
                                ColumnName = "PL_OTHER_EXP_CAP_EXP"

                            Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
                                ColumnName = "PL_OTHER_EXP_OTHERS"

                            Case TaxComPNLEnuItem.RENTALINC
                                ColumnName = "PL_OTH_IN_RENTAL"

                            Case TaxComPNLEnuItem.OTHERNONTAXINC
                                ColumnName = "PL_NONTAX_IN_INSU_COMP"

                            Case TaxComPNLEnuItem.EXEMDIV
                                ColumnName = "PL_NONTAX_IN_EXM_DIV"

                            Case TaxComPNLEnuItem.INTERESTRESTRICT
                                ColumnName = "PL_EXP_INTRESTRICT"

                            Case TaxComPNLEnuItem.DIVIDENDINC
                                ColumnName = "PL_OTH_IN_DIVIDEND"

                        End Select


                        If isHaveData Then
                            ScheduleInt += 1
                            dtRow(ColumnName) = ScheduleInt
                        Else
                            dtRow(ColumnName) = DBNull.Value
                        End If
                        Application.DoEvents()
                    Next
                End If

                ds.Tables("PROFIT_LOSS_ACCOUNT_REPORT_SCH").Rows.Add(dtRow)

            Next

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
            Return False
        End Try
    End Function



End Module
