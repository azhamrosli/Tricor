Imports DevExpress.XtraGrid.Views.Grid

Public Class frmMovementComplex_Add
    Dim ErrorLog As clsError = Nothing
    Public isEdit As Boolean = False
    Public ID As Decimal = 0

    Private Sub frmMovementComplex_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

                Me.Text = "Movement Complex - Add"
            Else


                Dim dt As DataTable = mdlProcess.Load_MovementComplex(ID, ErrorLog)

                If dt Is Nothing Then
                    Me.Text = "Movement Complex - Add"
                    isEdit = False
                    Exit Sub
                End If

                Me.Text = "Movement Complex - Edit"
                Application.DoEvents()

                cboRefNo.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_REFNO")), "", dt.Rows(0)("MM_REFNO"))
                cboYA.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_YA")), "", dt.Rows(0)("MM_YA"))
                txtTitle.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_TITLE")), "", dt.Rows(0)("MM_TITLE"))
                dtStart.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_PERIOD_ENDED")), Now, dt.Rows(0)("MM_PERIOD_ENDED"))
                dtEnded.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_YEAR_ENDED")), Now, dt.Rows(0)("MM_YEAR_ENDED"))
                dtBalanceStart.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_BALANCE_START")), Now, dt.Rows(0)("MM_BALANCE_START"))
                dtBalanceEnd.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_BALANCE_END")), Now, dt.Rows(0)("MM_BALANCE_END"))
                dtBalanceEnd.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_BALANCE_END")), Now, dt.Rows(0)("MM_BALANCE_END"))
                txtNoteStart.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_NOTE_START")), "", dt.Rows(0)("MM_NOTE_START"))
                txtNoteEnd.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_NOTE_END")), "", dt.Rows(0)("MM_NOTE_END"))
                txtNoteEnd.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_NOTE_END")), "", dt.Rows(0)("MM_NOTE_END"))
                txtAmountGeneral.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_GENERAL_START")), 0, dt.Rows(0)("MM_GENERAL_START"))
                txtAmountSpecificAllow.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_SPECIFIC_ALLOWABLE_START")), 0, dt.Rows(0)("MM_SPECIFIC_ALLOWABLE_START"))
                txtAmountSpecificNonAllow.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_SPECIFIC_NONALLOWABLE_START")), 0, dt.Rows(0)("MM_SPECIFIC_NONALLOWABLE_START"))

                dt = mdlProcess.Load_MovementComplex_Deduct(ID, ErrorLog)

                DsMovement.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows.Clear()
                If dt IsNot Nothing Then
                    For Each rowx As DataRow In dt.Rows
                        rowx("MM_ID") = DsMovement.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows.Count + 1
                        DsMovement.Tables("MOVEMENT_COMPLEX_DEDUCT").ImportRow(rowx)
                    Next
                End If

                dt = mdlProcess.Load_MovementComplex_Add(ID, ErrorLog)

                DsMovement.Tables("MOVEMENT_COMPLEX_ADD").Rows.Clear()
                If dt IsNot Nothing Then
                    For Each rowx As DataRow In dt.Rows
                        rowx("MM_ID") = DsMovement.Tables("MOVEMENT_COMPLEX_ADD").Rows.Count + 1
                        Application.DoEvents()
                        DsMovement.Tables("MOVEMENT_COMPLEX_ADD").ImportRow(rowx)
                    Next
                End If

                Application.DoEvents()
                CalcVal()

            End If

            MOVEMENTCOMPLEXADDBindingSource.DataSource = DsMovement.Tables("MOVEMENT_COMPLEX_ADD")
            MOVEMENTCOMPLEXDEDUCTBindingSource.DataSource = DsMovement.Tables("MOVEMENT_COMPLEX_DEDUCT")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView1_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        Try
            GridView1.GetDataRow(e.RowHandle)("MM_GENERAL_ADDBACK") = False
            GridView1.GetDataRow(e.RowHandle)("MM_SPECIFIC_ALLOWABLE_ADDBACK") = False
            GridView1.GetDataRow(e.RowHandle)("MM_SPECIFIC_NONALLOWABLE_ADDBACK") = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView2_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView2.InitNewRow
        Try
            GridView2.GetDataRow(e.RowHandle)("MM_GENERAL_DEDUCT") = False
            GridView2.GetDataRow(e.RowHandle)("MM_SPECIFIC_ALLOWABLE_DEDUCT") = False
            GridView2.GetDataRow(e.RowHandle)("MM_SPECIFIC_NONALLOWABLE_DEDUCT") = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            txtRefNo.EditValue = cboRefNo.EditValue
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GridView1_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.RowHandle)

                If IsDBNull(row("MM_Description")) = True Then
                    e.ErrorText = "Please put description."
                    e.Valid = False
                Else
                    row("MM_Amount") = CDec(row("MM_GENERAL")) + CDec(row("MM_SPECIFIC_ALLOWABLE")) + CDec(row("MM_SPECIFIC_NONALLOWABLE"))
                End If
            End If
        Catch ex As Exception
        Finally
            CalcVal()
        End Try
    End Sub
    Private Sub GridView1_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.RowHandle)

                If row IsNot Nothing Then
                    row("MM_Amount") = CDec(row("MM_GENERAL")) + CDec(row("MM_SPECIFIC_ALLOWABLE")) + CDec(row("MM_SPECIFIC_NONALLOWABLE"))
                End If

            End If
        Catch ex As Exception

        Finally
            CalcVal()
        End Try
    End Sub
    Private Sub GridView2_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView2.RowUpdated
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.RowHandle)

                If row IsNot Nothing Then
                    row("MM_Amount") = CDec(row("MM_GENERAL")) + CDec(row("MM_SPECIFIC_ALLOWABLE")) + CDec(row("MM_SPECIFIC_NONALLOWABLE"))
                End If

            End If
        Catch ex As Exception

        Finally
            CalcVal()
        End Try
    End Sub
    Private Sub GridView2_RowDeleted(sender As Object, e As DevExpress.Data.RowDeletedEventArgs) Handles GridView2.RowDeleted
        ' CalcVal()
    End Sub
    Private Sub GridView2_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView2.ValidateRow
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.RowHandle)

                If IsDBNull(row("MM_Description")) = True Then
                    e.ErrorText = "Please put description."
                    e.Valid = False
                Else
                    row("MM_Amount") = CDec(row("MM_GENERAL")) + CDec(row("MM_SPECIFIC_ALLOWABLE")) + CDec(row("MM_SPECIFIC_NONALLOWABLE"))
                End If
            End If
        Catch ex As Exception
        Finally
            CalcVal()
        End Try
    End Sub
    Private Sub CalcVal()
        Try
            Dim TotalGeneral As Decimal = 0
            Dim TotalSpecificAllawable As Decimal = 0
            Dim TotalSpecificNonAllawable As Decimal = 0

            If txtAmountGeneral.EditValue IsNot Nothing AndAlso IsNumeric(txtAmountGeneral.EditValue) = True Then
                TotalGeneral = CDec(txtAmountGeneral.EditValue)
            End If
            If txtAmountSpecificAllow.EditValue IsNot Nothing AndAlso IsNumeric(txtAmountSpecificAllow.EditValue) = True Then
                TotalSpecificAllawable = CDec(txtAmountSpecificAllow.EditValue)
            End If
            If txtAmountSpecificNonAllow.EditValue IsNot Nothing AndAlso IsNumeric(txtAmountSpecificNonAllow.EditValue) = True Then
                TotalSpecificNonAllawable = CDec(txtAmountSpecificNonAllow.EditValue)
            End If

            If DsMovement.Tables("MOVEMENT_COMPLEX_ADD").Rows.Count > 0 Then

                For Each rowx As DataRow In DsMovement.Tables("MOVEMENT_COMPLEX_ADD").Rows

                    If IsDBNull(rowx("MM_GENERAL")) = False Then

                        TotalGeneral += CDec(rowx("MM_GENERAL"))

                    End If
                    If IsDBNull(rowx("MM_SPECIFIC_ALLOWABLE")) = False Then

                        TotalSpecificAllawable += CDec(rowx("MM_SPECIFIC_ALLOWABLE"))

                    End If
                    If IsDBNull(rowx("MM_SPECIFIC_NONALLOWABLE")) = False Then

                        TotalSpecificNonAllawable += CDec(rowx("MM_SPECIFIC_NONALLOWABLE"))

                    End If
                Next

            End If

            If DsMovement.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows.Count > 0 Then

                For Each rowx As DataRow In DsMovement.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows

                    If IsDBNull(rowx("MM_GENERAL")) = False Then

                        TotalGeneral -= CDec(rowx("MM_GENERAL"))

                    End If
                    If IsDBNull(rowx("MM_SPECIFIC_ALLOWABLE")) = False Then

                        TotalSpecificAllawable -= CDec(rowx("MM_SPECIFIC_ALLOWABLE"))

                    End If
                    If IsDBNull(rowx("MM_SPECIFIC_NONALLOWABLE")) = False Then

                        TotalSpecificNonAllawable -= CDec(rowx("MM_SPECIFIC_NONALLOWABLE"))

                    End If
                Next

            End If

            txtAmountGeneral_End.EditValue = TotalGeneral
            txtAmountSpecificAllow_End.EditValue = TotalSpecificAllawable
            txtAmountSpecificNonAllow_End.EditValue = TotalSpecificNonAllawable
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtAmountSpecificNonAllow_EditValueChanged(sender As Object, e As EventArgs) Handles txtAmountSpecificNonAllow.EditValueChanged, txtAmountSpecificAllow.EditValueChanged, txtAmountGeneral.EditValueChanged
        Me.CalcVal()
    End Sub
    Private Sub btnMoveUp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMoveUp.ItemClick
        Try
            If GridControl1.IsFocused Then
                mdlPNL.MoveItemsInListView_WithoutChild(True, "MOVEMENT_COMPLEX_ADD", "MM_REFNO", "MM_ID", GridView1, DsMovement, ErrorLog)
            End If

            If GridControl2.IsFocused Then
                mdlPNL.MoveItemsInListView_WithoutChild(True, "MOVEMENT_COMPLEX_DEDUCT", "MM_REFNO", "MM_ID", GridView2, DsMovement, ErrorLog)
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnMoveDown_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMoveDown.ItemClick
        Try
            If GridControl1.IsFocused Then
                mdlPNL.MoveItemsInListView_WithoutChild(False, "MOVEMENT_COMPLEX_ADD", cboRefNo.EditValue, "MM_ID", GridView1, DsMovement, ErrorLog)
            End If

            If GridControl2.IsFocused Then
                mdlPNL.MoveItemsInListView_WithoutChild(False, "MOVEMENT_COMPLEX_DEDUCT", cboRefNo.EditValue, "MM_ID", GridView2, DsMovement, ErrorLog)
            End If
        Catch ex As Exception

        End Try
    End Sub
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
            DsMovement.Tables("MOVEMENT_COMPLEX_ADD").AcceptChanges()
            DsMovement.Tables("MOVEMENT_COMPLEX_DEDUCT").AcceptChanges()
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

    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            If isValid() Then

                If isEdit Then
                    If mdlProcess.Update_MovementComplex(ID, cboRefNo.EditValue, cboYA.EditValue, txtTitle.EditValue, dtStart.EditValue, _
                                                     dtEnded.EditValue, dtBalanceStart.EditValue, dtBalanceEnd.EditValue, txtAmountGeneral.EditValue, txtAmountSpecificAllow.EditValue, txtAmountSpecificNonAllow.EditValue, _
                                                      txtNoteStart.EditValue, txtNoteEnd.EditValue, txtAmountGeneral_End.EditValue, txtAmountSpecificAllow_End.EditValue, txtAmountSpecificNonAllow_End.EditValue, DsMovement, ErrorLog) Then
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
                    If mdlProcess.Save_MovementComplex(cboRefNo.EditValue, cboYA.EditValue, txtTitle.EditValue, dtStart.EditValue, _
                                                     dtEnded.EditValue, dtBalanceStart.EditValue, dtBalanceEnd.EditValue, txtAmountGeneral.EditValue, txtAmountSpecificAllow.EditValue, txtAmountSpecificNonAllow.EditValue, _
                                                      txtNoteStart.EditValue, txtNoteEnd.EditValue, txtAmountGeneral_End.EditValue, txtAmountSpecificAllow_End.EditValue, txtAmountSpecificNonAllow_End.EditValue, DsMovement, tmpID, ErrorLog) Then
                        ID = tmpID
                        isEdit = True
                        MsgBox("Successfully updated movement.", MsgBoxStyle.Information)
                        Application.DoEvents()
                        If mdlRefreshTaxComputation.RefreshTaxcom(cboRefNo.EditValue, cboYA.EditValue, ErrorLog) = False Then
                            MsgBox("Error to recalculate tax computation.", MsgBoxStyle.Critical)

                        End If
                        Me.LoadData()
                    Else
                        MsgBox("Unsuccessfully update movement.", MsgBoxStyle.Critical)
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

                If mdlProcess.CheckExist_MovementComplex(cboRefNo.EditValue, cboYA.EditValue, ErrorLog) Then
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
End Class