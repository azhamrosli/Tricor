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
    Public V3 As Integer = 0
    Public V4 As Integer = 0
    Public R1 As Integer = 0
    Public ArgParam0 As String = "frmpnl" 'Form Name
    Public ArgParam1 As String = "TAXCOM_C" 'Database Name
    Public ArgParam2 As String = "0785632400" 'RefNo
    Public ArgParam3 As String = "2016" 'YA
    Public Const isVersionLicenseType As VersionLicenseType = VersionLicenseType.Normal

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
    Public Function DBConnection_OFFICE(ByRef sqlCon As SqlConnection, ByRef ErrorMsg As clsError) As Boolean
        Try

            Dim strCon As String = DBSetting()

            If strCon Is Nothing OrElse strCon = "" Then
                mdlProcess.CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, "4060", "Connection string is empty.", ErrorMsg)
                Return False
            End If

            Dim Con As New SqlConnection(strCon)
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            sqlCon = Con
            Return True
        Catch ex As Exception
            mdlProcess.CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.GetHashCode.ToString, ex.Message, ErrorMsg)
            Return False
        End Try
    End Function
    Public Function DBConnection(ByRef sqlCon As SqlConnection, ByRef ErrorMsg As clsError) As Boolean
        Try

            Dim strCon As String = DBSetting(1, ArgParam1)

            If strCon Is Nothing OrElse strCon = "" Then
                mdlProcess.CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, "4060", "Connection string is empty.", ErrorMsg)
                Return False
            End If

            Dim Con As New SqlConnection(strCon)
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            sqlCon = Con
            Return True
        Catch ex As Exception
            mdlProcess.CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.GetHashCode.ToString, ex.Message, ErrorMsg)
            Return False
        End Try
    End Function
    Public Function DBConnection_CA(ByRef sqlCon As SqlConnection, ByRef ErrorMsg As clsError) As Boolean
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
                mdlProcess.CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, "4060", "Connection string is empty.", ErrorMsg)
                Return False
            End If

            Dim Con As New SqlConnection(strCon)
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            sqlCon = Con
            Return True
        Catch ex As Exception
            mdlProcess.CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.GetHashCode.ToString, ex.Message, ErrorMsg)
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return True
        End Try
    End Function

    Public Function CreateLookUpSourceNO(ByRef dsSourceNo As DataSet, ByVal RefNo As String, ByVal YA As Integer, _
                                        Optional ByVal TableName As String = "BUSINESS_SOURCE", Optional Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = mdlProcess.LoadBusinessSource_ByRefNo(RefNo, CStr(YA), Errorlog)

            If dt IsNot Nothing Then
                Dim dtrow As DataRow
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

            Return False
        End Try
    End Function
    Public Function CreateLookUpYA(ByRef cboYA As DevExpress.XtraEditors.ComboBoxEdit, Optional Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = mdlProcess.LoadYA(Errorlog)

            cboYA.Properties.Items.Clear()
            If dt Is Nothing Then
                Return False
            End If

            For i As Integer = 0 To dt.Rows.Count - 1
                cboYA.Properties.Items.Add(CInt(IIf(IsDBNull(dt.Rows(i)("YA")), "0", dt.Rows(i)("YA"))).ToString)
            Next

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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

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
                DataSet.Tables("TaxPayerFind").Rows.Add(dtRow)
            Next

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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
            If ErrorLog IsNot Nothing Then
                With ErrorLog
                    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                    .ErrorCode = ex.GetHashCode.ToString
                    .ErrorDateTime = Now
                    .ErrorMessage = ex.Message
                End With
            End If

            Return False
        End Try
    End Function

#End Region
#Region "LOAD"
#Region "CA"
    Public Function Load_Data(Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM lx"
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
    Public Function LOAD_GetDTYA(ByVal TC_REF_NO As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
            End Select
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
            SQLcmd.Parameters.Add("@HP_CODE", SqlDbType.NVarChar, 255).Value = HP_CODE

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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return Nothing
        End Try
    End Function
    Public Function Load_DISPOSAL_BY_CADISP_KEY(ByVal CA_DISP_KEY As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA_DISPOSAL WHERE CA_DISP_KEY=@CA_DISP_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@CA_DISP_KEY", SqlDbType.Int).Value = CA_DISP_KEY

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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return Nothing
        End Try
    End Function
#End Region
#Region "PNL"
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return Nothing
        End Try
    End Function
#End Region
#Region "OTHER"
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                                  ByVal CA_TRANSFEREE_NAME As String, ByVal CA_TAX_FILE_NO As String, _
                                  ByRef ReturnID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "INSERT INTO CA_DISPOSAL (CA_KEY,CA_DISP_KEY,CA_DISP_YA,CA_DISP_DATE,CA_DISP_WITHIN_2,CA_DISP_AMOUNT,CA_DISP_QC,CA_DISP_BALANCE,CA_DISP_TWDV,CA_DISP_SPROCEED,CA_DISP_BABC,CA_DISP_REMARKS,CA_ACCUMULATED,CA_TRANSFEREE_NAME,CA_TAX_FILE_NO) VALUES (@CA_KEY,@CA_DISP_KEY,@CA_DISP_YA,@CA_DISP_DATE,@CA_DISP_WITHIN_2,@CA_DISP_AMOUNT,@CA_DISP_QC,@CA_DISP_BALANCE,@CA_DISP_TWDV,@CA_DISP_SPROCEED,@CA_DISP_BABC,@CA_DISP_REMARKS,@CA_ACCUMULATED,@CA_TRANSFEREE_NAME,@CA_TAX_FILE_NO)"

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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return False
        End Try
    End Function
#End Region
#Region "PNL"
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
                StrSQL = "INSERT INTO EXPENSES_ALLOW(EXA_KEY,EXA_EXAKEY,EXA_SOURCENO,EXA_DESC,EXA_AMOUNT,EXA_DEDUCTIBLE,EXA_NOTE,EXA_DETAIL) VALUES (@EXA_KEY,@EXA_EXAKEY,@EXA_SOURCENO,@EXA_DESC,@EXA_AMOUNT,@EXA_DEDUCTIBLE,@EXA_NOTE,@EXA_DETAIL)"
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
                    StrSQL = "INSERT INTO EXPENSES_ALLOW_DETAIL(EXAD_KEY,EXAD_EXAKEY,EXAD_SOURCENO,EXAD_EXADKEY,EXAD_DESC,EXAD_AMOUNT,EXAD_DEDUCTIBLE,EXAD_NOTE) VALUES (@EXAD_KEY,@EXAD_EXAKEY,@EXAD_SOURCENO,@EXAD_EXADKEY,@EXAD_DESC,@EXAD_AMOUNT,@EXAD_DEDUCTIBLE,@EXAD_NOTE)"

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
#End Region
#Region "OTHER"
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
            SQLcmd.Parameters.Add("@HP_CODE", SqlDbType.NVarChar, 255).Value = HP_CODE
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return False
        End Try
    End Function
    Public Function Update_Disposal(ByVal CA_DISP_KEY As Integer, ByVal CA_KEY As Integer, ByVal CA_DISP_YA As Integer, _
                                  ByVal CA_DISP_DATE As DateTime, ByVal CA_DISP_WITHIN_2 As Boolean, _
                                  ByVal CA_DISP_AMOUNT As Decimal, ByVal CA_DISP_QC As Decimal, ByVal CA_DISP_BALANCE As Decimal, _
                                  ByVal CA_DISP_TWDV As Decimal, ByVal CA_DISP_SPROCEED As Decimal, _
                                  ByVal CA_DISP_BABC As Decimal, ByVal CA_DISP_REMARKS As String, ByVal CA_ACCUMULATED As Decimal, _
                                  ByVal CA_TRANSFEREE_NAME As String, ByVal CA_TAX_FILE_NO As String, _
                                  ByRef ReturnID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            ADO = New SQLDataObject()
            Dim SqlCon As SqlConnection

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "UPDATE CA_DISPOSAL SET CA_KEY=@CA_KEY,CA_DISP_KEY=@CA_DISP_KEY,CA_DISP_YA=@CA_DISP_YA,CA_DISP_DATE=@CA_DISP_DATE,CA_DISP_WITHIN_2=@CA_DISP_WITHIN_2,CA_DISP_AMOUNT=@CA_DISP_AMOUNT,CA_DISP_QC=@CA_DISP_QC,CA_DISP_BALANCE=@CA_DISP_BALANCE,CA_DISP_TWDV=@CA_DISP_TWDV,CA_DISP_SPROCEED=@CA_DISP_SPROCEED,CA_DISP_BABC=@CA_DISP_BABC,CA_DISP_REMARKS=@CA_DISP_REMARKS,CA_ACCUMULATED=@CA_ACCUMULATED,CA_TRANSFEREE_NAME=@CA_TRANSFEREE_NAME,CA_TAX_FILE_NO=@CA_TAX_FILE_NO WHERE CA_DISP_KEY=@CA_DISP_KEY"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@CA_DISP_KEY", SqlDbType.Int).Value = CA_DISP_KEY
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return False
        End Try
    End Function
#End Region
#Region "PNL"

#End Region
#Region "OTHER"

#End Region

#End Region
#Region "DELETE"
#Region "CA"

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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return False
        End Try
    End Function
#End Region
#Region "PNL"

#End Region
#Region "OTHER"
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
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
