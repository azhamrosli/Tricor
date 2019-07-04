Imports System.Collections.Generic
Imports DevExpress.Spreadsheet
Imports System.Data.OleDb

Public Class frmMapping_Import_1
    Dim ErrorLog As ClsError = Nothing

    WithEvents clsPNLQuick As clsPNL_Quick = Nothing
    Enum EnumStatus
        Ready = 0
        Initialize = 1
        InProgress = 2
        Completed = 3
        [Error] = 4
    End Enum
    Enum EnumTypeAcc
        BalanceSheet = 1
        PNL = 2
        Generic = 0
    End Enum
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If clsPNLQuick Is Nothing Then
            clsPNLQuick = New clsPNL_Quick
        End If
    End Sub
    Private Sub Ai_Testing()
        Try
            Dim dt As DataTable = Nothing
            dt = ADO.Load_Mapping_Code_list()
            If dt IsNot Nothing Then
                Dim r As New Random
                Dim RowData As DataRow = Nothing
                Dim dtRow As DataRow = Nothing
                Dim AccNo As String = Nothing
                Dim Description As String = Nothing
                Dim Amount As Decimal = 0
                Dim ExcelPath As String = "C:\Users\Azham\Desktop\FIMA TO UPLOAD\FIMA_AI.xlsx"

                If System.IO.File.Exists(ExcelPath) = True Then
                    System.IO.File.Delete(ExcelPath)
                End If

                Me.DsAccountMapping.Tables("Ai_BOT").Rows.Clear()

                For i As Integer = 0 To dt.Rows.Count - 1
                    RowData = dt.Rows(i)
                    AccNo = IIf(IsDBNull(RowData("Code")), "10111-L2000", RowData("Code"))
                    Description = AccNo & "- " & IIf(IsDBNull(RowData("KeyName")), "10111-L2000", RowData("KeyName"))
                    Application.DoEvents()
                    Amount = r.Next(-10, 100000)

                    dtRow = Nothing
                    dtRow = Me.DsAccountMapping.Tables("Ai_BOT").NewRow
                    dtRow("AccNo") = AccNo
                    dtRow("Description") = Description
                    dtRow("Amount") = Amount
                    Me.DsAccountMapping.Tables("Ai_BOT").Rows.Add(dtRow)
                Next

                'For i As Integer = 0 To r.Next(10, dt.Rows.Count)
                '    RowData = dt.Rows(i)

                '    AccNo = IIf(IsDBNull(RowData("Code")), "10111-L2000", RowData("Code"))
                '    Description = AccNo & "- " & IIf(IsDBNull(RowData("KeyName")), "10111-L2000", RowData("KeyName"))
                '    Application.DoEvents()
                '    Amount = r.Next(-10, 100000)

                '    dtRow = Nothing
                '    dtRow = Me.DsAccountMapping.Tables("Ai_BOT").NewRow
                '    dtRow("AccNo") = AccNo
                '    dtRow("Description") = Description
                '    dtRow("Amount") = Amount
                '    Me.DsAccountMapping.Tables("Ai_BOT").Rows.Add(dtRow)
                'Next

                AiBOTBindingSource.DataSource = Me.DsAccountMapping.Tables("Ai_BOT")
                Application.DoEvents()
                GCAi_Bot.ExportToXlsx(ExcelPath)
                Application.DoEvents()

            End If


        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmMapping_Import_1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            lblBoting.Visible = False
            'LOAD SETTING FROM MAPPING SETTING TABLE
            Dim dtSetting As DataTable = Nothing

            dtSetting = ADO.Load_Mapping_Setting(ErrorLog)

            DsAccountMapping.Tables("MAPPING_SETTING").Rows.Clear()
            If dtSetting IsNot Nothing Then
                For Each rowx As DataRow In dtSetting.Rows
                    DsAccountMapping.Tables("MAPPING_SETTING").ImportRow(rowx)
                Next

            End If

            DsAccountMappingBindingSource.DataSource = DsAccountMapping
            Application.DoEvents()

            If CreateLookUpTaxPayer(DsDefault, ErrorLog) = False Then
                MsgBox("Unable to retrive tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If CreateLookUpYA(cboYA, ErrorLog) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            Application.DoEvents()
            If My.Computer.Name = DeveloperPCName Then
                cboYA.EditValue = 2017
                cboRefNo.EditValue = "9876543210"
            End If

           
        Catch ex As Exception
        Finally

            If My.Computer.Name = DeveloperPCName Then
                Timer1.Enabled = True
                Timer1.Interval = 100
                Timer1.Start()

            End If
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Timer1.Stop()

            'If My.Computer.Name = DeveloperPCName Then
            '    Ai_Testing()
            'lblBoting.Visible = False
            ' Application.DoEvents()

            ' txtPath.EditValue = "C:\Users\Azham\Desktop\FIMA TO UPLOAD\FIMA_AI.xlsx" 'RandomString()
            'End If

           
            cboSetting.EditValue = 1

            'Application.DoEvents()
            '' btnImport.PerformClick()
            'System.Threading.Thread.Sleep(200)
            'btnStart.PerformClick()

            'Timer1.Interval = 60000
            'Timer1.Start()
            lblBoting.Visible = False
            Application.DoEvents()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Try
            If txtPath.EditValue Is Nothing AndAlso txtPath.EditValue = "" AndAlso System.IO.File.Exists(txtPath.EditValue) = True Then
                MsgBox("Invalid file lcoation.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            '   SpreadsheetControl1.LoadDocument(txtPath.EditValue)
        Catch ex As Exception

        End Try
    End Sub
    Private Function RandomString()

        Dim words = {"C:\Users\Azham\Desktop\FIMA TO UPLOAD\FIMA TO UPLOAD1.xlsx", "C:\Users\Azham\Desktop\FIMA TO UPLOAD\FIMA TO UPLOAD2.xlsx", "C:\Users\Azham\Desktop\FIMA TO UPLOAD\FIMA TO UPLOAD3.xlsx"}
        Dim rnd As New Random()
        Dim howMany As Int32 = rnd.Next(2, 31)
        Dim randomWords As String = ""
        For i As Int32 = 1 To howMany
            Dim nextRandomIndex = rnd.Next(0, words.Count)
            randomWords = words(nextRandomIndex)
            Exit For
        Next
        Return randomWords.ToString()
    End Function
    Private Sub txtPath_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtPath.ButtonClick
        Try

            OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;"

            Dim rslt As DialogResult = OpenFileDialog1.ShowDialog

            If rslt = Windows.Forms.DialogResult.OK Then

                txtPath.EditValue = OpenFileDialog1.FileName

            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub SpreadsheetControl1_SelectionChanged(sender As Object, e As EventArgs) Handles SpreadsheetControl1.SelectionChanged
        Try
            ' SpreadsheetControl1.SelectedCell.FillColor = Color.LightGray
            lbErrorLog.Items.Clear()
            Application.DoEvents()
            Dim currentSelection As IList(Of Range) = SpreadsheetControl1.GetSelectedRanges()

            For Each range As Range In currentSelection
                'If range.Borders.LeftBorder.LineStyle = BorderLineStyle.MediumDashDot Then
                '    Dim rangeFormatting As Formatting = range.BeginUpdateFormatting()
                '    range.Borders.SetOutsideBorders(Color.White, BorderLineStyle.None)
                '    range.EndUpdateFormatting(rangeFormatting)
                'Else
                '    Dim rangeFormatting As Formatting = range.BeginUpdateFormatting()
                '    range.Borders.SetOutsideBorders(Color.Green, BorderLineStyle.MediumDashDot)
                '    range.EndUpdateFormatting(rangeFormatting)
                'End If
                'Dim rangeFormatting As Formatting = range.BeginUpdateFormatting()
                'range.Borders.SetAllBorders(Color.AliceBlue, BorderLineStyle.Medium)

                lbErrorLog.Items.Add("Row :" & range.TopRowIndex.ToString & " Column :" & range.LeftColumnIndex.ToString & " Value :" & range.Value.ToString)
            Next range
        Catch ex As Exception

        End Try
    End Sub
    Private Function EngineImport() As Boolean
        Dim AccLog As String = ""
        Try
            If cboRefNo.EditValue Is Nothing Then
                MsgBox("Please select tax payer.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If cboYA.EditValue Is Nothing Then
                MsgBox("Please select year assessment", MsgBoxStyle.Exclamation)
                Return False
            End If

            'Validating
            ChangeStatusCaption("Validating file & setting", EnumStatus.Initialize)
            If txtPath.EditValue Is Nothing OrElse txtPath.EditValue = "" OrElse System.IO.File.Exists(txtPath.EditValue) = False Then
                MsgBox("Invalid file location.", MsgBoxStyle.Critical)

                txtPath.ReadOnly = False
                btnImport.Enabled = True
                Exit Function
            Else
                txtPath.ReadOnly = True
                btnImport.Enabled = False
            End If

            If cboSetting.EditValue Is Nothing Then
                MsgBox("Please select setting.", MsgBoxStyle.Critical)
                cboSetting.Focus()
                cboSetting.Enabled = True
                Exit Function
            Else
                cboSetting.Enabled = False
            End If

            'Clear ErrorLog Data
            lbErrorLog.Items.Clear()
            ChangeStatusCaption("Ready", EnumStatus.Ready)

            'Step 1 - Load Setting
            Dim dtSetting As DataTable = ADO.Load_Mapping_Setting(cboSetting.EditValue)

            If dtSetting Is Nothing Then
                ErrorLogThrow("Cannot find setting mapping for ID = " & cboSetting.EditValue.ToString)
                ChangeStatusCaption("Error", EnumStatus.Error)
                Return False
            End If
            btnStart.Enabled = False
            'Step 2 - Load Data
            Dim dsDataExcel As DataSet
            ClearBalanceSheet()
            ClearProfitNLoss()
            'Get excel sheet
            SpreadsheetControl1.LoadDocument(txtPath.EditValue)
            Application.DoEvents()

            If Me.LoadExcelFile(dsDataExcel, SpreadsheetControl1.ActiveWorksheet.Name) = False Then
                ChangeStatusCaption("Failed", EnumStatus.Error)
            End If

            If dtSetting IsNot Nothing AndAlso dtSetting.Rows.Count > 0 AndAlso IsDBNull(dtSetting.Rows(0)("Start_Row")) = False AndAlso dsDataExcel IsNot Nothing AndAlso dsDataExcel.Tables.Count > 0 AndAlso dsDataExcel.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To CInt(dtSetting.Rows(0)("Start_Row"))
                    If i <> CInt(dtSetting.Rows(0)("Start_Row")) Then
                        dsDataExcel.Tables(0).Rows(i).Delete()
                    End If
                Next
                Application.DoEvents()
            End If

            If dsDataExcel.Tables.Count > 0 AndAlso dsDataExcel.Tables(0).Rows.Count > 0 Then
                GridControl2.DataSource = dsDataExcel.Tables(0)
            Else
                ErrorLogThrow("Cannot load data from excel sheet to gridview")
                ChangeStatusCaption("Error", EnumStatus.Error)
            End If

            'Step 3 - Load Details
            Dim AccNo As String = Nothing
            Dim Description As String = Nothing
            Dim Amount1 As Decimal = 0
            Dim Amount2 As Decimal = 0
            Dim SourceNo As Integer = 0
            Dim TypeAcc As EnumTypeAcc = EnumTypeAcc.Generic


            Dim dtRowAccInfo As DataTable = Nothing
            If dsDataExcel.Tables.Count > 0 Then
                dsDataExcel.Tables(0).AcceptChanges()
            End If

            Application.DoEvents()
            Dim CurrPro As Integer = 0
            Dim TotalCount As Integer = dsDataExcel.Tables(0).Rows.Count  'LabelControl3
            For Each rowx As DataRow In dsDataExcel.Tables(0).Rows
                CurrPro += 1
                AccNo = ""
                Description = ""
                Amount1 = 0
                Amount2 = 0

                GVDataAfter.FocusedRowHandle = CurrPro - 1
                Application.DoEvents()

                If IsDBNull(rowx(0)) = False AndAlso rowx(0) <> "" Then
                    AccNo = rowx(0)
                    If IsDBNull(rowx(1)) = False AndAlso rowx(1) <> "" Then
                        Description = rowx(1)
                    End If
                    If IsDBNull(rowx(2)) = False AndAlso Information.IsNumeric(rowx(2)) = True Then
                        Amount1 = rowx(2)
                    End If

                    F1.Text = "Account : " & AccNo
                    F2.Text = "Description : " & Description
                    F3.Text = "Amount 1 : " & Amount1.ToString
                    F4.Text = "Amount 2 : " & Amount2.ToString
                    AccLog = AccNo

                    dtRowAccInfo = ADO.Load_Mapping_Code_list(AccNo, ErrorLog)
                    If dtRowAccInfo IsNot Nothing Then

                        If IsDBNull(dtRowAccInfo.Rows(0)("Operator")) = False Then
                            Select Case dtRowAccInfo.Rows(0)("Operator")
                                Case 0
                                    'Postive in Debit side
                                Case 1
                                    'Negative in Credit side
                                    Amount1 = Amount1 * -1
                                Case 2
                                    'Always be positve in Credit side
                                    Amount1 = Math.Abs(Amount1)
                            End Select
                        Else

                        End If


                        If dtRowAccInfo.Rows.Count > 1 Then
                            'Generic PNL
                            TypeAcc = EnumTypeAcc.Generic

                            If IsDBNull(dtRowAccInfo.Rows(0)("Type")) = False Then
                                F5.Text = "Type : Generic"
                            End If
                            BalanceSheet(dtRowAccInfo, Amount1, Amount2)
                            ProfitNLoss(dtRowAccInfo, Description, Amount1, Amount2)
                        Else
                            'Single
                            If IsDBNull(dtRowAccInfo.Rows(0)("Type")) = False Then
                                Select Case TypeAcc
                                    Case EnumTypeAcc.BalanceSheet
                                        F5.Text = "Type : Balance Sheet"
                                        BalanceSheet(dtRowAccInfo, Amount1, Amount2)
                                    Case EnumTypeAcc.Generic
                                        F5.Text = "Type : Generic"
                                        BalanceSheet(dtRowAccInfo, Amount1, Amount2)
                                        ProfitNLoss(dtRowAccInfo, Description, Amount1, Amount2)
                                    Case EnumTypeAcc.PNL
                                        F5.Text = "Type : Profit & Loss"
                                        ProfitNLoss(dtRowAccInfo, Description, Amount1, Amount2)
                                End Select

                                F6.Text = "Source : " & SourceNo.ToString
                            End If
                            'If IsDBNull(dtRowAccInfo.Rows(0)("SourceNo")) = False Then
                            '    SourceNo = dtRowAccInfo.Rows(0)("SourceNo")
                            'End If
                        End If

                    End If
                    Application.DoEvents()
                End If
                ChangeStatusCaption("In-progress " & CurrPro.ToString & "/" & TotalCount.ToString, EnumStatus.InProgress)
                lblBoting.Text = "Ai Testing Data " & CurrPro.ToString & "/" & TotalCount.ToString
                Application.DoEvents()
            Next

            CalcBalanceSheet()
            Dim StatusSave As Boolean = True
            If SaveBalanceSheet() = False Then
                ChangeStatusCaption("Failed to save balance sheet.", EnumStatus.Error)
                StatusSave = False
            End If
            If clsPNLQuick.Save_PNLQuick() = False Then
                ChangeStatusCaption("Failed to save profit and loss.", EnumStatus.Error)
                StatusSave = False
            End If

            If StatusSave Then
                ChangeStatusCaption("Done Saved.", EnumStatus.Completed)
                MsgBox("Successfully save data.", MsgBoxStyle.Information)
            End If
            btnStart.Enabled = True
        Catch ex As Exception
            ErrorLogThrow(ex.Message)
            ChangeStatusCaption("Failed to mapping in engine import.", EnumStatus.Error)
            btnStart.Enabled = True
            Return False
        Finally
         
            'Timer1.Interval = 10000
            'Timer1.Start()
        End Try
    End Function
#Region "BALANCE SHEET"
    Private Sub BalanceSheet(ByVal dtRowAccInfo As DataTable, ByVal Amount1 As Decimal, ByVal Amount2 As Decimal)
        Try

            Dim AmountMain As Decimal = 0

            If IsDBNull(dtRowAccInfo.Rows(0)("KeyName")) = False Then

                Select Case dtRowAccInfo.Rows(0)("KeyName")
                    Case "FA_MOTORVECHILE"
                        If Information.IsNumeric(Amount1) Then
                            AmountMain = CDec(Amount1)
                        ElseIf Information.IsNumeric(Amount2) Then
                            AmountMain = CDec(Amount2)
                        Else
                            AmountMain = 0
                        End If
                        txtVehicle.EditValue += AmountMain
                    Case "FA_PLANTMACHINERY"
                        If Information.IsNumeric(Amount1) Then
                            AmountMain = CDec(Amount1)
                        ElseIf Information.IsNumeric(Amount2) Then
                            AmountMain = CDec(Amount2)
                        End If
                        txtMachinery.EditValue += AmountMain
                    Case "FA_LANDBUILDING"
                        If Information.IsNumeric(Amount1) Then
                            AmountMain = CDec(Amount1)
                        ElseIf Information.IsNumeric(Amount2) Then
                            AmountMain = CDec(Amount2)
                        Else
                            AmountMain = 0
                        End If
                        txtBuilding.EditValue += AmountMain
                    Case "FA_OTHFIXEDASSET"
                        If Information.IsNumeric(Amount1) Then
                            AmountMain = CDec(Amount1)
                        ElseIf Information.IsNumeric(Amount2) Then
                            AmountMain = CDec(Amount2)
                        Else
                            AmountMain = 0
                        End If
                        txtOtherFA.EditValue += AmountMain
                    Case "FA_CURRYAFIXEDASSET"
                        If Information.IsNumeric(Amount1) Then
                            AmountMain = CDec(Amount1)
                        ElseIf Information.IsNumeric(Amount2) Then
                            AmountMain = CDec(Amount2)
                        Else
                            AmountMain = 0
                        End If
                        txtCurYear.EditValue += AmountMain
                    Case "FA_INVESTMENT"
                        If Information.IsNumeric(Amount1) Then
                            AmountMain = CDec(Amount1)
                        ElseIf Information.IsNumeric(Amount2) Then
                            AmountMain = CDec(Amount2)
                        Else
                            AmountMain = 0
                        End If
                        txtInvestment.EditValue += AmountMain
                    Case "CA_TRADEDEBTORS"
                        If Information.IsNumeric(Amount1) Then
                            AmountMain = CDec(Amount1)
                        ElseIf Information.IsNumeric(Amount2) Then
                            AmountMain = CDec(Amount2)
                        Else
                            AmountMain = 0
                        End If
                        txtTradeDebtors.EditValue += AmountMain
                    Case "CA_OTHERDEBTORS"
                        If Information.IsNumeric(Amount1) Then
                            AmountMain = CDec(Amount1)
                        ElseIf Information.IsNumeric(Amount2) Then
                            AmountMain = CDec(Amount2)
                        Else
                            AmountMain = 0
                        End If
                        txtOtherDebtors.EditValue += AmountMain
                    Case "CA_STOCK"
                        If Information.IsNumeric(Amount1) Then
                            AmountMain = CDec(Amount1)
                        ElseIf Information.IsNumeric(Amount2) Then
                            AmountMain = CDec(Amount2)
                        Else
                            AmountMain = 0
                        End If
                        txtStock.EditValue += AmountMain
                    Case "CA_LOANDIRECTOR"
                        If Information.IsNumeric(Amount1) Then
                            AmountMain = CDec(Amount1)
                        ElseIf Information.IsNumeric(Amount2) Then
                            AmountMain = CDec(Amount2)
                        Else
                            AmountMain = 0
                        End If
                        txtLoanTo.EditValue += AmountMain
                    Case "CA_CASHBANK"
                        If Information.IsNumeric(Amount1) Then
                            AmountMain = CDec(Amount1)
                        ElseIf Information.IsNumeric(Amount2) Then
                            AmountMain = CDec(Amount2)
                        Else
                            AmountMain = 0
                        End If
                        txtCashBank.EditValue += AmountMain
                    Case "CA_OTHCURRASSET"
                        If Information.IsNumeric(Amount1) Then
                            AmountMain = CDec(Amount1)
                        ElseIf Information.IsNumeric(Amount2) Then
                            AmountMain = CDec(Amount2)
                        Else
                            AmountMain = 0
                        End If
                        txtOtherCA.EditValue += AmountMain
                    Case "LECL_BORR"
                        If Information.IsNumeric(Amount1) Then
                            AmountMain = CDec(Amount1)
                        ElseIf Information.IsNumeric(Amount2) Then
                            AmountMain = CDec(Amount2)
                        Else
                            AmountMain = 0
                        End If
                        txtBorrowing.EditValue += AmountMain
                    Case "LECL_TRADECREDITOR"
                        If Information.IsNumeric(Amount1) Then
                            AmountMain = CDec(Amount1)
                        ElseIf Information.IsNumeric(Amount2) Then
                            AmountMain = CDec(Amount2)
                        Else
                            AmountMain = 0
                        End If
                        txtTradeCreditor.EditValue += AmountMain
                    Case "LECL_OTHCREDITOR"
                        If Information.IsNumeric(Amount1) Then
                            AmountMain = CDec(Amount1)
                        ElseIf Information.IsNumeric(Amount2) Then
                            AmountMain = CDec(Amount2)
                        Else
                            AmountMain = 0
                        End If
                        txtOtherCreditor.EditValue += AmountMain
                    Case "LECL_LOANDIRECTOR"
                        If Information.IsNumeric(Amount1) Then
                            AmountMain = CDec(Amount1)
                        ElseIf Information.IsNumeric(Amount2) Then
                            AmountMain = CDec(Amount2)
                        Else
                            AmountMain = 0
                        End If
                        txtLoanFrom.EditValue += AmountMain
                    Case "LECL_OTHCURRLIA"
                        If Information.IsNumeric(Amount1) Then
                            AmountMain = CDec(Amount1)
                        ElseIf Information.IsNumeric(Amount2) Then
                            AmountMain = CDec(Amount2)
                        Else
                            AmountMain = 0
                        End If
                        txtOtherCL.EditValue += AmountMain
                    Case "LECL_LONGTERM"
                        If Information.IsNumeric(Amount1) Then
                            AmountMain = CDec(Amount1)
                        ElseIf Information.IsNumeric(Amount2) Then
                            AmountMain = CDec(Amount2)
                        Else
                            AmountMain = 0
                        End If
                        txtLongTerm.EditValue += AmountMain
                    Case "LESE_PAIDCAPITAL"
                        If Information.IsNumeric(Amount1) Then
                            AmountMain = CDec(Amount1)
                        ElseIf Information.IsNumeric(Amount2) Then
                            AmountMain = CDec(Amount2)
                        Else
                            AmountMain = 0
                        End If
                        txtPaidUp.EditValue += AmountMain
                    Case "LESE_APPPNL"
                        If Information.IsNumeric(Amount1) Then
                            AmountMain = CDec(Amount1)
                        ElseIf Information.IsNumeric(Amount2) Then
                            AmountMain = CDec(Amount2)
                        Else
                            AmountMain = 0
                        End If
                        txtAppropriation.EditValue += AmountMain
                    Case "LESE_RESERVES"
                        If Information.IsNumeric(Amount1) Then
                            AmountMain = CDec(Amount1)
                        ElseIf Information.IsNumeric(Amount2) Then
                            AmountMain = CDec(Amount2)
                        Else
                            AmountMain = 0
                        End If
                        txtReserves.EditValue += AmountMain
                    Case "SME"

                End Select

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ClearBalanceSheet()
        Try
            txtVehicle.EditValue = 0
            txtMachinery.EditValue = 0
            txtBuilding.EditValue = 0
            txtOtherFA.EditValue = 0
            txtTotalFA.EditValue = 0
            txtCurYear.EditValue = 0
            txtInvestment.EditValue = 0
            txtTradeDebtors.EditValue = 0

            txtOtherDebtors.EditValue = 0
            txtStock.EditValue = 0
            txtLoanTo.EditValue = 0
            txtCashBank.EditValue = 0
            txtOtherCA.EditValue = 0
            txtTotalCA.EditValue = 0
            txtTotalAssets.EditValue = 0
            txtBorrowing.EditValue = 0
            txtTradeCreditor.EditValue = 0
            txtOtherCreditor.EditValue = 0
            txtLoanFrom.EditValue = 0
            txtOtherCL.EditValue = 0
            txtTotalCL.EditValue = 0
            txtLongTerm.EditValue = 0
            txtTotalLiability.EditValue = 0
            txtPaidUp.EditValue = 0
            txtAppropriation.EditValue = 0
            txtReserves.EditValue = 0
            txtTotalEquity.EditValue = 0
            txtTotalLE.EditValue = 0
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CalcBalanceSheet()
        Try
            txtTotalFA.EditValue = CDec(txtVehicle.EditValue) + CDec(txtMachinery.EditValue) + CDec(txtBuilding.EditValue) + CDec(txtOtherFA.EditValue)
            txtTotalCA.EditValue = CDec(txtOtherDebtors.EditValue) + CDec(txtStock.EditValue) + CDec(txtLoanTo.EditValue) + CDec(txtCashBank.EditValue) + CDec(txtOtherCA.EditValue) + CDec(txtTradeDebtors.EditValue)
            txtTotalAssets.EditValue = CDec(txtTotalCA.EditValue) + CDec(txtInvestment.EditValue) + CDec(txtTotalFA.EditValue)
            Application.DoEvents()
            txtTotalCL.EditValue = CDec(txtBorrowing.EditValue) + CDec(txtLoanFrom.EditValue) + CDec(txtOtherCreditor.EditValue) + CDec(txtTradeCreditor.EditValue) + CDec(txtOtherCL.EditValue)
            txtTotalLiability.EditValue = CDec(txtTotalCL.EditValue) + CDec(txtLongTerm.EditValue)
            txtTotalEquity.EditValue = CDec(txtPaidUp.EditValue) + CDec(txtReserves.EditValue) + CDec(txtAppropriation.EditValue)

            If CDec(txtPaidUp.EditValue) <= 2500000 And CDec(txtPaidUp.EditValue) > 0 Then
                chkSME.Checked = True
            Else
                chkSME.Checked = False
            End If

            txtTotalLE.EditValue = CDec(txtTotalEquity.EditValue) + CDec(txtTotalLiability.EditValue)
        Catch ex As Exception

        End Try
    End Sub
    Private Function SaveBalanceSheet(Optional ByRef ID As Integer = 0) As Boolean
        Try
            'If CDec(txtTotalLE.EditValue) <> CDec(txtTotalAssets.EditValue) Then
            '    Dim rlst As MsgBoxResult = MessageBox.Show("Assets not equal to Liability + Capital" & vbCrLf & "Assets = " & txtTotalAssets.EditValue & " Liability + Capital = " & txtTotalLE.EditValue & vbCrLf & "Do you want to save the record?", "Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            '    If rlst = MsgBoxResult.No Then
            '        Return False
            '    End If
            'End If

            Dim tmpBs As DataTable = ADO.Load_BalanceSheet_Search(cboRefNo.EditValue, cboYA.EditValue, ErrorLog)

            If ADO.Check_BalanceSheetExist(cboRefNo.EditValue, cboYA.EditValue, ErrorLog) = True AndAlso tmpBs IsNot Nothing AndAlso IsDBNull(tmpBs.Rows(0)("BS_KEY")) = False Then
                'Yes
                ID = tmpBs.Rows(0)("BS_KEY")
                If ADO.Update_BalanceSheet(ID, cboRefNo.EditValue, cboYA.EditValue, txtVehicle.EditValue, txtMachinery.EditValue, _
                                         txtBuilding.EditValue, txtOtherFA.EditValue, txtTotalFA.EditValue, txtInvestment.EditValue, _
                                         txtTradeDebtors.EditValue, txtOtherDebtors.EditValue, txtLoanTo.EditValue, txtCashBank.EditValue.ToString, _
                                         txtOtherCA.EditValue, txtTotalCA.EditValue, txtTotalAssets.EditValue, txtBorrowing.EditValue, _
                                         txtTradeCreditor.EditValue, txtOtherCreditor.EditValue, txtLoanFrom.EditValue, _
                                         txtOtherCL.EditValue, txtTotalCL.EditValue, txtLongTerm.EditValue, txtTotalLiability.EditValue, _
                                         txtPaidUp.EditValue, txtAppropriation.EditValue, txtReserves.EditValue, txtTotalEquity.EditValue, _
                                         txtTotalLE.EditValue, txtStock.EditValue, "C", txtCurYear.EditValue, _
                                         chkSME.Checked, "", ErrorLog) Then
                    isEdit = True
                Else
                    MsgBox("Unsuccessfully update balance sheet.", MsgBoxStyle.Critical)
                    Return False
                End If
            Else
                'no
                Dim ReturnID As Integer = 0
                If ADO.Save_BalanceSheet(cboRefNo.EditValue, cboYA.EditValue, txtVehicle.EditValue, txtMachinery.EditValue, _
                                                txtBuilding.EditValue, txtOtherFA.EditValue, txtTotalFA.EditValue, txtInvestment.EditValue, _
                                                txtTradeDebtors.EditValue, txtOtherDebtors.EditValue, txtLoanTo.EditValue, txtCashBank.EditValue, _
                                                txtOtherCA.EditValue, txtTotalCA.EditValue, txtTotalAssets.EditValue, txtBorrowing.EditValue, _
                                                txtTradeCreditor.EditValue, txtOtherCreditor.EditValue, txtLoanFrom.EditValue, _
                                                txtOtherCL.EditValue, txtTotalCL.EditValue, txtLongTerm.EditValue, txtTotalLiability.EditValue, _
                                                txtPaidUp.EditValue, txtAppropriation.EditValue, txtReserves.EditValue, txtTotalEquity.EditValue, _
                                                txtTotalLE.EditValue, txtStock.EditValue, "C", txtCurYear.EditValue, _
                                                chkSME.Checked, "", ReturnID, ErrorLog) Then
                    ID = ReturnID
                Else
                    MsgBox("Unsuccessfully save balance sheet.", MsgBoxStyle.Critical)
                    Return False
                End If
            End If

            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            Return False
        End Try
    End Function
#End Region
#Region "PNL"
    Private Sub ProfitNLoss(ByVal dtRowAccInfo As DataTable, ByVal Description As String, ByVal Amount1 As Decimal, ByVal Amount2 As Decimal)
        Try
            Dim AmountMain As Decimal = 0
            If Information.IsNumeric(Amount1) Then
                AmountMain = CDec(Amount1)
            ElseIf Information.IsNumeric(Amount2) Then
                AmountMain = CDec(Amount2)
            Else
                AmountMain = 0
            End If

            If IsDBNull(dtRowAccInfo.Rows(0)("KeyName")) = False AndAlso dtRowAccInfo.Rows(0)("KeyName") <> "" Then
                Dim Keyname As String = ""
                Dim dtSourceNO As DataTable = ADO.LoadSourceNo(cboRefNo.EditValue, cboYA.EditValue, ErrorLog)
                Dim SourceNo As Integer = 0
                If IsDBNull(dtRowAccInfo.Rows(0)("SourceNo")) = False AndAlso dtSourceNO IsNot Nothing Then
                    Dim isFind As Boolean = False
                    For Each rowsource As DataRow In dtSourceNO.Rows
                        If IsDBNull(rowsource("BC_SOURCENO")) = False Then
                            If dtRowAccInfo.Rows(0)("SourceNo") = rowsource("BC_SOURCENO") Then
                                SourceNo = dtRowAccInfo.Rows(0)("SourceNo")
                                isFind = True
                                Exit For
                            End If
                        End If                   
                    Next
                    If isFind = False Then
                        SourceNo = 1
                    End If
                Else
                    If dtSourceNO IsNot Nothing Then
                        SourceNo = IIf(IsDBNull(dtSourceNO.Rows(0)("BC_SOURCENO")), 1, dtSourceNO.Rows(0)("BC_SOURCENO"))
                    Else
                        SourceNo = 1
                    End If
                End If
              
                If clsPNLQuick IsNot Nothing Then

                    clsPNLQuick.Insert_ManualDataToCategory(dtRowAccInfo.Rows(0)("KeyName"), SourceNo, Description, AmountMain, False, False, 0, 0, "",
                                                            clsPNL_Quick.EnumTypeCategory.NoDeduct_1)


                End If

            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub ClearProfitNLoss()
        Try
            clsPNLQuick = Nothing
            clsPNLQuick = New clsPNL_Quick
            clsPNLQuick.RefNo = cboRefNo.EditValue
            clsPNLQuick.YA = cboYA.EditValue
            clsPNLQuick.Ai_Testing_Require = False

            clsPNLQuick.Init_QuickPNL()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub clsPNLQuick_OnChangeData(KeyName_ As String, dtRow_ As DataRow, Errorlog_ As ClsError) Handles clsPNLQuick.OnChangeData
        Try
            If dtRow_ IsNot Nothing Then

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub clsPNL_Quick_OnChangeInfo(dsDataset_ As DataSet, Errorlog_ As ClsError) Handles clsPNLQuick.OnChangeInfo
        Try
            If dsDataset_ IsNot Nothing Then
                PNLQUICKBindingSource.DataSource = Nothing
                PNLTABLEINFOBindingSource.DataSource = Nothing
                BUSINESSSOURCE1BindingSource.DataSource = Nothing
                PNLQUICKDETAILBindingSource.DataSource = Nothing
                PNLTABLEINFOMAINBindingSource.DataSource = Nothing

                PNLQUICKBindingSource.DataSource = dsDataset_.Tables("PNL_QUICK")
                PNLTABLEINFOBindingSource.DataSource = dsDataset_.Tables("PNL_TABLE_INFO")
                BUSINESSSOURCE1BindingSource.DataSource = dsDataset_.Tables("BUSINESS_SOURCE")
                PNLQUICKDETAILBindingSource.DataSource = dsDataset_.Tables("PNL_QUICK_DETAIL")
                PNLTABLEINFOMAINBindingSource.DataSource = dsDataset_.Tables("PNL_TABLE_INFO_MAIN")
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
    Private Sub ChangeStatusCaption(ByVal Caption As String, ByVal Status As EnumStatus)
        Try
            lblStatus.Text = "Status : " & Caption

            Select Case Status
                Case EnumStatus.Ready, EnumStatus.Initialize, EnumStatus.InProgress
                    lblStatus.ForeColor = Color.Black
                Case EnumStatus.Completed
                    lblStatus.ForeColor = Color.Green
                Case EnumStatus.Error
                    lblStatus.ForeColor = Color.Red
            End Select
            Application.DoEvents()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub ErrorLogThrow(ByVal ErrorLog As String)
        Try
            lbErrorLog.Items.Insert(0, ErrorLog)
            Application.DoEvents()
        Catch ex As Exception

        End Try
    End Sub
    Private Function LoadExcelFile(ByRef ds As DataSet, ByVal ShetName As String) As Boolean
        Try
            Dim tableName As String = ShetName
            Dim adapter As OleDbDataAdapter
            Dim strSQL As String = Nothing
            Dim dtRow As DataRow = Nothing
            Dim connectionString As String = ""

            If txtPath.EditValue.ToString.EndsWith(".xlsx") Then            '2007 Format            
                connectionString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;HDR=No'", txtPath.EditValue)
            Else            '2003 Format            
                connectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=No'", txtPath.EditValue)
            End If

            If ds Is Nothing Then
                ds = New DataSet
            End If

            Dim conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim dtSheets As DataTable =
              conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
            Dim listSheet As New List(Of String)
            Dim drSheet As DataRow

            For Each drSheet In dtSheets.Rows
                strSQL = "select * from [" & drSheet("TABLE_NAME").ToString() & "]"
                adapter = New OleDbDataAdapter(strSQL, connectionString)
                adapter.Fill(ds, "Sheet")
                Exit For
            Next

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            Return True
        Catch ex As Exception
            ErrorLogThrow(ex.Message)
            Return False
        End Try
    End Function
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Try

            EngineImport()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            txtTaxPayer.EditValue = cboRefNo.EditValue
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridControl1_Click(sender As Object, e As EventArgs)

    End Sub
End Class