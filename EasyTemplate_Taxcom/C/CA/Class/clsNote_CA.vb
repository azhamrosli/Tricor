﻿Imports System.Data.SqlClient

Public Class clsNote_CA
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
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

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
        ATTACHMENT = 2
        COLUMN = 1

    End Enum
#Region "DATABASE"
    Public Function Load_Footer_Note_CA(ByVal RefNo As String, ByVal YA As Integer,
                                              Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA_REPORT_NOTE WHERE RefNo=@RefNo AND YA=@YA"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = YA

            Return GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_Footer_Note_HP(ByVal RefNo As String, ByVal YA As Integer,
                                              Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM HP_REPORT_NOTE WHERE RefNo=@RefNo AND YA=@YA"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = YA

            Return GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_Footer_Note_Disposal(ByVal RefNo As String, ByVal YA As Integer, ByVal Type As Integer,
                                              Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA_REPORT_DISPOSAL_NOTE WHERE RefNo=@RefNo AND YA=@YA AND Type=@Type"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = YA
            SQLcmd.Parameters.Add("@Type", SqlDbType.Int).Value = Type

            Return GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_Footer_Note_ControlTransfer_IN(ByVal RefNo As String, ByVal YA As Integer,
                                                        Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA_REPORT_CONTROLTRANSFER_NOTE WHERE RefNo=@RefNo AND YA=@YA"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = YA

            Return GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_Note(Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA_NOTE"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

            Return GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_Note(ByVal ID As Decimal, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA_NOTE WHERE ID=@ID"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@ID", SqlDbType.Decimal).Value = ID

            Return GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_Note(ByVal RefNo As String, ByVal YA As String, Optional Title As String = "", Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim isWhere As Boolean = False
            Dim StrSQL As String = "SELECT * FROM CA_NOTE"
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
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_Note(ByVal RefNo As String, ByVal YA As String, ByVal CA_ID As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim isWhere As Boolean = False
            Dim StrSQL As String = "SELECT * FROM CA_NOTE WHERE RefNo=@RefNo AND YA=@YA AND CA_ID=@CA_ID"
            SQLcmd = New SqlCommand
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@CA_ID", SqlDbType.Int).Value = CA_ID
            SQLcmd.CommandText = StrSQL

            Return GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_Note(ByVal CA_ID As Integer, ByVal Type_CA As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA_NOTE WHERE CA_ID=@CA_ID AND Type_CA=@Type_CA"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@CA_ID", SqlDbType.Int).Value = CA_ID
            SQLcmd.Parameters.Add("@Type_CA", SqlDbType.Int).Value = Type_CA

            Return GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_Note(ByVal CA_ID As Integer, ByVal Type_CA As Integer, ByVal TagID As String, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA_NOTE WHERE CA_ID=@CA_ID AND Type_CA=@Type_CA AND TagID=@TagID"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@CA_ID", SqlDbType.Int).Value = CA_ID
            SQLcmd.Parameters.Add("@Type_CA", SqlDbType.Int).Value = Type_CA
            SQLcmd.Parameters.Add("@TagID", SqlDbType.NVarChar, 50).Value = TagID

            Return GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_Note_Attachment(ByVal ID As Decimal, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA_NOTE_ATTACHMENT WHERE ParentID=@ParentID"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@ParentID", SqlDbType.Decimal).Value = ID

            Return GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_Note_Attachment(ByVal ID As Decimal, ByVal ParentID As Decimal, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA_NOTE_ATTACHMENT WHERE CA_ID=@CA_ID ParentID=@ParentID"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@CA_ID", SqlDbType.Decimal).Value = ID
            SQLcmd.Parameters.Add("@ParentID", SqlDbType.Decimal).Value = ParentID

            Return GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_Note_Column(ByVal ID As Decimal, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA_NOTE_COLUMN WHERE ParentID=@ParentID"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@ParentID", SqlDbType.Decimal).Value = ID

            Return GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_Note_Column(ByVal ID As Decimal, ByVal ParentID As Decimal, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM CA_NOTE_COLUMN WHERE CA_ID=@CA_ID AND ParentID=@ParentID"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@CA_ID", SqlDbType.Decimal).Value = ID
            SQLcmd.Parameters.Add("@ParentID", SqlDbType.Decimal).Value = ParentID

            Return GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Save_Note_CA(ByVal RefNo As String, ByVal YA As String, ByVal QC_BF As String,
                                  ByVal QC_ADD As String, ByVal QC_DISP As String, ByVal QC_CF As String,
                                  ByVal TWDV_BF As String, ByVal TWDV_ADD As String, ByVal TWDV_DISP As String,
                                  ByVal TWDV_TOTAL As String, ByVal TWDV_AI As String, ByVal TWDV_AA As String,
                                  ByVal TWDV_CF As String, ByRef ReturnID As Integer,
                                  Optional ByRef ErrorLog As ClsError = Nothing) As Boolean
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "INSERT INTO CA_REPORT_NOTE (RefNo,YA,QC_BF,QC_ADD,QC_DISP,QC_CF,TWDV_BF,TWDV_ADD,TWDV_DISP,TWDV_TOTAL,TWDV_AI,TWDV_AA,TWDV_CF) VALUES (@RefNo,@YA,@QC_BF,@QC_ADD,@QC_DISP,@QC_CF,@TWDV_BF,@TWDV_ADD,@TWDV_DISP,@TWDV_TOTAL,@TWDV_AI,@TWDV_AA,@TWDV_CF)"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 30).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = YA
            SQLcmd.Parameters.Add("@QC_BF", SqlDbType.NVarChar, 200).Value = QC_BF
            SQLcmd.Parameters.Add("@QC_ADD", SqlDbType.NVarChar, 200).Value = QC_ADD
            SQLcmd.Parameters.Add("@QC_DISP", SqlDbType.NVarChar, 200).Value = QC_DISP
            SQLcmd.Parameters.Add("@QC_CF", SqlDbType.NVarChar, 200).Value = QC_CF
            SQLcmd.Parameters.Add("@TWDV_BF", SqlDbType.NVarChar, 200).Value = TWDV_BF
            SQLcmd.Parameters.Add("@TWDV_ADD", SqlDbType.NVarChar, 200).Value = TWDV_ADD
            SQLcmd.Parameters.Add("@TWDV_DISP", SqlDbType.NVarChar, 200).Value = TWDV_DISP
            SQLcmd.Parameters.Add("@TWDV_TOTAL", SqlDbType.NVarChar, 200).Value = TWDV_TOTAL
            SQLcmd.Parameters.Add("@TWDV_AI", SqlDbType.NVarChar, 200).Value = TWDV_AI
            SQLcmd.Parameters.Add("@TWDV_AA", SqlDbType.NVarChar, 200).Value = TWDV_AA
            SQLcmd.Parameters.Add("@TWDV_CF", SqlDbType.NVarChar, 200).Value = TWDV_CF

            Return ExecuteSQLCmd(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog, ReturnID)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function Save_Note_HP(ByVal RefNo As String, ByVal YA As Integer, ByVal BF_PRINCIPAL As String,
                                 ByVal BF_INTEREST As String, ByVal CURR_PRINCIPAL As String,
                                 ByVal CURR_INTEREST As String, ByVal CF_PRINCIPAL As String,
                                 ByVal CF_INTEREST As String, ByRef ReturnID As Integer,
                                 Optional ByRef ErrorLog As ClsError = Nothing) As Boolean
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "INSERT INTO HP_REPORT_NOTE (RefNo,YA,BF_PRINCIPAL,BF_INTEREST,CURR_PRINCIPAL,CURR_INTEREST,CF_PRINCIPAL,CF_INTEREST) VALUES (@RefNo,@YA,@BF_PRINCIPAL,@BF_INTEREST,@CURR_PRINCIPAL,@CURR_INTEREST,@CF_PRINCIPAL,@CF_INTEREST)"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 30).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = YA
            SQLcmd.Parameters.Add("@BF_PRINCIPAL", SqlDbType.NVarChar, 200).Value = BF_PRINCIPAL
            SQLcmd.Parameters.Add("@BF_INTEREST", SqlDbType.NVarChar, 200).Value = BF_INTEREST
            SQLcmd.Parameters.Add("@CURR_PRINCIPAL", SqlDbType.NVarChar, 200).Value = CURR_PRINCIPAL
            SQLcmd.Parameters.Add("@CURR_INTEREST", SqlDbType.NVarChar, 200).Value = CURR_INTEREST
            SQLcmd.Parameters.Add("@CF_PRINCIPAL", SqlDbType.NVarChar, 200).Value = CF_PRINCIPAL
            SQLcmd.Parameters.Add("@CF_INTEREST", SqlDbType.NVarChar, 200).Value = CF_INTEREST

            Return ExecuteSQLCmd(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog, ReturnID)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function Save_Note_Disposal(ByVal RefNo As String, ByVal YA As Integer, ByVal Type As Integer,
                                       ByVal CA_QUALIFYING_COST As String,
                                       ByVal DISP_DEPRECIATION As String,
                                       ByVal DISP_WDV As String,
                                       ByVal DISP_DISPOSAL_VALUE As String,
                                       ByVal DISP_PNL As String,
                                       ByVal DISP_TWDV As String,
                                       ByVal DISP_BABC As String,
                                       ByVal ReturnID As Integer,
                                       Optional ByRef ErrorLog As ClsError = Nothing) As Boolean
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "INSERT INTO CA_REPORT_DISPOSAL_NOTE (RefNo,YA,Type,CA_QUALIFYING_COST,DISP_DEPRECIATION,DISP_WDV,DISP_DISPOSAL_VALUE,DISP_PNL,DISP_TWDV,DISP_BABC) VALUES (@RefNo,@YA,@Type,@CA_QUALIFYING_COST,@DISP_DEPRECIATION,@DISP_WDV,@DISP_DISPOSAL_VALUE,@DISP_PNL,@DISP_TWDV,@DISP_BABC)"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 30).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = YA
            SQLcmd.Parameters.Add("@Type", SqlDbType.Int).Value = Type
            SQLcmd.Parameters.Add("@CA_QUALIFYING_COST", SqlDbType.NVarChar, 200).Value = CA_QUALIFYING_COST
            SQLcmd.Parameters.Add("@DISP_DEPRECIATION", SqlDbType.NVarChar, 200).Value = DISP_DEPRECIATION
            SQLcmd.Parameters.Add("@DISP_WDV", SqlDbType.NVarChar, 200).Value = DISP_WDV
            SQLcmd.Parameters.Add("@DISP_DISPOSAL_VALUE", SqlDbType.NVarChar, 200).Value = DISP_DISPOSAL_VALUE
            SQLcmd.Parameters.Add("@DISP_PNL", SqlDbType.NVarChar, 200).Value = DISP_PNL
            SQLcmd.Parameters.Add("@DISP_TWDV", SqlDbType.NVarChar, 200).Value = DISP_TWDV
            SQLcmd.Parameters.Add("@DISP_BABC", SqlDbType.NVarChar, 200).Value = DISP_BABC

            Return ExecuteSQLCmd(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog, ReturnID)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function Save_Note_ControlTransfer_IN(ByVal RefNo As String, ByVal YA As Integer,
                                                 ByVal CA_PURCHASE_AMOUNT As String,
                                                 ByVal TWDV_BF As String,
                                                 ByVal CA_TRANSFER_VAL As String,
                                                 ByVal ReturnID As Integer,
                                                 Optional ByRef ErrorLog As ClsError = Nothing) As Boolean
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "INSERT INTO CA_REPORT_CONTROLTRANSFER_NOTE (RefNo,YA,CA_PURCHASE_AMOUNT,TWDV_BF,CA_TRANSFER_VAL) VALUES (@RefNo,@YA,@CA_PURCHASE_AMOUNT,@TWDV_BF,@CA_TRANSFER_VAL)"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 30).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = YA
            SQLcmd.Parameters.Add("@CA_PURCHASE_AMOUNT", SqlDbType.NVarChar, 200).Value = CA_PURCHASE_AMOUNT
            SQLcmd.Parameters.Add("@TWDV_BF", SqlDbType.NVarChar, 200).Value = TWDV_BF
            SQLcmd.Parameters.Add("@CA_TRANSFER_VAL", SqlDbType.NVarChar, 200).Value = CA_TRANSFER_VAL


            Return ExecuteSQLCmd(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog, ReturnID)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function Save_Note(ByVal TitleFront As String, ByVal Title As String, ByVal RefNo As String, ByVal YA As String,
                              ByVal CA_ID As Integer, ByVal TypeNote As NoteType, ByVal Type_CA As Integer, ByVal Note As String, ByVal dtAttachment As DataTable,
                              ByVal dtColumn As DataTable, ByVal TagID As String,
                              ByRef ReturnID As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As Boolean
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "INSERT INTO CA_NOTE (Title,RefNo,YA,CA_ID,TypeNote,Note,TagID,Type_CA,TitleFront) VALUES (@Title,@RefNo,@YA,@CA_ID,@TypeNote,@Note,@TagID,@Type_CA,@TitleFront)"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@Title", SqlDbType.NVarChar, 250).Value = Title
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@CA_ID", SqlDbType.Int).Value = CA_ID
            SQLcmd.Parameters.Add("@TypeNote", SqlDbType.Int).Value = TypeNote
            SQLcmd.Parameters.Add("@Note", SqlDbType.NVarChar, 4000).Value = Note
            SQLcmd.Parameters.Add("@TagID", SqlDbType.NVarChar, 50).Value = TagID
            SQLcmd.Parameters.Add("@Type_CA", SqlDbType.Int).Value = Type_CA
            SQLcmd.Parameters.Add("@TitleFront", SqlDbType.NVarChar, 50).Value = TitleFront

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
                                StrSQL = "INSERT INTO CA_NOTE_ATTACHMENT(ParentID,Attachment,Extension) VALUES (@ParentID,@Attachment,@Extension)"
                                SQLcmd = New SqlCommand With {
                                    .CommandText = StrSQL
                                }
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
                                StrSQL = "INSERT INTO CA_NOTE_COLUMN(ParentID,Col1_Name,Col1_Val,Col2_Name,Col2_Val,Col3_Name,Col3_Val,Col4_Name,Col4_Val,Col5_Name,Col5_Val,Col6_Name,Col6_Val) VALUES (@ParentID,@Col1_Name,@Col1_Val,@Col2_Name,@Col2_Val,@Col3_Name,@Col3_Val,@Col4_Name,@Col4_Val,@Col5_Name,@Col5_Val,@Col6_Name,@Col6_Val)"
                                SQLcmd = New SqlCommand With {
                                    .CommandText = StrSQL
                                }
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

                If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
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
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function Update_Note_CA(ByVal ID As Integer, ByVal RefNo As String, ByVal YA As String, ByVal QC_BF As String,
                                  ByVal QC_ADD As String, ByVal QC_DISP As String, ByVal QC_CF As String,
                                  ByVal TWDV_BF As String, ByVal TWDV_ADD As String, ByVal TWDV_DISP As String,
                                  ByVal TWDV_TOTAL As String, ByVal TWDV_AI As String, ByVal TWDV_AA As String,
                                  ByVal TWDV_CF As String,
                                  Optional ByRef ErrorLog As ClsError = Nothing) As Boolean
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "UPDATE CA_REPORT_NOTE SET QC_BF=@QC_BF,QC_ADD=@QC_ADD,QC_DISP=@QC_DISP,QC_CF=@QC_CF,TWDV_BF=@TWDV_BF,TWDV_ADD=@TWDV_ADD,TWDV_DISP=@TWDV_DISP,TWDV_TOTAL=@TWDV_TOTAL,TWDV_AI=@TWDV_AI,TWDV_AA=@TWDV_AA,TWDV_CF=@TWDV_CF WHERE Refno=@RefNo AND YA=@YA AND ID=@ID"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 30).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = YA
            SQLcmd.Parameters.Add("@QC_BF", SqlDbType.NVarChar, 200).Value = QC_BF
            SQLcmd.Parameters.Add("@QC_ADD", SqlDbType.NVarChar, 200).Value = QC_ADD
            SQLcmd.Parameters.Add("@QC_DISP", SqlDbType.NVarChar, 200).Value = QC_DISP
            SQLcmd.Parameters.Add("@QC_CF", SqlDbType.NVarChar, 200).Value = QC_CF
            SQLcmd.Parameters.Add("@TWDV_BF", SqlDbType.NVarChar, 200).Value = TWDV_BF
            SQLcmd.Parameters.Add("@TWDV_ADD", SqlDbType.NVarChar, 200).Value = TWDV_ADD
            SQLcmd.Parameters.Add("@TWDV_DISP", SqlDbType.NVarChar, 200).Value = TWDV_DISP
            SQLcmd.Parameters.Add("@TWDV_TOTAL", SqlDbType.NVarChar, 200).Value = TWDV_TOTAL
            SQLcmd.Parameters.Add("@TWDV_AI", SqlDbType.NVarChar, 200).Value = TWDV_AI
            SQLcmd.Parameters.Add("@TWDV_AA", SqlDbType.NVarChar, 200).Value = TWDV_AA
            SQLcmd.Parameters.Add("@TWDV_CF", SqlDbType.NVarChar, 200).Value = TWDV_CF

            Return ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function Update_Note_HP(ByVal ID As Integer, ByVal RefNo As String, ByVal YA As Integer, ByVal BF_PRINCIPAL As String,
                                 ByVal BF_INTEREST As String, ByVal CURR_PRINCIPAL As String,
                                 ByVal CURR_INTEREST As String, ByVal CF_PRINCIPAL As String,
                                 ByVal CF_INTEREST As String,
                                 Optional ByRef ErrorLog As ClsError = Nothing) As Boolean
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "UPDATE HP_REPORT_NOTE SET BF_PRINCIPAL=@BF_PRINCIPAL,BF_INTEREST=@BF_INTEREST,CURR_PRINCIPAL=@CURR_PRINCIPAL,CURR_INTEREST=@CURR_INTEREST,CF_PRINCIPAL=@CF_PRINCIPAL,CF_INTEREST=@CF_INTEREST WHERE ID=@ID AND RefNo=@RefNo AND YA=@YA"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 30).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = YA
            SQLcmd.Parameters.Add("@BF_PRINCIPAL", SqlDbType.NVarChar, 200).Value = BF_PRINCIPAL
            SQLcmd.Parameters.Add("@BF_INTEREST", SqlDbType.NVarChar, 200).Value = BF_INTEREST
            SQLcmd.Parameters.Add("@CURR_PRINCIPAL", SqlDbType.NVarChar, 200).Value = CURR_PRINCIPAL
            SQLcmd.Parameters.Add("@CURR_INTEREST", SqlDbType.NVarChar, 200).Value = CURR_INTEREST
            SQLcmd.Parameters.Add("@CF_PRINCIPAL", SqlDbType.NVarChar, 200).Value = CF_PRINCIPAL
            SQLcmd.Parameters.Add("@CF_INTEREST", SqlDbType.NVarChar, 200).Value = CF_INTEREST

            Return ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function Update_Note_Disposal(ByVal ID As Decimal, ByVal RefNo As String, ByVal YA As Integer, ByVal Type As Integer,
                                       ByVal CA_QUALIFYING_COST As String,
                                       ByVal DISP_DEPRECIATION As String,
                                       ByVal DISP_WDV As String,
                                       ByVal DISP_DISPOSAL_VALUE As String,
                                       ByVal DISP_PNL As String,
                                       ByVal DISP_TWDV As String,
                                       ByVal DISP_BABC As String,
                                       Optional ByRef ErrorLog As ClsError = Nothing) As Boolean
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "UPDATE CA_REPORT_DISPOSAL_NOTE SET Type=@Type,CA_QUALIFYING_COST=@CA_QUALIFYING_COST,DISP_DEPRECIATION=@DISP_DEPRECIATION,DISP_WDV=@DISP_WDV,DISP_DISPOSAL_VALUE=@DISP_DISPOSAL_VALUE,DISP_PNL=@DISP_PNL,DISP_TWDV=@DISP_TWDV,DISP_BABC=@DISP_BABC WHERE RefNo=@RefNo AND YA=@YA AND ID=@ID"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 30).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = YA
            SQLcmd.Parameters.Add("@Type", SqlDbType.Int).Value = Type
            SQLcmd.Parameters.Add("@CA_QUALIFYING_COST", SqlDbType.NVarChar, 200).Value = CA_QUALIFYING_COST
            SQLcmd.Parameters.Add("@DISP_DEPRECIATION", SqlDbType.NVarChar, 200).Value = DISP_DEPRECIATION
            SQLcmd.Parameters.Add("@DISP_WDV", SqlDbType.NVarChar, 200).Value = DISP_WDV
            SQLcmd.Parameters.Add("@DISP_DISPOSAL_VALUE", SqlDbType.NVarChar, 200).Value = DISP_DISPOSAL_VALUE
            SQLcmd.Parameters.Add("@DISP_PNL", SqlDbType.NVarChar, 200).Value = DISP_PNL
            SQLcmd.Parameters.Add("@DISP_TWDV", SqlDbType.NVarChar, 200).Value = DISP_TWDV
            SQLcmd.Parameters.Add("@DISP_BABC", SqlDbType.NVarChar, 200).Value = DISP_BABC

            Return ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function Update_Note_ControlTransfer_IN(ByVal ID As Integer, ByVal RefNo As String, ByVal YA As Integer,
                                                 ByVal CA_PURCHASE_AMOUNT As String,
                                                 ByVal TWDV_BF As String,
                                                 ByVal CA_TRANSFER_VAL As String,
                                                 Optional ByRef ErrorLog As ClsError = Nothing) As Boolean
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "UPDATE CA_REPORT_CONTROLTRANSFER_NOTE SET CA_PURCHASE_AMOUNT=@CA_PURCHASE_AMOUNT,TWDV_BF=@TWDV_BF,CA_TRANSFER_VAL=@CA_TRANSFER_VAL WHERE ID=@ID AND RefNo=@RefNo AND YA=@YA"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 30).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.Int).Value = YA
            SQLcmd.Parameters.Add("@CA_PURCHASE_AMOUNT", SqlDbType.NVarChar, 200).Value = CA_PURCHASE_AMOUNT
            SQLcmd.Parameters.Add("@TWDV_BF", SqlDbType.NVarChar, 200).Value = TWDV_BF
            SQLcmd.Parameters.Add("@CA_TRANSFER_VAL", SqlDbType.NVarChar, 200).Value = CA_TRANSFER_VAL


            Return ExecuteSQLCmd_NOIDReturn(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function Update_Note(ByVal ID As Decimal, ByVal TitleFront As String, ByVal Title As String, ByVal RefNo As String, ByVal YA As String,
                              ByVal CA_ID As Integer, ByVal TypeNote As NoteType, ByVal Type_CA As Integer, ByVal Note As String,
                              ByVal dtAttachment As DataTable, ByVal dtColumn As DataTable, ByVal TagID As String,
                              Optional ByRef ErrorLog As ClsError = Nothing) As Boolean
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim ListofSQLCmd As New List(Of SqlCommand)
            Dim SQLcmd As SqlCommand

            Dim StrSQL As String = ""

            StrSQL = "DELETE CA_NOTE_ATTACHMENT WHERE ParentID=@ParentID"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@ParentID", SqlDbType.Decimal).Value = ID
            ListofSQLCmd.Add(SQLcmd)

            StrSQL = Nothing
            SQLcmd = Nothing

            StrSQL = "DELETE CA_NOTE_COLUMN WHERE ParentID=@ParentID"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@ParentID", SqlDbType.Decimal).Value = ID
            ListofSQLCmd.Add(SQLcmd)

            StrSQL = Nothing
            SQLcmd = Nothing

            StrSQL = "UPDATE CA_NOTE SET Title=@Title,RefNo=@RefNo,YA=@YA,CA_ID=@CA_ID,TypeNote=@TypeNote,Note=@Note,TagID=@TagID,Type_CA=@Type_CA,TitleFront=@TitleFront WHERE ID=@ID"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@ID", SqlDbType.Decimal).Value = ID
            SQLcmd.Parameters.Add("@Title", SqlDbType.NVarChar, 250).Value = Title
            SQLcmd.Parameters.Add("@RefNo", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@CA_ID", SqlDbType.Int).Value = CA_ID
            SQLcmd.Parameters.Add("@TypeNote", SqlDbType.Int).Value = TypeNote
            SQLcmd.Parameters.Add("@Note", SqlDbType.NVarChar, 4000).Value = Note
            SQLcmd.Parameters.Add("@TagID", SqlDbType.NVarChar, 50).Value = TagID
            SQLcmd.Parameters.Add("@Type_CA", SqlDbType.Int).Value = Type_CA
            SQLcmd.Parameters.Add("@TitleFront", SqlDbType.NVarChar, 50).Value = TitleFront


            ListofSQLCmd.Add(SQLcmd)

            Select Case TypeNote
                Case NoteType.ATTACHMENT

                    If dtAttachment IsNot Nothing Then

                        For Each rowx As DataRow In dtAttachment.Rows
                            StrSQL = Nothing
                            SQLcmd = Nothing
                            StrSQL = "INSERT INTO CA_NOTE_ATTACHMENT(ParentID,Attachment,Extension) VALUES (@ParentID,@Attachment,@Extension)"
                            SQLcmd = New SqlCommand With {
                                .CommandText = StrSQL
                            }
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
                            StrSQL = "INSERT INTO CA_NOTE_COLUMN(ParentID,Col1_Name,Col1_Val,Col2_Name,Col2_Val,Col3_Name,Col3_Val,Col4_Name,Col4_Val,Col5_Name,Col5_Val,Col6_Name,Col6_Val) VALUES (@ParentID,@Col1_Name,@Col1_Val,@Col2_Name,@Col2_Val,@Col3_Name,@Col3_Val,@Col4_Name,@Col4_Val,@Col5_Name,@Col5_Val,@Col6_Name,@Col6_Val)"
                            SQLcmd = New SqlCommand With {
                                .CommandText = StrSQL
                            }
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

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            If ListofSQLCmd IsNot Nothing AndAlso ListofSQLCmd.Count > 0 Then
                Return ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofSQLCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod.Name, ErrorLog)
            Else
                Return False
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function Delete_Note(ByVal ID As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As Boolean
        Try
            Dim ListofSQLCmd As New List(Of SqlCommand)
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection_CA(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If
            Dim StrSQL As String = Nothing
            Dim SQLcmd As SqlCommand = Nothing


            StrSQL = "DELETE CA_NOTE_ATTACHMENT WHERE ParentID=@ParentID"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@ParentID", SqlDbType.Decimal).Value = ID
            ListofSQLCmd.Add(SQLcmd)

            StrSQL = Nothing
            SQLcmd = Nothing

            StrSQL = "DELETE CA_NOTE_COLUMN WHERE ParentID=@ParentID"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@ParentID", SqlDbType.Decimal).Value = ID
            ListofSQLCmd.Add(SQLcmd)

            StrSQL = Nothing
            SQLcmd = Nothing

            StrSQL = "DELETE CA_NOTE WHERE ID=@ID"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@ID", SqlDbType.Decimal).Value = ID
            ListofSQLCmd.Add(SQLcmd)


            Return ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofSQLCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod.Name, ErrorLog)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New ClsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function

#End Region
End Class
