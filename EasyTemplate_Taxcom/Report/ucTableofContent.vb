Public Class ucTableofContent
    Dim ErrorLog As clsError = Nothing
    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            Dim frm As New frmTableofContent_Add
            frm.ShowDialog()
            Me.LoadData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ucTableofContent_Load(sender As Object, e As EventArgs) Handles Me.Load
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
            pnlLoading.Visible = True
            Application.DoEvents()

            Dim tmpType As Integer = -1

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


            Dim dt As DataTable = mdlProcess.Load_TableofContent_Search(cboRefNo.EditValue, cboYA.EditValue, errorlog)

            DsReport_Templatexsd.Tables("TABLE_CONTENT").Rows.Clear()
            If dt IsNot Nothing Then

                For i As Integer = 0 To dt.Rows.Count - 1
                    DsReport_Templatexsd.Tables("TABLE_CONTENT").ImportRow(dt(i))
                Next

            End If
        Catch ex As Exception

        Finally
            pnlLoading.Visible = False
        End Try
    End Sub
    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            txtRefNo.EditValue = cboRefNo.EditValue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAllRecord_Click(sender As Object, e As EventArgs) Handles btnAllRecord.Click
        Try
            cboRefNo.Text = ""
            cboYA.Text = ""
            LoadData(1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Me.LoadData(2)
    End Sub

   
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            cboRefNo.EditValue = ""
            Me.LoadData(2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            cboYA.EditValue = ""
            Me.LoadData(2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdit.ItemClick
        Try
            Dim ID As Decimal = dgvCA.GetDataRow(dgvCA.GetSelectedRows(0))("TBL_ID")

            Dim frm As New frmTableofContent_Add
            frm.isEdit = True
            frm.ID = ID
            frm.ShowDialog()
            Me.LoadData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvView_DoubleClick(sender As Object, e As EventArgs) Handles dgvView.DoubleClick
        Try
            btnEdit.PerformClick()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            Dim rslt As DialogResult = MessageBox.Show("Are you sure want to remove item(s)?", "Table of content", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If rslt = Windows.Forms.DialogResult.Yes Then
                Dim tmpSts As Boolean = True
                For i As Integer = 0 To dgvCA.SelectedRowsCount - 1

                    If mdlProcess.Delete_TableofContent(CInt(dgvCA.GetDataRow(dgvCA.GetSelectedRows(i))("TBL_ID")), ErrorLog) = False Then
                        tmpSts = False

                    End If
                    'MsgBox(dgvCA.GetDataRow(dgvCA.GetSelectedRows(i))("CA_KEY"))

                Next

                If tmpSts Then
                    MsgBox("Succesfully remove table of content.", MsgBoxStyle.Information)
                    Me.LoadData()
                Else
                    MsgBox("Some of table of content failed to delete.", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
