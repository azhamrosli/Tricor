Imports DevExpress.XtraBars.Docking

Public Class frmAdjustedIncome_Add
    Dim ErrorLog As ClsError
    Public isEdit As Boolean = False
    Public RefNo As String = ""
    Public YA As String = ""
    Public SourceNo As Integer = 0

    Dim docAI_NALoss As DockPanel
    Dim docAI_SurplusMiningAllowances As DockPanel
    Dim docAI_TaxIn As DockPanel
    Dim docAI_MiningAllowing As DockPanel
    Dim docAI_AddMiningExp As DockPanel
    Dim docAI_RevenueExp As DockPanel
    Dim docAI_OtherDeduc As DockPanel
    Dim docAI_OthExp As DockPanel

    Dim dsAdjustmentIncome As dsAdjustedIncome = Nothing
    Public WithEvents AdjustedIncome As AdjustedIncome
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If ADO Is Nothing Then
            ADO = New clsIODatabase
        End If

    End Sub
#Region "CLICK"
    Private Sub OpenDetails(ByVal Type As Integer)
        Try
            DocumentManager1.BeginUpdate()

            Dim doc As DevExpress.XtraBars.Docking2010.Views.BaseDocument
            Select Case Type
                Case 1
                    If docAI_NALoss Is Nothing OrElse docAI_NALoss.IsDisposed Then
                        docAI_NALoss = New DockPanel
                        Dim uc As New ucAI_NALoss
                        uc.RefNo = cboRefNo.EditValue
                        uc.YA = CInt(cboYA.EditValue)
                        uc.txtAmount = txtNALoss
                        uc.SourceNo = cboSourceNo
                        uc.AdjustedIncome = AdjustedIncome
                        uc.Dock = DockStyle.Fill


                        docAI_NALoss.Text = "Non-allowable loss"
                        docAI_NALoss.Name = TaxComPNLEnuItem.SALES.ToString
                        docAI_NALoss.Controls.Add(uc)
                        docAI_NALoss.Register(DockManager1)
                        docAI_NALoss.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docAI_NALoss)
                    Else
                        docAI_NALoss.Visibility = DockVisibility.Visible
                        If docAI_NALoss.Controls.Count > 0 AndAlso TypeOf docAI_NALoss.Controls(0) Is ucAI_NALoss Then
                            Dim uc As ucAI_NALoss = CType(docAI_NALoss.Controls(0), ucAI_NALoss)
                            uc.RefNo = CType(cboRefNo.EditValue, String)
                            uc.YA = CInt(cboYA.EditValue)
                            uc.txtAmount = txtNALoss
                            uc.SourceNo = cboSourceNo
                            uc.AdjustedIncome = AdjustedIncome
                            uc.Dock = DockStyle.Fill
                        End If
                        docAI_NALoss.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docAI_NALoss)
                    End If

                    DocumentManager1.View.ActivateDocument(docAI_NALoss)
                Case 8
                    If docAI_SurplusMiningAllowances Is Nothing OrElse docAI_SurplusMiningAllowances.IsDisposed Then
                        docAI_SurplusMiningAllowances = New DockPanel
                        Dim uc As New ucAI_SurplusMiningAllowance With {
                            .RefNo = CType(cboRefNo.EditValue, String),
                            .YA = CInt(cboYA.EditValue),
                            .txtAmount = txtNALoss,
                            .SourceNo = cboSourceNo,
                            .AdjustedIncome = AdjustedIncome,
                            .Dock = DockStyle.Fill
                        }

                        docAI_SurplusMiningAllowances.Text = "Surplus Recovered Mining Expenditure"
                        docAI_SurplusMiningAllowances.Name = TaxComPNLEnuItem.SALES.ToString
                        docAI_SurplusMiningAllowances.Controls.Add(uc)
                        docAI_SurplusMiningAllowances.Register(DockManager1)
                        docAI_SurplusMiningAllowances.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docAI_SurplusMiningAllowances)
                    Else
                        docAI_SurplusMiningAllowances.Visibility = DockVisibility.Visible
                        If docAI_SurplusMiningAllowances.Controls.Count > 0 AndAlso TypeOf docAI_SurplusMiningAllowances.Controls(0) Is ucAI_SurplusMiningAllowance Then
                            Dim uc As ucAI_SurplusMiningAllowance = CType(docAI_SurplusMiningAllowances.Controls(0), ucAI_SurplusMiningAllowance)
                            uc.RefNo = CType(cboRefNo.EditValue, String)
                            uc.YA = CInt(cboYA.EditValue)
                            uc.txtAmount = txtNALoss
                            uc.SourceNo = cboSourceNo
                            uc.AdjustedIncome = AdjustedIncome
                            uc.Dock = DockStyle.Fill
                        End If
                        docAI_SurplusMiningAllowances.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docAI_SurplusMiningAllowances)
                    End If

                    DocumentManager1.View.ActivateDocument(docAI_SurplusMiningAllowances)
                Case 3
                    If docAI_TaxIn Is Nothing OrElse docAI_TaxIn.IsDisposed Then
                        docAI_TaxIn = New DockPanel
                        Dim uc As New ucAI_TaxIn With {
                            .RefNo = CType(cboRefNo.EditValue, String),
                            .YA = CInt(cboYA.EditValue),
                            .txtAmount = txtNALoss,
                            .SourceNo = cboSourceNo,
                            .AdjustedIncome = AdjustedIncome,
                            .Dock = DockStyle.Fill
                        }

                        docAI_TaxIn.Text = "Non-taxable income/gain taken up in Proft and Loss Account but taken up in Balance Sheet"
                        docAI_TaxIn.Name = TaxComPNLEnuItem.SALES.ToString
                        docAI_TaxIn.Controls.Add(uc)
                        docAI_TaxIn.Register(DockManager1)
                        docAI_TaxIn.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docAI_TaxIn)
                    Else
                        docAI_TaxIn.Visibility = DockVisibility.Visible
                        If docAI_TaxIn.Controls.Count > 0 AndAlso TypeOf docAI_TaxIn.Controls(0) Is ucAI_TaxIn Then
                            Dim uc As ucAI_TaxIn = CType(docAI_TaxIn.Controls(0), ucAI_TaxIn)
                            uc.RefNo = CType(cboRefNo.EditValue, String)
                            uc.YA = CInt(cboYA.EditValue)
                            uc.txtAmount = txtNALoss
                            uc.SourceNo = cboSourceNo
                            uc.AdjustedIncome = AdjustedIncome
                            uc.Dock = DockStyle.Fill
                        End If
                        docAI_TaxIn.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docAI_TaxIn)
                    End If

                    DocumentManager1.View.ActivateDocument(docAI_TaxIn)
                Case 9
                    If docAI_MiningAllowing Is Nothing OrElse docAI_MiningAllowing.IsDisposed Then
                        docAI_MiningAllowing = New DockPanel
                        Dim uc As New ucAI_MiningAllowing With {
                            .RefNo = CType(cboRefNo.EditValue, String),
                            .YA = CInt(cboYA.EditValue),
                            .txtAmount = txtNALoss,
                            .SourceNo = cboSourceNo,
                             .AdjustedIncome = AdjustedIncome,
                            .Dock = DockStyle.Fill
                        }

                        docAI_MiningAllowing.Text = "2.1 Mining Allowance"
                        docAI_MiningAllowing.Name = TaxComPNLEnuItem.SALES.ToString
                        docAI_MiningAllowing.Controls.Add(uc)
                        docAI_MiningAllowing.Register(DockManager1)
                        docAI_MiningAllowing.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docAI_MiningAllowing)
                    Else
                        docAI_MiningAllowing.Visibility = DockVisibility.Visible
                        If docAI_MiningAllowing.Controls.Count > 0 AndAlso TypeOf docAI_MiningAllowing.Controls(0) Is ucAI_MiningAllowing Then
                            Dim uc As ucAI_MiningAllowing = CType(docAI_MiningAllowing.Controls(0), ucAI_MiningAllowing)
                            uc.RefNo = CType(cboRefNo.EditValue, String)
                            uc.YA = CInt(cboYA.EditValue)
                            uc.txtAmount = txtNALoss
                            uc.SourceNo = cboSourceNo
                            uc.AdjustedIncome = AdjustedIncome
                            uc.Dock = DockStyle.Fill
                        End If
                        docAI_MiningAllowing.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docAI_MiningAllowing)
                    End If

                    DocumentManager1.View.ActivateDocument(docAI_MiningAllowing)
                Case 10
                    If docAI_AddMiningExp Is Nothing OrElse docAI_AddMiningExp.IsDisposed Then
                        docAI_AddMiningExp = New DockPanel
                        Dim uc As New ucAI_AddMiningExp With {
                            .RefNo = CType(cboRefNo.EditValue, String),
                            .YA = CInt(cboYA.EditValue),
                            .txtAmount = txtNALoss,
                            .SourceNo = cboSourceNo,
                            .AdjustedIncome = AdjustedIncome,
                            .Dock = DockStyle.Fill
                        }

                        docAI_AddMiningExp.Text = "2.2 Surplus Mining Expenses"
                        docAI_AddMiningExp.Name = TaxComPNLEnuItem.SALES.ToString
                        docAI_AddMiningExp.Controls.Add(uc)
                        docAI_AddMiningExp.Register(DockManager1)
                        docAI_AddMiningExp.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docAI_AddMiningExp)
                    Else
                        docAI_AddMiningExp.Visibility = DockVisibility.Visible
                        If docAI_AddMiningExp.Controls.Count > 0 AndAlso TypeOf docAI_AddMiningExp.Controls(0) Is ucAI_AddMiningExp Then
                            Dim uc As ucAI_AddMiningExp = CType(docAI_AddMiningExp.Controls(0), ucAI_AddMiningExp)
                            uc.RefNo = CType(cboRefNo.EditValue, String)
                            uc.YA = CInt(cboYA.EditValue)
                            uc.txtAmount = txtNALoss
                            uc.SourceNo = cboSourceNo
                            uc.AdjustedIncome = AdjustedIncome
                            uc.Dock = DockStyle.Fill
                        End If
                        docAI_AddMiningExp.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docAI_AddMiningExp)
                    End If

                    DocumentManager1.View.ActivateDocument(docAI_AddMiningExp)
                Case 5
                    If docAI_RevenueExp Is Nothing OrElse docAI_RevenueExp.IsDisposed Then
                        docAI_RevenueExp = New DockPanel
                        Dim uc As New ucAI_RevenueExp With {
                            .RefNo = CType(cboRefNo.EditValue, String),
                            .YA = CInt(cboYA.EditValue),
                            .txtAmount = txtNALoss,
                            .SourceNo = cboSourceNo,
                            .AdjustedIncome = AdjustedIncome,
                            .Dock = DockStyle.Fill
                        }

                        docAI_RevenueExp.Text = "2.3 Revenue expenditure capitalised"
                        docAI_RevenueExp.Name = TaxComPNLEnuItem.SALES.ToString
                        docAI_RevenueExp.Controls.Add(uc)
                        docAI_RevenueExp.Register(DockManager1)
                        docAI_RevenueExp.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docAI_RevenueExp)
                    Else
                        docAI_RevenueExp.Visibility = DockVisibility.Visible
                        If docAI_RevenueExp.Controls.Count > 0 AndAlso TypeOf docAI_RevenueExp.Controls(0) Is ucAI_RevenueExp Then
                            Dim uc As ucAI_RevenueExp = CType(docAI_RevenueExp.Controls(0), ucAI_RevenueExp)
                            uc.RefNo = CType(cboRefNo.EditValue, String)
                            uc.YA = CInt(cboYA.EditValue)
                            uc.txtAmount = txtNALoss
                            uc.SourceNo = cboSourceNo
                            uc.AdjustedIncome = AdjustedIncome
                            uc.Dock = DockStyle.Fill
                        End If
                        docAI_RevenueExp.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docAI_RevenueExp)
                    End If

                    DocumentManager1.View.ActivateDocument(docAI_RevenueExp)
                Case 7
                    If docAI_OtherDeduc Is Nothing OrElse docAI_OtherDeduc.IsDisposed Then
                        docAI_OtherDeduc = New DockPanel
                        Dim uc As New ucAI_OtherDeduc With {
                            .RefNo = CType(cboRefNo.EditValue, String),
                            .YA = CInt(cboYA.EditValue),
                            .txtAmount = txtNALoss,
                            .SourceNo = cboSourceNo,
                             .AdjustedIncome = AdjustedIncome,
                            .Dock = DockStyle.Fill
                        }

                        docAI_OtherDeduc.Text = "Other Deduction"
                        docAI_OtherDeduc.Name = TaxComPNLEnuItem.SALES.ToString
                        docAI_OtherDeduc.Controls.Add(uc)
                        docAI_OtherDeduc.Register(DockManager1)
                        docAI_OtherDeduc.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docAI_OtherDeduc)
                    Else
                        docAI_OtherDeduc.Visibility = DockVisibility.Visible
                        If docAI_OtherDeduc.Controls.Count > 0 AndAlso TypeOf docAI_OtherDeduc.Controls(0) Is ucAI_OtherDeduc Then
                            Dim uc As ucAI_OtherDeduc = CType(docAI_OtherDeduc.Controls(0), ucAI_OtherDeduc)
                            uc.RefNo = CType(cboRefNo.EditValue, String)
                            uc.YA = CInt(cboYA.EditValue)
                            uc.txtAmount = txtNALoss
                            uc.SourceNo = cboSourceNo
                            uc.AdjustedIncome = AdjustedIncome
                            uc.Dock = DockStyle.Fill
                        End If
                        docAI_OtherDeduc.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docAI_OtherDeduc)
                    End If

                    DocumentManager1.View.ActivateDocument(docAI_OtherDeduc)
                Case 6
                    If docAI_OthExp Is Nothing OrElse docAI_OthExp.IsDisposed Then
                        docAI_OthExp = New DockPanel
                        Dim uc As New ucAI_OthExp With {
                            .RefNo = CType(cboRefNo.EditValue, String),
                            .YA = CInt(cboYA.EditValue),
                            .txtAmount = txtNALoss,
                            .SourceNo = cboSourceNo,
                             .AdjustedIncome = AdjustedIncome,
                                .Dock = DockStyle.Fill
                        }

                        docAI_OthExp.Text = "2.4 Claim for other expenditure/incentive"
                        docAI_OthExp.Name = TaxComPNLEnuItem.SALES.ToString
                        docAI_OthExp.Controls.Add(uc)
                        docAI_OthExp.Register(DockManager1)
                        docAI_OthExp.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docAI_OthExp)
                    Else
                        docAI_OthExp.Visibility = DockVisibility.Visible
                        If docAI_OthExp.Controls.Count > 0 AndAlso TypeOf docAI_OthExp.Controls(0) Is ucAI_OthExp Then
                            Dim uc As ucAI_OthExp = CType(docAI_OthExp.Controls(0), ucAI_OthExp)
                            uc.RefNo = CType(cboRefNo.EditValue, String)
                            uc.YA = CInt(cboYA.EditValue)
                            uc.txtAmount = txtNALoss
                            uc.SourceNo = cboSourceNo
                            uc.AdjustedIncome = AdjustedIncome
                            uc.Dock = DockStyle.Fill
                        End If
                        docAI_OthExp.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docAI_OthExp)
                    End If

                    DocumentManager1.View.ActivateDocument(docAI_OthExp)
            End Select
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
    Private Sub btnNALoss_Click(sender As Object, e As EventArgs) Handles btnNALoss.Click
        OpenDetails(1)
    End Sub
    Private Sub lblNALoss_DoubleClick(sender As Object, e As EventArgs) Handles lblNALoss.DoubleClick
        OpenDetails(1)
    End Sub
    Private Sub lblSurplusMiningAllowance_DoubleClick(sender As Object, e As EventArgs) Handles lblSurplusMiningAllowance.DoubleClick
        OpenDetails(8)
    End Sub
    Private Sub btnSurplusMiningAllowance_Click(sender As Object, e As EventArgs) Handles btnSurplusMiningAllowance.Click
        OpenDetails(8)
    End Sub
    Private Sub btnTaxIn_Click(sender As Object, e As EventArgs) Handles btnTaxIn.Click
        OpenDetails(3)
    End Sub
    Private Sub lblTaxIn_DoubleClick(sender As Object, e As EventArgs) Handles lblTaxIn.DoubleClick
        OpenDetails(3)
    End Sub
    Private Sub btnOthExp_Click(sender As Object, e As EventArgs) Handles btnOthExp.Click
        OpenDetails(6)
    End Sub
    Private Sub lblOthExp_Click(sender As Object, e As EventArgs) Handles lblOthExp.DoubleClick
        OpenDetails(6)
    End Sub
    Private Sub lblOtherDeduc_Click(sender As Object, e As EventArgs) Handles lblOtherDeduc.DoubleClick
        OpenDetails(7)
    End Sub
    Private Sub btnOtherDeduc_Click(sender As Object, e As EventArgs) Handles btnOtherDeduc.Click
        OpenDetails(7)
    End Sub
    Private Sub lblRevenueExp_Click(sender As Object, e As EventArgs) Handles lblRevenueExp.DoubleClick
        OpenDetails(5)
    End Sub
    Private Sub btnRevenueExp_Click(sender As Object, e As EventArgs) Handles btnRevenueExp.Click
        OpenDetails(5)
    End Sub
    Private Sub btnAddMiningExp_Click(sender As Object, e As EventArgs) Handles btnAddMiningExp.Click
        OpenDetails(10)
    End Sub
    Private Sub lblAddMiningExp_Click(sender As Object, e As EventArgs) Handles lblAddMiningExp.DoubleClick
        OpenDetails(10)
    End Sub
    Private Sub lblMiningAllowing_Click(sender As Object, e As EventArgs) Handles lblMiningAllowing.DoubleClick
        OpenDetails(9)
    End Sub
    Private Sub btnMiningAllowing_Click(sender As Object, e As EventArgs) Handles btnMiningAllowing.Click
        OpenDetails(9)
    End Sub
