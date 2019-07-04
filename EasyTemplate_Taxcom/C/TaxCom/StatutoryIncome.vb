Imports System.Data.SqlClient

Public Class StatutoryIncome
    Inherits SQLDataObject

    Private Property ErrorLog As ClsError = Nothing

#Region "DATABASE"
    Public Function Load_OtherExemption() As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT EXP_PIONEER FROM OTHER_EXEMPTION ORDER BY EXP_PIONEER"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

            Return Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
#End Region
End Class
