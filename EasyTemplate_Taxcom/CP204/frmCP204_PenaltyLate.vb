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
            If mdlProcess.CreateLookUpTaxPayer(dsCA, ErrorLog) = False Then
                MsgBox("Unable to retrive tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If mdlProcess.CreateLookUpYA(cboYA, ErrorLog, True) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
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
    Private Sub GenerateBreakDown()
        Try

            If cboRefNo.EditValue Is Nothing OrElse cboRefNo.EditValue = "" Then
                Exit Sub
            End If

            If cboYA.EditValue Is Nothing OrElse cboYA.EditValue = "" Then
                Exit Sub
            End If

            Dim dt As DataTable = mdlProcess.LoadTaxPayer_ByRefNO(cboRefNo.EditValue, ErrorLog)

            If dt IsNot Nothing Then

                dtBasisStart.EditValue = IIf(IsDBNull(dt.Rows(0)("TP_BASIS_PERIOD_FR")), Now, dt.Rows(0)("TP_BASIS_PERIOD_FR"))
                dtBasisEnd.EditValue = IIf(IsDBNull(dt.Rows(0)("TP_BASIS_PERIOD_TO")), Now, dt.Rows(0)("TP_BASIS_PERIOD_TO"))
                Application.DoEvents()
                Dim tmpTotal As Long = 0

                tmpTotal = DateDiff(DateInterval.Day, dtBasisStart.EditValue, dtBasisEnd.EditValue)

                txtTotalBasisPeriod.EditValue = CInt(tmpTotal)

                Application.DoEvents()

                If IsNumeric(txtTotalBasisPeriod.EditValue) = False Then
                    Exit Sub
                End If

                Dim dtRow As DataRow = Nothing
                For i As Integer = 0 To CInt(txtTotalBasisPeriod.EditValue) - 1
                    dtRow = DsCP204.Tables(MainTable_Details).NewRow
                    dtRow("CP_PARENTID") = 0
                    dtRow("CP_INSTALL_NO") = i + 1
                    dtRow("CP_PAYMENT_DUE") = CDate(dtBasisStart.EditValue).AddMonths(1)
                    dtRow("CP_INSTALLMENT_AMOUNT") = 0
                    dtRow("CP_PAYMENT_DATE_1") = Now
                    dtRow("CP_AMOUNT_PAID_1") = 0
                    dtRow("CP_PAYMENT_DATE_2") = Now
                    dtRow("CP_AMOUNT_PAID_2") = 0
                    dtRow("CP_PENALTY") = 0
                    dtRow("CP_NOTE_TITLE") = ""
                    dtRow("CP_NOTE") = ""
                    DsCP204.Tables(MainTable_Details).Rows.Add(dtRow)
                Next

            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboYA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYA.SelectedIndexChanged
        GenerateBreakDown()
    End Sub
End Class