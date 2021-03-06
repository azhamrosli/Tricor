﻿Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Text
Imports System.Net.NetworkInformation
Imports System.IO
Imports Microsoft.Win32
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository
Public Class clsMovementNormal
    Inherits SQLDataObject

    Public Const TableName As String = "MOVEMENT_NORMAL"
    Public Const TableName_ADD As String = "MOVEMENT_ADD"
    Public Const TableName_Deduct As String = "MOVEMENT_DEDUCT"
    Sub New()

    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Public Sub ClearData(ByRef ds As DataSet)
        Try
            ds.Tables(TableName_ADD).Rows.Clear()
            ds.Tables(TableName_Deduct).Rows.Clear()
            ds.Tables(TableName).Rows.Clear()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Public Function LoadWordMovement(ByRef AutoSouce As AutoCompleteStringCollection, Optional ByRef ErrorLog As ClsError = Nothing) As Boolean
        Try
            Dim SqlCon As SqlConnection = Nothing
            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT TOP 1000 MM_Description FROM MOVEMENT_ADD UNION SELECT TOP 1000 MM_Description FROM MOVEMENT_DEDUCT"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }

            Dim dt As DataTable = Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing Then

                If AutoSouce Is Nothing Then
                    AutoSouce = New AutoCompleteStringCollection
                Else
                    AutoSouce.Clear()
                End If
                For Each row As DataRow In dt.Rows
                    AutoSouce.Add(row("MM_Description"))
                Next

                Return True
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

    Public Sub SearchListData(ByVal RefNo As String, ByVal YA As String, ByRef ds As DataSet, Optional ByRef ErrorLog As ClsError = Nothing)
        Try
            Dim dt As DataTable = Me.Load_MovementNormal_Search(RefNo, YA, ErrorLog)

            Me.ClearData(ds)
            If dt Is Nothing Then
                Exit Sub
            End If



            For i As Integer = 0 To dt.Rows.Count - 1
                ds.Tables(TableName).ImportRow(dt.Rows(i))
            Next
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
        End Try
    End Sub
    Public Sub StoreDataToDataset(ByVal ID As Integer, ByRef ds As DataSet, Optional ByRef ErrorLog As ClsError = Nothing)
        Try

            Dim dt As DataTable = Nothing
            dt = clsMoveNormal.Load_MovementNormal_Add(ID, ErrorLog)

            ds.Tables(TableName_ADD).Rows.Clear()
            If dt IsNot Nothing Then
                For Each rowx As DataRow In dt.Rows
                    '  rowx("MM_ID") = ds.Tables(TableName_ADD).Rows.Count + 1
                    ds.Tables(TableName_ADD).ImportRow(rowx)
                Next
            End If

            dt = clsMoveNormal.Load_MovementNormal_Deduct(ID, ErrorLog)

            ds.Tables(TableName_Deduct).Rows.Clear()
            If dt IsNot Nothing Then
                For Each rowx As DataRow In dt.Rows
                    ' rowx("MM_ID") = ds.Tables(TableName_Deduct).Rows.Count + 1
                    Application.DoEvents()
                    ds.Tables(TableName_Deduct).ImportRow(rowx)
                Next
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
        End Try
    End Sub
