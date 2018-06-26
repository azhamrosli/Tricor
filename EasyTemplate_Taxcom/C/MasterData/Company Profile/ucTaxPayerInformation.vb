Public Class ucTaxPayerInformation
    Dim ErrorLog As ClsError = Nothing
    Private Sub ucTaxPayerInformation_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If CreateLookUpTaxPayer(DsDefault, ErrorLog) = False Then
                MsgBox("Unable to retrive tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
        Try
            Dim frm As New frmTaxpayerInformation_Add
            frm.ShowDialog()
            LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

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
            ElseIf Type = 1 Then
                cboRefNo.EditValue = ""
            End If

            Dim dt As DataTable = Nothing

            dt = ADO.LoadTaxPayer(cboRefNo.EditValue, ErrorLog)

            DsDefault.Tables("TAXP_PROFILE").Rows.Clear()

            If dt IsNot Nothing Then

                For Each rowx As DataRow In dt.Rows
                    DsDefault.Tables("TAXP_PROFILE").ImportRow(rowx)
                Next


            End If
            TAXPPROFILEBindingSource.DataSource = DsDefault.Tables("TAXP_PROFILE")
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        Finally
            pnlLoading.Visible = False
        End Try
    End Sub


    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Me.LoadData()
    End Sub

    Private Sub btnAllRecord_Click(sender As Object, e As EventArgs) Handles btnAllRecord.Click
        Try
            cboRefNo.EditValue = ""
            Application.DoEvents()
            Me.LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            btnAllRecord.PerformClick()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Try
            btnEdit.PerformClick()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEdit.ItemClick
        Try
            Dim ID As String = GridView1.GetDataRow(GridView1.GetSelectedRows(0))("TP_REF_NO")

            Dim frm As New frmTaxpayerInformation_Add With {
                .isEdit = True,
                .ID = ID
            }
            frm.ShowDialog()
            Me.LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        Try
            Dim rslt As DialogResult = MessageBox.Show("Are you sure want to remove item(s)?" & vbCrLf & "your data will me lose", "Tax payer information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If rslt = Windows.Forms.DialogResult.Yes Then
                Dim tmpSts As Boolean = True
                For i As Integer = 0 To GridView1.SelectedRowsCount - 1

                    If ADO.Delete_Taxpayer(CInt(GridView1.GetDataRow(GridView1.GetSelectedRows(i))("TP_REF_NO")), ErrorLog) = False Then
                        tmpSts = False
                    End If
                Next

                If tmpSts Then
                    MsgBox("Succesfully remove tax payer information.", MsgBoxStyle.Information)
                    Me.LoadData()
                Else
                    MsgBox("Some of tax payer information failed to delete.", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged
        Try
            Me.LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
End Class
