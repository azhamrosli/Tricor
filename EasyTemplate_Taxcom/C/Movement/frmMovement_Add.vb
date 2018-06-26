Imports DevExpress.XtraGrid.Views.Grid

Public Class frmMovement_Add
    Dim ErrorLog As ClsError = Nothing
    Public isEdit As Boolean = False
    Public ID As Integer = 0
    Dim MM_REFID As String = ""
    Dim autosource As AutoCompleteStringCollection = Nothing
    Sub New()

        If clsMoveNormal Is Nothing Then
            clsMoveNormal = New clsMovementNormal
        End If

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmMovement_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            clsMoveNormal.LoadWordMovement(autosource)

            If isEdit = False Then
                If mdlProcess.ArgParam2 <> "" Then
                    cboRefNo.EditValue = mdlProcess.ArgParam2
                End If

                If mdlProcess.ArgParam3 <> "" Then
                    cboYA.EditValue = mdlProcess.ArgParam3
                End If

                cboRefNo.Enabled = True
                cboYA.Enabled = True

                btnNote_Add.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                btnNote_Less.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                MM_REFID = ""
            Else
                btnNote_Add.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                btnNote_Less.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                Dim dt As DataTable = clsMoveNormal.Load_MovementNormal(ID, ErrorLog)
                DsMovement.Tables("MOVEMENT_ADD").AcceptChanges()
                DsMovement.Tables("MOVEMENT_DEDUCT").AcceptChanges()
                DsMovement.Tables("MOVEMENT_NORMAL").AcceptChanges()

                DsMovement.Tables("MOVEMENT_ADD").Rows.Clear()
                DsMovement.Tables("MOVEMENT_DEDUCT").Rows.Clear()
                DsMovement.Tables("MOVEMENT_NORMAL").Rows.Clear()
                If dt Is Nothing Then
                    cboRefNo.Enabled = True
                    cboYA.Enabled = True
                    isEdit = False
                    MM_REFID = ""
                    Exit Sub
                End If

                cboRefNo.Enabled = False
                cboYA.Enabled = False

                cboRefNo.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_REFNO")), "", dt.Rows(0)("MM_REFNO"))
                cboYA.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_YA")), "", dt.Rows(0)("MM_YA"))
                txtTitle.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_TITLE")), "", dt.Rows(0)("MM_TITLE"))
                cboType.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_TYPE")), "Year Ended", dt.Rows(0)("MM_TYPE"))
                dtEnded.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_YEAR_ENDED")), Now, dt.Rows(0)("MM_YEAR_ENDED"))
                dtBalanceStart.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_BALANCE_START")), Now, dt.Rows(0)("MM_BALANCE_START"))
                dtBalanceEnd.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_BALANCE_END")), Now, dt.Rows(0)("MM_BALANCE_END"))
                txtAmountStart.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_AMOUNT_START")), 0, dt.Rows(0)("MM_AMOUNT_START"))
                txtAmountEnd.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_AMOUNT_END")), 0, dt.Rows(0)("MM_AMOUNT_END"))
                txtNoteStart.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_NOTE_START")), 0, dt.Rows(0)("MM_NOTE_START"))
                txtNoteEnd.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_NOTE_END")), 0, dt.Rows(0)("MM_NOTE_END"))
                txtTotalAmount_AddbackDeduct.EditValue = IIf(IsDBNull(dt.Rows(0)("MM_ADD_DEDUCT_AMOUNT")), 0, dt.Rows(0)("MM_ADD_DEDUCT_AMOUNT"))
                MM_REFID = IIf(IsDBNull(dt.Rows(0)("MM_REFID")), "", dt.Rows(0)("MM_REFID"))

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

                DsMovement.Tables("MOVEMENT_NORMAL").ImportRow(dt.Rows(0))
                clsMoveNormal.StoreDataToDataset(ID, DsMovement)
            End If

            MOVEMENTADDBindingSource.DataSource = DsMovement.Tables("MOVEMENT_ADD")
            '    MOVEMENTDEDUCTBindingSource.DataSource = DsMovement.Tables("MOVEMENT_DEDUCT")
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Try
            If e.Column.FieldName = "MM_AddBack" Then
                If TypeOf sender Is GridView Then
                    Dim view As GridView = CType(sender, GridView)
                    Dim row As DataRow = view.GetDataRow(e.RowHandle)

                    If IsDBNull(row("MM_AddBack")) = False AndAlso CBool(row("MM_AddBack")) = True Then
                        row("MM_ADDBACK_AMOUNT") = row("MM_Amount")
                    Else
                        row("MM_ADDBACK_AMOUNT") = 0
                    End If
                End If
            Else
                If TypeOf sender Is GridView Then
                    Dim view As GridView = CType(sender, GridView)
                    Dim row As DataRow = view.GetDataRow(e.RowHandle)

                    If IsDBNull(row("MM_AddBack")) = False AndAlso CBool(row("MM_AddBack")) = True Then
                        row("MM_ADDBACK_AMOUNT") = row("MM_Amount")
                    Else
                        row("MM_ADDBACK_AMOUNT") = 0
                    End If
                End If
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub GridView2_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        Try
            If e.Column.FieldName = "MM_Deduct" AndAlso CBool(e.Value) = True Then
                If TypeOf sender Is GridView Then
                    Dim view As GridView = CType(sender, GridView)
                    Dim row As DataRow = view.GetDataRow(e.RowHandle)

                    If IsDBNull(row("MM_Deduct")) = False AndAlso CBool(row("MM_Deduct")) = True Then
                        row("MM_DEDUCT_AMOUNT") = row("MM_Amount")
                    Else
                        row("MM_DEDUCT_AMOUNT") = 0
                    End If

                End If
            Else
                If TypeOf sender Is GridView Then
                    Dim view As GridView = CType(sender, GridView)
                    Dim row As DataRow = view.GetDataRow(e.RowHandle)

                    If IsDBNull(row("MM_Deduct")) = False AndAlso CBool(row("MM_Deduct")) = True Then
                        row("MM_DEDUCT_AMOUNT") = row("MM_Amount")
                    Else
                        row("MM_DEDUCT_AMOUNT") = 0
                    End If

                End If
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub GridView1_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        Try
            GridView1.GetDataRow(e.RowHandle)("MM_AddBack") = False
            GridView1.GetDataRow(e.RowHandle)("MM_ADDBACK_AMOUNT") = 0
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub GridView2_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView2.InitNewRow
        Try
            GridView2.GetDataRow(e.RowHandle)("MM_Deduct") = False
            GridView2.GetDataRow(e.RowHandle)("MM_DEDUCT_AMOUNT") = 0
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            txtRefNo.EditValue = cboRefNo.EditValue
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub txtAmountStart_EditValueChanged(sender As Object, e As EventArgs) Handles txtAmountStart.EditValueChanged
        clsMoveNormal.CalcVal(DsMovement, txtAmountStart.EditValue, txtAmountEnd.EditValue, txtTotalAmount_AddbackDeduct.EditValue)
    End Sub
    Private Sub GridView1_RowDeleted(sender As Object, e As DevExpress.Data.RowDeletedEventArgs) Handles GridView1.RowDeleted
        clsMoveNormal.CalcVal(DsMovement, txtAmountStart.EditValue, txtAmountEnd.EditValue, txtTotalAmount_AddbackDeduct.EditValue)
    End Sub
    Private Sub GridView1_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated
        Try
            clsMoveNormal.CalcVal(DsMovement, txtAmountStart.EditValue, txtAmountEnd.EditValue, txtTotalAmount_AddbackDeduct.EditValue)

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub GridView1_ShownEditor(sender As Object, e As EventArgs) Handles GridView1.ShownEditor
        Try
            If GridView1.FocusedColumn.FieldName.Equals("MM_Description") Then
                Dim currentEditor As DevExpress.XtraEditors.TextEdit = CType(CType(sender, GridView).ActiveEditor, DevExpress.XtraEditors.TextEdit)

                If currentEditor IsNot Nothing Then
                    currentEditor.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    currentEditor.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource
                    currentEditor.MaskBox.AutoCompleteCustomSource = autosource
                End If
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub GridView2_ShownEditor(sender As Object, e As EventArgs) Handles GridView2.ShownEditor
        Try
            If GridView2.FocusedColumn.FieldName.Equals("MM_Description") Then
                Dim currentEditor As DevExpress.XtraEditors.TextEdit = CType(CType(sender, GridView).ActiveEditor, DevExpress.XtraEditors.TextEdit)

                If currentEditor IsNot Nothing Then
                    currentEditor.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    currentEditor.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource
                    currentEditor.MaskBox.AutoCompleteCustomSource = autosource
                End If
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub GridView2_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView2.RowUpdated
        Try

            clsMoveNormal.CalcVal(DsMovement, txtAmountStart.EditValue, txtAmountEnd.EditValue, txtTotalAmount_AddbackDeduct.EditValue)

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try

    End Sub
    Private Sub GridView2_RowDeleted(sender As Object, e As DevExpress.Data.RowDeletedEventArgs) Handles GridView2.RowDeleted
        clsMoveNormal.CalcVal(DsMovement, txtAmountStart.EditValue, txtAmountEnd.EditValue, txtTotalAmount_AddbackDeduct.EditValue)
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


                    Application.DoEvents()
                    clsMoveNormal.CalcVal(DsMovement, txtAmountStart.EditValue, txtAmountEnd.EditValue, txtTotalAmount_AddbackDeduct.EditValue)
                End If
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

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
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            If isValid() Then

                Dim TypePass As Integer = RGType.SelectedIndex


                'If chkNonAllowableExpenses.Checked Then
                '    TypePass = 1
                'ElseIf chkTaxPositive.Checked Then
                '    TypePass = 2
                'ElseIf chkTaxNegative.Checked Then
                '    TypePass = 3
                'End If
                DsMovement.Tables("MOVEMENT_ADD").AcceptChanges()
                DsMovement.Tables("MOVEMENT_DEDUCT").AcceptChanges()
                DsMovement.Tables("MOVEMENT_NORMAL").AcceptChanges()

                Application.DoEvents()

                If isEdit Then
                    If clsMoveNormal.Update_MovementNormal(ID, cboRefNo.EditValue, cboYA.EditValue, txtTitle.EditValue, cboType.EditValue, _
                                                     dtEnded.EditValue, dtBalanceStart.EditValue, dtBalanceEnd.EditValue, txtAmountStart.EditValue, _
                                                     txtAmountEnd.EditValue, txtNoteStart.EditValue, txtNoteEnd.EditValue, _
                                                     txtTotalAmount_AddbackDeduct.EditValue, TypePass, cboSourceCode.EditValue, _
                                                     MM_REFID, DsMovement, ErrorLog) Then
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
                    If clsMoveNormal.Save_MovementNormal(cboRefNo.EditValue, cboYA.EditValue, txtTitle.EditValue, cboType.EditValue, _
                                                      dtEnded.EditValue, dtBalanceStart.EditValue, dtBalanceEnd.EditValue, txtAmountStart.EditValue, _
                                                      txtAmountEnd.EditValue, txtNoteStart.EditValue, txtNoteEnd.EditValue, _
                                                      txtTotalAmount_AddbackDeduct.EditValue, TypePass, cboSourceCode.EditValue, _
                                                      DsMovement, tmpID, ErrorLog) Then
                        ID = tmpID
                        isEdit = True
                        MsgBox("Successfully saved movement.", MsgBoxStyle.Information)
                        Application.DoEvents()
                        If mdlRefreshTaxComputation.RefreshTaxcom(cboRefNo.EditValue, cboYA.EditValue, ErrorLog) = False Then
                            MsgBox("Error to recalculate tax computation.", MsgBoxStyle.Critical)

                        End If
                        Me.LoadData()
                    Else
                        MsgBox("Unsuccessfully save movement.", MsgBoxStyle.Critical)
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

            'If dtStart.EditValue Is Nothing OrElse IsDate(dtStart.EditValue) = False Then
            '    dtStart.EditValue = Now
            'End If

            If dtEnded.EditValue Is Nothing OrElse IsDate(dtEnded.EditValue) = False Then
                dtEnded.EditValue = Now
            End If
            If dtBalanceStart.EditValue Is Nothing OrElse IsDate(dtBalanceStart.EditValue) = False Then
                dtBalanceStart.EditValue = Now
            End If


            If isEdit = False Then

                'If clsMoveNormal.CheckExist_MovementNormal(cboRefNo.EditValue, cboYA.EditValue, ErrorLog) Then
                '    MsgBox("Movement for this company and ya " & cboYA.EditValue.ToString & " already exist.", MsgBoxStyle.Exclamation)
                '    Return False
                'End If

            End If

            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
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
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

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
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

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
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

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

                End If

                SearchSourceNO()
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

    Private Sub btnNote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNote_Add.ItemClick
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
                .Type_Movement = 0,
                .Type_Addless = 0,
                .DsMovement = DsMovement,
                .TagID = GridView1.GetDataRow(GridView1.FocusedRowHandle)("TagID"),
                .RowDescription = GridView1.GetDataRow(GridView1.FocusedRowHandle)("MM_Description")
            }
            frm.ShowDialog()
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
                .Type_Movement = 0,
                .Type_Addless = 1,
                .DsMovement = DsMovement,
                .TagID = GridView2.GetDataRow(GridView2.FocusedRowHandle)("TagID"),
                .RowDescription = GridView2.GetDataRow(GridView2.FocusedRowHandle)("MM_Description")
            }
            frm.ShowDialog()
        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub
End Class