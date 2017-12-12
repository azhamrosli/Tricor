Module mdlReport_CA
    Public Function Report_CA(ByVal RefNo As String, ByVal YA As String, ByRef ID As String, _
                              ByVal RateFrom As Integer, ByVal RateTo As Integer, ByVal Category As String, _
                              Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = mdlProcess.LoadCA_Search_Report(RefNo, YA, RateFrom, RateTo, Category, Errorlog)

            If dt IsNot Nothing Then

                ID = "CA_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)

                While mdlProcess.Validate_CA_TEMP_REPORTID(ID)
                    ID = "CA_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)
                End While


                For i As Integer = 0 To dt.Rows.Count - 1
                    If IsDBNull(dt.Rows(i)("CA_KEY")) = False Then
                        If mdlReport_CA.GenerateCA_Schudule(RefNo, YA, ID, CInt(dt.Rows(i)("CA_KEY")), Errorlog) = False Then
                            Return False
                        End If
                    End If
                Next

            End If

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
    Public Function Report_CA_Summary(ByVal RefNo As String, ByVal YA As String, ByRef ID As String, _
                              ByVal RateFrom As Integer, ByVal RateTo As Integer, ByVal Category As String, ByVal Type As mdlEnum.CAReport_Type, _
                              Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dtCA As DataTable = mdlProcess.LoadCA_Search_Report(RefNo, "", RateFrom, RateTo, Category, Errorlog)

            If dtCA IsNot Nothing Then

                ID = "CA_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)

                While mdlProcess.Validate_CA_TEMP_REPORTID(ID)
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
                        dt = mdlProcess.Load_CAReportSummary_Temp_ByRate(ID, CInt(YA), Errorlog)
                    Case CAReport_Type.CA_REPORT_SUMMARY_BYCATEGORY
                        dt = mdlProcess.Load_CAReportSummary_Temp_ByCategory(ID, CInt(YA), Errorlog)
                End Select
                'mdlProcess.Load_CAReportSummary_Temp(ID, CInt(YA), Errorlog)

                If dt IsNot Nothing Then

                    Dim CurrentYA As Integer = 0
                    Dim CA_KEY As Integer = 0
                    Dim CA_NAME As String = Nothing
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
                    Dim IndexNo As Integer = 0
                    For i As Integer = 0 To dt.Rows.Count - 1


                        CA_KEY = 0
                        CA_NAME = CStr(IIf(IsDBNull(dt.Rows(i)("CA_NAME")), "", dt.Rows(i)("CA_NAME")))
                        CA_ASSET = ""

                        Select Case Type
                            Case CAReport_Type.CA_REPORT_SUMMARY_BYRATE
                                CurrentYA = 0
                                CA_CATEGORY_CODE = ""
                                CA_RATE_IA = 0
                                CA_RATE_AA = CInt(IIf(IsDBNull(dt.Rows(i)("CA_RATE_AA")), 0, dt.Rows(i)("CA_RATE_AA")))
                            Case CAReport_Type.CA_REPORT_SUMMARY_BYCATEGORY
                                CurrentYA = 0
                                CA_CATEGORY_CODE = CStr(IIf(IsDBNull(dt.Rows(i)("CA_CATEGORY_CODE")), "", dt.Rows(i)("CA_CATEGORY_CODE")))
                                CA_RATE_IA = 0
                                CA_RATE_AA = CInt(IIf(IsDBNull(dt.Rows(i)("CA_RATE_AA")), 0, dt.Rows(i)("CA_RATE_AA")))
                            Case Else
                                CurrentYA = CInt(IIf(IsDBNull(dt.Rows(i)("YA")), 0, dt.Rows(i)("YA")))
                                CA_CATEGORY_CODE = ""
                                CA_RATE_IA = 0
                                CA_RATE_AA = 0
                        End Select

                        CA_SOURCENO = 0
                        CA_YA = 0
                        HP_CODE = ""
                        CA_MODE = ""
                        CA_PURCHASE_YEAR = CInt(IIf(IsDBNull(dt.Rows(i)("CA_PURCHASE_YEAR")), 0, dt.Rows(i)("CA_PURCHASE_YEAR")))
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
                        TWDV_CF = CDec(IIf(IsDBNull(dt.Rows(i)("TWDV_CF")), 0, dt.Rows(i)("TWDV_CF")))
                        IndexNo = i

                        If mdlProcess.Save_CA_TEMP_REPORT(RefNo, CurrentYA, CA_KEY, CA_NAME, CA_ASSET, CA_CATEGORY_CODE, _
                                              CA_SOURCENO, CA_YA, HP_CODE, CA_MODE, CA_PURCHASE_YEAR, CA_QUALIFYING_COST, _
                                              CA_RATE_IA, CA_RATE_AA, QC_BF, QC_ADD, QC_DISP, QC_CF, TWDV_BF, TWDV_ADD, TWDV_DISP, _
                                              TWDV_IA, TWDV_AA, TWDV_CF, IndexNo, CAReport_TableType.CA_REPORT_SUMMARY_TEMP, ID, Errorlog) = False Then
                            Return False
                        End If
                    Next

                End If

            End If



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
    Public Function GenerateCA_Schudule(ByVal RefNo As String, ByVal YA As String, ByVal ID As String, ByVal CA_KEY As Integer, Optional ByRef Errorlog As clsError = Nothing) As Boolean
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
            Dim HP_CODE As String = Nothing
            Dim CA_ASSET_NAME As String = Nothing
            Dim CA_CATEGORY As String = Nothing
            Dim dtDisposal As DataTable = Nothing
            Dim DISP_AMOUNT As Decimal = 0
            Dim IndexNo As Integer = 0
            Dim dt As DataTable = mdlProcess.Load_CA(CA_KEY)

            If dt Is Nothing Then
                If Errorlog Is Nothing Then
                    Errorlog = New clsError
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

            If CA_MODE.ToUpper = "OPN" Then
                QC_BF = CA_QUA_AMOUNT
                QC_ADD = 0

                dtDisposal = mdlProcess.Load_DISPOSAL_BY_CA_KEY_DISP_YA(CA_KEY, CStr(CurrentYA), Errorlog)

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
            Else
                QC_BF = 0
                QC_ADD = CA_QUA_AMOUNT
                If dtDisposal IsNot Nothing Then
                    DISP_AMOUNT = CDec(IIf(IsDBNull(dtDisposal.Rows(0)("CA_DISP_QC")), 0, dtDisposal.Rows(0)("CA_DISP_QC")))
                Else
                    DISP_AMOUNT = 0
                End If

                QC_DISP = DISP_AMOUNT
                QC_CF = QC_BF + QC_ADD - QC_DISP
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
            End If


            If TWDV_CF < 0 Then
                TWDV_CF = 0
            End If
            If mdlProcess.Save_CA_TEMP_REPORT(RefNo, CurrentYA, CA_KEY, CA_NAME, CA_ASSET_NAME, CA_CATEGORY, _
                                              CA_SOURCENO, CA_YA, HP_CODE, CA_MODE, CA_PURCHASE_YE, CA_QUA_AMOUNT, _
                                              CA_IA, CA_AA, QC_BF, QC_ADD, QC_DISP, QC_CF, TWDV_BF, TWDV_ADD, TWDV_DISP, _
                                              TWDV_IA, TWDV_AA, TWDV_CF, IndexNo, CAReport_TableType.CA_REPORT_TEMP, ID, Errorlog) = False Then
                Return False
            End If


            '=========NEXT YEAR===================================
            While TWDV_CF > 0
                CurrentYA += 1
                IndexNo += 1

                LEFT_IA_AA = 100 - (TOTAL_IA + TOTAL_AA)
                If LEFT_IA_AA < 0 Then
                    LEFT_IA_AA = 0
                End If

                QC_BF = QC_CF
                QC_ADD = 0
                dtDisposal = mdlProcess.Load_DISPOSAL_BY_CA_KEY_DISP_YA(CA_KEY, CStr(CurrentYA), Errorlog)
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

                TWDV_CF = TWDV_BF + TWDV_ADD - TWDV_DISP - TWDV_IA - TWDV_AA

                If TWDV_CF < 0 Then
                    TWDV_CF = 0
                End If
                If mdlProcess.Save_CA_TEMP_REPORT(RefNo, CurrentYA, CA_KEY, CA_NAME, CA_ASSET_NAME, CA_CATEGORY, _
                                            CA_SOURCENO, CA_YA, HP_CODE, CA_MODE, CA_PURCHASE_YE, CA_QUA_AMOUNT, _
                                            CA_IA, CA_AA, QC_BF, QC_ADD, QC_DISP, QC_CF, TWDV_BF, TWDV_ADD, TWDV_DISP, _
                                            TWDV_IA, TWDV_AA, TWDV_CF, IndexNo, CAReport_TableType.CA_REPORT_TEMP, ID, Errorlog) = False Then
                    Return False
                End If


                TOTAL_AA += CA_AA
            End While

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


End Module
