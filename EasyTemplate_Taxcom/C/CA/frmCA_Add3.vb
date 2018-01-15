Public Class frmCA_Add3 
    Inherits DevExpress.XtraEditors.XtraForm
    Dim ErrorLog As clsError = Nothing
    Public isEdit As Boolean = False
    Public ID As Integer = 0
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

    Private Sub frmCA_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadData()
        Try
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


            If mdlProcess.CreateLookUpYA(cboPurchaseYE, ErrorLog) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If rgTypeCA.SelectedIndex = 0 Then
                cboPurchaseYE.SelectedIndex = cboYA.SelectedIndex
            End If


            Application.DoEvents()

            If mdlProcess.ArgParam2 <> "" Then
                cboRefNo.EditValue = mdlProcess.ArgParam2
                DefaultTaxPayer(cboRefNo)
            End If

            If mdlProcess.ArgParam3 <> "" Then
                cboYA.EditValue = mdlProcess.ArgParam3
                cboPurchaseYE.EditValue = mdlProcess.ArgParam3
                DefaultTaxPayer(cboRefNo)
            End If


            Dim dt As DataTable = mdlProcess.Load_CA(ID)


            If dt Is Nothing Then
                isEdit = False
                cboRefNo.ReadOnly = False
                cboYA.ReadOnly = False
                cboPurchaseYE.ReadOnly = False
                cboSourceCode.ReadOnly = False
                Exit Sub
            Else
                btnDuplicate.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                txtDuplicateNo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                cboRefNo.ReadOnly = True
                cboYA.ReadOnly = True
                cboPurchaseYE.ReadOnly = True
                cboSourceCode.ReadOnly = True
                Application.DoEvents()


                cboRefNo.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_REF_NO")), "", dt.Rows(0)("CA_REF_NO"))
                cboYA.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_YA")), Now.Year, dt.Rows(0)("CA_YA"))
                Application.DoEvents()

                If IsDBNull(dt.Rows(0)("CA_MODE")) = False AndAlso dt.Rows(0)("CA_MODE") = "ADD" Then
                    rgTypeCA.SelectedIndex = 0
                Else
                    rgTypeCA.SelectedIndex = 1
                End If

                cboPurchaseYE.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_PURCHASE_YEAR")), Now.Year, dt.Rows(0)("CA_PURCHASE_YEAR"))
                cboSourceCode.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_SOURCENO")), "", dt.Rows(0)("CA_SOURCENO"))

                If IsDBNull(dt.Rows(0)("HP_CODE")) = False AndAlso dt.Rows(0)("HP_CODE").ToString <> "" Then
                    cboHP.EditValue = IIf(IsDBNull(dt.Rows(0)("HP_CODE")), "", dt.Rows(0)("HP_CODE"))
                    chkHP.Checked = True
                Else
                    chkHP.Checked = False
                End If

                chkCAEEO.Checked = CBool(IIf(IsDBNull(dt.Rows(0)("CA_CAEEO")), False, dt.Rows(0)("CA_CAEEO")))
                chkREC.Checked = CBool(IIf(IsDBNull(dt.Rows(0)("CA_REC")), False, dt.Rows(0)("CA_REC")))

                Application.DoEvents()


                txtAsset.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_ASSET")), "", dt.Rows(0)("CA_ASSET"))
                txtAssetID.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_ASSET_CODE")), "", dt.Rows(0)("CA_ASSET_CODE"))
                cboCategory.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_CATEGORY_CODE")), "", dt.Rows(0)("CA_CATEGORY_CODE"))
                dtDateofPurchase.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_PURCHASE_DATE")), Now, dt.Rows(0)("CA_PURCHASE_DATE"))
                txtPurchaseAmountFA.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_PURCHASE_AMOUNT")), 0, dt.Rows(0)("CA_PURCHASE_AMOUNT"))
                txtDeposit.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_PAYMENT")), 0, dt.Rows(0)("CA_PAYMENT"))
                txtRestrictedQua.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_RESTRICTED_QC")), 0, dt.Rows(0)("CA_RESTRICTED_QC"))
                txtDescription.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_DESC")), "", dt.Rows(0)("CA_DESC"))
                txtIA.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_RATE_IA")), 0, dt.Rows(0)("CA_RATE_IA"))
                cboAA.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_RATE_AA")), 0, dt.Rows(0)("CA_RATE_AA"))
                txtQualifyingCost.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_QUALIFYING_COST")), 0, dt.Rows(0)("CA_QUALIFYING_COST"))
                txtRemainingQualifyingCost.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_REMAIN_QC")), 0, dt.Rows(0)("CA_REMAIN_QC"))
                txtTWDV.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_TWDV")), 0, dt.Rows(0)("CA_TWDV"))
                cboIncentive.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_INCENTIVE")), "", dt.Rows(0)("CA_INCENTIVE"))
                txtTWDV.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_TWDV")), 0, dt.Rows(0)("CA_TWDV"))

                If IsDBNull(dt.Rows(0)("CA_CTRL_TRANSFER")) = False AndAlso dt.Rows(0)("CA_CTRL_TRANSFER").ToString <> 0 Then
                    chkControlTransfer.Checked = True
                Else
                    chkControlTransfer.Checked = False
                End If

                'cbo.Checked = CBool(IIf(IsDBNull(dt.Rows(0)("CA_CAEEO")), False, dt.Rows(0)("CA_CAEEO")))
                chkDeferred.Checked = CBool(IIf(IsDBNull(dt.Rows(0)("CA_DEFERREDCLAIM")), False, dt.Rows(0)("CA_DEFERREDCLAIM")))
                chkDeductAdjustIncome.Checked = CBool(IIf(IsDBNull(dt.Rows(0)("CA_DEDUCTADJ_INCOME")), False, dt.Rows(0)("CA_DEDUCTADJ_INCOME")))
                txtTaxFileNumber.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_TAX_FILE_NUMBER")), "", dt.Rows(0)("CA_TAX_FILE_NUMBER"))
                txtTransferorName.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_TRANSFERROR_NAME")), "", dt.Rows(0)("CA_TRANSFERROR_NAME"))
                txtTransferVal.EditValue = IIf(IsDBNull(dt.Rows(0)("CA_TRANSFER_VAL")), "", dt.Rows(0)("CA_TRANSFER_VAL"))

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub rgTypeCA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rgTypeCA.SelectedIndexChanged
        TypeCA_Add_Open()
    End Sub

    Private Sub cboPurchaseYE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPurchaseYE.SelectedIndexChanged
        Try
            DefaultTaxPayer(cboRefNo)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TypeCA_Add_Open()
        Try
            If rgTypeCA.SelectedIndex = 0 Then
                cboPurchaseYE.SelectedIndex = cboYA.SelectedIndex
                cboPurchaseYE.ReadOnly = True
                lblTitle_FA.Text = "Fixed Asset Information (Addition)"
                lblTitle_CA.Text = "Capital Allowance Information (Addition)"
                txtIA.ReadOnly = True
                txtIA.EditValue = 20
            Else
                cboPurchaseYE.ReadOnly = False
                lblTitle_FA.Text = "Fixed Asset Information (Opening)"
                lblTitle_CA.Text = "Capital Allowance Information (Opening)"
                txtIA.ReadOnly = False
                txtIA.EditValue = 0
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

                cboHP.Properties.Items.Clear()
                cboHP.EditValue = ""

                If mdlProcess.CreateLookUpSourceNo(cboSourceCode, cboRefNo.EditValue.ToString, cboPurchaseYE.EditValue.ToString, ErrorLog) = False Then
                    cboSourceCode.EditValue = ""
                    chkHP.Checked = False
                    chkHP.Visible = False
                    chkREC.Visible = False
                    chkCAEEO.Visible = False
                    Exit Sub
                Else
                    cboSourceCode.SelectedIndex = 0

                    If chkHP.Checked = True AndAlso mdlProcess.CreateLookUpHPCode(cboHP, cboRefNo.EditValue.ToString, ErrorLog) = False Then
                        cboHP.EditValue = ""
                        Exit Sub
                    Else
                        cboHP.SelectedIndex = 0
                    End If

                    dtDateofPurchase.EditValue = Now
                    chkHP.Visible = True
                    chkREC.Visible = True
                    chkCAEEO.Visible = True



                End If
            End If


        Catch ex As Exception

        Finally
            ShowMainCA()
            TypeCA_Add_Open()
        End Try
    End Sub

    Private Sub cboSourceCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSourceCode.SelectedIndexChanged
        ShowMainCA()
    End Sub
    Private Sub ShowMainCA()
        Try
            If txtTaxPayer.Text = "" Then
                pnlMain.Enabled = False
                Exit Sub
            End If

            If cboSourceCode.Text.ToString = "" Then
                pnlMain.Enabled = False
                Exit Sub
            End If

            pnlMain.Enabled = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkHP_CheckedChanged(sender As Object, e As EventArgs) Handles chkHP.CheckedChanged
        Try
            If chkHP.Checked = True Then
                lblHPCode.Visible = True
                cboHP.Visible = True
            Else
                lblHPCode.Visible = False
                cboHP.Visible = False
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPurchaseAmountFA_EditValueChanged(sender As Object, e As EventArgs) Handles txtPurchaseAmountFA.EditValueChanged
        Try
            If chkREC.Checked = False Then
                txtDeposit.EditValue = txtPurchaseAmountFA.EditValue
                txtRestrictedQua.EditValue = txtPurchaseAmountFA.EditValue
                txtPurchaseAmount.EditValue = txtPurchaseAmountFA.EditValue
            End If
           

        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtRestrictedQua_EditValueChanged(sender As Object, e As EventArgs) Handles txtRestrictedQua.EditValueChanged
        Try
            If chkREC.Checked = False Then
                txtQualifyingCost.EditValue = txtRestrictedQua.EditValue
                txtRemainingQualifyingCost.EditValue = txtRestrictedQua.EditValue
                txtTWDV.EditValue = txtRestrictedQua.EditValue
            Else
                txtIA.EditValue = 0
                cboAA.EditValue = 0
                txtQualifyingCost.EditValue = 0
                txtRemainingQualifyingCost.EditValue = txtQualifyingCost.EditValue
                txtTWDV.EditValue = 0
            End If
          
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtQualifyingCost_EditValueChanged(sender As Object, e As EventArgs) Handles txtQualifyingCost.EditValueChanged
        Try
            If chkREC.Checked = False Then
                txtNonQualifyingCost.EditValue = CDec(txtPurchaseAmount.EditValue) - CDec(txtQualifyingCost.EditValue)
                txtRemainingQualifyingCost.EditValue = txtQualifyingCost.EditValue
                txtTWDV.EditValue = txtQualifyingCost.EditValue
            Else
                txtIA.EditValue = 0
                cboAA.EditValue = 0
                txtQualifyingCost.EditValue = 0
                txtNonQualifyingCost.EditValue = CDec(txtPurchaseAmount.EditValue) - CDec(txtQualifyingCost.EditValue)
                txtRemainingQualifyingCost.EditValue = txtQualifyingCost.EditValue
                txtTWDV.EditValue = 0
            End If
           
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TaxPayerFindBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles TaxPayerFindBindingSource.CurrentChanged

    End Sub

    Private Sub cboCategory_EditValueChanged(sender As Object, e As EventArgs) Handles cboCategory.EditValueChanged
        Try
            Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
            Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
            Dim value As Object = row("CA_CATEGORY")
            txtCategory.Text = value.ToString

        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkCAEEO_CheckedChanged(sender As Object, e As EventArgs) Handles chkCAEEO.CheckedChanged
        Try
            If chkCAEEO.Checked = True Then
                If DsCA.Tables("Category").Rows.Count > 0 AndAlso cboPurchaseYE.EditValue.ToString <> "" Then
                    cboCategory.EditValue = "CAPEX"
                    Dim Lastyear As New DateTime(CInt(cboPurchaseYE.EditValue), 12, 31)
                    dtDateofPurchase.EditValue = Lastyear
                    cboCategory.ReadOnly = True
                    dtDateofPurchase.ReadOnly = True
                Else
                    cboCategory.ReadOnly = False
                    dtDateofPurchase.ReadOnly = False
                End If
            Else
                cboCategory.ReadOnly = False
                dtDateofPurchase.ReadOnly = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkControlTransfer_CheckedChanged(sender As Object, e As EventArgs) Handles chkControlTransfer.CheckedChanged
        Try
            If chkControlTransfer.Checked = True Then
                pnlControlTransfer.Visible = True
            Else
                pnlControlTransfer.Visible = False
                If isEdit = False Then
                    txtTaxFileNumber.EditValue = ""
                    txtTransferorName.EditValue = ""
                    txtTransferVal.EditValue = ""
                End If
             
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkREC_CheckedChanged(sender As Object, e As EventArgs) Handles chkREC.CheckedChanged
        Try
            If chkREC.Checked Then
                chkDeductAdjustIncome.Checked = True
               
                txtIA.EditValue = 0
                cboAA.EditValue = 0
                txtQualifyingCost.EditValue = 0
                txtTWDV.EditValue = 0
                cboAA.ReadOnly = True
                txtIA.ReadOnly = True
            Else
                cboAA.ReadOnly = False
                TypeCA_Add_Open()
                chkDeductAdjustIncome.Checked = False
                txtQualifyingCost_EditValueChanged(sender, e)
            End If
           
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Save()
    End Sub
    Private Sub Save()
        Try
            If isValid() Then

                If isEdit Then
                    If mdlProcess.Update_CA(ID, cboRefNo.EditValue, txtTaxPayer.Text, txtFileNo.Text, cboYA.EditValue, txtCompanyCode.EditValue, _
                                         CInt(cboSourceCode.EditValue), IIf(rgTypeCA.SelectedIndex = 0, "ADD", "OPN"), _
                                         txtAssetID.EditValue, txtAsset.EditValue, cboCategory.EditValue, dtDateofPurchase.EditValue, _
                                         cboPurchaseYE.EditValue, CDec(txtPurchaseAmountFA.EditValue), CDec(txtDeposit.EditValue), _
                                      CDec(txtRestrictedQua.EditValue), txtDescription.EditValue, CInt(txtIA.EditValue), _
                                      cboAA.EditValue, CDec(txtQualifyingCost.EditValue), CDec(txtRemainingQualifyingCost.EditValue), _
                                      CDec(txtTWDV.EditValue), cboIncentive.EditValue, IIf(chkControlTransfer.Checked, 0, -1), _
                                      cboHP.EditValue, IIf(chkAccelerated.Checked, "True", "False"), chkCAEEO.Checked, chkREC.Checked, _
                                      chkDeferred.Checked, chkDeductAdjustIncome.Checked, txtTaxFileNumber.EditValue, txtTransferorName.EditValue, _
                                      txtTransferVal.EditValue, ErrorLog) Then

                        MsgBox("Successfully updated CA.", MsgBoxStyle.Information)
                    Else
                        MsgBox("Failed to update CA." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                    End If
                Else
                    Dim ReturnID As Integer = 0
                    If mdlProcess.Save_CA(cboRefNo.EditValue, txtTaxPayer.Text, txtFileNo.Text, cboYA.EditValue, txtCompanyCode.EditValue, _
                                          CInt(cboSourceCode.EditValue), IIf(rgTypeCA.SelectedIndex = 0, "ADD", "OPN"), _
                                          txtAssetID.EditValue, txtAsset.EditValue, cboCategory.EditValue, dtDateofPurchase.EditValue, _
                                          cboPurchaseYE.EditValue, CDec(txtPurchaseAmountFA.EditValue), CDec(txtDeposit.EditValue), _
                                       CDec(txtRestrictedQua.EditValue), txtDescription.EditValue, CInt(txtIA.EditValue), _
                                       cboAA.EditValue, CDec(txtQualifyingCost.EditValue), CDec(txtRemainingQualifyingCost.EditValue), _
                                       CDec(txtTWDV.EditValue), cboIncentive.EditValue, IIf(chkControlTransfer.Checked, 0, -1), _
                                       cboHP.EditValue, IIf(chkAccelerated.Checked, "True", "False"), chkCAEEO.Checked, chkREC.Checked, _
                                       chkDeferred.Checked, chkDeductAdjustIncome.Checked, txtTaxFileNumber.EditValue, txtTransferorName.EditValue, _
                                       txtTransferVal.EditValue, ReturnID, ErrorLog) Then
                        ID = ReturnID
                        isEdit = True
                        MsgBox("Successfully saved CA.", MsgBoxStyle.Information)

                        If CStr(cboHP.EditValue) <> "" AndAlso mdlProcess.Load_HPPrincipal(cboRefNo.EditValue, cboHP.EditValue) Is Nothing Then
                            Dim rlst As DialogResult = MessageBox.Show("Do you want to create hire purchase?", "Capital Allowance", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                            If rlst = Windows.Forms.DialogResult.Yes Then
                                Dim frm As New frmHP_Add
                                frm.ID_CA = ReturnID
                                frm.ShowDialog()
                                Me.LoadData()
                            Else
                                Me.LoadData()
                            End If
                        Else
                            Me.LoadData()
                        End If

                    Else
                        MsgBox("Failed to save CA." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                    End If
                End If

                If mdlCA.RefreshCA(cboRefNo.EditValue, cboYA.EditValue, ErrorLog) = False Then
                    MsgBox("Failed to refresh capital allowance." & vbCrLf & ErrorLog.ErrorName & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Function isValid() As Boolean
        Try
            If txtTaxPayer.EditValue Is Nothing OrElse txtTaxPayer.EditValue.ToString = "" Then
                cboRefNo.Focus()
                MsgBox("Please select tax payer.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If txtAsset.EditValue Is Nothing OrElse txtAsset.EditValue.ToString = "" Then
                txtAsset.Focus()
                MsgBox("Please enter asset description.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If cboCategory.EditValue Is Nothing OrElse cboCategory.EditValue.ToString = "" Then
                cboCategory.Focus()
                MsgBox("Please enter category.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If chkHP.Checked Then

                If cboHP Is Nothing OrElse cboHP.EditValue.ToString = "" Then
                    cboHP.Focus()
                    MsgBox("Please enter Hire Purchase Code", MsgBoxStyle.Exclamation)
                    Return False
                End If
            Else
                If txtDeposit.EditValue <> txtPurchaseAmountFA.EditValue Then
                    txtDeposit.Focus()
                    MsgBox("Deposit must equal to purhcase amount for non Hire Purchase asset.", MsgBoxStyle.Exclamation)
                    Return False
                End If
            End If
           
            If cboAA.EditValue Is Nothing OrElse cboAA.EditValue.ToString = "" Then
                cboAA.Focus()
                MsgBox("Annual allowance percentage cannot be empty.", MsgBoxStyle.Exclamation)
                Return False
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub
    Private Sub cboHP_EditValueChanged(sender As Object, e As EventArgs) Handles cboHP.EditValueChanged
        Try
            LoadHPData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadHPData()
        Try
            Dim dt As DataTable = mdlProcess.Load_HPPrincipal(cboRefNo.EditValue, cboHP.EditValue)

            If dt Is Nothing Then
                Exit Sub
            End If

            For i As Integer = 0 To dt.Rows.Count - 1
                txtAsset.EditValue = IIf(IsDBNull(dt.Rows(i)("HP_ASSET")), "", dt.Rows(i)("HP_ASSET"))
                txtAssetID.EditValue = IIf(IsDBNull(dt.Rows(i)("HP_ASSET_CODE")), "", dt.Rows(i)("HP_ASSET_CODE"))
                txtPurchaseAmountFA.EditValue = IIf(IsDBNull(dt.Rows(i)("HP_PRINCIPAL")), 0, dt.Rows(i)("HP_PRINCIPAL"))
                cboCategory.EditValue = IIf(IsDBNull(dt.Rows(i)("HP_CATEGORY_CODE")), "", dt.Rows(i)("HP_CATEGORY_CODE"))
                dtDateofPurchase.EditValue = IIf(IsDBNull(dt.Rows(i)("HP_PURCHASE_DATE")), Now, dt.Rows(i)("HP_PURCHASE_DATE"))
            Next


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDuplicate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDuplicate.ItemClick
        Try

            If txtDuplicateNo.EditValue.ToString = "" OrElse IsNumeric(txtDuplicateNo.EditValue) = False Then

                MsgBox("Please enter number of duplicate.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim rslt As DialogResult = MessageBox.Show("Are you sure want to duplicate item(s)?", "Capital Allowance", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If rslt = Windows.Forms.DialogResult.Yes Then
                Dim ListofCA_KEY As New List(Of Integer)
                For i As Integer = 0 To CInt(txtDuplicateNo.EditValue) - 1
                    ListofCA_KEY.Add(ID)
                Next

                If mdlProcess.Duplicate_CA(ListofCA_KEY, ErrorLog) Then
                    MsgBox("Successfully duplicate capital allowance.", MsgBoxStyle.Information)
                    Me.LoadData()
                Else
                    MsgBox("Failed to duplicate capital allowance." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboYA_EditValueChanged(sender As Object, e As EventArgs) Handles cboYA.EditValueChanged
        Try
            If rgTypeCA.SelectedIndex = 0 Then
                cboPurchaseYE.EditValue = cboYA.EditValue
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub cboRefNo_EditValueChanged_1(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            DefaultTaxPayer(sender)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCategory_EditValueChanged(sender As Object, e As EventArgs) Handles txtCategory.EditValueChanged

    End Sub
End Class