Imports Microsoft.Win32
Imports System.IO
Imports System.Net.NetworkInformation
Imports DevExpress.XtraEditors.Repository
Imports System.Data.SqlClient
Imports System.Text
Imports DevExpress.XtraGrid.Views.Grid


Module mdlProcess
    Public ADO As clsIODatabase

    Public clsPNL_ As clsPNL

    Public LicenseType As Integer = 0
    Public V1 As Integer = My.Application.Info.Version.Major
    Public V2 As Integer = My.Application.Info.Version.Minor
    Public V3 As Integer = My.Application.Info.Version.Build
    Public V4 As Integer = My.Application.Info.Version.Revision

    Public ArgParam0 As String = "frmpnl_b_add" 'Form Name
    Public ArgParam1 As String = "TAXCOM_B" 'Database Name
    Public ArgParam2 As String = "01333648070" '"1054242304" 'RefNo
    Public ArgParam3 As String = "2007" 'YA"

    Public Setting_DecimalPlace_PNL As Integer = 0
    Public Setting_AllowAllGroupExpand As Boolean = False


    Public ListofClsError As List(Of clsError) = Nothing
    Public dsDataSetErrorlog As DataSet

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
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

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
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
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
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            ' MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return Nothing
        End Try
    End Function
#End Region
#Region "GENERAL"
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
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
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
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
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
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
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
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
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
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
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
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
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
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
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
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
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
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            Return ""
        End Try
    End Function
    Public Function Base64ToStringConvert(ByVal data As String) As String
        Try
            Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(data)
            Return System.Convert.ToBase64String(byt)
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            Return ""
        End Try
    End Function
    Public Function Base64ToByteConvert(ByVal data As String) As String
        Try
            Dim byt() As Byte = System.Convert.FromBase64String(data)
            Return System.Text.ASCIIEncoding.ASCII.GetString(byt)
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
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
    Public Function GetDecimalPlace(ByVal Index As Integer) As String
        Try
            Select Case Index
                Case 0
                    Return "N0"
                Case 1
                    Return "N1"
                Case 2
                    Return "N2"
                Case 3
                    Return "N3"

                Case Else
                    Return "N0"
            End Select
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            Return "N2"
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
