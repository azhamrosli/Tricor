Imports System.Data.SqlClient
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Export
Imports DevExpress.XtraGrid
Imports System.Data.OleDb

Public Class frmPNL_B_Add
    Public isEdit As Boolean = True
    Public ID As Decimal = 1269
    Dim ErrorLog As clsError = Nothing
    Dim isReplacePNL As Boolean = False
    Dim ListofCmd As List(Of SqlCommand)

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        If dsDataSet Is Nothing Then
            dsDataSet = New dsPNL
        End If


        txtPCName.Caption = My.Computer.Name & " | " & GetServerName() & " | V" & mdlProcess.V1 & "." & mdlProcess.V2 & "." & mdlProcess.V3 & "." & mdlProcess.V4 & " R." & System.Reflection.Assembly.GetExecutingAssembly.GetName.Version.Revision.ToString
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmPNL_Details_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Try
            If e.KeyCode = Keys.F1 Then
                XtraTabControl1.SelectedTabPageIndex = 0
            ElseIf e.KeyCode = Keys.F2 Then
                XtraTabControl1.SelectedTabPageIndex = 1
            ElseIf e.KeyCode = Keys.F3 Then
                XtraTabControl1.SelectedTabPageIndex = 2
            ElseIf e.KeyCode = Keys.F4 Then
                XtraTabControl1.SelectedTabPageIndex = 3
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmPNL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            If mdlProcess.CreateLookUpTaxPayer(DsCA, ErrorLog) = False Then
                MsgBox("Failed to load tax payer." & vbCrLf & ErrorLog.ErrorName & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                Me.Close()
            End If
            Application.DoEvents()
            If mdlProcess.CreateLookUpYA(cboYA, ErrorLog) = False Then
                MsgBox("Failed to load ya." & vbCrLf & ErrorLog.ErrorName & vbCrLf & ErrorLog.ErrorMessage, MsgBoxStyle.Critical)
                Me.Close()
            End If
            Application.DoEvents()


        Catch ex As Exception

        End Try

    End Sub
    

End Class