﻿Imports DevExpress.XtraReports.UI
Public Class ucCP204
    Dim ErrorLog As clsError = Nothing
    Private Sub frmCP204_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If mdlProcess.CreateLookUpTaxPayer(DsDefault, ErrorLog) = False Then
                MsgBox("Unable to retrive tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If mdlProcess.CreateLookUpYA(cboYA, ErrorLog, True) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Application.DoEvents()

            LoadData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadData(Optional Type As Integer = 0)
        Try
            If Type = 0 Then
                If mdlProcess.ArgParam2 <> "" Then
                    cboRefNo.EditValue = mdlProcess.ArgParam2
                End If

                If mdlProcess.ArgParam3 <> "" Then
                    cboYA.EditValue = mdlProcess.ArgParam3
                End If
            ElseIf Type = 1 Then
                cboRefNo.EditValue = ""
                cboYA.EditValue = ""
            End If

            If txtMonth.EditValue Is Nothing OrElse IsNumeric(txtMonth.EditValue) = False Then
                txtMonth.EditValue = -1
            End If

            Dim dt As DataTable = mdlProcess.Load_CP204_Search(cboRefNo.EditValue, cboYA.EditValue, CInt(txtMonth.EditValue), ErrorLog)

            DsCP204.Tables("BORANG_CP204").Rows.Clear()

            If dt Is Nothing Then
                Exit Sub
            End If

            For i As Integer = 0 To dt.Rows.Count - 1
                DsCP204.Tables("BORANG_CP204").ImportRow(dt.Rows(i))
            Next


        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Try
            LoadData(2)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            Dim frm As New frmCP204_Add
            frm.isEdit = False
            frm.ID = 0
            frm.ShowDialog()

            Me.LoadData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs)
        Try
            If cboRefNo IsNot Nothing AndAlso cboRefNo.EditValue IsNot Nothing AndAlso cboRefNo.EditValue <> "" Then
                txtRefNo.EditValue = cboRefNo.EditValue
                LoadData(2)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboYA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYA.SelectedIndexChanged
        Try
            LoadData(2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            cboRefNo.EditValue = ""
            Me.LoadData(2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        Try
            cboYA.EditValue = ""
            Me.LoadData(2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAllRecord_Click(sender As Object, e As EventArgs) Handles btnAllRecord.Click
        Try
            cboRefNo.EditValue = ""
            cboYA.EditValue = ""
            LoadData(1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdit.ItemClick
        Try
            Dim ID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows(0))("BCP_KEY")

            Dim frm As New frmCP204_Add
            frm.isEdit = True
            frm.ID = ID
            frm.ShowDialog()
            Me.LoadData(2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            Dim rslt As DialogResult = MessageBox.Show("Are you sure want to remove item(s)?", "CP204", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If rslt = Windows.Forms.DialogResult.Yes Then
                Dim tmpSts As Boolean = True
                For i As Integer = 0 To GridView1.SelectedRowsCount - 1

                    If mdlProcess.Delete_CP204(CInt(GridView1.GetDataRow(GridView1.GetSelectedRows(i))("BCP_KEY")), ErrorLog) = False Then
                        tmpSts = False

                    End If
                    'MsgBox(GridView1.GetDataRow(GridView1.GetSelectedRows(i))("CA_KEY"))
                Next
                If tmpSts Then
                    MsgBox("Succesfully remove CP204.", MsgBoxStyle.Information)
                    Me.LoadData(2)
                Else
                    MsgBox("Some of CP204 failed to delete.", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Try
            btnEdit.PerformClick()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboRefNo_EditValueChanged_1(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            txtRefNo.EditValue = cboRefNo.EditValue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint.ItemClick
        Try

            If GridView1.SelectedRowsCount = 0 Then
                Exit Sub
            End If

            Dim ID As Integer = GridView1.GetDataRow(GridView1.GetSelectedRows(0))("BCP_KEY")

            Dim dt As DataTable = mdlProcess.Load_CP204_BreakDown_ByParentID(ID)

            DsCP204.Tables("BORANG_CP204_TRICOR_BREAKDOWN_REPORT").Rows.Clear()
            If dt Is Nothing Then
                MsgBox("Record not found.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            Dim dtRow As DataRow = Nothing


            For i As Integer = 0 To dt.Rows.Count - 1
                dtRow = Nothing
                dtRow = DsCP204.Tables("BORANG_CP204_TRICOR_BREAKDOWN_REPORT").NewRow
                dtRow("CP_ID") = IIf(IsDBNull(dt.Rows(i)("CP_ID")), 0, dt.Rows(i)("CP_ID"))
                dtRow("CP_PARENTID") = IIf(IsDBNull(dt.Rows(i)("CP_PARENTID")), 0, dt.Rows(i)("CP_PARENTID"))
                dtRow("CP_INSTALL_NO") = i + 1
                dtRow("CP_PAYMENT_DUE") = IIf(IsDBNull(dt.Rows(i)("CP_PAYMENT_DUE")), DBNull.Value, dt.Rows(i)("CP_PAYMENT_DUE"))
                dtRow("CP_INSTALLMENT_AMOUNT") = IIf(IsDBNull(dt.Rows(i)("CP_INSTALLMENT_AMOUNT")), 0, dt.Rows(i)("CP_INSTALLMENT_AMOUNT"))
                dtRow("CP_PAYMENT_DATE_1") = IIf(IsDBNull(dt.Rows(i)("CP_PAYMENT_DATE_1")), DBNull.Value, dt.Rows(i)("CP_PAYMENT_DATE_1"))
                dtRow("CP_AMOUNT_PAID_1") = IIf(IsDBNull(dt.Rows(i)("CP_AMOUNT_PAID_1")), 0, dt.Rows(i)("CP_AMOUNT_PAID_1"))


                If IsDBNull(dt.Rows(i)("CP_PAYMENT_DATE_2")) = False AndAlso IsDBNull(dt.Rows(i)("CP_AMOUNT_PAID_2")) = False AndAlso CDec(dt.Rows(i)("CP_AMOUNT_PAID_2")) <> 0 Then
                    dtRow("CP_PENALTY") = 0
                Else
                    dtRow("CP_PENALTY") = IIf(IsDBNull(dt.Rows(i)("CP_PENALTY")), 0, dt.Rows(i)("CP_PENALTY"))
                End If

                DsCP204.Tables("BORANG_CP204_TRICOR_BREAKDOWN_REPORT").Rows.Add(dtRow)


                If IsDBNull(dt.Rows(i)("CP_PAYMENT_DATE_2")) = False AndAlso IsDBNull(dt.Rows(i)("CP_AMOUNT_PAID_2")) = False AndAlso CDec(dt.Rows(i)("CP_AMOUNT_PAID_2")) <> 0 Then
                    dtRow = Nothing

                    dtRow = DsCP204.Tables("BORANG_CP204_TRICOR_BREAKDOWN_REPORT").NewRow
                    dtRow("CP_ID") = IIf(IsDBNull(dt.Rows(i)("CP_ID")), 0, dt.Rows(i)("CP_ID"))
                    dtRow("CP_PARENTID") = IIf(IsDBNull(dt.Rows(i)("CP_PARENTID")), 0, dt.Rows(i)("CP_PARENTID"))
                    dtRow("CP_INSTALL_NO") = IIf(IsDBNull(dt.Rows(i)("CP_INSTALL_NO")), 0, dt.Rows(i)("CP_INSTALL_NO"))
                    dtRow("CP_PAYMENT_DUE") = IIf(IsDBNull(dt.Rows(i)("CP_PAYMENT_DUE")), DBNull.Value, dt.Rows(i)("CP_PAYMENT_DUE"))
                    dtRow("CP_INSTALLMENT_AMOUNT") = IIf(IsDBNull(dt.Rows(i)("CP_INSTALLMENT_AMOUNT")), 0, dt.Rows(i)("CP_INSTALLMENT_AMOUNT"))
                    dtRow("CP_PAYMENT_DATE_1") = IIf(IsDBNull(dt.Rows(i)("CP_PAYMENT_DATE_2")), DBNull.Value, dt.Rows(i)("CP_PAYMENT_DATE_2"))
                    dtRow("CP_AMOUNT_PAID_1") = IIf(IsDBNull(dt.Rows(i)("CP_AMOUNT_PAID_2")), 0, dt.Rows(i)("CP_AMOUNT_PAID_2"))

                    dtRow("CP_PENALTY") = IIf(IsDBNull(dt.Rows(i)("CP_PENALTY")), 0, dt.Rows(i)("CP_PENALTY"))
                    DsCP204.Tables("BORANG_CP204_TRICOR_BREAKDOWN_REPORT").Rows.Add(dtRow)

                End If

            Next

            Dim rpt As New rpt_CP204_Breakdown
            rpt.paramCompanyName.Value = GridView1.GetDataRow(GridView1.GetSelectedRows(0))("BCP_CO_NAME")
            rpt.paramYA.Value = GridView1.GetDataRow(GridView1.GetSelectedRows(0))("BCP_YA")
            rpt.paramApendix.Value = "APPENDIX"
            rpt.DataSource = DsCP204.Tables("BORANG_CP204_TRICOR_BREAKDOWN_REPORT")
            rpt.ShowPreview()
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
        End Try
    End Sub
End Class