Module mdlReport_CA
    Dim MaxYearForCA As Integer = 150
    Public Function GenerateCA_Calculation(ByRef ds As DataSet, CA_KEY As Integer, CA_QUALIFYING_COST As Decimal, CA_RATE_IA As Integer, CA_RATE_AA As Integer, CA_MODE As String, _
                                           CA_NAME As String, HP_CODE As String, CA_SOURCENO As Integer, CA_YA As Integer, _
                                           CA_PURCHASE_YE As Integer, TWDV As Integer) As Boolean
        Try
            Dim QC_BF As Decimal = 0
            Dim QC_ADD As Decimal = 0
            Dim QC_DISP As Decimal = 0
            Dim QC_CF As Decimal = 0
            Dim TWDV_BF As Decimal = 0
            Dim TWDV_ADD As Decimal = 0
            Dim TWDV_DISP As Decimal = 0
            Dim TWDV_TOTAL As Decimal = 0
            Dim TWDV_IA As Decimal = 0
            Dim TWDV_AA As Decimal = 0
            Dim TWDV_CF As Decimal = 0

            Dim TOTAL_IA As Decimal = 0
            Dim TOTAL_AA As Decimal = 0
            Dim LEFT_IA_AA As Decimal = 0
            Dim ClaimInUsePercent As Integer = 0
            Dim CurrentYA As Integer = 0
            Dim isFirstYear As Boolean = False

            Dim CA_QUA_AMOUNT As Decimal = 0
            Dim CA_IA As Integer = 0
            Dim CA_AA As Integer = 0
            '   Dim CA_PURCHASE_YE As Integer = 0
            Dim CA_TRANSFERROR_NAME As String = Nothing
            Dim CA_ASSET_NAME As String = Nothing
            Dim CA_CATEGORY As String = Nothing
            Dim dtDisposal As DataTable = Nothing
            Dim DISP_AMOUNT As Decimal = 0
            Dim IndexNo As Integer = 0
            Dim dtCategory As DataTable = Nothing
            Dim dtRow As DataRow = Nothing
            Dim IsControlTransfer As Boolean = False
            'Dim dt As DataTable = ADO.Load_CA(CA_KEY)

            'If dt Is Nothing Then
            '    If Errorlog Is Nothing Then
            '        Errorlog = New ClsError
            '    End If
            '    With Errorlog
            '        .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
            '        .ErrorCode = "P10001"
            '        .ErrorDateTime = Now
            '        .ErrorMessage = "No data found for CA = " & CA_KEY
            '    End With
            '    Return False
            'End If

            'With dt.Rows(0)

            '   CA_TRANSFERROR_NAME = CStr(IIf(IsDBNull(dt.Rows(0)("CA_TRANSFERROR_NAME")), "", dt.Rows(0)("CA_TRANSFERROR_NAME"))) & " [" & CStr(IIf(IsDBNull(dt.Rows(0)("CA_TAX_FILE_NUMBER")), "", dt.Rows(0)("CA_TAX_FILE_NUMBER"))) & "]"
            '    CA_ASSET_NAME = CStr(IIf(IsDBNull(dt.Rows(0)("CA_ASSET")), "", dt.Rows(0)("CA_ASSET")))
            'dtCategory = ADO.LoadCategory(CStr(IIf(IsDBNull(dt.Rows(0)("CA_CATEGORY_CODE")), "", dt.Rows(0)("CA_CATEGORY_CODE"))), Errorlog)

            'If dtCategory IsNot Nothing Then
            '    CA_CATEGORY = CStr(IIf(IsDBNull(dtCategory.Rows(0)("CA_CATEGORY")), "", dtCategory.Rows(0)("CA_CATEGORY")))

            'Else
            '    CA_CATEGORY = CStr(IIf(IsDBNull(dt.Rows(0)("CA_CATEGORY_CODE")), "", dt.Rows(0)("CA_CATEGORY_CODE")))
            'End If

            'If CA_CATEGORY.ToUpper <> "Capital Expenditure Expensed Off in Income Statement" Then
            '    CA_CATEGORY = " " & CA_CATEGORY
            'End If

            'CA_CATEGORY = CStr(IIf(IsDBNull(dt.Rows(0)("CA_CATEGORY_CODE")), "", dt.Rows(0)("CA_CATEGORY_CODE")))
            ' HP_CODE = CStr(IIf(IsDBNull(dt.Rows(0)("HP_CODE")), "", dt.Rows(0)("HP_CODE")))
            'CA_SOURCENO = CInt(IIf(IsDBNull(dt.Rows(0)("CA_SOURCENO")), 0, dt.Rows(0)("CA_SOURCENO")))
            'CA_YA = CInt(IIf(IsDBNull(dt.Rows(0)("CA_YA")), 0, dt.Rows(0)("CA_YA")))

            'If IsDBNull(dt.Rows(0)("CA_PURCHASE_YEAR")) = False AndAlso IsNumeric(dt.Rows(0)("CA_PURCHASE_YEAR")) = True Then
            '    CA_PURCHASE_YE = CInt(dt.Rows(0)("CA_PURCHASE_YEAR"))
            'Else
            '    CA_PURCHASE_YE = 0
            'End If

            ' End With
            CA_QUA_AMOUNT = CA_QUALIFYING_COST
            CA_IA = CA_RATE_IA
            CA_AA = CA_RATE_AA
            CA_MODE = CA_MODE
            CA_NAME = CA_NAME

            If CA_MODE.ToUpper = "OPN" Then
                CurrentYA = CA_YA
            Else
                CurrentYA = CA_PURCHASE_YE
            End If

            TOTAL_IA += CA_IA
            TOTAL_AA += CA_AA

            LEFT_IA_AA = 100 - (TOTAL_IA + TOTAL_AA)
            dtDisposal = ADO.Load_DISPOSAL_BY_CA_KEY_DISP_YA(CA_KEY, CStr(CurrentYA), Errorlog)

            If CA_MODE.ToUpper = "OPN" Then
                QC_BF = CA_QUA_AMOUNT
                QC_ADD = 0

                LEFT_IA_AA = ((CA_QUA_AMOUNT - TWDV) / CA_QUA_AMOUNT) * 100
                If dtDisposal IsNot Nothing Then
                    DISP_AMOUNT = CDec(IIf(IsDBNull(dtDisposal.Rows(0)("CA_DISP_QC")), 0, dtDisposal.Rows(0)("CA_DISP_QC")))
                Else
                    DISP_AMOUNT = 0
                End If
                TOTAL_AA += LEFT_IA_AA
                ' If dtDisposal IsNot Nothing AndAlso IsDBNull(dtDisposal.Rows(0)("CA_DISP_TYPE")) = False AndAlso dtDisposal.Rows(0)("CA_DISP_TYPE") <> 2 Then
                '    DISP_AMOUNT = CDec(IIf(IsDBNull(dtDisposal.Rows(0)("CA_DISP_QC")), 0, dtDisposal.Rows(0)("CA_DISP_QC")))
                'Else
                '    If dtDisposal IsNot Nothing AndAlso IsDBNull(dtDisposal.Rows(0)("CA_DISP_TYPE")) = False AndAlso dtDisposal.Rows(0)("CA_DISP_TYPE") = 2 Then
                '        IsControlTransfer = True
                '    End If
                '    DISP_AMOUNT = 0
                'End If

                QC_DISP = DISP_AMOUNT

                QC_CF = QC_BF + QC_ADD - QC_DISP
                TWDV_BF = TWDV
                TWDV_ADD = 0

                If DISP_AMOUNT <> 0 Then
                    TWDV_DISP = (DISP_AMOUNT / 100) * LEFT_IA_AA
                Else
                    DISP_AMOUNT = 0
                End If

                If TWDV_BF = 0 Then
                    TWDV_IA = 0
                    TWDV_AA = 0
                Else
                    TWDV_IA = 0
                    TWDV_AA = (QC_CF / 100) * CA_AA
                End If

                TWDV_TOTAL = TWDV_BF + TWDV_ADD - TWDV_DISP
                ' TWDV_CF = TWDV_BF + TWDV_ADD - TWDV_DISP - TWDV_IA - TWDV_AA

                If QC_CF = 0 AndAlso QC_DISP > 0 Then
                    TWDV_CF = 0
                Else
                    TWDV_CF = TWDV_BF + TWDV_ADD - TWDV_DISP - TWDV_IA - TWDV_AA
                End If
            Else
                QC_BF = 0
                QC_ADD = CA_QUA_AMOUNT

                If dtDisposal IsNot Nothing Then
                    DISP_AMOUNT = CDec(IIf(IsDBNull(dtDisposal.Rows(0)("CA_DISP_QC")), 0, dtDisposal.Rows(0)("CA_DISP_QC")))
                Else
                    DISP_AMOUNT = 0
                End If

                'If dtDisposal IsNot Nothing AndAlso IsDBNull(dtDisposal.Rows(0)("CA_DISP_TYPE")) = False AndAlso dtDisposal.Rows(0)("CA_DISP_TYPE") <> 2 Then
                '    DISP_AMOUNT = CDec(IIf(IsDBNull(dtDisposal.Rows(0)("CA_DISP_QC")), 0, dtDisposal.Rows(0)("CA_DISP_QC")))
                'Else
                '    If dtDisposal IsNot Nothing AndAlso IsDBNull(dtDisposal.Rows(0)("CA_DISP_TYPE")) = False AndAlso dtDisposal.Rows(0)("CA_DISP_TYPE") = 2 Then
                '        IsControlTransfer = True
                '    End If
                '    DISP_AMOUNT = 0
                'End If

                QC_DISP = DISP_AMOUNT
                QC_CF = QC_BF + QC_ADD - QC_DISP
                TWDV_BF = 0
                TWDV_ADD = CA_QUA_AMOUNT

                If DISP_AMOUNT <> 0 Then
                    TWDV_DISP = (DISP_AMOUNT / 100) * 100
                Else
                    DISP_AMOUNT = 0
                End If

                TWDV_IA = (QC_CF / 100) * CA_IA
                TWDV_AA = (QC_CF / 100) * CA_AA
                TWDV_TOTAL = TWDV_BF + TWDV_ADD - TWDV_DISP
                ' TWDV_CF = TWDV_BF + TWDV_ADD - TWDV_DISP - TWDV_IA - TWDV_AA

                If QC_CF = 0 AndAlso QC_DISP > 0 Then
                    TWDV_CF = 0
                Else
                    TWDV_CF = TWDV_BF + TWDV_ADD - TWDV_DISP - TWDV_IA - TWDV_AA
                End If
            End If


            If TWDV_CF < 0 Then
                TWDV_CF = 0
            End If
            'If ADO.Save_CA_TEMP_REPORT(RefNo, CurrentYA, CA_KEY, CA_NAME, CA_ASSET_NAME, CA_CATEGORY, _
            '                                  CA_SOURCENO, CA_YA, HP_CODE, CA_MODE, CA_TRANSFERROR_NAME, CA_PURCHASE_YE, CA_QUA_AMOUNT, _
            '                                  CA_IA, CA_AA, QC_BF, QC_ADD, QC_DISP, QC_CF, TWDV_BF, TWDV_ADD, TWDV_DISP, _
            '                                  TWDV_IA, TWDV_AA, TWDV_TOTAL, TWDV_CF, IndexNo, ADO.CAReport_TableType.CA_REPORT_TEMP, ID, Errorlog) = False Then
            '    Return False
            'End If
            dtRow = ds.Tables("CA_CALCULATION").NewRow
            dtRow("YA") = CurrentYA
            dtRow("QC_BF") = QC_BF
            dtRow("QC_ADD") = QC_ADD
            dtRow("QC_DISP") = QC_DISP
            dtRow("QC_CF") = QC_CF
            dtRow("TWDV_BF") = TWDV_BF
            dtRow("TWDV_ADD") = TWDV_ADD
            dtRow("TWDV_DISP") = TWDV_DISP
            dtRow("TWDV_TOTAL") = TWDV_TOTAL
            dtRow("TWDV_AI") = TWDV_IA
            dtRow("TWDV_AA") = TWDV_AA
            dtRow("TWDV_CF") = TWDV_CF
            ds.Tables("CA_CALCULATION").Rows.Add(dtRow)

            '=========NEXT YEAR===================================
            ' If IsControlTransfer = True Then
            Dim CurrLoop As Integer = 0
            While TWDV_CF > 0 And CurrLoop <= MaxYearForCA
                If IsControlTransfer = True Then
                    Exit While
                End If

                CurrLoop += 1
                CurrentYA += 1
                IndexNo += 1

                LEFT_IA_AA = 100 - (TOTAL_IA + TOTAL_AA)
                If LEFT_IA_AA < 0 Then
                    LEFT_IA_AA = 0
                End If

                QC_BF = QC_CF
                QC_ADD = 0
                dtDisposal = ADO.Load_DISPOSAL_BY_CA_KEY_DISP_YA(CA_KEY, CStr(CurrentYA), Errorlog)


                If dtDisposal IsNot Nothing Then
                    DISP_AMOUNT = CDec(IIf(IsDBNull(dtDisposal.Rows(0)("CA_DISP_QC")), 0, dtDisposal.Rows(0)("CA_DISP_QC")))
                Else
                    DISP_AMOUNT = 0
                End If
                'If dtDisposal IsNot Nothing AndAlso IsDBNull(dtDisposal.Rows(0)("CA_DISP_TYPE")) = False AndAlso dtDisposal.Rows(0)("CA_DISP_TYPE") <> 2 Then
                '    DISP_AMOUNT = CDec(IIf(IsDBNull(dtDisposal.Rows(0)("CA_DISP_QC")), 0, dtDisposal.Rows(0)("CA_DISP_QC")))
                'Else
                '    If dtDisposal IsNot Nothing AndAlso IsDBNull(dtDisposal.Rows(0)("CA_DISP_TYPE")) = False AndAlso dtDisposal.Rows(0)("CA_DISP_TYPE") = 2 Then
                '        IsControlTransfer = True
                '    End If
                '    DISP_AMOUNT = 0
                'End If

                QC_DISP = DISP_AMOUNT
                QC_CF = QC_BF + QC_ADD - QC_DISP
                TWDV_BF = TWDV_CF
                TWDV_ADD = 0

                If QC_DISP <> 0 Then
                    TWDV_DISP = (QC_DISP / 100) * LEFT_IA_AA
                Else
                    TWDV_DISP = 0
                End If

                TWDV_IA = 0
                TWDV_AA = (QC_CF / 100) * CA_AA

                If TWDV_AA > TWDV_BF Then
                    TWDV_AA = TWDV_BF
                End If
                TWDV_TOTAL = TWDV_BF + TWDV_ADD - TWDV_DISP
                TWDV_CF = TWDV_BF + TWDV_ADD - TWDV_DISP - TWDV_IA - TWDV_AA

                If TWDV_CF < 0 Then
                    TWDV_CF = 0
                End If
                'If ADO.Save_CA_TEMP_REPORT(RefNo, CurrentYA, CA_KEY, CA_NAME, CA_ASSET_NAME, CA_CATEGORY, _
                '                            CA_SOURCENO, CA_YA, HP_CODE, CA_MODE, CA_TRANSFERROR_NAME, CA_PURCHASE_YE, CA_QUA_AMOUNT, _
                '                            CA_IA, CA_AA, QC_BF, QC_ADD, QC_DISP, QC_CF, TWDV_BF, TWDV_ADD, TWDV_DISP, _
                '                            TWDV_IA, TWDV_AA, TWDV_TOTAL, TWDV_CF, IndexNo, ADO.CAReport_TableType.CA_REPORT_TEMP, ID, Errorlog) = False Then
                '    Return False
                'End If
                dtRow = ds.Tables("CA_CALCULATION").NewRow
                dtRow("YA") = CurrentYA
                dtRow("QC_BF") = QC_BF
                dtRow("QC_ADD") = QC_ADD
                dtRow("QC_DISP") = QC_DISP
                dtRow("QC_CF") = QC_CF
                dtRow("TWDV_BF") = TWDV_BF
                dtRow("TWDV_ADD") = TWDV_ADD
                dtRow("TWDV_DISP") = TWDV_DISP
                dtRow("TWDV_TOTAL") = TWDV_TOTAL
                dtRow("TWDV_AI") = TWDV_IA
                dtRow("TWDV_AA") = TWDV_AA
                dtRow("TWDV_CF") = TWDV_CF
                ds.Tables("CA_CALCULATION").Rows.Add(dtRow)

                TOTAL_AA += CA_AA
            End While
            '    End If


            Return True
        Catch ex As Exception
            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'If Errorlog Is Nothing Then
            '    Errorlog = New ClsError
            'End If
            'With Errorlog
            '    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
            '    .ErrorCode = ex.GetHashCode.ToString
            '    .ErrorDateTime = Now
            '    .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            'End With
            'AddListOfError(Errorlog)
            Return False
        End Try
    End Function
    Public Function Report_CA(ByVal RefNo As String, ByVal YA As String, ByRef ID As String, _
                              ByVal RateFrom As Integer, ByVal RateTo As Integer, ByVal Category As String, _
                              ByVal isTableOfContent As Boolean,
                              Optional ByRef Errorlog As ClsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = ADO.LoadCA_Search_Report(RefNo, "", RateFrom, RateTo, Category, "", "", Errorlog)

            If dt IsNot Nothing Then

                ID = "CA_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)

                While ADO.Validate_CA_TEMP_REPORTID(ID)
                    ID = "CA_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)
                End While


                For i As Integer = 0 To dt.Rows.Count - 1
                    If IsDBNull(dt.Rows(i)("CA_KEY")) = False Then
                        If mdlReport_CA.GenerateCA_Schudule(RefNo, YA, ID, CInt(dt.Rows(i)("CA_KEY")), Errorlog) = False Then
                            Return False
                        End If
                    End If
                Next
                ShowNoteFooter(3, RefNo, YA, 0, isTableOfContent, Errorlog)
            End If

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
    Public Function Report_HP(ByVal RefNo As String, ByVal YA As String, ByRef ID As String, _
                              ByVal RateFrom As Integer, ByVal RateTo As Integer, ByVal Category As String, _
                               ByVal isTableOfContent As Boolean,
                              Optional ByRef Errorlog As ClsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = ADO.LoadHP_Search(RefNo, "", -1, "", Errorlog)

            If dt IsNot Nothing Then

                ID = "HP_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)

                While ADO.Validate_HP_TEMP_REPORTID(ID)
                    ID = "HP_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)
                End While

                For i As Integer = 0 To dt.Rows.Count - 1
                    If IsDBNull(dt.Rows(i)("HP_KEY")) = False Then
                        If mdlReport_CA.GenerateHP_Schudule(RefNo, YA, ID, CInt(dt.Rows(i)("HP_KEY")), Errorlog) = False Then
                            Return False
                        End If
                    End If
                Next
                ShowNoteFooter(2, RefNo, YA, 0, isTableOfContent, Errorlog)
            End If

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
    Public Function Report_DISPOSAL(ByVal RefNo As String, ByVal YA As String, ByRef ID As String, _
                              ByVal RateFrom As Integer, ByVal RateTo As Integer, ByVal Category As String, _
                              ByVal Type As Integer, ByVal isTableOfContent As Boolean, Optional ByRef Errorlog As ClsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = ADO.LoadDisposal_Search_Report(RefNo, YA, RateFrom, RateTo, Category, Type, Errorlog)

            If dt IsNot Nothing Then

                ID = "CA_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)

                While ADO.Validate_CA_TEMP_REPORTID(ID)
                    ID = "CA_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)
                End While


                Dim CA_QUA_AMOUNT As Decimal = 0
                Dim CA_MODE As String = "OPN"
                Dim CA_KEY As Integer = 0
                Dim CA_RATE_IA As Integer = 0
                Dim CA_RATE_AA As Integer = 0
                Dim CA_YA As Integer = 0
                Dim CA_SOURCENO As Integer = 0
                Dim CA_PURCHASE_YEAR As Integer = 0
                Dim CA_NAME As String = Nothing
                Dim CA_TRANSFERROR_NAME As String = Nothing
                Dim HP_CODE As String = Nothing
                Dim CA_ASSET_NAME As String = Nothing
                Dim CA_CATEGORY_CODE As String = Nothing
                Dim CA_CAEEO As Boolean = False
                Dim CA_QUALIFYING_COST As Decimal = 0
                Dim DISP_KEY As Integer = 0
                Dim DISP_DEPRECIATION As Decimal = 0
                Dim DISP_WDV As Decimal = 0
                Dim DISP_DISPOSAL_VALUE As Decimal = 0
                Dim DISP_PNL As Decimal = 0
                Dim DISP_TWDV As Decimal = 0
                Dim DISP_BABC As Decimal = 0
                Dim IndexNo As Integer = 0
                Dim dtCA As DataTable = Nothing
                Dim dtCategory As DataTable = Nothing
                Dim dtTransfree As DataTable = Nothing

                For i As Integer = 0 To dt.Rows.Count - 1
                    dtCA = Nothing

                    If IsDBNull(dt.Rows(i)("CA_KEY")) = False Then
                        dtCA = ADO.Load_CA(dt.Rows(i)("CA_KEY"), Errorlog)
                    End If

                    If dtCA IsNot Nothing Then
                        CA_KEY = IIf(IsDBNull(dtCA.Rows(0)("CA_KEY")), 0, dtCA.Rows(0)("CA_KEY"))
                        CA_NAME = IIf(IsDBNull(dtCA.Rows(0)("CA_NAME")), "", dtCA.Rows(0)("CA_NAME"))
                        CA_SOURCENO = IIf(IsDBNull(dtCA.Rows(0)("CA_SOURCENO")), 0, dtCA.Rows(0)("CA_SOURCENO"))
                        CA_YA = IIf(IsDBNull(dtCA.Rows(0)("CA_YA")), 0, dtCA.Rows(0)("CA_YA"))
                        HP_CODE = IIf(IsDBNull(dtCA.Rows(0)("HP_CODE")), "", dtCA.Rows(0)("HP_CODE"))
                        CA_ASSET_NAME = IIf(IsDBNull(dtCA.Rows(0)("CA_ASSET")), "", dtCA.Rows(0)("CA_ASSET"))
                        ' CA_CATEGORY_CODE = IIf(IsDBNull(dtCA.Rows(0)("CA_CATEGORY_CODE")), "", dtCA.Rows(0)("CA_CATEGORY_CODE"))

                        dtCategory = ADO.LoadCategory(CStr(IIf(IsDBNull(dtCA.Rows(0)("CA_CATEGORY_CODE")), "", dtCA.Rows(0)("CA_CATEGORY_CODE"))), Errorlog)

                        If dtCategory IsNot Nothing Then
                            CA_CATEGORY_CODE = CStr(IIf(IsDBNull(dtCategory.Rows(0)("CA_CATEGORY")), "", dtCategory.Rows(0)("CA_CATEGORY")))

                        Else
                            CA_CATEGORY_CODE = CStr(IIf(IsDBNull(dt.Rows(0)("CA_CATEGORY_CODE")), "", dt.Rows(0)("CA_CATEGORY_CODE")))
                        End If

                        dtTransfree = ADO.LoadTransferee_Disposal(CA_KEY, Errorlog)
                        CA_MODE = IIf(IsDBNull(dtCA.Rows(0)("CA_MODE")), "OPN", dtCA.Rows(0)("CA_MODE"))
                        CA_QUALIFYING_COST = IIf(IsDBNull(dtCA.Rows(0)("CA_QUALIFYING_COST")), 0, dtCA.Rows(0)("CA_QUALIFYING_COST"))
                        If dtTransfree IsNot Nothing AndAlso dtTransfree.Rows.Count > 0 AndAlso dtTransfree.Rows(0)("CA_TRANSFEREE_NAME") <> "" Then
                            CA_TRANSFERROR_NAME = IIf(IsDBNull(dtTransfree.Rows(0)("CA_TRANSFEREE_NAME")), "", dtTransfree.Rows(0)("CA_TRANSFEREE_NAME")) & " [" & IIf(IsDBNull(dtTransfree.Rows(0)("CA_TAX_FILE_NO")), "", dtTransfree.Rows(0)("CA_TAX_FILE_NO")) & "]"
                        Else
                            CA_TRANSFERROR_NAME = ""
                        End If

                        CA_PURCHASE_YEAR = IIf(IsDBNull(dtCA.Rows(0)("CA_PURCHASE_YEAR")), 0, dtCA.Rows(0)("CA_PURCHASE_YEAR"))
                        CA_RATE_IA = IIf(IsDBNull(dtCA.Rows(0)("CA_RATE_IA")), 0, dtCA.Rows(0)("CA_RATE_IA"))
                        CA_RATE_AA = IIf(IsDBNull(dtCA.Rows(0)("CA_RATE_AA")), 0, dtCA.Rows(0)("CA_RATE_AA"))
                        CA_CAEEO = IIf(IsDBNull(dtCA.Rows(0)("CA_CAEEO")), False, dtCA.Rows(0)("CA_CAEEO"))
                        DISP_DEPRECIATION = CDec(IIf(IsDBNull(dt.Rows(i)("CA_ACCUMULATED")), 0, dt.Rows(i)("CA_ACCUMULATED")))

                        DISP_WDV = CA_QUALIFYING_COST - DISP_DEPRECIATION

                        DISP_KEY = IIf(IsDBNull(dt.Rows(0)("CA_DISP_KEY")), 0, dt.Rows(0)("CA_DISP_KEY"))
                        DISP_DISPOSAL_VALUE = CDec(IIf(IsDBNull(dt.Rows(i)("CA_DISP_SPROCEED")), 0, dt.Rows(i)("CA_DISP_SPROCEED")))
                        DISP_PNL = DISP_DISPOSAL_VALUE - DISP_WDV
                        DISP_TWDV = CDec(IIf(IsDBNull(dt.Rows(i)("CA_DISP_TWDV")), 0, dt.Rows(i)("CA_DISP_TWDV")))
                        DISP_BABC = CDec(IIf(IsDBNull(dt.Rows(i)("CA_DISP_BABC")), 0, dt.Rows(i)("CA_DISP_BABC")))

                        If ADO.Save_Disposal_Report_TEMP(ID, RefNo, YA, CA_KEY, DISP_KEY, CA_NAME, CA_SOURCENO, _
                                                                CA_YA, HP_CODE, CA_ASSET_NAME, CA_CATEGORY_CODE, CA_MODE, _
                                                                CA_TRANSFERROR_NAME, CA_PURCHASE_YEAR, CA_QUALIFYING_COST, CA_RATE_IA, _
                                                                CA_RATE_AA, CA_CAEEO, DISP_DEPRECIATION, DISP_WDV, DISP_DISPOSAL_VALUE, DISP_PNL, _
                                                                DISP_TWDV, DISP_BABC, Type, i) = False Then
                            Return False
                        End If
                    End If

                Next
            Else
                Return False
            End If
            ShowNoteFooter(1, RefNo, YA, Type, isTableOfContent, Errorlog)
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
            Return True
        End Try
    End Function
    Public Function Report_CA_ControlTransfer(ByVal RefNo As String, ByVal YA As String, ByRef ID As String,
                              ByVal RateFrom As Integer, ByVal RateTo As Integer, ByVal Category As String,
                              ByVal isTableContent As Boolean,
                              Optional ByRef Errorlog As ClsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = ADO.LoadCA_Search_Report_ControlTransfer(RefNo, "", RateFrom, RateTo, Category, Errorlog)

            If dt IsNot Nothing Then

                ID = "CA_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)

                While ADO.Validate_CA_TEMP_REPORTID(ID)
                    ID = "CA_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)
                End While


                For i As Integer = 0 To dt.Rows.Count - 1
                    If IsDBNull(dt.Rows(i)("CA_KEY")) = False Then
                        If mdlReport_CA.GenerateCA_Schudule(RefNo, YA, ID, CInt(dt.Rows(i)("CA_KEY")), Errorlog) = False Then
                            Return False
                        End If
                    End If
                Next


                Dim dtData As DataTable = ADO.Load_CAReport_Temp(ID, YA)

                If dtData IsNot Nothing Then
                    Dim CurrentYA As Integer = 0
                    Dim CA_KEY As Integer = 0
                    Dim CA_NAME As String = Nothing
                    Dim CA_SOURCENO As Integer = 0
                    Dim CA_YA As Integer = 0
                    Dim HP_CODE As String = Nothing
                    Dim CA_ASSET As String = Nothing
                    Dim CA_CATEGORY_CODE As String = Nothing
                    Dim CA_PURCHASE_AMOUNT As String = Nothing
                    Dim CA_TRANSFERROR_NAME As String = Nothing
                    Dim CA_TRANSFER_VAL As Decimal = 0
                    Dim CA_PURCHASE_YEAR As Integer = 0
                    Dim CA_QUALIFYING_COST As Decimal = 0
                    Dim CA_RATE_IA As Integer = 0
                    Dim CA_RATE_AA As Integer = 0
                    Dim QC_CF As Decimal = 0
                    Dim TWDV_BF As Decimal = 0
                    Dim CA_CAEEO As Boolean = False

                    Dim AA_0 As Decimal = 0
                    Dim AA_2 As Decimal = 0
                    Dim AA_3 As Decimal = 0
                    Dim AA_8 As Decimal = 0
                    Dim AA_10 As Decimal = 0
                    Dim AA_12 As Decimal = 0
                    Dim AA_14 As Decimal = 0
                    Dim AA_16 As Decimal = 0
                    Dim AA_20 As Decimal = 0
                    Dim AA_40 As Decimal = 0
                    Dim AA_50 As Decimal = 0
                    Dim AA_60 As Decimal = 0
                    Dim AA_80 As Decimal = 0
                    Dim AA_90 As Decimal = 0
                    Dim AA_100 As Decimal = 0

                    Dim TmpID As Integer = 0
                    Dim tmpDT As DataTable = Nothing
                    Dim dtCategory As DataTable = Nothing
                    For i As Integer = 0 To dtData.Rows.Count - 1
                        CA_CATEGORY_CODE = Nothing
                        AA_0 = 0
                        AA_2 = 0
                        AA_3 = 0
                        AA_8 = 0
                        AA_10 = 0
                        AA_12 = 0
                        AA_14 = 0
                        AA_16 = 0
                        AA_20 = 0
                        AA_40 = 0
                        AA_50 = 0
                        AA_60 = 0
                        AA_80 = 0
                        AA_90 = 0
                        AA_100 = 0

                        CurrentYA = IIf(IsDBNull(dtData.Rows(i)("YA")), 0, dtData.Rows(i)("YA"))
                        CA_KEY = IIf(IsDBNull(dtData.Rows(i)("CA_KEY")), 0, dtData.Rows(i)("CA_KEY"))

                        tmpDT = ADO.Load_CA(CA_KEY, Errorlog)

                        If tmpDT Is Nothing Then
                            Exit For
                        End If


                        CA_NAME = IIf(IsDBNull(dtData.Rows(i)("CA_NAME")), "", dtData.Rows(i)("CA_NAME"))
                        CA_SOURCENO = IIf(IsDBNull(dtData.Rows(i)("CA_SOURCENO")), 0, dtData.Rows(i)("CA_SOURCENO"))
                        CA_YA = IIf(IsDBNull(dtData.Rows(i)("CA_YA")), 0, dtData.Rows(i)("CA_YA"))
                        HP_CODE = IIf(IsDBNull(dtData.Rows(i)("HP_CODE")), "", dtData.Rows(i)("HP_CODE"))
                        CA_ASSET = IIf(IsDBNull(dtData.Rows(i)("CA_ASSET")), "", dtData.Rows(i)("CA_ASSET"))

                        'dtCategory = ADO.LoadCategory(CStr(IIf(IsDBNull(dt.Rows(0)("CA_CATEGORY_CODE")), "", dt.Rows(0)("CA_CATEGORY_CODE"))), Errorlog)

                        'If dtCategory IsNot Nothing Then
                        '    CA_CATEGORY_CODE = CStr(IIf(IsDBNull(dtCategory.Rows(0)("CA_CATEGORY")), "", dtCategory.Rows(0)("CA_CATEGORY")))

                        'Else
                        '    CA_CATEGORY_CODE = CStr(IIf(IsDBNull(dt.Rows(0)("CA_CATEGORY_CODE")), "", dt.Rows(0)("CA_CATEGORY_CODE")))
                        'End If
                        CA_CATEGORY_CODE = IIf(IsDBNull(dtData.Rows(i)("CA_CATEGORY_CODE")), "", dtData.Rows(i)("CA_CATEGORY_CODE"))

                        CA_PURCHASE_AMOUNT = IIf(IsDBNull(tmpDT.Rows(0)("CA_PURCHASE_AMOUNT")), 0, tmpDT.Rows(0)("CA_PURCHASE_AMOUNT"))

                        CA_TRANSFERROR_NAME = IIf(IsDBNull(dtData.Rows(i)("CA_TRANSFERROR_NAME")), "", dtData.Rows(i)("CA_TRANSFERROR_NAME"))
                        CA_PURCHASE_YEAR = IIf(IsDBNull(dtData.Rows(i)("CA_PURCHASE_YEAR")), 0, dtData.Rows(i)("CA_PURCHASE_YEAR"))
                        CA_QUALIFYING_COST = IIf(IsDBNull(dtData.Rows(i)("CA_QUALIFYING_COST")), 0, dtData.Rows(i)("CA_QUALIFYING_COST"))
                        CA_RATE_IA = IIf(IsDBNull(dtData.Rows(i)("CA_RATE_IA")), 0, dtData.Rows(i)("CA_RATE_IA"))
                        CA_RATE_AA = IIf(IsDBNull(dtData.Rows(i)("CA_RATE_AA")), 0, dtData.Rows(i)("CA_RATE_AA"))
                        QC_CF = IIf(IsDBNull(dtData.Rows(i)("QC_CF")), 0, dtData.Rows(i)("QC_CF"))
                        TWDV_BF = IIf(IsDBNull(dtData.Rows(i)("TWDV_BF")), 0, dtData.Rows(i)("TWDV_BF"))
                        CA_CAEEO = IIf(IsDBNull(tmpDT.Rows(0)("CA_CAEEO")), False, tmpDT.Rows(0)("CA_CAEEO"))
                        If IsDBNull(tmpDT.Rows(0)("CA_TRANSFER_VAL")) = False AndAlso IsNumeric(tmpDT.Rows(0)("CA_TRANSFER_VAL")) Then
                            CA_TRANSFER_VAL = CInt(tmpDT.Rows(0)("CA_TRANSFER_VAL"))
                        Else
                            CA_TRANSFER_VAL = 0
                        End If


                        Select Case IIf(IsDBNull(dtData.Rows(i)("CA_RATE_AA")), 0, dtData.Rows(i)("CA_RATE_AA"))
                            Case 2
                                AA_2 = QC_CF
                            Case 3
                                AA_3 = QC_CF
                            Case 8
                                AA_8 = QC_CF
                            Case 10
                                AA_10 = QC_CF
                            Case 12
                                AA_12 = QC_CF
                            Case 14
                                AA_14 = QC_CF
                            Case 16
                                AA_16 = QC_CF
                            Case 20
                                AA_20 = QC_CF
                            Case 40
                                AA_40 = QC_CF
                            Case 50
                                AA_50 = QC_CF
                            Case 60
                                AA_60 = QC_CF
                            Case 80
                                AA_80 = QC_CF
                            Case 90
                                AA_90 = QC_CF
                            Case 100
                                AA_100 = QC_CF
                            Case Else
                                AA_0 = QC_CF
                        End Select

                        If QC_CF > 0 Then
                            If ADO.Save_CA_ControlTranfer(ID, RefNo, CurrentYA, CA_KEY, CA_NAME, CA_SOURCENO, CA_YA, HP_CODE, CA_ASSET, CA_CATEGORY_CODE,
                                                             CA_PURCHASE_AMOUNT, CA_TRANSFERROR_NAME, CA_TRANSFER_VAL, CA_PURCHASE_YEAR, CA_QUALIFYING_COST, CA_RATE_IA, CA_RATE_AA,
                                                             CA_CAEEO, QC_CF, TWDV_BF, AA_0, AA_2, AA_3, AA_8, AA_10, AA_12, AA_14, AA_16, AA_20, AA_40, AA_50,
                                                             AA_60, AA_80, AA_90, AA_100, i, TmpID, Errorlog) = False Then
                                Return False
                            End If
                        End If

                    Next

                    ShowNoteFooter(0, RefNo, YA, 0, isTableContent, Errorlog)
                End If

            End If

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
            Return True
        End Try
    End Function
    Public Function Report_CA_Analysis(ByVal RefNo As String, ByVal YA As String, ByRef ID As String, _
                             ByVal RateFrom As Integer, ByVal RateTo As Integer, ByVal Category As String, _
                             Optional ByRef Errorlog As ClsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = ADO.LoadCA_Search_Report(RefNo, "", RateFrom, RateTo, Category, "ADD", YA, Errorlog)

            If dt IsNot Nothing Then

                ID = "CA_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)

                While ADO.Validate_CA_TEMP_REPORTID(ID)
                    ID = "CA_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)
                End While


                For y As Integer = 0 To dt.Rows.Count - 1
                    If IsDBNull(dt.Rows(y)("CA_KEY")) = False Then
                        If mdlReport_CA.GenerateCA_Schudule(RefNo, YA, ID, CInt(dt.Rows(y)("CA_KEY")), Errorlog) = False Then
                            Return False
                        End If
                    End If
                Next

                Dim dtData As DataTable = ADO.Load_CAReport_Temp(ID, YA)

                If dtData IsNot Nothing Then

                    Dim CA_KEY As Integer = 0
                    Dim CA_DESCRIPTION As String = Nothing
                    Dim CA_CATEGORY As String = Nothing
                    Dim CA_QC As Decimal = 0
                    Dim CA_REC As Decimal = 0
                    Dim CA_RAITA As Decimal = 0
                    Dim CA_RAITA_TITLE As String = Nothing
                    Dim CA_DEFERRED As Decimal = 0
                    Dim i As Integer = 0
                    Dim dtCA_Ana As DataTable = Nothing
                    Dim CA_ACCELERATED As Boolean = False
                    Dim CA_RATE_AA As Integer = 0
                    Dim AA_0 As Decimal = 0
                    Dim AA_2 As Decimal = 0
                    Dim AA_3 As Decimal = 0
                    Dim AA_8 As Decimal = 0
                    Dim AA_10 As Decimal = 0
                    Dim AA_12 As Decimal = 0
                    Dim AA_14 As Decimal = 0
                    Dim AA_16 As Decimal = 0
                    Dim AA_20 As Decimal = 0
                    Dim AA_40 As Decimal = 0
                    Dim AA_50 As Decimal = 0
                    Dim AA_60 As Decimal = 0
                    Dim AA_80 As Decimal = 0
                    Dim AA_90 As Decimal = 0
                    Dim AA_100 As Decimal = 0
                    Dim Total As Decimal = 0
                    Dim tmpTotal As Object = Nothing
                    Dim dtCategory As DataTable = Nothing
                    Dim Total_ALL As Decimal = 0
                    For Each rowx As DataRow In dtData.Rows

                        AA_0 = 0
                        AA_2 = 0
                        AA_3 = 0
                        AA_8 = 0
                        AA_10 = 0
                        AA_12 = 0
                        AA_14 = 0
                        AA_16 = 0
                        AA_20 = 0
                        AA_40 = 0
                        AA_50 = 0
                        AA_60 = 0
                        AA_80 = 0
                        AA_90 = 0
                        AA_100 = 0
                        Total = 0

                        CA_RATE_AA = IIf(IsDBNull(rowx("CA_RATE_AA")), 0, rowx("CA_RATE_AA"))
                        CA_KEY = IIf(IsDBNull(rowx("CA_KEY")), 0, rowx("CA_KEY"))
                        CA_DESCRIPTION = IIf(IsDBNull(rowx("CA_ASSET")), "", rowx("CA_ASSET"))
                        CA_CATEGORY = IIf(IsDBNull(rowx("CA_CATEGORY_CODE")), "", rowx("CA_CATEGORY_CODE"))
                        CA_QC = IIf(IsDBNull(rowx("CA_QUALIFYING_COST")), 0, rowx("CA_QUALIFYING_COST"))
                        CA_ACCELERATED = IIf(IsDBNull(rowx("CA_ACCELERATED")), 0, rowx("CA_ACCELERATED"))

                        dtCA_Ana = ADO.Load_CAReport_Analysis(CA_KEY, Errorlog)

                        If dtCA_Ana IsNot Nothing Then
                            If IsDBNull(dtCA_Ana.Rows(0)("CA_REC")) = False AndAlso CBool(dtCA_Ana.Rows(0)("CA_REC")) Then
                                CA_REC = IIf(IsDBNull(dtCA_Ana.Rows(0)("CA_PURCHASE_AMOUNT")), 0, dtCA_Ana.Rows(0)("CA_PURCHASE_AMOUNT"))
                            Else
                                CA_REC = 0
                            End If
                            If IsDBNull(dtCA_Ana.Rows(0)("CA_DEFERREDCLAIM")) = False AndAlso CBool(dtCA_Ana.Rows(0)("CA_DEFERREDCLAIM")) Then
                                CA_DEFERRED = CA_QC
                            Else
                                CA_DEFERRED = 0
                            End If
                            If IsDBNull(dtCA_Ana.Rows(0)("CA_INCENTIVE")) = False AndAlso dtCA_Ana.Rows(0)("CA_INCENTIVE") <> "" Then
                                CA_RAITA = CA_QC
                                CA_RAITA_TITLE = IIf(IsDBNull(dtCA_Ana.Rows(0)("CA_INCENTIVE")), 0, dtCA_Ana.Rows(0)("CA_INCENTIVE"))
                            Else
                                CA_RAITA_TITLE = ""
                                CA_RAITA = 0
                            End If
                        Else
                            CA_REC = 0
                            CA_RAITA = 0
                            CA_DEFERRED = 0
                        End If

                        Select Case CA_RATE_AA
                            Case 2
                                AA_2 = CA_QC
                            Case 3
                                AA_3 = CA_QC
                            Case 8
                                AA_8 = CA_QC
                            Case 10
                                AA_10 = CA_QC
                            Case 12
                                AA_12 = CA_QC
                            Case 14
                                AA_14 = CA_QC
                            Case 16
                                AA_16 = CA_QC
                            Case 20
                                AA_20 = CA_QC
                            Case 40
                                AA_40 = CA_QC
                            Case 50
                                AA_50 = CA_QC
                            Case 60
                                AA_60 = CA_QC
                            Case 80
                                AA_80 = CA_QC
                            Case 90
                                AA_90 = CA_QC
                            Case 100
                                AA_100 = CA_QC
                            Case Else
                                AA_0 = CA_QC
                        End Select
                        tmpTotal = dtData.Compute("SUM(CA_QUALIFYING_COST)", "CA_CATEGORY_CODE ='" & CA_CATEGORY & "' AND CA_REC=0")
                        'Application.DoEvents()
                        'tmpTotal += dtData.Compute("SUM(CA_PURCHASE_AMOUNT_CA)", "CA_CATEGORY_CODE ='" & CA_CATEGORY & "' AND CA_REC=1")
                        Dim result() As DataRow = dtData.Select("CA_CATEGORY_CODE ='" & CA_CATEGORY & "' AND CA_REC=1")

                        If tmpTotal Is Nothing OrElse IsNumeric(tmpTotal) = False Then
                            tmpTotal = 0
                        End If
                        If result IsNot Nothing AndAlso result.Count > 0 Then
                            For Each rowxResult As DataRow In result
                                If IsDBNull(rowxResult("CA_REC")) = False AndAlso IsDBNull(rowxResult("CA_PURCHASE_AMOUNT_CA")) = False Then
                                    tmpTotal += CDec(rowxResult("CA_PURCHASE_AMOUNT_CA"))
                                End If
                            Next
                        End If

                        Total_ALL = ADO.Load_CAReport_Analysis_Total_Temp(ID, YA)
                        If tmpTotal IsNot Nothing AndAlso IsNumeric(tmpTotal) Then
                            Total = CDec(tmpTotal)
                        Else
                            Total = 0
                        End If

                        If CA_REC <> 0 Then
                            CA_QC = CA_REC
                        End If
                        i += 1
                        If CA_CATEGORY <> "Capital Expenditure Expensed Off in Income Statement" Then
                            CA_CATEGORY = CA_CATEGORY.Substring(1, CA_CATEGORY.ToString.Length - 1)
                        End If

                        CA_CATEGORY &= " - RM" & Total.ToString("N0")
                        If ADO.Save_CA_Analysis(ID, RefNo, CInt(YA), CA_KEY, CA_DESCRIPTION, CA_CATEGORY, CA_QC, CA_REC, CA_DEFERRED, CA_RAITA, CA_RAITA_TITLE, AA_0, AA_2, AA_3, AA_8, AA_10, AA_12, AA_14, AA_16, AA_20, AA_40, AA_50, _
                                                            AA_60, AA_80, AA_90, AA_100, Total, i, 0, Total_ALL, CA_ACCELERATED, Errorlog) = False Then
                            Return False
                        End If
                    Next

                End If
            End If

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
            Return True
        End Try
    End Function
    Public Function Report_CA_SummaryQE(ByVal RefNo As String, ByVal YA As String, ByRef ID As String, _
                             ByVal RateFrom As Integer, ByVal RateTo As Integer, ByVal Category As String, _
                             Optional ByRef Errorlog As ClsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = ADO.LoadCA_Search_Report(RefNo, "", RateFrom, RateTo, Category, "ADD", YA, Errorlog)

            If dt IsNot Nothing Then

                ID = "CA_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)

                While ADO.Validate_CA_TEMP_REPORTID(ID)
                    ID = "CA_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)
                End While


                For y As Integer = 0 To dt.Rows.Count - 1
                    If IsDBNull(dt.Rows(y)("CA_KEY")) = False Then
                        If mdlReport_CA.GenerateCA_Schudule(RefNo, YA, ID, CInt(dt.Rows(y)("CA_KEY")), Errorlog) = False Then
                            Return False
                        End If
                    End If
                Next

                Dim dtData As DataTable = ADO.Load_CAReport_SummaryQEStep1_Temp(ID, YA)

                Dim CA_DESCRIPTION As String = Nothing
                Dim CA_CATEGORY As String = Nothing
                Dim CA_SOURCENO As Integer = 0
                Dim CA_AMOUNT As Decimal = 0
                Dim CA_RATE_AA As Integer = 0
                Dim AA_0 As Decimal = 0
                Dim AA_2 As Decimal = 0
                Dim AA_3 As Decimal = 0
                Dim AA_8 As Decimal = 0
                Dim AA_10 As Decimal = 0
                Dim AA_12 As Decimal = 0
                Dim AA_14 As Decimal = 0
                Dim AA_16 As Decimal = 0
                Dim AA_20 As Decimal = 0
                Dim AA_40 As Decimal = 0
                Dim AA_50 As Decimal = 0
                Dim AA_60 As Decimal = 0
                Dim AA_80 As Decimal = 0
                Dim AA_90 As Decimal = 0
                Dim AA_100 As Decimal = 0
                Dim dtCategory As DataTable = Nothing
                Dim tmpTotal As Object = Nothing
                Dim tmpCategory As String = ""
                Dim TmpID As Integer = 0
                Dim i As Integer = 0
                Dim tmpObj As DataRow() = Nothing
                If dtData IsNot Nothing Then

                    For Each rowx As DataRow In dtData.Rows
                        tmpTotal = Nothing


                        If tmpCategory <> IIf(IsDBNull(rowx("CA_CATEGORY_CODE")), "", rowx("CA_CATEGORY_CODE")) Then
                            AA_0 = 0
                            AA_2 = 0
                            AA_3 = 0
                            AA_8 = 0
                            AA_10 = 0
                            AA_12 = 0
                            AA_14 = 0
                            AA_16 = 0
                            AA_20 = 0
                            AA_40 = 0
                            AA_50 = 0
                            AA_60 = 0
                            AA_80 = 0
                            AA_90 = 0
                            AA_100 = 0

                            tmpCategory = IIf(IsDBNull(rowx("CA_CATEGORY_CODE")), "", rowx("CA_CATEGORY_CODE"))
                            CA_DESCRIPTION = tmpCategory
                            tmpTotal = dtData.Compute("SUM(sumx)", "CA_CATEGORY_CODE ='" & tmpCategory & "'")
                            If tmpTotal IsNot Nothing AndAlso IsNumeric(tmpTotal) Then
                                CA_AMOUNT = CDec(tmpTotal)
                            Else
                                CA_AMOUNT = 0
                            End If
                            CA_CATEGORY = ""


                            tmpObj = dtData.Select("CA_CATEGORY_CODE ='" & tmpCategory & "'")

                            If tmpObj IsNot Nothing AndAlso tmpObj.Length > 0 Then
                                For Each tmpRow As DataRow In tmpObj


                                    CA_RATE_AA = IIf(IsDBNull(tmpRow("CA_RATE_AA")), 0, tmpRow("CA_RATE_AA"))
                                    tmpTotal = dtData.Compute("SUM(sumx)", "CA_CATEGORY_CODE ='" & tmpCategory & "' AND CA_RATE_AA =" & CA_RATE_AA)

                                    Select Case CA_RATE_AA
                                        Case 2
                                            If tmpTotal IsNot Nothing AndAlso IsNumeric(tmpTotal) Then
                                                AA_2 = CDec(tmpTotal)
                                            Else
                                                AA_2 = 0
                                            End If

                                        Case 3
                                            If tmpTotal IsNot Nothing AndAlso IsNumeric(tmpTotal) Then
                                                AA_3 = CDec(tmpTotal)
                                            Else
                                                AA_3 = 0
                                            End If
                                        Case 8
                                            If tmpTotal IsNot Nothing AndAlso IsNumeric(tmpTotal) Then
                                                AA_8 = CDec(tmpTotal)
                                            Else
                                                AA_8 = 0
                                            End If

                                        Case 10
                                            If tmpTotal IsNot Nothing AndAlso IsNumeric(tmpTotal) Then
                                                AA_10 = CDec(tmpTotal)
                                            Else
                                                AA_10 = 0
                                            End If

                                        Case 12
                                            If tmpTotal IsNot Nothing AndAlso IsNumeric(tmpTotal) Then
                                                AA_12 = CDec(tmpTotal)
                                            Else
                                                AA_12 = 0
                                            End If

                                        Case 14
                                            If tmpTotal IsNot Nothing AndAlso IsNumeric(tmpTotal) Then
                                                AA_14 = CDec(tmpTotal)
                                            Else
                                                AA_14 = 0
                                            End If

                                        Case 16
                                            If tmpTotal IsNot Nothing AndAlso IsNumeric(tmpTotal) Then
                                                AA_16 = CDec(tmpTotal)
                                            Else
                                                AA_16 = 0
                                            End If

                                        Case 20
                                            If tmpTotal IsNot Nothing AndAlso IsNumeric(tmpTotal) Then
                                                AA_20 = CDec(tmpTotal)
                                            Else
                                                AA_20 = 0
                                            End If

                                        Case 40
                                            If tmpTotal IsNot Nothing AndAlso IsNumeric(tmpTotal) Then
                                                AA_40 = CDec(tmpTotal)
                                            Else
                                                AA_40 = 0
                                            End If

                                        Case 50
                                            If tmpTotal IsNot Nothing AndAlso IsNumeric(tmpTotal) Then
                                                AA_50 = CDec(tmpTotal)
                                            Else
                                                AA_50 = 0
                                            End If

                                        Case 60
                                            If tmpTotal IsNot Nothing AndAlso IsNumeric(tmpTotal) Then
                                                AA_60 = CDec(tmpTotal)
                                            Else
                                                AA_60 = 0
                                            End If

                                        Case 80
                                            If tmpTotal IsNot Nothing AndAlso IsNumeric(tmpTotal) Then
                                                AA_80 = CDec(tmpTotal)
                                            Else
                                                AA_80 = 0
                                            End If

                                        Case 90
                                            If tmpTotal IsNot Nothing AndAlso IsNumeric(tmpTotal) Then
                                                AA_90 = CDec(tmpTotal)
                                            Else
                                                AA_90 = 0
                                            End If

                                        Case 100
                                            If tmpTotal IsNot Nothing AndAlso IsNumeric(tmpTotal) Then
                                                AA_100 = CDec(tmpTotal)
                                            Else
                                                AA_100 = 0
                                            End If

                                        Case Else
                                            If tmpTotal IsNot Nothing AndAlso IsNumeric(tmpTotal) Then
                                                AA_0 = CDec(tmpTotal)
                                            Else
                                                AA_0 = 0
                                            End If

                                    End Select
                                Next
                            End If

                            i += 1
                            If ADO.Save_CA_Summary_QE(ID, RefNo, CInt(YA), CA_DESCRIPTION, CA_CATEGORY, AA_0, AA_2, AA_3, AA_8, AA_10, AA_12, AA_14, AA_16, AA_20, AA_40, AA_50, _
                                                            AA_60, AA_80, AA_90, AA_100, CA_AMOUNT, i, 0, TmpID, Errorlog) = False Then
                                Return False
                            End If

                        End If
                    Next

                End If

                dtData = Nothing
                dtData = ADO.Load_CAReport_SummaryQEStep2_Temp(ID, YA)

                If dtData IsNot Nothing Then

                    For Each rowx As DataRow In dtData.Rows
                        AA_0 = 0
                        AA_2 = 0
                        AA_3 = 0
                        AA_8 = 0
                        AA_10 = 0
                        AA_12 = 0
                        AA_14 = 0
                        AA_16 = 0
                        AA_20 = 0
                        AA_40 = 0
                        AA_50 = 0
                        AA_60 = 0
                        AA_80 = 0
                        AA_90 = 0
                        AA_100 = 0

                        CA_DESCRIPTION = IIf(IsDBNull(rowx("CA_ASSET")), "", rowx("CA_ASSET")) & " - " & IIf(IsDBNull(rowx("HP_CODE")), "", rowx("HP_CODE"))
                        CA_AMOUNT = IIf(IsDBNull(rowx("CA_QUALIFYING_COST")), 0, rowx("CA_QUALIFYING_COST"))
                        CA_CATEGORY = "Motor Vehicles under Hire Purchase"
                        CA_RATE_AA = IIf(IsDBNull(rowx("CA_RATE_AA")), 0, rowx("CA_RATE_AA"))

                        Select Case CA_RATE_AA
                            Case 2
                                AA_2 = CA_AMOUNT
                            Case 3
                                AA_3 = CA_AMOUNT
                            Case 8
                                AA_8 = CA_AMOUNT
                            Case 10
                                AA_10 = CA_AMOUNT
                            Case 12
                                AA_12 = CA_AMOUNT
                            Case 14
                                AA_14 = CA_AMOUNT
                            Case 16
                                AA_16 = CA_AMOUNT
                            Case 20
                                AA_20 = CA_AMOUNT
                            Case 40
                                AA_40 = CA_AMOUNT
                            Case 50
                                AA_50 = CA_AMOUNT
                            Case 60
                                AA_60 = CA_AMOUNT
                            Case 80
                                AA_80 = CA_AMOUNT
                            Case 90
                                AA_90 = CA_AMOUNT
                            Case 100
                                AA_100 = CA_AMOUNT
                            Case Else
                                AA_0 = CA_AMOUNT
                        End Select

                        i += 1
                        If ADO.Save_CA_Summary_QE(ID, RefNo, CInt(YA), CA_DESCRIPTION, CA_CATEGORY, AA_0, AA_2, AA_3, AA_8, AA_10, AA_12, AA_14, AA_16, AA_20, AA_40, AA_50, _
                                                           AA_60, AA_80, AA_90, AA_100, CA_AMOUNT, i, 1, TmpID, Errorlog) = False Then
                            Return False
                        End If

                    Next
                End If

                dtData = Nothing
                dtData = ADO.Load_CAReport_SummaryQEStep3_Temp(ID, YA)

                If dtData IsNot Nothing Then

                    For Each rowx As DataRow In dtData.Rows
                        AA_0 = 0
                        AA_2 = 0
                        AA_3 = 0
                        AA_8 = 0
                        AA_10 = 0
                        AA_12 = 0
                        AA_14 = 0
                        AA_16 = 0
                        AA_20 = 0
                        AA_40 = 0
                        AA_50 = 0
                        AA_60 = 0
                        AA_80 = 0
                        AA_90 = 0
                        AA_100 = 0

                        CA_DESCRIPTION = IIf(IsDBNull(rowx("CA_ASSET")), "", rowx("CA_ASSET")) ' & " - " & IIf(IsDBNull(rowx("HP_CODE")), "", rowx("HP_CODE"))
                        CA_AMOUNT = IIf(IsDBNull(rowx("CA_QUALIFYING_COST")), 0, rowx("CA_QUALIFYING_COST"))
                        CA_CATEGORY = "Capital Expenditure Expensed off"
                        CA_RATE_AA = IIf(IsDBNull(rowx("CA_RATE_AA")), 0, rowx("CA_RATE_AA"))

                        Select Case CA_RATE_AA
                            Case 2
                                AA_2 = CA_AMOUNT
                            Case 3
                                AA_3 = CA_AMOUNT
                            Case 8
                                AA_8 = CA_AMOUNT
                            Case 10
                                AA_10 = CA_AMOUNT
                            Case 12
                                AA_12 = CA_AMOUNT
                            Case 14
                                AA_14 = CA_AMOUNT
                            Case 16
                                AA_16 = CA_AMOUNT
                            Case 20
                                AA_20 = CA_AMOUNT
                            Case 40
                                AA_40 = CA_AMOUNT
                            Case 50
                                AA_50 = CA_AMOUNT
                            Case 60
                                AA_60 = CA_AMOUNT
                            Case 80
                                AA_80 = CA_AMOUNT
                            Case 90
                                AA_90 = CA_AMOUNT
                            Case 100
                                AA_100 = CA_AMOUNT
                            Case Else
                                AA_0 = CA_AMOUNT
                        End Select

                        i += 1
                        If ADO.Save_CA_Summary_QE(ID, RefNo, CInt(YA), CA_DESCRIPTION, CA_CATEGORY, AA_0, AA_2, AA_3, AA_8, AA_10, AA_12, AA_14, AA_16, AA_20, AA_40, AA_50, _
                                                           AA_60, AA_80, AA_90, AA_100, CA_AMOUNT, i, 2, TmpID, Errorlog) = False Then
                            Return False
                        End If

                    Next
                End If

            End If

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
            Return True
        End Try
    End Function
    Public Function Report_CA_FAConciliation(ByVal RefNo As String, ByVal YA As String, ByRef ID As String, _
                              ByVal RateFrom As Integer, ByVal RateTo As Integer, ByVal Category As String, _
                              Optional ByRef Errorlog As ClsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = ADO.LoadCA_Search_Report(RefNo, "", RateFrom, RateTo, Category, "", "", Errorlog)

            If dt IsNot Nothing Then

                ID = "CA_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)

                While ADO.Validate_CA__FA_TEMP_REPORTID(ID)
                    ID = "CA_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)
                End While


                For i As Integer = 0 To dt.Rows.Count - 1
                    If IsDBNull(dt.Rows(i)("CA_KEY")) = False Then
                        If mdlReport_CA.GenerateCA_FixedAssetREconliliation_Schudule(RefNo, YA, ID, CInt(dt.Rows(i)("CA_KEY")), Errorlog) = False Then
                            Return False
                        End If
                    End If
                Next

            End If

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
    Public Function Report_CA_Summary(ByVal RefNo As String, ByVal YA As String, ByRef ID As String, _
                              ByVal RateFrom As Integer, ByVal RateTo As Integer, ByVal Category As String, ByVal Type As mdlEnum.CAReport_Type, _
                              Optional ByRef Errorlog As ClsError = Nothing) As Boolean
        Try
            Dim dtCA As DataTable = ADO.LoadCA_Search_Report(RefNo, "", RateFrom, RateTo, Category, "", "", Errorlog)

            If dtCA IsNot Nothing Then

                ID = "CA_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)

                While ADO.Validate_CA_TEMP_REPORTID(ID)
                    ID = "CA_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)
                End While


                For i As Integer = 0 To dtCA.Rows.Count - 1
                    If IsDBNull(dtCA.Rows(i)("CA_KEY")) = False Then
                        If mdlReport_CA.GenerateCA_Schudule(RefNo, YA, ID, CInt(dtCA.Rows(i)("CA_KEY")), Errorlog) = False Then
                            Return False
                        End If
                    End If
                Next

                Application.DoEvents()
                Dim dt As DataTable = Nothing
                Select Case Type
                    Case CAReport_Type.CA_REPORT_SUMMARY_BYRATE
                        dt = ADO.Load_CAReportSummary_Temp_ByRate(ID, CInt(YA), Errorlog)
                    Case CAReport_Type.CA_REPORT_SUMMARY_BYCATEGORY
                        dt = ADO.Load_CAReportSummary_Temp_ByCategory(ID, CInt(YA), Errorlog)
                End Select
                'ADO.Load_CAReportSummary_Temp(ID, CInt(YA), Errorlog)

                If dt IsNot Nothing Then

                    Dim CurrentYA As Integer = 0
                    Dim CA_KEY As Integer = 0
                    Dim CA_NAME As String = Nothing
                    Dim CA_TRANSFERROR_NAME As String = Nothing
                    Dim CA_ASSET As String = Nothing
                    Dim CA_CATEGORY_CODE As String = Nothing
                    Dim CA_SOURCENO As Integer = 0
                    Dim CA_YA As Integer = 0
                    Dim HP_CODE As String = Nothing
                    Dim CA_MODE As String = Nothing
                    Dim CA_PURCHASE_YEAR As Integer = 0
                    Dim CA_QUALIFYING_COST As Decimal = 0
                    Dim CA_RATE_IA As Integer = 0
                    Dim CA_RATE_AA As Integer = 0
                    Dim QC_BF As Decimal = 0
                    Dim QC_ADD As Decimal = 0
                    Dim QC_DISP As Decimal = 0
                    Dim QC_CF As Decimal = 0
                    Dim TWDV_BF As Decimal = 0
                    Dim TWDV_ADD As Decimal = 0
                    Dim TWDV_DISP As Decimal = 0
                    Dim TWDV_IA As Decimal = 0
                    Dim TWDV_AA As Decimal = 0
                    Dim TWDV_CF As Decimal = 0
                    Dim TWDV_TOTAL As Decimal = 0
                    Dim IndexNo As Integer = 0
                    Dim CA_ACCELERATED As Boolean = False
                    Dim dtCategory As DataTable = Nothing
                    For i As Integer = 0 To dt.Rows.Count - 1


                        CA_KEY = 0
                        CA_NAME = CStr(IIf(IsDBNull(dt.Rows(i)("CA_NAME")), "", dt.Rows(i)("CA_NAME")))
                        CA_ASSET = ""

                        Select Case Type
                            Case CAReport_Type.CA_REPORT_SUMMARY_BYRATE
                                CurrentYA = 0
                                CA_CATEGORY_CODE = ""
                                CA_RATE_IA = CInt(IIf(IsDBNull(dt.Rows(i)("CA_RATE_IA")), 0, dt.Rows(i)("CA_RATE_IA")))
                                CA_RATE_AA = CInt(IIf(IsDBNull(dt.Rows(i)("CA_RATE_AA")), 0, dt.Rows(i)("CA_RATE_AA")))
                            Case CAReport_Type.CA_REPORT_SUMMARY_BYCATEGORY
                                CurrentYA = 0
                                dtCategory = ADO.LoadCategory(CStr(IIf(IsDBNull(dt.Rows(i)("CA_CATEGORY_CODE")), "", dt.Rows(i)("CA_CATEGORY_CODE"))), Errorlog)

                                If dtCategory IsNot Nothing Then
                                    CA_CATEGORY_CODE = CStr(IIf(IsDBNull(dtCategory.Rows(0)("CA_CATEGORY")), "", dtCategory.Rows(0)("CA_CATEGORY")))

                                Else
                                    CA_CATEGORY_CODE = CStr(IIf(IsDBNull(dt.Rows(i)("CA_CATEGORY_CODE")), "", dt.Rows(i)("CA_CATEGORY_CODE")))
                                End If
                                'CA_CATEGORY_CODE = CStr(IIf(IsDBNull(dt.Rows(i)("CA_CATEGORY_CODE")), "", dt.Rows(i)("CA_CATEGORY_CODE")))
                                CA_RATE_IA = CInt(IIf(IsDBNull(dt.Rows(i)("CA_RATE_IA")), 0, dt.Rows(i)("CA_RATE_IA")))
                                CA_RATE_AA = CInt(IIf(IsDBNull(dt.Rows(i)("CA_RATE_AA")), 0, dt.Rows(i)("CA_RATE_AA")))
                            Case Else
                                CurrentYA = CInt(IIf(IsDBNull(dt.Rows(i)("YA")), 0, dt.Rows(i)("YA")))
                                CA_CATEGORY_CODE = ""
                                CA_RATE_IA = 0
                                CA_RATE_AA = 0
                        End Select

                        If CA_CATEGORY_CODE.ToUpper <> "Capital Expenditure Expensed Off in Income Statement" Then
                            CA_CATEGORY_CODE = " " & CA_CATEGORY_CODE
                        End If

                        CA_SOURCENO = 0
                        CA_YA = 0
                        HP_CODE = ""
                        CA_MODE = ""
                        CA_PURCHASE_YEAR = CInt(IIf(IsDBNull(dt.Rows(i)("CA_PURCHASE_YEAR")), 0, dt.Rows(i)("CA_PURCHASE_YEAR")))
                        CA_TRANSFERROR_NAME = CStr(IIf(IsDBNull(dt.Rows(i)("CA_TRANSFERROR_NAME")), "", dt.Rows(i)("CA_TRANSFERROR_NAME")))
                        CA_QUALIFYING_COST = 0

                        QC_BF = CDec(IIf(IsDBNull(dt.Rows(i)("QC_BF")), 0, dt.Rows(i)("QC_BF")))
                        QC_ADD = CDec(IIf(IsDBNull(dt.Rows(i)("QC_ADD")), 0, dt.Rows(i)("QC_ADD")))
                        QC_DISP = CDec(IIf(IsDBNull(dt.Rows(i)("QC_DISP")), 0, dt.Rows(i)("QC_DISP")))
                        QC_CF = CDec(IIf(IsDBNull(dt.Rows(i)("QC_CF")), 0, dt.Rows(i)("QC_CF")))
                        TWDV_BF = CDec(IIf(IsDBNull(dt.Rows(i)("TWDV_BF")), 0, dt.Rows(i)("TWDV_BF")))
                        TWDV_ADD = CDec(IIf(IsDBNull(dt.Rows(i)("TWDV_ADD")), 0, dt.Rows(i)("TWDV_ADD")))
                        TWDV_DISP = CDec(IIf(IsDBNull(dt.Rows(i)("TWDV_DISP")), 0, dt.Rows(i)("TWDV_DISP")))
                        TWDV_IA = CDec(IIf(IsDBNull(dt.Rows(i)("TWDV_AI")), 0, dt.Rows(i)("TWDV_AI")))
                        TWDV_AA = CDec(IIf(IsDBNull(dt.Rows(i)("TWDV_AA")), 0, dt.Rows(i)("TWDV_AA")))
                        TWDV_AA = CDec(IIf(IsDBNull(dt.Rows(i)("TWDV_AA")), 0, dt.Rows(i)("TWDV_AA")))
                        TWDV_TOTAL = CDec(IIf(IsDBNull(dt.Rows(i)("TWDV_TOTAL")), 0, dt.Rows(i)("TWDV_TOTAL")))
                        TWDV_CF = CDec(IIf(IsDBNull(dt.Rows(i)("TWDV_CF")), 0, dt.Rows(i)("TWDV_CF")))
                        IndexNo = i

                        If ADO.Save_CA_TEMP_REPORT(RefNo, CurrentYA, CA_KEY, CA_NAME, CA_ASSET, CA_CATEGORY_CODE, _
                                              CA_SOURCENO, CA_YA, HP_CODE, CA_MODE, CA_TRANSFERROR_NAME, CA_PURCHASE_YEAR, CA_QUALIFYING_COST, _
                                              CA_RATE_IA, CA_RATE_AA, QC_BF, QC_ADD, QC_DISP, QC_CF, TWDV_BF, TWDV_ADD, TWDV_DISP, _
                                              TWDV_IA, TWDV_AA, TWDV_TOTAL, TWDV_CF, IndexNo, CA_ACCELERATED, ADO.CAReport_TableType.CA_REPORT_SUMMARY_TEMP, ID, Errorlog) = False Then
                            Return False
                        End If
                    Next

                End If

            End If



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
    Public Function GenerateHP_Schudule(ByVal RefNo As String, ByVal YA As String, ByVal ID As String, ByVal HP_KEY As Integer, Optional ByRef Errorlog As ClsError = Nothing) As Boolean
        Try
            Dim BF_PRINCIPAL As Decimal = 0
            Dim BF_INTEREST As Decimal = 0
            Dim CURR_PRINCIPAL As Decimal = 0
            Dim CURR_INTEREST As Decimal = 0
            Dim CF_PRINCIPAL As Decimal = 0
            Dim CF_INTEREST As Decimal = 0

            Dim ClaimInUsePercent As Integer = 0
            Dim CurrentYA As Integer = 0

            Dim HP_PRINCIPAL As Decimal = 0
            Dim HP_INTEREST_RATE As Integer = 0
            Dim HP_INTEREST As Decimal = 0
            Dim HP_TOTAL As Decimal = 0

            Dim CA_YA As Integer = 0
            Dim CA_SOURCENO As Integer = 0
            Dim CA_PURCHASE_YEAR As Integer = 0
            Dim CA_NAME As String = Nothing
            Dim HP_CODE As String = Nothing
            Dim CA_ASSET As String = Nothing
            Dim CA_CATEGORY As String = Nothing
            Dim dtDisposal As DataTable = Nothing
            Dim DISP_AMOUNT As Decimal = 0
            Dim IndexNo As Integer = 0
            Dim dt As DataTable = ADO.Load_HP(HP_KEY)
            Dim dtCategory As DataTable = Nothing
            '   Dim dtCASchedule As DataTable = Nothing

            If dt Is Nothing Then
                If Errorlog Is Nothing Then
                    Errorlog = New ClsError
                End If
                With Errorlog
                    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                    .ErrorCode = "P10001"
                    .ErrorDateTime = Now
                    .ErrorMessage = "No data found for CA = " & HP_KEY
                End With
                Return False
            End If


            With dt.Rows(0)

                CA_NAME = CStr(IIf(IsDBNull(dt.Rows(0)("HP_NAME")), "", dt.Rows(0)("HP_NAME")))
                CA_SOURCENO = CInt(IIf(IsDBNull(dt.Rows(0)("HP_SOURCENO")), 0, dt.Rows(0)("HP_SOURCENO")))

                HP_CODE = CStr(IIf(IsDBNull(dt.Rows(0)("HP_CODE")), "", dt.Rows(0)("HP_CODE")))
                CA_ASSET = CStr(IIf(IsDBNull(dt.Rows(0)("HP_ASSET")), "", dt.Rows(0)("HP_ASSET"))) & " - " & CStr(IIf(IsDBNull(dt.Rows(0)("HP_CODE")), "", dt.Rows(0)("HP_CODE")))

                dtCategory = ADO.LoadCategory(CStr(IIf(IsDBNull(dt.Rows(0)("HP_CATEGORY_CODE")), "", dt.Rows(0)("HP_CATEGORY_CODE"))), Errorlog)

                If dtCategory IsNot Nothing Then
                    CA_CATEGORY = CStr(IIf(IsDBNull(dtCategory.Rows(0)("CA_CATEGORY")), "", dtCategory.Rows(0)("CA_CATEGORY")))

                Else
                    CA_CATEGORY = CStr(IIf(IsDBNull(dt.Rows(0)("HP_CATEGORY_CODE")), "", dt.Rows(0)("HP_CATEGORY_CODE")))
                End If
                If CA_CATEGORY.ToUpper <> "Capital Expenditure Expensed Off in Income Statement" Then
                    '  CA_CATEGORY = " " & CA_CATEGORY disable 09112018

                End If

                CA_PURCHASE_YEAR = CInt(IIf(IsDBNull(dt.Rows(0)("HP_YA")), 0, dt.Rows(0)("HP_YA")))

                HP_PRINCIPAL = CDec(IIf(IsDBNull(dt.Rows(0)("HP_PRINCIPAL")), 0, dt.Rows(0)("HP_PRINCIPAL")))
                HP_INTEREST_RATE = CInt(IIf(IsDBNull(dt.Rows(0)("HP_INTEREST_RATE")), 0, dt.Rows(0)("HP_INTEREST_RATE")))
                HP_INTEREST = CDec(IIf(IsDBNull(dt.Rows(0)("HP_INTEREST")), 0, dt.Rows(0)("HP_INTEREST")))
                HP_TOTAL = CDec(IIf(IsDBNull(dt.Rows(0)("HP_TOTAL")), 0, dt.Rows(0)("HP_TOTAL")))

              

                If IsDBNull(dt.Rows(0)("HP_YA")) = False AndAlso IsNumeric(dt.Rows(0)("HP_YA")) = True Then
                    CA_YA = CInt(dt.Rows(0)("HP_YA"))
                Else
                    CA_YA = 0
                End If

            End With

            Dim dtYear As DataTable = Nothing

            CurrentYA = CA_YA

            dtYear = ADO.Load_HP_YEARLY_ByYear(HP_KEY, CStr(CurrentYA))

            BF_PRINCIPAL = HP_PRINCIPAL
            BF_INTEREST = HP_INTEREST

            If dtYear IsNot Nothing Then
                CURR_INTEREST = CDec(IIf(IsDBNull(dtYear.Rows(0)("HPD_INTEREST")), 0, dtYear.Rows(0)("HPD_INTEREST")))
                CURR_PRINCIPAL = CDec(IIf(IsDBNull(dtYear.Rows(0)("HPD_PRINCIPAL")), 0, dtYear.Rows(0)("HPD_PRINCIPAL")))
            Else
                CURR_INTEREST = 0
                CURR_PRINCIPAL = 0
            End If


            CF_PRINCIPAL = BF_PRINCIPAL - CURR_PRINCIPAL
            CF_INTEREST = BF_INTEREST - CURR_INTEREST
            IndexNo = 0

            If ADO.Save_HP_TEMP_REPORT(RefNo, CurrentYA, HP_KEY, CA_NAME, CA_SOURCENO, CA_YA, HP_CODE, CA_ASSET, CA_CATEGORY, CA_PURCHASE_YEAR, _
                                              HP_PRINCIPAL, HP_INTEREST_RATE, HP_INTEREST, HP_TOTAL, BF_PRINCIPAL, BF_INTEREST, _
                                              CURR_PRINCIPAL, CURR_INTEREST, CF_PRINCIPAL, CF_INTEREST, IndexNo, ID, Errorlog) = False Then
                Return False
            End If
            '=========NEXT YEAR===================================
            Dim CurrLoop As Integer = 0
            While CF_PRINCIPAL > 0 And CurrLoop <= MaxYearForCA
                IndexNo += 1
                CurrentYA += 1

                BF_PRINCIPAL = CF_PRINCIPAL
                BF_INTEREST = CF_INTEREST

                dtYear = ADO.Load_HP_YEARLY_ByYear(HP_KEY, CStr(CurrentYA))

                If dtYear IsNot Nothing Then
                    CURR_INTEREST = CDec(IIf(IsDBNull(dtYear.Rows(0)("HPD_INTEREST")), 0, dtYear.Rows(0)("HPD_INTEREST")))
                    CURR_PRINCIPAL = CDec(IIf(IsDBNull(dtYear.Rows(0)("HPD_PRINCIPAL")), 0, dtYear.Rows(0)("HPD_PRINCIPAL")))
                Else
                    CURR_INTEREST = 0
                    CURR_PRINCIPAL = 0
                End If

                CF_PRINCIPAL = BF_PRINCIPAL - CURR_PRINCIPAL
                CF_INTEREST = BF_INTEREST - CURR_INTEREST

                If ADO.Save_HP_TEMP_REPORT(RefNo, CurrentYA, HP_KEY, CA_NAME, CA_SOURCENO, CA_YA, HP_CODE, CA_ASSET, CA_CATEGORY, CA_PURCHASE_YEAR, _
                                          HP_PRINCIPAL, HP_INTEREST_RATE, HP_INTEREST, HP_TOTAL, BF_PRINCIPAL, BF_INTEREST, _
                                          CURR_PRINCIPAL, CURR_INTEREST, CF_PRINCIPAL, CF_INTEREST, IndexNo, ID, Errorlog) = False Then
                    Return False
                End If
                CurrLoop += 1
            End While

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
    Public Function GenerateCA_Schudule(ByVal RefNo As String, ByVal YA As String, ByVal ID As String, ByVal CA_KEY As Integer,
                                        Optional ByRef Errorlog As ClsError = Nothing) As Boolean
        Try
            Dim QC_BF As Decimal = 0
            Dim QC_ADD As Decimal = 0
            Dim QC_DISP As Decimal = 0
            Dim QC_CF As Decimal = 0
            Dim TWDV_BF As Decimal = 0
            Dim TWDV_ADD As Decimal = 0
            Dim TWDV_DISP As Decimal = 0
            Dim TWDV_TOTAL As Decimal = 0
            Dim TWDV_IA As Decimal = 0
            Dim TWDV_AA As Decimal = 0
            Dim TWDV_CF As Decimal = 0

            Dim TOTAL_IA As Decimal = 0
            Dim TOTAL_AA As Decimal = 0
            Dim LEFT_IA_AA As Decimal = 0
            Dim ClaimInUsePercent As Integer = 0
            Dim CurrentYA As Integer = 0
            Dim isFirstYear As Boolean = False

            Dim CA_QUA_AMOUNT As Decimal = 0
            Dim CA_MODE As String = "OPN"
            Dim CA_IA As Integer = 0
            Dim CA_AA As Integer = 0
            Dim CA_YA As Integer = 0
            Dim CA_SOURCENO As Integer = 0
            Dim CA_PURCHASE_YE As Integer = 0
            Dim CA_NAME As String = Nothing
            Dim CA_TRANSFERROR_NAME As String = Nothing
            Dim HP_CODE As String = Nothing
            Dim CA_ASSET_NAME As String = Nothing
            Dim CA_CATEGORY As String = Nothing
            Dim CA_TWDV As Integer = 0
            Dim dtDisposal As DataTable = Nothing
            Dim DISP_AMOUNT As Decimal = 0
            Dim IndexNo As Integer = 0
            Dim CA_ACCELERATED As Boolean = False
            Dim dtCategory As DataTable = Nothing
            Dim dt As DataTable = ADO.Load_CA(CA_KEY)
            Dim IsControlTransfer As Boolean = False

            If dt Is Nothing Then
                If Errorlog Is Nothing Then
                    Errorlog = New ClsError
                End If
                With Errorlog
                    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                    .ErrorCode = "P10001"
                    .ErrorDateTime = Now
                    .ErrorMessage = "No data found for CA = " & CA_KEY
                End With
                Return False
            End If




            With dt.Rows(0)
                CA_QUA_AMOUNT = CDec(IIf(IsDBNull(dt.Rows(0)("CA_QUALIFYING_COST")), 0, dt.Rows(0)("CA_QUALIFYING_COST")))
                CA_IA = CInt(IIf(IsDBNull(dt.Rows(0)("CA_RATE_IA")), 0, dt.Rows(0)("CA_RATE_IA")))
                CA_AA = CInt(IIf(IsDBNull(dt.Rows(0)("CA_RATE_AA")), 0, dt.Rows(0)("CA_RATE_AA")))
                CA_MODE = CStr(IIf(IsDBNull(dt.Rows(0)("CA_MODE")), "OPN", dt.Rows(0)("CA_MODE")))
                CA_NAME = CStr(IIf(IsDBNull(dt.Rows(0)("CA_NAME")), "", dt.Rows(0)("CA_NAME")))
                CA_TWDV = CInt(IIf(IsDBNull(dt.Rows(0)("CA_TWDV")), 0, dt.Rows(0)("CA_TWDV")))
                CA_TRANSFERROR_NAME = CStr(IIf(IsDBNull(dt.Rows(0)("CA_TRANSFERROR_NAME")), "", dt.Rows(0)("CA_TRANSFERROR_NAME"))) & " [" & CStr(IIf(IsDBNull(dt.Rows(0)("CA_TAX_FILE_NUMBER")), "", dt.Rows(0)("CA_TAX_FILE_NUMBER"))) & "]"
                CA_ASSET_NAME = CStr(IIf(IsDBNull(dt.Rows(0)("CA_ASSET")), "", dt.Rows(0)("CA_ASSET")))
                CA_ACCELERATED = CStr(IIf(IsDBNull(dt.Rows(0)("CA_ACCELERATED")), "", dt.Rows(0)("CA_ACCELERATED")))
                dtCategory = ADO.LoadCategory(CStr(IIf(IsDBNull(dt.Rows(0)("CA_CATEGORY_CODE")), "", dt.Rows(0)("CA_CATEGORY_CODE"))), Errorlog)

                If dtCategory IsNot Nothing Then
                    CA_CATEGORY = CStr(IIf(IsDBNull(dtCategory.Rows(0)("CA_CATEGORY")), "", dtCategory.Rows(0)("CA_CATEGORY")))

                Else
                    CA_CATEGORY = CStr(IIf(IsDBNull(dt.Rows(0)("CA_CATEGORY_CODE")), "", dt.Rows(0)("CA_CATEGORY_CODE")))
                End If

                If CA_CATEGORY.ToUpper <> "Capital Expenditure Expensed Off in Income Statement" Then
                    CA_CATEGORY = " " & CA_CATEGORY
                End If

                'CA_CATEGORY = CStr(IIf(IsDBNull(dt.Rows(0)("CA_CATEGORY_CODE")), "", dt.Rows(0)("CA_CATEGORY_CODE")))
                HP_CODE = CStr(IIf(IsDBNull(dt.Rows(0)("HP_CODE")), "", dt.Rows(0)("HP_CODE")))
                CA_SOURCENO = CInt(IIf(IsDBNull(dt.Rows(0)("CA_SOURCENO")), 0, dt.Rows(0)("CA_SOURCENO")))
                CA_YA = CInt(IIf(IsDBNull(dt.Rows(0)("CA_YA")), 0, dt.Rows(0)("CA_YA")))

                If IsDBNull(dt.Rows(0)("CA_YA")) = False AndAlso IsNumeric(dt.Rows(0)("CA_YA")) = True Then
                    CA_YA = CInt(dt.Rows(0)("CA_YA"))
                Else
                    CA_YA = 0
                End If

                If IsDBNull(dt.Rows(0)("CA_PURCHASE_YEAR")) = False AndAlso IsNumeric(dt.Rows(0)("CA_PURCHASE_YEAR")) = True Then
                    CA_PURCHASE_YE = CInt(dt.Rows(0)("CA_PURCHASE_YEAR"))
                Else
                    CA_PURCHASE_YE = 0
                End If

            End With


            If CA_MODE.ToUpper = "OPN" Then
                CurrentYA = CA_YA
            Else
                CurrentYA = CA_PURCHASE_YE
            End If

            TOTAL_IA += CA_IA
            TOTAL_AA += CA_AA

            LEFT_IA_AA = 100 - (TOTAL_IA + TOTAL_AA)
            dtDisposal = ADO.Load_DISPOSAL_BY_CA_KEY_DISP_YA(CA_KEY, CStr(CurrentYA), Errorlog)

            If CA_MODE.ToUpper = "OPN" Then
                QC_BF = CA_QUA_AMOUNT
                QC_ADD = 0

                LEFT_IA_AA = ((CA_QUA_AMOUNT - CA_TWDV) / CA_QUA_AMOUNT) * 100
                If dtDisposal IsNot Nothing Then
                    DISP_AMOUNT = CDec(IIf(IsDBNull(dtDisposal.Rows(0)("CA_DISP_QC")), 0, dtDisposal.Rows(0)("CA_DISP_QC")))
                Else
                    DISP_AMOUNT = 0
                End If
                TOTAL_AA += LEFT_IA_AA
                'If dtDisposal IsNot Nothing AndAlso IsDBNull(dtDisposal.Rows(0)("CA_DISP_TYPE")) = False AndAlso dtDisposal.Rows(0)("CA_DISP_TYPE") <> 2 Then
                '    DISP_AMOUNT = CDec(IIf(IsDBNull(dtDisposal.Rows(0)("CA_DISP_QC")), 0, dtDisposal.Rows(0)("CA_DISP_QC")))
                'Else
                '    If dtDisposal IsNot Nothing AndAlso IsDBNull(dtDisposal.Rows(0)("CA_DISP_TYPE")) = False AndAlso dtDisposal.Rows(0)("CA_DISP_TYPE") = 2 Then
                '        IsControlTransfer = True
                '    End If
                '    DISP_AMOUNT = 0
                'End If

                QC_DISP = DISP_AMOUNT

                QC_CF = QC_BF + QC_ADD - QC_DISP
                TWDV_BF = CA_TWDV
                TWDV_ADD = 0

                If DISP_AMOUNT <> 0 Then
                    TWDV_DISP = (DISP_AMOUNT / 100) * LEFT_IA_AA
                Else
                    DISP_AMOUNT = 0
                End If

                If TWDV_BF = 0 Then
                    TWDV_IA = 0
                    TWDV_AA = 0
                Else
                    TWDV_IA = 0
                    TWDV_AA = (QC_CF / 100) * CA_AA
                End If
                
                TWDV_TOTAL = TWDV_BF + TWDV_ADD - TWDV_DISP
                TWDV_CF = TWDV_BF + TWDV_ADD - TWDV_DISP - TWDV_IA - TWDV_AA
            Else
                QC_BF = 0
                QC_ADD = CA_QUA_AMOUNT

                If dtDisposal IsNot Nothing Then
                    DISP_AMOUNT = CDec(IIf(IsDBNull(dtDisposal.Rows(0)("CA_DISP_QC")), 0, dtDisposal.Rows(0)("CA_DISP_QC")))
                Else
                    DISP_AMOUNT = 0
                End If
                'If dtDisposal IsNot Nothing AndAlso IsDBNull(dtDisposal.Rows(0)("CA_DISP_TYPE")) = False AndAlso dtDisposal.Rows(0)("CA_DISP_TYPE") <> 2 Then
                '    DISP_AMOUNT = CDec(IIf(IsDBNull(dtDisposal.Rows(0)("CA_DISP_QC")), 0, dtDisposal.Rows(0)("CA_DISP_QC")))
                'Else
                '    If dtDisposal IsNot Nothing AndAlso IsDBNull(dtDisposal.Rows(0)("CA_DISP_TYPE")) = False AndAlso dtDisposal.Rows(0)("CA_DISP_TYPE") = 2 Then
                '        IsControlTransfer = True
                '    End If
                '    DISP_AMOUNT = 0
                'End If

                QC_DISP = DISP_AMOUNT
                QC_CF = QC_BF + QC_ADD - QC_DISP
                TWDV_BF = 0
                TWDV_ADD = CA_QUA_AMOUNT

                If DISP_AMOUNT <> 0 Then
                    TWDV_DISP = (DISP_AMOUNT / 100) * 100
                Else
                    DISP_AMOUNT = 0
                End If

                TWDV_IA = (QC_CF / 100) * CA_IA
                TWDV_AA = (QC_CF / 100) * CA_AA
                TWDV_TOTAL = TWDV_BF + TWDV_ADD - TWDV_DISP
                TWDV_CF = TWDV_BF + TWDV_ADD - TWDV_DISP - TWDV_IA - TWDV_AA
            End If


            If TWDV_CF < 0 Then
                TWDV_CF = 0
            End If
            If ADO.Save_CA_TEMP_REPORT(RefNo, CurrentYA, CA_KEY, CA_NAME, CA_ASSET_NAME, CA_CATEGORY, _
                                              CA_SOURCENO, CA_YA, HP_CODE, CA_MODE, CA_TRANSFERROR_NAME, CA_PURCHASE_YE, CA_QUA_AMOUNT, _
                                              CA_IA, CA_AA, QC_BF, QC_ADD, QC_DISP, QC_CF, TWDV_BF, TWDV_ADD, TWDV_DISP, _
                                              TWDV_IA, TWDV_AA, TWDV_TOTAL, TWDV_CF, IndexNo, CA_ACCELERATED, ADO.CAReport_TableType.CA_REPORT_TEMP, ID, Errorlog) = False Then
                Return False
            End If


            '=========NEXT YEAR===================================
            Dim CurrLoop As Integer = 0
            While TWDV_CF > 0 And CurrLoop <= MaxYearForCA
                If IsControlTransfer = True Then
                    Exit While
                End If

                CurrLoop += 1
                CurrentYA += 1
                IndexNo += 1

                LEFT_IA_AA = 100 - (TOTAL_IA + TOTAL_AA)
                If LEFT_IA_AA < 0 Then
                    LEFT_IA_AA = 0
                End If

                QC_BF = QC_CF
                QC_ADD = 0
                dtDisposal = ADO.Load_DISPOSAL_BY_CA_KEY_DISP_YA(CA_KEY, CStr(CurrentYA), Errorlog)
                If dtDisposal IsNot Nothing Then
                    DISP_AMOUNT = CDec(IIf(IsDBNull(dtDisposal.Rows(0)("CA_DISP_QC")), 0, dtDisposal.Rows(0)("CA_DISP_QC")))
                Else
                    DISP_AMOUNT = 0
                End If

                QC_DISP = DISP_AMOUNT
                QC_CF = QC_BF + QC_ADD - QC_DISP
                TWDV_BF = TWDV_CF
                TWDV_ADD = 0

                If QC_DISP <> 0 Then
                    TWDV_DISP = (QC_DISP / 100) * LEFT_IA_AA
                Else
                    TWDV_DISP = 0
                End If

                TWDV_IA = 0
                TWDV_AA = (QC_CF / 100) * CA_AA

                If TWDV_AA > TWDV_BF Then
                    TWDV_AA = TWDV_BF
                End If
                TWDV_TOTAL = TWDV_BF + TWDV_ADD - TWDV_DISP
                TWDV_CF = TWDV_BF + TWDV_ADD - TWDV_DISP - TWDV_IA - TWDV_AA

                If TWDV_CF < 0 Then
                    TWDV_CF = 0
                End If
                If ADO.Save_CA_TEMP_REPORT(RefNo, CurrentYA, CA_KEY, CA_NAME, CA_ASSET_NAME, CA_CATEGORY, _
                                            CA_SOURCENO, CA_YA, HP_CODE, CA_MODE, CA_TRANSFERROR_NAME, CA_PURCHASE_YE, CA_QUA_AMOUNT, _
                                            CA_IA, CA_AA, QC_BF, QC_ADD, QC_DISP, QC_CF, TWDV_BF, TWDV_ADD, TWDV_DISP, _
                                            TWDV_IA, TWDV_AA, TWDV_TOTAL, TWDV_CF, IndexNo, CA_ACCELERATED, ADO.CAReport_TableType.CA_REPORT_TEMP, ID, Errorlog) = False Then
                    Return False
                End If


                TOTAL_AA += CA_AA
            End While

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
    Public Function GenerateCA_FixedAssetREconliliation_Schudule(ByVal RefNo As String, ByVal YA As String, ByVal ID As String, ByVal CA_KEY As Integer, Optional ByRef Errorlog As ClsError = Nothing) As Boolean
        Try
            Dim QC_BF As Decimal = 0
            Dim QC_ADD As Decimal = 0
            Dim QC_DISP As Decimal = 0
            Dim QC_CF As Decimal = 0

            Dim TWDV_BF As Decimal = 0
            Dim TWDV_ADD As Decimal = 0
            Dim TWDV_DISP As Decimal = 0
            Dim TWDV_IA As Decimal = 0
            Dim TWDV_AA As Decimal = 0
            Dim TWDV_CF As Decimal = 0

            Dim PC_BF As Decimal = 0
            Dim PC_ADD As Decimal = 0
            Dim PC_DISP As Decimal = 0
            Dim PC_CF As Decimal = 0

            Dim TOTAL_IA As Decimal = 0
            Dim TOTAL_AA As Decimal = 0
            Dim LEFT_IA_AA As Decimal = 0
            Dim ClaimInUsePercent As Integer = 0
            Dim CurrentYA As Integer = 0
            Dim isFirstYear As Boolean = False

            Dim CA_QUA_AMOUNT As Decimal = 0
            Dim CA_MODE As String = "OPN"
            Dim CA_IA As Integer = 0
            Dim CA_AA As Integer = 0
            Dim CA_YA As Integer = 0
            Dim CA_SOURCENO As Integer = 0
            Dim CA_PURCHASE_YE As Integer = 0
            Dim CA_PURCHASE_AMOUNT As Decimal = 0
            Dim CA_NAME As String = Nothing
            Dim HP_CODE As String = Nothing
            Dim CA_ASSET_NAME As String = Nothing
            Dim CA_ASSET_CODE As String = Nothing
            Dim CA_CATEGORY As String = Nothing
            Dim dtDisposal As DataTable = Nothing
            Dim DISP_AMOUNT As Decimal = 0
            Dim IndexNo As Integer = 0
            Dim dt As DataTable = ADO.Load_CA(CA_KEY)

            If dt Is Nothing Then
                If Errorlog Is Nothing Then
                    Errorlog = New ClsError
                End If
                With Errorlog
                    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                    .ErrorCode = "P10001"
                    .ErrorDateTime = Now
                    .ErrorMessage = "No data found for CA = " & CA_KEY
                End With
                Return False
            End If

            With dt.Rows(0)
                CA_PURCHASE_AMOUNT = CDec(IIf(IsDBNull(dt.Rows(0)("CA_PURCHASE_AMOUNT")), 0, dt.Rows(0)("CA_PURCHASE_AMOUNT")))
                CA_QUA_AMOUNT = CDec(IIf(IsDBNull(dt.Rows(0)("CA_QUALIFYING_COST")), 0, dt.Rows(0)("CA_QUALIFYING_COST")))
                CA_IA = CInt(IIf(IsDBNull(dt.Rows(0)("CA_RATE_IA")), 0, dt.Rows(0)("CA_RATE_IA")))
                CA_AA = CInt(IIf(IsDBNull(dt.Rows(0)("CA_RATE_AA")), 0, dt.Rows(0)("CA_RATE_AA")))
                CA_MODE = CStr(IIf(IsDBNull(dt.Rows(0)("CA_MODE")), "OPN", dt.Rows(0)("CA_MODE")))
                CA_NAME = CStr(IIf(IsDBNull(dt.Rows(0)("CA_NAME")), "", dt.Rows(0)("CA_NAME")))
                CA_ASSET_CODE = CStr(IIf(IsDBNull(dt.Rows(0)("CA_ASSET_CODE")), "", dt.Rows(0)("CA_ASSET_CODE")))
                CA_ASSET_NAME = CStr(IIf(IsDBNull(dt.Rows(0)("CA_ASSET")), "", dt.Rows(0)("CA_ASSET")))
                CA_CATEGORY = CStr(IIf(IsDBNull(dt.Rows(0)("CA_CATEGORY_CODE")), "", dt.Rows(0)("CA_CATEGORY_CODE")))
                HP_CODE = CStr(IIf(IsDBNull(dt.Rows(0)("HP_CODE")), "", dt.Rows(0)("HP_CODE")))
                CA_SOURCENO = CInt(IIf(IsDBNull(dt.Rows(0)("CA_SOURCENO")), 0, dt.Rows(0)("CA_SOURCENO")))
                CA_YA = CInt(IIf(IsDBNull(dt.Rows(0)("CA_YA")), 0, dt.Rows(0)("CA_YA")))


                If IsDBNull(dt.Rows(0)("CA_YA")) = False AndAlso IsNumeric(dt.Rows(0)("CA_YA")) = True Then
                    CA_YA = CInt(dt.Rows(0)("CA_YA"))
                Else
                    CA_YA = 0
                End If

                If IsDBNull(dt.Rows(0)("CA_PURCHASE_YEAR")) = False AndAlso IsNumeric(dt.Rows(0)("CA_PURCHASE_YEAR")) = True Then
                    CA_PURCHASE_YE = CInt(dt.Rows(0)("CA_PURCHASE_YEAR"))
                Else
                    CA_PURCHASE_YE = 0
                End If

            End With


            CurrentYA = CA_PURCHASE_YE
            TOTAL_IA += CA_IA
            TOTAL_AA += CA_AA

            LEFT_IA_AA = 100 - (TOTAL_IA + TOTAL_AA)

            dtDisposal = ADO.Load_DISPOSAL_BY_CA_KEY_DISP_YA(CA_KEY, CStr(CurrentYA), Errorlog)

            If CA_MODE.ToUpper = "OPN" Then
                QC_BF = CA_QUA_AMOUNT
                QC_ADD = 0

                If dtDisposal IsNot Nothing Then
                    DISP_AMOUNT = CDec(IIf(IsDBNull(dtDisposal.Rows(0)("CA_DISP_QC")), 0, dtDisposal.Rows(0)("CA_DISP_QC")))
                End If

                QC_DISP = DISP_AMOUNT

                QC_CF = QC_BF + QC_ADD - QC_DISP

                TWDV_BF = CA_QUA_AMOUNT
                TWDV_ADD = 0

                If DISP_AMOUNT <> 0 Then
                    TWDV_DISP = (DISP_AMOUNT / 100) * LEFT_IA_AA
                Else
                    DISP_AMOUNT = 0
                End If

                TWDV_IA = 0
                TWDV_AA = (QC_CF / 100) * CA_AA

                TWDV_CF = TWDV_BF + TWDV_ADD - TWDV_DISP - TWDV_IA - TWDV_AA


                PC_BF = CA_PURCHASE_AMOUNT
                PC_ADD = 0

                If DISP_AMOUNT <> 0 Then
                    PC_DISP = DISP_AMOUNT
                Else
                    PC_DISP = 0
                End If

                PC_CF = PC_BF + PC_ADD - PC_DISP
            Else
                'QC
                QC_BF = 0
                QC_ADD = CA_QUA_AMOUNT
                If dtDisposal IsNot Nothing Then
                    DISP_AMOUNT = CDec(IIf(IsDBNull(dtDisposal.Rows(0)("CA_DISP_QC")), 0, dtDisposal.Rows(0)("CA_DISP_QC")))
                Else
                    DISP_AMOUNT = 0
                End If

                QC_DISP = DISP_AMOUNT
                QC_CF = QC_BF + QC_ADD - QC_DISP

                'TWDV
                TWDV_BF = 0
                TWDV_ADD = CA_QUA_AMOUNT

                If DISP_AMOUNT <> 0 Then
                    TWDV_DISP = (DISP_AMOUNT / 100) * LEFT_IA_AA
                Else
                    DISP_AMOUNT = 0
                End If

                TWDV_IA = (QC_CF / 100) * CA_IA
                TWDV_AA = (QC_CF / 100) * CA_AA

                TWDV_CF = TWDV_BF + TWDV_ADD - TWDV_DISP - TWDV_IA - TWDV_AA

                'PC
                PC_BF = 0
                PC_ADD = CA_PURCHASE_AMOUNT

                If DISP_AMOUNT <> 0 Then
                    PC_DISP = DISP_AMOUNT
                Else
                    PC_DISP = 0
                End If

                PC_CF = PC_BF + PC_ADD - PC_DISP
            End If

            If TWDV_CF < 0 Then
                TWDV_CF = 0
            End If
            If PC_CF < 0 Then
                PC_CF = 0
            End If
            If ADO.Save_CA_FAReconliliation_TEMP_REPORT(RefNo, CurrentYA, CA_KEY, CA_NAME, CA_ASSET_NAME, CA_ASSET_CODE, CA_CATEGORY, _
                                              CA_SOURCENO, CA_YA, HP_CODE, CA_MODE, CA_PURCHASE_YE, CA_QUA_AMOUNT, CA_PURCHASE_AMOUNT, _
                                              CA_IA, CA_AA, QC_BF, QC_ADD, QC_DISP, QC_CF, TWDV_BF, TWDV_ADD, TWDV_DISP, TWDV_IA, TWDV_AA, TWDV_CF, PC_BF, PC_ADD, PC_DISP, _
                                              PC_CF, IndexNo, ADO.CAReport_TableType.CA_REPORT_FIXEDASET_RECONCILIATION, ID, Errorlog) = False Then
                Return False
            End If


            '=========NEXT YEAR===================================
            Dim CurrLoop As Integer = 0
            While TWDV_CF > 0 And CurrLoop <= MaxYearForCA
                CurrLoop += 1
                CurrentYA += 1
                IndexNo += 1

                LEFT_IA_AA = 100 - (TOTAL_IA + TOTAL_AA)
                If LEFT_IA_AA < 0 Then
                    LEFT_IA_AA = 0
                End If
                'QC
                QC_BF = QC_CF
                QC_ADD = 0
                dtDisposal = ADO.Load_DISPOSAL_BY_CA_KEY_DISP_YA(CA_KEY, CStr(CurrentYA), Errorlog)
                If dtDisposal IsNot Nothing Then
                    DISP_AMOUNT = CDec(IIf(IsDBNull(dtDisposal.Rows(0)("CA_DISP_QC")), 0, dtDisposal.Rows(0)("CA_DISP_QC")))
                Else
                    DISP_AMOUNT = 0
                End If

                QC_DISP = DISP_AMOUNT
                QC_CF = QC_BF + QC_ADD - QC_DISP

                'TWDV
                TWDV_BF = TWDV_CF
                TWDV_ADD = 0

                If QC_DISP <> 0 Then
                    TWDV_DISP = (QC_DISP / 100) * LEFT_IA_AA
                Else
                    TWDV_DISP = 0
                End If

                TWDV_IA = 0
                TWDV_AA = (QC_CF / 100) * CA_AA

                If TWDV_AA > TWDV_BF Then
                    TWDV_AA = TWDV_BF
                End If

                TWDV_CF = TWDV_BF + TWDV_ADD - TWDV_DISP - TWDV_IA - TWDV_AA

                If TWDV_CF < 0 Then
                    TWDV_CF = 0
                End If

                'PC
                PC_BF = PC_CF
                PC_ADD = 0

                PC_DISP = DISP_AMOUNT

                PC_CF = PC_BF + PC_ADD - PC_DISP

                If PC_CF < 0 Then
                    PC_CF = 0
                End If

                If ADO.Save_CA_FAReconliliation_TEMP_REPORT(RefNo, CurrentYA, CA_KEY, CA_NAME, CA_ASSET_NAME, CA_ASSET_CODE, CA_CATEGORY, _
                                            CA_SOURCENO, CA_YA, HP_CODE, CA_MODE, CA_PURCHASE_YE, CA_QUA_AMOUNT, CA_PURCHASE_AMOUNT, _
                                            CA_IA, CA_AA, QC_BF, QC_ADD, QC_DISP, QC_CF, TWDV_BF, TWDV_ADD, TWDV_DISP, TWDV_IA, TWDV_AA, TWDV_CF, PC_BF, PC_ADD, PC_DISP, _
                                            PC_CF, IndexNo, ADO.CAReport_TableType.CA_REPORT_FIXEDASET_RECONCILIATION, ID, Errorlog) = False Then
                    Return False
                End If

                TOTAL_AA += CA_AA
            End While

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
    Public Function ShowNoteFooter(ByVal Type As Integer, ByVal RefNo As String, ByVal YA As Integer,
                                   Optional ByVal Disposal_type As Integer = 0, Optional isTableOfContent As Boolean = False,
                                   Optional ByRef ErrorLog As ClsError = Nothing) As Boolean
        Try
            If isTableOfContent = True Then
                Return False
            End If

            My.Settings.Reload()
            Application.DoEvents()

            If My.Settings.isAlwaysShowFooterNoteCA Then
                Select Case Type
                    Case 0
                        Dim frm As New frmCA_NoteFooter_ControlTransfer_In
                        frm.RefNo = RefNo
                        frm.YA = YA
                        frm.ShowDialog()
                    Case 1
                        Dim frm As New frmCA_NoteFooter_Disposal
                        frm.RefNo = RefNo
                        frm.YA = YA
                        frm.Type = Disposal_type
                        frm.ShowDialog()
                    Case 2
                        Dim frm As New frmCA_NoteFooter_HP
                        frm.RefNo = RefNo
                        frm.YA = YA
                        frm.ShowDialog()
                    Case 3
                        Dim frm As New frmCA_NoteFooter_CA
                        frm.RefNo = RefNo
                        frm.YA = YA
                        frm.ShowDialog()
                End Select
            End If
            Return True
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
End Module
