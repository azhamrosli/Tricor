Imports System.Data.OleDb

Public Class ucPNL_Import
    Dim ErrorLog As clsError = Nothing
    Public Const MainTable As String = "ExportPNL" 'PLFST_SALES
    Public SourceNo As Integer = 0
    Dim MainDataSet As DataSet = Nothing
    Dim MainDataSet2 As DataSet = Nothing
    Public Property MainData() As DataSet
        Get
            Return MainDataSet
        End Get
        Set(ByVal value As DataSet)
            MainDataSet = value
        End Set
    End Property
    Public Property MainData2() As DataSet
        Get
            Return MainDataSet2
        End Get
        Set(ByVal value As DataSet)
            MainDataSet2 = value
        End Set
    End Property
    Private Sub Import_Data()
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

            MainDataSet2.Tables(MainTable).Rows.Clear()
            Dim loopx As Integer = -1
            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each rowx As DataRow In ds.Tables(0).Rows
                    loopx += 1
                    If loopx = 0 AndAlso chkisFirstRowHeader.Checked = True Then

                    Else
                        If IsDBNull(rowx(0)) = False AndAlso rowx(0).ToString <> "" Then
                            dtRow = MainDataSet2.Tables(MainTable).NewRow
                            dtRow("No") = rowx(0)
                            dtRow("No2") = rowx(1)
                            dtRow("Type") = rowx(2)
                            dtRow("Description") = rowx(3)
                            dtRow("LeftAmount") = rowx(4)
                            dtRow("RightAmount") = rowx(5)
                            MainDataSet2.Tables(MainTable).Rows.Add(dtRow)
                        End If
                    End If
                    
                Next
            End If

            ExportPNLBindingSource.DataSource = MainDataSet2.Tables(MainTable)
            ds = Nothing
        Catch ex As Exception

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

        End Try
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TransferSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferSelectedToolStripMenuItem.Click
        Try

            Dim dtRow As DataRow = Nothing
            Dim Type As mdlEnum.TaxComPNLEnuItem = TaxComPNLEnuItem.CLOSESTOCK

            Dim contrl As Control = Nothing
            Dim dsControl As DataSet = Nothing
            Dim TableName As String = ""
            For Each i As Integer In GridView1.GetSelectedRows

                dtRow = GridView1.GetDataRow(i)

                If dtRow IsNot Nothing Then
                    Type = DirectCast([Enum].Parse(GetType(mdlEnum.TaxComPNLEnuItem), dtRow("Type")), mdlEnum.TaxComPNLEnuItem)

                    Select Case Type
                        Case TaxComPNLEnuItem.SALES
                            TableName = ucPNL_p1Sales.MainTable


                    End Select

                    If mdlPNL2.TransferFromImport_ToMain(MainDataSet, MainDataSet2, dtRow, TableName, Type, SourceNo, ErrorLog) Then
                        GridView1.DeleteRow(i)
                    Else
                        MsgBox("Failed to transfer to main table." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                        Exit For
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TransferAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferAllToolStripMenuItem.Click
        Try
            Dim dtRow As DataRow = Nothing
            Dim Type As mdlEnum.TaxComPNLEnuItem = TaxComPNLEnuItem.CLOSESTOCK

            Dim contrl As Control = Nothing
            Dim dsControl As DataSet = Nothing
            Dim TableName As String = ""
            Dim ListofRow As New List(Of DataRow)

            For i As Integer = 0 To dsDataSet2.Tables(Me.MainTable).Rows.Count - 1
                dtRow = dsDataSet2.Tables(Me.MainTable).Rows(i)

                If dtRow IsNot Nothing AndAlso IsDBNull(dtRow("No")) = False Then

                    Type = DirectCast([Enum].Parse(GetType(mdlEnum.TaxComPNLEnuItem), dtRow("Type")), mdlEnum.TaxComPNLEnuItem)

                    Select Case Type
                        Case TaxComPNLEnuItem.SALES
                            TableName = ucPNL_p1Sales.MainTable


                    End Select

                    If mdlPNL2.TransferFromImport_ToMain(MainDataSet, MainDataSet2, dtRow, TableName, Type, SourceNo, ErrorLog) Then
                        '  GridView1.DeleteRow(i)
                        ListofRow.Add(dtRow)


                        ' dsDataSet2.Tables(Me.MainTable).Rows(i).Delete()
                    Else
                        MsgBox("Failed to transfer to main table.", MsgBoxStyle.Critical)
                        Exit For
                    End If
                End If
            Next


            For i As Integer = 0 To ListofRow.Count - 1
                'x = -1
                'For Each rowx As DataRow In dsDataSet2.Tables(Me.MainTable).Rows
                '    x += 1
                '    If IsDBNull(rowx("No")) = False AndAlso rowx("No") = ListofRow(i) Then
                '        dsDataSet2.Tables(Me.MainTable).Rows(x).Delete()

                '    End If
                'Next

                'For x As Integer = 0 To (dsDataSet2.Tables(Me.MainTable).Rows.Count - 1)
                '    If IsDBNull(dsDataSet2.Tables(Me.MainTable).Rows(x)("No")) = False AndAlso dsDataSet2.Tables(Me.MainTable).Rows(x)("No") = ListofRow(i) Then


                '    End If

                'Next
                dsDataSet2.Tables(Me.MainTable).Rows.Remove(ListofRow(i))
            Next
            ' dsDataSet2.Tables(Me.MainTable).AcceptChanges()

            MsgBox("Successfully Import to main table.", MsgBoxStyle.Information)

            'dsDataSet2.Tables(Me.MainTable).AcceptChanges()
            'Application.DoEvents()

            'ExportPNLBindingSource.DataSource = dsDataSet2.Tables(Me.MainTable)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OpenNormalTemplateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenNormalTemplateToolStripMenuItem.Click
        Try
            btnOpenFile.PerformClick()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OpenYGLECorpTemplateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenYGLECorpTemplateToolStripMenuItem.Click
        Try
            btnOpenFileYGL.PerformClick()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TransferToManual(ByVal Type As mdlEnum.TaxComPNLEnuItem)
        Try
            Try
                Dim dtRow As DataRow = Nothing

                Dim contrl As Control = Nothing
                Dim dsControl As DataSet = Nothing
                Dim TableName As String = ""
                For Each i As Integer In GridView1.GetSelectedRows

                    dtRow = GridView1.GetDataRow(i)

                    If dtRow IsNot Nothing Then
                       
                        Select Case Type
                            Case TaxComPNLEnuItem.SALES
                                TableName = ucPNL_p1Sales.MainTable


                        End Select

                        If mdlPNL2.TransferFromImport_ToMain(MainDataSet, MainDataSet2, dtRow, TableName, Type, SourceNo, ErrorLog) Then
                            GridView1.DeleteRow(i)
                        Else
                            MsgBox("Failed to transfer to main table." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                            Exit For
                        End If
                    End If
                Next
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
    End Sub
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
