Imports DevExpress.XtraBars.Docking

Public Class frmTaxComputation_Add
    Public RefNo As String = "123123123"
    Public YA As String = "2017"

    Dim dsAdjustmentIncome As dsAdjustedIncome = Nothing
    Dim WithEvents AdjustedIncome As AdjustedIncome = Nothing
    Dim docStatutoryIncome As DockPanel
    Dim docNonBusinessIncome As DockPanel
    Dim docIncomeTaxPayable1 As DockPanel
    Dim docIncomeTaxPayable2 As DockPanel
    Dim docComputationofUnabsorbedCA As DockPanel
    Dim docUnabsordbedLoss As DockPanel
    Dim docRA_ITA As DockPanel
    Dim docExcessiveDiffencePenalty As DockPanel
    Dim docUnabsoredExportAllowance As DockPanel

    Enum EnumFormType
        StatutoryIncome = 0
        NonBusinessIncome = 1
        IncomeTaxPayable1 = 2
        IncomeTaxPayable2 = 3
        ComputationofUnabsorbedCA = 4
        UnabsordbedLoss = 5
        RA_ITA = 6
        ExcessiveDiffencePenalty = 7
        UnabsoredExportAllowance = 8
    End Enum
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If AdjustedIncome Is Nothing Then
            AdjustedIncome = New AdjustedIncome
     
        End If

    End Sub
