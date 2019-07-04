Imports DevExpress.XtraGrid.Views.Grid

Public Class frmTaxpayerInformation_Add
    Dim ErrorLog As ClsError = Nothing

    Public isEdit As Boolean = False
    Public ID As String = ""

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If ADO Is Nothing Then
            ADO = New clsIODatabase
        End If
    End Sub
    Private Sub LabelControl61_Click(sender As Object, e As EventArgs) Handles LabelControl61.Click

    End Sub
    Private Sub frmTaxpayerInformation_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadData()
            Application.DoEvents()

            TabbedView1.ActivateDocument(DockPanel1)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub LoadData()
        Try

            Dim dt As DataTable = Nothing


            dt = ADO.LoadYA
            DsDefault.Tables("YEAR_ASSESSMENT").Rows.Clear()
            If dt Is Nothing Then
                MsgBox("Please unable to ya.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            For Each rowx As DataRow In dt.Rows
                DsDefault.Tables("YEAR_ASSESSMENT").ImportRow(rowx)
            Next
            YEARASSESSMENTBindingSource.DataSource = DsDefault.Tables("YEAR_ASSESSMENT")
            '====================================================================

            dt = ADO.Load_Country
            DsDefault.Tables("COUNTRY").Rows.Clear()
            If dt Is Nothing Then
                MsgBox("Please unable to load country.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            For Each rowx As DataRow In dt.Rows
                DsDefault.Tables("COUNTRY").ImportRow(rowx)
            Next
            COUNTRYBindingSource.DataSource = DsDefault.Tables("COUNTRY")
            '====================================================================
            dt = ADO.Load_State
            DsDefault.Tables("STATES").Rows.Clear()
            If dt Is Nothing Then
                MsgBox("Please unable to load state.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            For Each rowx As DataRow In dt.Rows
                DsDefault.Tables("STATES").ImportRow(rowx)
            Next
            STATESBindingSource.DataSource = DsDefault.Tables("STATES")
            '====================================================================
            dt = ADO.Load_Bank
            DsDefault.Tables("BANK").Rows.Clear()
            If dt Is Nothing Then
                MsgBox("Please unable to bank.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            For Each rowx As DataRow In dt.Rows
                DsDefault.Tables("BANK").ImportRow(rowx)
            Next
            BANKBindingSource.DataSource = DsDefault.Tables("BANK")
            '====================================================================
            dt = ADO.Load_Business
            DsDefault.Tables("BUSINESS").Rows.Clear()
            If dt Is Nothing Then
                MsgBox("Please unable to business.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            For Each rowx As DataRow In dt.Rows
                DsDefault.Tables("BUSINESS").ImportRow(rowx)
            Next

            BUSINESSBindingSource.DataSource = DsDefault.Tables("BUSINESS")
            '====================================================================

            If isEdit = False Then
                txtRefNo.ReadOnly = False

                dtAccountFrom.EditValue = Now
                dtBasisPeriodFrom.EditValue = Now
                dtAccountTo.EditValue = Now.AddYears(+1)
                dtBasisPeriodTo.EditValue = Now.AddYears(+1)
                dtDateCommencement.EditValue = Now
                dtNextInvDate.EditValue = Now.AddYears(+1)
            Else
                txtRefNo.ReadOnly = True

                Dim dtTaxPayer As DataTable = ADO.LoadTaxPayer_ByRefNO(ID, ErrorLog)

                If dtTaxPayer Is Nothing Then
                    isEdit = False
                    MsgBox("Unable to find tax payer.", MsgBoxStyle.Critical)
                    txtRefNo.ReadOnly = False
                    Exit Sub
                End If

                txtRefNo.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_REF_NO")), "", dtTaxPayer.Rows(0)("TP_REF_NO"))
                txtCompanyName.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_COM_NAME")), "", dtTaxPayer.Rows(0)("TP_COM_NAME"))
                txtCompanyRegistration.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_ROC_NO")), "", dtTaxPayer.Rows(0)("TP_ROC_NO"))
                txtEmployeeNo.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_EMPLOYER_NO")), "", dtTaxPayer.Rows(0)("TP_EMPLOYER_NO"))
                rgResidence.EditValue = Convert.ToInt16(IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_RESIDENCE")), 1, dtTaxPayer.Rows(0)("TP_RESIDENCE")))

                cboCountryResidence.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_COUNTRY")), "MY", dtTaxPayer.Rows(0)("TP_COUNTRY"))
                dtAccountFrom.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_ACC_PERIOD_FR")), Now, dtTaxPayer.Rows(0)("TP_ACC_PERIOD_FR"))
                dtAccountTo.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_ACC_PERIOD_TO")), Now.AddDays(+1), dtTaxPayer.Rows(0)("TP_ACC_PERIOD_TO"))
                rgEfilling.EditValue = Convert.ToInt16(IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_EFILING")), 1, dtTaxPayer.Rows(0)("TP_EFILING")))
                rgPublicRuling.EditValue = Convert.ToInt16(IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_PUBLIC_ORDER")), 0, dtTaxPayer.Rows(0)("TP_PUBLIC_ORDER")))

                If IsDBNull(dtTaxPayer.Rows(0)("TP_CO_STATUS")) = False Then
                    Dim split() As String = dtTaxPayer.Rows(0)("TP_CO_STATUS").ToString.Split(",")

                    If split.Length > 0 Then
                        For i As Integer = 0 To split.Length - 1
                            If split(i) <> "" AndAlso IsNumeric(split(i)) Then
                                For x As Integer = 0 To chkCompanyStatus.Items.Count - 1
                                    If chkCompanyStatus.Items(x).Value = CInt(split(i)) Then
                                        chkCompanyStatus.Items(x).CheckState = CheckState.Checked
                                        Application.DoEvents()
                                    End If
                                Next
                            End If

                        Next
                    End If
                End If

                txtEmail.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_EMAIL")), "", dtTaxPayer.Rows(0)("TP_EMAIL"))
                txt_RegAddress1.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_REG_ADD_LINE1")), "", dtTaxPayer.Rows(0)("TP_REG_ADD_LINE1"))
                txt_RegAddress2.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_REG_ADD_LINE2")), "", dtTaxPayer.Rows(0)("TP_REG_ADD_LINE2"))
                txt_RegAddress3.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_REG_ADD_LINE3")), "", dtTaxPayer.Rows(0)("TP_REG_ADD_LINE3"))
                txt_RegPostcode.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_REG_POSTCODE")), "", dtTaxPayer.Rows(0)("TP_REG_POSTCODE"))
                txt_RegCity.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_REG_CITY")), "", dtTaxPayer.Rows(0)("TP_REG_CITY"))
                cbo_RegState.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_REG_STATE")), "", dtTaxPayer.Rows(0)("TP_REG_STATE"))

                txt_CorrAddress1.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_CURR_ADD_LINE1")), "", dtTaxPayer.Rows(0)("TP_CURR_ADD_LINE1"))
                txt_CorrAddress2.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_CURR_ADD_LINE2")), "", dtTaxPayer.Rows(0)("TP_CURR_ADD_LINE2"))
                txt_CorrAddress3.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_CURR_ADD_LINE3")), "", dtTaxPayer.Rows(0)("TP_CURR_ADD_LINE3"))
                txt_CorrPostcode.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_CURR_POSTCODE")), "", dtTaxPayer.Rows(0)("TP_CURR_POSTCODE"))
                txt_CorrCity.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_CURR_CITY")), "", dtTaxPayer.Rows(0)("TP_CURR_CITY"))
                cbo_CorrState.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_CURR_STATE")), "", dtTaxPayer.Rows(0)("TP_CURR_STATE"))

                txt_BizAddress1.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_COM_ADD_LINE1")), "", dtTaxPayer.Rows(0)("TP_COM_ADD_LINE1"))
                txt_BizAddress2.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_COM_ADD_LINE2")), "", dtTaxPayer.Rows(0)("TP_COM_ADD_LINE2"))
                txt_BizAddress3.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_COM_ADD_LINE3")), "", dtTaxPayer.Rows(0)("TP_COM_ADD_LINE3"))
                txt_BizPostcode.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_COM_POSTCODE")), "", dtTaxPayer.Rows(0)("TP_COM_POSTCODE"))
                txt_BizCity.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_COM_CITY")), "", dtTaxPayer.Rows(0)("TP_COM_CITY"))
                cbo_BizState.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_COM_STATE")), "", dtTaxPayer.Rows(0)("TP_COM_STATE"))

                cbo_BankName.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_BANK")), "", dtTaxPayer.Rows(0)("TP_BANK"))
                txt_BankAcc.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_BANK_ACC")), "", dtTaxPayer.Rows(0)("TP_BANK_ACC"))
                txt_BankAddress1.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_BANK_ADD_LINE1")), "", dtTaxPayer.Rows(0)("TP_BANK_ADD_LINE1"))
                txt_BankAddress2.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_BANK_ADD_LINE2")), "", dtTaxPayer.Rows(0)("TP_BANK_ADD_LINE2"))
                txt_BankAddress3.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_BANK_ADD_LINE3")), "", dtTaxPayer.Rows(0)("TP_BANK_ADD_LINE3"))
                txt_BankPostcode.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_BANK_POSTCODE")), "", dtTaxPayer.Rows(0)("TP_BANK_POSTCODE"))
                txt_BankCity.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_BANK_CITY")), "", dtTaxPayer.Rows(0)("TP_BANK_CITY"))
                cbo_BankState.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_BANK_STATE")), "", dtTaxPayer.Rows(0)("TP_BANK_STATE"))

                If IsDBNull(dtTaxPayer.Rows(0)("TP_RECORD_KEPT")) = False Then
                    Dim split() As String = dtTaxPayer.Rows(0)("TP_RECORD_KEPT").ToString.Split(",")

                    If split.Length > 0 Then
                        For i As Integer = 0 To split.Length - 1
                            If split(i) <> "" AndAlso IsNumeric(split(i)) Then
                                For x As Integer = 0 To chk_BankTypeAlt.Items.Count - 1
                                    If chk_BankTypeAlt.Items(i).Value = CInt(split(i)) Then
                                        chk_BankTypeAlt.Items(i).CheckState = CheckState.Checked
                                        Application.DoEvents()
                                    End If
                                Next
                            End If

                        Next
                    End If
                End If

                txt_BankAltAddress1.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_ALT_ADD_LINE1")), "", dtTaxPayer.Rows(0)("TP_ALT_ADD_LINE1"))
                txt_BankAltAddress2.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_ALT_ADD_LINE2")), "", dtTaxPayer.Rows(0)("TP_ALT_ADD_LINE2"))
                txt_BankAltAddress3.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_ALT_ADD_LINE3")), "", dtTaxPayer.Rows(0)("TP_ALT_ADD_LINE3"))
                txt_BankAltPostcode.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_ALT_POSTCODE")), "", dtTaxPayer.Rows(0)("TP_ALT_POSTCODE"))
                txt_BankAltCity.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_ALT_CITY")), "", dtTaxPayer.Rows(0)("TP_ALT_CITY"))
                cbo_BankAltState.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_ALT_STATE")), "", dtTaxPayer.Rows(0)("TP_ALT_STATE"))

                txtTaxFileNo.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_TAX_FILE_NO")), "", dtTaxPayer.Rows(0)("TP_TAX_FILE_NO"))

                txtContactPerson.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_CONTACT")), "", dtTaxPayer.Rows(0)("TP_CONTACT"))
                txtTelNo.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_TEL_NO")), "", dtTaxPayer.Rows(0)("TP_TEL_NO"))
                txtFaxNo.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_FAX_NO")), "", dtTaxPayer.Rows(0)("TP_FAX_NO"))
                dtNextInvDate.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_INV_ANN_DATE")), Now, dtTaxPayer.Rows(0)("TP_INV_ANN_DATE"))
                txtDetailsTaxFee.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_INV_DETTAXFEE")), 0, dtTaxPayer.Rows(0)("TP_INV_DETTAXFEE"))
                txtDisbursement.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_INV_DISBURSEMENT")), 0, dtTaxPayer.Rows(0)("TP_INV_DISBURSEMENT"))
                txtSalesTax.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_INV_SALESTAX")), 0, dtTaxPayer.Rows(0)("TP_INV_SALESTAX"))
                txtTotal.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_INV_TOTAL")), 0, dtTaxPayer.Rows(0)("TP_INV_TOTAL"))

                txtBlogWebsite.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_BLOG")), "", dtTaxPayer.Rows(0)("TP_BLOG"))
                dtBasisPeriodFrom.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_BASIS_PERIOD_FR")), Now, dtTaxPayer.Rows(0)("TP_BASIS_PERIOD_FR"))
                dtBasisPeriodTo.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_BASIS_PERIOD_TO")), Now.AddDays(+1), dtTaxPayer.Rows(0)("TP_BASIS_PERIOD_TO"))

                dtDateCommencement.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_OPN_OPERATION")), "", dtTaxPayer.Rows(0)("TP_OPN_OPERATION"))

                txtUltimateHolding.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_ULT_COMPANY")), "", dtTaxPayer.Rows(0)("TP_ULT_COMPANY"))
                cboUltimateHolding_Country.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_ULT_COUNTRY_CODE")), "MY", dtTaxPayer.Rows(0)("TP_ULT_COUNTRY_CODE"))

                txtImmadiateHolding.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_IMD_COMPANY")), "", dtTaxPayer.Rows(0)("TP_IMD_COMPANY"))
                cboImmadiateHolding_Country.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_IMD_COUNTRY_CODE")), "MY", dtTaxPayer.Rows(0)("TP_IMD_COUNTRY_CODE"))

                cbo_RegCountry.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_REG_COUNTRY")), "MY", dtTaxPayer.Rows(0)("TP_REG_COUNTRY"))
                cbo_CorrCountry.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_CURR_COUNTRY")), "MY", dtTaxPayer.Rows(0)("TP_CURR_COUNTRY"))
                cbo_BizCountry.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_COM_COUNTRY")), "MY", dtTaxPayer.Rows(0)("TP_COM_COUNTRY"))
                cbo_BankAltCountry.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_ALT_COUNTRY")), "MY", dtTaxPayer.Rows(0)("TP_ALT_COUNTRY"))

                rgStatus.EditValue = Convert.ToInt16(IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_COM_STS")), 1, dtTaxPayer.Rows(0)("TP_COM_STS")))
                'chk.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_SECTION_127_1")), 0, dtTaxPayer.Rows(0)("TP_SECTION_127_1"))

                For i As Integer = 0 To chkClaimSec127.Items.Count - 1

                    If chkClaimSec127.Items(i).Value = "1" Then
                        If IsDBNull(dtTaxPayer.Rows(0)("TP_SECTION_127_1")) = False AndAlso dtTaxPayer.Rows(0)("TP_SECTION_127_1") = "1" Then
                            chkClaimSec127.Items(i).CheckState = CheckState.Checked
                        Else
                            chkClaimSec127.Items(i).CheckState = CheckState.Unchecked
                        End If
                    End If

                    If chkClaimSec127.Items(i).Value = "2" Then
                        If IsDBNull(dtTaxPayer.Rows(0)("TP_SECTION_127_2")) = False AndAlso dtTaxPayer.Rows(0)("TP_SECTION_127_1") = "2" Then
                            chkClaimSec127.Items(i).CheckState = CheckState.Checked
                        Else
                            chkClaimSec127.Items(i).CheckState = CheckState.Unchecked
                        End If
                    End If

                    If chkClaimSec127.Items(i).Value = "3" Then
                        If IsDBNull(dtTaxPayer.Rows(0)("TP_SECTION_127_3")) = False AndAlso dtTaxPayer.Rows(0)("TP_SECTION_127_1") = "3" Then
                            chkClaimSec127.Items(i).CheckState = CheckState.Checked
                        Else
                            chkClaimSec127.Items(i).CheckState = CheckState.Unchecked
                        End If
                    End If

                Next

                rgJKDM.EditValue = Convert.ToInt16(IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_ROYALCLAIM")), 0, dtTaxPayer.Rows(0)("TP_ROYALCLAIM")))
                rgCarryEBiz.EditValue = Convert.ToInt16(IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_CARRYETRANDING")), 0, dtTaxPayer.Rows(0)("TP_CARRYETRANDING")))
                txtGSTNo.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_GOODSERVICETAXREGISTRAION")), "", dtTaxPayer.Rows(0)("TP_GOODSERVICETAXREGISTRAION"))
                rgLabuan.EditValue = Convert.ToInt16(IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_LABUAN_STATUS")), 0, dtTaxPayer.Rows(0)("TP_LABUAN_STATUS")))
                txt_LabuanName.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_LABUAN_NAME")), "", dtTaxPayer.Rows(0)("TP_LABUAN_NAME"))
                txt_LabuanRegNo.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_LABUAN_REG")), "", dtTaxPayer.Rows(0)("TP_LABUAN_REG"))
                txt_LabuanTaxNo.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_LABUAN_INCOME_TAX")), "", dtTaxPayer.Rows(0)("TP_LABUAN_INCOME_TAX"))
                rgClaimIndustBuil42_1.EditValue = Convert.ToInt16(IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_BUILDINGINDUSTRY")), "", dtTaxPayer.Rows(0)("TP_BUILDINGINDUSTRY")))
                txtOtherCompanyStatus.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("TP_STS_OTHER")), "", dtTaxPayer.Rows(0)("TP_STS_OTHER"))
                txtPersonIncharge.EditValue = IIf(IsDBNull(dtTaxPayer.Rows(0)("HandleBy")), "", dtTaxPayer.Rows(0)("HandleBy"))

                If IsDBNull(dtTaxPayer.Rows(0)("ModifiedBy")) = False AndAlso dtTaxPayer.Rows(0)("ModifiedBy") <> "" Then
                    lblLastmodified.Caption = dtTaxPayer.Rows(0)("ModifiedBy") & " | " & IIf(IsDBNull(dtTaxPayer.Rows(0)("ModifiedDateTime")), "", dtTaxPayer.Rows(0)("ModifiedDateTime"))
                Else
                    lblLastmodified.Caption = ""
                End If

                Dim dtBusinessSource As DataTable = Nothing

                dtBusinessSource = ADO.Load_BusinessSource(ID, ErrorLog)

                DsDefault.Tables("BUSINESS_SOURCE").Rows.Clear()

                If dtBusinessSource IsNot Nothing Then
                    For Each rowx As DataRow In dtBusinessSource.Rows
                        DsDefault.Tables("BUSINESS_SOURCE").ImportRow(rowx)
                    Next
                End If

                BUSINESSSOURCEBindingSource.DataSource = DsDefault.Tables("BUSINESS_SOURCE")

                dtBusinessSource = ADO.Load_BusinessSourcePartnership(ID, ErrorLog)

                DsDefault.Tables("TAXP_PARTNERSHIP").Rows.Clear()

                If dtBusinessSource IsNot Nothing Then
                    For Each rowx As DataRow In dtBusinessSource.Rows
                        DsDefault.Tables("TAXP_PARTNERSHIP").ImportRow(rowx)
                    Next
                End If

                TAXPPARTNERSHIPBindingSource.DataSource = DsDefault.Tables("TAXP_PARTNERSHIP")

            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub dgvBusinessSource_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs)
        Try

            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.RowHandle)

                If IsDBNull(row("BC_YA")) = True OrElse row("BC_YA").ToString = "" Then
                    e.ErrorText = "Please put year assessment."
                    e.Valid = False
                    Exit Sub
                End If

                If IsDBNull(row("BC_SOURCENO")) = True OrElse row("BC_SOURCENO").ToString Is Nothing Then
                    e.ErrorText = "Please put business source no."
                    e.Valid = False
                Else
                    For i As Integer = 0 To DsDefault.Tables("BUSINESS_SOURCE").Rows.Count - 1
                        If IsDBNull(DsDefault.Tables("BUSINESS_SOURCE").Rows(i)("BC_YA")) = False AndAlso IsNumeric(DsDefault.Tables("BUSINESS_SOURCE").Rows(i)("BC_YA")) Then
                            If CInt(DsDefault.Tables("BUSINESS_SOURCE").Rows(i)("BC_YA")) = CInt(row("BC_YA")) Then

                                If DsDefault.Tables("BUSINESS_SOURCE").Rows(i)("BC_SOURCENO").ToString = row("BC_SOURCENO").ToString Then
                                    e.ErrorText = "Source number already exist for this year."
                                    e.Valid = False
                                    Exit Sub
                                End If
                            End If
                        End If

                    Next
                End If

                If IsDBNull(row("BC_CODE")) = True OrElse row("BC_CODE").ToString = "" Then
                    e.ErrorText = "Please select business code type."
                    e.Valid = False
                    Exit Sub
                End If

                Dim dtTmp As DataTable = ADO.Load_Business(row("BC_CODE"))

                If dtTmp IsNot Nothing Then
                    row("BC_TYPE") = IIf(IsDBNull(dtTmp.Rows(0)("BS_TYPE")), "", dtTmp.Rows(0)("BS_TYPE"))
                End If

            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub dgvPartnership_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs)
        Try

            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.RowHandle)

                If IsDBNull(row("PS_YA")) = True OrElse row("PS_YA").ToString = "" Then
                    e.ErrorText = "Please put year assessment."
                    e.Valid = False
                    Exit Sub
                End If

                If IsDBNull(row("PS_SOURCENO")) = True OrElse row("PS_SOURCENO").ToString Is Nothing Then
                    e.ErrorText = "Please put business source no."
                    e.Valid = False
                Else
                    For i As Integer = 0 To DsDefault.Tables("TAXP_PARTNERSHIP").Rows.Count - 1
                        If IsDBNull(DsDefault.Tables("TAXP_PARTNERSHIP").Rows(i)("PS_YA")) = False AndAlso IsNumeric(DsDefault.Tables("TAXP_PARTNERSHIP").Rows(i)("PS_YA")) Then
                            If CInt(DsDefault.Tables("TAXP_PARTNERSHIP").Rows(i)("PS_YA")) = CInt(row("PS_YA")) Then

                                If DsDefault.Tables("TAXP_PARTNERSHIP").Rows(i)("PS_SOURCENO").ToString = row("PS_SOURCENO").ToString Then
                                    e.ErrorText = "Source number already exist for this year."
                                    e.Valid = False
                                    Exit Sub
                                End If
                            End If
                        End If

                    Next
                End If

                If IsDBNull(row("PS_CODE")) = True OrElse row("PS_CODE").ToString = "" Then
                    e.ErrorText = "Please select business code type."
                    e.Valid = False
                    Exit Sub
                End If

                If IsDBNull(row("PS_COM_REG_NO")) = True OrElse row("PS_COM_REG_NO").ToString = "" Then
                    e.ErrorText = "Please put company register number."
                    e.Valid = False
                    Exit Sub
                End If

                If IsDBNull(row("PS_COM_NAME")) = True OrElse row("PS_COM_NAME").ToString = "" Then
                    e.ErrorText = "Please put company name."
                    e.Valid = False
                    Exit Sub
                End If

                If IsDBNull(row("PS_FILE_NO3")) = False AndAlso row("PS_FILE_NO3").ToString.Length > 2 Then
                    e.ErrorText = "File number 3 cannot more then 2 chartacter."
                    e.Valid = False
                    Exit Sub
                End If


                Dim dtTmp As DataTable = ADO.Load_Business(row("PS_CODE"))

                If dtTmp IsNot Nothing Then
                    row("PS_TYPE") = IIf(IsDBNull(dtTmp.Rows(0)("BS_TYPE")), "", dtTmp.Rows(0)("BS_TYPE"))
                End If

                row("PS_FILE_NO1") = "D"

            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub chk_CorrSameReg_CheckedChanged(sender As Object, e As EventArgs) Handles chk_CorrSameReg.CheckedChanged
        Try
            If chk_CorrSameReg.Checked = True Then
                If txt_RegAddress1.EditValue IsNot Nothing Then
                    txt_CorrAddress1.EditValue = txt_RegAddress1.EditValue
                End If
                If txt_RegAddress2.EditValue IsNot Nothing Then
                    txt_CorrAddress2.EditValue = txt_RegAddress2.EditValue
                End If
                If txt_RegAddress3.EditValue IsNot Nothing Then
                    txt_CorrAddress3.EditValue = txt_RegAddress3.EditValue
                End If
                If txt_RegPostcode.EditValue IsNot Nothing Then
                    txt_CorrPostcode.EditValue = txt_RegPostcode.EditValue
                End If
                If cbo_RegState.EditValue IsNot Nothing Then
                    cbo_CorrState.EditValue = cbo_RegState.EditValue
                End If
                If txt_RegCity.EditValue IsNot Nothing Then
                    txt_CorrCity.EditValue = txt_RegCity.EditValue
                End If
                If cbo_RegCountry.EditValue IsNot Nothing Then
                    cbo_CorrCountry.EditValue = cbo_RegCountry.EditValue
                End If
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub chk_BizSameReg_CheckedChanged(sender As Object, e As EventArgs) Handles chk_BizSameReg.CheckedChanged
        Try
            If chk_BizSameReg.Checked = True Then
                If txt_RegAddress1.EditValue IsNot Nothing Then
                    txt_BizAddress1.EditValue = txt_RegAddress1.EditValue
                End If
                If txt_RegAddress2.EditValue IsNot Nothing Then
                    txt_BizAddress2.EditValue = txt_RegAddress2.EditValue
                End If
                If txt_RegAddress3.EditValue IsNot Nothing Then
                    txt_BizAddress3.EditValue = txt_RegAddress3.EditValue
                End If
                If txt_RegPostcode.EditValue IsNot Nothing Then
                    txt_BizPostcode.EditValue = txt_RegPostcode.EditValue
                End If
                If cbo_RegState.EditValue IsNot Nothing Then
                    cbo_BizState.EditValue = cbo_RegState.EditValue
                End If
                If txt_RegCity.EditValue IsNot Nothing Then
                    txt_BizCity.EditValue = txt_RegCity.EditValue
                End If
                If cbo_RegCountry.EditValue IsNot Nothing Then
                    cbo_BizCountry.EditValue = cbo_RegCountry.EditValue
                End If
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub chk_BizSameCorr_CheckedChanged(sender As Object, e As EventArgs) Handles chk_BizSameCorr.CheckedChanged
        Try
            If chk_BizSameCorr.Checked = True Then
                If txt_CorrAddress1.EditValue IsNot Nothing Then
                    txt_BizAddress1.EditValue = txt_CorrAddress1.EditValue
                End If
                If txt_CorrAddress2.EditValue IsNot Nothing Then
                    txt_BizAddress2.EditValue = txt_CorrAddress2.EditValue
                End If
                If txt_CorrAddress3.EditValue IsNot Nothing Then
                    txt_BizAddress3.EditValue = txt_CorrAddress3.EditValue
                End If
                If txt_CorrPostcode.EditValue IsNot Nothing Then
                    txt_BizPostcode.EditValue = txt_CorrPostcode.EditValue
                End If
                If cbo_CorrState.EditValue IsNot Nothing Then
                    cbo_BizState.EditValue = cbo_CorrState.EditValue
                End If
                If txt_CorrCity.EditValue IsNot Nothing Then
                    txt_BizCity.EditValue = txt_CorrCity.EditValue
                End If
                If cbo_CorrCountry.EditValue IsNot Nothing Then
                    cbo_BizCountry.EditValue = cbo_CorrCountry.EditValue
                End If
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Try
            If isValid() Then
                DsDefault.Tables("TAXP_PROFILE").Rows.Clear()

                Dim dtRow As DataRow = Nothing

                dtRow = DsDefault.Tables("TAXP_PROFILE").NewRow
                dtRow("TP_REF_NO") = txtRefNo.EditValue
                dtRow("TP_COM_NAME") = txtCompanyName.EditValue
                dtRow("TP_ROC_NO") = txtCompanyRegistration.EditValue
                dtRow("TP_EMPLOYER_NO") = txtEmployeeNo.EditValue
                dtRow("TP_FILE_NO") = "C"
                dtRow("TP_RESIDENCE") = rgResidence.EditValue.ToString
                dtRow("TP_COUNTRY") = cboCountryResidence.EditValue
                dtRow("TP_ACC_PERIOD_FR") = dtAccountFrom.EditValue
                dtRow("TP_ACC_PERIOD_TO") = dtAccountTo.EditValue
                dtRow("TP_EFILING") = rgEfilling.EditValue.ToString
                dtRow("TP_PUBLIC_ORDER") = rgPublicRuling.EditValue.ToString

                Dim tmp_CO_Status As String = ""
                Dim isFirst As Boolean = True
                For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In chkCompanyStatus.CheckedItems
                    If isFirst = True Then
                        isFirst = False
                        tmp_CO_Status += item.Value.ToString()
                    Else
                        tmp_CO_Status += "," & item.Value.ToString()
                    End If

                Next
                dtRow("TP_CO_STATUS") = tmp_CO_Status

                dtRow("TP_EMAIL") = txtEmail.EditValue
                dtRow("TP_REG_ADD_LINE1") = txt_RegAddress1.EditValue
                dtRow("TP_REG_ADD_LINE2") = txt_RegAddress2.EditValue
                dtRow("TP_REG_ADD_LINE3") = txt_RegAddress3.EditValue
                dtRow("TP_REG_POSTCODE") = txt_RegPostcode.EditValue
                dtRow("TP_REG_CITY") = txt_RegCity.EditValue
                dtRow("TP_REG_STATE") = cbo_RegState.EditValue

                dtRow("TP_CURR_ADD_LINE1") = txt_CorrAddress1.EditValue
                dtRow("TP_CURR_ADD_LINE2") = txt_CorrAddress2.EditValue
                dtRow("TP_CURR_ADD_LINE3") = txt_CorrAddress3.EditValue
                dtRow("TP_CURR_POSTCODE") = txt_CorrPostcode.EditValue
                dtRow("TP_CURR_CITY") = txt_CorrCity.EditValue
                dtRow("TP_CURR_STATE") = cbo_CorrState.EditValue

                dtRow("TP_COM_ADD_LINE1") = txt_BizAddress1.EditValue
                dtRow("TP_COM_ADD_LINE2") = txt_BizAddress2.EditValue
                dtRow("TP_COM_ADD_LINE3") = txt_BizAddress3.EditValue
                dtRow("TP_COM_POSTCODE") = txt_BizPostcode.EditValue
                dtRow("TP_COM_CITY") = txt_BizCity.EditValue
                dtRow("TP_COM_STATE") = cbo_BizState.EditValue

                dtRow("TP_BANK") = cbo_BankName.EditValue
                dtRow("TP_BANK_ACC") = txt_BankAcc.EditValue
                dtRow("TP_BANK_ADD_LINE1") = txt_BankAddress1.EditValue
                dtRow("TP_BANK_ADD_LINE2") = txt_BankAddress2.EditValue
                dtRow("TP_BANK_ADD_LINE3") = txt_BankAddress3.EditValue
                dtRow("TP_BANK_POSTCODE") = txt_BankPostcode.EditValue
                dtRow("TP_BANK_CITY") = txt_BankCity.EditValue
                dtRow("TP_BANK_STATE") = cbo_BankState.EditValue

                Dim tmpRECORD_KEPT As String = ""
                isFirst = True
                For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In chk_BankTypeAlt.CheckedItems
                    If isFirst = True Then
                        isFirst = False
                        tmpRECORD_KEPT += item.Value.ToString()
                    Else
                        tmpRECORD_KEPT += "," & item.Value.ToString()
                    End If

                Next
                dtRow("TP_RECORD_KEPT") = tmpRECORD_KEPT

                dtRow("TP_ALT_ADD_LINE1") = txt_BankAltAddress1.EditValue
                dtRow("TP_ALT_ADD_LINE2") = txt_BankAltAddress2.EditValue
                dtRow("TP_ALT_ADD_LINE3") = txt_BankAltAddress3.EditValue
                dtRow("TP_ALT_POSTCODE") = txt_BankAltPostcode.EditValue
                dtRow("TP_ALT_CITY") = txt_BankAltCity.EditValue
                dtRow("TP_ALT_STATE") = cbo_BankAltState.EditValue

                dtRow("TP_TAX_FILE_NO") = txtTaxFileNo.EditValue

                dtRow("TP_CONTACT") = txtContactPerson.EditValue
                dtRow("TP_TEL_NO") = txtTelNo.EditValue
                dtRow("TP_FAX_NO") = txtFaxNo.EditValue
                dtRow("TP_INV_ANN_DATE") = IIf(dtNextInvDate.EditValue Is Nothing, CDate(dtDateCommencement.EditValue).AddYears(+1), dtNextInvDate.EditValue)
                dtRow("TP_INV_DETTAXFEE") = txtDetailsTaxFee.EditValue
                dtRow("TP_INV_DISBURSEMENT") = txtDisbursement.EditValue
                dtRow("TP_INV_SALESTAX") = txtSalesTax.EditValue
                dtRow("TP_INV_TOTAL") = txtTotal.EditValue

                dtRow("TP_PREFIX") = "C"
                dtRow("TP_BLOG") = txtBlogWebsite.EditValue
                dtRow("TP_BASIS_PERIOD_FR") = dtBasisPeriodFrom.EditValue
                dtRow("TP_BASIS_PERIOD_TO") = dtBasisPeriodTo.EditValue
                dtRow("TP_OPN_OPERATION") = dtDateCommencement.EditValue

                dtRow("TP_ULT_COMPANY") = txtUltimateHolding.EditValue
                dtRow("TP_ULT_COUNTRY_CODE") = cboUltimateHolding_Country.EditValue

                dtRow("TP_IMD_COMPANY") = txtImmadiateHolding.EditValue
                dtRow("TP_IMD_COUNTRY_CODE") = cboImmadiateHolding_Country.EditValue

                dtRow("TP_REG_COUNTRY") = cbo_RegCountry.EditValue
                dtRow("TP_CURR_COUNTRY") = cbo_CorrCountry.EditValue
                dtRow("TP_COM_COUNTRY") = cbo_BizCountry.EditValue
                dtRow("TP_ALT_COUNTRY") = cbo_BankAltCountry.EditValue


                dtRow("TP_COM_STS") = rgStatus.EditValue
                Dim TP_SECTION_127_1 As String = "0"
                Dim TP_SECTION_127_2 As String = "0"
                Dim TP_SECTION_127_3 As String = "0"
                For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In chkClaimSec127.CheckedItems

                    If item.Value.ToString = "1" Then
                        TP_SECTION_127_1 = "1"
                    End If

                    If item.Value.ToString = "2" Then
                        TP_SECTION_127_2 = "1"
                    End If

                    If item.Value.ToString = "3" Then
                        TP_SECTION_127_3 = "1"
                    End If

                Next
                dtRow("TP_SECTION_127_1") = TP_SECTION_127_1
                dtRow("TP_SECTION_127_2") = TP_SECTION_127_2
                dtRow("TP_SECTION_127_3") = TP_SECTION_127_3

                dtRow("TP_ROYALCLAIM") = rgJKDM.EditValue
                dtRow("TP_CARRYETRANDING") = rgCarryEBiz.EditValue
                dtRow("TP_GOODSERVICETAXREGISTRAION") = txtGSTNo.EditValue

                dtRow("TP_LABUAN_STATUS") = rgLabuan.EditValue
                dtRow("TP_LABUAN_NAME") = txt_LabuanName.EditValue
                dtRow("TP_LABUAN_REG") = txt_LabuanRegNo.EditValue
                dtRow("TP_LABUAN_INCOME_TAX") = txt_LabuanTaxNo.EditValue

                dtRow("TP_BUILDINGINDUSTRY") = rgClaimIndustBuil42_1.EditValue
                dtRow("TP_STS_OTHER") = txtOtherCompanyStatus.EditValue

                dtRow("HandleBy") = txtPersonIncharge.EditValue
                dtRow("ModifiedBy") = My.Computer.Name
                dtRow("ModifiedDateTime") = Now

                DsDefault.Tables("TAXP_PROFILE").Rows.Add(dtRow)

                For Each rowx As DataRow In DsDefault.Tables("BUSINESS_SOURCE").Rows
                    rowx("BC_KEY") = txtRefNo.EditValue
                    rowx("BC_COMPANY") = "C"
                Next
                For Each rowx As DataRow In DsDefault.Tables("TAXP_PARTNERSHIP").Rows
                    rowx("PS_KEY") = txtRefNo.EditValue
                Next
                Application.DoEvents()

                If isEdit Then

                    If ADO.Update_TaxPayer(DsDefault.Tables("TAXP_PROFILE"), DsDefault.Tables("BUSINESS_SOURCE"), DsDefault.Tables("TAXP_PARTNERSHIP"), ErrorLog) Then
                        MsgBox("Successfully updated tax payer information", MsgBoxStyle.Information)
                        Me.LoadData()
                    Else
                        MsgBox("Unsuccessfully update tax payer information", MsgBoxStyle.Critical)
                    End If

                Else

                    If ADO.Save_TaxPayer(DsDefault.Tables("TAXP_PROFILE"), DsDefault.Tables("BUSINESS_SOURCE"), DsDefault.Tables("TAXP_PARTNERSHIP"), ErrorLog) Then
                        MsgBox("Successfully saved tax payer information", MsgBoxStyle.Information)
                        ID = txtRefNo.EditValue
                        isEdit = True
                        Me.LoadData()
                    Else
                        MsgBox("Unsuccessfully save tax payer information", MsgBoxStyle.Critical)
                    End If

                End If

                frmHome.LoadData()
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
    Private Function isValid() As Boolean
        Try

            If txtCompanyName.EditValue Is Nothing OrElse txtCompanyName.EditValue = "" Then
                txtCompanyName.Focus()
                MsgBox("Please enter company name.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If txtRefNo.EditValue Is Nothing OrElse txtRefNo.EditValue = "" Then
                txtRefNo.Focus()
                MsgBox("Please enter reference number.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If txtCompanyRegistration.EditValue Is Nothing OrElse txtCompanyRegistration.EditValue = "" Then
                txtCompanyRegistration.Focus()
                MsgBox("Please enter company registration number.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If dtBasisPeriodFrom.EditValue Is Nothing Then
                dtBasisPeriodFrom.Focus()
                MsgBox("Please enter basis period.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If dtBasisPeriodTo.EditValue Is Nothing Then
                dtBasisPeriodTo.Focus()
                MsgBox("Please enter basis period.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If DateDiff(DateInterval.Day, dtBasisPeriodFrom.EditValue, dtBasisPeriodTo.EditValue) < 0 Then
                dtBasisPeriodTo.Focus()
                MsgBox("Basis period from cannot more than basis period to.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If dtAccountFrom.EditValue Is Nothing Then
                dtAccountFrom.Focus()
                MsgBox("Please enter account period.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If dtAccountTo.EditValue Is Nothing Then
                dtBasisPeriodTo.Focus()
                MsgBox("Please enter account period.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If DateDiff(DateInterval.Day, dtAccountFrom.EditValue, dtAccountTo.EditValue) < 0 Then
                dtBasisPeriodTo.Focus()
                MsgBox("Acount period from cannot more than account period to.", MsgBoxStyle.Exclamation)
                Return False
            End If


            If txt_RegAddress1.EditValue Is Nothing OrElse txt_RegAddress1.EditValue = "" Then
                txt_RegAddress1.Focus()
                MsgBox("Please enter registration address.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If txt_RegPostcode.EditValue Is Nothing OrElse txt_RegPostcode.EditValue = "" Then
                txt_RegPostcode.Focus()
                MsgBox("Please enter registration postcode.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If cbo_RegState.EditValue Is Nothing Then
                cbo_RegState.Focus()
                MsgBox("Please enter registration state.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If cbo_RegCountry.EditValue Is Nothing Then
                cbo_RegCountry.Focus()
                MsgBox("Please enter registration country.", MsgBoxStyle.Exclamation)
                Return False
            End If
            '============================================================================
            If txt_CorrAddress1.EditValue Is Nothing OrElse txt_CorrAddress1.EditValue = "" Then
                txt_CorrAddress1.Focus()
                MsgBox("Please enter correspondence address.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If txt_CorrPostcode.EditValue Is Nothing OrElse txt_CorrPostcode.EditValue = "" Then
                txt_CorrPostcode.Focus()
                MsgBox("Please enter correspondence postcode.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If cbo_CorrState.EditValue Is Nothing Then
                cbo_CorrState.Focus()
                MsgBox("Please enter correspondence state.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If cbo_CorrCountry.EditValue Is Nothing Then
                cbo_CorrCountry.Focus()
                MsgBox("Please enter correspondence country.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If isEdit = False Then
                If ADO.Load_TaxPayer_Exist(txtRefNo.EditValue, ErrorLog) Then
                    txtRefNo.Focus()
                    MsgBox("Reference number already exist.", MsgBoxStyle.Exclamation)
                    Return False
                End If
            End If

            If chkClaimSec127.Items(2).CheckState = CheckState.Checked AndAlso (chkClaimSec127.Items(0).CheckState = CheckState.Checked Or chkClaimSec127.Items(1).CheckState = CheckState.Checked) Then
                chkClaimSec127.Focus()
                MsgBox("Claim section 127 cannot tick 'Not Relevant' and 'Paragraph 127, Subsection 127' together.", MsgBoxStyle.Exclamation)
                Return False
            End If
            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            Return False
        End Try
    End Function




    Private Sub txtDetailsTaxFee_EditValueChanged(sender As Object, e As EventArgs) Handles txtDetailsTaxFee.EditValueChanged, txtSalesTax.EditValueChanged, txtDisbursement.EditValueChanged
        Try

            Dim Total As Decimal = 0

            If txtDetailsTaxFee.EditValue IsNot Nothing AndAlso IsNumeric(txtDetailsTaxFee.EditValue) Then
                Total += CDec(txtDetailsTaxFee.EditValue)
            End If
            If txtSalesTax.EditValue IsNot Nothing AndAlso IsNumeric(txtSalesTax.EditValue) Then
                Total += CDec(txtSalesTax.EditValue)
            End If
            If txtDisbursement.EditValue IsNot Nothing AndAlso IsNumeric(txtDisbursement.EditValue) Then
                Total += CDec(txtDisbursement.EditValue)
            End If

            txtTotal.EditValue = Total
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub dgvBusinessSource_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles dgvBusinessSource.CellValueChanged
        Try
            If e.Column.FieldName = "BC_CODE" Then
                Dim row As DataRow = dgvBusinessSource.GetDataRow(dgvBusinessSource.FocusedRowHandle)

                If row IsNot Nothing Then

                    For Each rowx As DataRow In DsDefault.Tables("BUSINESS").Rows
                        If IsDBNull(rowx("BS_CODE")) = False AndAlso IsDBNull(rowx("BS_TYPE")) = False Then

                            If rowx("BS_CODE") = row("BC_CODE") Then
                                row("BC_TYPE") = rowx("BS_TYPE")
                            End If

                        End If
                    Next
                End If
            End If


        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub dgvPartnership_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles dgvPartnership.CellValueChanged
        Try
            If e.Column.FieldName = "PS_CODE" Then
                Dim row As DataRow = dgvPartnership.GetDataRow(dgvPartnership.FocusedRowHandle)

                If row IsNot Nothing Then

                    For Each rowx As DataRow In DsDefault.Tables("BUSINESS").Rows
                        If IsDBNull(rowx("BS_CODE")) = False AndAlso IsDBNull(rowx("BS_TYPE")) = False Then

                            If rowx("BS_CODE") = row("PS_CODE") Then
                                row("PS_TYPE") = rowx("BS_TYPE")
                            End If

                        End If
                    Next
                End If
            End If


        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub
End Class