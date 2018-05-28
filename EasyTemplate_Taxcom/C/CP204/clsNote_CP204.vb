Imports System.Data.SqlClient

Public Class clsNote_CP204
    Inherits SQLDataObject
    Private _Row As DataRow
    Private _Attachment As List(Of DataRow)
    Private _Column As List(Of DataRow)

    Public Event Row_Added(e As DataRow)

    Sub New()

    End Sub

    Sub New(ByVal Row As DataRow)
        Try
            _Row = Row
        Catch ex As Exception

        End Try
    End Sub

    Public Property Attachment As List(Of DataRow)
        Set(value As List(Of DataRow))
            If _Attachment Is Nothing Then
                _Attachment = New List(Of DataRow)
            End If
            _Attachment = value
        End Set
        Get
            Return _Attachment
        End Get
    End Property
    Public Property Attachment_Item As DataRow
        Set(value As DataRow)
            If _Attachment Is Nothing Then
                _Attachment = New List(Of DataRow)
            End If
            _Attachment.Add(value)
        End Set
        Get
            Return Nothing
        End Get
    End Property
    Public Property Column As List(Of DataRow)
        Set(value As List(Of DataRow))
            If _Column Is Nothing Then
                _Column = New List(Of DataRow)
            End If
            _Column = value
        End Set
        Get
            Return _Column
        End Get
    End Property
    Public Property Column_Item As DataRow
        Set(value As DataRow)
            If _Column Is Nothing Then
                _Column = New List(Of DataRow)
            End If
            _Column.Add(value)
        End Set
        Get
            Return Nothing
        End Get
    End Property

    Public Property Row As DataRow
        Set(value As DataRow)
            _Row = value
            RaiseEvent Row_Added(value)
        End Set
        Get
            Return _Row
        End Get
    End Property

    Public Enum NoteType
        NORMAL = 0
        ATTACHMENT = 1
        COLUMN = 2

    End Enum
