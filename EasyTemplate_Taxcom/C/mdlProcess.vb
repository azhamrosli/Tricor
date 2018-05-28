Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Text
Imports System.Net.NetworkInformation
Imports System.IO
Imports Microsoft.Win32
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository
Imports System.Net

Module mdlProcess
    Public ADO As clsIODatabase
    Public clsMoveNormal As clsMovementNormal
    Public YGLClient As DataRow = Nothing

    Public LicenseType As Integer = 0
    Public V1 As Integer = My.Application.Info.Version.Major
    Public V2 As Integer = My.Application.Info.Version.Minor
    Public V3 As Integer = My.Application.Info.Version.Build
    Public V4 As Integer = My.Application.Info.Version.Revision
    Public R1 As String = ""

    Public ArgParam0 As String = "frmca" 'Form Name
    Public ArgParam1 As String = "TAXCOM_C" 'Database Name
    Public ArgParam2 As String = "1234567890" '"1054242304" 'RefNo
    Public ArgParam3 As String = "2017" 'YA"
    Public Const isVersionLicenseType As VersionLicenseType = VersionLicenseType.Tricor
    Public ListofClsError As List(Of clsError) = Nothing
    Public dsDataSetErrorlog As DataSet

    Dim MaxYearForCA As Integer = 50

