Module mdlReport_CA
    Dim MaxYearForCA As Integer = 150

    Public Function Report_CA(ByVal RefNo As String, ByVal YA As String, ByRef ID As String, _
                              ByVal RateFrom As Integer, ByVal RateTo As Integer, ByVal Category As String, _
                              Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = mdlProcess.LoadCA_Search_Report(RefNo, "", RateFrom, RateTo, Category, Errorlog)

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
    Public Function Report_DISPOSAL(ByVal RefNo As String, ByVal YA As String, ByRef ID As String, _
                              ByVal RateFrom As Integer, ByVal RateTo As Integer, ByVal Category As String, _
                              ByVal Type As Integer, Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = mdlProcess.LoadDisposal_Search_Report(RefNo, YA, RateFrom, RateTo, Category, Type, Errorlog)

            If dt IsNot Nothing Then

                ID = "CA_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)

                While mdlProcess.Validate_CA_TEMP_REPORTID(ID)
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
                Dim DISP_DEPRECIATION As Decimal = 0
                Dim DISP_WDV As Decimal = 0
                Dim DISP_DISPOSAL_VALUE As Decimal = 0
                Dim DISP_PNL As Decimal = 0
                Dim DISP_TWDV As Decimal = 0
                Dim DISP_BABC As Decimal = 0
                Dim IndexNo As Integer = 0
                Dim dtCA As DataTable = Nothing

                For i As Integer = 0 To dt.Rows.Count - 1
                    dtCA = Nothing

                    If IsDBNull(dt.Rows(i)("CA_KEY")) = False Then
                        dtCA = mdlProcess.Load_CA(dt.Rows(i)("CA_KEY"), Errorlog)
                    End If
                   
                    If dtCA IsNot Nothing Then
                        CA_KEY = IIf(IsDBNull(dtCA.Rows(0)("CA_KEY")), 0, dtCA.Rows(0)("CA_KEY"))
                        CA_NAME = IIf(IsDBNull(dtCA.Rows(0)("CA_NAME")), "", dtCA.Rows(0)("CA_NAME"))
                        CA_SOURCENO = IIf(IsDBNull(dtCA.Rows(0)("CA_SOURCENO")), 0, dtCA.Rows(0)("CA_SOURCENO"))
                        CA_YA = IIf(IsDBNull(dtCA.Rows(0)("CA_YA")), 0, dtCA.Rows(0)("CA_YA"))
                        HP_CODE = IIf(IsDBNull(dtCA.Rows(0)("HP_CODE")), "", dtCA.Rows(0)("HP_CODE"))
                        CA_ASSET_NAME = IIf(IsDBNull(dtCA.Rows(0)("CA_ASSET")), "", dtCA.Rows(0)("CA_ASSET"))
                        CA_CATEGORY_CODE = IIf(IsDBNull(dtCA.Rows(0)("CA_CATEGORY_CODE")), "", dtCA.Rows(0)("CA_CATEGORY_CODE"))
                        CA_MODE = IIf(IsDBNull(dtCA.Rows(0)("CA_MODE")), "OPN", dtCA.Rows(0)("CA_MODE"))
                        CA_QUALIFYING_COST = IIf(IsDBNull(dtCA.Rows(0)("CA_QUALIFYING_COST")), 0, dtCA.Rows(0)("CA_QUALIFYING_COST"))
                        CA_TRANSFERROR_NAME = IIf(IsDBNull(dtCA.Rows(0)("CA_TRANSFERROR_NAME")), "", dtCA.Rows(0)("CA_TRANSFERROR_NAME"))
                        CA_PURCHASE_YEAR = IIf(IsDBNull(dtCA.Rows(0)("CA_PURCHASE_YEAR")), 0, dtCA.Rows(0)("CA_PURCHASE_YEAR"))
                        CA_RATE_IA = IIf(IsDBNull(dtCA.Rows(0)("CA_RATE_IA")), 0, dtCA.Rows(0)("CA_RATE_IA"))
                        CA_RATE_AA = IIf(IsDBNull(dtCA.Rows(0)("CA_RATE_AA")), 0, dtCA.Rows(0)("CA_RATE_AA"))
                        CA_CAEEO = IIf(IsDBNull(dtCA.Rows(0)("CA_CAEEO")), False, dtCA.Rows(0)("CA_CAEEO"))
                        DISP_DEPRECIATION = CDec(IIf(IsDBNull(dt.Rows(i)("CA_ACCUMULATED")), 0, dt.Rows(i)("CA_ACCUMULATED")))

                        DISP_WDV = CA_QUALIFYING_COST - DISP_DEPRECIATION

                        DISP_DISPOSAL_VALUE = CDec(IIf(IsDBNull(dt.Rows(i)("CA_DISP_SPROCEED")), 0, dt.Rows(i)("CA_DISP_SPROCEED")))
                        DISP_PNL = DISP_WDV - DISP_DISPOSAL_VALUE
                        DISP_TWDV = CDec(IIf(IsDBNull(dt.Rows(i)("CA_DISP_TWDV")), 0, dt.Rows(i)("CA_DISP_TWDV")))
                        DISP_BABC = CDec(IIf(IsDBNull(dt.Rows(i)("CA_DISP_BABC")), 0, dt.Rows(i)("CA_DISP_BABC")))

                        If mdlProcess.Save_Disposal_Report_TEMP(ID, RefNo, YA, CA_KEY, CA_NAME, CA_SOURCENO, _
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
            Return True
        End Try
    End Function
    Public Function Report_CA_ControlTransfer(ByVal RefNo As String, ByVal YA As String, ByRef ID As String, _
                              ByVal RateFrom As Integer, ByVal RateTo As Integer, ByVal Category As String, _
                              Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = mdlProcess.LoadCA_Search_Report_ControlTransfer(RefNo, "", RateFrom, RateTo, Category, Errorlog)

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


                Dim dtData As DataTable = Load_CAReport_Temp(ID, YA)

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
                    For i As Integer = 0 To dtData.Rows.Count - 1

                        CurrentYA = IIf(IsDBNull(dtData.Rows(i)("YA")), 0, dtData.Rows(i)("YA"))
                        CA_KEY = IIf(IsDBNull(dtData.Rows(i)("CA_KEY")), 0, dtData.Rows(i)("CA_KEY"))

                        tmpDT = mdlProcess.Load_CA(CA_KEY, Errorlog)

                        If tmpDT Is Nothing Then
                            Exit For
                        End If

                   
                        CA_NAME = IIf(IsDBNull(dtData.Rows(i)("CA_NAME")), "", dtData.Rows(i)("CA_NAME"))
                        CA_SOURCENO = IIf(IsDBNull(dtData.Rows(i)("CA_SOURCENO")), 0, dtData.Rows(i)("CA_SOURCENO"))
                        CA_YA = IIf(IsDBNull(dtData.Rows(i)("CA_YA")), 0, dtData.Rows(i)("CA_YA"))
                        HP_CODE = IIf(IsDBNull(dtData.Rows(i)("HP_CODE")), "", dtData.Rows(i)("HP_CODE"))
                        CA_ASSET = IIf(IsDBNull(dtData.Rows(i)("CA_ASSET")), "", dtData.Rows(i)("CA_ASSET"))
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
                        CA_TRANSFER_VAL = IIf(IsDBNull(tmpDT.Rows(0)("CA_TRANSFER_VAL")), 0, tmpDT.Rows(0)("CA_TRANSFER_VAL"))

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

                        If mdlProcess.Save_CA_ControlTranfer(ID, RefNo, CurrentYA, CA_KEY, CA_NAME, CA_SOURCENO, CA_YA, HP_CODE, CA_ASSET, CA_CATEGORY_CODE, _
                                                             CA_PURCHASE_AMOUNT, CA_TRANSFERROR_NAME, CA_TRANSFER_VAL, CA_PURCHASE_YEAR, CA_QUALIFYING_COST, CA_RATE_IA, CA_RATE_AA, _
                                                             CA_CAEEO, QC_CF, TWDV_BF, AA_0, AA_2, AA_3, AA_8, AA_10, AA_12, AA_14, AA_16, AA_20, AA_40, AA_50, _
                                                             AA_60, AA_80, AA_90, AA_100, i, TmpID, Errorlog) = False Then
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
            AddListOfError(Errorlog)
            Return True
        End Try
    End Function
    Public Function Report_CA_FAConciliation(ByVal RefNo As String, ByVal YA As String, ByRef ID As String, _
                              ByVal RateFrom As Integer, ByVal RateTo As Integer, ByVal Category As String, _
                              Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = mdlProcess.LoadCA_Search_Report(RefNo, "", RateFrom, RateTo, Category, Errorlog)

            If dt IsNot Nothing Then

                ID = "CA_" & Format(Now, "ddMMMyyyyHHmmss") & RandomKey(5)

                While mdlProcess.Validate_CA__FA_TEMP_REPORTID(ID)
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

                        If mdlProcess.Save_CA_TEMP_REPORT(RefNo, CurrentYA, CA_KEY, CA_NAME, CA_ASSET, CA_CATEGORY_CODE, _
                                              CA_SOURCENO, CA_YA, HP_CODE, CA_MODE, CA_TRANSFERROR_NAME, CA_PURCHASE_YEAR, CA_QUALIFYING_COST, _
                                              CA_RATE_IA, CA_RATE_AA, QC_BF, QC_ADD, QC_DISP, QC_CF, TWDV_BF, TWDV_ADD, TWDV_DISP, _
                                              TWDV_IA, TWDV_AA, TWDV_TOTAL, TWDV_CF, IndexNo, CAReport_TableType.CA_REPORT_SUMMARY_TEMP, ID, Errorlog) = False Then
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
                CA_TRANSFERROR_NAME = CStr(IIf(IsDBNull(dt.Rows(0)("CA_TRANSFERROR_NAME")), "", dt.Rows(0)("CA_TRANSFERROR_NAME")))
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
            dtDisposal = mdlProcess.Load_DISPOSAL_BY_CA_KEY_DISP_YA(CA_KEY, CStr(CurrentYA), Errorlog)

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
                TWDV_TOTAL = TWDV_BF + TWDV_ADD - TWDV_DISP
                TWDV_CF = TWDV_BF + TWDV_ADD - TWDV_DISP - TWDV_IA - TWDV_AA
            End If


            If TWDV_CF < 0 Then
                TWDV_CF = 0
            End If
            If mdlProcess.Save_CA_TEMP_REPORT(RefNo, CurrentYA, CA_KEY, CA_NAME, CA_ASSET_NAME, CA_CATEGORY, _
                                              CA_SOURCENO, CA_YA, HP_CODE, CA_MODE, CA_TRANSFERROR_NAME, CA_PURCHASE_YE, CA_QUA_AMOUNT, _
                                              CA_IA, CA_AA, QC_BF, QC_ADD, QC_DISP, QC_CF, TWDV_BF, TWDV_ADD, TWDV_DISP, _
                                              TWDV_IA, TWDV_AA, TWDV_TOTAL, TWDV_CF, IndexNo, CAReport_TableType.CA_REPORT_TEMP, ID, Errorlog) = False Then
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
                TWDV_TOTAL = TWDV_BF + TWDV_ADD - TWDV_DISP
                TWDV_CF = TWDV_BF + TWDV_ADD - TWDV_DISP - TWDV_IA - TWDV_AA

                If TWDV_CF < 0 Then
                    TWDV_CF = 0
                End If
                If mdlProcess.Save_CA_TEMP_REPORT(RefNo, CurrentYA, CA_KEY, CA_NAME, CA_ASSET_NAME, CA_CATEGORY, _
                                            CA_SOURCENO, CA_YA, HP_CODE, CA_MODE, CA_TRANSFERROR_NAME, CA_PURCHASE_YE, CA_QUA_AMOUNT, _
                                            CA_IA, CA_AA, QC_BF, QC_ADD, QC_DISP, QC_CF, TWDV_BF, TWDV_ADD, TWDV_DISP, _
                                            TWDV_IA, TWDV_AA, TWDV_TOTAL, TWDV_CF, IndexNo, CAReport_TableType.CA_REPORT_TEMP, ID, Errorlog) = False Then
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
    Public Function GenerateCA_FixedAssetREconliliation_Schudule(ByVal RefNo As String, ByVal YA As String, ByVal ID As String, ByVal CA_KEY As Integer, Optional ByRef Errorlog As clsError = Nothing) As Boolean
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

            dtDisposal = mdlProcess.Load_DISPOSAL_BY_CA_KEY_DISP_YA(CA_KEY, CStr(CurrentYA), Errorlog)

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
            If mdlProcess.Save_CA_FAReconliliation_TEMP_REPORT(RefNo, CurrentYA, CA_KEY, CA_NAME, CA_ASSET_NAME, CA_ASSET_CODE, CA_CATEGORY, _
                                              CA_SOURCENO, CA_YA, HP_CODE, CA_MODE, CA_PURCHASE_YE, CA_QUA_AMOUNT, CA_PURCHASE_AMOUNT, _
                                              CA_IA, CA_AA, QC_BF, QC_ADD, QC_DISP, QC_CF, TWDV_BF, TWDV_ADD, TWDV_DISP, TWDV_IA, TWDV_AA, TWDV_CF, PC_BF, PC_ADD, PC_DISP, _
                                              PC_CF, IndexNo, CAReport_TableType.CA_REPORT_FIXEDASET_RECONCILIATION, ID, Errorlog) = False Then
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
                dtDisposal = mdlProcess.Load_DISPOSAL_BY_CA_KEY_DISP_YA(CA_KEY, CStr(CurrentYA), Errorlog)
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

                If mdlProcess.Save_CA_FAReconliliation_TEMP_REPORT(RefNo, CurrentYA, CA_KEY, CA_NAME, CA_ASSET_NAME, CA_ASSET_CODE, CA_CATEGORY, _
                                            CA_SOURCENO, CA_YA, HP_CODE, CA_MODE, CA_PURCHASE_YE, CA_QUA_AMOUNT, CA_PURCHASE_AMOUNT, _
                                            CA_IA, CA_AA, QC_BF, QC_ADD, QC_DISP, QC_CF, TWDV_BF, TWDV_ADD, TWDV_DISP, TWDV_IA, TWDV_AA, TWDV_CF, PC_BF, PC_ADD, PC_DISP, _
                                            PC_CF, IndexNo, CAReport_TableType.CA_REPORT_FIXEDASET_RECONCILIATION, ID, Errorlog) = False Then
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
