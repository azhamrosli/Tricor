Imports System.Data.SqlClient

Module mdlRefreshTaxComputation
#Region "NON ALLOWABLE TAXABLE"

    Public Function GetAJDTotalRevenueExpenditure(ByVal strRefNo As String, ByVal strCYa As String, ByVal SourceNo As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum(cast([RE_AMOUNT] as money))),0) as sumx FROM [REVENUE_EXPENDITURE] WHERE [RE_REF_NO]=@refNo AND [RE_YA]=@ya AND [RE_SOURCENO]=@source"

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function

    Public Function GetAJDTotalOtherExpenditure(ByVal strRefNo As String, ByVal strCYa As String, ByVal SourceNo As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum(cast([OE_AMOUNT] as money))),0) as sumx FROM [OTHER_EXPENDITURE] WHERE [OE_REF_NO]=@refno AND [OE_YA]=@ya AND [OE_SOURCENO]=@source"

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpOtherInterest(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exi_amount as money))),0) as sumx from expenses_interest where exi_key=@key and exi_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exi_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpContractPay(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exc_amount as money))),0) as sumx from expenses_contract where exc_key=@key and exc_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exc_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpDirectorFee(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exdf_amount as money))),0) as sumx from expenses_directors_fee where exdf_key=@key and exdf_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exdf_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpTechnicalFee(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(extf_amount as money))),0) as sumx from expenses_tech_fee where extf_key=@key and extf_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and extf_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpSalary(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exs_amount as money))),0) as sumx from expenses_salary where exs_key=@key and exs_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exs_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpRoyalty(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exro_amount as money))),0) as sumx from expenses_royalty where exro_key=@key and exro_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exro_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpRental(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exrent_amount as money))),0) as sumx from expenses_rental where exrent_key=@key and exrent_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exrent_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpRepairMaintenance(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exrep_amount as money))),0) as sumx from expenses_repair where exrep_key=@key and exrep_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exrep_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpRND(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exres_amount as money))),0) as sumx from expenses_research where exres_key=@key and exres_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exres_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpPromotionAdvertisement(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exp_amount as money))),0) as sumx from expenses_promote where exp_key=@key and exp_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exp_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpTravel(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(ext_amount as money))),0) as sumx from expenses_travel where ext_key=@key and ext_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and ext_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpJKDM(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exjk_amount as money))),0) as sumx from expenses_jkdm where exjk_key=@key and exjk_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exjk_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpEmployeeStock(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exes_amount as money))),0) as sumx from expenses_empl_stock where exes_key=@key and exes_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exes_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpLegal(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exl_amount as money))),0) as sumx from expenses_legal where exl_key=@key and exl_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and EXL_DEDUCTIBLE=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpEntertainStaff(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exoes_amount as money))),0) as sumx from other_entertainstaff where exoes_key=@key and exoes_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and EXOES_DEDUCTIBLE=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpOthersExpenses(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exo_amount as money))),0) as sumx from other_expenses where exo_key=@key and exo_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exo_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpDepreciation(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exodep_amount as money))),0) as sumx from other_exdepreciation where exodep_key=@key and exodep_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exodep_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpEntertainNonStaff(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exoens_amount as money))),0) as sumx from other_entertainnstaff where exoens_key=@key and exoens_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exoens_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpProvision(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exopa_amount as money))),0) as sumx from other_exprovisionacc where exopa_key=@key and exopa_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exopa_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpCompoundPenalty(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exop_amount as money))),0) as sumx from other_expenalty where exop_key=@key and exop_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exop_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpLeavePassage(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exolp_amount as money))),0) as sumx from other_exleavepassage where exolp_key=@key and exolp_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exolp_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpFAWrittenOff(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exowo_amount as money))),0) as sumx from other_exfawrittenoff where exowo_key=@key and exowo_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exowo_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpInitialSubscript(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exois_amount as money))),0) as sumx from other_exinitialsub where exois_key=@key and exois_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exois_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpCapitalExpenditure(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exoce_amount as money))),0) as sumx from other_excapitalexp where exoce_key=@key and exoce_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exoce_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalDepreciation(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exdep_amount as money))),0) as sumx from expenses_depreciation where exdep_key = @key and exdep_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exdep_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalOtherNonAllowExpenses(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exna_amount as money))),0) as sumx from expenses_nonallow where exna_key = @key and exna_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exna_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalPurchases(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(plfpur_amount as money))),0) as sumx from plfst_purchase where plfpur_key=@key and PLFPUR_SOURCENO=@source"

            If strDeductible <> "" Then
                StrSQL += " and plfpur_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpDonationNonApproved(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exonad_amount as money))),0) as sumx from other_exnapprdonation where exonad_key=@key and exonad_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exonad_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpInterestRestrict(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exir_amount as money))),0) as sumx from expenses_interestrestrict where exir_key=@key and exir_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exir_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@source", SqlDbType.Int).Value = SourceNo
            SQLcmd.Parameters.Add("@ded", SqlDbType.NVarChar, 30).Value = strDeductible

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpUnrealLossFE(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exour_amount as money))),0) as sumx from other_exurlossforeign where exour_key=@key and exour_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exour_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpRealLossFENonTrade(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exor_amount as money))),0) as sumx from other_exrlossforeign where exor_key=@key and exor_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exor_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpLossDisposalFA(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exold_amount as money))),0) as sumx from other_exlossdisposalfa where exold_key=@key and exold_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exold_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalOtherExrLossForeignt(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exort_amount as money))),0) as sumx from other_exrlossforeignt where exort_key=@key and exort_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exort_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpDonationApproved(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exoad_amount as money))),0) as sumx from other_exapprdonation where exoad_key=@key and exoad_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exoad_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetAJDTotalExpZakat(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(exoz_amount as money))),0) as sumx from other_exzakat where exoz_key=@key and exoz_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exoz_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function

    Public Function GetAJDTotalRealFETrade(ByVal PNLID As Integer, ByVal SourceNo As Integer, ByVal strDeductible As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ISNULL((sum(cast(irfet_amount as money))),0) as sumx from income_realfet where irfet_key=@key and irfet_sourceno=@source"

            If strDeductible <> "" Then
                StrSQL += " and exi_deductible=@ded"
            End If

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetTotalNonAllowLoss(ByVal strRefNo As String, ByVal strCYa As String, ByVal SourceNo As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum(cast([NL_AMOUNT] as money))),0) as sumx FROM [NON_ALLOW_LOSS] WHERE [NL_REF_NO]=@refno AND [NL_YA]=@ya AND [NL_SOURCENO]=@source AND [NL_CATEGORIZED]=''"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function

    Public Function GetNonTaxableIncome(ByVal strRefNo As String, ByVal strCYa As String, ByVal SourceNo As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum(cast([NT_AMOUNT] as money))),0) as sumx FROM [NON_TAXABLE_INCOME] WHERE [NT_REF_NO]=@refno AND [NT_YA]=@ya AND [NT_SOURCENO]=@source AND [NT_CATEGORIZED]<>'Other'"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetTotalTaxableIncome(ByVal strRefNo As String, ByVal strCYa As String, ByVal SourceNo As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum(cast([TI_AMOUNT] as money))),0) as sumx FROM [TAXABLE_INCOME] WHERE [TI_REF_NO]=@refno AND [TI_YA]=@ya AND [TI_SOURCENO]=@source"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
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
            Return 0
        End Try
    End Function
    Public Function GetTotalMovementNormal_AddBack(ByVal strRefNo As String, ByVal strCYa As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT Isnull(sum(MM_Amount),0) as sumx FROM [MOVEMENT_ADD] WHERE MM_PARENTID in (SELECT MM_ID FROM MOVEMENT_NORMAL WHERE MM_REFNO=@refno AND MM_YA=@ya) AND MM_AddBack=1"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@ya", SqlDbType.NVarChar, 5).Value = strCYa


            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
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
            Return 0
        End Try
    End Function
    Public Function GetTotalMovementNormal_Deduct(ByVal strRefNo As String, ByVal strCYa As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT Isnull(sum(MM_Amount),0) as sumx FROM [MOVEMENT_DEDUCT] WHERE MM_PARENTID in (SELECT MM_ID FROM MOVEMENT_NORMAL WHERE MM_REFNO=@refno AND MM_YA=@ya) AND MM_Deduct=1"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@ya", SqlDbType.NVarChar, 5).Value = strCYa


            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
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
            Return 0
        End Try
    End Function
    Public Function GetTotalMovementComplex_AddBack(ByVal strRefNo As String, ByVal strCYa As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

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
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@ya", SqlDbType.NVarChar, 5).Value = strCYa


            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
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
            Return 0
        End Try
    End Function
    Public Function GetTotalMovementComplex_Deduct(ByVal strRefNo As String, ByVal strCYa As String, Optional ByRef ErrorLog As ClsError = Nothing) As Double
        Try

            Dim SqlCon As SqlConnection = Nothing

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
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@ya", SqlDbType.NVarChar, 5).Value = strCYa


            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CDbl(dt.Rows(0)("sumx"))
            Else
                Return 0
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
            Return 0
        End Try
    End Function
#End Region
#Region "LOAD"

    Public Function GetTCBusinessSource(ByVal strRefNo As String, ByVal strCYa As String, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select tc_business from tax_computation where tc_ref_no=@refno and tc_ya=@ya order by tc_business"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = strRefNo
            SQLcmd.Parameters.Add("@ya", SqlDbType.NVarChar, 5).Value = strCYa

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
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
            Return Nothing
        End Try
    End Function
    Public Function Load_TaxCom_DividendIncome(ByVal PNLID As Integer, ByVal SourceNo As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As Decimal
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL(sum(case when di_disclose='Yes' then di_net else di_gross end),0) as sumx from dividend_income where di_key=@di_key and di_sourceno=@di_sourceno and di_transfer='Section 4c' or di_transfer='Single Tier'"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@di_key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@di_sourceno", SqlDbType.Int).Value = SourceNo

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return dt.Rows(0)("sumx")
            Else
                Return 0
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
            Return 0
        End Try
    End Function

    Public Function Load_TaxCom_RentalIncome(ByVal PNLID As Integer, ByVal SourceNo As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As Decimal
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum([RI_AMOUNT] )),0) as sumx FROM [RENTAL_INCOME] WHERE [ri_key]=@ri_key AND [ri_sourceno]=@ri_sourceno AND [RI_STATUS4d]='Sec 4d' or [RI_STATUS4d]='Section 4d'"

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@ri_key", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@ri_sourceno", SqlDbType.Int).Value = SourceNo

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return dt.Rows(0)("sumx")
            Else
                Return 0
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
            Return 0
        End Try
    End Function

    Public Function Load_TaxCom_RoyaltIncome(ByVal PNLID As Integer, ByVal SourceNo As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As Decimal
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum([NOBRI_AMOUNT])),0) as sumx FROM [INCOME_NBROYALTY] WHERE [NOBRI_KEY]=@NOBRI_KEY AND [NOBRI_SOURCENO]=@NOBRI_SOURCENO"

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@NOBRI_KEY", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@NOBRI_SOURCENO", SqlDbType.Int).Value = SourceNo

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return dt.Rows(0)("sumx")
            Else
                Return 0
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
            Return 0
        End Try
    End Function

    Public Function Load_TaxCom_InterestIncome(ByVal PNLID As Integer, ByVal SourceNo As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As Decimal
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum([NOBII_AMOUNT])),0) as sumx FROM [INCOME_NBINTEREST] WHERE [NOBII_KEY]=@NOBII_KEY AND [NOBII_SOURCENO]=@NOBII_SOURCENO"

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@NOBII_KEY", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@NOBII_SOURCENO", SqlDbType.Int).Value = SourceNo

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return dt.Rows(0)("sumx")
            Else
                Return 0
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
            Return 0
        End Try
    End Function

    Public Function Load_TaxCom_OtherIncome(ByVal PNLID As Integer, ByVal SourceNo As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As Decimal
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum([OI_AMOUNT])),0) as sumx FROM [OTHER_INCOME] WHERE [OI_KEY]=@OI_KEY AND [OI_SOURCENO]=@OI_SOURCENO"

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@OI_KEY", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@OI_SOURCENO", SqlDbType.Int).Value = SourceNo

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return dt.Rows(0)("sumx")
            Else
                Return 0
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
            Return 0
        End Try
    End Function

    Public Function Load_TaxCom_NonSourceBusinessIncome(ByVal PNLID As Integer, ByVal SourceNo As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As Decimal
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum([NSBI_AMOUNT])),0) as sumx FROM [NONSOURCE_BUSINESSINCOME] WHERE [NSBI_KEY]= @NSBI_KEY AND [NSBI_SOURCENO]=@NSBI_SOURCENO"

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@NSBI_KEY", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@NSBI_SOURCENO", SqlDbType.Int).Value = SourceNo

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return dt.Rows(0)("sumx")
            Else
                Return 0
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
            Return 0
        End Try
    End Function

    Public Function Load_TaxCom_ExemptDividend(ByVal PNLID As Integer, ByVal SourceNo As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As Decimal
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum([ED_AMOUNT] )),0) as sumx FROM [EXEMPT_DIVIDEND] WHERE [ED_KEY]=@ED_KEY AND [ED_SOURCENO]=@ED_SOURCENO"

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@ED_KEY", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@ED_SOURCENO", SqlDbType.Int).Value = SourceNo

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return dt.Rows(0)("sumx")
            Else
                Return 0
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
            Return 0
        End Try
    End Function

    Public Function Load_TaxCom_OtherBusinessIncome(ByVal PNLID As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As Decimal
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum(cast([OBI_GROSS_INCOME] as money))),0) as sumx FROM [OTHER_BUSINESS_INCOME] WHERE [OBI_KEY]=@OI_KEY"

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@OI_KEY", SqlDbType.Int).Value = PNLID

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return dt.Rows(0)("sumx")
            Else
                Return 0
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
            Return 0
        End Try
    End Function

    Public Function Load_TaxCom_OtherBusinessIncomeBySource(ByVal PNLID As Integer, ByVal SourceNo As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As Decimal
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ISNULL((sum(cast([OBI_GROSS_INCOME] as money))),0) as sumx FROM [OTHER_BUSINESS_INCOME] WHERE [OBI_KEY]=@data and [OBI_SOURCENO]=@sourceno"

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@data", SqlDbType.Int).Value = PNLID
            SQLcmd.Parameters.Add("@sourceno", SqlDbType.Int).Value = SourceNo

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return dt.Rows(0)("sumx")
            Else
                Return 0
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
            Return 0
        End Try
    End Function
#End Region
#Region "TAXCOM"

#End Region

    Public Function RefreshInvestmentHolding(ByVal RefNo As String, ByVal YA As String, Optional ByRef Errorlog As ClsError = Nothing) As Boolean
        Try
            Dim dtIH As DataTable = Nothing
            Dim dtPL As DataTable = Nothing
            Dim dtIHInsert As DataTable = Nothing
            Dim dtIHOtherIn As DataTable = Nothing

            Dim PL_NONTAX_IN_EXM_DIV As Decimal = 0
            Dim PL_TREGROSS As Decimal = 0
            Dim PL_OTH_IN_INTEREST As Decimal = 0
            Dim IH_INTEREST_EXEMPT As Decimal = 0
            Dim IH_INTEREST_EXP As Decimal = 0
            Dim IH_INT_TOTAL As Decimal = 0
            Dim InterestIn As Decimal = 0
            Dim IH_RENTIBA_IN As Decimal = 0
            Dim IH_RENTAL_ATTR As Decimal = 0
            Dim IH_RENTAL_ASSESS As Decimal = 0
            Dim IH_RENTAL_QUIT As Decimal = 0
            Dim IH_RENTAL_INSUR As Decimal = 0
            Dim IH_RENTAL_REPAIR As Decimal = 0
            Dim IH_RENTAL_RENEW As Decimal = 0
            Dim IH_RENTIBA_INSUR As Decimal = 0
            Dim IH_RENTIBA_EXP As Decimal = 0
            Dim IH_RENTIBA_IBA As Decimal = 0
            Dim IH_GAIN_REAL_INVEST As Decimal = 0
            Dim IH_PE_TOTAL As Decimal = 0
            '   Dim IH_RENTAL_NET As Decimal = 0

            Dim PL_OTH_IN_RENTAL As Decimal = 0
            Dim dblRental As Decimal = 0
            Dim dblRentalIBA As Decimal = 0

            Dim NONEXEMPT As Decimal = 0
            dtIH = ADO.Load_InvestmentHolding(RefNo, YA)
            dtPL = ADO.LoadPNL_Search(RefNo, YA)

            If dtIH IsNot Nothing AndAlso dtPL IsNot Nothing Then

                If IsDBNull(dtIH.Rows(0)("IH_KEY")) = False Then
                    dtIHInsert = ADO.Load_InvestmentHoldingInterest(dtIH.Rows(0)("IH_KEY"), Errorlog)
                    dtIHOtherIn = ADO.Load_InvestmentHoldingOtherIn(dtIH.Rows(0)("IH_KEY"), Errorlog)
                    If IsDBNull(dtPL.Rows(0).Item("PL_NONTAX_IN_EXM_DIV")) = False AndAlso IsNumeric(dtPL.Rows(0).Item("PL_NONTAX_IN_EXM_DIV")) Then
                        PL_NONTAX_IN_EXM_DIV = dtPL.Rows(0).Item("PL_NONTAX_IN_EXM_DIV")
                    End If

                    If IsDBNull(dtPL.Rows(0).Item("PL_TREGROSS")) = False AndAlso IsNumeric(dtPL.Rows(0).Item("PL_TREGROSS")) Then
                        PL_TREGROSS = dtPL.Rows(0).Item("PL_TREGROSS")
                    End If

                    If IsDBNull(dtPL.Rows(0).Item("PL_OTH_IN_INTEREST")) = False AndAlso IsNumeric(dtPL.Rows(0).Item("PL_OTH_IN_INTEREST")) Then
                        PL_OTH_IN_INTEREST = dtPL.Rows(0).Item("PL_OTH_IN_INTEREST")
                    End If

                    If dtIHInsert IsNot Nothing Then
                        If IsDBNull(dtIHInsert.Rows(0).Item("IH_INT_TOTAL")) = False AndAlso IsNumeric(dtIHInsert.Rows(0).Item("IH_INT_TOTAL")) Then
                            IH_INT_TOTAL = dtIHInsert.Rows(0).Item("IH_INT_TOTAL")
                        End If
                    End If
                    InterestIn = PL_OTH_IN_INTEREST + IH_INT_TOTAL

                    If IsDBNull(dtIH.Rows(0).Item("IH_INTEREST_EXEMPT")) = False AndAlso IsNumeric(dtIH.Rows(0).Item("IH_INTEREST_EXEMPT")) Then
                        PL_OTH_IN_INTEREST = dtIH.Rows(0).Item("IH_INTEREST_EXEMPT")
                    End If

                    If IsDBNull(dtIH.Rows(0).Item("IH_INTEREST_EXP")) = False AndAlso IsNumeric(dtIH.Rows(0).Item("IH_INTEREST_EXP")) Then
                        IH_INTEREST_EXP = dtIH.Rows(0).Item("IH_INTEREST_EXP")
                    End If

                    If IsDBNull(dtIH.Rows(0).Item("IH_RENTIBA_IN")) = False AndAlso IsNumeric(dtIH.Rows(0).Item("IH_RENTIBA_IN")) Then
                        IH_RENTIBA_IN = dtIH.Rows(0).Item("IH_RENTIBA_IN")
                    End If

                    If IsDBNull(dtIH.Rows(0).Item("PL_OTH_IN_RENTAL")) = False AndAlso IsNumeric(dtIH.Rows(0).Item("PL_OTH_IN_RENTAL")) Then
                        PL_OTH_IN_RENTAL = dtIH.Rows(0).Item("PL_OTH_IN_RENTAL")
                    End If

                    If IsDBNull(dtIH.Rows(0).Item("IH_RENTAL_ATTR")) = False AndAlso IsNumeric(dtIH.Rows(0).Item("IH_RENTAL_ATTR")) Then
                        IH_RENTAL_ATTR = dtIH.Rows(0).Item("IH_RENTAL_ATTR")
                    End If

                    If IsDBNull(dtIH.Rows(0).Item("IH_RENTAL_ASSESS")) = False AndAlso IsNumeric(dtIH.Rows(0).Item("IH_RENTAL_ASSESS")) Then
                        IH_RENTAL_ASSESS = dtIH.Rows(0).Item("IH_RENTAL_ASSESS")
                    End If

                    If IsDBNull(dtIH.Rows(0).Item("IH_RENTAL_QUIT")) = False AndAlso IsNumeric(dtIH.Rows(0).Item("IH_RENTAL_QUIT")) Then
                        IH_RENTAL_QUIT = dtIH.Rows(0).Item("IH_RENTAL_QUIT")
                    End If

                    If IsDBNull(dtIH.Rows(0).Item("IH_RENTAL_INSUR")) = False AndAlso IsNumeric(dtIH.Rows(0).Item("IH_RENTAL_INSUR")) Then
                        IH_RENTAL_INSUR = dtIH.Rows(0).Item("IH_RENTAL_INSUR")
                    End If

                    If IsDBNull(dtIH.Rows(0).Item("IH_RENTAL_REPAIR")) = False AndAlso IsNumeric(dtIH.Rows(0).Item("IH_RENTAL_REPAIR")) Then
                        IH_RENTAL_REPAIR = dtIH.Rows(0).Item("IH_RENTAL_REPAIR")
                    End If

                    If IsDBNull(dtIH.Rows(0).Item("IH_RENTAL_RENEW")) = False AndAlso IsNumeric(dtIH.Rows(0).Item("IH_RENTAL_RENEW")) Then
                        IH_RENTAL_RENEW = dtIH.Rows(0).Item("IH_RENTAL_RENEW")
                    End If

                    If IsDBNull(dtIH.Rows(0).Item("IH_RENTIBA_INSUR")) = False AndAlso IsNumeric(dtIH.Rows(0).Item("IH_RENTIBA_INSUR")) Then
                        IH_RENTIBA_INSUR = dtIH.Rows(0).Item("IH_RENTIBA_INSUR")
                    End If

                    If IsDBNull(dtIH.Rows(0).Item("IH_RENTIBA_EXP")) = False AndAlso IsNumeric(dtIH.Rows(0).Item("IH_RENTIBA_EXP")) Then
                        IH_RENTIBA_EXP = dtIH.Rows(0).Item("IH_RENTIBA_EXP")
                    End If

                    If IsDBNull(dtIH.Rows(0).Item("IH_RENTIBA_IBA")) = False AndAlso IsNumeric(dtIH.Rows(0).Item("IH_RENTIBA_IBA")) Then
                        IH_RENTIBA_IBA = dtIH.Rows(0).Item("IH_RENTIBA_IBA")
                    End If


                    If IsDBNull(dtIH.Rows(0).Item("IH_RENTIBA_IBA")) = False AndAlso IsNumeric(dtIH.Rows(0).Item("IH_RENTIBA_IBA")) Then
                        IH_RENTIBA_IBA = dtIH.Rows(0).Item("IH_RENTIBA_IBA")
                    End If

                    If IsDBNull(dtIH.Rows(0).Item("IH_GAIN_REAL_INVEST")) = False AndAlso IsNumeric(dtIH.Rows(0).Item("IH_GAIN_REAL_INVEST")) Then
                        IH_GAIN_REAL_INVEST = dtIH.Rows(0).Item("IH_GAIN_REAL_INVEST")
                    End If

                    If IsDBNull(dtIH.Rows(0).Item("IH_PE_TOTAL")) = False AndAlso IsNumeric(dtIH.Rows(0).Item("IH_PE_TOTAL")) Then
                        IH_PE_TOTAL = dtIH.Rows(0).Item("IH_PE_TOTAL")
                    End If

                    'DIVIDEND ==============================================================================================  
                    If PL_NONTAX_IN_EXM_DIV <= PL_NONTAX_IN_EXM_DIV Then
                        dtIH.Rows(0)("IH_DIVIDEND_NET") = "0"
                    ElseIf PL_TREGROSS > PL_NONTAX_IN_EXM_DIV Then
                        dtIH.Rows(0)("IH_DIVIDEND_NET") = PL_NONTAX_IN_EXM_DIV - PL_NONTAX_IN_EXM_DIV
                    End If
                    'DIVIDEND ==============================================================================================

                    'INTEREST ==============================================================================================
                    NONEXEMPT = InterestIn - PL_OTH_IN_INTEREST

                    If NONEXEMPT >= 0 Then
                        dtIH.Rows(0)("IH_INTEREST_NONEXEMPT") = NONEXEMPT
                    Else
                        PL_OTH_IN_INTEREST = "0"
                        dtIH.Rows(0)("IH_INTEREST_NONEXEMPT") = InterestIn
                    End If

                    If CDec(dtIH.Rows(0)("IH_INTEREST_NONEXEMPT")) <= IH_INTEREST_EXP Then
                        dtIH.Rows(0)("IH_INTEREST_NET") = "0"
                    ElseIf CDec(dtIH.Rows(0)("IH_INTEREST_NONEXEMPT")) > IH_INTEREST_EXP Then
                        dtIH.Rows(0)("IH_INTEREST_NET") = CDec(dtIH.Rows(0)("IH_INTEREST_NONEXEMPT")) - IH_INTEREST_EXP
                    Else
                        dtIH.Rows(0)("IH_INTEREST_NET") = "0"
                    End If
                    'INTEREST ==============================================================================================
                    'RENTAL ================================================================================================
                    If PL_OTH_IN_RENTAL < PL_OTH_IN_RENTAL Then
                        PL_OTH_IN_RENTAL = 0
                    Else
                        PL_OTH_IN_RENTAL = PL_OTH_IN_RENTAL - PL_OTH_IN_RENTAL
                    End If

                    dblRentalIBA = PL_OTH_IN_RENTAL - IH_RENTAL_ATTR - IH_RENTAL_ASSESS - IH_RENTAL_QUIT - IH_RENTIBA_INSUR - IH_RENTAL_REPAIR - IH_RENTAL_RENEW - IH_RENTIBA_EXP - IH_RENTIBA_IBA

                    If dblRentalIBA <= 0 Then dblRentalIBA = 0


                    If (dblRental + dblRentalIBA) <= 0 Then
                        dtIH.Rows(0)("IH_RENTAL_NET") = "0"
                    ElseIf (dblRental + dblRentalIBA) > 0 Then
                        dtIH.Rows(0)("IH_RENTAL_NET") = FormatNumber(dblRental + dblRentalIBA, 0)
                    End If
                    'RENTAL =================================================================================================
                    'NET TOTAL ==============================================================================================
                    ' FormatNumber(CDbl(dicInvestmentHolding("txtNetDividend")) + CDbl(dicInvestmentHolding("txtNetInterest")) + CDbl(dicInvestmentHolding("txtNetRental")), 0)
                    dtIH.Rows(0)("IH_NET_TOTAL") = CDec(dtIH.Rows(0)("IH_DIVIDEND_NET")) + CDec(dtIH.Rows(0)("IH_INTEREST_NET")) + CDec(dtIH.Rows(0)("IH_RENTAL_NET"))
                    dtIH.Rows(0)("IH_NET_EXDIV_TOTAL") = CDec(dtIH.Rows(0)("IH_INTEREST_NET")) + CDec(dtIH.Rows(0)("IH_RENTAL_NET"))

                    If CInt(YA) >= 2008 Then
                        dtIH.Rows(0)("IH_STAT_DIVIDEND") = CDec(dtIH.Rows(0)("IH_DIVIDEND_NET"))
                    End If
                    'NET TOTAL ==============================================================================================
                    'Calc5P GROSS============================================================================================
                    'dicInvestmentHolding("txt5PGrossIn") = FormatNumber((CDbl(dicInvestmentHolding("txtDividendNonExempt")) + CDbl(dicInvestmentHolding("txtInterestIn")) + CDbl(dicInvestmentHolding("txtRentalIn")) + CDbl(dicInvestmentHolding("txtRentalIBA"))) * 0.05, 0)
                    Dim SingleTier As Decimal = ADO.Get_TotalExemptDivSingleTier(RefNo, YA, Errorlog)
                    dtIH.Rows(0)("IH_5P_GROSS_IN") = FormatNumber((PL_TREGROSS + InterestIn + PL_OTH_IN_RENTAL + IH_RENTIBA_IN) * 0.05, 0)
                    'If CDbl(dicInvestmentHolding("txtDividendExempt")) + CDbl(dicInvestmentHolding("txtDividendNonExempt")) + CDbl(dicInvestmentHolding("txtInterestIn")) + CDbl(dicInvestmentHolding("txtRentalIn")) + CDbl(dicInvestmentHolding("txtRentalIBA")) + CDbl(dicInvestmentHolding("txtGainRealInvest")) - CDbl(GetTotalExemptDiv_SingleTier()) > 0 Then
                    If PL_NONTAX_IN_EXM_DIV + PL_TREGROSS + InterestIn + PL_OTH_IN_RENTAL + IH_RENTIBA_IN + IH_RENTIBA_IBA + IH_GAIN_REAL_INVEST + SingleTier Then
                        '(CDbl(dicInvestmentHolding("txtDividendNonExempt")) + CDbl(dicInvestmentHolding("txtInterestIn")) + CDbl(dicInvestmentHolding("txtRentalIn")) + CDbl(dicInvestmentHolding("txtRentalIBA"))) 

                        Dim TotalSub As Decimal = (PL_NONTAX_IN_EXM_DIV + PL_TREGROSS + InterestIn + IH_RENTIBA_IN + IH_RENTIBA_IBA + IH_GAIN_REAL_INVEST + SingleTier)
                        IH_PE_TOTAL = IH_PE_TOTAL - ((IH_PE_TOTAL * SingleTier) / TotalSub)
                        dtIH.Rows(0)("IH_PE_TOTAL") = IH_PE_TOTAL
                        dtIH.Rows(0)("IH_CALC_EXP") = IH_PE_TOTAL * (PL_NONTAX_IN_EXM_DIV + PL_TREGROSS + InterestIn + IH_RENTIBA_IN + IH_RENTIBA_IBA) / (4 * (PL_NONTAX_IN_EXM_DIV + PL_TREGROSS + InterestIn + IH_RENTIBA_IN + IH_RENTIBA_IBA + IH_GAIN_REAL_INVEST + SingleTier))
                    End If
                    If CDec(dtIH.Rows(0)("IH_5P_GROSS_IN")) <= CDec(dtIH.Rows(0)("IH_CALC_EXP")) Then
                        dtIH.Rows(0)("IH_EXP_ALLOWED") = CDec(dtIH.Rows(0)("IH_5P_GROSS_IN"))
                    Else
                        dtIH.Rows(0)("IH_EXP_ALLOWED") = CDec(dtIH.Rows(0)("IH_CALC_EXP"))
                    End If
                    'Calc5P GROSS============================================================================================
                    'AGG INCOME==============================================================================================
                    'IH_TP_AGGR_IN
                    If CInt(YA) < 2008 Then
                        dtIH.Rows(0)("IH_EXP_ALLOWED") = CDec(dtIH.Rows(0)("IH_NET_TOTAL")) + CDec(dtIH.Rows(0)("PL_OTH_IN_ROYALTY")) + CDec(dtIH.Rows(0)("PL_OTH_IN_OTHER")) + CDec(dtIH.Rows(0)("IH_OTHER_EXPENSES")) + CDec(dtIH.Rows(0)("IH_ADDITION"))
                    Else
                        dtIH.Rows(0)("IH_EXP_ALLOWED") = CDec(dtIH.Rows(0)("IH_NET_EXDIV_TOTAL")) + CDec(dtIH.Rows(0)("PL_OTH_IN_ROYALTY")) + CDec(dtIH.Rows(0)("PL_OTH_IN_OTHER")) + CDec(dtIH.Rows(0)("IH_OTHER_EXPENSES")) + CDec(dtIH.Rows(0)("IH_ADDITION"))
                    End If
                    'AGG INCOME==============================================================================================
                    'TOTAL EXPENSES==========================================================================================
                    If CDec(dtIH.Rows(0)("IH_EXP_ALLOWED")) < CDec(dtIH.Rows(0)("IH_NET_EXDIV_TOTAL")) Then
                        dtIH.Rows(0)("IH_TOTAL_OTH_EXP") = "0"
                    ElseIf CDec(dtIH.Rows(0)("IH_EXP_ALLOWED")) >= CDec(dtIH.Rows(0)("IH_NET_EXDIV_TOTAL")) Then
                        dtIH.Rows(0)("IH_TOTAL_OTH_EXP") = CDec(dtIH.Rows(0)("IH_EXP_ALLOWED")) - CDec(dtIH.Rows(0)("IH_NET_EXDIV_TOTAL"))
                    End If
                    'TOTAL EXPENSES==========================================================================================

                    If IsDBNull(dtPL.Rows(0)("PL_TOTALY")) Then
                        If Not String.IsNullOrEmpty(dtPL.Rows(0).Item("PL_TOTALY").ToString) Then
                            dtIH.Rows(0)("IH_ITP_SETOFF") = dtPL.Rows(0)("PL_TOTALY").ToString
                        End If
                    End If
                    dtIH.Rows(0)("IH_ITP_SETOFF") = dtPL.Rows(0)("PL_TTAXDEDUCTION").ToString

                    ADO.LoadLessApprDonationInvest(RefNo, YA, dtIH.Rows(0))
                    ADO.Investment_CalculateZakat(dtPL.Rows(0)("PL_KEY"), dtIH.Rows(0), Errorlog)
                    'TotalIncome==========================================================================================
                    'FormatNumber(CDbl(dicInvestmentHolding("txtTotalOthExp")) - (CDbl(dicInvestmentHolding("txtApprDonation")) + CDbl(dicInvestmentHolding("txtZakat")) + CDbl(dicInvestmentHolding("txtClaim"))), 0)
                    dtIH.Rows(0)("IH_TOTAL_INCOME") = CDec(dtIH.Rows(0)("IH_TOTAL_OTH_EXP")) - (CDec(dtIH.Rows(0)("IH_APPR_DONATION")) + CDec(dtIH.Rows(0)("IH_ZAKAT")) + CDec(dtIH.Rows(0)("IH_CLAIM")))
                    ADO.Investment_chargeable_apportionment(RefNo, YA, dtIH.Rows(0))

                    Return ADO.Update_InvestmentHolding(dtIH, RefNo, YA, Errorlog)
                End If
            End If
            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(Errorlog)
            Return False
        End Try
    End Function
    
    Public Function RefreshTaxcom(ByVal RefNo As String, ByVal YA As String, Optional ByRef Errorlog As ClsError = Nothing) As Boolean
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
                        TC_AI_ADJ_BS_IN_TAX_IN += GetTaxableIncome_Movement(RefNo, YA, 2, Errorlog)

                        TC_AI_ADJ_BS_EXP_INT = mdlRefreshTaxComputation.GetAJDTotalExpInterestRestrict(PNLID, SourceNo, "")
                        TC_AI_ADJ_BS_EXP_RV_EXP = mdlRefreshTaxComputation.GetAJDTotalRevenueExpenditure(RefNo, YA, SourceNo)
                        TC_AI_ADJ_BS_EXP_RV_EXP += GetRevenueExpenditure_Movement(RefNo, YA, 3, Errorlog)

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

                        Application.DoEvents()

                        ADO.Update_AdjTaxcom(TaxcomID, TC_AI_DIVIDEND, TC_AI_RENTAL, TC_AI_ROYALTY, TC_AI_INTEREST, TC_AI_SEC4A, TC_AI_PNL_BAL, TC_AI_ADJ_BS_EXP_NA_EXP, TC_AI_ADJ_BS_IN_NA_LOS, TC_AI_ADJ_BS_IN_NT_IN, TC_AI_TOT_NONBS_IN, TC_AI_TOT_BS_IN, TC_AI_ADJ_BS_IN_TAX_IN, TC_AI_ADJ_BS_EXP_INT, TC_AI_ADJ_BS_EXP_RV_EXP, TC_AI_ADJ_BS_EXP_CLAIM, TC_AI_TOT_ADJ_BS_EXP, TC_OTHERDEDUCTION, TC_AI_TOT_ADJ_BS_IN, TC_AI_ADJ_IN_LOSS)
                    End If


                Next

            End If

            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(Errorlog)
            Return True
        End Try
    End Function
    Public Function GetTaxableIncome_Movement(ByVal RefNo As String, ByVal YA As String, ByVal Type As Integer, Optional ByVal ErrorLog As ClsError = Nothing) As Decimal
        Try
            Dim dtMovement As DataTable = Nothing
            Dim dtData As DataTable = Nothing
            Dim tmpMovement As Decimal = 0
            Dim Amount As Decimal = 0
            Dim MM_REFID As String = ""
            'Normal movement
            Dim ListofCmd As New List(Of SqlCommand)
            dtMovement = clsMoveNormal.Load_MovementNormal(RefNo, YA, ErrorLog)

            Dim Key As Integer = ADO.Load_GetTaxableIncome_Key(Nothing)

            If dtMovement IsNot Nothing Then
                For i As Integer = 0 To dtMovement.Rows.Count - 1

                    MM_REFID = IIf(IsDBNull(dtMovement.Rows(i)("MM_REFID")), "", dtMovement.Rows(i)("MM_REFID"))
                    ADO.Delete_TaxableIncome(RefNo, YA, MM_REFID, ListofCmd)

                    If MM_REFID <> "" AndAlso IsDBNull(dtMovement.Rows(i)("MM_TYPE_PASS")) = False AndAlso dtMovement.Rows(i)("MM_TYPE_PASS") <> 0 Then
                        If IsDBNull(dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT")) = False AndAlso Type = CInt(dtMovement.Rows(i)("MM_TYPE_PASS")) Then
                            Amount += CDec(dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT"))
                            Key += 1
                            ADO.Save_TaxableIncome(Key, RefNo, YA, dtMovement.Rows(i)("MM_TITLE"), CDec(dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT")), dtMovement.Rows(i)("MM_SOURCENO"), dtMovement.Rows(i)("MM_ID"), MM_REFID, ListofCmd)
                        End If
                    End If
                Next

            End If
            Application.DoEvents()

            dtMovement = Nothing
            'Complex Movement
            dtMovement = ADO.Load_MovementComplex(RefNo, YA, ErrorLog)

            If dtMovement IsNot Nothing Then
                For i As Integer = 0 To dtMovement.Rows.Count - 1

                    MM_REFID = IIf(IsDBNull(dtMovement.Rows(i)("MM_REFID")), "", dtMovement.Rows(i)("MM_REFID"))

                    ADO.Delete_TaxableIncome(RefNo, YA, MM_REFID, ListofCmd)

                    If MM_REFID <> "" AndAlso IsDBNull(dtMovement.Rows(i)("MM_TYPE_PASS")) = False AndAlso dtMovement.Rows(i)("MM_TYPE_PASS") <> 0 Then
                        If IsDBNull(dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT")) = False AndAlso Type = CInt(dtMovement.Rows(i)("MM_TYPE_PASS")) Then
                            Amount += CDec(dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT"))
                            Key += 1
                            ADO.Save_TaxableIncome(Key, RefNo, YA, dtMovement.Rows(i)("MM_TITLE"), CDec(dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT")), dtMovement.Rows(i)("MM_SOURCENO"), dtMovement.Rows(i)("MM_ID"), MM_REFID, ListofCmd)
                        End If
                    End If

                Next
            End If


            If ADO.Save_ListExecute(ListofCmd, ErrorLog) = False Then
                Return False
            End If

            Return Amount
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            Return 0
        End Try
    End Function
    Public Function GetRevenueExpenditure_Movement(ByVal RefNo As String, ByVal YA As String, ByVal Type As Integer, Optional ByVal ErrorLog As ClsError = Nothing) As Decimal
        Try
            Dim dtMovement As DataTable = Nothing
            Dim dtData As DataTable = Nothing
            Dim tmpMovement As Decimal = 0
            Dim Amount As Decimal = 0
            Dim MM_REFID As String = ""
            'Normal movement

            dtMovement = clsMoveNormal.Load_MovementNormal(RefNo, YA, ErrorLog)
            Dim ListofCmd As New List(Of SqlCommand)

            If dtMovement IsNot Nothing Then
                For i As Integer = 0 To dtMovement.Rows.Count - 1

                    MM_REFID = IIf(IsDBNull(dtMovement.Rows(i)("MM_REFID")), "", dtMovement.Rows(i)("MM_REFID"))
                    ADO.Delete_RevenueExpenditure(RefNo, YA, MM_REFID, ListofCmd)

                    If MM_REFID <> "" AndAlso IsDBNull(dtMovement.Rows(i)("MM_TYPE_PASS")) = False AndAlso dtMovement.Rows(i)("MM_TYPE_PASS") <> 0 Then
                        If IsDBNull(dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT")) = False AndAlso Type = CInt(dtMovement.Rows(i)("MM_TYPE_PASS")) Then
                            Amount += CDec(dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT"))
                            '   Key += 1
                            ADO.Save_RevenueExpenditure(RefNo, YA, dtMovement.Rows(i)("MM_TITLE"), CDec(dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT")), dtMovement.Rows(i)("MM_SOURCENO"), dtMovement.Rows(i)("MM_ID"), MM_REFID, ListofCmd)
                        End If
                    End If
                Next

            End If
            Application.DoEvents()

            dtMovement = Nothing
            'Complex Movement
            dtMovement = ADO.Load_MovementComplex(RefNo, YA, ErrorLog)

            If dtMovement IsNot Nothing Then
                For i As Integer = 0 To dtMovement.Rows.Count - 1

                    MM_REFID = IIf(IsDBNull(dtMovement.Rows(i)("MM_REFID")), "", dtMovement.Rows(i)("MM_REFID"))
                    ADO.Delete_RevenueExpenditure(RefNo, YA, MM_REFID, ListofCmd)

                    If MM_REFID <> "" AndAlso IsDBNull(dtMovement.Rows(i)("MM_TYPE_PASS")) = False AndAlso dtMovement.Rows(i)("MM_TYPE_PASS") <> 0 Then
                        If IsDBNull(dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT")) = False AndAlso Type = CInt(dtMovement.Rows(i)("MM_TYPE_PASS")) Then
                            Amount += CDec(dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT"))
                            ' Key += 1
                            ADO.Save_RevenueExpenditure(RefNo, YA, dtMovement.Rows(i)("MM_TITLE"), CDec(dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT")), dtMovement.Rows(i)("MM_SOURCENO"), dtMovement.Rows(i)("MM_ID"), MM_REFID, ListofCmd)
                        End If
                    End If
                Next
            End If
            If ADO.Save_ListExecute(ListofCmd, ErrorLog) = False Then
                Return False
            End If
            Return Amount
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            Return 0
        End Try
    End Function
    Public Function GetTotalNonBusinessIncome(TC_AI_DIVIDEND As Decimal, TC_AI_RENTAL As Decimal, TC_AI_ROYALTY As Decimal, TC_AI_INTEREST As Decimal, TC_AI_SEC4A As Decimal) As Decimal
        Try
            Dim dblTotalNBI As Double = 0
            dblTotalNBI = TC_AI_DIVIDEND + TC_AI_RENTAL + TC_AI_ROYALTY + TC_AI_INTEREST + TC_AI_SEC4A

            Return dblTotalNBI
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            Return 0
        End Try

    End Function
    Public Function GetTotalNonAllowableExpenses(ByVal RefNo As String, ByVal YA As String, ByVal PNLID As Integer, Optional ByRef Errorlog As ClsError = Nothing) As Double
        Try
            Dim strDeductible As String = "No"
            Dim dblTotalNonAllowExpenses As Double = 0
            Dim tmpMovement As Decimal = 0
            Dim SourceNo As Integer = 0
            Dim dtMovement As DataTable = Nothing
            Dim drBusinessSource As DataTable = mdlRefreshTaxComputation.GetTCBusinessSource(RefNo, YA)

            If drBusinessSource IsNot Nothing AndAlso drBusinessSource.Rows.Count > 0 Then

                For Each row As DataRow In drBusinessSource.Rows
                    SourceNo = row("tc_business")
                    strDeductible = "No"

                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpOtherInterest(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpContractPay(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpDirectorFee(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpTechnicalFee(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpSalary(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpRoyalty(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpRental(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpRepairMaintenance(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpRND(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpPromotionAdvertisement(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpTravel(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpJKDM(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpEmployeeStock(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpLegal(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpEntertainStaff(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpOthersExpenses(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpDepreciation(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpEntertainNonStaff(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpProvision(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpCompoundPenalty(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpLeavePassage(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpFAWrittenOff(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpInitialSubscript(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpCapitalExpenditure(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalDepreciation(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalOtherNonAllowExpenses(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalPurchases(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpDonationNonApproved(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpInterestRestrict(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpUnrealLossFE(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpRealLossFENonTrade(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpLossDisposalFA(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetTotalNonAllowLoss(RefNo, YA, SourceNo)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalOtherExrLossForeignt(PNLID, SourceNo, strDeductible)

                    strDeductible = ""
                    Application.DoEvents()
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpDonationApproved(PNLID, SourceNo, strDeductible)
                    dblTotalNonAllowExpenses += mdlRefreshTaxComputation.GetAJDTotalExpZakat(PNLID, SourceNo, strDeductible)

                    'Normal movement
                    dtMovement = clsMoveNormal.Load_MovementNormal(RefNo, YA, Errorlog)

                    If dtMovement IsNot Nothing Then
                        If IsDBNull(dtMovement.Rows(0)("MM_TYPE_PASS")) = False AndAlso dtMovement.Rows(0)("MM_TYPE_PASS") <> 0 Then
                            Select Case CInt(dtMovement.Rows(0)("MM_TYPE_PASS"))
                                Case 1
                                    If IsDBNull(dtMovement.Rows(0)("MM_ADD_DEDUCT_AMOUNT")) = False Then
                                        tmpMovement = CDec(dtMovement.Rows(0)("MM_ADD_DEDUCT_AMOUNT"))
                                    End If
                                Case 2

                                Case 3

                            End Select
                        End If
                    End If
                    dblTotalNonAllowExpenses += tmpMovement

                    dtMovement = Nothing
                    'Complex Movement
                    dtMovement = ADO.Load_MovementComplex(RefNo, YA, Errorlog)

                    If dtMovement IsNot Nothing Then
                        If IsDBNull(dtMovement.Rows(0)("MM_TYPE_PASS")) = False AndAlso dtMovement.Rows(0)("MM_TYPE_PASS") <> 0 Then
                            Select Case CInt(dtMovement.Rows(0)("MM_TYPE_PASS"))
                                Case 1
                                    If IsDBNull(dtMovement.Rows(0)("MM_ADD_DEDUCT_AMOUNT")) = False Then
                                        tmpMovement = CDec(dtMovement.Rows(0)("MM_ADD_DEDUCT_AMOUNT"))
                                    End If
                                Case 2

                                Case 3

                            End Select
                        End If
                    End If
                    dblTotalNonAllowExpenses += tmpMovement
                    ''Normal movement
                    'tmpMovement = mdlRefreshTaxComputation.GetTotalMovementNormal_AddBack(RefNo, SourceNo, Errorlog)

                    'tmpMovement -= mdlRefreshTaxComputation.GetTotalMovementNormal_Deduct(RefNo, SourceNo, Errorlog)

                    'dblTotalNonAllowExpenses += tmpMovement

                    'tmpMovement = 0

                    ''Complex movement

                    'tmpMovement = mdlRefreshTaxComputation.GetTotalMovementComplex_AddBack(RefNo, SourceNo, Errorlog)

                    'tmpMovement -= mdlRefreshTaxComputation.GetTotalMovementComplex_Deduct(RefNo, SourceNo, Errorlog)

                    'dblTotalNonAllowExpenses += tmpMovement
                Next

            End If

            Return dblTotalNonAllowExpenses
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(Errorlog)

            Return 0
        End Try
    End Function
End Module
