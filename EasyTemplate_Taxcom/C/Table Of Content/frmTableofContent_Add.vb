Imports DevExpress.XtraGrid.Views.Grid

Public Class frmTableofContent_Add

    Dim ErrorLog As ClsError = Nothing
    Public ID As Decimal = 0
    Public isEdit As Boolean = False

    Public Const MainTable_Default As String = "TABLE_CONTENT_DEFAULT" 'PLFST_SALES
    Public Const MainTable As String = "TABLE_CONTENT_LIST" 'PLFST_SALES
    Public Const MainKey As String = "TBL_ID" 'PLFST_SALES
    Public Const Default_Title As String = "TBL_TITLE"
    Public Const Default_ReportName As String = "TBL_REPORTNAME"
    Public Const Default_ParentNo As String = "TBL_PARENTID"
    Public Const Default_Index As String = "TBL_INDEX"
    Public Const Default_Draft As String = "TBL_SHOW_DRAFT"

    Dim autosource As AutoCompleteStringCollection = Nothing

    Private Sub frmTableofContent_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If CreateLookUpTaxPayer(DsDefault, ErrorLog) = False Then
                MsgBox("Unable to retrive tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If CreateLookUpYA(cboYA, ErrorLog, True) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Application.DoEvents()

            If autosource Is Nothing Then
                autosource = New AutoCompleteStringCollection
            Else
                autosource.Clear()
            End If

            autosource.Add("Schedule")
            autosource.Add("Appendix")

            Me.LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Public Sub LoadData(Optional ByRef Errorlog As ClsError = Nothing)
        Try
            Dim dtDefault As DataTable = ADO.Load_TableofContent_Default(Errorlog)

            DsReport_Templatexsd.Tables(MainTable_Default).Rows.Clear()
            If dtDefault IsNot Nothing Then

                For i As Integer = 0 To dtDefault.Rows.Count - 1
                    DsReport_Templatexsd.Tables(MainTable_Default).ImportRow(dtDefault(i))
                Next
            End If

            If isEdit = False Then
                If mdlProcess.ArgParam2 <> "" Then
                    cboRefNo.EditValue = mdlProcess.ArgParam2
                End If

                If mdlProcess.ArgParam3 <> "" Then
                    cboYA.EditValue = mdlProcess.ArgParam3
                End If
            Else

                Dim dt As DataTable = ADO.Load_TableofContent_ByID(ID)

                If dt Is Nothing Then
                    isEdit = False
                    MsgBox("Data not found.", MsgBoxStyle.Critical)
                    Exit Sub
                End If

                cboRefNo.EditValue = IIf(IsDBNull(dt.Rows(0)("TBL_REFNO")), "", dt.Rows(0)("TBL_REFNO"))
                cboYA.EditValue = IIf(IsDBNull(dt.Rows(0)("TBL_YA")), "", dt.Rows(0)("TBL_YA"))
                txtModifiedBy.EditValue = IIf(IsDBNull(dt.Rows(0)("ModifiedBy")), "", dt.Rows(0)("ModifiedBy"))
                txtModifiedDT.EditValue = IIf(IsDBNull(dt.Rows(0)("ModifiedDateTime")), "", dt.Rows(0)("ModifiedDateTime"))

                dt = ADO.Load_TableofContent_List_ByParentID(ID, Errorlog)

                DsReport_Templatexsd.Tables(MainTable).Rows.Clear()
                If dt IsNot Nothing Then

                    For i As Integer = 0 To dt.Rows.Count - 1
                        DsReport_Templatexsd.Tables(MainTable).ImportRow(dt(i))
                    Next
                End If

            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New ClsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = "Line: " & st.GetFrame(0).GetFileLineNumber().ToString & " - " & ex.Message
            End With
            AddListOfError(Errorlog)
        End Try
    End Sub
    Private Sub CheckLastYearTOC()
        Try
            If isEdit = True Then
                Exit Sub
            End If

            If cboRefNo.EditValue IsNot Nothing AndAlso cboYA.EditValue IsNot Nothing AndAlso IsNumeric(cboYA.EditValue) Then
                Dim LastYA As Integer = Now.Year

                LastYA = CInt(cboYA.EditValue) - 1
                If ADO.CheckExist_TableofContent(cboRefNo.EditValue, LastYA.ToString) Then

                    Dim rlst As DialogResult = MessageBox.Show("Do you want copy from previous YA data?", "Question", MessageBoxButtons.YesNo)

                    If rlst = Windows.Forms.DialogResult.Yes Then

                        Dim dt As DataTable = Nothing

                        dt = ADO.Load_TableofContent_Search(cboRefNo.EditValue, LastYA.ToString)
                        If dt IsNot Nothing Then
                            ID = IIf(IsDBNull(dt.Rows(0)("TBL_ID")), 0, dt.Rows(0)("TBL_ID"))

                            dt = ADO.Load_TableofContent_ByID(ID)

                            If dt Is Nothing Then
                                Exit Sub
                            End If

                            dt = ADO.Load_TableofContent_List_ByParentID(ID, ErrorLog)

                            DsReport_Templatexsd.Tables(MainTable).Rows.Clear()
                            If dt IsNot Nothing Then

                                For i As Integer = 0 To dt.Rows.Count - 1
                                    DsReport_Templatexsd.Tables(MainTable).ImportRow(dt(i))
                                Next
                            End If

                        End If


                    End If
                End If
            End If


        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub


    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            txtRefNo.EditValue = cboRefNo.EditValue

            CheckLastYearTOC()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Try
            If e.Column.FieldName = Default_ReportName Then
                Dim row As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)

                If row IsNot Nothing AndAlso IsDBNull(row(Default_Title)) = True OrElse row(Default_Title) = "" Then
                    row(Default_Title) = cboReportName.GetDisplayText(row(Default_ReportName))
                End If
            End If

          

        Catch ex As Exception
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub GridView1_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanging
      
    End Sub

    'Private Sub GridView1_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) Handles GridView1.CustomRowCellEdit
    '    Try
    '        If e.Column.FieldName = Default_Draft Then
    '            Dim row As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)

    '            If row IsNot Nothing AndAlso row(Default_ReportName).ToString.ToUpper = "RPT_RA" Or row(Default_ReportName).ToString.ToUpper = "RPT_ITA" Then
    '                e.Column.OptionsColumn.ReadOnly = False
    '            Else
    '                e.Column.OptionsColumn.ReadOnly = True
    '            End If
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        Try
            GridView1.GetDataRow(e.RowHandle)(Default_ParentNo) = 0

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub GridView1_ShownEditor(sender As Object, e As EventArgs) Handles GridView1.ShownEditor
        Try
            If GridView1.FocusedColumn.FieldName.Equals("TBL_SCH") Then
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

    Private Sub GridView1_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
        Try
            If TypeOf sender Is GridView Then
                Dim view As GridView = CType(sender, GridView)
                Dim row As DataRow = view.GetDataRow(e.RowHandle)

                If IsDBNull(row(Default_ReportName)) = True OrElse IsDBNull(row(Default_Title)) = True OrElse IsDBNull(row(Default_Index)) = True Then
                    e.ErrorText = "Please put report / title / index."
                    e.Valid = False
                End If

            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnMoveUp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMoveUp.ItemClick
        Try
            If cboRefNo.EditValue Is Nothing OrElse cboRefNo.EditValue = "" Then
                MsgBox("Please select reference number first.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            mdlPNL.MoveItemsInListView_WithoutChild(True, MainTable, cboRefNo.EditValue, MainKey, GridView1, DsReport_Templatexsd, ErrorLog)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnMoveDown_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMoveDown.ItemClick
        Try
            If cboRefNo.EditValue Is Nothing OrElse cboRefNo.EditValue = "" Then
                MsgBox("Please select reference number first.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            mdlPNL.MoveItemsInListView_WithoutChild(False, MainTable, cboRefNo.EditValue, MainKey, GridView1, DsReport_Templatexsd, ErrorLog)
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Try
            If isValid() Then
                DsReport_Templatexsd.Tables(MainTable).AcceptChanges()
                Application.DoEvents()

                If isEdit Then
                    If ADO.Update_TableOfContent(ID, cboRefNo.EditValue, cboRefNo.Properties.GetDisplayText(cboRefNo.EditValue), cboYA.EditValue, DsReport_Templatexsd.Tables(MainTable), ErrorLog) Then
                        MsgBox("Successfully updated data.", MsgBoxStyle.Information)

                    Else
                        MsgBox("Unsuccessfully update data.", MsgBoxStyle.Critical)
                    End If
                Else
                    Dim tmpID As Decimal = 0

                    If ADO.Save_TableOfContent(cboRefNo.EditValue, cboRefNo.Properties.GetDisplayText(cboRefNo.EditValue), cboYA.EditValue, DsReport_Templatexsd.Tables(MainTable), tmpID, ErrorLog) Then
                        MsgBox("Successfully saved data.", MsgBoxStyle.Information)
                        ID = tmpID
                        isEdit = True
                        Me.LoadData()
                    Else
                        MsgBox("Unsuccessfully save data.", MsgBoxStyle.Critical)
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
                cboRefNo.Focus()
                MsgBox("Please select tax payer.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If cboYA.EditValue Is Nothing OrElse cboYA.EditValue = "" Then
                cboYA.Focus()
                MsgBox("Please select year assessment.", MsgBoxStyle.Exclamation)
                Return False
            End If

            If isEdit = False Then
                If ADO.CheckExist_TableofContent(cboRefNo.EditValue, cboYA.EditValue, ErrorLog) Then
                    MsgBox("This tax payer already exist data for " & cboYA.EditValue & ".", MsgBoxStyle.Exclamation)
                    Return False
                End If
            End If

            Dim RptName As String = Nothing
            Dim Countx As Object
            For Each rowDetailsList As DataRow In DsReport_Templatexsd.Tables(MainTable).Rows

                RptName = rowDetailsList(Default_ReportName)

                Countx = DsReport_Templatexsd.Tables(MainTable).Compute("COUNT(TBL_REPORTNAME)", "TBL_REPORTNAME = '" & RptName & "'")

                If Countx IsNot Nothing AndAlso IsNumeric(Countx) AndAlso CInt(Countx) > 1 Then
                    MsgBox("Some of report if duplicate. please check back.", MsgBoxStyle.Exclamation)
                    Return False
                End If
            Next
            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            Return False
        End Try

    End Function

    Private Sub cboYA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYA.SelectedIndexChanged
        CheckLastYearTOC()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Try
            GridView1.DeleteSelectedRows()

            DsReport_Templatexsd.Tables(MainTable).AcceptChanges()

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

End Class