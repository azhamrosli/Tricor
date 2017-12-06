Imports DevExpress.XtraGrid.Views.Grid

Public Class frmMovement_Add
    Dim ErrorLog As clsError = Nothing
    Public isEdit As Boolean = False
    Public ID As Integer = 0
    Private Sub frmMovement_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadData()
        Try
            If mdlProcess.CreateLookUpTaxPayer(DsCA, ErrorLog) = False Then
                MsgBox("Unable to retrive tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If mdlProcess.CreateLookUpYA(cboYA, ErrorLog, True) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            dtStart.EditValue = Now
            dtEnded.EditValue = New DateTime(DateTime.Now.Year, 12, 31)
            dtBalanceStart.EditValue = Now
            dtBalanceEnd.EditValue = New DateTime(DateTime.Now.Year, 12, 31)



            If isEdit = False Then
                If mdlProcess.ArgParam2 <> "" Then
                    cboRefNo.EditValue = mdlProcess.ArgParam2
                End If

                If mdlProcess.ArgParam3 <> "" Then
                    cboYA.EditValue = mdlProcess.ArgParam3
                End If

            Else
                Dim dt As DataTable = mdlProcess.Load_MovementNormal(ID, ErrorLog)

                If dt Is Nothing Then
                    isEdit = False
                    Exit Sub
                End If

                cboRefNo.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_REFNO")), "", dt.Rows(0)("MM_REFNO"))
                cboYA.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_YA")), "", dt.Rows(0)("MM_YA"))
                txtTitle.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_TITLE")), "", dt.Rows(0)("MM_TITLE"))
                dtStart.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_PERIOD_ENDED")), Now, dt.Rows(0)("MM_PERIOD_ENDED"))
                dtEnded.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_YEAR_ENDED")), Now, dt.Rows(0)("MM_YEAR_ENDED"))
                dtBalanceStart.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_BALANCE_START")), Now, dt.Rows(0)("MM_BALANCE_START"))
                dtBalanceEnd.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_BALANCE_END")), Now, dt.Rows(0)("MM_BALANCE_END"))
                txtAmountStart.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_AMOUNT_START")), 0, dt.Rows(0)("MM_AMOUNT_START"))
                txtAmountEnd.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_AMOUNT_END")), 0, dt.Rows(0)("MM_AMOUNT_END"))
                txtNoteStart.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_NOTE_START")), 0, dt.Rows(0)("MM_NOTE_START"))
                txtNoteEnd.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_NOTE_END")), 0, dt.Rows(0)("MM_NOTE_END"))

                dt = mdlProcess.Load_MovementNormal_Add(ID, ErrorLog)

                DsMovement.Tables("MOVEMENT_ADD").Rows.Clear()
                If dt IsNot Nothing Then
                    For Each rowx As DataRow In dt.Rows
                        rowx("MM_ID") = DsMovement.Tables("MOVEMENT_ADD").Rows.Count + 1
                        DsMovement.Tables("MOVEMENT_ADD").ImportRow(rowx)
                    Next
                End If

                dt = mdlProcess.Load_MovementNormal_Deduct(ID, ErrorLog)

                DsMovement.Tables("MOVEMENT_DEDUCT").Rows.Clear()
                If dt IsNot Nothing Then
                    For Each rowx As DataRow In dt.Rows
                        rowx("MM_ID") = DsMovement.Tables("MOVEMENT_DEDUCT").Rows.Count + 1
                        Application.DoEvents()
                        DsMovement.Tables("MOVEMENT_DEDUCT").ImportRow(rowx)
                    Next
                End If
            End If

            MOVEMENTADDBindingSource.DataSource = DsMovement.Tables("MOVEMENT_ADD")
            MOVEMENTDEDUCTBindingSource.DataSource = DsMovement.Tables("MOVEMENT_DEDUCT")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView1_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        Try
            GridView1.GetDataRow(e.RowHandle)("MM_AddBack") = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView2_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView2.InitNewRow
        Try
            GridView2.GetDataRow(e.RowHandle)("MM_Deduct") = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            txtRefNo.EditValue = cboRefNo.EditValue
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CalcVal()
        Try
            Dim Total As Decimal = 0
            If txtAmountStart.EditValue IsNot Nothing AndAlso IsNumeric(txtAmountStart.EditValue) = True Then
                Total += CDec(txtAmountStart.EditValue)
            End If


            If DsMovement.Tables("MOVEMENT_ADD") IsNot Nothing AndAlso DsMovement.Tables("MOVEMENT_ADD").Rows.Count > 0 Then
                For Each rowx As DataRow In DsMovement.Tables("MOVEMENT_ADD").Rows
                    If rowx.RowState <> DataRowState.Deleted AndAlso IsDBNull(rowx("MM_Amount")) = False Then
                        Total += CDec(rowx("MM_Amount"))
                    End If
                Next
            End If

            If DsMovement.Tables("MOVEMENT_DEDUCT") IsNot Nothing AndAlso DsMovement.Tables("MOVEMENT_DEDUCT").Rows.Count > 0 Then
                For Each rowx As DataRow In DsMovement.Tables("MOVEMENT_DEDUCT").Rows
                    If rowx.RowState <> DataRowState.Deleted AndAlso IsDBNull(rowx("MM_Amount")) = False Then
                        Total -= CDec(rowx("MM_Amount"))
                    End If
                Next
            End If

            txtAmountEnd.EditValue = Total
        Catch ex As Exception
            txtAmountEnd.EditValue = 0
        End Try
    End Sub

    Private Sub txtAmountStart_EditValueChanged(sender As Object, e As EventArgs) Handles txtAmountStart.EditValueChanged
        CalcVal()
    End Sub

    Private Sub GridView1_RowDeleted(sender As Object, e As DevExpress.Data.RowDeletedEventArgs) Handles GridView1.RowDeleted
        CalcVal()
    End Sub

    Private Sub GridView1_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated
        CalcVal()
    End Sub

    Private Sub GridView1_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.RowHandle)

                If IsDBNull(row("MM_Description")) = True Then
                    e.ErrorText = "Please put description."
                    e.Valid = False
                ElseIf IsDBNull(row("MM_Amount")) = True Then
                    e.ErrorText = "Please put amount."
                    e.Valid = False
                Else
                    CalcVal()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView2_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView2.RowUpdated
        CalcVal()
    End Sub
    Private Sub GridView2_RowDeleted(sender As Object, e As DevExpress.Data.RowDeletedEventArgs) Handles GridView2.RowDeleted
        CalcVal()
    End Sub

    Private Sub GridView2_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView2.ValidateRow
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.RowHandle)

                If IsDBNull(row("MM_Description")) = True Then
                    e.ErrorText = "Please put description."
                    e.Valid = False
                ElseIf IsDBNull(row("MM_Amount")) = True Then
                    e.ErrorText = "Please put amount."
                    e.Valid = False
                Else
                    CalcVal()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtBalanceStart_EditValueChanged(sender As Object, e As EventArgs) Handles dtBalanceStart.EditValueChanged
        Try
            Dim dt As DateTime = Now

            If dtBalanceStart.EditValue IsNot Nothing AndAlso IsDate(dtBalanceStart.EditValue) = True Then
                dt = CDate(dtBalanceStart.EditValue)
            End If

            ' Dim Firstyear As New DateTime(DateTime.Now.Year, 1, 1)
            Dim Lastyear As New DateTime(dt.Year, 12, 31)


            dtBalanceEnd.EditValue = Lastyear
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            If isValid() Then

                If isEdit Then
                    If mdlProcess.Update_MovementNormal(ID, cboRefNo.EditValue, cboYA.EditValue, txtTitle.EditValue, dtStart.EditValue, _
                                                     dtEnded.EditValue, dtBalanceStart.EditValue, dtBalanceEnd.EditValue, txtAmountStart.EditValue, _
                                                     txtAmountEnd.EditValue, txtNoteStart.EditValue, txtNoteEnd.EditValue, _
                                                     DsMovement, ErrorLog) Then
                        MsgBox("Successfully updated movement.", MsgBoxStyle.Information)
                        Application.DoEvents()
                        If mdlRefreshTaxComputation.RefreshTaxcom(cboRefNo.EditValue, cboYA.EditValue, ErrorLog) = False Then
                            MsgBox("Error to recalculate tax computation.", MsgBoxStyle.Critical)

                        End If
                    Else
                        MsgBox("Unsuccessfully update movement.", MsgBoxStyle.Critical)
                    End If
                Else
                    Dim tmpID As Integer = 0
                    If mdlProcess.Save_MovementNormal(cboRefNo.EditValue, cboYA.EditValue, txtTitle.EditValue, dtStart.EditValue, _
                                                      dtEnded.EditValue, dtBalanceStart.EditValue, dtBalanceEnd.EditValue, txtAmountStart.EditValue, _
                                                      txtAmountEnd.EditValue, txtNoteStart.EditValue, txtNoteEnd.EditValue, _
                                                      DsMovement, tmpID, ErrorLog) Then
                        ID = tmpID
                        isEdit = True
                        MsgBox("Successfully saved movement.", MsgBoxStyle.Information)
                        Application.DoEvents()
                        If mdlRefreshTaxComputation.RefreshTaxcom(cboRefNo.EditValue, cboYA.EditValue, ErrorLog) = False Then
                            MsgBox("Error to recalculate tax computation.", MsgBoxStyle.Critical)

                        End If
                    Else
                        MsgBox("Unsuccessfully save movement.", MsgBoxStyle.Critical)
                    End If
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Function isValid() As Boolean
        Try
            If cboRefNo.EditValue Is Nothing OrElse cboRefNo.EditValue = "" Then
                MsgBox("Please select tax payer.", MsgBoxStyle.Exclamation)
                cboRefNo.Focus()
                Return False
            End If

            If cboYA.EditValue Is Nothing OrElse cboYA.EditValue = "" Then
                MsgBox("Please select year assessment.", MsgBoxStyle.Exclamation)
                cboYA.Focus()
                Return False
            End If

            If txtTitle.EditValue Is Nothing OrElse txtTitle.EditValue = "" Then
                MsgBox("Please enter title.", MsgBoxStyle.Exclamation)
                cboYA.Focus()
                Return False
            End If

            If dtStart.EditValue Is Nothing OrElse IsDate(dtStart.EditValue) = False Then
                dtStart.EditValue = Now
            End If
            If dtEnded.EditValue Is Nothing OrElse IsDate(dtEnded.EditValue) = False Then
                dtEnded.EditValue = Now
            End If
            If dtBalanceStart.EditValue Is Nothing OrElse IsDate(dtBalanceStart.EditValue) = False Then
                dtBalanceStart.EditValue = Now
            End If


            If isEdit = False Then

                If mdlProcess.CheckExist_MovementNormal(cboRefNo.EditValue, cboYA.EditValue, ErrorLog) Then
                    MsgBox("Movement for this company and ya " & cboYA.EditValue.ToString & " already exist.", MsgBoxStyle.Exclamation)
                    Return False
                End If

            End If

            Return True
        Catch ex As Exception
            MsgBox("Failed to validate data." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            Return False
        End Try
    End Function

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            If GridControl1.IsFocused Then
                GridView1.DeleteSelectedRows()
            End If

            If GridControl2.IsFocused Then

                GridView2.DeleteSelectedRows()
            End If
        Catch ex As Exception

        Finally
            DsMovement.Tables("MOVEMENT_ADD").AcceptChanges()
            DsMovement.Tables("MOVEMENT_DEDUCT").AcceptChanges()
        End Try
    End Sub

    Private Sub btnMoveUp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMoveUp.ItemClick
        Try
            If GridControl1.IsFocused Then
                mdlPNL.MoveItemsInListView_WithoutChild(True, "MOVEMENT_ADD", "MM_REFNO", "MM_ID", GridView1, DsMovement, ErrorLog)
            End If

            If GridControl2.IsFocused Then
                mdlPNL.MoveItemsInListView_WithoutChild(True, "MOVEMENT_DEDUCT", "MM_REFNO", "MM_ID", GridView2, DsMovement, ErrorLog)
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnMoveDown_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMoveDown.ItemClick
        Try
            If GridControl1.IsFocused Then
                mdlPNL.MoveItemsInListView_WithoutChild(False, "MOVEMENT_ADD", cboRefNo.EditValue, "MM_ID", GridView1, DsMovement, ErrorLog)
            End If

            If GridControl2.IsFocused Then
                mdlPNL.MoveItemsInListView_WithoutChild(False, "MOVEMENT_DEDUCT", cboRefNo.EditValue, "MM_ID", GridView2, DsMovement, ErrorLog)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAddChild_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddChild.ItemClick
        Try
            If GridControl1.IsFocused Then
                GridView1.FocusedRowHandle = DevExpress.XtraGrid.GridControl.NewItemRowHandle
                GridView1.FocusedColumn = GridView1.VisibleColumns(0)
            End If

            If GridControl2.IsFocused Then
                GridView2.FocusedRowHandle = DevExpress.XtraGrid.GridControl.NewItemRowHandle
                GridView2.FocusedColumn = GridView2.VisibleColumns(0)
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class