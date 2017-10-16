Imports DevExpress.XtraGrid.Views.Grid

Public Class frmHP_Add
    Inherits DevExpress.XtraEditors.XtraForm
    Dim ErrorLog As clsError = Nothing
    Public isEdit As Boolean = False
    Public ID As Integer = 0
    Public ID_CA As Integer = 0
    Dim isSumofDigit As Boolean = True
    Dim isFirstTimeLoad As Boolean = True
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Visual Studio 2013 Dark" ' "Office 2013" DevExpress Dark Style,
        InitializeComponent()
    End Sub

    Private Sub frmHP_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
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


            If ID_CA <> 0 Then
                Dim dtCA As DataTable = mdlProcess.Load_CA(ID_CA, ErrorLog)

                If dtCA IsNot Nothing Then

                    txtAsset.EditValue = IIf(IsDBNull(dtCA.Rows(0)("CA_ASSET")), "", dtCA.Rows(0)("CA_ASSET"))
                    txtAssetID.EditValue = IIf(IsDBNull(dtCA.Rows(0)("CA_ASSET_CODE")), "", dtCA.Rows(0)("CA_ASSET_CODE"))
                    dtDateofPurchase.EditValue = IIf(IsDBNull(dtCA.Rows(0)("CA_PURCHASE_DATE")), Now, dtCA.Rows(0)("CA_PURCHASE_DATE"))
                    txtPurchaseAmountFA.EditValue = IIf(IsDBNull(dtCA.Rows(0)("CA_PURCHASE_AMOUNT")), 0, dtCA.Rows(0)("CA_PURCHASE_AMOUNT"))
                    cboCategory.EditValue = IIf(IsDBNull(dtCA.Rows(0)("CA_CATEGORY_CODE")), "", dtCA.Rows(0)("CA_CATEGORY_CODE"))
                    txtDescription.EditValue = IIf(IsDBNull(dtCA.Rows(0)("CA_DESC")), "", dtCA.Rows(0)("CA_DESC"))
                End If

            End If
            GenerateType()
            If isEdit Then

                Dim dtHP As DataTable = mdlProcess.Load_HP(ID, ErrorLog)

                If dtHP Is Nothing Then
                    Exit Sub
                End If

                cboRefNo.EditValue = IIf(IsDBNull(dtHP.Rows(0)("HP_REF_NO")), "", dtHP.Rows(0)("HP_REF_NO"))
                cboYA.EditValue = IIf(IsDBNull(dtHP.Rows(0)("HP_YA")), Now.Year, dtHP.Rows(0)("HP_YA"))
                Application.DoEvents()

                cboSourceCode.EditValue = IIf(IsDBNull(dtHP.Rows(0)("HP_SOURCENO")), "", dtHP.Rows(0)("HP_SOURCENO"))
                cboHP.EditValue = IIf(IsDBNull(dtHP.Rows(0)("HP_CODE")), "", dtHP.Rows(0)("HP_CODE"))
                Application.DoEvents()

                txtAsset.EditValue = IIf(IsDBNull(dtHP.Rows(0)("HP_ASSET")), "", dtHP.Rows(0)("HP_ASSET"))
                txtAssetID.EditValue = IIf(IsDBNull(dtHP.Rows(0)("HP_ASSET_CODE")), "", dtHP.Rows(0)("HP_ASSET_CODE"))
                cboCategory.EditValue = IIf(IsDBNull(dtHP.Rows(0)("HP_CATEGORY_CODE")), "", dtHP.Rows(0)("HP_CATEGORY_CODE"))
                dtDateofPurchase.EditValue = IIf(IsDBNull(dtHP.Rows(0)("HP_PURCHASE_DATE")), Now, dtHP.Rows(0)("HP_PURCHASE_DATE"))
                txtPurchaseAmountFA.EditValue = IIf(IsDBNull(dtHP.Rows(0)("HP_PURCHASE_AMOUNT")), 0, dtHP.Rows(0)("HP_PURCHASE_AMOUNT"))
                txtDeposit.EditValue = IIf(IsDBNull(dtHP.Rows(0)("HP_PAYMENT")), 0, dtHP.Rows(0)("HP_PAYMENT"))
                txtRestrictedQua.EditValue = IIf(IsDBNull(dtHP.Rows(0)("HP_RESTRICTED_QC")), 0, dtHP.Rows(0)("HP_RESTRICTED_QC"))
                txtDescription.EditValue = IIf(IsDBNull(dtHP.Rows(0)("HP_DESC")), "", dtHP.Rows(0)("HP_DESC"))
                txtPrincipal.EditValue = IIf(IsDBNull(dtHP.Rows(0)("HP_PRINCIPAL")), 0, dtHP.Rows(0)("HP_PRINCIPAL"))
                txtInterest.EditValue = IIf(IsDBNull(dtHP.Rows(0)("HP_INTEREST")), 0, dtHP.Rows(0)("HP_INTEREST"))
                txtPrincipalInterest_Total.EditValue = IIf(IsDBNull(dtHP.Rows(0)("HP_TOTAL")), 0, dtHP.Rows(0)("HP_TOTAL"))

                rgGenerateType.SelectedIndex = IIf(IsDBNull(dtHP.Rows(0)("HP_TYPE_SCHE")), 0, dtHP.Rows(0)("HP_TYPE_SCHE"))
                Application.DoEvents()
                txtNoInstallment.EditValue = IIf(IsDBNull(dtHP.Rows(0)("HP_NO_INST")), 0, dtHP.Rows(0)("HP_NO_INST"))
                dtFirstInstallment.EditValue = IIf(IsDBNull(dtHP.Rows(0)("HP_FIRST_INST")), Now, dtHP.Rows(0)("HP_FIRST_INST"))
                isFirstTimeLoad = True
                Application.DoEvents()
                cboDecimal.EditValue = IIf(IsDBNull(dtHP.Rows(0)("HP_DECIMAL")), 0, dtHP.Rows(0)("HP_DECIMAL"))


                If IsDBNull(dtHP.Rows(0)("HP_SCHE_METHOD")) = False AndAlso dtHP.Rows(0)("HP_SCHE_METHOD") = "SOD" Then
                    isSumofDigit = True
                Else
                    isSumofDigit = False
                End If


                Dim dtInstallment As DataTable = mdlProcess.Load_HP_INSTALLMENT(ID, ErrorLog)

                If dtInstallment IsNot Nothing Then
                    DsCA.Tables("HP_INSTALLMENT").Rows.Clear()

                    For i As Integer = 0 To dtInstallment.Rows.Count - 1
                        DsCA.Tables("HP_INSTALLMENT").ImportRow(dtInstallment.Rows(i))
                    Next
                End If

                Dim dtYearly As DataTable = mdlProcess.Load_HP_YEARLY(ID, ErrorLog)

                If dtYearly IsNot Nothing Then
                    DsCA.Tables("HP_YEARLY").Rows.Clear()

                    For i As Integer = 0 To dtYearly.Rows.Count - 1
                        DsCA.Tables("HP_YEARLY").ImportRow(dtYearly.Rows(i))
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub DefaultTaxPayer(ByVal sender As Object)
        Try
            If cboRefNo.EditValue.ToString <> "" Then

                Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
                Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
                Dim value As Object = row("CompanyName")
                txtTaxPayer.EditValue = value.ToString
                txtFileNo.EditValue = row("FileNo").ToString
                txtCompanyCode.EditValue = row("CompanyCode").ToString

                cboHP.Properties.Items.Clear()
                cboHP.EditValue = ""

                If mdlProcess.CreateLookUpSourceNo(cboSourceCode, cboRefNo.EditValue.ToString, cboPurchaseYE.EditValue.ToString, ErrorLog) = False Then
                    cboSourceCode.EditValue = ""
                    Exit Sub
                Else
                    cboSourceCode.SelectedIndex = 0

                    If mdlProcess.CreateLookUpHPCode(cboHP, cboRefNo.EditValue.ToString, ErrorLog) = False Then
                        cboHP.EditValue = ""
                        Exit Sub
                    Else
                        cboHP.SelectedIndex = 0
                    End If

                    dtDateofPurchase.EditValue = Now

                End If
            End If


        Catch ex As Exception

        End Try
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
    Private Sub cboYA_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboYA.SelectedValueChanged
        Try
            cboPurchaseYE.EditValue = cboYA.EditValue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        DefaultTaxPayer(sender)
    End Sub

    Private Sub rgGenerateType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rgGenerateType.SelectedIndexChanged
        GenerateType()
    End Sub
    Private Sub GenerateType()
        Try
            If rgGenerateType.SelectedIndex = 0 Then
                pnlGenerateType.Visible = False
                Application.DoEvents()

                dgvCYearly.Visible = True
                dgvCInstallment.Visible = False
                dgvCYearly.Dock = DockStyle.Fill
                lblTitleSchedule.Text = "Yearly Schedule"
                lblTypeInstallment.Text = ""
                btnSumofDigits.Enabled = False
                btnStraightLine.Enabled = False
                btnRemove.Enabled = True
            Else
                pnlGenerateType.Visible = True
                dtFirstInstallment.EditValue = Now
                txtNoInstallment.EditValue = 0
                cboDecimal.SelectedIndex = 0
                Application.DoEvents()
                dgvCYearly.Visible = False
                dgvCInstallment.Visible = True
                dgvCInstallment.Dock = DockStyle.Fill
                lblTitleSchedule.Text = "Installments Schedule"
                btnSumofDigits.Enabled = True
                btnStraightLine.Enabled = True
                btnRemove.Enabled = False

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GenerateInstallmentSchedule(Optional Type As Integer = 0)
        Try

            If isEdit = True AndAlso Type = 0 Then
                Exit Sub
            Else
                If DsCA.Tables("HP_INSTALLMENT").Rows.Count > 0 Then
                    Dim rlst As DialogResult = MessageBox.Show("Do you want to create new schedule? your previous data will be loss.", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If rlst = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If

            If rgGenerateType.SelectedIndex = 0 Then
                Exit Sub
            End If

            If IsNumeric(txtNoInstallment.EditValue) = False OrElse CDec(txtNoInstallment.EditValue) <= 0 Then
                Exit Sub
            End If

            Dim dblTotalPrinInterest As Double = 0
            Dim dblTotalPrinModInterest As Double = 0
            Dim dblPrincipal As Double = 0 'Math.Round((CDbl(dicdata("txtPrincipal")) / CInt(dicdata("txtInstallmentNo"))), CInt(dicdata("cboRound")))
            Dim dblPrinModLast As Double = 0 'CDbl(dicdata("txtPrincipal")) - (dblPrincipal * (CInt(dicdata("txtInstallmentNo")) - 1))
            Dim dblInterest As Double = 0 'Math.Round((CDbl(dicdata("txtInterest")) / CInt(dicdata("txtInstallmentNo"))), CInt(dicdata("cboRound")))
            Dim dblInterestModLast As Double = 0 'CDbl(dicdata("txtInterest")) - (dblInterest * (CInt(dicdata("txtInstallmentNo")) - 1))
            Dim dblSumDigit As Double = 0
            Dim lngTotalInstallment As Long = 0

            Dim Principal As Decimal = CDec(txtPrincipal.EditValue)
            Dim Interest As Decimal = CDec(txtInterest.EditValue)
            Dim Total As Decimal = CDec(txtPrincipalInterest_Total.EditValue)
            Dim Payment_Due As DateTime = CDate(dtFirstInstallment.EditValue).AddMonths(-1)
            Dim Principal_Paid As Decimal = 0
            Dim Interest_Paid As Decimal = 0
            Dim Total_Paid As Decimal = 0
            Dim Payment_Date As Decimal = 0
            Dim YA As Integer = 0
            Dim dtRow As DataRow = Nothing
            DsCA.Tables("HP_INSTALLMENT").Rows.Clear()


            If isSumofDigit Then

                lblTypeInstallment.Text = "Sum Of Digits"

                dblTotalPrinInterest = ((Principal + Interest) / CInt(txtNoInstallment.EditValue))

                If CInt(cboDecimal.EditValue) > 0 Then
                    dblTotalPrinInterest = Math.Ceiling(Math.Round(dblTotalPrinInterest, 2) * Math.Pow(10, CInt(cboDecimal.EditValue))) / Math.Pow(10, CInt(cboDecimal.EditValue))

                Else
                    dblTotalPrinInterest = Math.Ceiling(Math.Round(dblTotalPrinInterest, 2))
                End If

                dblTotalPrinModInterest = (CDbl(txtPrincipal.EditValue) + CDbl(txtInterest.EditValue)) _
                    - (dblTotalPrinInterest) * (CInt(txtNoInstallment.EditValue) - 1)



                For idx As Integer = 1 To CInt(txtNoInstallment.EditValue)
                    lngTotalInstallment = lngTotalInstallment + CLng(idx)
                Next

                For idx As Integer = 1 To CInt(txtNoInstallment.EditValue)
                    dtRow = DsCA.Tables("HP_INSTALLMENT").NewRow

                    dblSumDigit = (CInt(txtNoInstallment.EditValue) - idx + 1) / lngTotalInstallment
                    dblInterestModLast = Math.Round(dblSumDigit * CDbl(txtInterest.EditValue), CInt(cboDecimal.EditValue))
                    dblInterest = Math.Round(dblSumDigit * CDbl(txtInterest.EditValue), CInt(cboDecimal.EditValue))
                    dblPrinModLast = dblTotalPrinModInterest - dblInterestModLast
                    dblPrincipal = dblTotalPrinInterest - dblInterestModLast

                    dtRow("HP_KEY") = DsCA.Tables("HP_INSTALLMENT").Rows.Count + 1
                    dtRow("HPD_KEY") = idx

                    If idx = CInt(txtNoInstallment.EditValue) Then
                        dtRow("HPD_PRINCIPAL") = FormatNumber(dblPrinModLast, 2)
                        dtRow("HPD_INTEREST") = FormatNumber(dblInterestModLast, 2)
                        dtRow("HPD_TOTAL") = FormatNumber(dblPrinModLast + dblInterestModLast, 2)
                    Else
                        dtRow("HPD_PRINCIPAL") = FormatNumber(dblPrincipal, 2)
                        dtRow("HPD_INTEREST") = FormatNumber(dblInterest, 2)
                        dtRow("HPD_TOTAL") = FormatNumber(dblInterest + dblPrincipal, 2)
                    End If

                    Payment_Due = CDate(Payment_Due).AddMonths(+1)
                    dtRow("HPD_PAY_DUE_DATE") = Payment_Due

                    dtRow("HPD_PAYMENT_PRINCIPAL") = 0
                    dtRow("HPD_PAYMENT_INTEREST") = 0
                    dtRow("HPD_PAYMENT_DATE") = Payment_Due
                    dtRow("HPD_YA") = Format(Payment_Due, "yyyy")

                    dtRow("HPD_PAYMENT_TOTAL") = 0

                    DsCA.Tables("HP_INSTALLMENT").Rows.Add(dtRow)
                Next
            Else
                'straight line
                lblTypeInstallment.Text = "Straight Line"

                dblPrincipal = Math.Round((CDbl(txtPrincipal.EditValue) / CInt(txtNoInstallment.EditValue)), CInt(cboDecimal.EditValue))
                dblPrinModLast = CDbl(txtPrincipal.EditValue) - (dblPrincipal * (CInt(txtNoInstallment.EditValue) - 1))
                dblInterest = Math.Round((CDbl(txtInterest.EditValue) / CInt(txtNoInstallment.EditValue)), CInt(cboDecimal.EditValue))
                dblInterestModLast = CDbl(txtInterest.EditValue) - (dblInterest * (CInt(txtNoInstallment.EditValue) - 1))

                dblTotalPrinModInterest = (CDbl(txtPrincipal.EditValue) + CDbl(txtInterest.EditValue)) _
                - Math.Round(((CDbl(txtPrincipal.EditValue) + CDbl(txtInterest.EditValue)) / _
                    CInt(txtNoInstallment.EditValue)), CInt(cboDecimal.EditValue)) * (CInt(txtNoInstallment.EditValue) - 1)

                dblTotalPrinInterest = Math.Round((CDbl(txtPrincipal.EditValue) + CDbl(txtInterest.EditValue)) / CInt(txtNoInstallment.EditValue), CInt(cboDecimal.EditValue))

                If CInt(cboDecimal.EditValue) > 0 Then
                    dblTotalPrinInterest = _
                        Math.Ceiling(Math.Round(dblTotalPrinInterest, 2) * Math.Pow(10, CInt(cboDecimal.EditValue))) / Math.Pow(10, CInt(cboDecimal.EditValue))
                Else
                    dblTotalPrinInterest = _
                        Math.Ceiling(Math.Round(dblTotalPrinInterest, 2))
                End If

                For idx As Integer = 1 To CInt(txtNoInstallment.EditValue)
                    lngTotalInstallment = lngTotalInstallment + CLng(idx)
                Next

                For idx As Integer = 1 To CInt(txtNoInstallment.EditValue)
                    dtRow = DsCA.Tables("HP_INSTALLMENT").NewRow

                    dblSumDigit = (CInt(txtNoInstallment.EditValue) - idx + 1) / lngTotalInstallment

                    dtRow("HP_KEY") = DsCA.Tables("HP_INSTALLMENT").Rows.Count + 1
                    dtRow("HPD_KEY") = idx

                    If idx = CInt(txtNoInstallment.EditValue) Then
                        dtRow("HPD_PRINCIPAL") = FormatNumber(dblPrinModLast, 2)
                        dtRow("HPD_INTEREST") = FormatNumber(dblInterestModLast, 2)
                        dtRow("HPD_TOTAL") = FormatNumber(dblPrinModLast + dblInterestModLast, 2)
                    Else
                        dtRow("HPD_PRINCIPAL") = FormatNumber(dblPrincipal, 2)
                        dtRow("HPD_INTEREST") = FormatNumber(dblInterest, 2)
                        dtRow("HPD_TOTAL") = FormatNumber(dblInterest + dblPrincipal, 2)
                    End If

                    Payment_Due = CDate(Payment_Due).AddMonths(+1)
                    dtRow("HPD_PAY_DUE_DATE") = Payment_Due

                    dtRow("HPD_PAYMENT_PRINCIPAL") = 0
                    dtRow("HPD_PAYMENT_INTEREST") = 0
                    dtRow("HPD_PAYMENT_DATE") = Payment_Due
                    dtRow("HPD_YA") = Format(Payment_Due, "yyyy")

                    dtRow("HPD_PAYMENT_TOTAL") = 0

                    DsCA.Tables("HP_INSTALLMENT").Rows.Add(dtRow)
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtPurchaseAmountFA_EditValueChanged(sender As Object, e As EventArgs) Handles txtPurchaseAmountFA.EditValueChanged
        Try
            txtRestrictedQua.EditValue = txtPurchaseAmountFA.EditValue
            GetPrincipal()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDeposit_EditValueChanged(sender As Object, e As EventArgs) Handles txtDeposit.EditValueChanged
        Try
            If CDec(txtDeposit.EditValue) < 0 Or CDec(txtDeposit.EditValue) >= CDec(txtPurchaseAmountFA.EditValue) Then
                MsgBox("Deposit must not equal/ exceed purchase amount or less than zero.", MsgBoxStyle.Exclamation)
                txtDeposit.EditValue = 0
                Exit Sub
            End If
            GetPrincipal()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GetPrincipal()
        Try
            Dim total As Decimal = 0

            If IsNumeric(txtPurchaseAmountFA.EditValue) = False Then
                txtPurchaseAmountFA.EditValue = 0
            End If

            If IsNumeric(txtDeposit.EditValue) = False Then
                txtDeposit.EditValue = 0
            End If

            total = CDec(txtPurchaseAmountFA.EditValue) - CDec(txtDeposit.EditValue)

            txtPrincipal.EditValue = total
            GetPrincipalInterestTotal()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GetPrincipalInterestTotal()
        Try
            Dim total As Decimal = 0

            If IsNumeric(txtPrincipal.EditValue) = False Then
                txtPrincipal.EditValue = 0
            End If

            If IsNumeric(txtInterest.EditValue) = False Then
                txtInterest.EditValue = 0
            End If

            total = CDec(txtPrincipal.EditValue) + CDec(txtInterest.EditValue)

            txtPrincipalInterest_Total.EditValue = total
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtInterest_EditValueChanged(sender As Object, e As EventArgs) Handles txtInterest.EditValueChanged
        Try
            GetPrincipalInterestTotal()
        Catch ex As Exception

        End Try
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

    Private Sub dgvCYearly_Click(sender As Object, e As EventArgs) Handles dgvCYearly.Click

    End Sub

    Private Sub dgvYearly_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles dgvYearly.CellValueChanged
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.RowHandle)

                If IsDBNull(row("HPD_PRINCIPAL")) = False AndAlso IsDBNull(row("HPD_INTEREST")) = False Then
                    Dim Total As Decimal = CDec(row("HPD_PRINCIPAL")) + CDec(row("HPD_INTEREST"))
                    row("HPD_TOTAL") = Total
                Else
                    row("HPD_TOTAL") = 0
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvYearly_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles dgvYearly.ValidateRow
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.RowHandle)
                If IsDBNull(row("HPD_YA")) = True Or IsNumeric(row("HPD_YA")) = False Then
                    e.ErrorText = "Please all the field."
                    e.Valid = False
                End If

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSumofDigits_Click(sender As Object, e As EventArgs) Handles btnSumofDigits.Click
        isSumofDigit = True
        Application.DoEvents()
        GenerateInstallmentSchedule(1)
    End Sub

    Private Sub btnStraightLine_Click(sender As Object, e As EventArgs) Handles btnStraightLine.Click
        isSumofDigit = False
        Application.DoEvents()
        GenerateInstallmentSchedule(1)
    End Sub

    Private Sub txtNoInstallment_EditValueChanged(sender As Object, e As EventArgs) Handles txtNoInstallment.EditValueChanged
        GenerateInstallmentSchedule()
    End Sub

    Private Sub btnApplyPayment_Click(sender As Object, e As EventArgs) Handles btnApplyPayment.Click
        Try
            If DsCA.Tables("HP_INSTALLMENT").Rows.Count > 0 Then
                For i As Integer = 0 To dgvInstallment.SelectedRowsCount - 1

                    dgvInstallment.GetDataRow(dgvInstallment.GetSelectedRows(i))("HPD_PAYMENT_PRINCIPAL") = dgvInstallment.GetDataRow(dgvInstallment.GetSelectedRows(i))("HPD_PRINCIPAL")
                    dgvInstallment.GetDataRow(dgvInstallment.GetSelectedRows(i))("HPD_PAYMENT_INTEREST") = dgvInstallment.GetDataRow(dgvInstallment.GetSelectedRows(i))("HPD_INTEREST")
                    dgvInstallment.GetDataRow(dgvInstallment.GetSelectedRows(i))("HPD_PAYMENT_TOTAL") = dgvInstallment.GetDataRow(dgvInstallment.GetSelectedRows(i))("HPD_TOTAL")

                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvInstallment_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles dgvInstallment.ValidateRow
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.RowHandle)

                If IsDBNull(row("HPD_PAYMENT_PRINCIPAL")) = False AndAlso IsDBNull(row("HPD_PAYMENT_INTEREST")) = False Then
                    Dim Total As Decimal = CDec(row("HPD_PAYMENT_PRINCIPAL")) + CDec(row("HPD_PAYMENT_INTEREST"))
                    row("HPD_PAYMENT_TOTAL") = Total
                Else
                    row("HPD_PAYMENT_TOTAL") = 0
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboDecimal_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboDecimal.SelectedValueChanged
        GenerateInstallmentSchedule()
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Try
            If isValid() Then
                Dim tmpTypeOfDigit As String = "SOD"
                Dim tmpDTFirstIntallment As DateTime = Now
                If isSumofDigit = False Then
                    tmpTypeOfDigit = "SLN"
                End If

                If rgGenerateType.SelectedIndex = 1 OrElse IsDate(dtFirstInstallment.EditValue) = True Then
                    tmpDTFirstIntallment = dtFirstInstallment.EditValue
                End If
                If isEdit Then


                    If mdlProcess.Update_HP(ID, "C", cboRefNo.EditValue, txtTaxPayer.EditValue, txtFileNo.EditValue, cboYA.EditValue, _
                                          txtCompanyCode.EditValue, cboSourceCode.EditValue, txtAssetID.EditValue, txtAsset.EditValue, _
                                          cboCategory.EditValue, dtDateofPurchase.EditValue, txtPurchaseAmountFA.EditValue, txtDeposit.EditValue, _
                                          txtRestrictedQua.EditValue, txtDescription.EditValue, cboHP.EditValue, txtPrincipal.EditValue, _
                                          0, txtInterest.EditValue, txtPrincipalInterest_Total.EditValue, txtNoInstallment.EditValue, _
                                          tmpDTFirstIntallment, cboDecimal.EditValue, tmpTypeOfDigit, rgGenerateType.SelectedIndex, DsCA, _
                                          ErrorLog) Then
                        MsgBox("Succesfully updated hire purchase.", MsgBoxStyle.Information)
                    Else
                        MsgBox("Failed to update hire purchase." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                    End If
                Else
                    Dim ReturnID As Integer = 0
                    If mdlProcess.Save_HP("C", cboRefNo.EditValue, txtTaxPayer.EditValue, txtFileNo.EditValue, cboYA.EditValue, _
                                          txtCompanyCode.EditValue, cboSourceCode.EditValue, txtAssetID.EditValue, txtAsset.EditValue, _
                                          cboCategory.EditValue, dtDateofPurchase.EditValue, txtPurchaseAmountFA.EditValue, txtDeposit.EditValue, _
                                          txtRestrictedQua.EditValue, txtDescription.EditValue, cboHP.EditValue, txtPrincipal.EditValue, _
                                          0, txtInterest.EditValue, txtPrincipalInterest_Total.EditValue, txtNoInstallment.EditValue, _
                                          tmpDTFirstIntallment, cboDecimal.EditValue, tmpTypeOfDigit, rgGenerateType.SelectedIndex, DsCA, _
                                          ReturnID, ErrorLog) Then
                        MsgBox("Succesfully saved hire purchase.", MsgBoxStyle.Information)
                        isEdit = True
                        ID = ReturnID
                    Else
                        MsgBox("Failed to save hire purchase." & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                    End If
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

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class