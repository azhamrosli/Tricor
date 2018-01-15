Public Class frmDisposal_Add 
    Inherits DevExpress.XtraEditors.XtraForm
    Dim ErrorLog As clsError = Nothing
    Public isEdit As Boolean = False
    Public ID As Integer = 0
    Public ID_CA As Integer = 0
    Public isFromCA As Boolean = False
    Dim dtRowSelected As DataRow
    Dim isSumofDigit As Boolean = True
    Dim isFirstTimeLoad As Boolean = True
    Dim boolDuplicateDisposal As Boolean

    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        If My.Settings.ThemeName <> "" Then
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = My.Settings.ThemeName
        Else
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "DevExpress Dark Style" ' "Office 2013"
        End If
        InitializeComponent()
    End Sub
    Private Sub frmHP_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Try
            cboSearchFor.SelectedIndex = 0

            If mdlProcess.CreateLookUpTaxPayer(DsCA, ErrorLog) = False Then
                MsgBox("Unable to retrive tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If mdlProcess.CreateLookUpYA(cboYA, ErrorLog) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If mdlProcess.CreateLookUpCategory(DsCA, ErrorLog) = False Then
                MsgBox("Unable to retrive category.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If mdlProcess.ArgParam3 <> "" AndAlso IsNumeric(mdlProcess.ArgParam3) Then
                For i As Integer = 0 To cboYA.Properties.Items.Count - 1
                    If CInt(cboYA.Properties.Items(i)) = CInt(mdlProcess.ArgParam3) Then
                        cboYA.SelectedIndex = i
                        Exit For
                    End If
                Next
                Application.DoEvents()
            Else
                cboYA.SelectedIndex = 0
            End If

            Application.DoEvents()

            If mdlProcess.ArgParam2 <> "" Then
                cboRefNo.EditValue = mdlProcess.ArgParam2
                DefaultTaxPayer(cboRefNo)
            End If


            If isEdit Then
                'select 1st ca
                'load disposal
                Dim dt As DataTable = mdlProcess.Load_DISPOSAL_BY_CADISP_KEY(ID_CA, ID)
                Dim dtCA As DataTable = mdlProcess.Load_CA(ID_CA, ErrorLog)


                If dt Is Nothing OrElse dtCA Is Nothing Then
                    isEdit = False
                    Exit Sub
                End If

                cboRefNo.EditValue = IIf(IsDBNull(dtCA.Rows(0)("CA_REF_NO")), "", dtCA.Rows(0)("CA_REF_NO"))
                Dim tmpYA As Integer = IIf(IsDBNull(dt.Rows(0)("CA_DISP_YA")), 0, dt.Rows(0)("CA_DISP_YA"))

                For i As Integer = 0 To cboYA.Properties.Items.Count - 1
                    If CInt(cboYA.Properties.Items(i)) = tmpYA Then
                        cboYA.SelectedIndex = i
                        Exit For
                    End If
                Next
                Application.DoEvents()
                DefaultTaxPayer(cboRefNo)
                Application.DoEvents()

                txtAsset.EditValue = IIf(IsDBNull(dtCA.Rows(0)("CA_ASSET")), "", dtCA.Rows(0)("CA_ASSET"))
                txtAssetID.EditValue = IIf(IsDBNull(dtCA.Rows(0)("CA_ASSET_CODE")), "", dtCA.Rows(0)("CA_ASSET_CODE"))
                cboCategory.EditValue = IIf(IsDBNull(dtCA.Rows(0)("CA_CATEGORY_CODE")), "", dtCA.Rows(0)("CA_CATEGORY_CODE"))
                dtDateofPurchase.EditValue = IIf(IsDBNull(dtCA.Rows(0)("CA_PURCHASE_DATE")), Now, dtCA.Rows(0)("CA_PURCHASE_DATE"))
                txtPurchaseAmountFA.EditValue = IIf(IsDBNull(dtCA.Rows(0)("CA_PURCHASE_AMOUNT")), 0, dtCA.Rows(0)("CA_PURCHASE_AMOUNT"))
                txtDeposit.EditValue = IIf(IsDBNull(dtCA.Rows(0)("CA_PAYMENT")), 0, dtCA.Rows(0)("CA_PAYMENT"))
                txtRestrictedQua.EditValue = IIf(IsDBNull(dtCA.Rows(0)("CA_RESTRICTED_QC")), 0, dtCA.Rows(0)("CA_RESTRICTED_QC"))
                txtHP_Code.EditValue = IIf(IsDBNull(dtCA.Rows(0)("HP_CODE")), "", dtCA.Rows(0)("HP_CODE"))
                txtDescription.EditValue = IIf(IsDBNull(dtCA.Rows(0)("CA_DESC")), 0, dtCA.Rows(0)("CA_DESC"))
                Application.DoEvents()
                txtTotal_QC.EditValue = Load_GetTotalCA(txtHP_Code.EditValue)

                txtIA.EditValue = IIf(IsDBNull(dtCA.Rows(0)("CA_RATE_IA")), 0, dtCA.Rows(0)("CA_RATE_IA"))
                cboAA.EditValue = IIf(IsDBNull(dtCA.Rows(0)("CA_RATE_AA")), 0, dtCA.Rows(0)("CA_RATE_AA"))
                cboIncentive.EditValue = IIf(IsDBNull(dtCA.Rows(0)("CA_INCENTIVE")), 0, dtCA.Rows(0)("CA_INCENTIVE"))
                txtQualifyingCost.EditValue = IIf(IsDBNull(dtCA.Rows(0)("CA_QUALIFYING_COST")), 0, dtCA.Rows(0)("CA_QUALIFYING_COST"))
                txtRemainingQualifyingCost.EditValue = IIf(IsDBNull(dtCA.Rows(0)("CA_REMAIN_QC")), 0, dtCA.Rows(0)("CA_REMAIN_QC"))
                txtTWDV.EditValue = IIf(IsDBNull(dtCA.Rows(0)("CA_TWDV")), 0, dtCA.Rows(0)("CA_TWDV"))
                cboIncentive.EditValue = IIf(IsDBNull(dtCA.Rows(0)("CA_INCENTIVE")), "", dtCA.Rows(0)("CA_INCENTIVE"))
                txtTWDV.EditValue = IIf(IsDBNull(dtCA.Rows(0)("CA_TWDV")), 0, dtCA.Rows(0)("CA_TWDV"))

                If IsDBNull(dtCA.Rows(0)("CA_CTRL_TRANSFER")) = False AndAlso dtCA.Rows(0)("CA_CTRL_TRANSFER").ToString <> -1 Then
                    chkControlTransfer.Checked = True
                Else
                    chkControlTransfer.Checked = False
                End If

                Application.DoEvents()
                cboTypeDisposal.SelectedIndex = IIf(IsDBNull(dt.Rows(0)("CA_DISP_TYPE")), 0, dt.Rows(0)("CA_DISP_TYPE"))

                dtDisposal.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_DISP_DATE")), Now, dt.Rows(0)("CA_DISP_DATE"))
                txtDisposal_PurchaseAmount.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_DISP_AMOUNT")), 0, dt.Rows(0)("CA_DISP_AMOUNT"))
                txtDispose_QC.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_DISP_QC")), 0, dt.Rows(0)("CA_DISP_QC"))
                txtDisposal_TWDV.EditValue = Calc_TWDV(dtCA.Rows(0))
                txtDisposal_SalesProceed.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_DISP_SPROCEED")), 0, dt.Rows(0)("CA_DISP_SPROCEED"))
                Application.DoEvents()

                If DateDiff(DateInterval.Year, dtDateofPurchase.EditValue, dtDisposal.EditValue) <= 2 Then
                    rgWithIn2YA.SelectedIndex = 0
                Else
                    rgWithIn2YA.SelectedIndex = 1
                End If



                txtDisposal_BABC.EditValue = CalculateBABC(IIf(chkControlTransfer.Checked, "True", "False"), txtHP_Code.EditValue, txtDisposal_PurchaseAmount.EditValue, txtDispose_QC.EditValue, _
                                                    txtDisposal_TWDV.EditValue, txtDisposal_SalesProceed.EditValue, IIf(rgWithIn2YA.SelectedIndex = 0, True, False))

                dtRowSelected = dtCA.Rows(0)
            Else
                cboYA.EditValue = mdlProcess.ArgParam3
                If isFromCA Then
                    Dim dtCA As DataTable = mdlProcess.Load_CA(ID_CA, ErrorLog)

                    dtRowSelected = dtCA.Rows(0)

                    txtSearchVal.Text = ID_CA
                    cboSearchFor.SelectedIndex = 6
                    Application.DoEvents()
                    Load_CA()


                    txtAsset.EditValue = IIf(IsDBNull(dtRowSelected("CA_ASSET")), "", dtRowSelected("CA_ASSET"))
                    txtAssetID.EditValue = IIf(IsDBNull(dtRowSelected("CA_ASSET_CODE")), "", dtRowSelected("CA_ASSET_CODE"))
                    cboCategory.EditValue = IIf(IsDBNull(dtRowSelected("CA_CATEGORY_CODE")), "", dtRowSelected("CA_CATEGORY_CODE"))
                    dtDateofPurchase.EditValue = IIf(IsDBNull(dtRowSelected("CA_PURCHASE_DATE")), Now, dtRowSelected("CA_PURCHASE_DATE"))
                    txtPurchaseAmountFA.EditValue = IIf(IsDBNull(dtRowSelected("CA_PURCHASE_AMOUNT")), 0, dtRowSelected("CA_PURCHASE_AMOUNT"))
                    txtDeposit.EditValue = IIf(IsDBNull(dtRowSelected("CA_PAYMENT")), 0, dtRowSelected("CA_PAYMENT"))
                    txtRestrictedQua.EditValue = IIf(IsDBNull(dtRowSelected("CA_RESTRICTED_QC")), 0, dtRowSelected("CA_RESTRICTED_QC"))
                    txtHP_Code.EditValue = IIf(IsDBNull(dtRowSelected("HP_CODE")), "", dtRowSelected("HP_CODE"))
                    txtDescription.EditValue = IIf(IsDBNull(dtRowSelected("CA_DESC")), 0, dtRowSelected("CA_DESC"))
                    Application.DoEvents()
                    txtTotal_QC.EditValue = Load_GetTotalCA(txtHP_Code.EditValue)

                    txtIA.EditValue = IIf(IsDBNull(dtRowSelected("CA_RATE_IA")), 0, dtRowSelected("CA_RATE_IA"))
                    cboAA.EditValue = IIf(IsDBNull(dtRowSelected("CA_RATE_AA")), 0, dtRowSelected("CA_RATE_AA"))
                    cboIncentive.EditValue = IIf(IsDBNull(dtRowSelected("CA_INCENTIVE")), 0, dtRowSelected("CA_INCENTIVE"))
                    txtQualifyingCost.EditValue = IIf(IsDBNull(dtRowSelected("CA_QUALIFYING_COST")), 0, dtRowSelected("CA_QUALIFYING_COST"))
                    txtRemainingQualifyingCost.EditValue = IIf(IsDBNull(dtRowSelected("CA_REMAIN_QC")), 0, dtRowSelected("CA_REMAIN_QC"))
                    txtTWDV.EditValue = IIf(IsDBNull(dtRowSelected("CA_TWDV")), 0, dtRowSelected("CA_TWDV"))
                    cboIncentive.EditValue = IIf(IsDBNull(dtRowSelected("CA_INCENTIVE")), "", dtRowSelected("CA_INCENTIVE"))
                    txtTWDV.EditValue = IIf(IsDBNull(dtRowSelected("CA_TWDV")), 0, dtRowSelected("CA_TWDV"))

                    If IsDBNull(dtRowSelected("CA_CTRL_TRANSFER")) = False AndAlso dtRowSelected("CA_CTRL_TRANSFER").ToString <> -1 Then
                        chkControlTransfer.Checked = True
                    Else
                        chkControlTransfer.Checked = False
                    End If
                    Application.DoEvents()
                    cboTypeDisposal.SelectedIndex = 0

                    dtDisposal.EditValue = Now
                    txtDisposal_PurchaseAmount.EditValue = txtPurchaseAmountFA.EditValue
                    txtDispose_QC.EditValue = txtPurchaseAmountFA.EditValue
                    txtDisposal_TWDV.EditValue = Calc_TWDV(dtRowSelected)
                    txtDisposal_SalesProceed.EditValue = 0
                    Application.DoEvents()

                    txtDisposal_BABC.EditValue = CalculateBABC(IIf(chkControlTransfer.Checked, "True", "False"), txtHP_Code.EditValue, txtDisposal_PurchaseAmount.EditValue, txtDisposal_RemainingQuaCost.EditValue, _
                                                        txtDisposal_TWDV.EditValue, txtDisposal_SalesProceed.EditValue, IIf(rgWithIn2YA.SelectedIndex = 0, True, False))


                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DefaultTaxPayer(ByVal sender As Object)
        Try
            If cboRefNo.EditValue.ToString <> "" Then

                Dim editor As DevExpress.XtraEditors.SearchLookUpEdit = CType(sender, DevExpress.XtraEditors.SearchLookUpEdit)
                Dim row As DataRowView = CType(editor.Properties.GetRowByKeyValue(editor.EditValue), DataRowView)
                Dim value As Object = row("CompanyName")
                txtTaxPayer.EditValue = value.ToString
                txtFileNo.EditValue = row("FileNo").ToString
                txtCompanyCode.EditValue = row("CompanyCode").ToString

                If mdlProcess.CreateLookUpSourceNo(cboSourceCode, cboRefNo.EditValue.ToString, cboYA.EditValue.ToString, ErrorLog) = False Then
                    cboSourceCode.EditValue = ""
                    Exit Sub
                Else
                    cboSourceCode.SelectedIndex = 0
                End If

                Load_CA()
            End If

        Catch ex As Exception

        Finally
            ShowMainCA()
        End Try
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Load_CA()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Load_CA()
        Try
            If cboRefNo.EditValue.ToString <> "" Then

                Dim dt As DataTable = mdlProcess.Load_Disposal_CA(cboRefNo.EditValue, cboYA.EditValue, cboSearchFor.SelectedIndex, txtSearchVal.EditValue)

                DsCA.Tables("CA").Rows.Clear()
                If dt IsNot Nothing Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        DsCA.Tables("CA").ImportRow(dt.Rows(i))
                    Next
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ShowMainCA()
        Try
            If txtTaxPayer.Text = "" Then
                DockPanel3.Enabled = False
                Exit Sub
            End If

            DockPanel3.Enabled = True

        Catch ex As Exception

        End Try
    End Sub
    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        DefaultTaxPayer(sender)
    End Sub
    Private Sub Save_Disposal()
        Try
            Try
                If isValid() Then
                    Dim ReturnID As Integer = 0
                    'Dim tmpDtRows As DataRow = GridView1.GetDataRow(GridView1.GetSelectedRows(0))

                    Dim HP_CODE As String = ""
                    If dtRowSelected IsNot Nothing Then
                        HP_CODE = IIf(IsDBNull(dtRowSelected("HP_CODE")), "", dtRowSelected("HP_CODE"))
                    End If


                    If Not String.IsNullOrEmpty(HP_CODE) And CInt(mdlProcess.Load_HP_Count(HP_CODE, ErrorLog)) > 1 Then
                        Dim rslt As DialogResult = MessageBox.Show("More than one CA record has been found under this HP Code." & vbCrLf & "Do you want to duplicate the disposal among these items?", "Disposal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                        If rslt = Windows.Forms.DialogResult.Yes Then
                            boolDuplicateDisposal = True
                        Else
                            boolDuplicateDisposal = False
                        End If
                    Else
                        boolDuplicateDisposal = False
                    End If

                    If boolDuplicateDisposal AndAlso isEdit = False Then
                        Dim intMaxYear As Integer = mdlProcess.LOAD_GetLatestCAYear(HP_CODE)

                        If intMaxYear > 0 AndAlso intMaxYear <= CInt(cboYA.EditValue) Then
                            Dim dtCA As DataTable = mdlProcess.LOAD_GetCAByHPCode(HP_CODE)
                            Dim dblRemainingQC As Double = 0
                            Dim REMAINING_QC As Decimal = 0
                            Dim CA_KEY As Integer = 0
                            Dim CA_Qua_Cost As Decimal = 0
                            Dim TWDV As Decimal = 0
                            Dim BABC As Decimal = 0
                            Dim CA_DISP_YA As Integer = 0
                            Dim DISPOSEQC As Decimal = 0
                            Dim DISPOSEAMOUNT As Decimal = 0
                            Dim SALESPROCEED As Decimal = 0
                            For i As Integer = 0 To dtCA.Rows.Count - 1
                                CA_KEY = IIf(IsDBNull(dtCA.Rows(i)("ca_key")), 0, dtCA.Rows(i)("ca_key"))
                                CA_Qua_Cost = IIf(IsDBNull(dtCA.Rows(i)("ca_qualifying_cost")), 0, dtCA.Rows(i)("ca_qualifying_cost"))
                                dblRemainingQC = CDbl(CA_Qua_Cost) - CDbl(mdlProcess.LOAD_GetTotalDisposedCA(CA_KEY))

                                If dblRemainingQC > 0 Then
                                    TWDV = Calc_TWDV(dtCA.Rows(i))

                                    CA_DISP_YA = IIf(IsDBNull(dtCA.Rows(i)("ca_qualifying_cost")), 0, dtCA.Rows(i)("ca_qualifying_cost"))
                                    SALESPROCEED = IIf(IsDBNull(dtCA.Rows(i)("ca_qualifying_cost")), 0, dtCA.Rows(i)("ca_qualifying_cost"))

                                    If CA_KEY <> dtRowSelected("CA_KEY") Then
                                        DISPOSEQC = CDec(dblRemainingQC)
                                        DISPOSEAMOUNT = IIf(IsDBNull(dtCA.Rows(i)("ca_purchase_amount")), 0, dtCA.Rows(i)("ca_purchase_amount"))
                                    Else
                                        DISPOSEQC = CDec(txtDispose_QC.EditValue)
                                        DISPOSEAMOUNT = CDec(txtDisposal_PurchaseAmount.EditValue)
                                    End If

                                    '  dicInsVal2.Add("txtRemainQC", dblRemainingQC - CDbl(dicInsVal2("txtDisposeQC")))
                                    REMAINING_QC = dblRemainingQC - CDec(txtDispose_QC.EditValue)

                                    BABC = CalculateBABC(chkControlTransfer.Checked.ToString, txtHP_Code.EditValue, txtDisposal_PurchaseAmount.EditValue, txtDispose_QC.EditValue, TWDV, txtDisposal_SalesProceed.EditValue, IIf(rgWithIn2YA.SelectedIndex = 0, True, False))

                                    If mdlProcess.Save_Disposal(CA_KEY, LOAD_GetDISPKey(CA_KEY), cboYA.EditValue, dtDisposal.EditValue, _
                                                                IIf(rgWithIn2YA.SelectedIndex = 0, True, False), DISPOSEAMOUNT, DISPOSEQC, _
                                                                REMAINING_QC, TWDV, txtDisposal_SalesProceed.EditValue, BABC, txtDisposal_Remarks.EditValue, _
                                                                txtAccumulated.EditValue, txtTransfereeName.EditValue, txtTaxFileNumber.EditValue, cboTypeDisposal.EditValue, ReturnID, ErrorLog) = False Then
                                        MsgBox("Failed to save disposal." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                                        Exit Sub
                                    End If

                                    If mdlProcess.Update_UpdateRemainingQC(CA_KEY, REMAINING_QC, "CA", ErrorLog) = False Then
                                        MsgBox("Failed to update remaining QC -CA." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                                        Exit Sub
                                    End If

                                    If mdlProcess.LOAD_GetDISPRecordCount(CA_KEY) > 1 Then
                                        If mdlProcess.Update_UpdateRemainingQC(CA_KEY, REMAINING_QC, "DISP", ErrorLog) = False Then
                                            MsgBox("Failed to update remaining QC -DISP." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                                            Exit Sub
                                        End If
                                    End If

                                End If

                            Next
                        Else
                            If intMaxYear > 0 Then
                                MsgBox("One of the Year of Assessment in CA record is later than the year of disposal." + (Chr(13)) + "Duplicate disposal is aborted, no record has been saved.", MsgBoxStyle.Information, "Taxcom CA")
                            Else
                                MsgBox("No CA record found." + (Chr(13)) + "Duplicate disposal is aborted, no record has been saved.", MsgBoxStyle.Information, "Taxcom CA")
                            End If
                            Exit Sub
                        End If
                    Else
                        Dim DispKey As Integer = mdlProcess.LOAD_GetDISPKey(IIf(IsDBNull(dtRowSelected("ca_key")), 0, dtRowSelected("ca_key")))
                        Dim CA_KEY As Integer = IIf(IsDBNull(dtRowSelected("ca_key")), 0, dtRowSelected("ca_key"))

                        If isEdit Then
                            If mdlProcess.Update_Disposal(ID, CA_KEY, cboYA.EditValue, dtDisposal.EditValue, _
                                                        IIf(rgWithIn2YA.SelectedIndex = 0, True, False), txtDisposal_PurchaseAmount.EditValue, txtDispose_QC.EditValue, txtDisposal_RemainingQuaCost.EditValue, _
                                                        txtDisposal_TWDV.EditValue, txtDisposal_SalesProceed.EditValue, txtDisposal_BABC.EditValue, txtDisposal_Remarks.EditValue, txtAccumulated.EditValue, _
                                                        txtTransfereeName.EditValue, txtTaxFileNumber.EditValue, cboTypeDisposal.SelectedIndex, 0, ErrorLog) = False Then
                                MsgBox("Failed to update disposal." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                                Exit Sub
                            End If
                        Else

                            If mdlProcess.Save_Disposal(CA_KEY, DispKey, cboYA.EditValue, dtDisposal.EditValue, _
                                                        IIf(rgWithIn2YA.SelectedIndex = 0, True, False), txtDisposal_PurchaseAmount.EditValue, txtDispose_QC.EditValue, txtDisposal_RemainingQuaCost.EditValue, _
                                                        txtDisposal_TWDV.EditValue, txtDisposal_SalesProceed.EditValue, txtDisposal_BABC.EditValue, txtDisposal_Remarks.EditValue, txtAccumulated.EditValue, _
                                                        txtTransfereeName.EditValue, txtTaxFileNumber.EditValue, cboTypeDisposal.SelectedIndex, 0, ErrorLog) = False Then
                                MsgBox("Failed to save disposal." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                                Exit Sub
                            Else
                                ID = DispKey
                                isEdit = True
                            End If
                        End If


                        If mdlProcess.Update_UpdateRemainingQC(CA_KEY, txtDisposal_RemainingQuaCost.EditValue, "CA", ErrorLog) = False Then
                            MsgBox("Failed to update remaining QC -CA." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                            Exit Sub
                        End If

                        If mdlProcess.LOAD_GetDISPRecordCount(CA_KEY) > 1 Then
                            If mdlProcess.Update_UpdateRemainingQC(CA_KEY, txtDisposal_RemainingQuaCost.EditValue, "DISP", ErrorLog) = False Then
                                MsgBox("Failed to update remaining QC -DISP." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                                Exit Sub
                            End If
                        End If

                        If mdlCA.RefreshCA(cboRefNo.EditValue, cboYA.EditValue, ErrorLog) = False Then
                            MsgBox("Failed to refresh capital allowance." & vbCrLf & ErrorLog.ErrorName & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                            Exit Sub
                        End If
                    End If

                    MsgBox("Succesfully save disposal.", MsgBoxStyle.Information)
                End If

            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
    End Sub
    Private Function isValid() As Boolean
        Try
            If txtAsset.EditValue.ToString = "" Then
                MsgBox("Please select an asset!", MsgBoxStyle.Exclamation)
                Return False
            End If

            If mdlProcess.LOAD_VerifySourceCode(cboRefNo.EditValue, cboYA.EditValue, cboSourceCode.EditValue) = False Then
                MsgBox("Source Code not exists under selected Year Assessment!", MsgBoxStyle.Exclamation)
                Return False
            End If

            If CDate(dtDisposal.EditValue) < CDate(dtDateofPurchase.EditValue) Then
                MsgBox("Disposal Date must not earlier than Purchase Date!", MsgBoxStyle.Exclamation, "Taxcom CA")
                Return False
            End If

            If String.IsNullOrEmpty(txtDisposal_PurchaseAmount.EditValue) Then
                MsgBox("Disposal Amount expected!", MsgBoxStyle.Exclamation, "Taxcom CA")
                Return False
            End If

            If CDec(txtDisposal_PurchaseAmount.EditValue) > CDec(txtPurchaseAmountFA.EditValue) Then
                MsgBox("Disposal Amount must not exceed asset Purchase Amount!", MsgBoxStyle.Exclamation, "Taxcom CA")
                Return False
            End If

            If String.IsNullOrEmpty(txtDispose_QC.EditValue) Then
                MsgBox("Disposal Qualifying Cost expected!", MsgBoxStyle.Exclamation, "Taxcom CA")
                Return False
            End If

            If String.IsNullOrEmpty(txtDisposal_TWDV.EditValue) Then
                MsgBox("TWDV expected!", MsgBoxStyle.Exclamation, "Taxcom CA")
                Return False
            End If

            If String.IsNullOrEmpty(txtDisposal_SalesProceed.EditValue) Then
                MsgBox("Sales proceed expected!", MsgBoxStyle.Exclamation, "Taxcom CA")
                Return False
            End If

            If String.IsNullOrEmpty(txtDisposal_BABC.EditValue) Then
                MsgBox("Balancing Charges expected!", MsgBoxStyle.Exclamation, "Taxcom CA")
                Return False
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function
    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Try

            Dim dtrow As DataRow = GridView1.GetDataRow(GridView1.GetSelectedRows(0))

            If dtrow IsNot Nothing Then

                txtAsset.EditValue = IIf(IsDBNull(dtrow("CA_ASSET")), "", dtrow("CA_ASSET"))
                txtAssetID.EditValue = IIf(IsDBNull(dtrow("CA_ASSET_CODE")), "", dtrow("CA_ASSET_CODE"))
                cboCategory.EditValue = IIf(IsDBNull(dtrow("CA_CATEGORY_CODE")), "", dtrow("CA_CATEGORY_CODE"))
                dtDateofPurchase.EditValue = IIf(IsDBNull(dtrow("CA_PURCHASE_DATE")), Now, dtrow("CA_PURCHASE_DATE"))
                txtPurchaseAmountFA.EditValue = IIf(IsDBNull(dtrow("CA_PURCHASE_AMOUNT")), 0, dtrow("CA_PURCHASE_AMOUNT"))
                txtDeposit.EditValue = IIf(IsDBNull(dtrow("CA_PAYMENT")), 0, dtrow("CA_PAYMENT"))
                txtRestrictedQua.EditValue = IIf(IsDBNull(dtrow("CA_RESTRICTED_QC")), 0, dtrow("CA_RESTRICTED_QC"))
                txtHP_Code.EditValue = IIf(IsDBNull(dtrow("HP_CODE")), "", dtrow("HP_CODE"))
                txtDescription.EditValue = IIf(IsDBNull(dtrow("CA_DESC")), 0, dtrow("CA_DESC"))
                Application.DoEvents()
                txtTotal_QC.EditValue = Load_GetTotalCA(txtHP_Code.EditValue)

                txtIA.EditValue = IIf(IsDBNull(dtrow("CA_RATE_IA")), 0, dtrow("CA_RATE_IA"))
                cboAA.EditValue = IIf(IsDBNull(dtrow("CA_RATE_AA")), 0, dtrow("CA_RATE_AA"))
                cboIncentive.EditValue = IIf(IsDBNull(dtrow("CA_INCENTIVE")), 0, dtrow("CA_INCENTIVE"))
                txtQualifyingCost.EditValue = IIf(IsDBNull(dtrow("CA_QUALIFYING_COST")), 0, dtrow("CA_QUALIFYING_COST"))
                txtRemainingQualifyingCost.EditValue = IIf(IsDBNull(dtrow("CA_REMAIN_QC")), 0, dtrow("CA_REMAIN_QC"))
                txtTWDV.EditValue = IIf(IsDBNull(dtrow("CA_TWDV")), 0, dtrow("CA_TWDV"))
                cboIncentive.EditValue = IIf(IsDBNull(dtrow("CA_INCENTIVE")), "", dtrow("CA_INCENTIVE"))
                txtTWDV.EditValue = IIf(IsDBNull(dtrow("CA_TWDV")), 0, dtrow("CA_TWDV"))

                If IsDBNull(dtrow("CA_CTRL_TRANSFER")) = False AndAlso dtrow("CA_CTRL_TRANSFER").ToString <> -1 Then
                    chkControlTransfer.Checked = True
                Else
                    chkControlTransfer.Checked = False
                End If
                Application.DoEvents()
                cboTypeDisposal.SelectedIndex = 0

                dtDisposal.EditValue = Now
                txtDisposal_PurchaseAmount.EditValue = txtPurchaseAmountFA.EditValue
                txtDispose_QC.EditValue = txtPurchaseAmountFA.EditValue
                txtDisposal_TWDV.EditValue = Calc_TWDV(dtrow)
                txtDisposal_SalesProceed.EditValue = 0
                Application.DoEvents()

                txtDisposal_BABC.EditValue = CalculateBABC(IIf(chkControlTransfer.Checked, "True", "False"), txtHP_Code.EditValue, txtDisposal_PurchaseAmount.EditValue, txtDispose_QC.EditValue, _
                                                    txtDisposal_TWDV.EditValue, txtDisposal_SalesProceed.EditValue, IIf(rgWithIn2YA.SelectedIndex = 0, True, False))

                dtRowSelected = dtrow
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Function Calc_TWDV(ByVal dtRow As DataRow) As Decimal
        Try
            Dim dblTotalTWDV As Double
            Dim CA_TWDV As Decimal

            Select Case dtRow("CA_MODE")
                Case "OPN"
                    If CDbl(cboYA.EditValue) > CDbl(dtRow("CA_YA")) Then
                        dblTotalTWDV = CDbl(dtRow("CA_TWDV")) - ((CDbl(cboYA.EditValue) - CDbl(dtRow("CA_YA"))) * FormatNumber((CDbl(dtRow("CA_RATE_AA")) * CDbl(dtRow("CA_QUALIFYING_COST")) / 100), 2))
                    Else
                        dblTotalTWDV = dtRow("CA_TWDV")
                    End If
                Case "ADD"
                    If CDbl(cboYA.EditValue) > CDbl(dtRow("CA_YA")) Then
                        dblTotalTWDV = FormatNumber(CDbl(dtRow("CA_TWDV")) - (FormatNumber((CDbl(dtRow("CA_RATE_IA")) * CDbl(dtRow("CA_QUALIFYING_COST")) / 100), 2) + ((CDbl(cboYA.EditValue) - CDbl(dtRow("CA_YA"))) * FormatNumber((CDbl(dtRow("CA_RATE_AA")) * CDbl(dtRow("CA_QUALIFYING_COST")) / 100), 2))))
                    Else
                        dblTotalTWDV = dtRow("CA_TWDV")
                    End If
            End Select

            If CDbl(txtDispose_QC.EditValue) = CDbl(dtRow("CA_QUALIFYING_COST")) Then
                CA_TWDV = FormatNumber(dblTotalTWDV)
            Else
                CA_TWDV = FormatNumber(CDbl(txtDispose_QC.EditValue) / CDbl(dtRow("CA_QUALIFYING_COST")) * dblTotalTWDV)
            End If

            If CDbl(CA_TWDV) < 0 Then
                CA_TWDV = 0
            End If



            Return CA_TWDV
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Private Function CalculateBABC(ByVal strControlTransfer As String, ByVal HP_CODE As String, ByVal txtDisposeAmount As String, _
                                   ByVal txtDisposeQC As String, ByVal txtTWDV As String, ByVal txtSalesProceed As String, _
                                   ByVal boolWithin2 As Boolean) As Decimal
        Try
            If cboTypeDisposal.SelectedIndex = 2 Then
                'Control Transfer Out
                Return 0
            End If

            If boolWithin2 = True Then
                Return CDec(CDbl(txtDisposeQC) - CDbl(txtTWDV))
            Else
                Dim dblSalesProceed As Double

                If CDbl(txtDisposeAmount) <> CDbl(txtDisposeQC) Then
                    If CDbl(txtDisposeAmount) = 0 Then
                        dblSalesProceed = 0
                    Else
                        If Not String.IsNullOrEmpty(Trim(HP_CODE)) Then
                            If strControlTransfer = "True" Then
                                dblSalesProceed = FormatNumber(CDbl(txtSalesProceed) * (CDbl(txtDisposeQC) / CDbl(txtTotal_QC.EditValue)), 2)
                            Else
                                dblSalesProceed = FormatNumber(CDbl(txtSalesProceed) * (CDbl(txtDisposeQC) / CDbl(txtDisposeAmount)), 2)
                            End If
                        Else
                            If CDbl(txtDisposeAmount) < CDbl(txtDisposeQC) Then
                                dblSalesProceed = CDbl(txtSalesProceed)
                            Else
                                dblSalesProceed = FormatNumber(CDbl(txtSalesProceed) * (CDbl(txtDisposeQC) / CDbl(txtDisposeAmount)), 2)
                            End If
                        End If
                    End If
                Else
                    dblSalesProceed = CDbl(txtSalesProceed)
                End If

                If dblSalesProceed - CDbl(txtTWDV) = 0 Then
                    Return CDec(dblSalesProceed - CDbl(txtTWDV))
                Else
                    If dblSalesProceed >= CDbl(txtDisposeQC) Then
                        Return CDec(CDbl(txtDisposeQC) - CDbl(txtTWDV))
                    Else
                        Return CDec(dblSalesProceed - CDbl(txtTWDV))
                    End If
                End If
            End If
        Catch ex As Exception
            Return 0
        End Try

    End Function
    Private Sub rgWithIn2YA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rgWithIn2YA.SelectedIndexChanged
        Try
            txtDisposal_BABC.EditValue = CalculateBABC(IIf(chkControlTransfer.Checked, "True", "False"), txtHP_Code.EditValue, txtDisposal_PurchaseAmount.EditValue, txtDispose_QC.EditValue, _
                                                       txtDisposal_TWDV.EditValue, txtDisposal_SalesProceed.EditValue, IIf(rgWithIn2YA.SelectedIndex = 0, True, False))


        Catch ex As Exception

        End Try
    End Sub
    Private Sub CalcRemainingCost()
        Try
            If IsNumeric(txtDisposal_PurchaseAmount.EditValue) = False Then
                txtDisposal_PurchaseAmount.EditValue = 0
            End If

            If IsNumeric(txtDispose_QC.EditValue) = False Then
                txtDispose_QC.EditValue = 0
            End If

            txtDisposal_RemainingQuaCost.EditValue = CDec(txtDisposal_PurchaseAmount.EditValue) - CDec(txtDispose_QC.EditValue)


            Application.DoEvents()

            If dtRowSelected IsNot Nothing Then
                txtDisposal_TWDV.EditValue = Calc_TWDV(dtRowSelected)
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtDispose_QC_EditValueChanged(sender As Object, e As EventArgs) Handles txtDispose_QC.EditValueChanged
        CalcRemainingCost()
    End Sub
    Private Sub txtDisposal_PurchaseAmount_EditValueChanged(sender As Object, e As EventArgs) Handles txtDisposal_PurchaseAmount.EditValueChanged
        CalcRemainingCost()
    End Sub
    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub
    Private Sub cboTypeDisposal_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            txtDisposal_BABC.EditValue = CalculateBABC(IIf(chkControlTransfer.Checked, "True", "False"), txtHP_Code.EditValue, txtDisposal_PurchaseAmount.EditValue, txtDispose_QC.EditValue, _
                                                      txtDisposal_TWDV.EditValue, txtDisposal_SalesProceed.EditValue, IIf(rgWithIn2YA.SelectedIndex = 0, True, False))


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Try
            Save_Disposal()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboRefNo_EditValueChanged_1(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            DefaultTaxPayer(sender)
        Catch ex As Exception

        End Try
    End Sub
End Class