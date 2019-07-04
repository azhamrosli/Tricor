Public Class ucMapping_Code_List
    Dim Errorlog As ClsError = Nothing
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If ADO Is Nothing Then
            ADO = New clsIODatabase
        End If

    End Sub

    Private Sub ucMapping_Code_List_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            LoadData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadData()
        Try
            Dim dt As DataTable = Nothing

            DsAccountMapping.Tables("MAPPING_CODE_LIST").Rows.Clear()

            dt = ADO.Load_Mapping_Code_list()

            If dt IsNot Nothing Then
                For Each rowx As DataRow In dt.Rows
                    DsAccountMapping.Tables("MAPPING_CODE_LIST").ImportRow(rowx)
                Next
            End If

            MAPPINGCODELISTBindingSource.DataSource = DsAccountMapping.Tables("MAPPING_CODE_LIST")

            Dim dtKeyName As DataTable = ADO.Load_KeyName_Default()

            If dtKeyName IsNot Nothing Then
                Dim dtRow As DataRow = Nothing

                For Each rowx As DataRow In dtKeyName.Rows

                    If rowx("Type") = 1 Then
                        rowx("Description") = "Balance Sheet - " & IIf(IsDBNull(rowx("Description")), "", rowx("Description")) & " = [" & IIf(IsDBNull(rowx("KeyName")), "", rowx("KeyName")) & "]"
                    Else
                        rowx("Description") = "Profit & Loss - " & IIf(IsDBNull(rowx("Description")), "", rowx("Description")) & " = [" & IIf(IsDBNull(rowx("KeyName")), "", rowx("KeyName")) & "]"
                    End If

                    Application.DoEvents()
                    DsAccountMapping.Tables("KeyName").ImportRow(rowx)
                Next
            End If

            KeyNameBindingSource.DataSource = DsAccountMapping.Tables("KeyName")

            Dim dtRowInd As DataRow = Nothing
            dtRowInd = Nothing
            dtRowInd = DsAccountMapping.Tables("INDICATOR").NewRow
            dtRowInd("ID") = 0
            dtRowInd("Description") = "Positive"
            DsAccountMapping.Tables("INDICATOR").Rows.Add(dtRowInd)
            dtRowInd = Nothing
            dtRowInd = DsAccountMapping.Tables("INDICATOR").NewRow
            dtRowInd("ID") = 1
            dtRowInd("Description") = "Negative (- sign in excel)"
            DsAccountMapping.Tables("INDICATOR").Rows.Add(dtRowInd)
            dtRowInd = Nothing
            dtRowInd = DsAccountMapping.Tables("INDICATOR").NewRow
            dtRowInd("ID") = 2
            dtRowInd("Description") = "Dynamic Positive (- sign in excel but on system convert always to positive)"
            DsAccountMapping.Tables("INDICATOR").Rows.Add(dtRowInd)
            dtRowInd = Nothing
            dtRowInd = DsAccountMapping.Tables("INDICATOR").NewRow
            dtRowInd("ID") = 3
            dtRowInd("Description") = "Dynamic Negative (+ sign in excel but on system convert always to negative)"
            DsAccountMapping.Tables("INDICATOR").Rows.Add(dtRowInd)

            INDICATORBindingSource.DataSource = DsAccountMapping.Tables("INDICATOR")
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

    Private Sub btnImport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImport.ItemClick
        Try
            Dim frm As New frmMapping_Code_List_Import
            frm.ShowDialog()

            If frm.dtReturn IsNot Nothing Then

                DsAccountMapping.Tables("MAPPING_CODE_LIST").Rows.Clear()

                Dim dtRow_Import As DataRow = Nothing
                Dim tmpKeynamestr() As String = Nothing
                For i As Integer = 0 To frm.dtReturn.Rows.Count - 1
                    If frm.isFirstHasColumnName = True AndAlso i = 0 Then

                    Else
                        dtRow_Import = DsAccountMapping.Tables("MAPPING_CODE_LIST").NewRow
                        dtRow_Import("ID") = DsAccountMapping.Tables("MAPPING_CODE_LIST").Rows.Count + 1
                        dtRow_Import("Code") = frm.dtReturn.Rows(i)(0)
                        dtRow_Import("Type") = frm.dtReturn.Rows(i)(1)

                        If IsDBNull(frm.dtReturn.Rows(i)(2)) = False AndAlso frm.dtReturn.Rows(i)(2) <> "" AndAlso frm.dtReturn.Rows(i)(2).ToString.Contains(" = [") Then
                            tmpKeynamestr = frm.dtReturn.Rows(i)(2).ToString.Split("[ [")
                            If tmpKeynamestr.Count = 2 Then
                                dtRow_Import("Keyname") = tmpKeynamestr(1).Replace("]", "")
                            Else
                                dtRow_Import("Keyname") = DBNull.Value
                            End If

                        Else
                            dtRow_Import("Keyname") = DBNull.Value
                        End If
                        dtRow_Import("ModifiedBy") = My.Computer.Name
                        dtRow_Import("ModifiedDateTime") = Format(Now, "dd-MMM-yyyy HH:mm")
                        DsAccountMapping.Tables("MAPPING_CODE_LIST").Rows.Add(dtRow_Import)
                    End If
                Next

                btnSave.PerformClick()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Try
            If DsAccountMapping.Tables("MAPPING_CODE_LIST").Rows.Count > 0 Then
                If ADO.Save_Mapping_Code_List(DsAccountMapping.Tables("MAPPING_CODE_LIST"), Errorlog) Then
                    MsgBox("Successfully save.", MsgBoxStyle.Information)
                Else
                    MsgBox("Failed to save.", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick

        Try
            Dim rslt As DialogResult = MessageBox.Show("Are you sure want to remove item(s)?", "Mapping Code List", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If rslt = Windows.Forms.DialogResult.Yes Then
                Dim ListofID As New List(Of Integer)
                For i As Integer = 0 To GridView1.SelectedRowsCount - 1
                    ListofID.Add(CInt(GridView1.GetDataRow(GridView1.GetSelectedRows(i))("ID")))
                Next

                If ADO.Delete_Mapping_Code_List(ListofID, Errorlog) Then
                    MsgBox("Succesfully remove data.", MsgBoxStyle.Information)
                    Me.LoadData()
                Else
                    MsgBox("Failed to remove data.", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExport.ItemClick
        Try
            Dim Path As String = "D:"

            Dim rslt As DialogResult = FolderBrowserDialog1.ShowDialog
            If rslt = Windows.Forms.DialogResult.OK Then

                If System.IO.File.Exists(FolderBrowserDialog1.SelectedPath & "\Code_Mapping_" & Format(Now, "dd-MMM-yyyy") & ".xlsx") = True Then
                    System.IO.File.Delete(System.IO.File.Exists(FolderBrowserDialog1.SelectedPath & "\Code_Mapping_" & Format(Now, "dd-MMM-yyyy") & ".xlsx"))
                End If

                GridControl1.ExportToXlsx(FolderBrowserDialog1.SelectedPath & "\Code_Mapping_" & Format(Now, "dd-MMM-yyyy") & ".xlsx")
                MsgBox("Export successfully! Info : " & FolderBrowserDialog1.SelectedPath & "\Code_Mapping_" & Format(Now, "dd-MMM-yyyy") & ".xlsx")
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class
