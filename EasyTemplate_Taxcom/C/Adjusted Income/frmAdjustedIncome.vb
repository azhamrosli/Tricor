Imports DevExpress.XtraBars.Docking

Public Class frmAdjustedIncome
    Dim ErrorLog As ClsError
    Dim isEdit As Boolean = False

    Dim docAI_NALoss As DockPanel
    Dim docAI_SurplusMiningAllowances As DockPanel
    Dim docAI_TaxIn As DockPanel
    Dim docAI_MiningAllowing As DockPanel
    Dim docAI_AddMiningExp As DockPanel
    Dim docAI_RevenueExp As DockPanel
    Dim docAI_OtherDeduc As DockPanel
    Dim docAI_OthExp As DockPanel

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
                        Dim uc As New ucAI_NALoss With {
                            .RefNo = CType(cboRefNo.EditValue, String),
                            .YA = CInt(cboYA.EditValue),
                            .txtAmount = txtNALoss,
                            .SourceNo = cboSourceNo,
                            .Dock = DockStyle.Fill
                        }

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
                            uc.Dock = DockStyle.Fill
                        End If
                        docAI_TaxIn.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docAI_TaxIn)
                    End If

                    DocumentManager1.View.ActivateDocument(docAI_TaxIn)
                Case 9
                    If docAI_MiningAllowing Is Nothing OrElse docAI_MiningAllowing.IsDisposed Then
                        docAI_MiningAllowing = New DockPanel
                        Dim uc As New ucAI_AddMiningExp With {
                            .RefNo = CType(cboRefNo.EditValue, String),
                            .YA = CInt(cboYA.EditValue),
                            .txtAmount = txtNALoss,
                            .SourceNo = cboSourceNo,
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
                        If docAI_MiningAllowing.Controls.Count > 0 AndAlso TypeOf docAI_MiningAllowing.Controls(0) Is ucAI_AddMiningExp Then
                            Dim uc As ucAI_AddMiningExp = CType(docAI_MiningAllowing.Controls(0), ucAI_AddMiningExp)
                            uc.RefNo = CType(cboRefNo.EditValue, String)
                            uc.YA = CInt(cboYA.EditValue)
                            uc.txtAmount = txtNALoss
                            uc.SourceNo = cboSourceNo
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

            If mdlProcess.ArgParam2 <> "" Then
                cboRefNo.EditValue = mdlProcess.ArgParam2
            End If

            If mdlProcess.ArgParam3 <> "" Then
                cboYA.EditValue = mdlProcess.ArgParam3
            End If

            If isEdit = False Then
                DockPanel1.Enabled = False
            Else
                DockPanel1.Enabled = True
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
            Dim dt As DataTable = Nothing
            Dim PNLKEY As Integer = 0
            If isEdit = False Then
                dt = ADO.Load_PNL(CType(cboRefNo.EditValue, String), CType(cboYA.EditValue, String), ErrorLog)

                If dt IsNot Nothing Then
                    PNLKEY = CInt(IIf(IsDBNull(dt.Rows(0)("PL_KEY")), 0, dt.Rows(0)("PL_KEY")))

                End If
            Else

            End If
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
End Class