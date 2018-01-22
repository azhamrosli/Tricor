Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid
Imports DevExpress.XtraReports.UI
Imports DevExpress.Spreadsheet
Imports System.IO

Public Class ucPNL_p3InterestResPurS33_Monthly_Tricor
    Public ID_PNL As Decimal = 0
    Public RefNo As String = Nothing
    Public YA As String = Nothing
    Public SourceNo As Integer = 0
    Public KeyID As Integer = 0
    Public isEdit As Boolean = False
    Public txtAmount As DevExpress.XtraEditors.TextEdit
    Dim ErrorLog As clsError = Nothing

    Public Const MainTable As String = "EXPENSES_INTERESTRESTRICT" 'PLFST_SALES
    Public Const MainTable_Details As String = "INTEREST_RESTRIC_MONTLY_REPORT" 'PLFST_SALES_DETAIL
    Public Const MainKey As String = "EXIR_EXIRKEY" ' PLFS_KEY
    Public Const MainKey_Details As String = "RIRD_KEY" 'PLFSD_PLFSKEY
    Public Const MainAmount As String = "EXIR_YEAREND" 'PLFS_AMOUNT
    Public Const MainAmount_Details As String = "RIRD_AMOUNT" 'PLFSD_AMOUNT
    Public Const MainSourceNo As String = "EXIR_SOURCENO" 'PLFS_SOURCENO
    Public Const MainDetail As String = "EXIR_DETAIL"  'PLFS_DETAIL
    Public Const MainDetails_Desc As String = "RIRD_DESC"  'PLFSD_DESC
    Public Const Main_Desc As String = "EXIR_DESC"  'PLFSD_DESC
    Public Const Main_Addback As String = "EXIR_DEDUCTIBLE"  'PLFSD_DESC
    Public Const MainDetails_Addback As String = ""  'PLFSD_DESC
    Public Const Main_Deduct As String = "EXIR_DEDUCTIBLE_ADD"  'PLFSD_DESC
    Public Const MainDetails_Deduct As String = ""  'PLFSD_DESC
    Public Const MainColumn_PercentageAmount As String = "PecentageAmount"
    Dim MainDs As DataSet = Nothing
    Public Property DataView_Main() As DataSet
        Get
            Return dsPNL
        End Get
        Set(ByVal value As DataSet)
            dsPNL = value
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
            mdlPNL2.LoadTable_InterestRestricted(DsPNL, RefNo, YA, SourceNo, KeyID, Errorlog)
            Application.DoEvents()
            INTERESTRESTRICMONTLYREPORTBindingSource.DataSource = dsPNL.Tables("INTEREST_RESTRIC_MONTLY_REPORT")

            Application.DoEvents()
            GridView1.BeginSort()
            GridView1.ClearGrouping()
            Dim col1 As GridColumn = GridView1.Columns("TypeName")

            col1.GroupIndex = 0

            GridView1.EndSort()


            GridView1.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways

            Dim item As GridGroupSummaryItem = Nothing ' New GridGroupSummaryItem()

            For Each colx As DataColumn In dsPNL.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns

                Select Case colx.ColumnName
                    Case "Title", "TypeName", "TypeIncome", "TotalYear", "LabelTag", "KeyID"
                        Dim col As GridColumn = GridView1.Columns(colx.ColumnName)
                        col.OptionsColumn.AllowEdit = False

                        If colx.ColumnName = "Title" Then
                            col.Width = 120
                        ElseIf colx.ColumnName = "TypeIncome" Or colx.ColumnName = "KeyID" Then
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

            Application.DoEvents()

            Dim dtData As DataTable = mdlProcess.Load_REF_INTEREST_RESTRIC_MONTHLY_TRICOR_TEMP(SourceNo, RefNo, YA, Errorlog)
            If dtData IsNot Nothing Then
                mdlPNL2.AppenData_InterestRestricted(dtData, DsPNL, Errorlog)
            End If


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
                    Case "Title", "TypeName", "TypeIncome", "TotalYear", "LabelTag", "KeyID"

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
                        Case "Title", "TypeName", "TypeIncome", "TotalYear", "LabelTag", "KeyID"

                        Case Else
                            TotalCol += IIf(IsDBNull(rowx(colx.ColumnName)), 0, rowx(colx.ColumnName))

                    End Select
                Next
                rowx("TotalYear") = TotalCol
            Next

            Dim MainTotal As Decimal = 0
            For Each rowx As DataRow In DsPNL.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Rows
                TotalCol = 0
                If IsDBNull(rowx("TypeName")) = False AndAlso CStr(rowx("TypeName")) = "5 INTEREST RESTIRCTED" Then
                    For Each colx As DataColumn In DsPNL.Tables("INTEREST_RESTRIC_MONTLY_REPORT").Columns

                        Select Case colx.ColumnName
                            Case "TotalYear"
                                MainTotal += CDec(IIf(IsDBNull(rowx(colx.ColumnName)), 0, rowx(colx.ColumnName)))

                        End Select
                    Next
                End If      
            Next

            For Each row As DataRow In DsPNL.Tables(MainTable).Rows
                If IsDBNull(row(MainKey)) = False AndAlso row(MainKey) = KeyID Then
                    row(MainAmount) = Math.Round(MainTotal, 2)
                End If
            Next

            CalcTotalofView(txtAmount, DsPNL, MainTable, MainAmount, 0, ErrorLog)

            CalcPercentageAmount_Expenses(DsPNL, MainTable, "", MainKey, "", Main_Addback, Main_Deduct, _
                                          MainDetails_Addback, MainDetails_Deduct, MainAmount, MainAmount_Details, _
                                          MainColumn_PercentageAmount, ErrorLog)
            mdlProcess.SAVE_EXPENSES_INTERESTRESTRICT_TRICOR_TEMP(KeyID, DsPNL.Tables(MainTable_Details), RefNo, YA, SourceNo, ErrorLog)

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


End Class
