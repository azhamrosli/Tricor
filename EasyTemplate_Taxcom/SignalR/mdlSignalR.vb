Imports Microsoft.AspNet.SignalR.Client

Module mdlSignalR
    '  Public connection As HubConnection = New HubConnection("http://www.arsoftwaremalaysia.com/signalr")
    Public connection As HubConnection = New HubConnection("http://tax2016.yglmmr.com/signalr")
    Public myHub As IHubProxy = connection.CreateHubProxy("hitCounter")

    Async Sub startConnect()
        Try

            Await connection.Start()
            Await myHub.Invoke("OnConnectedChat", My.Computer.Name & "_Taxcom")
            '   Await myHub.Invoke("send", My.Computer.Name, "Hello")
        Catch ex As Exception
            MsgBox("Failed to start service signal R" & vbCrLf & ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

    End Sub
    Async Sub chatConnect()
        Try
            If connection.State = System.Data.ConnectionState.Connecting Or connection.State = ConnectionState.Disconnected Then
                Await connection.Start()
            End If

            Await myHub.Invoke("OnConnectedChat", My.Computer.Name)
        Catch ex As Exception
            MsgBox("Failed start chat service" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    Async Sub disConnect()
        Try
            Await myHub.Invoke("OnDisconnected", True)
            connection.Stop()
        Catch ex As Exception
            MsgBox("Failed stop chat service" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    Async Sub SendNotification(ByVal ComName As String)
        Try
            Await myHub.Invoke("sendnotification", My.Computer.Name, ComName)

        Catch ex As Exception

        End Try
    End Sub
    Async Sub SendMessage(ByVal ComName As String)
        Try
            Await myHub.Invoke("Send", My.Computer.Name, ComName)
        Catch ex As Exception

        End Try
    End Sub
End Module