#Region "NAVAGATION"
    Private Sub OpenDetail(ByVal Type As EnumFormType, ByVal Title As String)
        Try
            Select Case Type
                Case EnumFormType.StatutoryIncome
                    If docStatutoryIncome Is Nothing OrElse docStatutoryIncome.IsDisposed Then
                        docStatutoryIncome = New DockPanel
                        Dim uc As New ucTaxCom_StatutoryIncome
                        uc.AdjustedIncome = AdjustedIncome
                        uc.Dock = DockStyle.Fill
                        uc.RefNo = RefNo
                        uc.YA = YA

                        docStatutoryIncome.Text = Title
                        docStatutoryIncome.Name = TaxComPNLEnuItem.SALES.ToString
                        docStatutoryIncome.Controls.Add(uc)
                        docStatutoryIncome.Register(DockManager1)
                        docStatutoryIncome.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docStatutoryIncome)
                    Else
                        docStatutoryIncome.Visibility = DockVisibility.Visible
                        If docStatutoryIncome.Controls.Count > 0 AndAlso TypeOf docStatutoryIncome.Controls(0) Is ucTaxCom_StatutoryIncome Then
                            Dim uc As ucTaxCom_StatutoryIncome = CType(docStatutoryIncome.Controls(0), ucTaxCom_StatutoryIncome)
                            uc.AdjustedIncome = AdjustedIncome
                            uc.Dock = DockStyle.Fill
                            uc.RefNo = RefNo
                            uc.YA = YA
                        End If
                        docStatutoryIncome.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docStatutoryIncome)
                    End If

                    DocumentManager1.View.ActivateDocument(docStatutoryIncome)
                Case EnumFormType.NonBusinessIncome
                    If docNonBusinessIncome Is Nothing OrElse docNonBusinessIncome.IsDisposed Then
                        docNonBusinessIncome = New DockPanel
                        Dim uc As New ucTaxCom_NonBusinessIncome
                        uc.AdjustedIncome = AdjustedIncome
                        uc.Dock = DockStyle.Fill


                        docNonBusinessIncome.Text = Title
                        docNonBusinessIncome.Name = TaxComPNLEnuItem.SALES.ToString
                        docNonBusinessIncome.Controls.Add(uc)
                        docNonBusinessIncome.Register(DockManager1)
                        docNonBusinessIncome.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docNonBusinessIncome)
                    Else
                        docNonBusinessIncome.Visibility = DockVisibility.Visible
                        If docNonBusinessIncome.Controls.Count > 0 AndAlso TypeOf docNonBusinessIncome.Controls(0) Is ucTaxCom_NonBusinessIncome Then
                            Dim uc As ucTaxCom_NonBusinessIncome = CType(docNonBusinessIncome.Controls(0), ucTaxCom_NonBusinessIncome)
                            uc.AdjustedIncome = AdjustedIncome
                            uc.Dock = DockStyle.Fill
                        End If
                        docNonBusinessIncome.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docNonBusinessIncome)
                    End If

                    DocumentManager1.View.ActivateDocument(docNonBusinessIncome)
                Case EnumFormType.IncomeTaxPayable1
                    If docIncomeTaxPayable1 Is Nothing OrElse docIncomeTaxPayable1.IsDisposed Then
                        docIncomeTaxPayable1 = New DockPanel
                        Dim uc As New ucTaxCom_IncomePayable1
                        uc.AdjustedIncome = AdjustedIncome
                        uc.Dock = DockStyle.Fill


                        docIncomeTaxPayable1.Text = Title
                        docIncomeTaxPayable1.Name = TaxComPNLEnuItem.SALES.ToString
                        docIncomeTaxPayable1.Controls.Add(uc)
                        docIncomeTaxPayable1.Register(DockManager1)
                        docIncomeTaxPayable1.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docIncomeTaxPayable1)
                    Else
                        docIncomeTaxPayable1.Visibility = DockVisibility.Visible
                        If docIncomeTaxPayable1.Controls.Count > 0 AndAlso TypeOf docIncomeTaxPayable1.Controls(0) Is ucTaxCom_IncomePayable1 Then
                            Dim uc As ucTaxCom_IncomePayable1 = CType(docIncomeTaxPayable1.Controls(0), ucTaxCom_IncomePayable1)
                            uc.AdjustedIncome = AdjustedIncome
                            uc.Dock = DockStyle.Fill
                        End If
                        docIncomeTaxPayable1.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docIncomeTaxPayable1)
                    End If

                    DocumentManager1.View.ActivateDocument(docIncomeTaxPayable1)
                Case EnumFormType.IncomeTaxPayable2
                    If docIncomeTaxPayable2 Is Nothing OrElse docIncomeTaxPayable2.IsDisposed Then
                        docIncomeTaxPayable2 = New DockPanel
                        Dim uc As New ucTaxCom_IncomePayable2
                        uc.AdjustedIncome = AdjustedIncome
                        uc.Dock = DockStyle.Fill


                        docIncomeTaxPayable2.Text = Title
                        docIncomeTaxPayable2.Name = TaxComPNLEnuItem.SALES.ToString
                        docIncomeTaxPayable2.Controls.Add(uc)
                        docIncomeTaxPayable2.Register(DockManager1)
                        docIncomeTaxPayable2.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docIncomeTaxPayable2)
                    Else
                        docIncomeTaxPayable2.Visibility = DockVisibility.Visible
                        If docIncomeTaxPayable2.Controls.Count > 0 AndAlso TypeOf docIncomeTaxPayable2.Controls(0) Is ucTaxCom_IncomePayable2 Then
                            Dim uc As ucTaxCom_IncomePayable2 = CType(docIncomeTaxPayable2.Controls(0), ucTaxCom_IncomePayable2)
                            uc.AdjustedIncome = AdjustedIncome
                            uc.Dock = DockStyle.Fill
                        End If
                        docIncomeTaxPayable2.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docIncomeTaxPayable2)
                    End If

                    DocumentManager1.View.ActivateDocument(docIncomeTaxPayable2)
                Case EnumFormType.ComputationofUnabsorbedCA
                    If docComputationofUnabsorbedCA Is Nothing OrElse docComputationofUnabsorbedCA.IsDisposed Then
                        docComputationofUnabsorbedCA = New DockPanel
                        Dim uc As New ucTaxCom_UnabsorbedCA
                        uc.AdjustedIncome = AdjustedIncome
                        uc.Dock = DockStyle.Fill


                        docComputationofUnabsorbedCA.Text = Title
                        docComputationofUnabsorbedCA.Name = TaxComPNLEnuItem.SALES.ToString
                        docComputationofUnabsorbedCA.Controls.Add(uc)
                        docComputationofUnabsorbedCA.Register(DockManager1)
                        docComputationofUnabsorbedCA.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docComputationofUnabsorbedCA)
                    Else
                        docComputationofUnabsorbedCA.Visibility = DockVisibility.Visible
                        If docComputationofUnabsorbedCA.Controls.Count > 0 AndAlso TypeOf docComputationofUnabsorbedCA.Controls(0) Is ucTaxCom_UnabsorbedCA Then
                            Dim uc As ucTaxCom_UnabsorbedCA = CType(docComputationofUnabsorbedCA.Controls(0), ucTaxCom_UnabsorbedCA)
                            uc.AdjustedIncome = AdjustedIncome
                            uc.Dock = DockStyle.Fill
                        End If
                        docComputationofUnabsorbedCA.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docComputationofUnabsorbedCA)
                    End If

                    DocumentManager1.View.ActivateDocument(docComputationofUnabsorbedCA)
                Case EnumFormType.UnabsordbedLoss
                    If docUnabsordbedLoss Is Nothing OrElse docUnabsordbedLoss.IsDisposed Then
                        docUnabsordbedLoss = New DockPanel
                        Dim uc As New ucTaxCom_UnabsorbedBizLoss
                        uc.AdjustedIncome = AdjustedIncome
                        uc.Dock = DockStyle.Fill


                        docUnabsordbedLoss.Text = Title
                        docUnabsordbedLoss.Name = TaxComPNLEnuItem.SALES.ToString
                        docUnabsordbedLoss.Controls.Add(uc)
                        docUnabsordbedLoss.Register(DockManager1)
                        docUnabsordbedLoss.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docUnabsordbedLoss)
                    Else
                        docUnabsordbedLoss.Visibility = DockVisibility.Visible
                        If docUnabsordbedLoss.Controls.Count > 0 AndAlso TypeOf docUnabsordbedLoss.Controls(0) Is ucTaxCom_UnabsorbedBizLoss Then
                            Dim uc As ucTaxCom_UnabsorbedBizLoss = CType(docUnabsordbedLoss.Controls(0), ucTaxCom_UnabsorbedBizLoss)
                            uc.AdjustedIncome = AdjustedIncome
                            uc.Dock = DockStyle.Fill
                        End If
                        docUnabsordbedLoss.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docUnabsordbedLoss)
                    End If

                    DocumentManager1.View.ActivateDocument(docUnabsordbedLoss)
                Case EnumFormType.RA_ITA
                    If docRA_ITA Is Nothing OrElse docRA_ITA.IsDisposed Then
                        docRA_ITA = New DockPanel
                        Dim uc As New ucTaxCom_RAITA
                        uc.AdjustedIncome = AdjustedIncome
                        uc.Dock = DockStyle.Fill


                        docRA_ITA.Text = Title
                        docRA_ITA.Name = TaxComPNLEnuItem.SALES.ToString
                        docRA_ITA.Controls.Add(uc)
                        docRA_ITA.Register(DockManager1)
                        docRA_ITA.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docRA_ITA)
                    Else
                        docRA_ITA.Visibility = DockVisibility.Visible
                        If docRA_ITA.Controls.Count > 0 AndAlso TypeOf docRA_ITA.Controls(0) Is ucTaxCom_RAITA Then
                            Dim uc As ucTaxCom_RAITA = CType(docRA_ITA.Controls(0), ucTaxCom_RAITA)
                            uc.AdjustedIncome = AdjustedIncome
                            uc.Dock = DockStyle.Fill
                        End If
                        docRA_ITA.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docRA_ITA)
                    End If

                    DocumentManager1.View.ActivateDocument(docRA_ITA)
                Case EnumFormType.ExcessiveDiffencePenalty
                    If docExcessiveDiffencePenalty Is Nothing OrElse docExcessiveDiffencePenalty.IsDisposed Then
                        docExcessiveDiffencePenalty = New DockPanel
                        Dim uc As New ucTaxCom_ExcessiveDiffPenalty
                        uc.AdjustedIncome = AdjustedIncome
                        uc.Dock = DockStyle.Fill


                        docExcessiveDiffencePenalty.Text = Title
                        docExcessiveDiffencePenalty.Name = TaxComPNLEnuItem.SALES.ToString
                        docExcessiveDiffencePenalty.Controls.Add(uc)
                        docExcessiveDiffencePenalty.Register(DockManager1)
                        docExcessiveDiffencePenalty.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docExcessiveDiffencePenalty)
                    Else
                        docExcessiveDiffencePenalty.Visibility = DockVisibility.Visible
                        If docExcessiveDiffencePenalty.Controls.Count > 0 AndAlso TypeOf docExcessiveDiffencePenalty.Controls(0) Is ucTaxCom_ExcessiveDiffPenalty Then
                            Dim uc As ucTaxCom_ExcessiveDiffPenalty = CType(docExcessiveDiffencePenalty.Controls(0), ucTaxCom_ExcessiveDiffPenalty)
                            uc.AdjustedIncome = AdjustedIncome
                            uc.Dock = DockStyle.Fill
                        End If
                        docExcessiveDiffencePenalty.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docExcessiveDiffencePenalty)
                    End If

                    DocumentManager1.View.ActivateDocument(docExcessiveDiffencePenalty)
                Case EnumFormType.UnabsoredExportAllowance
                    If docUnabsoredExportAllowance Is Nothing OrElse docUnabsoredExportAllowance.IsDisposed Then
                        docUnabsoredExportAllowance = New DockPanel
                        Dim uc As New ucTaxCom_UnabsorbedExportAllowance
                        uc.AdjustedIncome = AdjustedIncome
                        uc.Dock = DockStyle.Fill


                        docUnabsoredExportAllowance.Text = Title
                        docUnabsoredExportAllowance.Name = TaxComPNLEnuItem.SALES.ToString
                        docUnabsoredExportAllowance.Controls.Add(uc)
                        docUnabsoredExportAllowance.Register(DockManager1)
                        docUnabsoredExportAllowance.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docUnabsoredExportAllowance)
                    Else
                        docUnabsoredExportAllowance.Visibility = DockVisibility.Visible
                        If docUnabsoredExportAllowance.Controls.Count > 0 AndAlso TypeOf docUnabsoredExportAllowance.Controls(0) Is ucTaxCom_UnabsorbedExportAllowance Then
                            Dim uc As ucTaxCom_UnabsorbedExportAllowance = CType(docUnabsoredExportAllowance.Controls(0), ucTaxCom_UnabsorbedExportAllowance)
                            uc.AdjustedIncome = AdjustedIncome
                            uc.Dock = DockStyle.Fill
                        End If
                        docUnabsoredExportAllowance.Dock = DockingStyle.Fill
                        doc = DocumentManager1.View.AddDocument(docUnabsoredExportAllowance)
                    End If

                    DocumentManager1.View.ActivateDocument(docUnabsoredExportAllowance)
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Statutory_Income_Click(sender As Object, e As EventArgs) Handles Statutory_Income.Click
        OpenDetail(EnumFormType.StatutoryIncome, Statutory_Income.Text)
    End Sub
    Private Sub Unabsorbed_Export_Allowance_Click(sender As Object, e As EventArgs) Handles Unabsorbed_Export_Allowance.Click
        OpenDetail(EnumFormType.UnabsoredExportAllowance, Unabsorbed_Export_Allowance.Text)
    End Sub
    Private Sub Excessive_Diff_Penantly_Click(sender As Object, e As EventArgs) Handles Excessive_Diff_Penantly.Click
        OpenDetail(EnumFormType.ExcessiveDiffencePenalty, Excessive_Diff_Penantly.Text)
    End Sub
    Private Sub RA_ITA_Click(sender As Object, e As EventArgs) Handles RA_ITA.Click
        OpenDetail(EnumFormType.RA_ITA, RA_ITA.Text)
    End Sub
    Private Sub Unabsorbed_Loss_Click(sender As Object, e As EventArgs) Handles Unabsorbed_Loss.Click
        OpenDetail(EnumFormType.UnabsordbedLoss, Unabsorbed_Loss.Text)
    End Sub
    Private Sub Computation_of_Unabsorbed_CA_Click(sender As Object, e As EventArgs) Handles Computation_of_Unabsorbed_CA.Click
        OpenDetail(EnumFormType.ComputationofUnabsorbedCA, Computation_of_Unabsorbed_CA.Text)
    End Sub
    Private Sub Income_Tax_Payable_2_Click(sender As Object, e As EventArgs) Handles Income_Tax_Payable_2.Click
        OpenDetail(EnumFormType.IncomeTaxPayable1, Income_Tax_Payable_1.Text)
    End Sub
    Private Sub Income_Tax_Payable_1_Click(sender As Object, e As EventArgs) Handles Income_Tax_Payable_1.Click
        OpenDetail(EnumFormType.IncomeTaxPayable2, Income_Tax_Payable_2.Text)
    End Sub
    Private Sub Non_Business_Income_Click(sender As Object, e As EventArgs) Handles Non_Business_Income.Click
        OpenDetail(EnumFormType.NonBusinessIncome, Non_Business_Income.Text)
    End Sub
#End Region

    Private Sub frmTaxComputation_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadData()
        Try
            If AdjustedIncome Is Nothing Then
                Exit Sub
            End If
            AdjustedIncome.RefNo = RefNo
            AdjustedIncome.YA = YA

        Catch ex As Exception

        End Try
    End Sub

    Private Sub AdjustedIncome_OnLoadTaxcom(dt_ As DataTable, dtTaxpayer_ As DataTable) Handles AdjustedIncome.OnLoadTaxcom
        Try
            If dt_ IsNot Nothing Then

                If dtTaxpayer_ IsNot Nothing Then

                    txtCompanyName.EditValue = IIf(IsDBNull(dtTaxpayer_.Rows(0)("TP_COM_NAME")), "", dtTaxpayer_.Rows(0)("TP_COM_NAME"))
                    txtRefNo.EditValue = RefNo
                    txtYA.EditValue = YA
                End If

                AccordionControl1.Enabled = True
            Else
                AccordionControl1.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class