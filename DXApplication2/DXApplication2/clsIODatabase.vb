Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Text
Imports System.Net.NetworkInformation
Imports System.IO
Imports Microsoft.Win32
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository

Public Class clsIODatabase
    Inherits SQLDataObject

    Public ErrorLog As clsError = Nothing
#Region "SCRIPT DATABASE"

#End Region
#Region "STRUCT"
    Public Const PaymentURL As String = ""
    Public Const RegisterUserURL As String = "http://localhost:52310/pages/registeruser_confirm.html"
    Public Const ForgotPassURL As String = "http://localhost:52310/pages/forgotpass.html"
    Public SystemInfo As SystemDetails
    Structure SystemDetails
        Dim V1 As Integer
        Dim V2 As Integer
        Dim V3 As Integer
        Dim LicenseKey As String
        Dim ValidateUntil As DateTime
        Dim isActive As Integer
        Dim LicenseType As Integer
        Dim LicenseName As String
    End Structure
#End Region
#Region "GENERAL"


    Public Function CreateTaxPayer(ByRef ds As DataSet, Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = Me.Load_TaxPayer(Errorlog)

            ds.Tables("TaxPayer").Rows.Clear()
            If dt IsNot Nothing Then
                Dim dtRow As DataRow = Nothing

                For Each row As DataRow In dt.Rows

                    dtRow = ds.Tables("TaxPayer").NewRow
                    dtRow("RefNo") = IIf(IsDBNull(row("TP_REF_NO1")), "", row("TP_REF_NO1")) & IIf(IsDBNull(row("TP_REF_NO2")), "", row("TP_REF_NO2")) & IIf(IsDBNull(row("TP_REF_NO3")), "", row("TP_REF_NO3"))
                    dtRow("Name") = IIf(IsDBNull(row("TP_NAME")), "", row("TP_NAME"))
                    dtRow("IC_Number") = IIf(IsDBNull(row("TP_IC_NEW_1")), "", row("TP_IC_NEW_1")) & "-" & IIf(IsDBNull(row("TP_IC_NEW_2")), "", row("TP_IC_NEW_2")) & "-" & IIf(IsDBNull(row("TP_IC_NEW_3")), "", row("TP_IC_NEW_3"))
                    dtRow("Country") = IIf(IsDBNull(row("TP_COUNTRY")), "", row("TP_COUNTRY"))
                    dtRow("Address1") = IIf(IsDBNull(row("TP_CURR_ADD_LINE1")), "", row("TP_CURR_ADD_LINE1"))
                    dtRow("Address2") = IIf(IsDBNull(row("TP_CURR_ADD_LINE2")), "", row("TP_CURR_ADD_LINE2"))
                    dtRow("Address3") = IIf(IsDBNull(row("TP_CURR_ADD_LINE3")), "", row("TP_CURR_ADD_LINE3"))
                    dtRow("Postcode") = IIf(IsDBNull(row("TP_CURR_POSTCODE")), "", row("TP_CURR_POSTCODE"))
                    dtRow("City") = IIf(IsDBNull(row("TP_CURR_CITY")), "", row("TP_CURR_CITY"))
                    dtRow("State") = IIf(IsDBNull(row("TP_CURR_STATE")), "", row("TP_CURR_STATE"))
                    dtRow("RefNo_Prefix") = IIf(IsDBNull(row("TP_REF_NO_PREFIX")), "", row("TP_REF_NO_PREFIX"))
                    dtRow("HandleBy") = ""

                    ds.Tables("TaxPayer").Rows.Add(dtRow)
                Next

            End If

            Return True
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
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

    Public Function CreateYA(ByRef ds As DataSet, Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = Me.Load_YA(Errorlog)

            ds.Tables("YA").Rows.Clear()
            If dt IsNot Nothing Then
                Dim dtRow As DataRow = Nothing

                For Each row As DataRow In dt.Rows

                    dtRow = ds.Tables("YA").NewRow
                    dtRow("YA") = IIf(IsDBNull(row("YA")), 0, row("YA"))
                    ds.Tables("YA").Rows.Add(dtRow)
                Next

            End If

            Return True
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
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
    Public Function CreateSourceNo(ByRef ds As DataSet, ByVal RefNo As String, ByVal YA As String, Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = Me.Load_BusinessSource(RefNo, YA, Errorlog)

            ds.Tables("Business_Source").Rows.Clear()
            If dt IsNot Nothing Then
                Dim dtRow As DataRow = Nothing

                For Each row As DataRow In dt.Rows

                    dtRow = ds.Tables("Business_Source").NewRow
                    dtRow("CompanyNo") = IIf(IsDBNull(row("BC_COMPANY")), "", row("BC_COMPANY"))
                    dtRow("SourceNo") = IIf(IsDBNull(row("BC_BUSINESSSOURCE")), "", row("BC_BUSINESSSOURCE"))
                    dtRow("Type") = IIf(IsDBNull(row("BC_TYPE")), "", row("BC_TYPE"))
                    dtRow("Code") = IIf(IsDBNull(row("BC_CODE")), "", row("BC_CODE"))
                    ds.Tables("Business_Source").Rows.Add(dtRow)
                Next

            End If

            Return True
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
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
#End Region
#Region "LOAD"

    Public Function Load_TaxPayer_ByRefNo(ByVal RefNo As String, Optional ByVal Prefix As String = "", Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            SQLcmd = New SqlCommand
            Dim StrSQL As String = "SELECT * FROM TAXP_PROFILE WHERE TP_REF_NO1=@TP_REF_NO1 AND TP_REF_NO2=@TP_REF_NO2 AND TP_REF_NO3=@TP_REF_NO3"


            SQLcmd.Parameters.Add("@TP_REF_NO1", SqlDbType.NVarChar, 17).Value = RefNo.Substring(0, RefNo.Length - 3)
            SQLcmd.Parameters.Add("@TP_REF_NO2", SqlDbType.NVarChar, 2).Value = RefNo.Substring(RefNo.Length - 3, 2)
            SQLcmd.Parameters.Add("@TP_REF_NO3", SqlDbType.NVarChar, 1).Value = RefNo.Substring(RefNo.Length - 1, 1)

            If Prefix <> "" Then
                StrSQL = " AND TP_REF_NO_PREFIX=@TP_REF_NO_PREFIX"
                SQLcmd.Parameters.Add("@TP_REF_NO_PREFIX", SqlDbType.NVarChar, 3).Value = Prefix
            End If

            SQLcmd.CommandText = StrSQL

            Return Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
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
    Public Function Load_TaxPayer(Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM TAXP_PROFILE ORDER BY TP_NAME"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL

            Return Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
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
    Public Function Load_YA(Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM YEAR_ASSESSMENT ORDER BY YA DESC"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL

            Return Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
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
    Public Function Load_BusinessSource(ByVal RefNo As String, ByVal YA As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM BUSINESS_SOURCE WHERE BC_KEY=@BC_KEY AND BC_YA=@BC_YA ORDER BY BC_SOURCEKEY,BC_SOURCENO"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@BC_KEY", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@BC_YA", SqlDbType.NVarChar, 5).Value = YA

            Return Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
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
    Public Function Load_BusinessSource(ByVal RefNo As String, ByVal YA As String, ByVal SourceNo As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM BUSINESS_SOURCE WHERE BC_KEY=@BC_KEY AND BC_YA=@BC_YA AND BC_SOURCENO=@BC_SOURCENO ORDER BY BC_SOURCEKEY,BC_SOURCENO"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@BC_KEY", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@BC_YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@BC_SOURCENO", SqlDbType.Int).Value = YA

            Return Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
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
    Public Function Load_BusinessSource(ByVal RefNo As String, ByVal YA As String, ByVal MainSource As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM BUSINESS_SOURCE WHERE BC_KEY=@BC_KEY AND BC_YA=@BC_YA AND BC_BUSINESSSOURCE=@BC_BUSINESSSOURCE ORDER BY BC_SOURCEKEY,BC_SOURCENO"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@BC_KEY", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@BC_YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@BC_BUSINESSSOURCE", SqlDbType.NVarChar, 12).Value = MainSource

            Return Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
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
#End Region
    Public Function EventLogging(ByVal MethodName As String, ByVal ErrorCode As String, ByVal Message As String,
                          Optional Type As Integer = 0, Optional ByVal Status As Integer = 1, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try

            Dim SQLcmd As SqlCommand
            Dim SqlCon As SqlConnection = Nothing
            If DBConnection_OFFICE(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim strSQL As String = "INSERT INTO tblLog(DateTime,MethodName,ErrorCode,Message,Type,Status) VALUES (@DateTime,@MethodName,@ErrorCode,@Message,@Type,@Status)"


            SQLcmd = New SqlCommand
            SQLcmd.CommandText = strSQL
            SQLcmd.Parameters.Add("@DateTime", SqlDbType.DateTime).Value = Format(Now, "dd-MMM-yyyy HH:mm:sss")
            SQLcmd.Parameters.Add("@MethodName", SqlDbType.NVarChar, 100).Value = MethodName
            SQLcmd.Parameters.Add("@ErrorCode", SqlDbType.NVarChar, 20).Value = ErrorCode
            SQLcmd.Parameters.Add("@Message", SqlDbType.NVarChar, 350).Value = Message
            SQLcmd.Parameters.Add("@Type", SqlDbType.Int).Value = Type
            SQLcmd.Parameters.Add("@Status", SqlDbType.TinyInt).Value = Status

            Return ExecuteSQLCmd(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            Return False
        End Try
    End Function
    Public Function BackupData(ByVal IniDir As String, ByVal Type As Integer, ByVal SQLCon As SqlConnection, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        If ErrorLog Is Nothing Then
            ErrorLog = New clsError
        End If
        Try


            Dim SQLcmd As SqlCommand
            Dim ListofCmd As New List(Of SqlCommand)
            Dim strSQL As String = Nothing

            If Directory.Exists(IniDir & "\" & Format(Now, "dd-MMM-yyyy")) = False Then
                Directory.CreateDirectory(IniDir & "\" & Format(Now, "dd-MMM-yyyy"))
            End If

            If Directory.Exists(IniDir & "\" & Format(Now, "dd-MMM-yyyy")) = True Then
                IniDir = IniDir & "\" & Format(Now, "dd-MMM-yyyy")
            End If
            Select Case Type
                Case 0
                    strSQL = "BACKUP DATABASE TAXCOM_C TO DISK = '" & IniDir & "\TAXCOM_C_" & Format(Now, "ddMMMyyyyHHmmss") & ".Bak' WITH FORMAT,MEDIANAME = 'TAXCOM_C',NAME = 'TAXCOM_C'"
                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = strSQL
                    SQLcmd.CommandTimeout = 0
                Case 1
                    SQLcmd = Nothing
                    strSQL = "BACKUP DATABASE TAX_CA_C TO DISK = '" & IniDir & "\TAX_CA_C_" & Format(Now, "ddMMMyyyyHHmmss") & ".Bak' WITH FORMAT,MEDIANAME = 'TAX_CA_C',NAME = 'TAX_CA_C'"
                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = strSQL
                    SQLcmd.CommandTimeout = 0
                Case 2
                    SQLcmd = Nothing
                    strSQL = "BACKUP DATABASE TAX_CA_B TO DISK = '" & IniDir & "\TAX_CA_B_" & Format(Now, "ddMMMyyyyHHmmss") & ".Bak' WITH FORMAT,MEDIANAME = 'TAX_CA_B',NAME = 'TAX_CA_B'"
                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = strSQL
                    SQLcmd.CommandTimeout = 0
                Case 3
                    strSQL = "BACKUP DATABASE TAXCOM_B TO DISK = '" & IniDir & "\TAXCOM_B_" & Format(Now, "ddMMMyyyyHHmmss") & ".Bak' WITH FORMAT,MEDIANAME = 'TAXCOM_B',NAME = 'TAXCOM_B'"
                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = strSQL
                    SQLcmd.CommandTimeout = 0
                Case 4
                    strSQL = "BACKUP DATABASE TAXCOM_P TO DISK = '" & IniDir & "\TAXCOM_P_" & Format(Now, "ddMMMyyyyHHmmss") & ".Bak' WITH FORMAT,MEDIANAME = 'TAXCOM_P',NAME = 'TAXCOM_P'"
                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = strSQL
                    SQLcmd.CommandTimeout = 0
                Case 5
                    strSQL = "BACKUP DATABASE TAX_CA_P TO DISK = '" & IniDir & "\TAX_CA_P_" & Format(Now, "ddMMMyyyyHHmmss") & ".Bak' WITH FORMAT,MEDIANAME = 'TAX_CA_P',NAME = 'TAX_CA_P'"
                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = strSQL
                    SQLcmd.CommandTimeout = 0
                Case 6
                    strSQL = "BACKUP DATABASE TAXOFFICE TO DISK = '" & IniDir & "\TAXOFFICE_" & Format(Now, "ddMMMyyyyHHmmss") & ".Bak' WITH FORMAT,MEDIANAME = 'TAXOFFICE',NAME = 'TAX_OFFICE'"
                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = strSQL
                    SQLcmd.CommandTimeout = 0
                Case 7
                    strSQL = "BACKUP DATABASE TAXOFFICE TO DISK = '" & IniDir & "\TAXCOM_R_" & Format(Now, "ddMMMyyyyHHmmss") & ".Bak' WITH FORMAT,MEDIANAME = 'TAXCOM_R',NAME = 'TAXCOM_R'"
                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = strSQL
                    SQLcmd.CommandTimeout = 0
            End Select

            Return ExecuteSQLCmd_NOIDReturn(SQLcmd, SQLCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
End Class
