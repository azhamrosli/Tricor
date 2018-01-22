Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid
Imports DevExpress.XtraReports.UI
Imports DevExpress.Spreadsheet
Imports System.IO

Public Class frmPNL_InterestResPurS33_Monthly
    Public ID_PNL As Decimal = 0
    Public RefNo As String = Nothing
    Public YA As String = Nothing
    Public SourceNo As Integer = 0
    Public isEdit As Boolean = False
    Public txtAmount As DevExpress.XtraEditors.TextEdit
    Dim ErrorLog As clsError = Nothing

    Public Const MainTable As String = "EXPENSES_INTERESTRESTRICT" 'PLFST_SALES
    Public Const MainTable_Details As String = "REF_INTEREST_RESTRIC_DETAIL" 'PLFST_SALES_DETAIL
    Public Const MainKey As String = "EXIR_EXIRKEY" ' PLFS_KEY
    Public Const MainKey_Details As String = "RIRD_KEY" 'PLFSD_PLFSKEY
    Public Const MainAmount As String = "EXIR_YEAREND" 'PLFS_AMOUNT
    Public Const MainAmount_Details As String = "RIRD_AMOUNT" 'PLFSD_AMOUNT
    Public Const MainSourceNo As String = "EXIR_SOURCENO" 'PLFS_SOURCENO
    Public Const MainDetail As String = "EXIR_DETAIL"  'PLFS_DETAIL
    Public Const MainDetails_Desc As String = "RIRD_DESC"  'PLFSD_DESC
    Public Const Main_Desc As String = "EXIR_DESC"  'PLFSD_DESC
    Dim MainDs As DataSet = Nothing
    Public Property DataView_Main() As DataSet
        Get
            Return DsPNL
        End Get
        Set(ByVal value As DataSet)
            DsPNL = value
        End Set
    End Property

    Private Sub frmPNL_InterestResPurS33_Yearly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadData()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub LoadData(Optional ByRef Errorlog As clsError = Nothing)
        Try
            LoadTable_InterestRestricted(DsPNL)
            Application.DoEvents()
            INTERESTRESTRICMONTLYREPORTBindingSource.DataSource = DsPNL.Tables("INTEREST_RESTRIC_MONTLY_REPORT")

            Application.DoEvents()
            GridView1.BeginSort()
            GridView1.ClearGrouping()
            Dim col1 As GridColumn = GridView1.Columns("TypeName")

            col1.GroupIndex = 0

            GridView1.EndSort()


            GridView1.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways

            Dim item As GridGroupSummaryItem = Nothing ' New GridGroupSummaryItem()

            For Each colx As DataColumn In DsPNL.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns

                Select Case colx.ColumnName
                    Case "Title", "TypeName", "TypeIncome", "TotalYear", "LabelTag"
                        Dim col As GridColumn = GridView1.Columns(colx.ColumnName)
                        col.OptionsColumn.AllowEdit = False

                        If colx.ColumnName = "Title" Then
                            col.Width = 120
                        ElseIf colx.ColumnName = "TypeIncome" Then
                            col.Visible = False
                        End If

                    Case Else

                        Dim item1 As GridGroupSummaryItem = New GridGroupSummaryItem()
                        item1.FieldName = colx.ColumnName
                        item1.SummaryType = DevExpress.Data.SummaryItemType.Sum
                        item1.DisplayFormat = "{0:n2}"
                        item1.ShowInGroupColumnFooter = GridView1.Columns(colx.ColumnName)
                        GridView1.GroupSummary.Add(item1)
                End Select

            Next

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
        End Try
    End Sub

    Private Sub LoadTable_InterestRestricted(ByRef ds As DataSet)
        Try

            Dim dt As DataTable = mdlProcess.Load_interestRestricMonthNBasis(RefNo, YA, SourceNo, ErrorLog)
            Dim MonthDuration As Integer = 0
            Dim BasisPeriod As DateTime = Now
            Dim CurrBasisPeriod As DateTime = Now
            Dim dtRow As DataRow = Nothing
            Dim LabelTag As String = Nothing
            Dim dtTaxPayer As DataTable = mdlProcess.LoadTaxPayer_ByRefNO(RefNo)

            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Rows.Clear()
            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns.Clear()


            If dtTaxPayer Is Nothing Then
                MsgBox("Tax payer not found.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If dt Is Nothing Then
                MsgBox("Failed to load interest restriction.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            MonthDuration = IIf(IsDBNull(dt.Rows(0)("DURATION")), 12, dt.Rows(0)("DURATION"))
            BasisPeriod = IIf(IsDBNull(dt.Rows(0)("BASICPERIOD")), Now, dt.Rows(0)("BASICPERIOD"))
            CurrBasisPeriod = BasisPeriod

            Dim clm As System.Data.DataColumn
            clm = Nothing
            clm = New System.Data.DataColumn
            clm.ColumnName = "LabelTag"
            clm.Caption = "Label Tag"
            clm.DataType = System.Type.GetType("System.String")
            clm.DefaultValue = ""
            clm.AllowDBNull = True
            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns.Add(clm)


            clm = Nothing
            clm = New System.Data.DataColumn
            clm.ColumnName = "Title"
            clm.Caption = "Title"
            clm.DataType = System.Type.GetType("System.String")
            clm.DefaultValue = ""
            clm.AllowDBNull = True
            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns.Add(clm)

            clm = Nothing
            clm = New System.Data.DataColumn
            clm.ColumnName = "TypeName"
            clm.Caption = "Type Name"
            clm.DataType = System.Type.GetType("System.String")
            clm.DefaultValue = ""
            clm.AllowDBNull = True
            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns.Add(clm)

            clm = Nothing
            clm = New System.Data.DataColumn
            clm.ColumnName = "TypeIncome"
            clm.Caption = "Type Income"
            clm.DataType = System.Type.GetType("System.String")
            clm.DefaultValue = ""
            clm.AllowDBNull = True
            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns.Add(clm)

            For i As Integer = 0 To MonthDuration - 1

                CurrBasisPeriod = CurrBasisPeriod.AddMonths(+1)

                clm = Nothing
                clm = New System.Data.DataColumn
                clm.ColumnName = Format(CurrBasisPeriod, "MMM") & "_" & CurrBasisPeriod.Year
                clm.Caption = Format(CurrBasisPeriod, "MMM") & " " & CurrBasisPeriod.Year
                clm.DataType = System.Type.GetType("System.Decimal")
                clm.AllowDBNull = True
                ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns.Add(clm)

            Next

            clm = Nothing
            clm = New System.Data.DataColumn
            clm.ColumnName = "TotalYear"
            clm.Caption = "Total"
            clm.DataType = System.Type.GetType("System.Decimal")
            clm.AllowDBNull = True
            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns.Add(clm)

            Application.DoEvents()
            Dim inxt As Integer = 0
            Dim CurrInxt As Integer = 0
            For i As Integer = 0 To 3
                CurrInxt = i
                LabelTag = GetLabelTag(CurrInxt)
                Select Case i
                    Case 0

                        dt = mdlProcess.Load_interestRestricSchedule(RefNo, YA, SourceNo, "Borr")
                    Case 1
                        dt = mdlProcess.Load_interestRestricSchedule(RefNo, YA, SourceNo, "inv")
                    Case 2
                        dt = mdlProcess.Load_interestRestricSchedule(RefNo, YA, SourceNo, "invNon")
                    Case Else
                        dt = mdlProcess.Load_interestRestricSchedule(RefNo, YA, SourceNo, "Interest")
                End Select

                If dt IsNot Nothing Then
                    inxt = 0
                    For Each rowx As DataRow In dt.Rows
                        inxt += 1
                        dtRow = Nothing
                        dtRow = ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").NewRow
                        dtRow("LabelTag") = LabelTag & inxt
                        dtRow("Title") = IIf(IsDBNull(rowx("Item")), "", rowx("Item")).ToString.Remove(0, 1)
                        Select Case i
                            Case 0
                                dtRow("TypeName") = "1 BORROWINGS"
                            Case 1
                                dtRow("TypeName") = "2 LOANS AND INVESTMENTS"
                            Case 2
                                dtRow("TypeName") = "3 LOANS AND INVESTMENTS NON"
                            Case Else
                                dtRow("TypeName") = "4 INTEREST"
                        End Select

                        dtRow("TypeIncome") = IIf(IsDBNull(rowx("Income Type")), "", rowx("Income Type"))
                        For Each colx As DataColumn In ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns
                            Select Case colx.ColumnName
                                Case "Title", "TypeName", "TypeIncome", "TotalYear", "LabelTag"

                                Case Else
                                    dtRow(colx.ColumnName) = 0
                            End Select

                        Next

                        dtRow("TotalYear") = 0

                        ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Rows.Add(dtRow)
                    Next

                End If
            Next

            dtRow = Nothing
            dtRow = ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").NewRow
            dtRow("Title") = "Interest restricted"
            dtRow("TypeName") = "5 INTEREST RESTIRCTED"
            CurrInxt += 1
            dtRow("LabelTag") = GetLabelTag(CurrInxt)
            dtRow("TypeIncome") = ""
            For Each colx As DataColumn In ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns
                Select Case colx.ColumnName
                    Case "Title", "TypeName", "TypeIncome", "TotalYear", "LabelTag"

                    Case Else
                        dtRow(colx.ColumnName) = 0
                End Select

            Next

            dtRow("TotalYear") = 0

            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Rows.Add(dtRow)


            dtRow = Nothing
            dtRow = ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").NewRow
            dtRow("Title") = "Interest Income"
            CurrInxt += 1
            dtRow("LabelTag") = GetLabelTag(CurrInxt) & "1"
            dtRow("TypeName") = "6 INTEREST RESTRICTED BUT ALLOWABLE AGAINST"

            dtRow("TypeIncome") = "E1"
            For Each colx As DataColumn In ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns
                Select Case colx.ColumnName
                    Case "Title", "TypeName", "TypeIncome", "TotalYear", "LabelTag"

                    Case Else
                        dtRow(colx.ColumnName) = 0
                End Select

            Next

            dtRow("TotalYear") = 0

            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Rows.Add(dtRow)

            dtRow = Nothing
            dtRow = ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").NewRow
            dtRow("Title") = "Rental Income"
            dtRow("LabelTag") = GetLabelTag(CurrInxt) & "2"
            dtRow("TypeName") = "6 INTEREST RESTRICTED BUT ALLOWABLE AGAINST"

            dtRow("TypeIncome") = "E2"
            For Each colx As DataColumn In ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns
                Select Case colx.ColumnName
                    Case "Title", "TypeName", "TypeIncome", "TotalYear", "LabelTag"

                    Case Else
                        dtRow(colx.ColumnName) = 0
                End Select

            Next

            dtRow("TotalYear") = 0

            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Rows.Add(dtRow)

            dtRow = Nothing
            dtRow = ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").NewRow
            dtRow("Title") = "Dividend Income"
            dtRow("LabelTag") = GetLabelTag(CurrInxt) & "3"
            dtRow("TypeName") = "6 INTEREST RESTRICTED BUT ALLOWABLE AGAINST"

            dtRow("TypeIncome") = "E3"
            For Each colx As DataColumn In ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns
                Select Case colx.ColumnName
                    Case "Title", "TypeName", "TypeIncome", "TotalYear", "LabelTag"

                    Case Else
                        dtRow(colx.ColumnName) = 0
                End Select

            Next

            dtRow("TotalYear") = 0

            ds.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Rows.Add(dtRow)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView1_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView1.RowUpdated
        Try
            Dim TotalCol As Decimal = 0
            'Dim indexRow As Integer = e.RowHandle
            'For Each colx As DataColumn In DsPNL.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns
            '    Select Case colx.ColumnName
            '        Case "Title", "TypeName", "TypeIncome", "TotalYear"

            '        Case Else

            '            TotalCol += DsPNL.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Rows(indexRow)(colx.ColumnName)
            '    End Select
            'Next
            'DsPNL.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Rows(indexRow)("TotalYear") = TotalCol


            Application.DoEvents()
            Dim txtTotalInv As Decimal = 0
            Dim txtTotalInvNon As Decimal = 0
            Dim txtTotalInvBorr As Decimal = 0
            Dim txtTotalInvInterest As Decimal = 0
            Dim txtTotalInvSub As Decimal = 0
            Dim TotalRestrict As Decimal = 0
            Dim SubRental As Decimal = 0
            Dim TotalRental As Decimal = 0
            Dim SubInterest As Decimal = 0
            Dim TotalInterest As Decimal = 0
            Dim SubDividend As Decimal = 0
            Dim TotalDividend As Decimal = 0
            For Each colx As DataColumn In DsPNL.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns
                txtTotalInvBorr = 0
                txtTotalInv = 0
                txtTotalInvNon = 0
                TotalRestrict = 0
                SubRental = 0
                TotalRental = 0
                SubInterest = 0
                TotalInterest = 0
                SubDividend = 0
                TotalDividend = 0

                Select Case colx.ColumnName
                    Case "Title", "TypeName", "TypeIncome", "TotalYear", "LabelTag"

                    Case Else
                        For Each rowx As DataRow In DsPNL.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Rows

                            Select Case rowx("TypeName")
                                Case "1 BORROWINGS"
                                    txtTotalInvBorr += IIf(IsDBNull(rowx(colx.ColumnName)), 0, rowx(colx.ColumnName))
                                Case "2 LOANS AND INVESTMENTS"
                                    If rowx("TypeIncome") = "RENTAL INCOME" Then
                                        SubRental += IIf(IsDBNull(rowx(colx.ColumnName)), 0, rowx(colx.ColumnName))
                                    ElseIf rowx("TypeIncome") = "INTEREST INCOME" Then
                                        SubInterest += IIf(IsDBNull(rowx(colx.ColumnName)), 0, rowx(colx.ColumnName))
                                    ElseIf rowx("TypeIncome") = "DIVIDEND INCOME" Then
                                        SubDividend += IIf(IsDBNull(rowx(colx.ColumnName)), 0, rowx(colx.ColumnName))
                                    End If
                                    txtTotalInv += IIf(IsDBNull(rowx(colx.ColumnName)), 0, rowx(colx.ColumnName))
                                Case "3 LOANS AND INVESTMENTS NON"
                                    If rowx("TypeIncome") = "RENTAL INCOME" Then
                                        SubRental += IIf(IsDBNull(rowx(colx.ColumnName)), 0, rowx(colx.ColumnName))
                                    ElseIf rowx("TypeIncome") = "INTEREST INCOME" Then
                                        SubInterest += IIf(IsDBNull(rowx(colx.ColumnName)), 0, rowx(colx.ColumnName))
                                    ElseIf rowx("TypeIncome") = "DIVIDEND INCOME" Then
                                        SubDividend += IIf(IsDBNull(rowx(colx.ColumnName)), 0, rowx(colx.ColumnName))
                                    End If
                                    txtTotalInvNon += IIf(IsDBNull(rowx(colx.ColumnName)), 0, rowx(colx.ColumnName))
                                Case "4 INTEREST"
                                    txtTotalInvInterest += IIf(IsDBNull(rowx(colx.ColumnName)), 0, rowx(colx.ColumnName))
                                Case "5 INTEREST RESTIRCTED"
                                    txtTotalInvSub = txtTotalInv + txtTotalInvNon
                                    If (txtTotalInvBorr * txtTotalInvInterest) = 0 Then
                                        TotalRestrict += 0
                                    Else
                                        TotalRestrict += txtTotalInvSub / (txtTotalInvBorr * txtTotalInvInterest)
                                    End If

                                    rowx(colx.ColumnName) = TotalRestrict.ToString("N2")

                                Case "6 INTEREST RESTRICTED BUT ALLOWABLE AGAINST"
                                    If rowx("TypeIncome") = "E1" Then
                                        If txtTotalInvSub = 0 Then
                                            TotalInterest = 0
                                        Else
                                            TotalInterest = (TotalRestrict * SubInterest) / txtTotalInvSub
                                        End If

                                        rowx(colx.ColumnName) = TotalInterest.ToString("N2")
                                    End If
                                    If rowx("TypeIncome") = "E2" Then
                                        If txtTotalInvSub = 0 Then
                                            TotalRental = 0
                                        Else
                                            TotalRental = (TotalRestrict * SubRental) / txtTotalInvSub
                                        End If

                                        rowx(colx.ColumnName) = TotalRental.ToString("N2")
                                    End If
                                    If rowx("TypeIncome") = "E3" Then
                                        If txtTotalInvSub = 0 Then
                                            TotalDividend = 0
                                        Else
                                            TotalDividend = (TotalRestrict * SubDividend) / txtTotalInvSub
                                        End If
                                        rowx(colx.ColumnName) = TotalDividend.ToString("N2")
                                    End If
                            End Select


                        Next
                End Select

            Next
            Application.DoEvents()
            For Each rowx As DataRow In DsPNL.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Rows
                TotalCol = 0

                For Each colx As DataColumn In DsPNL.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns

                    Select Case colx.ColumnName
                        Case "Title", "TypeName", "TypeIncome", "TotalYear", "LabelTag"

                        Case Else
                            TotalCol += IIf(IsDBNull(rowx(colx.ColumnName)), 0, rowx(colx.ColumnName))

                    End Select
                Next
                rowx("TotalYear") = TotalCol
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridView1_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GridView1.ShowingEditor
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim rowx As DataRow = view.GetFocusedDataRow

                If IsDBNull(rowx("Title")) = False Then
                    Select Case rowx("TypeName")
                        Case "5 INTEREST RESTIRCTED", "6 INTEREST RESTRICTED BUT ALLOWABLE AGAINST"
                            e.Cancel = True
                        Case Else
                            e.Cancel = False
                    End Select
                End If
                ' e.Cancel = mdlPNL.DisableAmountIfGotChild(MainTable_Details, MainKey, MainKey_Details, MainDetail, view, DsPNL1, ErrorLog)
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Function GetLabelTag(ByVal Index As Integer) As String
        Try
            Select Case Index
                Case 0
                    Return "A"
                Case 1
                    Return "B"
                Case 2
                    Return "C"
                Case 3
                    Return "D"
                Case 4
                    Return "E"
                Case 5
                    Return "F"
                Case 6
                    Return "G"
                Case 7
                    Return "H"
            End Select
        Catch ex As Exception
            Return "A"
        End Try
    End Function

    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try

            Dim Path As String = Nothing
            Dim tmpPath As String = Nothing
            SaveFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx"
            Dim rslt As DialogResult = SaveFileDialog1.ShowDialog

            If rslt = Windows.Forms.DialogResult.OK Then
                Path = SaveFileDialog1.FileName

                If System.IO.Directory.Exists(Application.StartupPath & "\ReportTemporary") = False Then
                    System.IO.Directory.CreateDirectory(Application.StartupPath & "\ReportTemporary")
                End If

                tmpPath = Application.StartupPath & "\ReportTemporary\InterestRestricted.xlsx"

                GridControl1.ExportToXlsx(tmpPath)
                Application.DoEvents()

                If System.IO.File.Exists(tmpPath) Then

                    Dim workbook As New Workbook()

                    ' Load a workbook from the stream. 
                    Using stream As New FileStream(tmpPath, FileMode.Open)
                        workbook.LoadDocument(stream, DocumentFormat.Xlsx)
                        Dim worksheets As WorksheetCollection = workbook.Worksheets

                        ' Access a worksheet by its index.
                        Dim worksheet1 As Worksheet = workbook.Worksheets(0)

                        worksheet1.Rows.Insert(1, 7)

                        Application.DoEvents()
                        worksheet1.Rows(0).Delete()

                        worksheet1.Rows(1)(0).Value = "AR Software Malaysia"
                        worksheet1.Rows(2)(0).Value = "Schedule of Section 33(2) Restriction of Interest Expense"
                        worksheet1.Rows(3)(0).Value = "Basis Period : 01.01.2016 - 31.12.2016"
                        worksheet1.Rows(4)(0).Value = "Year of Assessment : 2016"

                        Application.DoEvents()
                        Dim tmpCol As Integer = -1
                        For Each colx As DataColumn In DsPNL.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns

                            Select Case colx.ColumnName
                                Case "Title", "TotalYear", "LabelTag"
                                    tmpCol += 1
                                    worksheet1.Rows(6)(tmpCol).Value = ""
                                Case "TypeName", "TypeIncome"
                                Case Else
                                    tmpCol += 1
                                    worksheet1.Rows(6)(tmpCol).Value = colx.ColumnName

                            End Select

                        Next
                        workbook.SaveDocument(stream, DocumentFormat.Xlsx)
                    End Using

                    Dim frm As New frmExcel
                    frm.Path = tmpPath
                    frm.isAutoOpen = True
                    frm.Show()
                End If
                ' GridControl1.ExportToXlsx(Path)
            Else
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class