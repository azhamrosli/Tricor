Imports System.Data.SqlClient

Module mdlCA
    Dim ADO As SQLDataObject
    Private strRefNo As String = Nothing
    Private strCYa As String = Nothing
    Private strPNLKey As Integer = 0
    Private strSourceNo As String = ""
    Private strMainBuz As Integer = 0

    Private drLstview As DataTable = Nothing
    Private drPartnerIncome As DataTable = Nothing
    Private dtRAOpeningBalance As DataTable = Nothing
    Private drOpeningBalance As DataTable = Nothing
    Private dtOpeningBalanceNextYA As DataTable = Nothing
    Private dtLessApprDonation As DataTable = Nothing
    Private drCA_sourceNum As DataTable = Nothing
    Private drCA_AA_IARate As DataTable = Nothing
    Private drCADisposal As DataTable = Nothing
    Private drCADisposalBABCNonHP As DataTable = Nothing
    Private drCADisposalBABCHP As DataTable = Nothing
    Private drTCUnabsorbedBusinessLoss As DataTable = Nothing
    Private drPartnerLoss As DataTable = Nothing
    Private drGetDTApprDonation As DataTable = Nothing
    Private drGetDTApprDonationDetail As DataTable = Nothing
    Private drBusinessSource As DataTable = Nothing
