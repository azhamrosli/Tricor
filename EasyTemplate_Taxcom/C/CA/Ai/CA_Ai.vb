Imports System.Data.SqlClient

Public Class CA_Ai
    Inherits SQLDataObject
    Public Property Description As String = Nothing
    Public Property isBusy As Boolean = False

    Public Event OnDataResult(ByVal dt_ As DataTable)
    Dim ListofArrStr As List(Of String)

    Private SqlCon As SqlConnection = Nothing
    Private ErrorLog As ClsError = Nothing
    Public Sub Search()
        Try
            isBusy = True

            ListofArrStr = Nothing
            ListofArrStr = New List(Of String)

            Dim arr As String() = Description.Split(" ")

            If arr IsNot Nothing AndAlso arr.Count > 0 Then

                For i As Integer = 0 To arr.Count - 1
                    ListofArrStr.Add(arr(i))
                Next


                If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                    Exit Sub
                End If

                Dim SQLcmd As SqlCommand
                Dim StrSQL As String = "SELECT COUNT(CA_KEY) AS COUNTX,CA_CATEGORY_CODE,CA_RATE_IA,CA_RATE_AA FROM CA WHERE"
               
                Dim isWhere As Boolean = False
                For Each Descript As String In ListofArrStr
                    If Descript IsNot Nothing AndAlso Descript <> "" Then
                        If isWhere = False Then
                            StrSQL += " CA_ASSET LIKE '%" & Descript & "%'"
                            isWhere = True
                        Else
                            StrSQL += " AND CA_ASSET LIKE '%" & Descript & "%'"
                        End If

                    End If
                Next
                StrSQL += " GROUP BY CA_CATEGORY_CODE,CA_RATE_IA,CA_RATE_AA ORDER BY COUNTX DESC"
                Application.DoEvents()
                SQLcmd = New SqlCommand With {
                   .CommandText = StrSQL
                }

                Dim dtResult As DataTable = Nothing

                dtResult = Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

              RaiseEvent OnDataResult(dtResult)
            End If

        Catch ex As Exception

        Finally
            isBusy = False
        End Try
    End Sub
End Class
