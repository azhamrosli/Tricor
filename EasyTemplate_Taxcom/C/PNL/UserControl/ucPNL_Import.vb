Imports System.Data.OleDb

Public Class ucPNL_Import
    Dim ErrorLog As ClsError = Nothing
    Public txt_p1Sales As DevExpress.XtraEditors.TextEdit = Nothing

    Public txt_p1OpenStock As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p1Purchase As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p1Depreciation As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p1AllowanceExpenses As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p1NonAllowableExpenses As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p1CloseStock As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p2OtherBizIncome As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p2ForeignCurrExGain As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p2DivIncome As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p2InterestIncome As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p2RentalIncome As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p2RoyaltyIncome As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p2OtherIncome As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p2ProDispPlantEq As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p2ProDisInvestment As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p2ExemptDividend As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p2ForeIncomeRemmit As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p2UnreaGainForeEx As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p2ReaForeExGainNonTrade As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p2UnreaGainForeExNon As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p2Other As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p3InterestResPurS33 As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p3OtherInterestExHirePur As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p3ProTechManLeganFees As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p3TechPayNonResis As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p3ContractPay As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p3DirectorFee As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p3Salary As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p3COEStock As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p3Royalty As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p3Rental As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p3RepairMain As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p3ResearchDev As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p3PromotionAds As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p3Travelling As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p3ForeignCurrExLoss As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p3JKDM As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p3Depreciation As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p3DonationApp As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p3DonationNonApp As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p3Zakat As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p4LossDispFA As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p4EntNonStaff As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p4EntStaff As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p4Compound As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p4ProvisionAcc As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p4LeavePass As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p4FAWrittenOff As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p4UnreaLossForeEx As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p4ReaLossForeExTrade As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p4ReaLossForeExNonTrade As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p4InitSub As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p4CAExpenditure As DevExpress.XtraEditors.TextEdit = Nothing
    Public txt_p4Other As DevExpress.XtraEditors.TextEdit = Nothing


    Public cboRefNo As DevExpress.XtraBars.BarEditItem
    Public cboYA As DevExpress.XtraBars.BarEditItem

    Public Const MainTable As String = "ExportPNL" 'PLFST_SALES
    Public Const MainTable_Details As String = "ExportPNL_Details"
    Public SourceNo As Integer = 0
    Dim MainDataSet As DataSet = Nothing
    Dim dtPNLInfo As DataTable = Nothing
    Public Property MainData() As DataSet
        Get
            Return MainDataSet
        End Get
        Set(ByVal value As DataSet)
            MainDataSet = value
        End Set
    End Property
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If ADO Is Nothing Then
            ADO = New clsIODatabase
        End If
    End Sub
    Private Sub Import_Data()
        Dim tmp_ParentID As String = ""
        Dim tmp_ID As String = ""
        lblError.Text = ""
        dtPNLInfo = Nothing
        Application.DoEvents()


        dtPNLInfo = ADO.Load_PNLINFO()
        Try
            Dim tableName As String = "Sheet"
            Dim adapter As OleDbDataAdapter
            Dim strSQL As String = Nothing
            Dim dtRow As DataRow = Nothing
            Dim connectionString As String = ""

            If txtFileUrl.EditValue.ToString.EndsWith(".xlsx") Then            '2007 Format            
                connectionString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;HDR=No'", txtFileUrl.EditValue)
            Else            '2003 Format            
                connectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=No'", txtFileUrl.EditValue)
            End If

            Dim ds = New DataSet()
            strSQL = "select * from [Sheet$]"
            adapter = New OleDbDataAdapter(strSQL, connectionString)
            adapter.Fill(ds, "Sheet")

            MainDataSet.Tables(MainTable_Details).Rows.Clear()
            MainDataSet.Tables(MainTable).Rows.Clear()
            Dim loopx As Integer = -1
            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each rowx As DataRow In ds.Tables(0).Rows
                    tmp_ParentID = ""
                    tmp_ID = ""
                    loopx += 1
                    If loopx = 0 AndAlso chkisFirstRowHeader.Checked = True Then

                    Else
                        If IsDBNull(rowx(0)) = False AndAlso rowx(0).ToString <> "" Then

                            If rowx(1) IsNot Nothing AndAlso rowx(1).ToString <> "" AndAlso IsNumeric(rowx(1)) = True Then
                                dtRow = MainDataSet.Tables(MainTable_Details).NewRow
                                dtRow("No") = rowx(0)
                                dtRow("No2") = rowx(1)
                                tmp_ID = rowx(0)
                                tmp_ParentID = rowx(1)
                                dtRow("Type") = rowx(2)
                                dtRow("Description") = rowx(3)
                                dtRow("LeftAmount") = rowx(4)
                                dtRow("RightAmount") = rowx(5)
                                MainDataSet.Tables(MainTable_Details).Rows.Add(dtRow)
                            Else
                                dtRow = MainDataSet.Tables(MainTable).NewRow
                                dtRow("No") = rowx(0)
                                If rowx(1) Is Nothing OrElse IsNumeric(rowx(1)) = False Then
                                    dtRow("No2") = -1
                                Else
                                    dtRow("No2") = rowx(1)
                                End If
                                dtRow("Type") = rowx(2)
                                dtRow("Description") = rowx(3)
                                dtRow("LeftAmount") = rowx(4)
                                dtRow("RightAmount") = rowx(5)
                                MainDataSet.Tables(MainTable).Rows.Add(dtRow)
                            End If

                        End If
                    End If

                Next
            End If

            ExportPNLBindingSource.DataSource = MainDataSet.Tables(MainTable)
            ds = Nothing
        Catch ex As Exception

            '  If ex.Message.ToString.Contains("ForeignKeyConstraint FK_ExportPNL_ExportPNL_Details") Then
            If ex.Message.ToString.Contains("FK_ExportPNL_ExportPNL_Details") Then
                lblError.Text = "Ops!! Some data you import is invalid parent ID. please change and try again." & vbCrLf & "Details : " & vbCrLf & "No : " & tmp_ID & vbCrLf & "Parent ID : " & tmp_ParentID
                MsgBox("Ops!! Some data you import is invalid parent ID. please change and try again." & vbCrLf & "Details : " & vbCrLf & "No : " & tmp_ID & vbCrLf & "Parent ID : " & tmp_ParentID, MsgBoxStyle.Exclamation)
            Else
                Dim st As New StackTrace(True)
                st = New StackTrace(ex, True)
                If ErrorLog Is Nothing Then
                    ErrorLog = New ClsError
                End If
                With ErrorLog
                    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                    .ErrorCode = "C1001"
                    .ErrorDateTime = Now
                    .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
                End With

                AddListOfError(ErrorLog)
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End If

        End Try
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        Try
            txtFileUrl.ReadOnly = False

            OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;"

            Dim rslt As DialogResult = OpenFileDialog1.ShowDialog

            If rslt = Windows.Forms.DialogResult.OK Then

                txtFileUrl.EditValue = OpenFileDialog1.FileName

            End If


            If System.IO.File.Exists(txtFileUrl.EditValue) = False Then
                MsgBox("File not exist", MsgBoxStyle.Exclamation)
                txtFileUrl.ReadOnly = False
                Exit Sub
            Else
                txtFileUrl.ReadOnly = True
            End If

            Import_Data()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Try
            If System.IO.File.Exists(txtFileUrl.EditValue) = False Then
                MsgBox("File not exist", MsgBoxStyle.Exclamation)
                txtFileUrl.ReadOnly = False
                Exit Sub
            Else
                txtFileUrl.ReadOnly = True
            End If

            Import_Data()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub TransferSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferSelectedToolStripMenuItem.Click
        Try

            Dim dtRow As DataRow = Nothing
            Dim Type As mdlEnum.TaxComPNLEnuItem = TaxComPNLEnuItem.CLOSESTOCK

            Dim contrl As Control = Nothing
            Dim dsControl As DataSet = Nothing
            Dim obj As Object = Nothing
            Dim txt As DevExpress.XtraEditors.TextEdit = Nothing
            Dim isHasChild As Boolean = False
            Dim TableName_ As String = Nothing
            Dim ColumnName_ As String = Nothing
            If dtPNLInfo IsNot Nothing Then
                For Each i As Integer In GridView1.GetSelectedRows
                    isHasChild = False
                    dtRow = GridView1.GetDataRow(i)

                    If dtRow IsNot Nothing Then
                        Type = DirectCast([Enum].Parse(GetType(mdlEnum.TaxComPNLEnuItem), dtRow("Type")), mdlEnum.TaxComPNLEnuItem)

                        txt = GetTableName(Type)
                        If dtRow.GetChildRows("FK_ExportPNL_ExportPNL_Details").Length > 0 Then
                            isHasChild = True
                        End If
                        If mdlPNL2.TransferFromImport_ToMain(MainDataSet, dtRow, Type, SourceNo, cboRefNo.EditValue, _
                                                             cboYA.EditValue, dtPNLInfo, isHasChild, TableName_, ColumnName_, ErrorLog) Then
                            GridView1.DeleteRow(i)
                            CalcTotalofView(txt, MainDataSet, TableName_, ColumnName_, 0, ErrorLog)
                        Else
                            MsgBox("Failed to transfer to main table." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                            Exit For
                        End If
                    End If
                Next
            End If
            
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub TransferAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferAllToolStripMenuItem.Click
        Try
            Dim dtRow As DataRow = Nothing
            Dim Type As mdlEnum.TaxComPNLEnuItem = TaxComPNLEnuItem.CLOSESTOCK

            Dim contrl As Control = Nothing
            Dim dsControl As DataSet = Nothing
            Dim ListofRow As New List(Of DataRow)
            Dim TableAmount As String = ""
            Dim obj As Object = Nothing
            Dim txt As DevExpress.XtraEditors.TextEdit = Nothing
            Dim RowInfo As DataRow = Nothing
            Dim isHasChild As Boolean = False
            Dim TableName_ As String = Nothing
            Dim ColumnName_ As String = Nothing
            If dtPNLInfo IsNot Nothing Then
                For i As Integer = 0 To dsDataSet.Tables(Me.MainTable).Rows.Count - 1
                    dtRow = dsDataSet.Tables(Me.MainTable).Rows(i)

                    If dtRow IsNot Nothing AndAlso IsDBNull(dtRow("No")) = False Then

                        Type = DirectCast([Enum].Parse(GetType(mdlEnum.TaxComPNLEnuItem), dtRow("Type")), mdlEnum.TaxComPNLEnuItem)

                        txt = GetTableName(Type)
                        If dtRow.GetChildRows("FK_ExportPNL_ExportPNL_Details").Length > 0 Then
                            isHasChild = True
                        End If
                        If mdlPNL2.TransferFromImport_ToMain(MainDataSet, dtRow, Type, SourceNo, cboRefNo.EditValue, _
                                                             cboYA.EditValue, dtPNLInfo, isHasChild, TableName_, ColumnName_, ErrorLog) Then
                            '  GridView1.DeleteRow(i)
                            ListofRow.Add(dtRow)
                            CalcTotalofView(txt, MainDataSet, TableName_, ColumnName_, 0, ErrorLog)
                            ' dsDataSet.Tables(Me.MainTable).Rows(i).Delete()
                        Else
                            MsgBox("Failed to transfer to main table.", MsgBoxStyle.Critical)
                            Exit For
                        End If
                    End If
                Next
            End If
           


            For i As Integer = 0 To ListofRow.Count - 1
                'x = -1
                'For Each rowx As DataRow In dsDataSet.Tables(Me.MainTable).Rows
                '    x += 1
                '    If IsDBNull(rowx("No")) = False AndAlso rowx("No") = ListofRow(i) Then
                '        dsDataSet.Tables(Me.MainTable).Rows(x).Delete()

                '    End If
                'Next

                'For x As Integer = 0 To (dsDataSet.Tables(Me.MainTable).Rows.Count - 1)
                '    If IsDBNull(dsDataSet.Tables(Me.MainTable).Rows(x)("No")) = False AndAlso dsDataSet.Tables(Me.MainTable).Rows(x)("No") = ListofRow(i) Then


                '    End If

                'Next
                dsDataSet.Tables(Me.MainTable).Rows.Remove(ListofRow(i))
            Next
            ' dsDataSet.Tables(Me.MainTable).AcceptChanges()

            MsgBox("Successfully Import to main table.", MsgBoxStyle.Information)

            'dsDataSet.Tables(Me.MainTable).AcceptChanges()
            'Application.DoEvents()

            'ExportPNLBindingSource.DataSource = dsDataSet.Tables(Me.MainTable)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub TransferToManual(ByVal Type As mdlEnum.TaxComPNLEnuItem)
        Try
            Try
                Dim dtRow As DataRow = Nothing

                Dim contrl As Control = Nothing
                Dim dsControl As DataSet = Nothing
                Dim TableAmount As String = ""
                Dim obj As Object = Nothing
                Dim txt As DevExpress.XtraEditors.TextEdit = Nothing
                Dim RowInfo As DataRow = Nothing
                Dim isHasChild As Boolean = False
                Dim TableName_ As String = Nothing
                Dim ColumnName_ As String = Nothing
                If dtPNLInfo Is Nothing Then
                    For Each i As Integer In GridView1.GetSelectedRows

                        dtRow = GridView1.GetDataRow(i)

                        If dtRow IsNot Nothing Then

                            txt = GetTableName(Type)
                            If dtRow.GetChildRows("FK_ExportPNL_ExportPNL_Details").Length > 0 Then
                                isHasChild = True
                            End If
                            If mdlPNL2.TransferFromImport_ToMain(MainDataSet, dtRow, Type, SourceNo, _
                                                                 cboRefNo.EditValue, cboYA.EditValue, dtPNLInfo, isHasChild, TableName_, ColumnName_, ErrorLog) Then
                                GridView1.DeleteRow(i)
                                CalcTotalofView(txt, MainDataSet, TableName_, ColumnName_, 0, ErrorLog)
                            Else
                                MsgBox("Failed to transfer to main table." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                                Exit For
                            End If
                        End If
                    Next
                End If
               
            Catch ex As Exception
                Dim st As New StackTrace(True)
                st = New StackTrace(ex, True)

            End Try
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub OpenNormalTemplateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenNormalTemplateToolStripMenuItem.Click
        Try
            btnOpenFile.PerformClick()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub OpenYGLECorpTemplateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenYGLECorpTemplateToolStripMenuItem.Click
        Try
            btnOpenFileYGL.PerformClick()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    
    Private Function GetTableName(ByVal Type As TaxComPNLEnuItem) As DevExpress.XtraEditors.TextEdit
        Try
            Dim txt As DevExpress.XtraEditors.TextEdit = Nothing
            Select Case Type
                Case TaxComPNLEnuItem.SALES
                    txt = txt_p1Sales
                Case TaxComPNLEnuItem.OPENSTOCK
                    txt = txt_p1OpenStock
                Case TaxComPNLEnuItem.PURCHASE
                    txt = txt_p1Purchase
                Case TaxComPNLEnuItem.DEPRECIATION
                    txt = txt_p1Depreciation
                Case TaxComPNLEnuItem.OTHERALLOWEXP
                    txt = txt_p1AllowanceExpenses
                Case TaxComPNLEnuItem.OTHERNONALLOWEXP
                    txt = txt_p1NonAllowableExpenses
                Case TaxComPNLEnuItem.CLOSESTOCK
                    txt = txt_p1CloseStock
                Case TaxComPNLEnuItem.OTHERBUSINC
                    txt = txt_p2OtherBizIncome
                Case TaxComPNLEnuItem.DIVIDENDINC
                    txt = txt_p2DivIncome
                Case TaxComPNLEnuItem.INTERESTINC
                    txt = txt_p2InterestIncome
                Case TaxComPNLEnuItem.RENTALINC
                    txt = txt_p2RentalIncome
                Case TaxComPNLEnuItem.ROYALTYINC
                    txt = txt_p2RoyaltyIncome
                Case TaxComPNLEnuItem.OTHERINC
                    txt = txt_p2OtherIncome
                Case TaxComPNLEnuItem.PDFIXASSET
                    txt = txt_p2ProDispPlantEq
                Case TaxComPNLEnuItem.PDINVEST
                    txt = txt_p2ProDisInvestment
                Case TaxComPNLEnuItem.EXEMDIV
                    txt = txt_p2ExemptDividend
                Case TaxComPNLEnuItem.FORINCREMIT
                    txt = txt_p2ForeIncomeRemmit
                Case TaxComPNLEnuItem.REALFE
                    txt = txt_p2UnreaGainForeEx
                Case TaxComPNLEnuItem.UNREALFETRADE
                    txt = txt_p2UnreaGainForeExNon
                Case TaxComPNLEnuItem.UNREALFENONTRADE
                    txt = txt_p2ReaForeExGainNonTrade
                Case TaxComPNLEnuItem.OTHERNONTAXINC
                    txt = txt_p2Other
                Case TaxComPNLEnuItem.INTERESTRESTRICT
                    txt = txt_p3InterestResPurS33
                Case TaxComPNLEnuItem.EXPOTHERINTEREST
                    txt = txt_p3OtherInterestExHirePur
                Case TaxComPNLEnuItem.EXPLEGAL
                    txt = txt_p3ProTechManLeganFees
                Case TaxComPNLEnuItem.EXPTECHNICAL
                    txt = txt_p3TechPayNonResis
                Case TaxComPNLEnuItem.EXPCONTRACTPAY
                    txt = txt_p3ContractPay
                Case TaxComPNLEnuItem.EXPDIRECTORFEE
                    txt = txt_p3DirectorFee
                Case TaxComPNLEnuItem.EXPSALARY
                    txt = txt_p3Salary
                Case TaxComPNLEnuItem.EXPEMPLOYEESTOCK
                    txt = txt_p3COEStock
                Case TaxComPNLEnuItem.EXPROYALTY
                    txt = txt_p3Royalty
                Case TaxComPNLEnuItem.EXPRENTAL
                    txt = txt_p3Rental
                Case TaxComPNLEnuItem.EXPREPAIRMAINTENANCE
                    txt = txt_p3RepairMain
                Case TaxComPNLEnuItem.EXPRND
                    txt = txt_p3ResearchDev
                Case TaxComPNLEnuItem.EXPADVERTISEMENT
                    txt = txt_p3PromotionAds
                Case TaxComPNLEnuItem.EXPTRAVEL
                    txt = txt_p3Travelling
                Case TaxComPNLEnuItem.EXPJKDM
                    txt = txt_p3JKDM
                Case TaxComPNLEnuItem.EXPDEPRECIATION
                    txt = txt_p3Depreciation
                Case TaxComPNLEnuItem.EXPDONATIONAPPR
                    txt = txt_p3DonationApp
                Case TaxComPNLEnuItem.EXPDONATIONNONAPPR
                    txt = txt_p3DonationNonApp
                Case TaxComPNLEnuItem.EXPZAKAT
                    txt = txt_p3Zakat
                Case TaxComPNLEnuItem.EXPLOSSDISPFA
                    txt = txt_p4LossDispFA
                Case TaxComPNLEnuItem.EXPENTERTAINNONSTAFF
                    txt = txt_p4EntNonStaff
                Case TaxComPNLEnuItem.EXPENTERTAINSTAFF
                    txt = txt_p4EntStaff
                Case TaxComPNLEnuItem.EXPCOMPAUNDPENALTY
                    txt = txt_p4Compound
                Case TaxComPNLEnuItem.EXPPROVISION
                    txt = txt_p4ProvisionAcc
                Case TaxComPNLEnuItem.EXPLEAVEPASSAGE
                    txt = txt_p4LeavePass
                Case TaxComPNLEnuItem.EXPFAWRITTENOFF
                    txt = txt_p4FAWrittenOff
                Case TaxComPNLEnuItem.EXPUNREALLOSSFE
                    txt = txt_p4UnreaLossForeEx
                Case TaxComPNLEnuItem.EXPREALLOSSFETRADE
                    txt = txt_p4ReaLossForeExTrade
                Case TaxComPNLEnuItem.EXPREALLOSSFENONTRADE
                    txt = txt_p4ReaLossForeExNonTrade
                Case TaxComPNLEnuItem.EXPINITIALSUBSCRIPT
                    txt = txt_p4InitSub
                Case TaxComPNLEnuItem.EXPCAPITALEXPENDITURE
                    txt = txt_p4CAExpenditure
                Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
                    txt = txt_p4Other
                Case TaxComPNLEnuItem.REALFETRADE
                    txt = txt_p2ForeignCurrExGain
                Case Else

            End Select

            Return txt
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            Return Nothing
        End Try
    End Function
#Region "CONTENT_MENU_CLICK"
    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.SALES)
    End Sub

    Private Sub OpeningStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpeningStockToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.OPENSTOCK)
    End Sub

    Private Sub DeprecationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeprecationToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.DEPRECIATION)
    End Sub

    Private Sub OtherAllowableExpensesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtherAllowableExpensesToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.OTHERALLOWEXP)
    End Sub

    Private Sub OtherNonAllowableExpensesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtherNonAllowableExpensesToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.OTHERNONALLOWEXP)
    End Sub

    Private Sub ClosingStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClosingStockToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.CLOSESTOCK)
    End Sub

    Private Sub OtherBusinessIncomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtherBusinessIncomeToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.OTHERBUSINC)
    End Sub

    Private Sub RealisedForeignExchangeGainTradeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RealisedForeignExchangeGainTradeToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.REALFETRADE)
    End Sub

    Private Sub DividendIncomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DividendIncomeToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.DIVIDENDINC)
    End Sub

    Private Sub InterestIncomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InterestIncomeToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.INTERESTINC)
    End Sub

    Private Sub RentalIncomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RentalIncomeToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.RENTALINC)
    End Sub

    Private Sub RoyaltyIncomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoyaltyIncomeToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.ROYALTYINC)
    End Sub

    Private Sub OtherIncomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtherIncomeToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.OTHERINC)
    End Sub

    Private Sub ProfitOnDisposalOfFixedAssetsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfitOnDisposalOfFixedAssetsToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.PDFIXASSET)
    End Sub

    Private Sub ProfitOnDisposalOfInvestmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfitOnDisposalOfInvestmentToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.PDINVEST)
    End Sub

    Private Sub ExemptDividendToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExemptDividendToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXEMDIV)
    End Sub

    Private Sub ForeignIncomeRemittanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForeignIncomeRemittanceToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.FORINCREMIT)
    End Sub

    Private Sub RealisedForeignExchangeGainArisingFromCapitalTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RealisedForeignExchangeGainArisingFromCapitalTransactionToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.REALFE)
    End Sub

    Private Sub UnrealisedGainOnForeignExchangeTradeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnrealisedGainOnForeignExchangeTradeToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.UNREALFENONTRADE)
    End Sub

    Private Sub UnrealisedGainOnForeginExchangeNonTradeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnrealisedGainOnForeginExchangeNonTradeToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.UNREALFETRADE)
    End Sub

    Private Sub OtherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtherToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.OTHERNONTAXINC)
    End Sub

    Private Sub InterestRestrictedPursuantToS332ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InterestRestrictedPursuantToS332ToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.INTERESTRESTRICT)
    End Sub

    Private Sub OtherInterestexcludingHirePurchaseInterestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtherInterestexcludingHirePurchaseInterestToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPOTHERINTEREST)
    End Sub

    Private Sub ProfessionalTechnicalManagementLegalFeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfessionalTechnicalManagementLegalFeesToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPLEGAL)
    End Sub

    Private Sub TechnicalFeePaymentsToNonresidentRecipientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TechnicalFeePaymentsToNonresidentRecipientsToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPTECHNICAL)
    End Sub

    Private Sub ContractPaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContractPaymentsToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPCONTRACTPAY)
    End Sub

    Private Sub DirectorsFeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DirectorsFeeToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPDIRECTORFEE)
    End Sub

    Private Sub SalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPSALARY)
    End Sub

    Private Sub CostOfEmployeeStockOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CostOfEmployeeStockOptionsToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPEMPLOYEESTOCK)
    End Sub

    Private Sub RoyaltyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoyaltyToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPROYALTY)
    End Sub

    Private Sub RentalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RentalToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPRENTAL)
    End Sub

    Private Sub RepairMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepairMaintenanceToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPREPAIRMAINTENANCE)
    End Sub

    Private Sub ResearchDevelopmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResearchDevelopmentToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPRND)
    End Sub

    Private Sub PromotionAdvertisementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromotionAdvertisementToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPADVERTISEMENT)
    End Sub

    Private Sub TravellingAccommodationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TravellingAccommodationToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPTRAVEL)
    End Sub

    Private Sub InputTaxNotClaimableFromJKDMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputTaxNotClaimableFromJKDMToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPJKDM)
    End Sub

    Private Sub DepreciationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepreciationToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPDEPRECIATION)
    End Sub

    Private Sub DonationApprovedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonationApprovedToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPDONATIONAPPR)
    End Sub

    Private Sub DonationNonApprovedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonationNonApprovedToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPDONATIONNONAPPR)
    End Sub

    Private Sub ZakatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZakatToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPZAKAT)
    End Sub

    Private Sub LossOnDisposalOfFixedAssetsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LossOnDisposalOfFixedAssetsToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPLOSSDISPFA)
    End Sub

    Private Sub EntertainmentNonStafToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntertainmentNonStafToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPENTERTAINNONSTAFF)
    End Sub

    Private Sub EntertainmentStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntertainmentStaffToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPENTERTAINSTAFF)
    End Sub

    Private Sub CompoundPenaltyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompoundPenaltyToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPCOMPAUNDPENALTY)
    End Sub

    Private Sub ProvisionAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProvisionAccountToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPPROVISION)
    End Sub

    Private Sub LeavePassageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeavePassageToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPLEAVEPASSAGE)
    End Sub

    Private Sub FixedAssetWrittenOffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FixedAssetWrittenOffToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPFAWRITTENOFF)
    End Sub

    Private Sub UnrealisedLossOnForeignExchangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnrealisedLossOnForeignExchangeToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPUNREALLOSSFE)
    End Sub

    Private Sub RealisedLossOnForeignExchangeTradeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RealisedLossOnForeignExchangeTradeToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPREALLOSSFETRADE)
    End Sub

    Private Sub RealisedLossOnForeignExchangeNonTradeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RealisedLossOnForeignExchangeNonTradeToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPREALLOSSFENONTRADE)
    End Sub

    Private Sub InitialSubscriptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InitialSubscriptionToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPINITIALSUBSCRIPT)
    End Sub

    Private Sub CapitalExpenditureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapitalExpenditureToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPCAPITALEXPENDITURE)
    End Sub

    Private Sub OthersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OthersToolStripMenuItem.Click
        TransferToManual(TaxComPNLEnuItem.EXPOTHERSEXPENSES)
    End Sub
#End Region

End Class
