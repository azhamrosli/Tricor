Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Text
Imports System.Net.NetworkInformation
Imports System.IO
Imports Microsoft.Win32
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository

Module mdlProcess
    Public ADO As clsIODatabase
    Public clsMoveNormal As clsMovementNormal

    'Dim ADO As SQLDataObject
    Public LicenseType As Integer = 0
    Public V1 As Integer = My.Application.Info.Version.Major
    Public V2 As Integer = My.Application.Info.Version.Minor
    Public V3 As Integer = My.Application.Info.Version.Build
    Public V4 As Integer = My.Application.Info.Version.Revision
    Public R1 As String = "Change To New Code OOP make a class move all from mdlProcess to clsIODatabase"

    Public ArgParam0 As String = "frmpnl" 'Form Name
    Public ArgParam1 As String = "TAXCOM_C" 'Database Name
    Public ArgParam2 As String = "0388601701" '"1054242304" 'RefNo
    Public ArgParam3 As String = "2016" 'YA"
    Public Const isVersionLicenseType As VersionLicenseType = VersionLicenseType.Tricor
    Public ListofClsError As List(Of clsError) = Nothing
    Public dsDataSetErrorlog As DataSet

    Dim MaxYearForCA As Integer = 50

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
#Region "DATABASE"
   
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
