Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frm_rptLampiranA1
    Dim ErrorLog As clsError = Nothing
    Private Sub frm_rptLampiranA_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            e.Cancel = True
            Application.DoEvents()

            frmStartup.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub frm_rptLampiranA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Timer1.Enabled = True
            Timer1.Start()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadData()
        Try

            'SELECT TAX_COMPUTATION
            Dim dt As DataTable = mdlProcess.Load_Tax_Computation(mdlProcess.ArgParam2, mdlProcess.ArgParam3)

            If dt Is Nothing Then
                MsgBox("Report unsuccessfully generate. No Taxcomputation found.", MsgBoxStyle.Critical)
                Me.Close()
            End If

            'Call TempBalSecA
            TempValSecA()
            Application.DoEvents()
            TempAdjustedIncome()
            Application.DoEvents()
            TempAINonTaxableIncome()
            Application.DoEvents()
            TempAINonTaxableIncome()
            Application.DoEvents()

            Dim cryRpt As New ReportDocument
            Dim crConnectionInfo As New ConnectionInfo
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim CrTables As Tables
            Dim CrTable As Table

            cryRpt.Load(Application.StartupPath & "\LampiranA1.rpt")

            cryRpt.SetParameterValue("refNo", mdlProcess.ArgParam2)
            cryRpt.SetParameterValue("Tahun Taksiran", mdlProcess.ArgParam3)
            ' cryRpt.SetDatabaseLogon("sa", "azham91", "AZHAM-LAPTOP", "TAXCOM_C")


            'With crConnectionInfo
            '    .ServerName = "AZHAM-LAPTOP"
            '    .DatabaseName = "TAXCOM_C"
            '    .UserID = "sa"
            '    .Password = "azham91"

            'End With

            'CrTables = cryRpt.Database.Tables
            'For Each CrTable In CrTables
            '    crtableLogoninfo = CrTable.LogOnInfo
            '    crtableLogoninfo.ConnectionInfo = crConnectionInfo
            '    CrTable.ApplyLogOnInfo(crtableLogoninfo)
            'Next


            'Dim crParameterFieldDefinitions As ParameterFieldDefinitions
            'Dim crParameterFieldDefinition As ParameterFieldDefinition
            'Dim crParameterValues As New ParameterValues
            'Dim crParameterDiscreteValue As New ParameterDiscreteValue

            'crParameterDiscreteValue.Value = mdlProcess.ArgParam2
            'crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields
            'crParameterFieldDefinition = crParameterFieldDefinitions.Item("refNo")
            'crParameterValues = crParameterFieldDefinition.CurrentValues

            'crParameterValues.Clear()
            'crParameterValues.Add(crParameterDiscreteValue)
            'crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

            'crParameterDiscreteValue.Value = mdlProcess.ArgParam3
            'crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields
            'crParameterFieldDefinition = crParameterFieldDefinitions.Item("Tahun Taksiran")
            'crParameterValues = crParameterFieldDefinition.CurrentValues

            'crParameterValues.Add(crParameterDiscreteValue)
            'crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

            'cryRpt.Refresh()


            CRV.ReportSource = cryRpt
            CRV.Refresh()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TempAINonTaxableIncome()
        Try
            If mdlProcess.Delete_REPORT1_AI(ErrorLog) = False Then
                MsgBox("Failed to clear Report1 AI." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                Exit Sub
            End If

            Dim dtPNL As DataTable = Nothing
            Dim dtPNLDetails As DataTable = Nothing
            Dim Header As String = Nothing
            Dim NO As Integer = 0
            Dim RowIvt As Integer = 0
            dtPNL = mdlProcess.Load_PNL(mdlProcess.ArgParam2, mdlProcess.ArgParam3, ErrorLog)

            For i As Integer = 0 To dtPNL.Rows.Count - 1
                If dtPNL IsNot Nothing AndAlso IsDBNull(dtPNL.Rows(0)("PL_KEY")) = False Then
                    'Profit on Disposal of Fixed Assets =START =========================================
                    Header = "profit on disposal of fixed assets"
                    NO = 1
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AiNonTaxableIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report1_AI(IIf(IsDBNull(row("NTIDFA_KEY")), 0, row("NTIDFA_KEY")), NO, Header, IIf(IsDBNull(row("NTIDFA_NTIDFAKEY")), 0, row("NTIDFA_NTIDFAKEY")), _
                                                      IIf(IsDBNull(row("NTIDFA_SOURCENO")), 0, row("NTIDFA_SOURCENO")), IIf(IsDBNull(row("NTIDFA_DESC")), "", row("NTIDFA_DESC")), _
                                                      IIf(IsDBNull(row("NTIDFA_AMOUNT")), "0", row("NTIDFA_AMOUNT")), _
                                                      IIf(IsDBNull(row("NTIDFA_NOTE")), "", row("NTIDFA_NOTE")), IIf(IsDBNull(row("NTIDFA_DETAIL")), "", row("NTIDFA_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AiNonTaxableIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT1_AI_DETAIL(IIf(IsDBNull(row("NTIDFAD_KEY")), 0, row("NTIDFAD_KEY")), NO, IIf(IsDBNull(row("NTIDFAD_EXDEPKEY")), 0, row("NTIDFAD_EXDEPKEY")), _
                                                             IIf(IsDBNull(row("NTIDFAD_SOURCENO")), 0, row("NTIDFAD_SOURCENO")), IIf(IsDBNull(row("NTIDFAD_NTIDFADKEY")), 0, row("NTIDFAD_NTIDFADKEY")), _
                                                             IIf(IsDBNull(row("NTIDFAD_DESC")), 0, row("NTIDFAD_DESC")), IIf(IsDBNull(row("NTIDFAD_AMOUNT")), 0, row("NTIDFAD_AMOUNT")), _
                                                             IIf(IsDBNull(row("NTIDFAD_NOTE")), 0, row("NTIDFAD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Profit on Disposal of Fixed Assets =END =========================================
                    'Profit on Disposal of Investment =START =========================================
                    Header = "profit on disposal of investment"
                    NO = 2
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AiNonTaxableIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report1_AI(IIf(IsDBNull(row("NTIDI_KEY")), 0, row("NTIDI_KEY")), NO, Header, IIf(IsDBNull(row("NTIDI_NTIDIKEY")), 0, row("NTIDI_NTIDIKEY")), _
                                                      IIf(IsDBNull(row("NTIDI_SOURCENO")), 0, row("NTIDI_SOURCENO")), IIf(IsDBNull(row("NTIDI_DESC")), "", row("NTIDI_DESC")), _
                                                      IIf(IsDBNull(row("NTIDI_AMOUNT")), "0", row("NTIDI_AMOUNT")), _
                                                      IIf(IsDBNull(row("NTIDI_NOTE")), "", row("NTIDI_NOTE")), IIf(IsDBNull(row("NTIDI_DETAIL")), "", row("NTIDI_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AiNonTaxableIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT1_AI_DETAIL(IIf(IsDBNull(row("NTIDID_KEY")), 0, row("NTIDID_KEY")), NO, IIf(IsDBNull(row("NTIDID_NTIDIKEY")), 0, row("NTIDID_NTIDIKEY")), _
                                                             IIf(IsDBNull(row("NTIDID_SOURCENO")), 0, row("NTIDID_SOURCENO")), IIf(IsDBNull(row("NTIDID_NTIDIDKEY")), 0, row("NTIDID_NTIDIDKEY")), _
                                                             IIf(IsDBNull(row("NTIDID_DESC")), 0, row("NTIDID_DESC")), IIf(IsDBNull(row("NTIDID_AMOUNT")), 0, row("NTIDID_AMOUNT")), _
                                                             IIf(IsDBNull(row("NTIDID_NOTE")), 0, row("NTIDID_NOTE")), ErrorLog)
                        Next
                    End If
                    'Profit on Disposal of Investment =END =========================================
                    'Foreign Income Remittance =START =========================================
                    Header = "foreign income remittance"
                    NO = 3
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AiNonTaxableIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report1_AI(IIf(IsDBNull(row("NTIFIR_KEY")), 0, row("NTIFIR_KEY")), NO, Header, IIf(IsDBNull(row("NTIFIR_NTIFIRKEY")), 0, row("NTIFIR_NTIFIRKEY")), _
                                                      IIf(IsDBNull(row("NTIFIR_SOURCENO")), 0, row("NTIFIR_SOURCENO")), IIf(IsDBNull(row("NTIFIR_DESC")), "", row("NTIFIR_DESC")), _
                                                      IIf(IsDBNull(row("NTIFIR_AMOUNT")), "0", row("NTIFIR_AMOUNT")), _
                                                      IIf(IsDBNull(row("NTIFIR_NOTE")), "", row("NTIFIR_NOTE")), IIf(IsDBNull(row("NTIFIR_DETAIL")), "", row("NTIFIR_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AiNonTaxableIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT1_AI_DETAIL(IIf(IsDBNull(row("NTIFIRD_KEY")), 0, row("NTIFIRD_KEY")), NO, IIf(IsDBNull(row("NTIFIRD_NTIFIRKEY")), 0, row("NTIFIRD_NTIFIRKEY")), _
                                                             IIf(IsDBNull(row("NTIFIRD_SOURCENO")), 0, row("NTIFIRD_SOURCENO")), IIf(IsDBNull(row("NTIFIRD_NTIFIRDKEY")), 0, row("NTIFIRD_NTIFIRDKEY")), _
                                                             IIf(IsDBNull(row("NTIFIRD_DESC")), 0, row("NTIFIRD_DESC")), IIf(IsDBNull(row("NTIFIRD_AMOUNT")), 0, row("NTIFIRD_AMOUNT")), _
                                                             IIf(IsDBNull(row("NTIFIRD_NOTE")), 0, row("NTIFIRD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Foreign Income Remittance =END =========================================
                    'Realised Foregin Exchange Gain arising from Capital Transaction =START =========================================
                    Header = "realised foregin exchange gain arising from capital transaction"
                    NO = 4
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AiNonTaxableIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report1_AI(IIf(IsDBNull(row("NTIRFECT_KEY")), 0, row("NTIRFECT_KEY")), NO, Header, IIf(IsDBNull(row("NTIRFECT_NTIRFECTKEY")), 0, row("NTIRFECT_NTIRFECTKEY")), _
                                                      IIf(IsDBNull(row("NTIRFECT_SOURCENO")), 0, row("NTIRFECT_SOURCENO")), IIf(IsDBNull(row("NTIRFECT_DESC")), "", row("NTIRFECT_DESC")), _
                                                      IIf(IsDBNull(row("NTIRFECT_AMOUNT")), "0", row("NTIRFECT_AMOUNT")), _
                                                      IIf(IsDBNull(row("NTIRFECT_NOTE")), "", row("NTIRFECT_NOTE")), IIf(IsDBNull(row("NTIRFECT_DETAIL")), "", row("NTIRFECT_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AiNonTaxableIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT1_AI_DETAIL(IIf(IsDBNull(row("NTIRFECTD_KEY")), 0, row("NTIRFECTD_KEY")), NO, IIf(IsDBNull(row("NTIRFECTD_NTIRFECTKEY")), 0, row("NTIRFECTD_NTIRFECTKEY")), _
                                                             IIf(IsDBNull(row("NTIRFECTD_SOURCENO")), 0, row("NTIRFECTD_SOURCENO")), IIf(IsDBNull(row("NTIRFECTD_NTIRFECTDKEY")), 0, row("NTIRFECTD_NTIRFECTDKEY")), _
                                                             IIf(IsDBNull(row("NTIRFECTD_DESC")), 0, row("NTIRFECTD_DESC")), IIf(IsDBNull(row("NTIRFECTD_AMOUNT")), 0, row("NTIRFECTD_AMOUNT")), _
                                                             IIf(IsDBNull(row("NTIRFECTD_NOTE")), 0, row("NTIRFECTD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Realised Foregin Exchange Gain arising from Capital Transaction =END =========================================
                    'Unrealised Gain on Foreign Exchange - Trade =START =========================================
                    Header = "unrealised gain on foreign exchange - trade"
                    NO = 5
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AiNonTaxableIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report1_AI(IIf(IsDBNull(row("NTIUT_KEY")), 0, row("NTIUT_KEY")), NO, Header, IIf(IsDBNull(row("NTIUT_NTIUTKEY")), 0, row("NTIUT_NTIUTKEY")), _
                                                      IIf(IsDBNull(row("NTIUT_SOURCENO")), 0, row("NTIUT_SOURCENO")), IIf(IsDBNull(row("NTIUT_DESC")), "", row("NTIUT_DESC")), _
                                                      IIf(IsDBNull(row("NTIUT_AMOUNT")), "0", row("NTIUT_AMOUNT")), _
                                                      IIf(IsDBNull(row("NTIUT_NOTE")), "", row("NTIUT_NOTE")), IIf(IsDBNull(row("NTIUT_DETAIL")), "", row("NTIUT_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AiNonTaxableIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT1_AI_DETAIL(IIf(IsDBNull(row("NTIUTD_KEY")), 0, row("NTIUTD_KEY")), NO, IIf(IsDBNull(row("NTIUTD_NTIUTKEY")), 0, row("NTIUTD_NTIUTKEY")), _
                                                             IIf(IsDBNull(row("NTIUTD_SOURCENO")), 0, row("NTIUTD_SOURCENO")), IIf(IsDBNull(row("NTIUTD_NTIUTDKEY")), 0, row("NTIUTD_NTIUTDKEY")), _
                                                             IIf(IsDBNull(row("NTIUTD_DESC")), 0, row("NTIUTD_DESC")), IIf(IsDBNull(row("NTIUTD_AMOUNT")), 0, row("NTIUTD_AMOUNT")), _
                                                             IIf(IsDBNull(row("NTIUTD_NOTE")), 0, row("NTIUTD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Unrealised Gain on Foreign Exchange - Trade =END =========================================
                    'Unrealised Gain on Foreign Exchange - Non Trade =START =========================================
                    Header = "unrealised gain on foreign exchange - non trade"
                    NO = 6
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AiNonTaxableIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report1_AI(IIf(IsDBNull(row("NTIUNT_KEY")), 0, row("NTIUNT_KEY")), NO, Header, IIf(IsDBNull(row("NTIUNT_NTIUNTKEY")), 0, row("NTIUNT_NTIUNTKEY")), _
                                                      IIf(IsDBNull(row("NTIUNT_SOURCENO")), 0, row("NTIUNT_SOURCENO")), IIf(IsDBNull(row("NTIUNT_DESC")), "", row("NTIUNT_DESC")), _
                                                      IIf(IsDBNull(row("NTIUNT_AMOUNT")), "0", row("NTIUNT_AMOUNT")), _
                                                      IIf(IsDBNull(row("NTIUNT_NOTE")), "", row("NTIUNT_NOTE")), IIf(IsDBNull(row("NTIUNT_DETAIL")), "", row("NTIUNT_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AiNonTaxableIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT1_AI_DETAIL(IIf(IsDBNull(row("NTIUNTD_KEY")), 0, row("NTIUNTD_KEY")), NO, IIf(IsDBNull(row("NTIUNTD_NTIUNTKEY")), 0, row("NTIUNTD_NTIUNTKEY")), _
                                                             IIf(IsDBNull(row("NTIUNTD_SOURCENO")), 0, row("NTIUNTD_SOURCENO")), IIf(IsDBNull(row("NTIUNTD_NTIUNTDKEY")), 0, row("NTIUNTD_NTIUNTDKEY")), _
                                                             IIf(IsDBNull(row("NTIUNTD_DESC")), 0, row("NTIUNTD_DESC")), IIf(IsDBNull(row("NTIUNTD_AMOUNT")), 0, row("NTIUNTD_AMOUNT")), _
                                                             IIf(IsDBNull(row("NTIUNTD_NOTE")), 0, row("NTIUNTD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Unrealised Gain on Foreign Exchange - Non Trade =END =========================================
                    'Others =START =========================================
                    Header = "others"
                    NO = 7
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AiNonTaxableIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report1_AI(IIf(IsDBNull(row("NT_KEY")), 0, row("NT_KEY")), NO, Header, IIf(IsDBNull(row("NT_NTKEY")), 0, row("NT_NTKEY")), _
                                                      IIf(IsDBNull(row("NT_SOURCENO")), 0, row("NT_SOURCENO")), IIf(IsDBNull(row("NT_DESC")), "", row("NT_DESC")), _
                                                      IIf(IsDBNull(row("NT_AMOUNT")), "0", row("NT_AMOUNT")), _
                                                      IIf(IsDBNull(row("NT_NOTE")), "", row("NT_NOTE")), IIf(IsDBNull(row("NT_DETAIL")), "", row("NT_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AiNonTaxableIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT1_AI_DETAIL(IIf(IsDBNull(row("NTD_KEY")), 0, row("NTD_KEY")), NO, IIf(IsDBNull(row("NTD_NTKEY")), 0, row("NTD_NTKEY")), _
                                                             IIf(IsDBNull(row("NTD_SOURCENO")), 0, row("NTD_SOURCENO")), IIf(IsDBNull(row("NTD_NTDKEY")), 0, row("NTD_NTDKEY")), _
                                                             IIf(IsDBNull(row("NTD_DESC")), 0, row("NTD_DESC")), IIf(IsDBNull(row("NTD_AMOUNT")), 0, row("NTD_AMOUNT")), _
                                                             IIf(IsDBNull(row("NTD_NOTE")), 0, row("NTD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Others =END =========================================
                End If
            Next

        Catch ex As Exception
            MsgBox(System.Reflection.MethodBase.GetCurrentMethod().Name & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub TempAdjustedIncome()
        Try
            If mdlProcess.Delete_REPORT_AI(ErrorLog) = False Then
                MsgBox("Failed to clear Report AI." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                Exit Sub
            End If

            Dim dtPNL As DataTable = Nothing
            Dim dtPNLDetails As DataTable = Nothing
            Dim Header As String = Nothing
            Dim NO As Integer = 0
            Dim RowIvt As Integer = 0
            dtPNL = mdlProcess.Load_PNL(mdlProcess.ArgParam2, mdlProcess.ArgParam3, ErrorLog)

            For i As Integer = 0 To dtPNL.Rows.Count - 1
                If dtPNL IsNot Nothing AndAlso IsDBNull(dtPNL.Rows(0)("PL_KEY")) = False Then
                    'Production Cost - Depreciation =START =========================================
                    Header = "production cost - depreciation"
                    NO = 2
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXDEP_KEY")), 0, row("EXDEP_KEY")), NO, Header, IIf(IsDBNull(row("EXDEP_EXDEPKEY")), 0, row("EXDEP_EXDEPKEY")), _
                                                      IIf(IsDBNull(row("EXDEP_SOURCENO")), 0, row("EXDEP_SOURCENO")), IIf(IsDBNull(row("EXDEP_DESC")), "", row("EXDEP_DESC")), _
                                                      IIf(IsDBNull(row("EXDEP_AMOUNT")), "0", row("EXDEP_AMOUNT")), IIf(IsDBNull(row("EXDEP_DEDUCTIBLE")), "", row("EXDEP_DEDUCTIBLE")), _
                                                      IIf(IsDBNull(row("EXDEP_NOTE")), "", row("EXDEP_NOTE")), IIf(IsDBNull(row("EXDEP_DETAIL")), "", row("EXDEP_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXDEPD_KEY")), 0, row("EXDEPD_KEY")), NO, IIf(IsDBNull(row("EXDEPD_EXDEPKEY")), 0, row("EXDEPD_EXDEPKEY")), _
                                                             IIf(IsDBNull(row("EXDEPD_SOURCENO")), 0, row("EXDEPD_SOURCENO")), IIf(IsDBNull(row("EXDEPD_EXDEPDKEY")), 0, row("EXDEPD_EXDEPDKEY")), _
                                                             IIf(IsDBNull(row("EXDEPD_DESC")), 0, row("EXDEPD_DESC")), IIf(IsDBNull(row("EXDEPD_DEDUCTIBLE")), 0, row("EXDEPD_DEDUCTIBLE")), IIf(IsDBNull(row("EXDEPD_AMOUNT")), 0, row("EXDEPD_AMOUNT")), _
                                                             IIf(IsDBNull(row("EXDEPD_NOTE")), 0, row("EXDEPD_NOTE")), ErrorLog)
                        Next
                    End If


                    'Production Cost - Depreciation =END =========================================
                    'Production Cost - Other Non Allowable Expenses =START =========================================
                    Header = "production cost - other non allowable expenses"
                    NO = 3
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXNA_KEY")), 0, row("EXNA_KEY")), NO, Header, IIf(IsDBNull(row("EXNA_EXNAKEY")), 0, row("EXNA_EXNAKEY")), _
                                                      IIf(IsDBNull(row("EXNA_SOURCENO")), 0, row("EXNA_SOURCENO")), IIf(IsDBNull(row("EXNA_DESC")), "", row("EXNA_DESC")), _
                                                      IIf(IsDBNull(row("EXNA_AMOUNT")), "0", row("EXNA_AMOUNT")), IIf(IsDBNull(row("EXNA_DEDUCTIBLE")), "", row("EXNA_DEDUCTIBLE")), _
                                                      IIf(IsDBNull(row("EXNA_NOTE")), "", row("EXNA_NOTE")), IIf(IsDBNull(row("EXNA_DETAIL")), "", row("EXNA_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXNAD_KEY")), 0, row("EXNAD_KEY")), NO, IIf(IsDBNull(row("EXNAD_EXNAKEY")), 0, row("EXNAD_EXNAKEY")), _
                                                             IIf(IsDBNull(row("EXNAD_SOURCENO")), 0, row("EXNAD_SOURCENO")), IIf(IsDBNull(row("EXNAD_EXNADKEY")), 0, row("EXNAD_EXNADKEY")), _
                                                             IIf(IsDBNull(row("EXNAD_DESC")), "", row("EXNAD_DESC")), IIf(IsDBNull(row("EXNAD_DEDUCTIBLE")), 0, row("EXNAD_DEDUCTIBLE")), IIf(IsDBNull(row("EXNAD_AMOUNT")), 0, row("EXNAD_AMOUNT")), _
                                                             IIf(IsDBNull(row("EXNAD_NOTE")), 0, row("EXNAD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Production Cost - Other Non Allowable Expenses =END =========================================
                    'Expenses: Other Interest  =START =========================================
                    Header = "expenses: other interest"
                    NO = 5
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXI_KEY")), 0, row("EXI_KEY")), NO, Header, IIf(IsDBNull(row("EXI_EXIKEY")), 0, row("EXI_EXIKEY")), _
                                                      IIf(IsDBNull(row("EXI_SOURCENO")), 0, row("EXI_SOURCENO")), IIf(IsDBNull(row("EXI_DESC")), "", row("EXI_DESC")), _
                                                      IIf(IsDBNull(row("EXI_AMOUNT")), "0", row("EXI_AMOUNT")), IIf(IsDBNull(row("EXI_DEDUCTIBLE")), "", row("EXI_DEDUCTIBLE")), _
                                                      IIf(IsDBNull(row("EXI_NOTE")), "", row("EXI_NOTE")), IIf(IsDBNull(row("EXI_DETAIL")), "", row("EXI_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXID_KEY")), 0, row("EXID_KEY")), NO, IIf(IsDBNull(row("EXID_EXIKEY")), 0, row("EXID_EXIKEY")), _
                                                             IIf(IsDBNull(row("EXID_SOURCENO")), 0, row("EXID_SOURCENO")), IIf(IsDBNull(row("EXID_EXIDKEY")), 0, row("EXID_EXIDKEY")), _
                                                             IIf(IsDBNull(row("EXID_DESC")), "", row("EXID_DESC")), IIf(IsDBNull(row("EXID_DEDUCTIBLE")), 0, row("EXID_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXID_AMOUNT")), 0, row("EXID_AMOUNT")), IIf(IsDBNull(row("EXID_NOTE")), 0, row("EXID_NOTE")), ErrorLog)
                        Next
                    End If
                    'Expenses: Other Interest  =END =========================================
                    'expenses: professional, technical, managament & legal fees   =START =========================================
                    Header = "expenses: professional, technical, managament & legal fees"
                    NO = 6
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXL_KEY")), 0, row("EXL_KEY")), NO, Header, IIf(IsDBNull(row("EXL_EXLKEY")), 0, row("EXL_EXLKEY")), _
                                                      IIf(IsDBNull(row("EXL_SOURCENO")), 0, row("EXL_SOURCENO")), IIf(IsDBNull(row("EXL_DESC")), "", row("EXL_DESC")), _
                                                      IIf(IsDBNull(row("EXL_AMOUNT")), "0", row("EXL_AMOUNT")), IIf(IsDBNull(row("EXL_DEDUCTIBLE")), "", row("EXL_DEDUCTIBLE")), _
                                                      IIf(IsDBNull(row("EXL_NOTE")), "", row("EXL_NOTE")), IIf(IsDBNull(row("EXL_DETAIL")), "", row("EXL_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXLD_KEY")), 0, row("EXLD_KEY")), NO, IIf(IsDBNull(row("EXLD_EXLKEY")), 0, row("EXLD_EXLKEY")), _
                                                             IIf(IsDBNull(row("EXLD_SOURCENO")), 0, row("EXLD_SOURCENO")), IIf(IsDBNull(row("EXLD_EXLDKEY")), 0, row("EXLD_EXLDKEY")), _
                                                             IIf(IsDBNull(row("EXLD_DESC")), "", row("EXLD_DESC")), IIf(IsDBNull(row("EXLD_DEDUCTIBLE")), 0, row("EXLD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXLD_AMOUNT")), 0, row("EXLD_AMOUNT")), IIf(IsDBNull(row("EXLD_NOTE")), 0, row("EXLD_NOTE")), ErrorLog)
                        Next
                    End If
                    'expenses: professional, technical, managament & legal fees   =END =========================================
                    'Expenses: Contract Payment   =START =========================================
                    Header = "expenses: contract payment"
                    NO = 7
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXC_KEY")), 0, row("EXC_KEY")), NO, Header, IIf(IsDBNull(row("EXC_EXCKEY")), 0, row("EXC_EXCKEY")), _
                                                      IIf(IsDBNull(row("EXC_SOURCENO")), 0, row("EXC_SOURCENO")), IIf(IsDBNull(row("EXC_DESC")), "", row("EXC_DESC")), _
                                                      IIf(IsDBNull(row("EXC_AMOUNT")), "0", row("EXC_AMOUNT")), IIf(IsDBNull(row("EXC_DEDUCTIBLE")), "", row("EXC_DEDUCTIBLE")), _
                                                      IIf(IsDBNull(row("EXC_NOTE")), "", row("EXC_NOTE")), IIf(IsDBNull(row("EXC_DETAIL")), "", row("EXC_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXCD_KEY")), 0, row("EXCD_KEY")), NO, IIf(IsDBNull(row("EXCD_EXCKEY")), 0, row("EXCD_EXCKEY")), _
                                                             IIf(IsDBNull(row("EXCD_SOURCENO")), 0, row("EXCD_SOURCENO")), IIf(IsDBNull(row("EXCD_EXCDKEY")), 0, row("EXCD_EXCDKEY")), _
                                                             IIf(IsDBNull(row("EXCD_DESC")), "", row("EXCD_DESC")), IIf(IsDBNull(row("EXCD_DEDUCTIBLE")), 0, row("EXCD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXCD_AMOUNT")), 0, row("EXCD_AMOUNT")), IIf(IsDBNull(row("EXCD_NOTE")), 0, row("EXCD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Expenses: Contract Payment   =END =========================================
                    'Expenses: Salary   =START =========================================
                    Header = "expenses: salary"
                    NO = 8
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXS_KEY")), 0, row("EXS_KEY")), NO, Header, IIf(IsDBNull(row("EXS_EXSKEY")), 0, row("EXS_EXSKEY")), _
                                                      IIf(IsDBNull(row("EXS_SOURCENO")), 0, row("EXS_SOURCENO")), IIf(IsDBNull(row("EXS_DESC")), "", row("EXS_DESC")), _
                                                      IIf(IsDBNull(row("EXS_AMOUNT")), "0", row("EXS_AMOUNT")), IIf(IsDBNull(row("EXS_DEDUCTIBLE")), "", row("EXS_DEDUCTIBLE")), _
                                                      IIf(IsDBNull(row("EXS_NOTE")), "", row("EXS_NOTE")), IIf(IsDBNull(row("EXS_DETAIL")), "", row("EXS_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXSD_KEY")), 0, row("EXSD_KEY")), NO, IIf(IsDBNull(row("EXSD_EXSKEY")), 0, row("EXSD_EXSKEY")), _
                                                             IIf(IsDBNull(row("EXSD_SOURCENO")), 0, row("EXSD_SOURCENO")), IIf(IsDBNull(row("EXSD_EXSDKEY")), 0, row("EXSD_EXSDKEY")), _
                                                             IIf(IsDBNull(row("EXSD_DESC")), "", row("EXSD_DESC")), IIf(IsDBNull(row("EXSD_DEDUCTIBLE")), 0, row("EXSD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXSD_AMOUNT")), 0, row("EXSD_AMOUNT")), IIf(IsDBNull(row("EXSD_NOTE")), 0, row("EXSD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Expenses: Salary   =END =========================================
                    'Expenses: Royalty   =START =========================================
                    Header = "expenses: royalty"
                    NO = 9
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXRO_KEY")), 0, row("EXRO_KEY")), NO, Header, IIf(IsDBNull(row("EXRO_EXROKEY")), 0, row("EXRO_EXROKEY")), _
                                                      IIf(IsDBNull(row("EXRO_SOURCENO")), 0, row("EXRO_SOURCENO")), IIf(IsDBNull(row("EXRO_DESC")), "", row("EXRO_DESC")), _
                                                      IIf(IsDBNull(row("EXRO_AMOUNT")), "0", row("EXRO_AMOUNT")), IIf(IsDBNull(row("EXRO_DEDUCTIBLE")), "", row("EXRO_DEDUCTIBLE")), _
                                                      IIf(IsDBNull(row("EXRO_NOTE")), "", row("EXRO_NOTE")), IIf(IsDBNull(row("EXRO_DETAIL")), "", row("EXRO_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXROD_KEY")), 0, row("EXROD_KEY")), NO, IIf(IsDBNull(row("EXROD_EXROKEY")), 0, row("EXROD_EXROKEY")), _
                                                             IIf(IsDBNull(row("EXROD_SOURCENO")), 0, row("EXROD_SOURCENO")), IIf(IsDBNull(row("EXROD_EXRODKEY")), 0, row("EXROD_EXRODKEY")), _
                                                             IIf(IsDBNull(row("EXROD_DESC")), "", row("EXROD_DESC")), IIf(IsDBNull(row("EXROD_DEDUCTIBLE")), 0, row("EXROD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXROD_AMOUNT")), 0, row("EXROD_AMOUNT")), IIf(IsDBNull(row("EXROD_NOTE")), 0, row("EXROD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Expenses: Royalty   =END =========================================
                    'Expenses: Rental   =START =========================================
                    Header = "expenses: rental"
                    NO = 10
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXRENT_KEY")), 0, row("EXRENT_KEY")), NO, Header, IIf(IsDBNull(row("EXRENT_EXRENTKEY")), 0, row("EXRENT_EXRENTKEY")), _
                                                      IIf(IsDBNull(row("EXRENT_SOURCENO")), 0, row("EXRENT_SOURCENO")), IIf(IsDBNull(row("EXRENT_DESC")), "", row("EXRENT_DESC")), _
                                                      IIf(IsDBNull(row("EXRENT_AMOUNT")), "0", row("EXRENT_AMOUNT")), IIf(IsDBNull(row("EXRENT_DEDUCTIBLE")), "", row("EXRENT_DEDUCTIBLE")), _
                                                      IIf(IsDBNull(row("EXRENT_NOTE")), "", row("EXRENT_NOTE")), IIf(IsDBNull(row("EXRENT_DETAIL")), "", row("EXRENT_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXRENTD_KEY")), 0, row("EXRENTD_KEY")), NO, IIf(IsDBNull(row("EXRENTD_EXRENTKEY")), 0, row("EXRENTD_EXRENTKEY")), _
                                                             IIf(IsDBNull(row("EXRENTD_SOURCENO")), 0, row("EXRENTD_SOURCENO")), IIf(IsDBNull(row("EXRENTD_EXRENTDKEY")), 0, row("EXRENTD_EXRENTDKEY")), _
                                                             IIf(IsDBNull(row("EXRENTD_DESC")), "", row("EXRENTD_DESC")), IIf(IsDBNull(row("EXRENTD_DEDUCTIBLE")), 0, row("EXRENTD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXRENTD_AMOUNT")), 0, row("EXRENTD_AMOUNT")), IIf(IsDBNull(row("EXRENTD_NOTE")), 0, row("EXRENTD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Expenses: Rental   =END =========================================
                    'Expenses: Repair & Maintenance   =START =========================================
                    Header = "expenses: repair & maintenance"
                    NO = 11
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXREP_KEY")), 0, row("EXREP_KEY")), NO, Header, IIf(IsDBNull(row("EXREP_EXREPKEY")), 0, row("EXREP_EXREPKEY")), _
                                                      IIf(IsDBNull(row("EXREP_SOURCENO")), 0, row("EXREP_SOURCENO")), IIf(IsDBNull(row("EXREP_DESC")), "", row("EXREP_DESC")), _
                                                      IIf(IsDBNull(row("EXREP_AMOUNT")), "0", row("EXREP_AMOUNT")), IIf(IsDBNull(row("EXREP_DEDUCTIBLE")), "", row("EXREP_DEDUCTIBLE")), _
                                                      IIf(IsDBNull(row("EXREP_NOTE")), "", row("EXREP_NOTE")), IIf(IsDBNull(row("EXREP_DETAIL")), "", row("EXREP_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXREPD_KEY")), 0, row("EXREPD_KEY")), NO, IIf(IsDBNull(row("EXREPD_EXREPKEY")), 0, row("EXREPD_EXREPKEY")), _
                                                             IIf(IsDBNull(row("EXREPD_SOURCENO")), 0, row("EXREPD_SOURCENO")), IIf(IsDBNull(row("EXREPD_EXREPDKEY")), 0, row("EXREPD_EXREPDKEY")), _
                                                             IIf(IsDBNull(row("EXREPD_DESC")), "", row("EXREPD_DESC")), IIf(IsDBNull(row("EXREPD_DEDUCTIBLE")), 0, row("EXREPD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXREPD_AMOUNT")), 0, row("EXREPD_AMOUNT")), IIf(IsDBNull(row("EXREPD_NOTE")), 0, row("EXREPD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Expenses: Repair & Maintenance   =END =========================================
                    'Expenses: Research & Development   =START =========================================
                    Header = "expenses: research & development"
                    NO = 12
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXRES_KEY")), 0, row("EXRES_KEY")), NO, Header, IIf(IsDBNull(row("EXRES_EXRESKEY")), 0, row("EXRES_EXRESKEY")), _
                                                      IIf(IsDBNull(row("EXRES_SOURCENO")), 0, row("EXRES_SOURCENO")), IIf(IsDBNull(row("EXRES_DESC")), "", row("EXRES_DESC")), _
                                                      IIf(IsDBNull(row("EXRES_AMOUNT")), "0", row("EXRES_AMOUNT")), IIf(IsDBNull(row("EXRES_DEDUCTIBLE")), "", row("EXRES_DEDUCTIBLE")), _
                                                      IIf(IsDBNull(row("EXRES_NOTE")), "", row("EXRES_NOTE")), IIf(IsDBNull(row("EXRES_DETAIL")), "", row("EXRES_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXRESD_KEY")), 0, row("EXRESD_KEY")), NO, IIf(IsDBNull(row("EXRESD_EXRESKEY")), 0, row("EXRESD_EXRESKEY")), _
                                                             IIf(IsDBNull(row("EXRESD_SOURCENO")), 0, row("EXRESD_SOURCENO")), IIf(IsDBNull(row("EXRESD_EXRESDKEY")), 0, row("EXRESD_EXRESDKEY")), _
                                                             IIf(IsDBNull(row("EXRESD_DESC")), "", row("EXRESD_DESC")), IIf(IsDBNull(row("EXRESD_DEDUCTIBLE")), 0, row("EXRESD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXRESD_AMOUNT")), 0, row("EXRESD_AMOUNT")), IIf(IsDBNull(row("EXRESD_NOTE")), 0, row("EXRESD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Expenses: Research & Development   =END =========================================
                    'Expenses: Promotion & Advertisement   =START =========================================
                    Header = "expenses: promotion & advertisement"
                    NO = 13
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXP_KEY")), 0, row("EXP_KEY")), NO, Header, IIf(IsDBNull(row("EXP_EXPKEY")), 0, row("EXP_EXPKEY")), _
                                                      IIf(IsDBNull(row("EXP_SOURCENO")), 0, row("EXP_SOURCENO")), IIf(IsDBNull(row("EXP_DESC")), "", row("EXP_DESC")), _
                                                      IIf(IsDBNull(row("EXP_AMOUNT")), "0", row("EXP_AMOUNT")), IIf(IsDBNull(row("EXP_DEDUCTIBLE")), "", row("EXP_DEDUCTIBLE")), _
                                                      IIf(IsDBNull(row("EXP_NOTE")), "", row("EXP_NOTE")), IIf(IsDBNull(row("EXP_DETAIL")), "", row("EXP_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXPD_KEY")), 0, row("EXPD_KEY")), NO, IIf(IsDBNull(row("EXPD_EXPKEY")), 0, row("EXPD_EXPKEY")), _
                                                             IIf(IsDBNull(row("EXPD_SOURCENO")), 0, row("EXPD_SOURCENO")), IIf(IsDBNull(row("EXPD_EXPDKEY")), 0, row("EXPD_EXPDKEY")), _
                                                             IIf(IsDBNull(row("EXPD_DESC")), "", row("EXPD_DESC")), IIf(IsDBNull(row("EXPD_DEDUCTIBLE")), 0, row("EXPD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXPD_AMOUNT")), 0, row("EXPD_AMOUNT")), IIf(IsDBNull(row("EXPD_NOTE")), 0, row("EXPD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Expenses: Promotion & Advertisement   =END =========================================
                    'Expenses: Travelling and Accommodation   =START =========================================
                    Header = "expenses: travelling and accommodation"
                    NO = 14
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXT_KEY")), 0, row("EXT_KEY")), NO, Header, IIf(IsDBNull(row("EXT_EXTKEY")), 0, row("EXT_EXTKEY")), _
                                                      IIf(IsDBNull(row("EXT_SOURCENO")), 0, row("EXT_SOURCENO")), IIf(IsDBNull(row("EXT_DESC")), "", row("EXT_DESC")), _
                                                      IIf(IsDBNull(row("EXT_AMOUNT")), "0", row("EXT_AMOUNT")), IIf(IsDBNull(row("EXT_DEDUCTIBLE")), "", row("EXT_DEDUCTIBLE")), _
                                                      IIf(IsDBNull(row("EXT_NOTE")), "", row("EXT_NOTE")), IIf(IsDBNull(row("EXT_DETAIL")), "", row("EXT_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXTD_KEY")), 0, row("EXTD_KEY")), NO, IIf(IsDBNull(row("EXTD_EXTKEY")), 0, row("EXTD_EXTKEY")), _
                                                             IIf(IsDBNull(row("EXTD_SOURCENO")), 0, row("EXTD_SOURCENO")), IIf(IsDBNull(row("EXTD_EXTDKEY")), 0, row("EXTD_EXTDKEY")), _
                                                             IIf(IsDBNull(row("EXTD_DESC")), "", row("EXTD_DESC")), IIf(IsDBNull(row("EXTD_DEDUCTIBLE")), 0, row("EXTD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXTD_AMOUNT")), 0, row("EXTD_AMOUNT")), IIf(IsDBNull(row("EXTD_NOTE")), 0, row("EXTD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Expenses: Travelling and Accommodation   =END =========================================
                    'Other Expenses: Depreciation   =START =========================================
                    Header = "other expenses: depreciation"
                    NO = 15
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXODEP_KEY")), 0, row("EXODEP_KEY")), NO, Header, IIf(IsDBNull(row("EXODEP_EXODEPKEY")), 0, row("EXODEP_EXODEPKEY")), _
                                                      IIf(IsDBNull(row("EXODEP_SOURCENO")), 0, row("EXODEP_SOURCENO")), IIf(IsDBNull(row("EXODEP_DESC")), "", row("EXODEP_DESC")), _
                                                      IIf(IsDBNull(row("EXODEP_AMOUNT")), "0", row("EXODEP_AMOUNT")), IIf(IsDBNull(row("EXODEP_DEDUCTIBLE")), "", row("EXODEP_DEDUCTIBLE")), _
                                                      IIf(IsDBNull(row("EXODEP_NOTE")), "", row("EXODEP_NOTE")), IIf(IsDBNull(row("EXODEP_DETAIL")), "", row("EXODEP_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXODEPD_KEY")), 0, row("EXODEPD_KEY")), NO, IIf(IsDBNull(row("EXODEPD_EXODEPKEY")), 0, row("EXODEPD_EXODEPKEY")), _
                                                             IIf(IsDBNull(row("EXODEPD_SOURCENO")), 0, row("EXODEPD_SOURCENO")), IIf(IsDBNull(row("EXODEPD_EXODEPDKEY")), 0, row("EXODEPD_EXODEPDKEY")), _
                                                             IIf(IsDBNull(row("EXODEPD_DESC")), "", row("EXODEPD_DESC")), IIf(IsDBNull(row("EXODEPD_DEDUCTIBLE")), 0, row("EXODEPD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXODEPD_AMOUNT")), 0, row("EXODEPD_AMOUNT")), IIf(IsDBNull(row("EXODEPD_NOTE")), 0, row("EXODEPD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Other Expenses: Depreciation   =END =========================================
                    'Other Expenses: Donation - Approved   =START =========================================
                    Header = "other expenses: donation - approved"
                    NO = 16
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXOAD_KEY")), 0, row("EXOAD_KEY")), NO, Header, IIf(IsDBNull(row("EXOAD_EXOADKEY")), 0, row("EXOAD_EXOADKEY")), _
                                                      IIf(IsDBNull(row("EXOAD_SOURCENO")), 0, row("EXOAD_SOURCENO")), IIf(IsDBNull(row("EXOAD_DESC")), "", row("EXOAD_DESC")), _
                                                      IIf(IsDBNull(row("EXOAD_AMOUNT")), "0", row("EXOAD_AMOUNT")), IIf(IsDBNull(row("EXOAD_DEDUCTIBLE")), "", row("EXOAD_DEDUCTIBLE")), _
                                                      IIf(IsDBNull(row("EXOAD_NOTE")), "", row("EXOAD_NOTE")), IIf(IsDBNull(row("EXOAD_DETAIL")), "", row("EXOAD_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXOADD_KEY")), 0, row("EXOADD_KEY")), NO, IIf(IsDBNull(row("EXOADD_EXOADKEY")), 0, row("EXOADD_EXOADKEY")), _
                                                             IIf(IsDBNull(row("EXOADD_SOURCENO")), 0, row("EXOADD_SOURCENO")), IIf(IsDBNull(row("EXOADD_EXOADDKEY")), 0, row("EXOADD_EXOADDKEY")), _
                                                             IIf(IsDBNull(row("EXOADD_DESC")), "", row("EXOADD_DESC")), IIf(IsDBNull(row("EXOADD_DEDUCTIBLE")), 0, row("EXOADD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXOADD_AMOUNT")), 0, row("EXOADD_AMOUNT")), IIf(IsDBNull(row("EXOADD_NOTE")), 0, row("EXOADD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Other Expenses: Donation - Approved   =END =========================================
                    'Other Expenses: Donation - Non Approved   =START =========================================
                    Header = "other expenses: donation - non approved"
                    NO = 17
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXONAD_KEY")), 0, row("EXONAD_KEY")), NO, Header, IIf(IsDBNull(row("EXONAD_EXONADKEY")), 0, row("EXONAD_EXONADKEY")), _
                                                      IIf(IsDBNull(row("EXONAD_SOURCENO")), 0, row("EXONAD_SOURCENO")), IIf(IsDBNull(row("EXONAD_DESC")), "", row("EXONAD_DESC")), _
                                                      IIf(IsDBNull(row("EXONAD_AMOUNT")), "0", row("EXONAD_AMOUNT")), IIf(IsDBNull(row("EXONAD_DEDUCTIBLE")), "", row("EXONAD_DEDUCTIBLE")), _
                                                      IIf(IsDBNull(row("EXONAD_NOTE")), "", row("EXONAD_NOTE")), IIf(IsDBNull(row("EXONAD_DETAIL")), "", row("EXONAD_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXONADD_KEY")), 0, row("EXONADD_KEY")), NO, IIf(IsDBNull(row("EXONADD_EXONADKEY")), 0, row("EXONADD_EXONADKEY")), _
                                                             IIf(IsDBNull(row("EXONADD_SOURCENO")), 0, row("EXONADD_SOURCENO")), IIf(IsDBNull(row("EXONADD_EXONADDKEY")), 0, row("EXONADD_EXONADDKEY")), _
                                                             IIf(IsDBNull(row("EXONADD_DESC")), "", row("EXONADD_DESC")), IIf(IsDBNull(row("EXONADD_DEDUCTIBLE")), 0, row("EXONADD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXONADD_AMOUNT")), 0, row("EXONADD_AMOUNT")), IIf(IsDBNull(row("EXONADD_NOTE")), 0, row("EXONADD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Other Expenses: Donation - Non Approved   =END =========================================
                    'Other Expenses: Zakat   =START =========================================
                    Header = "other expenses: zakat"
                    NO = 18
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXOZ_KEY")), 0, row("EXOZ_KEY")), NO, Header, IIf(IsDBNull(row("EXOZ_EXOZKEY")), 0, row("EXOZ_EXOZKEY")), _
                                                      IIf(IsDBNull(row("EXOZ_SOURCENO")), 0, row("EXOZ_SOURCENO")), IIf(IsDBNull(row("EXOZ_DESC")), "", row("EXOZ_DESC")), _
                                                      IIf(IsDBNull(row("EXOZ_AMOUNT")), "0", row("EXOZ_AMOUNT")), IIf(IsDBNull(row("EXOZ_DEDUCTIBLE")), "", row("EXOZ_DEDUCTIBLE")), _
                                                      IIf(IsDBNull(row("EXOZ_NOTE")), "", row("EXOZ_NOTE")), IIf(IsDBNull(row("EXOZ_DETAIL")), "", row("EXOZ_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXOZD_KEY")), 0, row("EXOZD_KEY")), NO, IIf(IsDBNull(row("EXOZD_EXOZKEY")), 0, row("EXOZD_EXOZKEY")), _
                                                             IIf(IsDBNull(row("EXOZD_SOURCENO")), 0, row("EXOZD_SOURCENO")), IIf(IsDBNull(row("EXOZD_EXOZDKEY")), 0, row("EXOZD_EXOZDKEY")), _
                                                             IIf(IsDBNull(row("EXOZD_DESC")), "", row("EXOZD_DESC")), IIf(IsDBNull(row("EXOZD_DEDUCTIBLE")), 0, row("EXOZD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXOZD_AMOUNT")), 0, row("EXOZD_AMOUNT")), IIf(IsDBNull(row("EXOZD_NOTE")), 0, row("EXOZD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Other Expenses: Zakat   =END =========================================
                    'Other Expenses: Entertainment - Non Staff   =START =========================================
                    Header = "other expenses: entertainment - non staff"
                    NO = 19
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXOENS_KEY")), 0, row("EXOENS_KEY")), NO, Header, IIf(IsDBNull(row("EXOENS_EXOENSKEY")), 0, row("EXOENS_EXOENSKEY")), _
                                                      IIf(IsDBNull(row("EXOENS_SOURCENO")), 0, row("EXOENS_SOURCENO")), IIf(IsDBNull(row("EXOENS_DESC")), "", row("EXOENS_DESC")), _
                                                      IIf(IsDBNull(row("EXOENS_AMOUNT")), "0", row("EXOENS_AMOUNT")), IIf(IsDBNull(row("EXOENS_DEDUCTIBLE")), "", row("EXOENS_DEDUCTIBLE")), _
                                                      IIf(IsDBNull(row("EXOENS_NOTE")), "", row("EXOENS_NOTE")), IIf(IsDBNull(row("EXOENS_DETAIL")), "", row("EXOENS_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXOENSD_KEY")), 0, row("EXOENSD_KEY")), NO, IIf(IsDBNull(row("EXOENSD_EXOENSKEY")), 0, row("EXOENSD_EXOENSKEY")), _
                                                             IIf(IsDBNull(row("EXOENSD_SOURCENO")), 0, row("EXOENSD_SOURCENO")), IIf(IsDBNull(row("EXOENSD_EXOENSDKEY")), 0, row("EXOENSD_EXOENSDKEY")), _
                                                             IIf(IsDBNull(row("EXOENSD_DESC")), "", row("EXOENSD_DESC")), IIf(IsDBNull(row("EXOENSD_DEDUCTIBLE")), 0, row("EXOENSD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXOENSD_AMOUNT")), 0, row("EXOENSD_AMOUNT")), IIf(IsDBNull(row("EXOENSD_NOTE")), 0, row("EXOENSD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Other Expenses: Entertainment - Non Staff   =END =========================================
                    'Other Expenses: Entertainment - Staff   =START =========================================
                    Header = "other expenses: entertainment - staff"
                    NO = 20
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXOES_KEY")), 0, row("EXOES_KEY")), NO, Header, IIf(IsDBNull(row("EXOES_EXOESKEY")), 0, row("EXOES_EXOESKEY")), _
                                                      IIf(IsDBNull(row("EXOES_SOURCENO")), 0, row("EXOES_SOURCENO")), IIf(IsDBNull(row("EXOES_DESC")), "", row("EXOES_DESC")), _
                                                      IIf(IsDBNull(row("EXOES_AMOUNT")), "0", row("EXOES_AMOUNT")), IIf(IsDBNull(row("EXOES_DEDUCTIBLE")), "", row("EXOES_DEDUCTIBLE")), _
                                                      IIf(IsDBNull(row("EXOES_NOTE")), "", row("EXOES_NOTE")), IIf(IsDBNull(row("EXOES_DETAIL")), "", row("EXOES_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXOESD_KEY")), 0, row("EXOESD_KEY")), NO, IIf(IsDBNull(row("EXOESD_EXOESKEY")), 0, row("EXOESD_EXOESKEY")), _
                                                             IIf(IsDBNull(row("EXOESD_SOURCENO")), 0, row("EXOESD_SOURCENO")), IIf(IsDBNull(row("EXOESD_EXOESDKEY")), 0, row("EXOESD_EXOESDKEY")), _
                                                             IIf(IsDBNull(row("EXOESD_DESC")), "", row("EXOESD_DESC")), IIf(IsDBNull(row("EXOESD_DEDUCTIBLE")), 0, row("EXOESD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXOESD_AMOUNT")), 0, row("EXOESD_AMOUNT")), IIf(IsDBNull(row("EXOESD_NOTE")), 0, row("EXOESD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Other Expenses: Entertainment - Staff   =END =========================================
                    'Other Expenses: Compound/Penalty   =START =========================================
                    Header = "other expenses: compound/penalty"
                    NO = 21
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXOP_KEY")), 0, row("EXOP_KEY")), NO, Header, IIf(IsDBNull(row("EXOP_EXOPKEY")), 0, row("EXOP_EXOPKEY")), _
                                                      IIf(IsDBNull(row("EXOP_SOURCENO")), 0, row("EXOP_SOURCENO")), IIf(IsDBNull(row("EXOP_DESC")), "", row("EXOP_DESC")), _
                                                      IIf(IsDBNull(row("EXOP_AMOUNT")), "0", row("EXOP_AMOUNT")), IIf(IsDBNull(row("EXOP_DEDUCTIBLE")), "", row("EXOP_DEDUCTIBLE")), _
                                                       IIf(IsDBNull(row("EXOP_NOTE")), "", row("EXOP_NOTE")), IIf(IsDBNull(row("EXOP_DETAIL")), "", row("EXOP_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXOPD_KEY")), 0, row("EXOPD_KEY")), NO, IIf(IsDBNull(row("EXOPD_EXOPKEY")), 0, row("EXOPD_EXOPKEY")), _
                                                             IIf(IsDBNull(row("EXOPD_SOURCENO")), 0, row("EXOPD_SOURCENO")), IIf(IsDBNull(row("EXOPD_EXOPDKEY")), 0, row("EXOPD_EXOPDKEY")), _
                                                             IIf(IsDBNull(row("EXOPD_DESC")), "", row("EXOPD_DESC")), IIf(IsDBNull(row("EXOPD_DEDUCTIBLE")), 0, row("EXOPD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXOPD_AMOUNT")), 0, row("EXOPD_AMOUNT")), IIf(IsDBNull(row("EXOPD_NOTE")), 0, row("EXOPD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Other Expenses: Compound/Penalty   =END =========================================
                    'Other Expenses: Provision Account   =START =========================================
                    Header = "other expenses: provision account"
                    NO = 22
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXOPA_KEY")), 0, row("EXOPA_KEY")), NO, Header, IIf(IsDBNull(row("EXOPA_EXOPAKEY")), 0, row("EXOPA_EXOPAKEY")), _
                                                      IIf(IsDBNull(row("EXOPA_SOURCENO")), 0, row("EXOPA_SOURCENO")), IIf(IsDBNull(row("EXOPA_DESC")), "", row("EXOPA_DESC")), _
                                                      IIf(IsDBNull(row("EXOPA_AMOUNT")), "0", row("EXOPA_AMOUNT")), IIf(IsDBNull(row("EXOPA_DEDUCTIBLE")), "", row("EXOPA_DEDUCTIBLE")), _
                                                       IIf(IsDBNull(row("EXOPA_NOTE")), "", row("EXOPA_NOTE")), IIf(IsDBNull(row("EXOPA_DETAIL")), "", row("EXOPA_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXOPAD_KEY")), 0, row("EXOPAD_KEY")), NO, IIf(IsDBNull(row("EXOPAD_EXOPAKEY")), 0, row("EXOPAD_EXOPAKEY")), _
                                                             IIf(IsDBNull(row("EXOPAD_SOURCENO")), 0, row("EXOPAD_SOURCENO")), IIf(IsDBNull(row("EXOPAD_EXOPADKEY")), 0, row("EXOPAD_EXOPADKEY")), _
                                                             IIf(IsDBNull(row("EXOPAD_DESC")), "", row("EXOPAD_DESC")), IIf(IsDBNull(row("EXOPAD_DEDUCTIBLE")), 0, row("EXOPAD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXOPAD_AMOUNT")), 0, row("EXOPAD_AMOUNT")), IIf(IsDBNull(row("EXOPAD_NOTE")), 0, row("EXOPAD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Other Expenses: Provision Account =END =========================================
                    'Other Expenses: Leave Passage   =START =========================================
                    Header = "other expenses: leave passage"
                    NO = 23
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXOLP_KEY")), 0, row("EXOLP_KEY")), NO, Header, IIf(IsDBNull(row("EXOLP_EXOLPKEY")), 0, row("EXOLP_EXOLPKEY")), _
                                                      IIf(IsDBNull(row("EXOLP_SOURCENO")), 0, row("EXOLP_SOURCENO")), IIf(IsDBNull(row("EXOLP_DESC")), "", row("EXOLP_DESC")), _
                                                      IIf(IsDBNull(row("EXOLP_AMOUNT")), "0", row("EXOLP_AMOUNT")), IIf(IsDBNull(row("EXOLP_DEDUCTIBLE")), "", row("EXOLP_DEDUCTIBLE")), _
                                                       IIf(IsDBNull(row("EXOLP_NOTE")), "", row("EXOLP_NOTE")), IIf(IsDBNull(row("EXOLP_DETAIL")), "", row("EXOLP_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXOLPD_KEY")), 0, row("EXOLPD_KEY")), NO, IIf(IsDBNull(row("EXOLPD_EXOLPKEY")), 0, row("EXOLPD_EXOLPKEY")), _
                                                             IIf(IsDBNull(row("EXOLPD_SOURCENO")), 0, row("EXOLPD_SOURCENO")), IIf(IsDBNull(row("EXOLPD_EXOLPDKEY")), 0, row("EXOLPD_EXOLPDKEY")), _
                                                             IIf(IsDBNull(row("EXOLPD_DESC")), "", row("EXOLPD_DESC")), IIf(IsDBNull(row("EXOLPD_DEDUCTIBLE")), 0, row("EXOLPD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXOLPD_AMOUNT")), 0, row("EXOLPD_AMOUNT")), IIf(IsDBNull(row("EXOLPD_NOTE")), 0, row("EXOLPD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Other Expenses: Leave Passage =END =========================================
                    'Other Expenses: Fixed Asset Written Off   =START =========================================
                    Header = "other expenses: fixed asset written off"
                    NO = 24
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXOWO_KEY")), 0, row("EXOWO_KEY")), NO, Header, IIf(IsDBNull(row("EXOWO_EXOWOKEY")), 0, row("EXOWO_EXOWOKEY")), _
                                                      IIf(IsDBNull(row("EXOWO_SOURCENO")), 0, row("EXOWO_SOURCENO")), IIf(IsDBNull(row("EXOWO_DESC")), "", row("EXOWO_DESC")), _
                                                      IIf(IsDBNull(row("EXOWO_AMOUNT")), "0", row("EXOWO_AMOUNT")), IIf(IsDBNull(row("EXOWO_DEDUCTIBLE")), "", row("EXOWO_DEDUCTIBLE")), _
                                                       IIf(IsDBNull(row("EXOWO_NOTE")), "", row("EXOWO_NOTE")), IIf(IsDBNull(row("EXOWO_DETAIL")), "", row("EXOWO_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXOWOD_KEY")), 0, row("EXOWOD_KEY")), NO, IIf(IsDBNull(row("EXOWOD_EXOWOKEY")), 0, row("EXOWOD_EXOWOKEY")), _
                                                             IIf(IsDBNull(row("EXOWOD_SOURCENO")), 0, row("EXOWOD_SOURCENO")), IIf(IsDBNull(row("EXOWOD_EXOWODKEY")), 0, row("EXOWOD_EXOWODKEY")), _
                                                             IIf(IsDBNull(row("EXOWOD_DESC")), "", row("EXOWOD_DESC")), IIf(IsDBNull(row("EXOWOD_DEDUCTIBLE")), 0, row("EXOWOD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXOWOD_AMOUNT")), 0, row("EXOWOD_AMOUNT")), IIf(IsDBNull(row("EXOWOD_NOTE")), 0, row("EXOWOD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Other Expenses: Fixed Asset Written Off =END =========================================
                    'Other Expenses: Initial Subscription   =START =========================================
                    Header = "other expenses: initial subscription"
                    NO = 25
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXOIS_KEY")), 0, row("EXOIS_KEY")), NO, Header, IIf(IsDBNull(row("EXOIS_EXOISKEY")), 0, row("EXOIS_EXOISKEY")), _
                                                      IIf(IsDBNull(row("EXOIS_SOURCENO")), 0, row("EXOIS_SOURCENO")), IIf(IsDBNull(row("EXOIS_DESC")), "", row("EXOIS_DESC")), _
                                                      IIf(IsDBNull(row("EXOIS_AMOUNT")), "0", row("EXOIS_AMOUNT")), IIf(IsDBNull(row("EXOIS_DEDUCTIBLE")), "", row("EXOIS_DEDUCTIBLE")), _
                                                       IIf(IsDBNull(row("EXOIS_NOTE")), "", row("EXOIS_NOTE")), IIf(IsDBNull(row("EXOIS_DETAIL")), "", row("EXOIS_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXOISD_KEY")), 0, row("EXOISD_KEY")), NO, IIf(IsDBNull(row("EXOISD_EXOISKEY")), 0, row("EXOISD_EXOISKEY")), _
                                                             IIf(IsDBNull(row("EXOISD_SOURCENO")), 0, row("EXOISD_SOURCENO")), IIf(IsDBNull(row("EXOISD_EXOISDKEY")), 0, row("EXOISD_EXOISDKEY")), _
                                                             IIf(IsDBNull(row("EXOISD_DESC")), "", row("EXOISD_DESC")), IIf(IsDBNull(row("EXOISD_DEDUCTIBLE")), 0, row("EXOISD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXOISD_AMOUNT")), 0, row("EXOISD_AMOUNT")), IIf(IsDBNull(row("EXOISD_NOTE")), 0, row("EXOISD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Other Expenses: Initial Subscription =END =========================================
                    'Other Expenses: Capital Expenditure   =START =========================================
                    Header = "other expenses: capital expenditure"
                    NO = 26
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXOCE_KEY")), 0, row("EXOCE_KEY")), NO, Header, IIf(IsDBNull(row("EXOCE_EXOCEKEY")), 0, row("EXOCE_EXOCEKEY")), _
                                                      IIf(IsDBNull(row("EXOCE_SOURCENO")), 0, row("EXOCE_SOURCENO")), IIf(IsDBNull(row("EXOCE_DESC")), "", row("EXOCE_DESC")), _
                                                      IIf(IsDBNull(row("EXOCE_AMOUNT")), "0", row("EXOCE_AMOUNT")), IIf(IsDBNull(row("EXOCE_DEDUCTIBLE")), "", row("EXOCE_DEDUCTIBLE")), _
                                                       IIf(IsDBNull(row("EXOCE_NOTE")), "", row("EXOCE_NOTE")), IIf(IsDBNull(row("EXOCE_DETAIL")), "", row("EXOCE_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXOCED_KEY")), 0, row("EXOCED_KEY")), NO, IIf(IsDBNull(row("EXOCED_EXOCEKEY")), 0, row("EXOCED_EXOCEKEY")), _
                                                             IIf(IsDBNull(row("EXOCED_SOURCENO")), 0, row("EXOCED_SOURCENO")), IIf(IsDBNull(row("EXOCED_EXOCEDKEY")), 0, row("EXOCED_EXOCEDKEY")), _
                                                             IIf(IsDBNull(row("EXOCED_DESC")), "", row("EXOCED_DESC")), IIf(IsDBNull(row("EXOCED_DEDUCTIBLE")), 0, row("EXOCED_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXOCED_AMOUNT")), 0, row("EXOCED_AMOUNT")), IIf(IsDBNull(row("EXOCED_NOTE")), 0, row("EXOCED_NOTE")), ErrorLog)
                        Next
                    End If
                    'Other Expenses: Capital Expenditure =END =========================================
                    'Other Expenses: Others   =START =========================================
                    Header = "other expenses: others"
                    NO = 27
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXO_KEY")), 0, row("EXO_KEY")), NO, Header, IIf(IsDBNull(row("EXO_EXOKEY")), 0, row("EXO_EXOKEY")), _
                                                      IIf(IsDBNull(row("EXO_SOURCENO")), 0, row("EXO_SOURCENO")), IIf(IsDBNull(row("EXO_DESC")), "", row("EXO_DESC")), _
                                                      IIf(IsDBNull(row("EXO_AMOUNT")), "0", row("EXO_AMOUNT")), IIf(IsDBNull(row("EXO_DEDUCTIBLE")), "", row("EXO_DEDUCTIBLE")), _
                                                       IIf(IsDBNull(row("EXO_NOTE")), "", row("EXO_NOTE")), IIf(IsDBNull(row("EXO_DETAIL")), "", row("EXO_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXOD_KEY")), 0, row("EXOD_KEY")), NO, IIf(IsDBNull(row("EXOD_EXOKEY")), 0, row("EXOD_EXOKEY")), _
                                                             IIf(IsDBNull(row("EXOD_SOURCENO")), 0, row("EXOD_SOURCENO")), IIf(IsDBNull(row("EXOD_EXODKEY")), 0, row("EXOD_EXODKEY")), _
                                                             IIf(IsDBNull(row("EXOD_DESC")), "", row("EXOD_DESC")), IIf(IsDBNull(row("EXOD_DEDUCTIBLE")), 0, row("EXOD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXOD_AMOUNT")), 0, row("EXOD_AMOUNT")), IIf(IsDBNull(row("EXOD_NOTE")), 0, row("EXOD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Other Expenses: Others =END =========================================
                    'Expenses: Technical fee payments to non-resident recipients   =START =========================================
                    Header = "expenses: technical fee payments to non-resident recipients"
                    NO = 28
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXTF_KEY")), 0, row("EXTF_KEY")), NO, Header, IIf(IsDBNull(row("EXTF_EXTFKEY")), 0, row("EXTF_EXTFKEY")), _
                                                      IIf(IsDBNull(row("EXTF_SOURCENO")), 0, row("EXTF_SOURCENO")), IIf(IsDBNull(row("EXTF_DESC")), "", row("EXTF_DESC")), _
                                                      IIf(IsDBNull(row("EXTF_AMOUNT")), "0", row("EXTF_AMOUNT")), IIf(IsDBNull(row("EXTF_DEDUCTIBLE")), "", row("EXTF_DEDUCTIBLE")), _
                                                       IIf(IsDBNull(row("EXTF_NOTE")), "", row("EXTF_NOTE")), IIf(IsDBNull(row("EXTF_DETAIL")), "", row("EXTF_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXTFD_KEY")), 0, row("EXTFD_KEY")), NO, IIf(IsDBNull(row("EXTFD_EXTFKEY")), 0, row("EXTFD_EXTFKEY")), _
                                                             IIf(IsDBNull(row("EXTFD_SOURCENO")), 0, row("EXTFD_SOURCENO")), IIf(IsDBNull(row("EXTFD_EXTFDKEY")), 0, row("EXTFD_EXTFDKEY")), _
                                                             IIf(IsDBNull(row("EXTFD_DESC")), "", row("EXTFD_DESC")), IIf(IsDBNull(row("EXTFD_DEDUCTIBLE")), 0, row("EXTFD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXTFD_AMOUNT")), 0, row("EXTFD_AMOUNT")), IIf(IsDBNull(row("EXTFD_NOTE")), 0, row("EXTFD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Expenses: Technical fee payments to non-resident recipients =END =========================================
                    'Expenses: Cost of Employee Stock Options   =START =========================================
                    Header = "expenses: cost of employee stock options"
                    NO = 29
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXES_KEY")), 0, row("EXES_KEY")), NO, Header, IIf(IsDBNull(row("EXES_EXESKEY")), 0, row("EXES_EXESKEY")), _
                                                      IIf(IsDBNull(row("EXES_SOURCENO")), 0, row("EXES_SOURCENO")), IIf(IsDBNull(row("EXES_DESC")), "", row("EXES_DESC")), _
                                                      IIf(IsDBNull(row("EXES_AMOUNT")), "0", row("EXES_AMOUNT")), IIf(IsDBNull(row("EXES_DEDUCTIBLE")), "", row("EXES_DEDUCTIBLE")), _
                                                       IIf(IsDBNull(row("EXES_NOTE")), "", row("EXES_NOTE")), IIf(IsDBNull(row("EXES_DETAIL")), "", row("EXES_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXESD_KEY")), 0, row("EXESD_KEY")), NO, IIf(IsDBNull(row("EXESD_EXESKEY")), 0, row("EXESD_EXESKEY")), _
                                                             IIf(IsDBNull(row("EXESD_SOURCENO")), 0, row("EXESD_SOURCENO")), IIf(IsDBNull(row("EXESD_EXESDKEY")), 0, row("EXESD_EXESDKEY")), _
                                                             IIf(IsDBNull(row("EXESD_DESC")), "", row("EXESD_DESC")), IIf(IsDBNull(row("EXESD_DEDUCTIBLE")), 0, row("EXESD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXESD_AMOUNT")), 0, row("EXESD_AMOUNT")), IIf(IsDBNull(row("EXESD_NOTE")), 0, row("EXESD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Expenses: Cost of Employee Stock Options =END =========================================
                    'Purchase   =START =========================================
                    Header = "purchase"
                    NO = 1
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("PLFRUP_KEY")), 0, row("PLFRUP_KEY")), NO, Header, IIf(IsDBNull(row("PLFRUP_PLFRUPKEY")), 0, row("PLFRUP_PLFRUPKEY")), _
                                                      IIf(IsDBNull(row("PLFRUP_SOURCENO")), 0, row("PLFRUP_SOURCENO")), IIf(IsDBNull(row("PLFRUP_DESC")), "", row("PLFRUP_DESC")), _
                                                      IIf(IsDBNull(row("PLFRUP_AMOUNT")), "0", row("PLFRUP_AMOUNT")), IIf(IsDBNull(row("PLFRUP_DEDUCTIBLE")), "", row("PLFRUP_DEDUCTIBLE")), _
                                                       IIf(IsDBNull(row("PLFRUP_NOTE")), "", row("PLFRUP_NOTE")), IIf(IsDBNull(row("PLFRUP_DETAIL")), "", row("PLFRUP_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("PLFRUPD_KEY")), 0, row("PLFRUPD_KEY")), NO, IIf(IsDBNull(row("PLFRUPD_PLFRUPKEY")), 0, row("PLFRUPD_PLFRUPKEY")), _
                                                             IIf(IsDBNull(row("PLFRUPD_SOURCENO")), 0, row("PLFRUPD_SOURCENO")), IIf(IsDBNull(row("PLFRUPD_PLFRUPDKEY")), 0, row("PLFRUPD_PLFRUPDKEY")), _
                                                             IIf(IsDBNull(row("PLFRUPD_DESC")), "", row("PLFRUPD_DESC")), IIf(IsDBNull(row("PLFRUPD_DEDUCTIBLE")), 0, row("PLFRUPD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("PLFRUPD_AMOUNT")), 0, row("PLFRUPD_AMOUNT")), IIf(IsDBNull(row("PLFRUPD_NOTE")), 0, row("PLFRUPD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Purchase =END =========================================
                    'Other Expenses: Realised Loss on Foreign Exchange - Trade   =START =========================================
                    Header = "other expenses: realised loss on foreign exchange - trade"
                    NO = 33
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXORT_KEY")), 0, row("EXORT_KEY")), NO, Header, IIf(IsDBNull(row("EXORT_EXORTKEY")), 0, row("EXORT_EXORTKEY")), _
                                                      IIf(IsDBNull(row("EXORT_SOURCENO")), 0, row("EXORT_SOURCENO")), IIf(IsDBNull(row("EXORT_DESC")), "", row("EXORT_DESC")), _
                                                      IIf(IsDBNull(row("EXORT_AMOUNT")), "0", row("EXORT_AMOUNT")), IIf(IsDBNull(row("EXORT_DEDUCTIBLE")), "", row("EXORT_DEDUCTIBLE")), _
                                                       IIf(IsDBNull(row("EXORT_NOTE")), "", row("EXORT_NOTE")), IIf(IsDBNull(row("EXORT_DETAIL")), "", row("EXORT_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXORTD_KEY")), 0, row("EXORTD_KEY")), NO, IIf(IsDBNull(row("EXORTD_EXORTKEY")), 0, row("EXORTD_EXORTKEY")), _
                                                             IIf(IsDBNull(row("EXORTD_SOURCENO")), 0, row("EXORTD_SOURCENO")), IIf(IsDBNull(row("EXORTD_EXORTDKEY")), 0, row("EXORTD_EXORTDKEY")), _
                                                             IIf(IsDBNull(row("EXORTD_DESC")), "", row("EXORTD_DESC")), IIf(IsDBNull(row("EXORTD_DEDUCTIBLE")), 0, row("EXORTD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXORTD_AMOUNT")), 0, row("EXORTD_AMOUNT")), IIf(IsDBNull(row("EXORTD_NOTE")), 0, row("EXORTD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Other Expenses: Realised Loss on Foreign Exchange - Trade =END =========================================
                    'Expenses: Director's Fee   =START =========================================
                    Header = "expenses: director's fee"
                    NO = 34
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXDF_KEY")), 0, row("EXDF_KEY")), NO, Header, IIf(IsDBNull(row("EXDF_EXDFKEY")), 0, row("EXDF_EXDFKEY")), _
                                                      IIf(IsDBNull(row("EXDF_SOURCENO")), 0, row("EXDF_SOURCENO")), IIf(IsDBNull(row("EXDF_DESC")), "", row("EXDF_DESC")), _
                                                      IIf(IsDBNull(row("EXDF_AMOUNT")), "0", row("EXDF_AMOUNT")), IIf(IsDBNull(row("EXDF_DEDUCTIBLE")), "", row("EXDF_DEDUCTIBLE")), _
                                                       IIf(IsDBNull(row("EXDF_NOTE")), "", row("EXDF_NOTE")), IIf(IsDBNull(row("EXDF_DETAIL")), "", row("EXDF_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXDFD_KEY")), 0, row("EXDFD_KEY")), NO, IIf(IsDBNull(row("EXDFD_EXDFKEY")), 0, row("EXDFD_EXDFKEY")), _
                                                             IIf(IsDBNull(row("EXDFD_SOURCENO")), 0, row("EXDFD_SOURCENO")), IIf(IsDBNull(row("EXDFD_EXDFDKEY")), 0, row("EXDFD_EXDFDKEY")), _
                                                             IIf(IsDBNull(row("EXDFD_DESC")), "", row("EXDFD_DESC")), IIf(IsDBNull(row("EXDFD_DEDUCTIBLE")), 0, row("EXDFD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXDFD_AMOUNT")), 0, row("EXDFD_AMOUNT")), IIf(IsDBNull(row("EXDFD_NOTE")), 0, row("EXDFD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Expenses: Director's Fee =END =========================================
                    'Expenses: Input Tax Not Claimable from JKDM"   =START =========================================
                    Header = "expenses: input tax not claimable from jkdm"
                    NO = 35
                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_Report_AI(IIf(IsDBNull(row("EXJK_KEY")), 0, row("EXJK_KEY")), NO, Header, IIf(IsDBNull(row("EXJK_EXJKKEY")), 0, row("EXJK_EXJKKEY")), _
                                                      IIf(IsDBNull(row("EXJK_SOURCENO")), 0, row("EXJK_SOURCENO")), IIf(IsDBNull(row("EXJK_DESC")), "", row("EXJK_DESC")), _
                                                      IIf(IsDBNull(row("EXJK_AMOUNT")), "0", row("EXJK_AMOUNT")), IIf(IsDBNull(row("EXJK_DEDUCTIBLE")), "", row("EXJK_DEDUCTIBLE")), _
                                                       IIf(IsDBNull(row("EXJK_NOTE")), "", row("EXJK_NOTE")), IIf(IsDBNull(row("EXJK_DETAIL")), "", row("EXJK_DETAIL")), RowIvt, ErrorLog)
                        Next
                    End If

                    dtPNLDetails = Nothing

                    dtPNLDetails = mdlProcess.Load_rptLampiranA1_AdjustedIncome(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), ErrorLog)

                    If dtPNLDetails IsNot Nothing Then
                        RowIvt = 0
                        For Each row As DataRow In dtPNLDetails.Rows
                            RowIvt += 1
                            mdlProcess.Save_REPORT_AI_DETAIL(IIf(IsDBNull(row("EXJKD_KEY")), 0, row("EXJKD_KEY")), NO, IIf(IsDBNull(row("EXJKD_EXJKKEY")), 0, row("EXJKD_EXJKKEY")), _
                                                             IIf(IsDBNull(row("EXJKD_SOURCENO")), 0, row("EXJKD_SOURCENO")), IIf(IsDBNull(row("EXJKD_EXJKDKEY")), 0, row("EXJKD_EXJKDKEY")), _
                                                             IIf(IsDBNull(row("EXJKD_DESC")), "", row("EXJKD_DESC")), IIf(IsDBNull(row("EXJKD_DEDUCTIBLE")), 0, row("EXJKD_DEDUCTIBLE")), _
                                                             IIf(IsDBNull(row("EXJKD_AMOUNT")), 0, row("EXJKD_AMOUNT")), IIf(IsDBNull(row("EXJKD_NOTE")), 0, row("EXJKD_NOTE")), ErrorLog)
                        Next
                    End If
                    'Expenses: Input Tax Not Claimable from JKDM" =END =========================================
                End If
            Next

        Catch ex As Exception
            MsgBox(System.Reflection.MethodBase.GetCurrentMethod().Name & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub TempValSecA()
        Try

            If mdlProcess.Delete_REPORT_AI_BAL(mdlProcess.ArgParam2, ErrorLog) = False Then
                MsgBox("Failed to clear Report AI BAL." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                Exit Sub
            End If


            Dim dtBusinessSource As DataTable = mdlProcess.Load_rptLampiranA1_BusinessSource(mdlProcess.ArgParam2, mdlProcess.ArgParam3, ErrorLog)

            If dtBusinessSource Is Nothing Then
                Exit Sub
            End If

            Dim dtPNL As DataTable = Nothing
            Dim dtPNLDetails As DataTable = Nothing
            Dim NA_Exp As Decimal = 0
            Dim Header As String = Nothing
            Dim NO As Integer = 0
            Dim ColumnName As String = Nothing
            For i As Integer = 0 To dtBusinessSource.Rows.Count - 1

                If IsDBNull(dtBusinessSource.Rows(i)("BC_KEY")) = False AndAlso IsDBNull(dtBusinessSource.Rows(i)("BC_YA")) = False Then

                    dtPNL = mdlProcess.Load_PNL(dtBusinessSource.Rows(i)("BC_KEY").ToString, dtBusinessSource.Rows(i)("BC_YA").ToString, ErrorLog)

                    If dtPNL IsNot Nothing AndAlso IsDBNull(dtPNL.Rows(0)("PL_KEY")) = False Then

                        'Purchase =START =========================================
                        Header = "purchase"
                        NO = 1
                        ColumnName = "PLFPUR_AMOUNT"
                        dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header, CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                        If dtPNLDetails IsNot Nothing Then
                            NA_Exp = 0
                            CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                            mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                              CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))
                        End If

                        'Purchase =END =========================================

                        'production cost - depreciation =START =========================================
                        Header = "production cost - depreciation"
                        NO = 2
                        ColumnName = "EXDEP_AMOUNT"
                        dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header, CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                        If dtPNLDetails IsNot Nothing Then
                            NA_Exp = 0
                            CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                            mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                              CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))
                        End If

                        'production cost - depreciation =END =========================================
                        'production cost - other non allowable expenses =START =========================================
                        Header = "production cost - other non allowable expenses"
                        NO = 3
                        ColumnName = "EXNA_AMOUNT"
                        dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header, CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                        If dtPNLDetails IsNot Nothing Then
                            NA_Exp = 0
                            CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                            mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                              CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))
                        End If

                        'production cost - other non allowable expenses =END =========================================
                        'expenses: interest restricted persuant to  S33 (2) =START =========================================
                        Header = "expenses: interest restricted persuant to  S33 (2)"
                        NO = 4
                        ColumnName = "EXIR_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'expenses: interest restricted persuant to  S33 (2) =END =========================================
                        'Expenses: Other Interest =START =========================================
                        Header = "expenses: other interest"
                        NO = 5
                        ColumnName = "EXI_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Expenses: Other Interest =END =========================================
                        'Expenses: Professional, Technical, Management & Legal Fees" =START =========================================
                        Header = "expenses: professional, technical, management & legal fees"
                        NO = 6
                        ColumnName = "EXL_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Expenses: Professional, Technical, Management & Legal Fees" =END =========================================
                        'Expenses: Contract Payment =START =========================================
                        Header = "expenses: contract payment"
                        NO = 7
                        ColumnName = "EXC_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Expenses: Contract Payment =END =========================================
                        'Expenses: Salary =START =========================================
                        Header = "expenses: salary"
                        NO = 8
                        ColumnName = "EXS_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Expenses: Salary =END =========================================
                        'Expenses: Royalty =START =========================================
                        Header = "expenses: royalty"
                        NO = 9
                        ColumnName = "EXRO_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Expenses: Royalty =END =========================================
                        'Expenses: Rental =START =========================================
                        Header = "expenses: rental"
                        NO = 10
                        ColumnName = "EXRENT_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Expenses: Rental =END =========================================
                        'Expenses: Repair & Maintenance =START =========================================
                        Header = "expenses: repair & maintenance"
                        NO = 11
                        ColumnName = "EXREP_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Expenses: Repair & Maintenance =END =========================================
                        'Expenses: Research & Development =START =========================================
                        Header = "expenses: research & development"
                        NO = 12
                        ColumnName = "EXRES_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Expenses: Research & Development =END =========================================
                        'Expenses: Promotion & Advertisement =START =========================================
                        Header = "expenses: promotion & advertisement"
                        NO = 13
                        ColumnName = "EXP_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Expenses: Promotion & Advertisement =END =========================================
                        'Expenses: Travelling and Accommodation =START =========================================
                        Header = "expenses: travelling and accommodation"
                        NO = 14
                        ColumnName = "EXT_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Expenses: Travelling and Accommodation =END =========================================
                        'Other Expenses: Depreciation =START =========================================
                        Header = "other expenses: depreciation"
                        NO = 15
                        ColumnName = "EXODEP_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Other Expenses: Depreciation =END =========================================
                        'Other Expenses: Donation - Approved =START =========================================
                        Header = "other expenses: donation - approved"
                        NO = 16
                        ColumnName = "EXOAD_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Other Expenses: Donation - Approved =END =========================================
                        'Other Expenses: Donation - Non Approved" =START =========================================
                        Header = "other expenses: donation - non approved"
                        NO = 17
                        ColumnName = "EXONAD_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Other Expenses: Donation - Non Approved" =END =========================================
                        'Other Expenses: Zakat =START =========================================
                        Header = "other expenses: zakat"
                        NO = 18
                        ColumnName = "EXOZ_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 3", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Other Expenses: Zakat =END =========================================
                        'Other Expenses: Entertainment - Non Staff =START =========================================
                        Header = "other expenses: entertainment - non staff"
                        NO = 19
                        ColumnName = "EXOENS_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Other Expenses: Entertainment - Non Staff =END =========================================
                        'Other Expenses: Entertainment - Staff =START =========================================
                        Header = "other Expenses: entertainment - staff"
                        NO = 20
                        ColumnName = "EXOES_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Other Expenses: Entertainment - Staff =END =========================================
                        'other expenses: compound/penalty =START =========================================
                        Header = "other expenses: compound/penalty"
                        NO = 21
                        ColumnName = "EXOPA_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'other expenses: compound/penalty =END =========================================
                        'Other Expenses: Provision Account =START =========================================
                        Header = "other expenses: provision account"
                        NO = 22
                        ColumnName = "EXOPAA_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Other Expenses: Provision Account =END =========================================
                        'Other Expenses: Leave Passage =START =========================================
                        Header = "other expenses: leave passage"
                        NO = 23
                        ColumnName = "EXOLP_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Other Expenses: Leave Passage =END =========================================
                        'Other Expenses: Fixed Asset Written Off =START =========================================
                        Header = "other expenses: fixed asset written off"
                        NO = 24
                        ColumnName = "EXOWO_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Other Expenses: Fixed Asset Written Off =END =========================================
                        'Other Expenses: Initial Subscription =START =========================================
                        Header = "other expenses: initial subscription"
                        NO = 25
                        ColumnName = "EXOIS_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Other Expenses: Initial Subscription =END =========================================
                        'Other Expenses: Capital Expenditure =START =========================================
                        Header = "other expenses: capital expenditure"
                        NO = 26
                        ColumnName = "EXOCE_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Other Expenses: Capital Expenditure =END =========================================
                        'Other Expenses: Others =START =========================================
                        Header = "other expenses: others"
                        NO = 27
                        ColumnName = "EXO_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Other Expenses: Others =END =========================================
                        'Expenses: Technical fee payments to non-resident recipients =START =========================================
                        Header = "expenses: technical fee payments to non-resident recipients"
                        NO = 28
                        ColumnName = "EXTF_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Expenses: Technical fee payments to non-resident recipients =END =========================================
                        'Expenses: Cost of Employee Stock Options =START =========================================
                        Header = "expenses: cost of employee stock options"
                        NO = 29
                        ColumnName = "EXES_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Expenses: Cost of Employee Stock Options =END =========================================
                        'Other Expenses: Realised Loss on Foreign Exchange - Non-Trade =START =========================================
                        Header = "other expenses: realised loss on foreign exchange - non-trade"
                        NO = 30
                        ColumnName = "EXOR_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Other Expenses: Realised Loss on Foreign Exchange - Non-Trade =END =========================================
                        'Other Expenses: Unrealised Loss on Foreign Exchange =START =========================================
                        Header = "other expenses: unrealised loss on foreign exchange"
                        NO = 31
                        ColumnName = "EXOUR_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Other Expenses: Unrealised Loss on Foreign Exchange =END =========================================
                        'Other Expenses: Loss on Disposal of Fixed Assets =START =========================================
                        Header = "other expenses: loss on disposal of fixed assets"
                        NO = 32
                        ColumnName = "EXOLD_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Other Expenses: Loss on Disposal of Fixed Assets =END =========================================
                        'Other Expenses: Realised Loss on Foreign Exchange - Trade =START =========================================
                        Header = "other expenses: realised loss on foreign exchange - trade"
                        NO = 33
                        ColumnName = "EXORT_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Other Expenses: Realised Loss on Foreign Exchange - Trade =END =========================================
                        'Expenses: Director's Fee =START =========================================
                        Header = "expenses: director's fee"
                        NO = 34
                        ColumnName = "EXDF_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Expenses: Director's Fee =END =========================================
                        'Expenses: Input Tax Not Claimable from JKDM =START =========================================
                        Header = "expenses: input tax not claimable from jkdm"
                        NO = 35
                        ColumnName = "EXJK_AMOUNT"
                        If CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")) > 1 Then
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 1", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                            dtPNLDetails = Nothing

                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If

                        Else
                            dtPNLDetails = mdlProcess.Load_PNL_NonAllowDetails(Header & " - 2", CInt(dtPNL.Rows(0)("PL_KEY")), CInt(dtBusinessSource.Rows(i)("BC_KEY")), ErrorLog)

                            If dtPNLDetails IsNot Nothing Then
                                NA_Exp = 0
                                CalcNa(dtPNLDetails, ColumnName, NA_Exp)
                                mdlProcess.Save_Report_AI_BAL(CInt(dtPNL.Rows(0)("PL_KEY")), mdlProcess.ArgParam2, dtPNL.Rows(0)("PL_YA").ToString, _
                                                                  CInt(dtBusinessSource.Rows(i)("BC_SOURCENO")), NO, Header, "No", CStr(NA_Exp))

                            End If
                        End If

                        'Expenses: Input Tax Not Claimable from JKDM =END =========================================
                    End If

                End If

            Next
        Catch ex As Exception
            MsgBox(System.Reflection.MethodBase.GetCurrentMethod().Name & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Timer1.Stop()
            Me.LoadData()
        Catch ex As Exception

        End Try
    End Sub
End Class