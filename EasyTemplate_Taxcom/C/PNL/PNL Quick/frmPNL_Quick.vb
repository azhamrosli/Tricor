Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns

Public Class frmPNL_Quick
    Dim ErrorLog As ClsError = Nothing
    Dim isMappingCode As Boolean = False

    Private Sub frmPNL_Quick_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Try
            Dim dtInfo As DataTable = ADO.Load_PNLINFO()

            dsDataSet.Tables("PNL_QUICK_DETAIL_SUB").Rows.Clear()
            dsDataSet.Tables("PNL_QUICK_DETAIL").Rows.Clear()
            dsDataSet.Tables("PNL_QUICK").Rows.Clear()
            dsDataSet.Tables("PNL_TABLE_INFO").Rows.Clear()

            If dtInfo IsNot Nothing Then
                Dim dtRow As DataRow = Nothing
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
                Dim Type As Integer = 0
                Dim PrefixName As String = Nothing
                For Each rowx As DataRow In dtInfo.Rows
                    dsDataSet.Tables("PNL_TABLE_INFO").ImportRow(rowx)

                    'PNL QUICK
                    dtRow = Nothing
                    If IsDBNull(rowx("KeyName")) = False Then

                        If isVersionLicenseType = VersionLicenseType.Tricor AndAlso IsDBNull(rowx("LabelNameTricor")) = False AndAlso rowx("LabelNameTricor") <> "" Then
                            dtRow = dsDataSet.Tables("PNL_QUICK").NewRow
                            dtRow("KEYNAME") = rowx("KeyName")
                            dtRow("DESCRIPTION") = IIf(IsDBNull(rowx("LabelNameTricor")), "", rowx("LabelNameTricor"))
                            dtRow("AMOUNT") = 0
                            dsDataSet.Tables("PNL_QUICK").Rows.Add(dtRow)
                        ElseIf isVersionLicenseType = VersionLicenseType.Normal AndAlso IsDBNull(rowx("LabelName")) = False AndAlso rowx("LabelName") <> "" Then
                            dtRow = dsDataSet.Tables("PNL_QUICK").NewRow
                            dtRow("KEYNAME") = rowx("KeyName")
                            dtRow("DESCRIPTION") = IIf(IsDBNull(rowx("LabelName")), "", rowx("LabelName"))
                            dtRow("AMOUNT") = 0
                            dsDataSet.Tables("PNL_QUICK").Rows.Add(dtRow)
                        End If

                        TableName = IIf(IsDBNull(rowx("TableName")), "", rowx("TableName"))
                        TableName_Details = IIf(IsDBNull(rowx("TableName_Details")), "", rowx("TableName_Details"))
                        ColumnSourceNo = IIf(IsDBNull(rowx("ColumnSourceNo")), "", rowx("ColumnSourceNo"))
                        ColumnSourceNo_Details = IIf(IsDBNull(rowx("ColumnSourceNo_Details")), "", rowx("ColumnSourceNo_Details"))
                        ColumnDescription = IIf(IsDBNull(rowx("ColumnDescription")), "", rowx("ColumnDescription"))
                        ColumnDescription_Details = IIf(IsDBNull(rowx("ColumnDescription_Details")), "", rowx("ColumnDescription_Details"))
                        ColumnAmount = IIf(IsDBNull(rowx("ColumnAmount")), "", rowx("ColumnAmount"))
                        ColumnAmount_Details = IIf(IsDBNull(rowx("ColumnAmount_Details")), "", rowx("ColumnAmount_Details"))
                        ColumnTable = IIf(IsDBNull(rowx("ColumnTable")), "", rowx("ColumnTable"))
                        ColumnTable_Details = IIf(IsDBNull(rowx("ColumnTable_Details")), "", rowx("ColumnTable_Details"))
                        ColumnAddBack = IIf(IsDBNull(rowx("ColumnAddBack")), "", rowx("ColumnAddBack"))
                        ColumnAddBack_Details = IIf(IsDBNull(rowx("ColumnAddBack_Details")), "", rowx("ColumnAddBack_Details"))
                        ColumnDeduct = IIf(IsDBNull(rowx("ColumnDeduct")), "", rowx("ColumnDeduct"))
                        ColumnDeduct_Details = IIf(IsDBNull(rowx("ColumnDeduct_Details")), "", rowx("ColumnDeduct_Details"))
                        ColumnPercentage = IIf(IsDBNull(rowx("ColumnPecentage_Amount")), "", rowx("ColumnPecentage_Amount"))
                        Type = IIf(IsDBNull(rowx("Type")), 1, rowx("Type"))
                        PrefixName = IIf(IsDBNull(rowx("PrefixName")), "", rowx("PrefixName"))

                        GetSubItemData(rowx("KeyName"), TableName, TableName_Details,
                                       ColumnSourceNo, ColumnSourceNo_Details,
                                       ColumnDescription, ColumnDescription_Details,
                                       ColumnAmount, ColumnAmount_Details, ColumnTable, ColumnTable_Details,
                                       ColumnAddBack, ColumnAddBack_Details, ColumnDeduct, ColumnDeduct_Details,
                                       ColumnPercentage, Type, PrefixName)
                    End If

                Next

                PNLQUICKBindingSource.DataSource = dsDataSet.Tables("PNL_QUICK")
                PNLTABLEINFOBindingSource.DataSource = dsDataSet.Tables("PNL_TABLE_INFO")
                BUSINESSSOURCEBindingSource.DataSource = dsDataSet.Tables("BUSINESS_SOURCE")
                PNLQUICKDETAILBindingSource.DataSource = dsDataSet.Tables("PNL_QUICK_DETAIL")
                CalcTotal()

                ' rowx As DataRow In DsPNL.Tables("PNL_QUICK_DETAIL").Rows
                '    For Each colx As DataColumn In DsPNL.Tables("PNL_QUICK_DETAIL").Columns
                '        Select Case colx.ColumnName
                '            Case "DEDUCTIBLE", "DEDUCTIBLE_ADD"

                '                If IsDBNull(rowx("KEYNAME")) = False Then
                '                    Select Case rowx("KEYNAME")
                '                        Case ""

                '                    End Select
                '                End If


                '        End Select
                '    Next
                'Next

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
    Private Sub GetSubItemData(ByVal KeyName As String, ByVal TableName As String, ByVal TableName_Details As String, _
                               ByVal ColumnSourceNo As String, ByVal ColumnSourceNo_Details As String,
                               ByVal ColumnDescription As String, ByVal ColumnDescription_Details As String, _
                               ByVal ColumnAmount As String, ByVal ColumnAmount_Details As String, _
                               ByVal ColumnTable As String, ByVal ColumnTable_Details As String, _
                               ByVal ColumnAddBack As String, ByVal ColumnAddBack_Details As String, _
                               ByVal ColumnDeduct As String, ByVal ColumnDeduct_Details As String, _
                               ByVal ColumnPercentage As String, ByVal Type As Integer, ByVal PrefixName As String)
        Try
            Dim dtRow As DataRow = Nothing
            Dim dtRowChild As DataRow = Nothing
            Dim ID As Integer = 0
            For Each rowx As DataRow In dsDataSet.Tables(TableName).Rows
                dtRow = Nothing
                ID = -1
                dtRow = dsDataSet.Tables("PNL_QUICK_DETAIL").NewRow
                dtRow("KEYNAME") = KeyName
                dtRow("SOURCE_NO") = rowx(ColumnSourceNo)
                dtRow("DESCRIPTION") = rowx(ColumnDescription)
                dtRow("AMOUNT") = rowx(ColumnAmount)
                If PrefixName <> "" AndAlso KeyName <> "DIVIDENDINC" AndAlso KeyName <> "RENTALINC" Then
                    dtRow("NOTE") = rowx(PrefixName & "_NOTE")
                Else
                    dtRow("NOTE") = ""
                End If

                Select Case Type
                    Case 2
                        'Without Percentage
                        dtRow("DEDUCTIBLE") = rowx(ColumnAddBack)
                        If ColumnDeduct <> "" Then
                            dtRow("DEDUCTIBLE_ADD") = rowx(ColumnDeduct)
                        Else
                            dtRow("DEDUCTIBLE_ADD") = False
                        End If
                        If rowx(ColumnAddBack) = True Then
                            dtRow("PECENTAGE") = 100
                            dtRow("PECENTAGE_AMOUNT") = rowx("PecentageAmount")
                        Else
                            dtRow("PECENTAGE") = 0
                            dtRow("PECENTAGE_AMOUNT") = rowx("PecentageAmount")
                        End If

                    Case 3
                        'Percentage
                        dtRow("DEDUCTIBLE") = rowx(ColumnAddBack)
                        dtRow("DEDUCTIBLE_ADD") = rowx(ColumnDeduct)
                        If rowx(ColumnAddBack) = True Then
                            dtRow("PECENTAGE") = rowx("Pecentage")
                            dtRow("PECENTAGE_AMOUNT") = rowx("PecentageAmount")
                        Else
                            dtRow("PECENTAGE") = 0
                            dtRow("PECENTAGE_AMOUNT") = rowx("PecentageAmount")
                        End If

                    Case Else
                        'Not Deduct
                        dtRow("DEDUCTIBLE") = False
                        dtRow("DEDUCTIBLE_ADD") = False
                        dtRow("PECENTAGE") = 100
                        dtRow("PECENTAGE_AMOUNT") = 0
                End Select

                dsDataSet.Tables("PNL_QUICK_DETAIL").Rows.Add(dtRow)
                Application.DoEvents()

                ID = dsDataSet.Tables("PNL_QUICK_DETAIL").Rows(dsDataSet.Tables("PNL_QUICK_DETAIL").Rows.Count - 1)("ID")

                If TableName_Details <> "" Then
                    For Each rowChild As DataRow In dsDataSet.Tables(TableName_Details).Rows
                        If IsDBNull(rowx(ColumnTable)) = False AndAlso IsDBNull(rowChild(ColumnTable_Details)) = False AndAlso
                            rowx(ColumnTable) = rowChild(ColumnTable_Details) AndAlso ID <> -1 Then

                            dtRowChild = Nothing
                            dtRowChild = dsDataSet.Tables("PNL_QUICK_DETAIL_SUB").NewRow
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

                            dsDataSet.Tables("PNL_QUICK_DETAIL_SUB").Rows.Add(dtRowChild)

                        End If

                    Next
                End If

            Next
            'Select Case KeyName
            '    Case TaxComPNLEnuItem.SALES

            'End Select

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
    Private Sub CalcTotal()
        Try
            Dim Total As Decimal = 0
            Dim PercentageAmount As Decimal = 0
            For Each rowQuick As DataRow In dsDataSet.Tables("PNL_QUICK").Rows
                Total = 0

                For Each rowxDetails As DataRow In dsDataSet.Tables("PNL_QUICK_DETAIL").Rows

                    If rowQuick("KeyName") = rowxDetails("KeyName") AndAlso IsDBNull(rowxDetails("Amount")) = False Then

                        Total += CDec(rowxDetails("Amount"))

                        If IsDBNull(rowxDetails("PECENTAGE")) = False AndAlso rowxDetails("PECENTAGE") <> 0 Then
                            PercentageAmount = (CDec(rowxDetails("PECENTAGE")) / 100) * CDec(rowxDetails("AMOUNT"))
                            rowxDetails("PECENTAGE_AMOUNT") = PercentageAmount
                        End If

                    End If
                Next

                rowQuick("Amount") = Total
                Application.DoEvents()
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

    Private Sub GridView4_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView4.InitNewRow
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)

                view.GetDataRow(e.RowHandle)("KEYNAME") = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "KEYNAME")
                view.GetDataRow(e.RowHandle)("SOURCE_NO") = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "SOURCE_NO")
                view.GetDataRow(e.RowHandle)("AMOUNT") = 0
                view.GetDataRow(e.RowHandle)("PECENTAGE") = 100
                view.GetDataRow(e.RowHandle)("PECENTAGE_AMOUNT") = 0
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView2_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles GridView2.RowCellStyle, GridView4.RowCellStyle
        Try
            Dim view As GridView = CType(sender, GridView)

            Dim dt As DataTable = ADO.Load_PNLINFO(view.GetRowCellValue(e.RowHandle, "KEYNAME"))
            If dt IsNot Nothing Then
                If IsDBNull(dt.Rows(0)("Type")) = False Then
                    Select Case dt.Rows(0)("Type")
                        Case 1
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
                        Case 2
                            Select Case IIf(IsDBNull(dt.Rows(0)("KeyName")), "", dt.Rows(0)("KeyName"))
                                Case "PURCHASE", "DEPRECIATION", "OTHERALLOWEXP", "OTHERNONALLOWEXP"
                                    If e.Column.FieldName = "DEDUCTIBLE_ADD" Then
                                        e.Appearance.BackColor = Color.Gray
                                    End If
                                    If e.Column.FieldName = "PECENTAGE" Then
                                        e.Appearance.BackColor = Color.Gray
                                    End If
                                    If e.Column.FieldName = "PECENTAGE_AMOUNT" Then
                                        e.Appearance.BackColor = Color.Gray
                                    End If
                                Case Else
                                    If e.Column.FieldName = "PECENTAGE" Then
                                        e.Appearance.BackColor = Color.Gray
                                    End If
                                    If e.Column.FieldName = "PECENTAGE_AMOUNT" Then
                                        e.Appearance.BackColor = Color.Gray
                                    End If
                            End Select


                        Case 3

                    End Select
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView2_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView2.RowUpdated
        Try
            CalcTotal()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView4_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView4.RowUpdated
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim Total As Decimal = 0
                Dim PercentageAmount As Decimal = 0
                Dim TotalPercentage As Decimal = 0
                For Each rowParent As DataRow In dsDataSet.Tables("PNL_QUICK_DETAIL").Rows
                    Total = 0
                    TotalPercentage = 0
                    For Each rowx As DataRow In dsDataSet.Tables("PNL_QUICK_DETAIL_SUB").Rows
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


                            End If
                        End If

                    Next

                    rowParent("AMOUNT") = Total
                    rowParent("PECENTAGE_AMOUNT") = TotalPercentage

                Next
                CalcTotal()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView2_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView2.SelectionChanged
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.ControllerRow)

                If row IsNot Nothing AndAlso IsDBNull(row("KeyName")) = False Then

                    For i As Integer = 0 To GridView1.RowCount - 1

                        If GridView1.GetDataRow(i)("KeyName") = row("KeyName") Then
                            GridView1.SelectRow(i)
                        End If

                    Next

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub



    Private Sub GridView2_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GridView2.ShowingEditor, GridView4.ShowingEditor
        Try
            Dim view As GridView = CType(sender, GridView)
            Dim row As DataRow = view.GetDataRow(view.FocusedRowHandle)

            If row IsNot Nothing Then
                Dim dtInfo As DataTable = ADO.Load_PNLINFO(row("KEYNAME"))

                If dtInfo IsNot Nothing Then

                    Dim Type As Integer = IIf(IsDBNull(dtInfo.Rows(0)("Type")), 0, dtInfo.Rows(0)("Type"))

                    Select Case Type
                        Case 2
                            Select Case row("KEYNAME")
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
                        Case 3

                        Case Else
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
                    End Select

                    If view.Name = "GridView2" Then
                        Dim Count As Integer = 0
                        If view.FocusedColumn.FieldName = "AMOUNT" Then

                            For Each rowItem As DataRow In dsDataSet.Tables("PNL_QUICK_DETAIL_SUB").Rows

                                If rowItem("PARENT_ID") = row("ID") Then
                                    Count += 1
                                End If

                            Next

                            If Count > 0 Then
                                e.Cancel = True
                            End If
                        End If
                    End If

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView2_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView2.ValidateRow, GridView4.ValidateRow
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.RowHandle)

                If IsDBNull(row("KEYNAME")) = True Then
                    e.ErrorText = "Please select category."
                    e.Valid = False
                End If
                If IsDBNull(row("SOURCE_NO")) = True Then
                    e.ErrorText = "Please select source no."
                    e.Valid = False
                End If
                If IsDBNull(row("DESCRIPTION")) = True Then
                    e.ErrorText = "Please put description."
                    e.Valid = False
                End If
                If IsDBNull(row("AMOUNT")) = True Then
                    e.ErrorText = "Please put amount."
                    e.Valid = False
                End If

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

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Try
            Dim TableName As String = Nothing
            Dim dtRow As DataRow = Nothing
            Dim obj As System.Data.DataRow() = Nothing
            For Each rowInfo As DataRow In dsDataSet.Tables("PNL_TABLE_INFO").Rows

                If IsDBNull(rowInfo("KEYNAME")) = False Then

                    If IsDBNull(rowInfo("TableName_Details")) = False Then
                        dsDataSet.Tables(rowInfo("TableName_Details")).rows.clear()
                        Application.DoEvents()
                    End If

                    If IsDBNull(rowInfo("TableName")) = False Then
                        dsDataSet.Tables(rowInfo("TableName")).rows.clear()
                        Application.DoEvents()
                    End If
                    obj = Nothing
                    obj = dsDataSet.Tables("PNL_QUICK_DETAIL").Select("KEYNAME ='" & rowInfo("KEYNAME") & "'")

                    If obj IsNot Nothing Then

                        For Each rowx As DataRow In obj

                            If IsDBNull(rowx("DESCRIPTION")) = False AndAlso IsDBNull(rowx("AMOUNT")) = False Then

                                dtRow = Nothing
                                dtRow = dsDataSet.Tables(rowInfo("TableName")).NewRow
                                dtRow(rowInfo("ColumnTable")) = rowx("ID")
                                dtRow(rowInfo("ColumnAmount")) = rowx("AMOUNT")
                                dtRow(rowInfo("ColumnDescription")) = rowx("DESCRIPTION")

                                Select Case rowInfo("Type")
                                    Case 1

                                    Case 2
                                        Select Case rowInfo("KEYNAME")
                                            Case "PURCHASE", "DEPRECIATION", "OTHERALLOWEXP", "OTHERNONALLOWEXP"
                                                dtRow(rowInfo("ColumnAddBack")) = rowx("DEDUCTIBLE")
                                                dtRow(rowInfo("ColumnPecentage_Amount")) = rowx("PECENTAGE_AMOUNT")
                                            Case Else
                                                dtRow(rowInfo("ColumnAddBack")) = rowx("DEDUCTIBLE")
                                                dtRow(rowInfo("ColumnDeduct")) = rowx("DEDUCTIBLE_ADD")
                                                dtRow(rowInfo("ColumnPecentage_Amount")) = rowx("PECENTAGE_AMOUNT")
                                        End Select
                                    Case 3
                                        dtRow(rowInfo("ColumnAddBack")) = rowx("DEDUCTIBLE")
                                        dtRow(rowInfo("ColumnDeduct")) = rowx("DEDUCTIBLE_ADD")
                                        dtRow(rowInfo("Pecentage")) = rowx("PECENTAGE")
                                        dtRow(rowInfo("ColumnPecentage_Amount")) = rowx("PECENTAGE_AMOUNT")
                                End Select

                                dsDataSet.Tables(rowInfo("TableName")).rows.add(dtRow)


                                For Each rowChild As DataRow In dsDataSet.Tables("PNL_QUICK_DETAIL_SUB").Rows

                                Next
                            End If
                        Next

                    End If

                    'For Each rowx As DataRow In dsDataSet.Tables("PNL_QUICK_DETAIL").Rows


                    '    If IsDBNull(rowx("KEYNAME")) = False AndAlso IsDBNull(rowx("SOURCE_NO")) = False AndAlso
                    '        IsDBNull(rowx("DESCRIPTION")) = False AndAlso IsDBNull(rowx("AMOUNT")) = False Then

                    '        dtRow = Nothing
                    '        dtRow = dsDataSet.Tables(rowInfo("TableName")).NewRow
                    '        dtRow(rowInfo("ColumnTable")) = rowx("ID")
                    '        dtRow(rowInfo("ColumnAmount")) = rowx("AMOUNT")
                    '        dtRow(rowInfo("ColumnDescription")) = rowx("DESCRIPTION")

                    '        Select Case rowInfo("Type")
                    '            Case 1

                    '            Case 2
                    '                Select Case rowInfo("KEYNAME")
                    '                    Case "PURCHASE", "DEPRECIATION", "OTHERALLOWEXP", "OTHERNONALLOWEXP"
                    '                        dtRow(rowInfo("ColumnAddBack")) = rowx("DEDUCTIBLE")
                    '                        dtRow(rowInfo("ColumnPecentage_Amount")) = rowx("PECENTAGE_AMOUNT")
                    '                    Case Else
                    '                        dtRow(rowInfo("ColumnAddBack")) = rowx("DEDUCTIBLE")
                    '                        dtRow(rowInfo("ColumnDeduct")) = rowx("DEDUCTIBLE_ADD")
                    '                        dtRow(rowInfo("ColumnPecentage_Amount")) = rowx("PECENTAGE_AMOUNT")
                    '                End Select
                    '            Case 3
                    '                dtRow(rowInfo("ColumnAddBack")) = rowx("DEDUCTIBLE")
                    '                dtRow(rowInfo("ColumnDeduct")) = rowx("DEDUCTIBLE_ADD")
                    '                dtRow(rowInfo("Pecentage")) = rowx("PECENTAGE")
                    '                dtRow(rowInfo("ColumnPecentage_Amount")) = rowx("PECENTAGE_AMOUNT")
                    '        End Select

                    '        dsDataSet.Tables(rowInfo("TableName")).rows.add(dtRow)


                    '        For Each rowChild As DataRow In dsDataSet.Tables("PNL_QUICK_DETAIL_SUB").Rows

                    '        Next


                    '    End If

                    'Next

                End If


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

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class