#End Region

    Private Sub frmAdjustedIncome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If CreateLookUpTaxPayer(dsDefault, ErrorLog) = False Then
                MsgBox("Unable to retrive tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If CreateLookUpYA(cboYA, ErrorLog) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If isEdit = False Then
                If mdlProcess.ArgParam2 <> "" Then
                    cboRefNo.EditValue = mdlProcess.ArgParam2
                End If

                If mdlProcess.ArgParam3 <> "" Then
                    cboYA.EditValue = mdlProcess.ArgParam3
                End If

                DockPanel1.Enabled = False
            Else
                DockPanel1.Enabled = True
                cboRefNo.EditValue = RefNo
                cboYA.EditValue = YA
                Application.DoEvents()
                cboSourceNo.EditValue = SourceNo
            End If
            Application.DoEvents()

            LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub LoadData()
        Try
            If cboSourceNo.EditValue Is Nothing Then
                Exit Sub
            End If

            If AdjustedIncome Is Nothing Then
                AdjustedIncome = New AdjustedIncome
                If dsAdjustmentIncome Is Nothing Then
                    dsAdjustmentIncome = New dsAdjustedIncome
                End If
                AdjustedIncome.dsAdjustIncome = dsAdjustmentIncome
            End If

            AdjustedIncome.RefNo = cboRefNo.EditValue
            AdjustedIncome.YA = cboYA.EditValue
            AdjustedIncome.SourceNo = CInt(cboSourceNo.EditValue)
            AdjustedIncome.LoadData()

            'Dim dt As DataTable = Nothing
            'Dim PNLKEY As Integer = 0

            'Dim PL_GROSS_PROFIT As Decimal = 0
            'Dim PL_OTH_BSIN As Decimal = 0


            'If isEdit = False Then
            '    dt = ADO.Load_PNL(CType(cboRefNo.EditValue, String), CType(cboYA.EditValue, String), CInt(cboSourceNo.EditValue), ErrorLog)

            '    If dt IsNot Nothing Then
            '        PNLKEY = CInt(IIf(IsDBNull(dt.Rows(0)("PL_KEY")), 0, dt.Rows(0)("PL_KEY")))



            '        'If IsDBNull(dt.Rows(0)("PL_NET_PROFIT_LOSS")) = False AndAlso IsNumeric(dt.Rows(0)("PL_NET_PROFIT_LOSS")) Then

            '        '    If CDec(dt.Rows(0)("PL_NET_PROFIT_LOSS")) > 0 Then
            '        '        txtBalProfit.EditValue = CDec(dt.Rows(0)("PL_NET_PROFIT_LOSS")).ToString("N0")
            '        '    ElseIf CDec(dt.Rows(0)("PL_NET_PROFIT_LOSS")) < 0 Then
            '        '        txtBalLoss.EditValue = CDec(dt.Rows(0)("PL_NET_PROFIT_LOSS")).ToString("N0")
            '        '    End If

            '        'End If
            '    End If

            'Else

            'End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            txtTaxPayer.EditValue = cboRefNo.EditValue

            LoadSourceNo()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try

    End Sub

    Private Sub cboYA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYA.SelectedIndexChanged
        LoadSourceNo()
    End Sub
    Private Sub LoadSourceNo()
        Try
            DsDefault.Tables("BUSINESS_SOURCE").Rows.Clear()
            If cboRefNo.EditValue Is Nothing OrElse cboRefNo.EditValue = "" Then
                Exit Sub
            End If
            If cboYA.EditValue Is Nothing OrElse cboYA.EditValue = "" Then
                Exit Sub
            End If

            If mdlProcess.CreateSearchLookUpSourceNo(DsDefault, cboRefNo.EditValue, cboYA.EditValue, ErrorLog) Then
                BUSINESSSOURCEBindingSource.DataSource = DsDefault.Tables("BUSINESS_SOURCE")
            Else
                BUSINESSSOURCEBindingSource.DataSource = Nothing
            End If

            isReadyToLoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub isReadyToLoadData()
        Try
            If cboRefNo.EditValue Is Nothing OrElse cboRefNo.EditValue = "" Then
                DockPanel1.Enabled = False
                Exit Sub
            End If
            If cboYA.EditValue Is Nothing OrElse cboYA.EditValue = "" Then
                DockPanel1.Enabled = False
                Exit Sub
            End If
            If cboSourceNo.EditValue Is Nothing OrElse IsNumeric(cboSourceNo.EditValue) = False Then
                DockPanel1.Enabled = False
                Exit Sub
            End If

            DockPanel1.Enabled = True
            Me.LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub cboSourceNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboSourceNo.EditValueChanged
        Try
            isReadyToLoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub AdjustedIncome_OnChangeStatus(Status_ As AdjustedIncome.EnumStatus, Stage_ As AdjustedIncome.EnumStage, ErrorLog_ As ClsError) Handles AdjustedIncome.OnChangeStatus
        Try
            Select Case Status_
                Case EasyTemplate_Taxcom.AdjustedIncome.EnumStatus.Ready
                    DockPanel1.Enabled = False
                    DockPanel2.Enabled = True
                    ProgressPanel1.Visible = False
                    lblStatus.Caption = ""
                Case EasyTemplate_Taxcom.AdjustedIncome.EnumStatus.InProgress
                    DockPanel1.Enabled = False
                    DockPanel2.Enabled = False
                    ProgressPanel1.Visible = True

                    Select Case Stage_
                        Case EasyTemplate_Taxcom.AdjustedIncome.EnumStage.Load
                            lblStatus.Caption = "Status : InProgress / Load Data"
                        Case EasyTemplate_Taxcom.AdjustedIncome.EnumStage.Save
                            lblStatus.Caption = "Status : InProgress / Saving Data"
                        Case EasyTemplate_Taxcom.AdjustedIncome.EnumStage.Calculating
                            lblStatus.Caption = "Status : InProgress / Calculating"
                    End Select

                Case EasyTemplate_Taxcom.AdjustedIncome.EnumStatus.Done
                    DockPanel1.Enabled = True
                    DockPanel2.Enabled = True
                    ProgressPanel1.Visible = False
                    lblStatus.Caption = "Status : Done"
                    If Stage_ = EasyTemplate_Taxcom.AdjustedIncome.EnumStage.Save Then
                        MsgBox("Successfully saved adjusted income.", MsgBoxStyle.Information)
                    End If
                Case EasyTemplate_Taxcom.AdjustedIncome.EnumStatus.Failed
                    DockPanel1.Enabled = False
                    DockPanel2.Enabled = True
                    ProgressPanel1.Visible = False
                    lblStatus.Caption = "Status : Failed"
                    If ErrorLog_ IsNot Nothing Then
                        MsgBox("Failed!" & vbCrLf & ErrorLog_.ErrorName & " - " & ErrorLog_.ErrorMessage)
                    End If
                Case EasyTemplate_Taxcom.AdjustedIncome.EnumStatus.isInvestmentHolding
                    lblStatus.Caption = "Status : Failed"
                    MsgBox("This company belong to investment holding, please use S60F.", MsgBoxStyle.Exclamation)
                    Me.Close()
            End Select
            Application.DoEvents()

        Catch ex As Exception

        End Try
    End Sub


    Private Sub AdjustedIncome_OnChangeStep1(txtBalProfit_ As Decimal, txtBalLoss_ As Decimal, txtDividend_ As Decimal, txtInterest_ As Decimal,
                                             txtRental_ As Decimal, txtRoyalty_ As Decimal, txtSection4A_ As Decimal, txtTotBsProfit_ As Decimal,
                                             txtNTaxIn_ As Decimal, txtOthBsIn_ As Decimal, txtTotNonBs_ As Decimal, txtInterestRestricted_ As Decimal,
                                             txtNAExp_ As Decimal, txtTotBsLoss_ As Decimal) Handles AdjustedIncome.OnChangeStep1
        Try
            txtBalProfit.EditValue = txtBalProfit_.ToString("N0")
            txtBalLoss.EditValue = txtBalLoss_.ToString("N0")
            txtDividend.EditValue = txtDividend_.ToString("N0")
            txtInterest.EditValue = txtInterest_.ToString("N0")
            txtRental.EditValue = txtRental_.ToString("N0")
            txtRoyalty.EditValue = txtRoyalty_.ToString("N0")
            txtSection4A.EditValue = txtSection4A_.ToString("N0")
            txtTotBsProfit.EditValue = txtTotBsProfit_.ToString("N0")
            txtNTaxIn.EditValue = txtNTaxIn_.ToString("N0")
            txtOthBsIn.EditValue = txtOthBsIn_.ToString("N0")
            txtTotNonBs.EditValue = txtTotNonBs_.ToString("N0")
            txtInterestRestricted.EditValue = txtInterestRestricted_.ToString("N0")
            txtNAExp.EditValue = txtNAExp_.ToString("N0")
            txtTotBsLoss.EditValue = txtTotBsLoss_.ToString("N0")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AdjustedIncome_OnChangeStep2(txtNALoss_ As Decimal, txtSurplusMiningAllowance_ As Decimal, txtTaxIn_ As Decimal, _
                                             txtAddMiningExp_ As Decimal, txtMiningAllowing_ As Decimal, txtRevenueExp_ As Decimal, _
                                             txtOtherDeduc_ As Decimal, txtOthExp_ As Decimal) Handles AdjustedIncome.OnChangeStep2
        Try
            txtNALoss.EditValue = txtNALoss_.ToString("N0")
            txtSurplusMiningAllowance.EditValue = txtSurplusMiningAllowance_.ToString("N0")
            txtTaxIn.EditValue = txtTaxIn_.ToString("N0")
            txtAddMiningExp.EditValue = txtAddMiningExp_.ToString("N0")
            txtMiningAllowing.EditValue = txtMiningAllowing_.ToString("N0")
            txtRevenueExp.EditValue = txtRevenueExp_.ToString("N0")
            txtOtherDeduc.EditValue = txtOtherDeduc_.ToString("N0")
            txtOthExp.EditValue = txtOthExp_.toString("N0")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AdjustedIncome_OnChangeStep3(txtTotBIProfit_ As Decimal, txtTotBILoss_ As Decimal, txtTotBSExp_ As Decimal, txtAdIn_ As Decimal,
                                             txtAdLoss_ As Decimal) Handles AdjustedIncome.OnChangeStep3
        Try
            txtTotBIProfit.EditValue = txtTotBIProfit_.ToString("N0")
            txtTotBILoss.EditValue = txtTotBILoss_.ToString("N0")
            txtTotBSExp.EditValue = txtTotBSExp_.ToString("N0")
            txtAdIn.EditValue = txtAdIn_.ToString("N0")
            txtAdLoss.EditValue = txtAdLoss_.ToString("N0")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Try
            AdjustedIncome.SaveData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

End Class