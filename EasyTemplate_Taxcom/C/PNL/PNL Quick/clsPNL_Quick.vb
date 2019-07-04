Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports DevExpress.XtraGrid
Imports org.mariuszgromada.math.mxparser
Imports System.Data.OleDb

Public Class clsPNL_Quick
    Public Property dsDataset As DataSet
    Public Property RefNo As String = ""
    Public Property YA As String = ""
    Public Property isS60F As Boolean = False
    Public Property isS60FA As Boolean = False
    Public Property Ai_Testing_Require As Boolean = False

    Private Property Errorlog As ClsError
    Private Property Status As EnumStatus = EnumStatus.Ready
    Private dtRow As DataRow = Nothing
    Private dtRowChild As DataRow = Nothing

    Public Event OnChangeStatus(Status_ As EnumStatus, Errorlog_ As ClsError)
    Public Event OnChangeInfo(dsDataset_ As DataSet, Errorlog_ As ClsError)
    Public Event OnChangeData(KeyName_ As String, dtRow_ As DataRow, Errorlog_ As ClsError)
    Public Event OnSchangeSaveStatus(Status_ As EnumStatus, Errorlog_ As ClsError)
    Public Event OnProgress(Current_ As Integer, Total_ As Integer, strSQL As String)
    Enum EnumStatus
        Ready = 0
        InProgress = 1
        Done = 2
        Failed = 3
    End Enum
    Enum EnumTypeCategory
        NoDeduct_1 = 1
        WithOutPercentage_2 = 2
        Percentage_3 = 3
    End Enum
    Sub New()
        If Me.dsDataset Is Nothing Then
            Me.dsDataset = New dsPNL
        End If
        If Errorlog Is Nothing Then
            Errorlog = New ClsError
        End If
    End Sub
    ''' <summary>
    ''' Init_QuickPNL initialize PNL Quick - Step 1
    ''' </summary>
    Public Sub Init_QuickPNL()
        Try
            ChangeStatus(EnumStatus.InProgress)
            Dim dtInfo As DataTable = ADO.Load_PNLINFO

            If dtInfo Is Nothing Then
                With Errorlog
                    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                    .ErrorCode = "A001"
                    .ErrorDateTime = Now
                    .ErrorMessage = "No PNL Info found."
                End With
                ChangeStatus(EnumStatus.Failed)
                Exit Sub
            End If

            'Put PNL info in Dataset
            For Each rowInfo As DataRow In dtInfo.Rows
                If IsDBNull(rowInfo("KeyName")) = False Then
                    Me.dsDataset.Tables("PNL_TABLE_INFO").ImportRow(rowInfo)

                    If isVersionLicenseType = VersionLicenseType.Tricor AndAlso IsDBNull(rowInfo("LabelNameTricor")) = False AndAlso rowInfo("LabelNameTricor") <> "" Then
                        dtRow = Me.dsDataset.Tables("PNL_QUICK").NewRow
                        dtRow("KEYNAME") = rowInfo("KeyName")
                        dtRow("DESCRIPTION") = IIf(IsDBNull(rowInfo("LabelNameTricor")), "", rowInfo("LabelNameTricor"))
                        dtRow("AMOUNT") = 0
                        Me.dsDataset.Tables("PNL_QUICK").Rows.Add(dtRow)
                    ElseIf isVersionLicenseType = VersionLicenseType.Normal AndAlso IsDBNull(rowInfo("LabelName")) = False AndAlso rowInfo("LabelName") <> "" Then
                        dtRow = Me.dsDataset.Tables("PNL_QUICK").NewRow
                        dtRow("KEYNAME") = rowInfo("KeyName")
                        dtRow("DESCRIPTION") = IIf(IsDBNull(rowInfo("LabelName")), "", rowInfo("LabelName"))
                        dtRow("AMOUNT") = 0
                        Me.dsDataset.Tables("PNL_QUICK").Rows.Add(dtRow)
                    End If
                End If
            Next

            Dim dtInfoMain As DataTable = ADO.Load_PNLINFO_MAIN

            If dtInfoMain Is Nothing Then
                With Errorlog
                    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                    .ErrorCode = "A001"
                    .ErrorDateTime = Now
                    .ErrorMessage = "No PNL Info Main found."
                End With
                ChangeStatus(EnumStatus.Failed)
                Exit Sub
            End If
            'Put PNL info main in Dataset
            For Each rowInfo As DataRow In dtInfoMain.Rows
                If IsDBNull(rowInfo("KeyName")) = False Then
                    Me.dsDataset.Tables("PNL_TABLE_INFO_MAIN").ImportRow(rowInfo)
                    Me.dsDataset.Tables("PNL_TABLE_INFO_MAIN_DEFAULT").ImportRow(rowInfo)
                End If
            Next

            mdlProcess.CreateLookUpSourceNO(Me.dsDataset, RefNo, YA, "BUSINESS_SOURCE", Errorlog)

            RaiseEvent OnChangeInfo(Me.dsDataset, Errorlog)
            ChangeStatus(EnumStatus.Done)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(Errorlog)
            ChangeStatus(EnumStatus.Failed)
        Finally
            Ai_Testing()
        End Try
    End Sub
    Private Function Find_KeyName(ByVal KeyName As String) As DataRow
        Try
            If KeyName Is Nothing OrElse KeyName = "" Then
                Return Nothing
            End If

            For Each rowInfo As DataRow In Me.dsDataset.Tables("PNL_TABLE_INFO").Rows
                If IsDBNull(rowInfo("KeyName")) = False AndAlso rowInfo("KeyName") = KeyName Then
                    Return rowInfo
                End If
            Next

            Return Nothing
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(Errorlog)
            Return Nothing
        End Try
    End Function
#Region "STYLE & VALIDATION GRID"
    ''' <summary>
    ''' Row_Updated update calculation for parent and insert keyname and source no to child
    ''' Please make sure you edit GRIDVIEW NAME to gv_Parent !!!!!!!!!!
    ''' </summary>
    Public Sub Row_Updated(ByRef view As DevExpress.XtraGrid.Views.Grid.GridView, ByRef e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs)
        Try
            ChangeStatus(EnumStatus.InProgress)

            Dim Total As Decimal = 0
            Dim PercentageAmount As Decimal = 0
            Dim TotalPercentage As Decimal = 0
            For Each rowParent As DataRow In Me.dsDataset.Tables("PNL_QUICK_DETAIL").Rows
                Total = 0
                TotalPercentage = 0
                For Each rowx As DataRow In Me.dsDataset.Tables("PNL_QUICK_DETAIL_SUB").Rows


                    If IsDBNull(rowParent("ID")) = False AndAlso IsDBNull(rowx("PARENT_ID")) = False Then

                        If rowParent("ID") = rowx("PARENT_ID") Then
                            If IsDBNull(rowx("AMOUNT")) = False Then
                                Total += rowx("AMOUNT")
                            End If

                            If IsDBNull(rowx("AMOUNT")) = False AndAlso IsDBNull(rowx("PECENTAGE")) = False AndAlso rowx("PECENTAGE") <> 0 Then
                                PercentageAmount = (CDec(rowx("PECENTAGE")) / 100) * CDec(rowx("AMOUNT"))
                                rowx("PECENTAGE_AMOUNT") = PercentageAmount
                                Application.DoEvents()
                            End If

                            If IsDBNull(rowx("PECENTAGE_AMOUNT")) = False Then
                                TotalPercentage += rowx("PECENTAGE_AMOUNT")
                            End If

                            rowx("SOURCE_NO") = rowParent("SOURCE_NO")
                            rowx("KEYNAME") = rowParent("KEYNAME")
                            rowParent("AMOUNT") = Total
                            rowParent("PECENTAGE_AMOUNT") = TotalPercentage
                        End If
                    End If

                Next



            Next
            Me.Calculate_CategoryTotal()
            ChangeStatus(EnumStatus.Done)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(Errorlog)
            ChangeStatus(EnumStatus.Failed)

        End Try
    End Sub
    ''' <summary>
    ''' Row_CellStyle initialize column color to gray if disble for that keyname
    ''' Please make sure you edit GRIDVIEW NAME to gv_Parent !!!!!!!!!!
    ''' </summary>
    Public Sub Row_CellStyle(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView, ByRef e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        Try
            ChangeStatus(EnumStatus.InProgress)
            Dim row As DataRow = view.GetDataRow(view.FocusedRowHandle)
            Dim KeyName As String = ""
            Dim Type As EnumTypeCategory = EnumTypeCategory.NoDeduct_1
            If row IsNot Nothing Then
                KeyName = IIf(IsDBNull(row("KeyName")), "", row("KeyName"))
                Dim dtInfo As DataRow = Me.Find_KeyName(KeyName)

                If dtInfo Is Nothing Then
                    With Errorlog
                        .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                        .ErrorCode = "A001"
                        .ErrorDateTime = Now
                        .ErrorMessage = "No PNL Info found."
                    End With
                    ChangeStatus(EnumStatus.Failed)
                    Exit Sub
                End If
                Type = IIf(IsDBNull(dtInfo("Type")), 0, dtInfo("Type"))
                Select Case Type
                    Case EnumTypeCategory.NoDeduct_1
                        If e.Column.FieldName = "DEDUCTIBLE" Then
                            e.Appearance.BackColor = Color.Gray
                        End If
                        If e.Column.FieldName = "DEDUCTIBLE_ADD" Then
                            e.Appearance.BackColor = Color.Gray
                        End If
                        If e.Column.FieldName = "PECENTAGE" Then
                            e.Appearance.BackColor = Color.Gray
                        End If
                        If e.Column.FieldName = "PECENTAGE_AMOUNT" Then
                            e.Appearance.BackColor = Color.Gray
                        End If
                    Case EnumTypeCategory.WithOutPercentage_2

                End Select
            End If

            ChangeStatus(EnumStatus.Done)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(Errorlog)
            ChangeStatus(EnumStatus.Failed)
        End Try
    End Sub
    ''' <summary>
    ''' Allow_ShowingEditor initialize row can edit or not
    ''' Please make sure you edit GRIDVIEW NAME to gv_Parent !!!!!!!!!!
    ''' </summary>
    Public Sub Allow_ShowingEditor(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView, ByRef e As System.ComponentModel.CancelEventArgs)
        Try
            ChangeStatus(EnumStatus.InProgress)

            If view Is Nothing Then
                With Errorlog
                    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                    .ErrorCode = "A001"
                    .ErrorDateTime = Now
                    .ErrorMessage = "Grid is empty."
                End With
                ChangeStatus(EnumStatus.Failed)
                Exit Sub
            End If


            Dim Type As EnumTypeCategory = EnumTypeCategory.NoDeduct_1
            Dim row As DataRow = view.GetDataRow(view.FocusedRowHandle)
            Dim KeyName As String = ""
            If row IsNot Nothing Then
                KeyName = IIf(IsDBNull(row("KeyName")), "", row("KeyName"))
                Dim dtInfo As DataRow = Me.Find_KeyName(KeyName)

                If dtInfo Is Nothing Then
                    With Errorlog
                        .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                        .ErrorCode = "A001"
                        .ErrorDateTime = Now
                        .ErrorMessage = "No PNL Info found."
                    End With
                    ChangeStatus(EnumStatus.Failed)
                    Exit Sub
                End If
                Type = IIf(IsDBNull(dtInfo("Type")), 0, dtInfo("Type"))
                Select Case Type
                    Case EnumTypeCategory.WithOutPercentage_2
                        Select Case KeyName
                            Case "PURCHASE", "DEPRECIATION", "OTHERALLOWEXP", "OTHERNONALLOWEXP"
                                If view.FocusedColumn.FieldName = "DEDUCTIBLE_ADD" Then
                                    e.Cancel = True
                                End If
                                If view.FocusedColumn.FieldName = "PECENTAGE" Then
                                    e.Cancel = True
                                End If
                                If view.FocusedColumn.FieldName = "PECENTAGE_AMOUNT" Then
                                    e.Cancel = True
                                End If
                            Case Else
                                If view.FocusedColumn.FieldName = "PECENTAGE" Then
                                    e.Cancel = True
                                End If
                                If view.FocusedColumn.FieldName = "PECENTAGE_AMOUNT" Then
                                    e.Cancel = True
                                End If
                        End Select
                    Case EnumTypeCategory.Percentage_3
                    Case EnumTypeCategory.NoDeduct_1
                        If view.FocusedColumn.FieldName = "DEDUCTIBLE" Then
                            e.Cancel = True
                        End If
                        If view.FocusedColumn.FieldName = "DEDUCTIBLE_ADD" Then
                            e.Cancel = True
                        End If
                        If view.FocusedColumn.FieldName = "PECENTAGE" Then
                            e.Cancel = True
                        End If
                        If view.FocusedColumn.FieldName = "PECENTAGE_AMOUNT" Then
                            e.Cancel = True
                        End If
                    Case Else
                End Select

                'Protection from edit after have child inside
                If view.Name = "gv_Parent" Then
                    Dim Count As Integer = 0
                    'If view.FocusedColumn.FieldName = "AMOUNT" Then

                    For Each rowItem As DataRow In Me.dsDataset.Tables("PNL_QUICK_DETAIL_SUB").Rows

                        If rowItem("PARENT_ID") = row("ID") Then
                            Count += 1
                        End If

                    Next

                    If Count > 0 Then
                        e.Cancel = True
                    End If
                    'End If
                End If
            End If


            ChangeStatus(EnumStatus.Done)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(Errorlog)
            ChangeStatus(EnumStatus.Failed)
        End Try
    End Sub
    ''' <summary>
    ''' Init_NewRow initialize row put information about parent
    ''' Please make sure you edit GRIDVIEW NAME to gv_Parent !!!!!!!!!!
    ''' </summary>
    Public Sub Init_NewRow(ByVal viewParent As DevExpress.XtraGrid.Views.Grid.GridView, ByVal viewChild As DevExpress.XtraGrid.Views.Grid.GridView, ByRef e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
        Try
            ChangeStatus(EnumStatus.InProgress)

            viewChild.GetDataRow(e.RowHandle)("KEYNAME") = viewParent.GetRowCellValue(viewParent.FocusedRowHandle, "KEYNAME")
            viewChild.GetDataRow(e.RowHandle)("SOURCE_NO") = viewParent.GetRowCellValue(viewParent.FocusedRowHandle, "SOURCE_NO")
            viewChild.GetDataRow(e.RowHandle)("AMOUNT") = 0
            viewChild.GetDataRow(e.RowHandle)("PECENTAGE") = 100
            viewChild.GetDataRow(e.RowHandle)("PECENTAGE_AMOUNT") = 0

            ChangeStatus(EnumStatus.Done)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(Errorlog)
            ChangeStatus(EnumStatus.Failed)
        End Try
    End Sub
#End Region
    ''' <summary>
    ''' Export_PNLQuick import data to pnl quick from excel
    ''' ImportPath = location to import file.must be xlsx
    ''' isAppend = false mean clear last data inside pnl quick.
    ''' </summary>
    Public Function Import_PNLQuick(ByVal ImportPath As String, Optional ByVal isAppend As Boolean = False) As Boolean
        Try
            ChangeStatus(EnumStatus.InProgress)

            If System.IO.File.Exists(ImportPath) = False Then
                If Errorlog Is Nothing Then
                    Errorlog = New ClsError
                End If
                With Errorlog
                    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                    .ErrorCode = "A003"
                    .ErrorDateTime = Now
                    .ErrorMessage = "File not exist."
                End With
                ChangeStatus(EnumStatus.Failed)
                Return False
            End If

            Dim strSQL As String = Nothing
            Dim adapter As OleDbDataAdapter
            Dim connectionString As String = ""

            If ImportPath.EndsWith(".xlsx") Then            '2007 Format            
                connectionString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;HDR=No'", ImportPath)
            Else            '2003 Format            
                connectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=No'", ImportPath)
            End If

            If isAppend = False Then
                Me.dsDataset.Tables("PNL_QUICK_DETAIL_SUB").Rows.Clear()
                Me.dsDataset.Tables("PNL_QUICK_DETAIL").Rows.Clear()
            End If

            Dim conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim dtSheets As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)

            Dim ds As New DataSet

            For Each drSheet In dtSheets.Rows
                strSQL = "select * from [" & drSheet("TABLE_NAME").ToString() & "] ORDER BY 2"
                adapter = New OleDbDataAdapter(strSQL, connectionString)
                adapter.Fill(ds, "Sheet")
                Exit For
            Next
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                Dim tmpID As Integer = 0
                For Each rowx As DataRow In ds.Tables(0).Rows

                    dtRow = Nothing
                    If IsDBNull(rowx(0)) = False AndAlso rowx(0) <> "" AndAlso IsDBNull(rowx(1)) = False Then 'KEYNAME
                        If IsDBNull(rowx(2)) = False AndAlso rowx(2) <> 0 Then
                            dtRow = Me.dsDataset.Tables("PNL_QUICK_DETAIL").NewRow
                            dtRow("KEYNAME") = rowx(0) 'KEYNAME
                            dtRow("SOURCE_NO") = rowx(3) 'SOURCE NO
                            dtRow("DESCRIPTION") = rowx(4) 'DESCRIPTION
                            dtRow("AMOUNT") = rowx(5) 'AMOUNT
                            dtRow("NOTE") = rowx(6) 'NOTE
                            dtRow("DEDUCTIBLE") = rowx(7) 'DEDUCTIBLE
                            dtRow("DEDUCTIBLE_ADD") = rowx(8) 'DEDUCTIBLE_ADD
                            dtRow("PECENTAGE") = rowx(9) 'PECENTAGE
                            dtRow("PECENTAGE_AMOUNT") = rowx(10) 'PECENTAGE_AMOUNT
                            Me.dsDataset.Tables("PNL_QUICK_DETAIL").Rows.Add(dtRow)

                            tmpID = Me.dsDataset.Tables("PNL_QUICK_DETAIL").Rows(Me.dsDataset.Tables("PNL_QUICK_DETAIL").Rows.Count - 1)("ID")

                            For Each rowx_child As DataRow In ds.Tables(0).Rows
                                If IsDBNull(rowx_child(0)) = False AndAlso rowx_child(0) <> "" AndAlso IsDBNull(rowx_child(2)) = False Then 'KEYNAME
                                    '                                If rowx_child(2) <> 0 AndAlso rowx(1) = rowx_child(2) Then
                                    If rowx(1) = rowx_child(2) Then
                                        dtRow = Nothing
                                        dtRow = Me.dsDataset.Tables("PNL_QUICK_DETAIL_SUB").NewRow
                                        dtRow("KEYNAME") = rowx_child(0) 'KEYNAME
                                        dtRow("PARENT_ID") = tmpID 'PARENT ID
                                        dtRow("SOURCE_NO") = rowx_child(3) 'SOURCE NO
                                        dtRow("DESCRIPTION") = rowx_child(4) 'DESCRIPTION
                                        dtRow("AMOUNT") = rowx_child(5) 'AMOUNT
                                        dtRow("NOTE") = rowx_child(6) 'NOTE
                                        dtRow("DEDUCTIBLE") = rowx_child(7) 'DEDUCTIBLE
                                        dtRow("DEDUCTIBLE_ADD") = rowx_child(8) 'DEDUCTIBLE_ADD
                                        dtRow("PECENTAGE") = rowx_child(9) 'PECENTAGE
                                        dtRow("PECENTAGE_AMOUNT") = rowx_child(10) 'PECENTAGE_AMOUNT
                                        Me.dsDataset.Tables("PNL_QUICK_DETAIL_SUB").Rows.Add(dtRow)
                                    End If
                                End If
                            Next
                        Else
                            dtRow = Me.dsDataset.Tables("PNL_QUICK_DETAIL").NewRow
                            dtRow("KEYNAME") = rowx(0) 'KEYNAME
                            dtRow("SOURCE_NO") = rowx(3) 'SOURCE NO
                            dtRow("DESCRIPTION") = rowx(4) 'DESCRIPTION
                            dtRow("AMOUNT") = rowx(5) 'AMOUNT
                            dtRow("NOTE") = rowx(6) 'NOTE
                            dtRow("DEDUCTIBLE") = rowx(7) 'DEDUCTIBLE
                            dtRow("DEDUCTIBLE_ADD") = rowx(8) 'DEDUCTIBLE_ADD
                            dtRow("PECENTAGE") = rowx(9) 'PECENTAGE
                            dtRow("PECENTAGE_AMOUNT") = rowx(10) 'PECENTAGE_AMOUNT
                            Me.dsDataset.Tables("PNL_QUICK_DETAIL").Rows.Add(dtRow)

                            tmpID = Me.dsDataset.Tables("PNL_QUICK_DETAIL").Rows(Me.dsDataset.Tables("PNL_QUICK_DETAIL").Rows.Count - 1)("ID")
                        End If
                        
                       
                    End If
                Next

            End If

            RaiseEvent OnChangeInfo(Me.dsDataset, Errorlog)
            ChangeStatus(EnumStatus.Done)
            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(Errorlog)
            ChangeStatus(EnumStatus.Failed)
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Export_PNLQuick export data from pnl quick to excel
    ''' ExportPath = location to export 
    ''' </summary>
    Public Function Export_PNLQuick(ByVal ExportPath As String) As Boolean
        Try
            ChangeStatus(EnumStatus.InProgress)

            Me.dsDataset.Tables("PNL_QUICK_EXPORT_IMPORT").Rows.Clear()
            Application.DoEvents()
            Dim tmpID As Integer = 0
            For Each rowx As DataRow In Me.dsDataset.Tables("PNL_QUICK_DETAIL").Rows
                dtRow = Nothing
                dtRow = Me.dsDataset.Tables("PNL_QUICK_EXPORT_IMPORT").NewRow()
                dtRow("KEYNAME") = rowx("KEYNAME")
                tmpID = Me.dsDataset.Tables("PNL_QUICK_EXPORT_IMPORT").Rows.Count + 1
                dtRow("ID") = tmpID
                dtRow("PARENT_ID") = 0
                dtRow("SOURCE_NO") = IIf(IsDBNull(rowx("SOURCE_NO")), 0, rowx("SOURCE_NO"))
                dtRow("DESCRIPTION") = IIf(IsDBNull(rowx("DESCRIPTION")), "", rowx("DESCRIPTION"))
                dtRow("AMOUNT") = IIf(IsDBNull(rowx("AMOUNT")), 0, rowx("AMOUNT"))
                dtRow("NOTE") = IIf(IsDBNull(rowx("NOTE")), "", rowx("NOTE"))
                dtRow("DEDUCTIBLE") = IIf(IsDBNull(rowx("DEDUCTIBLE")), False, rowx("DEDUCTIBLE"))
                dtRow("DEDUCTIBLE_ADD") = IIf(IsDBNull(rowx("DEDUCTIBLE_ADD")), False, rowx("DEDUCTIBLE_ADD"))
                dtRow("PECENTAGE") = IIf(IsDBNull(rowx("PECENTAGE")), 0, rowx("PECENTAGE"))
                dtRow("PECENTAGE_AMOUNT") = IIf(IsDBNull(rowx("PECENTAGE_AMOUNT")), 0, rowx("PECENTAGE_AMOUNT"))
                Me.dsDataset.Tables("PNL_QUICK_EXPORT_IMPORT").Rows.Add(dtRow)

                For Each row_child As DataRow In Me.dsDataset.Tables("PNL_QUICK_DETAIL_SUB").Rows

                    If rowx("ID") = row_child("PARENT_ID") Then
                        dtRow = Nothing
                        dtRow = Me.dsDataset.Tables("PNL_QUICK_EXPORT_IMPORT").NewRow()
                        dtRow("KEYNAME") = IIf(IsDBNull(rowx("KEYNAME")), "", rowx("KEYNAME"))
                        dtRow("ID") = Me.dsDataset.Tables("PNL_QUICK_EXPORT_IMPORT").Rows.Count + 1
                        dtRow("PARENT_ID") = tmpID
                        dtRow("SOURCE_NO") = IIf(IsDBNull(row_child("SOURCE_NO")), 0, row_child("SOURCE_NO"))
                        dtRow("DESCRIPTION") = IIf(IsDBNull(row_child("DESCRIPTION")), "", row_child("DESCRIPTION"))
                        dtRow("AMOUNT") = IIf(IsDBNull(row_child("AMOUNT")), 0, row_child("AMOUNT"))
                        dtRow("NOTE") = IIf(IsDBNull(row_child("NOTE")), "", row_child("NOTE"))
                        dtRow("DEDUCTIBLE") = IIf(IsDBNull(row_child("DEDUCTIBLE")), False, row_child("DEDUCTIBLE"))
                        dtRow("DEDUCTIBLE_ADD") = IIf(IsDBNull(row_child("DEDUCTIBLE_ADD")), False, row_child("DEDUCTIBLE_ADD"))
                        dtRow("PECENTAGE") = IIf(IsDBNull(row_child("PECENTAGE")), 0, row_child("PECENTAGE"))
                        dtRow("PECENTAGE_AMOUNT") = IIf(IsDBNull(row_child("PECENTAGE_AMOUNT")), 0, row_child("PECENTAGE_AMOUNT"))
                        Me.dsDataset.Tables("PNL_QUICK_EXPORT_IMPORT").Rows.Add(dtRow)
                    End If

                Next

            Next

            Dim gridcontrol As New GridControl

            Dim gvCredentials As New DevExpress.XtraGrid.Views.Grid.GridView
            gridcontrol.ViewCollection.Add(gvCredentials)
            gridcontrol.MainView = gvCredentials
            gridcontrol.BindingContext = New BindingContext()
            gridcontrol.DataSource = Me.dsDataset.Tables("PNL_QUICK_EXPORT_IMPORT")
            gvCredentials.PopulateColumns()

            If System.IO.File.Exists(ExportPath & "\PNL_QUICK_EXPORT_" & Format(Now, "dd-MMM-yyyy") & ".xlsx") Then
                System.IO.File.Delete(ExportPath & "\PNL_QUICK_EXPORT_" & Format(Now, "dd-MMM-yyyy") & ".xlsx")
            End If
            gridcontrol.ExportToXlsx(ExportPath & "\PNL_QUICK_EXPORT_" & Format(Now, "dd-MMM-yyyy") & ".xlsx")

            ChangeStatus(EnumStatus.Done)
            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(Errorlog)
            ChangeStatus(EnumStatus.Failed)
            Return False
        End Try
    End Function
    Public Sub Ai_Testing()
        Try
            ChangeStatus(EnumStatus.InProgress)

            If Ai_Testing_Require = False Then
                ChangeStatus(EnumStatus.Done)
                Exit Sub
            End If

            Dim AI_Keyname As String = "SALES"
            Dim AI_SourceNo As Integer = 1
            Dim AI_Description As String = ""
            Dim AI_Amount As Integer = 0
            Dim r As New Random

            Me.dsDataset.Tables("PNL_QUICK_DETAIL").Rows.Clear()
            Dim rowSelect As Integer = 0
            For i As Integer = 0 To r.Next(10, 100)
                rowSelect = r.Next(0, Me.dsDataset.Tables("PNL_TABLE_INFO").Rows.Count - 1)
                AI_Keyname = Me.dsDataset.Tables("PNL_TABLE_INFO").Rows(rowSelect)("Keyname")

                Select Case AI_Keyname
                    Case "OTHERNONALLOWEXP", "REALFE"
                    Case Else
                        AI_SourceNo = Me.dsDataset.Tables("BUSINESS_SOURCE").Rows(0)("BC_SOURCENO")
                        AI_Description = mdlProcess.RandomKey()
                        AI_Amount = r.Next(0, 100000)


                        dtRow = Nothing
                        dtRow = Me.dsDataset.Tables("PNL_QUICK_DETAIL").NewRow
                        dtRow("KeyName") = AI_Keyname
                        dtRow("Source_No") = AI_SourceNo
                        dtRow("Description") = AI_Description
                        dtRow("Amount") = AI_Amount
                        dtRow("Note") = ""
                        dtRow("Deductible") = False
                        dtRow("Deductible_Add") = False
                        dtRow("Pecentage") = 0
                        dtRow("Pecentage_Amount") = 0
                        Me.dsDataset.Tables("PNL_QUICK_DETAIL").Rows.Add(dtRow)
                End Select


            Next
            Me.Calculate_CategoryTotal()
            ChangeStatus(EnumStatus.Done)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(Errorlog)
            ChangeStatus(EnumStatus.Failed)

        End Try
    End Sub
    ''' <summary>
    ''' Save_PNLQuick Save Profit and Loss
    ''' isPartiallySave = True is not save to database but pass data to main Profit & Loss dataset. (Original P&L)
    ''' isPartiallySave = False is directly save to database
    ''' dsOrignal = Optional if you use isPartiallySave = True, you must specifies orignal dataset P&L(Take from frmPNL_Add)
    ''' Note 12/06/2017 Save data to database
    ''' </summary>
    Public Function Save_PNLQuick(Optional ByVal isPartiallySave As Boolean = False, Optional ByRef dsOrignal As DataSet = Nothing) As Boolean
        Try
            RaiseEvent OnSchangeSaveStatus(EnumStatus.InProgress, Errorlog)
            Dim KeyName As String = Nothing
            Dim TableName As String = Nothing
            Dim TableName_Details As String = Nothing
            Dim ColumnSourceNo As String = Nothing
            Dim ColumnSourceNo_Details As String = Nothing
            Dim ColumnAmount As String = Nothing
            Dim ColumnAmount_Details As String = Nothing
            Dim ColumnTable As String = Nothing
            Dim ColumnTable_Details As String = Nothing
            Dim ColumnAddBack As String = Nothing
            Dim ColumnAddBack_Details As String = Nothing
            Dim ColumnDeduct As String = Nothing
            Dim ColumnDeduct_Details As String = Nothing
            Dim ColumnPercentage As String = Nothing
            Dim Type As EnumTypeCategory = EnumTypeCategory.NoDeduct_1
            Dim PrefixName As String = Nothing
            Dim ID As Integer = 0
            Dim Ori_ID As Integer = 0
            If isPartiallySave Then
                'Pass Data
                For Each rowInfo As DataRow In Me.dsDataset.Tables("PNL_TABLE_INFO").Rows
                    If IsDBNull(rowInfo("KEYNAME")) = False AndAlso rowInfo("KEYNAME") <> "" Then
                        ID = 0
                        Ori_ID = 0
                        KeyName = rowInfo("KeyName")
                        TableName = IIf(IsDBNull(rowInfo("TableName")), "", rowInfo("TableName"))
                        TableName_Details = IIf(IsDBNull(rowInfo("TableName_Details")), "", rowInfo("TableName_Details"))
                        ColumnSourceNo = IIf(IsDBNull(rowInfo("ColumnSourceNo")), "", rowInfo("ColumnSourceNo"))
                        ColumnSourceNo_Details = IIf(IsDBNull(rowInfo("ColumnSourceNo_Details")), "", rowInfo("ColumnSourceNo_Details"))
                        ColumnDescription = IIf(IsDBNull(rowInfo("ColumnDescription")), "", rowInfo("ColumnDescription"))
                        ColumnDescription_Details = IIf(IsDBNull(rowInfo("ColumnDescription_Details")), "", rowInfo("ColumnDescription_Details"))
                        ColumnAmount = IIf(IsDBNull(rowInfo("ColumnAmount")), "", rowInfo("ColumnAmount"))
                        ColumnAmount_Details = IIf(IsDBNull(rowInfo("ColumnAmount_Details")), "", rowInfo("ColumnAmount_Details"))
                        ColumnTable = IIf(IsDBNull(rowInfo("ColumnTable")), "", rowInfo("ColumnTable"))
                        ColumnTable_Details = IIf(IsDBNull(rowInfo("ColumnTable_Details")), "", rowInfo("ColumnTable_Details"))
                        ColumnAddBack = IIf(IsDBNull(rowInfo("ColumnAddBack")), "", rowInfo("ColumnAddBack"))
                        ColumnAddBack_Details = IIf(IsDBNull(rowInfo("ColumnAddBack_Details")), "", rowInfo("ColumnAddBack_Details"))
                        ColumnDeduct = IIf(IsDBNull(rowInfo("ColumnDeduct")), "", rowInfo("ColumnDeduct"))
                        ColumnDeduct_Details = IIf(IsDBNull(rowInfo("ColumnDeduct_Details")), "", rowInfo("ColumnDeduct_Details"))
                        ColumnPercentage = IIf(IsDBNull(rowInfo("ColumnPecentage_Amount")), "", rowInfo("ColumnPecentage_Amount"))
                        Type = IIf(IsDBNull(rowInfo("Type")), 1, rowInfo("Type"))
                        PrefixName = IIf(IsDBNull(rowInfo("PrefixName")), "", rowInfo("PrefixName"))

                        dsOrignal.Tables(TableName_Details).Rows.Clear()
                        dsOrignal.Tables(TableName).Rows.Clear()
                        For Each rowData As DataRow In Me.dsDataset.Tables("PNL_QUICK_DETAIL").Rows
                            dtRow = Nothing
                            dtRow = dsOrignal.Tables(TableName).NewRow
                            dtRow(ColumnSourceNo) = rowData("SOURCE_NO")
                            dtRow(ColumnDescription) = rowData("DESCRIPTION")
                            dtRow(ColumnAmount) = rowData("AMOUNT")
                            ID = rowData("ID")
                            Select Case Type
                                Case EnumTypeCategory.NoDeduct_1
                                Case EnumTypeCategory.WithOutPercentage_2
                                    Select Case rowInfo("KEYNAME")
                                        Case "PURCHASE", "DEPRECIATION", "OTHERALLOWEXP", "OTHERNONALLOWEXP"
                                            dtRow(ColumnAddBack) = rowData("DEDUCTIBLE")
                                            dtRow(ColumnPercentage) = rowData("PECENTAGE_AMOUNT")
                                        Case Else
                                            dtRow(ColumnAddBack) = rowData("DEDUCTIBLE")
                                            dtRow(ColumnDeduct) = rowData("DEDUCTIBLE_ADD")
                                            dtRow(ColumnPercentage) = rowData("PECENTAGE_AMOUNT")
                                    End Select
                                Case EnumTypeCategory.Percentage_3
                                    dtRow(ColumnAddBack) = rowData("DEDUCTIBLE")
                                    dtRow(ColumnDeduct) = rowData("DEDUCTIBLE_ADD")
                                    dtRow("Pecentage") = rowData("PECENTAGE")
                                    dtRow(ColumnPercentage) = rowData("PECENTAGE_AMOUNT")
                            End Select

                            dsOrignal.Tables(TableName).Rows.Add(dtRow)
                            Ori_ID = dsOrignal.Tables(TableName).Rows(dsOrignal.Tables(TableName).Rows.Count - 1)(ColumnTable)

                            If TableName_Details <> "" AndAlso Me.dsDataset.Tables("PNL_QUICK_DETAIL_SUB").Rows.Count > 0 Then

                                For Each rowDataChild As DataRow In Me.dsDataset.Tables("PNL_QUICK_DETAIL_SUB").Rows
                                    dtRowChild = Nothing
                                    If IsDBNull(rowDataChild("KeyName")) = False AndAlso rowDataChild("KeyName") <> "" Then

                                        If ID = rowDataChild("PARENT_ID") Then
                                            dtRowChild = dsOrignal.Tables(TableName_Details).NewRow

                                            dtRowChild(ColumnSourceNo_Details) = rowDataChild("SOURCE_NO")
                                            dtRowChild(ColumnDescription_Details) = rowDataChild("DESCRIPTION")
                                            dtRowChild(ColumnAmount_Details) = rowDataChild("AMOUNT")
                                            dtRowChild(ColumnTable_Details) = Ori_ID

                                            Select Case Type
                                                Case EnumTypeCategory.NoDeduct_1
                                                Case EnumTypeCategory.WithOutPercentage_2
                                                    Select Case rowInfo("KEYNAME")
                                                        Case "PURCHASE", "DEPRECIATION", "OTHERALLOWEXP", "OTHERNONALLOWEXP"
                                                            dtRowChild(ColumnAddBack_Details) = rowDataChild("DEDUCTIBLE")
                                                            dtRowChild(ColumnPercentage) = rowDataChild("PECENTAGE_AMOUNT")
                                                        Case Else
                                                            dtRowChild(ColumnAddBack_Details) = rowDataChild("DEDUCTIBLE")
                                                            dtRowChild(ColumnDeduct_Details) = rowDataChild("DEDUCTIBLE_ADD")
                                                            dtRowChild(ColumnPercentage) = rowDataChild("PECENTAGE_AMOUNT")
                                                    End Select
                                                Case EnumTypeCategory.Percentage_3
                                                    dtRowChild(ColumnAddBack_Details) = rowDataChild("DEDUCTIBLE")
                                                    dtRowChild(ColumnDeduct_Details) = rowDataChild("DEDUCTIBLE_ADD")
                                                    dtRowChild("Pecentage") = rowDataChild("PECENTAGE")
                                                    dtRowChild(ColumnPercentage) = rowDataChild("PECENTAGE_AMOUNT")
                                            End Select

                                            dsOrignal.Tables(TableName_Details).Rows.Add(dtRowChild)
                                        End If

                                    End If

                                Next
                            End If
                        Next

                    End If
                Next
            Else
                'Database 
                Dim ListofSQL As New List(Of SqlCommand)
                Dim SqlCon As SqlConnection = Nothing
                Dim ListofExp As New List(Of String)
                Dim PNL_Key As Integer = 0
                If DBConnection(SqlCon, Errorlog) = False OrElse SqlCon Is Nothing Then
                    With Errorlog
                        .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                        .ErrorCode = "A001"
                        .ErrorDateTime = Now
                        .ErrorMessage = "Failed connect to database."
                    End With
                    ChangeStatus(EnumStatus.Failed)
                    Return False
                End If
                Me.dsDataset.Tables("PROFIT_LOSS_ACCOUNT").Rows.Clear()

                Dim tmpPNL As DataTable = ADO.Load_PNL(RefNo, YA, Errorlog)
                'Update
                dtRow = Nothing
                dtRow = Me.dsDataset.Tables("PROFIT_LOSS_ACCOUNT").NewRow
                If tmpPNL IsNot Nothing Then
                    PNL_Key = IIf(IsDBNull(tmpPNL.Rows(0)("PL_KEY")), 0, tmpPNL.Rows(0)("PL_KEY"))
                    dtRow("PL_MAINBUZ") = IIf(IsDBNull(tmpPNL.Rows(0)("PL_MAINBUZ")), 1, tmpPNL.Rows(0)("PL_MAINBUZ"))
                    dtRow("PL_KEY") = PNL_Key
                Else
                    If Me.dsDataset.Tables("BUSINESS_SOURCE").Rows.Count > 0 Then
                        dtRow("PL_MAINBUZ") = IIf(IsDBNull(Me.dsDataset.Tables("BUSINESS_SOURCE").Rows(0)("BC_SOURCENO")), 1, Me.dsDataset.Tables("BUSINESS_SOURCE").Rows(0)("BC_SOURCENO"))
                        PNL_Key = ADO.GETPNLKEY(Errorlog) + 1
                        dtRow("PL_KEY") = PNL_Key
                    Else
                        With Errorlog
                            .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                            .ErrorCode = "A002"
                            .ErrorDateTime = Now
                            .ErrorMessage = "No business source found"
                        End With
                        ChangeStatus(EnumStatus.Failed)
                        Return False
                    End If

                End If
                For Each rowInfo As DataRow In Me.dsDataset.Tables("PNL_TABLE_INFO").Rows
                    If IsDBNull(rowInfo("KeyName")) = False AndAlso rowInfo("KeyName") <> "" AndAlso IsDBNull(rowInfo("ColumnName")) = False AndAlso rowInfo("ColumnName") <> "" Then
                        For Each rowPNLQuick As DataRow In Me.dsDataset.Tables("PNL_QUICK").Rows
                            If IsDBNull(rowPNLQuick("KeyName")) = False AndAlso rowPNLQuick("KeyName") = rowInfo("KeyName") Then
                                dtRow(rowInfo("ColumnName")) = rowPNLQuick("Amount")
                            End If
                        Next
                    End If
                Next

                If isS60F Then
                    dtRow("PL_S60F") = "Y"
                Else
                    dtRow("PL_S60F") = "N"
                End If
                If isS60FA Then
                    dtRow("PL_S60FA") = "Y"
                Else
                    dtRow("PL_S60FA") = "N"
                End If

                'Column Amount from PNL_TABLE_INFO_MAIN only exist in program. temporary memory
                For Each rowInfo As DataRow In Me.dsDataset.Tables("PNL_TABLE_INFO_MAIN").Rows
                    If IsDBNull(rowInfo("KeyName")) = False AndAlso rowInfo("KeyName") <> "" AndAlso IsDBNull(rowInfo("ColumnName")) = False AndAlso rowInfo("ColumnName") <> "" Then
                        dtRow(rowInfo("ColumnName")) = rowInfo("Amount")
                    End If
                Next

                dtRow("PL_REF_NO") = RefNo
                dtRow("PL_YA") = YA
                dtRow("PL_OTH_BSIN_RENTAL") = "0"
                dtRow("PL_OTH_BSIN_OTHER") = "0"
                dtRow("PL_OTHER_EXP_ENTM") = "0"
                dtRow("PL_COMPANY") = "C"
                dtRow("PL_TOTALX") = "0"
                dtRow("PL_TOTALY") = "0"
                dtRow("PL_OTHER_EXP_ENTM") = "0"
                dtRow("PL_TTAXDEDUCTION") = "0"
                dtRow("PL_TNETDEDUCTION") = "0"
                dtRow("ModifiedBy") = My.Computer.Name
                dtRow("ModifiedDateTime") = Now
                dtRow("PNL_Status") = ""

                Me.dsDataset.Tables("PROFIT_LOSS_ACCOUNT").Rows.Add(dtRow)

                If tmpPNL IsNot Nothing Then
                    ADO.Update_ProfitAndLoss_Query(Me.dsDataset.Tables("PROFIT_LOSS_ACCOUNT"), ListofSQL, Errorlog)
                Else
                    ADO.Save_ProfitAndLoss_Query(Me.dsDataset.Tables("PROFIT_LOSS_ACCOUNT"), ListofSQL, Errorlog)
                End If

                'ADO.Delete_PNLItem_Return(ListofSQL, PNL_Key, Errorlog)

                Dim KeyNameEnum As TaxComPNLEnuItem = TaxComPNLEnuItem.SALES
                ' Me.PNL_GetSaveDataQuickPNL(PNL_Key, ListofSQL, SqlCon)
                Me.PNL_GetDataSQLCommand(PNL_Key, ListofSQL, SqlCon)

                If ListofSQL IsNot Nothing AndAlso ListofSQL.Count > 0 Then
                    If ADO.Save_ListExecute(ListofSQL, Errorlog) = False Then
                        RaiseEvent OnSchangeSaveStatus(EnumStatus.Failed, Errorlog)
                        Return False
                    End If
                End If


            End If

            RaiseEvent OnSchangeSaveStatus(EnumStatus.Done, Errorlog)
            Return True
        Catch ex As Exception
            'Dim st As New StackTrace(True)
            'st = New StackTrace(ex, True)
            'If Errorlog Is Nothing Then
            '    Errorlog = New ClsError
            'End If
            'With Errorlog
            '    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
            '    .ErrorCode = ex.GetHashCode.ToString
            '    .ErrorDateTime = Now
            '    .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            'End With
            AddListOfError(Errorlog)
            ChangeStatus(EnumStatus.Failed)
            Return False
        End Try
    End Function
    ''' <summary>
    ''' PNL_GetDataSQLCommand transfer quick Profit and Loss to SQL Query
    ''' PNL_KEY = PNL key
    ''' ListofSQLCmd = SQL command from another side
    ''' SqlCon = SQL Connection
    ''' FIXED PARAMETER
    ''' PNLKEY = Orginal PNL KEY
    ''' KEY = ID
    ''' SOURCENO = SOURCE_NO
    ''' DESC = DESCRIPTION
    ''' AMOUNT = AMOUNT
    ''' NOTE = NOTE
    ''' RowIndex = INDEX
    ''' DEDUCTIBLE = DEDUCTIBLE
    ''' DEDUCTIBLE_ADD = DEDUCTIBLE_ADD
    ''' Pecentage = PECENTAGE
    ''' PecentageAmount = PECENTAGE_AMOUNT
    ''' </summary>
    Public Sub PNL_GetDataSQLCommand(ByVal PNL_KEY As Integer, ByRef ListofSQLCmd As List(Of SqlCommand), ByRef SQLCon As SqlConnection)
        Try
            RaiseEvent OnSchangeSaveStatus(EnumStatus.InProgress, Errorlog)

            Dim SQLCmd As SqlCommand = Nothing
            Dim SQLCmd_Details As SqlCommand = Nothing
            Dim RowIndex As Integer = 0
            Dim RowIndex_Details As Integer = 0
            Dim tmpID As Integer = 0
            Dim Count_Sub As Integer = 0
            Dim ProgressNo As Integer = 0
            RaiseEvent OnProgress(0, Me.dsDataset.Tables("PNL_QUICK_DETAIL").Rows.Count, "Adding")
            For Each rowInfo As DataRow In Me.dsDataset.Tables("PNL_TABLE_INFO").Rows
                RowIndex = 0
                If IsDBNull(rowInfo("Keyname")) = False AndAlso rowInfo("Keyname") <> "" AndAlso
                       IsDBNull(rowInfo("DeleteQuery")) = False AndAlso rowInfo("DeleteQuery") <> "" Then

                    If rowInfo("KeyName") = "OTHERNONALLOWEXP" Then
                        Dim x As String = ""
                    End If


                    If IsDBNull(rowInfo("DeleteQuery_Details")) = False AndAlso rowInfo("DeleteQuery_Details") <> "" Then
                        SQLCmd = Nothing
                        SQLCmd = New SqlCommand
                        SQLCmd.CommandText = rowInfo("DeleteQuery_Details")
                        SQLCmd.Parameters.Add("@PNLKEY", SqlDbType.Int).Value = PNL_KEY
                        SQLCmd.Connection = SQLCon
                        ListofSQLCmd.Add(SQLCmd)
                    End If

                    SQLCmd = Nothing
                    SQLCmd = New SqlCommand
                    SQLCmd.CommandText = rowInfo("DeleteQuery")
                    SQLCmd.Parameters.Add("@PNLKEY", SqlDbType.Int).Value = PNL_KEY
                    SQLCmd.Connection = SQLCon
                    ListofSQLCmd.Add(SQLCmd)


                End If


                For Each rowData As DataRow In Me.dsDataset.Tables("PNL_QUICK_DETAIL").Rows
                    RowIndex += 1
                    ProgressNo += 1
                    If IsDBNull(rowInfo("Keyname")) = False AndAlso rowInfo("Keyname") <> "" AndAlso
                        IsDBNull(rowInfo("SaveQuery")) = False AndAlso rowInfo("SaveQuery") <> "" AndAlso
                        IsDBNull(rowData("Keyname")) = False AndAlso rowData("Keyname") = rowInfo("Keyname") Then

                        Select Case rowInfo("Keyname")
                            Case "DIVIDENDINC"
                                SQLCmd = Nothing
                                SQLCmd = New SqlCommand
                                SQLCmd.CommandText = "INSERT INTO DIVIDEND_INCOME (DI_KEY,DI_DIVIDENDKEY,DI_SOURCENO,DI_DATE,DI_COMPANY,DI_GROSS,DI_TAX,DI_NET,DI_WARANT_NO,DI_CHKREGROSS,DI_TAXRATE,DI_REGROSS,DI_TAXDEDUCTION,DI_NETDEDUCTION,DI_ENDDATE,DI_TRATE,DI_DISCLOSE,DI_TRANSFER,DI_Percentage,DI_PercentageAmount) VALUES (@DI_KEY,@DI_DIVIDENDKEY,@DI_SOURCENO,@DI_DATE,@DI_COMPANY,@DI_GROSS,@DI_TAX,@DI_NET,@DI_WARANT_NO,@DI_CHKREGROSS,@DI_TAXRATE,@DI_REGROSS,@DI_TAXDEDUCTION,@DI_NETDEDUCTION,@DI_ENDDATE,@DI_TRATE,@DI_DISCLOSE,@DI_TRANSFER,@DI_Percentage,@DI_PercentageAmount)"
                                SQLCmd.Connection = SQLCon
                                SQLCmd.Parameters.Add("@DI_KEY", SqlDbType.Int).Value = PNL_KEY
                                SQLCmd.Parameters.Add("@DI_DIVIDENDKEY", SqlDbType.Int).Value = IIf(IsDBNull(rowData("ID")), 0, rowData("ID"))
                                SQLCmd.Parameters.Add("@DI_DATE", SqlDbType.DateTime).Value = Now
                                SQLCmd.Parameters.Add("@DI_COMPANY", SqlDbType.NVarChar, 100).Value = IIf(IsDBNull(rowData("DESCRIPTION")), "", rowData("DESCRIPTION"))
                                SQLCmd.Parameters.Add("@DI_GROSS", SqlDbType.Decimal).Value = 0
                                SQLCmd.Parameters.Add("@DI_TAX", SqlDbType.Decimal).Value = 0
                                SQLCmd.Parameters.Add("@DI_NET", SqlDbType.Decimal).Value = IIf(IsDBNull(rowData("AMOUNT")), 0, rowData("AMOUNT"))
                                SQLCmd.Parameters.Add("@DI_WARANT_NO", SqlDbType.NVarChar, 50).Value = ""
                                SQLCmd.Parameters.Add("@DI_TAXRATE", SqlDbType.NVarChar, 3).Value = "0"
                                SQLCmd.Parameters.Add("@DI_REGROSS", SqlDbType.Decimal).Value = 0
                                SQLCmd.Parameters.Add("@DI_CHKREGROSS", SqlDbType.NVarChar, 3).Value = "No"
                                SQLCmd.Parameters.Add("@DI_TAXDEDUCTION", SqlDbType.Decimal).Value = 0
                                SQLCmd.Parameters.Add("@DI_NETDEDUCTION", SqlDbType.Decimal).Value = 0
                                SQLCmd.Parameters.Add("@DI_ENDDATE", SqlDbType.DateTime).Value = Now
                                SQLCmd.Parameters.Add("@DI_TRATE", SqlDbType.NVarChar, 3).Value = "0"
                                SQLCmd.Parameters.Add("@DI_SOURCENO", SqlDbType.Int).Value = IIf(IsDBNull(rowData("SOURCE_NO")), 0, rowData("SOURCE_NO"))
                                SQLCmd.Parameters.Add("@DI_DISCLOSE", SqlDbType.NVarChar, 3).Value = ""
                                SQLCmd.Parameters.Add("@DI_TRANSFER", SqlDbType.NVarChar, 25).Value = "Single Tier"
                                SQLCmd.Parameters.Add("@DI_Percentage", SqlDbType.Decimal).Value = 0
                                SQLCmd.Parameters.Add("@DI_PercentageAmount", SqlDbType.Decimal).Value = 0
                                ListofSQLCmd.Add(SQLCmd)

                            Case "RENTALINC"
                                SQLCmd = Nothing
                                SQLCmd = New SqlCommand
                                SQLCmd.CommandText = "INSERT INTO RENTAL_INCOME (RI_KEY,RI_RENTKEY,RI_TYPE,RI_ADDRESS,RI_DATE,RI_AMOUNT,RI_SOURCENO,RI_STATUS4d,RI_DATE_END,RowIndex) VALUES (@RI_KEY,@RI_RENTKEY,@RI_TYPE,@RI_ADDRESS,@RI_DATE,@RI_AMOUNT,@RI_SOURCENO,@RI_STATUS4d,@RI_DATE_END,@RowIndex)"
                                SQLCmd.Parameters.Add("@RI_KEY", SqlDbType.Int).Value = PNL_KEY
                                SQLCmd.Parameters.Add("@RI_RENTKEY", SqlDbType.Int).Value = IIf(IsDBNull(rowData("ID")), 0, rowData("ID"))
                                SQLCmd.Parameters.Add("@RI_TYPE", SqlDbType.NVarChar, 255).Value = "Rental Income"
                                SQLCmd.Parameters.Add("@RI_ADDRESS", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(rowData("DESCRIPTION")), "", rowData("DESCRIPTION"))
                                SQLCmd.Parameters.Add("@RI_DATE", SqlDbType.Date).Value = Now
                                SQLCmd.Parameters.Add("@RI_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(rowData("AMOUNT")), 0, rowData("AMOUNT"))
                                SQLCmd.Parameters.Add("@RI_SOURCENO", SqlDbType.Int).Value = IIf(IsDBNull(rowData("SOURCE_NO")), 0, rowData("SOURCE_NO"))
                                SQLCmd.Parameters.Add("@RI_STATUS4d", SqlDbType.NVarChar, 25).Value = "No"
                                SQLCmd.Parameters.Add("@RI_DATE_END", SqlDbType.DateTime).Value = Now
                                SQLCmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = RowIndex
                                ListofSQLCmd.Add(SQLCmd)

                            Case "EXEMDIV"
                                SQLCmd = Nothing
                                SQLCmd = New SqlCommand
                                SQLCmd.CommandText = "INSERT INTO EXEMPT_DIVIDEND (ED_KEY,ED_EDKEY,ED_DATE,ED_COMPANY,ED_AMOUNT,ED_TIERSTATUS,ED_SOURCENO,RowIndex) VALUES (@ED_KEY,@ED_EDKEY,@ED_DATE,@ED_COMPANY,@ED_AMOUNT,@ED_TIERSTATUS,@ED_SOURCENO,@RowIndex)"
                                SQLCmd.Parameters.Add("@ED_KEY", SqlDbType.Int).Value = PNL_KEY
                                SQLCmd.Parameters.Add("@ED_EDKEY", SqlDbType.Int).Value = IIf(IsDBNull(rowData("ID")), 0, rowData("ID"))
                                SQLCmd.Parameters.Add("@ED_DATE", SqlDbType.DateTime).Value = Now
                                SQLCmd.Parameters.Add("@ED_COMPANY", SqlDbType.NVarChar, 255).Value = IIf(IsDBNull(rowData("DESCRIPTION")), "", rowData("DESCRIPTION"))
                                SQLCmd.Parameters.Add("@ED_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(rowData("AMOUNT")), 0, rowData("AMOUNT"))
                                SQLCmd.Parameters.Add("@ED_TIERSTATUS", SqlDbType.NVarChar, 50).Value = "Single Tier"
                                SQLCmd.Parameters.Add("@ED_SOURCENO", SqlDbType.Int).Value = IIf(IsDBNull(rowData("SOURCE_NO")), 0, rowData("SOURCE_NO"))
                                SQLCmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = RowIndex
                                ListofSQLCmd.Add(SQLCmd)

                            Case "OTHERNONTAXINC"
                                SQLCmd = Nothing
                                SQLCmd = New SqlCommand
                                SQLCmd.CommandText = "INSERT INTO NON_TAXABLE_INCOME (NT_KEY,NT_REF_NO,NT_YA,NT_DESC,NT_AMOUNT,NT_CATEGORIZED,NT_NOTE,NT_DETAIL,NT_SOURCENO,NT_NTKEY,RowIndex) VALUES (@NT_KEY,@NT_REF_NO,@NT_YA,@NT_DESC,@NT_AMOUNT,@NT_CATEGORIZED,@NT_NOTE,@NT_DETAIL,@NT_SOURCENO,@NT_NTKEY,@RowIndex)"
                                SQLCmd.Parameters.Add("@NT_KEY", SqlDbType.Int).Value = PNL_KEY
                                SQLCmd.Parameters.Add("@NT_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
                                SQLCmd.Parameters.Add("@NT_YA", SqlDbType.NVarChar, 5).Value = YA
                                SQLCmd.Parameters.Add("@NT_DESC", SqlDbType.NVarChar, 255).Value = IIf(IsDBNull(rowData("DESCRIPTION")), "", rowData("DESCRIPTION"))
                                SQLCmd.Parameters.Add("@NT_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(rowData("AMOUNT")), 0, rowData("AMOUNT"))
                                SQLCmd.Parameters.Add("@NT_CATEGORIZED", SqlDbType.NVarChar, 10).Value = ""
                                SQLCmd.Parameters.Add("@NT_NOTE", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(rowData("NOTE")), "", rowData("NOTE"))
                                SQLCmd.Parameters.Add("@NT_SOURCENO", SqlDbType.Int).Value = IIf(IsDBNull(rowData("SOURCE_NO")), 0, rowData("SOURCE_NO"))
                                SQLCmd.Parameters.Add("@NT_NTKEY", SqlDbType.Float).Value = DBNull.Value
                                SQLCmd.Parameters.Add("@NT_DETAIL", SqlDbType.NVarChar, 30).Value = "No"
                                SQLCmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = RowIndex
                                ListofSQLCmd.Add(SQLCmd)

                            Case "INTERESTRESTRICT"
                                SQLCmd = Nothing
                                SQLCmd = New SqlCommand
                                SQLCmd.CommandText = "INSERT INTO EXPENSES_INTERESTRESTRICT (EXIR_KEY,EXIR_EXIRKEY,EXIR_SOURCENO,EXIR_AMOUNT,EXIR_DESC,EXIR_DEDUCTIBLE,EXIR_NOTE,EXIR_DETAIL,EXIR_YEAREND,EXIR_STATUS,EXIR_DEDUCTIBLE_ADD,RowIndex,PecentageAmount) VALUES (@EXIR_KEY,@EXIR_EXIRKEY,@EXIR_SOURCENO,@EXIR_AMOUNT,@EXIR_DESC,@EXIR_DEDUCTIBLE,@EXIR_NOTE,@EXIR_DETAIL,@EXIR_YEAREND,@EXIR_STATUS,@EXIR_DEDUCTIBLE_ADD,@RowIndex,@PecentageAmount)"
                                SQLCmd.Parameters.Add("@EXIR_KEY", SqlDbType.Int).Value = PNL_KEY
                                SQLCmd.Parameters.Add("@EXIR_EXIRKEY", SqlDbType.Int).Value = IIf(IsDBNull(rowData("ID")), 0, rowData("ID"))
                                SQLCmd.Parameters.Add("@EXIR_SOURCENO", SqlDbType.Int).Value = IIf(IsDBNull(rowData("SOURCE_NO")), 0, rowData("SOURCE_NO"))
                                SQLCmd.Parameters.Add("@EXIR_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(rowData("AMOUNT")), 0, rowData("AMOUNT"))
                                SQLCmd.Parameters.Add("@EXIR_DESC", SqlDbType.NVarChar, 255).Value = IIf(IsDBNull(rowData("DESCRIPTION")), "", rowData("DESCRIPTION"))
                                SQLCmd.Parameters.Add("@EXIR_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = IIf(IsDBNull(rowData("DEDUCTIBLE")), "No", IIf(rowData("DEDUCTIBLE") = True, "Yes", "No"))
                                SQLCmd.Parameters.Add("@EXIR_NOTE", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(rowData("NOTE")), "", rowData("NOTE"))
                                SQLCmd.Parameters.Add("@EXIR_DETAIL", SqlDbType.NVarChar, 30).Value = "No"
                                SQLCmd.Parameters.Add("@EXIR_YEAREND", SqlDbType.NVarChar, 50).Value = "0"
                                SQLCmd.Parameters.Add("@EXIR_STATUS", SqlDbType.NVarChar, 10).Value = "Yearly"
                                SQLCmd.Parameters.Add("@EXIR_DEDUCTIBLE_ADD", SqlDbType.NVarChar, 30).Value = IIf(IsDBNull(rowData("DEDUCTIBLE_ADD")), "No", IIf(rowData("DEDUCTIBLE_ADD") = True, "Yes", "No"))
                                SQLCmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = RowIndex
                                SQLCmd.Parameters.Add("@PecentageAmount", SqlDbType.Decimal).Value = 0
                                ListofSQLCmd.Add(SQLCmd)

                            Case "EXPEMPLOYEESTOCK"
                                SQLCmd = Nothing
                                SQLCmd = New SqlCommand
                                SQLCmd.CommandText = "INSERT INTO EXPENSES_EMPL_STOCK (EXES_KEY,EXES_EXESKEY,EXES_SOURCENO,EXES_DESC,EXES_AMOUNT,EXES_DEDUCTIBLE,EXES_NOTE,EXES_DETAIL,EXES_DEDUCTIBLE_ADD,RowIndex,PecentageAmount) VALUES (@EXES_KEY,@EXES_EXESKEY,@EXES_SOURCENO,@EXES_DESC,@EXES_AMOUNT,@EXES_DEDUCTIBLE,@EXES_NOTE,@EXES_DETAIL,@EXES_DEDUCTIBLE_ADD,@RowIndex,@PecentageAmount)"
                                SQLCmd.Parameters.Add("@EXES_KEY", SqlDbType.Int).Value = PNL_KEY
                                SQLCmd.Parameters.Add("@EXES_EXESKEY", SqlDbType.Int).Value = IIf(IsDBNull(rowData("ID")), 0, rowData("ID"))
                                SQLCmd.Parameters.Add("@EXES_SOURCENO", SqlDbType.Int).Value = IIf(IsDBNull(rowData("SOURCE_NO")), 0, rowData("SOURCE_NO"))
                                SQLCmd.Parameters.Add("@EXES_DESC", SqlDbType.NVarChar, 255).Value = IIf(IsDBNull(rowData("DESCRIPTION")), "", rowData("DESCRIPTION"))
                                SQLCmd.Parameters.Add("@EXES_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(rowData("AMOUNT")), 0, rowData("AMOUNT"))
                                SQLCmd.Parameters.Add("@EXES_DEDUCTIBLE", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowData("DEDUCTIBLE")), "No", IIf(rowData("DEDUCTIBLE") = True, "Yes", "No"))
                                SQLCmd.Parameters.Add("@EXES_NOTE", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(rowData("NOTE")), "", rowData("NOTE"))
                                SQLCmd.Parameters.Add("@EXES_DETAIL", SqlDbType.NVarChar, 30).Value = "No"
                                SQLCmd.Parameters.Add("@EXES_DEDUCTIBLE_ADD", SqlDbType.NVarChar, 30).Value = IIf(IsDBNull(rowData("DEDUCTIBLE_ADD")), "No", IIf(rowData("DEDUCTIBLE_ADD") = True, "Yes", "No"))
                                SQLCmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = RowIndex
                                SQLCmd.Parameters.Add("@PecentageAmount", SqlDbType.Decimal).Value = 0
                                ListofSQLCmd.Add(SQLCmd)

                            Case "EXPRENTAL"
                                SQLCmd = Nothing
                                SQLCmd = New SqlCommand
                                SQLCmd.CommandText = "INSERT INTO EXPENSES_RENTAL (EXRENT_KEY,EXRENT_EXRENTKEY,EXRENT_SOURCENO,EXRENT_DESC,EXRENT_AMOUNT,EXRENT_DEDUCTIBLE,EXRENT_NOTE,EXRENT_DETAIL,EXRENT_DEDUCTIBLE_ADD,RowIndex,PecentageAmount,Address) VALUES (@EXRENT_KEY,@EXRENT_EXRENTKEY,@EXRENT_SOURCENO,@EXRENT_DESC,@EXRENT_AMOUNT,@EXRENT_DEDUCTIBLE,@EXRENT_NOTE,@EXRENT_DETAIL,@EXRENT_DEDUCTIBLE_ADD,@RowIndex,@PecentageAmount,@Address)"
                                SQLCmd.Parameters.Add("@EXRENT_KEY", SqlDbType.Int).Value = PNL_KEY
                                SQLCmd.Parameters.Add("@EXRENT_EXRENTKEY", SqlDbType.Int).Value = IIf(IsDBNull(rowData("ID")), 0, rowData("ID"))
                                SQLCmd.Parameters.Add("@EXRENT_SOURCENO", SqlDbType.Int).Value = IIf(IsDBNull(rowData("SOURCE_NO")), 0, rowData("SOURCE_NO"))
                                SQLCmd.Parameters.Add("@EXRENT_DESC", SqlDbType.NVarChar, 255).Value = IIf(IsDBNull(rowData("DESCRIPTION")), "", rowData("DESCRIPTION"))
                                SQLCmd.Parameters.Add("@EXRENT_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(rowData("AMOUNT")), 0, rowData("AMOUNT"))
                                SQLCmd.Parameters.Add("@EXRENT_DEDUCTIBLE", SqlDbType.NVarChar, 50).Value = IIf(IsDBNull(rowData("DEDUCTIBLE")), "No", IIf(rowData("DEDUCTIBLE") = True, "Yes", "No"))
                                SQLCmd.Parameters.Add("@EXRENT_NOTE", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(rowData("NOTE")), "", rowData("NOTE"))
                                SQLCmd.Parameters.Add("@EXRENT_DETAIL", SqlDbType.NVarChar, 30).Value = "No"
                                SQLCmd.Parameters.Add("@EXRENT_DEDUCTIBLE_ADD", SqlDbType.NVarChar, 30).Value = IIf(IsDBNull(rowData("DEDUCTIBLE_ADD")), "No", IIf(rowData("DEDUCTIBLE_ADD") = True, "Yes", "No"))
                                SQLCmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = RowIndex
                                SQLCmd.Parameters.Add("@PecentageAmount", SqlDbType.Decimal).Value = 0
                                SQLCmd.Parameters.Add("@Address", SqlDbType.NVarChar, 3000).Value = ""
                                ListofSQLCmd.Add(SQLCmd)

                            Case "EXPDONATIONAPPR"
                                SQLCmd = Nothing
                                SQLCmd = New SqlCommand
                                SQLCmd.CommandText = "INSERT INTO OTHER_EXAPPRDONATION (EXOAD_KEY,EXOAD_EXOADKEY,EXOAD_SOURCENO,EXOAD_DESC,EXOAD_AMOUNT,EXOAD_DEDUCTIBLE,EXOAD_NOTE,EXOAD_DETAIL,EXOAD_TYPE,EXOAD_DEDUCTIBLE_ADD,RowIndex,Pecentage,PecentageAmount) VALUES (@EXOAD_KEY,@EXOAD_EXOADKEY,@EXOAD_SOURCENO,@EXOAD_DESC,@EXOAD_AMOUNT,@EXOAD_DEDUCTIBLE,@EXOAD_NOTE,@EXOAD_DETAIL,@EXOAD_TYPE,@EXOAD_DEDUCTIBLE_ADD,@RowIndex,@Pecentage,@PecentageAmount)"
                                SQLCmd.Parameters.Add("@EXOAD_KEY", SqlDbType.Int).Value = PNL_KEY
                                SQLCmd.Parameters.Add("@EXOAD_EXOADKEY", SqlDbType.Int).Value = IIf(IsDBNull(rowData("ID")), 0, rowData("ID"))
                                SQLCmd.Parameters.Add("@EXOAD_SOURCENO", SqlDbType.Int).Value = IIf(IsDBNull(rowData("SOURCE_NO")), 0, rowData("SOURCE_NO"))
                                SQLCmd.Parameters.Add("@EXOAD_DESC", SqlDbType.NVarChar, 255).Value = IIf(IsDBNull(rowData("DESCRIPTION")), "", rowData("DESCRIPTION"))
                                SQLCmd.Parameters.Add("@EXOAD_AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(rowData("AMOUNT")), 0, rowData("AMOUNT"))
                                SQLCmd.Parameters.Add("@EXOAD_DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = IIf(IsDBNull(rowData("DEDUCTIBLE")), "No", IIf(rowData("DEDUCTIBLE") = True, "Yes", "No"))
                                SQLCmd.Parameters.Add("@EXOAD_NOTE", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(rowData("NOTE")), "", rowData("NOTE"))
                                SQLCmd.Parameters.Add("@EXOAD_DETAIL", SqlDbType.NVarChar, 30).Value = "No"
                                SQLCmd.Parameters.Add("@EXOAD_TYPE", SqlDbType.NVarChar, 255).Value = ""
                                SQLCmd.Parameters.Add("@EXOAD_DEDUCTIBLE_ADD", SqlDbType.NVarChar, 30).Value = IIf(IsDBNull(rowData("DEDUCTIBLE_ADD")), "No", IIf(rowData("DEDUCTIBLE_ADD") = True, "Yes", "No"))
                                SQLCmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = RowIndex
                                SQLCmd.Parameters.Add("@Pecentage", SqlDbType.Int).Value = 0
                                SQLCmd.Parameters.Add("@PecentageAmount", SqlDbType.Decimal).Value = 0
                                ListofSQLCmd.Add(SQLCmd)

                            Case Else

                                SQLCmd = Nothing
                                SQLCmd = New SqlCommand
                                RaiseEvent OnProgress(ProgressNo, Me.dsDataset.Tables("PNL_QUICK_DETAIL").Rows.Count, rowInfo("SaveQuery"))
                                SQLCmd.CommandText = rowInfo("SaveQuery")
                                SQLCmd.Connection = SQLCon
                                SQLCmd.Parameters.Add("@PNLKEY", SqlDbType.Int).Value = PNL_KEY
                                tmpID = IIf(IsDBNull(rowData("ID")), 0, rowData("ID"))
                                SQLCmd.Parameters.Add("@KEY", SqlDbType.Int).Value = tmpID
                                SQLCmd.Parameters.Add("@SOURCENO", SqlDbType.Int).Value = IIf(IsDBNull(rowData("SOURCE_NO")), 0, rowData("SOURCE_NO"))
                                SQLCmd.Parameters.Add("@DESC", SqlDbType.NVarChar, 255).Value = IIf(IsDBNull(rowData("DESCRIPTION")), "", rowData("DESCRIPTION"))
                                SQLCmd.Parameters.Add("@AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(rowData("AMOUNT")), 0, rowData("AMOUNT"))
                                SQLCmd.Parameters.Add("@NOTE", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(rowData("NOTE")), 0, rowData("NOTE"))
                                SQLCmd.Parameters.Add("@RowIndex", SqlDbType.Int).Value = RowIndex
                                ' SQLCmd.Parameters.Add("@DETAIL", SqlDbType.Int).Value = IIf(IsDBNull(rowData("NOTE")), 0, rowData("NOTE"))

                                If IsDBNull(rowInfo("ColumnAddBack")) = False AndAlso rowInfo("ColumnAddBack") <> "" Then
                                    SQLCmd.Parameters.Add("@DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = IIf(IsDBNull(rowData("DEDUCTIBLE")), "No", IIf(rowData("DEDUCTIBLE") = True, "Yes", "No"))
                                End If
                                If IsDBNull(rowInfo("ColumnDeduct")) = False AndAlso rowInfo("ColumnDeduct") <> "" Then
                                    SQLCmd.Parameters.Add("@DEDUCTIBLE_ADD", SqlDbType.NVarChar, 30).Value = IIf(IsDBNull(rowData("DEDUCTIBLE_ADD")), "No", IIf(rowData("DEDUCTIBLE_ADD") = True, "Yes", "No"))
                                End If
                                If IsDBNull(rowInfo("ColumnPercentage")) = False AndAlso rowInfo("ColumnPercentage") <> "" Then
                                    SQLCmd.Parameters.Add("@Pecentage", SqlDbType.Int).Value = IIf(IsDBNull(rowData("PECENTAGE")), 0, rowData("PECENTAGE"))
                                End If
                                If IsDBNull(rowInfo("ColumnPecentage_Amount")) = False AndAlso rowInfo("ColumnPecentage_Amount") <> "" Then
                                    SQLCmd.Parameters.Add("@PecentageAmount", SqlDbType.Decimal).Value = IIf(IsDBNull(rowData("PECENTAGE_AMOUNT")), 0, rowData("PECENTAGE_AMOUNT"))
                                End If

                                Count_Sub = Me.dsDataset.Tables("PNL_QUICK_DETAIL_SUB").Compute("COUNT(PARENT_ID)", "PARENT_ID = " & tmpID)
                                If Count_Sub > 0 Then
                                    SQLCmd.Parameters.Add("@DETAIL", SqlDbType.NVarChar, 30).Value = "Yes"
                                Else
                                    SQLCmd.Parameters.Add("@DETAIL", SqlDbType.NVarChar, 30).Value = "No"
                                End If

                                ListofSQLCmd.Add(SQLCmd)
                                RowIndex_Details = 0
                                SQLCmd_Details = Nothing

                                For Each rowData_Details As DataRow In Me.dsDataset.Tables("PNL_QUICK_DETAIL_SUB").Rows

                                    If IsDBNull(rowData("PARENT_ID")) = False AndAlso rowData("PARENT_ID") = tmpID Then
                                        If IsDBNull(rowInfo("SaveQuery_Details")) = False AndAlso rowInfo("SaveQuery_Details") <> "" Then
                                            RowIndex_Details += 1

                                            SQLCmd_Details = New SqlCommand
                                            SQLCmd_Details.CommandText = rowInfo("SaveQuery_Details")
                                            SQLCmd_Details.Connection = SQLCon
                                            SQLCmd_Details.Parameters.Add("@PNLKEY", SqlDbType.Int).Value = PNL_KEY
                                            SQLCmd_Details.Parameters.Add("@Parent_ID", SqlDbType.Int).Value = tmpID
                                            SQLCmd_Details.Parameters.Add("@SOURCENO", SqlDbType.Int).Value = IIf(IsDBNull(rowData_Details("SOURCE_NO")), 0, rowData_Details("SOURCE_NO"))
                                            SQLCmd_Details.Parameters.Add("@KEY", SqlDbType.Int).Value = IIf(IsDBNull(rowData_Details("ID")), 0, rowData_Details("ID"))
                                            SQLCmd_Details.Parameters.Add("@DESC", SqlDbType.NVarChar, 255).Value = IIf(IsDBNull(rowData_Details("DESCRIPTION")), "", rowData_Details("DESCRIPTION"))
                                            SQLCmd_Details.Parameters.Add("@AMOUNT", SqlDbType.Decimal).Value = IIf(IsDBNull(rowData_Details("AMOUNT")), "", rowData_Details("AMOUNT"))
                                            SQLCmd_Details.Parameters.Add("@NOTE", SqlDbType.NVarChar, 3000).Value = IIf(IsDBNull(rowData_Details("NOTE")), 0, rowData_Details("NOTE"))

                                            If IsDBNull(rowInfo("ColumnAddBack_Details")) = False AndAlso rowInfo("ColumnAddBack_Details") <> "" Then
                                                SQLCmd_Details.Parameters.Add("@DEDUCTIBLE", SqlDbType.NVarChar, 30).Value = IIf(IsDBNull(rowData_Details("DEDUCTIBLE")), "No", IIf(rowData_Details("DEDUCTIBLE") = True, "Yes", "No"))
                                            End If
                                            If IsDBNull(rowInfo("ColumnDeduct_Details")) = False AndAlso rowInfo("ColumnDeduct_Details") <> "" Then
                                                SQLCmd_Details.Parameters.Add("@DEDUCTIBLE_ADD", SqlDbType.NVarChar, 30).Value = IIf(IsDBNull(rowData_Details("DEDUCTIBLE_ADD")), "No", IIf(rowData_Details("DEDUCTIBLE_ADD") = True, "Yes", "No"))
                                            End If
                                            If IsDBNull(rowInfo("ColumnRowIndex_Details")) = False AndAlso rowInfo("ColumnRowIndex_Details") <> "" Then
                                                SQLCmd_Details.Parameters.Add("@RowIndex", SqlDbType.Int).Value = RowIndex_Details
                                            End If
                                            If IsDBNull(rowInfo("ColumnPercentage_Details")) = False AndAlso rowInfo("ColumnPercentage_Details") <> "" Then
                                                SQLCmd_Details.Parameters.Add("@Pecentage", SqlDbType.Int).Value = IIf(IsDBNull(rowData_Details("PECENTAGE")), 0, rowData_Details("PECENTAGE"))
                                            End If
                                            If IsDBNull(rowInfo("ColumnPecentage_Amount_Details")) = False AndAlso rowInfo("ColumnPecentage_Amount_Details") <> "" Then
                                                SQLCmd_Details.Parameters.Add("@PecentageAmount", SqlDbType.Decimal).Value = IIf(IsDBNull(rowData_Details("PECENTAGE_AMOUNT")), 0, rowData_Details("PECENTAGE_AMOUNT"))
                                            End If

                                            ListofSQLCmd.Add(SQLCmd_Details)
                                        End If

                                    End If

                                Next

                        End Select

                    End If

                Next

            Next

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(Errorlog)
            ChangeStatus(EnumStatus.Failed)
        End Try
    End Sub
    ''' <summary>
    ''' Get_NonAllowableExpenses get total amount and details non allowable including Movement (Optional)
    ''' IncludeMovement = True is Include movement non allowable, False is Not include movement
    ''' </summary>
    Public Sub Get_NonAllowableExpenses(ByRef Amount_NonAllowableExp As Decimal, Optional IncludeMovement As Boolean = True)
        Try
            ChangeStatus(EnumStatus.InProgress)

            Dim dtInfo As DataTable = Me.dsDataset.Tables("PNL_TABLE_INFO")
            If dtInfo Is Nothing Then
                With Errorlog
                    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                    .ErrorCode = "A001"
                    .ErrorDateTime = Now
                    .ErrorMessage = "No PNL Info found."
                End With
                ChangeStatus(EnumStatus.Failed)
                Exit Sub
            End If

            Me.dsDataset.Tables("PNL_QUICK_DETAIL_NONALLOWABLE_EXP").Rows.Clear()

            For Each rowInfo As DataRow In dtInfo.Rows

                If IsDBNull(rowInfo("KeyName")) = False AndAlso rowInfo("KeyName") <> "" Then
                    If IsDBNull(rowInfo("ColumnPecentage_Amount")) = False AndAlso rowInfo("ColumnPecentage_Amount") <> "" Then

                        For Each rowData As DataRow In Me.dsDataset.Tables("PNL_QUICK_DETAIL").Rows

                            If IsDBNull(rowData("KeyName")) = False AndAlso rowData("KeyName") <> "" AndAlso rowInfo("KeyName") = rowData("KeyName") Then
                                Me.dsDataset.Tables("PNL_QUICK_DETAIL_NONALLOWABLE_EXP").ImportRow(rowData)
                            End If

                        Next

                    End If
                End If

            Next
            If RefNo = "" OrElse YA = "" Then
                ChangeStatus(EnumStatus.Done)
                Exit Sub
            End If

            Dim dtMovement As DataTable = Nothing

            dtMovement = clsMoveNormal.Load_MovementNormal(RefNo, YA, Errorlog)

            If dtMovement IsNot Nothing Then
                For i As Integer = 0 To dtMovement.Rows.Count - 1
                    If IsDBNull(dtMovement.Rows(i)("MM_TYPE_PASS")) = False AndAlso dtMovement.Rows(i)("MM_TYPE_PASS") = 1 Then
                        dtRow = Nothing

                        dtRow = Nothing
                        dtRow = Me.dsDataset.Tables("PNL_QUICK_DETAIL_NONALLOWABLE_EXP").NewRow()
                        dtRow("KEYNAME") = "MOVEMENT_NORMAL"
                        dtRow("SOURCE_NO") = IIf(IsDBNull(dtMovement.Rows(i)("MM_SOURCENO")), 0, dtMovement.Rows(i)("MM_SOURCENO"))
                        dtRow("DESCRIPTION") = IIf(IsDBNull(dtMovement.Rows(i)("MM_TITLE")), "", dtMovement.Rows(i)("MM_TITLE"))
                        dtRow("AMOUNT") = IIf(IsDBNull(dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT")), 0, dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT"))
                        dtRow("Note") = ""
                        dtRow("DEDUCTIBLE") = True
                        dtRow("DEDUCTIBLE_ADD") = False
                        dtRow("PECENTAGE") = 100
                        dtRow("PECENTAGE_AMOUNT") = IIf(IsDBNull(dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT")), 0, dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT"))
                        Me.dsDataset.Tables("PNL_QUICK_DETAIL_NONALLOWABLE_EXP").Rows.Add(dtRow)
                    End If
                Next
            End If
            dtMovement = Nothing
            dtMovement = ADO.Load_MovementComplex(RefNo, YA, Errorlog)

            If dtMovement IsNot Nothing Then
                For i As Integer = 0 To dtMovement.Rows.Count - 1
                    If IsDBNull(dtMovement.Rows(i)("MM_TYPE_PASS")) = False AndAlso dtMovement.Rows(i)("MM_TYPE_PASS") = 1 Then
                        dtRow = Nothing

                        dtRow = Nothing
                        dtRow = Me.dsDataset.Tables("PNL_QUICK_DETAIL_NONALLOWABLE_EXP").NewRow()
                        dtRow("KEYNAME") = "MOVEMENT_COMPLEX"
                        dtRow("SOURCE_NO") = IIf(IsDBNull(dtMovement.Rows(i)("MM_SOURCENO")), 0, dtMovement.Rows(i)("MM_SOURCENO"))
                        dtRow("DESCRIPTION") = IIf(IsDBNull(dtMovement.Rows(i)("MM_TITLE")), "", dtMovement.Rows(i)("MM_TITLE"))
                        dtRow("AMOUNT") = IIf(IsDBNull(dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT")), 0, dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT"))
                        dtRow("Note") = ""
                        dtRow("DEDUCTIBLE") = True
                        dtRow("DEDUCTIBLE_ADD") = False
                        dtRow("PECENTAGE") = 100
                        dtRow("PECENTAGE_AMOUNT") = IIf(IsDBNull(dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT")), 0, dtMovement.Rows(i)("MM_ADD_DEDUCT_AMOUNT"))
                        Me.dsDataset.Tables("PNL_QUICK_DETAIL_NONALLOWABLE_EXP").Rows.Add(dtRow)
                    End If
                Next
            End If

            Dim Total As Decimal = 0
            For Each rowData As DataRow In Me.dsDataset.Tables("PNL_QUICK_DETAIL_NONALLOWABLE_EXP").Rows

                If IsDBNull(rowData("PECENTAGE_AMOUNT")) = False AndAlso IsNumeric(rowData("PECENTAGE_AMOUNT")) Then
                    Total += rowData("PECENTAGE_AMOUNT")
                End If
            Next

            Amount_NonAllowableExp = Total
            ChangeStatus(EnumStatus.Done)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(Errorlog)
            ChangeStatus(EnumStatus.Failed)
        End Try
    End Sub
    ''' <summary>
    ''' Calculate_CategoryTotal function to calculate all or partially category
    ''' PartOfKeyNameOnly = Calculate partial category
    ''' </summary>
    Public Sub Calculate_CategoryTotal(Optional PartOfKeyNameOnly As String = "")
        Dim tmpDebug As String = ""
        Try
            ChangeStatus(EnumStatus.InProgress)


            Dim Total As Decimal = 0
            Dim PercentageAmount As Decimal = 0
            Dim p1Sales As Decimal = 0
            Dim P1Purchase As Decimal = 0
            Dim P1OpenStock As Decimal = 0
            Dim P1CloseStock As Decimal = 0
            Dim p1COP As Decimal = 0
            Dim p1PCP As Decimal = 0
            Dim p1COS As Decimal = 0
            Dim p2Dividen As Decimal = 0
            Dim p2Interest As Decimal = 0
            Dim p2Rental As Decimal = 0
            Dim p2Royalty As Decimal = 0
            Dim p2NonBizIncome As Decimal = 0
            Dim GrossProfitLoss As Decimal = 0

            Dim p2ProDispPlantEq As Decimal = 0
            Dim p2Other As Decimal = 0
            Dim p2ExemptDividend As Decimal = 0
            Dim p2ForeIncomeRemmit As Decimal = 0
            Dim p2ReaForeExGainNonTrade As Decimal = 0
            Dim p2UnreaGainForeEx As Decimal = 0
            Dim p2UnreaGainForeExNon As Decimal = 0
            Dim p2ProDisInvestment As Decimal = 0

            Me.dsDataset.Tables("PNL_TABLE_INFO_MAIN").Rows.Clear()
            Application.DoEvents()
            For Each rowInfoMain As DataRow In Me.dsDataset.Tables("PNL_TABLE_INFO_MAIN_DEFAULT").Rows
                Me.dsDataset.Tables("PNL_TABLE_INFO_MAIN").ImportRow(rowInfoMain)
            Next
            For Each rowQuick As DataRow In Me.dsDataset.Tables("PNL_QUICK").Rows
                Total = 0

                For Each rowxDetails As DataRow In Me.dsDataset.Tables("PNL_QUICK_DETAIL").Rows

                    If PartOfKeyNameOnly = "" Then
                        If rowQuick("KeyName") = rowxDetails("KeyName") AndAlso IsDBNull(rowxDetails("Amount")) = False Then

                            Total += CDec(rowxDetails("Amount"))

                            If IsDBNull(rowxDetails("PECENTAGE")) = False AndAlso rowxDetails("PECENTAGE") <> 0 Then
                                PercentageAmount = (CDec(rowxDetails("PECENTAGE")) / 100) * CDec(rowxDetails("AMOUNT"))
                                rowxDetails("PECENTAGE_AMOUNT") = PercentageAmount
                            End If

                        End If
                    Else
                        If rowQuick("KeyName") = PartOfKeyNameOnly AndAlso rowQuick("KeyName") = rowxDetails("KeyName") AndAlso IsDBNull(rowxDetails("Amount")) = False Then

                            Total += CDec(rowxDetails("Amount"))

                            If IsDBNull(rowxDetails("PECENTAGE")) = False AndAlso rowxDetails("PECENTAGE") <> 0 Then
                                PercentageAmount = (CDec(rowxDetails("PECENTAGE")) / 100) * CDec(rowxDetails("AMOUNT"))
                                rowxDetails("PECENTAGE_AMOUNT") = PercentageAmount
                            End If

                        End If
                    End If

                Next


                rowQuick("Amount") = Total

                For Each rowInfoMain As DataRow In Me.dsDataset.Tables("PNL_TABLE_INFO_MAIN").Rows
                    If IsDBNull(rowInfoMain("KeyName")) = False Then
                        rowInfoMain("Operator") = Regex.Replace(rowInfoMain("Operator"), "\b" + Regex.Escape(rowQuick("KeyName").ToString) + "\b", Total.ToString, RegexOptions.IgnoreCase)

                    End If
                Next

                Application.DoEvents()
            Next

            For Each rowInfoMain As DataRow In Me.dsDataset.Tables("PNL_TABLE_INFO_MAIN").Rows
                For Each rowInfo As DataRow In Me.dsDataset.Tables("PNL_TABLE_INFO").Rows
                    If IsDBNull(rowInfo("KeyName")) = False Then
                        rowInfoMain("Operator") = Regex.Replace(rowInfoMain("Operator"), "\b" + Regex.Escape(rowInfo("KeyName").ToString) + "\b", "0", RegexOptions.IgnoreCase)
                    End If
                Next
            Next

            Dim tmpTotal As Decimal = 0
            For Each rowInfoMain As DataRow In Me.dsDataset.Tables("PNL_TABLE_INFO_MAIN").Rows
                tmpTotal = Equation(rowInfoMain)
                rowInfoMain("Amount") = tmpTotal
                Application.DoEvents()
                For Each rowInfoMain2 As DataRow In Me.dsDataset.Tables("PNL_TABLE_INFO_MAIN").Rows
                    If Regex.IsMatch(rowInfoMain2("Operator").ToString, "\b" + Regex.Escape(rowInfoMain("KeyName").ToString) + "\b", RegexOptions.IgnoreCase) Then
                        rowInfoMain2("Operator") = Regex.Replace(rowInfoMain2("Operator"), "\b" + Regex.Escape(rowInfoMain("KeyName").ToString) + "\b", tmpTotal.ToString, RegexOptions.IgnoreCase)
                    End If
                Next
            Next

            RaiseEvent OnChangeInfo(Me.dsDataset, Errorlog)

            ChangeStatus(EnumStatus.Done)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(Errorlog)
            ChangeStatus(EnumStatus.Failed)
        End Try
    End Sub
    Private Function Equation(ByVal RowData As DataRow) As Decimal
        Try
            Dim e As Expression = New Expression(RowData("Operator").ToString)
            Dim Total As Decimal = 0
            Total = e.calculate()

            Return Total
        Catch ex As Exception

        End Try
    End Function
    ''' <summary>
    ''' Insert_AutoDataToCategory function to insert all data to specific category.
    ''' dsData =  dataset contain all data from orginal or database table
    ''' </summary>
    Public Sub Insert_AutoDataToCategory(ByVal dsData As DataSet)
        Try
            ChangeStatus(EnumStatus.InProgress)
            Dim dtInfo As DataTable = Me.dsDataset.Tables("PNL_TABLE_INFO")

            If dtInfo Is Nothing Then
                With Errorlog
                    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                    .ErrorCode = "A001"
                    .ErrorDateTime = Now
                    .ErrorMessage = "No PNL Info found."
                End With
                ChangeStatus(EnumStatus.Failed)
                Exit Sub
            End If

            Me.dsDataset.Tables("PNL_QUICK_DETAIL").Rows.Clear()
            Dim KeyName As String = Nothing
            Dim TableName As String = Nothing
            Dim TableName_Details As String = Nothing
            Dim ColumnSourceNo As String = Nothing
            Dim ColumnSourceNo_Details As String = Nothing
            Dim ColumnAmount As String = Nothing
            Dim ColumnAmount_Details As String = Nothing
            Dim ColumnTable As String = Nothing
            Dim ColumnTable_Details As String = Nothing
            Dim ColumnAddBack As String = Nothing
            Dim ColumnAddBack_Details As String = Nothing
            Dim ColumnDeduct As String = Nothing
            Dim ColumnDeduct_Details As String = Nothing
            Dim ColumnPercentage As String = Nothing
            Dim Type As EnumTypeCategory = EnumTypeCategory.NoDeduct_1
            Dim PrefixName As String = Nothing
            Dim ID As Integer = 0
            For Each rowInfo As DataRow In dtInfo.Rows

                If IsDBNull(rowInfo("KeyName")) = False AndAlso rowInfo("KeyName") <> "" Then
                    KeyName = rowInfo("KeyName")
                    TableName = IIf(IsDBNull(rowInfo("TableName")), "", rowInfo("TableName"))
                    TableName_Details = IIf(IsDBNull(rowInfo("TableName_Details")), "", rowInfo("TableName_Details"))
                    ColumnSourceNo = IIf(IsDBNull(rowInfo("ColumnSourceNo")), "", rowInfo("ColumnSourceNo"))
                    ColumnSourceNo_Details = IIf(IsDBNull(rowInfo("ColumnSourceNo_Details")), "", rowInfo("ColumnSourceNo_Details"))
                    ColumnDescription = IIf(IsDBNull(rowInfo("ColumnDescription")), "", rowInfo("ColumnDescription"))
                    ColumnDescription_Details = IIf(IsDBNull(rowInfo("ColumnDescription_Details")), "", rowInfo("ColumnDescription_Details"))
                    ColumnAmount = IIf(IsDBNull(rowInfo("ColumnAmount")), "", rowInfo("ColumnAmount"))
                    ColumnAmount_Details = IIf(IsDBNull(rowInfo("ColumnAmount_Details")), "", rowInfo("ColumnAmount_Details"))
                    ColumnTable = IIf(IsDBNull(rowInfo("ColumnTable")), "", rowInfo("ColumnTable"))
                    ColumnTable_Details = IIf(IsDBNull(rowInfo("ColumnTable_Details")), "", rowInfo("ColumnTable_Details"))
                    ColumnAddBack = IIf(IsDBNull(rowInfo("ColumnAddBack")), "", rowInfo("ColumnAddBack"))
                    ColumnAddBack_Details = IIf(IsDBNull(rowInfo("ColumnAddBack_Details")), "", rowInfo("ColumnAddBack_Details"))
                    ColumnDeduct = IIf(IsDBNull(rowInfo("ColumnDeduct")), "", rowInfo("ColumnDeduct"))
                    ColumnDeduct_Details = IIf(IsDBNull(rowInfo("ColumnDeduct_Details")), "", rowInfo("ColumnDeduct_Details"))
                    ColumnPercentage = IIf(IsDBNull(rowInfo("ColumnPecentage_Amount")), "", rowInfo("ColumnPecentage_Amount"))
                    Type = IIf(IsDBNull(rowInfo("Type")), 1, rowInfo("Type"))
                    PrefixName = IIf(IsDBNull(rowInfo("PrefixName")), "", rowInfo("PrefixName"))

                    'Insert data (parent)
                    For Each rowData As DataRow In dsData.Tables(TableName).Rows
                        dtRow = Nothing
                        ID = -1
                        dtRow = Me.dsDataset.Tables("PNL_QUICK_DETAIL").NewRow
                        dtRow("KEYNAME") = KeyName
                        dtRow("SOURCE_NO") = rowData(ColumnSourceNo)
                        dtRow("DESCRIPTION") = rowData(ColumnDescription)
                        dtRow("AMOUNT") = rowData(ColumnAmount)
                        If PrefixName <> "" AndAlso KeyName <> "DIVIDENDINC" AndAlso KeyName <> "RENTALINC" Then
                            dtRow("NOTE") = rowData(PrefixName & "_NOTE")
                        Else
                            dtRow("NOTE") = ""
                        End If
                        Select Case Type
                            Case EnumTypeCategory.WithOutPercentage_2
                                dtRow("DEDUCTIBLE") = rowData(ColumnAddBack)
                                If ColumnDeduct <> "" Then
                                    dtRow("DEDUCTIBLE_ADD") = rowData(ColumnDeduct)
                                Else
                                    dtRow("DEDUCTIBLE_ADD") = False
                                End If
                                If rowData(ColumnAddBack) = True Then
                                    dtRow("PECENTAGE") = 100
                                    dtRow("PECENTAGE_AMOUNT") = rowData("PecentageAmount")
                                Else
                                    dtRow("PECENTAGE") = 0
                                    dtRow("PECENTAGE_AMOUNT") = rowData("PecentageAmount")
                                End If
                            Case EnumTypeCategory.Percentage_3
                                dtRow("DEDUCTIBLE") = rowData(ColumnAddBack)
                                dtRow("DEDUCTIBLE_ADD") = rowData(ColumnDeduct)
                                If rowData(ColumnAddBack) = True Then
                                    dtRow("PECENTAGE") = rowData("Pecentage")
                                    dtRow("PECENTAGE_AMOUNT") = rowData("PecentageAmount")
                                Else
                                    dtRow("PECENTAGE") = 0
                                    dtRow("PECENTAGE_AMOUNT") = rowData("PecentageAmount")
                                End If
                            Case Else
                                dtRow("DEDUCTIBLE") = False
                                dtRow("DEDUCTIBLE_ADD") = False
                                dtRow("PECENTAGE") = 100
                                dtRow("PECENTAGE_AMOUNT") = 0
                        End Select
                    Next

                    Me.dsDataset.Tables("PNL_QUICK_DETAIL").Rows.Add(dtRow)
                    Application.DoEvents()
                    ID = Me.dsDataset.Tables("PNL_QUICK_DETAIL").Rows(Me.dsDataset.Tables("PNL_QUICK_DETAIL").Rows.Count - 1)("ID")

                    'Insert Details to parent
                    If TableName_Details <> "" Then
                        For Each rowChild As DataRow In Me.dsDataset.Tables(TableName_Details).Rows
                            If IsDBNull(dtRow(ColumnTable)) = False AndAlso IsDBNull(rowChild(ColumnTable_Details)) = False AndAlso
                                dtRow(ColumnTable) = rowChild(ColumnTable_Details) AndAlso ID <> -1 Then

                                dtRowChild = Nothing
                                dtRowChild = Me.dsDataset.Tables("PNL_QUICK_DETAIL_SUB").NewRow
                                dtRowChild("PARENT_ID") = ID
                                dtRowChild("KEYNAME") = KeyName
                                dtRowChild("SOURCE_NO") = rowChild(ColumnSourceNo_Details)
                                dtRowChild("DESCRIPTION") = rowChild(ColumnDescription_Details)
                                dtRowChild("AMOUNT") = rowChild(ColumnAmount_Details)
                                If PrefixName <> "" AndAlso KeyName <> "DIVIDENDINC" AndAlso KeyName <> "RENTALINC" Then
                                    dtRowChild("NOTE") = rowChild(PrefixName & "D_NOTE")
                                Else
                                    dtRowChild("NOTE") = ""
                                End If


                                Select Case Type
                                    Case 2
                                        'Without Percentage
                                        dtRowChild("DEDUCTIBLE") = rowChild(ColumnAddBack_Details)
                                        If ColumnDeduct_Details <> "" Then
                                            dtRowChild("DEDUCTIBLE_ADD") = rowChild(ColumnDeduct_Details)
                                        Else
                                            dtRowChild("DEDUCTIBLE_ADD") = False
                                        End If
                                        If rowChild(ColumnAddBack_Details) = True Then
                                            dtRowChild("PECENTAGE") = 100
                                            dtRowChild("PECENTAGE_AMOUNT") = rowChild("PecentageAmount")
                                        Else
                                            dtRowChild("PECENTAGE") = 0
                                            dtRowChild("PECENTAGE_AMOUNT") = rowChild("PecentageAmount")
                                        End If

                                    Case 3
                                        'Percentage
                                        dtRowChild("DEDUCTIBLE") = rowChild(ColumnAddBack_Details)
                                        dtRowChild("DEDUCTIBLE_ADD") = rowChild(ColumnDeduct_Details)

                                        If rowChild(ColumnAddBack_Details) = True Then
                                            dtRowChild("PECENTAGE") = rowChild("Pecentage")
                                            dtRowChild("PECENTAGE_AMOUNT") = rowChild("PecentageAmount")
                                        Else
                                            dtRowChild("PECENTAGE") = 0
                                            dtRowChild("PECENTAGE_AMOUNT") = rowChild("PecentageAmount")
                                        End If

                                    Case Else
                                        'Not Deduct
                                        dtRowChild("DEDUCTIBLE") = False
                                        dtRowChild("DEDUCTIBLE_ADD") = False
                                        dtRowChild("PECENTAGE") = 100
                                        dtRowChild("PECENTAGE_AMOUNT") = 0
                                End Select

                                Me.dsDataset.Tables("PNL_QUICK_DETAIL_SUB").Rows.Add(dtRowChild)

                            End If

                        Next
                    End If
                End If

            Next

            RaiseEvent OnChangeInfo(Me.dsDataset, Errorlog)
            ChangeStatus(EnumStatus.Done)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(Errorlog)
            ChangeStatus(EnumStatus.Failed)
        Finally
            Me.Calculate_CategoryTotal()
        End Try
    End Sub
    ''' <summary>
    ''' Insert_ManualDataToCategory function to insert 1 data to specific category.
    ''' KeyName = Category code name
    ''' SourceNo = Business Source No
    ''' Description = Description Items
    ''' Amount = Amount Items
    ''' Deduct = Deduct
    ''' Deduct_Add = Add Back
    ''' Percentage = Percentage expenses calculate add back
    ''' Percentage_Amount = Final amount add back
    ''' Note = Note items
    ''' Type = Type category normal = NoDeduct, without percentage (expenses),  Percentage (expense with percentage)
    ''' </summary>
    Public Sub Insert_ManualDataToCategory(ByVal KeyName As String, ByVal SourceNo As Integer, ByVal Description As String, _
                                           ByVal Amount As Decimal, ByVal Deduct As Boolean, ByVal Deduct_Add As Boolean, _
                                           ByVal Percentage As Integer, ByVal Percentage_Amount As Decimal, _
                                           ByVal Note As String, Type As EnumTypeCategory)
        Try
            ChangeStatus(EnumStatus.InProgress)
            Dim dtInfo As DataRow = Me.Find_KeyName(KeyName)

            If dtInfo Is Nothing Then
                With Errorlog
                    .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                    .ErrorCode = "A001"
                    .ErrorDateTime = Now
                    .ErrorMessage = "No PNL Info found."
                End With
                ChangeStatus(EnumStatus.Failed)
                Exit Sub
            End If

            dtRow = Nothing
            dtRow = Me.dsDataset.Tables("PNL_QUICK_DETAIL").NewRow()
            dtRow("KEYNAME") = KeyName
            dtRow("SOURCE_NO") = SourceNo
            dtRow("DESCRIPTION") = Description
            dtRow("AMOUNT") = Amount
            dtRow("Note") = Note

            Select Case Type
                Case EnumTypeCategory.WithOutPercentage_2
                    dtRow("DEDUCTIBLE") = Deduct
                    If IsDBNull(dtInfo("ColumnAddBack")) = False AndAlso dtInfo("ColumnAddBack") <> "" Then
                        dtRow("DEDUCTIBLE_ADD") = Deduct_Add
                    Else
                        dtRow("DEDUCTIBLE_ADD") = False
                    End If

                    If Deduct = True Then
                        dtRow("PECENTAGE") = 100
                        dtRow("PECENTAGE_AMOUNT") = Percentage_Amount
                    Else
                        dtRow("PECENTAGE") = 0
                        dtRow("PECENTAGE_AMOUNT") = Percentage_Amount
                    End If

                Case EnumTypeCategory.Percentage_3
                    dtRow("DEDUCTIBLE") = Deduct
                    dtRow("DEDUCTIBLE_ADD") = Deduct_Add
                    If Deduct_Add = True Then
                        dtRow("PECENTAGE") = Percentage
                        dtRow("PECENTAGE_AMOUNT") = Percentage_Amount
                    Else
                        dtRow("PECENTAGE") = 0
                        dtRow("PECENTAGE_AMOUNT") = Percentage_Amount
                    End If
                Case Else
                    dtRow("DEDUCTIBLE") = False
                    dtRow("DEDUCTIBLE_ADD") = False
                    dtRow("PECENTAGE") = 100
                    dtRow("PECENTAGE_AMOUNT") = 0
            End Select
            Me.dsDataset.Tables("PNL_QUICK_DETAIL").Rows.Add(dtRow)

            RaiseEvent OnChangeData(KeyName, dtRow, Errorlog)
            ChangeStatus(EnumStatus.Done)
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(Errorlog)
            ChangeStatus(EnumStatus.Failed)
        Finally
            Me.Calculate_CategoryTotal()
        End Try
    End Sub
#Region "Event"
    Public Sub ChangeStatus(ByVal Status_ As EnumStatus)
        Try
            Status = Status_
            RaiseEvent OnChangeStatus(Status_, Errorlog)
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class
