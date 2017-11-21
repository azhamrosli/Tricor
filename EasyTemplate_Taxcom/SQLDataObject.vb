Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections
Imports System.Xml

'For Database server
'Min Pool Size=5;Max Pool Size=60;Connect Timeout=2;"
'Pooling=false;Connect Timeout=30;

Public Class SQLDataObject

#Region " Private Attributes"
    Private DBErrorMsg As String
    Private Shared strSQLConstr As String 'Using SQL connection 
#End Region

#Region " Public Attributes"
    Public Property ErrorMessage() As String
        Get
            Return DBErrorMsg
        End Get
        Set(ByVal strMsg As String)
            DBErrorMsg = strMsg
        End Set
    End Property

    Public Property ConstrSQL() As String
        Get
            'Return DecryptConnectionString(configurationmanager.AppSettings("ConnectionString"))
            Return strSQLConstr
        End Get
        Set(ByVal strConn As String)
            'DecryptConnectionString(configurationmanager.AppSettings("ConnectionString"))
            strSQLConstr = strConn 'DecryptConnectionString(strConn)
        End Set
    End Property
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

            AddListOfError(ErrorLog)
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

#End Region

#Region " Functions & Subroutines"
    Public Function GetSQLDataTable(ByVal Command As SqlCommand, ByVal oConn As SqlConnection, Optional MethodName As String = "", Optional ByRef ErrorLog As clsError = Nothing) As DataTable

        If oConn Is Nothing OrElse oConn.State = ConnectionState.Closed OrElse oConn.State = ConnectionState.Broken Then
            If mdlProcess.DBConnection(oConn, ErrorLog) = False Then
                Return Nothing
            End If
        End If

        'Dim Cmd As New SqlCommand(strSQL, oConn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Try
            Command.Connection = oConn
            da.SelectCommand = Command
            da.Fill(ds, "Table")

            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                Return ds.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.GetHashCode.ToString, ex.Message, ErrorLog)
            Return Nothing
        Finally
            If oConn IsNot Nothing AndAlso oConn.State = ConnectionState.Open Then
                oConn.Close()
            End If
        End Try
    End Function
    Public Function ExecuteSQLCmd_NOIDReturn(ByVal Command As SqlCommand, ByVal oConn As SqlConnection,
                                   Optional MethodName As String = "",
                                  Optional ByRef ErrorLog As clsError = Nothing) As Boolean

        If oConn Is Nothing OrElse oConn.State = ConnectionState.Closed OrElse oConn.State = ConnectionState.Broken Then
            If mdlProcess.DBConnection(oConn, ErrorLog) = False Then
                Return Nothing
            End If
        End If

        'Dim Cmd As New SqlCommand(strSQL, oConn)
        '   Dim ds As New DataSet
        '   Dim da As New SqlDataAdapter
        Try
            Command.Connection = oConn
            Command.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.GetHashCode.ToString, ex.Message, ErrorLog)
            Return False
        Finally
            If oConn IsNot Nothing AndAlso oConn.State = ConnectionState.Open Then
                oConn.Close()
            End If
        End Try
    End Function
    Public Function ExecuteSQLCmd(ByVal Command As SqlCommand, ByVal oConn As SqlConnection,
                                   Optional MethodName As String = "",
                                  Optional ByRef ErrorLog As clsError = Nothing, Optional ByRef ReturnID As Integer = -1) As Boolean

        If oConn Is Nothing OrElse oConn.State = ConnectionState.Closed OrElse oConn.State = ConnectionState.Broken Then
            If mdlProcess.DBConnection(oConn, ErrorLog) = False Then
                Return Nothing
            End If
        End If

        'Dim Cmd As New SqlCommand(strSQL, oConn)
        '   Dim ds As New DataSet
        '   Dim da As New SqlDataAdapter
        Try
            Command.Connection = oConn
            Command.ExecuteNonQuery()

            Command.CommandText = "SELECT @@IDENTITY"
            ReturnID = Command.ExecuteScalar()

            Return True
        Catch ex As Exception

            CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.GetHashCode.ToString, ex.Message, ErrorLog)
            Return False
        Finally
            If oConn IsNot Nothing AndAlso oConn.State = ConnectionState.Open Then
                oConn.Close()
            End If
        End Try
    End Function
    Public Function GetSQLDataSet(ByVal strSQL As String, ByVal oConn As SqlConnection, Optional MethodName As String = "", Optional ByRef ErrorLog As clsError = Nothing) As DataSet

        If oConn Is Nothing OrElse oConn.State = ConnectionState.Closed OrElse oConn.State = ConnectionState.Broken Then
            If mdlProcess.DBConnection(oConn, ErrorLog) = False Then
                Return Nothing
            End If
        End If

        Dim Cmd As New SqlCommand(strSQL, oConn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Try
            da.SelectCommand = Cmd
            da.Fill(ds, strSQL)

            If ds IsNot Nothing Then
                Return ds
            Else
                Return Nothing
            End If

        Catch ex As Exception
            CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.GetHashCode.ToString, ex.Message, ErrorLog)
            Return Nothing
        Finally
            If oConn IsNot Nothing AndAlso oConn.State = ConnectionState.Open Then
                oConn.Close()
            End If
        End Try
        'Return ds
    End Function
    Public Sub UpdateSQLDataTableTransction(ByVal strDelTbl As ArrayList, ByVal odt As ArrayList, _
                                            ByVal strSelectSQL As ArrayList, ByVal oConn As SqlConnection, _
                                             Optional ByRef ErrorLog As clsError = Nothing)

        If oConn Is Nothing OrElse oConn.State = ConnectionState.Closed OrElse oConn.State = ConnectionState.Broken Then
            If mdlProcess.DBConnection(oConn, ErrorLog) = False Then
                Exit Sub
            End If
        End If

        Dim i As Integer

        Dim txn As SqlTransaction = oConn.BeginTransaction() 'Begin Trans

        'Delete statement arraylist size is independent
        Try
            For i = 0 To strDelTbl.Count - 1
                Dim Cmd As New SqlCommand(strDelTbl(i))
                Cmd.Connection = oConn
                Cmd.Transaction = txn
                Cmd.ExecuteNonQuery()
            Next
        Catch ex As Exception
            CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.GetHashCode.ToString, ex.Message, ErrorLog)
            txn.Rollback()
            Exit Sub
        End Try

        'Select statement and datatable arraylist count or size must be the same
        Try
            For i = 0 To odt.Count - 1
                Dim da As New SqlDataAdapter(strSelectSQL(i), oConn)
                da.SelectCommand.Transaction = txn 'Without this line not work, cb is not associate to the transaction
                Dim cb As New SqlCommandBuilder(da) 'Generate command for database update
                da.Update(odt(i))
            Next
        Catch ex As Exception
            CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.GetHashCode.ToString, ex.Message, ErrorLog)
            txn.Rollback()
            Exit Sub
        End Try
        txn.Commit() 'Commit Trans 
        If oConn IsNot Nothing AndAlso oConn.State = ConnectionState.Open Then
            oConn.Close()
        End If
    End Sub
    'Above function using dataset instead of datatable
    Public Sub UpdateSQLDataTable(ByVal odt As DataTable, ByVal oConn As SqlConnection, ByVal strSelectSQL As String, _
                                   Optional ByRef ErrorLog As clsError = Nothing)

        If oConn Is Nothing OrElse oConn.State = ConnectionState.Closed OrElse oConn.State = ConnectionState.Broken Then
            Exit Sub
        End If

        Try
            Dim da As New SqlDataAdapter(strSelectSQL, oConn)
            Dim cb As New SqlCommandBuilder(da)
            da.Update(odt)
        Catch ex As Exception
            CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.GetHashCode.ToString, ex.Message, ErrorLog)
        End Try

    End Sub
    'Insert, update & delete using dataset and command builder
    Public Sub CBUpdateSQLTrans(ByVal odt As DataTable, ByVal oConn As SqlConnection, ByVal strSelectSQL As String, Optional ByRef ErrorLog As clsError = Nothing)

        If oConn Is Nothing OrElse oConn.State = ConnectionState.Closed OrElse oConn.State = ConnectionState.Broken Then
            If mdlProcess.DBConnection(oConn, ErrorLog) = False Then
                Exit Sub
            End If
        End If

        Dim txn As SqlTransaction = oConn.BeginTransaction()  'Begin Trans

        Try
            Dim da As New SqlDataAdapter(strSelectSQL, oConn)
            Dim cb As New SqlCommandBuilder(da)

            Dim UpdatedRows As DataTable
            Dim InsertedRows As DataTable
            Dim DeletedRows As DataTable
            UpdatedRows = odt.GetChanges(DataRowState.Modified)
            InsertedRows = odt.GetChanges(DataRowState.Added)
            DeletedRows = odt.GetChanges(DataRowState.Deleted)

            da.SelectCommand.Transaction = txn
            If Not UpdatedRows Is Nothing Then da.Update(UpdatedRows)
            If Not InsertedRows Is Nothing Then da.Update(InsertedRows)
            If Not DeletedRows Is Nothing Then da.Update(DeletedRows)
        Catch ex As Exception
            txn.Rollback()
            DBErrorMsg = ex.Message.ToString
            CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.GetHashCode.ToString, ex.Message, ErrorLog)
            Exit Sub
        End Try
        txn.Commit()

        If oConn IsNot Nothing AndAlso oConn.State = ConnectionState.Open Then
            oConn.Close()
        End If
    End Sub
    Public Function ExecuteSQLTransactionBySQLCommand_NOReturnID(ByVal ListofSQLCmd As List(Of SqlCommand), ByVal oConn As SqlConnection,
                                                     Optional ByVal MethodName As String = "", Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Dim ReturnID As Integer = -1
        Dim SQL As String = ""
        If oConn Is Nothing OrElse oConn.State = ConnectionState.Closed OrElse oConn.State = ConnectionState.Broken Then
            If mdlProcess.DBConnection(oConn, ErrorLog) = False Then
                Return False
            End If
        End If

        Dim txn As SqlTransaction
        txn = oConn.BeginTransaction 'Begin Trans

        Try

            For i = 0 To ListofSQLCmd.Count - 1
                ReturnID = i
                SQL = ListofSQLCmd(i).CommandText
                ListofSQLCmd(i).Transaction = txn
                ListofSQLCmd(i).Connection = oConn
                ListofSQLCmd(i).ExecuteNonQuery()
            Next

            txn.Commit() 'Commit Trans 
            Return True
        Catch ex As Exception

            CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.GetHashCode.ToString, "Line No =" & ReturnID & " | SQL =" & SQL & " | Error=" & ex.Message, ErrorLog)
            Return False
        Finally
            If oConn IsNot Nothing AndAlso oConn.State = ConnectionState.Open Then
                oConn.Close()
            End If
        End Try
    End Function
    Public Function ExecuteSQLTransactionBySQLCommand(ByVal ListofSQLCmd As List(Of SqlCommand), ByVal oConn As SqlConnection,
                                                      Optional ByVal MethodName As String = "", Optional ByRef ErrorLog As clsError = Nothing,
                                                      Optional ByRef ListOfReturnID As List(Of Integer) = Nothing) As Boolean

        If oConn Is Nothing OrElse oConn.State = ConnectionState.Closed OrElse oConn.State = ConnectionState.Broken Then
            If mdlProcess.DBConnection(oConn, ErrorLog) = False Then
                Return False
            End If
        End If
        Dim ReturnID As Integer = -1
        Dim SQL As String = Nothing
        Dim txn As SqlTransaction
        txn = oConn.BeginTransaction 'Begin Trans

        Try

            For i = 0 To ListofSQLCmd.Count - 1
                ReturnID = -1
                SQL = ListofSQLCmd(i).CommandText
                ListofSQLCmd(i).Transaction = txn
                ListofSQLCmd(i).ExecuteNonQuery()

                ListofSQLCmd(i).CommandText = "SELECT @@IDENTITY"
                ReturnID = ListofSQLCmd(i).ExecuteScalar()

                ListOfReturnID.Add(ReturnID)
            Next

            txn.Commit() 'Commit Trans 
            Return True
        Catch ex As Exception

            CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.GetHashCode.ToString, "Line No =" & ReturnID & " | SQL =" & SQL & " | Error=" & ex.Message, ErrorLog)
            Return False
        Finally
            If oConn IsNot Nothing AndAlso oConn.State = ConnectionState.Open Then
                oConn.Close()
            End If
        End Try
    End Function
    Public Function ExecuteSQL(ByVal strSQL As String, ByVal oConn As SqlConnection, _
                                 Optional MethodName As String = "", Optional ByRef ErrorLog As clsError = Nothing) As Integer

        If oConn Is Nothing OrElse oConn.State = ConnectionState.Closed OrElse oConn.State = ConnectionState.Broken Then
            If mdlProcess.DBConnection(oConn, ErrorLog) = False Then
                Return -1
            End If
        End If

        Dim Cmd As New SqlCommand
        Cmd.CommandText = strSQL
        Cmd.CommandType = CommandType.Text
        Cmd.Connection = oConn
        Try
            Return Cmd.ExecuteNonQuery() 'The number of rows affected.
        Catch ex As Exception
            CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.GetHashCode.ToString, ex.Message, ErrorLog)
            Return -1
        End Try
    End Function

    Public Function DataSetExists(ByVal objDS As DataSet) As Boolean
        If objDS.Tables(0).Rows.Count <= 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function CreateInsertCommand_ByDataTable(ByVal dt As DataTable, ByVal oConn As SqlConnection, ByVal ExceptionCol As List(Of String), _
                                              ByRef ListOfSQLcmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean

        If oConn Is Nothing OrElse oConn.State = ConnectionState.Closed OrElse oConn.State = ConnectionState.Broken Then
            If mdlProcess.DBConnection(oConn, ErrorLog) = False Then
                Return Nothing
            End If
        End If
        Try
            Dim tmpSQL As String = Nothing
            If dt.Rows.Count > 0 Then
                Dim SQLcmd As SqlCommand
                If ListOfSQLcmd Is Nothing Then
                    ListOfSQLcmd = New List(Of SqlCommand)
                End If

                Dim ListofColnotExp As New List(Of System.Data.DataColumn)
                For x As Integer = 0 To dt.Columns.Count - 1
                    If ExceptionCol IsNot Nothing AndAlso ExceptionCol.Contains(dt.Columns(x).ToString) Then
                    Else
                        ListofColnotExp.Add(dt.Columns(x))
                    End If
                Next

                For i As Integer = 0 To dt.Rows.Count - 1
                    tmpSQL = Nothing
                    tmpSQL = "INSERT INTO " & dt.TableName & "("
                    For x As Integer = 0 To ListofColnotExp.Count - 1
                        If (ListofColnotExp.Count - 1) = x Then
                            tmpSQL += ListofColnotExp(x).ToString
                        Else
                            tmpSQL += ListofColnotExp(x).ToString & ","
                        End If
                    Next
                    tmpSQL += ") VALUES ("

                    For x As Integer = 0 To ListofColnotExp.Count - 1
                        If (ListofColnotExp.Count - 1) = x Then
                            tmpSQL += "@" & ListofColnotExp(x).ToString
                        Else
                            tmpSQL += "@" & ListofColnotExp(x).ToString & ","
                        End If
                    Next
                    tmpSQL += ")"

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = tmpSQL
                    SQLcmd.Connection = oConn

                    For x As Integer = 0 To ListofColnotExp.Count - 1
                        Select Case ListofColnotExp(x).DataType
                            Case Type.GetType("System.String")
                                SQLcmd.Parameters.Add("@" & ListofColnotExp(x).ToString, SqlDbType.NVarChar, ListofColnotExp(x).MaxLength).Value = dt.Rows(i)(ListofColnotExp(x).ToString)
                            Case Type.GetType("System.Decimal")
                                SQLcmd.Parameters.Add("@" & ListofColnotExp(x).ToString, SqlDbType.Decimal).Value = dt.Rows(i)(ListofColnotExp(x).ToString)
                            Case Type.GetType("System.Int16"), Type.GetType("System.Int32"), Type.GetType("System.Int64")
                                SQLcmd.Parameters.Add("@" & ListofColnotExp(x).ToString, SqlDbType.Int).Value = dt.Rows(i)(ListofColnotExp(x).ToString)
                            Case Type.GetType("System.Double"), Type.GetType("System.Float")
                                SQLcmd.Parameters.Add("@" & ListofColnotExp(x).ToString, SqlDbType.Float).Value = dt.Rows(i)(ListofColnotExp(x).ToString)
                            Case Type.GetType("System.Decimal")
                                SQLcmd.Parameters.Add("@" & ListofColnotExp(x).ToString, SqlDbType.Decimal).Value = dt.Rows(i)(ListofColnotExp(x).ToString)
                            Case Type.GetType("System.DateTime")
                                SQLcmd.Parameters.Add("@" & ListofColnotExp(x).ToString, SqlDbType.DateTime).Value = dt.Rows(i)(ListofColnotExp(x).ToString)
                            Case Type.GetType("System.Byte()")
                                SQLcmd.Parameters.Add("@" & ListofColnotExp(x).ToString, SqlDbType.Image).Value = dt.Rows(i)(ListofColnotExp(x).ToString)
                            Case Type.GetType("System.Boolean")
                                SQLcmd.Parameters.Add("@" & ListofColnotExp(x).ToString, SqlDbType.Bit).Value = dt.Rows(i)(ListofColnotExp(x).ToString)
                        End Select
                    Next

                    ListOfSQLcmd.Add(SQLcmd)
                Next
            End If
            Return True
        Catch ex As Exception
            CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.GetHashCode.ToString, ex.Message, ErrorLog)
            Return False
        End Try
    End Function
    Public Function CreateUpdateCommand_ByDataTable(ByVal dt As DataTable, ByVal oConn As SqlConnection, ByVal ExceptionCol As List(Of String), _
                                             ByVal colID As String, ByRef ListOfSQLcmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        If oConn Is Nothing OrElse oConn.State = ConnectionState.Closed OrElse oConn.State = ConnectionState.Broken Then
            If mdlProcess.DBConnection(oConn, ErrorLog) = False Then
                Return Nothing
            End If
        End If
        Try
            Dim tmpSQL As String = Nothing
            If dt.Rows.Count > 0 Then
                Dim SQLcmd As SqlCommand
                If ListOfSQLcmd Is Nothing Then
                    ListOfSQLcmd = New List(Of SqlCommand)
                End If

                Dim ListofColnotExp As New List(Of System.Data.DataColumn)
                For x As Integer = 0 To dt.Columns.Count - 1
                    If ExceptionCol IsNot Nothing AndAlso ExceptionCol.Contains(dt.Columns(x).ToString) Then
                    Else
                        ListofColnotExp.Add(dt.Columns(x))
                    End If
                Next

                For i As Integer = 0 To dt.Rows.Count - 1
                    tmpSQL = Nothing
                    tmpSQL = "UPDATE " & dt.TableName & " SET "
                    For x As Integer = 0 To ListofColnotExp.Count - 1
                        If (ListofColnotExp.Count - 1) = x Then
                            tmpSQL += ListofColnotExp(x).ToString & "=@" & ListofColnotExp(x).ToString
                        Else
                            tmpSQL += ListofColnotExp(x).ToString & "=@" & ListofColnotExp(x).ToString & ","
                        End If
                    Next

                    tmpSQL += " WHERE " & colID & "=@" & colID

                    SQLcmd = New SqlCommand
                    SQLcmd.CommandText = tmpSQL
                    SQLcmd.Connection = oConn

                    For x As Integer = 0 To ListofColnotExp.Count - 1
                        Select Case ListofColnotExp(x).DataType
                            Case Type.GetType("System.String")
                                SQLcmd.Parameters.Add("@" & ListofColnotExp(x).ToString, SqlDbType.NVarChar, ListofColnotExp(x).MaxLength).Value = dt.Rows(i)(ListofColnotExp(x).ToString)
                            Case Type.GetType("System.Decimal")
                                SQLcmd.Parameters.Add("@" & ListofColnotExp(x).ToString, SqlDbType.Decimal).Value = dt.Rows(i)(ListofColnotExp(x).ToString)
                            Case Type.GetType("System.Int16"), Type.GetType("System.Int32"), Type.GetType("System.Int64")
                                SQLcmd.Parameters.Add("@" & ListofColnotExp(x).ToString, SqlDbType.Int).Value = dt.Rows(i)(ListofColnotExp(x).ToString)
                            Case Type.GetType("System.Double"), Type.GetType("System.Float")
                                SQLcmd.Parameters.Add("@" & ListofColnotExp(x).ToString, SqlDbType.Float).Value = dt.Rows(i)(ListofColnotExp(x).ToString)
                            Case Type.GetType("System.Decimal")
                                SQLcmd.Parameters.Add("@" & ListofColnotExp(x).ToString, SqlDbType.Decimal).Value = dt.Rows(i)(ListofColnotExp(x).ToString)
                            Case Type.GetType("System.DateTime")
                                SQLcmd.Parameters.Add("@" & ListofColnotExp(x).ToString, SqlDbType.DateTime).Value = dt.Rows(i)(ListofColnotExp(x).ToString)
                            Case Type.GetType("System.Byte()")
                                SQLcmd.Parameters.Add("@" & ListofColnotExp(x).ToString, SqlDbType.Image).Value = dt.Rows(i)(ListofColnotExp(x).ToString)
                            Case Type.GetType("System.Boolean")
                                SQLcmd.Parameters.Add("@" & ListofColnotExp(x).ToString, SqlDbType.Bit).Value = dt.Rows(i)(ListofColnotExp(x).ToString)

                        End Select
                    Next

                    Dim tmpCol As System.Data.DataColumn = dt.Columns(colID)

                    If tmpCol IsNot Nothing Then
                        Select Case tmpCol.DataType
                            Case Type.GetType("System.String")
                                SQLcmd.Parameters.Add("@" & tmpCol.ToString, SqlDbType.NVarChar, tmpCol.MaxLength).Value = dt.Rows(i)(tmpCol.ToString)
                            Case Type.GetType("System.Decimal")
                                SQLcmd.Parameters.Add("@" & tmpCol.ToString, SqlDbType.Decimal).Value = dt.Rows(i)(tmpCol.ToString)
                            Case Type.GetType("System.Int16"), Type.GetType("System.Int32"), Type.GetType("System.Int64")
                                SQLcmd.Parameters.Add("@" & tmpCol.ToString, SqlDbType.Int).Value = dt.Rows(i)(tmpCol.ToString)
                            Case Type.GetType("System.Double"), Type.GetType("System.Float")
                                SQLcmd.Parameters.Add("@" & tmpCol.ToString, SqlDbType.Float).Value = dt.Rows(i)(tmpCol.ToString)
                            Case Type.GetType("System.Decimal")
                                SQLcmd.Parameters.Add("@" & tmpCol.ToString, SqlDbType.Decimal).Value = dt.Rows(i)(tmpCol.ToString)
                            Case Type.GetType("System.DateTime")
                                SQLcmd.Parameters.Add("@" & tmpCol.ToString, SqlDbType.DateTime).Value = dt.Rows(i)(tmpCol.ToString)
                            Case Type.GetType("System.Byte()")
                                SQLcmd.Parameters.Add("@" & tmpCol.ToString, SqlDbType.Image).Value = dt.Rows(i)(tmpCol.ToString)
                            Case Type.GetType("System.Boolean")
                                SQLcmd.Parameters.Add("@" & tmpCol.ToString, SqlDbType.Bit).Value = dt.Rows(i)(tmpCol.ToString)
                        End Select
                    End If

                    ListOfSQLcmd.Add(SQLcmd)
                Next

            End If
            Return True
        Catch ex As Exception
            CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.GetHashCode.ToString, ex.Message, ErrorLog)
            Return False
        End Try
    End Function
    Public Function UpdateDataAdapter(ByVal da As System.Data.IDbDataAdapter, _
            ByVal dt As DataTable, ByVal useTransactions As Boolean) As Integer
        Dim tr As System.Data.IDbTransaction = Nothing
        Dim affectedRows As Integer

        ' we need a reference to a concrete DbDataAdapter object
        Dim dda As System.Data.Common.DbDataAdapter = DirectCast(da,  _
            System.Data.Common.DbDataAdapter)

        If useTransactions Then
            ' get the connection object related to the DataAdapter
            Dim cn As System.Data.IDbConnection = da.SelectCommand.Connection

            ' open a transaction on that connection
            tr = da.SelectCommand.Connection.BeginTransaction()
            ' enroll all commands in that transaction
            da.DeleteCommand.Transaction = tr
            da.InsertCommand.Transaction = tr
            da.UpdateCommand.Transaction = tr
            ' we need an exception if an update conflict occurs
            dda.ContinueUpdateOnError = False
        Else
            ' otherwise just ignore conflicts
            dda.ContinueUpdateOnError = True
        End If

        Try
            ' perform the update
            affectedRows = dda.Update(dt)
            ' if we get here, we can commit the transaction (if there is one)
            If Not (tr Is Nothing) Then tr.Commit()
        Catch ex As Exception
            ' in this case we must rollback the transaction 
            ' (if there is one) and swallow the exception
            If Not (tr Is Nothing) Then tr.Rollback()
            affectedRows = -1
        End Try

        ' return the number of affected rows
        Return affectedRows
    End Function
    Public Function WriteDateTableXML(ByVal Command As SqlCommand, ByVal oConn As SqlConnection, ByVal FilePath As String, Optional Type As Integer = 0,
                                   Optional ByVal MethodName As String = "",
                                  Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        'NOTE := FILE PATH MUST BE FULL
        If oConn Is Nothing OrElse oConn.State = ConnectionState.Closed OrElse oConn.State = ConnectionState.Broken Then
            If mdlProcess.DBConnection(oConn, ErrorLog) = False Then
                Return False
            End If
        End If

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Try
            Command.Connection = oConn
            da.SelectCommand = Command
            da.Fill(ds, "Table")

            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then

                FilePath = FilePath.Replace(".xml", "")

                If Type = 0 Then
                    'Delete
                    If System.IO.File.Exists(FilePath) = True Then
                        System.IO.File.Delete(FilePath)
                        FilePath = FilePath & ".xml"
                    End If
                Else
                    'Rename
                    If System.IO.File.Exists(FilePath) = True Then
                        FilePath = FilePath & Format(Now, "ddMMMyyyyHHmmss") & ".xml"
                    End If
                End If

                ds.WriteXml(FilePath)

                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            CreateErrorLog(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.GetHashCode.ToString, ex.Message, ErrorLog)
            Return False
        Finally
            If oConn IsNot Nothing AndAlso oConn.State = ConnectionState.Open Then
                oConn.Close()
            End If
        End Try
    End Function
#End Region

End Class