#Region "LOAD"
    Public Function Check_MovementNormal_TagID(ByVal MM_REFID As String, Optional ByRef ErrorLog As ClsError = Nothing) As Boolean
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT COUNT(*) as countx FROM MOVEMENT_NORMAL WHERE MM_REFID=@MM_REFID"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@MM_REFID", SqlDbType.NVarChar, 50).Value = MM_REFID

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("countx")) = False AndAlso dt.Rows(0)("countx") > 0 Then
                Return True
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
    Public Function Check_MovementNormalAdd_TagID(ByVal TagID As String, Optional ByRef ErrorLog As ClsError = Nothing) As Boolean
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT COUNT(*) as countx FROM MOVEMENT_ADD WHERE TagID=@TagID"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@TagID", SqlDbType.NVarChar, 50).Value = TagID

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("countx")) = False AndAlso dt.Rows(0)("countx") > 0 Then
                Return True
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
    Public Function Check_MovementNormalDeduct_TagID(ByVal TagID As String, Optional ByRef ErrorLog As ClsError = Nothing) As Boolean
        Try
            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT COUNT(*) as countx FROM MOVEMENT_DEDUCT WHERE TagID=@TagID"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@TagID", SqlDbType.NVarChar, 50).Value = TagID

            Dim dt As DataTable = ADO.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("countx")) = False AndAlso dt.Rows(0)("countx") > 0 Then
                Return True
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


    Public Function CheckExist_MovementNormal(ByVal MM_REFNO As String, ByVal MM_YA As String, Optional ByRef ErrorLog As ClsError = Nothing) As Boolean
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT COUNT(*) AS COUNTX FROM MOVEMENT_NORMAL WHERE MM_REFNO=@MM_REFNO AND MM_YA=@MM_YA"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@MM_REFNO", SqlDbType.NVarChar, 20).Value = MM_REFNO
            SQLcmd.Parameters.Add("@MM_YA", SqlDbType.NVarChar, 5).Value = MM_YA

            Dim dt As DataTable = Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("countx")) = False AndAlso dt.Rows(0)("countx") > 0 Then
                Return True
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
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With

            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function Load_MovementNormal_Search(ByVal RefNo As String, ByVal YA As String, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM MOVEMENT_NORMAL"
            Dim isWhere As Boolean = False
            SQLcmd = New SqlCommand

            If RefNo IsNot Nothing AndAlso RefNo <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE MM_REFNO=@MM_REFNO"
                Else
                    StrSQL += " AND MM_REFNO=@MM_REFNO"
                End If
                SQLcmd.Parameters.Add("@MM_REFNO", SqlDbType.NVarChar, 20).Value = RefNo
            End If

            If YA IsNot Nothing AndAlso YA <> "" Then
                If isWhere = False Then
                    isWhere = True
                    StrSQL += " WHERE MM_YA=@MM_YA"
                Else
                    StrSQL += " AND MM_YA=@MM_YA"
                End If
                SQLcmd.Parameters.Add("@MM_YA", SqlDbType.NVarChar, 5).Value = YA
            End If

            SQLcmd.CommandText = StrSQL
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
    Public Function Load_MovementNormal(ByVal ID As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM MOVEMENT_NORMAL WHERE MM_ID=@ID"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID

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
    Public Function Load_MovementNormal(ByVal RefNo As String, ByVal YA As String, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM MOVEMENT_NORMAL WHERE MM_REFNO=@MM_REFNO AND MM_YA=@MM_YA"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@MM_REFNO", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@MM_YA", SqlDbType.NVarChar, 5).Value = YA

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
    Public Function Load_MovementNormal_Add(ByVal ID As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM MOVEMENT_ADD WHERE MM_PARENTID=@ID ORDER BY MM_Sequence"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID

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
    Public Function Load_MovementComplex_Add(ByVal ID As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM MOVEMENT_COMPLEX_ADD WHERE MM_PARENTID=@ID ORDER BY MM_Sequence"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID

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
    Public Function Load_MovementNormal_Add(ByVal ID As Integer, ByVal MM_PARENTID As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM MOVEMENT_ADD WHERE MM_ID=@MM_ID AND MM_PARENTID=@MM_PARENTID ORDER BY MM_Sequence"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@MM_ID", SqlDbType.Int).Value = ID
            SQLcmd.Parameters.Add("@MM_PARENTID", SqlDbType.Int).Value = MM_PARENTID

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
    Public Function Load_MovementNormal_Deduct(ByVal ID As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM MOVEMENT_DEDUCT WHERE MM_PARENTID=@ID ORDER BY MM_Sequence"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID

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
    Public Function Load_MovementComplex_Deduct(ByVal ID As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM MOVEMENT_COMPLEX_DEDUCT WHERE MM_PARENTID=@ID ORDER BY MM_Sequence"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID

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
    Public Function Load_MovementNormal_Deduct(ByVal ID As Integer, ByVal MM_PARENTID As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As DataTable
        Try

            Dim SqlCon As SqlConnection = Nothing

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM MOVEMENT_DEDUCT WHERE MM_ID=@MM_ID AND MM_PARENTID=@MM_PARENTID ORDER BY MM_Sequence"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@MM_ID", SqlDbType.Int).Value = ID
            SQLcmd.Parameters.Add("@MM_PARENTID", SqlDbType.Int).Value = MM_PARENTID

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
#Region "SAVE"
    Public Function Save_MovementNormal(ByVal RefNo As String, ByVal YA As String, ByVal Title As String,
                                        ByVal TypeDate As String, ByVal YearEnded As DateTime,
                                        ByVal BalanceStart As DateTime, ByVal BalanceEnd As DateTime,
                                        ByVal AmountStart As Decimal, ByVal AmountEnd As Decimal,
                                        ByVal NoteStart As String, ByVal NoteEnd As String, ByVal Total_AddBackDeduct As Decimal,
                                        ByVal TypePass As Integer, ByVal SourceNO As Integer,
                                        ByVal ds As DataSet,
                                        ByRef ReturnID As Integer, Optional ByRef ErrorLog As ClsError = Nothing) As Boolean
        Try

            Dim SqlCon As SqlConnection = Nothing
            Dim tmpTagID As String = Nothing
            Dim ListofCmd As List(Of SqlCommand)
            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim tmpID As Decimal = 0

            tmpTagID = "MMN" & Format(Now, "ddMMMyyyyHHmmss") & RandomID(3)

            While Me.Check_MovementNormal_TagID(tmpTagID, ErrorLog)
                tmpTagID = "MMN" & Format(Now, "ddMMMyyyyHHmmss") & RandomID(3)
            End While

            Dim StrSQL As String = "INSERT INTO MOVEMENT_NORMAL (MM_REFNO,MM_YA,MM_TITLE,MM_TYPE,MM_YEAR_ENDED,MM_BALANCE_START,MM_BALANCE_END,MM_AMOUNT_START,MM_AMOUNT_END,MM_NOTE_START,MM_NOTE_END,ModifiedBy,ModifiedDateTime,MM_ADD_DEDUCT_AMOUNT,MM_TYPE_PASS,MM_SOURCENO,MM_REFID) VALUES (@MM_REFNO,@MM_YA,@MM_TITLE,@MM_TYPE,@MM_YEAR_ENDED,@MM_BALANCE_START,@MM_BALANCE_END,@MM_AMOUNT_START,@MM_AMOUNT_END,@MM_NOTE_START,@MM_NOTE_END,@ModifiedBy,@ModifiedDateTime,@MM_ADD_DEDUCT_AMOUNT,@MM_TYPE_PASS,@MM_SOURCENO,@MM_REFID)"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@MM_REFNO", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@MM_YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@MM_TITLE", SqlDbType.NVarChar, 250).Value = IIf(Title Is Nothing, "", Title)
            SQLcmd.Parameters.Add("@MM_TYPE", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(TypeDate), "", TypeDate)
            SQLcmd.Parameters.Add("@MM_YEAR_ENDED", SqlDbType.DateTime).Value = IIf(IsDBNull(YearEnded), Now, YearEnded)
            SQLcmd.Parameters.Add("@MM_BALANCE_START", SqlDbType.DateTime).Value = IIf(IsDBNull(BalanceStart), Now, BalanceStart)
            SQLcmd.Parameters.Add("@MM_BALANCE_END", SqlDbType.DateTime).Value = IIf(IsDBNull(BalanceEnd), Now, BalanceEnd)
            SQLcmd.Parameters.Add("@MM_AMOUNT_START", SqlDbType.Decimal).Value = IIf(IsNumeric(AmountStart) = False, 0, AmountStart)
            SQLcmd.Parameters.Add("@MM_AMOUNT_END", SqlDbType.Decimal).Value = IIf(IsNumeric(AmountEnd) = False, 0, AmountEnd)
            SQLcmd.Parameters.Add("@MM_NOTE_START", SqlDbType.NVarChar, 250).Value = IIf(NoteStart Is Nothing, "", NoteStart)
            SQLcmd.Parameters.Add("@MM_NOTE_END", SqlDbType.NVarChar, 250).Value = IIf(NoteEnd Is Nothing, "", NoteEnd)
            SQLcmd.Parameters.Add("@ModifiedBy", SqlDbType.NVarChar, 100).Value = My.Computer.Name
            SQLcmd.Parameters.Add("@ModifiedDateTime", SqlDbType.DateTime).Value = Now
            SQLcmd.Parameters.Add("@MM_ADD_DEDUCT_AMOUNT", SqlDbType.Decimal).Value = Total_AddBackDeduct
            SQLcmd.Parameters.Add("@MM_TYPE_PASS", SqlDbType.Int).Value = TypePass
            SQLcmd.Parameters.Add("@MM_SOURCENO", SqlDbType.Int).Value = SourceNO
            SQLcmd.Parameters.Add("@MM_REFID", SqlDbType.NVarChar, 50).Value = tmpTagID


            Me.ExecuteSQLCmd(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog, ReturnID)
            Application.DoEvents()
            tmpID = ReturnID

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            ListofCmd = New List(Of SqlCommand)
            If ds IsNot Nothing AndAlso ds.Tables(TableName_ADD).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(TableName_ADD).Rows.Count - 1
                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO MOVEMENT_ADD (MM_PARENTID,MM_Description,MM_Amount,MM_Sequence,MM_AddBack,MM_ADDBACK_AMOUNT,TagID) VALUES (@MM_PARENTID,@MM_Description,@MM_Amount,@MM_Sequence,@MM_AddBack,@MM_ADDBACK_AMOUNT,@TagID)"

                    SQLcmd = New SqlCommand With {
                        .CommandText = StrSQL
                    }

                    tmpTagID = "NMLADD" & Format(Now, "ddMMMyyyyHHmmss") & RandomID(3)

                    While Me.Check_MovementNormalAdd_TagID(tmpTagID, ErrorLog)
                        tmpTagID = "NMLADD" & Format(Now, "ddMMMyyyyHHmmss") & RandomID(3)
                    End While

                    SQLcmd.Parameters.Add("@MM_PARENTID", SqlDbType.Int).Value = tmpID
                    SQLcmd.Parameters.Add("@TagID", SqlDbType.NVarChar, 50).Value = tmpTagID
                    SQLcmd.Parameters.Add("@MM_Description", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(ds.Tables(TableName_ADD).Rows(i)("MM_Description")), "", ds.Tables(TableName_ADD).Rows(i)("MM_Description"))
                    SQLcmd.Parameters.Add("@MM_Amount", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables(TableName_ADD).Rows(i)("MM_Amount")), 0, ds.Tables(TableName_ADD).Rows(i)("MM_Amount"))
                    SQLcmd.Parameters.Add("@MM_Sequence", SqlDbType.Int).Value = i
                    SQLcmd.Parameters.Add("@MM_AddBack", SqlDbType.Bit).Value = IIf(IsDBNull(ds.Tables(TableName_ADD).Rows(i)("MM_AddBack")), False, ds.Tables(TableName_ADD).Rows(i)("MM_AddBack"))
                    SQLcmd.Parameters.Add("@MM_ADDBACK_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables(TableName_ADD).Rows(i)("MM_ADDBACK_AMOUNT")), 0, ds.Tables(TableName_ADD).Rows(i)("MM_ADDBACK_AMOUNT"))
                    ListofCmd.Add(SQLcmd)
                Next
            End If
            If ds IsNot Nothing AndAlso ds.Tables(TableName_Deduct).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(TableName_Deduct).Rows.Count - 1
                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO MOVEMENT_DEDUCT (MM_PARENTID,MM_Description,MM_Amount,MM_Sequence,MM_Deduct,MM_DEDUCT_AMOUNT,TagID) VALUES (@MM_PARENTID,@MM_Description,@MM_Amount,@MM_Sequence,@MM_Deduct,@MM_DEDUCT_AMOUNT,@TagID)"

                    SQLcmd = New SqlCommand With {
                        .CommandText = StrSQL
                    }

                    tmpTagID = "NMLLES" & Format(Now, "ddMMMyyyyHHmmss") & RandomID(3)

                    While Me.Check_MovementNormalDeduct_TagID(tmpTagID, ErrorLog)
                        tmpTagID = "NMLLES" & Format(Now, "ddMMMyyyyHHmmss") & RandomID(3)
                    End While

                    SQLcmd.Parameters.Add("@MM_PARENTID", SqlDbType.Int).Value = tmpID
                    SQLcmd.Parameters.Add("@TagID", SqlDbType.NVarChar, 50).Value = tmpTagID
                    SQLcmd.Parameters.Add("@MM_Description", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(ds.Tables(TableName_Deduct).Rows(i)("MM_Description")), "", ds.Tables(TableName_Deduct).Rows(i)("MM_Description"))
                    SQLcmd.Parameters.Add("@MM_Amount", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables(TableName_Deduct).Rows(i)("MM_Amount")), 0, ds.Tables(TableName_Deduct).Rows(i)("MM_Amount"))
                    SQLcmd.Parameters.Add("@MM_Sequence", SqlDbType.Int).Value = i
                    SQLcmd.Parameters.Add("@MM_Deduct", SqlDbType.Bit).Value = IIf(IsDBNull(ds.Tables(TableName_Deduct).Rows(i)("MM_Deduct")), False, ds.Tables(TableName_Deduct).Rows(i)("MM_Deduct"))
                    SQLcmd.Parameters.Add("@MM_DEDUCT_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables(TableName_Deduct).Rows(i)("MM_DEDUCT_AMOUNT")), 0, ds.Tables(TableName_Deduct).Rows(i)("MM_DEDUCT_AMOUNT"))

                    ListofCmd.Add(SQLcmd)
                Next
            End If

            If ListofCmd.Count > 0 Then
                Return Me.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
            Else
                Return True
            End If
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
            Return False
        End Try
    End Function
#End Region
#Region "UPDATE"
    Public Function Update_MovementNormal(ByVal ID As Integer, ByVal RefNo As String, ByVal YA As String, ByVal Title As String,
                                      ByVal TypeDate As String, ByVal YearEnded As DateTime,
                                      ByVal BalanceStart As DateTime, ByVal BalanceEnd As DateTime,
                                      ByVal AmountStart As Decimal, ByVal AmountEnd As Decimal,
                                      ByVal NoteStart As String, ByVal NoteEnd As String, ByVal Total_AddbackDeduct As Decimal,
                                      ByVal TypePass As Integer, ByVal SourceNO As Integer, ByVal MM_REFID As String,
                                      ByVal ds As DataSet, Optional ByRef ErrorLog As ClsError = Nothing) As Boolean
        Try

            Dim SqlCon As SqlConnection = Nothing
            Dim ListofCmd As List(Of SqlCommand)
            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim tmpTagID As String = Nothing
            Dim tmpID As Decimal = 0
            ListofCmd = New List(Of SqlCommand)


            If MM_REFID Is Nothing OrElse MM_REFID = "" Then
                tmpTagID = "MMN" & Format(Now, "ddMMMyyyyHHmmss") & RandomID(3)

                While Me.Check_MovementNormal_TagID(tmpTagID, ErrorLog)
                    tmpTagID = "MMN" & Format(Now, "ddMMMyyyyHHmmss") & RandomID(3)
                End While
            Else
                tmpTagID = MM_REFID
            End If

            Dim StrSQL As String = "UPDATE MOVEMENT_NORMAL SET MM_REFNO=@MM_REFNO,MM_YA=@MM_YA,MM_TITLE=@MM_TITLE,MM_TYPE=@MM_TYPE,MM_YEAR_ENDED=@MM_YEAR_ENDED,MM_BALANCE_START=@MM_BALANCE_START,MM_BALANCE_END=@MM_BALANCE_END,MM_AMOUNT_START=@MM_AMOUNT_START,MM_AMOUNT_END=@MM_AMOUNT_END,MM_NOTE_START=@MM_NOTE_START,MM_NOTE_END=@MM_NOTE_END,ModifiedBy=@ModifiedBy,ModifiedDateTime=@ModifiedDateTime,MM_ADD_DEDUCT_AMOUNT=@MM_ADD_DEDUCT_AMOUNT,MM_TYPE_PASS=@MM_TYPE_PASS,MM_SOURCENO=@MM_SOURCENO,MM_REFID=@MM_REFID WHERE MM_ID=@MM_ID"

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@MM_ID", SqlDbType.Int).Value = ID
            SQLcmd.Parameters.Add("@MM_REFNO", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@MM_YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@MM_TITLE", SqlDbType.NVarChar, 250).Value = IIf(Title Is Nothing, "", Title)
            SQLcmd.Parameters.Add("@MM_TYPE", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(TypeDate), "", TypeDate)
            SQLcmd.Parameters.Add("@MM_YEAR_ENDED", SqlDbType.DateTime).Value = IIf(IsDBNull(YearEnded), Now, YearEnded)
            SQLcmd.Parameters.Add("@MM_BALANCE_START", SqlDbType.DateTime).Value = IIf(IsDBNull(BalanceStart), Now, BalanceStart)
            SQLcmd.Parameters.Add("@MM_BALANCE_END", SqlDbType.DateTime).Value = IIf(IsDBNull(BalanceEnd), Now, BalanceEnd)
            SQLcmd.Parameters.Add("@MM_AMOUNT_START", SqlDbType.Decimal).Value = IIf(IsNumeric(AmountStart) = False, 0, AmountStart)
            SQLcmd.Parameters.Add("@MM_AMOUNT_END", SqlDbType.Decimal).Value = IIf(IsNumeric(AmountEnd) = False, 0, AmountEnd)
            SQLcmd.Parameters.Add("@MM_NOTE_START", SqlDbType.NVarChar, 250).Value = IIf(NoteStart Is Nothing, "", NoteStart)
            SQLcmd.Parameters.Add("@MM_NOTE_END", SqlDbType.NVarChar, 250).Value = IIf(NoteEnd Is Nothing, "", NoteEnd)
            SQLcmd.Parameters.Add("@ModifiedBy", SqlDbType.NVarChar, 100).Value = My.Computer.Name
            SQLcmd.Parameters.Add("@ModifiedDateTime", SqlDbType.DateTime).Value = Now
            SQLcmd.Parameters.Add("@MM_ADD_DEDUCT_AMOUNT", SqlDbType.Decimal).Value = Total_AddbackDeduct
            SQLcmd.Parameters.Add("@MM_TYPE_PASS", SqlDbType.Int).Value = TypePass
            SQLcmd.Parameters.Add("@MM_SOURCENO", SqlDbType.Int).Value = SourceNO
            SQLcmd.Parameters.Add("@MM_REFID", SqlDbType.NVarChar, 50).Value = tmpTagID

            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE MOVEMENT_ADD WHERE MM_PARENTID=@MM_ID"

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@MM_ID", SqlDbType.Int).Value = ID
            ListofCmd.Add(SQLcmd)

            StrSQL = "DELETE MOVEMENT_DEDUCT WHERE MM_PARENTID=@MM_ID"

            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@MM_ID", SqlDbType.Int).Value = ID
            ListofCmd.Add(SQLcmd)

            If ds IsNot Nothing AndAlso ds.Tables(TableName_ADD).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(TableName_ADD).Rows.Count - 1
                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO MOVEMENT_ADD (MM_PARENTID,MM_Description,MM_Amount,MM_Sequence,MM_AddBack,MM_ADDBACK_AMOUNT,TagID) VALUES (@MM_PARENTID,@MM_Description,@MM_Amount,@MM_Sequence,@MM_AddBack,@MM_ADDBACK_AMOUNT,@TagID)"

                    SQLcmd = New SqlCommand With {
                        .CommandText = StrSQL
                    }


                    If IsDBNull(ds.Tables(TableName_ADD).Rows(i)("TagID")) OrElse ds.Tables(TableName_ADD).Rows(i)("TagID") Is Nothing Then
                        tmpTagID = "NMLADD" & Format(Now, "ddMMMyyyyHHmmss") & RandomID(3)

                        While Me.Check_MovementNormalAdd_TagID(tmpTagID, ErrorLog)
                            tmpTagID = "NMLADD" & Format(Now, "ddMMMyyyyHHmmss") & RandomID(3)
                        End While
                    Else
                        tmpTagID = ds.Tables(TableName_ADD).Rows(i)("TagID")
                    End If

                    SQLcmd.Parameters.Add("@MM_PARENTID", SqlDbType.Int).Value = ID
                    SQLcmd.Parameters.Add("@TagID", SqlDbType.NVarChar, 50).Value = tmpTagID
                    SQLcmd.Parameters.Add("@MM_Description", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(ds.Tables(TableName_ADD).Rows(i)("MM_Description")), "", ds.Tables(TableName_ADD).Rows(i)("MM_Description"))
                    SQLcmd.Parameters.Add("@MM_Amount", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables(TableName_ADD).Rows(i)("MM_Amount")), 0, ds.Tables(TableName_ADD).Rows(i)("MM_Amount"))
                    SQLcmd.Parameters.Add("@MM_Sequence", SqlDbType.Int).Value = i
                    SQLcmd.Parameters.Add("@MM_AddBack", SqlDbType.Bit).Value = IIf(IsDBNull(ds.Tables(TableName_ADD).Rows(i)("MM_AddBack")), False, ds.Tables(TableName_ADD).Rows(i)("MM_AddBack"))
                    SQLcmd.Parameters.Add("@MM_ADDBACK_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables(TableName_ADD).Rows(i)("MM_ADDBACK_AMOUNT")), 0, ds.Tables(TableName_ADD).Rows(i)("MM_ADDBACK_AMOUNT"))
                    ListofCmd.Add(SQLcmd)
                Next
            End If
            If ds IsNot Nothing AndAlso ds.Tables(TableName_Deduct).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(TableName_Deduct).Rows.Count - 1
                    SQLcmd = Nothing
                    StrSQL = "INSERT INTO MOVEMENT_DEDUCT (MM_PARENTID,MM_Description,MM_Amount,MM_Sequence,MM_Deduct,MM_DEDUCT_AMOUNT,TagID) VALUES (@MM_PARENTID,@MM_Description,@MM_Amount,@MM_Sequence,@MM_Deduct,@MM_DEDUCT_AMOUNT,@TagID)"

                    SQLcmd = New SqlCommand With {
                        .CommandText = StrSQL
                    }

                    If IsDBNull(ds.Tables(TableName_Deduct).Rows(i)("TagID")) OrElse ds.Tables(TableName_Deduct).Rows(i)("TagID") Is Nothing Then
                        tmpTagID = "NMLLES" & Format(Now, "ddMMMyyyyHHmmss") & RandomID(3)

                        While Me.Check_MovementNormalDeduct_TagID(tmpTagID, ErrorLog)
                            tmpTagID = "NMLLES" & Format(Now, "ddMMMyyyyHHmmss") & RandomID(3)
                        End While
                    Else
                        tmpTagID = ds.Tables(TableName_Deduct).Rows(i)("TagID")
                    End If

                    SQLcmd.Parameters.Add("@MM_PARENTID", SqlDbType.Int).Value = ID
                    SQLcmd.Parameters.Add("@TagID", SqlDbType.NVarChar, 50).Value = tmpTagID
                    SQLcmd.Parameters.Add("@MM_Description", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(ds.Tables(TableName_Deduct).Rows(i)("MM_Description")), "", ds.Tables(TableName_Deduct).Rows(i)("MM_Description"))
                    SQLcmd.Parameters.Add("@MM_Amount", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables(TableName_Deduct).Rows(i)("MM_Amount")), 0, ds.Tables(TableName_Deduct).Rows(i)("MM_Amount"))
                    SQLcmd.Parameters.Add("@MM_Sequence", SqlDbType.Int).Value = i
                    SQLcmd.Parameters.Add("@MM_Deduct", SqlDbType.Bit).Value = IIf(IsDBNull(ds.Tables(TableName_Deduct).Rows(i)("MM_Deduct")), False, ds.Tables(TableName_Deduct).Rows(i)("MM_Deduct"))
                    SQLcmd.Parameters.Add("@MM_DEDUCT_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(ds.Tables(TableName_Deduct).Rows(i)("MM_DEDUCT_AMOUNT")), 0, ds.Tables(TableName_Deduct).Rows(i)("MM_DEDUCT_AMOUNT"))

                    ListofCmd.Add(SQLcmd)
                Next
            End If

            If ListofCmd.Count > 0 Then
                Return Me.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
            Else
                Return True
            End If
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
            Return False
        End Try
    End Function
#End Region
#Region "DELETE"
    Public Function Delete_MovementNormal(ByVal MM_ID As Integer, ByVal RefNo As String, ByVal YA As String, Optional ByRef ErrorLog As ClsError = Nothing) As Boolean
        Try

            Dim SqlCon As SqlConnection = Nothing
            Dim ListofCmd As List(Of SqlCommand)
            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If
            ListofCmd = New List(Of SqlCommand)
            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "DELETE FROM MOVEMENT_NORMAL WHERE MM_ID=@MM_ID"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@MM_ID", SqlDbType.Int).Value = MM_ID

            ListofCmd.Add(SQLcmd)

            SQLcmd = Nothing
            StrSQL = "DELETE FROM MOVEMENT_ADD WHERE MM_PARENTID=@MM_PARENTID"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@MM_PARENTID", SqlDbType.Int).Value = MM_ID
            ListofCmd.Add(SQLcmd)


            SQLcmd = Nothing
            StrSQL = "DELETE FROM MOVEMENT_DEDUCT WHERE MM_PARENTID=@MM_PARENTID"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@MM_PARENTID", SqlDbType.Int).Value = MM_ID
            ListofCmd.Add(SQLcmd)

            SQLcmd = Nothing
            StrSQL = "DELETE FROM TAXABLE_INCOME WHERE TI_REF_NO=@TI_REF_NO AND TI_YA=@TI_YA AND TI_TYPE=@TI_TYPE"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@TI_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@TI_YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@TI_TYPE", SqlDbType.Int).Value = MM_ID
            ListofCmd.Add(SQLcmd)

            SQLcmd = Nothing
            StrSQL = "DELETE FROM REVENUE_EXPENDITURE WHERE RE_REF_NO=@RE_REF_NO AND RE_YA=@RE_YA AND RE_TYPE=@RE_TYPE"
            SQLcmd = New SqlCommand With {
                .CommandText = StrSQL
            }
            SQLcmd.Parameters.Add("@RE_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@RE_YA", SqlDbType.NVarChar, 5).Value = YA
            SQLcmd.Parameters.Add("@RE_TYPE", SqlDbType.Int).Value = MM_ID
            ListofCmd.Add(SQLcmd)

            Return Me.ExecuteSQLTransactionBySQLCommand_NOReturnID(ListofCmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)


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
            Return False
        End Try
    End Function
#End Region
#Region "CALCULATION"
    Public Sub CalcVal(ByRef ds As DataSet, ByRef AmountStart As Decimal, ByRef AmountEnd As Decimal, ByRef TotalAmountAddDeduct As Decimal)
        Try
            Dim Total As Decimal = 0
            Dim TotalAddBackDeduct As Decimal = 0
            If IsNumeric(AmountStart) = True Then
                Total += CDec(AmountStart)
            End If


            If ds.Tables(TableName_ADD) IsNot Nothing AndAlso ds.Tables(TableName_ADD).Rows.Count > 0 Then
                For Each rowx As DataRow In ds.Tables(TableName_ADD).Rows
                    If rowx.RowState <> DataRowState.Deleted AndAlso IsDBNull(rowx("MM_Amount")) = False Then
                        Total += CDec(rowx("MM_Amount"))
                        TotalAddBackDeduct += CDec(IIf(IsDBNull(rowx("MM_ADDBACK_AMOUNT")), 0, rowx("MM_ADDBACK_AMOUNT")))
                    End If
                Next
            End If

            If ds.Tables(TableName_Deduct) IsNot Nothing AndAlso ds.Tables(TableName_Deduct).Rows.Count > 0 Then
                For Each rowx As DataRow In ds.Tables(TableName_Deduct).Rows
                    If rowx.RowState <> DataRowState.Deleted AndAlso IsDBNull(rowx("MM_Amount")) = False Then
                        Total -= CDec(rowx("MM_Amount"))
                        TotalAddBackDeduct -= CDec(IIf(IsDBNull(rowx("MM_DEDUCT_AMOUNT")), 0, rowx("MM_DEDUCT_AMOUNT")))
                    End If
                Next
            End If

            AmountEnd = Total
            TotalAmountAddDeduct = TotalAddBackDeduct
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            AmountEnd = 0
        End Try
    End Sub
#End Region
End Class