#Region "DATABASE"
#Region "YGL SERVER"
    Public Function DBConnection_YGLSERVER(ByRef sqlCon As SqlConnection, ByRef ErrorMsg As clsError) As Boolean
        Try
            Dim strCon As String = DBSetting_YGLSERVER()

            If strCon Is Nothing OrElse strCon = "" Then
                With ErrorMsg
                    .ErrorName = "DBConnection"
                    .ErrorCode = "DB10001"
                    .ErrorDateTime = Now
                    .ErrorMessage = "Connection String Empty"
                End With
                Return False
            End If

            Dim Con As New SqlConnection(strCon)
            If Con.State = System.Data.ConnectionState.Closed Then
                Con.Open()
            End If

            sqlCon = Con
            Return True
        Catch ex As Exception
            With ErrorMsg
                .ErrorName = "DBConnection"
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return False
        End Try
    End Function
    Public Function DBSetting_YGLSERVER() As String
        Try
            Return "Server=175.136.230.74,11443;Database=taxcom;User Id=taxcom;Password=P@$$w0rd;"
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region
    Public Function DBConnection_Test(ByVal ServerName As String, ByVal UserName As String, ByVal Password As String, _
                                          ByRef sqlCon As SqlConnection, ByRef ErrorLog As clsError) As Boolean
        Try

            Dim strCon As String = DBSetting()

            If strCon Is Nothing OrElse strCon = "" Then
                CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, "4060", "Connection string is empty.", ErrorLog)
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
                CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, "4060", "Connection string is empty.", ErrorLog)
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
                CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, "4060", "Connection string is empty.", ErrorLog)
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
    Public Function DBConnection_B(ByRef sqlCon As SqlConnection, ByRef ErrorLog As clsError) As Boolean
        Try

            Dim strCon As String = DBSetting(1, "TAXCOM_B")

            If strCon Is Nothing OrElse strCon = "" Then
                CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, "4060", "Connection string is empty.", ErrorLog)
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
                CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, "4060", "Connection string is empty.", ErrorLog)
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

            If ADO IsNot Nothing Then
                ADO = New clsIODatabase
            End If

            If CheckForInternetConnection() Then
                ADO.SaveSupport("CLN-22052018113101BAA", "", "", "", ErrorLog.ErrorCode & " - " & ErrorLog.ErrorName & " - " & ErrorLog.ErrorMessage, "This is automatically generate by software.", _
                            0, 0, "", Now.Year, My.Computer.Name, Now, Now, Nothing, ErrorLog)
            End If
            

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
            Dim dt As DataTable = ADO.LoadBusinessSource_ByRefNo(RefNo, CStr(YA), Errorlog)

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
            'Dim dt As DataTable = LoadHPCode_ByRefNo(RefNo, Errorlog)

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
            Dim dt As DataTable = ADO.LoadHPCode_ByRefNo(RefNo, Errorlog)

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
    Public Function CreateLookUpSourceNox(ByRef cboSourceNo As DevExpress.XtraEditors.Repository.RepositoryItemComboBox, _
                                         ByVal RefNo As String, ByVal YA As String, Optional Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = ADO.LoadSourceNo(RefNo, YA, Errorlog)

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
    Public Function CreateLookUpSourceNo(ByRef cboSourceNo As DevExpress.XtraEditors.ComboBoxEdit, _
                                         ByVal RefNo As String, ByVal YA As String, Optional Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = ADO.LoadSourceNo(RefNo, YA, Errorlog)

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
            Dim dt As DataTable = ADO.LoadSourceNo(RefNo, YA, Errorlog)

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
            Dim dt As DataTable = ADO.LoadYA(Errorlog)

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
            Dim dt As DataTable = ADO.LoadState(Errorlog)

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
            Dim dt As DataTable = ADO.LoadYA(Errorlog)


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
            Dim dt As DataTable = ADO.LoadCategory(Errorlog)

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
            Dim dt As DataTable = ADO.LoadTaxPayer(Errorlog)

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
            ADO.EventLogging(System.Reflection.MethodBase.GetCurrentMethod().Name & " " & MethodName, ex.HResult.ToString, ex.Message, 2)
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
            ADO.EventLogging(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.HResult.ToString, ex.Message, 1)
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
    Public Function ProcessDoctoByte(ByVal Url As String) As Byte()
        Try
            Dim fInfo As New FileInfo(Url)
            Dim numBytes As Long = fInfo.Length

            Dim fStream As New FileStream(Url, FileMode.Open, FileAccess.Read)
            Dim br As New BinaryReader(fStream)
            Dim data As Byte() = br.ReadBytes(CInt(numBytes))

            ' Show the number of bytes in the array.
            br.Close()
            fStream.Close()

            Return data
        Catch ex As Exception
            Return Nothing
        End Try
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
            ADO.EventLogging(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.HResult.ToString, ex.Message, 1)
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
            ADO.EventLogging(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.HResult.ToString, ex.Message, 1)
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
                mail.Body += "<p><a href='" & ADO.RegisterUserURL & "?sysDatax=" & Base64ToStringConvert("email=" & Email & "&userdata=" & ID) & "'>Please click this link to confirm registration.</a></p>"
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
    Public Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function
    Public Function LicenseChecking() As Boolean
        Try
           
            If ADO Is Nothing Then
                ADO = New clsIODatabase
            End If
            Dim dt As DataTable = Nothing

            dt = ADO.LoadYGLClient_InOffice()

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                'GOT
                YGLClient = dt.Rows(0)

            Else
                'NG
                If CheckForInternetConnection() = False Then
                    Return True
                End If

                Dim tmpID As String = Nothing

                Dim frm As New frmLicense
                frm.ShowDialog()


                If frm.LicenseKey Is Nothing OrElse frm.LicenseKey = "" Then
                    End
                End If

                tmpID = frm.LicenseKey

                dt = ADO.LoadYGLClient_ByCompanyID(tmpID)

                If dt Is Nothing Then
                    MsgBox("Unable to find your company. please contact support team for more information.", MsgBoxStyle.Critical)
                    End
                End If

                ADO.Save_YGLClient(dt.Rows(0))
                YGLClient = dt.Rows(0)

                MsgBox("Succesfully Register Client :" & vbCrLf & IIf(IsDBNull(YGLClient("CompanyName")), "", YGLClient("CompanyName")), MsgBoxStyle.Information)
            End If

            Return True
        Catch ex As Exception
            Return True
        Finally
            ADO = Nothing
        End Try
    End Function

   
#End Region
#Region "REPORT"
    Public Function GenerateTable_SummaryQE(dt As DataTable, ByRef ds As DataSet, ByRef ErrorLog As clsError) As Boolean
        Try
            If ds Is Nothing Then
                ds = New dsCA
            End If
            Dim dtTable As New DataTable("CA_REPORT_SUMMARY_QE_2")
            Dim col As DataColumn

            col = Nothing
            col = New DataColumn
            col.ColumnName = "CA_DESCRIPTION"
            col.Caption = "Description"
            col.DataType = System.Type.GetType("System.String")
            col.MaxLength = 255
            dtTable.Columns.Add(col)

            col = Nothing
            col = New DataColumn
            col.ColumnName = "YA"
            col.Caption = "YA"
            col.DataType = System.Type.GetType("System.Int32")
            dtTable.Columns.Add(col)

            col = New DataColumn
            col.ColumnName = "CA_CATEGORY"
            col.Caption = "Category"
            col.DataType = System.Type.GetType("System.String")
            col.MaxLength = 255
            dtTable.Columns.Add(col)

            col = Nothing
            col = New DataColumn
            col.ColumnName = "GroupType"
            col.Caption = "GroupType"
            col.DataType = System.Type.GetType("System.Int32")
            dtTable.Columns.Add(col)
            'col = Nothing
            'col = New DataColumn
            'col.ColumnName = "AA_0"
            'col.Caption = "No Claim"
            'col.DataType = System.Type.GetType("System.Decimal")
            'dtTable.Columns.Add(col)
            Dim ListofAA As List(Of String) = mdlCA.Get_ListofAA(True)
            Dim tmpStatus As Boolean = False
            For i As Integer = 0 To ListofAA.Count - 1
                tmpStatus = False
                For x As Integer = 0 To dt.Rows.Count - 1

                    If tmpStatus = False AndAlso IsDBNull(dt.Rows(x)(ListofAA(i))) = False AndAlso dt.Rows(x)(ListofAA(i)) <> 0 Then
                        tmpStatus = True

                        col = Nothing
                        col = New DataColumn
                        col.ColumnName = ListofAA(i)
                        col.Caption = ListofAA(i) & "% RM"
                        col.DataType = System.Type.GetType("System.Decimal")
                        dtTable.Columns.Add(col)
                    End If

                Next

            Next

            col = New DataColumn
            col.ColumnName = "Total"
            col.Caption = "Total"
            col.DataType = System.Type.GetType("System.Decimal")

            dtTable.Columns.Add(col)
            Dim dtRow As DataRow = Nothing
            For i As Integer = 0 To dt.Rows.Count - 1


                dtRow = Nothing
                dtRow = dtTable.NewRow
                For x As Integer = 0 To dtTable.Columns.Count - 1

                    If IsDBNull(dt.Rows(i)(dtTable.Columns(x).ColumnName)) = False Then
                        dtRow(dtTable.Columns(x).ColumnName) = dt.Rows(i)(dtTable.Columns(x).ColumnName)
                    End If

                Next
                dtTable.Rows.Add(dtRow)
            Next

            ds.Tables.Add(dtTable)

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
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function PrintReport_CAAnalysis(ds As DataSet, ID As String, ByRef rpt As rpt_CAAnalysis, ByRef ErrorLog As clsError, Optional ByVal SchApex As String = "") As Boolean
        Try
            Dim clsNote As New clsNote_CA
            If rpt Is Nothing Then
                rpt = New rpt_CAAnalysis
            End If

            ds.Tables("CA_NOTE_ATTACHMENT").Rows.Clear()
            ds.Tables("CA_NOTE_COLUMN").Rows.Clear()
            ds.Tables("CA_NOTE").Rows.Clear()

            ds.Tables("CA_REPORT_ANALYSIS_PROPERTY").Clear()


            Dim dt As DataTable = Nothing

             dt = ADO.Load_CAReport_Analysis_Temp(ID)

            For Each rowx As DataRow In dt.Rows
                ds.Tables("CA_REPORT_ANALYSIS_PROPERTY").ImportRow(rowx)
                ' rpt.DsCA1.Tables("CA_REPORT_ANALYSIS_PROPERTY").ImportRow(rowx)
            Next
            rpt.paramID.Value = ID
            rpt.paramSch.Value = SchApex
            rpt.Landscape = True

            Dim dtNote As DataTable = Nothing
            Dim dtNote_Child As DataTable = Nothing
            Dim tmpNoteID As Integer = 0

            For Each rowx As DataRow In dt.Rows
                If IsDBNull(rowx("CA_KEY")) = False Then

                    dtNote = clsNote.Load_Note(rowx("CA_KEY"), 0)

                    If dtNote IsNot Nothing Then

                        For Each rownote As DataRow In dtNote.Rows
                            'rpt.DsCA1.Tables("CA_NOTE").ImportRow(rownote)
                            ds.Tables("CA_NOTE").ImportRow(rownote)

                            tmpNoteID = rownote("ID")
                            dtNote_Child = Nothing
                            dtNote_Child = clsNote.Load_Note_Column(tmpNoteID)

                            If dtNote_Child IsNot Nothing Then
                                For Each rownote_child As DataRow In dtNote_Child.Rows
                                    rownote_child("ParentID") = tmpNoteID
                                    Application.DoEvents()
                                    'rpt.DsCA1.Tables("CA_NOTE_COLUMN").ImportRow(rownote_child)
                                    ds.Tables("CA_NOTE_COLUMN").ImportRow(rownote_child)
                                Next
                            End If
                            dtNote_Child = Nothing
                            dtNote_Child = clsNote.Load_Note_Attachment(tmpNoteID)

                            If dtNote_Child IsNot Nothing Then
                                For Each rownote_child As DataRow In dtNote_Child.Rows
                                    rownote_child("ParentID") = tmpNoteID
                                    Application.DoEvents()
                                    'rpt.DsCA1.Tables("CA_NOTE_ATTACHMENT").ImportRow(rownote_child)
                                    ds.Tables("CA_NOTE_ATTACHMENT").ImportRow(rownote_child)
                                Next
                            End If
                        Next

                    End If

                End If
            Next

            rpt.DataSource = ds
            rpt.XrSubreport1.ReportSource.DataSource = ds

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
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function PrintReport_SummaryQE(ds As DataSet, ID As String, ByRef rpt As rpt_CASummaryQE, ByRef ErrorLog As clsError, Optional ByVal SchApex As String = "") As Boolean
        Try

            Dim No40 As Decimal = 0

            If rpt Is Nothing Then
                rpt = New rpt_CASummaryQE
            End If

            rpt.DsCA1.Tables("CA_REPORT_SUMMARY_QE").Clear()

            For Each rowx As DataRow In ds.Tables("CA_REPORT_SUMMARY_QE_2").Rows
                rpt.DsCA1.Tables("CA_REPORT_SUMMARY_QE").ImportRow(rowx)
            Next
            rpt.paramID.Value = ID
            rpt.paramSch.Value = SchApex
            rpt.Landscape = True

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
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function PrintReport_ITA(RefNo As String, YA As String, ByRef rpt As rpt_ITA, ByRef ErrorLog As clsError, Optional ByVal SchApex As String = "") As Boolean
        Try

            Dim dtTaxCOM As DataTable = ADO.Load_Tax_Computation(RefNo, YA)

            Dim ds As New dsRA_ITA


            ds.Tables("CA").Rows.Clear()
            ds.Tables("TAX_ITA_WITHDRAWAL").Rows.Clear()
            ds.Tables("TAX_ITA_ADJUSTMENT").Rows.Clear()
            ds.Tables("TAX_COMPUTATION").Rows.Clear()
            If dtTaxCOM IsNot Nothing Then

                Dim TC_KEY As Integer = 0
                Dim TC_SOURCENO As Integer = 0
                Dim dtAdjustment As DataTable = Nothing
                Dim dtWithDrawal As DataTable = Nothing
                Dim dtCA As DataTable = Nothing
                For i As Integer = 0 To dtTaxCOM.Rows.Count - 1
                    TC_KEY = IIf(IsDBNull(dtTaxCOM.Rows(i)("TC_KEY")), 0, dtTaxCOM.Rows(i)("TC_KEY"))
                    TC_SOURCENO = IIf(IsDBNull(dtTaxCOM.Rows(i)("TC_BUSINESS")), 0, dtTaxCOM.Rows(i)("TC_BUSINESS"))
                    ds.Tables("TAX_COMPUTATION").ImportRow(dtTaxCOM.Rows(i))
                    Application.DoEvents()

                    dtCA = ADO.LoadCA_ByRefNoYASourceNo(RefNo, YA, TC_SOURCENO)
                    If dtCA IsNot Nothing Then
                        For Each rowx As DataRow In dtCA.Rows
                            ds.Tables("CA").ImportRow(rowx)
                        Next
                    End If

                    dtWithDrawal = ADO.Load_Taxcom_RA_Withdrawal(TC_KEY, ErrorLog)
                    If dtWithDrawal IsNot Nothing Then
                        For Each rowx As DataRow In dtWithDrawal.Rows
                            ds.Tables("TAX_ITA_WITHDRAWAL").ImportRow(rowx)
                        Next
                    End If

                    dtAdjustment = ADO.Load_Taxcom_RA_Adjustment(TC_KEY, ErrorLog)
                    If dtAdjustment IsNot Nothing Then
                        For Each rowx As DataRow In dtAdjustment.Rows
                            ds.Tables("TAX_ITA_ADJUSTMENT").ImportRow(rowx)
                        Next
                    End If


                Next

                If rpt Is Nothing Then
                    rpt = New rpt_ITA
                End If
                rpt.paramSch.Value = SchApex
                rpt.DataSource = ds
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
    Public Function PrintReport_RA(RefNo As String, YA As String, ByRef rpt As rpt_RA, ByRef ErrorLog As clsError, Optional ByVal SchApex As String = "") As Boolean
        Try

            Dim dtTaxCOM As DataTable = ADO.Load_Tax_Computation(RefNo, YA)

            Dim ds As New dsRA_ITA


            ds.Tables("CA").Rows.Clear()
            ds.Tables("TAX_RA_WITHDRAWAL").Rows.Clear()
            ds.Tables("TAX_RA_ADJUSTMENT").Rows.Clear()
            ds.Tables("TAX_COMPUTATION").Rows.Clear()
            If dtTaxCOM IsNot Nothing Then

                Dim TC_KEY As Integer = 0
                Dim TC_SOURCENO As Integer = 0
                Dim dtAdjustment As DataTable = Nothing
                Dim dtWithDrawal As DataTable = Nothing
                Dim dtCA As DataTable = Nothing
                For i As Integer = 0 To dtTaxCOM.Rows.Count - 1
                    TC_KEY = IIf(IsDBNull(dtTaxCOM.Rows(i)("TC_KEY")), 0, dtTaxCOM.Rows(i)("TC_KEY"))
                    TC_SOURCENO = IIf(IsDBNull(dtTaxCOM.Rows(i)("TC_BUSINESS")), 0, dtTaxCOM.Rows(i)("TC_BUSINESS"))
                    ds.Tables("TAX_COMPUTATION").ImportRow(dtTaxCOM.Rows(i))
                    Application.DoEvents()

                    dtCA = ADO.LoadCA_ByRefNoYASourceNo(RefNo, YA, TC_SOURCENO)
                    If dtCA IsNot Nothing Then
                        For Each rowx As DataRow In dtCA.Rows
                            ds.Tables("CA").ImportRow(rowx)
                        Next
                    End If

                    dtWithDrawal = ADO.Load_Taxcom_RA_Withdrawal(TC_KEY, ErrorLog)
                    If dtWithDrawal IsNot Nothing Then
                        For Each rowx As DataRow In dtWithDrawal.Rows
                            ds.Tables("TAX_RA_WITHDRAWAL").ImportRow(rowx)
                        Next
                    End If

                    dtAdjustment = ADO.Load_Taxcom_RA_Adjustment(TC_KEY, ErrorLog)
                    If dtAdjustment IsNot Nothing Then
                        For Each rowx As DataRow In dtAdjustment.Rows
                            ds.Tables("TAX_RA_ADJUSTMENT").ImportRow(rowx)
                        Next
                    End If


                Next

                If rpt Is Nothing Then
                    rpt = New rpt_RA
                End If
                rpt.paramSch.Value = SchApex
                rpt.DataSource = ds

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
    Public Function PrintReport_CP204(dsCP204 As DataSet, RefNo As String, YA As String, ID As Integer, ByRef rpt As rpt_CP204_Breakdown, _
                                      ByRef ErrorLog As clsError, Optional ByVal SchApex As String = "APPENDIX") As Boolean
        Try
            Dim clsCP204_Note As New clsNote_CP204

            Dim dt As DataTable = ADO.Load_CP204_BreakDown_ByParentID(ID)

            dsCP204.Tables("BORANG_CP204_TRICOR_BREAKDOWN_REPORT").Rows.Clear()
            If dt Is Nothing Then
                MsgBox("Record not found.", MsgBoxStyle.Critical)
                Exit Function
            End If


            Dim dtRow As DataRow = Nothing
            Dim dtNote As DataTable = Nothing
            Dim dtNoteChild As DataTable = Nothing
            Dim Ext As String = Nothing
            Dim dtRowAtt As Byte() = Nothing

            dsCP204.Tables("BORANG_CP204_NOTE_COLUMN").Rows.Clear()
            dsCP204.Tables("BORANG_CP204_NOTE_ATTACHMENT").Rows.Clear()
            dsCP204.Tables("BORANG_CP204_NOTE").Rows.Clear()

            For i As Integer = 0 To dt.Rows.Count - 1
                dtRow = Nothing
                dtRow = dsCP204.Tables("BORANG_CP204_TRICOR_BREAKDOWN_REPORT").NewRow
                dtRow("CP_ID") = IIf(IsDBNull(dt.Rows(i)("CP_ID")), 0, dt.Rows(i)("CP_ID"))
                dtRow("CP_PARENTID") = IIf(IsDBNull(dt.Rows(i)("CP_PARENTID")), 0, dt.Rows(i)("CP_PARENTID"))
                dtRow("CP_INSTALL_NO") = i + 1
                dtRow("CP_PAYMENT_DUE") = IIf(IsDBNull(dt.Rows(i)("CP_PAYMENT_DUE")), DBNull.Value, dt.Rows(i)("CP_PAYMENT_DUE"))
                dtRow("CP_INSTALLMENT_AMOUNT") = IIf(IsDBNull(dt.Rows(i)("CP_INSTALLMENT_AMOUNT")), 0, dt.Rows(i)("CP_INSTALLMENT_AMOUNT"))
                dtRow("CP_PAYMENT_DATE_1") = IIf(IsDBNull(dt.Rows(i)("CP_PAYMENT_DATE_1")), DBNull.Value, dt.Rows(i)("CP_PAYMENT_DATE_1"))
                dtRow("CP_AMOUNT_PAID_1") = IIf(IsDBNull(dt.Rows(i)("CP_AMOUNT_PAID_1")), 0, dt.Rows(i)("CP_AMOUNT_PAID_1"))
                '  dtRow("CP_TOTAL_INSTALLMENT") = IIf(IsDBNull(dt.Rows(i)("BCP_ESTIMATED_TAX")), 0, dt.Rows(i)("BCP_ESTIMATED_TAX"))

                If IsDBNull(dt.Rows(i)("CP_PAYMENT_DATE_2")) = False AndAlso IsDBNull(dt.Rows(i)("CP_AMOUNT_PAID_2")) = False AndAlso CDec(dt.Rows(i)("CP_AMOUNT_PAID_2")) <> 0 Then
                    dtRow("CP_PENALTY") = 0
                Else
                    dtRow("CP_PENALTY") = IIf(IsDBNull(dt.Rows(i)("CP_PENALTY")), 0, dt.Rows(i)("CP_PENALTY"))
                End If


                '==========NOTE======================================================================================
                dtNote = Nothing
                dtNote = clsCP204_Note.Load_Note(dt.Rows(i)("CP_TagID"), ID, ErrorLog)

                If dtNote IsNot Nothing Then
                    dtRow("CP_NOTE_TITLE") = IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                    dtNote.Rows(0)("ID") = dsCP204.Tables("BORANG_CP204_NOTE").Rows.Count + 1
                    dsCP204.Tables("BORANG_CP204_NOTE").ImportRow(dtNote.Rows(0))
                End If

                Application.DoEvents()
                If dtNote IsNot Nothing Then

                    dtNoteChild = Nothing
                    dtNoteChild = clsCP204_Note.Load_Note_Attachment(dtNote.Rows(0)("ID"), ErrorLog)
                    If dtNoteChild IsNot Nothing Then
                        For Each rowx As DataRow In dtNoteChild.Rows
                            rowx("ParentID") = dtNote.Rows(0)("ID")
                            dsCP204.Tables("BORANG_CP204_NOTE_ATTACHMENT").ImportRow(rowx)

                            Ext = Nothing
                            dtRowAtt = IIf(IsDBNull(rowx("Attachment")), Nothing, rowx("Attachment"))
                            Ext = IIf(IsDBNull(rowx("Extension")), Nothing, rowx("Extension"))

                            If dtRowAtt IsNot Nothing Then
                                Dim frmnote As New frmNote_AttachmentView
                                Select Case Ext.ToLower
                                    Case ".jpg", ".png", ".jpeg", ".bitmap", ".ico", ".gif", ".tif"
                                        frmnote.Type = 0
                                    Case ".xls", ".xlsx", ".csv", ".openxml"
                                        frmnote.Type = 1
                                    Case ".doc", "docx", ".rtf", ".wordml", ".opendocument"
                                        frmnote.Type = 2
                                    Case ".pdf"
                                        frmnote.Type = 3
                                End Select
                                frmnote.Title = dtRow("CP_NOTE_TITLE")
                                frmnote.Extension = Ext
                                frmnote.dataArr = dtRowAtt
                                frmnote.Show()
                            End If
                        Next
                    End If

                    dtNoteChild = Nothing
                    dtNoteChild = clsCP204_Note.Load_Note_Column(dtNote.Rows(0)("ID"), ErrorLog)
                    If dtNoteChild IsNot Nothing Then
                        For Each rowx As DataRow In dtNoteChild.Rows
                            rowx("ParentID") = dtNote.Rows(0)("ID")
                            dsCP204.Tables("BORANG_CP204_NOTE_COLUMN").ImportRow(rowx)
                        Next
                    End If

                End If
                '==========NOTE======================================================================================

                dsCP204.Tables("BORANG_CP204_TRICOR_BREAKDOWN_REPORT").Rows.Add(dtRow)


                If IsDBNull(dt.Rows(i)("CP_PAYMENT_DATE_2")) = False AndAlso IsDBNull(dt.Rows(i)("CP_AMOUNT_PAID_2")) = False AndAlso CDec(dt.Rows(i)("CP_AMOUNT_PAID_2")) <> 0 Then
                    dtRow = Nothing

                    dtRow = dsCP204.Tables("BORANG_CP204_TRICOR_BREAKDOWN_REPORT").NewRow
                    dtRow("CP_ID") = IIf(IsDBNull(dt.Rows(i)("CP_ID")), 0, dt.Rows(i)("CP_ID"))
                    dtRow("CP_PARENTID") = IIf(IsDBNull(dt.Rows(i)("CP_PARENTID")), 0, dt.Rows(i)("CP_PARENTID"))
                    dtRow("CP_INSTALL_NO") = IIf(IsDBNull(dt.Rows(i)("CP_INSTALL_NO")), 0, dt.Rows(i)("CP_INSTALL_NO"))
                    dtRow("CP_PAYMENT_DUE") = DBNull.Value 'IIf(IsDBNull(dt.Rows(i)("CP_PAYMENT_DUE")), DBNull.Value, dt.Rows(i)("CP_PAYMENT_DUE"))
                    dtRow("CP_INSTALLMENT_AMOUNT") = DBNull.Value 'IIf(IsDBNull(dt.Rows(i)("CP_INSTALLMENT_AMOUNT")), 0, dt.Rows(i)("CP_INSTALLMENT_AMOUNT"))
                    dtRow("CP_PAYMENT_DATE_1") = IIf(IsDBNull(dt.Rows(i)("CP_PAYMENT_DATE_2")), DBNull.Value, dt.Rows(i)("CP_PAYMENT_DATE_2"))
                    dtRow("CP_AMOUNT_PAID_1") = IIf(IsDBNull(dt.Rows(i)("CP_AMOUNT_PAID_2")), 0, dt.Rows(i)("CP_AMOUNT_PAID_2"))
                    '  dtRow("CP_TOTAL_INSTALLMENT") = IIf(IsDBNull(dt.Rows(i)("BCP_ESTIMATED_TAX")), 0, dt.Rows(i)("BCP_ESTIMATED_TAX"))
                    dtRow("CP_PENALTY") = IIf(IsDBNull(dt.Rows(i)("CP_PENALTY")), 0, dt.Rows(i)("CP_PENALTY"))
                    dsCP204.Tables("BORANG_CP204_TRICOR_BREAKDOWN_REPORT").Rows.Add(dtRow)

                End If


            Next

            If rpt Is Nothing Then
                rpt = New rpt_CP204_Breakdown
            End If
            ' Dim ComName As String = GridView1
            rpt.paramCompanyName.Value = ADO.LoadTaxPayer_CompanyName(RefNo)
            '  rpt.paramCompanyName.Value =' .ToString.ToUpper
            rpt.paramYA.Value = YA
            rpt.paramSch.Value = IIf(SchApex = "", "APPENDIX", SchApex)
            rpt.DataSource = dsCP204
            rpt.XrSubreport1.ReportSource.DataSource = dsCP204

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
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function PrintReport_CAByAsset(dsCA As DataSet, ComName As String, YA As String, ByRef rpt As rptCAReport, ByRef ErrorLog As clsError) As Boolean
        Try
            Dim clsNote As New clsNote_CA
            Dim dtNote As DataTable = Nothing
            Dim dtNote_Child As DataTable = Nothing
            Dim tmpNoteID As Integer = 0
            Dim Ext As String = Nothing
            Dim dtRowAtt As Byte() = Nothing
            Dim i As Integer = -1


            dsCA.Tables("CA_NOTE_ATTACHMENT").Rows.Clear()
            dsCA.Tables("CA_NOTE_COLUMN").Rows.Clear()
            dsCA.Tables("CA_NOTE").Rows.Clear()


            'Capital Allowance Details By Rate
            If rpt Is Nothing Then
                rpt = New rptCAReport
            End If

            rpt.paramCompanyName.Value = ComName
            rpt.paramYA.Value = CInt(YA)


            rpt.Landscape = True

            For Each rowx As DataRow In dsCA.Tables("CA_REPORT_TEMP").Rows
                If IsDBNull(rowx("CA_KEY")) = False Then

                    dtNote = clsNote.Load_Note(rowx("CA_KEY"), 0)

                    If dtNote IsNot Nothing Then
                        i = -1
                        For Each rownote As DataRow In dtNote.Rows
                            i += 1
                            dsCA.Tables("CA_NOTE").ImportRow(rownote)

                            tmpNoteID = rownote("ID")
                            dtNote_Child = Nothing
                            dtNote_Child = clsNote.Load_Note_Column(tmpNoteID)

                            If dtNote_Child IsNot Nothing Then
                                For Each rownote_child As DataRow In dtNote_Child.Rows
                                    rownote_child("ParentID") = tmpNoteID
                                    Application.DoEvents()
                                    dsCA.Tables("CA_NOTE_COLUMN").ImportRow(rownote_child)
                                Next
                            End If
                            dtNote_Child = Nothing
                            dtNote_Child = clsNote.Load_Note_Attachment(tmpNoteID)

                            If dtNote_Child IsNot Nothing Then
                                For Each rownote_child As DataRow In dtNote_Child.Rows
                                    rownote_child("ParentID") = tmpNoteID
                                    Application.DoEvents()
                                    dsCA.Tables("CA_NOTE_ATTACHMENT").ImportRow(rownote_child)

                                    Ext = Nothing
                                    dtRowAtt = IIf(IsDBNull(rownote_child("Attachment")), Nothing, rownote_child("Attachment"))
                                    Ext = IIf(IsDBNull(rownote_child("Extension")), Nothing, rownote_child("Extension"))

                                    If dtRowAtt IsNot Nothing Then
                                        Dim frmnote As New frmNote_AttachmentView
                                        Select Case Ext.ToLower
                                            Case ".jpg", ".png", ".jpeg", ".bitmap", ".ico", ".gif", ".tif"
                                                frmnote.Type = 0
                                            Case ".xls", ".xlsx", ".csv", ".openxml"
                                                frmnote.Type = 1
                                            Case ".doc", "docx", ".rtf", ".wordml", ".opendocument"
                                                frmnote.Type = 2
                                            Case ".pdf"
                                                frmnote.Type = 3
                                        End Select
                                        frmnote.Title = dsCA.Tables("CA_NOTE").Rows(i)("Title")
                                        frmnote.Extension = Ext
                                        frmnote.dataArr = dtRowAtt
                                        frmnote.Show()
                                    End If
                                Next
                            End If
                        Next

                    End If

                End If
            Next

            rpt.DataSource = dsCA
            rpt.XrSubreport1.ReportSource.DataSource = dsCA
            rpt.FontSize.Value = 8

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
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function PrintReport_CAByRate(dsCA As DataSet, ComName As String, YA As String, ByRef rpt As rpt_CAByRate, _
                                         ByRef ErrorLog As clsError, Optional ByVal SchApex As String = "") As Boolean
        Try
            Dim clsNote As New clsNote_CA
            Dim dtNote As DataTable = Nothing
            Dim dtNote_Child As DataTable = Nothing
            Dim tmpNoteID As Integer = 0
            Dim Ext As String = Nothing
            Dim dtRowAtt As Byte() = Nothing
            Dim i As Integer = -1


            dsCA.Tables("CA_NOTE_ATTACHMENT").Rows.Clear()
            dsCA.Tables("CA_NOTE_COLUMN").Rows.Clear()
            dsCA.Tables("CA_NOTE").Rows.Clear()


            'Capital Allowance Details By Rate
            If rpt Is Nothing Then
                rpt = New rpt_CAByRate
            End If

            rpt.paramCompanyName.Value = ComName
            rpt.paramYA.Value = CInt(YA)


            rpt.Landscape = True

            For Each rowx As DataRow In dsCA.Tables("CA_REPORT_TEMP").Rows
                If IsDBNull(rowx("CA_KEY")) = False Then

                    dtNote = clsNote.Load_Note(rowx("CA_KEY"), 0)

                    If dtNote IsNot Nothing Then
                        i = -1
                        For Each rownote As DataRow In dtNote.Rows
                            i += 1
                            dsCA.Tables("CA_NOTE").ImportRow(rownote)

                            tmpNoteID = rownote("ID")
                            dtNote_Child = Nothing
                            dtNote_Child = clsNote.Load_Note_Column(tmpNoteID)

                            If dtNote_Child IsNot Nothing Then
                                For Each rownote_child As DataRow In dtNote_Child.Rows
                                    rownote_child("ParentID") = tmpNoteID
                                    Application.DoEvents()
                                    dsCA.Tables("CA_NOTE_COLUMN").ImportRow(rownote_child)
                                Next
                            End If
                            dtNote_Child = Nothing
                            dtNote_Child = clsNote.Load_Note_Attachment(tmpNoteID)

                            If dtNote_Child IsNot Nothing Then
                                For Each rownote_child As DataRow In dtNote_Child.Rows
                                    rownote_child("ParentID") = tmpNoteID
                                    Application.DoEvents()
                                    dsCA.Tables("CA_NOTE_ATTACHMENT").ImportRow(rownote_child)

                                    Ext = Nothing
                                    dtRowAtt = IIf(IsDBNull(rownote_child("Attachment")), Nothing, rownote_child("Attachment"))
                                    Ext = IIf(IsDBNull(rownote_child("Extension")), Nothing, rownote_child("Extension"))

                                    If dtRowAtt IsNot Nothing Then
                                        Dim frmnote As New frmNote_AttachmentView
                                        Select Case Ext.ToLower
                                            Case ".jpg", ".png", ".jpeg", ".bitmap", ".ico", ".gif", ".tif"
                                                frmnote.Type = 0
                                            Case ".xls", ".xlsx", ".csv", ".openxml"
                                                frmnote.Type = 1
                                            Case ".doc", "docx", ".rtf", ".wordml", ".opendocument"
                                                frmnote.Type = 2
                                            Case ".pdf"
                                                frmnote.Type = 3
                                        End Select
                                        frmnote.Title = dsCA.Tables("CA_NOTE").Rows(i)("Title")
                                        frmnote.Extension = Ext
                                        frmnote.dataArr = dtRowAtt
                                        frmnote.Show()
                                    End If
                                Next
                            End If
                        Next

                    End If

                End If
            Next

            rpt.DataSource = dsCA
            rpt.XrSubreport1.ReportSource.DataSource = dsCA
            rpt.FontSize.Value = 8
            rpt.paramSch.Value = SchApex

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
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function PrintReport_CAByCategory(dsCA As DataSet, ComName As String, YA As String, ByRef rpt As rpt_CAByCategory, _
                                             ByRef ErrorLog As clsError, Optional ByVal SchApex As String = "") As Boolean
        Try
            Dim clsNote As New clsNote_CA
            Dim dtNote As DataTable = Nothing
            Dim dtNote_Child As DataTable = Nothing
            Dim tmpNoteID As Integer = 0
            Dim Ext As String = Nothing
            Dim dtRowAtt As Byte() = Nothing
            Dim i As Integer = -1


            dsCA.Tables("CA_NOTE_ATTACHMENT").Rows.Clear()
            dsCA.Tables("CA_NOTE_COLUMN").Rows.Clear()
            dsCA.Tables("CA_NOTE").Rows.Clear()


            'Capital Allowance Details By Rate
            If rpt Is Nothing Then
                rpt = New rpt_CAByCategory
            End If

            rpt.paramCompanyName.Value = ComName
            rpt.paramYA.Value = CInt(YA)


            rpt.Landscape = True

            For Each rowx As DataRow In dsCA.Tables("CA_REPORT_TEMP").Rows
                If IsDBNull(rowx("CA_KEY")) = False Then

                    dtNote = clsNote.Load_Note(rowx("CA_KEY"), 0)

                    If dtNote IsNot Nothing Then
                        i = -1
                        For Each rownote As DataRow In dtNote.Rows
                            i += 1
                            dsCA.Tables("CA_NOTE").ImportRow(rownote)

                            tmpNoteID = rownote("ID")
                            dtNote_Child = Nothing
                            dtNote_Child = clsNote.Load_Note_Column(tmpNoteID)

                            If dtNote_Child IsNot Nothing Then
                                For Each rownote_child As DataRow In dtNote_Child.Rows
                                    rownote_child("ParentID") = tmpNoteID
                                    Application.DoEvents()
                                    dsCA.Tables("CA_NOTE_COLUMN").ImportRow(rownote_child)
                                Next
                            End If
                            dtNote_Child = Nothing
                            dtNote_Child = clsNote.Load_Note_Attachment(tmpNoteID)

                            If dtNote_Child IsNot Nothing Then
                                For Each rownote_child As DataRow In dtNote_Child.Rows
                                    rownote_child("ParentID") = tmpNoteID
                                    Application.DoEvents()
                                    dsCA.Tables("CA_NOTE_ATTACHMENT").ImportRow(rownote_child)

                                    Ext = Nothing
                                    dtRowAtt = IIf(IsDBNull(rownote_child("Attachment")), Nothing, rownote_child("Attachment"))
                                    Ext = IIf(IsDBNull(rownote_child("Extension")), Nothing, rownote_child("Extension"))

                                    If dtRowAtt IsNot Nothing Then
                                        Dim frmnote As New frmNote_AttachmentView
                                        Select Case Ext.ToLower
                                            Case ".jpg", ".png", ".jpeg", ".bitmap", ".ico", ".gif", ".tif"
                                                frmnote.Type = 0
                                            Case ".xls", ".xlsx", ".csv", ".openxml"
                                                frmnote.Type = 1
                                            Case ".doc", "docx", ".rtf", ".wordml", ".opendocument"
                                                frmnote.Type = 2
                                            Case ".pdf"
                                                frmnote.Type = 3
                                        End Select
                                        frmnote.Title = dsCA.Tables("CA_NOTE").Rows(i)("Title")
                                        frmnote.Extension = Ext
                                        frmnote.dataArr = dtRowAtt
                                        frmnote.Show()
                                    End If
                                Next
                            End If
                        Next

                    End If

                End If
            Next

            rpt.DataSource = dsCA
            rpt.XrSubreport1.ReportSource.DataSource = dsCA
            rpt.FontSize.Value = 8
            rpt.paramSch.Value = SchApex

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
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function PrintReport_ControlTransferOut(dsCA As DataSet, ComName As String, ByVal YA As String, ByRef rpt As rpt_CAControlTransfer_Out, _
                                                   ByRef ErrorLog As clsError, Optional ByVal SchApex As String = "") As Boolean
        Try
            Dim clsNote As New clsNote_CA
            Dim dtNote As DataTable = Nothing
            Dim dtNote_Child As DataTable = Nothing
            Dim tmpNoteID As Integer = 0
            Dim Ext As String = Nothing
            Dim dtRowAtt As Byte() = Nothing
            Dim i As Integer = -1

            'Control Transfer Out
            If rpt Is Nothing Then
                rpt = New rpt_CAControlTransfer_Out
            End If

            rpt.paramCompanyName.Value = ComName
            rpt.paramYA.Value = CInt(YA)


            rpt.Landscape = True


            For Each rowx As DataRow In dsCA.Tables("CA_REPORT_DISPOSAL_TEMP").Rows
                If IsDBNull(rowx("CA_KEY")) = False Then

                    dtNote = clsNote.Load_Note(rowx("CA_KEY"), 2, CStr(rowx("DISP_KEY")), Nothing)

                    If dtNote IsNot Nothing Then
                        i = -1
                        For Each rownote As DataRow In dtNote.Rows
                            i += 1
                            dsCA.Tables("CA_NOTE").ImportRow(rownote)

                            tmpNoteID = rownote("ID")
                            dtNote_Child = Nothing
                            dtNote_Child = clsNote.Load_Note_Column(tmpNoteID)


                            If dtNote_Child IsNot Nothing Then
                                For Each rownote_child As DataRow In dtNote_Child.Rows
                                    rownote_child("ParentID") = tmpNoteID
                                    Application.DoEvents()
                                    dsCA.Tables("CA_NOTE_COLUMN").ImportRow(rownote_child)
                                Next
                            End If
                            dtNote_Child = Nothing
                            dtNote_Child = clsNote.Load_Note_Attachment(tmpNoteID)

                            If dtNote_Child IsNot Nothing Then
                                For Each rownote_child As DataRow In dtNote_Child.Rows
                                    rownote_child("ParentID") = tmpNoteID
                                    Application.DoEvents()
                                    dsCA.Tables("CA_NOTE_ATTACHMENT").ImportRow(rownote_child)

                                    Ext = Nothing
                                    dtRowAtt = IIf(IsDBNull(rownote_child("Attachment")), Nothing, rownote_child("Attachment"))
                                    Ext = IIf(IsDBNull(rownote_child("Extension")), Nothing, rownote_child("Extension"))

                                    If dtRowAtt IsNot Nothing Then
                                        Dim frmnote As New frmNote_AttachmentView
                                        Select Case Ext.ToLower
                                            Case ".jpg", ".png", ".jpeg", ".bitmap", ".ico", ".gif", ".tif"
                                                frmnote.Type = 0
                                            Case ".xls", ".xlsx", ".csv", ".openxml"
                                                frmnote.Type = 1
                                            Case ".doc", "docx", ".rtf", ".wordml", ".opendocument"
                                                frmnote.Type = 2
                                            Case ".pdf"
                                                frmnote.Type = 3
                                        End Select
                                        frmnote.Title = dsCA.Tables("CA_NOTE").Rows(i)("Title")
                                        frmnote.Extension = Ext
                                        frmnote.dataArr = dtRowAtt
                                        frmnote.Show()
                                    End If
                                Next
                            End If
                        Next

                    End If

                End If
            Next

            rpt.DataSource = dsCA
            rpt.XrSubreport1.ReportSource.DataSource = dsCA
            rpt.FontSize.Value = 11
            rpt.paramSch.Value = SchApex

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
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function PrintReport_WrittenOff(dsCA As DataSet, ComName As String, ByVal YA As String, ByRef rpt As rpt_CAWrittenOff, _
                                           ByRef ErrorLog As clsError, Optional ByVal SchApex As String = "") As Boolean
        Try
            Dim clsNote As New clsNote_CA
            Dim dtNote As DataTable = Nothing
            Dim dtNote_Child As DataTable = Nothing
            Dim tmpNoteID As Integer = 0
            Dim Ext As String = Nothing
            Dim dtRowAtt As Byte() = Nothing
            Dim i As Integer = -1

            'Written Off
            If rpt Is Nothing Then
                rpt = New rpt_CAWrittenOff
            End If

            rpt.paramCompanyName.Value = ComName
            rpt.paramYA.Value = CInt(YA)


            rpt.Landscape = True

            For Each rowx As DataRow In dsCA.Tables("CA_REPORT_DISPOSAL_TEMP").Rows
                If IsDBNull(rowx("CA_KEY")) = False Then

                    dtNote = clsNote.Load_Note(rowx("CA_KEY"), 2, CStr(rowx("DISP_KEY")), Nothing)

                    If dtNote IsNot Nothing Then
                        i = -1
                        For Each rownote As DataRow In dtNote.Rows
                            i += 1
                            dsCA.Tables("CA_NOTE").ImportRow(rownote)

                            tmpNoteID = rownote("ID")
                            dtNote_Child = Nothing
                            dtNote_Child = clsNote.Load_Note_Column(tmpNoteID)

                            If dtNote_Child IsNot Nothing Then
                                For Each rownote_child As DataRow In dtNote_Child.Rows
                                    rownote_child("ParentID") = tmpNoteID
                                    Application.DoEvents()
                                    dsCA.Tables("CA_NOTE_COLUMN").ImportRow(rownote_child)
                                Next
                            End If
                            dtNote_Child = Nothing
                            dtNote_Child = clsNote.Load_Note_Attachment(tmpNoteID)

                            If dtNote_Child IsNot Nothing Then
                                For Each rownote_child As DataRow In dtNote_Child.Rows
                                    rownote_child("ParentID") = tmpNoteID
                                    Application.DoEvents()
                                    dsCA.Tables("CA_NOTE_ATTACHMENT").ImportRow(rownote_child)

                                    Ext = Nothing
                                    dtRowAtt = IIf(IsDBNull(rownote_child("Attachment")), Nothing, rownote_child("Attachment"))
                                    Ext = IIf(IsDBNull(rownote_child("Extension")), Nothing, rownote_child("Extension"))

                                    If dtRowAtt IsNot Nothing Then
                                        Dim frmnote As New frmNote_AttachmentView
                                        Select Case Ext.ToLower
                                            Case ".jpg", ".png", ".jpeg", ".bitmap", ".ico", ".gif", ".tif"
                                                frmnote.Type = 0
                                            Case ".xls", ".xlsx", ".csv", ".openxml"
                                                frmnote.Type = 1
                                            Case ".doc", "docx", ".rtf", ".wordml", ".opendocument"
                                                frmnote.Type = 2
                                            Case ".pdf"
                                                frmnote.Type = 3
                                        End Select
                                        frmnote.Title = dsCA.Tables("CA_NOTE").Rows(i)("Title")
                                        frmnote.Extension = Ext
                                        frmnote.dataArr = dtRowAtt
                                        frmnote.Show()
                                    End If
                                Next
                            End If
                        Next

                    End If

                End If
            Next

            rpt.DataSource = dsCA
            rpt.XrSubreport1.ReportSource.DataSource = dsCA
            rpt.FontSize.Value = 11
            rpt.paramSch.Value = SchApex

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
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function PrintReport_Disposal(dsCA As DataSet, ComName As String, YA As String, ByRef rpt As rpt_Disposal, _
                                         ByRef ErrorLog As clsError, Optional ByVal SchApex As String = "") As Boolean
        Try
            'Disposal
            Dim clsNote As New clsNote_CA

            Dim dtNote As DataTable = Nothing
            Dim dtNote_Child As DataTable = Nothing
            Dim tmpNoteID As Integer = 0
            Dim Ext As String = Nothing
            Dim dtRowAtt As Byte() = Nothing
            Dim i As Integer = -1

            dsCA.Tables("CA_NOTE_ATTACHMENT").Rows.Clear()
            dsCA.Tables("CA_NOTE_COLUMN").Rows.Clear()
            dsCA.Tables("CA_NOTE").Rows.Clear()

            If rpt Is Nothing Then
                rpt = New rpt_Disposal
            End If
            rpt.paramCompanyName.Value = ComName
            rpt.paramYA.Value = CInt(YA)
            rpt.Landscape = True

            For Each rowx As DataRow In dsCA.Tables("CA_REPORT_DISPOSAL_TEMP").Rows
                If IsDBNull(rowx("CA_KEY")) = False Then

                    dtNote = clsNote.Load_Note(rowx("CA_KEY"), 2, CStr(rowx("DISP_KEY")), Nothing)

                    If dtNote IsNot Nothing Then
                        i = -1
                        For Each rownote As DataRow In dtNote.Rows
                            i += 1
                            dsCA.Tables("CA_NOTE").ImportRow(rownote)

                            tmpNoteID = rownote("ID")
                            dtNote_Child = Nothing
                            dtNote_Child = clsNote.Load_Note_Column(tmpNoteID)

                            If dtNote_Child IsNot Nothing Then
                                For Each rownote_child As DataRow In dtNote_Child.Rows
                                    rownote_child("ParentID") = tmpNoteID
                                    Application.DoEvents()
                                    dsCA.Tables("CA_NOTE_COLUMN").ImportRow(rownote_child)
                                Next
                            End If
                            dtNote_Child = Nothing
                            dtNote_Child = clsNote.Load_Note_Attachment(tmpNoteID)

                            If dtNote_Child IsNot Nothing Then
                                For Each rownote_child As DataRow In dtNote_Child.Rows
                                    rownote_child("ParentID") = tmpNoteID
                                    Application.DoEvents()
                                    dsCA.Tables("CA_NOTE_ATTACHMENT").ImportRow(rownote_child)


                                    Ext = Nothing
                                    dtRowAtt = IIf(IsDBNull(rownote_child("Attachment")), Nothing, rownote_child("Attachment"))
                                    Ext = IIf(IsDBNull(rownote_child("Extension")), Nothing, rownote_child("Extension"))

                                    If dtRowAtt IsNot Nothing Then
                                        Dim frmnote As New frmNote_AttachmentView
                                        Select Case Ext.ToLower
                                            Case ".jpg", ".png", ".jpeg", ".bitmap", ".ico", ".gif", ".tif"
                                                frmnote.Type = 0
                                            Case ".xls", ".xlsx", ".csv", ".openxml"
                                                frmnote.Type = 1
                                            Case ".doc", "docx", ".rtf", ".wordml", ".opendocument"
                                                frmnote.Type = 2
                                            Case ".pdf"
                                                frmnote.Type = 3
                                        End Select
                                        frmnote.Title = dsCA.Tables("CA_NOTE").Rows(i)("Title")
                                        frmnote.Extension = Ext
                                        frmnote.dataArr = dtRowAtt
                                        frmnote.Show()
                                    End If
                                Next
                            End If
                        Next

                    End If

                End If
            Next

            rpt.DataSource = dsCA
            rpt.XrSubreport1.ReportSource.DataSource = dsCA
            rpt.FontSize.Value = 11
            rpt.paramSch.Value = SchApex

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
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function PrintReport_HP(dsCA As DataSet, ComName As String, YA As String, ByRef rpt As rpt_HP, _
                                   ByRef ErrorLog As clsError, Optional ByVal SchApex As String = "") As Boolean
        Try
            Dim clsNote As New clsNote_CA


            'Capital Allowance Details By Rate
            If rpt Is Nothing Then
                rpt = New rpt_HP
            End If

            Dim dtNote As DataTable = Nothing
            Dim dtNote_Child As DataTable = Nothing
            Dim tmpNoteID As Integer = 0

            Dim Ext As String = Nothing
            Dim dtRowAtt As Byte() = Nothing
            Dim i As Integer = -1

            dsCA.Tables("CA_NOTE_ATTACHMENT").Rows.Clear()
            dsCA.Tables("CA_NOTE_COLUMN").Rows.Clear()
            dsCA.Tables("CA_NOTE").Rows.Clear()


            rpt.ParamCompanyName.Value = ComName
            rpt.ParamYA.Value = CInt(YA)


            rpt.Landscape = True

            For Each rowx As DataRow In dsCA.Tables("HP_REPORT_TEMP").Rows
                If IsDBNull(rowx("HP_KEY")) = False Then

                    dtNote = clsNote.Load_Note(rowx("HP_KEY"), 1)

                    If dtNote IsNot Nothing Then
                        i = -1
                        For Each rownote As DataRow In dtNote.Rows
                            i += 1
                            dsCA.Tables("CA_NOTE").ImportRow(rownote)

                            tmpNoteID = rownote("ID")
                            dtNote_Child = Nothing
                            dtNote_Child = clsNote.Load_Note_Column(tmpNoteID)

                            If dtNote_Child IsNot Nothing Then
                                For Each rownote_child As DataRow In dtNote_Child.Rows
                                    rownote_child("ParentID") = tmpNoteID
                                    Application.DoEvents()
                                    dsCA.Tables("CA_NOTE_COLUMN").ImportRow(rownote_child)
                                Next
                            End If
                            dtNote_Child = Nothing
                            dtNote_Child = clsNote.Load_Note_Attachment(tmpNoteID)

                            If dtNote_Child IsNot Nothing Then

                                For Each rownote_child As DataRow In dtNote_Child.Rows
                                    rownote_child("ParentID") = tmpNoteID
                                    Application.DoEvents()
                                    dsCA.Tables("CA_NOTE_ATTACHMENT").ImportRow(rownote_child)

                                    Ext = Nothing
                                    dtRowAtt = IIf(IsDBNull(rownote_child("Attachment")), Nothing, rownote_child("Attachment"))
                                    Ext = IIf(IsDBNull(rownote_child("Extension")), Nothing, rownote_child("Extension"))

                                    If dtRowAtt IsNot Nothing Then
                                        Dim frmnote As New frmNote_AttachmentView
                                        Select Case Ext.ToLower
                                            Case ".jpg", ".png", ".jpeg", ".bitmap", ".ico", ".gif", ".tif"
                                                frmnote.Type = 0
                                            Case ".xls", ".xlsx", ".csv", ".openxml"
                                                frmnote.Type = 1
                                            Case ".doc", "docx", ".rtf", ".wordml", ".opendocument"
                                                frmnote.Type = 2
                                            Case ".pdf"
                                                frmnote.Type = 3
                                        End Select
                                        frmnote.Title = dsCA.Tables("CA_NOTE").Rows(i)("Title")
                                        frmnote.Extension = Ext
                                        frmnote.dataArr = dtRowAtt
                                        frmnote.Show()
                                    End If
                                Next
                            End If
                        Next

                    End If

                End If
            Next

            rpt.DataSource = dsCA
            rpt.XrSubreport1.ReportSource.DataSource = dsCA
            rpt.FontSize.Value = 9
            rpt.paramSch.Value = SchApex

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
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function PrintReport_MovementComplex(dsMovement As DataSet, ID As Integer, RefNo As String, ByRef rpt As rptMovementComplex, _
                                                ByRef ErrorLog As clsError, Optional ByVal SchApex As String = "") As Boolean
        Try
            Dim clsMovement_Note As New clsNote_Movement

            Dim dt As DataTable = Nothing
            Dim dtChild As DataTable = Nothing
            Dim dtNote As DataTable = Nothing
            Dim dtNoteChild As DataTable = Nothing
            Dim Ext As String = Nothing
            Dim dtRowAtt As Byte() = Nothing

            dt = ADO.Load_MovementComplex(ID, ErrorLog)


            dsMovement.Tables("MOVEMENT_NOTE_ATTACHMENT").Rows.Clear()
            dsMovement.Tables("MOVEMENT_NOTE_COLUMN").Rows.Clear()
            dsMovement.Tables("MOVEMENT_NOTE").Rows.Clear()

            dsMovement.Tables("MOVEMENT_COMPLEX_ADD").Rows.Clear()
            dsMovement.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows.Clear()
            dsMovement.Tables("MOVEMENT_COMPLEX").Rows.Clear()

            If dt Is Nothing Then
                MsgBox("Data not found.", MsgBoxStyle.Critical)
                Return False
            End If

            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("MM_TITLE") = "Movements in " & IIf(IsDBNull(dt.Rows(i)("MM_TITLE")), "", dt.Rows(i)("MM_TITLE")) & " for the " & IIf(IsDBNull(dt.Rows(i)("MM_TYPE")), "Year Ended", dt.Rows(i)("MM_TYPE")) & " " & Format(IIf(IsDBNull(dt.Rows(i)("MM_YEAR_ENDED")), Now, dt.Rows(i)("MM_YEAR_ENDED")), "dd.MM.yyyy")
                Application.DoEvents()
                dsMovement.Tables("MOVEMENT_COMPLEX").ImportRow(dt.Rows(i))
            Next

            dt = ADO.Load_MovementComplex_Add(ID, ErrorLog)

            If dt IsNot Nothing Then
                For i As Integer = 0 To dt.Rows.Count - 1

                    If IsDBNull(dt.Rows(i)("TagID")) = False Then
                        dtNote = Nothing
                        dtNote = clsMovement_Note.Load_Note(dt.Rows(i)("TagID"), ID, 1, 0, ErrorLog)

                        If dtNote IsNot Nothing Then
                            dt.Rows(i)("MM_NOTE") = IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                            dsMovement.Tables("MOVEMENT_NOTE").ImportRow(dtNote.Rows(0))
                        End If

                        dsMovement.Tables("MOVEMENT_COMPLEX_ADD").ImportRow(dt.Rows(i))


                        Application.DoEvents()
                        If dtNote IsNot Nothing Then

                            '                            DsMovement.Tables("MOVEMENT_NOTE").ImportRow(dtNote.Rows(0))

                            dtNoteChild = Nothing
                            dtNoteChild = clsMovement_Note.Load_Note_Attachment(dtNote.Rows(0)("ID"), ErrorLog)
                            If dtNoteChild IsNot Nothing Then
                                For Each rowx As DataRow In dtNoteChild.Rows
                                    rowx("ParentID") = dtNote.Rows(0)("ID")
                                    dsMovement.Tables("MOVEMENT_NOTE_ATTACHMENT").ImportRow(rowx)

                                    Ext = Nothing
                                    dtRowAtt = IIf(IsDBNull(rowx("Attachment")), Nothing, rowx("Attachment"))
                                    Ext = IIf(IsDBNull(rowx("Extension")), Nothing, rowx("Extension"))

                                    If dtRowAtt IsNot Nothing Then
                                        Dim frmnote As New frmNote_AttachmentView
                                        Select Case Ext.ToLower
                                            Case ".jpg", ".png", ".jpeg", ".bitmap", ".ico", ".gif", ".tif"
                                                frmnote.Type = 0
                                            Case ".xls", ".xlsx", ".csv", ".openxml"
                                                frmnote.Type = 1
                                            Case ".doc", "docx", ".rtf", ".wordml", ".opendocument"
                                                frmnote.Type = 2
                                            Case ".pdf"
                                                frmnote.Type = 3
                                        End Select
                                        frmnote.Title = dt.Rows(i)("MM_NOTE")
                                        frmnote.Extension = Ext
                                        frmnote.dataArr = dtRowAtt
                                        frmnote.Show()
                                    End If
                                Next
                            End If

                            dtNoteChild = Nothing
                            dtNoteChild = clsMovement_Note.Load_Note_Column(dtNote.Rows(0)("ID"), ErrorLog)
                            If dtNoteChild IsNot Nothing Then
                                For Each rowx As DataRow In dtNoteChild.Rows
                                    rowx("ParentID") = dtNote.Rows(0)("ID")
                                    dsMovement.Tables("MOVEMENT_NOTE_COLUMN").ImportRow(rowx)
                                Next
                            End If

                        End If
                    End If

                Next
            End If
            Application.DoEvents()
            dt = ADO.Load_MovementComplex_Deduct(ID, ErrorLog)

            If dt IsNot Nothing Then
                For i As Integer = 0 To dt.Rows.Count - 1

                    If IsDBNull(dt.Rows(i)("TagID")) = False Then
                        dtNote = Nothing
                        dtNote = clsMovement_Note.Load_Note(dt.Rows(i)("TagID"), ID, 1, 1, ErrorLog)

                        If dtNote IsNot Nothing Then
                            dt.Rows(i)("MM_NOTE") = IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                            dsMovement.Tables("MOVEMENT_NOTE").ImportRow(dtNote.Rows(0))
                        End If

                        dsMovement.Tables("MOVEMENT_COMPLEX_DEDUCT").ImportRow(dt.Rows(i))

                        Application.DoEvents()
                        If dtNote IsNot Nothing Then

                            dtNoteChild = Nothing
                            dtNoteChild = clsMovement_Note.Load_Note_Attachment(dtNote.Rows(0)("ID"), ErrorLog)
                            If dtNoteChild IsNot Nothing Then
                                For Each rowx As DataRow In dtNoteChild.Rows
                                    rowx("ParentID") = dtNote.Rows(0)("ID")
                                    dsMovement.Tables("MOVEMENT_NOTE_ATTACHMENT").ImportRow(rowx)

                                    Ext = Nothing
                                    dtRowAtt = IIf(IsDBNull(rowx("Attachment")), Nothing, rowx("Attachment"))
                                    Ext = IIf(IsDBNull(rowx("Extension")), Nothing, rowx("Extension"))

                                    If dtRowAtt IsNot Nothing Then
                                        Dim frmnote As New frmNote_AttachmentView
                                        Select Case Ext.ToLower
                                            Case ".jpg", ".png", ".jpeg", ".bitmap", ".ico", ".gif", ".tif"
                                                frmnote.Type = 0
                                            Case ".xls", ".xlsx", ".csv", ".openxml"
                                                frmnote.Type = 1
                                            Case ".doc", "docx", ".rtf", ".wordml", ".opendocument"
                                                frmnote.Type = 2
                                            Case ".pdf"
                                                frmnote.Type = 3
                                        End Select
                                        frmnote.Title = dt.Rows(i)("MM_NOTE")
                                        frmnote.Extension = Ext
                                        frmnote.dataArr = dtRowAtt
                                        frmnote.Show()
                                    End If
                                Next
                            End If

                            dtNoteChild = Nothing
                            dtNoteChild = clsMovement_Note.Load_Note_Column(dtNote.Rows(0)("ID"), ErrorLog)
                            If dtNoteChild IsNot Nothing Then
                                For Each rowx As DataRow In dtNoteChild.Rows
                                    rowx("ParentID") = dtNote.Rows(0)("ID")
                                    dsMovement.Tables("MOVEMENT_NOTE_COLUMN").ImportRow(rowx)
                                Next
                            End If

                        End If
                    End If

                Next
            End If

            If rpt Is Nothing Then
                rpt = New rptMovementComplex
            End If
            rpt.paramCompanyName.Value = ADO.LoadTaxPayer_CompanyName(RefNo)
            rpt.paramParentID.Value = ID
            rpt.ParamSch.Value = SchApex
            rpt.DataSource = dsMovement.Tables("MOVEMENT_COMPLEX")
            rpt.XrSubreport1.ReportSource.DataSource = dsMovement.Tables("MOVEMENT_NOTE")

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
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function PrintReport_MovementNormal(dsMovement As DataSet, ID As Integer, ByVal RefNo As String, ByRef rpt As rptMovementNormal, _
                                               ByRef ErrorLog As clsError, Optional ByVal SchApex As String = "") As Boolean
        Try
            Dim clsMovement_Note As New clsNote_Movement


            Dim dt As DataTable = Nothing
            Dim dtChild As DataTable = Nothing
            Dim dtNote As DataTable = Nothing
            Dim dtNoteChild As DataTable = Nothing
            Dim Ext As String = Nothing
            Dim dtRowAtt As Byte() = Nothing


            dt = clsMoveNormal.Load_MovementNormal(ID, ErrorLog)

            dsMovement.Tables("MOVEMENT_NOTE_ATTACHMENT").Rows.Clear()
            dsMovement.Tables("MOVEMENT_NOTE_COLUMN").Rows.Clear()
            dsMovement.Tables("MOVEMENT_NOTE").Rows.Clear()

            dsMovement.Tables("MOVEMENT_ADD").Rows.Clear()
            dsMovement.Tables("MOVEMENT_DEDUCT").Rows.Clear()
            dsMovement.Tables("MOVEMENT_NORMAL").Rows.Clear()


            If dt Is Nothing Then
                MsgBox("Data not found.", MsgBoxStyle.Critical)
                Exit Function
            End If

            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("MM_TITLE") = "Movements in " & IIf(IsDBNull(dt.Rows(i)("MM_TITLE")), "", dt.Rows(i)("MM_TITLE")) & " for the " & IIf(IsDBNull(dt.Rows(i)("MM_TYPE")), "Year Ended", dt.Rows(i)("MM_TYPE")) & " " & Format(IIf(IsDBNull(dt.Rows(i)("MM_YEAR_ENDED")), Now, dt.Rows(i)("MM_YEAR_ENDED")), "dd.MM.yyyy")
                Application.DoEvents()
                dsMovement.Tables("MOVEMENT_NORMAL").ImportRow(dt.Rows(i))
            Next

            dt = clsMoveNormal.Load_MovementNormal_Add(ID, ErrorLog)

            If dt IsNot Nothing Then
                For i As Integer = 0 To dt.Rows.Count - 1

                    If IsDBNull(dt.Rows(i)("TagID")) = False Then

                        dtNote = Nothing
                        dtNote = clsMovement_Note.Load_Note(dt.Rows(i)("TagID"), ID, 0, 0, ErrorLog)

                        If dtNote IsNot Nothing Then
                            dt.Rows(i)("Note") = IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                            dsMovement.Tables("MOVEMENT_ADD").ImportRow(dt.Rows(i))
                        End If

                        Application.DoEvents()
                        If dtNote IsNot Nothing Then

                            dsMovement.Tables("MOVEMENT_NOTE").ImportRow(dtNote.Rows(0))

                            dtNoteChild = Nothing
                            dtNoteChild = clsMovement_Note.Load_Note_Attachment(dtNote.Rows(0)("ID"), ErrorLog)
                            If dtNoteChild IsNot Nothing Then
                                For Each rowx As DataRow In dtNoteChild.Rows
                                    rowx("ParentID") = dt.Rows(i)("ID")
                                    dsMovement.Tables("MOVEMENT_NOTE_ATTACHMENT").ImportRow(rowx)


                                    Ext = Nothing
                                    dtRowAtt = IIf(IsDBNull(rowx("Attachment")), Nothing, rowx("Attachment"))
                                    Ext = IIf(IsDBNull(rowx("Extension")), Nothing, rowx("Extension"))

                                    If dtRowAtt IsNot Nothing Then
                                        Dim frmnote As New frmNote_AttachmentView
                                        Select Case Ext.ToLower
                                            Case ".jpg", ".png", ".jpeg", ".bitmap", ".ico", ".gif", ".tif"
                                                frmnote.Type = 0
                                            Case ".xls", ".xlsx", ".csv", ".openxml"
                                                frmnote.Type = 1
                                            Case ".doc", "docx", ".rtf", ".wordml", ".opendocument"
                                                frmnote.Type = 2
                                            Case ".pdf"
                                                frmnote.Type = 3
                                        End Select
                                        frmnote.Title = dt.Rows(i)("Note")
                                        frmnote.Extension = Ext
                                        frmnote.dataArr = dtRowAtt
                                        frmnote.Show()
                                    End If
                                Next
                            End If

                            dtNoteChild = Nothing
                            dtNoteChild = clsMovement_Note.Load_Note_Column(dtNote.Rows(0)("ID"), ErrorLog)
                            If dtNoteChild IsNot Nothing Then
                                For Each rowx As DataRow In dtNoteChild.Rows
                                    rowx("ParentID") = dt.Rows(i)("ID")
                                    dsMovement.Tables("MOVEMENT_NOTE_COLUMN").ImportRow(rowx)
                                Next
                            End If

                        End If

                    End If

                Next
            End If
            Application.DoEvents()
            dt = clsMoveNormal.Load_MovementNormal_Deduct(ID, ErrorLog)

            If dt IsNot Nothing Then
                For i As Integer = 0 To dt.Rows.Count - 1

                    If IsDBNull(dt.Rows(i)("TagID")) = False Then
                        dtNote = Nothing
                        dtNote = clsMovement_Note.Load_Note(dt.Rows(i)("TagID"), ID, 0, 1, ErrorLog)

                        If dtNote IsNot Nothing Then
                            dt.Rows(i)("Note") = IIf(IsDBNull(dtNote.Rows(0)("Title")), "", dtNote.Rows(0)("Title"))
                            dsMovement.Tables("MOVEMENT_NOTE").ImportRow(dtNote.Rows(0))
                        End If

                        dsMovement.Tables("MOVEMENT_DEDUCT").ImportRow(dt.Rows(i))
                        Application.DoEvents()
                        If dtNote IsNot Nothing Then

                            dtNoteChild = Nothing
                            dtNoteChild = clsMovement_Note.Load_Note_Attachment(dtNote.Rows(0)("ID"), ErrorLog)
                            If dtNoteChild IsNot Nothing Then
                                For Each rowx As DataRow In dtNoteChild.Rows
                                    rowx("ParentID") = dtNote.Rows(0)("ID")
                                    dsMovement.Tables("MOVEMENT_NOTE_ATTACHMENT").ImportRow(rowx)


                                    Ext = Nothing
                                    dtRowAtt = IIf(IsDBNull(rowx("Attachment")), Nothing, rowx("Attachment"))
                                    Ext = IIf(IsDBNull(rowx("Extension")), Nothing, rowx("Extension"))

                                    If dtRowAtt IsNot Nothing Then
                                        Dim frmnote As New frmNote_AttachmentView
                                        Select Case Ext.ToLower
                                            Case ".jpg", ".png", ".jpeg", ".bitmap", ".ico", ".gif", ".tif"
                                                frmnote.Type = 0
                                            Case ".xls", ".xlsx", ".csv", ".openxml"
                                                frmnote.Type = 1
                                            Case ".doc", "docx", ".rtf", ".wordml", ".opendocument"
                                                frmnote.Type = 2
                                            Case ".pdf"
                                                frmnote.Type = 3
                                        End Select
                                        frmnote.Title = dt.Rows(i)("Note")
                                        frmnote.Extension = Ext
                                        frmnote.dataArr = dtRowAtt
                                        frmnote.Show()
                                    End If
                                Next
                            End If

                            dtNoteChild = Nothing
                            dtNoteChild = clsMovement_Note.Load_Note_Column(dtNote.Rows(0)("ID"), ErrorLog)
                            If dtNoteChild IsNot Nothing Then
                                For Each rowx As DataRow In dtNoteChild.Rows
                                    rowx("ParentID") = dtNote.Rows(0)("ID")
                                    dsMovement.Tables("MOVEMENT_NOTE_COLUMN").ImportRow(rowx)
                                Next
                            End If

                        End If
                    End If

                Next
            End If

            If rpt Is Nothing Then
                rpt = New rptMovementNormal
            End If

            rpt.paramCompanyName.Value = ADO.LoadTaxPayer_CompanyName(RefNo)
            rpt.paramParentID.Value = ID
            rpt.paramSch.Value = SchApex
            rpt.DataSource = dsMovement.Tables("MOVEMENT_NORMAL")
            rpt.XrSubreport1.ReportSource.DataSource = dsMovement.Tables("MOVEMENT_NOTE")

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
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function PrintReport_PNL(RefNo As String, YA As String, ByRef rpt As rptPNL, _
                                   ByRef rpt_details As rptPNL_Details, ByRef rpt_interest As rptPNL_InterestResict _
                                   , ByRef ErrorLog As clsError, Optional ByVal SchApex As String = "") As Boolean
        Try

            If RefNo Is Nothing OrElse YA Is Nothing OrElse IsNumeric(YA) = False Then
                Return False
            End If

            If rpt Is Nothing Then
                rpt = New rptPNL
            End If

            rpt.paramCompanyName.Value = ADO.LoadTaxPayer_CompanyName(RefNo)
            rpt.paramYA.Value = CInt(YA)
            rpt.ParamSch.Value = SchApex


            If mdlPNL2.PNL_Report(RefNo, YA, rpt.DsPNL1, ErrorLog) Then
                If rpt_details Is Nothing Then
                    rpt_details = New rptPNL_Details
                End If
                rpt_details.paramCompanyName.Value = ADO.LoadTaxPayer_CompanyName(RefNo)
                rpt_details.paramYA.Value = CInt(YA)
                rpt_details.DataSource = rpt.DsPNL1


                rpt_details.rptSubNote_PLST_SALES.ReportSource.DataSource = rpt.DsPNL1

                rpt.XrSubreport1.ReportSource = rpt_details

                rpt.CreateDocument()
                Application.DoEvents()

                If rpt_interest Is Nothing Then
                    rpt_interest = New rptPNL_InterestResict
                End If
                rpt_interest.paramCompanyName.Value = ADO.LoadTaxPayer_CompanyName(RefNo)
                rpt_interest.paramYA.Value = CInt(YA)
                rpt_interest.DataSource = rpt.DsPNL1
                rpt_interest.CreateDocument()
                Application.DoEvents()

                Return True
            Else
                rpt = Nothing
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
