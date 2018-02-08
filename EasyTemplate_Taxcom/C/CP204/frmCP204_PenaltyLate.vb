Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCP204_PenaltyLate
    Public ID As Integer = 0
    Public isEdit As Boolean = False
    Dim ErrorLog As clsError = Nothing

    Public Const MainTable As String = "BORANG_CP204_TRICOR"
    Public Const MainTable_Details As String = "BORANG_CP204_TRICOR_BREAKDOWN"

    Private Sub frmCP204_PenaltyLate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadData()
        Try
            If CreateLookUpTaxPayer(DsCA, ErrorLog) = False Then
                MsgBox("Unable to retrive tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If CreateLookUpYA(cboYA, ErrorLog, True) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If isEdit = False Then
                If mdlProcess.ArgParam2 <> "" Then
                    cboRefNo.EditValue = mdlProcess.ArgParam2
                End If

                If mdlProcess.ArgParam3 <> "" Then
                    cboYA.EditValue = mdlProcess.ArgParam3
                End If


                txtAmount.EditValue = 0

            Else


            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            txtRefNo.EditValue = cboRefNo.EditValue
        Catch ex As Exception

        Finally
            GenerateBreakDown()
        End Try
    End Sub
    Private Sub GridView1_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated

    End Sub
    Private Sub GenerateBreakDown()
        Try

            If cboRefNo.EditValue Is Nothing OrElse cboRefNo.EditValue = "" Then
                Exit Sub
            End If

            If cboYA.EditValue Is Nothing OrElse cboYA.EditValue = "" Then
                Exit Sub
            End If

            Dim dt As DataTable = ADO.LoadTaxPayer_ByRefNO(cboRefNo.EditValue, ErrorLog)

            If dt IsNot Nothing Then

                dtBasisStart.EditValue = IIf(IsDBNull(dt.Rows(0)("TP_BASIS_PERIOD_FR")), Now, dt.Rows(0)("TP_BASIS_PERIOD_FR"))
                dtBasisEnd.EditValue = IIf(IsDBNull(dt.Rows(0)("TP_BASIS_PERIOD_TO")), Now, dt.Rows(0)("TP_BASIS_PERIOD_TO"))
                Application.DoEvents()
                Dim tmpTotal As Long = 0

                tmpTotal = DateDiff(DateInterval.Month, dtBasisStart.EditValue, dtBasisEnd.EditValue)

                txtTotalBasisPeriod.EditValue = CInt(tmpTotal)

                Application.DoEvents()

                If IsNumeric(txtTotalBasisPeriod.EditValue) = False Then
                    Exit Sub
                End If
                DsCP204.Tables(MainTable_Details).Rows.Clear()

                '< 2015 = 10 payment due
                '=> 2015 = 15 payment due

                Dim dtRow As DataRow = Nothing
                For i As Integer = 0 To CInt(txtTotalBasisPeriod.EditValue) - 1
                    dtRow = DsCP204.Tables(MainTable_Details).NewRow
                    dtRow("CP_PARENTID") = 0
                    dtRow("CP_INSTALL_NO") = i + 1
                    dtRow("CP_PAYMENT_DUE") = CDate(dtBasisStart.EditValue).AddMonths(1)
                    dtRow("CP_INSTALLMENT_AMOUNT") = 0
                    dtRow("CP_PAYMENT_DATE_1") = CDate(dtBasisStart.EditValue).AddMonths(1)
                    dtRow("CP_AMOUNT_PAID_1") = 0
                    dtRow("CP_PAYMENT_DATE_2") = CDate(dtBasisStart.EditValue).AddMonths(1)
                    dtRow("CP_AMOUNT_PAID_2") = 0
                    dtRow("CP_PENALTY") = 0
                    dtRow("CP_NOTE_TITLE") = ""
                    dtRow("CP_NOTE") = ""
                    DsCP204.Tables(MainTable_Details).Rows.Add(dtRow)
                Next
                Application.DoEvents()

                If DsCP204.Tables(MainTable_Details).Rows.Count > 0 Then

                    Dim MonthyInstall As Decimal = 0
                    Dim LastAmount As Decimal = 0
                    Dim Amountx As Decimal = CDec(IIf(txtAmount.EditValue Is Nothing, 0, txtAmount.EditValue))
                    MonthyInstall = Amountx / CInt(txtTotalBasisPeriod.EditValue)
                    MonthyInstall = Math.Round(MonthyInstall, MidpointRounding.AwayFromZero)
                    LastAmount = Amountx - (MonthyInstall * CInt(txtTotalBasisPeriod.EditValue))
                    LastAmount += MonthyInstall
                    For i As Integer = 0 To DsCP204.Tables(MainTable_Details).Rows.Count - 1

                        If i = (DsCP204.Tables(MainTable_Details).Rows.Count - 1) Then
                            DsCP204.Tables(MainTable_Details).Rows(i)("CP_INSTALLMENT_AMOUNT") = LastAmount
                        Else
                            DsCP204.Tables(MainTable_Details).Rows(i)("CP_INSTALLMENT_AMOUNT") = MonthyInstall
                        End If

                    Next

                End If

            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboYA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYA.SelectedIndexChanged
        GenerateBreakDown()
    End Sub

    Private Sub txtAmount_EditValueChanged(sender As Object, e As EventArgs) Handles txtAmount.EditValueChanged
        GenerateBreakDown()
    End Sub

    Private Sub GridView1_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.RowHandle)

                If IsDBNull(row("CP_PAYMENT_DUE")) = True Then
                    e.ErrorText = "Please enter payment due date."
                    e.Valid = False
                    Exit Sub
                End If

                If IsDBNull(row("CP_PAYMENT_DATE_1")) = True Then
                    e.ErrorText = "Please enter payment date 1."
                    e.Valid = False
                    Exit Sub
                End If

                If IsDBNull(row("CP_AMOUNT_PAID_1")) = True Then
                    e.ErrorText = "Please enter paid amount 1."
                    e.Valid = False
                    Exit Sub
                End If



                'If IsDBNull(row("MM_Description")) = True Then
                '    e.ErrorText = "Please put description."
                '    e.Valid = False
                'ElseIf IsDBNull(row("MM_Amount")) = True Then
                '    e.ErrorText = "Please put amount."
                '    e.Valid = False
                'Else
                '    CalcVal()
                'End If
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class