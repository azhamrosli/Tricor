Public Class frmNote 
    Dim clsNote As clsNote_PNL = Nothing
    Dim ErrorLog As ClsError = Nothing

    Public isEdit As Boolean = True
    Public ID As Integer = 1

    Public PNL_KeyName As String = Nothing
    Public PNL_Parent_Key As Integer = 0
    Public PNL_isParent As Boolean = False
    Public PNL_DataID As Integer = 0
    Public PNL_Data_SubID As Integer = 0
    Public PNL_RowDescription As String = Nothing

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TabControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False

    End Sub

    Private Sub frmNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If clsNote Is Nothing Then
                clsNote = New clsNote_PNL
            End If
            If My.Computer.Name = DeveloperPCName Then
                pnlReference.Visible = True
            Else
                pnlReference.Visible = False
            End If
            Me.LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    'Private Sub LoadData()
    '    Try
    '        Dim dt As DataTable = Nothing

    '        dt = clsNote.Load_Note(PNL_Parent_Key, PNL_KeyName, PNL_isParent, PNL_DataID, PNL_Data_SubID, ErrorLog)

    '        dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE_COLUMN").Rows.Clear()
    '        dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE_ATTACHMENT").Rows.Clear()
    '        dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE").Rows.Clear()

    '        txtProfitAndLoss.EditValue = PNL_Parent_Key
    '        txtParentID.EditValue = PNL_DataID
    '        txtParentSubID.EditValue = PNL_Data_SubID
    '        txtDescription.EditValue = PNL_RowDescription

    '        If dt IsNot Nothing Then

    '            For Each rowx As DataRow In dt.Rows
    '                dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE").ImportRow(rowx)
    '            Next

    '        End If

    '        PROFITLOSSACCOUNTNOTEBindingSource.DataSource = dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE")
    '    Catch ex As Exception

    '    End Try
    'End Sub
    Private Sub LoadData()
        Try

            txtProfitAndLoss.EditValue = PNL_Parent_Key
            txtParentID.EditValue = PNL_DataID
            txtParentSubID.EditValue = PNL_Data_SubID
            txtDescription.EditValue = PNL_RowDescription

            Dim dt As DataTable = Nothing


            dt = clsNote.Load_Note(PNL_Parent_Key, PNL_KeyName, PNL_isParent, PNL_DataID, PNL_Data_SubID, ErrorLog)

            dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE_COLUMN").Rows.Clear()
            dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE_ATTACHMENT").Rows.Clear()
            dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE").Rows.Clear()


            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                ID = IIf(IsDBNull(dt.Rows(0)("ID")), 0, dt.Rows(0)("ID"))
                isEdit = True
            Else
                isEdit = False
            End If


            If isEdit Then
                dt = clsNote.Load_Note(ID, ErrorLog)

                dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE").ImportRow(dt.Rows(0))



                Dim dtChild As DataTable = Nothing
                dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE_ATTACHMENT").Rows.Clear()
                dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE_COLUMN").Rows.Clear()
                Select Case IIf(IsDBNull(dt.Rows(0)("TypeNote")), 0, dt.Rows(0)("TypeNote"))
                    Case 2
                        dtChild = clsNote.Load_Note_Attachment(ID, ErrorLog)

                        If dtChild IsNot Nothing Then
                            For Each rowx As DataRow In dtChild.Rows
                                dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE_ATTACHMENT").ImportRow(rowx)
                            Next
                        End If
                    Case 1
                        dtChild = clsNote.Load_Note_Column(ID, ErrorLog)
                        If dtChild IsNot Nothing Then
                            txtCol1.EditValue = IIf(IsDBNull(dtChild.Rows(0)("Col1_Name")), "", dtChild.Rows(0)("Col1_Name"))
                            txtCol2.EditValue = IIf(IsDBNull(dtChild.Rows(0)("Col2_Name")), "", dtChild.Rows(0)("Col2_Name"))
                            txtCol3.EditValue = IIf(IsDBNull(dtChild.Rows(0)("Col3_Name")), "", dtChild.Rows(0)("Col3_Name"))
                            txtCol4.EditValue = IIf(IsDBNull(dtChild.Rows(0)("Col4_Name")), "", dtChild.Rows(0)("Col4_Name"))
                            txtCol5.EditValue = IIf(IsDBNull(dtChild.Rows(0)("Col5_Name")), "", dtChild.Rows(0)("Col5_Name"))
                            txtCol6.EditValue = IIf(IsDBNull(dtChild.Rows(0)("Col6_Name")), "", dtChild.Rows(0)("Col6_Name"))

                            For Each rowx As DataRow In dtChild.Rows
                                dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE_COLUMN").ImportRow(rowx)
                            Next
                        End If
                End Select

                RGTypeNote.SelectedIndex = IIf(IsDBNull(dt.Rows(0)("TypeNote")), 0, dt.Rows(0)("TypeNote"))
                txtTitleNote.EditValue = IIf(IsDBNull(dt.Rows(0)("Title")), "", dt.Rows(0)("Title"))
                txtTitleFrontNote.EditValue = IIf(IsDBNull(dt.Rows(0)("TitleFront")), "", dt.Rows(0)("TitleFront"))
                txtMemo.EditValue = IIf(IsDBNull(dt.Rows(0)("Note")), "", dt.Rows(0)("Note"))

            Else
                Dim dtRow As DataRow = Nothing
                dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE").Rows.Clear()

                dtRow = dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE").NewRow
                dtRow("Title") = "TEST"
                dtRow("Parent_KEY") = PNL_Parent_Key
                dtRow("DataID") = PNL_DataID
                dtRow("Data_SubID") = PNL_Data_SubID
                dtRow("isParent") = PNL_isParent
                dtRow("KeyName") = ""
                dtRow("TypeNote") = 1
                dtRow("Note") = ""
                dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE").Rows.Add(dtRow)
            End If
            PROFITLOSSACCOUNTNOTEATTACHMENTBindingSource.DataSource = dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE_ATTACHMENT")
            PROFITLOSSACCOUNTNOTECOLUMNBindingSource.DataSource = dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE_COLUMN")

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        Finally
            ValidateMultipleAttachment()
        End Try
    End Sub
    Private Sub btnRemove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRemove.ItemClick
        Try
            Dim rlst As DialogResult = MessageBox.Show("Are you sure want to remove this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If rlst = Windows.Forms.DialogResult.Yes Then
                If clsNote.Delete_Note(ID, ErrorLog) Then
                    MsgBox("Succesfully deleted item.", MsgBoxStyle.Information)
                    Me.Close()
                Else
                    MsgBox("Unsuccesfully deleted item.", MsgBoxStyle.Critical)
                End If
                Me.LoadData()
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            Dim rslt As DialogResult = MessageBox.Show("Are you sure want to remove this attachment?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If rslt = Windows.Forms.DialogResult.Yes Then
                GridView2.DeleteSelectedRows()
                dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE_ATTACHMENT").AcceptChanges()
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        Finally
            ValidateMultipleAttachment()

        End Try
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RGTypeNote.SelectedIndexChanged
        Try
            Select Case RGTypeNote.SelectedIndex
                Case 0
                    TabControl.SelectedTabPageIndex = 0
                Case 1
                    TabControl.SelectedTabPageIndex = 2
                Case 2
                    TabControl.SelectedTabPageIndex = 1
            End Select
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Try
            If isValid() Then


                If RGTypeNote.SelectedIndex = 1 Then
                    If dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE_COLUMN").Rows.Count > 0 Then
                        For Each rowx As DataRow In dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE_COLUMN").Rows
                            rowx("Col1_Name") = txtCol1.EditValue
                            rowx("Col2_Name") = txtCol2.EditValue
                            rowx("Col3_Name") = txtCol3.EditValue
                            rowx("Col4_Name") = txtCol4.EditValue
                            rowx("Col5_Name") = txtCol5.EditValue
                            rowx("Col6_Name") = txtCol6.EditValue
                        Next
                    End If
                End If

                If isEdit Then
                    If clsNote.Update_Note(ID, txtTitleFrontNote.EditValue, txtTitleNote.EditValue, PNL_Parent_Key, PNL_DataID, PNL_Data_SubID, PNL_isParent, _
                                           PNL_KeyName, RGTypeNote.SelectedIndex, txtMemo.EditValue, _
                                            dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE_ATTACHMENT"), dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE_COLUMN"), ErrorLog) Then
                        MsgBox("Successfully updated data.", MsgBoxStyle.Information)
                    Else
                        MsgBox("Unsuccesfully update data.", MsgBoxStyle.Critical)
                    End If

                Else
                    Dim tmpID As Integer = 0
                    If clsNote.Save_Note(txtTitleFrontNote.EditValue, txtTitleNote.EditValue, PNL_Parent_Key, PNL_DataID, PNL_Data_SubID, PNL_isParent, _
                                         PNL_KeyName, RGTypeNote.SelectedIndex, txtMemo.EditValue, dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE_ATTACHMENT"), _
                                         dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE_COLUMN"), tmpID, ErrorLog) Then

                        isEdit = True
                        ID = tmpID
                        MsgBox("Successfully saved data.", MsgBoxStyle.Information)

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

            If txtTitleNote.EditValue Is Nothing OrElse txtTitleNote.EditValue = "" Then
                MsgBox("Please enter title note.", MsgBoxStyle.Exclamation)
                Return False
            End If

            Select Case RGTypeNote.SelectedIndex
                Case 0
                    If txtMemo.EditValue Is Nothing OrElse txtMemo.EditValue = "" Then
                        txtMemo.EditValue = " "
                    End If
                Case 2
                    If dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE_ATTACHMENT").Rows.Count = 0 Then
                        MsgBox("Please insert at least one attachment.", MsgBoxStyle.Exclamation)
                        Return False
                    End If
                    txtMemo.EditValue = "Please refer to attachment."

                Case 1
                    If dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE_COLUMN").Rows.Count = 0 Then
                        MsgBox("Please insert at least one data.", MsgBoxStyle.Exclamation)
                        Return False
                    End If
                    txtMemo.EditValue = ""
            End Select
            Return True
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)
            Return False
        End Try
    End Function
    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub GridView2_DoubleClick(sender As Object, e As EventArgs) Handles GridView2.DoubleClick
        Try
            Dim dtRow As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)

            If dtRow IsNot Nothing Then
                Dim frmnote As New frmNote_AttachmentView
                Dim Ext As String = IIf(IsDBNull(dtRow("Extension")), "", dtRow("Extension"))
                Select Case Ext.ToLower
                    Case ".jpg", ".png", ".jpeg", ".bitmap", ".ico", ".gif", ".tif"
                        frmnote.Type = 0
                    Case ".xls", ".xlsx", ".csv", ".openxml"
                        frmnote.Type = 1
                    Case ".doc", "docx", ".rtf", ".wordml", ".opendocument"
                        frmnote.Type = 2
                    Case ".pdf"
                        frmnote.Type = 3
                End Select
                If Ext <> "" Then
                    frmnote.Title = txtTitleNote.EditValue
                    frmnote.Extension = Ext
                    frmnote.dataArr = IIf(IsDBNull(dtRow("Attachment")), Nothing, dtRow("Attachment")) 'Attachment
                    frmnote.Show()
                End If
                
            End If

           
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub GridView2_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView2.InitNewRow
        Try
            GridView2.GetDataRow(e.RowHandle)("ParentID") = dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE").Rows(0)("ID")
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub GridView3_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView3.InitNewRow
        Try
            GridView3.GetDataRow(e.RowHandle)("ParentID") = dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE").Rows(0)("ID")
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub txtCol4_EditValueChanged(sender As Object, e As EventArgs) Handles txtCol1.EditValueChanged, txtCol2.EditValueChanged, _
        txtCol3.EditValueChanged, txtCol4.EditValueChanged, txtCol5.EditValueChanged, txtCol6.EditValueChanged
        Try

            GridView3.Columns("Col1_Val").Caption = IIf(txtCol1.EditValue Is Nothing, " ", txtCol1.EditValue)
            GridView3.Columns("Col2_Val").Caption = IIf(txtCol2.EditValue Is Nothing, " ", txtCol2.EditValue)
            GridView3.Columns("Col3_Val").Caption = IIf(txtCol3.EditValue Is Nothing, " ", txtCol3.EditValue)
            GridView3.Columns("Col4_Val").Caption = IIf(txtCol4.EditValue Is Nothing, " ", txtCol4.EditValue)
            GridView3.Columns("Col5_Val").Caption = IIf(txtCol5.EditValue Is Nothing, " ", txtCol5.EditValue)
            GridView3.Columns("Col6_Val").Caption = IIf(txtCol6.EditValue Is Nothing, " ", txtCol6.EditValue)

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub ValidateMultipleAttachment()
        Try
            If dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE_ATTACHMENT").Rows.Count > 0 Then
                btnAddAttachment.Enabled = False
            Else
                btnAddAttachment.Enabled = True
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub btnAddAttachment_Click(sender As Object, e As EventArgs) Handles btnAddAttachment.Click
        Try
            OpenFileDialog1.Filter = "Files|*.xls;*.xlsx;*.doc;*.docx;*.pdf;*.jpg;*.png;"
            OpenFileDialog1.Multiselect = False
            Dim rslt As DialogResult = OpenFileDialog1.ShowDialog

            If rslt = Windows.Forms.DialogResult.OK Then

                For Each files As String In OpenFileDialog1.FileNames
                    If files IsNot Nothing AndAlso System.IO.File.Exists(files) Then

                        Dim byteData As Byte() = Nothing

                        byteData = ProcessDoctoByte(files)

                        Dim dtRow As DataRow = Nothing

                        dtRow = dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE_ATTACHMENT").NewRow
                        dtRow("ParentID") = ID
                        dtRow("Attachment") = byteData
                        dtRow("Extension") = System.IO.Path.GetExtension(files)

                        dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE_ATTACHMENT").Rows.Add(dtRow)


                        ' System.IO.File.WriteAllBytes("D:\x.pdf", dsDataSet.Tables("PROFIT_LOSS_ACCOUNT_NOTE_ATTACHMENT").Rows(0)("Attachment"))
                    End If
                Next

            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        Finally
            ValidateMultipleAttachment()
        End Try
    End Sub
End Class