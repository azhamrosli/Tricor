Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Text
Imports System.Net.NetworkInformation
Imports System.IO
Imports Microsoft.Win32
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository

Module mdlProcess
    Dim ADO As SQLDataObject
    Public LicenseType As Integer = 0
    Public V1 As Integer = 1
    Public V2 As Integer = 0
    Public V3 As Integer = 7
    Public V4 As Integer = 0
    Public R1 As Integer = 3 'After Dispose dsPNL2

    Public ArgParam0 As String = "frmpnl" 'Form Name
    Public ArgParam1 As String = "TAXCOM_C" 'Database Name
    Public ArgParam2 As String = "0388601701" '"1054242304" 'RefNo
    Public ArgParam3 As String = "2015" 'YA"
    Public Const isVersionLicenseType As VersionLicenseType = VersionLicenseType.Tricor
    Public ListofClsError As List(Of clsError) = Nothing
    Public dsDataSetErrorlog As DataSet

    Dim MaxYearForCA As Integer = 50
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
#Region "DATABASE"

    Public Function BackupData(ByVal IniDir As String, ByVal Type As Integer, ByVal SQLCon As SqlConnection, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        If ErrorLog Is Nothing Then
            ErrorLog = New clsError
        End If
        Try

            ADO = New SQLDataObject()
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

            Return ADO.ExecuteSQLCmd_NOIDReturn(SQLcmd, SQLCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)


        Catch ex As Exception
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
    Public Function DBConnection_Test(ByVal ServerName As String, ByVal UserName As String, ByVal Password As String, _
                                          ByRef sqlCon As SqlConnection, ByRef ErrorLog As clsError) As Boolean
        Try

            Dim strCon As String = DBSetting()

            If strCon Is Nothing OrElse strCon = "" Then
                mdlProcess.CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, "4060", "Connection string is empty.", ErrorLog)
                Return False
            End If

            Dim Con As New SqlConnection(strCon)
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            sqlCon = Con
            Return True
        Catch ex As Exception
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
    Public Function DBConnection_OFFICE(ByRef sqlCon As SqlConnection, ByRef ErrorLog As clsError) As Boolean
        Try

            Dim strCon As String = DBSetting()

            If strCon Is Nothing OrElse strCon = "" Then
                mdlProcess.CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, "4060", "Connection string is empty.", ErrorLog)
                Return False
            End If

            Dim Con As New SqlConnection(strCon)
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            sqlCon = Con
            Return True
        Catch ex As Exception
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
    Public Function DBConnection(ByRef sqlCon As SqlConnection, ByRef ErrorLog As clsError) As Boolean
        Try

            Dim strCon As String = DBSetting(1, ArgParam1)

            If strCon Is Nothing OrElse strCon = "" Then
                mdlProcess.CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, "4060", "Connection string is empty.", ErrorLog)
                Return False
            End If

            Dim Con As New SqlConnection(strCon)
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            sqlCon = Con
            Return True
        Catch ex As Exception
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
    Public Function DBConnection_CA(ByRef sqlCon As SqlConnection, ByRef ErrorLog As clsError) As Boolean
        Try
            Dim DatabaseName As String = Nothing

            Select Case mdlProcess.ArgParam1
                Case "TAXCOM_C"
                    DatabaseName = "TAX_CA_C"
                Case "TAXCOM_B"
                    DatabaseName = "TAX_CA_B"
                Case "TAXCOM_P"
                    DatabaseName = "TAX_CA_P"
            End Select

            Dim strCon As String = DBSetting(1, DatabaseName)

            If strCon Is Nothing OrElse strCon = "" Then
                mdlProcess.CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, "4060", "Connection string is empty.", ErrorLog)
                Return False
            End If

            Dim Con As New SqlConnection(strCon)
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            sqlCon = Con
            Return True
        Catch ex As Exception
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
    Public Function DBSetting(Optional type As Integer = 0, Optional DatabaseName As String = "TAXCOM_C", Optional ErrorLog As clsError = Nothing) As String
        Try
            Dim regVersion As RegistryKey
            If Environment.Is64BitOperatingSystem Then
                regVersion = Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\TAXOFFICE", False)
            Else
                regVersion = Registry.LocalMachine.OpenSubKey("SOFTWARE\TAXOFFICE", False)
            End If

            If regVersion Is Nothing Then
                If ErrorLog Is Nothing Then
                    ErrorLog = New clsError
                End If
                With ErrorLog
                    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                    .ErrorCode = "X100"
                    .ErrorDateTime = Now
                    .ErrorMessage = "Unable to find registry TAXOFFICE"
                End With
                Return Nothing

            End If
            Dim Server As String = CStr(regVersion.GetValue("value1", ""))
            Dim Database As String = "TAXOFFICE"
            Dim UserID As String = CStr(regVersion.GetValue("value2", ""))
            Dim Pass As String = CStr(regVersion.GetValue("value3", ""))

            If type = 0 Then
                Database = "TAXOFFICE"
            Else
                Database = DatabaseName
            End If


            Return "Server=" & Server & ";Database=" & Database & ";User Id=" & UserID & ";Password=" & Pass & ";"
            'End If
            ' Return System.Configuration.ConfigurationManager.ConnectionStrings("dbEmployeeManagementConnectionString").ConnectionString
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function DBSetting_GetSetting(ByRef Server As String, ByRef UserID As String, ByRef Pass As String, Optional ErrorLog As clsError = Nothing) As Boolean
        Try
            Dim regVersion As RegistryKey
            If Environment.Is64BitOperatingSystem Then
                regVersion = Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\TAXOFFICE", False)
            Else
                regVersion = Registry.LocalMachine.OpenSubKey("SOFTWARE\TAXOFFICE", False)
            End If

            If regVersion Is Nothing Then
                If ErrorLog Is Nothing Then
                    ErrorLog = New clsError
                End If
                With ErrorLog
                    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                    .ErrorCode = "X100"
                    .ErrorDateTime = Now
                    .ErrorMessage = "Unable to find registry TAXOFFICE"
                End With
                Return False

            End If
            Server = CStr(regVersion.GetValue("value1", ""))
            UserID = CStr(regVersion.GetValue("value2", ""))
            Pass = CStr(regVersion.GetValue("value3", ""))


            Return True
        Catch ex As Exception
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
    Public Function DBSetting_SetSetting(ByRef Server As String, ByRef UserID As String, ByRef Pass As String, Optional ErrorLog As clsError = Nothing) As Boolean
        Try
            Dim regVersion As RegistryKey
            If Environment.Is64BitOperatingSystem Then
                regVersion = Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\TAXOFFICE", True)
            Else
                regVersion = Registry.LocalMachine.OpenSubKey("SOFTWARE\TAXOFFICE", True)
            End If

            If regVersion Is Nothing Then
                If ErrorLog Is Nothing Then
                    ErrorLog = New clsError
                End If
                With ErrorLog
                    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                    .ErrorCode = "X100"
                    .ErrorDateTime = Now
                    .ErrorMessage = "Unable to find registry TAXOFFICE"
                End With
                Return False

            End If

            regVersion.SetValue("value1", Server)
            regVersion.SetValue("value2", UserID)
            regVersion.SetValue("value3", Pass)
         
            Return True
        Catch ex As Exception
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
    Public Function GetServerName(Optional type As Integer = 0, Optional DatabaseName As String = "TAXCOM_C", Optional ErrorLog As clsError = Nothing) As String
        Try
            Dim regVersion As RegistryKey
            If Environment.Is64BitOperatingSystem Then
                regVersion = Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\TAXOFFICE", False)
            Else
                regVersion = Registry.LocalMachine.OpenSubKey("SOFTWARE\TAXOFFICE", False)
            End If

            If regVersion Is Nothing Then
                If ErrorLog Is Nothing Then
                    ErrorLog = New clsError
                End If
                With ErrorLog
                    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                    .ErrorCode = "X100"
                    .ErrorDateTime = Now
                    .ErrorMessage = "Unable to find registry TAXOFFICE"
                End With
                Return Nothing

            End If
            Dim Server As String = CStr(regVersion.GetValue("value1", ""))


            Return "Server=" & Server
            'End If
            ' Return System.Configuration.ConfigurationManager.ConnectionStrings("dbEmployeeManagementConnectionString").ConnectionString
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
#End Region
#Region "ENCRYPT DECRYPT"
    Public Function EncryptPass(ByVal Password As String) As String
        Try
            Dim plainText As String = Password

            Dim passPhrase As String
            Dim saltValue As String
            Dim hashAlgorithm As String
            Dim passwordIterations As Integer
            Dim initVector As String
            Dim keySize As Integer

            '  plainText = "Hello, World!"     ' original plaintext

            passPhrase = "Pas5pr@se"        ' can be any string
            saltValue = "Azh@m1"         ' can be any string
            hashAlgorithm = "SHA1"          ' can be "MD5"
            passwordIterations = 2          ' can be any number
            initVector = "@1B2c3D4e5F6g7H8" ' must be 16 bytes
            keySize = 256                   ' can be 192 or 128

            Return RijndaelSimple.Encrypt _
             ( _
                 plainText, _
                 passPhrase, _
                 saltValue, _
                 hashAlgorithm, _
                 passwordIterations, _
                 initVector, _
                 keySize _
             )
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return Nothing
        End Try

    End Function
    Public Function DecriptPass(ByVal Password As String) As String
        Try
            Dim cipherText As String = Password

            Dim passPhrase As String
            Dim saltValue As String
            Dim hashAlgorithm As String
            Dim passwordIterations As Integer
            Dim initVector As String
            Dim keySize As Integer

            '  plainText = "Hello, World!"     ' original plaintext

            passPhrase = "Pas5pr@se"        ' can be any string
            saltValue = "Azh@m1"         ' can be any string
            hashAlgorithm = "SHA1"          ' can be "MD5"
            passwordIterations = 2          ' can be any number
            initVector = "@1B2c3D4e5F6g7H8" ' must be 16 bytes
            keySize = 256                   ' can be 192 or 128

            Return RijndaelSimple.Decrypt _
            ( _
                cipherText, _
                passPhrase, _
                saltValue, _
                hashAlgorithm, _
                passwordIterations, _
                initVector, _
                keySize _
            )
        Catch ex As Exception
            ' MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return Nothing
        End Try
    End Function
#End Region
#Region "GENERAL"
    Public Sub AddListOfError(ByVal ErrorLog As clsError)
        Try
            If ListofClsError Is Nothing Then
                ListofClsError = New List(Of clsError)
            End If

            ListofClsError.Add(ErrorLog)

            Dim dtRow As DataRow = Nothing

            dtRow = dsDataSetErrorlog.Tables("dtErrorLog").NewRow
            dtRow("No") = dsDataSetErrorlog.Tables("dtErrorLog").Rows.Count + 1
            dtRow("ErrorDateTime") = Now
            dtRow("ErrorCode") = ErrorLog.ErrorCode
            dtRow("ErrorName") = ErrorLog.ErrorName
            dtRow("ErrorMessage") = ErrorLog.ErrorMessage

            dsDataSetErrorlog.Tables("dtErrorLog").Rows.Add(dtRow)


        Catch ex As Exception

        End Try
    End Sub
    Public Function CalcNa(ByVal dtPNLDetails As DataTable, ByVal ColumnName As String, ByRef NA_Exp As Decimal, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try

            For j As Integer = 0 To dtPNLDetails.Rows.Count - 1
                If IsDBNull(dtPNLDetails.Rows(j)(ColumnName)) = False AndAlso IsNumeric(dtPNLDetails.Rows(j)(ColumnName)) Then
                    NA_Exp += CDec(dtPNLDetails.Rows(j)(ColumnName))
                End If
            Next
            Return True
        Catch ex As Exception
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
            Return True
        End Try
    End Function

    Public Function CreateLookUpSourceNO(ByRef dsSourceNo As DataSet, ByVal RefNo As String, ByVal YA As Integer, _
                                        Optional ByVal TableName As String = "BUSINESS_SOURCE", Optional Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = mdlProcess.LoadBusinessSource_ByRefNo(RefNo, CStr(YA), Errorlog)

            If dt IsNot Nothing Then
                Dim dtrow As DataRow
                dsSourceNo.Tables(TableName).Clear()

                For i As Integer = 0 To dt.Rows.Count - 1
                    dtrow = dsSourceNo.Tables(TableName).NewRow
                    dtrow("BC_SOURCEKEY") = IIf(IsDBNull(dt.Rows(i)("BC_SOURCEKEY")), 0, dt.Rows(i)("BC_SOURCEKEY"))
                    dtrow("BC_SOURCENO") = IIf(IsDBNull(dt.Rows(i)("BC_SOURCENO")), 0, dt.Rows(i)("BC_SOURCENO"))
                    dtrow("BC_CODE") = IIf(IsDBNull(dt.Rows(i)("BC_CODE")), "", dt.Rows(i)("BC_CODE"))
                    dtrow("BC_TYPE") = IIf(IsDBNull(dt.Rows(i)("BC_TYPE")), "", dt.Rows(i)("BC_TYPE"))
                    dsSourceNo.Tables(TableName).Rows.Add(dtrow)
                Next
            End If
            'Dim dt As DataTable = mdlProcess.LoadHPCode_ByRefNo(RefNo, Errorlog)

            'cboHP.Properties.Items.Clear()
            'If dt Is Nothing Then
            '    Return False
            'End If

            'For i As Integer = 0 To dt.Rows.Count - 1
            '    cboHP.Properties.Items.Add(IIf(IsDBNull(dt.Rows(i)("HP")), "", dt.Rows(i)("HP")).ToString)
            'Next

            Return True
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

            AddListOfError(Errorlog)
            Return False
        End Try
    End Function

    Public Function CreateLookUpHPCode(ByRef cboHP As DevExpress.XtraEditors.ComboBoxEdit, _
                                         ByVal RefNo As String, Optional Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = mdlProcess.LoadHPCode_ByRefNo(RefNo, Errorlog)

            cboHP.Properties.Items.Clear()
            If dt Is Nothing Then
                Return False
            End If

            For i As Integer = 0 To dt.Rows.Count - 1
                cboHP.Properties.Items.Add(IIf(IsDBNull(dt.Rows(i)("HP")), "", dt.Rows(i)("HP")).ToString)
            Next

            Return True
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

            AddListOfError(Errorlog)

            Return False
        End Try
    End Function
    Public Function CreateLookUpSourceNo(ByRef cboSourceNo As DevExpress.XtraEditors.ComboBoxEdit, _
                                         ByVal RefNo As String, ByVal YA As String, Optional Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = mdlProcess.LoadSourceNo(RefNo, YA, Errorlog)

            cboSourceNo.Properties.Items.Clear()
            If dt Is Nothing Then
                Return False
            End If

            For i As Integer = 0 To dt.Rows.Count - 1
                cboSourceNo.Properties.Items.Add(CInt(IIf(IsDBNull(dt.Rows(i)("BC_SOURCENO")), 0, dt.Rows(i)("BC_SOURCENO"))).ToString)
            Next

            Return True
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

            AddListOfError(Errorlog)
            Return False
        End Try
    End Function
    Public Function CreateLookUpSourceNo(ByRef cboSourceNo As DevExpress.XtraBars.BarEditItem, ByVal RefNo As String, ByVal YA As String, Optional Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = mdlProcess.LoadSourceNo(RefNo, YA, Errorlog)

            Dim cbo As RepositoryItemComboBox = CType(cboSourceNo.Edit, RepositoryItemComboBox)
            'cboYA.Properties.Items.Clear()
            cbo.Properties.Items.Clear()
            If dt Is Nothing Then
                Return False
            End If

            For i As Integer = 0 To dt.Rows.Count - 1
                cbo.Items.Add(CInt(IIf(IsDBNull(dt.Rows(i)("BC_SOURCENO")), 0, dt.Rows(i)("BC_SOURCENO"))).ToString)
            Next

            Return True
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

            AddListOfError(Errorlog)
            Return False
        End Try
    End Function
    Public Function CreateLookUpYA(ByRef cboYA As DevExpress.XtraEditors.ComboBoxEdit, Optional Errorlog As clsError = Nothing, Optional isAddEmpty As Boolean = False) As Boolean
        Try
            Dim dt As DataTable = mdlProcess.LoadYA(Errorlog)

            cboYA.Properties.Items.Clear()
            If dt Is Nothing Then
                Return False
            End If

            For i As Integer = 0 To dt.Rows.Count - 1
                cboYA.Properties.Items.Add(CInt(IIf(IsDBNull(dt.Rows(i)("YA")), "0", dt.Rows(i)("YA"))).ToString)
            Next

            If isAddEmpty Then
                cboYA.Properties.Items.Add("")
            End If

            Return True
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

            AddListOfError(Errorlog)
            Return False
        End Try
    End Function

    Public Function CreateLookUpState(ByRef cboYA As DevExpress.XtraEditors.ComboBoxEdit, Optional Errorlog As clsError = Nothing, Optional isAddEmpty As Boolean = False) As Boolean
        Try
            Dim dt As DataTable = mdlProcess.LoadState(Errorlog)

            cboYA.Properties.Items.Clear()
            If dt Is Nothing Then
                Return False
            End If

            For i As Integer = 0 To dt.Rows.Count - 1
                cboYA.Properties.Items.Add(IIf(IsDBNull(dt.Rows(i)("ST_DESC")), "-", dt.Rows(i)("ST_DESC")))
            Next

            If isAddEmpty Then
                cboYA.Properties.Items.Add("")
            End If

            Return True
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

            AddListOfError(Errorlog)
            Return False
        End Try
    End Function
    Public Function CreateLookUpYA(ByRef cboYA As DevExpress.XtraBars.BarEditItem, Optional Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = mdlProcess.LoadYA(Errorlog)


            CType(cboYA.Edit, RepositoryItemComboBox).Items.Clear()

            'cboYA.Properties.Items.Clear()
            If dt Is Nothing Then
                Return False
            End If

            For i As Integer = 0 To dt.Rows.Count - 1
                CType(cboYA.Edit, RepositoryItemComboBox).Items.Add(CInt(IIf(IsDBNull(dt.Rows(i)("YA")), "0", dt.Rows(i)("YA"))).ToString)
            Next

            Return True
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

            AddListOfError(Errorlog)
            Return False
        End Try
    End Function
    Public Function CreateLookUpCategory(ByRef DataSet As DataSet, Optional Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = mdlProcess.LoadCategory(Errorlog)

            DataSet.Tables("Category").Rows.Clear()

            If dt Is Nothing Then
                Return False
            End If

            Dim dtRow As DataRow
            For i As Integer = 0 To dt.Rows.Count - 1
                dtRow = DataSet.Tables("Category").NewRow
                dtRow("CA_CATEGORY") = IIf(IsDBNull(dt.Rows(i)("CA_CATEGORY")), "", dt.Rows(i)("CA_CATEGORY"))
                dtRow("CA_CODE") = IIf(IsDBNull(dt.Rows(i)("CA_CODE")), "", dt.Rows(i)("CA_CODE"))
                DataSet.Tables("Category").Rows.Add(dtRow)
            Next

            Return True
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

            AddListOfError(Errorlog)
            Return False
        End Try
    End Function
    Public Function CreateLookUpTaxPayer(ByRef DataSet As DataSet, Optional Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = mdlProcess.LoadTaxPayer(Errorlog)

            DataSet.Tables("TaxPayerFind").Rows.Clear()

            If dt Is Nothing Then
                Return False
            End If

            Dim dtRow As DataRow
            For i As Integer = 0 To dt.Rows.Count - 1
                dtRow = DataSet.Tables("TaxPayerFind").NewRow
                dtRow("RefNo") = IIf(IsDBNull(dt.Rows(i)("TP_REF_NO")), "", dt.Rows(i)("TP_REF_NO"))
                dtRow("CompanyName") = IIf(IsDBNull(dt.Rows(i)("TP_COM_NAME")), "", dt.Rows(i)("TP_COM_NAME"))
                dtRow("CompanyNo") = IIf(IsDBNull(dt.Rows(i)("TP_ROC_NO")), "", dt.Rows(i)("TP_ROC_NO"))
                dtRow("EmployerNo") = IIf(IsDBNull(dt.Rows(i)("TP_EMPLOYER_NO")), "", dt.Rows(i)("TP_EMPLOYER_NO"))
                dtRow("FileNo") = IIf(IsDBNull(dt.Rows(i)("TP_TAX_FILE_NO")), "", dt.Rows(i)("TP_TAX_FILE_NO"))
                dtRow("Country") = IIf(IsDBNull(dt.Rows(i)("TP_COUNTRY")), "", dt.Rows(i)("TP_COUNTRY"))
                dtRow("CompanyCode") = IIf(IsDBNull(dt.Rows(i)("TP_FILE_NO")), "C", dt.Rows(i)("TP_FILE_NO"))
                dtRow("HandleBy") = IIf(IsDBNull(dt.Rows(i)("HandleBy")), "", dt.Rows(i)("HandleBy"))
                DataSet.Tables("TaxPayerFind").Rows.Add(dtRow)
            Next

            Return True
        Catch ex As Exception
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

            AddListOfError(Errorlog)
            Return False
        End Try
    End Function
    Private Sub CreateErrorLog(ByVal MethodName As String, ByVal ErrorCode As String, ByVal Message As String, ByRef ErrorLog As clsError)
        Try
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = MethodName
                .ErrorCode = ErrorCode
                .ErrorDateTime = Now
                .ErrorMessage = Message
            End With
        Catch ex As Exception
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
            mdlProcess.EventLogging(System.Reflection.MethodBase.GetCurrentMethod().Name & " " & MethodName, ex.HResult.ToString, ex.Message, 2)
        End Try
    End Sub
    Public Sub numbervalidation_Phone(ByVal e As KeyPressEventArgs)
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 45) Then
            e.Handled = False
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    Public Sub numbervalidation_Decimal(ByVal e As KeyPressEventArgs)
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 46) Then
            e.Handled = False
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    Public Function ProcessImageFromPictureBoxToByte(ByVal Pic As PictureBox) As Byte()
        Try
            Dim ms As New IO.MemoryStream
            Pic.Image.Save(ms, Imaging.ImageFormat.Jpeg)
            Return ms.GetBuffer()
        Catch ex As Exception
            EventLogging(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.HResult.ToString, ex.Message, 1)
            Return Nothing
        End Try
    End Function
    Public Function ProcessImagetoByte(ByVal Url As String) As Byte()

        Dim stream As New MemoryStream()
tryagain:
        Try
            If System.IO.File.Exists(Url) Then
                Dim image As New Bitmap(Url)
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            GoTo tryagain
        End Try

        Return stream.ToArray()


    End Function
    Public Sub GetImage(ByVal imgbyte As Byte(), Picbox As PictureBox)
        If imgbyte IsNot Nothing AndAlso imgbyte.Count > 0 Then
            Dim stream As New IO.MemoryStream()

            Dim image As Byte() = DirectCast(imgbyte, Byte())
            stream.Write(image, 0, image.Length)

            Dim bitmap As New Bitmap(stream)
            Picbox.Image = bitmap
        Else
            Exit Sub
        End If
    End Sub
    Public Function GetMacAddress(Optional ByRef ErrorLog As String = "") As String
        Try
            Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces

            Dim strAdd As String = ""
            If nics IsNot Nothing AndAlso nics.Count > 0 Then
                For i As Integer = 0 To nics.Count - 1
                    strAdd += nics(i).Name & " (" & nics(i).GetPhysicalAddress.ToString & ")" & vbCrLf
                Next
            End If

            Return strAdd 'nics(0).GetPhysicalAddress.ToString
        Catch ex As Exception
            EventLogging(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.HResult.ToString, ex.Message, 1)
            Return ""
        End Try
    End Function
    Public Function GetNetworkSpeed(Optional ByRef ErrorLog As String = "") As String
        Try
            Dim adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
            Dim adapter As NetworkInterface
            Dim strAdd As String = ""
            For Each adapter In adapters
                Dim properties As IPInterfaceProperties = adapter.GetIPProperties()
                Dim stats As IPv4InterfaceStatistics = adapter.GetIPv4Statistics()
                strAdd += adapter.Description & " (" & adapter.Speed.ToString("N0") & ") pre-sec" & vbCrLf
                '   Console.WriteLine(adapter.Description)
                ' Console.WriteLine("     Speed .................................: {0}", adapter.Speed)
                '  Console.WriteLine("     Output queue length....................: {0}", stats.OutputQueueLength)
            Next adapter

            Return strAdd 'nics(0).GetPhysicalAddress.ToString
        Catch ex As Exception
            EventLogging(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.HResult.ToString, ex.Message, 1)
            Return ""
        End Try
    End Function
    Public Function ConvertDateTimeToFacebookDateTime(ByVal DateData As DateTime, Optional ByVal FormatType As Integer = 0, Optional ByRef ErrorLog As String = "") As String
        Try
            Dim Hours As String = " hours ago"
            Dim Minutes As String = " minutes ago"
            Dim Seconds As String = "a few seconds ago"
            Select Case FormatType
                Case 0
                    Hours = " hours ago"
                    Minutes = " minutes ago"
                    Seconds = "a few seconds ago"
                Case 1
                    Hours = " hrs ago"
                    Minutes = " min ago"
                    Seconds = "a moments ago"
            End Select
            If DateDiff(DateInterval.Day, DateData, Now) > 0 Then
                Return Format(DateData, "dd-MMM-yyyy")
            Else
                If DateDiff(DateInterval.Hour, DateData, Now) > 0 Then
                    Return DateDiff(DateInterval.Hour, DateData, Now) & Hours
                ElseIf DateDiff(DateInterval.Minute, DateData, Now) > 0 Then
                    Return DateDiff(DateInterval.Minute, DateData, Now) & Minutes
                Else
                    Return Seconds
                End If
            End If
        Catch ex As Exception
            Return Format(DateData, "dd-MMM-yyyy")
        End Try
    End Function
    Public Function ConvertDateTimeToFacebookDateTime_Year(ByVal DateData As DateTime, Optional ByVal FormatType As Integer = 0, Optional ByRef ErrorLog As String = "") As String
        Try
            Dim Hours As String = " hours ago"
            Dim Minutes As String = " minutes ago"
            Dim Seconds As String = "a few seconds ago"
            Dim Years As String = "a years ago"
            Dim Months As String = "a months ago"
            Dim Days As String = "a days ago"
            Select Case FormatType
                Case 0
                    Hours = " hours ago"
                    Minutes = " minutes ago"
                    Seconds = "a few seconds ago"
                    Years = " years ago"
                    Months = " months ago"
                    Days = " days ago"
                Case 1
                    Hours = " hrs ago"
                    Minutes = " min ago"
                    Seconds = "a moments ago"
                    Years = " years ago"
                    Months = " months ago"
                    Days = " days ago"
            End Select
            If DateDiff(DateInterval.Day, DateData, Now) > 0 Then
                If DateDiff(DateInterval.Year, DateData, Now) > 0 Then
                    Return DateDiff(DateInterval.Year, DateData, Now) & Years
                ElseIf DateDiff(DateInterval.Month, DateData, Now) > 0 Then
                    Return DateDiff(DateInterval.Month, DateData, Now) & Months
                ElseIf DateDiff(DateInterval.Day, DateData, Now) > 0 Then
                    Return DateDiff(DateInterval.Day, DateData, Now) & Days
                ElseIf DateDiff(DateInterval.Hour, DateData, Now) > 0 Then
                    Return DateDiff(DateInterval.Hour, DateData, Now) & Hours
                ElseIf DateDiff(DateInterval.Minute, DateData, Now) > 0 Then
                    Return DateDiff(DateInterval.Minute, DateData, Now) & Minutes
                Else
                    Return Seconds

                End If
            Else
                If DateDiff(DateInterval.Hour, DateData, Now) > 0 Then
                    Return DateDiff(DateInterval.Hour, DateData, Now) & Hours
                ElseIf DateDiff(DateInterval.Minute, DateData, Now) > 0 Then
                    Return DateDiff(DateInterval.Minute, DateData, Now) & Minutes
                Else
                    Return Seconds
                End If
            End If

        Catch ex As Exception
            Return Format(DateData, "dd-MMM-yyyy")
        End Try
    End Function
    Public Function RandomKey() As String
        Try
            Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
            Dim r As New Random
            Dim sb As New StringBuilder
            For i As Integer = 1 To 4
                Dim idx As Integer = r.Next(0, 4)
                sb.Append(s.Substring(idx, 1))
            Next
            sb.Append("-")
            For i As Integer = 1 To 4
                Dim idx As Integer = r.Next(0, 4)
                sb.Append(s.Substring(idx, 1))
            Next
            sb.Append("-")
            For i As Integer = 1 To 4
                Dim idx As Integer = r.Next(0, 4)
                sb.Append(s.Substring(idx, 1))
            Next
            sb.Append("-")
            For i As Integer = 1 To 3
                Dim idx As Integer = r.Next(0, 3)
                sb.Append(s.Substring(idx, 1))
            Next

            Return sb.ToString
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function RandomID(Optional ByVal Count As Integer = 4) As String
        Try
            Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
            Dim r As New Random
            Dim sb As New StringBuilder
            For i As Integer = 1 To Count
                Dim idx As Integer = r.Next(0, Count)
                sb.Append(s.Substring(idx, 1))
            Next

            Return sb.ToString
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function RandomNO_Only(Optional ByVal Count As Integer = 4) As String
        Try
            Dim s As String = "0123456789"
            Dim r As New Random
            Dim sb As New StringBuilder
            For i As Integer = 1 To Count
                Dim idx As Integer = r.Next(0, Count)
                sb.Append(s.Substring(idx, 1))
            Next

            Return sb.ToString
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function Base64ToStringConvert(ByVal data As String) As String
        Try
            Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(data)
            Return System.Convert.ToBase64String(byt)
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function Base64ToByteConvert(ByVal data As String) As String
        Try
            Dim byt() As Byte = System.Convert.FromBase64String(data)
            Return System.Text.ASCIIEncoding.ASCII.GetString(byt)
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function ConvertFileToBase64(ByVal byt As Byte()) As String
        Return System.Convert.ToBase64String(byt)
    End Function
    Public Function ConvertFileStringToByte(ByVal data As String) As Byte()
        If data Is Nothing Or data = "" Then
            Return Nothing
        End If
        Return System.Text.Encoding.UTF8.GetBytes(data)
    End Function
    Public Function EventLogging(ByVal MethodName As String, ByVal ErrorCode As String, ByVal Message As String,
                           Optional Type As Integer = 0, Optional ByVal Status As Integer = 1, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
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

            Return ADO.ExecuteSQLCmd(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function SentEmail_NewUser(ByVal Email As String, ByVal FirstName As String, ByVal LastName As String, ByVal ID As Decimal, Optional ErrorLog As clsError = Nothing) As Boolean
        If ErrorLog Is Nothing Then
            ErrorLog = New clsError
        End If
        Try
            Using mail As MailMessage = New MailMessage


                mail.From = New MailAddress("arsoftwaremalaysia.team@gmail.com")
                mail.To.Add(Email)
                mail.Bcc.Add("arsoftwaremalaysia@gmail.com")

                mail.Subject = "Confirmation Register Employeee Management -" & FirstName & " " & LastName
                mail.IsBodyHtml = True
                mail.Body += "<div style='width:100%;height:50px;background-color:#212121;'>"
                mail.Body += "<h1 style='color:#ffffff;margin:10px;'>Register new user.</h1>"
                mail.Body += "</div>"
                mail.Body += "<div style='width:100%;background-color:#ffffff;'><br />"
                mail.Body += "<b style='background-color:red;color:#ffffff;'>Please do not reply to this email. This email is auto generate system.</b><br /><br />"
                mail.Body += "<b> Dear " & FirstName & " " & LastName & ","
                mail.Body += "</div>"
                mail.Body += "<p>Thank you for become our part of member, congratulations on making the smart decision to take minimize your job scope with us.</p>"
                mail.Body += "<br />"
                mail.Body += "<p><a href='" & RegisterUserURL & "?sysDatax=" & Base64ToStringConvert("email=" & Email & "&userdata=" & ID) & "'>Please click this link to confirm registration.</a></p>"
                mail.Body += "<br />"
                mail.Body += "<p>Email : " & Email & "</p>"
                mail.Body += "<p>First Name : " & FirstName & "</p>"
                mail.Body += "<p><Last Name : " & LastName & "</p>"
                mail.Body += "<p>Here is benefit using our system.</p>"
                mail.Body += "<br /><ul><li>Easy to use.</li><li>Secure your employee information.</li><li>Minimize your job scope</li><li>Faster and reliable</li></ul><br />"


                mail.Body += "<div style='background-color:#212121;padding:15px;color:white;'>"
                mail.Body += "<b>Best Regards,</b><br /><b>AR Software Enterprise</b><br />"
                mail.Body += "<img src='http://arsoftwaremalaysia.com/Image/CompanyLogo.png' style='width:200px' /><br />"
                mail.Body += "<i>Website : www.arsoftwaremalaysia.com</i>"
                mail.Body += "</div>"

                Using smtp As New SmtpClient("smtp.gmail.com")
                    smtp.EnableSsl = True
                    smtp.Credentials = New System.Net.NetworkCredential("arsoftwaremalaysia.team@gmail.com", "black@91")
                    smtp.Port = 587
                    smtp.Send(mail)
                End Using

                Return True
            End Using
        Catch ex As Exception
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

#End Region
#Region "VALIDATE"
    Public Function Validate_CA_TEMP_REPORTID(ByVal ID As String, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT COUNT(*) AS COUNTX FROM CA_REPORT_TEMP WHERE ID=@ID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.NVarChar, 50).Value = ID

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("COUNTX")) = False AndAlso dt.Rows(0)("COUNTX") > 0 Then
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
    Public Function Validate_CA__FA_TEMP_REPORTID(ByVal ID As String, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT COUNT(*) AS COUNTX FROM CA_REPORT_FIXEDASSET_TEMP WHERE ID=@ID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.NVarChar, 50).Value = ID

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("COUNTX")) = False AndAlso dt.Rows(0)("COUNTX") > 0 Then
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
    Public Function Validate_PNL_TEMP_REPORTID(ByVal ID As String, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT COUNT(*) AS COUNTX FROM PROFIT_LOSS_ACCOUNT_REPORT_TEMP WHERE ID=@ID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.NVarChar, 50).Value = ID

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("COUNTX")) = False AndAlso dt.Rows(0)("COUNTX") > 0 Then
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
#End Region
#Region "LOAD"
#Region "CA"

    Public Function LOAD_GetDTYA(ByVal TC_REF_NO As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT DISTINCT [TC_YA] FROM [TAX_COMPUTATION] WHERE [TC_REF_NO]= @TC_REF_NO"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@TC_REF_NO", SqlDbType.NVarChar, 20).Value = TC_REF_NO

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function LOAD_GetDISPRecordCount(ByVal CA_KEY As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Integer
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select count(ca_key) as countx from ca_disposal where ca_key=@ca_key"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ca_key", SqlDbType.Int).Value = CA_KEY

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("countx")) = False Then
                Return CInt(dt.Rows(0)("countx"))
            Else
                Return 0
            End If
        Catch ex As Exception
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
            Return 0
        End Try
    End Function
    Public Function LOAD_GetDISPKey(ByVal CA_KEY As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Integer
        Try
            'select count(ca_disp_qc), sum(cast(ca_disp_qc as money)) from ca_disposal where ca_key=@cakey
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 1
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select count(ca_disp_key) as countx, max(ca_disp_key) as sumx from ca_disposal where ca_key=@ca_key"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ca_key", SqlDbType.Int).Value = CA_KEY

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("countx")) = False AndAlso CInt(dt.Rows(0)("countx")) > 0 Then
                Return 1
            ElseIf dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                Return CInt(dt.Rows(0)("sumx")) + 1
            Else
                Return 1
            End If

        Catch ex As Exception
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
            Return 1
        End Try

    End Function
    Public Function LOAD_GetTotalDisposedCA(ByVal CA_KEY As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Decimal
        Try
            'select count(ca_disp_qc), sum(cast(ca_disp_qc as money)) from ca_disposal where ca_key=@cakey
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select count(ca_disp_qc) as countx, sum(cast(ca_disp_qc as money)) as sumx from ca_disposal where ca_key=@ca_key"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ca_key", SqlDbType.Int).Value = CA_KEY

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("countx")) = False AndAlso IsDBNull(dt.Rows(0)("sumx")) = False Then
                If CInt(dt.Rows(0)("countx")) > 0 Then
                    Return CDec(dt.Rows(0)("sumx"))
                Else
                    Return 0
                End If
            Else
                Return 0
            End If
        Catch ex As Exception
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
            Return 0
        End Try
    End Function
    Public Function LOAD_VerifySourceCode(ByVal BC_KEY As String, ByVal YA As String, ByVal SourceCode As String, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select bc_sourceno from business_source where bc_key=@bckey and bc_ya=@ya and bc_sourceno=@sourcecode"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@bckey", SqlDbType.NVarChar, 255).Value = BC_KEY
            SQLcmd.Parameters.Add("@ya", SqlDbType.NVarChar, 255).Value = YA
            SQLcmd.Parameters.Add("@sourcecode", SqlDbType.NVarChar, 255).Value = SourceCode

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
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
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function LOAD_GetCAByHPCode(ByVal HP_CODE As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select ca_key, ca_mode, ca_qualifying_cost,ca_twdv, ca_ya, ca_purchase_amount, ca_payment, ca_rate_ia, ca_rate_aa, ca_purchase_date from ca where hp_code=@hp_code"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@hp_code", SqlDbType.NVarChar, 255).Value = HP_CODE

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function LOAD_GetLatestCAYear(ByVal HP_CODE As String, Optional ByRef ErrorLog As clsError = Nothing) As Integer
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select count(ca_ya) as countx, max(ca_ya) as maxx from ca where hp_code=@hp_code"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@hp_code", SqlDbType.NVarChar, 255).Value = HP_CODE

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("countx")) = False AndAlso CInt(dt.Rows(0)("countx")) > 0 Then
                Return CInt(dt.Rows(0)("maxx"))
            Else
                Return 0
            End If
        Catch ex As Exception
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
            Return 0
        End Try
    End Function
    Public Function Load_GetTotalCA(ByVal HP_CODE As String, Optional ByRef ErrorLog As clsError = Nothing) As Integer
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select count(ca_qualifying_cost) as countx, sum(cast(ca_qualifying_cost as money)) as sumx from ca where hp_code=@hpcode"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@hpcode", SqlDbType.NVarChar, 255).Value = HP_CODE

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("countx")) = False AndAlso IsNumeric(dt.Rows(0)("countx")) > True Then

                If CInt(dt.Rows(0)("countx")) > 0 Then
                    Return CInt(dt.Rows(0)("sumx"))
                Else
                    Return 0
                End If

            Else
                Return 0
            End If
        Catch ex As Exception
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
            Return 0
        End Try
    End Function
    Public Function Load_HP_Count(ByVal HP_CODE As String, Optional ByRef ErrorLog As clsError = Nothing) As Integer
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return 0
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT COUNT(CA_KEY) as countx FROM CA WHERE HP_CODE=@HP_CODE"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@HP_CODE", SqlDbType.NVarChar, 255).Value = HP_CODE

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("countx")) = False Then
                Return CInt(dt.Rows(0)("countx"))
            Else
                Return 0
            End If
        Catch ex As Exception
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
            Return 0
        End Try
    End Function
    Public Function Load_Disposal_CA(ByVal CA_REF_NO As String, ByVal CA_YA As String, ByVal FilterType As Integer, ByVal FilterValue As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select * from ca where ca_ref_no = @refno and cast(ca_purchase_year as int) <= @ya and cast(ca_ya as int)<=@ya and cast(ca_remain_qc as money)>0"
            SQLcmd = New SqlCommand

            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 20).Value = CA_REF_NO
            SQLcmd.Parameters.Add("@ya", SqlDbType.Int, 5).Value = CA_YA
            Select Case FilterType
                Case 0
                    StrSQL += " order by ca_ya, ca_key asc"
                Case 1
                    StrSQL += " and ca_asset like @search order by ca_asset, ca_ya asc"
                    SQLcmd.Parameters.Add("@search", SqlDbType.NVarChar, 255).Value = "%" & FilterValue & "%"
                Case 2
                    StrSQL += " and ca_asset_code like @search order by ca_asset_code, ca_ya asc"
                    SQLcmd.Parameters.Add("@search", SqlDbType.NVarChar, 20).Value = "%" & FilterValue & "%"
                Case 3
                    StrSQL += " and hp_code like @search order by hp_code, ca_ya asc"
                    SQLcmd.Parameters.Add("@search", SqlDbType.NVarChar, 255).Value = "%" & FilterValue & "%"
                Case 4
                    StrSQL += " and ca_category_code like @search order by ca_category_code, ca_ya asc"
                    SQLcmd.Parameters.Add("@search", SqlDbType.NVarChar, 20).Value = "%" & FilterValue & "%"
                Case 6
                    StrSQL += " and ca_key=@search order by ca_category_code, ca_ya asc"
                    SQLcmd.Parameters.Add("@search", SqlDbType.Int).Value = FilterValue
            End Select
            SQLcmd.CommandText = StrSQL

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_HPPrincipal(ByVal HP_REF_NO As String, ByVal HP_CODE As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM HP WHERE HP_REF_NO=@HP_REF_NO AND HP_CODE=@HP_CODE"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@HP_REF_NO", SqlDbType.NVarChar, 20).Value = HP_REF_NO
            SQLcmd.Parameters.Add("@HP_CODE", SqlDbType.NVarChar, 255).Value = IIf(HP_CODE Is Nothing, "", HP_CODE)

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_CA(ByVal CA_KEY As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA WHERE CA_KEY=@CA_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@CA_KEY", SqlDbType.Int).Value = CA_KEY

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_CA_Report(ByVal CA_KEY As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA WHERE CA_KEY=@CA_KEY AND CA_QUALIFYING_COST <> '0'"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@CA_KEY", SqlDbType.Int).Value = CA_KEY

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_DISPOSAL_BY_CA_KEY(ByVal CA_KEY As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA_DISPOSAL WHERE CA_KEY=@CA_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@CA_KEY", SqlDbType.Int).Value = CA_KEY

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_DISPOSAL_BY_CA_KEY_DISP_YA(ByVal CA_KEY As Integer, ByVal CA_DISP_YA As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA_DISPOSAL WHERE CA_KEY=@CA_KEY AND CA_DISP_YA=@CA_DISP_YA"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@CA_KEY", SqlDbType.Int).Value = CA_KEY
            SQLcmd.Parameters.Add("@CA_DISP_YA", SqlDbType.NVarChar, 5).Value = CA_DISP_YA

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_DISPOSAL_BY_CADISP_KEY(ByVal ID_CA As Integer, ByVal CA_DISP_KEY As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA_DISPOSAL WHERE CA_KEY=@CA_KEY AND CA_DISP_KEY=@CA_DISP_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@CA_KEY", SqlDbType.Int).Value = ID_CA
            SQLcmd.Parameters.Add("@CA_DISP_KEY", SqlDbType.Int).Value = CA_DISP_KEY

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_HP(ByVal HP_KEY As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM HP WHERE HP_KEY=@HP_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@HP_KEY", SqlDbType.Int).Value = HP_KEY

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_HP_INSTALLMENT(ByVal HP_KEY As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM HP_INSTALLMENT WHERE HP_KEY=@HP_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@HP_KEY", SqlDbType.Int).Value = HP_KEY

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_HP_YEARLY(ByVal HPD_KEY As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM HP_YEARLY WHERE HPD_KEY=@HPD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@HPD_KEY", SqlDbType.Int).Value = HPD_KEY

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function LoadHPCode_ByRefNo(ByVal RefNo As String, Optional ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT DISTINCT(HP_CODE) as HP FROM CA WHERE CA_REF_NO =@RefNo AND HP_CODE <> ''"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function LoadBusinessSource_ByRefNo(ByVal RefNo As String, ByVal BC_YA As String, Optional ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM BUSINESS_SOURCE WHERE BC_KEY =@RefNo AND BC_YA=@BC_YA"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@BC_YA", SqlDbType.NVarChar, 5).Value = BC_YA

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function LoadCategory(Optional ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA_CATEGORY ORDER BY CA_CODE"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function LoadPNL_Search(ByVal RefNo As String, ByVal YA As String, _
                                   Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM PROFIT_LOSS_ACCOUNT"
            Dim isWhere As Boolean = False
            SQLcmd = New SqlCommand

            If RefNo IsNot Nothing AndAlso RefNo <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE PL_REF_NO=@PL_REF_NO"
                Else
                    StrSQL += " AND PL_REF_NO=@PL_REF_NO"
                End If
                SQLcmd.Parameters.Add("@PL_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
            End If

            If YA IsNot Nothing AndAlso YA <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE PL_YA=@PL_YA"
                Else
                    StrSQL += " AND PL_YA=@PL_YA"
                End If
                SQLcmd.Parameters.Add("@PL_YA", SqlDbType.NVarChar, 5).Value = YA
            End If

            SQLcmd.CommandText = StrSQL


            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function LoadCA_Search(ByVal RefNo As String, ByVal YA As String, ByVal FilterType As Integer, ByVal FilterValue As String, _
                                   Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA"
            Dim isWhere As Boolean = False
            SQLcmd = New SqlCommand

            If RefNo IsNot Nothing AndAlso RefNo <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE CA_REF_NO=@CA_REF_NO"
                Else
                    StrSQL += " AND CA_REF_NO=@CA_REF_NO"
                End If
                SQLcmd.Parameters.Add("@CA_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
            End If

            If YA IsNot Nothing AndAlso YA <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE CA_YA=@CA_YA"
                Else
                    StrSQL += " AND CA_YA=@CA_YA"
                End If
                SQLcmd.Parameters.Add("@CA_YA", SqlDbType.NVarChar, 5).Value = YA
            End If

            If FilterType <> -1 Then
                If FilterValue <> "" Then
                    Select Case FilterType
                        Case 0
                            'Asset Description
                            If isWhere = False Then
                                isWhere = True
                                StrSQL += " WHERE CA_ASSET LIKE @CA_ASSET"
                            Else
                                StrSQL += " AND CA_ASSET LIKE @CA_ASSET"
                            End If
                            SQLcmd.Parameters.Add("@CA_ASSET", SqlDbType.NVarChar, 255).Value = "%" & FilterValue & "%"
                        Case 1
                            'Asset Code
                            If isWhere = False Then
                                isWhere = True
                                StrSQL += " WHERE CA_ASSET_CODE LIKE @CA_ASSET_CODE"
                            Else
                                StrSQL += " AND CA_ASSET_CODE LIKE @CA_ASSET_CODE"
                            End If
                            SQLcmd.Parameters.Add("@CA_ASSET_CODE", SqlDbType.NVarChar, 20).Value = "%" & FilterValue & "%"
                        Case 2
                            'Accelerated CA
                            If isWhere = False Then
                                isWhere = True
                                StrSQL += " WHERE CA_ACCELERATED LIKE @CA_ACCELERATED"
                            Else
                                StrSQL += " AND CA_ACCELERATED LIKE @CA_ACCELERATED"
                            End If
                            SQLcmd.Parameters.Add("@CA_ACCELERATED", SqlDbType.NVarChar, 20).Value = "%" & FilterValue & "%"
                        Case 3
                            'HP Code
                            If isWhere = False Then
                                isWhere = True
                                StrSQL += " WHERE HP_CODE LIKE @HP_CODE"
                            Else
                                StrSQL += " AND HP_CODE LIKE @HP_CODE"
                            End If
                            SQLcmd.Parameters.Add("@HP_CODE", SqlDbType.NVarChar, 255).Value = "%" & FilterValue & "%"
                        Case 4
                            'RA
                            If isWhere = False Then
                                isWhere = True
                                StrSQL += " WHERE CA_INCENTIVE=@CA_INCENTIVE"
                            Else
                                StrSQL += " AND CA_INCENTIVE=@CA_INCENTIVE"
                            End If
                            SQLcmd.Parameters.Add("@CA_INCENTIVE", SqlDbType.NVarChar, 3).Value = "RA"
                        Case 5
                            'ITA
                            If isWhere = False Then
                                isWhere = True
                                StrSQL += " WHERE CA_INCENTIVE=@CA_INCENTIVE"
                            Else
                                StrSQL += " AND CA_INCENTIVE=@CA_INCENTIVE"
                            End If
                            SQLcmd.Parameters.Add("@CA_INCENTIVE", SqlDbType.NVarChar, 3).Value = "ITA"
                        Case 7
                            'Deferred Claim

                    End Select
                End If
            End If
            SQLcmd.CommandText = StrSQL


            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function LoadCA_Search_Report(ByVal RefNo As String, ByVal YA As String, ByVal RateFrom As Integer, ByVal RateTo As Integer, _
                                   ByVal Category As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA"
            Dim isWhere As Boolean = False
            SQLcmd = New SqlCommand

            If RefNo IsNot Nothing AndAlso RefNo <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE CA_REF_NO=@CA_REF_NO"
                Else
                    StrSQL += " AND CA_REF_NO=@CA_REF_NO"
                End If
                SQLcmd.Parameters.Add("@CA_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
            End If

            If YA IsNot Nothing AndAlso YA <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE CA_PURCHASE_YEAR=@CA_PURCHASE_YEAR"
                Else
                    StrSQL += " AND CA_PURCHASE_YEAR=@CA_PURCHASE_YEAR"
                End If
                SQLcmd.Parameters.Add("@CA_PURCHASE_YEAR", SqlDbType.NVarChar, 5).Value = YA
            End If

            If Category IsNot Nothing AndAlso Category <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE CA_CATEGORY_CODE=@CA_CATEGORY_CODE"
                Else
                    StrSQL += " AND CA_CATEGORY_CODE=@CA_CATEGORY_CODE"
                End If
                SQLcmd.Parameters.Add("@CA_CATEGORY_CODE", SqlDbType.NVarChar, 20).Value = Category
            End If

            If RateFrom <> -1 Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE CA_RATE_AA >=@CA_RATE_AA"
                Else
                    StrSQL += " AND CA_RATE_AA >=@CA_RATE_AA"
                End If
                SQLcmd.Parameters.Add("@CA_RATE_AA", SqlDbType.Float).Value = RateFrom
            End If

            If RateTo <> -1 Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE CA_RATE_AA <=@CA_RATE_AA"
                Else
                    StrSQL += " AND CA_RATE_AA <=@CA_RATE_AA"
                End If
                SQLcmd.Parameters.Add("@CA_RATE_AA", SqlDbType.Float).Value = RateTo
            End If

            SQLcmd.CommandText = StrSQL


            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function LoadDisposal_Search_Report(ByVal RefNo As String, ByVal YA As String, ByVal RateFrom As Integer, ByVal RateTo As Integer, _
                                   ByVal Category As String, ByVal Type As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA_DISPOSAL WHERE CA_KEY in (SELECT CA_KEY FROM CA"
            Dim isWhere As Boolean = False
            SQLcmd = New SqlCommand

            If RefNo IsNot Nothing AndAlso RefNo <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE CA_REF_NO=@CA_REF_NO"
                Else
                    StrSQL += " AND CA_REF_NO=@CA_REF_NO"
                End If
                SQLcmd.Parameters.Add("@CA_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
            End If

            'If YA IsNot Nothing AndAlso YA <> "" Then
            '    If isWhere = False Then
            '        isWhere = True
            '        StrSQL += " WHERE CA_PURCHASE_YEAR=@CA_PURCHASE_YEAR"
            '    Else
            '        StrSQL += " AND CA_PURCHASE_YEAR=@CA_PURCHASE_YEAR"
            '    End If
            '    SQLcmd.Parameters.Add("@CA_PURCHASE_YEAR", SqlDbType.NVarChar, 5).Value = YA
            'End If

            If Category IsNot Nothing AndAlso Category <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE CA_CATEGORY_CODE=@CA_CATEGORY_CODE"
                Else
                    StrSQL += " AND CA_CATEGORY_CODE=@CA_CATEGORY_CODE"
                End If
                SQLcmd.Parameters.Add("@CA_CATEGORY_CODE", SqlDbType.NVarChar, 20).Value = Category
            End If

            If RateFrom <> -1 Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE CA_RATE_AA >=@CA_RATE_AA"
                Else
                    StrSQL += " AND CA_RATE_AA >=@CA_RATE_AA"
                End If
                SQLcmd.Parameters.Add("@CA_RATE_AA", SqlDbType.Float).Value = RateFrom
            End If

            If RateTo <> -1 Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE CA_RATE_AA <=@CA_RATE_AA"
                Else
                    StrSQL += " AND CA_RATE_AA <=@CA_RATE_AA"
                End If
                SQLcmd.Parameters.Add("@CA_RATE_AA", SqlDbType.Float).Value = RateTo
            End If

            StrSQL += ") AND CA_DISP_YA=@CA_DISP_YA AND CA_DISP_TYPE=@CA_DISP_TYPE"
            SQLcmd.Parameters.Add("@CA_DISP_YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@CA_DISP_TYPE", SqlDbType.Int).Value = Type



            SQLcmd.CommandText = StrSQL


            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function LoadCA_Search_Report_ControlTransfer(ByVal RefNo As String, ByVal YA As String, ByVal RateFrom As Integer, ByVal RateTo As Integer, _
                                   ByVal Category As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA"
            Dim isWhere As Boolean = False
            SQLcmd = New SqlCommand

            If RefNo IsNot Nothing AndAlso RefNo <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE CA_REF_NO=@CA_REF_NO"
                Else
                    StrSQL += " AND CA_REF_NO=@CA_REF_NO"
                End If
                SQLcmd.Parameters.Add("@CA_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
            End If

            If YA IsNot Nothing AndAlso YA <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE CA_YA=@CA_YA"
                Else
                    StrSQL += " AND CA_YA=@CA_YA"
                End If
                SQLcmd.Parameters.Add("@CA_YA", SqlDbType.NVarChar, 5).Value = YA
            End If

            If Category IsNot Nothing AndAlso Category <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE CA_CATEGORY_CODE=@CA_CATEGORY_CODE"
                Else
                    StrSQL += " AND CA_CATEGORY_CODE=@CA_CATEGORY_CODE"
                End If
                SQLcmd.Parameters.Add("@CA_CATEGORY_CODE", SqlDbType.NVarChar, 20).Value = Category
            End If

            If RateFrom <> -1 Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE CA_RATE_AA >=@CA_RATE_AA"
                Else
                    StrSQL += " AND CA_RATE_AA >=@CA_RATE_AA"
                End If
                SQLcmd.Parameters.Add("@CA_RATE_AA", SqlDbType.Float).Value = RateFrom
            End If

            If RateTo <> -1 Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE CA_RATE_AA <=@CA_RATE_AA"
                Else
                    StrSQL += " AND CA_RATE_AA <=@CA_RATE_AA"
                End If
                SQLcmd.Parameters.Add("@CA_RATE_AA", SqlDbType.Float).Value = RateTo
            End If

            StrSQL += " AND CA_TRANSFERROR_NAME is not null and CA_TRANSFERROR_NAME <> ''"

            SQLcmd.CommandText = StrSQL


            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function LoadHP_Search(ByVal RefNo As String, ByVal YA As String, ByVal FilterType As Integer, ByVal FilterValue As String, _
                                       Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM HP"
            Dim isWhere As Boolean = False
            SQLcmd = New SqlCommand

            If RefNo IsNot Nothing AndAlso RefNo <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE HP_REF_NO=@HP_REF_NO"
                Else
                    StrSQL += " AND HP_REF_NO=@HP_REF_NO"
                End If
                SQLcmd.Parameters.Add("@HP_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
            End If

            If YA IsNot Nothing AndAlso YA <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE HP_YA=@HP_YA"
                Else
                    StrSQL += " AND HP_YA=@HP_YA"
                End If
                SQLcmd.Parameters.Add("@HP_YA", SqlDbType.NVarChar, 5).Value = YA
            End If

            If FilterType <> -1 Then
                If FilterValue <> "" Then
                    Select Case FilterType
                        Case 0
                            'Asset Description
                            If isWhere = False Then
                                isWhere = True
                                StrSQL += " WHERE HP_ASSET LIKE @HP_ASSET"
                            Else
                                StrSQL += " AND HP_ASSET LIKE @HP_ASSET"
                            End If
                            SQLcmd.Parameters.Add("@HP_ASSET", SqlDbType.NVarChar, 255).Value = "%" & FilterValue & "%"
                        Case 1
                            'Asset Code
                            If isWhere = False Then
                                isWhere = True
                                StrSQL += " WHERE HP_ASSET_CODE LIKE @HP_ASSET_CODE"
                            Else
                                StrSQL += " AND HP_ASSET_CODE LIKE @HP_ASSET_CODE"
                            End If
                            SQLcmd.Parameters.Add("@HP_ASSET_CODE", SqlDbType.NVarChar, 20).Value = "%" & FilterValue & "%"
                        Case 2
                            'HP Code
                            If isWhere = False Then
                                isWhere = True
                                StrSQL += " WHERE HP_CODE LIKE @HP_CODE"
                            Else
                                StrSQL += " AND HP_CODE LIKE @HP_CODE"
                            End If
                            SQLcmd.Parameters.Add("@HP_CODE", SqlDbType.NVarChar, 255).Value = "%" & FilterValue & "%"

                    End Select
                End If
            End If
            SQLcmd.CommandText = StrSQL


            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_CAReportSummary2_Temp(ByVal ID As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT a.* FROM CA_REPORT_SUMMARY_TEMP a INNER JOIN (select ID_KEY,RefNo,ca_key,CA_NAME,CA_ASSET from CA_REPORT_SUMMARY_TEMP GROUP BY RefNo,ca_key,CA_NAME,CA_ASSET,ID_KEY) b ON a.ID_key = b.ID_KEY WHERE a.ID=@ID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.NVarChar, 50).Value = ID

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
    Public Function Load_CAReport_Temp(ByVal ID As String, ByVal YA As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT a.* FROM CA_REPORT_TEMP a INNER JOIN (select ID_KEY,RefNo,ca_key,CA_NAME,CA_ASSET from CA_REPORT_TEMP GROUP BY RefNo,ca_key,CA_NAME,CA_ASSET,ID_KEY) b ON a.ID_key = b.ID_KEY WHERE a.ID=@ID AND YA=@YA"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.NVarChar, 50).Value = ID
            SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = YA

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
    Public Function Load_CAReport_ControlTransfer_Temp(ByVal ID As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA_REPORT_CONTROLTRANSFER_TEMP WHERE ID=@ID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.NVarChar, 50).Value = ID

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
    Public Function Load_CAReport_Disposal(ByVal ID As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA_REPORT_DISPOSAL_TEMP WHERE ID=@ID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.NVarChar, 50).Value = ID

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
    Public Function Load_CAReport_FAReconciliation_Temp(ByVal ID As String, ByVal YA As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT a.* FROM CA_REPORT_FIXEDASSET_TEMP a INNER JOIN (select ID_KEY,RefNo,ca_key,CA_NAME,CA_ASSET from CA_REPORT_FIXEDASSET_TEMP GROUP BY RefNo,ca_key,CA_NAME,CA_ASSET,ID_KEY) b ON a.ID_key = b.ID_KEY WHERE a.ID=@ID AND a.YA=@YA"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.NVarChar, 50).Value = ID
            SQLcmd.Parameters.Add("@YA", SqlDbType.NVarChar, 5).Value = YA

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
    Public Function Load_CAReportSummary_Temp_ByRate(ByVal ID As String, ByVal YA As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            'Dim StrSQL As String = "SELECT a.* FROM CA_REPORT_TEMP a INNER JOIN (select ID_KEY,RefNo,ca_key,CA_NAME,CA_ASSET from CA_REPORT_TEMP GROUP BY RefNo,ca_key,CA_NAME,CA_ASSET,ID_KEY) b ON a.ID_key = b.ID_KEY WHERE a.ID=@ID AND a.YA=@YA"

            Dim StrSQL As String = "select RefNo,CA_NAME,CA_TRANSFERROR_NAME,CA_RATE_AA,CA_PURCHASE_YEAR,sum(QC_BF) as QC_BF,sum(QC_ADD) as QC_ADD,sum(QC_DISP) as QC_DISP,sum(QC_CF) as QC_CF,sum(TWDV_BF) as TWDV_BF,sum(TWDV_ADD) as TWDV_ADD,sum(TWDV_DISP) as TWDV_DISP,sum(TWDV_AI) as TWDV_AI,sum(TWDV_AA) as TWDV_AA,sum(TWDV_CF) as TWDV_CF,sum(TWDV_TOTAL) as TWDV_TOTAL from CA_REPORT_TEMP where ID=@ID AND YA=@YA GROUP BY RefNo,CA_NAME,CA_TRANSFERROR_NAME,CA_RATE_AA,CA_PURCHASE_YEAR"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.NVarChar, 50).Value = ID
            SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = YA

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
    Public Function Load_CAReportSummary_Temp_ByCategory(ByVal ID As String, ByVal YA As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            'Dim StrSQL As String = "SELECT a.* FROM CA_REPORT_TEMP a INNER JOIN (select ID_KEY,RefNo,ca_key,CA_NAME,CA_ASSET from CA_REPORT_TEMP GROUP BY RefNo,ca_key,CA_NAME,CA_ASSET,ID_KEY) b ON a.ID_key = b.ID_KEY WHERE a.ID=@ID AND a.YA=@YA"

            Dim StrSQL As String = "select RefNo,CA_NAME,CA_TRANSFERROR_NAME,CA_CATEGORY_CODE,CA_RATE_AA,CA_PURCHASE_YEAR,sum(QC_BF) as QC_BF,sum(QC_ADD) as QC_ADD,sum(QC_DISP) as QC_DISP,sum(QC_CF) as QC_CF,sum(TWDV_BF) as TWDV_BF,sum(TWDV_ADD) as TWDV_ADD,sum(TWDV_DISP) as TWDV_DISP,sum(TWDV_AI) as TWDV_AI,sum(TWDV_AA) as TWDV_AA,sum(TWDV_CF) as TWDV_CF,sum(TWDV_TOTAL) as TWDV_TOTAL from CA_REPORT_TEMP where ID=@ID AND YA=@YA GROUP BY RefNo,CA_NAME,CA_TRANSFERROR_NAME,CA_CATEGORY_CODE,CA_RATE_AA,CA_PURCHASE_YEAR"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.NVarChar, 50).Value = ID
            SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = YA

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
#End Region
#Region "PNL"

    Public Function Load_PNLReport_ByID(ByVal ID As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM PROFIT_LOSS_ACCOUNT_REPORT_TEMP WHERE ID=@ID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.NVarChar, 50).Value = ID

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
    Public Function Check_AdjustedIncomeExist(ByVal RefNo As String, ByVal YA As String, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return True
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT COUNT(*) AS countx FROM TAX_COMPUTATION WHERE TC_REF_NO=@TC_REF_NO AND TC_YA=@TC_YA"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@TC_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@TC_YA", SqlDbType.NVarChar, 5).Value = YA

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("countx")) = False AndAlso dt.Rows(0)("countx") > 0 Then
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
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

            AddListOfError(ErrorLog)
            Return True
        End Try
    End Function

    Public Function Load_PNL_PLFST_SALES(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try

            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM PLFST_SALES WHERE PLFS_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_PLFST_SALES_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM PLFST_SALES_DETAIL WHERE PLFSD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_PLFST_OPENSTOCK(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM PLFST_OPENSTOCK WHERE PLFOS_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_PLFST_OPENSTOCK_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM PLFST_OPENSTOCK_DETAIL WHERE PLFOSD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_PLFST_PURCHASE(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM PLFST_PURCHASE WHERE PLFPUR_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_PLFST_PURCHASE_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM PLFST_PURCHASE_DETAIL WHERE PLFPURD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_EXPENSES_DEPRECIATION(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM EXPENSES_DEPRECIATION WHERE EXDEP_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_EXPENSES_DEPRECIATION_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM EXPENSES_DEPRECIATION_DETAIL WHERE EXDEPD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_EXPENSES_ALLOW(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM EXPENSES_ALLOW WHERE EXA_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_EXPENSES_ALLOW_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM EXPENSES_ALLOW_DETAIL WHERE EXAD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_EXPENSES_NONALLOW(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM EXPENSES_NONALLOW WHERE EXNA_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_EXPENSES_NONALLOW_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM EXPENSES_NONALLOW_DETAIL WHERE EXNAD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_PLFST_CLOSESTOCK(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM PLFST_CLOSESTOCK WHERE PLFCS_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_PLFST_CLOSESTOCK_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM PLFST_CLOSESTOCK_DETAIL WHERE PLFCSD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_NONSOURCE_BUSINESSINCOME(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM NONSOURCE_BUSINESSINCOME WHERE NSBI_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_NONSOURCE_BUSINESSINCOME_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM NONSOURCE_BUSINESSINCOME_DETAIL WHERE NSBID_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_INCOME_REALFET(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM INCOME_REALFET WHERE IRFET_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_INCOME_REALFET_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM INCOME_REALFET_DETAIL WHERE IRFETD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_dividend_income(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM dividend_income WHERE DI_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_INCOME_NBINTEREST(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM INCOME_NBINTEREST WHERE NOBII_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_INCOME_NBINTEREST_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM INCOME_NBINTEREST_DETAIL WHERE NOBIID_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_rental_income(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM rental_income WHERE RI_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_INCOME_NBROYALTY(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM INCOME_NBROYALTY WHERE NOBRI_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_INCOME_NBROYALTY_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM INCOME_NBROYALTY_DETAIL WHERE NOBRID_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_OTHER_INCOME(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_INCOME WHERE OI_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_OTHER_INCOME_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_INCOME_DETAIL WHERE OID_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_INCOME_NTDISPOSALFA(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM INCOME_NTDISPOSALFA WHERE NTIDFA_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_INCOME_NTDISPOSALFA_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM INCOME_NTDISPOSALFA_DETAIL WHERE NTIDFAD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_INCOME_NTDISPOSALINVEST(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM INCOME_NTDISPOSALINVEST WHERE NTIDI_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_INCOME_NTDISPOSALINVEST_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM INCOME_NTDISPOSALINVEST_DETAIL WHERE NTIDID_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_exempt_dividend(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM exempt_dividend WHERE ED_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_INCOME_NTFOREIGNINCREM(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM INCOME_NTFOREIGNINCREM WHERE NTIFIR_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_INCOME_NTFOREIGNINCREM_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM INCOME_NTFOREIGNINCREM_DETAIL WHERE NTIFIRD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_INCOME_NTUREALFET(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM INCOME_NTUREALFET WHERE NTIUT_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_INCOME_NTUREALFET_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM INCOME_NTUREALFET_DETAIL WHERE NTIUTD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_INCOME_NTREALFE(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM INCOME_NTREALFE WHERE NTIRFECT_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_INCOME_NTREALFE_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM INCOME_NTREALFE_DETAIL WHERE NTIRFECTD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_INCOME_NTUREALFENT(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM INCOME_NTUREALFENT WHERE NTIUNT_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_INCOME_NTUREALFENT_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM INCOME_NTUREALFENT_DETAIL WHERE NTIUNTD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_non_taxable_income(ByVal RefNo As String, ByVal YA As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM non_taxable_income WHERE NT_REF_NO=@NT_REF_NO AND NT_YA=@NT_YA AND NT_CATEGORIZED='Other'"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NT_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@NT_YA", SqlDbType.Int).Value = YA


            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_NON_TAXABLE_INCOME_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM NON_TAXABLE_INCOME_DETAIL WHERE NTD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_expenses_interestrestrict(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM expenses_interestrestrict WHERE EXIR_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_EXPENSES_INTERESTRESTRICT_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM EXPENSES_INTERESTRESTRICT_DETAIL WHERE EXIRD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_expenses_interest(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM expenses_interest WHERE EXI_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_EXPENSES_INTEREST_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM EXPENSES_INTEREST_DETAIL WHERE EXID_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_expenses_legal(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM expenses_legal WHERE EXL_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_EXPENSES_LEGAL_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM EXPENSES_LEGAL_DETAIL WHERE EXLD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_expenses_tech_fee(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM expenses_tech_fee WHERE EXTF_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_EXPENSES_TECH_FEE_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM EXPENSES_TECH_FEE_DETAIL WHERE EXTFD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_expenses_contract(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM expenses_contract WHERE EXC_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_EXPENSES_CONTRACT_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM EXPENSES_CONTRACT_DETAIL WHERE EXCD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_expenses_directors_fee(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM expenses_directors_fee WHERE EXDF_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_EXPENSES_DIRECTORS_FEE_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM EXPENSES_DIRECTORS_FEE_DETAIL WHERE EXDFD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_expenses_salary(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM expenses_salary WHERE EXS_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_EXPENSES_SALARY_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM EXPENSES_SALARY_DETAIL WHERE EXSD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_expenses_empl_stock(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM expenses_empl_stock WHERE EXES_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_EXPENSES_EMPLSTOCK_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM EXPENSES_EMPLSTOCK_DETAIL WHERE EXESD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_expenses_royalty(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM expenses_royalty WHERE EXRO_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_EXPENSES_ROYALTY_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM EXPENSES_ROYALTY_DETAIL WHERE EXROD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_expenses_rental(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM expenses_rental WHERE EXRENT_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_EXPENSES_RENTAL_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM EXPENSES_RENTAL_DETAIL WHERE EXRENTD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_expenses_repair(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM expenses_repair WHERE EXREP_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_EXPENSES_REPAIR_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM EXPENSES_REPAIR_DETAIL WHERE EXREPD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_expenses_research(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM expenses_research WHERE EXRES_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_EXPENSES_RESEARCH_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM EXPENSES_RESEARCH_DETAIL WHERE EXRESD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_expenses_promote(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM expenses_promote WHERE EXP_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_EXPENSES_PROMOTE_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM EXPENSES_PROMOTE_DETAIL WHERE EXPD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_expenses_travel(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM expenses_travel WHERE EXT_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_EXPENSES_TRAVEL_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM EXPENSES_TRAVEL_DETAIL WHERE EXTD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_expenses_jkdm(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM expenses_jkdm WHERE EXJK_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_EXPENSES_JKDM_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM EXPENSES_JKDM_DETAIL WHERE EXJKD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_other_exdepreciation(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM other_exdepreciation WHERE EXODEP_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_OTHER_EXDEPRECIATION_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_EXDEPRECIATION_DETAIL WHERE EXODEPD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_other_exapprdonation(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM other_exapprdonation WHERE EXOAD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_OTHER_EXAPPRDONATION_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_EXAPPRDONATION_DETAIL WHERE EXOADD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_other_exnapprdonation(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM other_exnapprdonation WHERE EXONAD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_OTHER_EXNAPPRDONATION_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_EXNAPPRDONATION_DETAIL WHERE EXONADD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_other_exzakat(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM other_exzakat WHERE EXOZ_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_OTHER_EXZAKAT_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_EXZAKAT_DETAIL WHERE EXOZD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_other_exlossdisposalfa(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM other_exlossdisposalfa WHERE EXOLD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_OTHER_EXLOSSDISPOSALFA_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_EXLOSSDISPOSALFA_DETAIL WHERE EXOLDD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_other_entertainnstaff(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM other_entertainnstaff WHERE EXOENS_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_OTHER_ENTERTAINNSTAFF_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_ENTERTAINNSTAFF_DETAIL WHERE EXOENSD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_OTHER_ENTERTAINSTAFF(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_ENTERTAINSTAFF WHERE EXOES_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_OTHER_ENTERTAINSTAFF_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_ENTERTAINSTAFF_DETAIL WHERE EXOESD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_other_expenalty(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM other_expenalty WHERE EXOP_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_OTHER_EXPENALTY_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_EXPENALTY_DETAIL WHERE EXOPD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_other_exprovisionacc(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM other_exprovisionacc WHERE EXOPA_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_OTHER_EXPROVISIONACC_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_EXPROVISIONACC_DETAIL WHERE EXOPAD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_other_exleavepassage(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM other_exleavepassage WHERE EXOLP_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_OTHER_EXLEAVEPASSAGE_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_EXLEAVEPASSAGE_DETAIL WHERE EXOLPD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_other_exfawrittenoff(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM other_exfawrittenoff WHERE EXOWO_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_OTHER_EXFAWRITTENOFF_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_EXFAWRITTENOFF_DETAIL WHERE EXOWOD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_other_exurlossforeign(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM other_exurlossforeign WHERE EXOUR_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_OTHER_EXURLOSSFOREIGN_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_EXURLOSSFOREIGN_DETAIL WHERE EXOURD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_other_exrlossforeignt(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM other_exrlossforeignt WHERE EXORT_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_OTHER_EXRLOSSFOREIGNT_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_EXRLOSSFOREIGNT_DETAIL WHERE EXORTD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_other_exrlossforeign(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM other_exrlossforeign WHERE EXOR_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_OTHER_EXRLOSSFOREIGN_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_EXRLOSSFOREIGN_DETAIL WHERE EXORD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_other_exinitialsub(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM other_exinitialsub WHERE EXOIS_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_OTHER_EXINITIALSUB_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_EXINITIALSUB_DETAIL WHERE EXOISD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_other_excapitalexp(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM other_excapitalexp WHERE EXOCE_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_OTHER_EXCAPITALEXP_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_EXCAPITALEXP_DETAIL WHERE EXOCED_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_other_expenses(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            'Dim StrSQL As String = "SELECT * FROM other_expenses WHERE EXO_KEY=@PL_KEY"
            Dim StrSQL As String = "SELECT EXO_KEY,EXO_EXOKEY,SUM(EXO_AMOUNT) AS EXO_AMOUNT,EXO_DESC,EXO_NOTE,EXO_SOURCENO,EXO_DETAIL,RowIndex,Pecentage FROM OTHER_EXPENSES where EXO_KEY =@PL_KEY GROUP BY EXO_EXOKEY,EXO_DESC,EXO_NOTE,EXO_SOURCENO,EXO_KEY,EXO_DETAIL,RowIndex,Pecentage"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_OTHER_EXPENSES_DETAIL(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM OTHER_EXPENSES_DETAIL WHERE EXOD_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function

    Public Function Load_PNL_ByKey(ByVal KeyID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM PROFIT_LOSS_ACCOUNT WHERE PL_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = KeyID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNLLastModified(ByVal Key As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT ModifiedDateTime FROM PROFIT_LOSS_ACCOUNT WHERE PL_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = Key

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function

    Public Function VerifyInvestmentHolding(ByVal RefNo As String, ByVal YA As String, _
                                            Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "Select ih_key from investment_holding where ih_ref_no=@refno and ih_ya =@ya"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 30).Value = RefNo
            SQLcmd.Parameters.Add("@ya", SqlDbType.NVarChar, 5).Value = YA

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("ih_key")) = False Then
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
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function GETPNLKEY(Optional ByRef ErrorLog As clsError = Nothing) As Integer
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return -1
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select top 1 pl_key from profit_loss_account order by pl_key desc"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("pl_key")) = False Then
                Return CInt(dt.Rows(0)("pl_key"))
            Else
                Return -1
            End If
        Catch ex As Exception
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
            Return -1
        End Try
    End Function
    Public Function GETNONTAXABLEINCOME(Optional ByRef ErrorLog As clsError = Nothing) As Integer
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return -1
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select top 1 NT_KEY from NON_TAXABLE_INCOME order by NT_KEY desc"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("NT_KEY")) = False Then
                Return CInt(dt.Rows(0)("NT_KEY"))
            Else
                Return -1
            End If
        Catch ex As Exception
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
            Return -1
        End Try
    End Function
    Public Function Check_PNLExist(ByVal RefNo As String, ByVal YA As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT Count(*) as countx FROM PROFIT_LOSS_ACCOUNT WHERE PL_REF_NO=@PL_REF_NO AND PL_YA=@PL_YA"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_REF_NO", SqlDbType.NVarChar, 30).Value = RefNo
            SQLcmd.Parameters.Add("@PL_YA", SqlDbType.NVarChar, 5).Value = CStr(YA)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("countx")) = False AndAlso CInt(dt.Rows(0)("countx")) > 0 Then
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
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function

    Public Function Load_REF_INTEREST_RESTRIC_DETAIL_TEMP(ByVal KeyID As Integer, ByVal RefNo As String, ByVal YA As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM REF_INTEREST_RESTRIC_DETAIL_TEMP WHERE RIRD_KEY=@RIRD_KEY AND RIR_REF_NO=@RIR_REF_NO AND RIR_YA=@RIR_YA"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@RIRD_KEY", SqlDbType.Int).Value = KeyID
            SQLcmd.Parameters.Add("@RIR_REF_NO", SqlDbType.NVarChar, 30).Value = RefNo
            SQLcmd.Parameters.Add("@RIR_YA", SqlDbType.NVarChar, 10).Value = YA

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_interestRestricSchedule(ByVal RefNo As String, ByVal YA As String, _
                                                 ByVal SourceNo As Integer, ByVal Type As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select column_name as [Item], ref_num as [Item Ref], type as [Item Type], type_income as [Income Type], basicperiod as [Basic Period],  duration as [Month] from ref_interest_restric where tp_ref_no=@refno and yoa=@ya and rir_sourceno=@sourceno and type=@type order by ref_num"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@refno", SqlDbType.NVarChar, 30).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.NVarChar, 10).Value = YA
            SQLcmd.Parameters.Add("@SourceNo", SqlDbType.Int).Value = SourceNo
            SQLcmd.Parameters.Add("@type", SqlDbType.NVarChar, 10).Value = Type

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function

    Public Function Load_PNL_NonAllowDetails(ByVal DetailsName As String, ByVal PL_KEY As Integer, ByVal BC_SOURCENO As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = Nothing
            SQLcmd = New SqlCommand
            Select Case DetailsName.ToLower
                Case "purchase"
                    StrSQL = "SELECT [PLFPUR_AMOUNT] FROM [PLFST_PURCHASE] WHERE [PLFPUR_KEY]=@PLFPUR_KEY AND [PLFPUR_SOURCENO]= @PLFPUR_SOURCENO AND [PLFPUR_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@PLFPUR_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@PLFPUR_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "production cost - depreciation"
                    StrSQL = "SELECT [EXDEP_AMOUNT] FROM [EXPENSES_DEPRECIATION] WHERE [EXDEP_KEY]=@EXDEP_KEY AND [EXDEP_SOURCENO]=@EXDEP_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXDEP_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXDEP_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "production cost - other non allowable expenses"

                    StrSQL = "SELECT [EXNA_AMOUNT] FROM [EXPENSES_NONALLOW] WHERE [EXNA_KEY]=@EXNA_KEY AND [EXNA_SOURCENO]=@EXNA_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXNA_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXNA_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: interest restricted persuant to  S33 (2) - 1"

                    StrSQL = "SELECT [EXIR_AMOUNT] FROM [EXPENSES_INTERESTRESTRICT] WHERE [EXIR_KEY]=@EXIR_KEY AND [EXIR_SOURCENO]=@EXIR_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXIR_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXIR_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: interest restricted persuant to  S33 (2) - 2"

                    StrSQL = "SELECT [EXIR_AMOUNT] FROM [EXPENSES_INTERESTRESTRICT] WHERE [EXIR_KEY]=@EXIR_KEY AND [EXIR_SOURCENO]=@EXIR_SOURCENO AND [EXIR_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXIR_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXIR_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: other interest - 1"

                    StrSQL = "SELECT [EXI_AMOUNT] FROM [EXPENSES_INTEREST] WHERE [EXI_KEY]=@EXI_KEY AND [EXI_SOURCENO]=@EXI_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXI_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXI_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: other interest - 2"
                    StrSQL = "SELECT [EXI_AMOUNT] FROM [EXPENSES_INTEREST] WHERE [EXI_KEY]=@EXI_KEY AND [EXI_SOURCENO]=@EXI_SOURCENO AND [EXI_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXI_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXI_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: professional, technical, management & legal fees - 1"
                    StrSQL = "SELECT [EXL_AMOUNT] FROM [EXPENSES_LEGAL] WHERE [EXL_KEY]=@EXL_KEY AND [EXL_SOURCENO]=@EXL_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXL_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXL_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: professional, technical, management & legal fees - 2"
                    StrSQL = "SELECT [EXL_AMOUNT] FROM [EXPENSES_LEGAL] WHERE [EXL_KEY]=@EXL_KEY AND [EXL_SOURCENO]=@EXL_SOURCENO AND [EXL_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXL_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXL_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: contract payment - 1"
                    StrSQL = "SELECT [EXC_AMOUNT] FROM [EXPENSES_CONTRACT] WHERE [EXC_KEY]=@EXC_KEY AND [EXC_SOURCENO] =@EXC_SOURCENO "
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXC_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXC_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: contract payment - 2"
                    StrSQL = "SELECT [EXC_AMOUNT] FROM [EXPENSES_CONTRACT] WHERE [EXC_KEY]=@EXC_KEY AND [EXC_SOURCENO] =@EXC_SOURCENO AND [EXC_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXC_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXC_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: salary - 1"
                    StrSQL = "SELECT [EXS_AMOUNT] FROM [EXPENSES_SALARY] WHERE [EXS_KEY]=@EXS_KEY AND [EXS_SOURCENO] = @EXS_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXS_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXS_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: salary - 2"
                    StrSQL = "SELECT [EXS_AMOUNT] FROM [EXPENSES_SALARY] WHERE [EXS_KEY]=@EXS_KEY AND [EXS_SOURCENO] = @EXS_SOURCENO AND [EXS_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXS_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXS_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: royalty - 1"
                    StrSQL = "SELECT [EXRO_AMOUNT] FROM [EXPENSES_ROYALTY] WHERE [EXRO_KEY]=@EXRO_KEY AND [EXRO_SOURCENO] = @EXRO_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXRO_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXRO_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: royalty - 2"
                    StrSQL = "SELECT [EXRO_AMOUNT] FROM [EXPENSES_ROYALTY] WHERE [EXRO_KEY]=@EXRO_KEY AND [EXRO_SOURCENO] = @EXRO_SOURCENO AND [EXRO_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXRO_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXRO_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: rental - 1"
                    StrSQL = "SELECT [EXRENT_AMOUNT] FROM [EXPENSES_RENTAL] WHERE [EXRENT_KEY]=@EXRENT_KEY AND [EXRENT_SOURCENO] =@EXRENT_SOURCENO "
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXRENT_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXRENT_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: rental - 2"
                    StrSQL = "SELECT [EXRENT_AMOUNT] FROM [EXPENSES_RENTAL] WHERE [EXRENT_KEY]=@EXRENT_KEY AND [EXRENT_SOURCENO] = @EXRENT_SOURCENO AND [EXRENT_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXRENT_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXRENT_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: repair & maintenance - 1"
                    StrSQL = "SELECT [EXREP_AMOUNT] FROM [EXPENSES_REPAIR] WHERE [EXREP_KEY]=@EXREP_KEY AND [EXREP_SOURCENO] = @EXREP_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXREP_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXREP_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: repair & maintenance - 2"
                    StrSQL = "SELECT [EXREP_AMOUNT] FROM [EXPENSES_REPAIR] WHERE [EXREP_KEY]=@EXREP_KEY AND [EXREP_SOURCENO] = @EXREP_SOURCENO AND [EXREP_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXREP_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXREP_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: promotion & advertisement - 1"
                    StrSQL = "SELECT [EXP_AMOUNT] FROM [EXPENSES_PROMOTE] WHERE [EXP_KEY]=@EXP_KEY AND [EXP_SOURCENO] = @EXP_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXP_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXP_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: promotion & advertisement - 2"
                    StrSQL = "SELECT [EXP_AMOUNT] FROM [EXPENSES_PROMOTE] WHERE [EXP_KEY]=@EXP_KEY AND [EXP_SOURCENO] = @EXP_SOURCENO AND [EXP_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXP_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXP_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: travelling and accommodation - 1"
                    StrSQL = "SELECT [EXT_AMOUNT] FROM [EXPENSES_TRAVEL] WHERE [EXT_KEY]=@EXT_KEY AND [EXT_SOURCENO] =@EXT_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXT_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXT_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: travelling and accommodation - 2"
                    StrSQL = "SELECT [EXT_AMOUNT] FROM [EXPENSES_TRAVEL] WHERE [EXT_KEY]=@EXT_KEY AND [EXT_SOURCENO] = @EXT_SOURCENO AND [EXT_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXT_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXT_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: depreciation - 1"
                    StrSQL = "SELECT [EXODEP_AMOUNT] FROM [OTHER_EXDEPRECIATION] WHERE [EXODEP_KEY]=@EXODEP_KEY AND [EXODEP_SOURCENO] = @EXODEP_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXODEP_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXODEP_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: depreciation - 2"
                    StrSQL = "SELECT [EXODEP_AMOUNT] FROM [OTHER_EXDEPRECIATION] WHERE [EXODEP_KEY]=@EXODEP_KEY AND [EXODEP_SOURCENO] = @EXODEP_SOURCENO AND [EXODEP_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXODEP_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXODEP_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: donation - approved - 1"
                    StrSQL = "SELECT [EXOAD_AMOUNT] FROM [OTHER_EXAPPRDONATION] WHERE [EXOAD_KEY]=@EXOAD_KEY AND [EXOAD_SOURCENO] = @EXOAD_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOAD_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOAD_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: donation - approved - 2"
                    StrSQL = "SELECT [EXOAD_AMOUNT] FROM [OTHER_EXAPPRDONATION] WHERE [EXOAD_KEY]=@EXOAD_KEY AND [EXOAD_SOURCENO] = @EXOAD_SOURCENO AND [EXONAD_DEDUCTIBLE] = 'Yes'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOAD_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOAD_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: donation - non approved - 1"
                    StrSQL = "SELECT [EXONAD_AMOUNT] FROM [OTHER_EXNAPPRDONATION] WHERE [EXONAD_KEY]=@EXONAD_KEY AND [EXONAD_SOURCENO] =@EXONAD_SOURCENO "
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXONAD_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXONAD_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: donation - non approved - 2"
                    StrSQL = "SELECT [EXONAD_AMOUNT] FROM [OTHER_EXNAPPRDONATION] WHERE [EXONAD_KEY]=@EXONAD_KEY AND [EXONAD_SOURCENO] = @EXONAD_SOURCENO AND [EXONAD_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXONAD_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXONAD_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: zakat - 1"
                    StrSQL = "SELECT [EXOZ_AMOUNT] FROM [OTHER_EXZAKAT] WHERE [EXOZ_KEY]=@EXOZ_KEY AND [EXOZ_SOURCENO] =@EXOZ_SOURCENO "
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOZ_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOZ_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: zakat - 2"
                    StrSQL = "SELECT [EXOZ_AMOUNT] FROM [OTHER_EXZAKAT] WHERE [EXOZ_KEY]=@EXOZ_KEY AND [EXOZ_SOURCENO] = @EXOZ_SOURCENO AND [EXOZ_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOZ_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOZ_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: zakat - 3"
                    StrSQL = "SELECT [EXOZ_AMOUNT] FROM [OTHER_EXZAKAT] WHERE [EXOZ_KEY]=@EXOZ_KEY AND [EXOZ_SOURCENO] = @EXOZ_SOURCENO AND [EXOZ_DEDUCTIBLE] = 'Yes'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOZ_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOZ_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: entertainment - non staff - 1"
                    StrSQL = "SELECT [EXOENS_AMOUNT] FROM [OTHER_ENTERTAINNSTAFF] WHERE [EXOENS_KEY]=@EXOENS_KEY AND [EXOENS_SOURCENO] = @EXOENS_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOENS_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOENS_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: entertainment - non staff - 2"
                    StrSQL = "SELECT [EXOENS_AMOUNT] FROM [OTHER_ENTERTAINNSTAFF] WHERE [EXOENS_KEY]=@EXOENS_KEY AND [EXOENS_SOURCENO] = @EXOENS_SOURCENO AND [EXOENS_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOENS_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOENS_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other Expenses: entertainment - staff - 1"
                    StrSQL = "SELECT [EXOES_AMOUNT] FROM [OTHER_ENTERTAINSTAFF] WHERE [EXOES_KEY]=@EXOES_KEY AND [EXOES_SOURCENO] = @EXOES_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOES_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOES_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other Expenses: entertainment - staff - 2"
                    StrSQL = "SELECT [EXOES_AMOUNT] FROM [OTHER_ENTERTAINSTAFF] WHERE [EXOES_KEY]=@EXOES_KEY AND [EXOES_SOURCENO] = @EXOES_SOURCENO AND [EXOES_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOES_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOES_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: compound/penalty - 1"
                    StrSQL = "SELECT [EXOP_AMOUNT] FROM [OTHER_EXPENALTY] WHERE [EXOP_KEY]=@EXOP_KEY AND [EXOP_SOURCENO] = @EXOP_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOP_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOP_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: compound/penalty - 2"
                    StrSQL = "SELECT [EXOP_AMOUNT] FROM [OTHER_EXPENALTY] WHERE [EXOP_KEY]=@EXOP_KEY AND [EXOP_SOURCENO] = @EXOP_SOURCENO AND [EXOP_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOP_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOP_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: provision account - 1"
                    StrSQL = "SELECT [EXOPA_AMOUNT] FROM [OTHER_EXPROVISIONACC] WHERE [EXOPA_KEY]=@EXOPA_KEY AND [EXOPA_SOURCENO] =@EXOPA_SOURCENO "
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOPA_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOPA_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: provision account - 2"
                    StrSQL = "SELECT [EXOPA_AMOUNT] FROM [OTHER_EXPROVISIONACC] WHERE [EXOPA_KEY]=@EXOPA_KEY AND [EXOPA_SOURCENO] = @EXOPA_SOURCENO AND [EXOPA_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOPA_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOPA_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: leave passage - 1"
                    StrSQL = "SELECT [EXOLP_AMOUNT] FROM [OTHER_EXLEAVEPASSAGE] WHERE [EXOLP_KEY]=@EXOLP_KEY AND [EXOLP_SOURCENO] = @EXOLP_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOLP_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOLP_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: leave passage - 2"
                    StrSQL = "SELECT [EXOLP_AMOUNT] FROM [OTHER_EXLEAVEPASSAGE] WHERE [EXOLP_KEY]=@EXOLP_KEY AND [EXOLP_SOURCENO] = @EXOLP_SOURCENO AND [EXOLP_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOLP_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOLP_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: fixed asset written off - 1"
                    StrSQL = "SELECT [EXOWO_AMOUNT] FROM [OTHER_EXFAWRITTENOFF] WHERE [EXOWO_KEY]=@EXOWO_KEY AND [EXOWO_SOURCENO] =@EXOWO_SOURCENO "
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOWO_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOWO_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: fixed asset written off - 2"
                    StrSQL = "SELECT [EXOWO_AMOUNT] FROM [OTHER_EXFAWRITTENOFF] WHERE [EXOWO_KEY]=@EXOWO_KEY AND [EXOWO_SOURCENO] = @EXOWO_SOURCENO AND [EXOWO_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOWO_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOWO_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: initial subscription - 1"
                    StrSQL = "SELECT [EXOIS_AMOUNT] FROM [OTHER_EXINITIALSUB] WHERE [EXOIS_KEY]=@EXOIS_KEY AND [EXOIS_SOURCENO] = @EXOIS_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOIS_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOIS_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: initial subscription - 2"
                    StrSQL = "SELECT [EXOIS_AMOUNT] FROM [OTHER_EXINITIALSUB] WHERE [EXOIS_KEY]=@EXOIS_KEY AND [EXOIS_SOURCENO] = @EXOIS_SOURCENO AND [EXOIS_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOIS_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOIS_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: capital expenditure - 1"
                    StrSQL = "SELECT [EXOCE_AMOUNT] FROM [OTHER_EXCAPITALEXP] WHERE [EXOCE_KEY]=@EXOCE_KEY AND [EXOCE_SOURCENO] =@EXOCE_SOURCENO "
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOCE_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOCE_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: capital expenditure - 2"
                    StrSQL = "SELECT [EXOCE_AMOUNT] FROM [OTHER_EXCAPITALEXP] WHERE [EXOCE_KEY]=@EXOCE_KEY AND [EXOCE_SOURCENO] = @EXOCE_SOURCENO AND [EXOCE_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOCE_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOCE_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: others - 1"
                    StrSQL = "SELECT [EXO_AMOUNT] FROM [OTHER_EXPENSES] WHERE [EXO_KEY]=@EXO_KEY AND [EXO_SOURCENO] = @EXO_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXO_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXO_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: others - 2"
                    StrSQL = "SELECT [EXO_AMOUNT] FROM [OTHER_EXPENSES] WHERE [EXO_KEY]=@EXO_KEY AND [EXO_SOURCENO] = @EXO_SOURCENO AND [EXO_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXO_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXO_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: technical fee payments to non-resident recipients - 1"
                    StrSQL = "SELECT [EXTF_AMOUNT] FROM [EXPENSES_TECH_FEE] WHERE [EXTF_KEY]=@EXTF_KEY AND [EXTF_SOURCENO] = @EXTF_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXTF_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXTF_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: technical fee payments to non-resident recipients - 2"
                    StrSQL = "SELECT [EXTF_AMOUNT] FROM [EXPENSES_TECH_FEE] WHERE [EXTF_KEY]=@EXTF_KEY AND [EXTF_SOURCENO] = @EXTF_SOURCENO AND [EXTF_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXTF_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXTF_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: cost of employee stock options - 1"
                    StrSQL = "SELECT [EXES_AMOUNT] FROM [EXPENSES_EMPL_STOCK] WHERE [EXES_KEY]=@EXES_KEY AND [EXES_SOURCENO] = @EXES_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXES_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXES_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: cost of employee stock options - 2"
                    StrSQL = "SELECT [EXES_AMOUNT] FROM [EXPENSES_EMPL_STOCK] WHERE [EXES_KEY]=@EXES_KEY AND [EXES_SOURCENO] = @EXES_SOURCENO AND [EXES_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXES_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXES_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: realised loss on foreign exchange - non-trade - 1"
                    StrSQL = "SELECT [EXOR_AMOUNT] FROM [OTHER_EXRLOSSFOREIGN] WHERE [EXOR_KEY]=@EXOR_KEY AND [EXOR_SOURCENO] = @EXOR_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOR_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOR_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: realised loss on foreign exchange - non-trade - 2"
                    StrSQL = "SELECT [EXOR_AMOUNT] FROM [OTHER_EXRLOSSFOREIGN] WHERE [EXOR_KEY]=@EXOR_KEY AND [EXOR_SOURCENO] = @EXOR_SOURCENO AND [EXOR_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOR_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOR_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: unrealised loss on foreign exchange - 1"
                    StrSQL = "SELECT [EXOUR_AMOUNT] FROM [OTHER_EXURLOSSFOREIGN] WHERE [EXOUR_KEY]=@EXOUR_KEY AND [EXOUR_SOURCENO] = @EXOUR_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOUR_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOUR_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: unrealised loss on foreign exchange - 2"
                    StrSQL = "SELECT [EXOUR_AMOUNT] FROM [OTHER_EXURLOSSFOREIGN] WHERE [EXOUR_KEY]=@EXOUR_KEY AND [EXOUR_SOURCENO] = @EXOUR_SOURCENO AND [EXOUR_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOUR_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOUR_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: loss on disposal of fixed assets - 1"
                    StrSQL = "SELECT [EXOLD_AMOUNT] FROM [OTHER_EXLOSSDISPOSALFA] WHERE [EXOLD_KEY]=@EXOLD_KEY AND [EXOLD_SOURCENO] = @EXOLD_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOLD_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOLD_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: loss on disposal of fixed assets - 2"
                    StrSQL = "SELECT [EXOLD_AMOUNT] FROM [OTHER_EXLOSSDISPOSALFA] WHERE [EXOLD_KEY]=@EXOLD_KEY AND [EXOLD_SOURCENO] = @EXOLD_SOURCENO AND [EXOLD_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOLD_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXOLD_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: realised loss on foreign exchange - trade - 1"
                    StrSQL = "SELECT [EXORT_AMOUNT] FROM [OTHER_EXRLOSSFOREIGNT] WHERE [EXORT_KEY]=@EXORT_KEY AND [EXORT_SOURCENO] = @EXORT_SOURCENO "
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXORT_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXORT_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "other expenses: realised loss on foreign exchange - trade - 2"
                    StrSQL = "SELECT [EXORT_AMOUNT] FROM [OTHER_EXRLOSSFOREIGNT] WHERE [EXORT_KEY]=@EXORT_KEY AND [EXORT_SOURCENO] = @EXORT_SOURCENO AND [EXORT_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXORT_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXORT_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: director's fee - 1"
                    StrSQL = "SELECT [EXDF_AMOUNT] FROM [EXPENSES_DIRECTORS_FEE] WHERE [EXDF_KEY]=@EXDF_KEY AND [EXDF_SOURCENO] = @EXDF_SOURCENO"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXDF_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXDF_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: director's fee - 2"
                    StrSQL = "SELECT [EXDF_AMOUNT] FROM [EXPENSES_DIRECTORS_FEE] WHERE [EXDF_KEY]=@EXDF_KEY AND [EXDF_SOURCENO] = @EXDF_SOURCENO AND [EXDF_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXDF_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXDF_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: input tax not claimable from jkdm - 1"
                    StrSQL = "SELECT [EXJK_AMOUNT] FROM [EXPENSES_JKDM] WHERE [EXJK_KEY]=@EXJK_KEY AND [EXJK_SOURCENO] =@EXJK_SOURCENO "
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXJK_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXJK_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

                Case "expenses: input tax not claimable from jkdm - 2"
                    StrSQL = "SELECT [EXJK_AMOUNT] FROM [EXPENSES_JKDM] WHERE [EXJK_KEY]=@EXJK_KEY AND [EXJK_SOURCENO] = @EXJK_SOURCENO AND [EXJK_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXJK_KEY", SqlDbType.Int).Value = PL_KEY
                    SQLcmd.Parameters.Add("@EXJK_SOURCENO", SqlDbType.Int).Value = BC_SOURCENO

            End Select




            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL(ByVal PL_REF_NO As String, ByVal PL_YA As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM PROFIT_LOSS_ACCOUNT WHERE PL_REF_NO=@PL_REF_NO AND PL_YA=@PL_YA"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_REF_NO", SqlDbType.NVarChar, 20).Value = PL_REF_NO
            SQLcmd.Parameters.Add("@PL_YA", SqlDbType.NVarChar, 5).Value = PL_YA

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_GetKey(ByVal pl_ref_no As String, ByVal pl_ya As String, Optional ByRef ErrorLog As clsError = Nothing) As String
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return "0"
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select top 1 pl_key from profit_loss_account where pl_ref_no=@pl_ref_no and pl_ya=@pl_ya order by pl_key desc"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@pl_ref_no", SqlDbType.NVarChar, 20).Value = pl_ref_no
            SQLcmd.Parameters.Add("@pl_ya", SqlDbType.NVarChar, 5).Value = pl_ya

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("pl_key")) = False Then
                Return CStr(dt.Rows(0)("pl_key"))
            Else
                Return "0"
            End If

        Catch ex As Exception
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
            Return "0"
        End Try
    End Function
#End Region
#Region "TAXCOMPUTATION"
    Public Function Load_LessApprove_Donation(ByVal PL_REF_NO As String, ByVal PL_YA As String, _
                                              Optional ByRef PL_KEY As Integer = 0, Optional ByRef PL_MAINBUZ As Integer = 0, _
                                              Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT [PL_KEY], [PL_MAINBUZ] FROM [PROFIT_LOSS_ACCOUNT] WHERE [PL_REF_NO] = @PL_REF_NO AND [PL_YA] = @PL_YA"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_REF_NO", SqlDbType.NVarChar, 20).Value = PL_REF_NO
            SQLcmd.Parameters.Add("@PL_YA", SqlDbType.NVarChar, 5).Value = PL_YA

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                PL_KEY = CInt(IIf(IsDBNull(dt.Rows(0)("PL_KEY")), 0, dt.Rows(0)("PL_KEY")))
                PL_MAINBUZ = CInt(IIf(IsDBNull(dt.Rows(0)("PL_MAINBUZ")), 0, dt.Rows(0)("PL_MAINBUZ")))
            End If

            Return dt
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_OpeningBalance_NextYA(ByVal OB_REF_NO As String, ByVal OB_YA As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT [OB_KEY], [OB_SCHEDULE],[OB_BS_LOSS],[OB_INVESTMENT],[OB_SOURCENO],[OB_RA],[OB_SRNAMT] FROM [OPENING_BALANCE] WHERE [OB_REF_NO]= @OB_REF_NO AND [OB_YA]= @OB_YA ORDER BY [OB_SOURCENO]"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@OB_REF_NO", SqlDbType.NVarChar, 20).Value = OB_REF_NO
            SQLcmd.Parameters.Add("@OB_YA", SqlDbType.NVarChar, 5).Value = CStr(CInt(OB_YA) + 1)

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_OpeningBalance(ByVal OB_REF_NO As String, ByVal OB_YA As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT [OB_KEY], [OB_SCHEDULE],[OB_BS_LOSS],[OB_INVESTMENT],[OB_SOURCENO],[OB_RA],[OB_SRNAMT],[OB_EXPORT] FROM [OPENING_BALANCE] WHERE [OB_REF_NO]= @OB_REF_NO AND [OB_YA]= @OB_YA ORDER BY [OB_SOURCENO]"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@OB_REF_NO", SqlDbType.NVarChar, 20).Value = OB_REF_NO
            SQLcmd.Parameters.Add("@OB_YA", SqlDbType.NVarChar, 5).Value = OB_YA

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_RA_OpeningBalance(ByVal OB_REF_NO As String, ByVal OB_YA As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT [OB_SOURCENO],[OB_RA] FROM [OPENING_BALANCE] WHERE [OB_REF_NO]= @OB_REF_NO AND [OB_YA]= @OB_YA ORDER BY [OB_SOURCENO]"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@OB_REF_NO", SqlDbType.NVarChar, 20).Value = OB_REF_NO
            SQLcmd.Parameters.Add("@OB_YA", SqlDbType.NVarChar, 5).Value = OB_YA

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_PartnerIncome(ByVal TCP_REF_NO As String, ByVal TCP_YA As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM [TAX_COMPUTATION_PARTNER] WHERE [TCP_REF_NO]= @TCP_REF_NO AND [TCP_YA]= @TCP_YA"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@TCP_REF_NO", SqlDbType.NVarChar, 20).Value = TCP_REF_NO
            SQLcmd.Parameters.Add("@TCP_YA", SqlDbType.NVarChar, 5).Value = TCP_YA

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_Tax_Computation(ByVal TC_REF_NO As String, ByVal TC_YA As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM [TAX_COMPUTATION] WHERE TC_REF_NO=@TC_REF_NO AND TC_YA=@TC_YA"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@TC_REF_NO", SqlDbType.NVarChar, 20).Value = TC_REF_NO
            SQLcmd.Parameters.Add("@TC_YA", SqlDbType.NVarChar, 5).Value = TC_YA

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function

#End Region
#Region "OTHER"
    Public Function CheckExist_DeemedInterest(ByVal YA As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT COUNT(*) AS COUNTX FROM DEEMED_INTEREST_RATE WHERE YA=@YA"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = YA

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("countx")) = False AndAlso dt.Rows(0)("countx") > 0 Then
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
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function

    Public Function LoadDeemedInterest_Rate(ByVal YA As Integer, Optional ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM DEEMED_INTEREST_RATE WHERE YA=@YA"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = YA

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_MovementComplex(ByVal ID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM MOVEMENT_COMPLEX WHERE MM_ID=@ID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_MovementComplex_Add(ByVal ID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM MOVEMENT_COMPLEX_ADD WHERE MM_PARENTID=@ID ORDER BY MM_Sequence"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_MovementComplex_Deduct(ByVal ID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM MOVEMENT_COMPLEX_DEDUCT WHERE MM_PARENTID=@ID ORDER BY MM_Sequence"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_MovementComplex_Search(ByVal RefNo As String, ByVal YA As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM MOVEMENT_COMPLEX"
            Dim isWhere As Boolean = False
            SQLcmd = New SqlCommand

            If RefNo IsNot Nothing AndAlso RefNo <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE MM_REFNO=@MM_REFNO"
                Else
                    StrSQL += " AND MM_REFNO=@MM_REFNO"
                End If
                SQLcmd.Parameters.Add("@MM_REFNO", SqlDbType.NVarChar, 20).Value = RefNo
            End If

            If YA IsNot Nothing AndAlso YA <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE MM_YA=@MM_YA"
                Else
                    StrSQL += " AND MM_YA=@MM_YA"
                End If
                SQLcmd.Parameters.Add("@MM_YA", SqlDbType.NVarChar, 5).Value = YA
            End If

            SQLcmd.CommandText = StrSQL
            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function CheckExist_MovementComplex(ByVal MM_REFNO As String, ByVal MM_YA As String, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT COUNT(*) AS COUNTX FROM MOVEMENT_COMPLEX WHERE MM_REFNO=@MM_REFNO AND MM_YA=@MM_YA"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@MM_REFNO", SqlDbType.NVarChar, 20).Value = MM_REFNO
            SQLcmd.Parameters.Add("@MM_YA", SqlDbType.NVarChar, 5).Value = MM_YA

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("countx")) = False AndAlso dt.Rows(0)("countx") > 0 Then
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
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function Load_MovementNormal_Search(ByVal RefNo As String, ByVal YA As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM MOVEMENT_NORMAL"
            Dim isWhere As Boolean = False
            SQLcmd = New SqlCommand

            If RefNo IsNot Nothing AndAlso RefNo <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE MM_REFNO=@MM_REFNO"
                Else
                    StrSQL += " AND MM_REFNO=@MM_REFNO"
                End If
                SQLcmd.Parameters.Add("@MM_REFNO", SqlDbType.NVarChar, 20).Value = RefNo
            End If

            If YA IsNot Nothing AndAlso YA <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE MM_YA=@MM_YA"
                Else
                    StrSQL += " AND MM_YA=@MM_YA"
                End If
                SQLcmd.Parameters.Add("@MM_YA", SqlDbType.NVarChar, 5).Value = YA
            End If

            SQLcmd.CommandText = StrSQL
            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function CheckExist_MovementNormal(ByVal MM_REFNO As String, ByVal MM_YA As String, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT COUNT(*) AS COUNTX FROM MOVEMENT_NORMAL WHERE MM_REFNO=@MM_REFNO AND MM_YA=@MM_YA"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@MM_REFNO", SqlDbType.NVarChar, 20).Value = MM_REFNO
            SQLcmd.Parameters.Add("@MM_YA", SqlDbType.NVarChar, 5).Value = MM_YA

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("countx")) = False AndAlso dt.Rows(0)("countx") > 0 Then
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
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function Load_MovementNormal(ByVal ID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM MOVEMENT_NORMAL WHERE MM_ID=@ID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_MovementNormal_Add(ByVal ID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM MOVEMENT_ADD WHERE MM_PARENTID=@ID ORDER BY MM_Sequence"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_MovementNormal_Deduct(ByVal ID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM MOVEMENT_DEDUCT WHERE MM_PARENTID=@ID ORDER BY MM_Sequence"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_SQLCmd(ByVal SQLCmd As SqlCommand, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            SQLCmd.Connection = SqlCon

            Return ADO.GetSQLDataTable(SQLCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_SQLCmd(ByVal SQLCmd As SqlCommand, ByVal SQLCon As SqlConnection, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()

            SQLCmd.Connection = SqlCon

            Return ADO.GetSQLDataTable(SQLCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Run_SQLCmd(ByVal SQLCmd As SqlCommand, ByVal SQLCon As SqlConnection, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()

            SQLCmd.Connection = SQLCon

            Return ADO.ExecuteSQLCmd_NOIDReturn(SQLCmd, SQLCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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

    Public Function GetListofTable(ByVal SQLCon As SqlConnection, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        If ErrorLog Is Nothing Then
            ErrorLog = New clsError
        End If
        Try
            ADO = New SQLDataObject()
            Dim SQLcmd As SqlCommand

            Dim StrSQL As String = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.CommandTimeout = 0

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SQLCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            If ErrorLog IsNot Nothing Then
                With ErrorLog
                    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                    .ErrorCode = ex.GetHashCode.ToString
                    .ErrorDateTime = Now
                    .ErrorMessage = ex.Message
                End With
            End If

            Return Nothing
        End Try
    End Function
    Public Function GetListofColumn(ByVal TableName As String, ByVal SQLCon As SqlConnection, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        If ErrorLog Is Nothing Then
            ErrorLog = New clsError
        End If
        Try
            ADO = New SQLDataObject()
            Dim SQLcmd As SqlCommand

            Dim StrSQL As String = "SELECT * FROM INFORMATION_SCHEMA.COLUMNS " 'WHERE TABLE_NAME = N'" & TableName & "'"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.CommandTimeout = 0

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SQLCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            If ErrorLog IsNot Nothing Then
                With ErrorLog
                    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                    .ErrorCode = ex.GetHashCode.ToString
                    .ErrorDateTime = Now
                    .ErrorMessage = ex.Message
                End With
            End If

            Return Nothing
        End Try
    End Function
    Public Function Load_rptLampiranA1_AiNonTaxableIncome(ByVal DetailsName As String, ByVal PL_KEY As Integer, Optional ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = Nothing
            SQLcmd = New SqlCommand
            Select Case DetailsName.ToLower
                Case "profit on disposal of fixed assets - 1"
                    StrSQL = "SELECT * FROM [INCOME_NTDISPOSALFA] WHERE [NTIDFA_KEY]=@NTIDFA_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NTIDFA_KEY", SqlDbType.Int).Value = PL_KEY
                Case "profit on disposal of fixed assets - 2"
                    StrSQL = "SELECT * FROM [INCOME_NTDISPOSALFA_DETAIL] WHERE [NTIDFAD_KEY]=@NTIDFAD_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NTIDFAD_KEY", SqlDbType.Int).Value = PL_KEY

                Case "profit on disposal of investment - 1"
                    StrSQL = "SELECT * FROM [INCOME_NTDISPOSALINVEST] WHERE [NTIDI_KEY]=@NTIDI_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NTIDI_KEY", SqlDbType.Int).Value = PL_KEY
                Case "profit on disposal of investment - 2"
                    StrSQL = "SELECT * FROM [INCOME_NTDISPOSALINVEST_DETAIL] WHERE [NTIDID_KEY]=@NTIDID_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NTIDID_KEY", SqlDbType.Int).Value = PL_KEY

                Case "foreign income remittance - 1"
                    StrSQL = "SELECT * FROM [INCOME_NTFOREIGNINCREM] WHERE [NTIFIR_KEY]=@NTIFIR_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NTIFIR_KEY", SqlDbType.Int).Value = PL_KEY
                Case "foreign income remittance - 2"
                    StrSQL = "SELECT * FROM [INCOME_NTFOREIGNINCREM_DETAIL] WHERE [NTIFIRD_KEY]=@NTIFIRD_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NTIFIRD_KEY", SqlDbType.Int).Value = PL_KEY

                Case "realised foregin exchange gain arising from capital transaction - 1"
                    StrSQL = "SELECT * FROM [INCOME_NTREALFE] WHERE [NTIRFECT_KEY]=@NTIRFECT_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NTIRFECT_KEY", SqlDbType.Int).Value = PL_KEY
                Case "realised foregin exchange gain arising from capital transaction - 2"
                    StrSQL = "SELECT * FROM [INCOME_NTREALFE_DETAIL] WHERE [NTIRFECTD_KEY]=@NTIRFECTD_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NTIRFECTD_KEY", SqlDbType.Int).Value = PL_KEY

                Case "unrealised gain on foreign exchange - trade - 1"
                    StrSQL = "SELECT * FROM [INCOME_NTUREALFET] WHERE [NTIUT_KEY]=@NTIUT_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NTIUT_KEY", SqlDbType.Int).Value = PL_KEY
                Case "unrealised gain on foreign exchange - trade - 2"
                    StrSQL = "SELECT * FROM [INCOME_NTUREALFET_DETAIL] WHERE [NTIUTD_KEY]=@NTIUTD_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NTIUTD_KEY", SqlDbType.Int).Value = PL_KEY

                Case "unrealised gain on foreign exchange - non trade - 1"
                    StrSQL = "SELECT * FROM [INCOME_NTUREALFENT] WHERE [NTIUNT_KEY]=@NTIUNT_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NTIUNT_KEY", SqlDbType.Int).Value = PL_KEY
                Case "unrealised gain on foreign exchange - non trade - 2"
                    StrSQL = "SELECT * FROM [INCOME_NTUREALFENT_DETAIL] WHERE [NTIUNTD_KEY]=@NTIUNTD_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NTIUNTD_KEY", SqlDbType.Int).Value = PL_KEY

                Case "others - 1"
                    StrSQL = "SELECT * FROM [NON_TAXABLE_INCOME] WHERE NT_KEY=@NT_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NT_KEY", SqlDbType.Int).Value = PL_KEY
                Case "others - 2"
                    StrSQL = "SELECT * FROM [NON_TAXABLE_INCOME_DETAIL] WHERE [NTD_KEY]=@NTD_KEY AND [NT_CATEGORIZED] = 'Other' ORDER BY [NT_KEY]"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NTD_KEY", SqlDbType.Int).Value = PL_KEY

            End Select

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_rptLampiranA1_AdjustedIncome(ByVal DetailsName As String, ByVal PL_KEY As Integer, Optional ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = Nothing
            SQLcmd = New SqlCommand
            Select Case DetailsName.ToLower
                Case "production cost - depreciation - 1"
                    StrSQL = "SELECT * FROM [EXPENSES_DEPRECIATION] WHERE [EXDEP_KEY]=@EXDEP_KEY AND [EXDEP_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXDEP_KEY", SqlDbType.Int).Value = PL_KEY
                Case "production cost - depreciation - 2"
                    StrSQL = "SELECT * FROM [EXPENSES_DEPRECIATION_DETAIL] WHERE [EXDEPD_KEY]=@EXDEPD_KEY AND [EXDEPD_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXDEPD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "production cost - other non allowable expenses - 1"
                    StrSQL = "SELECT * FROM [EXPENSES_NONALLOW] WHERE [EXNA_KEY]=@EXNA_KEY AND [EXNA_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXNA_KEY", SqlDbType.Int).Value = PL_KEY
                Case "production cost - other non allowable expenses - 2"
                    StrSQL = "SELECT * FROM [EXPENSES_NONALLOW_DETAIL] WHERE [EXNAD_KEY]=@EXNAD_KEY AND [EXNAD_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXNAD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: other interest - 1"
                    StrSQL = "SELECT * FROM [EXPENSES_INTEREST] WHERE [EXI_KEY]=@EXI_KEY AND [EXI_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXI_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: other interest - 2"
                    StrSQL = "SELECT * FROM [EXPENSES_INTEREST_DETAIL] WHERE [EXID_KEY]=@EXID_KEY AND [EXID_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXID_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: professional, technical, managament & legal fees - 1"
                    StrSQL = "SELECT * FROM [EXPENSES_LEGAL] WHERE [EXL_KEY]=@EXL_KEY AND [EXL_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXL_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: professional, technical, managament & legal fees - 2"
                    StrSQL = "SELECT * FROM [EXPENSES_LEGAL_DETAIL] WHERE [EXLD_KEY]=@EXLD_KEY AND [EXLD_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXLD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: contract payment - 1"
                    StrSQL = "SELECT * FROM [EXPENSES_CONTRACT] WHERE [EXC_KEY]=@EXC_KEY AND [EXC_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXC_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: contract payment - 2"
                    StrSQL = "SELECT * FROM [EXPENSES_CONTRACT_DETAIL] WHERE [EXCD_KEY]=@EXCD_KEY AND [EXCD_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXCD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: salary - 1"
                    StrSQL = "SELECT * FROM [EXPENSES_SALARY] WHERE [EXS_KEY]=@EXS_KEY AND [EXS_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXS_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: salary - 2"
                    StrSQL = "SELECT * FROM [EXPENSES_SALARY_DETAIL] WHERE [EXSD_KEY]=@EXSD_KEY AND [EXSD_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXSD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: royalty - 1"
                    StrSQL = "SELECT * FROM [EXPENSES_ROYALTY] WHERE [EXRO_KEY]=@EXRO_KEY AND [EXRO_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXRO_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: royalty - 2"
                    StrSQL = "SELECT * FROM [EXPENSES_ROYALTY_DETAIL] WHERE [EXROD_KEY]=@EXROD_KEY AND [EXROD_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXROD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: rental - 1"
                    StrSQL = "SELECT * FROM [EXPENSES_RENTAL] WHERE [EXRENT_KEY]=@EXRENT_KEY AND [EXRENT_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXRENT_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: rental - 2"
                    StrSQL = "SELECT * FROM [EXPENSES_RENTAL_DETAIL] WHERE [EXRENTD_KEY]=@EXRENTD_KEY AND [EXRENTD_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXRENTD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: repair & maintenance - 1"
                    StrSQL = "SELECT * FROM [EXPENSES_REPAIR] WHERE [EXREP_KEY]=@EXREP_KEY AND [EXREP_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXREP_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: repair & maintenance - 2"
                    StrSQL = "SELECT * FROM [EXPENSES_REPAIR_DETAIL] WHERE [EXREPD_KEY]=@EXREPD_KEY AND [EXREPD_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXREPD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: research & development - 1"
                    StrSQL = "SELECT * FROM [EXPENSES_RESEARCH] WHERE [EXRES_KEY]=@EXRES_KEY AND [EXRES_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXRES_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: research & development - 2"
                    StrSQL = "SELECT * FROM [EXPENSES_RESEARCH_DETAIL] WHERE [EXRESD_KEY]=@EXRESD_KEY AND [EXRESD_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXRESD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: promotion & advertisement - 1"
                    StrSQL = "SELECT * FROM [EXPENSES_PROMOTE] WHERE [EXP_KEY]=@EXP_KEY AND [EXP_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXP_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: promotion & advertisement - 2"
                    StrSQL = "SELECT * FROM [EXPENSES_PROMOTE_DETAIL] WHERE [EXPD_KEY]=@EXPD_KEY AND [EXPD_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXPD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: travelling and accommodation - 1"
                    StrSQL = "SELECT * FROM [EXPENSES_TRAVEL] WHERE [EXT_KEY]=@EXT_KEY AND [EXT_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXT_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: travelling and accommodation - 2"
                    StrSQL = "SELECT * FROM [EXPENSES_TRAVEL_DETAIL] WHERE [EXTD_KEY]=@EXTD_KEY AND [EXTD_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXTD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: depreciation - 1"
                    StrSQL = "SELECT * FROM [OTHER_EXDEPRECIATION] WHERE [EXODEP_KEY]=@EXODEP_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXODEP_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: depreciation - 2"
                    StrSQL = "SELECT * FROM [OTHER_EXDEPRECIATION_DETAIL] WHERE [EXODEPD_KEY]=@EXODEPD_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXODEPD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: donation - approved - 1"
                    StrSQL = "SELECT * FROM [OTHER_EXAPPRDONATION] WHERE [EXOAD_KEY]=@EXOAD_KEY" '& " AND [EXOAD_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOAD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: donation - approved - 2"
                    StrSQL = "SELECT * FROM [OTHER_EXAPPRDONATION_DETAIL] WHERE [EXOADD_KEY]=@EXOADD_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOADD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: donation - non approved - 1"
                    StrSQL = "SELECT * FROM [OTHER_EXNAPPRDONATION] WHERE [EXONAD_KEY]=@EXONAD_KEY AND [EXONAD_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXONAD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: donation - non approved - 2"
                    StrSQL = "SELECT * FROM [OTHER_EXNAPPRDONATION_DETAIL] WHERE [EXONADD_KEY]=@EXONADD_KEY AND [EXONADD_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXONADD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: zakat - 1"
                    StrSQL = "SELECT * FROM [OTHER_EXZAKAT] WHERE [EXOZ_KEY]=@EXOZ_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOZ_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: zakat - 2"
                    StrSQL = "SELECT * FROM [OTHER_EXZAKAT_DETAIL] WHERE [EXOZD_KEY]=@EXOZD_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOZD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: entertainment - non staff - 1"
                    StrSQL = "SELECT * FROM [OTHER_ENTERTAINNSTAFF] WHERE [EXOENS_KEY]=@EXOENS_KEY AND [EXOENS_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOENS_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: entertainment - non staff - 2"
                    StrSQL = "SELECT * FROM [OTHER_ENTERTAINNSTAFF_DETAIL] WHERE [EXOENSD_KEY]=@EXOENSD_KEY AND [EXOENSD_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOENSD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: entertainment - staff - 1"
                    StrSQL = "SELECT * FROM [OTHER_ENTERTAINSTAFF] WHERE [EXOES_KEY]=@EXOES_KEY AND [EXOES_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOES_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: entertainment - staff - 2"
                    StrSQL = "SELECT * FROM [OTHER_ENTERTAINSTAFF_DETAIL] WHERE [EXOESD_KEY]=@EXOESD_KEY AND [EXOESD_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOESD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: compound/penalty - 1"
                    StrSQL = "SELECT * FROM [OTHER_EXPENALTY] WHERE [EXOP_KEY]=@EXOP_KEY AND [EXOP_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOP_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: compound/penalty - 2"
                    StrSQL = "SELECT * FROM [OTHER_EXPENALTY_DETAIL] WHERE [EXOPD_KEY]=@EXOPD_KEY AND [EXOPD_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOPD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: provision account - 1"
                    StrSQL = "SELECT * FROM [OTHER_EXPROVISIONACC] WHERE [EXOPA_KEY]=@EXOPA_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOPA_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: provision account - 2"
                    StrSQL = "SELECT * FROM [OTHER_EXPROVISIONACC_DETAIL] WHERE [EXOPAD_KEY]=@EXOPAD_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOPAD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: leave passage - 1"
                    StrSQL = "SELECT * FROM [OTHER_EXLEAVEPASSAGE] WHERE [EXOLP_KEY]=@EXOLP_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOLP_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: leave passage - 2"
                    StrSQL = "SELECT * FROM [OTHER_EXLEAVEPASSAGE_DETAIL] WHERE [EXOLPD_KEY]=@EXOLPD_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOLPD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: fixed asset written off - 1"
                    StrSQL = "SELECT * FROM [OTHER_EXFAWRITTENOFF] WHERE [EXOWO_KEY]=@EXOWO_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOWO_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: fixed asset written off - 2"
                    StrSQL = "SELECT * FROM [OTHER_EXFAWRITTENOFF_DETAIL] WHERE [EXOWOD_KEY]=@EXOWOD_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOWOD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: initial subscription - 1"
                    StrSQL = "SELECT * FROM [OTHER_EXINITIALSUB] WHERE [EXOIS_KEY]=@EXOIS_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOIS_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: initial subscription - 2"
                    StrSQL = "SELECT * FROM [OTHER_EXINITIALSUB_DETAIL] WHERE [EXOISD_KEY]=@EXOISD_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOISD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: capital expenditure - 1"
                    StrSQL = "SELECT * FROM [OTHER_EXCAPITALEXP] WHERE [EXOCE_KEY]=@EXOCE_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOCE_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: capital expenditure - 2"
                    StrSQL = "SELECT * FROM [OTHER_EXCAPITALEXP_DETAIL] WHERE [EXOCED_KEY]=@EXOCED_KEY"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOCED_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: others - 1"
                    StrSQL = "SELECT * FROM [OTHER_EXPENSES] WHERE [EXO_KEY]=@EXO_KEY AND [EXO_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXO_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: others - 2"
                    StrSQL = "SELECT * FROM [OTHER_EXPENSES_DETAIL] WHERE [EXOD_KEY]=@EXOD_KEY AND [EXOD_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: technical fee payments to non-resident recipients - 1"
                    StrSQL = "SELECT * FROM [EXPENSES_TECH_FEE] WHERE [EXTF_KEY]=@EXTF_KEY AND [EXTF_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXTF_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: technical fee payments to non-resident recipients - 2"
                    StrSQL = "SELECT * FROM [EXPENSES_TECH_FEE_DETAIL] WHERE [EXTFD_KEY]=@EXTFD_KEY AND [EXTFD_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXTFD_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: cost of employee stock options - 1"
                    StrSQL = "SELECT * FROM [EXPENSES_EMPL_STOCK] WHERE [EXES_KEY]=@EXES_KEY AND [EXES_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXES_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: cost of employee stock options - 2"
                    StrSQL = "SELECT * FROM [EXPENSES_EMPLSTOCK_DETAIL] WHERE [EXESD_KEY]=@EXESD_KEY AND [EXESD_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXESD_KEY", SqlDbType.Int).Value = PL_KEY

                Case "purchase - 1"
                    StrSQL = "SELECT * FROM [PLFST_PURCHASE] WHERE [PLFPUR_KEY]=@PLFPUR_KEY AND [PLFPUR_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@PLFPUR_KEY", SqlDbType.Int).Value = PL_KEY
                Case "purchase - 2"
                    StrSQL = "SELECT * FROM [PLFST_PURCHASE_DETAIL] WHERE [PLFPURD_KEY]=@PLFPURD_KEY AND [PLFPURD_DEDUCTIBLE] = 'No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@PLFPURD_KEY", SqlDbType.Int).Value = PL_KEY

                Case "other expenses: realised loss on foreign exchange - trade - 1"
                    StrSQL = "SELECT * FROM [OTHER_EXRLOSSFOREIGNT] WHERE [EXORT_KEY]=@EXORT_KEY AND [EXORT_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXORT_KEY", SqlDbType.Int).Value = PL_KEY
                Case "other expenses: realised loss on foreign exchange - trade - 2"
                    StrSQL = "SELECT * FROM [OTHER_EXRLOSSFOREIGNT_DETAIL] WHERE [EXORTD_KEY]=@EXORTD_KEY AND [EXORTD_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXORTD_KEY", SqlDbType.Int).Value = PL_KEY

                Case "expenses: director's fee - 1"
                    StrSQL = "SELECT * FROM [EXPENSES_DIRECTORS_FEE] WHERE [EXDF_KEY]=@EXDF_KEY AND [EXDF_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXDF_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: director's fee - 2"
                    StrSQL = "SELECT * FROM [EXPENSES_DIRECTORS_FEE_DETAIL] WHERE [EXDFD_KEY]=@EXDFD_KEY AND [EXDFD_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXDFD_KEY", SqlDbType.Int).Value = PL_KEY

                Case "expenses: input tax not claimable from jkdm - 1"
                    StrSQL = "SELECT * FROM [EXPENSES_JKDM] WHERE [EXJK_KEY]=@EXJK_KEY AND [EXJK_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXJK_KEY", SqlDbType.Int).Value = PL_KEY
                Case "expenses: input tax not claimable from jkdm - 2"
                    StrSQL = "SELECT * FROM [EXPENSES_JKDM_DETAIL] WHERE [EXJKD_KEY]=@EXJKD_KEY AND [EXJKD_DEDUCTIBLE] ='No'"
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXJKD_KEY", SqlDbType.Int).Value = PL_KEY

            End Select

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try

    End Function
    Public Function Load_rptLampiranA1_BusinessSource(ByVal BC_KEY As String, ByVal BC_YA As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT BS.BC_KEY, BS.BC_YA, BS.BC_SOURCENO FROM BUSINESS_SOURCE BS, TAX_COMPUTATION TC WHERE BS.BC_KEY = TC.TC_REF_NO AND BS.BC_YA = TC.TC_YA AND BS.BC_SOURCENO = TC.TC_BUSINESS AND BS.BC_KEY = @BC_KEY And BC_YA = @BC_YA"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@BC_KEY", SqlDbType.NVarChar, 20).Value = BC_KEY
            SQLcmd.Parameters.Add("@BC_YA", SqlDbType.NVarChar, 5).Value = BC_YA

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function LoadSourceNo(ByVal RefNo As String, ByVal YA As String, Optional ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT BC_SOURCENO FROM BUSINESS_SOURCE WHERE BC_KEY=@RefNo and BC_YA=@YA ORDER BY BC_SOURCENO"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.NVarChar, 5).Value = YA

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function LoadYA(Optional ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM YEAR_ASSESSMENT ORDER BY YA DESC"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function CheckYA_Exist(ByVal YA As Integer, Optional ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return True
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT COUNT(*) as countx FROM YEAR_ASSESSMENT WHERE YA=@YA"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@YA", SqlDbType.NVarChar, 5).Value = CStr(YA)

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("countx")) = False AndAlso dt.Rows(0)("countx") > 0 Then
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
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function LoadState(Optional ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM STATES ORDER BY ST_DESC"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function LoadTaxPayer(Optional ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM TAXP_PROFILE ORDER BY TP_COM_NAME"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function LoadTaxPayer_CompanyName(ByVal TP_REF_NO As String, Optional ErrorLog As clsError = Nothing) As String
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return ""
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT TP_COM_NAME FROM TAXP_PROFILE WHERE TP_REF_NO=@TP_REF_NO"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@TP_REF_NO", SqlDbType.NVarChar, 20).Value = TP_REF_NO

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso IsDBNull(dt.Rows(0)("TP_COM_NAME")) = False Then
                Return dt.Rows(0)("TP_COM_NAME")
            Else
                Return ""
            End If
        Catch ex As Exception
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
            Return ""
        End Try
    End Function
    Public Function LoadTaxPayer_ByRefNO(ByVal REF_NO As String, Optional ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM TAXP_PROFILE WHERE TP_REF_NO=@TP_REF_NO"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@TP_REF_NO", SqlDbType.NVarChar, 20).Value = REF_NO

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function

    Public Function Load_DatabaseList(Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM master.dbo.sysdatabases"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL

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

    Public Function Load_UserNote(Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM USER_NOTE WHERE PCName=@PCName"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PCName", SqlDbType.NVarChar, 250).Value = My.Computer.Name

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

#End Region
#Region "CP204"
    Public Function Load_CP204_BreakDown_ByParentID(ByVal ID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM BORANG_CP204_TRICOR_BREAKDOWN WHERE CP_PARENTID=@CP_PARENTID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@CP_PARENTID", SqlDbType.Int).Value = ID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_CP204_ByID(ByVal ID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM BORANG_CP204 WHERE BCP_KEY=@BCP_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@BCP_KEY", SqlDbType.Int).Value = ID

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function

    Public Function GETCP204KEY(Optional ByRef ErrorLog As clsError = Nothing) As Integer
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return -1
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select top 1 BCP_KEY from BORANG_CP204 order by BCP_KEY desc"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("BCP_KEY")) = False Then
                Return CInt(dt.Rows(0)("BCP_KEY"))
            Else
                Return -1
            End If
        Catch ex As Exception
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
            Return -1
        End Try
    End Function
    Public Function Load_CP204(ByVal Refno As String, ByVal YA As String, Optional ByVal Type As String = "CP204", Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM BORANG_CP204 WHERE BCP_REF_NO=@BCP_REF_NO AND BCP_YA=@BCP_YA AND BCP_FORM=@BCP_FORM"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@BCP_REF_NO", SqlDbType.NVarChar, 20).Value = Refno
            SQLcmd.Parameters.Add("@BCP_YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@BCP_FORM", SqlDbType.NVarChar, 10).Value = Type

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
    Public Function Load_CP204_LastYAChecking(ByVal Refno As String, Optional ByVal Type As String = "CP204A", Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM BORANG_CP204 WHERE BCP_REF_NO=@BCP_REF_NO AND BCP_FORM=@BCP_FORM ORDER BY BCP_YA DESC"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@BCP_REF_NO", SqlDbType.NVarChar, 20).Value = Refno
            SQLcmd.Parameters.Add("@BCP_FORM", SqlDbType.NVarChar, 10).Value = Type

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
Public Function Load_CP204_Search(ByVal RefNo As String, ByVal YA As String, ByVal Month As Integer, _
                                      Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM BORANG_CP204"
            Dim isWhere As Boolean = False
            SQLcmd = New SqlCommand

            If RefNo IsNot Nothing AndAlso RefNo <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE BCP_REF_NO=@BCP_REF_NO"
                Else
                    StrSQL += " AND BCP_REF_NO=@BCP_REF_NO"
                End If
                SQLcmd.Parameters.Add("@BCP_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
            End If

            If YA IsNot Nothing AndAlso YA <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE BCP_YA=@BCP_YA"
                Else
                    StrSQL += " AND BCP_YA=@BCP_YA"
                End If
                SQLcmd.Parameters.Add("@BCP_YA", SqlDbType.NVarChar, 5).Value = YA
            End If

            If Month > -1 Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE BCP_TO_MONTH=@BCP_TO_MONTH"
                Else
                    StrSQL += " AND BCP_TO_MONTH=@BCP_TO_MONTH"
                End If
                SQLcmd.Parameters.Add("@BCP_TO_MONTH", SqlDbType.Int).Value = Month
            End If

            SQLcmd.CommandText = StrSQL
            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
#End Region
#Region "TABLE OF CONTENT"

    Public Function Load_TableofContent_Search(ByVal RefNo As String, ByVal YA As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM TABLE_CONTENT"
            Dim isWhere As Boolean = False
            SQLcmd = New SqlCommand

            If RefNo IsNot Nothing AndAlso RefNo <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE TBL_REFNO=@TBL_REFNO"
                Else
                    StrSQL += " AND TBL_REFNO=@TBL_REFNO"
                End If
                SQLcmd.Parameters.Add("@TBL_REFNO", SqlDbType.NVarChar, 20).Value = RefNo
            End If

            If YA IsNot Nothing AndAlso YA <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE TBL_YA=@TBL_YA"
                Else
                    StrSQL += " AND TBL_YA=@TBL_YA"
                End If
                SQLcmd.Parameters.Add("@TBL_YA", SqlDbType.NVarChar, 5).Value = YA
            End If

            SQLcmd.CommandText = StrSQL


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
    Public Function CheckExist_TableofContent(ByVal RefNo As String, ByVal YA As String, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT COUNT(*) AS COUNTX FROM TABLE_CONTENT WHERE TBL_REFNO=@TBL_REFNO AND TBL_YA=@TBL_YA"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@TBL_REFNO", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@TBL_YA", SqlDbType.NVarChar, 5).Value = YA

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("COUNTX")) = False AndAlso dt.Rows(0)("COUNTX") > 0 Then
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
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function

    Public Function Load_TableofContent_Default(Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM TABLE_CONTENT_DEFAULT ORDER BY TBL_TITLE"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL

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

    Public Function Load_TableofContent_ByID(ByVal ID As Decimal, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM TABLE_CONTENT WHERE TBL_ID=@TBL_ID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@TBL_ID", SqlDbType.Decimal).Value = ID

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

    Public Function Load_TableofContent_List_ByParentID(ByVal ID As Decimal, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM TABLE_CONTENT_LIST WHERE TBL_PARENTID=@TBL_PARENTID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@TBL_PARENTID", SqlDbType.Decimal).Value = ID

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

#End Region
#End Region
#Region "SAVE"
#Region "CA"
    Public Function Save_Disposal(ByVal CA_KEY As Integer, ByVal CA_DISP_KEY As Integer, ByVal CA_DISP_YA As Integer, _
                                  ByVal CA_DISP_DATE As DateTime, ByVal CA_DISP_WITHIN_2 As Boolean, _
                                  ByVal CA_DISP_AMOUNT As Decimal, ByVal CA_DISP_QC As Decimal, ByVal CA_DISP_BALANCE As Decimal, _
                                  ByVal CA_DISP_TWDV As Decimal, ByVal CA_DISP_SPROCEED As Decimal, _
                                  ByVal CA_DISP_BABC As Decimal, ByVal CA_DISP_REMARKS As String, ByVal CA_ACCUMULATED As Decimal, _
                                  ByVal CA_TRANSFEREE_NAME As String, ByVal CA_TAX_FILE_NO As String, ByVal CA_DISP_TYPE As Integer, _
                                  ByRef ReturnID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "INSERT INTO CA_DISPOSAL (CA_KEY,CA_DISP_KEY,CA_DISP_YA,CA_DISP_DATE,CA_DISP_WITHIN_2,CA_DISP_AMOUNT,CA_DISP_QC,CA_DISP_BALANCE,CA_DISP_TWDV,CA_DISP_SPROCEED,CA_DISP_BABC,CA_DISP_REMARKS,CA_ACCUMULATED,CA_TRANSFEREE_NAME,CA_TAX_FILE_NO,CA_DISP_TYPE) VALUES (@CA_KEY,@CA_DISP_KEY,@CA_DISP_YA,@CA_DISP_DATE,@CA_DISP_WITHIN_2,@CA_DISP_AMOUNT,@CA_DISP_QC,@CA_DISP_BALANCE,@CA_DISP_TWDV,@CA_DISP_SPROCEED,@CA_DISP_BABC,@CA_DISP_REMARKS,@CA_ACCUMULATED,@CA_TRANSFEREE_NAME,@CA_TAX_FILE_NO,@CA_DISP_TYPE)"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@CA_KEY", SqlDbType.Int).Value = CA_KEY
            SQLcmd.Parameters.Add("@CA_DISP_KEY", SqlDbType.Int).Value = CA_DISP_KEY
            SQLcmd.Parameters.Add("@CA_DISP_YA", SqlDbType.NVarChar, 5).Value = CA_DISP_YA
            SQLcmd.Parameters.Add("@CA_DISP_DATE", SqlDbType.DateTime).Value = CA_DISP_DATE
            SQLcmd.Parameters.Add("@CA_DISP_WITHIN_2", SqlDbType.NVarChar, 3).Value = CA_DISP_WITHIN_2
            SQLcmd.Parameters.Add("@CA_DISP_AMOUNT", SqlDbType.NVarChar, 25).Value = CA_DISP_AMOUNT
            SQLcmd.Parameters.Add("@CA_DISP_QC", SqlDbType.NVarChar, 25).Value = CA_DISP_QC
            SQLcmd.Parameters.Add("@CA_DISP_BALANCE", SqlDbType.NVarChar, 25).Value = CA_DISP_BALANCE
            SQLcmd.Parameters.Add("@CA_DISP_TWDV", SqlDbType.NVarChar, 25).Value = CA_DISP_TWDV
            SQLcmd.Parameters.Add("@CA_DISP_SPROCEED", SqlDbType.NVarChar, 25).Value = CA_DISP_SPROCEED
            SQLcmd.Parameters.Add("@CA_DISP_BABC", SqlDbType.NVarChar, 25).Value = CA_DISP_BABC
            SQLcmd.Parameters.Add("@CA_DISP_REMARKS", SqlDbType.NVarChar, 255).Value = IIf(CA_DISP_REMARKS Is Nothing, "", CA_DISP_REMARKS)
            SQLcmd.Parameters.Add("@CA_ACCUMULATED", SqlDbType.NVarChar, 25).Value = CA_ACCUMULATED
            SQLcmd.Parameters.Add("@CA_TRANSFEREE_NAME", SqlDbType.NVarChar, 255).Value = IIf(CA_TRANSFEREE_NAME Is Nothing, "", CA_TRANSFEREE_NAME)
            SQLcmd.Parameters.Add("@CA_TAX_FILE_NO", SqlDbType.NVarChar, 255).Value = IIf(CA_TAX_FILE_NO Is Nothing, "", CA_TAX_FILE_NO)
            SQLcmd.Parameters.Add("@CA_DISP_TYPE", SqlDbType.Int).Value = CA_DISP_TYPE

            Dim rlst As Boolean = ADO.ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If rlst = True Then
                ReturnID = CA_DISP_KEY
            End If

            Return rlst
        Catch ex As Exception
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
    Public Function Save_HP(ByVal HP_PREFIX As String, ByVal HP_REF_NO As String, ByVal HP_NAME As String, ByVal HP_FILENO As String, _
                            ByVal HP_YA As String, ByVal HP_COMPANY_CODE As String, ByVal HP_SOURCENO As Integer, ByVal HP_ASSET_CODE As String, _
                            ByVal HP_ASSET As String, ByVal HP_CATEGORY_CODE As String, ByVal HP_PURCHASE_DATE As DateTime, ByVal HP_PURCHASE_AMOUNT As Decimal, _
                            ByVal HP_PAYMENT As Decimal, ByVal HP_RESTRICTED_QC As Decimal, ByVal HP_DESC As String, ByVal HP_CODE As String, _
                            ByVal HP_PRINCIPAL As Decimal, ByVal HP_INTEREST_RATE As Decimal, ByVal HP_INTEREST As Decimal, ByVal HP_TOTAL As Decimal, _
                            ByVal HP_NO_INST As Integer, ByVal HP_FIRST_INST As DateTime, ByVal HP_DECIMAL As Integer, ByVal HP_SCHE_METHOD As String, _
                            ByVal HP_TYPE_SCHE As Integer, _
                            ByVal ds As DataSet, ByRef ReturnID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "INSERT INTO HP (HP_PREFIX,HP_REF_NO,HP_NAME,HP_FILENO,HP_YA,HP_COMPANY_CODE,HP_SOURCENO,HP_ASSET_CODE,"
            StrSQL += "HP_ASSET,HP_CATEGORY_CODE,HP_PURCHASE_DATE,HP_PURCHASE_AMOUNT,HP_PAYMENT,HP_RESTRICTED_QC,HP_DESC,HP_CODE,"
            StrSQL += "HP_PRINCIPAL,HP_INTEREST_RATE,HP_INTEREST,HP_TOTAL,HP_NO_INST,HP_FIRST_INST,HP_DECIMAL,HP_SCHE_METHOD,HP_TYPE_SCHE) VALUES ("

            StrSQL += "@HP_PREFIX,@HP_REF_NO,@HP_NAME,@HP_FILENO,@HP_YA,@HP_COMPANY_CODE,@HP_SOURCENO,@HP_ASSET_CODE,"
            StrSQL += "@HP_ASSET,@HP_CATEGORY_CODE,@HP_PURCHASE_DATE,@HP_PURCHASE_AMOUNT,@HP_PAYMENT,@HP_RESTRICTED_QC,@HP_DESC,@HP_CODE,"
            StrSQL += "@HP_PRINCIPAL,@HP_INTEREST_RATE,@HP_INTEREST,@HP_TOTAL,@HP_NO_INST,@HP_FIRST_INST,@HP_DECIMAL,@HP_SCHE_METHOD,@HP_TYPE_SCHE)"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@HP_PREFIX", SqlDbType.NVarChar, 3).Value = HP_PREFIX
            SQLcmd.Parameters.Add("@HP_REF_NO", SqlDbType.NVarChar, 20).Value = HP_REF_NO
            SQLcmd.Parameters.Add("@HP_NAME", SqlDbType.NVarChar, 255).Value = HP_NAME
            SQLcmd.Parameters.Add("@HP_FILENO", SqlDbType.NVarChar, 20).Value = HP_FILENO
            SQLcmd.Parameters.Add("@HP_YA", SqlDbType.NVarChar, 5).Value = HP_YA
            SQLcmd.Parameters.Add("@HP_COMPANY_CODE", SqlDbType.NVarChar, 8).Value = HP_COMPANY_CODE
            SQLcmd.Parameters.Add("@HP_SOURCENO", SqlDbType.Int).Value = HP_SOURCENO
            SQLcmd.Parameters.Add("@HP_ASSET_CODE", SqlDbType.NVarChar, 20).Value = HP_ASSET_CODE
            SQLcmd.Parameters.Add("@HP_ASSET", SqlDbType.NVarChar, 255).Value = HP_ASSET
            SQLcmd.Parameters.Add("@HP_CATEGORY_CODE", SqlDbType.NVarChar, 20).Value = HP_CATEGORY_CODE
            SQLcmd.Parameters.Add("@HP_PURCHASE_DATE", SqlDbType.DateTime).Value = HP_PURCHASE_DATE
            SQLcmd.Parameters.Add("@HP_PURCHASE_AMOUNT", SqlDbType.NVarChar, 25).Value = HP_PURCHASE_AMOUNT
            SQLcmd.Parameters.Add("@HP_PAYMENT", SqlDbType.NVarChar, 25).Value = HP_PAYMENT
            SQLcmd.Parameters.Add("@HP_RESTRICTED_QC", SqlDbType.NVarChar, 25).Value = HP_RESTRICTED_QC
            SQLcmd.Parameters.Add("@HP_DESC", SqlDbType.NVarChar, 255).Value = HP_DESC
            SQLcmd.Parameters.Add("@HP_CODE", SqlDbType.NVarChar, 255).Value = HP_CODE
            SQLcmd.Parameters.Add("@HP_PRINCIPAL", SqlDbType.NVarChar, 25).Value = HP_PRINCIPAL
            SQLcmd.Parameters.Add("@HP_INTEREST_RATE", SqlDbType.NVarChar, 25).Value = HP_INTEREST_RATE
            SQLcmd.Parameters.Add("@HP_INTEREST", SqlDbType.NVarChar, 25).Value = HP_INTEREST
            SQLcmd.Parameters.Add("@HP_TOTAL", SqlDbType.NVarChar, 25).Value = HP_TOTAL
            SQLcmd.Parameters.Add("@HP_NO_INST", SqlDbType.Int).Value = HP_NO_INST
            SQLcmd.Parameters.Add("@HP_FIRST_INST", SqlDbType.DateTime).Value = HP_FIRST_INST
            SQLcmd.Parameters.Add("@HP_DECIMAL", SqlDbType.Int).Value = HP_DECIMAL
            SQLcmd.Parameters.Add("@HP_SCHE_METHOD", SqlDbType.NVarChar, 50).Value = HP_SCHE_METHOD
            SQLcmd.Parameters.Add("@HP_TYPE_SCHE", SqlDbType.Int).Value = HP_TYPE_SCHE

            Dim rlst As Boolean = ADO.ExecuteSQLCmd(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog, ReturnID)

            If rlst = False Then
                Return False
            Else
                Dim ListofCmd As New List(Of SqlCommand)

                If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                    Return False
                End If

                If HP_TYPE_SCHE = 0 Then
                    'Yearly
                    StrSQL = "DELETE FROM HP_YEARLY WHERE HPD_KEY=@HPD_KEY"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@HPD_KEY", SqlDbType.Int).Value = ReturnID
                    ListofCmd.Add(SQLcmd)

                    For i As Integer = 0 To ds.Tables("HP_YEARLY").Rows.Count - 1

                        StrSQL = "INSERT INTO HP_YEARLY(HPD_KEY,HPD_YA,HPD_PRINCIPAL,HPD_INTEREST,HPD_TOTAL,HPD_NOTE_TITLE1,HPD_NOTE_TITLE2) VALUES (@HPD_KEY,@HPD_YA,@HPD_PRINCIPAL,@HPD_INTEREST,@HPD_TOTAL,@HPD_NOTE_TITLE1,@HPD_NOTE_TITLE2)"


                        SQLcmd = New SqlCommand
                        SQLcmd.CommandText = StrSQL
                        SQLcmd.Parameters.Add("@HPD_KEY", SqlDbType.Int).Value = ReturnID
                        SQLcmd.Parameters.Add("@HPD_YA", SqlDbType.NVarChar, 5).Value = ds.Tables("HP_YEARLY").Rows(i)("HPD_YA")
                        SQLcmd.Parameters.Add("@HPD_PRINCIPAL", SqlDbType.NVarChar, 25).Value = ds.Tables("HP_YEARLY").Rows(i)("HPD_PRINCIPAL")
                        SQLcmd.Parameters.Add("@HPD_INTEREST", SqlDbType.NVarChar, 25).Value = ds.Tables("HP_YEARLY").Rows(i)("HPD_INTEREST")
                        SQLcmd.Parameters.Add("@HPD_TOTAL", SqlDbType.NVarChar, 25).Value = ds.Tables("HP_YEARLY").Rows(i)("HPD_TOTAL")
                        SQLcmd.Parameters.Add("@HPD_NOTE_TITLE1", SqlDbType.NVarChar, 50).Value = ds.Tables("HP_YEARLY").Rows(i)("HPD_NOTE_TITLE1")
                        SQLcmd.Parameters.Add("@HPD_NOTE_TITLE2", SqlDbType.NVarChar, 50).Value = ds.Tables("HP_YEARLY").Rows(i)("HPD_NOTE_TITLE2")


                        ListofCmd.Add(SQLcmd)
                    Next
                Else
                    'Installment
                    StrSQL = "DELETE FROM HP_INSTALLMENT WHERE HP_KEY=@HP_KEY"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@HP_KEY", SqlDbType.Int).Value = ReturnID
                    ListofCmd.Add(SQLcmd)

                    For i As Integer = 0 To ds.Tables("HP_INSTALLMENT").Rows.Count - 1

                        StrSQL = "INSERT INTO HP_INSTALLMENT(HP_KEY,HPD_KEY,HPD_PRINCIPAL,HPD_INTEREST,HPD_TOTAL,HPD_PAY_DUE_DATE,HPD_PAYMENT_PRINCIPAL,HPD_PAYMENT_INTEREST,HPD_PAYMENT_DATE,HPD_YA) VALUES (@HP_KEY,@HPD_KEY,@HPD_PRINCIPAL,@HPD_INTEREST,@HPD_TOTAL,@HPD_PAY_DUE_DATE,@HPD_PAYMENT_PRINCIPAL,@HPD_PAYMENT_INTEREST,@HPD_PAYMENT_DATE,@HPD_YA)"


                        SQLcmd = New SqlCommand
                        SQLcmd.CommandText = StrSQL
                        SQLcmd.Parameters.Add("@HP_KEY", SqlDbType.Int).Value = ReturnID
                        SQLcmd.Parameters.Add("@HPD_KEY", SqlDbType.Int).Value = ds.Tables("HP_INSTALLMENT").Rows(i)("HPD_KEY")
                        SQLcmd.Parameters.Add("@HPD_PRINCIPAL", SqlDbType.NVarChar, 25).Value = ds.Tables("HP_INSTALLMENT").Rows(i)("HPD_PRINCIPAL")
                        SQLcmd.Parameters.Add("@HPD_INTEREST", SqlDbType.NVarChar, 25).Value = ds.Tables("HP_INSTALLMENT").Rows(i)("HPD_INTEREST")
                        SQLcmd.Parameters.Add("@HPD_TOTAL", SqlDbType.NVarChar, 25).Value = ds.Tables("HP_INSTALLMENT").Rows(i)("HPD_TOTAL")
                        SQLcmd.Parameters.Add("@HPD_PAY_DUE_DATE", SqlDbType.DateTime).Value = ds.Tables("HP_INSTALLMENT").Rows(i)("HPD_PAY_DUE_DATE")
                        SQLcmd.Parameters.Add("@HPD_PAYMENT_PRINCIPAL", SqlDbType.NVarChar, 25).Value = ds.Tables("HP_INSTALLMENT").Rows(i)("HPD_PAYMENT_PRINCIPAL")
                        SQLcmd.Parameters.Add("@HPD_PAYMENT_INTEREST", SqlDbType.NVarChar, 25).Value = ds.Tables("HP_INSTALLMENT").Rows(i)("HPD_PAYMENT_INTEREST")
                        SQLcmd.Parameters.Add("@HPD_PAYMENT_DATE", SqlDbType.DateTime).Value = ds.Tables("HP_INSTALLMENT").Rows(i)("HPD_PAYMENT_DATE")
                        SQLcmd.Parameters.Add("@HPD_YA", SqlDbType.NVarChar, 5).Value = ds.Tables("HP_INSTALLMENT").Rows(i)("HPD_YA")

                        ListofCmd.Add(SQLcmd)
                    Next

                End If

                Return ADO.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
            End If
        Catch ex As Exception
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
    Public Function Duplicate_CA(ByVal ListofCA_KEY As List(Of Integer), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim dt As DataTable = Nothing
            Dim ReturnID As Decimal = 0
            For i As Integer = 0 To ListofCA_KEY.Count - 1

                dt = mdlProcess.Load_CA(ListofCA_KEY(i))

                If dt IsNot Nothing Then

                    mdlProcess.Save_CA(IIf(IsDBNull(dt.Rows(0)("CA_REF_NO")), "", dt.Rows(0)("CA_REF_NO")), IIf(IsDBNull(dt.Rows(0)("CA_NAME")), "", dt.Rows(0)("CA_NAME")), _
                                       IIf(IsDBNull(dt.Rows(0)("CA_FILENO")), "", dt.Rows(0)("CA_FILENO")), IIf(IsDBNull(dt.Rows(0)("CA_YA")), "", dt.Rows(0)("CA_YA")), _
                                       IIf(IsDBNull(dt.Rows(0)("CA_COMPANY_CODE")), "", dt.Rows(0)("CA_COMPANY_CODE")), IIf(IsDBNull(dt.Rows(0)("CA_SOURCENO")), 0, dt.Rows(0)("CA_SOURCENO")), _
                                       IIf(IsDBNull(dt.Rows(0)("CA_MODE")), "ADD", dt.Rows(0)("CA_MODE")), IIf(IsDBNull(dt.Rows(0)("CA_ASSET_CODE")), "", dt.Rows(0)("CA_ASSET_CODE")), _
                                       IIf(IsDBNull(dt.Rows(0)("CA_ASSET")), "", dt.Rows(0)("CA_ASSET")), IIf(IsDBNull(dt.Rows(0)("CA_CATEGORY_CODE")), "", dt.Rows(0)("CA_CATEGORY_CODE")), _
                                       IIf(IsDBNull(dt.Rows(0)("CA_PURCHASE_DATE")), Now, dt.Rows(0)("CA_PURCHASE_DATE")), IIf(IsDBNull(dt.Rows(0)("CA_PURCHASE_YEAR")), "", dt.Rows(0)("CA_PURCHASE_YEAR")), _
                                       IIf(IsDBNull(dt.Rows(0)("CA_PURCHASE_AMOUNT")), 0, dt.Rows(0)("CA_PURCHASE_AMOUNT")), IIf(IsDBNull(dt.Rows(0)("CA_PAYMENT")), 0, dt.Rows(0)("CA_PAYMENT")), _
                                       IIf(IsDBNull(dt.Rows(0)("CA_RESTRICTED_QC")), 0, dt.Rows(0)("CA_RESTRICTED_QC")), IIf(IsDBNull(dt.Rows(0)("CA_DESC")), "", dt.Rows(0)("CA_DESC")), _
                                       IIf(IsDBNull(dt.Rows(0)("CA_RATE_IA")), 0, dt.Rows(0)("CA_RATE_IA")), IIf(IsDBNull(dt.Rows(0)("CA_RATE_AA")), 0, dt.Rows(0)("CA_RATE_AA")), _
                                       IIf(IsDBNull(dt.Rows(0)("CA_QUALIFYING_COST")), 0, dt.Rows(0)("CA_QUALIFYING_COST")), IIf(IsDBNull(dt.Rows(0)("CA_REMAIN_QC")), 0, dt.Rows(0)("CA_REMAIN_QC")), _
                                       IIf(IsDBNull(dt.Rows(0)("CA_TWDV")), 0, dt.Rows(0)("CA_TWDV")), IIf(IsDBNull(dt.Rows(0)("CA_INCENTIVE")), "", dt.Rows(0)("CA_INCENTIVE")), _
                                       IIf(IsDBNull(dt.Rows(0)("CA_CTRL_TRANSFER")), 0, dt.Rows(0)("CA_CTRL_TRANSFER")), IIf(IsDBNull(dt.Rows(0)("HP_CODE")), "", dt.Rows(0)("HP_CODE")), _
                                       IIf(IsDBNull(dt.Rows(0)("CA_ACCELERATED")), "", dt.Rows(0)("CA_ACCELERATED")), IIf(IsDBNull(dt.Rows(0)("CA_CAEEO")), False, dt.Rows(0)("CA_CAEEO")), _
                                       IIf(IsDBNull(dt.Rows(0)("CA_REC")), False, dt.Rows(0)("CA_REC")), IIf(IsDBNull(dt.Rows(0)("CA_DEFERREDCLAIM")), False, dt.Rows(0)("CA_DEFERREDCLAIM")), _
                                       IIf(IsDBNull(dt.Rows(0)("CA_DEDUCTADJ_INCOME")), False, dt.Rows(0)("CA_DEDUCTADJ_INCOME")), IIf(IsDBNull(dt.Rows(0)("CA_TAX_FILE_NUMBER")), "", dt.Rows(0)("CA_TAX_FILE_NUMBER")), _
                                       IIf(IsDBNull(dt.Rows(0)("CA_TRANSFERROR_NAME")), "", dt.Rows(0)("CA_TRANSFERROR_NAME")), IIf(IsDBNull(dt.Rows(0)("CA_TRANSFER_VAL")), "", dt.Rows(0)("CA_TRANSFER_VAL")), ReturnID, ErrorLog)

                End If

            Next

            Return True
        Catch ex As Exception
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
    Public Function Save_CA(ByVal CA_REF_NO As String, ByVal CA_NAME As String, ByVal CA_FILENO As String, ByVal CA_YA As String, ByVal CA_COMPANY_CODE As String, ByVal CA_SOURCENO As Decimal, _
                         ByVal CA_MODE As String, ByVal CA_ASSET_CODE As String, ByVal CA_ASSET As String, ByVal CA_CATEGORY_CODE As String, _
                         ByVal CA_PURCHASE_DATE As DateTime, ByVal CA_PURCHASE_YEAR As String, ByVal CA_PURCHASE_AMOUNT As Decimal, _
                         ByVal CA_PAYMENT As Decimal, ByVal CA_RESTRICTED_QC As Decimal, ByVal CA_DESC As String, _
                         ByVal CA_RATE_IA As Integer, ByVal CA_RATE_AA As Integer, ByVal CA_QUALIFYING_COST As Decimal, _
                         ByVal CA_REMAIN_QC As Decimal, ByVal CA_TWDV As Decimal, ByVal CA_INCENTIVE As String, _
                         ByVal CA_CTRL_TRANSFER As Integer, ByVal HP_CODE As String, ByVal CA_ACCELERATED As String, _
                         ByVal CA_CAEEO As Boolean, ByVal CA_REC As Boolean, ByVal CA_DEFERREDCLAIM As Boolean, ByVal CA_DEDUCTADJ_INCOME As Boolean, _
                         ByVal CA_TAX_FILE_NUMBER As String, ByVal CA_TRANSFERROR_NAME As String, ByVal CA_TRANSFER_VAL As String, _
                         ByRef ReturnID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "INSERT INTO CA (CA_MODE,CA_PREFIX,CA_REF_NO,CA_NAME,CA_FILENO,CA_YA,CA_COMPANY_CODE,CA_SOURCENO,"
            StrSQL += "CA_ASSET_CODE,CA_ASSET,CA_CATEGORY_CODE,CA_PURCHASE_DATE,CA_PURCHASE_YEAR,CA_PURCHASE_AMOUNT,CA_PAYMENT,CA_RESTRICTED_QC,"
            StrSQL += "CA_DESC,CA_RATE_IA,CA_RATE_AA,CA_QUALIFYING_COST,CA_REMAIN_QC,CA_TWDV,CA_INCENTIVE,CA_CTRL_TRANSFER,HP_CODE,CA_ACCELERATED,"
            StrSQL += "CA_CAEEO,CA_REC,CA_DEFERREDCLAIM,CA_DEDUCTADJ_INCOME,CA_TAX_FILE_NUMBER,CA_TRANSFERROR_NAME,CA_TRANSFER_VAL) VALUES ("

            StrSQL += "@CA_MODE,@CA_PREFIX,@CA_REF_NO,@CA_NAME,@CA_FILENO,@CA_YA,@CA_COMPANY_CODE,@CA_SOURCENO,"
            StrSQL += "@CA_ASSET_CODE,@CA_ASSET,@CA_CATEGORY_CODE,@CA_PURCHASE_DATE,@CA_PURCHASE_YEAR,@CA_PURCHASE_AMOUNT,@CA_PAYMENT,@CA_RESTRICTED_QC,"
            StrSQL += "@CA_DESC,@CA_RATE_IA,@CA_RATE_AA,@CA_QUALIFYING_COST,@CA_REMAIN_QC,@CA_TWDV,@CA_INCENTIVE,@CA_CTRL_TRANSFER,@HP_CODE,@CA_ACCELERATED,"
            StrSQL += "@CA_CAEEO,@CA_REC,@CA_DEFERREDCLAIM,@CA_DEDUCTADJ_INCOME,@CA_TAX_FILE_NUMBER,@CA_TRANSFERROR_NAME,@CA_TRANSFER_VAL)"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@CA_MODE", SqlDbType.NVarChar, 3).Value = CA_MODE
            SQLcmd.Parameters.Add("@CA_PREFIX", SqlDbType.NVarChar, 3).Value = "C"
            SQLcmd.Parameters.Add("@CA_REF_NO", SqlDbType.NVarChar, 20).Value = CA_REF_NO
            SQLcmd.Parameters.Add("@CA_NAME", SqlDbType.NVarChar, 255).Value = CA_NAME
            SQLcmd.Parameters.Add("@CA_FILENO", SqlDbType.NVarChar, 20).Value = CA_FILENO
            SQLcmd.Parameters.Add("@CA_YA", SqlDbType.NVarChar, 5).Value = CA_YA
            SQLcmd.Parameters.Add("@CA_COMPANY_CODE", SqlDbType.NVarChar, 8).Value = CA_COMPANY_CODE
            SQLcmd.Parameters.Add("@CA_SOURCENO", SqlDbType.Decimal).Value = CA_SOURCENO
            SQLcmd.Parameters.Add("@CA_ASSET_CODE", SqlDbType.NVarChar, 20).Value = IIf(CA_ASSET_CODE Is Nothing, "", CA_ASSET_CODE)
            SQLcmd.Parameters.Add("@CA_ASSET", SqlDbType.NVarChar, 255).Value = IIf(CA_ASSET Is Nothing, "", CA_ASSET)
            SQLcmd.Parameters.Add("@CA_CATEGORY_CODE", SqlDbType.NVarChar, 20).Value = CA_CATEGORY_CODE
            SQLcmd.Parameters.Add("@CA_PURCHASE_DATE", SqlDbType.DateTime).Value = CA_PURCHASE_DATE
            SQLcmd.Parameters.Add("@CA_PURCHASE_YEAR", SqlDbType.NVarChar, 5).Value = CA_PURCHASE_YEAR
            SQLcmd.Parameters.Add("@CA_PURCHASE_AMOUNT", SqlDbType.NVarChar, 25).Value = CStr(CA_PURCHASE_AMOUNT)
            SQLcmd.Parameters.Add("@CA_PAYMENT", SqlDbType.NVarChar, 25).Value = CStr(CA_PAYMENT)
            SQLcmd.Parameters.Add("@CA_RESTRICTED_QC", SqlDbType.NVarChar, 25).Value = CStr(CA_RESTRICTED_QC)
            SQLcmd.Parameters.Add("@CA_DESC", SqlDbType.NVarChar, 255).Value = IIf(CA_DESC Is Nothing, "", CA_DESC)
            SQLcmd.Parameters.Add("@CA_RATE_IA", SqlDbType.Float).Value = CA_RATE_IA
            SQLcmd.Parameters.Add("@CA_RATE_AA", SqlDbType.Float).Value = CA_RATE_AA
            SQLcmd.Parameters.Add("@CA_QUALIFYING_COST", SqlDbType.NVarChar, 25).Value = CStr(CA_QUALIFYING_COST)
            SQLcmd.Parameters.Add("@CA_REMAIN_QC", SqlDbType.NVarChar, 25).Value = CStr(CA_REMAIN_QC)
            SQLcmd.Parameters.Add("@CA_TWDV", SqlDbType.NVarChar, 25).Value = CStr(CA_TWDV)
            SQLcmd.Parameters.Add("@CA_INCENTIVE", SqlDbType.NVarChar, 3).Value = IIf(CA_DESC Is Nothing, "", CA_DESC)
            SQLcmd.Parameters.Add("@CA_CTRL_TRANSFER", SqlDbType.Int).Value = CA_CTRL_TRANSFER
            SQLcmd.Parameters.Add("@HP_CODE", SqlDbType.NVarChar, 255).Value = IIf(HP_CODE Is Nothing, "", HP_CODE)
            SQLcmd.Parameters.Add("@CA_ACCELERATED", SqlDbType.NVarChar, 20).Value = CA_ACCELERATED
            '//New Column Update
            SQLcmd.Parameters.Add("@CA_CAEEO", SqlDbType.Bit).Value = CA_CAEEO
            SQLcmd.Parameters.Add("@CA_REC", SqlDbType.Bit).Value = CA_REC
            SQLcmd.Parameters.Add("@CA_DEFERREDCLAIM", SqlDbType.Bit).Value = CA_DEFERREDCLAIM
            SQLcmd.Parameters.Add("@CA_DEDUCTADJ_INCOME", SqlDbType.Bit).Value = CA_DEDUCTADJ_INCOME
            SQLcmd.Parameters.Add("@CA_TAX_FILE_NUMBER", SqlDbType.NVarChar, 255).Value = IIf(CA_TAX_FILE_NUMBER Is Nothing, "", CA_TAX_FILE_NUMBER)
            SQLcmd.Parameters.Add("@CA_TRANSFERROR_NAME", SqlDbType.NVarChar, 255).Value = IIf(CA_TRANSFERROR_NAME Is Nothing, "", CA_TRANSFERROR_NAME)
            SQLcmd.Parameters.Add("@CA_TRANSFER_VAL", SqlDbType.NVarChar, 25).Value = IIf(CA_TRANSFER_VAL Is Nothing, "", CA_TRANSFER_VAL)

            Return ADO.ExecuteSQLCmd(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog, ReturnID)
        Catch ex As Exception
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
    Public Function Save_CA_TEMP_REPORT(ByVal RefNo As String, ByVal YA As Integer, ByVal CA_KEY As Integer, ByVal CA_NAME As String, _
                                        ByVal CA_ASSET As String, ByVal CA_CATEGORY_CODE As String, ByVal CA_SOURCENO As Integer, _
                                        ByVal CA_YA As Integer, ByVal HP_CODE As String, _
                                        ByVal CA_MODE As String, ByVal CA_TRANSFERROR_NAME As String, _
                                        ByVal CA_PURCHASE_YEAR As Integer, ByVal CA_QUALIFYING_COST As Decimal, _
                                        ByVal CA_RATE_IA As Integer, ByVal CA_RATE_AA As Integer, ByVal QC_BF As Decimal, _
                                        ByVal QC_ADD As Decimal, ByVal QC_DISP As Decimal, ByVal QC_CF As Decimal, _
                                        ByVal TWDV_BF As Decimal, ByVal TWDV_ADD As Decimal, ByVal TWDV_DISP As Decimal, _
                                        ByVal TWDV_AI As Decimal, ByVal TWDV_AA As Decimal, ByVal TWDV_TOTAL As Decimal, ByVal TWDV_CF As Decimal, _
                                        ByVal IndexNo As Integer, ByVal Type As mdlEnum.CAReport_TableType, ByRef ID As String, _
                                        Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = ""

            Select Case Type
                Case CAReport_TableType.CA_REPORT_TEMP
                    'CA_REPORT_TEMP
                    StrSQL = "INSERT INTO CA_REPORT_TEMP (ID,RefNo,YA,CA_KEY,CA_NAME,CA_SOURCENO,CA_YA,HP_CODE,CA_ASSET,CA_CATEGORY_CODE,CA_MODE,CA_TRANSFERROR_NAME,CA_PURCHASE_YEAR,CA_QUALIFYING_COST,CA_RATE_IA,CA_RATE_AA,QC_BF,QC_ADD,QC_DISP,QC_CF,TWDV_BF,TWDV_ADD,TWDV_DISP,TWDV_AI,TWDV_AA,TWDV_TOTAL,TWDV_CF,IndexNo) VALUES (@ID,@RefNo,@YA,@CA_KEY,@CA_NAME,@CA_SOURCENO,@CA_YA,@HP_CODE,@CA_ASSET,@CA_CATEGORY_CODE,@CA_MODE,@CA_TRANSFERROR_NAME,@CA_PURCHASE_YEAR,@CA_QUALIFYING_COST,@CA_RATE_IA,@CA_RATE_AA,@QC_BF,@QC_ADD,@QC_DISP,@QC_CF,@TWDV_BF,@TWDV_ADD,@TWDV_DISP,@TWDV_AI,@TWDV_AA,@TWDV_TOTAL,@TWDV_CF,@IndexNo)"
                Case CAReport_TableType.CA_REPORT_SUMMARY_TEMP
                    'CA_REPORT_SUMMARY_TEMP
                    StrSQL = "INSERT INTO CA_REPORT_SUMMARY_TEMP (ID,RefNo,YA,CA_KEY,CA_NAME,CA_SOURCENO,CA_YA,HP_CODE,CA_ASSET,CA_CATEGORY_CODE,CA_MODE,CA_TRANSFERROR_NAME,CA_PURCHASE_YEAR,CA_QUALIFYING_COST,CA_RATE_IA,CA_RATE_AA,QC_BF,QC_ADD,QC_DISP,QC_CF,TWDV_BF,TWDV_ADD,TWDV_DISP,TWDV_AI,TWDV_AA,TWDV_TOTAL,TWDV_CF,IndexNo) VALUES (@ID,@RefNo,@YA,@CA_KEY,@CA_NAME,@CA_SOURCENO,@CA_YA,@HP_CODE,@CA_ASSET,@CA_CATEGORY_CODE,@CA_MODE,@CA_TRANSFERROR_NAME,@CA_PURCHASE_YEAR,@CA_QUALIFYING_COST,@CA_RATE_IA,@CA_RATE_AA,@QC_BF,@QC_ADD,@QC_DISP,@QC_CF,@TWDV_BF,@TWDV_ADD,@TWDV_DISP,@TWDV_AI,@TWDV_AA,@TWDV_TOTAL,@TWDV_CF,@IndexNo)"
            End Select

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.NVarChar, 50).Value = ID
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = YA
            SQLcmd.Parameters.Add("@CA_KEY", SqlDbType.Int).Value = CA_KEY
            SQLcmd.Parameters.Add("@CA_NAME", SqlDbType.NVarChar, 255).Value = CA_NAME
            SQLcmd.Parameters.Add("@CA_SOURCENO", SqlDbType.Int).Value = CA_SOURCENO
            SQLcmd.Parameters.Add("@CA_YA", SqlDbType.Int).Value = CA_YA
            SQLcmd.Parameters.Add("@HP_CODE", SqlDbType.NVarChar, 255).Value = HP_CODE
            SQLcmd.Parameters.Add("@CA_ASSET", SqlDbType.NVarChar, 255).Value = CA_ASSET
            SQLcmd.Parameters.Add("@CA_CATEGORY_CODE", SqlDbType.NVarChar, 20).Value = CA_CATEGORY_CODE
            SQLcmd.Parameters.Add("@CA_MODE", SqlDbType.NVarChar, 3).Value = CA_MODE
            SQLcmd.Parameters.Add("@CA_TRANSFERROR_NAME", SqlDbType.NVarChar, 255).Value = CA_TRANSFERROR_NAME
            SQLcmd.Parameters.Add("@CA_PURCHASE_YEAR", SqlDbType.Int).Value = CA_PURCHASE_YEAR
            SQLcmd.Parameters.Add("@CA_QUALIFYING_COST", SqlDbType.Decimal).Value = CA_QUALIFYING_COST
            SQLcmd.Parameters.Add("@CA_RATE_IA", SqlDbType.Int).Value = CA_RATE_IA
            SQLcmd.Parameters.Add("@CA_RATE_AA", SqlDbType.Int).Value = CA_RATE_AA
            SQLcmd.Parameters.Add("@QC_BF", SqlDbType.Decimal).Value = QC_BF
            SQLcmd.Parameters.Add("@QC_ADD", SqlDbType.Decimal).Value = QC_ADD
            SQLcmd.Parameters.Add("@QC_DISP", SqlDbType.Decimal).Value = QC_DISP
            SQLcmd.Parameters.Add("@QC_CF", SqlDbType.Decimal).Value = QC_CF
            SQLcmd.Parameters.Add("@TWDV_BF", SqlDbType.Decimal).Value = TWDV_BF
            SQLcmd.Parameters.Add("@TWDV_ADD", SqlDbType.Decimal).Value = TWDV_ADD
            SQLcmd.Parameters.Add("@TWDV_DISP", SqlDbType.Decimal).Value = TWDV_DISP
            SQLcmd.Parameters.Add("@TWDV_AI", SqlDbType.Decimal).Value = TWDV_AI
            SQLcmd.Parameters.Add("@TWDV_AA", SqlDbType.Decimal).Value = TWDV_AA
            SQLcmd.Parameters.Add("@TWDV_TOTAL", SqlDbType.Decimal).Value = TWDV_TOTAL
            SQLcmd.Parameters.Add("@TWDV_CF", SqlDbType.Decimal).Value = TWDV_CF
            SQLcmd.Parameters.Add("@IndexNo", SqlDbType.Int).Value = IndexNo

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

            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function Save_CA_FAReconliliation_TEMP_REPORT(ByVal RefNo As String, ByVal YA As Integer, ByVal CA_KEY As Integer, _
                                                         ByVal CA_NAME As String, ByVal CA_ASSET As String, ByVal CA_ASSET_CODE As String, _
                                                         ByVal CA_CATEGORY_CODE As String, ByVal CA_SOURCENO As Integer, _
                                                         ByVal CA_YA As Integer, ByVal HP_CODE As String, _
                                                         ByVal CA_MODE As String, ByVal CA_PURCHASE_YEAR As Integer, _
                                                         ByVal CA_QUALIFYING_COST As Decimal, ByVal CA_PURCHASE_AMOUNT As Decimal, _
                                                         ByVal CA_RATE_IA As Integer, _
                                                         ByVal CA_RATE_AA As Integer, ByVal QC_BF As Decimal, _
                                                         ByVal QC_ADD As Decimal, ByVal QC_DISP As Decimal, ByVal QC_CF As Decimal, _
                                                         ByVal TWDV_BF As Decimal, ByVal TWDV_ADD As Decimal, ByVal TWDV_DISP As Decimal, _
                                                         ByVal TWDV_IA As Decimal, ByVal TWDV_AA As Decimal, ByVal TWDV_CF As Decimal, _
                                                         ByVal PC_BF As Decimal, ByVal PC_ADD As Decimal, ByVal PC_DISP As Decimal, _
                                                         ByVal PC_CF As Decimal, ByVal IndexNo As Integer, _
                                                         ByVal Type As mdlEnum.CAReport_TableType, _
                                                         ByRef ID As String, _
                                                         Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = ""

            Select Case Type
                Case CAReport_TableType.CA_REPORT_FIXEDASET_RECONCILIATION
                    'CA_REPORT_TEMP
                    StrSQL = "INSERT INTO CA_REPORT_FIXEDASSET_TEMP (ID,RefNo,YA,CA_KEY,CA_NAME,CA_SOURCENO,CA_YA,HP_CODE,CA_ASSET,CA_ASSET_CODE,CA_CATEGORY_CODE,CA_MODE,CA_PURCHASE_YEAR,CA_QUALIFYING_COST,CA_PURCHASE_AMOUNT,CA_RATE_IA,CA_RATE_AA,QC_BF,QC_ADD,QC_DISP,QC_CF,TWDV_BF,TWDV_ADD,TWDV_DISP,TWDV_AI,TWDV_AA,TWDV_CF,PC_BF,PC_ADD,PC_DISP,PC_CF,IndexNo) VALUES (@ID,@RefNo,@YA,@CA_KEY,@CA_NAME,@CA_SOURCENO,@CA_YA,@HP_CODE,@CA_ASSET,@CA_ASSET_CODE,@CA_CATEGORY_CODE,@CA_MODE,@CA_PURCHASE_YEAR,@CA_QUALIFYING_COST,@CA_PURCHASE_AMOUNT,@CA_RATE_IA,@CA_RATE_AA,@QC_BF,@QC_ADD,@QC_DISP,@QC_CF,@TWDV_BF,@TWDV_ADD,@TWDV_DISP,@TWDV_AI,@TWDV_AA,@TWDV_CF,@PC_BF,@PC_ADD,@PC_DISP,@PC_CF,@IndexNo)"
            End Select

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.NVarChar, 50).Value = ID
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = YA
            SQLcmd.Parameters.Add("@CA_KEY", SqlDbType.Int).Value = CA_KEY
            SQLcmd.Parameters.Add("@CA_NAME", SqlDbType.NVarChar, 255).Value = CA_NAME
            SQLcmd.Parameters.Add("@CA_SOURCENO", SqlDbType.Int).Value = CA_SOURCENO
            SQLcmd.Parameters.Add("@CA_YA", SqlDbType.Int).Value = CA_YA
            SQLcmd.Parameters.Add("@HP_CODE", SqlDbType.NVarChar, 255).Value = HP_CODE
            SQLcmd.Parameters.Add("@CA_ASSET", SqlDbType.NVarChar, 255).Value = CA_ASSET
            SQLcmd.Parameters.Add("@CA_ASSET_CODE", SqlDbType.NVarChar, 20).Value = CA_ASSET_CODE
            SQLcmd.Parameters.Add("@CA_CATEGORY_CODE", SqlDbType.NVarChar, 20).Value = CA_CATEGORY_CODE
            SQLcmd.Parameters.Add("@CA_MODE", SqlDbType.NVarChar, 3).Value = CA_MODE
            SQLcmd.Parameters.Add("@CA_PURCHASE_YEAR", SqlDbType.Int).Value = CA_PURCHASE_YEAR
            SQLcmd.Parameters.Add("@CA_QUALIFYING_COST", SqlDbType.Decimal).Value = CA_QUALIFYING_COST
            SQLcmd.Parameters.Add("@CA_PURCHASE_AMOUNT", SqlDbType.Decimal).Value = CA_PURCHASE_AMOUNT
            SQLcmd.Parameters.Add("@CA_RATE_IA", SqlDbType.Int).Value = CA_RATE_IA
            SQLcmd.Parameters.Add("@CA_RATE_AA", SqlDbType.Int).Value = CA_RATE_AA
            SQLcmd.Parameters.Add("@QC_BF", SqlDbType.Decimal).Value = QC_BF
            SQLcmd.Parameters.Add("@QC_ADD", SqlDbType.Decimal).Value = QC_ADD
            SQLcmd.Parameters.Add("@QC_DISP", SqlDbType.Decimal).Value = QC_DISP
            SQLcmd.Parameters.Add("@QC_CF", SqlDbType.Decimal).Value = QC_CF

            SQLcmd.Parameters.Add("@TWDV_BF", SqlDbType.Decimal).Value = TWDV_BF
            SQLcmd.Parameters.Add("@TWDV_ADD", SqlDbType.Decimal).Value = TWDV_ADD
            SQLcmd.Parameters.Add("@TWDV_DISP", SqlDbType.Decimal).Value = TWDV_CF
            SQLcmd.Parameters.Add("@TWDV_AI", SqlDbType.Decimal).Value = TWDV_IA
            SQLcmd.Parameters.Add("@TWDV_AA", SqlDbType.Decimal).Value = TWDV_AA
            SQLcmd.Parameters.Add("@TWDV_CF", SqlDbType.Decimal).Value = TWDV_CF

            SQLcmd.Parameters.Add("@PC_BF", SqlDbType.Decimal).Value = PC_BF
            SQLcmd.Parameters.Add("@PC_ADD", SqlDbType.Decimal).Value = PC_ADD
            SQLcmd.Parameters.Add("@PC_DISP", SqlDbType.Decimal).Value = PC_DISP
            SQLcmd.Parameters.Add("@PC_CF", SqlDbType.Decimal).Value = PC_CF
            SQLcmd.Parameters.Add("@IndexNo", SqlDbType.Int).Value = IndexNo

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

            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function Save_CA_ControlTranfer(ByVal ID As String, ByVal RefNo As String, ByVal YA As Integer, ByVal CA_KEY As Integer, ByVal CA_NAME As String, ByVal CA_SOURCENO As Integer, ByVal CA_YA As Integer, _
                                           ByVal HP_CODE As String, ByVal CA_ASSET As String, ByVal CA_CATEGORY_CODE As String, ByVal CA_PURCHASE_AMOUNT As Decimal, _
                                           ByVal CA_TRANSFERROR_NAME As String, ByVal CA_TRANSFER_VAL As Decimal, ByVal CA_PURCHASE_YEAR As Integer, ByVal CA_QUALIFYING_COST As Decimal, ByVal CA_RATE_IA As Integer, _
                                           ByVal CA_RATE_AA As Integer, ByVal CA_CAEEO As Boolean, ByVal QC_CF As Decimal, ByVal TWDV_BF As Decimal, ByVal AA_0 As Decimal, ByVal AA_2 As Decimal, ByVal AA_3 As Decimal, _
                                           ByVal AA_8 As Decimal, ByVal AA_10 As Decimal, ByVal AA_12 As Decimal, ByVal AA_14 As Decimal, ByVal AA_16 As Decimal, ByVal AA_20 As Decimal, ByVal AA_40 As Decimal, _
                                           ByVal AA_50 As Decimal, ByVal AA_60 As Decimal, ByVal AA_80 As Decimal, ByVal AA_90 As Decimal, ByVal AA_100 As Decimal, ByVal IndexNo As Integer, ByRef ReturnID As Integer, _
                                           Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "INSERT INTO CA_REPORT_CONTROLTRANSFER_TEMP (ID,RefNo,YA,CA_KEY,CA_NAME,CA_SOURCENO,CA_YA,HP_CODE,CA_ASSET,CA_CATEGORY_CODE,CA_PURCHASE_AMOUNT,CA_TRANSFERROR_NAME,CA_TRANSFER_VAL,CA_PURCHASE_YEAR,CA_QUALIFYING_COST,CA_RATE_IA,CA_RATE_AA,CA_CAEEO,QC_CF,TWDV_BF,AA_0,AA_2,AA_3,AA_8,AA_10,AA_12,AA_14,AA_16,AA_20,AA_40,AA_50,AA_60,AA_80,AA_90,AA_100,IndexNo)"
            StrSQL &= " VALUES (@ID,@RefNo,@YA,@CA_KEY,@CA_NAME,@CA_SOURCENO,@CA_YA,@HP_CODE,@CA_ASSET,@CA_CATEGORY_CODE,@CA_PURCHASE_AMOUNT,@CA_TRANSFERROR_NAME,@CA_TRANSFER_VAL,@CA_PURCHASE_YEAR,@CA_QUALIFYING_COST,@CA_RATE_IA,@CA_RATE_AA,@CA_CAEEO,@QC_CF,@TWDV_BF,@AA_0,@AA_2,@AA_3,@AA_8,@AA_10,@AA_12,@AA_14,@AA_16,@AA_20,@AA_40,@AA_50,@AA_60,@AA_80,@AA_90,@AA_100,@IndexNo)"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.NVarChar, 50).Value = ID
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = YA
            SQLcmd.Parameters.Add("@CA_KEY", SqlDbType.Int).Value = CA_KEY
            SQLcmd.Parameters.Add("@CA_NAME", SqlDbType.NVarChar, 255).Value = CA_NAME
            SQLcmd.Parameters.Add("@CA_SOURCENO", SqlDbType.Int).Value = CA_SOURCENO
            SQLcmd.Parameters.Add("@CA_YA", SqlDbType.Int).Value = CA_YA
            SQLcmd.Parameters.Add("@HP_CODE", SqlDbType.NVarChar, 255).Value = HP_CODE
            SQLcmd.Parameters.Add("@CA_ASSET", SqlDbType.NVarChar, 255).Value = CA_ASSET
            SQLcmd.Parameters.Add("@CA_CATEGORY_CODE", SqlDbType.NVarChar, 20).Value = CA_CATEGORY_CODE
            SQLcmd.Parameters.Add("@CA_PURCHASE_AMOUNT", SqlDbType.Decimal).Value = CA_PURCHASE_AMOUNT
            SQLcmd.Parameters.Add("@CA_TRANSFERROR_NAME", SqlDbType.NVarChar, 255).Value = CA_TRANSFERROR_NAME
            SQLcmd.Parameters.Add("@CA_TRANSFER_VAL", SqlDbType.Decimal).Value = CA_TRANSFER_VAL
            SQLcmd.Parameters.Add("@CA_PURCHASE_YEAR", SqlDbType.Int).Value = CA_PURCHASE_YEAR
            SQLcmd.Parameters.Add("@CA_QUALIFYING_COST", SqlDbType.Decimal).Value = CA_QUALIFYING_COST
            SQLcmd.Parameters.Add("@CA_RATE_IA", SqlDbType.Int).Value = CA_RATE_IA
            SQLcmd.Parameters.Add("@CA_RATE_AA", SqlDbType.Int).Value = CA_RATE_AA
            SQLcmd.Parameters.Add("@CA_CAEEO", SqlDbType.Bit).Value = CA_CAEEO
            SQLcmd.Parameters.Add("@QC_CF", SqlDbType.Decimal).Value = QC_CF
            SQLcmd.Parameters.Add("@TWDV_BF", SqlDbType.Decimal).Value = TWDV_BF
            SQLcmd.Parameters.Add("@AA_0", SqlDbType.Decimal).Value = AA_0
            SQLcmd.Parameters.Add("@AA_2", SqlDbType.Decimal).Value = AA_2
            SQLcmd.Parameters.Add("@AA_3", SqlDbType.Decimal).Value = AA_3
            SQLcmd.Parameters.Add("@AA_8", SqlDbType.Decimal).Value = AA_8
            SQLcmd.Parameters.Add("@AA_10", SqlDbType.Decimal).Value = AA_10
            SQLcmd.Parameters.Add("@AA_12", SqlDbType.Decimal).Value = AA_12
            SQLcmd.Parameters.Add("@AA_14", SqlDbType.Decimal).Value = AA_14
            SQLcmd.Parameters.Add("@AA_16", SqlDbType.Decimal).Value = AA_16
            SQLcmd.Parameters.Add("@AA_20", SqlDbType.Decimal).Value = AA_20
            SQLcmd.Parameters.Add("@AA_40", SqlDbType.Decimal).Value = AA_40
            SQLcmd.Parameters.Add("@AA_50", SqlDbType.Decimal).Value = AA_50
            SQLcmd.Parameters.Add("@AA_60", SqlDbType.Decimal).Value = AA_60
            SQLcmd.Parameters.Add("@AA_80", SqlDbType.Decimal).Value = AA_80
            SQLcmd.Parameters.Add("@AA_90", SqlDbType.Decimal).Value = AA_90
            SQLcmd.Parameters.Add("@AA_100", SqlDbType.Decimal).Value = AA_100
            SQLcmd.Parameters.Add("@IndexNo", SqlDbType.Int).Value = IndexNo

            Return ADO.ExecuteSQLCmd(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog, ReturnID)
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
    Public Function Save_Disposal_Report_TEMP(ByVal ID As String, ByVal RefNo As String, ByVal YA As Integer, ByVal CA_KEY As Integer, ByVal CA_NAME As String, _
                                              ByVal CA_SOURCENO As Integer, ByVal CA_YA As Integer, ByVal HP_CODE As String, ByVal CA_ASSET As String, _
                                              ByVal CA_CATEGORY_CODE As String, ByVal CA_MODE As String, ByVal CA_TRANSFERROR_NAME As String, _
                                              ByVal CA_PURCHASE_YEAR As Integer, ByVal CA_QUALIFYING_COST As Decimal, _
                                              ByVal CA_RATE_IA As Integer, ByVal CA_RATE_AA As Integer, ByVal CA_CAEEO As Boolean, _
                                              ByVal DISP_DEPRECIATION As Decimal, ByVal DISP_WDV As Decimal, ByVal DISP_DISPOSAL_VALUE As Decimal, _
                                              ByVal DISP_PNL As Decimal, ByVal DISP_TWDV As Decimal, ByVal DISP_BABC As Decimal, _
                                              ByVal Type As Integer, ByVal IndexNo As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "INSERT INTO CA_REPORT_DISPOSAL_TEMP (ID,RefNo,YA,CA_KEY,CA_NAME,CA_SOURCENO,CA_YA,HP_CODE,CA_ASSET,CA_CATEGORY_CODE,CA_MODE,CA_TRANSFERROR_NAME,CA_PURCHASE_YEAR,CA_QUALIFYING_COST,CA_RATE_IA,CA_RATE_AA,CA_CAEEO,DISP_DEPRECIATION,DISP_WDV,DISP_DISPOSAL_VALUE,DISP_PNL,DISP_TWDV,DISP_BABC,Type,IndexNo) VALUES "
            StrSQL += "(@ID,@RefNo,@YA,@CA_KEY,@CA_NAME,@CA_SOURCENO,@CA_YA,@HP_CODE,@CA_ASSET,@CA_CATEGORY_CODE,@CA_MODE,@CA_TRANSFERROR_NAME,@CA_PURCHASE_YEAR,@CA_QUALIFYING_COST,@CA_RATE_IA,@CA_RATE_AA,@CA_CAEEO,@DISP_DEPRECIATION,@DISP_WDV,@DISP_DISPOSAL_VALUE,@DISP_PNL,@DISP_TWDV,@DISP_BABC,@Type,@IndexNo)"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.NVarChar, 50).Value = ID
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = YA
            SQLcmd.Parameters.Add("@CA_KEY", SqlDbType.Int).Value = CA_KEY
            SQLcmd.Parameters.Add("@CA_NAME", SqlDbType.NVarChar, 255).Value = CA_NAME
            SQLcmd.Parameters.Add("@CA_SOURCENO", SqlDbType.Decimal).Value = CA_SOURCENO
            SQLcmd.Parameters.Add("@CA_YA", SqlDbType.Int).Value = CA_YA
            SQLcmd.Parameters.Add("@HP_CODE", SqlDbType.NVarChar, 255).Value = HP_CODE
            SQLcmd.Parameters.Add("@CA_ASSET", SqlDbType.NVarChar, 255).Value = CA_ASSET
            SQLcmd.Parameters.Add("@CA_CATEGORY_CODE", SqlDbType.NVarChar, 20).Value = CA_CATEGORY_CODE
            SQLcmd.Parameters.Add("@CA_MODE", SqlDbType.NVarChar, 3).Value = CA_MODE
            SQLcmd.Parameters.Add("@CA_TRANSFERROR_NAME", SqlDbType.NVarChar, 255).Value = CA_TRANSFERROR_NAME
            SQLcmd.Parameters.Add("@CA_PURCHASE_YEAR", SqlDbType.Int).Value = CA_PURCHASE_YEAR
            SQLcmd.Parameters.Add("@CA_QUALIFYING_COST", SqlDbType.Decimal).Value = CA_QUALIFYING_COST
            SQLcmd.Parameters.Add("@CA_RATE_IA", SqlDbType.Int).Value = CA_RATE_IA
            SQLcmd.Parameters.Add("@CA_RATE_AA", SqlDbType.Int).Value = CA_RATE_AA
            SQLcmd.Parameters.Add("@CA_CAEEO", SqlDbType.Bit).Value = CA_CAEEO
            SQLcmd.Parameters.Add("@DISP_DEPRECIATION", SqlDbType.Decimal).Value = DISP_DEPRECIATION
            SQLcmd.Parameters.Add("@DISP_WDV", SqlDbType.Decimal).Value = DISP_WDV
            SQLcmd.Parameters.Add("@DISP_DISPOSAL_VALUE", SqlDbType.Decimal).Value = DISP_DISPOSAL_VALUE
            SQLcmd.Parameters.Add("@DISP_PNL", SqlDbType.Decimal).Value = DISP_PNL
            SQLcmd.Parameters.Add("@DISP_TWDV", SqlDbType.Decimal).Value = DISP_TWDV
            SQLcmd.Parameters.Add("@DISP_BABC", SqlDbType.Decimal).Value = DISP_BABC
            SQLcmd.Parameters.Add("@Type", SqlDbType.Int).Value = Type
            SQLcmd.Parameters.Add("@IndexNo", SqlDbType.Int).Value = IndexNo

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

            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function

#End Region
#Region "PNL"

    Public Function Save_PNL_Report_TEMP(ByVal dt As DataTable, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = Nothing

            If dt Is Nothing Then
                Return False
            End If

            Dim ListofSQLCmd As New List(Of SqlCommand)
            For i As Integer = 0 To dt.Rows.Count - 1
                StrSQL = "INSERT INTO PROFIT_LOSS_ACCOUNT_REPORT_TEMP (ID_KEY,PARENT_ID,ID,RefNo,YA,IndexNo,Caption,LeftAmount,RightAmount,TypeRow,Note) VALUES (@ID_KEY,@PARENT_ID,@ID,@RefNo,@YA,@IndexNo,@Caption,@LeftAmount,@RightAmount,@TypeRow,@Note)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@ID_KEY", SqlDbType.Int).Value = dt.Rows(i)("ID_KEY")
                SQLcmd.Parameters.Add("@PARENT_ID", SqlDbType.Int).Value = dt.Rows(i)("PARENT_ID")
                SQLcmd.Parameters.Add("@ID", SqlDbType.NVarChar, 50).Value = dt.Rows(i)("ID")
                SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = dt.Rows(i)("RefNo")
                SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = dt.Rows(i)("YA")
                SQLcmd.Parameters.Add("@IndexNo", SqlDbType.Int).Value = dt.Rows(i)("IndexNo")
                SQLcmd.Parameters.Add("@Caption", SqlDbType.NVarChar, 4000).Value = dt.Rows(i)("Caption")
                SQLcmd.Parameters.Add("@LeftAmount", SqlDbType.Decimal).Value = dt.Rows(i)("LeftAmount")
                SQLcmd.Parameters.Add("@RightAmount", SqlDbType.Decimal).Value = dt.Rows(i)("RightAmount")
                SQLcmd.Parameters.Add("@TypeRow", SqlDbType.Int).Value = dt.Rows(i)("TypeRow")
                SQLcmd.Parameters.Add("@Note", SqlDbType.NVarChar, 4000).Value = dt.Rows(i)("Note")
                ListofSQLCmd.Add(SQLcmd)
            Next


            Return ADO.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofSQLCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
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
            Return False
        End Try
    End Function

    Public Function Save_PNLExecute(ByVal ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Return ADO.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
    Public Function Save_ProfitAndLoss_Query(ByVal dt As DataTable, ByRef Listofcmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "INSERT INTO PROFIT_LOSS_ACCOUNT (PL_KEY,PL_REF_NO,PL_YA,PL_SALES,PL_OP_STK,PL_PURCHASES,PL_PRO_COST,PL_PRO_COST_DPC,PL_PRO_COST_OAE,PL_PRO_COST_ONAE,PL_PURCHASES_PRO_COST,PL_CLS_STK,PL_COGS,PL_GROSS_PROFIT,PL_OTH_BSIN,PL_OTH_BSIN_UNREALGT,PL_OTH_BSIN_REALGT,PL_OTH_BSIN_RENTAL,PL_OTH_BSIN_OTHER,PL_OTH_IN,PL_OTH_IN_DIVIDEND,PL_OTH_IN_INTEREST,PL_OTH_IN_RENTAL,PL_OTH_IN_ROYALTY,PL_OTH_IN_OTHER,PL_NONTAX_IN,PL_NONTAX_IN_FA_DISP,PL_NONTAX_IN_INV_DISP,PL_NONTAX_IN_EXM_DIV,PL_NONTAX_IN_FIR,PL_NONTAX_IN_REALG,PL_NONTAX_IN_UNREALG,PL_NONTAX_IN_INSU_COMP,PL_EXP_INT,PL_LAWYER_COST,PL_CONTRACT_EXP,PL_EXP_SALARY,PL_ROYALTY,PL_EXP_RENT,PL_EXP_MAINTENANCE,PL_RND,PL_ADVERT,PL_TRAVEL,PL_OTHER_EXP,PL_OTHER_EXP_DPC,PL_OTHER_EXP_DNT,PL_OTHER_EXP_DNT_APP,PL_OTHER_EXP_DNT_NAPP,PL_OTHER_EXP_FA_DISP,PL_OTHER_EXP_ENTM,PL_OTHER_EXP_ENTM_CLNT,PL_OTHER_EXP_ENTM_STFF,PL_OTHER_EXP_PENALTY,PL_OTHER_EXP_PROV_ACC,PL_OTHER_EXP_LEAVE,PL_OTHER_EXP_FA_WO,PL_OTHER_EXP_UNREALOSS,PL_OTHER_EXP_REALOSS,PL_OTHER_EXP_INI_SUB,PL_OTHER_EXP_CAP_EXP,PL_OTHER_EXP_OTHERS,PL_TOT_EXP,PL_NET_PROFIT_LOSS,PL_DISALLOWED_EXP,PL_TOTALX,PL_TOTALY,PL_EXP_INTRESTRICT,PL_OTH_BSIN_NONSOURCE,PL_S60F,PL_MAINBUZ,PL_OTHER_EXP_ZAKAT,PL_COMPANY,PL_TREGROSS,PL_TTAXDEDUCTION,PL_TNETDEDUCTION,PL_TECH_FEE,PL_EMPL_STOCK,PL_S60FA,PL_OTHER_EXP_BALANCE,PL_OTHER_EXRLOSSFOREIGNT,PL_DIRECTORS_FEE,PL_JKDM,ModifiedBy,ModifiedDateTime,PNL_Status) VALUES (@PL_KEY,@PL_REF_NO,@PL_YA,@PL_SALES,@PL_OP_STK,@PL_PURCHASES,@PL_PRO_COST,@PL_PRO_COST_DPC,@PL_PRO_COST_OAE,@PL_PRO_COST_ONAE,@PL_PURCHASES_PRO_COST,@PL_CLS_STK,@PL_COGS,@PL_GROSS_PROFIT,@PL_OTH_BSIN,@PL_OTH_BSIN_UNREALGT,@PL_OTH_BSIN_REALGT,@PL_OTH_BSIN_RENTAL,@PL_OTH_BSIN_OTHER,@PL_OTH_IN,@PL_OTH_IN_DIVIDEND,@PL_OTH_IN_INTEREST,@PL_OTH_IN_RENTAL,@PL_OTH_IN_ROYALTY,@PL_OTH_IN_OTHER,@PL_NONTAX_IN,@PL_NONTAX_IN_FA_DISP,@PL_NONTAX_IN_INV_DISP,@PL_NONTAX_IN_EXM_DIV,@PL_NONTAX_IN_FIR,@PL_NONTAX_IN_REALG,@PL_NONTAX_IN_UNREALG,@PL_NONTAX_IN_INSU_COMP,@PL_EXP_INT,@PL_LAWYER_COST,@PL_CONTRACT_EXP,@PL_EXP_SALARY,@PL_ROYALTY,@PL_EXP_RENT,@PL_EXP_MAINTENANCE,@PL_RND,@PL_ADVERT,@PL_TRAVEL,@PL_OTHER_EXP,@PL_OTHER_EXP_DPC,@PL_OTHER_EXP_DNT,@PL_OTHER_EXP_DNT_APP,@PL_OTHER_EXP_DNT_NAPP,@PL_OTHER_EXP_FA_DISP,@PL_OTHER_EXP_ENTM,@PL_OTHER_EXP_ENTM_CLNT,@PL_OTHER_EXP_ENTM_STFF,@PL_OTHER_EXP_PENALTY,@PL_OTHER_EXP_PROV_ACC,@PL_OTHER_EXP_LEAVE,@PL_OTHER_EXP_FA_WO,@PL_OTHER_EXP_UNREALOSS,@PL_OTHER_EXP_REALOSS,@PL_OTHER_EXP_INI_SUB,@PL_OTHER_EXP_CAP_EXP,@PL_OTHER_EXP_OTHERS,@PL_TOT_EXP,@PL_NET_PROFIT_LOSS,@PL_DISALLOWED_EXP,@PL_TOTALX,@PL_TOTALY,@PL_EXP_INTRESTRICT,@PL_OTH_BSIN_NONSOURCE,@PL_S60F,@PL_MAINBUZ,@PL_OTHER_EXP_ZAKAT,@PL_COMPANY,@PL_TREGROSS,@PL_TTAXDEDUCTION,@PL_TNETDEDUCTION,@PL_TECH_FEE,@PL_EMPL_STOCK,@PL_S60FA,@PL_OTHER_EXP_BALANCE,@PL_OTHER_EXRLOSSFOREIGNT,@PL_DIRECTORS_FEE,@PL_JKDM,@ModifiedBy,@ModifiedDateTime,@PNL_Status)"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = dt.Rows(0)("PL_KEY")
            SQLcmd.Parameters.Add("@PL_REF_NO", SqlDbType.NVarChar, 20).Value = dt.Rows(0)("PL_REF_NO")
            SQLcmd.Parameters.Add("@PL_YA", SqlDbType.NVarChar, 5).Value = dt.Rows(0)("PL_YA")
            SQLcmd.Parameters.Add("@PL_SALES", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_SALES")), 0, dt.Rows(0)("PL_SALES"))
            SQLcmd.Parameters.Add("@PL_OP_STK", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OP_STK")), 0, dt.Rows(0)("PL_OP_STK"))
            SQLcmd.Parameters.Add("@PL_PURCHASES", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_PURCHASES")), 0, dt.Rows(0)("PL_PURCHASES"))
            SQLcmd.Parameters.Add("@PL_PRO_COST", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_PRO_COST")), 0, dt.Rows(0)("PL_PRO_COST"))
            SQLcmd.Parameters.Add("@PL_PRO_COST_DPC", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_PRO_COST_DPC")), 0, dt.Rows(0)("PL_PRO_COST_DPC"))
            SQLcmd.Parameters.Add("@PL_PRO_COST_OAE", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_PRO_COST_OAE")), 0, dt.Rows(0)("PL_PRO_COST_OAE"))
            SQLcmd.Parameters.Add("@PL_PRO_COST_ONAE", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_PRO_COST_ONAE")), 0, dt.Rows(0)("PL_PRO_COST_ONAE"))
            SQLcmd.Parameters.Add("@PL_PURCHASES_PRO_COST", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_PURCHASES_PRO_COST")), 0, dt.Rows(0)("PL_PURCHASES_PRO_COST"))
            SQLcmd.Parameters.Add("@PL_CLS_STK", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_CLS_STK")), 0, dt.Rows(0)("PL_CLS_STK"))
            SQLcmd.Parameters.Add("@PL_COGS", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_COGS")), 0, dt.Rows(0)("PL_COGS"))
            SQLcmd.Parameters.Add("@PL_GROSS_PROFIT", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_GROSS_PROFIT")), 0, dt.Rows(0)("PL_GROSS_PROFIT"))
            SQLcmd.Parameters.Add("@PL_OTH_BSIN", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_BSIN")), 0, dt.Rows(0)("PL_OTH_BSIN"))
            SQLcmd.Parameters.Add("@PL_OTH_BSIN_UNREALGT", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_BSIN_UNREALGT")), 0, dt.Rows(0)("PL_OTH_BSIN_UNREALGT"))
            SQLcmd.Parameters.Add("@PL_OTH_BSIN_REALGT", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_BSIN_REALGT")), 0, dt.Rows(0)("PL_OTH_BSIN_REALGT"))
            SQLcmd.Parameters.Add("@PL_OTH_BSIN_RENTAL", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_BSIN_RENTAL")), 0, dt.Rows(0)("PL_OTH_BSIN_RENTAL"))
            SQLcmd.Parameters.Add("@PL_OTH_BSIN_OTHER", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_BSIN_OTHER")), 0, dt.Rows(0)("PL_OTH_BSIN_OTHER"))
            SQLcmd.Parameters.Add("@PL_OTH_IN", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_IN")), 0, dt.Rows(0)("PL_OTH_IN"))
            SQLcmd.Parameters.Add("@PL_OTH_IN_DIVIDEND", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_IN_DIVIDEND")), 0, dt.Rows(0)("PL_OTH_IN_DIVIDEND"))
            SQLcmd.Parameters.Add("@PL_OTH_IN_INTEREST", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_IN_INTEREST")), 0, dt.Rows(0)("PL_OTH_IN_INTEREST"))
            SQLcmd.Parameters.Add("@PL_OTH_IN_RENTAL", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_IN_RENTAL")), 0, dt.Rows(0)("PL_OTH_IN_RENTAL"))
            SQLcmd.Parameters.Add("@PL_OTH_IN_ROYALTY", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_IN_ROYALTY")), 0, dt.Rows(0)("PL_OTH_IN_ROYALTY"))
            SQLcmd.Parameters.Add("@PL_OTH_IN_OTHER", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_IN_OTHER")), 0, dt.Rows(0)("PL_OTH_IN_OTHER"))
            SQLcmd.Parameters.Add("@PL_NONTAX_IN", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_NONTAX_IN")), 0, dt.Rows(0)("PL_NONTAX_IN"))
            SQLcmd.Parameters.Add("@PL_NONTAX_IN_FA_DISP", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_NONTAX_IN_FA_DISP")), 0, dt.Rows(0)("PL_NONTAX_IN_FA_DISP"))
            SQLcmd.Parameters.Add("@PL_NONTAX_IN_INV_DISP", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_NONTAX_IN_INV_DISP")), 0, dt.Rows(0)("PL_NONTAX_IN_INV_DISP"))
            SQLcmd.Parameters.Add("@PL_NONTAX_IN_EXM_DIV", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_NONTAX_IN_EXM_DIV")), 0, dt.Rows(0)("PL_NONTAX_IN_EXM_DIV"))
            SQLcmd.Parameters.Add("@PL_NONTAX_IN_FIR", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_NONTAX_IN_FIR")), 0, dt.Rows(0)("PL_NONTAX_IN_FIR"))
            SQLcmd.Parameters.Add("@PL_NONTAX_IN_REALG", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_NONTAX_IN_REALG")), 0, dt.Rows(0)("PL_NONTAX_IN_REALG"))
            SQLcmd.Parameters.Add("@PL_NONTAX_IN_UNREALG", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_NONTAX_IN_UNREALG")), 0, dt.Rows(0)("PL_NONTAX_IN_UNREALG"))
            SQLcmd.Parameters.Add("@PL_NONTAX_IN_INSU_COMP", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_NONTAX_IN_INSU_COMP")), 0, dt.Rows(0)("PL_NONTAX_IN_INSU_COMP"))
            SQLcmd.Parameters.Add("@PL_EXP_INT", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_EXP_INT")), 0, dt.Rows(0)("PL_EXP_INT"))
            SQLcmd.Parameters.Add("@PL_LAWYER_COST", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_LAWYER_COST")), 0, dt.Rows(0)("PL_LAWYER_COST"))
            SQLcmd.Parameters.Add("@PL_CONTRACT_EXP", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_CONTRACT_EXP")), 0, dt.Rows(0)("PL_CONTRACT_EXP"))
            SQLcmd.Parameters.Add("@PL_EXP_SALARY", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_EXP_SALARY")), 0, dt.Rows(0)("PL_EXP_SALARY"))
            SQLcmd.Parameters.Add("@PL_ROYALTY", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_ROYALTY")), 0, dt.Rows(0)("PL_ROYALTY"))
            SQLcmd.Parameters.Add("@PL_EXP_RENT", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_EXP_RENT")), 0, dt.Rows(0)("PL_EXP_RENT"))
            SQLcmd.Parameters.Add("@PL_EXP_MAINTENANCE", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_EXP_MAINTENANCE")), 0, dt.Rows(0)("PL_EXP_MAINTENANCE"))
            SQLcmd.Parameters.Add("@PL_RND", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_RND")), 0, dt.Rows(0)("PL_RND"))
            SQLcmd.Parameters.Add("@PL_ADVERT", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_ADVERT")), 0, dt.Rows(0)("PL_ADVERT"))
            SQLcmd.Parameters.Add("@PL_TRAVEL", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_TRAVEL")), 0, dt.Rows(0)("PL_TRAVEL"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP")), 0, dt.Rows(0)("PL_OTHER_EXP"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_DPC", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_DPC")), 0, dt.Rows(0)("PL_OTHER_EXP_DPC"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_DNT", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_DNT")), 0, dt.Rows(0)("PL_OTHER_EXP_DNT"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_DNT_APP", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_DNT_APP")), 0, dt.Rows(0)("PL_OTHER_EXP_DNT_APP"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_DNT_NAPP", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_DNT_NAPP")), 0, dt.Rows(0)("PL_OTHER_EXP_DNT_NAPP"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_FA_DISP", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_FA_DISP")), 0, dt.Rows(0)("PL_OTHER_EXP_FA_DISP"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_ENTM", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_ENTM")), 0, dt.Rows(0)("PL_OTHER_EXP_ENTM"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_ENTM_CLNT", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_ENTM_CLNT")), 0, dt.Rows(0)("PL_OTHER_EXP_ENTM_CLNT"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_ENTM_STFF", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_ENTM_STFF")), 0, dt.Rows(0)("PL_OTHER_EXP_ENTM_STFF"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_PENALTY", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_PENALTY")), 0, dt.Rows(0)("PL_OTHER_EXP_PENALTY"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_PROV_ACC", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_PROV_ACC")), 0, dt.Rows(0)("PL_OTHER_EXP_PROV_ACC"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_LEAVE", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_LEAVE")), 0, dt.Rows(0)("PL_OTHER_EXP_LEAVE"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_FA_WO", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_FA_WO")), 0, dt.Rows(0)("PL_OTHER_EXP_FA_WO"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_UNREALOSS", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_UNREALOSS")), 0, dt.Rows(0)("PL_OTHER_EXP_UNREALOSS"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_REALOSS", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_REALOSS")), 0, dt.Rows(0)("PL_OTHER_EXP_REALOSS"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_INI_SUB", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_INI_SUB")), 0, dt.Rows(0)("PL_OTHER_EXP_INI_SUB"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_CAP_EXP", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_CAP_EXP")), 0, dt.Rows(0)("PL_OTHER_EXP_CAP_EXP"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_OTHERS", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_OTHERS")), 0, dt.Rows(0)("PL_OTHER_EXP_OTHERS"))
            SQLcmd.Parameters.Add("@PL_TOT_EXP", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_TOT_EXP")), 0, dt.Rows(0)("PL_TOT_EXP"))
            SQLcmd.Parameters.Add("@PL_NET_PROFIT_LOSS", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_NET_PROFIT_LOSS")), 0, dt.Rows(0)("PL_NET_PROFIT_LOSS"))
            SQLcmd.Parameters.Add("@PL_DISALLOWED_EXP", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_DISALLOWED_EXP")), 0, dt.Rows(0)("PL_DISALLOWED_EXP"))
            SQLcmd.Parameters.Add("@PL_TOTALX", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_TOTALX")), 0, dt.Rows(0)("PL_TOTALX"))
            SQLcmd.Parameters.Add("@PL_TOTALY", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_TOTALY")), 0, dt.Rows(0)("PL_TOTALY"))
            SQLcmd.Parameters.Add("@PL_EXP_INTRESTRICT", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_EXP_INTRESTRICT")), 0, dt.Rows(0)("PL_EXP_INTRESTRICT"))
            SQLcmd.Parameters.Add("@PL_OTH_BSIN_NONSOURCE", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_BSIN_NONSOURCE")), 0, dt.Rows(0)("PL_OTH_BSIN_NONSOURCE"))
            SQLcmd.Parameters.Add("@PL_S60F", SqlDbType.NVarChar, 1).Value = dt.Rows(0)("PL_S60F")
            SQLcmd.Parameters.Add("@PL_MAINBUZ", SqlDbType.Int).Value = dt.Rows(0)("PL_MAINBUZ")
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_ZAKAT", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_ZAKAT")), 0, dt.Rows(0)("PL_OTHER_EXP_ZAKAT"))
            SQLcmd.Parameters.Add("@PL_COMPANY", SqlDbType.NVarChar, 8).Value = dt.Rows(0)("PL_COMPANY")
            SQLcmd.Parameters.Add("@PL_TREGROSS", SqlDbType.NVarChar, 25).Value = dt.Rows(0)("PL_TREGROSS")
            SQLcmd.Parameters.Add("@PL_TTAXDEDUCTION", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_TTAXDEDUCTION")), 0, dt.Rows(0)("PL_TTAXDEDUCTION"))
            SQLcmd.Parameters.Add("@PL_TNETDEDUCTION", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_TNETDEDUCTION")), 0, dt.Rows(0)("PL_TNETDEDUCTION"))
            SQLcmd.Parameters.Add("@PL_TECH_FEE", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_TECH_FEE")), 0, dt.Rows(0)("PL_TECH_FEE"))
            SQLcmd.Parameters.Add("@PL_EMPL_STOCK", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_EMPL_STOCK")), 0, dt.Rows(0)("PL_EMPL_STOCK"))
            SQLcmd.Parameters.Add("@PL_S60FA", SqlDbType.NVarChar, 1).Value = dt.Rows(0)("PL_S60FA")
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_BALANCE", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_BALANCE")), 0, dt.Rows(0)("PL_OTHER_EXP_BALANCE"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXRLOSSFOREIGNT", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXRLOSSFOREIGNT")), 0, dt.Rows(0)("PL_OTHER_EXRLOSSFOREIGNT"))
            SQLcmd.Parameters.Add("@PL_DIRECTORS_FEE", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_DIRECTORS_FEE")), 0, dt.Rows(0)("PL_DIRECTORS_FEE"))
            SQLcmd.Parameters.Add("@PL_JKDM", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_JKDM")), 0, dt.Rows(0)("PL_JKDM"))
            SQLcmd.Parameters.Add("@ModifiedBy", SqlDbType.NVarChar, 100).Value = IIf(IsDBNull(dt.Rows(0)("ModifiedBy")), My.Computer.Name, dt.Rows(0)("ModifiedBy"))
            SQLcmd.Parameters.Add("@ModifiedDateTime", SqlDbType.DateTime).Value = Now
            SQLcmd.Parameters.Add("@PNL_Status", SqlDbType.NVarChar, 20).Value = IIf(IsDBNull(dt.Rows(0)("PNL_Status")), "New", dt.Rows(0)("PNL_Status"))

            Listofcmd.Add(SQLcmd)
            Return True
        Catch ex As Exception
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

    Public Function Save_REF_INTEREST_RESTRIC_DETAIL_TEMP(ByVal dt As DataTable, ByVal RefNo As String, ByVal YA As String, ByVal KeyID As Integer, ByRef Amount As Decimal, Optional ByRef ErrorLog As clsError = Nothing, Optional IsMonthly As Boolean = False) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection
            Amount = 0
            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim ListofCmd As New List(Of SqlCommand)
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "DELETE FROM REF_INTEREST_RESTRIC_DETAIL_TEMP WHERE RIRD_KEY=@RIRD_KEY"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@RIRD_KEY", SqlDbType.Int).Value = KeyID
            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO REF_INTEREST_RESTRIC_DETAIL_TEMP(RIRD_KEY,RIR_REF_NUM,RIR_REF_NO,RIR_YA,RIRD_MONTH,RIRD_TYPE,RIRD_DESC,RIRD_AMOUNT,RIRD_NOTE,RIRD_SOURCENO,RIRD_TYPE_INCOME) VALUES (@RIRD_KEY,RIR_REF_NUM,@RIR_REF_NO,@RIR_YA,RIR_REF_NO,@RIR_REF_NUM,@RIRD_MONTH,@RIRD_TYPE,@RIRD_DESC,@RIRD_AMOUNT,@RIRD_NOTE,@RIRD_SOURCENO,@RIRD_TYPE_INCOME)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@RIRD_KEY", SqlDbType.Int).Value = KeyID
                SQLcmd.Parameters.Add("@RIR_REF_NUM", SqlDbType.Int).Value = i
                SQLcmd.Parameters.Add("@RIR_REF_NO", SqlDbType.Int).Value = RefNo
                SQLcmd.Parameters.Add("@RIR_YA", SqlDbType.Int).Value = YA
                If IsMonthly Then
                    SQLcmd.Parameters.Add("@RIRD_MONTH", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(dt.Rows(i)("RIRD_MONTH")), "0", dt.Rows(i)("RIRD_MONTH"))
                Else
                    SQLcmd.Parameters.Add("@RIRD_MONTH", SqlDbType.NVarChar, 50).Value = CStr(i + 1)
                End If

                SQLcmd.Parameters.Add("@RIRD_TYPE", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(dt.Rows(i)("RIRD_TYPE")), "", dt.Rows(i)("RIRD_TYPE"))
                SQLcmd.Parameters.Add("@RIRD_DESC", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(dt.Rows(i)("RIRD_DESC")), "", dt.Rows(i)("RIRD_DESC"))

                Amount += CDec(IIf(IsDBNull(dt.Rows(i)("RIRD_AMOUNT")), 0, dt.Rows(i)("RIRD_AMOUNT")))
                SQLcmd.Parameters.Add("@RIRD_AMOUNT", SqlDbType.NVarChar, 255).Value = IIf(IsDBNull(dt.Rows(i)("RIRD_AMOUNT")), "", dt.Rows(i)("RIRD_AMOUNT"))
                SQLcmd.Parameters.Add("@RIRD_NOTE", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(dt.Rows(i)("RIRD_NOTE")), "", dt.Rows(i)("RIRD_NOTE"))
                SQLcmd.Parameters.Add("@RIRD_SOURCENO", SqlDbType.Int).Value = IIf(IsDBNull(dt.Rows(i)("RIRD_SOURCENO")), 0, dt.Rows(i)("RIRD_SOURCENO"))
                SQLcmd.Parameters.Add("@RIRD_TYPE_INCOME", SqlDbType.NVarChar, 255).Value = IIf(IsDBNull(dt.Rows(i)("RIRD_TYPE_INCOME")), "", dt.Rows(i)("RIRD_TYPE_INCOME"))

                ListofCmd.Add(SQLcmd)
            Next



            Return ADO.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
    Public Function Save_EXPENSES_ALLOW(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                         ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE EXPENSES_ALLOW WHERE EXA_KEY=@EXA_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXA_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO EXPENSES_ALLOW(EXA_KEY,EXA_EXAKEY,EXA_SOURCENO,EXA_DESC,EXA_AMOUNT,EXA_DEDUCTIBLE,EXA_NOTE,EXA_DETAIL,RowIndex) VALUES (@EXA_KEY,@EXA_EXAKEY,@EXA_SOURCENO,@EXA_DESC,@EXA_AMOUNT,@EXA_DEDUCTIBLE,@EXA_NOTE,@EXA_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXA_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXA_EXAKEY", SqlDbType.Int).Value = dt.Rows(i)("EXA_EXAKEY")
                SQLcmd.Parameters.Add("@EXA_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXA_SOURCENO")
                SQLcmd.Parameters.Add("@EXA_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXA_DESC")
                SQLcmd.Parameters.Add("@EXA_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXA_AMOUNT")
                SQLcmd.Parameters.Add("@EXA_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXA_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXA_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXA_NOTE")
                SQLcmd.Parameters.Add("@EXA_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXA_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE EXPENSES_ALLOW_DETAIL WHERE EXAD_KEY=@EXAD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXAD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO EXPENSES_ALLOW_DETAIL(EXAD_KEY,EXAD_EXAKEY,EXAD_SOURCENO,EXAD_EXADKEY,EXAD_DESC,EXAD_AMOUNT,EXAD_DEDUCTIBLE,EXAD_NOTE,RowIndex) VALUES (@EXAD_KEY,@EXAD_EXAKEY,@EXAD_SOURCENO,@EXAD_EXADKEY,@EXAD_DESC,@EXAD_AMOUNT,@EXAD_DEDUCTIBLE,@EXAD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXAD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXAD_EXAKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXAD_EXAKEY")
                    SQLcmd.Parameters.Add("@EXAD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXAD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXAD_EXADKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXAD_EXADKEY")
                    SQLcmd.Parameters.Add("@EXAD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXAD_DESC")
                    SQLcmd.Parameters.Add("@EXAD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXAD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXAD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXAD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXAD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXAD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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
    Public Function Save_EXPENSES_CONTRACT(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                            ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE EXPENSES_CONTRACT WHERE EXC_KEY=@EXC_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXC_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO EXPENSES_CONTRACT(EXC_KEY,EXC_EXCKEY,EXC_SOURCENO,EXC_DESC,EXC_AMOUNT,EXC_DEDUCTIBLE,EXC_NOTE,EXC_DETAIL) VALUES (@EXC_KEY,@EXC_EXCKEY,@EXC_SOURCENO,@EXC_DESC,@EXC_AMOUNT,@EXC_DEDUCTIBLE,@EXC_NOTE,@EXC_DETAIL)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXC_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXC_EXCKEY", SqlDbType.Int).Value = dt.Rows(i)("EXC_EXCKEY")
                SQLcmd.Parameters.Add("@EXC_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXC_SOURCENO")
                SQLcmd.Parameters.Add("@EXC_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXC_DESC")
                SQLcmd.Parameters.Add("@EXC_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXC_AMOUNT")
                SQLcmd.Parameters.Add("@EXC_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXC_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXC_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXC_NOTE")
                SQLcmd.Parameters.Add("@EXC_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXC_DETAIL")

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE EXPENSES_CONTRACT_DETAIL WHERE EXCD_KEY=@EXCD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXCD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO EXPENSES_CONTRACT_DETAIL(EXCD_KEY,EXCD_EXCKEY,EXCD_SOURCENO,EXCD_EXCDKEY,EXCD_DESC,EXCD_AMOUNT,EXCD_DEDUCTIBLE,EXCD_NOTE) VALUES (@EXCD_KEY,@EXCD_EXCKEY,@EXCD_SOURCENO,@EXCD_EXCDKEY,@EXCD_DESC,@EXCD_AMOUNT,@EXCD_DEDUCTIBLE,@EXCD_NOTE)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXCD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXCD_EXCKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXCD_EXCKEY")
                    SQLcmd.Parameters.Add("@EXCD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXCD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXCD_EXCDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXCD_EXCDKEY")
                    SQLcmd.Parameters.Add("@EXCD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXCD_DESC")
                    SQLcmd.Parameters.Add("@EXCD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXCD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXCD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXCD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXCD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXCD_NOTE")

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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
    Public Function Save_EXPENSES_DEPRECIATION(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                            ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE EXPENSES_DEPRECIATION WHERE EXDEP_KEY=@EXDEP_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXDEP_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO EXPENSES_DEPRECIATION(EXDEP_KEY,EXDEP_EXDEPKEY,EXDEP_SOURCENO,EXDEP_DESC,EXDEP_AMOUNT,EXDEP_DEDUCTIBLE,EXDEP_NOTE,EXDEP_DETAIL,RowIndex) VALUES (@EXDEP_KEY,@EXDEP_EXDEPKEY,@EXDEP_SOURCENO,@EXDEP_DESC,@EXDEP_AMOUNT,@EXDEP_DEDUCTIBLE,@EXDEP_NOTE,@EXDEP_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXDEP_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXDEP_EXDEPKEY", SqlDbType.Int).Value = dt.Rows(i)("EXDEP_EXDEPKEY")
                SQLcmd.Parameters.Add("@EXDEP_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXDEP_SOURCENO")
                SQLcmd.Parameters.Add("@EXDEP_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXDEP_DESC")
                SQLcmd.Parameters.Add("@EXDEP_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXDEP_AMOUNT")
                SQLcmd.Parameters.Add("@EXDEP_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXDEP_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXDEP_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXDEP_NOTE")
                SQLcmd.Parameters.Add("@EXDEP_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXDEP_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE EXPENSES_DEPRECIATION_DETAIL WHERE EXDEPD_KEY=@EXDEPD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXDEPD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO EXPENSES_DEPRECIATION_DETAIL(EXDEPD_KEY,EXDEPD_EXDEPKEY,EXDEPD_SOURCENO,EXDEPD_EXDEPDKEY,EXDEPD_DESC,EXDEPD_AMOUNT,EXDEPD_DEDUCTIBLE,EXDEPD_NOTE,RowIndex) VALUES (@EXDEPD_KEY,@EXDEPD_EXDEPKEY,@EXDEPD_SOURCENO,@EXDEPD_EXDEPDKEY,@EXDEPD_DESC,@EXDEPD_AMOUNT,@EXDEPD_DEDUCTIBLE,@EXDEPD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXDEPD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXDEPD_EXDEPKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXDEPD_EXDEPKEY")
                    SQLcmd.Parameters.Add("@EXDEPD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXDEPD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXDEPD_EXDEPDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXDEPD_EXDEPDKEY")
                    SQLcmd.Parameters.Add("@EXDEPD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXDEPD_DESC")
                    SQLcmd.Parameters.Add("@EXDEPD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXDEPD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXDEPD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXDEPD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXDEPD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXDEPD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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
    Public Function Save_EXPENSES_DIRECTORS_FEE(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                            ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE EXPENSES_DIRECTORS_FEE WHERE EXDF_KEY=@EXDF_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXDF_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO EXPENSES_DIRECTORS_FEE(EXDF_KEY,EXDF_EXDFKEY,EXDF_SOURCENO,EXDF_DESC,EXDF_AMOUNT,EXDF_DEDUCTIBLE,EXDF_NOTE,EXDF_DETAIL,RowIndex) VALUES (@EXDF_KEY,@EXDF_EXDFKEY,@EXDF_SOURCENO,@EXDF_DESC,@EXDF_AMOUNT,@EXDF_DEDUCTIBLE,@EXDF_NOTE,@EXDF_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXDF_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXDF_EXDFKEY", SqlDbType.Int).Value = dt.Rows(i)("EXDF_EXDFKEY")
                SQLcmd.Parameters.Add("@EXDF_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXDF_SOURCENO")
                SQLcmd.Parameters.Add("@EXDF_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXDF_DESC")
                SQLcmd.Parameters.Add("@EXDF_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXDF_AMOUNT")
                SQLcmd.Parameters.Add("@EXDF_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXDF_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXDF_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXDF_NOTE")
                SQLcmd.Parameters.Add("@EXDF_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXDF_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE EXPENSES_DIRECTORS_FEE_DETAIL WHERE EXDFD_KEY=@EXDFD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXDFD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO EXPENSES_DIRECTORS_FEE_DETAIL(EXDFD_KEY,EXDFD_EXDFKEY,EXDFD_SOURCENO,EXDFD_EXDFDKEY,EXDFD_DESC,EXDFD_AMOUNT,EXDFD_DEDUCTIBLE,EXDFD_NOTE,RowIndex) VALUES (@EXDFD_KEY,@EXDFD_EXDFKEY,@EXDFD_SOURCENO,@EXDFD_EXDFDKEY,@EXDFD_DESC,@EXDFD_AMOUNT,@EXDFD_DEDUCTIBLE,@EXDFD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXDFD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXDFD_EXDFKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXDFD_EXDFKEY")
                    SQLcmd.Parameters.Add("@EXDFD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXDFD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXDFD_EXDFDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXDFD_EXDFDKEY")
                    SQLcmd.Parameters.Add("@EXDFD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXDFD_DESC")
                    SQLcmd.Parameters.Add("@EXDFD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXDFD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXDFD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXDFD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXDFD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXDFD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x
                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_EXPENSES_EMPL_STOCK(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                            ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE EXPENSES_EMPL_STOCK WHERE EXES_KEY=@EXES_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXES_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO EXPENSES_EMPL_STOCK(EXES_KEY,EXES_EXESKEY,EXES_SOURCENO,EXES_DESC,EXES_AMOUNT,EXES_DEDUCTIBLE,EXES_NOTE,EXES_DETAIL,RowIndex) VALUES (@EXES_KEY,@EXES_EXESKEY,@EXES_SOURCENO,@EXES_DESC,@EXES_AMOUNT,@EXES_DEDUCTIBLE,@EXES_NOTE,@EXES_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXES_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXES_EXESKEY", SqlDbType.Int).Value = dt.Rows(i)("EXES_EXESKEY")
                SQLcmd.Parameters.Add("@EXES_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXES_SOURCENO")
                SQLcmd.Parameters.Add("@EXES_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXES_DESC")
                SQLcmd.Parameters.Add("@EXES_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXES_AMOUNT")
                SQLcmd.Parameters.Add("@EXES_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXES_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXES_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXES_NOTE")
                SQLcmd.Parameters.Add("@EXES_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXES_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i
                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO EXPENSES_EMPL_STOCK_DETAIL(EXESD_KEY,EXESD_EXESKEY,EXESD_SOURCENO,EXESD_EXESDKEY,EXESD_DESC,EXESD_AMOUNT,EXESD_DEDUCTIBLE,EXESD_NOTE,RowIndex) VALUES (@EXESD_KEY,@EXESD_EXESKEY,@EXESD_SOURCENO,@EXESD_EXESDKEY,@EXESD_DESC,@EXESD_AMOUNT,@EXESD_DEDUCTIBLE,@EXESD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXESD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXESD_EXESKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXESD_EXESKEY")
                    SQLcmd.Parameters.Add("@EXESD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXESD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXESD_EXESDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXESD_EXESDKEY")
                    SQLcmd.Parameters.Add("@EXESD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXESD_DESC")
                    SQLcmd.Parameters.Add("@EXESD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXESD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXESD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXESD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXESD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXESD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x
                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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
    Public Function Save_EXPENSES_INTEREST(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                            ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE EXPENSES_INTEREST WHERE EXI_KEY=@EXI_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXI_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO EXPENSES_INTEREST(EXI_KEY,EXI_EXIKEY,EXI_SOURCENO,EXI_DESC,EXI_AMOUNT,EXI_DEDUCTIBLE,EXI_NOTE,EXI_DETAIL,RowIndex) VALUES (@EXI_KEY,@EXI_EXIKEY,@EXI_SOURCENO,@EXI_DESC,@EXI_AMOUNT,@EXI_DEDUCTIBLE,@EXI_NOTE,@EXI_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXI_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXI_EXIKEY", SqlDbType.Int).Value = dt.Rows(i)("EXI_EXIKEY")
                SQLcmd.Parameters.Add("@EXI_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXI_SOURCENO")
                SQLcmd.Parameters.Add("@EXI_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXI_DESC")
                SQLcmd.Parameters.Add("@EXI_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXI_AMOUNT")
                SQLcmd.Parameters.Add("@EXI_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXI_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXI_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXI_NOTE")
                SQLcmd.Parameters.Add("@EXI_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXI_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE EXPENSES_INTEREST_DETAIL WHERE EXID_KEY=@EXID_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXID_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO EXPENSES_INTEREST_DETAIL(EXID_KEY,EXID_EXIKEY,EXID_SOURCENO,EXID_EXIDKEY,EXID_DESC,EXID_AMOUNT,EXID_DEDUCTIBLE,EXID_NOTE,RowIndex) VALUES (@EXID_KEY,@EXID_EXIKEY,@EXID_SOURCENO,@EXID_EXIDKEY,@EXID_DESC,@EXID_AMOUNT,@EXID_DEDUCTIBLE,@EXID_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXID_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXID_EXIKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXID_EXIKEY")
                    SQLcmd.Parameters.Add("@EXID_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXID_SOURCENO")
                    SQLcmd.Parameters.Add("@EXID_EXIDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXID_EXIDKEY")
                    SQLcmd.Parameters.Add("@EXID_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXID_DESC")
                    SQLcmd.Parameters.Add("@EXID_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXID_AMOUNT")
                    SQLcmd.Parameters.Add("@EXID_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXID_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXID_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXID_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x
                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_EXPENSES_INTERESTRESTRICT(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                            ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE EXPENSES_INTERESTRESTRICT WHERE EXIR_KEY=@EXIR_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXIR_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO EXPENSES_INTERESTRESTRICT(EXIR_KEY,EXIR_EXIRKEY,EXIR_SOURCENO,EXIR_DESC,EXIR_AMOUNT,EXIR_DEDUCTIBLE,EXIR_NOTE,EXIR_DETAIL,EXIR_YEAREND,EXIR_STATUS,RowIndex) VALUES (@EXIR_KEY,@EXIR_EXIRKEY,@EXIR_SOURCENO,@EXIR_DESC,@EXIR_AMOUNT,@EXIR_DEDUCTIBLE,@EXIR_NOTE,@EXIR_DETAIL,@EXIR_YEAREND,@EXIR_STATUS,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXIR_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXIR_EXIRKEY", SqlDbType.Int).Value = dt.Rows(i)("EXIR_EXIRKEY")
                SQLcmd.Parameters.Add("@EXIR_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXIR_SOURCENO")
                SQLcmd.Parameters.Add("@EXIR_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXIR_DESC")
                SQLcmd.Parameters.Add("@EXIR_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXIR_AMOUNT")
                SQLcmd.Parameters.Add("@EXIR_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXIR_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXIR_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXIR_NOTE")
                SQLcmd.Parameters.Add("@EXIR_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXIR_DETAIL")
                SQLcmd.Parameters.Add("@EXIR_YEAREND", SqlDbType.NVarChar, 50).Value = dt.Rows(i)("EXIR_YEAREND")
                SQLcmd.Parameters.Add("@EXIR_STATUS", SqlDbType.NVarChar, 10).Value = dt.Rows(i)("EXIR_STATUS")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE EXPENSES_INTERESTRESTRICT_DETAIL WHERE EXIRD_KEY=@EXIRD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXIRD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO EXPENSES_INTERESTRESTRICT_DETAIL(EXIRD_KEY,EXIRD_EXIRKEY,EXIRD_SOURCENO,EXIRD_EXIRDKEY,EXIRD_DESC,EXIRD_AMOUNT,EXIRD_DEDUCTIBLE,EXIRD_NOTE,RowIndex) VALUES (@EXIRD_KEY,@EXIRD_EXIRKEY,@EXIRD_SOURCENO,@EXIRD_EXIRDKEY,@EXIRD_DESC,@EXIRD_AMOUNT,@EXIRD_DEDUCTIBLE,@EXIRD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXIRD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXIRD_EXIRKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXIRD_EXIRKEY")
                    SQLcmd.Parameters.Add("@EXIRD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXIRD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXIRD_EXIRDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXIRD_EXIRDKEY")
                    SQLcmd.Parameters.Add("@EXIRD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXIRD_DESC")
                    SQLcmd.Parameters.Add("@EXIRD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXIRD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXIRD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXIRD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXIRD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXIRD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x
                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_EXPENSES_JKDM(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                            ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE EXPENSES_JKDM WHERE EXJK_KEY=@EXJK_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXJK_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO EXPENSES_JKDM(EXJK_KEY,EXJK_EXJKKEY,EXJK_SOURCENO,EXJK_DESC,EXJK_AMOUNT,EXJK_DEDUCTIBLE,EXJK_NOTE,EXJK_DETAIL,RowIndex) VALUES (@EXJK_KEY,@EXJK_EXJKKEY,@EXJK_SOURCENO,@EXJK_DESC,@EXJK_AMOUNT,@EXJK_DEDUCTIBLE,@EXJK_NOTE,@EXJK_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXJK_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXJK_EXJKKEY", SqlDbType.Int).Value = dt.Rows(i)("EXJK_EXJKKEY")
                SQLcmd.Parameters.Add("@EXJK_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXJK_SOURCENO")
                SQLcmd.Parameters.Add("@EXJK_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXJK_DESC")
                SQLcmd.Parameters.Add("@EXJK_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXJK_AMOUNT")
                SQLcmd.Parameters.Add("@EXJK_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXJK_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXJK_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXJK_NOTE")
                SQLcmd.Parameters.Add("@EXJK_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXJK_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE EXPENSES_JKDM_DETAIL WHERE EXJKD_KEY=@EXJKD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXJKD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO EXPENSES_JKDM_DETAIL(EXJKD_KEY,EXJKD_EXJKKEY,EXJKD_SOURCENO,EXJKD_EXJKDKEY,EXJKD_DESC,EXJKD_AMOUNT,EXJKD_DEDUCTIBLE,EXJKD_NOTE,RowIndex) VALUES (@EXJKD_KEY,@EXJKD_EXJKKEY,@EXJKD_SOURCENO,@EXJKD_EXJKDKEY,@EXJKD_DESC,@EXJKD_AMOUNT,@EXJKD_DEDUCTIBLE,@EXJKD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXJKD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXJKD_EXJKKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXJKD_EXJKKEY")
                    SQLcmd.Parameters.Add("@EXJKD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXJKD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXJKD_EXJKDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXJKD_EXJKDKEY")
                    SQLcmd.Parameters.Add("@EXJKD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXJKD_DESC")
                    SQLcmd.Parameters.Add("@EXJKD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXJKD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXJKD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXJKD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXJKD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXJKD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_EXPENSES_LEGAL(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                            ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE EXPENSES_LEGAL WHERE EXL_KEY=@EXL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXL_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO EXPENSES_LEGAL(EXL_KEY,EXL_EXLKEY,EXL_SOURCENO,EXL_DESC,EXL_AMOUNT,EXL_DEDUCTIBLE,EXL_NOTE,EXL_DETAIL,RowIndex) VALUES (@EXL_KEY,@EXL_EXLKEY,@EXL_SOURCENO,@EXL_DESC,@EXL_AMOUNT,@EXL_DEDUCTIBLE,@EXL_NOTE,@EXL_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXL_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXL_EXLKEY", SqlDbType.Int).Value = dt.Rows(i)("EXL_EXLKEY")
                SQLcmd.Parameters.Add("@EXL_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXL_SOURCENO")
                SQLcmd.Parameters.Add("@EXL_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXL_DESC")
                SQLcmd.Parameters.Add("@EXL_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXL_AMOUNT")
                SQLcmd.Parameters.Add("@EXL_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXL_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXL_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXL_NOTE")
                SQLcmd.Parameters.Add("@EXL_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXL_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE EXPENSES_LEGAL_DETAIL WHERE EXLD_KEY=@EXLD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXLD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO EXPENSES_LEGAL_DETAIL(EXLD_KEY,EXLD_EXLKEY,EXLD_SOURCENO,EXLD_EXLDKEY,EXLD_DESC,EXLD_AMOUNT,EXLD_DEDUCTIBLE,EXLD_NOTE,RowIndex) VALUES (@EXLD_KEY,@EXLD_EXLKEY,@EXLD_SOURCENO,@EXLD_EXLDKEY,@EXLD_DESC,@EXLD_AMOUNT,@EXLD_DEDUCTIBLE,@EXLD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXLD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXLD_EXLKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXLD_EXLKEY")
                    SQLcmd.Parameters.Add("@EXLD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXLD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXLD_EXLDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXLD_EXLDKEY")
                    SQLcmd.Parameters.Add("@EXLD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXLD_DESC")
                    SQLcmd.Parameters.Add("@EXLD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXLD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXLD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXLD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXLD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXLD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x
                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_EXPENSES_NONALLOW(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                            ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE EXPENSES_NONALLOW WHERE EXNA_KEY=@EXNA_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXNA_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO EXPENSES_NONALLOW(EXNA_KEY,EXNA_EXNAKEY,EXNA_SOURCENO,EXNA_DESC,EXNA_AMOUNT,EXNA_DEDUCTIBLE,EXNA_NOTE,EXNA_DETAIL,RowIndex) VALUES (@EXNA_KEY,@EXNA_EXNAKEY,@EXNA_SOURCENO,@EXNA_DESC,@EXNA_AMOUNT,@EXNA_DEDUCTIBLE,@EXNA_NOTE,@EXNA_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXNA_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXNA_EXNAKEY", SqlDbType.Int).Value = dt.Rows(i)("EXNA_EXNAKEY")
                SQLcmd.Parameters.Add("@EXNA_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXNA_SOURCENO")
                SQLcmd.Parameters.Add("@EXNA_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXNA_DESC")
                SQLcmd.Parameters.Add("@EXNA_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXNA_AMOUNT")
                SQLcmd.Parameters.Add("@EXNA_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXNA_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXNA_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXNA_NOTE")
                SQLcmd.Parameters.Add("@EXNA_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXNA_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE EXPENSES_NONALLOW_DETAIL WHERE EXNAD_KEY=@EXNAD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXNAD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO EXPENSES_NONALLOW_DETAIL(EXNAD_KEY,EXNAD_EXNAKEY,EXNAD_SOURCENO,EXNAD_EXNADKEY,EXNAD_DESC,EXNAD_AMOUNT,EXNAD_DEDUCTIBLE,EXNAD_NOTE,RowIndex) VALUES (@EXNAD_KEY,@EXNAD_EXNAKEY,@EXNAD_SOURCENO,@EXNAD_EXNADKEY,@EXNAD_DESC,@EXNAD_AMOUNT,@EXNAD_DEDUCTIBLE,@EXNAD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXNAD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXNAD_EXNAKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXNAD_EXNAKEY")
                    SQLcmd.Parameters.Add("@EXNAD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXNAD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXNAD_EXNADKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXNAD_EXNADKEY")
                    SQLcmd.Parameters.Add("@EXNAD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXNAD_DESC")
                    SQLcmd.Parameters.Add("@EXNAD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXNAD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXNAD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXNAD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXNAD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXNAD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_EXPENSES_PROMOTE(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                            ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE EXPENSES_PROMOTE WHERE EXP_KEY=@EXP_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXP_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO EXPENSES_PROMOTE(EXP_KEY,EXP_EXPKEY,EXP_SOURCENO,EXP_DESC,EXP_AMOUNT,EXP_DEDUCTIBLE,EXP_NOTE,EXP_DETAIL,RowIndex) VALUES (@EXP_KEY,@EXP_EXPKEY,@EXP_SOURCENO,@EXP_DESC,@EXP_AMOUNT,@EXP_DEDUCTIBLE,@EXP_NOTE,@EXP_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXP_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXP_EXPKEY", SqlDbType.Int).Value = dt.Rows(i)("EXP_EXPKEY")
                SQLcmd.Parameters.Add("@EXP_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXP_SOURCENO")
                SQLcmd.Parameters.Add("@EXP_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXP_DESC")
                SQLcmd.Parameters.Add("@EXP_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXP_AMOUNT")
                SQLcmd.Parameters.Add("@EXP_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXP_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXP_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXP_NOTE")
                SQLcmd.Parameters.Add("@EXP_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXP_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE EXPENSES_PROMOTE_DETAIL WHERE EXPD_KEY=@EXPD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXPD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO EXPENSES_PROMOTE_DETAIL(EXPD_KEY,EXPD_EXPKEY,EXPD_SOURCENO,EXPD_EXPDKEY,EXPD_DESC,EXPD_AMOUNT,EXPD_DEDUCTIBLE,EXPD_NOTE,RowIndex) VALUES (@EXPD_KEY,@EXPD_EXPKEY,@EXPD_SOURCENO,@EXPD_EXPDKEY,@EXPD_DESC,@EXPD_AMOUNT,@EXPD_DEDUCTIBLE,@EXPD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXPD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXPD_EXPKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXPD_EXPKEY")
                    SQLcmd.Parameters.Add("@EXPD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXPD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXPD_EXPDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXPD_EXPDKEY")
                    SQLcmd.Parameters.Add("@EXPD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXPD_DESC")
                    SQLcmd.Parameters.Add("@EXPD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXPD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXPD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXPD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXPD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXPD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_EXPENSES_RENTAL(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                            ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE EXPENSES_RENTAL WHERE EXRENT_KEY=@EXRENT_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXRENT_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO EXPENSES_RENTAL(EXRENT_KEY,EXRENT_EXRENTKEY,EXRENT_SOURCENO,EXRENT_DESC,EXRENT_AMOUNT,EXRENT_DEDUCTIBLE,EXRENT_NOTE,EXRENT_DETAIL,RowIndex) VALUES (@EXRENT_KEY,@EXRENT_EXRENTKEY,@EXRENT_SOURCENO,@EXRENT_DESC,@EXRENT_AMOUNT,@EXRENT_DEDUCTIBLE,@EXRENT_NOTE,@EXRENT_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXRENT_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXRENT_EXRENTKEY", SqlDbType.Int).Value = dt.Rows(i)("EXRENT_EXRENTKEY")
                SQLcmd.Parameters.Add("@EXRENT_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXRENT_SOURCENO")
                SQLcmd.Parameters.Add("@EXRENT_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXRENT_DESC")
                SQLcmd.Parameters.Add("@EXRENT_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXRENT_AMOUNT")
                SQLcmd.Parameters.Add("@EXRENT_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXRENT_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXRENT_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXRENT_NOTE")
                SQLcmd.Parameters.Add("@EXRENT_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXRENT_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE EXPENSES_RENTAL_DETAIL WHERE EXRENTD_KEY=@EXRENTD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXRENTD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO EXPENSES_RENTAL_DETAIL(EXRENTD_KEY,EXRENTD_EXRENTKEY,EXRENTD_SOURCENO,EXRENTD_EXRENTDKEY,EXRENTD_DESC,EXRENTD_AMOUNT,EXRENTD_DEDUCTIBLE,EXRENTD_NOTE,RowIndex) VALUES (@EXRENTD_KEY,@EXRENTD_EXRENTKEY,@EXRENTD_SOURCENO,@EXRENTD_EXRENTDKEY,@EXRENTD_DESC,@EXRENTD_AMOUNT,@EXRENTD_DEDUCTIBLE,@EXRENTD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXRENTD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXRENTD_EXRENTKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXRENTD_EXRENTKEY")
                    SQLcmd.Parameters.Add("@EXRENTD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXRENTD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXRENTD_EXRENTDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXRENTD_EXRENTDKEY")
                    SQLcmd.Parameters.Add("@EXRENTD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXRENTD_DESC")
                    SQLcmd.Parameters.Add("@EXRENTD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXRENTD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXRENTD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXRENTD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXRENTD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXRENTD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x
                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_EXPENSES_REPAIR(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                            ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE EXPENSES_REPAIR WHERE EXREP_KEY=@EXREP_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXREP_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO EXPENSES_REPAIR(EXREP_KEY,EXREP_EXREPKEY,EXREP_SOURCENO,EXREP_DESC,EXREP_AMOUNT,EXREP_DEDUCTIBLE,EXREP_NOTE,EXREP_DETAIL,RowIndex) VALUES (@EXREP_KEY,@EXREP_EXREPKEY,@EXREP_SOURCENO,@EXREP_DESC,@EXREP_AMOUNT,@EXREP_DEDUCTIBLE,@EXREP_NOTE,@EXREP_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXREP_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXREP_EXREPKEY", SqlDbType.Int).Value = dt.Rows(i)("EXREP_EXREPKEY")
                SQLcmd.Parameters.Add("@EXREP_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXREP_SOURCENO")
                SQLcmd.Parameters.Add("@EXREP_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXREP_DESC")
                SQLcmd.Parameters.Add("@EXREP_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXREP_AMOUNT")
                SQLcmd.Parameters.Add("@EXREP_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXREP_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXREP_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXREP_NOTE")
                SQLcmd.Parameters.Add("@EXREP_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXREP_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE EXPENSES_REPAIR_DETAIL WHERE EXREPD_KEY=@EXREPD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXREPD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO EXPENSES_REPAIR_DETAIL(EXREPD_KEY,EXREPD_EXREPKEY,EXREPD_SOURCENO,EXREPD_EXREPDKEY,EXREPD_DESC,EXREPD_AMOUNT,EXREPD_DEDUCTIBLE,EXREPD_NOTE,RowIndex) VALUES (@EXREPD_KEY,@EXREPD_EXREPKEY,@EXREPD_SOURCENO,@EXREPD_EXREPDKEY,@EXREPD_DESC,@EXREPD_AMOUNT,@EXREPD_DEDUCTIBLE,@EXREPD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXREPD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXREPD_EXREPKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXREPD_EXREPKEY")
                    SQLcmd.Parameters.Add("@EXREPD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXREPD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXREPD_EXREPDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXREPD_EXREPDKEY")
                    SQLcmd.Parameters.Add("@EXREPD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXREPD_DESC")
                    SQLcmd.Parameters.Add("@EXREPD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXREPD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXREPD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXREPD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXREPD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXREPD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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
    Public Function Save_EXPENSES_RESEARCH(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                            ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE EXPENSES_RESEARCH WHERE EXRES_KEY=@EXRES_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXRES_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO EXPENSES_RESEARCH(EXRES_KEY,EXRES_EXRESKEY,EXRES_SOURCENO,EXRES_DESC,EXRES_AMOUNT,EXRES_DEDUCTIBLE,EXRES_NOTE,EXRES_DETAIL,RowIndex) VALUES (@EXRES_KEY,@EXRES_EXRESKEY,@EXRES_SOURCENO,@EXRES_DESC,@EXRES_AMOUNT,@EXRES_DEDUCTIBLE,@EXRES_NOTE,@EXRES_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXRES_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXRES_EXRESKEY", SqlDbType.Int).Value = dt.Rows(i)("EXRES_EXRESKEY")
                SQLcmd.Parameters.Add("@EXRES_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXRES_SOURCENO")
                SQLcmd.Parameters.Add("@EXRES_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXRES_DESC")
                SQLcmd.Parameters.Add("@EXRES_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXRES_AMOUNT")
                SQLcmd.Parameters.Add("@EXRES_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXRES_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXRES_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXRES_NOTE")
                SQLcmd.Parameters.Add("@EXRES_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXRES_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE EXPENSES_RESEARCH_DETAIL WHERE EXRESD_KEY=@EXRESD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXRESD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO EXPENSES_RESEARCH_DETAIL(EXRESD_KEY,EXRESD_EXRESKEY,EXRESD_SOURCENO,EXRESD_EXRESDKEY,EXRESD_DESC,EXRESD_AMOUNT,EXRESD_DEDUCTIBLE,EXRESD_NOTE,RowIndex) VALUES (@EXRESD_KEY,@EXRESD_EXRESKEY,@EXRESD_SOURCENO,@EXRESD_EXRESDKEY,@EXRESD_DESC,@EXRESD_AMOUNT,@EXRESD_DEDUCTIBLE,@EXRESD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXRESD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXRESD_EXRESKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXRESD_EXRESKEY")
                    SQLcmd.Parameters.Add("@EXRESD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXRESD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXRESD_EXRESDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXRESD_EXRESDKEY")
                    SQLcmd.Parameters.Add("@EXRESD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXRESD_DESC")
                    SQLcmd.Parameters.Add("@EXRESD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXRESD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXRESD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXRESD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXRESD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXRESD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x
                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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
    Public Function Save_EXPENSES_ROYALTY(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                            ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE EXPENSES_ROYALTY WHERE EXRO_KEY=@EXRO_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXRO_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO EXPENSES_ROYALTY(EXRO_KEY,EXRO_EXROKEY,EXRO_SOURCENO,EXRO_DESC,EXRO_AMOUNT,EXRO_DEDUCTIBLE,EXRO_NOTE,EXRO_DETAIL,RowIndex) VALUES (@EXRO_KEY,@EXRO_EXROKEY,@EXRO_SOURCENO,@EXRO_DESC,@EXRO_AMOUNT,@EXRO_DEDUCTIBLE,@EXRO_NOTE,@EXRO_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXRO_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXRO_EXROKEY", SqlDbType.Int).Value = dt.Rows(i)("EXRO_EXROKEY")
                SQLcmd.Parameters.Add("@EXRO_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXRO_SOURCENO")
                SQLcmd.Parameters.Add("@EXRO_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXRO_DESC")
                SQLcmd.Parameters.Add("@EXRO_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXRO_AMOUNT")
                SQLcmd.Parameters.Add("@EXRO_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXRO_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXRO_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXRO_NOTE")
                SQLcmd.Parameters.Add("@EXRO_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXRO_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i
                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE EXPENSES_ROYALTY_DETAIL WHERE EXROD_KEY=@EXROD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXROD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO EXPENSES_ROYALTY_DETAIL(EXROD_KEY,EXROD_EXROKEY,EXROD_SOURCENO,EXROD_EXRODKEY,EXROD_DESC,EXROD_AMOUNT,EXROD_DEDUCTIBLE,EXROD_NOTE,RowIndex) VALUES (@EXROD_KEY,@EXROD_EXROKEY,@EXROD_SOURCENO,@EXROD_EXRODKEY,@EXROD_DESC,@EXROD_AMOUNT,@EXROD_DEDUCTIBLE,@EXROD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXROD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXROD_EXROKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXROD_EXROKEY")
                    SQLcmd.Parameters.Add("@EXROD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXROD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXROD_EXRODKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXROD_EXRODKEY")
                    SQLcmd.Parameters.Add("@EXROD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXROD_DESC")
                    SQLcmd.Parameters.Add("@EXROD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXROD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXROD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXROD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXROD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXROD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x
                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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
    Public Function Save_EXPENSES_SALARY(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                            ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE EXPENSES_SALARY WHERE EXS_KEY=@EXS_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXS_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO EXPENSES_SALARY(EXS_KEY,EXS_EXSKEY,EXS_SOURCENO,EXS_DESC,EXS_AMOUNT,EXS_DEDUCTIBLE,EXS_NOTE,EXS_DETAIL,RowIndex) VALUES (@EXS_KEY,@EXS_EXSKEY,@EXS_SOURCENO,@EXS_DESC,@EXS_AMOUNT,@EXS_DEDUCTIBLE,@EXS_NOTE,@EXS_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXS_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXS_EXSKEY", SqlDbType.Int).Value = dt.Rows(i)("EXS_EXSKEY")
                SQLcmd.Parameters.Add("@EXS_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXS_SOURCENO")
                SQLcmd.Parameters.Add("@EXS_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXS_DESC")
                SQLcmd.Parameters.Add("@EXS_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXS_AMOUNT")
                SQLcmd.Parameters.Add("@EXS_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXS_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXS_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXS_NOTE")
                SQLcmd.Parameters.Add("@EXS_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXS_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i
                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE EXPENSES_SALARY_DETAIL WHERE EXSD_KEY=@EXSD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXSD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO EXPENSES_SALARY_DETAIL(EXSD_KEY,EXSD_EXSKEY,EXSD_SOURCENO,EXSD_EXSDKEY,EXSD_DESC,EXSD_AMOUNT,EXSD_DEDUCTIBLE,EXSD_NOTE,RowIndex) VALUES (@EXSD_KEY,@EXSD_EXSKEY,@EXSD_SOURCENO,@EXSD_EXSDKEY,@EXSD_DESC,@EXSD_AMOUNT,@EXSD_DEDUCTIBLE,@EXSD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXSD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXSD_EXSKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXSD_EXSKEY")
                    SQLcmd.Parameters.Add("@EXSD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXSD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXSD_EXSDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXSD_EXSDKEY")
                    SQLcmd.Parameters.Add("@EXSD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXSD_DESC")
                    SQLcmd.Parameters.Add("@EXSD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXSD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXSD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXSD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXSD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXSD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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
    Public Function Save_EXPENSES_TECH_FEE(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                            ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE EXPENSES_TECH_FEE WHERE EXTF_KEY=@EXTF_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXTF_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO EXPENSES_TECH_FEE(EXTF_KEY,EXTF_EXTFKEY,EXTF_SOURCENO,EXTF_DESC,EXTF_AMOUNT,EXTF_DEDUCTIBLE,EXTF_NOTE,EXTF_DETAIL,RowIndex) VALUES (@EXTF_KEY,@EXTF_EXTFKEY,@EXTF_SOURCENO,@EXTF_DESC,@EXTF_AMOUNT,@EXTF_DEDUCTIBLE,@EXTF_NOTE,@EXTF_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXTF_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXTF_EXTFKEY", SqlDbType.Int).Value = dt.Rows(i)("EXTF_EXTFKEY")
                SQLcmd.Parameters.Add("@EXTF_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXTF_SOURCENO")
                SQLcmd.Parameters.Add("@EXTF_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXTF_DESC")
                SQLcmd.Parameters.Add("@EXTF_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXTF_AMOUNT")
                SQLcmd.Parameters.Add("@EXTF_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXTF_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXTF_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXTF_NOTE")
                SQLcmd.Parameters.Add("@EXTF_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXTF_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i
                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE EXPENSES_TECH_FEE_DETAIL WHERE EXTFD_KEY=@EXTFD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXTFD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO EXPENSES_TECH_FEE_DETAIL(EXTFD_KEY,EXTFD_EXTFKEY,EXTFD_SOURCENO,EXTFD_EXTFDKEY,EXTFD_DESC,EXTFD_AMOUNT,EXTFD_DEDUCTIBLE,EXTFD_NOTE,RowIndex) VALUES (@EXTFD_KEY,@EXTFD_EXTFKEY,@EXTFD_SOURCENO,@EXTFD_EXTFDKEY,@EXTFD_DESC,@EXTFD_AMOUNT,@EXTFD_DEDUCTIBLE,@EXTFD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXTFD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXTFD_EXTFKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXTFD_EXTFKEY")
                    SQLcmd.Parameters.Add("@EXTFD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXTFD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXTFD_EXTFDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXTFD_EXTFDKEY")
                    SQLcmd.Parameters.Add("@EXTFD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXTFD_DESC")
                    SQLcmd.Parameters.Add("@EXTFD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXTFD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXTFD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXTFD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXTFD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXTFD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x
                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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
    Public Function Save_EXPENSES_TRAVEL(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                            ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE EXPENSES_TRAVEL WHERE EXT_KEY=@EXT_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXT_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO EXPENSES_TRAVEL(EXT_KEY,EXT_EXTKEY,EXT_SOURCENO,EXT_DESC,EXT_AMOUNT,EXT_DEDUCTIBLE,EXT_NOTE,EXT_DETAIL) VALUES (@EXT_KEY,@EXT_EXTKEY,@EXT_SOURCENO,@EXT_DESC,@EXT_AMOUNT,@EXT_DEDUCTIBLE,@EXT_NOTE,@EXT_DETAIL)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXT_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXT_EXTKEY", SqlDbType.Int).Value = dt.Rows(i)("EXT_EXTKEY")
                SQLcmd.Parameters.Add("@EXT_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXT_SOURCENO")
                SQLcmd.Parameters.Add("@EXT_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXT_DESC")
                SQLcmd.Parameters.Add("@EXT_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXT_AMOUNT")
                SQLcmd.Parameters.Add("@EXT_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXT_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXT_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXT_NOTE")
                SQLcmd.Parameters.Add("@EXT_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXT_DETAIL")

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE EXPENSES_TRAVEL_DETAIL WHERE EXTD_KEY=@EXTD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXTD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO EXPENSES_TRAVEL_DETAIL(EXTD_KEY,EXTD_EXTKEY,EXTD_SOURCENO,EXTD_EXTDKEY,EXTD_DESC,EXTD_AMOUNT,EXTD_DEDUCTIBLE,EXTD_NOTE) VALUES (@EXTD_KEY,@EXTD_EXTKEY,@EXTD_SOURCENO,@EXTD_EXTDKEY,@EXTD_DESC,@EXTD_AMOUNT,@EXTD_DEDUCTIBLE,@EXTD_NOTE)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXTD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXTD_EXTKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXTD_EXTKEY")
                    SQLcmd.Parameters.Add("@EXTD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXTD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXTD_EXTDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXTD_EXTDKEY")
                    SQLcmd.Parameters.Add("@EXTD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXTD_DESC")
                    SQLcmd.Parameters.Add("@EXTD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXTD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXTD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXTD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXTD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXTD_NOTE")

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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
    Public Function Save_INCOME_NBINTEREST(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE INCOME_NBINTEREST WHERE NOBII_KEY=@NOBII_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NOBII_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO INCOME_NBINTEREST(NOBII_KEY,NOBII_NOBIIKEY,NOBII_DESC,NOBII_AMOUNT,NOBII_NOTE,NOBII_DETAIL,NOBII_SOURCENO,RowIndex) VALUES (@NOBII_KEY,@NOBII_NOBIIKEY,@NOBII_DESC,@NOBII_AMOUNT,@NOBII_NOTE,@NOBII_DETAIL,@NOBII_SOURCENO,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@NOBII_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@NOBII_NOBIIKEY", SqlDbType.Int).Value = dt.Rows(i)("NOBII_NOBIIKEY")
                SQLcmd.Parameters.Add("@NOBII_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("NOBII_DESC")
                SQLcmd.Parameters.Add("@NOBII_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("NOBII_AMOUNT")
                SQLcmd.Parameters.Add("@NOBII_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("NOBII_NOTE")
                SQLcmd.Parameters.Add("@NOBII_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("NOBII_DETAIL")
                SQLcmd.Parameters.Add("@NOBII_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("NOBII_SOURCENO")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE INCOME_NBINTEREST_DETAIL WHERE NOBIID_KEY=@NOBIID_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@NOBIID_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO INCOME_NBINTEREST_DETAIL(NOBIID_KEY,NOBIID_NOBIIKEY,NOBIID_NOBIIDKEY,NOBIID_DESC,NOBIID_AMOUNT,NOBIID_NOTE,NOBIID_SOURCENO,RowIndex) VALUES (@NOBIID_KEY,@NOBIID_NOBIIKEY,@NOBIID_NOBIIDKEY,@NOBIID_DESC,@NOBIID_AMOUNT,@NOBIID_NOTE,@NOBIID_SOURCENO,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NOBIID_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@NOBIID_NOBIIKEY", SqlDbType.Int).Value = dt_child.Rows(x)("NOBIID_NOBIIKEY")
                    SQLcmd.Parameters.Add("@NOBIID_NOBIIDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("NOBIID_NOBIIDKEY")
                    SQLcmd.Parameters.Add("@NOBIID_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("NOBIID_DESC")
                    SQLcmd.Parameters.Add("@NOBIID_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("NOBIID_AMOUNT")
                    SQLcmd.Parameters.Add("@NOBIID_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("NOBIID_NOTE")
                    SQLcmd.Parameters.Add("@NOBIID_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("NOBIID_SOURCENO")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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
    Public Function Save_INCOME_NBROYALTY(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE INCOME_NBROYALTY WHERE NOBRI_KEY=@NOBRI_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NOBRI_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO INCOME_NBROYALTY(NOBRI_KEY,NOBRI_NOBRIKEY,NOBRI_DESC,NOBRI_AMOUNT,NOBRI_NOTE,NOBRI_DETAIL,NOBRI_SOURCENO,RowIndex) VALUES (@NOBRI_KEY,@NOBRI_NOBRIKEY,@NOBRI_DESC,@NOBRI_AMOUNT,@NOBRI_NOTE,@NOBRI_DETAIL,@NOBRI_SOURCENO,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@NOBRI_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@NOBRI_NOBRIKEY", SqlDbType.Int).Value = dt.Rows(i)("NOBRI_NOBRIKEY")
                SQLcmd.Parameters.Add("@NOBRI_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("NOBRI_DESC")
                SQLcmd.Parameters.Add("@NOBRI_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("NOBRI_AMOUNT")
                SQLcmd.Parameters.Add("@NOBRI_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("NOBRI_NOTE")
                SQLcmd.Parameters.Add("@NOBRI_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("NOBRI_DETAIL")
                SQLcmd.Parameters.Add("@NOBRI_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("NOBRI_SOURCENO")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE INCOME_NBROYALTY_DETAIL WHERE NOBRID_KEY=@NOBRID_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@NOBRID_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO INCOME_NBROYALTY_DETAIL(NOBRID_KEY,NOBRID_NOBRIKEY,NOBRID_NOBRIDKEY,NOBRID_DESC,NOBRID_AMOUNT,NOBRID_NOTE,NOBRID_SOURCENO,RowIndex) VALUES (@NOBRID_KEY,@NOBRID_NOBRIKEY,@NOBRID_NOBRIDKEY,@NOBRID_DESC,@NOBRID_AMOUNT,@NOBRID_NOTE,@NOBRID_SOURCENO,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NOBRID_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@NOBRID_NOBRIKEY", SqlDbType.Int).Value = dt_child.Rows(x)("NOBRID_NOBRIKEY")
                    SQLcmd.Parameters.Add("@NOBRID_NOBRIDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("NOBRID_NOBRIDKEY")
                    SQLcmd.Parameters.Add("@NOBRID_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("NOBRID_DESC")
                    SQLcmd.Parameters.Add("@NOBRID_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("NOBRID_AMOUNT")
                    SQLcmd.Parameters.Add("@NOBRID_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("NOBRID_NOTE")
                    SQLcmd.Parameters.Add("@NOBRID_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("NOBRID_SOURCENO")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x
                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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
    Public Function Save_INCOME_NTDISPOSALFA(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE INCOME_NTDISPOSALFA WHERE NTIDFA_KEY=@NTIDFA_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NTIDFA_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO INCOME_NTDISPOSALFA(NTIDFA_KEY,NTIDFA_NTIDFAKEY,NTIDFA_DESC,NTIDFA_AMOUNT,NTIDFA_NOTE,NTIDFA_DETAIL,NTIDFA_SOURCENO,RowIndex) VALUES (@NTIDFA_KEY,@NTIDFA_NTIDFAKEY,@NTIDFA_DESC,@NTIDFA_AMOUNT,@NTIDFA_NOTE,@NTIDFA_DETAIL,@NTIDFA_SOURCENO,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@NTIDFA_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@NTIDFA_NTIDFAKEY", SqlDbType.Int).Value = dt.Rows(i)("NTIDFA_NTIDFAKEY")
                SQLcmd.Parameters.Add("@NTIDFA_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("NTIDFA_DESC")
                SQLcmd.Parameters.Add("@NTIDFA_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("NTIDFA_AMOUNT")
                SQLcmd.Parameters.Add("@NTIDFA_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("NTIDFA_NOTE")
                SQLcmd.Parameters.Add("@NTIDFA_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("NTIDFA_DETAIL")
                SQLcmd.Parameters.Add("@NTIDFA_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("NTIDFA_SOURCENO")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE INCOME_NTDISPOSALFA_DETAIL WHERE NTIDFAD_KEY=@NTIDFAD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@NTIDFAD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO INCOME_NTDISPOSALFA_DETAIL(NTIDFAD_KEY,NTIDFAD_NTIDFAKEY,NTIDFAD_NTIDFADKEY,NTIDFAD_DESC,NTIDFAD_AMOUNT,NTIDFAD_NOTE,NTIDFAD_SOURCENO,RowIndex) VALUES (@NTIDFAD_KEY,@NTIDFAD_NTIDFAKEY,@NTIDFAD_NTIDFADKEY,@NTIDFAD_DESC,@NTIDFAD_AMOUNT,@NTIDFAD_NOTE,@NTIDFAD_SOURCENO,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NTIDFAD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@NTIDFAD_NTIDFAKEY", SqlDbType.Int).Value = dt_child.Rows(x)("NTIDFAD_NTIDFAKEY")
                    SQLcmd.Parameters.Add("@NTIDFAD_NTIDFADKEY", SqlDbType.Int).Value = dt_child.Rows(x)("NTIDFAD_NTIDFADKEY")
                    SQLcmd.Parameters.Add("@NTIDFAD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("NTIDFAD_DESC")
                    SQLcmd.Parameters.Add("@NTIDFAD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("NTIDFAD_AMOUNT")
                    SQLcmd.Parameters.Add("@NTIDFAD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("NTIDFAD_NOTE")
                    SQLcmd.Parameters.Add("@NTIDFAD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("NTIDFAD_SOURCENO")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

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
    Public Function Save_INCOME_NTDISPOSALINVEST(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE INCOME_NTDISPOSALINVEST WHERE NTIDI_KEY=@NTIDI_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NTIDI_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO INCOME_NTDISPOSALINVEST(NTIDI_KEY,NTIDI_NTIDIKEY,NTIDI_DESC,NTIDI_AMOUNT,NTIDI_NOTE,NTIDI_DETAIL,NTIDI_SOURCENO,RowIndex) VALUES (@NTIDI_KEY,@NTIDI_NTIDIKEY,@NTIDI_DESC,@NTIDI_AMOUNT,@NTIDI_NOTE,@NTIDI_DETAIL,@NTIDI_SOURCENO,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@NTIDI_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@NTIDI_NTIDIKEY", SqlDbType.Int).Value = dt.Rows(i)("NTIDI_NTIDIKEY")
                SQLcmd.Parameters.Add("@NTIDI_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("NTIDI_DESC")
                SQLcmd.Parameters.Add("@NTIDI_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("NTIDI_AMOUNT")
                SQLcmd.Parameters.Add("@NTIDI_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("NTIDI_NOTE")
                SQLcmd.Parameters.Add("@NTIDI_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("NTIDI_DETAIL")
                SQLcmd.Parameters.Add("@NTIDI_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("NTIDI_SOURCENO")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE INCOME_NTDISPOSALINVEST_DETAIL WHERE NTIDID_KEY=@NTIDID_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@NTIDID_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO INCOME_NTDISPOSALINVEST_DETAIL(NTIDID_KEY,NTIDID_NTIDIKEY,NTIDID_NTIDIDKEY,NTIDID_DESC,NTIDID_AMOUNT,NTIDID_NOTE,NTIDID_SOURCENO,RowIndex) VALUES (@NTIDID_KEY,@NTIDID_NTIDIKEY,@NTIDID_NTIDIDKEY,@NTIDID_DESC,@NTIDID_AMOUNT,@NTIDID_NOTE,@NTIDID_SOURCENO,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NTIDID_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@NTIDID_NTIDIKEY", SqlDbType.Int).Value = dt_child.Rows(x)("NTIDID_NTIDIKEY")
                    SQLcmd.Parameters.Add("@NTIDID_NTIDIDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("NTIDID_NTIDIDKEY")
                    SQLcmd.Parameters.Add("@NTIDID_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("NTIDID_DESC")
                    SQLcmd.Parameters.Add("@NTIDID_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("NTIDID_AMOUNT")
                    SQLcmd.Parameters.Add("@NTIDID_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("NTIDID_NOTE")
                    SQLcmd.Parameters.Add("@NTIDID_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("NTIDID_SOURCENO")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x
                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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
    Public Function Save_INCOME_NTFOREIGNINCREM(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE INCOME_NTFOREIGNINCREM WHERE NTIFIR_KEY=@NTIFIR_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NTIFIR_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO INCOME_NTFOREIGNINCREM(NTIFIR_KEY,NTIFIR_NTIFIRKEY,NTIFIR_DESC,NTIFIR_AMOUNT,NTIFIR_NOTE,NTIFIR_DETAIL,NTIFIR_SOURCENO,RowIndex) VALUES (@NTIFIR_KEY,@NTIFIR_NTIFIRKEY,@NTIFIR_DESC,@NTIFIR_AMOUNT,@NTIFIR_NOTE,@NTIFIR_DETAIL,@NTIFIR_SOURCENO,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@NTIFIR_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@NTIFIR_NTIFIRKEY", SqlDbType.Int).Value = dt.Rows(i)("NTIFIR_NTIFIRKEY")
                SQLcmd.Parameters.Add("@NTIFIR_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("NTIFIR_DESC")
                SQLcmd.Parameters.Add("@NTIFIR_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("NTIFIR_AMOUNT")
                SQLcmd.Parameters.Add("@NTIFIR_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("NTIFIR_NOTE")
                SQLcmd.Parameters.Add("@NTIFIR_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("NTIFIR_DETAIL")
                SQLcmd.Parameters.Add("@NTIFIR_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("NTIFIR_SOURCENO")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE INCOME_NTFOREIGNINCREM_DETAIL WHERE NTIFIRD_KEY=@NTIFIRD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@NTIFIRD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO INCOME_NTFOREIGNINCREM_DETAIL(NTIFIRD_KEY,NTIFIRD_NTIFIRKEY,NTIFIRD_NTIFIRDKEY,NTIFIRD_DESC,NTIFIRD_AMOUNT,NTIFIRD_NOTE,NTIFIRD_SOURCENO,RowIndex) VALUES (@NTIFIRD_KEY,@NTIFIRD_NTIFIRKEY,@NTIFIRD_NTIFIRDKEY,@NTIFIRD_DESC,@NTIFIRD_AMOUNT,@NTIFIRD_NOTE,@NTIFIRD_SOURCENO,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NTIFIRD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@NTIFIRD_NTIFIRKEY", SqlDbType.Int).Value = dt_child.Rows(x)("NTIFIRD_NTIFIRKEY")
                    SQLcmd.Parameters.Add("@NTIFIRD_NTIFIRDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("NTIFIRD_NTIFIRDKEY")
                    SQLcmd.Parameters.Add("@NTIFIRD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("NTIFIRD_DESC")
                    SQLcmd.Parameters.Add("@NTIFIRD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("NTIFIRD_AMOUNT")
                    SQLcmd.Parameters.Add("@NTIFIRD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("NTIFIRD_NOTE")
                    SQLcmd.Parameters.Add("@NTIFIRD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("NTIFIRD_SOURCENO")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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
    Public Function Save_INCOME_NTREALFE(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE INCOME_NTREALFE WHERE NTIRFECT_KEY=@NTIRFECT_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NTIRFECT_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO INCOME_NTREALFE(NTIRFECT_KEY,NTIRFECT_NTIRFECTKEY,NTIRFECT_DESC,NTIRFECT_AMOUNT,NTIRFECT_NOTE,NTIRFECT_DETAIL,NTIRFECT_SOURCENO,RowIndex) VALUES (@NTIRFECT_KEY,@NTIRFECT_NTIRFECTKEY,@NTIRFECT_DESC,@NTIRFECT_AMOUNT,@NTIRFECT_NOTE,@NTIRFECT_DETAIL,@NTIRFECT_SOURCENO,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@NTIRFECT_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@NTIRFECT_NTIRFECTKEY", SqlDbType.Int).Value = dt.Rows(i)("NTIRFECT_NTIRFECTKEY")
                SQLcmd.Parameters.Add("@NTIRFECT_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("NTIRFECT_DESC")
                SQLcmd.Parameters.Add("@NTIRFECT_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("NTIRFECT_AMOUNT")
                SQLcmd.Parameters.Add("@NTIRFECT_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("NTIRFECT_NOTE")
                SQLcmd.Parameters.Add("@NTIRFECT_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("NTIRFECT_DETAIL")
                SQLcmd.Parameters.Add("@NTIRFECT_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("NTIRFECT_SOURCENO")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE INCOME_NTREALFE_DETAIL WHERE NTIRFECTD_KEY=@NTIRFECTD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@NTIRFECTD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO INCOME_NTREALFE_DETAIL(NTIRFECTD_KEY,NTIRFECTD_NTIRFECTKEY,NTIRFECTD_NTIRFECTDKEY,NTIRFECTD_DESC,NTIRFECTD_AMOUNT,NTIRFECTD_NOTE,NTIRFECTD_SOURCENO,RowIndex) VALUES (@NTIRFECTD_KEY,@NTIRFECTD_NTIRFECTKEY,@NTIRFECTD_NTIRFECTDKEY,@NTIRFECTD_DESC,@NTIRFECTD_AMOUNT,@NTIRFECTD_NOTE,@NTIRFECTD_SOURCENO,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NTIRFECTD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@NTIRFECTD_NTIRFECTKEY", SqlDbType.Int).Value = dt_child.Rows(x)("NTIRFECTD_NTIRFECTKEY")
                    SQLcmd.Parameters.Add("@NTIRFECTD_NTIRFECTDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("NTIRFECTD_NTIRFECTDKEY")
                    SQLcmd.Parameters.Add("@NTIRFECTD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("NTIRFECTD_DESC")
                    SQLcmd.Parameters.Add("@NTIRFECTD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("NTIRFECTD_AMOUNT")
                    SQLcmd.Parameters.Add("@NTIRFECTD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("NTIRFECTD_NOTE")
                    SQLcmd.Parameters.Add("@NTIRFECTD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("NTIRFECTD_SOURCENO")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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
    Public Function Save_INCOME_NTUREALFENT(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE INCOME_NTUREALFENT WHERE NTIUNT_KEY=@NTIUNT_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NTIUNT_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO INCOME_NTUREALFENT(NTIUNT_KEY,NTIUNT_NTIUNTKEY,NTIUNT_DESC,NTIUNT_AMOUNT,NTIUNT_NOTE,NTIUNT_DETAIL,NTIUNT_SOURCENO,RowIndex) VALUES (@NTIUNT_KEY,@NTIUNT_NTIUNTKEY,@NTIUNT_DESC,@NTIUNT_AMOUNT,@NTIUNT_NOTE,@NTIUNT_DETAIL,@NTIUNT_SOURCENO,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@NTIUNT_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@NTIUNT_NTIUNTKEY", SqlDbType.Int).Value = dt.Rows(i)("NTIUNT_NTIUNTKEY")
                SQLcmd.Parameters.Add("@NTIUNT_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("NTIUNT_DESC")
                SQLcmd.Parameters.Add("@NTIUNT_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("NTIUNT_AMOUNT")
                SQLcmd.Parameters.Add("@NTIUNT_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("NTIUNT_NOTE")
                SQLcmd.Parameters.Add("@NTIUNT_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("NTIUNT_DETAIL")
                SQLcmd.Parameters.Add("@NTIUNT_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("NTIUNT_SOURCENO")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE INCOME_NTUREALFENT_DETAIL WHERE NTIUNTD_KEY=@NTIUNTD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@NTIUNTD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO INCOME_NTUREALFENT_DETAIL(NTIUNTD_KEY,NTIUNTD_NTIUNTKEY,NTIUNTD_NTIUNTDKEY,NTIUNTD_DESC,NTIUNTD_AMOUNT,NTIUNTD_NOTE,NTIUNTD_SOURCENO,RowIndex) VALUES (@NTIUNTD_KEY,@NTIUNTD_NTIUNTKEY,@NTIUNTD_NTIUNTDKEY,@NTIUNTD_DESC,@NTIUNTD_AMOUNT,@NTIUNTD_NOTE,@NTIUNTD_SOURCENO,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NTIUNTD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@NTIUNTD_NTIUNTKEY", SqlDbType.Int).Value = dt_child.Rows(x)("NTIUNTD_NTIUNTKEY")
                    SQLcmd.Parameters.Add("@NTIUNTD_NTIUNTDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("NTIUNTD_NTIUNTDKEY")
                    SQLcmd.Parameters.Add("@NTIUNTD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("NTIUNTD_DESC")
                    SQLcmd.Parameters.Add("@NTIUNTD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("NTIUNTD_AMOUNT")
                    SQLcmd.Parameters.Add("@NTIUNTD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("NTIUNTD_NOTE")
                    SQLcmd.Parameters.Add("@NTIUNTD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("NTIUNTD_SOURCENO")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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
    Public Function Save_INCOME_NTUREALFET(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE INCOME_NTUREALFET WHERE NTIUT_KEY=@NTIUT_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NTIUT_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO INCOME_NTUREALFET(NTIUT_KEY,NTIUT_NTIUTKEY,NTIUT_DESC,NTIUT_AMOUNT,NTIUT_NOTE,NTIUT_DETAIL,NTIUT_SOURCENO,RowIndex) VALUES (@NTIUT_KEY,@NTIUT_NTIUTKEY,@NTIUT_DESC,@NTIUT_AMOUNT,@NTIUT_NOTE,@NTIUT_DETAIL,@NTIUT_SOURCENO,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@NTIUT_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@NTIUT_NTIUTKEY", SqlDbType.Int).Value = dt.Rows(i)("NTIUT_NTIUTKEY")
                SQLcmd.Parameters.Add("@NTIUT_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("NTIUT_DESC")
                SQLcmd.Parameters.Add("@NTIUT_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("NTIUT_AMOUNT")
                SQLcmd.Parameters.Add("@NTIUT_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("NTIUT_NOTE")
                SQLcmd.Parameters.Add("@NTIUT_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("NTIUT_DETAIL")
                SQLcmd.Parameters.Add("@NTIUT_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("NTIUT_SOURCENO")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE INCOME_NTUREALFET_DETAIL WHERE NTIUTD_KEY=@NTIUTD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@NTIUTD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO INCOME_NTUREALFET_DETAIL(NTIUTD_KEY,NTIUTD_NTIUTKEY,NTIUTD_NTIUTDKEY,NTIUTD_DESC,NTIUTD_AMOUNT,NTIUTD_NOTE,NTIUTD_SOURCENO,RowIndex) VALUES (@NTIUTD_KEY,@NTIUTD_NTIUTKEY,@NTIUTD_NTIUTDKEY,@NTIUTD_DESC,@NTIUTD_AMOUNT,@NTIUTD_NOTE,@NTIUTD_SOURCENO,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NTIUTD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@NTIUTD_NTIUTKEY", SqlDbType.Int).Value = dt_child.Rows(x)("NTIUTD_NTIUTKEY")
                    SQLcmd.Parameters.Add("@NTIUTD_NTIUTDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("NTIUTD_NTIUTDKEY")
                    SQLcmd.Parameters.Add("@NTIUTD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("NTIUTD_DESC")
                    SQLcmd.Parameters.Add("@NTIUTD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("NTIUTD_AMOUNT")
                    SQLcmd.Parameters.Add("@NTIUTD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("NTIUTD_NOTE")
                    SQLcmd.Parameters.Add("@NTIUTD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("NTIUTD_SOURCENO")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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
    Public Function Save_INCOME_REALFET(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE INCOME_REALFET WHERE IRFET_KEY=@IRFET_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@IRFET_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO INCOME_REALFET(IRFET_KEY,IRFET_IRFETKEY,IRFET_DESC,IRFET_AMOUNT,IRFET_NOTE,IRFET_DETAIL,IRFET_SOURCENO,RowIndex) VALUES (@IRFET_KEY,@IRFET_IRFETKEY,@IRFET_DESC,@IRFET_AMOUNT,@IRFET_NOTE,@IRFET_DETAIL,@IRFET_SOURCENO,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@IRFET_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@IRFET_IRFETKEY", SqlDbType.Int).Value = dt.Rows(i)("IRFET_IRFETKEY")
                SQLcmd.Parameters.Add("@IRFET_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("IRFET_DESC")
                SQLcmd.Parameters.Add("@IRFET_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("IRFET_AMOUNT")
                SQLcmd.Parameters.Add("@IRFET_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("IRFET_NOTE")
                SQLcmd.Parameters.Add("@IRFET_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("IRFET_DETAIL")
                SQLcmd.Parameters.Add("@IRFET_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("IRFET_SOURCENO")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE INCOME_REALFET_DETAIL WHERE IRFETD_KEY=@IRFETD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@IRFETD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO INCOME_REALFET_DETAIL(IRFETD_KEY,IRFETD_IRFETKEY,IRFETD_IRFETDKEY,IRFETD_DESC,IRFETD_AMOUNT,IRFETD_NOTE,IRFETD_SOURCENO,RowIndex) VALUES (@IRFETD_KEY,@IRFETD_IRFETKEY,@IRFETD_IRFETDKEY,@IRFETD_DESC,@IRFETD_AMOUNT,@IRFETD_NOTE,@IRFETD_SOURCENO,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@IRFETD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@IRFETD_IRFETKEY", SqlDbType.Int).Value = dt_child.Rows(x)("IRFETD_IRFETKEY")
                    SQLcmd.Parameters.Add("@IRFETD_IRFETDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("IRFETD_IRFETDKEY")
                    SQLcmd.Parameters.Add("@IRFETD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("IRFETD_DESC")
                    SQLcmd.Parameters.Add("@IRFETD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("IRFETD_AMOUNT")
                    SQLcmd.Parameters.Add("@IRFETD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("IRFETD_NOTE")
                    SQLcmd.Parameters.Add("@IRFETD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("IRFETD_SOURCENO")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_NON_TAXABLE_INCOME(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE NON_TAXABLE_INCOME WHERE NT_KEY=@NT_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NT_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)
            Dim tmpID As Integer = 0
            tmpID = GETNONTAXABLEINCOME(ErrorLog)
            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO NON_TAXABLE_INCOME(NT_KEY,NT_REF_NO,NT_YA,NT_DESC,NT_AMOUNT,NT_CATEGORIZED,NT_NOTE,NT_DETAIL,NT_SOURCENO,NT_NTKEY,RowIndex) VALUES (@NT_KEY,@NT_REF_NO,@NT_YA,@NT_DESC,@NT_AMOUNT,@NT_CATEGORIZED,@NT_NOTE,@NT_DETAIL,@NT_SOURCENO,@NT_NTKEY,@RowIndex)"
                SQLcmd = New SqlCommand


                tmpID += 1
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@NT_KEY", SqlDbType.Int).Value = tmpID
                SQLcmd.Parameters.Add("@NT_REF_NO", SqlDbType.NVarChar, 20).Value = dt.Rows(i)("NT_REF_NO")
                SQLcmd.Parameters.Add("@NT_YA", SqlDbType.NVarChar, 5).Value = dt.Rows(i)("NT_YA")
                SQLcmd.Parameters.Add("@NT_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("NT_DESC")
                SQLcmd.Parameters.Add("@NT_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("NT_AMOUNT")
                SQLcmd.Parameters.Add("@NT_CATEGORIZED", SqlDbType.NVarChar, 10).Value = dt.Rows(i)("NT_CATEGORIZED")
                SQLcmd.Parameters.Add("@NT_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("NT_NOTE")
                SQLcmd.Parameters.Add("@NT_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("NT_DETAIL")
                SQLcmd.Parameters.Add("@NT_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("NT_SOURCENO")
                SQLcmd.Parameters.Add("@NT_NTKEY", SqlDbType.Float).Value = dt.Rows(i)("NT_NTKEY")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE NON_TAXABLE_INCOME_DETAIL WHERE NTD_KEY=@NTD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@NTD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO NON_TAXABLE_INCOME_DETAIL(NTD_KEY,NTD_NTKEY,NTD_NTDKEY,NTD_DESC,NTD_AMOUNT,NTD_NOTE,NTD_SOURCENO,NTD_NTKEYN,RowIndex) VALUES (@NTD_KEY,@NTD_NTKEY,@NTD_NTDKEY,@NTD_DESC,@NTD_AMOUNT,@NTD_NOTE,@NTD_SOURCENO,@NTD_NTKEYN,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NTD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@NTD_NTKEY", SqlDbType.Int).Value = dt_child.Rows(x)("NTD_NTKEY")
                    SQLcmd.Parameters.Add("@NTD_NTDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("NTD_NTDKEY")
                    SQLcmd.Parameters.Add("@NTD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("NTD_DESC")
                    SQLcmd.Parameters.Add("@NTD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("NTD_AMOUNT")
                    SQLcmd.Parameters.Add("@NTD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("NTD_NOTE")
                    SQLcmd.Parameters.Add("@NTD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("NTD_SOURCENO")
                    SQLcmd.Parameters.Add("@NTD_NTKEYN", SqlDbType.Float).Value = dt_child.Rows(x)("NTD_NTKEYN")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x
                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_NONSOURCE_BUSINESSINCOME(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE NONSOURCE_BUSINESSINCOME WHERE NSBI_KEY=@NSBI_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NSBI_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO NONSOURCE_BUSINESSINCOME(NSBI_KEY,NSBI_NSBIKEY,NSBI_DESC,NSBI_AMOUNT,NSBI_NOTE,NSBI_DETAIL,NSBI_SOURCENO,RowIndex) VALUES (@NSBI_KEY,@NSBI_NSBIKEY,@NSBI_DESC,@NSBI_AMOUNT,@NSBI_NOTE,@NSBI_DETAIL,@NSBI_SOURCENO,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@NSBI_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@NSBI_NSBIKEY", SqlDbType.Int).Value = dt.Rows(i)("NSBI_NSBIKEY")
                SQLcmd.Parameters.Add("@NSBI_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("NSBI_DESC")
                SQLcmd.Parameters.Add("@NSBI_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("NSBI_AMOUNT")
                SQLcmd.Parameters.Add("@NSBI_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("NSBI_NOTE")
                SQLcmd.Parameters.Add("@NSBI_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("NSBI_DETAIL")
                SQLcmd.Parameters.Add("@NSBI_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("NSBI_SOURCENO")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE NONSOURCE_BUSINESSINCOME_DETAIL WHERE NSBID_KEY=@NSBID_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@NSBID_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO NONSOURCE_BUSINESSINCOME_DETAIL(NSBID_KEY,NSBID_NSBIKEY,NSBID_NSBIDKEY,NSBID_DESC,NSBID_AMOUNT,NSBID_NOTE,NSBID_SOURCENO,RowIndex) VALUES (@NSBID_KEY,@NSBID_NSBIKEY,@NSBID_NSBIDKEY,@NSBID_DESC,@NSBID_AMOUNT,@NSBID_NOTE,@NSBID_SOURCENO,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@NSBID_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@NSBID_NSBIKEY", SqlDbType.Int).Value = dt_child.Rows(x)("NSBID_NSBIKEY")
                    SQLcmd.Parameters.Add("@NSBID_NSBIDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("NSBID_NSBIDKEY")
                    SQLcmd.Parameters.Add("@NSBID_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("NSBID_DESC")
                    SQLcmd.Parameters.Add("@NSBID_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("NSBID_AMOUNT")
                    SQLcmd.Parameters.Add("@NSBID_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("NSBID_NOTE")
                    SQLcmd.Parameters.Add("@NSBID_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("NSBID_SOURCENO")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_OTHER_ENTERTAINNSTAFF(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE OTHER_ENTERTAINNSTAFF WHERE EXOENS_KEY=@EXOENS_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOENS_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO OTHER_ENTERTAINNSTAFF(EXOENS_KEY,EXOENS_EXOENSKEY,EXOENS_SOURCENO,EXOENS_DESC,EXOENS_AMOUNT,EXOENS_DEDUCTIBLE,EXOENS_NOTE,EXOENS_DETAIL,RowIndex) VALUES (@EXOENS_KEY,@EXOENS_EXOENSKEY,@EXOENS_SOURCENO,@EXOENS_DESC,@EXOENS_AMOUNT,@EXOENS_DEDUCTIBLE,@EXOENS_NOTE,@EXOENS_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOENS_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXOENS_EXOENSKEY", SqlDbType.Int).Value = dt.Rows(i)("EXOENS_EXOENSKEY")
                SQLcmd.Parameters.Add("@EXOENS_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXOENS_SOURCENO")
                SQLcmd.Parameters.Add("@EXOENS_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXOENS_DESC")
                SQLcmd.Parameters.Add("@EXOENS_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXOENS_AMOUNT")
                SQLcmd.Parameters.Add("@EXOENS_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOENS_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXOENS_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXOENS_NOTE")
                SQLcmd.Parameters.Add("@EXOENS_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOENS_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i
                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE OTHER_ENTERTAINNSTAFF_DETAIL WHERE EXOENSD_KEY=@EXOENSD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOENSD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO OTHER_ENTERTAINNSTAFF_DETAIL(EXOENSD_KEY,EXOENSD_EXOENSKEY,EXOENSD_SOURCENO,EXOENSD_EXOENSDKEY,EXOENSD_DESC,EXOENSD_DEDUCTIBLE,EXOENSD_AMOUNT,EXOENSD_NOTE,RowIndex) VALUES (@EXOENSD_KEY,@EXOENSD_EXOENSKEY,@EXOENSD_SOURCENO,@EXOENSD_EXOENSDKEY,@EXOENSD_DESC,@EXOENSD_DEDUCTIBLE,@EXOENSD_AMOUNT,@EXOENSD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOENSD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXOENSD_EXOENSKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOENSD_EXOENSKEY")
                    SQLcmd.Parameters.Add("@EXOENSD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXOENSD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXOENSD_EXOENSDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOENSD_EXOENSDKEY")
                    SQLcmd.Parameters.Add("@EXOENSD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXOENSD_DESC")
                    SQLcmd.Parameters.Add("@EXOENSD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXOENSD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXOENSD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXOENSD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXOENSD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXOENSD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x
                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_OTHER_ENTERTAINSTAFF(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE OTHER_ENTERTAINSTAFF WHERE EXOES_KEY=@EXOES_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOES_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO OTHER_ENTERTAINSTAFF(EXOES_KEY,EXOES_EXOESKEY,EXOES_SOURCENO,EXOES_DESC,EXOES_AMOUNT,EXOES_DEDUCTIBLE,EXOES_NOTE,EXOES_DETAIL,RowIndex) VALUES (@EXOES_KEY,@EXOES_EXOESKEY,@EXOES_SOURCENO,@EXOES_DESC,@EXOES_AMOUNT,@EXOES_DEDUCTIBLE,@EXOES_NOTE,@EXOES_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOES_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXOES_EXOESKEY", SqlDbType.Int).Value = dt.Rows(i)("EXOES_EXOESKEY")
                SQLcmd.Parameters.Add("@EXOES_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXOES_SOURCENO")
                SQLcmd.Parameters.Add("@EXOES_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXOES_DESC")
                SQLcmd.Parameters.Add("@EXOES_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXOES_AMOUNT")
                SQLcmd.Parameters.Add("@EXOES_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOES_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXOES_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXOES_NOTE")
                SQLcmd.Parameters.Add("@EXOES_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOES_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i
                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE OTHER_ENTERTAINSTAFF_DETAIL WHERE EXOESD_KEY=@EXOESD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOESD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO OTHER_ENTERTAINSTAFF_DETAIL(EXOESD_KEY,EXOESD_EXOESKEY,EXOESD_SOURCENO,EXOESD_EXOESDKEY,EXOESD_DESC,EXOESD_DEDUCTIBLE,EXOESD_AMOUNT,EXOESD_NOTE,RowIndex) VALUES (@EXOESD_KEY,@EXOESD_EXOESKEY,@EXOESD_SOURCENO,@EXOESD_EXOESDKEY,@EXOESD_DESC,@EXOESD_DEDUCTIBLE,@EXOESD_AMOUNT,@EXOESD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOESD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXOESD_EXOESKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOESD_EXOESKEY")
                    SQLcmd.Parameters.Add("@EXOESD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXOESD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXOESD_EXOESDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOESD_EXOESDKEY")
                    SQLcmd.Parameters.Add("@EXOESD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXOESD_DESC")
                    SQLcmd.Parameters.Add("@EXOESD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXOESD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXOESD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXOESD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXOESD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXOESD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_OTHER_EXAPPRDONATION(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE OTHER_EXAPPRDONATION WHERE EXOAD_KEY=@EXOAD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOAD_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO OTHER_EXAPPRDONATION(EXOAD_KEY,EXOAD_EXOADKEY,EXOAD_SOURCENO,EXOAD_DESC,EXOAD_AMOUNT,EXOAD_DEDUCTIBLE,EXOAD_NOTE,EXOAD_DETAIL,EXOAD_TYPE,RowIndex) VALUES (@EXOAD_KEY,@EXOAD_EXOADKEY,@EXOAD_SOURCENO,@EXOAD_DESC,@EXOAD_AMOUNT,@EXOAD_DEDUCTIBLE,@EXOAD_NOTE,@EXOAD_DETAIL,@EXOAD_TYPE,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOAD_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXOAD_EXOADKEY", SqlDbType.Int).Value = dt.Rows(i)("EXOAD_EXOADKEY")
                SQLcmd.Parameters.Add("@EXOAD_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXOAD_SOURCENO")
                SQLcmd.Parameters.Add("@EXOAD_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXOAD_DESC")
                SQLcmd.Parameters.Add("@EXOAD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXOAD_AMOUNT")
                SQLcmd.Parameters.Add("@EXOAD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOAD_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXOAD_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXOAD_NOTE")
                SQLcmd.Parameters.Add("@EXOAD_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOAD_DETAIL")
                SQLcmd.Parameters.Add("@EXOAD_TYPE", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXOAD_TYPE")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i
                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE OTHER_EXAPPRDONATION_DETAIL WHERE EXOADD_KEY=@EXOADD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOADD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO OTHER_EXAPPRDONATION_DETAIL(EXOADD_KEY,EXOADD_EXOADKEY,EXOADD_SOURCENO,EXOADD_EXOADDKEY,EXOADD_DESC,EXOADD_DEDUCTIBLE,EXOADD_AMOUNT,EXOADD_NOTE,EXOADD_TYPE,RowIndex) VALUES (@EXOADD_KEY,@EXOADD_EXOADKEY,@EXOADD_SOURCENO,@EXOADD_EXOADDKEY,@EXOADD_DESC,@EXOADD_DEDUCTIBLE,@EXOADD_AMOUNT,@EXOADD_NOTE,@EXOADD_TYPE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOADD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXOADD_EXOADKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOADD_EXOADKEY")
                    SQLcmd.Parameters.Add("@EXOADD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXOADD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXOADD_EXOADDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOADD_EXOADDKEY")
                    SQLcmd.Parameters.Add("@EXOADD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXOADD_DESC")
                    SQLcmd.Parameters.Add("@EXOADD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXOADD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXOADD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXOADD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXOADD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXOADD_NOTE")
                    SQLcmd.Parameters.Add("@EXOADD_TYPE", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXOADD_TYPE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_OTHER_EXCAPITALEXP(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE OTHER_EXCAPITALEXP WHERE EXOCE_KEY=@EXOCE_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOCE_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO OTHER_EXCAPITALEXP(EXOCE_KEY,EXOCE_EXOCEKEY,EXOCE_SOURCENO,EXOCE_DESC,EXOCE_AMOUNT,EXOCE_DEDUCTIBLE,EXOCE_NOTE,EXOCE_DETAIL,RowIndex) VALUES (@EXOCE_KEY,@EXOCE_EXOCEKEY,@EXOCE_SOURCENO,@EXOCE_DESC,@EXOCE_AMOUNT,@EXOCE_DEDUCTIBLE,@EXOCE_NOTE,@EXOCE_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOCE_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXOCE_EXOCEKEY", SqlDbType.Int).Value = dt.Rows(i)("EXOCE_EXOCEKEY")
                SQLcmd.Parameters.Add("@EXOCE_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXOCE_SOURCENO")
                SQLcmd.Parameters.Add("@EXOCE_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXOCE_DESC")
                SQLcmd.Parameters.Add("@EXOCE_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXOCE_AMOUNT")
                SQLcmd.Parameters.Add("@EXOCE_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOCE_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXOCE_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXOCE_NOTE")
                SQLcmd.Parameters.Add("@EXOCE_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOCE_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i
                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE OTHER_EXCAPITALEXP_DETAIL WHERE EXOCED_KEY=@EXOCED_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOCED_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO OTHER_EXCAPITALEXP_DETAIL(EXOCED_KEY,EXOCED_EXOCEKEY,EXOCED_SOURCENO,EXOCED_EXOCEDKEY,EXOCED_DESC,EXOCED_DEDUCTIBLE,EXOCED_AMOUNT,EXOCED_NOTE,RowIndex) VALUES (@EXOCED_KEY,@EXOCED_EXOCEKEY,@EXOCED_SOURCENO,@EXOCED_EXOCEDKEY,@EXOCED_DESC,@EXOCED_DEDUCTIBLE,@EXOCED_AMOUNT,@EXOCED_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOCED_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXOCED_EXOCEKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOCED_EXOCEKEY")
                    SQLcmd.Parameters.Add("@EXOCED_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXOCED_SOURCENO")
                    SQLcmd.Parameters.Add("@EXOCED_EXOCEDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOCED_EXOCEDKEY")
                    SQLcmd.Parameters.Add("@EXOCED_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXOCED_DESC")
                    SQLcmd.Parameters.Add("@EXOCED_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXOCED_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXOCED_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXOCED_AMOUNT")
                    SQLcmd.Parameters.Add("@EXOCED_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXOCED_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x
                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_OTHER_EXDEPRECIATION(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE OTHER_EXDEPRECIATION WHERE EXODEP_KEY=@EXODEP_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXODEP_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO OTHER_EXDEPRECIATION(EXODEP_KEY,EXODEP_EXODEPKEY,EXODEP_SOURCENO,EXODEP_DESC,EXODEP_AMOUNT,EXODEP_DEDUCTIBLE,EXODEP_NOTE,EXODEP_DETAIL,RowIndex) VALUES (@EXODEP_KEY,@EXODEP_EXODEPKEY,@EXODEP_SOURCENO,@EXODEP_DESC,@EXODEP_AMOUNT,@EXODEP_DEDUCTIBLE,@EXODEP_NOTE,@EXODEP_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXODEP_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXODEP_EXODEPKEY", SqlDbType.Int).Value = dt.Rows(i)("EXODEP_EXODEPKEY")
                SQLcmd.Parameters.Add("@EXODEP_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXODEP_SOURCENO")
                SQLcmd.Parameters.Add("@EXODEP_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXODEP_DESC")
                SQLcmd.Parameters.Add("@EXODEP_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXODEP_AMOUNT")
                SQLcmd.Parameters.Add("@EXODEP_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXODEP_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXODEP_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXODEP_NOTE")
                SQLcmd.Parameters.Add("@EXODEP_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXODEP_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE OTHER_EXDEPRECIATION_DETAIL WHERE EXODEPD_KEY=@EXODEPD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXODEPD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO OTHER_EXDEPRECIATION_DETAIL(EXODEPD_KEY,EXODEPD_EXODEPKEY,EXODEPD_SOURCENO,EXODEPD_EXODEPDKEY,EXODEPD_DESC,EXODEPD_DEDUCTIBLE,EXODEPD_AMOUNT,EXODEPD_NOTE,RowIndex) VALUES (@EXODEPD_KEY,@EXODEPD_EXODEPKEY,@EXODEPD_SOURCENO,@EXODEPD_EXODEPDKEY,@EXODEPD_DESC,@EXODEPD_DEDUCTIBLE,@EXODEPD_AMOUNT,@EXODEPD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXODEPD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXODEPD_EXODEPKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXODEPD_EXODEPKEY")
                    SQLcmd.Parameters.Add("@EXODEPD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXODEPD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXODEPD_EXODEPDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXODEPD_EXODEPDKEY")
                    SQLcmd.Parameters.Add("@EXODEPD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXODEPD_DESC")
                    SQLcmd.Parameters.Add("@EXODEPD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXODEPD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXODEPD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXODEPD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXODEPD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXODEPD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x
                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_OTHER_EXFAWRITTENOFF(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE OTHER_EXFAWRITTENOFF WHERE EXOWO_KEY=@EXOWO_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOWO_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO OTHER_EXFAWRITTENOFF(EXOWO_KEY,EXOWO_EXOWOKEY,EXOWO_SOURCENO,EXOWO_DESC,EXOWO_AMOUNT,EXOWO_DEDUCTIBLE,EXOWO_NOTE,EXOWO_DETAIL,RowIndex) VALUES (@EXOWO_KEY,@EXOWO_EXOWOKEY,@EXOWO_SOURCENO,@EXOWO_DESC,@EXOWO_AMOUNT,@EXOWO_DEDUCTIBLE,@EXOWO_NOTE,@EXOWO_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOWO_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXOWO_EXOWOKEY", SqlDbType.Int).Value = dt.Rows(i)("EXOWO_EXOWOKEY")
                SQLcmd.Parameters.Add("@EXOWO_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXOWO_SOURCENO")
                SQLcmd.Parameters.Add("@EXOWO_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXOWO_DESC")
                SQLcmd.Parameters.Add("@EXOWO_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXOWO_AMOUNT")
                SQLcmd.Parameters.Add("@EXOWO_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOWO_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXOWO_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXOWO_NOTE")
                SQLcmd.Parameters.Add("@EXOWO_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOWO_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i
                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE OTHER_EXFAWRITTENOFF_DETAIL WHERE EXOWOD_KEY=@EXOWOD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOWOD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO OTHER_EXFAWRITTENOFF_DETAIL(EXOWOD_KEY,EXOWOD_EXOWOKEY,EXOWOD_SOURCENO,EXOWOD_EXOWODKEY,EXOWOD_DESC,EXOWOD_DEDUCTIBLE,EXOWOD_AMOUNT,EXOWOD_NOTE,RowIndex) VALUES (@EXOWOD_KEY,@EXOWOD_EXOWOKEY,@EXOWOD_SOURCENO,@EXOWOD_EXOWODKEY,@EXOWOD_DESC,@EXOWOD_DEDUCTIBLE,@EXOWOD_AMOUNT,@EXOWOD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOWOD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXOWOD_EXOWOKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOWOD_EXOWOKEY")
                    SQLcmd.Parameters.Add("@EXOWOD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXOWOD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXOWOD_EXOWODKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOWOD_EXOWODKEY")
                    SQLcmd.Parameters.Add("@EXOWOD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXOWOD_DESC")
                    SQLcmd.Parameters.Add("@EXOWOD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXOWOD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXOWOD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXOWOD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXOWOD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXOWOD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x
                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_OTHER_EXINITIALSUB(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE OTHER_EXINITIALSUB WHERE EXOIS_KEY=@EXOIS_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOIS_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO OTHER_EXINITIALSUB(EXOIS_KEY,EXOIS_EXOISKEY,EXOIS_SOURCENO,EXOIS_DESC,EXOIS_AMOUNT,EXOIS_DEDUCTIBLE,EXOIS_NOTE,EXOIS_DETAIL) VALUES (@EXOIS_KEY,@EXOIS_EXOISKEY,@EXOIS_SOURCENO,@EXOIS_DESC,@EXOIS_AMOUNT,@EXOIS_DEDUCTIBLE,@EXOIS_NOTE,@EXOIS_DETAIL)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOIS_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXOIS_EXOISKEY", SqlDbType.Int).Value = dt.Rows(i)("EXOIS_EXOISKEY")
                SQLcmd.Parameters.Add("@EXOIS_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXOIS_SOURCENO")
                SQLcmd.Parameters.Add("@EXOIS_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXOIS_DESC")
                SQLcmd.Parameters.Add("@EXOIS_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXOIS_AMOUNT")
                SQLcmd.Parameters.Add("@EXOIS_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOIS_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXOIS_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXOIS_NOTE")
                SQLcmd.Parameters.Add("@EXOIS_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOIS_DETAIL")

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE OTHER_EXINITIALSUB_DETAIL WHERE EXOISD_KEY=@EXOISD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOISD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO OTHER_EXINITIALSUB_DETAIL(EXOISD_KEY,EXOISD_EXOISKEY,EXOISD_SOURCENO,EXOISD_EXOISDKEY,EXOISD_DESC,EXOISD_DEDUCTIBLE,EXOISD_AMOUNT,EXOISD_NOTE) VALUES (@EXOISD_KEY,@EXOISD_EXOISKEY,@EXOISD_SOURCENO,@EXOISD_EXOISDKEY,@EXOISD_DESC,@EXOISD_DEDUCTIBLE,@EXOISD_AMOUNT,@EXOISD_NOTE)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOISD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXOISD_EXOISKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOISD_EXOISKEY")
                    SQLcmd.Parameters.Add("@EXOISD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXOISD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXOISD_EXOISDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOISD_EXOISDKEY")
                    SQLcmd.Parameters.Add("@EXOISD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXOISD_DESC")
                    SQLcmd.Parameters.Add("@EXOISD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXOISD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXOISD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXOISD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXOISD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXOISD_NOTE")

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_OTHER_EXLEAVEPASSAGE(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE OTHER_EXLEAVEPASSAGE WHERE EXOLP_KEY=@EXOLP_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOLP_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO OTHER_EXLEAVEPASSAGE(EXOLP_KEY,EXOLP_EXOLPKEY,EXOLP_SOURCENO,EXOLP_DESC,EXOLP_AMOUNT,EXOLP_DEDUCTIBLE,EXOLP_NOTE,EXOLP_DETAIL,RowIndex) VALUES (@EXOLP_KEY,@EXOLP_EXOLPKEY,@EXOLP_SOURCENO,@EXOLP_DESC,@EXOLP_AMOUNT,@EXOLP_DEDUCTIBLE,@EXOLP_NOTE,@EXOLP_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOLP_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXOLP_EXOLPKEY", SqlDbType.Int).Value = dt.Rows(i)("EXOLP_EXOLPKEY")
                SQLcmd.Parameters.Add("@EXOLP_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXOLP_SOURCENO")
                SQLcmd.Parameters.Add("@EXOLP_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXOLP_DESC")
                SQLcmd.Parameters.Add("@EXOLP_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXOLP_AMOUNT")
                SQLcmd.Parameters.Add("@EXOLP_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOLP_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXOLP_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXOLP_NOTE")
                SQLcmd.Parameters.Add("@EXOLP_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOLP_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i
                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE OTHER_EXLEAVEPASSAGE_DETAIL WHERE EXOLPD_KEY=@EXOLPD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOLPD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO OTHER_EXLEAVEPASSAGE_DETAIL(EXOLPD_KEY,EXOLPD_EXOLPKEY,EXOLPD_SOURCENO,EXOLPD_EXOLPDKEY,EXOLPD_DESC,EXOLPD_DEDUCTIBLE,EXOLPD_AMOUNT,EXOLPD_NOTE,RowIndex) VALUES (@EXOLPD_KEY,@EXOLPD_EXOLPKEY,@EXOLPD_SOURCENO,@EXOLPD_EXOLPDKEY,@EXOLPD_DESC,@EXOLPD_DEDUCTIBLE,@EXOLPD_AMOUNT,@EXOLPD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOLPD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXOLPD_EXOLPKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOLPD_EXOLPKEY")
                    SQLcmd.Parameters.Add("@EXOLPD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXOLPD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXOLPD_EXOLPDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOLPD_EXOLPDKEY")
                    SQLcmd.Parameters.Add("@EXOLPD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXOLPD_DESC")
                    SQLcmd.Parameters.Add("@EXOLPD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXOLPD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXOLPD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXOLPD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXOLPD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXOLPD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_OTHER_EXLOSSDISPOSALFA(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE OTHER_EXLOSSDISPOSALFA WHERE EXOLD_KEY=@EXOLD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOLD_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO OTHER_EXLOSSDISPOSALFA(EXOLD_KEY,EXOLD_EXOLDKEY,EXOLD_SOURCENO,EXOLD_DESC,EXOLD_AMOUNT,EXOLD_DEDUCTIBLE,EXOLD_NOTE,EXOLD_DETAIL,RowIndex) VALUES (@EXOLD_KEY,@EXOLD_EXOLDKEY,@EXOLD_SOURCENO,@EXOLD_DESC,@EXOLD_AMOUNT,@EXOLD_DEDUCTIBLE,@EXOLD_NOTE,@EXOLD_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOLD_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXOLD_EXOLDKEY", SqlDbType.Int).Value = dt.Rows(i)("EXOLD_EXOLDKEY")
                SQLcmd.Parameters.Add("@EXOLD_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXOLD_SOURCENO")
                SQLcmd.Parameters.Add("@EXOLD_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXOLD_DESC")
                SQLcmd.Parameters.Add("@EXOLD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXOLD_AMOUNT")
                SQLcmd.Parameters.Add("@EXOLD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOLD_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXOLD_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXOLD_NOTE")
                SQLcmd.Parameters.Add("@EXOLD_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOLD_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i
                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE OTHER_EXLOSSDISPOSALFA_DETAIL WHERE EXOLDD_KEY=@EXOLDD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOLDD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO OTHER_EXLOSSDISPOSALFA_DETAIL(EXOLDD_KEY,EXOLDD_EXOLDKEY,EXOLDD_SOURCENO,EXOLDD_EXOLDDKEY,EXOLDD_DESC,EXOLDD_DEDUCTIBLE,EXOLDD_AMOUNT,EXOLDD_NOTE,RowIndex) VALUES (@EXOLDD_KEY,@EXOLDD_EXOLDKEY,@EXOLDD_SOURCENO,@EXOLDD_EXOLDDKEY,@EXOLDD_DESC,@EXOLDD_DEDUCTIBLE,@EXOLDD_AMOUNT,@EXOLDD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOLDD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXOLDD_EXOLDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOLDD_EXOLDKEY")
                    SQLcmd.Parameters.Add("@EXOLDD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXOLDD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXOLDD_EXOLDDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOLDD_EXOLDDKEY")
                    SQLcmd.Parameters.Add("@EXOLDD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXOLDD_DESC")
                    SQLcmd.Parameters.Add("@EXOLDD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXOLDD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXOLDD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXOLDD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXOLDD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXOLDD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x
                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_OTHER_EXNAPPRDONATION(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE OTHER_EXNAPPRDONATION WHERE EXONAD_KEY=@EXONAD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXONAD_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO OTHER_EXNAPPRDONATION(EXONAD_KEY,EXONAD_EXONADKEY,EXONAD_SOURCENO,EXONAD_DESC,EXONAD_AMOUNT,EXONAD_DEDUCTIBLE,EXONAD_NOTE,EXONAD_DETAIL,RowIndex) VALUES (@EXONAD_KEY,@EXONAD_EXONADKEY,@EXONAD_SOURCENO,@EXONAD_DESC,@EXONAD_AMOUNT,@EXONAD_DEDUCTIBLE,@EXONAD_NOTE,@EXONAD_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXONAD_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXONAD_EXONADKEY", SqlDbType.Int).Value = dt.Rows(i)("EXONAD_EXONADKEY")
                SQLcmd.Parameters.Add("@EXONAD_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXONAD_SOURCENO")
                SQLcmd.Parameters.Add("@EXONAD_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXONAD_DESC")
                SQLcmd.Parameters.Add("@EXONAD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXONAD_AMOUNT")
                SQLcmd.Parameters.Add("@EXONAD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXONAD_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXONAD_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXONAD_NOTE")
                SQLcmd.Parameters.Add("@EXONAD_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXONAD_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i
                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE OTHER_EXNAPPRDONATION_DETAIL WHERE EXONADD_KEY=@EXONADD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXONADD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO OTHER_EXNAPPRDONATION_DETAIL(EXONADD_KEY,EXONADD_EXONADKEY,EXONADD_SOURCENO,EXONADD_EXONADDKEY,EXONADD_DESC,EXONADD_DEDUCTIBLE,EXONADD_AMOUNT,EXONADD_NOTE,RowIndex) VALUES (@EXONADD_KEY,@EXONADD_EXONADKEY,@EXONADD_SOURCENO,@EXONADD_EXONADDKEY,@EXONADD_DESC,@EXONADD_DEDUCTIBLE,@EXONADD_AMOUNT,@EXONADD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXONADD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXONADD_EXONADKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXONADD_EXONADKEY")
                    SQLcmd.Parameters.Add("@EXONADD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXONADD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXONADD_EXONADDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXONADD_EXONADDKEY")
                    SQLcmd.Parameters.Add("@EXONADD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXONADD_DESC")
                    SQLcmd.Parameters.Add("@EXONADD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXONADD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXONADD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXONADD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXONADD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXONADD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_OTHER_EXPENALTY(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE OTHER_EXPENALTY WHERE EXOP_KEY=@EXOP_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOP_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO OTHER_EXPENALTY(EXOP_KEY,EXOP_EXOPKEY,EXOP_SOURCENO,EXOP_DESC,EXOP_AMOUNT,EXOP_DEDUCTIBLE,EXOP_NOTE,EXOP_DETAIL,RowIndex) VALUES (@EXOP_KEY,@EXOP_EXOPKEY,@EXOP_SOURCENO,@EXOP_DESC,@EXOP_AMOUNT,@EXOP_DEDUCTIBLE,@EXOP_NOTE,@EXOP_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOP_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXOP_EXOPKEY", SqlDbType.Int).Value = dt.Rows(i)("EXOP_EXOPKEY")
                SQLcmd.Parameters.Add("@EXOP_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXOP_SOURCENO")
                SQLcmd.Parameters.Add("@EXOP_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXOP_DESC")
                SQLcmd.Parameters.Add("@EXOP_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXOP_AMOUNT")
                SQLcmd.Parameters.Add("@EXOP_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOP_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXOP_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXOP_NOTE")
                SQLcmd.Parameters.Add("@EXOP_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOP_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i
                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE OTHER_EXPENALTY_DETAIL WHERE EXOPD_KEY=@EXOPD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOPD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO OTHER_EXPENALTY_DETAIL(EXOPD_KEY,EXOPD_EXOPKEY,EXOPD_SOURCENO,EXOPD_EXOPDKEY,EXOPD_DESC,EXOPD_DEDUCTIBLE,EXOPD_AMOUNT,EXOPD_NOTE,RowIndex) VALUES (@EXOPD_KEY,@EXOPD_EXOPKEY,@EXOPD_SOURCENO,@EXOPD_EXOPDKEY,@EXOPD_DESC,@EXOPD_DEDUCTIBLE,@EXOPD_AMOUNT,@EXOPD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOPD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXOPD_EXOPKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOPD_EXOPKEY")
                    SQLcmd.Parameters.Add("@EXOPD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXOPD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXOPD_EXOPDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOPD_EXOPDKEY")
                    SQLcmd.Parameters.Add("@EXOPD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXOPD_DESC")
                    SQLcmd.Parameters.Add("@EXOPD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXOPD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXOPD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXOPD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXOPD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXOPD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_OTHER_EXPENSES(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE OTHER_EXPENSES WHERE EXO_KEY=@EXO_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXO_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO OTHER_EXPENSES(EXO_KEY,EXO_EXOKEY,EXO_SOURCENO,EXO_DESC,EXO_AMOUNT,EXO_DEDUCTIBLE,EXO_NOTE,EXO_DETAIL,RowIndex) VALUES (@EXO_KEY,@EXO_EXOKEY,@EXO_SOURCENO,@EXO_DESC,@EXO_AMOUNT,@EXO_DEDUCTIBLE,@EXO_NOTE,@EXO_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXO_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXO_EXOKEY", SqlDbType.Int).Value = dt.Rows(i)("EXO_EXOKEY")
                SQLcmd.Parameters.Add("@EXO_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXO_SOURCENO")
                SQLcmd.Parameters.Add("@EXO_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXO_DESC")
                SQLcmd.Parameters.Add("@EXO_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXO_AMOUNT")
                SQLcmd.Parameters.Add("@EXO_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXO_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXO_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXO_NOTE")
                SQLcmd.Parameters.Add("@EXO_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXO_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i
                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE OTHER_EXPENSES_DETAIL WHERE EXOD_KEY=@EXOD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO OTHER_EXPENSES_DETAIL(EXOD_KEY,EXOD_EXOKEY,EXOD_SOURCENO,EXOD_EXODKEY,EXOD_DESC,EXOD_DEDUCTIBLE,EXOD_AMOUNT,EXOD_NOTE,RowIndex) VALUES (@EXOD_KEY,@EXOD_EXOKEY,@EXOD_SOURCENO,@EXOD_EXODKEY,@EXOD_DESC,@EXOD_DEDUCTIBLE,@EXOD_AMOUNT,@EXOD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXOD_EXOKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOD_EXOKEY")
                    SQLcmd.Parameters.Add("@EXOD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXOD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXOD_EXODKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOD_EXODKEY")
                    SQLcmd.Parameters.Add("@EXOD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXOD_DESC")
                    SQLcmd.Parameters.Add("@EXOD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXOD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXOD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXOD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXOD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXOD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x
                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_OTHER_EXPROVISIONACC(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE OTHER_EXPROVISIONACC WHERE EXOPA_KEY=@EXOPA_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOPA_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO OTHER_EXPROVISIONACC(EXOPA_KEY,EXOPA_EXOPAKEY,EXOPA_SOURCENO,EXOPA_DESC,EXOPA_AMOUNT,EXOPA_DEDUCTIBLE,EXOPA_NOTE,EXOPA_DETAIL,RowIndex) VALUES (@EXOPA_KEY,@EXOPA_EXOPAKEY,@EXOPA_SOURCENO,@EXOPA_DESC,@EXOPA_AMOUNT,@EXOPA_DEDUCTIBLE,@EXOPA_NOTE,@EXOPA_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOPA_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXOPA_EXOPAKEY", SqlDbType.Int).Value = dt.Rows(i)("EXOPA_EXOPAKEY")
                SQLcmd.Parameters.Add("@EXOPA_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXOPA_SOURCENO")
                SQLcmd.Parameters.Add("@EXOPA_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXOPA_DESC")
                SQLcmd.Parameters.Add("@EXOPA_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXOPA_AMOUNT")
                SQLcmd.Parameters.Add("@EXOPA_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOPA_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXOPA_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXOPA_NOTE")
                SQLcmd.Parameters.Add("@EXOPA_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOPA_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE OTHER_EXPROVISIONACC_DETAIL WHERE EXOPAD_KEY=@EXOPAD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOPAD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO OTHER_EXPROVISIONACC_DETAIL(EXOPAD_KEY,EXOPAD_EXOPAKEY,EXOPAD_SOURCENO,EXOPAD_EXOPADKEY,EXOPAD_DESC,EXOPAD_DEDUCTIBLE,EXOPAD_AMOUNT,EXOPAD_NOTE,RowIndex) VALUES (@EXOPAD_KEY,@EXOPAD_EXOPAKEY,@EXOPAD_SOURCENO,@EXOPAD_EXOPADKEY,@EXOPAD_DESC,@EXOPAD_DEDUCTIBLE,@EXOPAD_AMOUNT,@EXOPAD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOPAD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXOPAD_EXOPAKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOPAD_EXOPAKEY")
                    SQLcmd.Parameters.Add("@EXOPAD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXOPAD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXOPAD_EXOPADKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOPAD_EXOPADKEY")
                    SQLcmd.Parameters.Add("@EXOPAD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXOPAD_DESC")
                    SQLcmd.Parameters.Add("@EXOPAD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXOPAD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXOPAD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXOPAD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXOPAD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXOPAD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x
                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_OTHER_EXRLOSSFOREIGN(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE OTHER_EXRLOSSFOREIGN WHERE EXOR_KEY=@EXOR_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOR_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO OTHER_EXRLOSSFOREIGN(EXOR_KEY,EXOR_EXORKEY,EXOR_SOURCENO,EXOR_DESC,EXOR_AMOUNT,EXOR_DEDUCTIBLE,EXOR_NOTE,EXOR_DETAIL,RowIndex) VALUES (@EXOR_KEY,@EXOR_EXORKEY,@EXOR_SOURCENO,@EXOR_DESC,@EXOR_AMOUNT,@EXOR_DEDUCTIBLE,@EXOR_NOTE,@EXOR_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOR_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXOR_EXORKEY", SqlDbType.Int).Value = dt.Rows(i)("EXOR_EXORKEY")
                SQLcmd.Parameters.Add("@EXOR_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXOR_SOURCENO")
                SQLcmd.Parameters.Add("@EXOR_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXOR_DESC")
                SQLcmd.Parameters.Add("@EXOR_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXOR_AMOUNT")
                SQLcmd.Parameters.Add("@EXOR_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOR_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXOR_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXOR_NOTE")
                SQLcmd.Parameters.Add("@EXOR_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOR_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE OTHER_EXRLOSSFOREIGN_DETAIL WHERE EXORD_KEY=@EXORD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXORD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO OTHER_EXRLOSSFOREIGN_DETAIL(EXORD_KEY,EXORD_EXORKEY,EXORD_SOURCENO,EXORD_EXORDKEY,EXORD_DESC,EXORD_DEDUCTIBLE,EXORD_AMOUNT,EXORD_NOTE,RowIndex) VALUES (@EXORD_KEY,@EXORD_EXORKEY,@EXORD_SOURCENO,@EXORD_EXORDKEY,@EXORD_DESC,@EXORD_DEDUCTIBLE,@EXORD_AMOUNT,@EXORD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXORD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXORD_EXORKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXORD_EXORKEY")
                    SQLcmd.Parameters.Add("@EXORD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXORD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXORD_EXORDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXORD_EXORDKEY")
                    SQLcmd.Parameters.Add("@EXORD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXORD_DESC")
                    SQLcmd.Parameters.Add("@EXORD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXORD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXORD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXORD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXORD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXORD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x
                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_OTHER_EXRLOSSFOREIGNT(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE OTHER_EXRLOSSFOREIGNT WHERE EXORT_KEY=@EXORT_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXORT_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO OTHER_EXRLOSSFOREIGNT(EXORT_KEY,EXORT_EXORTKEY,EXORT_SOURCENO,EXORT_DESC,EXORT_AMOUNT,EXORT_DEDUCTIBLE,EXORT_NOTE,EXORT_DETAIL,RowIndex) VALUES (@EXORT_KEY,@EXORT_EXORTKEY,@EXORT_SOURCENO,@EXORT_DESC,@EXORT_AMOUNT,@EXORT_DEDUCTIBLE,@EXORT_NOTE,@EXORT_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXORT_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXORT_EXORTKEY", SqlDbType.Int).Value = dt.Rows(i)("EXORT_EXORTKEY")
                SQLcmd.Parameters.Add("@EXORT_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXORT_SOURCENO")
                SQLcmd.Parameters.Add("@EXORT_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXORT_DESC")
                SQLcmd.Parameters.Add("@EXORT_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXORT_AMOUNT")
                SQLcmd.Parameters.Add("@EXORT_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXORT_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXORT_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXORT_NOTE")
                SQLcmd.Parameters.Add("@EXORT_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXORT_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i
                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE OTHER_EXRLOSSFOREIGNT_DETAIL WHERE EXORTD_KEY=@EXORTD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXORTD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO OTHER_EXRLOSSFOREIGNT_DETAIL(EXORTD_KEY,EXORTD_EXORTKEY,EXORTD_SOURCENO,EXORTD_EXORTDKEY,EXORTD_DESC,EXORTD_DEDUCTIBLE,EXORTD_AMOUNT,EXORTD_NOTE,RowIndex) VALUES (@EXORTD_KEY,@EXORTD_EXORTKEY,@EXORTD_SOURCENO,@EXORTD_EXORTDKEY,@EXORTD_DESC,@EXORTD_DEDUCTIBLE,@EXORTD_AMOUNT,@EXORTD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXORTD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXORTD_EXORTKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXORTD_EXORTKEY")
                    SQLcmd.Parameters.Add("@EXORTD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXORTD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXORTD_EXORTDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXORTD_EXORTDKEY")
                    SQLcmd.Parameters.Add("@EXORTD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXORTD_DESC")
                    SQLcmd.Parameters.Add("@EXORTD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXORTD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXORTD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXORTD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXORTD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXORTD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x
                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_OTHER_EXURLOSSFOREIGN(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE OTHER_EXURLOSSFOREIGN WHERE EXOUR_KEY=@EXOUR_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOUR_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO OTHER_EXURLOSSFOREIGN(EXOUR_KEY,EXOUR_EXOURKEY,EXOUR_SOURCENO,EXOUR_DESC,EXOUR_AMOUNT,EXOUR_DEDUCTIBLE,EXOUR_NOTE,EXOUR_DETAIL,RowIndex) VALUES (@EXOUR_KEY,@EXOUR_EXOURKEY,@EXOUR_SOURCENO,@EXOUR_DESC,@EXOUR_AMOUNT,@EXOUR_DEDUCTIBLE,@EXOUR_NOTE,@EXOUR_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOUR_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXOUR_EXOURKEY", SqlDbType.Int).Value = dt.Rows(i)("EXOUR_EXOURKEY")
                SQLcmd.Parameters.Add("@EXOUR_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXOUR_SOURCENO")
                SQLcmd.Parameters.Add("@EXOUR_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXOUR_DESC")
                SQLcmd.Parameters.Add("@EXOUR_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXOUR_AMOUNT")
                SQLcmd.Parameters.Add("@EXOUR_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOUR_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXOUR_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXOUR_NOTE")
                SQLcmd.Parameters.Add("@EXOUR_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOUR_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE OTHER_EXURLOSSFOREIGN_DETAIL WHERE EXOURD_KEY=@EXOURD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOURD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO OTHER_EXURLOSSFOREIGN_DETAIL(EXOURD_KEY,EXOURD_EXOURKEY,EXOURD_SOURCENO,EXOURD_EXOURDKEY,EXOURD_DESC,EXOURD_DEDUCTIBLE,EXOURD_AMOUNT,EXOURD_NOTE,RowIndex) VALUES (@EXOURD_KEY,@EXOURD_EXOURKEY,@EXOURD_SOURCENO,@EXOURD_EXOURDKEY,@EXOURD_DESC,@EXOURD_DEDUCTIBLE,@EXOURD_AMOUNT,@EXOURD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOURD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXOURD_EXOURKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOURD_EXOURKEY")
                    SQLcmd.Parameters.Add("@EXOURD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXOURD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXOURD_EXOURDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOURD_EXOURDKEY")
                    SQLcmd.Parameters.Add("@EXOURD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXOURD_DESC")
                    SQLcmd.Parameters.Add("@EXOURD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXOURD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXOURD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXOURD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXOURD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXOURD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_OTHER_EXZAKAT(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                            ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE OTHER_EXZAKAT WHERE EXOZ_KEY=@EXOZ_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOZ_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO OTHER_EXZAKAT(EXOZ_KEY,EXOZ_EXOZKEY,EXOZ_SOURCENO,EXOZ_DESC,EXOZ_AMOUNT,EXOZ_DEDUCTIBLE,EXOZ_NOTE,EXOZ_DETAIL,RowIndex) VALUES (@EXOZ_KEY,@EXOZ_EXOZKEY,@EXOZ_SOURCENO,@EXOZ_DESC,@EXOZ_AMOUNT,@EXOZ_DEDUCTIBLE,@EXOZ_NOTE,@EXOZ_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOZ_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@EXOZ_EXOZKEY", SqlDbType.Int).Value = dt.Rows(i)("EXOZ_EXOZKEY")
                SQLcmd.Parameters.Add("@EXOZ_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("EXOZ_SOURCENO")
                SQLcmd.Parameters.Add("@EXOZ_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("EXOZ_DESC")
                SQLcmd.Parameters.Add("@EXOZ_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("EXOZ_AMOUNT")
                SQLcmd.Parameters.Add("@EXOZ_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOZ_DEDUCTIBLE")
                SQLcmd.Parameters.Add("@EXOZ_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("EXOZ_NOTE")
                SQLcmd.Parameters.Add("@EXOZ_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("EXOZ_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i
                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE OTHER_EXZAKAT_DETAIL WHERE EXOZD_KEY=@EXOZD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@EXOZD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO OTHER_EXZAKAT_DETAIL(EXOZD_KEY,EXOZD_EXOZKEY,EXOZD_SOURCENO,EXOZD_EXOZDKEY,EXOZD_DESC,EXOZD_DEDUCTIBLE,EXOZD_AMOUNT,EXOZD_NOTE,RowIndex) VALUES (@EXOZD_KEY,@EXOZD_EXOZKEY,@EXOZD_SOURCENO,@EXOZD_EXOZDKEY,@EXOZD_DESC,@EXOZD_DEDUCTIBLE,@EXOZD_AMOUNT,@EXOZD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@EXOZD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@EXOZD_EXOZKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOZD_EXOZKEY")
                    SQLcmd.Parameters.Add("@EXOZD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("EXOZD_SOURCENO")
                    SQLcmd.Parameters.Add("@EXOZD_EXOZDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("EXOZD_EXOZDKEY")
                    SQLcmd.Parameters.Add("@EXOZD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("EXOZD_DESC")
                    SQLcmd.Parameters.Add("@EXOZD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = dt_child.Rows(x)("EXOZD_DEDUCTIBLE")
                    SQLcmd.Parameters.Add("@EXOZD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("EXOZD_AMOUNT")
                    SQLcmd.Parameters.Add("@EXOZD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("EXOZD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_OTHER_INCOME(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE OTHER_INCOME WHERE OI_KEY=@OI_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@OI_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO OTHER_INCOME(OI_KEY,OI_OIKEY,OI_SOURCENO,OI_DESC,OI_AMOUNT,OI_NOTE,OI_DETAIL,RowIndex) VALUES (@OI_KEY,@OI_OIKEY,@OI_SOURCENO,@OI_DESC,@OI_AMOUNT,@OI_NOTE,@OI_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@OI_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@OI_OIKEY", SqlDbType.Int).Value = dt.Rows(i)("OI_OIKEY")
                SQLcmd.Parameters.Add("@OI_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("OI_SOURCENO")
                SQLcmd.Parameters.Add("@OI_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("OI_DESC")
                SQLcmd.Parameters.Add("@OI_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("OI_AMOUNT")
                SQLcmd.Parameters.Add("@OI_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("OI_NOTE")
                SQLcmd.Parameters.Add("@OI_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("OI_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE OTHER_INCOME_DETAIL WHERE OID_KEY=@OID_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@OID_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO OTHER_INCOME_DETAIL(OID_KEY,OID_OIKEY,OID_SOURCENO,OID_OIDKEY,OID_DESC,OID_AMOUNT,OID_NOTE,RowIndex) VALUES (@OID_KEY,@OID_OIKEY,@OID_SOURCENO,@OID_OIDKEY,@OID_DESC,@OID_AMOUNT,@OID_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@OID_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@OID_OIKEY", SqlDbType.Int).Value = dt_child.Rows(x)("OID_OIKEY")
                    SQLcmd.Parameters.Add("@OID_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("OID_SOURCENO")
                    SQLcmd.Parameters.Add("@OID_OIDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("OID_OIDKEY")
                    SQLcmd.Parameters.Add("@OID_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("OID_DESC")
                    SQLcmd.Parameters.Add("@OID_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("OID_AMOUNT")
                    SQLcmd.Parameters.Add("@OID_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("OID_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_PLFST_CLOSESTOCK(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE PLFST_CLOSESTOCK WHERE PLFCS_KEY=@PLFCS_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PLFCS_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO PLFST_CLOSESTOCK(PLFCS_KEY,PLFCS_PLFCSKEY,PLFCS_SOURCENO,PLFCS_DESC,PLFCS_AMOUNT,PLFCS_NOTE,PLFCS_DETAIL,RowIndex) VALUES (@PLFCS_KEY,@PLFCS_PLFCSKEY,@PLFCS_SOURCENO,@PLFCS_DESC,@PLFCS_AMOUNT,@PLFCS_NOTE,@PLFCS_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@PLFCS_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@PLFCS_PLFCSKEY", SqlDbType.Int).Value = dt.Rows(i)("PLFCS_PLFCSKEY")
                SQLcmd.Parameters.Add("@PLFCS_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("PLFCS_SOURCENO")
                SQLcmd.Parameters.Add("@PLFCS_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("PLFCS_DESC")
                SQLcmd.Parameters.Add("@PLFCS_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("PLFCS_AMOUNT")
                SQLcmd.Parameters.Add("@PLFCS_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("PLFCS_NOTE")
                SQLcmd.Parameters.Add("@PLFCS_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("PLFCS_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE PLFST_CLOSESTOCK_DETAIL WHERE PLFCSD_KEY=@PLFCSD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@PLFCSD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO PLFST_CLOSESTOCK_DETAIL(PLFCSD_KEY,PLFCSD_PLFCSKEY,PLFCSD_SOURCENO,PLFCSD_PLFCSDKEY,PLFCSD_DESC,PLFCSD_AMOUNT,PLFCSD_NOTE,RowIndex) VALUES (@PLFCSD_KEY,@PLFCSD_PLFCSKEY,@PLFCSD_SOURCENO,@PLFCSD_PLFCSDKEY,@PLFCSD_DESC,@PLFCSD_AMOUNT,@PLFCSD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@PLFCSD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@PLFCSD_PLFCSKEY", SqlDbType.Int).Value = dt_child.Rows(x)("PLFCSD_PLFCSKEY")
                    SQLcmd.Parameters.Add("@PLFCSD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("PLFCSD_SOURCENO")
                    SQLcmd.Parameters.Add("@PLFCSD_PLFCSDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("PLFCSD_PLFCSDKEY")
                    SQLcmd.Parameters.Add("@PLFCSD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("PLFCSD_DESC")
                    SQLcmd.Parameters.Add("@PLFCSD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("PLFCSD_AMOUNT")
                    SQLcmd.Parameters.Add("@PLFCSD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("PLFCSD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_PLFST_OPENSTOCK(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE PLFST_OPENSTOCK WHERE PLFOS_KEY=@PLFOS_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PLFOS_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO PLFST_OPENSTOCK(PLFOS_KEY,PLFOS_PLFOSKEY,PLFOS_SOURCENO,PLFOS_DESC,PLFOS_AMOUNT,PLFOS_NOTE,PLFOS_DETAIL,RowIndex) VALUES (@PLFOS_KEY,@PLFOS_PLFOSKEY,@PLFOS_SOURCENO,@PLFOS_DESC,@PLFOS_AMOUNT,@PLFOS_NOTE,@PLFOS_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@PLFOS_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@PLFOS_PLFOSKEY", SqlDbType.Int).Value = dt.Rows(i)("PLFOS_PLFOSKEY")
                SQLcmd.Parameters.Add("@PLFOS_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("PLFOS_SOURCENO")
                SQLcmd.Parameters.Add("@PLFOS_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("PLFOS_DESC")
                SQLcmd.Parameters.Add("@PLFOS_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("PLFOS_AMOUNT")
                SQLcmd.Parameters.Add("@PLFOS_NOTE", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(dt.Rows(i)("PLFOS_NOTE")), "", dt.Rows(i)("PLFOS_NOTE"))
                SQLcmd.Parameters.Add("@PLFOS_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("PLFOS_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE PLFST_OPENSTOCK_DETAIL WHERE PLFOSD_KEY=@PLFOSD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@PLFOSD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO PLFST_OPENSTOCK_DETAIL(PLFOSD_KEY,PLFOSD_PLFOSKEY,PLFOSD_SOURCENO,PLFOSD_PLFOSDKEY,PLFOSD_DESC,PLFOSD_AMOUNT,PLFOSD_NOTE,RowIndex) VALUES (@PLFOSD_KEY,@PLFOSD_PLFOSKEY,@PLFOSD_SOURCENO,@PLFOSD_PLFOSDKEY,@PLFOSD_DESC,@PLFOSD_AMOUNT,@PLFOSD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@PLFOSD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@PLFOSD_PLFOSKEY", SqlDbType.Int).Value = dt_child.Rows(x)("PLFOSD_PLFOSKEY")
                    SQLcmd.Parameters.Add("@PLFOSD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("PLFOSD_SOURCENO")
                    SQLcmd.Parameters.Add("@PLFOSD_PLFOSDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("PLFOSD_PLFOSDKEY")
                    SQLcmd.Parameters.Add("@PLFOSD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("PLFOSD_DESC")
                    SQLcmd.Parameters.Add("@PLFOSD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("PLFOSD_AMOUNT")
                    SQLcmd.Parameters.Add("@PLFOSD_NOTE", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(dt_child.Rows(x)("PLFOSD_NOTE")), "", dt_child.Rows(x)("PLFOSD_NOTE"))
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_PLFST_PURCHASE(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE PLFST_PURCHASE WHERE PLFPUR_KEY=@PLFPUR_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PLFPUR_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO PLFST_PURCHASE(PLFPUR_KEY,PLFPUR_PLFPURKEY,PLFPUR_SOURCENO,PLFPUR_DESC,PLFPUR_AMOUNT,PLFPUR_NOTE,PLFPUR_DETAIL,RowIndex) VALUES (@PLFPUR_KEY,@PLFPUR_PLFPURKEY,@PLFPUR_SOURCENO,@PLFPUR_DESC,@PLFPUR_AMOUNT,@PLFPUR_NOTE,@PLFPUR_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@PLFPUR_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@PLFPUR_PLFPURKEY", SqlDbType.Int).Value = dt.Rows(i)("PLFPUR_PLFPURKEY")
                SQLcmd.Parameters.Add("@PLFPUR_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("PLFPUR_SOURCENO")
                SQLcmd.Parameters.Add("@PLFPUR_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("PLFPUR_DESC")
                SQLcmd.Parameters.Add("@PLFPUR_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("PLFPUR_AMOUNT")
                SQLcmd.Parameters.Add("@PLFPUR_NOTE", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("PLFPUR_NOTE")
                SQLcmd.Parameters.Add("@PLFPUR_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("PLFPUR_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE PLFST_PURCHASE_DETAIL WHERE PLFPURD_KEY=@PLFPURD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@PLFPURD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO PLFST_PURCHASE_DETAIL(PLFPURD_KEY,PLFPURD_PLFPURKEY,PLFPURD_SOURCENO,PLFPURD_PLFPURDKEY,PLFPURD_DESC,PLFPURD_AMOUNT,PLFPURD_NOTE,RowIndex) VALUES (@PLFPURD_KEY,@PLFPURD_PLFPURKEY,@PLFPURD_SOURCENO,@PLFPURD_PLFPURDKEY,@PLFPURD_DESC,@PLFPURD_AMOUNT,@PLFPURD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@PLFPURD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@PLFPURD_PLFPURKEY", SqlDbType.Int).Value = dt_child.Rows(x)("PLFPURD_PLFPURKEY")
                    SQLcmd.Parameters.Add("@PLFPURD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("PLFPURD_SOURCENO")
                    SQLcmd.Parameters.Add("@PLFPURD_PLFPURDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("PLFPURD_PLFPURDKEY")
                    SQLcmd.Parameters.Add("@PLFPURD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("PLFPURD_DESC")
                    SQLcmd.Parameters.Add("@PLFPURD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("PLFPURD_AMOUNT")
                    SQLcmd.Parameters.Add("@PLFPURD_NOTE", SqlDbType.NVarChar, 3000).Value = dt_child.Rows(x)("PLFPURD_NOTE")
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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

    Public Function Save_PLFST_SALES(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal dt_child As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE PLFST_SALES WHERE PLFS_KEY=@PLFS_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PLFS_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO PLFST_SALES(PLFS_KEY,PLFS_PLFSKEY,PLFS_SOURCENO,PLFS_DESC,PLFS_AMOUNT,PLFS_NOTE,PLFS_DETAIL,RowIndex) VALUES (@PLFS_KEY,@PLFS_PLFSKEY,@PLFS_SOURCENO,@PLFS_DESC,@PLFS_AMOUNT,@PLFS_NOTE,@PLFS_DETAIL,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@PLFS_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@PLFS_PLFSKEY", SqlDbType.Int).Value = dt.Rows(i)("PLFS_PLFSKEY")
                SQLcmd.Parameters.Add("@PLFS_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("PLFS_SOURCENO")
                SQLcmd.Parameters.Add("@PLFS_DESC", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("PLFS_DESC")
                SQLcmd.Parameters.Add("@PLFS_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("PLFS_AMOUNT")
                SQLcmd.Parameters.Add("@PLFS_NOTE", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(dt.Rows(i)("PLFS_NOTE")), "", dt.Rows(i)("PLFS_NOTE"))
                SQLcmd.Parameters.Add("@PLFS_DETAIL", SqlDbType.NVarChar, 30).Value = dt.Rows(i)("PLFS_DETAIL")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i

                ListofCmd.Add(SQLcmd)

            Next

            If dt_child.Rows.Count > 0 Then
                'THIS IS CHILD

                StrSQL = "DELETE PLFST_SALES_DETAIL WHERE PLFSD_KEY=@PLFSD_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@PLFSD_KEY", SqlDbType.Int).Value = PNL_Key
                ListofCmd.Add(SQLcmd)

                For x As Integer = 0 To dt_child.Rows.Count - 1

                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO PLFST_SALES_DETAIL(PLFSD_KEY,PLFSD_PLFSKEY,PLFSD_SOURCENO,PLFSD_PLFSDKEY,PLFSD_DESC,PLFSD_AMOUNT,PLFSD_NOTE,RowIndex) VALUES (@PLFSD_KEY,@PLFSD_PLFSKEY,@PLFSD_SOURCENO,@PLFSD_PLFSDKEY,@PLFSD_DESC,@PLFSD_AMOUNT,@PLFSD_NOTE,@RowIndex)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@PLFSD_KEY", SqlDbType.Int).Value = PNL_Key
                    SQLcmd.Parameters.Add("@PLFSD_PLFSKEY", SqlDbType.Int).Value = dt_child.Rows(x)("PLFSD_PLFSKEY")
                    SQLcmd.Parameters.Add("@PLFSD_SOURCENO", SqlDbType.Int).Value = dt_child.Rows(x)("PLFSD_SOURCENO")
                    SQLcmd.Parameters.Add("@PLFSD_PLFSDKEY", SqlDbType.Int).Value = dt_child.Rows(x)("PLFSD_PLFSDKEY")
                    SQLcmd.Parameters.Add("@PLFSD_DESC", SqlDbType.NVarChar, 255).Value = dt_child.Rows(x)("PLFSD_DESC")
                    SQLcmd.Parameters.Add("@PLFSD_AMOUNT", SqlDbType.NVarChar, 25).Value = dt_child.Rows(x)("PLFSD_AMOUNT")
                    SQLcmd.Parameters.Add("@PLFSD_NOTE", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(dt_child.Rows(x)("PLFSD_NOTE")), "", dt_child.Rows(x)("PLFSD_NOTE"))
                    SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = x

                    ListofCmd.Add(SQLcmd)

                Next

            End If

            Return True
        Catch ex As Exception
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
    Public Function Save_RENTAL_INCOME(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE RENTAL_INCOME WHERE RI_KEY=@RI_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@RI_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO RENTAL_INCOME(RI_KEY,RI_RENTKEY,RI_TYPE,RI_ADDRESS,RI_DATE,RI_AMOUNT,RI_SOURCENO,RI_STATUS4d,RI_DATE_END,RowIndex) VALUES (@RI_KEY,@RI_RENTKEY,@RI_TYPE,@RI_ADDRESS,@RI_DATE,@RI_AMOUNT,@RI_SOURCENO,@RI_STATUS4d,@RI_DATE_END,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@RI_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@RI_RENTKEY", SqlDbType.Int).Value = dt.Rows(i)("RI_RENTKEY")
                SQLcmd.Parameters.Add("@RI_TYPE", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("RI_TYPE")
                SQLcmd.Parameters.Add("@RI_ADDRESS", SqlDbType.NVarChar, 3000).Value = dt.Rows(i)("RI_ADDRESS")
                SQLcmd.Parameters.Add("@RI_DATE", SqlDbType.DateTime).Value = dt.Rows(i)("RI_DATE")
                SQLcmd.Parameters.Add("@RI_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("RI_AMOUNT")
                SQLcmd.Parameters.Add("@RI_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("RI_SOURCENO")
                SQLcmd.Parameters.Add("@RI_STATUS4d", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("RI_STATUS4d")
                SQLcmd.Parameters.Add("@RI_DATE_END", SqlDbType.DateTime).Value = dt.Rows(i)("RI_DATE_END")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i
                ListofCmd.Add(SQLcmd)

            Next

            Return True
        Catch ex As Exception
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
    Public Function Save_EXEMPT_DIVIDEND(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal oConn As SqlConnection, _
                                        ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE EXEMPT_DIVIDEND WHERE ED_KEY=@ED_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ED_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO EXEMPT_DIVIDEND(ED_KEY,ED_EDKEY,ED_DATE,ED_COMPANY,ED_AMOUNT,ED_TIERSTATUS,ED_SOURCENO,RowIndex) VALUES (@ED_KEY,@ED_EDKEY,@ED_DATE,@ED_COMPANY,@ED_AMOUNT,@ED_TIERSTATUS,@ED_SOURCENO,@RowIndex)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@ED_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@ED_EDKEY", SqlDbType.Int).Value = dt.Rows(i)("ED_EDKEY")
                SQLcmd.Parameters.Add("@ED_DATE", SqlDbType.DateTime).Value = dt.Rows(i)("ED_DATE")
                SQLcmd.Parameters.Add("@ED_COMPANY", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("ED_COMPANY")
                SQLcmd.Parameters.Add("@ED_AMOUNT", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("ED_AMOUNT")
                SQLcmd.Parameters.Add("@ED_TIERSTATUS", SqlDbType.NVarChar, 50).Value = dt.Rows(i)("ED_TIERSTATUS")
                SQLcmd.Parameters.Add("@ED_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("ED_SOURCENO")
                SQLcmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = i


                ListofCmd.Add(SQLcmd)

            Next

            Return True
        Catch ex As Exception
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
    Public Function Save_DIVIDEND_INCOME(ByVal PNL_Key As Integer, ByVal dt As DataTable, ByVal isDisclose As Boolean, ByVal oConn As SqlConnection, _
                                       ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If ListofCmd Is Nothing Then
                ListofCmd = New List(Of SqlCommand)
            End If

            Dim StrSQL As String
            Dim SQLcmd As SqlCommand

            StrSQL = "DELETE DIVIDEND_INCOME WHERE DI_KEY=@DI_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@DI_KEY", SqlDbType.Int).Value = PNL_Key

            ListofCmd.Add(SQLcmd)

            For i As Integer = 0 To dt.Rows.Count - 1
                SQLcmd = Nothing
                StrSQL = "INSERT INTO DIVIDEND_INCOME(DI_KEY,DI_DIVIDENDKEY,DI_DATE,DI_COMPANY,DI_GROSS,DI_TAX,DI_NET,DI_WARANT_NO,DI_CHKREGROSS,DI_TAXRATE,DI_REGROSS,DI_TAXDEDUCTION,DI_NETDEDUCTION,DI_ENDDATE,DI_TRATE,DI_SOURCENO,DI_DISCLOSE,DI_TRANSFER) VALUES (@DI_KEY,@DI_DIVIDENDKEY,@DI_DATE,@DI_COMPANY,@DI_GROSS,@DI_TAX,@DI_NET,@DI_WARANT_NO,@DI_CHKREGROSS,@DI_TAXRATE,@DI_REGROSS,@DI_TAXDEDUCTION,@DI_NETDEDUCTION,@DI_ENDDATE,@DI_TRATE,@DI_SOURCENO,@DI_DISCLOSE,@DI_TRANSFER)"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = StrSQL
                SQLcmd.Parameters.Add("@DI_KEY", SqlDbType.Int).Value = PNL_Key
                SQLcmd.Parameters.Add("@DI_DIVIDENDKEY", SqlDbType.Int).Value = dt.Rows(i)("DI_DIVIDENDKEY")
                SQLcmd.Parameters.Add("@DI_DATE", SqlDbType.DateTime).Value = dt.Rows(i)("DI_DATE")

                SQLcmd.Parameters.Add("@DI_COMPANY", SqlDbType.NVarChar, 255).Value = dt.Rows(i)("DI_COMPANY")
                SQLcmd.Parameters.Add("@DI_GROSS", SqlDbType.Decimal).Value = dt.Rows(i)("DI_GROSS")
                SQLcmd.Parameters.Add("@DI_TAX", SqlDbType.Decimal).Value = dt.Rows(i)("DI_TAX")
                SQLcmd.Parameters.Add("@DI_NET", SqlDbType.Decimal).Value = dt.Rows(i)("DI_NET")
                SQLcmd.Parameters.Add("@DI_WARANT_NO", SqlDbType.NVarChar, 50).Value = dt.Rows(i)("DI_WARANT_NO")
                SQLcmd.Parameters.Add("@DI_CHKREGROSS", SqlDbType.NVarChar, 3).Value = dt.Rows(i)("DI_CHKREGROSS")
                SQLcmd.Parameters.Add("@DI_TAXRATE", SqlDbType.Decimal).Value = dt.Rows(i)("DI_TAXRATE")
                SQLcmd.Parameters.Add("@DI_REGROSS", SqlDbType.Decimal).Value = dt.Rows(i)("DI_REGROSS")
                SQLcmd.Parameters.Add("@DI_TAXDEDUCTION", SqlDbType.Decimal).Value = dt.Rows(i)("DI_TAXDEDUCTION")
                SQLcmd.Parameters.Add("@DI_NETDEDUCTION", SqlDbType.Decimal).Value = dt.Rows(i)("DI_NETDEDUCTION")
                SQLcmd.Parameters.Add("@DI_ENDDATE", SqlDbType.DateTime).Value = dt.Rows(i)("DI_ENDDATE")
                SQLcmd.Parameters.Add("@DI_TRATE", SqlDbType.Decimal).Value = dt.Rows(i)("DI_TRATE")
                SQLcmd.Parameters.Add("@DI_SOURCENO", SqlDbType.Int).Value = dt.Rows(i)("DI_SOURCENO")
                SQLcmd.Parameters.Add("@DI_DISCLOSE", SqlDbType.NVarChar, 3).Value = IIf(isDisclose = True, "Yes", "No")
                SQLcmd.Parameters.Add("@DI_TRANSFER", SqlDbType.NVarChar, 25).Value = dt.Rows(i)("DI_TRANSFER")

                ListofCmd.Add(SQLcmd)

            Next

            Return True
        Catch ex As Exception
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


#End Region
#Region "OTHER"

    Public Function Save_UserNote(ByVal Name As String, ByVal Note As String, _
                                  ByRef ReturnID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "INSERT INTO USER_NOTE (PCName,Name,Datetime,Note) VALUES (@PCName,@Name,@Datetime,@Note)"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PCName", SqlDbType.NVarChar, 250).Value = My.Computer.Name
            SQLcmd.Parameters.Add("@Name", SqlDbType.NVarChar, 3).Value = Name
            SQLcmd.Parameters.Add("@Datetime", SqlDbType.DateTime).Value = Now
            SQLcmd.Parameters.Add("@Note", SqlDbType.NVarChar, 4000).Value = Note

            Return ADO.ExecuteSQLCmd(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog, ReturnID)
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
            Return False
        End Try
    End Function
    Public Function Save_DeemedInterest_Rate(ByVal YA As Integer, _
                                             ByVal Jan As Decimal, ByVal Feb As Decimal, ByVal Mac As Decimal, ByVal Apr As Decimal, _
                                             ByVal May As Decimal, ByVal Jun As Decimal, ByVal Jul As Decimal, ByVal Aug As Decimal, _
                                             ByVal Sep As Decimal, ByVal Oct As Decimal, ByVal Nov As Decimal, ByVal Dec As Decimal, _
                                             Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "INSERT INTO DEEMED_INTEREST_RATE (YA,Jan,Feb,Mac,Apr,May,Jun,Jul,Aug,Sep,Oct,Nov,Dec) VALUES (@YA,@Jan,@Feb,@Mac,@Apr,@May,@Jun,@Jul,@Aug,@Sep,@Oct,@Nov,@Dec)"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = YA
            SQLcmd.Parameters.Add("@Jan", SqlDbType.Decimal).Value = Jan
            SQLcmd.Parameters.Add("@Feb", SqlDbType.Decimal).Value = Feb
            SQLcmd.Parameters.Add("@Mac", SqlDbType.Decimal).Value = Mac
            SQLcmd.Parameters.Add("@Apr", SqlDbType.Decimal).Value = Apr
            SQLcmd.Parameters.Add("@May", SqlDbType.Decimal).Value = May
            SQLcmd.Parameters.Add("@Jun", SqlDbType.Decimal).Value = Jun
            SQLcmd.Parameters.Add("@Jul", SqlDbType.Decimal).Value = Jul
            SQLcmd.Parameters.Add("@Aug", SqlDbType.Decimal).Value = Aug
            SQLcmd.Parameters.Add("@Sep", SqlDbType.Decimal).Value = Sep
            SQLcmd.Parameters.Add("@Oct", SqlDbType.Decimal).Value = Oct
            SQLcmd.Parameters.Add("@Nov", SqlDbType.Decimal).Value = Nov
            SQLcmd.Parameters.Add("@Dec", SqlDbType.Decimal).Value = Dec

            Return ADO.ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
    Public Function Save_REPORT1_AI_DETAIL(ByVal R_KEY As Integer, ByVal RD_HEARDERNO As Integer, ByVal R_RKEY As String, _
                                  ByVal RD_SOURCENO As Integer, ByVal RD_RDKEY As Integer, ByVal RD_DESC As String, _
                                  ByVal RD_AMOUNT As String, ByVal RD_NOTE As String, _
                                  Optional ErrorLog As clsError = Nothing) As Boolean
        Try

            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "INSERT INTO REPORT1_AI(R_KEY,RD_HEARDERNO,R_RKEY,RD_SOURCENO,RD_RDKEY,RD_DESC,RD_AMOUNT,RD_NOTE) VALUES (@R_KEY,@RD_HEARDERNO,@R_RKEY,@RD_SOURCENO,@RD_RDKEY,@RD_DESC,@RD_AMOUNT,@RD_NOTE)"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@R_KEY", SqlDbType.Int).Value = R_KEY
            SQLcmd.Parameters.Add("@RD_HEARDERNO", SqlDbType.Int).Value = RD_HEARDERNO
            SQLcmd.Parameters.Add("@R_RKEY", SqlDbType.Int).Value = R_RKEY
            SQLcmd.Parameters.Add("@RD_SOURCENO", SqlDbType.Int).Value = RD_RDKEY
            SQLcmd.Parameters.Add("@RD_RDKEY", SqlDbType.Int).Value = RD_SOURCENO
            SQLcmd.Parameters.Add("@RD_DESC", SqlDbType.NVarChar, 255).Value = RD_DESC
            SQLcmd.Parameters.Add("@RD_AMOUNT", SqlDbType.NVarChar, 35).Value = RD_AMOUNT
            SQLcmd.Parameters.Add("@RD_NOTE", SqlDbType.NVarChar, 50).Value = RD_NOTE

            Return ADO.ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
    Public Function Save_Report1_AI(ByVal R_KEY As Integer, ByVal R_HEARDERNO As Integer, ByVal R_HEARDER As String, _
                                   ByVal R_RKEY As Integer, ByVal R_SOURCENO As Integer, ByVal R_DESC As String, _
                                   ByVal R_AMOUNT As String, ByVal R_NOTE As String, _
                                   ByVal R_DETAIL As String, ByVal RPT_STotal As Integer, _
                                   Optional ErrorLog As clsError = Nothing) As Boolean
        Try

            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "INSERT INTO REPORT1_AI(R_KEY,R_HEARDERNO,R_HEARDER,R_RKEY,R_SOURCENO,R_DESC,R_AMOUNT,R_NOTE,R_DETAIL,RPT_STotal) VALUES (@R_KEY,@R_HEARDERNO,@R_HEARDER,@R_RKEY,@R_SOURCENO,@R_DESC,@R_AMOUNT,@R_NOTE,@R_DETAIL,@RPT_STotal)"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@R_KEY", SqlDbType.Int).Value = R_KEY
            SQLcmd.Parameters.Add("@R_HEARDERNO", SqlDbType.Int).Value = R_HEARDERNO
            SQLcmd.Parameters.Add("@R_HEARDER", SqlDbType.NVarChar, 255).Value = R_HEARDER
            SQLcmd.Parameters.Add("@R_RKEY", SqlDbType.Int).Value = R_RKEY
            SQLcmd.Parameters.Add("@R_SOURCENO", SqlDbType.Int).Value = R_SOURCENO
            SQLcmd.Parameters.Add("@R_DESC", SqlDbType.NVarChar, 255).Value = R_DESC
            SQLcmd.Parameters.Add("@R_AMOUNT", SqlDbType.NVarChar, 25).Value = R_AMOUNT
            SQLcmd.Parameters.Add("@R_NOTE", SqlDbType.NVarChar, 3000).Value = R_NOTE
            SQLcmd.Parameters.Add("@R_DETAIL", SqlDbType.NVarChar, 50).Value = R_DETAIL
            SQLcmd.Parameters.Add("@RPT_STotal", SqlDbType.Int).Value = RPT_STotal

            Return ADO.ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
    Public Function Save_REPORT_AI_DETAIL(ByVal R_KEY As Integer, ByVal RD_HEARDERNO As Integer, ByVal R_RKEY As String, _
                                   ByVal RD_SOURCENO As Integer, ByVal RD_RDKEY As Integer, ByVal RD_DESC As String, ByVal RD_DEDUCTIBLE As String, _
                                   ByVal RD_AMOUNT As String, ByVal RD_NOTE As String, _
                                   Optional ErrorLog As clsError = Nothing) As Boolean
        Try

            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "INSERT INTO REPORT_AI(R_KEY,RD_HEARDERNO,R_RKEY,RD_SOURCENO,RD_RDKEY,RD_DESC,RD_DEDUCTIBLE,RD_AMOUNT,RD_NOTE) VALUES (@R_KEY,@RD_HEARDERNO,@R_RKEY,@RD_SOURCENO,@RD_RDKEY,@RD_DESC,@RD_DEDUCTIBLE,@RD_AMOUNT,@RD_NOTE)"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@R_KEY", SqlDbType.Int).Value = R_KEY
            SQLcmd.Parameters.Add("@RD_HEARDERNO", SqlDbType.Int).Value = RD_HEARDERNO
            SQLcmd.Parameters.Add("@R_RKEY", SqlDbType.Int).Value = R_RKEY
            SQLcmd.Parameters.Add("@RD_SOURCENO", SqlDbType.Int).Value = RD_RDKEY
            SQLcmd.Parameters.Add("@RD_RDKEY", SqlDbType.Int).Value = RD_SOURCENO
            SQLcmd.Parameters.Add("@RD_DESC", SqlDbType.NVarChar, 255).Value = RD_DESC
            SQLcmd.Parameters.Add("@RD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = RD_DEDUCTIBLE
            SQLcmd.Parameters.Add("@RD_AMOUNT", SqlDbType.NVarChar, 35).Value = RD_AMOUNT
            SQLcmd.Parameters.Add("@RD_NOTE", SqlDbType.NVarChar, 50).Value = RD_NOTE

            Return ADO.ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
    Public Function Save_Report_AI(ByVal R_KEY As Integer, ByVal R_HEARDERNO As Integer, ByVal R_HEARDER As String, _
                                   ByVal R_RKEY As Integer, ByVal R_SOURCENO As Integer, ByVal R_DESC As String, _
                                   ByVal R_AMOUNT As String, ByVal R_DEDUCTIBLE As String, ByVal R_NOTE As String, _
                                   ByVal R_DETAIL As String, ByVal RPT_STotal As Integer, _
                                   Optional ErrorLog As clsError = Nothing) As Boolean
        Try

            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "INSERT INTO REPORT_AI(R_KEY,R_HEARDERNO,R_HEARDER,R_RKEY,R_SOURCENO,R_DESC,R_AMOUNT,R_DEDUCTIBLE,R_NOTE,R_DETAIL,RPT_STotal) VALUES (@R_KEY,@R_HEARDERNO,@R_HEARDER,@R_RKEY,@R_SOURCENO,@R_DESC,@R_AMOUNT,@R_DEDUCTIBLE,@R_NOTE,@R_DETAIL,@RPT_STotal)"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@R_KEY", SqlDbType.Int).Value = R_KEY
            SQLcmd.Parameters.Add("@R_HEARDERNO", SqlDbType.Int).Value = R_HEARDERNO
            SQLcmd.Parameters.Add("@R_HEARDER", SqlDbType.NVarChar, 255).Value = R_HEARDER
            SQLcmd.Parameters.Add("@R_RKEY", SqlDbType.Int).Value = R_RKEY
            SQLcmd.Parameters.Add("@R_SOURCENO", SqlDbType.Int).Value = R_SOURCENO
            SQLcmd.Parameters.Add("@R_DESC", SqlDbType.NVarChar, 255).Value = R_DESC
            SQLcmd.Parameters.Add("@R_AMOUNT", SqlDbType.NVarChar, 25).Value = R_AMOUNT
            SQLcmd.Parameters.Add("@R_DEDUCTIBLE", SqlDbType.NVarChar, 50).Value = R_DEDUCTIBLE
            SQLcmd.Parameters.Add("@R_NOTE", SqlDbType.NVarChar, 3000).Value = R_NOTE
            SQLcmd.Parameters.Add("@R_DETAIL", SqlDbType.NVarChar, 50).Value = R_DETAIL
            SQLcmd.Parameters.Add("@RPT_STotal", SqlDbType.Int).Value = RPT_STotal

            Return ADO.ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
    Public Function Save_Report_AI_BAL(ByVal NA_PL_NO As Integer, ByVal NA_REF_NO As String, ByVal NA_YA As String, _
                                       ByVal NA_SOURCE_NO As Integer, ByVal NA_HEADERNO As Integer, ByVal NA_DESC As String, _
                                       ByVal NA_DED_STATUS As String, ByVal NA_AMOUNT As String, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try

            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "INSERT INTO REPORT_AI_BAL (NA_PL_NO,NA_REF_NO,NA_YA,NA_SOURCE_NO,NA_HEADERNO,NA_DESC,NA_DED_STATUS,NA_AMOUNT) VALUES (@NA_PL_NO,@NA_REF_NO,@NA_YA,@NA_SOURCE_NO,@NA_HEADERNO,@NA_DESC,@NA_DED_STATUS,@NA_AMOUNT)"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NA_PL_NO", SqlDbType.Int).Value = NA_PL_NO
            SQLcmd.Parameters.Add("@NA_REF_NO", SqlDbType.NVarChar, 20).Value = NA_REF_NO
            SQLcmd.Parameters.Add("@NA_YA", SqlDbType.NVarChar, 5).Value = NA_YA
            SQLcmd.Parameters.Add("@NA_SOURCE_NO", SqlDbType.Int).Value = NA_SOURCE_NO
            SQLcmd.Parameters.Add("@NA_HEADERNO", SqlDbType.Int).Value = NA_HEADERNO
            SQLcmd.Parameters.Add("@NA_DESC", SqlDbType.NVarChar, 255).Value = NA_DESC
            SQLcmd.Parameters.Add("@NA_DED_STATUS", SqlDbType.NVarChar, 50).Value = NA_DED_STATUS
            SQLcmd.Parameters.Add("@NA_AMOUNT", SqlDbType.NVarChar, 50).Value = NA_AMOUNT

            Return ADO.ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
#End Region
#Region "MOVEMENT"
    Public Function Save_MovementComplex(ByVal RefNo As String, ByVal YA As String, ByVal Title As String, _
                                    ByVal PeriodEnd As DateTime, ByVal YearEnded As DateTime, _
                                    ByVal BalanceStart As DateTime, ByVal BalanceEnd As DateTime, _
                                    ByVal MM_GENERAL_START As Decimal, ByVal MM_SPECIFIC_ALLOWABLE_START As Decimal, _
                                    ByVal MM_SPECIFIC_NONALLOWABLE_START As Decimal, _
                                    ByVal NoteStart As String, ByVal NoteEnd As String, _
                                    ByVal MM_GENERAL_END As Decimal, ByVal MM_SPECIFIC_ALLOWABLE_END As Decimal, ByVal MM_SPECIFIC_NONALLOWABLE_END As Decimal, ByVal MM_ADD_DEDUCT_AMOUNT As Decimal, _
                                    ByVal ds As DataSet, _
                                    ByRef ReturnID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection
            Dim ListofCmd As List(Of SqlCommand)
            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim tmpID As Decimal = 0


            Dim StrSQL As String = "INSERT INTO MOVEMENT_COMPLEX (MM_REFNO,MM_YA,MM_TITLE,MM_PERIOD_ENDED,MM_YEAR_ENDED,MM_BALANCE_START,MM_BALANCE_END,MM_GENERAL_START,MM_SPECIFIC_ALLOWABLE_START,MM_SPECIFIC_NONALLOWABLE_START,MM_NOTE_START,MM_NOTE_END,MM_GENERAL_END,MM_SPECIFIC_ALLOWABLE_END,MM_SPECIFIC_NONALLOWABLE_END,ModifiedBy,ModifiedDateTime,MM_ADD_DEDUCT_AMOUNT) VALUES (@MM_REFNO,@MM_YA,@MM_TITLE,@MM_PERIOD_ENDED,@MM_YEAR_ENDED,@MM_BALANCE_START,@MM_BALANCE_END,@MM_GENERAL_START,@MM_SPECIFIC_ALLOWABLE_START,@MM_SPECIFIC_NONALLOWABLE_START,@MM_NOTE_START,@MM_NOTE_END,@MM_GENERAL_END,@MM_SPECIFIC_ALLOWABLE_END,@MM_SPECIFIC_NONALLOWABLE_END,@ModifiedBy,@ModifiedDateTime,@MM_ADD_DEDUCT_AMOUNT)"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@MM_REFNO", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@MM_YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@MM_TITLE", SqlDbType.NVarChar, 250).Value = IIf(Title Is Nothing, "", Title)
            SQLcmd.Parameters.Add("@MM_PERIOD_ENDED", SqlDbType.DateTime).Value = IIf(IsDBNull(PeriodEnd), Now, PeriodEnd)
            SQLcmd.Parameters.Add("@MM_YEAR_ENDED", SqlDbType.DateTime).Value = IIf(IsDBNull(YearEnded), Now, YearEnded)
            SQLcmd.Parameters.Add("@MM_BALANCE_START", SqlDbType.DateTime).Value = IIf(IsDBNull(BalanceStart), Now, BalanceStart)
            SQLcmd.Parameters.Add("@MM_BALANCE_END", SqlDbType.DateTime).Value = IIf(IsDBNull(BalanceEnd), Now, BalanceEnd)
            SQLcmd.Parameters.Add("@MM_GENERAL_START", SqlDbType.Decimal).Value = IIf(IsNumeric(MM_GENERAL_START) = False, 0, MM_GENERAL_START)
            SQLcmd.Parameters.Add("@MM_SPECIFIC_ALLOWABLE_START", SqlDbType.Decimal).Value = IIf(IsNumeric(MM_SPECIFIC_ALLOWABLE_START) = False, 0, MM_SPECIFIC_ALLOWABLE_START)
            SQLcmd.Parameters.Add("@MM_SPECIFIC_NONALLOWABLE_START", SqlDbType.Decimal).Value = IIf(IsNumeric(MM_SPECIFIC_NONALLOWABLE_START) = False, 0, MM_SPECIFIC_NONALLOWABLE_START)
            SQLcmd.Parameters.Add("@MM_NOTE_START", SqlDbType.NVarChar, 250).Value = IIf(NoteStart Is Nothing, "", NoteStart)
            SQLcmd.Parameters.Add("@MM_NOTE_END", SqlDbType.NVarChar, 250).Value = IIf(NoteEnd Is Nothing, "", NoteEnd)
            SQLcmd.Parameters.Add("@MM_GENERAL_END", SqlDbType.Decimal).Value = IIf(IsNumeric(MM_GENERAL_END), 0, MM_GENERAL_END)
            SQLcmd.Parameters.Add("@MM_SPECIFIC_ALLOWABLE_END", SqlDbType.Decimal).Value = IIf(IsNumeric(MM_SPECIFIC_ALLOWABLE_END), 0, MM_SPECIFIC_ALLOWABLE_END)
            SQLcmd.Parameters.Add("@MM_SPECIFIC_NONALLOWABLE_END", SqlDbType.Decimal).Value = IIf(IsNumeric(MM_SPECIFIC_NONALLOWABLE_END), 0, MM_SPECIFIC_NONALLOWABLE_END)
            SQLcmd.Parameters.Add("@ModifiedBy", SqlDbType.NVarChar, 100).Value = My.Computer.Name
            SQLcmd.Parameters.Add("@ModifiedDateTime", SqlDbType.DateTime).Value = Now
            SQLcmd.Parameters.Add("@MM_ADD_DEDUCT_AMOUNT", SqlDbType.Decimal).Value = MM_ADD_DEDUCT_AMOUNT

            ADO.ExecuteSQLCmd(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog, ReturnID)
            Application.DoEvents()
            tmpID = ReturnID

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            ListofCmd = New List(Of SqlCommand)
            If ds IsNot Nothing AndAlso ds.Tables("MOVEMENT_COMPLEX_ADD").Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables("MOVEMENT_COMPLEX_ADD").Rows.Count - 1
                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO MOVEMENT_COMPLEX_ADD (MM_PARENTID,MM_Description,MM_Amount,MM_Sequence,MM_GENERAL,MM_SPECIFIC_ALLOWABLE,MM_SPECIFIC_NONALLOWABLE,MM_GENERAL_ADDBACK,MM_SPECIFIC_ALLOWABLE_ADDBACK,MM_SPECIFIC_NONALLOWABLE_ADDBACK,MM_NOTE,MM_ADDBACK_AMOUNT) VALUES (@MM_PARENTID,@MM_Description,@MM_Amount,@MM_Sequence,@MM_GENERAL,@MM_SPECIFIC_ALLOWABLE,@MM_SPECIFIC_NONALLOWABLE,@MM_GENERAL_ADDBACK,@MM_SPECIFIC_ALLOWABLE_ADDBACK,@MM_SPECIFIC_NONALLOWABLE_ADDBACK,@MM_NOTE,@MM_ADDBACK_AMOUNT)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@MM_PARENTID", SqlDbType.Int).Value = tmpID
                    SQLcmd.Parameters.Add("@MM_Description", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_Description")), "", ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_Description"))
                    SQLcmd.Parameters.Add("@MM_Amount", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_Amount")), 0, ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_Amount"))
                    SQLcmd.Parameters.Add("@MM_Sequence", SqlDbType.Int).Value = i
                    SQLcmd.Parameters.Add("@MM_GENERAL", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_GENERAL")), 0, ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_GENERAL"))
                    SQLcmd.Parameters.Add("@MM_SPECIFIC_ALLOWABLE", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_SPECIFIC_ALLOWABLE")), 0, ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_SPECIFIC_ALLOWABLE"))
                    SQLcmd.Parameters.Add("@MM_SPECIFIC_NONALLOWABLE", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_SPECIFIC_NONALLOWABLE")), 0, ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_SPECIFIC_NONALLOWABLE"))
                    SQLcmd.Parameters.Add("@MM_GENERAL_ADDBACK", SqlDbType.Bit).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_SPECIFIC_NONALLOWABLE")), False, ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_GENERAL_ADDBACK"))
                    SQLcmd.Parameters.Add("@MM_SPECIFIC_ALLOWABLE_ADDBACK", SqlDbType.Bit).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_SPECIFIC_ALLOWABLE_ADDBACK")), False, ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_SPECIFIC_ALLOWABLE_ADDBACK"))
                    SQLcmd.Parameters.Add("@MM_SPECIFIC_NONALLOWABLE_ADDBACK", SqlDbType.Bit).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_SPECIFIC_NONALLOWABLE_ADDBACK")), False, ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_SPECIFIC_NONALLOWABLE_ADDBACK"))
                    SQLcmd.Parameters.Add("@MM_NOTE", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_NOTE")), "", ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_NOTE"))
                    SQLcmd.Parameters.Add("@MM_ADDBACK_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_ADDBACK_AMOUNT")), 0, ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_ADDBACK_AMOUNT"))

                    ListofCmd.Add(SQLcmd)
                Next
            End If
            If ds IsNot Nothing AndAlso ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows.Count - 1
                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO MOVEMENT_COMPLEX_DEDUCT (MM_PARENTID,MM_Description,MM_Amount,MM_Sequence,MM_GENERAL,MM_SPECIFIC_ALLOWABLE,MM_SPECIFIC_NONALLOWABLE,MM_GENERAL_DEDUCT,MM_SPECIFIC_ALLOWABLE_DEDUCT,MM_SPECIFIC_NONALLOWABLE_DEDUCT,MM_NOTE,MM_DEDUCT_AMOUNT) VALUES (@MM_PARENTID,@MM_Description,@MM_Amount,@MM_Sequence,@MM_GENERAL,@MM_SPECIFIC_ALLOWABLE,@MM_SPECIFIC_NONALLOWABLE,@MM_GENERAL_DEDUCT,@MM_SPECIFIC_ALLOWABLE_DEDUCT,@MM_SPECIFIC_NONALLOWABLE_DEDUCT,@MM_NOTE,@MM_DEDUCT_AMOUNT)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@MM_PARENTID", SqlDbType.Int).Value = tmpID
                    SQLcmd.Parameters.Add("@MM_Description", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_Description")), "", ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_Description"))
                    SQLcmd.Parameters.Add("@MM_Amount", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_Amount")), 0, ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_Amount"))
                    SQLcmd.Parameters.Add("@MM_Sequence", SqlDbType.Int).Value = i
                    SQLcmd.Parameters.Add("@MM_GENERAL", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_GENERAL")), 0, ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_GENERAL"))
                    SQLcmd.Parameters.Add("@MM_SPECIFIC_ALLOWABLE", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_SPECIFIC_ALLOWABLE")), 0, ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_SPECIFIC_ALLOWABLE"))
                    SQLcmd.Parameters.Add("@MM_SPECIFIC_NONALLOWABLE", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_SPECIFIC_NONALLOWABLE")), 0, ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_SPECIFIC_NONALLOWABLE"))
                    SQLcmd.Parameters.Add("@MM_GENERAL_DEDUCT", SqlDbType.Bit).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_SPECIFIC_NONALLOWABLE")), False, ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_GENERAL_DEDUCT"))
                    SQLcmd.Parameters.Add("@MM_SPECIFIC_ALLOWABLE_DEDUCT", SqlDbType.Bit).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_SPECIFIC_ALLOWABLE_DEDUCT")), False, ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_SPECIFIC_ALLOWABLE_DEDUCT"))
                    SQLcmd.Parameters.Add("@MM_SPECIFIC_NONALLOWABLE_DEDUCT", SqlDbType.Bit).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_SPECIFIC_NONALLOWABLE_DEDUCT")), False, ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_SPECIFIC_NONALLOWABLE_DEDUCT"))
                    SQLcmd.Parameters.Add("@MM_NOTE", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_NOTE")), "", ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_NOTE"))
                    SQLcmd.Parameters.Add("@MM_DEDUCT_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_DEDUCT_AMOUNT")), 0, ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_DEDUCT_AMOUNT"))

                    ListofCmd.Add(SQLcmd)
                Next
            End If

            If ListofCmd.Count > 0 Then
                Return ADO.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
            Else
                Return True
            End If
        Catch ex As Exception
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
    Public Function Save_MovementNormal(ByVal RefNo As String, ByVal YA As String, ByVal Title As String, _
                                        ByVal PeriodEnd As DateTime, ByVal YearEnded As DateTime, _
                                        ByVal BalanceStart As DateTime, ByVal BalanceEnd As DateTime, _
                                        ByVal AmountStart As Decimal, ByVal AmountEnd As Decimal, _
                                        ByVal NoteStart As String, ByVal NoteEnd As String, ByVal Total_AddBackDeduct As Decimal, _
                                        ByVal ds As DataSet, _
                                        ByRef ReturnID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection
            Dim ListofCmd As List(Of SqlCommand)
            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim tmpID As Decimal = 0

            Dim StrSQL As String = "INSERT INTO MOVEMENT_NORMAL (MM_REFNO,MM_YA,MM_TITLE,MM_PERIOD_ENDED,MM_YEAR_ENDED,MM_BALANCE_START,MM_BALANCE_END,MM_AMOUNT_START,MM_AMOUNT_END,MM_NOTE_START,MM_NOTE_END,ModifiedBy,ModifiedDateTime,MM_ADD_DEDUCT_AMOUNT) VALUES (@MM_REFNO,@MM_YA,@MM_TITLE,@MM_PERIOD_ENDED,@MM_YEAR_ENDED,@MM_BALANCE_START,@MM_BALANCE_END,@MM_AMOUNT_START,@MM_AMOUNT_END,@MM_NOTE_START,@MM_NOTE_END,@ModifiedBy,@ModifiedDateTime,@MM_ADD_DEDUCT_AMOUNT)"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@MM_REFNO", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@MM_YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@MM_TITLE", SqlDbType.NVarChar, 250).Value = IIf(Title Is Nothing, "", Title)
            SQLcmd.Parameters.Add("@MM_PERIOD_ENDED", SqlDbType.DateTime).Value = IIf(IsDBNull(PeriodEnd), Now, PeriodEnd)
            SQLcmd.Parameters.Add("@MM_YEAR_ENDED", SqlDbType.DateTime).Value = IIf(IsDBNull(YearEnded), Now, YearEnded)
            SQLcmd.Parameters.Add("@MM_BALANCE_START", SqlDbType.DateTime).Value = IIf(IsDBNull(BalanceStart), Now, BalanceStart)
            SQLcmd.Parameters.Add("@MM_BALANCE_END", SqlDbType.DateTime).Value = IIf(IsDBNull(BalanceEnd), Now, BalanceEnd)
            SQLcmd.Parameters.Add("@MM_AMOUNT_START", SqlDbType.Decimal).Value = IIf(IsNumeric(AmountStart) = False, 0, AmountStart)
            SQLcmd.Parameters.Add("@MM_AMOUNT_END", SqlDbType.Decimal).Value = IIf(IsNumeric(AmountEnd) = False, 0, AmountEnd)
            SQLcmd.Parameters.Add("@MM_NOTE_START", SqlDbType.NVarChar, 250).Value = IIf(NoteStart Is Nothing, "", NoteStart)
            SQLcmd.Parameters.Add("@MM_NOTE_END", SqlDbType.NVarChar, 250).Value = IIf(NoteEnd Is Nothing, "", NoteEnd)
            SQLcmd.Parameters.Add("@ModifiedBy", SqlDbType.NVarChar, 100).Value = My.Computer.Name
            SQLcmd.Parameters.Add("@ModifiedDateTime", SqlDbType.DateTime).Value = Now
            SQLcmd.Parameters.Add("@MM_ADD_DEDUCT_AMOUNT", SqlDbType.Decimal).Value = Total_AddBackDeduct


            ADO.ExecuteSQLCmd(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog, ReturnID)
            Application.DoEvents()
            tmpID = ReturnID

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            ListofCmd = New List(Of SqlCommand)
            If ds IsNot Nothing AndAlso ds.Tables("MOVEMENT_ADD").Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables("MOVEMENT_ADD").Rows.Count - 1
                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO MOVEMENT_ADD (MM_PARENTID,MM_Description,MM_Amount,MM_Sequence,MM_AddBack,MM_ADDBACK_AMOUNT) VALUES (@MM_PARENTID,@MM_Description,@MM_Amount,@MM_Sequence,@MM_AddBack,@MM_ADDBACK_AMOUNT)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@MM_PARENTID", SqlDbType.Int).Value = tmpID
                    SQLcmd.Parameters.Add("@MM_Description", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_ADD").Rows(i)("MM_Description")), "", ds.Tables("MOVEMENT_ADD").Rows(i)("MM_Description"))
                    SQLcmd.Parameters.Add("@MM_Amount", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_ADD").Rows(i)("MM_Amount")), 0, ds.Tables("MOVEMENT_ADD").Rows(i)("MM_Amount"))
                    SQLcmd.Parameters.Add("@MM_Sequence", SqlDbType.Int).Value = i
                    SQLcmd.Parameters.Add("@MM_AddBack", SqlDbType.Bit).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_ADD").Rows(i)("MM_AddBack")), False, ds.Tables("MOVEMENT_ADD").Rows(i)("MM_AddBack"))
                    SQLcmd.Parameters.Add("@MM_ADDBACK_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_ADD").Rows(i)("MM_ADDBACK_AMOUNT")), 0, ds.Tables("MOVEMENT_ADD").Rows(i)("MM_ADDBACK_AMOUNT"))
                    ListofCmd.Add(SQLcmd)
                Next
            End If
            If ds IsNot Nothing AndAlso ds.Tables("MOVEMENT_DEDUCT").Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables("MOVEMENT_DEDUCT").Rows.Count - 1
                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO MOVEMENT_DEDUCT (MM_PARENTID,MM_Description,MM_Amount,MM_Sequence,MM_Deduct,MM_DEDUCT_AMOUNT) VALUES (@MM_PARENTID,@MM_Description,@MM_Amount,@MM_Sequence,@MM_Deduct,@MM_DEDUCT_AMOUNT)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@MM_PARENTID", SqlDbType.Int).Value = tmpID
                    SQLcmd.Parameters.Add("@MM_Description", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_DEDUCT").Rows(i)("MM_Description")), "", ds.Tables("MOVEMENT_DEDUCT").Rows(i)("MM_Description"))
                    SQLcmd.Parameters.Add("@MM_Amount", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_DEDUCT").Rows(i)("MM_Amount")), 0, ds.Tables("MOVEMENT_DEDUCT").Rows(i)("MM_Amount"))
                    SQLcmd.Parameters.Add("@MM_Sequence", SqlDbType.Int).Value = i
                    SQLcmd.Parameters.Add("@MM_Deduct", SqlDbType.Bit).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_DEDUCT").Rows(i)("MM_Deduct")), False, ds.Tables("MOVEMENT_DEDUCT").Rows(i)("MM_Deduct"))
                    SQLcmd.Parameters.Add("@MM_DEDUCT_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_DEDUCT").Rows(i)("MM_DEDUCT_AMOUNT")), 0, ds.Tables("MOVEMENT_DEDUCT").Rows(i)("MM_DEDUCT_AMOUNT"))

                    ListofCmd.Add(SQLcmd)
                Next
            End If

            If ListofCmd.Count > 0 Then
                Return ADO.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
            Else
                Return True
            End If
        Catch ex As Exception
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
#End Region
#Region "CP204"
    Public Function Save_CP204(ByVal ds As DataSet, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim ListofSQLcmd As New List(Of SqlCommand)
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "INSERT INTO BORANG_CP204 (BCP_KEY,BCP_REF_NO,BCP_CO_NAME,BCP_CO_REGNO,BCP_CORRESPOND_ADD1,BCP_CORRESPOND_ADD2,BCP_CORRESPOND_ADD3,BCP_CORRESPOND_POST,BCP_CORRESPOND_CITY,BCP_CORRESPOND_STATE,BCP_DATE,BCP_YA,BCP_ESTIMATED_TAX,BCP_ACC_PERIOD_FR,BCP_ACC_PERIOD_TO,BCP_BASIS_PERIOD_FR,BCP_BASIS_PERIOD_TO,BCP_NEWCO_DATE,BCP_TO_MONTH,BCP_FIRST_INSTALMENT,BCP_LAST_INSTALMENT,BCP_NEWCO_BAS_FR,BCP_NEWCO_BAS_TO,BCP_NEWCO_BAS_SUB_FR,BCP_NEWCO_BAS_SUB_TO,BCP_CURR_CORR_ADD1,BCP_CURR_CORR_ADD2,BCP_CURR_CORR_ADD3,BCP_CURR_CORR_POST,BCP_CURR_CORR_CITY,BCP_CURR_CORR_STATE,BCP_REV_ESTIMATED_TAX,BCP_BAL_ESTIMATED_TAX,BCP_TOTAL_PAID,BCP_FR_MONTH,BCP_FROM_INSTALMENT,BCP_NEW_ACC_PERIOD_FR,BCP_NEW_ACC_PERIOD_TO,BCP_BASIS_PERIOD_FLW_FR,BCP_BASIS_PERIOD_FLW_TO,BCP_BASIS_PERIOD_SUB_FR,BCP_BASIS_PERIOD_SUB_TO,BCP_FORM,BCP_VERSION,BCP_ESTIMATED,BCP_INDICATE,BCP_CHKM,BCP_SME_PERIOD_FR,BCP_SME_PERIOD_TO,ModifiedBy,ModifiedDateTime) VALUES (@BCP_KEY,@BCP_REF_NO,@BCP_CO_NAME,@BCP_CO_REGNO,@BCP_CORRESPOND_ADD1,@BCP_CORRESPOND_ADD2,@BCP_CORRESPOND_ADD3,@BCP_CORRESPOND_POST,@BCP_CORRESPOND_CITY,@BCP_CORRESPOND_STATE,@BCP_DATE,@BCP_YA,@BCP_ESTIMATED_TAX,@BCP_ACC_PERIOD_FR,@BCP_ACC_PERIOD_TO,@BCP_BASIS_PERIOD_FR,@BCP_BASIS_PERIOD_TO,@BCP_NEWCO_DATE,@BCP_TO_MONTH,@BCP_FIRST_INSTALMENT,@BCP_LAST_INSTALMENT,@BCP_NEWCO_BAS_FR,@BCP_NEWCO_BAS_TO,@BCP_NEWCO_BAS_SUB_FR,@BCP_NEWCO_BAS_SUB_TO,@BCP_CURR_CORR_ADD1,@BCP_CURR_CORR_ADD2,@BCP_CURR_CORR_ADD3,@BCP_CURR_CORR_POST,@BCP_CURR_CORR_CITY,@BCP_CURR_CORR_STATE,@BCP_REV_ESTIMATED_TAX,@BCP_BAL_ESTIMATED_TAX,@BCP_TOTAL_PAID,@BCP_FR_MONTH,@BCP_FROM_INSTALMENT,@BCP_NEW_ACC_PERIOD_FR,@BCP_NEW_ACC_PERIOD_TO,@BCP_BASIS_PERIOD_FLW_FR,@BCP_BASIS_PERIOD_FLW_TO,@BCP_BASIS_PERIOD_SUB_FR,@BCP_BASIS_PERIOD_SUB_TO,@BCP_FORM,@BCP_VERSION,@BCP_ESTIMATED,@BCP_INDICATE,@BCP_CHKM,@BCP_SME_PERIOD_FR,@BCP_SME_PERIOD_TO,@ModifiedBy,@ModifiedDateTime)"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            With ds.Tables("BORANG_CP204")
                SQLcmd.Parameters.Add("@BCP_KEY", SqlDbType.Int).Value = .Rows(0)("BCP_KEY")
                SQLcmd.Parameters.Add("@BCP_REF_NO", SqlDbType.NVarChar, 20).Value = .Rows(0)("BCP_REF_NO")
                SQLcmd.Parameters.Add("@BCP_CO_NAME", SqlDbType.NVarChar, 255).Value = .Rows(0)("BCP_CO_NAME")
                SQLcmd.Parameters.Add("@BCP_CO_REGNO", SqlDbType.NVarChar, 20).Value = .Rows(0)("BCP_CO_REGNO")
                SQLcmd.Parameters.Add("@BCP_CORRESPOND_ADD1", SqlDbType.NVarChar, 40).Value = .Rows(0)("BCP_CORRESPOND_ADD1")
                SQLcmd.Parameters.Add("@BCP_CORRESPOND_ADD2", SqlDbType.NVarChar, 40).Value = .Rows(0)("BCP_CORRESPOND_ADD2")
                SQLcmd.Parameters.Add("@BCP_CORRESPOND_ADD3", SqlDbType.NVarChar, 40).Value = .Rows(0)("BCP_CORRESPOND_ADD3")
                SQLcmd.Parameters.Add("@BCP_CORRESPOND_POST", SqlDbType.NVarChar, 10).Value = .Rows(0)("BCP_CORRESPOND_POST")
                SQLcmd.Parameters.Add("@BCP_CORRESPOND_CITY", SqlDbType.NVarChar, 30).Value = .Rows(0)("BCP_CORRESPOND_CITY")
                SQLcmd.Parameters.Add("@BCP_CORRESPOND_STATE", SqlDbType.NVarChar, 30).Value = .Rows(0)("BCP_CORRESPOND_STATE")
                SQLcmd.Parameters.Add("@BCP_DATE", SqlDbType.DateTime).Value = .Rows(0)("BCP_DATE")
                SQLcmd.Parameters.Add("@BCP_YA", SqlDbType.NVarChar, 5).Value = .Rows(0)("BCP_YA")
                SQLcmd.Parameters.Add("@BCP_ESTIMATED_TAX", SqlDbType.Decimal).Value = .Rows(0)("BCP_ESTIMATED_TAX")
                SQLcmd.Parameters.Add("@BCP_ACC_PERIOD_FR", SqlDbType.DateTime).Value = .Rows(0)("BCP_ACC_PERIOD_FR")
                SQLcmd.Parameters.Add("@BCP_ACC_PERIOD_TO", SqlDbType.DateTime).Value = .Rows(0)("BCP_ACC_PERIOD_TO")
                SQLcmd.Parameters.Add("@BCP_BASIS_PERIOD_FR", SqlDbType.DateTime).Value = .Rows(0)("BCP_BASIS_PERIOD_FR")
                SQLcmd.Parameters.Add("@BCP_BASIS_PERIOD_TO", SqlDbType.DateTime).Value = .Rows(0)("BCP_BASIS_PERIOD_TO")
                SQLcmd.Parameters.Add("@BCP_NEWCO_DATE", SqlDbType.DateTime).Value = .Rows(0)("BCP_NEWCO_DATE")
                SQLcmd.Parameters.Add("@BCP_TO_MONTH", SqlDbType.Int).Value = .Rows(0)("BCP_TO_MONTH")
                SQLcmd.Parameters.Add("@BCP_FIRST_INSTALMENT", SqlDbType.Decimal).Value = .Rows(0)("BCP_FIRST_INSTALMENT")
                SQLcmd.Parameters.Add("@BCP_LAST_INSTALMENT", SqlDbType.Decimal).Value = .Rows(0)("BCP_LAST_INSTALMENT")
                SQLcmd.Parameters.Add("@BCP_NEWCO_BAS_FR", SqlDbType.DateTime).Value = .Rows(0)("BCP_NEWCO_BAS_FR")
                SQLcmd.Parameters.Add("@BCP_NEWCO_BAS_TO", SqlDbType.DateTime).Value = .Rows(0)("BCP_NEWCO_BAS_TO")
                SQLcmd.Parameters.Add("@BCP_NEWCO_BAS_SUB_FR", SqlDbType.DateTime).Value = .Rows(0)("BCP_NEWCO_BAS_SUB_FR")
                SQLcmd.Parameters.Add("@BCP_NEWCO_BAS_SUB_TO", SqlDbType.DateTime).Value = .Rows(0)("BCP_NEWCO_BAS_SUB_TO")
                SQLcmd.Parameters.Add("@BCP_CURR_CORR_ADD1", SqlDbType.NVarChar, 40).Value = .Rows(0)("BCP_CURR_CORR_ADD1")
                SQLcmd.Parameters.Add("@BCP_CURR_CORR_ADD2", SqlDbType.NVarChar, 40).Value = .Rows(0)("BCP_CURR_CORR_ADD2")
                SQLcmd.Parameters.Add("@BCP_CURR_CORR_ADD3", SqlDbType.NVarChar, 40).Value = .Rows(0)("BCP_CURR_CORR_ADD3")
                SQLcmd.Parameters.Add("@BCP_CURR_CORR_POST", SqlDbType.NVarChar, 10).Value = .Rows(0)("BCP_CURR_CORR_POST")
                SQLcmd.Parameters.Add("@BCP_CURR_CORR_CITY", SqlDbType.NVarChar, 30).Value = .Rows(0)("BCP_CURR_CORR_CITY")
                SQLcmd.Parameters.Add("@BCP_CURR_CORR_STATE", SqlDbType.NVarChar, 30).Value = .Rows(0)("BCP_CURR_CORR_STATE")
                SQLcmd.Parameters.Add("@BCP_REV_ESTIMATED_TAX", SqlDbType.Decimal).Value = .Rows(0)("BCP_REV_ESTIMATED_TAX")
                SQLcmd.Parameters.Add("@BCP_BAL_ESTIMATED_TAX", SqlDbType.Decimal).Value = .Rows(0)("BCP_BAL_ESTIMATED_TAX")
                SQLcmd.Parameters.Add("@BCP_TOTAL_PAID", SqlDbType.Decimal).Value = .Rows(0)("BCP_TOTAL_PAID")
                SQLcmd.Parameters.Add("@BCP_FR_MONTH", SqlDbType.Int).Value = .Rows(0)("BCP_FR_MONTH")
                SQLcmd.Parameters.Add("@BCP_FROM_INSTALMENT", SqlDbType.NVarChar, 25).Value = .Rows(0)("BCP_FROM_INSTALMENT")
                SQLcmd.Parameters.Add("@BCP_NEW_ACC_PERIOD_FR", SqlDbType.DateTime).Value = .Rows(0)("BCP_NEW_ACC_PERIOD_FR")
                SQLcmd.Parameters.Add("@BCP_NEW_ACC_PERIOD_TO", SqlDbType.DateTime).Value = .Rows(0)("BCP_NEW_ACC_PERIOD_TO")
                SQLcmd.Parameters.Add("@BCP_BASIS_PERIOD_FLW_FR", SqlDbType.DateTime).Value = .Rows(0)("BCP_BASIS_PERIOD_FLW_FR")
                SQLcmd.Parameters.Add("@BCP_BASIS_PERIOD_FLW_TO", SqlDbType.DateTime).Value = .Rows(0)("BCP_BASIS_PERIOD_FLW_TO")
                SQLcmd.Parameters.Add("@BCP_BASIS_PERIOD_SUB_FR", SqlDbType.DateTime).Value = .Rows(0)("BCP_BASIS_PERIOD_SUB_FR")
                SQLcmd.Parameters.Add("@BCP_BASIS_PERIOD_SUB_TO", SqlDbType.DateTime).Value = .Rows(0)("BCP_BASIS_PERIOD_SUB_TO")
                SQLcmd.Parameters.Add("@BCP_FORM", SqlDbType.NVarChar, 10).Value = .Rows(0)("BCP_FORM")
                SQLcmd.Parameters.Add("@BCP_VERSION", SqlDbType.Int).Value = .Rows(0)("BCP_VERSION")
                SQLcmd.Parameters.Add("@BCP_ESTIMATED", SqlDbType.Decimal).Value = .Rows(0)("BCP_ESTIMATED")
                SQLcmd.Parameters.Add("@BCP_INDICATE", SqlDbType.Int).Value = .Rows(0)("BCP_INDICATE")
                SQLcmd.Parameters.Add("@BCP_CHKM", SqlDbType.NVarChar, 1).Value = .Rows(0)("BCP_CHKM")
                SQLcmd.Parameters.Add("@BCP_SME_PERIOD_FR", SqlDbType.NVarChar, 20).Value = .Rows(0)("BCP_SME_PERIOD_FR")
                SQLcmd.Parameters.Add("@BCP_SME_PERIOD_TO", SqlDbType.NVarChar, 20).Value = .Rows(0)("BCP_SME_PERIOD_TO")
                SQLcmd.Parameters.Add("@ModifiedBy", SqlDbType.NVarChar, 100).Value = My.Computer.Name
                SQLcmd.Parameters.Add("@ModifiedDateTime", SqlDbType.DateTime).Value = Now
            End With

            ListofSQLcmd.Add(SQLcmd)

            SQLcmd = Nothing
            StrSQL = "DELETE FROM BORANG_CP204_TRICOR_BREAKDOWN WHERE CP_PARENTID=@CP_PARENTID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@CP_PARENTID", SqlDbType.Int).Value = ds.Tables("BORANG_CP204").Rows(0)("BCP_KEY")

            ListofSQLcmd.Add(SQLcmd)

            If ds.Tables("BORANG_CP204_TRICOR_BREAKDOWN").Rows.Count > 0 Then

                For i As Integer = 0 To ds.Tables("BORANG_CP204_TRICOR_BREAKDOWN").Rows.Count - 1
                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO BORANG_CP204_TRICOR_BREAKDOWN (CP_PARENTID,CP_INSTALL_NO,CP_PAYMENT_DUE,CP_INSTALLMENT_AMOUNT,CP_PAYMENT_DATE_1,CP_AMOUNT_PAID_1,CP_PAYMENT_DATE_2,CP_AMOUNT_PAID_2,CP_PENALTY,CP_NOTE_TITLE,CP_NOTE) VALUES (@CP_PARENTID,@CP_INSTALL_NO,@CP_PAYMENT_DUE,@CP_INSTALLMENT_AMOUNT,@CP_PAYMENT_DATE_1,@CP_AMOUNT_PAID_1,@CP_PAYMENT_DATE_2,@CP_AMOUNT_PAID_2,@CP_PENALTY,@CP_NOTE_TITLE,@CP_NOTE)"

                    With ds.Tables("BORANG_CP204_TRICOR_BREAKDOWN")

                        SQLcmd = New SqlCommand
                        SQLcmd.CommandText = StrSQL
                        SQLcmd.Parameters.Add("@CP_PARENTID", SqlDbType.Int).Value = ds.Tables("BORANG_CP204").Rows(0)("BCP_KEY")
                        SQLcmd.Parameters.Add("@CP_INSTALL_NO", SqlDbType.Int).Value = IIf(IsDBNull(.Rows(0)("CP_INSTALL_NO")), i, .Rows(0)("CP_INSTALL_NO"))
                        SQLcmd.Parameters.Add("@CP_PAYMENT_DUE", SqlDbType.DateTime).Value = IIf(IsDBNull(.Rows(0)("CP_PAYMENT_DUE")), DBNull.Value, .Rows(0)("CP_PAYMENT_DUE"))
                        SQLcmd.Parameters.Add("@CP_INSTALLMENT_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(.Rows(0)("CP_INSTALLMENT_AMOUNT")), DBNull.Value, .Rows(0)("CP_INSTALLMENT_AMOUNT"))
                        SQLcmd.Parameters.Add("@CP_PAYMENT_DATE_1", SqlDbType.DateTime).Value = IIf(IsDBNull(.Rows(0)("CP_PAYMENT_DATE_1")), DBNull.Value, .Rows(0)("CP_PAYMENT_DATE_1"))
                        SQLcmd.Parameters.Add("@CP_AMOUNT_PAID_1", SqlDbType.Decimal).Value = IIf(IsDBNull(.Rows(0)("CP_AMOUNT_PAID_1")), DBNull.Value, .Rows(0)("CP_AMOUNT_PAID_1"))
                        SQLcmd.Parameters.Add("@CP_PAYMENT_DATE_2", SqlDbType.DateTime).Value = IIf(IsDBNull(.Rows(0)("CP_PAYMENT_DATE_2")), DBNull.Value, .Rows(0)("CP_PAYMENT_DATE_2"))
                        SQLcmd.Parameters.Add("@CP_AMOUNT_PAID_2", SqlDbType.Decimal).Value = IIf(IsDBNull(.Rows(0)("CP_AMOUNT_PAID_2")), DBNull.Value, .Rows(0)("CP_AMOUNT_PAID_2"))
                        SQLcmd.Parameters.Add("@CP_PENALTY", SqlDbType.Decimal).Value = IIf(IsDBNull(.Rows(0)("CP_PENALTY")), DBNull.Value, .Rows(0)("CP_PENALTY"))
                        SQLcmd.Parameters.Add("@CP_NOTE_TITLE", SqlDbType.NVarChar, 100).Value = IIf(IsDBNull(.Rows(0)("CP_NOTE_TITLE")), DBNull.Value, .Rows(0)("CP_NOTE_TITLE"))
                        SQLcmd.Parameters.Add("@CP_NOTE", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(.Rows(0)("CP_NOTE")), DBNull.Value, .Rows(0)("CP_NOTE"))

                    End With
                   

                    ListofSQLcmd.Add(SQLcmd)
                Next
                
            End If

            Return ADO.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofSQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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

#End Region
#Region "MASTER DATA"
    Public Function Save_YA(ByVal YA As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            If CheckYA_Exist(YA) Then
                If ErrorLog Is Nothing Then
                    ErrorLog = New clsError
                End If
                ErrorLog.ErrorDateTime = Now
                ErrorLog.ErrorCode = "X1001"
                ErrorLog.ErrorName = "Year assessment already exist."

                Return False
            End If

            ADO = New SQLDataObject()
            Dim SQLcmd As SqlCommand
            Dim SqlCon As SqlConnection = Nothing
            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim strSQL As String = "INSERT INTO YEAR_ASSESSMENT(YA) VALUES (@YA)"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = strSQL
            SQLcmd.Parameters.Add("@YA", SqlDbType.NVarChar, 5).Value = CStr(YA)

            Return ADO.ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
#End Region
#Region "TABLE OF CONTENT"

    Public Function Save_TableOfContent(ByVal RefNo As String, ByVal CompanyName As String, ByVal YA As String, dt As DataTable, ByRef ReturnID As Decimal, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "INSERT INTO TABLE_CONTENT (TBL_REFNO,TBL_COMPANYNAME,TBL_YA,ModifiedBy,ModifiedDateTime) VALUES (@TBL_REFNO,@TBL_COMPANYNAME,@TBL_YA,@ModifiedBy,@ModifiedDateTime)"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@TBL_REFNO", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@TBL_COMPANYNAME", SqlDbType.NVarChar, 350).Value = CompanyName
            SQLcmd.Parameters.Add("@TBL_YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@ModifiedBy", SqlDbType.NVarChar, 100).Value = My.Computer.Name
            SQLcmd.Parameters.Add("@ModifiedDateTime", SqlDbType.DateTime).Value = Now

            If ADO.ExecuteSQLCmd(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog, ReturnID) Then

                If dt IsNot Nothing Then
                    Dim ListofSQLCmd As New List(Of SqlCommand)

                    For i As Integer = 0 To dt.Rows.Count - 1
                        SQLcmd = Nothing
                        StrSQL = "INSERT INTO TABLE_CONTENT_LIST (TBL_PARENTID,TBL_REPORTNAME,TBL_TITLE,TBL_INDEX,TBL_SEQUENCE) VALUES (@TBL_PARENTID,@TBL_REPORTNAME,@TBL_TITLE,@TBL_INDEX,@TBL_SEQUENCE)"

                        SQLcmd = New SqlCommand
                        SQLcmd.CommandText = StrSQL
                        SQLcmd.Parameters.Add("@TBL_PARENTID", SqlDbType.Decimal).Value = ReturnID
                        SQLcmd.Parameters.Add("@TBL_REPORTNAME", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(dt.Rows(i)("TBL_REPORTNAME")), "", dt.Rows(i)("TBL_REPORTNAME"))
                        SQLcmd.Parameters.Add("@TBL_TITLE", SqlDbType.NVarChar, 300).Value = IIf(IsDBNull(dt.Rows(i)("TBL_TITLE")), "", dt.Rows(i)("TBL_TITLE"))
                        SQLcmd.Parameters.Add("@TBL_INDEX", SqlDbType.NVarChar, 10).Value = IIf(IsDBNull(dt.Rows(i)("TBL_INDEX")), "", dt.Rows(i)("TBL_INDEX"))
                        SQLcmd.Parameters.Add("@TBL_SEQUENCE", SqlDbType.Int).Value = i

                        ListofSQLCmd.Add(SQLcmd)
                    Next


                    If ADO.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofSQLCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog) = False Then
                        Return False
                    End If
                End If

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
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function



#End Region
#End Region
#Region "UPDATE"
#Region "CA"
    Public Function Update_UpdateRemainingQC(ByVal CA_KEY As Integer, ByVal RemainingQC As Decimal, ByVal TableName As String, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = Nothing

            Select Case TableName.ToUpper
                Case "CA"
                    StrSQL = "update ca set ca_remain_qc=@remain_qc where ca_key=@ca_key"
                Case "DISP"
                    StrSQL = "update ca_disposal set ca_disp_balance=@remain_qc where ca_key=@ca_key"
            End Select

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ca_key", SqlDbType.Int).Value = CA_KEY
            SQLcmd.Parameters.Add("@remain_qc", SqlDbType.NVarChar, 25).Value = CStr(RemainingQC)

            Return ADO.ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
    Public Function Update_HP(ByVal HP_KEY As Integer, ByVal HP_PREFIX As String, ByVal HP_REF_NO As String, ByVal HP_NAME As String, ByVal HP_FILENO As String, _
                            ByVal HP_YA As String, ByVal HP_COMPANY_CODE As String, ByVal HP_SOURCENO As Integer, ByVal HP_ASSET_CODE As String, _
                            ByVal HP_ASSET As String, ByVal HP_CATEGORY_CODE As String, ByVal HP_PURCHASE_DATE As DateTime, ByVal HP_PURCHASE_AMOUNT As Decimal, _
                            ByVal HP_PAYMENT As Decimal, ByVal HP_RESTRICTED_QC As Decimal, ByVal HP_DESC As String, ByVal HP_CODE As String, _
                            ByVal HP_PRINCIPAL As Decimal, ByVal HP_INTEREST_RATE As Decimal, ByVal HP_INTEREST As Decimal, ByVal HP_TOTAL As Decimal, _
                            ByVal HP_NO_INST As Integer, ByVal HP_FIRST_INST As DateTime, ByVal HP_DECIMAL As Integer, ByVal HP_SCHE_METHOD As String, _
                            ByVal HP_TYPE_SCHE As Integer, _
                            ByVal ds As DataSet, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "UPDATE HP SET HP_PREFIX=@HP_PREFIX,HP_REF_NO=@HP_REF_NO,HP_NAME=@HP_NAME,HP_FILENO=@HP_FILENO,HP_YA=@HP_YA,HP_COMPANY_CODE=@HP_COMPANY_CODE,HP_SOURCENO=@HP_SOURCENO,HP_ASSET_CODE=@HP_ASSET_CODE,"
            StrSQL += "HP_ASSET=@HP_ASSET,HP_CATEGORY_CODE=@HP_CATEGORY_CODE,HP_PURCHASE_DATE=@HP_PURCHASE_DATE,HP_PURCHASE_AMOUNT=@HP_PURCHASE_AMOUNT,HP_PAYMENT=@HP_PAYMENT,HP_RESTRICTED_QC=@HP_RESTRICTED_QC,HP_DESC=@HP_DESC,HP_CODE=@HP_CODE,"
            StrSQL += "HP_PRINCIPAL=@HP_PRINCIPAL,HP_INTEREST_RATE=@HP_INTEREST_RATE,HP_INTEREST=@HP_INTEREST,HP_TOTAL=@HP_TOTAL,HP_NO_INST=@HP_NO_INST,HP_FIRST_INST=@HP_FIRST_INST,HP_DECIMAL=@HP_DECIMAL,HP_SCHE_METHOD=@HP_SCHE_METHOD,HP_TYPE_SCHE=@HP_TYPE_SCHE WHERE HP_KEY=@HP_KEY"


            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@HP_KEY", SqlDbType.Int).Value = HP_KEY
            SQLcmd.Parameters.Add("@HP_PREFIX", SqlDbType.NVarChar, 3).Value = HP_PREFIX
            SQLcmd.Parameters.Add("@HP_REF_NO", SqlDbType.NVarChar, 20).Value = HP_REF_NO
            SQLcmd.Parameters.Add("@HP_NAME", SqlDbType.NVarChar, 255).Value = HP_NAME
            SQLcmd.Parameters.Add("@HP_FILENO", SqlDbType.NVarChar, 20).Value = HP_FILENO
            SQLcmd.Parameters.Add("@HP_YA", SqlDbType.NVarChar, 5).Value = HP_YA
            SQLcmd.Parameters.Add("@HP_COMPANY_CODE", SqlDbType.NVarChar, 8).Value = HP_COMPANY_CODE
            SQLcmd.Parameters.Add("@HP_SOURCENO", SqlDbType.Int).Value = HP_SOURCENO
            SQLcmd.Parameters.Add("@HP_ASSET_CODE", SqlDbType.NVarChar, 20).Value = HP_ASSET_CODE
            SQLcmd.Parameters.Add("@HP_ASSET", SqlDbType.NVarChar, 255).Value = HP_ASSET
            SQLcmd.Parameters.Add("@HP_CATEGORY_CODE", SqlDbType.NVarChar, 20).Value = HP_CATEGORY_CODE
            SQLcmd.Parameters.Add("@HP_PURCHASE_DATE", SqlDbType.DateTime).Value = HP_PURCHASE_DATE
            SQLcmd.Parameters.Add("@HP_PURCHASE_AMOUNT", SqlDbType.NVarChar, 25).Value = HP_PURCHASE_AMOUNT
            SQLcmd.Parameters.Add("@HP_PAYMENT", SqlDbType.NVarChar, 25).Value = HP_PAYMENT
            SQLcmd.Parameters.Add("@HP_RESTRICTED_QC", SqlDbType.NVarChar, 25).Value = HP_RESTRICTED_QC
            SQLcmd.Parameters.Add("@HP_DESC", SqlDbType.NVarChar, 255).Value = HP_DESC
            SQLcmd.Parameters.Add("@HP_CODE", SqlDbType.NVarChar, 255).Value = HP_CODE
            SQLcmd.Parameters.Add("@HP_PRINCIPAL", SqlDbType.NVarChar, 25).Value = HP_PRINCIPAL
            SQLcmd.Parameters.Add("@HP_INTEREST_RATE", SqlDbType.NVarChar, 25).Value = HP_INTEREST_RATE
            SQLcmd.Parameters.Add("@HP_INTEREST", SqlDbType.NVarChar, 25).Value = HP_INTEREST
            SQLcmd.Parameters.Add("@HP_TOTAL", SqlDbType.NVarChar, 25).Value = HP_TOTAL
            SQLcmd.Parameters.Add("@HP_NO_INST", SqlDbType.Int).Value = HP_NO_INST
            SQLcmd.Parameters.Add("@HP_FIRST_INST", SqlDbType.DateTime).Value = HP_FIRST_INST
            SQLcmd.Parameters.Add("@HP_DECIMAL", SqlDbType.Int).Value = HP_DECIMAL
            SQLcmd.Parameters.Add("@HP_SCHE_METHOD", SqlDbType.NVarChar, 50).Value = HP_SCHE_METHOD
            SQLcmd.Parameters.Add("@HP_TYPE_SCHE", SqlDbType.Int).Value = HP_TYPE_SCHE

            Dim rlst As Boolean = ADO.ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If rlst = False Then
                Return False
            Else
                Dim ListofCmd As New List(Of SqlCommand)

                If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                    Return False
                End If

                If HP_TYPE_SCHE = 0 Then
                    'Yearly
                    StrSQL = "DELETE FROM HP_YEARLY WHERE HPD_KEY=@HPD_KEY"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@HPD_KEY", SqlDbType.Int).Value = HP_KEY
                    ListofCmd.Add(SQLcmd)

                    For i As Integer = 0 To ds.Tables("HP_YEARLY").Rows.Count - 1

                        StrSQL = "INSERT INTO HP_YEARLY(HPD_KEY,HPD_YA,HPD_PRINCIPAL,HPD_INTEREST,HPD_TOTAL,HPD_NOTE_TITLE1,HPD_NOTE_TITLE2) VALUES (@HPD_KEY,@HPD_YA,@HPD_PRINCIPAL,@HPD_INTEREST,@HPD_TOTAL,@HPD_NOTE_TITLE1,@HPD_NOTE_TITLE2)"


                        SQLcmd = New SqlCommand
                        SQLcmd.CommandText = StrSQL
                        SQLcmd.Parameters.Add("@HPD_KEY", SqlDbType.Int).Value = HP_KEY
                        SQLcmd.Parameters.Add("@HPD_YA", SqlDbType.NVarChar, 5).Value = ds.Tables("HP_YEARLY").Rows(i)("HPD_YA")
                        SQLcmd.Parameters.Add("@HPD_PRINCIPAL", SqlDbType.NVarChar, 25).Value = ds.Tables("HP_YEARLY").Rows(i)("HPD_PRINCIPAL")
                        SQLcmd.Parameters.Add("@HPD_INTEREST", SqlDbType.NVarChar, 25).Value = ds.Tables("HP_YEARLY").Rows(i)("HPD_INTEREST")
                        SQLcmd.Parameters.Add("@HPD_TOTAL", SqlDbType.NVarChar, 25).Value = ds.Tables("HP_YEARLY").Rows(i)("HPD_TOTAL")
                        SQLcmd.Parameters.Add("@HPD_NOTE_TITLE1", SqlDbType.NVarChar, 50).Value = ds.Tables("HP_YEARLY").Rows(i)("HPD_NOTE_TITLE1")
                        SQLcmd.Parameters.Add("@HPD_NOTE_TITLE2", SqlDbType.NVarChar, 50).Value = ds.Tables("HP_YEARLY").Rows(i)("HPD_NOTE_TITLE2")

                        ListofCmd.Add(SQLcmd)
                    Next
                Else
                    'Installment
                    StrSQL = "DELETE FROM HP_INSTALLMENT WHERE HP_KEY=@HP_KEY"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@HP_KEY", SqlDbType.Int).Value = HP_KEY
                    ListofCmd.Add(SQLcmd)

                    For i As Integer = 0 To ds.Tables("HP_INSTALLMENT").Rows.Count - 1

                        StrSQL = "INSERT INTO HP_INSTALLMENT(HP_KEY,HPD_KEY,HPD_PRINCIPAL,HPD_INTEREST,HPD_TOTAL,HPD_PAY_DUE_DATE,HPD_PAYMENT_PRINCIPAL,HPD_PAYMENT_INTEREST,HPD_PAYMENT_DATE,HPD_YA) VALUES (@HP_KEY,@HPD_KEY,@HPD_PRINCIPAL,@HPD_INTEREST,@HPD_TOTAL,@HPD_PAY_DUE_DATE,@HPD_PAYMENT_PRINCIPAL,@HPD_PAYMENT_INTEREST,@HPD_PAYMENT_DATE,@HPD_YA)"


                        SQLcmd = New SqlCommand
                        SQLcmd.CommandText = StrSQL
                        SQLcmd.Parameters.Add("@HP_KEY", SqlDbType.Int).Value = HP_KEY
                        SQLcmd.Parameters.Add("@HPD_KEY", SqlDbType.Int).Value = ds.Tables("HP_INSTALLMENT").Rows(i)("HPD_KEY")
                        SQLcmd.Parameters.Add("@HPD_PRINCIPAL", SqlDbType.NVarChar, 25).Value = ds.Tables("HP_INSTALLMENT").Rows(i)("HPD_PRINCIPAL")
                        SQLcmd.Parameters.Add("@HPD_INTEREST", SqlDbType.NVarChar, 25).Value = ds.Tables("HP_INSTALLMENT").Rows(i)("HPD_INTEREST")
                        SQLcmd.Parameters.Add("@HPD_TOTAL", SqlDbType.NVarChar, 25).Value = ds.Tables("HP_INSTALLMENT").Rows(i)("HPD_TOTAL")
                        SQLcmd.Parameters.Add("@HPD_PAY_DUE_DATE", SqlDbType.DateTime).Value = ds.Tables("HP_INSTALLMENT").Rows(i)("HPD_PAY_DUE_DATE")
                        SQLcmd.Parameters.Add("@HPD_PAYMENT_PRINCIPAL", SqlDbType.NVarChar, 25).Value = ds.Tables("HP_INSTALLMENT").Rows(i)("HPD_PAYMENT_PRINCIPAL")
                        SQLcmd.Parameters.Add("@HPD_PAYMENT_INTEREST", SqlDbType.NVarChar, 25).Value = ds.Tables("HP_INSTALLMENT").Rows(i)("HPD_PAYMENT_INTEREST")
                        SQLcmd.Parameters.Add("@HPD_PAYMENT_DATE", SqlDbType.DateTime).Value = ds.Tables("HP_INSTALLMENT").Rows(i)("HPD_PAYMENT_DATE")
                        SQLcmd.Parameters.Add("@HPD_YA", SqlDbType.NVarChar, 5).Value = ds.Tables("HP_INSTALLMENT").Rows(i)("HPD_YA")


                        ListofCmd.Add(SQLcmd)
                    Next

                End If

                Return ADO.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
            End If
        Catch ex As Exception
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
    Public Function Update_CA(ByVal CA_KEY As Decimal, ByVal CA_REF_NO As String, ByVal CA_NAME As String, ByVal CA_FILENO As String, ByVal CA_YA As String, ByVal CA_COMPANY_CODE As String, ByVal CA_SOURCENO As Decimal, _
                           ByVal CA_MODE As String, ByVal CA_ASSET_CODE As String, ByVal CA_ASSET As String, ByVal CA_CATEGORY_CODE As String, _
                           ByVal CA_PURCHASE_DATE As DateTime, ByVal CA_PURCHASE_YEAR As String, ByVal CA_PURCHASE_AMOUNT As Decimal, _
                           ByVal CA_PAYMENT As Decimal, ByVal CA_RESTRICTED_QC As Decimal, ByVal CA_DESC As String, _
                           ByVal CA_RATE_IA As Integer, ByVal CA_RATE_AA As Integer, ByVal CA_QUALIFYING_COST As Decimal, _
                           ByVal CA_REMAIN_QC As Decimal, ByVal CA_TWDV As Decimal, ByVal CA_INCENTIVE As String, _
                           ByVal CA_CTRL_TRANSFER As Integer, ByVal HP_CODE As String, ByVal CA_ACCELERATED As String, _
                           ByVal CA_CAEEO As Boolean, ByVal CA_REC As Boolean, ByVal CA_DEFERREDCLAIM As Boolean, ByVal CA_DEDUCTADJ_INCOME As Boolean, _
                           ByVal CA_TAX_FILE_NUMBER As String, ByVal CA_TRANSFERROR_NAME As String, ByVal CA_TRANSFER_VAL As String, _
                            Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "UPDATE CA SET CA_MODE=@CA_MODE,CA_PREFIX=@CA_PREFIX,CA_REF_NO=@CA_REF_NO,CA_NAME=@CA_NAME,CA_FILENO=@CA_FILENO,CA_YA=@CA_YA,CA_COMPANY_CODE=@CA_COMPANY_CODE,CA_SOURCENO=@CA_SOURCENO,"
            StrSQL += "CA_ASSET_CODE=@CA_ASSET_CODE,CA_ASSET=@CA_ASSET,CA_CATEGORY_CODE=@CA_CATEGORY_CODE,CA_PURCHASE_DATE=@CA_PURCHASE_DATE,CA_PURCHASE_YEAR=@CA_PURCHASE_YEAR,CA_PURCHASE_AMOUNT=@CA_PURCHASE_AMOUNT,CA_PAYMENT=@CA_PAYMENT,CA_RESTRICTED_QC=@CA_RESTRICTED_QC,"
            StrSQL += "CA_DESC=@CA_DESC,CA_RATE_IA=@CA_RATE_IA,CA_RATE_AA=@CA_RATE_AA,CA_QUALIFYING_COST=@CA_QUALIFYING_COST,CA_REMAIN_QC=@CA_REMAIN_QC,CA_TWDV=@CA_TWDV,CA_INCENTIVE=@CA_INCENTIVE,CA_CTRL_TRANSFER=@CA_CTRL_TRANSFER,HP_CODE=@HP_CODE,CA_ACCELERATED=@CA_ACCELERATED,"
            StrSQL += "CA_CAEEO=@CA_CAEEO,CA_REC=@CA_REC,CA_DEFERREDCLAIM=@CA_DEFERREDCLAIM,CA_DEDUCTADJ_INCOME=@CA_DEDUCTADJ_INCOME,CA_TAX_FILE_NUMBER=@CA_TAX_FILE_NUMBER,CA_TRANSFERROR_NAME=@CA_TRANSFERROR_NAME,CA_TRANSFER_VAL=@CA_TRANSFER_VAL WHERE CA_KEY=@CA_KEY"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@CA_KEY", SqlDbType.Int).Value = CA_KEY
            SQLcmd.Parameters.Add("@CA_MODE", SqlDbType.NVarChar, 3).Value = CA_MODE
            SQLcmd.Parameters.Add("@CA_PREFIX", SqlDbType.NVarChar, 3).Value = "C"
            SQLcmd.Parameters.Add("@CA_REF_NO", SqlDbType.NVarChar, 20).Value = CA_REF_NO
            SQLcmd.Parameters.Add("@CA_NAME", SqlDbType.NVarChar, 255).Value = CA_NAME
            SQLcmd.Parameters.Add("@CA_FILENO", SqlDbType.NVarChar, 20).Value = CA_FILENO
            SQLcmd.Parameters.Add("@CA_YA", SqlDbType.NVarChar, 5).Value = CA_YA
            SQLcmd.Parameters.Add("@CA_COMPANY_CODE", SqlDbType.NVarChar, 8).Value = CA_COMPANY_CODE
            SQLcmd.Parameters.Add("@CA_SOURCENO", SqlDbType.Decimal).Value = CA_SOURCENO
            SQLcmd.Parameters.Add("@CA_ASSET_CODE", SqlDbType.NVarChar, 20).Value = CA_ASSET_CODE
            SQLcmd.Parameters.Add("@CA_ASSET", SqlDbType.NVarChar, 255).Value = CA_ASSET
            SQLcmd.Parameters.Add("@CA_CATEGORY_CODE", SqlDbType.NVarChar, 20).Value = CA_CATEGORY_CODE
            SQLcmd.Parameters.Add("@CA_PURCHASE_DATE", SqlDbType.DateTime).Value = CA_PURCHASE_DATE
            SQLcmd.Parameters.Add("@CA_PURCHASE_YEAR", SqlDbType.NVarChar, 5).Value = CA_PURCHASE_YEAR
            SQLcmd.Parameters.Add("@CA_PURCHASE_AMOUNT", SqlDbType.NVarChar, 25).Value = CStr(CA_PURCHASE_AMOUNT)
            SQLcmd.Parameters.Add("@CA_PAYMENT", SqlDbType.NVarChar, 25).Value = CStr(CA_PAYMENT)
            SQLcmd.Parameters.Add("@CA_RESTRICTED_QC", SqlDbType.NVarChar, 25).Value = CStr(CA_RESTRICTED_QC)
            SQLcmd.Parameters.Add("@CA_DESC", SqlDbType.NVarChar, 255).Value = CA_DESC
            SQLcmd.Parameters.Add("@CA_RATE_IA", SqlDbType.Float).Value = CA_RATE_IA
            SQLcmd.Parameters.Add("@CA_RATE_AA", SqlDbType.Float).Value = CA_RATE_AA
            SQLcmd.Parameters.Add("@CA_QUALIFYING_COST", SqlDbType.NVarChar, 25).Value = CStr(CA_QUALIFYING_COST)
            SQLcmd.Parameters.Add("@CA_REMAIN_QC", SqlDbType.NVarChar, 25).Value = CStr(CA_REMAIN_QC)
            SQLcmd.Parameters.Add("@CA_TWDV", SqlDbType.NVarChar, 25).Value = CStr(CA_TWDV)
            SQLcmd.Parameters.Add("@CA_INCENTIVE", SqlDbType.NVarChar, 3).Value = CA_INCENTIVE
            SQLcmd.Parameters.Add("@CA_CTRL_TRANSFER", SqlDbType.Int).Value = CA_CTRL_TRANSFER
            SQLcmd.Parameters.Add("@HP_CODE", SqlDbType.NVarChar, 255).Value = IIf(HP_CODE Is Nothing, "", HP_CODE)
            SQLcmd.Parameters.Add("@CA_ACCELERATED", SqlDbType.NVarChar, 20).Value = CA_ACCELERATED
            '//New Column Update
            SQLcmd.Parameters.Add("@CA_CAEEO", SqlDbType.Bit).Value = CA_CAEEO
            SQLcmd.Parameters.Add("@CA_REC", SqlDbType.Bit).Value = CA_REC
            SQLcmd.Parameters.Add("@CA_DEFERREDCLAIM", SqlDbType.Bit).Value = CA_DEFERREDCLAIM
            SQLcmd.Parameters.Add("@CA_DEDUCTADJ_INCOME", SqlDbType.Bit).Value = CA_DEDUCTADJ_INCOME
            SQLcmd.Parameters.Add("@CA_TAX_FILE_NUMBER", SqlDbType.NVarChar, 255).Value = CA_TAX_FILE_NUMBER
            SQLcmd.Parameters.Add("@CA_TRANSFERROR_NAME", SqlDbType.NVarChar, 255).Value = CA_TRANSFERROR_NAME
            SQLcmd.Parameters.Add("@CA_TRANSFER_VAL", SqlDbType.NVarChar, 25).Value = CA_TRANSFER_VAL

            Return ADO.ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
    Public Function Update_Disposal(ByVal CA_DISP_KEY As Integer, ByVal CA_KEY As Integer, ByVal CA_DISP_YA As Integer, _
                                  ByVal CA_DISP_DATE As DateTime, ByVal CA_DISP_WITHIN_2 As Boolean, _
                                  ByVal CA_DISP_AMOUNT As Decimal, ByVal CA_DISP_QC As Decimal, ByVal CA_DISP_BALANCE As Decimal, _
                                  ByVal CA_DISP_TWDV As Decimal, ByVal CA_DISP_SPROCEED As Decimal, _
                                  ByVal CA_DISP_BABC As Decimal, ByVal CA_DISP_REMARKS As String, ByVal CA_ACCUMULATED As Decimal, _
                                  ByVal CA_TRANSFEREE_NAME As String, ByVal CA_TAX_FILE_NO As String, ByVal CA_DISP_TYPE As Integer, _
                                  ByRef ReturnID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "UPDATE CA_DISPOSAL SET CA_DISP_DATE=@CA_DISP_DATE,CA_DISP_WITHIN_2=@CA_DISP_WITHIN_2,CA_DISP_AMOUNT=@CA_DISP_AMOUNT,CA_DISP_QC=@CA_DISP_QC,CA_DISP_BALANCE=@CA_DISP_BALANCE,CA_DISP_TWDV=@CA_DISP_TWDV,CA_DISP_SPROCEED=@CA_DISP_SPROCEED,CA_DISP_BABC=@CA_DISP_BABC,CA_DISP_REMARKS=@CA_DISP_REMARKS,CA_ACCUMULATED=@CA_ACCUMULATED,CA_TRANSFEREE_NAME=@CA_TRANSFEREE_NAME,CA_TAX_FILE_NO=@CA_TAX_FILE_NO,CA_DISP_TYPE=@CA_DISP_TYPE WHERE CA_DISP_KEY=@CA_DISP_KEY AND CA_KEY=@CA_KEY AND CA_DISP_YA=@CA_DISP_YA"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@CA_DISP_KEY", SqlDbType.Int).Value = CA_DISP_KEY
            SQLcmd.Parameters.Add("@CA_KEY", SqlDbType.Int).Value = CA_KEY
            SQLcmd.Parameters.Add("@CA_DISP_YA", SqlDbType.NVarChar, 5).Value = CA_DISP_YA
            SQLcmd.Parameters.Add("@CA_DISP_DATE", SqlDbType.DateTime).Value = CA_DISP_DATE
            SQLcmd.Parameters.Add("@CA_DISP_WITHIN_2", SqlDbType.NVarChar, 3).Value = CA_DISP_WITHIN_2
            SQLcmd.Parameters.Add("@CA_DISP_AMOUNT", SqlDbType.NVarChar, 25).Value = CA_DISP_AMOUNT
            SQLcmd.Parameters.Add("@CA_DISP_QC", SqlDbType.NVarChar, 25).Value = CA_DISP_QC
            SQLcmd.Parameters.Add("@CA_DISP_BALANCE", SqlDbType.NVarChar, 25).Value = CA_DISP_BALANCE
            SQLcmd.Parameters.Add("@CA_DISP_TWDV", SqlDbType.NVarChar, 25).Value = CA_DISP_TWDV
            SQLcmd.Parameters.Add("@CA_DISP_SPROCEED", SqlDbType.NVarChar, 25).Value = CA_DISP_SPROCEED
            SQLcmd.Parameters.Add("@CA_DISP_BABC", SqlDbType.NVarChar, 25).Value = CA_DISP_BABC
            SQLcmd.Parameters.Add("@CA_DISP_REMARKS", SqlDbType.NVarChar, 255).Value = IIf(CA_DISP_REMARKS Is Nothing, "", CA_DISP_REMARKS)
            SQLcmd.Parameters.Add("@CA_ACCUMULATED", SqlDbType.NVarChar, 25).Value = CA_ACCUMULATED
            SQLcmd.Parameters.Add("@CA_TRANSFEREE_NAME", SqlDbType.NVarChar, 255).Value = IIf(CA_TRANSFEREE_NAME Is Nothing, "", CA_TRANSFEREE_NAME)
            SQLcmd.Parameters.Add("@CA_TAX_FILE_NO", SqlDbType.NVarChar, 255).Value = IIf(CA_TAX_FILE_NO Is Nothing, "", CA_TAX_FILE_NO)
            SQLcmd.Parameters.Add("@CA_DISP_TYPE", SqlDbType.Int).Value = CA_DISP_TYPE

            Dim rlst As Boolean = ADO.ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If rlst = True Then
                ReturnID = CA_DISP_KEY
            End If

            Return rlst
        Catch ex As Exception
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
#End Region
#Region "PNL"
    Public Function Update_ProfitAndLoss_Query(ByVal dt As DataTable, ByRef Listofcmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "UPDATE PROFIT_LOSS_ACCOUNT SET PL_REF_NO=@PL_REF_NO,PL_YA=@PL_YA,PL_SALES=@PL_SALES,PL_OP_STK=@PL_OP_STK,PL_PURCHASES=@PL_PURCHASES,PL_PRO_COST=@PL_PRO_COST,PL_PRO_COST_DPC=@PL_PRO_COST_DPC,PL_PRO_COST_OAE=@PL_PRO_COST_OAE,PL_PRO_COST_ONAE=@PL_PRO_COST_ONAE,PL_PURCHASES_PRO_COST=@PL_PURCHASES_PRO_COST,PL_CLS_STK=@PL_CLS_STK,PL_COGS=@PL_COGS,PL_GROSS_PROFIT=@PL_GROSS_PROFIT,PL_OTH_BSIN=@PL_OTH_BSIN,PL_OTH_BSIN_UNREALGT=@PL_OTH_BSIN_UNREALGT,PL_OTH_BSIN_REALGT=@PL_OTH_BSIN_REALGT,PL_OTH_BSIN_RENTAL=@PL_OTH_BSIN_RENTAL,PL_OTH_BSIN_OTHER=@PL_OTH_BSIN_OTHER,PL_OTH_IN=@PL_OTH_IN,PL_OTH_IN_DIVIDEND=@PL_OTH_IN_DIVIDEND,PL_OTH_IN_INTEREST=@PL_OTH_IN_INTEREST,PL_OTH_IN_RENTAL=@PL_OTH_IN_RENTAL,PL_OTH_IN_ROYALTY=@PL_OTH_IN_ROYALTY,PL_OTH_IN_OTHER=@PL_OTH_IN_OTHER,PL_NONTAX_IN=@PL_NONTAX_IN,PL_NONTAX_IN_FA_DISP=@PL_NONTAX_IN_FA_DISP,PL_NONTAX_IN_INV_DISP=@PL_NONTAX_IN_INV_DISP,PL_NONTAX_IN_EXM_DIV=@PL_NONTAX_IN_EXM_DIV,PL_NONTAX_IN_FIR=@PL_NONTAX_IN_FIR,PL_NONTAX_IN_REALG=@PL_NONTAX_IN_REALG,PL_NONTAX_IN_UNREALG=@PL_NONTAX_IN_UNREALG,PL_NONTAX_IN_INSU_COMP=@PL_NONTAX_IN_INSU_COMP,PL_EXP_INT=@PL_EXP_INT,PL_LAWYER_COST=@PL_LAWYER_COST,PL_CONTRACT_EXP=@PL_CONTRACT_EXP,PL_EXP_SALARY=@PL_EXP_SALARY,PL_ROYALTY=@PL_ROYALTY,PL_EXP_RENT=@PL_EXP_RENT,PL_EXP_MAINTENANCE=@PL_EXP_MAINTENANCE,PL_RND=@PL_RND,PL_ADVERT=@PL_ADVERT,PL_TRAVEL=@PL_TRAVEL,PL_OTHER_EXP=@PL_OTHER_EXP,PL_OTHER_EXP_DPC=@PL_OTHER_EXP_DPC,PL_OTHER_EXP_DNT=@PL_OTHER_EXP_DNT,PL_OTHER_EXP_DNT_APP=@PL_OTHER_EXP_DNT_APP,PL_OTHER_EXP_DNT_NAPP=@PL_OTHER_EXP_DNT_NAPP,PL_OTHER_EXP_FA_DISP=@PL_OTHER_EXP_FA_DISP,PL_OTHER_EXP_ENTM=@PL_OTHER_EXP_ENTM,PL_OTHER_EXP_ENTM_CLNT=@PL_OTHER_EXP_ENTM_CLNT,PL_OTHER_EXP_ENTM_STFF=@PL_OTHER_EXP_ENTM_STFF,PL_OTHER_EXP_PENALTY=@PL_OTHER_EXP_PENALTY,PL_OTHER_EXP_PROV_ACC=@PL_OTHER_EXP_PROV_ACC,PL_OTHER_EXP_LEAVE=@PL_OTHER_EXP_LEAVE,PL_OTHER_EXP_FA_WO=@PL_OTHER_EXP_FA_WO,PL_OTHER_EXP_UNREALOSS=@PL_OTHER_EXP_UNREALOSS,PL_OTHER_EXP_REALOSS=@PL_OTHER_EXP_REALOSS,PL_OTHER_EXP_INI_SUB=@PL_OTHER_EXP_INI_SUB,PL_OTHER_EXP_CAP_EXP=@PL_OTHER_EXP_CAP_EXP,PL_OTHER_EXP_OTHERS=@PL_OTHER_EXP_OTHERS,PL_TOT_EXP=@PL_TOT_EXP,PL_NET_PROFIT_LOSS=@PL_NET_PROFIT_LOSS,PL_DISALLOWED_EXP=@PL_DISALLOWED_EXP,PL_TOTALX=@PL_TOTALX,PL_TOTALY=@PL_TOTALY,PL_EXP_INTRESTRICT=@PL_EXP_INTRESTRICT,PL_OTH_BSIN_NONSOURCE=@PL_OTH_BSIN_NONSOURCE,PL_S60F=@PL_S60F,PL_MAINBUZ=@PL_MAINBUZ,PL_OTHER_EXP_ZAKAT=@PL_OTHER_EXP_ZAKAT,PL_COMPANY=@PL_COMPANY,PL_TREGROSS=@PL_TREGROSS,PL_TTAXDEDUCTION=@PL_TTAXDEDUCTION,PL_TNETDEDUCTION=@PL_TNETDEDUCTION,PL_TECH_FEE=@PL_TECH_FEE,PL_EMPL_STOCK=@PL_EMPL_STOCK,PL_S60FA=@PL_S60FA,PL_OTHER_EXP_BALANCE=@PL_OTHER_EXP_BALANCE,PL_OTHER_EXRLOSSFOREIGNT=@PL_OTHER_EXRLOSSFOREIGNT,PL_DIRECTORS_FEE=@PL_DIRECTORS_FEE,PL_JKDM=@PL_JKDM,ModifiedBy=@ModifiedBy,ModifiedDateTime=@ModifiedDateTime,PNL_Status=@PNL_Status WHERE PL_KEY=@PL_KEY"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = dt.Rows(0)("PL_KEY")
            SQLcmd.Parameters.Add("@PL_REF_NO", SqlDbType.NVarChar, 20).Value = dt.Rows(0)("PL_REF_NO")
            SQLcmd.Parameters.Add("@PL_YA", SqlDbType.NVarChar, 5).Value = dt.Rows(0)("PL_YA")
            SQLcmd.Parameters.Add("@PL_SALES", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_SALES")), 0, dt.Rows(0)("PL_SALES"))
            SQLcmd.Parameters.Add("@PL_OP_STK", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OP_STK")), 0, dt.Rows(0)("PL_OP_STK"))
            SQLcmd.Parameters.Add("@PL_PURCHASES", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_PURCHASES")), 0, dt.Rows(0)("PL_PURCHASES"))
            SQLcmd.Parameters.Add("@PL_PRO_COST", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_PRO_COST")), 0, dt.Rows(0)("PL_PRO_COST"))
            SQLcmd.Parameters.Add("@PL_PRO_COST_DPC", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_PRO_COST_DPC")), 0, dt.Rows(0)("PL_PRO_COST_DPC"))
            SQLcmd.Parameters.Add("@PL_PRO_COST_OAE", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_PRO_COST_OAE")), 0, dt.Rows(0)("PL_PRO_COST_OAE"))
            SQLcmd.Parameters.Add("@PL_PRO_COST_ONAE", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_PRO_COST_ONAE")), 0, dt.Rows(0)("PL_PRO_COST_ONAE"))
            SQLcmd.Parameters.Add("@PL_PURCHASES_PRO_COST", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_PURCHASES_PRO_COST")), 0, dt.Rows(0)("PL_PURCHASES_PRO_COST"))
            SQLcmd.Parameters.Add("@PL_CLS_STK", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_CLS_STK")), 0, dt.Rows(0)("PL_CLS_STK"))
            SQLcmd.Parameters.Add("@PL_COGS", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_COGS")), 0, dt.Rows(0)("PL_COGS"))
            SQLcmd.Parameters.Add("@PL_GROSS_PROFIT", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_GROSS_PROFIT")), 0, dt.Rows(0)("PL_GROSS_PROFIT"))
            SQLcmd.Parameters.Add("@PL_OTH_BSIN", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_BSIN")), 0, dt.Rows(0)("PL_OTH_BSIN"))
            SQLcmd.Parameters.Add("@PL_OTH_BSIN_UNREALGT", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_BSIN_UNREALGT")), 0, dt.Rows(0)("PL_OTH_BSIN_UNREALGT"))
            SQLcmd.Parameters.Add("@PL_OTH_BSIN_REALGT", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_BSIN_REALGT")), 0, dt.Rows(0)("PL_OTH_BSIN_REALGT"))
            SQLcmd.Parameters.Add("@PL_OTH_BSIN_RENTAL", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_BSIN_RENTAL")), 0, dt.Rows(0)("PL_OTH_BSIN_RENTAL"))
            SQLcmd.Parameters.Add("@PL_OTH_BSIN_OTHER", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_BSIN_OTHER")), 0, dt.Rows(0)("PL_OTH_BSIN_OTHER"))
            SQLcmd.Parameters.Add("@PL_OTH_IN", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_IN")), 0, dt.Rows(0)("PL_OTH_IN"))
            SQLcmd.Parameters.Add("@PL_OTH_IN_DIVIDEND", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_IN_DIVIDEND")), 0, dt.Rows(0)("PL_OTH_IN_DIVIDEND"))
            SQLcmd.Parameters.Add("@PL_OTH_IN_INTEREST", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_IN_INTEREST")), 0, dt.Rows(0)("PL_OTH_IN_INTEREST"))
            SQLcmd.Parameters.Add("@PL_OTH_IN_RENTAL", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_IN_RENTAL")), 0, dt.Rows(0)("PL_OTH_IN_RENTAL"))
            SQLcmd.Parameters.Add("@PL_OTH_IN_ROYALTY", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_IN_ROYALTY")), 0, dt.Rows(0)("PL_OTH_IN_ROYALTY"))
            SQLcmd.Parameters.Add("@PL_OTH_IN_OTHER", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_IN_OTHER")), 0, dt.Rows(0)("PL_OTH_IN_OTHER"))
            SQLcmd.Parameters.Add("@PL_NONTAX_IN", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_NONTAX_IN")), 0, dt.Rows(0)("PL_NONTAX_IN"))
            SQLcmd.Parameters.Add("@PL_NONTAX_IN_FA_DISP", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_NONTAX_IN_FA_DISP")), 0, dt.Rows(0)("PL_NONTAX_IN_FA_DISP"))
            SQLcmd.Parameters.Add("@PL_NONTAX_IN_INV_DISP", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_NONTAX_IN_INV_DISP")), 0, dt.Rows(0)("PL_NONTAX_IN_INV_DISP"))
            SQLcmd.Parameters.Add("@PL_NONTAX_IN_EXM_DIV", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_NONTAX_IN_EXM_DIV")), 0, dt.Rows(0)("PL_NONTAX_IN_EXM_DIV"))
            SQLcmd.Parameters.Add("@PL_NONTAX_IN_FIR", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_NONTAX_IN_FIR")), 0, dt.Rows(0)("PL_NONTAX_IN_FIR"))
            SQLcmd.Parameters.Add("@PL_NONTAX_IN_REALG", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_NONTAX_IN_REALG")), 0, dt.Rows(0)("PL_NONTAX_IN_REALG"))
            SQLcmd.Parameters.Add("@PL_NONTAX_IN_UNREALG", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_NONTAX_IN_UNREALG")), 0, dt.Rows(0)("PL_NONTAX_IN_UNREALG"))
            SQLcmd.Parameters.Add("@PL_NONTAX_IN_INSU_COMP", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_NONTAX_IN_INSU_COMP")), 0, dt.Rows(0)("PL_NONTAX_IN_INSU_COMP"))
            SQLcmd.Parameters.Add("@PL_EXP_INT", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_EXP_INT")), 0, dt.Rows(0)("PL_EXP_INT"))
            SQLcmd.Parameters.Add("@PL_LAWYER_COST", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_LAWYER_COST")), 0, dt.Rows(0)("PL_LAWYER_COST"))
            SQLcmd.Parameters.Add("@PL_CONTRACT_EXP", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_CONTRACT_EXP")), 0, dt.Rows(0)("PL_CONTRACT_EXP"))
            SQLcmd.Parameters.Add("@PL_EXP_SALARY", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_EXP_SALARY")), 0, dt.Rows(0)("PL_EXP_SALARY"))
            SQLcmd.Parameters.Add("@PL_ROYALTY", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_ROYALTY")), 0, dt.Rows(0)("PL_ROYALTY"))
            SQLcmd.Parameters.Add("@PL_EXP_RENT", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_EXP_RENT")), 0, dt.Rows(0)("PL_EXP_RENT"))
            SQLcmd.Parameters.Add("@PL_EXP_MAINTENANCE", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_EXP_MAINTENANCE")), 0, dt.Rows(0)("PL_EXP_MAINTENANCE"))
            SQLcmd.Parameters.Add("@PL_RND", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_RND")), 0, dt.Rows(0)("PL_RND"))
            SQLcmd.Parameters.Add("@PL_ADVERT", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_ADVERT")), 0, dt.Rows(0)("PL_ADVERT"))
            SQLcmd.Parameters.Add("@PL_TRAVEL", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_TRAVEL")), 0, dt.Rows(0)("PL_TRAVEL"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP")), 0, dt.Rows(0)("PL_OTHER_EXP"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_DPC", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_DPC")), 0, dt.Rows(0)("PL_OTHER_EXP_DPC"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_DNT", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_DNT")), 0, dt.Rows(0)("PL_OTHER_EXP_DNT"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_DNT_APP", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_DNT_APP")), 0, dt.Rows(0)("PL_OTHER_EXP_DNT_APP"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_DNT_NAPP", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_DNT_NAPP")), 0, dt.Rows(0)("PL_OTHER_EXP_DNT_NAPP"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_FA_DISP", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_FA_DISP")), 0, dt.Rows(0)("PL_OTHER_EXP_FA_DISP"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_ENTM", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_ENTM")), 0, dt.Rows(0)("PL_OTHER_EXP_ENTM"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_ENTM_CLNT", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_ENTM_CLNT")), 0, dt.Rows(0)("PL_OTHER_EXP_ENTM_CLNT"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_ENTM_STFF", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_ENTM_STFF")), 0, dt.Rows(0)("PL_OTHER_EXP_ENTM_STFF"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_PENALTY", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_PENALTY")), 0, dt.Rows(0)("PL_OTHER_EXP_PENALTY"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_PROV_ACC", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_PROV_ACC")), 0, dt.Rows(0)("PL_OTHER_EXP_PROV_ACC"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_LEAVE", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_LEAVE")), 0, dt.Rows(0)("PL_OTHER_EXP_LEAVE"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_FA_WO", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_FA_WO")), 0, dt.Rows(0)("PL_OTHER_EXP_FA_WO"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_UNREALOSS", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_UNREALOSS")), 0, dt.Rows(0)("PL_OTHER_EXP_UNREALOSS"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_REALOSS", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_REALOSS")), 0, dt.Rows(0)("PL_OTHER_EXP_REALOSS"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_INI_SUB", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_INI_SUB")), 0, dt.Rows(0)("PL_OTHER_EXP_INI_SUB"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_CAP_EXP", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_CAP_EXP")), 0, dt.Rows(0)("PL_OTHER_EXP_CAP_EXP"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_OTHERS", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_OTHERS")), 0, dt.Rows(0)("PL_OTHER_EXP_OTHERS"))
            SQLcmd.Parameters.Add("@PL_TOT_EXP", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_TOT_EXP")), 0, dt.Rows(0)("PL_TOT_EXP"))
            SQLcmd.Parameters.Add("@PL_NET_PROFIT_LOSS", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_NET_PROFIT_LOSS")), 0, dt.Rows(0)("PL_NET_PROFIT_LOSS"))
            SQLcmd.Parameters.Add("@PL_DISALLOWED_EXP", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_DISALLOWED_EXP")), 0, dt.Rows(0)("PL_DISALLOWED_EXP"))
            SQLcmd.Parameters.Add("@PL_TOTALX", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_TOTALX")), 0, dt.Rows(0)("PL_TOTALX"))
            SQLcmd.Parameters.Add("@PL_TOTALY", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_TOTALY")), 0, dt.Rows(0)("PL_TOTALY"))
            SQLcmd.Parameters.Add("@PL_EXP_INTRESTRICT", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_EXP_INTRESTRICT")), 0, dt.Rows(0)("PL_EXP_INTRESTRICT"))
            SQLcmd.Parameters.Add("@PL_OTH_BSIN_NONSOURCE", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTH_BSIN_NONSOURCE")), 0, dt.Rows(0)("PL_OTH_BSIN_NONSOURCE"))
            SQLcmd.Parameters.Add("@PL_S60F", SqlDbType.NVarChar, 1).Value = dt.Rows(0)("PL_S60F")
            SQLcmd.Parameters.Add("@PL_MAINBUZ", SqlDbType.Int).Value = dt.Rows(0)("PL_MAINBUZ")
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_ZAKAT", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_ZAKAT")), 0, dt.Rows(0)("PL_OTHER_EXP_ZAKAT"))
            SQLcmd.Parameters.Add("@PL_COMPANY", SqlDbType.NVarChar, 8).Value = dt.Rows(0)("PL_COMPANY")
            SQLcmd.Parameters.Add("@PL_TREGROSS", SqlDbType.NVarChar, 25).Value = dt.Rows(0)("PL_TREGROSS")
            SQLcmd.Parameters.Add("@PL_TTAXDEDUCTION", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_TTAXDEDUCTION")), 0, dt.Rows(0)("PL_TTAXDEDUCTION"))
            SQLcmd.Parameters.Add("@PL_TNETDEDUCTION", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_TNETDEDUCTION")), 0, dt.Rows(0)("PL_TNETDEDUCTION"))
            SQLcmd.Parameters.Add("@PL_TECH_FEE", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_TECH_FEE")), 0, dt.Rows(0)("PL_TECH_FEE"))
            SQLcmd.Parameters.Add("@PL_EMPL_STOCK", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_EMPL_STOCK")), 0, dt.Rows(0)("PL_EMPL_STOCK"))
            SQLcmd.Parameters.Add("@PL_S60FA", SqlDbType.NVarChar, 1).Value = dt.Rows(0)("PL_S60FA")
            SQLcmd.Parameters.Add("@PL_OTHER_EXP_BALANCE", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXP_BALANCE")), 0, dt.Rows(0)("PL_OTHER_EXP_BALANCE"))
            SQLcmd.Parameters.Add("@PL_OTHER_EXRLOSSFOREIGNT", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_OTHER_EXRLOSSFOREIGNT")), 0, dt.Rows(0)("PL_OTHER_EXRLOSSFOREIGNT"))
            SQLcmd.Parameters.Add("@PL_DIRECTORS_FEE", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_DIRECTORS_FEE")), 0, dt.Rows(0)("PL_DIRECTORS_FEE"))
            SQLcmd.Parameters.Add("@PL_JKDM", SqlDbType.NVarChar, 25).Value = IIf(IsDBNull(dt.Rows(0)("PL_JKDM")), 0, dt.Rows(0)("PL_JKDM"))
            SQLcmd.Parameters.Add("@ModifiedBy", SqlDbType.NVarChar, 100).Value = IIf(IsDBNull(dt.Rows(0)("ModifiedBy")), My.Computer.Name, dt.Rows(0)("ModifiedBy"))
            SQLcmd.Parameters.Add("@ModifiedDateTime", SqlDbType.DateTime).Value = Now
            SQLcmd.Parameters.Add("@PNL_Status", SqlDbType.NVarChar, 20).Value = IIf(IsDBNull(dt.Rows(0)("PNL_Status")), "New", dt.Rows(0)("PNL_Status"))


            Listofcmd.Add(SQLcmd)
            Return True
        Catch ex As Exception
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
#End Region
#Region "OTHER"

    Public Function Update_UserNote(ByVal Name As String, ByVal Note As String, _
                                  ByVal ID As Decimal, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "UPDATE USER_NOTE SET PCName=@PCName,Name=@Name,Datetime=@Datetime,Note=@Note WHERE ID=@ID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.Decimal).Value = ID
            SQLcmd.Parameters.Add("@PCName", SqlDbType.NVarChar, 250).Value = My.Computer.Name
            SQLcmd.Parameters.Add("@Name", SqlDbType.NVarChar, 3).Value = Name
            SQLcmd.Parameters.Add("@Datetime", SqlDbType.DateTime).Value = Now
            SQLcmd.Parameters.Add("@Note", SqlDbType.NVarChar, 4000).Value = Note

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

            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function Update_DeemedInterest_Rate(ByVal YA As Integer, _
                                            ByVal Jan As Decimal, ByVal Feb As Decimal, ByVal Mac As Decimal, ByVal Apr As Decimal, _
                                            ByVal May As Decimal, ByVal Jun As Decimal, ByVal Jul As Decimal, ByVal Aug As Decimal, _
                                            ByVal Sep As Decimal, ByVal Oct As Decimal, ByVal Nov As Decimal, ByVal Dec As Decimal, _
                                            Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "UPDATE DEEMED_INTEREST_RATE SET Jan=@Jan,Feb=@Feb,Mac=@Mac,Apr=@Apr,May=@May,Jun=@Jun,Jul=@Jul,Aug=@Aug,Sep=@Sep,Oct=@Oct,Nov=@Nov,Dec=@Dec WHERE YA=@YA"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = YA
            SQLcmd.Parameters.Add("@Jan", SqlDbType.Decimal).Value = Jan
            SQLcmd.Parameters.Add("@Feb", SqlDbType.Decimal).Value = Feb
            SQLcmd.Parameters.Add("@Mac", SqlDbType.Decimal).Value = Mac
            SQLcmd.Parameters.Add("@Apr", SqlDbType.Decimal).Value = Apr
            SQLcmd.Parameters.Add("@May", SqlDbType.Decimal).Value = May
            SQLcmd.Parameters.Add("@Jun", SqlDbType.Decimal).Value = Jun
            SQLcmd.Parameters.Add("@Jul", SqlDbType.Decimal).Value = Jul
            SQLcmd.Parameters.Add("@Aug", SqlDbType.Decimal).Value = Aug
            SQLcmd.Parameters.Add("@Sep", SqlDbType.Decimal).Value = Sep
            SQLcmd.Parameters.Add("@Oct", SqlDbType.Decimal).Value = Oct
            SQLcmd.Parameters.Add("@Nov", SqlDbType.Decimal).Value = Nov
            SQLcmd.Parameters.Add("@Dec", SqlDbType.Decimal).Value = Dec

            Return ADO.ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
#End Region
#Region "MOVEMENT"
    Public Function Update_MovementNormal(ByVal ID As Integer, ByVal RefNo As String, ByVal YA As String, ByVal Title As String, _
                                        ByVal PeriodEnd As DateTime, ByVal YearEnded As DateTime, _
                                        ByVal BalanceStart As DateTime, ByVal BalanceEnd As DateTime, _
                                        ByVal AmountStart As Decimal, ByVal AmountEnd As Decimal, _
                                        ByVal NoteStart As String, ByVal NoteEnd As String, ByVal Total_AddbackDeduct As Decimal, _
                                        ByVal ds As DataSet, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection
            Dim ListofCmd As List(Of SqlCommand)
            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim tmpID As Decimal = 0
            ListofCmd = New List(Of SqlCommand)

            Dim StrSQL As String = "UPDATE MOVEMENT_NORMAL SET MM_REFNO=@MM_REFNO,MM_YA=@MM_YA,MM_TITLE=@MM_TITLE,MM_PERIOD_ENDED=@MM_PERIOD_ENDED,MM_YEAR_ENDED=@MM_YEAR_ENDED,MM_BALANCE_START=@MM_BALANCE_START,MM_BALANCE_END=@MM_BALANCE_END,MM_AMOUNT_START=@MM_AMOUNT_START,MM_AMOUNT_END=@MM_AMOUNT_END,MM_NOTE_START=@MM_NOTE_START,MM_NOTE_END=@MM_NOTE_END,ModifiedBy=@ModifiedBy,ModifiedDateTime=@ModifiedDateTime,MM_ADD_DEDUCT_AMOUNT=@MM_ADD_DEDUCT_AMOUNT WHERE MM_ID=@MM_ID"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@MM_ID", SqlDbType.Int).Value = ID
            SQLcmd.Parameters.Add("@MM_REFNO", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@MM_YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@MM_TITLE", SqlDbType.NVarChar, 250).Value = IIf(Title Is Nothing, "", Title)
            SQLcmd.Parameters.Add("@MM_PERIOD_ENDED", SqlDbType.DateTime).Value = IIf(IsDBNull(PeriodEnd), Now, PeriodEnd)
            SQLcmd.Parameters.Add("@MM_YEAR_ENDED", SqlDbType.DateTime).Value = IIf(IsDBNull(YearEnded), Now, YearEnded)
            SQLcmd.Parameters.Add("@MM_BALANCE_START", SqlDbType.DateTime).Value = IIf(IsDBNull(BalanceStart), Now, BalanceStart)
            SQLcmd.Parameters.Add("@MM_BALANCE_END", SqlDbType.DateTime).Value = IIf(IsDBNull(BalanceEnd), Now, BalanceEnd)
            SQLcmd.Parameters.Add("@MM_AMOUNT_START", SqlDbType.Decimal).Value = IIf(IsNumeric(AmountStart) = False, 0, AmountStart)
            SQLcmd.Parameters.Add("@MM_AMOUNT_END", SqlDbType.Decimal).Value = IIf(IsNumeric(AmountEnd) = False, 0, AmountEnd)
            SQLcmd.Parameters.Add("@MM_NOTE_START", SqlDbType.NVarChar, 250).Value = IIf(NoteStart Is Nothing, "", NoteStart)
            SQLcmd.Parameters.Add("@MM_NOTE_END", SqlDbType.NVarChar, 250).Value = IIf(NoteEnd Is Nothing, "", NoteEnd)
            SQLcmd.Parameters.Add("@ModifiedBy", SqlDbType.NVarChar, 100).Value = My.Computer.Name
            SQLcmd.Parameters.Add("@ModifiedDateTime", SqlDbType.DateTime).Value = Now
            SQLcmd.Parameters.Add("@MM_ADD_DEDUCT_AMOUNT", SqlDbType.Decimal).Value = Total_AddbackDeduct

            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE MOVEMENT_ADD WHERE MM_PARENTID=@MM_ID"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@MM_ID", SqlDbType.Int).Value = ID
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE MOVEMENT_DEDUCT WHERE MM_PARENTID=@MM_ID"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@MM_ID", SqlDbType.Int).Value = ID
            ListofCmd.Add(SQLcmd)

            If ds IsNot Nothing AndAlso ds.Tables("MOVEMENT_ADD").Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables("MOVEMENT_ADD").Rows.Count - 1
                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO MOVEMENT_ADD (MM_PARENTID,MM_Description,MM_Amount,MM_Sequence,MM_AddBack,MM_ADDBACK_AMOUNT) VALUES (@MM_PARENTID,@MM_Description,@MM_Amount,@MM_Sequence,@MM_AddBack,@MM_ADDBACK_AMOUNT)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@MM_PARENTID", SqlDbType.Int).Value = ID
                    SQLcmd.Parameters.Add("@MM_Description", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_ADD").Rows(i)("MM_Description")), "", ds.Tables("MOVEMENT_ADD").Rows(i)("MM_Description"))
                    SQLcmd.Parameters.Add("@MM_Amount", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_ADD").Rows(i)("MM_Amount")), 0, ds.Tables("MOVEMENT_ADD").Rows(i)("MM_Amount"))
                    SQLcmd.Parameters.Add("@MM_Sequence", SqlDbType.Int).Value = i
                    SQLcmd.Parameters.Add("@MM_AddBack", SqlDbType.Bit).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_ADD").Rows(i)("MM_AddBack")), False, ds.Tables("MOVEMENT_ADD").Rows(i)("MM_AddBack"))
                    SQLcmd.Parameters.Add("@MM_ADDBACK_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_ADD").Rows(i)("MM_ADDBACK_AMOUNT")), 0, ds.Tables("MOVEMENT_ADD").Rows(i)("MM_ADDBACK_AMOUNT"))
                    ListofCmd.Add(SQLcmd)
                Next
            End If
            If ds IsNot Nothing AndAlso ds.Tables("MOVEMENT_DEDUCT").Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables("MOVEMENT_DEDUCT").Rows.Count - 1
                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO MOVEMENT_DEDUCT (MM_PARENTID,MM_Description,MM_Amount,MM_Sequence,MM_Deduct,MM_DEDUCT_AMOUNT) VALUES (@MM_PARENTID,@MM_Description,@MM_Amount,@MM_Sequence,@MM_Deduct,@MM_DEDUCT_AMOUNT)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@MM_PARENTID", SqlDbType.Int).Value = ID
                    SQLcmd.Parameters.Add("@MM_Description", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_DEDUCT").Rows(i)("MM_Description")), "", ds.Tables("MOVEMENT_DEDUCT").Rows(i)("MM_Description"))
                    SQLcmd.Parameters.Add("@MM_Amount", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_DEDUCT").Rows(i)("MM_Amount")), 0, ds.Tables("MOVEMENT_DEDUCT").Rows(i)("MM_Amount"))
                    SQLcmd.Parameters.Add("@MM_Sequence", SqlDbType.Int).Value = i
                    SQLcmd.Parameters.Add("@MM_Deduct", SqlDbType.Bit).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_DEDUCT").Rows(i)("MM_Deduct")), False, ds.Tables("MOVEMENT_DEDUCT").Rows(i)("MM_Deduct"))
                    SQLcmd.Parameters.Add("@MM_DEDUCT_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_DEDUCT").Rows(i)("MM_DEDUCT_AMOUNT")), 0, ds.Tables("MOVEMENT_DEDUCT").Rows(i)("MM_DEDUCT_AMOUNT"))

                    ListofCmd.Add(SQLcmd)
                Next
            End If

            If ListofCmd.Count > 0 Then
                Return ADO.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
            Else
                Return True
            End If
        Catch ex As Exception
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
    Public Function Update_MovementComplex(ByVal ID As Integer, ByVal RefNo As String, ByVal YA As String, ByVal Title As String, _
                                   ByVal PeriodEnd As DateTime, ByVal YearEnded As DateTime, _
                                   ByVal BalanceStart As DateTime, ByVal BalanceEnd As DateTime, _
                                   ByVal MM_GENERAL_START As Decimal, ByVal MM_SPECIFIC_ALLOWABLE_START As Decimal, _
                                   ByVal MM_SPECIFIC_NONALLOWABLE_START As Decimal, _
                                   ByVal NoteStart As String, ByVal NoteEnd As String, _
                                   ByVal MM_GENERAL_END As Decimal, ByVal MM_SPECIFIC_ALLOWABLE_END As Decimal, ByVal MM_SPECIFIC_NONALLOWABLE_END As Decimal, ByVal MM_ADD_DEDUCT_AMOUNT As Decimal, _
                                   ByVal ds As DataSet, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection
            Dim ListofCmd As List(Of SqlCommand)
            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            ListofCmd = New List(Of SqlCommand)

            Dim StrSQL As String = "UPDATE MOVEMENT_COMPLEX SET MM_REFNO=@MM_REFNO,MM_YA=@MM_YA,MM_TITLE=@MM_TITLE,MM_PERIOD_ENDED=@MM_PERIOD_ENDED,MM_YEAR_ENDED=@MM_YEAR_ENDED,MM_BALANCE_START=@MM_BALANCE_START,MM_BALANCE_END=@MM_BALANCE_END,MM_GENERAL_START=@MM_GENERAL_START,MM_SPECIFIC_ALLOWABLE_START=@MM_SPECIFIC_ALLOWABLE_START,MM_SPECIFIC_NONALLOWABLE_START=@MM_SPECIFIC_NONALLOWABLE_START,MM_NOTE_START=@MM_NOTE_START,MM_NOTE_END=@MM_NOTE_END,MM_GENERAL_END=@MM_GENERAL_END,MM_SPECIFIC_ALLOWABLE_END=@MM_SPECIFIC_ALLOWABLE_END,MM_SPECIFIC_NONALLOWABLE_END=@MM_SPECIFIC_NONALLOWABLE_END,ModifiedBy=@ModifiedBy,ModifiedDateTime=@ModifiedDateTime,MM_ADD_DEDUCT_AMOUNT=@MM_ADD_DEDUCT_AMOUNT WHERE MM_ID=@MM_ID"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@MM_ID", SqlDbType.Int).Value = ID
            SQLcmd.Parameters.Add("@MM_REFNO", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@MM_YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@MM_TITLE", SqlDbType.NVarChar, 250).Value = IIf(Title Is Nothing, "", Title)
            SQLcmd.Parameters.Add("@MM_PERIOD_ENDED", SqlDbType.DateTime).Value = IIf(IsDBNull(PeriodEnd), Now, PeriodEnd)
            SQLcmd.Parameters.Add("@MM_YEAR_ENDED", SqlDbType.DateTime).Value = IIf(IsDBNull(YearEnded), Now, YearEnded)
            SQLcmd.Parameters.Add("@MM_BALANCE_START", SqlDbType.DateTime).Value = IIf(IsDBNull(BalanceStart), Now, BalanceStart)
            SQLcmd.Parameters.Add("@MM_BALANCE_END", SqlDbType.DateTime).Value = IIf(IsDBNull(BalanceEnd), Now, BalanceEnd)
            SQLcmd.Parameters.Add("@MM_GENERAL_START", SqlDbType.Decimal).Value = IIf(IsNumeric(MM_GENERAL_START) = False, 0, MM_GENERAL_START)
            SQLcmd.Parameters.Add("@MM_SPECIFIC_ALLOWABLE_START", SqlDbType.Decimal).Value = IIf(IsNumeric(MM_SPECIFIC_ALLOWABLE_START) = False, 0, MM_SPECIFIC_ALLOWABLE_START)
            SQLcmd.Parameters.Add("@MM_SPECIFIC_NONALLOWABLE_START", SqlDbType.Decimal).Value = IIf(IsNumeric(MM_SPECIFIC_NONALLOWABLE_START) = False, 0, MM_SPECIFIC_NONALLOWABLE_START)
            SQLcmd.Parameters.Add("@MM_NOTE_START", SqlDbType.NVarChar, 250).Value = IIf(NoteStart Is Nothing, "", NoteStart)
            SQLcmd.Parameters.Add("@MM_NOTE_END", SqlDbType.NVarChar, 250).Value = IIf(NoteEnd Is Nothing, "", NoteEnd)
            SQLcmd.Parameters.Add("@MM_GENERAL_END", SqlDbType.Decimal).Value = IIf(IsNumeric(MM_GENERAL_END), MM_GENERAL_END, 0)
            SQLcmd.Parameters.Add("@MM_SPECIFIC_ALLOWABLE_END", SqlDbType.Decimal).Value = IIf(IsNumeric(MM_SPECIFIC_ALLOWABLE_END), MM_SPECIFIC_ALLOWABLE_END, 0)
            SQLcmd.Parameters.Add("@MM_SPECIFIC_NONALLOWABLE_END", SqlDbType.Decimal).Value = IIf(IsNumeric(MM_SPECIFIC_NONALLOWABLE_END), MM_SPECIFIC_NONALLOWABLE_END, 0)
            SQLcmd.Parameters.Add("@ModifiedBy", SqlDbType.NVarChar, 100).Value = My.Computer.Name
            SQLcmd.Parameters.Add("@ModifiedDateTime", SqlDbType.DateTime).Value = Now
            SQLcmd.Parameters.Add("@MM_ADD_DEDUCT_AMOUNT", SqlDbType.Decimal).Value = MM_ADD_DEDUCT_AMOUNT

            ListofCmd.Add(SQLcmd)

            SQLcmd = Nothing
            StrSQL = "DELETE FROM MOVEMENT_COMPLEX_ADD WHERE MM_PARENTID=@MM_PARENTID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@MM_PARENTID", SqlDbType.Int).Value = ID
            ListofCmd.Add(SQLcmd)

            SQLcmd = Nothing
            StrSQL = "DELETE FROM MOVEMENT_COMPLEX_DEDUCT WHERE MM_PARENTID=@MM_PARENTID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@MM_PARENTID", SqlDbType.Int).Value = ID
            ListofCmd.Add(SQLcmd)

            If ds IsNot Nothing AndAlso ds.Tables("MOVEMENT_COMPLEX_ADD").Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables("MOVEMENT_COMPLEX_ADD").Rows.Count - 1
                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO MOVEMENT_COMPLEX_ADD (MM_PARENTID,MM_Description,MM_Amount,MM_Sequence,MM_GENERAL,MM_SPECIFIC_ALLOWABLE,MM_SPECIFIC_NONALLOWABLE,MM_GENERAL_ADDBACK,MM_SPECIFIC_ALLOWABLE_ADDBACK,MM_SPECIFIC_NONALLOWABLE_ADDBACK,MM_NOTE,MM_ADDBACK_AMOUNT) VALUES (@MM_PARENTID,@MM_Description,@MM_Amount,@MM_Sequence,@MM_GENERAL,@MM_SPECIFIC_ALLOWABLE,@MM_SPECIFIC_NONALLOWABLE,@MM_GENERAL_ADDBACK,@MM_SPECIFIC_ALLOWABLE_ADDBACK,@MM_SPECIFIC_NONALLOWABLE_ADDBACK,@MM_NOTE,@MM_ADDBACK_AMOUNT)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@MM_PARENTID", SqlDbType.Int).Value = ID
                    SQLcmd.Parameters.Add("@MM_Description", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_Description")), "", ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_Description"))
                    SQLcmd.Parameters.Add("@MM_Amount", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_Amount")), 0, ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_Amount"))
                    SQLcmd.Parameters.Add("@MM_Sequence", SqlDbType.Int).Value = i
                    SQLcmd.Parameters.Add("@MM_GENERAL", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_GENERAL")), 0, ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_GENERAL"))
                    SQLcmd.Parameters.Add("@MM_SPECIFIC_ALLOWABLE", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_SPECIFIC_ALLOWABLE")), 0, ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_SPECIFIC_ALLOWABLE"))
                    SQLcmd.Parameters.Add("@MM_SPECIFIC_NONALLOWABLE", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_SPECIFIC_NONALLOWABLE")), 0, ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_SPECIFIC_NONALLOWABLE"))
                    SQLcmd.Parameters.Add("@MM_GENERAL_ADDBACK", SqlDbType.Bit).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_SPECIFIC_NONALLOWABLE")), False, ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_GENERAL_ADDBACK"))
                    SQLcmd.Parameters.Add("@MM_SPECIFIC_ALLOWABLE_ADDBACK", SqlDbType.Bit).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_SPECIFIC_ALLOWABLE_ADDBACK")), False, ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_SPECIFIC_ALLOWABLE_ADDBACK"))
                    SQLcmd.Parameters.Add("@MM_SPECIFIC_NONALLOWABLE_ADDBACK", SqlDbType.Bit).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_SPECIFIC_NONALLOWABLE_ADDBACK")), False, ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_SPECIFIC_NONALLOWABLE_ADDBACK"))
                    SQLcmd.Parameters.Add("@MM_NOTE", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_NOTE")), "", ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_NOTE"))
                    SQLcmd.Parameters.Add("@MM_ADDBACK_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_ADDBACK_AMOUNT")), 0, ds.Tables("MOVEMENT_COMPLEX_ADD").Rows(i)("MM_ADDBACK_AMOUNT"))

                    ListofCmd.Add(SQLcmd)
                Next
            End If
            If ds IsNot Nothing AndAlso ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows.Count - 1
                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO MOVEMENT_COMPLEX_DEDUCT (MM_PARENTID,MM_Description,MM_Amount,MM_Sequence,MM_GENERAL,MM_SPECIFIC_ALLOWABLE,MM_SPECIFIC_NONALLOWABLE,MM_GENERAL_DEDUCT,MM_SPECIFIC_ALLOWABLE_DEDUCT,MM_SPECIFIC_NONALLOWABLE_DEDUCT,MM_NOTE,MM_DEDUCT_AMOUNT) VALUES (@MM_PARENTID,@MM_Description,@MM_Amount,@MM_Sequence,@MM_GENERAL,@MM_SPECIFIC_ALLOWABLE,@MM_SPECIFIC_NONALLOWABLE,@MM_GENERAL_DEDUCT,@MM_SPECIFIC_ALLOWABLE_DEDUCT,@MM_SPECIFIC_NONALLOWABLE_DEDUCT,@MM_NOTE,@MM_DEDUCT_AMOUNT)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@MM_PARENTID", SqlDbType.Int).Value = ID
                    SQLcmd.Parameters.Add("@MM_Description", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_Description")), "", ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_Description"))
                    SQLcmd.Parameters.Add("@MM_Amount", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_Amount")), 0, ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_Amount"))
                    SQLcmd.Parameters.Add("@MM_Sequence", SqlDbType.Int).Value = i
                    SQLcmd.Parameters.Add("@MM_GENERAL", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_GENERAL")), 0, ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_GENERAL"))
                    SQLcmd.Parameters.Add("@MM_SPECIFIC_ALLOWABLE", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_SPECIFIC_ALLOWABLE")), 0, ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_SPECIFIC_ALLOWABLE"))
                    SQLcmd.Parameters.Add("@MM_SPECIFIC_NONALLOWABLE", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_SPECIFIC_NONALLOWABLE")), 0, ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_SPECIFIC_NONALLOWABLE"))
                    SQLcmd.Parameters.Add("@MM_GENERAL_DEDUCT", SqlDbType.Bit).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_SPECIFIC_NONALLOWABLE")), False, ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_GENERAL_DEDUCT"))
                    SQLcmd.Parameters.Add("@MM_SPECIFIC_ALLOWABLE_DEDUCT", SqlDbType.Bit).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_SPECIFIC_ALLOWABLE_DEDUCT")), False, ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_SPECIFIC_ALLOWABLE_DEDUCT"))
                    SQLcmd.Parameters.Add("@MM_SPECIFIC_NONALLOWABLE_DEDUCT", SqlDbType.Bit).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_SPECIFIC_NONALLOWABLE_DEDUCT")), False, ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_SPECIFIC_NONALLOWABLE_DEDUCT"))
                    SQLcmd.Parameters.Add("@MM_NOTE", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_NOTE")), "", ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_NOTE"))
                    SQLcmd.Parameters.Add("@MM_DEDUCT_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_DEDUCT_AMOUNT")), 0, ds.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows(i)("MM_DEDUCT_AMOUNT"))

                    ListofCmd.Add(SQLcmd)
                Next
            End If

            If ListofCmd.Count > 0 Then
                Return ADO.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
            Else
                Return True
            End If
        Catch ex As Exception
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
#End Region

#Region "CP204"
    Public Function Update_CP204(ByVal ds As DataSet, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim ListofSQLcmd As New List(Of SqlCommand)
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "UPDATE BORANG_CP204 SET BCP_REF_NO=@BCP_REF_NO,BCP_CO_NAME=@BCP_CO_NAME,BCP_CO_REGNO=@BCP_CO_REGNO,BCP_CORRESPOND_ADD1=@BCP_CORRESPOND_ADD1,BCP_CORRESPOND_ADD2=@BCP_CORRESPOND_ADD2,BCP_CORRESPOND_ADD3=@BCP_CORRESPOND_ADD3,BCP_CORRESPOND_POST=@BCP_CORRESPOND_POST,BCP_CORRESPOND_CITY=@BCP_CORRESPOND_CITY,BCP_CORRESPOND_STATE=@BCP_CORRESPOND_STATE,BCP_DATE=@BCP_DATE,BCP_YA=@BCP_YA,BCP_ESTIMATED_TAX=@BCP_ESTIMATED_TAX,BCP_ACC_PERIOD_FR=@BCP_ACC_PERIOD_FR,BCP_ACC_PERIOD_TO=@BCP_ACC_PERIOD_TO,BCP_BASIS_PERIOD_FR=@BCP_BASIS_PERIOD_FR,BCP_BASIS_PERIOD_TO=@BCP_BASIS_PERIOD_TO,BCP_NEWCO_DATE=@BCP_NEWCO_DATE,BCP_TO_MONTH=@BCP_TO_MONTH,BCP_FIRST_INSTALMENT=@BCP_FIRST_INSTALMENT,BCP_LAST_INSTALMENT=@BCP_LAST_INSTALMENT,BCP_NEWCO_BAS_FR=@BCP_NEWCO_BAS_FR,BCP_NEWCO_BAS_TO=@BCP_NEWCO_BAS_TO,BCP_NEWCO_BAS_SUB_FR=@BCP_NEWCO_BAS_SUB_FR,BCP_NEWCO_BAS_SUB_TO=@BCP_NEWCO_BAS_SUB_TO,BCP_CURR_CORR_ADD1=@BCP_CURR_CORR_ADD1,BCP_CURR_CORR_ADD2=@BCP_CURR_CORR_ADD2,BCP_CURR_CORR_ADD3=@BCP_CURR_CORR_ADD3,BCP_CURR_CORR_POST=@BCP_CURR_CORR_POST,BCP_CURR_CORR_CITY=@BCP_CURR_CORR_CITY,BCP_CURR_CORR_STATE=@BCP_CURR_CORR_STATE,BCP_REV_ESTIMATED_TAX=@BCP_REV_ESTIMATED_TAX,BCP_BAL_ESTIMATED_TAX=@BCP_BAL_ESTIMATED_TAX,BCP_TOTAL_PAID=@BCP_TOTAL_PAID,BCP_FR_MONTH=@BCP_FR_MONTH,BCP_FROM_INSTALMENT=@BCP_FROM_INSTALMENT,BCP_NEW_ACC_PERIOD_FR=@BCP_NEW_ACC_PERIOD_FR,BCP_NEW_ACC_PERIOD_TO=@BCP_NEW_ACC_PERIOD_TO,BCP_BASIS_PERIOD_FLW_FR=@BCP_BASIS_PERIOD_FLW_FR,BCP_BASIS_PERIOD_FLW_TO=@BCP_BASIS_PERIOD_FLW_TO,BCP_BASIS_PERIOD_SUB_FR=@BCP_BASIS_PERIOD_SUB_FR,BCP_BASIS_PERIOD_SUB_TO=@BCP_BASIS_PERIOD_SUB_TO,BCP_FORM=@BCP_FORM,BCP_VERSION=@BCP_VERSION,BCP_ESTIMATED=@BCP_ESTIMATED,BCP_INDICATE=@BCP_INDICATE,BCP_CHKM=@BCP_CHKM,BCP_SME_PERIOD_FR=@BCP_SME_PERIOD_FR,BCP_SME_PERIOD_TO=@BCP_SME_PERIOD_TO,ModifiedBy=@ModifiedBy,ModifiedDateTime=@ModifiedDateTime WHERE BCP_KEY=@BCP_KEY"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            With ds.Tables("BORANG_CP204")
                SQLcmd.Parameters.Add("@BCP_KEY", SqlDbType.Int).Value = .Rows(0)("BCP_KEY")
                SQLcmd.Parameters.Add("@BCP_REF_NO", SqlDbType.NVarChar, 20).Value = .Rows(0)("BCP_REF_NO")
                SQLcmd.Parameters.Add("@BCP_CO_NAME", SqlDbType.NVarChar, 255).Value = .Rows(0)("BCP_CO_NAME")
                SQLcmd.Parameters.Add("@BCP_CO_REGNO", SqlDbType.NVarChar, 20).Value = .Rows(0)("BCP_CO_REGNO")
                SQLcmd.Parameters.Add("@BCP_CORRESPOND_ADD1", SqlDbType.NVarChar, 40).Value = .Rows(0)("BCP_CORRESPOND_ADD1")
                SQLcmd.Parameters.Add("@BCP_CORRESPOND_ADD2", SqlDbType.NVarChar, 40).Value = .Rows(0)("BCP_CORRESPOND_ADD2")
                SQLcmd.Parameters.Add("@BCP_CORRESPOND_ADD3", SqlDbType.NVarChar, 40).Value = .Rows(0)("BCP_CORRESPOND_ADD3")
                SQLcmd.Parameters.Add("@BCP_CORRESPOND_POST", SqlDbType.NVarChar, 10).Value = .Rows(0)("BCP_CORRESPOND_POST")
                SQLcmd.Parameters.Add("@BCP_CORRESPOND_CITY", SqlDbType.NVarChar, 30).Value = .Rows(0)("BCP_CORRESPOND_CITY")
                SQLcmd.Parameters.Add("@BCP_CORRESPOND_STATE", SqlDbType.NVarChar, 30).Value = .Rows(0)("BCP_CORRESPOND_STATE")
                SQLcmd.Parameters.Add("@BCP_DATE", SqlDbType.DateTime).Value = .Rows(0)("BCP_DATE")
                SQLcmd.Parameters.Add("@BCP_YA", SqlDbType.NVarChar, 5).Value = .Rows(0)("BCP_YA")
                SQLcmd.Parameters.Add("@BCP_ESTIMATED_TAX", SqlDbType.Decimal).Value = .Rows(0)("BCP_ESTIMATED_TAX")
                SQLcmd.Parameters.Add("@BCP_ACC_PERIOD_FR", SqlDbType.DateTime).Value = .Rows(0)("BCP_ACC_PERIOD_FR")
                SQLcmd.Parameters.Add("@BCP_ACC_PERIOD_TO", SqlDbType.DateTime).Value = .Rows(0)("BCP_ACC_PERIOD_TO")
                SQLcmd.Parameters.Add("@BCP_BASIS_PERIOD_FR", SqlDbType.DateTime).Value = .Rows(0)("BCP_BASIS_PERIOD_FR")
                SQLcmd.Parameters.Add("@BCP_BASIS_PERIOD_TO", SqlDbType.DateTime).Value = .Rows(0)("BCP_BASIS_PERIOD_TO")
                SQLcmd.Parameters.Add("@BCP_NEWCO_DATE", SqlDbType.DateTime).Value = .Rows(0)("BCP_NEWCO_DATE")
                SQLcmd.Parameters.Add("@BCP_TO_MONTH", SqlDbType.Int).Value = .Rows(0)("BCP_TO_MONTH")
                SQLcmd.Parameters.Add("@BCP_FIRST_INSTALMENT", SqlDbType.Decimal).Value = .Rows(0)("BCP_FIRST_INSTALMENT")
                SQLcmd.Parameters.Add("@BCP_LAST_INSTALMENT", SqlDbType.Decimal).Value = .Rows(0)("BCP_LAST_INSTALMENT")
                SQLcmd.Parameters.Add("@BCP_NEWCO_BAS_FR", SqlDbType.DateTime).Value = .Rows(0)("BCP_NEWCO_BAS_FR")
                SQLcmd.Parameters.Add("@BCP_NEWCO_BAS_TO", SqlDbType.DateTime).Value = .Rows(0)("BCP_NEWCO_BAS_TO")
                SQLcmd.Parameters.Add("@BCP_NEWCO_BAS_SUB_FR", SqlDbType.DateTime).Value = .Rows(0)("BCP_NEWCO_BAS_SUB_FR")
                SQLcmd.Parameters.Add("@BCP_NEWCO_BAS_SUB_TO", SqlDbType.DateTime).Value = .Rows(0)("BCP_NEWCO_BAS_SUB_TO")
                SQLcmd.Parameters.Add("@BCP_CURR_CORR_ADD1", SqlDbType.NVarChar, 40).Value = .Rows(0)("BCP_CURR_CORR_ADD1")
                SQLcmd.Parameters.Add("@BCP_CURR_CORR_ADD2", SqlDbType.NVarChar, 40).Value = .Rows(0)("BCP_CURR_CORR_ADD2")
                SQLcmd.Parameters.Add("@BCP_CURR_CORR_ADD3", SqlDbType.NVarChar, 40).Value = .Rows(0)("BCP_CURR_CORR_ADD3")
                SQLcmd.Parameters.Add("@BCP_CURR_CORR_POST", SqlDbType.NVarChar, 10).Value = .Rows(0)("BCP_CURR_CORR_POST")
                SQLcmd.Parameters.Add("@BCP_CURR_CORR_CITY", SqlDbType.NVarChar, 30).Value = .Rows(0)("BCP_CURR_CORR_CITY")
                SQLcmd.Parameters.Add("@BCP_CURR_CORR_STATE", SqlDbType.NVarChar, 30).Value = .Rows(0)("BCP_CURR_CORR_STATE")
                SQLcmd.Parameters.Add("@BCP_REV_ESTIMATED_TAX", SqlDbType.Decimal).Value = .Rows(0)("BCP_REV_ESTIMATED_TAX")
                SQLcmd.Parameters.Add("@BCP_BAL_ESTIMATED_TAX", SqlDbType.Decimal).Value = .Rows(0)("BCP_BAL_ESTIMATED_TAX")
                SQLcmd.Parameters.Add("@BCP_TOTAL_PAID", SqlDbType.Decimal).Value = .Rows(0)("BCP_TOTAL_PAID")
                SQLcmd.Parameters.Add("@BCP_FR_MONTH", SqlDbType.Int).Value = .Rows(0)("BCP_FR_MONTH")
                SQLcmd.Parameters.Add("@BCP_FROM_INSTALMENT", SqlDbType.NVarChar, 25).Value = .Rows(0)("BCP_FROM_INSTALMENT")
                SQLcmd.Parameters.Add("@BCP_NEW_ACC_PERIOD_FR", SqlDbType.DateTime).Value = .Rows(0)("BCP_NEW_ACC_PERIOD_FR")
                SQLcmd.Parameters.Add("@BCP_NEW_ACC_PERIOD_TO", SqlDbType.DateTime).Value = .Rows(0)("BCP_NEW_ACC_PERIOD_TO")
                SQLcmd.Parameters.Add("@BCP_BASIS_PERIOD_FLW_FR", SqlDbType.DateTime).Value = .Rows(0)("BCP_BASIS_PERIOD_FLW_FR")
                SQLcmd.Parameters.Add("@BCP_BASIS_PERIOD_FLW_TO", SqlDbType.DateTime).Value = .Rows(0)("BCP_BASIS_PERIOD_FLW_TO")
                SQLcmd.Parameters.Add("@BCP_BASIS_PERIOD_SUB_FR", SqlDbType.DateTime).Value = .Rows(0)("BCP_BASIS_PERIOD_SUB_FR")
                SQLcmd.Parameters.Add("@BCP_BASIS_PERIOD_SUB_TO", SqlDbType.DateTime).Value = .Rows(0)("BCP_BASIS_PERIOD_SUB_TO")
                SQLcmd.Parameters.Add("@BCP_FORM", SqlDbType.NVarChar, 10).Value = .Rows(0)("BCP_FORM")
                SQLcmd.Parameters.Add("@BCP_VERSION", SqlDbType.Int).Value = .Rows(0)("BCP_VERSION")
                SQLcmd.Parameters.Add("@BCP_ESTIMATED", SqlDbType.Decimal).Value = .Rows(0)("BCP_ESTIMATED")
                SQLcmd.Parameters.Add("@BCP_INDICATE", SqlDbType.Int).Value = .Rows(0)("BCP_INDICATE")
                SQLcmd.Parameters.Add("@BCP_CHKM", SqlDbType.NVarChar, 1).Value = .Rows(0)("BCP_CHKM")
                SQLcmd.Parameters.Add("@BCP_SME_PERIOD_FR", SqlDbType.NVarChar, 20).Value = .Rows(0)("BCP_SME_PERIOD_FR")
                SQLcmd.Parameters.Add("@BCP_SME_PERIOD_TO", SqlDbType.NVarChar, 20).Value = .Rows(0)("BCP_SME_PERIOD_TO")
                SQLcmd.Parameters.Add("@ModifiedBy", SqlDbType.NVarChar, 100).Value = My.Computer.Name
                SQLcmd.Parameters.Add("@ModifiedDateTime", SqlDbType.DateTime).Value = Now
            End With

            ListofSQLcmd.Add(SQLcmd)

            SQLcmd = Nothing
            StrSQL = "DELETE FROM BORANG_CP204_TRICOR_BREAKDOWN WHERE CP_PARENTID=@CP_PARENTID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@CP_PARENTID", SqlDbType.Int).Value = ds.Tables("BORANG_CP204").Rows(0)("BCP_KEY")

            ListofSQLcmd.Add(SQLcmd)

            If ds.Tables("BORANG_CP204_TRICOR_BREAKDOWN").Rows.Count > 0 Then
                Dim dtRow As DataRow = Nothing
                For i As Integer = 0 To ds.Tables("BORANG_CP204_TRICOR_BREAKDOWN").Rows.Count - 1
                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO BORANG_CP204_TRICOR_BREAKDOWN (CP_PARENTID,CP_INSTALL_NO,CP_PAYMENT_DUE,CP_INSTALLMENT_AMOUNT,CP_PAYMENT_DATE_1,CP_AMOUNT_PAID_1,CP_PAYMENT_DATE_2,CP_AMOUNT_PAID_2,CP_PENALTY,CP_NOTE_TITLE,CP_NOTE) VALUES (@CP_PARENTID,@CP_INSTALL_NO,@CP_PAYMENT_DUE,@CP_INSTALLMENT_AMOUNT,@CP_PAYMENT_DATE_1,@CP_AMOUNT_PAID_1,@CP_PAYMENT_DATE_2,@CP_AMOUNT_PAID_2,@CP_PENALTY,@CP_NOTE_TITLE,@CP_NOTE)"

                    dtRow = ds.Tables("BORANG_CP204_TRICOR_BREAKDOWN").Rows(i)
                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@CP_PARENTID", SqlDbType.Int).Value = ds.Tables("BORANG_CP204").Rows(0)("BCP_KEY")
                    SQLcmd.Parameters.Add("@CP_INSTALL_NO", SqlDbType.Int).Value = IIf(IsDBNull(dtRow("CP_INSTALL_NO")), i, dtRow("CP_INSTALL_NO"))
                    SQLcmd.Parameters.Add("@CP_PAYMENT_DUE", SqlDbType.DateTime).Value = IIf(IsDBNull(dtRow("CP_PAYMENT_DUE")), DBNull.Value, dtRow("CP_PAYMENT_DUE"))
                    SQLcmd.Parameters.Add("@CP_INSTALLMENT_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(dtRow("CP_INSTALLMENT_AMOUNT")), DBNull.Value, dtRow("CP_INSTALLMENT_AMOUNT"))
                    SQLcmd.Parameters.Add("@CP_PAYMENT_DATE_1", SqlDbType.DateTime).Value = IIf(IsDBNull(dtRow("CP_PAYMENT_DATE_1")), DBNull.Value, dtRow("CP_PAYMENT_DATE_1"))
                    SQLcmd.Parameters.Add("@CP_AMOUNT_PAID_1", SqlDbType.Decimal).Value = IIf(IsDBNull(dtRow("CP_AMOUNT_PAID_1")), DBNull.Value, dtRow("CP_AMOUNT_PAID_1"))
                    SQLcmd.Parameters.Add("@CP_PAYMENT_DATE_2", SqlDbType.DateTime).Value = IIf(IsDBNull(dtRow("CP_PAYMENT_DATE_2")), DBNull.Value, dtRow("CP_PAYMENT_DATE_2"))
                    SQLcmd.Parameters.Add("@CP_AMOUNT_PAID_2", SqlDbType.Decimal).Value = IIf(IsDBNull(dtRow("CP_AMOUNT_PAID_2")), DBNull.Value, dtRow("CP_AMOUNT_PAID_2"))
                    SQLcmd.Parameters.Add("@CP_PENALTY", SqlDbType.Decimal).Value = IIf(IsDBNull(dtRow("CP_PENALTY")), DBNull.Value, dtRow("CP_PENALTY"))
                    SQLcmd.Parameters.Add("@CP_NOTE_TITLE", SqlDbType.NVarChar, 100).Value = IIf(IsDBNull(dtRow("CP_NOTE_TITLE")), DBNull.Value, dtRow("CP_NOTE_TITLE"))
                    SQLcmd.Parameters.Add("@CP_NOTE", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(dtRow("CP_NOTE")), DBNull.Value, dtRow("CP_NOTE"))


                    ListofSQLcmd.Add(SQLcmd)
                Next

            End If

            Return ADO.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofSQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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

#End Region
#Region "TAXCOM"


    Public Function Update_AdjTaxcom(ByVal ID As Integer, ByVal TC_AI_DIVIDEND As Decimal, ByVal TC_AI_RENTAL As Decimal, ByVal TC_AI_ROYALTY As Decimal, ByVal TC_AI_INTEREST As Decimal, ByVal TC_AI_SEC4A As Decimal, ByVal TC_AI_PNL_BAL As Decimal, ByVal TC_AI_ADJ_BS_EXP_NA_EXP As Decimal, ByVal TC_AI_ADJ_BS_IN_NA_LOS As Decimal, ByVal TC_AI_ADJ_BS_IN_NT_IN As Decimal, ByVal TC_AI_TOT_NONBS_IN As Decimal, ByVal TC_AI_TOT_BS_IN As Decimal, ByVal TC_AI_ADJ_BS_IN_TAX_IN As Decimal, ByVal TC_AI_ADJ_BS_EXP_INT As Decimal, ByVal TC_AI_ADJ_BS_EXP_RV_EXP As Decimal, ByVal TC_AI_ADJ_BS_EXP_CLAIM As Decimal, ByVal TC_AI_TOT_ADJ_BS_EXP As Decimal, ByVal TC_OTHERDEDUCTION As Decimal, ByVal TC_AI_TOT_ADJ_BS_IN As Decimal, ByVal TC_AI_ADJ_IN_LOSS As Decimal, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "UPDATE TAX_COMPUTATION SET TC_AI_DIVIDEND=@TC_AI_DIVIDEND,TC_AI_RENTAL=@TC_AI_RENTAL,TC_AI_ROYALTY=@TC_AI_ROYALTY,TC_AI_INTEREST=@TC_AI_INTEREST,TC_AI_SEC4A=@TC_AI_SEC4A,TC_AI_PNL_BAL=@TC_AI_PNL_BAL,TC_AI_ADJ_BS_EXP_NA_EXP=@TC_AI_ADJ_BS_EXP_NA_EXP,TC_AI_TOT_BS_IN=@TC_AI_TOT_BS_IN,TC_AI_ADJ_BS_IN_TAX_IN=@TC_AI_ADJ_BS_IN_TAX_IN,TC_AI_ADJ_BS_EXP_INT=@TC_AI_ADJ_BS_EXP_INT,TC_AI_ADJ_BS_EXP_RV_EXP=@TC_AI_ADJ_BS_EXP_RV_EXP,TC_AI_ADJ_BS_EXP_CLAIM=@TC_AI_ADJ_BS_EXP_CLAIM,TC_AI_TOT_ADJ_BS_EXP=@TC_AI_TOT_ADJ_BS_EXP,TC_OTHERDEDUCTION=@TC_OTHERDEDUCTION,TC_AI_TOT_ADJ_BS_IN=@TC_AI_TOT_ADJ_BS_IN,TC_AI_ADJ_IN_LOSS=@TC_AI_ADJ_IN_LOSS WHERE TC_KEY=@TC_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            ' SQLcmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
            SQLcmd.Parameters.Add("@TC_AI_DIVIDEND", SqlDbType.NVarChar, 25).Value = CStr(TC_AI_DIVIDEND)
            SQLcmd.Parameters.Add("@TC_AI_RENTAL", SqlDbType.NVarChar, 25).Value = CStr(TC_AI_RENTAL)
            SQLcmd.Parameters.Add("@TC_AI_ROYALTY", SqlDbType.NVarChar, 25).Value = CStr(TC_AI_ROYALTY)
            SQLcmd.Parameters.Add("@TC_AI_INTEREST", SqlDbType.NVarChar, 25).Value = CStr(TC_AI_INTEREST)
            SQLcmd.Parameters.Add("@TC_AI_SEC4A", SqlDbType.NVarChar, 25).Value = CStr(TC_AI_SEC4A)
            SQLcmd.Parameters.Add("@TC_AI_PNL_BAL", SqlDbType.NVarChar, 25).Value = CStr(TC_AI_PNL_BAL)
            SQLcmd.Parameters.Add("@TC_AI_ADJ_BS_EXP_NA_EXP", SqlDbType.NVarChar, 25).Value = CStr(TC_AI_ADJ_BS_EXP_NA_EXP)
            SQLcmd.Parameters.Add("@TC_AI_TOT_BS_IN", SqlDbType.NVarChar, 25).Value = CStr(TC_AI_TOT_BS_IN)
            SQLcmd.Parameters.Add("@TC_AI_ADJ_BS_IN_TAX_IN", SqlDbType.NVarChar, 25).Value = CStr(TC_AI_ADJ_BS_IN_TAX_IN)
            SQLcmd.Parameters.Add("@TC_AI_ADJ_BS_EXP_INT", SqlDbType.NVarChar, 25).Value = CStr(TC_AI_ADJ_BS_EXP_INT)
            SQLcmd.Parameters.Add("@TC_AI_ADJ_BS_EXP_RV_EXP", SqlDbType.NVarChar, 25).Value = CStr(TC_AI_ADJ_BS_EXP_RV_EXP)
            SQLcmd.Parameters.Add("@TC_AI_ADJ_BS_EXP_CLAIM", SqlDbType.NVarChar, 25).Value = CStr(TC_AI_ADJ_BS_EXP_CLAIM)
            SQLcmd.Parameters.Add("@TC_AI_TOT_ADJ_BS_EXP", SqlDbType.NVarChar, 25).Value = CStr(TC_AI_TOT_ADJ_BS_EXP)
            SQLcmd.Parameters.Add("@TC_OTHERDEDUCTION", SqlDbType.NVarChar, 25).Value = CStr(TC_OTHERDEDUCTION)
            SQLcmd.Parameters.Add("@TC_AI_TOT_ADJ_BS_IN", SqlDbType.NVarChar, 25).Value = CStr(TC_AI_TOT_ADJ_BS_IN)
            SQLcmd.Parameters.Add("@TC_AI_ADJ_IN_LOSS", SqlDbType.NVarChar, 25).Value = CStr(TC_AI_ADJ_IN_LOSS)
            SQLcmd.Parameters.Add("@TC_KEY", SqlDbType.Int).Value = ID


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

            AddListOfError(ErrorLog)

            Return False
        End Try
    End Function



#End Region
#Region "MASTER DATA"
    Public Function Update_YA(ByVal YA As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SQLcmd As SqlCommand
            Dim SqlCon As SqlConnection = Nothing
            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim strSQL As String = "UPDATE YEAR_ASSESSMENT SET YA=@YA WHERE YA=@ID"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = strSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.NVarChar, 5).Value = CStr(YA)
            SQLcmd.Parameters.Add("@YA", SqlDbType.NVarChar, 5).Value = CStr(YA)

            Return ADO.ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
#End Region
#Region "TABLE OF CONTENT"

    Public Function Update_TableOfContent(ByVal ID As Decimal, ByVal RefNo As String, ByVal CompanyName As String, ByVal YA As String, dt As DataTable, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = ""

            Dim ListofSQLCmd As New List(Of SqlCommand)
            SQLcmd = Nothing
            StrSQL = "DELETE TABLE_CONTENT_LIST WHERE TBL_PARENTID=@TBL_PARENTID"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@TBL_PARENTID", SqlDbType.Decimal).Value = ID
            ListofSQLCmd.Add(SQLcmd)

            SQLcmd = Nothing
            StrSQL = "UPDATE TABLE_CONTENT SET TBL_REFNO=@TBL_REFNO,TBL_COMPANYNAME=@TBL_COMPANYNAME,TBL_YA=@TBL_YA,ModifiedBy=@ModifiedBy,ModifiedDateTime=@ModifiedDateTime WHERE TBL_ID=@TBL_ID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@TBL_ID", SqlDbType.Decimal).Value = ID
            SQLcmd.Parameters.Add("@TBL_REFNO", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@TBL_COMPANYNAME", SqlDbType.NVarChar, 350).Value = CompanyName
            SQLcmd.Parameters.Add("@TBL_YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@ModifiedBy", SqlDbType.NVarChar, 100).Value = My.Computer.Name
            SQLcmd.Parameters.Add("@ModifiedDateTime", SqlDbType.DateTime).Value = Now
            ListofSQLCmd.Add(SQLcmd)

            If dt IsNot Nothing Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO TABLE_CONTENT_LIST (TBL_PARENTID,TBL_REPORTNAME,TBL_TITLE,TBL_INDEX,TBL_SEQUENCE) VALUES (@TBL_PARENTID,@TBL_REPORTNAME,@TBL_TITLE,@TBL_INDEX,@TBL_SEQUENCE)"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = StrSQL
                    SQLcmd.Parameters.Add("@TBL_PARENTID", SqlDbType.Decimal).Value = ID
                    SQLcmd.Parameters.Add("@TBL_REPORTNAME", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(dt.Rows(i)("TBL_REPORTNAME")), "", dt.Rows(i)("TBL_REPORTNAME"))
                    SQLcmd.Parameters.Add("@TBL_TITLE", SqlDbType.NVarChar, 300).Value = IIf(IsDBNull(dt.Rows(i)("TBL_TITLE")), "", dt.Rows(i)("TBL_TITLE"))
                    SQLcmd.Parameters.Add("@TBL_INDEX", SqlDbType.NVarChar, 10).Value = IIf(IsDBNull(dt.Rows(i)("TBL_INDEX")), "", dt.Rows(i)("TBL_INDEX"))
                    SQLcmd.Parameters.Add("@TBL_SEQUENCE", SqlDbType.Int).Value = i

                    ListofSQLCmd.Add(SQLcmd)
                Next
            End If

            Return ADO.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofSQLCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
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
            Return False
        End Try
    End Function



#End Region
#End Region
#Region "DELETE"
#Region "CA"

    Public Function Delete_CA_Report_TEMP(ByVal ID As String, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection
            Dim ListofSQLCmd As New List(Of SqlCommand)
            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "DELETE FROM CA_REPORT_TEMP WHERE ID=@ID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.NVarChar, 50).Value = ID
            ListofSQLCmd.Add(SQLcmd)

            SQLcmd = Nothing
            StrSQL = "DELETE FROM CA_REPORT_SUMMARY_TEMP WHERE ID=@ID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.NVarChar, 50).Value = ID
            ListofSQLCmd.Add(SQLcmd)

            Return ADO.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofSQLCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
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

    Public Function Delete_CA_Report_FAReconciliation_TEMP(ByVal ID As String, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection
            Dim ListofSQLCmd As New List(Of SqlCommand)
            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "DELETE FROM CA_REPORT_FIXEDASSET_TEMP WHERE ID=@ID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.NVarChar, 50).Value = ID
            ListofSQLCmd.Add(SQLcmd)


            Return ADO.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofSQLCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
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

    Public Function Delete_CA(ByVal CA_KEY As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "DELETE FROM CA WHERE CA_KEY=@CA_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@CA_KEY", SqlDbType.Int).Value = CA_KEY

            Return ADO.ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)


        Catch ex As Exception
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
    Public Function Delete_HP(ByVal HP_KEY As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection


            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim ListofCmd As New List(Of SqlCommand)

            Dim StrSQL As String = "DELETE FROM HP WHERE HP_KEY=@HP_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@HP_KEY", SqlDbType.Int).Value = HP_KEY

            ListofCmd.Add(SQLcmd)

            SQLcmd = Nothing
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = "DELETE FROM HP_INSTALLMENT WHERE HP_KEY=@HP_KEY"
            SQLcmd.Parameters.Add("@HP_KEY", SqlDbType.Int).Value = HP_KEY
            ListofCmd.Add(SQLcmd)

            SQLcmd = Nothing
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = "DELETE FROM HP_YEARLY WHERE HPD_KEY=@HPD_KEY"
            SQLcmd.Parameters.Add("@HPD_KEY", SqlDbType.Int).Value = HP_KEY
            ListofCmd.Add(SQLcmd)


            Return ADO.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)


        Catch ex As Exception
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
#End Region
#Region "PNL"
    Public Function Delete_PNL(ByVal PL_KEY As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection
            Dim ListofCmd As List(Of SqlCommand)
            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If
            ListofCmd = New List(Of SqlCommand)


            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "DELETE FROM PROFIT_LOSS_ACCOUNT WHERE PL_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PL_KEY

            ListofCmd.Add(SQLcmd)

            mdlProcess.Delete_PNLItem(ListofCmd, PL_KEY, ErrorLog)

            Return ADO.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
    Public Function Delete_PNLItem(ByVal ListofCmd As List(Of SqlCommand), ByVal PL_KEY As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "DELETE PLFST_SALES WHERE PLFS_KEY=@PLFS_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PLFS_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE PLFST_SALES_DETAIL WHERE PLFSD_KEY=@PLFSD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PLFSD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE PLFST_OPENSTOCK WHERE PLFOS_KEY=@PLFOS_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PLFOS_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE PLFST_OPENSTOCK_DETAIL WHERE PLFOSD_KEY=@PLFOSD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PLFOSD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE PLFST_PURCHASE WHERE PLFPUR_KEY=@PLFPUR_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PLFPUR_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE PLFST_PURCHASE_DETAIL WHERE PLFPURD_KEY=@PLFPURD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PLFPURD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE EXPENSES_DEPRECIATION WHERE EXDEP_KEY=@EXDEP_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXDEP_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE EXPENSES_DEPRECIATION_DETAIL WHERE EXDEPD_KEY=@EXDEPD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXDEPD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE EXPENSES_ALLOW WHERE EXA_KEY=@EXA_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXA_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE EXPENSES_ALLOW_DETAIL WHERE EXAD_KEY=@EXAD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXAD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE EXPENSES_NONALLOW WHERE EXNA_KEY=@EXNA_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXNA_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE EXPENSES_NONALLOW_DETAIL WHERE EXNAD_KEY=@EXNAD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXNAD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE PLFST_CLOSESTOCK WHERE PLFCS_KEY=@PLFCS_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PLFCS_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE PLFST_CLOSESTOCK_DETAIL WHERE PLFCSD_KEY=@PLFCSD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PLFCSD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE NONSOURCE_BUSINESSINCOME WHERE NSBI_KEY=@NSBI_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NSBI_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE NONSOURCE_BUSINESSINCOME_DETAIL WHERE NSBID_KEY=@NSBID_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NSBID_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE INCOME_REALFET WHERE IRFET_KEY=@IRFET_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@IRFET_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE INCOME_REALFET_DETAIL WHERE IRFETD_KEY=@IRFETD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@IRFETD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE DIVIDEND_INCOME WHERE DI_KEY=@DI_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@DI_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE INCOME_NBINTEREST WHERE NOBII_KEY=@NOBII_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NOBII_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE INCOME_NBINTEREST_DETAIL WHERE NOBIID_KEY=@NOBIID_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NOBIID_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE RENTAL_INCOME WHERE RI_KEY=@RI_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@RI_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE INCOME_NBROYALTY WHERE NOBRI_KEY=@NOBRI_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NOBRI_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE INCOME_NBROYALTY_DETAIL WHERE NOBRID_KEY=@NOBRID_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NOBRID_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE OTHER_INCOME WHERE OI_KEY=@OI_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@OI_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE OTHER_INCOME_DETAIL WHERE OID_KEY=@OID_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@OID_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE INCOME_NTDISPOSALFA WHERE NTIDFA_KEY=@NTIDFA_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NTIDFA_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE INCOME_NTDISPOSALFA_DETAIL WHERE NTIDFAD_KEY=@NTIDFAD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NTIDFAD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE INCOME_NTDISPOSALINVEST WHERE NTIDI_KEY=@NTIDI_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NTIDI_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE INCOME_NTDISPOSALINVEST_DETAIL WHERE NTIDID_KEY=@NTIDID_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NTIDID_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE EXEMPT_DIVIDEND WHERE ED_KEY=@ED_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ED_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE INCOME_NTFOREIGNINCREM WHERE NTIFIR_KEY=@NTIFIR_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NTIFIR_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE INCOME_NTFOREIGNINCREM_DETAIL WHERE NTIFIRD_KEY=@NTIFIRD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NTIFIRD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE INCOME_NTUREALFET WHERE NTIUT_KEY=@NTIUT_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NTIUT_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE INCOME_NTUREALFET_DETAIL WHERE NTIUTD_KEY=@NTIUTD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NTIUTD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE INCOME_NTREALFE WHERE NTIRFECT_KEY=@NTIRFECT_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NTIRFECT_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE INCOME_NTREALFE_DETAIL WHERE NTIRFECTD_KEY=@NTIRFECTD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NTIRFECTD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE INCOME_NTUREALFENT WHERE NTIUNT_KEY=@NTIUNT_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NTIUNT_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE INCOME_NTUREALFENT_DETAIL WHERE NTIUNTD_KEY=@NTIUNTD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NTIUNTD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE NON_TAXABLE_INCOME WHERE NT_KEY=@NT_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NT_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE NON_TAXABLE_INCOME_DETAIL WHERE NTD_KEY=@NTD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NTD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE EXPENSES_INTERESTRESTRICT WHERE EXIR_KEY=@EXIR_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXIR_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE EXPENSES_INTERESTRESTRICT_DETAIL WHERE EXIRD_KEY=@EXIRD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXIRD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE EXPENSES_INTEREST WHERE EXI_KEY=@EXI_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXI_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE EXPENSES_INTEREST_DETAIL WHERE EXID_KEY=@EXID_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXID_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE EXPENSES_LEGAL WHERE EXL_KEY=@EXL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXL_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE EXPENSES_LEGAL_DETAIL WHERE EXLD_KEY=@EXLD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXLD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE EXPENSES_TECH_FEE WHERE EXTF_KEY=@EXTF_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXTF_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE EXPENSES_TECH_FEE_DETAIL WHERE EXTFD_KEY=@EXTFD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXTFD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE EXPENSES_CONTRACT WHERE EXC_KEY=@EXC_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXC_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE EXPENSES_CONTRACT_DETAIL WHERE EXCD_KEY=@EXCD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXCD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE EXPENSES_DIRECTORS_FEE WHERE EXDF_KEY=@EXDF_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXDF_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE EXPENSES_DIRECTORS_FEE_DETAIL WHERE EXDFD_KEY=@EXDFD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXDFD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE EXPENSES_SALARY WHERE EXS_KEY=@EXS_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXS_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE EXPENSES_SALARY_DETAIL WHERE EXSD_KEY=@EXSD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXSD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE EXPENSES_EMPL_STOCK WHERE EXES_KEY=@EXES_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXES_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE EXPENSES_EMPLSTOCK_DETAIL WHERE EXESD_KEY=@EXESD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXESD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE EXPENSES_ROYALTY WHERE EXRO_KEY=@EXRO_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXRO_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE EXPENSES_ROYALTY_DETAIL WHERE EXROD_KEY=@EXROD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXROD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE EXPENSES_RENTAL WHERE EXRENT_KEY=@EXRENT_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXRENT_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE EXPENSES_RENTAL_DETAIL WHERE EXRENTD_KEY=@EXRENTD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXRENTD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE EXPENSES_REPAIR WHERE EXREP_KEY=@EXREP_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXREP_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE EXPENSES_REPAIR_DETAIL WHERE EXREPD_KEY=@EXREPD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXREPD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE EXPENSES_RESEARCH WHERE EXRES_KEY=@EXRES_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXRES_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE EXPENSES_RESEARCH_DETAIL WHERE EXRESD_KEY=@EXRESD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXRESD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE EXPENSES_PROMOTE WHERE EXP_KEY=@EXP_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXP_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE EXPENSES_PROMOTE_DETAIL WHERE EXPD_KEY=@EXPD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXPD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE EXPENSES_TRAVEL WHERE EXT_KEY=@EXT_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXT_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE EXPENSES_TRAVEL_DETAIL WHERE EXTD_KEY=@EXTD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXTD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE EXPENSES_JKDM WHERE EXJK_KEY=@EXJK_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXJK_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE EXPENSES_JKDM_DETAIL WHERE EXJKD_KEY=@EXJKD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXJKD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE OTHER_EXDEPRECIATION WHERE EXODEP_KEY=@EXODEP_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXODEP_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE OTHER_EXDEPRECIATION_DETAIL WHERE EXODEPD_KEY=@EXODEPD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXODEPD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE OTHER_EXAPPRDONATION WHERE EXOAD_KEY=@EXOAD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOAD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE OTHER_EXAPPRDONATION_DETAIL WHERE EXOADD_KEY=@EXOADD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOADD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE OTHER_EXNAPPRDONATION WHERE EXONAD_KEY=@EXONAD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXONAD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE OTHER_EXNAPPRDONATION_DETAIL WHERE EXONADD_KEY=@EXONADD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXONADD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE OTHER_EXZAKAT WHERE EXOZ_KEY=@EXOZ_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOZ_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE OTHER_EXZAKAT_DETAIL WHERE EXOZD_KEY=@EXOZD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOZD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE OTHER_EXLOSSDISPOSALFA WHERE EXOLD_KEY=@EXOLD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOLD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE OTHER_EXLOSSDISPOSALFA_DETAIL WHERE EXOLDD_KEY=@EXOLDD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOLDD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE OTHER_ENTERTAINNSTAFF WHERE EXOENS_KEY=@EXOENS_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOENS_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE OTHER_ENTERTAINNSTAFF_DETAIL WHERE EXOENSD_KEY=@EXOENSD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOENSD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE OTHER_ENTERTAINSTAFF WHERE EXOES_KEY=@EXOES_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOES_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE OTHER_ENTERTAINSTAFF_DETAIL WHERE EXOESD_KEY=@EXOESD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOESD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE OTHER_EXPENALTY WHERE EXOP_KEY=@EXOP_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOP_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE OTHER_EXPENALTY_DETAIL WHERE EXOPD_KEY=@EXOPD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOPD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE OTHER_EXPROVISIONACC WHERE EXOPA_KEY=@EXOPA_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOPA_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE OTHER_EXPROVISIONACC_DETAIL WHERE EXOPAD_KEY=@EXOPAD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOPAD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE OTHER_EXLEAVEPASSAGE WHERE EXOLP_KEY=@EXOLP_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOLP_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE OTHER_EXLEAVEPASSAGE_DETAIL WHERE EXOLPD_KEY=@EXOLPD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOLPD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE OTHER_EXFAWRITTENOFF WHERE EXOWO_KEY=@EXOWO_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOWO_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE OTHER_EXFAWRITTENOFF_DETAIL WHERE EXOWOD_KEY=@EXOWOD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOWOD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE OTHER_EXURLOSSFOREIGN WHERE EXOUR_KEY=@EXOUR_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOUR_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE OTHER_EXURLOSSFOREIGN_DETAIL WHERE EXOURD_KEY=@EXOURD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOURD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE OTHER_EXRLOSSFOREIGNT WHERE EXORT_KEY=@EXORT_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXORT_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE OTHER_EXRLOSSFOREIGNT_DETAIL WHERE EXORTD_KEY=@EXORTD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXORTD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE OTHER_EXRLOSSFOREIGN WHERE EXOR_KEY=@EXOR_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOR_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE OTHER_EXRLOSSFOREIGN_DETAIL WHERE EXORD_KEY=@EXORD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXORD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE OTHER_EXINITIALSUB WHERE EXOIS_KEY=@EXOIS_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOIS_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE OTHER_EXINITIALSUB_DETAIL WHERE EXOISD_KEY=@EXOISD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOISD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE OTHER_EXCAPITALEXP WHERE EXOCE_KEY=@EXOCE_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOCE_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE OTHER_EXCAPITALEXP_DETAIL WHERE EXOCED_KEY=@EXOCED_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOCED_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE OTHER_EXPENSES WHERE EXO_KEY=@EXO_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXO_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)
            StrSQL = "DELETE OTHER_EXPENSES_DETAIL WHERE EXOD_KEY=@EXOD_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@EXOD_KEY", SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

            Return ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
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
            Return Nothing
        End Try
    End Function
#End Region
#Region "OTHER"
    Public Function Delete_CP204(ByVal ID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection
            Dim ListofCmd As List(Of SqlCommand)
            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If
            ListofCmd = New List(Of SqlCommand)
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "DELETE FROM BORANG_CP204 WHERE BCP_KEY=@BCP_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@BCP_KEY", SqlDbType.Int).Value = ID

            ListofCmd.Add(SQLcmd)

            SQLcmd = Nothing
            StrSQL = "DELETE FROM BORANG_CP204_TRICOR_BREAKDOWN WHERE CP_PARENTID=@CP_PARENTID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@CP_PARENTID", SqlDbType.Int).Value = ID
            ListofCmd.Add(SQLcmd)


            Return ADO.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)


        Catch ex As Exception
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
    Public Function Delete_MovementComplex(ByVal MM_ID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection
            Dim ListofCmd As List(Of SqlCommand)
            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If
            ListofCmd = New List(Of SqlCommand)
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "DELETE FROM MOVEMENT_COMPLEX WHERE MM_ID=@MM_ID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@MM_ID", SqlDbType.Int).Value = MM_ID

            ListofCmd.Add(SQLcmd)

            SQLcmd = Nothing
            StrSQL = "DELETE FROM MOVEMENT_COMPLEX_ADD WHERE MM_PARENTID=@MM_PARENTID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@MM_PARENTID", SqlDbType.Int).Value = MM_ID
            ListofCmd.Add(SQLcmd)


            SQLcmd = Nothing
            StrSQL = "DELETE FROM MOVEMENT_COMPLEX_DEDUCT WHERE MM_PARENTID=@MM_PARENTID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@MM_PARENTID", SqlDbType.Int).Value = MM_ID
            ListofCmd.Add(SQLcmd)

            Return ADO.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)


        Catch ex As Exception
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
    Public Function Delete_MovementNormal(ByVal MM_ID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection
            Dim ListofCmd As List(Of SqlCommand)
            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If
            ListofCmd = New List(Of SqlCommand)
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "DELETE FROM MOVEMENT_NORMAL WHERE MM_ID=@MM_ID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@MM_ID", SqlDbType.Int).Value = MM_ID

            ListofCmd.Add(SQLcmd)

            SQLcmd = Nothing
            StrSQL = "DELETE FROM MOVEMENT_ADD WHERE MM_PARENTID=@MM_PARENTID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@MM_PARENTID", SqlDbType.Int).Value = MM_ID
            ListofCmd.Add(SQLcmd)


            SQLcmd = Nothing
            StrSQL = "DELETE FROM MOVEMENT_DEDUCT WHERE MM_PARENTID=@MM_PARENTID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@MM_PARENTID", SqlDbType.Int).Value = MM_ID
            ListofCmd.Add(SQLcmd)

            Return ADO.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)


        Catch ex As Exception
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
    Public Function Delete_REPORT_AI_BAL(ByVal NA_REF_NO As String, Optional ErrorLog As clsError = Nothing) As Boolean
        Try

            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "DELETE FROM [REPORT_AI_BAL] WHERE NA_REF_NO=@NA_REF_NO"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@NA_REF_NO", SqlDbType.NVarChar, 20).Value = NA_REF_NO

            Return ADO.ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
    Public Function Delete_REPORT_AI(Optional ErrorLog As clsError = Nothing) As Boolean
        Try

            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection
            Dim ListofSQLcmd As New List(Of SqlCommand)

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "DELETE FROM REPORT_AI"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Connection = SqlCon
            ListofSQLcmd.Add(SQLcmd)

            StrSQL = "DELETE FROM REPORT_AI_DETAIL"
            SQLcmd = Nothing
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Connection = SqlCon
            ListofSQLcmd.Add(SQLcmd)


            Return ADO.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofSQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
    Public Function Delete_REPORT1_AI(Optional ErrorLog As clsError = Nothing) As Boolean
        Try

            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection
            Dim ListofSQLcmd As New List(Of SqlCommand)

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "DELETE FROM REPORT1_AI"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Connection = SqlCon
            ListofSQLcmd.Add(SQLcmd)

            StrSQL = "DELETE FROM REPORT1_AI_DETAIL"
            SQLcmd = Nothing
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Connection = SqlCon
            ListofSQLcmd.Add(SQLcmd)


            Return ADO.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofSQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
#End Region

#Region "TABLE OF CONTENT"
    Public Function Delete_TableofContent(ByVal TBL_ID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection
            Dim ListofSQL As List(Of SqlCommand)

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            ListofSQL = New List(Of SqlCommand)
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "DELETE FROM TABLE_CONTENT WHERE TBL_ID=@TBL_ID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@TBL_ID", SqlDbType.Int).Value = TBL_ID
            ListofSQL.Add(SQLcmd)
            StrSQL = Nothing
            StrSQL = "DELETE FROM TABLE_CONTENT_LIST WHERE TBL_PARENTID=@TBL_PARENTID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@TBL_PARENTID", SqlDbType.Int).Value = TBL_ID
            ListofSQL.Add(SQLcmd)


            Return ADO.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofSQL, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
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
#End Region
#End Region
End Module
Public Class clsError
    Public ErrorName As String = Nothing
    Public ErrorCode As String = Nothing
    Public ErrorMessage As String = Nothing
    Public ErrorDateTime As DateTime = Now

    Sub New()

    End Sub

    Sub New(ByVal ErrorName_ As String, ByVal ErrorCode_ As String, ByVal ErrorMessage_ As String, ByVal ErrorDateTime_ As DateTime)
        ErrorName = ErrorName_
        ErrorCode = ErrorCode_
        ErrorMessage = ErrorMessage_
        ErrorDateTime = ErrorDateTime_
    End Sub

End Class
