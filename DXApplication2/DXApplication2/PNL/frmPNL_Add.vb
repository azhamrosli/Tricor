Imports System.Speech
Imports System.Speech.Synthesis
Imports System.Speech.Recognition
Imports System.Data.SqlClient

Public Class frmPNL_Add
    Public ID As Integer = 216
    Public isEdit As Boolean = True
    Dim ErrorLog As clsError = Nothing

    Dim AiFirstTime As Boolean = False

    Dim Speaker As SpeechSynthesizer
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        If mdlProcess.clsPNL_ Is Nothing Then
            mdlProcess.clsPNL_ = New clsPNL
            mdlProcess.clsPNL_.txtNetProfit = txtNetProfitAndLoss
        Else
            mdlProcess.clsPNL_.txtNetProfit = txtNetProfitAndLoss
        End If
        Application.DoEvents()
        ' Add any initialization after the InitializeComponent() call.
        If IsNumeric(My.Settings.DecimalPlace_PNL) Then
            Select Case CInt(My.Settings.DecimalPlace_PNL)
                Case 0
                    cboDecimalPlace.EditValue = "0 =  Exp : 1000"
                Case 1
                    cboDecimalPlace.EditValue = "1 =  Exp : 1000.1"
                Case 2
                    cboDecimalPlace.EditValue = "2 =  Exp : 1000.10"
                Case 3
                    cboDecimalPlace.EditValue = "3 =  Exp : 1000.100"
                Case Else
                    cboDecimalPlace.EditValue = "0 =  Exp : 1000"
            End Select
        End If
    End Sub
    Private Sub frmPNL_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadData()
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub LoadData()
        Try
            ADO.CreateTaxPayer(DsDefault, ADO.ErrorLog)
            ADO.CreateYA(DsDefault, ADO.ErrorLog)

            If clsPNL_.CreatePNLINFO() = False Then
                MsgBox("Failed to load profit and loss information.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            PNLINFOBindingSource.DataSource = clsPNL_.dsDataset.Tables("PNL_INFO")
            AiBindingSource.DataSource = clsPNL_.dsDataset.Tables("Ai")
            DocumentManager1.View.Controller.CloseAll()
            Application.DoEvents()

            clsPNL_.ClearDatabaseMemory(False, ErrorLog)

            If isEdit = False Then
                If mdlProcess.ArgParam2 <> "" Then
                    cboRefNo.EditValue = mdlProcess.ArgParam2
                    cboYA.EditValue = mdlProcess.ArgParam3
                End If
                ReadOnlyisEdit()
            Else
                ProgressChange(0, "Ready to load data.")
                If clsPNL_.dsDataset.Tables("PNL_INFO").Rows.Count > 0 Then

                    Dim dtTmp As DataTable = Nothing
                    Dim dsTmp_tbl As DataTable = Nothing
                    Dim dsTmp As dsPNL = Nothing
                    Dim dtRow As DataRow = Nothing
                    Dim CurrProgress As Integer = 0

                    Dim dtPNL As DataTable = clsPNL_.Load_PNL(ID, ErrorLog)

                    If dtPNL Is Nothing Then
                        isEdit = False
                        Exit Sub
                    End If

                    cboRefNo.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_REF_NO")), "", dtPNL.Rows(0)("PL_REF_NO"))
                    cboYA.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_YA")), "", dtPNL.Rows(0)("PL_YA"))
                    Application.DoEvents()
                    cboCompanyNo.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_COMPANY")), "", dtPNL.Rows(0)("PL_COMPANY"))
                    cboSourceNo.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_MAIN_BUSINESS")), "", dtPNL.Rows(0)("PL_MAIN_BUSINESS"))
                    Application.DoEvents()
                    ProgressChange(5, "Cleaning cache memory.")

                    For Each rowInfo As DataRow In clsPNL_.dsDataset.Tables("PNL_INFO").Rows
                        CurrProgress += 1
                        If IsDBNull(rowInfo("OldKey")) = False AndAlso rowInfo("OldKey") <> 0 AndAlso IsDBNull(rowInfo("TableName")) = False AndAlso
                            rowInfo("TableName") <> "" AndAlso IsDBNull(rowInfo("PrefixName")) = False AndAlso rowInfo("PrefixName") <> "" AndAlso
                            IsDBNull(rowInfo("ColumnKey")) = False AndAlso rowInfo("ColumnKey") <> "" Then

                            If rowInfo("OldKey") = 44 Then
                                Dim x As String = Nothing
                            End If
                            dtTmp = Nothing
                            dsTmp = Nothing
                            dsTmp = clsPNL_.GetDatasetPNL("ds_" & IIf(IsDBNull(rowInfo("KeyName")), "", rowInfo("KeyName")))


                            If dsTmp IsNot Nothing Then

                                dtTmp = clsPNL_.Load_PNL_ITEM(rowInfo("TableName"), rowInfo("PrefixName") & "_KEY", ID, rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), ErrorLog)

                                If dtTmp IsNot Nothing Then

                                    For Each row As DataRow In dtTmp.Rows
                                        dtRow = Nothing
                                        dtRow = dsTmp.Tables(rowInfo("TableName")).NewRow

                                        For Each col As DataColumn In dsTmp.Tables(rowInfo("TableName")).columns
                                            If col.ColumnName = rowInfo("ColumnKey") Then
                                                dtRow(col.ColumnName) = dsTmp.Tables(rowInfo("TableName")).rows.count + 1
                                            Else
                                                Select Case col.DataType
                                                    Case Type.GetType("System.String")
                                                        dtRow(col.ColumnName) = IIf(IsDBNull(row(col.ColumnName)), "", row(col.ColumnName))
                                                    Case Type.GetType("System.Decimal"), Type.GetType("System.Int16"), Type.GetType("System.Int32"), Type.GetType("System.Int64")
                                                        dtRow(col.ColumnName) = IIf(IsDBNull(row(col.ColumnName)), 0, row(col.ColumnName))
                                                    Case Type.GetType("System.DateTime")
                                                        dtRow(col.ColumnName) = IIf(IsDBNull(row(col.ColumnName)), DBNull.Value, row(col.ColumnName))
                                                    Case Type.GetType("System.Byte()")
                                                        dtRow(col.ColumnName) = IIf(IsDBNull(row(col.ColumnName)), DBNull.Value, row(col.ColumnName))
                                                    Case Type.GetType("System.Boolean")
                                                        If IsDBNull(row(col.ColumnName)) = False AndAlso row(col.ColumnName).ToString.ToLower = "yes" Then
                                                            dtRow(col.ColumnName) = True
                                                        Else
                                                            dtRow(col.ColumnName) = False
                                                        End If
                                                End Select
                                            End If
                                        Next

                                        dsTmp.Tables(rowInfo("TableName")).rows.add(dtRow)

                                    Next

                                End If
                                Application.DoEvents()
                                If IsDBNull(rowInfo("TableName_Details")) = False AndAlso rowInfo("TableName_Details") <> "" AndAlso
                                    IsDBNull(rowInfo("PrefixName_Details")) = False AndAlso rowInfo("PrefixName_Details") <> "" AndAlso
                                    IsDBNull(rowInfo("ColumnKey_Details")) AndAlso rowInfo("ColumnKey_Details") <> "" Then

                                    dtTmp = Nothing
                                    dtTmp = clsPNL_.Load_PNL_ITEM(rowInfo("TableName_Details"), rowInfo("PrefixName_Details") & "_KEY", ID, rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), ErrorLog)

                                    If dtTmp IsNot Nothing Then

                                        For Each row As DataRow In dtTmp.Rows
                                            dtRow = Nothing
                                            dtRow = dsTmp.Tables(rowInfo("TableName_Details")).NewRow

                                            For Each col As DataColumn In dsTmp.Tables(rowInfo("TableName_Details")).columns
                                                If col.ColumnName = rowInfo("ColumnKey") Then
                                                    dtRow(col.ColumnName) = dsTmp.Tables(rowInfo("TableName_Details")).rows.count + 1
                                                Else
                                                    Select Case col.DataType
                                                        Case Type.GetType("System.String")
                                                            dtRow(col.ColumnName) = IIf(IsDBNull(row(col.ColumnName)), "", row(col.ColumnName))
                                                        Case Type.GetType("System.Decimal"), Type.GetType("System.Int16"), Type.GetType("System.Int32"), Type.GetType("System.Int64")
                                                            dtRow(col.ColumnName) = IIf(IsDBNull(row(col.ColumnName)), 0, row(col.ColumnName))
                                                        Case Type.GetType("System.DateTime")
                                                            dtRow(col.ColumnName) = IIf(IsDBNull(row(col.ColumnName)), DBNull.Value, row(col.ColumnName))
                                                        Case Type.GetType("System.Byte()")
                                                            dtRow(col.ColumnName) = IIf(IsDBNull(row(col.ColumnName)), DBNull.Value, row(col.ColumnName))
                                                        Case Type.GetType("System.Boolean")
                                                            If IsDBNull(row(col.ColumnName)) = False AndAlso row(col.ColumnName).ToString.ToLower = "yes" Then
                                                                dtRow(col.ColumnName) = True
                                                            Else
                                                                dtRow(col.ColumnName) = False
                                                            End If
                                                    End Select
                                                End If
                                            Next

                                            dsTmp.Tables(rowInfo("TableName")).rows.add(dtRow)
                                        Next
                                    End If
                                End If

                                clsPNL_.CalcTotalofView(rowInfo, dsTmp, 0, ErrorLog)
                                Application.DoEvents()
                            End If

                        End If
                        ProgressChange((CurrProgress / (clsPNL_.dsDataset.Tables("PNL_INFO").Rows.Count - 5)) * 100, rowInfo("Description"))
                        System.Threading.Thread.Sleep(50)
                    Next
                    ReadOnlyisEdit()


                End If

            End If

            For Each rowInfo As DataRow In clsPNL_.dsDataset.Tables("PNL_INFO").Rows
                If IsDBNull(rowInfo("OldKey")) = False AndAlso rowInfo("OldKey") <> 0 Then
                    clsPNL_.ViewPNL(rowInfo, DsDefault, cboRefNo, cboYA, cboSourceNo, DockManager1, DocumentManager1)
                    Application.DoEvents()
                End If
            Next
            Application.DoEvents()
            DocumentManager1.View.Controller.CloseAll()
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        Finally
            ProgressChange(0, "Im done..Ready to use")
        End Try
    End Sub
    Private Sub ReadOnlyisEdit()
        Try
            cboRefNo.Edit.ReadOnly = isEdit
            cboYA.Edit.ReadOnly = isEdit
            txtRefNo.Edit.ReadOnly = isEdit
            cboCompanyNo.Edit.ReadOnly = isEdit
            cboSourceNo.Edit.ReadOnly = isEdit
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged, cboYA.EditValueChanged
        Try

            txtRefNo.EditValue = cboRefNo.EditValue

            ADO.CreateSourceNo(DsDefault, cboRefNo.EditValue, cboYA.EditValue)

            If DsDefault.Tables("Business_Source").Rows.Count > 0 Then
                If isEdit = False Then
                    cboCompanyNo.EditValue = DsDefault.Tables("Business_Source").Rows(0)("CompanyNo")
                    cboSourceNo.EditValue = DsDefault.Tables("Business_Source").Rows(0)("SourceNo")
                End If
            End If
            Application.DoEvents()

        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub GV_MENU_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GV_MENU.CustomDrawCell
        Try
            Dim dtRow As DataRow = GV_MENU.GetDataRow(e.RowHandle)

            If dtRow IsNot Nothing AndAlso IsDBNull(dtRow("OldKey")) = False AndAlso IsNumeric(dtRow("OldKey")) Then

                If CInt(dtRow("OldKey")) = 0 Then
                    e.Appearance.Font = New Font(e.Appearance.Font.FontFamily, 10, FontStyle.Bold)
                End If

            End If
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub GC_MENU_DoubleClick(sender As Object, e As EventArgs) Handles GC_MENU.DoubleClick
        OpenDetails()
    End Sub
    Private Sub OpenDetails()
        Try
            Dim dtRow As DataRow = GV_MENU.GetDataRow(GV_MENU.FocusedRowHandle)

            If dtRow IsNot Nothing AndAlso IsDBNull(dtRow("OldKey")) = False AndAlso IsNumeric(dtRow("OldKey")) AndAlso CInt(dtRow("OldKey")) <> 0 Then

                clsPNL_.ViewPNL(dtRow, DsDefault, cboRefNo, cboYA, cboSourceNo, DockManager1, DocumentManager1)
            End If
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub cboDecimalPlace_EditValueChanged(sender As Object, e As EventArgs) Handles cboDecimalPlace.EditValueChanged
        Try
            Select Case cboDecimalPlace.EditValue.ToString
                Case "0 =  Exp : 1000"
                    Setting_DecimalPlace_PNL = 0
                Case "1 =  Exp : 1000.1"
                    Setting_DecimalPlace_PNL = 1
                Case "2 =  Exp : 1000.10"
                    Setting_DecimalPlace_PNL = 2
                Case "3 =  Exp : 1000.100"
                    Setting_DecimalPlace_PNL = 3
                Case Else
                    Setting_DecimalPlace_PNL = 0
            End Select

            For Each row As DataRow In clsPNL_.dsDataset.Tables("PNL_INFO").Rows

                If IsDBNull(row("Amount")) = False AndAlso IsNumeric(row("Amount")) Then
                    row("Amount") = CDec(row("Amount")).ToString(GetDecimalPlace(Setting_DecimalPlace_PNL))
                Else
                    If row("OldKey") <> 0 Then
                        row("Amount") = CDec(0).ToString(GetDecimalPlace(Setting_DecimalPlace_PNL))
                    End If

                End If

            Next
            My.Settings.DecimalPlace_PNL = Setting_DecimalPlace_PNL
            My.Settings.Save()
            My.Settings.Reload()
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            Setting_DecimalPlace_PNL = 0
        End Try
    End Sub

    Private Sub btnAllowAllGroupExpanded_EditValueChanged(sender As Object, e As EventArgs) Handles btnAllowAllGroupExpanded.EditValueChanged
        Try
            Setting_AllowAllGroupExpand = CBool(btnAllowAllGroupExpanded.EditValue)


            If clsPNL_.doc_p1Sales IsNot Nothing AndAlso clsPNL_.doc_p1Sales.Controls.Count > 0 AndAlso TypeOf clsPNL_.doc_p1Sales.Controls(0) Is ucPNL_p1Sales Then

                Dim uc As ucPNL_p1Sales = CType(clsPNL_.doc_p1Sales.Controls(0), ucPNL_p1Sales)

                uc.GridView1.OptionsDetail.AllowOnlyOneMasterRowExpanded = Setting_AllowAllGroupExpand

                uc.GridView1.CollapseAllDetails()

                uc.GridView1.ExpandMasterRow(uc.GridView1.FocusedRowHandle)
            End If
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub


    Private Sub btnSpeech_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSpeech.ItemClick
        Try
            If Speaker Is Nothing Then
                Speaker = New SpeechSynthesizer
            End If
            btnSpeech.Enabled = False
            Application.DoEvents()

            Dim str As String = Nothing

            For Each row As DataRow In clsPNL_.dsDataset.Tables("PNL_INFO").Rows
                If IsDBNull(row("OldKey")) = False AndAlso CInt(row("OldKey")) <> 0 Then
                    If IsDBNull(row("Amount")) = False AndAlso IsNumeric(row("Amount")) = True Then
                        If CDec(row("Amount")) = 0 Then
                            str += row("Description").ToString & " zero..."
                        Else
                            str += row("Description").ToString & ", is " & row("Amount").ToString & "..."
                        End If

                    Else
                        str += row("Description").ToString & "..."
                    End If

                End If
            Next

            Speaker.SpeakAsync(str)
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        Finally
            btnSpeech.Enabled = True
            Application.DoEvents()
        End Try
    End Sub

    Private Sub btnStopSpeech_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnStopSpeech.ItemClick
        Try
            If Speaker IsNot Nothing Then
                Speaker.SpeakAsyncCancelAll()
            End If
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            If txtSearch.EditValue IsNot Nothing AndAlso txtSearch.EditValue <> "" Then
                If clsPNL_.PNL_SearchItem(txtSearch.EditValue) Then
                    PNLSEARCHBindingSource.DataSource = clsPNL_.dsDataset.Tables("PNL_SEARCH")
                End If
            End If

        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub GV_SEARCH_DoubleClick(sender As Object, e As EventArgs) Handles GV_SEARCH.DoubleClick
        Try
            Dim dtRow As DataRow = GV_SEARCH.GetDataRow(GV_SEARCH.FocusedRowHandle)

            If dtRow IsNot Nothing AndAlso IsDBNull(dtRow("OldKey")) = False AndAlso IsNumeric(dtRow("OldKey")) AndAlso CInt(dtRow("OldKey")) <> 0 Then
                For Each rowx In clsPNL_.dsDataset.Tables("PNL_INFO").Rows
                    If IsDBNull(rowx("OldKey")) = False AndAlso rowx("OldKey") = dtRow("OldKey") Then
                        dtRow = rowx
                        clsPNL_.ViewPNL(dtRow, DsDefault, cboRefNo, cboYA, cboSourceNo, DockManager1, DocumentManager1)
                        Exit For
                    End If
                Next


            End If
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Try
            If isValid() Then

                Dim CurrentProgress As Integer = 0
                Dim tmpID As Integer = 0
                Dim TaxPayerInfo As DataTable = clsPNL_.Load_TaxPayer_ByRefNo(cboRefNo.EditValue)
                Dim SourceBis As DataTable = clsPNL_.Load_BusinessSource(cboRefNo.EditValue, cboYA.EditValue, cboSourceNo.EditValue.ToString)

                If TaxPayerInfo Is Nothing Then
                    MsgBox("Unable to find tax payer information.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                ProgressChange(0, "checking to save profit and loss")

                If isEdit Then
                    tmpID = ID
                Else
                    tmpID = clsPNL_.GETPNLKEY
                    tmpID += 1
                End If

                Dim dtRow As DataRow = Nothing
                Dim ListOfSQLCmd As New List(Of SqlCommand)

                clsPNL_.dsDataset.Tables("PROFIT_LOSS_ACCOUNT").Rows.Clear()


                dtRow = clsPNL_.dsDataset.Tables("PROFIT_LOSS_ACCOUNT").NewRow
                dtRow("PL_KEY") = tmpID
                dtRow("PL_REF_PREFIX") = IIf(IsDBNull(TaxPayerInfo.Rows(0)("TP_REF_NO_PREFIX")), "", TaxPayerInfo.Rows(0)("TP_REF_NO_PREFIX"))
                dtRow("PL_REF_NO") = cboRefNo.EditValue
                dtRow("PL_FILENO") = IIf(IsDBNull(TaxPayerInfo.Rows(0)("TP_FILE_NO")), "", TaxPayerInfo.Rows(0)("TP_FILE_NO"))
                dtRow("PL_NAME") = IIf(IsDBNull(TaxPayerInfo.Rows(0)("TP_NAME")), "", TaxPayerInfo.Rows(0)("TP_NAME"))
                dtRow("PL_YA") = cboYA.EditValue
                dtRow("PL_MAIN_BUSINESS") = cboSourceNo.EditValue

                For Each rowInfo As DataRow In clsPNL_.dsDataset.Tables("PNL_INFO").Rows

                    If IsDBNull(rowInfo("ColumnName")) = False Then
                        dtRow(rowInfo("ColumnName")) = IIf(IsDBNull(rowInfo("Amount")), 0, rowInfo("Amount"))
                    End If
                Next

                dtRow("PL_COMPANY") = cboCompanyNo.EditValue

                If chkDeclareB.EditValue IsNot Nothing AndAlso chkDeclareB.EditValue Then
                    If SourceBis IsNot Nothing Then
                        dtRow("PL_MAINCOMPANY") = "1" 'IIf(IsDBNull(SourceBis.Rows(0)("BC_SOURCENO")), "", SourceBis.Rows(0)("BC_SOURCENO"))
                    Else
                        dtRow("PL_MAINCOMPANY") = "0"
                    End If
                Else
                    dtRow("PL_MAINCOMPANY") = "0"
                End If

               

                clsPNL_.dsDataset.Tables("PROFIT_LOSS_ACCOUNT").Rows.Add(dtRow)
                Application.DoEvents()

                If isEdit Then
                    clsPNL_.UpdateSQLScriptPNL(clsPNL_.dsDataset.Tables("PROFIT_LOSS_ACCOUNT"), "PL_KEY", tmpID, ListOfSQLCmd)
                Else
                    clsPNL_.InsertSQLScriptPNL(clsPNL_.dsDataset.Tables("PROFIT_LOSS_ACCOUNT"), "", 0, "", tmpID, ListOfSQLCmd)
                End If

                ProgressChange(15, "retrive data from profit and loss")

                Dim tmpDataset As dsPNL = Nothing
                Dim Percentage As Decimal = 0
                Dim Count As Integer = 0

                For Each rowInfo As DataRow In clsPNL_.dsDataset.Tables("PNL_INFO").Rows
                    If IsDBNull(rowInfo("OldKey")) = False AndAlso rowInfo("OldKey") <> 0 Then
                        clsPNL_.ViewPNL(rowInfo, DsDefault, cboRefNo, cboYA, cboSourceNo, DockManager1, DocumentManager1)
                        Application.DoEvents()
                    End If
                Next

                'DELETE
                For Each rowInfo As DataRow In clsPNL_.dsDataset.Tables("PNL_INFO").Rows
                    If IsDBNull(rowInfo("OldKey")) = False AndAlso IsNumeric(rowInfo("OldKey")) AndAlso rowInfo("OldKey") <> 0 AndAlso IsDBNull(rowInfo("KeyName")) = False AndAlso
                         IsDBNull(rowInfo("TableName")) = False AndAlso rowInfo("TableName") <> "" AndAlso IsDBNull(rowInfo("TableName_Details")) = False AndAlso rowInfo("TableName_Details") <> "" Then

                        tmpDataset = clsPNL_.GetDatasetPNL("ds_" & rowInfo("KeyName"))

                        If tmpDataset IsNot Nothing Then
                            clsPNL_.DeleteSQLScriptPNL(rowInfo, tmpID, ListOfSQLCmd)
                        End If
                    End If
                Next

                'ADD
                clsPNL_.GetPNLData_FromItem(tmpID, btnProgress, lblProgress, cboRefNo.EditValue, cboYA.EditValue, TaxPayerInfo.Rows(0), SourceBis.Rows(0), ListOfSQLCmd)
                Dim SqlCon As SqlConnection

                If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                    MsgBox("Unable to connect with database.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                If clsPNL_.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListOfSQLCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name) Then
                    ProgressChange(0, "Im done..Ready to use")
                    DocumentManager1.View.Controller.CloseAll()
                    Application.DoEvents()
                Else
                    MsgBox("Failed to save profit and loss. Please check error log for more information.", MsgBoxStyle.Critical)
                    Exit Sub
                End If


            End If
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        Finally
            ProgressChange(0, "Im done..Ready to use")
        End Try
    End Sub
    'dtRow("PL_SALES") = "" 'IIf(IsDBNull(tmpDTRow("PL_SALES")), 0, tmpDTRow("PL_SALES"))
    'dtRow("PL_OP_STK") = "" 'IIf(IsDBNull(tmpDTRow("PL_OP_STK")), 0, tmpDTRow("PL_OP_STK"))
    'dtRow("PL_PURCHASES") = ""
    'dtRow("PL_PRO_COST") = ""
    'dtRow("PL_PRO_COST_DPC") = ""
    'dtRow("PL_PRO_COST_OAE") = ""
    'dtRow("PL_PRO_COST_ONAE") = ""
    'dtRow("PL_PURCHASES_PRO_COST") = ""
    'dtRow("PL_CLS_STK") = ""
    'dtRow("PL_COGS") = ""
    'dtRow("PL_GROSS_PROFIT") = ""
    'dtRow("PL_OTH_BSIN") = ""
    'dtRow("PL_OTH_IN") = ""
    'dtRow("PL_OTH_IN_DIVIDEND") = ""
    'dtRow("PL_OTH_IN_INTEREST") = ""
    'dtRow("PL_OTH_IN_RENTAL_ROYALTY") = ""
    'dtRow("PL_OTH_IN_OTHER") = ""
    'dtRow("PL_NT_INCOME") = ""
    'dtRow("PL_NT_GAIN_DISPOSAL") = ""
    'dtRow("PL_NT_GAIN_FOREXCHANGE") = ""
    'dtRow("PL_NT_GAIN_INVEST") = ""
    'dtRow("PL_NT_OTHERS") = ""
    'dtRow("PL_EXP_LOANINTEREST") = ""
    'dtRow("PL_EXP_SALARY") = ""
    'dtRow("PL_EXP_RENTAL") = ""
    'dtRow("PL_EXP_CONTRACT") = ""
    'dtRow("PL_EXP_COMMISSION") = ""
    'dtRow("PL_BAD_DEBTS") = ""
    'dtRow("PL_TRAVEL") = ""
    'dtRow("PL_NAE_EPF_PER") = ""
    'dtRow("PL_NAE_EPF_STAFF") = ""
    'dtRow("PL_NAE_LEGALFEE") = ""
    'dtRow("PL_NON_ALLOW_LOSS") = ""
    'dtRow("PL_NAL_LOSS_DISPOSAL") = ""
    'dtRow("PL_NAL_LOSS_FOREXCHANGE") = ""
    'dtRow("PL_NAL_LOSS_INVEST") = ""
    'dtRow("PL_NAL_OTHERS") = ""
    'dtRow("PL_NAE_DEPERECIATION") = ""
    'dtRow("PL_NAE_ENTERTAINMENT") = ""
    'dtRow("PL_NAE_GIFT") = ""
    'dtRow("PL_NAE_DONATION") = ""
    'dtRow("PL_NAE_PENALTY") = ""
    'dtRow("PL_NAE_STOCKDRAWING") = ""
    'dtRow("PL_NAE_CASHDRAWING") = ""
    'dtRow("PL_NAE_PROVISION") = ""
    'dtRow("PL_NAE_PRELIMINARY") = ""
    'dtRow("PL_NAE_CAPITALEXP") = ""
    'dtRow("PL_NAE_INTERESTEXP") = ""
    'dtRow("PL_NAE_ASSETWOFF") = ""
    'dtRow("PL_NAEP_MOTORVEH") = ""
    'dtRow("PL_NAEP_RESIDENTIAL") = ""
    'dtRow("PL_NAEP_TEL") = ""
    'dtRow("PL_NAEP_SUBSCRIPTION") = ""
    'dtRow("PL_NAEP_SEMILAR") = ""
    'dtRow("PL_NAEP_MEDICALEXP") = ""
    'dtRow("PL_NAE_OTHEREXP") = ""
    'dtRow("PL_NAE_TOTALEXP") = ""
    'dtRow("PL_NET_PROFIT_LOSS") = ""
    'dtRow("PL_DISALLOWED_EXP") = ""
    'dtRow("PL_TOTALX") = ""
    'dtRow("PL_TOTALY") = ""
    'dtRow("PL_1") = ""
    'dtRow("PL_2") = ""
    'dtRow("PL_3") = ""
    'dtRow("PL_4") = ""
    'dtRow("PL_5") = ""
    'dtRow("PL_REP_MAINT") = ""
    'dtRow("PL_PRO_ADV") = ""
    'dtRow("PL_JKDM") = ""
    Private Sub ProgressChange(ByVal Value As Integer, ByVal Title As String)
        Try
            'btnProgress.Value = Value
            'lblProgress.Text = Title
            btnProgress.EditValue = Value
            lblProgress.Caption = Title

            If Title = "Im done..Ready to use" Then
                ProgressPanel1.Visible = False
                docMainMenu.Enabled = True
            Else
                ProgressPanel1.Visible = True
                docMainMenu.Enabled = False
            End If
            Application.DoEvents()

        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Function isValid() As Boolean
        Try
            If cboRefNo.EditValue Is Nothing OrElse cboRefNo.EditValue = "" Then
                MsgBox("Please select tax payer information.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If cboYA.EditValue Is Nothing OrElse cboYA.EditValue = "" Then
                MsgBox("Please select year assessment.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If cboCompanyNo.EditValue Is Nothing OrElse cboCompanyNo.EditValue = "" Then
                MsgBox("Please select company number.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If cboSourceNo.EditValue Is Nothing OrElse cboSourceNo.EditValue = "" Then
                MsgBox("Please select source number.", MsgBoxStyle.Exclamation)
                Return False
            End If


            If isEdit = False Then

                If clsPNL_.Check_PNL_Exist(cboRefNo.EditValue, cboYA.EditValue) Then
                    Dim rlst As MsgBoxResult = MessageBox.Show("Profit and Loss already, do you want to replace?" & vbCrLf & "Warning!! previous data will be loss.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If rlst = MsgBoxResult.Yes Then
                        Dim dt As DataTable = clsPNL_.Load_PNL(cboRefNo.EditValue, cboYA.EditValue, ErrorLog)

                        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("PL_KEY")) = False Then
                            ID = dt.Rows(0)("PL_KEY")
                            isEdit = True
                        Else
                            Return False
                        End If
                    Else
                        Return False
                    End If

                End If
            End If
            Return True
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            Return False
        End Try
    End Function
#Region "AI"
    Private Sub Ai()
        Try
            If txtAi.EditValue Is Nothing Or txtAi.EditValue = "" Then
                Exit Sub
            End If

            If clsPNL_.dsDataset.Tables("Ai").Rows.Count = 0 Then
                Ai_Finish()
            End If
            Dim AiRow As DataRow = clsPNL_.dsDataset.Tables("Ai").Rows(clsPNL_.dsDataset.Tables("Ai").Rows.Count - 1)

            If IsDBNull(AiRow("JobType")) OrElse AiRow("JobType") = "" Then


                If txtAi.EditValue.ToString.ToLower.Contains("insert") Or txtAi.EditValue.ToString.ToLower.Contains("add") Then

                    Dim rawStr As String = txtAi.EditValue

                    Dim DataStr As String = ""
                    Dim Amount As String = ""
                    Dim Category As String = ""

                    Dim IndxInsertAdd As Integer = 0
                    Dim IndxAtToInto As Integer = 0

                    If txtAi.EditValue.ToString.ToLower.Contains("insert") Then
                        IndxInsertAdd = rawStr.ToLower.IndexOf("insert") + 6
                    ElseIf txtAi.EditValue.ToString.ToLower.Contains("add") Then
                        IndxInsertAdd = rawStr.ToLower.IndexOf("add") + 3
                    End If

                    If rawStr.ToLower.Contains("at") Or rawStr.ToLower.Contains("into") Or rawStr.ToLower.Contains("to") Then
                        If txtAi.EditValue.ToString.ToLower.Contains("at") Then
                            IndxAtToInto = rawStr.ToLower.IndexOf("at")
                        ElseIf txtAi.EditValue.ToString.ToLower.Contains("into") Then
                            IndxAtToInto = rawStr.ToLower.IndexOf("into")
                        ElseIf txtAi.EditValue.ToString.ToLower.Contains("to") Then
                            IndxAtToInto = rawStr.ToLower.IndexOf("to")
                        End If
                    End If
                    DataStr = rawStr.Substring(IndxInsertAdd, IndxAtToInto - IndxInsertAdd)

                    Ai_Convertion(DataStr, "")

                End If


                Select Case txtAi.EditValue.ToString.ToLower.Trim
                    Case "open"
                        Ai_Convertion("Please enter number ID you want to open", "open")
                        Application.DoEvents()

                        Dim aiRowResult As DataRow = clsPNL_.dsDataset.Tables("Ai").Rows(clsPNL_.dsDataset.Tables("Ai").Rows.Count - 1)
                        For Each rowinfo As DataRow In clsPNL_.dsDataset.Tables("PNL_INFO").Rows
                            If IsDBNull(rowinfo("Oldkey")) = False AndAlso rowinfo("Oldkey") <> 0 Then
                                Ai_Result(aiRowResult("ID"), rowinfo("Description"), rowinfo("KeyName"))
                            End If
                        Next

                        GVAi.SetMasterRowExpanded(clsPNL_.dsDataset.Tables("Ai").Rows.Count - 1, True)

                    Case "insert"
                        Ai_Convertion("Please enter which category you want to insert.", "insert")
                    Case "delete"

                    Case "close"
                        Ai_Convertion("Okay. close this window without save?", "close")
                    Case "closewithoutsave", "closenosave", "closeoutsave"
                        Ai_Convertion("closing window now.", "")
                        Application.DoEvents()
                    Case "closesave", "closeandsave"

                    Case "exit"

                    Case "hello", "hye", "elo", "hai", "hi"
                        Ai_Convertion("hello,you can choose to open or insert or close or info", "")
                    Case "info"
                        Ai_Convertion("I am Jerry,i am Artificial intelligence for taxcom. i can help you to faster create profit and loss. my command is open or insert or close or info", "")
                    Case Else
                        If txtAi.EditValue.ToString.ToLower.Trim.Contains("sing") AndAlso txtAi.EditValue.ToString.ToLower.Trim.Contains("song") Then
                            Ai_Convertion("apakah semua orang dengan saya", "")
                        Else
                            Ai_Convertion("my command is open or insert or close or info", "")
                        End If

                End Select
            Else
                Select Case AiRow("JobType").ToString.ToLower
                    Case "open"
                        Dim aiRowResult As DataRow = Nothing
                        For Each rowAix As DataRow In clsPNL_.dsDataset.Tables("Ai_Result").Rows
                            If txtAi.EditValue.ToString.ToLower = CStr(rowAix("ID")) Then
                                aiRowResult = rowAix
                            End If
                        Next

                        For Each rowinfo As DataRow In clsPNL_.dsDataset.Tables("PNL_INFO").Rows
                            If IsDBNull(rowinfo("Oldkey")) = False AndAlso rowinfo("Oldkey") <> 0 Then

                                If rowinfo("KeyName") = aiRowResult("Q1") Then
                                    Ai_Convertion("Okay", "")
                                    Application.DoEvents()
                                    clsPNL_.ViewPNL(rowinfo, DsDefault, cboRefNo, cboYA, cboSourceNo, DockManager1, DocumentManager1)
                                    Ai_Finish()
                                    Exit Sub
                                End If

                            End If
                        Next
                        Ai_Convertion("Ops!! sorry i can't find. please enter correct category.", "open")
                    Case "insert"
                        For Each rowinfo As DataRow In clsPNL_.dsDataset.Tables("PNL_INFO").Rows
                            If IsDBNull(rowinfo("Oldkey")) = False AndAlso rowinfo("Oldkey") <> 0 Then

                                If rowinfo("Description").ToString.ToLower.Contains(txtAi.EditValue.ToString.ToLower) Then
                                    Ai_Convertion("Okay insert data to " & rowinfo("Description"), "insert data", rowinfo("KeyName"))
                                    clsPNL_.ViewPNL(rowinfo, DsDefault, cboRefNo, cboYA, cboSourceNo, DockManager1, DocumentManager1)
                                    Ai_Convertion("insert data Description --- Amount. example (Sale turn over --- 10000) ", "insert data", rowinfo("KeyName"))
                                    Exit Sub
                                End If

                            End If
                        Next
                        Ai_Convertion("Ops!! sorry i can't find. please enter correct category.", "open")
                    Case "insert data"
                        Dim ds As dsPNL = clsPNL_.GetDatasetPNL("ds_" & AiRow("KeyName"))

                        If ds IsNot Nothing Then
                            Dim dtRow As DataRow = Nothing
                            Dim Description As String = ""
                            Dim Amount As Decimal = 0

                            Dim split() As String = txtAi.EditValue.ToString.Split("---")

                            If split.Count = 4 Then
                                Description = split(0)
                                If IsNumeric(split(3)) = False Then
                                    Amount = 0
                                Else
                                    Amount = CDec(split(3))
                                End If
                            Else
                                If txtAi.EditValue.ToString.Trim.ToLower = "exit" Then
                                    Ai_Finish()
                                Else
                                    Ai_Convertion("Ops!! you enter invalid data.", "insert data", AiRow("KeyName"))
                                End If
                                Exit Sub
                            End If

                            For Each rowinfo As DataRow In clsPNL_.dsDataset.Tables("PNL_INFO").Rows
                                If rowinfo("KeyName") = AiRow("KeyName") Then

                                    dtRow = ds.Tables(rowinfo("TableName")).newrow

                                    For Each col As DataColumn In ds.Tables(rowinfo("TableName")).columns
                                        If col.ColumnName <> rowinfo("ColumnKey") Then

                                            If col.ColumnName = rowinfo("ColumnSource") Then
                                                dtRow(col.ColumnName) = cboSourceNo.EditValue
                                            ElseIf col.ColumnName = rowinfo("PrefixName") & "_PLTYPE" Then
                                                dtRow(col.ColumnName) = rowinfo("OldKey")
                                            ElseIf col.ColumnName = rowinfo("PrefixName") & "_DESC" Then
                                                dtRow(col.ColumnName) = Description
                                            ElseIf col.ColumnName = rowinfo("ColumnAmount") Then
                                                dtRow(col.ColumnName) = Amount
                                            ElseIf col.ColumnName = rowinfo("PrefixName") & "_TAXABLE" Or col.ColumnName = rowinfo("PrefixName") & "_DEDUCTIBLE" Then
                                                dtRow(col.ColumnName) = False
                                            End If

                                        End If
                                    Next
                                    ds.Tables(rowinfo("TableName")).rows.add(dtRow)
                                    Ai_Convertion("Done", "insert data", rowinfo("KeyName"))
                                    Exit Sub
                                End If
                            Next
                        Else
                            Ai_Convertion("Ops!! sorry i can't find. please enter correct category.", "insert")
                        End If
                    Case "close"
                        If txtAi.EditValue.ToString.ToLower = "ok" Or txtAi.EditValue.ToString.ToLower = "yes" Or txtAi.EditValue.ToString.ToLower = "okay" Then
                            Ai_Convertion("closing window now.", "")
                            Application.DoEvents()
                            Me.Close()
                        Else
                            Ai_Convertion("cancelling close", "")
                            Ai_Finish()
                        End If
                End Select
            End If


        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub docAi_GotFocus(sender As Object, e As EventArgs) Handles docAi.GotFocus, GCAi.GotFocus, txtAi.GotFocus
        Try
            If AiFirstTime = False Then
                AiFirstTime = True

                Ai_Convertion("What should i do?", "")
                txtAi.Focus()

            End If
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Ai_Finish()
        Try
            clsPNL_.dsDataset.Tables("Ai_Result").Rows.Clear()
            clsPNL_.dsDataset.Tables("Ai").Rows.Clear()
            Application.DoEvents()
            Ai_Convertion("What should i do?", "")
            txtAi.Focus()
            AiFirstTime = False


        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Ai_Convertion(ByVal Communication As String, ByVal JobType As String, Optional ByVal KeyName As String = "", Optional ByVal From As String = "Jerry")
        Try
            Dim dtRow As DataRow = Nothing

            dtRow = clsPNL_.dsDataset.Tables("Ai").NewRow
            dtRow("From") = From
            dtRow("Communication") = Communication
            dtRow("JobType") = JobType
            dtRow("KeyName") = KeyName
            clsPNL_.dsDataset.Tables("Ai").Rows.Add(dtRow)

            If Speaker Is Nothing Then
                Speaker = New SpeechSynthesizer
            End If
            Application.DoEvents()
            Speaker.SpeakAsync(Communication)

            txtAi.EditValue = ""

            GVAi.MoveLast()
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Ai_Result(ByVal ParentID As Integer, ByVal Description As String, Optional ByVal Q1 As String = "", Optional ByVal Q2 As String = "", Optional ByVal Q3 As String = "")
        Try
            Dim dtRow As DataRow = Nothing

            dtRow = clsPNL_.dsDataset.Tables("Ai_Result").NewRow
            dtRow("Description") = Description
            dtRow("Q1") = Q1
            dtRow("Q2") = Q2
            dtRow("Q2") = Q3
            dtRow("ParentID") = ParentID
            clsPNL_.dsDataset.Tables("Ai_Result").Rows.Add(dtRow)

            GVAi.MoveLast()
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub txtAi_EditValueChanged(sender As Object, e As EventArgs) Handles txtAi.EditValueChanged

    End Sub
    Private Sub txtAi_KeyUp(sender As Object, e As KeyEventArgs) Handles txtAi.KeyUp
        Try
            If e.KeyCode = Keys.Enter Then
                Ai()
            End If
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub
#End Region

    Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
        Me.LoadData()
    End Sub
End Class