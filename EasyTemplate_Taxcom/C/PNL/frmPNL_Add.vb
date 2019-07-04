Imports System.Data.SqlClient
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Export
Imports DevExpress.XtraGrid
Imports System.Data.OleDb
Imports DevExpress.XtraReports.UI
Public Class frmPNL_Add
    Public isEdit As Boolean = True
    Public ID As Decimal = 1269
    Dim ErrorLog As ClsError = Nothing
    Dim isReplacePNL As Boolean = False
    Dim ListofCmd As List(Of SqlCommand)

    Dim dtPNLInfo As DataTable = Nothing
    Property PNLKEY As Decimal
        Set(value As Decimal)
            ID = value
        End Set
        Get
            Return ID
        End Get
    End Property

    Property PNL_INFO As DataTable
        Set(value As DataTable)
            dtPNLInfo = value
        End Set
        Get
            Return dtPNLInfo
        End Get
    End Property

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        If dsDataSet Is Nothing Then
            dsDataSet = New dsPNL
        End If

        txtPCName.Caption = My.Computer.Name & " | " & GetServerName() & " | V" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision & " R = " & mdlProcess.R1
        'txtPCName.Caption = My.Computer.Name & " | " & GetServerName() & " | V" & mdlProcess.V1 & "." & mdlProcess.V2 & "." & mdlProcess.V3 & "." & mdlProcess.V4 & " R." & System.Reflection.Assembly.GetExecutingAssembly.GetName.Version.Revision.ToString
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmPNL_Details_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Try
            If e.KeyCode = Keys.F1 Then
                XtraTabControl1.SelectedTabPageIndex = 0
            ElseIf e.KeyCode = Keys.F2 Then
                XtraTabControl1.SelectedTabPageIndex = 1
            ElseIf e.KeyCode = Keys.F3 Then
                XtraTabControl1.SelectedTabPageIndex = 2
            ElseIf e.KeyCode = Keys.F4 Then
                XtraTabControl1.SelectedTabPageIndex = 3
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub frmPNL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            If CreateLookUpTaxPayer(DsCA, ErrorLog) = False Then
                MsgBox("Failed to load tax payer." & vbCrLf & ErrorLog.ErrorName & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                Me.Close()
            End If
            Application.DoEvents()
            If CreateLookUpYA(cboYA, ErrorLog) = False Then
                MsgBox("Failed to load ya." & vbCrLf & ErrorLog.ErrorName & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                Me.Close()
            End If
            Application.DoEvents()

            dtPNLInfo = ADO.Load_PNLINFO()

            If dtPNLInfo Is Nothing Then
                MsgBox("Failed to load PNL Info.", MsgBoxStyle.Critical)
                Me.Close()
            End If

            If My.Computer.Name = DeveloperPCName Then
                btnQuickPNL.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                btnPrintAdmin.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Else
                btnQuickPNL.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                btnPrintAdmin.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If

            LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
        Finally
            If AutoBot_Allow = True AndAlso My.Computer.Name = DeveloperPCName Then
                btnPrintAdmin.PerformClick()
            End If
        End Try

    End Sub
    Private Sub InitDockingSystem(ByVal CurrentProgress As Integer)
        Try
            Dim lbl As DevExpress.XtraEditors.LabelControl
            Dim KeyNameEnum As TaxComPNLEnuItem
            For Each rowx As DataRow In dtPNLInfo.Rows
                KeyNameEnum = [Enum].Parse(GetType(TaxComPNLEnuItem), IIf(IsDBNull(rowx("KeyName")), "", rowx("KeyName")))
                lbl = GetLabel(KeyNameEnum)
                DetailsClick(lbl, rowx, KeyNameEnum)

                CurrentProgress += 0.8
                Progress(CurrentProgress, "Initialize " & IIf(IsDBNull(rowx("LabelNameTricor")), "", rowx("LabelNameTricor")) & " data...")
                Application.DoEvents()
            Next
            DocumentManager1.View.Controller.CloseAll()

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Function GetLabel(ByVal Typex As TaxComPNLEnuItem) As DevExpress.XtraEditors.LabelControl
        Try
            Select Case Typex
                Case TaxComPNLEnuItem.SALES
                    Return lbl_p1Sales
                Case TaxComPNLEnuItem.OPENSTOCK
                    Return lbl_p1OpenStock
                Case TaxComPNLEnuItem.PURCHASE
                    Return lbl_p1Purchase
                Case TaxComPNLEnuItem.DEPRECIATION
                    Return lbl_p1Depreciation
                Case TaxComPNLEnuItem.OTHERALLOWEXP
                    Return lbl_p1AllowanceExpenses
                Case TaxComPNLEnuItem.OTHERNONALLOWEXP
                    Return lbl_p1NonAllowableExpenses
                Case TaxComPNLEnuItem.CLOSESTOCK
                    Return lbl_p1CloseStock
                Case TaxComPNLEnuItem.OTHERBUSINC
                    Return lbl_p2OtherBizIncome
                Case TaxComPNLEnuItem.REALFETRADE
                    Return lbl_p2ForeignCurrExGain
                Case TaxComPNLEnuItem.INTERESTINC
                    Return lbl_p2InterestIncome
                Case TaxComPNLEnuItem.ROYALTYINC
                    Return lbl_p2RoyaltyIncome
                Case TaxComPNLEnuItem.OTHERINC
                    Return lbl_p2OtherIncome
                Case TaxComPNLEnuItem.PDFIXASSET
                    Return lbl_p2ProDispPlantEq
                Case TaxComPNLEnuItem.PDINVEST
                    Return lbl_p2ProDisInvestment
                Case TaxComPNLEnuItem.FORINCREMIT
                    Return lbl_p2ForeIncomeRemmit

                Case TaxComPNLEnuItem.REALFE
                    Return lbl_p2ReaForeExGainNonTrade
                Case TaxComPNLEnuItem.UNREALFETRADE
                    Return lbl_p2UnreaGainForeExNon
                Case TaxComPNLEnuItem.UNREALFENONTRADE
                    Return lbl_p2UnreaGainForeEx

                Case TaxComPNLEnuItem.EXPOTHERINTEREST
                    Return lbl_p3OtherInterestExHirePur
                Case TaxComPNLEnuItem.EXPLEGAL
                    Return lbl_p3ProTechManLeganFees
                Case TaxComPNLEnuItem.EXPTECHNICAL
                    Return lbl_p3TechPayNonResis
                Case TaxComPNLEnuItem.EXPCONTRACTPAY
                    Return lbl_p3ContractPay
                Case TaxComPNLEnuItem.EXPDIRECTORFEE
                    Return lbl_p3DirectorFee
                Case TaxComPNLEnuItem.EXPSALARY
                    Return lbl_p3Salary
                Case TaxComPNLEnuItem.EXPEMPLOYEESTOCK
                    Return lbl_p3COEStock
                Case TaxComPNLEnuItem.EXPROYALTY
                    Return lbl_p3Royalty
                Case TaxComPNLEnuItem.EXPRENTAL
                    Return lbl_p3Rental
                Case TaxComPNLEnuItem.EXPREPAIRMAINTENANCE
                    Return lbl_p3RepairMain
                Case TaxComPNLEnuItem.EXPRND
                    Return lbl_p3ResearchDev
                Case TaxComPNLEnuItem.EXPADVERTISEMENT
                    Return lbl_p3PromotionAds
                Case TaxComPNLEnuItem.EXPTRAVEL
                    Return lbl_p3Travelling
                Case TaxComPNLEnuItem.EXPJKDM
                    Return lbl_p3JKDM
                Case TaxComPNLEnuItem.EXPDEPRECIATION
                    Return lbl_p3Depreciation
                Case TaxComPNLEnuItem.EXPDONATIONAPPR
                    Return lbl_p3DonationApp
                Case TaxComPNLEnuItem.EXPDONATIONAPPR
                    Return lbl_p3DonationApp
                Case TaxComPNLEnuItem.EXPDONATIONNONAPPR
                    Return lbl_p3DonationNonApp
                Case TaxComPNLEnuItem.EXPZAKAT
                    Return lbl_p3Zakat
                Case TaxComPNLEnuItem.EXPLOSSDISPFA
                    Return lbl_p4LossDispFA
                Case TaxComPNLEnuItem.EXPENTERTAINNONSTAFF
                    Return lbl_p4EntNonStaff
                Case TaxComPNLEnuItem.EXPENTERTAINSTAFF
                    Return lbl_p4EntStaff
                Case TaxComPNLEnuItem.EXPCOMPAUNDPENALTY
                    Return lbl_p4Compound
                Case TaxComPNLEnuItem.EXPPROVISION
                    Return lbl_p4ProvisionAcc
                Case TaxComPNLEnuItem.EXPLEAVEPASSAGE
                    Return lbl_p4LeavePass
                Case TaxComPNLEnuItem.EXPFAWRITTENOFF
                    Return lbl_p4FAWrittenOff
                Case TaxComPNLEnuItem.EXPUNREALLOSSFE, TaxComPNLEnuItem.FORECURREXLOSS
                    If isVersionLicenseType = VersionLicenseType.Tricor Then
                        Return lbl_p3ForeignCurrExLoss
                    Else
                        Return lbl_p4UnreaLossForeEx
                    End If
                Case TaxComPNLEnuItem.EXPREALLOSSFETRADE
                    Return lbl_p4ReaLossForeExTrade
                Case TaxComPNLEnuItem.EXPREALLOSSFENONTRADE
                    Return lbl_p4ReaLossForeExNonTrade
                Case TaxComPNLEnuItem.EXPINITIALSUBSCRIPT
                    Return lbl_p4InitSub
                Case TaxComPNLEnuItem.EXPCAPITALEXPENDITURE
                    Return lbl_p4CAExpenditure
                Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
                    Return lbl_p4Other
                Case TaxComPNLEnuItem.RENTALINC
                    Return lbl_p2RentalIncome
                Case TaxComPNLEnuItem.NONALLOWABLEEXPENSES
                    Return lblP4NonAllowableExpenses
                Case TaxComPNLEnuItem.OTHERNONTAXINC
                    Return lbl_p2Other
                Case TaxComPNLEnuItem.EXEMDIV
                    Return lbl_p2ExemptDividend
                Case TaxComPNLEnuItem.INTERESTRESTRICT
                    Return lbl_p3InterestResPurS33
                Case TaxComPNLEnuItem.DIVIDENDINC
                    Return lbl_p2DivIncome
            End Select
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            Return lbl_p1Sales
        End Try
    End Function
    Private Sub LoadData()
        Try
            ProgressPanel1.Visible = True
            Me.Text = "Profit and Loss - New"
            Application.DoEvents()

            GC.Collect()
            Application.DoEvents()

            'Dim listoflabelname As List(Of clsPNL_LabelName) = mdlPNL.GetPNLLabelName(ErrorLog)

            'If listoflabelname Is Nothing Then
            '    MsgBox("Failed to retrive profit and loss label name." & vbCrLf & ErrorLog.ErrorName & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
            '    Me.Close()
            'End If

            Dim controls() As Control
            Dim controls_text() As Control
            Dim tmpControl As DevExpress.XtraEditors.LabelControl
            Dim tmpControl_txt As DevExpress.XtraEditors.TextEdit
            Dim lblID As String = Nothing
            Dim lbltxt As String = Nothing
            Dim lblName As String = Nothing
            Dim lblType As String = Nothing
            For i As Integer = 0 To dtPNLInfo.Rows.Count - 1

                lblID = "lbl_" & IIf(IsDBNull(dtPNLInfo.Rows(i)("LabelID")), "", dtPNLInfo.Rows(i)("LabelID"))
                lbltxt = "txt_" & IIf(IsDBNull(dtPNLInfo.Rows(i)("LabelID")), "", dtPNLInfo.Rows(i)("LabelID"))
                lblType = IIf(IsDBNull(dtPNLInfo.Rows(i)("KeyName")), "", dtPNLInfo.Rows(i)("KeyName"))
                If mdlProcess.isVersionLicenseType = VersionLicenseType.Normal Then
                    lblName = IIf(IsDBNull(dtPNLInfo.Rows(i)("LabelName")), "", dtPNLInfo.Rows(i)("LabelName"))
                Else
                    lblName = IIf(IsDBNull(dtPNLInfo.Rows(i)("LabelNameTricor")), "", dtPNLInfo.Rows(i)("LabelNameTricor"))
                End If

                controls = Me.Controls.Find(lblID, True)
                If controls.Length > 0 AndAlso TypeOf controls(0) Is DevExpress.XtraEditors.LabelControl Then
                    tmpControl = CType(controls(0), DevExpress.XtraEditors.LabelControl)

                    tmpControl.Text = lblName
                    If lblName = "" Then
                        tmpControl.Visible = False

                        controls_text = Me.Controls.Find(lbltxt, True)

                        If controls_text.Length > 0 AndAlso TypeOf controls_text(0) Is DevExpress.XtraEditors.TextEdit Then
                            tmpControl_txt = CType(controls_text(0), DevExpress.XtraEditors.TextEdit)
                            tmpControl_txt.Visible = False
                        End If
                    Else
                        tmpControl.Visible = True
                    End If
                    tmpControl.Tag = lblType


                End If
            Next
            ClearMemoryDataset()

            UcPNL_Import1.MainData = dsDataSet

            If isEdit = False Then

                cboS60FA.EditValue = "No"

                cboRefNo.EditValue = mdlProcess.ArgParam2
                cboYA.EditValue = mdlProcess.ArgParam3

                cboRefNo.Edit.ReadOnly = False
                cboYA.Edit.ReadOnly = False
                cboMainSource.Edit.ReadOnly = False
                cboS60F.Edit.ReadOnly = False
                cboS60FA.Edit.ReadOnly = False

                InitDockingSystem(0)
                Application.DoEvents()
            Else
                Dim dtPNL As DataTable = ADO.Load_PNL_ByKey(ID)

                If dtPNL Is Nothing Then
                    cboRefNo.Edit.ReadOnly = False
                    cboYA.Edit.ReadOnly = False
                    cboMainSource.Edit.ReadOnly = False
                    cboS60F.Edit.ReadOnly = False
                    cboS60FA.Edit.ReadOnly = False

                    isEdit = False
                    cboRefNo.EditValue = mdlProcess.ArgParam2
                    cboYA.EditValue = mdlProcess.ArgParam3
                    Exit Sub
                Else
                    cboRefNo.Edit.ReadOnly = True
                    cboYA.Edit.ReadOnly = True
                    cboMainSource.Edit.ReadOnly = True
                    cboS60F.Edit.ReadOnly = True
                    cboS60FA.Edit.ReadOnly = True
                End If

                Dim CurrentProgress As Decimal = 5
                pnlProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                XtraTabControl1.Enabled = False
                RibbonControl1.Enabled = False
                Application.DoEvents()

                Me.Text = "Profit and Loss - Edit"

                cboRefNo.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_REF_NO")), "", dtPNL.Rows(0)("PL_REF_NO"))
                cboYA.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_YA")), "", dtPNL.Rows(0)("PL_YA"))
                Application.DoEvents()
                cboMainSource.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PL_MAINBUZ")), 1, dtPNL.Rows(0)("PL_MAINBUZ"))

                If IsDBNull(dtPNL.Rows(0)("PL_S60F")) = False AndAlso dtPNL.Rows(0)("PL_S60F") = "Y" Then
                    cboS60F.EditValue = "Yes"
                Else
                    cboS60F.EditValue = "No"
                End If
                If IsDBNull(dtPNL.Rows(0)("PL_S60FA")) = False AndAlso dtPNL.Rows(0)("PL_S60FA") = "Y" Then
                    cboS60FA.EditValue = "Yes"
                Else
                    cboS60FA.EditValue = "No"
                End If

                txtLastModified.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("ModifiedBy")), "", dtPNL.Rows(0)("ModifiedBy")) & " | " & IIf(IsDBNull(dtPNL.Rows(0)("ModifiedDateTime")), "", dtPNL.Rows(0)("ModifiedDateTime"))
                cboPNLStatus.EditValue = IIf(IsDBNull(dtPNL.Rows(0)("PNL_STATUS")), "", dtPNL.Rows(0)("PNL_STATUS"))
                txt_p4ExpectedExpenses.EditValue = 0 ' IIf(IsDBNull(dtPNL.Rows(0)("PL_TOT_EXP")), 0, dtPNL.Rows(0)("PL_TOT_EXP"))
                CurrentProgress += 5

               

                ' Dim listofclsPNLLabel As List(Of clsPNL_LabelName) = GetPNLLabelName()
                Dim KeyNameEnum As TaxComPNLEnuItem
                If dtPNLInfo IsNot Nothing Then
                    For Each rowInfo As DataRow In dtPNLInfo.Rows
                        KeyNameEnum = [Enum].Parse(GetType(TaxComPNLEnuItem), IIf(IsDBNull(rowInfo("KeyName")), "", rowInfo("KeyName")))
                        CurrentProgress += 1
                        mdlPNL2.PNL_GetData(ID, KeyNameEnum, txtRefNo.EditValue, cboYA.EditValue, dsDataSet, ErrorLog)

                        If mdlProcess.isVersionLicenseType = VersionLicenseType.Tricor Then
                            Progress(CurrentProgress, "Loading " & IIf(IsDBNull(rowInfo("LabelNameTricor")), "", rowInfo("LabelNameTricor")).ToString & " data...")
                        Else
                            Progress(CurrentProgress, "Loading " & IIf(IsDBNull(rowInfo("LabelName")), "", rowInfo("LabelName")).ToString & " data...")
                        End If

                        Application.DoEvents()

                    Next

                End If
                dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_REPORT_EXCLUDE").Rows.Clear()
                Application.DoEvents()
                Dim dtExclude As DataTable = ADO.Load_PNL_IncludeInReport(ID, ErrorLog)

                If dtExclude IsNot Nothing Then
                    For Each row As DataRow In dtExclude.Rows
                        dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_REPORT_EXCLUDE").ImportRow(row)
                    Next
                End If

                Application.DoEvents()
                InitDockingSystem(CurrentProgress)
                Application.DoEvents()

                If dtPNLInfo IsNot Nothing Then
                    Dim txtamount As DevExpress.XtraEditors.TextEdit
                    Dim isIncludeInReport As Boolean = False

                    For Each rowInfo As DataRow In dtPNLInfo.Rows
                        KeyNameEnum = [Enum].Parse(GetType(TaxComPNLEnuItem), IIf(IsDBNull(rowInfo("KeyName")), "", rowInfo("KeyName")))
                        GetTxtAmount(KeyNameEnum, txtamount)
                        Application.DoEvents()
                        mdlPNL2.PNL_ReCalcAll_Amount(KeyNameEnum, dsDataSet, txtamount, ErrorLog)
                    Next
                End If


                Dim dtPNLINFOisDeduct As DataTable = ADO.Load_PNLINFO(True, ErrorLog)

                If dtPNLINFOisDeduct IsNot Nothing Then

                    For Each rowx As DataRow In dtPNLINFOisDeduct.Rows
                        If rowx("KeyName") <> "INTERESTRESTRICT" Then
                            Select Case CInt(IIf(IsDBNull(rowx("Type")), 1, rowx("Type")))
                                Case 2
                                    CalcPercentageAmount_Expenses(dsDataSet, IIf(IsDBNull(rowx("TableName")), "", rowx("TableName")), IIf(IsDBNull(rowx("TableName_Details")), "", rowx("TableName_Details")), _
                                                 IIf(IsDBNull(rowx("ColumnTable")), "", rowx("ColumnTable")), IIf(IsDBNull(rowx("ColumnTable_Details")), "", rowx("ColumnTable_Details")), _
                                                 IIf(IsDBNull(rowx("ColumnAddBack")), "", rowx("ColumnAddBack")), IIf(IsDBNull(rowx("ColumnDeduct")), "", rowx("ColumnDeduct")), _
                                                 IIf(IsDBNull(rowx("ColumnAddBack_Details")), "", rowx("ColumnAddBack_Details")), IIf(IsDBNull(rowx("ColumnDeduct_Details")), "", rowx("ColumnDeduct_Details")), _
                                                 IIf(IsDBNull(rowx("ColumnAmount")), "", rowx("ColumnAmount")), IIf(IsDBNull(rowx("ColumnAmount_Details")), "", rowx("ColumnAmount_Details")), _
                                                 "PecentageAmount", ErrorLog)
                                Case 3
                                    CalcPercentageAmount(dsDataSet, IIf(IsDBNull(rowx("TableName")), "", rowx("TableName")), IIf(IsDBNull(rowx("TableName_Details")), "", rowx("TableName_Details")), _
                                                 IIf(IsDBNull(rowx("ColumnTable")), "", rowx("ColumnTable")), IIf(IsDBNull(rowx("ColumnTable_Details")), "", rowx("ColumnTable_Details")), _
                                                 IIf(IsDBNull(rowx("ColumnAddBack")), "", rowx("ColumnAddBack")), IIf(IsDBNull(rowx("ColumnDeduct")), "", rowx("ColumnDeduct")), _
                                                 IIf(IsDBNull(rowx("ColumnAddBack_Details")), "", rowx("ColumnAddBack_Details")), IIf(IsDBNull(rowx("ColumnDeduct_Details")), "", rowx("ColumnDeduct_Details")), _
                                                 IIf(IsDBNull(rowx("ColumnAmount")), "", rowx("ColumnAmount")), IIf(IsDBNull(rowx("ColumnAmount_Details")), "", rowx("ColumnAmount_Details")), _
                                                 "Pecentage", "PecentageAmount", ErrorLog)
                            End Select

                        End If

                    Next

                End If

                txt_p4NonAllowableExpenses.EditValue = mdlPNL.GetNonAllowanbleExpenses(dsDataSet, cboRefNo.EditValue, cboYA.EditValue, _
                                                                                       cboMainSource, ErrorLog)

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
        Finally
            RibbonControl1.Enabled = True
            XtraTabControl1.Enabled = True
            ProgressPanel1.Visible = False
            pnlProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End Try
    End Sub
    Private Sub DetailsClick(ByVal lbl As DevExpress.XtraEditors.LabelControl, ByVal RowInfo As DataRow, _
                             Optional ByVal Type As mdlEnum.TaxComPNLEnuItem = TaxComPNLEnuItem.SALES)
        Try
            Dim doc As New DevExpress.XtraBars.Docking.DockPanel
            Dim txtamount As DevExpress.XtraEditors.TextEdit

            GetTxtAmount(Type, txtamount)
            Application.DoEvents()
            If cboRefNo Is Nothing OrElse cboYA Is Nothing OrElse cboRefNo.EditValue.ToString = "" OrElse cboYA.EditValue.ToString = "" Then
                MsgBox("Please select tax payer and ya first.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Application.DoEvents()
            mdlPNL.ViewPNL(Type, Me.DockManager1, Me.DocumentManager1, lbl, txtamount, TabbedView1, cboRefNo.EditValue, _
                           cboYA.EditValue, RowInfo, ErrorLog, txt_p1Sales, cboMainSource.EditValue, cboMainSource)
            Application.DoEvents()
            '.View.AddDocument(doc)

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub GetTxtAmount(ByVal type As TaxComPNLEnuItem, ByRef txtAmount As DevExpress.XtraEditors.TextEdit)
        Try
            Select Case type
                Case TaxComPNLEnuItem.SALES
                    txtAmount = txt_p1Sales
                Case TaxComPNLEnuItem.OPENSTOCK
                    txtAmount = txt_p1OpenStock
                Case TaxComPNLEnuItem.PURCHASE
                    txtAmount = txt_p1Purchase
                Case TaxComPNLEnuItem.DEPRECIATION
                    txtAmount = txt_p1Depreciation
                Case TaxComPNLEnuItem.OTHERALLOWEXP
                    txtAmount = txt_p1AllowanceExpenses
                Case TaxComPNLEnuItem.OTHERNONALLOWEXP
                    txtAmount = txt_p1NonAllowableExpenses
                Case TaxComPNLEnuItem.CLOSESTOCK
                    txtAmount = txt_p1CloseStock
                Case TaxComPNLEnuItem.OTHERBUSINC
                    txtAmount = txt_p2OtherBizIncome
                Case TaxComPNLEnuItem.REALFETRADE
                    txtAmount = txt_p2ForeignCurrExGain
                Case TaxComPNLEnuItem.INTERESTINC
                    txtAmount = txt_p2InterestIncome
                Case TaxComPNLEnuItem.ROYALTYINC
                    txtAmount = txt_p2RoyaltyIncome
                Case TaxComPNLEnuItem.OTHERINC
                    txtAmount = txt_p2OtherIncome
                Case TaxComPNLEnuItem.PDFIXASSET
                    txtAmount = txt_p2ProDispPlantEq
                Case TaxComPNLEnuItem.PDINVEST
                    txtAmount = txt_p2ProDisInvestment
                Case TaxComPNLEnuItem.FORINCREMIT
                    txtAmount = txt_p2ForeIncomeRemmit


                Case TaxComPNLEnuItem.REALFE
                    txtAmount = txt_p2ReaForeExGainNonTrade
                Case TaxComPNLEnuItem.UNREALFETRADE
                    txtAmount = txt_p2UnreaGainForeExNon
                Case TaxComPNLEnuItem.UNREALFENONTRADE 'azham ====================
                    txtAmount = txt_p2UnreaGainForeEx

                Case TaxComPNLEnuItem.EXPOTHERINTEREST
                    txtAmount = txt_p3OtherInterestExHirePur
                Case TaxComPNLEnuItem.EXPLEGAL
                    txtAmount = txt_p3ProTechManLeganFees
                Case TaxComPNLEnuItem.EXPTECHNICAL
                    txtAmount = txt_p3TechPayNonResis
                Case TaxComPNLEnuItem.EXPCONTRACTPAY
                    txtAmount = txt_p3ContractPay
                Case TaxComPNLEnuItem.EXPDIRECTORFEE
                    txtAmount = txt_p3DirectorFee
                Case TaxComPNLEnuItem.EXPSALARY
                    txtAmount = txt_p3Salary
                Case TaxComPNLEnuItem.EXPEMPLOYEESTOCK
                    txtAmount = txt_p3COEStock
                Case TaxComPNLEnuItem.EXPROYALTY
                    txtAmount = txt_p3Royalty
                Case TaxComPNLEnuItem.EXPRENTAL
                    txtAmount = txt_p3Rental
                Case TaxComPNLEnuItem.EXPREPAIRMAINTENANCE
                    txtAmount = txt_p3RepairMain
                Case TaxComPNLEnuItem.EXPRND
                    txtAmount = txt_p3ResearchDev
                Case TaxComPNLEnuItem.EXPADVERTISEMENT
                    txtAmount = txt_p3PromotionAds
                Case TaxComPNLEnuItem.EXPTRAVEL
                    txtAmount = txt_p3Travelling
                Case TaxComPNLEnuItem.EXPJKDM
                    txtAmount = txt_p3JKDM
                Case TaxComPNLEnuItem.EXPDEPRECIATION
                    txtAmount = txt_p3Depreciation
                Case TaxComPNLEnuItem.EXPDONATIONAPPR
                    txtAmount = txt_p3DonationApp
                Case TaxComPNLEnuItem.EXPDONATIONAPPR
                    txtAmount = txt_p3DonationApp
                Case TaxComPNLEnuItem.EXPDONATIONNONAPPR
                    txtAmount = txt_p3DonationNonApp
                Case TaxComPNLEnuItem.EXPZAKAT
                    txtAmount = txt_p3Zakat
                Case TaxComPNLEnuItem.EXPLOSSDISPFA
                    txtAmount = txt_p4LossDispFA
                Case TaxComPNLEnuItem.EXPENTERTAINNONSTAFF
                    txtAmount = txt_p4EntNonStaff
                Case TaxComPNLEnuItem.EXPENTERTAINSTAFF
                    txtAmount = txt_p4EntStaff
                Case TaxComPNLEnuItem.EXPCOMPAUNDPENALTY
                    txtAmount = txt_p4Compound
                Case TaxComPNLEnuItem.EXPPROVISION
                    txtAmount = txt_p4ProvisionAcc
                Case TaxComPNLEnuItem.EXPLEAVEPASSAGE
                    txtAmount = txt_p4LeavePass
                Case TaxComPNLEnuItem.EXPFAWRITTENOFF
                    txtAmount = txt_p4FAWrittenOff
                Case TaxComPNLEnuItem.EXPUNREALLOSSFE, TaxComPNLEnuItem.FORECURREXLOSS
                    If isVersionLicenseType = VersionLicenseType.Tricor Then
                        txtAmount = txt_p3ForeignCurrExLoss
                    Else
                        txtAmount = txt_p4UnreaLossForeEx
                    End If

                Case TaxComPNLEnuItem.EXPREALLOSSFETRADE
                    txtAmount = txt_p4ReaLossForeExTrade
                Case TaxComPNLEnuItem.EXPREALLOSSFENONTRADE
                    txtAmount = txt_p4ReaLossForeExNonTrade
                Case TaxComPNLEnuItem.EXPINITIALSUBSCRIPT
                    txtAmount = txt_p4InitSub
                Case TaxComPNLEnuItem.EXPCAPITALEXPENDITURE
                    txtAmount = txt_p4CAExpenditure
                Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
                    txtAmount = txt_p4Other
                Case TaxComPNLEnuItem.RENTALINC
                    txtAmount = txt_p2RentalIncome
                Case TaxComPNLEnuItem.NONALLOWABLEEXPENSES
                    txtAmount = txt_p4NonAllowableExpenses
                Case TaxComPNLEnuItem.OTHERNONTAXINC
                    txtAmount = txt_p2Other
                Case TaxComPNLEnuItem.EXEMDIV
                    txtAmount = txt_p2ExemptDividend
                Case TaxComPNLEnuItem.INTERESTRESTRICT
                    txtAmount = txt_p3InterestResPurS33
                Case TaxComPNLEnuItem.DIVIDENDINC
                    txtAmount = txt_p2DivIncome
            End Select
            Application.DoEvents()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            txtAmount = txt_p2DivIncome
        End Try
    End Sub
    Private Sub lblSales_DoubleClick(sender As Object, e As EventArgs) Handles lbl_p1Sales.DoubleClick, lbl_p1OpenStock.DoubleClick, lbl_p1Purchase.DoubleClick, lbl_p1Depreciation.DoubleClick, lbl_p1AllowanceExpenses.DoubleClick, lbl_p1NonAllowableExpenses.DoubleClick, lbl_p1CloseStock.DoubleClick, lbl_p2OtherBizIncome.DoubleClick, lbl_p2ForeignCurrExGain.DoubleClick, lbl_p2InterestIncome.DoubleClick, lbl_p2RoyaltyIncome.DoubleClick, lbl_p2OtherIncome.DoubleClick, lbl_p2ProDispPlantEq.DoubleClick, lbl_p2ProDisInvestment.DoubleClick, lbl_p2ForeIncomeRemmit.DoubleClick, lbl_p2ReaForeExGainNonTrade.DoubleClick, lbl_p2UnreaGainForeEx.DoubleClick, lbl_p2UnreaGainForeExNon.DoubleClick, lbl_p3OtherInterestExHirePur.DoubleClick, lbl_p3ProTechManLeganFees.DoubleClick, lbl_p3TechPayNonResis.DoubleClick, lbl_p3ContractPay.DoubleClick, lbl_p3DirectorFee.DoubleClick, lbl_p3Salary.DoubleClick, lbl_p3COEStock.DoubleClick, lbl_p3Royalty.DoubleClick, lbl_p3Rental.DoubleClick, lbl_p3RepairMain.DoubleClick, lbl_p3ResearchDev.DoubleClick, lbl_p3PromotionAds.DoubleClick, lbl_p3Travelling.DoubleClick, lbl_p3JKDM.DoubleClick, lbl_p3Depreciation.DoubleClick, lbl_p3DonationApp.DoubleClick, lbl_p3DonationNonApp.DoubleClick, lbl_p3Zakat.DoubleClick, lbl_p4LossDispFA.DoubleClick, lbl_p4EntNonStaff.DoubleClick, lbl_p4EntStaff.DoubleClick, lbl_p4Compound.DoubleClick, lbl_p4ProvisionAcc.DoubleClick, lbl_p4LeavePass.DoubleClick, lbl_p4FAWrittenOff.DoubleClick, lbl_p4UnreaLossForeEx.DoubleClick, lbl_p4ReaLossForeExTrade.DoubleClick, lbl_p4ReaLossForeExNonTrade.DoubleClick, lbl_p4InitSub.DoubleClick, lbl_p4CAExpenditure.DoubleClick, lbl_p4Other.DoubleClick, lbl_p2RentalIncome.DoubleClick, lblP4NonAllowableExpenses.DoubleClick, lbl_p2Other.DoubleClick, lbl_p2ExemptDividend.DoubleClick, lbl_p3InterestResPurS33.DoubleClick, lbl_p2DivIncome.DoubleClick, lbl_p3ForeignCurrExLoss.DoubleClick
        Try

            If cboRefNo Is Nothing OrElse cboRefNo.EditValue = "" Then
                MsgBox("Please select tax payer.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If cboYA Is Nothing OrElse cboYA.EditValue = "" Then
                MsgBox("Please select year assessment.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If cboMainSource Is Nothing OrElse IsNumeric(cboMainSource.EditValue) = False Then
                MsgBox("Please select source no.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If TypeOf sender Is DevExpress.XtraEditors.LabelControl Then

                Dim lbl As DevExpress.XtraEditors.LabelControl = CType(sender, DevExpress.XtraEditors.LabelControl)

                Dim type As mdlEnum.TaxComPNLEnuItem = DirectCast([Enum].Parse(GetType(mdlEnum.TaxComPNLEnuItem), lbl.Tag.ToString), mdlEnum.TaxComPNLEnuItem)

                Dim dtTmpPNLInfo As DataTable = ADO.Load_PNLINFO(lbl.Tag.ToString)

                If dtTmpPNLInfo IsNot Nothing Then
                    DetailsClick(lbl, dtTmpPNLInfo.Rows(0), type)
                ElseIf lbl.Tag.ToString = "NONALLOWABLEEXPENSES" Then
                    DetailsClick(lbl, Nothing, type)
                End If

            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub TabbedView1_DocumentClosing(sender As Object, e As DevExpress.XtraBars.Docking2010.Views.DocumentCancelEventArgs) Handles TabbedView1.DocumentClosing
        e.Cancel = True

        mdlPNL.DestroyPNL(e.Document.Control.Name, Me.DockManager1, Me.DocumentManager1)
    End Sub
    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Me.Close()
    End Sub
    Private Sub txt_p1Depreciation_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p1Depreciation.EditValueChanged, txt_p1AllowanceExpenses.EditValueChanged, txt_p1NonAllowableExpenses.EditValueChanged
        Try
            txt_p1COP.EditValue = mdlPNL.CalcProductofCost(IIf(IsNumeric(txt_p1Depreciation.EditValue) = False, 0, txt_p1Depreciation.EditValue), IIf(IsNumeric(txt_p1AllowanceExpenses.EditValue) = False, 0, txt_p1AllowanceExpenses.EditValue), IIf(IsNumeric(txt_p1NonAllowableExpenses.EditValue) = False, 0, txt_p1NonAllowableExpenses.EditValue))
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub txt_p1COP_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p1COP.EditValueChanged, txt_p1Purchase.EditValueChanged
        Try
            txt_p1PCP.EditValue = mdlPNL.CalcPurchaseProductofCost(IIf(IsNumeric(txt_p1Purchase.EditValue) = False, 0, txt_p1Purchase.EditValue), IIf(IsNumeric(txt_p1COP.EditValue) = False, 0, txt_p1COP.EditValue))
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub txt_p1CloseStock_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p1CloseStock.EditValueChanged, txt_p1OpenStock.EditValueChanged, txt_p1PCP.EditValueChanged
        Try
            txt_p1COS.EditValue = mdlPNL.CalcCostOfSales(IIf(IsNumeric(txt_p1OpenStock.EditValue) = False, 0, txt_p1OpenStock.EditValue), IIf(IsNumeric(txt_p1CloseStock.EditValue) = False, 0, txt_p1CloseStock.EditValue), IIf(IsNumeric(txt_p1PCP.EditValue) = False, 0, txt_p1PCP.EditValue))


        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try

    End Sub
    Private Sub txt_p1Sales_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p1Sales.EditValueChanged, txt_p1COS.EditValueChanged
        Try
            txt_p1GrossProfitLoss.EditValue = mdlPNL.CalcGrossProfitLoss(IIf(IsNumeric(txt_p1Sales.EditValue) = False, 0, txt_p1Sales.EditValue), IIf(IsNumeric(txt_p1COS.EditValue) = False, 0, txt_p1COS.EditValue))

            CalcNetProfit()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Try
            Dim CurrentProgress As Integer = 0

            DsPNL.AcceptChanges()
            DsPNL2.AcceptChanges()

            pnlProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Application.DoEvents()

            If isValid() = False Then
                pnlProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Application.DoEvents()
                Exit Sub
            End If
            Progress(2, "Preparing data...")
            Dim SqlCon As SqlConnection = Nothing

            ListofCmd = Nothing
            ListofCmd = New List(Of SqlCommand)

            If dsDataSet.Tables("PROFIT_LOSS_ACCOUNT") IsNot Nothing Then
                dsDataSet.Tables("PROFIT_LOSS_ACCOUNT").Rows.Clear()
            End If
            Dim tmpID As Integer = 0
            Dim dtrow As DataRow = Nothing
            If isEdit Then
                'edit
                Progress(4, "Saving new PNL data...")

                dtrow = dsDataSet.Tables("PROFIT_LOSS_ACCOUNT").NewRow
                tmpID = ID
                dtrow("PL_KEY") = tmpID
                dtrow("PL_REF_NO") = cboRefNo.EditValue
                dtrow("PL_YA") = cboYA.EditValue
                dtrow("PL_SALES") = IIf(IsDBNull(txt_p1Sales.EditValue), 0, txt_p1Sales.EditValue)
                dtrow("PL_OP_STK") = IIf(IsDBNull(txt_p1OpenStock.EditValue), 0, txt_p1OpenStock.EditValue)
                dtrow("PL_PURCHASES") = IIf(IsDBNull(txt_p1Purchase.EditValue), 0, txt_p1Purchase.EditValue)
                dtrow("PL_PRO_COST") = IIf(IsDBNull(txt_p1COP.EditValue), 0, txt_p1COP.EditValue)
                dtrow("PL_PRO_COST_DPC") = IIf(IsDBNull(txt_p1Depreciation.EditValue), 0, txt_p1Depreciation.EditValue)
                dtrow("PL_PRO_COST_OAE") = IIf(IsDBNull(txt_p1AllowanceExpenses.EditValue), 0, txt_p1AllowanceExpenses.EditValue)
                dtrow("PL_PRO_COST_ONAE") = IIf(IsDBNull(txt_p1NonAllowableExpenses.EditValue), 0, txt_p1NonAllowableExpenses.EditValue)
                dtrow("PL_PURCHASES_PRO_COST") = IIf(IsDBNull(txt_p1PCP.EditValue), 0, txt_p1PCP.EditValue)
                dtrow("PL_CLS_STK") = IIf(IsDBNull(txt_p1CloseStock.EditValue), 0, txt_p1CloseStock.EditValue)
                dtrow("PL_COGS") = IIf(IsDBNull(txt_p1COS.EditValue), 0, txt_p1COS.EditValue)
                dtrow("PL_GROSS_PROFIT") = IIf(IsDBNull(txt_p1GrossProfitLoss.EditValue), 0, txt_p1GrossProfitLoss.EditValue)
                dtrow("PL_OTH_BSIN") = IIf(IsDBNull(txt_p2OtherBizIncome.EditValue), 0, txt_p2OtherBizIncome.EditValue)

                '   dtrow("PL_OTH_BSIN_UNREALGT") = IIf(IsDBNull(txt_p2UnreaGainForeEx.EditValue), 0, txt_p2UnreaGainForeEx.EditValue)
                dtrow("PL_OTH_BSIN_REALGT") = IIf(IsDBNull(txt_p2ForeignCurrExGain.EditValue), 0, txt_p2ForeignCurrExGain.EditValue)

                dtrow("PL_OTH_BSIN_RENTAL") = "0"
                dtrow("PL_OTH_BSIN_OTHER") = "0"
                dtrow("PL_OTH_IN") = IIf(IsDBNull(txt_p2NonBizIncome.EditValue), 0, txt_p2NonBizIncome.EditValue)
                dtrow("PL_OTH_IN_DIVIDEND") = IIf(IsDBNull(txt_p2DivIncome.EditValue), 0, txt_p2DivIncome.EditValue)
                dtrow("PL_OTH_IN_INTEREST") = IIf(IsDBNull(txt_p2InterestIncome.EditValue), 0, txt_p2InterestIncome.EditValue)
                dtrow("PL_OTH_IN_RENTAL") = IIf(IsDBNull(txt_p2RentalIncome.EditValue), 0, txt_p2RentalIncome.EditValue)
                dtrow("PL_OTH_IN_ROYALTY") = IIf(IsDBNull(txt_p2RoyaltyIncome.EditValue), 0, txt_p2RoyaltyIncome.EditValue)
                dtrow("PL_OTH_IN_OTHER") = IIf(IsDBNull(txt_p2OtherIncome.EditValue), 0, txt_p2OtherIncome.EditValue)
                dtrow("PL_NONTAX_IN") = IIf(IsDBNull(txt_p2NonTaxProfit.EditValue), 0, txt_p2NonTaxProfit.EditValue)
                dtrow("PL_NONTAX_IN_FA_DISP") = IIf(IsDBNull(txt_p2ProDispPlantEq.EditValue), 0, txt_p2ProDispPlantEq.EditValue)
                dtrow("PL_NONTAX_IN_INV_DISP") = IIf(IsDBNull(txt_p2ProDisInvestment.EditValue), 0, txt_p2ProDisInvestment.EditValue)
                dtrow("PL_NONTAX_IN_EXM_DIV") = IIf(IsDBNull(txt_p2ExemptDividend.EditValue), 0, txt_p2ExemptDividend.EditValue)

                dtrow("PL_NONTAX_IN_FIR") = IIf(IsDBNull(txt_p2ForeIncomeRemmit.EditValue), 0, txt_p2ForeIncomeRemmit.EditValue)
                ' dtrow("PL_NONTAX_IN_REALG") = IIf(IsDBNull(txt_p2UnreaGainForeExNon.EditValue), 0, txt_p2UnreaGainForeExNon.EditValue)

                dtrow("PL_NONTAX_IN_REALG") = IIf(IsDBNull(txt_p2ReaForeExGainNonTrade.EditValue), 0, txt_p2ReaForeExGainNonTrade.EditValue)
                dtrow("PL_OTH_BSIN_UNREALGT") = IIf(IsDBNull(txt_p2UnreaGainForeEx.EditValue), 0, txt_p2UnreaGainForeEx.EditValue)
                dtrow("PL_NONTAX_IN_UNREALG") = IIf(IsDBNull(txt_p2UnreaGainForeExNon.EditValue), 0, txt_p2UnreaGainForeExNon.EditValue)

                ' dtrow("PL_NONTAX_IN_UNREALG") = IIf(IsDBNull(txt_p2ReaForeExGainNonTrade.EditValue), 0, txt_p2ReaForeExGainNonTrade.EditValue)
                dtrow("PL_NONTAX_IN_INSU_COMP") = IIf(IsDBNull(txt_p2Other.EditValue), 0, txt_p2Other.EditValue)
                dtrow("PL_EXP_INT") = IIf(IsDBNull(txt_p3OtherInterestExHirePur.EditValue), 0, txt_p3OtherInterestExHirePur.EditValue)
                dtrow("PL_LAWYER_COST") = IIf(IsDBNull(txt_p3ProTechManLeganFees.EditValue), 0, txt_p3ProTechManLeganFees.EditValue)
                dtrow("PL_CONTRACT_EXP") = IIf(IsDBNull(txt_p3ContractPay.EditValue), 0, txt_p3ContractPay.EditValue)
                dtrow("PL_EXP_SALARY") = IIf(IsDBNull(txt_p3Salary.EditValue), 0, txt_p3Salary.EditValue)
                dtrow("PL_ROYALTY") = IIf(IsDBNull(txt_p3Royalty.EditValue), 0, txt_p3Royalty.EditValue)
                dtrow("PL_EXP_RENT") = IIf(IsDBNull(txt_p3Rental.EditValue), 0, txt_p3Rental.EditValue)
                dtrow("PL_EXP_MAINTENANCE") = IIf(IsDBNull(txt_p3RepairMain.EditValue), 0, txt_p3RepairMain.EditValue)
                dtrow("PL_RND") = IIf(IsDBNull(txt_p3ResearchDev.EditValue), 0, txt_p3ResearchDev.EditValue)
                dtrow("PL_ADVERT") = IIf(IsDBNull(txt_p3PromotionAds.EditValue), 0, txt_p3PromotionAds.EditValue)
                dtrow("PL_TRAVEL") = IIf(IsDBNull(txt_p3Travelling.EditValue), 0, txt_p3Travelling.EditValue)
                dtrow("PL_OTHER_EXP") = IIf(IsDBNull(txt_p4TotalOtherExpenses.EditValue), 0, txt_p4TotalOtherExpenses.EditValue)
                dtrow("PL_OTHER_EXP_DPC") = IIf(IsDBNull(txt_p3Depreciation.EditValue), 0, txt_p3Depreciation.EditValue)
                dtrow("PL_OTHER_EXP_DNT") = GetTotalDonation(ErrorLog)
                dtrow("PL_OTHER_EXP_DNT_APP") = IIf(IsDBNull(txt_p3DonationApp.EditValue), 0, txt_p3DonationApp.EditValue)
                dtrow("PL_OTHER_EXP_DNT_NAPP") = IIf(IsDBNull(txt_p3DonationNonApp.EditValue), 0, txt_p3DonationNonApp.EditValue)
                dtrow("PL_OTHER_EXP_FA_DISP") = IIf(IsDBNull(txt_p4LossDispFA.EditValue), 0, txt_p4LossDispFA.EditValue)
                dtrow("PL_OTHER_EXP_ENTM") = "0"
                dtrow("PL_OTHER_EXP_ENTM_CLNT") = IIf(IsDBNull(txt_p4EntNonStaff.EditValue), 0, txt_p4EntNonStaff.EditValue)
                dtrow("PL_OTHER_EXP_ENTM_STFF") = IIf(IsDBNull(txt_p4EntStaff.EditValue), 0, txt_p4EntStaff.EditValue)
                dtrow("PL_OTHER_EXP_PENALTY") = IIf(IsDBNull(txt_p4Compound.EditValue), 0, txt_p4Compound.EditValue)
                dtrow("PL_OTHER_EXP_PROV_ACC") = IIf(IsDBNull(txt_p4ProvisionAcc.EditValue), 0, txt_p4ProvisionAcc.EditValue)
                dtrow("PL_OTHER_EXP_LEAVE") = IIf(IsDBNull(txt_p4LeavePass.EditValue), 0, txt_p4LeavePass.EditValue)
                dtrow("PL_OTHER_EXP_FA_WO") = IIf(IsDBNull(txt_p4FAWrittenOff.EditValue), 0, txt_p4FAWrittenOff.EditValue)
                If isVersionLicenseType = VersionLicenseType.Tricor Then
                    dtrow("PL_OTHER_EXP_UNREALOSS") = IIf(IsDBNull(txt_p3ForeignCurrExLoss.EditValue), 0, txt_p3ForeignCurrExLoss.EditValue)
                Else
                    dtrow("PL_OTHER_EXP_UNREALOSS") = IIf(IsDBNull(txt_p4UnreaLossForeEx.EditValue), 0, txt_p4UnreaLossForeEx.EditValue)
                End If

                dtrow("PL_OTHER_EXP_REALOSS") = IIf(IsDBNull(txt_p4ReaLossForeExTrade.EditValue), 0, txt_p4ReaLossForeExTrade.EditValue)
                dtrow("PL_OTHER_EXP_INI_SUB") = IIf(IsDBNull(txt_p4InitSub.EditValue), 0, txt_p4InitSub.EditValue)
                dtrow("PL_OTHER_EXP_CAP_EXP") = IIf(IsDBNull(txt_p4CAExpenditure.EditValue), 0, txt_p4CAExpenditure.EditValue)
                dtrow("PL_OTHER_EXP_OTHERS") = IIf(IsDBNull(txt_p4Other.EditValue), 0, txt_p4Other.EditValue)
                dtrow("PL_TOT_EXP") = IIf(IsDBNull(txt_p4TotalExpenses.EditValue), 0, txt_p4TotalExpenses.EditValue)
                dtrow("PL_NET_PROFIT_LOSS") = IIf(IsDBNull(txt_p4NetProfitLoss.EditValue), 0, txt_p4NetProfitLoss.EditValue)
                dtrow("PL_DISALLOWED_EXP") = IIf(IsDBNull(txt_p4NonAllowableExpenses.EditValue), 0, txt_p4NonAllowableExpenses.EditValue)
                dtrow("PL_TOTALX") = "0"
                dtrow("PL_TOTALY") = "0"
                dtrow("PL_EXP_INTRESTRICT") = IIf(IsDBNull(txt_p3InterestResPurS33.EditValue), 0, txt_p3InterestResPurS33.EditValue)
                dtrow("PL_OTH_BSIN_NONSOURCE") = IIf(IsDBNull(txt_p2OtherBizIncome.EditValue), 0, txt_p2OtherBizIncome.EditValue)
                dtrow("PL_S60F") = IIf(cboS60F.EditValue = "Yes", "Y", "N")
                dtrow("PL_MAINBUZ") = CInt(IIf(IsDBNull(cboMainSource.EditValue), 1, cboMainSource.EditValue))
                dtrow("PL_OTHER_EXP_ZAKAT") = txt_p3Zakat.EditValue
                dtrow("PL_COMPANY") = "C"
                dtrow("PL_TREGROSS") = GetTotalTaxDeductuibDividendIncome(ErrorLog)
                dtrow("PL_TTAXDEDUCTION") = "0"
                dtrow("PL_TNETDEDUCTION") = "0"
                dtrow("PL_TECH_FEE") = IIf(IsDBNull(txt_p3TechPayNonResis.EditValue), 0, txt_p3TechPayNonResis.EditValue)
                dtrow("PL_EMPL_STOCK") = IIf(IsDBNull(txt_p3COEStock.EditValue), 0, txt_p3COEStock.EditValue)
                dtrow("PL_S60FA") = IIf(cboS60FA.EditValue = "Yes", "Y", "N")
                dtrow("PL_OTHER_EXP_BALANCE") = IIf(IsDBNull(txt_p4OtherBalacingFigure.EditValue), 0, txt_p4OtherBalacingFigure.EditValue)
                dtrow("PL_OTHER_EXRLOSSFOREIGNT") = IIf(IsDBNull(txt_p4ReaLossForeExNonTrade.EditValue), 0, txt_p4ReaLossForeExNonTrade.EditValue)
                dtrow("PL_DIRECTORS_FEE") = IIf(IsDBNull(txt_p3DirectorFee.EditValue), 0, txt_p3DirectorFee.EditValue)
                dtrow("PL_JKDM") = IIf(IsDBNull(txt_p3JKDM.EditValue), 0, txt_p3JKDM.EditValue)
                dtrow("ModifiedBy") = My.Computer.Name
                dtrow("ModifiedDateTime") = Now
                dtrow("PNL_Status") = IIf(cboPNLStatus.EditValue Is Nothing, "New", cboPNLStatus.EditValue)

                dsDataSet.Tables("PROFIT_LOSS_ACCOUNT").Rows.Add(dtrow)

                ADO.Update_ProfitAndLoss_Query(dsDataSet.Tables("PROFIT_LOSS_ACCOUNT"), ListofCmd, ErrorLog)

                Progress(6, "trying to connect with database...")

                If mdlProcess.DBConnection(sqlCon, ErrorLog) = False Then
                    Progress(0, "Failed to connect with database.")
                    MsgBox("Failed to connect with database.", MsgBoxStyle.Critical)
                    Exit Sub
                End If

            Else
                'new
                Progress(4, "Preparing new PNL data...")

                tmpID = ADO.GETPNLKEY(ErrorLog)
                tmpID += 1

                dtrow = dsDataSet.Tables("PROFIT_LOSS_ACCOUNT").NewRow

                dtrow("PL_KEY") = tmpID
                dtrow("PL_REF_NO") = cboRefNo.EditValue
                dtrow("PL_YA") = cboYA.EditValue
                dtrow("PL_SALES") = IIf(IsDBNull(txt_p1Sales.EditValue), 0, txt_p1Sales.EditValue)
                dtrow("PL_OP_STK") = IIf(IsDBNull(txt_p1OpenStock.EditValue), 0, txt_p1OpenStock.EditValue)
                dtrow("PL_PURCHASES") = IIf(IsDBNull(txt_p1Purchase.EditValue), 0, txt_p1Purchase.EditValue)
                dtrow("PL_PRO_COST") = IIf(IsDBNull(txt_p1PCP.EditValue), 0, txt_p1PCP.EditValue)
                dtrow("PL_PRO_COST_DPC") = IIf(IsDBNull(txt_p1Depreciation.EditValue), 0, txt_p1Depreciation.EditValue)
                dtrow("PL_PRO_COST_OAE") = IIf(IsDBNull(txt_p1AllowanceExpenses.EditValue), 0, txt_p1AllowanceExpenses.EditValue)
                dtrow("PL_PRO_COST_ONAE") = IIf(IsDBNull(txt_p1NonAllowableExpenses.EditValue), 0, txt_p1NonAllowableExpenses.EditValue)
                dtrow("PL_PURCHASES_PRO_COST") = IIf(IsDBNull(txt_p1PCP.EditValue), 0, txt_p1PCP.EditValue)
                dtrow("PL_CLS_STK") = IIf(IsDBNull(txt_p1CloseStock.EditValue), 0, txt_p1CloseStock.EditValue)
                dtrow("PL_COGS") = IIf(IsDBNull(txt_p1COS.EditValue), 0, txt_p1COS.EditValue)
                dtrow("PL_GROSS_PROFIT") = IIf(IsDBNull(txt_p1GrossProfitLoss.EditValue), 0, txt_p1GrossProfitLoss.EditValue)
                dtrow("PL_OTH_BSIN") = IIf(IsDBNull(txt_p2OtherBizIncome.EditValue), 0, txt_p2OtherBizIncome.EditValue)
                dtrow("PL_OTH_BSIN_REALGT") = IIf(IsDBNull(txt_p2ForeignCurrExGain.EditValue), 0, txt_p2ForeignCurrExGain.EditValue)

                dtrow("PL_OTH_BSIN_RENTAL") = "0"
                dtrow("PL_OTH_BSIN_OTHER") = "0"
                dtrow("PL_OTH_IN") = IIf(IsDBNull(txt_p2NonBizIncome.EditValue), 0, txt_p2NonBizIncome.EditValue)
                dtrow("PL_OTH_IN_DIVIDEND") = IIf(IsDBNull(txt_p2DivIncome.EditValue), 0, txt_p2DivIncome.EditValue)
                dtrow("PL_OTH_IN_INTEREST") = IIf(IsDBNull(txt_p2InterestIncome.EditValue), 0, txt_p2InterestIncome.EditValue)
                dtrow("PL_OTH_IN_RENTAL") = IIf(IsDBNull(txt_p2RentalIncome.EditValue), 0, txt_p2RentalIncome.EditValue)
                dtrow("PL_OTH_IN_ROYALTY") = IIf(IsDBNull(txt_p2RoyaltyIncome.EditValue), 0, txt_p2RoyaltyIncome.EditValue)
                dtrow("PL_OTH_IN_OTHER") = IIf(IsDBNull(txt_p2OtherIncome.EditValue), 0, txt_p2OtherIncome.EditValue)
                dtrow("PL_NONTAX_IN") = IIf(IsDBNull(txt_p2NonTaxProfit.EditValue), 0, txt_p2NonTaxProfit.EditValue)
                dtrow("PL_NONTAX_IN_FA_DISP") = IIf(IsDBNull(txt_p2ProDispPlantEq.EditValue), 0, txt_p2ProDispPlantEq.EditValue)
                dtrow("PL_NONTAX_IN_INV_DISP") = IIf(IsDBNull(txt_p2ProDisInvestment.EditValue), 0, txt_p2ProDisInvestment.EditValue)
                dtrow("PL_NONTAX_IN_EXM_DIV") = IIf(IsDBNull(txt_p2ExemptDividend.EditValue), 0, txt_p2ExemptDividend.EditValue)
                dtrow("PL_NONTAX_IN_FIR") = IIf(IsDBNull(txt_p2ForeIncomeRemmit.EditValue), 0, txt_p2ForeIncomeRemmit.EditValue)

                dtrow("PL_NONTAX_IN_REALG") = IIf(IsDBNull(txt_p2ReaForeExGainNonTrade.EditValue), 0, txt_p2ReaForeExGainNonTrade.EditValue)
                dtrow("PL_OTH_BSIN_UNREALGT") = IIf(IsDBNull(txt_p2UnreaGainForeEx.EditValue), 0, txt_p2UnreaGainForeEx.EditValue)
                dtrow("PL_NONTAX_IN_UNREALG") = IIf(IsDBNull(txt_p2UnreaGainForeExNon.EditValue), 0, txt_p2UnreaGainForeExNon.EditValue)

                dtrow("PL_NONTAX_IN_INSU_COMP") = IIf(IsDBNull(txt_p2Other.EditValue), 0, txt_p2Other.EditValue)
                dtrow("PL_EXP_INT") = IIf(IsDBNull(txt_p3OtherInterestExHirePur.EditValue), 0, txt_p3OtherInterestExHirePur.EditValue)
                dtrow("PL_LAWYER_COST") = IIf(IsDBNull(txt_p3ProTechManLeganFees.EditValue), 0, txt_p3ProTechManLeganFees.EditValue)
                dtrow("PL_CONTRACT_EXP") = IIf(IsDBNull(txt_p3ContractPay.EditValue), 0, txt_p3ContractPay.EditValue)
                dtrow("PL_EXP_SALARY") = IIf(IsDBNull(txt_p3Salary.EditValue), 0, txt_p3Salary.EditValue)
                dtrow("PL_ROYALTY") = IIf(IsDBNull(txt_p3Royalty.EditValue), 0, txt_p3Royalty.EditValue)
                dtrow("PL_EXP_RENT") = IIf(IsDBNull(txt_p3Rental.EditValue), 0, txt_p3Rental.EditValue)
                dtrow("PL_EXP_MAINTENANCE") = IIf(IsDBNull(txt_p3RepairMain.EditValue), 0, txt_p3RepairMain.EditValue)
                dtrow("PL_RND") = IIf(IsDBNull(txt_p3ResearchDev.EditValue), 0, txt_p3ResearchDev.EditValue)
                dtrow("PL_ADVERT") = IIf(IsDBNull(txt_p3PromotionAds.EditValue), 0, txt_p3PromotionAds.EditValue)
                dtrow("PL_TRAVEL") = IIf(IsDBNull(txt_p3Travelling.EditValue), 0, txt_p3Travelling.EditValue)
                dtrow("PL_OTHER_EXP") = IIf(IsDBNull(txt_p4TotalOtherExpenses.EditValue), 0, txt_p4TotalOtherExpenses.EditValue)
                dtrow("PL_OTHER_EXP_DPC") = IIf(IsDBNull(txt_p3Depreciation.EditValue), 0, txt_p3Depreciation.EditValue)
                dtrow("PL_OTHER_EXP_DNT") = GetTotalDonation(ErrorLog)
                dtrow("PL_OTHER_EXP_DNT_APP") = IIf(IsDBNull(txt_p3DonationApp.EditValue), 0, txt_p3DonationApp.EditValue)
                dtrow("PL_OTHER_EXP_DNT_NAPP") = IIf(IsDBNull(txt_p3DonationNonApp.EditValue), 0, txt_p3DonationNonApp.EditValue)
                dtrow("PL_OTHER_EXP_FA_DISP") = IIf(IsDBNull(txt_p4LossDispFA.EditValue), 0, txt_p4LossDispFA.EditValue)
                dtrow("PL_OTHER_EXP_ENTM") = "0"
                dtrow("PL_OTHER_EXP_ENTM_CLNT") = IIf(IsDBNull(txt_p4EntNonStaff.EditValue), 0, txt_p4EntNonStaff.EditValue)
                dtrow("PL_OTHER_EXP_ENTM_STFF") = IIf(IsDBNull(txt_p4EntStaff.EditValue), 0, txt_p4EntStaff.EditValue)
                dtrow("PL_OTHER_EXP_PENALTY") = IIf(IsDBNull(txt_p4Compound.EditValue), 0, txt_p4Compound.EditValue)
                dtrow("PL_OTHER_EXP_PROV_ACC") = IIf(IsDBNull(txt_p4ProvisionAcc.EditValue), 0, txt_p4ProvisionAcc.EditValue)
                dtrow("PL_OTHER_EXP_LEAVE") = IIf(IsDBNull(txt_p4LeavePass.EditValue), 0, txt_p4LeavePass.EditValue)
                dtrow("PL_OTHER_EXP_FA_WO") = IIf(IsDBNull(txt_p4FAWrittenOff.EditValue), 0, txt_p4FAWrittenOff.EditValue)
                If isVersionLicenseType = VersionLicenseType.Tricor Then
                    dtrow("PL_OTHER_EXP_UNREALOSS") = IIf(IsDBNull(txt_p3ForeignCurrExLoss.EditValue), 0, txt_p3ForeignCurrExLoss.EditValue)
                Else
                    dtrow("PL_OTHER_EXP_UNREALOSS") = IIf(IsDBNull(txt_p4UnreaLossForeEx.EditValue), 0, txt_p4UnreaLossForeEx.EditValue)
                End If

                dtrow("PL_OTHER_EXP_REALOSS") = IIf(IsDBNull(txt_p4ReaLossForeExTrade.EditValue), 0, txt_p4ReaLossForeExTrade.EditValue)
                dtrow("PL_OTHER_EXP_INI_SUB") = IIf(IsDBNull(txt_p4InitSub.EditValue), 0, txt_p4InitSub.EditValue)
                dtrow("PL_OTHER_EXP_CAP_EXP") = IIf(IsDBNull(txt_p4CAExpenditure.EditValue), 0, txt_p4CAExpenditure.EditValue)
                dtrow("PL_OTHER_EXP_OTHERS") = IIf(IsDBNull(txt_p4Other.EditValue), 0, txt_p4Other.EditValue)
                dtrow("PL_TOT_EXP") = IIf(IsDBNull(txt_p4TotalExpenses.EditValue), 0, txt_p4TotalExpenses.EditValue)
                dtrow("PL_NET_PROFIT_LOSS") = IIf(IsDBNull(txt_p4NetProfitLoss.EditValue), 0, txt_p4NetProfitLoss.EditValue)
                dtrow("PL_DISALLOWED_EXP") = IIf(IsDBNull(txt_p4NonAllowableExpenses.EditValue), 0, txt_p4NonAllowableExpenses.EditValue)
                dtrow("PL_TOTALX") = "0"
                dtrow("PL_TOTALY") = "0"
                dtrow("PL_EXP_INTRESTRICT") = IIf(IsDBNull(txt_p3InterestResPurS33.EditValue), 0, txt_p3InterestResPurS33.EditValue)
                dtrow("PL_OTH_BSIN_NONSOURCE") = IIf(IsDBNull(txt_p2OtherBizIncome.EditValue), 0, txt_p2OtherBizIncome.EditValue)
                dtrow("PL_S60F") = IIf(cboS60F.EditValue = "Yes", "Y", "N")
                dtrow("PL_MAINBUZ") = CInt(IIf(IsDBNull(cboMainSource.EditValue), 1, cboMainSource.EditValue))
                dtrow("PL_OTHER_EXP_ZAKAT") = txt_p3Zakat.EditValue
                dtrow("PL_COMPANY") = "C"
                dtrow("PL_TREGROSS") = GetTotalTaxDeductuibDividendIncome(ErrorLog)
                dtrow("PL_TTAXDEDUCTION") = "0"
                dtrow("PL_TNETDEDUCTION") = "0"
                dtrow("PL_TECH_FEE") = IIf(IsDBNull(txt_p3TechPayNonResis.EditValue), 0, txt_p3TechPayNonResis.EditValue)
                dtrow("PL_EMPL_STOCK") = IIf(IsDBNull(txt_p3COEStock.EditValue), 0, txt_p3COEStock.EditValue)
                dtrow("PL_S60FA") = IIf(cboS60FA.EditValue = "Yes", "Y", "N")
                dtrow("PL_OTHER_EXP_BALANCE") = IIf(IsDBNull(txt_p4OtherBalacingFigure.EditValue), 0, txt_p4OtherBalacingFigure.EditValue)
                dtrow("PL_OTHER_EXRLOSSFOREIGNT") = IIf(IsDBNull(txt_p4ReaLossForeExNonTrade.EditValue), 0, txt_p4ReaLossForeExNonTrade.EditValue)
                dtrow("PL_DIRECTORS_FEE") = IIf(IsDBNull(txt_p3DirectorFee.EditValue), 0, txt_p3DirectorFee.EditValue)
                dtrow("PL_JKDM") = IIf(IsDBNull(txt_p3JKDM.EditValue), 0, txt_p3JKDM.EditValue)
                dtrow("ModifiedBy") = My.Computer.Name
                dtrow("ModifiedDateTime") = Now
                dtrow("PNL_Status") = IIf(cboPNLStatus.EditValue Is Nothing, "New", cboPNLStatus.EditValue)

                dsDataSet.Tables("PROFIT_LOSS_ACCOUNT").Rows.Add(dtrow)

                ADO.Save_ProfitAndLoss_Query(dsDataSet.Tables("PROFIT_LOSS_ACCOUNT"), ListofCmd, ErrorLog)

                Progress(6, "trying to connect with database...")

                If mdlProcess.DBConnection(sqlCon, ErrorLog) = False Then
                    Progress(0, "Failed to connect with database.")
                    MsgBox("Failed to connect with database.", MsgBoxStyle.Critical)
                    Exit Sub
                End If

            End If

            ADO.Delete_PNLItem(ListofCmd, tmpID, ErrorLog)

            ' Dim listofclsPNLLabel As List(Of clsPNL_LabelName) = GetPNLLabelName()

            CurrentProgress = 6
            Dim isIncludeInReport As Boolean = True
            If dtPNLInfo IsNot Nothing Then
                dtrow = Nothing

                dtrow = dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_REPORT_EXCLUDE").NewRow

                dtrow("PL_KEY") = tmpID

                Dim KeyNameEnum As TaxComPNLEnuItem
                For Each rowInfo As DataRow In dtPNLInfo.Rows
                    CurrentProgress += 1
                    KeyNameEnum = [Enum].Parse(GetType(TaxComPNLEnuItem), IIf(IsDBNull(rowInfo("KeyName")), "", rowInfo("KeyName")))

                    If mdlProcess.isVersionLicenseType = VersionLicenseType.Tricor Then
                        Progress(CurrentProgress, "Getting " & IIf(IsDBNull(rowInfo("LabelNameTricor")), "", rowInfo("LabelNameTricor")).ToString & " data...")
                    Else
                        Progress(CurrentProgress, "Getting " & IIf(IsDBNull(rowInfo("LabelName")), "", rowInfo("LabelName")).ToString & " data...")
                    End If


                    mdlPNL2.PNL_GetSaveData(tmpID, KeyNameEnum, Nothing, ListofCmd, txtRefNo.EditValue, cboYA.EditValue, isIncludeInReport, ErrorLog)
                    Application.DoEvents()

                    If IsDBNull(rowInfo("ColumnName")) = False AndAlso IsDBNull(rowInfo("Type")) = False Then
                        If CInt(rowInfo("Type")) = 2 Or CInt(rowInfo("Type")) = 3 Then

                            Select Case KeyNameEnum
                                Case TaxComPNLEnuItem.PURCHASE, TaxComPNLEnuItem.DEPRECIATION, TaxComPNLEnuItem.OTHERALLOWEXP, TaxComPNLEnuItem.OTHERNONALLOWEXP
                                Case Else
                                    dtrow(rowInfo("ColumnName")) = isIncludeInReport
                            End Select

                        End If

                    End If

                    '  Me.InsertIncludeInReport(isIncludeInReport, KeyNameEnum, dtrow)

                Next

                dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_REPORT_EXCLUDE").Rows.Add(dtrow)
                Application.DoEvents()
                ADO.Save_PNL_ExcludeInReport(dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_REPORT_EXCLUDE"), ListofCmd, ErrorLog)
            End If

            CurrentProgress += 1
            Progress(CurrentProgress, "Ready to saving " & ListofCmd.Count & " data(s)...")

            If ListofCmd IsNot Nothing AndAlso ListofCmd.Count > 0 Then
                If ADO.Save_ListExecute(ListofCmd, ErrorLog) Then
                    Progress(100, "Done to saved " & ListofCmd.Count & " data(s)...")
                    isEdit = True
                    Application.DoEvents()
                    isSuccessfullySaved(tmpID)
                    If cboS60F.EditValue = "Yes" Then
                        If mdlRefreshTaxComputation.RefreshInvestmentHolding(cboRefNo.EditValue, cboYA.EditValue, ErrorLog) = False Then
                            MsgBox("Error to recalculate tax computation investment holding.", MsgBoxStyle.Critical)
                        End If
                    Else
                        If mdlRefreshTaxComputation.RefreshTaxcom(cboRefNo.EditValue, cboYA.EditValue, ErrorLog) = False Then
                            MsgBox("Error to recalculate tax computation.", MsgBoxStyle.Critical)
                        End If
                    End If
                Else
                    Progress(100, "Failed to saving " & ListofCmd.Count & " data(s)...")
                    MsgBox("Failed to save data." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)

                End If
            End If


        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog IsNot Nothing Then
                MsgBox(ErrorLog.ErrorMessage)

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
            End If
        End Try
    End Sub
    Private Sub InsertIncludeInReport(ByVal isIncludeInReport As Boolean, ByVal Type As TaxComPNLEnuItem, ByVal dtrow As DataRow)
        Try
            Select Case Type
                Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
                    dtrow("PL_OTHER_EXP_OTHERS") = isIncludeInReport


            End Select
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub isSuccessfullySaved(ByVal KeyID As Integer)
        Try
            Dim dt As DataTable = ADO.Load_PNLLastModified(KeyID)

            If dt IsNot Nothing Then
                txtLastModified.EditValue = IIf(IsDBNull(dt.Rows(0)("ModifiedDateTime")), "", dt.Rows(0)("ModifiedDateTime"))
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub Progress(ByVal val As Integer, ByVal Caption As String)
        Try
            pnlProgress.EditValue = val
            pnlProgress.Caption = Caption
            Application.DoEvents()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Public Function GetTotalTaxDeductuibDividendIncome(Optional ByRef Errorlog As ClsError = Nothing) As Decimal
        Try
            Dim obj As Object = dsDataSet.Tables("DIVIDEND_INCOME").Compute("sum('di_taxdeduction')", "")

            If obj IsNot Nothing AndAlso IsNumeric(obj) Then
                Return CDec(obj)
            End If

            Return 0
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
            Return 0
        End Try
    End Function
    Private Function isValid() As Boolean
        Try
            If cboRefNo Is Nothing OrElse cboRefNo.EditValue.ToString = "" Then
                MsgBox("Please select company reference number.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If cboYA Is Nothing OrElse cboYA.EditValue.ToString = "" Then
                MsgBox("Please select year assesment.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If cboMainSource Is Nothing OrElse cboMainSource.EditValue.ToString = "" Then
                MsgBox("Please select main source number.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If isEdit = False Then
                If ADO.Check_PNLExist(cboRefNo.EditValue, CInt(cboYA.EditValue), ErrorLog) Then
                    ' MsgBox("Profit and loss already exist.", MsgBoxStyle.Exclamation)
                    Dim rlst As DialogResult = MessageBox.Show("Profit and loss already exist, do you want to replace with this pnl?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

                    If rlst = Windows.Forms.DialogResult.Yes Then
                        isEdit = True
                    End If

                    Return False
                End If
            End If


            If dsDataSet Is Nothing Then
                MsgBox("Unable to get dataset.", MsgBoxStyle.Critical)
                Return False
            End If


            Return True

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            Return False
        End Try
    End Function
    Public Function GetTotalDonation(Optional ByRef Errorlog As ClsError = Nothing) As Decimal
        Try
            Dim Total As Decimal = 0

            Total = IIf(IsNumeric(txt_p3DonationApp.EditValue), txt_p3DonationApp.EditValue, 0) + IIf(IsNumeric(txt_p3DonationNonApp.EditValue), txt_p3DonationNonApp.EditValue, 0)
            Return 0
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
            Return 0
        End Try
    End Function
    Private Sub txt_p2DivIncome_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p2DivIncome.EditValueChanged, txt_p2InterestIncome.EditValueChanged, txt_p2RentalIncome.EditValueChanged, txt_p2RoyaltyIncome.EditValueChanged, txt_p2OtherIncome.EditValueChanged
        Try
            Dim Dividen As Decimal = IIf(IsNumeric(txt_p2DivIncome.EditValue) = False, 0, txt_p2DivIncome.EditValue)
            Dim Interest As Decimal = IIf(IsNumeric(txt_p2InterestIncome.EditValue) = False, 0, txt_p2InterestIncome.EditValue)
            Dim Rental As Decimal = IIf(IsNumeric(txt_p2RentalIncome.EditValue) = False, 0, txt_p2RentalIncome.EditValue)
            Dim Royalty As Decimal = IIf(IsNumeric(txt_p2RoyaltyIncome.EditValue) = False, 0, txt_p2RoyaltyIncome.EditValue)
            Dim Other As Decimal = IIf(IsNumeric(txt_p2OtherIncome.EditValue) = False, 0, txt_p2OtherIncome.EditValue)

            txt_p2NonBizIncome.EditValue = mdlPNL.CalcNonBizIncome(Dividen, Interest, Rental, Royalty, Other, ErrorLog)

            CalcNetProfit()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub txt_p2ProDispPlantEq_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p2ProDispPlantEq.EditValueChanged, txt_p2Other.EditValueChanged, txt_p2ExemptDividend.EditValueChanged, txt_p2ForeIncomeRemmit.EditValueChanged, txt_p2ReaForeExGainNonTrade.EditValueChanged, txt_p2UnreaGainForeEx.EditValueChanged, txt_p2UnreaGainForeExNon.EditValueChanged, txt_p2ProDisInvestment.EditValueChanged

        Try
            Dim p2ProDispPlantEq As Decimal = IIf(IsNumeric(txt_p2ProDispPlantEq.EditValue) = False, 0, txt_p2ProDispPlantEq.EditValue)
            Dim p2Other As Decimal = IIf(IsNumeric(txt_p2Other.EditValue) = False, 0, txt_p2Other.EditValue)
            Dim p2ExemptDividend As Decimal = IIf(IsNumeric(txt_p2ExemptDividend.EditValue) = False, 0, txt_p2ExemptDividend.EditValue)
            Dim p2ForeIncomeRemmit As Decimal = IIf(IsNumeric(txt_p2ForeIncomeRemmit.EditValue) = False, 0, txt_p2ForeIncomeRemmit.EditValue)
            Dim p2ReaForeExGainNonTrade As Decimal = IIf(IsNumeric(txt_p2ReaForeExGainNonTrade.EditValue) = False, 0, txt_p2ReaForeExGainNonTrade.EditValue)

            Dim p2UnreaGainForeEx As Decimal = IIf(IsNumeric(txt_p2UnreaGainForeEx.EditValue) = False, 0, txt_p2UnreaGainForeEx.EditValue)
            Dim p2UnreaGainForeExNon As Decimal = IIf(IsNumeric(txt_p2UnreaGainForeExNon.EditValue) = False, 0, txt_p2UnreaGainForeExNon.EditValue)
            Dim p2ProDisInvestment As Decimal = IIf(IsNumeric(txt_p2ProDisInvestment.EditValue) = False, 0, txt_p2ProDisInvestment.EditValue)

            txt_p2NonTaxProfit.EditValue = mdlPNL.CalcNonTaxProfit(p2ProDispPlantEq, p2Other, p2ExemptDividend, p2ForeIncomeRemmit, p2ReaForeExGainNonTrade, p2UnreaGainForeEx, p2UnreaGainForeExNon, p2ProDisInvestment, ErrorLog)

            CalcNetProfit()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub txt_p3Depreciation_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p3Depreciation.EditValueChanged, txt_p3DonationApp.EditValueChanged, txt_p3DonationNonApp.EditValueChanged, txt_p3Zakat.EditValueChanged, txt_p4EntNonStaff.EditValueChanged, txt_p4EntStaff.EditValueChanged, txt_p4Compound.EditValueChanged, txt_p4ProvisionAcc.EditValueChanged, txt_p4LeavePass.EditValueChanged, txt_p4FAWrittenOff.EditValueChanged, txt_p4UnreaLossForeEx.EditValueChanged, txt_p4ReaLossForeExTrade.EditValueChanged, txt_p4ReaLossForeExNonTrade.EditValueChanged, txt_p4InitSub.EditValueChanged, txt_p4CAExpenditure.EditValueChanged, txt_p4Other.EditValueChanged, txt_p4LossDispFA.EditValueChanged

        Try
            Dim p3Depreciation As Decimal = IIf(IsNumeric(txt_p3Depreciation.EditValue) = False, 0, txt_p3Depreciation.EditValue)
            Dim p3DonationApp As Decimal = IIf(IsNumeric(txt_p3DonationApp.EditValue) = False, 0, txt_p3DonationApp.EditValue)
            Dim p3DonationNonApp As Decimal = IIf(IsNumeric(txt_p3DonationNonApp.EditValue) = False, 0, txt_p3DonationNonApp.EditValue)
            Dim p3Zakat As Decimal = IIf(IsNumeric(txt_p3Zakat.EditValue) = False, 0, txt_p3Zakat.EditValue)

            Dim p4EntNonStaff As Decimal = IIf(IsNumeric(txt_p4EntNonStaff.EditValue) = False, 0, txt_p4EntNonStaff.EditValue)
            Dim p4EntStaff As Decimal = IIf(IsNumeric(txt_p4EntStaff.EditValue) = False, 0, txt_p4EntStaff.EditValue)
            Dim p4Compound As Decimal = IIf(IsNumeric(txt_p4Compound.EditValue) = False, 0, txt_p4Compound.EditValue)
            Dim p4ProvisionAcc As Decimal = IIf(IsNumeric(txt_p4ProvisionAcc.EditValue) = False, 0, txt_p4ProvisionAcc.EditValue)
            Dim p4LeavePass As Decimal = IIf(IsNumeric(txt_p4LeavePass.EditValue) = False, 0, txt_p4LeavePass.EditValue)
            Dim p4FAWrittenOff As Decimal = IIf(IsNumeric(txt_p4FAWrittenOff.EditValue) = False, 0, txt_p4FAWrittenOff.EditValue)
            Dim p4UnreaLossForeEx As Decimal = IIf(IsNumeric(txt_p4UnreaLossForeEx.EditValue) = False, 0, txt_p4UnreaLossForeEx.EditValue)
            Dim p4ReaLossForeExTrade As Decimal = IIf(IsNumeric(txt_p4ReaLossForeExTrade.EditValue) = False, 0, txt_p4ReaLossForeExTrade.EditValue)
            Dim p4ReaLossForeExNonTrade As Decimal = IIf(IsNumeric(txt_p4ReaLossForeExNonTrade.EditValue) = False, 0, txt_p4ReaLossForeExNonTrade.EditValue)
            Dim p4InitSub As Decimal = IIf(IsNumeric(txt_p4InitSub.EditValue) = False, 0, txt_p4InitSub.EditValue)
            Dim p4CAExpenditure As Decimal = IIf(IsNumeric(txt_p4CAExpenditure.EditValue) = False, 0, txt_p4CAExpenditure.EditValue)
            Dim p4Other As Decimal = IIf(IsNumeric(txt_p4Other.EditValue) = False, 0, txt_p4Other.EditValue)
            Dim p4LossDispFA As Decimal = IIf(IsNumeric(txt_p4LossDispFA.EditValue) = False, 0, txt_p4LossDispFA.EditValue)

            txt_p4TotalOtherExpenses.EditValue = mdlPNL.CalcOtherExpenses(p3Depreciation, p3DonationApp, p3DonationNonApp, p3Zakat, p4EntNonStaff, p4EntStaff, p4Compound, p4ProvisionAcc, p4LeavePass, p4FAWrittenOff, p4UnreaLossForeEx, p4ReaLossForeExTrade, p4ReaLossForeExNonTrade, p4InitSub, p4CAExpenditure, p4Other, p4LossDispFA, ErrorLog)

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try

    End Sub
    Private Sub txt_p3ForeignCurrExLoss_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p3ForeignCurrExLoss.EditValueChanged, txt_p3OtherInterestExHirePur.EditValueChanged, txt_p3ProTechManLeganFees.EditValueChanged, txt_p3TechPayNonResis.EditValueChanged, txt_p3ContractPay.EditValueChanged, txt_p3DirectorFee.EditValueChanged, txt_p3Salary.EditValueChanged, txt_p3COEStock.EditValueChanged, txt_p3Royalty.EditValueChanged, txt_p3Rental.EditValueChanged, txt_p3RepairMain.EditValueChanged, txt_p3ResearchDev.EditValueChanged, txt_p3PromotionAds.EditValueChanged, txt_p3Travelling.EditValueChanged, txt_p3JKDM.EditValueChanged, txt_p3InterestResPurS33.EditValueChanged, txt_p4TotalOtherExpenses.EditValueChanged
        Try
            CalcTotalExpenses()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub CalcTotalExpenses()
        Try
            Dim p3ForeignCurrExLoss As Decimal = IIf(IsNumeric(txt_p3ForeignCurrExLoss.EditValue) = False, 0, txt_p3ForeignCurrExLoss.EditValue)
            Dim p3OtherInterestExHirePur As Decimal = IIf(IsNumeric(txt_p3OtherInterestExHirePur.EditValue) = False, 0, txt_p3OtherInterestExHirePur.EditValue)
            Dim p3ProTechManLeganFees As Decimal = IIf(IsNumeric(txt_p3ProTechManLeganFees.EditValue) = False, 0, txt_p3ProTechManLeganFees.EditValue)
            Dim p3TechPayNonResis As Decimal = IIf(IsNumeric(txt_p3TechPayNonResis.EditValue) = False, 0, txt_p3TechPayNonResis.EditValue)
            Dim p3ContractPay As Decimal = IIf(IsNumeric(txt_p3ContractPay.EditValue) = False, 0, txt_p3ContractPay.EditValue)
            Dim p3DirectorFee As Decimal = IIf(IsNumeric(txt_p3DirectorFee.EditValue) = False, 0, txt_p3DirectorFee.EditValue)
            Dim p3Salary As Decimal = IIf(IsNumeric(txt_p3Salary.EditValue) = False, 0, txt_p3Salary.EditValue)
            Dim p3COEStock As Decimal = IIf(IsNumeric(txt_p3COEStock.EditValue) = False, 0, txt_p3COEStock.EditValue)
            Dim p3Royalty As Decimal = IIf(IsNumeric(txt_p3Royalty.EditValue) = False, 0, txt_p3Royalty.EditValue)
            Dim p3Rental As Decimal = IIf(IsNumeric(txt_p3Rental.EditValue) = False, 0, txt_p3Rental.EditValue)
            Dim p3RepairMain As Decimal = IIf(IsNumeric(txt_p3RepairMain.EditValue) = False, 0, txt_p3RepairMain.EditValue)
            Dim p3ResearchDev As Decimal = IIf(IsNumeric(txt_p3ResearchDev.EditValue) = False, 0, txt_p3ResearchDev.EditValue)
            Dim p3PromotionAds As Decimal = IIf(IsNumeric(txt_p3PromotionAds.EditValue) = False, 0, txt_p3PromotionAds.EditValue)
            Dim p3Travelling As Decimal = IIf(IsNumeric(txt_p3Travelling.EditValue) = False, 0, txt_p3Travelling.EditValue)
            Dim p3JKDM As Decimal = IIf(IsNumeric(txt_p3JKDM.EditValue) = False, 0, txt_p3JKDM.EditValue)
            Dim p3InterestResPurS33 As Decimal = IIf(IsNumeric(txt_p3InterestResPurS33.EditValue) = False, 0, txt_p3InterestResPurS33.EditValue)
            Dim p4TotalOtherExpenses As Decimal = IIf(IsNumeric(txt_p4TotalOtherExpenses.EditValue) = False, 0, txt_p4TotalOtherExpenses.EditValue)
            Dim BalacingFigure As Decimal = 0

            If IsNumeric(txt_p4TotalExpenses.EditValue) = False Then
                txt_p4TotalExpenses.EditValue = 0
            End If
            If IsNumeric(txt_p4OtherBalacingFigure.EditValue) = False Then
                txt_p4OtherBalacingFigure.EditValue = 0
            End If

            Dim NonAllowableExpenses As Decimal = 0
            Dim TotalExpenses As Decimal = mdlPNL.CalcExpenses(p3ForeignCurrExLoss, p3OtherInterestExHirePur, p3ProTechManLeganFees, p3TechPayNonResis, _
                                                               p3ContractPay, p3DirectorFee, p3Salary, p3COEStock, _
                                                               p3Royalty, p3Rental, p3RepairMain, p3ResearchDev, p3PromotionAds, _
                                                               p3Travelling, p3JKDM, p3InterestResPurS33, p4TotalOtherExpenses, _
                                                               BalacingFigure, NonAllowableExpenses, cboRefNo.EditValue, cboYA.EditValue, cboMainSource, ErrorLog)

            txt_p4NonAllowableExpenses.EditValue = NonAllowableExpenses
            txt_p4TotalExpenses.EditValue = CDec(TotalExpenses)
            Application.DoEvents()
            Dim p4ExpectedExpenses As Decimal = IIf(IsNumeric(txt_p4ExpectedExpenses.EditValue) = False, 0, txt_p4ExpectedExpenses.EditValue)

            GetOtherBalancingFigureRefresh(TotalExpenses, p4ExpectedExpenses)

            CalcNetProfit()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub txt_p4TotalExpenses_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_p4TotalExpenses.KeyUp
        CalcTotalExpenses()
    End Sub
    Public Sub GetOtherBalancingFigureRefresh(ByVal TotalExpenses As Decimal, ByVal ExpectedExpenses As Decimal, _
                                                    Optional ByRef Errorlog As ClsError = Nothing)
        Try
            If ExpectedExpenses <> 0 Then
                Dim dblOtherBalancingFigure As Decimal = ExpectedExpenses - TotalExpenses


                txt_p4OtherBalacingFigure.EditValue = dblOtherBalancingFigure
            End If

            'If TotalExpenses < txtTotalExpensesDic Then
            '    dblOtherBalancingFigure = txtTotalExpensesDic - TotalExpenses
            '    If dblOtherBalancingFigure >= ExpTotalBalance Then
            '        Return 0
            '    ElseIf dblOtherBalancingFigure > 0 Then
            '        '  Me.dicPNL("ExpTotalBalance") = FormatNumber(CDbl(Me.dicPNL("ExpTotalBalance")) - CDbl(dblOtherBalancingFigure), 0)
            '        Return ExpTotalBalance - dblOtherBalancingFigure
            '    End If
            'End If

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

            txt_p4OtherBalacingFigure.EditValue = 0
        End Try
    End Sub
    Public Sub CalcNetProfit(Optional ByRef Errorlog As ClsError = Nothing)
        Try
            'Dim dblNetProfitLoss As Double 'weihong add RealFETrade
            'dblNetProfitLoss = GetGrossProfitLoss() + dicPNL("OtherBusinessIncome") + GetTotalOtherNonBusinessIncome() + GetTotalNonTaxableIncome() - GetTotalExpensesDic() + dicPNL("RealFETrade")
            'Return dblNetProfitLoss

            ' Dim NetProfitLoss As Decimal = CDec(txt_p1GrossProfitLoss.EditValue) + CDec(txt_p2OtherBizIncome.EditValue) 
            '+ CDec(txt_p2NonBizIncome.EditValue) + CDec(txt_p2ForeignCurrExGain.EditValue) - CDec(txt_p4TotalExpenses.EditValue)

            Dim NetProfitLoss As Decimal = CDec(txt_p1GrossProfitLoss.EditValue) + CDec(txt_p2NonBizIncome.EditValue) + CDec(txt_p2NonTaxProfit.EditValue) + CDec(txt_p2OtherBizIncome.EditValue) - CDec(txt_p4TotalExpenses.EditValue) + CDec(txt_p2ForeignCurrExGain.EditValue)

            txt_p4NetProfitLoss.EditValue = NetProfitLoss
            txtNetProfit2.EditValue = NetProfitLoss
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

        End Try
    End Sub
    Private Sub txt_p2OtherBizIncome_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p2OtherBizIncome.EditValueChanged, txt_p2ForeignCurrExGain.EditValueChanged
        Try
            CalcNetProfit()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub txt_p4ExpectedExpenses_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p4ExpectedExpenses.EditValueChanged
        Try

            Dim TotalExpenses As Decimal = IIf(IsNumeric(txt_p4TotalExpenses.EditValue) = False, 0, txt_p4TotalExpenses.EditValue)
            Dim p4ExpectedExpenses As Decimal = IIf(IsNumeric(txt_p4ExpectedExpenses.EditValue) = False, 0, txt_p4ExpectedExpenses.EditValue)
            GetOtherBalancingFigureRefresh(TotalExpenses, p4ExpectedExpenses)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub txt_p4NonAllowableExpenses_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p4NonAllowableExpenses.EditValueChanged
        Try
            If txt_p4NonAllowableExpenses IsNot Nothing Then
                txtNonAllowableExpense.EditValue = txt_p4NonAllowableExpenses.EditValue
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged, cboYA.EditValueChanged
        Try
            If cboRefNo IsNot Nothing AndAlso cboRefNo.EditValue.ToString <> "" AndAlso cboYA IsNot Nothing AndAlso cboYA.EditValue.ToString <> "" Then
                txtRefNo.EditValue = cboRefNo.EditValue
                mdlProcess.CreateLookUpSourceNO(dsDataSet, cboRefNo.EditValue, cboYA.EditValue, "BUSINESS_SOURCE", ErrorLog)
                mdlProcess.CreateLookUpSourceNO(dsDataSet, cboRefNo.EditValue, cboYA.EditValue, "BUSINESS_SOURCE", ErrorLog)
                Application.DoEvents()
                BUSINESSSOURCEBindingSource.DataSource = dsDataSet.Tables("BUSINESS_SOURCE")

                For i As Integer = 0 To dsDataSet.Tables("BUSINESS_SOURCE").Rows.Count - 1
                    If i = 0 Then
                        cboMainSource.EditValue = dsDataSet.Tables("BUSINESS_SOURCE").Rows(i)("BC_SOURCENO")
                    End If
                Next
                'If isEdit = False Then
                '    'Dim editor As DevExpress.XtraEditors.ComboBoxEdit
                '    'editor = CType(cboMainSource, DevExpress.XtraEditors.ComboBoxEdit)
                '    '' editor = TryCast(cboMainSource, DevExpress.XtraEditors.ComboBoxEdit)
                '    'editor.SelectedIndex = 0
                '    For i As Integer = 0 To dsDataSet.Tables("BUSINESS_SOURCE").Rows.Count - 1
                '        If i = 0 Then
                '            cboMainSource.EditValue = dsDataSet.Tables("BUSINESS_SOURCE").Rows(i)("BC_SOURCENO")
                '        End If
                '    Next

                'End If
                If ADO.VerifyInvestmentHolding(cboRefNo.EditValue, cboYA.EditValue, ErrorLog) Then
                    cboS60F.Edit.ReadOnly = True
                    cboS60F.EditValue = "Yes"
                Else
                    cboS60F.Edit.ReadOnly = False
                    cboS60F.EditValue = "No"
                End If

                pnlDocInformation.Enabled = True
            Else
                pnlDocInformation.Enabled = False
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub txt_p4OtherBalacingFigure_EditValueChanged(sender As Object, e As EventArgs) Handles txt_p4OtherBalacingFigure.EditValueChanged
        txtBalacingFigure.EditValue = txt_p4OtherBalacingFigure.EditValue
    End Sub

    Private Sub btnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefresh.ItemClick
        Try
            Me.LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImport.ItemClick
        Try
            pnlDocImport.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible

            'OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;"

            'Dim rslt As DialogResult = OpenFileDialog1.ShowDialog

            'If rslt = Windows.Forms.DialogResult.OK Then

            '    Dim Path As String = OpenFileDialog1.FileName

            '    If System.IO.File.Exists(Path) = False Then
            '        MsgBox("File not exist, please select correct file.", MsgBoxStyle.Exclamation)
            '        Exit Sub
            '    End If
            '    Dim connectionString As String = String.Format("Provider=Microsoft.ACE.OLEDB.12.0; data source={0}; Extended Properties=Excel 12.0;", OpenFileDialog1.FileName)
            '    Dim adapter = New OleDbDataAdapter("select * from [Sheet$]", connectionString)
            '    Dim ds = New DataSet()
            '    Dim dsControl As DataSet
            '    Dim tableName As String = "Sheet"
            '    adapter.Fill(ds, tableName)

            '    Dim Status As Boolean = False
            '    Dim PnlType As mdlEnum.TaxComPNLEnuItem = TaxComPNLEnuItem.CLOSESTOCK
            '    Dim contrl As Control = Nothing
            '    Dim ParentID As Integer = 0
            '    Dim dtRow As DataRow = Nothing
            '    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
            '        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            '            If IsDBNull(ds.Tables(0).Rows(i)("Type")) = False AndAlso ds.Tables(0).Rows(i)("Type") IsNot Nothing Then
            '                PnlType = DirectCast([Enum].Parse(GetType(mdlEnum.TaxComPNLEnuItem), ds.Tables(0).Rows(i)("Type")), mdlEnum.TaxComPNLEnuItem)

            '                Select Case PnlType
            '                    Case TaxComPNLEnuItem.EXPOTHERSEXPENSES
            '                        If p4_docOther IsNot Nothing AndAlso p4_docOther.Controls.Count > 0 Then
            '                            contrl = p4_docOther.Controls(0)

            '                            If contrl Is Nothing OrElse TypeOf contrl Is ucPNL_p4Other = False Then
            '                                Exit Sub
            '                            End If
            '                            Dim uc As ucPNL_p4Other = CType(contrl, ucPNL_p4Other)

            '                            dsControl = uc.DataView_Main

            '                            If dsControl IsNot Nothing Then
            '                                If IsDBNull(ds.Tables(0).Rows(i)("Description")) = False OrElse ds.Tables(0).Rows(i)("Description") IsNot Nothing Then

            '                                    dtRow = dsControl.Tables(uc.MainTable_Details).NewRow
            '                                    ParentID = dsControl.Tables(uc.MainTable).Rows.Count + 1

            '                                    dtRow("EXO_KEY") = 0
            '                                    dtRow("EXO_EXOKEY") = ParentID
            '                                    dtRow("EXO_DESC") = ds.Tables(0).Rows(i)("Description")
            '                                    If IsNumeric(ds.Tables(0).Rows(i)("Description")) = True AndAlso CDec(ds.Tables(0).Rows(i)("Description")) > 0 Then
            '                                        dtRow("EXO_AMOUNT") = ds.Tables(0).Rows(i)("Debit Amount")
            '                                    Else
            '                                        dtRow("EXO_AMOUNT") = ds.Tables(0).Rows(i)("Credit Amount")
            '                                    End If
            '                                    dtRow("EXO_DEDUCTIBLE") = False
            '                                    dtRow("EXO_NOTE") = ""
            '                                    dtRow("EXO_SOURCENO") = cboMainSource.EditValue
            '                                    dtRow("EXO_DETAIL") = "No"
            '                                    dtRow("EXO_DEDUCTIBLE_ADD") = False
            '                                    dtRow("RowIndex") = 0
            '                                    dtRow("Pecentage") = 0

            '                                    dsControl.Tables(uc.MainTable_Details).Rows.Add(dtRow)

            '                                Else
            '                                    dtRow = dsControl.Tables(uc.MainTable).NewRow
            '                                    ParentID = dsControl.Tables(uc.MainTable).Rows.Count + 1

            '                                    dtRow("EXO_KEY") = 0
            '                                    dtRow("EXO_EXOKEY") = ParentID
            '                                    dtRow("EXO_DESC") = ds.Tables(0).Rows(i)("Description")
            '                                    If IsNumeric(ds.Tables(0).Rows(i)("Description")) = True AndAlso CDec(ds.Tables(0).Rows(i)("Description")) > 0 Then
            '                                        dtRow("EXO_AMOUNT") = ds.Tables(0).Rows(i)("Debit Amount")
            '                                    Else
            '                                        dtRow("EXO_AMOUNT") = ds.Tables(0).Rows(i)("Credit Amount")
            '                                    End If
            '                                    dtRow("EXO_DEDUCTIBLE") = False
            '                                    dtRow("EXO_NOTE") = ""
            '                                    dtRow("EXO_SOURCENO") = cboMainSource.EditValue
            '                                    dtRow("EXO_DETAIL") = "No"
            '                                    dtRow("EXO_DEDUCTIBLE_ADD") = False
            '                                    dtRow("RowIndex") = 0
            '                                    dtRow("Pecentage") = 0

            '                                    dsControl.Tables(uc.MainTable).Rows.Add(dtRow)
            '                                End If

            '                            End If

            '                            End If

            '                End Select

            '            End If

            '            ' mdlC_Process.Save_State(ds.Tables(0).Rows(i)("CT_CODE"), ds.Tables(0).Rows(i)("ST_DESC"), ErrorLog)
            '        Next
            '    End If
            'End If


        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
        Try
            Dim rslt As DialogResult = FolderBrowserDialog1.ShowDialog
            Dim obj() As Object = Nothing
            Dim rowchild As DataRow = Nothing
            Dim ParentNo As Integer = 0
            If rslt = Windows.Forms.DialogResult.OK Then
                Dim Path As String = FolderBrowserDialog1.SelectedPath

                If System.IO.Directory.Exists(Path) = False Then
                    MsgBox("Directory not exist.", MsgBoxStyle.Critical)
                    Exit Sub
                End If

                DsPNL2.Tables("ExportPNL").Rows.Clear()

                If System.IO.File.Exists(Path & "\ExportPNL_" & cboRefNo.EditValue.ToString & "_" & cboYA.EditValue.ToString & ".xlsx") Then
                    Path = Path & "\ExportPNL_" & cboRefNo.EditValue.ToString & "_" & cboYA.EditValue.ToString & "_& " & Format(Now, "ddMMMyyyyHHmmss") & ".xlsx"
                Else
                    Path = Path & "\ExportPNL_" & cboRefNo.EditValue.ToString & "_" & cboYA.EditValue.ToString & ".xlsx"
                End If

                Dim contrl As Control = Nothing
                Dim ds As DataSet = Nothing
                Dim dtRow As DataRow = Nothing
                Dim dockPnl As DevExpress.XtraBars.Docking.DockPanel
                Dim tableName As String = Nothing
                Dim tableName_details As String = Nothing
                Dim decription As String = Nothing
                Dim decription_details As String = Nothing
                Dim amount As String = Nothing
                Dim amount_details As String = Nothing
                Dim KeyName As String = ""
                For Each rowInfo As DataRow In dtPNLInfo.Rows
                    KeyName = IIf(IsDBNull(rowInfo("KeyName")), "", rowInfo("KeyName"))
                    If KeyName = "INTERESTRESTRICT" Then
                        Dim x As String = ""
                    End If
                    Application.DoEvents()
                    tableName = IIf(IsDBNull(rowInfo("TableName")), "", rowInfo("TableName"))
                    tableName_details = IIf(IsDBNull(rowInfo("TableName_Details")), "", rowInfo("TableName_Details"))
                    decription = IIf(IsDBNull(rowInfo("ColumnDescription")), "", rowInfo("ColumnDescription"))
                    decription_details = IIf(IsDBNull(rowInfo("ColumnDescription_Details")), "", rowInfo("ColumnDescription_Details"))
                    amount = IIf(IsDBNull(rowInfo("ColumnAmount")), "", rowInfo("ColumnAmount"))
                    amount_details = IIf(IsDBNull(rowInfo("ColumnAmount_Details")), "", rowInfo("ColumnAmount_Details"))

                    For Each rowx As DataRow In dsDataSet.Tables(tableName).Rows
                        dtRow = DsPNL2.Tables("ExportPNL").NewRow
                        ParentNo = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                        dtRow("No") = ParentNo
                        dtRow("Type") = IIf(IsDBNull(rowInfo("KeyName")), "", rowInfo("KeyName"))
                        dtRow("Description") = IIf(IsDBNull(rowx(decription)), "", rowx(decription))
                        dtRow("LeftAmount") = 0
                        dtRow("RightAmount") = IIf(IsDBNull(rowx(amount)), 0, rowx(amount))
                        DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)

                        If IsDBNull(rowInfo("TableName_Details")) = False AndAlso KeyName <> "INTERESTRESTRICT" Then
                            If dsDataSet Is Nothing OrElse dsDataSet.Tables(tableName_details) Is Nothing OrElse dsDataSet.Tables(tableName_details).Rows.Count > 0 Then
                                obj = dsDataSet.Tables(tableName_details).Select(IIf(IsDBNull(rowInfo("ColumnTable_Details")), "", rowInfo("ColumnTable_Details")) & " = " & rowx(IIf(IsDBNull(rowInfo("ColumnTable")), "", rowInfo("ColumnTable"))))

                                If obj IsNot Nothing AndAlso obj.Length > 0 Then

                                    For i As Integer = 0 To obj.Length - 1
                                        rowchild = CType(obj(i), DataRow)
                                        If rowchild IsNot Nothing Then
                                            dtRow = DsPNL2.Tables("ExportPNL").NewRow
                                            dtRow("No") = DsPNL2.Tables("ExportPNL").Rows.Count + 1
                                            dtRow("No2") = ParentNo
                                            dtRow("Type") = IIf(IsDBNull(rowInfo("KeyName")), "", rowInfo("KeyName"))
                                            dtRow("Description") = IIf(IsDBNull(rowchild(decription_details)), "", rowchild(decription_details))
                                            dtRow("LeftAmount") = 0
                                            dtRow("RightAmount") = IIf(IsDBNull(rowchild(amount_details)), 0, rowchild(amount_details))
                                            DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                                        End If

                                    Next

                                End If

                            End If
                        End If

                    Next

                Next
                ' Dim listofclsPNLLabel As List(Of clsPNL_LabelName) = GetPNLLabelName()

                Application.DoEvents()
                If DsPNL2.Tables("ExportPNL").Rows.Count > 0 Then
                    dgvExport.BeginInit()
                    ExportPNLBindingSource.DataSource = DsPNL2.Tables("ExportPNL")
                    dgvExport.EndInit()

                    Application.DoEvents()
                    System.Threading.Thread.Sleep(1000)

                    dgvExport.ExportToXlsx(Path)
                    MsgBox("Successfully export profit and loss at :" & vbCrLf & Path)
                End If
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
        Finally

        End Try
    End Sub
    Private Sub exporter_CellValueConversionError(ByVal sender As Object, ByVal e As CellValueConversionErrorEventArgs)
        MessageBox.Show("Error in cell " & e.Cell.GetReferenceA1())
        e.DataTableValue = Nothing
        e.Action = DataTableExporterAction.Continue
    End Sub

    Private Sub TabbedView1_EndDocumentsHostDocking(sender As Object, e As DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs) Handles TabbedView1.EndDocumentsHostDocking

    End Sub


    Private Sub TabbedView1_RegisterDocumentsHostWindow(sender As Object, e As DevExpress.XtraBars.Docking2010.DocumentsHostWindowEventArgs) Handles TabbedView1.RegisterDocumentsHostWindow

    End Sub

    Private Sub cboMainSource_EditValueChanged(sender As Object, e As EventArgs) Handles cboMainSource.EditValueChanged
        Try
            UcPNL_Import1.SourceNo = cboMainSource.EditValue

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    'Private Sub TabbedView1_UnregisterDocumentsHostWindow(sender As Object, e As DevExpress.XtraBars.Docking2010.DocumentsHostWindowEventArgs) Handles TabbedView1.UnregisterDocumentsHostWindow
    '    MsgBox("M")
    'End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Me.LoadData()

    End Sub

    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Try
            pnlDocInformation.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub BarButtonItem4_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Try
            pnlDocImport.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnErrorLog_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnErrorLog.ItemClick
        Try
            frmErrorLog.Show()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub UcPNL_Import1_Load(sender As Object, e As EventArgs) Handles UcPNL_Import1.Load
        Try
            UcPNL_Import1.txt_p1Sales = Me.txt_p1Sales
            UcPNL_Import1.cboRefNo = cboRefNo
            UcPNL_Import1.cboYA = cboYA
            UcPNL_Import1.txt_p1OpenStock = txt_p1OpenStock
            UcPNL_Import1.txt_p1Purchase = txt_p1Purchase
            UcPNL_Import1.txt_p1Depreciation = txt_p1Depreciation
            UcPNL_Import1.txt_p1AllowanceExpenses = txt_p1AllowanceExpenses
            UcPNL_Import1.txt_p1NonAllowableExpenses = txt_p1NonAllowableExpenses
            UcPNL_Import1.txt_p1CloseStock = txt_p1CloseStock
            UcPNL_Import1.txt_p2OtherBizIncome = txt_p2OtherBizIncome
            UcPNL_Import1.txt_p2ForeignCurrExGain = txt_p2ForeignCurrExGain
            UcPNL_Import1.txt_p2DivIncome = txt_p2DivIncome
            UcPNL_Import1.txt_p2InterestIncome = txt_p2InterestIncome
            UcPNL_Import1.txt_p2RentalIncome = txt_p2RentalIncome
            UcPNL_Import1.txt_p2RoyaltyIncome = txt_p2RoyaltyIncome
            UcPNL_Import1.txt_p2OtherIncome = txt_p2OtherIncome
            UcPNL_Import1.txt_p2ProDispPlantEq = txt_p2ProDispPlantEq
            UcPNL_Import1.txt_p2ProDisInvestment = txt_p2ProDisInvestment
            UcPNL_Import1.txt_p2ExemptDividend = txt_p2ExemptDividend
            UcPNL_Import1.txt_p2ForeIncomeRemmit = txt_p2ForeIncomeRemmit
            UcPNL_Import1.txt_p2UnreaGainForeEx = txt_p2UnreaGainForeEx
            UcPNL_Import1.txt_p2ReaForeExGainNonTrade = txt_p2ReaForeExGainNonTrade
            UcPNL_Import1.txt_p2UnreaGainForeExNon = txt_p2UnreaGainForeExNon
            UcPNL_Import1.txt_p2Other = txt_p2Other
            UcPNL_Import1.txt_p3InterestResPurS33 = txt_p3InterestResPurS33
            UcPNL_Import1.txt_p3OtherInterestExHirePur = txt_p3OtherInterestExHirePur
            UcPNL_Import1.txt_p3ProTechManLeganFees = txt_p3ProTechManLeganFees
            UcPNL_Import1.txt_p3TechPayNonResis = txt_p3TechPayNonResis
            UcPNL_Import1.txt_p3ContractPay = txt_p3ContractPay
            UcPNL_Import1.txt_p3DirectorFee = txt_p3DirectorFee
            UcPNL_Import1.txt_p3Salary = txt_p3Salary
            UcPNL_Import1.txt_p3COEStock = txt_p3COEStock
            UcPNL_Import1.txt_p3Royalty = txt_p3Royalty
            UcPNL_Import1.txt_p3Rental = txt_p3Rental
            UcPNL_Import1.txt_p3RepairMain = txt_p3RepairMain
            UcPNL_Import1.txt_p3ResearchDev = txt_p3ResearchDev
            UcPNL_Import1.txt_p3PromotionAds = txt_p3PromotionAds
            UcPNL_Import1.txt_p3Travelling = txt_p3Travelling
            UcPNL_Import1.txt_p3ForeignCurrExLoss = txt_p3ForeignCurrExLoss
            UcPNL_Import1.txt_p3JKDM = txt_p3JKDM
            UcPNL_Import1.txt_p3Depreciation = txt_p3Depreciation
            UcPNL_Import1.txt_p3DonationApp = txt_p3DonationApp
            UcPNL_Import1.txt_p3DonationNonApp = txt_p3DonationNonApp
            UcPNL_Import1.txt_p3Zakat = txt_p3Zakat
            UcPNL_Import1.txt_p4LossDispFA = txt_p4LossDispFA
            UcPNL_Import1.txt_p4EntNonStaff = txt_p4EntNonStaff
            UcPNL_Import1.txt_p4EntStaff = txt_p4EntStaff
            UcPNL_Import1.txt_p4Compound = txt_p4Compound
            UcPNL_Import1.txt_p4ProvisionAcc = txt_p4ProvisionAcc
            UcPNL_Import1.txt_p4LeavePass = txt_p4LeavePass
            UcPNL_Import1.txt_p4FAWrittenOff = txt_p4FAWrittenOff
            UcPNL_Import1.txt_p4UnreaLossForeEx = txt_p4UnreaLossForeEx
            UcPNL_Import1.txt_p4ReaLossForeExTrade = txt_p4ReaLossForeExTrade
            UcPNL_Import1.txt_p4ReaLossForeExNonTrade = txt_p4ReaLossForeExNonTrade
            UcPNL_Import1.txt_p4InitSub = txt_p4InitSub
            UcPNL_Import1.txt_p4CAExpenditure = txt_p4CAExpenditure
            UcPNL_Import1.txt_p4Other = txt_p4Other

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            dsDataSet.Tables("DataSearch").Rows.Clear()

            If txtSearch.EditValue Is Nothing OrElse txtSearch.EditValue = "" Then
                Exit Sub
            End If

            '    Dim Listoflabel As List(Of clsPNL_LabelName) = mdlPNL.GetPNLLabelName(ErrorLog)

            If dtPNLInfo IsNot Nothing Then
                Dim dtRow As DataRow = Nothing
                ' Dim KeyNameEnum As TaxComPNLEnuItem                
                For Each rowInfo As DataRow In dtPNLInfo.Rows
                    'KeyNameEnum = [Enum].Parse(GetType(TaxComPNLEnuItem), )
                    If IsDBNull(rowInfo("TableName")) = False Then
                        For Each rowx As DataRow In dsDataSet.Tables(rowInfo("TableName")).Rows
                            For Each colx As DataColumn In dsDataSet.Tables(IIf(IsDBNull(rowInfo("TableName")), "", rowInfo("TableName"))).Columns

                                If colx.ColumnName = IIf(IsDBNull(rowInfo("ColumnDescription")), "", rowInfo("ColumnDescription")) Or colx.ColumnName = IIf(IsDBNull(rowInfo("ColumnAmount")), "", rowInfo("ColumnAmount")) Then

                                    If rowx(colx.ColumnName).ToString.ToUpper.Contains(txtSearch.EditValue.ToString.ToUpper) Then
                                        dtRow = dsDataSet.Tables("DataSearch").NewRow
                                        dtRow("KeyName") = IIf(IsDBNull(rowInfo("KeyName")), "", rowInfo("KeyName"))
                                        dtRow("ColumnName") = colx.ColumnName
                                        dtRow("ParentID") = rowx(IIf(IsDBNull(rowInfo("ColumnTable")), "", rowInfo("ColumnTable")))
                                        dtRow("Value") = rowx(colx.ColumnName).ToString
                                        dsDataSet.Tables("DataSearch").Rows.Add(dtRow)
                                    End If

                                End If

                            Next
                        Next
                    End If

                    If IsDBNull(rowInfo("TableName_Details")) = False AndAlso rowInfo("TableName_Details") <> "EXPENSES_INTERESTRESTRICT_DETAIL" Then
                        For Each rowx As DataRow In dsDataSet.Tables(rowInfo("TableName_Details")).Rows
                            For Each colx As DataColumn In dsDataSet.Tables(IIf(IsDBNull(rowInfo("TableName_Details")), "", rowInfo("TableName_Details"))).Columns

                                If colx.ColumnName = IIf(IsDBNull(rowInfo("ColumnDescription_Details")), "", rowInfo("ColumnDescription_Details")) Or colx.ColumnName = IIf(IsDBNull(rowInfo("ColumnAmount_Details")), "", rowInfo("ColumnAmount_Details")) Then

                                    If rowx(colx.ColumnName).ToString.ToUpper.Contains(txtSearch.EditValue.ToString.ToUpper) Then
                                        dtRow = dsDataSet.Tables("DataSearch").NewRow
                                        dtRow("KeyName") = IIf(IsDBNull(rowInfo("KeyName")), "", rowInfo("KeyName"))
                                        dtRow("ColumnName") = colx.ColumnName
                                        dtRow("ParentID") = rowx(IIf(IsDBNull(rowInfo("ColumnTable_Details")), "", rowInfo("ColumnTable_Details")))
                                        dtRow("Value") = rowx(colx.ColumnName).ToString
                                        dsDataSet.Tables("DataSearch").Rows.Add(dtRow)
                                    End If

                                End If

                            Next
                        Next
                    End If


                Next
                DataSearchBindingSource.DataSource = dsDataSet.Tables("DataSearch")
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

    Private Sub GridView2_DoubleClick(sender As Object, e As EventArgs) Handles GridView2.DoubleClick
        Try
            Dim row As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)

            If row IsNot Nothing Then

                Dim KeyName As String = IIf(IsDBNull(row("KeyName")), "", row("KeyName"))

                If KeyName = "" Then
                    Exit Sub
                End If
                Dim val As mdlEnum.TaxComPNLEnuItem = DirectCast([Enum].Parse(GetType(mdlEnum.TaxComPNLEnuItem), KeyName), mdlEnum.TaxComPNLEnuItem)
                Dim lbl As DevExpress.XtraEditors.LabelControl

                lbl = GetLabel(val)

                Dim dtTmpPNLInfo As DataTable = ADO.Load_PNLINFO(KeyName)

                If dtTmpPNLInfo IsNot Nothing Then
                    DetailsClick(lbl, dtTmpPNLInfo.Rows(0), val)
                End If

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

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        Try
            If e.KeyCode = Keys.Enter Then
                btnSearch.PerformClick()
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnQuickPNL_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuickPNL.ItemClick
        Try
            frmPNL_Quick.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnPrintAdmin_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintAdmin.ItemClick
        Try
            Dim dsPNL_Report As New dsPNL_Report

            Dim dtInfo As DataTable = ADO.Load_PNLINFO()

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

                Dim dtPNL As DataTable = ADO.Load_PNL(cboRefNo.EditValue, cboYA.EditValue, ErrorLog)
                Dim PL_KEY As Integer = 0
                If dtPNL IsNot Nothing Then
                    For Each rowx As DataRow In dtPNL.Rows
                        PL_KEY = rowx("PL_KEY")
                        dsPNL_Report.Tables("PROFIT_LOSS_ACCOUNT_REPORT").ImportRow(rowx)
                    Next
                End If

                dtRowSch = dsPNL_Report.Tables("PROFIT_LOSS_ACCOUNT_REPORT_SCH").NewRow
                dtRowSch("PL_KEY") = PL_KEY
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
                                       ColumnPercentage, Type, PrefixName, LabelName, IntSch, ColumnName, PL_KEY, dtRow)
                        If dtRow("Sch").ToString = " " Then
                            dtRowSch(ColumnName) = ""
                        Else
                            dtRowSch(ColumnName) = "Sch " & dtRow("Sch").ToString.Replace("Schedule ", "")
                        End If

                    End If



                Next

                dsPNL_Report.Tables("PROFIT_LOSS_ACCOUNT_REPORT_SCH").Rows.Add(dtRowSch)
                

                Dim CompanyName As String = Nothing

                CompanyName = ADO.LoadTaxPayer_CompanyName(cboRefNo.EditValue)
                Dim rptPNL_Report As New rptPNL_DetailsNew
                rptPNL_Report.paramCompanyName.Value = CompanyName
                rptPNL_Report.paramYA.Value = CInt(cboYA.EditValue)
                ' rptPNL_Report.paramKeyName.Value = "EXPOTHERSEXPENSES"
                rptPNL_Report.DataSource = dsPNL_Report
                rptPNL_Report.SubrptPNL_Details1_Income.ReportSource.DataSource = dsPNL_Report
                rptPNL_Report.SubrptPNL_Details1_Expenses.ReportSource.DataSource = dsPNL_Report
                rptPNL_Report.SubrptPNL_NoteNew.ReportSource.DataSource = dsPNL_Report
                rptPNL_Report.SubrptPNL_Details_DividendIncome.ReportSource.DataSource = dsPNL_Report
                rptPNL_Report.SubrptPNL_Details1_RentalIncome.ReportSource.DataSource = dsPNL_Report
                rptPNL_Report.SubrptPNL_Details1_ExemptDividend.ReportSource.DataSource = dsPNL_Report
                rptPNL_Report.SubrptPNL_Details1_RentalExpenses.ReportSource.DataSource = dsPNL_Report
                '  rptPNL_Report.rpt_Note1.ReportSource.DataSource = dsPNL_Report
                'Dim rpt_Note1 As XRSubreport = rptPNL_Report.XrSubreport1.ReportSource.FindControl("rpt_Note", True)
                'rpt_Note1.Report.DataSource = dsPNL_Report
                'Dim rpt_Note2 As XRSubreport = rptPNL_Report.XrSubreport2.ReportSource.FindControl("rpt_Note", True)
                'rpt_Note2.Report.DataSource = dsPNL_Report

                'rptPNL_Report.ShowPreview()
                Dim rpt As New rptPNLNew
                Dim Title As String = ADO.Load_TableOfContent_Title(cboRefNo.EditValue, cboYA.EditValue, "rptProfitAndLoss")
                rpt.paramCompanyName.Value = CompanyName
                rpt.paramYA.Value = CInt(cboYA.EditValue)
                rpt.ParamSch.Value = ""
                rpt.paramTitle.Value = Title
                If isVersionLicenseType = VersionLicenseType.Tricor Then
                    rpt.isTricor.Value = True
                Else
                    rpt.isTricor.Value = False
                End If
                rpt.XrSubreport1.ReportSource = rptPNL_Report
                rpt.DataSource = dsPNL_Report
                rpt.CreateDocument()


                If GetInterestRestrictedData(dsPNL_Report, PL_KEY, cboRefNo.EditValue, cboYA.EditValue) = True Then
                    If dsPNL_Report.Tables("INTEREST_RESTRIC_MONTLY_REPORT_Tricor").Rows.Count > 0 Then
                        Dim TotalColumn As Integer = 0
                        TotalColumn = IIf(IsDBNull(dsPNL_Report.Tables("INTEREST_RESTRIC_MONTLY_REPORT_Tricor").Rows(0)("TotalColumn")), 12, dsPNL_Report.Tables("INTEREST_RESTRIC_MONTLY_REPORT_Tricor").Rows(0)("TotalColumn"))

                        Select Case TotalColumn
                            Case 12
                                Dim rpt_Interest_sub As New rptPNL_InterestResict12
                                rpt_Interest_sub.paramCompanyName.Value = ADO.LoadTaxPayer_CompanyName(cboRefNo.EditValue)
                                rpt_Interest_sub.paramYA.Value = CInt(cboYA.EditValue)
                                rpt_Interest_sub.DataSource = dsPNL_Report
                                rpt_Interest_sub.CreateDocument()
                                rpt_Interest = rpt_Interest_sub
                            Case 13
                                Dim rpt_Interest_sub As New rptPNL_InterestResict13
                                rpt_Interest_sub.paramCompanyName.Value = ADO.LoadTaxPayer_CompanyName(cboRefNo.EditValue)
                                rpt_Interest_sub.paramYA.Value = CInt(cboYA.EditValue)
                                rpt_Interest_sub.DataSource = dsPNL_Report
                                rpt_Interest_sub.CreateDocument()
                                rpt_Interest = rpt_Interest_sub
                            Case 14
                                Dim rpt_Interest_sub As New rptPNL_InterestResict14
                                rpt_Interest_sub.paramCompanyName.Value = ADO.LoadTaxPayer_CompanyName(cboRefNo.EditValue)
                                rpt_Interest_sub.paramYA.Value = CInt(cboYA.EditValue)
                                rpt_Interest_sub.DataSource = dsPNL_Report
                                rpt_Interest_sub.CreateDocument()
                                rpt_Interest = rpt_Interest_sub
                            Case 15
                                Dim rpt_Interest_sub As New rptPNL_InterestResict15
                                rpt_Interest_sub.paramCompanyName.Value = ADO.LoadTaxPayer_CompanyName(cboRefNo.EditValue)
                                rpt_Interest_sub.paramYA.Value = CInt(cboYA.EditValue)
                                rpt_Interest_sub.DataSource = dsPNL_Report
                                rpt_Interest_sub.CreateDocument()
                                rpt_Interest = rpt_Interest_sub
                            Case 16
                                Dim rpt_Interest_sub As New rptPNL_InterestResict16
                                rpt_Interest_sub.paramCompanyName.Value = ADO.LoadTaxPayer_CompanyName(cboRefNo.EditValue)
                                rpt_Interest_sub.paramYA.Value = CInt(cboYA.EditValue)
                                rpt_Interest_sub.DataSource = dsPNL_Report
                                rpt_Interest_sub.CreateDocument()
                                rpt_Interest = rpt_Interest_sub
                            Case 17
                                Dim rpt_Interest_sub As New rptPNL_InterestResict17
                                rpt_Interest_sub.paramCompanyName.Value = ADO.LoadTaxPayer_CompanyName(cboRefNo.EditValue)
                                rpt_Interest_sub.paramYA.Value = CInt(cboYA.EditValue)
                                rpt_Interest_sub.DataSource = dsPNL_Report
                                rpt_Interest_sub.CreateDocument()
                                rpt_Interest = rpt_Interest_sub
                            Case 18
                                Dim rpt_Interest_sub As New rptPNL_InterestResict18
                                rpt_Interest_sub.paramCompanyName.Value = ADO.LoadTaxPayer_CompanyName(cboRefNo.EditValue)
                                rpt_Interest_sub.paramYA.Value = CInt(cboYA.EditValue)
                                rpt_Interest_sub.DataSource = dsPNL_Report
                                rpt_Interest_sub.CreateDocument()
                                rpt_Interest = rpt_Interest_sub
                        End Select
                        Dim minPageCount As Integer = Math.Min(rpt.Pages.Count, rpt_interest.Pages.Count)

                        Dim x As Integer = 0

                        For Each pg As DevExpress.XtraPrinting.Page In rpt_interest.Pages
                            rpt.Pages.Add(pg)
                        Next
                    End If
                End If
               

                Dim printTool As New ReportPrintTool(rpt)
                printTool.ShowPreviewDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GetSubItemData(ByRef dsPNL_Report As DataSet, ByVal KeyName As String, ByVal TableName As String, ByVal TableName_Details As String, _
                          ByVal ColumnSourceNo As String, ByVal ColumnSourceNo_Details As String,
                          ByVal ColumnDescription As String, ByVal ColumnDescription_Details As String, _
                          ByVal ColumnAmount As String, ByVal ColumnAmount_Details As String, _
                          ByVal ColumnTable As String, ByVal ColumnTable_Details As String, ByVal ColumnTable_Details_Key As String, _
                          ByVal ColumnAddBack As String, ByVal ColumnAddBack_Details As String, _
                          ByVal ColumnDeduct As String, ByVal ColumnDeduct_Details As String, _
                          ByVal ColumnPercentage As String, ByVal Type As Integer, ByVal PrefixName As String, _
                          ByVal LabelName As String, ByRef IntSch As Integer, ByVal ColumnName As String, _
                          ByVal PL_KEY As Integer, ByRef PNLINFO_ROW As DataRow)
        Try
            Dim dtRow As DataRow = Nothing
            Dim dtRowChild As DataRow = Nothing
            Dim TmpID As Integer = 0
            Dim TotalAmount As Decimal = 0
            Dim TotalPecentage As Decimal = 0
            Dim dtExclude As DataTable = Nothing

            If IsDBNull(PNLINFO_ROW("Type")) = False AndAlso (PNLINFO_ROW("Type") = 2 OrElse PNLINFO_ROW("Type") = 3) Then
                Select Case KeyName
                    Case "PURCHASE", "DEPRECIATION", "OTHERALLOWEXP", "OTHERNONALLOWEXP"
                        If dsDataSet.Tables(TableName).Rows.Count > 0 Then
                            IntSch += 1
                            PNLINFO_ROW("Sch") = "Schedule " & IntSch.ToString
                        End If
                    Case Else
                        dtExclude = Nothing
                        dtExclude = ADO.Load_PNL_IncludeInReport(ID, ColumnName)
                        If dsDataSet.Tables(TableName).Rows.Count > 0 Then
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
                If dsDataSet.Tables(TableName).Rows.Count > 0 Then
                    IntSch += 1
                    PNLINFO_ROW("Sch") = "Schedule " & IntSch.ToString
                End If

            End If

            dsPNL_Report.Tables("PNL_TABLE_INFO").Rows.Add(PNLINFO_ROW)

            Select Case KeyName
                Case "DIVIDENDINC"
                    For Each rowx As DataRow In dsDataSet.Tables(TableName).Rows
                        If IsDBNull(rowx(ColumnAmount)) = False AndAlso IsNumeric(rowx(ColumnAmount)) Then
                            TotalAmount += rowx(ColumnAmount)
                        End If
                    Next
                    For Each rowx As DataRow In dsDataSet.Tables(TableName).Rows
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
                    For Each rowx As DataRow In dsDataSet.Tables(TableName).Rows
                        If IsDBNull(rowx(ColumnAmount)) = False AndAlso IsNumeric(rowx(ColumnAmount)) Then
                            TotalAmount += rowx(ColumnAmount)
                        End If
                    Next
                    For Each rowx As DataRow In dsDataSet.Tables(TableName).Rows
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
                    For Each rowx As DataRow In dsDataSet.Tables(TableName).Rows
                        If IsDBNull(rowx(ColumnAmount)) = False AndAlso IsNumeric(rowx(ColumnAmount)) Then
                            TotalAmount += rowx(ColumnAmount)
                        End If
                    Next
                    For Each rowx As DataRow In dsDataSet.Tables(TableName).Rows
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
                    For Each rowx As DataRow In dsDataSet.Tables(TableName).Rows
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
                    For Each rowx As DataRow In dsDataSet.Tables(TableName).Rows
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
                            For Each rowChild As DataRow In dsDataSet.Tables(TableName_Details).Rows
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
                    For Each rowx As DataRow In dsDataSet.Tables(TableName).Rows
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
                    For Each rowx As DataRow In dsDataSet.Tables(TableName).Rows
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
                    For Each rowx As DataRow In dsDataSet.Tables(TableName).Rows
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
                    For Each rowx As DataRow In dsDataSet.Tables(TableName).Rows
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
                                    dtRow("PECENTAGE_AMOUNT") = 0
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
                                    dtRow("PECENTAGE_AMOUNT") = 0
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
                            For Each rowChild As DataRow In dsDataSet.Tables(TableName_Details).Rows

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
                                                dtRowChild("PECENTAGE_AMOUNT") = 0
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
                                                dtRowChild("PECENTAGE_AMOUNT") = 0
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
            Dim clsNote As clsNote_PNL = Nothing
            If clsNote Is Nothing Then
                clsNote = New clsNote_PNL
            End If

            Dim dtNote As DataTable
            dtNote = Nothing
            dtNote = clsNote.Load_Note(ID, KeyName)
            If dtNote IsNot Nothing Then
                Dim dtRowAtt As Byte() = Nothing
                Dim Ext As String = Nothing
                For Each rowx As DataRow In dtNote.Rows
                    dsPNL_Report.Tables("PROFIT_LOSS_ACCOUNT_NOTE").ImportRow(rowx)

                    If IsDBNull(rowx("TypeNote")) = False Then
                        Select Case rowx("TypeNote")
                            Case 2
                                'Column
                                dtNoteColumn = clsNote.Load_Note_Column(rowx("ID"), ErrorLog)

                                If dtNoteColumn IsNot Nothing Then
                                    For Each rowy As DataRow In dtNoteColumn.Rows
                                        dsPNL_Report.Tables("PROFIT_LOSS_ACCOUNT_NOTE_COLUMN").ImportRow(rowy)
                                    Next

                                End If
                            Case 1
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
            Return ""
        End Try
    End Function

End Class