#Region "DATABASE"
    Public Function Load_Note(Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM BORANG_CP204_NOTE"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL

            Return GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
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
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_Note(ByVal ID As Decimal, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM BORANG_CP204_NOTE WHERE ID=@ID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.Decimal).Value = ID

            Return GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
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
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_Note(ByVal RefNo As String, ByVal YA As String, Optional Title As String = "", Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim isWhere As Boolean = False
            Dim StrSQL As String = "SELECT * FROM BORANG_CP204_NOTE"
            SQLcmd = New SqlCommand

            If RefNo <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE RefNo=@RefNo"
                Else
                    StrSQL += " AND RefNo=@RefNo"
                End If
                SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            End If

            If YA <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE YA=@YA"
                Else
                    StrSQL += " AND YA=@YA"
                End If
                SQLcmd.Parameters.Add("@YA", SqlDbType.NVarChar, 5).Value = YA
            End If

            If Title <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE Title LIKE @Title"
                Else
                    StrSQL += " AND LIKE @Title"
                End If
                SQLcmd.Parameters.Add("@Title", SqlDbType.NVarChar, 250).Value = "%" & Title & "%"
            End If
            SQLcmd.CommandText = StrSQL

            Return GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
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
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_Note(ByVal RefNo As String, ByVal YA As String, ByVal Parent_KEY As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim isWhere As Boolean = False
            Dim StrSQL As String = "SELECT * FROM BORANG_CP204_NOTE WHERE RefNo=@RefNo AND YA=@YA AND Parent_KEY=@Parent_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@Parent_KEY", SqlDbType.Int).Value = Parent_KEY
            SQLcmd.CommandText = StrSQL

            Return GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
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
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_Note(ByVal TagID As String, ByVal Parent_KEY As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM BORANG_CP204_NOTE WHERE TagID=@TagID AND Parent_KEY=@Parent_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@TagID", SqlDbType.NVarChar, 50).Value = TagID
            SQLcmd.Parameters.Add("@Parent_KEY", SqlDbType.Int).Value = Parent_KEY

            Return GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
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
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_Note_Attachment(ByVal ID As Decimal, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM BORANG_CP204_NOTE_ATTACHMENT WHERE ParentID=@ParentID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ParentID", SqlDbType.Decimal).Value = ID

            Return GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
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
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_Note_Attachment(ByVal ID As Decimal, ByVal ParentID As Decimal, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM BORANG_CP204_NOTE_ATTACHMENT WHERE Parent_KEY=@Parent_KEY AND ParentID=@ParentID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@Parent_KEY", SqlDbType.Decimal).Value = ID
            SQLcmd.Parameters.Add("@ParentID", SqlDbType.Decimal).Value = ParentID

            Return GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
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
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_Note_Column(ByVal ID As Decimal, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM BORANG_CP204_NOTE_COLUMN WHERE ParentID=@ParentID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ParentID", SqlDbType.Decimal).Value = ID

            Return GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
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
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_Note_Column(ByVal ID As Decimal, ByVal ParentID As Decimal, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM BORANG_CP204_NOTE_COLUMN WHERE Parent_KEY=@Parent_KEY AND ParentID=@ParentID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@Parent_KEY", SqlDbType.Decimal).Value = ID
            SQLcmd.Parameters.Add("@ParentID", SqlDbType.Decimal).Value = ParentID

            Return GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
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
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Save_Note(ByVal Title As String, ByVal RefNo As String, ByVal YA As String, _
                              ByVal Parent_KEY As Integer, ByVal DataID As Integer, _
                              ByVal TypeNote As NoteType, _
                              ByVal Note As String, ByVal dtAttachment As DataTable, _
                              ByVal dtColumn As DataTable, ByVal TagID As String, _
                              ByRef ReturnID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "INSERT INTO BORANG_CP204_NOTE (Title,RefNo,YA,Parent_KEY,DataID,TypeNote,TagID,Note) VALUES (@Title,@RefNo,@YA,@Parent_KEY,@DataID,@TypeNote,@TagID,@Note)"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@Title", SqlDbType.NVarChar, 250).Value = Title
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@Parent_KEY", SqlDbType.Int).Value = Parent_KEY
            SQLcmd.Parameters.Add("@DataID", SqlDbType.Int).Value = DataID
            SQLcmd.Parameters.Add("@TypeNote", SqlDbType.Int).Value = TypeNote
            SQLcmd.Parameters.Add("@Note", SqlDbType.NVarChar, 4000).Value = Note
            SQLcmd.Parameters.Add("@TagID", SqlDbType.NVarChar, 50).Value = TagID

            Dim status As Boolean = ExecuteSQLCmd(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog, ReturnID)

            If status Then
                StrSQL = Nothing
                Dim ListofSQLCmd As New List(Of SqlCommand)

                Select Case TypeNote
                    Case NoteType.ATTACHMENT

                        If dtAttachment IsNot Nothing Then

                            For Each rowx As DataRow In dtAttachment.Rows
                                StrSQL = Nothing
                                SQLcmd = Nothing
                                StrSQL = "INSERT INTO BORANG_CP204_NOTE_ATTACHMENT(ParentID,Attachment,Extension) VALUES (@ParentID,@Attachment,@Extension)"
                                SQLcmd = New SqlCommand
                                SQLcmd.CommandText = StrSQL
                                SQLcmd.Parameters.Add("@ParentID", SqlDbType.Decimal).Value = ReturnID

                                If IsDBNull(rowx("Attachment")) = False Then
                                    SQLcmd.Parameters.Add("@Attachment", SqlDbType.Image).Value = rowx("Attachment")
                                Else
                                    SQLcmd.Parameters.Add("@Attachment", SqlDbType.Image).Value = DBNull.Value
                                End If

                                SQLcmd.Parameters.Add("@Extension", SqlDbType.NVarChar, 20).Value = IIf(IsDBNull(rowx("Extension")), "", rowx("Extension"))

                                ListofSQLCmd.Add(SQLcmd)
                            Next

                        End If


                    Case NoteType.COLUMN
                        If dtColumn IsNot Nothing Then

                            For Each rowx As DataRow In dtColumn.Rows
                                StrSQL = Nothing
                                SQLcmd = Nothing
                                StrSQL = "INSERT INTO BORANG_CP204_NOTE_COLUMN(ParentID,Col1_Name,Col1_Val,Col2_Name,Col2_Val,Col3_Name,Col3_Val,Col4_Name,Col4_Val,Col5_Name,Col5_Val,Col6_Name,Col6_Val) VALUES (@ParentID,@Col1_Name,@Col1_Val,@Col2_Name,@Col2_Val,@Col3_Name,@Col3_Val,@Col4_Name,@Col4_Val,@Col5_Name,@Col5_Val,@Col6_Name,@Col6_Val)"
                                SQLcmd = New SqlCommand
                                SQLcmd.CommandText = StrSQL
                                SQLcmd.Parameters.Add("@ParentID", SqlDbType.Decimal).Value = ReturnID

                                SQLcmd.Parameters.Add("@Col1_Name", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowx("Col1_Name")), "", rowx("Col1_Name"))
                                SQLcmd.Parameters.Add("@Col1_Val", SqlDbType.NVarChar, 250).Value = IIf(IsDBNull(rowx("Col1_Val")), "", rowx("Col1_Val"))

                                SQLcmd.Parameters.Add("@Col2_Name", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowx("Col2_Name")), "", rowx("Col2_Name"))
                                SQLcmd.Parameters.Add("@Col2_Val", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowx("Col2_Val")), "", rowx("Col2_Val"))

                                SQLcmd.Parameters.Add("@Col3_Name", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowx("Col3_Name")), "", rowx("Col3_Name"))
                                SQLcmd.Parameters.Add("@Col3_Val", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowx("Col3_Val")), "", rowx("Col3_Val"))

                                SQLcmd.Parameters.Add("@Col4_Name", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowx("Col4_Name")), "", rowx("Col4_Name"))
                                SQLcmd.Parameters.Add("@Col4_Val", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowx("Col4_Val")), "", rowx("Col4_Val"))

                                SQLcmd.Parameters.Add("@Col5_Name", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowx("Col5_Name")), "", rowx("Col5_Name"))
                                SQLcmd.Parameters.Add("@Col5_Val", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowx("Col5_Val")), "", rowx("Col5_Val"))

                                SQLcmd.Parameters.Add("@Col6_Name", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowx("Col6_Name")), "", rowx("Col6_Name"))
                                SQLcmd.Parameters.Add("@Col6_Val", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowx("Col6_Val")), "", rowx("Col6_Val"))

                                ListofSQLCmd.Add(SQLcmd)
                            Next

                        End If

                End Select

                If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                    Return False
                End If

                If ListofSQLCmd IsNot Nothing AndAlso ListofSQLCmd.Count > 0 Then
                    Return ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofSQLCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod.Name, ErrorLog)
                Else
                    Return True
                End If

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
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function Update_Note(ByVal ID As Decimal, ByVal Title As String, ByVal RefNo As String, ByVal YA As String, _
                              ByVal Parent_KEY As Integer, ByVal DataID As Integer, _
                              ByVal TypeNote As NoteType, _
                              ByVal Note As String, ByVal dtAttachment As DataTable, _
                              ByVal dtColumn As DataTable, ByVal TagID As String, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim ListofSQLCmd As New List(Of SqlCommand)
            Dim SQLcmd As SqlCommand

            Dim StrSQL As String = ""

            StrSQL = "DELETE BORANG_CP204_NOTE_ATTACHMENT WHERE ParentID=@ParentID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ParentID", SqlDbType.Decimal).Value = ID
            ListofSQLCmd.Add(SQLcmd)

            StrSQL = Nothing
            SQLcmd = Nothing

            StrSQL = "DELETE BORANG_CP204_NOTE_COLUMN WHERE ParentID=@ParentID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ParentID", SqlDbType.Decimal).Value = ID
            ListofSQLCmd.Add(SQLcmd)

            StrSQL = Nothing
            SQLcmd = Nothing

            StrSQL = "UPDATE BORANG_CP204_NOTE SET Title=@Title,RefNo=@RefNo,YA=@YA,Parent_KEY=@Parent_KEY,DataID=@DataID,TypeNote=@TypeNote,Note=@Note,TagID=@TagID WHERE ID=@ID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
            SQLcmd.Parameters.Add("@Title", SqlDbType.NVarChar, 250).Value = Title
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@Parent_KEY", SqlDbType.Int).Value = Parent_KEY
            SQLcmd.Parameters.Add("@DataID", SqlDbType.Int).Value = DataID
            SQLcmd.Parameters.Add("@TypeNote", SqlDbType.Int).Value = TypeNote
            SQLcmd.Parameters.Add("@Note", SqlDbType.NVarChar, 4000).Value = Note
            SQLcmd.Parameters.Add("@TagID", SqlDbType.NVarChar, 50).Value = TagID

            ListofSQLCmd.Add(SQLcmd)

            Select Case TypeNote
                Case NoteType.ATTACHMENT

                    If dtAttachment IsNot Nothing Then

                        For Each rowx As DataRow In dtAttachment.Rows
                            StrSQL = Nothing
                            SQLcmd = Nothing
                            StrSQL = "INSERT INTO BORANG_CP204_NOTE_ATTACHMENT(ParentID,Attachment,Extension) VALUES (@ParentID,@Attachment,@Extension)"
                            SQLcmd = New SqlCommand
                            SQLcmd.CommandText = StrSQL
                            SQLcmd.Parameters.Add("@ParentID", SqlDbType.Decimal).Value = ID

                            If IsDBNull(rowx("Attachment")) = False Then
                                SQLcmd.Parameters.Add("@Attachment", SqlDbType.Image).Value = rowx("Attachment")
                            Else
                                SQLcmd.Parameters.Add("@Attachment", SqlDbType.Image).Value = DBNull.Value
                            End If

                            SQLcmd.Parameters.Add("@Extension", SqlDbType.NVarChar, 20).Value = IIf(IsDBNull(rowx("Extension")), "", rowx("Extension"))

                            ListofSQLCmd.Add(SQLcmd)
                        Next

                    End If


                Case NoteType.COLUMN
                    If dtColumn IsNot Nothing Then

                        For Each rowx As DataRow In dtColumn.Rows
                            StrSQL = Nothing
                            SQLcmd = Nothing
                            StrSQL = "INSERT INTO BORANG_CP204_NOTE_COLUMN(ParentID,Col1_Name,Col1_Val,Col2_Name,Col2_Val,Col3_Name,Col3_Val,Col4_Name,Col4_Val,Col5_Name,Col5_Val,Col6_Name,Col6_Val) VALUES (@ParentID,@Col1_Name,@Col1_Val,@Col2_Name,@Col2_Val,@Col3_Name,@Col3_Val,@Col4_Name,@Col4_Val,@Col5_Name,@Col5_Val,@Col6_Name,@Col6_Val)"
                            SQLcmd = New SqlCommand
                            SQLcmd.CommandText = StrSQL
                            SQLcmd.Parameters.Add("@ParentID", SqlDbType.Decimal).Value = ID

                            SQLcmd.Parameters.Add("@Col1_Name", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowx("Col1_Name")), "", rowx("Col1_Name"))
                            SQLcmd.Parameters.Add("@Col1_Val", SqlDbType.NVarChar, 250).Value = IIf(IsDBNull(rowx("Col1_Val")), "", rowx("Col1_Val"))

                            SQLcmd.Parameters.Add("@Col2_Name", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowx("Col2_Name")), "", rowx("Col2_Name"))
                            SQLcmd.Parameters.Add("@Col2_Val", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowx("Col2_Val")), "", rowx("Col2_Val"))

                            SQLcmd.Parameters.Add("@Col3_Name", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowx("Col3_Name")), "", rowx("Col3_Name"))
                            SQLcmd.Parameters.Add("@Col3_Val", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowx("Col3_Val")), "", rowx("Col3_Val"))

                            SQLcmd.Parameters.Add("@Col4_Name", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowx("Col4_Name")), "", rowx("Col4_Name"))
                            SQLcmd.Parameters.Add("@Col4_Val", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowx("Col4_Val")), "", rowx("Col4_Val"))

                            SQLcmd.Parameters.Add("@Col5_Name", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowx("Col5_Name")), "", rowx("Col5_Name"))
                            SQLcmd.Parameters.Add("@Col5_Val", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowx("Col5_Val")), "", rowx("Col5_Val"))

                            SQLcmd.Parameters.Add("@Col6_Name", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowx("Col6_Name")), "", rowx("Col6_Name"))
                            SQLcmd.Parameters.Add("@Col6_Val", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowx("Col6_Val")), "", rowx("Col6_Val"))

                            ListofSQLCmd.Add(SQLcmd)
                        Next

                    End If

            End Select

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            If ListofSQLCmd IsNot Nothing AndAlso ListofSQLCmd.Count > 0 Then
                Return ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofSQLCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod.Name, ErrorLog)
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
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function Delete_Note(ByVal ID As Integer, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            Dim ListofSQLCmd As New List(Of SqlCommand)
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If
            Dim StrSQL As String = Nothing
            Dim SQLcmd As SqlCommand = Nothing


            StrSQL = "DELETE BORANG_CP204_NOTE_ATTACHMENT WHERE ParentID=@ParentID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ParentID", SqlDbType.Decimal).Value = ID
            ListofSQLCmd.Add(SQLcmd)

            StrSQL = Nothing
            SQLcmd = Nothing

            StrSQL = "DELETE BORANG_CP204_NOTE_COLUMN WHERE ParentID=@ParentID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ParentID", SqlDbType.Decimal).Value = ID
            ListofSQLCmd.Add(SQLcmd)

            StrSQL = Nothing
            SQLcmd = Nothing

            StrSQL = "DELETE BORANG_CP204_NOTE WHERE ID=@ID"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@ID", SqlDbType.Decimal).Value = ID
            ListofSQLCmd.Add(SQLcmd)


            Return ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofSQLCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod.Name, ErrorLog)
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
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function

#End Region
End Class
