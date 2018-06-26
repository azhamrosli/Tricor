Imports DevExpress.XtraGrid.Views.Grid

Public Class frmMovementComplex_Add
    Dim ErrorLog As ClsError = Nothing
    Public isEdit As Boolean = False
    Dim MM_REFID As String = ""
    Public ID As Decimal = 0

    Private Sub frmMovementComplex_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

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


            cboType.EditValue = "Year Ended"
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

                cboRefNo.Enabled = True
                cboYA.Enabled = True
                Me.Text = "Movement Complex - Add"

                MM_REFID = ""
                btnNote_Add.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                btnNote_Less.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Else
                btnNote_Add.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                btnNote_Less.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                Dim dt As DataTable = ADO.Load_MovementComplex(ID, ErrorLog)

                If dt Is Nothing Then
                    cboRefNo.Enabled = True
                    cboYA.Enabled = True
                    Me.Text = "Movement Complex - Add"
                    isEdit = False
                    MM_REFID = ""
                    Exit Sub
                End If

                cboRefNo.Enabled = False
                cboYA.Enabled = False

                Me.Text = "Movement Complex - Edit"
                Application.DoEvents()

                cboRefNo.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_REFNO")), "", dt.Rows(0)("MM_REFNO"))
                cboYA.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_YA")), "", dt.Rows(0)("MM_YA"))
                txtTitle.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_TITLE")), "", dt.Rows(0)("MM_TITLE"))
                cboType.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_TYPE")), "Year Ended", dt.Rows(0)("MM_TYPE"))
                dtEnded.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_YEAR_ENDED")), Now, dt.Rows(0)("MM_YEAR_ENDED"))
                dtBalanceStart.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_BALANCE_START")), Now, dt.Rows(0)("MM_BALANCE_START"))
                dtBalanceEnd.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_BALANCE_END")), Now, dt.Rows(0)("MM_BALANCE_END"))
                dtBalanceEnd.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_BALANCE_END")), Now, dt.Rows(0)("MM_BALANCE_END"))
                txtNoteStart.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_NOTE_START")), "", dt.Rows(0)("MM_NOTE_START"))
                txtNoteEnd.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_NOTE_END")), "", dt.Rows(0)("MM_NOTE_END"))
                txtNoteEnd.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_NOTE_END")), "", dt.Rows(0)("MM_NOTE_END"))
                txtAmountGeneral.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_GENERAL_START")), 0, dt.Rows(0)("MM_GENERAL_START"))
                MM_REFID = IIf(IsDBNull(dt.Rows(0)("MM_REFID")), "", dt.Rows(0)("MM_REFID"))
                txtAmountSpecificAllow.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_SPECIFIC_ALLOWABLE_START")), 0, dt.Rows(0)("MM_SPECIFIC_ALLOWABLE_START"))
                txtAmountSpecificNonAllow.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_SPECIFIC_NONALLOWABLE_START")), 0, dt.Rows(0)("MM_SPECIFIC_NONALLOWABLE_START"))
                RGType.SelectedIndex = IIf(IsDBNull(dt.Rows(0)("MM_TYPE_PASS")), 0, dt.Rows(0)("MM_TYPE_PASS"))
                'If IsDBNull(dt.Rows(0)("MM_TYPE_PASS")) = False AndAlso dt.Rows(0)("MM_TYPE_PASS") = 1 Then
                '    chkNonAllowableExpenses.Checked = True
                '    chkTaxPositive.Checked = False
                '    chkTaxNegative.Checked = False
                'ElseIf IsDBNull(dt.Rows(0)("MM_TYPE_PASS")) = False AndAlso dt.Rows(0)("MM_TYPE_PASS") = 2 Then
                '    chkNonAllowableExpenses.Checked = False
                '    chkTaxPositive.Checked = True
                '    chkTaxNegative.Checked = False
                'ElseIf IsDBNull(dt.Rows(0)("MM_TYPE_PASS")) = False AndAlso dt.Rows(0)("MM_TYPE_PASS") = 3 Then
                '    chkNonAllowableExpenses.Checked = False
                '    chkTaxPositive.Checked = False
                '    chkTaxNegative.Checked = True
                'Else
                '    chkNonAllowableExpenses.Checked = False
                '    chkTaxPositive.Checked = False
                '    chkTaxNegative.Checked = False
                'End If
                cboSourceCode.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_SOURCENO")), 0, dt.Rows(0)("MM_SOURCENO"))

                DsMovement.Tables("MOVEMENT_COMPLEX_ADD").Rows.Clear()
                DsMovement.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows.Clear()
                DsMovement.Tables("MOVEMENT_COMPLEX").Rows.Clear()


                If dt IsNot Nothing Then
                    For Each rowx As DataRow In dt.Rows
                        DsMovement.Tables("MOVEMENT_COMPLEX").ImportRow(rowx)
                    Next
                End If


                dt = ADO.Load_MovementComplex_Add(ID, ErrorLog)

                DsMovement.Tables("MOVEMENT_COMPLEX_ADD").Rows.Clear()
                If dt IsNot Nothing Then
                    For Each rowx As DataRow In dt.Rows
                        ' rowx("MM_ID") = DsMovement.Tables("MOVEMENT_COMPLEX_ADD").Rows.Count + 1
                        ' Application.DoEvents()
                        DsMovement.Tables("MOVEMENT_COMPLEX_ADD").ImportRow(rowx)
                    Next
                End If

                dt = ADO.Load_MovementComplex_Deduct(ID, ErrorLog)


                If dt IsNot Nothing Then
                    For Each rowx As DataRow In dt.Rows
                        '  rowx("MM_ID") = DsMovement.Tables("MOVEMENT_COMPLEX_DEDUCT").Rows.Count + 1
                        DsMovement.Tables("MOVEMENT_COMPLEX_DEDUCT").ImportRow(rowx)
                    Next
                End If



                Application.DoEvents()
                CalcVal()

            End If

            MOVEMENTCOMPLEXADDBindingSource.DataSource = DsMovement.Tables("MOVEMENT_COMPLEX_ADD")
            MOVEMENTCOMPLEXDEDUCTBindingSource.DataSource = DsMovement.Tables("MOVEMENT_COMPLEX_DEDUCT")
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Try
            If e.Column.FieldName = "MM_GENERAL_ADDBACK" Or e.Column.FieldName = "MM_SPECIFIC_ALLOWABLE_ADDBACK" Or e.Column.FieldName = "MM_SPECIFIC_NONALLOWABLE_ADDBACK" Then

                If TypeOf sender Is GridView Then
                    Dim view As GridView = CType(sender, GridView)
                    Dim row As DataRow = view.GetDataRow(e.RowHandle)
                    Dim Total As Decimal = 0

                    If IsDBNull(row("MM_GENERAL_ADDBACK")) = False AndAlso CBool(row("MM_GENERAL_ADDBACK")) = True Then
                        Total += IIf(IsDBNull(row("MM_GENERAL")), 0, row("MM_GENERAL"))
                    End If
                    If IsDBNull(row("MM_SPECIFIC_ALLOWABLE_ADDBACK")) = False AndAlso CBool(row("MM_SPECIFIC_ALLOWABLE_ADDBACK")) = True Then
                        Total += IIf(IsDBNull(row("MM_SPECIFIC_ALLOWABLE")), 0, row("MM_SPECIFIC_ALLOWABLE"))
                    End If
                    If IsDBNull(row("MM_SPECIFIC_NONALLOWABLE_ADDBACK")) = False AndAlso CBool(row("MM_SPECIFIC_NONALLOWABLE_ADDBACK")) = True Then
                        Total += IIf(IsDBNull(row("MM_SPECIFIC_NONALLOWABLE")), 0, row("MM_SPECIFIC_NONALLOWABLE"))
                    End If

                    row("MM_ADDBACK_AMOUNT") = Total
                End If


            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub GridView2_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        Try
            If e.Column.FieldName = "MM_GENERAL_DEDUCT" Or e.Column.FieldName = "MM_SPECIFIC_ALLOWABLE_DEDUCT" Or e.Column.FieldName = "MM_SPECIFIC_NONALLOWABLE_DEDUCT" Then

                If TypeOf sender Is GridView Then
                    Dim view As GridView = CType(sender, GridView)
                    Dim row As DataRow = view.GetDataRow(e.RowHandle)
                    Dim Total As Decimal = 0

                    If IsDBNull(row("MM_GENERAL_DEDUCT")) = False AndAlso CBool(row("MM_GENERAL_DEDUCT")) = True Then
                        Total += IIf(IsDBNull(row("MM_GENERAL")), 0, row("MM_GENERAL"))
                    End If
                    If IsDBNull(row("MM_SPECIFIC_ALLOWABLE_DEDUCT")) = False AndAlso CBool(row("MM_SPECIFIC_ALLOWABLE_DEDUCT")) = True Then
                        Total += IIf(IsDBNull(row("MM_SPECIFIC_ALLOWABLE")), 0, row("MM_SPECIFIC_ALLOWABLE"))
                    End If
                    If IsDBNull(row("MM_SPECIFIC_NONALLOWABLE_DEDUCT")) = False AndAlso CBool(row("MM_SPECIFIC_NONALLOWABLE_DEDUCT")) = True Then
                        Total += IIf(IsDBNull(row("MM_SPECIFIC_NONALLOWABLE")), 0, row("MM_SPECIFIC_NONALLOWABLE"))
                    End If

                    row("MM_DEDUCT_AMOUNT") = Total
                End If


            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub GridView1_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        Try
            GridView1.GetDataRow(e.RowHandle)("MM_GENERAL_ADDBACK") = False
            GridView1.GetDataRow(e.RowHandle)("MM_SPECIFIC_ALLOWABLE_ADDBACK") = False
            GridView1.GetDataRow(e.RowHandle)("MM_SPECIFIC_NONALLOWABLE_ADDBACK") = False
            GridView1.GetDataRow(e.RowHandle)("MM_ADDBACK_AMOUNT") = 0
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub GridView2_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView2.InitNewRow
        Try
            GridView2.GetDataRow(e.RowHandle)("MM_GENERAL_DEDUCT") = False
            GridView2.GetDataRow(e.RowHandle)("MM_SPECIFIC_ALLOWABLE_DEDUCT") = False
            GridView2.GetDataRow(e.RowHandle)("MM_SPECIFIC_NONALLOWABLE_DEDUCT") = False
            GridView2.GetDataRow(e.RowHandle)("MM_DEDUCT_AMOUNT") = 0
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs)
        Try
            txtRefNo.EditValue = cboRefNo.EditValue
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

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
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
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
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

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
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

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
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
        Finally
            CalcVal()
        End Try
    End Sub
    Private Sub CalcVal()
        Try
            Dim TotalGeneral As Decimal = 0
            Dim TotalSpecificAllawable As Decimal = 0
            Dim TotalSpecificNonAllawable As Decimal = 0
            Dim Total_AddbackDeduct As Decimal = 0

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
                    If IsDBNull(rowx("MM_ADDBACK_AMOUNT")) = False Then

                        Total_AddbackDeduct += CDec(rowx("MM_ADDBACK_AMOUNT"))

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
                    If IsDBNull(rowx("MM_DEDUCT_AMOUNT")) = False Then

                        Total_AddbackDeduct -= CDec(rowx("MM_DEDUCT_AMOUNT"))

                    End If
                Next

            End If

            txtAmountGeneral_End.EditValue = TotalGeneral
            txtAmountSpecificAllow_End.EditValue = TotalSpecificAllawable
            txtAmountSpecificNonAllow_End.EditValue = TotalSpecificNonAllawable
            txtTotal_AddBackDeduct.EditValue = Total_AddbackDeduct
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

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
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

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
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

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
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

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
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            If isValid() Then


                Dim TypePass As Integer = RGType.SelectedIndex

                DsMovement.Tables("MOVEMENT_COMPLEX_ADD").AcceptChanges()
                DsMovement.Tables("MOVEMENT_COMPLEX_DEDUCT").AcceptChanges()
                DsMovement.Tables("MOVEMENT_COMPLEX").AcceptChanges()
                Application.DoEvents()



                If isEdit Then
                    If ADO.Update_MovementComplex(ID, cboRefNo.EditValue, cboYA.EditValue, txtTitle.EditValue, cboType.EditValue, _
                                                     dtEnded.EditValue, dtBalanceStart.EditValue, dtBalanceEnd.EditValue, txtAmountGeneral.EditValue, txtAmountSpecificAllow.EditValue, txtAmountSpecificNonAllow.EditValue, _
                                                      txtNoteStart.EditValue, txtNoteEnd.EditValue, txtAmountGeneral_End.EditValue, txtAmountSpecificAllow_End.EditValue, txtAmountSpecificNonAllow_End.EditValue, _
                                                      txtTotal_AddBackDeduct.EditValue, TypePass, cboSourceCode.EditValue, MM_REFID, DsMovement, ErrorLog) Then
                        MsgBox("Successfully updated movement.", MsgBoxStyle.Information)
                        Application.DoEvents()
                        If mdlRefreshTaxComputation.RefreshTaxcom(cboRefNo.EditValue, cboYA.EditValue, ErrorLog) = False Then
                            MsgBox("Error to recalculate tax computation.", MsgBoxStyle.Critical)

                        End If

                        Me.LoadData()
                    Else
                        MsgBox("Unsuccessfully update movement.", MsgBoxStyle.Critical)
                    End If
                Else
                    Dim tmpID As Integer = 0
                    If ADO.Save_MovementComplex(cboRefNo.EditValue, cboYA.EditValue, txtTitle.EditValue, cboType.EditValue, _
                                                     dtEnded.EditValue, dtBalanceStart.EditValue, dtBalanceEnd.EditValue, txtAmountGeneral.EditValue, txtAmountSpecificAllow.EditValue, txtAmountSpecificNonAllow.EditValue, _
                                                      txtNoteStart.EditValue, txtNoteEnd.EditValue, txtAmountGeneral_End.EditValue, txtAmountSpecificAllow_End.EditValue, txtAmountSpecificNonAllow_End.EditValue, txtTotal_AddBackDeduct.EditValue, TypePass, cboSourceCode.EditValue, DsMovement, tmpID, ErrorLog) Then
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
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

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

            If cboSourceCode.EditValue Is Nothing OrElse IsNumeric(cboSourceCode.EditValue) = False Then
                MsgBox("Please select source no.", MsgBoxStyle.Exclamation)
                cboSourceCode.Focus()
                Return False
            End If

            If dtEnded.EditValue Is Nothing OrElse IsDate(dtEnded.EditValue) = False Then
                dtEnded.EditValue = Now
            End If
            If dtBalanceStart.EditValue Is Nothing OrElse IsDate(dtBalanceStart.EditValue) = False Then
                dtBalanceStart.EditValue = Now
            End If


            'If isEdit = False Then

            '    If ADO.CheckExist_MovementComplex(cboRefNo.EditValue, cboYA.EditValue, ErrorLog) Then
            '        MsgBox("Movement for this company and ya " & cboYA.EditValue.ToString & " already exist.", MsgBoxStyle.Exclamation)
            '        Return False
            '    End If

            'End If

            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            MsgBox("Failed to validate data." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            Return False
        End Try
    End Function

    Private Sub cboRefNo_EditValueChanged_1(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            txtRefNo.EditValue = cboRefNo.EditValue

            If cboRefNo.EditValue IsNot Nothing AndAlso cboRefNo.EditValue <> "" Then
                Dim dt As DataTable = ADO.LoadTaxPayer_ByRefNO(cboRefNo.EditValue)

                If dt IsNot Nothing AndAlso isEdit = False Then
                    Dim BasisPeriodFrom As DateTime = IIf(IsDBNull(dt.Rows(0)("TP_BASIS_PERIOD_FR")), Now, dt.Rows(0)("TP_BASIS_PERIOD_FR"))
                    Dim BasisPeriodTo As DateTime = IIf(IsDBNull(dt.Rows(0)("TP_BASIS_PERIOD_TO")), Now, dt.Rows(0)("TP_BASIS_PERIOD_TO"))

                    dtBalanceStart.EditValue = BasisPeriodFrom
                    dtBalanceEnd.EditValue = BasisPeriodTo

                    If DateDiff(DateInterval.Month, BasisPeriodFrom, BasisPeriodTo) = 12 Then
                        cboType.EditValue = "Year Ended"
                    Else
                        cboType.EditValue = "Period Ended"
                    End If
                    dtEnded.EditValue = IIf(IsDBNull(dt.Rows(0)("TP_ACC_PERIOD_TO")), Now, dt.Rows(0)("TP_ACC_PERIOD_TO"))


                    SearchSourceNO()
                End If
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub SearchSourceNO()
        Try
            If mdlProcess.CreateLookUpSourceNO(cboSourceCode, cboRefNo.EditValue.ToString, cboYA.EditValue.ToString, ErrorLog) = False Then
                cboSourceCode.EditValue = ""
            Else
                cboSourceCode.SelectedIndex = 0
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub cboYA_EditValueChanged(sender As Object, e As EventArgs) Handles cboYA.EditValueChanged
        Try
            SearchSourceNO()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnNote_Less_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNote_Less.ItemClick
        Try
            If isEdit = False Then
                MsgBox("Please save this data first before proceed to insert note.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim frm As New frmNote_Movement With {
                .RefNo = CType(cboRefNo.EditValue, String),
                .YA = cboYA.EditValue,
                .MM_ID = ID,
                .Data_SubID = GridView2.GetDataRow(GridView2.FocusedRowHandle)("MM_ID"),
                .Type_Movement = 1,
                .Type_Addless = 1,
                .TagID = GridView1.GetDataRow(GridView1.FocusedRowHandle)("TagID"),
                .DsMovement = DsMovement,
                .RowDescription = GridView2.GetDataRow(GridView2.FocusedRowHandle)("MM_Description")
            }
            frm.ShowDialog()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnNote_Add_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNote_Add.ItemClick
        Try
            If isEdit = False Then
                MsgBox("Please save this data first before proceed to insert note.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim frm As New frmNote_Movement With {
                .RefNo = CType(cboRefNo.EditValue, String),
                .YA = cboYA.EditValue,
                .MM_ID = ID,
                .Data_SubID = GridView1.GetDataRow(GridView1.FocusedRowHandle)("MM_ID"),
                .Type_Movement = 1,
                .Type_Addless = 0,
                .TagID = GridView1.GetDataRow(GridView1.FocusedRowHandle)("TagID"),
                .DsMovement = DsMovement,
                .RowDescription = GridView1.GetDataRow(GridView1.FocusedRowHandle)("MM_Description")
            }
            frm.ShowDialog()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
End Class