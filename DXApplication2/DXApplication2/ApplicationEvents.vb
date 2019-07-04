Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            Try
                If e.CommandLine(0) IsNot Nothing AndAlso e.CommandLine(0) <> "" Then

                    Dim tmpSplit As String() = e.CommandLine(0).ToString.Split(",")

                    If tmpSplit.Length > 0 Then
                        For i As Integer = 0 To tmpSplit.Length - 1
                            Select Case i
                                Case 0
                                    mdlProcess.ArgParam0 = tmpSplit(0) ' Form name
                                Case 1
                                    mdlProcess.ArgParam1 = tmpSplit(1) ' Database name
                                Case 2
                                    mdlProcess.ArgParam2 = tmpSplit(2) ' Refno
                                Case 3
                                    mdlProcess.ArgParam3 = tmpSplit(3) ' YA
                            End Select
                        Next


                    End If
                End If


            Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

            End Try
        End Sub
    End Class


End Namespace

