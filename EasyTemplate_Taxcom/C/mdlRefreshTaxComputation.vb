Imports System.Data.SqlClient

Module mdlRefreshTaxComputation
#Region "NON ALLOWABLE TAXABLE"

    Public Function GetAJDTotalRevenueExpenditure(ByVal strRefNo As String, ByVal strCYa As String, ByVal SourceNo As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum(cast([RE_AMOUNT] as money))),0) as sumx FROM [REVENUE_EXPENDITURE] WHERE [RE_REF_NO]=@refNo AND [RE_YA]=@ya AND [RE_SOURCENO]=@source"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@ya", SqlDbType.NVarChar, 5).Value = strCYa
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo

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

    Public Function GetAJDTotalOtherExpenditure(ByVal strRefNo As String, ByVal strCYa As String, ByVal SourceNo As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum(cast([OE_AMOUNT] as money))),0) as sumx FROM [OTHER_EXPENDITURE] WHERE [OE_REF_NO]=@refno AND [OE_YA]=@ya AND [OE_SOURCENO]=@source"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@ya", SqlDbType.NVarChar, 5).Value = strCYa
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo

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
    Public Function GetAJDTotalExpOtherInterest(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

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
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpContractPay(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exc_amount as money))),0) as sumx from expenses_contract where exc_key=@key and exc_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exc_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpDirectorFee(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exdf_amount as money))),0) as sumx from expenses_directors_fee where exdf_key=@key and exdf_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exdf_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpTechnicalFee(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(extf_amount as money))),0) as sumx from expenses_tech_fee where extf_key=@key and extf_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and extf_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpSalary(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exs_amount as money))),0) as sumx from expenses_salary where exs_key=@key and exs_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exs_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpRoyalty(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exro_amount as money))),0) as sumx from expenses_royalty where exro_key=@key and exro_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exro_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpRental(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exrent_amount as money))),0) as sumx from expenses_rental where exrent_key=@key and exrent_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exrent_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpRepairMaintenance(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exrep_amount as money))),0) as sumx from expenses_repair where exrep_key=@key and exrep_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exrep_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpRND(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exres_amount as money))),0) as sumx from expenses_research where exres_key=@key and exres_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exres_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpPromotionAdvertisement(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exp_amount as money))),0) as sumx from expenses_promote where exp_key=@key and exp_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exp_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpTravel(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(ext_amount as money))),0) as sumx from expenses_travel where ext_key=@key and ext_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and ext_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpJKDM(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exjk_amount as money))),0) as sumx from expenses_jkdm where exjk_key=@key and exjk_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exjk_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpEmployeeStock(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exes_amount as money))),0) as sumx from expenses_empl_stock where exes_key=@key and exes_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exes_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpLegal(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exl_amount as money))),0) as sumx from expenses_legal where exl_key=@key and exl_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and EXL_DEDUCTIBLE=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpEntertainStaff(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exoes_amount as money))),0) as sumx from other_entertainstaff where exoes_key=@key and exoes_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and EXOES_DEDUCTIBLE=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpOthersExpenses(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exo_amount as money))),0) as sumx from other_expenses where exo_key=@key and exo_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exo_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpDepreciation(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exodep_amount as money))),0) as sumx from other_exdepreciation where exodep_key=@key and exodep_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exodep_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpEntertainNonStaff(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exoens_amount as money))),0) as sumx from other_entertainnstaff where exoens_key=@key and exoens_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exoens_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpProvision(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exopa_amount as money))),0) as sumx from other_exprovisionacc where exopa_key=@key and exopa_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exopa_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpCompoundPenalty(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exop_amount as money))),0) as sumx from other_expenalty where exop_key=@key and exop_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exop_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpLeavePassage(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exolp_amount as money))),0) as sumx from other_exleavepassage where exolp_key=@key and exolp_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exolp_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpFAWrittenOff(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exowo_amount as money))),0) as sumx from other_exfawrittenoff where exowo_key=@key and exowo_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exowo_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpInitialSubscript(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exois_amount as money))),0) as sumx from other_exinitialsub where exois_key=@key and exois_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exois_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpCapitalExpenditure(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exoce_amount as money))),0) as sumx from other_excapitalexp where exoce_key=@key and exoce_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exoce_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalDepreciation(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exdep_amount as money))),0) as sumx from expenses_depreciation where exdep_key = @key and exdep_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exdep_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalOtherNonAllowExpenses(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exna_amount as money))),0) as sumx from expenses_nonallow where exna_key = @key and exna_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exna_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalPurchases(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(plfpur_amount as money))),0) as sumx from plfst_purchase where plfpur_key=@key and PLFPUR_SOURCENO=@source"

            If strDeductible <> "" Then
                StrSQL += " and plfpur_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpDonationNonApproved(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exonad_amount as money))),0) as sumx from other_exnapprdonation where exonad_key=@key and exonad_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exonad_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpInterestRestrict(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exir_amount as money))),0) as sumx from expenses_interestrestrict where exir_key=@key and exir_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exir_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpUnrealLossFE(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exour_amount as money))),0) as sumx from other_exurlossforeign where exour_key=@key and exour_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exour_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpRealLossFENonTrade(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exor_amount as money))),0) as sumx from other_exrlossforeign where exor_key=@key and exor_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exor_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpLossDisposalFA(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exold_amount as money))),0) as sumx from other_exlossdisposalfa where exold_key=@key and exold_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exold_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalOtherExrLossForeignt(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exort_amount as money))),0) as sumx from other_exrlossforeignt where exort_key=@key and exort_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exort_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpDonationApproved(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exoad_amount as money))),0) as sumx from other_exapprdonation where exoad_key=@key and exoad_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exoad_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpZakat(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exoz_amount as money))),0) as sumx from other_exzakat where exoz_key=@key and exoz_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exoz_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function

    Public Function GetAJDTotalRealFETrade(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(irfet_amount as money))),0) as sumx from income_realfet where irfet_key=@key and irfet_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exi_deductible=@ded"
            End If

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetTotalNonAllowLoss(ByVal strRefNo As String, ByVal strCYa As String, ByVal SourceNo As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

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
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo


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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function

    Public Function GetNonTaxableIncome(ByVal strRefNo As String, ByVal strCYa As String, ByVal SourceNo As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum(cast([NT_AMOUNT] as money))),0) as sumx FROM [NON_TAXABLE_INCOME] WHERE [NT_REF_NO]=@refno AND [NT_YA]=@ya AND [NT_SOURCENO]=@source AND [NT_CATEGORIZED]<>'Other'"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@ya", SqlDbType.NVarChar, 5).Value = strCYa
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo


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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetTotalTaxableIncome(ByVal strRefNo As String, ByVal strCYa As String, ByVal SourceNo As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum(cast([TI_AMOUNT] as money))),0) as sumx FROM [TAXABLE_INCOME] WHERE [TI_REF_NO]=@refno AND [TI_YA]=@ya AND [TI_SOURCENO]=@source"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@ya", SqlDbType.NVarChar, 5).Value = strCYa
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo


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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetTotalMovementNormal_AddBack(ByVal strRefNo As String, ByVal strCYa As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT Isnull(sum(MM_Amount),0) as sumx FROM [MOVEMENT_ADD] WHERE MM_PARENTID in (SELECT MM_ID FROM MOVEMENT_NORMAL WHERE MM_REFNO=@refno AND MM_YA=@ya) AND MM_AddBack=1"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@ya", SqlDbType.NVarChar, 5).Value = strCYa


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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetTotalMovementNormal_Deduct(ByVal strRefNo As String, ByVal strCYa As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT Isnull(sum(MM_Amount),0) as sumx FROM [MOVEMENT_DEDUCT] WHERE MM_PARENTID in (SELECT MM_ID FROM MOVEMENT_NORMAL WHERE MM_REFNO=@refno AND MM_YA=@ya) AND MM_Deduct=1"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@ya", SqlDbType.NVarChar, 5).Value = strCYa


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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetTotalMovementComplex_AddBack(ByVal strRefNo As String, ByVal strCYa As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT SUM(totalsum) as sumx "
            StrSQL += "FROM ("
            StrSQL += "SELECT Isnull(SUM(MM_GENERAL),0) as totalsum FROM MOVEMENT_COMPLEX_ADD "
            StrSQL += "WHERE MM_PARENTID in (SELECT MM_ID FROM MOVEMENT_COMPLEX "
            StrSQL += "WHERE MM_REFNO=@refno AND MM_YA=@ya) AND MM_GENERAL_ADDBACK=1 "
            StrSQL += "UNION ALL "
            StrSQL += "SELECT Isnull(SUM(MM_SPECIFIC_ALLOWABLE),0) as totalsum FROM MOVEMENT_COMPLEX_ADD "
            StrSQL += "WHERE MM_PARENTID in (SELECT MM_ID FROM MOVEMENT_COMPLEX "
            StrSQL += "WHERE MM_REFNO=@refno AND MM_YA=@ya) AND MM_SPECIFIC_ALLOWABLE_ADDBACK=1 "
            StrSQL += "UNION ALL "
            StrSQL += "SELECT Isnull(SUM(MM_SPECIFIC_NONALLOWABLE),0) as totalsum FROM MOVEMENT_COMPLEX_ADD "
            StrSQL += "WHERE MM_PARENTID in (SELECT MM_ID FROM MOVEMENT_COMPLEX "
            StrSQL += "WHERE MM_REFNO=@refno AND MM_YA=@ya) AND MM_SPECIFIC_NONALLOWABLE_ADDBACK=1 "
            StrSQL += ") a"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@ya", SqlDbType.NVarChar, 5).Value = strCYa


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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
    Public Function GetTotalMovementComplex_Deduct(ByVal strRefNo As String, ByVal strCYa As String, Optional ByRef ErrorLog As clsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT SUM(totalsum) as sumx "
            StrSQL += "FROM ("
            StrSQL += "SELECT Isnull(SUM(MM_GENERAL),0) as totalsum FROM MOVEMENT_COMPLEX_DEDUCT "
            StrSQL += "WHERE MM_PARENTID in (SELECT MM_ID FROM MOVEMENT_COMPLEX "
            StrSQL += "WHERE MM_REFNO=@refno AND MM_YA=@ya) AND MM_GENERAL_DEDUCT=1 "
            StrSQL += "UNION ALL "
            StrSQL += "SELECT Isnull(SUM(MM_SPECIFIC_ALLOWABLE),0) as totalsum FROM MOVEMENT_COMPLEX_DEDUCT "
            StrSQL += "WHERE MM_PARENTID in (SELECT MM_ID FROM MOVEMENT_COMPLEX "
            StrSQL += "WHERE MM_REFNO=@refno AND MM_YA=@ya) AND MM_SPECIFIC_ALLOWABLE_DEDUCT=1 "
            StrSQL += "UNION ALL "
            StrSQL += "SELECT Isnull(SUM(MM_SPECIFIC_NONALLOWABLE),0) as totalsum FROM MOVEMENT_COMPLEX_DEDUCT "
            StrSQL += "WHERE MM_PARENTID in (SELECT MM_ID FROM MOVEMENT_COMPLEX "
            StrSQL += "WHERE MM_REFNO=@refno AND MM_YA=@ya) AND MM_SPECIFIC_NONALLOWABLE_DEDUCT=1 "
            StrSQL += ") a"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@ya", SqlDbType.NVarChar, 5).Value = strCYa


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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
#End Region
#Region "LOAD"

    Public Function GetTCBusinessSource(ByVal strRefNo As String, ByVal strCYa As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try

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
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_TaxCom_DividendIncome(ByVal PNLID As Integer, ByVal SourceNo As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Decimal
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL(sum(case when di_disclose='Yes' then di_net else di_gross end),0) as sumx from dividend_income where di_key=@di_key and di_sourceno=@di_sourceno and di_transfer='Section 4c' or di_transfer='Single Tier'"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@di_key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@di_sourceno", SqlDbType.Int).Value = SourceNo

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return dt.Rows(0)("sumx")
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function

    Public Function Load_TaxCom_RentalIncome(ByVal PNLID As Integer, ByVal SourceNo As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Decimal
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum([RI_AMOUNT] )),0) as sumx FROM [RENTAL_INCOME] WHERE [ri_key]=@ri_key AND [ri_sourceno]=@ri_sourceno AND [RI_STATUS4d]='Sec 4d' or [RI_STATUS4d]='Section 4d'"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ri_key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@ri_sourceno", SqlDbType.Int).Value = SourceNo

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return dt.Rows(0)("sumx")
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function

    Public Function Load_TaxCom_RoyaltIncome(ByVal PNLID As Integer, ByVal SourceNo As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Decimal
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum([NOBRI_AMOUNT])),0) as sumx FROM [INCOME_NBROYALTY] WHERE [NOBRI_KEY]=@NOBRI_KEY AND [NOBRI_SOURCENO]=@NOBRI_SOURCENO"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NOBRI_KEY", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@NOBRI_SOURCENO", SqlDbType.Int).Value = SourceNo

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return dt.Rows(0)("sumx")
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function

    Public Function Load_TaxCom_InterestIncome(ByVal PNLID As Integer, ByVal SourceNo As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Decimal
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum([NOBII_AMOUNT])),0) as sumx FROM [INCOME_NBINTEREST] WHERE [NOBII_KEY]=@NOBII_KEY AND [NOBII_SOURCENO]=@NOBII_SOURCENO"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NOBII_KEY", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@NOBII_SOURCENO", SqlDbType.Int).Value = SourceNo

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return dt.Rows(0)("sumx")
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function

    Public Function Load_TaxCom_OtherIncome(ByVal PNLID As Integer, ByVal SourceNo As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Decimal
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum([OI_AMOUNT])),0) as sumx FROM [OTHER_INCOME] WHERE [OI_KEY]=@OI_KEY AND [OI_SOURCENO]=@OI_SOURCENO"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@OI_KEY", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@OI_SOURCENO", SqlDbType.Int).Value = SourceNo

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return dt.Rows(0)("sumx")
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function

    Public Function Load_TaxCom_NonSourceBusinessIncome(ByVal PNLID As Integer, ByVal SourceNo As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Decimal
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum([NSBI_AMOUNT])),0) as sumx FROM [NONSOURCE_BUSINESSINCOME] WHERE [NSBI_KEY]= @NSBI_KEY AND [NSBI_SOURCENO]=@NSBI_SOURCENO"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NSBI_KEY", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@NSBI_SOURCENO", SqlDbType.Int).Value = SourceNo

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return dt.Rows(0)("sumx")
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function

    Public Function Load_TaxCom_ExemptDividend(ByVal PNLID As Integer, ByVal SourceNo As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Decimal
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum([ED_AMOUNT] )),0) as sumx FROM [EXEMPT_DIVIDEND] WHERE [ED_KEY]=@ED_KEY AND [ED_SOURCENO]=@ED_SOURCENO"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ED_KEY", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@ED_SOURCENO", SqlDbType.Int).Value = SourceNo

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return dt.Rows(0)("sumx")
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function

    Public Function Load_TaxCom_OtherBusinessIncome(ByVal PNLID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Decimal
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum(cast([OBI_GROSS_INCOME] as money))),0) as sumx FROM [OTHER_BUSINESS_INCOME] WHERE [OBI_KEY]=@OI_KEY"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@OI_KEY", SqlDbType.Int).Value = PNLID

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return dt.Rows(0)("sumx")
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function

    Public Function Load_TaxCom_OtherBusinessIncomeBySource(ByVal PNLID As Integer, ByVal SourceNo As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Decimal
        Try

            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum(cast([OBI_GROSS_INCOME] as money))),0) as sumx FROM [OTHER_BUSINESS_INCOME] WHERE [OBI_KEY]=@data and [OBI_SOURCENO]=@sourceno"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@data", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@sourceno", SqlDbType.Int).Value = SourceNo

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return dt.Rows(0)("sumx")
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
            AddListOfError(ErrorLog)
            Return 0
        End Try
    End Function
