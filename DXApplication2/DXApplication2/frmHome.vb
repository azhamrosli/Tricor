Public Class frmHome 

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        If ADO Is Nothing Then
            ADO = New clsIODatabase
        End If
    End Sub
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub frmCA_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
               e.Cancel = True
            frmStartup.Close()
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Sub
End Class