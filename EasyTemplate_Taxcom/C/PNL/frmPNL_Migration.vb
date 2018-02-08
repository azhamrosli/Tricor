Imports System.Data.SqlClient

Public Class frmPNL_Migration
    Dim ErrorLog As clsError = Nothing
    Private Sub frmPNL_Migration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Timer1.Enabled = True
            Timer1.Start()

        Catch ex As Exception

        End Try
    End Sub

    Public Function LoadData(Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try

            Dim dtListofable As DataTable = ADO.Load_PNL_GETTableList(Errorlog)
            Dim dtListofPNL As DataTable = ADO.LoadPNL_Search("", "", Errorlog)
            Dim dtData As DataTable = Nothing
            Dim dtDataDetails As DataTable = Nothing

            Dim SQLcmd As SqlCommand
            Dim TableName As String = Nothing
            Dim TableNameDetails As String = Nothing
            Dim ColumnName As String = Nothing
            Dim ColumnNameDetails As String = Nothing
            Dim Total As Decimal = 0
            If dtListofPNL IsNot Nothing AndAlso dtListofable IsNot Nothing Then

                For Each rowTable As DataRow In dtListofable.Rows

                    TableName = IIf(IsDBNull(rowTable("TableName")), "", rowTable("TableName"))
                    ColumnName = IIf(IsDBNull(rowTable("ColumnTable")), "", rowTable("ColumnTable"))

                    If TableName <> "" Then
                        SQLcmd = Nothing
                        SQLcmd = New SqlCommand
                        SQLcmd.CommandText = "SELECT * FROM " & TableName

                        dtData = ADO.Load_SQLCmd(SQLcmd, Errorlog)

                        If dtData IsNot Nothing Then

                            For Each rowData As DataRow In dtData.Rows

                                TableNameDetails = IIf(IsDBNull(rowTable("TableName_Details")), "", rowTable("TableName_Details"))
                                ColumnNameDetails = IIf(IsDBNull(rowTable("ColumnTable_Details")), "", rowTable("ColumnTable_Details"))

                                If TableNameDetails <> "" Then
                                    SQLcmd = Nothing
                                    SQLcmd = New SqlCommand
                                    SQLcmd.CommandText = "SELECT * FROM " & TableNameDetails & "WHERE " & ColumnNameDetails & "=" & IIf(IsDBNull(dtData(ColumnName)), 0, dtData(ColumnName))

                                    dtDataDetails = ADO.Load_SQLCmd(SQLcmd, Errorlog)

                                    If dtDataDetails IsNot Nothing Then

                                        For Each rowDataDetails As DataRow In dtDataDetails.Rows

                                            If IIf(IsDBNull(dtData(ColumnName)), 0, dtData(ColumnName)) = IIf(IsDBNull(rowDataDetails(ColumnNameDetails)), 0, rowDataDetails(ColumnNameDetails)) Then

                                                Total += IIf(IsDBNull(rowDataDetails(ColumnNameDetails)), 0, rowDataDetails(ColumnNameDetails))

                                            End If

                                        Next

                                    End If
                                End If

                            Next

                        End If
                    End If

                Next


            End If



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
            AddListOfError(Errorlog)
            Return True
        End Try
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Timer1.Stop()
            Application.DoEvents()

            LoadData()
        Catch ex As Exception

        End Try
    End Sub
End Class