#End Region
#Region "TAXCOM"

#End Region
    Public Function RefreshTaxcom(ByVal RefNo As String, ByVal YA As String, Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            Dim TC_AI_DIVIDEND As Decimal = 0
            Dim TC_AI_RENTAL As Decimal = 0
            Dim TC_AI_ROYALTY As Decimal = 0
            Dim TC_AI_INTEREST As Decimal = 0
            Dim TC_AI_SEC4A As Decimal = 0
            Dim TC_AI_PNL_BAL As String = 0
            Dim TC_AI_ADJ_BS_EXP_NA_EXP As Decimal = 0
            Dim TC_AI_ADJ_BS_IN_NA_LOS As Decimal = 0
            Dim TC_AI_ADJ_BS_IN_NT_IN As Decimal = 0
            Dim TC_AI_TOT_NONBS_IN As Decimal = 0
            Dim TC_AI_TOT_BS_IN As Decimal = 0
            Dim TC_AI_ADJ_BS_IN_TAX_IN As Decimal = 0
            Dim TC_AI_ADJ_BS_EXP_INT As Decimal = 0
            Dim TC_AI_ADJ_BS_EXP_RV_EXP As Decimal = 0
            Dim TC_AI_ADJ_BS_EXP_CLAIM As Decimal = 0
            Dim TC_AI_TOT_ADJ_BS_EXP As Decimal = 0
            Dim TC_OTHERDEDUCTION As Decimal = 0
            Dim TC_AI_TOT_ADJ_BS_IN As Decimal = 0
            Dim TC_AI_ADJ_IN_LOSS As Decimal = 0
            Dim TC_TOTAL_NBI As Decimal = 0


            Dim PL_GROSS_PROFIT As Decimal = 0
            Dim OTHER_BIZ_INCOME As Decimal = 0
            Dim TOTAL_NONBIZ_INCOME As Decimal = 0
            Dim TOTAL_NONSOURCEBIZ_INCOME As Decimal = 0
            Dim NONALLOWABLE_EXPENSES As Decimal = 0
            Dim EXEMPT_DIVIDEND As Decimal = 0
            Dim NONTAXABLE_INCOME As Decimal = 0

            Dim dtTemp As DataTable = Nothing
            Dim IncomeTotal As Decimal = 0
            Dim dblTotalExpenditure As Decimal = 0

            Dim adjustedincome As Decimal = 0
            Dim businessincome As Decimal = 0
            Dim businessincomeadjust As Decimal = 0
            Dim businessexpendadjust As Decimal = 0
            Dim TaxcomID As Integer = 0
            Dim dtRow As DataRow = Nothing
            Dim PNLID As Integer = 0
            Dim SourceNo As Integer = 0
            Dim dtTaxcom As DataTable = ADO.Load_Tax_Computation(RefNo, YA)
            Dim dtPNL As DataTable = Nothing


            If dtTaxcom IsNot Nothing Then

                For i As Integer = 0 To dtTaxcom.Rows.Count - 1
                    TaxcomID = IIf(IsDBNull(dtTaxcom.Rows(i)("TC_KEY")), 0, dtTaxcom.Rows(i)("TC_KEY"))
                    SourceNo = IIf(IsDBNull(dtTaxcom.Rows(i)("TC_BUSINESS")), 0, dtTaxcom.Rows(i)("TC_BUSINESS"))
                    dtTemp = Nothing

                    dtPNL = ADO.Load_PNL(RefNo, YA, Errorlog)

                    If dtPNL IsNot Nothing Then
                        PNLID = IIf(IsDBNull(dtPNL.Rows(0)("PL_KEY")), 0, dtPNL.Rows(0)("PL_KEY"))

                        PL_GROSS_PROFIT = IIf(IsDBNull(dtPNL.Rows(0)("pl_gross_profit")), 0, dtPNL.Rows(0)("pl_gross_profit"))

                        OTHER_BIZ_INCOME = mdlRefreshTaxComputation.Load_TaxCom_OtherBusinessIncome(PNLID)

                        TC_AI_DIVIDEND = mdlRefreshTaxComputation.Load_TaxCom_DividendIncome(PNLID, SourceNo)
                        TC_AI_RENTAL = mdlRefreshTaxComputation.Load_TaxCom_RentalIncome(PNLID, SourceNo)
                        TC_AI_ROYALTY = mdlRefreshTaxComputation.Load_TaxCom_RoyaltIncome(PNLID, SourceNo)
                        TC_AI_INTEREST = mdlRefreshTaxComputation.Load_TaxCom_InterestIncome(PNLID, SourceNo)
                        TC_AI_SEC4A = mdlRefreshTaxComputation.Load_TaxCom_OtherIncome(PNLID, SourceNo)
                        TOTAL_NONSOURCEBIZ_INCOME = mdlRefreshTaxComputation.Load_TaxCom_NonSourceBusinessIncome(PNLID, SourceNo)
                        TOTAL_NONBIZ_INCOME = GetTotalNonBusinessIncome(TC_AI_DIVIDEND, TC_AI_RENTAL, TC_AI_ROYALTY, TC_AI_INTEREST, TC_AI_SEC4A)

                        TC_AI_PNL_BAL = PL_GROSS_PROFIT - OTHER_BIZ_INCOME + TOTAL_NONBIZ_INCOME + TOTAL_NONSOURCEBIZ_INCOME + TC_AI_ADJ_BS_IN_NT_IN - TC_AI_ADJ_BS_EXP_NA_EXP

                        NONALLOWABLE_EXPENSES = mdlRefreshTaxComputation.GetTotalNonAllowableExpenses(RefNo, YA, PNLID)
                        EXEMPT_DIVIDEND = mdlRefreshTaxComputation.Load_TaxCom_ExemptDividend(PNLID, SourceNo)
                        NONTAXABLE_INCOME = mdlRefreshTaxComputation.GetNonTaxableIncome(RefNo, YA, SourceNo)

                        TC_AI_ADJ_BS_EXP_NA_EXP = NONALLOWABLE_EXPENSES

                        TC_AI_ADJ_BS_IN_NA_LOS = mdlRefreshTaxComputation.GetTotalNonAllowLoss(RefNo, YA, SourceNo) + mdlRefreshTaxComputation.GetAJDTotalExpUnrealLossFE(PNLID, SourceNo, "") + mdlRefreshTaxComputation.GetAJDTotalExpRealLossFENonTrade(PNLID, SourceNo, "") + mdlRefreshTaxComputation.GetAJDTotalExpLossDisposalFA(PNLID, SourceNo, "")

                        TC_AI_ADJ_BS_IN_NT_IN = 0 + EXEMPT_DIVIDEND + NONTAXABLE_INCOME

                        TC_TOTAL_NBI = TC_AI_DIVIDEND + TC_AI_RENTAL + TC_AI_ROYALTY + TC_AI_INTEREST + TC_AI_SEC4A

                        TC_OTHERDEDUCTION = IIf(IsDBNull(dtTaxcom.Rows(i)("TC_OTHERDEDUCTION")), 0, dtTaxcom.Rows(i)("TC_OTHERDEDUCTION"))

                        If SourceNo = 1 Then
                            If SourceNo = IIf(IsDBNull(dtPNL.Rows(0)("PL_MAINBUZ")), 1, dtPNL.Rows(0)("PL_MAINBUZ")) Then
                                TC_AI_PNL_BAL = PL_GROSS_PROFIT - OTHER_BIZ_INCOME + TC_TOTAL_NBI + TOTAL_NONSOURCEBIZ_INCOME + TC_AI_ADJ_BS_IN_NT_IN - TC_AI_ADJ_BS_EXP_NA_EXP - IIf(IsDBNull(dtPNL.Rows(0)("pl_other_exp_balance")), 0, dtPNL.Rows(0)("pl_other_exp_balance")) + mdlRefreshTaxComputation.GetAJDTotalRealFETrade(PNLID, SourceNo, "")
                            Else
                                TC_AI_PNL_BAL = PL_GROSS_PROFIT - OTHER_BIZ_INCOME + TC_TOTAL_NBI + TOTAL_NONSOURCEBIZ_INCOME + TC_AI_ADJ_BS_IN_NT_IN - TC_AI_ADJ_BS_EXP_NA_EXP + mdlRefreshTaxComputation.GetAJDTotalRealFETrade(PNLID, SourceNo, "")
                            End If
                        Else
                            If SourceNo = IIf(IsDBNull(dtPNL.Rows(0)("PL_MAINBUZ")), 1, dtPNL.Rows(0)("PL_MAINBUZ")) Then
                                TC_AI_PNL_BAL = Load_TaxCom_OtherBusinessIncomeBySource(PNLID, SourceNo) + TC_TOTAL_NBI + TOTAL_NONSOURCEBIZ_INCOME + TC_AI_ADJ_BS_IN_NT_IN - TC_AI_ADJ_BS_EXP_NA_EXP - IIf(IsDBNull(dtPNL.Rows(0)("pl_other_exp_balance")), 0, dtPNL.Rows(0)("pl_other_exp_balance")) + mdlRefreshTaxComputation.GetAJDTotalRealFETrade(PNLID, SourceNo, "")
                            Else
                                TC_AI_PNL_BAL = Load_TaxCom_OtherBusinessIncomeBySource(PNLID, SourceNo) + TC_TOTAL_NBI + TOTAL_NONSOURCEBIZ_INCOME + TC_AI_ADJ_BS_IN_NT_IN - TC_AI_ADJ_BS_EXP_NA_EXP + mdlRefreshTaxComputation.GetAJDTotalRealFETrade(PNLID, SourceNo, "")
                            End If
                        End If

                        IncomeTotal = 0

                        TC_AI_TOT_NONBS_IN = TC_AI_DIVIDEND + TC_AI_RENTAL + TC_AI_INTEREST + TC_AI_ROYALTY + TC_AI_SEC4A

                        IncomeTotal = TC_AI_PNL_BAL - TC_AI_TOT_NONBS_IN - CDbl(IIf(IsDBNull(dtTaxcom.Rows(i)("TC_AI_OTH_BS_IN")), 0, dtTaxcom.Rows(i)("TC_AI_OTH_BS_IN")))

                        TC_AI_TOT_BS_IN = IncomeTotal

                        TC_AI_ADJ_BS_IN_TAX_IN = mdlRefreshTaxComputation.GetTotalTaxableIncome(RefNo, YA, SourceNo)
                        TC_AI_ADJ_BS_EXP_INT = mdlRefreshTaxComputation.GetAJDTotalExpInterestRestrict(RefNo, SourceNo, "")
                        TC_AI_ADJ_BS_EXP_RV_EXP = mdlRefreshTaxComputation.GetAJDTotalRevenueExpenditure(RefNo, YA, SourceNo)

                        TC_AI_ADJ_BS_EXP_CLAIM = mdlRefreshTaxComputation.GetAJDTotalOtherExpenditure(RefNo, YA, SourceNo)

                        TC_AI_ADJ_BS_EXP_NA_EXP = mdlRefreshTaxComputation.GetTotalNonAllowableExpenses(RefNo, YA, PNLID)

                        dblTotalExpenditure = TC_AI_ADJ_BS_EXP_INT + TC_AI_ADJ_BS_EXP_NA_EXP - TC_AI_ADJ_BS_EXP_RV_EXP + TC_AI_ADJ_BS_EXP_CLAIM + TC_OTHERDEDUCTION + IIf(IsDBNull(dtTaxcom.Rows(i)("TC_MININGALLOWNANCE")), 0, dtTaxcom.Rows(i)("TC_MININGALLOWNANCE")) + IIf(IsDBNull(dtTaxcom.Rows(i)("TC_MININGEXPENSES")), 0, dtTaxcom.Rows(i)("TC_MININGEXPENSES"))

                        TC_AI_TOT_ADJ_BS_EXP = dblTotalExpenditure

                        TC_AI_TOT_ADJ_BS_IN = TC_AI_ADJ_BS_IN_NA_LOS + IIf(IsDBNull(dtTaxcom.Rows(i)("TC_SURPLUSRECOVERED")), 0, dtTaxcom.Rows(i)("TC_SURPLUSRECOVERED")) - TC_AI_ADJ_BS_IN_NT_IN + TC_AI_ADJ_BS_IN_TAX_IN

                        adjustedincome = 0
                        businessincome = 0
                        businessincomeadjust = 0
                        businessexpendadjust = 0

                        businessincome = TC_AI_TOT_BS_IN
                        businessincomeadjust = TC_AI_TOT_ADJ_BS_IN
                        businessexpendadjust = TC_AI_TOT_ADJ_BS_EXP
                        adjustedincome = businessincome + businessincomeadjust + businessexpendadjust

                        TC_AI_ADJ_IN_LOSS = adjustedincome


                        ADO.Update_AdjTaxcom(TaxcomID, TC_AI_DIVIDEND, TC_AI_RENTAL, TC_AI_ROYALTY, TC_AI_INTEREST, TC_AI_SEC4A, TC_AI_PNL_BAL, TC_AI_ADJ_BS_EXP_NA_EXP, TC_AI_ADJ_BS_IN_NA_LOS, TC_AI_ADJ_BS_IN_NT_IN, TC_AI_TOT_NONBS_IN, TC_AI_TOT_BS_IN, TC_AI_ADJ_BS_IN_TAX_IN, TC_AI_ADJ_BS_EXP_INT, TC_AI_ADJ_BS_EXP_RV_EXP, TC_AI_ADJ_BS_EXP_CLAIM, TC_AI_TOT_ADJ_BS_EXP, TC_OTHERDEDUCTION, TC_AI_TOT_ADJ_BS_IN, TC_AI_ADJ_IN_LOSS)


                    End If


                Next

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
            AddListOfError(Errorlog)
            Return True
        End Try
    End Function
    Public Function GetTotalNonBusinessIncome(TC_AI_DIVIDEND As Decimal, TC_AI_RENTAL As Decimal, TC_AI_ROYALTY As Decimal, TC_AI_INTEREST As Decimal, TC_AI_SEC4A As Decimal) As Decimal
        Try
            Dim dblTotalNBI As Double = 0
            dblTotalNBI = TC_AI_DIVIDEND + TC_AI_RENTAL + TC_AI_ROYALTY + TC_AI_INTEREST + TC_AI_SEC4A

            Return dblTotalNBI
        Catch ex As Exception
            Return 0
        End Try

    End Function
    Public Function GetTotalNonAllowableExpenses(ByVal RefNo As String, ByVal YA As String, ByVal PNLID As Integer, Optional ByRef Errorlog As clsError = Nothing) As Double
        Try
            Dim strDeductible As String = "No"
            Dim dblTotalNonAllowExpenses As Double = 0
            Dim tmpMovement As Decimal = 0
            Dim SourceNo As Integer = 0
            Dim drBusinessSource As DataTable = mdlRefreshTaxComputation.GetTCBusinessSource(RefNo, YA)

            If drBusinessSource IsNot Nothing AndAlso drBusinessSource.Rows.Count > 0 Then

                For Each row As DataRow In drBusinessSource.Rows
                    SourceNo = row("tc_business")
                    strDeductible = "No"

                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpOtherInterest(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpContractPay(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpDirectorFee(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpTechnicalFee(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpSalary(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpRoyalty(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpRental(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpRepairMaintenance(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpRND(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpPromotionAdvertisement(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpTravel(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpJKDM(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpEmployeeStock(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpLegal(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpEntertainStaff(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpOthersExpenses(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpDepreciation(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpEntertainNonStaff(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpProvision(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpCompoundPenalty(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpLeavePassage(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpFAWrittenOff(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpInitialSubscript(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpCapitalExpenditure(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalDepreciation(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalOtherNonAllowExpenses(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalPurchases(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpDonationNonApproved(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpInterestRestrict(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpUnrealLossFE(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpRealLossFENonTrade(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpLossDisposalFA(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetTotalNonAllowLoss(RefNo, YA, SourceNo)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalOtherExrLossForeignt(RefNo, SourceNo, strDeductible)

                    strDeductible = ""
                    Application.DoEvents()
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpDonationApproved(RefNo, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpZakat(RefNo, SourceNo, strDeductible)

                    'Normal movement
                    tmpMovement = mdlRefreshTaxComputation.GetTotalMovementNormal_AddBack(RefNo, SourceNo, Errorlog)

                    tmpMovement -= mdlRefreshTaxComputation.GetTotalMovementNormal_Deduct(RefNo, SourceNo, Errorlog)

                    dblTotalNonAllowExpenses += tmpMovement

                    tmpMovement = 0

                    'Complex movement

                    tmpMovement = mdlRefreshTaxComputation.GetTotalMovementComplex_AddBack(RefNo, SourceNo, Errorlog)

                    tmpMovement -= mdlRefreshTaxComputation.GetTotalMovementComplex_Deduct(RefNo, SourceNo, Errorlog)

                    dblTotalNonAllowExpenses += tmpMovement
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
            AddListOfError(Errorlog)

            Return 0
        End Try
    End Function
End Module
