Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid
Imports System.Collections

Public Class ucPNL_p3InterestResPurS33_Monthly
    Public txtAmount As DevExpress.XtraEditors.TextEdit
    Public SourceNo As Integer = 0
    Public RefNo As String = Nothing
    Public YA As String = Nothing
    Public KeyID As Integer = 0
    Public Amount As Decimal = 0
    Public isEdit As Boolean = False

    Public Const MainTable As String = "EXPENSES_INTERESTRESTRICT" 'PLFST_SALES
    Public Const MainTable_Details As String = "REF_INTEREST_RESTRIC_DETAIL_MONTHLY" 'PLFST_SALES_DETAIL
    Public Const MainTable_Details_temp As String = "REF_INTEREST_RESTRIC_DETAIL_TEMP" 'PLFST_SALES_DETAIL
    Public Const MainKey As String = "EXIR_EXIRKEY" ' PLFS_KEY
    Public Const MainKey_Details As String = "RIRD_KEY" 'PLFSD_PLFSKEY
    Public Const MainAmount As String = "EXIR_YEAREND" 'PLFS_AMOUNT
    Public Const MainAmount_Details As String = "RIRD_AMOUNT" 'PLFSD_AMOUNT
    Public Const MainSourceNo As String = "EXIR_SOURCENO" 'PLFS_SOURCENO
    Public Const MainSourceNo_Details As String = "RIRD_SOURCENO" 'PLFS_SOURCENO
    Public Const MainDetail As String = "EXIR_DETAIL"  'PLFS_DETAIL
    Public Const MainDetails_Desc As String = "RIRD_DESC"  'PLFSD_DESC
    Public Const Main_Desc As String = "EXIR_DESC"  'PLFSD_DESC
    Public Const Main_Type As String = "RIRD_TYPE"  'PLFSD_DESC
    Public Const Main_TypeofIncome As String = "RIRD_TYPE_INCOME"  'PLFSD_DESC

    ' Dim MainDataset As DataSet = Nothing
    Dim ErrorLog As clsError = Nothing
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Property DataView_Main() As DataSet
        Get
            Return DsPNL1
        End Get
        Set(ByVal value As DataSet)
            DsPNL1 = value
        End Set
    End Property

    Private Sub ucPNLTest_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            LoadData()
        Catch ex As Exception

        End Try
    End Sub


    Public Sub LoadData(Optional ByRef Errorlog As clsError = Nothing)
        Try

            Dim MonthDuration As Integer = 0
            Dim DateBasisPeriod As DateTime = Now
            mdlPNL.GetColumn_InterestRestrictMonthly(RefNo, YA, SourceNo, DsPNL1, GridView1, MonthDuration, DateBasisPeriod)
            Application.DoEvents()


            REFINTERESTRESTRICTMPBindingSource.DataSource = DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP")

            Dim dt As DataTable = Nothing

            dt = ADO.Load_REF_INTEREST_RESTRIC_DETAIL_MONTHLY(SourceNo, RefNo, YA, Errorlog)

            If dt Is Nothing Then
                ADO.Load_REF_INTEREST_RESTRIC_DETAIL_TEMP(SourceNo, RefNo, YA, Errorlog)
            End If


            DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").Clear()


            Dim dtrow As DataRow = Nothing
            ' Dim LoopDuration As Integer = 0
            If dt Is Nothing Then
                For i As Integer = 0 To MonthDuration - 1
                    dtrow = Nothing
                    dtrow = DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").NewRow
                    For Each clm As DataColumn In DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").Columns
                        Select Case clm.ColumnName
                            Case "Month"
                                DateBasisPeriod = DateBasisPeriod.AddMonths(+1)
                                '  Dim yeardt As New DateTime(CInt(YA) - 1, DateBasisPeriod.Month, DateBasisPeriod.Day)
                                dtrow(clm.ColumnName) = CDate(Format(DateBasisPeriod, "dd-MMM-yyyy"))
                            Case Else
                                dtrow(clm.ColumnName) = 0
                        End Select
                    Next
                    DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").Rows.Add(dtrow)
                Next

            Else
                GridView1.BeginUpdate()
                'Create the row first
                For i As Integer = 0 To MonthDuration - 1
                    dtrow = Nothing
                    dtrow = DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").NewRow
                    For Each clm As DataColumn In DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").Columns
                        Select Case clm.ColumnName
                            Case "Month"
                                DateBasisPeriod = DateBasisPeriod.AddMonths(+1)
                                ' Dim yeardt As New DateTime(CInt(YA) - 1, DateBasisPeriod.Month, DateBasisPeriod.Day)
                                dtrow(clm.ColumnName) = CDate(Format(DateBasisPeriod, "dd-MMM-yyyy"))
                            Case Else
                                dtrow(clm.ColumnName) = 0
                        End Select
                    Next
                    DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").Rows.Add(dtrow)
                Next
                Application.DoEvents()
                'put all data to the correct column
                Dim rowinx As Integer = 0

                For Each clm As DataColumn In DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").Columns
                    Select Case clm.ColumnName
                        Case "Month", "TotalIncProInv", "TotalIncNonProInv", "TotalInv", "TotalBorr", "TotalInterest", "TotalRestrict"

                        Case Else
                            For x As Integer = 0 To dt.Rows.Count - 1
                                If dt.Rows(x)("RIRD_TYPE") = clm.ColumnName Then
                                    rowinx = CInt(IIf(IsDBNull(dt.Rows(x)("RIRD_MONTH")), 10, dt.Rows(x)("RIRD_MONTH")))
                                    rowinx = rowinx - 1
                                    DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").Rows(rowinx)(clm.ColumnName) = IIf(IsDBNull(dt.Rows(x)("RIRD_AMOUNT")), 1, dt.Rows(x)("RIRD_AMOUNT"))
                                End If
                            Next
                    End Select
                Next
                GridView1.EndUpdate()

                If DsPNL1 Is Nothing OrElse DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP") Is Nothing Then
                    Exit Sub
                End If

                Dim intRow As Integer = -1
                Dim txtTotalInv As Decimal = 0
                Dim txtTotalInvNon As Decimal = 0
                Dim txtTotalInvBorr As Decimal = 0
                Dim txtTotalInvInterest As Decimal = 0
                Dim txtTotalInvSub As Decimal = 0
                Dim TotalRestrict As Decimal = 0
                For Each row As DataRow In DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").Rows
                    intRow += 1
                    If IsDBNull(row("Month")) = False Then
                        txtTotalInv = 0
                        txtTotalInvNon = 0
                        txtTotalInvBorr = 0
                        txtTotalInvInterest = 0
                        For Each clm As DataColumn In DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").Columns
                            Select Case clm.Caption
                                Case "inv"
                                    txtTotalInv += CDec(DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").Rows(intRow)(clm.ColumnName))
                                Case "invNon"
                                    txtTotalInvNon += CDec(DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").Rows(intRow)(clm.ColumnName))
                                Case "Borr"
                                    txtTotalInvBorr += CDec(DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").Rows(intRow)(clm.ColumnName))
                                Case "Interest"
                                    txtTotalInvInterest += CDec(DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").Rows(intRow)(clm.ColumnName))
                            End Select
                        Next

                        row("TotalIncProInv") = txtTotalInv
                        row("TotalIncNonProInv") = txtTotalInvNon
                        txtTotalInvSub = txtTotalInv + txtTotalInvNon
                        row("TotalInv") = txtTotalInvSub
                        row("TotalBorr") = txtTotalInvBorr
                        row("TotalInterest") = txtTotalInvInterest
                        If txtTotalInvBorr = 0 Then
                            row("TotalRestrict") = 0
                        Else
                            TotalRestrict += txtTotalInvSub / txtTotalInvBorr * txtTotalInvInterest
                            row("TotalRestrict") = txtTotalInvSub / txtTotalInvBorr * txtTotalInvInterest
                        End If

                    End If
                Next

                For Each row As DataRow In DsPNL1.Tables(MainTable).Rows
                    If IsDBNull(row(MainKey)) = False AndAlso row(MainKey) = KeyID Then
                        row(MainAmount) = Math.Round(TotalRestrict, MidpointRounding.ToEven)
                    End If
                Next

                CalcTotalofView(txtAmount, DsPNL1, MainTable, MainAmount, 0, Errorlog)
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
            AddListOfError(Errorlog)
        End Try
    End Sub
    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        SaveData()
    End Sub
    Private Sub SaveData(Optional ByVal isNotify As Boolean = True)
        Try
            If DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").Rows.Count > 0 Then
                Dim Amount_tmp As Decimal = 0

                DsPNL1.Tables(MainTable_Details).Rows.Clear()
                Dim dtRow As DataRow = Nothing
                Dim looprow As Integer = 0
                For i As Integer = 0 To DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").Rows.Count - 1
                    looprow = i + 1
                    For Each clm As DataColumn In DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").Columns
                        Select Case clm.ColumnName
                            Case "Month", "TotalIncProInv", "TotalIncNonProInv", "TotalInv", "TotalBorr", "TotalInterest", "TotalRestrict"

                            Case Else
                                dtRow = DsPNL1.Tables(MainTable_Details).NewRow
                                dtRow("RIRD_KEY") = KeyID
                                dtRow("RIR_REF_NUM") = 1
                                dtRow("RIRD_MONTH") = looprow
                                dtRow("RIRD_TYPE") = clm.ColumnName
                                dtRow("RIRD_DESC") = ""
                                dtRow("RIRD_AMOUNT") = DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").Rows(i)(clm.ColumnName)
                                dtRow("RIRD_NOTE") = ""
                                dtRow("RIRD_SOURCENO") = SourceNo
                                dtRow("RIRD_TYPE_INCOME") = ""
                                DsPNL1.Tables(MainTable_Details).Rows.Add(dtRow)
                        End Select

                    Next

                Next


                If ADO.Save_REF_INTEREST_RESTRIC_DETAIL_TEMP(DsPNL1.Tables(MainTable_Details), RefNo, YA, SourceNo, KeyID, _
                                                                    Amount_tmp, ErrorLog, True) = False Then

                    MsgBox("Unsuccessfully save your data.", MsgBoxStyle.Critical)


                Else
                    If isNotify Then
                        MsgBox("Successfully saved your data.", MsgBoxStyle.Information)
                    End If

                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        Try
            GridView1.GetDataRow(e.RowHandle)(Main_Type) = "Investment"
            GridView1.GetDataRow(e.RowHandle)(Main_TypeofIncome) = "INTEREST INCOME"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView1.ValidateRow
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.RowHandle)

                If IsDBNull(row(MainDetails_Desc)) = True OrElse IsDBNull(row(MainAmount_Details)) = True Then
                    e.ErrorText = "Please put amount and source number."
                    e.Valid = False
                Else
                    row(MainSourceNo_Details) = SourceNo
                    row(MainKey_Details) = KeyID
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView1_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView1.RowUpdated
        Try

            If DsPNL1 Is Nothing OrElse DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP") Is Nothing Then
                Exit Sub
            End If

            Dim intRow As Integer = -1
            Dim txtTotalInv As Decimal = 0
            Dim txtTotalInvNon As Decimal = 0
            Dim txtTotalInvBorr As Decimal = 0
            Dim txtTotalInvInterest As Decimal = 0
            Dim txtTotalInvSub As Decimal = 0
            Dim TotalRestrict As Decimal = 0
            For Each row As DataRow In DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").Rows
                intRow += 1
                If IsDBNull(row("Month")) = False Then
                    txtTotalInv = 0
                    txtTotalInvNon = 0
                    txtTotalInvBorr = 0
                    txtTotalInvInterest = 0
                    For Each clm As DataColumn In DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").Columns
                        Select Case clm.Caption
                            Case "inv"
                                txtTotalInv += CDec(DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").Rows(intRow)(clm.ColumnName))
                            Case "invNon"
                                txtTotalInvNon += CDec(DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").Rows(intRow)(clm.ColumnName))
                            Case "Borr"
                                txtTotalInvBorr += CDec(DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").Rows(intRow)(clm.ColumnName))
                            Case "Interest"
                                txtTotalInvInterest += CDec(DsPNL1.Tables("REF_INTEREST_RESTRIC_TMP").Rows(intRow)(clm.ColumnName))
                        End Select
                    Next

                    row("TotalIncProInv") = txtTotalInv
                    row("TotalIncNonProInv") = txtTotalInvNon
                    txtTotalInvSub = txtTotalInv + txtTotalInvNon
                    row("TotalInv") = txtTotalInvSub
                    row("TotalBorr") = txtTotalInvBorr
                    row("TotalInterest") = txtTotalInvInterest
                    If txtTotalInvBorr = 0 Then
                        row("TotalRestrict") = 0
                    Else
                        TotalRestrict += txtTotalInvSub / txtTotalInvBorr * txtTotalInvInterest
                        row("TotalRestrict") = txtTotalInvSub / txtTotalInvBorr * txtTotalInvInterest
                    End If

                End If
            Next

            For Each row As DataRow In DsPNL1.Tables(MainTable).Rows
                If IsDBNull(row(MainKey)) = False AndAlso row(MainKey) = KeyID Then
                    row(MainAmount) = Math.Round(TotalRestrict, MidpointRounding.ToEven)
                End If
            Next

            CalcTotalofView(txtAmount, DsPNL1, MainTable, MainAmount, 0, ErrorLog)
            Application.DoEvents()

            SaveData(False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim rslt As DialogResult = MessageBox.Show("Are you sure want to remove this item?", "Delete item", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If rslt = DialogResult.Yes Then
                GridView1.DeleteSelectedRows()
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class