#Region "LOAD"
    Private Function GetBoolPLS60FA(Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT PL_S60FA FROM [PROFIT_LOSS_ACCOUNT] WHERE [PL_REF_NO] = @refno AND [PL_YA] = @cya"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@cya", SqlDbType.NVarChar, 5).Value = strCYa

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("PL_S60FA")) = False AndAlso dt.Rows(0)("PL_S60FA") = "Y" Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return False
        End Try
    End Function
    Private Function GetDTCA_SourceNum(Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT DISTINCT CA_SOURCENO FROM [CA] WHERE [CA_REF_NO]= @refno AND cast([CA_YA] as money) <= @cya ORDER BY [CA_SOURCENO]"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@cya", SqlDbType.NVarChar, 5).Value = strCYa

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return Nothing
        End Try
    End Function
    Private Function GetDTCA_AA_IARate(ByVal strkey_array() As String, ByVal I As Long, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT [CA_KEY], [CA_RATE_AA], [CA_RATE_IA], [CA_QUALIFYING_COST], [CA_YA], [CA_MODE], [CA_PURCHASE_YEAR], [CA_TWDV], [CA_ACCELERATED] FROM [CA] WHERE [CA_REF_NO]= @refno AND cast([CA_YA] as money) <= @cya AND ([CA_SOURCENO]) = @sourceno"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL

            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@cya", SqlDbType.NVarChar, 5).Value = strCYa
            SQLcmd.Parameters.Add("@sourceno", SqlDbType.Decimal).Value = CInt(strkey_array(I))

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return Nothing
        End Try
    End Function
    Private Function GetDTCADisposal(ByVal strCAKEY As String, ByVal strCAYA As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT COUNT(CA_KEY) AS C_CAKEY, SUM(cast(CA_DISP_QC as money)) AS S_CADISPQC, SUM(cast(CA_DISP_TWDV as money)) AS S_CADISPTWDV FROM CA_DISPOSAL where [CA_DISP_YA] = @cya and [CA_KEY]= @cakey"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@cya", SqlDbType.NVarChar, 5).Value = strCAYA
            SQLcmd.Parameters.Add("@cakey", SqlDbType.Int).Value = strCAKEY

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return Nothing
        End Try
    End Function
    Private Function GetDTCADisposalBABCNonHP(ByVal strkey_array() As String, ByVal I As Long, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT [CA_DISP_BABC] FROM [CA_DISPOSAL] AS [D] WHERE D.CA_KEY IN (SELECT [CA_KEY] FROM CA WHERE [CA_REF_NO]= @refno AND [CA_SOURCENO] = @sourceno AND [HP_CODE] = '') AND [CA_DISP_YA]= @dispya ORDER BY [CA_DISP_KEY]"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@dispya", SqlDbType.NVarChar, 5).Value = strCYa
            SQLcmd.Parameters.Add("@sourceno", SqlDbType.Decimal).Value = CInt(strkey_array(I))

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return Nothing
        End Try
    End Function
    Private Function GetDTCADisposalBABCHP(ByVal strkey_array() As String, ByVal I As Long, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT SUM(cast(BABC as money)) AS CA_BABC,  HP_CODE FROM (select ca_disposal.ca_disp_ya as YA, ca_disposal.ca_disp_babc as babc , ca.hp_code as hp_code from ca_disposal inner join ca on ca_disposal.ca_key = ca.ca_key where ca.ca_ref_no=@refno and ca.ca_sourceno=@sourceno ) a WHERE HP_CODE IN (select distinct c.hp_code from ca c) AND HP_CODE <> '' AND YA=@dispya GROUP BY HP_CODE"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@dispya", SqlDbType.NVarChar, 5).Value = strCYa
            SQLcmd.Parameters.Add("@sourceno", SqlDbType.Decimal).Value = CInt(strkey_array(I))

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return Nothing
        End Try
    End Function
    Private Function GetBoolChkMajorC(Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT TC_CB_CHECK FROM [TAX_COMPUTATION] WHERE [TC_REF_NO]= @refno AND [TC_YA]= @cya"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@cya", SqlDbType.NVarChar, 5).Value = strCYa


            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("TC_CB_CHECK")) = False AndAlso dt.Rows(0)("TC_CB_CHECK") = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return False
        End Try
    End Function
    Private Function Load_PNL(Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM [PROFIT_LOSS_ACCOUNT] WHERE [PL_REF_NO]= @refno AND [PL_YA]= @cya"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@cya", SqlDbType.NVarChar, 5).Value = strCYa

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return Nothing
        End Try
    End Function
    Private Function Load_INT_AMOUNT_INTEREST_INCOME(ByVal TC_KEY As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT isnull(sum(cast([INT_AMOUNT] as money)), '0') as [INT_TOTAL] FROM [INTEREST_INCOME] WHERE [INT_KEY] = @key"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = TC_KEY

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return Nothing
        End Try
    End Function
    Private Function Load_SUN_AMOUNT_SUN_TOTAL(ByVal TC_KEY As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT isnull(sum(cast([SUN_AMOUNT] as money)), '0') as [SUN_TOTAL] FROM [SUNDRY_INCOME] WHERE [SUN_KEY] = @key"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = TC_KEY

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return Nothing
        End Try
    End Function
    Private Function GetDTTCUnabsorbedBusinessLoss(Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM [TAX_COMPUTATION] WHERE [TC_REF_NO]= @refno AND [TC_YA]= @cya ORDER BY [TC_BUSINESS]"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@cya", SqlDbType.NVarChar, 5).Value = strCYa

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return Nothing
        End Try
    End Function
    Private Function GetPartnerLoss_LstView(ByVal strKey As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "Select sum(cast(PN_ADJ_LOSS as money)) AS PARTNER_LOSS FROM [INCOME_PARTNERSHIP] WHERE [TCP_KEY] = @strKey"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@strKey", SqlDbType.Int).Value = strKey

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return Nothing
        End Try
    End Function
    Private Function GetDTApprDonation(ByVal strPLKEYs As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM [OTHER_EXAPPRDONATION] WHERE [EXOAD_KEY] = @plkey"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@plkey", SqlDbType.Int).Value = CInt(strPLKEYs)


            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return Nothing
        End Try
    End Function
   Private Function GetDTApprDonationDetail(ByVal strPLKEYs As Integer, ByVal strBusiness As String, ByVal strEXOADKEY As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM [OTHER_EXAPPRDONATION_DETAIL] WHERE [EXOADD_KEY] = @plkey AND [EXOADD_SOURCENO] = @business AND [EXOADD_EXOADKEY]= @exoadkey"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@plkey", SqlDbType.Int).Value = CInt(strPLKEYs)
            SQLcmd.Parameters.Add("@business", SqlDbType.Int).Value = CInt(strBusiness)
            SQLcmd.Parameters.Add("@exoadkey", SqlDbType.Int).Value = CInt(strEXOADKEY)

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return Nothing
        End Try
    End Function
    Private Function GetDTZakat(ByVal strPLKEYs As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT EXOZ_AMOUNT FROM [OTHER_EXZAKAT] WHERE [EXOZ_KEY]= @plkey AND [EXOZ_DEDUCTIBLE]='Yes'"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@plkey", SqlDbType.Int).Value = CInt(strPLKEYs)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("EXOZ_AMOUNT")) = False Then
                Dim dbl As Double = 0
                For Each dr As DataRow In dt.Rows
                    dbl += IIf(IsDBNull(dr("EXOZ_AMOUNT")), 0, CDbl(dr("EXOZ_AMOUNT")))
                Next
                Return dbl
            Else
                Return 0
            End If

        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Private Function GetBoolSME(Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT [SME] FROM [BALANCE_SHEET] WHERE [BS_REF_NO]= @refno AND [BS_YA]= @cya"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@cya", SqlDbType.NVarChar, 5).Value = strCYa

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("SME")) = False Then
                If dt.Rows(0)("SME") = "1" Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return False
        End Try
    End Function
    Private Function GetTCBusinessSource(Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select tc_business from tax_computation where tc_ref_no=@refno and tc_ya=@ya order by tc_business"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@ya", SqlDbType.NVarChar, 5).Value = strCYa

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return Nothing
        End Try
    End Function

    Public Function GetAJDTotalExpOtherInterest(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exi_amount as money))),0) as sumx from expenses_interest where exi_key=@key and exi_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exi_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpContractPay(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exc_amount as money))),0) from expenses_contract where exc_key=@key and exc_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exc_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpDirectorFee(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exdf_amount as money))),0) from expenses_directors_fee where exdf_key=@key and exdf_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exdf_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpTechnicalFee(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(extf_amount as money))),0) from expenses_tech_fee where extf_key=@key and extf_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and extf_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpSalary(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exs_amount as money))),0) from expenses_salary where exs_key=@key and exs_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exs_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpRoyalty(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exro_amount as money))),0) from expenses_royalty where exro_key=@key and exro_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exro_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpRental(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exrent_amount as money))),0) from expenses_rental where exrent_key=@key and exrent_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exrent_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpRepairMaintenance(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exrep_amount as money))),0) from expenses_repair where exrep_key=@key and exrep_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exrep_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpRND(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exres_amount as money))),0) from expenses_research where exres_key=@key and exres_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exres_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpPromotionAdvertisement(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exp_amount as money))),0) from expenses_promote where exp_key=@key and exp_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exp_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpTravel(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(ext_amount as money))),0) from expenses_travel where ext_key=@key and ext_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and ext_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpJKDM(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exjk_amount as money))),0) from expenses_jkdm where exjk_key=@key and exjk_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exjk_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpEmployeeStock(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exes_amount as money))),0) from expenses_empl_stock where exes_key=@key and exes_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exes_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpLegal(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exl_amount as money))),0) from expenses_legal where exl_key=@key and exl_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exl_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpEntertainStaff(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exoes_amount as money))),0) from other_entertainstaff where exoes_key=@key and exoes_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exl_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpOthersExpenses(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exo_amount as money))),0) from other_expenses where exo_key=@key and exo_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exo_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpDepreciation(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exodep_amount as money))),0) from other_exdepreciation where exodep_key=@key and exodep_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exodep_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpEntertainNonStaff(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exoens_amount as money))),0) from other_entertainnstaff where exoens_key=@key and exoens_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exoens_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpProvision(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exopa_amount as money))),0) from other_exprovisionacc where exopa_key=@key and exopa_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exopa_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpCompoundPenalty(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exop_amount as money))),0) from other_expenalty where exop_key=@key and exop_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exop_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpLeavePassage(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exolp_amount as money))),0) from other_exleavepassage where exolp_key=@key and exolp_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exolp_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpFAWrittenOff(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exowo_amount as money))),0) from other_exfawrittenoff where exowo_key=@key and exowo_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exowo_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpInitialSubscript(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exois_amount as money))),0) from other_exinitialsub where exois_key=@key and exois_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exois_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpCapitalExpenditure(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exoce_amount as money))),0) from other_excapitalexp where exoce_key=@key and exoce_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exoce_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalDepreciation(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exdep_amount as money))),0) from expenses_depreciation where exdep_key = @key and exdep_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exdep_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalOtherNonAllowExpenses(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exna_amount as money))),0) from expenses_nonallow where exna_key = @key and exna_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exna_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalPurchases(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(plfpur_amount as money))),0) from plfst_purchase where plfpur_key=@key and plfpur_sourceno=@sourceno"

            If strDeductible <> "" Then
                StrSQL += " and plfpur_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpDonationNonApproved(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exonad_amount as money))),0) from other_exnapprdonation where exonad_key=@key and exonad_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exonad_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpInterestRestrict(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exir_amount as money))),0) from expenses_interestrestrict where exir_key=@data and exir_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exir_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpUnrealLossFE(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exour_amount as money))),0) from other_exurlossforeign where exour_key=@key and exour_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exour_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpRealLossFENonTrade(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exor_amount as money))),0) from other_exrlossforeign where exor_key=@key and exor_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exor_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpLossDisposalFA(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exold_amount as money))),0) from other_exlossdisposalfa where exold_key=@key and exold_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exold_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalOtherExrLossForeignt(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exort_amount as money))),0) from other_exrlossforeignt where exort_key=@key and exort_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exort_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpDonationApproved(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exoad_amount as money))),0) from other_exapprdonation where exoad_key=@key and exoad_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exoad_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpZakat(ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exoz_amount as money))),0) from other_exzakat where exoz_key=@key and exoz_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exoz_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = strPNLKey
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo
            SQLcmd.Parameters.Add("@ded", strDeductible)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function GetTotalNonAllowLoss(Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum(cast([NL_AMOUNT] as money))),0) as sumx FROM [NON_ALLOW_LOSS] WHERE [NL_REF_NO]=@refno AND [NL_YA]=@ya AND [NL_SOURCENO]=@source AND [NL_CATEGORIZED]=''"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@ya", SqlDbType.NVarChar, 5).Value = strCYa
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = strSourceNo


            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
            End If
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
#End Region
#Region "UPDATE"
    Public Function Update_TAXCOMPUTATION(ByVal TC_BUSINESS As Integer, _
                                                ByVal TC_SI_ADJ_BS_IN As Double, _
                                                ByVal TC_CB_CA_BAL_BF As Double, _
                                                ByVal TC_RA_BALANCINGALLOWANCE As Double, _
                                                ByVal TC_ITA_BALANCINGALLOWANCE As Double, _
                                                ByVal TC_RA_TOTAL1 As Double, ByVal TC_ITA_TOTAL1 As Double, _
                                                ByVal TC_CB_RA_BAL_BF As Double, ByVal TC_CB_RA_BAL_CF As Double, _
                                                ByVal TC_CB_ITA_BAL_BF As Double, _
                                                ByVal TC_CB_ITA_BAL_CF As Double, ByVal TC_CB_CA_AA As Double, _
                                                ByVal TC_CB_CA_IA As Double, _
                                                ByVal TC_CB_CA_BA As Double, _
                                                ByVal TC_SI_BC As Double, ByVal TC_CB_CA_CURR As Double, _
                                                ByVal TC_CB_CA_CURR_BA As Double, ByVal TC_CB_CA_UTIL As Double, _
                                                ByVal TC_SI_CA As Double, ByVal TC_CB_CA_BAL_CF As Double, _
                                                ByVal TC_CB_CA_DISALLOW As Double, ByVal TC_CB_CA_ABAL_CF As Double, _
                                                ByVal TC_CB_CA_ACA As Double, ByVal TC_SI_STAT_BS_IN As Double, _
                                                ByVal TC_SI_NET_STAT_IN As Double, ByVal TC_CB_RA_BAL_BF_CURR As Double, _
                                                ByVal TC_CB_ITA_BAL_BF_CURR As Double, ByVal TC_NB_DIV As Double, _
                                                ByVal TC_NB_INT As Double, ByVal TC_NB_RENT As Double, _
                                                ByVal TC_TP_SEC110 As Double, ByVal TC_NB_ROYALTY As Double, _
                                                ByVal TC_NB_SUNDRY As Double, ByVal TC_NB_DIV_NET As Double, _
                                                ByVal TC_NB_INT_NET As Double, ByVal TC_NB_RENT_NET As Double, _
                                                ByVal TC_NB_OTH_AGGR_STAT As Double, ByVal TC_STAT_DIVIDEND As Double, _
                                                ByVal TC_CB_LS_BAL_BF As Double, ByVal TC_SI_ADJ_BS_IN_BC As Double, _
                                                ByVal TC_NB_RENTIBA As Double, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "UPDATE [TAX_COMPUTATION] SET [TC_SI_ADJ_BS_IN]=@TC_SI_ADJ_BS_IN, [TC_CB_CA_BAL_BF]=@TC_CB_CA_BAL_BF, [TC_RA_BALANCINGALLOWANCE]=@TC_RA_BALANCINGALLOWANCE, [TC_ITA_BALANCINGALLOWANCE]=@TC_ITA_BALANCINGALLOWANCE, [TC_RA_TOTAL1]=@TC_RA_TOTAL1, [TC_ITA_TOTAL1]=@TC_ITA_TOTAL1, [TC_CB_RA_BAL_BF]=@TC_CB_RA_BAL_BF, [TC_CB_RA_BAL_CF]=@TC_CB_RA_BAL_CF, [TC_CB_ITA_BAL_BF]=@TC_CB_ITA_BAL_BF, [TC_CB_ITA_BAL_CF]=@TC_CB_ITA_BAL_CF, [TC_CB_CA_AA]=@TC_CB_CA_AA, [TC_CB_CA_IA]=@TC_CB_CA_IA, [TC_CB_CA_BA]=@TC_CB_CA_BA, [TC_SI_BC]=@TC_SI_BC, [TC_CB_CA_CURR]=@TC_CB_CA_CURR, [TC_CB_CA_CURR_BA]=@TC_CB_CA_CURR_BA, [TC_CB_CA_UTIL]=@TC_CB_CA_UTIL, [TC_SI_CA]=@TC_SI_CA, [TC_CB_CA_BAL_CF]=@TC_CB_CA_BAL_CF, [TC_CB_CA_DISALLOW]=@TC_CB_CA_DISALLOW, [TC_CB_CA_ABAL_CF]=@TC_CB_CA_ABAL_CF, [TC_CB_CA_ACA]=@TC_CB_CA_ACA, [TC_SI_STAT_BS_IN]=@TC_SI_STAT_BS_IN, [TC_SI_NET_STAT_IN]=@TC_SI_NET_STAT_IN, [TC_CB_RA_BAL_BF_CURR]=@TC_CB_RA_BAL_BF_CURR, [TC_CB_ITA_BAL_BF_CURR]=@TC_CB_ITA_BAL_BF_CURR, [TC_NB_DIV]=@TC_NB_DIV, [TC_NB_INT]=@TC_NB_INT, [TC_NB_RENT]=@TC_NB_RENT, [TC_TP_SEC110]=@TC_TP_SEC110, [TC_NB_ROYALTY]=@TC_NB_ROYALTY, [TC_NB_SUNDRY]=@TC_NB_SUNDRY, [TC_NB_DIV_NET]=@TC_NB_DIV_NET, [TC_NB_INT_NET]=@TC_NB_INT_NET, [TC_NB_RENT_NET]=@TC_NB_RENT_NET, [TC_NB_OTH_AGGR_STAT]=@TC_NB_OTH_AGGR_STAT, [TC_STAT_DIVIDEND]=@TC_STAT_DIVIDEND, [TC_CB_LS_BAL_BF]=@TC_CB_LS_BAL_BF, [TC_SI_ADJ_BS_IN_BC]=@TC_SI_ADJ_BS_IN_BC, [TC_NB_RENTIBA]=@TC_NB_RENTIBA WHERE [TC_REF_NO]=@refno AND [TC_YA]=@ya AND [TC_BUSINESS]=@sourceno"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL

            SQLcmd.Parameters.Add("@TC_SI_ADJ_BS_IN", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_SI_ADJ_BS_IN, 0)
            SQLcmd.Parameters.Add("@TC_CB_CA_BAL_BF", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_CA_BAL_BF, 0)
            SQLcmd.Parameters.Add("@TC_RA_BALANCINGALLOWANCE ", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_RA_BALANCINGALLOWANCE, 0)
            SQLcmd.Parameters.Add("@TC_ITA_BALANCINGALLOWANCE", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_ITA_BALANCINGALLOWANCE, 0)
            SQLcmd.Parameters.Add("@TC_RA_TOTAL1", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_RA_TOTAL1, 0)
            SQLcmd.Parameters.Add("@TC_ITA_TOTAL1", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_ITA_TOTAL1, 0)
            SQLcmd.Parameters.Add("@TC_CB_RA_BAL_BF", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_RA_BAL_BF, 0)
            SQLcmd.Parameters.Add("@TC_CB_RA_BAL_CF", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_RA_BAL_CF, 0)
            SQLcmd.Parameters.Add("@TC_CB_ITA_BAL_BF", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_ITA_BAL_BF, 0)
            SQLcmd.Parameters.Add("@TC_CB_ITA_BAL_CF", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_ITA_BAL_CF, 0)
            SQLcmd.Parameters.Add("@TC_CB_CA_AA", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_CA_AA, 0)
            SQLcmd.Parameters.Add("@TC_CB_CA_IA", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_CA_IA, 0)
            SQLcmd.Parameters.Add("@TC_CB_CA_BA", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_CA_BA, 0)
            SQLcmd.Parameters.Add("@TC_SI_BC", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_SI_BC, 0)
            SQLcmd.Parameters.Add("@TC_CB_CA_CURR", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_CA_CURR, 0)
            SQLcmd.Parameters.Add("@TC_CB_CA_CURR_BA", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_CA_CURR_BA, 0)
            SQLcmd.Parameters.Add("@TC_CB_CA_UTIL", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_CA_UTIL, 0)
            SQLcmd.Parameters.Add("@TC_SI_CA", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_SI_CA, 0)
            SQLcmd.Parameters.Add("@TC_CB_CA_BAL_CF", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_CA_BAL_CF, 0)
            SQLcmd.Parameters.Add("@TC_CB_CA_DISALLOW", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_CA_DISALLOW, 0)
            SQLcmd.Parameters.Add("@TC_CB_CA_ABAL_CF", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_CA_ABAL_CF, 0)
            SQLcmd.Parameters.Add("@TC_CB_CA_ACA", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_CA_ACA, 0)
            SQLcmd.Parameters.Add("@TC_SI_STAT_BS_IN", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_SI_STAT_BS_IN, 0)
            SQLcmd.Parameters.Add("@TC_SI_NET_STAT_IN", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_SI_NET_STAT_IN, 0)
            SQLcmd.Parameters.Add("@TC_CB_RA_BAL_BF_CURR", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_RA_BAL_BF_CURR, 0)
            SQLcmd.Parameters.Add("@TC_CB_ITA_BAL_BF_CURR", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_ITA_BAL_BF_CURR, 0)
            SQLcmd.Parameters.Add("@TC_NB_DIV", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_NB_DIV, 0)
            SQLcmd.Parameters.Add("@TC_NB_INT", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_NB_INT, 0)
            SQLcmd.Parameters.Add("@TC_NB_RENT", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_NB_RENT, 0)
            SQLcmd.Parameters.Add("@TC_TP_SEC110", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_TP_SEC110, 0)
            SQLcmd.Parameters.Add("@TC_NB_ROYALTY", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_NB_ROYALTY, 0)
            SQLcmd.Parameters.Add("@TC_NB_SUNDRY", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_NB_SUNDRY, 0)
            SQLcmd.Parameters.Add("@TC_NB_DIV_NET", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_NB_DIV_NET, 0)
            SQLcmd.Parameters.Add("@TC_NB_INT_NET", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_NB_INT_NET, 0)
            SQLcmd.Parameters.Add("@TC_NB_RENT_NET", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_NB_RENT_NET, 0)
            SQLcmd.Parameters.Add("@TC_NB_OTH_AGGR_STAT", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_NB_OTH_AGGR_STAT, 0)
            SQLcmd.Parameters.Add("@TC_STAT_DIVIDEND", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_STAT_DIVIDEND, 0)
            SQLcmd.Parameters.Add("@TC_CB_LS_BAL_BF", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_LS_BAL_BF, 0)
            SQLcmd.Parameters.Add("@TC_SI_ADJ_BS_IN_BC", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_SI_ADJ_BS_IN_BC, 0)
            SQLcmd.Parameters.Add("@TC_NB_RENTIBA", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_NB_RENTIBA, 0)
            SQLcmd.Parameters.Add("@refno", strRefNo)
            SQLcmd.Parameters.Add("@ya", strCYa)
            SQLcmd.Parameters.Add("@sourceno", SqlDbType.Int).Value = FormatNumber(TC_BUSINESS, 0)

            Return ADO.ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return False
        End Try
    End Function
    Public Function Update_OBSchudule(ByVal OB_SCHEDULE_NYA As Double, ByVal TC_BUSINESS As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "UPDATE [OPENING_BALANCE] SET [OB_SCHEDULE]=@data WHERE [OB_REF_NO]=@refno AND [OB_YA]=@ya AND [OB_SOURCENO]=@sourceno"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@sourceno", SqlDbType.NVarChar, 25).Value = TC_BUSINESS
            SQLcmd.Parameters.Add("@data", SqlDbType.NVarChar, 3).Value = OB_SCHEDULE_NYA
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@ya", SqlDbType.NVarChar, 5).Value = (CInt(strCYa) + 1).ToString


            Return ADO.ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return False
        End Try
    End Function
    Public Function Update_TAXCOMPUTATION_TC_SI_TOT(ByVal TC_SI_TOT As Double, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "UPDATE [TAX_COMPUTATION] SET [TC_SI_TOT]=@TC_SI_TOT WHERE [TC_REF_NO]=@refno AND [TC_YA]=@ya AND [TC_BUSINESS]=@sourceno"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@ya", SqlDbType.NVarChar, 5).Value = strCYa
            SQLcmd.Parameters.Add("@sourceno", SqlDbType.Int).Value = 1

            Return ADO.ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return False
        End Try
    End Function
    Public Function Update_AggregateTAXCOMPATION(ByVal TC_SI_BS_LOSS_BF As Double, _
                                                ByVal TC_CB_LS_UTIL As Double, _
                                                ByVal TC_SI_AGGREGATE As Double, _
                                                ByVal TC_CB_LS_BAL_UTIL As Double, _
                                                ByVal TC_CB_LS_ADJUST_LOSS As Double, ByVal TC_TP_AGGR_IN As Double, _
                                                ByVal TC_TP_CURR_LOSS As Double, ByVal TC_CB_LS_UTIL_CURR As Double, _
                                                ByVal TC_CB_LS_UNABSORBED As Double, ByVal TC_CB_LS_BAL_CF As Double, _
                                                ByVal TC_CB_LS_BALS_CF As Double, ByVal TC_TP_TOTAL_OTH_EXP As Double, _
                                                ByVal TC_TP_APRV_DONATION As Double, ByVal TC_TP_ZAKAT As Double, _
                                                ByVal TC_TP_TOTAL_INCOME As Double, ByVal TC_TP_CHARGEABLE As Double, _
                                                ByVal TC_TP_APP_CHARGEABLE4A As Double, ByVal TC_TP_APP_CHARGEABLE5 As Double, _
                                                ByVal TC_TP_RATE4A_CHARGEABLE As Double, ByVal TC_TP_28_CHARGEABLE As Double, _
                                                ByVal TC_TP_TOT_TAX_CHARGED As Double, ByVal TC_TP_TOT_SETOFF As Double, _
                                                ByVal TC_TP_PAYABLE As Double, ByVal TC_TP_INCOME_TP2 As Double, _
                                                ByVal TC_TP_PAYABLE_BAL As Double, ByVal TC_TP_INCOME_TP3 As Double, _
                                                ByVal TC_TP_ALL_DIFF As Double, _
                                                ByVal TC_TP_EX_DIFF As Double, ByVal TC_TP_PEN_DIFF As Double, _
                                                ByVal TC_TP_AGGR_IN_LOSS As Double, Optional ByRef ErrorLog As clsError = Nothing) As Boolean

        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "UPDATE [TAX_COMPUTATION] SET [TC_SI_BS_LOSS_BF]=@TC_SI_BS_LOSS_BF, [TC_CB_LS_UTIL]=@TC_CB_LS_UTIL, [TC_SI_AGGREGATE]=@TC_SI_AGGREGATE, [TC_CB_LS_BAL_UTIL]=@TC_CB_LS_BAL_UTIL, [TC_CB_LS_ADJUST_LOSS]=@TC_CB_LS_ADJUST_LOSS, [TC_TP_AGGR_IN]=@TC_TP_AGGR_IN, [TC_TP_CURR_LOSS]=@TC_TP_CURR_LOSS, [TC_CB_LS_UTIL_CURR]=@TC_CB_LS_UTIL_CURR, [TC_CB_LS_UNABSORBED]=@TC_CB_LS_UNABSORBED, [TC_CB_LS_BAL_CF]=@TC_CB_LS_BAL_CF, [TC_CB_LS_BALS_CF]=@TC_CB_LS_BALS_CF, [TC_TP_TOTAL_OTH_EXP]=@TC_TP_TOTAL_OTH_EXP, [TC_TP_APRV_DONATION]=@TC_TP_APRV_DONATION, [TC_TP_ZAKAT]=@TC_TP_ZAKAT, [TC_TP_TOTAL_INCOME]=@TC_TP_TOTAL_INCOME, [TC_TP_CHARGEABLE]=@TC_TP_CHARGEABLE, [TC_TP_APP_CHARGEABLE4A]=@TC_TP_APP_CHARGEABLE4A, [TC_TP_APP_CHARGEABLE5]=@TC_TP_APP_CHARGEABLE5, [TC_TP_RATE4A_CHARGEABLE]=@TC_TP_RATE4A_CHARGEABLE, [TC_TP_28_CHARGEABLE]=@TC_TP_28_CHARGEABLE, [TC_TP_TOT_TAX_CHARGED]=@TC_TP_TOT_TAX_CHARGED, [TC_TP_TOT_SETOFF]=@TC_TP_TOT_SETOFF, [TC_TP_PAYABLE]=@TC_TP_PAYABLE, [TC_TP_INCOME_TP2]=@TC_TP_INCOME_TP2, [TC_TP_PAYABLE_BAL]=@TC_TP_PAYABLE_BAL, [TC_TP_INCOME_TP3]=@TC_TP_INCOME_TP3, [TC_TP_ALL_DIFF]=@TC_TP_ALL_DIFF, [TC_TP_EX_DIFF]=@TC_TP_EX_DIFF, [TC_TP_PEN_DIFF]=@TC_TP_PEN_DIFF, [TC_TP_AGGR_IN_LOSS]=@TC_TP_AGGR_IN_LOSS WHERE TC_REF_NO=@refno AND TC_YA=@ya AND TC_BUSINESS=@sourceno"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL

            SQLcmd.Parameters.Add("@TC_SI_BS_LOSS_BF", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_SI_BS_LOSS_BF, 0)
            SQLcmd.Parameters.Add("@TC_CB_LS_UTIL", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_LS_UTIL, 0)
            SQLcmd.Parameters.Add("@TC_SI_AGGREGATE", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_SI_AGGREGATE, 0)
            SQLcmd.Parameters.Add("@TC_CB_LS_BAL_UTIL", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_LS_BAL_UTIL, 0)
            SQLcmd.Parameters.Add("@TC_CB_LS_ADJUST_LOSS", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_LS_ADJUST_LOSS, 0)
            SQLcmd.Parameters.Add("@TC_TP_AGGR_IN", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_TP_AGGR_IN, 0)
            SQLcmd.Parameters.Add("@TC_TP_CURR_LOSS", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_TP_CURR_LOSS, 0)
            SQLcmd.Parameters.Add("@TC_CB_LS_UTIL_CURR", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_LS_UTIL_CURR, 0)
            SQLcmd.Parameters.Add("@TC_CB_LS_UNABSORBED", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_LS_UNABSORBED, 0)
            SQLcmd.Parameters.Add("@TC_CB_LS_BAL_CF", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_LS_BAL_CF, 0)
            SQLcmd.Parameters.Add("@TC_CB_LS_BALS_CF", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_CB_LS_BALS_CF, 0)
            SQLcmd.Parameters.Add("@TC_TP_TOTAL_OTH_EXP", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_TP_TOTAL_OTH_EXP, 0)
            SQLcmd.Parameters.Add("@TC_TP_APRV_DONATION", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_TP_APRV_DONATION, 0)
            SQLcmd.Parameters.Add("@TC_TP_ZAKAT", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_TP_ZAKAT, 0)
            SQLcmd.Parameters.Add("@TC_TP_TOTAL_INCOME", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_TP_TOTAL_INCOME, 0)
            SQLcmd.Parameters.Add("@TC_TP_CHARGEABLE", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_TP_CHARGEABLE, 0)
            SQLcmd.Parameters.Add("@TC_TP_APP_CHARGEABLE4A", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_TP_APP_CHARGEABLE4A, 0)
            SQLcmd.Parameters.Add("@TC_TP_APP_CHARGEABLE5", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_TP_APP_CHARGEABLE5, 0)
            SQLcmd.Parameters.Add("@TC_TP_RATE4A_CHARGEABLE", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_TP_RATE4A_CHARGEABLE, 2)
            SQLcmd.Parameters.Add("@TC_TP_28_CHARGEABLE", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_TP_28_CHARGEABLE, 2)
            SQLcmd.Parameters.Add("@TC_TP_TOT_TAX_CHARGED", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_TP_TOT_TAX_CHARGED, 2)
            SQLcmd.Parameters.Add("@TC_TP_TOT_SETOFF", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_TP_TOT_SETOFF, 2)
            SQLcmd.Parameters.Add("@TC_TP_PAYABLE", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_TP_PAYABLE, 2)
            SQLcmd.Parameters.Add("@TC_TP_INCOME_TP2", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_TP_INCOME_TP2, 2)
            SQLcmd.Parameters.Add("@TC_TP_PAYABLE_BAL", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_TP_PAYABLE_BAL, 2)
            SQLcmd.Parameters.Add("@TC_TP_INCOME_TP3", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_TP_INCOME_TP3, 2)
            SQLcmd.Parameters.Add("@TC_TP_ALL_DIFF", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_TP_ALL_DIFF, 2)
            SQLcmd.Parameters.Add("@TC_TP_EX_DIFF", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_TP_EX_DIFF, 2)
            SQLcmd.Parameters.Add("@TC_TP_PEN_DIFF", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_TP_PEN_DIFF, 2)
            SQLcmd.Parameters.Add("@TC_TP_AGGR_IN_LOSS", SqlDbType.NVarChar, 25).Value = FormatNumber(TC_TP_AGGR_IN_LOSS, 0)
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@ya", SqlDbType.NVarChar, 5).Value = strCYa
            SQLcmd.Parameters.Add("@sourceno", SqlDbType.Int).Value = 1

            Return ADO.ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return False
        End Try
    End Function
    Public Function UpdateNonAllowableExpenses(ByVal value As Double, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "update [profit_loss_account] set [pl_disallowed_exp]=@value where [pl_ref_no]=@refno and [pl_ya]=@ya"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@value", SqlDbType.NVarChar, 25).Value = CStr(value)
            SQLcmd.Parameters.Add("@pl_ref_no", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@ya", SqlDbType.NVarChar, 5).Value = strCYa

            Return ADO.ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return False
        End Try
    End Function

#End Region

    Private Function GetTotalNonAllowableExpenses(Optional ByRef Errorlog As clsError = Nothing) As Double
        Try
            strPNLKey = CInt(Load_PNL_GetKey(strRefNo, strCYa, Errorlog))
            Dim strDeductible As String = "No"
            Dim dblTotalNonAllowExpenses As Double = 0

            drBusinessSource = GetTCBusinessSource()

            If drBusinessSource IsNot Nothing AndAlso drBusinessSource.Rows.Count > 0 Then

                For Each row As DataRow In drBusinessSource.Rows
                    strSourceNo = row("tc_business")
                    strDeductible = "No"

                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpOtherInterest(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpContractPay(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpDirectorFee(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpTechnicalFee(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpSalary(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpRoyalty(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpRental(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpRepairMaintenance(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpRND(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpPromotionAdvertisement(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpTravel(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpJKDM(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpEmployeeStock(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpLegal(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpEntertainStaff(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpOthersExpenses(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpDepreciation(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpEntertainNonStaff(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpProvision(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpCompoundPenalty(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpLeavePassage(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpFAWrittenOff(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpInitialSubscript(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpCapitalExpenditure(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalDepreciation(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalOtherNonAllowExpenses(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalPurchases(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpDonationNonApproved(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpInterestRestrict(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpUnrealLossFE(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpRealLossFENonTrade(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpLossDisposalFA(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetTotalNonAllowLoss()
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalOtherExrLossForeignt(strDeductible)

                    strDeductible = ""
                    Application.DoEvents()
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpDonationApproved(strDeductible)
                    dblTotalNonAllowExpenses += mdlCA.GetAJDTotalExpZakat(strDeductible)
                Next

            End If

            Return dblTotalNonAllowExpenses
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return 0
        End Try
    End Function
    Public Function RefreshCA(ByVal TC_REF_NO As String, ByVal YA As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            strRefNo = TC_REF_NO
            strCYa = YA

            Dim dt As DataTable = mdlProcess.LOAD_GetDTYA(TC_REF_NO)
            Dim tmpTotalNonAllExp As Double = 0
            If dt IsNot Nothing Then

                For Each dtRowYA As DataRow In dt.Rows
                    If strCYa = dtRowYA("TC_YA") Then
                        drLstview = mdlProcess.Load_Tax_Computation(TC_REF_NO, CStr(YA), ErrorLog)
                        drPartnerIncome = mdlProcess.Load_PartnerIncome(TC_REF_NO, CStr(YA), ErrorLog)
                        dtRAOpeningBalance = mdlProcess.Load_RA_OpeningBalance(TC_REF_NO, CStr(YA), ErrorLog)
                        drOpeningBalance = mdlProcess.Load_OpeningBalance(TC_REF_NO, CStr(YA), ErrorLog)
                        dtOpeningBalanceNextYA = mdlProcess.Load_OpeningBalance_NextYA(TC_REF_NO, CStr(YA), ErrorLog)
                        dtLessApprDonation = mdlProcess.Load_LessApprove_Donation(TC_REF_NO, CStr(YA), strPNLKey, strMainBuz, ErrorLog)

                        If drLstview IsNot Nothing AndAlso drLstview.Rows.Count > 0 Then
                            IIf(SetAdjBusinessIn(ErrorLog) = False, MsgBox(ErrorLog.ErrorMessage), Nothing)
                            Application.DoEvents()
                            drTCUnabsorbedBusinessLoss = mdlCA.GetDTTCUnabsorbedBusinessLoss(ErrorLog)
                            drLstview = mdlProcess.Load_Tax_Computation(TC_REF_NO, CStr(YA), ErrorLog)
                            IIf(Aggregate(ErrorLog) = False, MsgBox(ErrorLog.ErrorMessage), Nothing)

                        End If

                        tmpTotalNonAllExp = GetTotalNonAllowableExpenses()
                        UpdateNonAllowableExpenses(tmpTotalNonAllExp, ErrorLog)
                    End If
                Next

            End If

            Return True
        Catch ex As Exception
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return False
        End Try
    End Function

    Public Function SetAdjBusinessIn(Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dbltotalstatutory As Double = 0
            Dim TC_SI_ADJ_BS_IN As Double = 0
            Dim TC_SI_TOT As Double = 0
            Dim TC_CB_CA_BAL_BF As Double = 0
            Dim TC_RA_BALANCINGALLOWANCE As Double = 0
            Dim TC_ITA_BALANCINGALLOWANCE As Double = 0
            Dim TC_RA_TOTAL1 As Double = 0
            Dim TC_ITA_TOTAL1 As Double = 0
            Dim TC_CB_RA_BAL_BF As Double = 0
            Dim RATOTAL As Double = 0 'TOTAL
            Dim TC_CB_RA_BAL_CF As Double = 0
            Dim TC_CB_ITA_BAL_BF As Double = 0
            Dim ITATOTAL As Double = 0 'TOTAL
            Dim TC_CB_ITA_BAL_CF As Double = 0
            Dim TC_CB_CA_AA As Double = 0
            Dim TC_CB_CA_IA As Double = 0
            Dim TC_CB_CA_BA As Double = 0
            Dim TC_SI_BC As Double = 0
            Dim TC_SI_ADJ_BS_IN_BC As Double = 0
            Dim TC_CB_CA_CURR As Double = 0
            Dim TC_CB_CA_CURR_BA As Double = 0
            Dim TC_CB_CA_UTIL As Double = 0
            Dim TC_SI_CA As Double = 0
            Dim TC_CB_CA_BAL_CF As Double = 0
            Dim TC_CB_CA_DISALLOW As Double = 0
            Dim TC_CB_CA_ABAL_CF As Double = 0
            Dim OB_SCHEDULE As Double = 0
            Dim TC_SI_STAT_BS_IN As Double = 0
            Dim TC_SI_NET_STAT_IN As Double = 0
            Dim TC_CB_RA_BAL_BF_CURR As Double = 0
            Dim TC_CB_ITA_BAL_BF_CURR As Double = 0
            Dim TC_NB_DIV As Double = 0
            Dim TC_NB_INT As Double = 0
            Dim TC_NB_RENT As Double = 0
            Dim TC_TP_SEC110 As Double = 0
            Dim TC_NB_ROYALTY As Double = 0
            Dim TC_NB_SUNDRY As Double = 0
            Dim TC_NB_DIV_NET As Double = 0
            Dim TC_NB_INT_NET As Double = 0
            Dim TC_NB_RENT_NET As Double = 0
            Dim TC_NB_OTH_AGGR_STAT As Double = 0
            Dim TC_STAT_DIVIDEND As Double = 0
            Dim TC_CB_LS_BAL_BF As Double = 0
            Dim TC_CB_CA_ACA As Double = 0 'LeeCC
            Dim TC_NB_RENTIBA As Double = 0 'LeeCC IBA

            If drLstview.Rows.Count > 0 Then
                For Each row As DataRow In drLstview.Rows
                    TC_SI_ADJ_BS_IN = CDbl(row("TC_SI_ADJ_BS_IN"))
                    TC_SI_TOT = CDbl(row("TC_SI_TOT"))
                    TC_CB_CA_BAL_BF = CDbl(row("TC_CB_CA_BAL_BF"))
                    TC_RA_BALANCINGALLOWANCE = CDbl(row("TC_RA_BALANCINGALLOWANCE"))
                    TC_ITA_BALANCINGALLOWANCE = CDbl(row("TC_ITA_BALANCINGALLOWANCE"))
                    TC_RA_TOTAL1 = CDbl(row("TC_SI_ADJ_BS_IN"))
                    TC_ITA_TOTAL1 = CDbl(row("TC_ITA_TOTAL1"))
                    TC_CB_RA_BAL_BF = CDbl(row("TC_CB_RA_BAL_BF"))
                    TC_CB_RA_BAL_CF = CDbl(row("TC_CB_RA_BAL_CF"))
                    TC_CB_ITA_BAL_BF = CDbl(row("TC_CB_ITA_BAL_BF"))
                    TC_CB_ITA_BAL_CF = CDbl(row("TC_CB_ITA_BAL_CF"))
                    TC_CB_CA_AA = CDbl(row("TC_CB_CA_AA"))
                    TC_CB_CA_IA = CDbl(row("TC_CB_CA_IA"))
                    TC_CB_CA_BA = CDbl(row("TC_CB_CA_BA"))
                    TC_SI_BC = CDbl(row("TC_SI_BC"))
                    TC_SI_ADJ_BS_IN_BC = CDbl(row("TC_SI_ADJ_BS_IN_BC"))
                    TC_CB_CA_CURR = CDbl(row("TC_CB_CA_CURR"))
                    TC_CB_CA_CURR_BA = CDbl(row("TC_CB_CA_CURR_BA"))
                    TC_CB_CA_UTIL = CDbl(row("TC_CB_CA_UTIL"))
                    TC_SI_CA = CDbl(row("TC_SI_CA"))
                    TC_CB_CA_BAL_CF = CDbl(row("TC_CB_CA_BAL_CF"))
                    TC_CB_CA_DISALLOW = CDbl(row("TC_CB_CA_DISALLOW"))
                    TC_CB_CA_ABAL_CF = CDbl(row("TC_CB_CA_ABAL_CF"))
                    TC_SI_STAT_BS_IN = CDbl(row("TC_SI_STAT_BS_IN"))
                    TC_SI_NET_STAT_IN = CDbl(row("TC_SI_NET_STAT_IN"))
                    TC_CB_RA_BAL_BF_CURR = CDbl(row("TC_CB_RA_BAL_BF_CURR"))
                    TC_CB_ITA_BAL_BF_CURR = CDbl(row("TC_CB_ITA_BAL_BF_CURR"))
                    TC_NB_DIV = CDbl(row("TC_NB_DIV"))
                    TC_NB_INT = CDbl(row("TC_NB_INT"))
                    TC_NB_RENT = CDbl(row("TC_NB_RENT"))
                    TC_TP_SEC110 = CDbl(row("TC_TP_SEC110"))
                    TC_NB_ROYALTY = CDbl(row("TC_NB_ROYALTY"))
                    TC_NB_SUNDRY = CDbl(row("TC_NB_SUNDRY"))
                    TC_NB_DIV_NET = CDbl(row("TC_NB_DIV_NET"))
                    TC_NB_INT_NET = CDbl(row("TC_NB_INT_NET"))
                    TC_NB_RENT_NET = CDbl(row("TC_NB_RENT_NET"))
                    TC_NB_OTH_AGGR_STAT = CDbl(row("TC_NB_OTH_AGGR_STAT"))
                    TC_STAT_DIVIDEND = CDbl(row("TC_STAT_DIVIDEND"))
                    TC_CB_LS_BAL_BF = CDbl(row("TC_CB_LS_BAL_BF"))
                    TC_NB_RENTIBA = CDbl(row("TC_NB_RENTIBA"))
                    TC_CB_CA_ACA = CDbl(row("TC_CB_CA_ACA"))

                    If Not IsDBNull(row("TC_AI_ADJ_IN_LOSS")) Then
                        If CDbl(row("TC_AI_ADJ_IN_LOSS")) < 0 Then
                            TC_SI_ADJ_BS_IN = 0 'Adjusted Business Income
                        Else
                            TC_SI_ADJ_BS_IN = FormatNumber(row("TC_AI_ADJ_IN_LOSS"), 0)
                        End If
                    End If

                    For Each dtrowOB As DataRow In drOpeningBalance.Rows
                        OB_SCHEDULE = CDbl(dtrowOB("OB_SCHEDULE"))

                        If CDbl(dtrowOB("OB_SOURCENO")) = CDbl(row("TC_BUSINESS")) Then
                            If GetBoolPLS60FA() Then
                                TC_CB_CA_BAL_BF = 0
                            Else
                                If CDbl(drLstview("TC_BUSINESS").ToString) > 0 Then
                                    TC_CB_CA_BAL_BF = FormatNumber(CDbl(OB_SCHEDULE), 0) 'Balance b/f

                                Else
                                    TC_CB_CA_BAL_BF = 0

                                End If
                            End If
                        End If

                        If CDbl(dtrowOB("OB_RA")) - CDbl(row("TC_RA_WITHDRAWAL")) > 0 Then
                            TC_RA_BALANCINGALLOWANCE = FormatNumber(CDbl(dtrowOB("OB_RA")) - CDbl(row("TC_RA_WITHDRAWAL")), 0) 'RA Balance b/f
                        Else
                            TC_RA_BALANCINGALLOWANCE = 0
                        End If

                        If CDbl(dtrowOB("OB_INVESTMENT")) - CDbl(row("TC_ITA_WITHDRAWAL")) > 0 Then
                            TC_ITA_BALANCINGALLOWANCE = FormatNumber(CDbl(dtrowOB("OB_INVESTMENT")) - CDbl(row("TC_ITA_WITHDRAWAL")), 0) 'ITA Balance b/f
                        Else
                            TC_ITA_BALANCINGALLOWANCE = 0
                        End If

                        TC_RA_TOTAL1 = FormatNumber(CDbl(TC_RA_BALANCINGALLOWANCE) + CDbl(row("TC_RA_QUALIFYINGCAPITALEXP_AMOUNT")), 0)
                        TC_ITA_TOTAL1 = FormatNumber(CDbl(TC_ITA_BALANCINGALLOWANCE) + CDbl(row("TC_ITA_QUALIFYINGCAPITALEXP_AMOUNT")), 0)

                        TC_CB_RA_BAL_BF = FormatNumber(dtrowOB("OB_RA"), 0) 'Balance b/f
                        RATOTAL = FormatNumber(CDbl(TC_CB_RA_BAL_BF) + CDbl(row("TC_CB_RA_CURR")) - CDbl(row("TC_RA_WITHDRAWAL")), 0)
                        TC_CB_RA_BAL_CF = FormatNumber(CDbl(RATOTAL) - CDbl(row("TC_SI_RA")) - CDbl(row("TC_RA_ADJUSTMENT")), 0)
                        If TC_CB_RA_BAL_CF < 0 Then
                            TC_CB_RA_BAL_CF = 0
                        End If
                        If RATOTAL < 0 Then
                            RATOTAL = 0
                        End If

                        TC_CB_ITA_BAL_BF = FormatNumber(CDbl(dtrowOB("OB_INVESTMENT")), 0) 'Balance b/f
                        ITATOTAL = FormatNumber(CDbl(TC_CB_ITA_BAL_BF) + CDbl(row("TC_CB_ITA_CURR")) - CDbl(row("TC_ITA_WITHDRAWAL")), 0)
                        TC_CB_ITA_BAL_CF = FormatNumber(CDbl(ITATOTAL) - CDbl(row("TC_SI_INVEST_ALLOW")) - CDbl(row("TC_ITA_ADJUSTMENT")), 0)
                        If TC_CB_ITA_BAL_CF < 0 Then
                            TC_CB_ITA_BAL_CF = 0
                        End If
                        If ITATOTAL < 0 Then
                            ITATOTAL = 0
                        End If

                        Exit For
                    Next

                    Dim sourcenum As String = ""
                    Dim pre_sourcenum As String = ""
                    drCA_sourceNum = GetDTCA_SourceNum() 'LeeCC rmk

                    If drCA_sourceNum IsNot Nothing AndAlso drCA_sourceNum.Rows.Count > 0 Then
                        For Each dtRowSourceNo As DataRow In drCA_sourceNum.Rows
                            If sourcenum = "" Then
                                sourcenum = dtRowSourceNo("CA_SOURCENO").ToString
                            Else
                                If Not pre_sourcenum = dtRowSourceNo("CA_SOURCENO").ToString Then
                                    sourcenum = sourcenum & "," & dtRowSourceNo("CA_SOURCENO").ToString
                                End If
                            End If
                            pre_sourcenum = dtRowSourceNo("CA_SOURCENO").ToString
                        Next
                    End If

                    Dim dblAA As Double = 0
                    Dim dblIA As Double = 0
                    Dim dblCurrQCDisp As Double = 0
                    Dim dblCurrTWDVDisp As Double = 0
                    Dim dblIATotal As Double = 0
                    Dim dblAATotal As Double = 0
                    Dim dblAccAA As Double = 0
                    Dim dblAccIA As Double = 0
                    Dim dblAccIATotal As Double = 0
                    Dim dblAccAATotal As Double = 0

                    If Not sourcenum = "" Then
                        Dim strkey_array() As String = Split(sourcenum, ",")
                        For I As Long = 0 To UBound(strkey_array)
                            dblCurrQCDisp = 0
                            dblCurrTWDVDisp = 0
                            dblIATotal = 0
                            dblAATotal = 0
                            dblAccIATotal = 0
                            dblAccAATotal = 0
                            TC_CB_CA_ACA = 0

                            drCA_AA_IARate = GetDTCA_AA_IARate(strkey_array, I)

                            If drCA_AA_IARate IsNot Nothing AndAlso drCA_AA_IARate.Rows.Count > 0 Then
                                For Each dtRowAAIA As DataRow In drCA_AA_IARate.Rows
                                    dblCurrQCDisp = 0
                                    dblCurrTWDVDisp = 0
                                    dblIA = 0
                                    dblAA = 0
                                    dblAccAA = 0
                                    dblAccIA = 0

                                    Dim dblCurrQC As Double = CDbl(dtRowAAIA("CA_QUALIFYING_COST"))
                                    Dim dblCurrTWDV As Double = CDbl(dtRowAAIA("CA_TWDV"))

                                    If dtRowAAIA("CA_PURCHASE_YEAR") = strCYa Then
                                        If drCA_AA_IARate("CA_YA").ToString = strCYa Then
                                            dblIA += FormatNumber((CDbl(dtRowAAIA("CA_QUALIFYING_COST"))) * CDbl(dtRowAAIA("CA_RATE_IA")) / 100, 2)
                                            If drCA_AA_IARate("CA_ACCELERATED").ToString = "True" Then
                                                dblAccIA = dblIA
                                            End If
                                        End If
                                    Else
                                        dblCurrTWDV = dblCurrTWDV - FormatNumber(dblCurrQC * CDbl(dtRowAAIA("CA_RATE_IA")) / 100, 2)

                                        For intYear As Integer = CInt(dtRowAAIA("CA_YA")) To CInt(strCYa) - 1

                                            drCADisposal = GetDTCADisposal(dtRowAAIA("CA_KEY"), intYear)

                                            If drCADisposal IsNot Nothing AndAlso drCADisposal.Rows.Count > 0 Then
                                                If drCADisposal.Rows(0)("C_CAKEY") > 0 Then
                                                    dblCurrQC = dblCurrQC - CDbl(drCADisposal.Rows(0)("S_CADISPQC"))
                                                    dblCurrTWDV = dblCurrTWDV - CDbl(drCADisposal.Rows(0)("S_CADISPTWDV"))
                                                End If
                                            End If

                                            dblCurrTWDV = dblCurrTWDV - FormatNumber(dblCurrQC * CDbl(dtRowAAIA("CA_RATE_AA")) / 100, 2)
                                        Next
                                        If dblCurrTWDV < 0 Then dblCurrTWDV = 0
                                    End If

                                    drCADisposal = GetDTCADisposal(dtRowAAIA("CA_KEY"), strCYa)

                                    If drCADisposal IsNot Nothing AndAlso drCADisposal.Rows.Count > 0 Then
                                        If drCADisposal.Rows(0)("C_CAKEY") > 0 Then
                                            dblCurrQCDisp = CDbl(drCADisposal.Rows(0)("S_CADISPQC"))
                                            dblCurrTWDVDisp = CDbl(drCADisposal.Rows(0)("S_CADISPTWDV"))
                                        Else
                                            dblCurrQCDisp = 0
                                            dblCurrTWDVDisp = 0
                                        End If
                                    End If

                                    dblAA = FormatNumber(((dblCurrQC - dblCurrQCDisp) * (CDbl(dtRowAAIA("CA_RATE_AA") / 100))), 2)

                                    If dblAA > (dblCurrTWDV - dblCurrTWDVDisp) Then
                                        dblAA = dblCurrTWDV - dblCurrTWDVDisp
                                    End If

                                    If drCA_AA_IARate("CA_YA").ToString = strCYa Then
                                        If dblCurrQC - dblCurrQCDisp <= 0 Then dblIA = 0
                                    End If

                                    If drCA_AA_IARate("CA_ACCELERATED").ToString = "True" Then
                                        dblAccAA = dblAA
                                        dblAccIA = dblIA
                                    End If
                                    'LeeCC ACA refresh

                                    If dblCurrQC > 0 Then
                                        dblIATotal = dblIATotal + dblIA
                                        dblAccIATotal = dblAccIATotal + dblAccIA
                                        dblAATotal = dblAATotal + dblAA 'LeeCC ACA refresh
                                        dblAccAATotal = dblAccAATotal + dblAccAA 'LeeCC ACA refresh
                                    End If
                                Next
                            End If

                            If Val(row("TC_BUSINESS")) = Val(strkey_array(I)) Then
                                If dblAATotal > 0 Then
                                    TC_CB_CA_AA = FormatNumber(dblAATotal, 0)
                                Else
                                    TC_CB_CA_AA = 0
                                End If
                                If dblIATotal > 0 Then
                                    TC_CB_CA_IA = FormatNumber(dblIATotal, 0)
                                Else
                                    TC_CB_CA_IA = 0
                                End If

                                'LeeCC refresh ACA start
                                If dblAccIATotal > 0 Or dblAccAATotal > 0 Then
                                    TC_CB_CA_ACA = dblAccIATotal + dblAccAATotal
                                End If
                                'LeeCC refresh ACA end
                                Exit For
                            End If
                        Next
                    End If

                    Dim dblUCABal_Allow As Double = 0
                    Dim dblUCABal_Charge As Double = 0

                    If Not sourcenum = "" Then
                        Dim strkey_array() As String = Split(sourcenum, ",")
                        For I As Long = 0 To UBound(strkey_array)

                            dblUCABal_Allow = 0 ' Balancing Allowance
                            dblUCABal_Charge = 0 ' Balancing Charge

                            'Dim dtCADisposalBABCNonHP As New DataTable
                            drCADisposalBABCNonHP = GetDTCADisposalBABCNonHP(strkey_array, I)
                            If drCADisposalBABCNonHP IsNot Nothing AndAlso drCADisposalBABCNonHP.Rows.Count > 0 Then
                                For Each dtRowDispBABCNonHP As DataRow In drCADisposalBABCNonHP.Rows
                                    If CDbl(drCADisposalBABCNonHP("CA_DISP_BABC").ToString) < 0 Then
                                        dblUCABal_Allow = CDbl(dblUCABal_Allow) + CDbl(dtRowDispBABCNonHP("CA_DISP_BABC").ToString)
                                    Else
                                        dblUCABal_Charge = CDbl(dblUCABal_Charge) + CDbl(dtRowDispBABCNonHP("CA_DISP_BABC").ToString)
                                    End If
                                Next
                            End If

                            'Dim dtCADisposalBABCHP As New DataTable
                            drCADisposalBABCHP = GetDTCADisposalBABCHP(strkey_array, I)
                            If drCADisposalBABCHP IsNot Nothing AndAlso drCADisposalBABCHP.Rows.Count > 0 Then
                                For Each dtRowDispBABCHP As DataRow In drCADisposalBABCNonHP.Rows
                                    If CDbl(dtRowDispBABCHP("CA_BABC").ToString) < 0 Then
                                        dblUCABal_Allow = CDbl(dblUCABal_Allow) + CDbl(dtRowDispBABCHP("CA_BABC").ToString)
                                    Else
                                        dblUCABal_Charge = CDbl(dblUCABal_Charge) + CDbl(dtRowDispBABCHP("CA_BABC").ToString)
                                    End If
                                Next
                            End If

                            If Val(row("TC_BUSINESS")) = Val(strkey_array(I)) Then
                                TC_CB_CA_BA = FormatNumber(Math.Abs(CDbl(dblUCABal_Allow)), 0)
                                TC_SI_BC = FormatNumber(Math.Abs(CDbl(dblUCABal_Charge)), 0)
                                Exit For
                            End If
                        Next
                    End If

                    TC_SI_ADJ_BS_IN_BC = FormatNumber(CDbl(TC_SI_ADJ_BS_IN) + CDbl(TC_SI_BC), 0)

                    TC_CB_CA_CURR = FormatNumber(CDbl(TC_CB_CA_AA) + CDbl(TC_CB_CA_IA) - CDbl(row("TC_CB_CA_NA")) + CDbl(TC_CB_CA_BA), 0) 'UCA Year
                    TC_CB_CA_CURR_BA = FormatNumber(CDbl(TC_CB_CA_BAL_BF) + CDbl(TC_CB_CA_CURR), 0) 'Total

                    If CDbl(TC_CB_CA_CURR_BA) >= CDbl(TC_SI_ADJ_BS_IN_BC) Then
                        If CDbl(TC_SI_ADJ_BS_IN_BC) > 0 Then
                            TC_CB_CA_UTIL = FormatNumber(CDbl(TC_SI_ADJ_BS_IN_BC), 0) 'UCA Utilised
                        Else
                            TC_CB_CA_UTIL = 0
                        End If
                    ElseIf CDbl(TC_CB_CA_CURR_BA) < CDbl(TC_SI_ADJ_BS_IN_BC) Then
                        If CDbl(TC_SI_ADJ_BS_IN_BC) > 0 Then
                            TC_CB_CA_UTIL = FormatNumber(CDbl(TC_CB_CA_CURR_BA), 0) 'UCA Utilised
                        Else
                            TC_CB_CA_UTIL = 0
                        End If
                    End If
                    TC_SI_CA = FormatNumber(CDbl(TC_CB_CA_UTIL), 0) 'Capital Allowances for Statutory Income
                    '*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-

                    If GetBoolPLS60FA() Then
                        TC_CB_CA_BAL_CF = 0
                        TC_CB_CA_DISALLOW = TC_CB_CA_BAL_CF
                        TC_CB_CA_ABAL_CF = 0
                    Else
                        If (CDbl(TC_CB_CA_CURR_BA) - CDbl(TC_CB_CA_UTIL) < 0) Then
                            TC_CB_CA_BAL_CF = 0
                        Else
                            TC_CB_CA_BAL_CF = FormatNumber(CDbl(TC_CB_CA_CURR_BA) - CDbl(TC_CB_CA_UTIL), 0) 'Balance c/f
                        End If
                        If GetBoolChkMajorC() Then
                            TC_CB_CA_DISALLOW = TC_CB_CA_BAL_CF  'DisAllowance CA
                        Else
                            TC_CB_CA_DISALLOW = 0
                        End If
                        If (CDbl(TC_CB_CA_BAL_CF) - CDbl(TC_CB_CA_DISALLOW) > 0) Then
                            TC_CB_CA_ABAL_CF = FormatNumber(CDbl(TC_CB_CA_BAL_CF) - CDbl(TC_CB_CA_DISALLOW), 0) 'Actual b/f
                        Else
                            TC_CB_CA_ABAL_CF = 0
                        End If
                    End If

                    TC_SI_STAT_BS_IN = FormatNumber(CDbl(TC_SI_ADJ_BS_IN_BC) - CDbl(TC_SI_CA), 0) 'Statutory Business Income
                    TC_SI_NET_STAT_IN = FormatNumber(CDbl(TC_SI_STAT_BS_IN) - CDbl(row("TC_SI_RA")) - CDbl(row("TC_SI_INVEST_ALLOW")) - CDbl(row("TC_PIONEER")) + CDbl(row("TC_WITHRAITA")), 0) 'Net Statutory Income

                    If CDbl(TC_SI_NET_STAT_IN) < 0 Then
                        TC_SI_NET_STAT_IN = 0
                    End If

                    '//
                    If CDbl(TC_CB_RA_BAL_CF) < 0 Then
                        TC_CB_RA_BAL_CF = 0
                    End If

                    Dim RACurrClaims As String
                    Dim RABalanceCF As String

                    RACurrClaims = FormatNumber(CDbl(TC_CB_RA_BAL_BF) + CDbl(row("TC_CB_RA_CURR")) - CDbl(row("TC_RA_WITHDRAWAL")), 0)
                    RABalanceCF = FormatNumber((CDbl(TC_CB_RA_BAL_BF) + CDbl(row("TC_CB_RA_CURR"))) - CDbl(row("TC_SI_RA")) - CDbl(row("TC_RA_ADJUSTMENT")), 0)

                    If CDbl(RACurrClaims) < 0 Then
                        RACurrClaims = "0"
                    End If
                    If CDbl(RABalanceCF) < 0 Then
                        RABalanceCF = "0"
                    End If

                    TC_CB_RA_BAL_BF_CURR = RACurrClaims
                    TC_CB_RA_BAL_CF = RABalanceCF

                    If CDbl(TC_CB_ITA_BAL_CF) < 0 Then
                        TC_CB_ITA_BAL_CF = 0
                    End If

                    '//
                    Dim ITACurrClaims As String
                    Dim ITABalanceCF As String

                    ITACurrClaims = FormatNumber(CDbl(TC_CB_ITA_BAL_BF) + CDbl(row("TC_CB_ITA_CURR")) - CDbl(row("TC_ITA_WITHDRAWAL")), 0)
                    ITABalanceCF = FormatNumber((CDbl(TC_CB_ITA_BAL_BF) + CDbl(row("TC_CB_ITA_CURR"))) - CDbl(row("TC_SI_INVEST_ALLOW")) - CDbl(row("TC_ITA_ADJUSTMENT")), 0)

                    If CDbl(ITACurrClaims) < 0 Then
                        ITACurrClaims = 0
                    End If
                    If CDbl(ITABalanceCF) < 0 Then
                        ITABalanceCF = 0
                    End If

                    TC_CB_ITA_BAL_BF_CURR = ITACurrClaims
                    TC_CB_ITA_BAL_CF = ITABalanceCF

                    dbltotalstatutory = FormatNumber(dbltotalstatutory + TC_SI_NET_STAT_IN, 0)

                    Dim strSQL As String = ""
                    Dim dr1 As DataTable = Nothing
                    Dim dr2 As DataTable = Nothing
                    Dim dr3 As DataTable = Nothing

                    dr1 = mdlCA.Load_PNL()
                    dr2 = mdlCA.Load_INT_AMOUNT_INTEREST_INCOME(row("TC_KEY"))
                    dr3 = mdlCA.Load_SUN_AMOUNT_SUN_TOTAL(row("TC_KEY"))

                    If dr1 IsNot Nothing AndAlso dr1.Rows.Count > 0 Then
                        TC_NB_DIV = FormatNumber(dr1.Rows(0)("PL_TREGROSS"), 0)
                        If dr2 IsNot Nothing AndAlso dr2.Rows.Count > 0 Then
                            TC_NB_INT = FormatNumber(CDbl(dr1.Rows(0)("PL_OTH_IN_INTEREST")) + CDbl(dr2.Rows(0)("INT_TOTAL")), 0)
                        Else
                            TC_NB_INT = "0"
                        End If

                        If dr3 IsNot Nothing AndAlso dr3.Rows.Count > 0 Then
                            TC_NB_SUNDRY = FormatNumber(CDbl(dr1.Rows(0)("PL_OTH_IN_OTHER")) + CDbl(dr3.Rows(0)("SUN_TOTAL")), 0)
                        Else
                            TC_NB_SUNDRY = "0"
                        End If

                        TC_NB_RENT = FormatNumber(dr1.Rows(0)("PL_OTH_IN_RENTAL"), 0)
                        TC_TP_SEC110 = FormatNumber(dr1.Rows(0)("PL_TTAXDEDUCTION"), 0)
                        TC_NB_ROYALTY = FormatNumber(dr1.Rows(0)("PL_OTH_IN_ROYALTY"), 0)
                    End If

                    Dim dblOtherDividend As Double = 0
                    dblOtherDividend = CDbl(row("TC_NB_DIV_ATT_INT")) + CDbl(row("TC_NB_DIV_OTH"))

                    If CDbl(TC_NB_DIV) <= dblOtherDividend Then
                        TC_NB_DIV_NET = 0
                    ElseIf CDbl(TC_NB_DIV) > dblOtherDividend Then
                        TC_NB_DIV_NET = FormatNumber(CDbl(TC_NB_DIV) - dblOtherDividend, 0)
                    End If

                    'CalculateInterest
                    'LeeCC 2012 Disallowed Interest start
                    Dim dblOtherInterest As Double = 0
                    dblOtherInterest = CDbl(row("TC_NB_DIV_TOT_ATT_INT")) + CDbl(row("TC_NB_INT_OTH"))

                    If CDbl(TC_NB_INT) <= dblOtherInterest Then
                        TC_NB_INT_NET = 0
                    ElseIf CDbl(TC_NB_INT) > dblOtherInterest Then
                        TC_NB_INT_NET = FormatNumber(CDbl(TC_NB_INT) - dblOtherInterest, 0)
                    End If
                    'LeeCC 2012 Disallowed Interest end

                    Dim dblOtherRental As Double
                    dblOtherRental = CDbl(row("TC_NB_RENT_ATT_INT")) + CDbl(row("TC_NB_RENT_ASSESS")) + CDbl(row("TC_NB_RENT_QUIT")) + CDbl(row("TC_NB_RENT_INSUR")) + CDbl(row("TC_NB_RENT_MAIN")) + CDbl(row("TC_NB_RENT_AGREE")) + CDbl(row("TC_NB_RENT_OTH2"))

                    'LeeCC IBA start
                    If TC_NB_RENT < TC_NB_RENTIBA Then
                        TC_NB_RENTIBA = 0
                    Else
                        TC_NB_RENT = FormatNumber(CDbl(TC_NB_RENT) - CDbl(TC_NB_RENTIBA), 0)
                    End If

                    Dim dblExpDirectIBA As Double
                    dblExpDirectIBA = CDbl(row("TC_NB_RENTIBA_ATT_IN")) + CDbl(row("TC_NB_RENTIBA_ASSESS")) + _
                    CDbl(row("TC_NB_RENTIBA_QUIT")) + CDbl(row("TC_NB_RENTIBA_INSUR")) + _
                    CDbl(row("TC_NB_RENTIBA_OTH")) + CDbl(row("TC_NB_RENTIBA_MAIN")) + _
                    CDbl(row("TC_NB_RENTIBA_AGREE"))

                    '//
                    Dim dblRental As Double
                    dblRental = CDbl(TC_NB_RENT) - dblOtherRental

                    Dim dblRentalIBA As Double
                    dblRentalIBA = CDbl(TC_NB_RENTIBA) - dblExpDirectIBA - CDbl(row("TC_NB_RENTIBA_IBA"))

                    If (CDbl(dblRental) + CDbl(dblRentalIBA)) <= 0 Then
                        TC_NB_RENT_NET = 0
                    ElseIf (CDbl(dblRental) + CDbl(dblRentalIBA)) > 0 Then
                        TC_NB_RENT_NET = CDbl(dblRental) + CDbl(dblRentalIBA)
                    End If
                    'LeeCC IBA end

                    'CalculateNetTotal
                    Dim dblNBIBalBF As Double = 0
                    Dim dblNBIBalCF As Double = 0


                    If Val(strCYa) >= 2008 Then
                        dblNBIBalCF = FormatNumber(CDbl(TC_NB_INT_NET) + CDbl(TC_NB_RENT_NET), 0)
                        dblNBIBalBF = FormatNumber(CDbl(TC_NB_INT_NET) + CDbl(TC_NB_RENT_NET), 0)
                    Else
                        dblNBIBalCF = FormatNumber(CDbl(TC_NB_DIV_NET) + CDbl(TC_NB_INT_NET) + CDbl(TC_NB_RENT_NET), 0)
                        dblNBIBalBF = FormatNumber(CDbl(TC_NB_DIV_NET) + CDbl(TC_NB_INT_NET) + CDbl(TC_NB_RENT_NET), 0)
                    End If

                    If CDbl(TC_NB_SUNDRY) <= CDbl(row("TC_SUNDRY_EXP")) Then
                        TC_NB_SUNDRY = 0
                    ElseIf CDbl(TC_NB_SUNDRY) > CDbl(row("TC_SUNDRY_EXP")) Then
                        TC_NB_SUNDRY = FormatNumber(CDbl(TC_NB_SUNDRY), 0)
                    End If

                    TC_NB_OTH_AGGR_STAT = FormatNumber(CDbl(dblNBIBalBF) + CDbl(TC_NB_SUNDRY) - CDbl(row("TC_SUNDRY_EXP")) + CDbl(TC_NB_ROYALTY) + CDbl(row("TC_NB_ADDITION")), 0)

                    If drLstview IsNot Nothing AndAlso drLstview.Rows.Count > 0 Then
                        If strCYa >= 2008 Then
                            TC_STAT_DIVIDEND = TC_NB_DIV_NET
                        Else
                            TC_STAT_DIVIDEND = 0.0
                        End If
                    End If

                    drOpeningBalance = mdlProcess.Load_OpeningBalance(strRefNo, strCYa, Errorlog)
                    If drOpeningBalance IsNot Nothing AndAlso drOpeningBalance.Rows.Count > 0 Then
                        TC_CB_LS_BAL_BF = 0
                        For Each dtRowOB As DataRow In drOpeningBalance.Rows
                            If GetBoolPLS60FA() Then
                                TC_CB_LS_BAL_BF = 0
                            Else
                                TC_CB_LS_BAL_BF = CDbl(TC_CB_LS_BAL_BF) + CDbl(dtRowOB("OB_BS_LOSS"))
                            End If
                        Next
                    End If

                    If mdlCA.Update_TAXCOMPUTATION(row("TC_BUSINESS"), TC_SI_ADJ_BS_IN, TC_CB_CA_BAL_BF, TC_RA_BALANCINGALLOWANCE, TC_ITA_BALANCINGALLOWANCE, TC_RA_TOTAL1, TC_ITA_TOTAL1, TC_CB_RA_BAL_BF, TC_CB_RA_BAL_CF, TC_CB_ITA_BAL_BF, TC_CB_ITA_BAL_CF, TC_CB_CA_AA, TC_CB_CA_IA, TC_CB_CA_BA, TC_SI_BC, TC_CB_CA_CURR, TC_CB_CA_CURR_BA, TC_CB_CA_UTIL, TC_SI_CA, TC_CB_CA_BAL_CF, TC_CB_CA_DISALLOW, TC_CB_CA_ABAL_CF, TC_CB_CA_ACA, TC_SI_STAT_BS_IN, TC_SI_NET_STAT_IN, TC_CB_RA_BAL_BF_CURR, TC_CB_ITA_BAL_BF_CURR, TC_NB_DIV, TC_NB_INT, TC_NB_RENT, TC_TP_SEC110, TC_NB_ROYALTY, TC_NB_SUNDRY, TC_NB_DIV_NET, TC_NB_INT_NET, TC_NB_RENT_NET, TC_NB_OTH_AGGR_STAT, TC_STAT_DIVIDEND, TC_CB_LS_BAL_BF, TC_SI_ADJ_BS_IN_BC, TC_NB_RENTIBA, Errorlog) = False Then
                        MsgBox("Failed to update tax computation." & vbCrLf & Errorlog.ErrorName & vbCrLf & Errorlog.ErrorMessage, MsgBoxStyle.Critical)
                    End If

                    If mdlCA.Update_OBSchudule(OB_SCHEDULE, row("TC_BUSINESS"), Errorlog) = False Then
                        MsgBox("Failed to update opening balance." & vbCrLf & Errorlog.ErrorName & vbCrLf & Errorlog.ErrorMessage, MsgBoxStyle.Critical)
                    End If

                Next
            End If


            TC_SI_TOT = FormatNumber(dbltotalstatutory, 0)

            If mdlCA.Update_TAXCOMPUTATION_TC_SI_TOT(TC_SI_TOT, Errorlog) = False Then
                MsgBox("Failed to update tax computation tc_si_tot." & vbCrLf & Errorlog.ErrorName & vbCrLf & Errorlog.ErrorMessage, MsgBoxStyle.Critical)
            End If


            Return True
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return False
        End Try
    End Function
    Public Function Aggregate(Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            Dim TC_SI_BS_LOSS_BF As Double = 0
            Dim TC_CB_LS_UTIL As Double = 0
            Dim TC_SI_AGGREGATE As Double = 0
            Dim TC_CB_LS_BAL_UTIL As Double = 0
            Dim TC_CB_LS_ADJUST_LOSS As Double = 0
            Dim TC_TP_AGGR_IN As Double = 0
            Dim TC_TP_CURR_LOSS As Double = 0
            Dim TC_TP_AGGR_IN_LOSS As Double = 0
            Dim TC_CB_LS_UTIL_CURR As Double = 0
            Dim TC_CB_LS_UNABSORBED As Double = 0
            Dim TC_CB_LS_BAL_CF As Double = 0
            Dim TC_CB_LS_BALS_CF As Double = 0
            Dim TC_TP_TOTAL_OTH_EXP As Double = 0
            Dim TC_TP_APRV_DONATION As Double = 0
            Dim TC_TP_ZAKAT As Double = 0
            Dim TC_TP_TOTAL_INCOME As Double = 0
            Dim TC_TP_CHARGEABLE As Double = 0
            Dim TC_TP_APP_CHARGEABLE4A As Double = 0
            Dim TC_TP_APP_CHARGEABLE5 As Double = 0
            Dim TC_TP_RATE4A_CHARGEABLE As Double = 0
            Dim TC_TP_28_CHARGEABLE As Double = 0
            Dim TC_TP_TOT_TAX_CHARGED As Double = 0
            Dim TC_TP_TOT_SETOFF As Double = 0
            Dim TC_TP_PAYABLE As Double = 0
            Dim TC_TP_INCOME_TP2 As Double = 0
            Dim TC_TP_PAYABLE_BAL As Double = 0
            Dim TC_TP_INCOME_TP3 As Double = 0
            Dim TC_TP_ALL_DIFF As Double = 0
            Dim TC_TP_EX_DIFF As Double = 0
            Dim TC_TP_PEN_DIFF As Double = 0
            '=== CYS 2010 start ===
            Dim TCP_PARTNERSHIP As Double = 0
            Dim strKey As String
            Dim PARTNER_LOSS As Double = 0

            If drPartnerIncome IsNot Nothing AndAlso drPartnerIncome.Rows.Count > 0 Then
                TCP_PARTNERSHIP = drPartnerIncome.Rows(0)("TCP_PARTNERSHIP")
                strKey = drPartnerIncome.Rows(0)("TCP_KEY")
                If Not String.IsNullOrEmpty(strKey) Then
                    drPartnerLoss = mdlCA.GetPartnerLoss_LstView(strKey)
                    If drPartnerLoss IsNot Nothing AndAlso drPartnerLoss.Rows.Count > 0 Then
                        If Not IsDBNull(drPartnerLoss.Rows(0)("PARTNER_LOSS")) Then
                            PARTNER_LOSS = drPartnerLoss.Rows(0)("PARTNER_LOSS")
                        Else
                            PARTNER_LOSS = 0
                        End If
                    End If
                End If
            End If

            If drTCUnabsorbedBusinessLoss IsNot Nothing AndAlso drTCUnabsorbedBusinessLoss.Rows.Count > 0 Then
                'InitializeValue
                TC_SI_BS_LOSS_BF = drTCUnabsorbedBusinessLoss.Rows(0)("TC_SI_BS_LOSS_BF")
                TC_CB_LS_UTIL = drTCUnabsorbedBusinessLoss.Rows(0)("TC_CB_LS_UTIL")
                TC_SI_AGGREGATE = drTCUnabsorbedBusinessLoss.Rows(0)("TC_SI_AGGREGATE")
                TC_CB_LS_BAL_UTIL = drTCUnabsorbedBusinessLoss.Rows(0)("TC_CB_LS_BAL_UTIL")
                TC_CB_LS_ADJUST_LOSS = drTCUnabsorbedBusinessLoss.Rows(0)("TC_CB_LS_ADJUST_LOSS")
                TC_TP_AGGR_IN = drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_AGGR_IN")
                TC_TP_CURR_LOSS = drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_CURR_LOSS")
                TC_CB_LS_UTIL_CURR = drTCUnabsorbedBusinessLoss.Rows(0)("TC_CB_LS_UTIL_CURR")
                TC_TP_AGGR_IN_LOSS = drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_AGGR_IN_LOSS")
                TC_CB_LS_UNABSORBED = drTCUnabsorbedBusinessLoss.Rows(0)("TC_CB_LS_UNABSORBED")
                TC_CB_LS_BAL_CF = drTCUnabsorbedBusinessLoss.Rows(0)("TC_CB_LS_BAL_CF")
                TC_CB_LS_BALS_CF = drTCUnabsorbedBusinessLoss.Rows(0)("TC_CB_LS_BALS_CF")
                TC_TP_TOTAL_OTH_EXP = drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_TOTAL_OTH_EXP")
                TC_TP_APRV_DONATION = drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_APRV_DONATION")
                TC_TP_ZAKAT = drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_ZAKAT")
                TC_TP_TOTAL_INCOME = drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_TOTAL_INCOME")
                TC_TP_CHARGEABLE = drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_CHARGEABLE")
                TC_TP_APP_CHARGEABLE4A = drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_APP_CHARGEABLE4A")
                TC_TP_APP_CHARGEABLE5 = drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_APP_CHARGEABLE5")
                TC_TP_RATE4A_CHARGEABLE = drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_RATE4A_CHARGEABLE")
                TC_TP_28_CHARGEABLE = drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_28_CHARGEABLE")
                TC_TP_TOT_TAX_CHARGED = drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_TOT_TAX_CHARGED")
                TC_TP_TOT_SETOFF = drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_TOT_SETOFF")
                TC_TP_PAYABLE = drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_PAYABLE")
                TC_TP_INCOME_TP2 = drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_INCOME_TP2")
                TC_TP_PAYABLE_BAL = drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_PAYABLE_BAL")
                TC_TP_INCOME_TP3 = drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_INCOME_TP3")
                TC_TP_ALL_DIFF = drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_ALL_DIFF")
                TC_TP_EX_DIFF = drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_EX_DIFF")
                TC_TP_PEN_DIFF = drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_PEN_DIFF")

                If CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_CB_LS_BAL_BF")) - CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_CB_LS_D_BL")) >= CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_SI_TOT")) Then
                    TC_SI_BS_LOSS_BF = FormatNumber(CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_SI_TOT")), 0)
                ElseIf CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_CB_LS_BAL_BF")) - CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_CB_LS_D_BL")) < CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_SI_TOT")) Then
                    ' HS :C2008.7 : Format Number
                    'txtBsLoss = FormatNumber(CDbl(txtULBalbf), 0) - FormatNumber(CDbl(txtDisABL), 0)
                    TC_SI_BS_LOSS_BF = FormatNumber(CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_CB_LS_BAL_BF")) - CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_CB_LS_D_BL")), 0)
                End If

                'BsLoss
                If CDbl(TC_SI_BS_LOSS_BF) >= CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_CB_LS_BAL_BF")) - CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_CB_LS_D_BL")) Then
                    'HS : C2008.7 : Format Number
                    'txtULUtilised = FormatNumber(CDbl(txtULBalbf), 0) - FormatNumber(CDbl(txtDisABL), 0)
                    TC_CB_LS_UTIL = FormatNumber(CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_CB_LS_BAL_BF")) - CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_CB_LS_D_BL")), 0)
                ElseIf CDbl(TC_SI_BS_LOSS_BF) < CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_CB_LS_BAL_BF")) - CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_CB_LS_D_BL")) Then
                    'HS : C2008.7 : Format Number
                    'txtULUtilised = FormatNumber(CDbl(txtBsLoss), 0) - FormatNumber(CDbl(txtDisABL), 0)
                    TC_CB_LS_UTIL = FormatNumber(CDbl(TC_SI_BS_LOSS_BF), 0)
                End If
                '=== CYS 2010 modify ===
                TC_SI_AGGREGATE = FormatNumber((CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_SI_TOT")) + CDbl(TCP_PARTNERSHIP)) - CDbl(TC_SI_BS_LOSS_BF), 0)

                'ULUtilised

                TC_CB_LS_BAL_UTIL = FormatNumber(CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_CB_LS_BAL_BF")) - CDbl(TC_CB_LS_UTIL), 0)

                'AggregateIn
                Dim total_loss As Double = 0.0
                If drLstview IsNot Nothing AndAlso drLstview.Rows.Count > 0 Then
                    For Each row As DataRow In drLstview.Rows
                        If CDbl(row("TC_AI_ADJ_IN_LOSS")) < 0 Then
                            total_loss = CDbl(total_loss) + Math.Abs(CDbl(row("TC_AI_ADJ_IN_LOSS")))
                        End If
                    Next
                End If
                '=== CYS 2010 modify ===
                TC_CB_LS_ADJUST_LOSS = FormatNumber(CDbl(total_loss) + CDbl(PARTNER_LOSS), 0)

                TC_SI_AGGREGATE = FormatNumber((CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_SI_TOT")) + CDbl(TCP_PARTNERSHIP)) - CDbl(TC_SI_BS_LOSS_BF), 0)

                TC_TP_AGGR_IN = FormatNumber(CDbl(TC_SI_AGGREGATE) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_NB_OTH_AGGR_STAT")), 0)

                If CDbl(TC_CB_LS_ADJUST_LOSS) >= CDbl(TC_TP_AGGR_IN) Then
                    TC_TP_CURR_LOSS = FormatNumber(CDbl(TC_TP_AGGR_IN), 0)

                    'CurrBsLoss
                    If CDbl(TC_TP_CURR_LOSS) >= CDbl(TC_CB_LS_ADJUST_LOSS) Then
                        TC_CB_LS_UTIL_CURR = FormatNumber(CDbl(TC_CB_LS_ADJUST_LOSS), 0)
                    ElseIf CDbl(TC_TP_CURR_LOSS) < CDbl(TC_CB_LS_ADJUST_LOSS) Then
                        TC_CB_LS_UTIL_CURR = FormatNumber(CDbl(TC_TP_CURR_LOSS), 0)
                    End If
                ElseIf CDbl(TC_CB_LS_ADJUST_LOSS) < CDbl(TC_TP_AGGR_IN) Then
                    TC_TP_CURR_LOSS = FormatNumber(CDbl(TC_CB_LS_ADJUST_LOSS), 0)

                    'CurrBsLoss
                    If CDbl(TC_TP_CURR_LOSS) >= CDbl(TC_CB_LS_ADJUST_LOSS) Then
                        TC_CB_LS_UTIL_CURR = FormatNumber(CDbl(TC_CB_LS_ADJUST_LOSS), 0)
                    ElseIf CDbl(TC_TP_CURR_LOSS) < CDbl(TC_CB_LS_ADJUST_LOSS) Then
                        TC_CB_LS_UTIL_CURR = FormatNumber(CDbl(TC_TP_CURR_LOSS), 0)
                    End If
                End If

                TC_TP_AGGR_IN_LOSS = FormatNumber(CDbl(TC_TP_AGGR_IN) - CDbl(TC_TP_CURR_LOSS), 0)

                'CurrentYrLoss
                TC_CB_LS_UNABSORBED = FormatNumber(CDbl(TC_CB_LS_ADJUST_LOSS) - CDbl(TC_CB_LS_UTIL_CURR), 0)

                'ULBalUtil
                ' HS : 2009 : Change Unabsorbed business loss'
                TC_CB_LS_BAL_CF = FormatNumber(CDbl(TC_CB_LS_BAL_UTIL) + CDbl(TC_CB_LS_UNABSORBED) - CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_CB_LS_SAMOUNT")) - CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_NB_CARRYBCKLOSS")), 0)
                If CDbl(TC_CB_LS_BAL_CF) < 0 Then
                    TC_CB_LS_BAL_CF = 0
                End If

                'ULBalcf
                TC_CB_LS_BALS_CF = FormatNumber(CDbl(TC_CB_LS_BAL_CF) - CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_CB_LS_D_BL")), 0)
                If CDbl(TC_CB_LS_BALS_CF) < 0 Then
                    TC_CB_LS_BALS_CF = 0
                End If

                If GetBoolPLS60FA() Then
                    TC_CB_LS_BAL_CF = 0
                End If

                TC_TP_TOTAL_OTH_EXP = FormatNumber(CDbl(TC_TP_AGGR_IN_LOSS) - (CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_PROSPECTING")) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_QUALIFY_AGRICULTURE")) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_PREOP_BS")) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_FOOD_PRODUCTION")) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_EXP_ALLOWED"))), 0)
                If CDbl(TC_TP_TOTAL_OTH_EXP) < 0 Then
                    TC_TP_TOTAL_OTH_EXP = 0
                    TC_TP_APRV_DONATION = 0
                    TC_TP_ZAKAT = 0
                End If

                'GetLessApprDonation
                Dim YearAccess As String
                Dim TotalAmount1, TotalAmount2, TotalAmount3, TotalAmount4, TotalAmount5, TotalAmount6, TotalAmount7, TotalA1, LessA1, TotalCompareAmount As Double
                Dim CompareAmount1, CompareAmount2, CompareAmount3, CompareAmount4, CompareAmount5, CompareAmount6, CompareAmount7, TotalSum As Double

                TotalAmount1 = 0
                TotalAmount2 = 0
                TotalAmount3 = 0
                TotalAmount4 = 0
                TotalAmount5 = 0
                TotalAmount6 = 0
                TotalAmount7 = 0

                YearAccess = strCYa

                If strPNLKey <> Nothing Then
                    drGetDTApprDonation = GetDTApprDonation(strPNLKey)

                    If drGetDTApprDonation IsNot Nothing AndAlso drGetDTApprDonation.Rows.Count > 0 Then
                        For Each dtrowAppDonation As DataRow In drGetDTApprDonation.Rows
                            If dtrowAppDonation("EXOAD_DETAIL") = "Yes" Then
                                drGetDTApprDonationDetail = GetDTApprDonationDetail(strPNLKey, dtrowAppDonation("EXOAD_SOURCENO"), dtrowAppDonation("EXOAD_EXOADKEY"))

                                If drGetDTApprDonationDetail IsNot Nothing AndAlso drGetDTApprDonationDetail.Rows.Count > 0 Then
                                    For Each dtrowAppDonationDetail As DataRow In drGetDTApprDonationDetail.Rows
                                        Select Case dtrowAppDonationDetail("EXOADD_TYPE")
                                            Case "Gifts of Money to Government"
                                                TotalAmount1 = TotalAmount1 + FormatNumber(CDbl(dtrowAppDonationDetail("EXOADD_AMOUNT")), 0)
                                            Case "Gifts of Money to Approved institutions"
                                                TotalAmount2 = TotalAmount2 + FormatNumber(CDbl(dtrowAppDonationDetail("EXOADD_AMOUNT")), 0)
                                            Case "Gifts of Money or Contribution for Approved Sports Activities"
                                                TotalAmount3 = TotalAmount3 + FormatNumber(CDbl(dtrowAppDonationDetail("EXOADD_AMOUNT")), 0)
                                            Case "Gifts of Money or Contribution for Approved Project of National Interest"
                                                TotalAmount4 = TotalAmount4 + FormatNumber(CDbl(dtrowAppDonationDetail("EXOADD_AMOUNT")), 0)
                                            Case "Gifts of Artifacts, Manuscripts or paintings"
                                                TotalAmount5 = TotalAmount5 + FormatNumber(CDbl(dtrowAppDonationDetail("EXOADD_AMOUNT")), 0)
                                            Case "Gifts of Money to Library"
                                                TotalAmount6 = TotalAmount6 + FormatNumber(CDbl(dtrowAppDonationDetail("EXOADD_AMOUNT")), 0)
                                            Case "Gifts of Paintings to National Art Gallery"
                                                TotalAmount7 = TotalAmount7 + FormatNumber(CDbl(dtrowAppDonationDetail("EXOADD_AMOUNT")), 0)
                                        End Select
                                    Next
                                End If
                            Else
                                Select Case dtrowAppDonation("EXOAD_TYPE")
                                    Case "Gifts of Money to Government"
                                        TotalAmount1 = TotalAmount1 + FormatNumber(CDbl(dtrowAppDonation("EXOAD_AMOUNT")), 0)
                                    Case "Gifts of Money to Approved institutions"
                                        TotalAmount2 = TotalAmount2 + FormatNumber(CDbl(dtrowAppDonation("EXOAD_AMOUNT")), 0)
                                    Case "Gifts of Money or Contribution for Approved Sports Activities"
                                        TotalAmount3 = TotalAmount3 + FormatNumber(CDbl(dtrowAppDonation("EXOAD_AMOUNT")), 0)
                                    Case "Gifts of Money or Contribution for Approved Project of National Interest"
                                        TotalAmount4 = TotalAmount4 + FormatNumber(CDbl(dtrowAppDonation("EXOAD_AMOUNT")), 0)
                                    Case "Gifts of Artifacts, Manuscripts or paintings"
                                        TotalAmount5 = TotalAmount5 + FormatNumber(CDbl(dtrowAppDonation("EXOAD_AMOUNT")), 0)
                                    Case "Gifts of Money to Library"
                                        TotalAmount6 = TotalAmount6 + FormatNumber(CDbl(dtrowAppDonation("EXOAD_AMOUNT")), 0)
                                    Case "Gifts of Paintings to National Art Gallery"
                                        TotalAmount7 = TotalAmount7 + FormatNumber(CDbl(dtrowAppDonation("EXOAD_AMOUNT")), 0)
                                End Select
                            End If
                        Next
                    End If
                End If

                LessA1 = 0

                TotalA1 = CDbl(TC_TP_AGGR_IN)

                CompareAmount1 = FormatNumber(TotalAmount1, 0)
                CompareAmount2 = FormatNumber(TotalAmount2, 0)
                CompareAmount3 = FormatNumber(TotalAmount3, 0)
                CompareAmount4 = FormatNumber(TotalAmount4, 0)
                CompareAmount5 = FormatNumber(TotalAmount5, 0)
                CompareAmount6 = FormatNumber(TotalAmount6, 0)
                CompareAmount7 = FormatNumber(TotalAmount7, 0)

                TotalSum = FormatNumber(CDbl(CompareAmount2) + CDbl(CompareAmount3) + CDbl(CompareAmount4), 0)

                Select Case Val(YearAccess)
                    'NGOHCS 2009
                    Case Is >= 2009
                        LessA1 = TotalA1 * 10 / 100
                        If TotalSum >= LessA1 Then
                            TotalSum = FormatNumber(CDbl(LessA1), 0)
                        End If

                    Case Is > 2006
                        LessA1 = TotalA1 * 7 / 100
                        If TotalSum >= LessA1 Then
                            TotalSum = FormatNumber(CDbl(LessA1), 0)
                        End If

                    Case Is <= 2006
                        LessA1 = TotalA1 * 5 / 100
                        If TotalSum >= LessA1 Then
                            TotalSum = FormatNumber(CDbl(LessA1), 0)
                        End If
                End Select

                TotalCompareAmount = FormatNumber(CDbl(CompareAmount1) + TotalSum + CDbl(CompareAmount5) + CDbl(CompareAmount6) + CDbl(CompareAmount7), 0)

                'ApprDonation
                If TotalCompareAmount >= CDbl(TC_TP_TOTAL_OTH_EXP) Then
                    TC_TP_APRV_DONATION = TC_TP_TOTAL_OTH_EXP
                Else
                    TC_TP_APRV_DONATION = FormatNumber(TotalCompareAmount, 0)
                End If

                'Zakat
                Dim dblzakat As Double

                If strPNLKey <> Nothing And strMainBuz <> Nothing Then

                    dblzakat = 0
                    'azham note
                    'Me.GetDTPLLessApprDonation()
                    dtLessApprDonation = mdlProcess.Load_LessApprove_Donation(strRefNo, strCYa, strPNLKey, strMainBuz, Errorlog)

                    dblzakat = GetDTZakat(strPNLKey)

                    If CDbl(dblzakat) < CDbl(TC_TP_TOTAL_OTH_EXP) Then
                        If CDbl(dblzakat) >= CDbl(TC_TP_TOTAL_OTH_EXP) * 0.025 Then
                            TC_TP_ZAKAT = FormatNumber(CDbl(TC_TP_TOTAL_OTH_EXP) * 0.025, 0)
                        ElseIf CDbl(dblzakat) < CDbl(TC_TP_TOTAL_OTH_EXP) * 0.025 Then
                            TC_TP_ZAKAT = FormatNumber(CDbl(dblzakat), 0)
                        End If
                    ElseIf CDbl(dblzakat) >= CDbl(TC_TP_TOTAL_OTH_EXP) Then
                        TC_TP_ZAKAT = FormatNumber(CDbl(TC_TP_TOTAL_OTH_EXP) * 0.025, 0)
                    End If
                End If

                'cal_totalIncome
                TC_TP_TOTAL_INCOME = FormatNumber(CDbl(TC_TP_TOTAL_OTH_EXP) - (CDbl(TC_TP_APRV_DONATION) + CDbl(TC_TP_ZAKAT) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_CLAIM"))), 0) 'txtClaim
                ' HS : 2009 : C2008.7 : Total Income become -ve'
                If CDbl(TC_TP_TOTAL_INCOME) < 0 Then
                    TC_TP_TOTAL_INCOME = 0
                End If
                ' HS : 2009 : C2008.7 : Total Income become -ve end'

                'totalincome
                TC_TP_CHARGEABLE = FormatNumber(CDbl(TC_TP_TOTAL_INCOME) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_PIONEER_CHARGE")) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_STAT_DIVIDEND")), 0)

                If Val(strCYa) >= 2003 Then
                    TC_TP_APP_CHARGEABLE4A = 0
                    TC_TP_APP_CHARGEABLE5 = 0
                    TC_TP_RATE4A_CHARGEABLE = 0
                    TC_TP_28_CHARGEABLE = 0

                    If GetBoolSME() Then
                        If Val(strCYa) >= 2004 Then
                            If CDbl(TC_TP_CHARGEABLE) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_OPERATIONALHQ_CHARGE")) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_FOREIGN_CHARGE")) <= 500000 Then
                                TC_TP_APP_CHARGEABLE4A = FormatNumber(CDbl(TC_TP_CHARGEABLE) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_OPERATIONALHQ_CHARGE")) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_FOREIGN_CHARGE")), 0)

                                'AppChargeableIn4a
                                TC_TP_RATE4A_CHARGEABLE = FormatNumber(CDbl(TC_TP_APP_CHARGEABLE4A) * (CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_RATE4A")) / 100), 2)
                            Else
                                TC_TP_APP_CHARGEABLE4A = FormatNumber(CDbl(500000), 0)
                                TC_TP_APP_CHARGEABLE5 = FormatNumber((CDbl(TC_TP_CHARGEABLE) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_OPERATIONALHQ_CHARGE")) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_FOREIGN_CHARGE"))) - 500000, 0)

                                'AppChargeableIn4a
                                TC_TP_RATE4A_CHARGEABLE = FormatNumber(CDbl(TC_TP_APP_CHARGEABLE4A) * (CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_RATE4A")) / 100), 2)

                                'AppChargeableIn5
                                TC_TP_28_CHARGEABLE = FormatNumber(CDbl(TC_TP_APP_CHARGEABLE5) * (CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_RATE5")) / 100), 2)
                            End If
                        Else
                            If CDbl(TC_TP_CHARGEABLE) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_OPERATIONALHQ_CHARGE")) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_FOREIGN_CHARGE")) <= 100000 Then
                                TC_TP_APP_CHARGEABLE4A = FormatNumber(CDbl(TC_TP_CHARGEABLE) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_OPERATIONALHQ_CHARGE")) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_FOREIGN_CHARGE")), 0)

                                'AppChargeableIn4a
                                TC_TP_RATE4A_CHARGEABLE = FormatNumber(CDbl(TC_TP_APP_CHARGEABLE4A) * (CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_RATE4A")) / 100), 2)
                            Else
                                TC_TP_APP_CHARGEABLE4A = FormatNumber(CDbl(100000), 0)
                                TC_TP_APP_CHARGEABLE5 = FormatNumber((CDbl(TC_TP_CHARGEABLE) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_OPERATIONALHQ_CHARGE")) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_FOREIGN_CHARGE"))) - 100000, 0)

                                'AppChargeableIn4a
                                TC_TP_RATE4A_CHARGEABLE = FormatNumber(CDbl(TC_TP_APP_CHARGEABLE4A) * (CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_RATE4A")) / 100), 2)

                                'AppChargeableIn5
                                TC_TP_28_CHARGEABLE = FormatNumber(CDbl(TC_TP_APP_CHARGEABLE5) * (CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_RATE5")) / 100), 2)
                            End If
                        End If

                    Else
                        TC_TP_APP_CHARGEABLE5 = FormatNumber(CDbl(TC_TP_CHARGEABLE) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_OPERATIONALHQ_CHARGE")) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_FOREIGN_CHARGE")), 0)

                        'AppChargeableIn5
                        TC_TP_28_CHARGEABLE = FormatNumber(CDbl(TC_TP_APP_CHARGEABLE5) * (CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_RATE5")) / 100), 2)
                    End If
                Else
                    TC_TP_APP_CHARGEABLE5 = FormatNumber(CDbl(TC_TP_CHARGEABLE) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_OPERATIONALHQ_CHARGE")) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_FOREIGN_CHARGE")), 0)

                    'AppChargeableIn5
                    TC_TP_28_CHARGEABLE = FormatNumber(CDbl(TC_TP_APP_CHARGEABLE5) * (CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_RATE5")) / 100), 2)
                End If

                'totaltaxcharged
                TC_TP_TOT_TAX_CHARGED = FormatNumber(CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_RATE1_CHARGEABLE")) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_RATE2_CHARGEABLE")) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_RATE3_CHARGEABLE")) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_RATE4_CHARGEABLE")) + CDbl(TC_TP_RATE4A_CHARGEABLE) + CDbl(TC_TP_28_CHARGEABLE) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_RATE5_CHARGEABLE")), 2)

                'TotalSetOff
                TC_TP_TOT_SETOFF = FormatNumber(CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_SEC110")) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_SEC110B")) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_SEC110_OTHERS")) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_SEC132")) + CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_SEC133")), 2)

                'cal_totalpayable
                TC_TP_PAYABLE = FormatNumber(CDbl(TC_TP_TOT_TAX_CHARGED) - CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_SEC6B_REBATE")) - CDbl(TC_TP_TOT_SETOFF), 2)

                If CDbl(TC_TP_PAYABLE) < 0 Then
                    TC_TP_INCOME_TP2 = 0.0
                    TC_TP_PAYABLE_BAL = FormatNumber(CDbl(TC_TP_INCOME_TP2) - CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_INSTALL")), 2)
                Else
                    TC_TP_INCOME_TP2 = FormatNumber(CDbl(TC_TP_PAYABLE), 2)
                    TC_TP_PAYABLE_BAL = FormatNumber(CDbl(TC_TP_INCOME_TP2) - CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_INSTALL")), 2)
                End If

                'ExcessiveDifferencePenalty
                TC_TP_INCOME_TP3 = FormatNumber(CDbl(TC_TP_INCOME_TP2) - CDbl(drTCUnabsorbedBusinessLoss.Rows(0)("TC_TP_ESTIMATED_TP")))
                TC_TP_ALL_DIFF = FormatNumber((CDbl(TC_TP_INCOME_TP2) * 0.3), 2)
                TC_TP_EX_DIFF = FormatNumber((CDbl(TC_TP_INCOME_TP3)) - (CDbl(TC_TP_ALL_DIFF)), 2)
                If CDbl(TC_TP_EX_DIFF) < 0 Then
                    TC_TP_EX_DIFF = 0
                End If
                TC_TP_PEN_DIFF = FormatNumber((CDbl(TC_TP_EX_DIFF) * 0.1), 2)

                If mdlCA.Update_AggregateTAXCOMPATION(TC_SI_BS_LOSS_BF, TC_CB_LS_UTIL, TC_SI_AGGREGATE, TC_CB_LS_BAL_UTIL, TC_CB_LS_ADJUST_LOSS, TC_TP_AGGR_IN, TC_TP_CURR_LOSS, TC_CB_LS_UTIL_CURR, TC_CB_LS_UNABSORBED, TC_CB_LS_BAL_CF, TC_CB_LS_BALS_CF, TC_TP_TOTAL_OTH_EXP, TC_TP_APRV_DONATION, TC_TP_ZAKAT, TC_TP_TOTAL_INCOME, TC_TP_CHARGEABLE, TC_TP_APP_CHARGEABLE4A, TC_TP_APP_CHARGEABLE5, TC_TP_RATE4A_CHARGEABLE, TC_TP_28_CHARGEABLE, TC_TP_TOT_TAX_CHARGED, TC_TP_TOT_SETOFF, TC_TP_PAYABLE, TC_TP_INCOME_TP2, TC_TP_PAYABLE_BAL, TC_TP_INCOME_TP3, TC_TP_ALL_DIFF, TC_TP_EX_DIFF, TC_TP_PEN_DIFF, TC_TP_AGGR_IN_LOSS, Errorlog) = False Then
                    MsgBox("Failed to update aggregate tax computation." & vbCrLf & Errorlog.ErrorName & vbCrLf & Errorlog.ErrorMessage, MsgBoxStyle.Critical)
                End If
            End If
            Return True
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return False
        End Try
    End Function




End Module